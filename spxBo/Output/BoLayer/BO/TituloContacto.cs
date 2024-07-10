using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class TituloContacto : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _codTituloContacto;
private System.String _tituloContacto1;
private IList<Cliente> _clientes;
private IList<ContactosCliente> _contactosClientes;

#endregion


#region --- Class Properties ---

public virtual System.String CodTituloContacto 
{
get
{
return _codTituloContacto;
}
set 
{
if ( _codTituloContacto != value) 
{
_codTituloContacto = value ;
OnPropertyChanged("CodTituloContacto");
}
}
}

public virtual System.String TituloContacto1 
{
get
{
return _tituloContacto1;
}
set 
{
if ( _tituloContacto1 != value) 
{
_tituloContacto1 = value ;
OnPropertyChanged("TituloContacto1");
}
}
}

/// <summary>
/// Collection of Cliente.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "9c6b958e-256e-4152-982d-9847a5a8796d" , CollectionOfType = typeof(Cliente)) ]
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
[GenWiseAttribute(RelationID = "727b6d6d-4f45-4f71-9630-69c0a5137ab5" , CollectionOfType = typeof(ContactosCliente)) ]
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
/// Create a new TituloContacto object. 
/// </summary>
public  TituloContacto()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  TituloContacto(System.String pCodTituloContacto)
{
_codTituloContacto = pCodTituloContacto ;

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
// Call Validator IsRequired for Column : codTituloContacto(Type:Required Field Validator)
_error = this.ValidatecodTituloContactoIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(CodTituloContacto) ) 
{
   _errors.Add( new Error( "The PK Column (codTituloContacto) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codTituloContacto
/// </remarks>
public virtual Error ValidatecodTituloContactoIsRequired()
{
if ( String.IsNullOrEmpty(CodTituloContacto) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codTituloContacto is required and therefore must have a value." ;
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

