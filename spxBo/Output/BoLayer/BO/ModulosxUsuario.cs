using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class ModulosxUsuario : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _codModulo;
private System.String _login;
private System.Boolean? _controlTotal;
private System.Boolean? _modificar;
private System.Boolean? _lecturaEjecucion;
private System.Boolean? _escribir;
private System.Boolean? _eliminar;
private System.Boolean? _imprimir;
private System.Boolean? _denegar;
private Modulo _modulo;
private Usuario0 _usuario0;

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
/// Generated from Relation FK_modulosxUsuario_modulos
/// </summary>
[GenWiseAttribute(RelationID = "49d815ef-d957-43cc-b467-5326dcb05ab3") ]
public virtual Modulo Modulo 
{
get
{
if ( _modulo == null ) 
{
if ( String.IsNullOrEmpty(_codModulo) || _codModulo.Equals(string.Empty) ) 
{
if ( _modulo != null && ( _modulo.CodModulo.Equals(string.Empty) ) )
{
  _modulo = null;
}
}
else
{
_modulo = (new ModuloFactory()).Get(_codModulo);
}
}

return _modulo;
}
set 
{
if ( _modulo != value) 
{
if ( value==null ) _codModulo = string.Empty; else _codModulo = (System.String)value.CodModulo; 
_modulo = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_modulosxUsuario_usuarios
/// </summary>
[GenWiseAttribute(RelationID = "91ef65a2-98f5-49f6-b64c-1afa2dea07fe") ]
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

if ( CodModulo != null ) _retValue += CodModulo.ToString();

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
/// Create a new ModulosxUsuario object. 
/// </summary>
public  ModulosxUsuario()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  ModulosxUsuario(System.String pCodModulo , System.String pLogin)
{
_codModulo = pCodModulo ;
_login = pLogin ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
if ( CodModulo != null ) _hash += CodModulo.ToString();
if ( Login != null ) _hash += Login.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
ModulosxUsuario _newModulosxUsuario = (pObject as ModulosxUsuario); 
if (_newModulosxUsuario == null ) return false; 
if (_newModulosxUsuario.GetHashCode() == this.GetHashCode() ) return true; 
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
// Call Validator IsRequired for Column : codModulo(Type:Required Field Validator)
_error = this.ValidatecodModuloIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : login(Type:Required Field Validator)
_error = this.ValidateloginIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(CodModulo) ) 
{
   _errors.Add( new Error( "The PK Column (codModulo) can not be null!. " ) );
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

