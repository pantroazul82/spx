using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_calendar_frmEjectarTarea : System.Web.UI.Page
{
    public class AutoCompleteResult
    {
        public string id { get; set; }
        public string value { get; set; }
    }

   



    protected void Page_Load(object sender, EventArgs e)
    {
        
        clsSeguridad obj = new clsSeguridad();
        obj.comprobarAcceso(Page, Session, Response, 2010);
        #region  registramos scripts y eventos onblur a los cuadros de texto
       
      
        #endregion
        //verficiamos los permisos para habilitar o deshabilitar el combo de responsable
        if (!IsPostBack)
        {
            string a = "";
           
        }
        if (Request.QueryString["cod"] != null && !IsPostBack)
        {
            string msg = "";
            #region cargamos la informacion de la tarea selecionada

            SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter tar = new SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.estado_tarea_calendarioTableAdapter objEstado = new SPControladoraDatos.dsSpxTableAdapters.estado_tarea_calendarioTableAdapter();
            SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
            ds.EnforceConstraints = false;
            tar.FillByCod_tarea_calendario(ds.tarea_calendario, int.Parse(Request.QueryString["cod"]));
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            //cargamos el estado 
            objEstado.FillByCod_estado_tarea_calendario(ds.estado_tarea_calendario, ds.tarea_calendario[0].cod_estado_tarea_calendario);
            cmbEstado.DataBind();
            cmbEstado.SelectedValue = ds.estado_tarea_calendario[0].cod_estado_tarea_calendario.ToString();
          if (!ds.tarea_calendario[0].IsconsecutivoxtipoNull())
            {
                lblConsecutivo.Text = "Consecutivo x Tipo: " + ds.tarea_calendario[0].consecutivoxtipo.ToString();
            }
           


            if (!ds.tarea_calendario[0].Iscod_tipo_tarea_calendarioNull())
            {
                cmbtipoActividad.DataBind();
                cmbtipoActividad.SelectedValue = ds.tarea_calendario[0].cod_tipo_tarea_calendario.ToString();
            }

            if (!ds.tarea_calendario[0].Iscod_subtipo_tarea_calendarioNull())
            {
                cmbSubtipoActividad.DataBind();
                cmbSubtipoActividad.SelectedValue = ds.tarea_calendario[0].cod_subtipo_tarea_calendario.ToString();
            }
            

            if (!ds.tarea_calendario[0].IsfinNull())
                calFin.SelectedDate = ds.tarea_calendario[0].fin;

            if (!ds.tarea_calendario[0].IsinicioNull())
                calInicio.SelectedDate = ds.tarea_calendario[0].inicio;

            if (!ds.tarea_calendario[0].IsactivaNull())
                chkActiva.Checked = ds.tarea_calendario[0].activa;


            lblCodACtividad.Text = Request.QueryString["cod"];

            #endregion
           
            btnImprimir.Visible = true;
            lblEstado.Visible = true;
            cmbEstado.Visible = true;
            if (!ds.tarea_calendario[0].Isrequiere_aprobacionNull() && ds.tarea_calendario[0].requiere_aprobacion)
            {
                if (ds.tarea_calendario[0].IsaprobadaNull())
                {
                   
                }
                else
                {
                    //si no fu aprobada es casi como si fuera anulada
                    if (!ds.tarea_calendario[0].aprobada)
                    {
                        chkActiva.Checked = false;
                        chkActiva.Enabled = false;
                   
                        btnCambiarEstado.Visible = false;
                    } else{//si fue aprobada deja hacer todo
                        btnCambiarEstado.Visible = SPXSeguridad.verificadorPermisos.ejecutarAccion(2007, int.Parse(Session["ss_cod_usuario"].ToString()), ref msg);
                         //--
                    }
                }
            }else{
                btnCambiarEstado.Visible = SPXSeguridad.verificadorPermisos.ejecutarAccion(2007, int.Parse(Session["ss_cod_usuario"].ToString()), ref msg);
            }

            ///si no tiene permiso de administrador no puede modificar el combo

            if (!ds.tarea_calendario[0].Isinicio_ejecucionNull())
            {
                //calFinEjecucion.SelectedDate = ds.tarea_calendario[0].inicio_ejecucion;
                //calFinEjecucion.Visible = true;
                //calEjecucion.Visible = true;
                //lblFechaEjecucion.Visible = true;
                //lblFechaFinEjecucion.Visible = true;
            }
            #region ajusta visibilidad dependiendo los controles
            btnVerdetalles.Visible = true;
            btnAgregar.Visible = false;
            if (ds.estado_tarea_calendario[0].cod_manual == 1)//si es abierta puede editar toda la informacion
            {
                cmbtipoActividad.Enabled = false;
                cmbSubtipoActividad.Enabled = false;

                btnCambiarEstado.Visible = SPXSeguridad.verificadorPermisos.ejecutarAccion(2007, int.Parse(Session["ss_cod_usuario"].ToString()), ref msg);
                btnImprimir.Visible = true;
                btnAgregar.Visible = true;
            }

            if (ds.estado_tarea_calendario[0].cod_manual >= 2)//si esta en ejecucion no deja editar varios campos
            {
                #region

               
                chkActiva.Enabled = false;
                cmbtipoActividad.Enabled = false;
                cmbSubtipoActividad.Enabled = false;
                btnAgregar.Visible = true;
                #endregion
            }

            if (ds.estado_tarea_calendario[0].cod_manual == 3)//cerrada
            {
                btnCambiarEstado.Visible = false;
                

            }else if (ds.estado_tarea_calendario[0].cod_manual == 4)//cerrada temp
            {
                btnCambiarEstado.Visible = SPXSeguridad.verificadorPermisos.ejecutarAccion(2007, int.Parse(Session["ss_cod_usuario"].ToString()), ref msg);
                

            }else
            if (ds.estado_tarea_calendario[0].cod_manual > 4)//anulada
            {
                btnCambiarEstado.Visible = false;
            }
            #endregion
        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("calendar.aspx");
    }

    public string sacarNit(string texto)
    {
        if (texto.LastIndexOf('(') <= 0)
            return "";
        string res = texto.Substring(texto.LastIndexOf('(') + 1);
        res = res.Substring(0, res.Length - 1);
        return res;
    }

    
   
   

    protected void btnImprimir_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmImprimir.aspx?os=" + lblCodACtividad.Text);
    }

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmNewTask.aspx?cod=tarea|" + Request.QueryString["cod"].ToString());
    }

    protected void btnCambiarEstado_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmCerrarActividad.aspx?cod=" + Request.QueryString["cod"].ToString());
    }

    protected void eliminarTarea(object sender, ImageClickEventArgs e)
    {
        ImageButton im = (ImageButton)sender;
        SPControladoraDatos.dsSpxTableAdapters.actividadxtarea_calendarioTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.actividadxtarea_calendarioTableAdapter();
        obj.DeleteQuery(int.Parse(im.ValidationGroup));
        grdACtividad.DataBind();
    }

    protected bool validarEliminar(object sender)
    {
        return (sender.ToString() == Session["ss_cod_usuario"].ToString()) ? true : false;
    }

    protected void btnAprobar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmAprobarActividad.aspx?cod=" + Request.QueryString["cod"].ToString().Split('|')[1].ToString());
    }

    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        lblErrorActividad.Text = "";
        if (txtObservacionesActividad.Text == string.Empty)
        {
            lblErrorActividad.Text = "<br>La descripcion de la actividad es obligatoria!!!!";
            return;
        }
        if (cmbActividad.SelectedValue == null || cmbActividad.SelectedValue.Trim() == string.Empty)
        {
            lblErrorActividad.Text = "<br>Debe seleccionar una actividad de la lista desplegable, si no existe debe crear una para continuar!";
            return;
        }
        SPControladoraDatos.dsSpxTableAdapters.actividadxtarea_calendarioTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.actividadxtarea_calendarioTableAdapter();
        obj.Insert(int.Parse(lblCodACtividad.Text), int.Parse(Session["ss_cod_usuario"].ToString()),
            int.Parse(cmbActividad.SelectedValue), DateTime.Now, txtObservacionesActividad.Text);
        txtObservacionesActividad.Text = "";
        grdACtividad.DataBind();
        //cambiamos el estado a en ejecucion
        SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter objTarea = new SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter();
        SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
        ds.EnforceConstraints = false;
        SPControladoraDatos.dsSpxTableAdapters.estado_tarea_calendarioTableAdapter objEstados = new SPControladoraDatos.dsSpxTableAdapters.estado_tarea_calendarioTableAdapter();
        objEstados.FillByCod_manual(ds.estado_tarea_calendario, 2);
        objTarea.UpdateEstadoAprobacion(ds.estado_tarea_calendario[0].cod_estado_tarea_calendario, int.Parse(lblCodACtividad.Text));
    }
    protected void btnGuardarArchivo_Click(object sender, EventArgs e)
    {
        lblErrorArchivo.Text = "";
        if (!FileUpload1.HasFile)
        {
            lblErrorArchivo.Text = "Seleccione un archivo!";
            return;
        }
        
        SPControladoraDatos.dsSpxTableAdapters.archivosxtarea_calendarioTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.archivosxtarea_calendarioTableAdapter();
        obj.Insert(int.Parse(lblCodACtividad.Text), FileUpload1.FileName, "", FileUpload1.FileBytes);
        grdArchivos.DataBind();

    }

    protected void eliminarArchivo(object sender, ImageClickEventArgs e)
    {
        ImageButton im = (ImageButton)sender;
        SPControladoraDatos.dsSpxTableAdapters.archivosxtarea_calendarioTableAdapter obj = new  SPControladoraDatos.dsSpxTableAdapters.archivosxtarea_calendarioTableAdapter();
        obj.DeleteQuery(int.Parse(im.ValidationGroup));
        grdArchivos.DataBind();
    }

    protected void bajarArchivo(object sender, ImageClickEventArgs e)
    {
        ImageButton im = (ImageButton)sender;
        SPControladoraDatos.dsSpxTableAdapters.archivosxtarea_calendarioTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.archivosxtarea_calendarioTableAdapter();
        SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
        ds.EnforceConstraints = false;
        obj.FillByCodarchivosxtarea_calendario(ds.archivosxtarea_calendario,int.Parse(im.ValidationGroup));
        //bajamos el archivo a una carpeta temporal
        string ruta=Server.MapPath(@"~\temp\");
        
           string nombreArchivo= "" +DateTime.Now.Year+""+DateTime.Now.Month.ToString().PadLeft(2,'0')+""
            + DateTime.Now.Day.ToString().PadLeft(2, '0') + "" + DateTime.Now.Hour.ToString().PadLeft(2, '0') + "" + DateTime.Now.Minute.ToString().PadLeft(2, '0') + ""
            + DateTime.Now.Second.ToString().PadLeft(3, '0') + "" + DateTime.Now.Millisecond.ToString().PadLeft(3, '0') + ""
            + ds.archivosxtarea_calendario[0].nombreArchivo.Trim();
           ruta = ruta + nombreArchivo;
        System.IO.File.WriteAllBytes(ruta, ds.archivosxtarea_calendario[0].archivo);
        Response.Redirect(@"~\temp\" + nombreArchivo);

    }
    protected void btnVerdetalles_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmDetallesTarea.aspx?cod=" + Request.QueryString["cod"]);

    }
    protected void btnCambiarEstadoPendientes_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmCerrarPendientes.aspx?cod=" + Request.QueryString["cod"]);

    }
    protected void btnGuardarInformacionREactivos_Click(object sender, EventArgs e)
    {
        SPControladoraDatos.dsSpxTableAdapters.reactivoxtareaTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.reactivoxtareaTableAdapter();
        for (int k = 0; k < grdReactivos.Items.Count; k++)
        {
            int codigo = int.Parse( ((TextBox)grdReactivos.Items[k].FindControl("txtLote")).ValidationGroup);
            string lote = ((TextBox)grdReactivos.Items[k].FindControl("txtLote")).Text;
            DateTime? ini = ((Telerik.Web.UI.RadDatePicker)grdReactivos.Items[k].FindControl("calInicio")).SelectedDate;
            DateTime? fin = ((Telerik.Web.UI.RadDatePicker)grdReactivos.Items[k].FindControl("calFin")).SelectedDate;
            obj.UpdateReactivoxTarea(lote, ini, fin, codigo);
        }
        lblErrorREactivos.Text = "Se guardaron los valores satisfactoriamnete";
    }
}