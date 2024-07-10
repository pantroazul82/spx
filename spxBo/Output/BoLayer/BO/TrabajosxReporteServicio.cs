using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class TrabajosxReporteServicio : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _idReporteServicio;
private System.Int32 _idTrabajo;
private System.String _loginAutor;
private System.String _descripcion;

#endregion


#region --- Class Properties ---

public virtual System.Int32 IdReporteServicio 
{
get
{
return _idReporteServicio;
}
set 
{
if ( _idReporteServicio != value) 
{
_idReporteServicio = value ;
OnPropertyChanged("IdReporteServicio");
}
}
}

public virtual System.Int32 IdTrabajo 
{
get
{
return _idTrabajo;
}
set 
{
if ( _idTrabajo != value) 
{
_idTrabajo = value ;
OnPropertyChanged("IdTrabajo");
}
}
}

public virtual System.String LoginAutor 
{
get
{
return _loginAutor;
}
set 
{
if ( _loginAutor != value) 
{
_loginAutor = value ;
OnPropertyChanged("LoginAutor");
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
/// Property that simulates a unique PK by concatenating all the Pk properties
/// </summary>
public virtual System.String VirtualPk 
{
get
{
string _retValue = string.Empty;

_retValue += IdReporteServicio.ToString();

_retValue += "^";
_retValue += IdTrabajo.ToString();

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
/// Create a new TrabajosxReporteServicio object. 
/// </summary>
public  TrabajosxReporteServicio()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  TrabajosxReporteServicio(System.Int32 pIdReporteServicio , System.Int32 pIdTrabajo)
{
_idReporteServicio = pIdReporteServicio ;
_idTrabajo = pIdTrabajo ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
_hash += IdReporteServicio.ToString();
_hash += IdTrabajo.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
TrabajosxReporteServicio _newTrabajosxReporteServicio = (pObject as TrabajosxReporteServicio); 
if (_newTrabajosxReporteServicio == null ) return false; 
if (_newTrabajosxReporteServicio.GetHashCode() == this.GetHashCode() ) return true; 
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
if (  IdReporteServicio.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (idReporteServicio) can not be null!. " ) );
}
if (  IdTrabajo.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (idTrabajo) can not be null!. " ) );
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

