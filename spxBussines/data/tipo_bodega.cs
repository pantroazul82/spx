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
    
    public partial class tipo_bodega
    {
        public tipo_bodega()
        {
            this.bodega = new HashSet<bodega>();
        }
    
        public int cod_tipo_bodega { get; set; }
        public string nombre_tipo_bodega { get; set; }
        public Nullable<bool> ind_1 { get; set; }
        public Nullable<bool> ind_2 { get; set; }
        public Nullable<bool> ind_3 { get; set; }
        public Nullable<bool> ind_4 { get; set; }
        public Nullable<bool> ind_5 { get; set; }
    
        public virtual ICollection<bodega> bodega { get; set; }
    }
}
