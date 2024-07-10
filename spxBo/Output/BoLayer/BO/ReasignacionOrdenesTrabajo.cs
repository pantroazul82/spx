using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class ReasignacionOrdenesTrabajo : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codOrdenServicio;
private System.Int32 _codReasignacion;
private System.String _loginOriginal;
private System.String _loginNuevo;
private System.DateTime? _fechaReAsignacion;
private System.String _motivoReasignacion;
private System.String _reasignadoPor;
private OrdenServicio _ordenServicio;

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

public virtual System.Int32 CodReasignacion 
{
get
{
return _codReasignacion;
}
set 
{
if ( _codReasignacion != value) 
{
_codReasignacion = value ;
OnPropertyChanged("CodReasignacion");
}
}
}

public virtual System.String LoginOriginal 
{
get
{
return _loginOriginal;
}
set 
{
if ( _loginOriginal != value) 
{
_loginOriginal = value ;
OnPropertyChanged("LoginOriginal");
}
}
}

public virtual System.String LoginNuevo 
{
get
{
return _loginNuevo;
}
set 
{
if ( _loginNuevo != value) 
{
_loginNuevo = value ;
OnPropertyChanged("LoginNuevo");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaReAsignacion_Date 
{
get
{
if (  !FechaReAsignacion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaReAsignacion.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaReAsignacion.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaReAsignacion_Time)) {

FechaReAsignacion = null;
}
 else
{
 FechaReAsignacion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaReAsignacion.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaReAsignacion_Time)) 
{
 FechaReAsignacion = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaReAsignacion = Convert.ToDateTime( " " + value + " " + FechaReAsignacion.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaReAsignacion_Time 
{
get
{
if (  !FechaReAsignacion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaReAsignacion.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaReAsignacion.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaReAsignacion_Date)) 
{
FechaReAsignacion = null;
}
 else
{
 FechaReAsignacion = Convert.ToDateTime( " " + FechaReAsignacion.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaReAsignacion_Date)) 
{
 FechaReAsignacion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaReAsignacion = Convert.ToDateTime( " " + FechaReAsignacion_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaReAsignacion 
{
get
{
return _fechaReAsignacion;
}
set 
{
if ( _fechaReAsignacion != value) 
{
_fechaReAsignacion = value ;
OnPropertyChanged("FechaReAsignacion");
}
}
}

public virtual System.String MotivoReasignacion 
{
get
{
return _motivoReasignacion;
}
set 
{
if ( _motivoReasignacion != value) 
{
_motivoReasignacion = value ;
OnPropertyChanged("MotivoReasignacion");
}
}
}

public virtual System.String ReasignadoPor 
{
get
{
return _reasignadoPor;
}
set 
{
if ( _reasignadoPor != value) 
{
_reasignadoPor = value ;
OnPropertyChanged("ReasignadoPor");
}
}
}

/// <summary>
/// Generated from Relation FK_reasignacionOrdenesTrabajo_ordenServicio
/// </summary>
[GenWiseAttribute(RelationID = "c5903e92-bda8-44ef-a30f-4949e1a8ce9c") ]
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
/// Property that simulates a unique PK by concatenating all the Pk properties
/// </summary>
public virtual System.String VirtualPk 
{
get
{
string _retValue = string.Empty;

_retValue += CodOrdenServicio.ToString();

_retValue += "^";
_retValue += CodReasignacion.ToString();

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
/// Create a new ReasignacionOrdenesTrabajo object. 
/// </summary>
public  ReasignacionOrdenesTrabajo()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  ReasignacionOrdenesTrabajo(System.Int32 pCodOrdenServicio , System.Int32 pCodReasignacion)
{
_codOrdenServicio = pCodOrdenServicio ;
_codReasignacion = pCodReasignacion ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
_hash += CodOrdenServicio.ToString();
_hash += CodReasignacion.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
ReasignacionOrdenesTrabajo _newReasignacionOrdenesTrabajo = (pObject as ReasignacionOrdenesTrabajo); 
if (_newReasignacionOrdenesTrabajo == null ) return false; 
if (_newReasignacionOrdenesTrabajo.GetHashCode() == this.GetHashCode() ) return true; 
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
if (  CodReasignacion.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codReasignacion) can not be null!. " ) );
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

