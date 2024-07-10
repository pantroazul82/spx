using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class RepuestoxOrdenServicio : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codOrdenServicio;
private System.String _codRepuesto;
private System.Int32? _cantidad;
private OrdenServicio _ordenServicio;
private Repuesto _repuesto;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodOrdenServicio 
{
get
{
return _codOrdenServicio;
}
set 
{
if ( _codOrdenServicio != value) 
{
_codOrdenServicio = value ;
OnPropertyChanged("CodOrdenServicio");
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

/// <summary>
/// Generated from Relation FK_repuestoxOrdenServicio_ordenServicio
/// </summary>
[GenWiseAttribute(RelationID = "4d7a967a-d15a-4370-8e98-1f8a035eb0ab") ]
public virtual OrdenServicio OrdenServicio 
{
get
{
if ( _ordenServicio == null ) 
{
if (  _codOrdenServicio.Equals(0)  || _codOrdenServicio.Equals(System.Int32.MinValue) ) 
{
if ( _ordenServicio != null && ( _ordenServicio.CodOrdenServicio.Equals(System.Int32.MinValue) ) )
{
  _ordenServicio = null;
}
}
else
{
_ordenServicio = (new OrdenServicioFactory()).Get(_codOrdenServicio);
}
}

return _ordenServicio;
}
set 
{
if ( _ordenServicio != value) 
{
if ( value==null ) _codOrdenServicio = System.Int32.MinValue; else _codOrdenServicio = (System.Int32)value.CodOrdenServicio; 
_ordenServicio = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_repuestoxOrdenServicio_repuestos
/// </summary>
[GenWiseAttribute(RelationID = "7576e6da-f843-4245-b264-297d9f357f51") ]
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

_retValue += CodOrdenServicio.ToString();

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
/// Create a new RepuestoxOrdenServicio object. 
/// </summary>
public  RepuestoxOrdenServicio()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  RepuestoxOrdenServicio(System.Int32 pCodOrdenServicio , System.String pCodRepuesto)
{
_codOrdenServicio = pCodOrdenServicio ;
_codRepuesto = pCodRepuesto ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
_hash += CodOrdenServicio.ToString();
if ( CodRepuesto != null ) _hash += CodRepuesto.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
RepuestoxOrdenServicio _newRepuestoxOrdenServicio = (pObject as RepuestoxOrdenServicio); 
if (_newRepuestoxOrdenServicio == null ) return false; 
if (_newRepuestoxOrdenServicio.GetHashCode() == this.GetHashCode() ) return true; 
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
// Call Validator IsRequired for Column : codRepuesto(Type:Required Field Validator)
_error = this.ValidatecodRepuestoIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if (  CodOrdenServicio.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codOrdenServicio) can not be null!. " ) );
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

