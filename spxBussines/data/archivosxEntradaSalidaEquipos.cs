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
    
    public partial class archivosxEntradaSalidaEquipos
    {
        public int codarchivosxEntradaSalidaEquipos { get; set; }
        public Nullable<int> codEntradaSalidaEquipos { get; set; }
        public string nombreArchivo { get; set; }
        public string descripcion { get; set; }
        public byte[] archivo { get; set; }
    
        public virtual EntradaSalidaEquipos EntradaSalidaEquipos { get; set; }
    }
}
