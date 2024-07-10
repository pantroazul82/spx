using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class CgSmtpEmailCCO : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _idCgSmtpEmail;
private System.Int32 _idCgSmtpEmailCCO;
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

public virtual System.Int32 IdCgSmtpEmailCCO 
{
get
{
return _idCgSmtpEmailCCO;
}
set 
{
if ( _idCgSmtpEmailCCO != value) 
{
_idCgSmtpEmailCCO = value ;
OnPropertyChanged("IdCgSmtpEmailCCO");
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
/// Generated from Relation FK_cgSmtpEmailCCO_cgSmtpEmail
/// </summary>
[GenWiseAttribute(RelationID = "9e362be0-4957-4de2-a25f-ccab3f1cf13b") ]
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
/// Create a new CgSmtpEmailCCO object. 
/// </summary>
public  CgSmtpEmailCCO()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  CgSmtpEmailCCO(System.Int32 pIdCgSmtpEmailCCO)
{
_idCgSmtpEmailCCO = pIdCgSmtpEmailCCO ;

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
if (  IdCgSmtpEmailCCO.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (idCgSmtpEmailCCO) can not be null!. " ) );
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

