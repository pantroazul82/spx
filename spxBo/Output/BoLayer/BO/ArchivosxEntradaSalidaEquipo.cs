using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class ArchivosxEntradaSalidaEquipo : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codarchivosxEntradaSalidaEquipos;
private System.Int32? _codEntradaSalidaEquipos;
private System.String _nombreArchivo;
private System.String _descripcion;
private EntradaSalidaEquipo _entradaSalidaEquipo;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodarchivosxEntradaSalidaEquipos 
{
get
{
return _codarchivosxEntradaSalidaEquipos;
}
set 
{
if ( _codarchivosxEntradaSalidaEquipos != value) 
{
_codarchivosxEntradaSalidaEquipos = value ;
OnPropertyChanged("CodarchivosxEntradaSalidaEquipos");
}
}
}

public virtual System.Int32? CodEntradaSalidaEquipos 
{
get
{
if ( EntradaSalidaEquipo != null ) 
{
_codEntradaSalidaEquipos = (System.Int32)EntradaSalidaEquipo.CodEntradaSalidaEquipos;
}

return _codEntradaSalidaEquipos;
}
set 
{
if ( _codEntradaSalidaEquipos != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_entradaSalidaEquipo = null;

_codEntradaSalidaEquipos = value ;
OnPropertyChanged("CodEntradaSalidaEquipos");
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
/// Generated from Relation FK_archivosxEntradaSalidaEquipos_EntradaSalidaEquipos
/// </summary>
[GenWiseAttribute(RelationID = "b189b9e1-071a-40b2-a890-ee33b728f422") ]
public virtual EntradaSalidaEquipo EntradaSalidaEquipo 
{
get
{
if ( _entradaSalidaEquipo == null ) 
{
if ( !_codEntradaSalidaEquipos.HasValue || _codEntradaSalidaEquipos.Value.Equals(System.Int32.MinValue) ) 
{
if ( _entradaSalidaEquipo != null && ( _entradaSalidaEquipo.CodEntradaSalidaEquipos.Equals(null) ) )
{
  _entradaSalidaEquipo = null;
}
}
else
{
_entradaSalidaEquipo = (new EntradaSalidaEquipoFactory()).Get(_codEntradaSalidaEquipos.Value);
}
}

return _entradaSalidaEquipo;
}
set 
{
if ( _entradaSalidaEquipo != value) 
{
if ( value==null ) _codEntradaSalidaEquipos = null; else _codEntradaSalidaEquipos = (System.Int32)value.CodEntradaSalidaEquipos; 
_entradaSalidaEquipo = value ;
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
/// Create a new ArchivosxEntradaSalidaEquipo object. 
/// </summary>
public  ArchivosxEntradaSalidaEquipo()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  ArchivosxEntradaSalidaEquipo(System.Int32 pCodarchivosxEntradaSalidaEquipos)
{
_codarchivosxEntradaSalidaEquipos = pCodarchivosxEntradaSalidaEquipos ;

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
if (  CodarchivosxEntradaSalidaEquipos.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codarchivosxEntradaSalidaEquipos) can not be null!. " ) );
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

