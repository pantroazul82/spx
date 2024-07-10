using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.solicitudes
{
    public partial class frmMisSolicitudesPendientes : Form
    {
        public frmMisSolicitudesPendientes()
        {
            InitializeComponent();
            controladorColumnas1.grilla = grddatos;
        }

        private void frmMisOrdenesPendientes_Load(object sender, EventArgs e)
        {
            medioSolicitudTableAdapter1.Fill(dsSpx1.medioSolicitud);
            prioridadSolicitudTableAdapter1.Fill(dsSpx1.prioridadSolicitud);
            estadosSolicitudTableAdapter1.Fill(dsSpx1.estadosSolicitud);
            medioSolicitudTableAdapter1.Fill(dsSpx1.medioSolicitud);
            tipoServicioTableAdapter1.Fill(dsSpx1.TipoServicio);
            dsSpx1.EnforceConstraints = false;
            solicitudServicioTableAdapter1.FillByAsignadoA(dsSpx1.solicitudServicio, SPXSeguridad.logica.sesion.LoginUsuarioAutenticado);
            if (dsSpx1.solicitudServicio.Rows.Count <= 0)
            {
                MessageBox.Show("No tiene Solicitudes de servicio Pendientes en el momento.");
            }
        }

        private void btnVerOrden_Click(object sender, EventArgs e)
        {
            if (grddatos.Columns[0].Text.Trim() == string.Empty) return;
            spProcesos.solicitudes.frmSolicitudServicio frmObj = new frmSolicitudServicio();
            frmObj.CodSolicitud = int.Parse(grddatos.Columns[0].Text);
            frmObj.Show();
        }

        private void visibilidadEstado()
        {

            if (rdPendientesxAprobacion.Checked)
            {
                //grddatos.Columns["codEstadoOrdenServicio"].FilterText = "CERRA";
                //grddatos.Columns["codEstadoSolicitud"].FilterText = "1";
                dsSpx1.solicitudServicio.DefaultView.RowFilter = "codEstadoSolicitud='1'";
                dsSpx1.solicitudServicio.DefaultView.RowStateFilter = DataViewRowState.CurrentRows;
                //dsSpx1.solicitudServicio.codEstadoSolicitudColumn.Expression = "'1'";
            }
            else if (rdEnEjecucion.Checked)
            {
             //   grddatos.Columns["codEstadoSolicitud"].FilterText = "2";
                //dsSpx1.solicitudServicio.codEstadoSolicitudColumn.Expression = "'2'";
                dsSpx1.solicitudServicio.DefaultView.RowFilter = "codEstadoSolicitud='2'";
                dsSpx1.solicitudServicio.DefaultView.RowStateFilter = DataViewRowState.CurrentRows;
            }else{
//                dsSpx1.solicitudServicio.codEstadoSolicitudColumn.Expression = "";
                dsSpx1.solicitudServicio.DefaultView.RowFilter = "";
                dsSpx1.solicitudServicio.DefaultView.RowStateFilter = DataViewRowState.OriginalRows;
            }
        }

        private void rdTodas_CheckedChanged(object sender, EventArgs e)
        {
            visibilidadEstado();
        }

        private void rdProgramadas_CheckedChanged(object sender, EventArgs e)
        {
            visibilidadEstado();
        }

        private void rdEnEjecucion_CheckedChanged(object sender, EventArgs e)
        {
            visibilidadEstado();
        }

        private void rdPendientesxAprobacion_CheckedChanged(object sender, EventArgs e)
        {
            visibilidadEstado();
        }
    }
}
