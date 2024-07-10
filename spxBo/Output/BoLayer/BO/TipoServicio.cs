using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class TipoServicio : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _codTipoServicio;
private System.String _nombretipoServicio;
private System.String _descripcion;
private System.Boolean? _devuelveTaller;
private System.Boolean? _validoContrato;
private System.Boolean? _preventivo;
private System.Boolean? _correctivo;
private System.Boolean? _devuelveEntrada;
private IList<DetalleProgramacionViaje> _detalleProgramacionViajes;
private IList<EntradaSalidaEquipo> _entradaSalidaEquipos;
private IList<Equipo> _equipos;
private IList<OrdenServicio> _ordenServicios;
private IList<SolicitudServicio> _solicitudServicios;

#endregion


#region --- Class Properties ---

public virtual System.String CodTipoServicio 
{
get
{
return _codTipoServicio;
}
set 
{
if ( _codTipoServicio != value) 
{
_codTipoServicio = value ;
OnPropertyChanged("CodTipoServicio");
}
}
}

public virtual System.String NombretipoServicio 
{
get
{
return _nombretipoServicio;
}
set 
{
if ( _nombretipoServicio != value) 
{
_nombretipoServicio = value ;
OnPropertyChanged("NombretipoServicio");
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

public virtual System.Boolean? DevuelveTaller 
{
get
{
return _devuelveTaller;
}
set 
{
if ( _devuelveTaller != value) 
{
_devuelveTaller = value ;
OnPropertyChanged("DevuelveTaller");
}
}
}

public virtual System.Boolean? ValidoContrato 
{
get
{
return _validoContrato;
}
set 
{
if ( _validoContrato != value) 
{
_validoContrato = value ;
OnPropertyChanged("ValidoContrato");
}
}
}

public virtual System.Boolean? Preventivo 
{
get
{
return _preventivo;
}
set 
{
if ( _preventivo != value) 
{
_preventivo = value ;
OnPropertyChanged("Preventivo");
}
}
}

public virtual System.Boolean? Correctivo 
{
get
{
return _correctivo;
}
set 
{
if ( _correctivo != value) 
{
_correctivo = value ;
OnPropertyChanged("Correctivo");
}
}
}

public virtual System.Boolean? DevuelveEntrada 
{
get
{
return _devuelveEntrada;
}
set 
{
if ( _devuelveEntrada != value) 
{
_devuelveEntrada = value ;
OnPropertyChanged("DevuelveEntrada");
}
}
}

/// <summary>
/// Collection of DetalleProgramacionViaje.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "6942c4bf-4f12-4c75-8cb8-41981fe14480" , CollectionOfType = typeof(DetalleProgramacionViaje)) ]
public virtual IList<DetalleProgramacionViaje> DetalleProgramacionViajes 
{
get
{
 if (_detalleProgramacionViajes == null) _detalleProgramacionViajes = new List<DetalleProgramacionViaje>();

return _detalleProgramacionViajes;
}
set 
{
if ( _detalleProgramacionViajes != value) 
{
_detalleProgramacionViajes = value ;
}
}
}

/// <summary>
/// Collection of EntradaSalidaEquipo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "c95cb4a8-6e93-409c-ad32-18cd4e24b2e9" , CollectionOfType = typeof(EntradaSalidaEquipo)) ]
public virtual IList<EntradaSalidaEquipo> EntradaSalidaEquipos 
{
get
{
 if (_entradaSalidaEquipos == null) _entradaSalidaEquipos = new List<EntradaSalidaEquipo>();

return _entradaSalidaEquipos;
}
set 
{
if ( _entradaSalidaEquipos != value) 
{
_entradaSalidaEquipos = value ;
}
}
}

/// <summary>
/// Collection of Equipo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "046ed500-cfc8-4001-887d-c7dd6296502a" , CollectionOfType = typeof(Equipo)) ]
public virtual IList<Equipo> Equipos 
{
get
{
 if (_equipos == null) _equipos = new List<Equipo>();

return _equipos;
}
set 
{
if ( _equipos != value) 
{
_equipos = value ;
}
}
}

/// <summary>
/// Collection of OrdenServicio.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "bdec0077-42ba-4764-8979-c26ab741f348" , CollectionOfType = typeof(OrdenServicio)) ]
public virtual IList<OrdenServicio> OrdenServicios 
{
get
{
 if (_ordenServicios == null) _ordenServicios = new List<OrdenServicio>();

return _ordenServicios;
}
set 
{
if ( _ordenServicios != value) 
{
_ordenServicios = value ;
}
}
}

/// <summary>
/// Collection of SolicitudServicio.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "7cf67f05-b70e-44d1-a995-24c092634182" , CollectionOfType = typeof(SolicitudServicio)) ]
public virtual IList<SolicitudServicio> SolicitudServicios 
{
get
{
 if (_solicitudServicios == null) _solicitudServicios = new List<SolicitudServicio>();

return _solicitudServicios;
}
set 
{
if ( _solicitudServicios != value) 
{
_solicitudServicios = value ;
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
/// Create a new TipoServicio object. 
/// </summary>
public  TipoServicio()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  TipoServicio(System.String pCodTipoServicio)
{
_codTipoServicio = pCodTipoServicio ;

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
// Call Validator IsRequired for Column : codTipoServicio(Type:Required Field Validator)
_error = this.ValidatecodTipoServicioIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(CodTipoServicio) ) 
{
   _errors.Add( new Error( "The PK Column (codTipoServicio) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codTipoServicio
/// </remarks>
public virtual Error ValidatecodTipoServicioIsRequired()
{
if ( String.IsNullOrEmpty(CodTipoServicio) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codTipoServicio is required and therefore must have a value." ;
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

