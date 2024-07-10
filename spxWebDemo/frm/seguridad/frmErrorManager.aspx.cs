using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_seguridad_frmErrorManager : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["er"] != null)
            {
                
                string ruta = Server.MapPath("~/logs/");
                ruta = ruta + Request.QueryString["er"] + ".log";
                string error = System.IO.File.ReadAllText(ruta);
                lblError.Text = error.Replace("@%@", "<br><br>");
            }
        }
    }
}