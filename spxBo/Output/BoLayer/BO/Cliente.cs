using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class Cliente : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _nitCliente;
private System.String _nombreCliente;
private System.String _nombreContactoPrincipal;
private System.String _apellidosContacto;
private System.String _docContacto;
private System.String _codTipoDoc;
private System.String _tituloContacto;
private System.String _telefono1;
private System.String _telefono2;
private System.String _fax;
private System.String _celular;
private System.String _email;
private System.String _numeroSocio;
private System.Boolean? _esLocal;
private IList<Contrato> _contratos;
private IList<SolicitudServicio> _solicitudServicios;
private IList<SucursalCliente> _sucursalClientes;
private TipoDocumento _tipoDocumento;
private TituloContacto _tituloContactoParent;

#endregion


#region --- Class Properties ---

public virtual System.String NitCliente 
{
get
{
return _nitCliente;
}
set 
{
if ( _nitCliente != value) 
{
_nitCliente = value ;
OnPropertyChanged("NitCliente");
}
}
}

public virtual System.String NombreCliente 
{
get
{
return _nombreCliente;
}
set 
{
if ( _nombreCliente != value) 
{
_nombreCliente = value ;
OnPropertyChanged("NombreCliente");
}
}
}

public virtual System.String NombreContactoPrincipal 
{
get
{
return _nombreContactoPrincipal;
}
set 
{
if ( _nombreContactoPrincipal != value) 
{
_nombreContactoPrincipal = value ;
OnPropertyChanged("NombreContactoPrincipal");
}
}
}

public virtual System.String ApellidosContacto 
{
get
{
return _apellidosContacto;
}
set 
{
if ( _apellidosContacto != value) 
{
_apellidosContacto = value ;
OnPropertyChanged("ApellidosContacto");
}
}
}

public virtual System.String DocContacto 
{
get
{
return _docContacto;
}
set 
{
if ( _docContacto != value) 
{
_docContacto = value ;
OnPropertyChanged("DocContacto");
}
}
}

public virtual System.String CodTipoDoc 
{
get
{
if ( TipoDocumento != null ) 
{
_codTipoDoc = (System.String)TipoDocumento.CodTipoDoc;
}

return _codTipoDoc;
}
set 
{
if ( _codTipoDoc != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_tipoDocumento = null;

_codTipoDoc = value ;
OnPropertyChanged("CodTipoDoc");
}
}
}

public virtual System.String TituloContacto 
{
get
{
if ( TituloContactoParent != null ) 
{
_tituloContacto = (System.String)TituloContactoParent.CodTituloContacto;
}

return _tituloContacto;
}
set 
{
if ( _tituloContacto != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_tituloContactoParent = null;

_tituloContacto = value ;
OnPropertyChanged("TituloContacto");
}
}
}

public virtual System.String Telefono1 
{
get
{
return _telefono1;
}
set 
{
if ( _telefono1 != value) 
{
_telefono1 = value ;
OnPropertyChanged("Telefono1");
}
}
}

public virtual System.String Telefono2 
{
get
{
return _telefono2;
}
set 
{
if ( _telefono2 != value) 
{
_telefono2 = value ;
OnPropertyChanged("Telefono2");
}
}
}

public virtual System.String Fax 
{
get
{
return _fax;
}
set 
{
if ( _fax != value) 
{
_fax = value ;
OnPropertyChanged("Fax");
}
}
}

public virtual System.String Celular 
{
get
{
return _celular;
}
set 
{
if ( _celular != value) 
{
_celular = value ;
OnPropertyChanged("Celular");
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

public virtual System.String NumeroSocio 
{
get
{
return _numeroSocio;
}
set 
{
if ( _numeroSocio != value) 
{
_numeroSocio = value ;
OnPropertyChanged("NumeroSocio");
}
}
}

public virtual System.Boolean? EsLocal 
{
get
{
return _esLocal;
}
set 
{
if ( _esLocal != value) 
{
_esLocal = value ;
OnPropertyChanged("EsLocal");
}
}
}

/// <summary>
/// Collection of Contrato.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "14e22708-3c1c-4d57-ac1f-d5593f32094d" , CollectionOfType = typeof(Contrato)) ]
public virtual IList<Contrato> Contratos 
{
get
{
 if (_contratos == null) _contratos = new List<Contrato>();

return _contratos;
}
set 
{
if ( _contratos != value) 
{
_contratos = value ;
}
}
}

/// <summary>
/// Collection of SolicitudServicio.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "afd3b87d-6c44-4968-9992-e94efea097f3" , CollectionOfType = typeof(SolicitudServicio)) ]
public virtual IList<SolicitudServicio> SolicitudServicios 
{
get
{
 if (_solicitudServicios == null) _solicitudServicios = new List<SolicitudServicio>();

return _solicitudServicios;
}
set 
{
if ( _solicitudServicios != value) 
{
_solicitudServicios = value ;
}
}
}

/// <summary>
/// Collection of SucursalCliente.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "dcebf87c-ae32-406f-9179-4ece35c95774" , CollectionOfType = typeof(SucursalCliente)) ]
public virtual IList<SucursalCliente> SucursalClientes 
{
get
{
 if (_sucursalClientes == null) _sucursalClientes = new List<SucursalCliente>();

return _sucursalClientes;
}
set 
{
if ( _sucursalClientes != value) 
{
_sucursalClientes = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_clientes_tipoDocumento
/// </summary>
[GenWiseAttribute(RelationID = "85bf8948-e0d1-4320-a320-9391609a7cb2") ]
public virtual TipoDocumento TipoDocumento 
{
get
{
if ( _tipoDocumento == null ) 
{
if ( String.IsNullOrEmpty(_codTipoDoc) || _codTipoDoc.Equals(string.Empty) ) 
{
if ( _tipoDocumento != null && ( _tipoDocumento.CodTipoDoc.Equals(null) ) )
{
  _tipoDocumento = null;
}
}
else
{
_tipoDocumento = (new TipoDocumentoFactory()).Get(_codTipoDoc);
}
}

return _tipoDocumento;
}
set 
{
if ( _tipoDocumento != value) 
{
if ( value==null ) _codTipoDoc = null; else _codTipoDoc = (System.String)value.CodTipoDoc; 
_tipoDocumento = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_clientes_tituloContacto
/// </summary>
[GenWiseAttribute(RelationID = "9c6b958e-256e-4152-982d-9847a5a8796d") ]
public virtual TituloContacto TituloContactoParent 
{
get
{
if ( _tituloContactoParent == null ) 
{
if ( String.IsNullOrEmpty(_tituloContacto) || _tituloContacto.Equals(string.Empty) ) 
{
if ( _tituloContactoParent != null && ( _tituloContactoParent.CodTituloContacto.Equals(null) ) )
{
  _tituloContactoParent = null;
}
}
else
{
_tituloContactoParent = (new TituloContactoFactory()).Get(_tituloContacto);
}
}

return _tituloContactoParent;
}
set 
{
if ( _tituloContactoParent != value) 
{
if ( value==null ) _tituloContacto = null; else _tituloContacto = (System.String)value.CodTituloContacto; 
_tituloContactoParent = value ;
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
/// Create a new Cliente object. 
/// </summary>
public  Cliente()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  Cliente(System.String pNitCliente)
{
_nitCliente = pNitCliente ;

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
// Call Validator IsRequired for Column : nitCliente(Type:Required Field Validator)
_error = this.ValidatenitClienteIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : nombreCliente(Type:Required Field Validator)
_error = this.ValidatenombreClienteIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(NitCliente) ) 
{
   _errors.Add( new Error( "The PK Column (nitCliente) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : nitCliente
/// </remarks>
public virtual Error ValidatenitClienteIsRequired()
{
if ( String.IsNullOrEmpty(NitCliente) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "nitCliente is required and therefore must have a value." ;
 return _error;
}
 return null;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : nombreCliente
/// </remarks>
public virtual Error ValidatenombreClienteIsRequired()
{
if ( String.IsNullOrEmpty(NombreCliente) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "nombreCliente is required and therefore must have a value." ;
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

