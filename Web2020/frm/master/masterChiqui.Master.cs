using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2020.frm.master
{
    public partial class masterChiqui : System.Web.UI.MasterPage
    {
        protected void Page_Preinit(object sender, EventArgs e)
        {
            if (Request.ServerVariables["http_user_agent"].IndexOf("Safari", StringComparison.CurrentCultureIgnoreCase) >= 0)
            {
                Page.ClientTarget = "uplevel";
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ss_nombre_usuario"] == null)
            {
                menu1.Visible = false;
            }
            else
            {
                menu1.Visible = true;
            }


            //  traerEstadoMenus();
            #region para los link de login
            if (Session["ss_nombre_usuario"] != null)
            {
                linkLogin.Text = "Cerrar Sesion";
                linkLogin.ValidationGroup = "../../frm/logica/frmLogoOut.aspx";
                lblNombre.Text = Session["ss_nombre_usuario"] + "(" + Session["ss_login"] + ")";
            }
            else
            {
                linkLogin.Text = "Entrar al Sistema";
                linkLogin.ValidationGroup = "../../frm/logica/frmLogin.aspx";
            }

            if (Request.Url.AbsoluteUri.IndexOf("frm/logica/frmLogin.aspx") > 0)//miramos si viene de frmLogin.aspx ocultamos el link
            {
                linkLogin.Visible = false;
            }
            else
            {
                linkLogin.Visible = true;
            }
            #endregion
        }
        protected void linkLogin_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            Response.Redirect(b.ValidationGroup);
        }
    }
}