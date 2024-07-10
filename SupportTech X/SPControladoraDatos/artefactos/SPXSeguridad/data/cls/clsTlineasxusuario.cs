using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPXSeguridad.data.cls
{

    public class clsTlineasxusuario: SPXdata.BD.clsAdaptador
    {
        #region copiar y pegar en todas las tablas
        public SPXSeguridad.data.dsSPXSeguridad.lineasxusuarioDataTable tabla;

        public clsTlineasxusuario()
        {
            tabla = new dsSPXSeguridad.lineasxusuarioDataTable();
            tablaMaestra = (System.Data.DataTable)tabla;
            nombreLlave = "cod_lineasxusuario";
            nombreTabla = "lineasxusuario";
            cargarCamposSelect();
        }

        #endregion

        public int Insert(int cod_linea, int cod_usuario)
        {
            string sql = @"INSERT INTO lineasxusuario
                         (cod_linea, cod_usuario)
VALUES        (@cod_linea, @cod_usuario)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_linea);
            name.Add("@cod_linea");

            arr.Add(cod_usuario);
            name.Add("@cod_usuario");


            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int DeleteByCod_linea(int cod_linea)
        {
            string sql = @"DELETE FROM lineasxusuario 
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


        public int DeleteBycod_lineasxusuario(int cod_lineasxusuario)
        {
            string sql = @"DELETE FROM 
lineasxusuario 
WHERE cod_lineasxusuario = @cod_lineasxusuario";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_lineasxusuario);
            name.Add("@cod_lineasxusuario");

            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }


        public int DeleteQuery(int cod_linea, int cod_usuario)
        {
            string sql = @"DELETE FROM 
lineasxusuario 
WHERE cod_linea = @cod_linea and cod_usuario=@cod_usuario";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_linea);
            name.Add("@cod_linea");

            arr.Add(cod_usuario);
            name.Add("@cod_usuario");

            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int DeletexUsuario(int cod_linea, int cod_usuario)
        {
            string sql = @"DELETE FROM 
lineasxusuario 
WHERE 
cod_usuario = @cod_usuario";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_usuario);
            name.Add("@cod_usuario");

            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }


        public void FillBycod_linea(SPXSeguridad.data.dsSPXSeguridad.lineasxusuarioDataTable tabla,
        int cod_linea)
        {
            string sql = sentenciaBase + @"  WHERE cod_linea=@cod_linea ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_linea);
            name.Add("@cod_linea");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }


        public void FillBycod_usuario(SPXSeguridad.data.dsSPXSeguridad.lineasxusuarioDataTable tabla,
        int cod_usuario)
        {
            string sql = sentenciaBase + @"  WHERE cod_usuario=@cod_usuario ";
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

