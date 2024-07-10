using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface
{
    public class parametrosSoftware
    {
        public static string nombreSoftware { set; get; }

        public static System.Drawing.Image logotipoSoftware { set; get; }

        public static System.Drawing.Icon iconoSoftware { set; get; }

        /// <summary>
        /// 0 personalizado
        /// 1 modo anuncios
        /// 2 modo calendario
        /// </summary>
        public static int formularioWinInicio { set; get; }
        public static string formularioWinInicioCustom { set; get; }


    }
}
