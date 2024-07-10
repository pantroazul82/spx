using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class ProgramacionViaje : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codProgramacionViajes;
private System.DateTime? _fechaCreacion;
private System.String _creadoPor;
private System.DateTime? _fechaViaje;
private System.DateTime? _fechaRegreso;
private System.String _ingenieroAsignado;
private System.Boolean? _programada;
private System.String _codPais;
private System.String _codDepartamento;
private System.String _codCiudad;
private System.String _observaciones;
private System.Int32? _codAsesor;
private IList<DetalleProgramacionViaje> _detalleProgramacionViajes;
private AsesoresComerciale _asesoresComerciale;
private Usuario0 _usuario0;
private Usuario0 _usuario01;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodProgramacionViajes 
{
get
{
return _codProgramacionViajes;
}
set 
{
if ( _codProgramacionViajes != value) 
{
_codProgramacionViajes = value ;
OnPropertyChanged("CodProgramacionViajes");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaCreacion_Date 
{
get
{
if (  !FechaCreacion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaCreacion.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaCreacion.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaCreacion_Time)) {

FechaCreacion = null;
}
 else
{
 FechaCreacion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaCreacion.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaCreacion_Time)) 
{
 FechaCreacion = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaCreacion = Convert.ToDateTime( " " + value + " " + FechaCreacion.Value.ToString("HH:mm:ss.fff") ) ;
}
}

}
}

/// <summary>
/// This property contains a calculated, bindable value of the TIME part of a DateTime property. If you want to only work with the TIME and ignore the underlying DATE component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaCreacion_Time 
{
get
{
if (  !FechaCreacion.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaCreacion.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaCreacion.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaCreacion_Date)) 
{
FechaCreacion = null;
}
 else
{
 FechaCreacion = Convert.ToDateTime( " " + FechaCreacion.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaCreacion_Date)) 
{
 FechaCreacion = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaCreacion = Convert.ToDateTime( " " + FechaCreacion_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaCreacion 
{
get
{
return _fechaCreacion;
}
set 
{
if ( _fechaCreacion != value) 
{
_fechaCreacion = value ;
OnPropertyChanged("FechaCreacion");
}
}
}

public virtual System.String CreadoPor 
{
get
{
if ( Usuario01 != null ) 
{
_creadoPor = (System.String)Usuario01.Login;
}

return _creadoPor;
}
set 
{
if ( _creadoPor != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_usuario01 = null;

_creadoPor = value ;
OnPropertyChanged("CreadoPor");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaViaje_Date 
{
get
{
if (  !FechaViaje.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaViaje.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaViaje.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaViaje_Time)) {

FechaViaje = null;
}
 else
{
 FechaViaje = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaViaje.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaViaje_Time)) 
{
 FechaViaje = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaViaje = Convert.ToDateTime( " " + value + " " + FechaViaje.Value.ToString("HH:mm:ss.fff") ) ;
}
}

}
}

/// <summary>
/// This property contains a calculated, bindable value of the TIME part of a DateTime property. If you want to only work with the TIME and ignore the underlying DATE component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaViaje_Time 
{
get
{
if (  !FechaViaje.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaViaje.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaViaje.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaViaje_Date)) 
{
FechaViaje = null;
}
 else
{
 FechaViaje = Convert.ToDateTime( " " + FechaViaje.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaViaje_Date)) 
{
 FechaViaje = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaViaje = Convert.ToDateTime( " " + FechaViaje_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaViaje 
{
get
{
return _fechaViaje;
}
set 
{
if ( _fechaViaje != value) 
{
_fechaViaje = value ;
OnPropertyChanged("FechaViaje");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaRegreso_Date 
{
get
{
if (  !FechaRegreso.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaRegreso.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FechaRegreso.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaRegreso_Time)) {

FechaRegreso = null;
}
 else
{
 FechaRegreso = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FechaRegreso.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaRegreso_Time)) 
{
 FechaRegreso = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FechaRegreso = Convert.ToDateTime( " " + value + " " + FechaRegreso.Value.ToString("HH:mm:ss.fff") ) ;
}
}

}
}

/// <summary>
/// This property contains a calculated, bindable value of the TIME part of a DateTime property. If you want to only work with the TIME and ignore the underlying DATE component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FechaRegreso_Time 
{
get
{
if (  !FechaRegreso.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FechaRegreso.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FechaRegreso.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FechaRegreso_Date)) 
{
FechaRegreso = null;
}
 else
{
 FechaRegreso = Convert.ToDateTime( " " + FechaRegreso.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FechaRegreso_Date)) 
{
 FechaRegreso = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FechaRegreso = Convert.ToDateTime( " " + FechaRegreso_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FechaRegreso 
{
get
{
return _fechaRegreso;
}
set 
{
if ( _fechaRegreso != value) 
{
_fechaRegreso = value ;
OnPropertyChanged("FechaRegreso");
}
}
}

public virtual System.String IngenieroAsignado 
{
get
{
if ( Usuario0 != null ) 
{
_ingenieroAsignado = (System.String)Usuario0.Login;
}

return _ingenieroAsignado;
}
set 
{
if ( _ingenieroAsignado != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_usuario0 = null;

_ingenieroAsignado = value ;
OnPropertyChanged("IngenieroAsignado");
}
}
}

public virtual System.Boolean? Programada 
{
get
{
return _programada;
}
set 
{
if ( _programada != value) 
{
_programada = value ;
OnPropertyChanged("Programada");
}
}
}

public virtual System.String CodPais 
{
get
{
return _codPais;
}
set 
{
if ( _codPais != value) 
{
_codPais = value ;
OnPropertyChanged("CodPais");
}
}
}

public virtual System.String CodDepartamento 
{
get
{
return _codDepartamento;
}
set 
{
if ( _codDepartamento != value) 
{
_codDepartamento = value ;
OnPropertyChanged("CodDepartamento");
}
}
}

public virtual System.String CodCiudad 
{
get
{
return _codCiudad;
}
set 
{
if ( _codCiudad != value) 
{
_codCiudad = value ;
OnPropertyChanged("CodCiudad");
}
}
}

public virtual System.String Observaciones 
{
get
{
return _observaciones;
}
set 
{
if ( _observaciones != value) 
{
_observaciones = value ;
OnPropertyChanged("Observaciones");
}
}
}

public virtual System.Int32? CodAsesor 
{
get
{
if ( AsesoresComerciale != null ) 
{
_codAsesor = (System.Int32)AsesoresComerciale.CodAsesor;
}

return _codAsesor;
}
set 
{
if ( _codAsesor != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_asesoresComerciale = null;

_codAsesor = value ;
OnPropertyChanged("CodAsesor");
}
}
}

/// <summary>
/// Collection of DetalleProgramacionViaje.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "47b7ba38-2505-4909-a387-2ce435597bc7" , CollectionOfType = typeof(DetalleProgramacionViaje)) ]
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
/// Generated from Relation FK_programacionViajes_asesoresComerciales
/// </summary>
[GenWiseAttribute(RelationID = "b4666742-5c7a-4da3-b862-7786137eba66") ]
public virtual AsesoresComerciale AsesoresComerciale 
{
get
{
if ( _asesoresComerciale == null ) 
{
if ( !_codAsesor.HasValue || _codAsesor.Value.Equals(System.Int32.MinValue) ) 
{
if ( _asesoresComerciale != null && ( _asesoresComerciale.CodAsesor.Equals(null) ) )
{
  _asesoresComerciale = null;
}
}
else
{
_asesoresComerciale = (new AsesoresComercialeFactory()).Get(_codAsesor.Value);
}
}

return _asesoresComerciale;
}
set 
{
if ( _asesoresComerciale != value) 
{
if ( value==null ) _codAsesor = null; else _codAsesor = (System.Int32)value.CodAsesor; 
_asesoresComerciale = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_programacionViajes_usuarios
/// </summary>
[GenWiseAttribute(RelationID = "900cf5d5-b60e-4312-9854-793383a8a9d9") ]
public virtual Usuario0 Usuario0 
{
get
{
if ( _usuario0 == null ) 
{
if ( String.IsNullOrEmpty(_ingenieroAsignado) || _ingenieroAsignado.Equals(string.Empty) ) 
{
if ( _usuario0 != null && ( _usuario0.Login.Equals(null) ) )
{
  _usuario0 = null;
}
}
else
{
_usuario0 = (new Usuario0Factory()).Get(_ingenieroAsignado);
}
}

return _usuario0;
}
set 
{
if ( _usuario0 != value) 
{
if ( value==null ) _ingenieroAsignado = null; else _ingenieroAsignado = (System.String)value.Login; 
_usuario0 = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_programacionViajes_usuarios1
/// </summary>
[GenWiseAttribute(RelationID = "6dbbdadf-b6bf-4cbc-8cc5-8f9745e44216") ]
public virtual Usuario0 Usuario01 
{
get
{
if ( _usuario01 == null ) 
{
if ( String.IsNullOrEmpty(_creadoPor) || _creadoPor.Equals(string.Empty) ) 
{
if ( _usuario01 != null && ( _usuario01.Login.Equals(null) ) )
{
  _usuario01 = null;
}
}
else
{
_usuario01 = (new Usuario0Factory()).Get(_creadoPor);
}
}

return _usuario01;
}
set 
{
if ( _usuario01 != value) 
{
if ( value==null ) _creadoPor = null; else _creadoPor = (System.String)value.Login; 
_usuario01 = value ;
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
/// Create a new ProgramacionViaje object. 
/// </summary>
public  ProgramacionViaje()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  ProgramacionViaje(System.Int32 pCodProgramacionViajes)
{
_codProgramacionViajes = pCodProgramacionViajes ;

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
if (  CodProgramacionViajes.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codProgramacionViajes) can not be null!. " ) );
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

