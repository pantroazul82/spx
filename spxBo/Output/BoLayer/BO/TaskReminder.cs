using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class TaskReminder : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codReminder;
private System.Int32 _codTarea;
private System.DateTime? _fechaReminder;
private Task _task;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodReminder 
{
get
{
return _codReminder;
}
set 
{
if ( _codReminder != value) 
{
_codReminder = value ;
OnPropertyChanged("CodReminder");
}
}
}

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

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaReminder_Date 
{
get
{
if (  !FechaReminder.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaReminder.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaReminder.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaReminder_Time)) {

FechaReminder = null;
}
 else
{
 FechaReminder = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaReminder.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaReminder_Time)) 
{
 FechaReminder = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaReminder = Convert.ToDateTime( " " + value + " " + FechaReminder.Value.ToString("HH:mm:ss.fff") ) ;
}
}

}
}

/// <summary>
/// This property contains a calculated, bindable value of the TIME part of a DateTime property. If you want to only work with the TIME and ignore the underlying DATE component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaReminder_Time 
{
get
{
if (  !FechaReminder.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaReminder.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaReminder.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaReminder_Date)) 
{
FechaReminder = null;
}
 else
{
 FechaReminder = Convert.ToDateTime( " " + FechaReminder.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaReminder_Date)) 
{
 FechaReminder = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaReminder = Convert.ToDateTime( " " + FechaReminder_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaReminder 
{
get
{
return _fechaReminder;
}
set 
{
if ( _fechaReminder != value) 
{
_fechaReminder = value ;
OnPropertyChanged("FechaReminder");
}
}
}

/// <summary>
/// Generated from Relation FK_TaskReminder_task
/// </summary>
[GenWiseAttribute(RelationID = "b8d6832a-e081-462d-a646-d1af7ea72d15") ]
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

_retValue += CodReminder.ToString();

_retValue += "^";
_retValue += CodTarea.ToString();

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
/// Create a new TaskReminder object. 
/// </summary>
public  TaskReminder()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  TaskReminder(System.Int32 pCodReminder , System.Int32 pCodTarea)
{
_codReminder = pCodReminder ;
_codTarea = pCodTarea ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
_hash += CodReminder.ToString();
_hash += CodTarea.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
TaskReminder _newTaskReminder = (pObject as TaskReminder); 
if (_newTaskReminder == null ) return false; 
if (_newTaskReminder.GetHashCode() == this.GetHashCode() ) return true; 
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
if (  CodReminder.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codReminder) can not be null!. " ) );
}
if (  CodTarea.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codTarea) can not be null!. " ) );
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

