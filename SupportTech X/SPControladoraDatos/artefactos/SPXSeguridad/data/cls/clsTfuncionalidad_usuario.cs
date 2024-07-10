using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPXSeguridad.data.cls
{

    public class clsTfuncionalidad_usuario : SPXdata.BD.clsAdaptador
    {
        #region copiar y pegar en todas las tablas
        public SPXSeguridad.data.dsSPXSeguridad.funcionalidad_usuarioDataTable tabla;

        public clsTfuncionalidad_usuario()
        {
            tabla = new dsSPXSeguridad.funcionalidad_usuarioDataTable();
            tablaMaestra = (System.Data.DataTable)tabla;
            nombreLlave = "cod_funcionalidad_usuario";
            nombreTabla = "funcionalidad_usuario";
            cargarCamposSelect();
        }

        #endregion

        public int Insert(int cod_funcionalidad, int cod_usuario, bool? control_total, bool? modificar, bool? lectura_ejecucion, bool? escribir, bool? eliminar,
            bool? imprimir, bool? denegar)
        {
            string sql = @"INSERT INTO funcionalidad_usuario
                         (cod_funcionalidad, cod_usuario, control_total, modificar, lectura_ejecucion, escribir, eliminar, imprimir, denegar)
                        VALUES        
                        (@cod_funcionalidad, @cod_usuario, @control_total, @modificar, @lectura_ejecucion, @escribir, @eliminar, @imprimir, @denegar)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(cod_funcionalidad); name.Add("@cod_funcionalidad");

            arr.Add(cod_usuario); name.Add("@cod_usuario");

            arr.Add(control_total); name.Add("@control_total");

            arr.Add(modificar);  name.Add("@modificar");

            arr.Add(lectura_ejecucion); name.Add("@lectura_ejecucion");

            arr.Add(escribir); name.Add("@escribir");

            arr.Add(eliminar); name.Add("@eliminar");

            arr.Add(imprimir); name.Add("@imprimir");

            arr.Add(denegar); name.Add("@denegar");
            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int UpdateQuery( bool? control_total, bool? modificar, bool? lectura_ejecucion, bool? escribir, bool? eliminar,
            bool? imprimir, bool? denegar, int cod_funcionalidad_usuario)
        {
            string sql = @"UPDATE funcionalidad_usuario 
SET 
 control_total = @control_total, modificar = @modificar, lectura_ejecucion = @lectura_ejecucion, escribir = @escribir, eliminar = @eliminar, imprimir = @imprimir, denegar = @denegar 
WHERE 
cod_funcionalidad_usuario = @cod_funcionalidad_usuario";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(control_total);
            name.Add("@control_total");

            arr.Add(modificar);
            name.Add("@modificar");

            arr.Add(lectura_ejecucion);
            name.Add("@lectura_ejecucion");            

            arr.Add(escribir);
            name.Add("@escribir");

            arr.Add(eliminar);
            name.Add("@eliminar");

            arr.Add(imprimir);
            name.Add("@imprimir");

            arr.Add(denegar);
            name.Add("@denegar");

            arr.Add(cod_funcionalidad_usuario);
            name.Add("@cod_funcionalidad_usuario");
            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int UpdateByForaneas(bool? control_total, bool? modificar, bool? lectura_ejecucion, bool? escribir, bool? eliminar,
           bool? imprimir, bool? denegar, int cod_funcionalidad,int cod_usuario)
        {
            string sql = @"UPDATE funcionalidad_usuario 
SET 
control_total = @control_total, modificar = @modificar, lectura_ejecucion = @lectura_ejecucion, escribir = @escribir, eliminar = @eliminar, imprimir = @imprimir, denegar = @denegar 
WHERE cod_funcionalidad = @cod_funcionalidad AND cod_usuario = @cod_usuario";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(control_total);
            name.Add("@control_total");

            arr.Add(modificar);
            name.Add("@modificar");

            arr.Add(lectura_ejecucion);
            name.Add("@lectura_ejecucion");

            arr.Add(escribir);
            name.Add("@escribir");

            arr.Add(eliminar);
            name.Add("@eliminar");

            arr.Add(imprimir);
            name.Add("@imprimir");

            arr.Add(denegar);
            name.Add("@denegar");

            arr.Add(cod_funcionalidad);
            name.Add("@cod_funcionalidad");

            arr.Add(cod_usuario);
            name.Add("@cod_usuario");
            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int DeleteByCod_funcionalidad(int cod_funcionalidad)
        {
            string sql = @"DELETE FROM 
funcionalidad_usuario 
WHERE 
cod_funcionalidad = @cod_funcionalidad";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(cod_funcionalidad);
            name.Add("@cod_funcionalidad");

         
            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int DeleteBycod_funcionalidad_usuario(int cod_funcionalidad_usuario)
        {
            string sql = @"DELETE FROM 
funcionalidad_usuario WHERE 
cod_funcionalidad_usuario = @cod_funcionalidad_usuario";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(cod_funcionalidad_usuario);
            name.Add("@cod_funcionalidad_usuario");
            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int DeleteBycod_usuario(int cod_usuario)
        {
            string sql = @"DELETE FROM funcionalidad_usuario 
                            WHERE cod_usuario = @cod_usuario";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(cod_usuario);
            name.Add("@cod_usuario");
            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int DeleteQuery(int cod_funcionalidad,int cod_usuario)
        {
            string sql = @"DELETE FROM 
funcionalidad_usuario 
WHERE 
cod_funcionalidad = @cod_funcionalidad AND cod_usuario = @cod_usuario";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(cod_usuario);
            name.Add("@cod_usuario");

            arr.Add(cod_funcionalidad);
            name.Add("@cod_funcionalidad");
            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }



        public void fillByCod_usuario(SPXSeguridad.data.dsSPXSeguridad.funcionalidad_usuarioDataTable tabla,int cod_usuario)
        {
            string sql = sentenciaBase + @" WHERE cod_usuario = @cod_usuario";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_usuario);
            name.Add("@cod_usuario");
            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql,tabla,false, arr, name);
        }

        public void FillBycod_funcionalidad(SPXSeguridad.data.dsSPXSeguridad.funcionalidad_usuarioDataTable tabla,int cod_funcionalidad)
        {
            string sql = sentenciaBase + @" WHERE cod_funcionalidad = @cod_funcionalidad";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_funcionalidad);
            name.Add("@cod_funcionalidad");
            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }



        public void FillBycod_funcionalidadCodUsuario(SPXSeguridad.data.dsSPXSeguridad.funcionalidad_usuarioDataTable tabla, int cod_usuario,  int cod_funcionalidad)
        {
            string sql = sentenciaBase + @"  WHERE (cod_usuario = @cod_usuario) AND (cod_funcionalidad = @cod_funcionalidad)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_funcionalidad);
            name.Add("@cod_funcionalidad");

            arr.Add(cod_usuario);
            name.Add("@cod_usuario");
            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }
    }
}
