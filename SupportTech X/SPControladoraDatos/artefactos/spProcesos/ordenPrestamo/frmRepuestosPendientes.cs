using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.ordenPrestamo
{
    public partial class frmRepuestosPendientes : Form
    {
        public frmRepuestosPendientes()
        {
            InitializeComponent();
        }

        private void buscar() 
        {
            if (txtFiltro.Text.Trim() == "%")
            {
                pltRepuestosPendientesTableAdapter1.Fill(dsPlantillas1.pltRepuestosPendientes);
                return;
            }
            switch (cmbCampo.Text.Trim())
            {
                case "Responsable": {
                    pltRepuestosPendientesTableAdapter1.FillByResponsable(dsPlantillas1.pltRepuestosPendientes,
                         txtFiltro.Text);
                    break; }
                case "Repuesto": {
                    pltRepuestosPendientesTableAdapter1.FillByRepuesto(dsPlantillas1.pltRepuestosPendientes,
                        txtFiltro.Text);
                    break; }
            }
        }

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscar();
            }
        }

        private void frmRepuestosPendientes_Load(object sender, EventArgs e)
        {
            cmbCampo.SelectedIndex = 0;
            pltRepuestosPendientesTableAdapter1.Fill(dsPlantillas1.pltRepuestosPendientes);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dsPlantillas1.pltRepuestosPendientes.Clear();
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            obj.exportar(grdDatos, "Repuestos Pendientes", false);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }
    }
}
