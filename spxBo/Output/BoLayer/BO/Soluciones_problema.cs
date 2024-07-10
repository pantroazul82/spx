using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class Soluciones_problema : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _cod_soluciones_problemas;
private System.Int32? _cod_problema_frecuente;
private System.String _nombre_solucion;
private System.String _descripcion_solucion;
private Problemas_frecuente _problemas_frecuente;

#endregion


#region --- Class Properties ---

public virtual System.Int32 Cod_soluciones_problemas 
{
get
{
return _cod_soluciones_problemas;
}
}

public virtual System.Int32? Cod_problema_frecuente 
{
get
{
if ( Problemas_frecuente != null ) 
{
_cod_problema_frecuente = (System.Int32)Problemas_frecuente.Cod_problema_frecuente;
}

return _cod_problema_frecuente;
}
set 
{
if ( _cod_problema_frecuente != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_problemas_frecuente = null;

_cod_problema_frecuente = value ;
OnPropertyChanged("Cod_problema_frecuente");
}
}
}

public virtual System.String Nombre_solucion 
{
get
{
return _nombre_solucion;
}
set 
{
if ( _nombre_solucion != value) 
{
_nombre_solucion = value ;
OnPropertyChanged("Nombre_solucion");
}
}
}

public virtual System.String Descripcion_solucion 
{
get
{
return _descripcion_solucion;
}
set 
{
if ( _descripcion_solucion != value) 
{
_descripcion_solucion = value ;
OnPropertyChanged("Descripcion_solucion");
}
}
}

/// <summary>
/// Generated from Relation FK_soluciones_problemas_problemas_frecuentes
/// </summary>
[GenWiseAttribute(RelationID = "5d80e91a-d7e5-400e-9ffd-76230f023e57") ]
public virtual Problemas_frecuente Problemas_frecuente 
{
get
{
if ( _problemas_frecuente == null ) 
{
if ( !_cod_problema_frecuente.HasValue || _cod_problema_frecuente.Value.Equals(System.Int32.MinValue) ) 
{
if ( _problemas_frecuente != null && ( _problemas_frecuente.Cod_problema_frecuente.Equals(null) ) )
{
  _problemas_frecuente = null;
}
}
else
{
_problemas_frecuente = (new Problemas_frecuenteFactory()).Get(_cod_problema_frecuente.Value);
}
}

return _problemas_frecuente;
}
set 
{
if ( _problemas_frecuente != value) 
{
if ( value==null ) _cod_problema_frecuente = null; else _cod_problema_frecuente = (System.Int32)value.Cod_problema_frecuente; 
_problemas_frecuente = value ;
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
/// Create a new Soluciones_problema object. 
/// </summary>
public  Soluciones_problema()
{
_cod_soluciones_problemas = System.Int32.MinValue;

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

