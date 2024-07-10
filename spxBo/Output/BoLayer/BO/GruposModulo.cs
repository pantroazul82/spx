using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class GruposModulo : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _codGrupoModulo;
private System.String _nombreGrupoModulo;
private System.String _descripcion;
private IList<GruposModulosxGruposUsuario> _gruposModulosxGruposUsuarios;
private IList<GruposModulosxUsuario> _gruposModulosxUsuarios;
private IList<Modulo> _modulos;

#endregion


#region --- Class Properties ---

public virtual System.String CodGrupoModulo 
{
get
{
return _codGrupoModulo;
}
set 
{
if ( _codGrupoModulo != value) 
{
_codGrupoModulo = value ;
OnPropertyChanged("CodGrupoModulo");
}
}
}

public virtual System.String NombreGrupoModulo 
{
get
{
return _nombreGrupoModulo;
}
set 
{
if ( _nombreGrupoModulo != value) 
{
_nombreGrupoModulo = value ;
OnPropertyChanged("NombreGrupoModulo");
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

/// <summary>
/// Collection of GruposModulosxGruposUsuario.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "8df6e06a-2d06-4b23-80df-2f20f7f2b34f" , CollectionOfType = typeof(GruposModulosxGruposUsuario)) ]
public virtual IList<GruposModulosxGruposUsuario> GruposModulosxGruposUsuarios 
{
get
{
 if (_gruposModulosxGruposUsuarios == null) _gruposModulosxGruposUsuarios = new List<GruposModulosxGruposUsuario>();

return _gruposModulosxGruposUsuarios;
}
set 
{
if ( _gruposModulosxGruposUsuarios != value) 
{
_gruposModulosxGruposUsuarios = value ;
}
}
}

/// <summary>
/// Collection of GruposModulosxUsuario.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "891f3930-4aeb-4eb2-b2cc-1008d6d731bb" , CollectionOfType = typeof(GruposModulosxUsuario)) ]
public virtual IList<GruposModulosxUsuario> GruposModulosxUsuarios 
{
get
{
 if (_gruposModulosxUsuarios == null) _gruposModulosxUsuarios = new List<GruposModulosxUsuario>();

return _gruposModulosxUsuarios;
}
set 
{
if ( _gruposModulosxUsuarios != value) 
{
_gruposModulosxUsuarios = value ;
}
}
}

/// <summary>
/// Collection of Modulo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "c863cd0e-7092-4ae6-a068-9ad337d7844c" , CollectionOfType = typeof(Modulo)) ]
public virtual IList<Modulo> Modulos 
{
get
{
 if (_modulos == null) _modulos = new List<Modulo>();

return _modulos;
}
set 
{
if ( _modulos != value) 
{
_modulos = value ;
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
/// Create a new GruposModulo object. 
/// </summary>
public  GruposModulo()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  GruposModulo(System.String pCodGrupoModulo)
{
_codGrupoModulo = pCodGrupoModulo ;

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
// Call Validator IsRequired for Column : codGrupoModulo(Type:Required Field Validator)
_error = this.ValidatecodGrupoModuloIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(CodGrupoModulo) ) 
{
   _errors.Add( new Error( "The PK Column (codGrupoModulo) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codGrupoModulo
/// </remarks>
public virtual Error ValidatecodGrupoModuloIsRequired()
{
if ( String.IsNullOrEmpty(CodGrupoModulo) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codGrupoModulo is required and therefore must have a value." ;
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

