using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class CGQ_TipoFiltro : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codTipoFiltro;
private System.String _descripcion;
private IList<CGQ_ParametrosQuery> _cGQ_ParametrosQueries;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodTipoFiltro 
{
get
{
return _codTipoFiltro;
}
set 
{
if ( _codTipoFiltro != value) 
{
_codTipoFiltro = value ;
OnPropertyChanged("CodTipoFiltro");
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
/// Collection of CGQ_ParametrosQuery.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "dcb74fa7-1b0b-4e08-864e-e4988e4c5578" , CollectionOfType = typeof(CGQ_ParametrosQuery)) ]
public virtual IList<CGQ_ParametrosQuery> CGQ_ParametrosQueries 
{
get
{
 if (_cGQ_ParametrosQueries == null) _cGQ_ParametrosQueries = new List<CGQ_ParametrosQuery>();

return _cGQ_ParametrosQueries;
}
set 
{
if ( _cGQ_ParametrosQueries != value) 
{
_cGQ_ParametrosQueries = value ;
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
/// Create a new CGQ_TipoFiltro object. 
/// </summary>
public  CGQ_TipoFiltro()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  CGQ_TipoFiltro(System.Int32 pCodTipoFiltro)
{
_codTipoFiltro = pCodTipoFiltro ;

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
if (  CodTipoFiltro.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codTipoFiltro) can not be null!. " ) );
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

