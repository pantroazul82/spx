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
    
    public partial class repuestos
    {
        public repuestos()
        {
            this.archivosxRepuesto = new HashSet<archivosxRepuesto>();
            this.detalleSolicitudInsumos = new HashSet<detalleSolicitudInsumos>();
            this.repuestosxContratos = new HashSet<repuestosxContratos>();
            this.repuestosxOrdenPrestamo = new HashSet<repuestosxOrdenPrestamo>();
            this.repuestoxOrdenServicio = new HashSet<repuestoxOrdenServicio>();
        }
    
        public string codRepuesto { get; set; }
        public string descripcion { get; set; }
        public Nullable<decimal> precio { get; set; }
        public string Observaciones { get; set; }
    
        public virtual ICollection<archivosxRepuesto> archivosxRepuesto { get; set; }
        public virtual ICollection<detalleSolicitudInsumos> detalleSolicitudInsumos { get; set; }
        public virtual ICollection<repuestosxContratos> repuestosxContratos { get; set; }
        public virtual ICollection<repuestosxOrdenPrestamo> repuestosxOrdenPrestamo { get; set; }
        public virtual ICollection<repuestoxOrdenServicio> repuestoxOrdenServicio { get; set; }
    }
}
