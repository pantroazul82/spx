using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class ActividadxordenServicio : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codOrdenServicio;
private System.Int32 _codActividad;
private System.DateTime? _fecha;
private System.String _observacion;
private System.String _loginAutor;
private OrdenServicio _ordenServicio;
private Usuario0 _usuario0;

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

public virtual System.Int32 CodActividad 
{
get
{
return _codActividad;
}
set 
{
if ( _codActividad != value) 
{
_codActividad = value ;
OnPropertyChanged("CodActividad");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String Fecha_Date 
{
get
{
if (  !Fecha.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( Fecha.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return Fecha.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(Fecha_Time)) {

Fecha = null;
}
 else
{
 Fecha = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + Fecha.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(Fecha_Time)) 
{
 Fecha = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 Fecha = Convert.ToDateTime( " " + value + " " + Fecha.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String Fecha_Time 
{
get
{
if (  !Fecha.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( Fecha.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return Fecha.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(Fecha_Date)) 
{
Fecha = null;
}
 else
{
 Fecha = Convert.ToDateTime( " " + Fecha.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(Fecha_Date)) 
{
 Fecha = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 Fecha = Convert.ToDateTime( " " + Fecha_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? Fecha 
{
get
{
return _fecha;
}
set 
{
if ( _fecha != value) 
{
_fecha = value ;
OnPropertyChanged("Fecha");
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

/// <summary>
/// Generated from Relation FK_actividadxordenServicio_ordenServicio
/// </summary>
[GenWiseAttribute(RelationID = "e09bd3f8-4d3f-4d6b-8b97-5b1a3b51a4f6") ]
public virtual OrdenServicio OrdenServicio 
{
get
{
if ( _ordenServicio == null ) 
{
if (  _codOrdenServicio.Equals(0)  || _codOrdenServicio.Equals(System.Int32.MinValue) ) 
{
if ( _ordenServicio != null && ( _ordenServicio.CodOrdenServicio.Equals(System.Int32.MinValue) ) )
{
  _ordenServicio = null;
}
}
else
{
_ordenServicio = (new OrdenServicioFactory()).Get(_codOrdenServicio);
}
}

return _ordenServicio;
}
set 
{
if ( _ordenServicio != value) 
{
if ( value==null ) _codOrdenServicio = System.Int32.MinValue; else _codOrdenServicio = (System.Int32)value.CodOrdenServicio; 
_ordenServicio = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_actividadxordenServicio_usuarios
/// </summary>
[GenWiseAttribute(RelationID = "64623de3-1cb4-4852-be00-87ac3525ff02") ]
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

_retValue += CodOrdenServicio.ToString();

_retValue += "^";
_retValue += CodActividad.ToString();

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
/// Create a new ActividadxordenServicio object. 
/// </summary>
public  ActividadxordenServicio()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  ActividadxordenServicio(System.Int32 pCodOrdenServicio , System.Int32 pCodActividad)
{
_codOrdenServicio = pCodOrdenServicio ;
_codActividad = pCodActividad ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
_hash += CodOrdenServicio.ToString();
_hash += CodActividad.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
ActividadxordenServicio _newActividadxordenServicio = (pObject as ActividadxordenServicio); 
if (_newActividadxordenServicio == null ) return false; 
if (_newActividadxordenServicio.GetHashCode() == this.GetHashCode() ) return true; 
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
if (  CodOrdenServicio.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codOrdenServicio) can not be null!. " ) );
}
if (  CodActividad.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codActividad) can not be null!. " ) );
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

