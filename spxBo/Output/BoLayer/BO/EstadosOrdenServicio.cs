using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class EstadosOrdenServicio : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _codEstadoOrdenServicio;
private System.String _nombreEstado;
private System.String _descripcion;
private IList<OrdenServicio> _ordenServicios;

#endregion


#region --- Class Properties ---

public virtual System.String CodEstadoOrdenServicio 
{
get
{
return _codEstadoOrdenServicio;
}
set 
{
if ( _codEstadoOrdenServicio != value) 
{
_codEstadoOrdenServicio = value ;
OnPropertyChanged("CodEstadoOrdenServicio");
}
}
}

public virtual System.String NombreEstado 
{
get
{
return _nombreEstado;
}
set 
{
if ( _nombreEstado != value) 
{
_nombreEstado = value ;
OnPropertyChanged("NombreEstado");
}
}
}

public virtual System.String Descripcion 
{
get
{
return _descripcion;
}
set 
{
if ( _descripcion != value) 
{
_descripcion = value ;
OnPropertyChanged("Descripcion");
}
}
}

/// <summary>
/// Collection of OrdenServicio.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "d9efbe2f-0abe-48ed-a7fd-6172001a7f9f" , CollectionOfType = typeof(OrdenServicio)) ]
public virtual IList<OrdenServicio> OrdenServicios 
{
get
{
 if (_ordenServicios == null) _ordenServicios = new List<OrdenServicio>();

return _ordenServicios;
}
set 
{
if ( _ordenServicios != value) 
{
_ordenServicios = value ;
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
/// Create a new EstadosOrdenServicio object. 
/// </summary>
public  EstadosOrdenServicio()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  EstadosOrdenServicio(System.String pCodEstadoOrdenServicio)
{
_codEstadoOrdenServicio = pCodEstadoOrdenServicio ;

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
// Call Validator IsRequired for Column : codEstadoOrdenServicio(Type:Required Field Validator)
_error = this.ValidatecodEstadoOrdenServicioIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(CodEstadoOrdenServicio) ) 
{
   _errors.Add( new Error( "The PK Column (codEstadoOrdenServicio) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codEstadoOrdenServicio
/// </remarks>
public virtual Error ValidatecodEstadoOrdenServicioIsRequired()
{
if ( String.IsNullOrEmpty(CodEstadoOrdenServicio) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codEstadoOrdenServicio is required and therefore must have a value." ;
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

