using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class Recoleccion : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codRecoleccion;
private System.Int32? _codEstadoRecoleccion;
private System.String _nitCliente;
private System.String _codSucursal;
private System.String _codModalidad;
private System.String _serial;
private System.DateTime? _fechaSolicitud;
private System.String _solicitadoPor;
private System.String _observacionesSolicitud;
private System.String _motivoRecoleccion;
private System.DateTime? _fechaTentativaLlegada;
private System.String _responsableRecoleccion;
private System.Int32? _codTransportadora;
private System.String _codRecoleccionTransportadora;
private System.String _nroGuia;
private System.String _obsIniciales;
private System.Boolean? _confirmada;
private System.String _confirmadaPor;
private System.DateTime? _fechaConfirmacion;
private System.String _obsConfirmacion;
private System.DateTime? _fechaRecoleccion;
private System.Int32? _codEntradaSalidaEquipos;
private IList<ArchivosxRecoleccion> _archivosxRecoleccions;
private Equipo _equipo;
private EstadoRecoleccion _estadoRecoleccion;
private ModalidadEquipo _modalidadEquipo;
private SucursalCliente _sucursalCliente;
private Transportadora _transportadora;
private Usuario0 _usuario0;
private Usuario0 _usuario01;
private Usuario0 _usuario02;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodRecoleccion 
{
get
{
return _codRecoleccion;
}
set 
{
if ( _codRecoleccion != value) 
{
_codRecoleccion = value ;
OnPropertyChanged("CodRecoleccion");
}
}
}

public virtual System.Int32? CodEstadoRecoleccion 
{
get
{
if ( EstadoRecoleccion != null ) 
{
_codEstadoRecoleccion = (System.Int32)EstadoRecoleccion.CodEstadoRecoleccion;
}

return _codEstadoRecoleccion;
}
set 
{
if ( _codEstadoRecoleccion != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_estadoRecoleccion = null;

_codEstadoRecoleccion = value ;
OnPropertyChanged("CodEstadoRecoleccion");
}
}
}

public virtual System.String NitCliente 
{
get
{
if ( SucursalCliente != null ) 
{
_nitCliente = (System.String)SucursalCliente.NitCliente;
}

return _nitCliente;
}
set 
{
if ( _nitCliente != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_sucursalCliente = null;

_nitCliente = value ;
OnPropertyChanged("NitCliente");
}
}
}

public virtual System.String CodSucursal 
{
get
{
if ( SucursalCliente != null ) 
{
_codSucursal = (System.String)SucursalCliente.CodSucursal;
}

return _codSucursal;
}
set 
{
if ( _codSucursal != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_sucursalCliente = null;

_codSucursal = value ;
OnPropertyChanged("CodSucursal");
}
}
}

public virtual System.String CodModalidad 
{
get
{
if ( ModalidadEquipo != null ) 
{
_codModalidad = (System.String)ModalidadEquipo.CodModalidadEquipo;
}

return _codModalidad;
}
set 
{
if ( _codModalidad != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_modalidadEquipo = null;

_codModalidad = value ;
OnPropertyChanged("CodModalidad");
}
}
}

public virtual System.String Serial 
{
get
{
if ( Equipo != null ) 
{
_serial = (System.String)Equipo.Serial;
}

return _serial;
}
set 
{
if ( _serial != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_equipo = null;

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

public virtual System.String SolicitadoPor 
{
get
{
if ( Usuario01 != null ) 
{
_solicitadoPor = (System.String)Usuario01.Login;
}

return _solicitadoPor;
}
set 
{
if ( _solicitadoPor != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_usuario01 = null;

_solicitadoPor = value ;
OnPropertyChanged("SolicitadoPor");
}
}
}

public virtual System.String ObservacionesSolicitud 
{
get
{
return _observacionesSolicitud;
}
set 
{
if ( _observacionesSolicitud != value) 
{
_observacionesSolicitud = value ;
OnPropertyChanged("ObservacionesSolicitud");
}
}
}

public virtual System.String MotivoRecoleccion 
{
get
{
return _motivoRecoleccion;
}
set 
{
if ( _motivoRecoleccion != value) 
{
_motivoRecoleccion = value ;
OnPropertyChanged("MotivoRecoleccion");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaTentativaLlegada_Date 
{
get
{
if (  !FechaTentativaLlegada.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaTentativaLlegada.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaTentativaLlegada.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaTentativaLlegada_Time)) {

FechaTentativaLlegada = null;
}
 else
{
 FechaTentativaLlegada = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaTentativaLlegada.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaTentativaLlegada_Time)) 
{
 FechaTentativaLlegada = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaTentativaLlegada = Convert.ToDateTime( " " + value + " " + FechaTentativaLlegada.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaTentativaLlegada_Time 
{
get
{
if (  !FechaTentativaLlegada.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaTentativaLlegada.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaTentativaLlegada.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaTentativaLlegada_Date)) 
{
FechaTentativaLlegada = null;
}
 else
{
 FechaTentativaLlegada = Convert.ToDateTime( " " + FechaTentativaLlegada.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaTentativaLlegada_Date)) 
{
 FechaTentativaLlegada = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaTentativaLlegada = Convert.ToDateTime( " " + FechaTentativaLlegada_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaTentativaLlegada 
{
get
{
return _fechaTentativaLlegada;
}
set 
{
if ( _fechaTentativaLlegada != value) 
{
_fechaTentativaLlegada = value ;
OnPropertyChanged("FechaTentativaLlegada");
}
}
}

public virtual System.String ResponsableRecoleccion 
{
get
{
if ( Usuario02 != null ) 
{
_responsableRecoleccion = (System.String)Usuario02.Login;
}

return _responsableRecoleccion;
}
set 
{
if ( _responsableRecoleccion != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_usuario02 = null;

_responsableRecoleccion = value ;
OnPropertyChanged("ResponsableRecoleccion");
}
}
}

public virtual System.Int32? CodTransportadora 
{
get
{
if ( Transportadora != null ) 
{
_codTransportadora = (System.Int32)Transportadora.CodTransportadora;
}

return _codTransportadora;
}
set 
{
if ( _codTransportadora != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_transportadora = null;

_codTransportadora = value ;
OnPropertyChanged("CodTransportadora");
}
}
}

public virtual System.String CodRecoleccionTransportadora 
{
get
{
return _codRecoleccionTransportadora;
}
set 
{
if ( _codRecoleccionTransportadora != value) 
{
_codRecoleccionTransportadora = value ;
OnPropertyChanged("CodRecoleccionTransportadora");
}
}
}

public virtual System.String NroGuia 
{
get
{
return _nroGuia;
}
set 
{
if ( _nroGuia != value) 
{
_nroGuia = value ;
OnPropertyChanged("NroGuia");
}
}
}

public virtual System.String ObsIniciales 
{
get
{
return _obsIniciales;
}
set 
{
if ( _obsIniciales != value) 
{
_obsIniciales = value ;
OnPropertyChanged("ObsIniciales");
}
}
}

public virtual System.Boolean? Confirmada 
{
get
{
return _confirmada;
}
set 
{
if ( _confirmada != value) 
{
_confirmada = value ;
OnPropertyChanged("Confirmada");
}
}
}

public virtual System.String ConfirmadaPor 
{
get
{
if ( Usuario0 != null ) 
{
_confirmadaPor = (System.String)Usuario0.Login;
}

return _confirmadaPor;
}
set 
{
if ( _confirmadaPor != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_usuario0 = null;

_confirmadaPor = value ;
OnPropertyChanged("ConfirmadaPor");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaConfirmacion_Date 
{
get
{
if (  !FechaConfirmacion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaConfirmacion.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaConfirmacion.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaConfirmacion_Time)) {

FechaConfirmacion = null;
}
 else
{
 FechaConfirmacion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaConfirmacion.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaConfirmacion_Time)) 
{
 FechaConfirmacion = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaConfirmacion = Convert.ToDateTime( " " + value + " " + FechaConfirmacion.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaConfirmacion_Time 
{
get
{
if (  !FechaConfirmacion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaConfirmacion.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaConfirmacion.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaConfirmacion_Date)) 
{
FechaConfirmacion = null;
}
 else
{
 FechaConfirmacion = Convert.ToDateTime( " " + FechaConfirmacion.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaConfirmacion_Date)) 
{
 FechaConfirmacion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaConfirmacion = Convert.ToDateTime( " " + FechaConfirmacion_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaConfirmacion 
{
get
{
return _fechaConfirmacion;
}
set 
{
if ( _fechaConfirmacion != value) 
{
_fechaConfirmacion = value ;
OnPropertyChanged("FechaConfirmacion");
}
}
}

public virtual System.String ObsConfirmacion 
{
get
{
return _obsConfirmacion;
}
set 
{
if ( _obsConfirmacion != value) 
{
_obsConfirmacion = value ;
OnPropertyChanged("ObsConfirmacion");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaRecoleccion_Date 
{
get
{
if (  !FechaRecoleccion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaRecoleccion.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaRecoleccion.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaRecoleccion_Time)) {

FechaRecoleccion = null;
}
 else
{
 FechaRecoleccion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaRecoleccion.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaRecoleccion_Time)) 
{
 FechaRecoleccion = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaRecoleccion = Convert.ToDateTime( " " + value + " " + FechaRecoleccion.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaRecoleccion_Time 
{
get
{
if (  !FechaRecoleccion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaRecoleccion.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaRecoleccion.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaRecoleccion_Date)) 
{
FechaRecoleccion = null;
}
 else
{
 FechaRecoleccion = Convert.ToDateTime( " " + FechaRecoleccion.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaRecoleccion_Date)) 
{
 FechaRecoleccion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaRecoleccion = Convert.ToDateTime( " " + FechaRecoleccion_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaRecoleccion 
{
get
{
return _fechaRecoleccion;
}
set 
{
if ( _fechaRecoleccion != value) 
{
_fechaRecoleccion = value ;
OnPropertyChanged("FechaRecoleccion");
}
}
}

public virtual System.Int32? CodEntradaSalidaEquipos 
{
get
{
return _codEntradaSalidaEquipos;
}
set 
{
if ( _codEntradaSalidaEquipos != value) 
{
_codEntradaSalidaEquipos = value ;
OnPropertyChanged("CodEntradaSalidaEquipos");
}
}
}

/// <summary>
/// Collection of ArchivosxRecoleccion.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "7b8d7e5b-15cf-4d56-893b-c6f79d475348" , CollectionOfType = typeof(ArchivosxRecoleccion)) ]
public virtual IList<ArchivosxRecoleccion> ArchivosxRecoleccions 
{
get
{
 if (_archivosxRecoleccions == null) _archivosxRecoleccions = new List<ArchivosxRecoleccion>();

return _archivosxRecoleccions;
}
set 
{
if ( _archivosxRecoleccions != value) 
{
_archivosxRecoleccions = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_recoleccion_equipos
/// </summary>
[GenWiseAttribute(RelationID = "c9c735f3-8c21-4205-a513-0a2cfe15a899") ]
public virtual Equipo Equipo 
{
get
{
if ( _equipo == null ) 
{
if ( String.IsNullOrEmpty(_serial) || _serial.Equals(string.Empty) ) 
{
if ( _equipo != null && ( _equipo.Serial.Equals(null) ) )
{
  _equipo = null;
}
}
else
{
_equipo = (new EquipoFactory()).Get(_serial);
}
}

return _equipo;
}
set 
{
if ( _equipo != value) 
{
if ( value==null ) _serial = null; else _serial = (System.String)value.Serial; 
_equipo = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_recoleccion_estadoRecoleccion
/// </summary>
[GenWiseAttribute(RelationID = "4a7d1d7f-c144-4061-9be2-07035f5f82a9") ]
public virtual EstadoRecoleccion EstadoRecoleccion 
{
get
{
if ( _estadoRecoleccion == null ) 
{
if ( !_codEstadoRecoleccion.HasValue || _codEstadoRecoleccion.Value.Equals(System.Int32.MinValue) ) 
{
if ( _estadoRecoleccion != null && ( _estadoRecoleccion.CodEstadoRecoleccion.Equals(null) ) )
{
  _estadoRecoleccion = null;
}
}
else
{
_estadoRecoleccion = (new EstadoRecoleccionFactory()).Get(_codEstadoRecoleccion.Value);
}
}

return _estadoRecoleccion;
}
set 
{
if ( _estadoRecoleccion != value) 
{
if ( value==null ) _codEstadoRecoleccion = null; else _codEstadoRecoleccion = (System.Int32)value.CodEstadoRecoleccion; 
_estadoRecoleccion = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_recoleccion_ModalidadEquipo
/// </summary>
[GenWiseAttribute(RelationID = "c116c71f-3468-4f86-acec-8579e3908ce2") ]
public virtual ModalidadEquipo ModalidadEquipo 
{
get
{
if ( _modalidadEquipo == null ) 
{
if ( String.IsNullOrEmpty(_codModalidad) || _codModalidad.Equals(string.Empty) ) 
{
if ( _modalidadEquipo != null && ( _modalidadEquipo.CodModalidadEquipo.Equals(null) ) )
{
  _modalidadEquipo = null;
}
}
else
{
_modalidadEquipo = (new ModalidadEquipoFactory()).Get(_codModalidad);
}
}

return _modalidadEquipo;
}
set 
{
if ( _modalidadEquipo != value) 
{
if ( value==null ) _codModalidad = null; else _codModalidad = (System.String)value.CodModalidadEquipo; 
_modalidadEquipo = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_recoleccion_sucursalCliente
/// </summary>
[GenWiseAttribute(RelationID = "9d78d9b3-f5cb-4d4b-87c5-85e90a6b6788") ]
public virtual SucursalCliente SucursalCliente 
{
get
{
if ( _sucursalCliente == null || _sucursalCliente == null ) 
{
if ( String.IsNullOrEmpty(_nitCliente) || _nitCliente.Equals(string.Empty) || String.IsNullOrEmpty(_codSucursal) || _codSucursal.Equals(string.Empty) ) 
{
if ( _sucursalCliente != null && ( _sucursalCliente.NitCliente.Equals(null) || _sucursalCliente.CodSucursal.Equals(null) ) )
{
  _sucursalCliente = null;
}
}
else
{
  _sucursalCliente = (new SucursalClienteFactory()).Fetch(_nitCliente,_codSucursal);
}
}

return _sucursalCliente;
}
set 
{
if ( _sucursalCliente != value) 
{
if ( value==null ) _nitCliente = null; else _nitCliente = (System.String)value.NitCliente; 
if ( value==null ) _codSucursal = null; else _codSucursal = (System.String)value.CodSucursal; 
_sucursalCliente = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_recoleccion_transportadora
/// </summary>
[GenWiseAttribute(RelationID = "d67e6b5d-0e88-48dd-91ba-14099c060ba6") ]
public virtual Transportadora Transportadora 
{
get
{
if ( _transportadora == null ) 
{
if ( !_codTransportadora.HasValue || _codTransportadora.Value.Equals(System.Int32.MinValue) ) 
{
if ( _transportadora != null && ( _transportadora.CodTransportadora.Equals(null) ) )
{
  _transportadora = null;
}
}
else
{
_transportadora = (new TransportadoraFactory()).Get(_codTransportadora.Value);
}
}

return _transportadora;
}
set 
{
if ( _transportadora != value) 
{
if ( value==null ) _codTransportadora = null; else _codTransportadora = (System.Int32)value.CodTransportadora; 
_transportadora = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_recoleccion_usuarios
/// </summary>
[GenWiseAttribute(RelationID = "6b9ea1fe-fa86-48a3-b907-eb488eaf69b8") ]
public virtual Usuario0 Usuario0 
{
get
{
if ( _usuario0 == null ) 
{
if ( String.IsNullOrEmpty(_confirmadaPor) || _confirmadaPor.Equals(string.Empty) ) 
{
if ( _usuario0 != null && ( _usuario0.Login.Equals(null) ) )
{
  _usuario0 = null;
}
}
else
{
_usuario0 = (new Usuario0Factory()).Get(_confirmadaPor);
}
}

return _usuario0;
}
set 
{
if ( _usuario0 != value) 
{
if ( value==null ) _confirmadaPor = null; else _confirmadaPor = (System.String)value.Login; 
_usuario0 = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_recoleccion_usuarios1
/// </summary>
[GenWiseAttribute(RelationID = "4d4bcc4b-d727-4a68-9beb-6a71aa5dd16e") ]
public virtual Usuario0 Usuario01 
{
get
{
if ( _usuario01 == null ) 
{
if ( String.IsNullOrEmpty(_solicitadoPor) || _solicitadoPor.Equals(string.Empty) ) 
{
if ( _usuario01 != null && ( _usuario01.Login.Equals(null) ) )
{
  _usuario01 = null;
}
}
else
{
_usuario01 = (new Usuario0Factory()).Get(_solicitadoPor);
}
}

return _usuario01;
}
set 
{
if ( _usuario01 != value) 
{
if ( value==null ) _solicitadoPor = null; else _solicitadoPor = (System.String)value.Login; 
_usuario01 = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_recoleccion_usuarios2
/// </summary>
[GenWiseAttribute(RelationID = "24f9986b-8d6e-47cc-9ac8-df68419bc0ca") ]
public virtual Usuario0 Usuario02 
{
get
{
if ( _usuario02 == null ) 
{
if ( String.IsNullOrEmpty(_responsableRecoleccion) || _responsableRecoleccion.Equals(string.Empty) ) 
{
if ( _usuario02 != null && ( _usuario02.Login.Equals(null) ) )
{
  _usuario02 = null;
}
}
else
{
_usuario02 = (new Usuario0Factory()).Get(_responsableRecoleccion);
}
}

return _usuario02;
}
set 
{
if ( _usuario02 != value) 
{
if ( value==null ) _responsableRecoleccion = null; else _responsableRecoleccion = (System.String)value.Login; 
_usuario02 = value ;
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
/// Create a new Recoleccion object. 
/// </summary>
public  Recoleccion()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  Recoleccion(System.Int32 pCodRecoleccion)
{
_codRecoleccion = pCodRecoleccion ;

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
if (  CodRecoleccion.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codRecoleccion) can not be null!. " ) );
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

