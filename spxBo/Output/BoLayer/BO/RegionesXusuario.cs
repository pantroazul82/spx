using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class RegionesXusuario : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _login;
private System.String _codPais;
private System.String _codDepartamento;
private System.String _codCiudad;
private Ciudade _ciudade;
private Usuario0 _usuario0;

#endregion


#region --- Class Properties ---

public virtual System.String Login 
{
get
{
return _login;
}
set 
{
if ( _login != value) 
{
_login = value ;
OnPropertyChanged("Login");
}
}
}

public virtual System.String CodPais 
{
get
{
return _codPais;
}
set 
{
if ( _codPais != value) 
{
_codPais = value ;
OnPropertyChanged("CodPais");
}
}
}

public virtual System.String CodDepartamento 
{
get
{
return _codDepartamento;
}
set 
{
if ( _codDepartamento != value) 
{
_codDepartamento = value ;
OnPropertyChanged("CodDepartamento");
}
}
}

public virtual System.String CodCiudad 
{
get
{
return _codCiudad;
}
set 
{
if ( _codCiudad != value) 
{
_codCiudad = value ;
OnPropertyChanged("CodCiudad");
}
}
}

/// <summary>
/// Generated from Relation FK_regionesXusuarios_ciudades
/// </summary>
[GenWiseAttribute(RelationID = "f63b23aa-3f06-43db-9e07-70465a8be905") ]
public virtual Ciudade Ciudade 
{
get
{
if ( _ciudade == null || _ciudade == null || _ciudade == null ) 
{
if ( String.IsNullOrEmpty(_codPais) || _codPais.Equals(string.Empty) || String.IsNullOrEmpty(_codDepartamento) || _codDepartamento.Equals(string.Empty) || String.IsNullOrEmpty(_codCiudad) || _codCiudad.Equals(string.Empty) ) 
{
if ( _ciudade != null && ( _ciudade.CodPais.Equals(string.Empty) || _ciudade.CodDepartamento.Equals(string.Empty) || _ciudade.CodCiudad.Equals(string.Empty) ) )
{
  _ciudade = null;
}
}
else
{
  _ciudade = (new CiudadeFactory()).Fetch(_codPais,_codDepartamento,_codCiudad);
}
}

return _ciudade;
}
set 
{
if ( _ciudade != value) 
{
if ( value==null ) _codPais = string.Empty; else _codPais = (System.String)value.CodPais; 
if ( value==null ) _codDepartamento = string.Empty; else _codDepartamento = (System.String)value.CodDepartamento; 
if ( value==null ) _codCiudad = string.Empty; else _codCiudad = (System.String)value.CodCiudad; 
_ciudade = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_regionesXusuarios_usuarios
/// </summary>
[GenWiseAttribute(RelationID = "6475efd3-d793-4d68-872d-c74ab8d8d179") ]
public virtual Usuario0 Usuario0 
{
get
{
if ( _usuario0 == null ) 
{
if ( String.IsNullOrEmpty(_login) || _login.Equals(string.Empty) ) 
{
if ( _usuario0 != null && ( _usuario0.Login.Equals(string.Empty) ) )
{
  _usuario0 = null;
}
}
else
{
_usuario0 = (new Usuario0Factory()).Get(_login);
}
}

return _usuario0;
}
set 
{
if ( _usuario0 != value) 
{
if ( value==null ) _login = string.Empty; else _login = (System.String)value.Login; 
_usuario0 = value ;
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

if ( Login != null ) _retValue += Login.ToString();

_retValue += "^";
if ( CodPais != null ) _retValue += CodPais.ToString();

_retValue += "^";
if ( CodDepartamento != null ) _retValue += CodDepartamento.ToString();

_retValue += "^";
if ( CodCiudad != null ) _retValue += CodCiudad.ToString();

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
/// Create a new RegionesXusuario object. 
/// </summary>
public  RegionesXusuario()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  RegionesXusuario(System.String pLogin , System.String pCodPais , System.String pCodDepartamento , System.String pCodCiudad)
{
_login = pLogin ;
_codPais = pCodPais ;
_codDepartamento = pCodDepartamento ;
_codCiudad = pCodCiudad ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
if ( Login != null ) _hash += Login.ToString();
if ( CodPais != null ) _hash += CodPais.ToString();
if ( CodDepartamento != null ) _hash += CodDepartamento.ToString();
if ( CodCiudad != null ) _hash += CodCiudad.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
RegionesXusuario _newRegionesXusuario = (pObject as RegionesXusuario); 
if (_newRegionesXusuario == null ) return false; 
if (_newRegionesXusuario.GetHashCode() == this.GetHashCode() ) return true; 
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
// Call Validator IsRequired for Column : login(Type:Required Field Validator)
_error = this.ValidateloginIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : codPais(Type:Required Field Validator)
_error = this.ValidatecodPaisIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : codDepartamento(Type:Required Field Validator)
_error = this.ValidatecodDepartamentoIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : codCiudad(Type:Required Field Validator)
_error = this.ValidatecodCiudadIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(Login) ) 
{
   _errors.Add( new Error( "The PK Column (login) can not be null!. " ) );
}
if ( String.IsNullOrEmpty(CodPais) ) 
{
   _errors.Add( new Error( "The PK Column (codPais) can not be null!. " ) );
}
if ( String.IsNullOrEmpty(CodDepartamento) ) 
{
   _errors.Add( new Error( "The PK Column (codDepartamento) can not be null!. " ) );
}
if ( String.IsNullOrEmpty(CodCiudad) ) 
{
   _errors.Add( new Error( "The PK Column (codCiudad) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : login
/// </remarks>
public virtual Error ValidateloginIsRequired()
{
if ( String.IsNullOrEmpty(Login) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "login is required and therefore must have a value." ;
 return _error;
}
 return null;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codPais
/// </remarks>
public virtual Error ValidatecodPaisIsRequired()
{
if ( String.IsNullOrEmpty(CodPais) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codPais is required and therefore must have a value." ;
 return _error;
}
 return null;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codDepartamento
/// </remarks>
public virtual Error ValidatecodDepartamentoIsRequired()
{
if ( String.IsNullOrEmpty(CodDepartamento) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codDepartamento is required and therefore must have a value." ;
 return _error;
}
 return null;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codCiudad
/// </remarks>
public virtual Error ValidatecodCiudadIsRequired()
{
if ( String.IsNullOrEmpty(CodCiudad) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codCiudad is required and therefore must have a value." ;
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

