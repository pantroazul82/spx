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
    
    public partial class transportador
    {
        public transportador()
        {
            this.bodega = new HashSet<bodega>();
            this.movimiento = new HashSet<movimiento>();
        }
    
        public int cod_transportador { get; set; }
        public string nombre_transportador { get; set; }
        public string direccion_transportador { get; set; }
        public Nullable<int> cod_ciudad { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public Nullable<bool> tiene_contrato { get; set; }
        public string numero_contrato { get; set; }
        public Nullable<System.DateTime> fecha_vencimiento { get; set; }
        public Nullable<int> cod_linea { get; set; }
        public byte[] logo { get; set; }
    
        public virtual ICollection<bodega> bodega { get; set; }
        public virtual ciudad ciudad { get; set; }
        public virtual linea linea { get; set; }
        public virtual ICollection<movimiento> movimiento { get; set; }
    }
}