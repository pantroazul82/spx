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
    
    public partial class repuestosxContratos
    {
        public string numeroContrato { get; set; }
        public int codOtroSi { get; set; }
        public string codRepuesto { get; set; }
        public Nullable<int> cantidad { get; set; }
        public string observaciones { get; set; }
    
        public virtual contratos contratos { get; set; }
        public virtual repuestos repuestos { get; set; }
    }
}
