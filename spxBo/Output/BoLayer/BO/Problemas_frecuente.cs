using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class Problemas_frecuente : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _cod_problema_frecuente;
private System.String _codFabricante;
private System.String _codModelo;
private System.String _cod_manual;
private System.String _nombre_problema;
private System.String _descripcion;
private IList<Soluciones_problema> _soluciones_problemas;
private Modelo _modelo;

#endregion


#region --- Class Properties ---

public virtual System.Int32 Cod_problema_frecuente 
{
get
{
return _cod_problema_frecuente;
}
}

public virtual System.String CodFabricante 
{
get
{
if ( Modelo != null ) 
{
_codFabricante = (System.String)Modelo.CodFabricante;
}

return _codFabricante;
}
set 
{
if ( _codFabricante != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_modelo = null;

_codFabricante = value ;
OnPropertyChanged("CodFabricante");
}
}
}

public virtual System.String CodModelo 
{
get
{
if ( Modelo != null ) 
{
_codModelo = (System.String)Modelo.CodModelo;
}

return _codModelo;
}
set 
{
if ( _codModelo != value) 
{
// Simplified Parent Access Property : reset object reference if simple property changes it's value
_modelo = null;

_codModelo = value ;
OnPropertyChanged("CodModelo");
}
}
}

public virtual System.String Cod_manual 
{
get
{
return _cod_manual;
}
set 
{
if ( _cod_manual != value) 
{
_cod_manual = value ;
OnPropertyChanged("Cod_manual");
}
}
}

public virtual System.String Nombre_problema 
{
get
{
return _nombre_problema;
}
set 
{
if ( _nombre_problema != value) 
{
_nombre_problema = value ;
OnPropertyChanged("Nombre_problema");
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
/// Collection of Soluciones_problema.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "5d80e91a-d7e5-400e-9ffd-76230f023e57" , CollectionOfType = typeof(Soluciones_problema)) ]
public virtual IList<Soluciones_problema> Soluciones_problemas 
{
get
{
 if (_soluciones_problemas == null) _soluciones_problemas = new List<Soluciones_problema>();

return _soluciones_problemas;
}
set 
{
if ( _soluciones_problemas != value) 
{
_soluciones_problemas = value ;
}
}
}

/// <summary>
/// Generated from Relation FK_problemas_frecuentes_Modelos
/// </summary>
[GenWiseAttribute(RelationID = "bfc11fb8-65dd-4f30-9eae-0fde9b2b83df") ]
public virtual Modelo Modelo 
{
get
{
if ( _modelo == null || _modelo == null ) 
{
if ( String.IsNullOrEmpty(_codFabricante) || _codFabricante.Equals(string.Empty) || String.IsNullOrEmpty(_codModelo) || _codModelo.Equals(string.Empty) ) 
{
if ( _modelo != null && ( _modelo.CodFabricante.Equals(null) || _modelo.CodModelo.Equals(null) ) )
{
  _modelo = null;
}
}
else
{
  _modelo = (new ModeloFactory()).Fetch(_codFabricante,_codModelo);
}
}

return _modelo;
}
set 
{
if ( _modelo != value) 
{
if ( value==null ) _codFabricante = null; else _codFabricante = (System.String)value.CodFabricante; 
if ( value==null ) _codModelo = null; else _codModelo = (System.String)value.CodModelo; 
_modelo = value ;
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
/// Create a new Problemas_frecuente object. 
/// </summary>
public  Problemas_frecuente()
{
_cod_problema_frecuente = System.Int32.MinValue;

}

/// <summary>
/// Add a new Soluciones_problema object and automatically associate it with this instance as it's parent. This method makes easier to add new children and ensures you do not forget to related them correctly.
/// </summary>
///<param name="pSoluciones_problema">An Soluciones_problema object to be added to this objects collection.</param>
public virtual void AddSoluciones_problema(Soluciones_problema pSoluciones_problema)
{
if( pSoluciones_problema == null  ) throw new ArgumentNullException("pSoluciones_problema");
// Set the Parent Property
pSoluciones_problema.Problemas_frecuente = this;
if (!pSoluciones_problema.IsValid) { throw new Exception("pSoluciones_problema failed on the Validate() method." + Error.ErrorsToString( pSoluciones_problema.Validate() ) ); }
Soluciones_problemas.Add(pSoluciones_problema);
}

/// <summary>
/// Delete an existing Soluciones_problema object + remove the association it with this instance as it's parent. This method makes easier to add new children and ensures you do not forget to related them correctly.
/// </summary>
///<param name="pSoluciones_problema">The Soluciones_problema object to be removed from this objects collection.</param>
public virtual void DeleteSoluciones_problemas(Soluciones_problema pSoluciones_problema)
{
if( pSoluciones_problema == null  ) throw new ArgumentNullException("pSoluciones_problema");
Soluciones_problemas.Remove(pSoluciones_problema);
// Remove the Association with the Parent object
pSoluciones_problema.Problemas_frecuente = null;
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

