using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class RepuestosxContrato : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _numeroContrato;
private System.Int32 _codOtroSi;
private System.String _codRepuesto;
private System.Int32? _cantidad;
private System.String _observaciones;
private Contrato _contrato;
private Repuesto _repuesto;

#endregion


#region --- Class Properties ---

public virtual System.String NumeroContrato 
{
get
{
return _numeroContrato;
}
set 
{
if ( _numeroContrato != value) 
{
_numeroContrato = value ;
OnPropertyChanged("NumeroContrato");
}
}
}

public virtual System.Int32 CodOtroSi 
{
get
{
return _codOtroSi;
}
set 
{
if ( _codOtroSi != value) 
{
_codOtroSi = value ;
OnPropertyChanged("CodOtroSi");
}
}
}

public virtual System.String CodRepuesto 
{
get
{
return _codRepuesto;
}
set 
{
if ( _codRepuesto != value) 
{
_codRepuesto = value ;
OnPropertyChanged("CodRepuesto");
}
}
}

public virtual System.Int32? Cantidad 
{
get
{
return _cantidad;
}
set 
{
if ( _cantidad != value) 
{
_cantidad = value ;
OnPropertyChanged("Cantidad");
}
}
}

public virtual System.String Observaciones 
{
get
{
return _observaciones;
}
set 
{
if ( _observaciones != value) 
{
_observaciones = value ;
OnPropertyChanged("Observaciones");
}
}
}

/// <summary>
/// Generated from Relation FK_repuestosxContratos_contratos
/// </summary>
[GenWiseAttribute(RelationID = "2e1e651b-02b6-48f0-8cc1-8bbac6d69c12") ]
public virtual Contrato Contrato 
{
get
{
if ( _contrato == null || _contrato == null ) 
{
if ( String.IsNullOrEmpty(_numeroContrato) || _numeroContrato.Equals(string.Empty) ||  _codOtroSi.Equals(0)  || _codOtroSi.Equals(System.Int32.MinValue) ) 
{
if ( _contrato != null && ( _contrato.NumeroContrato.Equals(string.Empty) || _contrato.CodOtroSI.Equals(System.Int32.MinValue) ) )
{
  _contrato = null;
}
}
else
{
  _contrato = (new ContratoFactory()).Fetch(_numeroContrato,_codOtroSi);
}
}

return _contrato;
}
set 
{
if ( _contrato != value) 
{
if ( value==null ) _numeroContrato = string.Empty; else _numeroContrato = (System.String)value.NumeroContrato; 
if ( value==null ) _codOtroSi = System.Int32.MinValue; else _codOtroSi = (System.Int32)value.CodOtroSI; 
_contrato = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_repuestosxContratos_repuestos
/// </summary>
[GenWiseAttribute(RelationID = "aaee4d56-ce06-4d0f-b682-b4b615db338e") ]
public virtual Repuesto Repuesto 
{
get
{
if ( _repuesto == null ) 
{
if ( String.IsNullOrEmpty(_codRepuesto) || _codRepuesto.Equals(string.Empty) ) 
{
if ( _repuesto != null && ( _repuesto.CodRepuesto.Equals(string.Empty) ) )
{
  _repuesto = null;
}
}
else
{
_repuesto = (new RepuestoFactory()).Get(_codRepuesto);
}
}

return _repuesto;
}
set 
{
if ( _repuesto != value) 
{
if ( value==null ) _codRepuesto = string.Empty; else _codRepuesto = (System.String)value.CodRepuesto; 
_repuesto = value ;
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

if ( NumeroContrato != null ) _retValue += NumeroContrato.ToString();

_retValue += "^";
_retValue += CodOtroSi.ToString();

_retValue += "^";
if ( CodRepuesto != null ) _retValue += CodRepuesto.ToString();

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
/// Create a new RepuestosxContrato object. 
/// </summary>
public  RepuestosxContrato()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  RepuestosxContrato(System.String pNumeroContrato , System.Int32 pCodOtroSi , System.String pCodRepuesto)
{
_numeroContrato = pNumeroContrato ;
_codOtroSi = pCodOtroSi ;
_codRepuesto = pCodRepuesto ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
if ( NumeroContrato != null ) _hash += NumeroContrato.ToString();
_hash += CodOtroSi.ToString();
if ( CodRepuesto != null ) _hash += CodRepuesto.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
RepuestosxContrato _newRepuestosxContrato = (pObject as RepuestosxContrato); 
if (_newRepuestosxContrato == null ) return false; 
if (_newRepuestosxContrato.GetHashCode() == this.GetHashCode() ) return true; 
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
// Call Validator IsRequired for Column : numeroContrato(Type:Required Field Validator)
_error = this.ValidatenumeroContratoIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : codRepuesto(Type:Required Field Validator)
_error = this.ValidatecodRepuestoIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(NumeroContrato) ) 
{
   _errors.Add( new Error( "The PK Column (numeroContrato) can not be null!. " ) );
}
if (  CodOtroSi.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codOtroSi) can not be null!. " ) );
}
if ( String.IsNullOrEmpty(CodRepuesto) ) 
{
   _errors.Add( new Error( "The PK Column (codRepuesto) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : numeroContrato
/// </remarks>
public virtual Error ValidatenumeroContratoIsRequired()
{
if ( String.IsNullOrEmpty(NumeroContrato) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "numeroContrato is required and therefore must have a value." ;
 return _error;
}
 return null;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codRepuesto
/// </remarks>
public virtual Error ValidatecodRepuestoIsRequired()
{
if ( String.IsNullOrEmpty(CodRepuesto) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codRepuesto is required and therefore must have a value." ;
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

