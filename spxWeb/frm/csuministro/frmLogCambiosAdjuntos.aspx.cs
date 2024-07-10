using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_csuministro_frmLogCambiosAdjuntos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmDetalleContrato.aspx?cod="+Request.QueryString["codo"]);
    }
}