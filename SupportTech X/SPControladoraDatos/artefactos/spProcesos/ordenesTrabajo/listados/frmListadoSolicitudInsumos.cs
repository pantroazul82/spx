using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.ordenesTrabajo.listados
{
    public partial class frmListadoSolicitudInsumos : Form
    {
        public frmListadoSolicitudInsumos()
        {
            InitializeComponent();
            controladorColumnas1.grilla = grdDatos;
        }

        private void frmListadoSolicitudInsumos_Load(object sender, EventArgs e)
        {
            //
            solicitudInsumosTableAdapter1.FillByTop100(dsSpx1.solicitudInsumos);
            cmbCampo.SelectedIndex = 0;
            cmbEstados.SelectedIndex = 0;
            veTodas = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1013);
        }
        bool veTodas = false;

        private void btnVerLlamada_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["codOrdenServicio"].Text.Trim() == string.Empty) return;
            if (grdDatos.Columns["codSolicitud"].Text.Trim() == string.Empty) return;
            spProcesos.ordenesTrabajo.frmSolicitudInsumos fm = new frmSolicitudInsumos();
            fm.CodOrdenServicio = grdDatos.Columns["codOrdenServicio"].Text;
            fm.CodSolicitud = grdDatos.Columns["codSolicitud"].Text.Trim();
            fm.Show();
        }

        private void buscar()
        {
            string sql = " select solicitudInsumos.* from solicitudInsumos" +
                         " join ordenServicio " +
                         " on solicitudInsumos.codOrdenServicio = ordenServicio.codOrdenServicio";
            switch(cmbCampo.Text.Trim())
            {
                case "Cod Orden Servicio": { sql += " where ordenServicio.codOrdenServicio like '" + txtFiltro.Text + "%'"; break; }
                case "Cod Solicitud": { sql += " where solicitudInsumos.idSolictudInsumos like '" + txtFiltro.Text + "%'"; break; }
                case "Estado": { sql += filtroEstado(); break; }
                case "Numero factura": { sql += " where solicitudInsumos.numeroFactura like '" + txtFiltro.Text + "%'"; break; }
                case "Serial": { sql += " where ordenServicio.serial like '" + txtFiltro.Text + "%'"; break; }
                case "Nit Cliente": { sql += " where ordenServicio.nitCliente like '"+txtFiltro.Text+"%'"; break; }
            }
            if (!veTodas)
            {
                sql += " and ordenServicio.asignadoA = '"+SPXSeguridad.logica.sesion.LoginUsuarioAutenticado+"'";
            }
            dsSpx1.solicitudInsumos.Clear();
            SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
            dsSpx1.solicitudInsumos.Merge(obj.ejecutarConsulta(sql).Tables[0]);
            System.Media.SystemSounds.Exclamation.Play();
        }

        private string filtroEstado() 
        {
            string sql = "";
            switch (cmbEstados.Text.Trim())
            {
                case "Por Aprobar": { sql = " where solicitudInsumos.aceptada is null "; break; }
                case "Aceptadas": { sql = " where solicitudInsumos.aceptada is not null and aceptada =1 "; break; }
                case "Rechazadas": { sql = " where solicitudInsumos.aceptada is not null and aceptada =0 "; break; }
            }
            return sql;
        }

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscar();
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCampo.Text.Trim() == "Estado")
            {
                cmbEstados.Visible = true;
                txtFiltro.Visible = false;
            }else{
                cmbEstados.Visible = false;
                txtFiltro.Visible = true;
            }
        }

        private void cmbEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEstados.Visible)
            {
                buscar();
            }
        }
    }
}
