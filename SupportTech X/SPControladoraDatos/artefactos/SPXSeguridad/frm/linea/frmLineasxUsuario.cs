using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SPXSeguridad.data;

namespace SPXSeguridad.linea
{
    public partial class frmLineasxUsuario : Form
    {
        public frmLineasxUsuario()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAgregarGrupo_Click(object sender, EventArgs e)
        {
            if (grdLinea.Columns["cod_linea"].Text.Trim() == string.Empty) return;
            
            int linea = int.Parse(grdLinea.Columns["cod_linea"].Text);
            frm.frmSeleccionarGrupoUsuario fr = new frm.frmSeleccionarGrupoUsuario();
            //agregamos la lista de los grupos que tiene actualmente
            List<int> listBefore = new List<int>();
            for (int k = 0; k < dsSPXSeguridad1.grupo_usuario.Count; k++)
            {
                listBefore.Add(dsSPXSeguridad1.grupo_usuario[k].cod_grupo_usuario);
                fr.listaSeleccionada.Add(dsSPXSeguridad1.grupo_usuario[k].cod_grupo_usuario);
            }

            if (fr.ShowDialog() != DialogResult.OK) return;
            //primero evaluamos cuales son los nuevos, los nuevos son los que estan en fr.listaSeleccionada y no estan en listBefore
            for (int k = 0; k < fr.listaSeleccionada.Count; k++)
            {
                if (!listBefore.Contains(fr.listaSeleccionada[k]))
                {
                    grupo_usuarioxlineaTableAdapter1.Insert( fr.listaSeleccionada[k],linea);
                }
            }
            //ahora evluamos cuales debemos borrar, borramos los que estan en lidtBefore y no estan en fr.listaSeeccionada
            for (int k = 0; k < listBefore.Count; k++)
            {
                if (!fr.listaSeleccionada.Contains(listBefore[k]))
                {
                    grupo_usuarioxlineaTableAdapter1.DeleteQuery(listBefore[k], linea);
                }
            }
            cargarDatos();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (grdLinea.Columns["cod_linea"].Text.Trim() == string.Empty) return;
   frm.frmSeleccionarUsuario fr = new frm.frmSeleccionarUsuario();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                if (dsSPXSeguridad1.usuario.Select("cod_usuario=" + fr.codUsuario).Length <= 0)
                {
                    lineaxusuarioTableAdapter1.Insert( int.Parse(grdLinea.Columns["cod_linea"].Text),fr.codUsuario);
                    cargarDatos();
                }
            }
            //end
         
        }

        private void btnQuitarUsuario_Click(object sender, EventArgs e)
        {
            if (grdLinea.Columns["cod_linea"].Text.Trim() == string.Empty) return;
            if (grdUsuarios.Columns["cod_usuario"].Text.Trim() == string.Empty) return;
         
            if (MessageBox.Show("Esta seguro de quitar el usuario?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lineaxusuarioTableAdapter1.DeleteQuery(

                    int.Parse(grdLinea.Columns["cod_linea"].Text), int.Parse(grdUsuarios.Columns["cod_usuario"].Text));

                cargarDatos();
            }
        }

        private void grdLinea_RowColChange(object sender, C1.Win.C1TrueDBGrid.RowColChangeEventArgs e)
        {
            cargarDatos();
        }

        bool eventosEncendidos = false;

        private void cargarDatos() 
        {
            if (!eventosEncendidos) return;
            dsSPXSeguridad1.grupo_usuario.Clear();
                dsSPXSeguridad1.usuario.Clear();
            if (grdLinea.Columns["cod_linea"].Text.Trim() == string.Empty)
            {   
                return;
            }
            lineaxusuarioTableAdapter1.FillBycod_linea(dsSPXSeguridad1.lineasxusuario, int.Parse(grdLinea.Columns["cod_linea"].Text));
            grupo_usuarioxlineaTableAdapter1.FillBycod_linea(dsSPXSeguridad1.grupo_usuarioxlinea, int.Parse(grdLinea.Columns["cod_linea"].Text));
            for (int k = 0; k < dsSPXSeguridad1.lineasxusuario.Count; k++)
            {
                SPXSeguridad.data.dsSPXSeguridad ds = new SPXSeguridad.data.dsSPXSeguridad();
                usuarioTableAdapter1.FillBycod_usuario(ds.usuario, dsSPXSeguridad1.lineasxusuario[k].cod_usuario);
                dsSPXSeguridad1.usuario.Merge(ds.usuario);
            }
            for (int k = 0; k < dsSPXSeguridad1.grupo_usuarioxlinea.Count; k++)
            {
                SPXSeguridad.data.dsSPXSeguridad.grupo_usuarioDataTable t = new SPXSeguridad.data.dsSPXSeguridad.grupo_usuarioDataTable();
                grupo_usuarioTableAdapter1.FillBycod_grupo_usuario(t, dsSPXSeguridad1.grupo_usuarioxlinea[k].cod_grupo_usuario);
                dsSPXSeguridad1.grupo_usuario.Merge(t);
            }
        }

        private void frmLineasxUsuario_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

            lineaTableAdapter1.FillSinLogo(dsSPXSeguridad1.linea);
            eventosEncendidos = true;
            cargarDatos();
        }
    }
}
