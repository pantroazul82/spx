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
    
    public partial class tipo_actividad
    {
        public tipo_actividad()
        {
            this.actividad_adicional = new HashSet<actividad_adicional>();
        }
    
        public int cod_tipo_actividad { get; set; }
        public string nombre_tipo_actividad { get; set; }
    
        public virtual ICollection<actividad_adicional> actividad_adicional { get; set; }
    }
}