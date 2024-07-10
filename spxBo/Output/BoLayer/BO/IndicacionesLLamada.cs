using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class IndicacionesLLamada : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _idLLamadaSoporte;
private System.Int32 _codIndicacion;
private System.String _ingresadaPor;
private System.String _descripcion;
private System.String _observaciones;
private System.DateTime? _fechaCreacion;
private System.DateTime? _fechaIndicacion;
private LlamadaSoporte _llamadaSoporte;
private Usuario0 _usuario0;

#endregion


#region --- Class Properties ---

public virtual System.Int32 IdLLamadaSoporte 
{
get
{
return _idLLamadaSoporte;
}
set 
{
if ( _idLLamadaSoporte != value) 
{
_idLLamadaSoporte = value ;
OnPropertyChanged("IdLLamadaSoporte");
}
}
}

public virtual System.Int32 CodIndicacion 
{
get
{
return _codIndicacion;
}
set 
{
if ( _codIndicacion != value) 
{
_codIndicacion = value ;
OnPropertyChanged("CodIndicacion");
}
}
}

public virtual System.String IngresadaPor 
{
get
{
if ( Usuario0 != null ) 
{
_ingresadaPor = (System.String)Usuario0.Login;
}

return _ingresadaPor;
}
set 
{
if ( _ingresadaPor != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_usuario0 = null;

_ingresadaPor = value ;
OnPropertyChanged("IngresadaPor");
}
}
}

public virtual System.String Descripcion 
{
get
{
return _descripcion;
}
set 
{
if ( _descripcion != value) 
{
_descripcion = value ;
OnPropertyChanged("Descripcion");
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
public virtual System.String FechaIndicacion_Date 
{
get
{
if (  !FechaIndicacion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaIndicacion.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaIndicacion.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaIndicacion_Time)) {

FechaIndicacion = null;
}
 else
{
 FechaIndicacion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaIndicacion.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaIndicacion_Time)) 
{
 FechaIndicacion = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaIndicacion = Convert.ToDateTime( " " + value + " " + FechaIndicacion.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaIndicacion_Time 
{
get
{
if (  !FechaIndicacion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaIndicacion.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaIndicacion.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaIndicacion_Date)) 
{
FechaIndicacion = null;
}
 else
{
 FechaIndicacion = Convert.ToDateTime( " " + FechaIndicacion.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaIndicacion_Date)) 
{
 FechaIndicacion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaIndicacion = Convert.ToDateTime( " " + FechaIndicacion_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaIndicacion 
{
get
{
return _fechaIndicacion;
}
set 
{
if ( _fechaIndicacion != value) 
{
_fechaIndicacion = value ;
OnPropertyChanged("FechaIndicacion");
}
}
}

/// <summary>
/// Generated from Relation FK_indicacionesLLamadas_LlamadaSoporte
/// </summary>
[GenWiseAttribute(RelationID = "16ada563-7dd3-4ad1-ba74-e764d17a2eca") ]
public virtual LlamadaSoporte LlamadaSoporte 
{
get
{
if ( _llamadaSoporte == null ) 
{
if (  _idLLamadaSoporte.Equals(0)  || _idLLamadaSoporte.Equals(System.Int32.MinValue) ) 
{
if ( _llamadaSoporte != null && ( _llamadaSoporte.IdLlamadaSoporte.Equals(System.Int32.MinValue) ) )
{
  _llamadaSoporte = null;
}
}
else
{
_llamadaSoporte = (new LlamadaSoporteFactory()).Get(_idLLamadaSoporte);
}
}

return _llamadaSoporte;
}
set 
{
if ( _llamadaSoporte != value) 
{
if ( value==null ) _idLLamadaSoporte = System.Int32.MinValue; else _idLLamadaSoporte = (System.Int32)value.IdLlamadaSoporte; 
_llamadaSoporte = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_indicacionesLLamadas_usuarios
/// </summary>
[GenWiseAttribute(RelationID = "46243392-62ec-425c-afaa-c730f8ec46ac") ]
public virtual Usuario0 Usuario0 
{
get
{
if ( _usuario0 == null ) 
{
if ( String.IsNullOrEmpty(_ingresadaPor) || _ingresadaPor.Equals(string.Empty) ) 
{
if ( _usuario0 != null && ( _usuario0.Login.Equals(null) ) )
{
  _usuario0 = null;
}
}
else
{
_usuario0 = (new Usuario0Factory()).Get(_ingresadaPor);
}
}

return _usuario0;
}
set 
{
if ( _usuario0 != value) 
{
if ( value==null ) _ingresadaPor = null; else _ingresadaPor = (System.String)value.Login; 
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

_retValue += IdLLamadaSoporte.ToString();

_retValue += "^";
_retValue += CodIndicacion.ToString();

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
/// Create a new IndicacionesLLamada object. 
/// </summary>
public  IndicacionesLLamada()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  IndicacionesLLamada(System.Int32 pIdLLamadaSoporte , System.Int32 pCodIndicacion)
{
_idLLamadaSoporte = pIdLLamadaSoporte ;
_codIndicacion = pCodIndicacion ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
_hash += IdLLamadaSoporte.ToString();
_hash += CodIndicacion.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
IndicacionesLLamada _newIndicacionesLLamada = (pObject as IndicacionesLLamada); 
if (_newIndicacionesLLamada == null ) return false; 
if (_newIndicacionesLLamada.GetHashCode() == this.GetHashCode() ) return true; 
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
if (  IdLLamadaSoporte.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (idLLamadaSoporte) can not be null!. " ) );
}
if (  CodIndicacion.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codIndicacion) can not be null!. " ) );
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

