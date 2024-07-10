using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2020.frm.logica
{
    public partial class frmLogin : System.Web.UI.Page
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
                Response.Redirect("../../default.aspx");
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
            if (obj.autenticar(txtUsuario.Text, txtPass.Text, out codUsuario, out nombre, out mensaje))
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
                    Response.Redirect("../../frm/logica/Default.aspx", true);
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

            if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(1095, codUsuario, Session))//torneos federacion.
            {
                string a = "Equipos|../../frm/hojavida/frmHojaVida.aspx";
                res = a + "-" + res;
            }
            //if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2051, codUsuario, Session))//torneos federacion.
            //{
            //    string a = "Listado de Actividades |../../frm/herramientas/frmListadoConsultaCalendario.aspx";
            //    res = a + "-" + res;
            //}
            if (res != string.Empty) res = "Consultas|-" + res + ";";
            #endregion
            #region Ingenieria
            string resCursos = "";
            ////--------------------------------------------------------------------------------------------------
            if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(1200, codUsuario, Session))
            {
                string a = "Ordenes de Servicio|../../frm/ordenServicio/frmListado.aspx";
                resCursos = a + "-" + resCursos;
            }
            if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2014, codUsuario, Session))
            {
                string a = "Crear Orden de Servicio|../../frm/ordenServicio/frmCrearOrden.aspx";
                resCursos = a + "-" + resCursos;
            }
            if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2015, codUsuario, Session))
            {
                string a = "Crear Equipos|../../frm/ordenServicio/frmCrearEquipo.aspx";
                resCursos = a + "-" + resCursos;
            }

            //if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(1083, codUsuario, Session))
            //{
            //    string a = "Ordenes de Prestamo|../../frm/ordenPrestamo/frmListadoOrdenesPrestamo.aspx";
            //    resCursos = a + "-" + resCursos;
            //}

            if (resCursos != string.Empty)
            {
                resCursos = "Ingenieria|-" + resCursos + ";";
                res = resCursos + res;
            }
            #endregion

            #region Solicitudes
            //resCursos = "";
            //if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(1071, codUsuario, Session))
            //{
            //    string a = "Solicitudes|../../frm/logica/enDesarrollo.aspx";
            //    resCursos = a + "-" + resCursos;
            //}

            //if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2002, codUsuario, Session))
            //{
            //    string a = "Generar Solicitud|../../frm/proceso/frmSolicitudGeneral.aspx";
            //    resCursos = a + "-" + resCursos;
            //}
            //if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2002, codUsuario, Session))
            //{
            //    string a = "Mis Solicitudes|../../frm/proceso/frmListadoGeneralSolicitudes.aspx?tipo=auto";
            //    resCursos = a + "-" + resCursos;
            //}
            //if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2003, codUsuario, Session))
            //{
            //    string a = "Listado de Solicitudes|../../frm/proceso/frmListadoGeneralSolicitudes.aspx";
            //    resCursos = a + "-" + resCursos;
            //}

            //if (resCursos != string.Empty) { resCursos = "Solicitudes|-" + resCursos + ";"; }
            //res = resCursos + res;
            #endregion



            #region parametrizacion
            //////string resParametrizacion = "";
            //////if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2009, codUsuario, Session))
            //////{
            //////    string a = "Tipo Actividad Calendario|../../frm/parametrizacion/frmListadoTipoTarea.aspx";
            //////    resParametrizacion = a + "-" + resParametrizacion;
            //////}
            //////if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2009, codUsuario, Session))
            //////{
            //////    string a = "Sub Tipo Actividad Calendario|../../frm/parametrizacion/frmListadoSubtipoActividad.aspx";
            //////    resParametrizacion = a + "-" + resParametrizacion;
            //////}
            //////if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2009, codUsuario, Session))
            //////{
            //////    string a = "Actividad x Sub tipo Calendario|../../frm/parametrizacion/frmListadoActividad.aspx";
            //////    resParametrizacion = a + "-" + resParametrizacion;
            ////}

            //////if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2009, codUsuario, Session))
            //////{
            //////    string a = "Calibracion Control Calidad|../../frm/parametrizacion/frmListadoCalibracionCalidad.aspx";
            //////    resParametrizacion = a + "-" + resParametrizacion;
            //////}
            //////if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2009, codUsuario, Session))
            //////{
            //////    string a = "Controles de Calidad|../../frm/parametrizacion/frmListadoControlesCalidad.aspx";
            //////    resParametrizacion = a + "-" + resParametrizacion;
            //////}
            //////if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2009, codUsuario, Session))
            //////{
            //////    string a = "Estado revision Producto QC|../../frm/parametrizacion/frmlistadoRevisionProducto.aspx";
            //////    resParametrizacion = a + "-" + resParametrizacion;
            //////}


            //////if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2009, codUsuario, Session))
            //////{
            //////    string a = "Contactos Cliente|../../frm/parametrizacion/frmListadoContactos.aspx";
            //////    resParametrizacion = a + "-" + resParametrizacion;
            //////}

            //////if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2009, codUsuario, Session))
            //////{
            //////    string a = "Control Calidad Origen Interno|../../frm/parametrizacion/frmListadoControlCalidadInterno.aspx";
            //////    resParametrizacion = a + "-" + resParametrizacion;
            //////}
            //////if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2009, codUsuario, Session))
            //////{
            //////    string a = "Origen revision Equipos|../../frm/parametrizacion/frmListadoOrigenRevisionEquipos.aspx";
            //////    resParametrizacion = a + "-" + resParametrizacion;
            //////}


            //////if (resParametrizacion != string.Empty) { resParametrizacion = "Parametrizacion|-" + resParametrizacion + ";"; }
            //////res = resParametrizacion + res;
#endregion


            //string moduloCientifica = "";


            #region actividades Cientifica
            //string resActividades = "";
            //if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2010, codUsuario, Session))
            //{
            //    string a = "Mis Tareas|../../frm/calendar/frmMisTareas.aspx";
            //    resActividades = a + "-" + resActividades;
            //}
            //if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2008, codUsuario, Session))
            //{
            //    string a = "Tareas por Aprobar|../../frm/calendar/frmTareasxAprobar.aspx";
            //    resActividades = a + "-" + resActividades;
            //}
            //if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2012, codUsuario, Session))
            //{
            //    string a = "Comparativo de tareas|../../frm/calendar/frmCalendarComparativo.aspx";
            //    resActividades = a + "-" + resActividades;
            //}
            //if (SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2012, codUsuario, Session))
            //{
            //    string a = "Listado General de Tareas|../../frm/calendar/frmListadoTareas.aspx";
            //    resActividades = a + "-" + resActividades;
            //}

            //string aa = "Calendario|../../frm/calendar/calendar.aspx";
            //resActividades = aa + "-" + resActividades;
            #endregion
 
            //if (resActividades != string.Empty)
            //    resActividades = "Actividades |-" + resActividades + ";";
            
            //moduloCientifica =  resActividades ;


            //if (resContratosSuministro != string.Empty)
            //{
            //    resContratosSuministro = "Contratos suministro#" + resContratosSuministro;
            //}

            //res = res + moduloCientifica ;
            return res;
        }

    }
}