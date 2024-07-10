using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class ParametrosxCgSmtpAccion : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32? _idCgSmtpAccion;
private System.Int32 _idParametroxCgSmtpAccion;
private System.String _parametro;
private CgSmtpAccion _cgSmtpAccion;

#endregion


#region --- Class Properties ---

public virtual System.Int32? IdCgSmtpAccion 
{
get
{
if ( CgSmtpAccion != null ) 
{
_idCgSmtpAccion = (System.Int32)CgSmtpAccion.IdCgSmtpAccion;
}

return _idCgSmtpAccion;
}
set 
{
if ( _idCgSmtpAccion != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_cgSmtpAccion = null;

_idCgSmtpAccion = value ;
OnPropertyChanged("IdCgSmtpAccion");
}
}
}

public virtual System.Int32 IdParametroxCgSmtpAccion 
{
get
{
return _idParametroxCgSmtpAccion;
}
set 
{
if ( _idParametroxCgSmtpAccion != value) 
{
_idParametroxCgSmtpAccion = value ;
OnPropertyChanged("IdParametroxCgSmtpAccion");
}
}
}

public virtual System.String Parametro 
{
get
{
return _parametro;
}
set 
{
if ( _parametro != value) 
{
_parametro = value ;
OnPropertyChanged("Parametro");
}
}
}

/// <summary>
/// Generated from Relation FK_parametrosxCgSmtpAccion_cgSmtpAccion
/// </summary>
[GenWiseAttribute(RelationID = "3dc00074-4e6a-40ca-a72d-5d4fb081dfdf") ]
public virtual CgSmtpAccion CgSmtpAccion 
{
get
{
if ( _cgSmtpAccion == null ) 
{
if ( !_idCgSmtpAccion.HasValue || _idCgSmtpAccion.Value.Equals(System.Int32.MinValue) ) 
{
if ( _cgSmtpAccion != null && ( _cgSmtpAccion.IdCgSmtpAccion.Equals(null) ) )
{
  _cgSmtpAccion = null;
}
}
else
{
_cgSmtpAccion = (new CgSmtpAccionFactory()).Get(_idCgSmtpAccion.Value);
}
}

return _cgSmtpAccion;
}
set 
{
if ( _cgSmtpAccion != value) 
{
if ( value==null ) _idCgSmtpAccion = null; else _idCgSmtpAccion = (System.Int32)value.IdCgSmtpAccion; 
_cgSmtpAccion = value ;
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
/// Create a new ParametrosxCgSmtpAccion object. 
/// </summary>
public  ParametrosxCgSmtpAccion()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  ParametrosxCgSmtpAccion(System.Int32 pIdParametroxCgSmtpAccion)
{
_idParametroxCgSmtpAccion = pIdParametroxCgSmtpAccion ;

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
if (  IdParametroxCgSmtpAccion.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (idParametroxCgSmtpAccion) can not be null!. " ) );
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

