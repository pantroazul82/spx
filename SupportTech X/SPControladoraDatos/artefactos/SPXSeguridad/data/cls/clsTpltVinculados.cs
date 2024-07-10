using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPXSeguridad.data.cls
{

    public class clsTpltVinculados : SPXdata.BD.clsAdaptador
    {
        #region copiar y pegar en todas las tablas
        public SPXSeguridad.data.dsSPXSeguridad.pltVinculadosDataTable tabla;

        public clsTpltVinculados()
        {
            tabla = new dsSPXSeguridad.pltVinculadosDataTable();
            tablaMaestra = (System.Data.DataTable)tabla;
            nombreLlave = "codigo";
            nombreTabla = "pltVinculados";
            cargarCamposSelect();
            sentenciaBase = @"SELECT
  usuario.cod_usuario AS codigo, 1 AS tipo, nombre
FROM usuario JOIN moduloseguridad_usuario ON moduloseguridad_usuario.cod_usuario = usuario.cod_usuario";
        }

        public void FillBycod_funcionalidad(SPXSeguridad.data.dsSPXSeguridad.pltVinculadosDataTable tabla,
         int cod_funcionalidad)
        {
            string sql = @"SELECT
  usuario.cod_usuario AS codigo, 1 AS tipo, nombre
FROM
  usuario
  JOIN funcionalidad_usuario ON funcionalidad_usuario.cod_usuario = usuario.cod_usuario
WHERE
  funcionalidad_usuario.cod_funcionalidad = @cod_funcionalidad
UNION
SELECT
  grupo_usuario.cod_grupo_usuario AS codigo, 2 AS tipo, nombre_grupo_usuario
FROM
  grupo_usuario
  JOIN funcionalidad_grupousuario ON funcionalidad_grupousuario.cod_grupo_usuario = grupo_usuario.cod_grupo_usuario
WHERE
  funcionalidad_grupousuario.cod_funcionalidad = @cod_funcionalidad ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_funcionalidad);
            name.Add("@cod_funcionalidad");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }


        public void FillBycod_grupo_modulo(SPXSeguridad.data.dsSPXSeguridad.pltVinculadosDataTable tabla,
    int cod_grupo_modulo)
        {
            string sql = @"SELECT
  usuario.cod_usuario AS codigo, 1 AS tipo, nombre
FROM
  usuario
  JOIN moduloseguridad_usuario ON moduloseguridad_usuario.cod_usuario = usuario.cod_usuario
WHERE
  moduloseguridad_usuario.cod_modulo_seguridad = @cod_grupo_modulo
UNION
SELECT
  grupo_usuario.cod_grupo_usuario AS codigo, 2 AS tipo, nombre_grupo_usuario
FROM
  grupo_usuario
  JOIN moduloseguridad_grupousuario ON moduloseguridad_grupousuario.cod_grupo_usuario = grupo_usuario.cod_grupo_usuario
WHERE
  moduloseguridad_grupousuario.cod_modulo_seguridad = @cod_grupo_modulo ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_grupo_modulo);
            name.Add("@cod_grupo_modulo");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }
        #endregion

    }
}