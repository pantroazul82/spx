using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SPXSeguridad;

namespace SPXSeguridad.frm
{
    public partial class frmGrupoUsuario : Form
    {
        public frmGrupoUsuario()
        {
            InitializeComponent();
        }

        private void frmGrupoUsuario_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

            grupo_usuarioTableAdapter2.Fill(dsSPXSeguridad2.grupo_usuario);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            grupo_usuarioTableAdapter2.Fill(dsSPXSeguridad2.grupo_usuario);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            SPXSeguridad.frmGrupoUsuarioDetalle fr = new frmGrupoUsuarioDetalle();
            fr.Icon = this.Icon;
            if (fr.ShowDialog() == DialogResult.OK)
            {
                grupo_usuarioTableAdapter2.Fill(dsSPXSeguridad2.grupo_usuario);
            }
        }

        private void btnEditarGrupo_Click(object sender, EventArgs e)
        {
            if (grdGrupos.Columns["cod_grupo_usuario"].Text.Trim() == string.Empty) return;
            frmGrupoUsuarioDetalle fr = new frmGrupoUsuarioDetalle();
            fr.Icon = this.Icon;
            fr.CodGrupo = int.Parse(grdGrupos.Columns["cod_grupo_usuario"].Text);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                grupo_usuarioTableAdapter2.Fill(dsSPXSeguridad2.grupo_usuario);
            }
        }

        private void btnEliminarGrupo_Click(object sender, EventArgs e)
        {
            if (grdGrupos.Columns["cod_grupo_usuario"].Text.Trim() == string.Empty) return;
            if (MessageBox.Show("Esta Seguro de Eliminar el grupo!","Confirmacion",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    grupo_usuarioTableAdapter2.DeleteQuery(int.Parse(grdGrupos.Columns["cod_grupo_usuario"].Text));
                    grupo_usuarioTableAdapter2.Fill(dsSPXSeguridad2.grupo_usuario);
                }
                catch (Exception ex)
                {
                    if (MessageBox.Show("Asegurese de que el grupo no este vinculado con ningun usuario\nDesea ver mas Infomarcion del error?", "Error al Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
