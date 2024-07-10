using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class AsesoresComerciale : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codAsesor;
private System.String _nombreAsesor;
private System.String _correo;
private System.String _telefono;
private System.String _celular;
private IList<LlamadaSoporte> _llamadaSoportes;
private IList<OrdenServicio> _ordenServicios;
private IList<ProgramacionViaje> _programacionViajes;
private IList<SolicitudServicio> _solicitudServicios;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodAsesor 
{
get
{
return _codAsesor;
}
set 
{
if ( _codAsesor != value) 
{
_codAsesor = value ;
OnPropertyChanged("CodAsesor");
}
}
}

public virtual System.String NombreAsesor 
{
get
{
return _nombreAsesor;
}
set 
{
if ( _nombreAsesor != value) 
{
_nombreAsesor = value ;
OnPropertyChanged("NombreAsesor");
}
}
}

public virtual System.String Correo 
{
get
{
return _correo;
}
set 
{
if ( _correo != value) 
{
_correo = value ;
OnPropertyChanged("Correo");
}
}
}

public virtual System.String Telefono 
{
get
{
return _telefono;
}
set 
{
if ( _telefono != value) 
{
_telefono = value ;
OnPropertyChanged("Telefono");
}
}
}

public virtual System.String Celular 
{
get
{
return _celular;
}
set 
{
if ( _celular != value) 
{
_celular = value ;
OnPropertyChanged("Celular");
}
}
}

/// <summary>
/// Collection of LlamadaSoporte.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "6a85bb75-d389-425d-a307-2121b9e504ba" , CollectionOfType = typeof(LlamadaSoporte)) ]
public virtual IList<LlamadaSoporte> LlamadaSoportes 
{
get
{
 if (_llamadaSoportes == null) _llamadaSoportes = new List<LlamadaSoporte>();

return _llamadaSoportes;
}
set 
{
if ( _llamadaSoportes != value) 
{
_llamadaSoportes = value ;
}
}
}

/// <summary>
/// Collection of OrdenServicio.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "fb257a46-2f25-4400-966c-b1bcc6de2b4f" , CollectionOfType = typeof(OrdenServicio)) ]
public virtual IList<OrdenServicio> OrdenServicios 
{
get
{
 if (_ordenServicios == null) _ordenServicios = new List<OrdenServicio>();

return _ordenServicios;
}
set 
{
if ( _ordenServicios != value) 
{
_ordenServicios = value ;
}
}
}

/// <summary>
/// Collection of ProgramacionViaje.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "b4666742-5c7a-4da3-b862-7786137eba66" , CollectionOfType = typeof(ProgramacionViaje)) ]
public virtual IList<ProgramacionViaje> ProgramacionViajes 
{
get
{
 if (_programacionViajes == null) _programacionViajes = new List<ProgramacionViaje>();

return _programacionViajes;
}
set 
{
if ( _programacionViajes != value) 
{
_programacionViajes = value ;
}
}
}

/// <summary>
/// Collection of SolicitudServicio.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "827e6f77-4fe7-4bdb-b2a2-a2e5f92e9eaf" , CollectionOfType = typeof(SolicitudServicio)) ]
public virtual IList<SolicitudServicio> SolicitudServicios 
{
get
{
 if (_solicitudServicios == null) _solicitudServicios = new List<SolicitudServicio>();

return _solicitudServicios;
}
set 
{
if ( _solicitudServicios != value) 
{
_solicitudServicios = value ;
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
/// Create a new AsesoresComerciale object. 
/// </summary>
public  AsesoresComerciale()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  AsesoresComerciale(System.Int32 pCodAsesor)
{
_codAsesor = pCodAsesor ;

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
if (  CodAsesor.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codAsesor) can not be null!. " ) );
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

