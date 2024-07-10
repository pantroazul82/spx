using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SPControladoraDatos.artefactos.SPXQuery.frm.Query
{
    public partial class frmEditarQueryUsuarios : plantillas.frmPrincipal
    {
        public int cod_query;
        public frmEditarQueryUsuarios()
        {
            InitializeComponent();
        }

        data.cls.clsTcgq_queryxusuario cgq_queryxusuarioTableAdapter1 = new data.cls.clsTcgq_queryxusuario();
        data.cls.clsTcgq_queryxgrupo_usuario cgq_queryxgrupo_usuarioTableAdapter1 = new data.cls.clsTcgq_queryxgrupo_usuario();

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            int cod_usuario = int.Parse(grdUsuario.Columns[0].Value.ToString());
            System.Data.DataRow[] filas = dataSet1.Tables[0].Select("Tipo = 'Usuario' AND codigo = " + cod_usuario);
            if (filas.Count() > 0) return;

            string login = grdUsuario.Columns["Nombre"].Value.ToString();
            System.Data.DataRow dr = dataSet1.Tables[0].NewRow();
            dr[0] = cod_usuario;
            dr[1] = "Usuario";
            dr[2] = login;
            dataSet1.Tables[0].Rows.Add(dr);
        }

        private void btnAgregarGrupo_Click(object sender, EventArgs e)
        {
            int cod_grupo = int.Parse(grdGrupos.Columns[0].Value.ToString());
            System.Data.DataRow[] filas = dataSet1.Tables[0].Select("Tipo = 'Grupo' AND codigo = " + cod_grupo);
            if (filas.Count() > 0) return;

            string login = grdGrupos.Columns["nombre_grupo_usuario"].Value.ToString();
            System.Data.DataRow dr = dataSet1.Tables[0].NewRow();
            dr[0] = cod_grupo;
            dr[1] = "Grupo";
            dr[2] = login;
            dataSet1.Tables[0].Rows.Add(dr);
        }


         
        private void frmEditarQueryUsuarios_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

            usuarioTableAdapter1.Fill(dsSPXSeguridadGrillas.usuario);
            grupo_usuarioTableAdapter1.Fill(dsSPXSeguridadGrillas.grupo_usuario);

            cgq_queryxusuarioTableAdapter1.FillByCod_query(
                dsSPXQuery1.cgq_queryxusuario, cod_query);
            cgq_queryxgrupo_usuarioTableAdapter1.FillByCod_query(
                dsSPXQuery1.cgq_queryxgrupo_usuario, cod_query);

            
            for (int i = 0; i < dsSPXQuery1.cgq_queryxusuario.Rows.Count; i++)
            {
                System.Data.DataRow dr = dataSet1.Tables[0].NewRow();
                dr[0] = dsSPXQuery1.cgq_queryxusuario[i].cod_usuario;
                usuarioTableAdapter1.FillBycod_usuario(
                    dsSPXSeguridad1.usuario, dsSPXQuery1.cgq_queryxusuario[i].cod_usuario);
                dr[1] = "Usuario";
                dr[2] = dsSPXSeguridad1.usuario[0].login;

                if(dataSet1.Tables[0].Select("Codigo="+dr[0].ToString() +" and tipo= '"+dr[1].ToString().Trim()+"'").Length<=0)
                dataSet1.Tables[0].Rows.Add(dr);
            }
            

            for (int i = 0; i < dsSPXQuery1.cgq_queryxgrupo_usuario.Rows.Count; i++)
            {
                System.Data.DataRow dr = dataSet1.Tables[0].NewRow();
                dr[0] = dsSPXQuery1.cgq_queryxgrupo_usuario[i].cod_grupo_usuario;
                grupo_usuarioTableAdapter1.FillBycod_grupo_usuario(
                    dsSPXSeguridad1.grupo_usuario, dsSPXQuery1.cgq_queryxgrupo_usuario[i].cod_grupo_usuario);
                dr[1] = "Grupo";
                dr[2] = dsSPXSeguridad1.grupo_usuario[0].nombre_grupo_usuario;
                if (dataSet1.Tables[0].Select("Codigo=" + dr[0].ToString() + " and tipo= '" + dr[1].ToString().Trim() + "'").Length <= 0)
                
                dataSet1.Tables[0].Rows.Add(dr);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (grdQuery.Columns[0].Value.ToString().Trim() == string.Empty) return;
            int codigo = int.Parse(grdQuery.Columns[0].Value.ToString());
            dataSet1.Tables[0].Rows.RemoveAt(grdQuery.Row);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Ingresar los grupos y usuarios que no están en la relación
            for (int i = 0; i < dataSet1.Tables[0].Rows.Count; i++)
            {
                if (dataSet1.Tables[0].Rows[i][1].ToString() == "Grupo")
                {
                    int cod_grupo = int.Parse(dataSet1.Tables[0].Rows[i][0].ToString() );
                    cgq_queryxgrupo_usuarioTableAdapter1.FillBycod_query_cod_grupo_usuario(
                        dsSPXQuery1.cgq_queryxgrupo_usuario, cod_query, cod_grupo);
                    if (dsSPXQuery1.cgq_queryxgrupo_usuario.Rows.Count > 0) continue;

                    cgq_queryxgrupo_usuarioTableAdapter1.Insert(cod_grupo, cod_query);
                }

                else if (dataSet1.Tables[0].Rows[i][1].ToString() == "Usuario")
                {
                    int cod_usuario = int.Parse(dataSet1.Tables[0].Rows[i][0].ToString());
                    cgq_queryxusuarioTableAdapter1.FillByCod_usuarioCod_query(
                        dsSPXQuery1.cgq_queryxusuario, cod_usuario, cod_query);
                    if (dsSPXQuery1.cgq_queryxusuario.Rows.Count > 0) continue;

                    cgq_queryxusuarioTableAdapter1.Insert(cod_usuario, cod_query);
                }
            }

            //Eliminar los grupos de usuario que no están en la relación
            cgq_queryxgrupo_usuarioTableAdapter1.FillByCod_query(
                dsSPXQuery1.cgq_queryxgrupo_usuario, cod_query);
            for (int i = 0; i < dsSPXQuery1.cgq_queryxgrupo_usuario.Rows.Count; i++)
            {
                System.Data.DataRow[] filas = dataSet1.Tables[0].Select("Tipo = 'Grupo' AND codigo = '" +
                    dsSPXQuery1.cgq_queryxgrupo_usuario[i].cod_grupo_usuario+"'");
                if (filas.Count() > 0) continue;
                cgq_queryxgrupo_usuarioTableAdapter1.DeleteByCod_grupo_usuario(
                    dsSPXQuery1.cgq_queryxgrupo_usuario[i].cod_grupo_usuario, cod_query);
            }

            //Eliminar los usuarios que no estén en la relación
            cgq_queryxusuarioTableAdapter1.FillByCod_query(
                dsSPXQuery1.cgq_queryxusuario, cod_query);
            for (int i = 0; i < dsSPXQuery1.cgq_queryxusuario.Rows.Count; i++)
            {
                System.Data.DataRow[] filas = dataSet1.Tables[0].Select("Tipo = 'Usuario' AND codigo = '" +
                    dsSPXQuery1.cgq_queryxusuario[i].cod_usuario+"'");
                if (filas.Count() > 0) continue;
                cgq_queryxusuarioTableAdapter1.DeleteByCodUsuarioCodQuery(
                    dsSPXQuery1.cgq_queryxusuario[i].cod_usuario, cod_query);
            }

            DialogResult = DialogResult.OK;
        }
    }
}
