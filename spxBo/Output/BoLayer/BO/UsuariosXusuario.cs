using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class UsuariosXusuario : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _login;
private System.String _subordinadoDe;
private Usuario0 _usuario0;
private Usuario0 _usuario01;

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

public virtual System.String SubordinadoDe 
{
get
{
return _subordinadoDe;
}
set 
{
if ( _subordinadoDe != value) 
{
_subordinadoDe = value ;
OnPropertyChanged("SubordinadoDe");
}
}
}

/// <summary>
/// Generated from Relation FK_usuariosXusuarios_usuarios
/// </summary>
[GenWiseAttribute(RelationID = "84993998-710d-4241-a8a1-b505155a44f4") ]
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
/// Generated from Relation FK_usuariosXusuarios_usuarios1
/// </summary>
[GenWiseAttribute(RelationID = "777bd92a-821f-42d8-b178-71408e4f6062") ]
public virtual Usuario0 Usuario01 
{
get
{
if ( _usuario01 == null ) 
{
if ( String.IsNullOrEmpty(_subordinadoDe) || _subordinadoDe.Equals(string.Empty) ) 
{
if ( _usuario01 != null && ( _usuario01.Login.Equals(string.Empty) ) )
{
  _usuario01 = null;
}
}
else
{
_usuario01 = (new Usuario0Factory()).Get(_subordinadoDe);
}
}

return _usuario01;
}
set 
{
if ( _usuario01 != value) 
{
if ( value==null ) _subordinadoDe = string.Empty; else _subordinadoDe = (System.String)value.Login; 
_usuario01 = value ;
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
if ( SubordinadoDe != null ) _retValue += SubordinadoDe.ToString();

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
/// Create a new UsuariosXusuario object. 
/// </summary>
public  UsuariosXusuario()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  UsuariosXusuario(System.String pLogin , System.String pSubordinadoDe)
{
_login = pLogin ;
_subordinadoDe = pSubordinadoDe ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
if ( Login != null ) _hash += Login.ToString();
if ( SubordinadoDe != null ) _hash += SubordinadoDe.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
UsuariosXusuario _newUsuariosXusuario = (pObject as UsuariosXusuario); 
if (_newUsuariosXusuario == null ) return false; 
if (_newUsuariosXusuario.GetHashCode() == this.GetHashCode() ) return true; 
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
// Call Validator IsRequired for Column : subordinadoDe(Type:Required Field Validator)
_error = this.ValidatesubordinadoDeIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(Login) ) 
{
   _errors.Add( new Error( "The PK Column (login) can not be null!. " ) );
}
if ( String.IsNullOrEmpty(SubordinadoDe) ) 
{
   _errors.Add( new Error( "The PK Column (subordinadoDe) can not be null!. " ) );
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

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : subordinadoDe
/// </remarks>
public virtual Error ValidatesubordinadoDeIsRequired()
{
if ( String.IsNullOrEmpty(SubordinadoDe) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "subordinadoDe is required and therefore must have a value." ;
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

