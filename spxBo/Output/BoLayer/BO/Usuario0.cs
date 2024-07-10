using System; 
using System.Collections.Generic; 
using System.ComponentModel; 

namespace BOLayer{
[Serializable]
[GenWiseAttribute(IsDataSourceEntity = true) ]
public partial class Usuario0 : Validation.IValidatable ,  INotifyPropertyChanged
 {


#region --- Class Fields / Objects  ---

[NonSerialized]
protected PropertyChangedEventHandler _propertyChanged;
private System.String _login;
private System.String _nombre;
private System.String _password;
private System.Boolean? _esBloqueado;
private System.Boolean? _esDeshabilitado;
private System.String _correo;
private IList<ActividadxordenServicio> _actividadxordenServicios;
private IList<EntradaSalidaEquipo> _entradaSalidaEquipos;
private IList<EntradaSalidaEquipo> _entradaSalidaEquipos1;
private IList<GruposModulosxUsuario> _gruposModulosxUsuarios;
private IList<GruposUsuariosxUsuario> _gruposUsuariosxUsuarios;
private IList<IndicacionesLLamada> _indicacionesLLamadas;
private IList<LlamadaSoporte> _llamadaSoportes;
private IList<LlamadaSoporte> _llamadaSoportes1;
private IList<LlamadaSoporte> _llamadaSoportes2;
private IList<LogCambioUbicacione> _logCambioUbicaciones;
private IList<ModulosxUsuario> _modulosxUsuarios;
private IList<ObservacionesxOrdenPrestamo> _observacionesxOrdenPrestamos;
private IList<OrdenPrestamo> _ordenPrestamos;
private IList<OrdenPrestamo> _ordenPrestamos1;
private IList<OrdenPrestamo> _ordenPrestamos2;
private IList<OrdenPrestamo> _ordenPrestamos3;
private IList<OrdenPrestamo> _ordenPrestamos4;
private IList<ProgramacionViaje> _programacionViajes;
private IList<ProgramacionViaje> _programacionViajes1;
private IList<Recoleccion> _recoleccions;
private IList<Recoleccion> _recoleccions1;
private IList<Recoleccion> _recoleccions2;
private IList<RegionesXusuario> _regionesXusuarios;
private IList<Seguimiento> _seguimientos;
private IList<Seguimiento> _seguimientos1;
private IList<SolicitudServicio> _solicitudServicios;
private IList<SolicitudServicio> _solicitudServicios1;
private IList<Task> _tasks;
private IList<Task> _tasks1;
private IList<UsuarioCopiaOcultaxSmtpAccion> _usuarioCopiaOcultaxSmtpAccions;
private IList<UsuarioCopiaxSmtpAccion> _usuarioCopiaxSmtpAccions;
private IList<UsuariosXusuario> _usuariosXusuarios;
private IList<UsuariosXusuario> _usuariosXusuarios1;
private IList<UsuarioxSmtpAccion> _usuarioxSmtpAccions;

#endregion


#region --- Class Properties ---

public virtual System.String Login 
{
get
{
return _login;
}
set 
{
if ( _login != value) 
{
_login = value ;
OnPropertyChanged("Login");
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

public virtual System.String Password 
{
get
{
return _password;
}
set 
{
if ( _password != value) 
{
_password = value ;
OnPropertyChanged("Password");
}
}
}

public virtual System.Boolean? EsBloqueado 
{
get
{
return _esBloqueado;
}
set 
{
if ( _esBloqueado != value) 
{
_esBloqueado = value ;
OnPropertyChanged("EsBloqueado");
}
}
}

public virtual System.Boolean? EsDeshabilitado 
{
get
{
return _esDeshabilitado;
}
set 
{
if ( _esDeshabilitado != value) 
{
_esDeshabilitado = value ;
OnPropertyChanged("EsDeshabilitado");
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



/// <summary>
/// Collection of ActividadxordenServicio.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "64623de3-1cb4-4852-be00-87ac3525ff02" , CollectionOfType = typeof(ActividadxordenServicio)) ]
public virtual IList<ActividadxordenServicio> ActividadxordenServicios 
{
get
{
 if (_actividadxordenServicios == null) _actividadxordenServicios = new List<ActividadxordenServicio>();

return _actividadxordenServicios;
}
set 
{
if ( _actividadxordenServicios != value) 
{
_actividadxordenServicios = value ;
}
}
}

/// <summary>
/// Collection of EntradaSalidaEquipo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "34918523-b4c2-4ac1-9c4b-c1401ec20a54" , CollectionOfType = typeof(EntradaSalidaEquipo)) ]
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
[GenWiseAttribute(RelationID = "19c008b9-4307-4e28-941a-4c63a5cb5b72" , CollectionOfType = typeof(EntradaSalidaEquipo)) ]
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
/// Collection of GruposModulosxUsuario.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "838fa8bf-e1cd-4d5b-a245-b370d7f2d0d9" , CollectionOfType = typeof(GruposModulosxUsuario)) ]
public virtual IList<GruposModulosxUsuario> GruposModulosxUsuarios 
{
get
{
 if (_gruposModulosxUsuarios == null) _gruposModulosxUsuarios = new List<GruposModulosxUsuario>();

return _gruposModulosxUsuarios;
}
set 
{
if ( _gruposModulosxUsuarios != value) 
{
_gruposModulosxUsuarios = value ;
}
}
}

/// <summary>
/// Collection of GruposUsuariosxUsuario.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "88f6d1ae-b753-4cc3-87d2-0e392f81b59c" , CollectionOfType = typeof(GruposUsuariosxUsuario)) ]
public virtual IList<GruposUsuariosxUsuario> GruposUsuariosxUsuarios 
{
get
{
 if (_gruposUsuariosxUsuarios == null) _gruposUsuariosxUsuarios = new List<GruposUsuariosxUsuario>();

return _gruposUsuariosxUsuarios;
}
set 
{
if ( _gruposUsuariosxUsuarios != value) 
{
_gruposUsuariosxUsuarios = value ;
}
}
}

/// <summary>
/// Collection of IndicacionesLLamada.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "46243392-62ec-425c-afaa-c730f8ec46ac" , CollectionOfType = typeof(IndicacionesLLamada)) ]
public virtual IList<IndicacionesLLamada> IndicacionesLLamadas 
{
get
{
 if (_indicacionesLLamadas == null) _indicacionesLLamadas = new List<IndicacionesLLamada>();

return _indicacionesLLamadas;
}
set 
{
if ( _indicacionesLLamadas != value) 
{
_indicacionesLLamadas = value ;
}
}
}

/// <summary>
/// Collection of LlamadaSoporte.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "640be00a-5b43-420d-b4ee-9540e2b222de" , CollectionOfType = typeof(LlamadaSoporte)) ]
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
/// Collection of LlamadaSoporte.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "6b9668c1-95a0-41d1-93ea-40fa4c6d705c" , CollectionOfType = typeof(LlamadaSoporte)) ]
public virtual IList<LlamadaSoporte> LlamadaSoportes1 
{
get
{
 if (_llamadaSoportes1 == null) _llamadaSoportes1 = new List<LlamadaSoporte>();

return _llamadaSoportes1;
}
set 
{
if ( _llamadaSoportes1 != value) 
{
_llamadaSoportes1 = value ;
}
}
}

/// <summary>
/// Collection of LlamadaSoporte.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "204a40ee-e34b-4c99-a015-f043b5a83602" , CollectionOfType = typeof(LlamadaSoporte)) ]
public virtual IList<LlamadaSoporte> LlamadaSoportes2 
{
get
{
 if (_llamadaSoportes2 == null) _llamadaSoportes2 = new List<LlamadaSoporte>();

return _llamadaSoportes2;
}
set 
{
if ( _llamadaSoportes2 != value) 
{
_llamadaSoportes2 = value ;
}
}
}

/// <summary>
/// Collection of LogCambioUbicacione.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "10f87264-0a37-401d-b5d1-31cefee72aaa" , CollectionOfType = typeof(LogCambioUbicacione)) ]
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
/// Collection of ModulosxUsuario.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "91ef65a2-98f5-49f6-b64c-1afa2dea07fe" , CollectionOfType = typeof(ModulosxUsuario)) ]
public virtual IList<ModulosxUsuario> ModulosxUsuarios 
{
get
{
 if (_modulosxUsuarios == null) _modulosxUsuarios = new List<ModulosxUsuario>();

return _modulosxUsuarios;
}
set 
{
if ( _modulosxUsuarios != value) 
{
_modulosxUsuarios = value ;
}
}
}

/// <summary>
/// Collection of ObservacionesxOrdenPrestamo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "53f6223a-f41b-4496-bfb4-54044fe5f9fb" , CollectionOfType = typeof(ObservacionesxOrdenPrestamo)) ]
public virtual IList<ObservacionesxOrdenPrestamo> ObservacionesxOrdenPrestamos 
{
get
{
 if (_observacionesxOrdenPrestamos == null) _observacionesxOrdenPrestamos = new List<ObservacionesxOrdenPrestamo>();

return _observacionesxOrdenPrestamos;
}
set 
{
if ( _observacionesxOrdenPrestamos != value) 
{
_observacionesxOrdenPrestamos = value ;
}
}
}

/// <summary>
/// Collection of OrdenPrestamo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "e557ad52-2e5b-413d-aebd-1308c4f92673" , CollectionOfType = typeof(OrdenPrestamo)) ]
public virtual IList<OrdenPrestamo> OrdenPrestamos 
{
get
{
 if (_ordenPrestamos == null) _ordenPrestamos = new List<OrdenPrestamo>();

return _ordenPrestamos;
}
set 
{
if ( _ordenPrestamos != value) 
{
_ordenPrestamos = value ;
}
}
}

/// <summary>
/// Collection of OrdenPrestamo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "ca92cf78-319b-418d-b98d-831a82914aa0" , CollectionOfType = typeof(OrdenPrestamo)) ]
public virtual IList<OrdenPrestamo> OrdenPrestamos1 
{
get
{
 if (_ordenPrestamos1 == null) _ordenPrestamos1 = new List<OrdenPrestamo>();

return _ordenPrestamos1;
}
set 
{
if ( _ordenPrestamos1 != value) 
{
_ordenPrestamos1 = value ;
}
}
}

/// <summary>
/// Collection of OrdenPrestamo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "589985d3-804e-41b2-a276-c0c45f1c109a" , CollectionOfType = typeof(OrdenPrestamo)) ]
public virtual IList<OrdenPrestamo> OrdenPrestamos2 
{
get
{
 if (_ordenPrestamos2 == null) _ordenPrestamos2 = new List<OrdenPrestamo>();

return _ordenPrestamos2;
}
set 
{
if ( _ordenPrestamos2 != value) 
{
_ordenPrestamos2 = value ;
}
}
}

/// <summary>
/// Collection of OrdenPrestamo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "9e2f20f2-e6b4-4df0-8611-b69dab4cc948" , CollectionOfType = typeof(OrdenPrestamo)) ]
public virtual IList<OrdenPrestamo> OrdenPrestamos3 
{
get
{
 if (_ordenPrestamos3 == null) _ordenPrestamos3 = new List<OrdenPrestamo>();

return _ordenPrestamos3;
}
set 
{
if ( _ordenPrestamos3 != value) 
{
_ordenPrestamos3 = value ;
}
}
}

/// <summary>
/// Collection of OrdenPrestamo.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "81b4e626-8193-495c-82c0-b137212587af" , CollectionOfType = typeof(OrdenPrestamo)) ]
public virtual IList<OrdenPrestamo> OrdenPrestamos4 
{
get
{
 if (_ordenPrestamos4 == null) _ordenPrestamos4 = new List<OrdenPrestamo>();

return _ordenPrestamos4;
}
set 
{
if ( _ordenPrestamos4 != value) 
{
_ordenPrestamos4 = value ;
}
}
}

/// <summary>
/// Collection of ProgramacionViaje.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "900cf5d5-b60e-4312-9854-793383a8a9d9" , CollectionOfType = typeof(ProgramacionViaje)) ]
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
/// Collection of ProgramacionViaje.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "6dbbdadf-b6bf-4cbc-8cc5-8f9745e44216" , CollectionOfType = typeof(ProgramacionViaje)) ]
public virtual IList<ProgramacionViaje> ProgramacionViajes1 
{
get
{
 if (_programacionViajes1 == null) _programacionViajes1 = new List<ProgramacionViaje>();

return _programacionViajes1;
}
set 
{
if ( _programacionViajes1 != value) 
{
_programacionViajes1 = value ;
}
}
}

/// <summary>
/// Collection of Recoleccion.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "6b9ea1fe-fa86-48a3-b907-eb488eaf69b8" , CollectionOfType = typeof(Recoleccion)) ]
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
/// Collection of Recoleccion.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "4d4bcc4b-d727-4a68-9beb-6a71aa5dd16e" , CollectionOfType = typeof(Recoleccion)) ]
public virtual IList<Recoleccion> Recoleccions1 
{
get
{
 if (_recoleccions1 == null) _recoleccions1 = new List<Recoleccion>();

return _recoleccions1;
}
set 
{
if ( _recoleccions1 != value) 
{
_recoleccions1 = value ;
}
}
}

/// <summary>
/// Collection of Recoleccion.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "24f9986b-8d6e-47cc-9ac8-df68419bc0ca" , CollectionOfType = typeof(Recoleccion)) ]
public virtual IList<Recoleccion> Recoleccions2 
{
get
{
 if (_recoleccions2 == null) _recoleccions2 = new List<Recoleccion>();

return _recoleccions2;
}
set 
{
if ( _recoleccions2 != value) 
{
_recoleccions2 = value ;
}
}
}

/// <summary>
/// Collection of RegionesXusuario.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "6475efd3-d793-4d68-872d-c74ab8d8d179" , CollectionOfType = typeof(RegionesXusuario)) ]
public virtual IList<RegionesXusuario> RegionesXusuarios 
{
get
{
 if (_regionesXusuarios == null) _regionesXusuarios = new List<RegionesXusuario>();

return _regionesXusuarios;
}
set 
{
if ( _regionesXusuarios != value) 
{
_regionesXusuarios = value ;
}
}
}

/// <summary>
/// Collection of Seguimiento.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "130f0fea-45cc-49ce-af02-c2c8900ca0f4" , CollectionOfType = typeof(Seguimiento)) ]
public virtual IList<Seguimiento> Seguimientos 
{
get
{
 if (_seguimientos == null) _seguimientos = new List<Seguimiento>();

return _seguimientos;
}
set 
{
if ( _seguimientos != value) 
{
_seguimientos = value ;
}
}
}

/// <summary>
/// Collection of Seguimiento.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "6a18160d-6d2c-46ce-adf2-698df0158833" , CollectionOfType = typeof(Seguimiento)) ]
public virtual IList<Seguimiento> Seguimientos1 
{
get
{
 if (_seguimientos1 == null) _seguimientos1 = new List<Seguimiento>();

return _seguimientos1;
}
set 
{
if ( _seguimientos1 != value) 
{
_seguimientos1 = value ;
}
}
}

/// <summary>
/// Collection of SolicitudServicio.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "a4554bdd-8e27-43b0-9a5a-05089a25b69c" , CollectionOfType = typeof(SolicitudServicio)) ]
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
/// Collection of SolicitudServicio.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "d01941a6-1c99-4d43-a3f2-ec556b9fe1ab" , CollectionOfType = typeof(SolicitudServicio)) ]
public virtual IList<SolicitudServicio> SolicitudServicios1 
{
get
{
 if (_solicitudServicios1 == null) _solicitudServicios1 = new List<SolicitudServicio>();

return _solicitudServicios1;
}
set 
{
if ( _solicitudServicios1 != value) 
{
_solicitudServicios1 = value ;
}
}
}

/// <summary>
/// Collection of Task.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "b44649d6-a572-496d-ade1-37663c9d7dc7" , CollectionOfType = typeof(Task)) ]
public virtual IList<Task> Tasks 
{
get
{
 if (_tasks == null) _tasks = new List<Task>();

return _tasks;
}
set 
{
if ( _tasks != value) 
{
_tasks = value ;
}
}
}

/// <summary>
/// Collection of Task.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "ebcd4450-9574-49f8-bd09-bdeec1017105" , CollectionOfType = typeof(Task)) ]
public virtual IList<Task> Tasks1 
{
get
{
 if (_tasks1 == null) _tasks1 = new List<Task>();

return _tasks1;
}
set 
{
if ( _tasks1 != value) 
{
_tasks1 = value ;
}
}
}

/// <summary>
/// Collection of UsuarioCopiaOcultaxSmtpAccion.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "b93ec33e-50c3-4d62-ac24-778e002ce75d" , CollectionOfType = typeof(UsuarioCopiaOcultaxSmtpAccion)) ]
public virtual IList<UsuarioCopiaOcultaxSmtpAccion> UsuarioCopiaOcultaxSmtpAccions 
{
get
{
 if (_usuarioCopiaOcultaxSmtpAccions == null) _usuarioCopiaOcultaxSmtpAccions = new List<UsuarioCopiaOcultaxSmtpAccion>();

return _usuarioCopiaOcultaxSmtpAccions;
}
set 
{
if ( _usuarioCopiaOcultaxSmtpAccions != value) 
{
_usuarioCopiaOcultaxSmtpAccions = value ;
}
}
}

/// <summary>
/// Collection of UsuarioCopiaxSmtpAccion.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "ef34320b-a75c-40c9-a2cd-3c0e7938324c" , CollectionOfType = typeof(UsuarioCopiaxSmtpAccion)) ]
public virtual IList<UsuarioCopiaxSmtpAccion> UsuarioCopiaxSmtpAccions 
{
get
{
 if (_usuarioCopiaxSmtpAccions == null) _usuarioCopiaxSmtpAccions = new List<UsuarioCopiaxSmtpAccion>();

return _usuarioCopiaxSmtpAccions;
}
set 
{
if ( _usuarioCopiaxSmtpAccions != value) 
{
_usuarioCopiaxSmtpAccions = value ;
}
}
}

/// <summary>
/// Collection of UsuariosXusuario.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "84993998-710d-4241-a8a1-b505155a44f4" , CollectionOfType = typeof(UsuariosXusuario)) ]
public virtual IList<UsuariosXusuario> UsuariosXusuarios 
{
get
{
 if (_usuariosXusuarios == null) _usuariosXusuarios = new List<UsuariosXusuario>();

return _usuariosXusuarios;
}
set 
{
if ( _usuariosXusuarios != value) 
{
_usuariosXusuarios = value ;
}
}
}

/// <summary>
/// Collection of UsuariosXusuario.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "777bd92a-821f-42d8-b178-71408e4f6062" , CollectionOfType = typeof(UsuariosXusuario)) ]
public virtual IList<UsuariosXusuario> UsuariosXusuarios1 
{
get
{
 if (_usuariosXusuarios1 == null) _usuariosXusuarios1 = new List<UsuariosXusuario>();

return _usuariosXusuarios1;
}
set 
{
if ( _usuariosXusuarios1 != value) 
{
_usuariosXusuarios1 = value ;
}
}
}

/// <summary>
/// Collection of UsuarioxSmtpAccion.
/// </summary>
/// <remarks>
/// This has been automatically being generated because of the mapped 1:Many Relation 
/// </remarks>
[GenWiseAttribute(RelationID = "e33f5d70-264d-4ed3-8ed5-94f97d77bc80" , CollectionOfType = typeof(UsuarioxSmtpAccion)) ]
public virtual IList<UsuarioxSmtpAccion> UsuarioxSmtpAccions 
{
get
{
 if (_usuarioxSmtpAccions == null) _usuarioxSmtpAccions = new List<UsuarioxSmtpAccion>();

return _usuarioxSmtpAccions;
}
set 
{
if ( _usuarioxSmtpAccions != value) 
{
_usuarioxSmtpAccions = value ;
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
/// Create a new Usuario0 object. 
/// </summary>
public  Usuario0()
{
}

/// <summary>
/// Create a new instance/object
/// </summary>
public  Usuario0(System.String pLogin)
{
_login = pLogin ;

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
// Call Validator IsRequired for Column : login(Type:Required Field Validator)
_error = this.ValidateloginIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : nombre(Type:Required Field Validator)
_error = this.ValidatenombreIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }
// Call Validator IsRequired for Column : password(Type:Required Field Validator)
_error = this.ValidatepasswordIsRequired() ;
 if ( _error != null ) { _errors.Add(_error); }


// Primary Key Validation (Template Option)
if ( String.IsNullOrEmpty(Login) ) 
{
   _errors.Add( new Error( "The PK Column (login) can not be null!. " ) );
}

return _errors;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : login
/// </remarks>
public virtual Error ValidateloginIsRequired()
{
if ( String.IsNullOrEmpty(Login) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "login is required and therefore must have a value." ;
 return _error;
}
 return null;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : nombre
/// </remarks>
public virtual Error ValidatenombreIsRequired()
{
if ( String.IsNullOrEmpty(Nombre) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "nombre is required and therefore must have a value." ;
 return _error;
}
 return null;
}

/// <summary>
/// Validation Method
/// </summary>
/// <remarks>
/// This method was automatically generated based on the DataBase Repository Validations for the Column : password
/// </remarks>
public virtual Error ValidatepasswordIsRequired()
{
if ( String.IsNullOrEmpty(Password) ) 
{
 Error _error = new Error();
 _error.ErrorMessage = "password is required and therefore must have a value." ;
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

