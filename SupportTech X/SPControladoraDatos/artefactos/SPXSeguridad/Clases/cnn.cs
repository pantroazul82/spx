using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPXSeguridad
{
    public class cnn
    {
        public cnn() { }

        public static bool validaUsuarios = false;
        public static int usuariosLicencia = 10;

        public static void cargarConexion(string conexion)
        {
            SPControladoraDatos.Properties.Settings.Default["wcg_coreConnectionString"] = conexion;
            SPControladoraDatos.Properties.Settings.Default.Save();
        }

        /// <summary>
        /// 
        /// </summary>
        public static void cargarPermisos()
        {
            //permisos del 1 - 19
            SPXSeguridad.logica.clsInicializador cls = new SPXSeguridad.logica.clsInicializador();
            cls.cargarTablaModulos();
            cls.cargarTablaFuncionalidades();
            //
            cls.agregarModulo(1, "Seguridad");
            //--
            cls.agregarFuncionalidad(1,1,"Usuarios y Grupos");
            cls.agregarFuncionalidad(1, 2, "Lineas");
            var p= cls.agregarFuncionalidad(1, 3, "Configuracion de Permisos");

            //--
            cls.guardarTablaFuncionalidades();
            cls.guardarTablaModulos();
        }
      

        public static List<SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface> cargarOpcionesWindows(out string nombreModulo)
        {
            nombreModulo = "Seguridad";
            List<SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface> list = new List<SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface>();
            
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj.asignar("Lineas", 1, 2, "", "SPXSeguridad.linea.frmLinea", SPControladoraDatos.Properties.Resources.linea, null, true, false,true,"","",false,false);
            list.Add(obj);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj2 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj2.asignar("Lineas por Usuario", 1, 2, "", "SPXSeguridad.linea.frmLineasxUsuario", SPControladoraDatos.Properties.Resources.funcionalidades, null,true,false,true,"","",false,false);
            list.Add(obj2);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj3 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj3.asignar("Grupos de Usuario", 1, 1, "", "SPXSeguridad.frm.frmGrupoUsuario", SPControladoraDatos.Properties.Resources.user, null, true, false,true,"","",false,false);
            list.Add(obj3);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj4 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj4.asignar("Usuarios", 1, 1, "", "SPXSeguridad.frm.frmUsuarios", SPControladoraDatos.Properties.Resources.user2, null, true, false,true,"","",false,false);
            list.Add(obj4);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj5 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj5.asignar("Funcionalidades", 1, 0, "", "SPXSeguridad.frm.frmFuncionalidades", SPControladoraDatos.Properties.Resources.modulos, null, true, false, true, "", "",false,false);
            list.Add(obj5);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj6 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj6.asignar("Permisos", 1, 3, "", "SPXSeguridad.frm.frmPermisos", SPControladoraDatos.Properties.Resources.llaves, null, true, false, true, "", "",false,false);
            list.Add(obj6);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj7 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj7.asignar("Cambiar Password", 1, 0, "", "SPXSeguridad.frm.frmInterfacePass", SPControladoraDatos.Properties.Resources.candado, null, false, true, false, "", "",false,false);
            list.Add(obj7);
            return list;
        }
    
    }
}
