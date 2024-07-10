using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class DetalleProgramacionViaje : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codProgramacionViajes;
private System.Int32 _codDetalleProgramacionViajes;
private System.Int32? _codOrdenServicio;
private System.Boolean? _confirmado;
private System.String _serial;
private System.DateTime? _fechaInicio;
private System.DateTime? _fechaFin;
private System.String _codTipoServicio;
private System.Int32? _codPrioridadOS;
private System.String _observaciones;
private Equipo _equipo;
private OrdenServicio _ordenServicio;
private PrioridadesOrdenServicio _prioridadesOrdenServicio;
private ProgramacionViaje _programacionViaje;
private TipoServicio _tipoServicio;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodProgramacionViajes 
{
get
{
return _codProgramacionViajes;
}
set 
{
if ( _codProgramacionViajes != value) 
{
_codProgramacionViajes = value ;
OnPropertyChanged("CodProgramacionViajes");
}
}
}

public virtual System.Int32 CodDetalleProgramacionViajes 
{
get
{
return _codDetalleProgramacionViajes;
}
set 
{
if ( _codDetalleProgramacionViajes != value) 
{
_codDetalleProgramacionViajes = value ;
OnPropertyChanged("CodDetalleProgramacionViajes");
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

public virtual System.Boolean? Confirmado 
{
get
{
return _confirmado;
}
set 
{
if ( _confirmado != value) 
{
_confirmado = value ;
OnPropertyChanged("Confirmado");
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
public virtual System.String FechaFin_Date 
{
get
{
if (  !FechaFin.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaFin.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaFin.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaFin_Time)) {

FechaFin = null;
}
 else
{
 FechaFin = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaFin.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaFin_Time)) 
{
 FechaFin = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaFin = Convert.ToDateTime( " " + value + " " + FechaFin.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaFin_Time 
{
get
{
if (  !FechaFin.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaFin.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaFin.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaFin_Date)) 
{
FechaFin = null;
}
 else
{
 FechaFin = Convert.ToDateTime( " " + FechaFin.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaFin_Date)) 
{
 FechaFin = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaFin = Convert.ToDateTime( " " + FechaFin_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaFin 
{
get
{
return _fechaFin;
}
set 
{
if ( _fechaFin != value) 
{
_fechaFin = value ;
OnPropertyChanged("FechaFin");
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

public virtual System.Int32? CodPrioridadOS 
{
get
{
if ( PrioridadesOrdenServicio != null ) 
{
_codPrioridadOS = (System.Int32)PrioridadesOrdenServicio.CodPrioridadOS;
}

return _codPrioridadOS;
}
set 
{
if ( _codPrioridadOS != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_prioridadesOrdenServicio = null;

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

/// <summary>
/// Generated from Relation FK_detalleProgramacionViajes_equipos
/// </summary>
[GenWiseAttribute(RelationID = "130b52c3-b97a-494d-bfce-2eed6f6e18ac") ]
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
/// Generated from Relation FK_detalleProgramacionViajes_ordenServicio
/// </summary>
[GenWiseAttribute(RelationID = "77c5da6c-f88a-4367-b43c-20d742a1e119") ]
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
/// Generated from Relation FK_detalleProgramacionViajes_prioridadesOrdenServicio
/// </summary>
[GenWiseAttribute(RelationID = "4aed6798-5232-4c69-9509-cce104f80eac") ]
public virtual PrioridadesOrdenServicio PrioridadesOrdenServicio 
{
get
{
if ( _prioridadesOrdenServicio == null ) 
{
if ( !_codPrioridadOS.HasValue || _codPrioridadOS.Value.Equals(System.Int32.MinValue) ) 
{
if ( _prioridadesOrdenServicio != null && ( _prioridadesOrdenServicio.CodPrioridadOS.Equals(null) ) )
{
  _prioridadesOrdenServicio = null;
}
}
else
{
_prioridadesOrdenServicio = (new PrioridadesOrdenServicioFactory()).Get(_codPrioridadOS.Value);
}
}

return _prioridadesOrdenServicio;
}
set 
{
if ( _prioridadesOrdenServicio != value) 
{
if ( value==null ) _codPrioridadOS = null; else _codPrioridadOS = (System.Int32)value.CodPrioridadOS; 
_prioridadesOrdenServicio = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_detalleProgramacionViajes_programacionViajes
/// </summary>
[GenWiseAttribute(RelationID = "47b7ba38-2505-4909-a387-2ce435597bc7") ]
public virtual ProgramacionViaje ProgramacionViaje 
{
get
{
if ( _programacionViaje == null ) 
{
if (  _codProgramacionViajes.Equals(0)  || _codProgramacionViajes.Equals(System.Int32.MinValue) ) 
{
if ( _programacionViaje != null && ( _programacionViaje.CodProgramacionViajes.Equals(System.Int32.MinValue) ) )
{
  _programacionViaje = null;
}
}
else
{
_programacionViaje = (new ProgramacionViajeFactory()).Get(_codProgramacionViajes);
}
}

return _programacionViaje;
}
set 
{
if ( _programacionViaje != value) 
{
if ( value==null ) _codProgramacionViajes = System.Int32.MinValue; else _codProgramacionViajes = (System.Int32)value.CodProgramacionViajes; 
_programacionViaje = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_detalleProgramacionViajes_TipoServicio
/// </summary>
[GenWiseAttribute(RelationID = "6942c4bf-4f12-4c75-8cb8-41981fe14480") ]
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
/// Property that simulates a unique PK by concatenating all the Pk properties
/// </summary>
public virtual System.String VirtualPk 
{
get
{
string _retValue = string.Empty;

_retValue += CodProgramacionViajes.ToString();

_retValue += "^";
_retValue += CodDetalleProgramacionViajes.ToString();

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
/// Create a new DetalleProgramacionViaje object. 
/// </summary>
public  DetalleProgramacionViaje()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  DetalleProgramacionViaje(System.Int32 pCodProgramacionViajes , System.Int32 pCodDetalleProgramacionViajes)
{
_codProgramacionViajes = pCodProgramacionViajes ;
_codDetalleProgramacionViajes = pCodDetalleProgramacionViajes ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
_hash += CodProgramacionViajes.ToString();
_hash += CodDetalleProgramacionViajes.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
DetalleProgramacionViaje _newDetalleProgramacionViaje = (pObject as DetalleProgramacionViaje); 
if (_newDetalleProgramacionViaje == null ) return false; 
if (_newDetalleProgramacionViaje.GetHashCode() == this.GetHashCode() ) return true; 
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
if (  CodProgramacionViajes.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codProgramacionViajes) can not be null!. " ) );
}
if (  CodDetalleProgramacionViajes.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codDetalleProgramacionViajes) can not be null!. " ) );
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

