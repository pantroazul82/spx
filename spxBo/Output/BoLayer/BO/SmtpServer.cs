using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class SmtpServer : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _smtpServer1;
private System.Boolean? _smtpAutentificacion;
private System.String _smtpUser;
private System.String _smtpPass;
private System.String _smtpDirOrigen;
private System.Boolean? _smtpEnableSsl;
private System.Boolean? _smtpHabilitado;

#endregion


#region --- Class Properties ---

public virtual System.String SmtpServer1 
{
get
{
return _smtpServer1;
}
set 
{
if ( _smtpServer1 != value) 
{
_smtpServer1 = value ;
OnPropertyChanged("SmtpServer1");
}
}
}

public virtual System.Boolean? SmtpAutentificacion 
{
get
{
return _smtpAutentificacion;
}
set 
{
if ( _smtpAutentificacion != value) 
{
_smtpAutentificacion = value ;
OnPropertyChanged("SmtpAutentificacion");
}
}
}

public virtual System.String SmtpUser 
{
get
{
return _smtpUser;
}
set 
{
if ( _smtpUser != value) 
{
_smtpUser = value ;
OnPropertyChanged("SmtpUser");
}
}
}

public virtual System.String SmtpPass 
{
get
{
return _smtpPass;
}
set 
{
if ( _smtpPass != value) 
{
_smtpPass = value ;
OnPropertyChanged("SmtpPass");
}
}
}

public virtual System.String SmtpDirOrigen 
{
get
{
return _smtpDirOrigen;
}
set 
{
if ( _smtpDirOrigen != value) 
{
_smtpDirOrigen = value ;
OnPropertyChanged("SmtpDirOrigen");
}
}
}

public virtual System.Boolean? SmtpEnableSsl 
{
get
{
return _smtpEnableSsl;
}
set 
{
if ( _smtpEnableSsl != value) 
{
_smtpEnableSsl = value ;
OnPropertyChanged("SmtpEnableSsl");
}
}
}

public virtual System.Boolean? SmtpHabilitado 
{
get
{
return _smtpHabilitado;
}
set 
{
if ( _smtpHabilitado != value) 
{
_smtpHabilitado = value ;
OnPropertyChanged("SmtpHabilitado");
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
/// Create a new SmtpServer object. 
/// </summary>
public  SmtpServer()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  SmtpServer(System.String pSmtpServer1)
{
_smtpServer1 = pSmtpServer1 ;

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
// Call Validator IsRequired for Column : smtpServer1(Type:Required Field Validator)
_error = this.ValidatesmtpServer1IsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(SmtpServer1) ) 
{
   _errors.Add( new Error( "The PK Column (smtpServer1) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : smtpServer1
/// </remarks>
public virtual Error ValidatesmtpServer1IsRequired()
{
if ( String.IsNullOrEmpty(SmtpServer1) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "smtpServer1 is required and therefore must have a value." ;
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

