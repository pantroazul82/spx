using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPControladoraDatos.artefactos.SPXQuery.data.cls
{
    class clsTcgq_parametrosquery: SPXdata.BD.clsAdaptador
    {
        #region copiar y pegar en todas las tablas
        public dsSPXQuery.cgq_parametrosqueryDataTable tabla;

        public clsTcgq_parametrosquery()
        {
            tabla = new dsSPXQuery.cgq_parametrosqueryDataTable();
            tablaMaestra = (System.Data.DataTable)tabla;
            nombreLlave = "cod_parametros_query";
            nombreTabla = "cgq_parametrosquery";
            cargarCamposSelect();
        }

        #endregion

        public int Insert ( int cod_query, string campo,string caption,int cod_tipo_filtro, 
            string valor_por_defecto)
        {
            string sql = @"INSERT INTO cgq_parametrosquery
                         (cod_query, campo, caption, cod_tipo_filtro, valor_por_defecto)
VALUES        (@cod_query, @campo, @caption, @cod_tipo_filtro, @valor_por_defecto)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(cod_query);
            name.Add("@cod_query");

            arr.Add(campo);
            name.Add("@campo");

            arr.Add(caption);
            name.Add("@caption");

            arr.Add(cod_tipo_filtro);
            name.Add("@cod_tipo_filtro");

            arr.Add(valor_por_defecto);
            name.Add("@valor_por_defecto");


            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int UpdateQuery(int cod_query, string campo, string caption, int cod_tipo_filtro, string valor_por_defecto, int cod_parametros_query)
        {
            string sql = @"UPDATE       cgq_parametrosquery
SET                cod_query = @cod_query, campo = @campo, 
caption = @caption, cod_tipo_filtro = @cod_tipo_filtro, valor_por_defecto = @valor_por_defecto
                         
WHERE        (cod_parametros_query = @cod_parametros_query)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(cod_query);
            name.Add("@cod_query");

            arr.Add(campo);
            name.Add("@campo");

            arr.Add(caption);
            name.Add("@caption");

            arr.Add(cod_tipo_filtro);
            name.Add("@cod_tipo_filtro");

            arr.Add(valor_por_defecto);
            name.Add("@valor_por_defecto");

            arr.Add(cod_parametros_query);
            name.Add("@cod_parametros_query");
            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int UpdateReducido(string campo, string caption, int cod_tipo_filtro, string valor_por_defecto, int cod_parametros_query)
        {
            string sql = @"UPDATE       cgq_parametrosquery
SET  campo = @campo, caption = @caption, cod_tipo_filtro = @cod_tipo_filtro, valor_por_defecto = @valor_por_defecto
WHERE        (cod_parametros_query = @cod_parametros_query)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();


            arr.Add(campo);
            name.Add("@campo");

            arr.Add(caption);
            name.Add("@caption");

            arr.Add(cod_tipo_filtro);
            name.Add("@cod_tipo_filtro");

            arr.Add(valor_por_defecto);
            name.Add("@valor_por_defecto");

            arr.Add(cod_parametros_query);
            name.Add("@cod_parametros_query");
            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int DeleteByCodQuery(int cod_query)
        {
            string sql = @"DELETE FROM cgq_parametrosquery WHERE        (cod_query = @cod_query)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_query);
            name.Add("@cod_query");
            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }


        public void FillByCod_query(dsSPXQuery.cgq_parametrosqueryDataTable tabla, int cod_query)
        {
            string sql = sentenciaBase + @" WHERE (cod_query = @cod_query) ";
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
