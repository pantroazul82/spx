using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_parametrizacion_frmListadoSubtipoActividad : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnNuevo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("frmSubtipoActividad.aspx");
    }

    protected void btnEditar_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton im = (ImageButton)sender;
        Response.Redirect("frmSubtipoActividad.aspx?cod=" + im.ValidationGroup.ToString());
    }

    public string verTipo(object codTipo)
    {
        if (codTipo == null ) return "";
        SPControladoraDatos.dsSpxTableAdapters.tipo_tarea_calendarioTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.tipo_tarea_calendarioTableAdapter();
        return obj.GetDataBycod_tipo_tarea_calendario(int.Parse(codTipo.ToString()))[0].descripcion;
    }

    protected void btnEliminar_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            ImageButton im = (ImageButton)sender;
            SPControladoraDatos.dsSpxTableAdapters.sub_tipo_tarea_calendarioTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.sub_tipo_tarea_calendarioTableAdapter();
            obj.DeleteQuery(int.Parse(im.ValidationGroup.ToString()));
            RadGrid1.DataBind();
        }
        catch (Exception ex)
        {
            lblError.Text = "Error al eliminar el registro "+ex.Message;
        }

    }
}