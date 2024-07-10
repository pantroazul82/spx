using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace SpFrm.terceros
{
    public partial class frmInfContactoSucursal : Form
    {
        public frmInfContactoSucursal()
        {
            InitializeComponent();
        }

        string nitCliente = "";
        string codContacto = "";
        public string NitCliente { set { nitCliente = value; } get { return nitCliente; } }
        public string CodContacto { set { codContacto = value; } get { return codContacto; } }

        private void frmInfContactoSucursal_Load(object sender, EventArgs e)
        {
            tituloContactoTableAdapter1.Fill(dsSpx1.tituloContacto);
            tipoDocumentoTableAdapter1.Fill(dsSpx1.tipoDocumento);

            panel1.BackColor = SPControladoraDatos.artefactos.SPXUtilidades.Themes.ThemeManager.verColor();
            //cargamos todos los cotactos del cliente
            clientesTableAdapter1.FillByNitCliente(dsSpx1.clientes, nitCliente);
            txtNitCliente.Text = dsSpx1.clientes[0].nitCliente;
            txtcliente.Text = dsSpx1.clientes[0].nombreCliente;
            if (!dsSpx1.clientes[0].IsnumeroSocioNull()) txtNroSocio.Text = dsSpx1.clientes[0].numeroSocio;
            contactosClientesTableAdapter1.FillBynitCliente(dsSpx1.contactosClientes, nitCliente);
            txtApellidos.Text = dsSpx1.contactosClientes[0].apellidosContacto;
            if (!dsSpx1.contactosClientes[0].IscelularNull()) txtCelular.Text = dsSpx1.contactosClientes[0].celular;
            if (!dsSpx1.contactosClientes[0].IscodTipoDocNull()) cmbTipoDocumento.SelectedValue = dsSpx1.contactosClientes[0].codTipoDoc;
            if (!dsSpx1.contactosClientes[0].IscumpleanosNull()) calCumples.Value = dsSpx1.contactosClientes[0].cumpleanos;
            if (!dsSpx1.contactosClientes[0].IsdocContactoNull()) txtDocumento.Text = dsSpx1.contactosClientes[0].docContacto;
            if (!dsSpx1.contactosClientes[0].IsemailNull()) txtEmail.Text = dsSpx1.contactosClientes[0].email;
            if (!dsSpx1.contactosClientes[0].IsfaxNull()) txtFax.Text = dsSpx1.contactosClientes[0].fax;
             txtNombres.Text = dsSpx1.contactosClientes[0].nombreContacto;
            if (!dsSpx1.contactosClientes[0].IspaginaWebNull()) txtPaginaWeb.Text = dsSpx1.contactosClientes[0].paginaWeb;
             txtTelefono.Text = dsSpx1.contactosClientes[0].telefono1;
            if (!dsSpx1.contactosClientes[0].Istelefono2Null()) txtTelefono2.Text = dsSpx1.contactosClientes[0].telefono2;
            if (!dsSpx1.contactosClientes[0].IstituloContactoNull()) cmbTituloContacto.SelectedValue = dsSpx1.contactosClientes[0].tituloContacto;
            //
            vistaSucursalTableAdapter1.FillByNitClienteCodContacto(dsSpx1.vistaSucursal,nitCliente,codContacto);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnInfEquipo_Click(object sender, EventArgs e)
        {
            if (grdSucursales.Columns["codSucursal"].Text.Trim() == string.Empty) return;
            frmInfSucursal fr = new frmInfSucursal();
            fr.NitCliente = nitCliente;
            fr.CodSucursal = grdSucursales.Columns["codSucursal"].Text;
            fr.ShowDialog();
        }
    }
}
