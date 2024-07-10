using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class EstadoRecoleccion : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codEstadoRecoleccion;
private System.Int32? _jerarquiaEstadoRecoleccion;
private System.String _nombreEstadoRecoleccion;
private IList<Recoleccion> _recoleccions;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodEstadoRecoleccion 
{
get
{
return _codEstadoRecoleccion;
}
set 
{
if ( _codEstadoRecoleccion != value) 
{
_codEstadoRecoleccion = value ;
OnPropertyChanged("CodEstadoRecoleccion");
}
}
}

public virtual System.Int32? JerarquiaEstadoRecoleccion 
{
get
{
return _jerarquiaEstadoRecoleccion;
}
set 
{
if ( _jerarquiaEstadoRecoleccion != value) 
{
_jerarquiaEstadoRecoleccion = value ;
OnPropertyChanged("JerarquiaEstadoRecoleccion");
}
}
}

public virtual System.String NombreEstadoRecoleccion 
{
get
{
return _nombreEstadoRecoleccion;
}
set 
{
if ( _nombreEstadoRecoleccion != value) 
{
_nombreEstadoRecoleccion = value ;
OnPropertyChanged("NombreEstadoRecoleccion");
}
}
}

/// <summary>
/// Collection of Recoleccion.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "4a7d1d7f-c144-4061-9be2-07035f5f82a9" , CollectionOfType = typeof(Recoleccion)) ]
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
/// Create a new EstadoRecoleccion object. 
/// </summary>
public  EstadoRecoleccion()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  EstadoRecoleccion(System.Int32 pCodEstadoRecoleccion)
{
_codEstadoRecoleccion = pCodEstadoRecoleccion ;

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
if (  CodEstadoRecoleccion.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codEstadoRecoleccion) can not be null!. " ) );
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

