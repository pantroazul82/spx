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
    
    public partial class archivosxtarea_calendario
    {
        public int codarchivosxtarea_calendario { get; set; }
        public Nullable<int> cod_tarea_calendario { get; set; }
        public string nombreArchivo { get; set; }
        public string descripcion { get; set; }
        public byte[] archivo { get; set; }
    
        public virtual tarea_calendario tarea_calendario { get; set; }
    }
}