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
    
    public partial class estado_capacitacion
    {
        public estado_capacitacion()
        {
            this.capacitacion = new HashSet<capacitacion>();
        }
    
        public int cod_estado_capacitacion { get; set; }
        public string descripcion { get; set; }
        public Nullable<int> orden { get; set; }
    
        public virtual ICollection<capacitacion> capacitacion { get; set; }
    }
}