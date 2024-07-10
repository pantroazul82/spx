using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class AccesoriosxEntradaSalidaEquipo : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codEntradaSalidaEquipos;
private System.Int32 _codigo;
private System.Boolean _sonDeEntrada;
private System.String _codAccesoriosEquipos;
private System.Boolean? _esOtro;
private System.String _descripcion;
private System.Double? _cantidad;
private AccesoriosEquipo _accesoriosEquipo;
private EntradaSalidaEquipo _entradaSalidaEquipo;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodEntradaSalidaEquipos 
{
get
{
return _codEntradaSalidaEquipos;
}
set 
{
if ( _codEntradaSalidaEquipos != value) 
{
_codEntradaSalidaEquipos = value ;
OnPropertyChanged("CodEntradaSalidaEquipos");
}
}
}

public virtual System.Int32 Codigo 
{
get
{
return _codigo;
}
set 
{
if ( _codigo != value) 
{
_codigo = value ;
OnPropertyChanged("Codigo");
}
}
}

public virtual System.Boolean SonDeEntrada 
{
get
{
return _sonDeEntrada;
}
set 
{
if ( _sonDeEntrada != value) 
{
_sonDeEntrada = value ;
OnPropertyChanged("SonDeEntrada");
}
}
}

public virtual System.String CodAccesoriosEquipos 
{
get
{
if ( AccesoriosEquipo != null ) 
{
_codAccesoriosEquipos = (System.String)AccesoriosEquipo.CodAccesoriosEquipos;
}

return _codAccesoriosEquipos;
}
set 
{
if ( _codAccesoriosEquipos != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_accesoriosEquipo = null;

_codAccesoriosEquipos = value ;
OnPropertyChanged("CodAccesoriosEquipos");
}
}
}

public virtual System.Boolean? EsOtro 
{
get
{
return _esOtro;
}
set 
{
if ( _esOtro != value) 
{
_esOtro = value ;
OnPropertyChanged("EsOtro");
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

public virtual System.Double? Cantidad 
{
get
{
return _cantidad;
}
set 
{
if ( _cantidad != value) 
{
_cantidad = value ;
OnPropertyChanged("Cantidad");
}
}
}

/// <summary>
/// Generated from Relation FK_AccesoriosxEntradaSalidaEquipos_accesoriosEquipo
/// </summary>
[GenWiseAttribute(RelationID = "754f91d4-ed19-44b3-9eec-460377a36b0a") ]
public virtual AccesoriosEquipo AccesoriosEquipo 
{
get
{
if ( _accesoriosEquipo == null ) 
{
if ( String.IsNullOrEmpty(_codAccesoriosEquipos) || _codAccesoriosEquipos.Equals(string.Empty) ) 
{
if ( _accesoriosEquipo != null && ( _accesoriosEquipo.CodAccesoriosEquipos.Equals(null) ) )
{
  _accesoriosEquipo = null;
}
}
else
{
_accesoriosEquipo = (new AccesoriosEquipoFactory()).Get(_codAccesoriosEquipos);
}
}

return _accesoriosEquipo;
}
set 
{
if ( _accesoriosEquipo != value) 
{
if ( value==null ) _codAccesoriosEquipos = null; else _codAccesoriosEquipos = (System.String)value.CodAccesoriosEquipos; 
_accesoriosEquipo = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_AccesoriosxEntradaSalidaEquipos_EntradaSalidaEquipos
/// </summary>
[GenWiseAttribute(RelationID = "f1f780af-830c-4c8d-94cd-e02593455a2e") ]
public virtual EntradaSalidaEquipo EntradaSalidaEquipo 
{
get
{
if ( _entradaSalidaEquipo == null ) 
{
if (  _codEntradaSalidaEquipos.Equals(0)  || _codEntradaSalidaEquipos.Equals(System.Int32.MinValue) ) 
{
if ( _entradaSalidaEquipo != null && ( _entradaSalidaEquipo.CodEntradaSalidaEquipos.Equals(System.Int32.MinValue) ) )
{
  _entradaSalidaEquipo = null;
}
}
else
{
_entradaSalidaEquipo = (new EntradaSalidaEquipoFactory()).Get(_codEntradaSalidaEquipos);
}
}

return _entradaSalidaEquipo;
}
set 
{
if ( _entradaSalidaEquipo != value) 
{
if ( value==null ) _codEntradaSalidaEquipos = System.Int32.MinValue; else _codEntradaSalidaEquipos = (System.Int32)value.CodEntradaSalidaEquipos; 
_entradaSalidaEquipo = value ;
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

_retValue += CodEntradaSalidaEquipos.ToString();

_retValue += "^";
_retValue += Codigo.ToString();

_retValue += "^";
_retValue += SonDeEntrada.ToString();

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
/// Create a new AccesoriosxEntradaSalidaEquipo object. 
/// </summary>
public  AccesoriosxEntradaSalidaEquipo()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  AccesoriosxEntradaSalidaEquipo(System.Int32 pCodEntradaSalidaEquipos , System.Int32 pCodigo , System.Boolean pSonDeEntrada)
{
_codEntradaSalidaEquipos = pCodEntradaSalidaEquipos ;
_codigo = pCodigo ;
_sonDeEntrada = pSonDeEntrada ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
_hash += CodEntradaSalidaEquipos.ToString();
_hash += Codigo.ToString();
_hash += SonDeEntrada.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
AccesoriosxEntradaSalidaEquipo _newAccesoriosxEntradaSalidaEquipo = (pObject as AccesoriosxEntradaSalidaEquipo); 
if (_newAccesoriosxEntradaSalidaEquipo == null ) return false; 
if (_newAccesoriosxEntradaSalidaEquipo.GetHashCode() == this.GetHashCode() ) return true; 
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
if (  CodEntradaSalidaEquipos.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codEntradaSalidaEquipos) can not be null!. " ) );
}
if (  Codigo.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (Codigo) can not be null!. " ) );
}
// Column sonDeEntrada skipped because it non-nullable boolean.

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

