using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Rendering;

namespace SPControladoraDatos.artefactos.SPXUtilidades.Themes
{
    public class ThemeManager
    {

        public static void inicializar() 
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Themes.FrmPersonalizar fr = new SPControladoraDatos.artefactos.SPXUtilidades.Themes.FrmPersonalizar();
            fr.cargarConfig();
        }

        public void _inicializar()
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Themes.FrmPersonalizar fr = new SPControladoraDatos.artefactos.SPXUtilidades.Themes.FrmPersonalizar();
            fr.cargarConfig();
        }

        public System.Drawing.Color _verColor()
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Themes.FrmPersonalizar fr = new SPControladoraDatos.artefactos.SPXUtilidades.Themes.FrmPersonalizar();
            return fr.verColor();
        }

        public static System.Drawing.Color verColor()
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Themes.FrmPersonalizar fr = new SPControladoraDatos.artefactos.SPXUtilidades.Themes.FrmPersonalizar();
            return fr.verColor();
        }

    }
}
