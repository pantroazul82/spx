using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class GruposUsuario : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _codGruposUsu;
private System.String _nombreGru;
private System.String _descripcionGru;
private IList<GruposCopiaOcultaxSmtpAccion> _gruposCopiaOcultaxSmtpAccions;
private IList<GruposCopiaxSmtpAccion> _gruposCopiaxSmtpAccions;
private IList<GruposModulosxGruposUsuario> _gruposModulosxGruposUsuarios;
private IList<GruposUsuariosxUsuario> _gruposUsuariosxUsuarios;
private IList<GruposXgrupo> _gruposXgrupos;
private IList<GruposXgrupo> _gruposXgrupos1;
private IList<GruposxSmtpAccion> _gruposxSmtpAccions;
private IList<ModulosxGruposUsuario> _modulosxGruposUsuarios;

#endregion


#region --- Class Properties ---

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

public virtual System.String NombreGru 
{
get
{
return _nombreGru;
}
set 
{
if ( _nombreGru != value) 
{
_nombreGru = value ;
OnPropertyChanged("NombreGru");
}
}
}

public virtual System.String DescripcionGru 
{
get
{
return _descripcionGru;
}
set 
{
if ( _descripcionGru != value) 
{
_descripcionGru = value ;
OnPropertyChanged("DescripcionGru");
}
}
}

/// <summary>
/// Collection of GruposCopiaOcultaxSmtpAccion.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "15d012fc-ae01-4e76-af65-217b4ab2c54e" , CollectionOfType = typeof(GruposCopiaOcultaxSmtpAccion)) ]
public virtual IList<GruposCopiaOcultaxSmtpAccion> GruposCopiaOcultaxSmtpAccions 
{
get
{
 if (_gruposCopiaOcultaxSmtpAccions == null) _gruposCopiaOcultaxSmtpAccions = new List<GruposCopiaOcultaxSmtpAccion>();

return _gruposCopiaOcultaxSmtpAccions;
}
set 
{
if ( _gruposCopiaOcultaxSmtpAccions != value) 
{
_gruposCopiaOcultaxSmtpAccions = value ;
}
}
}

/// <summary>
/// Collection of GruposCopiaxSmtpAccion.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "375b4cad-bcae-487c-b12a-5c234ea1b77d" , CollectionOfType = typeof(GruposCopiaxSmtpAccion)) ]
public virtual IList<GruposCopiaxSmtpAccion> GruposCopiaxSmtpAccions 
{
get
{
 if (_gruposCopiaxSmtpAccions == null) _gruposCopiaxSmtpAccions = new List<GruposCopiaxSmtpAccion>();

return _gruposCopiaxSmtpAccions;
}
set 
{
if ( _gruposCopiaxSmtpAccions != value) 
{
_gruposCopiaxSmtpAccions = value ;
}
}
}

/// <summary>
/// Collection of GruposModulosxGruposUsuario.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "2a8f1acc-dc10-4597-8a92-f42e73f63c20" , CollectionOfType = typeof(GruposModulosxGruposUsuario)) ]
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
/// Collection of GruposUsuariosxUsuario.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "d5532cb6-4439-43fc-8d43-3e423a2e3e8b" , CollectionOfType = typeof(GruposUsuariosxUsuario)) ]
public virtual IList<GruposUsuariosxUsuario> GruposUsuariosxUsuarios 
{
get
{
 if (_gruposUsuariosxUsuarios == null) _gruposUsuariosxUsuarios = new List<GruposUsuariosxUsuario>();

return _gruposUsuariosxUsuarios;
}
set 
{
if ( _gruposUsuariosxUsuarios != value) 
{
_gruposUsuariosxUsuarios = value ;
}
}
}

/// <summary>
/// Collection of GruposXgrupo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "3c8236ef-5f88-4021-bac7-778bc7745202" , CollectionOfType = typeof(GruposXgrupo)) ]
public virtual IList<GruposXgrupo> GruposXgrupos 
{
get
{
 if (_gruposXgrupos == null) _gruposXgrupos = new List<GruposXgrupo>();

return _gruposXgrupos;
}
set 
{
if ( _gruposXgrupos != value) 
{
_gruposXgrupos = value ;
}
}
}

/// <summary>
/// Collection of GruposXgrupo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "69394da2-4b02-47f9-965c-6997548006f5" , CollectionOfType = typeof(GruposXgrupo)) ]
public virtual IList<GruposXgrupo> GruposXgrupos1 
{
get
{
 if (_gruposXgrupos1 == null) _gruposXgrupos1 = new List<GruposXgrupo>();

return _gruposXgrupos1;
}
set 
{
if ( _gruposXgrupos1 != value) 
{
_gruposXgrupos1 = value ;
}
}
}

/// <summary>
/// Collection of GruposxSmtpAccion.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "6c9374b2-4c59-48d4-8437-3be77f49eb2f" , CollectionOfType = typeof(GruposxSmtpAccion)) ]
public virtual IList<GruposxSmtpAccion> GruposxSmtpAccions 
{
get
{
 if (_gruposxSmtpAccions == null) _gruposxSmtpAccions = new List<GruposxSmtpAccion>();

return _gruposxSmtpAccions;
}
set 
{
if ( _gruposxSmtpAccions != value) 
{
_gruposxSmtpAccions = value ;
}
}
}

/// <summary>
/// Collection of ModulosxGruposUsuario.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "ce2d1a3e-638b-498f-b185-e19721bbc226" , CollectionOfType = typeof(ModulosxGruposUsuario)) ]
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
/// Create a new GruposUsuario object. 
/// </summary>
public  GruposUsuario()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  GruposUsuario(System.String pCodGruposUsu)
{
_codGruposUsu = pCodGruposUsu ;

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
// Call Validator IsRequired for Column : codGruposUsu(Type:Required Field Validator)
_error = this.ValidatecodGruposUsuIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : nombreGru(Type:Required Field Validator)
_error = this.ValidatenombreGruIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
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

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : nombreGru
/// </remarks>
public virtual Error ValidatenombreGruIsRequired()
{
if ( String.IsNullOrEmpty(NombreGru) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "nombreGru is required and therefore must have a value." ;
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

