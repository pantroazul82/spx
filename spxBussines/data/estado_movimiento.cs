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
    
    public partial class estado_movimiento
    {
        public estado_movimiento()
        {
            this.estado_movimientoxgrupo_usuario = new HashSet<estado_movimientoxgrupo_usuario>();
            this.estado_movimientoxusuario = new HashSet<estado_movimientoxusuario>();
            this.filtro_estado_movimiento = new HashSet<filtro_estado_movimiento>();
            this.flujoxestado = new HashSet<flujoxestado>();
            this.layout_flujo = new HashSet<layout_flujo>();
            this.logcambia_estado = new HashSet<logcambia_estado>();
            this.logcambia_estado1 = new HashSet<logcambia_estado>();
            this.movimiento = new HashSet<movimiento>();
            this.notificacion_estado = new HashSet<notificacion_estado>();
            this.secuencia_estado_movimiento = new HashSet<secuencia_estado_movimiento>();
            this.secuencia_estado_movimiento1 = new HashSet<secuencia_estado_movimiento>();
        }
    
        public int cod_estado_movimiento { get; set; }
        public int cod_proceso { get; set; }
        public string nombre_estado { get; set; }
        public int cod_estado_item_inicial { get; set; }
        public int cod_estado_item_final { get; set; }
        public Nullable<bool> permite_modificar_movimiento { get; set; }
        public Nullable<bool> permite_modificar_detalle { get; set; }
        public Nullable<bool> es_inicio { get; set; }
        public Nullable<bool> estado_anulacion { get; set; }
        public Nullable<bool> agrupa { get; set; }
        public Nullable<bool> desagrupa { get; set; }
        public Nullable<bool> inicia_fliujo_alterno { get; set; }
        public Nullable<bool> termina_flujo_alterno { get; set; }
        public Nullable<bool> asigna_responsable { get; set; }
        public Nullable<bool> filtraxresponsable { get; set; }
        public Nullable<bool> permite_reasignar { get; set; }
        public Nullable<bool> ejecuta_qc_pre { get; set; }
        public Nullable<bool> ejecuta_qc_post { get; set; }
        public Nullable<bool> calcula_pendiente_ingreso { get; set; }
        public Nullable<bool> calcula_pendiente_ejecucion { get; set; }
        public Nullable<bool> calcula_pendiente_cambio { get; set; }
        public Nullable<bool> no_cambia_estado { get; set; }
        public Nullable<bool> valida_detalle { get; set; }
        public Nullable<bool> valida_novedades_abiertas { get; set; }
        public Nullable<bool> confirma_cambia_estado { get; set; }
        public string caption_confirmacion { get; set; }
        public Nullable<bool> crea_movimiento { get; set; }
        public Nullable<bool> cambio_parcial { get; set; }
        public Nullable<bool> cambio_manual { get; set; }
        public Nullable<bool> ejecucion_cambia_estado { get; set; }
        public Nullable<bool> permite_cambios_multiples { get; set; }
        public Nullable<bool> ejecuta_actividad { get; set; }
        public Nullable<bool> fifo_ejecucion { get; set; }
        public Nullable<bool> lifo_ejecucion { get; set; }
        public Nullable<bool> fifo_cambio { get; set; }
        public Nullable<bool> lifo_cambio { get; set; }
        public Nullable<bool> orden_especial { get; set; }
        public string tabla_orden_especial { get; set; }
        public string campo_orden_especial { get; set; }
        public Nullable<bool> asc_orden_especial { get; set; }
        public string frm_pre_ejecucion { get; set; }
        public string sp_ejecucion { get; set; }
        public string frm_post_ejecuccion { get; set; }
        public string frm_pre_cambio { get; set; }
        public string sp_cambio { get; set; }
        public string frm_post_cambio { get; set; }
        public string frm_pre_cambio_especial { get; set; }
        public string sp_cambio_especial { get; set; }
        public string frm_post_cambio_especial { get; set; }
        public string frm_pre_anulacion { get; set; }
        public string sp_anulacion { get; set; }
        public string frm_post_anulacion { get; set; }
        public string frm_pre_ingreso { get; set; }
        public string sp_ingreso { get; set; }
        public string frm_post_ingreso { get; set; }
        public string frm_pre_cambio_multiple { get; set; }
        public string frm_post_cambio_multiple { get; set; }
        public string frm_pre_cambio_multiple_especial { get; set; }
        public string frm_post_cambio_multiple_especial { get; set; }
        public string query_layout { get; set; }
        public Nullable<int> dias_alarma { get; set; }
        public Nullable<bool> calcula_total_unidades { get; set; }
    
        public virtual estado_proceso_item estado_proceso_item { get; set; }
        public virtual estado_proceso_item estado_proceso_item1 { get; set; }
        public virtual proceso proceso { get; set; }
        public virtual ICollection<estado_movimientoxgrupo_usuario> estado_movimientoxgrupo_usuario { get; set; }
        public virtual ICollection<estado_movimientoxusuario> estado_movimientoxusuario { get; set; }
        public virtual ICollection<filtro_estado_movimiento> filtro_estado_movimiento { get; set; }
        public virtual ICollection<flujoxestado> flujoxestado { get; set; }
        public virtual ICollection<layout_flujo> layout_flujo { get; set; }
        public virtual ICollection<logcambia_estado> logcambia_estado { get; set; }
        public virtual ICollection<logcambia_estado> logcambia_estado1 { get; set; }
        public virtual ICollection<movimiento> movimiento { get; set; }
        public virtual ICollection<notificacion_estado> notificacion_estado { get; set; }
        public virtual ICollection<secuencia_estado_movimiento> secuencia_estado_movimiento { get; set; }
        public virtual ICollection<secuencia_estado_movimiento> secuencia_estado_movimiento1 { get; set; }
    }
}
