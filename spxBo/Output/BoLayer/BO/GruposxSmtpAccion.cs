using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class GruposxSmtpAccion : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _codGruposUsu;
private System.Int32 _idCgSmtpAccion;
private System.Boolean? _enviarSoloPropietario;
private CgSmtpAccion _cgSmtpAccion;
private GruposUsuario _gruposUsuario;

#endregion


#region --- Class Properties ---

public virtual System.String CodGruposUsu 
{
get
{
return _codGruposUsu;
}
set 
{
if ( _codGruposUsu != value) 
{
_codGruposUsu = value ;
OnPropertyChanged("CodGruposUsu");
}
}
}

public virtual System.Int32 IdCgSmtpAccion 
{
get
{
return _idCgSmtpAccion;
}
set 
{
if ( _idCgSmtpAccion != value) 
{
_idCgSmtpAccion = value ;
OnPropertyChanged("IdCgSmtpAccion");
}
}
}

public virtual System.Boolean? EnviarSoloPropietario 
{
get
{
return _enviarSoloPropietario;
}
set 
{
if ( _enviarSoloPropietario != value) 
{
_enviarSoloPropietario = value ;
OnPropertyChanged("EnviarSoloPropietario");
}
}
}

/// <summary>
/// Generated from Relation FK_gruposxSmtpAccion_cgSmtpAccion
/// </summary>
[GenWiseAttribute(RelationID = "432d2786-8777-4d58-8848-19c6be61df63") ]
public virtual CgSmtpAccion CgSmtpAccion 
{
get
{
if ( _cgSmtpAccion == null ) 
{
if (  _idCgSmtpAccion.Equals(0)  || _idCgSmtpAccion.Equals(System.Int32.MinValue) ) 
{
if ( _cgSmtpAccion != null && ( _cgSmtpAccion.IdCgSmtpAccion.Equals(System.Int32.MinValue) ) )
{
  _cgSmtpAccion = null;
}
}
else
{
_cgSmtpAccion = (new CgSmtpAccionFactory()).Get(_idCgSmtpAccion);
}
}

return _cgSmtpAccion;
}
set 
{
if ( _cgSmtpAccion != value) 
{
if ( value==null ) _idCgSmtpAccion = System.Int32.MinValue; else _idCgSmtpAccion = (System.Int32)value.IdCgSmtpAccion; 
_cgSmtpAccion = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_gruposxSmtpAccion_gruposUsuarios
/// </summary>
[GenWiseAttribute(RelationID = "6c9374b2-4c59-48d4-8437-3be77f49eb2f") ]
public virtual GruposUsuario GruposUsuario 
{
get
{
if ( _gruposUsuario == null ) 
{
if ( String.IsNullOrEmpty(_codGruposUsu) || _codGruposUsu.Equals(string.Empty) ) 
{
if ( _gruposUsuario != null && ( _gruposUsuario.CodGruposUsu.Equals(string.Empty) ) )
{
  _gruposUsuario = null;
}
}
else
{
_gruposUsuario = (new GruposUsuarioFactory()).Get(_codGruposUsu);
}
}

return _gruposUsuario;
}
set 
{
if ( _gruposUsuario != value) 
{
if ( value==null ) _codGruposUsu = string.Empty; else _codGruposUsu = (System.String)value.CodGruposUsu; 
_gruposUsuario = value ;
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

if ( CodGruposUsu != null ) _retValue += CodGruposUsu.ToString();

_retValue += "^";
_retValue += IdCgSmtpAccion.ToString();

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
/// Create a new GruposxSmtpAccion object. 
/// </summary>
public  GruposxSmtpAccion()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  GruposxSmtpAccion(System.String pCodGruposUsu , System.Int32 pIdCgSmtpAccion)
{
_codGruposUsu = pCodGruposUsu ;
_idCgSmtpAccion = pIdCgSmtpAccion ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
if ( CodGruposUsu != null ) _hash += CodGruposUsu.ToString();
_hash += IdCgSmtpAccion.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
GruposxSmtpAccion _newGruposxSmtpAccion = (pObject as GruposxSmtpAccion); 
if (_newGruposxSmtpAccion == null ) return false; 
if (_newGruposxSmtpAccion.GetHashCode() == this.GetHashCode() ) return true; 
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
Error _error;
// Call Validator IsRequired for Column : codGruposUsu(Type:Required Field Validator)
_error = this.ValidatecodGruposUsuIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(CodGruposUsu) ) 
{
   _errors.Add( new Error( "The PK Column (codGruposUsu) can not be null!. " ) );
}
if (  IdCgSmtpAccion.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (idCgSmtpAccion) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codGruposUsu
/// </remarks>
public virtual Error ValidatecodGruposUsuIsRequired()
{
if ( String.IsNullOrEmpty(CodGruposUsu) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codGruposUsu is required and therefore must have a value." ;
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

