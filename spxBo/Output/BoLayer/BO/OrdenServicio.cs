using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class OrdenServicio : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codOrdenServicio;
private System.DateTime? _fechaCreacion;
private System.DateTime? _fechaProgramacion;
private System.DateTime? _fechaFinProgramacion;
private System.DateTime? _fechaCierre;
private System.DateTime? _fechaAprobacion;
private System.DateTime? _fechaAnulacion;
private System.String _creadaPor;
private System.String _aprobadaPor;
private System.String _asignadoA;
private System.String _cerradaPor;
private System.String _anuladaPor;
private System.Boolean? _esInterno;
private System.String _serial;
private System.String _nitCliente;
private System.String _codSucursal;
private System.String _codTiposervicio;
private System.String _codModalidad;
private System.String _codEstadoOrdenServicio;
private System.Int32? _codPrioridadOS;
private System.String _observaciones;
private System.String _observacionesIngeniero;
private System.String _fallasReportadas;
private System.String _diagnostico;
private System.Int32? _numEntrada;
private System.String _horaEntradaControl;
private System.String _horaSalidaControl;
private System.String _nombreUsuarioCliente;
private System.Int32? _codAsesor;
private IList<ActividadxordenServicio> _actividadxordenServicios;
private IList<ArchivosXOrdenServicio> _archivosXOrdenServicios;
private IList<ComprobantesAceptacionOrdenservicio> _comprobantesAceptacionOrdenservicios;
private IList<DetalleProgramacionViaje> _detalleProgramacionViajes;
private IList<OrdenPrestamo> _ordenPrestamos;
private IList<ReasignacionOrdenesTrabajo> _reasignacionOrdenesTrabajos;
private IList<RepuestoxOrdenServicio> _repuestoxOrdenServicios;
private IList<SolicitudInsumo> _solicitudInsumos;
private IList<SolicitudServicio> _solicitudServicios;
private AsesoresComerciale _asesoresComerciale;
private Equipo _equipo;
private EstadosOrdenServicio _estadosOrdenServicio;
private ModalidadEquipo _modalidadEquipo;
private SucursalCliente _sucursalCliente;
private TipoServicio _tipoServicio;

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
public virtual System.String FechaProgramacion_Date 
{
get
{
if (  !FechaProgramacion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaProgramacion.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaProgramacion.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaProgramacion_Time)) {

FechaProgramacion = null;
}
 else
{
 FechaProgramacion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaProgramacion.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaProgramacion_Time)) 
{
 FechaProgramacion = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaProgramacion = Convert.ToDateTime( " " + value + " " + FechaProgramacion.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaProgramacion_Time 
{
get
{
if (  !FechaProgramacion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaProgramacion.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaProgramacion.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaProgramacion_Date)) 
{
FechaProgramacion = null;
}
 else
{
 FechaProgramacion = Convert.ToDateTime( " " + FechaProgramacion.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaProgramacion_Date)) 
{
 FechaProgramacion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaProgramacion = Convert.ToDateTime( " " + FechaProgramacion_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaProgramacion 
{
get
{
return _fechaProgramacion;
}
set 
{
if ( _fechaProgramacion != value) 
{
_fechaProgramacion = value ;
OnPropertyChanged("FechaProgramacion");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaFinProgramacion_Date 
{
get
{
if (  !FechaFinProgramacion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaFinProgramacion.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaFinProgramacion.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaFinProgramacion_Time)) {

FechaFinProgramacion = null;
}
 else
{
 FechaFinProgramacion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaFinProgramacion.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaFinProgramacion_Time)) 
{
 FechaFinProgramacion = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaFinProgramacion = Convert.ToDateTime( " " + value + " " + FechaFinProgramacion.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaFinProgramacion_Time 
{
get
{
if (  !FechaFinProgramacion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaFinProgramacion.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaFinProgramacion.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaFinProgramacion_Date)) 
{
FechaFinProgramacion = null;
}
 else
{
 FechaFinProgramacion = Convert.ToDateTime( " " + FechaFinProgramacion.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaFinProgramacion_Date)) 
{
 FechaFinProgramacion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaFinProgramacion = Convert.ToDateTime( " " + FechaFinProgramacion_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaFinProgramacion 
{
get
{
return _fechaFinProgramacion;
}
set 
{
if ( _fechaFinProgramacion != value) 
{
_fechaFinProgramacion = value ;
OnPropertyChanged("FechaFinProgramacion");
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

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaAnulacion_Date 
{
get
{
if (  !FechaAnulacion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaAnulacion.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaAnulacion.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaAnulacion_Time)) {

FechaAnulacion = null;
}
 else
{
 FechaAnulacion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaAnulacion.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaAnulacion_Time)) 
{
 FechaAnulacion = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaAnulacion = Convert.ToDateTime( " " + value + " " + FechaAnulacion.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaAnulacion_Time 
{
get
{
if (  !FechaAnulacion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaAnulacion.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaAnulacion.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaAnulacion_Date)) 
{
FechaAnulacion = null;
}
 else
{
 FechaAnulacion = Convert.ToDateTime( " " + FechaAnulacion.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaAnulacion_Date)) 
{
 FechaAnulacion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaAnulacion = Convert.ToDateTime( " " + FechaAnulacion_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaAnulacion 
{
get
{
return _fechaAnulacion;
}
set 
{
if ( _fechaAnulacion != value) 
{
_fechaAnulacion = value ;
OnPropertyChanged("FechaAnulacion");
}
}
}

public virtual System.String CreadaPor 
{
get
{
return _creadaPor;
}
set 
{
if ( _creadaPor != value) 
{
_creadaPor = value ;
OnPropertyChanged("CreadaPor");
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

public virtual System.String AsignadoA 
{
get
{
return _asignadoA;
}
set 
{
if ( _asignadoA != value) 
{
_asignadoA = value ;
OnPropertyChanged("AsignadoA");
}
}
}

public virtual System.String CerradaPor 
{
get
{
return _cerradaPor;
}
set 
{
if ( _cerradaPor != value) 
{
_cerradaPor = value ;
OnPropertyChanged("CerradaPor");
}
}
}

public virtual System.String AnuladaPor 
{
get
{
return _anuladaPor;
}
set 
{
if ( _anuladaPor != value) 
{
_anuladaPor = value ;
OnPropertyChanged("AnuladaPor");
}
}
}

public virtual System.Boolean? EsInterno 
{
get
{
return _esInterno;
}
set 
{
if ( _esInterno != value) 
{
_esInterno = value ;
OnPropertyChanged("EsInterno");
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

public virtual System.String CodTiposervicio 
{
get
{
if ( TipoServicio != null ) 
{
_codTiposervicio = (System.String)TipoServicio.CodTipoServicio;
}

return _codTiposervicio;
}
set 
{
if ( _codTiposervicio != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_tipoServicio = null;

_codTiposervicio = value ;
OnPropertyChanged("CodTiposervicio");
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

public virtual System.String CodEstadoOrdenServicio 
{
get
{
if ( EstadosOrdenServicio != null ) 
{
_codEstadoOrdenServicio = (System.String)EstadosOrdenServicio.CodEstadoOrdenServicio;
}

return _codEstadoOrdenServicio;
}
set 
{
if ( _codEstadoOrdenServicio != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_estadosOrdenServicio = null;

_codEstadoOrdenServicio = value ;
OnPropertyChanged("CodEstadoOrdenServicio");
}
}
}

public virtual System.Int32? CodPrioridadOS 
{
get
{
return _codPrioridadOS;
}
set 
{
if ( _codPrioridadOS != value) 
{
_codPrioridadOS = value ;
OnPropertyChanged("CodPrioridadOS");
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

public virtual System.String ObservacionesIngeniero 
{
get
{
return _observacionesIngeniero;
}
set 
{
if ( _observacionesIngeniero != value) 
{
_observacionesIngeniero = value ;
OnPropertyChanged("ObservacionesIngeniero");
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

public virtual System.String Diagnostico 
{
get
{
return _diagnostico;
}
set 
{
if ( _diagnostico != value) 
{
_diagnostico = value ;
OnPropertyChanged("Diagnostico");
}
}
}

public virtual System.Int32? NumEntrada 
{
get
{
return _numEntrada;
}
set 
{
if ( _numEntrada != value) 
{
_numEntrada = value ;
OnPropertyChanged("NumEntrada");
}
}
}

public virtual System.String HoraEntradaControl 
{
get
{
return _horaEntradaControl;
}
set 
{
if ( _horaEntradaControl != value) 
{
_horaEntradaControl = value ;
OnPropertyChanged("HoraEntradaControl");
}
}
}

public virtual System.String HoraSalidaControl 
{
get
{
return _horaSalidaControl;
}
set 
{
if ( _horaSalidaControl != value) 
{
_horaSalidaControl = value ;
OnPropertyChanged("HoraSalidaControl");
}
}
}

public virtual System.String NombreUsuarioCliente 
{
get
{
return _nombreUsuarioCliente;
}
set 
{
if ( _nombreUsuarioCliente != value) 
{
_nombreUsuarioCliente = value ;
OnPropertyChanged("NombreUsuarioCliente");
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

/// <summary>
/// Collection of ActividadxordenServicio.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "e09bd3f8-4d3f-4d6b-8b97-5b1a3b51a4f6" , CollectionOfType = typeof(ActividadxordenServicio)) ]
public virtual IList<ActividadxordenServicio> ActividadxordenServicios 
{
get
{
 if (_actividadxordenServicios == null) _actividadxordenServicios = new List<ActividadxordenServicio>();

return _actividadxordenServicios;
}
set 
{
if ( _actividadxordenServicios != value) 
{
_actividadxordenServicios = value ;
}
}
}

/// <summary>
/// Collection of ArchivosXOrdenServicio.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "781996e3-10ed-4da0-a884-17856ca0bb39" , CollectionOfType = typeof(ArchivosXOrdenServicio)) ]
public virtual IList<ArchivosXOrdenServicio> ArchivosXOrdenServicios 
{
get
{
 if (_archivosXOrdenServicios == null) _archivosXOrdenServicios = new List<ArchivosXOrdenServicio>();

return _archivosXOrdenServicios;
}
set 
{
if ( _archivosXOrdenServicios != value) 
{
_archivosXOrdenServicios = value ;
}
}
}

/// <summary>
/// Collection of ComprobantesAceptacionOrdenservicio.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "6d7dfbd0-1a61-4530-9fa1-ee7730b66779" , CollectionOfType = typeof(ComprobantesAceptacionOrdenservicio)) ]
public virtual IList<ComprobantesAceptacionOrdenservicio> ComprobantesAceptacionOrdenservicios 
{
get
{
 if (_comprobantesAceptacionOrdenservicios == null) _comprobantesAceptacionOrdenservicios = new List<ComprobantesAceptacionOrdenservicio>();

return _comprobantesAceptacionOrdenservicios;
}
set 
{
if ( _comprobantesAceptacionOrdenservicios != value) 
{
_comprobantesAceptacionOrdenservicios = value ;
}
}
}

/// <summary>
/// Collection of DetalleProgramacionViaje.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "77c5da6c-f88a-4367-b43c-20d742a1e119" , CollectionOfType = typeof(DetalleProgramacionViaje)) ]
public virtual IList<DetalleProgramacionViaje> DetalleProgramacionViajes 
{
get
{
 if (_detalleProgramacionViajes == null) _detalleProgramacionViajes = new List<DetalleProgramacionViaje>();

return _detalleProgramacionViajes;
}
set 
{
if ( _detalleProgramacionViajes != value) 
{
_detalleProgramacionViajes = value ;
}
}
}

/// <summary>
/// Collection of OrdenPrestamo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "543636d3-3b27-468a-aef4-1fb186931edd" , CollectionOfType = typeof(OrdenPrestamo)) ]
public virtual IList<OrdenPrestamo> OrdenPrestamos 
{
get
{
 if (_ordenPrestamos == null) _ordenPrestamos = new List<OrdenPrestamo>();

return _ordenPrestamos;
}
set 
{
if ( _ordenPrestamos != value) 
{
_ordenPrestamos = value ;
}
}
}

/// <summary>
/// Collection of ReasignacionOrdenesTrabajo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "c5903e92-bda8-44ef-a30f-4949e1a8ce9c" , CollectionOfType = typeof(ReasignacionOrdenesTrabajo)) ]
public virtual IList<ReasignacionOrdenesTrabajo> ReasignacionOrdenesTrabajos 
{
get
{
 if (_reasignacionOrdenesTrabajos == null) _reasignacionOrdenesTrabajos = new List<ReasignacionOrdenesTrabajo>();

return _reasignacionOrdenesTrabajos;
}
set 
{
if ( _reasignacionOrdenesTrabajos != value) 
{
_reasignacionOrdenesTrabajos = value ;
}
}
}

/// <summary>
/// Collection of RepuestoxOrdenServicio.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "4d7a967a-d15a-4370-8e98-1f8a035eb0ab" , CollectionOfType = typeof(RepuestoxOrdenServicio)) ]
public virtual IList<RepuestoxOrdenServicio> RepuestoxOrdenServicios 
{
get
{
 if (_repuestoxOrdenServicios == null) _repuestoxOrdenServicios = new List<RepuestoxOrdenServicio>();

return _repuestoxOrdenServicios;
}
set 
{
if ( _repuestoxOrdenServicios != value) 
{
_repuestoxOrdenServicios = value ;
}
}
}

/// <summary>
/// Collection of SolicitudInsumo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "75fee3cf-6fe6-4b17-b844-64aa339252d8" , CollectionOfType = typeof(SolicitudInsumo)) ]
public virtual IList<SolicitudInsumo> SolicitudInsumos 
{
get
{
 if (_solicitudInsumos == null) _solicitudInsumos = new List<SolicitudInsumo>();

return _solicitudInsumos;
}
set 
{
if ( _solicitudInsumos != value) 
{
_solicitudInsumos = value ;
}
}
}

/// <summary>
/// Collection of SolicitudServicio.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "fe2e0522-9b29-465f-87e1-24215877c55b" , CollectionOfType = typeof(SolicitudServicio)) ]
public virtual IList<SolicitudServicio> SolicitudServicios 
{
get
{
 if (_solicitudServicios == null) _solicitudServicios = new List<SolicitudServicio>();

return _solicitudServicios;
}
set 
{
if ( _solicitudServicios != value) 
{
_solicitudServicios = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_ordenServicio_asesoresComerciales
/// </summary>
[GenWiseAttribute(RelationID = "fb257a46-2f25-4400-966c-b1bcc6de2b4f") ]
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
/// Generated from Relation FK_ordenServicio_equipos1
/// </summary>
[GenWiseAttribute(RelationID = "48a29f7e-8344-4665-b1cd-7fe542d9bd27") ]
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
/// Generated from Relation FK_ordenServicio_estadosOrdenServicio
/// </summary>
[GenWiseAttribute(RelationID = "d9efbe2f-0abe-48ed-a7fd-6172001a7f9f") ]
public virtual EstadosOrdenServicio EstadosOrdenServicio 
{
get
{
if ( _estadosOrdenServicio == null ) 
{
if ( String.IsNullOrEmpty(_codEstadoOrdenServicio) || _codEstadoOrdenServicio.Equals(string.Empty) ) 
{
if ( _estadosOrdenServicio != null && ( _estadosOrdenServicio.CodEstadoOrdenServicio.Equals(null) ) )
{
  _estadosOrdenServicio = null;
}
}
else
{
_estadosOrdenServicio = (new EstadosOrdenServicioFactory()).Get(_codEstadoOrdenServicio);
}
}

return _estadosOrdenServicio;
}
set 
{
if ( _estadosOrdenServicio != value) 
{
if ( value==null ) _codEstadoOrdenServicio = null; else _codEstadoOrdenServicio = (System.String)value.CodEstadoOrdenServicio; 
_estadosOrdenServicio = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_ordenServicio_ModalidadEquipo
/// </summary>
[GenWiseAttribute(RelationID = "f068f931-a3b1-4bf0-bac4-9850432a8da2") ]
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
/// Generated from Relation FK_ordenServicio_sucursalCliente
/// </summary>
[GenWiseAttribute(RelationID = "811b128c-07a0-49b3-a071-41d0c1fc6b1e") ]
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
/// Generated from Relation FK_ordenServicio_TipoServicio
/// </summary>
[GenWiseAttribute(RelationID = "bdec0077-42ba-4764-8979-c26ab741f348") ]
public virtual TipoServicio TipoServicio 
{
get
{
if ( _tipoServicio == null ) 
{
if ( String.IsNullOrEmpty(_codTiposervicio) || _codTiposervicio.Equals(string.Empty) ) 
{
if ( _tipoServicio != null && ( _tipoServicio.CodTipoServicio.Equals(null) ) )
{
  _tipoServicio = null;
}
}
else
{
_tipoServicio = (new TipoServicioFactory()).Get(_codTiposervicio);
}
}

return _tipoServicio;
}
set 
{
if ( _tipoServicio != value) 
{
if ( value==null ) _codTiposervicio = null; else _codTiposervicio = (System.String)value.CodTipoServicio; 
_tipoServicio = value ;
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
/// Create a new OrdenServicio object. 
/// </summary>
public  OrdenServicio()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  OrdenServicio(System.Int32 pCodOrdenServicio)
{
_codOrdenServicio = pCodOrdenServicio ;

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

