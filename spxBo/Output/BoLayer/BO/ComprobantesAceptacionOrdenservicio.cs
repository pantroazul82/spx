using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class ComprobantesAceptacionOrdenservicio : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codComprobantesAceptacionOrdenservicio;
private System.Int32 _codOrdenServicio;
private System.String _descripcion;
private System.String _codTipoComprobante;
private System.String _nombre;
private OrdenServicio _ordenServicio;
private TipoComprobante _tipoComprobante;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodComprobantesAceptacionOrdenservicio 
{
get
{
return _codComprobantesAceptacionOrdenservicio;
}
set 
{
if ( _codComprobantesAceptacionOrdenservicio != value) 
{
_codComprobantesAceptacionOrdenservicio = value ;
OnPropertyChanged("CodComprobantesAceptacionOrdenservicio");
}
}
}

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

public virtual System.String CodTipoComprobante 
{
get
{
if ( TipoComprobante != null ) 
{
_codTipoComprobante = (System.String)TipoComprobante.CodTipoComprobante;
}

return _codTipoComprobante;
}
set 
{
if ( _codTipoComprobante != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_tipoComprobante = null;

_codTipoComprobante = value ;
OnPropertyChanged("CodTipoComprobante");
}
}
}

public virtual System.String Nombre 
{
get
{
return _nombre;
}
set 
{
if ( _nombre != value) 
{
_nombre = value ;
OnPropertyChanged("Nombre");
}
}
}

/// <summary>
/// Generated from Relation FK_comprobantesAceptacionOrdenservicio_ordenServicio
/// </summary>
[GenWiseAttribute(RelationID = "6d7dfbd0-1a61-4530-9fa1-ee7730b66779") ]
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
/// Generated from Relation FK_comprobantesAceptacionOrdenservicio_tipoComprobante
/// </summary>
[GenWiseAttribute(RelationID = "79f3658c-eb64-446b-b1f4-605c83857583") ]
public virtual TipoComprobante TipoComprobante 
{
get
{
if ( _tipoComprobante == null ) 
{
if ( String.IsNullOrEmpty(_codTipoComprobante) || _codTipoComprobante.Equals(string.Empty) ) 
{
if ( _tipoComprobante != null && ( _tipoComprobante.CodTipoComprobante.Equals(null) ) )
{
  _tipoComprobante = null;
}
}
else
{
_tipoComprobante = (new TipoComprobanteFactory()).Get(_codTipoComprobante);
}
}

return _tipoComprobante;
}
set 
{
if ( _tipoComprobante != value) 
{
if ( value==null ) _codTipoComprobante = null; else _codTipoComprobante = (System.String)value.CodTipoComprobante; 
_tipoComprobante = value ;
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

_retValue += CodComprobantesAceptacionOrdenservicio.ToString();

_retValue += "^";
_retValue += CodOrdenServicio.ToString();

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
/// Create a new ComprobantesAceptacionOrdenservicio object. 
/// </summary>
public  ComprobantesAceptacionOrdenservicio()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  ComprobantesAceptacionOrdenservicio(System.Int32 pCodComprobantesAceptacionOrdenservicio , System.Int32 pCodOrdenServicio)
{
_codComprobantesAceptacionOrdenservicio = pCodComprobantesAceptacionOrdenservicio ;
_codOrdenServicio = pCodOrdenServicio ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
_hash += CodComprobantesAceptacionOrdenservicio.ToString();
_hash += CodOrdenServicio.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
ComprobantesAceptacionOrdenservicio _newComprobantesAceptacionOrdenservicio = (pObject as ComprobantesAceptacionOrdenservicio); 
if (_newComprobantesAceptacionOrdenservicio == null ) return false; 
if (_newComprobantesAceptacionOrdenservicio.GetHashCode() == this.GetHashCode() ) return true; 
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
if (  CodComprobantesAceptacionOrdenservicio.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codComprobantesAceptacionOrdenservicio) can not be null!. " ) );
}
if (  CodOrdenServicio.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codOrdenServicio) can not be null!. " ) );
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

