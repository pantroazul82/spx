using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using System.IO;

namespace spProcesos.solicitudes
{
    public partial class frmSolicitudServicio : Form
    {
        public frmSolicitudServicio()
        {
            InitializeComponent();
        }

        public bool mostrarDialogo = false;
        int codSolicitud = 0;
        public int CodSolicitud { set { codSolicitud = value; } get { return codSolicitud; } }

        int codLlamada = 0;
        public int CodLlamada { set { codLlamada = value; } get { return codLlamada; } }

#region zona de permisos y opciones de botones
        private bool per_creaSolicitud = false;
        private bool per_aceptaSolicitud = false;
        private bool per_modificaSolicitud = false;//este permite modificar la orden en cualquier estado de la misma

        private string codigoModalidad = "";
        string codSucursal = "";
        
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
            ocultarBoton(btnRechazar, estado);
            ocultarBoton(btnGuardar, estado);
            ocultarBoton(btnImprimir, estado);
        }

        private void cargarPermisos()
        {
            per_creaSolicitud = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1078);
            per_modificaSolicitud = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1078);

            per_aceptaSolicitud = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1030);
            if(!per_aceptaSolicitud)
                per_aceptaSolicitud = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1003);
        }
       
        /// <summary>
        /// Esta funcion permite que todos los controles sean editables esta se invoca antes de ajustarcontroles automaticamente
        /// </summary>
        private void resetearControles() 
        {
            #region Informacion General
            //rdAceptada.Enabled = true;
            //rdRechazada.Enabled = true;
            //txtSerial.ReadOnly = false;
            //btnBuscarSerial.Enabled = true;
            //cmbTipoServicio.Enabled = true;
            //cmbPrioridad.Enabled = true;
            //calOrdenTrabajo.Enabled = true;
            //cmbHora.Enabled = true;
            //cmbMinuto.Enabled = true;
            //cmbAmPm.Enabled = true;
            //cmbHoraFin.Enabled = true;
            //cmbMinutoFin.Enabled = true;
            //cmbAmPmFin.Enabled = true;
            //cmbIngeniero.Enabled = true;
            //btnLimpiarIngeniero.Enabled = true;
            //txtObservacionesIniciales.ReadOnly = false;
            #endregion
        }
        
        /// <summary>
        /// Esta funcion habilita y deshabilita los controles que se pueden o no modificar, incluyendo los botones segundarios
        /// cada uno de estos botonoes se habilitan o deshabilitan dependiendo los permisos del usuario y el estado de la orden de servicio
        /// </summary>
        private void ajustarControles()
        {
            //resetearControles();
            int est = int.Parse(cmbEstado.SelectedValue.ToString());
            #region Estado Nueva
            //si es nueva puede modficar todo
            if (est==1) 
            {
           //
            }
           #endregion
            #region Estado En Proceso y Estado Rechazada
            else if (est == 2 || est ==3)
            {
                pnlAceptacion.Visible = true;
                if (rdAceptada.Checked)
                    pnlOrdenServicio.Visible = true;
                //si no tiene el super permiso de modificar la solicitud bloquea todos los controles
                if (!per_modificaSolicitud)
                { 
                    cmbPrioridad.Enabled=false;
                    cmbTipoServicio.Enabled=false;
                    cmbAsesorComercial.Enabled=false;
                    btnLimpiarAsesor.Enabled=false;
                    cmbMedio.Enabled=false;
                    calSugerida.Enabled=false;
                    txtObservacionesIniciales.Enabled=false;
                    txtSerial.Enabled=false;
                    btnBuscarSerial.Enabled = false;
                }
            }
            #endregion
            #region Estado CERRADA
            else if (est == 4)
            {
                    pnlAceptacion.Visible = true;
                if (rdAceptada.Checked)
                    pnlOrdenServicio.Visible = true;
                    cmbPrioridad.Enabled=false;
                    cmbTipoServicio.Enabled=false;
                    cmbAsesorComercial.Enabled=false;
                    btnLimpiarAsesor.Enabled=false;
                    cmbMedio.Enabled=false;
                    calSugerida.Enabled=false;
                    txtObservacionesIniciales.Enabled=false;
                    txtSerial.Enabled=false;
                    btnBuscarSerial.Enabled = false;
            }
            #endregion      
        }

        /// <summary>
        /// ajusta los botones principales  de acuerdo a los permisos y estado de la orden de servicio
        /// </summary>
        private void ajustarBotones() 
        {
#region si es nueva
            if (codSolicitud == 0)
            {
                ocultarBotones(true);
                ocultarBoton(btnGuardar, false);
                pnlAceptacion.Visible = false;
                pnlOrdenServicio.Visible = false;
            }
#endregion
            //si no es nueva ya debe tener la informacion en el dataset
            if (dsSpx1.solicitudServicio.Rows.Count <= 0) return;
            int estado = dsSpx1.solicitudServicio[0].codEstadoSolicitud;
            #region zona nueva, ya fue creada perviamente y ahora la van a modificar.
            if (estado == 1) 
            { 
                ocultarBotones(true);
                ocultarBoton(btnGuardar, false);
                ocultarBoton(btnImprimir, false);
                if (per_aceptaSolicitud) 
                {
                    ocultarBoton(btnAceptar, false);
                    ocultarBoton(btnRechazar, false);
                }
            }
            #endregion
            #region zona aceptada o rehazasa
            else if (estado == 2 || estado==3)
            {
                ocultarBotones(true);
                ocultarBoton(btnGuardar, false);
                ocultarBoton(btnImprimir, false);
            }
            #endregion
            #region zona cerrada
            else if (estado == 4)
            {
                ocultarBotones(true);
                ocultarBoton(btnImprimir, false);
            }
            #endregion
        }

        /// <summary>
        /// Este metodo toma la informacion que esta en el dataset y la pasa a los controles.
        /// </summary>
        private void cargarDatos()
        {
            //carga los datos dependiendo cual es el tab activo
            solicitudServicioTableAdapter1.FillBycodSolicitudServicio(dsSpx1.solicitudServicio, codSolicitud);
            #region Informacion General
            txtCodSolicitud.Text = codSolicitud.ToString();
            txtSerial.Text = dsSpx1.solicitudServicio[0].serial.ToString();
            cargarserial(txtSerial.Text);
            //Se carga la informacion del cliente en el moment que fue creada la orden.
            
            if(!dsSpx1.solicitudServicio[0].IsaceptadaNull())
            {
                rdAceptada.Checked=dsSpx1.solicitudServicio[0].aceptada;
                rdRechazada.Checked=!dsSpx1.solicitudServicio[0].aceptada;
                txtAceptadaPor.Text = dsSpx1.solicitudServicio[0].aceptadaPor;
                calFechaAceptacion.Value = dsSpx1.solicitudServicio[0].fechaAceptacion;
                //miramos si tiene orden Servicio
                if(!dsSpx1.solicitudServicio[0].IscodOrdenServicioNull()){
                
                    txtCodOrdenServicio.Text= dsSpx1.solicitudServicio[0].codOrdenServicio.ToString();
                   btnVerOs.Visible = true;
                    
                    string str=ordenServicioTableAdapter1.verEstadoOrden(dsSpx1.solicitudServicio[0].codOrdenServicio);
                    cmbEstadoOS.SelectedValue=str;
                    str=cmbEstadoOS.SelectedValue.ToString().Trim().ToUpper();
                    //si el estado de la orden es cerrada la solicitud pasa a estar cerrada
                    if (str == "CERRA" || str == "ANULA")
                    {
                        solicitudServicioTableAdapter1.UpdatecodEstadoSolicitud(4, codSolicitud);
                    }
               }
            }
            
            if(!dsSpx1.solicitudServicio[0].IscodAsesorNull())
            cmbAsesorComercial.SelectedValue= dsSpx1.solicitudServicio[0].codAsesor;

            
            cmbEstado.SelectedValue = dsSpx1.solicitudServicio[0].codEstadoSolicitud;
            if(int.Parse(cmbEstado.SelectedValue.ToString()) > 1 && int.Parse(cmbEstado.SelectedValue.ToString()) < 4)
            {
                    txtSerial.ReadOnly = true;
                    btnBuscarSerial.Visible = false;
            }
            if (!dsSpx1.solicitudServicio[0].IscodMedioSolicitudNull()) cmbMedio.SelectedValue= dsSpx1.solicitudServicio[0].codMedioSolicitud;
            if (!dsSpx1.solicitudServicio[0].IscodPrioridadSolicitudNull()) cmbPrioridad.SelectedValue = dsSpx1.solicitudServicio[0].codPrioridadSolicitud;
            if(!dsSpx1.solicitudServicio[0].IscodTipoServicioNull())cmbTipoServicio.SelectedValue=dsSpx1.solicitudServicio[0].codTipoServicio;
            txtCreadaPor.Text = dsSpx1.solicitudServicio[0].creadaPor;
            txtFallasReportadas.Text= dsSpx1.solicitudServicio[0].fallasReportadas;
            calCreacion.fechaValue=dsSpx1.solicitudServicio[0].fechaCreacion;
            calSugerida.fechaValue=dsSpx1.solicitudServicio[0].fechaSugerida;
            txtObservacionesIniciales.Text= dsSpx1.solicitudServicio[0].objetoServicio;
            txtObservaciones.Text = dsSpx1.solicitudServicio[0].Observaciones;
            #endregion
        }
 #endregion

        private void cargarTablas() 
        {
            asesoresComercialesTableAdapter1.Fill(dsSpx1.asesoresComerciales);
            prioridadSolicitudTableAdapter1.Fill(dsSpx1.prioridadSolicitud);
            estadosSolicitudTableAdapter1.Fill(dsSpx1.estadosSolicitud);
            estadosOrdenServicioTableAdapter1.Fill(dsSpx1.estadosOrdenServicio);
            medioSolicitudTableAdapter1.Fill(dsSpx1.medioSolicitud);
            tipoServicioTableAdapter1.Fill(dsSpx1.TipoServicio);
            cmbAsesorComercial.SelectedValue =-1;
        }
        
        private void frmNuevaOrdenTrabajo_Load(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            dsSpx1.EnforceConstraints = false;
            calFechaAceptacion.MonthCalendar.DisplayMonth = n;
            calProximoMantenimiento.MonthCalendar.DisplayMonth =n;
            calUltimoMantenimiento.MonthCalendar.DisplayMonth =n;

            cargarPermisos();
            cargarTablas();
            ajustarBotones();            
            //miramos si es nueva
            if (codSolicitud ==0 )
            {
                txtCodSolicitud.Text = solicitudServicioTableAdapter1.verNextId().ToString();
                cmbEstado.SelectedValue = "1";
                calCreacion.fechaValue = n;
                txtCreadaPor.Text = SPXSeguridad.logica.sesion.LoginUsuarioAutenticado;
                //miramos si la estan creando desde una llamada y cargamos la informacion del serial
                
                llamadaSoporteTableAdapter1.FillByidLlamadaSoporte(dsSpx1.LlamadaSoporte, codLlamada);
                if (codLlamada != 0)
                {
                    txtSerial.Text = dsSpx1.LlamadaSoporte[0].serial;
                    if (!dsSpx1.LlamadaSoporte[0].IscodAsesorNull()) cmbAsesorComercial.SelectedValue = dsSpx1.LlamadaSoporte[0].codAsesor;
                    cargarserial(txtSerial.Text);
                    btnBuscarSerial.Visible = false;
                    txtSerial.ReadOnly = true;
                    txtObservacionesIniciales.Text = "Asesoria Telefonica ";
                    txtObservaciones.Text = dsSpx1.LlamadaSoporte[0].obsAsesorTelefonico;
                    txtFallasReportadas.Text = dsSpx1.LlamadaSoporte[0].obsCliente;
                }
                
              
               
             }
            else { 
            //cargamos toda la informacion de la base de datos
               cargarDatos();
                ajustarBotones();
                ajustarControles();
                if (!dsSpx1.solicitudServicio[0].Iscod_asesoria_cientificaNull())
                {
                    txtFallasReportadas.ReadOnly = true;
                    txtObservacionesIniciales.ReadOnly = true;
                    btnBuscarSerial.Enabled = false;
                }                
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
            txtSerial.Text = serial;
            //miramos si existe el serial
            vistaEquipoTableAdapter1.FillBySerial(dsSpx1.vistaEquipo,serial);
            //equiposTableAdapter1.FillBySerial(dsSpx1.equipos, serial);
            if (dsSpx1.vistaEquipo.Rows.Count <= 0)
            {
                MessageBox.Show("El equipo con serial " + serial.Trim() + " no existe en la base de datos.");
                return false;
            }

            if (!dsSpx1.vistaEquipo[0].IsfechaProximoManteNull())
                calProximoMantenimiento.Value = dsSpx1.vistaEquipo[0].fechaProximoMante;
            if (!dsSpx1.vistaEquipo[0].IsfechaUltimoManteNull())
                calUltimoMantenimiento.Value = dsSpx1.vistaEquipo[0].fechaUltimoMante;
            txtFabricante.Text = dsSpx1.vistaEquipo[0].nombrefabricante;
            txtModelo.Text = dsSpx1.vistaEquipo[0].nombremodelo;

            //esto es para cargar la modalidad con el cual fue creada la orden de servicio si cambio de modadlidad no trae el actual si no el de ese entonces.
            codigoModalidad = "";
            if (dsSpx1.solicitudServicio.Rows.Count <= 0 || dsSpx1.solicitudServicio[0].serial != txtSerial.Text)
            {
                    txtModalidad.Text = dsSpx1.vistaEquipo[0].nombremodalidadequipo;
                    equiposTableAdapter1.FillBySerial(dsSpx1.equipos, serial);
                    if (!dsSpx1.equipos[0].IscodModalidadEquipoNull()) codigoModalidad = dsSpx1.equipos[0].codModalidadEquipo;
            }
            else
            {
                if (!dsSpx1.solicitudServicio[0].IscodModalidadNull())
                {
                    codigoModalidad = dsSpx1.solicitudServicio[0].codModalidad;
                    txtModalidad.Text = modalidadEquipoTableAdapter1.verNombreModadlidad(codigoModalidad).ToString();
                }
            }
            //esto es para cargar el cliente con el cual fue creada la orden de servicio si cambio no trae el actual si no el de ese entonces.
            string nitCliente = "";
            codSucursal = "";
            if (dsSpx1.solicitudServicio.Rows.Count <= 0 || dsSpx1.solicitudServicio[0].serial != txtSerial.Text)
            {
                nitCliente = dsSpx1.vistaEquipo[0].nitCliente;
                codSucursal = equiposTableAdapter1.veCodSucursalUbica(serial);
            }
            else
            {
                nitCliente = dsSpx1.solicitudServicio[0].nitCliente;
                codSucursal = dsSpx1.solicitudServicio[0].codSucursal;
            }

            clientesTableAdapter1.FillByNitCliente(dsSpx1.clientes, nitCliente);
            txtNitCliente.Text =  dsSpx1.vistaEquipo[0].nitCliente;
            txtNombrecliente.Text = dsSpx1.vistaEquipo[0].nombreCliente;
            txtContactoPrincipal.Text = (dsSpx1.clientes[0].IsnombreContactoPrincipalNull()) ? "" : dsSpx1.clientes[0].nombreContactoPrincipal;
            txtTelefonoCliente.Text = (dsSpx1.clientes[0].Istelefono1Null()) ? "" : dsSpx1.clientes[0].telefono1;
            txtCelularCliente.Text = (dsSpx1.clientes[0].IscelularNull()) ? "" : dsSpx1.clientes[0].celular;
            //informacion de la ubicacion

            sucursalClienteTableAdapter1.FillByCodSucursalNit(dsSpx1.sucursalCliente, nitCliente, codSucursal);
            txtSucursal.Text = dsSpx1.sucursalCliente[0].nombreSucursal;
            txtTelefonoUbicacion.Text = (dsSpx1.sucursalCliente[0].IsTelefono1Null()) ? "" : dsSpx1.sucursalCliente[0].Telefono1;
            txtDireccionUbicacion.Text = (dsSpx1.sucursalCliente[0].IsDireccionNull()) ? "" : dsSpx1.sucursalCliente[0].Direccion;
            if (!dsSpx1.sucursalCliente[0].IscodPaisNull() && !dsSpx1.sucursalCliente[0].IscodDepartamentoNull()
                && !dsSpx1.sucursalCliente[0].IscodCiudadNull())
            {
                txtUbicacion.Text = "(" + paisesTableAdapter1.verNombrePais(dsSpx1.sucursalCliente[0].codPais).ToString().Trim();
                txtUbicacion.Text += ") " + departamentoTableAdapter1.verNombreDepartamento(dsSpx1.sucursalCliente[0].codPais, dsSpx1.sucursalCliente[0].codDepartamento).ToString().Trim();
                txtUbicacion.Text += ", " + ciudadesTableAdapter1.verNombreCiudad(dsSpx1.sucursalCliente[0].codPais, dsSpx1.sucursalCliente[0].codDepartamento, dsSpx1.sucursalCliente[0].codCiudad).ToString().Trim();
            }
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

        private void imprimirOs()
        {
            string ruta = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter objDef = new SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter();
            objDef.Fill(dsSpx1.defaults);
            string strReporte = "rptSolicitudServicio";

            C1.C1Report.C1Report reporte = new C1.C1Report.C1Report();
            reporte.Load(ruta + @"\rpt\rpt.xml", strReporte);
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
    
            if (reporte.Fields.Contains("lblTitulo") && defaultsTableAdapter1.vertituloSolicitud() != null)
            {
                reporte.Fields["lblTitulo"].Value =  defaultsTableAdapter1.vertituloSolicitud().Trim();
            }
            if (reporte.Fields.Contains("lblVersion") && defaultsTableAdapter1.verversionSolicitud() != null)
            {
                reporte.Fields["lblVersion"].Value = defaultsTableAdapter1.verversionSolicitud().Trim();
            }
            if (reporte.Fields.Contains("lblTipoDocumento"))
            {
                if (!dsSpx1.defaults[0].IscodigoSolicitudNull())
                    reporte.Fields["lblTipoDocumento"].Value = dsSpx1.defaults[0].codigoSolicitud.Trim();
            }
            if (reporte.Fields.Contains("lblVigencia"))
            {
                if (!dsSpx1.defaults[0].IsfechaVigenciaSolicitudNull())
                    reporte.Fields["lblVigencia"].Value = dsSpx1.defaults[0].fechaVigenciaSolicitud.ToShortDateString();
            }
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            reporte.DataSource.ConnectionString = objData.CadenaConexionReportes;
            reporte.DataSource.RecordSource = reporte.DataSource.RecordSource.Replace("<<codSolicitud>>", txtCodSolicitud.Text);

            SPControladoraDatos.artefactos.SPXQuery.frm.Reportes.frmReporte  frmRpt = new SPControladoraDatos.artefactos.SPXQuery.frm.Reportes.frmReporte (reporte);
            frmRpt.Icon = this.Icon;

            frmRpt.ShowDialog();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            imprimirOs();
        }

#endregion

        private void btnInfEquipo_Click(object sender, EventArgs e)
        {
            if (txtSerial.Text.Trim() == string.Empty) return;
            spProcesos.Equipos.frmInformacionEquipo frm = new spProcesos.Equipos.frmInformacionEquipo();
            frm.Serial = txtSerial.Text.Trim();
            frm.ShowDialog();
        }

        private bool validar() 
        {

            if (cmbMedio.SelectedValue == null || cmbMedio.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese el medio por el cual fue generada esta Solicitud.");
                return false;
            }
            if (cmbPrioridad.SelectedValue == null || cmbPrioridad.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese la prioridad para esta Solicitud.");
                return false;
            }
            if (cmbTipoServicio.SelectedValue == null || cmbTipoServicio.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese el tipo de servicio para esta Solicitud.");
                return false;
            }
            if (txtSerial.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El equipo es necesario para crear la soliccitud");

                txtSerial.Focus();
                return false;
            }

            return true;
        }

        private void btnLimpiarIngeniero_Click(object sender, EventArgs e)
        {
            cmbAsesorComercial.SelectedValue = "";
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validar()) return;
            Nullable<DateTime> fechaNull= new Nullable<DateTime>();
            Nullable<bool> boolNull= new Nullable<bool>();
            Nullable<int> enteroN= new Nullable<int>();
            Nullable<int> codAse= new Nullable<int>();
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            if(cmbAsesorComercial.SelectedValue != null && cmbAsesorComercial.SelectedValue.ToString().Trim() != string.Empty)
                codAse=int.Parse(cmbAsesorComercial.SelectedValue.ToString());
            if (codSolicitud == 0)
            {
                codSolicitud = (int)solicitudServicioTableAdapter1.verNextId();

                solicitudServicioTableAdapter1.Insert(codSolicitud, n, calSugerida.fechaValue,
                    fechaNull, SPXSeguridad.logica.sesion.LoginUsuarioAutenticado, null, boolNull, txtSerial.Text, txtNitCliente.Text,
                    codSucursal, cmbTipoServicio.SelectedValue.ToString(),( codigoModalidad==string.Empty)?null:codigoModalidad,
                    1, int.Parse(cmbPrioridad.SelectedValue.ToString()), txtObservacionesIniciales.Text,
                    txtFallasReportadas.Text, txtObservaciones.Text, codAse, int.Parse(cmbMedio.SelectedValue.ToString()),
                    enteroN,null);
                solicitudServicioTableAdapter1.FillBycodSolicitudServicio(dsSpx1.solicitudServicio, codSolicitud);
                #region zona de notificacion
                //CgSmtpEmailSender.core.clsSender mailsender = new CgSmtpEmailSender.core.clsSender();
                //mailsender.EjecutarAccion(401, dsSpx1.solicitudServicio[0].creadaPor, (System.Data.DataRow)dsSpx1.solicitudServicio[0], null, CgSmtpEmailSender.core.clsSender.prioridad.media, "", "");
                #endregion
            }else{
                solicitudServicioTableAdapter1.UpdateQuery(
                    dsSpx1.solicitudServicio[0].fechaCreacion, calSugerida.fechaValue,
                    (dsSpx1.solicitudServicio[0].IsfechaAceptacionNull() ? fechaNull : dsSpx1.solicitudServicio[0].fechaAceptacion),
                    dsSpx1.solicitudServicio[0].creadaPor,
                    (dsSpx1.solicitudServicio[0].IsaceptadaPorNull() ? null : dsSpx1.solicitudServicio[0].aceptadaPor),
                    (dsSpx1.solicitudServicio[0].IsaceptadaNull() ? boolNull : dsSpx1.solicitudServicio[0].aceptada),
                        txtSerial.Text, txtNitCliente.Text, codSucursal,
                        cmbTipoServicio.SelectedValue.ToString(),(codigoModalidad == string.Empty)?null: codigoModalidad,
                        int.Parse(cmbEstado.SelectedValue.ToString()), int.Parse(cmbPrioridad.SelectedValue.ToString()),
                        txtObservacionesIniciales.Text, txtFallasReportadas.Text, txtObservaciones.Text, codAse,
                        int.Parse(cmbMedio.SelectedValue.ToString()),
                        (dsSpx1.solicitudServicio[0].IscodOrdenServicioNull() ? enteroN : dsSpx1.solicitudServicio[0].codOrdenServicio),
                        codSolicitud);
                
            }
            if (mostrarDialogo)
            {
                DialogResult = DialogResult.OK;
                Close();
                return;
            }
            cargarDatos();
            ajustarBotones();
            ajustarControles();
            System.Media.SystemSounds.Exclamation.Play();
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!SPXSeguridad.verificadorPermisos.ejecutarAccion(2016) )
            {
                MessageBox.Show("No tiene permisos para hacer esta accion!");
                return;
            }

            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            if (codSolicitud == 0)
            {
                MessageBox.Show("No Puede realizar esta operacion hasta guardar la Solicitud");
                return;
            }
            frmEleccion fr = new frmEleccion();
            DialogResult dg = fr.ShowDialog();
            if (dg == DialogResult.Cancel) return;
            if (dg == DialogResult.Yes)
            {

                spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo frmOs = new spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo();
                frmOs.mostrarDialogo = true;
                frmOs.CodSolicitud = txtCodSolicitud.Text;
                if (frmOs.ShowDialog() != DialogResult.OK)
                    return;
                int tm = 0;
                if (!int.TryParse(frmOs.CodOrdenServicio, out tm)) return;
                int codOS = tm;
                solicitudServicioTableAdapter1.UpdateAceptada(n, SPXSeguridad.logica.sesion.LoginUsuarioAutenticado,
                    true, codSolicitud);
                //actualizamos el codigo de la orden de servicio.
                solicitudServicioTableAdapter1.UpdateCodOrdenServicio(codOS, codSolicitud);
                solicitudServicioTableAdapter1.UpdatecodEstadoSolicitud(2, codSolicitud);
            }
            else if (dg == DialogResult.No)
            {
                frmListadoOrdenesSinSolicitud frm = new frmListadoOrdenesSinSolicitud();
                frm.serial = txtSerial.Text;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    int codOS = frm.codOrdenServicio;
                    solicitudServicioTableAdapter1.UpdateAceptada(n, SPXSeguridad.logica.sesion.LoginUsuarioAutenticado,
                        true, codSolicitud);
                    //actualizamos el codigo de la orden de servicio.
                    solicitudServicioTableAdapter1.UpdateCodOrdenServicio(codOS, codSolicitud);
                    solicitudServicioTableAdapter1.UpdatecodEstadoSolicitud(2, codSolicitud);
                }
                else {
                    return;
                }
            }



            cargarDatos();
            ajustarBotones();
            ajustarControles();
            solicitudServicioTableAdapter1.FillBycodSolicitudServicio(dsSpx1.solicitudServicio, codSolicitud);
            #region zona de notificacion
         //   CgSmtpEmailSender.core.clsSender mailsender = new CgSmtpEmailSender.core.clsSender();
          //  mailsender.EjecutarAccion(402, dsSpx1.solicitudServicio[0].creadaPor, (System.Data.DataRow)dsSpx1.solicitudServicio[0], null, CgSmtpEmailSender.core.clsSender.prioridad.media,"","");
            #endregion
            System.Media.SystemSounds.Exclamation.Play();
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            if (codSolicitud == 0)
            {
                MessageBox.Show("No Puede realizar esta operacion hasta guardar la Solicitud");
                return;
            }
            solicitudServicioTableAdapter1.UpdateAceptada(n, SPXSeguridad.logica.sesion.LoginUsuarioAutenticado,
                false, codSolicitud);
            solicitudServicioTableAdapter1.UpdatecodEstadoSolicitud(3, codSolicitud);
            cargarDatos();
            ajustarBotones();
            ajustarControles();
            solicitudServicioTableAdapter1.FillBycodSolicitudServicio(dsSpx1.solicitudServicio, codSolicitud);
            #region zona de notificacion
         //   CgSmtpEmailSender.core.clsSender mailsender = new CgSmtpEmailSender.core.clsSender();
         //   mailsender.EjecutarAccion(403, dsSpx1.solicitudServicio[0].creadaPor, (System.Data.DataRow)dsSpx1.solicitudServicio[0], null, CgSmtpEmailSender.core.clsSender.prioridad.media,"","");
            #endregion
            System.Media.SystemSounds.Exclamation.Play();
        }

        private void btnVerOs_Click(object sender, EventArgs e)
        {
            if (txtCodOrdenServicio.Text.Trim() != string.Empty)
            {
                spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo fr = new spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo();
                fr.CodOrdenServicio = txtCodOrdenServicio.Text;
                fr.Show();
            }
        }
    }
}
