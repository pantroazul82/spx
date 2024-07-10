using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class SubTipoEquipo : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _codTipoEquipo;
private System.String _codSubtipoEquipo;
private System.String _nombreSubTipo;
private IList<Modelo> _modelos;
private TipoEquipo _tipoEquipo;

#endregion


#region --- Class Properties ---

public virtual System.String CodTipoEquipo 
{
get
{
return _codTipoEquipo;
}
set 
{
if ( _codTipoEquipo != value) 
{
_codTipoEquipo = value ;
OnPropertyChanged("CodTipoEquipo");
}
}
}

public virtual System.String CodSubtipoEquipo 
{
get
{
return _codSubtipoEquipo;
}
set 
{
if ( _codSubtipoEquipo != value) 
{
_codSubtipoEquipo = value ;
OnPropertyChanged("CodSubtipoEquipo");
}
}
}

public virtual System.String NombreSubTipo 
{
get
{
return _nombreSubTipo;
}
set 
{
if ( _nombreSubTipo != value) 
{
_nombreSubTipo = value ;
OnPropertyChanged("NombreSubTipo");
}
}
}

/// <summary>
/// Collection of Modelo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "876378f9-e2f3-4827-9cf7-6f61254d14c8" , CollectionOfType = typeof(Modelo)) ]
public virtual IList<Modelo> Modelos 
{
get
{
 if (_modelos == null) _modelos = new List<Modelo>();

return _modelos;
}
set 
{
if ( _modelos != value) 
{
_modelos = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_subTipoEquipo_tipoEquipo
/// </summary>
[GenWiseAttribute(RelationID = "83415e57-f07f-4765-a2f9-2f1fce21d246") ]
public virtual TipoEquipo TipoEquipo 
{
get
{
if ( _tipoEquipo == null ) 
{
if ( String.IsNullOrEmpty(_codTipoEquipo) || _codTipoEquipo.Equals(string.Empty) ) 
{
if ( _tipoEquipo != null && ( _tipoEquipo.CodTipoEquipo.Equals(string.Empty) ) )
{
  _tipoEquipo = null;
}
}
else
{
_tipoEquipo = (new TipoEquipoFactory()).Get(_codTipoEquipo);
}
}

return _tipoEquipo;
}
set 
{
if ( _tipoEquipo != value) 
{
if ( value==null ) _codTipoEquipo = string.Empty; else _codTipoEquipo = (System.String)value.CodTipoEquipo; 
_tipoEquipo = value ;
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

if ( CodTipoEquipo != null ) _retValue += CodTipoEquipo.ToString();

_retValue += "^";
if ( CodSubtipoEquipo != null ) _retValue += CodSubtipoEquipo.ToString();

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
/// Create a new SubTipoEquipo object. 
/// </summary>
public  SubTipoEquipo()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  SubTipoEquipo(System.String pCodTipoEquipo , System.String pCodSubtipoEquipo)
{
_codTipoEquipo = pCodTipoEquipo ;
_codSubtipoEquipo = pCodSubtipoEquipo ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
if ( CodTipoEquipo != null ) _hash += CodTipoEquipo.ToString();
if ( CodSubtipoEquipo != null ) _hash += CodSubtipoEquipo.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
SubTipoEquipo _newSubTipoEquipo = (pObject as SubTipoEquipo); 
if (_newSubTipoEquipo == null ) return false; 
if (_newSubTipoEquipo.GetHashCode() == this.GetHashCode() ) return true; 
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
Error _error;
// Call Validator IsRequired for Column : codTipoEquipo(Type:Required Field Validator)
_error = this.ValidatecodTipoEquipoIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : codSubtipoEquipo(Type:Required Field Validator)
_error = this.ValidatecodSubtipoEquipoIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(CodTipoEquipo) ) 
{
   _errors.Add( new Error( "The PK Column (codTipoEquipo) can not be null!. " ) );
}
if ( String.IsNullOrEmpty(CodSubtipoEquipo) ) 
{
   _errors.Add( new Error( "The PK Column (codSubtipoEquipo) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codTipoEquipo
/// </remarks>
public virtual Error ValidatecodTipoEquipoIsRequired()
{
if ( String.IsNullOrEmpty(CodTipoEquipo) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codTipoEquipo is required and therefore must have a value." ;
 return _error;
}
 return null;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codSubtipoEquipo
/// </remarks>
public virtual Error ValidatecodSubtipoEquipoIsRequired()
{
if ( String.IsNullOrEmpty(CodSubtipoEquipo) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codSubtipoEquipo is required and therefore must have a value." ;
 return _error;
}
 return null;
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

