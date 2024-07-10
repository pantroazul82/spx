using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2020.frm.master
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        public class MenuHijo
        {

            public string Nombre { set; get; }

            public string Url { set; get; }
        }

        public class MenuModulo
        {
            public MenuModulo() {
                MenuActividades = new List<MenuHijo>();
            }
            public string Nombre { set; get; }
            public string Url { set; get; }
            public List<MenuHijo> MenuActividades { set; get; }
        }

        private void generarMenu()
        {
            if (Session["menu"] == null || Session["menu"].ToString().Trim() == string.Empty) return;
            string a = Session["menu"].ToString();
            string[] arr = a.Split(';');
            List<MenuModulo> menu = new List<master.MasterPage.MenuModulo>();
            for (int k = 0; k < arr.Length; k++)
            {
                if (arr[k].Trim() == string.Empty) continue;
                //        Telerik.Web.UI.RadMenuItem mn = new Telerik.Web.UI.RadMenuItem();
                MenuModulo menuItem = new MenuModulo();
                string[] subMenus = arr[k].Split('#');
                for (int h = 0; h < subMenus.Length; h++)
                {
                    if (h == 0 && subMenus.Length > 1)
                    {
                        menuItem.Nombre = subMenus[h];
                        continue;
                    }
                    string[] b = subMenus[h].Split('-');
                    for (int j = 0; j < b.Length; j++)
                    {
                        if (b[j].Trim() == string.Empty) continue;
                        string[] c = b[j].Split('|');
                        if (j == 0)
                        {
                            if (subMenus.Length == 1)
                            {
                                menuItem.Nombre = c[0];
                                menuItem.Url = c[1];
                            }
                            else
                            {
                                MenuHijo mnContainer = new MenuHijo();
                                mnContainer.Nombre = c[0];
                                mnContainer.Url = c[1];
                                menuItem.MenuActividades.Add(mnContainer);
                            }
                        }
                        else
                        {
                            MenuHijo mnContainer = new MenuHijo();
                            mnContainer.Nombre = c[0];
                            mnContainer.Url = c[1];
                            menuItem.MenuActividades.Add(mnContainer);
                        }
                    }
                }
                menu.Add(menuItem);
            }
            lstEvento.DataSource = menu;
            lstEvento.DataBind();
        }

        protected void Page_Preinit(object sender, EventArgs e)
        {
            if (Request.ServerVariables["http_user_agent"].IndexOf("Safari", StringComparison.CurrentCultureIgnoreCase) >= 0)
            {
                Page.ClientTarget = "uplevel";
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["ss_nombre_usuario"] == null 
                    
                    && Page.Request.RawUrl.ToLower().IndexOf("frmlogoout") < 0 
                    && Page.Request.RawUrl.ToLower().IndexOf("frmmsg") < 0
                    && Page.Request.RawUrl.ToLower().IndexOf("frmerrormanager") < 0
)
                {
                    Response.Redirect("~/Default.aspx");
                }
                else
                {
                  //  RadMenu1.Visible = true;
                    generarMenu();
                }
            }


            //  traerEstadoMenus();

        }

        public void btnSalir_click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("../../frm/logica/frmLogin.aspx");
        }


    }
}