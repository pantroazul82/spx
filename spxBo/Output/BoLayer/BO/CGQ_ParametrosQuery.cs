using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class CGQ_ParametrosQuery : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codQuery;
private System.Int32 _codParametrosQuery;
private System.String _campo;
private System.String _caption;
private System.Int32? _codTipoFiltro;
private CGQ_Query _cGQ_Query;
private CGQ_TipoFiltro _cGQ_TipoFiltro;

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

public virtual System.Int32 CodParametrosQuery 
{
get
{
return _codParametrosQuery;
}
set 
{
if ( _codParametrosQuery != value) 
{
_codParametrosQuery = value ;
OnPropertyChanged("CodParametrosQuery");
}
}
}

public virtual System.String Campo 
{
get
{
return _campo;
}
set 
{
if ( _campo != value) 
{
_campo = value ;
OnPropertyChanged("Campo");
}
}
}

public virtual System.String Caption 
{
get
{
return _caption;
}
set 
{
if ( _caption != value) 
{
_caption = value ;
OnPropertyChanged("Caption");
}
}
}

public virtual System.Int32? CodTipoFiltro 
{
get
{
if ( CGQ_TipoFiltro != null ) 
{
_codTipoFiltro = (System.Int32)CGQ_TipoFiltro.CodTipoFiltro;
}

return _codTipoFiltro;
}
set 
{
if ( _codTipoFiltro != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_cGQ_TipoFiltro = null;

_codTipoFiltro = value ;
OnPropertyChanged("CodTipoFiltro");
}
}
}

/// <summary>
/// Generated from Relation FK_CGQ_ParametrosQuery_CGQ_Query
/// </summary>
[GenWiseAttribute(RelationID = "89d028c8-4850-479e-b218-59235626dab0") ]
public virtual CGQ_Query CGQ_Query 
{
get
{
if ( _cGQ_Query == null ) 
{
if (  _codQuery.Equals(0)  || _codQuery.Equals(System.Int32.MinValue) ) 
{
if ( _cGQ_Query != null && ( _cGQ_Query.CodQuery.Equals(System.Int32.MinValue) ) )
{
  _cGQ_Query = null;
}
}
else
{
_cGQ_Query = (new CGQ_QueryFactory()).Get(_codQuery);
}
}

return _cGQ_Query;
}
set 
{
if ( _cGQ_Query != value) 
{
if ( value==null ) _codQuery = System.Int32.MinValue; else _codQuery = (System.Int32)value.CodQuery; 
_cGQ_Query = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_CGQ_ParametrosQuery_CGQ_TipoFiltro
/// </summary>
[GenWiseAttribute(RelationID = "dcb74fa7-1b0b-4e08-864e-e4988e4c5578") ]
public virtual CGQ_TipoFiltro CGQ_TipoFiltro 
{
get
{
if ( _cGQ_TipoFiltro == null ) 
{
if ( !_codTipoFiltro.HasValue || _codTipoFiltro.Value.Equals(System.Int32.MinValue) ) 
{
if ( _cGQ_TipoFiltro != null && ( _cGQ_TipoFiltro.CodTipoFiltro.Equals(null) ) )
{
  _cGQ_TipoFiltro = null;
}
}
else
{
_cGQ_TipoFiltro = (new CGQ_TipoFiltroFactory()).Get(_codTipoFiltro.Value);
}
}

return _cGQ_TipoFiltro;
}
set 
{
if ( _cGQ_TipoFiltro != value) 
{
if ( value==null ) _codTipoFiltro = null; else _codTipoFiltro = (System.Int32)value.CodTipoFiltro; 
_cGQ_TipoFiltro = value ;
}
}
}

/// <summary>
/// Property that simulates a unique PK by concatenating all the Pk properties
/// </summary>
public virtual System.String VirtualPk 
{
get
{
string _retValue = string.Empty;

_retValue += CodQuery.ToString();

_retValue += "^";
_retValue += CodParametrosQuery.ToString();

return _retValue;

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
/// Create a new CGQ_ParametrosQuery object. 
/// </summary>
public  CGQ_ParametrosQuery()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  CGQ_ParametrosQuery(System.Int32 pCodQuery , System.Int32 pCodParametrosQuery)
{
_codQuery = pCodQuery ;
_codParametrosQuery = pCodParametrosQuery ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
_hash += CodQuery.ToString();
_hash += CodParametrosQuery.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
CGQ_ParametrosQuery _newCGQ_ParametrosQuery = (pObject as CGQ_ParametrosQuery); 
if (_newCGQ_ParametrosQuery == null ) return false; 
if (_newCGQ_ParametrosQuery.GetHashCode() == this.GetHashCode() ) return true; 
return false; 

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
if (  CodParametrosQuery.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codParametrosQuery) can not be null!. " ) );
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

