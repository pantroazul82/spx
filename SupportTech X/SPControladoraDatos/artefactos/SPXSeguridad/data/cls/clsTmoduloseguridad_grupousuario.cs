using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPXSeguridad.data.cls
{

    public class clsTmoduloseguridad_grupousuario : SPXdata.BD.clsAdaptador
    {
        #region copiar y pegar en todas las tablas
        public SPXSeguridad.data.dsSPXSeguridad.moduloseguridad_grupousuarioDataTable tabla;

        public clsTmoduloseguridad_grupousuario()
        {
            tabla = new dsSPXSeguridad.moduloseguridad_grupousuarioDataTable();
            tablaMaestra = (System.Data.DataTable)tabla;
            nombreLlave = "codmoduloseguridad_grupoUsuario";
            nombreTabla = "moduloseguridad_grupousuario";
            cargarCamposSelect();
        }

        #endregion


        public int Insert(int cod_grupo_usuario,int cod_modulo_seguridad,bool? control_total,
            bool? modificar,bool? lectura_ejecucion,bool? escribir,bool? eliminar,bool? imprimir,bool? denegar
            )
        {
            string sql = @"INSERT INTO moduloseguridad_grupousuario
                         (cod_grupo_usuario, control_total, modificar, lectura_ejecucion, escribir, eliminar,
imprimir, denegar, cod_modulo_seguridad)
VALUES        (@cod_grupo_usuario, @control_total, @modificar, @lectura_ejecucion, @escribir, @eliminar, @imprimir, @denegar, @cod_modulo_seguridad)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_grupo_usuario);
            name.Add("@cod_grupo_usuario");

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


        public int UpdateByForaneas(int cod_moduloseguridad_grupoUsuario, bool? control_total,
            bool? modificar,bool? lectura_ejecucion,bool? escribir,bool? eliminar,bool? imprimir,bool? denegar)
        {
            string sql = @"UPDATE 
moduloseguridad_grupousuario 
SET control_total = @control_total, modificar = @modificar, lectura_ejecucion = @lectura_ejecucion, escribir = @escribir, eliminar = @eliminar, imprimir = @imprimir, denegar = @denegar 
WHERE cod_moduloseguridad_grupoUsuario = @cod_moduloseguridad_grupoUsuario";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_moduloseguridad_grupoUsuario);
            name.Add("@cod_moduloseguridad_grupoUsuario");

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

        public int UpdateQuery(int cod_grupo_usuario, int cod_modulo_seguridad, bool? control_total,
          bool? modificar, bool? lectura_ejecucion, bool? escribir, bool? eliminar, bool? imprimir, bool? denegar)
        {
            string sql = @"UPDATE 
moduloseguridad_grupousuario SET 
 control_total = @control_total, modificar = @modificar, lectura_ejecucion = @lectura_ejecucion, escribir = @escribir, eliminar = @eliminar, imprimir = @imprimir, denegar = @denegar 
WHERE 
cod_grupo_usuario = @cod_grupo_usuario AND cod_modulo_seguridad = @cod_modulo_seguridad";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_grupo_usuario);
            name.Add("@cod_grupo_usuario");

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


        public int DeleteBycod_grupo_usuario(int cod_grupo_usuario)
        {
            string sql = @"DELETE FROM moduloseguridad_grupousuario 
                           WHERE cod_grupo_usuario = @cod_grupo_usuario";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_grupo_usuario);
            name.Add("@cod_grupo_usuario");

            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }


        public int DeleteBycod_moduloseguridad(int cod_moduloseguridad)
        {
            string sql = @"DELETE FROM 
moduloseguridad_grupousuario 
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


        public int DeleteBycod_moduloseguridad_grupoUsuario(int codmoduloseguridad_grupousuario)
        {
            string sql = @"DELETE FROM 
moduloseguridad_grupousuario 
WHERE codmoduloseguridad_grupousuario = @codmoduloseguridad_grupousuario";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(codmoduloseguridad_grupousuario);
            name.Add("@codmoduloseguridad_grupousuario");

            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }


        public int DeleteQuery(int cod_grupo_usuario, int cod_moduloseguridad)
        {
            string sql = @"DELETE FROM 
moduloseguridad_grupousuario 
WHERE 
cod_grupo_usuario = @cod_grupo_usuario AND cod_moduloseguridad = @cod_moduloseguridad";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_grupo_usuario);
            name.Add("@cod_grupo_usuario");

            arr.Add(cod_moduloseguridad);
            name.Add("@cod_moduloseguridad");

            #endregion
            DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }


        public void FillBycod_grupo_usuario(SPXSeguridad.data.dsSPXSeguridad.moduloseguridad_grupousuarioDataTable tabla,
        int cod_grupo_usuario)
        {
            string sql = sentenciaBase + @"  WHERE (cod_grupo_usuario = @cod_grupo_usuario) ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_grupo_usuario);
            name.Add("@cod_grupo_usuario");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }


        public void FillBycod_moduloseguridad(SPXSeguridad.data.dsSPXSeguridad.moduloseguridad_grupousuarioDataTable tabla,
        int cod_modulo_seguridad)
        {
            string sql = sentenciaBase + @" WHERE (cod_modulo_seguridad = @cod_modulo_seguridad)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_modulo_seguridad);
            name.Add("@cod_modulo_seguridad");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }

        public void FillBycod_moduloseguridad_grupoUsuario(SPXSeguridad.data.dsSPXSeguridad.moduloseguridad_grupousuarioDataTable tabla,
       int cod_moduloseguridad_grupoUsuario)
        {
            string sql = sentenciaBase + @" WHERE (cod_moduloseguridad_grupoUsuario = @cod_moduloseguridad_grupoUsuario)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add (cod_moduloseguridad_grupoUsuario);
            name.Add("@cod_moduloseguridad_grupoUsuario");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }

        public void FillByForaneas(SPXSeguridad.data.dsSPXSeguridad.moduloseguridad_grupousuarioDataTable tabla, int cod_modulo_seguridad, int cod_grupo_usuario)
        {
            string sql = sentenciaBase + @" where cod_modulo_seguridad = @cod_modulo_seguridad and cod_grupo_usuario = @cod_grupo_usuario";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_modulo_seguridad);
            name.Add("@cod_modulo_seguridad");

            arr.Add(cod_grupo_usuario);
            name.Add("@cod_grupo_usuario");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }

        public void FillByUsuario(SPXSeguridad.data.dsSPXSeguridad.moduloseguridad_grupousuarioDataTable tabla, int cod_usuario)
        {
            string sql = sentenciaBase + @" join grupousuario_usuario on grupousuario_usuario.cod_grupo_usuario = moduloseguridad_grupousuario.cod_grupo_usuario 
where grupousuario_usuario.cod_usuario =@cod_usuario";
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

