using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPControladoraDatos.artefactos.SPXUtilidades.Misc.festivos;
using SPXdata.BD;

namespace SPControladoraDatos.artefactos.SPXUtilidades.Misc.festivos
{
    public class clsTdias_festivos : SPXdata.BD.clsAdaptador
    {
        #region copiar y pegar en todas las tablas
        public dsFestivos.dias_festivosDataTable tabla;

        public clsTdias_festivos()
        {
            tabla = new dsFestivos.dias_festivosDataTable();
            tablaMaestra = (System.Data.DataTable)tabla;
            nombreLlave = "cod_dias_festivos";
            nombreTabla = "dias_festivos";
            cargarCamposSelect();
        }

        #endregion

        public int Insert(int dia ,int mes ,int ano,DateTime fecha)
        {
            
            string sql = @"INSERT INTO dias_festivos
           (dia ,mes ,ano,fecha,day_of_year) VALUES (@dia ,@mes ,@ano,@fecha,@day_of_year)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(dia);
            name.Add("dia");

            arr.Add(mes);
            name.Add("mes");

            arr.Add(ano);
            name.Add("ano");

            arr.Add(fecha);
            name.Add("fecha");

            arr.Add(fecha.DayOfYear);
            name.Add("day_of_year");

            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public void FillBycod_dias_festivos(dsFestivos.dias_festivosDataTable tabla,
          int cod_dias_festivos)
        {
            string sql = @" SELECT cod_dias_festivos ,dia,mes,ano,fecha,day_of_year
  FROM dias_festivos
WHERE        (cod_dias_festivos = @cod_dias_festivos) ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_dias_festivos);
            name.Add("@cod_dias_festivos");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }

        public void FillByano(dsFestivos.dias_festivosDataTable tabla,
  int ano)
        {
            string sql = @" SELECT cod_dias_festivos ,dia,mes,ano,fecha,day_of_year
  FROM dias_festivos
WHERE        (ano = @ano) ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(ano);
            name.Add("ano");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }


        public void FillByday_of_year(dsFestivos.dias_festivosDataTable tabla,
int day_of_year,int ano)
        {
            string sql = @" SELECT cod_dias_festivos ,dia,mes,ano,fecha,day_of_year
  FROM dias_festivos
WHERE        (day_of_year = @day_of_year) and ano=@ano ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(day_of_year);
            name.Add("day_of_year");

            arr.Add(ano);
            name.Add("ano");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }

        /// <summary>
        /// todo problema al cambiar de ano,
        /// </summary>
        /// <param name="ano"></param>
        /// <param name="inicio"></param>
        /// <param name="fin"></param>
        /// <returns></returns>
            public int verDiasNoHabiles(DateTime inicio,DateTime fin)
        {
            string sql = @" SELECT COUNT(*) from dias_festivos where  fecha between @inicio and @fin ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
       

            arr.Add(inicio);
            name.Add("inicio");

            arr.Add(fin);
            name.Add("fin");

            #endregion
           DataConector obj = new DataConector();
            System.Data.DataTable tb = new System.Data.DataTable();
             obj.ejecutarConsulta(sql,tb,true,  arr, name);
             return int.Parse(tb.Rows[0][0].ToString());
        }

    }
}

