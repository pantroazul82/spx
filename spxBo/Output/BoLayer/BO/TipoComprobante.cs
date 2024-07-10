using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class TipoComprobante : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _codTipoComprobante;
private System.String _nombreTipoComprobante;
private IList<ComprobantesAceptacionOrdenservicio> _comprobantesAceptacionOrdenservicios;

#endregion


#region --- Class Properties ---

public virtual System.String CodTipoComprobante 
{
get
{
return _codTipoComprobante;
}
set 
{
if ( _codTipoComprobante != value) 
{
_codTipoComprobante = value ;
OnPropertyChanged("CodTipoComprobante");
}
}
}

public virtual System.String NombreTipoComprobante 
{
get
{
return _nombreTipoComprobante;
}
set 
{
if ( _nombreTipoComprobante != value) 
{
_nombreTipoComprobante = value ;
OnPropertyChanged("NombreTipoComprobante");
}
}
}

/// <summary>
/// Collection of ComprobantesAceptacionOrdenservicio.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "79f3658c-eb64-446b-b1f4-605c83857583" , CollectionOfType = typeof(ComprobantesAceptacionOrdenservicio)) ]
public virtual IList<ComprobantesAceptacionOrdenservicio> ComprobantesAceptacionOrdenservicios 
{
get
{
 if (_comprobantesAceptacionOrdenservicios == null) _comprobantesAceptacionOrdenservicios = new List<ComprobantesAceptacionOrdenservicio>();

return _comprobantesAceptacionOrdenservicios;
}
set 
{
if ( _comprobantesAceptacionOrdenservicios != value) 
{
_comprobantesAceptacionOrdenservicios = value ;
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
/// Create a new TipoComprobante object. 
/// </summary>
public  TipoComprobante()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  TipoComprobante(System.String pCodTipoComprobante)
{
_codTipoComprobante = pCodTipoComprobante ;

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
// Call Validator IsRequired for Column : codTipoComprobante(Type:Required Field Validator)
_error = this.ValidatecodTipoComprobanteIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(CodTipoComprobante) ) 
{
   _errors.Add( new Error( "The PK Column (codTipoComprobante) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codTipoComprobante
/// </remarks>
public virtual Error ValidatecodTipoComprobanteIsRequired()
{
if ( String.IsNullOrEmpty(CodTipoComprobante) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codTipoComprobante is required and therefore must have a value." ;
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

