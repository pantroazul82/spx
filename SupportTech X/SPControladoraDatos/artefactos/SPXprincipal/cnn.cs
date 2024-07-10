using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPControladoraDatos.artefactos;
using SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface;


namespace SPControladoraDatos.artefactos.SPXprincipal
{
    public class cnn
    {
        public cnn() { }

        public static void cargarConexion(string conexion)
        {
            SPControladoraDatos.Properties.Settings.Default["wcg_coreConnectionString"] = conexion;
            SPControladoraDatos.Properties.Settings.Default.Save();
        }

        public static List<Interface> cargarOpcionesWindows(out string nombreModulo)
        {
            nombreModulo = "Herramientas";
            List<Interface> list = new List<Interface>();
             
            

            Interface obj = new Interface();
            obj.asignar("Estilo Visual", 0, 0, "", "SPControladoraDatos.artefactos.SPXUtilidades.Themes.FrmPersonalizar",SPControladoraDatos.Properties.Resources.estilo, null, false, true, false, "Herramientas", "", false, false);
            list.Add(obj);



            return list;
        }

    }
}
