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
    
    public partial class prioridad_callcenter_cientifica
    {
        public prioridad_callcenter_cientifica()
        {
            this.asesoria_cientifica = new HashSet<asesoria_cientifica>();
            this.asesoria_cientifica1 = new HashSet<asesoria_cientifica>();
        }
    
        public int cod_prioridad_callcenter_cientifica { get; set; }
        public string nombre_prioridad { get; set; }
        public int relevancia { get; set; }
    
        public virtual ICollection<asesoria_cientifica> asesoria_cientifica { get; set; }
        public virtual ICollection<asesoria_cientifica> asesoria_cientifica1 { get; set; }
    }
}