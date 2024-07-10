using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_logica_frmMsg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblMensaje.Text = "";

        if(Request.Params["mensajeSecurity"] != null)
            lblMensaje.Text = Request.Params["mensajeSecurity"].Trim().Replace("$$","<br>");
    }
}
