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
    
    public partial class moduloseguridad_usuario
    {
        public int cod_moduloseguridad_usuario { get; set; }
        public int cod_modulo_seguridad { get; set; }
        public int cod_usuario { get; set; }
        public Nullable<bool> control_total { get; set; }
        public Nullable<bool> modificar { get; set; }
        public Nullable<bool> lectura_ejecucion { get; set; }
        public Nullable<bool> escribir { get; set; }
        public Nullable<bool> eliminar { get; set; }
        public Nullable<bool> imprimir { get; set; }
        public Nullable<bool> denegar { get; set; }
    
        public virtual usuario usuario { get; set; }
    }
}
