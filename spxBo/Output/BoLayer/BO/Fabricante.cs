using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class Fabricante : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _codFabricante;
private System.String _nombreFabricante;
private System.String _numeroNit;
private System.String _paginaWeb;
private System.String _emailContacto;
private System.String _telefono1;
private System.String _telefono2;
private System.String _nombreContacto;
private System.String _tituloContacto;
private IList<Modelo> _modelos;

#endregion


#region --- Class Properties ---

public virtual System.String CodFabricante 
{
get
{
return _codFabricante;
}
set 
{
if ( _codFabricante != value) 
{
_codFabricante = value ;
OnPropertyChanged("CodFabricante");
}
}
}

public virtual System.String NombreFabricante 
{
get
{
return _nombreFabricante;
}
set 
{
if ( _nombreFabricante != value) 
{
_nombreFabricante = value ;
OnPropertyChanged("NombreFabricante");
}
}
}

public virtual System.String NumeroNit 
{
get
{
return _numeroNit;
}
set 
{
if ( _numeroNit != value) 
{
_numeroNit = value ;
OnPropertyChanged("NumeroNit");
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

public virtual System.String EmailContacto 
{
get
{
return _emailContacto;
}
set 
{
if ( _emailContacto != value) 
{
_emailContacto = value ;
OnPropertyChanged("EmailContacto");
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

public virtual System.String TituloContacto 
{
get
{
return _tituloContacto;
}
set 
{
if ( _tituloContacto != value) 
{
_tituloContacto = value ;
OnPropertyChanged("TituloContacto");
}
}
}

/// <summary>
/// Collection of Modelo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "d5aae68d-0f2f-4009-9f72-f4a6f472b525" , CollectionOfType = typeof(Modelo)) ]
public virtual IList<Modelo> Modelos 
{
get
{
 if (_modelos == null) _modelos = new List<Modelo>();

return _modelos;
}
set 
{
if ( _modelos != value) 
{
_modelos = value ;
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
/// Create a new Fabricante object. 
/// </summary>
public  Fabricante()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  Fabricante(System.String pCodFabricante)
{
_codFabricante = pCodFabricante ;

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
// Call Validator IsRequired for Column : codFabricante(Type:Required Field Validator)
_error = this.ValidatecodFabricanteIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : nombreFabricante(Type:Required Field Validator)
_error = this.ValidatenombreFabricanteIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(CodFabricante) ) 
{
   _errors.Add( new Error( "The PK Column (codFabricante) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codFabricante
/// </remarks>
public virtual Error ValidatecodFabricanteIsRequired()
{
if ( String.IsNullOrEmpty(CodFabricante) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codFabricante is required and therefore must have a value." ;
 return _error;
}
 return null;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : nombreFabricante
/// </remarks>
public virtual Error ValidatenombreFabricanteIsRequired()
{
if ( String.IsNullOrEmpty(NombreFabricante) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "nombreFabricante is required and therefore must have a value." ;
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

