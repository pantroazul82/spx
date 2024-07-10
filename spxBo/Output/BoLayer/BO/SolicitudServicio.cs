using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class SolicitudServicio : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codSolicitudServicio;
private System.DateTime? _fechaCreacion;
private System.DateTime? _fechaSugerida;
private System.DateTime? _fechaAceptacion;
private System.String _creadaPor;
private System.String _aceptadaPor;
private System.Boolean? _aceptada;
private System.String _serial;
private System.String _nitCliente;
private System.String _codSucursal;
private System.String _codTipoServicio;
private System.String _codModalidad;
private System.Int32? _codEstadoSolicitud;
private System.Int32? _codPrioridadSolicitud;
private System.String _objetoServicio;
private System.String _fallasReportadas;
private System.String _observaciones;
private System.Int32? _codAsesor;
private System.Int32? _codMedioSolicitud;
private System.Int32? _codOrdenServicio;
private IList<LlamadaSoporte> _llamadaSoportes;
private AsesoresComerciale _asesoresComerciale;
private Cliente _cliente;
private Equipo _equipo;
private EstadosSolicitud _estadosSolicitud;
private MedioSolicitud _medioSolicitud;
private ModalidadEquipo _modalidadEquipo;
private OrdenServicio _ordenServicio;
private PrioridadSolicitud _prioridadSolicitud;
private TipoServicio _tipoServicio;
private Usuario0 _usuario0;
private Usuario0 _usuario01;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodSolicitudServicio 
{
get
{
return _codSolicitudServicio;
}
set 
{
if ( _codSolicitudServicio != value) 
{
_codSolicitudServicio = value ;
OnPropertyChanged("CodSolicitudServicio");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaCreacion_Date 
{
get
{
if (  !FechaCreacion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaCreacion.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaCreacion.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaCreacion_Time)) {

FechaCreacion = null;
}
 else
{
 FechaCreacion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaCreacion.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaCreacion_Time)) 
{
 FechaCreacion = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaCreacion = Convert.ToDateTime( " " + value + " " + FechaCreacion.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaCreacion_Time 
{
get
{
if (  !FechaCreacion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaCreacion.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaCreacion.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaCreacion_Date)) 
{
FechaCreacion = null;
}
 else
{
 FechaCreacion = Convert.ToDateTime( " " + FechaCreacion.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaCreacion_Date)) 
{
 FechaCreacion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaCreacion = Convert.ToDateTime( " " + FechaCreacion_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaCreacion 
{
get
{
return _fechaCreacion;
}
set 
{
if ( _fechaCreacion != value) 
{
_fechaCreacion = value ;
OnPropertyChanged("FechaCreacion");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaSugerida_Date 
{
get
{
if (  !FechaSugerida.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaSugerida.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaSugerida.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaSugerida_Time)) {

FechaSugerida = null;
}
 else
{
 FechaSugerida = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaSugerida.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaSugerida_Time)) 
{
 FechaSugerida = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaSugerida = Convert.ToDateTime( " " + value + " " + FechaSugerida.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaSugerida_Time 
{
get
{
if (  !FechaSugerida.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaSugerida.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaSugerida.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaSugerida_Date)) 
{
FechaSugerida = null;
}
 else
{
 FechaSugerida = Convert.ToDateTime( " " + FechaSugerida.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaSugerida_Date)) 
{
 FechaSugerida = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaSugerida = Convert.ToDateTime( " " + FechaSugerida_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaSugerida 
{
get
{
return _fechaSugerida;
}
set 
{
if ( _fechaSugerida != value) 
{
_fechaSugerida = value ;
OnPropertyChanged("FechaSugerida");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaAceptacion_Date 
{
get
{
if (  !FechaAceptacion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaAceptacion.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaAceptacion.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaAceptacion_Time)) {

FechaAceptacion = null;
}
 else
{
 FechaAceptacion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaAceptacion.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaAceptacion_Time)) 
{
 FechaAceptacion = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaAceptacion = Convert.ToDateTime( " " + value + " " + FechaAceptacion.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaAceptacion_Time 
{
get
{
if (  !FechaAceptacion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaAceptacion.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaAceptacion.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaAceptacion_Date)) 
{
FechaAceptacion = null;
}
 else
{
 FechaAceptacion = Convert.ToDateTime( " " + FechaAceptacion.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaAceptacion_Date)) 
{
 FechaAceptacion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaAceptacion = Convert.ToDateTime( " " + FechaAceptacion_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaAceptacion 
{
get
{
return _fechaAceptacion;
}
set 
{
if ( _fechaAceptacion != value) 
{
_fechaAceptacion = value ;
OnPropertyChanged("FechaAceptacion");
}
}
}

public virtual System.String CreadaPor 
{
get
{
if ( Usuario0 != null ) 
{
_creadaPor = (System.String)Usuario0.Login;
}

return _creadaPor;
}
set 
{
if ( _creadaPor != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_usuario0 = null;

_creadaPor = value ;
OnPropertyChanged("CreadaPor");
}
}
}

public virtual System.String AceptadaPor 
{
get
{
if ( Usuario01 != null ) 
{
_aceptadaPor = (System.String)Usuario01.Login;
}

return _aceptadaPor;
}
set 
{
if ( _aceptadaPor != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_usuario01 = null;

_aceptadaPor = value ;
OnPropertyChanged("AceptadaPor");
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

public virtual System.String NitCliente 
{
get
{
if ( Cliente != null ) 
{
_nitCliente = (System.String)Cliente.NitCliente;
}

return _nitCliente;
}
set 
{
if ( _nitCliente != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_cliente = null;

_nitCliente = value ;
OnPropertyChanged("NitCliente");
}
}
}

public virtual System.String CodSucursal 
{
get
{
return _codSucursal;
}
set 
{
if ( _codSucursal != value) 
{
_codSucursal = value ;
OnPropertyChanged("CodSucursal");
}
}
}

public virtual System.String CodTipoServicio 
{
get
{
if ( TipoServicio != null ) 
{
_codTipoServicio = (System.String)TipoServicio.CodTipoServicio;
}

return _codTipoServicio;
}
set 
{
if ( _codTipoServicio != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_tipoServicio = null;

_codTipoServicio = value ;
OnPropertyChanged("CodTipoServicio");
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

public virtual System.Int32? CodEstadoSolicitud 
{
get
{
if ( EstadosSolicitud != null ) 
{
_codEstadoSolicitud = (System.Int32)EstadosSolicitud.CodEstadoSolicitud;
}

return _codEstadoSolicitud;
}
set 
{
if ( _codEstadoSolicitud != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_estadosSolicitud = null;

_codEstadoSolicitud = value ;
OnPropertyChanged("CodEstadoSolicitud");
}
}
}

public virtual System.Int32? CodPrioridadSolicitud 
{
get
{
if ( PrioridadSolicitud != null ) 
{
_codPrioridadSolicitud = (System.Int32)PrioridadSolicitud.CodPrioridadSolicitud;
}

return _codPrioridadSolicitud;
}
set 
{
if ( _codPrioridadSolicitud != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_prioridadSolicitud = null;

_codPrioridadSolicitud = value ;
OnPropertyChanged("CodPrioridadSolicitud");
}
}
}

public virtual System.String ObjetoServicio 
{
get
{
return _objetoServicio;
}
set 
{
if ( _objetoServicio != value) 
{
_objetoServicio = value ;
OnPropertyChanged("ObjetoServicio");
}
}
}

public virtual System.String FallasReportadas 
{
get
{
return _fallasReportadas;
}
set 
{
if ( _fallasReportadas != value) 
{
_fallasReportadas = value ;
OnPropertyChanged("FallasReportadas");
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

public virtual System.Int32? CodAsesor 
{
get
{
if ( AsesoresComerciale != null ) 
{
_codAsesor = (System.Int32)AsesoresComerciale.CodAsesor;
}

return _codAsesor;
}
set 
{
if ( _codAsesor != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_asesoresComerciale = null;

_codAsesor = value ;
OnPropertyChanged("CodAsesor");
}
}
}

public virtual System.Int32? CodMedioSolicitud 
{
get
{
if ( MedioSolicitud != null ) 
{
_codMedioSolicitud = (System.Int32)MedioSolicitud.CodMedioSolicitud;
}

return _codMedioSolicitud;
}
set 
{
if ( _codMedioSolicitud != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_medioSolicitud = null;

_codMedioSolicitud = value ;
OnPropertyChanged("CodMedioSolicitud");
}
}
}

public virtual System.Int32? CodOrdenServicio 
{
get
{
if ( OrdenServicio != null ) 
{
_codOrdenServicio = (System.Int32)OrdenServicio.CodOrdenServicio;
}

return _codOrdenServicio;
}
set 
{
if ( _codOrdenServicio != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_ordenServicio = null;

_codOrdenServicio = value ;
OnPropertyChanged("CodOrdenServicio");
}
}
}

/// <summary>
/// Collection of LlamadaSoporte.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "aab3580f-7b7d-4767-89c5-cf2dfc5a26cd" , CollectionOfType = typeof(LlamadaSoporte)) ]
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
/// Generated from Relation FK_solicitudServicio_asesoresComerciales
/// </summary>
[GenWiseAttribute(RelationID = "827e6f77-4fe7-4bdb-b2a2-a2e5f92e9eaf") ]
public virtual AsesoresComerciale AsesoresComerciale 
{
get
{
if ( _asesoresComerciale == null ) 
{
if ( !_codAsesor.HasValue || _codAsesor.Value.Equals(System.Int32.MinValue) ) 
{
if ( _asesoresComerciale != null && ( _asesoresComerciale.CodAsesor.Equals(null) ) )
{
  _asesoresComerciale = null;
}
}
else
{
_asesoresComerciale = (new AsesoresComercialeFactory()).Get(_codAsesor.Value);
}
}

return _asesoresComerciale;
}
set 
{
if ( _asesoresComerciale != value) 
{
if ( value==null ) _codAsesor = null; else _codAsesor = (System.Int32)value.CodAsesor; 
_asesoresComerciale = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_solicitudServicio_clientes
/// </summary>
[GenWiseAttribute(RelationID = "afd3b87d-6c44-4968-9992-e94efea097f3") ]
public virtual Cliente Cliente 
{
get
{
if ( _cliente == null ) 
{
if ( String.IsNullOrEmpty(_nitCliente) || _nitCliente.Equals(string.Empty) ) 
{
if ( _cliente != null && ( _cliente.NitCliente.Equals(null) ) )
{
  _cliente = null;
}
}
else
{
_cliente = (new ClienteFactory()).Get(_nitCliente);
}
}

return _cliente;
}
set 
{
if ( _cliente != value) 
{
if ( value==null ) _nitCliente = null; else _nitCliente = (System.String)value.NitCliente; 
_cliente = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_solicitudServicio_equipos
/// </summary>
[GenWiseAttribute(RelationID = "3ea033eb-ea38-4723-b23a-5a9627ee4e0d") ]
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
/// Generated from Relation FK_solicitudServicio_estadosSolicitud
/// </summary>
[GenWiseAttribute(RelationID = "2214f531-990c-4233-9657-a814a4df0907") ]
public virtual EstadosSolicitud EstadosSolicitud 
{
get
{
if ( _estadosSolicitud == null ) 
{
if ( !_codEstadoSolicitud.HasValue || _codEstadoSolicitud.Value.Equals(System.Int32.MinValue) ) 
{
if ( _estadosSolicitud != null && ( _estadosSolicitud.CodEstadoSolicitud.Equals(null) ) )
{
  _estadosSolicitud = null;
}
}
else
{
_estadosSolicitud = (new EstadosSolicitudFactory()).Get(_codEstadoSolicitud.Value);
}
}

return _estadosSolicitud;
}
set 
{
if ( _estadosSolicitud != value) 
{
if ( value==null ) _codEstadoSolicitud = null; else _codEstadoSolicitud = (System.Int32)value.CodEstadoSolicitud; 
_estadosSolicitud = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_solicitudServicio_medioSolicitud
/// </summary>
[GenWiseAttribute(RelationID = "4416ee42-a68e-40a8-b679-334727fab306") ]
public virtual MedioSolicitud MedioSolicitud 
{
get
{
if ( _medioSolicitud == null ) 
{
if ( !_codMedioSolicitud.HasValue || _codMedioSolicitud.Value.Equals(System.Int32.MinValue) ) 
{
if ( _medioSolicitud != null && ( _medioSolicitud.CodMedioSolicitud.Equals(null) ) )
{
  _medioSolicitud = null;
}
}
else
{
_medioSolicitud = (new MedioSolicitudFactory()).Get(_codMedioSolicitud.Value);
}
}

return _medioSolicitud;
}
set 
{
if ( _medioSolicitud != value) 
{
if ( value==null ) _codMedioSolicitud = null; else _codMedioSolicitud = (System.Int32)value.CodMedioSolicitud; 
_medioSolicitud = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_solicitudServicio_ModalidadEquipo
/// </summary>
[GenWiseAttribute(RelationID = "36e471c5-d5b5-443d-a11e-cca7a454a8ec") ]
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
/// Generated from Relation FK_solicitudServicio_ordenServicio
/// </summary>
[GenWiseAttribute(RelationID = "fe2e0522-9b29-465f-87e1-24215877c55b") ]
public virtual OrdenServicio OrdenServicio 
{
get
{
if ( _ordenServicio == null ) 
{
if ( !_codOrdenServicio.HasValue || _codOrdenServicio.Value.Equals(System.Int32.MinValue) ) 
{
if ( _ordenServicio != null && ( _ordenServicio.CodOrdenServicio.Equals(null) ) )
{
  _ordenServicio = null;
}
}
else
{
_ordenServicio = (new OrdenServicioFactory()).Get(_codOrdenServicio.Value);
}
}

return _ordenServicio;
}
set 
{
if ( _ordenServicio != value) 
{
if ( value==null ) _codOrdenServicio = null; else _codOrdenServicio = (System.Int32)value.CodOrdenServicio; 
_ordenServicio = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_solicitudServicio_prioridadSolicitud
/// </summary>
[GenWiseAttribute(RelationID = "ddebf181-ee35-410a-b778-f4efaecac9cf") ]
public virtual PrioridadSolicitud PrioridadSolicitud 
{
get
{
if ( _prioridadSolicitud == null ) 
{
if ( !_codPrioridadSolicitud.HasValue || _codPrioridadSolicitud.Value.Equals(System.Int32.MinValue) ) 
{
if ( _prioridadSolicitud != null && ( _prioridadSolicitud.CodPrioridadSolicitud.Equals(null) ) )
{
  _prioridadSolicitud = null;
}
}
else
{
_prioridadSolicitud = (new PrioridadSolicitudFactory()).Get(_codPrioridadSolicitud.Value);
}
}

return _prioridadSolicitud;
}
set 
{
if ( _prioridadSolicitud != value) 
{
if ( value==null ) _codPrioridadSolicitud = null; else _codPrioridadSolicitud = (System.Int32)value.CodPrioridadSolicitud; 
_prioridadSolicitud = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_solicitudServicio_TipoServicio
/// </summary>
[GenWiseAttribute(RelationID = "7cf67f05-b70e-44d1-a995-24c092634182") ]
public virtual TipoServicio TipoServicio 
{
get
{
if ( _tipoServicio == null ) 
{
if ( String.IsNullOrEmpty(_codTipoServicio) || _codTipoServicio.Equals(string.Empty) ) 
{
if ( _tipoServicio != null && ( _tipoServicio.CodTipoServicio.Equals(null) ) )
{
  _tipoServicio = null;
}
}
else
{
_tipoServicio = (new TipoServicioFactory()).Get(_codTipoServicio);
}
}

return _tipoServicio;
}
set 
{
if ( _tipoServicio != value) 
{
if ( value==null ) _codTipoServicio = null; else _codTipoServicio = (System.String)value.CodTipoServicio; 
_tipoServicio = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_solicitudServicio_usuarios
/// </summary>
[GenWiseAttribute(RelationID = "a4554bdd-8e27-43b0-9a5a-05089a25b69c") ]
public virtual Usuario0 Usuario0 
{
get
{
if ( _usuario0 == null ) 
{
if ( String.IsNullOrEmpty(_creadaPor) || _creadaPor.Equals(string.Empty) ) 
{
if ( _usuario0 != null && ( _usuario0.Login.Equals(null) ) )
{
  _usuario0 = null;
}
}
else
{
_usuario0 = (new Usuario0Factory()).Get(_creadaPor);
}
}

return _usuario0;
}
set 
{
if ( _usuario0 != value) 
{
if ( value==null ) _creadaPor = null; else _creadaPor = (System.String)value.Login; 
_usuario0 = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_solicitudServicio_usuarios1
/// </summary>
[GenWiseAttribute(RelationID = "d01941a6-1c99-4d43-a3f2-ec556b9fe1ab") ]
public virtual Usuario0 Usuario01 
{
get
{
if ( _usuario01 == null ) 
{
if ( String.IsNullOrEmpty(_aceptadaPor) || _aceptadaPor.Equals(string.Empty) ) 
{
if ( _usuario01 != null && ( _usuario01.Login.Equals(null) ) )
{
  _usuario01 = null;
}
}
else
{
_usuario01 = (new Usuario0Factory()).Get(_aceptadaPor);
}
}

return _usuario01;
}
set 
{
if ( _usuario01 != value) 
{
if ( value==null ) _aceptadaPor = null; else _aceptadaPor = (System.String)value.Login; 
_usuario01 = value ;
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
/// Create a new SolicitudServicio object. 
/// </summary>
public  SolicitudServicio()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  SolicitudServicio(System.Int32 pCodSolicitudServicio)
{
_codSolicitudServicio = pCodSolicitudServicio ;

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
if (  CodSolicitudServicio.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codSolicitudServicio) can not be null!. " ) );
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

