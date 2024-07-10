using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class Modelo : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _codFabricante;
private System.String _codModelo;
private System.String _nombreModelo;
private System.String _descripcion;
private System.String _nombreManual;
private System.String _codTipoEquipo;
private System.String _codSubTipoEquipo;
private System.String _voltaje;
private System.String _watios;
private System.String _amperios;
private System.String _frecuencia;
private System.Double? _duracionMantenimiento;
private System.Int32? _diasxMantenimiento;
private System.Int32? _mesesxMantenimiento;
private System.Decimal? _pesoEstimado;
private System.Int32? _codUnidadPeso;
private IList<AccesoriosEquipo> _accesoriosEquipos;
private IList<ActividadesxModelo> _actividadesxModelos;
private IList<ArchivosxModelo> _archivosxModelos;
private IList<Equipo> _equipos;
private IList<Problemas_frecuente> _problemas_frecuentes;
private Fabricante _fabricante;
private SubTipoEquipo _subTipoEquipo;

#endregion


#region --- Class Properties ---

public virtual System.String CodFabricante 
{
get
{
return _codFabricante;
}
set 
{
if ( _codFabricante != value) 
{
_codFabricante = value ;
OnPropertyChanged("CodFabricante");
}
}
}

public virtual System.String CodModelo 
{
get
{
return _codModelo;
}
set 
{
if ( _codModelo != value) 
{
_codModelo = value ;
OnPropertyChanged("CodModelo");
}
}
}

public virtual System.String NombreModelo 
{
get
{
return _nombreModelo;
}
set 
{
if ( _nombreModelo != value) 
{
_nombreModelo = value ;
OnPropertyChanged("NombreModelo");
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

public virtual System.String NombreManual 
{
get
{
return _nombreManual;
}
set 
{
if ( _nombreManual != value) 
{
_nombreManual = value ;
OnPropertyChanged("NombreManual");
}
}
}

public virtual System.String CodTipoEquipo 
{
get
{
if ( SubTipoEquipo != null ) 
{
_codTipoEquipo = (System.String)SubTipoEquipo.CodTipoEquipo;
}

return _codTipoEquipo;
}
set 
{
if ( _codTipoEquipo != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_subTipoEquipo = null;

_codTipoEquipo = value ;
OnPropertyChanged("CodTipoEquipo");
}
}
}

public virtual System.String CodSubTipoEquipo 
{
get
{
if ( SubTipoEquipo != null ) 
{
_codSubTipoEquipo = (System.String)SubTipoEquipo.CodSubtipoEquipo;
}

return _codSubTipoEquipo;
}
set 
{
if ( _codSubTipoEquipo != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_subTipoEquipo = null;

_codSubTipoEquipo = value ;
OnPropertyChanged("CodSubTipoEquipo");
}
}
}

public virtual System.String Voltaje 
{
get
{
return _voltaje;
}
set 
{
if ( _voltaje != value) 
{
_voltaje = value ;
OnPropertyChanged("Voltaje");
}
}
}

public virtual System.String Watios 
{
get
{
return _watios;
}
set 
{
if ( _watios != value) 
{
_watios = value ;
OnPropertyChanged("Watios");
}
}
}

public virtual System.String Amperios 
{
get
{
return _amperios;
}
set 
{
if ( _amperios != value) 
{
_amperios = value ;
OnPropertyChanged("Amperios");
}
}
}

public virtual System.String Frecuencia 
{
get
{
return _frecuencia;
}
set 
{
if ( _frecuencia != value) 
{
_frecuencia = value ;
OnPropertyChanged("Frecuencia");
}
}
}

public virtual System.Double? DuracionMantenimiento 
{
get
{
return _duracionMantenimiento;
}
set 
{
if ( _duracionMantenimiento != value) 
{
_duracionMantenimiento = value ;
OnPropertyChanged("DuracionMantenimiento");
}
}
}

public virtual System.Int32? DiasxMantenimiento 
{
get
{
return _diasxMantenimiento;
}
set 
{
if ( _diasxMantenimiento != value) 
{
_diasxMantenimiento = value ;
OnPropertyChanged("DiasxMantenimiento");
}
}
}

public virtual System.Int32? MesesxMantenimiento 
{
get
{
return _mesesxMantenimiento;
}
set 
{
if ( _mesesxMantenimiento != value) 
{
_mesesxMantenimiento = value ;
OnPropertyChanged("MesesxMantenimiento");
}
}
}

public virtual System.Decimal? PesoEstimado 
{
get
{
return _pesoEstimado;
}
set 
{
if ( _pesoEstimado != value) 
{
_pesoEstimado = value ;
OnPropertyChanged("PesoEstimado");
}
}
}

public virtual System.Int32? CodUnidadPeso 
{
get
{
return _codUnidadPeso;
}
set 
{
if ( _codUnidadPeso != value) 
{
_codUnidadPeso = value ;
OnPropertyChanged("CodUnidadPeso");
}
}
}

/// <summary>
/// Collection of AccesoriosEquipo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "c0d81b65-ca76-4621-b72f-144b46db593f" , CollectionOfType = typeof(AccesoriosEquipo)) ]
public virtual IList<AccesoriosEquipo> AccesoriosEquipos 
{
get
{
 if (_accesoriosEquipos == null) _accesoriosEquipos = new List<AccesoriosEquipo>();

return _accesoriosEquipos;
}
set 
{
if ( _accesoriosEquipos != value) 
{
_accesoriosEquipos = value ;
}
}
}

/// <summary>
/// Collection of ActividadesxModelo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "25b4663a-6cd4-4430-a33f-e9b5b78de125" , CollectionOfType = typeof(ActividadesxModelo)) ]
public virtual IList<ActividadesxModelo> ActividadesxModelos 
{
get
{
 if (_actividadesxModelos == null) _actividadesxModelos = new List<ActividadesxModelo>();

return _actividadesxModelos;
}
set 
{
if ( _actividadesxModelos != value) 
{
_actividadesxModelos = value ;
}
}
}

/// <summary>
/// Collection of ArchivosxModelo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "92bfdc30-221d-473b-9f8a-b344293842cb" , CollectionOfType = typeof(ArchivosxModelo)) ]
public virtual IList<ArchivosxModelo> ArchivosxModelos 
{
get
{
 if (_archivosxModelos == null) _archivosxModelos = new List<ArchivosxModelo>();

return _archivosxModelos;
}
set 
{
if ( _archivosxModelos != value) 
{
_archivosxModelos = value ;
}
}
}

/// <summary>
/// Collection of Equipo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "88450922-80a7-490e-aabd-e64cd3ac89a5" , CollectionOfType = typeof(Equipo)) ]
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
/// Collection of Problemas_frecuente.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "bfc11fb8-65dd-4f30-9eae-0fde9b2b83df" , CollectionOfType = typeof(Problemas_frecuente)) ]
public virtual IList<Problemas_frecuente> Problemas_frecuentes 
{
get
{
 if (_problemas_frecuentes == null) _problemas_frecuentes = new List<Problemas_frecuente>();

return _problemas_frecuentes;
}
set 
{
if ( _problemas_frecuentes != value) 
{
_problemas_frecuentes = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_Modelos_fabricante
/// </summary>
[GenWiseAttribute(RelationID = "d5aae68d-0f2f-4009-9f72-f4a6f472b525") ]
public virtual Fabricante Fabricante 
{
get
{
if ( _fabricante == null ) 
{
if ( String.IsNullOrEmpty(_codFabricante) || _codFabricante.Equals(string.Empty) ) 
{
if ( _fabricante != null && ( _fabricante.CodFabricante.Equals(string.Empty) ) )
{
  _fabricante = null;
}
}
else
{
_fabricante = (new FabricanteFactory()).Get(_codFabricante);
}
}

return _fabricante;
}
set 
{
if ( _fabricante != value) 
{
if ( value==null ) _codFabricante = string.Empty; else _codFabricante = (System.String)value.CodFabricante; 
_fabricante = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_Modelos_subTipoEquipo
/// </summary>
[GenWiseAttribute(RelationID = "876378f9-e2f3-4827-9cf7-6f61254d14c8") ]
public virtual SubTipoEquipo SubTipoEquipo 
{
get
{
if ( _subTipoEquipo == null || _subTipoEquipo == null ) 
{
if ( String.IsNullOrEmpty(_codTipoEquipo) || _codTipoEquipo.Equals(string.Empty) || String.IsNullOrEmpty(_codSubTipoEquipo) || _codSubTipoEquipo.Equals(string.Empty) ) 
{
if ( _subTipoEquipo != null && ( _subTipoEquipo.CodTipoEquipo.Equals(null) || _subTipoEquipo.CodSubtipoEquipo.Equals(null) ) )
{
  _subTipoEquipo = null;
}
}
else
{
  _subTipoEquipo = (new SubTipoEquipoFactory()).Fetch(_codTipoEquipo,_codSubTipoEquipo);
}
}

return _subTipoEquipo;
}
    set
    {
        try
        {
            if (_subTipoEquipo != value)
            {
                if (value == null) _codTipoEquipo = null; else _codTipoEquipo = (System.String)value.CodTipoEquipo;
                if (value == null) _codSubTipoEquipo = null; else _codSubTipoEquipo = (System.String)value.CodSubtipoEquipo;
                _subTipoEquipo = value;
            }
        }
        catch (Exception) { }
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

if ( CodFabricante != null ) _retValue += CodFabricante.ToString();

_retValue += "^";
if ( CodModelo != null ) _retValue += CodModelo.ToString();

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
/// Create a new Modelo object. 
/// </summary>
public  Modelo()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  Modelo(System.String pCodFabricante , System.String pCodModelo)
{
_codFabricante = pCodFabricante ;
_codModelo = pCodModelo ;

}

/// <summary>
/// Add a new Problemas_frecuente object and automatically associate it with this instance as it's parent. This method makes easier to add new children and ensures you do not forget to related them correctly.
/// </summary>
///<param name="pProblemas_frecuente">An Problemas_frecuente object to be added to this objects collection.</param>
public virtual void AddProblemas_frecuente(Problemas_frecuente pProblemas_frecuente)
{
if( pProblemas_frecuente == null  ) throw new ArgumentNullException("pProblemas_frecuente");
// Set the Parent Property
pProblemas_frecuente.Modelo = this;
if (!pProblemas_frecuente.IsValid) { throw new Exception("pProblemas_frecuente failed on the Validate() method." + Error.ErrorsToString( pProblemas_frecuente.Validate() ) ); }
Problemas_frecuentes.Add(pProblemas_frecuente);
}

/// <summary>
/// Delete an existing Problemas_frecuente object + remove the association it with this instance as it's parent. This method makes easier to add new children and ensures you do not forget to related them correctly.
/// </summary>
///<param name="pProblemas_frecuente">The Problemas_frecuente object to be removed from this objects collection.</param>
public virtual void DeleteProblemas_frecuentes(Problemas_frecuente pProblemas_frecuente)
{
if( pProblemas_frecuente == null  ) throw new ArgumentNullException("pProblemas_frecuente");
Problemas_frecuentes.Remove(pProblemas_frecuente);
// Remove the Association with the Parent object
pProblemas_frecuente.Modelo = null;
}

public override int GetHashCode()
{
string _hash = String.Empty; 
if ( CodFabricante != null ) _hash += CodFabricante.ToString();
if ( CodModelo != null ) _hash += CodModelo.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
Modelo _newModelo = (pObject as Modelo); 
if (_newModelo == null ) return false; 
if (_newModelo.GetHashCode() == this.GetHashCode() ) return true; 
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
// Call Validator IsRequired for Column : codFabricante(Type:Required Field Validator)
_error = this.ValidatecodFabricanteIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : codModelo(Type:Required Field Validator)
_error = this.ValidatecodModeloIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }

// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(CodFabricante) ) 
{
   _errors.Add( new Error( "The PK Column (codFabricante) can not be null!. " ) );
}
if ( String.IsNullOrEmpty(CodModelo) ) 
{
   _errors.Add( new Error( "The PK Column (codModelo) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codFabricante
/// </remarks>
public virtual Error ValidatecodFabricanteIsRequired()
{
if ( String.IsNullOrEmpty(CodFabricante) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codFabricante is required and therefore must have a value." ;
 return _error;
}
 return null;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : codModelo
/// </remarks>
public virtual Error ValidatecodModeloIsRequired()
{
if ( String.IsNullOrEmpty(CodModelo) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "codModelo is required and therefore must have a value." ;
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

