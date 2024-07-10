using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class TipoEquipo : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _codTipoEquipo;
private System.String _nombreTipoEquipo;
private IList<SubTipoEquipo> _subTipoEquipos;

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

public virtual System.String NombreTipoEquipo 
{
get
{
return _nombreTipoEquipo;
}
set 
{
if ( _nombreTipoEquipo != value) 
{
_nombreTipoEquipo = value ;
OnPropertyChanged("NombreTipoEquipo");
}
}
}

/// <summary>
/// Collection of SubTipoEquipo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "83415e57-f07f-4765-a2f9-2f1fce21d246" , CollectionOfType = typeof(SubTipoEquipo)) ]
public virtual IList<SubTipoEquipo> SubTipoEquipos 
{
get
{
 if (_subTipoEquipos == null) _subTipoEquipos = new List<SubTipoEquipo>();

return _subTipoEquipos;
}
set 
{
if ( _subTipoEquipos != value) 
{
_subTipoEquipos = value ;
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
/// Create a new TipoEquipo object. 
/// </summary>
public  TipoEquipo()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  TipoEquipo(System.String pCodTipoEquipo)
{
_codTipoEquipo = pCodTipoEquipo ;

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

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(CodTipoEquipo) ) 
{
   _errors.Add( new Error( "The PK Column (codTipoEquipo) can not be null!. " ) );
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

