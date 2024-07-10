using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_controlcalidad_frmObservacionesSeguimiento : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        SPControladoraDatos.dsCientificaTableAdapters.observicionesxseguimiento_control_calidadTableAdapter obs = new SPControladoraDatos.dsCientificaTableAdapters.observicionesxseguimiento_control_calidadTableAdapter();
        obs.Insert(txtObservacion.Text,
            int.Parse(Request.QueryString["cod"]),
            int.Parse(Session["ss_cod_usuario"].ToString()),
            DateTime.Now);
        Response.Redirect("frmCerrarControl.aspx?cod=" + Request.QueryString["cod"]);
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmCerrarControl.aspx?cod=" + Request.QueryString["cod"]);
    }
}