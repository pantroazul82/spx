using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class Contrato : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _numeroContrato;
private System.Int32 _codOtroSI;
private System.String _nitCliente;
private System.String _codTipoContrato;
private System.Boolean? _incluyeRepuestos;
private System.Int32? _numeroMantenimientos;
private System.Boolean? _incluyeTiquetes;
private System.Boolean? _tienePolizaConsumoMinimo;
private System.Boolean? _consumoMinimoxLinea;
private System.Boolean? _consumoMinimoGeneral;
private System.Decimal? _consumoMinimoTotalLinea;
private System.Decimal? _consumoMinimoAcordado;
private System.DateTime? _fechaInicioContrato;
private System.Int32? _mesesxMantenimiento;
private System.String _observaciones;
private System.DateTime? _fechaFinContrato;
private System.Int32? _timeRptaDiasHabiles;
private System.Int32? _timeRptaHorasHabiles;
private System.Int32? _porcentajeTiquetes;
private System.String _codModalidadContrato;
private System.Decimal? _montoContrato;
private System.String _loginCreacion;
private System.DateTime? _fechaCreacion;
private IList<Archivosxcontrato> _archivosxcontratos;
private IList<ContratosxEquipo> _contratosxEquipos;
private IList<MantenimientosxContrato> _mantenimientosxContratos;
private IList<RepuestosxContrato> _repuestosxContratos;
private Cliente _cliente;
private ModalidadContrato _modalidadContrato;
private TipoContrato _tipoContrato;

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

public virtual System.Int32 CodOtroSI 
{
get
{
return _codOtroSI;
}
set 
{
if ( _codOtroSI != value) 
{
_codOtroSI = value ;
OnPropertyChanged("CodOtroSI");
}
}
}

public virtual System.String NitCliente 
{
get
{
if ( Cliente != null ) 
{
_nitCliente = (System.String)Cliente.NitCliente;
}

return _nitCliente;
}
set 
{
if ( _nitCliente != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_cliente = null;

_nitCliente = value ;
OnPropertyChanged("NitCliente");
}
}
}

public virtual System.String CodTipoContrato 
{
get
{
if ( TipoContrato != null ) 
{
_codTipoContrato = (System.String)TipoContrato.CodTipoContrato;
}

return _codTipoContrato;
}
set 
{
if ( _codTipoContrato != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_modalidadContrato = null;

// Simplified Parent Access Property : reset object reference if simple property changes it's value
_tipoContrato = null;

_codTipoContrato = value ;
OnPropertyChanged("CodTipoContrato");
}
}
}

public virtual System.Boolean? IncluyeRepuestos 
{
get
{
return _incluyeRepuestos;
}
set 
{
if ( _incluyeRepuestos != value) 
{
_incluyeRepuestos = value ;
OnPropertyChanged("IncluyeRepuestos");
}
}
}

public virtual System.Int32? NumeroMantenimientos 
{
get
{
return _numeroMantenimientos;
}
set 
{
if ( _numeroMantenimientos != value) 
{
_numeroMantenimientos = value ;
OnPropertyChanged("NumeroMantenimientos");
}
}
}

public virtual System.Boolean? IncluyeTiquetes 
{
get
{
return _incluyeTiquetes;
}
set 
{
if ( _incluyeTiquetes != value) 
{
_incluyeTiquetes = value ;
OnPropertyChanged("IncluyeTiquetes");
}
}
}

public virtual System.Boolean? TienePolizaConsumoMinimo 
{
get
{
return _tienePolizaConsumoMinimo;
}
set 
{
if ( _tienePolizaConsumoMinimo != value) 
{
_tienePolizaConsumoMinimo = value ;
OnPropertyChanged("TienePolizaConsumoMinimo");
}
}
}

public virtual System.Boolean? ConsumoMinimoxLinea 
{
get
{
return _consumoMinimoxLinea;
}
set 
{
if ( _consumoMinimoxLinea != value) 
{
_consumoMinimoxLinea = value ;
OnPropertyChanged("ConsumoMinimoxLinea");
}
}
}

public virtual System.Boolean? ConsumoMinimoGeneral 
{
get
{
return _consumoMinimoGeneral;
}
set 
{
if ( _consumoMinimoGeneral != value) 
{
_consumoMinimoGeneral = value ;
OnPropertyChanged("ConsumoMinimoGeneral");
}
}
}

public virtual System.Decimal? ConsumoMinimoTotalLinea 
{
get
{
return _consumoMinimoTotalLinea;
}
set 
{
if ( _consumoMinimoTotalLinea != value) 
{
_consumoMinimoTotalLinea = value ;
OnPropertyChanged("ConsumoMinimoTotalLinea");
}
}
}

public virtual System.Decimal? ConsumoMinimoAcordado 
{
get
{
return _consumoMinimoAcordado;
}
set 
{
if ( _consumoMinimoAcordado != value) 
{
_consumoMinimoAcordado = value ;
OnPropertyChanged("ConsumoMinimoAcordado");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaInicioContrato_Date 
{
get
{
if (  !FechaInicioContrato.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaInicioContrato.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaInicioContrato.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaInicioContrato_Time)) {

FechaInicioContrato = null;
}
 else
{
 FechaInicioContrato = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaInicioContrato.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaInicioContrato_Time)) 
{
 FechaInicioContrato = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaInicioContrato = Convert.ToDateTime( " " + value + " " + FechaInicioContrato.Value.ToString("HH:mm:ss.fff") ) ;
}
}

}
}

/// <summary>
/// This property contains a calculated, bindable value of the TIME part of a DateTime property. If you want to only work with the TIME and ignore the underlying DATE component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaInicioContrato_Time 
{
get
{
if (  !FechaInicioContrato.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaInicioContrato.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaInicioContrato.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaInicioContrato_Date)) 
{
FechaInicioContrato = null;
}
 else
{
 FechaInicioContrato = Convert.ToDateTime( " " + FechaInicioContrato.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaInicioContrato_Date)) 
{
 FechaInicioContrato = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaInicioContrato = Convert.ToDateTime( " " + FechaInicioContrato_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaInicioContrato 
{
get
{
return _fechaInicioContrato;
}
set 
{
if ( _fechaInicioContrato != value) 
{
_fechaInicioContrato = value ;
OnPropertyChanged("FechaInicioContrato");
}
}
}

public virtual System.Int32? MesesxMantenimiento 
{
get
{
return _mesesxMantenimiento;
}
set 
{
if ( _mesesxMantenimiento != value) 
{
_mesesxMantenimiento = value ;
OnPropertyChanged("MesesxMantenimiento");
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
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaFinContrato_Date 
{
get
{
if (  !FechaFinContrato.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaFinContrato.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaFinContrato.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaFinContrato_Time)) {

FechaFinContrato = null;
}
 else
{
 FechaFinContrato = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaFinContrato.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaFinContrato_Time)) 
{
 FechaFinContrato = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaFinContrato = Convert.ToDateTime( " " + value + " " + FechaFinContrato.Value.ToString("HH:mm:ss.fff") ) ;
}
}

}
}

/// <summary>
/// This property contains a calculated, bindable value of the TIME part of a DateTime property. If you want to only work with the TIME and ignore the underlying DATE component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaFinContrato_Time 
{
get
{
if (  !FechaFinContrato.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaFinContrato.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaFinContrato.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaFinContrato_Date)) 
{
FechaFinContrato = null;
}
 else
{
 FechaFinContrato = Convert.ToDateTime( " " + FechaFinContrato.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaFinContrato_Date)) 
{
 FechaFinContrato = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaFinContrato = Convert.ToDateTime( " " + FechaFinContrato_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaFinContrato 
{
get
{
return _fechaFinContrato;
}
set 
{
if ( _fechaFinContrato != value) 
{
_fechaFinContrato = value ;
OnPropertyChanged("FechaFinContrato");
}
}
}

public virtual System.Int32? TimeRptaDiasHabiles 
{
get
{
return _timeRptaDiasHabiles;
}
set 
{
if ( _timeRptaDiasHabiles != value) 
{
_timeRptaDiasHabiles = value ;
OnPropertyChanged("TimeRptaDiasHabiles");
}
}
}

public virtual System.Int32? TimeRptaHorasHabiles 
{
get
{
return _timeRptaHorasHabiles;
}
set 
{
if ( _timeRptaHorasHabiles != value) 
{
_timeRptaHorasHabiles = value ;
OnPropertyChanged("TimeRptaHorasHabiles");
}
}
}

public virtual System.Int32? PorcentajeTiquetes 
{
get
{
return _porcentajeTiquetes;
}
set 
{
if ( _porcentajeTiquetes != value) 
{
_porcentajeTiquetes = value ;
OnPropertyChanged("PorcentajeTiquetes");
}
}
}

public virtual System.String CodModalidadContrato 
{
get
{
if ( ModalidadContrato != null ) 
{
_codModalidadContrato = (System.String)ModalidadContrato.CodModalidadContrato;
}

return _codModalidadContrato;
}
set 
{
if ( _codModalidadContrato != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_modalidadContrato = null;

_codModalidadContrato = value ;
OnPropertyChanged("CodModalidadContrato");
}
}
}

public virtual System.Decimal? MontoContrato 
{
get
{
return _montoContrato;
}
set 
{
if ( _montoContrato != value) 
{
_montoContrato = value ;
OnPropertyChanged("MontoContrato");
}
}
}

public virtual System.String LoginCreacion 
{
get
{
return _loginCreacion;
}
set 
{
if ( _loginCreacion != value) 
{
_loginCreacion = value ;
OnPropertyChanged("LoginCreacion");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaCreacion_Date 
{
get
{
if (  !FechaCreacion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaCreacion.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaCreacion.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaCreacion_Time)) {

FechaCreacion = null;
}
 else
{
 FechaCreacion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaCreacion.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaCreacion_Time)) 
{
 FechaCreacion = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaCreacion = Convert.ToDateTime( " " + value + " " + FechaCreacion.Value.ToString("HH:mm:ss.fff") ) ;
}
}

}
}

/// <summary>
/// This property contains a calculated, bindable value of the TIME part of a DateTime property. If you want to only work with the TIME and ignore the underlying DATE component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaCreacion_Time 
{
get
{
if (  !FechaCreacion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaCreacion.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaCreacion.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaCreacion_Date)) 
{
FechaCreacion = null;
}
 else
{
 FechaCreacion = Convert.ToDateTime( " " + FechaCreacion.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaCreacion_Date)) 
{
 FechaCreacion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaCreacion = Convert.ToDateTime( " " + FechaCreacion_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaCreacion 
{
get
{
return _fechaCreacion;
}
set 
{
if ( _fechaCreacion != value) 
{
_fechaCreacion = value ;
OnPropertyChanged("FechaCreacion");
}
}
}

/// <summary>
/// Collection of Archivosxcontrato.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "5c1df3c8-bb59-464e-be97-380154f2cba1" , CollectionOfType = typeof(Archivosxcontrato)) ]
public virtual IList<Archivosxcontrato> Archivosxcontratos 
{
get
{
 if (_archivosxcontratos == null) _archivosxcontratos = new List<Archivosxcontrato>();

return _archivosxcontratos;
}
set 
{
if ( _archivosxcontratos != value) 
{
_archivosxcontratos = value ;
}
}
}

/// <summary>
/// Collection of ContratosxEquipo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "e43535ce-d616-45f9-a9c4-2cd0de7b08a6" , CollectionOfType = typeof(ContratosxEquipo)) ]
public virtual IList<ContratosxEquipo> ContratosxEquipos 
{
get
{
 if (_contratosxEquipos == null) _contratosxEquipos = new List<ContratosxEquipo>();

return _contratosxEquipos;
}
set 
{
if ( _contratosxEquipos != value) 
{
_contratosxEquipos = value ;
}
}
}

/// <summary>
/// Collection of MantenimientosxContrato.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "19357b75-67f3-4bc8-8ac6-d726a076571f" , CollectionOfType = typeof(MantenimientosxContrato)) ]
public virtual IList<MantenimientosxContrato> MantenimientosxContratos 
{
get
{
 if (_mantenimientosxContratos == null) _mantenimientosxContratos = new List<MantenimientosxContrato>();

return _mantenimientosxContratos;
}
set 
{
if ( _mantenimientosxContratos != value) 
{
_mantenimientosxContratos = value ;
}
}
}

/// <summary>
/// Collection of RepuestosxContrato.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "2e1e651b-02b6-48f0-8cc1-8bbac6d69c12" , CollectionOfType = typeof(RepuestosxContrato)) ]
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
/// Generated from Relation FK_contratos_clientes
/// </summary>
[GenWiseAttribute(RelationID = "14e22708-3c1c-4d57-ac1f-d5593f32094d") ]
public virtual Cliente Cliente 
{
get
{
if ( _cliente == null ) 
{
if ( String.IsNullOrEmpty(_nitCliente) || _nitCliente.Equals(string.Empty) ) 
{
if ( _cliente != null && ( _cliente.NitCliente.Equals(null) ) )
{
  _cliente = null;
}
}
else
{
_cliente = (new ClienteFactory()).Get(_nitCliente);
}
}

return _cliente;
}
set 
{
if ( _cliente != value) 
{
if ( value==null ) _nitCliente = null; else _nitCliente = (System.String)value.NitCliente; 
_cliente = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_contratos_modalidadContrato1
/// </summary>
[GenWiseAttribute(RelationID = "8c729e68-9404-481d-856b-60fdc4e8f2c1") ]
public virtual ModalidadContrato ModalidadContrato 
{
get
{
if ( _modalidadContrato == null || _modalidadContrato == null ) 
{
if ( String.IsNullOrEmpty(_codModalidadContrato) || _codModalidadContrato.Equals(string.Empty) || String.IsNullOrEmpty(_codTipoContrato) || _codTipoContrato.Equals(string.Empty) ) 
{
if ( _modalidadContrato != null && ( _modalidadContrato.CodModalidadContrato.Equals(null) || _modalidadContrato.CodTipoContrato.Equals(null) ) )
{
  _modalidadContrato = null;
}
}
else
{
  _modalidadContrato = (new ModalidadContratoFactory()).Fetch(_codModalidadContrato,_codTipoContrato);
}
}

return _modalidadContrato;
}
set 
{
if ( _modalidadContrato != value) 
{
if ( value==null ) _codModalidadContrato = null; else _codModalidadContrato = (System.String)value.CodModalidadContrato; 
if ( value==null ) _codTipoContrato = null; else _codTipoContrato = (System.String)value.CodTipoContrato; 
_modalidadContrato = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_contratos_tipoContrato
/// </summary>
[GenWiseAttribute(RelationID = "b89fa18a-2a3c-4028-a42f-b73f2edade74") ]
public virtual TipoContrato TipoContrato 
{
get
{
if ( _tipoContrato == null ) 
{
if ( String.IsNullOrEmpty(_codTipoContrato) || _codTipoContrato.Equals(string.Empty) ) 
{
if ( _tipoContrato != null && ( _tipoContrato.CodTipoContrato.Equals(null) ) )
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
if ( value==null ) _codTipoContrato = null; else _codTipoContrato = (System.String)value.CodTipoContrato; 
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

if ( NumeroContrato != null ) _retValue += NumeroContrato.ToString();

_retValue += "^";
_retValue += CodOtroSI.ToString();

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
/// Create a new Contrato object. 
/// </summary>
public  Contrato()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  Contrato(System.String pNumeroContrato , System.Int32 pCodOtroSI)
{
_numeroContrato = pNumeroContrato ;
_codOtroSI = pCodOtroSI ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
if ( NumeroContrato != null ) _hash += NumeroContrato.ToString();
_hash += CodOtroSI.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
Contrato _newContrato = (pObject as Contrato); 
if (_newContrato == null ) return false; 
if (_newContrato.GetHashCode() == this.GetHashCode() ) return true; 
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
if (  CodOtroSI.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codOtroSI) can not be null!. " ) );
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

