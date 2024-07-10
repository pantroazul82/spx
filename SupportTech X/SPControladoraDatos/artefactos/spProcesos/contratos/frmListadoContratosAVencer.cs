using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.contratos
{
    public partial class frmListadoContratosAVencer : Form
    {
        public frmListadoContratosAVencer()
        {
            InitializeComponent();
            controladorColumnas1.grilla = grdDatos;
        }

        private void frmListadoContratosAVencer_Load(object sender, EventArgs e)
        {
            eventosEncendidos = false;
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            calfechaVencimiento.Value = n.AddDays(-5);
            calVencimientoHasta.Value =n.AddDays(-1 * n.Day).AddDays(DateTime.DaysInMonth(n.Year, n.Month));
            
            cmbFiltro.SelectedIndex = 0;
            eventosEncendidos = true;
            buscar();
        }

        private void btnVerProgramacion_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["numeroContrato"].Text.Trim() == string.Empty) return;

            frmNuevoContrato objFrm = new frmNuevoContrato();
            objFrm.NumeroContrato = grdDatos.Columns["numeroContrato"].Text.Trim();
            objFrm.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dsPlantillas1.pltListaContratosVencimiento.Clear();
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            obj.exportar(grdDatos, "Contratos", false);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }
        private void buscar()
        {
            dsPlantillas1.pltListaContratosVencimiento.Clear();
            if (txtFiltro.Text.Trim() == string.Empty)
            {
                pltListaContratosVencimientoTableAdapter1.FillByFechas(dsPlantillas1.pltListaContratosVencimiento, calfechaVencimiento.Value,
                    calVencimientoHasta.Value);
            }else if (cmbFiltro.Text.Trim() == "Numero Contrato")
            {
                pltListaContratosVencimientoTableAdapter1.FillByNumeroContrato(dsPlantillas1.pltListaContratosVencimiento, calfechaVencimiento.Value,
                    calVencimientoHasta.Value, txtFiltro.Text);
            }
            else if (cmbFiltro.Text.Trim() == "Nit Cliente")
            {
                pltListaContratosVencimientoTableAdapter1.FillByFechasNitCliente(dsPlantillas1.pltListaContratosVencimiento, calfechaVencimiento.Value,
                    calVencimientoHasta.Value, txtFiltro.Text);
            }else if (cmbFiltro.Text.Trim() == "Nombre Cliente")
            {
                pltListaContratosVencimientoTableAdapter1.FillByFechasNombreCliente(dsPlantillas1.pltListaContratosVencimiento, calfechaVencimiento.Value,
                    calVencimientoHasta.Value, txtFiltro.Text);
            }else if (cmbFiltro.Text.Trim() == "Tipo de Contrato")
            {
                pltListaContratosVencimientoTableAdapter1.FillByFechasTipoContrato(dsPlantillas1.pltListaContratosVencimiento, calfechaVencimiento.Value,
                    calVencimientoHasta.Value, txtFiltro.Text);
            }
            else if (cmbFiltro.Text.Trim() == "Modalidad")
            {
                pltListaContratosVencimientoTableAdapter1.FillByFechasModalidad(dsPlantillas1.pltListaContratosVencimiento, calfechaVencimiento.Value,
                    calVencimientoHasta.Value, txtFiltro.Text);
            }

            


            System.Media.SystemSounds.Exclamation.Play();
        }

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buscar();
        }
        bool eventosEncendidos = true;
        private void calVencimientoHasta_ValueChanged(object sender, EventArgs e)
        {
            if (!eventosEncendidos) return;
            buscar();
        }

        private void calfechaVencimiento_ValueChanged(object sender, EventArgs e)
        {
            if (!eventosEncendidos) return;
            buscar();
        }

        private void grdDatos_FetchRowStyle(object sender, C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            DateTime f = dsPlantillas1.pltListaContratosVencimiento[grdDatos.RowBookmark(e.Row)].fechaFinContrato;
            if (n.Subtract(f).TotalDays > 0)
            {e.CellStyle.BackColor = Color.FromArgb(241, 221, 220); 
              
            }else
                if (n.Subtract(f).TotalDays >= -15)
                {
                    e.CellStyle.BackColor = Color.LightCyan;
                    
                }else if (n.Subtract(f).TotalDays >= -30)
                {
                     e.CellStyle.BackColor = Color.LightGreen;      
                }
        }
    }
}
