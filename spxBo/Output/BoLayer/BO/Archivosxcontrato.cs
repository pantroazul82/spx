using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class Archivosxcontrato : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _numeroContrato;
private System.Int32 _codOtroSi;
private System.Int32 _codArchivo;
private System.String _nombreArchivo;
private System.String _descripcion;
private Contrato _contrato;

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

public virtual System.Int32 CodArchivo 
{
get
{
return _codArchivo;
}
set 
{
if ( _codArchivo != value) 
{
_codArchivo = value ;
OnPropertyChanged("CodArchivo");
}
}
}

public virtual System.String NombreArchivo 
{
get
{
return _nombreArchivo;
}
set 
{
if ( _nombreArchivo != value) 
{
_nombreArchivo = value ;
OnPropertyChanged("NombreArchivo");
}
}
}

public virtual System.String Descripcion 
{
get
{
return _descripcion;
}
set 
{
if ( _descripcion != value) 
{
_descripcion = value ;
OnPropertyChanged("Descripcion");
}
}
}

/// <summary>
/// Generated from Relation FK_archivosxcontrato_contratos
/// </summary>
[GenWiseAttribute(RelationID = "5c1df3c8-bb59-464e-be97-380154f2cba1") ]
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
_retValue += CodArchivo.ToString();

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
/// Create a new Archivosxcontrato object. 
/// </summary>
public  Archivosxcontrato()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  Archivosxcontrato(System.String pNumeroContrato , System.Int32 pCodOtroSi , System.Int32 pCodArchivo)
{
_numeroContrato = pNumeroContrato ;
_codOtroSi = pCodOtroSi ;
_codArchivo = pCodArchivo ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
if ( NumeroContrato != null ) _hash += NumeroContrato.ToString();
_hash += CodOtroSi.ToString();
_hash += CodArchivo.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
Archivosxcontrato _newArchivosxcontrato = (pObject as Archivosxcontrato); 
if (_newArchivosxcontrato == null ) return false; 
if (_newArchivosxcontrato.GetHashCode() == this.GetHashCode() ) return true; 
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

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(NumeroContrato) ) 
{
   _errors.Add( new Error( "The PK Column (numeroContrato) can not be null!. " ) );
}
if (  CodOtroSi.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codOtroSi) can not be null!. " ) );
}
if (  CodArchivo.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codArchivo) can not be null!. " ) );
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

