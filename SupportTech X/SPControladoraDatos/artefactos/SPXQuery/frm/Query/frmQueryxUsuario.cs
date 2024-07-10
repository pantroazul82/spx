using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SPControladoraDatos.artefactos.SPXUtilidades.Misc;
using SPControladoraDatos.artefactos;

namespace SPControladoraDatos.artefactos.SPXQuery.frm.Query
{
    public partial class frmQueryxUsuario : frm.plantillas.frmPrincipal
    {
        public frmQueryxUsuario()
        {
            InitializeComponent();
        }

        data.cls.clsTcgq_query cgq_queryTableAdapter1 = new data.cls.clsTcgq_query();
        private void frmQueryxUsuario_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

            //     usuarioTableAdapter1.Fill(dsSPXSeguridad1.usuario);
            cgq_queryTableAdapter1.Fill(dsSPXQuery1.cgq_query);
            //
            cargarInfoQuery();
        }

        private void cargarInfoQuery() 
        {    
            dsSPXSeguridad1.usuario.Clear();
            if (grdQuery.Columns["cod_query"].ToString().Trim() == string.Empty)
                return;

            try
            {
                var cod_query = int.Parse(grdQuery.Columns[0].Value.ToString());
                usuarioTableAdapter1.FillByCod_query(dsSPXSeguridad1.usuario,cod_query);
                grupo_usuarioTableAdapter1.FillBycod_query(dsSPXSeguridad1.grupo_usuario,cod_query);
            }
            catch (Exception) { }
        }

        private void grdQuery_RowColChange(object sender, C1.Win.C1TrueDBGrid.RowColChangeEventArgs e)
        {
            cargarInfoQuery();
        }

        private void btnActualizarGrupos_Click(object sender, EventArgs e)
        {
            var cod_query = int.Parse(grdQuery.Columns[0].Value.ToString());
            grupo_usuarioTableAdapter1.FillBycod_query(dsSPXSeguridad1.grupo_usuario, cod_query);
        }

        private void btnExportarUsuarios_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            obj.exportar(grdUsuario, "Libro1", true);
        }

        private void btnExportarQuery_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            obj.exportar(grdQuery, "Libro1", true);
        }

        private void btnActualizarUsuarios_Click(object sender, EventArgs e)
        {
            var cod_query = int.Parse(grdQuery.Columns[0].Value.ToString());
            usuarioTableAdapter1.FillByCod_query(dsSPXSeguridad1.usuario, cod_query);
        }

        private void btnExportarGrupos_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            obj.exportar(grdGrupos, "Libro1", true);
        }

        private void btnActualizarQuery_Click(object sender, EventArgs e)
        {
            cgq_queryTableAdapter1.Fill(dsSPXQuery1.cgq_query);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(grdQuery.Columns[0].Value == null || grdQuery.Columns[0].Value.ToString().Trim() == string.Empty )
            {
                return;
            }
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
            frmEditarQueryUsuarios fr = new frmEditarQueryUsuarios();
            fr.cod_query = int.Parse(grdQuery.Columns[0].Value.ToString());
            if (fr.ShowDialog() == DialogResult.OK)
                cargarInfoQuery();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void grdQuery_RowColChange_1(object sender, C1.Win.C1TrueDBGrid.RowColChangeEventArgs e)
        {
            cargarInfoQuery();
        }

        private void btnExportarUsuarios_Click_1(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel ob = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            ob.exportar(grdUsuario,"Usuarios x Query",false);
        }

        private void btnExportarGrupos_Click_1(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel ob = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            ob.exportar(grdGrupos, "Usuarios x Query", false);
        }

        private void btnExportarQuery_Click_1(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel ob = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            ob.exportar(grdQuery, "Query", false);
        }
    }
}
