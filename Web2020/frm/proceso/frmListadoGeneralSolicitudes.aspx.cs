using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2020.frm.proceso
{
    public partial class frmListadoGeneralSolicitudes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnNuevaSolicutd_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("frmSolicitudGeneral.aspx");
        }
    }
}