using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class CgSmtpAccion : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _idCgSmtpAccion;
private System.String _nombreAccion;
private System.String _descripcion;
private System.String _cuerpoEmail;
private System.String _asunto;
private IList<GruposCopiaOcultaxSmtpAccion> _gruposCopiaOcultaxSmtpAccions;
private IList<GruposCopiaxSmtpAccion> _gruposCopiaxSmtpAccions;
private IList<GruposxSmtpAccion> _gruposxSmtpAccions;
private IList<ParametrosxCgSmtpAccion> _parametrosxCgSmtpAccions;
private IList<UsuarioCopiaOcultaxSmtpAccion> _usuarioCopiaOcultaxSmtpAccions;
private IList<UsuarioCopiaxSmtpAccion> _usuarioCopiaxSmtpAccions;
private IList<UsuarioxSmtpAccion> _usuarioxSmtpAccions;

#endregion


#region --- Class Properties ---

public virtual System.Int32 IdCgSmtpAccion 
{
get
{
return _idCgSmtpAccion;
}
set 
{
if ( _idCgSmtpAccion != value) 
{
_idCgSmtpAccion = value ;
OnPropertyChanged("IdCgSmtpAccion");
}
}
}

public virtual System.String NombreAccion 
{
get
{
return _nombreAccion;
}
set 
{
if ( _nombreAccion != value) 
{
_nombreAccion = value ;
OnPropertyChanged("NombreAccion");
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

public virtual System.String CuerpoEmail 
{
get
{
return _cuerpoEmail;
}
set 
{
if ( _cuerpoEmail != value) 
{
_cuerpoEmail = value ;
OnPropertyChanged("CuerpoEmail");
}
}
}

public virtual System.String Asunto 
{
get
{
return _asunto;
}
set 
{
if ( _asunto != value) 
{
_asunto = value ;
OnPropertyChanged("Asunto");
}
}
}

/// <summary>
/// Collection of GruposCopiaOcultaxSmtpAccion.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "6f48e148-a65d-41e4-a0af-7cf00675fb87" , CollectionOfType = typeof(GruposCopiaOcultaxSmtpAccion)) ]
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
[GenWiseAttribute(RelationID = "e9bbd3db-23c3-4010-85d1-8b1ed6a3dec2" , CollectionOfType = typeof(GruposCopiaxSmtpAccion)) ]
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
/// Collection of GruposxSmtpAccion.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "432d2786-8777-4d58-8848-19c6be61df63" , CollectionOfType = typeof(GruposxSmtpAccion)) ]
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
/// Collection of ParametrosxCgSmtpAccion.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "3dc00074-4e6a-40ca-a72d-5d4fb081dfdf" , CollectionOfType = typeof(ParametrosxCgSmtpAccion)) ]
public virtual IList<ParametrosxCgSmtpAccion> ParametrosxCgSmtpAccions 
{
get
{
 if (_parametrosxCgSmtpAccions == null) _parametrosxCgSmtpAccions = new List<ParametrosxCgSmtpAccion>();

return _parametrosxCgSmtpAccions;
}
set 
{
if ( _parametrosxCgSmtpAccions != value) 
{
_parametrosxCgSmtpAccions = value ;
}
}
}

/// <summary>
/// Collection of UsuarioCopiaOcultaxSmtpAccion.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "f13f7f5f-bd9f-4a1c-a437-0a69127fba91" , CollectionOfType = typeof(UsuarioCopiaOcultaxSmtpAccion)) ]
public virtual IList<UsuarioCopiaOcultaxSmtpAccion> UsuarioCopiaOcultaxSmtpAccions 
{
get
{
 if (_usuarioCopiaOcultaxSmtpAccions == null) _usuarioCopiaOcultaxSmtpAccions = new List<UsuarioCopiaOcultaxSmtpAccion>();

return _usuarioCopiaOcultaxSmtpAccions;
}
set 
{
if ( _usuarioCopiaOcultaxSmtpAccions != value) 
{
_usuarioCopiaOcultaxSmtpAccions = value ;
}
}
}

/// <summary>
/// Collection of UsuarioCopiaxSmtpAccion.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "4cd9fbee-5bcf-4781-9c2a-77a0a19b5e4b" , CollectionOfType = typeof(UsuarioCopiaxSmtpAccion)) ]
public virtual IList<UsuarioCopiaxSmtpAccion> UsuarioCopiaxSmtpAccions 
{
get
{
 if (_usuarioCopiaxSmtpAccions == null) _usuarioCopiaxSmtpAccions = new List<UsuarioCopiaxSmtpAccion>();

return _usuarioCopiaxSmtpAccions;
}
set 
{
if ( _usuarioCopiaxSmtpAccions != value) 
{
_usuarioCopiaxSmtpAccions = value ;
}
}
}

/// <summary>
/// Collection of UsuarioxSmtpAccion.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "ec649f36-6416-4b14-9b1b-5839b3b1d075" , CollectionOfType = typeof(UsuarioxSmtpAccion)) ]
public virtual IList<UsuarioxSmtpAccion> UsuarioxSmtpAccions 
{
get
{
 if (_usuarioxSmtpAccions == null) _usuarioxSmtpAccions = new List<UsuarioxSmtpAccion>();

return _usuarioxSmtpAccions;
}
set 
{
if ( _usuarioxSmtpAccions != value) 
{
_usuarioxSmtpAccions = value ;
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
/// Create a new CgSmtpAccion object. 
/// </summary>
public  CgSmtpAccion()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  CgSmtpAccion(System.Int32 pIdCgSmtpAccion)
{
_idCgSmtpAccion = pIdCgSmtpAccion ;

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
// Call Validator IsRequired for Column : nombreAccion(Type:Required Field Validator)
_error = this.ValidatenombreAccionIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if (  IdCgSmtpAccion.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (idCgSmtpAccion) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : nombreAccion
/// </remarks>
public virtual Error ValidatenombreAccionIsRequired()
{
if ( String.IsNullOrEmpty(NombreAccion) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "nombreAccion is required and therefore must have a value." ;
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

