using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPControladoraDatos.artefactos;

namespace SPControladoraDatos.artefactos.SPXQuery.data
{
    class cgq_tablas_pivote : clsAdaptador
    {
        #region copiar y pegar en todas las tablas
        public dsSPXQuery.cgq_tablas_pivoteDataTable tabla;

        public cgq_tablas_pivote()
        {
            tabla = new  dsSPXQuery.cgq_tablas_pivoteDataTable();
            tablaMaestra = (System.Data.DataTable)tabla;
            nombreLlave = "cod_cgq_tablas_pivote";
            nombreTabla = "cgq_tablas_pivote";
            cargarCamposSelect();
        }

        #endregion


        public long Insert(string campo, string caption, int cod_query, bool es_columna, bool es_fila)
        {
            string sql = @"INSERT INTO cgq_tablas_pivote 
                            (campo,caption,cod_query,es_columna, es_fila) VALUES 
                            (@campo,@caption,@cod_query,@es_columna, @es_fila)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(campo);
            name.Add("@campo");
            arr.Add(caption);
            name.Add("@caption");

            arr.Add(es_columna);
            name.Add("@es_columna");
            arr.Add(es_fila);
            name.Add("@es_fila");

            arr.Add(cod_query);
            name.Add("@cod_query");          
            #endregion
           DataConector obj = new DataConector();
            obj.iniciarTransaccion();
            obj.ejecutarComando(sql, arr, name);//ejecuta el insert 
            sql = "SELECT @@identity";
            object a = obj.ejecutarProcedimiento(sql, null, null);
            obj.commitTransaccion();
            long res = 0;
            if (a != null && a != System.DBNull.Value)
                res = long.Parse(a.ToString());
            ultimo_id_insertado = res;
            return res;
        }


        public int DeleteByCod_Query(int cod_query)
        {
            string sql = @"delete from cgq_tablas_pivote 
                            where cod_query=@cod_query";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_query);
            name.Add("@cod_query");
            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }



        public int UpdateQuery(string campo, string caption, bool es_columna, bool es_fila, int cod_cgq_tablas_pivote)
        {
            string sql = @"UPDATE cgq_tablas_pivote SET 
                                campo =@campo,caption =@caption,es_columna=@es_columna,es_fila=@es_fila
                            where cod_cgq_tablas_pivote=@cod_cgq_tablas_pivote";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(campo);
            name.Add("@campo");
            arr.Add(caption);
            name.Add("@caption");

            arr.Add(es_columna);
            name.Add("@es_columna");
            arr.Add(es_fila);
            name.Add("@es_fila");

            arr.Add(cod_cgq_tablas_pivote);
            name.Add("@cod_cgq_tablas_pivote");
            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

       public void FillBycod_cgq_tablas_pivote(dsSPXQuery.cgq_tablas_pivoteDataTable tabla,
       int cod_cgq_tablas_pivote)
        {
            string sql = sentenciaBase + @"  WHERE (cod_cgq_tablas_pivote = @cod_cgq_tablas_pivote) ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_cgq_tablas_pivote);
            name.Add("@cod_cgq_tablas_pivote");
            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }

        public void FillBycod_query(dsSPXQuery.cgq_tablas_pivoteDataTable tabla,int cod_query)
        {
            string sql = sentenciaBase + @"  WHERE (cod_query = @cod_query) ";
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
