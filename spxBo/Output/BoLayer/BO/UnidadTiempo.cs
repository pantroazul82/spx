using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class UnidadTiempo : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codUnidadTiempo;
private System.String _descripcion;
private System.Double? _factorConversion;
private IList<SolicitudInsumo> _solicitudInsumos;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodUnidadTiempo 
{
get
{
return _codUnidadTiempo;
}
set 
{
if ( _codUnidadTiempo != value) 
{
_codUnidadTiempo = value ;
OnPropertyChanged("CodUnidadTiempo");
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
/// Collection of SolicitudInsumo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "d7723c08-833d-4d07-b0e0-43e00b339660" , CollectionOfType = typeof(SolicitudInsumo)) ]
public virtual IList<SolicitudInsumo> SolicitudInsumos 
{
get
{
 if (_solicitudInsumos == null) _solicitudInsumos = new List<SolicitudInsumo>();

return _solicitudInsumos;
}
set 
{
if ( _solicitudInsumos != value) 
{
_solicitudInsumos = value ;
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
/// Create a new UnidadTiempo object. 
/// </summary>
public  UnidadTiempo()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  UnidadTiempo(System.Int32 pCodUnidadTiempo)
{
_codUnidadTiempo = pCodUnidadTiempo ;

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
if (  CodUnidadTiempo.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codUnidadTiempo) can not be null!. " ) );
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

