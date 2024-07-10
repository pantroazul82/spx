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
    public partial class frmReferenciaReactivoLista : Form
    {
        public frmReferenciaReactivoLista()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cientifica.frmReferenciaReactivo fr = new frmReferenciaReactivo();
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pltReferenciaReactivoTableAdapter1.Fill(dsPlantillas1.pltReferenciaReactivo);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_referencia_reactivo"].Text.Trim() == string.Empty) return;
            cientifica.frmReferenciaReactivo fr = new frmReferenciaReactivo();
            fr.codReferenciaReactivo = int.Parse(grdDatos.Columns["cod_referencia_reactivo"].Text);
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pltReferenciaReactivoTableAdapter1.Fill(dsPlantillas1.pltReferenciaReactivo);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(grdDatos.Columns["cod_referencia_reactivo"].Text.Trim() == string.Empty) return;
            if (MessageBox.Show("Esta seguro de eliminar el registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                referencia_reactivoTableAdapter1.DeleteQuery(int.Parse(grdDatos.Columns["cod_referencia_reactivo"].Text));
                pltReferenciaReactivoTableAdapter1.Fill(dsPlantillas1.pltReferenciaReactivo);
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            obj.exportarRapido(grdDatos, "Reactivos", false);
        }

        private void frmReferenciaReactivoLista_Load(object sender, EventArgs e)
        {
           //dsPlantillas1.EnforceConstraints = false;
            dsPlantillas1.EnforceConstraints = false;
            pltReferenciaReactivoTableAdapter1.Fill(dsPlantillas1.pltReferenciaReactivo);
        }
    }
}
