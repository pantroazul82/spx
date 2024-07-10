using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class AccesoriosEquipo : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _codAccesoriosEquipos;
private System.String _nombreAccesorio;
private System.String _descripcion;
private System.String _codFabricante;
private System.String _codModelo;
private System.Int32? _codFoto;
private IList<AccesoriosxEntradaSalidaEquipo> _accesoriosxEntradaSalidaEquipos;
private Fotografium _fotografium;
private Modelo _modelo;

#endregion


#region --- Class Properties ---

public virtual System.String CodAccesoriosEquipos 
{
get
{
return _codAccesoriosEquipos;
}
set 
{
if ( _codAccesoriosEquipos != value) 
{
_codAccesoriosEquipos = value ;
OnPropertyChanged("CodAccesoriosEquipos");
}
}
}

public virtual System.String NombreAccesorio 
{
get
{
return _nombreAccesorio;
}
set 
{
if ( _nombreAccesorio != value) 
{
_nombreAccesorio = value ;
OnPropertyChanged("NombreAccesorio");
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

public virtual System.String CodFabricante 
{
get
{
if ( Modelo != null ) 
{
_codFabricante = (System.String)Modelo.CodFabricante;
}

return _codFabricante;
}
set 
{
if ( _codFabricante != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_modelo = null;

_codFabricante = value ;
OnPropertyChanged("CodFabricante");
}
}
}

public virtual System.String CodModelo 
{
get
{
if ( Modelo != null ) 
{
_codModelo = (System.String)Modelo.CodModelo;
}

return _codModelo;
}
set 
{
if ( _codModelo != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_modelo = null;

_codModelo = value ;
OnPropertyChanged("CodModelo");
}
}
}

public virtual System.Int32? CodFoto 
{
get
{
if ( Fotografium != null ) 
{
_codFoto = (System.Int32)Fotografium.CodFotografia;
}

return _codFoto;
}
set 
{
if ( _codFoto != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_fotografium = null;

_codFoto = value ;
OnPropertyChanged("CodFoto");
}
}
}

/// <summary>
/// Collection of AccesoriosxEntradaSalidaEquipo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "754f91d4-ed19-44b3-9eec-460377a36b0a" , CollectionOfType = typeof(AccesoriosxEntradaSalidaEquipo)) ]
public virtual IList<AccesoriosxEntradaSalidaEquipo> AccesoriosxEntradaSalidaEquipos 
{
get
{
 if (_accesoriosxEntradaSalidaEquipos == null) _accesoriosxEntradaSalidaEquipos = new List<AccesoriosxEntradaSalidaEquipo>();

return _accesoriosxEntradaSalidaEquipos;
}
set 
{
if ( _accesoriosxEntradaSalidaEquipos != value) 
{
_accesoriosxEntradaSalidaEquipos = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_accesoriosEquipo_fotografia
/// </summary>
[GenWiseAttribute(RelationID = "c82e9ddf-107b-48a4-bf33-d6c2b41cf511") ]
public virtual Fotografium Fotografium 
{
get
{
if ( _fotografium == null ) 
{
if ( !_codFoto.HasValue || _codFoto.Value.Equals(System.Int32.MinValue) ) 
{
if ( _fotografium != null && ( _fotografium.CodFotografia.Equals(null) ) )
{
  _fotografium = null;
}
}
else
{
_fotografium = (new FotografiumFactory()).Get(_codFoto.Value);
}
}

return _fotografium;
}
set 
{
if ( _fotografium != value) 
{
if ( value==null ) _codFoto = null; else _codFoto = (System.Int32)value.CodFotografia; 
_fotografium = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_accesoriosEquipo_Modelos
/// </summary>
[GenWiseAttribute(RelationID = "c0d81b65-ca76-4621-b72f-144b46db593f") ]
public virtual Modelo Modelo 
{
get
{
if ( _modelo == null || _modelo == null ) 
{
if ( String.IsNullOrEmpty(_codFabricante) || _codFabricante.Equals(string.Empty) || String.IsNullOrEmpty(_codModelo) || _codModelo.Equals(string.Empty) ) 
{
if ( _modelo != null && ( _modelo.CodFabricante.Equals(null) || _modelo.CodModelo.Equals(null) ) )
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
if ( value==null ) _codFabricante = null; else _codFabricante = (System.String)value.CodFabricante; 
if ( value==null ) _codModelo = null; else _codModelo = (System.String)value.CodModelo; 
_modelo = value ;
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
/// Create a new AccesoriosEquipo object. 
/// </summary>
public  AccesoriosEquipo()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  AccesoriosEquipo(System.String pCodAccesoriosEquipos)
{
_codAccesoriosEquipos = pCodAccesoriosEquipos ;

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
// Call Validator IsRequired for Column : codAccesoriosEquipos(Type:Required Field Validator)
_error = this.ValidatecodAccesoriosEquiposIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(CodAccesoriosEquipos) ) 
{
   _errors.Add( new Error( "The PK Column (codAccesoriosEquipos) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codAccesoriosEquipos
/// </remarks>
public virtual Error ValidatecodAccesoriosEquiposIsRequired()
{
if ( String.IsNullOrEmpty(CodAccesoriosEquipos) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codAccesoriosEquipos is required and therefore must have a value." ;
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

