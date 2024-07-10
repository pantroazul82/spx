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


</script>

