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
    
    public partial class wcg_virtual_frm
    {
        public wcg_virtual_frm()
        {
            this.wcg_virtual_tab = new HashSet<wcg_virtual_tab>();
        }
    
        public int cod_wcg_virtual_frm { get; set; }
        public string titulo { get; set; }
        public string nombre { get; set; }
        public string tabla_operacion { get; set; }
        public string procedimiento_delete_all { get; set; }
    
        public virtual ICollection<wcg_virtual_tab> wcg_virtual_tab { get; set; }
    }
}