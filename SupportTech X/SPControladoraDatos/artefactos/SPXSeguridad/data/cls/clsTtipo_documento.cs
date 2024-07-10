using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPXSeguridad.data.cls
{

    public class clsTtipo_documento : SPXdata.BD.clsAdaptador
    {
        #region copiar y pegar en todas las tablas
        public SPXSeguridad.data.dsSPXSeguridad.tipo_documentoDataTable tabla;

        public clsTtipo_documento()
        {
            tabla = new dsSPXSeguridad.tipo_documentoDataTable();
            tablaMaestra = (System.Data.DataTable)tabla;
            nombreLlave = "cod_tipo_documento";
            nombreTabla = "tipo_documento";
            cargarCamposSelect();
        }

        #endregion

        public int Insert(string nombre_tipo_documento,bool? ind_1,bool? ind_2,string abreviatura)
        {
            string sql = @"INSERT INTO tipo_documento
                         (nombre_tipo_documento, ind_1, ind_2, abreviatura)
                        VALUES        
                        (@nombre_tipo_documento, @ind_1, @ind_2, @abreviatura)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(nombre_tipo_documento);
            name.Add("@nombre_tipo_documento");

            arr.Add(ind_1);
            name.Add("@ind_1");

            arr.Add(ind_2);
            name.Add("@ind_2");

            arr.Add(abreviatura);
            name.Add("@abreviatura");
            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int updateQuery(string nombre_tipo_documento, bool? ind_1, bool? ind_2, string abreviatura,int cod_tipo_documento)
        {
            string sql = @"UPDATE tipo_documento SET 
                            nombre_tipo_documento = @nombre_tipo_documento, ind_1 = @ind_1, ind_2 = @ind_2, abreviatura = @abreviatura 
                            WHERE cod_tipo_documento = @cod_tipo_documento";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_tipo_documento);
            name.Add("@cod_tipo_documento");

            arr.Add(nombre_tipo_documento);
            name.Add("@nombre_tipo_documento");

            arr.Add(ind_1);
            name.Add("@ind_1");

            arr.Add(ind_2);
            name.Add("@ind_2");

            arr.Add(abreviatura);
            name.Add("@abreviatura");
            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public void FillBycod_tipo_documento(SPXSeguridad.data.dsSPXSeguridad.tipo_documentoDataTable tabla,
           int cod_tipo_documento)
        {
            string sql = sentenciaBase + @"  WHERE (cod_tipo_documento = @cod_tipo_documento) ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_tipo_documento);
            name.Add("@cod_tipo_documento");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }

       



    }
}