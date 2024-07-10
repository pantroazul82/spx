using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class Fotografium : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codFotografia;
private System.String _nombreArchivo;
private IList<AccesoriosEquipo> _accesoriosEquipos;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodFotografia 
{
get
{
return _codFotografia;
}
set 
{
if ( _codFotografia != value) 
{
_codFotografia = value ;
OnPropertyChanged("CodFotografia");
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

/// <summary>
/// Collection of AccesoriosEquipo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "c82e9ddf-107b-48a4-bf33-d6c2b41cf511" , CollectionOfType = typeof(AccesoriosEquipo)) ]
public virtual IList<AccesoriosEquipo> AccesoriosEquipos 
{
get
{
 if (_accesoriosEquipos == null) _accesoriosEquipos = new List<AccesoriosEquipo>();

return _accesoriosEquipos;
}
set 
{
if ( _accesoriosEquipos != value) 
{
_accesoriosEquipos = value ;
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
/// Create a new Fotografium object. 
/// </summary>
public  Fotografium()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  Fotografium(System.Int32 pCodFotografia)
{
_codFotografia = pCodFotografia ;

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
// Call Validator IsRequired for Column : nombreArchivo(Type:Required Field Validator)
_error = this.ValidatenombreArchivoIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if (  CodFotografia.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codFotografia) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : nombreArchivo
/// </remarks>
public virtual Error ValidatenombreArchivoIsRequired()
{
if ( String.IsNullOrEmpty(NombreArchivo) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "nombreArchivo is required and therefore must have a value." ;
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

