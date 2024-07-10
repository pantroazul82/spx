using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPXSeguridad.data.cls
{

    public class clsTgrupo_usuario : SPXdata.BD.clsAdaptador
    {
        #region copiar y pegar en todas las tablas
        public SPXSeguridad.data.dsSPXSeguridad.grupo_usuarioDataTable tabla;

        public clsTgrupo_usuario()
        {
            tabla = new SPXSeguridad.data.dsSPXSeguridad.grupo_usuarioDataTable();
            tablaMaestra = (System.Data.DataTable)tabla;
            nombreLlave = "cod_grupo_usuario";
            nombreTabla = "grupo_usuario";
            cargarCamposSelect();  
        }

        #endregion


        //vamos con el insert
        public long Insert(string nombre_grupo_usuario) 
        {
            string sql = "insert into grupo_usuario (nombre_grupo_usuario) values (@nombre_grupo_usuario)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(nombre_grupo_usuario);
            name.Add("@nombre_grupo_usuario");
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

        public int UpdateQuery(string nombre_grupo_usuario, int cod_grupo_usuario)
        {
            #region sentencia sql
            string sql = @"UPDATE grupo_usuario SET  
                            nombre_grupo_usuario = @nombre_grupo_usuario 
                            WHERE
                            cod_grupo_usuario = @cod_grupo_usuario";
            #endregion
            #region parametros
            List< object> arr=new List<object>();
            List<string> name = new List<string>();

            arr.Add(nombre_grupo_usuario);
            name.Add("@nombre_grupo_usuario");
            
           
            arr.Add(cod_grupo_usuario);
            name.Add("@cod_grupo_usuario");
#endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql,arr,name);
        }

        public void FillByUsuario(SPXSeguridad.data.dsSPXSeguridad.grupo_usuarioDataTable tabla,int cod_usuario)
        {
            string sql = @"SELECT grupo_usuario.cod_grupo_usuario, grupo_usuario.nombre_grupo_usuario 
                           FROM grupo_usuario 
                            INNER JOIN grupousuario_usuario ON grupousuario_usuario.cod_grupo_usuario = grupo_usuario.cod_grupo_usuario 
                            WHERE (grupousuario_usuario.cod_usuario = @cod_usuario) ORDER BY grupo_usuario.nombre_grupo_usuario";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(cod_usuario);
            name.Add("@cod_usuario");
            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql,(System.Data.DataTable)tabla,false,arr,name);
        }

        public void FillByCod_rpt(SPXSeguridad.data.dsSPXSeguridad.grupo_usuarioDataTable tabla, int cod_rpt)
        {
             string sql = @" SELECT        gu.cod_grupo_usuario, gu.nombre_grupo_usuario
                            FROM            grupo_usuario gu LEFT OUTER JOIN
                            rpt_grupousuario rpg 
                            ON rpg.cod_grupo_usuario = gu.cod_grupo_usuario
                            WHERE        (rpg.cod_rpt = @cod_rpt)";

             #region parametros
             List<object> arr = new List<object>();
             List<string> name = new List<string>();

             arr.Add(cod_rpt);
             name.Add("@cod_rpt");
             #endregion
            DataConector obj = new DataConector();
             obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }

        public void FillBycod_query(SPXSeguridad.data.dsSPXSeguridad.grupo_usuarioDataTable tabla, int cod_query)
         {
             string sql = @"SELECT        gu.cod_grupo_usuario, gu.nombre_grupo_usuario
FROM            grupo_usuario gu LEFT OUTER JOIN
                         cgq_queryxgrupo_usuario cgg ON gu.cod_grupo_usuario = cgg.cod_grupo_usuario
WHERE        (cgg.cod_query = @cod_query)";
             #region parametros
             List<object> arr = new List<object>();
             List<string> name = new List<string>();

             arr.Add(cod_query);
             name.Add("@cod_query");

             #endregion
            DataConector obj = new DataConector();
             obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }

        public void FillBycod_grupo_usuario(SPXSeguridad.data.dsSPXSeguridad.grupo_usuarioDataTable tabla, int cod_grupo_usuario)
        {
            string sql = @"SELECT cod_grupo_usuario, nombre_grupo_usuario FROM grupo_usuario WHERE (cod_grupo_usuario = @cod_grupo_usuario)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(cod_grupo_usuario);
            name.Add("@cod_grupo_usuario");
            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql,tabla,false, arr, name);
        }

        public void FillBynombre_grupo_usuario(SPXSeguridad.data.dsSPXSeguridad.grupo_usuarioDataTable tabla, string nombre_grupo_usuario)
        {
            string sql = @"SELECT cod_grupo_usuario, nombre_grupo_usuario FROM grupo_usuario WHERE (nombre_grupo_usuario = @nombre_grupo_usuario)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(nombre_grupo_usuario);
            name.Add("@nombre_grupo_usuario");
            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }
    }
}
