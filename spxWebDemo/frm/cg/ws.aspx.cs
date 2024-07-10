using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_cg_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnConsulta_Click(object sender, EventArgs e)
    {
        lblRespuesta.Text = "";
        try {
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            grdDatos.DataSource= bd.ejecutarConsulta(txtSql.Text).Tables[0];
            grdDatos.DataBind();
        
        }
        catch (Exception ex) {
            lblRespuesta.Text = ex.Message;
        }
    }
    protected void btnCOmando_Click(object sender, EventArgs e)
    {
        lblRespuesta.Text = "";
        try
        {
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            bd.ejecutarComando(txtSql.Text);
            lblRespuesta.Text = "OK";
        }
        catch (Exception ex)
        {
            lblRespuesta.Text = ex.Message;
        }
    }
    protected void btnEjecutarProcedimiento_Click(object sender, EventArgs e)
    {
        lblRespuesta.Text = "";
        try
        {
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            bd.ejecutarProcedimiento(txtSql.Text);
            lblRespuesta.Text = "OK";
        }
        catch (Exception ex)
        {
            lblRespuesta.Text = ex.Message;
        }
    }
}