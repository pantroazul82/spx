using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class Ciudade : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _codPais;
private System.String _codDepartamento;
private System.String _codCiudad;
private System.String _nombreCiudad;
private IList<OrdenPrestamo> _ordenPrestamos;
private IList<RegionesXusuario> _regionesXusuarios;
private IList<SucursalCliente> _sucursalClientes;
private Departamento _departamento;

#endregion


#region --- Class Properties ---

public virtual System.String CodPais 
{
get
{
return _codPais;
}
set 
{
if ( _codPais != value) 
{
_codPais = value ;
OnPropertyChanged("CodPais");
}
}
}

public virtual System.String CodDepartamento 
{
get
{
return _codDepartamento;
}
set 
{
if ( _codDepartamento != value) 
{
_codDepartamento = value ;
OnPropertyChanged("CodDepartamento");
}
}
}

public virtual System.String CodCiudad 
{
get
{
return _codCiudad;
}
set 
{
if ( _codCiudad != value) 
{
_codCiudad = value ;
OnPropertyChanged("CodCiudad");
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
/// Collection of OrdenPrestamo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "a0d97942-7f70-4eb2-9b28-7fbc2db9964f" , CollectionOfType = typeof(OrdenPrestamo)) ]
public virtual IList<OrdenPrestamo> OrdenPrestamos 
{
get
{
 if (_ordenPrestamos == null) _ordenPrestamos = new List<OrdenPrestamo>();

return _ordenPrestamos;
}
set 
{
if ( _ordenPrestamos != value) 
{
_ordenPrestamos = value ;
}
}
}

/// <summary>
/// Collection of RegionesXusuario.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "f63b23aa-3f06-43db-9e07-70465a8be905" , CollectionOfType = typeof(RegionesXusuario)) ]
public virtual IList<RegionesXusuario> RegionesXusuarios 
{
get
{
 if (_regionesXusuarios == null) _regionesXusuarios = new List<RegionesXusuario>();

return _regionesXusuarios;
}
set 
{
if ( _regionesXusuarios != value) 
{
_regionesXusuarios = value ;
}
}
}

/// <summary>
/// Collection of SucursalCliente.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "4149959e-72f2-40b4-bbeb-44290e1fec38" , CollectionOfType = typeof(SucursalCliente)) ]
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
/// Generated from Relation FK_ciudades_departamento
/// </summary>
[GenWiseAttribute(RelationID = "e84cb356-cb84-410b-99ea-ffd27fe6b6fb") ]
public virtual Departamento Departamento 
{
get
{
if ( _departamento == null || _departamento == null ) 
{
if ( String.IsNullOrEmpty(_codPais) || _codPais.Equals(string.Empty) || String.IsNullOrEmpty(_codDepartamento) || _codDepartamento.Equals(string.Empty) ) 
{
if ( _departamento != null && ( _departamento.CodPais.Equals(string.Empty) || _departamento.CodDepartamento.Equals(string.Empty) ) )
{
  _departamento = null;
}
}
else
{
  _departamento = (new DepartamentoFactory()).Fetch(_codPais,_codDepartamento);
}
}

return _departamento;
}
set 
{
if ( _departamento != value) 
{
if ( value==null ) _codPais = string.Empty; else _codPais = (System.String)value.CodPais; 
if ( value==null ) _codDepartamento = string.Empty; else _codDepartamento = (System.String)value.CodDepartamento; 
_departamento = value ;
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

if ( CodPais != null ) _retValue += CodPais.ToString();

_retValue += "^";
if ( CodDepartamento != null ) _retValue += CodDepartamento.ToString();

_retValue += "^";
if ( CodCiudad != null ) _retValue += CodCiudad.ToString();

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
/// Create a new Ciudade object. 
/// </summary>
public  Ciudade()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  Ciudade(System.String pCodPais , System.String pCodDepartamento , System.String pCodCiudad)
{
_codPais = pCodPais ;
_codDepartamento = pCodDepartamento ;
_codCiudad = pCodCiudad ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
if ( CodPais != null ) _hash += CodPais.ToString();
if ( CodDepartamento != null ) _hash += CodDepartamento.ToString();
if ( CodCiudad != null ) _hash += CodCiudad.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
Ciudade _newCiudade = (pObject as Ciudade); 
if (_newCiudade == null ) return false; 
if (_newCiudade.GetHashCode() == this.GetHashCode() ) return true; 
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
// Call Validator IsRequired for Column : codPais(Type:Required Field Validator)
_error = this.ValidatecodPaisIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : codDepartamento(Type:Required Field Validator)
_error = this.ValidatecodDepartamentoIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : codCiudad(Type:Required Field Validator)
_error = this.ValidatecodCiudadIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(CodPais) ) 
{
   _errors.Add( new Error( "The PK Column (codPais) can not be null!. " ) );
}
if ( String.IsNullOrEmpty(CodDepartamento) ) 
{
   _errors.Add( new Error( "The PK Column (codDepartamento) can not be null!. " ) );
}
if ( String.IsNullOrEmpty(CodCiudad) ) 
{
   _errors.Add( new Error( "The PK Column (codCiudad) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codPais
/// </remarks>
public virtual Error ValidatecodPaisIsRequired()
{
if ( String.IsNullOrEmpty(CodPais) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codPais is required and therefore must have a value." ;
 return _error;
}
 return null;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codDepartamento
/// </remarks>
public virtual Error ValidatecodDepartamentoIsRequired()
{
if ( String.IsNullOrEmpty(CodDepartamento) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codDepartamento is required and therefore must have a value." ;
 return _error;
}
 return null;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codCiudad
/// </remarks>
public virtual Error ValidatecodCiudadIsRequired()
{
if ( String.IsNullOrEmpty(CodCiudad) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codCiudad is required and therefore must have a value." ;
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

