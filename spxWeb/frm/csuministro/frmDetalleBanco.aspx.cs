using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_csuministro_frmDetalleBanco : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //los permisos deben validarse al final masivamente
        if (Request.Params["cod"] != null)
        {
            if (!IsPostBack)
            {
                SPControladoraDatos.dsContratosSuministroTableAdapters.banco_suministroTableAdapter obj = new SPControladoraDatos.dsContratosSuministroTableAdapters.banco_suministroTableAdapter();

                SPControladoraDatos.dsContratosSuministro ds = new SPControladoraDatos.dsContratosSuministro();
                ds.EnforceConstraints = false;
                obj.FillByCod_banco_suministro(ds.banco_suministro, int.Parse(Request.Params["cod"]));
                //--
                txtDescripcion.Text = ds.banco_suministro[0].nombre_banco_suministro;


                lblCodTipo.Text = ds.banco_suministro[0].cod_banco_suministro.ToString();
            }
        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmListadoBanco.aspx");
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        //validamos
        if (txtDescripcion.Text == string.Empty)
        {
            lblError.Text = "El nombre del banco es obligatorio";
            return;
        }
        SPControladoraDatos.dsContratosSuministroTableAdapters.banco_suministroTableAdapter obj = new SPControladoraDatos.dsContratosSuministroTableAdapters.banco_suministroTableAdapter();
        if (lblCodTipo.Text == string.Empty)
        {
            obj.Insert(txtDescripcion.Text);
        }
        else
        {
            obj.UpdateQuery(txtDescripcion.Text, int.Parse(lblCodTipo.Text));
        }

        Response.Redirect("frmListadoBanco.aspx");
    }
}