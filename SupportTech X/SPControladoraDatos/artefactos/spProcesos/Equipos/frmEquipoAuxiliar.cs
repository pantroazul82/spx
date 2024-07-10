using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.Equipos
{
    public partial class frmEquipoAuxiliar : Form
    {
        public frmEquipoAuxiliar()
        {
            InitializeComponent();
        }

        private string serialEquipo = "";
        private string serialAuxiliar = "";
//--
        public string SerialEquipo { set { serialEquipo = value; } get { return serialEquipo; } }
        public string SerialAuxiliar { set { serialAuxiliar = value; } get { return serialAuxiliar; } }

        //nit cliente
        //codUbicacion del equipo principal
        string nitCliente = "";
        string codUbicacion = "";


        private void btnCAncelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void frmEquipoAuxiliar_Load(object sender, EventArgs e)
        {
            //
            txtSerial.Text = serialEquipo;
            equiposTableAdapter1.FillBySerial(dsSpx1.equipos, serialEquipo);
            
            if (dsSpx1.equipos.Rows.Count > 0)
            {
                nitCliente = dsSpx1.equipos[0].nitClienteUbica;
                codUbicacion = dsSpx1.equipos[0].codSucursalUbica;
            }

            if (serialAuxiliar.Trim() != string.Empty) 
            {
                txtSerialAuxiliar.Text = serialAuxiliar;
                txtSerialAuxiliar.ReadOnly = true;
                btnBuscarAux.Enabled = false;
                cargarInformacionAdicional();
                //cargamos la info de la base de datos
                equipoAuxiliarTableAdapter1.FillByserialAuxiliarSerialEquipo(dsSpx1.equipoAuxiliar,
                    serialEquipo, serialAuxiliar);
                if (dsSpx1.equipoAuxiliar.Rows.Count > 0)
                {
                    txtDescripcionAuxiliar.Text = dsSpx1.equipoAuxiliar[0].Observaciones;
                }
            }
        }

        private void cargarInformacionAdicional() 
        {
            vistaEquipoTableAdapter1.FillBySerial(dsSpx1.vistaEquipo, txtSerialAuxiliar.Text);
            if (dsSpx1.vistaEquipo.Rows.Count > 0)
            {
                txtModelo.Text = dsSpx1.vistaEquipo[0].nombremodelo;
                txtFabricante.Text = dsSpx1.vistaEquipo[0].nombrefabricante;
                txtModalidad.Text = dsSpx1.vistaEquipo[0].nombremodalidadequipo;
                txtSubtipo.Text=dsSpx1.vistaEquipo[0].nombresubtipo;
                txtTipoEquipo.Text = dsSpx1.vistaEquipo[0].nombretipoequipo;
            }
            

        }

        private bool validar() 
        {
            if (txtSerialAuxiliar.Text.Trim() == string.Empty)
            {
                MessageBox.Show("el serial auxiliar es obligatorio");
                return false;
            }
            if (serialAuxiliar.Trim() == string.Empty) 
            {//si es nuevo verificamos que no exista ya
                equipoAuxiliarTableAdapter1.FillByserialAuxiliarSerialEquipo(dsSpx1.equipoAuxiliar, serialEquipo,
                    txtSerialAuxiliar.Text);
                if (dsSpx1.equipoAuxiliar.Rows.Count > 0)
                {
                    MessageBox.Show("Este equipo ya fue asociado como equipo auxiliar de este previamente.");
                    return false;
                }
            
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!validar()) return;
            //miramos si insertamos o si actualizams
            if (serialAuxiliar.Trim() == string.Empty)
            {
                equipoAuxiliarTableAdapter1.Insert(serialEquipo.Trim(), txtSerialAuxiliar.Text.Trim(), txtDescripcionAuxiliar.Text);
            }
            else {
                equipoAuxiliarTableAdapter1.UpdateQuery(txtDescripcionAuxiliar.Text, serialEquipo, serialAuxiliar);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void txtSerialAuxiliar_Validating(object sender, CancelEventArgs e)
        {
            if (txtSerialAuxiliar.Text.Trim() == string.Empty) return;
            equiposTableAdapter1.FillBySerial(dsSpx1.equipos, txtSerialAuxiliar.Text);
            if (txtSerial.Text.Trim() == txtSerialAuxiliar.Text.Trim()) 
            {
                MessageBox.Show("El serial del equipo auxiliar no puede ser el mismo que el serial del equipo principal");
                txtSerialAuxiliar.Focus();
                return;
            }
            if (dsSpx1.equipos.Rows.Count <= 0)
            {
                MessageBox.Show("El serial auxiliar Ingresado no existe");
                txtSerialAuxiliar.Focus();
            }else { //miramos que aparte de que exista sea del mismo cliente y ubicacion

                if (dsSpx1.equipos[0].nitClienteUbica.Trim() != nitCliente.Trim())
                {
                    MessageBox.Show("El serial Ingresado no esta ubicado en el mismo cliente del Equipo principal");
                    txtSerialAuxiliar.Focus();
                }
                if (dsSpx1.equipos[0].codSucursalUbica.Trim() != codUbicacion.Trim())
                {
                    MessageBox.Show("El serial Ingresado no esta en la misma ubicacion del Equipo principal");
                    txtSerialAuxiliar.Focus();
                }
            }

            cargarInformacionAdicional();
        }

        private void btnInfEquipo_Click(object sender, EventArgs e)
        {
            if (txtSerialAuxiliar.Text.Trim() == string.Empty) return;
            Equipos.frmInformacionEquipo objfm = new frmInformacionEquipo();
            objfm.Serial = txtSerialAuxiliar.Text;
            objfm.ShowDialog();
        }

        private void btnBuscarAux_Click(object sender, EventArgs e)
        {
            //buscar todos los equipos qeu sean del mismo cliente
            Equipos.frmBuscarEquipo objFrm = new frmBuscarEquipo();
            objFrm.NitCliente = nitCliente;
            if (objFrm.ShowDialog() == DialogResult.OK)
            {
                txtSerialAuxiliar.Text = objFrm.Serial;
                cargarInformacionAdicional();
            }
        }
    }
}
