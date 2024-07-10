using NHibernate.Cfg; 
using NHibernate; 
using System; 
using System.Reflection; 
using System.IO; 
using System.Runtime.Remoting.Messaging; 
using System.Xml; 
using System.Web; 

namespace BOLayer{
/// <summary>
/// The SessionFactory is responsible for the NHibernate Configuration.
/// </summary>
public class SessionFactory
 {


#region --- Class Fields / Objects  ---

private static Configuration _configuration;
private static ISessionFactory _sessionFactory;
/// <summary>
/// Used to identify the object inside the http context items (WebForm) or CallContext (WinForm)
/// </summary>
private const string _sessionKey = "NHibernateSession";
/// <summary>
/// Used to identify the object inside the http context items (WebForm) or CallContext (WinForm)
/// </summary>
private const string _transactionKey = "NHibernateTransaction";

#endregion


#region --- Class Properties ---

/// <summary>
/// Is the application running in a Web Context.
/// </summary>
public static bool IsWebForm 
{
get
{
return (System.Web.HttpContext.Current != null );
}
}


#endregion


#region --- Class Methods --- 

/// <summary>
/// Create a new instance/object
/// </summary>
static  SessionFactory()
{
_configuration = new Configuration();
string _xmlpath = NHibernateConfigPath();
if (!_xmlpath.EndsWith(@"\")) _xmlpath += @"\";
_xmlpath += @"hibernate.config";
// Check that the XML Configuration exists
if (!System.IO.File.Exists(_xmlpath))
{
throw new System.Exception("The XML Configuration File: " + _xmlpath + " can not be found"); 
}
_configuration.Configure(_xmlpath);
_sessionFactory = _configuration.BuildSessionFactory();
CheckConnection();
}

/// <summary>
/// Method to make sure that the connection works. It's automatically called from the constructor.
/// </summary>
public static void CheckConnection()
{
try
{
ISession session = SessionFactory.GetSession();
System.Data.IDbConnection conn = session.Connection;
}
catch (System.Exception ex)
{
throw new System.Exception("The SessionFactory can not obtain a connection. Please check your connection string and other settings", ex);
}

}

/// <summary>
/// Method that calculates the Nhibernate.config file Path.
/// </summary>
public static string NHibernateConfigPath()
{
if (HttpContext.Current != null)
{
 return ApplicationPath();
}
else
{
 DirectoryInfo _di = new DirectoryInfo(ApplicationPath());
 while (true)
{
 if (_di == null) throw new Exception("hibernate.config"+" could not be found.");
 FileInfo[] _files = _di.GetFiles("hibernate.config");
 if (_files.Length > 0) break;
 _di = _di.Parent;
}
return _di.FullName;
}

}

/// <summary>
/// Method that calculates the current Application Path. This process works for both WebForm and WinForms projects.
/// </summary>
public static string ApplicationPath()
{
string _xmlPath = null;
if (HttpContext.Current != null)
{
 _xmlPath = HttpContext.Current.ApplicationInstance.Request.PhysicalApplicationPath;
}
else
{
 Assembly _ass = Assembly.GetEntryAssembly();
 if (_ass == null) _ass = Assembly.GetCallingAssembly();
 Uri _uri = new Uri( _ass.EscapedCodeBase);
 if (_uri.Scheme == "file")
{
 System.IO.FileInfo _fileInfo = new FileInfo(_uri.LocalPath);
 _xmlPath = _fileInfo.Directory.FullName;
}
 else 
{
_xmlPath = _uri.ToString();
}
}
 return _xmlPath;

}

public static void CloseSession()
{
ISession session = SessionFactory.GetSession();

if (session != null)
{
session.Close();
}

// Remove the Session from the HttpContext Items.
if (IsWebForm)
{
if (System.Web.HttpContext.Current.Items.Contains(_sessionKey))
{
System.Web.HttpContext.Current.Items.Remove(_sessionKey);
}
}
else
{
session = null;
}

}

/// <summary>
/// Gets an NHibernate Session.When running under ASP.NET it will use the HttpContext.Current.Items to store and retrieve the session so that the same httprequest uses the same session
/// </summary>
public static ISession GetSession()
{
ISession session;

if (IsWebForm)
 session = (ISession)HttpContext.Current.Items[_sessionKey];
else 
 session = (ISession)CallContext.GetData(_sessionKey);

if (session == null || !session.IsOpen)
{
session = _sessionFactory.OpenSession();
session.FlushMode = FlushMode.Never;
}
if (IsWebForm)
 HttpContext.Current.Items[_sessionKey] = session;
else
 CallContext.SetData(_sessionKey, session);
return session;
}

/// <summary>
/// Returns the current Transaction. This depends on the context (Web or Winforms)
/// </summary>
private static ITransaction GetTransaction()
{
ITransaction transaction;
if (IsWebForm)
 transaction = (ITransaction)HttpContext.Current.Items[_transactionKey];
 else
 transaction = (ITransaction)CallContext.GetData(_transactionKey);
return transaction;

}

/// <summary>
/// Starts a Transaction.
/// </summary>
public static ITransaction BeginTransaction()
{
ITransaction transaction = GetTransaction();
ISession session = SessionFactory.GetSession();

if (transaction == null || transaction.WasCommitted || transaction.WasRolledBack)
{
transaction = session.BeginTransaction();

if (IsWebForm)
   HttpContext.Current.Items[_transactionKey] = transaction;
else
   CallContext.SetData(_transactionKey, transaction);
}
return transaction;
}

/// <summary>
/// Commits / Accepts the current transaction.
/// </summary>
public static void CommitTransaction()
{
ITransaction transaction = GetTransaction();
ISession session = GetSession();
if (transaction == null)
{
throw new System.Exception("There is no Transaction to Commit!");
}
try
{
session.Flush();
transaction.Commit();
}
catch(System.Exception)
{
RollBackTransaction();
throw;
}
finally
{
transaction = null;
if ( session != null ) 
{
CloseSession();
}
}

}

/// <summary>
/// Commits / Accepts the current transaction.
/// </summary>
public static void RollBackTransaction()
{
ITransaction transaction = GetTransaction();
ISession session = GetSession();
// Verify that there is a transaction in the scope of this Factory. If the Transaction is null, then the call is incorrect thus an exception is raised.
if (transaction == null)
{
throw new System.Exception("There is no Transaction to Rollback!");
}
// Since a transaction is shared by many Factories it's possible that the transaction was rollback by another factory
if (transaction.WasRolledBack) return;
try
{
transaction.Rollback();
}
finally
{
// Clear the local Transaction reference in the factory and Close the Session.
transaction = null;
if ( session != null ) 
{
CloseSession();
}
}

}


#endregion
}
}

