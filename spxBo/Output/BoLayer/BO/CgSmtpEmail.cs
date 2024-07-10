using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class CgSmtpEmail : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _idCgSmtpEmail;
private System.Boolean? _enviado;
private System.DateTime? _fechaRealEnvio;
private System.String _cuerpo;
private System.String _nombreFirma;
private System.String _emailFirma;
private System.String _asunto;
private System.Boolean? _isBodyHtml;
private System.String _prioridad;
private System.String _responderA;
private System.DateTime? _fechaEnvio;
private IList<CgSmtpAdjunto> _cgSmtpAdjuntos;
private IList<CgSmtpEmailCC> _cgSmtpEmailCCs;
private IList<CgSmtpEmailCCO> _cgSmtpEmailCCOs;
private IList<CgSmtpEmailTo> _cgSmtpEmailTos;

#endregion


#region --- Class Properties ---

public virtual System.Int32 IdCgSmtpEmail 
{
get
{
return _idCgSmtpEmail;
}
set 
{
if ( _idCgSmtpEmail != value) 
{
_idCgSmtpEmail = value ;
OnPropertyChanged("IdCgSmtpEmail");
}
}
}

public virtual System.Boolean? Enviado 
{
get
{
return _enviado;
}
set 
{
if ( _enviado != value) 
{
_enviado = value ;
OnPropertyChanged("Enviado");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaRealEnvio_Date 
{
get
{
if (  !FechaRealEnvio.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaRealEnvio.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaRealEnvio.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaRealEnvio_Time)) {

FechaRealEnvio = null;
}
 else
{
 FechaRealEnvio = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaRealEnvio.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaRealEnvio_Time)) 
{
 FechaRealEnvio = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaRealEnvio = Convert.ToDateTime( " " + value + " " + FechaRealEnvio.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaRealEnvio_Time 
{
get
{
if (  !FechaRealEnvio.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaRealEnvio.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaRealEnvio.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaRealEnvio_Date)) 
{
FechaRealEnvio = null;
}
 else
{
 FechaRealEnvio = Convert.ToDateTime( " " + FechaRealEnvio.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaRealEnvio_Date)) 
{
 FechaRealEnvio = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaRealEnvio = Convert.ToDateTime( " " + FechaRealEnvio_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaRealEnvio 
{
get
{
return _fechaRealEnvio;
}
set 
{
if ( _fechaRealEnvio != value) 
{
_fechaRealEnvio = value ;
OnPropertyChanged("FechaRealEnvio");
}
}
}

public virtual System.String Cuerpo 
{
get
{
return _cuerpo;
}
set 
{
if ( _cuerpo != value) 
{
_cuerpo = value ;
OnPropertyChanged("Cuerpo");
}
}
}

public virtual System.String NombreFirma 
{
get
{
return _nombreFirma;
}
set 
{
if ( _nombreFirma != value) 
{
_nombreFirma = value ;
OnPropertyChanged("NombreFirma");
}
}
}

public virtual System.String EmailFirma 
{
get
{
return _emailFirma;
}
set 
{
if ( _emailFirma != value) 
{
_emailFirma = value ;
OnPropertyChanged("EmailFirma");
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

public virtual System.Boolean? IsBodyHtml 
{
get
{
return _isBodyHtml;
}
set 
{
if ( _isBodyHtml != value) 
{
_isBodyHtml = value ;
OnPropertyChanged("IsBodyHtml");
}
}
}

public virtual System.String Prioridad 
{
get
{
return _prioridad;
}
set 
{
if ( _prioridad != value) 
{
_prioridad = value ;
OnPropertyChanged("Prioridad");
}
}
}

public virtual System.String ResponderA 
{
get
{
return _responderA;
}
set 
{
if ( _responderA != value) 
{
_responderA = value ;
OnPropertyChanged("ResponderA");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaEnvio_Date 
{
get
{
if (  !FechaEnvio.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaEnvio.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaEnvio.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaEnvio_Time)) {

FechaEnvio = null;
}
 else
{
 FechaEnvio = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaEnvio.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaEnvio_Time)) 
{
 FechaEnvio = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaEnvio = Convert.ToDateTime( " " + value + " " + FechaEnvio.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FechaEnvio_Time 
{
get
{
if (  !FechaEnvio.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaEnvio.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaEnvio.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaEnvio_Date)) 
{
FechaEnvio = null;
}
 else
{
 FechaEnvio = Convert.ToDateTime( " " + FechaEnvio.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaEnvio_Date)) 
{
 FechaEnvio = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaEnvio = Convert.ToDateTime( " " + FechaEnvio_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaEnvio 
{
get
{
return _fechaEnvio;
}
set 
{
if ( _fechaEnvio != value) 
{
_fechaEnvio = value ;
OnPropertyChanged("FechaEnvio");
}
}
}

/// <summary>
/// Collection of CgSmtpAdjunto.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "e36ca2c3-32d4-498f-bb27-2e1c13452a77" , CollectionOfType = typeof(CgSmtpAdjunto)) ]
public virtual IList<CgSmtpAdjunto> CgSmtpAdjuntos 
{
get
{
 if (_cgSmtpAdjuntos == null) _cgSmtpAdjuntos = new List<CgSmtpAdjunto>();

return _cgSmtpAdjuntos;
}
set 
{
if ( _cgSmtpAdjuntos != value) 
{
_cgSmtpAdjuntos = value ;
}
}
}

/// <summary>
/// Collection of CgSmtpEmailCC.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "77891082-161c-4454-aa72-deb16a9880e9" , CollectionOfType = typeof(CgSmtpEmailCC)) ]
public virtual IList<CgSmtpEmailCC> CgSmtpEmailCCs 
{
get
{
 if (_cgSmtpEmailCCs == null) _cgSmtpEmailCCs = new List<CgSmtpEmailCC>();

return _cgSmtpEmailCCs;
}
set 
{
if ( _cgSmtpEmailCCs != value) 
{
_cgSmtpEmailCCs = value ;
}
}
}

/// <summary>
/// Collection of CgSmtpEmailCCO.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "9e362be0-4957-4de2-a25f-ccab3f1cf13b" , CollectionOfType = typeof(CgSmtpEmailCCO)) ]
public virtual IList<CgSmtpEmailCCO> CgSmtpEmailCCOs 
{
get
{
 if (_cgSmtpEmailCCOs == null) _cgSmtpEmailCCOs = new List<CgSmtpEmailCCO>();

return _cgSmtpEmailCCOs;
}
set 
{
if ( _cgSmtpEmailCCOs != value) 
{
_cgSmtpEmailCCOs = value ;
}
}
}

/// <summary>
/// Collection of CgSmtpEmailTo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "99cf4e3d-e23d-4be0-a52d-cdae3ef347ea" , CollectionOfType = typeof(CgSmtpEmailTo)) ]
public virtual IList<CgSmtpEmailTo> CgSmtpEmailTos 
{
get
{
 if (_cgSmtpEmailTos == null) _cgSmtpEmailTos = new List<CgSmtpEmailTo>();

return _cgSmtpEmailTos;
}
set 
{
if ( _cgSmtpEmailTos != value) 
{
_cgSmtpEmailTos = value ;
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
/// Create a new CgSmtpEmail object. 
/// </summary>
public  CgSmtpEmail()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  CgSmtpEmail(System.Int32 pIdCgSmtpEmail)
{
_idCgSmtpEmail = pIdCgSmtpEmail ;

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
if (  IdCgSmtpEmail.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (idCgSmtpEmail) can not be null!. " ) );
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

