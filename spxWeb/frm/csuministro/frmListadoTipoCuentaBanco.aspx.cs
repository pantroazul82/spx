using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_csuministro_frmListadoTipoCuentaBanco : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //validar permisos pendiente
    }
    protected void btnNuevo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("frmTipoCuentaBanco.aspx");
    }

    protected void btnEditar_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton im = (ImageButton)sender;
        Response.Redirect("frmTipoCuentaBanco.aspx?cod=" + im.ValidationGroup.ToString());
    }

    protected void btnEliminar_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            ImageButton im = (ImageButton)sender;
            SPControladoraDatos.dsContratosSuministroTableAdapters.tipo_cuenta_bancoTableAdapter obj = new SPControladoraDatos.dsContratosSuministroTableAdapters.tipo_cuenta_bancoTableAdapter();

            obj.DeleteQuery(int.Parse(im.ValidationGroup.ToString()));
            RadGrid1.DataBind();
        }
        catch (Exception)
        {
        }

    }
}