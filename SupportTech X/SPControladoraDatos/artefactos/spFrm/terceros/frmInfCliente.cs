using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace SpFrm.terceros
{
    public partial class frmInfCliente : Form
    {
        public frmInfCliente()
        {
            InitializeComponent();
        }
        public string nitCliente = "";
        public string NitCliente { set { nitCliente = value; } get { return nitCliente; } }

        private void frmInfCliente_Load(object sender, EventArgs e)
        {
            panel1.BackColor = SPControladoraDatos.artefactos.SPXUtilidades.Themes.ThemeManager.verColor();
            tipoDocumentoTableAdapter1.Fill(dsSpx1.tipoDocumento);
            tituloContactoTableAdapter1.Fill(dsSpx1.tituloContacto);
            clientesTableAdapter1.FillByNitCliente(dsSpx1.clientes, nitCliente);
            vistaSucursalTableAdapter1.FillByNitCliente(dsSpx1.vistaSucursal, nitCliente);
            contactosClientesTableAdapter1.FillBynitCliente(dsSpx1.contactosClientes, nitCliente);
            //cargamos la informacion del cliente
            if (!dsSpx1.clientes[0].IscodTipoDocNull()) cmbtipoDocumento.SelectedValue = dsSpx1.clientes[0].codTipoDoc;
            if (!dsSpx1.clientes[0].IstituloContactoNull()) cmbTituloContacto.SelectedValue = dsSpx1.clientes[0].tituloContacto;
            if (!dsSpx1.clientes[0].IsapellidosContactoNull()) txtApellidos.Text = dsSpx1.clientes[0].apellidosContacto;
            if (!dsSpx1.clientes[0].IscelularNull()) txtCelular.Text = dsSpx1.clientes[0].celular;
            if (!dsSpx1.clientes[0].IsemailNull()) txtEmail.Text = dsSpx1.clientes[0].email;
            if (!dsSpx1.clientes[0].IsfaxNull()) txtFax.Text = dsSpx1.clientes[0].fax;
                txtNit.Text = dsSpx1.clientes[0].nitCliente;
                txtNombreCliente.Text = dsSpx1.clientes[0].nombreCliente;
            if (!dsSpx1.clientes[0].IsnombreContactoPrincipalNull()) txtNombres.Text = dsSpx1.clientes[0].nombreContactoPrincipal;
            if (!dsSpx1.clientes[0].IsdocContactoNull()) txtNroDocumento.Text = dsSpx1.clientes[0].docContacto;
            if (!dsSpx1.clientes[0].Istelefono1Null()) txtTelefono1.Text = dsSpx1.clientes[0].telefono1;
            if (!dsSpx1.clientes[0].Istelefono2Null()) txtTelefono2.Text = dsSpx1.clientes[0].telefono2;
            if (!dsSpx1.clientes[0].IsnumeroSocioNull()) txtNroSocio.Text = dsSpx1.clientes[0].numeroSocio;
            //cargar el logotipo
            if (!dsSpx1.clientes[0].IslogotipoNull()) 
            {
                byte[] arr = dsSpx1.clientes[0].logotipo;
                System.IO.MemoryStream ms = new System.IO.MemoryStream(arr);
                System.Drawing.Image im = System.Drawing.Image.FromStream(ms);
                picLogo.Image = im;
            }
        }

        private void btnInfEquipo_Click(object sender, EventArgs e)
        {
            if (grdSucursales.Columns["codSucursal"].Text.Trim() == string.Empty) return;
            SpFrm.terceros.frmInfSucursal fr = new frmInfSucursal();
            fr.NitCliente = nitCliente;
            fr.CodSucursal = grdSucursales.Columns["codSucursal"].Text;
            fr.ShowDialog();
        }

        private void btnInfContactos_Click(object sender, EventArgs e)
        {
            if (grdContactos.Columns["codContacto"].Text.Trim() == string.Empty) return;
            SpFrm.terceros.frmInfContactoSucursal fr = new frmInfContactoSucursal();
            fr.NitCliente = nitCliente;
            fr.CodContacto = grdContactos.Columns["codContacto"].Text;
            fr.ShowDialog();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
