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
    
    public partial class auditoria
    {
        public long cod_auditoria { get; set; }
        public Nullable<System.DateTime> fecha_modificacion { get; set; }
        public string tabla { get; set; }
        public string campo { get; set; }
        public string valor_original { get; set; }
        public string valor_nuevo { get; set; }
        public string equipo_origen { get; set; }
        public string observaciones { get; set; }
        public string ip_origen { get; set; }
    }
}
