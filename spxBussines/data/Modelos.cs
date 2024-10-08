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
    
    public partial class Modelos
    {
        public Modelos()
        {
            this.accesoriosEquipo = new HashSet<accesoriosEquipo>();
            this.ActividadesxModelo = new HashSet<ActividadesxModelo>();
            this.archivosxModelo = new HashSet<archivosxModelo>();
            this.capacitacion = new HashSet<capacitacion>();
            this.control_calidad = new HashSet<control_calidad>();
            this.dispositivosmedicionxordenservicio = new HashSet<dispositivosmedicionxordenservicio>();
            this.equipos = new HashSet<equipos>();
            this.equiposxcontrato_consumo = new HashSet<equiposxcontrato_consumo>();
            this.modeloxtarea = new HashSet<modeloxtarea>();
            this.problemas_frecuentes = new HashSet<problemas_frecuentes>();
            this.tarea_calendario = new HashSet<tarea_calendario>();
            this.template_revison_equipo = new HashSet<template_revison_equipo>();
            this.variables_medicionxmodelo = new HashSet<variables_medicionxmodelo>();
            this.componente = new HashSet<componente>();
        }
    
        public string codFabricante { get; set; }
        public string codModelo { get; set; }
        public string NombreModelo { get; set; }
        public string descripcion { get; set; }
        public byte[] fotografia { get; set; }
        public string nombreManual { get; set; }
        public byte[] manual { get; set; }
        public string codTipoEquipo { get; set; }
        public string codSubTipoEquipo { get; set; }
        public string voltaje { get; set; }
        public string watios { get; set; }
        public string amperios { get; set; }
        public string frecuencia { get; set; }
        public Nullable<double> duracionmantenimiento { get; set; }
        public Nullable<int> diasxMantenimiento { get; set; }
        public Nullable<int> mesesxMantenimiento { get; set; }
        public Nullable<decimal> pesoEstimado { get; set; }
        public Nullable<int> codUnidadPeso { get; set; }
        public string cod_manual_modelo { get; set; }
    
        public virtual ICollection<accesoriosEquipo> accesoriosEquipo { get; set; }
        public virtual ICollection<ActividadesxModelo> ActividadesxModelo { get; set; }
        public virtual ICollection<archivosxModelo> archivosxModelo { get; set; }
        public virtual ICollection<capacitacion> capacitacion { get; set; }
        public virtual ICollection<control_calidad> control_calidad { get; set; }
        public virtual ICollection<dispositivosmedicionxordenservicio> dispositivosmedicionxordenservicio { get; set; }
        public virtual ICollection<equipos> equipos { get; set; }
        public virtual ICollection<equiposxcontrato_consumo> equiposxcontrato_consumo { get; set; }
        public virtual subTipoEquipo subTipoEquipo { get; set; }
        public virtual ICollection<modeloxtarea> modeloxtarea { get; set; }
        public virtual ICollection<problemas_frecuentes> problemas_frecuentes { get; set; }
        public virtual ICollection<tarea_calendario> tarea_calendario { get; set; }
        public virtual ICollection<template_revison_equipo> template_revison_equipo { get; set; }
        public virtual ICollection<variables_medicionxmodelo> variables_medicionxmodelo { get; set; }
        public virtual ICollection<componente> componente { get; set; }
    }
}
