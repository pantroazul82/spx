using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace spxreactlab
{
    public class cnn
    {

        public static int numeroUsuarios = 10;
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
            cls.agregarModulo(201, "Inventario Repuestos");
            
            cls.agregarFuncionalidad(201, 21201, "Editar ubicaciones");
            cls.agregarFuncionalidad(201, 21202, "Entrada Repuestos");
            cls.agregarFuncionalidad(201, 21203, "Salida Repuestos");
            cls.agregarFuncionalidad(201, 21204, "Consulta de Repuestos");
            cls.guardarTablaFuncionalidades();
            cls.guardarTablaModulos();
        }

        public static List<SPXUtilidades.Misc.menuInterface.Interface> cargarOpcionesWindows(out string nombreModulo)
        {
            nombreModulo = "Inventario Repuestos";
            List<SPXUtilidades.Misc.menuInterface.Interface> list = new List<SPXUtilidades.Misc.menuInterface.Interface>();
            
            
            SPXUtilidades.Misc.menuInterface.Interface obj = new SPXUtilidades.Misc.menuInterface.Interface();
            obj.asignar("Salida Repuestos", 0, 0, "", "SPXWms.Salida.frmListadoSalidas",
                spxInicio.Properties.Resources.Crystal_Clear_app_desktop_enhancements
                ,
                null, true, false, true, "Inventario Repuestos", "Procesos", false, false);
            list.Add(obj);

             SPXUtilidades.Misc.menuInterface.Interface objConsultaInv = new SPXUtilidades.Misc.menuInterface.Interface();
                        objConsultaInv.asignar("Consulta de Inventarios", 0, 0, "", "SPXWms.Consultas.frmConsultaInventario",
                spxInicio.Properties.Resources.Crystal_Clear_app_desktop_enhancements
                ,
                null, true, false, true, "Inventario Repuestos", "Consultas", false, false);
            list.Add(objConsultaInv);
            
            SPXUtilidades.Misc.menuInterface.Interface objParamItem = new SPXUtilidades.Misc.menuInterface.Interface();
            objParamItem.asignar("Item", 0, 0, "", "SPXWms.Parametrizacion.frmListaItem",
    spxInicio.Properties.Resources.Crystal_Clear_app_desktop_enhancements
    ,
    null, true, false, true, "Inventario Repuestos", "Parametrizacion", false, false);
            list.Add(objParamItem);
            
            SPXUtilidades.Misc.menuInterface.Interface objParamCategoria = new SPXUtilidades.Misc.menuInterface.Interface();
            objParamCategoria.asignar("Categoria Item", 0, 0, "", "SPXWms.Parametrizacion.frmListadoCategoriasItem",
    spxInicio.Properties.Resources.Crystal_Clear_app_desktop_enhancements
    ,
    null, true, false, true, "Inventario Repuestos", "Parametrizacion", false, false);
            list.Add(objParamCategoria);

            SPXUtilidades.Misc.menuInterface.Interface objParamSubCategoria = new SPXUtilidades.Misc.menuInterface.Interface();
            objParamSubCategoria.asignar("Sub Categoria Item", 0, 0, "", "SPXWms.Parametrizacion.frmListadoSubcategoria",
    spxInicio.Properties.Resources.Crystal_Clear_app_desktop_enhancements
    ,
    null, true, false, true, "Inventario Repuestos", "Parametrizacion", false, false);
            list.Add(objParamSubCategoria);

            SPXUtilidades.Misc.menuInterface.Interface objTiposEntrada= new SPXUtilidades.Misc.menuInterface.Interface();
            objTiposEntrada.asignar("Tipos de Entrada", 0, 0, "", "SPXWms.Parametrizacion.frmListadoTipoEntrada",
    spxInicio.Properties.Resources.Crystal_Clear_app_desktop_enhancements
    ,
    null, true, false, true, "Inventario Repuestos", "Parametrizacion", false, false);
            list.Add(objTiposEntrada);

            SPXUtilidades.Misc.menuInterface.Interface objTiposSalida = new SPXUtilidades.Misc.menuInterface.Interface();
            objTiposSalida.asignar("Tipos de Salida", 0, 0, "", "SPXWms.Parametrizacion.frmListadoTipoSalida",
    spxInicio.Properties.Resources.Crystal_Clear_app_desktop_enhancements
    ,
    null, true, false, true, "Inventario Repuestos", "Parametrizacion", false, false);
            list.Add(objTiposSalida);


            SPXUtilidades.Misc.menuInterface.Interface objEstadoConservacion = new SPXUtilidades.Misc.menuInterface.Interface();
            objEstadoConservacion.asignar("Estados de Conservacion", 0, 0, "", "SPXWms.Parametrizacion.frmListadoEstadosConservacion",
    spxInicio.Properties.Resources.Crystal_Clear_app_desktop_enhancements
    ,
    null, true, false, true, "Inventario Repuestos", "Parametrizacion", false, false);
            list.Add(objEstadoConservacion);


            SPXUtilidades.Misc.menuInterface.Interface objEstadosSubProceso = new SPXUtilidades.Misc.menuInterface.Interface();
            objEstadosSubProceso.asignar("Estados SubProceso", 0, 0, "", "SPXWms.Parametrizacion.frmListadoSubProceso",
    spxInicio.Properties.Resources.Crystal_Clear_app_desktop_enhancements
    ,
    null, true, false, true, "Inventario Repuestos", "Parametrizacion", false, false);
            list.Add(objEstadosSubProceso);


            SPXUtilidades.Misc.menuInterface.Interface objEstadoProceso = new SPXUtilidades.Misc.menuInterface.Interface();
            objEstadoProceso.asignar("Estado de Proceso Interno", 0, 0, "", "SPXWms.Parametrizacion.frmListadoEstadosProceso",
    spxInicio.Properties.Resources.Crystal_Clear_app_desktop_enhancements
    ,
    null, true, false, true, "Inventario Repuestos", "Parametrizacion", false, false);
            list.Add(objEstadoProceso);
            //--
            
            SPXUtilidades.Misc.menuInterface.Interface obj2 = new SPXUtilidades.Misc.menuInterface.Interface();
            obj2.asignar("Entrada Repuestos", 0, 0, "", "SPXWms.Entrada.frmListadoEntrada",
                spxInicio.Properties.Resources.Crystal_Clear_app_desktop_enhancements
                ,
                null, true, false, true, "Inventario Repuestos", "Procesos", false, false);
            list.Add(obj2);

            SPXUtilidades.Misc.menuInterface.Interface objTraslados = new SPXUtilidades.Misc.menuInterface.Interface();
            objTraslados.asignar("Traslados", 0, 0, "", "SPXWms.Traslados.frmCambiosUbicacion",
                spxInicio.Properties.Resources.Crystal_Clear_app_desktop_enhancements
                ,
                null, true, false, true, "Inventario Repuestos", "Procesos", false, false);
            list.Add(objTraslados);



          
            SPXUtilidades.Misc.menuInterface.Interface obj4a = new SPXUtilidades.Misc.menuInterface.Interface();
            obj4a.asignar("Edicion de Ubicaciones", 0, 0, "", "SPXWms.Parametrizacion.frmConfiguracionBodegas",
                spxInicio.Properties.Resources.Crystal_Clear_app_desktop_enhancements
                ,
                null, true, false, true, "Inventario Repuestos", "Procesos", false, false);
            list.Add(obj4a);

        

        //    //SPXUtilidades.Misc.menuInterface.Interface obj2 = new SPXUtilidades.Misc.menuInterface.Interface();
        //    //obj2.asignar("Cambiar Estados", 20, 202, "", "Ldnet.frm.procesos.alcomex.frmCambiarEstados", Properties.Resources.engine,
        //    //    null, true, false, true, "LDNET", "Procesos", false, true);
        //    //list.Add(obj2);

        //    //SPXUtilidades.Misc.menuInterface.Interface obj3 = new SPXUtilidades.Misc.menuInterface.Interface();
        //    //obj3.asignar("Reempaque", 20, 203, "", "Ldnet.frm.Reempaques.frmreempaque",
        //    //    Properties.Resources.engine, null, true, false, true, "LDNET", "Procesos", false, true);
        //    //list.Add(obj3);

        //    //SPXUtilidades.Misc.menuInterface.Interface obj4 = new SPXUtilidades.Misc.menuInterface.Interface();
        //    //obj4.asignar("Movilizar", 20, 204, "", "ldNetAlcomex.frm.herramientas.frmInmovilizar",
        //    //    Properties.Resources.Inmovilizar, null, true, false, true, "LDNET", "Procesos", false, true);
        //    //list.Add(obj4);


        //    //SPXUtilidades.Misc.menuInterface.Interface obj5 = new SPXUtilidades.Misc.menuInterface.Interface();
        //    //obj5.asignar("Traslado Interno", 20, 205, "", "ldNetAlcomex.frm.herramientas.frmTrasladosMercancia",
        //    //    Properties.Resources.Backup_Restore, null, true, false, true, "LDNET", "Procesos", false, true);
        //    //list.Add(obj5);


        //    //SPXUtilidades.Misc.menuInterface.Interface obj6 = new SPXUtilidades.Misc.menuInterface.Interface();
        //    //obj6.asignar("Cambiar Datos", 20, 206, "", "ldNetAlcomex.frm.herramientas.frmCambiarFecha_Lote",
        //    //    Properties.Resources.engine, null, true, false, true, "LDNET", "Herramientas", false, true);
        //    //list.Add(obj6);


        //    //SPXUtilidades.Misc.menuInterface.Interface obj7 = new SPXUtilidades.Misc.menuInterface.Interface();
        //    //obj7.asignar("Impresion de Sticker", 20, 207, "", "ldNetAlcomex.frm.herramientas.frmImprimeReferenciaZebra",
        //    //    Properties.Resources.Imprimir_Sticker, null, true, false, true, "LDNET", "Herramientas", false, true);
        //    //list.Add(obj7);

        //    //SPXUtilidades.Misc.menuInterface.Interface obj8 = new SPXUtilidades.Misc.menuInterface.Interface();
        //    //obj8.asignar("Configurar Impresora", 20, 208, "", "Ldnet.herramientas.frmImpresionZebra",
        //    //    Properties.Resources.Imprimir_Sticker, null, true, false, true, "LDNET", "Herramientas", false, true);
        //    //list.Add(obj8);

        //    //SPXUtilidades.Misc.menuInterface.Interface obj9 = new SPXUtilidades.Misc.menuInterface.Interface();
        //    //obj9.asignar("kardex", 20, 209, "", "    ldNetAlcomex.frm.ReportesAlcomex.frmKardex",
        //    //    Properties.Resources.Kardex, null, true, false, true, "LDNET", "Consultas", false, true);
        //    //list.Add(obj9);

        //    //SPXUtilidades.Misc.menuInterface.Interface obj10 = new SPXUtilidades.Misc.menuInterface.Interface();
        //    //obj10.asignar("Consulta de Movimiento", 20, 210, "", "    ldNetAlcomex.frm.ReportesAlcomex.frmConsultamovimientoDT",
        //    //    Properties.Resources.engine, null, true, false, true, "LDNET", "Consultas", false, true);
        //    //list.Add(obj10);

        //    //SPXUtilidades.Misc.menuInterface.Interface obj11 = new SPXUtilidades.Misc.menuInterface.Interface();
        //    //obj11.asignar("Importar Referencias Entre Lineas", 20, 211, "", "Ldnet.frm.procesos.frmCopiarPartesEntreLineas",
        //    //    Properties.Resources.engine, null, true, false, true, "LDNET", "Herramientas", false, true);
        //    //list.Add(obj11);

        //    //SPXUtilidades.Misc.menuInterface.Interface obj12 = new SPXUtilidades.Misc.menuInterface.Interface();
        //    //obj12.asignar("Desbloquear Documento de Transporte", 20, 212, "", "ldNetAlcomex.frm.herramientas.frmDesbloqueaMovimientos",
        //    //    Properties.Resources.engine, null, true, false, true, "LDNET", "Procesos", false, true);
        //    //list.Add(obj12);

        //    //SPXUtilidades.Misc.menuInterface.Interface obj13 = new SPXUtilidades.Misc.menuInterface.Interface();
        //    //obj13.asignar("Kits", 20, 213, "", "Ldnet.Manejo_Kits.frmOpcionKits",
        //    //    Properties.Resources.engine, null, true, false, true, "LDNET", "Procesos", false, true);
        //    //list.Add(obj13);

            return list;
        }

    }
}
