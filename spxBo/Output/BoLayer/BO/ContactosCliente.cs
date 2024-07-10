using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class ContactosCliente : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _nitCliente;
private System.String _codContacto;
private System.String _nombreContacto;
private System.String _apellidosContacto;
private System.String _docContacto;
private System.String _codTipoDoc;
private System.String _tituloContacto;
private System.String _telefono1;
private System.String _telefono2;
private System.String _fax;
private System.String _celular;
private System.String _email;
private System.String _paginaWeb;
private System.DateTime? _cumpleanos;
private IList<LlamadaSoporte> _llamadaSoportes;
private IList<Seguimiento> _seguimientos;
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

public virtual System.String CodContacto 
{
get
{
return _codContacto;
}
set 
{
if ( _codContacto != value) 
{
_codContacto = value ;
OnPropertyChanged("CodContacto");
}
}
}

public virtual System.String NombreContacto 
{
get
{
return _nombreContacto;
}
set 
{
if ( _nombreContacto != value) 
{
_nombreContacto = value ;
OnPropertyChanged("NombreContacto");
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

public virtual System.String PaginaWeb 
{
get
{
return _paginaWeb;
}
set 
{
if ( _paginaWeb != value) 
{
_paginaWeb = value ;
OnPropertyChanged("PaginaWeb");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String Cumpleanos_Date 
{
get
{
if (  !Cumpleanos.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( Cumpleanos.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return Cumpleanos.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(Cumpleanos_Time)) {

Cumpleanos = null;
}
 else
{
 Cumpleanos = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + Cumpleanos.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(Cumpleanos_Time)) 
{
 Cumpleanos = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 Cumpleanos = Convert.ToDateTime( " " + value + " " + Cumpleanos.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String Cumpleanos_Time 
{
get
{
if (  !Cumpleanos.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( Cumpleanos.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return Cumpleanos.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(Cumpleanos_Date)) 
{
Cumpleanos = null;
}
 else
{
 Cumpleanos = Convert.ToDateTime( " " + Cumpleanos.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(Cumpleanos_Date)) 
{
 Cumpleanos = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 Cumpleanos = Convert.ToDateTime( " " + Cumpleanos_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? Cumpleanos 
{
get
{
return _cumpleanos;
}
set 
{
if ( _cumpleanos != value) 
{
_cumpleanos = value ;
OnPropertyChanged("Cumpleanos");
}
}
}

/// <summary>
/// Collection of LlamadaSoporte.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "91ff214c-32b9-4f2c-bb65-dc13cdfc1c5d" , CollectionOfType = typeof(LlamadaSoporte)) ]
public virtual IList<LlamadaSoporte> LlamadaSoportes 
{
get
{
 if (_llamadaSoportes == null) _llamadaSoportes = new List<LlamadaSoporte>();

return _llamadaSoportes;
}
set 
{
if ( _llamadaSoportes != value) 
{
_llamadaSoportes = value ;
}
}
}

/// <summary>
/// Collection of Seguimiento.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "640137dd-3be0-4ba7-af90-091dc55f8428" , CollectionOfType = typeof(Seguimiento)) ]
public virtual IList<Seguimiento> Seguimientos 
{
get
{
 if (_seguimientos == null) _seguimientos = new List<Seguimiento>();

return _seguimientos;
}
set 
{
if ( _seguimientos != value) 
{
_seguimientos = value ;
}
}
}

/// <summary>
/// Collection of SucursalCliente.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "7c139d5e-a8a7-4b65-8516-e42468f86c51" , CollectionOfType = typeof(SucursalCliente)) ]
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
/// Generated from Relation FK_contactosClientes_tipoDocumento
/// </summary>
[GenWiseAttribute(RelationID = "3c8796b7-32c0-4a52-9beb-aa6a532cab6b") ]
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
/// Generated from Relation FK_contactosClientes_tituloContacto
/// </summary>
[GenWiseAttribute(RelationID = "727b6d6d-4f45-4f71-9630-69c0a5137ab5") ]
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
/// Property that simulates a unique PK by concatenating all the Pk properties
/// </summary>
public virtual System.String VirtualPk 
{
get
{
string _retValue = string.Empty;

if ( NitCliente != null ) _retValue += NitCliente.ToString();

_retValue += "^";
if ( CodContacto != null ) _retValue += CodContacto.ToString();

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
/// Create a new ContactosCliente object. 
/// </summary>
public  ContactosCliente()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  ContactosCliente(System.String pNitCliente , System.String pCodContacto)
{
_nitCliente = pNitCliente ;
_codContacto = pCodContacto ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
if ( NitCliente != null ) _hash += NitCliente.ToString();
if ( CodContacto != null ) _hash += CodContacto.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
ContactosCliente _newContactosCliente = (pObject as ContactosCliente); 
if (_newContactosCliente == null ) return false; 
if (_newContactosCliente.GetHashCode() == this.GetHashCode() ) return true; 
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
// Call Validator IsRequired for Column : nitCliente(Type:Required Field Validator)
_error = this.ValidatenitClienteIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : codContacto(Type:Required Field Validator)
_error = this.ValidatecodContactoIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : nombreContacto(Type:Required Field Validator)
_error = this.ValidatenombreContactoIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : apellidosContacto(Type:Required Field Validator)
_error = this.ValidateapellidosContactoIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : telefono1(Type:Required Field Validator)
_error = this.Validatetelefono1IsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(NitCliente) ) 
{
   _errors.Add( new Error( "The PK Column (nitCliente) can not be null!. " ) );
}
if ( String.IsNullOrEmpty(CodContacto) ) 
{
   _errors.Add( new Error( "The PK Column (codContacto) can not be null!. " ) );
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
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codContacto
/// </remarks>
public virtual Error ValidatecodContactoIsRequired()
{
if ( String.IsNullOrEmpty(CodContacto) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codContacto is required and therefore must have a value." ;
 return _error;
}
 return null;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : nombreContacto
/// </remarks>
public virtual Error ValidatenombreContactoIsRequired()
{
if ( String.IsNullOrEmpty(NombreContacto) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "nombreContacto is required and therefore must have a value." ;
 return _error;
}
 return null;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : apellidosContacto
/// </remarks>
public virtual Error ValidateapellidosContactoIsRequired()
{
if ( String.IsNullOrEmpty(ApellidosContacto) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "apellidosContacto is required and therefore must have a value." ;
 return _error;
}
 return null;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : telefono1
/// </remarks>
public virtual Error Validatetelefono1IsRequired()
{
if ( String.IsNullOrEmpty(Telefono1) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "telefono1 is required and therefore must have a value." ;
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

