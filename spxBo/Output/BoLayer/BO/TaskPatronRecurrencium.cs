using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class TaskPatronRecurrencium : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.Int32 _codTarea;
private System.Int32 _codPatron;
private System.Boolean? _diaria;
private System.Boolean? _diariaCada;
private System.Int32? _diariaCadaDias;
private System.Boolean? _diariaSemanal;
private System.Boolean? _semanal;
private System.Boolean? _semLunes;
private System.Boolean? _semMartes;
private System.Boolean? _semMiercoles;
private System.Boolean? _semJueves;
private System.Boolean? _semViernes;
private System.Boolean? _semSabado;
private System.Boolean? _semDomingo;
private System.Boolean? _mensual;
private System.Boolean? _menElDia;
private System.Int32? _menEldiaDia;
private System.Int32? _menEldiaCada;
private System.Boolean? _menEl;
private System.String _menElOrdenDia;
private System.String _menElNombreDia;
private System.Int32? _menElCada;
private System.Boolean? _anual;
private System.Boolean? _anuCada;
private System.String _anuCadaMes;
private System.String _anuCadaDia;
private System.Boolean? _anuEl;
private System.String _anuElOrden;
private System.String _anuElDia;
private System.String _anuElMes;
private System.DateTime? _inicia;
private System.Boolean? _sinFechaFin;
private System.Boolean? _finalizaDespues;
private System.Int32? _finalizaOcurrencias;
private System.Boolean? _finalizaElDia;
private System.DateTime? _finalizaDia;
private System.DateTime? _ultimoAviso;
private Task _task;

#endregion


#region --- Class Properties ---

public virtual System.Int32 CodTarea 
{
get
{
return _codTarea;
}
set 
{
if ( _codTarea != value) 
{
_codTarea = value ;
OnPropertyChanged("CodTarea");
}
}
}

public virtual System.Int32 CodPatron 
{
get
{
return _codPatron;
}
set 
{
if ( _codPatron != value) 
{
_codPatron = value ;
OnPropertyChanged("CodPatron");
}
}
}

public virtual System.Boolean? Diaria 
{
get
{
return _diaria;
}
set 
{
if ( _diaria != value) 
{
_diaria = value ;
OnPropertyChanged("Diaria");
}
}
}

public virtual System.Boolean? DiariaCada 
{
get
{
return _diariaCada;
}
set 
{
if ( _diariaCada != value) 
{
_diariaCada = value ;
OnPropertyChanged("DiariaCada");
}
}
}

public virtual System.Int32? DiariaCadaDias 
{
get
{
return _diariaCadaDias;
}
set 
{
if ( _diariaCadaDias != value) 
{
_diariaCadaDias = value ;
OnPropertyChanged("DiariaCadaDias");
}
}
}

public virtual System.Boolean? DiariaSemanal 
{
get
{
return _diariaSemanal;
}
set 
{
if ( _diariaSemanal != value) 
{
_diariaSemanal = value ;
OnPropertyChanged("DiariaSemanal");
}
}
}

public virtual System.Boolean? Semanal 
{
get
{
return _semanal;
}
set 
{
if ( _semanal != value) 
{
_semanal = value ;
OnPropertyChanged("Semanal");
}
}
}

public virtual System.Boolean? SemLunes 
{
get
{
return _semLunes;
}
set 
{
if ( _semLunes != value) 
{
_semLunes = value ;
OnPropertyChanged("SemLunes");
}
}
}

public virtual System.Boolean? SemMartes 
{
get
{
return _semMartes;
}
set 
{
if ( _semMartes != value) 
{
_semMartes = value ;
OnPropertyChanged("SemMartes");
}
}
}

public virtual System.Boolean? SemMiercoles 
{
get
{
return _semMiercoles;
}
set 
{
if ( _semMiercoles != value) 
{
_semMiercoles = value ;
OnPropertyChanged("SemMiercoles");
}
}
}

public virtual System.Boolean? SemJueves 
{
get
{
return _semJueves;
}
set 
{
if ( _semJueves != value) 
{
_semJueves = value ;
OnPropertyChanged("SemJueves");
}
}
}

public virtual System.Boolean? SemViernes 
{
get
{
return _semViernes;
}
set 
{
if ( _semViernes != value) 
{
_semViernes = value ;
OnPropertyChanged("SemViernes");
}
}
}

public virtual System.Boolean? SemSabado 
{
get
{
return _semSabado;
}
set 
{
if ( _semSabado != value) 
{
_semSabado = value ;
OnPropertyChanged("SemSabado");
}
}
}

public virtual System.Boolean? SemDomingo 
{
get
{
return _semDomingo;
}
set 
{
if ( _semDomingo != value) 
{
_semDomingo = value ;
OnPropertyChanged("SemDomingo");
}
}
}

public virtual System.Boolean? Mensual 
{
get
{
return _mensual;
}
set 
{
if ( _mensual != value) 
{
_mensual = value ;
OnPropertyChanged("Mensual");
}
}
}

public virtual System.Boolean? MenElDia 
{
get
{
return _menElDia;
}
set 
{
if ( _menElDia != value) 
{
_menElDia = value ;
OnPropertyChanged("MenElDia");
}
}
}

public virtual System.Int32? MenEldiaDia 
{
get
{
return _menEldiaDia;
}
set 
{
if ( _menEldiaDia != value) 
{
_menEldiaDia = value ;
OnPropertyChanged("MenEldiaDia");
}
}
}

public virtual System.Int32? MenEldiaCada 
{
get
{
return _menEldiaCada;
}
set 
{
if ( _menEldiaCada != value) 
{
_menEldiaCada = value ;
OnPropertyChanged("MenEldiaCada");
}
}
}

public virtual System.Boolean? MenEl 
{
get
{
return _menEl;
}
set 
{
if ( _menEl != value) 
{
_menEl = value ;
OnPropertyChanged("MenEl");
}
}
}

public virtual System.String MenElOrdenDia 
{
get
{
return _menElOrdenDia;
}
set 
{
if ( _menElOrdenDia != value) 
{
_menElOrdenDia = value ;
OnPropertyChanged("MenElOrdenDia");
}
}
}

public virtual System.String MenElNombreDia 
{
get
{
return _menElNombreDia;
}
set 
{
if ( _menElNombreDia != value) 
{
_menElNombreDia = value ;
OnPropertyChanged("MenElNombreDia");
}
}
}

public virtual System.Int32? MenElCada 
{
get
{
return _menElCada;
}
set 
{
if ( _menElCada != value) 
{
_menElCada = value ;
OnPropertyChanged("MenElCada");
}
}
}

public virtual System.Boolean? Anual 
{
get
{
return _anual;
}
set 
{
if ( _anual != value) 
{
_anual = value ;
OnPropertyChanged("Anual");
}
}
}

public virtual System.Boolean? AnuCada 
{
get
{
return _anuCada;
}
set 
{
if ( _anuCada != value) 
{
_anuCada = value ;
OnPropertyChanged("AnuCada");
}
}
}

public virtual System.String AnuCadaMes 
{
get
{
return _anuCadaMes;
}
set 
{
if ( _anuCadaMes != value) 
{
_anuCadaMes = value ;
OnPropertyChanged("AnuCadaMes");
}
}
}

public virtual System.String AnuCadaDia 
{
get
{
return _anuCadaDia;
}
set 
{
if ( _anuCadaDia != value) 
{
_anuCadaDia = value ;
OnPropertyChanged("AnuCadaDia");
}
}
}

public virtual System.Boolean? AnuEl 
{
get
{
return _anuEl;
}
set 
{
if ( _anuEl != value) 
{
_anuEl = value ;
OnPropertyChanged("AnuEl");
}
}
}

public virtual System.String AnuElOrden 
{
get
{
return _anuElOrden;
}
set 
{
if ( _anuElOrden != value) 
{
_anuElOrden = value ;
OnPropertyChanged("AnuElOrden");
}
}
}

public virtual System.String AnuElDia 
{
get
{
return _anuElDia;
}
set 
{
if ( _anuElDia != value) 
{
_anuElDia = value ;
OnPropertyChanged("AnuElDia");
}
}
}

public virtual System.String AnuElMes 
{
get
{
return _anuElMes;
}
set 
{
if ( _anuElMes != value) 
{
_anuElMes = value ;
OnPropertyChanged("AnuElMes");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String Inicia_Date 
{
get
{
if (  !Inicia.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( Inicia.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return Inicia.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(Inicia_Time)) {

Inicia = null;
}
 else
{
 Inicia = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + Inicia.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(Inicia_Time)) 
{
 Inicia = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 Inicia = Convert.ToDateTime( " " + value + " " + Inicia.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String Inicia_Time 
{
get
{
if (  !Inicia.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( Inicia.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return Inicia.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(Inicia_Date)) 
{
Inicia = null;
}
 else
{
 Inicia = Convert.ToDateTime( " " + Inicia.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(Inicia_Date)) 
{
 Inicia = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 Inicia = Convert.ToDateTime( " " + Inicia_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? Inicia 
{
get
{
return _inicia;
}
set 
{
if ( _inicia != value) 
{
_inicia = value ;
OnPropertyChanged("Inicia");
}
}
}

public virtual System.Boolean? SinFechaFin 
{
get
{
return _sinFechaFin;
}
set 
{
if ( _sinFechaFin != value) 
{
_sinFechaFin = value ;
OnPropertyChanged("SinFechaFin");
}
}
}

public virtual System.Boolean? FinalizaDespues 
{
get
{
return _finalizaDespues;
}
set 
{
if ( _finalizaDespues != value) 
{
_finalizaDespues = value ;
OnPropertyChanged("FinalizaDespues");
}
}
}

public virtual System.Int32? FinalizaOcurrencias 
{
get
{
return _finalizaOcurrencias;
}
set 
{
if ( _finalizaOcurrencias != value) 
{
_finalizaOcurrencias = value ;
OnPropertyChanged("FinalizaOcurrencias");
}
}
}

public virtual System.Boolean? FinalizaElDia 
{
get
{
return _finalizaElDia;
}
set 
{
if ( _finalizaElDia != value) 
{
_finalizaElDia = value ;
OnPropertyChanged("FinalizaElDia");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String FinalizaDia_Date 
{
get
{
if (  !FinalizaDia.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FinalizaDia.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return FinalizaDia.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FinalizaDia_Time)) {

FinalizaDia = null;
}
 else
{
 FinalizaDia = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + FinalizaDia.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FinalizaDia_Time)) 
{
 FinalizaDia = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 FinalizaDia = Convert.ToDateTime( " " + value + " " + FinalizaDia.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String FinalizaDia_Time 
{
get
{
if (  !FinalizaDia.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( FinalizaDia.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return FinalizaDia.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(FinalizaDia_Date)) 
{
FinalizaDia = null;
}
 else
{
 FinalizaDia = Convert.ToDateTime( " " + FinalizaDia.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(FinalizaDia_Date)) 
{
 FinalizaDia = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 FinalizaDia = Convert.ToDateTime( " " + FinalizaDia_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? FinalizaDia 
{
get
{
return _finalizaDia;
}
set 
{
if ( _finalizaDia != value) 
{
_finalizaDia = value ;
OnPropertyChanged("FinalizaDia");
}
}
}

/// <summary>
/// This property contains a calculated, bindable value of the DATE part of a DateTime property. If you want to only work with the DATE and ignore the underlying TIME component then you could use this property.
/// </summary>
/// <remarks>
/// Auto-Generated Property
/// </remarks>
public virtual System.String UltimoAviso_Date 
{
get
{
if (  !UltimoAviso.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( UltimoAviso.Value.ToShortDateString() == System.DateTime.MinValue.ToShortDateString() ) 
 return String.Empty;
else  
 return UltimoAviso.Value.ToShortDateString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(UltimoAviso_Time)) {

UltimoAviso = null;
}
 else
{
 UltimoAviso = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + UltimoAviso.Value.ToString("HH:mm:ss.fff") ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(UltimoAviso_Time)) 
{
 UltimoAviso = Convert.ToDateTime( " " + value + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
 else
{
 UltimoAviso = Convert.ToDateTime( " " + value + " " + UltimoAviso.Value.ToString("HH:mm:ss.fff") ) ;
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
public virtual System.String UltimoAviso_Time 
{
get
{
if (  !UltimoAviso.HasValue ) 
{ 
 return String.Empty;
} 
else 
{ 
if ( UltimoAviso.Value.ToShortTimeString() == System.DateTime.MinValue.ToShortTimeString() ) 
 return String.Empty;
else  
 return UltimoAviso.Value.ToShortTimeString();
} 

}
set 
{
if ( string.IsNullOrEmpty( value ) )  
{
 if (string.IsNullOrEmpty(UltimoAviso_Date)) 
{
UltimoAviso = null;
}
 else
{
 UltimoAviso = Convert.ToDateTime( " " + UltimoAviso.Value.ToShortDateString() + " " + System.DateTime.MinValue.ToLongTimeString() ) ;
}
}
 else
{
 if (string.IsNullOrEmpty(UltimoAviso_Date)) 
{
 UltimoAviso = Convert.ToDateTime( " " + System.DateTime.MinValue.ToShortDateString() + " " + value ) ;
}
 else
{
 UltimoAviso = Convert.ToDateTime( " " + UltimoAviso_Date + " " + value ) ;
}
}

}
}

public virtual System.DateTime? UltimoAviso 
{
get
{
return _ultimoAviso;
}
set 
{
if ( _ultimoAviso != value) 
{
_ultimoAviso = value ;
OnPropertyChanged("UltimoAviso");
}
}
}

/// <summary>
/// Generated from Relation FK_taskPatronRecurrencia_task
/// </summary>
[GenWiseAttribute(RelationID = "035902d4-5e41-4bbc-9e70-93a954536dc3") ]
public virtual Task Task 
{
get
{
if ( _task == null ) 
{
if (  _codTarea.Equals(0)  || _codTarea.Equals(System.Int32.MinValue) ) 
{
if ( _task != null && ( _task.CodTarea.Equals(System.Int32.MinValue) ) )
{
  _task = null;
}
}
else
{
_task = (new TaskFactory()).Get(_codTarea);
}
}

return _task;
}
set 
{
if ( _task != value) 
{
if ( value==null ) _codTarea = System.Int32.MinValue; else _codTarea = (System.Int32)value.CodTarea; 
_task = value ;
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

_retValue += CodTarea.ToString();

_retValue += "^";
_retValue += CodPatron.ToString();

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
/// Create a new TaskPatronRecurrencium object. 
/// </summary>
public  TaskPatronRecurrencium()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  TaskPatronRecurrencium(System.Int32 pCodTarea , System.Int32 pCodPatron)
{
_codTarea = pCodTarea ;
_codPatron = pCodPatron ;

}

public override int GetHashCode()
{
string _hash = String.Empty; 
_hash += CodTarea.ToString();
_hash += CodPatron.ToString();
return _hash.GetHashCode(); 

}

public override bool Equals(object pObject)
{
TaskPatronRecurrencium _newTaskPatronRecurrencium = (pObject as TaskPatronRecurrencium); 
if (_newTaskPatronRecurrencium == null ) return false; 
if (_newTaskPatronRecurrencium.GetHashCode() == this.GetHashCode() ) return true; 
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
if (  CodTarea.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codTarea) can not be null!. " ) );
}
if (  CodPatron.Equals(0)  ) 
{
   _errors.Add( new Error( "The PK Column (codPatron) can not be null!. " ) );
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

