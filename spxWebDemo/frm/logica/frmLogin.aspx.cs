using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_logica_frmLogin : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["urlRefer"] != null)
        {
            lblEnviadoDesde.Text = Session["urlRefer"].ToString();
            Session["urlRefer"] = null;
        }

        //miramos si lo enviaron desde un pagina que requiere login automaticamente
        if (Session["msgLogin"] != null)
        {
            lblError.Visible = true;
            if (Session["msgLogin"] == "xxx")
                lblError.Text = "Intento Entrar a Una pagina que requiere autentificación, <br>para ingresar a la pagina debe ingresar su Nombre de usuario y contraseña!";
            else
                lblError.Text = Session["msgLogin"].ToString();

            Session["msgLogin"] = null;
        }

        if (Session["ss_cod_usuario"] != null)
        {
            txtPass.Visible = false;
            txtUsuario.Visible = false;
            Label1.Visible = false;
            Label2.Visible = false;
            btnIngresar.Visible = false;
        }
    }

    protected void btnIngresar_Click(object sender, EventArgs e)
    {
        clsSeguridad obj = new clsSeguridad();
        //asignacion de variables
        int codUsuario = 0;
        string loginUsuario = txtUsuario.Text;
        string nombre = "";
        string mensaje = "";
        //ver cadena de conexion de web config
        if (obj.autenticar(txtUsuario.Text, txtPass.Text, out codUsuario, out nombre, out mensaje)  )
        {
            obj.asignarSession(Session, "ss_login", loginUsuario);
            obj.asignarSession(Session, "ss_cod_usuario", codUsuario.ToString());
            obj.asignarSession(Session, "ss_nombre_usuario", nombre);
            obj.asignarSession(Session, "menu", construirMenu());

            if (lblEnviadoDesde.Text.Trim() != string.Empty)
            {
                Response.Redirect(lblEnviadoDesde.Text, true);
            }
            else
            {
                Response.Redirect("~/frm/logica/Default.aspx", true);
            }
        }
        else
        {
            lblError.Visible = true;
            lblError.Text = "Error el nombre de usuario y la contraseña no son validos!!!<br>" + mensaje;
        }
    }

    private string construirMenu()
    {
        //cargamos el codigo del perfil web
        int codUsuario = int.Parse(Session["ss_cod_usuario"].ToString());
        string res = "";
        //menu torneos
        #region Consultas
        
        if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb( 1095,codUsuario,Session))//torneos federacion.
        {
            string a = "Equipos|~/frm/hojavida/frmHojaVida.aspx";
            res = a + "-" + res;
        }
        if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2051, codUsuario, Session))//torneos federacion.
        {
            string a = "Listado de Actividades Cientifica|~/frm/herramientas/frmListadoConsultaCalendario.aspx";
            res = a + "-" + res;
        }   
        if (res != string.Empty) res = "Consultas|-" + res + ";";
        #endregion
        #region Ingenieria
        string resCursos = "";
        ////--------------------------------------------------------------------------------------------------
        if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(1200, codUsuario, Session))
        {
            string a = "Ordenes de Servicio|~/frm/ordenServicio/frmListado.aspx";
            resCursos = a + "-" + resCursos;
        }
        if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2014, codUsuario, Session))
        {
            string a = "Crear Orden de Servicio|~/frm/ordenServicio/frmCrearOrden.aspx";
            resCursos = a + "-" + resCursos;
        }

        if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(1083, codUsuario, Session))
        {
            string a = "Ordenes de Prestamo|~/frm/ordenPrestamo/frmListadoOrdenesPrestamo.aspx";
            resCursos = a + "-" + resCursos;
        }
      
        if (resCursos != string.Empty)
        {
            resCursos = "Ingenieria|-" + resCursos + ";";
            res = resCursos + res;
        }
        #endregion
        
        #region Solcitudes
        resCursos = "";
        //if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(1071, codUsuario, Session))
        //{
        //    string a = "Solicitudes|~/frm/logica/enDesarrollo.aspx";
        //    resCursos = a + "-" + resCursos;
        //}

        if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2002, codUsuario, Session))
        {
            string a = "Generar Solicitud|~/frm/proceso/frmSolicitudGeneral.aspx";
            resCursos = a + "-" + resCursos;
        }
        if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2002, codUsuario, Session))
        {
            string a = "Mis Solicitudes|~/frm/proceso/frmListadoGeneralSolicitudes.aspx?tipo=auto";
            resCursos = a + "-" + resCursos;
        }
        if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2003, codUsuario, Session))
        {
            string a = "Listado de Solicitudes|~/frm/proceso/frmListadoGeneralSolicitudes.aspx";
            resCursos = a + "-" + resCursos;
        }
       
        if (resCursos != string.Empty) { resCursos = "Solicitudes|-" + resCursos + ";"; }
        res = resCursos + res;
        #endregion



        #region parametrizacion
        string resParametrizacion = "";
        if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2009, codUsuario, Session))
        {
            string a = "Tipo Actividad Calendario|~/frm/parametrizacion/frmListadoTipoTarea.aspx";
            resParametrizacion = a + "-" + resParametrizacion;
        }
        if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2009, codUsuario, Session))
        {
            string a = "Sub Tipo Actividad Calendario|~/frm/parametrizacion/frmListadoSubtipoActividad.aspx";
            resParametrizacion = a + "-" + resParametrizacion;
        }
        if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2009, codUsuario, Session))
        {
            string a = "Actividad x Sub tipo Calendario|~/frm/parametrizacion/frmListadoActividad.aspx";
            resParametrizacion = a + "-" + resParametrizacion;
        }

        if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2009, codUsuario, Session))
        {
            string a = "Calibracion Control Calidad|~/frm/parametrizacion/frmListadoCalibracionCalidad.aspx";
            resParametrizacion = a + "-" + resParametrizacion;
        }
        if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2009, codUsuario, Session))
        {
            string a = "Controles de Calidad|~/frm/parametrizacion/frmListadoControlesCalidad.aspx";
            resParametrizacion = a + "-" + resParametrizacion;
        }
        if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2009, codUsuario, Session))
        {
            string a = "Estado revision Producto QC|~/frm/parametrizacion/frmlistadoRevisionProducto.aspx";
            resParametrizacion = a + "-" + resParametrizacion;
        }


        if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2009, codUsuario, Session))
        {
            string a = "Contactos Cliente|~/frm/parametrizacion/frmListadoContactos.aspx";
            resParametrizacion = a + "-" + resParametrizacion;
        }

        if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2009, codUsuario, Session))
        {
            string a = "Control Calidad Origen Interno|~/frm/parametrizacion/frmListadoControlCalidadInterno.aspx";
            resParametrizacion = a + "-" + resParametrizacion;
        }
          if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2009, codUsuario, Session))
        {
            string a = "Origen revision Equipos|~/frm/parametrizacion/frmListadoOrigenRevisionEquipos.aspx";
            resParametrizacion = a + "-" + resParametrizacion;
        }
        
       
        if (resParametrizacion != string.Empty) { resParametrizacion = "Parametrizacion|-" + resParametrizacion + ";"; }
        res = resParametrizacion + res;
        #endregion

        
        string moduloCientifica = "";
        #region capacitaciones
        string resCapacitaciones = "";
        if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2011, codUsuario, Session))
        {
            string a = "Nueva Capacitacion|~/frm/capacitacion/frmCapacitacion.aspx";
            resCapacitaciones = a + "-" + resCapacitaciones;
        }
        if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2011, codUsuario, Session))
        {
            string a = "Listado Capacitaciones|~/frm/capacitacion/frmListadoCapacitaciones.aspx";
            resCapacitaciones = a + "-" + resCapacitaciones;
        }
        if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2022, codUsuario, Session) || SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2011, codUsuario, Session))
        {
            string a = "Mis cursos tomados|~/frm/capacitacion/frmMisCursos.aspx";
            resCapacitaciones = a + "-" + resCapacitaciones;
        }
        if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2011, codUsuario, Session))
        {
            string a = "Listado Maestro|~/frm/capacitacion/frmListadoMaestro.aspx";
            resCapacitaciones = a + "-" + resCapacitaciones;
        }
       
        
        #endregion

        #region actividades Cientifica
        string resActividades = "";
        //if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2010, codUsuario, Session))
        //{
        //    string a = "Calendario|~/frm/calendar/calendar.aspx";
        //    resActividades = a + "-" + resActividades;
        //}
        if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2010, codUsuario, Session))
        {
            string a = "Mis Tareas|~/frm/calendar/frmMisTareas.aspx";
            resActividades = a + "-" + resActividades;
        }
        if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2008, codUsuario, Session))
        {
            string a = "Tareas por Aprobar|~/frm/calendar/frmTareasxAprobar.aspx";
            resActividades = a + "-" + resActividades;
        }
        if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2012, codUsuario, Session))
        {
            string a = "Comparativo de tareas|~/frm/calendar/frmCalendarComparativo.aspx";
            resActividades = a + "-" + resActividades;
        }
        if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2012, codUsuario, Session))
        {
            string a = "Listado General de Tareas|~/frm/calendar/frmListadoTareas.aspx";
            resActividades = a + "-" + resActividades;
        }        
        #endregion

        #region control de calidad
        string resControl = "";
        if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2019, codUsuario, Session))
        {
            string a = "Crear Control Calidad|~/frm/controlcalidad/frmNewControlCalidad.aspx";
            resControl = a + "-" + resControl;
        }
        if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2020, codUsuario, Session))
        {
            string a = "Listado Controles|~/frm/controlcalidad/frmListadoControlCalidad.aspx";
            resControl = a + "-" + resControl;
        }
        if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2033, codUsuario, Session))
        {
            string a = "Controles por Aprobar|~/frm/controlcalidad/frmOrdenesxAprobar.aspx";
            resControl = a + "-" + resControl;
        }

        

        #endregion

        #region revision equipos
        string resRevisionEquipos = "";
        if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2038, codUsuario, Session))
        {
            string a = "Crear Revision Equipos|~/frm/revision/frmNuevaRevision.aspx";
            resRevisionEquipos = a + "-" + resRevisionEquipos;
        }
        if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2039, codUsuario, Session))
        {
            string a = "Listado Revision Equipos|~/frm/revision/frmListadoRevision.aspx";
            resRevisionEquipos = a + "-" + resRevisionEquipos;
        }
        if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2041, codUsuario, Session))
        {
            string a = "Revisiones Equipo por Asignar|~/frm/revision/frmListadoRevision.aspx?fe=900297458";
            resRevisionEquipos = a + "-" + resRevisionEquipos;
        }



        #endregion

        string resContratosSuministro = "";
        string parametrizacion = "";

        if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2058, codUsuario, Session))
        {
            string a = "Navegador de experiencias|~/frm/csuministro/frmExploradorExperiencias.aspx#";
            resContratosSuministro = a + "" + resContratosSuministro;
        }
        if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2058, codUsuario, Session))
        {
            string a = "Listado de contratos de suministro|~/frm/csuministro/frmListadoContratos.aspx#";
            resContratosSuministro = a + "" + resContratosSuministro;
        }
        if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2054, codUsuario, Session))
        {
            string a = "Crear Contrato suministro|~/frm/csuministro/frmCrearContrato.aspx#";
            resContratosSuministro = a + "" + resContratosSuministro;
        }



        if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2059, codUsuario, Session))
        {
            string a = "Division Experiencia|~/frm/csuministro/frmListadoDivisionExperiencia.aspx";
            parametrizacion = a + "-" + parametrizacion;

            a = "Grupo Reactivo Experiencia|~/frm/csuministro/frmListadoGrupoReactivoExperiencia.aspx";
            parametrizacion = a + "-" + parametrizacion;

            a = "Producto Experiencia|~/frm/csuministro/frmListadoProductosExperiencia.aspx";
            parametrizacion = a + "-" + parametrizacion;

            a = "Tipo Adjunto|~/frm/csuministro/frmListadoTipoAdjuntoContratoSuministro.aspx";
            parametrizacion = a + "-" + parametrizacion;

            a = "Tipo Archivo|~/frm/csuministro/frmListadpTipoArchivoContratoSuministro.aspx";
            parametrizacion = "parametrizacion|-" + a + "-" + parametrizacion + "#";

            a = "Motivos de anulacion|~/frm/csuministro/frmListadoMotivosAnulacion.aspx";
            parametrizacion = "parametrizacion|-" + a + "-" + parametrizacion + "#";

        }

        if (resContratosSuministro != string.Empty)
        {
            resContratosSuministro = "Contratos de suministro#" + resContratosSuministro + parametrizacion + ";";
        
        }


        if (resActividades != string.Empty)
            resActividades = "Actividades Cientifica|-" + resActividades+"#";
        if(resCapacitaciones!= string.Empty)
            resCapacitaciones = "Capacitaciones|-"+resCapacitaciones+"#";
        if (resControl != string.Empty)
            resControl = "Control Calidad|-" + resControl + "#";
        if (resRevisionEquipos != string.Empty)
            resRevisionEquipos = "Revision Equipos|-" + resRevisionEquipos + "#";
        moduloCientifica = "Cientifica#" + resActividades + resCapacitaciones+resControl+resRevisionEquipos+"Calendario|~/frm/calendar/calendar.aspx#;";


        //if (resContratosSuministro != string.Empty)
        //{
        //    resContratosSuministro = "Contratos suministro#" + resContratosSuministro;
        //}

        res = res + moduloCientifica + resContratosSuministro;
        return res;
    }

}
