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
    
    public partial class problemas_frecuentes
    {
        public problemas_frecuentes()
        {
            this.problemas_frecuentes_por_llamada = new HashSet<problemas_frecuentes_por_llamada>();
            this.soluciones_problemas = new HashSet<soluciones_problemas>();
        }
    
        public int cod_problema_frecuente { get; set; }
        public string codFabricante { get; set; }
        public string codModelo { get; set; }
        public string cod_manual { get; set; }
        public string nombre_problema { get; set; }
        public string descripcion { get; set; }
    
        public virtual Modelos Modelos { get; set; }
        public virtual ICollection<problemas_frecuentes_por_llamada> problemas_frecuentes_por_llamada { get; set; }
        public virtual ICollection<soluciones_problemas> soluciones_problemas { get; set; }
    }
}