using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class EquipoAuxiliar : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _serialEquipo;
private System.String _serialAuxiliar;
private System.String _observaciones;
private Equipo _equipo;
private Equipo _equipo1;

#endregion


#region --- Class Properties ---

public virtual System.String SerialEquipo 
{
get
{
return _serialEquipo;
}
set 
{
if ( _serialEquipo != value) 
{
_serialEquipo = value ;
OnPropertyChanged("SerialEquipo");
}
}
}

public virtual System.String SerialAuxiliar 
{
get
{
return _serialAuxiliar;
}
set 
{
if ( _serialAuxiliar != value) 
{
_serialAuxiliar = value ;
OnPropertyChanged("SerialAuxiliar");
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
/// Generated from Relation FK_equipoAuxiliar_equipos
/// </summary>
[GenWiseAttribute(RelationID = "592b51a2-84ae-4618-adcb-54e84648a959") ]
public virtual Equipo Equipo 
{
get
{
if ( _equipo == null ) 
{
if ( String.IsNullOrEmpty(_serialEquipo) || _serialEquipo.Equals(string.Empty) ) 
{
if ( _equipo != null && ( _equipo.Serial.Equals(string.Empty) ) )
{
  _equipo = null;
}
}
else
{
_equipo = (new EquipoFactory()).Get(_serialEquipo);
}
}

return _equipo;
}
set 
{
if ( _equipo != value) 
{
if ( value==null ) _serialEquipo = string.Empty; else _serialEquipo = (System.String)value.Serial; 
_equipo = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_equipoAuxiliar_equipos1
/// </summary>
[GenWiseAttribute(RelationID = "9754ca2a-afff-4db7-a52a-8e81fe760507") ]
public virtual Equipo Equipo1 
{
get
{
if ( _equipo1 == null ) 
{
if ( String.IsNullOrEmpty(_serialAuxiliar) || _serialAuxiliar.Equals(string.Empty) ) 
{
if ( _equipo1 != null && ( _equipo1.Serial.Equals(string.Empty) ) )
{
  _equipo1 = null;
}
}
else
{
_equipo1 = (new EquipoFactory()).Get(_serialAuxiliar);
}
}

return _equipo1;
}
set 
{
if ( _equipo1 != value) 
{
if ( value==null ) _serialAuxiliar = string.Empty; else _serialAuxiliar = (System.String)value.Serial; 
_equipo1 = value ;
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

if ( SerialEquipo != null ) _retValue += SerialEquipo.ToString();

_retValue += "^";
if ( SerialAuxiliar != null ) _retValue += SerialAuxiliar.ToString();

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
/// Create a new EquipoAuxiliar object. 
/// </summary>
public  EquipoAuxiliar()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  EquipoAuxiliar(System.String pSerialEquipo , System.String pSerialAuxiliar)
{
_serialEquipo = pSerialEquipo ;
_serialAuxiliar = pSerialAuxiliar ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
if ( SerialEquipo != null ) _hash += SerialEquipo.ToString();
if ( SerialAuxiliar != null ) _hash += SerialAuxiliar.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
EquipoAuxiliar _newEquipoAuxiliar = (pObject as EquipoAuxiliar); 
if (_newEquipoAuxiliar == null ) return false; 
if (_newEquipoAuxiliar.GetHashCode() == this.GetHashCode() ) return true; 
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
// Call Validator IsRequired for Column : serialEquipo(Type:Required Field Validator)
_error = this.ValidateserialEquipoIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : serialAuxiliar(Type:Required Field Validator)
_error = this.ValidateserialAuxiliarIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(SerialEquipo) ) 
{
   _errors.Add( new Error( "The PK Column (serialEquipo) can not be null!. " ) );
}
if ( String.IsNullOrEmpty(SerialAuxiliar) ) 
{
   _errors.Add( new Error( "The PK Column (serialAuxiliar) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : serialEquipo
/// </remarks>
public virtual Error ValidateserialEquipoIsRequired()
{
if ( String.IsNullOrEmpty(SerialEquipo) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "serialEquipo is required and therefore must have a value." ;
 return _error;
}
 return null;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : serialAuxiliar
/// </remarks>
public virtual Error ValidateserialAuxiliarIsRequired()
{
if ( String.IsNullOrEmpty(SerialAuxiliar) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "serialAuxiliar is required and therefore must have a value." ;
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

