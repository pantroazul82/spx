using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace spxInicio
{
    public class cnn
    {
        public cnn() { }

        public static void cargarConexion(string conexion)
        {
            //Properties.Settings.Default["wcg_coreConnectionString"] = conexion;
            //Properties.Settings.Default.Save();
        }

        /// <summary>
        /// 
        /// </summary>
        public static void cargarPermisos()
        {
            //permisos del 1000 - 1100
            SPXSeguridad.logica.clsInicializador cls = new SPXSeguridad.logica.clsInicializador();
            cls.cargarTablaModulos();
            cls.cargarTablaFuncionalidades();
            //recuerde que el moduoo 20 de ldnet ya existe no lo descomentaree
            //cls.agregarModulo(20, "LDNET");
            //--
            //cls.agregarFuncionalidad(20, 1001, "Interfaz SAP");
            //cls.guardarTablaFuncionalidades();
            //cls.guardarTablaModulos();
        }

        //public static List<SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface> cargarOpcionesWindows(out string nombreModulo)
        //{
        //    //nombreModulo = "Seguridad";
        //    //List<SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface> list = new List<SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface>();

        //    //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
        //    //obj.asignar("Impresora ZEBRA", 0, 0, "", "Ldnet.herramientas.frmImpresionZebra", Properties.Resources.Printer,
        //    //    null, false, true, false, "Herramientas", "", false, false);
        //    //list.Add(obj);

        //    //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj2 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
        //    //obj2.asignar("Cambiar Estados", 20, 202, "", "Ldnet.frm.procesos.alcomex.frmCambiarEstados", Properties.Resources.engine,
        //    //    null, true, false, true, "LDNET", "Procesos", false, true);
        //    //list.Add(obj2);

        //    //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj3 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
        //    //obj3.asignar("Reempaque", 20, 203, "", "Ldnet.frm.Reempaques.frmreempaque",
        //    //    Properties.Resources.engine, null, true, false, true, "LDNET", "Procesos", false, true);
        //    //list.Add(obj3);

        //    //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj4 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
        //    //obj4.asignar("Movilizar", 20, 204, "", "ldNetAlcomex.frm.herramientas.frmInmovilizar",
        //    //    Properties.Resources.Inmovilizar, null, true, false, true, "LDNET", "Procesos", false, true);
        //    //list.Add(obj4);


        //    //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj5 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
        //    //obj5.asignar("Traslado Interno", 20, 205, "", "ldNetAlcomex.frm.herramientas.frmTrasladosMercancia",
        //    //    Properties.Resources.Backup_Restore, null, true, false, true, "LDNET", "Procesos", false, true);
        //    //list.Add(obj5);


        //    //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj6 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
        //    //obj6.asignar("Cambiar Datos", 20, 206, "", "ldNetAlcomex.frm.herramientas.frmCambiarFecha_Lote",
        //    //    Properties.Resources.engine, null, true, false, true, "LDNET", "Herramientas", false, true);
        //    //list.Add(obj6);


        //    //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj7 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
        //    //obj7.asignar("Impresion de Sticker", 20, 207, "", "ldNetAlcomex.frm.herramientas.frmImprimeReferenciaZebra",
        //    //    Properties.Resources.Imprimir_Sticker, null, true, false, true, "LDNET", "Herramientas", false, true);
        //    //list.Add(obj7);

        //    //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj8 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
        //    //obj8.asignar("Configurar Impresora", 20, 208, "", "Ldnet.herramientas.frmImpresionZebra",
        //    //    Properties.Resources.Imprimir_Sticker, null, true, false, true, "LDNET", "Herramientas", false, true);
        //    //list.Add(obj8);

        //    //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj9 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
        //    //obj9.asignar("kardex", 20, 209, "", "    ldNetAlcomex.frm.ReportesAlcomex.frmKardex",
        //    //    Properties.Resources.Kardex, null, true, false, true, "LDNET", "Consultas", false, true);
        //    //list.Add(obj9);

        //    //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj10 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
        //    //obj10.asignar("Consulta de Movimiento", 20, 210, "", "    ldNetAlcomex.frm.ReportesAlcomex.frmConsultamovimientoDT",
        //    //    Properties.Resources.engine, null, true, false, true, "LDNET", "Consultas", false, true);
        //    //list.Add(obj10);

        //    //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj11 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
        //    //obj11.asignar("Importar Referencias Entre Lineas", 20, 211, "", "Ldnet.frm.procesos.frmCopiarPartesEntreLineas",
        //    //    Properties.Resources.engine, null, true, false, true, "LDNET", "Herramientas", false, true);
        //    //list.Add(obj11);

        //    //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj12 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
        //    //obj12.asignar("Desbloquear Documento de Transporte", 20, 212, "", "ldNetAlcomex.frm.herramientas.frmDesbloqueaMovimientos",
        //    //    Properties.Resources.engine, null, true, false, true, "LDNET", "Procesos", false, true);
        //    //list.Add(obj12);

        //    //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj13 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
        //    //obj13.asignar("Kits", 20, 213, "", "Ldnet.Manejo_Kits.frmOpcionKits",
        //    //    Properties.Resources.engine, null, true, false, true, "LDNET", "Procesos", false, true);
        //    //list.Add(obj13);

        //    return list;
        //}

    }
}
