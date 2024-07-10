using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SPXSeguridad;
using SPXSeguridad.frm;

namespace spxreactlab
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            grupo_usuarioTableAdapter1.Fill(dsSPXSeguridad1.grupo_usuario);
            usuarioTableAdapter1.Fill(dsSPXSeguridad1.usuario);
            cargarGruposUsuario();
        }

        #region grupos del sistema
        private void btnAgregarGrupo_Click(object sender, EventArgs e)
        {
            frmGrupoUsuarioDetalle fr = new frmGrupoUsuarioDetalle();
            fr.Icon = this.Icon;
            if (fr.ShowDialog() == DialogResult.OK)
            {
                grupo_usuarioTableAdapter1.Fill(dsSPXSeguridad1.grupo_usuario);
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
                grupo_usuarioTableAdapter1.Fill(dsSPXSeguridad1.grupo_usuario);
                cargarGruposUsuario();
            }
        }

        private void btnEliminarGrupo_Click(object sender, EventArgs e)
        {
            if (grdGrupos.Columns["cod_grupo_usuario"].Text.Trim() == string.Empty) return;
            if (MessageBox.Show("Esta Seguro de Eliminar el grupo!", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    grupo_usuarioTableAdapter1.DeleteQuery(int.Parse(grdGrupos.Columns["cod_grupo_usuario"].Text));
                    grupo_usuarioTableAdapter1.Fill(dsSPXSeguridad1.grupo_usuario);
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
        #endregion

        private void btnActuazalizar_Click(object sender, EventArgs e)
        {
            usuarioTableAdapter1.Fill(dsSPXSeguridad1.usuario);
            grupo_usuarioTableAdapter1.Fill(dsSPXSeguridad1.grupo_usuario);
            cargarGruposUsuario();
        }

        private void cargarGruposUsuario()
        {
            if (grdUsuario.Columns["cod_usuario"].Text.Trim() == string.Empty)
            {
                dsSPXSeguridad2.grupo_usuario.Clear();
                return;
            }

            int usu = int.Parse(grdUsuario.Columns["cod_usuario"].Text);
            grupo_usuarioTableAdapter1.FillByUsuario(dsSPXSeguridad2.grupo_usuario, usu);
        }

        private void btnAgregarGrupoUsuario_Click(object sender, EventArgs e)
        {
            int usu = int.Parse(grdUsuario.Columns["cod_usuario"].Text);
            frmSeleccionarGrupoUsuario fr = new frmSeleccionarGrupoUsuario();
            //agregamos la lista de los grupos que tiene actualmente
            List<int> listBefore = new List<int>();
            for (int k = 0; k < dsSPXSeguridad2.grupo_usuario.Count; k++)
            {
                listBefore.Add(dsSPXSeguridad2.grupo_usuario[k].cod_grupo_usuario);
                fr.listaSeleccionada.Add(dsSPXSeguridad2.grupo_usuario[k].cod_grupo_usuario);
            }

            if (fr.ShowDialog() != DialogResult.OK) return;
            //primero evaluamos cuales son los nuevos, los nuevos son los que estan en fr.listaSeleccionada y no estan en listBefore
            for (int k = 0; k < fr.listaSeleccionada.Count; k++)
            {
                if (!listBefore.Contains(fr.listaSeleccionada[k]))
                {
                    grupousuario_usuarioTableAdapter1.Insert(fr.listaSeleccionada[k], usu);
                }
            }
            //ahora evluamos cuales debemos borrar, borramos los que estan en lidtBefore y no estan en fr.listaSeeccionada
            for (int k = 0; k < listBefore.Count; k++)
            {
                if (!fr.listaSeleccionada.Contains(listBefore[k]))
                {
                    grupousuario_usuarioTableAdapter1.DeleteQuery(listBefore[k], usu);
                }
            }
            cargarGruposUsuario();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            //vALIDAMOS QUE LOS USUARIOS NO SOBREPASEN LOS USUARIOS DE LA LICENCIA
            
                string sql="select count(*) from usuario";
            SPXdata.BD.DataConector bd=new SPXdata.BD.DataConector();
            string a= bd.ejecutarProcedimiento(sql).ToString();
            int u=0;
            int .TryParse(a,out u);
            if (u >= spxreactlab.cnn.numeroUsuarios)
            {
                MessageBox.Show("alcanzo el numero maximo de usuarios de la licencia");
                return;
            }
            
            frmUsuarioDetalle fr = new frmUsuarioDetalle();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                usuarioTableAdapter1.Fill(dsSPXSeguridad1.usuario);
                cargarGruposUsuario();
            }
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (grdUsuario.Columns["cod_usuario"].Text.Trim() == string.Empty) return;
            int usu = int.Parse(grdUsuario.Columns["cod_usuario"].Text);
            frmUsuarioDetalle fr = new frmUsuarioDetalle();
            fr.codUsuario = usu;
            if (fr.ShowDialog() == DialogResult.OK)
            {
                usuarioTableAdapter1.Fill(dsSPXSeguridad1.usuario);
                cargarGruposUsuario();
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (grdUsuario.Columns["cod_usuario"].Text.Trim() == string.Empty) return;
            int usu = int.Parse(grdUsuario.Columns["cod_usuario"].Text);
            if (MessageBox.Show("Esta seguro de Eliminar el Usuario", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    grupousuario_usuarioTableAdapter1.DeleteBycod_usuario(usu);
                    usuarioTableAdapter1.DeleteQuery(usu);
                    usuarioTableAdapter1.Fill(dsSPXSeguridad1.usuario);
                    cargarGruposUsuario();
                }
                catch (Exception ex)
                {
                    if (MessageBox.Show("Asegurese de que el Usuario no este vinculado con ningun proceso\nDesea ver mas Infomarcion del error?", "Error al Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void grdUsuario_RowColChange(object sender, C1.Win.C1TrueDBGrid.RowColChangeEventArgs e)
        {
            cargarGruposUsuario();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //validamos que usuarios no tienen grupo
            grupousuario_usuarioTableAdapter1.Fill(dsSPXSeguridad1.grupousuario_usuario);
            int singrupo = 0;
            for (int k = 0; k < dsSPXSeguridad1.usuario.Count; k++)
            {
                if (dsSPXSeguridad1.grupousuario_usuario.Select("cod_usuario=" + dsSPXSeguridad1.usuario[k].cod_usuario + "").Length <= 0)
                {
                    singrupo++;
                }
            }
            if (singrupo > 0)
            {
                if (MessageBox.Show("Hay Usuarios sin grupo de usuario asignado!\nDesea continuar en esta ventana y configurarlos correctamente. ", "Usuarios sin Grupo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    return;
                }

            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
