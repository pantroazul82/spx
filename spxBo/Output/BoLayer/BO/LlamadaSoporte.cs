using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class LlamadaSoporte : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _idLlamadaSoporte;
private System.String _codEstadoLLamadaTecnica;
private System.DateTime? _fechaLlamada;
private System.Boolean? _llamadaRecibida;
private System.String _nitCliente;
private System.String _codUbicacion;
private System.String _codContacto;
private System.String _infAdicionalContacto;
private System.String _serial;
private System.String _codModalidadEquipo;
private System.String _asesorTelefonico;
private System.String _ingenieroAsesor;
private System.DateTime? _fechaAsignacionIngeniero;
private System.Int32? _codAsesor;
private System.String _obsCliente;
private System.String _obsAsesorTelefonico;
private System.Boolean? _solucionado;
private System.String _obsFinales;
private System.DateTime? _fechaCierre;
private System.String _cerradaPor;
private System.Int32? _codSolicitud;
private IList<IndicacionesLLamada> _indicacionesLLamadas;
private IList<Seguimiento> _seguimientos;
private AsesoresComerciale _asesoresComerciale;
private ContactosCliente _contactosCliente;
private Equipo _equipo;
private EstadosLLamadasTecnica _estadosLLamadasTecnica;
private ModalidadEquipo _modalidadEquipo;
private SolicitudServicio _solicitudServicio;
private SucursalCliente _sucursalCliente;
private Usuario0 _usuario0;
private Usuario0 _usuario01;
private Usuario0 _usuario02;

#endregion


#region --- Class Properties ---

public virtual System.Int32 IdLlamadaSoporte 
{
get
{
return _idLlamadaSoporte;
}
set 
{
if ( _idLlamadaSoporte != value) 
{
_idLlamadaSoporte = value ;
OnPropertyChanged("IdLlamadaSoporte");
}
}
}

public virtual System.String CodEstadoLLamadaTecnica 
{
get
{
if ( EstadosLLamadasTecnica != null ) 
{
_codEstadoLLamadaTecnica = (System.String)EstadosLLamadasTecnica.CodEstadoLlamada;
}

return _codEstadoLLamadaTecnica;
}
set 
{
if ( _codEstadoLLamadaTecnica != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_estadosLLamadasTecnica = null;

_codEstadoLLamadaTecnica = value ;
OnPropertyChanged("CodEstadoLLamadaTecnica");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaLlamada_Date 
{
get
{
if (  !FechaLlamada.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaLlamada.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaLlamada.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaLlamada_Time)) {

FechaLlamada = null;
}
 else
{
 FechaLlamada = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaLlamada.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaLlamada_Time)) 
{
 FechaLlamada = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaLlamada = Convert.ToDateTime( " " + value + " " + FechaLlamada.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaLlamada_Time 
{
get
{
if (  !FechaLlamada.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaLlamada.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaLlamada.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaLlamada_Date)) 
{
FechaLlamada = null;
}
 else
{
 FechaLlamada = Convert.ToDateTime( " " + FechaLlamada.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaLlamada_Date)) 
{
 FechaLlamada = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaLlamada = Convert.ToDateTime( " " + FechaLlamada_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaLlamada 
{
get
{
return _fechaLlamada;
}
set 
{
if ( _fechaLlamada != value) 
{
_fechaLlamada = value ;
OnPropertyChanged("FechaLlamada");
}
}
}

public virtual System.Boolean? LlamadaRecibida 
{
get
{
return _llamadaRecibida;
}
set 
{
if ( _llamadaRecibida != value) 
{
_llamadaRecibida = value ;
OnPropertyChanged("LlamadaRecibida");
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
_contactosCliente = null;

// Simplified Parent Access Property : reset object reference if simple property changes it's value
_sucursalCliente = null;

_nitCliente = value ;
OnPropertyChanged("NitCliente");
}
}
}

public virtual System.String CodUbicacion 
{
get
{
if ( SucursalCliente != null ) 
{
_codUbicacion = (System.String)SucursalCliente.CodSucursal;
}

return _codUbicacion;
}
set 
{
if ( _codUbicacion != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_sucursalCliente = null;

_codUbicacion = value ;
OnPropertyChanged("CodUbicacion");
}
}
}

public virtual System.String CodContacto 
{
get
{
if ( ContactosCliente != null ) 
{
_codContacto = (System.String)ContactosCliente.CodContacto;
}

return _codContacto;
}
set 
{
if ( _codContacto != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_contactosCliente = null;

_codContacto = value ;
OnPropertyChanged("CodContacto");
}
}
}

public virtual System.String InfAdicionalContacto 
{
get
{
return _infAdicionalContacto;
}
set 
{
if ( _infAdicionalContacto != value) 
{
_infAdicionalContacto = value ;
OnPropertyChanged("InfAdicionalContacto");
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

public virtual System.String CodModalidadEquipo 
{
get
{
if ( ModalidadEquipo != null ) 
{
_codModalidadEquipo = (System.String)ModalidadEquipo.CodModalidadEquipo;
}

return _codModalidadEquipo;
}
set 
{
if ( _codModalidadEquipo != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_modalidadEquipo = null;

_codModalidadEquipo = value ;
OnPropertyChanged("CodModalidadEquipo");
}
}
}

public virtual System.String AsesorTelefonico 
{
get
{
if ( Usuario0 != null ) 
{
_asesorTelefonico = (System.String)Usuario0.Login;
}

return _asesorTelefonico;
}
set 
{
if ( _asesorTelefonico != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_usuario0 = null;

_asesorTelefonico = value ;
OnPropertyChanged("AsesorTelefonico");
}
}
}

public virtual System.String IngenieroAsesor 
{
get
{
if ( Usuario01 != null ) 
{
_ingenieroAsesor = (System.String)Usuario01.Login;
}

return _ingenieroAsesor;
}
set 
{
if ( _ingenieroAsesor != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_usuario01 = null;

_ingenieroAsesor = value ;
OnPropertyChanged("IngenieroAsesor");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaAsignacionIngeniero_Date 
{
get
{
if (  !FechaAsignacionIngeniero.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaAsignacionIngeniero.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaAsignacionIngeniero.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaAsignacionIngeniero_Time)) {

FechaAsignacionIngeniero = null;
}
 else
{
 FechaAsignacionIngeniero = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaAsignacionIngeniero.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaAsignacionIngeniero_Time)) 
{
 FechaAsignacionIngeniero = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaAsignacionIngeniero = Convert.ToDateTime( " " + value + " " + FechaAsignacionIngeniero.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaAsignacionIngeniero_Time 
{
get
{
if (  !FechaAsignacionIngeniero.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaAsignacionIngeniero.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaAsignacionIngeniero.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaAsignacionIngeniero_Date)) 
{
FechaAsignacionIngeniero = null;
}
 else
{
 FechaAsignacionIngeniero = Convert.ToDateTime( " " + FechaAsignacionIngeniero.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaAsignacionIngeniero_Date)) 
{
 FechaAsignacionIngeniero = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaAsignacionIngeniero = Convert.ToDateTime( " " + FechaAsignacionIngeniero_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaAsignacionIngeniero 
{
get
{
return _fechaAsignacionIngeniero;
}
set 
{
if ( _fechaAsignacionIngeniero != value) 
{
_fechaAsignacionIngeniero = value ;
OnPropertyChanged("FechaAsignacionIngeniero");
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

public virtual System.String ObsCliente 
{
get
{
return _obsCliente;
}
set 
{
if ( _obsCliente != value) 
{
_obsCliente = value ;
OnPropertyChanged("ObsCliente");
}
}
}

public virtual System.String ObsAsesorTelefonico 
{
get
{
return _obsAsesorTelefonico;
}
set 
{
if ( _obsAsesorTelefonico != value) 
{
_obsAsesorTelefonico = value ;
OnPropertyChanged("ObsAsesorTelefonico");
}
}
}

public virtual System.Boolean? Solucionado 
{
get
{
return _solucionado;
}
set 
{
if ( _solucionado != value) 
{
_solucionado = value ;
OnPropertyChanged("Solucionado");
}
}
}

public virtual System.String ObsFinales 
{
get
{
return _obsFinales;
}
set 
{
if ( _obsFinales != value) 
{
_obsFinales = value ;
OnPropertyChanged("ObsFinales");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaCierre_Date 
{
get
{
if (  !FechaCierre.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaCierre.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaCierre.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaCierre_Time)) {

FechaCierre = null;
}
 else
{
 FechaCierre = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaCierre.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaCierre_Time)) 
{
 FechaCierre = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaCierre = Convert.ToDateTime( " " + value + " " + FechaCierre.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaCierre_Time 
{
get
{
if (  !FechaCierre.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaCierre.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaCierre.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaCierre_Date)) 
{
FechaCierre = null;
}
 else
{
 FechaCierre = Convert.ToDateTime( " " + FechaCierre.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaCierre_Date)) 
{
 FechaCierre = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaCierre = Convert.ToDateTime( " " + FechaCierre_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaCierre 
{
get
{
return _fechaCierre;
}
set 
{
if ( _fechaCierre != value) 
{
_fechaCierre = value ;
OnPropertyChanged("FechaCierre");
}
}
}

public virtual System.String CerradaPor 
{
get
{
if ( Usuario02 != null ) 
{
_cerradaPor = (System.String)Usuario02.Login;
}

return _cerradaPor;
}
set 
{
if ( _cerradaPor != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_usuario02 = null;

_cerradaPor = value ;
OnPropertyChanged("CerradaPor");
}
}
}

public virtual System.Int32? CodSolicitud 
{
get
{
if ( SolicitudServicio != null ) 
{
_codSolicitud = (System.Int32)SolicitudServicio.CodSolicitudServicio;
}

return _codSolicitud;
}
set 
{
if ( _codSolicitud != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_solicitudServicio = null;

_codSolicitud = value ;
OnPropertyChanged("CodSolicitud");
}
}
}

/// <summary>
/// Collection of IndicacionesLLamada.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "16ada563-7dd3-4ad1-ba74-e764d17a2eca" , CollectionOfType = typeof(IndicacionesLLamada)) ]
public virtual IList<IndicacionesLLamada> IndicacionesLLamadas 
{
get
{
 if (_indicacionesLLamadas == null) _indicacionesLLamadas = new List<IndicacionesLLamada>();

return _indicacionesLLamadas;
}
set 
{
if ( _indicacionesLLamadas != value) 
{
_indicacionesLLamadas = value ;
}
}
}

/// <summary>
/// Collection of Seguimiento.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "f62b7f23-c0c0-4d19-9a74-1df6a795213e" , CollectionOfType = typeof(Seguimiento)) ]
public virtual IList<Seguimiento> Seguimientos 
{
get
{
 if (_seguimientos == null) _seguimientos = new List<Seguimiento>();

return _seguimientos;
}
set 
{
if ( _seguimientos != value) 
{
_seguimientos = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_LlamadaSoporte_asesoresComerciales
/// </summary>
[GenWiseAttribute(RelationID = "6a85bb75-d389-425d-a307-2121b9e504ba") ]
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
/// Generated from Relation FK_LlamadaSoporte_contactosClientes
/// </summary>
[GenWiseAttribute(RelationID = "91ff214c-32b9-4f2c-bb65-dc13cdfc1c5d") ]
public virtual ContactosCliente ContactosCliente 
{
get
{
if ( _contactosCliente == null || _contactosCliente == null ) 
{
if ( String.IsNullOrEmpty(_nitCliente) || _nitCliente.Equals(string.Empty) || String.IsNullOrEmpty(_codContacto) || _codContacto.Equals(string.Empty) ) 
{
if ( _contactosCliente != null && ( _contactosCliente.NitCliente.Equals(null) || _contactosCliente.CodContacto.Equals(null) ) )
{
  _contactosCliente = null;
}
}
else
{
  _contactosCliente = (new ContactosClienteFactory()).Fetch(_nitCliente,_codContacto);
}
}

return _contactosCliente;
}
set 
{
if ( _contactosCliente != value) 
{
if ( value==null ) _nitCliente = null; else _nitCliente = (System.String)value.NitCliente; 
if ( value==null ) _codContacto = null; else _codContacto = (System.String)value.CodContacto; 
_contactosCliente = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_LlamadaSoporte_equipos
/// </summary>
[GenWiseAttribute(RelationID = "66d1013b-8384-436e-a117-900ce5512e95") ]
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
/// Generated from Relation FK_LlamadaSoporte_estadosLLamadasTecnicas
/// </summary>
[GenWiseAttribute(RelationID = "85fa8057-3645-4a42-8d88-110465fe93f0") ]
public virtual EstadosLLamadasTecnica EstadosLLamadasTecnica 
{
get
{
if ( _estadosLLamadasTecnica == null ) 
{
if ( String.IsNullOrEmpty(_codEstadoLLamadaTecnica) || _codEstadoLLamadaTecnica.Equals(string.Empty) ) 
{
if ( _estadosLLamadasTecnica != null && ( _estadosLLamadasTecnica.CodEstadoLlamada.Equals(null) ) )
{
  _estadosLLamadasTecnica = null;
}
}
else
{
_estadosLLamadasTecnica = (new EstadosLLamadasTecnicaFactory()).Get(_codEstadoLLamadaTecnica);
}
}

return _estadosLLamadasTecnica;
}
set 
{
if ( _estadosLLamadasTecnica != value) 
{
if ( value==null ) _codEstadoLLamadaTecnica = null; else _codEstadoLLamadaTecnica = (System.String)value.CodEstadoLlamada; 
_estadosLLamadasTecnica = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_LlamadaSoporte_ModalidadEquipo
/// </summary>
[GenWiseAttribute(RelationID = "2260bc53-b2aa-4500-8690-1e75f9b2bd9c") ]
public virtual ModalidadEquipo ModalidadEquipo 
{
get
{
if ( _modalidadEquipo == null ) 
{
if ( String.IsNullOrEmpty(_codModalidadEquipo) || _codModalidadEquipo.Equals(string.Empty) ) 
{
if ( _modalidadEquipo != null && ( _modalidadEquipo.CodModalidadEquipo.Equals(null) ) )
{
  _modalidadEquipo = null;
}
}
else
{
_modalidadEquipo = (new ModalidadEquipoFactory()).Get(_codModalidadEquipo);
}
}

return _modalidadEquipo;
}
set 
{
if ( _modalidadEquipo != value) 
{
if ( value==null ) _codModalidadEquipo = null; else _codModalidadEquipo = (System.String)value.CodModalidadEquipo; 
_modalidadEquipo = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_LlamadaSoporte_solicitudServicio
/// </summary>
[GenWiseAttribute(RelationID = "aab3580f-7b7d-4767-89c5-cf2dfc5a26cd") ]
public virtual SolicitudServicio SolicitudServicio 
{
get
{
if ( _solicitudServicio == null ) 
{
if ( !_codSolicitud.HasValue || _codSolicitud.Value.Equals(System.Int32.MinValue) ) 
{
if ( _solicitudServicio != null && ( _solicitudServicio.CodSolicitudServicio.Equals(null) ) )
{
  _solicitudServicio = null;
}
}
else
{
_solicitudServicio = (new SolicitudServicioFactory()).Get(_codSolicitud.Value);
}
}

return _solicitudServicio;
}
set 
{
if ( _solicitudServicio != value) 
{
if ( value==null ) _codSolicitud = null; else _codSolicitud = (System.Int32)value.CodSolicitudServicio; 
_solicitudServicio = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_LlamadaSoporte_sucursalCliente
/// </summary>
[GenWiseAttribute(RelationID = "f18bc721-ce21-4f0b-97fa-819558df70b6") ]
public virtual SucursalCliente SucursalCliente 
{
get
{
if ( _sucursalCliente == null || _sucursalCliente == null ) 
{
if ( String.IsNullOrEmpty(_nitCliente) || _nitCliente.Equals(string.Empty) || String.IsNullOrEmpty(_codUbicacion) || _codUbicacion.Equals(string.Empty) ) 
{
if ( _sucursalCliente != null && ( _sucursalCliente.NitCliente.Equals(null) || _sucursalCliente.CodSucursal.Equals(null) ) )
{
  _sucursalCliente = null;
}
}
else
{
  _sucursalCliente = (new SucursalClienteFactory()).Fetch(_nitCliente,_codUbicacion);
}
}

return _sucursalCliente;
}
set 
{
if ( _sucursalCliente != value) 
{
if ( value==null ) _nitCliente = null; else _nitCliente = (System.String)value.NitCliente; 
if ( value==null ) _codUbicacion = null; else _codUbicacion = (System.String)value.CodSucursal; 
_sucursalCliente = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_LlamadaSoporte_usuarios
/// </summary>
[GenWiseAttribute(RelationID = "640be00a-5b43-420d-b4ee-9540e2b222de") ]
public virtual Usuario0 Usuario0 
{
get
{
if ( _usuario0 == null ) 
{
if ( String.IsNullOrEmpty(_asesorTelefonico) || _asesorTelefonico.Equals(string.Empty) ) 
{
if ( _usuario0 != null && ( _usuario0.Login.Equals(null) ) )
{
  _usuario0 = null;
}
}
else
{
_usuario0 = (new Usuario0Factory()).Get(_asesorTelefonico);
}
}

return _usuario0;
}
set 
{
if ( _usuario0 != value) 
{
if ( value==null ) _asesorTelefonico = null; else _asesorTelefonico = (System.String)value.Login; 
_usuario0 = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_LlamadaSoporte_usuarios1
/// </summary>
[GenWiseAttribute(RelationID = "6b9668c1-95a0-41d1-93ea-40fa4c6d705c") ]
public virtual Usuario0 Usuario01 
{
get
{
if ( _usuario01 == null ) 
{
if ( String.IsNullOrEmpty(_ingenieroAsesor) || _ingenieroAsesor.Equals(string.Empty) ) 
{
if ( _usuario01 != null && ( _usuario01.Login.Equals(null) ) )
{
  _usuario01 = null;
}
}
else
{
_usuario01 = (new Usuario0Factory()).Get(_ingenieroAsesor);
}
}

return _usuario01;
}
set 
{
if ( _usuario01 != value) 
{
if ( value==null ) _ingenieroAsesor = null; else _ingenieroAsesor = (System.String)value.Login; 
_usuario01 = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_LlamadaSoporte_usuarios2
/// </summary>
[GenWiseAttribute(RelationID = "204a40ee-e34b-4c99-a015-f043b5a83602") ]
public virtual Usuario0 Usuario02 
{
get
{
if ( _usuario02 == null ) 
{
if ( String.IsNullOrEmpty(_cerradaPor) || _cerradaPor.Equals(string.Empty) ) 
{
if ( _usuario02 != null && ( _usuario02.Login.Equals(null) ) )
{
  _usuario02 = null;
}
}
else
{
_usuario02 = (new Usuario0Factory()).Get(_cerradaPor);
}
}

return _usuario02;
}
set 
{
if ( _usuario02 != value) 
{
if ( value==null ) _cerradaPor = null; else _cerradaPor = (System.String)value.Login; 
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
/// Create a new LlamadaSoporte object. 
/// </summary>
public  LlamadaSoporte()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  LlamadaSoporte(System.Int32 pIdLlamadaSoporte)
{
_idLlamadaSoporte = pIdLlamadaSoporte ;

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
if (  IdLlamadaSoporte.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (idLlamadaSoporte) can not be null!. " ) );
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

