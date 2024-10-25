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
    
    public partial class capacitacion
    {
        public capacitacion()
        {
            this.asistente_capacitacion = new HashSet<asistente_capacitacion>();
            this.asistentexsession = new HashSet<asistentexsession>();
            this.session_capacitacion = new HashSet<session_capacitacion>();
        }
    
        public int cod_capacitacion { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public System.DateTime fecha_inicio { get; set; }
        public System.DateTime fecha_fin { get; set; }
        public string cod_modelo { get; set; }
        public string cod_fabricante { get; set; }
        public Nullable<int> cod_referencia_reactivo { get; set; }
        public Nullable<int> dictada_por { get; set; }
        public int cod_estado_capacitacion { get; set; }
        public string dictada_por_otro { get; set; }
    
        public virtual ICollection<asistente_capacitacion> asistente_capacitacion { get; set; }
        public virtual ICollection<asistentexsession> asistentexsession { get; set; }
        public virtual estado_capacitacion estado_capacitacion { get; set; }
        public virtual Modelos Modelos { get; set; }
        public virtual referencia_reactivo referencia_reactivo { get; set; }
        public virtual usuario usuario { get; set; }
        public virtual ICollection<session_capacitacion> session_capacitacion { get; set; }
    }
}
