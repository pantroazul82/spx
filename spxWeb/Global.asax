<%@ Application Language="C#" %>
<script runat="server">

void Application_Start(Object sender, EventArgs e) 
{
    try
    {
        string cnn = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["spxConnectionString"].ConnectionString;
        SPXdata.BD.DataConector.CadenaConexionAsignada= cnn;
        SPControladoraDatos.cnn.cargarCnn();
        SPXSeguridad.cnn.cargarConexion(cnn);
    }catch(Exception){
        
        
    }
    SPXSeguridad.logica.clsInicializador.serverWeb = Server;
    //cargamos los permisos
    SPXSeguridad.logica.clsInicializador obj = new SPXSeguridad.logica.clsInicializador();
    obj.guardarTablaFuncionalidades();
    obj.guardarTablaModulos();
    SPXSeguridad.cnn.cargarPermisos();
    SPXQuery.cnn.cargarPermisos();
    SupportTech.cnn.cargarPermisos();
}

 private const string _sessionKey = "NHibernate"; 

void Application_EndRequest(Object sender, EventArgs e) 
{
if( HttpContext.Current.Items.Contains(_sessionKey) )
{
NHibernate.ISession _session = (NHibernate.ISession)HttpContext.Current.Items[_sessionKey];
_session.Close();
HttpContext.Current.Items.Remove(_sessionKey);
}
}

void Application_Error(object sender, EventArgs e) 
{
    if (Server.GetLastError() == null) return;
    Exception objError = Server.GetLastError().GetBaseException();

    string err = "Error en la aplicacion" + "@%@" +
                  "Error en la pagina: " + Request.Url.ToString() +
                  "@%@" +
                  "Mensage: " + objError.Message.ToString() +
                  "@%@" +
                  "Tecnico:" + objError.StackTrace.ToString();

    Server.ClearError();
    err = err.Replace("\r\n", "@%@");
    err = err.Replace("\r", "@%@");
    err = err.Replace("\n", "@%@");
    string er = DateTime.Now.Ticks.ToString() + "spx";
    string ruta = Server.MapPath("~/logs/");
    try
    {
        System.IO.File.WriteAllText(ruta + "/" + er + ".log", err);
        Response.Redirect("~/frm/seguridad/frmErrorManager.aspx?er=" + er);
    }catch(Exception){}
}


</script>

