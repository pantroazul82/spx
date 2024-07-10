using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class Prioridad : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _codPrioridad;
private System.String _nombrePrioridad;
private System.String _descripcionPrioridad;
private System.Int32? _orden;
private IList<Task> _tasks;

#endregion


#region --- Class Properties ---

public virtual System.String CodPrioridad 
{
get
{
return _codPrioridad;
}
set 
{
if ( _codPrioridad != value) 
{
_codPrioridad = value ;
OnPropertyChanged("CodPrioridad");
}
}
}

public virtual System.String NombrePrioridad 
{
get
{
return _nombrePrioridad;
}
set 
{
if ( _nombrePrioridad != value) 
{
_nombrePrioridad = value ;
OnPropertyChanged("NombrePrioridad");
}
}
}

public virtual System.String DescripcionPrioridad 
{
get
{
return _descripcionPrioridad;
}
set 
{
if ( _descripcionPrioridad != value) 
{
_descripcionPrioridad = value ;
OnPropertyChanged("DescripcionPrioridad");
}
}
}

public virtual System.Int32? Orden 
{
get
{
return _orden;
}
set 
{
if ( _orden != value) 
{
_orden = value ;
OnPropertyChanged("Orden");
}
}
}

/// <summary>
/// Collection of Task.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "1725bcf1-591a-45c3-985e-ae4cfbea5fc3" , CollectionOfType = typeof(Task)) ]
public virtual IList<Task> Tasks 
{
get
{
 if (_tasks == null) _tasks = new List<Task>();

return _tasks;
}
set 
{
if ( _tasks != value) 
{
_tasks = value ;
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
/// Create a new Prioridad object. 
/// </summary>
public  Prioridad()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  Prioridad(System.String pCodPrioridad)
{
_codPrioridad = pCodPrioridad ;

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
// Call Validator IsRequired for Column : codPrioridad(Type:Required Field Validator)
_error = this.ValidatecodPrioridadIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : nombrePrioridad(Type:Required Field Validator)
_error = this.ValidatenombrePrioridadIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(CodPrioridad) ) 
{
   _errors.Add( new Error( "The PK Column (codPrioridad) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codPrioridad
/// </remarks>
public virtual Error ValidatecodPrioridadIsRequired()
{
if ( String.IsNullOrEmpty(CodPrioridad) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codPrioridad is required and therefore must have a value." ;
 return _error;
}
 return null;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : nombrePrioridad
/// </remarks>
public virtual Error ValidatenombrePrioridadIsRequired()
{
if ( String.IsNullOrEmpty(NombrePrioridad) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "nombrePrioridad is required and therefore must have a value." ;
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

