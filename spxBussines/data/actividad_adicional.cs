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
    
    public partial class actividad_adicional
    {
        public int cod_actividad_adicional { get; set; }
        public System.DateTime fecha_inicio { get; set; }
        public System.DateTime fecha_fin { get; set; }
        public string nombre_actividad { get; set; }
        public string descripcion_actividad { get; set; }
        public string ubicacion { get; set; }
        public int cod_tipo_actividad { get; set; }
        public string login { get; set; }
    
        public virtual tipo_actividad tipo_actividad { get; set; }
    }
}