using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class TaskAdjunto : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codTarea;
private System.Int32 _codAdjunto;
private System.String _nombre;
private Task _task;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodTarea 
{
get
{
return _codTarea;
}
set 
{
if ( _codTarea != value) 
{
_codTarea = value ;
OnPropertyChanged("CodTarea");
}
}
}

public virtual System.Int32 CodAdjunto 
{
get
{
return _codAdjunto;
}
set 
{
if ( _codAdjunto != value) 
{
_codAdjunto = value ;
OnPropertyChanged("CodAdjunto");
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

/// <summary>
/// Generated from Relation FK_taskAdjuntos_task
/// </summary>
[GenWiseAttribute(RelationID = "37dfa7a2-433b-4a49-bd9a-da2cc1f98828") ]
public virtual Task Task 
{
get
{
if ( _task == null ) 
{
if (  _codTarea.Equals(0)  || _codTarea.Equals(System.Int32.MinValue) ) 
{
if ( _task != null && ( _task.CodTarea.Equals(System.Int32.MinValue) ) )
{
  _task = null;
}
}
else
{
_task = (new TaskFactory()).Get(_codTarea);
}
}

return _task;
}
set 
{
if ( _task != value) 
{
if ( value==null ) _codTarea = System.Int32.MinValue; else _codTarea = (System.Int32)value.CodTarea; 
_task = value ;
}
}
}

/// <summary>
/// Property that simulates a unique PK by concatenating all the Pk properties
/// </summary>
public virtual System.String VirtualPk 
{
get
{
string _retValue = string.Empty;

_retValue += CodTarea.ToString();

_retValue += "^";
_retValue += CodAdjunto.ToString();

return _retValue;

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
/// Create a new TaskAdjunto object. 
/// </summary>
public  TaskAdjunto()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  TaskAdjunto(System.Int32 pCodTarea , System.Int32 pCodAdjunto)
{
_codTarea = pCodTarea ;
_codAdjunto = pCodAdjunto ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
_hash += CodTarea.ToString();
_hash += CodAdjunto.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
TaskAdjunto _newTaskAdjunto = (pObject as TaskAdjunto); 
if (_newTaskAdjunto == null ) return false; 
if (_newTaskAdjunto.GetHashCode() == this.GetHashCode() ) return true; 
return false; 

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
if (  CodTarea.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codTarea) can not be null!. " ) );
}
if (  CodAdjunto.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codAdjunto) can not be null!. " ) );
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

