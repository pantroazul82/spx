using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_csuministro_frmListadoTipoAdjuntoContratoSuministro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //validar permisos pendiente
    }
    protected void btnNuevo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("frmTipoAdjuntoContratoSuministro.aspx");
    }

    protected void btnEditar_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton im = (ImageButton)sender;
        Response.Redirect("frmTipoAdjuntoContratoSuministro.aspx?cod=" + im.ValidationGroup.ToString());
    }

    protected void btnEliminar_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            ImageButton im = (ImageButton)sender;
            SPControladoraDatos.dsSpxTableAdapters.tipo_tarea_calendarioTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.tipo_tarea_calendarioTableAdapter();
            obj.DeleteQuery(int.Parse(im.ValidationGroup.ToString()));
            RadGrid1.DataBind();
        }
        catch (Exception)
        {
        }

    }
}