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
    
    public partial class opciones
    {
        public int cod_opciones { get; set; }
        public string texto { get; set; }
        public Nullable<int> cod_linea { get; set; }
        public Nullable<int> cod_proceso { get; set; }
        public Nullable<int> color_r { get; set; }
        public Nullable<int> color_g { get; set; }
        public Nullable<int> color_b { get; set; }
        public byte[] imagen { get; set; }
        public Nullable<bool> flujo_alterno { get; set; }
    
        public virtual linea linea { get; set; }
        public virtual proceso proceso { get; set; }
        public virtual proceso proceso1 { get; set; }
    }
}
