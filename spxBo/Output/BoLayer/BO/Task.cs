using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class Task : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codTarea;
private System.String _loginAutor;
private System.String _codCategoria;
private System.String _loginPropietario;
private System.DateTime? _fechaCreacion;
private System.DateTime? _fechaInicio;
private System.DateTime? _fechaVencimiento;
private System.String _codEstatus;
private System.String _codPrioridad;
private System.Int32? _pcCompletado;
private System.String _asunto;
private System.String _cuerpo;
private System.Boolean? _esCompletada;
private System.Boolean? _esAprobada;
private System.Boolean? _conservarEnPropias;
private System.Boolean? _notificarFin;
private System.Boolean? _esPrivada;
private System.Int32? _codTareaCompartida;
private System.Boolean? _aceptada;
private System.String _asociadoA;
private System.DateTime? _fechaFinalizacion;
private System.DateTime? _fechaAprobacion;
private System.Boolean? _visibleAutor;
private System.Boolean? _visiblePropietario;
private System.String _parametrosInternos;
private IList<TaskAdjunto> _taskAdjuntos;
private IList<TaskPatronRecurrencium> _taskPatronRecurrencia;
private IList<TaskReminder> _taskReminders;
private Prioridad _prioridad;
private TaskCategorium _taskCategorium;
private TaskEstatu _taskEstatu;
private Usuario0 _usuario0;
private Usuario0 _usuario01;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodTarea 
{
get
{
return _codTarea;
}
set 
{
if ( _codTarea != value) 
{
_codTarea = value ;
OnPropertyChanged("CodTarea");
}
}
}

public virtual System.String LoginAutor 
{
get
{
if ( Usuario0 != null ) 
{
_loginAutor = (System.String)Usuario0.Login;
}

return _loginAutor;
}
set 
{
if ( _loginAutor != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_usuario0 = null;

_loginAutor = value ;
OnPropertyChanged("LoginAutor");
}
}
}

public virtual System.String CodCategoria 
{
get
{
if ( TaskCategorium != null ) 
{
_codCategoria = (System.String)TaskCategorium.CodCategoria;
}

return _codCategoria;
}
set 
{
if ( _codCategoria != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_taskCategorium = null;

_codCategoria = value ;
OnPropertyChanged("CodCategoria");
}
}
}

public virtual System.String LoginPropietario 
{
get
{
if ( Usuario01 != null ) 
{
_loginPropietario = (System.String)Usuario01.Login;
}

return _loginPropietario;
}
set 
{
if ( _loginPropietario != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_usuario01 = null;

_loginPropietario = value ;
OnPropertyChanged("LoginPropietario");
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
public virtual System.String FechaInicio_Date 
{
get
{
if (  !FechaInicio.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaInicio.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaInicio.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaInicio_Time)) {

FechaInicio = null;
}
 else
{
 FechaInicio = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaInicio.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaInicio_Time)) 
{
 FechaInicio = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaInicio = Convert.ToDateTime( " " + value + " " + FechaInicio.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaInicio_Time 
{
get
{
if (  !FechaInicio.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaInicio.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaInicio.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaInicio_Date)) 
{
FechaInicio = null;
}
 else
{
 FechaInicio = Convert.ToDateTime( " " + FechaInicio.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaInicio_Date)) 
{
 FechaInicio = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaInicio = Convert.ToDateTime( " " + FechaInicio_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaInicio 
{
get
{
return _fechaInicio;
}
set 
{
if ( _fechaInicio != value) 
{
_fechaInicio = value ;
OnPropertyChanged("FechaInicio");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaVencimiento_Date 
{
get
{
if (  !FechaVencimiento.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaVencimiento.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaVencimiento.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaVencimiento_Time)) {

FechaVencimiento = null;
}
 else
{
 FechaVencimiento = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaVencimiento.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaVencimiento_Time)) 
{
 FechaVencimiento = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaVencimiento = Convert.ToDateTime( " " + value + " " + FechaVencimiento.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaVencimiento_Time 
{
get
{
if (  !FechaVencimiento.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaVencimiento.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaVencimiento.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaVencimiento_Date)) 
{
FechaVencimiento = null;
}
 else
{
 FechaVencimiento = Convert.ToDateTime( " " + FechaVencimiento.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaVencimiento_Date)) 
{
 FechaVencimiento = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaVencimiento = Convert.ToDateTime( " " + FechaVencimiento_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaVencimiento 
{
get
{
return _fechaVencimiento;
}
set 
{
if ( _fechaVencimiento != value) 
{
_fechaVencimiento = value ;
OnPropertyChanged("FechaVencimiento");
}
}
}

public virtual System.String CodEstatus 
{
get
{
if ( TaskEstatu != null ) 
{
_codEstatus = (System.String)TaskEstatu.CodEstatus;
}

return _codEstatus;
}
set 
{
if ( _codEstatus != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_taskEstatu = null;

_codEstatus = value ;
OnPropertyChanged("CodEstatus");
}
}
}

public virtual System.String CodPrioridad 
{
get
{
if ( Prioridad != null ) 
{
_codPrioridad = (System.String)Prioridad.CodPrioridad;
}

return _codPrioridad;
}
set 
{
if ( _codPrioridad != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_prioridad = null;

_codPrioridad = value ;
OnPropertyChanged("CodPrioridad");
}
}
}

public virtual System.Int32? PcCompletado 
{
get
{
return _pcCompletado;
}
set 
{
if ( _pcCompletado != value) 
{
_pcCompletado = value ;
OnPropertyChanged("PcCompletado");
}
}
}

public virtual System.String Asunto 
{
get
{
return _asunto;
}
set 
{
if ( _asunto != value) 
{
_asunto = value ;
OnPropertyChanged("Asunto");
}
}
}

public virtual System.String Cuerpo 
{
get
{
return _cuerpo;
}
set 
{
if ( _cuerpo != value) 
{
_cuerpo = value ;
OnPropertyChanged("Cuerpo");
}
}
}

public virtual System.Boolean? EsCompletada 
{
get
{
return _esCompletada;
}
set 
{
if ( _esCompletada != value) 
{
_esCompletada = value ;
OnPropertyChanged("EsCompletada");
}
}
}

public virtual System.Boolean? EsAprobada 
{
get
{
return _esAprobada;
}
set 
{
if ( _esAprobada != value) 
{
_esAprobada = value ;
OnPropertyChanged("EsAprobada");
}
}
}

public virtual System.Boolean? ConservarEnPropias 
{
get
{
return _conservarEnPropias;
}
set 
{
if ( _conservarEnPropias != value) 
{
_conservarEnPropias = value ;
OnPropertyChanged("ConservarEnPropias");
}
}
}

public virtual System.Boolean? NotificarFin 
{
get
{
return _notificarFin;
}
set 
{
if ( _notificarFin != value) 
{
_notificarFin = value ;
OnPropertyChanged("NotificarFin");
}
}
}

public virtual System.Boolean? EsPrivada 
{
get
{
return _esPrivada;
}
set 
{
if ( _esPrivada != value) 
{
_esPrivada = value ;
OnPropertyChanged("EsPrivada");
}
}
}

public virtual System.Int32? CodTareaCompartida 
{
get
{
return _codTareaCompartida;
}
set 
{
if ( _codTareaCompartida != value) 
{
_codTareaCompartida = value ;
OnPropertyChanged("CodTareaCompartida");
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

public virtual System.String AsociadoA 
{
get
{
return _asociadoA;
}
set 
{
if ( _asociadoA != value) 
{
_asociadoA = value ;
OnPropertyChanged("AsociadoA");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaFinalizacion_Date 
{
get
{
if (  !FechaFinalizacion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaFinalizacion.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaFinalizacion.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaFinalizacion_Time)) {

FechaFinalizacion = null;
}
 else
{
 FechaFinalizacion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaFinalizacion.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaFinalizacion_Time)) 
{
 FechaFinalizacion = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaFinalizacion = Convert.ToDateTime( " " + value + " " + FechaFinalizacion.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaFinalizacion_Time 
{
get
{
if (  !FechaFinalizacion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaFinalizacion.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaFinalizacion.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaFinalizacion_Date)) 
{
FechaFinalizacion = null;
}
 else
{
 FechaFinalizacion = Convert.ToDateTime( " " + FechaFinalizacion.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaFinalizacion_Date)) 
{
 FechaFinalizacion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaFinalizacion = Convert.ToDateTime( " " + FechaFinalizacion_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaFinalizacion 
{
get
{
return _fechaFinalizacion;
}
set 
{
if ( _fechaFinalizacion != value) 
{
_fechaFinalizacion = value ;
OnPropertyChanged("FechaFinalizacion");
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

public virtual System.Boolean? VisibleAutor 
{
get
{
return _visibleAutor;
}
set 
{
if ( _visibleAutor != value) 
{
_visibleAutor = value ;
OnPropertyChanged("VisibleAutor");
}
}
}

public virtual System.Boolean? VisiblePropietario 
{
get
{
return _visiblePropietario;
}
set 
{
if ( _visiblePropietario != value) 
{
_visiblePropietario = value ;
OnPropertyChanged("VisiblePropietario");
}
}
}

public virtual System.String ParametrosInternos 
{
get
{
return _parametrosInternos;
}
set 
{
if ( _parametrosInternos != value) 
{
_parametrosInternos = value ;
OnPropertyChanged("ParametrosInternos");
}
}
}

/// <summary>
/// Collection of TaskAdjunto.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "37dfa7a2-433b-4a49-bd9a-da2cc1f98828" , CollectionOfType = typeof(TaskAdjunto)) ]
public virtual IList<TaskAdjunto> TaskAdjuntos 
{
get
{
 if (_taskAdjuntos == null) _taskAdjuntos = new List<TaskAdjunto>();

return _taskAdjuntos;
}
set 
{
if ( _taskAdjuntos != value) 
{
_taskAdjuntos = value ;
}
}
}

/// <summary>
/// Collection of TaskPatronRecurrencium.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "035902d4-5e41-4bbc-9e70-93a954536dc3" , CollectionOfType = typeof(TaskPatronRecurrencium)) ]
public virtual IList<TaskPatronRecurrencium> TaskPatronRecurrencia 
{
get
{
 if (_taskPatronRecurrencia == null) _taskPatronRecurrencia = new List<TaskPatronRecurrencium>();

return _taskPatronRecurrencia;
}
set 
{
if ( _taskPatronRecurrencia != value) 
{
_taskPatronRecurrencia = value ;
}
}
}

/// <summary>
/// Collection of TaskReminder.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "b8d6832a-e081-462d-a646-d1af7ea72d15" , CollectionOfType = typeof(TaskReminder)) ]
public virtual IList<TaskReminder> TaskReminders 
{
get
{
 if (_taskReminders == null) _taskReminders = new List<TaskReminder>();

return _taskReminders;
}
set 
{
if ( _taskReminders != value) 
{
_taskReminders = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_task_prioridad
/// </summary>
[GenWiseAttribute(RelationID = "1725bcf1-591a-45c3-985e-ae4cfbea5fc3") ]
public virtual Prioridad Prioridad 
{
get
{
if ( _prioridad == null ) 
{
if ( String.IsNullOrEmpty(_codPrioridad) || _codPrioridad.Equals(string.Empty) ) 
{
if ( _prioridad != null && ( _prioridad.CodPrioridad.Equals(null) ) )
{
  _prioridad = null;
}
}
else
{
_prioridad = (new PrioridadFactory()).Get(_codPrioridad);
}
}

return _prioridad;
}
set 
{
if ( _prioridad != value) 
{
if ( value==null ) _codPrioridad = null; else _codPrioridad = (System.String)value.CodPrioridad; 
_prioridad = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_task_taskCategoria
/// </summary>
[GenWiseAttribute(RelationID = "7d40250e-b764-4da5-9d51-8b21102674fa") ]
public virtual TaskCategorium TaskCategorium 
{
get
{
if ( _taskCategorium == null ) 
{
if ( String.IsNullOrEmpty(_codCategoria) || _codCategoria.Equals(string.Empty) ) 
{
if ( _taskCategorium != null && ( _taskCategorium.CodCategoria.Equals(null) ) )
{
  _taskCategorium = null;
}
}
else
{
_taskCategorium = (new TaskCategoriumFactory()).Get(_codCategoria);
}
}

return _taskCategorium;
}
set 
{
if ( _taskCategorium != value) 
{
if ( value==null ) _codCategoria = null; else _codCategoria = (System.String)value.CodCategoria; 
_taskCategorium = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_task_taskEstatus
/// </summary>
[GenWiseAttribute(RelationID = "85f328ef-07e3-4f88-afc6-81c195aac313") ]
public virtual TaskEstatu TaskEstatu 
{
get
{
if ( _taskEstatu == null ) 
{
if ( String.IsNullOrEmpty(_codEstatus) || _codEstatus.Equals(string.Empty) ) 
{
if ( _taskEstatu != null && ( _taskEstatu.CodEstatus.Equals(null) ) )
{
  _taskEstatu = null;
}
}
else
{
_taskEstatu = (new TaskEstatuFactory()).Get(_codEstatus);
}
}

return _taskEstatu;
}
set 
{
if ( _taskEstatu != value) 
{
if ( value==null ) _codEstatus = null; else _codEstatus = (System.String)value.CodEstatus; 
_taskEstatu = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_task_usuarios
/// </summary>
[GenWiseAttribute(RelationID = "b44649d6-a572-496d-ade1-37663c9d7dc7") ]
public virtual Usuario0 Usuario0 
{
get
{
if ( _usuario0 == null ) 
{
if ( String.IsNullOrEmpty(_loginAutor) || _loginAutor.Equals(string.Empty) ) 
{
if ( _usuario0 != null && ( _usuario0.Login.Equals(null) ) )
{
  _usuario0 = null;
}
}
else
{
_usuario0 = (new Usuario0Factory()).Get(_loginAutor);
}
}

return _usuario0;
}
set 
{
if ( _usuario0 != value) 
{
if ( value==null ) _loginAutor = null; else _loginAutor = (System.String)value.Login; 
_usuario0 = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_task_usuarios1
/// </summary>
[GenWiseAttribute(RelationID = "ebcd4450-9574-49f8-bd09-bdeec1017105") ]
public virtual Usuario0 Usuario01 
{
get
{
if ( _usuario01 == null ) 
{
if ( String.IsNullOrEmpty(_loginPropietario) || _loginPropietario.Equals(string.Empty) ) 
{
if ( _usuario01 != null && ( _usuario01.Login.Equals(null) ) )
{
  _usuario01 = null;
}
}
else
{
_usuario01 = (new Usuario0Factory()).Get(_loginPropietario);
}
}

return _usuario01;
}
set 
{
if ( _usuario01 != value) 
{
if ( value==null ) _loginPropietario = null; else _loginPropietario = (System.String)value.Login; 
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
/// Create a new Task object. 
/// </summary>
public  Task()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  Task(System.Int32 pCodTarea)
{
_codTarea = pCodTarea ;

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
if (  CodTarea.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codTarea) can not be null!. " ) );
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

