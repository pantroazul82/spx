﻿using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class EstadosSolicitud : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codEstadoSolicitud;
private System.String _descripcionSolicitud;
private IList<SolicitudServicio> _solicitudServicios;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodEstadoSolicitud 
{
get
{
return _codEstadoSolicitud;
}
set 
{
if ( _codEstadoSolicitud != value) 
{
_codEstadoSolicitud = value ;
OnPropertyChanged("CodEstadoSolicitud");
}
}
}

public virtual System.String DescripcionSolicitud 
{
get
{
return _descripcionSolicitud;
}
set 
{
if ( _descripcionSolicitud != value) 
{
_descripcionSolicitud = value ;
OnPropertyChanged("DescripcionSolicitud");
}
}
}

/// <summary>
/// Collection of SolicitudServicio.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "2214f531-990c-4233-9657-a814a4df0907" , CollectionOfType = typeof(SolicitudServicio)) ]
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
/// Create a new EstadosSolicitud object. 
/// </summary>
public  EstadosSolicitud()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  EstadosSolicitud(System.Int32 pCodEstadoSolicitud)
{
_codEstadoSolicitud = pCodEstadoSolicitud ;

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
if (  CodEstadoSolicitud.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codEstadoSolicitud) can not be null!. " ) );
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
