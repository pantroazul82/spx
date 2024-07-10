using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class EstadosLLamadasTecnica : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _codEstadoLlamada;
private System.String _nombreEstado;
private IList<LlamadaSoporte> _llamadaSoportes;

#endregion


#region --- Class Properties ---

public virtual System.String CodEstadoLlamada 
{
get
{
return _codEstadoLlamada;
}
set 
{
if ( _codEstadoLlamada != value) 
{
_codEstadoLlamada = value ;
OnPropertyChanged("CodEstadoLlamada");
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

/// <summary>
/// Collection of LlamadaSoporte.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "85fa8057-3645-4a42-8d88-110465fe93f0" , CollectionOfType = typeof(LlamadaSoporte)) ]
public virtual IList<LlamadaSoporte> LlamadaSoportes 
{
get
{
 if (_llamadaSoportes == null) _llamadaSoportes = new List<LlamadaSoporte>();

return _llamadaSoportes;
}
set 
{
if ( _llamadaSoportes != value) 
{
_llamadaSoportes = value ;
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
/// Create a new EstadosLLamadasTecnica object. 
/// </summary>
public  EstadosLLamadasTecnica()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  EstadosLLamadasTecnica(System.String pCodEstadoLlamada)
{
_codEstadoLlamada = pCodEstadoLlamada ;

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
// Call Validator IsRequired for Column : codEstadoLlamada(Type:Required Field Validator)
_error = this.ValidatecodEstadoLlamadaIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(CodEstadoLlamada) ) 
{
   _errors.Add( new Error( "The PK Column (codEstadoLlamada) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codEstadoLlamada
/// </remarks>
public virtual Error ValidatecodEstadoLlamadaIsRequired()
{
if ( String.IsNullOrEmpty(CodEstadoLlamada) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codEstadoLlamada is required and therefore must have a value." ;
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

