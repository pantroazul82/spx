using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using System.IO;
using SpFrm.generales;

namespace spProcesos.ordenesTrabajo
{
    public partial class frmNuevaOrdenTrabajo : Form
    {
        public frmNuevaOrdenTrabajo()
        {
            InitializeComponent();
        }

        #region zona de permisos y opciones de botones
        private bool per_programaOrden = false;
        private bool per_reasignaOrden = false;
        private bool per_cierraOrden = false;
        private bool per_apruebaOrden = false;
        private bool per_anulaOrden = false;
        private bool per_realizaOrden = false;
        private bool per_modificaOrden = false;//este permite modificar la orden en cualquier estado de la misma

        private string codOrdenServicio = "";
        public string CodOrdenServicio { set { codOrdenServicio = value; } get { return codOrdenServicio; } }

        private string numeroEntrada = "";
        public string NumeroEntrada { set { numeroEntrada = value; } get { return numeroEntrada; } }

        private string codSolicitud = "";
        public string CodSolicitud { set { codSolicitud = value; } get { return codSolicitud; } }

        private string codSucursal = "";
        public string CodSucursal { set { codSucursal = value; } get { return codSucursal; } }

        private string codigoModalidad = "";
        private float duracionModelo = 0;
        private List<string> tabsPermitidos = new List<string>();


        private void ocultarBoton(Control control, bool estado)
        {
            if (estado)
            {
                if (ribbonBar1.Controls.Contains(control))
                    ribbonBar1.Controls.Remove(control);
            }
            else
            {
                if (!ribbonBar1.Controls.Contains(control))
                    ribbonBar1.Controls.Add(control);
            }
        }

        /// <summary>
        /// Ocultar Botones 
        /// </summary>
        /// <param name="estado">los muestra o no</param>
        private void ocultarBotones(bool estado)
        {
            ocultarBoton(btnAceptar, estado);
            ocultarBoton(btnAnular, estado);
            ocultarBoton(btnGuardar, estado);
            ocultarBoton(btnImprimir, estado);
            ocultarBoton(btnReabrirOrden, estado);
            ocultarBoton(btnAprobarOrden, estado);
            ocultarBoton(btnCerrarOrden, estado);
        }

        private void cargarPermisos()
        {
            per_programaOrden = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1060);
            per_reasignaOrden = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1065);
            per_cierraOrden = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1023);
            per_apruebaOrden = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1014);
            per_anulaOrden = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1011);
            per_realizaOrden = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1063);
            per_modificaOrden = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1052);
        }


        private bool verPermisoxTab(string textoTab)
        {
            return tabsPermitidos.Contains(textoTab);
        }

        /// <summary>
        /// Esta funcion permite que todos los controles sean editables esta se invoca antes de ajustarcontroles automaticamente
        /// </summary>
        private void resetearControles()
        {
            #region Informacion General
            rdInterna.Enabled = true;
            rdOrdenExterna.Enabled = true;
            txtSerial.ReadOnly = false;
            btnBuscarSerial.Enabled = true;
            cmbTipoServicio.Enabled = true;
            cmbPrioridad.Enabled = true;
            calInicioProg.Enabled = true;
            calFinProg.Enabled = true;
            btnConsultarDisponib.Enabled = true;
            cmbIngeniero.Enabled = true;
            btnLimpiarIngeniero.Enabled = true;
            txtObservacionesIniciales.ReadOnly = false;
            #endregion
            #region Informacion Adicional.
            btnCambiarInformacionAceptacionCliente.Enabled = true;
            btnReasignar.Enabled = true;
            #endregion
            #region Actividades Realizadas
            txtFallasReportadas.ReadOnly = false;
            txtDiagnostico.ReadOnly = false;
            txtObservacionesIngeniero.ReadOnly = false;
            btnAgregarActividad.Enabled = true;
            btnModificarActividad.Enabled = true;
            btnEliminarActividad.Enabled = true;

            btnAgregarRepuesto.Enabled = true;
            btnModificarRepuesto.Enabled = true;
            btnQuitarRepuesto.Enabled = true;
            #endregion
            #region Archivos Asociados
            btnSubirArchivo.Enabled = true;
            btnVerArchivo.Enabled = true;
            btnGuardarArchivo.Enabled = true;
            btnQuitarArchivo.Enabled = true;
            #endregion
            #region Comprobantes de Aceptacion
            btnAgregarComprobante.Enabled = true;
            btnVerComprobante.Enabled = true;
            btnGuardarComprobante.Enabled = true;
            btnQuitarComprobante.Enabled = true;
            #endregion
            #region solicitud Insumos

            btnActualizarSolicitudes.Enabled = true;
            btnAgregarInsumos.Enabled = true;
            btnModifcarSolicitud.Enabled = true;
            btnEliminarSolicitud.Enabled = true;
            #endregion
            #region Ordenes Prestamo
            btnActualizarOrdenPrestamo.Enabled = true;
            btnSolicitarOrdenPrestamo.Enabled = true;
            btnModificarOrdenPrestamo.Enabled = true;
            btnEliminarOrdenPrestamo.Enabled = true;
            #endregion
        }

        /// <summary>
        /// Esta funcion habilita y deshabilita los controles que se pueden o no modificar, incluyendo los botones segundarios
        /// cada uno de estos botonoes se habilitan o deshabilitan dependiendo los permisos del usuario y el estado de la orden de servicio
        /// </summary>
        private void ajustarControles()
        {
            resetearControles();
            string est = cmbEstado.SelectedValue.ToString().Trim().ToUpper();
            #region Estado Nueva
            if (est == "NUEVA")
            {
                if (!per_programaOrden)
                {
                    grpIngeniero.Visible = false;

                    grpFecha.Visible = false;
                }
            }
            #endregion
            #region Estado PROGRAMADA
            else if (est == "PROGR")
            {
                if (per_modificaOrden) return;

                #region Informacion General
                rdInterna.Enabled = false;
                rdOrdenExterna.Enabled = false;
                txtSerial.ReadOnly = true;
                btnBuscarSerial.Enabled = false;
                cmbTipoServicio.Enabled = false;
                cmbPrioridad.Enabled = false;
                calInicioProg.Enabled = false;
                calFinProg.Enabled = false;
                cmbIngeniero.Enabled = false;
                btnLimpiarIngeniero.Enabled = false;
                txtObservacionesIniciales.ReadOnly = true;
                #endregion
                #region Informacion Adicional.
                if (!per_apruebaOrden)
                {
                    btnCambiarInformacionAceptacionCliente.Enabled = false;
                }
                if (!per_reasignaOrden)
                {
                    btnReasignar.Enabled = false;
                }
                #endregion
                //si no es el ingeniero asignado no puede modificar nada
                if (SPXSeguridad.logica.sesion.LoginUsuarioAutenticado.Trim() != cmbIngeniero.SelectedValue.ToString().Trim())
                {
                    #region Actividades Realizadas
                    txtFallasReportadas.ReadOnly = true;
                    txtDiagnostico.ReadOnly = true;
                    txtObservacionesIngeniero.ReadOnly = true;
                    btnAgregarActividad.Enabled = false;
                    btnModificarActividad.Enabled = false;
                    btnEliminarActividad.Enabled = false;
                    btnAgregarRepuesto.Enabled = false;
                    btnModificarRepuesto.Enabled = false;
                    btnQuitarRepuesto.Enabled = false;
                    #endregion
                    #region Archivos Asociados
                    btnSubirArchivo.Enabled = false;
                   // btnVerArchivo.Enabled = false;
                   // btnGuardarArchivo.Enabled = false;
                    btnQuitarArchivo.Enabled = false;
                    #endregion
                    #region Comprobantes de Aceptacion
                    btnAgregarComprobante.Enabled = false;
                    btnVerComprobante.Enabled = false;
                    btnGuardarComprobante.Enabled = false;
                    btnQuitarComprobante.Enabled = false;
                    #endregion
                    #region solicitud Insumos

                    btnActualizarSolicitudes.Enabled = false;
                    btnAgregarInsumos.Enabled = false;
                    btnModifcarSolicitud.Enabled = false;
                    btnEliminarSolicitud.Enabled = false;
                    #endregion
                    #region Ordenes Prestamo
                    btnActualizarOrdenPrestamo.Enabled = false;
                    btnSolicitarOrdenPrestamo.Enabled = false;
                    btnModificarOrdenPrestamo.Enabled = false;
                    btnEliminarOrdenPrestamo.Enabled = false;
                    #endregion
                }
            }
            #endregion
            #region Estado EN EJECUCION
            else if (est == "EJECU")
            {
                if (per_modificaOrden) return;

                #region Informacion General
                rdInterna.Enabled = false;
                rdOrdenExterna.Enabled = false;
                txtSerial.ReadOnly = true;
                btnBuscarSerial.Enabled = false;
                cmbTipoServicio.Enabled = false;
                cmbPrioridad.Enabled = false;
                calInicioProg.Enabled = false;
                btnConsultarDisponib.Enabled = false;
                calFinProg.Enabled = false;
                cmbIngeniero.Enabled = false;
                btnLimpiarIngeniero.Enabled = false;
                txtObservacionesIniciales.ReadOnly = true;
                #endregion
                #region Informacion Adicional.
                if (!per_apruebaOrden)
                {
                    btnCambiarInformacionAceptacionCliente.Enabled = false;
                }
                if (!per_reasignaOrden)
                {
                    btnReasignar.Enabled = false;
                }
                #endregion
                //si no es el ingeniero asignado no puede modificar nada
                if (SPXSeguridad.logica.sesion.LoginUsuarioAutenticado.Trim() != cmbIngeniero.SelectedValue.ToString().Trim())
                {
                    #region Actividades Realizadas
                    txtFallasReportadas.ReadOnly = true;
                    txtDiagnostico.ReadOnly = true;
                    txtObservacionesIngeniero.ReadOnly = true;
                    btnAgregarActividad.Enabled = false;
                    btnModificarActividad.Enabled = false;
                    btnEliminarActividad.Enabled = false;
                    btnAgregarRepuesto.Enabled = false;
                    btnModificarRepuesto.Enabled = false;
                    btnQuitarRepuesto.Enabled = false;
                    #endregion
                    #region Archivos Asociados
                    btnSubirArchivo.Enabled = false;
                    btnVerArchivo.Enabled = false;
                    btnGuardarArchivo.Enabled = false;
                    btnQuitarArchivo.Enabled = false;
                    #endregion
                    #region Comprobantes de Aceptacion
                    btnAgregarComprobante.Enabled = false;
                    btnVerComprobante.Enabled = false;
                    btnGuardarComprobante.Enabled = false;
                    btnQuitarComprobante.Enabled = false;
                    #endregion
                    #region solicitud Insumos

                    btnActualizarSolicitudes.Enabled = false;
                    btnAgregarInsumos.Enabled = false;
                    btnModifcarSolicitud.Enabled = false;
                    btnEliminarSolicitud.Enabled = false;
                    #endregion
                    #region Ordenes Prestamo
                    btnActualizarOrdenPrestamo.Enabled = false;
                    btnSolicitarOrdenPrestamo.Enabled = false;
                    btnModificarOrdenPrestamo.Enabled = false;
                    btnEliminarOrdenPrestamo.Enabled = false;
                    #endregion
                }


            }
            #endregion
            #region Estado EN ESPERA
            else if (est == "ENESP")
            {
                if (per_modificaOrden) return;

                #region Informacion General
                rdInterna.Enabled = false;
                rdOrdenExterna.Enabled = false;
                txtSerial.ReadOnly = true;
                btnBuscarSerial.Enabled = false;
                cmbTipoServicio.Enabled = false;
                cmbPrioridad.Enabled = false;
                calInicioProg.Enabled = false;
                calFinProg.Enabled = false;
                btnConsultarDisponib.Enabled = false;
                cmbIngeniero.Enabled = false;
                btnLimpiarIngeniero.Enabled = false;
                txtObservacionesIniciales.ReadOnly = true;
                #endregion
                #region Informacion Adicional.
                if (!per_apruebaOrden)
                {
                    btnCambiarInformacionAceptacionCliente.Enabled = false;
                }
                if (!per_reasignaOrden)
                {
                    btnReasignar.Enabled = false;
                }
                #endregion
                //si no es el ingeniero asignado no puede modificar nada
                //se mira la configuracion x defecto que dice que si cuando una orden esta en estado de espera se puede modificar o no.
                SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter objDef = new SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter();
                objDef.Fill(dsSpx1.defaults);
                if (SPXSeguridad.logica.sesion.LoginUsuarioAutenticado.Trim() != cmbIngeniero.SelectedValue.ToString().Trim()
                    || !dsSpx1.defaults[0].modificaOrden_Insumosabierta)
                {
                    #region Actividades Realizadas
                    txtFallasReportadas.ReadOnly = true;
                    txtDiagnostico.ReadOnly = true;
                    txtObservacionesIngeniero.ReadOnly = true;
                    btnAgregarActividad.Enabled = false;
                    btnModificarActividad.Enabled = false;
                    btnEliminarActividad.Enabled = false;
                    btnAgregarRepuesto.Enabled = false;
                    btnModificarRepuesto.Enabled = false;
                    btnQuitarRepuesto.Enabled = false;
                    #endregion
                    #region Archivos Asociados
                    btnSubirArchivo.Enabled = false;
                    btnVerArchivo.Enabled = false;
                    btnGuardarArchivo.Enabled = false;
                    btnQuitarArchivo.Enabled = false;
                    #endregion
                    #region Comprobantes de Aceptacion
                    btnAgregarComprobante.Enabled = false;
                    btnVerComprobante.Enabled = false;
                    btnGuardarComprobante.Enabled = false;
                    btnQuitarComprobante.Enabled = false;
                    #endregion
                    #region solicitud Insumos

                    btnActualizarSolicitudes.Enabled = false;
                    btnAgregarInsumos.Enabled = false;
                    btnModifcarSolicitud.Enabled = false;
                    btnEliminarSolicitud.Enabled = false;
                    #endregion
                    #region Ordenes Prestamo
                    btnActualizarOrdenPrestamo.Enabled = false;
                    btnSolicitarOrdenPrestamo.Enabled = false;
                    btnModificarOrdenPrestamo.Enabled = false;
                    btnEliminarOrdenPrestamo.Enabled = false;
                    #endregion
                }
            }
            #endregion
            #region Estado CERRADA
            else if (est == "CERRA")
            {
                if (per_modificaOrden) return;
                #region Informacion General
                calMantenimientoxUsuario.Enabled = false;
                rdManteimientoIndicadoNo.Enabled = false;
                rdAdecuado.Enabled = false;
                rdAdecuadoNo.Enabled = false;
                rdMantemientoIndicado.Enabled = false;
                rdInterna.Enabled = false;
                rdOrdenExterna.Enabled = false;
                txtSerial.ReadOnly = true;
                btnBuscarSerial.Enabled = false;
                cmbTipoServicio.Enabled = false;
                cmbPrioridad.Enabled = false;
                calInicioProg.Enabled = false;
                calFinProg.Enabled = false;
                btnConsultarDisponib.Enabled = false;
                cmbIngeniero.Enabled = false;
                btnLimpiarIngeniero.Enabled = false;
                txtObservacionesIniciales.ReadOnly = true;
                #endregion
                #region Informacion Adicional.
                btnCambiarInformacionAceptacionCliente.Enabled = false;
                btnReasignar.Enabled = false;
                #endregion
                #region Actividades Realizadas
                txtFallasReportadas.ReadOnly = true;
                txtDiagnostico.ReadOnly = true;
                txtObservacionesIngeniero.ReadOnly = true;
                btnAgregarActividad.Enabled = false;
                btnModificarActividad.Enabled = false;
                btnEliminarActividad.Enabled = false;
                btnAgregarRepuesto.Enabled = false;
                btnModificarRepuesto.Enabled = false;
                btnQuitarRepuesto.Enabled = false;
                #endregion
                #region Archivos Asociados
                btnSubirArchivo.Enabled = false;
                btnVerArchivo.Enabled = false;
                btnGuardarArchivo.Enabled = false;
                btnQuitarArchivo.Enabled = false;
                #endregion
                #region Comprobantes de Aceptacion
                btnAgregarComprobante.Enabled = false;
                btnVerComprobante.Enabled = false;
                btnGuardarComprobante.Enabled = false;
                btnQuitarComprobante.Enabled = false;
                #endregion
                #region solicitud Insumos

                btnActualizarSolicitudes.Enabled = false;
                btnAgregarInsumos.Enabled = false;
                btnModifcarSolicitud.Enabled = false;
                btnEliminarSolicitud.Enabled = false;
                #endregion
                #region Ordenes Prestamo
                btnActualizarOrdenPrestamo.Enabled = false;
                btnSolicitarOrdenPrestamo.Enabled = false;
                btnModificarOrdenPrestamo.Enabled = false;
                btnEliminarOrdenPrestamo.Enabled = false;
                #endregion
            }
            #endregion
            #region Estado APROBADA
            else if (est == "APROB")
            {
                if (per_modificaOrden) return;
                calMantenimientoxUsuario.Enabled = false;
                rdManteimientoIndicadoNo.Enabled = false;
                rdAdecuado.Enabled = false;
                rdAdecuadoNo.Enabled = false;
                rdMantemientoIndicado.Enabled = false;
                #region Informacion General
                rdInterna.Enabled = false;
                rdOrdenExterna.Enabled = false;
                txtSerial.ReadOnly = true;
                btnBuscarSerial.Enabled = false;
                cmbTipoServicio.Enabled = false;
                cmbPrioridad.Enabled = false;
                calInicioProg.Enabled = false;
                calFinProg.Enabled = false;
                btnConsultarDisponib.Enabled = true;
                cmbIngeniero.Enabled = false;
                btnLimpiarIngeniero.Enabled = false;
                txtObservacionesIniciales.ReadOnly = true;
                #endregion
                #region Informacion Adicional.
                btnCambiarInformacionAceptacionCliente.Enabled = false;
                btnReasignar.Enabled = false;
                #endregion
                #region Actividades Realizadas
                txtFallasReportadas.ReadOnly = true;
                txtDiagnostico.ReadOnly = true;
                txtObservacionesIngeniero.ReadOnly = true;
                btnAgregarActividad.Enabled = false;
                btnModificarActividad.Enabled = false;
                btnEliminarActividad.Enabled = false;
                btnAgregarRepuesto.Enabled = false;
                btnModificarRepuesto.Enabled = false;
                btnQuitarRepuesto.Enabled = false;
                #endregion
                #region Archivos Asociados
                btnSubirArchivo.Enabled = false;
                btnVerArchivo.Enabled = false;
                btnGuardarArchivo.Enabled = false;
                btnQuitarArchivo.Enabled = false;
                #endregion
                #region Comprobantes de Aceptacion
                btnAgregarComprobante.Enabled = false;
                btnVerComprobante.Enabled = false;
                btnGuardarComprobante.Enabled = false;
                btnQuitarComprobante.Enabled = false;
                #endregion
                #region solicitud Insumos

                btnActualizarSolicitudes.Enabled = false;
                btnAgregarInsumos.Enabled = false;
                btnModifcarSolicitud.Enabled = false;
                btnEliminarSolicitud.Enabled = false;
                #endregion
                #region Ordenes Prestamo
                btnActualizarOrdenPrestamo.Enabled = false;
                btnSolicitarOrdenPrestamo.Enabled = false;
                btnModificarOrdenPrestamo.Enabled = false;
                btnEliminarOrdenPrestamo.Enabled = false;
                #endregion
            }
            #endregion
            #region Estado ANULADA
            else if (est == "ANULA")
            {
                calMantenimientoxUsuario.Enabled = false;
                rdManteimientoIndicadoNo.Enabled = false;
                rdAdecuado.Enabled = false;
                rdAdecuadoNo.Enabled = false;
                rdMantemientoIndicado.Enabled = false;
                //SI ESTA ANULADA NO MODIFICA NINGUN CAMPO NI ADICIONA NADA A LA ORDEN
                //SIN IMPORTAR LOS PERMISOS.
                if (per_modificaOrden) return;//este permiso permite modificar las ordenes en cualquier estado.
                #region Informacion General
                rdInterna.Enabled = false;
                rdOrdenExterna.Enabled = false;
                txtSerial.ReadOnly = true;
                btnBuscarSerial.Enabled = false;
                cmbTipoServicio.Enabled = false;
                cmbPrioridad.Enabled = false;
                calInicioProg.Enabled = false;
                calFinProg.Enabled = false;
                btnConsultarDisponib.Enabled = false;
                cmbIngeniero.Enabled = false;
                btnLimpiarIngeniero.Enabled = false;
                txtObservacionesIniciales.ReadOnly = true;
                #endregion
                #region Informacion Adicional.
                btnCambiarInformacionAceptacionCliente.Enabled = false;
                btnReasignar.Enabled = false;
                #endregion
                #region Actividades Realizadas
                txtFallasReportadas.ReadOnly = true;
                txtDiagnostico.ReadOnly = true;
                txtObservacionesIngeniero.ReadOnly = true;
                btnAgregarActividad.Enabled = false;
                btnModificarActividad.Enabled = false;
                btnEliminarActividad.Enabled = false;
                btnAgregarRepuesto.Enabled = false;
                btnModificarRepuesto.Enabled = false;
                btnQuitarRepuesto.Enabled = false;
                #endregion
                #region Archivos Asociados
                btnSubirArchivo.Enabled = false;
                btnVerArchivo.Enabled = false;
                btnGuardarArchivo.Enabled = false;
                btnQuitarArchivo.Enabled = false;
                #endregion
                #region Comprobantes de Aceptacion
                btnAgregarComprobante.Enabled = false;
                btnVerComprobante.Enabled = false;
                btnGuardarComprobante.Enabled = false;
                btnQuitarComprobante.Enabled = false;
                #endregion
                #region solicitud Insumos

                btnActualizarSolicitudes.Enabled = false;
                btnAgregarInsumos.Enabled = false;
                btnModifcarSolicitud.Enabled = false;
                btnEliminarSolicitud.Enabled = false;
                #endregion
                #region Ordenes Prestamo
                btnActualizarOrdenPrestamo.Enabled = false;
                btnSolicitarOrdenPrestamo.Enabled = false;
                btnModificarOrdenPrestamo.Enabled = false;
                btnEliminarOrdenPrestamo.Enabled = false;
                #endregion
            }
            #endregion
        }

        /// <summary>
        /// ajusta los botones principales  de acuerdo a los permisos y estado de la orden de servicio
        /// </summary>
        private void ajustarBotones()
        {
            reiniciarBotones();
            //ajustamos primero los tabs 
            tabsPermitidos.Clear();
            for (int k = 0; k < tabControl1.Tabs.Count; k++)
            {
                tabsPermitidos.Add(tabControl1.Tabs[k].Text.Trim());
            }
            //verificamos el estado de la orden de trabajo
            #region si es nueva
            if (codOrdenServicio.Trim() == string.Empty)
            {
                tabsPermitidos.Remove("Informacion Adicional");
                tabsPermitidos.Remove("Actividades Realizadas");
                tabsPermitidos.Remove("Archivos Asociados");
                tabsPermitidos.Remove("Comprobantes de Aceptacion");
                tabsPermitidos.Remove("Solicitud de Insumos");
                tabsPermitidos.Remove("Ordenes de Prestamo");
                ocultarBotones(true);
                ocultarBoton(btnGuardar, false);
                if (!per_programaOrden)
                {
                    grpIngeniero.Visible = false;
                    grpFecha.Visible = false;
                }
            }
            #endregion
            //si no es nueva ya debe tener la informacion en el dataset
            if (dsSpx1.ordenServicio.Rows.Count <= 0) return;
            string estado = dsSpx1.ordenServicio[0].codEstadoOrdenServicio.Trim().ToUpper();
            #region zona programada
            if (estado == "PROGR")
            {
                ocultarBotones(true);
                ocultarBoton(btnGuardar, false);
                ocultarBoton(btnImprimir, false);

                if (per_anulaOrden)
                {
                    ocultarBoton(btnAnular, false);
                }
                if (per_cierraOrden || SPXSeguridad.logica.sesion.LoginUsuarioAutenticado.Trim() == cmbIngeniero.SelectedValue.ToString().Trim())
                {
                    ocultarBoton(btnCerrarOrden, false);
                }
            }
            #endregion
            #region en ejecucion
            else if (estado == "EJECU")
            {
                ocultarBotones(true);
                ocultarBoton(btnGuardar, false);
                ocultarBoton(btnImprimir, false);
                if (per_anulaOrden)
                {
                    ocultarBoton(btnAnular, false);
                }
                if (per_cierraOrden || SPXSeguridad.logica.sesion.LoginUsuarioAutenticado.Trim() == cmbIngeniero.SelectedValue.ToString().Trim())
                {
                    ocultarBoton(btnCerrarOrden, false);
                }
            }
            #endregion
            #region en espera
            else if (estado == "ENESP")
            {
                ocultarBotones(true);
                ocultarBoton(btnGuardar, false);
                ocultarBoton(btnImprimir, false);
                if (per_anulaOrden)
                {
                    ocultarBoton(btnAnular, false);
                }
                if (per_cierraOrden || SPXSeguridad.logica.sesion.LoginUsuarioAutenticado.Trim() == cmbIngeniero.SelectedValue.ToString().Trim())
                {
                    ocultarBoton(btnCerrarOrden, false);
                }
            }
            #endregion
            #region cerrada
            else if (estado == "CERRA")
            {
                ocultarBotones(true);
                ocultarBoton(btnImprimir, false);
                if (per_modificaOrden)
                {
                    ocultarBoton(btnGuardar, false);

                }
                if (per_anulaOrden)
                {
                    ocultarBoton(btnAnular, false);
                }
                if (per_apruebaOrden)
                {
                    ocultarBoton(btnReabrirOrden, false);
                    ocultarBoton(btnAprobarOrden, false);
                }
                //si el mismo la cerro puede reabrirla
                if (SPXSeguridad.logica.sesion.LoginUsuarioAutenticado.Trim() == cmbIngeniero.SelectedValue.ToString().Trim())
                {
                    ocultarBoton(btnReabrirOrden, false);
                }
            }
            #endregion
            #region aprobada
            else if (estado == "APROB")
            {
                ocultarBotones(true);

                ocultarBoton(btnImprimir, false);
                if (per_modificaOrden)
                {
                    ocultarBoton(btnGuardar, false);
                }
                if (per_anulaOrden)
                {
                    ocultarBoton(btnAnular, false);
                }
            }
            #endregion
            #region zona anulada
            else if (estado == "ANULA")
            {
                ocultarBotones(true);
                ocultarBoton(btnImprimir, false);
                if (per_modificaOrden)
                {
                    ocultarBoton(btnGuardar, false);
                }
            }
            #endregion
        }

        private void reiniciarBotones()
        {
            grpIngeniero.Visible = true;
            grpFecha.Visible = true;
            cmbIngeniero.Enabled = true;
        }

        private void AsignarfechaProgramacion(DateTime fecha)
        {
            #region se carga la fecha de programacion a lso controles
            calInicioProg.fechaValue = fecha;
            #endregion

        }

        /// <summary>
        /// Este metodo toma la informacion que esta en el dataset y la pasa a los controles.
        /// </summary>
        private void cargarDatos(string tab)
        {
            if (this.CodOrdenServicio == "0") return;
            //carga los datos dependiendo cual es el tab activo
            ordenServicioTableAdapter1.FillByCodOrdenServicio(dsSpx1.ordenServicio, int.Parse(codOrdenServicio));
            //se verifica si la orden de servicio debe quedar en espera al tener activa una orden de prestamo o una solicitud de repuestos
            if (actualizarEstadosEnEspera())
            {
                ordenServicioTableAdapter1.FillByCodOrdenServicio(dsSpx1.ordenServicio, int.Parse(codOrdenServicio));
            }
            string valor = tab;
            if (!dsSpx1.ordenServicio[0].IsmantenimientoSegunIndicacionesNull())
            {
                rdMantemientoIndicado.Checked = dsSpx1.ordenServicio[0].mantenimientoSegunIndicaciones;
                rdManteimientoIndicadoNo.Checked = !dsSpx1.ordenServicio[0].mantenimientoSegunIndicaciones;
            }

            if (!dsSpx1.ordenServicio[0].Isequipo_adecuadoNull())
            {
                rdAdecuado.Checked = dsSpx1.ordenServicio[0].equipo_adecuado;
                rdAdecuadoNo.Checked = !dsSpx1.ordenServicio[0].equipo_adecuado;
            }
            if (!dsSpx1.ordenServicio[0].IsfechaUltimoMantenimientoxUsuarioNull())
            {
                calMantenimientoxUsuario.Value = dsSpx1.ordenServicio[0].fechaUltimoMantenimientoxUsuario;
            }
            switch (valor.ToLower())
            {
                case "informacion general":
                    {
                        #region Informacion General
                        txtSerial.Text = dsSpx1.ordenServicio[0].serial.Trim();
                        cargarserial(txtSerial.Text);
                        if (!dsSpx1.ordenServicio[0].IsasignadoANull())
                        {
                            cmbIngeniero.SelectedValue = dsSpx1.ordenServicio[0].asignadoA.Trim();
                            //cuando el usuario fue deshabilitado no lo muestra en el combo para este caso se debe mostrar el nombre
                            //y dejarlo inmodificacble
                            if (cmbIngeniero.SelectedValue == null || cmbIngeniero.SelectedValue.ToString().Trim() == string.Empty)
                            {
                                SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
                                dsSPXSeguridad1.usuario.Merge(objData.ejecutarConsulta("select * from usuario where login = '" + dsSpx1.ordenServicio[0].asignadoA+ "' ").Tables[0]);
                                cmbIngeniero.SelectedValue = dsSpx1.ordenServicio[0].asignadoA.Trim();
                                cmbIngeniero.Enabled       = false;
                            }
                        }else{
                            cmbIngeniero.SelectedValue = "";
                            lblIngeniero.Text = "";
                        }
                        rdInterna.Checked = dsSpx1.ordenServicio[0].esInterno;
                        rdOrdenExterna.Checked = !dsSpx1.ordenServicio[0].esInterno;
                        if (rdInterna.Checked)
                        {
                            txtSerial.ReadOnly = true;
                            btnBuscarSerial.Enabled = false;
                            cmbTipoServicio.Enabled = false;
                        }
                      
                        txtObservacionesIniciales.Text = dsSpx1.ordenServicio[0].observaciones;
                        txtDiagnostico.Text = dsSpx1.ordenServicio[0].diagnostico;
                        txtObservacionesIngeniero.Text = dsSpx1.ordenServicio[0].observacionesIngeniero;
                        txtFallasReportadas.Text = dsSpx1.ordenServicio[0].fallasReportadas;

                        txtNumeroEntrada.Text = (dsSpx1.ordenServicio[0].IsnumEntradaNull() || dsSpx1.ordenServicio[0].numEntrada == 0) ? "" : dsSpx1.ordenServicio[0].numEntrada.ToString();

                        if (!dsSpx1.ordenServicio[0].IsfechaProgramacionNull())
                        {
                            #region se carga la fecha de programacion
                            calInicioProg.fechaValue =dsSpx1.ordenServicio[0].fechaProgramacion;
                            calFinProg.fechaValue = dsSpx1.ordenServicio[0].fechaFinProgramacion;
                            
                            #endregion
                        }
                        cmbTipoServicio.SelectedValue = dsSpx1.ordenServicio[0].codTiposervicio;
                        if (!dsSpx1.ordenServicio[0].IsporContratoNull())
                        {
                            rdContratoSi.Checked = dsSpx1.ordenServicio[0].porContrato;
                            rdContratoNo.Checked = !dsSpx1.ordenServicio[0].porContrato;
                            grpPorContrato.Enabled = false;
                            if (!dsSpx1.ordenServicio[0].IsnumeroContratoNull())
                            txtNumeroContrato.Text = dsSpx1.ordenServicio[0].numeroContrato;
                        }
                        cmbPrioridad.SelectedValue = dsSpx1.ordenServicio[0].codPrioridadOS;
                        cmbEstado.SelectedValue = dsSpx1.ordenServicio[0].codEstadoOrdenServicio;
                        txtNumeroOrdenServicio.Text = codOrdenServicio;
                        if (!dsSpx1.ordenServicio[0].IscodAsesorNull()) cmbAsesorComercial.SelectedValue = dsSpx1.ordenServicio[0].codAsesor;
                        #endregion
                        break;
                    }
                case "informacion adicional":
                    {
                        #region informacion adicional
                        SPXSeguridad.data.dsSPXSeguridad ds = new SPXSeguridad.data.dsSPXSeguridad();  
                        calAnulacion.ValueObject = null;
                        txtAnuladaPor.Text = "";
                        calAprobacion.ValueObject = null;
                        txtAprobadaPor.Text = "";
                        calCierre.ValueObject = null;
                        txtCerradaPor.Text = "";
                        calFechaProgramacionIA.ValueObject = null;
                        calFechaCreacion.ValueObject = null;
                        txtCreadaPor.Text = "";

                        if (!dsSpx1.ordenServicio[0].IsfechaCreacionNull())
                        {
                            calFechaCreacion.Value = dsSpx1.ordenServicio[0].fechaCreacion;
                            clsTusuario1.FillBylogin(ds.usuario, dsSpx1.ordenServicio[0].creadaPor);
                            txtCreadaPor.Text = ds.usuario[0].nombre ;
                        }
                        if (!dsSpx1.ordenServicio[0].IsfechaProgramacionNull())
                        {
                            calFechaProgramacionIA.Value = dsSpx1.ordenServicio[0].fechaProgramacion;
                            calFechaFinProgramacionIA.Value = dsSpx1.ordenServicio[0].fechaFinProgramacion;
                        }
                        if (!dsSpx1.ordenServicio[0].IsfechaCierreNull())
                        {
                            calCierre.Value = dsSpx1.ordenServicio[0].fechaCierre;
                            if (!dsSpx1.ordenServicio[0].IscerradaPorNull())
                            {
                                clsTusuario1.FillBylogin(ds.usuario, dsSpx1.ordenServicio[0].cerradaPor);
                                txtCerradaPor.Text = ds.usuario[0].nombre;
                            }
                        }
                        if (!dsSpx1.ordenServicio[0].IsfechaAprobacionNull())
                        {
                            calAprobacion.Value = dsSpx1.ordenServicio[0].fechaAprobacion;
                            clsTusuario1.FillBylogin(ds.usuario, dsSpx1.ordenServicio[0].aprobadaPor);
                            txtAprobadaPor.Text = ds.usuario[0].nombre;
                        }
                        if (!dsSpx1.ordenServicio[0].IsfechaAnulacionNull())
                        {
                            calAnulacion.Value = dsSpx1.ordenServicio[0].fechaAnulacion;
                            clsTusuario1.FillBylogin(ds.usuario, dsSpx1.ordenServicio[0].anuladaPor);
                            txtAnuladaPor.Text = ds.usuario[0].nombre;
                        }

                        reasignacionOrdenesTrabajoTableAdapter1.FillByCodOrdenServicio(dsSpx1.reasignacionOrdenesTrabajo, int.Parse(codOrdenServicio));
                        #endregion

                        break;
                    }
                case "actividades realizadas":
                    {
                        #region actividades realizadas
                        txtFallasReportadas.Text = dsSpx1.ordenServicio[0].fallasReportadas;
                        txtDiagnostico.Text = dsSpx1.ordenServicio[0].diagnostico;
                        txtObservacionesIngeniero.Text = dsSpx1.ordenServicio[0].observacionesIngeniero;
                        actividadxordenServicioTableAdapter1.FillBycodOrdenServicio(dsSpx1.actividadxordenServicio, int.Parse(codOrdenServicio));
                        pltRepuestosxOrdenServicioTableAdapter1.FillByCodOrdenServicio(dsPlantillas1.pltRepuestosxOrdenServicio, int.Parse(codOrdenServicio));

                        #endregion
                        cargarEquiposMedicionxOrdenServicio();
                        pltVariablesxOrdenServicioTableAdapter1.FillByCodOrdenServicio(dsPlantillas1.pltVariablesxOrdenServicio, int.Parse(codOrdenServicio));
                        break;
                    }
                case "archivos asociados":
                    {
                        archivosXOrdenServicioTableAdapter1.FillByCodOrdenServicio(dsSpx1.archivosXOrdenServicio, int.Parse(codOrdenServicio));
                        break;
                    }
                case "comprobantes de aceptacion":
                    {
                        if (!dsSpx1.ordenServicio[0].IsnombreUsuarioClienteNull())
                        {
                            txtUsuarioCliente.Text = dsSpx1.ordenServicio[0].nombreUsuarioCliente;
                            //el FORMATO ES 12:54 PM
                            string entrada = dsSpx1.ordenServicio[0].horaEntradaControl;
                            string salida = dsSpx1.ordenServicio[0].horaSalidaControl;
                            if (entrada.Trim() != string.Empty)
                            {
                                cmbHoraLlegadaCliente.Text = entrada.Substring(0, entrada.IndexOf(':'));
                                cmbMinutosLlegadaCliente.Text = entrada.Substring(entrada.IndexOf(':') + 1, 2);
                                cmbAmPmLlegadaCliente.Text = entrada.Substring(entrada.IndexOf(':') + 4, 2);
                            }
                            if (salida.Trim() != string.Empty)
                            {
                                cmbHoraSalidaCliente.Text = salida.Substring(0, salida.IndexOf(':'));
                                cmbMinSalidaCliente.Text = salida.Substring(salida.IndexOf(':') + 1, 2);
                                cmbAmPMSalidaCliente.Text = salida.Substring(salida.IndexOf(':') + 4, 2);
                            }
                        }
                        comprobantesAceptacionOrdenservicioTableAdapter1.FillByCodOrdenServicio(dsSpx1.comprobantesAceptacionOrdenservicio, int.Parse(codOrdenServicio));
                        break;
                    }
                case "solicitud de insumos":
                    {
                        solicitudInsumosTableAdapter1.FillByCodOrdenServicio(dsSpx1.solicitudInsumos, int.Parse(codOrdenServicio));
                        break;
                    }
                case "ordenes de prestamo":
                    {

                        pltOrdenPrestamoTableAdapter1.FillByCodOrdenServicio(dsPlantillas1.pltOrdenPrestamo, int.Parse(codOrdenServicio));

                        break;
                    }
            }


        }
        #endregion

        string codTipoEquipo = "";
        private void cargarTablas()
        {
            clsTusuario1.FillByPermiso(dsSPXSeguridad1.usuario, 1063);            
            tipoServicioTableAdapter1.Fill(dsSpx1.TipoServicio);
            prioridadesOrdenServicioTableAdapter1.Fill(dsSpx1.prioridadesOrdenServicio);
            estadosOrdenServicioTableAdapter1.Fill(dsSpx1.estadosOrdenServicio);
            asesoresComercialesTableAdapter1.Fill(dsSpx1.asesoresComerciales);
            cmbIngeniero.Text = "";
        }

        /// <summary>
        /// Esto me indica si el formulario se esta mostrando como un cuadro de dialogo que debe dar como respuesta
        /// una orden de servicio creada.
        /// </summary>
        public bool mostrarDialogo = false;

        private void frmNuevaOrdenTrabajo_Load(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            dsSpx1.EnforceConstraints = false;
            calAnulacion.MonthCalendar.DisplayMonth = n;
            calAprobacion.MonthCalendar.DisplayMonth = n;
            calCierre.MonthCalendar.DisplayMonth = n;
            calFechaCreacion.MonthCalendar.DisplayMonth = n;
            calFechaProgramacionIA.MonthCalendar.DisplayMonth = n;
            calFechaCreacion.MonthCalendar.DisplayMonth = n;
            calFechaProgramacionIA.MonthCalendar.DisplayMonth = n;
            calProximoMantenimiento.MonthCalendar.DisplayMonth = n;
            calUltimoMantenimiento.MonthCalendar.DisplayMonth = n;

            calInicioProg.fechaValueObject = null;
            calFinProg.fechaValueObject = null;

            cargarPermisos();
            cargarTablas();
            ajustarBotones();
            //miramos si es nueva
            if (codOrdenServicio.Trim() == string.Empty)
            {
                #region cuando es nueva
                txtNumeroOrdenServicio.Text = ordenServicioTableAdapter1.verNextId().Value.ToString();
                cmbEstado.SelectedValue = "NUEVA";
                cmbIngeniero.SelectedValue = "";
                lblIngeniero.Text = "";
                //miramos si fue enviada desde entrada y salida de equipos
                if (numeroEntrada.Trim() != string.Empty)
                {
                    txtNumeroEntrada.Text = numeroEntrada;
                    rdInterna.Checked = true;
                    rdInterna.Enabled = false;
                    rdOrdenExterna.Enabled = false;
                    //cargamos toda la informacion de la entrada
                    entradaSalidaEquiposTableAdapter1.FillBycodEntradaSalidaEquipos(dsSpx1.EntradaSalidaEquipos, int.Parse(numeroEntrada));
                    if (dsSpx1.EntradaSalidaEquipos.Rows.Count > 0)
                    {
                        #region cargamos la informacion de la entrada en la orde de servicio
                        cmbTipoServicio.SelectedValue = dsSpx1.EntradaSalidaEquipos[0].codTiposervicio;
                        cmbTipoServicio.Enabled = false;
                        txtSerial.Text = dsSpx1.EntradaSalidaEquipos[0].serial;
                        txtSerial.ReadOnly = true;
                        btnBuscarSerial.Enabled = false;
                        cargarserial(txtSerial.Text);
                        #endregion
                        txtObservacionesIniciales.Text = dsSpx1.EntradaSalidaEquipos[0].obsEntrada;
                    }
                }

                if (codSolicitud.Trim() != string.Empty)
                {
                    solicitudServicioTableAdapter1.FillBycodSolicitudServicio(dsSpx1.solicitudServicio, int.Parse(codSolicitud));
                    if (dsSpx1.solicitudServicio.Rows.Count > 0)
                    {
                        #region cargamos la informacion de la solicitud en la orden de servicio
                        cmbTipoServicio.SelectedValue = dsSpx1.solicitudServicio[0].codTipoServicio;
                        cmbTipoServicio.Enabled = false;
                        if (!dsSpx1.solicitudServicio[0].IscodAsesorNull())
                        cmbAsesorComercial.SelectedValue = dsSpx1.solicitudServicio[0].codAsesor;
                        txtSerial.Text = dsSpx1.solicitudServicio[0].serial;
                        txtSerial.ReadOnly = true;
                        btnBuscarSerial.Enabled = false;
                        btnBuscarSerial.Visible = false;
                        cargarserial(txtSerial.Text);
                        txtObservacionesIniciales.Text = dsSpx1.solicitudServicio[0].objetoServicio;
                        txtFallasReportadas.Text = dsSpx1.solicitudServicio[0].fallasReportadas;
                        //cargamos la fecha sugerida
                        AsignarfechaProgramacion(dsSpx1.solicitudServicio[0].fechaSugerida);
                        #endregion


                    }

                }
                #endregion
            }
            else
            {
                
                //cargamos toda la informacion de la base de datos
                
                cargarDatos(tabControl1.SelectedTab.Text);
                if (actualizarEstadosEnEspera())
                {
                    cargarDatos(tabControl1.SelectedTab.Text);
                }
                ajustarBotones();
                ajustarControles();
                //se deshabilita la opcion de cambiar el serial  ya que ese cambio genera muchas inconsistencias.
                btnBuscarSerial.Enabled = false;
            }

        }

        private void rdInterna_CheckedChanged(object sender, EventArgs e)
        {
            if (rdInterna.Checked)
            {
                prioridadesOrdenServicioTableAdapter1.FillByInternas(dsSpx1.prioridadesOrdenServicio);
            }
        }

        private void rdOrdenExterna_CheckedChanged(object sender, EventArgs e)
        {
            if (rdOrdenExterna.Checked)
            {
                txtNumeroEntrada.Text = "";
                cmbTipoServicio.Enabled = true;
                prioridadesOrdenServicioTableAdapter1.FillByExternas(dsSpx1.prioridadesOrdenServicio);
                txtSerial.Enabled = true;
                cmbTipoServicio.Enabled = true;
                btnBuscarSerial.Enabled = true;
                if (codSolicitud == string.Empty)
                {
                    txtObservacionesIniciales.Text = "";
                }
            }
        }

        private void rdInterna_Click(object sender, EventArgs e)
        {
            if (rdInterna.Checked && rdInterna.Enabled)
            {
                ESequipos.frmEntradasSalidasSinOrdenServicio frm = new ESequipos.frmEntradasSalidasSinOrdenServicio();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    txtNumeroEntrada.Text = frm.CodEntrada;
                    //traemos toda la informacion de la entrada
                    entradaSalidaEquiposTableAdapter1.FillBycodEntradaSalidaEquipos(dsSpx1.EntradaSalidaEquipos, int.Parse(frm.CodEntrada));
                    txtSerial.Text = dsSpx1.EntradaSalidaEquipos[0].serial;
                    txtSerial.Enabled = false;
                    cargarserial(txtSerial.Text);
                    cmbTipoServicio.SelectedValue = dsSpx1.EntradaSalidaEquipos[0].codTiposervicio;
                    btnBuscarSerial.Enabled = false;
                    cmbTipoServicio.Enabled = false;
                    txtObservacionesIniciales.Text = dsSpx1.EntradaSalidaEquipos[0].obsEntrada;
                }
            }
            else
            {
                txtSerial.Enabled = true;
                cmbTipoServicio.Enabled = true;
                btnBuscarSerial.Enabled = true;
            }
        }

        #region carga de serial e informacion de cliente
        private void btnBuscarSerial_Click(object sender, EventArgs e)
        {
            spProcesos.Equipos.frmBuscarEquipo fr = new spProcesos.Equipos.frmBuscarEquipo();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                txtSerial.Text = fr.Serial;
                txtSerial.Focus();
                cargarserial(txtSerial.Text);
            }
        }

        private bool cargarserial(string serial)
        {
            //miramos si existe el serial
            equiposTableAdapter1.FillBySerial(dsSpx1.equipos, serial);
            if (dsSpx1.equipos.Rows.Count <= 0)
            {
                MessageBox.Show("El equipo con serial " + serial.Trim() + " no existe en la base de datos.");
                return false;
            }
            if (!dsSpx1.equipos[0].IsfechaProximoManteNull())
                calProximoMantenimiento.Value = dsSpx1.equipos[0].fechaProximoMante;
            if (!dsSpx1.equipos[0].IsfechaUltimoManteNull())
                calUltimoMantenimiento.Value = dsSpx1.equipos[0].fechaUltimoMante;
            //
            fabricanteTableAdapter1.FillByCodfabricanteComboBox(dsSpx1.fabricante, dsSpx1.equipos[0].codFabricante.Trim());
            txtFabricante.Text = dsSpx1.fabricante[0].nombre_fabricante;
            //
            modelosTableAdapter1.FillByFabricanteModeloComboBox(dsSpx1.Modelos, dsSpx1.equipos[0].codFabricante.Trim(), dsSpx1.equipos[0].codModelo.Trim());
            txtModelo.Text = dsSpx1.Modelos[0].NombreModelo;

            codTipoEquipo= dsSpx1.Modelos[0].codTipoEquipo;


            //esto es para cargar la modalidad con el cual fue creada la orden de servicio si cambio de modadlidad no trae el actual si no el de ese entonces.
            codigoModalidad = "";
            if (dsSpx1.ordenServicio.Rows.Count <= 0 || dsSpx1.ordenServicio[0].serial != txtSerial.Text)
            {
                if (!dsSpx1.equipos[0].IscodModalidadEquipoNull())
                {
                    codigoModalidad = dsSpx1.equipos[0].codModalidadEquipo;
                    txtModalidad.Text = modalidadEquipoTableAdapter1.verNombreModadlidad(codigoModalidad).ToString();
                }
            }else{
                if (!dsSpx1.ordenServicio[0].IscodModalidadNull())
                {
                    codigoModalidad = dsSpx1.ordenServicio[0].codModalidad;
                    txtModalidad.Text = modalidadEquipoTableAdapter1.verNombreModadlidad(codigoModalidad).ToString();
                }
            }


            if (!dsSpx1.Modelos[0].IsduracionmantenimientoNull())
            {
                duracionModelo = (float)dsSpx1.Modelos[0].duracionmantenimiento;
            }
            else
            {
                duracionModelo = 0;
            }
            //esto es para cargar el cliente con el cual fue creada la orden de servicio si cambio no trae el actual si no el de ese entonces.
            string nitCliente = "";
            codSucursal = "";

            if (dsSpx1.ordenServicio.Rows.Count <= 0 || dsSpx1.ordenServicio[0].serial != txtSerial.Text)
            {
                nitCliente = dsSpx1.equipos[0].nitClienteUbica;
                codSucursal = dsSpx1.equipos[0].codSucursalUbica;
            }
            else
            {
                nitCliente = dsSpx1.ordenServicio[0].nitCliente;
                codSucursal = dsSpx1.ordenServicio[0].codSucursal;
            }
            clientesTableAdapter1.FillByNitCliente(dsSpx1.clientes, nitCliente);
            txtNitCliente.Text = dsSpx1.clientes[0].nitCliente;
            txtNombrecliente.Text = dsSpx1.clientes[0].nombreCliente;
             //informacion de la ubicacion

            sucursalClienteTableAdapter1.FillByCodSucursalNit(dsSpx1.sucursalCliente, nitCliente, codSucursal);
            txtSucursal.Text = dsSpx1.sucursalCliente[0].nombreSucursal;
           // calcularHoraFin(); //esto se quito por que este calculo se hace cuando se edita la informacion del calendario uno
            return true;
        }

        private void txtSerial_Validating(object sender, CancelEventArgs e)
        {
            if (txtSerial.Text.Trim() == string.Empty) return;
            e.Cancel = !cargarserial(txtSerial.Text);
            if (e.Cancel) txtSerial.Text = "";
        }

        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        #region zona de impresion de la orden de servicio

        private void imprimirOs(int opcion)
        {
            string ruta = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter objDef = new SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter();
            objDef.Fill(dsSpx1.defaults);
            string strReporte = "";
            switch (opcion)
            {
                case 1: { strReporte = "rptOrdenServicio"; break; }
                case 2: { strReporte = "rptReporteServicio"; break; }
                case 3: { strReporte = "rptOrdenCompleta"; break; }
            }

            C1.C1Report.C1Report reporte = new C1.C1Report.C1Report();
            reporte.Load(ruta + @"\rpt\rpt.xml", strReporte);
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            reporte.DataSource.ConnectionString = objData.CadenaConexionReportes;
            if (!dsSpx1.defaults[0].IslogotipoNull())
            {
                byte[] arr = (byte[])dsSpx1.defaults[0].logotipo;
                System.IO.Stream stream = new System.IO.MemoryStream(arr);
                Image im = Image.FromStream(stream);
                if (reporte.Fields.Contains("picLogo"))
                {
                    reporte.Fields["picLogo"].Picture = im;
                }
            }
            if (opcion != 2 && opcion != 3)
            {
                if (reporte.Fields.Contains("lblTitulo"))
                {
                    reporte.Fields["lblTitulo"].Value = dsSpx1.defaults[0].tituloOrdenServicio.Trim();
                }
                if (reporte.Fields.Contains("lblVersion"))
                {
                    reporte.Fields["lblVersion"].Value = dsSpx1.defaults[0].versionOrdenServicio.Trim();
                }
                if (reporte.Fields.Contains("lblTipoDocumento"))
                {
                    if (!dsSpx1.defaults[0].IscodigoOrdenServicioNull())
                        reporte.Fields["lblTipoDocumento"].Value = dsSpx1.defaults[0].codigoOrdenServicio.Trim();
                }
                if (reporte.Fields.Contains("lblVigencia"))
                {
                    if (!dsSpx1.defaults[0].IsfechaVigenciaOrdenServicioNull())
                        reporte.Fields["lblVigencia"].Value = dsSpx1.defaults[0].fechaVigenciaOrdenServicio.ToShortDateString();
                }
               
              
            }
            else
            {
                if (reporte.Fields.Contains("lblTitulo"))
                {
                    reporte.Fields["lblTitulo"].Value = dsSpx1.defaults[0].tituloReporteServicio.Trim();
                }
                if (reporte.Fields.Contains("lblVersion"))
                {
                    reporte.Fields["lblVersion"].Value = dsSpx1.defaults[0].versionReporteServicio.Trim();
                }
                if (reporte.Fields.Contains("lblTipoDocumento"))
                {
                    if (!dsSpx1.defaults[0].IscodigoReporteServicioNull())
                        reporte.Fields["lblTipoDocumento"].Value = dsSpx1.defaults[0].codigoReporteServicio.Trim();
                }
                if (reporte.Fields.Contains("lblVigencia"))
                {
                    if (!dsSpx1.defaults[0].IsfechaVigenciaReporteServicioNull())
                        reporte.Fields["lblVigencia"].Value = dsSpx1.defaults[0].fechaVigenciaReporteServicio.ToShortDateString();
                }
                //if (opcion == 3)
                //{
                //    reporte.Fields["lblTitulo"].Value = "Orden Completa";
                //}


                comprobantesAceptacionOrdenservicioTableAdapter2.FillByCodOrdenServicio(dsSpx1.comprobantesAceptacionOrdenservicio, int.Parse(CodOrdenServicio));
                try
                {
                    string a = (dsSpx1.comprobantesAceptacionOrdenservicio[0].IsdatosNull() ? "" : dsSpx1.comprobantesAceptacionOrdenservicio[0].datos.ToString());

                    if (a != string.Empty || a != null)
                    {
                        byte[] arr = (byte[])dsSpx1.comprobantesAceptacionOrdenservicio[0].datos;
                        System.IO.Stream stream = new System.IO.MemoryStream(arr);
                        Image im = Image.FromStream(stream);
                        if (reporte.Fields.Contains("picLogo2"))
                        {
                            reporte.Fields["picLogo2"].Picture = im;
                        }
                    }
                    else
                    {
                        if (reporte.Fields.Contains("picLogo2"))
                        {
                            reporte.Fields["picLogo2"].Visible = false;
                        }
                    }
                }
                catch 
                {
                    reporte.Fields["picLogo2"].Visible = false;
                }

            }
            if (reporte.Fields.Contains("rptReporteServicioFallareportada"))
            {
                reporte.Fields["rptReporteServicioFallareportada"].Subreport.DataSource.ConnectionString = objData.CadenaConexionReportes;
                reporte.Fields["rptReporteServicioFallareportada"].Subreport.DataSource.RecordSource = reporte.Fields["rptReporteServicioFallareportada"].Subreport.DataSource.RecordSource.Replace("<<codOrdenServicio>>", txtNumeroOrdenServicio.Text);
            }
            if (reporte.Fields.Contains("rptReporteServicioDiagonostico"))
            {
                reporte.Fields["rptReporteServicioDiagonostico"].Subreport.DataSource.ConnectionString = objData.CadenaConexionReportes;
                reporte.Fields["rptReporteServicioDiagonostico"].Subreport.DataSource.RecordSource = reporte.Fields["rptReporteServicioDiagonostico"].Subreport.DataSource.RecordSource.Replace("<<codOrdenServicio>>", txtNumeroOrdenServicio.Text);
            }
            if (reporte.Fields.Contains("rptReporteServicioObservacionesIngeniero"))
            {
                reporte.Fields["rptReporteServicioObservacionesIngeniero"].Subreport.DataSource.ConnectionString = objData.CadenaConexionReportes;
                reporte.Fields["rptReporteServicioObservacionesIngeniero"].Subreport.DataSource.RecordSource = 
                    reporte.Fields["rptReporteServicioObservacionesIngeniero"].Subreport.DataSource.RecordSource.Replace("<<codOrdenServicio>>", txtNumeroOrdenServicio.Text);
            }
            if (reporte.Fields.Contains("rptReporteServicioRepuesto"))
            {
                reporte.Fields["rptReporteServicioRepuesto"].Subreport.DataSource.ConnectionString = objData.CadenaConexionReportes;
                reporte.Fields["rptReporteServicioRepuesto"].Subreport.DataSource.RecordSource = reporte.Fields["rptReporteServicioRepuesto"].Subreport.DataSource.RecordSource.Replace("<<codOrdenServicio>>", txtNumeroOrdenServicio.Text);
            }
            if (reporte.Fields.Contains("subRptDispositivosMedicion"))
            {
                reporte.Fields["subRptDispositivosMedicion"].Subreport.DataSource.ConnectionString = objData.CadenaConexionReportes;
                reporte.Fields["subRptDispositivosMedicion"].Subreport.DataSource.RecordSource = reporte.Fields["subRptDispositivosMedicion"].Subreport.DataSource.RecordSource.Replace("<<codOrdenServicio>>", txtNumeroOrdenServicio.Text);
            }
            if (reporte.Fields.Contains("subRptVariablesxOrden"))
            {
                reporte.Fields["subRptVariablesxOrden"].Subreport.DataSource.ConnectionString = objData.CadenaConexionReportes;
                reporte.Fields["subRptVariablesxOrden"].Subreport.DataSource.RecordSource = reporte.Fields["subRptVariablesxOrden"].Subreport.DataSource.RecordSource.Replace("<<codOrdenServicio>>", txtNumeroOrdenServicio.Text);
            }

            if (reporte.Fields.Contains("notaPie"))
            {
                if (!dsSpx1.defaults[0].IsnotaPieReportesServicoNull())
                    reporte.Fields["notaPie"].Value = dsSpx1.defaults[0].notaPieReportesServico;
            }

            if (reporte.Fields.Contains("imgReviso"))
            {
                #region remplazamos la imagen de la firma
                string sql = @"select imagen_firma from informacion_adicional_usuario
where cod_usuario in(
select cod_usuario from ordenServicio 
join usuario on usuario.login = ordenServicio.asignadoA
where codOrdenServicio =" + txtNumeroOrdenServicio.Text + ")";
                System.Data.DataTable tb = objData.ejecutarConsulta(sql).Tables[0];
                if (tb.Rows.Count > 0 && tb.Rows[0]["imagen_firma"] != null && tb.Rows[0]["imagen_firma"] != System.DBNull.Value)
                {
                    System.Drawing.Image im = System.Drawing.Image.FromStream(new System.IO.MemoryStream((byte[])tb.Rows[0]["imagen_firma"]));
                    System.Drawing.Bitmap b = new System.Drawing.Bitmap(im, 250, 125);
                    string rutaImagen = System.IO.Path.GetTempPath();
                    rutaImagen = "" + rutaImagen + "/imgOs" + DateTime.Now.Year + "m"
                        + DateTime.Now.Month.ToString().PadLeft(2, '0') +
                        "d" + DateTime.Now.Day.ToString().PadLeft(2, '0') + "h" + DateTime.Now.Hour +
                        "m" + DateTime.Now.Minute.ToString().PadLeft(2, '0') + "m" +
                        DateTime.Now.Second.ToString().PadLeft(2, '0') + ".Png";
                    b.Save(rutaImagen, System.Drawing.Imaging.ImageFormat.Png);

                    reporte.Fields["imgReviso"].Picture = System.Drawing.Image.FromFile(rutaImagen);
                    reporte.Fields["imgReviso"].Visible = true;
                }
                #endregion
            }

            if (reporte.Fields.Contains("subReport"))
            {
                reporte.Fields["subreport"].Subreport.DataSource.ConnectionString = objData.CadenaConexionReportes;
               
            }
            reporte.DataSource.RecordSource = reporte.DataSource.RecordSource.Replace("<<codOrdenServicio>>", txtNumeroOrdenServicio.Text);


            SPControladoraDatos.artefactos.SPXQuery.frm.Reportes.frmReporte  frmRpt = new SPControladoraDatos.artefactos.SPXQuery.frm.Reportes.frmReporte (reporte);
            frmRpt.Icon = this.Icon;

            frmRpt.ShowDialog();
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //llamamos al formulario que permite elegir que imprimir
            frmImpresion frm = new frmImpresion();
            frm.CodOrdenServicio = int.Parse(codOrdenServicio);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                imprimirOs(frm.Opcion);
            }
        }

        #endregion
        private void tabControl1_SelectedTabChanging(object sender, DevComponents.DotNetBar.TabStripTabChangingEventArgs e)
        {
            if (!verPermisoxTab(e.NewTab.Text))
            {
                e.Cancel = true;
                return;
            }
            cargarDatos(e.NewTab.Text);
        }

        private void btnInfEquipo_Click(object sender, EventArgs e)
        {
            if (txtSerial.Text.Trim() == string.Empty) return;
            spProcesos.Equipos.frmInformacionEquipo frm = new spProcesos.Equipos.frmInformacionEquipo();
            frm.Serial = txtSerial.Text.Trim();
            frm.ShowDialog();
        }

        private bool validar()
        {
            if (!rdInterna.Checked && !rdOrdenExterna.Checked)
            {
                MessageBox.Show("Ingrese si la orden de servicio es interna o externa.");
                return false;
            }
            if (rdInterna.Checked && (txtNumeroEntrada.Text.Trim() == string.Empty || txtNumeroEntrada.Text.Trim() == "0"))
            {
                MessageBox.Show("Las ordenes de servicio internas deben estar asociadas a un registro de entrada");
                return false;
            }
            if (txtSerial.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El equipo es necesario para crear la orden de servicio");

                txtSerial.Focus();
                return false;
            }
            if (calFinProg.fechaValue < calInicioProg.fechaValue)
            {
                MessageBox.Show("Las fechas de programacion no son validas!");

                calInicioProg.Focus();
                return false;
            }

            return true;
        }

        private void guardarNueva()
        {
            //este caso es para cuando es nuevo
            bool fechaValida = true;
            //miramos si ya tiene asignada  una fecha valida
            if (calInicioProg.fechaValueObject == null || calFinProg.fechaValueObject == null)
            {
                fechaValida = false;
            }

            Nullable<DateTime> fechaProgramacion = new Nullable<DateTime>();
            Nullable<DateTime> fechaFinProgramacion = new Nullable<DateTime>();
            string asignadoA = "";



            //miramos los permisos
            if (per_programaOrden)
            {
                if (cmbIngeniero.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Para Guardar una orden de Servicio es Obligatorio Asignarle un Ingeniero.");
                    return;
                }
                if (!fechaValida)
                {
                    MessageBox.Show("Verifique las Fechas.");
                    return;
                }
                #region si tiene ingeniero y fecha deja programada la orden de una vez

                    asignadoA = cmbIngeniero.SelectedValue.ToString();
                    fechaProgramacion = calInicioProg.fechaValue;
                    fechaFinProgramacion = calFinProg.fechaValue;
                    #endregion
                
            }

            //creamos la orden de servicio con el manejador de ordenes de servicio
            cls.osController objC = new spProcesos.ordenesTrabajo.cls.osController();
            int codAsesor = 0;
            if (cmbAsesorComercial.SelectedValue != null && cmbAsesorComercial.SelectedValue.ToString().Trim() != string.Empty)
            {
                codAsesor = int.Parse(cmbAsesorComercial.SelectedValue.ToString());
            }

            int cod = objC.crearOrdenServicio(txtSerial.Text, ((asignadoA == string.Empty) ? "" : asignadoA),
            fechaProgramacion, fechaFinProgramacion, rdInterna.Checked,
            (rdInterna.Checked) ? int.Parse(txtNumeroEntrada.Text) : 0, cmbTipoServicio.SelectedValue.ToString()
            , int.Parse(cmbPrioridad.SelectedValue.ToString()), txtObservacionesIniciales.Text, "", txtFallasReportadas.Text,
            txtDiagnostico.Text, codAsesor);
            //si es interna actualizamos la entrada
            if (rdInterna.Checked)
                entradaSalidaEquiposTableAdapter1.UpdateCodOrdenServicio(cod, int.Parse(txtNumeroEntrada.Text));

            //Luego de crearla cargamos el dataset y actualizams los botones
            codOrdenServicio = cod.ToString();
            ordenServicioTableAdapter1.FillByCodOrdenServicio(dsSpx1.ordenServicio, cod);
            ajustarBotones();
            #region zona de notificaciones de email
          //  CgSmtpEmailSender.core.clsSender mailsender = new CgSmtpEmailSender.core.clsSender();
          //  mailsender.EjecutarAccion(1, cmbIngeniero.SelectedValue.ToString(), (System.Data.DataRow)dsSpx1.ordenServicio[0], null, CgSmtpEmailSender.core.clsSender.prioridad.media,"","");
            #endregion
            if (cmbIngeniero.SelectedValue != null && cmbIngeniero.SelectedValue.ToString().Trim() != string.Empty)
                notificacionTableAdapter1.Insert(cmbIngeniero.SelectedValue.ToString(), "Nueva orden de servicio generada",
                    "La orden de servicio "+cod +" se le asigno recientemente, "+cmbTipoServicio.Text+" "+txtModelo.Text);

        }

        private void guardarAntigua()
        {
            bool fechaValida = true;
            //miramos si ya tiene asignada  una fecha valida
            if (calInicioProg.fechaValueObject == null || calFinProg.fechaValueObject  == null)
            {
                fechaValida = false;
            }
            Nullable<DateTime> fechaProgramacion = new Nullable<DateTime>();
            Nullable<DateTime> fechaFinProgramacion = new Nullable<DateTime>();
            string asignadoA = "";
            string estado = dsSpx1.ordenServicio[0].codEstadoOrdenServicio.Trim().ToUpper();
            if (estado == "PROGR")
            {
                if (cmbIngeniero.Text.Trim() == string.Empty || !fechaValida)
                {
                    MessageBox.Show("No puede modificar una orden programada sin ingeniero o sin una fecha valida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    return;
                }
                estado = "PROGR";
                fechaProgramacion = dsSpx1.ordenServicio[0].fechaProgramacion;
                asignadoA = cmbIngeniero.SelectedValue.ToString();
                fechaProgramacion = calInicioProg.fechaValue;
                fechaFinProgramacion = calFinProg.fechaValue;
            }
            else
            {
                if (!dsSpx1.ordenServicio[0].IsfechaProgramacionNull()) { fechaProgramacion = dsSpx1.ordenServicio[0].fechaProgramacion; }

                asignadoA = cmbIngeniero.SelectedValue.ToString();
                if (!fechaValida)
                {
                    MessageBox.Show("Ingrese la fecha y hora de inicio y de finalizacion de la Orden de Trabajo");
                    return;
                }
                fechaProgramacion = calInicioProg.fechaValue;
                fechaFinProgramacion = calFinProg.fechaValue;
            }
            Nullable<int> enteroNulo = new Nullable<int>();
            int codAsesor = 0;
            if (cmbAsesorComercial.SelectedValue != null && cmbAsesorComercial.SelectedValue.ToString() != string.Empty)
                codAsesor = int.Parse(cmbAsesorComercial.SelectedValue.ToString());

            if (rdInterna.Checked)
                entradaSalidaEquiposTableAdapter1.UpdateCodOrdenServicio(int.Parse(codOrdenServicio), int.Parse(txtNumeroEntrada.Text));

           
            ordenServicioTableAdapter1.UpdateNueva(int.Parse(codOrdenServicio), fechaProgramacion, fechaFinProgramacion,
                        (asignadoA == string.Empty) ? null : asignadoA, rdInterna.Checked, txtSerial.Text, 
                    txtNitCliente.Text.Trim(),
                    codSucursal,
                    cmbTipoServicio.SelectedValue.ToString(),
                    dsSpx1.equipos[0].IscodModalidadEquipoNull() ? null : dsSpx1.equipos[0].codModalidadEquipo, estado,
                    int.Parse(cmbPrioridad.SelectedValue.ToString()), txtObservacionesIniciales.Text, txtObservacionesIngeniero.Text
                    , txtFallasReportadas.Text, txtDiagnostico.Text,
                    (rdInterna.Checked) ? int.Parse(txtNumeroEntrada.Text) : 0, (codAsesor == 0) ? enteroNulo : codAsesor);
            ordenServicioTableAdapter1.UpdateMantenimientoSegunIndicado(
                ((!rdMantemientoIndicado.Checked && !rdManteimientoIndicadoNo.Checked) ? (bool?)null:rdMantemientoIndicado.Checked) 
                
                , (DateTime?)calMantenimientoxUsuario.ValueObject,
                ((!rdAdecuado.Checked && !rdAdecuadoNo.Checked) ? (bool?)null : rdAdecuado.Checked),
                int.Parse(codOrdenServicio));
            

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validar()) return;
            if (codOrdenServicio.Trim() == string.Empty)
            {
                guardarNueva();
                if (mostrarDialogo)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            {
                guardarAntigua();
            }
            //realizamos operaciones de acuerdo al contrato
                  cls.osController objC = new spProcesos.ordenesTrabajo.cls.osController();
            if (vincularContrato && codOrdenServicio.Trim() != string.Empty) 
            {
            
                txtNumeroContrato.Text = objC.vincularOrdenContrato(txtSerial.Text, int.Parse(codOrdenServicio) );
            }
            else if (desVincularContrato && codOrdenServicio.Trim() != string.Empty)
            {
                  txtNumeroContrato.Text = "";
                objC.desVincularOrdenContrato(int.Parse(codOrdenServicio));
            }

            ajustarBotones();
            ajustarControles();
            System.Media.SystemSounds.Asterisk.Play();

        }

        private void btnLimpiarIngeniero_Click(object sender, EventArgs e)
        {
            cmbIngeniero.SelectedValue = "";
            lblIngeniero.Text = "";
        }
/// <summary>
/// Estima el tiempo de la orden dada la duracion del mantenimiento para el modelo.
/// </summary>
        private void calcularHoraFin()
        {
            DateTime fecha = calInicioProg.fechaValue;
            calFinProg.fechaValue= calInicioProg.fechaValue.AddHours(duracionModelo);
        }

       

        private void txtSerial_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            spProcesos.Equipos.frmBuscarEquipo fr = new spProcesos.Equipos.frmBuscarEquipo();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                txtSerial.Text = fr.Serial;
                txtSerial.Focus();
                cargarserial(txtSerial.Text);
            }
        }

        private void txtSerial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                spProcesos.Equipos.frmBuscarEquipo fr = new spProcesos.Equipos.frmBuscarEquipo();
                if (fr.ShowDialog() == DialogResult.OK)
                {
                    txtSerial.Text = fr.Serial;
                    txtSerial.Focus();
                    cargarserial(txtSerial.Text);
                }
            }
        }

        private void cmbIngeniero_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  lblIngeniero.Text = ((DataRowView)(BindingContext[dsSPXSeguridad1, "usuario"].Current))[1].ToString();
        }


        #region actividades realizadas

        private void btnAgregarActividad_Click(object sender, EventArgs e)
        {
            //agregar
            if (codOrdenServicio.Trim() == string.Empty)
            {
                MessageBox.Show("Para agregar actividades primero debe guardar la orden de servicio.");
                return;
            }
            #region verificamos los permisos
            if (!per_modificaOrden && (cmbIngeniero.SelectedValue.ToString().Trim() != SPXSeguridad.logica.sesion.LoginUsuarioAutenticado))
            {
                MessageBox.Show("No tiene los suficientes permisos para hacer esto.\n recuerde que el ingeniero asignado a esta orden de servicio es " + lblIngeniero.Text);
            }
            if (!per_modificaOrden && !per_realizaOrden)
            {
                MessageBox.Show("Solo el ingeniero que tiene asignada la orden de servicio puede asignar actividades");
                return;
            }
            if (!per_modificaOrden && cmbEstado.SelectedValue.ToString().Trim() == "ANULA")
            {
                MessageBox.Show("No puede asignar actividades si la orden de servicio esta anulada.");
                return;
            }
            if (!per_modificaOrden && cmbEstado.SelectedValue.ToString().Trim() == "CERRA")
            {
                MessageBox.Show("No puede asignar actividades si la orden de servicio esta cerrada.");
                return;
            }
            if (!per_modificaOrden && cmbEstado.SelectedValue.ToString().Trim() == "APROB")
            {
                MessageBox.Show("No puede asignar actividades si la orden de servicio esta aprobada.");
                return;
            }
            #endregion
            frmObservacionxOrdenServicio fr = new frmObservacionxOrdenServicio();
            fr.PuedeAsignarxOtro = per_modificaOrden;
            fr.Login = cmbIngeniero.SelectedValue.ToString();
            fr.CodOrdenServicio = codOrdenServicio.Trim();
            fr.CodActividad = "";
            if (fr.ShowDialog() == DialogResult.OK)
            {
                //cambiamos el estado de la orden de servicio x en ejecucion solo para las programadas
                string est = cmbEstado.SelectedValue.ToString().Trim();
                if (est == "PROGR")
                {
                    ordenServicioTableAdapter1.UpdateEstado("EJECU", int.Parse(codOrdenServicio));
                }
                actividadxordenServicioTableAdapter1.FillBycodOrdenServicio(dsSpx1.actividadxordenServicio, int.Parse(codOrdenServicio));
                #region zona de notificaciones de email
              //  CgSmtpEmailSender.core.clsSender mailsender = new CgSmtpEmailSender.core.clsSender();
              //  mailsender.EjecutarAccion(8,cmbIngeniero.SelectedValue.ToString(),
              //      (System.Data.DataRow)dsSpx1.actividadxordenServicio[dsSpx1.actividadxordenServicio.Count-1], null, CgSmtpEmailSender.core.clsSender.prioridad.media,"","");
                #endregion
            }
        }

        private void btnModificarActividad_Click(object sender, EventArgs e)
        {
            //verfificamos los permisos
            if (grdActividades.Columns["codActividad"].Text.Trim() == string.Empty) return;
            #region verificamos los permisos
            if (!per_modificaOrden && (cmbIngeniero.SelectedValue.ToString().Trim() == SPXSeguridad.logica.sesion.LoginUsuarioAutenticado.Trim()))
            {
                MessageBox.Show("No tiene los suficientes permisos para hacer esto.\n recuerde que el ingeniero asignado a esta orden de servicio es " + lblIngeniero.Text);
                return;
            }
            if (!per_modificaOrden && !per_realizaOrden)
            {
                MessageBox.Show("Solo el ingeniero que tiene asignada la orden de servicio puede modificar actividades");
                return;
            }
            if (!per_modificaOrden && cmbEstado.SelectedValue.ToString().Trim() == "ANULA")
            {
                MessageBox.Show("No puede modificar actividades si la orden de servicio esta anulada.");
                return;
            }
            if (!per_modificaOrden && cmbEstado.SelectedValue.ToString().Trim() == "CERRA")
            {
                MessageBox.Show("No puede modificar actividades si la orden de servicio esta cerrada.");
                return;
            }
            if (!per_modificaOrden && cmbEstado.SelectedValue.ToString().Trim() == "APROB")
            {
                MessageBox.Show("No puede modificar actividades si la orden de servicio esta aprobada.");
                return;
            }
            #endregion
            frmObservacionxOrdenServicio fr = new frmObservacionxOrdenServicio();
            fr.Login = cmbIngeniero.SelectedValue.ToString();
            fr.CodOrdenServicio = codOrdenServicio.Trim();
            fr.CodActividad = grdActividades.Columns["codActividad"].Text.Trim();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                actividadxordenServicioTableAdapter1.FillBycodOrdenServicio(dsSpx1.actividadxordenServicio, int.Parse(codOrdenServicio));
            }
        }

        private void btnEliminarActividad_Click(object sender, EventArgs e)
        {

            if (grdActividades.Columns["codActividad"].Text.Trim() == string.Empty) return;
            #region verificamos los permisos
            if (!per_modificaOrden && (cmbIngeniero.SelectedValue.ToString().Trim() != SPXSeguridad.logica.sesion.LoginUsuarioAutenticado.Trim()))
            {
                MessageBox.Show("No tiene los suficientes permisos para hacer esto.\n recuerde que el ingeniero asignado a esta orden de servicio es " + lblIngeniero.Text);
                return;
            }
            if (!per_modificaOrden && !per_realizaOrden)
            {
                MessageBox.Show("Solo el ingeniero que tiene asignada la orden de servicio puede eliminar actividades");
                return;
            }
            if (!per_modificaOrden && cmbEstado.SelectedValue.ToString().Trim() == "ANULA")
            {
                MessageBox.Show("No puede eliminar actividades si la orden de servicio esta anulada.");
                return;
            }
            if (!per_modificaOrden && cmbEstado.SelectedValue.ToString().Trim() == "CERRA")
            {
                MessageBox.Show("No puede eliminar actividades si la orden de servicio esta cerrada.");
                return;
            }
            if (!per_modificaOrden && cmbEstado.SelectedValue.ToString().Trim() == "APROB")
            {
                MessageBox.Show("No puede eliminar actividades si la orden de servicio esta aprobada.");
                return;
            }
            #endregion
            string a = grdActividades.Columns["codActividad"].Text.Trim();
            if (MessageBox.Show("Esta seguro de eliminar esta actividad?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                actividadxordenServicioTableAdapter1.DeleteQuery(int.Parse(codOrdenServicio), int.Parse(a));
                actividadxordenServicioTableAdapter1.FillBycodOrdenServicio(dsSpx1.actividadxordenServicio, int.Parse(codOrdenServicio));
            }

        }

        #endregion

        #region zona de archivos
        private void btnSubirArchivo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            //
            SPControladoraDatos.artefactos.SPXUtilidades.frmMensaje frm = new SPControladoraDatos.artefactos.SPXUtilidades.frmMensaje();
            frm.titulo = "Descripcion del Archivo";
            frm.pregunta = "Ingrese una descripcion del archivo";
            frm.mensaje = openFileDialog1.FileName;
            if (frm.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                System.IO.FileStream fs = new System.IO.FileStream(openFileDialog1.FileName
                    , System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Read);

                byte[] archivo = new byte[fs.Length];
                fs.Read(archivo, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
                string nombre = System.IO.Path.GetFileName(openFileDialog1.FileName.Trim());
                if (nombre.Length >= 150) nombre = nombre.Substring(0, 150);
                string mensaje = frm.mensaje.Trim();
                if (mensaje.Length >= 250) mensaje = mensaje.Substring(0, 250);

                int codArchivo = int.Parse(archivosXOrdenServicioTableAdapter1.verNextId(int.Parse(codOrdenServicio)).ToString());
                archivosXOrdenServicioTableAdapter1.Insert(int.Parse(codOrdenServicio), codArchivo, nombre, archivo, mensaje);
                //cargamos los archivos
                archivosXOrdenServicioTableAdapter1.FillByCodOrdenServicio(dsSpx1.archivosXOrdenServicio, int.Parse(codOrdenServicio));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el archivo\n" + ex.Message);
            }
        }

        private void btnVerArchivo_Click(object sender, EventArgs e)
        {
            if (grdArchivos.Columns["codArchivo"].Value == null ||
     grdArchivos.Columns["codArchivo"].Value.ToString().Trim() == string.Empty)
            {
                return;
            }
            try
            {
                string path = System.IO.Path.GetTempPath();
                string nombreArchivo = path + @"\" + System.IO.Path.GetFileName(
                    grdArchivos.Columns["nombreArchivo"].Value.ToString());

                FileStream stream = new FileStream(nombreArchivo, FileMode.Create, FileAccess.Write);
                BinaryWriter writer = new BinaryWriter(stream);
                byte[] arr = (byte[])
                    archivosXOrdenServicioTableAdapter1.verArchivo(int.Parse(codOrdenServicio), int.Parse(grdArchivos.Columns["codArchivo"].Value.ToString()));
                writer.Write(arr);
                writer.Close();
                //despues de creado lo abrimos
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo.FileName = nombreArchivo;
                //p.StartInfo.CreateNoWindow=true;
                p.StartInfo.UseShellExecute = true;
                p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                p.StartInfo.WorkingDirectory = nombreArchivo.Replace(System.IO.Path.GetFileName(nombreArchivo), "");
                p.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el archivo\n " + ex.Message);
            }
        }

        private void btnGuardarArchivo_Click(object sender, EventArgs e)
        {
            if (grdArchivos.Columns["codArchivo"].Value == null ||
  grdArchivos.Columns["codArchivo"].Value.ToString().Trim() == string.Empty)
            {
                return;
            }
            saveFileDialog1.FileName = grdArchivos.Columns["nombreArchivo"].Value.ToString();
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                string nombreArchivo = saveFileDialog1.FileName;

                FileStream stream = new FileStream(nombreArchivo, FileMode.Create, FileAccess.Write);
                BinaryWriter writer = new BinaryWriter(stream);
                byte[] arr = (byte[])
                    archivosXOrdenServicioTableAdapter1.verArchivo(int.Parse(codOrdenServicio), int.Parse(grdArchivos.Columns["codArchivo"].Value.ToString()));

                writer.Write(arr);
                writer.Close();
                MessageBox.Show("Archivo Guardado satisfactoriamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo \n" + ex.Message);
            }
        }

        private void btnQuitarArchivo_Click(object sender, EventArgs e)
        {
            if (grdArchivos.Columns["codArchivo"].Value == null ||
         grdArchivos.Columns["codArchivo"].Value.ToString().Trim() == string.Empty)
            {
                return;
            }

            if (MessageBox.Show("Esta seguro de eliminar el archivo relacionado al modelo", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) != DialogResult.Yes)
                return;


            archivosXOrdenServicioTableAdapter1.DeleteQuery(int.Parse(codOrdenServicio), int.Parse(grdArchivos.Columns["codArchivo"].Value.ToString()));
            //cargamos la grilla
            archivosXOrdenServicioTableAdapter1.FillByCodOrdenServicio(dsSpx1.archivosXOrdenServicio, int.Parse(codOrdenServicio));

        }
        #endregion

        #region zona de comprobantes de aceptacion
        private void btnAgregarComprobante_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            //
            SPControladoraDatos.artefactos.SPXUtilidades.frmMensaje frm = new SPControladoraDatos.artefactos.SPXUtilidades.frmMensaje();
            frm.titulo = "Descripcion del Archivo";
            frm.pregunta = "Ingrese una descripcion del archivo";
            frm.mensaje = openFileDialog1.FileName;
            if (frm.ShowDialog() != DialogResult.OK)
                return;
            //ahora vamos con el tipo de comprobante
            frmTipoComprobante frmTipo = new frmTipoComprobante();
            if (frmTipo.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                string arr = System.IO.Path.GetFileName(openFileDialog1.FileName);
                System.IO.FileStream fs = new System.IO.FileStream(openFileDialog1.FileName
                    , System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Read);

                byte[] archivo = new byte[fs.Length];
                fs.Read(archivo, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
                string nombre = arr;
                if (nombre.Length >= 150) nombre = nombre.Substring(0, 150);
                string mensaje = frm.mensaje.Trim();
                if (mensaje.Length >= 250) mensaje = mensaje.Substring(0, 250);

                int codArchivo = int.Parse(comprobantesAceptacionOrdenservicioTableAdapter1.verNextId(int.Parse(codOrdenServicio)).ToString());
                comprobantesAceptacionOrdenservicioTableAdapter1.Insert(codArchivo, int.Parse(codOrdenServicio),
                    mensaje, frmTipo.codTipoComprobante, archivo, nombre);
                //cargamos los archivos
                comprobantesAceptacionOrdenservicioTableAdapter1.FillByCodOrdenServicio(dsSpx1.comprobantesAceptacionOrdenservicio, int.Parse(codOrdenServicio));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el archivo\n" + ex.Message);
            }
        }

        private void btnVerComprobante_Click(object sender, EventArgs e)
        {
            if (grdComprobantes.Columns["codComprobantesAceptacionOrdenservicio"].Value == null ||
    grdComprobantes.Columns["codComprobantesAceptacionOrdenservicio"].Value.ToString().Trim() == string.Empty)
            {
                return;
            }
            try
            {
                string path = System.IO.Path.GetTempPath();
                string nombreArchivo = path + @"\" + System.IO.Path.GetFileName(
                    grdComprobantes.Columns["nombre"].Value.ToString());

                FileStream stream = new FileStream(nombreArchivo, FileMode.Create, FileAccess.Write);
                BinaryWriter writer = new BinaryWriter(stream);
                object ob =
                    comprobantesAceptacionOrdenservicioTableAdapter1.verArchivo(int.Parse(grdComprobantes.Columns["codComprobantesAceptacionOrdenservicio"].Value.ToString()),
                    int.Parse(codOrdenServicio));
                byte[] arr = (byte[])ob;
                writer.Write(arr);
                writer.Close();
                //despues de creado lo abrimos
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo.FileName = nombreArchivo;
                //p.StartInfo.CreateNoWindow=true;
                p.StartInfo.UseShellExecute = true;
                p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                p.StartInfo.WorkingDirectory = nombreArchivo.Replace(System.IO.Path.GetFileName(nombreArchivo), "");
                p.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el archivo\n " + ex.Message);
            }
        }

        private void btnGuardarComprobante_Click(object sender, EventArgs e)
        {
            if (grdComprobantes.Columns["codComprobantesAceptacionOrdenservicio"].Value == null ||
grdComprobantes.Columns["codComprobantesAceptacionOrdenservicio"].Value.ToString().Trim() == string.Empty)
            {
                return;
            }
            saveFileDialog1.FileName = grdComprobantes.Columns["nombre"].Value.ToString();
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                string nombreArchivo = saveFileDialog1.FileName;

                FileStream stream = new FileStream(nombreArchivo, FileMode.Create, FileAccess.Write);
                BinaryWriter writer = new BinaryWriter(stream);
                object ob =
                  comprobantesAceptacionOrdenservicioTableAdapter1.verArchivo(int.Parse(grdComprobantes.Columns["codComprobantesAceptacionOrdenservicio"].Value.ToString()),
                  int.Parse(codOrdenServicio));
                byte[] arr = (byte[])ob;
                writer.Write(arr);
                writer.Close();
                MessageBox.Show("Archivo Guardado satisfactoriamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo \n" + ex.Message);
            }
        }

        private void btnQuitarComprobante_Click(object sender, EventArgs e)
        {
            if (grdComprobantes.Columns["codComprobantesAceptacionOrdenservicio"].Value == null ||
       grdComprobantes.Columns["codComprobantesAceptacionOrdenservicio"].Value.ToString().Trim() == string.Empty)
            {
                return;
            }

            if (MessageBox.Show("Esta seguro de eliminar el archivo relacionado al modelo", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) != DialogResult.Yes)
                return;

            comprobantesAceptacionOrdenservicioTableAdapter1.DeleteQuery(int.Parse(grdComprobantes.Columns["codComprobantesAceptacionOrdenservicio"].Value.ToString()), int.Parse(codOrdenServicio));
            //cargamos la grilla
            comprobantesAceptacionOrdenservicioTableAdapter1.FillByCodOrdenServicio(dsSpx1.comprobantesAceptacionOrdenservicio, int.Parse(codOrdenServicio));

        }
        #endregion

        #region zona de solicitud de insumos
        private void btnImprimirSolicitud_Click(object sender, EventArgs e)
        {
            if (codOrdenServicio.Trim() == string.Empty) return;
            if (grdSolicitudesInsumos.Columns["codSolicitud"].Text.Trim() == string.Empty) return;

            string ruta = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter objDef = new SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter();
            objDef.Fill(dsSpx1.defaults);

            C1.C1Report.C1Report reporte = new C1.C1Report.C1Report();
            reporte.Load(ruta + @"\rpt\rpt.xml", "rptInsumos");
            if (!dsSpx1.defaults[0].IslogotipoNull())
            {
                byte[] arr = (byte[])dsSpx1.defaults[0].logotipo;
                System.IO.Stream stream = new System.IO.MemoryStream(arr);
                Image im = Image.FromStream(stream);
                if (reporte.Fields.Contains("picLogo"))
                {
                    reporte.Fields["picLogo"].Picture = im;
                }
            }
            if (reporte.Fields.Contains("lblTitulo"))
            {
                reporte.Fields["lblTitulo"].Value = dsSpx1.defaults[0].nombreReporteInsumos.Trim();
            }
            if (reporte.Fields.Contains("lblVersion"))
            {
                reporte.Fields["lblVersion"].Value = dsSpx1.defaults[0].versionReporteInsumos.Trim();
            }
            if (reporte.Fields.Contains("lblTipoDocumento"))
            {
                if (!dsSpx1.defaults[0].IscodigoReporteInsumosNull())
                    reporte.Fields["lblTipoDocumento"].Value = dsSpx1.defaults[0].codigoReporteInsumos.Trim();
            }
            if (reporte.Fields.Contains("lblVigencia"))
            {
                if (!dsSpx1.defaults[0].IsfechaVigenciaReporteInsumosNull())
                    reporte.Fields["lblVigencia"].Value = dsSpx1.defaults[0].fechaVigenciaReporteInsumos.ToShortDateString();
            }
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            reporte.DataSource.ConnectionString = objData.CadenaConexionReportes;
            reporte.DataSource.RecordSource = reporte.DataSource.RecordSource.Replace("<<codigoOrden>>", codOrdenServicio);
            reporte.DataSource.RecordSource = reporte.DataSource.RecordSource.Replace("<<codigoSolicitud>>", grdSolicitudesInsumos.Columns["codSolicitud"].Text);
           var  frmRpt = new SPControladoraDatos.artefactos.SPXQuery.frm.Reportes.frmReporte (reporte);
            frmRpt.Icon = this.Icon;

            frmRpt.ShowDialog();
        }

        private void btnActualizarSolicitudes_Click(object sender, EventArgs e)
        {
            if (codOrdenServicio.Trim() == string.Empty) return;
            solicitudInsumosTableAdapter1.FillByCodOrdenServicio(dsSpx1.solicitudInsumos, int.Parse(codOrdenServicio));
        }

        private void btnAgregarInsumos_Click(object sender, EventArgs e)
        {
            if (codOrdenServicio.Trim() == string.Empty)
            {
                MessageBox.Show("para realizar solicitud de insumos primero debe guardar la orden de servicio");
                return;
            }
            frmSolicitudInsumos fr = new frmSolicitudInsumos();
            fr.CodOrdenServicio = codOrdenServicio;
            if (fr.ShowDialog() == DialogResult.OK)
            {
                solicitudInsumosTableAdapter1.FillByCodOrdenServicio(dsSpx1.solicitudInsumos, int.Parse(codOrdenServicio));
            }
        }

        private void btnModifcarSolicitud_Click(object sender, EventArgs e)
        {
            if (grdSolicitudesInsumos.Columns["codSolicitud"].Text.Trim() == string.Empty) return;
            frmSolicitudInsumos fr = new frmSolicitudInsumos();
            fr.CodOrdenServicio = codOrdenServicio;
            fr.CodSolicitud = grdSolicitudesInsumos.Columns["codSolicitud"].Text.Trim();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                solicitudInsumosTableAdapter1.FillByCodOrdenServicio(dsSpx1.solicitudInsumos, int.Parse(codOrdenServicio));
            }
        }

        private void btnEliminarSolicitud_Click(object sender, EventArgs e)
        {
            if (grdSolicitudesInsumos.Columns["codSolicitud"].Text.Trim() == string.Empty) return;

            if (MessageBox.Show("Esta Seguro de Eliminar esta Solicitud de Insumos", "Elimnar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SPControladoraDatos.dsSpxTableAdapters.detalleSolicitudInsumosTableAdapter objDet = new SPControladoraDatos.dsSpxTableAdapters.detalleSolicitudInsumosTableAdapter();
                objDet.DeleteQuery(int.Parse(codOrdenServicio), int.Parse(grdSolicitudesInsumos.Columns["codSolicitud"].Text.Trim()));
                solicitudInsumosTableAdapter1.DeleteQuery(int.Parse(codOrdenServicio), int.Parse(grdSolicitudesInsumos.Columns["codSolicitud"].Text.Trim()));
                solicitudInsumosTableAdapter1.FillByCodOrdenServicio(dsSpx1.solicitudInsumos, int.Parse(codOrdenServicio));
            }
        }
        #endregion

        #region ordenes de prestamo
        private void btnImprimirOrdenPrestamo_Click(object sender, EventArgs e)
        {
            if (grdOrdenPrestamo.Columns["codOrdenPrestamo"].Text.Trim() == string.Empty)
            {
                return;
            }
            int codOrden = int.Parse(grdOrdenPrestamo.Columns["codOrdenPrestamo"].Value.ToString());
            ordenPrestamo.frmNuevaOrdenPrestamo.imprimirOrdenPrestamo(codOrden);
        }

        private void btnActualizarOrdenPrestamo_Click(object sender, EventArgs e)
        {
            pltOrdenPrestamoTableAdapter1.FillByCodOrdenServicio(dsPlantillas1.pltOrdenPrestamo, int.Parse(codOrdenServicio));
        }

        private void btnSolicitarOrdenPrestamo_Click(object sender, EventArgs e)
        {
            bool tienePermiso = false;
            tienePermiso = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1079);
            tienePermiso = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1080) || tienePermiso;
            if (!tienePermiso)
            {
                MessageBox.Show("No tiene permisos suficientes para ejecutar esta accion");
                return;
            }
            //lanzamos la ventana de ordenes de prestamo 
            ordenPrestamo.frmSolicitarPrestamo frmOP = new ordenPrestamo.frmSolicitarPrestamo();
            frmOP.codOrdenServicio = int.Parse(codOrdenServicio);
            if (frmOP.ShowDialog() == DialogResult.OK)
            {
                pltOrdenPrestamoTableAdapter1.FillByCodOrdenServicio(dsPlantillas1.pltOrdenPrestamo, int.Parse(codOrdenServicio));
                //cambiamos el estado de la orden de servicio
                ordenServicioTableAdapter1.UpdateEstado("ENESP", int.Parse(codOrdenServicio));
                cargarDatos(tabControl1.SelectedTab.Text);
                ajustarBotones();
            }
        }

        private void btnModificarOrdenPrestamo_Click(object sender, EventArgs e)
        {
            if (grdOrdenPrestamo.Columns["codOrdenPrestamo"].Text.Trim() == string.Empty)
            {
                return;
            }
            int codOrden = int.Parse(grdOrdenPrestamo.Columns["codOrdenPrestamo"].Value.ToString());

            ordenPrestamo.frmNuevaOrdenPrestamo frmOP = new spProcesos.ordenPrestamo.frmNuevaOrdenPrestamo();
            frmOP.CodOrdenPrestamo = codOrden;
            frmOP.CodOrdenServicio = int.Parse(codOrdenServicio);
            if (frmOP.ShowDialog() == DialogResult.OK)
            {
                pltOrdenPrestamoTableAdapter1.FillByCodOrdenServicio(dsPlantillas1.pltOrdenPrestamo, int.Parse(codOrdenServicio));
            }
        }

        private void btnEliminarOrdenPrestamo_Click(object sender, EventArgs e)
        {
            if (grdOrdenPrestamo.Columns["codOrdenPrestamo"].Text.Trim() == string.Empty)
            {
                return;
            }
            if (!SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1010))
            {
                MessageBox.Show("No tiene los permisos necesarios para ejecutar esta accion!!!!");
                return;
            }
            int codOrden = int.Parse(grdOrdenPrestamo.Columns["codOrdenPrestamo"].Value.ToString());
            //la orden de prestamo no se puede eliminar solo anular.
            if (MessageBox.Show("Esta seguro de anular esta orden de prestamo?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
               == DialogResult.Yes)
            {
               ordenPrestamoTableAdapter1.UpdateAnular(SPXSeguridad.logica.sesion.LoginUsuarioAutenticado, true, codOrden);
               ordenPrestamoTableAdapter1.UpdateEstado(8, codOrden);
                pltOrdenPrestamoTableAdapter1.FillByCodOrdenServicio(dsPlantillas1.pltOrdenPrestamo, int.Parse(codOrdenServicio));
            }
        }
        #endregion

        private bool actualizarEstadosEnEspera()
        {
            string est = cmbEstado.SelectedValue.ToString().Trim();
            //esto solo aplica cuando la orden esta en estado programada.
            if (est != "PROGR" && est != "EJECU" && est != "ENESP") return false;
            bool cambiaEstado = false;
            bool actualizo = false;
            //miramos si la orden de servicio tiene ordenes de prestamo abiertas.
            int cantidad = int.Parse(ordenPrestamoTableAdapter1.verPendientes(int.Parse(codOrdenServicio)).ToString());
            if (cantidad > 0) cambiaEstado = true;
            //miramos si la orden de servicio tiene solicitudes de insumos abiertas.
            cantidad = int.Parse(solicitudInsumosTableAdapter1.verSolicitudesPendientes(int.Parse(codOrdenServicio)).ToString());
            if (cantidad > 0) cambiaEstado = true;
            //si tiene acciones pendientes cambia el estado de la orden a enespera, si no tiene 
            if (cambiaEstado)
            {
                actualizo = true;
                ordenServicioTableAdapter1.UpdateEstado("ENESP", int.Parse(codOrdenServicio));
            }
            else if (est == "ENESP")
            {
                //miramos si es en ejecucion o programda
                actividadxordenServicioTableAdapter1.FillBycodOrdenServicio(dsSpx1.actividadxordenServicio, int.Parse(codOrdenServicio));
                int actividades = dsSpx1.actividadxordenServicio.Rows.Count;
                if (actividades > 0)
                {
                    actualizo = true;
                    ordenServicioTableAdapter1.UpdateEstado("EJECU", int.Parse(codOrdenServicio));
                }
                else
                {
                    actualizo = true;
                    ordenServicioTableAdapter1.UpdateEstado("PROGRA", int.Parse(codOrdenServicio));
                }
            }
            return actualizo;
        }

        #region cambios de estados

        private void btnAnular_Click(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            //MODIFICAMOS EL ESTADO DE LA ORDEN Y ACTUALIZAMOS LOS CONTROLES
            DialogResult dr = MessageBox.Show("Esta seguro de anular esta orden de servicio?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr != DialogResult.Yes) return;
            ordenServicioTableAdapter1.UpdateAnulada(n, SPXSeguridad.logica.sesion.LoginUsuarioAutenticado, "ANULA", int.Parse(codOrdenServicio));
            cargarDatos(tabControl1.SelectedTab.Text);
            #region liberamos la orden de servicio de la entrada
            Nullable<int> enteroNullo = new Nullable<int>();
            int numeroEntrada = 0;
            if (!dsSpx1.ordenServicio[0].IsnumEntradaNull())
                numeroEntrada = dsSpx1.ordenServicio[0].numEntrada;
            ordenServicioTableAdapter1.UpdatenumEntrada(enteroNullo, int.Parse(codOrdenServicio));
            entradaSalidaEquiposTableAdapter1.UpdateCodOrdenServicio(enteroNullo, numeroEntrada);
#endregion
            #region zona de contratos
            spProcesos.ordenesTrabajo.cls.osController os = new cls.osController();
            os.desVincularOrdenContrato( int.Parse( codOrdenServicio));
            #endregion
            ajustarBotones();
            ajustarControles();
            //notificamos
            #region zona de notificacion
            //CgSmtpEmailSender.core.clsSender mailsender = new CgSmtpEmailSender.core.clsSender();
            //mailsender.EjecutarAccion(5, cmbIngeniero.SelectedValue.ToString(), (System.Data.DataRow)dsSpx1.ordenServicio[0], null, CgSmtpEmailSender.core.clsSender.prioridad.media,"","");
            #endregion
        }

        private void btnReasignar_Click(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            if (cmbIngeniero.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Para reasignar una orden de servicio debe estar asignada a un usuario!");
                return;
            }
            if (!per_reasignaOrden)
            {
                MessageBox.Show("No tiene permisos para hacer esta accion");
                return;
            }

            DialogResult dr = MessageBox.Show("Esta seguro de reasignar esta orden de servicio?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr != DialogResult.Yes) return;
            //cargamos una ventana donde puede escoger el nuevo ingeniero
            frmEscogeIngenero frmIng = new frmEscogeIngenero();
            frmIng.Icon = this.Icon;
            //asignamos el ingeniero que actualmente tiene asignado
            frmIng.LoginActual = cmbIngeniero.SelectedValue.ToString();
            if (frmIng.ShowDialog() == DialogResult.OK)
            {
                //INSERTAMOS LA REASIGNACION
                int codR = reasignacionOrdenesTrabajoTableAdapter1.verSiguienteId(int.Parse(codOrdenServicio)).Value;
                reasignacionOrdenesTrabajoTableAdapter1.Insert(int.Parse(codOrdenServicio), codR,
                    dsSpx1.ordenServicio[0].asignadoA, frmIng.LoginNuevo,n, frmIng.motivoReasignacion,
                    SPXSeguridad.logica.sesion.LoginUsuarioAutenticado);
                //actualizamos la orden de servicio
                ordenServicioTableAdapter1.UpdateAsignacion(frmIng.LoginNuevo, int.Parse(codOrdenServicio));
                cmbIngeniero.SelectedValue = frmIng.LoginNuevo;
                reasignacionOrdenesTrabajoTableAdapter1.FillByCodOrdenServicio(dsSpx1.reasignacionOrdenesTrabajo, int.Parse(codOrdenServicio));
                #region zona de notificaciones de email
                //CgSmtpEmailSender.core.clsSender mailsender = new CgSmtpEmailSender.core.clsSender();
                //mailsender.EjecutarAccion(6, frmIng.LoginNuevo, (System.Data.DataRow)dsSpx1.ordenServicio[0], null, CgSmtpEmailSender.core.clsSender.prioridad.media,"","");
                //mailsender.EjecutarAccion(7, frmIng.LoginActual, (System.Data.DataRow)dsSpx1.ordenServicio[0], null, CgSmtpEmailSender.core.clsSender.prioridad.media,"","");
                #endregion
                if (cmbIngeniero.SelectedValue != null && cmbIngeniero.SelectedValue.ToString().Trim() != string.Empty)
                    notificacionTableAdapter1.Insert(cmbIngeniero.SelectedValue.ToString(), "Orden de servicio reasignada.",
                        "La orden de servicio " + codOrdenServicio + " se reasigno recientemente, " + cmbTipoServicio.Text + " " + txtModelo.Text);
            
            }
        }


        private void btnCambiarInformacionAceptacionCliente_Click(object sender, EventArgs e)
        {
            cambiarInformacionAceptacion();
        }

        private void btnCerrarOrden_Click(object sender, EventArgs e)
        {
            //solo la puede cerrar si es el mismo ingeniero o si es el que tiene todos los permisos
            if (per_modificaOrden || per_cierraOrden || SPXSeguridad.logica.sesion.LoginUsuarioAutenticado.Trim() == cmbIngeniero.SelectedValue.ToString().Trim())
            {

                DialogResult dr = MessageBox.Show("Esta seguro de cerrar esta orden de servicio?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                
                
                if (dr != DialogResult.Yes) return;

                SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
                SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter osTa = new SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter();
                guardarAntigua();
                osTa.FillByCodOrdenServicio(ds.ordenServicio, int.Parse(codOrdenServicio));
                if (ds.ordenServicio[0].IsmantenimientoSegunIndicacionesNull())
                {
                    MessageBox.Show("Debe especificar si el mantenimiento se realizo segun las indicaciones!");
                    return;
                }

                if (ds.ordenServicio[0].Isequipo_adecuadoNull())
                {
                    MessageBox.Show("Debe especificar si el equipo es adecuado!");
                    return;
                }

                //ahora miramos si ya tiene ingresadas actividades realizadas
                actividadxordenServicioTableAdapter1.FillBycodOrdenServicio(dsSpx1.actividadxordenServicio, int.Parse(codOrdenServicio));
                if (dsSpx1.actividadxordenServicio.Rows.Count <= 0)
                    dr = MessageBox.Show("Hasta el momento no tiene actividades ingresadas a la orden.\nDesea cerrarla de todos modos?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr != DialogResult.Yes) return;
                SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
                DateTime n = dc.fechaServer;
                //validamos las variables de medicion


                if (rdAdecuado.Checked)
                {
                    if (!validarVariablesMedicion(true))
                    {
                        return;
                    }
                }
                /*
                 para el mantenimiento preventivo  es importante que diligencia minimo las variables configuradas como obligatorias para poder cerrar la orden.
                 */
                tipoServicioTableAdapter1.FillBycodTipoServicio(ds.TipoServicio, ds.ordenServicio[0].codTiposervicio);
                if (!ds.TipoServicio[0].IspreventivoNull() && ds.TipoServicio[0].preventivo)
                {
                    string sql = @"select distinct variables_medicion.* from equipos 
 join variables_medicionxmodelo on variables_medicionxmodelo.codFabricante = equipos.codFabricante and variables_medicionxmodelo.codModelo = equipos.codModelo 
and variables_medicionxmodelo.obligatorio_preventivo=1
   join variables_medicion on variables_medicionxmodelo.cod_variables_medicion = variables_medicion.cod_variables_medicion
 where serial ='" + txtSerial.Text+@"'
 and variables_medicion.cod_variables_medicion not in(
   select cod_variables_medicion   from  
	   variables_medicionxorden_servicio 
	   join sub_variable_medicion on sub_variable_medicion.cod_sub_variables_medicion = variables_medicionxorden_servicio.cod_sub_variable_medicion
	   where variables_medicionxorden_servicio.codOrdenServicio = " + codOrdenServicio + "   )";
                //---
                    System.Data.DataTable tb = dc.ejecutarConsulta(sql).Tables[0];
                    if (tb.Rows.Count > 0)
                    {
                        string variables = "";
                        for (int k = 0; k < tb.Rows.Count; k++)
                        {
                            variables += "\n"+tb.Rows[k]["nombre_variables_medicion"].ToString();
                        }
                        MessageBox.Show("Los mantenimientos preventivos para este modelo debe incluir las siguientes variables de medicion que no estan incluidas:"+variables,"Variables incompletas");
                        return ;
                    }
                }

                ordenServicioTableAdapter1.UpdateCerrada(n, SPXSeguridad.logica.sesion.LoginUsuarioAutenticado, "CERRA", int.Parse(codOrdenServicio));
                
                // llenamos la tabla de solicitid de servicios segun el numero de orden 
                solicitudServicioTableAdapter1.FillByCodOrdenServicio(dsSpx1.solicitudServicio, int.Parse(codOrdenServicio));
                int EstadoSolicitud = 0;
                // se hace un try {} catch {} por si no hay ninguna solicitud de servicio asociada con una orden de servicio
                try
                {
                    // Se trae el codigo de la solicitud de servicio
                    EstadoSolicitud =  dsSpx1.solicitudServicio[0].codSolicitudServicio;
                }
                catch { }
                    if (EstadoSolicitud > 0)
                {
                    // Actualiza el estado segun el codigo de la solicitud de servicio
                    solicitudServicioTableAdapter1.UpdatecodEstadoSolicitud(4, EstadoSolicitud);
                }
                    #region miramos si la orden viene de una entrada y actualizamos la fecha
  
                entradaSalidaEquiposTableAdapter1.FillBycodOrdenServicio(dsSpx1.EntradaSalidaEquipos, int.Parse(codOrdenServicio));
                if (dsSpx1.EntradaSalidaEquipos.Count > 0)
                {
                    //primero cambia la fecha de terminacion del mantenimiento de la entrada
                    entradaSalidaEquiposTableAdapter1.UpdateFechaTerminacionMantenimiento(n, dsSpx1.EntradaSalidaEquipos[0].codEntradaSalidaEquipos);
                    #region verificamos si el tipo de servicio me cambia la ubicacion base de datos del equipo

                    bool? permiteCierre = defaultsTableAdapter1.VerTrasladosAutomaticosCierreSalida();

                    if (permiteCierre.HasValue && permiteCierre.Value)
                    {
                        if (
                            !tipoServicioTableAdapter1.GetDataBycodTipoServicio(cmbTipoServicio.SelectedValue.ToString())[0].IsdevuelveTallerNull()
                            &&
                            tipoServicioTableAdapter1.GetDataBycodTipoServicio(cmbTipoServicio.SelectedValue.ToString())[0].devuelveTaller)
                        {
                            //traemos el codigo de la ubicacion de destino
                            string codUbica = defaultsTableAdapter1.verCodUbicacionTallerxDefecto().Trim();
                            string codEstado = defaultsTableAdapter1.verCodEstadoLocalEquipos().Trim();
                            //ahora tramemos la ubicacion de origen
                            spProcesos.Herramientas.frmTrasladosDeEquipos.trasladar(
                              "local", (codUbica.Trim() == string.Empty) ? null : codUbica, txtSerial.Text,
                              "Se cambia La ubicacion Al cerrar la orden de Servicio " + txtNumeroOrdenServicio.Text + "!", false, n, false, "", codEstado);
                            //debemos actualizar la salida
                            entradaSalidaEquiposTableAdapter1.updateSalidaDevolucion(
                                "local", codUbica, codEstado, dsSpx1.EntradaSalidaEquipos[0].codEntradaSalidaEquipos);


                        }
                    }
                        #endregion
                    
                }
                #endregion
                ////hay un nuevo requerimiento de acuerdo a la paremtrizacion de tipo de equipo y de tipo de servicio puede dar un salto mas y quedar aprobado de una vez.
                tipoServicioTableAdapter1.FillBycodTipoServicio(ds.TipoServicio, cmbTipoServicio.SelectedValue.ToString());
                SPControladoraDatos.dsSpxTableAdapters.tipoEquipoTableAdapter tipoEquipoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.tipoEquipoTableAdapter();
                tipoEquipoTableAdapter1.FillBycodTipoEquipo(ds.tipoEquipo, codTipoEquipo);
                if ((!ds.tipoEquipo[0].Isomite_aprobacion_osNull() && ds.tipoEquipo[0].omite_aprobacion_os) || (!ds.TipoServicio[0].Isomite_aprobacion_osNull() && ds.TipoServicio[0].omite_aprobacion_os))
                {
                ////
                    ordenServicioTableAdapter1.UpdateAprobada(n, SPXSeguridad.logica.sesion.LoginUsuarioAutenticado, "APROB", int.Parse(codOrdenServicio));
                    //cambias la fecha del ultimo mantenimiento en el equipo
                    equiposTableAdapter1.UpdateUltimoMantenimiento(dsSpx1.ordenServicio[0].fechaProgramacion, dsSpx1.ordenServicio[0].codTiposervicio,
                        dsSpx1.ordenServicio[0].observacionesIngeniero, txtSerial.Text);
                }


                cargarDatos(tabControl1.SelectedTab.Text);
                ajustarBotones();
                ajustarControles();
                #region zona de notificaciones de email
             //   CgSmtpEmailSender.core.clsSender mailsender = new CgSmtpEmailSender.core.clsSender();
             //   mailsender.EjecutarAccion(2, cmbIngeniero.SelectedValue.ToString(), (System.Data.DataRow)dsSpx1.ordenServicio[0], null, CgSmtpEmailSender.core.clsSender.prioridad.media,"","");
                #endregion
            }
            else
            {
                MessageBox.Show("No tiene suficientes permisos para hacer esta accion.");
            }
        }

        private void btnReabrirOrden_Click(object sender, EventArgs e)
        {
            //solo la puede cerrar si es el mismo ingeniero o si es el que tiene todos los permisos
            if (per_modificaOrden || per_apruebaOrden)
            {
                DialogResult dr = MessageBox.Show("Esta seguro de reabrir esta orden de servicio?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr != DialogResult.Yes) return;
                ordenServicioTableAdapter1.UpdateCerrada(null, null, "PROGR", int.Parse(codOrdenServicio));
                cargarDatos(tabControl1.SelectedTab.Text);
                ajustarBotones();
                ajustarControles();
                #region zona de notificaciones de email
                //CgSmtpEmailSender.core.clsSender mailsender = new CgSmtpEmailSender.core.clsSender();
                //mailsender.EjecutarAccion(3, cmbIngeniero.SelectedValue.ToString(), (System.Data.DataRow)dsSpx1.ordenServicio[0], null, CgSmtpEmailSender.core.clsSender.prioridad.media,"","");
                #endregion
                if (cmbIngeniero.SelectedValue != null && cmbIngeniero.SelectedValue.ToString().Trim() != string.Empty)
                    notificacionTableAdapter1.Insert(cmbIngeniero.SelectedValue.ToString(), "Orden de servicio reabierta.",
                        "La orden de servicio " + codOrdenServicio + " se le reabrio recientemente, " + cmbTipoServicio.Text + " " + txtModelo.Text);
            }
            else
            {
                MessageBox.Show("No tiene suficientes permisos para hacer esta accion.");
            }
        }

        private void btnAprobarOrden_Click(object sender, EventArgs e)
        {
            //solo la puede cerrar si es el mismo ingeniero o si es el que tiene todos los permisos
            if (per_modificaOrden || per_apruebaOrden)
            {
                DialogResult dr = MessageBox.Show("Esta seguro de aprobar esta orden de servicio?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr != DialogResult.Yes) return;
                //miramos si ya tiene la informacion de aceptacion si no la tiene le preguntamos si la quiere ingresar
                if (dsSpx1.ordenServicio[0].IsnombreUsuarioClienteNull() || dsSpx1.ordenServicio[0].nombreUsuarioCliente.Trim() == string.Empty)
                {
                    dr = MessageBox.Show("Esta orden de servicio no tiene informacion de aceptacion\ndesea ingresarla antes de continuar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dr == DialogResult.Yes)
                    {
                        if (!cambiarInformacionAceptacion()) return;
                    }

                }
                SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
                DateTime n = dc.fechaServer;
                ordenServicioTableAdapter1.UpdateAprobada(n, SPXSeguridad.logica.sesion.LoginUsuarioAutenticado, "APROB", int.Parse(codOrdenServicio));
                //cambias la fecha del ultimo mantenimiento en el equipo
                equiposTableAdapter1.UpdateUltimoMantenimiento(dsSpx1.ordenServicio[0].fechaProgramacion, dsSpx1.ordenServicio[0].codTiposervicio,
                    dsSpx1.ordenServicio[0].observacionesIngeniero, txtSerial.Text);
                //aca tambien deberiamos actualizar la fecha del proximo mantenimiento
                frm.frmFechaProximoMantenimiento objProx = new spProcesos.ordenesTrabajo.frm.frmFechaProximoMantenimiento();
                objProx.serialEquipo = txtSerial.Text;
                if (objProx.ShowDialog() == DialogResult.OK)
                {
                    if (objProx.fechaProximomantenimiento == DateTime.MinValue)
                    {
                        Nullable<DateTime> fechaN = new Nullable<DateTime>();
                        equiposTableAdapter1.UpdatefechaProximoMante(fechaN, txtSerial.Text);
                    }
                    else
                        equiposTableAdapter1.UpdatefechaProximoMante(objProx.fechaProximomantenimiento, txtSerial.Text);
                }
                #region miramos si esta orden de servicio es generada por una llamada y si lo es deja la llamada abierta de nuevo
                //solicitudServicioTableAdapter1.FillByCodOrdenServicio(dsSpx1.solicitudServicio,int.Parse( codOrdenServicio));
                //if (dsSpx1.solicitudServicio.Count > 0)
                //{
                //    llamadaSoporteTableAdapter1.FillBycodSolicitud(dsSpx1.LlamadaSoporte, dsSpx1.solicitudServicio[0].codSolicitudServicio);
                //    if (dsSpx1.LlamadaSoporte.Count > 0)
                //    {
                //        llamadaSoporteTableAdapter1.UpdateEstado("ABIER", dsSpx1.LlamadaSoporte[0].idLlamadaSoporte);
                //    }
                //}
                #endregion
                cargarDatos(tabControl1.SelectedTab.Text);
                ajustarBotones();
                ajustarControles();
                #region zona de notificaciones de email
                //CgSmtpEmailSender.core.clsSender mailsender = new CgSmtpEmailSender.core.clsSender();
                //mailsender.EjecutarAccion(4, cmbIngeniero.SelectedValue.ToString(), (System.Data.DataRow)dsSpx1.ordenServicio[0], null, CgSmtpEmailSender.core.clsSender.prioridad.media,"","");
                #endregion
                if (cmbIngeniero.SelectedValue != null && cmbIngeniero.SelectedValue.ToString().Trim() != string.Empty)
                    notificacionTableAdapter1.Insert(cmbIngeniero.SelectedValue.ToString(), "Orden de servicio aprobada.",
                        "La orden de servicio " + codOrdenServicio + " se aprobo recientemente, " + cmbTipoServicio.Text + " " + txtModelo.Text);
            
            }
            else
            {
                MessageBox.Show("No tiene suficientes permisos para hacer esta accion.");
            }
        }
        #endregion

        private void btnLimpiaAsesor_Click(object sender, EventArgs e)
        {
            cmbAsesorComercial.SelectedValue = -1;
        }

        private void btnAgregarRepuesto_Click(object sender, EventArgs e)
        {
            programacion.frmRepuesto frmTmp = new programacion.frmRepuesto();

            if (frmTmp.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    repuestoxOrdenServicioTableAdapter1.Insert(int.Parse(codOrdenServicio), frmTmp.codigoRepuesto, frmTmp.cantidad);
                    pltRepuestosxOrdenServicioTableAdapter1.FillByCodOrdenServicio(dsPlantillas1.pltRepuestosxOrdenServicio, int.Parse(codOrdenServicio));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Asegurese de no ingresar dos veces el mismo codigo de repuesto a la orden de Servicio \n" + ex.Message);
                }
            }
        }

        private void btnModificarRepuesto_Click(object sender, EventArgs e)
        {
            if (grdRepuestos.Columns["codRepuesto"].Text.Trim() == string.Empty)
                return;
            programacion.frmRepuesto fr = new programacion.frmRepuesto();
            fr.codigoRepuesto = grdRepuestos.Columns["codRepuesto"].Text.Trim();
            fr.cantidad = int.Parse(grdRepuestos.Columns["cantidad"].Text.Trim());
            if (fr.ShowDialog() == DialogResult.OK)
            {
                repuestoxOrdenServicioTableAdapter1.Updatecantidad(fr.cantidad, int.Parse(codOrdenServicio), fr.codigoRepuesto);
                pltRepuestosxOrdenServicioTableAdapter1.FillByCodOrdenServicio(dsPlantillas1.pltRepuestosxOrdenServicio, int.Parse(codOrdenServicio));
            }

        }

        private bool cambiarInformacionAceptacion()
        {
            bool respuesta = false;
            if (per_modificaOrden || per_apruebaOrden)
            {
                frmAceptacionCliente frm = new frmAceptacionCliente();
                frm.nombreUsuario = txtUsuarioCliente.Text;
                frm.hotaInicio = cmbHoraLlegadaCliente.Text;
                frm.hotaFin = cmbHoraSalidaCliente.Text;
                frm.minutoInicio = cmbMinutosLlegadaCliente.Text;
                frm.minutoFin = cmbMinSalidaCliente.Text;
                frm.ampmInicio = cmbAmPmLlegadaCliente.Text;
                frm.ampmFin = cmbAmPMSalidaCliente.Text;
                frm.CodOrdenservicio = int.Parse(codOrdenServicio);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    respuesta = true;
                    #region cargamos los controles
                    txtUsuarioCliente.Text = frm.nombreUsuario;

                    if (frm.FechaInicio.Hour > 11 && frm.FechaInicio.Hour < 23)
                        cmbAmPmLlegadaCliente.Text = "PM";
                    else
                        cmbAmPmLlegadaCliente.Text = "AM";

                    if (frm.FechaFin.Hour > 11 && frm.FechaFin.Hour < 23)
                        cmbAmPMSalidaCliente.Text = "PM";
                    else
                        cmbAmPMSalidaCliente.Text = "AM";
                    //vamos con los minutos
                    cmbMinutosLlegadaCliente.Text = frm.FechaInicio.Minute.ToString().PadLeft(2, '0');
                    cmbMinSalidaCliente.Text = frm.FechaFin.Minute.ToString().PadLeft(2, '0');

                    int hora = frm.FechaInicio.Hour;
                    hora %= 12;
                    if (hora == 0) hora = 12;
                    cmbHoraLlegadaCliente.Text = hora.ToString();

                    hora = frm.FechaFin.Hour;
                    hora %= 12;
                    if (hora == 0) hora = 12;
                    cmbHoraSalidaCliente.Text = hora.ToString();
                    #endregion
                    ordenServicioTableAdapter1.updateAceptacion(
                        cmbHoraLlegadaCliente.Text.PadLeft(2, '0') + ":" + cmbMinutosLlegadaCliente.Text + " " + cmbAmPmLlegadaCliente.Text,
                        cmbHoraSalidaCliente.Text.PadLeft(2, '0') + ":" + cmbMinSalidaCliente.Text + " " + cmbAmPMSalidaCliente.Text
                        , txtUsuarioCliente.Text, int.Parse(codOrdenServicio));
                    comprobantesAceptacionOrdenservicioTableAdapter1.FillByCodOrdenServicio(dsSpx1.comprobantesAceptacionOrdenservicio, int.Parse(codOrdenServicio));

                }
            }
            else
            {
                MessageBox.Show("No tiene los permisos necesarios para realizar esta accion!!!");
                respuesta = false;
            }
            return respuesta;
        }


        private void btnQuitarRepuesto_Click(object sender, EventArgs e)
        {
            if (grdRepuestos.Columns["codRepuesto"].Text.Trim() == string.Empty)
                return;

            if (MessageBox.Show("Esta seguro de eliminar este repuesto de la orden", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                != DialogResult.Yes)
            {
                return;
            }


            repuestoxOrdenServicioTableAdapter1.DeleteQuery(int.Parse(codOrdenServicio), grdRepuestos.Columns["codRepuesto"].Text);
            pltRepuestosxOrdenServicioTableAdapter1.FillByCodOrdenServicio(dsPlantillas1.pltRepuestosxOrdenServicio, int.Parse(codOrdenServicio));
        }

        private void calInicioProg_Validated(object sender, EventArgs e)
        {
            calcularHoraFin();
        }

        private void calFinProg_Validating(object sender, CancelEventArgs e)
        {
            //si la hora de fin es menor que la hora de inicio lo devuelve
            if (calFinProg.fechaValueObject != null && calInicioProg.fechaValueObject != null)
            {
                if (calFinProg.fechaValue < calInicioProg.fechaValue)
                {
                    MessageBox.Show("La fecha de Inicio y la fecha de fin no son Coherentes.");
                    e.Cancel = true;
                    return;
                }
                //ahora validamos que el ingeniero no tenga una orden para esta misma fecha
                if (cmbIngeniero.SelectedValue != null && cmbIngeniero.SelectedValue.ToString().Trim() != string.Empty)
                {
                    if (ordenServicioTableAdapter1.validarIngeniero(cmbIngeniero.SelectedValue.ToString(), calInicioProg.fechaValue, calFinProg.fechaValue).Value > 0)
                    {
                        if (MessageBox.Show("El Ingeniero tiene asignada una orden en conflicto para este periodo de tiempo\nDesea Continuar de Todos Modos?", "Alerta", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.No)
                        {
                            e.Cancel = true;
                            return;                        
                        }
                    }
                    //validamos las actividaeds extraodinarias
                    if (actividad_adicionalTableAdapter1.validarIngeniero(cmbIngeniero.SelectedValue.ToString(), calInicioProg.fechaValue, calFinProg.fechaValue).Value > 0)
                    {
                        if (MessageBox.Show("El Ingeniero tiene actividades en conflicto para este periodo de tiempo\nDesea Continuar de Todos Modos?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                        {
                            e.Cancel = true;
                            return;
                        }
                    }
                }
            }
        }

        private void cmbIngeniero_Validating(object sender, CancelEventArgs e)
        {
            //si la hora de fin es menor que la hora de inicio lo devuelve
            if (calFinProg.fechaValueObject != null && calInicioProg.fechaValueObject != null)
            {
               if (cmbIngeniero.SelectedValue != null && cmbIngeniero.SelectedValue.ToString().Trim() != string.Empty)
               {
                    if (ordenServicioTableAdapter1.validarIngeniero(cmbIngeniero.SelectedValue.ToString(), calInicioProg.fechaValue, calFinProg.fechaValue).Value > 0)
                    {
                        if (MessageBox.Show("El Ingeniero tiene asignada una orden en conflicto para este periodo de tiempo\nDesea Continuar de Todos Modos?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                        {
                            e.Cancel = true;
                            return;
                        }
                    }
                }
            }
        }

        private void btnConsultarDisponib_Click(object sender, EventArgs e)
        {
            if (calInicioProg.fechaValueObject == null || calFinProg.fechaValueObject == null)
            {
                MessageBox.Show("Para consultar disponibilidad debe ingresar la fecha de inicio y la fecha de fin estimada.");
                return;
            }

            frm.frmDisponibilidad fr = new spProcesos.ordenesTrabajo.frm.frmDisponibilidad();
            fr.FechaInicio = calInicioProg.fechaValue;
            fr.FechaFin    = calFinProg.fechaValue;
            if(cmbIngeniero.SelectedValue != null)
            fr.ingenieroASignado = cmbIngeniero.SelectedValue.ToString();
            fr.ShowDialog();
        }

        private void cmbTipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        bool vincularContrato = false;
        bool desVincularContrato = false;
        private void cmbTipoServicio_Validated(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            contratosTableAdapter1.FillByContratoActivoEquipo(dsSpx1.contratos, txtSerial.Text,n);
            if (dsSpx1.contratos.Rows.Count <= 0) return;
            //primero miramos si el tipo de servicio es cubierto por el mantenimiento

            if (//(!dsSpx1.contratos[0].IsincluyeCorrectivosNull() && dsSpx1.contratos[0].incluyeCorrectivos) ||
                //la condicion de arriba se comentario por que la validacion debe hacerse solamente cuando el tipo de mantenimiento
                //afecta los mantenimoientos en contrato
                (!tipoServicioTableAdapter1.GetDataBycodTipoServicio(cmbTipoServicio.SelectedValue.ToString())[0].IsvalidoContratoNull() && 
                tipoServicioTableAdapter1.GetDataBycodTipoServicio(cmbTipoServicio.SelectedValue.ToString())[0].validoContrato)
                )
            {
                #region si afecta los contratos
                //miramos si el equipo tiene un contrato activo
                    //miramos que ya no este amarrado a la orden de servicio
                if (codOrdenServicio.Trim() != string.Empty)
                {
                    mantenimientosxContratoTableAdapter1.FillByContratoOrden(dsSpx1.mantenimientosxContrato,
                            int.Parse(codOrdenServicio), dsSpx1.contratos[0].numeroContrato, dsSpx1.contratos[0].codOtroSi);
                }
                    string str="";
                    if(codOrdenServicio.Trim() == string.Empty)str="0";
                    else str= codOrdenServicio;
                    if (dsSpx1.mantenimientosxContrato.Select("codOrdenServicio=" + str + "").Length <= 0)
                    {
                        //miramos cuantos mantenimientos se han echo del equipo por contrato
                        int echos = 0;
                        int incluidos = 0;
                        contratosxEquipoTableAdapter1.FillBySerialNumContratoOtroSi(dsSpx1.contratosxEquipo,
                            txtSerial.Text, dsSpx1.contratos[0].numeroContrato, dsSpx1.contratos[0].codOtroSi);
                        //
                        echos = dsSpx1.contratosxEquipo[0].mantenimientosRealizados;
                        incluidos = dsSpx1.contratosxEquipo[0].mantenimientosxContrato;

                        if (echos >= incluidos)
                        {
                            #region como se han echo mas de los incluidos preguntamos si esta seguro que quiere continuar!
                            //if (MessageBox.Show("El tipo de servicio escogido es valido para mantenimientos incluidos en contrato\n"
                            //    + "El contrato incluye " + incluidos + " mantenimientos de los cuales ya se han realizado " +
                            //    echos + " mantenimientos.\nDesea Continuar con este tipo de servicio? ", "Alerta ", MessageBoxButtons.YesNo, MessageBoxIcon.Stop
                            //    ) != DialogResult.Yes)

                                if (MessageBox.Show("El tipo de servicio escogido es valido para mantenimientos incluidos en contrato\n"
                                + "El contrato incluye " + incluidos + " mantenimientos de los cuales ya se han realizado " +
                                echos + " mantenimientos.\nNo puede vincular esta orden de servicio al contrato, teniendo en cuenta el tipo de servicio. ", "Alerta ", MessageBoxButtons.OK, MessageBoxIcon.Stop
                                ) != DialogResult.Yes)
                            {
                                cmbTipoServicio.Focus();
                                grpPorContrato.Enabled = false;
                                rdContratoNo.Checked = true;
                                txtNumeroContrato.Text = "";
                                return;
                            }
                            #endregion
                        }else{
                            #region en caso de que aplique para contrato verificamos si queda vinculado o no!
                            if (MessageBox.Show("El tipo de servicio escogido es valido para mantenimientos incluidos en contrato\n"
                                 + "El contrato incluye " + incluidos + " mantenimientos de los cuales ya se han realizado " +
                                 echos + " mantenimientos.\nDesea vincular la orden de servicio como mantenimiento del contrato? ", "Alerta ", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                                 ) == DialogResult.Yes)
                            {
                                vincularContrato = true;
                                rdContratoSi.Checked = true;
                                grpPorContrato.Enabled = false;
                                txtNumeroContrato.Text = dsSpx1.contratos[0].numeroContrato.Trim();
                            }else {
                                grpPorContrato.Enabled = false;
                                rdContratoNo.Checked = true;
                                txtNumeroContrato.Text = "";
                            }
                            #endregion
                        }
                    }
                
                #endregion
            }
            else
            {
                #region miramos si tiene un mantenimiento de contrato amarrado y preguntamos si desvincula
                //miramos si el equipo tiene un contrato activo
                contratosTableAdapter1.FillByContratoActivoEquipo(dsSpx1.contratos, txtSerial.Text, n);
                if (dsSpx1.contratos.Rows.Count > 0 && !desVincularContrato)
                {
                    if (codOrdenServicio.Trim() == string.Empty) return;
                    //miramos que ya  este amarrado a la orden de servicio
                    mantenimientosxContratoTableAdapter1.FillBySerial(dsSpx1.mantenimientosxContrato, txtSerial.Text);
                    if (dsSpx1.mantenimientosxContrato.Select("codOrdenServicio=" + codOrdenServicio + "").Length > 0)
                    {
                        //como esta amarrado preguntamos si desvincula el mantenimiento del contrato
                         if (MessageBox.Show("Esta Orden de servicio esta vinculada como mantenimiento de contrato\n"+
                             "el tipo de mantenimiento escogido no es valido para mantenimientos incluidos en contrato\n"
                                + "Desea desvincular El mantenimiento con el Mantenimiento del contrato????"
                                , "Alerta ", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                                ) == DialogResult.Yes)
                            {
                                desVincularContrato=true;
                            }
                         rdContratoNo.Checked = true;
                         txtNumeroContrato.Text = "";
                         grpPorContrato.Enabled = false;
                    }
                }

                #endregion
            }
            
        }

        private void btnVerES_Click(object sender, EventArgs e)
        {
            if (txtNumeroEntrada.Text.Trim() == string.Empty) return;
            spProcesos.ESequipos.frmEntradaSalidaEquipos fr = new spProcesos.ESequipos.frmEntradaSalidaEquipos();
            fr.CodEntradaSalidaEquipos = txtNumeroEntrada.Text;
            fr.Show();
        }

        private void btnInfCliente_Click(object sender, EventArgs e)
        {
            if (txtNitCliente.Text.Trim() == string.Empty) return;
            SpFrm.terceros.frmInfCliente fr = new SpFrm.terceros.frmInfCliente();
            fr.nitCliente = txtNitCliente.Text;
            fr.Show();
        }

        private void btnInfSucursal_Click(object sender, EventArgs e)
        {
            if (txtNitCliente.Text.Trim() == string.Empty) return;
            SpFrm.terceros.frmInfSucursal fr = new SpFrm.terceros.frmInfSucursal();
            fr.NitCliente = txtNitCliente.Text;
            fr.CodSucursal = codSucursal;
            fr.Show();
        }

        private void rdContratoNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarVariableMedicion_Click(object sender, EventArgs e)
        {
            frmSeleccionarVariableMedicion fr = new frmSeleccionarVariableMedicion();
            fr.serial = txtSerial.Text;
            fr.codOrdenServicio = int.Parse(this.codOrdenServicio);
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pltVariablesxOrdenServicioTableAdapter1.FillByCodOrdenServicio(dsPlantillas1.pltVariablesxOrdenServicio, int.Parse(codOrdenServicio));
            }
        }

        private void btnEditarVariableMedicion_Click(object sender, EventArgs e)
        {
            if (grdVariablesMedicion.Columns["cod_variables_medicionxorden_servicio"].Text == string.Empty) return;
            frmSeleccionarVariableMedicion fr = new frmSeleccionarVariableMedicion();
            fr.codOrdenServicio = int.Parse(this.codOrdenServicio);
            fr.serial = txtSerial.Text;
            fr.codVariablexOrden = int.Parse(grdVariablesMedicion.Columns["cod_variables_medicionxorden_servicio"].Text);
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pltVariablesxOrdenServicioTableAdapter1.FillByCodOrdenServicio(dsPlantillas1.pltVariablesxOrdenServicio, int.Parse(codOrdenServicio));
            }
        }

        private void btnEliminarVariableMedicion_Click(object sender, EventArgs e)
        {
            if (grdVariablesMedicion.Columns["cod_variables_medicionxorden_servicio"].Text == string.Empty) return;

            if (MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.confirmacionDelete,SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.tituloConfirmacionDelete,MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try { 
                    SPXdata.BD.DataConector bd=new SPXdata.BD.DataConector();
                    bd.ejecutarComando("delete variables_medicionxorden_servicio where cod_variables_medicionxorden_servicio=" + grdVariablesMedicion.Columns["cod_variables_medicionxorden_servicio"].Text);
                    pltVariablesxOrdenServicioTableAdapter1.FillByCodOrdenServicio(dsPlantillas1.pltVariablesxOrdenServicio, int.Parse(codOrdenServicio));
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.errorDelete + " " + ex.Message);
                }
            }
        }

        private bool validarVariablesMedicion(bool mostrarDialogo) 
        {
            string sql = @" select 
 variables_medicion.nombre_variables_medicion,
 sub_variable_medicion.nombre_subvariable,
 variables_medicionxorden_servicio.resultado_variable,
  variables_medicionxmodelo.rango_inicial,variables_medicionxmodelo.rango_final
  from variables_medicionxorden_servicio 
	
	join(select max(cod_variables_medicionxorden_servicio) id,cod_sub_variable_medicion from variables_medicionxorden_servicio group by cod_sub_variable_medicion ) 
	st on st.id = variables_medicionxorden_servicio.cod_variables_medicionxorden_servicio
	 join ordenServicio on ordenServicio.codOrdenServicio = variables_medicionxorden_servicio.codOrdenServicio
	 join equipos on equipos.serial= ordenServicio.serial
	  join variables_medicionxmodelo on variables_medicionxmodelo.codFabricante = equipos.codFabricante 
	  and variables_medicionxmodelo.codModelo = equipos.codModelo
	    and variables_medicionxmodelo.cod_sub_variables_medicion = variables_medicionxorden_servicio.cod_sub_variable_medicion

		join sub_variable_medicion on variables_medicionxorden_servicio.cod_sub_variable_medicion = sub_variable_medicion.cod_sub_variables_medicion
		  join variables_medicion on sub_variable_medicion.cod_variables_medicion = variables_medicion.cod_variables_medicion
 where variables_medicionxorden_servicio.codOrdenServicio = " + codOrdenServicio+@"
 and 
 (
 variables_medicionxorden_servicio.resultado_variable < variables_medicionxmodelo.rango_inicial
 or variables_medicionxorden_servicio.resultado_variable > variables_medicionxmodelo.rango_final)";
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            System.Data.DataTable tb= bd.ejecutarConsulta(sql).Tables[0];
            if (tb.Rows.Count == 0) return true;

            if (mostrarDialogo)
            {
                string problemas = "";
                for (int k = 0; k < tb.Rows.Count; k++)
                {
                    problemas += "\n" + tb.Rows[0]["nombre_variables_medicion"] + " (" + tb.Rows[0]["nombre_subvariable"].ToString().Trim() + ") valor:" + tb.Rows[0]["resultado_variable"] + " rango esperado ( " +
                        tb.Rows[0]["rango_inicial"] +" - " + tb.Rows[0]["rango_final"]+")";
                }
                MessageBox.Show("Las siguientes variables de medicion tiene valores fuera lo esperado "+problemas,"Variables de medicion fuera del rango.");
            
            }


            return false;
        }

        private void btnHojaVidaDipositivoMedicion_Click(object sender, EventArgs e)
        {
            if (grddispositivosMedicion.Columns["serial_herramienta"].Text == string.Empty) return;

            if (txtSerial.Text.Trim() == string.Empty) return;
            spProcesos.Equipos.frmInformacionEquipo frm = new spProcesos.Equipos.frmInformacionEquipo();
            frm.Serial = grddispositivosMedicion.Columns["serial_herramienta"].Text;
            frm.ShowDialog();
        }

        private void btnAgregarDispostivoMedicion_Click(object sender, EventArgs e)
        {
            spProcesos.Equipos.frmBuscarEquipo fr = new Equipos.frmBuscarEquipo();
            fr.DispositivosMedicion = true;
            fr.UltimoResponsableVisible = true;
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter ta=new SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter();
                SPControladoraDatos.dsSpx ds=new SPControladoraDatos.dsSpx();
                ta.FillBySerial(ds.equipos,fr.Serial);
                dispositivosmedicionxordenservicioTableAdapter1.Insert(fr.Serial, int.Parse(this.codOrdenServicio),ds.equipos[0].codFabricante.Trim(),ds.equipos[0].codModelo.Trim(),"","","","");
                cargarEquiposMedicionxOrdenServicio();
            }
        }

        private void cargarEquiposMedicionxOrdenServicio() 
        {
            pltDispositivosxOrdenTableAdapter1.FillByCodOrdenServicio(dsPlantillas1.pltDispositivosxOrden, int.Parse(codOrdenServicio));
            
        }

        private void btnQuitarDispositivo_Click(object sender, EventArgs e)
        {
            if (grddispositivosMedicion.Columns["cod_dispositivosmedicionxordenservicio"].Text == string.Empty) return;

            if (MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.confirmacionDelete,SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.tituloConfirmacionDelete,MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try { 
                    SPXdata.BD.DataConector bd=new SPXdata.BD.DataConector();
                    bd.ejecutarComando("delete dispositivosmedicionxordenservicio where cod_dispositivosmedicionxordenservicio='" + grddispositivosMedicion.Columns["cod_dispositivosmedicionxordenservicio"].Text + "' ");
                    cargarEquiposMedicionxOrdenServicio();
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.errorDelete + " " + ex.Message);
                }
            }
        }

        private void btnVerRangos_Click(object sender, EventArgs e)
        {
            if (grdVariablesMedicion.Columns["cod_sub_variable_medicion"].Text == string.Empty) return;
            string sql = "select codFabricante,codModelo from equipos where serial='"+txtSerial.Text.Trim()+"' ";
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            System.Data.DataTable tbmodelo=  bd.ejecutarConsulta(sql).Tables[0];


            string select = @"select rango_inicial,rango_final,unidades  from variables_medicionxmodelo where cod_sub_variables_medicion =" +
                grdVariablesMedicion.Columns["cod_sub_variable_medicion"].Text + @" and codFabricante ='" + tbmodelo.Rows[0]["codFabricante"].ToString().Trim()
                + "' and codModelo='" + tbmodelo.Rows[0]["codModelo"].ToString().Trim() + "'";
            System.Data.DataTable tb = bd.ejecutarConsulta(select).Tables[0];
            if (tb.Rows.Count == 0)
            {
                MessageBox.Show("el modelo no tiene rangos configurados para esta variable.");
                return;
            }

            MessageBox.Show("Rangos configurado: (" + tb.Rows[0]["rango_inicial"].ToString().Trim() + " - " + tb.Rows[0]["rango_final"].ToString().Trim() + ") " + tb.Rows[0]["unidades"].ToString().Trim() + "");
        }

        private void grdVariablesMedicion_FetchRowStyle(object sender, C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs e)
        {
            string al = grdVariablesMedicion[e.Row, 10].ToString();
            if (al.Trim() != string.Empty)
            {
                e.CellStyle.BackColor = Color.Pink;
            }
        }

        private void grdVariablesMedicion_AfterSort(object sender, C1.Win.C1TrueDBGrid.FilterEventArgs e)
        {
            grdVariablesMedicion.Refresh();
        }

        private void btnAgregarDispositivoMedicionExterno_Click(object sender, EventArgs e)
        {
            frmAgregarDispositivoMedicionExterno fr = new frmAgregarDispositivoMedicionExterno();
            fr.codOrdenServicio= int.Parse( codOrdenServicio);
            
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                cargarEquiposMedicionxOrdenServicio();
            }
        }

        private void btnGenerarExcel_Click(object sender, EventArgs e)
        {
            if (codOrdenServicio.Trim() == string.Empty) return;
            if (grdSolicitudesInsumos.Columns["codSolicitud"].Text.Trim() == string.Empty) return;
            string sql = @"select 
solicitudInsumos.numeroFactura,solicitudInsumos.codOrdenServicio, 
solicitudInsumos.codSolicitud, solicitudInsumos.aceptada, 
solicitudInsumos.aprobadaPor, solicitudInsumos.fechaAprobacion, 
solicitudInsumos.numeroFactura, solicitudInsumos.fechaSolicitud,
solicitudInsumos.horasDiagnostico, 
solicitudInsumos.horasMantPreventivo, 
solicitudInsumos.horasMantCorrectivo, solicitudInsumos.tiempoEstimadoEntrega, solicitudInsumos.observaciones as obsSolicitudInsumos,
usuAprobo.nombre as 'usuarioAprobo',dbo.repuestos.precio,repuestos.descripcion as 'repuestoDes',
detalleSolicitudInsumos.codRepuesto,detalleSolicitudInsumos.cantidad,
ordenServicio.codOrdenServicio, ordenServicio.fechaCreacion, ordenServicio.fechaProgramacion,
ordenServicio.fechaFinProgramacion, ordenServicio.esInterno, ordenServicio.serial,
ordenServicio.numentrada, ordenServicio.asignadoA 'loginIngeniero', ordenServicio.observaciones,
tipoServicio.nombreTipoServicio,usuario.nombre,
fabricante.nombre_fabricante,modelos.nombreModelo,
clientes.nombreCliente,clientes.nitcliente,
sucursalCliente.nombreSucursal,sucursalCliente.direccion,sucursalCliente.telefono1 as telefonoSucursal
,paises.nombrePais,departamento.nombredepartamento,ciudades.nombreciudad,
sentencia.nombreContacto,sentencia.apellidosContacto,sentencia.docContacto,
sentencia.tituloContacto,sentencia.telefono1,sentencia.celular,

ModalidadEquipo.nombreModalidadEquipo,
subtipoEquipo.nombreSubTipo,tipoequipo.nombreTipoEquipo

-----------
from 
solicitudInsumos
left join detalleSolicitudInsumos on 
detalleSolicitudInsumos.codOrdenServicio = solicitudInsumos.codOrdenServicio
and 
detalleSolicitudInsumos.codSolicitud = solicitudInsumos.codSolicitud
left join repuestos on repuestos.codRepuesto = detalleSolicitudInsumos.codRepuesto
join 
ordenServicio on ordenServicio.codOrdenServicio =  solicitudInsumos.codOrdenServicio
join tipoServicio on ordenServicio.codTipoServicio = dbo.TipoServicio.codTipoServicio
join usuario on asignadoA=usuario.login
left join usuario usuAprobo  on solicitudInsumos.aprobadaPor =usuAprobo.login

join equipos on equipos.serial = ordenServicio.serial
join ModalidadEquipo on equipos.codModalidadEquipo =ModalidadEquipo.codModalidadEquipo
join fabricante on fabricante.codFabricante = equipos.codFabricante
join modelos on modelos.codFabricante = equipos.codfabricante and modelos.codModelo = equipos.codModelo 
join tipoequipo on tipoequipo.codtipoEquipo=modelos.codtipoEquipo
join subtipoequipo on subtipoEquipo.codTipoEquipo = modelos.codTipoEquipo
and subtipoEquipo.codSubTipoEquipo = modelos.codSubTipoEquipo 
--informacion del cliente  
join clientes on clientes.nitcliente = equipos.nitClienteUbica
join sucursalCliente on sucursalCliente.nitcliente = equipos.nitClienteUbica and sucursalCliente.codsucursal = equipos.codsucursalUbica
join paises on paises.codPais = sucursalCliente.codPais
join departamentos departamento on departamento.codPais = sucursalCliente.codPais
and departamento.codDepartamento = sucursalCliente.codDepartamento
join ciudades on ciudades.codPais = sucursalCliente.codPais
and ciudades.codDepartamento = sucursalCliente.codDepartamento and ciudades.codCiudad = sucursalCliente.codCiudad
join 

--este join es para elegir el contacto del cliente o el de la sucursal
(
select  codContacto,nitCliente,nombreContacto,apellidosContacto,docContacto,tituloContacto,telefono1,celular from contactosClientes
union
select '' as codContacto,nitCliente,nombreContactoPrincipal,apellidosContacto,docContacto,tituloContacto,telefono1,celular from clientes
) sentencia 
on 
sentencia.nitCliente = equipos.nitClienteUbica and 
(
(dbo.sucursalCliente.codContacto is null and sentencia.codcontacto ='')
 or 
(dbo.sucursalCliente.codContacto is not null  and dbo.sucursalCliente.codContacto = sentencia.codContacto)
)


where solicitudInsumos.codOrdenServicio = "+CodOrdenServicio+" and solicitudInsumos.codSolicitud = "+grdSolicitudesInsumos.Columns["codSolicitud"].Text.Trim();
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            dsPlantillas1.EnforceConstraints = false;
            dsPlantillas1.pltExportarInsumos.Clear();
            dsPlantillas1.pltExportarInsumos.Merge(bd.ejecutarConsulta(sql).Tables[0]) ;
           SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel objXls = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();


           objXls.exportar(grdExpotarReportesInsumos, "Solicitudes de Insumos", false);
        }
    }
}
