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
    
    public partial class tipo_software_contrato_consumo
    {
        public tipo_software_contrato_consumo()
        {
            this.tipo_softwarexcontrato_consumo = new HashSet<tipo_softwarexcontrato_consumo>();
        }
    
        public int cod_tipo_software_contrato_consumo { get; set; }
        public string tipo_software_contrato_consumo1 { get; set; }
    
        public virtual ICollection<tipo_softwarexcontrato_consumo> tipo_softwarexcontrato_consumo { get; set; }
    }
}
