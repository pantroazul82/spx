using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class Seguimiento : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _idSeguimiento;
private System.String _creadoPor;
private System.Boolean? _realizado;
private System.String _realizadoPor;
private System.DateTime? _fechaSugerida;
private System.DateTime? _fechaRealizado;
private System.String _obsIniciales;
private System.String _obsFinales;
private System.Int32? _idLlamadaSoporte;
private System.String _nitCliente;
private System.String _codContacto;
private System.String _serial;
private ContactosCliente _contactosCliente;
private Equipo _equipo;
private LlamadaSoporte _llamadaSoporte;
private Usuario0 _usuario0;
private Usuario0 _usuario01;

#endregion


#region --- Class Properties ---

public virtual System.Int32 IdSeguimiento 
{
get
{
return _idSeguimiento;
}
set 
{
if ( _idSeguimiento != value) 
{
_idSeguimiento = value ;
OnPropertyChanged("IdSeguimiento");
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

public virtual System.Boolean? Realizado 
{
get
{
return _realizado;
}
set 
{
if ( _realizado != value) 
{
_realizado = value ;
OnPropertyChanged("Realizado");
}
}
}

public virtual System.String RealizadoPor 
{
get
{
if ( Usuario01 != null ) 
{
_realizadoPor = (System.String)Usuario01.Login;
}

return _realizadoPor;
}
set 
{
if ( _realizadoPor != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_usuario01 = null;

_realizadoPor = value ;
OnPropertyChanged("RealizadoPor");
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
public virtual System.String FechaRealizado_Date 
{
get
{
if (  !FechaRealizado.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaRealizado.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaRealizado.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaRealizado_Time)) {

FechaRealizado = null;
}
 else
{
 FechaRealizado = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaRealizado.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaRealizado_Time)) 
{
 FechaRealizado = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaRealizado = Convert.ToDateTime( " " + value + " " + FechaRealizado.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaRealizado_Time 
{
get
{
if (  !FechaRealizado.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaRealizado.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaRealizado.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaRealizado_Date)) 
{
FechaRealizado = null;
}
 else
{
 FechaRealizado = Convert.ToDateTime( " " + FechaRealizado.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaRealizado_Date)) 
{
 FechaRealizado = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaRealizado = Convert.ToDateTime( " " + FechaRealizado_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaRealizado 
{
get
{
return _fechaRealizado;
}
set 
{
if ( _fechaRealizado != value) 
{
_fechaRealizado = value ;
OnPropertyChanged("FechaRealizado");
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

public virtual System.Int32? IdLlamadaSoporte 
{
get
{
if ( LlamadaSoporte != null ) 
{
_idLlamadaSoporte = (System.Int32)LlamadaSoporte.IdLlamadaSoporte;
}

return _idLlamadaSoporte;
}
set 
{
if ( _idLlamadaSoporte != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_llamadaSoporte = null;

_idLlamadaSoporte = value ;
OnPropertyChanged("IdLlamadaSoporte");
}
}
}

public virtual System.String NitCliente 
{
get
{
if ( ContactosCliente != null ) 
{
_nitCliente = (System.String)ContactosCliente.NitCliente;
}

return _nitCliente;
}
set 
{
if ( _nitCliente != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_contactosCliente = null;

_nitCliente = value ;
OnPropertyChanged("NitCliente");
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
/// Generated from Relation FK_seguimiento_contactosClientes
/// </summary>
[GenWiseAttribute(RelationID = "640137dd-3be0-4ba7-af90-091dc55f8428") ]
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
/// Generated from Relation FK_seguimiento_equipos
/// </summary>
[GenWiseAttribute(RelationID = "d74b6498-c554-4c54-bbb4-c2530de2d7b1") ]
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
/// Generated from Relation FK_seguimiento_LlamadaSoporte
/// </summary>
[GenWiseAttribute(RelationID = "f62b7f23-c0c0-4d19-9a74-1df6a795213e") ]
public virtual LlamadaSoporte LlamadaSoporte 
{
get
{
if ( _llamadaSoporte == null ) 
{
if ( !_idLlamadaSoporte.HasValue || _idLlamadaSoporte.Value.Equals(System.Int32.MinValue) ) 
{
if ( _llamadaSoporte != null && ( _llamadaSoporte.IdLlamadaSoporte.Equals(null) ) )
{
  _llamadaSoporte = null;
}
}
else
{
_llamadaSoporte = (new LlamadaSoporteFactory()).Get(_idLlamadaSoporte.Value);
}
}

return _llamadaSoporte;
}
set 
{
if ( _llamadaSoporte != value) 
{
if ( value==null ) _idLlamadaSoporte = null; else _idLlamadaSoporte = (System.Int32)value.IdLlamadaSoporte; 
_llamadaSoporte = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_seguimiento_usuarios
/// </summary>
[GenWiseAttribute(RelationID = "130f0fea-45cc-49ce-af02-c2c8900ca0f4") ]
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
/// Generated from Relation FK_seguimiento_usuarios1
/// </summary>
[GenWiseAttribute(RelationID = "6a18160d-6d2c-46ce-adf2-698df0158833") ]
public virtual Usuario0 Usuario01 
{
get
{
if ( _usuario01 == null ) 
{
if ( String.IsNullOrEmpty(_realizadoPor) || _realizadoPor.Equals(string.Empty) ) 
{
if ( _usuario01 != null && ( _usuario01.Login.Equals(null) ) )
{
  _usuario01 = null;
}
}
else
{
_usuario01 = (new Usuario0Factory()).Get(_realizadoPor);
}
}

return _usuario01;
}
set 
{
if ( _usuario01 != value) 
{
if ( value==null ) _realizadoPor = null; else _realizadoPor = (System.String)value.Login; 
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
/// Create a new Seguimiento object. 
/// </summary>
public  Seguimiento()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  Seguimiento(System.Int32 pIdSeguimiento)
{
_idSeguimiento = pIdSeguimiento ;

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
if (  IdSeguimiento.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (idSeguimiento) can not be null!. " ) );
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

