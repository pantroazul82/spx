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
    
    public partial class transportadora
    {
        public transportadora()
        {
            this.recoleccion = new HashSet<recoleccion>();
        }
    
        public int codTransportadora { get; set; }
        public string nombreTransportadora { get; set; }
        public string telefono { get; set; }
        public string telefono2 { get; set; }
        public string celular { get; set; }
        public string direccion { get; set; }
        public string observaciones { get; set; }
    
        public virtual ICollection<recoleccion> recoleccion { get; set; }
    }
}
