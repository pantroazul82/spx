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
    
    public partial class log_cambios_estado_contratos_suministro
    {
        public int cod_log_cambios_estado_contratos_suministro { get; set; }
        public Nullable<System.DateTime> fecha_cambio { get; set; }
        public Nullable<int> usuario_cambio { get; set; }
        public string observaciones_cambio { get; set; }
        public Nullable<int> cod_estado_contrato_suministro { get; set; }
        public Nullable<int> cod_contratos_suministro { get; set; }
        public Nullable<int> cod_estado_contrato_suministro_original { get; set; }
        public Nullable<int> horas { get; set; }
        public Nullable<int> minutos { get; set; }
    
        public virtual contratos_suministro contratos_suministro { get; set; }
        public virtual estado_contrato_suministro estado_contrato_suministro { get; set; }
        public virtual usuario usuario { get; set; }
    }
}