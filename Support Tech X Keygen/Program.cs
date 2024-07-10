using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Support_Tech_X_Keygen
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SPXSeguridad.licencias.Verificador.Aplicativo = "Support Tech X";
            SPXSeguridad.licencias.Verificador.VersionApp = "2.0";
            SPXSeguridad.licencias.Verificador objVer = new SPXSeguridad.licencias.Verificador();
            SPXSeguridad.licencias.FormGenerador fmr = new SPXSeguridad.licencias.FormGenerador();
            
            fmr.ControlarPassword = true;
            Application.Run(fmr);
        }
    }
}