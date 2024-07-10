using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class CGQ_Query : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codQuery;
private System.String _nombreQuery;
private System.String _sql;
private IList<CGQ_ParametrosQuery> _cGQ_ParametrosQueries;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodQuery 
{
get
{
return _codQuery;
}
set 
{
if ( _codQuery != value) 
{
_codQuery = value ;
OnPropertyChanged("CodQuery");
}
}
}

public virtual System.String NombreQuery 
{
get
{
return _nombreQuery;
}
set 
{
if ( _nombreQuery != value) 
{
_nombreQuery = value ;
OnPropertyChanged("NombreQuery");
}
}
}

public virtual System.String Sql 
{
get
{
return _sql;
}
set 
{
if ( _sql != value) 
{
_sql = value ;
OnPropertyChanged("Sql");
}
}
}

/// <summary>
/// Collection of CGQ_ParametrosQuery.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "89d028c8-4850-479e-b218-59235626dab0" , CollectionOfType = typeof(CGQ_ParametrosQuery)) ]
public virtual IList<CGQ_ParametrosQuery> CGQ_ParametrosQueries 
{
get
{
 if (_cGQ_ParametrosQueries == null) _cGQ_ParametrosQueries = new List<CGQ_ParametrosQuery>();

return _cGQ_ParametrosQueries;
}
set 
{
if ( _cGQ_ParametrosQueries != value) 
{
_cGQ_ParametrosQueries = value ;
}
}
}

/// <summary>
/// Is this object Valid? 
/// </summary>
/// <remarks>
/// This is achieved by counting how many errors are returned from the Validate() method. If no errors are found then it's valid.
/// </remarks>
[Bindable(false)]
public virtual System.Boolean IsValid 
{
get
{
List<Error> _errors = this.Validate(); if ( _errors.Count > 0 ) return false; else return true;
}
}


#endregion


#region --- Class Methods --- 

/// <summary>
/// Raises PropertyChanged event.
/// </summary>
protected virtual void OnPropertyChanged(System.String pPropertyChanged)
{
if (_propertyChanged != null) _propertyChanged( this , new PropertyChangedEventArgs(pPropertyChanged));

}

/// <summary>
/// Create a new CGQ_Query object. 
/// </summary>
public  CGQ_Query()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  CGQ_Query(System.Int32 pCodQuery)
{
_codQuery = pCodQuery ;

}

/// <summary>
/// Validates the object returning a list of errors if the validation fails.
/// </summary>
/// <remarks>
/// You can use the provided User CodeBlocks to add your own validations.
/// </remarks>
///<returns>Returns the List of Errors found during the Validation. If no errors are found null is returned.<returns>
public virtual List<Error> Validate()
{
List<Error> _errors = new List<Error>();

// Primary Key Validation (Template Option)
if (  CodQuery.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codQuery) can not be null!. " ) );
}

return _errors;
}


#endregion


#region --- Class Events  ---

public virtual event PropertyChangedEventHandler PropertyChanged 
{
   add {
_propertyChanged+= value;
   }
   remove {
_propertyChanged-= value;
   }
}


#endregion
}
}

