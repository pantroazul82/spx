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
    
    public partial class linea_consumoxcontrato_consumo
    {
        public int cod_linea_consumoxcontrato_consumo { get; set; }
        public Nullable<int> cod_linea_consumo { get; set; }
        public Nullable<int> cod_contrato_consumo { get; set; }
        public Nullable<decimal> valor_exigido { get; set; }
    
        public virtual contrato_consumo contrato_consumo { get; set; }
        public virtual linea_consumo linea_consumo { get; set; }
    }
}