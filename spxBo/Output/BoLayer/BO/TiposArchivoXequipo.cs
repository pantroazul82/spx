using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class TiposArchivoXequipo : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _codTipoArchivoxEquipo;
private System.String _nombre;
private System.String _descripcion;
private System.Boolean? _esObligatorio;
private IList<ArchivosXequipo> _archivosXequipos;

#endregion


#region --- Class Properties ---

public virtual System.String CodTipoArchivoxEquipo 
{
get
{
return _codTipoArchivoxEquipo;
}
set 
{
if ( _codTipoArchivoxEquipo != value) 
{
_codTipoArchivoxEquipo = value ;
OnPropertyChanged("CodTipoArchivoxEquipo");
}
}
}

public virtual System.String Nombre 
{
get
{
return _nombre;
}
set 
{
if ( _nombre != value) 
{
_nombre = value ;
OnPropertyChanged("Nombre");
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

public virtual System.Boolean? EsObligatorio 
{
get
{
return _esObligatorio;
}
set 
{
if ( _esObligatorio != value) 
{
_esObligatorio = value ;
OnPropertyChanged("EsObligatorio");
}
}
}

/// <summary>
/// Collection of ArchivosXequipo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "1c57e0fc-c85f-462c-ab57-60fb6007017c" , CollectionOfType = typeof(ArchivosXequipo)) ]
public virtual IList<ArchivosXequipo> ArchivosXequipos 
{
get
{
 if (_archivosXequipos == null) _archivosXequipos = new List<ArchivosXequipo>();

return _archivosXequipos;
}
set 
{
if ( _archivosXequipos != value) 
{
_archivosXequipos = value ;
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
/// Create a new TiposArchivoXequipo object. 
/// </summary>
public  TiposArchivoXequipo()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  TiposArchivoXequipo(System.String pCodTipoArchivoxEquipo)
{
_codTipoArchivoxEquipo = pCodTipoArchivoxEquipo ;

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
// Call Validator IsRequired for Column : codTipoArchivoxEquipo(Type:Required Field Validator)
_error = this.ValidatecodTipoArchivoxEquipoIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(CodTipoArchivoxEquipo) ) 
{
   _errors.Add( new Error( "The PK Column (codTipoArchivoxEquipo) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codTipoArchivoxEquipo
/// </remarks>
public virtual Error ValidatecodTipoArchivoxEquipoIsRequired()
{
if ( String.IsNullOrEmpty(CodTipoArchivoxEquipo) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codTipoArchivoxEquipo is required and therefore must have a value." ;
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

