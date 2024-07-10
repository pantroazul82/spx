using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SPControladoraDatos.artefactos.SPXQuery.frm.plantillas
{
    public partial class frmListado : Form
    {
        protected int cod_modulo;
        protected bool permiteAgregar;
        protected bool permiteModificar;
        protected bool permiteEliminar;

        public frmListado()
        {
            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel ob = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            ob.exportar(grdDatos, "Libro1", false);
        }

        private void cargarEliminar()
        {
            SPXSeguridad.verificadorPermisos obj = new SPXSeguridad.verificadorPermisos();
            obj.codModulo = cod_modulo;
            obj.codUsuario = SPXSeguridad.logica.sesion.CodUsuarioAutenticado;
            obj.solicitarAutorizacion();
            if (!obj.Borrar)
                return;
            permiteEliminar = true;
        }

        private void cargarModificar()
        {
            SPXSeguridad.verificadorPermisos obj = new SPXSeguridad.verificadorPermisos();
            obj.codModulo = cod_modulo;
            obj.codUsuario = SPXSeguridad.logica.sesion.CodUsuarioAutenticado;
            obj.solicitarAutorizacion();
            if (!obj.Modificar)
                return;
            permiteModificar = true;
        }

        private void cargarAgregar()
        {
            SPXSeguridad.verificadorPermisos obj = new SPXSeguridad.verificadorPermisos();
            obj.codModulo = cod_modulo;
            obj.codUsuario = SPXSeguridad.logica.sesion.CodUsuarioAutenticado;
            obj.solicitarAutorizacion();
            if (!obj.Adicionar)
                return;
            permiteAgregar = true;
        }
        private void frmListado_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

            cargarAgregar();
            cargarEliminar();
            cargarModificar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!permiteEliminar)
            {
                MessageBox.Show("No tiene permisos para realizar esta acción!!!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!permiteModificar)
            {
                MessageBox.Show("No tiene permisos para realizar esta acción!!!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!permiteAgregar)
            {
                MessageBox.Show("No tiene permisos para realizar esta acción!!!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
