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
    
    public partial class archivos_control_calidad
    {
        public Nullable<int> cod_control_calidad { get; set; }
        public int cod_archivos_control_calidad { get; set; }
        public string tipo { get; set; }
        public byte[] archivo { get; set; }
        public System.DateTime fecha_subida { get; set; }
        public Nullable<System.DateTime> fecha_manual { get; set; }
        public string nombre { get; set; }
    
        public virtual control_calidad control_calidad { get; set; }
    }
}