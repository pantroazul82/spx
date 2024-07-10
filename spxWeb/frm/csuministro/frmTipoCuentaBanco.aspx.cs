using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_csuministro_frmTipoCuentaBanco : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //los permisos deben validarse al final masivamente
        if (Request.Params["cod"] != null)
        {
            if (!IsPostBack)
            {
                SPControladoraDatos.dsContratosSuministroTableAdapters.tipo_cuenta_bancoTableAdapter obj = new SPControladoraDatos.dsContratosSuministroTableAdapters.tipo_cuenta_bancoTableAdapter();

                SPControladoraDatos.dsContratosSuministro ds = new SPControladoraDatos.dsContratosSuministro();
                ds.EnforceConstraints = false;
                obj.FillByCod_tipo_cuenta_banco(ds.tipo_cuenta_banco, int.Parse(Request.Params["cod"]));
                //--
                txtDescripcion.Text = ds.tipo_cuenta_banco[0].nombre_tipo_cuenta_banco;


                lblCodTipo.Text = ds.tipo_cuenta_banco[0].cod_tipo_cuenta_banco.ToString();
            }
        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmListadoTipoCuentaBanco.aspx");
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        //validamos
        if (txtDescripcion.Text == string.Empty)
        {
            lblError.Text = "La descipcion es obligatoria";
            return;
        }
        SPControladoraDatos.dsContratosSuministroTableAdapters.tipo_cuenta_bancoTableAdapter obj = new SPControladoraDatos.dsContratosSuministroTableAdapters.tipo_cuenta_bancoTableAdapter();
        if (lblCodTipo.Text == string.Empty)
        {
            obj.Insert(txtDescripcion.Text);
        }
        else
        {
            obj.UpdateQuery(txtDescripcion.Text, int.Parse(lblCodTipo.Text));
        }

        Response.Redirect("frmListadoTipoCuentaBanco.aspx");
    }
}