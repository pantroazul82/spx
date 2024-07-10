using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPXSeguridad.data.cls
{

    public class clsTfuncionalidad_grupousuario : SPXdata.BD.clsAdaptador
    {
        #region copiar y pegar en todas las tablas
        public SPXSeguridad.data.dsSPXSeguridad.funcionalidad_grupousuarioDataTable tabla;

        public clsTfuncionalidad_grupousuario()
        {
            tabla = new SPXSeguridad.data.dsSPXSeguridad.funcionalidad_grupousuarioDataTable();
            tablaMaestra = (System.Data.DataTable)tabla;
            nombreLlave = "cod_funcionalidad_grupousuario";
            nombreTabla = "funcionalidad_grupousuario";
            cargarCamposSelect();
        }

        #endregion

        public int Insert(int cod_funcionalidad,int cod_grupo_usuario,bool? control_total,
            bool? modificar,bool? lectura_ejecucion,bool? escribir,bool? eliminar,bool? imprimir,bool? denegar)
        {
            string sql = @"INSERT INTO funcionalidad_grupousuario
                         (cod_funcionalidad, cod_grupo_usuario, control_total, modificar, lectura_ejecucion, escribir, eliminar, imprimir, denegar)
VALUES        (@cod_funcionalidad, @cod_grupo_usuario, @control_total, @modificar, @lectura_ejecucion, @escribir, @eliminar, @imprimir, @denegar)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(denegar);
            name.Add("@denegar");

            arr.Add(imprimir);
            name.Add("@imprimir");

            arr.Add(eliminar);
            name.Add("@eliminar");

            arr.Add(escribir);
            name.Add("@escribir");

            arr.Add(lectura_ejecucion);
            name.Add("@lectura_ejecucion");

            arr.Add(modificar);
            name.Add("@modificar");

            arr.Add(control_total);
            name.Add("@control_total");

            arr.Add(cod_grupo_usuario);
            name.Add("@cod_grupo_usuario");

            arr.Add(cod_funcionalidad);
            name.Add("@cod_funcionalidad");
            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int UpdateQuery(int cod_funcionalidad_grupo_usuario, bool? control_total,
            bool? modificar, bool? lectura_ejecucion, bool? escribir, bool? eliminar, bool? imprimir, bool? denegar)
        {
            string sql = @"UPDATE 
funcionalidad_grupousuario 
SET 
 control_total = @control_total, modificar = @modificar, lectura_ejecucion = @lectura_ejecucion, escribir = @escribir, eliminar = @eliminar, imprimir = @imprimir, denegar = @denegar 
WHERE 
cod_funcionalidad_grupo_usuario = @cod_funcionalidad_grupo_usuario";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(denegar);
            name.Add("@denegar");

            arr.Add(imprimir);
            name.Add("@imprimir");

            arr.Add(eliminar);
            name.Add("@eliminar");

            arr.Add(escribir);
            name.Add("@escribir");

            arr.Add(lectura_ejecucion);
            name.Add("@lectura_ejecucion");

            arr.Add(modificar);
            name.Add("@modificar");

            arr.Add(control_total);
            name.Add("@control_total");

            arr.Add(cod_funcionalidad_grupo_usuario);
            name.Add("@cod_funcionalidad_grupo_usuario");

            
            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int UpdateByForaneas(int cod_grupo_usuario, int cod_funcionalidad, bool? control_total,
      bool? modificar, bool? lectura_ejecucion, bool? escribir, bool? eliminar, bool? imprimir, bool? denegar)
        {
            string sql = @"UPDATE 
funcionalidad_grupousuario 
SET 
control_total = @control_total, modificar = @modificar, lectura_ejecucion = @lectura_ejecucion, escribir = @escribir, 
eliminar = @eliminar, imprimir = @imprimir, denegar = @denegar 
WHERE 
cod_funcionalidad = @cod_funcionalidad AND
cod_grupo_usuario = @cod_grupo_usuario";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(denegar);
            name.Add("@denegar");

            arr.Add(imprimir);
            name.Add("@imprimir");

            arr.Add(eliminar);
            name.Add("@eliminar");

            arr.Add(escribir);
            name.Add("@escribir");

            arr.Add(lectura_ejecucion);
            name.Add("@lectura_ejecucion");

            arr.Add(modificar);
            name.Add("@modificar");

            arr.Add(control_total);
            name.Add("@control_total");

            arr.Add(cod_funcionalidad);
            name.Add("@cod_funcionalidad");

            arr.Add(cod_grupo_usuario);
            name.Add("@cod_grupo_usuario");
#endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int DeleteQuery(int cod_funcionalidad, int cod_grupo_usuario)
        {
            string sql = @"DELETE FROM 
funcionalidad_grupousuario WHERE cod_funcionalidad = @cod_funcionalidad AND cod_grupo_usuario = @cod_grupo_usuario";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_funcionalidad);
            name.Add("@cod_funcionalidad");

            arr.Add(cod_grupo_usuario);
            name.Add("@cod_grupo_usuario");

            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int DeleteBycod_grupo_usuario(int cod_grupo_usuario)
        {
            string sql = @"DELETE FROM funcionalidad_grupousuario WHERE cod_grupo_usuario = @cod_grupo_usuario";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_grupo_usuario);
            name.Add("@cod_grupo_usuario");
            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int DeleteBycod_funcionalidad_grupo_usuario(int cod_funcionalidad_grupousuario)
        {
            string sql = @"DELETE FROM funcionalidad_grupousuario 
WHERE cod_funcionalidad_grupousuario = @cod_funcionalidad_grupousuario";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_funcionalidad_grupousuario);
            name.Add("@cod_funcionalidad_grupousuario");
            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int DeleteBycod_funcionalidad(int cod_funcionalidad)
        {
            string sql = @"DELETE FROM funcionalidad_grupousuario WHERE cod_funcionalidad = @cod_funcionalidad";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_funcionalidad);
            name.Add("@cod_funcionalidad");
            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public void FillBycod_grupo_usuarioandcod_funcionalidad(SPXSeguridad.data.dsSPXSeguridad.funcionalidad_grupousuarioDataTable tabla,
             int cod_funcionalidad, int cod_grupo_usuario)
        {
            string sql = sentenciaBase + @"  WHERE (cod_funcionalidad = @cod_funcionalidad) AND (cod_grupo_usuario = @cod_grupo_usuario) ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_funcionalidad);
            name.Add("@cod_funcionalidad");

            arr.Add(cod_grupo_usuario);
            name.Add("@cod_grupo_usuario");
            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }

        public void FillByUsuario(SPXSeguridad.data.dsSPXSeguridad.funcionalidad_grupousuarioDataTable tabla,
       int codusuario)
        {
            string sql = sentenciaBase + @" 
join grupousuario_usuario on grupousuario_usuario.cod_grupo_usuario = funcionalidad_grupousuario.cod_grupo_usuario 
where grupousuario_usuario.cod_usuario =@codusuario";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(codusuario);
            name.Add("@codusuario");
            
            #endregion
            DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }

        public void FillBycod_grupo_usuario(SPXSeguridad.data.dsSPXSeguridad.funcionalidad_grupousuarioDataTable tabla,
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

        public void FillBycod_funcionalidad(SPXSeguridad.data.dsSPXSeguridad.funcionalidad_grupousuarioDataTable tabla,
        int cod_funcionalidad)
        {
            string sql = sentenciaBase + @"  WHERE (cod_funcionalidad = @cod_funcionalidad) ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_funcionalidad);
            name.Add("@cod_funcionalidad");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }

        public void FillBycod_funcionalidad_grupo_usuario(SPXSeguridad.data.dsSPXSeguridad.funcionalidad_grupousuarioDataTable tabla,
        int cod_funcionalidad_grupo_usuario)
        {
            string sql = sentenciaBase + @"  WHERE (cod_funcionalidad_grupo_usuario = @cod_funcionalidad_grupo_usuario) ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_funcionalidad_grupo_usuario);
            name.Add("@cod_funcionalidad_grupo_usuario");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }

    }
}
