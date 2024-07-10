using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class UnidadPeso : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codUnidadPeso;
private System.String _nombreUnidadPeso;
private System.Double? _factorConversion;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodUnidadPeso 
{
get
{
return _codUnidadPeso;
}
set 
{
if ( _codUnidadPeso != value) 
{
_codUnidadPeso = value ;
OnPropertyChanged("CodUnidadPeso");
}
}
}

public virtual System.String NombreUnidadPeso 
{
get
{
return _nombreUnidadPeso;
}
set 
{
if ( _nombreUnidadPeso != value) 
{
_nombreUnidadPeso = value ;
OnPropertyChanged("NombreUnidadPeso");
}
}
}

public virtual System.Double? FactorConversion 
{
get
{
return _factorConversion;
}
set 
{
if ( _factorConversion != value) 
{
_factorConversion = value ;
OnPropertyChanged("FactorConversion");
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
/// Create a new UnidadPeso object. 
/// </summary>
public  UnidadPeso()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  UnidadPeso(System.Int32 pCodUnidadPeso)
{
_codUnidadPeso = pCodUnidadPeso ;

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
if (  CodUnidadPeso.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codUnidadPeso) can not be null!. " ) );
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

