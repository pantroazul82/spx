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
    
    public partial class cgq_queryxusuario
    {
        public int cod_queryxusuario { get; set; }
        public Nullable<int> cod_usuario { get; set; }
        public Nullable<int> cod_query { get; set; }
    
        public virtual cgq_query cgq_query { get; set; }
        public virtual usuario usuario { get; set; }
    }
}