//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace spxBussines.data
{
    using System;
    using System.Collections.Generic;
    
    public partial class sucursalCliente
    {
        public sucursalCliente()
        {
            this.asesoria_cientifica = new HashSet<asesoria_cientifica>();
            this.control_calidad = new HashSet<control_calidad>();
            this.EntradaSalidaEquipos = new HashSet<EntradaSalidaEquipos>();
            this.equipos = new HashSet<equipos>();
            this.equipos1 = new HashSet<equipos>();
            this.equipos2 = new HashSet<equipos>();
            this.equiposxcontrato_consumo = new HashSet<equiposxcontrato_consumo>();
            this.LlamadaSoporte = new HashSet<LlamadaSoporte>();
            this.logCambioUbicaciones = new HashSet<logCambioUbicaciones>();
            this.logCambioUbicaciones1 = new HashSet<logCambioUbicaciones>();
            this.ordenServicio = new HashSet<ordenServicio>();
            this.recoleccion = new HashSet<recoleccion>();
            this.revision_equipos = new HashSet<revision_equipos>();
            this.revision_equipos1 = new HashSet<revision_equipos>();
            this.solicitud_general = new HashSet<solicitud_general>();
            this.tarea_calendario = new HashSet<tarea_calendario>();
        }
    
        public string nitCliente { get; set; }
        public string codSucursal { get; set; }
        public string nombreSucursal { get; set; }
        public string codPais { get; set; }
        public string codDepartamento { get; set; }
        public string codCiudad { get; set; }
        public string Direccion { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string codContacto { get; set; }
        public Nullable<bool> bloqueaSalida { get; set; }
        public Nullable<bool> activaParaTraslados { get; set; }
        public Nullable<bool> requierePermisoParaTraslados { get; set; }
    
        public virtual ICollection<asesoria_cientifica> asesoria_cientifica { get; set; }
        public virtual ciudades ciudades { get; set; }
        public virtual clientes clientes { get; set; }
        public virtual contactosClientes contactosClientes { get; set; }
        public virtual ICollection<control_calidad> control_calidad { get; set; }
        public virtual ICollection<EntradaSalidaEquipos> EntradaSalidaEquipos { get; set; }
        public virtual ICollection<equipos> equipos { get; set; }
        public virtual ICollection<equipos> equipos1 { get; set; }
        public virtual ICollection<equipos> equipos2 { get; set; }
        public virtual ICollection<equiposxcontrato_consumo> equiposxcontrato_consumo { get; set; }
        public virtual ICollection<LlamadaSoporte> LlamadaSoporte { get; set; }
        public virtual ICollection<logCambioUbicaciones> logCambioUbicaciones { get; set; }
        public virtual ICollection<logCambioUbicaciones> logCambioUbicaciones1 { get; set; }
        public virtual ICollection<ordenServicio> ordenServicio { get; set; }
        public virtual ICollection<recoleccion> recoleccion { get; set; }
        public virtual ICollection<revision_equipos> revision_equipos { get; set; }
        public virtual ICollection<revision_equipos> revision_equipos1 { get; set; }
        public virtual ICollection<solicitud_general> solicitud_general { get; set; }
        public virtual ICollection<tarea_calendario> tarea_calendario { get; set; }
    }
}
