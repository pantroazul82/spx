using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_capacitacion_frmAceptarCapacitacion : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            lblPagPrev.Text = Request.UrlReferrer.AbsoluteUri.ToString();

        if (Request.Params["cod"] != null && !IsPostBack)
        {
           
            lblCod.Text = Request.Params["cod"];
            SPControladoraDatos.dsSpxTableAdapters.capacitacionTableAdapter objC = new SPControladoraDatos.dsSpxTableAdapters.capacitacionTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.estado_capacitacionTableAdapter objEstado = new SPControladoraDatos.dsSpxTableAdapters.estado_capacitacionTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter objAsistente=new SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter();
            SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
            ds.EnforceConstraints = false;
            objC.FillBycod_capacitacion(ds.capacitacion, int.Parse(Request.Params["cod"]));
            objAsistente.FillByUsuarioCapacitacion(ds.asistente_capacitacion, int.Parse(Request.Params["cod"]),int.Parse(Session["ss_cod_usuario"].ToString()));
            objEstado.FillByCod_estado_capacitacion(ds.estado_capacitacion, ds.capacitacion[0].cod_estado_capacitacion);
            lblNombreEstado.Text = ds.estado_capacitacion[0].descripcion;
            

            txtNombre.Text = ds.capacitacion[0].nombre;
            if (ds.capacitacion[0].Isdictada_por_otroNull())
            {
                txtotro.Text = ds.capacitacion[0].dictada_por_otro.Trim();
                cmbDictadaPor.DataBind();
                cmbDictadaPor_PreRender(sender, e);
                cmbDictadaPor.SelectedValue = "OTRO";
            }
            else if (!ds.capacitacion[0].Isdictada_porNull())
            {
                cmbDictadaPor.DataBind();
                cmbDictadaPor_PreRender(sender, e);
                cmbDictadaPor.SelectedValue = ds.capacitacion[0].dictada_por.ToString();
                if (ds.capacitacion[0].dictada_por.ToString() == Session["ss_cod_usuario"].ToString().Trim())
                {
                    Response.Redirect("frmCapacitacion.aspx?cod=" + Request.QueryString["cod"],true);
                    return;
                }
            }
            txtObservaciones.Text = ds.capacitacion[0].descripcion;
            calInicio.SelectedDate = ds.capacitacion[0].fecha_inicio;
            calFin.SelectedDate = ds.capacitacion[0].fecha_fin;
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            if (!ds.capacitacion[0].Iscod_modeloNull())
            {

                string sql = @"select top 1 rtrim(nombreModelo)+' ('+rtrim(nombre_Fabricante)+')'
 from modelos
join fabricante f on f.codFabricante = modelos.codFabricante
where modelos.codModelo ='" + ds.capacitacion[0].cod_modelo.Trim() + @"' and f.codFabricante ='" + ds.capacitacion[0].cod_fabricante.Trim() + "'";
                txtModelo.Text = bd.ejecutarProcedimiento(sql).ToString().Trim();
            }

            if (!ds.capacitacion[0].Iscod_referencia_reactivoNull())
            {

                string sql = @"select top 1 rtrim(nombre_referencia_reactivo)+' ('+rtrim(nombre_Fabricante)+')' from referencia_reactivo 
join fabricante f on f.codFabricante = referencia_reactivo.codFabricante where referencia_reactivo.cod_referencia_reactivo ='" + ds.capacitacion[0].cod_referencia_reactivo + "'";

                txtReactivo.Text = bd.ejecutarProcedimiento(sql).ToString().Trim();
            }
            //si aprobo analizaos los resultados
            if (ds.asistente_capacitacion.Count > 0 && !ds.asistente_capacitacion[0].IsaproboNull())
            { 
                lblTituloEvaluacion.Visible=true;
                lblAsistencia.Visible=true;
                lblResultado.Visible=true;
                btnVerAsistencia.Visible = true;
                btnVerAsistencia.Visible = true;
                btnVerAsistencia.Visible = true;
                if (ds.asistente_capacitacion[0].aprobo) lblResultado.Text = "Aprobo";
                else lblResultado.Text = "No Aprobo";
                //miramos el numero de clases
                string sql = @"select (sum(cast(asistio as int))*100)/(count(cod_usuario))
from asistentexsession
where cod_capacitacion = "+Request.Params["cod"]+" and cod_usuario = "+Session["ss_cod_usuario"];
                object ob= bd.ejecutarProcedimiento(sql);
                if (ob != null && ob != System.DBNull.Value)
                {
                    lblAsistencia.Text ="Asistencia "+ ob.ToString() +  " %";
                }
                //miramos los botones
                btnVerAsistencia.Visible = (!ds.asistente_capacitacion[0].Isextension_asistenciaNull());
                btnVerEvaluacion.Visible = (!ds.asistente_capacitacion[0].Isextension_evaluacionNull());
                btnVerCertificado.Visible = (!ds.asistente_capacitacion[0].Isextension_certificadoNull());

                lblVerAsistencia.Visible = (!ds.asistente_capacitacion[0].Isextension_asistenciaNull());
                lblVerEvaluacion.Visible = (!ds.asistente_capacitacion[0].Isextension_evaluacionNull());
                lblVerCertificado.Visible = (!ds.asistente_capacitacion[0].Isextension_certificadoNull());
                    
            }
        }
    }

    

  
    protected void cmbDictadaPor_PreRender(object sender, EventArgs e)
    {
        ListItem it = new ListItem("N/A", "N/A");
        ListItem it2 = new ListItem("Otro", "OTRO");

        if (!IsPostBack && !cmbDictadaPor.Items.Contains(it))
        {
            cmbDictadaPor.Items.Add(it);
            cmbDictadaPor.Items.Add(it2);
            cmbDictadaPor.SelectedValue = "N/A";
        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect(lblPagPrev.Text);
    }

    public void btnAceptar_Click(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        string cod_session = b.ValidationGroup;


        SPControladoraDatos.dsSpxTableAdapters.asistentexsessionTableAdapter objAsistentexSesion = new SPControladoraDatos.dsSpxTableAdapters.asistentexsessionTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.session_capacitacionTableAdapter objSession = new SPControladoraDatos.dsSpxTableAdapters.session_capacitacionTableAdapter();
        SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
        ds.EnforceConstraints = false;
        objSession.FillBycod_sesion_capacitacion(ds.session_capacitacion, int.Parse(cod_session));

        objAsistentexSesion.DeleteQuery(int.Parse(lblCod.Text), int.Parse(Session["ss_cod_usuario"].ToString()) ,int.Parse(cod_session));
        clsSeguridad objemail = new clsSeguridad();
        SPXSeguridad.data.dsSPXSeguridad dsSeguridad = new SPXSeguridad.data.dsSPXSeguridad();
        dsSeguridad.EnforceConstraints = false;
        SPXSeguridad.data.cls.clsTusuario usuario = new SPXSeguridad.data.cls.clsTusuario();
        usuario.FillBycod_usuario(dsSeguridad.usuario, int.Parse(Session["ss_cod_usuario"].ToString()));
        
       objAsistentexSesion.Insert(int.Parse(lblCod.Text), int.Parse(Session["ss_cod_usuario"].ToString()), int.Parse(cod_session), true,null,"");
       objemail.enviarCalendario("Clase Aceptada del curso " + txtNombre.Text, "", "Clase Aceptada del curso " + txtNombre.Text, ds.session_capacitacion[0].fecha_inicio, ds.session_capacitacion[0].fecha_fin, "", dsSeguridad.usuario[0].correo);
         
        grdClases.DataBind();
    }

    public void btnCambiar_Click(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        string cod_session = b.ValidationGroup;


        SPControladoraDatos.dsSpxTableAdapters.asistentexsessionTableAdapter objAsistentexSesion = new SPControladoraDatos.dsSpxTableAdapters.asistentexsessionTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.session_capacitacionTableAdapter objSession = new SPControladoraDatos.dsSpxTableAdapters.session_capacitacionTableAdapter();
        SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
        ds.EnforceConstraints = false;
        objSession.FillBycod_sesion_capacitacion(ds.session_capacitacion, int.Parse(cod_session));

        objAsistentexSesion.FillByCapactiacionUsuarioSession(ds.asistentexsession, int.Parse(lblCod.Text), int.Parse(Session["ss_cod_usuario"].ToString()), int.Parse(cod_session));
        bool aceptar = true;
        if (ds.asistentexsession.Count > 0)
        {
            if (!ds.asistentexsession[0].IsaceptadaNull())
            aceptar = !ds.asistentexsession[0].aceptada;   
         }

        objAsistentexSesion.DeleteQuery(int.Parse(lblCod.Text), int.Parse(Session["ss_cod_usuario"].ToString()), int.Parse(cod_session));
        clsSeguridad objemail = new clsSeguridad();
        SPXSeguridad.data.dsSPXSeguridad dsSeguridad = new SPXSeguridad.data.dsSPXSeguridad();
        dsSeguridad.EnforceConstraints = false;
        SPXSeguridad.data.cls.clsTusuario usuario = new SPXSeguridad.data.cls.clsTusuario();
        usuario.FillBycod_usuario(dsSeguridad.usuario, int.Parse(Session["ss_cod_usuario"].ToString()));

        objAsistentexSesion.Insert(int.Parse(lblCod.Text), int.Parse(Session["ss_cod_usuario"].ToString()), int.Parse(cod_session), aceptar,null,"");
        if(aceptar)
        objemail.enviarCalendario("Clase Aceptada del curso " + txtNombre.Text, "", "Clase Aceptada del curso " + txtNombre.Text, ds.session_capacitacion[0].fecha_inicio, ds.session_capacitacion[0].fecha_fin, "", dsSeguridad.usuario[0].correo);

        grdClases.DataBind();
    }


    public bool verVisibleAceptar(object session) 
    { 
        SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
        ds.EnforceConstraints = false;
        SPControladoraDatos.dsSpxTableAdapters.capacitacionTableAdapter objCApacitacion = new SPControladoraDatos.dsSpxTableAdapters.capacitacionTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.estado_capacitacionTableAdapter objEstado = new SPControladoraDatos.dsSpxTableAdapters.estado_capacitacionTableAdapter();
        objCApacitacion.FillBycod_capacitacion(ds.capacitacion, int.Parse(lblCod.Text));
        objEstado.FillByCod_estado_capacitacion(ds.estado_capacitacion, ds.capacitacion[0].cod_estado_capacitacion);
        if (ds.estado_capacitacion[0].orden == 3) return false;
        SPControladoraDatos.dsSpxTableAdapters.asistentexsessionTableAdapter objAsistentexSesion = new SPControladoraDatos.dsSpxTableAdapters.asistentexsessionTableAdapter();
       
        objAsistentexSesion.FillByCapactiacionUsuarioSession(ds.asistentexsession, int.Parse(lblCod.Text), int.Parse(Session["ss_cod_usuario"].ToString()), int.Parse(session.ToString()));
        return ( ds.asistentexsession[0].IsaceptadaNull());
        
    }

    public bool verVisibleCancelar(object session)
    {

        SPControladoraDatos.dsSpxTableAdapters.asistentexsessionTableAdapter objAsistentexSesion = new SPControladoraDatos.dsSpxTableAdapters.asistentexsessionTableAdapter();
        SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
        ds.EnforceConstraints = false;
        SPControladoraDatos.dsSpxTableAdapters.capacitacionTableAdapter objCApacitacion = new SPControladoraDatos.dsSpxTableAdapters.capacitacionTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.estado_capacitacionTableAdapter objEstado = new SPControladoraDatos.dsSpxTableAdapters.estado_capacitacionTableAdapter();
        objCApacitacion.FillBycod_capacitacion(ds.capacitacion, int.Parse(lblCod.Text));
        objEstado.FillByCod_estado_capacitacion(ds.estado_capacitacion, ds.capacitacion[0].cod_estado_capacitacion);
        if (ds.estado_capacitacion[0].orden == 3) return false;
        objAsistentexSesion.FillByCapactiacionUsuarioSession(ds.asistentexsession, int.Parse(lblCod.Text), int.Parse(Session["ss_cod_usuario"].ToString()), int.Parse(session.ToString()));
        return (!ds.asistentexsession[0].IsaceptadaNull());

    }

    public string verTexto(object session)
    {
        SPControladoraDatos.dsSpxTableAdapters.asistentexsessionTableAdapter objAsistentexSesion = new SPControladoraDatos.dsSpxTableAdapters.asistentexsessionTableAdapter();
        SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
        ds.EnforceConstraints = false;
        objAsistentexSesion.FillByCapactiacionUsuarioSession(ds.asistentexsession, int.Parse(lblCod.Text), int.Parse(Session["ss_cod_usuario"].ToString()), int.Parse(session.ToString()));
        if (ds.asistentexsession.Count > 0 )
        {
            if (!ds.asistentexsession[0].IsasistioNull())
            {
                if (ds.asistentexsession[0].asistio)
                    return "Asistio";
                else
                    return "No Asistio";
            }
            else { 
            if (ds.session_capacitacion.Count >0 && !ds.session_capacitacion[0].IsreprogramdaNull() && ds.session_capacitacion[0].reprogramda)
                {
                    return "Reprogramada: <br>"+ds.session_capacitacion[0].observaciones_reprogramacion;
                }
                else
                {

                    return "Programada";
                }
            }
        }
        else {
            return "";
        }
    }

    public void btnRechazar_Click(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        string cod_session = b.ValidationGroup;


        SPControladoraDatos.dsSpxTableAdapters.asistentexsessionTableAdapter objAsistentexSesion = new SPControladoraDatos.dsSpxTableAdapters.asistentexsessionTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.session_capacitacionTableAdapter objSession = new SPControladoraDatos.dsSpxTableAdapters.session_capacitacionTableAdapter();
        SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
        ds.EnforceConstraints = false;
        objSession.FillBycod_sesion_capacitacion(ds.session_capacitacion, int.Parse(cod_session));

        objAsistentexSesion.DeleteQuery(int.Parse(lblCod.Text), int.Parse(Session["ss_cod_usuario"].ToString()), int.Parse(cod_session));
        clsSeguridad objemail = new clsSeguridad();
        SPXSeguridad.data.dsSPXSeguridad dsSeguridad = new SPXSeguridad.data.dsSPXSeguridad();
        dsSeguridad.EnforceConstraints = false;
        SPXSeguridad.data.cls.clsTusuario usuario = new SPXSeguridad.data.cls.clsTusuario();
        usuario.FillBycod_usuario(dsSeguridad.usuario, int.Parse(Session["ss_cod_usuario"].ToString()));
        objAsistentexSesion.Insert(int.Parse(lblCod.Text), int.Parse(Session["ss_cod_usuario"].ToString()), int.Parse(cod_session), false, null, "");
        objemail.enviarCalendario("Clase Aceptada del curso " + txtNombre.Text, "", "Clase Aceptada del curso " + txtNombre.Text, ds.session_capacitacion[0].fecha_inicio, ds.session_capacitacion[0].fecha_fin, "", dsSeguridad.usuario[0].correo);
        grdClases.DataBind();
    }

    public void btnCambiarEstado_Click(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        string cod_session = b.ValidationGroup;


        SPControladoraDatos.dsSpxTableAdapters.asistentexsessionTableAdapter objAsistentexSesion = new SPControladoraDatos.dsSpxTableAdapters.asistentexsessionTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.session_capacitacionTableAdapter objSession = new SPControladoraDatos.dsSpxTableAdapters.session_capacitacionTableAdapter();
        SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
        ds.EnforceConstraints = false;
        objSession.FillBycod_sesion_capacitacion(ds.session_capacitacion, int.Parse(cod_session));

        objAsistentexSesion.DeleteQuery(int.Parse(lblCod.Text), int.Parse(Session["ss_cod_usuario"].ToString()), int.Parse(cod_session));
        clsSeguridad objemail = new clsSeguridad();
        SPXSeguridad.data.dsSPXSeguridad dsSeguridad = new SPXSeguridad.data.dsSPXSeguridad();
        dsSeguridad.EnforceConstraints = false;
        SPXSeguridad.data.cls.clsTusuario usuario = new SPXSeguridad.data.cls.clsTusuario();
        usuario.FillBycod_usuario(dsSeguridad.usuario, int.Parse(Session["ss_cod_usuario"].ToString()));
        objAsistentexSesion.Insert(int.Parse(lblCod.Text), int.Parse(Session["ss_cod_usuario"].ToString()), int.Parse(cod_session), false,null,"");
        objemail.enviarCalendario("Clase Aceptada del curso " + txtNombre.Text, "", "Clase Aceptada del curso " + txtNombre.Text, ds.session_capacitacion[0].fecha_inicio, ds.session_capacitacion[0].fecha_fin, "", dsSeguridad.usuario[0].correo);
        grdClases.DataBind();
    }

    protected void btnAceptarTodos_Click(object sender, EventArgs e)
    {
        SPControladoraDatos.dsSpxTableAdapters.asistentexsessionTableAdapter objAsistentexSesion = new SPControladoraDatos.dsSpxTableAdapters.asistentexsessionTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.session_capacitacionTableAdapter objSession=new SPControladoraDatos.dsSpxTableAdapters.session_capacitacionTableAdapter();
        SPControladoraDatos.dsSpx ds=new SPControladoraDatos.dsSpx();
        ds.EnforceConstraints = false;
        objSession.FillByCod_capacitacion(ds.session_capacitacion,int.Parse(lblCod.Text));

        objAsistentexSesion.DeleteByUsuarioyCapacitacion(int.Parse(lblCod.Text), int.Parse(Session["ss_cod_usuario"].ToString()));
        clsSeguridad objemail = new clsSeguridad();
        SPXSeguridad.data.dsSPXSeguridad dsSeguridad = new SPXSeguridad.data.dsSPXSeguridad();
        dsSeguridad.EnforceConstraints = false;
        SPXSeguridad.data.cls.clsTusuario usuario = new SPXSeguridad.data.cls.clsTusuario();
        usuario.FillBycod_usuario(dsSeguridad.usuario, int.Parse(Session["ss_cod_usuario"].ToString()));
        for(int k=0;k<ds.session_capacitacion.Count;k++)
        {
            objAsistentexSesion.Insert(int.Parse(lblCod.Text), int.Parse(Session["ss_cod_usuario"].ToString()), ds.session_capacitacion[k].cod_sesion_capacitacion, true, null, "");
            //enviamos las tareas en el calendario
            objemail.enviarCalendario("Clase " + (k + 1) + " del curso " + txtNombre.Text, "",  "Clase " + (k + 1) + " del curso " + txtNombre.Text, ds.session_capacitacion[k].fecha_inicio, ds.session_capacitacion[k].fecha_fin, "", dsSeguridad.usuario[0].correo);
        }
        grdClases.DataBind();
    }

    protected void btnRechazartodas_Click(object sender, EventArgs e)
    {
        SPControladoraDatos.dsSpxTableAdapters.asistentexsessionTableAdapter objAsistentexSesion = new SPControladoraDatos.dsSpxTableAdapters.asistentexsessionTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.session_capacitacionTableAdapter objSession = new SPControladoraDatos.dsSpxTableAdapters.session_capacitacionTableAdapter();
        SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
        ds.EnforceConstraints = false;
        objSession.FillByCod_capacitacion(ds.session_capacitacion, int.Parse(lblCod.Text));

        objAsistentexSesion.DeleteByUsuarioyCapacitacion(int.Parse(lblCod.Text), int.Parse(Session["ss_cod_usuario"].ToString()));
        clsSeguridad objemail = new clsSeguridad();
        SPXSeguridad.data.dsSPXSeguridad dsSeguridad = new SPXSeguridad.data.dsSPXSeguridad();
        dsSeguridad.EnforceConstraints = false;
        SPXSeguridad.data.cls.clsTusuario usuario = new SPXSeguridad.data.cls.clsTusuario();
        usuario.FillBycod_usuario(dsSeguridad.usuario, int.Parse(Session["ss_cod_usuario"].ToString()));
        for (int k = 0; k < ds.session_capacitacion.Count; k++)
        {
            objAsistentexSesion.Insert(int.Parse(lblCod.Text), int.Parse(Session["ss_cod_usuario"].ToString()), ds.session_capacitacion[k].cod_sesion_capacitacion, false, null, "");
        }
        grdClases.DataBind();
    }

    protected void btnVerAsistencia_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton im = (ImageButton)sender;
        SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter();
        byte[] arr = (byte[])obj.verAsistencia(int.Parse(Request.QueryString["cod"]), int.Parse(Session["ss_cod_usuario"].ToString()));
        string ext = obj.verExtensionAsistencia(int.Parse(Request.QueryString["cod"]), int.Parse(Session["ss_cod_usuario"].ToString()));
        bajarArchivo(arr, ext);
    }

    protected void btnVerEvaluacion_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton im = (ImageButton)sender;
        SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter();
        byte[] arr = obj.verEvaluacion(int.Parse(Request.QueryString["cod"]), int.Parse(Session["ss_cod_usuario"].ToString()));
        string ext = obj.verExtensionEvaluacion(int.Parse(Request.QueryString["cod"]), int.Parse(Session["ss_cod_usuario"].ToString()));
        bajarArchivo(arr, ext);
    }

    protected void btnVerCertificado_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton im = (ImageButton)sender;
        SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter();
        byte[] arr = obj.verCertificado(int.Parse(Request.QueryString["cod"]), int.Parse(Session["ss_cod_usuario"].ToString()));
        string ext = obj.verExtensionCertificado(int.Parse(Request.QueryString["cod"]), int.Parse(Session["ss_cod_usuario"].ToString()));
        bajarArchivo(arr, ext);
    }

    public void bajarArchivo(byte[] arr, string extension)
    {
        if (arr != null)
        {

            string path = Server.MapPath("~/temp/");
            string file = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0') +
                DateTime.Now.Hour.ToString().PadLeft(2, '0') + DateTime.Now.Minute.ToString().PadLeft(2, '0') + DateTime.Now.Minute.ToString() +
                extension;
            path = path + file;
            System.IO.File.WriteAllBytes(path, arr);
            Response.Redirect("~/temp/" + file);
        }
    }
}