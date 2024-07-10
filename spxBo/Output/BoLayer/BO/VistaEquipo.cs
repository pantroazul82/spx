using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class VistaEquipo : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _nombreFabricante;
private System.String _nombreModelo;
private System.String _nombreTipoEquipo;
private System.String _nombreSubTipo;
private System.String _nombreModalidadEquipo;
private System.String _nombreEstadoLocal;
private System.String _nitCliente;
private System.String _nombreCliente;
private System.String _nombreSucursal;
private System.String _nombrePais;
private System.String _nombreDepartamento;
private System.String _nombreCiudad;
private System.String _serial;
private System.DateTime? _fechaLlegada;
private System.DateTime? _fechaSalida;
private System.DateTime? _fechaProximoMante;
private System.DateTime? _fechaUltimoMante;
private System.String _codTipoServicio;
private System.String _observacionesUltimoMante;
private System.DateTime? _fechaProximaProgramacion;

#endregion


#region --- Class Properties ---

public virtual System.String NombreFabricante 
{
get
{
return _nombreFabricante;
}
set 
{
if ( _nombreFabricante != value) 
{
_nombreFabricante = value ;
OnPropertyChanged("NombreFabricante");
}
}
}

public virtual System.String NombreModelo 
{
get
{
return _nombreModelo;
}
set 
{
if ( _nombreModelo != value) 
{
_nombreModelo = value ;
OnPropertyChanged("NombreModelo");
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

public virtual System.String NombreModalidadEquipo 
{
get
{
return _nombreModalidadEquipo;
}
set 
{
if ( _nombreModalidadEquipo != value) 
{
_nombreModalidadEquipo = value ;
OnPropertyChanged("NombreModalidadEquipo");
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

public virtual System.String NitCliente 
{
get
{
return _nitCliente;
}
set 
{
if ( _nitCliente != value) 
{
_nitCliente = value ;
OnPropertyChanged("NitCliente");
}
}
}

public virtual System.String NombreCliente 
{
get
{
return _nombreCliente;
}
set 
{
if ( _nombreCliente != value) 
{
_nombreCliente = value ;
OnPropertyChanged("NombreCliente");
}
}
}

public virtual System.String NombreSucursal 
{
get
{
return _nombreSucursal;
}
set 
{
if ( _nombreSucursal != value) 
{
_nombreSucursal = value ;
OnPropertyChanged("NombreSucursal");
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

public virtual System.String NombreDepartamento 
{
get
{
return _nombreDepartamento;
}
set 
{
if ( _nombreDepartamento != value) 
{
_nombreDepartamento = value ;
OnPropertyChanged("NombreDepartamento");
}
}
}

public virtual System.String NombreCiudad 
{
get
{
return _nombreCiudad;
}
set 
{
if ( _nombreCiudad != value) 
{
_nombreCiudad = value ;
OnPropertyChanged("NombreCiudad");
}
}
}

public virtual System.String Serial 
{
get
{
return _serial;
}
set 
{
if ( _serial != value) 
{
_serial = value ;
OnPropertyChanged("Serial");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaLlegada_Date 
{
get
{
if (  !FechaLlegada.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaLlegada.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaLlegada.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaLlegada_Time)) {

FechaLlegada = null;
}
 else
{
 FechaLlegada = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaLlegada.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaLlegada_Time)) 
{
 FechaLlegada = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaLlegada = Convert.ToDateTime( " " + value + " " + FechaLlegada.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaLlegada_Time 
{
get
{
if (  !FechaLlegada.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaLlegada.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaLlegada.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaLlegada_Date)) 
{
FechaLlegada = null;
}
 else
{
 FechaLlegada = Convert.ToDateTime( " " + FechaLlegada.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaLlegada_Date)) 
{
 FechaLlegada = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaLlegada = Convert.ToDateTime( " " + FechaLlegada_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaLlegada 
{
get
{
return _fechaLlegada;
}
set 
{
if ( _fechaLlegada != value) 
{
_fechaLlegada = value ;
OnPropertyChanged("FechaLlegada");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaSalida_Date 
{
get
{
if (  !FechaSalida.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaSalida.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaSalida.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaSalida_Time)) {

FechaSalida = null;
}
 else
{
 FechaSalida = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaSalida.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaSalida_Time)) 
{
 FechaSalida = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaSalida = Convert.ToDateTime( " " + value + " " + FechaSalida.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaSalida_Time 
{
get
{
if (  !FechaSalida.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaSalida.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaSalida.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaSalida_Date)) 
{
FechaSalida = null;
}
 else
{
 FechaSalida = Convert.ToDateTime( " " + FechaSalida.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaSalida_Date)) 
{
 FechaSalida = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaSalida = Convert.ToDateTime( " " + FechaSalida_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaSalida 
{
get
{
return _fechaSalida;
}
set 
{
if ( _fechaSalida != value) 
{
_fechaSalida = value ;
OnPropertyChanged("FechaSalida");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaProximoMante_Date 
{
get
{
if (  !FechaProximoMante.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaProximoMante.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaProximoMante.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaProximoMante_Time)) {

FechaProximoMante = null;
}
 else
{
 FechaProximoMante = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaProximoMante.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaProximoMante_Time)) 
{
 FechaProximoMante = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaProximoMante = Convert.ToDateTime( " " + value + " " + FechaProximoMante.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaProximoMante_Time 
{
get
{
if (  !FechaProximoMante.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaProximoMante.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaProximoMante.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaProximoMante_Date)) 
{
FechaProximoMante = null;
}
 else
{
 FechaProximoMante = Convert.ToDateTime( " " + FechaProximoMante.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaProximoMante_Date)) 
{
 FechaProximoMante = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaProximoMante = Convert.ToDateTime( " " + FechaProximoMante_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaProximoMante 
{
get
{
return _fechaProximoMante;
}
set 
{
if ( _fechaProximoMante != value) 
{
_fechaProximoMante = value ;
OnPropertyChanged("FechaProximoMante");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaUltimoMante_Date 
{
get
{
if (  !FechaUltimoMante.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaUltimoMante.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaUltimoMante.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaUltimoMante_Time)) {

FechaUltimoMante = null;
}
 else
{
 FechaUltimoMante = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaUltimoMante.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaUltimoMante_Time)) 
{
 FechaUltimoMante = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaUltimoMante = Convert.ToDateTime( " " + value + " " + FechaUltimoMante.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaUltimoMante_Time 
{
get
{
if (  !FechaUltimoMante.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaUltimoMante.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaUltimoMante.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaUltimoMante_Date)) 
{
FechaUltimoMante = null;
}
 else
{
 FechaUltimoMante = Convert.ToDateTime( " " + FechaUltimoMante.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaUltimoMante_Date)) 
{
 FechaUltimoMante = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaUltimoMante = Convert.ToDateTime( " " + FechaUltimoMante_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaUltimoMante 
{
get
{
return _fechaUltimoMante;
}
set 
{
if ( _fechaUltimoMante != value) 
{
_fechaUltimoMante = value ;
OnPropertyChanged("FechaUltimoMante");
}
}
}

public virtual System.String CodTipoServicio 
{
get
{
return _codTipoServicio;
}
set 
{
if ( _codTipoServicio != value) 
{
_codTipoServicio = value ;
OnPropertyChanged("CodTipoServicio");
}
}
}

public virtual System.String ObservacionesUltimoMante 
{
get
{
return _observacionesUltimoMante;
}
set 
{
if ( _observacionesUltimoMante != value) 
{
_observacionesUltimoMante = value ;
OnPropertyChanged("ObservacionesUltimoMante");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaProximaProgramacion_Date 
{
get
{
if (  !FechaProximaProgramacion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaProximaProgramacion.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaProximaProgramacion.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaProximaProgramacion_Time)) {

FechaProximaProgramacion = null;
}
 else
{
 FechaProximaProgramacion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaProximaProgramacion.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaProximaProgramacion_Time)) 
{
 FechaProximaProgramacion = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaProximaProgramacion = Convert.ToDateTime( " " + value + " " + FechaProximaProgramacion.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaProximaProgramacion_Time 
{
get
{
if (  !FechaProximaProgramacion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaProximaProgramacion.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaProximaProgramacion.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaProximaProgramacion_Date)) 
{
FechaProximaProgramacion = null;
}
 else
{
 FechaProximaProgramacion = Convert.ToDateTime( " " + FechaProximaProgramacion.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaProximaProgramacion_Date)) 
{
 FechaProximaProgramacion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaProximaProgramacion = Convert.ToDateTime( " " + FechaProximaProgramacion_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaProximaProgramacion 
{
get
{
return _fechaProximaProgramacion;
}
set 
{
if ( _fechaProximaProgramacion != value) 
{
_fechaProximaProgramacion = value ;
OnPropertyChanged("FechaProximaProgramacion");
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
/// Create a new VistaEquipo object. 
/// </summary>
public  VistaEquipo()
{
}

public override int GetHashCode()
{
string _hash = String.Empty; 
if ( NombreFabricante != null ) _hash += NombreFabricante.ToString();
if ( NombreModelo != null ) _hash += NombreModelo.ToString();
if ( NombreTipoEquipo != null ) _hash += NombreTipoEquipo.ToString();
if ( NombreSubTipo != null ) _hash += NombreSubTipo.ToString();
if ( NombreModalidadEquipo != null ) _hash += NombreModalidadEquipo.ToString();
if ( NombreEstadoLocal != null ) _hash += NombreEstadoLocal.ToString();
if ( NitCliente != null ) _hash += NitCliente.ToString();
if ( NombreCliente != null ) _hash += NombreCliente.ToString();
if ( NombreSucursal != null ) _hash += NombreSucursal.ToString();
if ( NombrePais != null ) _hash += NombrePais.ToString();
if ( NombreDepartamento != null ) _hash += NombreDepartamento.ToString();
if ( NombreCiudad != null ) _hash += NombreCiudad.ToString();
if ( Serial != null ) _hash += Serial.ToString();
_hash += FechaLlegada.ToString();
_hash += FechaSalida.ToString();
_hash += FechaProximoMante.ToString();
_hash += FechaUltimoMante.ToString();
if ( CodTipoServicio != null ) _hash += CodTipoServicio.ToString();
if ( ObservacionesUltimoMante != null ) _hash += ObservacionesUltimoMante.ToString();
_hash += FechaProximaProgramacion.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
VistaEquipo _newVistaEquipo = (pObject as VistaEquipo); 
if (_newVistaEquipo == null ) return false; 
if (_newVistaEquipo.GetHashCode() == this.GetHashCode() ) return true; 
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
// Call Validator IsRequired for Column : nombreFabricante(Type:Required Field Validator)
_error = this.ValidatenombreFabricanteIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : NombreModelo(Type:Required Field Validator)
_error = this.ValidateNombreModeloIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : nombreTipoEquipo(Type:Required Field Validator)
_error = this.ValidatenombreTipoEquipoIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : nombreSubTipo(Type:Required Field Validator)
_error = this.ValidatenombreSubTipoIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : nombreModalidadEquipo(Type:Required Field Validator)
_error = this.ValidatenombreModalidadEquipoIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : nombreEstadoLocal(Type:Required Field Validator)
_error = this.ValidatenombreEstadoLocalIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : serial(Type:Required Field Validator)
_error = this.ValidateserialIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : nombreFabricante
/// </remarks>
public virtual Error ValidatenombreFabricanteIsRequired()
{
if ( String.IsNullOrEmpty(NombreFabricante) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "nombreFabricante is required and therefore must have a value." ;
 return _error;
}
 return null;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : NombreModelo
/// </remarks>
public virtual Error ValidateNombreModeloIsRequired()
{
if ( String.IsNullOrEmpty(NombreModelo) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "NombreModelo is required and therefore must have a value." ;
 return _error;
}
 return null;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : nombreTipoEquipo
/// </remarks>
public virtual Error ValidatenombreTipoEquipoIsRequired()
{
if ( String.IsNullOrEmpty(NombreTipoEquipo) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "nombreTipoEquipo is required and therefore must have a value." ;
 return _error;
}
 return null;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : nombreSubTipo
/// </remarks>
public virtual Error ValidatenombreSubTipoIsRequired()
{
if ( String.IsNullOrEmpty(NombreSubTipo) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "nombreSubTipo is required and therefore must have a value." ;
 return _error;
}
 return null;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : nombreModalidadEquipo
/// </remarks>
public virtual Error ValidatenombreModalidadEquipoIsRequired()
{
if ( String.IsNullOrEmpty(NombreModalidadEquipo) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "nombreModalidadEquipo is required and therefore must have a value." ;
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

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : serial
/// </remarks>
public virtual Error ValidateserialIsRequired()
{
if ( String.IsNullOrEmpty(Serial) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "serial is required and therefore must have a value." ;
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

