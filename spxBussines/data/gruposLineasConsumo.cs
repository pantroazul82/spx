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
    
    public partial class gruposLineasConsumo
    {
        public gruposLineasConsumo()
        {
            this.lineasConsumo = new HashSet<lineasConsumo>();
        }
    
        public string codGrupoLineaConsumo { get; set; }
        public string Descricpion { get; set; }
    
        public virtual ICollection<lineasConsumo> lineasConsumo { get; set; }
    }
}