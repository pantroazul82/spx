using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class Paise : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _codPais;
private System.String _nombrePais;
private IList<Departamento> _departamentos;

#endregion


#region --- Class Properties ---

public virtual System.String CodPais 
{
get
{
return _codPais;
}
set 
{
if ( _codPais != value) 
{
_codPais = value ;
OnPropertyChanged("CodPais");
}
}
}

public virtual System.String NombrePais 
{
get
{
return _nombrePais;
}
set 
{
if ( _nombrePais != value) 
{
_nombrePais = value ;
OnPropertyChanged("NombrePais");
}
}
}

/// <summary>
/// Collection of Departamento.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "5a0b777e-cd7a-443b-a9ef-3b76cb32708e" , CollectionOfType = typeof(Departamento)) ]
public virtual IList<Departamento> Departamentos 
{
get
{
 if (_departamentos == null) _departamentos = new List<Departamento>();

return _departamentos;
}
set 
{
if ( _departamentos != value) 
{
_departamentos = value ;
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
/// Create a new Paise object. 
/// </summary>
public  Paise()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  Paise(System.String pCodPais)
{
_codPais = pCodPais ;

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
// Call Validator IsRequired for Column : codPais(Type:Required Field Validator)
_error = this.ValidatecodPaisIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(CodPais) ) 
{
   _errors.Add( new Error( "The PK Column (codPais) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codPais
/// </remarks>
public virtual Error ValidatecodPaisIsRequired()
{
if ( String.IsNullOrEmpty(CodPais) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codPais is required and therefore must have a value." ;
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

