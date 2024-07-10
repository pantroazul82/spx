using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class GruposXgrupo : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _codGruposUsu;
private System.String _subordinadoDe;
private GruposUsuario _gruposUsuario;
private GruposUsuario _gruposUsuario1;

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

public virtual System.String SubordinadoDe 
{
get
{
return _subordinadoDe;
}
set 
{
if ( _subordinadoDe != value) 
{
_subordinadoDe = value ;
OnPropertyChanged("SubordinadoDe");
}
}
}

/// <summary>
/// Generated from Relation FK_gruposXgrupos_gruposUsuarios
/// </summary>
[GenWiseAttribute(RelationID = "3c8236ef-5f88-4021-bac7-778bc7745202") ]
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
/// Generated from Relation FK_gruposXgrupos_gruposUsuarios1
/// </summary>
[GenWiseAttribute(RelationID = "69394da2-4b02-47f9-965c-6997548006f5") ]
public virtual GruposUsuario GruposUsuario1 
{
get
{
if ( _gruposUsuario1 == null ) 
{
if ( String.IsNullOrEmpty(_subordinadoDe) || _subordinadoDe.Equals(string.Empty) ) 
{
if ( _gruposUsuario1 != null && ( _gruposUsuario1.CodGruposUsu.Equals(string.Empty) ) )
{
  _gruposUsuario1 = null;
}
}
else
{
_gruposUsuario1 = (new GruposUsuarioFactory()).Get(_subordinadoDe);
}
}

return _gruposUsuario1;
}
set 
{
if ( _gruposUsuario1 != value) 
{
if ( value==null ) _subordinadoDe = string.Empty; else _subordinadoDe = (System.String)value.CodGruposUsu; 
_gruposUsuario1 = value ;
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
if ( SubordinadoDe != null ) _retValue += SubordinadoDe.ToString();

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
/// Create a new GruposXgrupo object. 
/// </summary>
public  GruposXgrupo()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  GruposXgrupo(System.String pCodGruposUsu , System.String pSubordinadoDe)
{
_codGruposUsu = pCodGruposUsu ;
_subordinadoDe = pSubordinadoDe ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
if ( CodGruposUsu != null ) _hash += CodGruposUsu.ToString();
if ( SubordinadoDe != null ) _hash += SubordinadoDe.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
GruposXgrupo _newGruposXgrupo = (pObject as GruposXgrupo); 
if (_newGruposXgrupo == null ) return false; 
if (_newGruposXgrupo.GetHashCode() == this.GetHashCode() ) return true; 
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
// Call Validator IsRequired for Column : subordinadoDe(Type:Required Field Validator)
_error = this.ValidatesubordinadoDeIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(CodGruposUsu) ) 
{
   _errors.Add( new Error( "The PK Column (codGruposUsu) can not be null!. " ) );
}
if ( String.IsNullOrEmpty(SubordinadoDe) ) 
{
   _errors.Add( new Error( "The PK Column (subordinadoDe) can not be null!. " ) );
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

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : subordinadoDe
/// </remarks>
public virtual Error ValidatesubordinadoDeIsRequired()
{
if ( String.IsNullOrEmpty(SubordinadoDe) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "subordinadoDe is required and therefore must have a value." ;
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

