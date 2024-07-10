using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPXSeguridad.data.cls
{

    public class clsTlinea : SPXdata.BD.clsAdaptador
    {
        #region copiar y pegar en todas las tablas
        public SPXSeguridad.data.dsSPXSeguridad.lineaDataTable tabla;

        public clsTlinea()
        {
            tabla = new SPXSeguridad.data.dsSPXSeguridad.lineaDataTable();
            tablaMaestra = (System.Data.DataTable)tabla;
            nombreLlave = "cod_linea";
            nombreTabla = "linea";
            cargarCamposSelect();
        }

        #endregion


        public long Insert(string nombre_linea, string contacto_linea, string email_linea, string telefono_linea, string direccion_linea, string fax_linea, byte[] logo)
        {
            string sql = @"INSERT INTO linea
                         (nombre_linea, contacto_linea, email_linea, telefono_linea, direccion_linea, fax_linea, logo)
                            VALUES        
                        (@nombre_linea, @contacto_linea, @email_linea, @telefono_linea, @direccion_linea, @fax_linea, @logo)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(nombre_linea);
            name.Add("@nombre_linea");

            arr.Add(contacto_linea);
            name.Add("@contacto_linea");

            arr.Add(email_linea);
            name.Add("@email_linea");

            arr.Add(telefono_linea);
            name.Add("@telefono_linea");

            arr.Add(direccion_linea);
            name.Add("@direccion_linea");

            arr.Add(fax_linea);
            name.Add("@fax_linea");

            arr.Add(logo);
            name.Add("@logo|System.Byte[]");
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

      
        public void FillBycod_linea(SPXSeguridad.data.dsSPXSeguridad.lineaDataTable tabla, int cod_linea)
        {
            string sql = sentenciaBase + @" where cod_linea=@cod_linea ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_linea);
            name.Add("@cod_linea");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }

        public void FillByLineasPorPermisoUsuarioSinLogo(SPXSeguridad.data.dsSPXSeguridad.lineaDataTable tabla, int cod_usuario)
        {
            string sql = @"SELECT 
  distinct  linea.cod_linea, nombre_linea, contacto_linea, email_linea, telefono_linea, direccion_linea, fax_linea
FROM linea
  LEFT JOIN lineasxusuario ON lineasxusuario.cod_linea = linea.cod_linea

  LEFT JOIN grupo_usuarioxlinea ON grupo_usuarioxlinea.cod_linea = linea.cod_linea
  LEFT JOIN grupousuario_usuario ON grupousuario_usuario.cod_grupo_usuario = grupo_usuarioxlinea.cod_grupo_usuario

WHERE
  lineasxusuario.cod_usuario = @cod_usuario OR grupousuario_usuario.cod_usuario = @cod_usuario

ORDER BY
  nombre_linea ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_usuario);
            name.Add("@cod_usuario");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }

        public void FillSinLogo(SPXSeguridad.data.dsSPXSeguridad.lineaDataTable tabla)
        {
            string sql = @"SELECT        cod_linea, nombre_linea, contacto_linea, email_linea, telefono_linea, direccion_linea, fax_linea, logo 
                            FROM linea ";

           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, null, null);
        }


        public int UpdateLogo(byte[] logo, int cod_linea)
        {
            string sql = @"UPDATE linea SET  logo = @logo WHERE cod_linea = @cod_linea";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(logo);
            name.Add("@logo|System.Byte[]");

            arr.Add(cod_linea);
            name.Add("@cod_linea");


            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int UpdateQuery(string nombre_linea, string contacto_linea, string email_linea,
           string telefono_linea, string direccion_linea, string fax_linea, byte[] logo, int cod_linea)
        {
            string sql = @"UPDATE 
                            linea SET 
                nombre_linea = @nombre_linea, contacto_linea = @contacto_linea, email_linea = @email_linea, telefono_linea = @telefono_linea,
                direccion_linea = @direccion_linea, fax_linea = @fax_linea, logo = @logo 
                WHERE cod_linea = @cod_linea";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(nombre_linea);
            name.Add("@nombre_linea");

            arr.Add(contacto_linea);
            name.Add("@contacto_linea");

            arr.Add(email_linea);
            name.Add("@email_linea");

            arr.Add(telefono_linea);
            name.Add("@telefono_linea");

            arr.Add(direccion_linea);
            name.Add("@direccion_linea");

            arr.Add(fax_linea);
            name.Add("@fax_linea");

            arr.Add(logo);
            name.Add("@logo|System.Byte[]");

            arr.Add(cod_linea);
            name.Add("@cod_linea");
            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public System.Drawing.Image verLogo(int cod_linea)
        {
            string sql = @"SELECT logo FROM linea where cod_linea=" + cod_linea + "";
           DataConector obj = new DataConector();
            object ob = obj.ejecutarProcedimiento(sql);
            if (ob == null || ob == System.DBNull.Value) return null;

            System.IO.MemoryStream ms = new System.IO.MemoryStream((byte[])ob);
            try
            {
                return System.Drawing.Image.FromStream(ms);
            }catch(Exception){
                return null;
            }
        }
    }
}
