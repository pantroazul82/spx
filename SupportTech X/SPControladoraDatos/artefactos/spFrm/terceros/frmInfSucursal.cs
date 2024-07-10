using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace SpFrm.terceros
{
    public partial class frmInfSucursal : Form
    {
        public frmInfSucursal()
        {
            InitializeComponent();
        }

        string nitCliente = "";
        string codSucursal = "";
        public string NitCliente { set { nitCliente = value; } get { return nitCliente; } }
        public string CodSucursal { set { codSucursal = value; } get { return codSucursal; } }


        private void frmInfSucursal_Load(object sender, EventArgs e)
        {
            panel1.BackColor = SPControladoraDatos.artefactos.SPXUtilidades.Themes.ThemeManager.verColor();
            clientesTableAdapter1.FillByNitCliente(dsSpx1.clientes, nitCliente);
            //CARGAMOS LA informacion de la sucursal
            txtNitCliente.Text = nitCliente;
            txtcliente.Text = dsSpx1.clientes[0].nombreCliente;
            if (!dsSpx1.clientes[0].IsnumeroSocioNull()) txtNroSocio.Text = dsSpx1.clientes[0].numeroSocio;
            //cargamos la informacion de la vista de la sucursal
            if (codSucursal == string.Empty) {
                MessageBox.Show("No selecciono ninguna sucursal");
                return;
            }
            vistaSucursalTableAdapter1.FillByNitClienteCodSucursal(dsSpx1.vistaSucursal, nitCliente, codSucursal);
            txtNombreSucursal.Text = dsSpx1.vistaSucursal[0].nombreSucursal;
            txtPais.Text = dsSpx1.vistaSucursal[0].nombrePais;
            txtDepartamento.Text = dsSpx1.vistaSucursal[0].NombreDepartamento;
            txtCiudad.Text = dsSpx1.vistaSucursal[0].nombreCiudad;
            if (!dsSpx1.vistaSucursal[0].IsTelefono1Null()) txtTelefono.Text = dsSpx1.vistaSucursal[0].Telefono1;
            if (!dsSpx1.vistaSucursal[0].IsTelefono2Null()) txtTelefono2.Text = dsSpx1.vistaSucursal[0].Telefono2;
            if (!dsSpx1.vistaSucursal[0].IsDireccionNull()) txtDireccion.Text = dsSpx1.vistaSucursal[0].Direccion;
            //vistaSucursalTableAdapter1
            if (!dsSpx1.vistaSucursal[0].IscodContactoNull())
            {
                contactosClientesTableAdapter1.FillBycodContactoNit(dsSpx1.contactosClientes, nitCliente, dsSpx1.vistaSucursal[0].codContacto);
                if (dsSpx1.contactosClientes.Count > 0)
                {
                    tipoDocumentoTableAdapter1.Fill(dsSpx1.tipoDocumento);
                    tituloContactoTableAdapter1.Fill(dsSpx1.tituloContacto);
                    txtNombres.Text = dsSpx1.contactosClientes[0].nombreContacto;
                    txtDocumento.Text = dsSpx1.contactosClientes[0].docContacto;
                     txtApellidos.Text = dsSpx1.contactosClientes[0].apellidosContacto;
                     txtTelefonoContacto.Text = dsSpx1.contactosClientes[0].telefono1;
                     if (!dsSpx1.contactosClientes[0].Istelefono2Null()) txtTelefonoContactoAlterna.Text = dsSpx1.contactosClientes[0].telefono2;
                     if (!dsSpx1.contactosClientes[0].IsemailNull()) txtEmail.Text = dsSpx1.contactosClientes[0].email;
                     if (!dsSpx1.contactosClientes[0].IsfaxNull()) txtFax.Text = dsSpx1.contactosClientes[0].fax;
                     if (!dsSpx1.contactosClientes[0].IscelularNull()) txtCelular.Text = dsSpx1.contactosClientes[0].celular;
                     if (!dsSpx1.contactosClientes[0].IscodTipoDocNull()) cmbTipoDocumento.SelectedValue = dsSpx1.contactosClientes[0].codTipoDoc;
                    if (!dsSpx1.contactosClientes[0].IstituloContactoNull()) cmbTituloContacto.SelectedValue = dsSpx1.contactosClientes[0].tituloContacto;
                }
            }
            //dsSpx1.vistaSucursal[0].cods
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnInfContacto_Click(object sender, EventArgs e)
        {
            if (dsSpx1.contactosClientes.Count < 0) return;
            frmInfContactoSucursal fr = new frmInfContactoSucursal();
            fr.NitCliente = nitCliente;

            fr.CodContacto = dsSpx1.contactosClientes[0].codContacto;
            fr.ShowDialog();
        }
    }
}
