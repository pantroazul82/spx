using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class ModuloSeguridad : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codModuloSeguridad;
private System.String _descripcion;
private System.Int32? _codGrupoSeguridad;
private System.Boolean? _esDeshabilitado;
private IList<ModuloSeguridad_grupoUsuario> _moduloSeguridad_grupoUsuarios;
private IList<ModuloSeguridad_usuario> _moduloSeguridad_usuarios;
private GrupoSeguridad _grupoSeguridad;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodModuloSeguridad 
{
get
{
return _codModuloSeguridad;
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

public virtual System.Int32? CodGrupoSeguridad 
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

public virtual System.Boolean? EsDeshabilitado 
{
get
{
return _esDeshabilitado;
}
set 
{
if ( _esDeshabilitado != value) 
{
_esDeshabilitado = value ;
OnPropertyChanged("EsDeshabilitado");
}
}
}

/// <summary>
/// Collection of ModuloSeguridad_grupoUsuario.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "28f1a616-5e47-443f-bd53-e2697f4e0238" , CollectionOfType = typeof(ModuloSeguridad_grupoUsuario)) ]
public virtual IList<ModuloSeguridad_grupoUsuario> ModuloSeguridad_grupoUsuarios 
{
get
{
 if (_moduloSeguridad_grupoUsuarios == null) _moduloSeguridad_grupoUsuarios = new List<ModuloSeguridad_grupoUsuario>();

return _moduloSeguridad_grupoUsuarios;
}
set 
{
if ( _moduloSeguridad_grupoUsuarios != value) 
{
_moduloSeguridad_grupoUsuarios = value ;
}
}
}

/// <summary>
/// Collection of ModuloSeguridad_usuario.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "ca613933-9b52-4bbf-a864-1f49175c03b9" , CollectionOfType = typeof(ModuloSeguridad_usuario)) ]
public virtual IList<ModuloSeguridad_usuario> ModuloSeguridad_usuarios 
{
get
{
 if (_moduloSeguridad_usuarios == null) _moduloSeguridad_usuarios = new List<ModuloSeguridad_usuario>();

return _moduloSeguridad_usuarios;
}
set 
{
if ( _moduloSeguridad_usuarios != value) 
{
_moduloSeguridad_usuarios = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_moduloSeguridad_grupoSeguridad
/// </summary>
[GenWiseAttribute(RelationID = "bb84e982-03e0-4e75-bc85-b5350874f44b") ]
public virtual GrupoSeguridad GrupoSeguridad 
{
get
{
if ( _grupoSeguridad == null ) 
{
if ( !_codGrupoSeguridad.HasValue || _codGrupoSeguridad.Value.Equals(System.Int32.MinValue) ) 
{
if ( _grupoSeguridad != null && ( _grupoSeguridad.CodGrupoSeguridad.Equals(null) ) )
{
  _grupoSeguridad = null;
}
}
else
{
_grupoSeguridad = (new GrupoSeguridadFactory()).Get(_codGrupoSeguridad.Value);
}
}

return _grupoSeguridad;
}
set 
{
if ( _grupoSeguridad != value) 
{
if ( value==null ) _codGrupoSeguridad = null; else _codGrupoSeguridad = (System.Int32)value.CodGrupoSeguridad; 
_grupoSeguridad = value ;
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
/// Create a new ModuloSeguridad object. 
/// </summary>
public  ModuloSeguridad()
{
_codModuloSeguridad = System.Int32.MinValue;

}

/// <summary>
/// Add a new ModuloSeguridad_grupoUsuario object and automatically associate it with this instance as it's parent. This method makes easier to add new children and ensures you do not forget to related them correctly.
/// </summary>
///<param name="pModuloSeguridad_grupoUsuario">An ModuloSeguridad_grupoUsuario object to be added to this objects collection.</param>
public virtual void AddModuloSeguridad_grupoUsuario(ModuloSeguridad_grupoUsuario pModuloSeguridad_grupoUsuario)
{
if( pModuloSeguridad_grupoUsuario == null  ) throw new ArgumentNullException("pModuloSeguridad_grupoUsuario");
// Set the Parent Property
pModuloSeguridad_grupoUsuario.ModuloSeguridad = this;
if (!pModuloSeguridad_grupoUsuario.IsValid) { throw new Exception("pModuloSeguridad_grupoUsuario failed on the Validate() method." + Error.ErrorsToString( pModuloSeguridad_grupoUsuario.Validate() ) ); }
ModuloSeguridad_grupoUsuarios.Add(pModuloSeguridad_grupoUsuario);
}

/// <summary>
/// Delete an existing ModuloSeguridad_grupoUsuario object + remove the association it with this instance as it's parent. This method makes easier to add new children and ensures you do not forget to related them correctly.
/// </summary>
///<param name="pModuloSeguridad_grupoUsuario">The ModuloSeguridad_grupoUsuario object to be removed from this objects collection.</param>
public virtual void DeleteModuloSeguridad_grupoUsuarios(ModuloSeguridad_grupoUsuario pModuloSeguridad_grupoUsuario)
{
if( pModuloSeguridad_grupoUsuario == null  ) throw new ArgumentNullException("pModuloSeguridad_grupoUsuario");
ModuloSeguridad_grupoUsuarios.Remove(pModuloSeguridad_grupoUsuario);
// Remove the Association with the Parent object
pModuloSeguridad_grupoUsuario.ModuloSeguridad = null;
}

/// <summary>
/// Add a new ModuloSeguridad_usuario object and automatically associate it with this instance as it's parent. This method makes easier to add new children and ensures you do not forget to related them correctly.
/// </summary>
///<param name="pModuloSeguridad_usuario">An ModuloSeguridad_usuario object to be added to this objects collection.</param>
public virtual void AddModuloSeguridad_usuario(ModuloSeguridad_usuario pModuloSeguridad_usuario)
{
if( pModuloSeguridad_usuario == null  ) throw new ArgumentNullException("pModuloSeguridad_usuario");
// Set the Parent Property
pModuloSeguridad_usuario.ModuloSeguridad = this;
if (!pModuloSeguridad_usuario.IsValid) { throw new Exception("pModuloSeguridad_usuario failed on the Validate() method." + Error.ErrorsToString( pModuloSeguridad_usuario.Validate() ) ); }
ModuloSeguridad_usuarios.Add(pModuloSeguridad_usuario);
}

/// <summary>
/// Delete an existing ModuloSeguridad_usuario object + remove the association it with this instance as it's parent. This method makes easier to add new children and ensures you do not forget to related them correctly.
/// </summary>
///<param name="pModuloSeguridad_usuario">The ModuloSeguridad_usuario object to be removed from this objects collection.</param>
public virtual void DeleteModuloSeguridad_usuarios(ModuloSeguridad_usuario pModuloSeguridad_usuario)
{
if( pModuloSeguridad_usuario == null  ) throw new ArgumentNullException("pModuloSeguridad_usuario");
ModuloSeguridad_usuarios.Remove(pModuloSeguridad_usuario);
// Remove the Association with the Parent object
pModuloSeguridad_usuario.ModuloSeguridad = null;
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

