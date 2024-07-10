using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_herramientas_frmListadoConsultaCalendario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            calInicio.Value = DateTime.Now.AddDays(-10);
            calfin.Value = DateTime.Now.AddDays(1);
        }

    }
    protected void btnGenerar_Click(object sender, EventArgs e)
    {

    }
    protected void btnExportarXls_Click(object sender, EventArgs e)
    {
        ASPxGridViewExporter1.WriteXlsToResponse("listado");
    }

    public string verTiempo(object f1, object f2) 
    {
        if(f1 == null || f1 == System.DBNull.Value || f2 == null || f2 == System.DBNull.Value)
        return "";

        return ((DateTime)f2).Subtract((DateTime)f1).TotalHours.ToString(); 
    }
}