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
    
    public partial class wcg_smtp_email
    {
        public wcg_smtp_email()
        {
            this.wcg_smtp_adjuntos = new HashSet<wcg_smtp_adjuntos>();
            this.wcg_smtp_email_cc = new HashSet<wcg_smtp_email_cc>();
            this.wcg_smtp_email_to_cco = new HashSet<wcg_smtp_email_to_cco>();
            this.wcg_smtp_email_to = new HashSet<wcg_smtp_email_to>();
        }
    
        public int cod_wcg_smtp_email { get; set; }
        public bool enviado { get; set; }
        public Nullable<System.DateTime> fecha_real_envio { get; set; }
        public string cuerpo { get; set; }
        public string nombre_firma { get; set; }
        public string email_firma { get; set; }
        public string asunto { get; set; }
        public bool body_html { get; set; }
        public string prioridad { get; set; }
        public string responder_a { get; set; }
        public System.DateTime fecha_envio { get; set; }
    
        public virtual ICollection<wcg_smtp_adjuntos> wcg_smtp_adjuntos { get; set; }
        public virtual ICollection<wcg_smtp_email_cc> wcg_smtp_email_cc { get; set; }
        public virtual ICollection<wcg_smtp_email_to_cco> wcg_smtp_email_to_cco { get; set; }
        public virtual ICollection<wcg_smtp_email_to> wcg_smtp_email_to { get; set; }
    }
}