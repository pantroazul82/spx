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
    
    public partial class referencia_reactivo
    {
        public referencia_reactivo()
        {
            this.capacitacion = new HashSet<capacitacion>();
            this.control_calidad = new HashSet<control_calidad>();
            this.reactivo_solicitud = new HashSet<reactivo_solicitud>();
            this.reactivoxtarea = new HashSet<reactivoxtarea>();
        }
    
        public int cod_referencia_reactivo { get; set; }
        public string codFabricante { get; set; }
        public string codigo_manual { get; set; }
        public string nombre_referencia_reactivo { get; set; }
    
        public virtual ICollection<capacitacion> capacitacion { get; set; }
        public virtual ICollection<control_calidad> control_calidad { get; set; }
        public virtual ICollection<reactivo_solicitud> reactivo_solicitud { get; set; }
        public virtual ICollection<reactivoxtarea> reactivoxtarea { get; set; }
    }
}
