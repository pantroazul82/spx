using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPControladoraDatos.artefactos;

namespace SPControladoraDatos.artefactos.SPXQuery.data.cls
{
    class cgq_parametrosquery_ultimo_valor: SPXdata.BD.clsAdaptador
    {
        #region copiar y pegar en todas las tablas
        public dsSPXQuery.cgq_parametrosquery_ultimo_valorDataTable tabla;

        public cgq_parametrosquery_ultimo_valor()
        {
            tabla = new dsSPXQuery.cgq_parametrosquery_ultimo_valorDataTable();
            tablaMaestra = (System.Data.DataTable)tabla;
            nombreLlave = "cod_cgq_parametrosquery_ultimo_valor";
            nombreTabla = "cgq_parametrosquery_ultimo_valor";
            cargarCamposSelect();
        }

        #endregion

        public int Insert (int cod_parametros_query,string valor_asignado ,int cod_usuario)
        {
            string sql = @"INSERT INTO cgq_parametrosquery_ultimo_valor
                         (cod_parametros_query, valor_asignado, cod_usuario)
VALUES        (@cod_parametros_query, @valor_asignado, @cod_usuario)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(cod_parametros_query);
            name.Add("@cod_parametros_query");

            arr.Add(valor_asignado);
            name.Add("@valor_asignado");

            arr.Add(cod_usuario);
            name.Add("@cod_usuario");

            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int DeleteBycod_parametros_query(int cod_parametros_query)
        {
            string sql = @"DELETE from cgq_parametrosquery_ultimo_valor
                         
WHERE        (cod_parametros_query = @cod_parametros_query)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(cod_parametros_query);
            name.Add("@cod_parametros_query");

          
            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int UpdateQuery(int cod_parametros_query, string valor_asignado, int cod_usuario, int cod_cgq_parametrosquery_ultimo_valor)
        {
            string sql = @"UPDATE       cgq_parametrosquery_ultimo_valor
SET                cod_parametros_query = @cod_parametros_query, valor_asignado = @valor_asignado, cod_usuario=@cod_usuario
                         
WHERE        (cod_cgq_parametrosquery_ultimo_valor = @cod_cgq_parametrosquery_ultimo_valor)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(cod_parametros_query);
            name.Add("@cod_parametros_query");

            arr.Add(valor_asignado);
            name.Add("@valor_asignado");

            arr.Add(cod_usuario);
            name.Add("@cod_usuario");

            arr.Add(cod_cgq_parametrosquery_ultimo_valor);
            name.Add("@cod_cgq_parametrosquery_ultimo_valor");
            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int UpdateValor_asignado(string valor_asignado, int cod_cgq_parametrosquery_ultimo_valor)
        {
            string sql = @"UPDATE       cgq_parametrosquery_ultimo_valor
SET   valor_asignado = @valor_asignado
WHERE        (cod_cgq_parametrosquery_ultimo_valor = @cod_cgq_parametrosquery_ultimo_valor)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(valor_asignado);
            name.Add("@valor_asignado");

            arr.Add(cod_cgq_parametrosquery_ultimo_valor);
            name.Add("@cod_cgq_parametrosquery_ultimo_valor");
            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public void FillBycod_parametros_queryCodUsuario(dsSPXQuery.cgq_parametrosquery_ultimo_valorDataTable tabla, int cod_parametros_query,int cod_usuario)
        {
            string sql = sentenciaBase + @" WHERE (cod_parametros_query = @cod_parametros_query and cod_usuario=@cod_usuario) ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_parametros_query);
            name.Add("@cod_parametros_query");

            arr.Add(cod_usuario);
            name.Add("@cod_usuario");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }
    }
}

