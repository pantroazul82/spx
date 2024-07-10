using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.contratos
{
    public partial class frmListadoContratos : Form
    {
        public frmListadoContratos()
        {
            InitializeComponent();
            controladorColumnas1.grilla = grdDatos;
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void buscar() 
        {

            if (cmbFiltro.Text.Trim() == "Numero Contrato")
            {
                pltListadoContratosTableAdapter1.FillByNumeroContrato(dsPlantillas1.pltListadoContratos,txtFiltro.Text);
            }
            else if (cmbFiltro.Text.Trim() == "Nit Cliente")
            {
                pltListadoContratosTableAdapter1.FillByNitCliente(dsPlantillas1.pltListadoContratos,txtFiltro.Text);
            }if(cmbFiltro.Text.Trim() == "Nombre Cliente")
            {
                pltListadoContratosTableAdapter1.FillByNombreCliente(dsPlantillas1.pltListadoContratos,txtFiltro.Text);
            }
            if (cmbFiltro.Text.Trim() == "Socio de Negocio")
            {
                pltListadoContratosTableAdapter1.FillByNumeroSocio(dsPlantillas1.pltListadoContratos,txtFiltro.Text);
            }
            
            System.Media.SystemSounds.Exclamation.Play();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dsPlantillas1.pltListadoContratos.Clear();
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel objexcel = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            objexcel.exportar(grdDatos, "Contratos", false);
            
        }

        private void btnVerProgramacion_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["numeroContrato"].Text.Trim() == string.Empty) return;

            frmNuevoContrato objFrm = new frmNuevoContrato();
            objFrm.NumeroContrato = grdDatos.Columns["numeroContrato"].Text.Trim();
            objFrm.Show();

        }

        private void btnFiltrarxEstado_Click(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            if (cmbMeses.Text.Trim() == string.Empty) return;
            pltListadoContratosTableAdapter1.FillByFechaVencimiento(dsPlantillas1.pltListadoContratos,(decimal)n.Year,
                (decimal)(cmbMeses.SelectedIndex+1));
            System.Media.SystemSounds.Exclamation.Play();
        }

        private void frmListadoContratos_Load(object sender, EventArgs e)
        {
            cmbFiltro.SelectedIndex = 0;
        }

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscar();
            }

        }
    }
}
