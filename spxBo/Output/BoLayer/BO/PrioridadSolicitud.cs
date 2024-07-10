using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class PrioridadSolicitud : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codPrioridadSolicitud;
private System.String _descripcionPrioridad;
private IList<SolicitudServicio> _solicitudServicios;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodPrioridadSolicitud 
{
get
{
return _codPrioridadSolicitud;
}
set 
{
if ( _codPrioridadSolicitud != value) 
{
_codPrioridadSolicitud = value ;
OnPropertyChanged("CodPrioridadSolicitud");
}
}
}

public virtual System.String DescripcionPrioridad 
{
get
{
return _descripcionPrioridad;
}
set 
{
if ( _descripcionPrioridad != value) 
{
_descripcionPrioridad = value ;
OnPropertyChanged("DescripcionPrioridad");
}
}
}

/// <summary>
/// Collection of SolicitudServicio.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "ddebf181-ee35-410a-b778-f4efaecac9cf" , CollectionOfType = typeof(SolicitudServicio)) ]
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
/// Create a new PrioridadSolicitud object. 
/// </summary>
public  PrioridadSolicitud()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  PrioridadSolicitud(System.Int32 pCodPrioridadSolicitud)
{
_codPrioridadSolicitud = pCodPrioridadSolicitud ;

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
if (  CodPrioridadSolicitud.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codPrioridadSolicitud) can not be null!. " ) );
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

