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
    public partial class frmTareasAsesorias : Form
    {
        public frmTareasAsesorias()
        {
            InitializeComponent();
        }

        public int codAsesoria { set; get; }

        private void frmTareasAsesorias_Load(object sender, EventArgs e)
        {
            tarea_asesoria_cientificaTableAdapter1.FillBycod_asesoria_cientifica(dsSpx1.tarea_asesoria_cientifica, codAsesoria);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAsesoriaDetalle fr = new frmAsesoriaDetalle();
            fr.codAsesoria = codAsesoria;
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tarea_asesoria_cientificaTableAdapter1.FillBycod_asesoria_cientifica(dsSpx1.tarea_asesoria_cientifica, codAsesoria);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (grdDAtos.Columns["cod_tarea_asesoria_cientifica"].Text.Trim() == string.Empty) return;
            frmAsesoriaDetalle fr = new frmAsesoriaDetalle();
            fr.codAsesoria = codAsesoria;
            fr.codTarea = int.Parse(grdDAtos.Columns["cod_tarea_asesoria_cientifica"].Text);
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tarea_asesoria_cientificaTableAdapter1.FillBycod_asesoria_cientifica(dsSpx1.tarea_asesoria_cientifica, codAsesoria);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdDAtos.Columns["cod_tarea_asesoria_cientifica"].Text.Trim() == string.Empty) return;
            
            if (MessageBox.Show("Esta seguro de eliminar el registro?","Confirmacion",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                tarea_asesoria_cientificaTableAdapter1.DeleteQuery(int.Parse(grdDAtos.Columns["cod_tarea_asesoria_cientifica"].Text));
                tarea_asesoria_cientificaTableAdapter1.FillBycod_asesoria_cientifica(dsSpx1.tarea_asesoria_cientifica, codAsesoria);
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            obj.exportar(grdDAtos, "Tareas asesoria"+codAsesoria, false);
        }
    }
}
