using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_parametrizacion_frmContactos : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        //los permisos deben validarse al final masivamente
        if (Request.Params["cod"] != null || Request.Params["nit"] != null)
        {
            if (!IsPostBack)
            {
                string nitCliente = "";
                SPControladoraDatos.dsSpxTableAdapters.contactosClientesTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.contactosClientesTableAdapter();
                SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();

                if (Request.Params["nit"] != null)
                { 
                  nitCliente = Request.QueryString["nit"];
                    cmbCliente.Enabled = false;
                    cmbCliente.DataBind();
                cmbCliente.SelectedValue = nitCliente;
                }
                if (Request.Params["cod"] != null)
                {
                    string codContacto = Request.Params["cod"];

                    obj.FillBycodContactoNit(ds.contactosClientes, nitCliente, codContacto);
                    //-- 

                    cmbTipoDocumento.DataBind();
                    if (!ds.contactosClientes[0].IscodTipoDocNull())
                        cmbTipoDocumento.SelectedValue = ds.contactosClientes[0].codTipoDoc;

                    txtApellidosCliente.Text = ds.contactosClientes[0].apellidosContacto;

                    if (!ds.contactosClientes[0].IscelularNull())
                        txtCelular.Text = ds.contactosClientes[0].celular;

                    if (!ds.contactosClientes[0].IsdocContactoNull())
                        txtDocumento.Text = ds.contactosClientes[0].docContacto;

                    if (!ds.contactosClientes[0].IsemailNull())
                        txtEmail.Text = ds.contactosClientes[0].email;
                    if (!ds.contactosClientes[0].IsfaxNull())
                        txtFax.Text = ds.contactosClientes[0].fax;

                    if (!ds.contactosClientes[0].Istelefono2Null())
                        txtTelefono2.Text = ds.contactosClientes[0].telefono2;


                    txtNombreCliente.Text = ds.contactosClientes[0].nombreContacto;

                    txtTelefono.Text = ds.contactosClientes[0].telefono1;




                    if (!ds.contactosClientes[0].Ises_activoNull())
                        chkActivo.Checked = ds.contactosClientes[0].es_activo;

                    lblCodContacto.Text = codContacto;
                }
            }
        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmListadoContactos.aspx");
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        //validamos
        if (txtNombreCliente.Text == string.Empty)
        {
            lblError.Text = "El nombre es obligatorio!!!";
            return;
        }

        if (txtApellidosCliente.Text == string.Empty)
        {
            lblError.Text = "El apellido es obligatorio!!!";
            return;
        }
        if (cmbCliente.SelectedValue == string.Empty)
        {
            lblError.Text = "El cliente es obligatorio";
            return;
        }

        SPControladoraDatos.dsSpxTableAdapters.contactosClientesTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.contactosClientesTableAdapter();
        if (lblCodContacto.Text == string.Empty)
        {
            string codContacto = obj.verNextId(cmbCliente.SelectedValue).ToString();
            obj.Insert(cmbCliente.SelectedValue, codContacto, txtNombreCliente.Text,
                txtApellidosCliente.Text, txtDocumento.Text, cmbTipoDocumento.SelectedValue,
                null, txtTelefono.Text, txtTelefono2.Text, txtCelular.Text, txtEmail.Text, "",
                null, txtFax.Text, chkActivo.Checked,"");
        }
        else
        {
            obj.UpdateContacto(txtNombreCliente.Text, txtApellidosCliente.Text, txtDocumento.Text,
                cmbTipoDocumento.SelectedValue, null, txtTelefono.Text, txtTelefono2.Text, txtCelular.Text,
                txtEmail.Text, "", null, txtFax.Text, "",cmbCliente.SelectedValue,
                lblCodContacto.Text);
        }

        Response.Redirect("frmListadoContactos.aspx");
    }
}