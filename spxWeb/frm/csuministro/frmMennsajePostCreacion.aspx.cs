using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_csuministro_frmMennsajePostCreacion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["codN"] != null)
            {
                lblContrato.Text = Request.QueryString["codN"];
                lblCodInterno.Text = Request.QueryString["codI"];
            }
        
        }
    }
}