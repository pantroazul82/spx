using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_capacitacion_frmReprogramacion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SPControladoraDatos.dsSpxTableAdapters.session_capacitacionTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.session_capacitacionTableAdapter();
            SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
            ds.EnforceConstraints = false;
            obj.FillBycod_sesion_capacitacion(ds.session_capacitacion, int.Parse(Request.QueryString["cod"]));
            calClaseIni.SelectedDate = ds.session_capacitacion[0].fecha_inicio;
            calClaseFin.SelectedDate = ds.session_capacitacion[0].fecha_fin;
        }
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmInscritosClases.aspx?cod=" + Request.QueryString["cod"]);
    }

    protected void btnReprogramar_Click(object sender, EventArgs e)
    {
        if (txtObservacionesReprogramacion.Text.Trim() == string.Empty)
        {
            lblError.Text = "Debe ingresar la razon de la reprogramacion!";
            return;
        }
        #region validamos versus el calendario de actividades
        //valida las clases de todos los que estan inscritos
        if (linkConflicto.Text == string.Empty)
        {
            DateTime ini = calClaseIni.SelectedDate.Value;
            DateTime fin = calClaseFin.SelectedDate.Value;

            string sql = "select cod_capacitacion from session_capacitacion where cod_sesion_capacitacion= " + Request.QueryString["cod"];
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            string codCapacitacion = bd.ejecutarProcedimiento(sql).ToString();

            sql = @"select asistente_capacitacion.cod_capacitacion,usuario.cod_usuario,max(usuario.nombre) 'usuario'
 from asistente_capacitacion join usuario on usuario.cod_usuario = asistente_capacitacion.cod_usuario
where asistente_capacitacion.cod_capacitacion=" + codCapacitacion + " group by asistente_capacitacion.cod_capacitacion,usuario.cod_usuario";
            
            System.Data.DataTable tb= bd.ejecutarConsulta(sql).Tables[0];
            clsSeguridad sg = new clsSeguridad();
            for (int k = 0; k < tb.Rows.Count; k++)
            {
                string codigo = tb.Rows[k]["cod_usuario"].ToString();                
                string name = tb.Rows[k]["usuario"].ToString();
                string codTarea = sg.validarCalendario(int.Parse(codigo), ini, fin);

                if (codTarea != "")
                {
                    CGWebUtils.utils.misc.messageBox(Page, "Actividad en Conflicto para " + name + ", si presiona guardar nuevamente se guardara con conflicto");
                    
                    linkConflicto.Target = "_Blank";
                    linkConflicto.Visible = true;
                    linkConflicto.Text = "Actividad en Conflicto para " + name + ", si presiona guardar nuevamente se guardara con conflicto";
                    linkConflicto.NavigateUrl = sg.resolverLinkTarea(codTarea);
                    return;
                }
            }
        }
        linkConflicto.Text = string.Empty;
        linkConflicto.Visible = false;
        #endregion

        SPControladoraDatos.dsSpxTableAdapters.session_capacitacionTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.session_capacitacionTableAdapter();
        SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
        ds.EnforceConstraints = false;
        obj.FillBycod_sesion_capacitacion(ds.session_capacitacion, int.Parse(Request.QueryString["cod"]));
        obj.UpdateQuery(calClaseIni.SelectedDate.Value, calClaseFin.SelectedDate.Value, true, txtObservacionesReprogramacion.Text,
            int.Parse(Request.QueryString["cod"]));
        //enviamos los email
        SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter objAsistente = new SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.session_capacitacionTableAdapter objSession = new SPControladoraDatos.dsSpxTableAdapters.session_capacitacionTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.asistentexsessionTableAdapter objDetalle = new SPControladoraDatos.dsSpxTableAdapters.asistentexsessionTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.capacitacionTableAdapter objcapacitacion = new SPControladoraDatos.dsSpxTableAdapters.capacitacionTableAdapter();
        SPXSeguridad.data.dsSPXSeguridad dsSeguridad = new SPXSeguridad.data.dsSPXSeguridad();
        dsSeguridad.EnforceConstraints = false;
        SPXSeguridad.data.cls.clsTusuario objusuario = new SPXSeguridad.data.cls.clsTusuario();
        clsSeguridad objUtils = new clsSeguridad();
        int cod = ds.session_capacitacion[0].cod_capacitacion;
        objcapacitacion.FillBycod_capacitacion(ds.capacitacion, cod);

        objAsistente.FillBycod_capacitacion(ds.asistente_capacitacion,  cod);
        
        string asunto = "Reprogramacion de Sesion de Capacitacion " + ds.capacitacion[0].nombre;
        string cupero = "La sesion de la capacitacion programada para el dia " + ds.session_capacitacion[0].fecha_inicio.ToShortDateString() +
            " en la hora " + ds.session_capacitacion[0].fecha_inicio.ToLongTimeString() + " fue reprogramada para " +
            calClaseIni.SelectedDate.Value.ToLongDateString() + " hora " + calClaseIni.SelectedDate.Value.ToLongTimeString() + ", la razon  de la reprogramacione es:<br>" + txtObservacionesReprogramacion.Text;


        for (int j = 0; j < ds.asistente_capacitacion.Count; j++)
        {
            
            objusuario.FillBycod_usuario(dsSeguridad.usuario, ds.asistente_capacitacion[j].cod_usuario);
            objUtils.enviarEmail(asunto, cupero, dsSeguridad.usuario[0].correo);
        }


        Response.Redirect("frmInscritosClases.aspx?cod=" + Request.QueryString["cod"]);

    }
}