using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

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
            //validamos que tenga permiso para crear revision
            btnNuevo.Visible = SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2038, int.Parse(Session["ss_cod_usuario"].ToString()), Session);
            
            
            if (Request.QueryString["fe"] != null && Request.QueryString["fe"] == "900297458")
            {
                SPControladoraDatos.dsCientifica ds = new SPControladoraDatos.dsCientifica();
                ds.EnforceConstraints = false;
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

    protected void btnExportar_Click(object sender, EventArgs e)
    {
        SPXUtilidades.Misc.clsExportarExcel obj = new SPXUtilidades.Misc.clsExportarExcel();
       SPControladoraDatos.dsCientificaTableAdapters.pltRevisionEquiposTableAdapter ob=new SPControladoraDatos.dsCientificaTableAdapters.pltRevisionEquiposTableAdapter();
       SPControladoraDatos.dsCientifica ds = new SPControladoraDatos.dsCientifica();

       string ruta = Server.MapPath("~/temp/");
        if(cmbEstados.SelectedValue == null || cmbEstados.SelectedValue.Trim() == string.Empty)
            ob.FillByEstado(ds.pltRevisionEquipos,calInicio.SelectedDate, calFin.SelectedDate);
        else
           ob.FillByEstadoFechas(ds.pltRevisionEquipos,calInicio.SelectedDate,calFin.SelectedDate,int.Parse(cmbEstados.SelectedValue));





        obj.exportXlsWeb(ds.pltRevisionEquipos, "revisiones", ruta, DateTime.Now.Ticks.ToString() + "revisiones.xls", "../../temp/", Response);
    }
    protected void btnBuscar_Click1(object sender, EventArgs e)
    {

    }
}