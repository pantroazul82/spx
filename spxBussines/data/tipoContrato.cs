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
    
    public partial class tipoContrato
    {
        public tipoContrato()
        {
            this.modalidadContrato = new HashSet<modalidadContrato>();
        }
    
        public string codTipoContrato { get; set; }
        public string nombreTipoContrato { get; set; }
        public string descripcion { get; set; }
        public Nullable<bool> deMantenimiento { get; set; }
        public Nullable<bool> deConsumo { get; set; }
    
        public virtual ICollection<modalidadContrato> modalidadContrato { get; set; }
    }
}
