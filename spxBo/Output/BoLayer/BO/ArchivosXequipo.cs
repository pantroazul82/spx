﻿using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class ArchivosXequipo : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _serial;
private System.Int32 _codArchivo;
private System.String _nombreArchivo;
private System.String _descripcion;
private System.String _codTipoArchivoxEquipo;
private Equipo _equipo;
private TiposArchivoXequipo _tiposArchivoXequipo;

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

public virtual System.Int32 CodArchivo 
{
get
{
return _codArchivo;
}
set 
{
if ( _codArchivo != value) 
{
_codArchivo = value ;
OnPropertyChanged("CodArchivo");
}
}
}

public virtual System.String NombreArchivo 
{
get
{
return _nombreArchivo;
}
set 
{
if ( _nombreArchivo != value) 
{
_nombreArchivo = value ;
OnPropertyChanged("NombreArchivo");
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

public virtual System.String CodTipoArchivoxEquipo 
{
get
{
if ( TiposArchivoXequipo != null ) 
{
_codTipoArchivoxEquipo = (System.String)TiposArchivoXequipo.CodTipoArchivoxEquipo;
}

return _codTipoArchivoxEquipo;
}
set 
{
if ( _codTipoArchivoxEquipo != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_tiposArchivoXequipo = null;

_codTipoArchivoxEquipo = value ;
OnPropertyChanged("CodTipoArchivoxEquipo");
}
}
}

/// <summary>
/// Generated from Relation FK_archivosXequipo_equipos
/// </summary>
[GenWiseAttribute(RelationID = "e6312518-561c-4f09-9fa0-636fc38279a7") ]
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
/// Generated from Relation FK_archivosXequipo_TiposArchivoXequipo
/// </summary>
[GenWiseAttribute(RelationID = "1c57e0fc-c85f-462c-ab57-60fb6007017c") ]
public virtual TiposArchivoXequipo TiposArchivoXequipo 
{
get
{
if ( _tiposArchivoXequipo == null ) 
{
if ( String.IsNullOrEmpty(_codTipoArchivoxEquipo) || _codTipoArchivoxEquipo.Equals(string.Empty) ) 
{
if ( _tiposArchivoXequipo != null && ( _tiposArchivoXequipo.CodTipoArchivoxEquipo.Equals(null) ) )
{
  _tiposArchivoXequipo = null;
}
}
else
{
_tiposArchivoXequipo = (new TiposArchivoXequipoFactory()).Get(_codTipoArchivoxEquipo);
}
}

return _tiposArchivoXequipo;
}
set 
{
if ( _tiposArchivoXequipo != value) 
{
if ( value==null ) _codTipoArchivoxEquipo = null; else _codTipoArchivoxEquipo = (System.String)value.CodTipoArchivoxEquipo; 
_tiposArchivoXequipo = value ;
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
_retValue += CodArchivo.ToString();

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
/// Create a new ArchivosXequipo object. 
/// </summary>
public  ArchivosXequipo()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  ArchivosXequipo(System.String pSerial , System.Int32 pCodArchivo)
{
_serial = pSerial ;
_codArchivo = pCodArchivo ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
if ( Serial != null ) _hash += Serial.ToString();
_hash += CodArchivo.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
ArchivosXequipo _newArchivosXequipo = (pObject as ArchivosXequipo); 
if (_newArchivosXequipo == null ) return false; 
if (_newArchivosXequipo.GetHashCode() == this.GetHashCode() ) return true; 
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

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(Serial) ) 
{
   _errors.Add( new Error( "The PK Column (serial) can not be null!. " ) );
}
if (  CodArchivo.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codArchivo) can not be null!. " ) );
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

