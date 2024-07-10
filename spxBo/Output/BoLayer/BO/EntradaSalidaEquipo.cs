using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class EntradaSalidaEquipo : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codEntradaSalidaEquipos;
private System.DateTime? _fechaEntrada;
private System.DateTime? _fechaSalida;
private System.String _serial;
private System.String _codEstadoFisicamente;
private System.Int32? _codOrdenServicio;
private System.String _codTiposervicio;
private System.String _obsEntrada;
private System.String _obsSalida;
private System.String _nitCliente;
private System.String _codSucursal;
private System.String _codModalidad;
private System.DateTime? _fechaTerminacionMovto;
private System.String _creadoPor;
private System.DateTime? _fechaIngresoSeguimiento;
private System.DateTime? _fechaSeguimiento;
private System.String _usuarioSeguimiento;
private System.Boolean? _funcionaBien;
private System.String _observaciones;
private System.String _nitClienteSalida;
private System.String _codSucursalSalida;
private System.String _codModalidadSalida;
private System.String _codEstadoSalida;
private IList<AccesoriosxEntradaSalidaEquipo> _accesoriosxEntradaSalidaEquipos;
private IList<ArchivosxEntradaSalidaEquipo> _archivosxEntradaSalidaEquipos;
private Equipo _equipo;
private EstadoFisicamente _estadoFisicamente;
private EstadoLocalEquipo _estadoLocalEquipo;
private ModalidadEquipo _modalidadEquipo;
private ModalidadEquipo _modalidadEquipo1;
private SucursalCliente _sucursalCliente;
private SucursalCliente _sucursalCliente1;
private TipoServicio _tipoServicio;
private Usuario0 _usuario0;
private Usuario0 _usuario01;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodEntradaSalidaEquipos 
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
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaEntrada_Date 
{
get
{
if (  !FechaEntrada.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaEntrada.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaEntrada.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaEntrada_Time)) {

FechaEntrada = null;
}
 else
{
 FechaEntrada = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaEntrada.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaEntrada_Time)) 
{
 FechaEntrada = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaEntrada = Convert.ToDateTime( " " + value + " " + FechaEntrada.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaEntrada_Time 
{
get
{
if (  !FechaEntrada.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaEntrada.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaEntrada.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaEntrada_Date)) 
{
FechaEntrada = null;
}
 else
{
 FechaEntrada = Convert.ToDateTime( " " + FechaEntrada.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaEntrada_Date)) 
{
 FechaEntrada = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaEntrada = Convert.ToDateTime( " " + FechaEntrada_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaEntrada 
{
get
{
return _fechaEntrada;
}
set 
{
if ( _fechaEntrada != value) 
{
_fechaEntrada = value ;
OnPropertyChanged("FechaEntrada");
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

public virtual System.String CodEstadoFisicamente 
{
get
{
if ( EstadoFisicamente != null ) 
{
_codEstadoFisicamente = (System.String)EstadoFisicamente.CodEstadoFisicamente;
}

return _codEstadoFisicamente;
}
set 
{
if ( _codEstadoFisicamente != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_estadoFisicamente = null;

_codEstadoFisicamente = value ;
OnPropertyChanged("CodEstadoFisicamente");
}
}
}

public virtual System.Int32? CodOrdenServicio 
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

public virtual System.String ObsEntrada 
{
get
{
return _obsEntrada;
}
set 
{
if ( _obsEntrada != value) 
{
_obsEntrada = value ;
OnPropertyChanged("ObsEntrada");
}
}
}

public virtual System.String ObsSalida 
{
get
{
return _obsSalida;
}
set 
{
if ( _obsSalida != value) 
{
_obsSalida = value ;
OnPropertyChanged("ObsSalida");
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

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaTerminacionMovto_Date 
{
get
{
if (  !FechaTerminacionMovto.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaTerminacionMovto.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaTerminacionMovto.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaTerminacionMovto_Time)) {

FechaTerminacionMovto = null;
}
 else
{
 FechaTerminacionMovto = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaTerminacionMovto.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaTerminacionMovto_Time)) 
{
 FechaTerminacionMovto = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaTerminacionMovto = Convert.ToDateTime( " " + value + " " + FechaTerminacionMovto.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaTerminacionMovto_Time 
{
get
{
if (  !FechaTerminacionMovto.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaTerminacionMovto.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaTerminacionMovto.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaTerminacionMovto_Date)) 
{
FechaTerminacionMovto = null;
}
 else
{
 FechaTerminacionMovto = Convert.ToDateTime( " " + FechaTerminacionMovto.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaTerminacionMovto_Date)) 
{
 FechaTerminacionMovto = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaTerminacionMovto = Convert.ToDateTime( " " + FechaTerminacionMovto_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaTerminacionMovto 
{
get
{
return _fechaTerminacionMovto;
}
set 
{
if ( _fechaTerminacionMovto != value) 
{
_fechaTerminacionMovto = value ;
OnPropertyChanged("FechaTerminacionMovto");
}
}
}

public virtual System.String CreadoPor 
{
get
{
if ( Usuario0 != null ) 
{
_creadoPor = (System.String)Usuario0.Login;
}

return _creadoPor;
}
set 
{
if ( _creadoPor != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_usuario0 = null;

_creadoPor = value ;
OnPropertyChanged("CreadoPor");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaIngresoSeguimiento_Date 
{
get
{
if (  !FechaIngresoSeguimiento.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaIngresoSeguimiento.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaIngresoSeguimiento.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaIngresoSeguimiento_Time)) {

FechaIngresoSeguimiento = null;
}
 else
{
 FechaIngresoSeguimiento = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaIngresoSeguimiento.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaIngresoSeguimiento_Time)) 
{
 FechaIngresoSeguimiento = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaIngresoSeguimiento = Convert.ToDateTime( " " + value + " " + FechaIngresoSeguimiento.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaIngresoSeguimiento_Time 
{
get
{
if (  !FechaIngresoSeguimiento.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaIngresoSeguimiento.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaIngresoSeguimiento.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaIngresoSeguimiento_Date)) 
{
FechaIngresoSeguimiento = null;
}
 else
{
 FechaIngresoSeguimiento = Convert.ToDateTime( " " + FechaIngresoSeguimiento.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaIngresoSeguimiento_Date)) 
{
 FechaIngresoSeguimiento = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaIngresoSeguimiento = Convert.ToDateTime( " " + FechaIngresoSeguimiento_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaIngresoSeguimiento 
{
get
{
return _fechaIngresoSeguimiento;
}
set 
{
if ( _fechaIngresoSeguimiento != value) 
{
_fechaIngresoSeguimiento = value ;
OnPropertyChanged("FechaIngresoSeguimiento");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaSeguimiento_Date 
{
get
{
if (  !FechaSeguimiento.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaSeguimiento.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaSeguimiento.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaSeguimiento_Time)) {

FechaSeguimiento = null;
}
 else
{
 FechaSeguimiento = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaSeguimiento.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaSeguimiento_Time)) 
{
 FechaSeguimiento = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaSeguimiento = Convert.ToDateTime( " " + value + " " + FechaSeguimiento.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaSeguimiento_Time 
{
get
{
if (  !FechaSeguimiento.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaSeguimiento.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaSeguimiento.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaSeguimiento_Date)) 
{
FechaSeguimiento = null;
}
 else
{
 FechaSeguimiento = Convert.ToDateTime( " " + FechaSeguimiento.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaSeguimiento_Date)) 
{
 FechaSeguimiento = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaSeguimiento = Convert.ToDateTime( " " + FechaSeguimiento_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaSeguimiento 
{
get
{
return _fechaSeguimiento;
}
set 
{
if ( _fechaSeguimiento != value) 
{
_fechaSeguimiento = value ;
OnPropertyChanged("FechaSeguimiento");
}
}
}

public virtual System.String UsuarioSeguimiento 
{
get
{
if ( Usuario01 != null ) 
{
_usuarioSeguimiento = (System.String)Usuario01.Login;
}

return _usuarioSeguimiento;
}
set 
{
if ( _usuarioSeguimiento != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_usuario01 = null;

_usuarioSeguimiento = value ;
OnPropertyChanged("UsuarioSeguimiento");
}
}
}

public virtual System.Boolean? FuncionaBien 
{
get
{
return _funcionaBien;
}
set 
{
if ( _funcionaBien != value) 
{
_funcionaBien = value ;
OnPropertyChanged("FuncionaBien");
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

public virtual System.String NitClienteSalida 
{
get
{
if ( SucursalCliente1 != null ) 
{
_nitClienteSalida = (System.String)SucursalCliente1.NitCliente;
}

return _nitClienteSalida;
}
set 
{
if ( _nitClienteSalida != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_sucursalCliente1 = null;

_nitClienteSalida = value ;
OnPropertyChanged("NitClienteSalida");
}
}
}

public virtual System.String CodSucursalSalida 
{
get
{
if ( SucursalCliente1 != null ) 
{
_codSucursalSalida = (System.String)SucursalCliente1.CodSucursal;
}

return _codSucursalSalida;
}
set 
{
if ( _codSucursalSalida != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_sucursalCliente1 = null;

_codSucursalSalida = value ;
OnPropertyChanged("CodSucursalSalida");
}
}
}

public virtual System.String CodModalidadSalida 
{
get
{
if ( ModalidadEquipo1 != null ) 
{
_codModalidadSalida = (System.String)ModalidadEquipo1.CodModalidadEquipo;
}

return _codModalidadSalida;
}
set 
{
if ( _codModalidadSalida != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_modalidadEquipo1 = null;

_codModalidadSalida = value ;
OnPropertyChanged("CodModalidadSalida");
}
}
}

public virtual System.String CodEstadoSalida 
{
get
{
if ( EstadoLocalEquipo != null ) 
{
_codEstadoSalida = (System.String)EstadoLocalEquipo.CodEstadoLocal;
}

return _codEstadoSalida;
}
set 
{
if ( _codEstadoSalida != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_estadoLocalEquipo = null;

_codEstadoSalida = value ;
OnPropertyChanged("CodEstadoSalida");
}
}
}

/// <summary>
/// Collection of AccesoriosxEntradaSalidaEquipo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "f1f780af-830c-4c8d-94cd-e02593455a2e" , CollectionOfType = typeof(AccesoriosxEntradaSalidaEquipo)) ]
public virtual IList<AccesoriosxEntradaSalidaEquipo> AccesoriosxEntradaSalidaEquipos 
{
get
{
 if (_accesoriosxEntradaSalidaEquipos == null) _accesoriosxEntradaSalidaEquipos = new List<AccesoriosxEntradaSalidaEquipo>();

return _accesoriosxEntradaSalidaEquipos;
}
set 
{
if ( _accesoriosxEntradaSalidaEquipos != value) 
{
_accesoriosxEntradaSalidaEquipos = value ;
}
}
}

/// <summary>
/// Collection of ArchivosxEntradaSalidaEquipo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "b189b9e1-071a-40b2-a890-ee33b728f422" , CollectionOfType = typeof(ArchivosxEntradaSalidaEquipo)) ]
public virtual IList<ArchivosxEntradaSalidaEquipo> ArchivosxEntradaSalidaEquipos 
{
get
{
 if (_archivosxEntradaSalidaEquipos == null) _archivosxEntradaSalidaEquipos = new List<ArchivosxEntradaSalidaEquipo>();

return _archivosxEntradaSalidaEquipos;
}
set 
{
if ( _archivosxEntradaSalidaEquipos != value) 
{
_archivosxEntradaSalidaEquipos = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_EntradaSalidaEquipos_equipos
/// </summary>
[GenWiseAttribute(RelationID = "da3e2f05-61db-4978-923f-a337ca4b48ab") ]
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
/// Generated from Relation FK_EntradaSalidaEquipos_EstadoFisicamente
/// </summary>
[GenWiseAttribute(RelationID = "77878183-02bf-4b00-b9bc-6643c39d4110") ]
public virtual EstadoFisicamente EstadoFisicamente 
{
get
{
if ( _estadoFisicamente == null ) 
{
if ( String.IsNullOrEmpty(_codEstadoFisicamente) || _codEstadoFisicamente.Equals(string.Empty) ) 
{
if ( _estadoFisicamente != null && ( _estadoFisicamente.CodEstadoFisicamente.Equals(null) ) )
{
  _estadoFisicamente = null;
}
}
else
{
_estadoFisicamente = (new EstadoFisicamenteFactory()).Get(_codEstadoFisicamente);
}
}

return _estadoFisicamente;
}
set 
{
if ( _estadoFisicamente != value) 
{
if ( value==null ) _codEstadoFisicamente = null; else _codEstadoFisicamente = (System.String)value.CodEstadoFisicamente; 
_estadoFisicamente = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_EntradaSalidaEquipos_estadoLocalEquipos
/// </summary>
[GenWiseAttribute(RelationID = "0b096251-9ced-45fe-821b-bf0abd1d1f09") ]
public virtual EstadoLocalEquipo EstadoLocalEquipo 
{
get
{
if ( _estadoLocalEquipo == null ) 
{
if ( String.IsNullOrEmpty(_codEstadoSalida) || _codEstadoSalida.Equals(string.Empty) ) 
{
if ( _estadoLocalEquipo != null && ( _estadoLocalEquipo.CodEstadoLocal.Equals(null) ) )
{
  _estadoLocalEquipo = null;
}
}
else
{
_estadoLocalEquipo = (new EstadoLocalEquipoFactory()).Get(_codEstadoSalida);
}
}

return _estadoLocalEquipo;
}
set 
{
if ( _estadoLocalEquipo != value) 
{
if ( value==null ) _codEstadoSalida = null; else _codEstadoSalida = (System.String)value.CodEstadoLocal; 
_estadoLocalEquipo = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_EntradaSalidaEquipos_ModalidadEquipo
/// </summary>
[GenWiseAttribute(RelationID = "4c478760-f598-487d-ab99-839e82832a5a") ]
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
/// Generated from Relation FK_EntradaSalidaEquipos_ModalidadEquipo1
/// </summary>
[GenWiseAttribute(RelationID = "3b6f7ac2-4bd4-42cb-a258-555bf5e70da6") ]
public virtual ModalidadEquipo ModalidadEquipo1 
{
get
{
if ( _modalidadEquipo1 == null ) 
{
if ( String.IsNullOrEmpty(_codModalidadSalida) || _codModalidadSalida.Equals(string.Empty) ) 
{
if ( _modalidadEquipo1 != null && ( _modalidadEquipo1.CodModalidadEquipo.Equals(null) ) )
{
  _modalidadEquipo1 = null;
}
}
else
{
_modalidadEquipo1 = (new ModalidadEquipoFactory()).Get(_codModalidadSalida);
}
}

return _modalidadEquipo1;
}
set 
{
if ( _modalidadEquipo1 != value) 
{
if ( value==null ) _codModalidadSalida = null; else _codModalidadSalida = (System.String)value.CodModalidadEquipo; 
_modalidadEquipo1 = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_EntradaSalidaEquipos_sucursalCliente
/// </summary>
[GenWiseAttribute(RelationID = "a5ce3ca0-d2ec-4c75-bb16-515593c3cffc") ]
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
/// Generated from Relation FK_EntradaSalidaEquipos_sucursalCliente1
/// </summary>
[GenWiseAttribute(RelationID = "affef2ed-d0a9-4550-b621-d9581813ea54") ]
public virtual SucursalCliente SucursalCliente1 
{
get
{
if ( _sucursalCliente1 == null || _sucursalCliente1 == null ) 
{
if ( String.IsNullOrEmpty(_nitClienteSalida) || _nitClienteSalida.Equals(string.Empty) || String.IsNullOrEmpty(_codSucursalSalida) || _codSucursalSalida.Equals(string.Empty) ) 
{
if ( _sucursalCliente1 != null && ( _sucursalCliente1.NitCliente.Equals(null) || _sucursalCliente1.CodSucursal.Equals(null) ) )
{
  _sucursalCliente1 = null;
}
}
else
{
  _sucursalCliente1 = (new SucursalClienteFactory()).Fetch(_nitClienteSalida,_codSucursalSalida);
}
}

return _sucursalCliente1;
}
set 
{
if ( _sucursalCliente1 != value) 
{
if ( value==null ) _nitClienteSalida = null; else _nitClienteSalida = (System.String)value.NitCliente; 
if ( value==null ) _codSucursalSalida = null; else _codSucursalSalida = (System.String)value.CodSucursal; 
_sucursalCliente1 = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_EntradaSalidaEquipos_TipoServicio
/// </summary>
[GenWiseAttribute(RelationID = "c95cb4a8-6e93-409c-ad32-18cd4e24b2e9") ]
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
/// Generated from Relation FK_EntradaSalidaEquipos_usuarios
/// </summary>
[GenWiseAttribute(RelationID = "34918523-b4c2-4ac1-9c4b-c1401ec20a54") ]
public virtual Usuario0 Usuario0 
{
get
{
if ( _usuario0 == null ) 
{
if ( String.IsNullOrEmpty(_creadoPor) || _creadoPor.Equals(string.Empty) ) 
{
if ( _usuario0 != null && ( _usuario0.Login.Equals(null) ) )
{
  _usuario0 = null;
}
}
else
{
_usuario0 = (new Usuario0Factory()).Get(_creadoPor);
}
}

return _usuario0;
}
set 
{
if ( _usuario0 != value) 
{
if ( value==null ) _creadoPor = null; else _creadoPor = (System.String)value.Login; 
_usuario0 = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_EntradaSalidaEquipos_usuarios1
/// </summary>
[GenWiseAttribute(RelationID = "19c008b9-4307-4e28-941a-4c63a5cb5b72") ]
public virtual Usuario0 Usuario01 
{
get
{
if ( _usuario01 == null ) 
{
if ( String.IsNullOrEmpty(_usuarioSeguimiento) || _usuarioSeguimiento.Equals(string.Empty) ) 
{
if ( _usuario01 != null && ( _usuario01.Login.Equals(null) ) )
{
  _usuario01 = null;
}
}
else
{
_usuario01 = (new Usuario0Factory()).Get(_usuarioSeguimiento);
}
}

return _usuario01;
}
set 
{
if ( _usuario01 != value) 
{
if ( value==null ) _usuarioSeguimiento = null; else _usuarioSeguimiento = (System.String)value.Login; 
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
/// Create a new EntradaSalidaEquipo object. 
/// </summary>
public  EntradaSalidaEquipo()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  EntradaSalidaEquipo(System.Int32 pCodEntradaSalidaEquipos)
{
_codEntradaSalidaEquipos = pCodEntradaSalidaEquipos ;

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
if (  CodEntradaSalidaEquipos.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codEntradaSalidaEquipos) can not be null!. " ) );
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

