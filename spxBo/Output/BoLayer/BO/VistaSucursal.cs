using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class VistaSucursal : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _nitCliente;
private System.String _codSucursal;
private System.String _nombreSucursal;
private System.String _direccion;
private System.String _telefono1;
private System.String _telefono2;
private System.String _codContacto;
private System.String _nombrePais;
private System.String _nombreDepartamento;
private System.String _nombreCiudad;

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

public virtual System.String CodSucursal 
{
get
{
return _codSucursal;
}
set 
{
if ( _codSucursal != value) 
{
_codSucursal = value ;
OnPropertyChanged("CodSucursal");
}
}
}

public virtual System.String NombreSucursal 
{
get
{
return _nombreSucursal;
}
set 
{
if ( _nombreSucursal != value) 
{
_nombreSucursal = value ;
OnPropertyChanged("NombreSucursal");
}
}
}

public virtual System.String Direccion 
{
get
{
return _direccion;
}
set 
{
if ( _direccion != value) 
{
_direccion = value ;
OnPropertyChanged("Direccion");
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

public virtual System.String NombrePais 
{
get
{
return _nombrePais;
}
set 
{
if ( _nombrePais != value) 
{
_nombrePais = value ;
OnPropertyChanged("NombrePais");
}
}
}

public virtual System.String NombreDepartamento 
{
get
{
return _nombreDepartamento;
}
set 
{
if ( _nombreDepartamento != value) 
{
_nombreDepartamento = value ;
OnPropertyChanged("NombreDepartamento");
}
}
}

public virtual System.String NombreCiudad 
{
get
{
return _nombreCiudad;
}
set 
{
if ( _nombreCiudad != value) 
{
_nombreCiudad = value ;
OnPropertyChanged("NombreCiudad");
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
/// Create a new VistaSucursal object. 
/// </summary>
public  VistaSucursal()
{
}

public override int GetHashCode()
{
string _hash = String.Empty; 
if ( NitCliente != null ) _hash += NitCliente.ToString();
if ( CodSucursal != null ) _hash += CodSucursal.ToString();
if ( NombreSucursal != null ) _hash += NombreSucursal.ToString();
if ( Direccion != null ) _hash += Direccion.ToString();
if ( Telefono1 != null ) _hash += Telefono1.ToString();
if ( Telefono2 != null ) _hash += Telefono2.ToString();
if ( CodContacto != null ) _hash += CodContacto.ToString();
if ( NombrePais != null ) _hash += NombrePais.ToString();
if ( NombreDepartamento != null ) _hash += NombreDepartamento.ToString();
if ( NombreCiudad != null ) _hash += NombreCiudad.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
VistaSucursal _newVistaSucursal = (pObject as VistaSucursal); 
if (_newVistaSucursal == null ) return false; 
if (_newVistaSucursal.GetHashCode() == this.GetHashCode() ) return true; 
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
// Call Validator IsRequired for Column : codSucursal(Type:Required Field Validator)
_error = this.ValidatecodSucursalIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
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
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codSucursal
/// </remarks>
public virtual Error ValidatecodSucursalIsRequired()
{
if ( String.IsNullOrEmpty(CodSucursal) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codSucursal is required and therefore must have a value." ;
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

