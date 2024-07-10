using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class CgSmtpServer : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _idCgSmtpServer;
private System.String _servidorSmtp;
private System.String _usuarioSmtp;
private System.String _passSmtp;
private System.Boolean? _conAutenticacion;
private System.Boolean? _sslHabilitado;
private System.Int32? _puerto;
private System.String _correoOrigen;
private System.String _nombreOrigen;
private System.String _responderA;
private System.String _asuntoPrefijo;
private System.String _asuntoPostfijo;
private System.String _cuerpoPrefijo;
private System.String _cuerpoPostfijo;
private System.Boolean? _dejarCopiaTabla;
private System.Boolean? _isBodyHtml;
private System.Boolean? _habilitado;
private IList<CgSmtpServerCC> _cgSmtpServerCCs;
private IList<CgSmtpServerCCO> _cgSmtpServerCCOs;

#endregion


#region --- Class Properties ---

public virtual System.Int32 IdCgSmtpServer 
{
get
{
return _idCgSmtpServer;
}
set 
{
if ( _idCgSmtpServer != value) 
{
_idCgSmtpServer = value ;
OnPropertyChanged("IdCgSmtpServer");
}
}
}

public virtual System.String ServidorSmtp 
{
get
{
return _servidorSmtp;
}
set 
{
if ( _servidorSmtp != value) 
{
_servidorSmtp = value ;
OnPropertyChanged("ServidorSmtp");
}
}
}

public virtual System.String UsuarioSmtp 
{
get
{
return _usuarioSmtp;
}
set 
{
if ( _usuarioSmtp != value) 
{
_usuarioSmtp = value ;
OnPropertyChanged("UsuarioSmtp");
}
}
}

public virtual System.String PassSmtp 
{
get
{
return _passSmtp;
}
set 
{
if ( _passSmtp != value) 
{
_passSmtp = value ;
OnPropertyChanged("PassSmtp");
}
}
}

public virtual System.Boolean? ConAutenticacion 
{
get
{
return _conAutenticacion;
}
set 
{
if ( _conAutenticacion != value) 
{
_conAutenticacion = value ;
OnPropertyChanged("ConAutenticacion");
}
}
}

public virtual System.Boolean? SslHabilitado 
{
get
{
return _sslHabilitado;
}
set 
{
if ( _sslHabilitado != value) 
{
_sslHabilitado = value ;
OnPropertyChanged("SslHabilitado");
}
}
}

public virtual System.Int32? Puerto 
{
get
{
return _puerto;
}
set 
{
if ( _puerto != value) 
{
_puerto = value ;
OnPropertyChanged("Puerto");
}
}
}

public virtual System.String CorreoOrigen 
{
get
{
return _correoOrigen;
}
set 
{
if ( _correoOrigen != value) 
{
_correoOrigen = value ;
OnPropertyChanged("CorreoOrigen");
}
}
}

public virtual System.String NombreOrigen 
{
get
{
return _nombreOrigen;
}
set 
{
if ( _nombreOrigen != value) 
{
_nombreOrigen = value ;
OnPropertyChanged("NombreOrigen");
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

public virtual System.String AsuntoPrefijo 
{
get
{
return _asuntoPrefijo;
}
set 
{
if ( _asuntoPrefijo != value) 
{
_asuntoPrefijo = value ;
OnPropertyChanged("AsuntoPrefijo");
}
}
}

public virtual System.String AsuntoPostfijo 
{
get
{
return _asuntoPostfijo;
}
set 
{
if ( _asuntoPostfijo != value) 
{
_asuntoPostfijo = value ;
OnPropertyChanged("AsuntoPostfijo");
}
}
}

public virtual System.String CuerpoPrefijo 
{
get
{
return _cuerpoPrefijo;
}
set 
{
if ( _cuerpoPrefijo != value) 
{
_cuerpoPrefijo = value ;
OnPropertyChanged("CuerpoPrefijo");
}
}
}

public virtual System.String CuerpoPostfijo 
{
get
{
return _cuerpoPostfijo;
}
set 
{
if ( _cuerpoPostfijo != value) 
{
_cuerpoPostfijo = value ;
OnPropertyChanged("CuerpoPostfijo");
}
}
}

public virtual System.Boolean? DejarCopiaTabla 
{
get
{
return _dejarCopiaTabla;
}
set 
{
if ( _dejarCopiaTabla != value) 
{
_dejarCopiaTabla = value ;
OnPropertyChanged("DejarCopiaTabla");
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

public virtual System.Boolean? Habilitado 
{
get
{
return _habilitado;
}
set 
{
if ( _habilitado != value) 
{
_habilitado = value ;
OnPropertyChanged("Habilitado");
}
}
}

/// <summary>
/// Collection of CgSmtpServerCC.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "8981a91a-8579-4f27-9e61-911d8cdfd1ae" , CollectionOfType = typeof(CgSmtpServerCC)) ]
public virtual IList<CgSmtpServerCC> CgSmtpServerCCs 
{
get
{
 if (_cgSmtpServerCCs == null) _cgSmtpServerCCs = new List<CgSmtpServerCC>();

return _cgSmtpServerCCs;
}
set 
{
if ( _cgSmtpServerCCs != value) 
{
_cgSmtpServerCCs = value ;
}
}
}

/// <summary>
/// Collection of CgSmtpServerCCO.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "784802b8-bc61-440c-95c7-c1295921f7f2" , CollectionOfType = typeof(CgSmtpServerCCO)) ]
public virtual IList<CgSmtpServerCCO> CgSmtpServerCCOs 
{
get
{
 if (_cgSmtpServerCCOs == null) _cgSmtpServerCCOs = new List<CgSmtpServerCCO>();

return _cgSmtpServerCCOs;
}
set 
{
if ( _cgSmtpServerCCOs != value) 
{
_cgSmtpServerCCOs = value ;
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
/// Create a new CgSmtpServer object. 
/// </summary>
public  CgSmtpServer()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  CgSmtpServer(System.Int32 pIdCgSmtpServer)
{
_idCgSmtpServer = pIdCgSmtpServer ;

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
if (  IdCgSmtpServer.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (idCgSmtpServer) can not be null!. " ) );
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

