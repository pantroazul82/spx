using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class ModalidadEquipo : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _codModalidadEquipo;
private System.String _nombreModalidadEquipo;
private System.String _descripcion;
private IList<EntradaSalidaEquipo> _entradaSalidaEquipos;
private IList<EntradaSalidaEquipo> _entradaSalidaEquipos1;
private IList<Equipo> _equipos;
private IList<LlamadaSoporte> _llamadaSoportes;
private IList<OrdenServicio> _ordenServicios;
private IList<Recoleccion> _recoleccions;
private IList<SolicitudServicio> _solicitudServicios;

#endregion


#region --- Class Properties ---

public virtual System.String CodModalidadEquipo 
{
get
{
return _codModalidadEquipo;
}
set 
{
if ( _codModalidadEquipo != value) 
{
_codModalidadEquipo = value ;
OnPropertyChanged("CodModalidadEquipo");
}
}
}

public virtual System.String NombreModalidadEquipo 
{
get
{
return _nombreModalidadEquipo;
}
set 
{
if ( _nombreModalidadEquipo != value) 
{
_nombreModalidadEquipo = value ;
OnPropertyChanged("NombreModalidadEquipo");
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
/// Collection of EntradaSalidaEquipo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "4c478760-f598-487d-ab99-839e82832a5a" , CollectionOfType = typeof(EntradaSalidaEquipo)) ]
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
/// Collection of EntradaSalidaEquipo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "3b6f7ac2-4bd4-42cb-a258-555bf5e70da6" , CollectionOfType = typeof(EntradaSalidaEquipo)) ]
public virtual IList<EntradaSalidaEquipo> EntradaSalidaEquipos1 
{
get
{
 if (_entradaSalidaEquipos1 == null) _entradaSalidaEquipos1 = new List<EntradaSalidaEquipo>();

return _entradaSalidaEquipos1;
}
set 
{
if ( _entradaSalidaEquipos1 != value) 
{
_entradaSalidaEquipos1 = value ;
}
}
}

/// <summary>
/// Collection of Equipo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "7cb2b56c-9942-47d1-acc3-e78e06207d33" , CollectionOfType = typeof(Equipo)) ]
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
/// Collection of LlamadaSoporte.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "2260bc53-b2aa-4500-8690-1e75f9b2bd9c" , CollectionOfType = typeof(LlamadaSoporte)) ]
public virtual IList<LlamadaSoporte> LlamadaSoportes 
{
get
{
 if (_llamadaSoportes == null) _llamadaSoportes = new List<LlamadaSoporte>();

return _llamadaSoportes;
}
set 
{
if ( _llamadaSoportes != value) 
{
_llamadaSoportes = value ;
}
}
}

/// <summary>
/// Collection of OrdenServicio.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "f068f931-a3b1-4bf0-bac4-9850432a8da2" , CollectionOfType = typeof(OrdenServicio)) ]
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
/// Collection of Recoleccion.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "c116c71f-3468-4f86-acec-8579e3908ce2" , CollectionOfType = typeof(Recoleccion)) ]
public virtual IList<Recoleccion> Recoleccions 
{
get
{
 if (_recoleccions == null) _recoleccions = new List<Recoleccion>();

return _recoleccions;
}
set 
{
if ( _recoleccions != value) 
{
_recoleccions = value ;
}
}
}

/// <summary>
/// Collection of SolicitudServicio.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "36e471c5-d5b5-443d-a11e-cca7a454a8ec" , CollectionOfType = typeof(SolicitudServicio)) ]
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
/// Create a new ModalidadEquipo object. 
/// </summary>
public  ModalidadEquipo()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  ModalidadEquipo(System.String pCodModalidadEquipo)
{
_codModalidadEquipo = pCodModalidadEquipo ;

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
// Call Validator IsRequired for Column : codModalidadEquipo(Type:Required Field Validator)
_error = this.ValidatecodModalidadEquipoIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(CodModalidadEquipo) ) 
{
   _errors.Add( new Error( "The PK Column (codModalidadEquipo) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codModalidadEquipo
/// </remarks>
public virtual Error ValidatecodModalidadEquipoIsRequired()
{
if ( String.IsNullOrEmpty(CodModalidadEquipo) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codModalidadEquipo is required and therefore must have a value." ;
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

