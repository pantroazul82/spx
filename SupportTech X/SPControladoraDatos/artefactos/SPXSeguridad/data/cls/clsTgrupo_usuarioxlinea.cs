using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPXSeguridad.data.cls
{

    public class clsTgrupo_usuarioxlinea : SPXdata.BD.clsAdaptador
    {
        #region copiar y pegar en todas las tablas
        public SPXSeguridad.data.dsSPXSeguridad.grupo_usuarioxlineaDataTable tabla;

        public clsTgrupo_usuarioxlinea()
        {
            tabla = new dsSPXSeguridad.grupo_usuarioxlineaDataTable();
            tablaMaestra = (System.Data.DataTable)tabla;
            nombreLlave = "cod_grupo_usuarioxlinea";
            nombreTabla = "grupo_usuarioxlinea";
            cargarCamposSelect();
        }

        #endregion

        public int Insert(int cod_grupo_usuario, int cod_linea)
        {
            string sql = @"INSERT INTO grupo_usuarioxlinea
                         (cod_grupo_usuario, cod_linea)
VALUES        (@cod_grupo_usuario, @cod_linea)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(cod_grupo_usuario);
            name.Add("@cod_grupo_usuario");

            arr.Add(cod_linea);
            name.Add("@cod_linea");

            
            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }


        public int DeleteByCod_grupo_usuario(int cod_grupo_usuario)
        {
            string sql = @"DELETE FROM 
grupo_usuarioxlinea 
WHERE 
cod_grupo_usuario =@cod_grupo_usuario";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(cod_grupo_usuario);
            name.Add("@cod_grupo_usuario");

            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int DeleteByCod_grupo_usuarioxlinea(int cod_grupo_usuarioxlinea)
        {
            string sql = @"DELETE FROM grupo_usuarioxlinea
WHERE cod_grupo_usuarioxlinea = @cod_grupo_usuarioxlinea";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add (cod_grupo_usuarioxlinea);
            name.Add("@cod_grupo_usuarioxlinea");

            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int DeleteQuery(int cod_grupo_usuario, int cod_linea)
        {
            string sql = @"DELETE FROM grupo_usuarioxlinea
WHERE cod_grupo_usuario = @cod_grupo_usuario AND cod_linea = @cod_linea";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(cod_grupo_usuario);
            name.Add("@cod_grupo_usuario");

            arr.Add(cod_linea);
            name.Add("@cod_linea");

            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int DeletexLinea( int cod_linea)
        {
            string sql = @"DELETE FROM grupo_usuarioxlinea 
WHERE 
cod_linea =  @cod_linea";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

      

            arr.Add(cod_linea);
            name.Add("@cod_linea");

            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public void FillBycod_grupo_usuario(SPXSeguridad.data.dsSPXSeguridad.funcionalidadDataTable tabla,
        int cod_grupo_usuario)
        {
            string sql = sentenciaBase + @"  where  cod_grupo_usuario=@cod_grupo_usuario ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_grupo_usuario);
            name.Add("@cod_grupo_usuario");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }

        public void FillBycod_grupo_usuarioxlinea(SPXSeguridad.data.dsSPXSeguridad.funcionalidadDataTable tabla,
      int cod_grupo_usuarioxlinea)
        {
            string sql = sentenciaBase + @"  where cod_grupo_usuarioxlinea=@cod_grupo_usuarioxlinea ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_grupo_usuarioxlinea);
            name.Add("@cod_grupo_usuarioxlinea");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }

        public void FillBycod_linea(SPXSeguridad.data.dsSPXSeguridad.grupo_usuarioxlineaDataTable tabla,
     int cod_linea)
        {
            string sql = sentenciaBase + @" where cod_linea=@cod_linea";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
             arr.Add(cod_linea);
            name.Add("@cod_linea");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }


    }
}