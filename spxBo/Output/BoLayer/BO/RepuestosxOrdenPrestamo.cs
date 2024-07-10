using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class RepuestosxOrdenPrestamo : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codOrdenPrestamo;
private System.String _codRepuesto;
private System.Int32? _cantidadSolicitada;
private System.Int32? _cantidadPrestada;
private System.Int32? _cantidadDevuelta;
private System.Int32? _cantidadConNotaSalida;
private System.Boolean? _entregadoIngeniero;
private System.Boolean? _devueltoAlmacen;
private System.Boolean? _notaSalida;
private System.String _obsNotaSalida;
private System.DateTime? _fechaEntregaIng;
private System.DateTime? _fechaDevolucion;
private System.DateTime? _fechaNotaSalida;
private OrdenPrestamo _ordenPrestamo;
private Repuesto _repuesto;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodOrdenPrestamo 
{
get
{
return _codOrdenPrestamo;
}
set 
{
if ( _codOrdenPrestamo != value) 
{
_codOrdenPrestamo = value ;
OnPropertyChanged("CodOrdenPrestamo");
}
}
}

public virtual System.String CodRepuesto 
{
get
{
return _codRepuesto;
}
set 
{
if ( _codRepuesto != value) 
{
_codRepuesto = value ;
OnPropertyChanged("CodRepuesto");
}
}
}

public virtual System.Int32? CantidadSolicitada 
{
get
{
return _cantidadSolicitada;
}
set 
{
if ( _cantidadSolicitada != value) 
{
_cantidadSolicitada = value ;
OnPropertyChanged("CantidadSolicitada");
}
}
}

public virtual System.Int32? CantidadPrestada 
{
get
{
return _cantidadPrestada;
}
set 
{
if ( _cantidadPrestada != value) 
{
_cantidadPrestada = value ;
OnPropertyChanged("CantidadPrestada");
}
}
}

public virtual System.Int32? CantidadDevuelta 
{
get
{
return _cantidadDevuelta;
}
set 
{
if ( _cantidadDevuelta != value) 
{
_cantidadDevuelta = value ;
OnPropertyChanged("CantidadDevuelta");
}
}
}

public virtual System.Int32? CantidadConNotaSalida 
{
get
{
return _cantidadConNotaSalida;
}
set 
{
if ( _cantidadConNotaSalida != value) 
{
_cantidadConNotaSalida = value ;
OnPropertyChanged("CantidadConNotaSalida");
}
}
}

public virtual System.Boolean? EntregadoIngeniero 
{
get
{
return _entregadoIngeniero;
}
set 
{
if ( _entregadoIngeniero != value) 
{
_entregadoIngeniero = value ;
OnPropertyChanged("EntregadoIngeniero");
}
}
}

public virtual System.Boolean? DevueltoAlmacen 
{
get
{
return _devueltoAlmacen;
}
set 
{
if ( _devueltoAlmacen != value) 
{
_devueltoAlmacen = value ;
OnPropertyChanged("DevueltoAlmacen");
}
}
}

public virtual System.Boolean? NotaSalida 
{
get
{
return _notaSalida;
}
set 
{
if ( _notaSalida != value) 
{
_notaSalida = value ;
OnPropertyChanged("NotaSalida");
}
}
}

public virtual System.String ObsNotaSalida 
{
get
{
return _obsNotaSalida;
}
set 
{
if ( _obsNotaSalida != value) 
{
_obsNotaSalida = value ;
OnPropertyChanged("ObsNotaSalida");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaEntregaIng_Date 
{
get
{
if (  !FechaEntregaIng.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaEntregaIng.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaEntregaIng.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaEntregaIng_Time)) {

FechaEntregaIng = null;
}
 else
{
 FechaEntregaIng = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaEntregaIng.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaEntregaIng_Time)) 
{
 FechaEntregaIng = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaEntregaIng = Convert.ToDateTime( " " + value + " " + FechaEntregaIng.Value.ToString("HH:mm:ss.fff") ) ;
}
}

}
}

/// <summary>
/// This property contains a calculated, bindable value of the TIME part of a DateTime property. If you want to only work with the TIME and ignore the underlying DATE component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaEntregaIng_Time 
{
get
{
if (  !FechaEntregaIng.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaEntregaIng.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaEntregaIng.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaEntregaIng_Date)) 
{
FechaEntregaIng = null;
}
 else
{
 FechaEntregaIng = Convert.ToDateTime( " " + FechaEntregaIng.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaEntregaIng_Date)) 
{
 FechaEntregaIng = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaEntregaIng = Convert.ToDateTime( " " + FechaEntregaIng_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaEntregaIng 
{
get
{
return _fechaEntregaIng;
}
set 
{
if ( _fechaEntregaIng != value) 
{
_fechaEntregaIng = value ;
OnPropertyChanged("FechaEntregaIng");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaDevolucion_Date 
{
get
{
if (  !FechaDevolucion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaDevolucion.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaDevolucion.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaDevolucion_Time)) {

FechaDevolucion = null;
}
 else
{
 FechaDevolucion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaDevolucion.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaDevolucion_Time)) 
{
 FechaDevolucion = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaDevolucion = Convert.ToDateTime( " " + value + " " + FechaDevolucion.Value.ToString("HH:mm:ss.fff") ) ;
}
}

}
}

/// <summary>
/// This property contains a calculated, bindable value of the TIME part of a DateTime property. If you want to only work with the TIME and ignore the underlying DATE component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaDevolucion_Time 
{
get
{
if (  !FechaDevolucion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaDevolucion.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaDevolucion.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaDevolucion_Date)) 
{
FechaDevolucion = null;
}
 else
{
 FechaDevolucion = Convert.ToDateTime( " " + FechaDevolucion.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaDevolucion_Date)) 
{
 FechaDevolucion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaDevolucion = Convert.ToDateTime( " " + FechaDevolucion_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaDevolucion 
{
get
{
return _fechaDevolucion;
}
set 
{
if ( _fechaDevolucion != value) 
{
_fechaDevolucion = value ;
OnPropertyChanged("FechaDevolucion");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaNotaSalida_Date 
{
get
{
if (  !FechaNotaSalida.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaNotaSalida.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaNotaSalida.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaNotaSalida_Time)) {

FechaNotaSalida = null;
}
 else
{
 FechaNotaSalida = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaNotaSalida.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaNotaSalida_Time)) 
{
 FechaNotaSalida = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaNotaSalida = Convert.ToDateTime( " " + value + " " + FechaNotaSalida.Value.ToString("HH:mm:ss.fff") ) ;
}
}

}
}

/// <summary>
/// This property contains a calculated, bindable value of the TIME part of a DateTime property. If you want to only work with the TIME and ignore the underlying DATE component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaNotaSalida_Time 
{
get
{
if (  !FechaNotaSalida.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaNotaSalida.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaNotaSalida.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaNotaSalida_Date)) 
{
FechaNotaSalida = null;
}
 else
{
 FechaNotaSalida = Convert.ToDateTime( " " + FechaNotaSalida.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaNotaSalida_Date)) 
{
 FechaNotaSalida = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaNotaSalida = Convert.ToDateTime( " " + FechaNotaSalida_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaNotaSalida 
{
get
{
return _fechaNotaSalida;
}
set 
{
if ( _fechaNotaSalida != value) 
{
_fechaNotaSalida = value ;
OnPropertyChanged("FechaNotaSalida");
}
}
}

/// <summary>
/// Generated from Relation FK_repuestosxOrdenPrestamo_OrdenPrestamo
/// </summary>
[GenWiseAttribute(RelationID = "74019717-2af9-434b-941f-c3c0e91479a8") ]
public virtual OrdenPrestamo OrdenPrestamo 
{
get
{
if ( _ordenPrestamo == null ) 
{
if (  _codOrdenPrestamo.Equals(0)  || _codOrdenPrestamo.Equals(System.Int32.MinValue) ) 
{
if ( _ordenPrestamo != null && ( _ordenPrestamo.CodOrdenPrestamo.Equals(System.Int32.MinValue) ) )
{
  _ordenPrestamo = null;
}
}
else
{
_ordenPrestamo = (new OrdenPrestamoFactory()).Get(_codOrdenPrestamo);
}
}

return _ordenPrestamo;
}
set 
{
if ( _ordenPrestamo != value) 
{
if ( value==null ) _codOrdenPrestamo = System.Int32.MinValue; else _codOrdenPrestamo = (System.Int32)value.CodOrdenPrestamo; 
_ordenPrestamo = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_repuestosxOrdenPrestamo_repuestos
/// </summary>
[GenWiseAttribute(RelationID = "0adff025-e44a-49bb-8be0-6aa0a8de2cac") ]
public virtual Repuesto Repuesto 
{
get
{
if ( _repuesto == null ) 
{
if ( String.IsNullOrEmpty(_codRepuesto) || _codRepuesto.Equals(string.Empty) ) 
{
if ( _repuesto != null && ( _repuesto.CodRepuesto.Equals(string.Empty) ) )
{
  _repuesto = null;
}
}
else
{
_repuesto = (new RepuestoFactory()).Get(_codRepuesto);
}
}

return _repuesto;
}
set 
{
if ( _repuesto != value) 
{
if ( value==null ) _codRepuesto = string.Empty; else _codRepuesto = (System.String)value.CodRepuesto; 
_repuesto = value ;
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

_retValue += CodOrdenPrestamo.ToString();

_retValue += "^";
if ( CodRepuesto != null ) _retValue += CodRepuesto.ToString();

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
/// Create a new RepuestosxOrdenPrestamo object. 
/// </summary>
public  RepuestosxOrdenPrestamo()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  RepuestosxOrdenPrestamo(System.Int32 pCodOrdenPrestamo , System.String pCodRepuesto)
{
_codOrdenPrestamo = pCodOrdenPrestamo ;
_codRepuesto = pCodRepuesto ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
_hash += CodOrdenPrestamo.ToString();
if ( CodRepuesto != null ) _hash += CodRepuesto.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
RepuestosxOrdenPrestamo _newRepuestosxOrdenPrestamo = (pObject as RepuestosxOrdenPrestamo); 
if (_newRepuestosxOrdenPrestamo == null ) return false; 
if (_newRepuestosxOrdenPrestamo.GetHashCode() == this.GetHashCode() ) return true; 
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
// Call Validator IsRequired for Column : codRepuesto(Type:Required Field Validator)
_error = this.ValidatecodRepuestoIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if (  CodOrdenPrestamo.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codOrdenPrestamo) can not be null!. " ) );
}
if ( String.IsNullOrEmpty(CodRepuesto) ) 
{
   _errors.Add( new Error( "The PK Column (codRepuesto) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codRepuesto
/// </remarks>
public virtual Error ValidatecodRepuestoIsRequired()
{
if ( String.IsNullOrEmpty(CodRepuesto) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codRepuesto is required and therefore must have a value." ;
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

