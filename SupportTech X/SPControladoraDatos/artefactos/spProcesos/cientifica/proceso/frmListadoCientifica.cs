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
    public partial class frmListadoCientifica : Form
    {
        public frmListadoCientifica()
        {
            InitializeComponent();
            controladorColumnas1.grilla = grdDatos;
        }

        private string sentenciaMaestra() 
        {
            string sql = @"
select 
usuario.nombre 'interno',ind_interna,
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
left join usuario on usuario.login = asesoria_cientifica.usuario_interna
";
            return sql;
        }

        private void frmListadoCientifica_Load(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            calFin.Value = n;
            calInicio.Value = n.AddMonths(-2);
            cmbFiltro.SelectedIndex = 0;
        }

        private void buscar()
        {
            string sql ="set dateformat ymd "+ sentenciaMaestra();
            //agregamos los filtros de fecha
            sql = sql + " WHERE asesoria_cientifica.fecha_solicitud between '" +
            calInicio.Value.Year + @"/" + calInicio.Value.Month.ToString().PadLeft(2, '0') + @"/" + calInicio.Value.Day.ToString().PadLeft(2, '0') + "'" +
            " AND '" + calFin.Value.AddDays(1).Year + @"/" + calFin.Value.AddDays(1).Month.ToString().PadLeft(2, '0') + @"/" + calFin.Value.AddDays(1).Day.ToString().PadLeft(2, '0') + "'";
            //vamos con los filtros adcionales
            switch(cmbFiltro.Text)
            {
                case "Cod Asesoria":{ sql=sql+" and asesoria_cientifica.cod_asesoria_cientifica like '"+txtFiltro.Text+"%'"; break;}
                    case "Reactivo":{sql=sql+" and referencia_reactivo.nombre_referencia_reactivo like '"+txtFiltro.Text+"%'"; break;}
                    case "Cliente":{sql=sql+" and clientes.nombreCliente like '"+txtFiltro.Text+"%'"; break;}
                    case "Nit Cliente":{sql=sql+" and asesoria_cientifica.nitCliente like '"+txtFiltro.Text+"%'"; break;}
            }
            sql = sql + " order by asesoria_cientifica.cod_asesoria_cientifica desc";
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmNuevaAsesoria fr=new frmNuevaAsesoria();
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            { 
                buscar();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if(grdDatos.Columns["cod_asesoria_cientifica"].Text.Trim() == string.Empty)return;
            //verficamos el estado del movimiento
            int est= int.Parse(grdDatos.Columns["cod_estado_asesoria_cientifica"].Text.Trim());
            estado_asesoria_cientificaTableAdapter1.FillBycod_estado_asesoria_cientifica(dsSpx1.estado_asesoria_cientifica, est);
            if (dsSpx1.estado_asesoria_cientifica[0].cod_manual.Trim() == "2" )
            { 
                //validamos si tiene permiso para editar la informacion de aceptacion
                if (SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1020))
                {
                    frmAceptarOrden frAc = new frmAceptarOrden();
                    frAc.editarOrden = true;
                    frAc.codAsesoria = int.Parse(grdDatos.Columns["cod_asesoria_cientifica"].Text);
                    if (frAc.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        buscar();
                        
                    }return;
                }else {
                    MessageBox.Show("Acceso Denegado, no puede editar esta orden en este estado", "No tiene permisos suficientes");
                    return;
                }
            }
            else if (dsSpx1.estado_asesoria_cientifica[0].cod_manual.Trim() != "1")
            { 
                MessageBox.Show("La asesoria no se puede modificar en este estado!","No tiene permisos suficientes");
                return;
            }
            //verficamos permisos de edicion
            else if (!SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1053))
            {
                      MessageBox.Show("Acceso Denegado","No tiene permisos suficientes");
                return;
            }else{
            frmNuevaAsesoria fr = new frmNuevaAsesoria();
            fr.codAsesoria = int.Parse(grdDatos.Columns["cod_asesoria_cientifica"].Text);
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                buscar();
            }
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            int est = int.Parse(grdDatos.Columns["cod_estado_asesoria_cientifica"].Text.Trim());
            estado_asesoria_cientificaTableAdapter1.FillBycod_estado_asesoria_cientifica(dsSpx1.estado_asesoria_cientifica, est);
            if (dsSpx1.estado_asesoria_cientifica[0].cod_manual.Trim() == "5")
            {
                MessageBox.Show("No puede anular un movimiento ya anulado!", "Error");
                return;
            }
            //verificamos permisos
            if (!SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1008))
            {
                MessageBox.Show("No tiene los suficientes permisos para realizar esta accion","Acceso denegado");
                return;
            }
            if (MessageBox.Show("Esta seguro de anular el movimiento?", "Confirmacion", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                cientifica.proceso.frmMotivoAnulacion fr = new frmMotivoAnulacion();
                fr.codAsesoria= int.Parse(grdDatos.Columns["cod_asesoria_cientifica"].Text) ;
                if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    buscar();
                }
            }
        }

        public int buscarAsesoria(int asesoria) 
        {
            for (int k = 0; k < grdDatos.RowCount; k++)
            {
                if (grdDatos[k, "cod_asesoria_cientifica"].ToString() == asesoria.ToString())
                {
                    return k;
                }
            }
            return 0;
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_asesoria_cientifica"].Text.Trim() == string.Empty) return;
            //verficamos el estado del movimiento
            int est = int.Parse(grdDatos.Columns["cod_estado_asesoria_cientifica"].Text.Trim());
            int asesoria = int.Parse(grdDatos.Columns["cod_asesoria_cientifica"].Text.Trim());

            estado_asesoria_cientificaTableAdapter1.FillBycod_estado_asesoria_cientifica(dsSpx1.estado_asesoria_cientifica, est);
            if (dsSpx1.estado_asesoria_cientifica[0].cod_manual.Trim() == "1")
            {
                frmAceptarOrden fr = new frmAceptarOrden();
                fr.codAsesoria = int.Parse(grdDatos.Columns["cod_asesoria_cientifica"].Text);
                if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    buscar();
                }
            }else
                if (dsSpx1.estado_asesoria_cientifica[0].cod_manual.Trim() == "2" || dsSpx1.estado_asesoria_cientifica[0].cod_manual.Trim() == "3"
                    || dsSpx1.estado_asesoria_cientifica[0].cod_manual.Trim() == "31" || dsSpx1.estado_asesoria_cientifica[0].cod_manual.Trim() == "32")
                {
                    frmEnseguimiento fr = new frmEnseguimiento();
                    fr.codAsesoria = int.Parse(grdDatos.Columns["cod_asesoria_cientifica"].Text);
                    if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        buscar();
                    }
                }else 
            if (dsSpx1.estado_asesoria_cientifica[0].cod_manual.Trim() == "4" )
            {
                frmEnseguimiento fr = new frmEnseguimiento();
                fr.editable = false;
                fr.codAsesoria = int.Parse(grdDatos.Columns["cod_asesoria_cientifica"].Text);
                if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    buscar();
                }
            }
                else {
                    MessageBox.Show("Una orden cerrada o anulada no se puede ejecutar");
                }

           // grdDatos.SelectedRows.Add();
            grdDatos.Row = buscarAsesoria(asesoria);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_asesoria_cientifica"].Text.Trim() == string.Empty) return;
            //verficamos el estado del movimiento
            int est = int.Parse(grdDatos.Columns["cod_estado_asesoria_cientifica"].Text.Trim());
            int asesoria = int.Parse(grdDatos.Columns["cod_asesoria_cientifica"].Text.Trim());
            string ruta = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            //cargamos la informacion de calidad de los formatos
            parametro_cientificaTableAdapter1.Fill(dsSpx1.parametro_cientifica);
            if (dsSpx1.parametro_cientifica.Count <= 0)
            {
                MessageBox.Show("No tiene configurado la informacion de los formatos para las asesorias cientificas!");
                return;
            }
            string strReporte = "rptCientifica";

            C1.C1Report.C1Report reporte = new C1.C1Report.C1Report();
            reporte.Load(ruta + @"\rpt\rpt.xml", strReporte);
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            reporte.DataSource.ConnectionString = objData.CadenaConexionReportes;
            defaultsTableAdapter1.Fill(dsSpx1.defaults);
            if (!dsSpx1.defaults[0].IslogotipoNull())
            {
                byte[] arr = (byte[])dsSpx1.defaults[0].logotipo;
                System.IO.Stream stream = new System.IO.MemoryStream(arr);
                Image im = Image.FromStream(stream);
                if (reporte.Fields.Contains("picLogo"))
                {
                    reporte.Fields["picLogo"].Picture = im;
                }
            }
          
                if (reporte.Fields.Contains("lblCodigoDocumento"))
                {
                    reporte.Fields["lblCodigoDocumento"].Value = dsSpx1.parametro_cientifica[0].codigo_documento_llamada.Trim();
                }
                if (reporte.Fields.Contains("lblImplementacionDocumento"))
                {
                    reporte.Fields["lblImplementacionDocumento"].Value = dsSpx1.parametro_cientifica[0].implementacion_documento_llamada.Trim();
                }
                if (reporte.Fields.Contains("lblTipoDocumentoLlamada"))
                {
                    reporte.Fields["lblTipoDocumentoLlamada"].Value = dsSpx1.parametro_cientifica[0].tipo_documento_llamada.Trim();
                }
                if (reporte.Fields.Contains("lblVersionFormatoLlamada"))
                {
                    reporte.Fields["lblVersionFormatoLlamada"].Value = dsSpx1.parametro_cientifica[0].version_formato_llamada.Trim();
                }

                if (reporte.Fields.Contains("rptAcciones"))
                {
                 
                    reporte.Fields["rptAcciones"].Subreport.DataSource.ConnectionString = objData.CadenaConexionReportes;
                    reporte.Fields["rptAcciones"].Subreport.DataSource.RecordSource = reporte.Fields["rptAcciones"].Subreport.DataSource.RecordSource.Replace("<<cod_asesoria>>", asesoria.ToString());
                }


                reporte.DataSource.RecordSource = reporte.DataSource.RecordSource.Replace("<<cod_asesoria>>", asesoria.ToString());


            var  frmRpt = new SPControladoraDatos.artefactos.SPXQuery.frm.Reportes.frmReporte (reporte);
            frmRpt.Icon = this.Icon;

            frmRpt.ShowDialog();
        }

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buscar();
        }

        private void grdDatos_FetchRowStyle(object sender, C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs e)
        {
            if (grdDatos[grdDatos.RowBookmark(e.Row), "nombre_estado_asesoria_cientifica"].ToString().Trim() == "Nueva")
            { 
                e.CellStyle.BackColor = Color.LightCoral;
            }
            else if (grdDatos[grdDatos.RowBookmark(e.Row), "nombre_estado_asesoria_cientifica"].ToString().Trim() == "Abierta")
            {
                e.CellStyle.BackColor = Color.LightBlue;
            }
            else if (grdDatos[grdDatos.RowBookmark(e.Row), "nombre_estado_asesoria_cientifica"].ToString().Trim() == "En Seguimiento")
            {
                e.CellStyle.BackColor = Color.LightYellow;
            }
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_asesoria_cientifica"].Text.Trim() == string.Empty) return;
            //verficamos el estado del movimiento
            int asesoria = int.Parse(grdDatos.Columns["cod_asesoria_cientifica"].Text.Trim());
            frmGeneral fr = new frmGeneral();
            fr.codAsesoria = asesoria;
            fr.Show();
        }
    }
}
