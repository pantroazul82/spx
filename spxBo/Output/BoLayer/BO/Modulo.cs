using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class Modulo : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _codModulo;
private System.String _codGrupoModulo;
private System.String _nombreMod;
private System.String _linkMod;
private System.String _descripcionMod;
private System.Boolean? _esDeshabilitado;
private IList<ModulosxGruposUsuario> _modulosxGruposUsuarios;
private IList<ModulosxUsuario> _modulosxUsuarios;
private GruposModulo _gruposModulo;

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

public virtual System.String CodGrupoModulo 
{
get
{
if ( GruposModulo != null ) 
{
_codGrupoModulo = (System.String)GruposModulo.CodGrupoModulo;
}

return _codGrupoModulo;
}
set 
{
if ( _codGrupoModulo != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_gruposModulo = null;

_codGrupoModulo = value ;
OnPropertyChanged("CodGrupoModulo");
}
}
}

public virtual System.String NombreMod 
{
get
{
return _nombreMod;
}
set 
{
if ( _nombreMod != value) 
{
_nombreMod = value ;
OnPropertyChanged("NombreMod");
}
}
}

public virtual System.String LinkMod 
{
get
{
return _linkMod;
}
set 
{
if ( _linkMod != value) 
{
_linkMod = value ;
OnPropertyChanged("LinkMod");
}
}
}

public virtual System.String DescripcionMod 
{
get
{
return _descripcionMod;
}
set 
{
if ( _descripcionMod != value) 
{
_descripcionMod = value ;
OnPropertyChanged("DescripcionMod");
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
/// Collection of ModulosxGruposUsuario.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "cf1f8c85-3d9d-4dff-8ea9-f950b4c29769" , CollectionOfType = typeof(ModulosxGruposUsuario)) ]
public virtual IList<ModulosxGruposUsuario> ModulosxGruposUsuarios 
{
get
{
 if (_modulosxGruposUsuarios == null) _modulosxGruposUsuarios = new List<ModulosxGruposUsuario>();

return _modulosxGruposUsuarios;
}
set 
{
if ( _modulosxGruposUsuarios != value) 
{
_modulosxGruposUsuarios = value ;
}
}
}

/// <summary>
/// Collection of ModulosxUsuario.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "49d815ef-d957-43cc-b467-5326dcb05ab3" , CollectionOfType = typeof(ModulosxUsuario)) ]
public virtual IList<ModulosxUsuario> ModulosxUsuarios 
{
get
{
 if (_modulosxUsuarios == null) _modulosxUsuarios = new List<ModulosxUsuario>();

return _modulosxUsuarios;
}
set 
{
if ( _modulosxUsuarios != value) 
{
_modulosxUsuarios = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_modulos_gruposModulos
/// </summary>
[GenWiseAttribute(RelationID = "c863cd0e-7092-4ae6-a068-9ad337d7844c") ]
public virtual GruposModulo GruposModulo 
{
get
{
if ( _gruposModulo == null ) 
{
if ( String.IsNullOrEmpty(_codGrupoModulo) || _codGrupoModulo.Equals(string.Empty) ) 
{
if ( _gruposModulo != null && ( _gruposModulo.CodGrupoModulo.Equals(null) ) )
{
  _gruposModulo = null;
}
}
else
{
_gruposModulo = (new GruposModuloFactory()).Get(_codGrupoModulo);
}
}

return _gruposModulo;
}
set 
{
if ( _gruposModulo != value) 
{
if ( value==null ) _codGrupoModulo = null; else _codGrupoModulo = (System.String)value.CodGrupoModulo; 
_gruposModulo = value ;
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
/// Create a new Modulo object. 
/// </summary>
public  Modulo()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  Modulo(System.String pCodModulo)
{
_codModulo = pCodModulo ;

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
// Call Validator IsRequired for Column : nombreMod(Type:Required Field Validator)
_error = this.ValidatenombreModIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(CodModulo) ) 
{
   _errors.Add( new Error( "The PK Column (codModulo) can not be null!. " ) );
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
/// This method was automatically generated based on the DataBase Repository Validations for the Column : nombreMod
/// </remarks>
public virtual Error ValidatenombreModIsRequired()
{
if ( String.IsNullOrEmpty(NombreMod) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "nombreMod is required and therefore must have a value." ;
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

