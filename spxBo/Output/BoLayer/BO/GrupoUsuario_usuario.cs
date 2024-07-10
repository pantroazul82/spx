using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class GrupoUsuario_usuario : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codGrupoUsuario;
private System.Int32 _codUsuario;
private System.Int32 _codGrupoUsuario_usuario;
private GrupoUsuario _grupoUsuario;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodGrupoUsuario 
{
get
{
if ( GrupoUsuario != null ) 
{
_codGrupoUsuario = (System.Int32)GrupoUsuario.CodGrupoUsuario;
}

return _codGrupoUsuario;
}
set 
{
if ( _codGrupoUsuario != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_grupoUsuario = null;

_codGrupoUsuario = value ;
OnPropertyChanged("CodGrupoUsuario");
}
}
}

public virtual System.Int32 CodUsuario 
{
get
{
return _codUsuario;
}
set 
{
if ( _codUsuario != value) 
{
_codUsuario = value ;
OnPropertyChanged("CodUsuario");
}
}
}

public virtual System.Int32 CodGrupoUsuario_usuario 
{
get
{
return _codGrupoUsuario_usuario;
}
}

/// <summary>
/// Generated from Relation FK_grupoUsuario_usuario_grupoUsuario
/// </summary>
[GenWiseAttribute(RelationID = "a60a8b09-a9d5-418e-95ce-3c3c3c648a37") ]
public virtual GrupoUsuario GrupoUsuario 
{
get
{
if ( _grupoUsuario == null ) 
{
if (  _codGrupoUsuario.Equals(0)  || _codGrupoUsuario.Equals(System.Int32.MinValue) ) 
{
if ( _grupoUsuario != null && ( _grupoUsuario.CodGrupoUsuario.Equals(System.Int32.MinValue) ) )
{
  _grupoUsuario = null;
}
}
else
{
_grupoUsuario = (new GrupoUsuarioFactory()).Get(_codGrupoUsuario);
}
}

return _grupoUsuario;
}
set 
{
if ( _grupoUsuario != value) 
{
if ( value==null ) _codGrupoUsuario = System.Int32.MinValue; else _codGrupoUsuario = (System.Int32)value.CodGrupoUsuario; 
_grupoUsuario = value ;
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
/// Create a new GrupoUsuario_usuario object. 
/// </summary>
public  GrupoUsuario_usuario()
{
_codGrupoUsuario_usuario = System.Int32.MinValue;

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

