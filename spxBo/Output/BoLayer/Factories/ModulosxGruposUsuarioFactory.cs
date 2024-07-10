using System; 
using System.Data; 
using System.Collections.Generic; 
using System.ComponentModel; 
using NHibernate.Cfg; 
using NHibernate; 
using NHibernate.Criterion; 

namespace BOLayer{
[DataObject]
public partial class ModulosxGruposUsuarioFactory
 {


#region --- Class Fields / Objects  ---

private ITransaction _lastTransaction;
private SessionScope _sessionScope = SessionScope.SessionFactory;
private List<ICriterion> _filters =  new List<ICriterion>();

#endregion


#region --- Class Properties ---

/// <summary>
/// Exposes an easy way to add Filters to a Factory.
/// </summary>
public List<ICriterion> Filters 
{
get
{

return _filters;
}
set 
{

if ( _filters != value) 
{
_filters = value ;
}
}
}

public ISession Session 
{
get
{
return SessionFactory.GetSession();
}
}


#endregion


#region --- Class Methods --- 

/// <summary>
/// Create a new ModulosxGruposUsuario Factory .
/// </summary>
public  ModulosxGruposUsuarioFactory()
{
}

/// <summary>
/// Create a new ModulosxGruposUsuario Factory allowing to configure the Scope (life) of a Session.
/// </summary>
public  ModulosxGruposUsuarioFactory(SessionScope pSessionScope)
{
_sessionScope = pSessionScope;

}

/// <summary>
/// When the object gets destroyed.
/// </summary>
~ModulosxGruposUsuarioFactory()
{
// If this Factory used a transaction it's the Factory responsibility to close it.
// If you get this exception means that SessionFactory.CommitTransaction was not called
if ( _sessionScope != SessionScope.SessionFactory )
{
if ( _lastTransaction != null )
{
if (_lastTransaction.IsActive )
{
throw new System.Exception("You forgot to commit or rollback the current transaction!");
}
_lastTransaction = null; 
}
}
}

private void BeginTransaction(bool pForce)
{
if (_sessionScope == SessionScope.PerOperation || pForce || _lastTransaction == null)
{
_lastTransaction = SessionFactory.BeginTransaction();
}

}

private void RollBack()
{
// If not transacion --> return
if (_lastTransaction == null) return;
// Check for not rollbacking twice. It's safe to return since it's already rollbacked
if (_lastTransaction.WasRolledBack) return;
SessionFactory.RollBackTransaction();
_lastTransaction = null;

}

private void Commit(bool pForce)
{
if ( _sessionScope == SessionScope.PerOperation || pForce )
{
try
{
SessionFactory.CommitTransaction();
}
finally
{
_lastTransaction = null;
}
}

}

public void Commit()
{
Commit(true);

}

public NHibernate.ITransaction GetCurrentTransaction()
{
return _lastTransaction;

}

public void CloseSession(bool pForce)
{
if ( _sessionScope == SessionScope.PerOperation || pForce )
{
SessionFactory.CloseSession();
_lastTransaction = null;
}

}

/// <summary>
/// Fetch an object of type ModulosxGruposUsuario by using it's Primary Key values. This is the Primary method to retrieve a ModulosxGruposUsuario.
/// </summary>
public ModulosxGruposUsuario Fetch(System.String pCodModulo , System.String pCodGruposUsu)
{
if ( String.IsNullOrEmpty(pCodModulo)) throw new ArgumentException("Argument Name:pCodModulo. Primary Key Column must have a value (different from null or empty)");
pCodModulo = pCodModulo.PadRight(10,' ') ;
if ( String.IsNullOrEmpty(pCodGruposUsu)) throw new ArgumentException("Argument Name:pCodGruposUsu. Primary Key Column must have a value (different from null or empty)");
pCodGruposUsu = pCodGruposUsu.PadRight(10,' ') ;
ModulosxGruposUsuario _bo = null ;
try 
{
ICriteria _criteria = GetBasicCriteria();
_criteria.Add(Restrictions.Eq("CodModulo" ,pCodModulo ));
_criteria.Add(Restrictions.Eq("CodGruposUsu" ,pCodGruposUsu ));
_bo = (ModulosxGruposUsuario) _criteria.UniqueResult();
if ( _bo == null ) 
{
return null;
}
}
catch ( Exception ex ) 
{
string _msg = ex.Message; 
throw; 
}
finally
{
}
return _bo;
}

/// <summary>
/// Fetch an object of type ModulosxGruposUsuario by using it's Primary Key values. This is the Primary method to retrieve a ModulosxGruposUsuario.
/// </summary>
public ModulosxGruposUsuario FetchVirtual(string pVirtualKey)
{
if( string.IsNullOrEmpty(pVirtualKey) ) throw new ArgumentNullException("pVirtualKey");
string[] _keys = pVirtualKey.Split('^');
if (_keys.Length != 2) throw new Exception("The virtual key format does not match the number of expected key values");
System.String _codModulo = _keys[0];
System.String _codGruposUsu = _keys[1];
return Fetch(_codModulo,_codGruposUsu);

}

/// <summary>
/// Counts how many objects will be returned by the GetAll() method according to the Criteria parameters.
/// </summary>
///<returns>Returns the amount of objects that meet the criteria specified on the parameters.<returns>
public int Count()
{
 return Count( GetBasicCriteria());

}

/// <summary>
/// Counts how many objects will be returned by the GetAll() method according to the Criteria parameters.
/// </summary>
/// <remarks>
/// Future NHibernate version will contain a better Count() technique so the current implementation will change to use ICriteria.Count instead of using the GetAll(Filters) method.
/// </remarks>
///<param name="pCriteria">Define the Criteria that will limit/filter the result.</param>
///<returns>Returns the amount of objects that meet the criteria specified on the parameters.<returns>
public int Count(ICriteria pCriteria)
{
if( pCriteria == null  ) throw new ArgumentNullException("pCriteria");
pCriteria.SetProjection(Projections.RowCount());
int count = pCriteria.UniqueResult<int>();
// Set the original projection list. For normal Tables/Views this is null, for CustomViews the method GetProjectionList() is used)
pCriteria.SetProjection( null );
return count;

}

/// <summary>
/// Get strongly typed collection of ModulosxGruposUsuarioCollection contain ALL objects. Please use the overloads of this method for more efficient retrievals
/// </summary>
public ModulosxGruposUsuarioCollection GetAll()
{
return GetAll( GetBasicCriteria() ,null,null,null,null);

}

/// <summary>
/// Method that returns a common/simple Criteria for the object ModulosxGruposUsuario
/// </summary>
public ICriteria GetBasicCriteria()
{
ICriteria _criteria = Session.CreateCriteria(typeof(ModulosxGruposUsuario),"ModulosxGruposUsuario"); 
 if (_criteria == null) throw new Exception("Failed to create criteria for ModulosxGruposUsuario");
 return _criteria;
}

/// <summary>
/// Get a strongly typed collection of ModulosxGruposUsuarioCollection objects given a pre-defined Criteria.
/// </summary>
///<param name="pCriteria">Define the Criteria that will limit/filter the result.</param>
public ModulosxGruposUsuarioCollection GetAll(ICriteria pCriteria)
{
if( pCriteria == null  ) throw new ArgumentNullException("pCriteria");
 ModulosxGruposUsuarioCollection _list = new ModulosxGruposUsuarioCollection(this);
pCriteria.List(_list);
return _list;
}

/// <summary>
/// Get a strongly typed collection of ModulosxGruposUsuarioCollection objects given a Criteria.
/// </summary>
///<param name="pCriteria">Define the Criteria that will limit/filter the result.</param>
///<param name="pSortExpression">(Optional) Specify a Sorting Expression. (Note: This method expects a Property Name.)</param>
public ModulosxGruposUsuarioCollection GetAll(ICriteria pCriteria , System.String pSortExpression)
{
return GetAll(pCriteria,null,pSortExpression,null,null);

}

/// <summary>
/// Get a strongly typed collection of ModulosxGruposUsuarioCollection objects given a SortExpression + Paging Information.
/// </summary>
///<param name="pSortExpression">(Optional) Specify a Sorting Expression. (Note: This method expects a Property Name.)</param>
///<param name="pFirstResult">(Optional) If present it determines a starting row index from the complete DataSource. Notice that 0 should be used for the first row.</param>
///<param name="pMaxResult">(Optional) How many object should be retrieved? (Also know as Page Size)</param>
public ModulosxGruposUsuarioCollection GetAll(System.String pSortExpression , System.Int32? pFirstResult , System.Int32? pMaxResult)
{
return GetAll(null,null,pSortExpression,pFirstResult,pMaxResult);

}

/// <summary>
/// Get a strongly typed collection of ModulosxGruposUsuarioCollection objects given a SortExpression + Paging Information.
/// </summary>
///<param name="pCriteria">Define the Criteria that will limit/filter the result.</param>
///<param name="pSortExpression">(Optional) Specify a Sorting Expression. (Note: This method expects a Property Name.)</param>
///<param name="pFirstResult">(Optional) If present it determines a starting row index from the complete DataSource. Notice that 0 should be used for the first row.</param>
///<param name="pMaxResult">(Optional) How many object should be retrieved? (Also know as Page Size)</param>
public ModulosxGruposUsuarioCollection GetAll(ICriteria pCriteria , System.String pSortExpression , System.Int32? pFirstResult , System.Int32? pMaxResult)
{
return GetAll(pCriteria,null,pSortExpression,pFirstResult,pMaxResult);

}

/// <summary>
/// Use this method to Get a strongly typed collection of ModulosxGruposUsuarioCollection contain objects that match the parameters. 
/// </summary>
///<param name="pCriteria">Define the Criteria that will limit/filter the result.</param>
///<param name="pSQLExpression">(Optional) Specify an SQL Filter expression.</param>
///<param name="pSortExpression">(Optional) Specify a Sorting Expression. (Note: This method expects a Property Name.)</param>
///<param name="pFirstResult">(Optional) If present it determines a starting row index from the complete DataSource. Notice that 0 should be used for the first row.</param>
///<param name="pMaxResult">(Optional) How many object should be retrieved? (Also know as Page Size)</param>
public ModulosxGruposUsuarioCollection GetAll(ICriteria pCriteria , System.String pSQLExpression , System.String pSortExpression , System.Int32? pFirstResult , System.Int32? pMaxResult)
{
// If the ICriteria is null, then use a basic criteria
if ( pCriteria == null ) pCriteria = GetBasicCriteria();
try 
{
// If SQLExpression parameters are passed then include them in pCriteria
if ( !string.IsNullOrEmpty(pSQLExpression) )
{
pCriteria.Add( Expression.Sql( pSQLExpression ) );
}

 foreach (ICriterion _filter in Filters )
{
 pCriteria.Add(_filter);
}

// If sorting expression present, call the ApplySorting method
if (!String.IsNullOrEmpty(pSortExpression))
{
ApplySorting(pCriteria,pSortExpression);
}
// Set the first Result value
if ( pFirstResult.HasValue)
{
pCriteria.SetFirstResult(pFirstResult.Value);
}
else
{
pCriteria.SetFirstResult(0);
}
// Set the Max Results value
if ( pMaxResult.HasValue)
{
pCriteria.SetMaxResults(pMaxResult.Value);
}
else
{
pCriteria.SetMaxResults(-1);
}

}
catch ( Exception ex ) 
{
string _msg = ex.Message; 
throw; 
}
finally
{
}
return GetAll(pCriteria);
}

/// <summary>
/// Method that takes a Sort Expression as string (and containing dot syntax for nested properties) and applies it the passed criteria.;
/// </summary>
///<param name="pCriteria">Define the Criteria that will limit/filter the result.</param>
///<param name="pSortExpression">(Optional) Specify a Sorting Expression. (Note: This method expects a Property Name.)</param>
protected virtual void ApplySorting(ICriteria pCriteria , System.String pSortExpression)
{
if( pCriteria == null  ) throw new ArgumentNullException("pCriteria");
if( string.IsNullOrEmpty(pSortExpression) ) throw new ArgumentNullException("pSortExpression");
// The ICriteria does not expose subcriterias, so we need to cast to this base class
NHibernate.Impl.CriteriaImpl criteria = pCriteria as NHibernate.Impl.CriteriaImpl;
if (criteria == null) throw new Exception("ApplySorting can only work with CriteriaImpl");

// First split the sorting parts. The Comma (,) separates multi-column sorting.
foreach (string propSort in pSortExpression.Split(','))
{
bool isDescending = propSort.EndsWith(" DESC");
bool isAscending  = propSort.EndsWith(" ASC");
string[] path = propSort.Split('.');
string property = path[path.Length - 1].Trim();
if (isDescending)
{
property = property.Substring(0, property.Length - 5);
}

if (isAscending)
{
property = property.Substring(0, property.Length - 4);
}
 if (path.Length < 2)
{
// first level (main criteria) sort
 pCriteria.AddOrder(new NHibernate.Criterion.Order(property, !isDescending));
}
else
{
 string alias = CnvPath(path);
// find the sub-criteria that matches the path (alias)
foreach (ICriteria subCriteria in criteria.IterateSubcriteria())
{
if (subCriteria.Alias == alias)
{
subCriteria.AddOrder(new NHibernate.Criterion.Order(property, isDescending));
}
}
}
}

}

/// <summary>
/// Method that takes a Sort Expression as string (and containing dot syntax for nested properties) and applies it the passed criteria.;
/// </summary>
///<param name="pPath">A DotNet syntax of a path. Example: books.Categories.Description</param>
private string CnvPath(string[] pPath)
{
if( pPath == null  ) throw new ArgumentNullException("pPath");
string alias = string.Empty;
 for (int i = 0; i < pPath.Length - 1; i++)
{
 if (i > 0) alias += ".";
 alias += pPath[i];
}
 return alias;

}

/// <summary>
/// Takes a detached object an re-attaches to the Factory Session.
/// </summary>
///<param name="pModulosxGruposUsuario">A BO of type ModulosxGruposUsuario</param>
public void ReAttach(ModulosxGruposUsuario pModulosxGruposUsuario)
{
if( pModulosxGruposUsuario == null  ) throw new ArgumentNullException("pModulosxGruposUsuario");
try 
{
Session.Lock(pModulosxGruposUsuario, NHibernate.LockMode.None);;
}
catch ( Exception ex ) 
{
string _msg = ex.Message; 
throw; 
}
finally
{
}
}

/// <summary>
/// Given an object/instance of class ModulosxGruposUsuario it saves it (insert) to the DataBase
/// </summary>
///<param name="pModulosxGruposUsuario">A BO of type ModulosxGruposUsuario</param>
public void Insert(ModulosxGruposUsuario pModulosxGruposUsuario)
{
if( pModulosxGruposUsuario == null  ) throw new ArgumentNullException("pModulosxGruposUsuario");
try 
{
BeginTransaction(false);
Session.Save(pModulosxGruposUsuario);
Commit(false);
}
catch ( Exception ex ) 
{
RollBack();
string _msg = ex.Message; 
throw; 
}
finally
{
CloseSession(false);
}
}

/// <summary>
/// Given an List of BO of class ModulosxGruposUsuario it Inserts them into the DataBase
/// </summary>
///<param name="pListModulosxGruposUsuario">A List of ModulosxGruposUsuario</param>
public void Insert(IEnumerable<ModulosxGruposUsuario> pListModulosxGruposUsuario)
{
if( pListModulosxGruposUsuario == null  ) throw new ArgumentNullException("pListModulosxGruposUsuario");
try 
{
BeginTransaction(false);
foreach ( ModulosxGruposUsuario _ModulosxGruposUsuario in pListModulosxGruposUsuario ) 
{
Session.Save(_ModulosxGruposUsuario);
}
Commit(false);
}
catch ( Exception ex ) 
{
RollBack();
string _msg = ex.Message; 
throw; 
}
finally
{
CloseSession(false);
}
}

/// <summary>
/// Saves the object passed as parameter.
/// </summary>
///<param name="pModulosxGruposUsuario">A BO of type ModulosxGruposUsuario</param>
public void Save(ModulosxGruposUsuario pModulosxGruposUsuario)
{
if( pModulosxGruposUsuario == null  ) throw new ArgumentNullException("pModulosxGruposUsuario");
try 
{
BeginTransaction(false);
Session.Update(pModulosxGruposUsuario);
Commit(false);
}
catch ( Exception ex ) 
{
RollBack();
string _msg = ex.Message; 
throw; 
}
finally
{
CloseSession(false);
}
}

/// <summary>
/// Deletes an object of Type ModulosxGruposUsuario
/// </summary>
///<param name="pModulosxGruposUsuario">A BO of type ModulosxGruposUsuario</param>
public void Delete(ModulosxGruposUsuario pModulosxGruposUsuario)
{
if( pModulosxGruposUsuario == null  ) throw new ArgumentNullException("pModulosxGruposUsuario");
try 
{
BeginTransaction(false);
Session.Delete(pModulosxGruposUsuario);
Commit(false);
}
catch ( Exception ex ) 
{
RollBack();
string _msg = ex.Message; 
throw; 
}
finally
{
CloseSession(false);
}
}

/// <summary>
/// Deletes multiple objects of Type ModulosxGruposUsuario inside one transaction.
/// </summary>
///<param name="pListModulosxGruposUsuario">A List of ModulosxGruposUsuario</param>
public void Delete(IEnumerable<ModulosxGruposUsuario> pListModulosxGruposUsuario)
{
if( pListModulosxGruposUsuario == null  ) throw new ArgumentNullException("pListModulosxGruposUsuario");
try 
{
BeginTransaction(false);
foreach ( ModulosxGruposUsuario _ModulosxGruposUsuario in pListModulosxGruposUsuario ) 
{
Session.Delete(_ModulosxGruposUsuario);
}
Commit(false);
}
catch ( Exception ex ) 
{
RollBack();
string _msg = ex.Message; 
throw; 
}
finally
{
CloseSession(false);
}
}

/// <summary>
/// Delete a ModulosxGruposUsuario object by using it's primary key.Use this method whenever you have the PK values instead of having the object reference.
/// </summary>
/// <remarks>
/// Please note that this methods needs an extra fetch to retrieve the object. The overload that takes the object is more efficient so use that one if you have an object instance
/// </remarks>
public void Delete(System.String pCodModulo , System.String pCodGruposUsu)
{
ModulosxGruposUsuario _modulosxGruposUsuario = Fetch(pCodModulo , pCodGruposUsu);
if ( _modulosxGruposUsuario == null ) throw new Exception("Object not found , could not delete");
Delete(_modulosxGruposUsuario);

}

/// <summary>
/// Dummy method needed to make this Factory work against an ObjectDataSource
/// </summary>
///<param name="pModulosxGruposUsuario">A BO of type ModulosxGruposUsuario</param>
public ModulosxGruposUsuario Dummy(ModulosxGruposUsuario pModulosxGruposUsuario)
{
if( pModulosxGruposUsuario == null  ) throw new ArgumentNullException("pModulosxGruposUsuario");
return pModulosxGruposUsuario;

}


#endregion
}
}

