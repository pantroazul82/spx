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
    
    public partial class existencia
    {
        public int cod_existencia { get; set; }
        public Nullable<int> cod_linea { get; set; }
        public string documento_principal { get; set; }
        public string serial { get; set; }
        public string serial_rango { get; set; }
        public Nullable<decimal> precio { get; set; }
        public string cod_alterno { get; set; }
        public string numero_control { get; set; }
        public Nullable<System.DateTime> fecha_control { get; set; }
        public Nullable<double> cantidad { get; set; }
        public Nullable<double> cantidad_reservada { get; set; }
        public string texto_adicional { get; set; }
        public Nullable<int> cod_cliente { get; set; }
        public string bulto { get; set; }
        public string caja_madre { get; set; }
        public string estiba { get; set; }
        public Nullable<int> ultimo_usuario { get; set; }
        public Nullable<int> cod_referencia { get; set; }
        public Nullable<int> cod_estado_fisico { get; set; }
        public Nullable<int> cod_estado_bloqueo { get; set; }
        public Nullable<int> cod_estado_proceso_item { get; set; }
        public Nullable<long> cod_ultimo_movimiento { get; set; }
        public Nullable<long> cod_movimiento_ingreso { get; set; }
        public System.DateTime fecha_ingreso { get; set; }
        public Nullable<int> cod_bodega { get; set; }
        public Nullable<int> cod_ubicacion { get; set; }
        public string pedido { get; set; }
        public string texto1 { get; set; }
        public string texto2 { get; set; }
        public string texto3 { get; set; }
        public string texto4 { get; set; }
        public string texto5 { get; set; }
        public string texto6 { get; set; }
        public string texto7 { get; set; }
        public string texto8 { get; set; }
        public string texto9 { get; set; }
        public string texto10 { get; set; }
        public Nullable<System.DateTime> fecha1 { get; set; }
        public Nullable<System.DateTime> fecha2 { get; set; }
        public Nullable<System.DateTime> fecha3 { get; set; }
        public Nullable<System.DateTime> fecha4 { get; set; }
        public Nullable<System.DateTime> fecha5 { get; set; }
    
        public virtual cliente cliente { get; set; }
        public virtual estado_bloqueo estado_bloqueo { get; set; }
        public virtual estado_fisico estado_fisico { get; set; }
        public virtual estado_proceso_item estado_proceso_item { get; set; }
        public virtual linea linea { get; set; }
        public virtual movimiento movimiento { get; set; }
        public virtual movimiento movimiento1 { get; set; }
        public virtual usuario usuario { get; set; }
    }
}
