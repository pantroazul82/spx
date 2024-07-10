using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class LogCambioUbicacione : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codLog;
private System.String _nitClienteOrigen;
private System.String _codSucursalOrigen;
private System.String _nitClienteDestino;
private System.String _codSucursalDestino;
private System.DateTime? _fechaCambio;
private System.String _usuarioCambio;
private System.String _serial;
private System.String _razon;
private System.DateTime? _fechaEnvio;
private SucursalCliente _sucursalCliente;
private SucursalCliente _sucursalCliente1;
private Usuario0 _usuario0;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodLog 
{
get
{
return _codLog;
}
set 
{
if ( _codLog != value) 
{
_codLog = value ;
OnPropertyChanged("CodLog");
}
}
}

public virtual System.String NitClienteOrigen 
{
get
{
return _nitClienteOrigen;
}
set 
{
if ( _nitClienteOrigen != value) 
{
_nitClienteOrigen = value ;
OnPropertyChanged("NitClienteOrigen");
}
}
}

public virtual System.String CodSucursalOrigen 
{
get
{
return _codSucursalOrigen;
}
set 
{
if ( _codSucursalOrigen != value) 
{
_codSucursalOrigen = value ;
OnPropertyChanged("CodSucursalOrigen");
}
}
}

public virtual System.String NitClienteDestino 
{
get
{
if ( SucursalCliente1 != null ) 
{
_nitClienteDestino = (System.String)SucursalCliente1.NitCliente;
}

return _nitClienteDestino;
}
set 
{
if ( _nitClienteDestino != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_sucursalCliente = null;

// Simplified Parent Access Property : reset object reference if simple property changes it's value
_sucursalCliente1 = null;

_nitClienteDestino = value ;
OnPropertyChanged("NitClienteDestino");
}
}
}

public virtual System.String CodSucursalDestino 
{
get
{
if ( SucursalCliente1 != null ) 
{
_codSucursalDestino = (System.String)SucursalCliente1.CodSucursal;
}

return _codSucursalDestino;
}
set 
{
if ( _codSucursalDestino != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_sucursalCliente = null;

// Simplified Parent Access Property : reset object reference if simple property changes it's value
_sucursalCliente1 = null;

_codSucursalDestino = value ;
OnPropertyChanged("CodSucursalDestino");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaCambio_Date 
{
get
{
if (  !FechaCambio.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaCambio.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaCambio.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaCambio_Time)) {

FechaCambio = null;
}
 else
{
 FechaCambio = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaCambio.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaCambio_Time)) 
{
 FechaCambio = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaCambio = Convert.ToDateTime( " " + value + " " + FechaCambio.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaCambio_Time 
{
get
{
if (  !FechaCambio.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaCambio.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaCambio.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaCambio_Date)) 
{
FechaCambio = null;
}
 else
{
 FechaCambio = Convert.ToDateTime( " " + FechaCambio.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaCambio_Date)) 
{
 FechaCambio = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaCambio = Convert.ToDateTime( " " + FechaCambio_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaCambio 
{
get
{
return _fechaCambio;
}
set 
{
if ( _fechaCambio != value) 
{
_fechaCambio = value ;
OnPropertyChanged("FechaCambio");
}
}
}

public virtual System.String UsuarioCambio 
{
get
{
if ( Usuario0 != null ) 
{
_usuarioCambio = (System.String)Usuario0.Login;
}

return _usuarioCambio;
}
set 
{
if ( _usuarioCambio != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_usuario0 = null;

_usuarioCambio = value ;
OnPropertyChanged("UsuarioCambio");
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

public virtual System.String Razon 
{
get
{
return _razon;
}
set 
{
if ( _razon != value) 
{
_razon = value ;
OnPropertyChanged("Razon");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaEnvio_Date 
{
get
{
if (  !FechaEnvio.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaEnvio.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaEnvio.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaEnvio_Time)) {

FechaEnvio = null;
}
 else
{
 FechaEnvio = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaEnvio.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaEnvio_Time)) 
{
 FechaEnvio = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaEnvio = Convert.ToDateTime( " " + value + " " + FechaEnvio.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaEnvio_Time 
{
get
{
if (  !FechaEnvio.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaEnvio.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaEnvio.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaEnvio_Date)) 
{
FechaEnvio = null;
}
 else
{
 FechaEnvio = Convert.ToDateTime( " " + FechaEnvio.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaEnvio_Date)) 
{
 FechaEnvio = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaEnvio = Convert.ToDateTime( " " + FechaEnvio_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaEnvio 
{
get
{
return _fechaEnvio;
}
set 
{
if ( _fechaEnvio != value) 
{
_fechaEnvio = value ;
OnPropertyChanged("FechaEnvio");
}
}
}

/// <summary>
/// Generated from Relation FK_logCambioUbicaciones_sucursalCliente
/// </summary>
[GenWiseAttribute(RelationID = "5d94a5df-018b-47cd-8b2d-b46b672df95d") ]
public virtual SucursalCliente SucursalCliente 
{
get
{
if ( _sucursalCliente == null || _sucursalCliente == null ) 
{
if ( String.IsNullOrEmpty(_nitClienteDestino) || _nitClienteDestino.Equals(string.Empty) || String.IsNullOrEmpty(_codSucursalDestino) || _codSucursalDestino.Equals(string.Empty) ) 
{
if ( _sucursalCliente != null && ( _sucursalCliente.NitCliente.Equals(null) || _sucursalCliente.CodSucursal.Equals(null) ) )
{
  _sucursalCliente = null;
}
}
else
{
  _sucursalCliente = (new SucursalClienteFactory()).Fetch(_nitClienteDestino,_codSucursalDestino);
}
}

return _sucursalCliente;
}
set 
{
if ( _sucursalCliente != value) 
{
if ( value==null ) _nitClienteDestino = null; else _nitClienteDestino = (System.String)value.NitCliente; 
if ( value==null ) _codSucursalDestino = null; else _codSucursalDestino = (System.String)value.CodSucursal; 
_sucursalCliente = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_logCambioUbicaciones_sucursalCliente1
/// </summary>
[GenWiseAttribute(RelationID = "e3523f52-82be-4215-92e1-7526f87f6a73") ]
public virtual SucursalCliente SucursalCliente1 
{
get
{
if ( _sucursalCliente1 == null || _sucursalCliente1 == null ) 
{
if ( String.IsNullOrEmpty(_nitClienteDestino) || _nitClienteDestino.Equals(string.Empty) || String.IsNullOrEmpty(_codSucursalDestino) || _codSucursalDestino.Equals(string.Empty) ) 
{
if ( _sucursalCliente1 != null && ( _sucursalCliente1.NitCliente.Equals(null) || _sucursalCliente1.CodSucursal.Equals(null) ) )
{
  _sucursalCliente1 = null;
}
}
else
{
  _sucursalCliente1 = (new SucursalClienteFactory()).Fetch(_nitClienteDestino,_codSucursalDestino);
}
}

return _sucursalCliente1;
}
set 
{
if ( _sucursalCliente1 != value) 
{
if ( value==null ) _nitClienteDestino = null; else _nitClienteDestino = (System.String)value.NitCliente; 
if ( value==null ) _codSucursalDestino = null; else _codSucursalDestino = (System.String)value.CodSucursal; 
_sucursalCliente1 = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_logCambioUbicaciones_usuarios
/// </summary>
[GenWiseAttribute(RelationID = "10f87264-0a37-401d-b5d1-31cefee72aaa") ]
public virtual Usuario0 Usuario0 
{
get
{
if ( _usuario0 == null ) 
{
if ( String.IsNullOrEmpty(_usuarioCambio) || _usuarioCambio.Equals(string.Empty) ) 
{
if ( _usuario0 != null && ( _usuario0.Login.Equals(null) ) )
{
  _usuario0 = null;
}
}
else
{
_usuario0 = (new Usuario0Factory()).Get(_usuarioCambio);
}
}

return _usuario0;
}
set 
{
if ( _usuario0 != value) 
{
if ( value==null ) _usuarioCambio = null; else _usuarioCambio = (System.String)value.Login; 
_usuario0 = value ;
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
/// Create a new LogCambioUbicacione object. 
/// </summary>
public  LogCambioUbicacione()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  LogCambioUbicacione(System.Int32 pCodLog)
{
_codLog = pCodLog ;

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
if (  CodLog.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codLog) can not be null!. " ) );
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

