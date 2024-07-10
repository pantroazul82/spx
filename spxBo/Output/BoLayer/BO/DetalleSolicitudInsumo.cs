using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class DetalleSolicitudInsumo : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codOrdenServicio;
private System.Int32 _codSolicitud;
private System.Int32 _codDetalle;
private System.String _codRepuesto;
private System.Int32? _cantidad;
private Repuesto _repuesto;
private SolicitudInsumo _solicitudInsumo;

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

public virtual System.Int32 CodSolicitud 
{
get
{
return _codSolicitud;
}
set 
{
if ( _codSolicitud != value) 
{
_codSolicitud = value ;
OnPropertyChanged("CodSolicitud");
}
}
}

public virtual System.Int32 CodDetalle 
{
get
{
return _codDetalle;
}
set 
{
if ( _codDetalle != value) 
{
_codDetalle = value ;
OnPropertyChanged("CodDetalle");
}
}
}

public virtual System.String CodRepuesto 
{
get
{
if ( Repuesto != null ) 
{
_codRepuesto = (System.String)Repuesto.CodRepuesto;
}

return _codRepuesto;
}
set 
{
if ( _codRepuesto != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_repuesto = null;

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
/// Generated from Relation FK_detalleSolicitudInsumos_repuestos
/// </summary>
[GenWiseAttribute(RelationID = "7c1b2b7d-740b-43d4-adfb-35c10e8e6fed") ]
public virtual Repuesto Repuesto 
{
get
{
if ( _repuesto == null ) 
{
if ( String.IsNullOrEmpty(_codRepuesto) || _codRepuesto.Equals(string.Empty) ) 
{
if ( _repuesto != null && ( _repuesto.CodRepuesto.Equals(null) ) )
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
if ( value==null ) _codRepuesto = null; else _codRepuesto = (System.String)value.CodRepuesto; 
_repuesto = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_detalleSolicitudInsumos_solicitudInsumos
/// </summary>
[GenWiseAttribute(RelationID = "a83bee8a-81fb-4cd3-847b-79a8eac0511d") ]
public virtual SolicitudInsumo SolicitudInsumo 
{
get
{
if ( _solicitudInsumo == null || _solicitudInsumo == null ) 
{
if (  _codOrdenServicio.Equals(0)  || _codOrdenServicio.Equals(System.Int32.MinValue) ||  _codSolicitud.Equals(0)  || _codSolicitud.Equals(System.Int32.MinValue) ) 
{
if ( _solicitudInsumo != null && ( _solicitudInsumo.CodOrdenServicio.Equals(System.Int32.MinValue) || _solicitudInsumo.CodSolicitud.Equals(System.Int32.MinValue) ) )
{
  _solicitudInsumo = null;
}
}
else
{
  _solicitudInsumo = (new SolicitudInsumoFactory()).Fetch(_codOrdenServicio,_codSolicitud);
}
}

return _solicitudInsumo;
}
set 
{
if ( _solicitudInsumo != value) 
{
if ( value==null ) _codOrdenServicio = System.Int32.MinValue; else _codOrdenServicio = (System.Int32)value.CodOrdenServicio; 
if ( value==null ) _codSolicitud = System.Int32.MinValue; else _codSolicitud = (System.Int32)value.CodSolicitud; 
_solicitudInsumo = value ;
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
_retValue += CodSolicitud.ToString();

_retValue += "^";
_retValue += CodDetalle.ToString();

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
/// Create a new DetalleSolicitudInsumo object. 
/// </summary>
public  DetalleSolicitudInsumo()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  DetalleSolicitudInsumo(System.Int32 pCodOrdenServicio , System.Int32 pCodSolicitud , System.Int32 pCodDetalle)
{
_codOrdenServicio = pCodOrdenServicio ;
_codSolicitud = pCodSolicitud ;
_codDetalle = pCodDetalle ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
_hash += CodOrdenServicio.ToString();
_hash += CodSolicitud.ToString();
_hash += CodDetalle.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
DetalleSolicitudInsumo _newDetalleSolicitudInsumo = (pObject as DetalleSolicitudInsumo); 
if (_newDetalleSolicitudInsumo == null ) return false; 
if (_newDetalleSolicitudInsumo.GetHashCode() == this.GetHashCode() ) return true; 
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

// Primary Key Validation (Template Option)
if (  CodOrdenServicio.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codOrdenServicio) can not be null!. " ) );
}
if (  CodSolicitud.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codSolicitud) can not be null!. " ) );
}
if (  CodDetalle.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codDetalle) can not be null!. " ) );
}

return _errors;
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

