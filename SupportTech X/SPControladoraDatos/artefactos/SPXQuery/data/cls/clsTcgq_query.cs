using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPControladoraDatos.artefactos.SPXQuery.data.cls
{
    class clsTcgq_query : SPXdata.BD.clsAdaptador
    {
        #region copiar y pegar en todas las tablas
        public dsSPXQuery.cgq_queryDataTable tabla;

        public clsTcgq_query()
        {
            tabla = new dsSPXQuery.cgq_queryDataTable();
            tablaMaestra = (System.Data.DataTable)tabla;
            nombreLlave = "cod_query";
            nombreTabla = "cgq_query";
            cargarCamposSelect();
        }

        #endregion

        public long Insert(string nombre_query, string sentencia_sql, bool es_pivote, bool empiezo_con_columnas,
            DateTime? ultima_fecha_generacion, int? cod_linea, bool filtra_fecha, int? cod_origen_datos,string campo_fecha,
            int periodo_inicial, bool generar_tabla_auxiliar, bool generar_grafica, string tipo_grafica, bool limpia_tabla_auxiliar, string columna_agregado, string agregado)
        {
            string sql = @"INSERT INTO cgq_query
                         (nombre_query, sentencia_sql, es_pivote, empiezo_con_columnas, ultima_fecha_generacion, cod_linea,
filtra_fecha,  cod_origen_datos, campo_fecha, periodo_inicial, 
        generar_tabla_auxiliar, generar_grafica, tipo_grafica, limpia_tabla_auxiliar,columna_agregado,agregado)
                        VALUES        
                        (
        @nombre_query, @sentencia_sql, @es_pivote, @empiezo_con_columnas, @ultima_fecha_generacion, @cod_linea,
        @filtra_fecha,  @cod_origen_datos, @campo_fecha, @periodo_inicial, 
        @generar_tabla_auxiliar, @generar_grafica, @tipo_grafica, @limpia_tabla_auxiliar,@columna_agregado,@agregado)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(nombre_query);
            name.Add("@nombre_query");

            arr.Add(sentencia_sql);
            name.Add("@sentencia_sql");

            arr.Add(es_pivote);
            name.Add("@es_pivote");

            arr.Add(columna_agregado);
            name.Add("@columna_agregado");
            
            arr.Add(agregado);
            name.Add("@agregado");

            arr.Add(empiezo_con_columnas);
            name.Add("@empiezo_con_columnas");

            arr.Add(ultima_fecha_generacion);
            name.Add("@ultima_fecha_generacion");

            arr.Add(cod_linea);
            name.Add("@cod_linea");
           
            arr.Add(filtra_fecha);
            name.Add("@filtra_fecha");

            arr.Add(cod_origen_datos);
            name.Add("@cod_origen_datos");

            arr.Add(periodo_inicial);
            name.Add("@periodo_inicial");

            arr.Add(campo_fecha);
            name.Add("@campo_fecha");

            arr.Add(generar_tabla_auxiliar);
            name.Add("@generar_tabla_auxiliar");

            arr.Add(generar_grafica);
            name.Add("@generar_grafica");

            arr.Add(tipo_grafica);
            name.Add("@tipo_grafica");

            arr.Add(limpia_tabla_auxiliar);
            name.Add("@limpia_tabla_auxiliar");
           

            #endregion
           DataConector obj = new DataConector();
            
            obj.iniciarTransaccion();
            obj.ejecutarComando(sql, arr, name);//ejecuta el insert
            sql = "SELECT @@identity";
            object a=obj.ejecutarProcedimiento(sql, null, null);
            obj.commitTransaccion();
            long res = 0;
            if (a != null && a != System.DBNull.Value)
                res = long.Parse(a.ToString());
            ultimo_id_insertado = res;
            return res;
        }

        public int UpdateQuery(string nombre_query, string sentencia_sql, bool es_pivote, bool empiezo_con_columnas,
         DateTime? ultima_fecha_generacion, int? cod_linea,
             bool filtra_fecha,int?  cod_origen_datos,string campo_fecha,int periodo_inicial,
        bool generar_tabla_auxiliar, bool generar_grafica, string tipo_grafica, bool limpia_tabla_auxiliar, string columna_agregado, string agregado, int cod_query)
        {
            string sql = @"UPDATE       cgq_query
                SET
                nombre_query = @nombre_query, sentencia_sql = @sentencia_sql, es_pivote = @es_pivote, empiezo_con_columnas = @empiezo_con_columnas, 
                         ultima_fecha_generacion = @ultima_fecha_generacion, cod_linea = @cod_linea,
 filtra_fecha=@filtra_fecha,  cod_origen_datos=@cod_origen_datos, campo_fecha=@campo_fecha, periodo_inicial=@periodo_inicial, 
        generar_tabla_auxiliar=@generar_tabla_auxiliar, generar_grafica=@generar_grafica, tipo_grafica=@tipo_grafica, 
limpia_tabla_auxiliar=@limpia_tabla_auxiliar, columna_agregado=@columna_agregado, agregado=@agregado
                WHERE        (cod_query = @cod_query)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(nombre_query);
            name.Add("@nombre_query");

            arr.Add(sentencia_sql);
            name.Add("@sentencia_sql");

            arr.Add(es_pivote);
            name.Add("@es_pivote");

            arr.Add(empiezo_con_columnas);
            name.Add("@empiezo_con_columnas");

            arr.Add(columna_agregado);
            name.Add("@columna_agregado");
            
            arr.Add(agregado);
            name.Add("@agregado");

            arr.Add(ultima_fecha_generacion);
            name.Add("@ultima_fecha_generacion");

            arr.Add(cod_linea);
            name.Add("@cod_linea");

            arr.Add(cod_query);
            name.Add("@cod_query");

            arr.Add(filtra_fecha);
            name.Add("@filtra_fecha");
            
            arr.Add(cod_origen_datos);
            name.Add("@cod_origen_datos");
            
            arr.Add(campo_fecha);
            name.Add("@campo_fecha");
            
            arr.Add(periodo_inicial);
            name.Add("@periodo_inicial");
            
            arr.Add(generar_tabla_auxiliar);
            name.Add("@generar_tabla_auxiliar");
            
            arr.Add(generar_grafica);
            name.Add("@generar_grafica");
            
            arr.Add(tipo_grafica);
            name.Add("@tipo_grafica");
            
            arr.Add(limpia_tabla_auxiliar);
            name.Add("@limpia_tabla_auxiliar");
            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);

        }

        public void FillByCod_linea(dsSPXQuery.cgq_queryDataTable tabla,
          int cod_linea)
        {
            string sql = sentenciaBase + @"  where cod_linea=@cod_linea ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_linea);
            name.Add("@cod_linea");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }

        public void FillByCod_query(dsSPXQuery.cgq_queryDataTable tabla, int cod_query)
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

        public void FillByQueryxUsuarioxLinea(dsSPXQuery.cgq_queryDataTable tabla, int cod_usuario,
            int cod_linea, int cod_query)
        {
            string sql = sentenciaBase + @"
 LEFT JOIN
  cgq_queryxusuario ON cgq_queryxusuario.cod_query = cgq_query.cod_query
  LEFT JOIN cgq_queryxgrupo_usuario ON cgq_queryxgrupo_usuario.cod_query = cgq_query.cod_query
  LEFT JOIN grupousuario_usuario ON grupousuario_usuario.cod_usuario = cgq_queryxgrupo_usuario.cod_grupo_usuario
  WHERE
  (grupousuario_usuario.cod_usuario =@cod_usuario OR cgq_queryxusuario.cod_usuario=@cod_usuario)
and cgq_query.cod_linea =@cod_linea
WHERE (cod_query = @cod_query) ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_usuario);
            name.Add("@cod_usuario");

            arr.Add(cod_linea);
            name.Add("@cod_linea");

            arr.Add(cod_query);
            name.Add("@cod_query");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }

        public void FillByxUsuario(dsSPXQuery.cgq_queryDataTable tabla, int cod_usuario)
        {
            string sql = @"
SELECT distinct cgq_query.cod_query,cgq_query.nombre_query,
cast(cgq_query.sentencia_sql as char(200)) sentencia_sql,cgq_query.es_pivote,cgq_query.empiezo_con_columnas,cgq_query.ultima_fecha_generacion,cgq_query.cod_linea 
,filtra_fecha,  cod_origen_datos, campo_fecha, periodo_inicial, 
        generar_tabla_auxiliar, generar_grafica, tipo_grafica, limpia_tabla_auxiliar,columna_agregado,agregado

FROM cgq_query
    LEFT JOIN cgq_queryxusuario ON cgq_queryxusuario.cod_query = cgq_query.cod_query
    LEFT JOIN cgq_queryxgrupo_usuario ON cgq_queryxgrupo_usuario.cod_query = cgq_query.cod_query
    LEFT JOIN grupousuario_usuario ON grupousuario_usuario.cod_grupo_usuario = cgq_queryxgrupo_usuario.cod_grupo_usuario 
WHERE
  (grupousuario_usuario.cod_usuario =@cod_usuario
  or cgq_queryxusuario.cod_usuario=@cod_usuario )";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_usuario);
            name.Add("@cod_usuario");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }
            
    }
}
