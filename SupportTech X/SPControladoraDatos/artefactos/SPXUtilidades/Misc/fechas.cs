using System;
using System.Collections.Generic;
using System.Text;

namespace SPControladoraDatos.artefactos.SPXUtilidades.Misc
{
    public class fechas
    {
        public fechas()
        {
        }


        /// <summary>
        /// Retorna el nombre del mes
        /// </summary>
        /// <param name="mes">numeero del mes de 1 a 12</param>
        /// <returns>nombre del mes en espanol</returns>
        public string nombreMes(int mes) 
        {
            string res="";
            switch (mes) 
            {
                case 1: { res = "Enero"; break; }
                case 2: { res = "Febrero"; break; }
                case 3: { res = "Marzo"; break; }
                case 4: { res = "Abril"; break; }
                case 5: { res = "Mayo"; break; }
                case 6: { res = "Junio"; break; }
                case 7: { res = "Julio"; break; }
                case 8: { res = "Agosto"; break; }
                case 9: { res = "Septiembre"; break; }
                case 10: { res = "Octubre"; break; }
                case 11: { res = "Noviembre"; break; }
                case 12: { res = "Diciembre"; break; }
            }
            return res;        
        }

        public DateTime verPimerDiaSemana(DateTime fecha)
        {
            DateTime fechaRes = fecha;
            if (fecha.DayOfWeek == DayOfWeek.Tuesday)
            {
                fechaRes = fecha.AddDays(-1);
            }
            if (fecha.DayOfWeek == DayOfWeek.Wednesday)
            {
                fechaRes = fecha.AddDays(-2);
            }
            if (fecha.DayOfWeek == DayOfWeek.Thursday)
            {
                fechaRes = fecha.AddDays(-3);
            }
            if (fecha.DayOfWeek == DayOfWeek.Friday)
            {
                fechaRes = fecha.AddDays(-4);
            }
            if (fecha.DayOfWeek == DayOfWeek.Saturday)
            {
                fechaRes = fecha.AddDays(-5);
            }
            if (fecha.DayOfWeek == DayOfWeek.Sunday)
            {
                fechaRes = fecha.AddDays(-6);
            }

            return fechaRes;

        }
    }
}
