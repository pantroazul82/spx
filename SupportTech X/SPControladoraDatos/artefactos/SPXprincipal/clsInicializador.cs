using SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPControladoraDatos.artefactos.SPXprincipal.logica
{
    public class botones
    {
        public string modulo;
        public string funcionalidad;
        public string textoBoton;
        public string namespace_form { set;get;}

        public botones()
        {
        
        }

        public botones(string _modulo, string _funcionalidad, string _textoBoton)
        {
            modulo = _modulo; funcionalidad = _funcionalidad;
            textoBoton = _textoBoton; namespace_form = "";
        }

        public botones(string _modulo, string _funcionalidad,string _textoBoton,string _namespace)
        {
            modulo= _modulo; 
            funcionalidad= _funcionalidad;
            textoBoton= _textoBoton;
            namespace_form = _namespace;
        }
    }

    public class clsInicializador
    {
        public static List<botones> botonesOmitir = new List<botones>();
        public static List<botones> botonesSustituir = new List<botones>();
                               // List<SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface>()
        public static List<Interface> botonesAdicionales = new List<Interface>();

        public static bool? moduloSeguridad = null;

        public static bool? moduloReportes = null;
        public static bool? moduloNotificaciones = null;
        public static bool? moduloTablasComunes = null;
        public static bool? moduloWMS = null;
        public static bool? moduloFlujo = null;



        /// <summary>
        /// me indica si se debe incluir un boton o no
        /// </summary>
        /// <param name="modulo"></param>
        /// <param name="funcionalidad"></param>
        /// <param name="textoBoton"></param>
        /// <returns></returns>
        public static string sustituirBoton(string modulo, string funcionalidad, string textoBoton,string namespace_frm)
        {
            //for (int k = 0; k < botonesSustituir.Count; k++)
            //{
            //    if (botonesSustituir[k].funcionalidad == funcionalidad &&
            //        botonesSustituir[k].textoBoton == textoBoton &&
            //            botonesSustituir[k].modulo == modulo)
            //    {
            //        return botonesSustituir[k].namespace_form;
            //    }
            //}

            SPXprincipal.logica.botones boton = botonesSustituir.Where(obj => obj.funcionalidad == funcionalidad && obj.textoBoton == textoBoton && obj.modulo == modulo).SingleOrDefault();
            if (boton != null) {
                return boton.namespace_form;
            }

            return namespace_frm;
        }


    }
}
