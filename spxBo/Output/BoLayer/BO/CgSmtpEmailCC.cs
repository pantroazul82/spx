using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class CgSmtpEmailCC : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _idCgSmtpEmail;
private System.Int32 _idCgSmtpEmailCC;
private System.String _nombreEmail;
private System.String _email;
private CgSmtpEmail _cgSmtpEmail;

#endregion


#region --- Class Properties ---

public virtual System.Int32 IdCgSmtpEmail 
{
get
{
if ( CgSmtpEmail != null ) 
{
_idCgSmtpEmail = (System.Int32)CgSmtpEmail.IdCgSmtpEmail;
}

return _idCgSmtpEmail;
}
set 
{
if ( _idCgSmtpEmail != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_cgSmtpEmail = null;

_idCgSmtpEmail = value ;
OnPropertyChanged("IdCgSmtpEmail");
}
}
}

public virtual System.Int32 IdCgSmtpEmailCC 
{
get
{
return _idCgSmtpEmailCC;
}
set 
{
if ( _idCgSmtpEmailCC != value) 
{
_idCgSmtpEmailCC = value ;
OnPropertyChanged("IdCgSmtpEmailCC");
}
}
}

public virtual System.String NombreEmail 
{
get
{
return _nombreEmail;
}
set 
{
if ( _nombreEmail != value) 
{
_nombreEmail = value ;
OnPropertyChanged("NombreEmail");
}
}
}

public virtual System.String Email 
{
get
{
return _email;
}
set 
{
if ( _email != value) 
{
_email = value ;
OnPropertyChanged("Email");
}
}
}

/// <summary>
/// Generated from Relation FK_cgSmtpEmailCC_cgSmtpEmail
/// </summary>
[GenWiseAttribute(RelationID = "77891082-161c-4454-aa72-deb16a9880e9") ]
public virtual CgSmtpEmail CgSmtpEmail 
{
get
{
if ( _cgSmtpEmail == null ) 
{
if (  _idCgSmtpEmail.Equals(0)  || _idCgSmtpEmail.Equals(System.Int32.MinValue) ) 
{
if ( _cgSmtpEmail != null && ( _cgSmtpEmail.IdCgSmtpEmail.Equals(System.Int32.MinValue) ) )
{
  _cgSmtpEmail = null;
}
}
else
{
_cgSmtpEmail = (new CgSmtpEmailFactory()).Get(_idCgSmtpEmail);
}
}

return _cgSmtpEmail;
}
set 
{
if ( _cgSmtpEmail != value) 
{
if ( value==null ) _idCgSmtpEmail = System.Int32.MinValue; else _idCgSmtpEmail = (System.Int32)value.IdCgSmtpEmail; 
_cgSmtpEmail = value ;
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
/// Create a new CgSmtpEmailCC object. 
/// </summary>
public  CgSmtpEmailCC()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  CgSmtpEmailCC(System.Int32 pIdCgSmtpEmailCC)
{
_idCgSmtpEmailCC = pIdCgSmtpEmailCC ;

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

// Primary Key Validation (Template Option)
if (  IdCgSmtpEmailCC.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (idCgSmtpEmailCC) can not be null!. " ) );
}

return _errors;
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

