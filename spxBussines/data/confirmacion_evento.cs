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
    
    public partial class confirmacion_evento
    {
        public int cod_confirmacion { get; set; }
        public string nombre_completo { get; set; }
        public string correo { get; set; }
        public string celular { get; set; }
        public Nullable<System.DateTime> fecha_confirmacion { get; set; }
        public string invitado_por { get; set; }
        public Nullable<bool> va_con_pareja { get; set; }
        public string nombre_completo_pareja { get; set; }
    }
}
