using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.contratos_consumo
{
    public partial class frmNuevoEquipoModelo : Form
    {
        public frmNuevoEquipoModelo()
        {
            InitializeComponent();
        }

        public string Nitcliente { set; get; }
        public int codContratoConsumo { set; get; }
        public int codDetalle { set; get; }

        private void cmbFabricante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbFabricante.SelectedValue == null || cmbFabricante.SelectedValue.ToString().Trim() == string.Empty)
            {
                dsSpx1.Modelos.Clear();
                return;
            }
            modelosTableAdapter1.FillBycodFabricante(dsSpx1.Modelos, cmbFabricante.SelectedValue.ToString());

        }

        private void frmNuevoEquipoModelo_Load(object sender, EventArgs e)
        {
            fabricanteTableAdapter1.Fill(dsSpx1.fabricante);
            if (codDetalle != 0)
            {
                SPControladoraDatos.dsContratoConsumo ds=new SPControladoraDatos.dsContratoConsumo();
                equiposxcontrato_consumoTableAdapter1.FillBycod_equiposxcontrato_consumo(ds.equiposxcontrato_consumo, codDetalle);
                rdOtro.Checked = ds.equiposxcontrato_consumo[0].IscodFabricanteNull() || ds.equiposxcontrato_consumo[0].codFabricante.Trim() == string.Empty;
                rdEquipo.Checked = !(ds.equiposxcontrato_consumo[0].IscodFabricanteNull() || ds.equiposxcontrato_consumo[0].codFabricante.Trim() == string.Empty);
            
                if (rdEquipo.Checked)
                {
                    if (!ds.equiposxcontrato_consumo[0].IsserialNull())
                    txtSerial.Text = ds.equiposxcontrato_consumo[0].serial;
                    equiposTableAdapter1.FillBySerial(dsSpx1.equipos, txtSerial.Text.Trim());
                    cmbFabricante.SelectedValue = ds.equiposxcontrato_consumo[0].codFabricante.Trim();
                    modelosTableAdapter1.FillBycodFabricante(dsSpx1.Modelos, cmbFabricante.SelectedValue.ToString());
                    cmbModelo.SelectedValue = ds.equiposxcontrato_consumo[0].codModelo.Trim();
                    
                }
                if (!ds.equiposxcontrato_consumo[0].Isdescripcion_software_incluidoNull())
                txtDescripcion.Text = ds.equiposxcontrato_consumo[0].descripcion_software_incluido;
                
                if (!ds.equiposxcontrato_consumo[0].Ispertenece_annarNull())
                chkPropiedadAnnar.Checked = ds.equiposxcontrato_consumo[0].pertenece_annar;

                if (!ds.equiposxcontrato_consumo[0].Isconectado_softwareNull())
                    chkConectado.Checked = ds.equiposxcontrato_consumo[0].conectado_software;
                actualizarEstadoControles();
            }
        }

        private void rdEquipo_CheckedChanged(object sender, EventArgs e)
        {
            actualizarEstadoControles();
        }

        private void rdOtro_CheckedChanged(object sender, EventArgs e)
        {
            actualizarEstadoControles();
        }

        private void actualizarEstadoControles() 
        {
            cmbFabricante.Enabled = rdEquipo.Checked && txtSerial.Text.Trim() == string.Empty;
            cmbModelo.Enabled = rdEquipo.Checked && txtSerial.Text.Trim() == string.Empty;
            btnBuscarEquipo.Enabled = rdEquipo.Checked;
           
        }

        private void btnBuscarEquipo_Click(object sender, EventArgs e)
        {
            spProcesos.Equipos.frmBuscarEquipo fr = new Equipos.frmBuscarEquipo();
            fr.NitCliente = this.Nitcliente;
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            { 
                equiposTableAdapter1.FillBySerial(dsSpx1.equipos,fr.Serial);
                txtSerial.Text = dsSpx1.equipos[0].serial.Trim();
                cmbFabricante.SelectedValue = dsSpx1.equipos[0].codFabricante.Trim();
                modelosTableAdapter1.FillBycodFabricante(dsSpx1.Modelos, cmbFabricante.SelectedValue.ToString());
                cmbModelo.SelectedValue = dsSpx1.equipos[0].codModelo.Trim();
                cmbFabricante.Enabled = false;
                cmbModelo.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
         
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public List<string> serialesIngresados = new List<string>();

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (codDetalle !=0)
            {
                equiposxcontrato_consumoTableAdapter1.UpdateQuery(
                rdEquipo.Checked ? cmbFabricante.SelectedValue.ToString() : null,
                rdEquipo.Checked ? cmbModelo.SelectedValue.ToString() : null,
                          rdEquipo.Checked && txtSerial.Text.Trim() != string.Empty ? txtSerial.Text.Trim() : null,
                dsSpx1.equipos.Count > 0 ? dsSpx1.equipos[0].codSucursalUbica : null,
                txtDescripcion.Text,chkPropiedadAnnar.Checked,chkConectado.Checked, codDetalle);
            }else{

                if(serialesIngresados.Contains(txtSerial.Text.Trim()))
                {
                    MessageBox.Show("Serial ya ingresado");
                    return;
                }


               equiposxcontrato_consumoTableAdapter1.Insert(codContratoConsumo,
                rdEquipo.Checked?cmbFabricante.SelectedValue.ToString():null,
                rdEquipo.Checked?cmbModelo.SelectedValue.ToString():null,
                rdEquipo.Checked && txtSerial.Text.Trim() != string.Empty? txtSerial.Text.Trim() : null,
                dsSpx1.equipos.Count>0?dsSpx1.equipos[0].codSucursalUbica:null,
                dsSpx1.equipos.Count>0?dsSpx1.equipos[0].nitClienteUbica:null,
                txtDescripcion.Text,chkPropiedadAnnar.Checked,chkConectado.Checked);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

      
    }
}
