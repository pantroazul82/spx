using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2020.frm.parametrizacion
{
    public partial class frmListadoContactos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsSeguridad obj = new clsSeguridad();
            obj.comprobarAcceso(Page, Session, Response, 2009);
        }
        protected void btnNuevo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("frmContactos.aspx");
        }

        protected void btnEditar_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton im = (ImageButton)sender;
            string[] a = im.ValidationGroup.ToString().Split('|');
            Response.Redirect("frmContactos.aspx?cod=" + a[0] + "&nit=" + a[1]);
        }

    }
}