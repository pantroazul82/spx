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
    
    public partial class secuencia_estado_movimiento
    {
        public int cod_secuencia_estado_movimiento { get; set; }
        public int cod_estado_movimiento { get; set; }
        public int cod_estado_movimiento_anterior { get; set; }
        public bool cambio_especial { get; set; }
        public string tabla_fecha_log { get; set; }
        public string campo_fecha_log { get; set; }
    
        public virtual estado_movimiento estado_movimiento { get; set; }
        public virtual estado_movimiento estado_movimiento1 { get; set; }
    }
}