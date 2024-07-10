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
    public partial class frmConfigPermisos : Form
    {
        public frmConfigPermisos()
        {
            InitializeComponent();
        }

        public int cod_modulo { set; get; }
        public int cod_grupo_modulo{ set; get; }
        public string nombreModulo { set; get; }
        public string nombreGrupoModulo { set; get;  }

        private void cargarTipo() 
        {
            System.Data.DataRow fila= dataTable1.NewRow();
            fila[0]=1;
            fila[1] = "Usuario";
            dataTable1.Rows.Add(fila);
            //--
            System.Data.DataRow fila2 = dataTable1.NewRow();
            fila2[0] = 2;
            fila2[1] = "Grupo de Usuario";
            dataTable1.Rows.Add(fila2);
        }

        private void frmConfigPermisos_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

            cargarTipo();
           if(cod_modulo != 0)
            {
                lblVinculados.Text = "Grupos y Usuarios Vinculados a la funcionalidad";
                lblTitulo.Text = nombreModulo;
                pltVinculadosTableAdapter1.FillBycod_funcionalidad(dsSPXSeguridad1.pltVinculados, cod_modulo);
            }else{
                lblVinculados.Text = "Grupos y Usuarios Vinculados a el Modulo";
                lblTitulo.Text = nombreGrupoModulo;
                pltVinculadosTableAdapter1.FillBycod_grupo_modulo(dsSPXSeguridad1.pltVinculados, cod_grupo_modulo);
            }
            grupo_usuarioTableAdapter1.Fill(dsSPXSeguridad1.grupo_usuario);
            usuarioTableAdapter1.Fill(dsSPXSeguridad1.usuario);
            grdVinculados.Columns["tipo"].SortDirection = C1.Win.C1TrueDBGrid.SortDirEnum.Ascending;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //guardamos los permisos seleccionados
            if (cod_grupo_modulo != 0)
            {
                //cargamos la informacion del modulo
                moduloseguridad_grupousuarioTableAdapter1.FillBycod_moduloseguridad(dsSPXSeguridad1.moduloseguridad_grupousuario, cod_grupo_modulo);
                moduloseguridad_usuarioTableAdapter1.FillBycod_moduloseguridad(dsSPXSeguridad1.moduloseguridad_usuario, cod_grupo_modulo);
                //primero creamos los nuevos
                for (int k = 0; k < dsSPXSeguridad1.pltVinculados.Count; k++)
                {
                    if (dsSPXSeguridad1.pltVinculados[k].tipo == 1)
                    {
                        if (dsSPXSeguridad1.moduloseguridad_usuario.Select("cod_usuario=" + dsSPXSeguridad1.pltVinculados[k].codigo).Length <= 0)
                        {
                            moduloseguridad_usuarioTableAdapter1.Insert( dsSPXSeguridad1.pltVinculados[k].codigo,
                                false, false, false, false, false, false, false,cod_grupo_modulo);
                        }
                    }
                    else
                    {
                        if (dsSPXSeguridad1.moduloseguridad_grupousuario.Select("cod_grupo_usuario=" + dsSPXSeguridad1.pltVinculados[k].codigo).Length <= 0)
                        {
                            moduloseguridad_grupousuarioTableAdapter1.Insert(
                                dsSPXSeguridad1.pltVinculados[k].codigo,cod_grupo_modulo,
                                    false, false, false, false, false, false, false);
                        }
                    }
                }
                //eliminamos los que ya no estan vinculados
                for (int k = 0; k < dsSPXSeguridad1.moduloseguridad_grupousuario.Count; k++)
                {
                    if (dsSPXSeguridad1.pltVinculados.Select("tipo=2 and codigo=" + dsSPXSeguridad1.moduloseguridad_grupousuario[k].cod_grupo_usuario).Length <= 0)
                    {
                        moduloseguridad_grupousuarioTableAdapter1.DeleteBycod_moduloseguridad_grupoUsuario(dsSPXSeguridad1.moduloseguridad_grupousuario[k].codmoduloseguridad_grupousuario);
                    }
                }
                for (int k = 0; k < dsSPXSeguridad1.moduloseguridad_usuario.Count; k++)
                {
                    if (dsSPXSeguridad1.pltVinculados.Select("tipo=1 and codigo=" + dsSPXSeguridad1.moduloseguridad_usuario[k].cod_usuario).Length <= 0)
                    {
                        moduloseguridad_usuarioTableAdapter1.DeleteBycod_moduloseguridad_usuario(dsSPXSeguridad1.moduloseguridad_usuario[k].cod_moduloseguridad_usuario);
                    }
                }
            }
            else
            {
                //cargamos la informacion del grupo modulo
                funcionalidad_grupousuarioTableAdapter1.FillBycod_funcionalidad(dsSPXSeguridad1.funcionalidad_grupousuario, cod_modulo);
                funcionalidad_usuarioTableAdapter1.FillBycod_funcionalidad(dsSPXSeguridad1.funcionalidad_usuario, cod_modulo);
                //primero creamos los nuevos
                for (int k = 0; k < dsSPXSeguridad1.pltVinculados.Count; k++)
                {
                    if (dsSPXSeguridad1.pltVinculados[k].tipo == 1)
                    {
                        if (dsSPXSeguridad1.funcionalidad_usuario.Select("cod_usuario=" + dsSPXSeguridad1.pltVinculados[k].codigo).Length <= 0)
                        {
                            funcionalidad_usuarioTableAdapter1.Insert(cod_modulo, dsSPXSeguridad1.pltVinculados[k].codigo,
                                false, false, false, false, false, false, false);
                        }
                    }
                    else
                    {
                        if (dsSPXSeguridad1.funcionalidad_grupousuario.Select("cod_grupo_usuario=" + dsSPXSeguridad1.pltVinculados[k].codigo).Length <= 0)
                        {
                            funcionalidad_grupousuarioTableAdapter1.Insert(cod_modulo,dsSPXSeguridad1.pltVinculados[k].codigo,
                                    false, false, false, false, false, false, false);
                        }
                    }
                }
                //eliminamos los que ya no estan vinculados
                for (int k = 0; k < dsSPXSeguridad1.funcionalidad_grupousuario.Count; k++)
                {
                    if (dsSPXSeguridad1.pltVinculados.Select("tipo=2 and codigo=" + dsSPXSeguridad1.funcionalidad_grupousuario[k].cod_grupo_usuario).Length <= 0)
                    {
                        funcionalidad_grupousuarioTableAdapter1.DeleteBycod_funcionalidad_grupo_usuario(dsSPXSeguridad1.funcionalidad_grupousuario[k].cod_funcionalidad_grupousuario);
                    }
                }
                for (int k = 0; k < dsSPXSeguridad1.funcionalidad_usuario.Count; k++)
                {
                    if (dsSPXSeguridad1.pltVinculados.Select("tipo=1 and codigo=" + dsSPXSeguridad1.funcionalidad_usuario[k].cod_usuario).Length <= 0)
                    {
                        funcionalidad_usuarioTableAdapter1.DeleteBycod_funcionalidad_usuario(dsSPXSeguridad1.funcionalidad_usuario[k].cod_funcionalidad_usuario);
                    }
                }
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (grdUsuarios.Columns["cod_usuario"].Text.Trim() == string.Empty) return;
            //validamos si existe en la grilla
            if (grdUsuarios.SelectedRows.Count > 0)
            {
                for (int k = 0; k < grdUsuarios.SelectedRows.Count; k++)
                {
                    if (dsSPXSeguridad1.pltVinculados.Select("tipo=1 and codigo=" + grdUsuarios[grdUsuarios.SelectedRows[k], "cod_usuario"].ToString()).Length <= 0)
                    {
                        SPXSeguridad.data.dsSPXSeguridad.pltVinculadosRow fila = dsSPXSeguridad1.pltVinculados.NewpltVinculadosRow();
                        fila.codigo = int.Parse(grdUsuarios[grdUsuarios.SelectedRows[k], "cod_usuario"].ToString());
                        fila.tipo = 1;
                        fila.nombre = grdUsuarios[grdUsuarios.SelectedRows[k], "nombre"].ToString();
                        dsSPXSeguridad1.pltVinculados.AddpltVinculadosRow(fila);
                    }
                }
            }
            else
            {
                if (dsSPXSeguridad1.pltVinculados.Select("tipo=1 and codigo=" + grdUsuarios.Columns["cod_usuario"].Text).Length <= 0)
                {
                    SPXSeguridad.data.dsSPXSeguridad.pltVinculadosRow fila = dsSPXSeguridad1.pltVinculados.NewpltVinculadosRow();
                    fila.codigo = int.Parse(grdUsuarios.Columns["cod_usuario"].Text);
                    fila.tipo = 1;
                    fila.nombre = grdUsuarios.Columns["nombre"].Text;
                    dsSPXSeguridad1.pltVinculados.AddpltVinculadosRow(fila);
                }
            }
        }

        private void btnAgregarGrupo_Click(object sender, EventArgs e)
        {
            if (grdGrupo.Columns["cod_grupo_usuario"].Text.Trim() == string.Empty) return;
            //validamos si existe en la grilla
            if (grdGrupo.SelectedRows.Count > 0)
            {
                for (int k = 0; k < grdGrupo.SelectedRows.Count; k++)
                {
                    if (dsSPXSeguridad1.pltVinculados.Select("tipo=2 and codigo=" + grdGrupo[grdGrupo.SelectedRows[k], "cod_grupo_usuario"].ToString()).Length <= 0)
                    {
                        SPXSeguridad.data.dsSPXSeguridad.pltVinculadosRow fila = dsSPXSeguridad1.pltVinculados.NewpltVinculadosRow();
                        fila.codigo = int.Parse(grdGrupo[grdGrupo.SelectedRows[k], "cod_grupo_usuario"].ToString());
                        fila.tipo = 2;
                        fila.nombre = grdGrupo[grdGrupo.SelectedRows[k], "nombre_grupo_usuario"].ToString();
                        dsSPXSeguridad1.pltVinculados.AddpltVinculadosRow(fila);
                    }
                }
            }
            else
            {

                if (dsSPXSeguridad1.pltVinculados.Select("tipo=2 and codigo=" + grdGrupo.Columns["cod_grupo_usuario"].Text).Length <= 0)
                {
                    SPXSeguridad.data.dsSPXSeguridad.pltVinculadosRow fila = dsSPXSeguridad1.pltVinculados.NewpltVinculadosRow();
                    fila.codigo = int.Parse(grdGrupo.Columns["cod_grupo_usuario"].Text);
                    fila.tipo = 2;
                    fila.nombre = grdGrupo.Columns["nombre_grupo_usuario"].Text;
                    dsSPXSeguridad1.pltVinculados.AddpltVinculadosRow(fila);
                }
            }
        }

        private void btnDesvincular_Click(object sender, EventArgs e)
        {
            if (grdVinculados.Columns[0].Text.Trim() == string.Empty) return;

            if (grdVinculados.SelectedRows.Count > 0)
            {
                List<int> tipos = new List<int>();
                List<int> codigos = new List<int>();
                for (int k = 0; k < grdVinculados.SelectedRows.Count; k++)
                {
                    if (grdVinculados[grdVinculados.SelectedRows[k], "tipo"] == null || grdVinculados[grdVinculados.SelectedRows[k], "tipo"].ToString().Trim() == string.Empty) continue;
                    tipos.Add(int.Parse(grdVinculados[grdVinculados.SelectedRows[k], "tipo"].ToString()));
                    codigos.Add(int.Parse(grdVinculados[grdVinculados.SelectedRows[k], "codigo"].ToString()));
                }

                for (int k = 0; k < tipos.Count; k++)
                {
                    dsSPXSeguridad1.pltVinculados.Rows.Remove(
                    dsSPXSeguridad1.pltVinculados.Select("tipo=" + tipos[k]
                    + " and codigo=" + codigos[k])[0]);
                }
            }
            else
            {
                dsSPXSeguridad1.pltVinculados.Rows.Remove(
                    dsSPXSeguridad1.pltVinculados.Select("tipo=" + grdVinculados.Columns["tipo"].Value.ToString() + " and codigo=" + grdVinculados.Columns["codigo"].Text)[0]
                    );
            }
        }
    }
}
