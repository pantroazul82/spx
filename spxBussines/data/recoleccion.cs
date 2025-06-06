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
    
    public partial class recoleccion
    {
        public int codRecoleccion { get; set; }
        public Nullable<int> codEstadoRecoleccion { get; set; }
        public string nitCliente { get; set; }
        public string codSucursal { get; set; }
        public string codModalidad { get; set; }
        public string serial { get; set; }
        public Nullable<System.DateTime> fechaSolicitud { get; set; }
        public string solicitadoPor { get; set; }
        public string observacionesSolicitud { get; set; }
        public string motivoRecoleccion { get; set; }
        public Nullable<System.DateTime> fechaTentativaLlegada { get; set; }
        public string responsableRecoleccion { get; set; }
        public Nullable<int> codTransportadora { get; set; }
        public string codRecoleccionTransportadora { get; set; }
        public string nroGuia { get; set; }
        public string obsIniciales { get; set; }
        public Nullable<bool> confirmada { get; set; }
        public string confirmadaPor { get; set; }
        public Nullable<System.DateTime> fechaConfirmacion { get; set; }
        public string obsConfirmacion { get; set; }
        public Nullable<System.DateTime> fechaRecoleccion { get; set; }
        public Nullable<int> codEntradaSalidaEquipos { get; set; }
        public Nullable<bool> retiro_definitivo { get; set; }
    
        public virtual equipos equipos { get; set; }
        public virtual estadoRecoleccion estadoRecoleccion { get; set; }
        public virtual ModalidadEquipo ModalidadEquipo { get; set; }
        public virtual sucursalCliente sucursalCliente { get; set; }
        public virtual transportadora transportadora { get; set; }
    }
}
