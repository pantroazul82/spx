using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.cientifica
{
    public partial class frmPrioridadesCientificaListado : Form
    {
        public frmPrioridadesCientificaListado()
        {
            InitializeComponent();
        }

        private void frmPrioridadesCientificaListado_Load(object sender, EventArgs e)
        {
            prioridad_callcenter_cientificaTableAdapter1.Fill(dsSpx1.prioridad_callcenter_cientifica);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cientifica.frmPrioridadCientifica fr = new frmPrioridadCientifica();
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                prioridad_callcenter_cientificaTableAdapter1.Fill(dsSpx1.prioridad_callcenter_cientifica);
     
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_prioridad_callcenter_cientifica"].Text.Trim() == string.Empty)
                return;

            cientifica.frmPrioridadCientifica fr = new frmPrioridadCientifica();
            fr.codPrioridad = int.Parse(grdDatos.Columns["cod_prioridad_callcenter_cientifica"].Text);
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                prioridad_callcenter_cientificaTableAdapter1.Fill(dsSpx1.prioridad_callcenter_cientifica);

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_prioridad_callcenter_cientifica"].Text.Trim() == string.Empty)
                return;
            if (MessageBox.Show("Esta seguro de Eliminar el regitro","Confirmacion",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                prioridad_callcenter_cientificaTableAdapter1.DeleteQuery(int.Parse(grdDatos.Columns["cod_prioridad_callcenter_cientifica"].Text));
                prioridad_callcenter_cientificaTableAdapter1.Fill(dsSpx1.prioridad_callcenter_cientifica);

            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel o = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            o.exportarRapido(grdDatos, "Prioridades", false);
        }
    }
}
