using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPXSeguridad.data.cls
{

    public class clsTgrupousuario_usuario : SPXdata.BD.clsAdaptador
    {
        #region copiar y pegar en todas las tablas
        public SPXSeguridad.data.dsSPXSeguridad.grupousuario_usuarioDataTable tabla;

        public clsTgrupousuario_usuario()
        {
            tabla = new dsSPXSeguridad.grupousuario_usuarioDataTable();
            tablaMaestra = (System.Data.DataTable)tabla;
            nombreLlave = "cod_grupousuario_usuario";
            nombreTabla = "grupousuario_usuario";
            cargarCamposSelect();
        }

        #endregion


     
        public int Insert(int cod_grupo_usuario, int cod_usuario)
        {
            string sql = @"INSERT INTO grupousuario_usuario
                         (cod_grupo_usuario, cod_usuario)
                         VALUES (@cod_grupo_usuario, @cod_usuario)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(cod_grupo_usuario);
            name.Add("@cod_grupo_usuario");

            arr.Add(cod_usuario);
            name.Add("@cod_usuario");

            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int DeleteByCod_grupo_usuario(int cod_grupo_usuario)
        {
            string sql = @"DELETE FROM grupousuario_usuario WHERE cod_grupo_usuario = @cod_grupo_usuario";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_grupo_usuario);
            name.Add("@cod_grupo_usuario");

            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int DeleteBycod_usuario(int cod_usuario)
        {
            string sql = @"DELETE FROM grupousuario_usuario WHERE cod_usuario = @cod_usuario";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_usuario);
            name.Add("@cod_usuario");

            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int DeleteQuery(int cod_grupo_usuario, int cod_usuario)
        {
            string sql = @"DELETE FROM grupousuario_usuario WHERE (cod_grupo_usuario = @cod_grupo_usuario) AND (cod_usuario = @cod_usuario) ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_grupo_usuario);
            name.Add("@cod_grupo_usuario");

            arr.Add(cod_usuario);
            name.Add("@cod_usuario");

            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public void FillBycod_grupo_usuario(SPXSeguridad.data.dsSPXSeguridad.grupousuario_usuarioDataTable tabla,int cod_grupo_usuario)
        {
            string sql = sentenciaBase + @" WHERE (cod_grupo_usuario = @cod_grupo_usuario)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_grupo_usuario);
            name.Add("@cod_grupo_usuario");
            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql,tabla,false, arr, name);
        }

        public void FillBycod_grupousuario_usuario(SPXSeguridad.data.dsSPXSeguridad.grupousuario_usuarioDataTable tabla,int cod_grupousuario_usuario)
        {
            string sql = sentenciaBase + @" WHERE  (cod_grupousuario_usuario = @cod_grupousuario_usuario)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_grupousuario_usuario);
            name.Add("@cod_grupousuario_usuario");
            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql,tabla,false, arr, name);
        }

        public void FillBycod_usuario(SPXSeguridad.data.dsSPXSeguridad.grupousuario_usuarioDataTable tabla,int cod_usuario)
        {
            string sql = sentenciaBase + @" WHERE  (cod_usuario = @cod_usuario)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_usuario);
            name.Add("@cod_usuario");
            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql,tabla,false, arr, name);
        }
    }
}