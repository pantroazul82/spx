using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPXSeguridad.data.cls
{

    public class clsTusuario : SPXdata.BD.clsAdaptador
    {
        #region copiar y pegar en todas las tablas
        public SPXSeguridad.data.dsSPXSeguridad.usuarioDataTable tabla;

        public clsTusuario()
        {
            tabla = new dsSPXSeguridad.usuarioDataTable();
            tablaMaestra = (System.Data.DataTable)tabla;
            nombreLlave = "cod_usuario";
            nombreTabla = "usuario";
            cargarCamposSelect();
        }

        #endregion

        public long Insert(string login,string nombre,string documento,string password,bool es_bloqueado,string correo,
            int intentos,DateTime fecha_cambio_password,int? cod_tipo_documento)
        {
            string sql = @"INSERT INTO usuario
                         (login, nombre, documento, password, es_bloqueado, correo, intentos,
fecha_cambio_password, cod_tipo_documento)
VALUES        (@login, @nombre, @documento, @password, @es_bloqueado, @correo, @intentos, @fecha_cambio_password, @cod_tipo_documento)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(login);
            name.Add("@login");

            arr.Add(nombre);
            name.Add("@nombre");

            arr.Add(documento);
            name.Add("@documento");

            arr.Add(password);
            name.Add("@password");

            arr.Add(es_bloqueado);
            name.Add("@es_bloqueado");

            arr.Add(correo);
            name.Add("@correo");

            arr.Add(intentos);
            name.Add("@intentos");


            arr.Add(fecha_cambio_password);
            name.Add("@fecha_cambio_password");


            arr.Add(cod_tipo_documento);
            name.Add("@cod_tipo_documento");


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

        public override void Fill(System.Data.DataTable dt)
        {
            string sql = @" SELECT        u.cod_usuario, u.login, u.nombre, u.documento, u.cod_tipo_documento, u.password, u.es_bloqueado, u.correo, u.intentos, u.fecha_cambio_password
FROM            usuario u order by u.nombre asc";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            
            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, dt, false, arr, name);
        }
        public void FillByCod_query(SPXSeguridad.data.dsSPXSeguridad.usuarioDataTable tabla,
          int cod_query)
        {
            string sql = @" SELECT        u.cod_usuario, u.login, u.nombre, u.documento, u.cod_tipo_documento, u.password, u.es_bloqueado, u.correo, u.intentos, u.fecha_cambio_password
FROM            usuario u LEFT OUTER JOIN
                         cgq_queryxusuario cgu ON u.cod_usuario = cgu.cod_usuario
WHERE        (cgu.cod_query = @cod_query) ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_query);
            name.Add("@cod_query");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }

        public void FillByCod_rpt(SPXSeguridad.data.dsSPXSeguridad.usuarioDataTable tabla,  int cod_rpt)
        {
            string sql = @"SELECT        u.cod_usuario, u.login, u.nombre, u.documento, u.cod_tipo_documento, u.password, u.es_bloqueado, u.correo, u.intentos, u.fecha_cambio_password
FROM usuario u 
LEFT OUTER JOIN rptxusuario rpu ON u.cod_usuario = rpu.cod_usuario
WHERE (rpu.cod_rpt = @cod_rpt) ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_rpt);
            name.Add("@cod_rpt");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }

        public void FillBycod_usuario(SPXSeguridad.data.dsSPXSeguridad.usuarioDataTable tabla, int cod_usuario)
        {
            string sql = @"SELECT cod_tipo_documento, cod_usuario, correo, documento, es_bloqueado, fecha_cambio_password, intentos, rtrim(login) login, nombre, password FROM usuario WHERE (cod_usuario = @cod_usuario) ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_usuario);
            name.Add("@cod_usuario");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }

        public void FillByCodEstadoMovimento(SPXSeguridad.data.dsSPXSeguridad.usuarioDataTable tabla, int cod_estado_movimiento)
        {
            string sql = @"
SELECT distinct
  usuario.cod_usuario, usuario.login, usuario.nombre, usuario.documento, usuario.password, usuario.es_bloqueado, usuario.correo, usuario.intentos, usuario.fecha_cambio_password, usuario.cod_tipo_documento
FROM
  usuario
  LEFT JOIN estado_movimientoxusuario ON estado_movimientoxusuario.cod_usuario = usuario.cod_usuario
  LEFT JOIN grupousuario_usuario ON grupousuario_usuario.cod_usuario = usuario.cod_usuario
  LEFT JOIN estado_movimientoxgrupo_usuario ON estado_movimientoxgrupo_usuario.cod_grupo_usuario = grupousuario_usuario.cod_grupo_usuario

WHERE
  estado_movimientoxusuario.cod_estado_movimiento = @cod_estado_movimiento
  OR estado_movimientoxgrupo_usuario.cod_estado_movimiento = @cod_estado_movimiento
ORDER BY
  usuario.nombre ASC";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_estado_movimiento);
            name.Add("@cod_estado_movimiento");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }

        public void FillBylogin(SPXSeguridad.data.dsSPXSeguridad.usuarioDataTable tabla, string login)
        {
            string sql = @"SELECT cod_tipo_documento, cod_usuario, correo, documento, es_bloqueado, fecha_cambio_password, intentos, rtrim(login) login, nombre, password FROM usuario WHERE (login = @login) ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(login);
            name.Add("@login");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }

        public void FillByresponsable_proceso(SPXSeguridad.data.dsSPXSeguridad.usuarioDataTable tabla, int cod_proceso)
        {
            string sql = @"SELECT       distinct  cod_usuario, rtrim(login) login, nombre, documento,'' password, es_bloqueado, correo, intentos, fecha_cambio_password, cod_tipo_documento
FROM            usuario
  JOIN responsable_proceso ON responsable_proceso.cod_responsable = usuario.cod_usuario 
WHERE
  responsable_proceso.cod_proceso = @cod_proceso order by usuario.nombre";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_proceso);
            name.Add("@cod_proceso");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }

        public void FillByPermiso(SPXSeguridad.data.dsSPXSeguridad.usuarioDataTable tabla, int cod_funcionalidad)
        {
            string sql = @"SELECT   distinct     
u.cod_usuario, rtrim(u.login) login, u.nombre, u.documento, u.cod_tipo_documento, '' password,
 u.es_bloqueado, u.correo, u.intentos, u.fecha_cambio_password
FROM            usuario u 
left join funcionalidad_usuario on funcionalidad_usuario.cod_usuario = u.cod_usuario


left join grupousuario_usuario on grupousuario_usuario.cod_usuario = u.cod_usuario
left join funcionalidad_grupousuario on funcionalidad_grupousuario.cod_grupo_usuario = grupousuario_usuario.cod_grupo_usuario

where 
(funcionalidad_usuario.cod_funcionalidad =@cod_funcionalidad and funcionalidad_usuario.control_total =1 )
or 
(dbo.funcionalidad_grupousuario.cod_funcionalidad=@cod_funcionalidad and funcionalidad_grupousuario.control_total=1 )
order by login";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_funcionalidad);
            name.Add("@cod_funcionalidad");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }

        public System.Data.DataTable getDataByPermiso( int cod_funcionalidad)
        {
            string sql = @"SELECT   distinct     
u.cod_usuario, u.login, u.nombre, u.documento, u.cod_tipo_documento
FROM            usuario u 
left join funcionalidad_usuario on funcionalidad_usuario.cod_usuario = u.cod_usuario


left join grupousuario_usuario on grupousuario_usuario.cod_usuario = u.cod_usuario
left join funcionalidad_grupousuario on funcionalidad_grupousuario.cod_grupo_usuario = grupousuario_usuario.cod_grupo_usuario

where (funcionalidad_usuario.cod_funcionalidad =@cod_funcionalidad and funcionalidad_usuario.control_total =1)
or (dbo.funcionalidad_grupousuario.cod_funcionalidad=@cod_funcionalidad and funcionalidad_grupousuario.control_total =1)
order by login";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_funcionalidad);
            name.Add("@cod_funcionalidad");

            #endregion
            System.Data.DataTable tabla = new System.Data.DataTable();
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
            return tabla;
        }

        public System.Data.DataTable getDataByGrupo(int cod_grupo_usuario)
        {
            string sql = @"SELECT   distinct     
u.cod_usuario, u.login, u.nombre, u.documento, u.cod_tipo_documento
FROM            usuario u 
left join grupousuario_usuario on grupousuario_usuario.cod_usuario = u.cod_usuario

where grupousuario_usuario.cod_grupo_usuario = @cod_grupo_usuario
order by login";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_grupo_usuario);
            name.Add("@cod_grupo_usuario");

            #endregion
            System.Data.DataTable tabla = new System.Data.DataTable();
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
            return tabla;
        }


        public int UpdateBloqueado(bool es_bloqueado, int cod_usuario)
        {
            string sql = @"UPDATE usuario SET es_bloqueado = @es_bloqueado, intentos = 0 
WHERE cod_usuario = @cod_usuario";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(es_bloqueado);
            name.Add("@es_bloqueado");

            arr.Add(cod_usuario);
            name.Add("@cod_usuario");       

            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int UpdatePassword(string password,DateTime fechaCambio, int cod_usuario)
        {
            string sql = @"UPDATE usuario SET password = @password,
fecha_cambio_password = @fechaCambio 
WHERE cod_usuario = @cod_usuario";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(password);
            name.Add("@password");

            arr.Add(fechaCambio);
            name.Add("@fechaCambio");

            arr.Add(cod_usuario);
            name.Add("@cod_usuario");

            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int UpdateQuery(string login, string nombre, string documento, bool es_bloqueado, string correo,
         int intentos, int? cod_tipo_documento,int cod_usuario)
        {
            string sql = @"UPDATE 
usuario SET login = @login, nombre = @nombre, documento = @documento, es_bloqueado = @es_bloqueado, correo = @correo, intentos = @intentos,cod_tipo_documento=@cod_tipo_documento 
WHERE 
cod_usuario = @cod_usuario";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(cod_usuario);
            name.Add("@cod_usuario");

            arr.Add(login);
            name.Add("@login");

            arr.Add(nombre);
            name.Add("@nombre");

            arr.Add(documento);
            name.Add("@documento");

            arr.Add(es_bloqueado);
            name.Add("@es_bloqueado");

            arr.Add(correo);
            name.Add("@correo");

            arr.Add(intentos);
            name.Add("@intentos");



            arr.Add(cod_tipo_documento);
            name.Add("@cod_tipo_documento|System.Int32");


            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public string verNombre(int cod_usuario)
        { 
           DataConector obj=new DataConector();
            string sql = "SELECT nombre from usuario where cod_usuario='" + cod_usuario + "'";
            string a = obj.ejecutarProcedimiento(sql).ToString();
            return a;
        }

    }
}

