﻿using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class TipoPropiedad : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codTipoPropiedad;
private System.String _nombreTipoPropiedad;
private System.String _descripcion;
private IList<Equipo> _equipos;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodTipoPropiedad 
{
get
{
return _codTipoPropiedad;
}
set 
{
if ( _codTipoPropiedad != value) 
{
_codTipoPropiedad = value ;
OnPropertyChanged("CodTipoPropiedad");
}
}
}

public virtual System.String NombreTipoPropiedad 
{
get
{
return _nombreTipoPropiedad;
}
set 
{
if ( _nombreTipoPropiedad != value) 
{
_nombreTipoPropiedad = value ;
OnPropertyChanged("NombreTipoPropiedad");
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
/// Collection of Equipo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "00534c94-97ac-4618-bc6d-25c616dddd42" , CollectionOfType = typeof(Equipo)) ]
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
/// Create a new TipoPropiedad object. 
/// </summary>
public  TipoPropiedad()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  TipoPropiedad(System.Int32 pCodTipoPropiedad)
{
_codTipoPropiedad = pCodTipoPropiedad ;

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
if (  CodTipoPropiedad.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codTipoPropiedad) can not be null!. " ) );
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

