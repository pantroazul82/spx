using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class EstadoFisicamente : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _codEstadoFisicamente;
private System.String _nombreEstadoFisicamente;
private IList<EntradaSalidaEquipo> _entradaSalidaEquipos;

#endregion


#region --- Class Properties ---

public virtual System.String CodEstadoFisicamente 
{
get
{
return _codEstadoFisicamente;
}
set 
{
if ( _codEstadoFisicamente != value) 
{
_codEstadoFisicamente = value ;
OnPropertyChanged("CodEstadoFisicamente");
}
}
}

public virtual System.String NombreEstadoFisicamente 
{
get
{
return _nombreEstadoFisicamente;
}
set 
{
if ( _nombreEstadoFisicamente != value) 
{
_nombreEstadoFisicamente = value ;
OnPropertyChanged("NombreEstadoFisicamente");
}
}
}

/// <summary>
/// Collection of EntradaSalidaEquipo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "77878183-02bf-4b00-b9bc-6643c39d4110" , CollectionOfType = typeof(EntradaSalidaEquipo)) ]
public virtual IList<EntradaSalidaEquipo> EntradaSalidaEquipos 
{
get
{
 if (_entradaSalidaEquipos == null) _entradaSalidaEquipos = new List<EntradaSalidaEquipo>();

return _entradaSalidaEquipos;
}
set 
{
if ( _entradaSalidaEquipos != value) 
{
_entradaSalidaEquipos = value ;
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
/// Create a new EstadoFisicamente object. 
/// </summary>
public  EstadoFisicamente()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  EstadoFisicamente(System.String pCodEstadoFisicamente)
{
_codEstadoFisicamente = pCodEstadoFisicamente ;

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
// Call Validator IsRequired for Column : codEstadoFisicamente(Type:Required Field Validator)
_error = this.ValidatecodEstadoFisicamenteIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(CodEstadoFisicamente) ) 
{
   _errors.Add( new Error( "The PK Column (codEstadoFisicamente) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codEstadoFisicamente
/// </remarks>
public virtual Error ValidatecodEstadoFisicamenteIsRequired()
{
if ( String.IsNullOrEmpty(CodEstadoFisicamente) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codEstadoFisicamente is required and therefore must have a value." ;
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

