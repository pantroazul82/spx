using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace SPControladoraDatos.artefactos.SPXUtilidades.Misc
{
    public class clsSistema
    {
        public clsSistema() 
        {
        
        }

        public struct SYSTEMTIME
        {
            public short wYear;
            public short wMonth;
            public short wDayOfWeek;
            public short wDay;
            public short wHour;
            public short wMinute;
            public short wSecond;
            public short wMilliseconds;
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetSystemTime([In] ref SYSTEMTIME st);

        /// <summary>
        /// No olvidar que esta solo funciona si se ejecuta como Administrador
        /// </summary>
        /// <param name="fecha"></param>
        public static void cambiarFechaSystema(DateTime fecha)
        {
            SYSTEMTIME obj = new SYSTEMTIME();
            obj.wYear = (short)fecha.Year;
            obj.wSecond = (short)fecha.Second;
            obj.wMonth = (short)fecha.Month;
            obj.wMinute = (short)fecha.Minute;
            obj.wMilliseconds = (short)fecha.Millisecond;
            obj.wHour = (short)fecha.Hour;
            obj.wDayOfWeek = (short)fecha.DayOfWeek;
            obj.wDay = (short)fecha.Day;
            SetSystemTime(ref obj);
        }

    }
}
