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
    
    public partial class modelo_inventario
    {
        public modelo_inventario()
        {
            this.referencia = new HashSet<referencia>();
        }
    
        public int cod_modelo_inventario { get; set; }
        public string nombre_modelo { get; set; }
        public string tabla_relevante { get; set; }
        public string campo_relevante { get; set; }
        public string campo_ordenado { get; set; }
    
        public virtual ICollection<referencia> referencia { get; set; }
    }
}
