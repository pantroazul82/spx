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
    
    public partial class consumiblexcontrato_consumo
    {
        public int cod_consumiblexcontrato_consumo { get; set; }
        public Nullable<int> cod_consumible { get; set; }
        public Nullable<decimal> cantidad { get; set; }
        public Nullable<int> cod_contrato_consumo { get; set; }
    
        public virtual consumibles consumibles { get; set; }
        public virtual contrato_consumo contrato_consumo { get; set; }
    }
}
