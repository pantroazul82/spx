using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class MantenimientosxContrato : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _numeroContrato;
private System.Int32 _codotroSi;
private System.String _serial;
private System.Int32 _codMantenimientoxContrato;
private System.Int32? _codOrdenServicio;
private System.DateTime? _fechaMantenimiento;
private Contrato _contrato;
private Equipo _equipo;

#endregion


#region --- Class Properties ---

public virtual System.String NumeroContrato 
{
get
{
return _numeroContrato;
}
set 
{
if ( _numeroContrato != value) 
{
_numeroContrato = value ;
OnPropertyChanged("NumeroContrato");
}
}
}

public virtual System.Int32 CodotroSi 
{
get
{
return _codotroSi;
}
set 
{
if ( _codotroSi != value) 
{
_codotroSi = value ;
OnPropertyChanged("CodotroSi");
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

public virtual System.Int32 CodMantenimientoxContrato 
{
get
{
return _codMantenimientoxContrato;
}
set 
{
if ( _codMantenimientoxContrato != value) 
{
_codMantenimientoxContrato = value ;
OnPropertyChanged("CodMantenimientoxContrato");
}
}
}

public virtual System.Int32? CodOrdenServicio 
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

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaMantenimiento_Date 
{
get
{
if (  !FechaMantenimiento.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaMantenimiento.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaMantenimiento.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaMantenimiento_Time)) {

FechaMantenimiento = null;
}
 else
{
 FechaMantenimiento = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaMantenimiento.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaMantenimiento_Time)) 
{
 FechaMantenimiento = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaMantenimiento = Convert.ToDateTime( " " + value + " " + FechaMantenimiento.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaMantenimiento_Time 
{
get
{
if (  !FechaMantenimiento.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaMantenimiento.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaMantenimiento.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaMantenimiento_Date)) 
{
FechaMantenimiento = null;
}
 else
{
 FechaMantenimiento = Convert.ToDateTime( " " + FechaMantenimiento.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaMantenimiento_Date)) 
{
 FechaMantenimiento = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaMantenimiento = Convert.ToDateTime( " " + FechaMantenimiento_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaMantenimiento 
{
get
{
return _fechaMantenimiento;
}
set 
{
if ( _fechaMantenimiento != value) 
{
_fechaMantenimiento = value ;
OnPropertyChanged("FechaMantenimiento");
}
}
}

/// <summary>
/// Generated from Relation FK_mantenimientosxContrato_contratos
/// </summary>
[GenWiseAttribute(RelationID = "19357b75-67f3-4bc8-8ac6-d726a076571f") ]
public virtual Contrato Contrato 
{
get
{
if ( _contrato == null || _contrato == null ) 
{
if ( String.IsNullOrEmpty(_numeroContrato) || _numeroContrato.Equals(string.Empty) ||  _codotroSi.Equals(0)  || _codotroSi.Equals(System.Int32.MinValue) ) 
{
if ( _contrato != null && ( _contrato.NumeroContrato.Equals(string.Empty) || _contrato.CodOtroSI.Equals(System.Int32.MinValue) ) )
{
  _contrato = null;
}
}
else
{
  _contrato = (new ContratoFactory()).Fetch(_numeroContrato,_codotroSi);
}
}

return _contrato;
}
set 
{
if ( _contrato != value) 
{
if ( value==null ) _numeroContrato = string.Empty; else _numeroContrato = (System.String)value.NumeroContrato; 
if ( value==null ) _codotroSi = System.Int32.MinValue; else _codotroSi = (System.Int32)value.CodOtroSI; 
_contrato = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_mantenimientosxContrato_equipos
/// </summary>
[GenWiseAttribute(RelationID = "22fffb2d-9d62-42d2-9572-a7e0b8f3476c") ]
public virtual Equipo Equipo 
{
get
{
if ( _equipo == null ) 
{
if ( String.IsNullOrEmpty(_serial) || _serial.Equals(string.Empty) ) 
{
if ( _equipo != null && ( _equipo.Serial.Equals(string.Empty) ) )
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
if ( value==null ) _serial = string.Empty; else _serial = (System.String)value.Serial; 
_equipo = value ;
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

if ( NumeroContrato != null ) _retValue += NumeroContrato.ToString();

_retValue += "^";
_retValue += CodotroSi.ToString();

_retValue += "^";
if ( Serial != null ) _retValue += Serial.ToString();

_retValue += "^";
_retValue += CodMantenimientoxContrato.ToString();

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
/// Create a new MantenimientosxContrato object. 
/// </summary>
public  MantenimientosxContrato()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  MantenimientosxContrato(System.String pNumeroContrato , System.Int32 pCodotroSi , System.String pSerial , System.Int32 pCodMantenimientoxContrato)
{
_numeroContrato = pNumeroContrato ;
_codotroSi = pCodotroSi ;
_serial = pSerial ;
_codMantenimientoxContrato = pCodMantenimientoxContrato ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
if ( NumeroContrato != null ) _hash += NumeroContrato.ToString();
_hash += CodotroSi.ToString();
if ( Serial != null ) _hash += Serial.ToString();
_hash += CodMantenimientoxContrato.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
MantenimientosxContrato _newMantenimientosxContrato = (pObject as MantenimientosxContrato); 
if (_newMantenimientosxContrato == null ) return false; 
if (_newMantenimientosxContrato.GetHashCode() == this.GetHashCode() ) return true; 
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
Error _error;
// Call Validator IsRequired for Column : numeroContrato(Type:Required Field Validator)
_error = this.ValidatenumeroContratoIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : serial(Type:Required Field Validator)
_error = this.ValidateserialIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(NumeroContrato) ) 
{
   _errors.Add( new Error( "The PK Column (numeroContrato) can not be null!. " ) );
}
if (  CodotroSi.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codotroSi) can not be null!. " ) );
}
if ( String.IsNullOrEmpty(Serial) ) 
{
   _errors.Add( new Error( "The PK Column (serial) can not be null!. " ) );
}
if (  CodMantenimientoxContrato.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codMantenimientoxContrato) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : numeroContrato
/// </remarks>
public virtual Error ValidatenumeroContratoIsRequired()
{
if ( String.IsNullOrEmpty(NumeroContrato) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "numeroContrato is required and therefore must have a value." ;
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

