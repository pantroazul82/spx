using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.ordenesTrabajo
{
    public partial class frmSolicitudInsumos : Form
    {
        public frmSolicitudInsumos()
        {
            InitializeComponent();
        }

        private string codOrdenServicio = "";
        private string codSolicitud = "";

        public string CodOrdenServicio { set { codOrdenServicio = value; } get { return codOrdenServicio; } }
        public string CodSolicitud { set { codSolicitud = value; } get { return codSolicitud; } }


        private void chkAceptada_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtTiempoEstimado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar>20 && !char.IsDigit(e.KeyChar) && !(e.KeyChar.ToString() == System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator))
                e.Handled=true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
        private bool apruebaSolicitud = false;
        private void frmSolicitudInsumos_Load(object sender, EventArgs e)
        {
            unidadTiempoTableAdapter1.Fill(dsSpx1.unidadTiempo);
            cargar();
        }

        private void cargar() 
        {
          if (codSolicitud.Trim() != string.Empty)
            {
                txtNumeroSolicitud.Text = codSolicitud;
                solicitudInsumosTableAdapter1.FillBycodOrdenServiciocodSolicitud(dsSpx1.solicitudInsumos, int.Parse(codOrdenServicio), int.Parse(codSolicitud));
                pltDetalleSolicitudInsumosTableAdapter1.FillByCodigoOrdenCodSolicitud(dsSpx1.pltDetalleSolicitudInsumos, int.Parse(codOrdenServicio), int.Parse(codSolicitud));
                txtConsecutivoGeneral.Text = dsSpx1.solicitudInsumos[0].idSolictudInsumos.ToString();
              if (!dsSpx1.solicitudInsumos[0].IsaceptadaNull())
                {
                    clsTusuario1.FillBylogin(dsSPXSeguridad1.usuario, dsSpx1.solicitudInsumos[0].aprobadaPor);
                    txtAprobadaPor.Text = dsSPXSeguridad1.usuario[0].nombre; ;
                    chkAceptada.Checked = dsSpx1.solicitudInsumos[0].aceptada;
                    chkCancelada.Checked = !dsSpx1.solicitudInsumos[0].aceptada;
                    datecalFechaAprobacion.Value = dsSpx1.solicitudInsumos[0].fechaAprobacion;
                    btnModificar.Enabled = false;
                    btnAgregarRepuesto.Enabled = false;
                    btnEliminarRepuesto.Enabled = false;
                    //
                    txtNumerofactura.ReadOnly = true;
                    txtObservaciones.ReadOnly = true;
                    nmHorasMantenimientoPreventivo.Enabled = false;
                    nmManteCorrectivo.Enabled = false;
                    txtTiempoEstimado.ReadOnly = true;
                    btnAprobar.Visible = false;
                    btnRechazar.Visible = false;
                }
              if (!dsSpx1.solicitudInsumos[0].IscodUnidadTiempoNull())
              cmbtiempo.SelectedValue = dsSpx1.solicitudInsumos[0].codUnidadTiempo.ToString();
                txtTiempoEstimado.Text = dsSpx1.solicitudInsumos[0].tiempoEstimadoEntrega.ToString();
                txtObservaciones.Text = dsSpx1.solicitudInsumos[0].observaciones;
                txtNumerofactura.Text = dsSpx1.solicitudInsumos[0].numeroFactura;
                nmManteCorrectivo.Value = (decimal)dsSpx1.solicitudInsumos[0].horasMantCorrectivo;
                nmHorasMantenimientoPreventivo.Value = (decimal)dsSpx1.solicitudInsumos[0].horasMantPreventivo;
                nmManteCorrectivo.Value = (decimal)dsSpx1.solicitudInsumos[0].horasMantCorrectivo;
                nmHorasDiagnostico.Value = (decimal)dsSpx1.solicitudInsumos[0].horasDiagnostico;
                //ahora miramos si la persona puede aprobar o rechazar los insumos
                apruebaSolicitud = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1013);
                if (!apruebaSolicitud)
                {
                    btnAprobar.Visible = false;
                    btnRechazar.Visible = false;
                }
            }else {
                txtNumeroSolicitud.Text = solicitudInsumosTableAdapter1.verNextId(int.Parse(codOrdenServicio)).ToString();
                btnAprobar.Visible = false;
                btnRechazar.Visible = false;
            }
        
        }

        private void btnAgregarRepuesto_Click(object sender, EventArgs e)
        {
            if (codSolicitud.Trim() == string.Empty)
            {
                MessageBox.Show("Para agregar repuestos debe grabar primero el encabezado!!");
                return;
            }
            frmRepuesto fr = new frmRepuesto();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                int id = int.Parse(detalleSolicitudInsumosTableAdapter1.verNextId(int.Parse(CodOrdenServicio), int.Parse(codSolicitud)).ToString());
                detalleSolicitudInsumosTableAdapter1.Insert(int.Parse(CodOrdenServicio), int.Parse(codSolicitud), id, fr.codigoRepuesto, fr.cantidad);
                pltDetalleSolicitudInsumosTableAdapter1.FillByCodigoOrdenCodSolicitud(dsSpx1.pltDetalleSolicitudInsumos, int.Parse(codOrdenServicio), int.Parse(codSolicitud));

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (grdDetalleSolicitud.Columns["codDetalle"].Text.Trim() == string.Empty)
            {
                return;
            }
            frmRepuesto fr = new frmRepuesto();
            fr.cantidad = int.Parse( grdDetalleSolicitud.Columns["cantidad"].Text.Trim());
            fr.codigoRepuesto = grdDetalleSolicitud.Columns["codRepuesto"].Text.Trim();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                detalleSolicitudInsumosTableAdapter1.UpdateQuery(fr.codigoRepuesto, fr.cantidad,
                    int.Parse(CodOrdenServicio), int.Parse(codSolicitud), int.Parse(grdDetalleSolicitud.Columns["codDetalle"].Text.Trim()));
                pltDetalleSolicitudInsumosTableAdapter1.FillByCodigoOrdenCodSolicitud(dsSpx1.pltDetalleSolicitudInsumos, int.Parse(codOrdenServicio), int.Parse(codSolicitud));

            }
        }

        private void btnEliminarRepuesto_Click(object sender, EventArgs e)
        {
            if (grdDetalleSolicitud.Columns["codDetalle"].Text.Trim() == string.Empty)
            {
                return;
            }
            if (MessageBox.Show("Esta seguro de eliminar este repuesto de la solicitud?", "Eliminar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                detalleSolicitudInsumosTableAdapter1.DeleteCodOrdenCodSolicitudCodDetalle
                    (int.Parse(CodOrdenServicio), int.Parse(codSolicitud),int.Parse(grdDetalleSolicitud.Columns["codDetalle"].Text.Trim()));
                pltDetalleSolicitudInsumosTableAdapter1.FillByCodigoOrdenCodSolicitud(dsSpx1.pltDetalleSolicitudInsumos, int.Parse(codOrdenServicio), int.Parse(codSolicitud));

            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                guardar();
            }
        }
        private bool validar() 
        {
            if (txtTiempoEstimado.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese el tiempo estimado de trabajo.");
                return false;
            }
            if (cmbtiempo.SelectedValue == null || cmbtiempo.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese la unidad de tiempo para el estimado.");
                return false;
            }
            return true;
        
        }
        
        private void guardar() 
        {
         
            if (codSolicitud.Trim() == string.Empty)
            {//insertamos la orden
                Nullable<bool> boolNullo = new Nullable<bool>();
                Nullable<DateTime> fechaNullo = new Nullable<DateTime>();

                int siguienteId = int.Parse(solicitudInsumosTableAdapter1.verNextId(int.Parse(codOrdenServicio)).ToString());
                solicitudInsumosTableAdapter1.Insert(int.Parse(codOrdenServicio), siguienteId, null, null, null,
                    txtNumerofactura.Text, (double)nmHorasMantenimientoPreventivo.Value, (double)nmManteCorrectivo.Value, int.Parse(txtTiempoEstimado.Text),
                    txtObservaciones.Text,DateTime.Now,(double)nmHorasDiagnostico.Value,null,boolNullo,fechaNullo,int.Parse(cmbtiempo.SelectedValue.ToString()) );
                txtNumeroSolicitud.Text = siguienteId.ToString();
                codSolicitud = txtNumeroSolicitud.Text;
                solicitudInsumosTableAdapter1.FillBycodOrdenServiciocodSolicitud(dsSpx1.solicitudInsumos, int.Parse(codOrdenServicio), siguienteId);
            }
            else {
                solicitudInsumosTableAdapter1.FillBycodOrdenServiciocodSolicitud(dsSpx1.solicitudInsumos, int.Parse(codOrdenServicio), int.Parse(codSolicitud));
                if (dsSpx1.solicitudInsumos[0].IsaceptadaNull())
                {
                    solicitudInsumosTableAdapter1.UpdateQuery(null, null, null, txtNumerofactura.Text,
                        (double)nmHorasMantenimientoPreventivo.Value, (double)nmManteCorrectivo.Value, int.Parse(txtTiempoEstimado.Text),
                        txtObservaciones.Text,(double)nmHorasDiagnostico.Value,int.Parse(cmbtiempo.SelectedValue.ToString()), int.Parse(codOrdenServicio), int.Parse(codSolicitud));
                }else {
                    solicitudInsumosTableAdapter1.UpdateQuery(dsSpx1.solicitudInsumos[0].aceptada,
                        dsSpx1.solicitudInsumos[0].aprobadaPor, dsSpx1.solicitudInsumos[0].fechaAprobacion, txtNumerofactura.Text,
                        (double)nmHorasMantenimientoPreventivo.Value, (double)nmManteCorrectivo.Value, int.Parse(txtTiempoEstimado.Text),
                        txtObservaciones.Text, (double)nmHorasDiagnostico.Value,int.Parse(cmbtiempo.SelectedValue.ToString()), int.Parse(codOrdenServicio), int.Parse(codSolicitud));
                
                }
                //ahora vamos con el detalle
                detalleSolicitudInsumosTableAdapter1.Update(dsSpx1.detalleSolicitudInsumos);
                dsSpx1.detalleSolicitudInsumos.AcceptChanges();

            }
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            if(txtNumerofactura.Text.Trim()== string.Empty)
            {
                MessageBox.Show("El numero de la factura es necesaria para aprobar la orden!");
                return;
            }
            solicitudInsumosTableAdapter1.updateAprobar(true, SPXSeguridad.logica.sesion.LoginUsuarioAutenticado,
                int.Parse(codOrdenServicio), int.Parse(codSolicitud));
            cargar();
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            solicitudInsumosTableAdapter1.updateAprobar(false,SPXSeguridad.logica.sesion.LoginUsuarioAutenticado,
                int.Parse(codOrdenServicio),int.Parse(codSolicitud));
            cargar();
        }

        private void btnGrabarSalir_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                guardar();

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnAgregarRepuesto_ControlRemoved(object sender, ControlEventArgs e)
        {

        }

        private void txtObservaciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (codSolicitud.Trim() == string.Empty) return;
            if (codOrdenServicio.Trim() == string.Empty) return;

            string ruta = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter objDef = new SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter();
            objDef.Fill(dsSpx1.defaults);

            C1.C1Report.C1Report reporte = new C1.C1Report.C1Report();
            reporte.Load(ruta + @"\rpt\rpt.xml", "rptInsumos");
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
            if (reporte.Fields.Contains("lblTitulo"))
            {
                reporte.Fields["lblTitulo"].Value = dsSpx1.defaults[0].nombreReporteInsumos.Trim();
            }
            if (reporte.Fields.Contains("lblVersion"))
            {
                reporte.Fields["lblVersion"].Value = dsSpx1.defaults[0].versionReporteInsumos.Trim();
            }
            if (reporte.Fields.Contains("lblTipoDocumento"))
            {
                if (!dsSpx1.defaults[0].IscodigoReporteInsumosNull())
                    reporte.Fields["lblTipoDocumento"].Value = dsSpx1.defaults[0].codigoReporteInsumos.Trim();
            }
            if (reporte.Fields.Contains("lblVigencia"))
            {
                if (!dsSpx1.defaults[0].IsfechaVigenciaReporteInsumosNull())
                    reporte.Fields["lblVigencia"].Value = dsSpx1.defaults[0].fechaVigenciaReporteInsumos.ToShortDateString();
            }
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            reporte.DataSource.ConnectionString = objData.CadenaConexionReportes;
            reporte.DataSource.RecordSource = reporte.DataSource.RecordSource.Replace("<<codigoOrden>>", codOrdenServicio);
            reporte.DataSource.RecordSource = reporte.DataSource.RecordSource.Replace("<<codigoSolicitud>>",codSolicitud);
            var  frmRpt = new SPControladoraDatos.artefactos.SPXQuery.frm.Reportes.frmReporte (reporte);
            frmRpt.Icon = this.Icon;
            frmRpt.Show();
        }
    }
}