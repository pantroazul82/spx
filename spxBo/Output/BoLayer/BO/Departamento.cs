using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class Departamento : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _codPais;
private System.String _codDepartamento;
private System.String _nombreDepartamento;
private IList<Ciudade> _ciudades;
private Paise _paise;

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

/// <summary>
/// Collection of Ciudade.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "e84cb356-cb84-410b-99ea-ffd27fe6b6fb" , CollectionOfType = typeof(Ciudade)) ]
public virtual IList<Ciudade> Ciudades 
{
get
{
 if (_ciudades == null) _ciudades = new List<Ciudade>();

return _ciudades;
}
set 
{
if ( _ciudades != value) 
{
_ciudades = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_departamento_paises
/// </summary>
[GenWiseAttribute(RelationID = "5a0b777e-cd7a-443b-a9ef-3b76cb32708e") ]
public virtual Paise Paise 
{
get
{
if ( _paise == null ) 
{
if ( String.IsNullOrEmpty(_codPais) || _codPais.Equals(string.Empty) ) 
{
if ( _paise != null && ( _paise.CodPais.Equals(string.Empty) ) )
{
  _paise = null;
}
}
else
{
_paise = (new PaiseFactory()).Get(_codPais);
}
}

return _paise;
}
set 
{
if ( _paise != value) 
{
if ( value==null ) _codPais = string.Empty; else _codPais = (System.String)value.CodPais; 
_paise = value ;
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
/// Create a new Departamento object. 
/// </summary>
public  Departamento()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  Departamento(System.String pCodPais , System.String pCodDepartamento)
{
_codPais = pCodPais ;
_codDepartamento = pCodDepartamento ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
if ( CodPais != null ) _hash += CodPais.ToString();
if ( CodDepartamento != null ) _hash += CodDepartamento.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
Departamento _newDepartamento = (pObject as Departamento); 
if (_newDepartamento == null ) return false; 
if (_newDepartamento.GetHashCode() == this.GetHashCode() ) return true; 
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

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(CodPais) ) 
{
   _errors.Add( new Error( "The PK Column (codPais) can not be null!. " ) );
}
if ( String.IsNullOrEmpty(CodDepartamento) ) 
{
   _errors.Add( new Error( "The PK Column (codDepartamento) can not be null!. " ) );
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

