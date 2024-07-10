using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class PrioridadesOrdenServicio : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codPrioridadOS;
private System.String _nombre;
private System.Int32? _orden;
private System.Boolean? _esOrdenInterna;
private IList<DetalleProgramacionViaje> _detalleProgramacionViajes;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodPrioridadOS 
{
get
{
return _codPrioridadOS;
}
set 
{
if ( _codPrioridadOS != value) 
{
_codPrioridadOS = value ;
OnPropertyChanged("CodPrioridadOS");
}
}
}

public virtual System.String Nombre 
{
get
{
return _nombre;
}
set 
{
if ( _nombre != value) 
{
_nombre = value ;
OnPropertyChanged("Nombre");
}
}
}

public virtual System.Int32? Orden 
{
get
{
return _orden;
}
set 
{
if ( _orden != value) 
{
_orden = value ;
OnPropertyChanged("Orden");
}
}
}

public virtual System.Boolean? EsOrdenInterna 
{
get
{
return _esOrdenInterna;
}
set 
{
if ( _esOrdenInterna != value) 
{
_esOrdenInterna = value ;
OnPropertyChanged("EsOrdenInterna");
}
}
}

/// <summary>
/// Collection of DetalleProgramacionViaje.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "4aed6798-5232-4c69-9509-cce104f80eac" , CollectionOfType = typeof(DetalleProgramacionViaje)) ]
public virtual IList<DetalleProgramacionViaje> DetalleProgramacionViajes 
{
get
{
 if (_detalleProgramacionViajes == null) _detalleProgramacionViajes = new List<DetalleProgramacionViaje>();

return _detalleProgramacionViajes;
}
set 
{
if ( _detalleProgramacionViajes != value) 
{
_detalleProgramacionViajes = value ;
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
/// Create a new PrioridadesOrdenServicio object. 
/// </summary>
public  PrioridadesOrdenServicio()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  PrioridadesOrdenServicio(System.Int32 pCodPrioridadOS)
{
_codPrioridadOS = pCodPrioridadOS ;

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
if (  CodPrioridadOS.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codPrioridadOS) can not be null!. " ) );
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

