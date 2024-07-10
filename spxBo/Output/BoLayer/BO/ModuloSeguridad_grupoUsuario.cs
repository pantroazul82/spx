using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class ModuloSeguridad_grupoUsuario : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codModuloSeguridad_grupoUsuario;
private System.Int32? _codGrupoUsuario;
private System.Int32? _codModuloSeguridad;
private System.Boolean? _controlTotal;
private System.Boolean? _modificar;
private System.Boolean? _lecturaEjecucion;
private System.Boolean? _escribir;
private System.Boolean? _eliminar;
private System.Boolean? _imprimir;
private System.Boolean? _denegar;
private GrupoUsuario _grupoUsuario;
private ModuloSeguridad _moduloSeguridad;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodModuloSeguridad_grupoUsuario 
{
get
{
return _codModuloSeguridad_grupoUsuario;
}
}

public virtual System.Int32? CodGrupoUsuario 
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

public virtual System.Int32? CodModuloSeguridad 
{
get
{
if ( ModuloSeguridad != null ) 
{
_codModuloSeguridad = (System.Int32)ModuloSeguridad.CodModuloSeguridad;
}

return _codModuloSeguridad;
}
set 
{
if ( _codModuloSeguridad != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_moduloSeguridad = null;

_codModuloSeguridad = value ;
OnPropertyChanged("CodModuloSeguridad");
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
/// Generated from Relation FK_moduloSeguridad_grupoUsuario_grupoUsuario
/// </summary>
[GenWiseAttribute(RelationID = "7ab4d771-5ca3-4483-bdf0-d760d557cbf1") ]
public virtual GrupoUsuario GrupoUsuario 
{
get
{
if ( _grupoUsuario == null ) 
{
if ( !_codGrupoUsuario.HasValue || _codGrupoUsuario.Value.Equals(System.Int32.MinValue) ) 
{
if ( _grupoUsuario != null && ( _grupoUsuario.CodGrupoUsuario.Equals(null) ) )
{
  _grupoUsuario = null;
}
}
else
{
_grupoUsuario = (new GrupoUsuarioFactory()).Get(_codGrupoUsuario.Value);
}
}

return _grupoUsuario;
}
set 
{
if ( _grupoUsuario != value) 
{
if ( value==null ) _codGrupoUsuario = null; else _codGrupoUsuario = (System.Int32)value.CodGrupoUsuario; 
_grupoUsuario = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_moduloSeguridad_grupoUsuario_moduloSeguridad
/// </summary>
[GenWiseAttribute(RelationID = "28f1a616-5e47-443f-bd53-e2697f4e0238") ]
public virtual ModuloSeguridad ModuloSeguridad 
{
get
{
if ( _moduloSeguridad == null ) 
{
if ( !_codModuloSeguridad.HasValue || _codModuloSeguridad.Value.Equals(System.Int32.MinValue) ) 
{
if ( _moduloSeguridad != null && ( _moduloSeguridad.CodModuloSeguridad.Equals(null) ) )
{
  _moduloSeguridad = null;
}
}
else
{
_moduloSeguridad = (new ModuloSeguridadFactory()).Get(_codModuloSeguridad.Value);
}
}

return _moduloSeguridad;
}
set 
{
if ( _moduloSeguridad != value) 
{
if ( value==null ) _codModuloSeguridad = null; else _codModuloSeguridad = (System.Int32)value.CodModuloSeguridad; 
_moduloSeguridad = value ;
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
/// Create a new ModuloSeguridad_grupoUsuario object. 
/// </summary>
public  ModuloSeguridad_grupoUsuario()
{
_codModuloSeguridad_grupoUsuario = System.Int32.MinValue;

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

