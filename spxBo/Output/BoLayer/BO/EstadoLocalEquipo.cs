using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class EstadoLocalEquipo : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _codEstadoLocal;
private System.String _nombreEstadoLocal;
private System.String _descripcion;
private IList<EntradaSalidaEquipo> _entradaSalidaEquipos;
private IList<Equipo> _equipos;

#endregion


#region --- Class Properties ---

public virtual System.String CodEstadoLocal 
{
get
{
return _codEstadoLocal;
}
set 
{
if ( _codEstadoLocal != value) 
{
_codEstadoLocal = value ;
OnPropertyChanged("CodEstadoLocal");
}
}
}

public virtual System.String NombreEstadoLocal 
{
get
{
return _nombreEstadoLocal;
}
set 
{
if ( _nombreEstadoLocal != value) 
{
_nombreEstadoLocal = value ;
OnPropertyChanged("NombreEstadoLocal");
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
/// Collection of EntradaSalidaEquipo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "0b096251-9ced-45fe-821b-bf0abd1d1f09" , CollectionOfType = typeof(EntradaSalidaEquipo)) ]
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
/// Collection of Equipo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "743e5853-5911-4adf-beb9-f28d629fe8fd" , CollectionOfType = typeof(Equipo)) ]
public virtual IList<Equipo> Equipos 
{
get
{
 if (_equipos == null) _equipos = new List<Equipo>();

return _equipos;
}
set 
{
if ( _equipos != value) 
{
_equipos = value ;
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
/// Create a new EstadoLocalEquipo object. 
/// </summary>
public  EstadoLocalEquipo()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  EstadoLocalEquipo(System.String pCodEstadoLocal)
{
_codEstadoLocal = pCodEstadoLocal ;

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
// Call Validator IsRequired for Column : codEstadoLocal(Type:Required Field Validator)
_error = this.ValidatecodEstadoLocalIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : nombreEstadoLocal(Type:Required Field Validator)
_error = this.ValidatenombreEstadoLocalIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(CodEstadoLocal) ) 
{
   _errors.Add( new Error( "The PK Column (codEstadoLocal) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codEstadoLocal
/// </remarks>
public virtual Error ValidatecodEstadoLocalIsRequired()
{
if ( String.IsNullOrEmpty(CodEstadoLocal) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codEstadoLocal is required and therefore must have a value." ;
 return _error;
}
 return null;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : nombreEstadoLocal
/// </remarks>
public virtual Error ValidatenombreEstadoLocalIsRequired()
{
if ( String.IsNullOrEmpty(NombreEstadoLocal) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "nombreEstadoLocal is required and therefore must have a value." ;
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

