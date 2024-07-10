using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_revision_frmListadoRevision : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsSeguridad obj = new clsSeguridad();
        obj.comprobarAcceso(Page, Session, Response, 2039);
        if (!IsPostBack)
        {
            calInicio.SelectedDate = DateTime.Now.AddMonths(-1);
            calFin.SelectedDate = DateTime.Now.AddDays(20);
            if (Request.QueryString["fe"] != null && Request.QueryString["fe"] == "900297458")
            {
                SPControladoraDatos.dsCientifica ds = new SPControladoraDatos.dsCientifica();
                SPControladoraDatos.dsCientificaTableAdapters.estado_revision_equiposTableAdapter estado = new SPControladoraDatos.dsCientificaTableAdapters.estado_revision_equiposTableAdapter();
                estado.FillBycod_manual(ds.estado_revision_equipos, 1);
                cmbEstados.SelectedValue = ds.estado_revision_equipos[0].cod_estado_revision_equipos.ToString();
                cmbEstados.Enabled = false;
            
            }
        }
    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmNuevaRevision.aspx");
    }
}