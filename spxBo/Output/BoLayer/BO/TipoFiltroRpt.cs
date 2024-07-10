using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class TipoFiltroRpt : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codTipoFiltroRpt;
private System.String _descripcion;
private IList<FiltrosRpt> _filtrosRpts;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodTipoFiltroRpt 
{
get
{
return _codTipoFiltroRpt;
}
set 
{
if ( _codTipoFiltroRpt != value) 
{
_codTipoFiltroRpt = value ;
OnPropertyChanged("CodTipoFiltroRpt");
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
/// Collection of FiltrosRpt.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "5ec9258f-1f93-4c95-a203-5e7913f74a32" , CollectionOfType = typeof(FiltrosRpt)) ]
public virtual IList<FiltrosRpt> FiltrosRpts 
{
get
{
 if (_filtrosRpts == null) _filtrosRpts = new List<FiltrosRpt>();

return _filtrosRpts;
}
set 
{
if ( _filtrosRpts != value) 
{
_filtrosRpts = value ;
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
/// Create a new TipoFiltroRpt object. 
/// </summary>
public  TipoFiltroRpt()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  TipoFiltroRpt(System.Int32 pCodTipoFiltroRpt)
{
_codTipoFiltroRpt = pCodTipoFiltroRpt ;

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
if (  CodTipoFiltroRpt.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codTipoFiltroRpt) can not be null!. " ) );
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

