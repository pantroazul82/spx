using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.cientifica.proceso
{
    public partial class frmEstadisticasCientificas : Form
    {
        public frmEstadisticasCientificas()
        {
            InitializeComponent();
        }

        private string sentenciaMaestra()
        {
            string sql = @"
select 

asesoria_cientifica.cod_asesoria_cientifica,
estado_asesoria_cientifica.nombre_estado_asesoria_cientifica,
 asesoria_cientifica.cod_estado_asesoria_cientifica, asesoria_cientifica.cod_prioridad_sugerida,
 prioridad_callcenter_cientifica.nombre_prioridad 'prioridad_sugerida', asesoria_cientifica.cod_prioridad_callcenter_cientifica, 
 p2.nombre_prioridad 'prioridad'  
  ,asesoria_cientifica.fecha_solicitud, asesoria_cientifica.usuario_creacion,
   asesoria_cientifica.nitCliente,clientes.nombreCliente, asesoria_cientifica.codSucursal,
   sucursalCliente.nombreSucursal,ciudades.nombreCiudad
   , asesoria_cientifica.codContacto, asesoria_cientifica.infAdicionalContacto, asesoria_cientifica.fecha_respuesta_inicial fechaRespuestaInicial,
    asesoria_cientifica.cod_referencia_reactivo,referencia_reactivo.nombre_referencia_reactivo,fabricante.nombre_fabricante 'fabricante_reactivo',
     asesoria_cientifica.motivo_consulta, asesoria_cientifica.respuesta_inicial, asesoria_cientifica.informacionSuministradaInicial,
      asesoria_cientifica.responsable, 
asesoria_cientifica.codFabricante,fabricante_1.nombre_fabricante, asesoria_cientifica.codModelo,Modelos.NombreModelo,
 asesoria_cientifica.serial, asesoria_cientifica.fecha_visita, asesoria_cientifica.dias_solucion, asesoria_cientifica.numero_reporte_qc,
  asesoria_cientifica.fecha_cierre, asesoria_cientifica.solucionado, 
asesoria_cientifica.no_porque, asesoria_cientifica.conforme, asesoria_cientifica.no_conforme_porque,
 asesoria_cientifica.cerrada_por, 
asesoria_cientifica.cod_inconveniente_presentado_cientifica,inconveniente_presentado_cientifica.nombre_inconveniente, 
asesoria_cientifica.cod_reactivo_cierre,
 asesoria_cientifica.lote_reactivo, asesoria_cientifica.vencimiento_reactivo, 
asesoria_cientifica.llamada_recibida_disponibilidad,
 asesoria_cientifica.cod_motivo_anulacion_cientifica,motivo_anulacion_cientifica.motivo_anulacion,
  asesoria_cientifica.informacionAdicionalAnulacion,
fecha_solicitud,

fecha_sugerida,fecha_primer_seguimiento,

DATEDIFF(day,fecha_solicitud,fecha_sugerida) - dbo.d_festivos (fecha_solicitud,fecha_sugerida) 'A',
DATEDIFF(day,fecha_solicitud,fecha_primer_seguimiento) - dbo.d_festivos (fecha_solicitud,fecha_primer_seguimiento) 'B',
DATEDIFF(day,fecha_solicitud,fecha_cerrada_seguimiento) - dbo.d_festivos (fecha_solicitud,fecha_cerrada_seguimiento) 'C',
DATEDIFF(day,fecha_solicitud,fecha_cierre) - dbo.d_festivos (fecha_solicitud,fecha_cierre) 'D',

DATEDIFF(day,fecha_sugerida,fecha_primer_seguimiento) - dbo.d_festivos (fecha_sugerida,fecha_primer_seguimiento) 'E',
DATEDIFF(day,fecha_sugerida,fecha_cerrada_seguimiento) - dbo.d_festivos (fecha_sugerida,fecha_cerrada_seguimiento) 'F',
DATEDIFF(day,fecha_sugerida,fecha_cierre) - dbo.d_festivos (fecha_sugerida,fecha_cierre) 'G',

DATEDIFF(day,fecha_primer_seguimiento,fecha_cerrada_seguimiento) - dbo.d_festivos (fecha_primer_seguimiento,fecha_cerrada_seguimiento) 'H',
DATEDIFF(day,fecha_primer_seguimiento,fecha_cierre) - dbo.d_festivos (fecha_primer_seguimiento,fecha_cierre) 'I',

DATEDIFF(day,fecha_cerrada_seguimiento,fecha_cierre) - dbo.d_festivos (fecha_cerrada_seguimiento,fecha_cierre) 'J'

 from asesoria_cientifica
left join inconveniente_presentado_cientifica on inconveniente_presentado_cientifica.cod_inconveniente_presentado_cientifica= asesoria_cientifica.cod_inconveniente_presentado_cientifica
INNER JOIN estado_asesoria_cientifica 
                      ON asesoria_cientifica.cod_estado_asesoria_cientifica = estado_asesoria_cientifica.cod_estado_asesoria_cientifica 
left JOIN prioridad_callcenter_cientifica
					 ON asesoria_cientifica.cod_prioridad_sugerida = prioridad_callcenter_cientifica.cod_prioridad_callcenter_cientifica 
left JOIN prioridad_callcenter_cientifica p2
                     ON asesoria_cientifica.cod_prioridad_callcenter_cientifica = p2.cod_prioridad_callcenter_cientifica 
left JOIN          clientes ON asesoria_cientifica.nitCliente = clientes.nitCliente 
left JOIN  sucursalCliente ON asesoria_cientifica.nitCliente = sucursalCliente.nitCliente AND asesoria_cientifica.codSucursal = sucursalCliente.codSucursal 
left join motivo_anulacion_cientifica on motivo_anulacion_cientifica.cod_motivo_anulacion_cientifica = asesoria_cientifica.cod_motivo_anulacion_cientifica
left JOIN referencia_reactivo ON asesoria_cientifica.cod_referencia_reactivo = referencia_reactivo.cod_referencia_reactivo 
left JOIN fabricante ON referencia_reactivo.codFabricante = fabricante.codFabricante 
left JOIN fabricante AS fabricante_1 ON asesoria_cientifica.codFabricante = fabricante_1.codFabricante
left JOIN Modelos ON asesoria_cientifica.codFabricante = Modelos.codFabricante AND asesoria_cientifica.codModelo =Modelos.codModelo 
left join ciudades on sucursalCliente.codDepartamento = ciudades.codDepartamento and sucursalCliente.codPais = ciudades.codPais and ciudades.codCiudad= sucursalCliente.codCiudad
";
            return sql;
        }

        private void frmEstadisticasCientificas_Load(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            calFin.Value = n;
            calInicio.Value = n.AddMonths(-2);
            cmbFiltro.SelectedIndex = 0;
            buscar();
        }

        private void buscar()
        {
            string sql = "set dateformat ymd " + sentenciaMaestra();
            //agregamos los filtros de fecha
            sql = sql + " WHERE asesoria_cientifica.fecha_solicitud between '" +
                calInicio.Value.Year + @"/" + calInicio.Value.Month.ToString().PadLeft(2, '0') + @"/" + calInicio.Value.Day.ToString().PadLeft(2, '0') +"'"+
                " AND '" + calFin.Value.AddDays(1).Year + @"/" + calFin.Value.AddDays(1).Month.ToString().PadLeft(2, '0') + @"/" + calFin.Value.AddDays(1).Day.ToString().PadLeft(2, '0')+"'";
            //vamos con los filtros adcionales
            switch (cmbFiltro.Text)
            {
                case "Cod Asesoria": { sql = sql + " and asesoria_cientifica.cod_asesoria_cientifica like '" + txtFiltro.Text + "%'"; break; }
                case "Reactivo": { sql = sql + " and referencia_reactivo.nombre_referencia_reactivo like '" + txtFiltro.Text + "%'"; break; }
                case "Cliente": { sql = sql + " and clientes.nombreCliente like '" + txtFiltro.Text + "%'"; break; }
                case "Nit Cliente": { sql = sql + " and asesoria_cientifica.nitCliente like '" + txtFiltro.Text + "%'"; break; }
            }
            dsPlantillas1.pltListadoCientifica.Clear();
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            dsPlantillas1.pltListadoCientifica.Merge(
                objData.ejecutarConsulta(sql).Tables[0]
                );
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buscar();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd=new SaveFileDialog();
            sd.Filter="Excel |*.xlsx";
            if(sd.ShowDialog() == System.Windows.Forms.DialogResult.OK){
                pivotGridControl1.ExportToXlsx(sd.FileName);
                //chartControl1.ExportToXls(sd.FileName);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Bar": { 
                    chartControl1.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Bar); break; }
                case "Bar Stacked 100%":
                    {
                        chartControl1.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.FullStackedBar3D); break;
                    }
                case "Bar 3d":
                    {
                        chartControl1.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Bar3D); break;
                    }
                case "Point":
                    {
                        chartControl1.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Point); break;
                    }
                case "Lineas":
                    {
                    chartControl1.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Line); break;
                    }
                case "Lineas 3d":
                    {
                        chartControl1.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Line3D); break;
                    }
                case "Pie":
                    {
                        chartControl1.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Pie); break;
                    }
                case "Dona":
                    {
                        chartControl1.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Doughnut); break;
                    }
                case "Pie 3d":
                    {
                        chartControl1.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Pie3D); break;
                    }
            }
        }

        private void btnInfoFechas_Click(object sender, EventArgs e)
        {
            frmInfoFechas fr = new frmInfoFechas();
            fr.Show();
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
        
            for (int k = 0; k < pivotGridControl1.Fields.Count; k++)
            {
                pivotGridControl1.Fields[k].Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
            }

            this.fieldcodasesoriacientifica.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            fieldprioridad.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            fieldnombreestadoasesoriacientifica.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < pivotGridControl1.Fields.Count; k++)
            {
                pivotGridControl1.Fields[k].Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
            }

            this.fieldcodasesoriacientifica.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            fieldD.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            fieldnombreestadoasesoriacientifica.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
       
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < pivotGridControl1.Fields.Count; k++)
            {
                pivotGridControl1.Fields[k].Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
            }

            this.fieldcodasesoriacientifica.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            fieldresponsable.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            fieldnombreestadoasesoriacientifica.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
      
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < pivotGridControl1.Fields.Count; k++)
            {
                pivotGridControl1.Fields[k].Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
            }

            this.fieldcodasesoriacientifica.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            fieldusuariocreacion.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            fieldnombreestadoasesoriacientifica.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
   
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < pivotGridControl1.Fields.Count; k++)
            {
                pivotGridControl1.Fields[k].Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
            }

            this.fieldcodasesoriacientifica.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            fieldnombreCiudad.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
           // fieldprioridad.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            fieldnombreestadoasesoriacientifica.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
   
        }
    }
}
