using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_calendar_frmAnularTarea : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
            ds.EnforceConstraints = false;
            SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter objTarea = new SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.estado_tarea_calendarioTableAdapter objEstado = new SPControladoraDatos.dsSpxTableAdapters.estado_tarea_calendarioTableAdapter();
            SPXSeguridad.data.cls.clsTusuario objusuario = new SPXSeguridad.data.cls.clsTusuario();

            objTarea.FillByCod_tarea_calendario(ds.tarea_calendario, int.Parse( Request.QueryString["cod"]));
            objEstado.FillByCod_estado_tarea_calendario(ds.estado_tarea_calendario, ds.tarea_calendario[0].cod_estado_tarea_calendario);
            if (ds.estado_tarea_calendario[0].cod_manual == 5)
            {
                txtObservaciones.ReadOnly = true;
                btnanular.Visible = false;
                if (!ds.tarea_calendario[0].Isfecha_anulacionNull())
                lblDescription.Text = "Fecha de anulacion " + ds.tarea_calendario[0].fecha_anulacion.ToShortDateString();
                if (!ds.tarea_calendario[0].Isanulada_porNull())
                    lblDescription.Text += " Anulada por " + objusuario.verNombre( ds.tarea_calendario[0].anulada_por);

                txtObservaciones.Text = ds.tarea_calendario[0].obs_anulacion;
            }
        }
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmNewTask.aspx?cod=tarea|" + Request.Params["cod"]);
    }
    protected void btnanular_Click(object sender, EventArgs e)
    {
        SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter();
        obj.UpdateAnulacion(int.Parse(Session["ss_cod_usuario"].ToString()),DateTime.Now,txtObservaciones.Text,
            int.Parse(Request.QueryString["cod"]));

        SPControladoraDatos.dsSpxTableAdapters.estado_tarea_calendarioTableAdapter objEstado = new SPControladoraDatos.dsSpxTableAdapters.estado_tarea_calendarioTableAdapter();
        SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
        ds.EnforceConstraints = false;
        objEstado.FillByCod_manual(ds.estado_tarea_calendario, 5);

        obj.UpdateEstadoAprobacion(ds.estado_tarea_calendario[0].cod_estado_tarea_calendario,
           int.Parse(Request.QueryString["cod"]));
        string sql = @"update tarea_calendario 
set cod_usuario = cod_creador where cod_tarea_calendario = " + int.Parse(Request.QueryString["cod"]);
        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
        bd.ejecutarComando(sql);
        Response.Redirect("frmNewTask.aspx?cod=tarea|" + Request.QueryString["cod"]);
    }
}