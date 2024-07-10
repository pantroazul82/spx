using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class ArchivosxRecoleccion : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codArhivoxRecolecion;
private System.Int32? _codRecoleccion;
private System.String _nombreArchivo;
private System.String _descripcion;
private Recoleccion _recoleccion;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodArhivoxRecolecion 
{
get
{
return _codArhivoxRecolecion;
}
set 
{
if ( _codArhivoxRecolecion != value) 
{
_codArhivoxRecolecion = value ;
OnPropertyChanged("CodArhivoxRecolecion");
}
}
}

public virtual System.Int32? CodRecoleccion 
{
get
{
if ( Recoleccion != null ) 
{
_codRecoleccion = (System.Int32)Recoleccion.CodRecoleccion;
}

return _codRecoleccion;
}
set 
{
if ( _codRecoleccion != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_recoleccion = null;

_codRecoleccion = value ;
OnPropertyChanged("CodRecoleccion");
}
}
}

public virtual System.String NombreArchivo 
{
get
{
return _nombreArchivo;
}
set 
{
if ( _nombreArchivo != value) 
{
_nombreArchivo = value ;
OnPropertyChanged("NombreArchivo");
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
/// Generated from Relation FK_archivosxRecoleccion_recoleccion
/// </summary>
[GenWiseAttribute(RelationID = "7b8d7e5b-15cf-4d56-893b-c6f79d475348") ]
public virtual Recoleccion Recoleccion 
{
get
{
if ( _recoleccion == null ) 
{
if ( !_codRecoleccion.HasValue || _codRecoleccion.Value.Equals(System.Int32.MinValue) ) 
{
if ( _recoleccion != null && ( _recoleccion.CodRecoleccion.Equals(null) ) )
{
  _recoleccion = null;
}
}
else
{
_recoleccion = (new RecoleccionFactory()).Get(_codRecoleccion.Value);
}
}

return _recoleccion;
}
set 
{
if ( _recoleccion != value) 
{
if ( value==null ) _codRecoleccion = null; else _codRecoleccion = (System.Int32)value.CodRecoleccion; 
_recoleccion = value ;
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
/// Create a new ArchivosxRecoleccion object. 
/// </summary>
public  ArchivosxRecoleccion()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  ArchivosxRecoleccion(System.Int32 pCodArhivoxRecolecion)
{
_codArhivoxRecolecion = pCodArhivoxRecolecion ;

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
if (  CodArhivoxRecolecion.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codArhivoxRecolecion) can not be null!. " ) );
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

