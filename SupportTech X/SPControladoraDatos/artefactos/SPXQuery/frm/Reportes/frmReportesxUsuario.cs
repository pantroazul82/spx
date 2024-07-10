using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SPControladoraDatos.artefactos.SPXQuery.frm.Reportes
{
    public partial class frmReportesxUsuario : frm.plantillas.frmPrincipal
    {
        public frmReportesxUsuario()
        {
            InitializeComponent();
        }

        private void frmReportesxUsuario_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

            rptTableAdapter1.Fill(dsGrillas.rpt);
            cargarInfoQuery();
        }

        private void cargarInfoQuery()
        {
            if (grdDatos.Columns["cod_rpt"].Value == null || grdDatos.Columns["cod_rpt"].Value.ToString().Trim() == string.Empty)
            { 
                dsSPXSeguridad1.usuario.Clear();
                dsSPXSeguridad1.grupo_usuario.Clear();
                return;
            }
            int cod_reporte = int.Parse(grdDatos.Columns["cod_rpt"].Value.ToString());
            usuarioTableAdapter1.FillByCod_rpt(dsSPXSeguridad1.usuario, cod_reporte);
            grupo_usuarioTableAdapter1.FillByCod_rpt(dsSPXSeguridad1.grupo_usuario, cod_reporte);
        }

        private void grdQuery_RowColChange(object sender, C1.Win.C1TrueDBGrid.RowColChangeEventArgs e)
        {
            cargarInfoQuery();
        }

        private void btnActualizarGrupos_Click(object sender, EventArgs e)
        {
            cargarInfoQuery();
        }

        private void btnExportarQuery_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            obj.exportar(grdDatos, "Libro1", true);
        }

        private void btnActualizarUsuarios_Click(object sender, EventArgs e)
        {
            cargarInfoQuery();
        }

        private void btnExportarUsuarios_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            obj.exportar(grdUsuario, "Libro1", true);
        }

        private void btnExportarGrupos_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            obj.exportar(grdGrupos, "Libro1", true);
        }

        private void btnActualizarReporte_Click(object sender, EventArgs e)
        {
            rptTableAdapter1.Fill(dsGrillas.rpt);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            SPXSeguridad.verificadorPermisos obj = new SPXSeguridad.verificadorPermisos();
            obj.codModulo = 64;
            obj.codUsuario = SPXSeguridad.logica.sesion.CodUsuarioAutenticado;
            obj.solicitarAutorizacion();
            if (!obj.ControlTotal)
            {
                MessageBox.Show("No tiene permisos para realizar esta acción!!!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmEditarRptUsuarios fr = new frmEditarRptUsuarios();
            fr.cod_rpt = int.Parse(grdDatos.Columns[0].Value.ToString());
            if (fr.ShowDialog() == DialogResult.OK)
                cargarInfoQuery();
        }

        private void grdDatos_RowColChange(object sender, C1.Win.C1TrueDBGrid.RowColChangeEventArgs e)
        {
            cargarInfoQuery();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

    }
}
