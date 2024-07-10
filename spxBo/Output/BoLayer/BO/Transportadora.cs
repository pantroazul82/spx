using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class Transportadora : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codTransportadora;
private System.String _nombreTransportadora;
private System.String _telefono;
private System.String _telefono2;
private System.String _celular;
private System.String _direccion;
private System.String _observaciones;
private IList<Recoleccion> _recoleccions;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodTransportadora 
{
get
{
return _codTransportadora;
}
set 
{
if ( _codTransportadora != value) 
{
_codTransportadora = value ;
OnPropertyChanged("CodTransportadora");
}
}
}

public virtual System.String NombreTransportadora 
{
get
{
return _nombreTransportadora;
}
set 
{
if ( _nombreTransportadora != value) 
{
_nombreTransportadora = value ;
OnPropertyChanged("NombreTransportadora");
}
}
}

public virtual System.String Telefono 
{
get
{
return _telefono;
}
set 
{
if ( _telefono != value) 
{
_telefono = value ;
OnPropertyChanged("Telefono");
}
}
}

public virtual System.String Telefono2 
{
get
{
return _telefono2;
}
set 
{
if ( _telefono2 != value) 
{
_telefono2 = value ;
OnPropertyChanged("Telefono2");
}
}
}

public virtual System.String Celular 
{
get
{
return _celular;
}
set 
{
if ( _celular != value) 
{
_celular = value ;
OnPropertyChanged("Celular");
}
}
}

public virtual System.String Direccion 
{
get
{
return _direccion;
}
set 
{
if ( _direccion != value) 
{
_direccion = value ;
OnPropertyChanged("Direccion");
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
/// Collection of Recoleccion.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "d67e6b5d-0e88-48dd-91ba-14099c060ba6" , CollectionOfType = typeof(Recoleccion)) ]
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
/// Create a new Transportadora object. 
/// </summary>
public  Transportadora()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  Transportadora(System.Int32 pCodTransportadora)
{
_codTransportadora = pCodTransportadora ;

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
if (  CodTransportadora.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codTransportadora) can not be null!. " ) );
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

