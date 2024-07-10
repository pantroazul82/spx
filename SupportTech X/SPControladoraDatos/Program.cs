using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SPControladoraDatos
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //creamos el form de bienvenida
            System.Threading.Thread hilo = new System.Threading.Thread(new System.Threading.ThreadStart(inicializarDll));
            hilo.Start();
            ///inicializamos las opcines que van de menos

            //SPControladoraDatos.artefactos.SPXprincipal.logica.clsInicializador.botonesOmitir.Add(new SPControladoraDatos.artefactos.SPXprincipal.logica.botones("LDNET", "Herramientas", "Cambiar Datos", "ldNetAlcomex.frm.herramientas.frmCambiarFecha_Lote"));
            //esto va cuando es codigo que solo utiliza annar
            //  SupportTech.frm.frmInicio.cnn = Properties.Settings.Default;
            // SupportTech.frm.frmInicio.nombrePropiedadCnn = "wcg_coreConnectionString";
            //SPControladoraDatos.artefactos.SPXprincipal.logica.clsInicializador.botonesOmitir.Add(new SPControladoraDatos.artefactos.SPXprincipal.logica.botones("LDNET","Herramientas","Cambiar Datos","ldNetAlcomex.frm.herramientas.frmCambiarFecha_Lote"));

            //codigo para garantizar los pagos de reactivos del valle
            //primero validamos los usuarios 10 activos tiene reactivos

            


            #region sustituimos los botones que estan redireccionados
            SPControladoraDatos.artefactos.SPXprincipal.logica.clsInicializador.botonesSustituir.Add(new SPControladoraDatos.artefactos.SPXprincipal.logica.botones("Parametros y Tablas Generales", "Clientes y Proveedores", "Clientes", "SpFrm.generales.frmClientes"));
            #endregion
            #region hacemos esto para dejar limpias las tablas de permisos
            /**/
            SPXSeguridad.logica.clsInicializador obj = new SPXSeguridad.logica.clsInicializador();
            obj.guardarTablaFuncionalidades();
            obj.guardarTablaModulos();
            #endregion
            #region
            SupportTech.cnn.cargarPermisos();
            spxInicio.cnn.cargarPermisos();
            string tmp = "";
            List<SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface> lista = SupportTech.cnn.cargarOpcionesWindows(out tmp);
            // SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface btn = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface();
            //btn.asignar("Checklist Archivos", 0, 0, "", "ldNetAlcomex.frm.ingresos.frmParametrizacionCheck", Properties.Resources.File_Type,
            //    null, true, false, true, "Proceso", "Parametrizacion", false, true);
            //lista.Add(btn);

            for (int k = 0; k < lista.Count; k++)
            {
                SPControladoraDatos.artefactos.SPXprincipal.logica.clsInicializador.botonesAdicionales.Add(lista[k]);
            }
            #endregion
            #region redireccionamos los vinculos de tablas comunes
            //SPXTablasComunes.frm.referencia.frmSeleccionarReferencia.parametrizacionReferencia =
            //    SPXTablasComunes.frm.referencia.frmSeleccionarReferencia.formularioParametrizacion._frmReferenciaIndica;

            ////SPControladoraDatos.artefactos.SPXprincipal.logica.clsInicializador.botonesSustituir.Add(new SPControladoraDatos.artefactos.SPXprincipal.logica.botones("Seguridad", "", "Lineas", "ldNetAlcomex.frm.linea.frmLineaAlcomex"));
            #endregion



            Application.Run(new SupportTech.frm.frmInicio());
        }


        public static void inicializarDll()
    {
        /**/
        SPXFrmAnimacion.frmInicio frInicio = new SPXFrmAnimacion.frmInicio();
        spProcesos.cientifica.frmAccionSeguir f = new spProcesos.cientifica.frmAccionSeguir();
        spHerramientas.consultas.frmSeguimiento fr = new spHerramientas.consultas.frmSeguimiento();

        //spHorarios.Form2 ff = new spHorarios.Form2();
    }
    }

}
