using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.ordenPrestamo
{
    public partial class frmRecibirRepuestos : Form
    {
        public frmRecibirRepuestos()
        {
            InitializeComponent();
        }

        private void buscar()
        {
            string sql = "select * from ordenPrestamo where codEstadoOrdenPrestamo =5 or codEstadoOrdenPrestamo=6 " +
                " order by fechaorden desc";
            dsSpx1.OrdenPrestamo.Clear();
            SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
            dsSpx1.EnforceConstraints = false;
            dsSpx1.OrdenPrestamo.Merge(obj.ejecutarConsulta(sql).Tables[0]);
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            obj.exportar(grdDatos, "Repuestos Por Recibir", false);
        }

        private void btnverSolicitud_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["codOrdenPrestamo"].Text.Trim() == string.Empty) return;
            spProcesos.ordenPrestamo.frmNuevaOrdenPrestamo fr = new frmNuevaOrdenPrestamo();
            fr.CodOrdenPrestamo = int.Parse( grdDatos.Columns["codOrdenPrestamo"].Text);
            fr.ShowDialog();
            buscar();
        }

        private void btnEntregarRepuestos_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["codOrdenPrestamo"].Text.Trim() == string.Empty) return;

            if (MessageBox.Show("Esta seguro de recibir los repuestos del ingeniero?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    == DialogResult.Yes)
            {
                frmRecibirRepuestosIng fr = new frmRecibirRepuestosIng();
                fr.codOrdenPrestamo = int.Parse(grdDatos.Columns["codOrdenPrestamo"].Text);
                fr.ShowDialog();
            }
            buscar();
        }

        private void frmRecibirRepuestos_Load(object sender, EventArgs e)
        {
            buscar();
        }
    }
}
