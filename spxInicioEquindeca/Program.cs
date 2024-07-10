using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace spxInicio
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
            
            //verficamos el serial de licencia
            SPXSeguridad.licencias.Verificador.Aplicativo = "Support Tech X";
            SPXSeguridad.licencias.Verificador.VersionApp = "2.0";
            SPXSeguridad.licencias.Verificador objVer = new SPXSeguridad.licencias.Verificador();


            if (!objVer.verificarSerial())
            {
                if (MessageBox.Show("Para poder utilizar este software\n debe tener un codigo de licencia valido\nregistrar ahora?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
                   == DialogResult.No) return;
                SPXSeguridad.licencias.frmRegistrar f = new SPXSeguridad.licencias.frmRegistrar();
                if (f.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
            }
            

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
            SPXprincipal.logica.clsInicializador.botonesOmitir.Add(new SPXprincipal.logica.botones("Parametros y Tablas Generales", "Generales", "Dominios"));
           // SPXprincipal.logica.clsInicializador.botonesOmitir.Add(new SPXprincipal.logica.botones("Parametros y Tablas Generales", "Generales", "Dominios"));
            SPXprincipal.logica.clsInicializador.botonesOmitir.Add(new SPXprincipal.logica.botones("Parametrizacion Flujo", "", "Ajustes Varios"));
            SPXprincipal.logica.clsInicializador.botonesOmitir.Add(new SPXprincipal.logica.botones("Parametrizacion Flujo", "", "Configuracion  Mapping"));
            SPXprincipal.logica.clsInicializador.botonesOmitir.Add(new SPXprincipal.logica.botones("Parametrizacion Flujo", "", "Configuracion  Virtuales"));
            SPXprincipal.logica.clsInicializador.botonesOmitir.Add(new SPXprincipal.logica.botones("Parametrizacion Flujo", "", "Flujo"));
            SPXprincipal.logica.clsInicializador.botonesOmitir.Add(new SPXprincipal.logica.botones("Parametrizacion Flujo", "", "Listado Estados"));
            SPXprincipal.logica.clsInicializador.botonesOmitir.Add(new SPXprincipal.logica.botones("Parametrizacion Flujo", "", "Listado Movimientos"));
            SPXprincipal.logica.clsInicializador.botonesOmitir.Add(new SPXprincipal.logica.botones("Parametrizacion Flujo", "", "Listado Procesos"));
            SPXprincipal.logica.clsInicializador.botonesOmitir.Add(new SPXprincipal.logica.botones("Parametrizacion Flujo", "", "Motivos de Anulacion"));
            SPXprincipal.logica.clsInicializador.botonesOmitir.Add(new SPXprincipal.logica.botones("Parametrizacion Flujo", "", "Tipos de Archivo"));
            SPXprincipal.logica.clsInicializador.botonesOmitir.Add(new SPXprincipal.logica.botones("Parametrizacion Flujo", "", "Tipos de Movimiento"));
            SPXprincipal.logica.clsInicializador.botonesOmitir.Add(new SPXprincipal.logica.botones("Parametrizacion Flujo", "", "Tipos de Novedad"));
            SPXprincipal.logica.clsInicializador.botonesOmitir.Add(new SPXprincipal.logica.botones("PArametros", "Modelos", "Templates Revision por Modelos"));




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
            spxreactlab.cnn.cargarPermisos();
            SPXSeguridad.cnn.usuariosLicencia = 10;
            SPXSeguridad.cnn.validaUsuarios = true;
            string tmp = "",tmp2="";
           List<SPXUtilidades.Misc.menuInterface.Interface> lista = SupportTech.cnn.cargarOpcionesWindows(out tmp);
           List<SPXUtilidades.Misc.menuInterface.Interface> lista2 = spxreactlab.cnn.cargarOpcionesWindows(out tmp2);

           for (int k = 0; k < lista2.Count; k++)
           {
               SPXprincipal.logica.clsInicializador.botonesAdicionales.Add(lista2[k]);
           }
           
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


            SupportTech.frm.frmInicio.validarUsuarios = true;
        SupportTech.frm.frmInicio.usuariosLicencia = 1000;
            Application.Run(new SupportTech.frm.frmInicio());
        }

        public static void inicializarDll()
        {
           SPXFrmAnimacion.frmInicio frInicio = new SPXFrmAnimacion.frmInicio();
           spProcesos.cientifica.frmAccionSeguir f = new spProcesos.cientifica.frmAccionSeguir();
           spHerramientas.consultas.frmSeguimiento seguimiento = new spHerramientas.consultas.frmSeguimiento();
           SPXWms.Consultas.frmConsultaInventario fr = new SPXWms.Consultas.frmConsultaInventario();
           SPXprincipal.frm.inicio.frmConfigurarImagenInicio fr2 = new SPXprincipal.frm.inicio.frmConfigurarImagenInicio();
           SPXSeguridad.frm.frmPermisos frrr = new SPXSeguridad.frm.frmPermisos();
           spHorarios.Form2 ff = new spHorarios.Form2();
        }
    }
}
