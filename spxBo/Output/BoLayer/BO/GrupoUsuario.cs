using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class GrupoUsuario : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codGrupoUsuario;
private System.String _descripcion;
private System.Boolean? _esDeshabilitado;
private IList<GrupoSeguridad_grupoUsuario> _grupoSeguridad_grupoUsuarios;
private IList<GrupoUsuario_usuario> _grupoUsuario_usuarios;
private IList<ModuloSeguridad_grupoUsuario> _moduloSeguridad_grupoUsuarios;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodGrupoUsuario 
{
get
{
return _codGrupoUsuario;
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
[GenWiseAttribute(RelationID = "e90e87c9-9d95-4e03-80b2-e527afd5135b" , CollectionOfType = typeof(GrupoSeguridad_grupoUsuario)) ]
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
/// Collection of GrupoUsuario_usuario.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "a60a8b09-a9d5-418e-95ce-3c3c3c648a37" , CollectionOfType = typeof(GrupoUsuario_usuario)) ]
public virtual IList<GrupoUsuario_usuario> GrupoUsuario_usuarios 
{
get
{
 if (_grupoUsuario_usuarios == null) _grupoUsuario_usuarios = new List<GrupoUsuario_usuario>();

return _grupoUsuario_usuarios;
}
set 
{
if ( _grupoUsuario_usuarios != value) 
{
_grupoUsuario_usuarios = value ;
}
}
}

/// <summary>
/// Collection of ModuloSeguridad_grupoUsuario.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "7ab4d771-5ca3-4483-bdf0-d760d557cbf1" , CollectionOfType = typeof(ModuloSeguridad_grupoUsuario)) ]
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
/// Create a new GrupoUsuario object. 
/// </summary>
public  GrupoUsuario()
{
_codGrupoUsuario = System.Int32.MinValue;

}

/// <summary>
/// Add a new GrupoSeguridad_grupoUsuario object and automatically associate it with this instance as it's parent. This method makes easier to add new children and ensures you do not forget to related them correctly.
/// </summary>
///<param name="pGrupoSeguridad_grupoUsuario">An GrupoSeguridad_grupoUsuario object to be added to this objects collection.</param>
public virtual void AddGrupoSeguridad_grupoUsuario(GrupoSeguridad_grupoUsuario pGrupoSeguridad_grupoUsuario)
{
if( pGrupoSeguridad_grupoUsuario == null  ) throw new ArgumentNullException("pGrupoSeguridad_grupoUsuario");
// Set the Parent Property
pGrupoSeguridad_grupoUsuario.GrupoUsuario = this;
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
pGrupoSeguridad_grupoUsuario.GrupoUsuario = null;
}

/// <summary>
/// Add a new GrupoUsuario_usuario object and automatically associate it with this instance as it's parent. This method makes easier to add new children and ensures you do not forget to related them correctly.
/// </summary>
///<param name="pGrupoUsuario_usuario">An GrupoUsuario_usuario object to be added to this objects collection.</param>
public virtual void AddGrupoUsuario_usuario(GrupoUsuario_usuario pGrupoUsuario_usuario)
{
if( pGrupoUsuario_usuario == null  ) throw new ArgumentNullException("pGrupoUsuario_usuario");
// Set the Parent Property
pGrupoUsuario_usuario.GrupoUsuario = this;
if (!pGrupoUsuario_usuario.IsValid) { throw new Exception("pGrupoUsuario_usuario failed on the Validate() method." + Error.ErrorsToString( pGrupoUsuario_usuario.Validate() ) ); }
GrupoUsuario_usuarios.Add(pGrupoUsuario_usuario);
}

/// <summary>
/// Delete an existing GrupoUsuario_usuario object + remove the association it with this instance as it's parent. This method makes easier to add new children and ensures you do not forget to related them correctly.
/// </summary>
///<param name="pGrupoUsuario_usuario">The GrupoUsuario_usuario object to be removed from this objects collection.</param>
public virtual void DeleteGrupoUsuario_usuarios(GrupoUsuario_usuario pGrupoUsuario_usuario)
{
if( pGrupoUsuario_usuario == null  ) throw new ArgumentNullException("pGrupoUsuario_usuario");
GrupoUsuario_usuarios.Remove(pGrupoUsuario_usuario);
// Remove the Association with the Parent object
pGrupoUsuario_usuario.GrupoUsuario = null;
}

/// <summary>
/// Add a new ModuloSeguridad_grupoUsuario object and automatically associate it with this instance as it's parent. This method makes easier to add new children and ensures you do not forget to related them correctly.
/// </summary>
///<param name="pModuloSeguridad_grupoUsuario">An ModuloSeguridad_grupoUsuario object to be added to this objects collection.</param>
public virtual void AddModuloSeguridad_grupoUsuario(ModuloSeguridad_grupoUsuario pModuloSeguridad_grupoUsuario)
{
if( pModuloSeguridad_grupoUsuario == null  ) throw new ArgumentNullException("pModuloSeguridad_grupoUsuario");
// Set the Parent Property
pModuloSeguridad_grupoUsuario.GrupoUsuario = this;
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
pModuloSeguridad_grupoUsuario.GrupoUsuario = null;
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

