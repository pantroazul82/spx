using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SupportTech
{
    public class cnn
    {
        public cnn() { }

        public const int versionObligatoriaSupportech=2;
         
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
            //permisos del 1000 - 200
            SPXSeguridad.logica.clsInicializador cls = new SPXSeguridad.logica.clsInicializador();
            cls.cargarTablaModulos();
            cls.cargarTablaFuncionalidades();
            //           	
            cls.agregarModulo(1001, "Almacen");
            cls.agregarModulo(2, "Configuracion");
           // cls.agregarModulo(1002, "Cientifica");
            cls.agregarModulo(1003, "Ingenieria");
            cls.agregarModulo(1004, "Contratos");
            cls.agregarModulo(1005, "SPX Admin");
            cls.agregarModulo(1006, "Herramientas SPX");
            cls.agregarModulo(1007, "Equipos SPX");
            cls.agregarModulo(1008, "Reserva Equipos");
            //cls.agregarModulo(1009, "Actividades Cientifica");
            cls.agregarModulo(1010, "Solicitudes Web");
            //cls.agregarModulo(1011, "Contratos de Consumo");
            //cls.agregarModulo(1012, "Revision de equipos cientifica");
            cls.agregarModulo(1013, "Ingenieria denegacion");
            //cls.agregarModulo(1014, "Contratos de suministro");


            cls.agregarFuncionalidad(2, 20, "Parametros generales");//ok
            cls.agregarFuncionalidad(2, 28, "Configurar clientes");//ok

            #region call cientifica
            //cls.agregarFuncionalidad(1002, 1001, "Acepta Cientifica");
            //cls.agregarFuncionalidad(1002, 1008, "Anula Cientifica");
            //cls.agregarFuncionalidad(1002, 1015, "Asesor Cientifica");
            //cls.agregarFuncionalidad(1002, 1041, "Listado Cientifica");
            //cls.agregarFuncionalidad(1002, 1020, "Cientifica Editada Aceptada");
            //cls.agregarFuncionalidad(1002, 1021, "Cientifica edita asesor responsable");
            //cls.agregarFuncionalidad(1002, 1022, "Cientifica Reabre Orden");
            //cls.agregarFuncionalidad(1002, 1053, "Crea Cientifica");
            //cls.agregarFuncionalidad(1002, 1056, "Parametos Cientifica");
            //cls.agregarFuncionalidad(1002, 1071, "Seguimiento Cientifica");
            #endregion
            #region funciones herramientas
            cls.agregarFuncionalidad(1006, 1090, "Traslado Equipos");//ok
            cls.agregarFuncionalidad(1006, 1091, "Valores x Defecto");//ok
            cls.agregarFuncionalidad(1006, 1092, "Cambiar Seriales");//ok
            cls.agregarFuncionalidad(1006, 1093, "Cambiar Accesorios");//ok
            cls.agregarFuncionalidad(1006, 1094, "Traslados Entre Clientes");//ok
            cls.agregarFuncionalidad(1006, 2017, "Traslados Locales");//ok
            cls.agregarFuncionalidad(1006, 1095, "Seguimiento");//ok
            cls.agregarFuncionalidad(1006, 2031, "Informacion Adicional usuarios");//ok
            cls.agregarFuncionalidad(1006, 1118, "Exporta Excel Seguimiento");//ok
            cls.agregarFuncionalidad(1006, 1096, "Log de Traslados de Equipos");//ok
            cls.agregarFuncionalidad(1003, 1032, "Elimina Historial de Cambio de Ubicacion");//ok
            cls.agregarFuncionalidad(1006, 1097, "Programados Versus Realizados");//ok
            cls.agregarFuncionalidad(1006, 1098, "Correctivos Postpreventivos");//ok
            cls.agregarFuncionalidad(1006, 1099, "Estadistico Matematico");//ok
            cls.agregarFuncionalidad(1006, 1100, "Conteo Correctivos");//ok
            cls.agregarFuncionalidad(1006, 2030, "Traslados a Bodegas Especiales");//ok


            
#endregion
            #region parametrizacion
            cls.agregarFuncionalidad(1007, 1115, "Hoja Vida del Equipo");//ok
            cls.agregarFuncionalidad(1007, 1116, "Modificar Equipos");//ok
            cls.agregarFuncionalidad(1007, 1117, "Parametriza problemas Frecuentes");//ok
            cls.agregarFuncionalidad(1006, 1119, "Modifica Tipo de Propiedad");//ok
            
            #endregion        
            #region Ingenieria
           

            #region orden de prestamo
            cls.agregarFuncionalidad(1003, 1002, "Acepta Orden de Prestamo");//ok
            cls.agregarFuncionalidad(1003, 1010, "Anula Ordenes de Prestamo");//ok
            cls.agregarFuncionalidad(1003, 1017, "Autoriza Orden Prestamo");//ok
            cls.agregarFuncionalidad(1003, 1104, "Recibe Repuestos");//ok
            cls.agregarFuncionalidad(1003, 1105, "Entrega Repuestos");//ok
            cls.agregarFuncionalidad(1003, 1106, "Repuestos Prestados");//ok
            cls.agregarFuncionalidad(1003, 1079, "Solicita Orden de Prestamo");//ok
            cls.agregarFuncionalidad(1003, 1080, "Solicita Orden de Prestamo x Otra Persona");
            cls.agregarFuncionalidad(1003, 1083, "Listado Ordenes de Prestamo");//ok
            #endregion
            #region orden servicio
            cls.agregarFuncionalidad(1003, 1030, "Crea orden de servicio");//ok
            cls.agregarFuncionalidad(1003, 1054, "Listado Ordenes Servicio");//ok
            cls.agregarFuncionalidad(1003, 1081, "Mis Ordenes Servicio");//ok
            cls.agregarFuncionalidad(1003, 1082, "Estadisticas Orden de Servicio");//ok
            cls.agregarFuncionalidad(1003, 1060, "Programacion de Mantenimientos");//ok
            cls.agregarFuncionalidad(1003, 1086, "Listado Programaciones");//ok
            cls.agregarFuncionalidad(1003, 1023, "Cierra Orden de Servicio");//ok
            cls.agregarFuncionalidad(1003, 1065, "Reasigna Orden de Servicio");//ok
            cls.agregarFuncionalidad(1003, 1003, "Acepta Orden de Servicio");//ok
            cls.agregarFuncionalidad(1003, 1011, "Anula Orden de Servicio");//ok
            cls.agregarFuncionalidad(1003, 1014, "Aprueba Ordenes de Servicio");//ok
            cls.agregarFuncionalidad(1003, 1052, "Modifica Ordenes de Servicio en Cualquier Estado.");//ok
            cls.agregarFuncionalidad(1003, 1063, "Realiza Orden de Servicio");//ok
            cls.agregarFuncionalidad(1003, 1200, "Orden Servicio Web");//ok
            cls.agregarFuncionalidad(1003, 1201, "Orden Servicio Web Administrador");//ok
            cls.agregarFuncionalidad(1003, 2014, "Crea orden Web!");//ok
            cls.agregarFuncionalidad(1003, 2015, "Crea Orden Web para otros");//ok
            cls.agregarFuncionalidad(1013, 2052, "Ve solo sus ordenes de servicio web");//ok
            cls.agregarFuncionalidad(1013, 2053, "Ve solo sus ordenes de servicio windows");//ok
            #endregion
            #region entrada salida de equipos
            cls.agregarFuncionalidad(1003, 1005, "Modifica Entrada/Salida Equipos");//ok
            cls.agregarFuncionalidad(1003, 1033, "Crea Entrada de equipo");//ok
            cls.agregarFuncionalidad(1003, 1072, "Crea Salida de equipo");//ok
            cls.agregarFuncionalidad(1003, 1120, "Seguimientos Entrada salida de equipos");//ok
            cls.agregarFuncionalidad(1003, 1034, "Agrega Archivos Entrada/Salida.");//ok
            cls.agregarFuncionalidad(1003, 1035, "Elimina Achivos Entrada/Salida.");//ok
            cls.agregarFuncionalidad(1003, 1036, "Entrada y Salida de Equipos");//ok
            cls.agregarFuncionalidad(1003, 1084, "Listado de Entrada y Salida");//ok
            cls.agregarFuncionalidad(1003, 2013, "Anula Entrada y Salida");//ok
            #endregion
            
            
            cls.agregarFuncionalidad(1003, 1006, "ADMINISTRADOR SOLICITUDES DE SERVICIO");            
            cls.agregarFuncionalidad(1003, 1004, "Acepta Rechaza Prellamada");//ok            
            cls.agregarFuncionalidad(1003, 1009, "ANULA SOLICITUD DE INSUMOS");
            cls.agregarFuncionalidad(1003, 1019, "CIERRA SOLICITUD DE INSUMOS");            
            cls.agregarFuncionalidad(1003, 1013, "Aprueba Solicitudes de Insumos");//ok
            cls.agregarFuncionalidad(1003, 2075, "Crea Solicitud de Insumos");//ok
            cls.agregarFuncionalidad(1003, 1012, "Anula Recoleccion!");//ok
            cls.agregarFuncionalidad(1003, 1113, "Desconfirma recoleccion");//ok
            cls.agregarFuncionalidad(1003, 1026, "Confirma Recoleccion");//ok
            cls.agregarFuncionalidad(1003, 1031, "Crea Recoleccion");//ok

            #region llamadas ingenieria
            cls.agregarFuncionalidad(1003, 1042, "Llamadas Tecnicas");//ok
            cls.agregarFuncionalidad(1003, 1046, "Listado de Llamadas");//ok
            cls.agregarFuncionalidad(1003, 1058, "Listado Prellamadas");//ok
            cls.agregarFuncionalidad(1003, 1064, "Realiza seguimiento");//ok
            cls.agregarFuncionalidad(1003, 1066, "Parametros Llamadas");//ok
            cls.agregarFuncionalidad(1003, 2018, "Parametros Proceso");//ok
            #endregion
            #region contratos
            cls.agregarFuncionalidad(1004, 1029, "Listado Contratos!!");
            cls.agregarFuncionalidad(1004, 1101, "Crear Contratos!!");
            cls.agregarFuncionalidad(1004, 1102, "Parametros Contratos!!");
            cls.agregarFuncionalidad(1004, 1103, "Vincular Ordenes Contrato!!");
            cls.agregarFuncionalidad(1004, 1107, "Desvincular Ordenes Contrato!!");
            #endregion
            #region almacen

            cls.agregarFuncionalidad(1001, 1007, "ALMACEN");
            #endregion
           // cls.agregarFuncionalidad(1003, 1066, "REALIZA SOLICITUD DE INSUMOS");            
            cls.agregarFuncionalidad(1003, 1078, "Crea Solicitud de Servicio");//ok
            cls.agregarFuncionalidad(1003, 1087, "Listado Solicitud de Servicio");//ok
            cls.agregarFuncionalidad(1003, 1085, "Listado Solicitud Insumos");//ok
            cls.agregarFuncionalidad(1003, 2016, "Aprueba Solicitud de Servicio");//ok
            #endregion
            cls.agregarFuncionalidad(1008, 1088, "Listado Equipos Disponibles");//ok
            cls.agregarFuncionalidad(1008, 1089, "Equipos Reservados!");//ok
            #region actividades cientifica
            //cls.agregarFuncionalidad(1009, 2001, "Asignar Tareas!");//ok
            //cls.agregarFuncionalidad(1009, 2006, "Anular Actividades!");//ok
            //cls.agregarFuncionalidad(1009, 2065, "Reabrir Actividades!");//ok
            //cls.agregarFuncionalidad(1009, 2007, "Cerrar Actividades!");//ok
            //cls.agregarFuncionalidad(1009, 2008, "Aprobar Actividades!");//ok
            //cls.agregarFuncionalidad(1009, 2009, "Parametrizacion Actividades Cientifica!");//ok
            //cls.agregarFuncionalidad(1009, 2010, "Ejecuta Actividades Cientifica!");//ok
            //cls.agregarFuncionalidad(1009, 2011, "Crear Capacitaciones!");//ok
            //cls.agregarFuncionalidad(1009, 2021, "Ejecutar Capacitaciones!");//ok
            //cls.agregarFuncionalidad(1009, 2022, "Tomar Capacitaciones!");//ok
            //cls.agregarFuncionalidad(1009, 2023, "Reabrir Capacitaciones!");//ok

            //cls.agregarFuncionalidad(1009, 2012, "Listados Generales de Tareas!");//ok

            //cls.agregarFuncionalidad(1002, 2019, "Crear Control Calidad!");//ok
            //cls.agregarFuncionalidad(1002, 2020, "Listados Control Calidad!");//ok
            //cls.agregarFuncionalidad(1002, 2032, "Ejecuta Control de Calidad!");//ok
            //cls.agregarFuncionalidad(1002, 2033, "Aprueba Control Calidad!");//ok
            //cls.agregarFuncionalidad(1002, 2034, "Cierra Control Calidad!");//ok
            //cls.agregarFuncionalidad(1002, 2035, "Anula Control Calidad!");//ok
            //cls.agregarFuncionalidad(1002, 2036, "Reasigna Control Calidad!");//ok
            //cls.agregarFuncionalidad(1002, 2037, "Imprime Control Calidad!");//ok
            //cls.agregarFuncionalidad(1002, 2066, "Reabre Control Calidad!");//ok

            //cls.agregarFuncionalidad(1002, 2038, "Crear Revision Equipos!");//ok
            //cls.agregarFuncionalidad(1002, 2039, "Listados Revision Equipos!");//ok
            //cls.agregarFuncionalidad(1002, 2040, "Ejecuta Revision Equipos!");//ok
            //cls.agregarFuncionalidad(1002, 2041, "Aprueba Revision Equipos!");//ok
            //cls.agregarFuncionalidad(1002, 2042, "Cierra Revision Equipos!");//ok
            //cls.agregarFuncionalidad(1002, 2043, "Anula Revision Equipos!");//ok
            //cls.agregarFuncionalidad(1002, 2050, "Reabre Revision Equipos!");//ok
            //cls.agregarFuncionalidad(1002, 2049, "Editar en cualquier estado!");//ok

            
            

            #endregion
            

            cls.agregarFuncionalidad(1010, 2002, "Generar solicitudes Web!");//ok
            cls.agregarFuncionalidad(1010, 2003, "Aprobar Solicitudes Web!");//ok
            cls.agregarFuncionalidad(1010, 2004, "Ejecutar Solicitudes Ingenieria!");//ok
            //cls.agregarFuncionalidad(1010, 2005, "Ejecutar Solicitudes Cientifica!");//ok

            //cls.agregarFuncionalidad(1010, 2051, "Listado general de actividades cientifica!");//ok
            //contratos de consumo
            //cls.agregarFuncionalidad(1011, 2045, "Parametros Contratos de Consumo");//ok
            //cls.agregarFuncionalidad(1011, 2046, "Contratos de Consumo");//ok
            //cls.agregarFuncionalidad(1011, 2047, "Ver Todos los Contratos de Consumo");//ok
            //cls.agregarFuncionalidad(1011, 2048, "Elimina Contratos de Consumo");//ok
            //cls.agregarFuncionalidad(1011, 2076, "Edita Especial Contratos de Consumo");//ok
            
            ////contratos de suministro
            //cls.agregarFuncionalidad(1014, 2054, "Crear contratos de suministro");//ok
            //cls.agregarFuncionalidad(1014, 2055, "Primera Aprobacion");//ok
            //tecnico contractual es el permiso 2055
            //cls.agregarFuncionalidad(1014, 2056, "Aprobacion Juridica");//ok
            //cls.agregarFuncionalidad(1014, 2057, "Aprobacion Cartera");//ok
            //cls.agregarFuncionalidad(1014, 2058, "Ver contratos de suministro");//ok
            //cls.agregarFuncionalidad(1014, 2059, "Parametrizacion contratos suministro");//ok

            //cls.agregarFuncionalidad(1014, 2067, "Anula contratos suministro");//ok
            //cls.agregarFuncionalidad(1014, 2068, "Emite Estampillas");//ok
            //cls.agregarFuncionalidad(1014, 2069, "Emite polizas");//ok
            //cls.agregarFuncionalidad(1014, 2070, "Cerrar Contrato");//ok
            //cls.agregarFuncionalidad(1014, 2071, "Reabrir Contrato");//ok
            //cls.agregarFuncionalidad(1014, 2073, "Omitir flujo en creacion");//ok
            //cls.agregarFuncionalidad(1014, 2074, "Adjunta documentos a Contrato suministro");//ok

            ///
            cls.agregarFuncionalidad(1006, 2072, "Asignar Ultimo responsable");//ok
            cls.guardarTablaFuncionalidades();
            cls.guardarTablaModulos();
            //2031f proximo a usar 2077
            //permisos web del 2000 - 3000
        }

        public static List<SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface> cargarOpcionesWindows(out string nombreModulo)
        {
            nombreModulo = "Spx";
            List<SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface> list = new List<SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface>();

            #region cientifica
            //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj73 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            //obj73.asignar("Motivos Anulacion", 1002, 1056, "", "spProcesos.cientifica.frmMotivoAnulacionCientifica", SPControladoraDatos.Properties.Resources.motivos_anulacion,
            //    null, true, false, true, "SPX Cientifica", "Parametrizacion", false, true);
            //list.Add(obj73);

            //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj74 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            //obj74.asignar("Referencia Reactivo", 1002, 1056, "", "spProcesos.cientifica.frmReferenciaReactivoLista", SPControladoraDatos.Properties.Resources.referencia_reactivo,
            //    null, true, false, true, "SPX Cientifica", "Parametrizacion", false, true);
            //list.Add(obj74);

            //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj75 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            //obj75.asignar("Accion a Seguir", 1002, 1056, "", "spProcesos.cientifica.frmAccionSeguirLista", SPControladoraDatos.Properties.Resources.ok,
            //    null, true, false, true, "SPX Cientifica", "Parametrizacion", false, true);
            //list.Add(obj75);

            //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj76 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            //obj76.asignar("Inconveniente Presentado", 1002, 1056, "", "spProcesos.cientifica.frmInconvenientePresentadoPor", SPControladoraDatos.Properties.Resources.inconvenientes,
            //    null, true, false, true, "SPX Cientifica", "Parametrizacion", false, true);
            //list.Add(obj76);

            //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj77 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            //obj77.asignar("Prioridad", 1002, 1056, "", "spProcesos.cientifica.frmPrioridadesCientificaListado", SPControladoraDatos.Properties.Resources.prioridad_cientifica,
            //    null, true, false, true, "SPX Cientifica", "Parametrizacion", false, true);
            //list.Add(obj77);

            //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj78 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            //obj78.asignar("Problema Comun", 1002, 1056, "", "spProcesos.cientifica.frmProblemasComunesLista", SPControladoraDatos.Properties.Resources.problema_comun,
            //    null, true, false, true, "SPX Cientifica", "Parametrizacion", false, true);
           // list.Add(obj78);

            //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj79 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            //obj79.asignar("Parametros Cientifica", 1002, 1056, "", "spProcesos.cientifica.frmParametrosCientifica", SPControladoraDatos.Properties.Resources.parametros_cientifica,
            //    null, true, false, true, "SPX Cientifica", "Parametrizacion", false, true);
            //list.Add(obj79);

            //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj80 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            //obj80.asignar("Registrar Cientifica", 1002, 1053, "", "spProcesos.cientifica.proceso.frmNuevaAsesoria", SPControladoraDatos.Properties.Resources.registrar_cientifica,
            //    null, false, true, false, "SPX Cientifica", "Proceso", false, true);
            //list.Add(obj80);
            
            //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj81 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            //obj81.asignar("Listado Cientifica", 1002, 1041, "", "spProcesos.cientifica.proceso.frmListadoCientifica", SPControladoraDatos.Properties.Resources.consultaCientifica,
            //    null, true, false, true, "SPX Cientifica", "Proceso", false, true);
            //list.Add(obj81);
            
            //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj82 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            //obj82.asignar("Estadisticas Cientifica", 1002, 1041, "", "spProcesos.cientifica.proceso.frmEstadisticasCientificas", SPControladoraDatos.Properties.Resources.estadisticas,
            //    null, true, false, true, "SPX Cientifica", "Proceso", false, true);
            //list.Add(obj82);

            #endregion


            #region contratos de consumo
            //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface objConsumo1 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            //objConsumo1.asignar("Nuevo Contrato de Consumo ", 1011, 2045, "", "spProcesos.contratos_consumo.contratosConsumo",SPControladoraDatos.Properties.Resources.Crystal_Clear_app_business,
            //    null, true, false, true, "Contratos de Consumo", "Proceso", false, true);
            //list.Add(objConsumo1);

            //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface objConsumo2 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            //objConsumo2.asignar("Listado Contratos de Consumo ", 1011, 2045, "", "spProcesos.contratos_consumo.frmListadoContratosConsumo",SPControladoraDatos.Properties.Resources.Crystal_Clear_app_business,
            //    null, true, false, true, "Contratos de Consumo", "Proceso", false, true);
            //list.Add(objConsumo2);

            //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface objConsumo2a = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            //objConsumo2a.asignar("Comparativa Contratos/Instalaciones ", 1011, 2045, "", "spProcesos.contratos_consumo.frmListadoComparativo",SPControladoraDatos.Properties.Resources.Crystal_Clear_app_business,
            //    null, true, false, true, "Contratos de Consumo", "Reportes", false, true);
            //list.Add(objConsumo2a);

            //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface objConsumo2b = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            //objConsumo2b.asignar("Consulta de Vencimientos ", 1011, 2045, "", "spProcesos.contratos_consumo.frmConsultaVencimientos",SPControladoraDatos.Properties.Resources.Crystal_Clear_app_business,
            //    null, true, false, true, "Contratos de Consumo", "Reportes", false, true);
            //list.Add(objConsumo2b);

            

            // SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface objConsumo2c = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            // objConsumo2c.asignar("Reporte Maestro", 1011, 2045, "", "spProcesos.contratos_consumo.frmReporteMaestro",SPControladoraDatos.Properties.Resources.Crystal_Clear_app_business,
            //    null, true, false, true, "Contratos de Consumo", "Reportes", false, true);
            //list.Add(objConsumo2c);

            // SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface objConsumo2d = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            // objConsumo2d.asignar("Contratos por Asesor", 1011, 2045, "", "spProcesos.contratos_consumo.contratosPorAsesor",SPControladoraDatos.Properties.Resources.Crystal_Clear_app_business,
            //    null, true, false, true, "Contratos de Consumo", "Reportes", false, true);
            //list.Add(objConsumo2d);


            

            //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface objConsumo3 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            //objConsumo3.asignar("Lineas de Consumo ", 1011, 2046, "", "spProcesos.contratos_consumo.frmListadoLineasConsumo",SPControladoraDatos.Properties.Resources.Crystal_Clear_app_business,
            //    null, true, false, true, "Contratos de Consumo", "Parametrizacion", false, true);
            //list.Add(objConsumo3);

            //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface objConsumo4 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            //objConsumo4.asignar("Modalidad Contrato Consumo ", 1011, 2046, "", "spProcesos.contratos_consumo.frmListadoModalidadContrato",SPControladoraDatos.Properties.Resources.Crystal_Clear_app_business,
            //    null, true, false, true, "Contratos de Consumo", "Parametrizacion", false, true);
            //list.Add(objConsumo4);

            //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface objConsumo5 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            //objConsumo5.asignar("Sub Modalidad Contrato Consumo ", 1011, 2046, "", "spProcesos.contratos_consumo.frmListadoSubModalidad",SPControladoraDatos.Properties.Resources.Crystal_Clear_app_business,
            //    null, true, false, true, "Contratos de Consumo", "Parametrizacion", false, true);
            //list.Add(objConsumo5);

            //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface objConsumosoft = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            //objConsumosoft.asignar("Lineas de Software", 1011, 2046, "", "spProcesos.contratos_consumo.frmListadoTipoSoftware",SPControladoraDatos.Properties.Resources.Crystal_Clear_app_business,
            //    null, true, false, true, "Contratos de Consumo", "Parametrizacion", false, true);
            //list.Add(objConsumosoft);

            //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface objVigencia = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            //objVigencia.asignar("Lineas de Vigencia ", 1011, 2046, "", "spProcesos.contratos_consumo.frmListadoVigenciasContratos",SPControladoraDatos.Properties.Resources.Crystal_Clear_app_business,
            //    null, true, false, true, "Contratos de Consumo", "Parametrizacion", false, true);
            //list.Add(objVigencia);

            //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface objConsumible = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            //objConsumible.asignar("Consumibles ", 1011, 2046, "", "spProcesos.contratos_consumo.frmListadoConsumibles",SPControladoraDatos.Properties.Resources.Crystal_Clear_app_business,
            //    null, true, false, true, "Contratos de Consumo", "Parametrizacion", false, true);
            //list.Add(objConsumible);


            //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface objGrupoConsumible = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            //objGrupoConsumible.asignar("Grupos de Consumibles ", 1011, 2046, "", "spProcesos.contratos_consumo.frmListadoGruposConsumibles",SPControladoraDatos.Properties.Resources.Crystal_Clear_app_business,
            //    null, true, false, true, "Contratos de Consumo", "Parametrizacion", false, true);
            //list.Add(objGrupoConsumible);

            //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface objRazones = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            //objRazones.asignar("Razones de no renovacion", 1011, 2046, "", "spProcesos.contratos_consumo.frmListadoRazonesNoRenovacion",SPControladoraDatos.Properties.Resources.Crystal_Clear_app_business,
            //    null, true, false, true, "Contratos de Consumo", "Parametrizacion", false, true);
            //list.Add(objRazones);

            
            #endregion

            //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj83= new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            //   obj83.asignar("Equipos Disponibles", 1008, 1088, "", "spProcesos.disponibles.frmDisponibles", SPControladoraDatos.Properties.Resources.Rescue_Disk,
            //    null, true, false, true, "SPX Ingenieria", "Disponibles", false, true);
            //   list.Add(obj83);

            //SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj84= new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            //obj84.asignar("Equipos Reservados", 1008, 1089, "", "spProcesos.disponibles.frmReservados",SPControladoraDatos.Properties.Resources.Rescue_Disk,
            //    null, true, false, true, "SPX Ingenieria", "Disponibles", false, true);
            //   list.Add(obj84);

            

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj.asignar("Nueva Entrada Equipos", 1003, 1036, "", "spProcesos.ESequipos.frmEntradaSalidaEquipos", SPControladoraDatos.Properties.Resources.entradasalidas,
                null, true, false, true, "SPX Ingenieria", "Entrada Salida Equipos", false, true);
            list.Add(obj);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj245 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj245.asignar(@"Listado Entrada/Salidas", 1003, 1084, "", "spProcesos.ESequipos.frmListaEntradaSalidaEquipos", SPControladoraDatos.Properties.Resources.listadocontratos,
                null, true, false, true, "SPX Ingenieria", "Entrada Salida Equipos", false, true);
            list.Add(obj245);
            //--
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj3 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj3.asignar("Crear Orden Servicio", 1003, 1030, "", "spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo", SPControladoraDatos.Properties.Resources.ordenservicio,
                null, true, false, true, "SPX Ingenieria", "Ordenes Servicio", false, true);
            list.Add(obj3);
            
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj4 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj4.asignar("Listado Ordenes de Servicio", 1003, 1054, "", "spProcesos.ordenesTrabajo.frmListadoOrdenesServicio", SPControladoraDatos.Properties.Resources.ordenes_servicio,
                null, true, false, true, "SPX Ingenieria", "Ordenes Servicio", false, true);
            list.Add(obj4);
          
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj5 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj5.asignar("Mis Ordenes de Servicio", 1003, 1081, "", "spProcesos.ordenesTrabajo.frmMisOrdenesPendientes", SPControladoraDatos.Properties.Resources.misordenes,
                null, true, false, true, "SPX Ingenieria", "Ordenes Servicio", false, true);
            list.Add(obj5);
             
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj6 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj6.asignar("Estadisticas Orden de Servicio", 1003, 1082, "", "spProcesos.ordenesTrabajo.listados.frmFiltroEstadistico", SPControladoraDatos.Properties.Resources.Search_Engine,
                null, true, false, true, "SPX Ingenieria", "Ordenes Servicio", false, true);
            list.Add(obj6);
            
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj10 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj10.asignar("Programar Mantenimientos", 1003, 1060, "", "spProcesos.programacion.frmNewProgramacion", SPControladoraDatos.Properties.Resources.programar_viaje,
                null, true, false, true, "SPX Ingenieria", "Ordenes Servicio", false, true);
            list.Add(obj10);
            
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj11 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj11.asignar("Listado Programaciones", 1003, 1086, "", "spProcesos.programacion.frmListadoProgramaciones", SPControladoraDatos.Properties.Resources.listadocontratos,
                null, true, false, true, "SPX Ingenieria", "Ordenes Servicio", false, true);
            list.Add(obj11);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface objInsumos = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            objInsumos.asignar("Crear Solicitud Insumos", 1003, 2075, "", "spProcesos.ordenesTrabajo.frm.frmSeleccionarOrdenParaInsumo",
                SPControladoraDatos.Properties.Resources.imprimir,
                null, true, false, true, "SPX Ingenieria", "Solicitud Insumos", false, true);
            list.Add(objInsumos);
     

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj9 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj9.asignar("Listado Solicitud Insumos", 1003, 1085, "", "spProcesos.ordenesTrabajo.listados.frmListadoSolicitudInsumos", SPControladoraDatos.Properties.Resources.imprimir,
                null, true, false, true, "SPX Ingenieria", "Solicitud Insumos", false, true);
            list.Add(obj9);
     
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj12 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj12.asignar("Llamadas Soporte", 1003, 1042, "", "spProcesos.llamadasTecnicas.frmLlamadasSoporteNuevaVersion", SPControladoraDatos.Properties.Resources.llaamdasoporte,
                null, false, false, false, "SPX Ingenieria", "Call Center", false, true);
            list.Add(obj12);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj13 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj13.asignar("Seguimientos Programados", 1003, 1042, "", "spProcesos.llamadasTecnicas.frmListadoSeguimientos", SPControladoraDatos.Properties.Resources.llamadaseguimiento,
                null, true, false, true, "SPX Ingenieria", "Call Center", false, true);
            list.Add(obj13);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj14 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj14.asignar("Listado de Llamadas", 1003, 1046, "", "spProcesos.llamadasTecnicas.frmListadoLLamadas", SPControladoraDatos.Properties.Resources.telefono,
                null, true, false, true, "SPX Ingenieria", "Call Center", false, true);
            list.Add(obj14);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj15 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj15.asignar("Listado de Prellamadas", 1003, 1058, "", "spProcesos.cientifica.proceso.frmListadoPrellamadas ", SPControladoraDatos.Properties.Resources.prellamada,
                null, true, false, true, "SPX Ingenieria", "Call Center", false, true);
            list.Add(obj15);
           
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj16 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj16.asignar("Crear Solicitud de Servicio", 1003, 1078, "", "spProcesos.solicitudes.frmSolicitudServicio", SPControladoraDatos.Properties.Resources.crearsolicitud,
                null, true, false, true, "SPX Ingenieria", "Solicitud de Servicio", false, true);
            list.Add(obj16);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj17 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj17.asignar("Listado Solicitud de Servicio", 1003, 1087, "", "spProcesos.solicitudes.frmListadoSolicitudesServicio", SPControladoraDatos.Properties.Resources.listsolicitud,
                null, true, false, true, "SPX Ingenieria", "Solicitud de Servicio", false, true);
            list.Add(obj17);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj18 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj18.asignar("Mis Solicitudes de Servicio", 1003, 1078, "", "spProcesos.solicitudes.frmMisSolicitudesPendientes", SPControladoraDatos.Properties.Resources.missolicitudes,
                null, true, false, true, "SPX Ingenieria", "Solicitud de Servicio", false, true);
            list.Add(obj18);


            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj19 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj19.asignar("Recolecciones", 1003, 1031, "", "spProcesos.recolecciones.frmListadoRecolecciones", SPControladoraDatos.Properties.Resources.recolecciones,
                null, true, false, true, "SPX Ingenieria", "Recolecciones", false, true);
            list.Add(obj19);
           
            //tablas
            #region parametros
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj20 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj20.asignar("Tipos de Actividad", 2, 20, "", "SpFrm.actividades.frmTipoACtividad",SPControladoraDatos.Properties.Resources.tipo_actividad,
                null, true, false, true, "Parametros","Actividades",  false, true);
            list.Add(obj20);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj21 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj21.asignar("Listado Actividades Extra", 2, 20, "", "SpFrm.actividades.frmListadoACtividades",SPControladoraDatos.Properties.Resources.activiadesextra,
                null, true, false, true,"Parametros", "Actividades",  false, true);
            list.Add(obj21);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj22 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj22.asignar("Equipos", 1007, 1116, "", "spProcesos.Equipos.frmEquipos",SPControladoraDatos.Properties.Resources.equipos,
                null, true, false, true, "Parametros", "Equipos", false, true);
            list.Add(obj22);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface objreactivar = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            objreactivar.asignar("Reactivar Equipos", 1007, 1116, "", "spProcesos.Equipos.frmEquiposEliminados",SPControladoraDatos.Properties.Resources.equipos,
                null, true, false, true, "Parametros", "Equipos", false, true);
            list.Add(objreactivar);
            

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj23 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj23.asignar("Archivos x Equipo", 1007, 1116, "", "spProcesos.Equipos.frmTiposArchivosxEquipos",SPControladoraDatos.Properties.Resources.tipos_archivo,
                null, true, false, true, "Parametros", "Equipos", false, true);
            list.Add(obj23);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj24 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj24.asignar("Modalidades por Equipo", 2, 20, "", "SpFrm.generales.frmModalidadEquipo",SPControladoraDatos.Properties.Resources.modalidadequipo,
                null, true, false, true, "Parametros", "Equipos", false, true);
            list.Add(obj24);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj25 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj25.asignar("Estado Fisico", 2, 20, "", "SpFrm.generales.frmEstadoFisicamente",SPControladoraDatos.Properties.Resources.estadosfisico,
                null, true, false, true, "Parametros", "Equipos", false, true);
            list.Add(obj25);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj26 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj26.asignar("Estado Equipos Taller", 2, 20, "", "SpFrm.generales.frmEstadoEquiposLocales",SPControladoraDatos.Properties.Resources.estadoslocales,
                null, true, false, true, "Parametros", "Equipos", false, true);
            list.Add(obj26);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj27 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj27.asignar("Fabricantes", 2, 20, "", "SpFrm.generales.frmFabricante",SPControladoraDatos.Properties.Resources.fabricantes,
                null, true, false, true, "Parametros", "Modelos", false, true);
            list.Add(obj27);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj28 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj28.asignar("Modelos", 2, 20, "", "SpFrm.generales.frmModelos",SPControladoraDatos.Properties.Resources.modelos,
                null, true, false, true, "Parametros", "Modelos", false, true);
            list.Add(obj28);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj29 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj29.asignar("Actividades por Modelo", 2, 20, "", "SpFrm.generales.frmActividadesxModelo",SPControladoraDatos.Properties.Resources.buscar,
                null, true, false, true, "Parametros", "Modelos", false, true);
            list.Add(obj29);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface objTemplatesModelo = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            objTemplatesModelo.asignar("Templates Revision por Modelo", 2, 20, "", "spProcesos.cientifica.parametrizacion.frmTemplateRevisionEquipo",SPControladoraDatos.Properties.Resources.modelos,
                null, true, false, true, "Parametros", "Modelos", false, true);
            list.Add(objTemplatesModelo);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface objVariables = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            objVariables.asignar("Variables de Medicion", 2, 20, "", "SpFrm.generales.frmVariableMedicion",SPControladoraDatos.Properties.Resources.tipo_equipo,
                null, true, false, true, "Parametros", "Modelos", false, true);
            list.Add(objVariables);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface objSubVariables = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            objSubVariables.asignar("Sub Variables de Medicion", 2, 20, "", "SpFrm.generales.frmSubVariableMedicion",SPControladoraDatos.Properties.Resources.contratos,
                null, true, false, true, "Parametros", "Modelos", false, true);
            list.Add(objSubVariables);

             

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj30 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj30.asignar("Tipos de Equipo", 2, 20, "", "SpFrm.generales.frmTipoEquipo",SPControladoraDatos.Properties.Resources.tipo_equipo,
                null, true, false, true, "Parametros", "Modelos", false, true);
            list.Add(obj30);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj31 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj31.asignar("Subtipo de Equipo", 2, 20, "", "SpFrm.generales.frmSubTipoEquipo",SPControladoraDatos.Properties.Resources.subtipoEquipo,
                null, true, false, true, "Parametros", "Modelos", false, true);
            list.Add(obj31);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj32 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj32.asignar("Repuestos", 2, 20, "", "SpFrm.generales.frmRepuestos",SPControladoraDatos.Properties.Resources.repuestos,
                null, true, false, true, "Parametros", "Modelos", false, true);
            list.Add(obj32);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj33 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj33.asignar("Accesorios", 2, 20, "", "spProcesos.ESequipos.frmAccesoriosEquipo",SPControladoraDatos.Properties.Resources.accsorios,
                null, true, false, true, "Parametros", "Modelos", false, true);
            list.Add(obj33); 
            
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj34 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj34.asignar("Tipos de Documento", 2, 20, "", "SpFrm.generales.frmTipoDocumento",SPControladoraDatos.Properties.Resources.tipo_documento,
                null, true, false, true, "Parametros", "Clientes", false, true);
            list.Add(obj34);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj35 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj35.asignar("Titulos Contactos", 2, 20, "", "SpFrm.generales.frmTituloContacto",SPControladoraDatos.Properties.Resources.titulos_contacto,
                null, true, false, true, "Parametros", "Clientes", false, true);
            list.Add(obj35);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj43 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj43.asignar("Transportadoras", 2, 20, "", "SpFrm.terceros.frmTransportadora",SPControladoraDatos.Properties.Resources.trasportador,
                null, true, false, true, "Parametros", "Clientes", false, true);
            list.Add(obj43);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj36 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj36.asignar("Asesores Comerciales", 2, 20, "", "SpFrm.generales.frmAsesoresComerciales",SPControladoraDatos.Properties.Resources.usuarios,
                null, true, false, true, "Parametros", "Clientes", false, true);
            list.Add(obj36);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj37 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj37.asignar("Clientes", 2, 28, "", "SpFrm.generales.frmClientes",SPControladoraDatos.Properties.Resources.cliente,
                null, true, false, true, "Parametros", "Clientes", false, true);
            list.Add(obj37);
            
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj38 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj38.asignar("Paises", 2, 20, "", "SpFrm.generales.frmPaises",SPControladoraDatos.Properties.Resources.paises,
                null, true, false, true, "Parametros", "Geografia", false, true);
            list.Add(obj38);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj39 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj39.asignar("Departamentos", 2, 20, "", "SpFrm.generales.frmDepartamento",SPControladoraDatos.Properties.Resources.pais,
                null, true, false, true, "Parametros", "Geografia", false, true);
            list.Add(obj39);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj40 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj40.asignar("Ciudades", 2, 20, "", "SpFrm.generales.FrmCiudades",SPControladoraDatos.Properties.Resources.departamento,
                null, true, false, true, "Parametros", "Geografia", false, true);
            list.Add(obj40);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj41 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj41.asignar("Regiones x Usuario", 2, 20, "", "SpFrm.tool.regionesxUsuarios",SPControladoraDatos.Properties.Resources.regionesxusuario,
                null, true, false, true, "Parametros", "Geografia", false, true);
            list.Add(obj41);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj42 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj42.asignar("Bodegas Taller", 2, 20, "", "SpFrm.tool.frmInformacionLocal",SPControladoraDatos.Properties.Resources.estadoslocales,
                null, true, false, true, "Parametros", "Geografia", false, true);
            list.Add(obj42);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj44 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj44.asignar("Estados Solicitud", 2, 20, "", "SpFrm.generales.frmEstadosSolicitudes",SPControladoraDatos.Properties.Resources.estadossolictud,
                null, true, false, true, "Parametros", "Proceso", false, true);
            list.Add(obj44);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj45 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj45.asignar("Prioridad Solicitud", 2, 20, "", "SpFrm.generales.frmPrioridadSolicitud",SPControladoraDatos.Properties.Resources.prioridad_solicitudes,
                null, true, false, true, "Parametros", "Proceso", false, true);
            list.Add(obj45);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj46 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj46.asignar("Medios Solicitud", 2, 20, "", "SpFrm.generales.frmMediosSolicitud",SPControladoraDatos.Properties.Resources.mediossolicitud,
                null, true, false, true, "Parametros", "Proceso", false, true);
            list.Add(obj46);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj47 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj47.asignar("Prioridades orden de servicio", 2, 20, "", "SpFrm.generales.frmPrioridadesOrdenServicio",SPControladoraDatos.Properties.Resources.prioridad_orden_servicio,
                null, true, false, true, "Parametros", "Proceso", false, true);
            list.Add(obj47);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj48 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj48.asignar("Tipos de Servicio", 2, 20, "", "SpFrm.rptServicios.frmTipoServicio",SPControladoraDatos.Properties.Resources.tipo_servicio,
                null, true, false, true, "Parametros", "Proceso", false, true);
            list.Add(obj48);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj49 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj49.asignar("Tipos de Propiedad", 2, 20, "", "SpFrm.generales.frmTipoPropiedad",SPControladoraDatos.Properties.Resources.tipo_prioridad,
                null, true, false, true, "Parametros", "Proceso", false, true);
            list.Add(obj49);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj50 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj50.asignar("Problemas Comunes", 2, 20, "", "spProcesos.problemas_frecuentes.frmParametrizacionProblemas",SPControladoraDatos.Properties.Resources.problemas_frecuentes,
                null, true, false, true, "Parametros", "Proceso", false, true);
            list.Add(obj50);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj51 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj51.asignar("Dias Festivos", 2, 20, "", "SPControladoraDatos.artefactos.SPXUtilidades.Misc.festivos.frmConfiguracionFestivos",SPControladoraDatos.Properties.Resources.disafestivos,
                null, true, false, true, "Parametros", "Proceso", false, true);
            list.Add(obj51);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj84 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj84.asignar("Tipo Asesoria Llamadas", 1003, 1066, "", "spProcesos.llamadasTecnicas.frmListadoTipoAsesoria",SPControladoraDatos.Properties.Resources.Search_Engine,
                null, true, false, true, "Parametros", "Proceso", false, true);
            list.Add(obj84);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj85 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj85.asignar("Resultado Final Llamadas", 1003, 2018, "", "spProcesos.llamadasTecnicas.frmListadoREsFinal",SPControladoraDatos.Properties.Resources.Search_Engine,
                null, true, false, true, "Parametros", "Proceso", false, true);
            list.Add(obj85);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface objParSolicitud = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            objParSolicitud.asignar("Motivo Salida", 1003, 2018, "", "SpFrm.generales.newFormat.frmListadoMotivoSalida",SPControladoraDatos.Properties.Resources.Search_Engine,
                null, true, false, true, "Parametros", "Proceso", false, true);
            list.Add(objParSolicitud);
            #endregion
            #region herramientas
            /*SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj631 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj631.asignar("1. Calendario", 0, 0, "", "spHorarios.Form1",SPControladoraDatos.Properties.Resources.calendar30,
                null, true, false, true, "Herramientas SPX", "", false, true);
            list.Add(obj631);*/

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj58 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj58.asignar("1. Seguimiento", 1006, 1095, "", "spHerramientas.consultas.frmSeguimiento",SPControladoraDatos.Properties.Resources.seguimiento,
                null, true, false, true, "Herramientas SPX", "", false, true);
            list.Add(obj58);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface objauditoria= new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            objauditoria.asignar("2. Auditoria", 1006, 1095, "", "spProcesos.Equipos.frmAuditoriaEquipo",SPControladoraDatos.Properties.Resources.seguimiento,
                null, true, false, true, "Herramientas SPX", "", false, true);
            list.Add(objauditoria);
            

                SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface objInfAdicional = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
                objInfAdicional.asignar("Informacion Adicional de usuarios", 1006, 2031, "", "spHerramientas.frm.frmInformacionAdicionalUsuario",SPControladoraDatos.Properties.Resources.cliente,
                null, true, false, true, "Seguridad", "", false, true);
                list.Add(objInfAdicional);

            

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj52 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj52.asignar("3. Traslado Equipos", 1006, 1090, "", "spProcesos.Herramientas.frmTrasladosDeEquipos",SPControladoraDatos.Properties.Resources.traslado,
                null, true, false, true, "Herramientas SPX", "", false, true);
            list.Add(obj52);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface objtrasladoLocal = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            objtrasladoLocal.asignar("3.b Traslado Equipos Local", 1006, 2017, "", "spProcesos.Herramientas.frmTrasladosDeEquiposLocal",SPControladoraDatos.Properties.Resources.traslado,
                null, true, false, true, "Herramientas SPX", "", false, true);
            list.Add(objtrasladoLocal);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj53 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj53.asignar("8. Valores x Defecto", 1006, 1091, "", "spHerramientas.tool.frmDefaults",SPControladoraDatos.Properties.Resources.tool2,
                null, true, false, true, "Herramientas SPX", "", false, true);
            list.Add(obj53);
                                    
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface objBodegasLocales = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            objBodegasLocales.asignar("8b. Informacion Local", 1006, 1091, "", "SpFrm.tool.frmInformacionLocal",SPControladoraDatos.Properties.Resources.tool2,
                null, true, false, true, "Herramientas SPX", "", false, true);
            list.Add(objBodegasLocales);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj54 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj54.asignar("7. Cambiar Seriales", 1006, 1092, "", "spHerramientas.frm.frmCambiarSeriales",SPControladoraDatos.Properties.Resources.serial,
                null, true, false, true, "Herramientas SPX", "", false, true);
            list.Add(obj54);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj55 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj55.asignar("6. Cambiar Accesorios", 1006, 1093, "", "spHerramientas.frm.frmCambiarCodigoAccesorio",SPControladoraDatos.Properties.Resources.repuestos,
                null, true, false, true, "Herramientas SPX", "", false, true);
            list.Add(obj55);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj56 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj56.asignar("5. Traslados Entre Clientes", 1006, 1094, "", "spProcesos.Herramientas.frmTrasladosMasivos",SPControladoraDatos.Properties.Resources.serial,
                null, true, false, true, "Herramientas SPX", "", false, true);
            list.Add(obj56);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj59 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj59.asignar("4. Log de Traslados de Equipos", 1006, 1096, "", "SpFrm.tool.frmLogTraslados",SPControladoraDatos.Properties.Resources.listadocontratos,
                null, true, false, true, "Herramientas SPX", "", false, true);
            list.Add(obj59);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj60 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj60.asignar("9. Programados Versus Realizados", 1006, 1097, "", "spHerramientas.consultas.frmIndMantProgxReal",SPControladoraDatos.Properties.Resources.programadosversusrealizados,
                null, true, false, true, "Herramientas SPX", "", false, true);
            list.Add(obj60);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj61 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj61.asignar("Correctivos Postpreventivos", 1006, 1098, "", "spHerramientas.consultas.frmIndPreventivoGenCorrectivo",SPControladoraDatos.Properties.Resources.indicadorespreventivos,
                null, true, false, true, "Herramientas SPX", "", false, true);
            list.Add(obj61);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj62 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj62.asignar("Estadistico Matematico", 1006, 1099, "", "SpFrm.tool.frmEstadistico",SPControladoraDatos.Properties.Resources.estadisticas4 ,
                null, true, false, true, "Herramientas SPX", "", false, true);
            list.Add(obj62);
            
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj63 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj63.asignar("Conteo Correctivos", 1006, 1100, "", "spProcesos.Herramientas.frmConteoCorrectivos",SPControladoraDatos.Properties.Resources.formas,
                null, true, false, true, "Herramientas SPX", "", false, true);
            list.Add(obj63);

              SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj63a = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
              obj63a.asignar("Utilidades", 1006, 1100, "", "spProcesos.HerramientasAnnar.frmUtilidades",SPControladoraDatos.Properties.Resources.formas,
                null, true, false, true, "Herramientas SPX", "", false, true);
            list.Add(obj63a);

            
#endregion
            #region contratos
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj64 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj64.asignar("Tipos de Contrato", 1004, 1102, "", "spProcesos.contratos.frmTipoContratos",SPControladoraDatos.Properties.Resources.tipo_contratos,
                null, true, false, true, "SPX Ingenieria", "Contratos", false, true);
            list.Add(obj64);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj65 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj65.asignar("Modalidad de Contrato", 1004, 1102, "", "spProcesos.contratos.frmModalidadContrato",SPControladoraDatos.Properties.Resources.modalidadcontrato,
                null, true, false, true, "SPX Ingenieria", "Contratos", false, true);
            list.Add(obj65);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj66 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj66.asignar("Nuevo Contrato", 1004, 1101, "", "spProcesos.contratos.frmNuevoContrato",SPControladoraDatos.Properties.Resources.contratos,
                null, true, false, true, "SPX Ingenieria", "Contratos", false, true);
            list.Add(obj66);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj67 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj67.asignar("Listado Contratos", 1004, 1029, "", "spProcesos.contratos.frmListadoContratos",SPControladoraDatos.Properties.Resources.listadocontratos,
                null, true, false, true, "SPX Ingenieria", "Contratos", false, true);
            list.Add(obj67);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj68 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj68.asignar("Contratos Proximos a Vencer", 1004, 1029, "", "spProcesos.contratos.frmListadoContratosAVencer",SPControladoraDatos.Properties.Resources.mes,
                null, true, false, true, "SPX Ingenieria", "Contratos", false, true);
            list.Add(obj68);

            #endregion
            #region Orden Prestamo
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj7 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj7.asignar("Crear Orden Prestamo", 1003, 1079, "", "spProcesos.ordenPrestamo.frmSolicitarPrestamo",SPControladoraDatos.Properties.Resources.orden_prestamo,
                null, true, false, true, "SPX Ingenieria", "Ordenes Prestamo", false, true);
            list.Add(obj7);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj8 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj8.asignar("Listado Ordenes de Prestamo", 1003, 1083, "", "spProcesos.ordenPrestamo.frmListadoOrdenPrestamo",SPControladoraDatos.Properties.Resources.ordenprestamo,
                null, true, false, true, "SPX Ingenieria", "Ordenes Prestamo", false, true);
            list.Add(obj8);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj69 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj69.asignar("Entregar Repuestos", 1003, 1105, "", "spProcesos.ordenPrestamo.frmEntregarRepuestos",SPControladoraDatos.Properties.Resources.entregarepuestos,
                null, true, false, true, "SPX Ingenieria", "Ordenes Prestamo", false, true);
            list.Add(obj69);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj70 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj70.asignar("Recibir Repuestos", 1003, 1104, "", "spProcesos.ordenPrestamo.frmRecibirRepuestos",SPControladoraDatos.Properties.Resources.recibir_repuestos,
                null, true, false, true, "SPX Ingenieria", "Ordenes Prestamo", false, true);
            list.Add(obj70);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface obj72 = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            obj72.asignar("Repuestos Prestados", 1003, 1106, "", "spProcesos.ordenPrestamo.frmRepuestosPendientes",SPControladoraDatos.Properties.Resources.repuestos_prestados,
                null, true, false, true, "SPX Ingenieria", "Ordenes Prestamo", false, true);
            list.Add(obj72);
            #endregion
            
            return list;
        }
  
    }
}
