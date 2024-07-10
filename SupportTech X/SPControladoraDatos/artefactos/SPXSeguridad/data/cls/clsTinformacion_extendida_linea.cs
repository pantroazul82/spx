using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPXSeguridad.data.cls
{

    public class TclsTinformacion_extendida_linea : SPXdata.BD.clsAdaptador
    {
        #region copiar y pegar en todas las tablas
        public SPXSeguridad.data.dsSPXSeguridad.informacion_extendida_lineaDataTable tabla;

        public TclsTinformacion_extendida_linea()
        {
            tabla = new dsSPXSeguridad.informacion_extendida_lineaDataTable();
            tablaMaestra = (System.Data.DataTable)tabla;
            nombreLlave = "cod_informacion_extendida_linea";
            nombreTabla = "informacion_extendida_linea";
            cargarCamposSelect();
        }

        #endregion

        public int Insert(int cod_linea,string texto1,string texto2,string texto3,string texto4,string texto5, 
Decimal? numero1,Decimal?  numero2,Decimal?  numero3,Decimal?  numero4,Decimal?  numero5, 
DateTime? fecha1,DateTime? fecha2,DateTime? fecha3,DateTime? fecha4,DateTime? fecha5, 
bool? ind1,bool?  ind2,bool?  ind3,bool?  ind4,bool?  ind5)
        {
            string sql = @"INSERT INTO informacion_extendida_linea 
        (cod_linea, texto1, texto2, texto3, texto4, texto5, 
numero1, numero2, numero3, numero4, numero5, 
fecha1, fecha2, fecha3, fecha4, fecha5, 
ind1, ind2, ind3, ind4, ind5) VALUES 
(@cod_linea, @texto1, @texto2, @texto3, @texto4, @texto5, @numero1, @numero2,@numero3, @numero4, @numero5, @fecha1, @fecha2, @fecha3, @fecha4, @fecha5, @ind1, @ind2, @ind3, @ind4, @ind5)";
            #region parametros
           
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add (cod_linea);
            name.Add("@cod_linea");

            arr.Add (texto1);
            name.Add("@texto1");

            arr.Add (texto2);
            name.Add("@texto2");

            arr.Add (texto3);
            name.Add("@texto3");

            arr.Add (texto4);
            name.Add("@texto4");

            arr.Add (texto5);
            name.Add("@texto5");

            arr.Add (numero1);
            name.Add("@numero1");

            arr.Add (numero2);
            name.Add("@numero2");

            arr.Add(numero3);
            name.Add("@numero3");
            
            arr.Add(numero4);
            name.Add("@numero4");
            
            arr.Add(numero5);
            name.Add("@numero5");
            
            arr.Add(fecha1);
            name.Add("@fecha1");
            
            arr.Add(fecha2);
            name.Add("@fecha2");

            arr.Add(fecha3);
            name.Add("@fecha3");
            
            arr.Add(fecha4);
            name.Add("@fecha4");
            
            arr.Add(fecha5);
            name.Add("@fecha5");

            arr.Add(ind1);
            name.Add("@ind1");
            
            arr.Add(ind2);
            name.Add("@ind2");
            
            arr.Add(ind3);
            name.Add("@ind3");
            
            arr.Add(ind4);
            name.Add("@ind4");

            arr.Add(ind5);
            name.Add("@ind5");

            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int UpdateQuery(string texto1, string texto2, string texto3, string texto4, string texto5,
Decimal? numero1, Decimal? numero2, Decimal? numero3, Decimal? numero4, Decimal? numero5,
DateTime? fecha1, DateTime? fecha2, DateTime? fecha3, DateTime? fecha4, DateTime? fecha5,
bool? ind1, bool? ind2, bool? ind3, bool? ind4, bool? ind5,int cod_linea)
        {
            string sql = @"UPDATE informacion_extendida_linea SET 
texto1 = @texto1, texto2 = @texto2, texto3 = @texto3, texto4 = @texto4, texto5 = @texto5, 
numero1 = @numero1, numero2 = @numero2, numero3 = @numero3, numero4 = @numero4, numero5 = @numero5, 
fecha1 = @fecha1, fecha2 = @fecha2, fecha3 = @fecha3, fecha4 = @fecha4, fecha5 = @fecha5, 
ind1 = @ind1, ind2 = @ind2, ind3 = @ind3, ind4 = @ind4, ind5 = @ind5 WHERE cod_linea = @cod_linea";
            #region parametros

            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(cod_linea);
            name.Add("@cod_linea");

            arr.Add(texto1);
            name.Add("@texto1");

            arr.Add(texto2);
            name.Add("@texto2");

            arr.Add(texto3);
            name.Add("@texto3");

            arr.Add(texto4);
            name.Add("@texto4");

            arr.Add(texto5);
            name.Add("@texto5");

            arr.Add(numero1);
            name.Add("@numero1");

            arr.Add(numero2);
            name.Add("@numero2");

            arr.Add(numero3);
            name.Add("@numero3");

            arr.Add(numero4);
            name.Add("@numero4");

            arr.Add(numero5);
            name.Add("@numero5");

            arr.Add(fecha1);
            name.Add("@fecha1");

            arr.Add(fecha2);
            name.Add("@fecha2");

            arr.Add(fecha3);
            name.Add("@fecha3");

            arr.Add(fecha4);
            name.Add("@fecha4");

            arr.Add(fecha5);
            name.Add("@fecha5");

            arr.Add(ind1);
            name.Add("@ind1");

            arr.Add(ind2);
            name.Add("@ind2");

            arr.Add(ind3);
            name.Add("@ind3");

            arr.Add(ind4);
            name.Add("@ind4");

            arr.Add(ind5);
            name.Add("@ind5");

            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public void FillBycod_linea(SPXSeguridad.data.dsSPXSeguridad.informacion_extendida_lineaDataTable tabla,
           int cod_linea)
        {
            string sql = sentenciaBase + @"   WHERE (cod_linea = @cod_linea)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_linea);
            name.Add("@cod_linea");

            #endregion
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }


    }
}
