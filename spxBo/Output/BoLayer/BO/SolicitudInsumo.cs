using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class SolicitudInsumo : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codOrdenServicio;
private System.Int32 _codSolicitud;
private System.Boolean? _aceptada;
private System.String _aprobadaPor;
private System.DateTime? _fechaAprobacion;
private System.String _numeroFactura;
private System.Double? _horasMantPreventivo;
private System.Double? _horasMantCorrectivo;
private System.Int32? _tiempoEstimadoEntrega;
private System.String _observaciones;
private System.DateTime? _fechaSolicitud;
private System.Double? _horasDiagnostico;
private System.String _autorizadoPor;
private System.Boolean? _autorizado;
private System.DateTime? _fechaAutorizacion;
private System.Int32? _codUnidadTiempo;
private IList<DetalleSolicitudInsumo> _detalleSolicitudInsumos;
private OrdenServicio _ordenServicio;
private UnidadTiempo _unidadTiempo;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodOrdenServicio 
{
get
{
return _codOrdenServicio;
}
set 
{
if ( _codOrdenServicio != value) 
{
_codOrdenServicio = value ;
OnPropertyChanged("CodOrdenServicio");
}
}
}

public virtual System.Int32 CodSolicitud 
{
get
{
return _codSolicitud;
}
set 
{
if ( _codSolicitud != value) 
{
_codSolicitud = value ;
OnPropertyChanged("CodSolicitud");
}
}
}

public virtual System.Boolean? Aceptada 
{
get
{
return _aceptada;
}
set 
{
if ( _aceptada != value) 
{
_aceptada = value ;
OnPropertyChanged("Aceptada");
}
}
}

public virtual System.String AprobadaPor 
{
get
{
return _aprobadaPor;
}
set 
{
if ( _aprobadaPor != value) 
{
_aprobadaPor = value ;
OnPropertyChanged("AprobadaPor");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaAprobacion_Date 
{
get
{
if (  !FechaAprobacion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaAprobacion.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaAprobacion.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaAprobacion_Time)) {

FechaAprobacion = null;
}
 else
{
 FechaAprobacion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaAprobacion.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaAprobacion_Time)) 
{
 FechaAprobacion = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaAprobacion = Convert.ToDateTime( " " + value + " " + FechaAprobacion.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaAprobacion_Time 
{
get
{
if (  !FechaAprobacion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaAprobacion.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaAprobacion.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaAprobacion_Date)) 
{
FechaAprobacion = null;
}
 else
{
 FechaAprobacion = Convert.ToDateTime( " " + FechaAprobacion.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaAprobacion_Date)) 
{
 FechaAprobacion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaAprobacion = Convert.ToDateTime( " " + FechaAprobacion_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaAprobacion 
{
get
{
return _fechaAprobacion;
}
set 
{
if ( _fechaAprobacion != value) 
{
_fechaAprobacion = value ;
OnPropertyChanged("FechaAprobacion");
}
}
}

public virtual System.String NumeroFactura 
{
get
{
return _numeroFactura;
}
set 
{
if ( _numeroFactura != value) 
{
_numeroFactura = value ;
OnPropertyChanged("NumeroFactura");
}
}
}

public virtual System.Double? HorasMantPreventivo 
{
get
{
return _horasMantPreventivo;
}
set 
{
if ( _horasMantPreventivo != value) 
{
_horasMantPreventivo = value ;
OnPropertyChanged("HorasMantPreventivo");
}
}
}

public virtual System.Double? HorasMantCorrectivo 
{
get
{
return _horasMantCorrectivo;
}
set 
{
if ( _horasMantCorrectivo != value) 
{
_horasMantCorrectivo = value ;
OnPropertyChanged("HorasMantCorrectivo");
}
}
}

public virtual System.Int32? TiempoEstimadoEntrega 
{
get
{
return _tiempoEstimadoEntrega;
}
set 
{
if ( _tiempoEstimadoEntrega != value) 
{
_tiempoEstimadoEntrega = value ;
OnPropertyChanged("TiempoEstimadoEntrega");
}
}
}

public virtual System.String Observaciones 
{
get
{
return _observaciones;
}
set 
{
if ( _observaciones != value) 
{
_observaciones = value ;
OnPropertyChanged("Observaciones");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaSolicitud_Date 
{
get
{
if (  !FechaSolicitud.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaSolicitud.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaSolicitud.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaSolicitud_Time)) {

FechaSolicitud = null;
}
 else
{
 FechaSolicitud = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaSolicitud.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaSolicitud_Time)) 
{
 FechaSolicitud = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaSolicitud = Convert.ToDateTime( " " + value + " " + FechaSolicitud.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaSolicitud_Time 
{
get
{
if (  !FechaSolicitud.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaSolicitud.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaSolicitud.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaSolicitud_Date)) 
{
FechaSolicitud = null;
}
 else
{
 FechaSolicitud = Convert.ToDateTime( " " + FechaSolicitud.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaSolicitud_Date)) 
{
 FechaSolicitud = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaSolicitud = Convert.ToDateTime( " " + FechaSolicitud_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaSolicitud 
{
get
{
return _fechaSolicitud;
}
set 
{
if ( _fechaSolicitud != value) 
{
_fechaSolicitud = value ;
OnPropertyChanged("FechaSolicitud");
}
}
}

public virtual System.Double? HorasDiagnostico 
{
get
{
return _horasDiagnostico;
}
set 
{
if ( _horasDiagnostico != value) 
{
_horasDiagnostico = value ;
OnPropertyChanged("HorasDiagnostico");
}
}
}

public virtual System.String AutorizadoPor 
{
get
{
return _autorizadoPor;
}
set 
{
if ( _autorizadoPor != value) 
{
_autorizadoPor = value ;
OnPropertyChanged("AutorizadoPor");
}
}
}

public virtual System.Boolean? Autorizado 
{
get
{
return _autorizado;
}
set 
{
if ( _autorizado != value) 
{
_autorizado = value ;
OnPropertyChanged("Autorizado");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaAutorizacion_Date 
{
get
{
if (  !FechaAutorizacion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaAutorizacion.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaAutorizacion.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaAutorizacion_Time)) {

FechaAutorizacion = null;
}
 else
{
 FechaAutorizacion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaAutorizacion.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaAutorizacion_Time)) 
{
 FechaAutorizacion = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaAutorizacion = Convert.ToDateTime( " " + value + " " + FechaAutorizacion.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaAutorizacion_Time 
{
get
{
if (  !FechaAutorizacion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaAutorizacion.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaAutorizacion.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaAutorizacion_Date)) 
{
FechaAutorizacion = null;
}
 else
{
 FechaAutorizacion = Convert.ToDateTime( " " + FechaAutorizacion.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaAutorizacion_Date)) 
{
 FechaAutorizacion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaAutorizacion = Convert.ToDateTime( " " + FechaAutorizacion_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaAutorizacion 
{
get
{
return _fechaAutorizacion;
}
set 
{
if ( _fechaAutorizacion != value) 
{
_fechaAutorizacion = value ;
OnPropertyChanged("FechaAutorizacion");
}
}
}

public virtual System.Int32? CodUnidadTiempo 
{
get
{
if ( UnidadTiempo != null ) 
{
_codUnidadTiempo = (System.Int32)UnidadTiempo.CodUnidadTiempo;
}

return _codUnidadTiempo;
}
set 
{
if ( _codUnidadTiempo != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_unidadTiempo = null;

_codUnidadTiempo = value ;
OnPropertyChanged("CodUnidadTiempo");
}
}
}

/// <summary>
/// Collection of DetalleSolicitudInsumo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "a83bee8a-81fb-4cd3-847b-79a8eac0511d" , CollectionOfType = typeof(DetalleSolicitudInsumo)) ]
public virtual IList<DetalleSolicitudInsumo> DetalleSolicitudInsumos 
{
get
{
 if (_detalleSolicitudInsumos == null) _detalleSolicitudInsumos = new List<DetalleSolicitudInsumo>();

return _detalleSolicitudInsumos;
}
set 
{
if ( _detalleSolicitudInsumos != value) 
{
_detalleSolicitudInsumos = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_solicitudInsumos_ordenServicio
/// </summary>
[GenWiseAttribute(RelationID = "75fee3cf-6fe6-4b17-b844-64aa339252d8") ]
public virtual OrdenServicio OrdenServicio 
{
get
{
if ( _ordenServicio == null ) 
{
if (  _codOrdenServicio.Equals(0)  || _codOrdenServicio.Equals(System.Int32.MinValue) ) 
{
if ( _ordenServicio != null && ( _ordenServicio.CodOrdenServicio.Equals(System.Int32.MinValue) ) )
{
  _ordenServicio = null;
}
}
else
{
_ordenServicio = (new OrdenServicioFactory()).Get(_codOrdenServicio);
}
}

return _ordenServicio;
}
set 
{
if ( _ordenServicio != value) 
{
if ( value==null ) _codOrdenServicio = System.Int32.MinValue; else _codOrdenServicio = (System.Int32)value.CodOrdenServicio; 
_ordenServicio = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_solicitudInsumos_unidadTiempo
/// </summary>
[GenWiseAttribute(RelationID = "d7723c08-833d-4d07-b0e0-43e00b339660") ]
public virtual UnidadTiempo UnidadTiempo 
{
get
{
if ( _unidadTiempo == null ) 
{
if ( !_codUnidadTiempo.HasValue || _codUnidadTiempo.Value.Equals(System.Int32.MinValue) ) 
{
if ( _unidadTiempo != null && ( _unidadTiempo.CodUnidadTiempo.Equals(null) ) )
{
  _unidadTiempo = null;
}
}
else
{
_unidadTiempo = (new UnidadTiempoFactory()).Get(_codUnidadTiempo.Value);
}
}

return _unidadTiempo;
}
set 
{
if ( _unidadTiempo != value) 
{
if ( value==null ) _codUnidadTiempo = null; else _codUnidadTiempo = (System.Int32)value.CodUnidadTiempo; 
_unidadTiempo = value ;
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

_retValue += CodOrdenServicio.ToString();

_retValue += "^";
_retValue += CodSolicitud.ToString();

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
/// Create a new SolicitudInsumo object. 
/// </summary>
public  SolicitudInsumo()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  SolicitudInsumo(System.Int32 pCodOrdenServicio , System.Int32 pCodSolicitud)
{
_codOrdenServicio = pCodOrdenServicio ;
_codSolicitud = pCodSolicitud ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
_hash += CodOrdenServicio.ToString();
_hash += CodSolicitud.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
SolicitudInsumo _newSolicitudInsumo = (pObject as SolicitudInsumo); 
if (_newSolicitudInsumo == null ) return false; 
if (_newSolicitudInsumo.GetHashCode() == this.GetHashCode() ) return true; 
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

// Primary Key Validation (Template Option)
if (  CodOrdenServicio.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codOrdenServicio) can not be null!. " ) );
}
if (  CodSolicitud.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codSolicitud) can not be null!. " ) );
}

return _errors;
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

