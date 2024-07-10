using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class GrupoSeguridad : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codGrupoSeguridad;
private System.String _descripcion;
private System.Boolean? _esDeshabilitado;
private IList<GrupoSeguridad_grupoUsuario> _grupoSeguridad_grupoUsuarios;
private IList<GrupoSeguridad_usuario> _grupoSeguridad_usuarios;
private IList<ModuloSeguridad> _moduloSeguridads;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodGrupoSeguridad 
{
get
{
return _codGrupoSeguridad;
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
/// Collection of GrupoSeguridad_grupoUsuario.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "7314ab2a-17c9-4146-a3f1-5c0524226bca" , CollectionOfType = typeof(GrupoSeguridad_grupoUsuario)) ]
public virtual IList<GrupoSeguridad_grupoUsuario> GrupoSeguridad_grupoUsuarios 
{
get
{
 if (_grupoSeguridad_grupoUsuarios == null) _grupoSeguridad_grupoUsuarios = new List<GrupoSeguridad_grupoUsuario>();

return _grupoSeguridad_grupoUsuarios;
}
set 
{
if ( _grupoSeguridad_grupoUsuarios != value) 
{
_grupoSeguridad_grupoUsuarios = value ;
}
}
}

/// <summary>
/// Collection of GrupoSeguridad_usuario.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "498005b0-4758-462c-ae80-b35f2be85604" , CollectionOfType = typeof(GrupoSeguridad_usuario)) ]
public virtual IList<GrupoSeguridad_usuario> GrupoSeguridad_usuarios 
{
get
{
 if (_grupoSeguridad_usuarios == null) _grupoSeguridad_usuarios = new List<GrupoSeguridad_usuario>();

return _grupoSeguridad_usuarios;
}
set 
{
if ( _grupoSeguridad_usuarios != value) 
{
_grupoSeguridad_usuarios = value ;
}
}
}

/// <summary>
/// Collection of ModuloSeguridad.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "bb84e982-03e0-4e75-bc85-b5350874f44b" , CollectionOfType = typeof(ModuloSeguridad)) ]
public virtual IList<ModuloSeguridad> ModuloSeguridads 
{
get
{
 if (_moduloSeguridads == null) _moduloSeguridads = new List<ModuloSeguridad>();

return _moduloSeguridads;
}
set 
{
if ( _moduloSeguridads != value) 
{
_moduloSeguridads = value ;
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
/// Create a new GrupoSeguridad object. 
/// </summary>
public  GrupoSeguridad()
{
_codGrupoSeguridad = System.Int32.MinValue;

}

/// <summary>
/// Add a new GrupoSeguridad_grupoUsuario object and automatically associate it with this instance as it's parent. This method makes easier to add new children and ensures you do not forget to related them correctly.
/// </summary>
///<param name="pGrupoSeguridad_grupoUsuario">An GrupoSeguridad_grupoUsuario object to be added to this objects collection.</param>
public virtual void AddGrupoSeguridad_grupoUsuario(GrupoSeguridad_grupoUsuario pGrupoSeguridad_grupoUsuario)
{
if( pGrupoSeguridad_grupoUsuario == null  ) throw new ArgumentNullException("pGrupoSeguridad_grupoUsuario");
// Set the Parent Property
pGrupoSeguridad_grupoUsuario.GrupoSeguridad = this;
if (!pGrupoSeguridad_grupoUsuario.IsValid) { throw new Exception("pGrupoSeguridad_grupoUsuario failed on the Validate() method." + Error.ErrorsToString( pGrupoSeguridad_grupoUsuario.Validate() ) ); }
GrupoSeguridad_grupoUsuarios.Add(pGrupoSeguridad_grupoUsuario);
}

/// <summary>
/// Delete an existing GrupoSeguridad_grupoUsuario object + remove the association it with this instance as it's parent. This method makes easier to add new children and ensures you do not forget to related them correctly.
/// </summary>
///<param name="pGrupoSeguridad_grupoUsuario">The GrupoSeguridad_grupoUsuario object to be removed from this objects collection.</param>
public virtual void DeleteGrupoSeguridad_grupoUsuarios(GrupoSeguridad_grupoUsuario pGrupoSeguridad_grupoUsuario)
{
if( pGrupoSeguridad_grupoUsuario == null  ) throw new ArgumentNullException("pGrupoSeguridad_grupoUsuario");
GrupoSeguridad_grupoUsuarios.Remove(pGrupoSeguridad_grupoUsuario);
// Remove the Association with the Parent object
pGrupoSeguridad_grupoUsuario.GrupoSeguridad = null;
}

/// <summary>
/// Add a new GrupoSeguridad_usuario object and automatically associate it with this instance as it's parent. This method makes easier to add new children and ensures you do not forget to related them correctly.
/// </summary>
///<param name="pGrupoSeguridad_usuario">An GrupoSeguridad_usuario object to be added to this objects collection.</param>
public virtual void AddGrupoSeguridad_usuario(GrupoSeguridad_usuario pGrupoSeguridad_usuario)
{
if( pGrupoSeguridad_usuario == null  ) throw new ArgumentNullException("pGrupoSeguridad_usuario");
// Set the Parent Property
pGrupoSeguridad_usuario.GrupoSeguridad = this;
if (!pGrupoSeguridad_usuario.IsValid) { throw new Exception("pGrupoSeguridad_usuario failed on the Validate() method." + Error.ErrorsToString( pGrupoSeguridad_usuario.Validate() ) ); }
GrupoSeguridad_usuarios.Add(pGrupoSeguridad_usuario);
}

/// <summary>
/// Delete an existing GrupoSeguridad_usuario object + remove the association it with this instance as it's parent. This method makes easier to add new children and ensures you do not forget to related them correctly.
/// </summary>
///<param name="pGrupoSeguridad_usuario">The GrupoSeguridad_usuario object to be removed from this objects collection.</param>
public virtual void DeleteGrupoSeguridad_usuarios(GrupoSeguridad_usuario pGrupoSeguridad_usuario)
{
if( pGrupoSeguridad_usuario == null  ) throw new ArgumentNullException("pGrupoSeguridad_usuario");
GrupoSeguridad_usuarios.Remove(pGrupoSeguridad_usuario);
// Remove the Association with the Parent object
pGrupoSeguridad_usuario.GrupoSeguridad = null;
}

/// <summary>
/// Add a new ModuloSeguridad object and automatically associate it with this instance as it's parent. This method makes easier to add new children and ensures you do not forget to related them correctly.
/// </summary>
///<param name="pModuloSeguridad">An ModuloSeguridad object to be added to this objects collection.</param>
public virtual void AddModuloSeguridad(ModuloSeguridad pModuloSeguridad)
{
if( pModuloSeguridad == null  ) throw new ArgumentNullException("pModuloSeguridad");
// Set the Parent Property
pModuloSeguridad.GrupoSeguridad = this;
if (!pModuloSeguridad.IsValid) { throw new Exception("pModuloSeguridad failed on the Validate() method." + Error.ErrorsToString( pModuloSeguridad.Validate() ) ); }
ModuloSeguridads.Add(pModuloSeguridad);
}

/// <summary>
/// Delete an existing ModuloSeguridad object + remove the association it with this instance as it's parent. This method makes easier to add new children and ensures you do not forget to related them correctly.
/// </summary>
///<param name="pModuloSeguridad">The ModuloSeguridad object to be removed from this objects collection.</param>
public virtual void DeleteModuloSeguridads(ModuloSeguridad pModuloSeguridad)
{
if( pModuloSeguridad == null  ) throw new ArgumentNullException("pModuloSeguridad");
ModuloSeguridads.Remove(pModuloSeguridad);
// Remove the Association with the Parent object
pModuloSeguridad.GrupoSeguridad = null;
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
// Call Validator IsRequired for Column : descripcion(Type:Required Field Validator)
_error = this.ValidatedescripcionIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : descripcion
/// </remarks>
public virtual Error ValidatedescripcionIsRequired()
{
if ( String.IsNullOrEmpty(Descripcion) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "descripcion is required and therefore must have a value." ;
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

