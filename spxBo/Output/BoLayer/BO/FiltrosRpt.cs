using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class FiltrosRpt : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _idRpt;
private System.Int32 _codFiltroRpt;
private System.Int32? _codTipoFiltroRpt;
private System.String _nombre;
private System.String _campo;
private Rpt _rpt;
private TipoFiltroRpt _tipoFiltroRpt;

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

public virtual System.Int32 CodFiltroRpt 
{
get
{
return _codFiltroRpt;
}
set 
{
if ( _codFiltroRpt != value) 
{
_codFiltroRpt = value ;
OnPropertyChanged("CodFiltroRpt");
}
}
}

public virtual System.Int32? CodTipoFiltroRpt 
{
get
{
if ( TipoFiltroRpt != null ) 
{
_codTipoFiltroRpt = (System.Int32)TipoFiltroRpt.CodTipoFiltroRpt;
}

return _codTipoFiltroRpt;
}
set 
{
if ( _codTipoFiltroRpt != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_tipoFiltroRpt = null;

_codTipoFiltroRpt = value ;
OnPropertyChanged("CodTipoFiltroRpt");
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

public virtual System.String Campo 
{
get
{
return _campo;
}
set 
{
if ( _campo != value) 
{
_campo = value ;
OnPropertyChanged("Campo");
}
}
}

/// <summary>
/// Generated from Relation FK_filtrosRpt_rpt
/// </summary>
[GenWiseAttribute(RelationID = "11dce827-9c47-447b-ac06-357f488ff7b4") ]
public virtual Rpt Rpt 
{
get
{
if ( _rpt == null ) 
{
if (  _idRpt.Equals(0)  || _idRpt.Equals(System.Int32.MinValue) ) 
{
if ( _rpt != null && ( _rpt.IdRpt.Equals(System.Int32.MinValue) ) )
{
  _rpt = null;
}
}
else
{
_rpt = (new RptFactory()).Get(_idRpt);
}
}

return _rpt;
}
set 
{
if ( _rpt != value) 
{
if ( value==null ) _idRpt = System.Int32.MinValue; else _idRpt = (System.Int32)value.IdRpt; 
_rpt = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_filtrosRpt_tipoFiltroRpt
/// </summary>
[GenWiseAttribute(RelationID = "5ec9258f-1f93-4c95-a203-5e7913f74a32") ]
public virtual TipoFiltroRpt TipoFiltroRpt 
{
get
{
if ( _tipoFiltroRpt == null ) 
{
if ( !_codTipoFiltroRpt.HasValue || _codTipoFiltroRpt.Value.Equals(System.Int32.MinValue) ) 
{
if ( _tipoFiltroRpt != null && ( _tipoFiltroRpt.CodTipoFiltroRpt.Equals(null) ) )
{
  _tipoFiltroRpt = null;
}
}
else
{
_tipoFiltroRpt = (new TipoFiltroRptFactory()).Get(_codTipoFiltroRpt.Value);
}
}

return _tipoFiltroRpt;
}
set 
{
if ( _tipoFiltroRpt != value) 
{
if ( value==null ) _codTipoFiltroRpt = null; else _codTipoFiltroRpt = (System.Int32)value.CodTipoFiltroRpt; 
_tipoFiltroRpt = value ;
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

_retValue += IdRpt.ToString();

_retValue += "^";
_retValue += CodFiltroRpt.ToString();

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
/// Create a new FiltrosRpt object. 
/// </summary>
public  FiltrosRpt()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  FiltrosRpt(System.Int32 pIdRpt , System.Int32 pCodFiltroRpt)
{
_idRpt = pIdRpt ;
_codFiltroRpt = pCodFiltroRpt ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
_hash += IdRpt.ToString();
_hash += CodFiltroRpt.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
FiltrosRpt _newFiltrosRpt = (pObject as FiltrosRpt); 
if (_newFiltrosRpt == null ) return false; 
if (_newFiltrosRpt.GetHashCode() == this.GetHashCode() ) return true; 
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
if (  IdRpt.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (idRpt) can not be null!. " ) );
}
if (  CodFiltroRpt.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codFiltroRpt) can not be null!. " ) );
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

