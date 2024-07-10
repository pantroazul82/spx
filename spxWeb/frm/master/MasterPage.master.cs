using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_master_MasterPage : System.Web.UI.MasterPage
{
    private void generarMenu()
    {
        if (Session["menu"] == null || Session["menu"].ToString().Trim() == string.Empty) return;
        string a = Session["menu"].ToString();
        string[] arr = a.Split(';');

        for (int k = 0; k < arr.Length; k++)
        {
            if (arr[k].Trim() == string.Empty) continue;
            Telerik.Web.UI.RadMenuItem mn = new Telerik.Web.UI.RadMenuItem();
          

            Telerik.Web.UI.RadMenuItem mnContainer = new Telerik.Web.UI.RadMenuItem();
          
            
            string[] subMenus =arr[k].Split('#');
            for(int h=0;h<subMenus.Length;h++)
            {
                if (h==0 && subMenus.Length>1)
                {
                    mn.Text = subMenus[h];
                    mn.NavigateUrl = "";
                    continue;
                }
                string[] b = subMenus[h].Split('-');
                for (int j = 0; j < b.Length; j++)
                {
                    if (b[j].Trim() == string.Empty) continue;
                    string[] c = b[j].Split('|');
                    if ( j == 0 )
                    {
                        if (subMenus.Length == 1)
                        {
                            mn.Text = c[0];
                            mn.NavigateUrl = c[1];
                        }else {
                            mnContainer = new Telerik.Web.UI.RadMenuItem();
                          
                            mnContainer.Text = c[0];
                            mnContainer.NavigateUrl = c[1];
                            mn.Items.Add(mnContainer);
                        }
                    }else{
                        Telerik.Web.UI.RadMenuItem smn = new Telerik.Web.UI.RadMenuItem(c[0], c[1]);
                        if (subMenus.Length > 1)
                            mnContainer.Items.Insert(0, smn);
                        else
                            mn.Items.Insert(0, smn);
                    }

                }
            }
           
            RadMenu1.Items.Insert(2, mn);

        }
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
            if (Session["ss_nombre_usuario"] == null)
            {
                RadMenu1.Visible = false;
            }
            else
            {
                RadMenu1.Visible = true;
                generarMenu();
            }
        }


        //  traerEstadoMenus();
        #region para los link de login
        if (Session["ss_nombre_usuario"] != null)
        {
            linkLogin.Visible = false;
            linkLogin.Text = "Cerrar Sesion";
            linkLogin.ValidationGroup = "../../frm/logica/frmLogoOut.aspx";
            lblNombre.Text = Session["ss_nombre_usuario"] + "(" + Session["ss_login"] + ")";
        }else{
            linkLogin.Visible = true;
            linkLogin.Text = "Entrar al Sistema";
            linkLogin.ValidationGroup = "../../frm/logica/frmLogin.aspx";
        }

        if (Request.Url.AbsoluteUri.IndexOf("frm/logica/frmLogin.aspx") > 0)//miramos si viene de frmLogin.aspx ocultamos el link
        {
            linkLogin.Visible = false;
        }
        //else{
        //    linkLogin.Visible = true;
       // }
        #endregion
    }
    protected void linkLogin_Click(object sender, EventArgs e)
    {
        Button b = (Button)sender;

        Response.Redirect(b.ValidationGroup);
    }
}
