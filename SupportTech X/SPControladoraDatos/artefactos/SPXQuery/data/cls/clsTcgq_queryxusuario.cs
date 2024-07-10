using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPControladoraDatos.artefactos.SPXQuery.data.cls
{
    class clsTcgq_queryxusuario : SPXdata.BD.clsAdaptador
    {
        #region copiar y pegar en todas las tablas
        public dsSPXQuery.cgq_queryxusuarioDataTable tabla;

        public clsTcgq_queryxusuario()
        {
            tabla = new dsSPXQuery.cgq_queryxusuarioDataTable();
            tablaMaestra = (System.Data.DataTable)tabla;
            nombreLlave = "cod_queryxusuario";
            nombreTabla = "cgq_queryxusuario";
            cargarCamposSelect();
        }
        #endregion

        public int Insert(int cod_usuario, int cod_query)
        {
            string sql = @"INSERT INTO cgq_queryxusuario 
                         (cod_usuario, cod_query)
                        VALUES        
                        (@cod_usuario, @cod_query)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(cod_usuario);
            name.Add("@cod_usuario");

            arr.Add(cod_query);
            name.Add("@cod_query");

            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int DeleteByCodQuery( int cod_query)
        {
            string sql = @"DELETE FROM cgq_queryxusuario
                        WHERE (cod_query = @cod_query)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            
            arr.Add(cod_query);
            name.Add("@cod_query");


            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int DeleteByCodUsuarioCodQuery(int cod_usuario,int cod_query)
        {
            string sql = @"DELETE FROM cgq_queryxusuario
                        WHERE (cod_usuario = @cod_usuario) AND (cod_query = @cod_query)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(cod_usuario);
            name.Add("@cod_usuario");

            arr.Add(cod_query);
            name.Add("@cod_query");

            
            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public void FillByCod_query(dsSPXQuery.cgq_queryxusuarioDataTable tabla,int cod_query)
        {
            string sql = sentenciaBase + @" WHERE        (cod_query = @cod_query) ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_query);
            name.Add("@cod_query");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }

        public void FillByCod_usuarioCod_query(dsSPXQuery.cgq_queryxusuarioDataTable tabla,int cod_usuario, int cod_query)
        {
            string sql = sentenciaBase + @" WHERE (cod_usuario = @cod_usuario) AND (cod_query = @cod_query) ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_usuario);
            name.Add("@cod_usuario");

            arr.Add(cod_query);
            name.Add("@cod_query");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }

        public int verQueryxUsuario(dsSPXQuery.cgq_queryDataTable tabla, int cod_query, int cod_usuario)
        {
            string sql = @"SELECT        COUNT(*) AS cantidad
FROM            cgq_queryxusuario
WHERE        (cod_query = @cod_query) AND (cod_usuario = @cod_usuario)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_usuario);
            name.Add("@cod_usuario");

            arr.Add(cod_query);
            name.Add("@cod_query");

            #endregion
           DataConector obj = new DataConector();
            return int.Parse( obj.ejecutarProcedimiento(sql).ToString() );
        }



    }
}
