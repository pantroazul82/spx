using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SPXSeguridad.data;

namespace SPXSeguridad.frm
{
    public partial class frmSeleccionarUsuario : Form
    {
        public frmSeleccionarUsuario()
        {
            InitializeComponent();
        }

        public int codUsuario { set; get; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if( grdUsuario.Columns["cod_usuario"].Text.Trim() == string.Empty ) return;
            codUsuario = int.Parse(grdUsuario.Columns["cod_usuario"].Text.Trim());
            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmSeleccionarGrupoUsuario_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

            usuarioTableAdapter1.Fill(dsSPXSeguridad1.usuario);
        }
    }
}
