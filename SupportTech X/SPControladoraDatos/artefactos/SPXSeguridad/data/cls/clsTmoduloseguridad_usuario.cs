using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPXSeguridad.data.cls
{

    public class clsTmoduloseguridad_usuario : SPXdata.BD.clsAdaptador
    {
        #region copiar y pegar en todas las tablas
        public SPXSeguridad.data.dsSPXSeguridad.moduloseguridad_usuarioDataTable tabla;

        public clsTmoduloseguridad_usuario()
        {
            tabla = new dsSPXSeguridad.moduloseguridad_usuarioDataTable();
            tablaMaestra = (System.Data.DataTable)tabla;
            nombreLlave = "cod_moduloseguridad_usuario";
            nombreTabla = "moduloseguridad_usuario";
            cargarCamposSelect();
        }

        #endregion


        //vamos con el insert
        public int Insert(int cod_usuario,bool? control_total,bool? modificar,bool? lectura_ejecucion,bool? escribir,bool? eliminar
            ,bool? imprimir,bool? denegar,int cod_modulo_seguridad)
        {
            SPXSeguridad.data.cls.clsTmoduloseguridad_usuario o = new clsTmoduloseguridad_usuario();
            
            string sql = @"INSERT INTO moduloseguridad_usuario
                         (cod_usuario, control_total, modificar, lectura_ejecucion, escribir, eliminar, imprimir, denegar, cod_modulo_seguridad)
VALUES        (@cod_usuario, @control_total, @modificar, @lectura_ejecucion, @escribir, @eliminar, @imprimir, @denegar, @cod_modulo_seguridad)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(cod_usuario);
            name.Add("@cod_usuario");

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

            arr.Add(cod_modulo_seguridad);
            name.Add("@cod_modulo_seguridad");

        #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int UpdateQuery( bool? control_total, bool? modificar, bool? lectura_ejecucion, bool? escribir, bool? eliminar
            , bool? imprimir, bool? denegar,  int cod_moduloseguridad_usuario)
        {
            #region sentencia sql
            string sql = @"UPDATE 
moduloseguridad_usuario SET 
control_total = @control_total, modificar = @modificar, lectura_ejecucion = @lectura_ejecucion,
escribir = @escribir, eliminar = @eliminar, imprimir = @imprimir, denegar = @denegar 
WHERE 
cod_moduloseguridad_usuario = @cod_moduloseguridad_usuario";
            #endregion
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_moduloseguridad_usuario);
            name.Add("@cod_moduloseguridad_usuario");

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


            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int UpdateByForaneas( bool? control_total, bool? modificar, bool? lectura_ejecucion, bool? escribir, bool? eliminar
          , bool? imprimir, bool? denegar, int cod_modulo_seguridad, int cod_usuario)
        {
            #region sentencia sql
            string sql = @"UPDATE 
moduloseguridad_usuario SET 
control_total = @control_total, modificar = @modificar, lectura_ejecucion = @lectura_ejecucion, 
escribir = @escribir, eliminar = @eliminar, imprimir = @imprimir, denegar = @denegar 
WHERE 
cod_modulo_seguridad= @cod_modulo_seguridad  AND cod_usuario = @cod_usuario";
            #endregion
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(cod_usuario);
            name.Add("@cod_usuario");

            arr.Add(cod_modulo_seguridad);
            name.Add("@cod_modulo_seguridad");
            
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



            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int DeleteBycod_moduloseguridad(int cod_moduloseguridad)
        {
            string sql = @"DELETE FROM 
moduloseguridad_usuario 
WHERE 
cod_moduloseguridad = @cod_moduloseguridad";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_moduloseguridad);
            name.Add("@cod_moduloseguridad");
            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int DeleteBycod_moduloseguridad_usuario(int cod_moduloseguridad_usuario)
        {
            string sql = @"DELETE FROM 
moduloseguridad_usuario 
WHERE 
cod_moduloseguridad_usuario = @cod_moduloseguridad_usuario";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_moduloseguridad_usuario);
            name.Add("@cod_moduloseguridad_usuario");
            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }
        
        public int DeleteBycod_usuario(int cod_usuario)
        {
            string sql = @"DELETE FROM 
moduloseguridad_usuario 
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

        public int DeleteQuery(int cod_usuario, int cod_moduloseguridad)
        {
            string sql = @"DELETE FROM 
moduloseguridad_usuario 
WHERE 
cod_moduloseguridad = @cod_moduloseguridad AND cod_usuario = @cod_usuario";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_moduloseguridad);
            name.Add("@cod_moduloseguridad");
            
            arr.Add(cod_usuario);
            name.Add("@cod_usuario");
            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public void FillBycod_moduloseguridad
            (SPXSeguridad.data.dsSPXSeguridad.moduloseguridad_usuarioDataTable tabla,
      int cod_modulo_seguridad)
        {
            string sql = sentenciaBase + @"  WHERE (cod_modulo_seguridad = @cod_modulo_seguridad) ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_modulo_seguridad);
            name.Add("@cod_modulo_seguridad");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }


        public void FillBycod_moduloseguridad_usuario
            (SPXSeguridad.data.dsSPXSeguridad.moduloseguridad_usuarioDataTable tabla,
      int cod_moduloseguridad_usuario)
        {
            string sql = sentenciaBase + @"   WHERE (cod_moduloseguridad_usuario = @cod_moduloseguridad_usuario) ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_moduloseguridad_usuario);
            name.Add("@cod_moduloseguridad_usuario");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }

        public void FillBycod_usuario
          (SPXSeguridad.data.dsSPXSeguridad.moduloseguridad_usuarioDataTable tabla,
    int cod_usuario)
        {
            string sql = sentenciaBase + @" WHERE (cod_usuario = @cod_usuario) ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_usuario);
            name.Add("@cod_usuario");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }

        public void FillByForaneas
        (SPXSeguridad.data.dsSPXSeguridad.moduloseguridad_usuarioDataTable tabla,
  int cod_usuario, int cod_modulo_seguridad)
        {
            string sql = sentenciaBase + @" 
where cod_usuario =@cod_usuario and cod_modulo_seguridad=@cod_modulo_seguridad ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_usuario);
            name.Add("@cod_usuario");

            arr.Add(cod_modulo_seguridad);
            name.Add("@cod_modulo_seguridad");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }
   
    }
}
