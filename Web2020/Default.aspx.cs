using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2020
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ss_cod_usuario"] == null)
            {
                Response.Redirect("~/frm/logica/frmLogin.aspx");
            }
            else
            {
                Response.Redirect("~/frm/logica/frmInicio.aspx");
            }
        }
    }
}