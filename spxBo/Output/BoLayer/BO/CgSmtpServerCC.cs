using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class CgSmtpServerCC : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _idCgSmtpServer;
private System.Int32 _idCgSmtpServerCC;
private System.String _nombreEmail;
private System.String _email;
private CgSmtpServer _cgSmtpServer;

#endregion


#region --- Class Properties ---

public virtual System.Int32 IdCgSmtpServer 
{
get
{
if ( CgSmtpServer != null ) 
{
_idCgSmtpServer = (System.Int32)CgSmtpServer.IdCgSmtpServer;
}

return _idCgSmtpServer;
}
set 
{
if ( _idCgSmtpServer != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_cgSmtpServer = null;

_idCgSmtpServer = value ;
OnPropertyChanged("IdCgSmtpServer");
}
}
}

public virtual System.Int32 IdCgSmtpServerCC 
{
get
{
return _idCgSmtpServerCC;
}
set 
{
if ( _idCgSmtpServerCC != value) 
{
_idCgSmtpServerCC = value ;
OnPropertyChanged("IdCgSmtpServerCC");
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
/// Generated from Relation FK_cgSmtpServerCC_cgSmtpServer
/// </summary>
[GenWiseAttribute(RelationID = "8981a91a-8579-4f27-9e61-911d8cdfd1ae") ]
public virtual CgSmtpServer CgSmtpServer 
{
get
{
if ( _cgSmtpServer == null ) 
{
if (  _idCgSmtpServer.Equals(0)  || _idCgSmtpServer.Equals(System.Int32.MinValue) ) 
{
if ( _cgSmtpServer != null && ( _cgSmtpServer.IdCgSmtpServer.Equals(System.Int32.MinValue) ) )
{
  _cgSmtpServer = null;
}
}
else
{
_cgSmtpServer = (new CgSmtpServerFactory()).Get(_idCgSmtpServer);
}
}

return _cgSmtpServer;
}
set 
{
if ( _cgSmtpServer != value) 
{
if ( value==null ) _idCgSmtpServer = System.Int32.MinValue; else _idCgSmtpServer = (System.Int32)value.IdCgSmtpServer; 
_cgSmtpServer = value ;
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
/// Create a new CgSmtpServerCC object. 
/// </summary>
public  CgSmtpServerCC()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  CgSmtpServerCC(System.Int32 pIdCgSmtpServerCC)
{
_idCgSmtpServerCC = pIdCgSmtpServerCC ;

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
if (  IdCgSmtpServerCC.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (idCgSmtpServerCC) can not be null!. " ) );
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

