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
    
    public partial class accesoriosEquipo
    {
        public string codAccesoriosEquipos { get; set; }
        public string nombreAccesorio { get; set; }
        public string descripcion { get; set; }
        public string codFabricante { get; set; }
        public string codModelo { get; set; }
        public Nullable<int> codFoto { get; set; }
    
        public virtual fotografia fotografia { get; set; }
        public virtual Modelos Modelos { get; set; }
    }
}