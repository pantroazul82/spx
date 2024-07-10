using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class UsuarioxSmtpAccion : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _login;
private System.Int32 _idCgSmtpAccion;
private System.Boolean? _enviarSoloPropietario;
private CgSmtpAccion _cgSmtpAccion;
private Usuario0 _usuario0;

#endregion


#region --- Class Properties ---

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

public virtual System.Boolean? EnviarSoloPropietario 
{
get
{
return _enviarSoloPropietario;
}
set 
{
if ( _enviarSoloPropietario != value) 
{
_enviarSoloPropietario = value ;
OnPropertyChanged("EnviarSoloPropietario");
}
}
}

/// <summary>
/// Generated from Relation FK_usuarioxSmtpAccion_cgSmtpAccion
/// </summary>
[GenWiseAttribute(RelationID = "ec649f36-6416-4b14-9b1b-5839b3b1d075") ]
public virtual CgSmtpAccion CgSmtpAccion 
{
get
{
if ( _cgSmtpAccion == null ) 
{
if (  _idCgSmtpAccion.Equals(0)  || _idCgSmtpAccion.Equals(System.Int32.MinValue) ) 
{
if ( _cgSmtpAccion != null && ( _cgSmtpAccion.IdCgSmtpAccion.Equals(System.Int32.MinValue) ) )
{
  _cgSmtpAccion = null;
}
}
else
{
_cgSmtpAccion = (new CgSmtpAccionFactory()).Get(_idCgSmtpAccion);
}
}

return _cgSmtpAccion;
}
set 
{
if ( _cgSmtpAccion != value) 
{
if ( value==null ) _idCgSmtpAccion = System.Int32.MinValue; else _idCgSmtpAccion = (System.Int32)value.IdCgSmtpAccion; 
_cgSmtpAccion = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_usuarioxSmtpAccion_usuarios
/// </summary>
[GenWiseAttribute(RelationID = "e33f5d70-264d-4ed3-8ed5-94f97d77bc80") ]
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

if ( Login != null ) _retValue += Login.ToString();

_retValue += "^";
_retValue += IdCgSmtpAccion.ToString();

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
/// Create a new UsuarioxSmtpAccion object. 
/// </summary>
public  UsuarioxSmtpAccion()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  UsuarioxSmtpAccion(System.String pLogin , System.Int32 pIdCgSmtpAccion)
{
_login = pLogin ;
_idCgSmtpAccion = pIdCgSmtpAccion ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
if ( Login != null ) _hash += Login.ToString();
_hash += IdCgSmtpAccion.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
UsuarioxSmtpAccion _newUsuarioxSmtpAccion = (pObject as UsuarioxSmtpAccion); 
if (_newUsuarioxSmtpAccion == null ) return false; 
if (_newUsuarioxSmtpAccion.GetHashCode() == this.GetHashCode() ) return true; 
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
// Call Validator IsRequired for Column : login(Type:Required Field Validator)
_error = this.ValidateloginIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(Login) ) 
{
   _errors.Add( new Error( "The PK Column (login) can not be null!. " ) );
}
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

