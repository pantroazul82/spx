using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.generales
{
    public partial class frmContactos : Form
    {
        public frmContactos()
        {
            InitializeComponent();
        }

        string nitCliente = "";
        string codigoContacto = "";
        public string NitCliente { set { nitCliente = value; } get { return nitCliente; } }
        public string CodContacto { set { codigoContacto = value; } get { return codigoContacto; } }
        private bool consultando = false;
        public bool Consultando { set { consultando = value; } get { return consultando; } }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!validar()) return;
            if (!consultando)
            {
                if (codigoContacto == string.Empty)
                { //nuevo
                    contactosClientesTableAdapter1.Insert(
                        nitCliente, txtCodigoContacto.Text, txtNombres.Text, txtApellidos.Text,
                        txtDocumento.Text, cmbTipoDocumento.SelectedValue.ToString(), cmbTituloContacto.SelectedValue.ToString(),
                        txtTelefono.Text, txtTelefono2.Text, txtCelular.Text, txtEmail.Text, txtPaginaWeb.Text,
                        calCumples.Value, txtFax.Text,true,txtCargo.Text);
                }
                else
                {
                    contactosClientesTableAdapter1.UpdateContacto(txtNombres.Text, txtApellidos.Text, txtDocumento.Text,
                        cmbTipoDocumento.SelectedValue.ToString(), cmbTituloContacto.SelectedValue.ToString(), txtTelefono.Text,
                        txtTelefono2.Text, txtCelular.Text, txtEmail.Text, txtPaginaWeb.Text,
                        calCumples.Value, txtFax.Text,txtCargo.Text, nitCliente, txtCodigoContacto.Text);
                }
            }
            DialogResult = DialogResult.OK;
            Close();
        }
        private bool validar() 
        {
            if (txtCodigoContacto.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Error el codigo es obligatorio");
                txtCodigoContacto.Focus();
                return false;
            }
            if (txtNombres.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Error el nombre es obligatorio");
                txtNombres.Focus();
                return false;
            }
            return true;
        
        }

        private void frmContactos_Load(object sender, EventArgs e)
        {
            panel1.BackColor = SPControladoraDatos.artefactos.SPXUtilidades.Themes.ThemeManager.verColor();
            tipoDocumentoTableAdapter1.Fill(dsSpx1.tipoDocumento);
            tituloContactoTableAdapter1.Fill(dsSpx1.tituloContacto);
            if (codigoContacto != string.Empty)
            {
                contactosClientesTableAdapter1.FillBycodContactoNit(dsSpx1.contactosClientes, nitCliente, codigoContacto);
                if (dsSpx1.contactosClientes.Rows.Count > 0)
                {
                    txtApellidos.Text = dsSpx1.contactosClientes[0].apellidosContacto.Trim();
                    txtCelular.Text = dsSpx1.contactosClientes[0].celular.Trim();
                    txtCodigoContacto.Text = dsSpx1.contactosClientes[0].codContacto.Trim();
                    txtCodigoContacto.ReadOnly = true;
                    txtDocumento.Text = dsSpx1.contactosClientes[0].docContacto.Trim();
                    txtEmail.Text = dsSpx1.contactosClientes[0].email.Trim();
                    txtFax.Text = dsSpx1.contactosClientes[0].fax.Trim();
                    txtNombres.Text = dsSpx1.contactosClientes[0].nombreContacto.Trim();
                    txtPaginaWeb.Text = dsSpx1.contactosClientes[0].paginaWeb.Trim();
                    txtTelefono.Text = dsSpx1.contactosClientes[0].telefono1.Trim();
                    txtTelefono2.Text = dsSpx1.contactosClientes[0].telefono2.Trim();

                    if (!dsSpx1.contactosClientes[0].IscargoNull())
                    txtCargo.Text = dsSpx1.contactosClientes[0].cargo.Trim();
                    
                    if (!dsSpx1.contactosClientes[0].IstituloContactoNull())
                    cmbTituloContacto.SelectedValue = dsSpx1.contactosClientes[0].tituloContacto.Trim();

                    if (!dsSpx1.contactosClientes[0].IscodTipoDocNull())
                    cmbTipoDocumento.SelectedValue = dsSpx1.contactosClientes[0].codTipoDoc;
                    calCumples.Value = dsSpx1.contactosClientes[0].cumpleanos;
                    if (consultando)
                    {
                        txtApellidos.ReadOnly = true;
                        txtCelular.ReadOnly = true;
                        txtCodigoContacto.ReadOnly = true;
                        txtDocumento.ReadOnly = true;
                        txtEmail.ReadOnly = true;
                        txtFax.ReadOnly = true;
                        txtNombres.ReadOnly = true;
                        txtPaginaWeb.ReadOnly = true;
                        txtTelefono.ReadOnly = true;
                        txtTelefono2.ReadOnly = true;
                        cmbTituloContacto.Enabled = true;
                        cmbTipoDocumento.Enabled = false;
                        calCumples.Enabled = false;

                    }
                }
            }
            else {
                txtCodigoContacto.Text = contactosClientesTableAdapter1.verNextId(nitCliente).ToString();
            }
            txtCodigoContacto.Enabled = false;
        }

        private void txtFax_TextChanged(object sender, EventArgs e)
        {

        }
    }
}