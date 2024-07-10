using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class Usuario : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codUsuario;
private System.String _login;
private System.String _nombre;
private System.String _password;
private System.Boolean? _esBloqueado;
private System.Boolean? _esDeshabilitado;
private System.String _correo;
private System.Int32? _intentos;
private System.DateTime? _fechaCambioPassword;
private System.String _cedula;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodUsuario 
{
get
{
return _codUsuario;
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

public virtual System.String Nombre 
{
get
{
return _nombre;
}
set 
{
if ( _nombre != value) 
{
_nombre = value ;
OnPropertyChanged("Nombre");
}
}
}

public virtual System.String Password 
{
get
{
return _password;
}
set 
{
if ( _password != value) 
{
_password = value ;
OnPropertyChanged("Password");
}
}
}

public virtual System.Boolean? EsBloqueado 
{
get
{
return _esBloqueado;
}
set 
{
if ( _esBloqueado != value) 
{
_esBloqueado = value ;
OnPropertyChanged("EsBloqueado");
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

public virtual System.String Correo 
{
get
{
return _correo;
}
set 
{
if ( _correo != value) 
{
_correo = value ;
OnPropertyChanged("Correo");
}
}
}

public virtual System.Int32? Intentos 
{
get
{
return _intentos;
}
set 
{
if ( _intentos != value) 
{
_intentos = value ;
OnPropertyChanged("Intentos");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaCambioPassword_Date 
{
get
{
if (  !FechaCambioPassword.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaCambioPassword.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaCambioPassword.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaCambioPassword_Time)) {

FechaCambioPassword = null;
}
 else
{
 FechaCambioPassword = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaCambioPassword.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaCambioPassword_Time)) 
{
 FechaCambioPassword = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaCambioPassword = Convert.ToDateTime( " " + value + " " + FechaCambioPassword.Value.ToString("HH:mm:ss.fff") ) ;
}
}

}
}

/// <summary>
/// This property contains a calculated, bindable value of the TIME part of a DateTime property. If you want to only work with the TIME and ignore the underlying DATE component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaCambioPassword_Time 
{
get
{
if (  !FechaCambioPassword.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaCambioPassword.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaCambioPassword.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaCambioPassword_Date)) 
{
FechaCambioPassword = null;
}
 else
{
 FechaCambioPassword = Convert.ToDateTime( " " + FechaCambioPassword.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaCambioPassword_Date)) 
{
 FechaCambioPassword = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaCambioPassword = Convert.ToDateTime( " " + FechaCambioPassword_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaCambioPassword 
{
get
{
return _fechaCambioPassword;
}
set 
{
if ( _fechaCambioPassword != value) 
{
_fechaCambioPassword = value ;
OnPropertyChanged("FechaCambioPassword");
}
}
}

public virtual System.String Cedula 
{
get
{
return _cedula;
}
set 
{
if ( _cedula != value) 
{
_cedula = value ;
OnPropertyChanged("Cedula");
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
/// Create a new Usuario object. 
/// </summary>
public  Usuario()
{
_codUsuario = System.Int32.MinValue;

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
// Call Validator IsRequired for Column : nombre(Type:Required Field Validator)
_error = this.ValidatenombreIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : password(Type:Required Field Validator)
_error = this.ValidatepasswordIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
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

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : nombre
/// </remarks>
public virtual Error ValidatenombreIsRequired()
{
if ( String.IsNullOrEmpty(Nombre) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "nombre is required and therefore must have a value." ;
 return _error;
}
 return null;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : password
/// </remarks>
public virtual Error ValidatepasswordIsRequired()
{
if ( String.IsNullOrEmpty(Password) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "password is required and therefore must have a value." ;
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

