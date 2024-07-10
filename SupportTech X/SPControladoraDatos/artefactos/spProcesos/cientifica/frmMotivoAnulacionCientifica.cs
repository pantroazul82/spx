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
    public partial class frmMotivoAnulacionCientifica : Form
    {
        public frmMotivoAnulacionCientifica()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmMotivoAnulacion fr = new frmMotivoAnulacion();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                motivo_anulacion_cientificaTableAdapter1.Fill(dsSpx1.motivo_anulacion_cientifica);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_motivo_anulacion_cientifica"].Text.Trim() == string.Empty)
            {
                return;
            }
            frmMotivoAnulacion fr = new frmMotivoAnulacion();
            fr.codMotivoAnulacion = int.Parse( grdDatos.Columns["cod_motivo_anulacion_cientifica"].Text );
            if (fr.ShowDialog() == DialogResult.OK)
            {
                motivo_anulacion_cientificaTableAdapter1.Fill(dsSpx1.motivo_anulacion_cientifica);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_motivo_anulacion_cientifica"].Text.Trim() == string.Empty)
            {
                return;
            }
            
            if (MessageBox.Show("Esta seguro de eliminar el registro","Confirmacion",MessageBoxButtons.YesNo)== DialogResult.Yes )
            {
                motivo_anulacion_cientificaTableAdapter1.DeleteQuery( int.Parse(grdDatos.Columns["cod_motivo_anulacion_cientifica"].Text ) );
                motivo_anulacion_cientificaTableAdapter1.Fill(dsSpx1.motivo_anulacion_cientifica);
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel o = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            o.exportar(grdDatos, "Motivos Anulacion", false);
        }

        private void frmMotivoAnulacionCientifica_Load(object sender, EventArgs e)
        {
            motivo_anulacion_cientificaTableAdapter1.Fill(dsSpx1.motivo_anulacion_cientifica);
        }
    }
}
