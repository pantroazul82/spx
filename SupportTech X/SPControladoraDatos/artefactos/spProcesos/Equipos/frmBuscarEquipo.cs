using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.Equipos
{
    public partial class frmBuscarEquipo : Form
    {
        public frmBuscarEquipo()
        {
            InitializeComponent();
            controladorColumnas1.grilla = grdEquipos;
        }

        private bool filtraSoloUbicacionReal = false;
        public bool FiltraSoloUbicacionReal { set { filtraSoloUbicacionReal = value; } get { return filtraSoloUbicacionReal; } }


        private string nitCliente = "";
        public string NitCliente { set { nitCliente = value; } get { return nitCliente; } }

        private string serial = "";
        public string Serial { set { serial = value; } get { return serial; } }

        private bool dispositivosMedicion=false;
        public bool DispositivosMedicion { set { dispositivosMedicion = value; } get { return dispositivosMedicion; } }

        private bool ultimoResponsableVisible = false;
        public bool UltimoResponsableVisible { set { ultimoResponsableVisible = value; } get { return ultimoResponsableVisible; } }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (grdEquipos.Columns["serial"].Text.Trim() == string.Empty)
                return;
            serial = grdEquipos.Columns["serial"].Text.Trim();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmBuscarEquipo_Load(object sender, EventArgs e)
        {
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            if (!ultimoResponsableVisible)
            {
                grdEquipos.Splits[0].DisplayColumns["ultimo_responsable"].Visible = false;
            }
            str += @"\buscarEquipoLayt.xs";
            if (System.IO.File.Exists(str))
            grdEquipos.LoadLayout(str);
            panel1.BackColor = SPControladoraDatos.artefactos.SPXUtilidades.Themes.ThemeManager.verColor();
            cmbFiltros.SelectedIndex = 0;
            //si tiene el nit del cliente signific que solo debe tener en cuenta los equipos del cliente
            if (nitCliente.Trim() != string.Empty) 
            {
                cmbFiltros.Text = "Nit Cliente";
                cmbFiltro2.SelectedIndex = 0;
                cmbFiltros.Enabled = false;
                chkFiltro1.Enabled = false;
                chkFiltro1.Checked =  true;
                chkFiltro2.Checked =  true;
                txtFiltro1.Text = nitCliente.Trim();
                txtFiltro1.ReadOnly = true;
                txtFiltro2.Text = "%";
            }
        }

        private void buscar()
        {
            //realizamos la busqueda primer validamos
            if (!validar()) return;
            dsSpx1.vistaEquipo.Clear();
            string sql = " SELECT  * from vistaEquipo  WHERE ";
            
            string filtros = "";
            if (dispositivosMedicion)
            {
                sql = @"SELECT  vistaEquipo.* from vistaEquipo join equipos on equipos.serial = vistaEquipo.serial join Modelos on equipos.codModelo= modelos.codModelo  and equipos.codFabricante = modelos.codFabricante
 join tipoEquipo on modelos.codTipoEquipo = tipoEquipo.codTipoEquipo";
                filtros = " where (tipoEquipo.dispositivo_medicion is not null and tipoEquipo.dispositivo_medicion=1) ";
            }
            if (chkFiltro1.Checked)
            {
                if (filtros.Trim() != string.Empty)
                {
                    filtros += " AND ";
                }
                filtros += verCampoFiltro(cmbFiltros.Text) + " like '" + txtFiltro1.Text.Trim() + "%'";
            }

            if (chkFiltro2.Checked)
            {
                if (filtros.Trim() != string.Empty)
                {
                    filtros += " AND ";
                }
                filtros += verCampoFiltro(cmbFiltro2.Text) + " like '" + txtFiltro2.Text.Trim() + "%'";
            }

            if (chkFiltro3.Checked)
            {
                if (filtros.Trim() != string.Empty)
                {
                    filtros += " AND ";
                }
                filtros += verCampoFiltro(cmbFiltro3.Text) + " like '" + txtFiltro3.Text.Trim() + "%'";
            }
            
            dsSpx1.vistaEquipo.Clear();
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            dsSpx1.vistaEquipo.Merge(objData.ejecutarConsulta(sql + filtros).Tables[0]);
            System.Media.SystemSounds.Asterisk.Play();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private string verCampoFiltro(string filtro)
        { 
            string res="";
            switch(filtro.Trim()){
                case "Serial": { res = " vistaEquipo.serial "; break; }
                case "Fabricante": { res = " vistaEquipo.nombrefabricante "; break; }
                case "Modelo": { res = " vistaEquipo.nombreModelo "; break; }
                case "Nit Cliente":
                    {
                        if (this.FiltraSoloUbicacionReal)
                            res = " vistaEquipo.nitClienteUbicacionReal ";
                        else res = " vistaEquipo.nitcliente ";
                        break;
                    }
                case "Cliente": { res = " vistaEquipo.nombreCliente "; break; }

        }
        return res;
        }
        
        private bool validar() 
        {
            if (!(chkFiltro1.Checked || chkFiltro2.Checked || chkFiltro3.Checked))
            {
                MessageBox.Show("Debe seleccionar por lo menos un filtro!");
                return false;
            }
            if (chkFiltro1.Checked)
            { 
                if(cmbFiltros.Text.Trim() == string.Empty || txtFiltro1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Debe escoger el campo e ingresar  el texto para el filtro 1");
                    return false;
                }
            }
            if (chkFiltro2.Checked)
            {
                if (cmbFiltro2.Text.Trim() == string.Empty || txtFiltro2.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Debe escoger el campo e ingresar  el texto para el filtro 2");
                    return false;
                }
            }
            if (chkFiltro3.Checked)
            {
                if (cmbFiltro3.Text.Trim() == string.Empty || txtFiltro3.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Debe escoger el campo e ingresar  el texto para el filtro 3");
                    return false;
                }
            }
            return true;
        
        }

        private void txtFiltro2_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltro2.Text.Trim() == string.Empty)
            {
                chkFiltro2.Checked = false;
            }
            else {
                chkFiltro2.Checked = true;
            }
        }

        private void txtFiltro3_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltro3.Text.Trim() == string.Empty)
            {
                chkFiltro3.Checked = false;
            }
            else
            {
                chkFiltro3.Checked = true;
            }
        }

        private void btnInfEquipo_Click(object sender, EventArgs e)
        {
            if (grdEquipos.Columns["serial"].Text.Trim() == string.Empty) return;
            spProcesos.Equipos.frmInformacionEquipo frm = new spProcesos.Equipos.frmInformacionEquipo();
            frm.Serial = grdEquipos.Columns["serial"].Text.Trim();
            frm.ShowDialog();
        }

        private void txtFiltro1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            buscar();
        }

    }
}