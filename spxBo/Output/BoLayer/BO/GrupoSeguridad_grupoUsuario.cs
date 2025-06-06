﻿using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class GrupoSeguridad_grupoUsuario : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codGrupoSeguridad_grupoUsuario;
private System.Int32 _codGrupoSeguridad;
private System.Int32 _codGrupoUsuario;
private System.Boolean? _controlTotal;
private System.Boolean? _modificar;
private System.Boolean? _lecturaEjecucion;
private System.Boolean? _escribir;
private System.Boolean? _eliminar;
private System.Boolean? _imprimir;
private System.Boolean? _denegar;
private GrupoSeguridad _grupoSeguridad;
private GrupoUsuario _grupoUsuario;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodGrupoSeguridad_grupoUsuario 
{
get
{
return _codGrupoSeguridad_grupoUsuario;
}
}

public virtual System.Int32 CodGrupoSeguridad 
{
get
{
if ( GrupoSeguridad != null ) 
{
_codGrupoSeguridad = (System.Int32)GrupoSeguridad.CodGrupoSeguridad;
}

return _codGrupoSeguridad;
}
set 
{
if ( _codGrupoSeguridad != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_grupoSeguridad = null;

_codGrupoSeguridad = value ;
OnPropertyChanged("CodGrupoSeguridad");
}
}
}

public virtual System.Int32 CodGrupoUsuario 
{
get
{
if ( GrupoUsuario != null ) 
{
_codGrupoUsuario = (System.Int32)GrupoUsuario.CodGrupoUsuario;
}

return _codGrupoUsuario;
}
set 
{
if ( _codGrupoUsuario != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_grupoUsuario = null;

_codGrupoUsuario = value ;
OnPropertyChanged("CodGrupoUsuario");
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
/// Generated from Relation FK_grupoSeguridad_grupoUsuario_grupoSeguridad
/// </summary>
[GenWiseAttribute(RelationID = "7314ab2a-17c9-4146-a3f1-5c0524226bca") ]
public virtual GrupoSeguridad GrupoSeguridad 
{
get
{
if ( _grupoSeguridad == null ) 
{
if (  _codGrupoSeguridad.Equals(0)  || _codGrupoSeguridad.Equals(System.Int32.MinValue) ) 
{
if ( _grupoSeguridad != null && ( _grupoSeguridad.CodGrupoSeguridad.Equals(System.Int32.MinValue) ) )
{
  _grupoSeguridad = null;
}
}
else
{
_grupoSeguridad = (new GrupoSeguridadFactory()).Get(_codGrupoSeguridad);
}
}

return _grupoSeguridad;
}
set 
{
if ( _grupoSeguridad != value) 
{
if ( value==null ) _codGrupoSeguridad = System.Int32.MinValue; else _codGrupoSeguridad = (System.Int32)value.CodGrupoSeguridad; 
_grupoSeguridad = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_grupoSeguridad_grupoUsuario_grupoUsuario
/// </summary>
[GenWiseAttribute(RelationID = "e90e87c9-9d95-4e03-80b2-e527afd5135b") ]
public virtual GrupoUsuario GrupoUsuario 
{
get
{
if ( _grupoUsuario == null ) 
{
if (  _codGrupoUsuario.Equals(0)  || _codGrupoUsuario.Equals(System.Int32.MinValue) ) 
{
if ( _grupoUsuario != null && ( _grupoUsuario.CodGrupoUsuario.Equals(System.Int32.MinValue) ) )
{
  _grupoUsuario = null;
}
}
else
{
_grupoUsuario = (new GrupoUsuarioFactory()).Get(_codGrupoUsuario);
}
}

return _grupoUsuario;
}
set 
{
if ( _grupoUsuario != value) 
{
if ( value==null ) _codGrupoUsuario = System.Int32.MinValue; else _codGrupoUsuario = (System.Int32)value.CodGrupoUsuario; 
_grupoUsuario = value ;
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
/// Create a new GrupoSeguridad_grupoUsuario object. 
/// </summary>
public  GrupoSeguridad_grupoUsuario()
{
_codGrupoSeguridad_grupoUsuario = System.Int32.MinValue;

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

