using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class TipoDocumento : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _codTipoDoc;
private System.String _nombreTipoDoc;
private System.String _abreviatura;
private IList<Cliente> _clientes;
private IList<ContactosCliente> _contactosClientes;

#endregion


#region --- Class Properties ---

public virtual System.String CodTipoDoc 
{
get
{
return _codTipoDoc;
}
set 
{
if ( _codTipoDoc != value) 
{
_codTipoDoc = value ;
OnPropertyChanged("CodTipoDoc");
}
}
}

public virtual System.String NombreTipoDoc 
{
get
{
return _nombreTipoDoc;
}
set 
{
if ( _nombreTipoDoc != value) 
{
_nombreTipoDoc = value ;
OnPropertyChanged("NombreTipoDoc");
}
}
}

public virtual System.String Abreviatura 
{
get
{
return _abreviatura;
}
set 
{
if ( _abreviatura != value) 
{
_abreviatura = value ;
OnPropertyChanged("Abreviatura");
}
}
}

/// <summary>
/// Collection of Cliente.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "85bf8948-e0d1-4320-a320-9391609a7cb2" , CollectionOfType = typeof(Cliente)) ]
public virtual IList<Cliente> Clientes 
{
get
{
 if (_clientes == null) _clientes = new List<Cliente>();

return _clientes;
}
set 
{
if ( _clientes != value) 
{
_clientes = value ;
}
}
}

/// <summary>
/// Collection of ContactosCliente.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "3c8796b7-32c0-4a52-9beb-aa6a532cab6b" , CollectionOfType = typeof(ContactosCliente)) ]
public virtual IList<ContactosCliente> ContactosClientes 
{
get
{
 if (_contactosClientes == null) _contactosClientes = new List<ContactosCliente>();

return _contactosClientes;
}
set 
{
if ( _contactosClientes != value) 
{
_contactosClientes = value ;
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
/// Create a new TipoDocumento object. 
/// </summary>
public  TipoDocumento()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  TipoDocumento(System.String pCodTipoDoc)
{
_codTipoDoc = pCodTipoDoc ;

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
// Call Validator IsRequired for Column : codTipoDoc(Type:Required Field Validator)
_error = this.ValidatecodTipoDocIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : nombreTipoDoc(Type:Required Field Validator)
_error = this.ValidatenombreTipoDocIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(CodTipoDoc) ) 
{
   _errors.Add( new Error( "The PK Column (codTipoDoc) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codTipoDoc
/// </remarks>
public virtual Error ValidatecodTipoDocIsRequired()
{
if ( String.IsNullOrEmpty(CodTipoDoc) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codTipoDoc is required and therefore must have a value." ;
 return _error;
}
 return null;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : nombreTipoDoc
/// </remarks>
public virtual Error ValidatenombreTipoDocIsRequired()
{
if ( String.IsNullOrEmpty(NombreTipoDoc) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "nombreTipoDoc is required and therefore must have a value." ;
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

