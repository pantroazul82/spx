using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class Rpt : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _idRpt;
private System.String _nombreRpt;
private System.String _captionRpt;
private System.String _xml;
private System.Boolean? _filtroObligatorio;
private IList<FiltrosRpt> _filtrosRpts;

#endregion


#region --- Class Properties ---

public virtual System.Int32 IdRpt 
{
get
{
return _idRpt;
}
set 
{
if ( _idRpt != value) 
{
_idRpt = value ;
OnPropertyChanged("IdRpt");
}
}
}

public virtual System.String NombreRpt 
{
get
{
return _nombreRpt;
}
set 
{
if ( _nombreRpt != value) 
{
_nombreRpt = value ;
OnPropertyChanged("NombreRpt");
}
}
}

public virtual System.String CaptionRpt 
{
get
{
return _captionRpt;
}
set 
{
if ( _captionRpt != value) 
{
_captionRpt = value ;
OnPropertyChanged("CaptionRpt");
}
}
}

public virtual System.String Xml 
{
get
{
return _xml;
}
set 
{
if ( _xml != value) 
{
_xml = value ;
OnPropertyChanged("Xml");
}
}
}

public virtual System.Boolean? FiltroObligatorio 
{
get
{
return _filtroObligatorio;
}
set 
{
if ( _filtroObligatorio != value) 
{
_filtroObligatorio = value ;
OnPropertyChanged("FiltroObligatorio");
}
}
}

/// <summary>
/// Collection of FiltrosRpt.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "11dce827-9c47-447b-ac06-357f488ff7b4" , CollectionOfType = typeof(FiltrosRpt)) ]
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
/// Create a new Rpt object. 
/// </summary>
public  Rpt()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  Rpt(System.Int32 pIdRpt)
{
_idRpt = pIdRpt ;

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
if (  IdRpt.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (idRpt) can not be null!. " ) );
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

