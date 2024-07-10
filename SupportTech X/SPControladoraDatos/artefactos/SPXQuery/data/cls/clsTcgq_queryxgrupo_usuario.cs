using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPControladoraDatos.artefactos.SPXQuery.data.cls
{
    class clsTcgq_queryxgrupo_usuario: SPXdata.BD.clsAdaptador
    {
        #region copiar y pegar en todas las tablas
        public dsSPXQuery.cgq_queryxgrupo_usuarioDataTable tabla;

        public clsTcgq_queryxgrupo_usuario()
        {
            tabla = new dsSPXQuery.cgq_queryxgrupo_usuarioDataTable();
            tablaMaestra = (System.Data.DataTable)tabla;
            nombreLlave = "cod_cgq_queryxgrupo_usuario";
            nombreTabla = "cgq_queryxgrupo_usuario";
            cargarCamposSelect();
        }

        #endregion

        public int Insert(int cod_grupo_usuario, int cod_query)
        {
            string sql = @"INSERT INTO cgq_queryxgrupo_usuario
                         (cod_grupo_usuario, cod_query)
VALUES        (@cod_grupo_usuario, @cod_query)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(cod_grupo_usuario);
            name.Add("@cod_grupo_usuario");

            arr.Add(cod_query);
            name.Add("@cod_query");

            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int DeleteByCod_query(int cod_query)
        {
            string sql = @"DELETE FROM cgq_queryxgrupo_usuario WHERE (cod_query = @cod_query)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(cod_query);
            name.Add("@cod_query");

            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int DeleteByCod_grupo_usuario(int cod_grupo_usuario)
        {
            string sql = @"DELETE FROM cgq_queryxgrupo_usuario WHERE (cod_grupo_usuario = @cod_grupo_usuario)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(cod_grupo_usuario);
            name.Add("@cod_grupo_usuario");

            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }
      
        public int DeleteByCod_grupo_usuario(int cod_grupo_usuario,int cod_query)
        {
            string sql = @"DELETE FROM cgq_queryxgrupo_usuario
WHERE        (cod_grupo_usuario = @cod_grupo_usuario) AND (cod_query = @cod_query)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(cod_grupo_usuario);
            name.Add("@cod_grupo_usuario");

            arr.Add(cod_query);
            name.Add("@cod_query");

            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public void FillBycod_query_cod_grupo_usuario(dsSPXQuery.cgq_queryxgrupo_usuarioDataTable tabla, int cod_query, int cod_grupo_usuario)
        {
            string sql = sentenciaBase + @"  WHERE (cod_grupo_usuario = @cod_grupo_usuario) AND (cod_query = @cod_query) ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_grupo_usuario);
            name.Add("@cod_grupo_usuario");

            arr.Add(cod_query);
            name.Add("@cod_query");
            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }


        public void FillByCod_query(dsSPXQuery.cgq_queryxgrupo_usuarioDataTable tabla, int cod_query)
        {
            string sql = sentenciaBase + @"  WHERE  (cod_query = @cod_query) ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
        
            arr.Add(cod_query);
            name.Add("@cod_query");
            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }


    }
}
