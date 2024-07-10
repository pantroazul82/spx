using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class OrdenPrestamo : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codOrdenPrestamo;
private System.String _loginResponsable;
private System.String _loginSolicito;
private System.String _loginAutorizo;
private System.String _loginAceptado;
private System.String _loginRecibido;
private System.String _loginAnulo;
private System.DateTime? _fechaOrden;
private System.DateTime? _fechaDevolucion;
private System.String _codPais;
private System.String _codDepartamento;
private System.String _codCiudad;
private System.Int32? _codOrdenServicio;
private System.Boolean? _anulada;
private System.String _obsIniciales;
private System.String _obsAprobacion;
private System.String _obsEntrega;
private System.String _obsDevolucion;
private System.Int32? _codEstadoOrdenPrestamo;
private IList<ObservacionesxOrdenPrestamo> _observacionesxOrdenPrestamos;
private IList<RepuestosxOrdenPrestamo> _repuestosxOrdenPrestamos;
private Ciudade _ciudade;
private EstadosOrdenPrestamo _estadosOrdenPrestamo;
private OrdenServicio _ordenServicio;
private Usuario0 _usuario0;
private Usuario0 _usuario01;
private Usuario0 _usuario02;
private Usuario0 _usuario03;
private Usuario0 _usuario04;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodOrdenPrestamo 
{
get
{
return _codOrdenPrestamo;
}
set 
{
if ( _codOrdenPrestamo != value) 
{
_codOrdenPrestamo = value ;
OnPropertyChanged("CodOrdenPrestamo");
}
}
}

public virtual System.String LoginResponsable 
{
get
{
if ( Usuario04 != null ) 
{
_loginResponsable = (System.String)Usuario04.Login;
}

return _loginResponsable;
}
set 
{
if ( _loginResponsable != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_usuario04 = null;

_loginResponsable = value ;
OnPropertyChanged("LoginResponsable");
}
}
}

public virtual System.String LoginSolicito 
{
get
{
if ( Usuario03 != null ) 
{
_loginSolicito = (System.String)Usuario03.Login;
}

return _loginSolicito;
}
set 
{
if ( _loginSolicito != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_usuario03 = null;

_loginSolicito = value ;
OnPropertyChanged("LoginSolicito");
}
}
}

public virtual System.String LoginAutorizo 
{
get
{
if ( Usuario02 != null ) 
{
_loginAutorizo = (System.String)Usuario02.Login;
}

return _loginAutorizo;
}
set 
{
if ( _loginAutorizo != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_usuario02 = null;

_loginAutorizo = value ;
OnPropertyChanged("LoginAutorizo");
}
}
}

public virtual System.String LoginAceptado 
{
get
{
if ( Usuario01 != null ) 
{
_loginAceptado = (System.String)Usuario01.Login;
}

return _loginAceptado;
}
set 
{
if ( _loginAceptado != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_usuario01 = null;

_loginAceptado = value ;
OnPropertyChanged("LoginAceptado");
}
}
}

public virtual System.String LoginRecibido 
{
get
{
if ( Usuario0 != null ) 
{
_loginRecibido = (System.String)Usuario0.Login;
}

return _loginRecibido;
}
set 
{
if ( _loginRecibido != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_usuario0 = null;

_loginRecibido = value ;
OnPropertyChanged("LoginRecibido");
}
}
}

public virtual System.String LoginAnulo 
{
get
{
return _loginAnulo;
}
set 
{
if ( _loginAnulo != value) 
{
_loginAnulo = value ;
OnPropertyChanged("LoginAnulo");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaOrden_Date 
{
get
{
if (  !FechaOrden.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaOrden.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaOrden.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaOrden_Time)) {

FechaOrden = null;
}
 else
{
 FechaOrden = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaOrden.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaOrden_Time)) 
{
 FechaOrden = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaOrden = Convert.ToDateTime( " " + value + " " + FechaOrden.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaOrden_Time 
{
get
{
if (  !FechaOrden.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaOrden.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaOrden.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaOrden_Date)) 
{
FechaOrden = null;
}
 else
{
 FechaOrden = Convert.ToDateTime( " " + FechaOrden.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaOrden_Date)) 
{
 FechaOrden = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaOrden = Convert.ToDateTime( " " + FechaOrden_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaOrden 
{
get
{
return _fechaOrden;
}
set 
{
if ( _fechaOrden != value) 
{
_fechaOrden = value ;
OnPropertyChanged("FechaOrden");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaDevolucion_Date 
{
get
{
if (  !FechaDevolucion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaDevolucion.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaDevolucion.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaDevolucion_Time)) {

FechaDevolucion = null;
}
 else
{
 FechaDevolucion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaDevolucion.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaDevolucion_Time)) 
{
 FechaDevolucion = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaDevolucion = Convert.ToDateTime( " " + value + " " + FechaDevolucion.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaDevolucion_Time 
{
get
{
if (  !FechaDevolucion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaDevolucion.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaDevolucion.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaDevolucion_Date)) 
{
FechaDevolucion = null;
}
 else
{
 FechaDevolucion = Convert.ToDateTime( " " + FechaDevolucion.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaDevolucion_Date)) 
{
 FechaDevolucion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaDevolucion = Convert.ToDateTime( " " + FechaDevolucion_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaDevolucion 
{
get
{
return _fechaDevolucion;
}
set 
{
if ( _fechaDevolucion != value) 
{
_fechaDevolucion = value ;
OnPropertyChanged("FechaDevolucion");
}
}
}

public virtual System.String CodPais 
{
get
{
if ( Ciudade != null ) 
{
_codPais = (System.String)Ciudade.CodPais;
}

return _codPais;
}
set 
{
if ( _codPais != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_ciudade = null;

_codPais = value ;
OnPropertyChanged("CodPais");
}
}
}

public virtual System.String CodDepartamento 
{
get
{
if ( Ciudade != null ) 
{
_codDepartamento = (System.String)Ciudade.CodDepartamento;
}

return _codDepartamento;
}
set 
{
if ( _codDepartamento != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_ciudade = null;

_codDepartamento = value ;
OnPropertyChanged("CodDepartamento");
}
}
}

public virtual System.String CodCiudad 
{
get
{
if ( Ciudade != null ) 
{
_codCiudad = (System.String)Ciudade.CodCiudad;
}

return _codCiudad;
}
set 
{
if ( _codCiudad != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_ciudade = null;

_codCiudad = value ;
OnPropertyChanged("CodCiudad");
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

public virtual System.Boolean? Anulada 
{
get
{
return _anulada;
}
set 
{
if ( _anulada != value) 
{
_anulada = value ;
OnPropertyChanged("Anulada");
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

public virtual System.String ObsAprobacion 
{
get
{
return _obsAprobacion;
}
set 
{
if ( _obsAprobacion != value) 
{
_obsAprobacion = value ;
OnPropertyChanged("ObsAprobacion");
}
}
}

public virtual System.String ObsEntrega 
{
get
{
return _obsEntrega;
}
set 
{
if ( _obsEntrega != value) 
{
_obsEntrega = value ;
OnPropertyChanged("ObsEntrega");
}
}
}

public virtual System.String ObsDevolucion 
{
get
{
return _obsDevolucion;
}
set 
{
if ( _obsDevolucion != value) 
{
_obsDevolucion = value ;
OnPropertyChanged("ObsDevolucion");
}
}
}

public virtual System.Int32? CodEstadoOrdenPrestamo 
{
get
{
if ( EstadosOrdenPrestamo != null ) 
{
_codEstadoOrdenPrestamo = (System.Int32)EstadosOrdenPrestamo.CodEstadoOrdenPrestamo;
}

return _codEstadoOrdenPrestamo;
}
set 
{
if ( _codEstadoOrdenPrestamo != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_estadosOrdenPrestamo = null;

_codEstadoOrdenPrestamo = value ;
OnPropertyChanged("CodEstadoOrdenPrestamo");
}
}
}

/// <summary>
/// Collection of ObservacionesxOrdenPrestamo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "0058b5f7-819f-4dbe-869e-7d316e62d824" , CollectionOfType = typeof(ObservacionesxOrdenPrestamo)) ]
public virtual IList<ObservacionesxOrdenPrestamo> ObservacionesxOrdenPrestamos 
{
get
{
 if (_observacionesxOrdenPrestamos == null) _observacionesxOrdenPrestamos = new List<ObservacionesxOrdenPrestamo>();

return _observacionesxOrdenPrestamos;
}
set 
{
if ( _observacionesxOrdenPrestamos != value) 
{
_observacionesxOrdenPrestamos = value ;
}
}
}

/// <summary>
/// Collection of RepuestosxOrdenPrestamo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "74019717-2af9-434b-941f-c3c0e91479a8" , CollectionOfType = typeof(RepuestosxOrdenPrestamo)) ]
public virtual IList<RepuestosxOrdenPrestamo> RepuestosxOrdenPrestamos 
{
get
{
 if (_repuestosxOrdenPrestamos == null) _repuestosxOrdenPrestamos = new List<RepuestosxOrdenPrestamo>();

return _repuestosxOrdenPrestamos;
}
set 
{
if ( _repuestosxOrdenPrestamos != value) 
{
_repuestosxOrdenPrestamos = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_OrdenPrestamo_ciudades
/// </summary>
[GenWiseAttribute(RelationID = "a0d97942-7f70-4eb2-9b28-7fbc2db9964f") ]
public virtual Ciudade Ciudade 
{
get
{
if ( _ciudade == null || _ciudade == null || _ciudade == null ) 
{
if ( String.IsNullOrEmpty(_codPais) || _codPais.Equals(string.Empty) || String.IsNullOrEmpty(_codDepartamento) || _codDepartamento.Equals(string.Empty) || String.IsNullOrEmpty(_codCiudad) || _codCiudad.Equals(string.Empty) ) 
{
if ( _ciudade != null && ( _ciudade.CodPais.Equals(null) || _ciudade.CodDepartamento.Equals(null) || _ciudade.CodCiudad.Equals(null) ) )
{
  _ciudade = null;
}
}
else
{
  _ciudade = (new CiudadeFactory()).Fetch(_codPais,_codDepartamento,_codCiudad);
}
}

return _ciudade;
}
set 
{
if ( _ciudade != value) 
{
if ( value==null ) _codPais = null; else _codPais = (System.String)value.CodPais; 
if ( value==null ) _codDepartamento = null; else _codDepartamento = (System.String)value.CodDepartamento; 
if ( value==null ) _codCiudad = null; else _codCiudad = (System.String)value.CodCiudad; 
_ciudade = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_OrdenPrestamo_estadosOrdenPrestamo
/// </summary>
[GenWiseAttribute(RelationID = "5c805545-3a8f-4232-98f4-8b9ae11e2648") ]
public virtual EstadosOrdenPrestamo EstadosOrdenPrestamo 
{
get
{
if ( _estadosOrdenPrestamo == null ) 
{
if ( !_codEstadoOrdenPrestamo.HasValue || _codEstadoOrdenPrestamo.Value.Equals(System.Int32.MinValue) ) 
{
if ( _estadosOrdenPrestamo != null && ( _estadosOrdenPrestamo.CodEstadoOrdenPrestamo.Equals(null) ) )
{
  _estadosOrdenPrestamo = null;
}
}
else
{
_estadosOrdenPrestamo = (new EstadosOrdenPrestamoFactory()).Get(_codEstadoOrdenPrestamo.Value);
}
}

return _estadosOrdenPrestamo;
}
set 
{
if ( _estadosOrdenPrestamo != value) 
{
if ( value==null ) _codEstadoOrdenPrestamo = null; else _codEstadoOrdenPrestamo = (System.Int32)value.CodEstadoOrdenPrestamo; 
_estadosOrdenPrestamo = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_OrdenPrestamo_ordenServicio
/// </summary>
[GenWiseAttribute(RelationID = "543636d3-3b27-468a-aef4-1fb186931edd") ]
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
/// Generated from Relation FK_OrdenPrestamo_usuarios
/// </summary>
[GenWiseAttribute(RelationID = "e557ad52-2e5b-413d-aebd-1308c4f92673") ]
public virtual Usuario0 Usuario0 
{
get
{
if ( _usuario0 == null ) 
{
if ( String.IsNullOrEmpty(_loginRecibido) || _loginRecibido.Equals(string.Empty) ) 
{
if ( _usuario0 != null && ( _usuario0.Login.Equals(null) ) )
{
  _usuario0 = null;
}
}
else
{
_usuario0 = (new Usuario0Factory()).Get(_loginRecibido);
}
}

return _usuario0;
}
set 
{
if ( _usuario0 != value) 
{
if ( value==null ) _loginRecibido = null; else _loginRecibido = (System.String)value.Login; 
_usuario0 = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_OrdenPrestamo_usuarios1
/// </summary>
[GenWiseAttribute(RelationID = "ca92cf78-319b-418d-b98d-831a82914aa0") ]
public virtual Usuario0 Usuario01 
{
get
{
if ( _usuario01 == null ) 
{
if ( String.IsNullOrEmpty(_loginAceptado) || _loginAceptado.Equals(string.Empty) ) 
{
if ( _usuario01 != null && ( _usuario01.Login.Equals(null) ) )
{
  _usuario01 = null;
}
}
else
{
_usuario01 = (new Usuario0Factory()).Get(_loginAceptado);
}
}

return _usuario01;
}
set 
{
if ( _usuario01 != value) 
{
if ( value==null ) _loginAceptado = null; else _loginAceptado = (System.String)value.Login; 
_usuario01 = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_OrdenPrestamo_usuarios2
/// </summary>
[GenWiseAttribute(RelationID = "589985d3-804e-41b2-a276-c0c45f1c109a") ]
public virtual Usuario0 Usuario02 
{
get
{
if ( _usuario02 == null ) 
{
if ( String.IsNullOrEmpty(_loginAutorizo) || _loginAutorizo.Equals(string.Empty) ) 
{
if ( _usuario02 != null && ( _usuario02.Login.Equals(null) ) )
{
  _usuario02 = null;
}
}
else
{
_usuario02 = (new Usuario0Factory()).Get(_loginAutorizo);
}
}

return _usuario02;
}
set 
{
if ( _usuario02 != value) 
{
if ( value==null ) _loginAutorizo = null; else _loginAutorizo = (System.String)value.Login; 
_usuario02 = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_OrdenPrestamo_usuarios3
/// </summary>
[GenWiseAttribute(RelationID = "9e2f20f2-e6b4-4df0-8611-b69dab4cc948") ]
public virtual Usuario0 Usuario03 
{
get
{
if ( _usuario03 == null ) 
{
if ( String.IsNullOrEmpty(_loginSolicito) || _loginSolicito.Equals(string.Empty) ) 
{
if ( _usuario03 != null && ( _usuario03.Login.Equals(null) ) )
{
  _usuario03 = null;
}
}
else
{
_usuario03 = (new Usuario0Factory()).Get(_loginSolicito);
}
}

return _usuario03;
}
set 
{
if ( _usuario03 != value) 
{
if ( value==null ) _loginSolicito = null; else _loginSolicito = (System.String)value.Login; 
_usuario03 = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_OrdenPrestamo_usuarios4
/// </summary>
[GenWiseAttribute(RelationID = "81b4e626-8193-495c-82c0-b137212587af") ]
public virtual Usuario0 Usuario04 
{
get
{
if ( _usuario04 == null ) 
{
if ( String.IsNullOrEmpty(_loginResponsable) || _loginResponsable.Equals(string.Empty) ) 
{
if ( _usuario04 != null && ( _usuario04.Login.Equals(null) ) )
{
  _usuario04 = null;
}
}
else
{
_usuario04 = (new Usuario0Factory()).Get(_loginResponsable);
}
}

return _usuario04;
}
set 
{
if ( _usuario04 != value) 
{
if ( value==null ) _loginResponsable = null; else _loginResponsable = (System.String)value.Login; 
_usuario04 = value ;
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
/// Create a new OrdenPrestamo object. 
/// </summary>
public  OrdenPrestamo()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  OrdenPrestamo(System.Int32 pCodOrdenPrestamo)
{
_codOrdenPrestamo = pCodOrdenPrestamo ;

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
if (  CodOrdenPrestamo.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codOrdenPrestamo) can not be null!. " ) );
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

