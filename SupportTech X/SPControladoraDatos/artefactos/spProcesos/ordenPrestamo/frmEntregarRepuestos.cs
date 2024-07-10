using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.ordenPrestamo
{
    public partial class frmEntregarRepuestos : Form
    {
        public frmEntregarRepuestos()
        {
            InitializeComponent();
        }

        private void frmEntregarRepuestos_Load(object sender, EventArgs e)
        {
            buscar();
        }

        private void buscar()
        {
            string sql = "select * from ordenPrestamo where codEstadoOrdenPrestamo = 2 or codEstadoOrdenPrestamo = 4" +
                " order by fechaorden desc";
            dsSpx1.OrdenPrestamo.Clear();
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            dsSpx1.EnforceConstraints = false;
            dsSpx1.OrdenPrestamo.Merge(objData.ejecutarConsulta(sql).Tables[0]);
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            obj.exportar(grdDatos, "Orden de Prestamo sin Entregar Repuestos", false);
        }

        private void btnEntregarRepuestos_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["codOrdenPrestamo"].Text.Trim() == string.Empty) return;

            if (MessageBox.Show("Esta seguro de entregar los repuestos al ingeniero?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    == DialogResult.Yes)
            {
             //   ordenPrestamoTableAdapter1.UpdateAceptar(SPXSeguridad.logica.sesion.LoginUsuarioAutenticado, int.Parse(grdDatos.Columns["codOrdenPrestamo"].Text));
                frmEntregarRepuestosIng fr = new frmEntregarRepuestosIng();
                fr.codOrdenPrestamo = int.Parse(grdDatos.Columns["codOrdenPrestamo"].Text);

                fr.ShowDialog();
            
            }
            buscar();
        }

        private void btnverSolicitud_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["codOrdenPrestamo"].Text.Trim() == string.Empty) return;
            spProcesos.ordenPrestamo.frmNuevaOrdenPrestamo fr = new frmNuevaOrdenPrestamo();
            fr.CodOrdenPrestamo = int.Parse(grdDatos.Columns["codOrdenPrestamo"].Text);
            fr.ShowDialog();
            buscar();
        }
    }
}
