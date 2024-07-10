using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class SucursalCliente : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _nitCliente;
private System.String _codSucursal;
private System.String _nombreSucursal;
private System.String _codPais;
private System.String _codDepartamento;
private System.String _codCiudad;
private System.String _direccion;
private System.String _telefono1;
private System.String _telefono2;
private System.String _codContacto;
private IList<EntradaSalidaEquipo> _entradaSalidaEquipos;
private IList<EntradaSalidaEquipo> _entradaSalidaEquipos1;
private IList<Equipo> _equipos;
private IList<LlamadaSoporte> _llamadaSoportes;
private IList<LogCambioUbicacione> _logCambioUbicaciones;
private IList<LogCambioUbicacione> _logCambioUbicaciones1;
private IList<OrdenServicio> _ordenServicios;
private IList<Recoleccion> _recoleccions;
private Ciudade _ciudade;
private Cliente _cliente;
private ContactosCliente _contactosCliente;

#endregion


#region --- Class Properties ---

public virtual System.String NitCliente 
{
get
{
return _nitCliente;
}
set 
{
if ( _nitCliente != value) 
{
_nitCliente = value ;
OnPropertyChanged("NitCliente");
}
}
}

public virtual System.String CodSucursal 
{
get
{
return _codSucursal;
}
set 
{
if ( _codSucursal != value) 
{
_codSucursal = value ;
OnPropertyChanged("CodSucursal");
}
}
}

public virtual System.String NombreSucursal 
{
get
{
return _nombreSucursal;
}
set 
{
if ( _nombreSucursal != value) 
{
_nombreSucursal = value ;
OnPropertyChanged("NombreSucursal");
}
}
}

public virtual System.String CodPais 
{
get
{
if ( Ciudade != null ) 
{
_codPais = (System.String)Ciudade.CodPais;
}

return _codPais;
}
set 
{
if ( _codPais != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_ciudade = null;

_codPais = value ;
OnPropertyChanged("CodPais");
}
}
}

public virtual System.String CodDepartamento 
{
get
{
if ( Ciudade != null ) 
{
_codDepartamento = (System.String)Ciudade.CodDepartamento;
}

return _codDepartamento;
}
set 
{
if ( _codDepartamento != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_ciudade = null;

_codDepartamento = value ;
OnPropertyChanged("CodDepartamento");
}
}
}

public virtual System.String CodCiudad 
{
get
{
if ( Ciudade != null ) 
{
_codCiudad = (System.String)Ciudade.CodCiudad;
}

return _codCiudad;
}
set 
{
if ( _codCiudad != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_ciudade = null;

_codCiudad = value ;
OnPropertyChanged("CodCiudad");
}
}
}

public virtual System.String Direccion 
{
get
{
return _direccion;
}
set 
{
if ( _direccion != value) 
{
_direccion = value ;
OnPropertyChanged("Direccion");
}
}
}

public virtual System.String Telefono1 
{
get
{
return _telefono1;
}
set 
{
if ( _telefono1 != value) 
{
_telefono1 = value ;
OnPropertyChanged("Telefono1");
}
}
}

public virtual System.String Telefono2 
{
get
{
return _telefono2;
}
set 
{
if ( _telefono2 != value) 
{
_telefono2 = value ;
OnPropertyChanged("Telefono2");
}
}
}

public virtual System.String CodContacto 
{
get
{
if ( ContactosCliente != null ) 
{
_codContacto = (System.String)ContactosCliente.CodContacto;
}

return _codContacto;
}
set 
{
if ( _codContacto != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_contactosCliente = null;

_codContacto = value ;
OnPropertyChanged("CodContacto");
}
}
}

/// <summary>
/// Collection of EntradaSalidaEquipo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "a5ce3ca0-d2ec-4c75-bb16-515593c3cffc" , CollectionOfType = typeof(EntradaSalidaEquipo)) ]
public virtual IList<EntradaSalidaEquipo> EntradaSalidaEquipos 
{
get
{
 if (_entradaSalidaEquipos == null) _entradaSalidaEquipos = new List<EntradaSalidaEquipo>();

return _entradaSalidaEquipos;
}
set 
{
if ( _entradaSalidaEquipos != value) 
{
_entradaSalidaEquipos = value ;
}
}
}

/// <summary>
/// Collection of EntradaSalidaEquipo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "affef2ed-d0a9-4550-b621-d9581813ea54" , CollectionOfType = typeof(EntradaSalidaEquipo)) ]
public virtual IList<EntradaSalidaEquipo> EntradaSalidaEquipos1 
{
get
{
 if (_entradaSalidaEquipos1 == null) _entradaSalidaEquipos1 = new List<EntradaSalidaEquipo>();

return _entradaSalidaEquipos1;
}
set 
{
if ( _entradaSalidaEquipos1 != value) 
{
_entradaSalidaEquipos1 = value ;
}
}
}

/// <summary>
/// Collection of Equipo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "dbbc3aeb-9b73-4252-88fd-6431aa79c4f0" , CollectionOfType = typeof(Equipo)) ]
public virtual IList<Equipo> Equipos 
{
get
{
 if (_equipos == null) _equipos = new List<Equipo>();

return _equipos;
}
set 
{
if ( _equipos != value) 
{
_equipos = value ;
}
}
}

/// <summary>
/// Collection of LlamadaSoporte.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "f18bc721-ce21-4f0b-97fa-819558df70b6" , CollectionOfType = typeof(LlamadaSoporte)) ]
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
/// Collection of LogCambioUbicacione.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "5d94a5df-018b-47cd-8b2d-b46b672df95d" , CollectionOfType = typeof(LogCambioUbicacione)) ]
public virtual IList<LogCambioUbicacione> LogCambioUbicaciones 
{
get
{
 if (_logCambioUbicaciones == null) _logCambioUbicaciones = new List<LogCambioUbicacione>();

return _logCambioUbicaciones;
}
set 
{
if ( _logCambioUbicaciones != value) 
{
_logCambioUbicaciones = value ;
}
}
}

/// <summary>
/// Collection of LogCambioUbicacione.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "e3523f52-82be-4215-92e1-7526f87f6a73" , CollectionOfType = typeof(LogCambioUbicacione)) ]
public virtual IList<LogCambioUbicacione> LogCambioUbicaciones1 
{
get
{
 if (_logCambioUbicaciones1 == null) _logCambioUbicaciones1 = new List<LogCambioUbicacione>();

return _logCambioUbicaciones1;
}
set 
{
if ( _logCambioUbicaciones1 != value) 
{
_logCambioUbicaciones1 = value ;
}
}
}

/// <summary>
/// Collection of OrdenServicio.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "811b128c-07a0-49b3-a071-41d0c1fc6b1e" , CollectionOfType = typeof(OrdenServicio)) ]
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
/// Collection of Recoleccion.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "9d78d9b3-f5cb-4d4b-87c5-85e90a6b6788" , CollectionOfType = typeof(Recoleccion)) ]
public virtual IList<Recoleccion> Recoleccions 
{
get
{
 if (_recoleccions == null) _recoleccions = new List<Recoleccion>();

return _recoleccions;
}
set 
{
if ( _recoleccions != value) 
{
_recoleccions = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_sucursalCliente_ciudades
/// </summary>
[GenWiseAttribute(RelationID = "4149959e-72f2-40b4-bbeb-44290e1fec38") ]
public virtual Ciudade Ciudade 
{
get
{
if ( _ciudade == null || _ciudade == null || _ciudade == null ) 
{
if ( String.IsNullOrEmpty(_codPais) || _codPais.Equals(string.Empty) || String.IsNullOrEmpty(_codDepartamento) || _codDepartamento.Equals(string.Empty) || String.IsNullOrEmpty(_codCiudad) || _codCiudad.Equals(string.Empty) ) 
{
if ( _ciudade != null && ( _ciudade.CodPais.Equals(null) || _ciudade.CodDepartamento.Equals(null) || _ciudade.CodCiudad.Equals(null) ) )
{
  _ciudade = null;
}
}
else
{
  _ciudade = (new CiudadeFactory()).Fetch(_codPais,_codDepartamento,_codCiudad);
}
}

return _ciudade;
}
set 
{
if ( _ciudade != value) 
{
if ( value==null ) _codPais = null; else _codPais = (System.String)value.CodPais; 
if ( value==null ) _codDepartamento = null; else _codDepartamento = (System.String)value.CodDepartamento; 
if ( value==null ) _codCiudad = null; else _codCiudad = (System.String)value.CodCiudad; 
_ciudade = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_sucursalCliente_clientes
/// </summary>
[GenWiseAttribute(RelationID = "dcebf87c-ae32-406f-9179-4ece35c95774") ]
public virtual Cliente Cliente 
{
get
{
if ( _cliente == null ) 
{
if ( String.IsNullOrEmpty(_nitCliente) || _nitCliente.Equals(string.Empty) ) 
{
if ( _cliente != null && ( _cliente.NitCliente.Equals(string.Empty) ) )
{
  _cliente = null;
}
}
else
{
_cliente = (new ClienteFactory()).Get(_nitCliente);
}
}

return _cliente;
}
set 
{
if ( _cliente != value) 
{
if ( value==null ) _nitCliente = string.Empty; else _nitCliente = (System.String)value.NitCliente; 
_cliente = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_sucursalCliente_contactosClientes
/// </summary>
[GenWiseAttribute(RelationID = "7c139d5e-a8a7-4b65-8516-e42468f86c51") ]
public virtual ContactosCliente ContactosCliente 
{
get
{
if ( _contactosCliente == null || _contactosCliente == null ) 
{
if ( String.IsNullOrEmpty(_nitCliente) || _nitCliente.Equals(string.Empty) || String.IsNullOrEmpty(_codContacto) || _codContacto.Equals(string.Empty) ) 
{
if ( _contactosCliente != null && ( _contactosCliente.NitCliente.Equals(string.Empty) || _contactosCliente.CodContacto.Equals(null) ) )
{
  _contactosCliente = null;
}
}
else
{
  _contactosCliente = (new ContactosClienteFactory()).Fetch(_nitCliente,_codContacto);
}
}

return _contactosCliente;
}
    set
    {
        try
        {
            if (_contactosCliente != value)
            {
                if (value == null) _nitCliente = string.Empty; else _nitCliente = (System.String)value.NitCliente;
                if (value == null) _codContacto = null; else _codContacto = (System.String)value.CodContacto;
                _contactosCliente = value;
            }
        }catch (Exception){}
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

if ( NitCliente != null ) _retValue += NitCliente.ToString();

_retValue += "^";
if ( CodSucursal != null ) _retValue += CodSucursal.ToString();

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
/// Create a new SucursalCliente object. 
/// </summary>
public  SucursalCliente()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  SucursalCliente(System.String pNitCliente , System.String pCodSucursal)
{
_nitCliente = pNitCliente ;
_codSucursal = pCodSucursal ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
if ( NitCliente != null ) _hash += NitCliente.ToString();
if ( CodSucursal != null ) _hash += CodSucursal.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
SucursalCliente _newSucursalCliente = (pObject as SucursalCliente); 
if (_newSucursalCliente == null ) return false; 
if (_newSucursalCliente.GetHashCode() == this.GetHashCode() ) return true; 
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
Error _error;
// Call Validator IsRequired for Column : nitCliente(Type:Required Field Validator)
_error = this.ValidatenitClienteIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : codSucursal(Type:Required Field Validator)
_error = this.ValidatecodSucursalIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(NitCliente) ) 
{
   _errors.Add( new Error( "The PK Column (nitCliente) can not be null!. " ) );
}
if ( String.IsNullOrEmpty(CodSucursal) ) 
{
   _errors.Add( new Error( "The PK Column (codSucursal) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : nitCliente
/// </remarks>
public virtual Error ValidatenitClienteIsRequired()
{
if ( String.IsNullOrEmpty(NitCliente) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "nitCliente is required and therefore must have a value." ;
 return _error;
}
 return null;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codSucursal
/// </remarks>
public virtual Error ValidatecodSucursalIsRequired()
{
if ( String.IsNullOrEmpty(CodSucursal) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codSucursal is required and therefore must have a value." ;
 return _error;
}
 return null;
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

