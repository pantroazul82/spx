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
    
    public partial class estado_tarea_calendario
    {
        public estado_tarea_calendario()
        {
            this.tarea_calendario = new HashSet<tarea_calendario>();
        }
    
        public int cod_estado_tarea_calendario { get; set; }
        public int cod_manual { get; set; }
        public string nombre_estado_tarea { get; set; }
    
        public virtual ICollection<tarea_calendario> tarea_calendario { get; set; }
    }
}