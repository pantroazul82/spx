using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SPXSeguridad
{
    public partial class frmGrupoUsuarioDetalle : Form
    {
        public frmGrupoUsuarioDetalle()
        {
            InitializeComponent();
        }
        public int CodGrupo { set { codGrupo = value; } get { return codGrupo; } }

        private int codGrupo { set; get; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtNombreGrupo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El nombre del grupo es obligatorio!","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (codGrupo == 0)
            {
                grupo_usuarioTableAdapter1.Insert(txtNombreGrupo.Text);
            }
            else
            {
                grupo_usuarioTableAdapter1.UpdateQuery(txtNombreGrupo.Text, codGrupo);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmGrupoUsuario_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

            if (codGrupo != 0)
            {
                grupo_usuarioTableAdapter1.FillBycod_grupo_usuario(dsSPXSeguridad1.grupo_usuario,codGrupo);
                txtNombreGrupo.Text = dsSPXSeguridad1.grupo_usuario[0].nombre_grupo_usuario.Trim();
            }
            txtNombreGrupo.Focus();
        }
    }
}
