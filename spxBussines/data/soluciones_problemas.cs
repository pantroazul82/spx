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
    
    public partial class soluciones_problemas
    {
        public soluciones_problemas()
        {
            this.problemas_frecuentes_por_llamada = new HashSet<problemas_frecuentes_por_llamada>();
        }
    
        public int cod_soluciones_problemas { get; set; }
        public Nullable<int> cod_problema_frecuente { get; set; }
        public string nombre_solucion { get; set; }
        public string descripcion_solucion { get; set; }
    
        public virtual problemas_frecuentes problemas_frecuentes { get; set; }
        public virtual ICollection<problemas_frecuentes_por_llamada> problemas_frecuentes_por_llamada { get; set; }
    }
}
