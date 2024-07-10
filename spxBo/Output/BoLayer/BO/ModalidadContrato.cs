using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class ModalidadContrato : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _codModalidadContrato;
private System.String _codTipoContrato;
private System.String _nombreModalidadContrato;
private System.String _desccripcion;
private IList<Contrato> _contratos;
private TipoContrato _tipoContrato;

#endregion


#region --- Class Properties ---

public virtual System.String CodModalidadContrato 
{
get
{
return _codModalidadContrato;
}
set 
{
if ( _codModalidadContrato != value) 
{
_codModalidadContrato = value ;
OnPropertyChanged("CodModalidadContrato");
}
}
}

public virtual System.String CodTipoContrato 
{
get
{
return _codTipoContrato;
}
set 
{
if ( _codTipoContrato != value) 
{
_codTipoContrato = value ;
OnPropertyChanged("CodTipoContrato");
}
}
}

public virtual System.String NombreModalidadContrato 
{
get
{
return _nombreModalidadContrato;
}
set 
{
if ( _nombreModalidadContrato != value) 
{
_nombreModalidadContrato = value ;
OnPropertyChanged("NombreModalidadContrato");
}
}
}

public virtual System.String Desccripcion 
{
get
{
return _desccripcion;
}
set 
{
if ( _desccripcion != value) 
{
_desccripcion = value ;
OnPropertyChanged("Desccripcion");
}
}
}

/// <summary>
/// Collection of Contrato.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "8c729e68-9404-481d-856b-60fdc4e8f2c1" , CollectionOfType = typeof(Contrato)) ]
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
/// Generated from Relation FK_modalidadContrato_tipoContrato
/// </summary>
[GenWiseAttribute(RelationID = "12358cae-368b-45ef-a6ee-06aacc70579d") ]
public virtual TipoContrato TipoContrato 
{
get
{
if ( _tipoContrato == null ) 
{
if ( String.IsNullOrEmpty(_codTipoContrato) || _codTipoContrato.Equals(string.Empty) ) 
{
if ( _tipoContrato != null && ( _tipoContrato.CodTipoContrato.Equals(string.Empty) ) )
{
  _tipoContrato = null;
}
}
else
{
_tipoContrato = (new TipoContratoFactory()).Get(_codTipoContrato);
}
}

return _tipoContrato;
}
set 
{
if ( _tipoContrato != value) 
{
if ( value==null ) _codTipoContrato = string.Empty; else _codTipoContrato = (System.String)value.CodTipoContrato; 
_tipoContrato = value ;
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

if ( CodModalidadContrato != null ) _retValue += CodModalidadContrato.ToString();

_retValue += "^";
if ( CodTipoContrato != null ) _retValue += CodTipoContrato.ToString();

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
/// Create a new ModalidadContrato object. 
/// </summary>
public  ModalidadContrato()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  ModalidadContrato(System.String pCodModalidadContrato , System.String pCodTipoContrato)
{
_codModalidadContrato = pCodModalidadContrato ;
_codTipoContrato = pCodTipoContrato ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
if ( CodModalidadContrato != null ) _hash += CodModalidadContrato.ToString();
if ( CodTipoContrato != null ) _hash += CodTipoContrato.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
ModalidadContrato _newModalidadContrato = (pObject as ModalidadContrato); 
if (_newModalidadContrato == null ) return false; 
if (_newModalidadContrato.GetHashCode() == this.GetHashCode() ) return true; 
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
// Call Validator IsRequired for Column : codModalidadContrato(Type:Required Field Validator)
_error = this.ValidatecodModalidadContratoIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : codTipoContrato(Type:Required Field Validator)
_error = this.ValidatecodTipoContratoIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(CodModalidadContrato) ) 
{
   _errors.Add( new Error( "The PK Column (codModalidadContrato) can not be null!. " ) );
}
if ( String.IsNullOrEmpty(CodTipoContrato) ) 
{
   _errors.Add( new Error( "The PK Column (codTipoContrato) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codModalidadContrato
/// </remarks>
public virtual Error ValidatecodModalidadContratoIsRequired()
{
if ( String.IsNullOrEmpty(CodModalidadContrato) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codModalidadContrato is required and therefore must have a value." ;
 return _error;
}
 return null;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codTipoContrato
/// </remarks>
public virtual Error ValidatecodTipoContratoIsRequired()
{
if ( String.IsNullOrEmpty(CodTipoContrato) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codTipoContrato is required and therefore must have a value." ;
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

