using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.generales
{
    public partial class frmSucursales : Form
    {
        public frmSucursales()
        {
            InitializeComponent();
        }
        bool validando = true;
        //
        bool consultando = false;
        bool creando = true;
        bool modificando = false;
        string codigoSucursal = "";
        string nitCliente = "";
        string codigoContactoOriginal = "";
        string codigoContactoNuevo = "";

        //--
        private void reset(){
            consultando = false;
            creando = false;
            modificando = false;
        }
        public bool Consultando { set { reset(); consultando = value; } get { return consultando; } }
        public bool Creando { set { reset(); creando = value; } get { return creando; } }
        public bool Modificando { set { reset(); modificando = value; } get { return modificando; } }
        public string CodigoSucursal { set { codigoSucursal = value; } get { return codigoSucursal; } }
        public string NitCliente { set { nitCliente = value; } get { return nitCliente; } }


        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPais.SelectedValue != null && validando)
            {
                departamentoTableAdapter1.FillByCodigoPais(dsSpx1.departamento,cmbPais.SelectedValue.ToString());
            }
        }

        private void frmSucursales_Load(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            panel1.BackColor = SPControladoraDatos.artefactos.SPXUtilidades.Themes.ThemeManager.verColor();
            validando = false;
            paisesTableAdapter1.Fill(dsSpx1.paises);
            cmbPais.SelectedValue = "COL";
            if (cmbPais.SelectedValue != null && cmbPais.SelectedValue.ToString().Trim() != string.Empty)
            {
                departamentoTableAdapter1.FillByCodigoPais(dsSpx1.departamento, cmbPais.SelectedValue.ToString());
            }
            if (cmbDepartamento.SelectedValue != null && cmbDepartamento.SelectedValue.ToString().Trim() != string.Empty)
            {
                ciudadesTableAdapter1.FillByCodPaisCodDepartamento(dsSpx1.ciudades, cmbPais.SelectedValue.ToString(),cmbDepartamento.SelectedValue.ToString().Trim());
            }
            //
            tipoDocumentoTableAdapter1.Fill(dsSpx1.tipoDocumento);
            contactosClientesTableAdapter1.FillBynitCliente(dsSpx2.contactosClientes,nitCliente);
            contactosClientesTableAdapter1.FillByCodSucursalNit(dsSpx1.contactosClientes,nitCliente,codigoSucursal);
            //si la sucursal no tiene contacto elije el contaco por defecto del cliente
            if (dsSpx1.contactosClientes.Rows.Count <= 0)
            {
                clientesTableAdapter1.FillByNitCliente(dsSpx1.clientes, nitCliente);

                SPControladoraDatos.dsSpx.contactosClientesRow fila = dsSpx1.contactosClientes.NewcontactosClientesRow();

                fila.nitCliente=nitCliente.Trim();
                fila.codContacto="0";
                fila.nombreContacto= dsSpx1.clientes[0].IsnombreContactoPrincipalNull() ? "" : dsSpx1.clientes[0].nombreContactoPrincipal.Trim();
                fila.apellidosContacto=dsSpx1.clientes[0].IsapellidosContactoNull() ? "" : dsSpx1.clientes[0].apellidosContacto.Trim();
                fila.docContacto=dsSpx1.clientes[0].IsdocContactoNull()?"":dsSpx1.clientes[0].docContacto;
                fila.codTipoDoc=     dsSpx1.tipoDocumento[0].ToString();
                fila.tituloContacto=dsSpx1.clientes[0].IstituloContactoNull()?null:dsSpx1.clientes[0].tituloContacto[0].ToString();
                fila.telefono1= dsSpx1.clientes[0].Istelefono1Null()?"":dsSpx1.clientes[0].telefono1.Trim();
                fila.telefono2=dsSpx1.clientes[0].Istelefono2Null() ? "" : dsSpx1.clientes[0].telefono2.Trim();
                fila.celular= dsSpx1.clientes[0].IscelularNull() ? "" : dsSpx1.clientes[0].celular.Trim();
                fila.email=dsSpx1.clientes[0].IsemailNull() ? "" : dsSpx1.clientes[0].email.Trim();
                fila.fax=dsSpx1.clientes[0].IsfaxNull() ? "" : dsSpx1.clientes[0].fax.Trim();
                fila.es_activo=true;
                fila.paginaWeb = "p";
                fila.cumpleanos = n;
                fila.cargo = "";
                dsSpx1.contactosClientes.AddcontactosClientesRow(fila);
            }else{
                codigoContactoOriginal = dsSpx1.contactosClientes[0].codContacto;
                codigoContactoNuevo= dsSpx1.contactosClientes[0].codContacto;
            }

            if (!creando)
            {
                sucursalClienteTableAdapter1.FillByCodSucursalNit(dsSpx1.sucursalCliente, nitCliente, codigoSucursal);
                if (dsSpx1.sucursalCliente.Rows.Count <= 0)
                    return;
                cmbPais.SelectedValue = dsSpx1.sucursalCliente[0].codPais;
                departamentoTableAdapter1.FillByCodigoPais(dsSpx1.departamento, cmbPais.SelectedValue.ToString());
                cmbDepartamento.SelectedValue = dsSpx1.sucursalCliente[0].codDepartamento;
                ciudadesTableAdapter1.FillByCodPaisCodDepartamento(dsSpx1.ciudades, cmbPais.SelectedValue.ToString(), cmbDepartamento.SelectedValue.ToString());
                cmbCiudad.SelectedValue = dsSpx1.sucursalCliente[0].codCiudad;
                txtCodigoSucursal.Text = codigoSucursal;
                txtDireccion.Text = dsSpx1.sucursalCliente[0].IsDireccionNull() ? "" : dsSpx1.sucursalCliente[0].Direccion.Trim();
                txtNombreSucursal.Text = dsSpx1.sucursalCliente[0].IsnombreSucursalNull() ? "" : dsSpx1.sucursalCliente[0].nombreSucursal.Trim();
                txtTelefono.Text = dsSpx1.sucursalCliente[0].IsTelefono1Null() ? "" : dsSpx1.sucursalCliente[0].Telefono1.Trim();
                txtTelefono2.Text = dsSpx1.sucursalCliente[0].IsTelefono2Null() ? "" : dsSpx1.sucursalCliente[0].Telefono2.Trim();
                txtCodigoSucursal.ReadOnly = true;
                if (consultando)
                {
                    #region
                    cmbPais.Enabled = false;
                    cmbDepartamento.Enabled = false;
                    cmbCiudad.Enabled = false;
                    txtDireccion.ReadOnly = true;
                    txtNombreSucursal.ReadOnly = true;
                    txtTelefono.ReadOnly = true;
                    txtTelefono2.ReadOnly = true;
                    btnSeleccionar.Visible = false;
                    btnAceptar.Visible = false;
                    btnAgergarContacto.Visible = false;
                    btnConsultar.Visible = false;
                    btnModificarContacto.Visible = false;
                    btnSeleccionar.Visible = false;
                    #endregion
                }
            }else {
                try
                {
                    codigoSucursal = sucursalClienteTableAdapter1.verNextId(nitCliente).ToString();
                    txtCodigoSucursal.Text = codigoSucursal;
                    txtCodigoSucursal.ReadOnly = true;
                }catch(Exception){}
            }
            validando = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            if (grdDatos.FirstDisplayedCell != null)
            {
                dsSpx1.contactosClientes.Rows.Clear();
                codigoContactoNuevo = grdDatos["codContacto", grdDatos.CurrentCell.RowIndex].Value.ToString();
                SPControladoraDatos.dsSpx.contactosClientesRow fila=   dsSpx1.contactosClientes.NewcontactosClientesRow();
                fila.apellidosContacto =(grdDatos["apellidosContactoDataGridViewTextBoxColumn", grdDatos.CurrentCell.RowIndex].Value == null) ? "" : grdDatos["apellidosContactoDataGridViewTextBoxColumn", grdDatos.CurrentCell.RowIndex].Value.ToString();
                fila.celular=(grdDatos["celularDataGridViewTextBoxColumn", grdDatos.CurrentCell.RowIndex].Value == null) ? "" : grdDatos["celularDataGridViewTextBoxColumn", grdDatos.CurrentCell.RowIndex].Value.ToString();
                fila.codContacto =(grdDatos["codContacto", grdDatos.CurrentCell.RowIndex].Value == null) ? "" : grdDatos["codContacto", grdDatos.CurrentCell.RowIndex].Value.ToString();
                fila.codTipoDoc =dsSpx1.tipoDocumento[0].codTipoDoc;
                fila.cumpleanos =n;
                fila.docContacto =(grdDatos["docContactoDataGridViewTextBoxColumn", grdDatos.CurrentCell.RowIndex].Value == null) ? "" : grdDatos["docContactoDataGridViewTextBoxColumn", grdDatos.CurrentCell.RowIndex].Value.ToString();
                fila.email =(grdDatos["emailDataGridViewTextBoxColumn", grdDatos.CurrentCell.RowIndex].Value == null) ? "" : grdDatos["emailDataGridViewTextBoxColumn", grdDatos.CurrentCell.RowIndex].Value.ToString();
                fila.fax =(grdDatos["faxDataGridViewTextBoxColumn", grdDatos.CurrentCell.RowIndex].Value == null) ? "" : grdDatos["faxDataGridViewTextBoxColumn", grdDatos.CurrentCell.RowIndex].Value.ToString();
                fila.nitCliente=nitCliente;
                fila.nombreContacto=(grdDatos["nombreContactoDataGridViewTextBoxColumn", grdDatos.CurrentCell.RowIndex].Value == null) ? "" : grdDatos["nombreContactoDataGridViewTextBoxColumn", grdDatos.CurrentCell.RowIndex].Value.ToString();
                fila.paginaWeb="";
                fila.telefono1=(grdDatos["telefono1DataGridViewTextBoxColumn", grdDatos.CurrentCell.RowIndex].Value == null) ? "" : grdDatos["telefono1DataGridViewTextBoxColumn", grdDatos.CurrentCell.RowIndex].Value.ToString();
                fila.telefono2=(grdDatos["telefono2DataGridViewTextBoxColumn", grdDatos.CurrentCell.RowIndex].Value == null) ? "" : grdDatos["telefono2DataGridViewTextBoxColumn", grdDatos.CurrentCell.RowIndex].Value.ToString();
                fila.tituloContacto=(grdDatos["tituloContactoDataGridViewTextBoxColumn", grdDatos.CurrentCell.RowIndex].Value == null) ? "" : grdDatos["tituloContactoDataGridViewTextBoxColumn", grdDatos.CurrentCell.RowIndex].Value.ToString();

                dsSpx1.contactosClientes.AddcontactosClientesRow(fila);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(!validar())return;
            if (creando)
            {
                sucursalClienteTableAdapter1.Insert(nitCliente, txtCodigoSucursal.Text, txtNombreSucursal.Text,
                        cmbPais.SelectedValue.ToString(), cmbCiudad.SelectedValue.ToString(), txtDireccion.Text, txtTelefono.Text,
                        txtTelefono2.Text.Trim(), null, cmbDepartamento.SelectedValue.ToString(), null, null, null);
                if (codigoContactoNuevo.Trim() != string.Empty)
                {
                    sucursalClienteTableAdapter1.UpdateContacto(codigoContactoNuevo, nitCliente, txtCodigoSucursal.Text);
                }
            }else if (modificando) {
                sucursalClienteTableAdapter1.UpdateSucursal(txtNombreSucursal.Text, cmbPais.SelectedValue.ToString(),
                    cmbDepartamento.SelectedValue.ToString(),cmbCiudad.SelectedValue.ToString(), txtDireccion.Text, txtTelefono.Text, txtTelefono2.Text,
                    nitCliente, codigoSucursal);
                if (codigoContactoNuevo.Trim() != string.Empty && codigoContactoNuevo!=codigoContactoOriginal)
                {
                    sucursalClienteTableAdapter1.UpdateContacto(codigoContactoNuevo, nitCliente, txtCodigoSucursal.Text);
                }
            
            }
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private bool validar() 
        {
            if (txtCodigoSucursal.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe elejir un codigo para la sucursal");
                txtCodigoSucursal.Focus();
                return false;
            }
            if (txtNombreSucursal.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe elejir un nombre para la sucursal");
                txtNombreSucursal.Focus();
                return false;
            }
            if(cmbPais.SelectedValue == null || cmbPais.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Debe elejir un pais");
                cmbPais.Focus();
                return false;
            }
            if (cmbDepartamento.SelectedValue == null || cmbDepartamento.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Debe elejir un Departamento");
                cmbDepartamento.Focus();
                return false;
            }
            if (cmbCiudad.SelectedValue == null || cmbCiudad.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Debe elejir una ciudad");
                cmbCiudad.Focus();
                return false;
            }
            return true;
        }
   
        #region contactos
        private void btnAgergarContacto_Click(object sender, EventArgs e)
        {
            
            frmContactos frm = new frmContactos();
            frm.NitCliente = nitCliente;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                contactosClientesTableAdapter1.FillBynitCliente(dsSpx2.contactosClientes,nitCliente);
            }
        }

        private void btnModificarContacto_Click(object sender, EventArgs e)
        {
            if (grdDatos.FirstDisplayedCell == null) return;

            frmContactos frm = new frmContactos();
            frm.NitCliente = nitCliente;
            frm.CodContacto = grdDatos["codContacto", grdDatos.CurrentCell.RowIndex].Value.ToString();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                contactosClientesTableAdapter1.FillBynitCliente(dsSpx2.contactosClientes, nitCliente);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (grdDatos.FirstDisplayedCell == null) return;

            frmContactos frm = new frmContactos();
            frm.NitCliente = nitCliente;
            frm.Consultando = true;
            frm.CodContacto = grdDatos["codContacto", grdDatos.CurrentCell.RowIndex].Value.ToString();
            frm.ShowDialog();

        }

        private void grdDatos_DoubleClick(object sender, EventArgs e)
        {
            if (grdDatos.FirstDisplayedCell == null) return;

            frmContactos frm = new frmContactos();
            frm.NitCliente = nitCliente;
            frm.Consultando = true;
            frm.CodContacto = grdDatos["codContacto", grdDatos.CurrentCell.RowIndex].Value.ToString();
            frm.ShowDialog();
        }
        #endregion

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDepartamento.SelectedValue != null && validando)
            {
                ciudadesTableAdapter1.FillByCodPaisCodDepartamento(dsSpx1.ciudades, cmbPais.SelectedValue.ToString(),cmbDepartamento.SelectedValue.ToString().Trim());
            }
        }
    }
}