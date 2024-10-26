﻿using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class ModulosxGruposUsuario : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _codModulo;
private System.String _codGruposUsu;
private System.Boolean? _controlTotal;
private System.Boolean? _modificar;
private System.Boolean? _lecturaEjecucion;
private System.Boolean? _escribir;
private System.Boolean? _eliminar;
private System.Boolean? _imprimir;
private System.Boolean? _denegar;
private GruposUsuario _gruposUsuario;
private Modulo _modulo;

#endregion


#region --- Class Properties ---

public virtual System.String CodModulo 
{
get
{
return _codModulo;
}
set 
{
if ( _codModulo != value) 
{
_codModulo = value ;
OnPropertyChanged("CodModulo");
}
}
}

public virtual System.String CodGruposUsu 
{
get
{
return _codGruposUsu;
}
set 
{
if ( _codGruposUsu != value) 
{
_codGruposUsu = value ;
OnPropertyChanged("CodGruposUsu");
}
}
}

public virtual System.Boolean? ControlTotal 
{
get
{
return _controlTotal;
}
set 
{
if ( _controlTotal != value) 
{
_controlTotal = value ;
OnPropertyChanged("ControlTotal");
}
}
}

public virtual System.Boolean? Modificar 
{
get
{
return _modificar;
}
set 
{
if ( _modificar != value) 
{
_modificar = value ;
OnPropertyChanged("Modificar");
}
}
}

public virtual System.Boolean? LecturaEjecucion 
{
get
{
return _lecturaEjecucion;
}
set 
{
if ( _lecturaEjecucion != value) 
{
_lecturaEjecucion = value ;
OnPropertyChanged("LecturaEjecucion");
}
}
}

public virtual System.Boolean? Escribir 
{
get
{
return _escribir;
}
set 
{
if ( _escribir != value) 
{
_escribir = value ;
OnPropertyChanged("Escribir");
}
}
}

public virtual System.Boolean? Eliminar 
{
get
{
return _eliminar;
}
set 
{
if ( _eliminar != value) 
{
_eliminar = value ;
OnPropertyChanged("Eliminar");
}
}
}

public virtual System.Boolean? Imprimir 
{
get
{
return _imprimir;
}
set 
{
if ( _imprimir != value) 
{
_imprimir = value ;
OnPropertyChanged("Imprimir");
}
}
}

public virtual System.Boolean? Denegar 
{
get
{
return _denegar;
}
set 
{
if ( _denegar != value) 
{
_denegar = value ;
OnPropertyChanged("Denegar");
}
}
}

/// <summary>
/// Generated from Relation FK_modulosxGruposUsuario_gruposUsuarios
/// </summary>
[GenWiseAttribute(RelationID = "ce2d1a3e-638b-498f-b185-e19721bbc226") ]
public virtual GruposUsuario GruposUsuario 
{
get
{
if ( _gruposUsuario == null ) 
{
if ( String.IsNullOrEmpty(_codGruposUsu) || _codGruposUsu.Equals(string.Empty) ) 
{
if ( _gruposUsuario != null && ( _gruposUsuario.CodGruposUsu.Equals(string.Empty) ) )
{
  _gruposUsuario = null;
}
}
else
{
_gruposUsuario = (new GruposUsuarioFactory()).Get(_codGruposUsu);
}
}

return _gruposUsuario;
}
set 
{
if ( _gruposUsuario != value) 
{
if ( value==null ) _codGruposUsu = string.Empty; else _codGruposUsu = (System.String)value.CodGruposUsu; 
_gruposUsuario = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_modulosxGruposUsuario_modulos
/// </summary>
[GenWiseAttribute(RelationID = "cf1f8c85-3d9d-4dff-8ea9-f950b4c29769") ]
public virtual Modulo Modulo 
{
get
{
if ( _modulo == null ) 
{
if ( String.IsNullOrEmpty(_codModulo) || _codModulo.Equals(string.Empty) ) 
{
if ( _modulo != null && ( _modulo.CodModulo.Equals(string.Empty) ) )
{
  _modulo = null;
}
}
else
{
_modulo = (new ModuloFactory()).Get(_codModulo);
}
}

return _modulo;
}
set 
{
if ( _modulo != value) 
{
if ( value==null ) _codModulo = string.Empty; else _codModulo = (System.String)value.CodModulo; 
_modulo = value ;
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

if ( CodModulo != null ) _retValue += CodModulo.ToString();

_retValue += "^";
if ( CodGruposUsu != null ) _retValue += CodGruposUsu.ToString();

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
/// Create a new ModulosxGruposUsuario object. 
/// </summary>
public  ModulosxGruposUsuario()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  ModulosxGruposUsuario(System.String pCodModulo , System.String pCodGruposUsu)
{
_codModulo = pCodModulo ;
_codGruposUsu = pCodGruposUsu ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
if ( CodModulo != null ) _hash += CodModulo.ToString();
if ( CodGruposUsu != null ) _hash += CodGruposUsu.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
ModulosxGruposUsuario _newModulosxGruposUsuario = (pObject as ModulosxGruposUsuario); 
if (_newModulosxGruposUsuario == null ) return false; 
if (_newModulosxGruposUsuario.GetHashCode() == this.GetHashCode() ) return true; 
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
// Call Validator IsRequired for Column : codModulo(Type:Required Field Validator)
_error = this.ValidatecodModuloIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : codGruposUsu(Type:Required Field Validator)
_error = this.ValidatecodGruposUsuIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(CodModulo) ) 
{
   _errors.Add( new Error( "The PK Column (codModulo) can not be null!. " ) );
}
if ( String.IsNullOrEmpty(CodGruposUsu) ) 
{
   _errors.Add( new Error( "The PK Column (codGruposUsu) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codModulo
/// </remarks>
public virtual Error ValidatecodModuloIsRequired()
{
if ( String.IsNullOrEmpty(CodModulo) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codModulo is required and therefore must have a value." ;
 return _error;
}
 return null;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codGruposUsu
/// </remarks>
public virtual Error ValidatecodGruposUsuIsRequired()
{
if ( String.IsNullOrEmpty(CodGruposUsu) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codGruposUsu is required and therefore must have a value." ;
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

