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
    
    public partial class motivo_salida
    {
        public motivo_salida()
        {
            this.EntradaSalidaEquipos = new HashSet<EntradaSalidaEquipos>();
        }
    
        public int cod_motivo_salida { get; set; }
        public string nombre_motivo_salida { get; set; }
    
        public virtual ICollection<EntradaSalidaEquipos> EntradaSalidaEquipos { get; set; }
    }
}