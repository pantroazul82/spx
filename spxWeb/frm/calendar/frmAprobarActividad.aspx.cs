using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_calendar_frmAprobarActividad : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsSeguridad obj = new clsSeguridad();
       // obj.comprobarAcceso(Page, Session, Response, 2008);
        lblCodActividad.Text = Request.QueryString["cod"].ToString();
    }
    protected void btnAprobar_Click(object sender, EventArgs e)
    {
        SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter();
        obj.UpdateAprobacion(txtObservacionesAprobacion.Text,
            int.Parse(Session["ss_cod_usuario"].ToString()), true, DateTime.Now, int.Parse(lblCodActividad.Text)
            );
        //--
        Response.Redirect("frmNewTask.aspx?cod=tarea|" + lblCodActividad.Text);
    }
    protected void btnNoAprobar_Click(object sender, EventArgs e)
    {
        SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter();
        obj.UpdateAprobacion(txtObservacionesAprobacion.Text,
            int.Parse(Session["ss_cod_usuario"].ToString()), false, DateTime.Now, int.Parse(lblCodActividad.Text)
            );
        //--
        Response.Redirect("frmNewTask.aspx?cod=tarea|" + lblCodActividad.Text);
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmNewTask.aspx?cod=tarea|"+lblCodActividad.Text);
    }
}