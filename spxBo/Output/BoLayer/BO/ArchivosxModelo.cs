using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class ArchivosxModelo : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _codFabricante;
private System.String _codModelo;
private System.Int32 _codArchivo;
private System.String _nombreArchivo;
private System.String _descripcion;
private Modelo _modelo;

#endregion


#region --- Class Properties ---

public virtual System.String CodFabricante 
{
get
{
return _codFabricante;
}
set 
{
if ( _codFabricante != value) 
{
_codFabricante = value ;
OnPropertyChanged("CodFabricante");
}
}
}

public virtual System.String CodModelo 
{
get
{
return _codModelo;
}
set 
{
if ( _codModelo != value) 
{
_codModelo = value ;
OnPropertyChanged("CodModelo");
}
}
}

public virtual System.Int32 CodArchivo 
{
get
{
return _codArchivo;
}
set 
{
if ( _codArchivo != value) 
{
_codArchivo = value ;
OnPropertyChanged("CodArchivo");
}
}
}

public virtual System.String NombreArchivo 
{
get
{
return _nombreArchivo;
}
set 
{
if ( _nombreArchivo != value) 
{
_nombreArchivo = value ;
OnPropertyChanged("NombreArchivo");
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
/// Generated from Relation FK_archivosxModelo_Modelos
/// </summary>
[GenWiseAttribute(RelationID = "92bfdc30-221d-473b-9f8a-b344293842cb") ]
public virtual Modelo Modelo 
{
get
{
if ( _modelo == null || _modelo == null ) 
{
if ( String.IsNullOrEmpty(_codFabricante) || _codFabricante.Equals(string.Empty) || String.IsNullOrEmpty(_codModelo) || _codModelo.Equals(string.Empty) ) 
{
if ( _modelo != null && ( _modelo.CodFabricante.Equals(string.Empty) || _modelo.CodModelo.Equals(string.Empty) ) )
{
  _modelo = null;
}
}
else
{
  _modelo = (new ModeloFactory()).Fetch(_codFabricante,_codModelo);
}
}

return _modelo;
}
set 
{
if ( _modelo != value) 
{
if ( value==null ) _codFabricante = string.Empty; else _codFabricante = (System.String)value.CodFabricante; 
if ( value==null ) _codModelo = string.Empty; else _codModelo = (System.String)value.CodModelo; 
_modelo = value ;
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

if ( CodFabricante != null ) _retValue += CodFabricante.ToString();

_retValue += "^";
if ( CodModelo != null ) _retValue += CodModelo.ToString();

_retValue += "^";
_retValue += CodArchivo.ToString();

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
/// Create a new ArchivosxModelo object. 
/// </summary>
public  ArchivosxModelo()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  ArchivosxModelo(System.String pCodFabricante , System.String pCodModelo , System.Int32 pCodArchivo)
{
_codFabricante = pCodFabricante ;
_codModelo = pCodModelo ;
_codArchivo = pCodArchivo ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
if ( CodFabricante != null ) _hash += CodFabricante.ToString();
if ( CodModelo != null ) _hash += CodModelo.ToString();
_hash += CodArchivo.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
ArchivosxModelo _newArchivosxModelo = (pObject as ArchivosxModelo); 
if (_newArchivosxModelo == null ) return false; 
if (_newArchivosxModelo.GetHashCode() == this.GetHashCode() ) return true; 
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
// Call Validator IsRequired for Column : codFabricante(Type:Required Field Validator)
_error = this.ValidatecodFabricanteIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : codModelo(Type:Required Field Validator)
_error = this.ValidatecodModeloIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(CodFabricante) ) 
{
   _errors.Add( new Error( "The PK Column (codFabricante) can not be null!. " ) );
}
if ( String.IsNullOrEmpty(CodModelo) ) 
{
   _errors.Add( new Error( "The PK Column (codModelo) can not be null!. " ) );
}
if (  CodArchivo.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codArchivo) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codFabricante
/// </remarks>
public virtual Error ValidatecodFabricanteIsRequired()
{
if ( String.IsNullOrEmpty(CodFabricante) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codFabricante is required and therefore must have a value." ;
 return _error;
}
 return null;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codModelo
/// </remarks>
public virtual Error ValidatecodModeloIsRequired()
{
if ( String.IsNullOrEmpty(CodModelo) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codModelo is required and therefore must have a value." ;
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

