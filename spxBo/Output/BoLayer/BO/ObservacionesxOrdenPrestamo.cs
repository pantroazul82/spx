using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class ObservacionesxOrdenPrestamo : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codOrdenPrestamo;
private System.Int32 _idObservacion;
private System.DateTime? _fechaObservacion;
private System.String _loginAutor;
private System.String _observacion;
private OrdenPrestamo _ordenPrestamo;
private Usuario0 _usuario0;

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

public virtual System.Int32 IdObservacion 
{
get
{
return _idObservacion;
}
set 
{
if ( _idObservacion != value) 
{
_idObservacion = value ;
OnPropertyChanged("IdObservacion");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaObservacion_Date 
{
get
{
if (  !FechaObservacion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaObservacion.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaObservacion.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaObservacion_Time)) {

FechaObservacion = null;
}
 else
{
 FechaObservacion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaObservacion.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaObservacion_Time)) 
{
 FechaObservacion = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaObservacion = Convert.ToDateTime( " " + value + " " + FechaObservacion.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaObservacion_Time 
{
get
{
if (  !FechaObservacion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaObservacion.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaObservacion.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaObservacion_Date)) 
{
FechaObservacion = null;
}
 else
{
 FechaObservacion = Convert.ToDateTime( " " + FechaObservacion.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaObservacion_Date)) 
{
 FechaObservacion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaObservacion = Convert.ToDateTime( " " + FechaObservacion_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaObservacion 
{
get
{
return _fechaObservacion;
}
set 
{
if ( _fechaObservacion != value) 
{
_fechaObservacion = value ;
OnPropertyChanged("FechaObservacion");
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

public virtual System.String Observacion 
{
get
{
return _observacion;
}
set 
{
if ( _observacion != value) 
{
_observacion = value ;
OnPropertyChanged("Observacion");
}
}
}

/// <summary>
/// Generated from Relation FK_ObservacionesxOrdenPrestamo_OrdenPrestamo
/// </summary>
[GenWiseAttribute(RelationID = "0058b5f7-819f-4dbe-869e-7d316e62d824") ]
public virtual OrdenPrestamo OrdenPrestamo 
{
get
{
if ( _ordenPrestamo == null ) 
{
if (  _codOrdenPrestamo.Equals(0)  || _codOrdenPrestamo.Equals(System.Int32.MinValue) ) 
{
if ( _ordenPrestamo != null && ( _ordenPrestamo.CodOrdenPrestamo.Equals(System.Int32.MinValue) ) )
{
  _ordenPrestamo = null;
}
}
else
{
_ordenPrestamo = (new OrdenPrestamoFactory()).Get(_codOrdenPrestamo);
}
}

return _ordenPrestamo;
}
set 
{
if ( _ordenPrestamo != value) 
{
if ( value==null ) _codOrdenPrestamo = System.Int32.MinValue; else _codOrdenPrestamo = (System.Int32)value.CodOrdenPrestamo; 
_ordenPrestamo = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_ObservacionesxOrdenPrestamo_usuarios
/// </summary>
[GenWiseAttribute(RelationID = "53f6223a-f41b-4496-bfb4-54044fe5f9fb") ]
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
/// Property that simulates a unique PK by concatenating all the Pk properties
/// </summary>
public virtual System.String VirtualPk 
{
get
{
string _retValue = string.Empty;

_retValue += CodOrdenPrestamo.ToString();

_retValue += "^";
_retValue += IdObservacion.ToString();

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
/// Create a new ObservacionesxOrdenPrestamo object. 
/// </summary>
public  ObservacionesxOrdenPrestamo()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  ObservacionesxOrdenPrestamo(System.Int32 pCodOrdenPrestamo , System.Int32 pIdObservacion)
{
_codOrdenPrestamo = pCodOrdenPrestamo ;
_idObservacion = pIdObservacion ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
_hash += CodOrdenPrestamo.ToString();
_hash += IdObservacion.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
ObservacionesxOrdenPrestamo _newObservacionesxOrdenPrestamo = (pObject as ObservacionesxOrdenPrestamo); 
if (_newObservacionesxOrdenPrestamo == null ) return false; 
if (_newObservacionesxOrdenPrestamo.GetHashCode() == this.GetHashCode() ) return true; 
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
if (  CodOrdenPrestamo.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codOrdenPrestamo) can not be null!. " ) );
}
if (  IdObservacion.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (idObservacion) can not be null!. " ) );
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

