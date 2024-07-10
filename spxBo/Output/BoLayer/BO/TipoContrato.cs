using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class TipoContrato : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _codTipoContrato;
private System.String _nombreTipoContrato;
private System.String _descripcion;
private System.Boolean? _deMantenimiento;
private System.Boolean? _deConsumo;
private IList<Contrato> _contratos;
private IList<ModalidadContrato> _modalidadContratos;

#endregion


#region --- Class Properties ---

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

public virtual System.String NombreTipoContrato 
{
get
{
return _nombreTipoContrato;
}
set 
{
if ( _nombreTipoContrato != value) 
{
_nombreTipoContrato = value ;
OnPropertyChanged("NombreTipoContrato");
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

public virtual System.Boolean? DeMantenimiento 
{
get
{
return _deMantenimiento;
}
set 
{
if ( _deMantenimiento != value) 
{
_deMantenimiento = value ;
OnPropertyChanged("DeMantenimiento");
}
}
}

public virtual System.Boolean? DeConsumo 
{
get
{
return _deConsumo;
}
set 
{
if ( _deConsumo != value) 
{
_deConsumo = value ;
OnPropertyChanged("DeConsumo");
}
}
}

/// <summary>
/// Collection of Contrato.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "b89fa18a-2a3c-4028-a42f-b73f2edade74" , CollectionOfType = typeof(Contrato)) ]
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
/// Collection of ModalidadContrato.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "12358cae-368b-45ef-a6ee-06aacc70579d" , CollectionOfType = typeof(ModalidadContrato)) ]
public virtual IList<ModalidadContrato> ModalidadContratos 
{
get
{
 if (_modalidadContratos == null) _modalidadContratos = new List<ModalidadContrato>();

return _modalidadContratos;
}
set 
{
if ( _modalidadContratos != value) 
{
_modalidadContratos = value ;
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
/// Create a new TipoContrato object. 
/// </summary>
public  TipoContrato()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  TipoContrato(System.String pCodTipoContrato)
{
_codTipoContrato = pCodTipoContrato ;

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
// Call Validator IsRequired for Column : codTipoContrato(Type:Required Field Validator)
_error = this.ValidatecodTipoContratoIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
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

