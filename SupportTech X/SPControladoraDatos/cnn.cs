using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.Text;

namespace SPControladoraDatos
{
    public class cnn
    {
        public static void cargarCnn()
        {
           DataConector obj = new DataConector();
            SPControladoraDatos.Properties.Settings.Default["SUPPORTECHConnectionString"] = obj.CadenaConexion;
            SPControladoraDatos.Properties.Settings.Default.Save();
        }
    }
}
