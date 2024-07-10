using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
//using SPXQuery.data;
using SPControladoraDatos.artefactos.SPXQuery;
using SPControladoraDatos.artefactos;
using SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface;

namespace SPControladoraDatos.artefactos.SPXQuery
{
    public class cnn
    {
        public static void cargarConexion(string conexion)
        {
            SPControladoraDatos.Properties.Settings.Default["SUPPORTECHConnectionString"] = conexion;

            SPControladoraDatos.Properties.Settings.Default["supportechConnectionString1"] = conexion;

            SPControladoraDatos.Properties.Settings.Default["wcg_coreConnectionString"] = conexion;

             SPControladoraDatos.Properties.Settings.Default.Save();
        }

        /// <summary>
        /// 
        /// </summary>
        public static void cargarPermisos()
        {
            //permisos del 60 - 79
            SPXSeguridad.logica.clsInicializador cls = new SPXSeguridad.logica.clsInicializador();
            cls.cargarTablaModulos();
            cls.cargarTablaFuncionalidades();
            //
            cls.agregarModulo(4, "Querys y Reportes");
            //--
            cls.agregarFuncionalidad(4, 60, "Configuracion Query");
            cls.agregarFuncionalidad(4, 61, "Ejecutar Query");
           // cls.agregarFuncionalidad(4, 62, "Configuracion Reportes");
           // cls.agregarFuncionalidad(4, 63, "Ejecutar Reportes");
           // cls.agregarFuncionalidad(4, 64, "Query y Reportes por Usuario"); 
            cls.agregarFuncionalidad(4, 64, "Query por Usuario");
            cls.agregarFuncionalidad(4, 65, "Conexiones Query"); 
            //--
            cls.guardarTablaFuncionalidades();
            cls.guardarTablaModulos();
        }


        public static List<Interface> cargarOpcionesWindows(out string nombreModulo)
        {
            nombreModulo = "Reportes Y Querys";
            
            List<Interface> list = new List<Interface>();
                 
     
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj.asignar("Ejecutar Query", 4, 61, "", "SPControladoraDatos.artefactos.SPXQuery.frm.Query.frmSeleccionarQuery", null, null, true, false, true, "", "",false,false);
            list.Add(obj);
            //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj3 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            //obj3.asignar("Seleccionar Reporte",4, 63, "", "SPXQuery.frm.Reportes.frmSeleccionReporte", Resource.verrpt, null, true, false, true, "", "",false,false);
            //list.Add(obj3);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj5 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj5.asignar("Querys por Usuario", 4, 64, "", "SPControladoraDatos.artefactos.SPXQuery.frm.Query.frmQueryxUsuario", null, null, true, false, true, "", "", false, false);
            list.Add(obj5);
            
            //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj6 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            //obj6.asignar("Reportes por Usuario", 4, 64, "", "SPXQuery.frm.Reportes.frmReportesxUsuario", Resource.user_add, null, true, false, true, "", "", false, false);
            //list.Add(obj6);
            
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj2 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj2.asignar("Configurar Query", 4, 60, "", "SPControladoraDatos.artefactos.SPXQuery.frm.Query.frmListadoQuery", null, null, true, false, true, "", "", false, false);
            list.Add(obj2);
             
            //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj4 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            //obj4.asignar("Configurar Reporte", 4, 62, "", "SPXQuery.frm.Reportes.frmConfigurarReporte", Resource.configurarrpt, null, true, false, true, "", "",false,false);
            //list.Add(obj4);   
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj6= new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj6.asignar("Origenes de Datos", 4, 65, "", "SPControladoraDatos.artefactos.SPXQuery.frm.Query.frmListadoConexionesAuxiliares ", null, null, true, false, true, "", "", false, false);
            list.Add(obj6);
            return list;
        }
  
    }
}
