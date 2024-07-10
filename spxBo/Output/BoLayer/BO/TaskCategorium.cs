using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class TaskCategorium : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _codCategoria;
private System.String _nombreCategoria;
private System.String _color;
private System.Boolean? _procesoInterno;
private System.String _nameSpace;
private System.String _parametros;
private IList<Task> _tasks;

#endregion


#region --- Class Properties ---

public virtual System.String CodCategoria 
{
get
{
return _codCategoria;
}
set 
{
if ( _codCategoria != value) 
{
_codCategoria = value ;
OnPropertyChanged("CodCategoria");
}
}
}

public virtual System.String NombreCategoria 
{
get
{
return _nombreCategoria;
}
set 
{
if ( _nombreCategoria != value) 
{
_nombreCategoria = value ;
OnPropertyChanged("NombreCategoria");
}
}
}

public virtual System.String Color 
{
get
{
return _color;
}
set 
{
if ( _color != value) 
{
_color = value ;
OnPropertyChanged("Color");
}
}
}

public virtual System.Boolean? ProcesoInterno 
{
get
{
return _procesoInterno;
}
set 
{
if ( _procesoInterno != value) 
{
_procesoInterno = value ;
OnPropertyChanged("ProcesoInterno");
}
}
}

public virtual System.String NameSpace 
{
get
{
return _nameSpace;
}
set 
{
if ( _nameSpace != value) 
{
_nameSpace = value ;
OnPropertyChanged("NameSpace");
}
}
}

public virtual System.String Parametros 
{
get
{
return _parametros;
}
set 
{
if ( _parametros != value) 
{
_parametros = value ;
OnPropertyChanged("Parametros");
}
}
}

/// <summary>
/// Collection of Task.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "7d40250e-b764-4da5-9d51-8b21102674fa" , CollectionOfType = typeof(Task)) ]
public virtual IList<Task> Tasks 
{
get
{
 if (_tasks == null) _tasks = new List<Task>();

return _tasks;
}
set 
{
if ( _tasks != value) 
{
_tasks = value ;
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
/// Create a new TaskCategorium object. 
/// </summary>
public  TaskCategorium()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  TaskCategorium(System.String pCodCategoria)
{
_codCategoria = pCodCategoria ;

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
// Call Validator IsRequired for Column : codCategoria(Type:Required Field Validator)
_error = this.ValidatecodCategoriaIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : nombreCategoria(Type:Required Field Validator)
_error = this.ValidatenombreCategoriaIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(CodCategoria) ) 
{
   _errors.Add( new Error( "The PK Column (codCategoria) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codCategoria
/// </remarks>
public virtual Error ValidatecodCategoriaIsRequired()
{
if ( String.IsNullOrEmpty(CodCategoria) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codCategoria is required and therefore must have a value." ;
 return _error;
}
 return null;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : nombreCategoria
/// </remarks>
public virtual Error ValidatenombreCategoriaIsRequired()
{
if ( String.IsNullOrEmpty(NombreCategoria) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "nombreCategoria is required and therefore must have a value." ;
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

