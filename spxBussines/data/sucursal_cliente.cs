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
    
    public partial class sucursal_cliente
    {
        public sucursal_cliente()
        {
            this.sucursalxcontacto = new HashSet<sucursalxcontacto>();
        }
    
        public int cod_sucursal_cliente { get; set; }
        public string nombre_sucursal { get; set; }
        public Nullable<int> cod_ciudad { get; set; }
        public int cod_cliente { get; set; }
        public string direccion { get; set; }
        public string telefono_1 { get; set; }
        public string telefono_2 { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public Nullable<bool> sucursal_principal { get; set; }
        public Nullable<bool> ind_1 { get; set; }
        public Nullable<bool> ind_2 { get; set; }
        public Nullable<bool> ind_3 { get; set; }
        public string documento_sucursal { get; set; }
    
        public virtual ciudad ciudad { get; set; }
        public virtual cliente cliente { get; set; }
        public virtual ICollection<sucursalxcontacto> sucursalxcontacto { get; set; }
    }
}