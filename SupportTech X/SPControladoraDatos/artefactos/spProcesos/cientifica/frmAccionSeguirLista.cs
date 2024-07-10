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
    public partial class frmAccionSeguirLista : Form
    {
        public frmAccionSeguirLista()
        {
            InitializeComponent();
        }

        private void frmAccionSeguirLista_Load(object sender, EventArgs e)
        {
            accion_seguir_cientificaTableAdapter1.Fill(dsSpx1.accion_seguir_cientifica);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cientifica.frmAccionSeguir fr = new frmAccionSeguir();
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                accion_seguir_cientificaTableAdapter1.Fill(dsSpx1.accion_seguir_cientifica);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if ( grdDatos.Columns["cod_accion_seguir_cientifica"].Text.Trim() == string.Empty )
                return;
            cientifica.frmAccionSeguir fr = new frmAccionSeguir();
            fr.codAccionSeguir = int.Parse( grdDatos.Columns["cod_accion_seguir_cientifica"].Text.Trim());
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                accion_seguir_cientificaTableAdapter1.Fill(dsSpx1.accion_seguir_cientifica);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_accion_seguir_cientifica"].Text.Trim() == string.Empty)
                return;
            if (MessageBox.Show("Esta seguro de eliminar el registro", "",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                accion_seguir_cientificaTableAdapter1.DeleteQuery(int.Parse(grdDatos.Columns["cod_accion_seguir_cientifica"].Text));

                accion_seguir_cientificaTableAdapter1.Fill(dsSpx1.accion_seguir_cientifica);
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            obj.exportarRapido(grdDatos, "Acciones a Seguir", false);
        }
    }
}
