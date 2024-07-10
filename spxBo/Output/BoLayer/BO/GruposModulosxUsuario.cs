using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class GruposModulosxUsuario : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _codGrupoModulo;
private System.String _login;
private System.Boolean? _controlTotal;
private System.Boolean? _modificar;
private System.Boolean? _lecturaEjecucion;
private System.Boolean? _escribir;
private System.Boolean? _eliminar;
private System.Boolean? _imprimir;
private System.Boolean? _denegar;
private GruposModulo _gruposModulo;
private Usuario0 _usuario0;

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

public virtual System.String Login 
{
get
{
return _login;
}
set 
{
if ( _login != value) 
{
_login = value ;
OnPropertyChanged("Login");
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
/// Generated from Relation FK_gruposModulosxUsuario_gruposModulos
/// </summary>
[GenWiseAttribute(RelationID = "891f3930-4aeb-4eb2-b2cc-1008d6d731bb") ]
public virtual GruposModulo GruposModulo 
{
get
{
if ( _gruposModulo == null ) 
{
if ( String.IsNullOrEmpty(_codGrupoModulo) || _codGrupoModulo.Equals(string.Empty) ) 
{
if ( _gruposModulo != null && ( _gruposModulo.CodGrupoModulo.Equals(string.Empty) ) )
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
if ( value==null ) _codGrupoModulo = string.Empty; else _codGrupoModulo = (System.String)value.CodGrupoModulo; 
_gruposModulo = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_gruposModulosxUsuario_usuarios
/// </summary>
[GenWiseAttribute(RelationID = "838fa8bf-e1cd-4d5b-a245-b370d7f2d0d9") ]
public virtual Usuario0 Usuario0 
{
get
{
if ( _usuario0 == null ) 
{
if ( String.IsNullOrEmpty(_login) || _login.Equals(string.Empty) ) 
{
if ( _usuario0 != null && ( _usuario0.Login.Equals(string.Empty) ) )
{
  _usuario0 = null;
}
}
else
{
_usuario0 = (new Usuario0Factory()).Get(_login);
}
}

return _usuario0;
}
set 
{
if ( _usuario0 != value) 
{
if ( value==null ) _login = string.Empty; else _login = (System.String)value.Login; 
_usuario0 = value ;
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

if ( CodGrupoModulo != null ) _retValue += CodGrupoModulo.ToString();

_retValue += "^";
if ( Login != null ) _retValue += Login.ToString();

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
/// Create a new GruposModulosxUsuario object. 
/// </summary>
public  GruposModulosxUsuario()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  GruposModulosxUsuario(System.String pCodGrupoModulo , System.String pLogin)
{
_codGrupoModulo = pCodGrupoModulo ;
_login = pLogin ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
if ( CodGrupoModulo != null ) _hash += CodGrupoModulo.ToString();
if ( Login != null ) _hash += Login.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
GruposModulosxUsuario _newGruposModulosxUsuario = (pObject as GruposModulosxUsuario); 
if (_newGruposModulosxUsuario == null ) return false; 
if (_newGruposModulosxUsuario.GetHashCode() == this.GetHashCode() ) return true; 
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
// Call Validator IsRequired for Column : codGrupoModulo(Type:Required Field Validator)
_error = this.ValidatecodGrupoModuloIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : login(Type:Required Field Validator)
_error = this.ValidateloginIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(CodGrupoModulo) ) 
{
   _errors.Add( new Error( "The PK Column (codGrupoModulo) can not be null!. " ) );
}
if ( String.IsNullOrEmpty(Login) ) 
{
   _errors.Add( new Error( "The PK Column (login) can not be null!. " ) );
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

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : login
/// </remarks>
public virtual Error ValidateloginIsRequired()
{
if ( String.IsNullOrEmpty(Login) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "login is required and therefore must have a value." ;
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

