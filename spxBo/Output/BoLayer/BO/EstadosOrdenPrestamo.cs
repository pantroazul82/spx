using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class EstadosOrdenPrestamo : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codEstadoOrdenPrestamo;
private System.String _nombreEstadoOP;
private System.String _descripcionEstadoOP;
private IList<OrdenPrestamo> _ordenPrestamos;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodEstadoOrdenPrestamo 
{
get
{
return _codEstadoOrdenPrestamo;
}
set 
{
if ( _codEstadoOrdenPrestamo != value) 
{
_codEstadoOrdenPrestamo = value ;
OnPropertyChanged("CodEstadoOrdenPrestamo");
}
}
}

public virtual System.String NombreEstadoOP 
{
get
{
return _nombreEstadoOP;
}
set 
{
if ( _nombreEstadoOP != value) 
{
_nombreEstadoOP = value ;
OnPropertyChanged("NombreEstadoOP");
}
}
}

public virtual System.String DescripcionEstadoOP 
{
get
{
return _descripcionEstadoOP;
}
set 
{
if ( _descripcionEstadoOP != value) 
{
_descripcionEstadoOP = value ;
OnPropertyChanged("DescripcionEstadoOP");
}
}
}

/// <summary>
/// Collection of OrdenPrestamo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "5c805545-3a8f-4232-98f4-8b9ae11e2648" , CollectionOfType = typeof(OrdenPrestamo)) ]
public virtual IList<OrdenPrestamo> OrdenPrestamos 
{
get
{
 if (_ordenPrestamos == null) _ordenPrestamos = new List<OrdenPrestamo>();

return _ordenPrestamos;
}
set 
{
if ( _ordenPrestamos != value) 
{
_ordenPrestamos = value ;
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
/// Create a new EstadosOrdenPrestamo object. 
/// </summary>
public  EstadosOrdenPrestamo()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  EstadosOrdenPrestamo(System.Int32 pCodEstadoOrdenPrestamo)
{
_codEstadoOrdenPrestamo = pCodEstadoOrdenPrestamo ;

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
if (  CodEstadoOrdenPrestamo.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codEstadoOrdenPrestamo) can not be null!. " ) );
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

