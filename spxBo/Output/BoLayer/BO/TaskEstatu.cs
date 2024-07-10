using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class TaskEstatu : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _codEstatus;
private System.String _nombreEstatus;
private System.String _descripcionEstatus;
private System.Boolean? _indFin;
private System.Boolean? _indIni;
private IList<Task> _tasks;

#endregion


#region --- Class Properties ---

public virtual System.String CodEstatus 
{
get
{
return _codEstatus;
}
set 
{
if ( _codEstatus != value) 
{
_codEstatus = value ;
OnPropertyChanged("CodEstatus");
}
}
}

public virtual System.String NombreEstatus 
{
get
{
return _nombreEstatus;
}
set 
{
if ( _nombreEstatus != value) 
{
_nombreEstatus = value ;
OnPropertyChanged("NombreEstatus");
}
}
}

public virtual System.String DescripcionEstatus 
{
get
{
return _descripcionEstatus;
}
set 
{
if ( _descripcionEstatus != value) 
{
_descripcionEstatus = value ;
OnPropertyChanged("DescripcionEstatus");
}
}
}

public virtual System.Boolean? IndFin 
{
get
{
return _indFin;
}
set 
{
if ( _indFin != value) 
{
_indFin = value ;
OnPropertyChanged("IndFin");
}
}
}

public virtual System.Boolean? IndIni 
{
get
{
return _indIni;
}
set 
{
if ( _indIni != value) 
{
_indIni = value ;
OnPropertyChanged("IndIni");
}
}
}

/// <summary>
/// Collection of Task.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "85f328ef-07e3-4f88-afc6-81c195aac313" , CollectionOfType = typeof(Task)) ]
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
/// Create a new TaskEstatu object. 
/// </summary>
public  TaskEstatu()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  TaskEstatu(System.String pCodEstatus)
{
_codEstatus = pCodEstatus ;

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
// Call Validator IsRequired for Column : codEstatus(Type:Required Field Validator)
_error = this.ValidatecodEstatusIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : nombreEstatus(Type:Required Field Validator)
_error = this.ValidatenombreEstatusIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(CodEstatus) ) 
{
   _errors.Add( new Error( "The PK Column (codEstatus) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codEstatus
/// </remarks>
public virtual Error ValidatecodEstatusIsRequired()
{
if ( String.IsNullOrEmpty(CodEstatus) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codEstatus is required and therefore must have a value." ;
 return _error;
}
 return null;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : nombreEstatus
/// </remarks>
public virtual Error ValidatenombreEstatusIsRequired()
{
if ( String.IsNullOrEmpty(NombreEstatus) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "nombreEstatus is required and therefore must have a value." ;
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

