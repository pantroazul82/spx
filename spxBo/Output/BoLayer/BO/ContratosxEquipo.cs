using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class ContratosxEquipo : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _serial;
private System.String _numeroContrato;
private System.Int32 _codOtroSi;
private System.Int32? _mantenimientosRealizados;
private System.Int32? _mantenimientosxContrato;
private System.Boolean? _esActivo;
private Contrato _contrato;
private Equipo _equipo;

#endregion


#region --- Class Properties ---

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

public virtual System.Int32 CodOtroSi 
{
get
{
return _codOtroSi;
}
set 
{
if ( _codOtroSi != value) 
{
_codOtroSi = value ;
OnPropertyChanged("CodOtroSi");
}
}
}

public virtual System.Int32? MantenimientosRealizados 
{
get
{
return _mantenimientosRealizados;
}
set 
{
if ( _mantenimientosRealizados != value) 
{
_mantenimientosRealizados = value ;
OnPropertyChanged("MantenimientosRealizados");
}
}
}

public virtual System.Int32? MantenimientosxContrato 
{
get
{
return _mantenimientosxContrato;
}
set 
{
if ( _mantenimientosxContrato != value) 
{
_mantenimientosxContrato = value ;
OnPropertyChanged("MantenimientosxContrato");
}
}
}

public virtual System.Boolean? EsActivo 
{
get
{
return _esActivo;
}
set 
{
if ( _esActivo != value) 
{
_esActivo = value ;
OnPropertyChanged("EsActivo");
}
}
}

/// <summary>
/// Generated from Relation FK_contratosxEquipo_contratos
/// </summary>
[GenWiseAttribute(RelationID = "e43535ce-d616-45f9-a9c4-2cd0de7b08a6") ]
public virtual Contrato Contrato 
{
get
{
if ( _contrato == null || _contrato == null ) 
{
if ( String.IsNullOrEmpty(_numeroContrato) || _numeroContrato.Equals(string.Empty) ||  _codOtroSi.Equals(0)  || _codOtroSi.Equals(System.Int32.MinValue) ) 
{
if ( _contrato != null && ( _contrato.NumeroContrato.Equals(string.Empty) || _contrato.CodOtroSI.Equals(System.Int32.MinValue) ) )
{
  _contrato = null;
}
}
else
{
  _contrato = (new ContratoFactory()).Fetch(_numeroContrato,_codOtroSi);
}
}

return _contrato;
}
set 
{
if ( _contrato != value) 
{
if ( value==null ) _numeroContrato = string.Empty; else _numeroContrato = (System.String)value.NumeroContrato; 
if ( value==null ) _codOtroSi = System.Int32.MinValue; else _codOtroSi = (System.Int32)value.CodOtroSI; 
_contrato = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_contratosxEquipo_equipos
/// </summary>
[GenWiseAttribute(RelationID = "b8e3e2ba-5bb2-4bb3-8f2e-dc147c3ba752") ]
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

if ( Serial != null ) _retValue += Serial.ToString();

_retValue += "^";
if ( NumeroContrato != null ) _retValue += NumeroContrato.ToString();

_retValue += "^";
_retValue += CodOtroSi.ToString();

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
/// Create a new ContratosxEquipo object. 
/// </summary>
public  ContratosxEquipo()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  ContratosxEquipo(System.String pSerial , System.String pNumeroContrato , System.Int32 pCodOtroSi)
{
_serial = pSerial ;
_numeroContrato = pNumeroContrato ;
_codOtroSi = pCodOtroSi ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
if ( Serial != null ) _hash += Serial.ToString();
if ( NumeroContrato != null ) _hash += NumeroContrato.ToString();
_hash += CodOtroSi.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
ContratosxEquipo _newContratosxEquipo = (pObject as ContratosxEquipo); 
if (_newContratosxEquipo == null ) return false; 
if (_newContratosxEquipo.GetHashCode() == this.GetHashCode() ) return true; 
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
// Call Validator IsRequired for Column : serial(Type:Required Field Validator)
_error = this.ValidateserialIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : numeroContrato(Type:Required Field Validator)
_error = this.ValidatenumeroContratoIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(Serial) ) 
{
   _errors.Add( new Error( "The PK Column (serial) can not be null!. " ) );
}
if ( String.IsNullOrEmpty(NumeroContrato) ) 
{
   _errors.Add( new Error( "The PK Column (numeroContrato) can not be null!. " ) );
}
if (  CodOtroSi.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codOtroSi) can not be null!. " ) );
}

return _errors;
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

