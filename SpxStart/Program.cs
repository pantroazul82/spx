using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SpxStart
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            //creamos el form de bienvenida
            System.Threading.Thread hilo = new System.Threading.Thread(new System.Threading.ThreadStart(inicializarDll));
            hilo.Start();
            ///inicializamos las opcines que van de menos
           #region botones de omitir
            SPXprincipal.logica.clsInicializador.botonesOmitir.Add(new SPXprincipal.logica.botones("Parametros y Tablas Generales", "Clientes y Proveedores", "Proveedores"));
            SPXprincipal.logica.clsInicializador.botonesOmitir.Add(new SPXprincipal.logica.botones("Parametros y Tablas Generales", "Geografia", "Ciudades"));
            SPXprincipal.logica.clsInicializador.botonesOmitir.Add(new SPXprincipal.logica.botones("Parametros y Tablas Generales", "Clientes y Proveedores", "Clientes"));

            SPXprincipal.logica.clsInicializador.botonesOmitir.Add(new SPXprincipal.logica.botones("Parametros y Tablas Generales", "Parametros de Referencia", "Categorias"));
            SPXprincipal.logica.clsInicializador.botonesOmitir.Add(new SPXprincipal.logica.botones("Parametros y Tablas Generales", "Parametros de Referencia", "Modelos de Inventario"));
            SPXprincipal.logica.clsInicializador.botonesOmitir.Add(new SPXprincipal.logica.botones("Parametros y Tablas Generales", "Parametros de Referencia", "Grupos de Inventario"));
            SPXprincipal.logica.clsInicializador.botonesOmitir.Add(new SPXprincipal.logica.botones("Parametros y Tablas Generales", "Parametros de Referencia", "Fabricantes"));
            SPXprincipal.logica.clsInicializador.botonesOmitir.Add(new SPXprincipal.logica.botones("Parametros y Tablas Generales", "Parametros de Referencia", "Referencias"));

            SPXprincipal.logica.clsInicializador.botonesOmitir.Add(new SPXprincipal.logica.botones("Parametros y Tablas Generales", "Unidades", "Unidad de Empaque"));
            SPXprincipal.logica.clsInicializador.botonesOmitir.Add(new SPXprincipal.logica.botones("Parametros y Tablas Generales", "Unidades", "Unidad de Tiempo"));

            SPXprincipal.logica.clsInicializador.botonesOmitir.Add(new SPXprincipal.logica.botones("Parametros y Tablas Generales", "Parametros Comunes", "Accesorios"));
            SPXprincipal.logica.clsInicializador.botonesOmitir.Add(new SPXprincipal.logica.botones("Parametros y Tablas Generales", "Parametros Comunes", "Modalidades"));
            SPXprincipal.logica.clsInicializador.botonesOmitir.Add(new SPXprincipal.logica.botones("Parametros y Tablas Generales", "Parametros Comunes", "Tipo de Documento"));
            SPXprincipal.logica.clsInicializador.botonesOmitir.Add(new SPXprincipal.logica.botones("Parametros y Tablas Generales", "Parametros Comunes", "Tipo de Propiedad"));
            SPXprincipal.logica.clsInicializador.botonesOmitir.Add(new SPXprincipal.logica.botones("Parametros y Tablas Generales", "Parametros Comunes", "Titulo Persona"));
            SPXprincipal.logica.clsInicializador.botonesOmitir.Add(new SPXprincipal.logica.botones("Parametros y Tablas Generales", "Parametros Comunes", "Tipo de Servicio"));
            #endregion
            //SPXprincipal.logica.clsInicializador.botonesOmitir.Add(new SPXprincipal.logica.botones("LDNET", "Herramientas", "Cambiar Datos", "ldNetAlcomex.frm.herramientas.frmCambiarFecha_Lote"));
            //esto va cuando es codigo que solo utiliza annar
            //  SupportTech.frm.frmInicio.cnn = Properties.Settings.Default;
            // SupportTech.frm.frmInicio.nombrePropiedadCnn = "wcg_coreConnectionString";
            //SPXprincipal.logica.clsInicializador.botonesOmitir.Add(new SPXprincipal.logica.botones("LDNET","Herramientas","Cambiar Datos","ldNetAlcomex.frm.herramientas.frmCambiarFecha_Lote"));

            #region sustituimos los botones que estan redireccionados
            SPXprincipal.logica.clsInicializador.botonesSustituir.Add(new SPXprincipal.logica.botones("Parametros y Tablas Generales", "Clientes y Proveedores", "Clientes", "SpFrm.generales.frmClientes"));
            #endregion
            #region hacemos esto para dejar limpias las tablas de permisos
            SPXSeguridad.logica.clsInicializador obj = new SPXSeguridad.logica.clsInicializador();
            obj.guardarTablaFuncionalidades();
            obj.guardarTablaModulos();
            #endregion
            #region
            SupportTech.cnn.cargarPermisos();
            SPXStart.cnn.cargarPermisos();
            string tmp = "";
            List<SPXUtilidades.Misc.menuInterface.Interface> lista = SupportTech.cnn.cargarOpcionesWindows(out tmp);
            // SPXUtilidades.Misc.menuInterface.Interface btn = new SPXUtilidades.Misc.menuInterface.Interface();
            //btn.asignar("Checklist Archivos", 0, 0, "", "ldNetAlcomex.frm.ingresos.frmParametrizacionCheck", Properties.Resources.File_Type,
            //    null, true, false, true, "Proceso", "Parametrizacion", false, true);
            //lista.Add(btn);

            for (int k = 0; k < lista.Count; k++)
            {
                SPXprincipal.logica.clsInicializador.botonesAdicionales.Add(lista[k]);
            }
            #endregion
            #region redireccionamos los vinculos de tablas comunes
            //SPXTablasComunes.frm.referencia.frmSeleccionarReferencia.parametrizacionReferencia =
            //    SPXTablasComunes.frm.referencia.frmSeleccionarReferencia.formularioParametrizacion._frmReferenciaIndica;

            ////SPXprincipal.logica.clsInicializador.botonesSustituir.Add(new SPXprincipal.logica.botones("Seguridad", "", "Lineas", "ldNetAlcomex.frm.linea.frmLineaAlcomex"));
            #endregion

            Application.Run(new SupportTech.frm.frmInicio());
        }

        public static void inicializarDll()
        {
            
            SPXFrmAnimacion.frmInicio frInicio = new SPXFrmAnimacion.frmInicio();
            spProcesos.cientifica.frmAccionSeguir f = new spProcesos.cientifica.frmAccionSeguir();
            spHerramientas.consultas.frmSeguimiento fr = new spHerramientas.consultas.frmSeguimiento();
            SPXprincipal.frm.inicio.frmConfigurarImagenInicio fr2 = new SPXprincipal.frm.inicio.frmConfigurarImagenInicio();
           SPXSeguridad.frm.frmPermisos frrr = new SPXSeguridad.frm.frmPermisos();
           /*  spHorarios.Form1 ff = new spHorarios.Form1();
             * */
        }
    }
}
