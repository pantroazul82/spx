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
    public partial class frmInconvenientePresentadoPor : Form
    {
        public frmInconvenientePresentadoPor()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cientifica.frmInconvenientePresentado fr = new frmInconvenientePresentado();
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                inconveniente_presentado_cientificaTableAdapter1.Fill(dsSpx1.inconveniente_presentado_cientifica);        
            }
        }

        private void frmInconvenientePresentadoPor_Load(object sender, EventArgs e)
        {
            inconveniente_presentado_cientificaTableAdapter1.Fill(dsSpx1.inconveniente_presentado_cientifica);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_inconveniente_presentado_cientifica"].Text.Trim() == string.Empty)
                return;

            cientifica.frmInconvenientePresentado fr = new frmInconvenientePresentado();
            fr.codInconveniente = int.Parse(grdDatos.Columns["cod_inconveniente_presentado_cientifica"].Text);
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                inconveniente_presentado_cientificaTableAdapter1.Fill(dsSpx1.inconveniente_presentado_cientifica);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_inconveniente_presentado_cientifica"].Text.Trim() == string.Empty)
                return;

            if (MessageBox.Show("Esta seguro de eliminar el registro","Confirmacion",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                inconveniente_presentado_cientificaTableAdapter1.DeleteQuery(
                    int.Parse(grdDatos.Columns["cod_inconveniente_presentado_cientifica"].Text));
                inconveniente_presentado_cientificaTableAdapter1.Fill(dsSpx1.inconveniente_presentado_cientifica);
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            obj.exportarRapido(grdDatos, "Inconvenientes cientifica", false);
        }
    }
}
