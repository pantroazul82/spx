using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class Equipo : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _codFabricante;
private System.String _codModelo;
private System.String _serial;
private System.DateTime? _fechaLlegada;
private System.DateTime? _fechaSalida;
private System.DateTime? _fechaProximoMante;
private System.DateTime? _fechaUltimoMante;
private System.String _nitClienteUbica;
private System.String _codSucursalUbica;
private System.String _codTipoServicio;
private System.String _observacionesUltimoMante;
private System.String _codModalidadEquipo;
private System.String _codEstadoLocal;
private System.DateTime? _fechaProximaProgramacion;
private System.DateTime? _fechaUltimoTraslado;
private System.String _codAdicional;
private System.String _obsEquipo;
private System.Int32? _codTipoPropiedad;
private System.DateTime? _fechaCambioTipoPropiedad;
private System.String _usuarioCambio;
private IList<ArchivosXequipo> _archivosXequipos;
private IList<ContratosxEquipo> _contratosxEquipos;
private IList<DetalleProgramacionViaje> _detalleProgramacionViajes;
private IList<EntradaSalidaEquipo> _entradaSalidaEquipos;
private IList<EquipoAuxiliar> _equipoAuxiliars;
private IList<EquipoAuxiliar> _equipoAuxiliars1;
private IList<LlamadaSoporte> _llamadaSoportes;
private IList<MantenimientosxContrato> _mantenimientosxContratos;
private IList<OrdenServicio> _ordenServicios;
private IList<Recoleccion> _recoleccions;
private IList<Seguimiento> _seguimientos;
private IList<SolicitudServicio> _solicitudServicios;
private EstadoLocalEquipo _estadoLocalEquipo;
private ModalidadEquipo _modalidadEquipo;
private Modelo _modelo;
private SucursalCliente _sucursalCliente;
private TipoPropiedad _tipoPropiedad;
private TipoServicio _tipoServicio;

#endregion


#region --- Class Properties ---

public virtual System.String CodFabricante 
{
get
{
if ( Modelo != null ) 
{
_codFabricante = (System.String)Modelo.CodFabricante;
}

return _codFabricante;
}
set 
{
if ( _codFabricante != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_modelo = null;

_codFabricante = value ;
OnPropertyChanged("CodFabricante");
}
}
}

public virtual System.String CodModelo 
{
get
{
if ( Modelo != null ) 
{
_codModelo = (System.String)Modelo.CodModelo;
}

return _codModelo;
}
set 
{
if ( _codModelo != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_modelo = null;

_codModelo = value ;
OnPropertyChanged("CodModelo");
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

public virtual System.String NitClienteUbica 
{
get
{
if ( SucursalCliente != null ) 
{
_nitClienteUbica = (System.String)SucursalCliente.NitCliente;
}

return _nitClienteUbica;
}
set 
{
if ( _nitClienteUbica != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_sucursalCliente = null;

_nitClienteUbica = value ;
OnPropertyChanged("NitClienteUbica");
}
}
}

public virtual System.String CodSucursalUbica 
{
get
{
if ( SucursalCliente != null ) 
{
_codSucursalUbica = (System.String)SucursalCliente.CodSucursal;
}

return _codSucursalUbica;
}
set 
{
if ( _codSucursalUbica != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_sucursalCliente = null;

_codSucursalUbica = value ;
OnPropertyChanged("CodSucursalUbica");
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

public virtual System.String CodEstadoLocal 
{
get
{
if ( EstadoLocalEquipo != null ) 
{
_codEstadoLocal = (System.String)EstadoLocalEquipo.CodEstadoLocal;
}

return _codEstadoLocal;
}
set 
{
if ( _codEstadoLocal != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_estadoLocalEquipo = null;

_codEstadoLocal = value ;
OnPropertyChanged("CodEstadoLocal");
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
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaUltimoTraslado_Date 
{
get
{
if (  !FechaUltimoTraslado.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaUltimoTraslado.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaUltimoTraslado.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaUltimoTraslado_Time)) {

FechaUltimoTraslado = null;
}
 else
{
 FechaUltimoTraslado = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaUltimoTraslado.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaUltimoTraslado_Time)) 
{
 FechaUltimoTraslado = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaUltimoTraslado = Convert.ToDateTime( " " + value + " " + FechaUltimoTraslado.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaUltimoTraslado_Time 
{
get
{
if (  !FechaUltimoTraslado.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaUltimoTraslado.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaUltimoTraslado.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaUltimoTraslado_Date)) 
{
FechaUltimoTraslado = null;
}
 else
{
 FechaUltimoTraslado = Convert.ToDateTime( " " + FechaUltimoTraslado.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaUltimoTraslado_Date)) 
{
 FechaUltimoTraslado = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaUltimoTraslado = Convert.ToDateTime( " " + FechaUltimoTraslado_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaUltimoTraslado 
{
get
{
return _fechaUltimoTraslado;
}
set 
{
if ( _fechaUltimoTraslado != value) 
{
_fechaUltimoTraslado = value ;
OnPropertyChanged("FechaUltimoTraslado");
}
}
}

public virtual System.String CodAdicional 
{
get
{
return _codAdicional;
}
set 
{
if ( _codAdicional != value) 
{
_codAdicional = value ;
OnPropertyChanged("CodAdicional");
}
}
}

public virtual System.String ObsEquipo 
{
get
{
return _obsEquipo;
}
set 
{
if ( _obsEquipo != value) 
{
_obsEquipo = value ;
OnPropertyChanged("ObsEquipo");
}
}
}

public virtual System.Int32? CodTipoPropiedad 
{
get
{
if ( TipoPropiedad != null ) 
{
_codTipoPropiedad = (System.Int32)TipoPropiedad.CodTipoPropiedad;
}

return _codTipoPropiedad;
}
set 
{
if ( _codTipoPropiedad != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_tipoPropiedad = null;

_codTipoPropiedad = value ;
OnPropertyChanged("CodTipoPropiedad");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaCambioTipoPropiedad_Date 
{
get
{
if (  !FechaCambioTipoPropiedad.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaCambioTipoPropiedad.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaCambioTipoPropiedad.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaCambioTipoPropiedad_Time)) {

FechaCambioTipoPropiedad = null;
}
 else
{
 FechaCambioTipoPropiedad = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaCambioTipoPropiedad.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaCambioTipoPropiedad_Time)) 
{
 FechaCambioTipoPropiedad = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaCambioTipoPropiedad = Convert.ToDateTime( " " + value + " " + FechaCambioTipoPropiedad.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaCambioTipoPropiedad_Time 
{
get
{
if (  !FechaCambioTipoPropiedad.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaCambioTipoPropiedad.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaCambioTipoPropiedad.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaCambioTipoPropiedad_Date)) 
{
FechaCambioTipoPropiedad = null;
}
 else
{
 FechaCambioTipoPropiedad = Convert.ToDateTime( " " + FechaCambioTipoPropiedad.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaCambioTipoPropiedad_Date)) 
{
 FechaCambioTipoPropiedad = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaCambioTipoPropiedad = Convert.ToDateTime( " " + FechaCambioTipoPropiedad_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaCambioTipoPropiedad 
{
get
{
return _fechaCambioTipoPropiedad;
}
set 
{
if ( _fechaCambioTipoPropiedad != value) 
{
_fechaCambioTipoPropiedad = value ;
OnPropertyChanged("FechaCambioTipoPropiedad");
}
}
}

public virtual System.String UsuarioCambio 
{
get
{
return _usuarioCambio;
}
set 
{
if ( _usuarioCambio != value) 
{
_usuarioCambio = value ;
OnPropertyChanged("UsuarioCambio");
}
}
}

/// <summary>
/// Collection of ArchivosXequipo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "e6312518-561c-4f09-9fa0-636fc38279a7" , CollectionOfType = typeof(ArchivosXequipo)) ]
public virtual IList<ArchivosXequipo> ArchivosXequipos 
{
get
{
 if (_archivosXequipos == null) _archivosXequipos = new List<ArchivosXequipo>();

return _archivosXequipos;
}
set 
{
if ( _archivosXequipos != value) 
{
_archivosXequipos = value ;
}
}
}

/// <summary>
/// Collection of ContratosxEquipo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "b8e3e2ba-5bb2-4bb3-8f2e-dc147c3ba752" , CollectionOfType = typeof(ContratosxEquipo)) ]
public virtual IList<ContratosxEquipo> ContratosxEquipos 
{
get
{
 if (_contratosxEquipos == null) _contratosxEquipos = new List<ContratosxEquipo>();

return _contratosxEquipos;
}
set 
{
if ( _contratosxEquipos != value) 
{
_contratosxEquipos = value ;
}
}
}

/// <summary>
/// Collection of DetalleProgramacionViaje.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "130b52c3-b97a-494d-bfce-2eed6f6e18ac" , CollectionOfType = typeof(DetalleProgramacionViaje)) ]
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
/// Collection of EntradaSalidaEquipo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "da3e2f05-61db-4978-923f-a337ca4b48ab" , CollectionOfType = typeof(EntradaSalidaEquipo)) ]
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
/// Collection of EquipoAuxiliar.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "592b51a2-84ae-4618-adcb-54e84648a959" , CollectionOfType = typeof(EquipoAuxiliar)) ]
public virtual IList<EquipoAuxiliar> EquipoAuxiliars 
{
get
{
 if (_equipoAuxiliars == null) _equipoAuxiliars = new List<EquipoAuxiliar>();

return _equipoAuxiliars;
}
set 
{
if ( _equipoAuxiliars != value) 
{
_equipoAuxiliars = value ;
}
}
}

/// <summary>
/// Collection of EquipoAuxiliar.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "9754ca2a-afff-4db7-a52a-8e81fe760507" , CollectionOfType = typeof(EquipoAuxiliar)) ]
public virtual IList<EquipoAuxiliar> EquipoAuxiliars1 
{
get
{
 if (_equipoAuxiliars1 == null) _equipoAuxiliars1 = new List<EquipoAuxiliar>();

return _equipoAuxiliars1;
}
set 
{
if ( _equipoAuxiliars1 != value) 
{
_equipoAuxiliars1 = value ;
}
}
}

/// <summary>
/// Collection of LlamadaSoporte.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "66d1013b-8384-436e-a117-900ce5512e95" , CollectionOfType = typeof(LlamadaSoporte)) ]
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
/// Collection of MantenimientosxContrato.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "22fffb2d-9d62-42d2-9572-a7e0b8f3476c" , CollectionOfType = typeof(MantenimientosxContrato)) ]
public virtual IList<MantenimientosxContrato> MantenimientosxContratos 
{
get
{
 if (_mantenimientosxContratos == null) _mantenimientosxContratos = new List<MantenimientosxContrato>();

return _mantenimientosxContratos;
}
set 
{
if ( _mantenimientosxContratos != value) 
{
_mantenimientosxContratos = value ;
}
}
}

/// <summary>
/// Collection of OrdenServicio.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "48a29f7e-8344-4665-b1cd-7fe542d9bd27" , CollectionOfType = typeof(OrdenServicio)) ]
public virtual IList<OrdenServicio> OrdenServicios 
{
get
{
 if (_ordenServicios == null) _ordenServicios = new List<OrdenServicio>();

return _ordenServicios;
}
set 
{
if ( _ordenServicios != value) 
{
_ordenServicios = value ;
}
}
}

/// <summary>
/// Collection of Recoleccion.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "c9c735f3-8c21-4205-a513-0a2cfe15a899" , CollectionOfType = typeof(Recoleccion)) ]
public virtual IList<Recoleccion> Recoleccions 
{
get
{
 if (_recoleccions == null) _recoleccions = new List<Recoleccion>();

return _recoleccions;
}
set 
{
if ( _recoleccions != value) 
{
_recoleccions = value ;
}
}
}

/// <summary>
/// Collection of Seguimiento.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "d74b6498-c554-4c54-bbb4-c2530de2d7b1" , CollectionOfType = typeof(Seguimiento)) ]
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
/// Collection of SolicitudServicio.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "3ea033eb-ea38-4723-b23a-5a9627ee4e0d" , CollectionOfType = typeof(SolicitudServicio)) ]
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
/// Generated from Relation FK_equipos_estadoLocalEquipos
/// </summary>
[GenWiseAttribute(RelationID = "743e5853-5911-4adf-beb9-f28d629fe8fd") ]
public virtual EstadoLocalEquipo EstadoLocalEquipo 
{
get
{
if ( _estadoLocalEquipo == null ) 
{
if ( String.IsNullOrEmpty(_codEstadoLocal) || _codEstadoLocal.Equals(string.Empty) ) 
{
if ( _estadoLocalEquipo != null && ( _estadoLocalEquipo.CodEstadoLocal.Equals(null) ) )
{
  _estadoLocalEquipo = null;
}
}
else
{
_estadoLocalEquipo = (new EstadoLocalEquipoFactory()).Get(_codEstadoLocal);
}
}

return _estadoLocalEquipo;
}
set 
{
if ( _estadoLocalEquipo != value) 
{
if ( value==null ) _codEstadoLocal = null; else _codEstadoLocal = (System.String)value.CodEstadoLocal; 
_estadoLocalEquipo = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_equipos_ModalidadEquipo
/// </summary>
[GenWiseAttribute(RelationID = "7cb2b56c-9942-47d1-acc3-e78e06207d33") ]
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
/// Generated from Relation FK_equipos_Modelos
/// </summary>
[GenWiseAttribute(RelationID = "88450922-80a7-490e-aabd-e64cd3ac89a5") ]
public virtual Modelo Modelo 
{
get
{
if ( _modelo == null || _modelo == null ) 
{
if ( String.IsNullOrEmpty(_codFabricante) || _codFabricante.Equals(string.Empty) || String.IsNullOrEmpty(_codModelo) || _codModelo.Equals(string.Empty) ) 
{
if ( _modelo != null && ( _modelo.CodFabricante.Equals(string.Empty) || _modelo.CodModelo.Equals(string.Empty) ) )
{
  _modelo = null;
}
}
else
{
  _modelo = (new ModeloFactory()).Fetch(_codFabricante,_codModelo);
}
}

return _modelo;
}
set 
{
if ( _modelo != value) 
{
if ( value==null ) _codFabricante = string.Empty; else _codFabricante = (System.String)value.CodFabricante; 
if ( value==null ) _codModelo = string.Empty; else _codModelo = (System.String)value.CodModelo; 
_modelo = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_equipos_sucursalCliente
/// </summary>
[GenWiseAttribute(RelationID = "dbbc3aeb-9b73-4252-88fd-6431aa79c4f0") ]
public virtual SucursalCliente SucursalCliente 
{
get
{
if ( _sucursalCliente == null || _sucursalCliente == null ) 
{
if ( String.IsNullOrEmpty(_nitClienteUbica) || _nitClienteUbica.Equals(string.Empty) || String.IsNullOrEmpty(_codSucursalUbica) || _codSucursalUbica.Equals(string.Empty) ) 
{
if ( _sucursalCliente != null && ( _sucursalCliente.NitCliente.Equals(null) || _sucursalCliente.CodSucursal.Equals(null) ) )
{
  _sucursalCliente = null;
}
}
else
{
  _sucursalCliente = (new SucursalClienteFactory()).Fetch(_nitClienteUbica,_codSucursalUbica);
}
}

return _sucursalCliente;
}
set 
{
if ( _sucursalCliente != value) 
{
if ( value==null ) _nitClienteUbica = null; else _nitClienteUbica = (System.String)value.NitCliente; 
if ( value==null ) _codSucursalUbica = null; else _codSucursalUbica = (System.String)value.CodSucursal; 
_sucursalCliente = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_equipos_tipoPropiedad
/// </summary>
[GenWiseAttribute(RelationID = "00534c94-97ac-4618-bc6d-25c616dddd42") ]
public virtual TipoPropiedad TipoPropiedad 
{
get
{
if ( _tipoPropiedad == null ) 
{
if ( !_codTipoPropiedad.HasValue || _codTipoPropiedad.Value.Equals(System.Int32.MinValue) ) 
{
if ( _tipoPropiedad != null && ( _tipoPropiedad.CodTipoPropiedad.Equals(null) ) )
{
  _tipoPropiedad = null;
}
}
else
{
_tipoPropiedad = (new TipoPropiedadFactory()).Get(_codTipoPropiedad.Value);
}
}

return _tipoPropiedad;
}
set 
{
if ( _tipoPropiedad != value) 
{
if ( value==null ) _codTipoPropiedad = null; else _codTipoPropiedad = (System.Int32)value.CodTipoPropiedad; 
_tipoPropiedad = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_equipos_TipoServicio
/// </summary>
[GenWiseAttribute(RelationID = "046ed500-cfc8-4001-887d-c7dd6296502a") ]
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
/// Create a new Equipo object. 
/// </summary>
public  Equipo()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  Equipo(System.String pSerial)
{
_serial = pSerial ;

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
// Call Validator IsRequired for Column : codFabricante(Type:Required Field Validator)
_error = this.ValidatecodFabricanteIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : codModelo(Type:Required Field Validator)
_error = this.ValidatecodModeloIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : serial(Type:Required Field Validator)
_error = this.ValidateserialIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(Serial) ) 
{
   _errors.Add( new Error( "The PK Column (serial) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codFabricante
/// </remarks>
public virtual Error ValidatecodFabricanteIsRequired()
{
if ( String.IsNullOrEmpty(CodFabricante) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codFabricante is required and therefore must have a value." ;
 return _error;
}
 return null;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codModelo
/// </remarks>
public virtual Error ValidatecodModeloIsRequired()
{
if ( String.IsNullOrEmpty(CodModelo) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codModelo is required and therefore must have a value." ;
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

