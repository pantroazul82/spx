using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class Repuesto : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _codRepuesto;
private System.String _descripcion;
private System.Decimal? _precio;
private System.String _observaciones;
private IList<DetalleSolicitudInsumo> _detalleSolicitudInsumos;
private IList<RepuestosxContrato> _repuestosxContratos;
private IList<RepuestosxOrdenPrestamo> _repuestosxOrdenPrestamos;
private IList<RepuestoxOrdenServicio> _repuestoxOrdenServicios;

#endregion


#region --- Class Properties ---

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

public virtual System.Decimal? Precio 
{
get
{
return _precio;
}
set 
{
if ( _precio != value) 
{
_precio = value ;
OnPropertyChanged("Precio");
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
/// Collection of DetalleSolicitudInsumo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "7c1b2b7d-740b-43d4-adfb-35c10e8e6fed" , CollectionOfType = typeof(DetalleSolicitudInsumo)) ]
public virtual IList<DetalleSolicitudInsumo> DetalleSolicitudInsumos 
{
get
{
 if (_detalleSolicitudInsumos == null) _detalleSolicitudInsumos = new List<DetalleSolicitudInsumo>();

return _detalleSolicitudInsumos;
}
set 
{
if ( _detalleSolicitudInsumos != value) 
{
_detalleSolicitudInsumos = value ;
}
}
}

/// <summary>
/// Collection of RepuestosxContrato.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "aaee4d56-ce06-4d0f-b682-b4b615db338e" , CollectionOfType = typeof(RepuestosxContrato)) ]
public virtual IList<RepuestosxContrato> RepuestosxContratos 
{
get
{
 if (_repuestosxContratos == null) _repuestosxContratos = new List<RepuestosxContrato>();

return _repuestosxContratos;
}
set 
{
if ( _repuestosxContratos != value) 
{
_repuestosxContratos = value ;
}
}
}

/// <summary>
/// Collection of RepuestosxOrdenPrestamo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "0adff025-e44a-49bb-8be0-6aa0a8de2cac" , CollectionOfType = typeof(RepuestosxOrdenPrestamo)) ]
public virtual IList<RepuestosxOrdenPrestamo> RepuestosxOrdenPrestamos 
{
get
{
 if (_repuestosxOrdenPrestamos == null) _repuestosxOrdenPrestamos = new List<RepuestosxOrdenPrestamo>();

return _repuestosxOrdenPrestamos;
}
set 
{
if ( _repuestosxOrdenPrestamos != value) 
{
_repuestosxOrdenPrestamos = value ;
}
}
}

/// <summary>
/// Collection of RepuestoxOrdenServicio.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "7576e6da-f843-4245-b264-297d9f357f51" , CollectionOfType = typeof(RepuestoxOrdenServicio)) ]
public virtual IList<RepuestoxOrdenServicio> RepuestoxOrdenServicios 
{
get
{
 if (_repuestoxOrdenServicios == null) _repuestoxOrdenServicios = new List<RepuestoxOrdenServicio>();

return _repuestoxOrdenServicios;
}
set 
{
if ( _repuestoxOrdenServicios != value) 
{
_repuestoxOrdenServicios = value ;
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
/// Create a new Repuesto object. 
/// </summary>
public  Repuesto()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  Repuesto(System.String pCodRepuesto)
{
_codRepuesto = pCodRepuesto ;

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
// Call Validator IsRequired for Column : codRepuesto(Type:Required Field Validator)
_error = this.ValidatecodRepuestoIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
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

