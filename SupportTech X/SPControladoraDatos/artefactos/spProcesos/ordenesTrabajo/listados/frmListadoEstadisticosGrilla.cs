using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.ordenesTrabajo.listados
{
    public partial class frmListadoEstadisticosGrilla : Form
    {
        public frmListadoEstadisticosGrilla()
        {
            InitializeComponent();
        }

        public string filtro = "";
        public string codFiltro = "";
        public DateTime fechaInicio { set; get; }
        public DateTime fechaFin { set; get; }
        public listados.frmFiltroEstadistico objTmp;

        private void frmListadoEstadisticosGrilla_Load(object sender, EventArgs e)
        {
            estadosOrdenServicioTableAdapter1.Fill(dsSpx1.estadosOrdenServicio);
            prioridadesOrdenServicioTableAdapter1.Fill(dsSpx1.prioridadesOrdenServicio);
            tipoServicioTableAdapter1.Fill(dsSpx1.TipoServicio);
            string filtroFecha = " fechaProgramacion between"+
                " '" + fechaInicio.Year + "/" + fechaInicio.Month.ToString().PadLeft(2, '0') + "/" + fechaInicio.Day.ToString().PadLeft(2, '0') + "' and '" + fechaFin.Year + "/" + fechaFin.Month.ToString().PadLeft(2, '0') + "/" + fechaFin.Day.ToString().PadLeft(2, '0') + "'";
            switch (filtro) 
            {
                case "ESTADOS": { cargarEstados(codFiltro,filtroFecha); break; }
                case "TIPOSSERVICIO": { cargarTiposServicios(codFiltro, filtroFecha); break; }
                case "PINTERNAS": { cargarInternas(codFiltro, filtroFecha); break; }
                case "PEXTERNAS": { cargarExternas(codFiltro, filtroFecha); break; }
                case "CANTIDAD": { cargarCantidad(codFiltro, filtroFecha); break; }
            }
        }
        private void cargarEstados(string codFiltro,string filtroFecha) 
        {
            string sql = "set dateformat ymd  select ordenservicio.* from ordenservicio" +
                " join estadosOrdenServicio on  estadosOrdenServicio.codEstadoOrdenServicio = ordenServicio.codEstadoOrdenServicio"+
                " where nombreestado='"+codFiltro+"' and "+filtroFecha;
            dsSpx1.ordenServicio.Clear();
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            dsSpx1.ordenServicio.Merge(objData.ejecutarConsulta(sql).Tables[0]);
        }
        private void cargarTiposServicios(string codFiltro, string filtroFecha)
        {
            string sql = "set dateformat ymd  select ordenservicio.* from ordenservicio" +
                " join TipoServicio on TipoServicio.codTipoServicio = ordenServicio.codTipoServicio " +
                " where nombretipoServicio='" + codFiltro + "'and " + filtroFecha;
            dsSpx1.ordenServicio.Clear();
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            dsSpx1.ordenServicio.Merge(objData.ejecutarConsulta(sql).Tables[0]);
        }
        private void cargarInternas(string codFiltro, string filtroFecha)
        {
            string sql = "set dateformat ymd  select ordenservicio.* from ordenservicio" +
         " join prioridadesOrdenServicio on  prioridadesOrdenServicio.codPrioridadOS = ordenServicio.codPrioridadOS  " +
         " where prioridadesOrdenServicio.esOrdenInterna =1 and prioridadesOrdenServicio.nombre='" + codFiltro + "'and " + filtroFecha;
            dsSpx1.ordenServicio.Clear();
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            dsSpx1.ordenServicio.Merge(objData.ejecutarConsulta(sql).Tables[0]);
        }
        private void cargarExternas(string codFiltro, string filtroFecha)
        {
            string sql = "set dateformat ymd  select ordenservicio.* from ordenservicio" +
           " join prioridadesOrdenServicio on  prioridadesOrdenServicio.codPrioridadOS = ordenServicio.codPrioridadOS  " +
           " where prioridadesOrdenServicio.esOrdenInterna =0 and prioridadesOrdenServicio.nombre='" + codFiltro + "'and " + filtroFecha;
            dsSpx1.ordenServicio.Clear();
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            dsSpx1.ordenServicio.Merge(objData.ejecutarConsulta(sql).Tables[0]);
        }
        private void cargarCantidad(string codFiltro, string filtroFecha)
        {
            string strtmp = "";
            if (codFiltro == "Para Hoy")
            {
                strtmp = "WHERE datediff(day,getdate(),fechaProgramacion) =0and " + filtroFecha;
            }
            else if (codFiltro == "Para Mañana")
            {
                strtmp = "WHERE datediff(day,getdate(),fechaProgramacion) =1and " + filtroFecha;
            }
            else if (codFiltro == "Vencidos Menos de Una Semana")
            {
                strtmp = "where datediff(day,getdate(),fechaProgramacion) <0 and datediff(day,getdate(),fechaProgramacion)>-7 and " + filtroFecha;
            }
            else if (codFiltro == "Vencidos Mas de Una Semana")
            {
                strtmp = "WHERE datediff(day,getdate(),fechaProgramacion) < (-7) and " + filtroFecha;
            }

            string sql = "set dateformat dmy select ordenServicio.* from ordenServicio " + strtmp;
            dsSpx1.ordenServicio.Clear();
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
       
            dsSpx1.ordenServicio.Merge(objData.ejecutarConsulta(sql).Tables[0]);
        }


        private void frmListadoEstadisticosGrilla_FormClosing(object sender, FormClosingEventArgs e)
        {
            objTmp.Visible = true;
            objTmp.Focus();
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel objExcel= new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            objExcel.exportar(grddatos,"Ordenes de Servicio "+filtro+" "+codFiltro,false);
        }

        private void btnVerOrden_Click(object sender, EventArgs e)
        {
            if(grddatos.Columns[0].Text.Trim() == string.Empty)return;

            frmNuevaOrdenTrabajo frmObj= new frmNuevaOrdenTrabajo();
            frmObj.CodOrdenServicio= grddatos.Columns[0].Text;
            frmObj.Show();
        }
    }
}
