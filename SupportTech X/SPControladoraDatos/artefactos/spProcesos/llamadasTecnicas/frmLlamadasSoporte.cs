using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.llamadasTecnicas
{
    public partial class frmLlamadasSoporte : Form
    {
        public frmLlamadasSoporte()
        {
            InitializeComponent();
        }

        int codLlamada = 0;
        public int CodLLamada { set { codLlamada = value; } get { return codLlamada; } }
        string nitCliente = "";
        string codContacto = "";
        string codUbicacion = "";
        string codModalidad = "";

        private bool cargarserial(string serial)
        {
            //miramos si existe el serial
            vistaEquipoTableAdapter1.FillBySerial(dsSpx1.vistaEquipo, serial);
            if (dsSpx1.vistaEquipo.Rows.Count <= 0)
            {
                if(serial.Trim() != string.Empty)
                MessageBox.Show("El equipo con serial " + serial.Trim() + " no existe en la base de datos.");
                return false;
            }
            txtModelo.Text = dsSpx1.vistaEquipo[0].nombremodelo+" ("+dsSpx1.vistaEquipo[0].nombrefabricante.Trim()+")";
            if (!dsSpx1.vistaEquipo[0].IsnombremodalidadequipoNull())
                txtModalidad.Text = dsSpx1.vistaEquipo[0].nombremodalidadequipo;
            nitCliente = dsSpx1.vistaEquipo[0].nitCliente;
            txtNombrecliente.Text = dsSpx1.vistaEquipo[0].nombreCliente +" ("+ dsSpx1.vistaEquipo[0].nitCliente.Trim()+")";
             txtSucursal.Text = dsSpx1.vistaEquipo[0].nombreSucursal;
            //cargamos la informacion de la sucursal
             equiposTableAdapter1.FillBySerial(dsSpx1.equipos, serial);
             codUbicacion = dsSpx1.equipos[0].codSucursalUbica;
             if (!dsSpx1.equipos[0].IscodModalidadEquipoNull()) 
            codModalidad = dsSpx1.equipos[0].codModalidadEquipo;
            //  -- //
             if (!dsSpx1.equipos[0].IsfechaProximoManteNull()) calProximoMantenimiento.Value = dsSpx1.equipos[0].fechaProximoMante;
             if (!dsSpx1.equipos[0].IsfechaUltimoManteNull()) calUltimoMantenimiento.Value = dsSpx1.equipos[0].fechaUltimoMante;
             if (dsSpx1.LlamadaSoporte.Rows.Count > 0)
             { 
                //cargamos la informacion que tiene el serial desde la orden 
                 if (serial.Trim() == dsSpx1.LlamadaSoporte[0].serial.Trim())
                 {
                     if (!dsSpx1.LlamadaSoporte[0].IscodModalidadEquipoNull()) codModalidad = dsSpx1.LlamadaSoporte[0].codModalidadEquipo;
                     else codModalidad = "";
                     nitCliente = dsSpx1.LlamadaSoporte[0].nitCliente;
                     codUbicacion = dsSpx1.LlamadaSoporte[0].codUbicacion;
                     //
                     clientesTableAdapter1.FillByNitCliente(dsSpx1.clientes, nitCliente);
                     sucursalClienteTableAdapter1.FillByCodSucursalNit(dsSpx1.sucursalCliente, nitCliente, codUbicacion);
                     modalidadEquipoTableAdapter1.FillBycodModalidadEquipo(dsSpx1.ModalidadEquipo, codModalidad);
                     if (dsSpx1.ModalidadEquipo.Rows.Count > 0)
                     {
                         txtModalidad.Text = dsSpx1.ModalidadEquipo[0].nombreModalidadEquipo;
                     }
                     
                     txtNombrecliente.Text = dsSpx1.clientes[0].nombreCliente + " (" + dsSpx1.clientes[0].nitCliente.Trim() + ")";
                     txtSucursal.Text = dsSpx1.sucursalCliente[0].nombreSucursal;
                 }

             }
            return true;
        }

        private void btnBuscarSerial_Click(object sender, EventArgs e)
        {
            spProcesos.Equipos.frmBuscarEquipo fr = new spProcesos.Equipos.frmBuscarEquipo();

            if (nitCliente.Trim() != string.Empty)
            {
                fr.NitCliente = nitCliente;
            }
            if (fr.ShowDialog() == DialogResult.OK)
            {
                txtSerial.Text = fr.Serial;
                txtSerial.Focus();
                cargarserial(txtSerial.Text);
            }
        }

        private void btnInfEquipo_Click(object sender, EventArgs e)
        {
            if (txtSerial.Text.Trim() == string.Empty) return;
            spProcesos.Equipos.frmInformacionEquipo frm = new spProcesos.Equipos.frmInformacionEquipo();
            frm.Serial = txtSerial.Text.Trim();
            frm.ShowDialog();
        }

        private void llenarTablas()
        {
            asesoresComercialesTableAdapter1.Fill(dsSpx1.asesoresComerciales);
            cmbAsesorComercial.SelectedValue = -1;
            estadosLLamadasTecnicasTableAdapter1.Fill(dsSpx1.estadosLLamadasTecnicas);
            estadosSolicitudTableAdapter1.Fill(dsSpx1.estadosSolicitud);
            clsTusuario1.FillByPermiso(dsSPXSeguridad1.usuario, 1063);
            
            cmbIngeniero.SelectedValue = "";
            cmbEstadoSolicitud.SelectedValue = -1;
            resultado_final_llamadaTableAdapter1.Fill(dsSpx1.resultado_final_llamada);
            tipo_asesoriaTableAdapter1.Fill(dsSpx1.tipo_asesoria);
        }
        bool eventosEncendidos = true;
        private void frmLlamadasSoporte_Load(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            dsSpx1.EnforceConstraints = false;
            calCierre.MonthCalendar.DisplayMonth = n;
            calProximoMantenimiento.MonthCalendar.DisplayMonth = n;
            calUltimoMantenimiento.MonthCalendar.DisplayMonth = n;
            eventosEncendidos = false;
            llenarTablas();

                cmbTipoAsesoria.SelectedIndex = -1;
                cmbResultadoFinal.SelectedIndex = -1;
            if (codLlamada == 0)
            {
                txtCodigoLlamada.Text = llamadaSoporteTableAdapter1.verNextId().Value.ToString();
                txtAtendidaPor.Text = SPXSeguridad.logica.sesion.NombreUsuarioAutenticado;
                cmbEstado.SelectedValue = "ABIER";
                calApertura.fechaValueObject = null;
                calApertura.fechaValue = n;
                
            }else {
                btnBuscarSerial.Visible = false;
                btnBuscarCliente.Visible = false;
                btnBuscarContacto.Visible = false;
                //cargamos la informacion de la llamda
                llamadaSoporteTableAdapter1.FillByidLlamadaSoporte(dsSpx1.LlamadaSoporte, codLlamada);
                seguimientoTableAdapter1.FillByidLlamadaSoporte(dsSpx1.seguimiento, codLlamada);
                indicacionesLLamadasTableAdapter1.FillByidLLamadaSoporte(dsSpx1.indicacionesLLamadas, codLlamada);
                cargarDatos();
            }
            eventosEncendidos = true;
            acomodarBotones();
        }

        private void cargarDatos(){
            if (dsSpx1.LlamadaSoporte.Rows.Count <= 0) return;
            txtAtendidaPor.Text = dsSpx1.LlamadaSoporte[0].asesorTelefonico;
                    
            if(!dsSpx1.LlamadaSoporte[0].IscerradaPorNull()) txtCerradaPor.Text = dsSpx1.LlamadaSoporte[0].cerradaPor;
            if (!dsSpx1.LlamadaSoporte[0].IscodAsesorNull())cmbAsesorComercial.SelectedValue = dsSpx1.LlamadaSoporte[0].codAsesor;

            if (!dsSpx1.LlamadaSoporte[0].Iscod_tipo_asesoriaNull()) cmbTipoAsesoria.SelectedValue = dsSpx1.LlamadaSoporte[0].cod_tipo_asesoria;

            if (!dsSpx1.LlamadaSoporte[0].Iscod_resultado_final_llamadaNull()) cmbResultadoFinal.SelectedValue = dsSpx1.LlamadaSoporte[0].cod_resultado_final_llamada;

                    cmbEstado.SelectedValue =  dsSpx1.LlamadaSoporte[0].codEstadoLLamadaTecnica;
 
                    if(!dsSpx1.LlamadaSoporte[0].IscodSolicitudNull() )txtCodSolicitud.Text =dsSpx1.LlamadaSoporte[0].codSolicitud.ToString();
                     if(!dsSpx1.LlamadaSoporte[0].IsfechaCierreNull())calCierre.Value=  dsSpx1.LlamadaSoporte[0].fechaCierre;
                    if (!dsSpx1.LlamadaSoporte[0].IsfechaLlamadaNull()) calApertura.fechaValue = dsSpx1.LlamadaSoporte[0].fechaLlamada;
                    if (!dsSpx1.LlamadaSoporte[0].IsfechaUltimoSeguimientoNull()) calUltimoSeguimiento.fechaValue = dsSpx1.LlamadaSoporte[0].fechaUltimoSeguimiento;
                    if (!dsSpx1.LlamadaSoporte[0].IsfechaSolucionNull()) calFechaSolcuion.Value = dsSpx1.LlamadaSoporte[0].fechaSolucion;

                    if (!dsSpx1.LlamadaSoporte[0].IsdiasEnSolucionarNull()) txtDiasEnDarSolucion.Text = dsSpx1.LlamadaSoporte[0].diasEnSolucionar.ToString();

                    txtCodigoLlamada.Text= dsSpx1.LlamadaSoporte[0].idLlamadaSoporte.ToString();
                    txtInfAdiContacto.Text= dsSpx1.LlamadaSoporte[0].infAdicionalContacto;
                    if(!dsSpx1.LlamadaSoporte[0].IsingenieroAsesorNull())cmbIngeniero.SelectedValue =dsSpx1.LlamadaSoporte[0].ingenieroAsesor;
                    
                   
                    nitCliente= dsSpx1.LlamadaSoporte[0].nitCliente;
                    txtObservaciones.Text= dsSpx1.LlamadaSoporte[0].obsAsesorTelefonico;
                    txtDescripcionProblema.Text = dsSpx1.LlamadaSoporte[0].obsCliente;
                    txtObservacionesFinales.Text= dsSpx1.LlamadaSoporte[0].obsFinales;
                    txtSerial.Text= dsSpx1.LlamadaSoporte[0].serial;
                    cargarserial(txtSerial.Text);
                    if (!dsSpx1.LlamadaSoporte[0].IssolucionadoNull())
                    {
                        rdSiTelefonica.Checked= dsSpx1.LlamadaSoporte[0].solucionado;
                        rdNoTelefonic.Checked = !dsSpx1.LlamadaSoporte[0].solucionado;
                    }
                    if (!dsSpx1.LlamadaSoporte[0].IscodContactoNull())
                    {
                        codContacto = dsSpx1.LlamadaSoporte[0].codContacto;
                        contactosClientesTableAdapter1.FillBycodContactoNit(dsSpx1.contactosClientes,
                            nitCliente, codContacto);
                        if (dsSpx1.contactosClientes.Rows.Count > 0)
                        {
                            txtNombreContacto.Text = dsSpx1.contactosClientes[0].nombreContacto;
                            txtTelefonoContacto.Text = dsSpx1.contactosClientes[0].telefono1;
                            txtCelularContacto.Text = dsSpx1.contactosClientes[0].celular;
                        }
                    }
            //cargamos la informacion de la solicitud si la tiene
                    if (!dsSpx1.LlamadaSoporte[0].IscodSolicitudNull())
                    {
                        solicitudServicioTableAdapter1.FillBycodSolicitudServicio(dsSpx1.solicitudServicio, dsSpx1.LlamadaSoporte[0].codSolicitud);
                        cmbEstadoSolicitud.SelectedValue = dsSpx1.solicitudServicio[0].codEstadoSolicitud;
                    }
                    else {
                        cmbEstadoSolicitud.SelectedValue = -1;
                    }
        }
        
        private void acomodarBotones() 
        {
        //dependiendo el estado de la llamada muestra y oculta botones
            ocultarBotones(true);
            if (dsSpx1.LlamadaSoporte.Rows.Count <= 0)
            { // si es nueva da la opcion solo de guardar y de cancelar 
              //
            }
            else if (cmbEstado.SelectedValue.ToString().ToUpper().Trim() == "ABIER")
            {
                ocultarBoton(btnImprimir,false);
                ocultarBoton(btnCerrarOrden, false);
                ocultarBoton(btnSolicitarServicio, false);
            }
            else if (cmbEstado.SelectedValue.ToString().ToUpper().Trim() == "CERRA")
            {
                ocultarBoton(btnImprimir, false);
                ocultarBoton(btnReabrirOrden, false);
            }
            else if (cmbEstado.SelectedValue.ToString().ToUpper().Trim() == "SOLGE")
            {
                ocultarBoton(btnImprimir, false);
                ocultarBoton(btnCerrarOrden, false);
            }
        }

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
            ocultarBoton(btnSolicitarServicio, estado);
            ocultarBoton(btnCerrarOrden, estado);
            ocultarBoton(btnReabrirOrden, estado);
            ocultarBoton(btnImprimir, estado);
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            spProcesos.Equipos.frmBuscaCliente fc = new spProcesos.Equipos.frmBuscaCliente();
            if (fc.ShowDialog() == DialogResult.OK)
            {
                if (fc.NitClente != nitCliente)
                {
                    nitCliente = fc.NitClente;
                    txtNombrecliente.Text = fc.NombreClente.Trim() + " (" + fc.NitClente.Trim() + ")";
                    txtSerial.Text = "";
                    cargarserial("");
                }
            }
        }

        private void rdRecibida_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarContacto_Click(object sender, EventArgs e)
        {
            if (nitCliente.Trim() == string.Empty && txtNombrecliente.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Primero debe ingresar el Cliente o el serial del Equipo");
                return;
            }
            spProcesos.Equipos.frmContactosCliente frm2 = new spProcesos.Equipos.frmContactosCliente();
            frm2.NitCliente = nitCliente;
            if (frm2.ShowDialog() == DialogResult.OK)
            {
                codContacto = frm2.CodContacto;
                contactosClientesTableAdapter1.FillBycodContactoNit(dsSpx1.contactosClientes, nitCliente, codContacto);
                txtNombreContacto.Text = dsSpx1.contactosClientes[0].nombreContacto.Trim() + " " + dsSpx1.contactosClientes[0].apellidosContacto;
                txtTelefonoContacto.Text = dsSpx1.contactosClientes[0].telefono1;
                if (!dsSpx1.contactosClientes[0].IscelularNull()) txtCelularContacto.Text = dsSpx1.contactosClientes[0].celular;
            }
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            nitCliente = "";
            codContacto = "";
            txtSerial.Text = "";
            txtNombreContacto.Text = "";
            txtTelefonoContacto.Text = "";
            txtCelularContacto.Text = "";
            txtSucursal.Text = "";
            txtModelo.Text = "";
            txtModalidad.Text = "";
            txtNombrecliente.Text = "";
        }

        private void btnLimpiarAsesor_Click(object sender, EventArgs e)
        {
            cmbAsesorComercial.SelectedValue = -1;
        }

        private void btnLimpiarIng_Click(object sender, EventArgs e)
        {
            cmbIngeniero.SelectedValue = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool validar() 
        {
            if (cmbTipoAsesoria.SelectedValue == null || cmbTipoAsesoria.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Debe Ingresar el tipo de asesoria.");
                return false;
            }
            if (calApertura.fechaValueObject == null)
            {
                MessageBox.Show("Ingrese la fecha de apertura de la llamada");
                return false;
            }
            if (txtSerial.Text.Trim() == string.Empty) 
            {
                MessageBox.Show("El serial del equipo es Obligatorio");
                return false;
            }
            if (codContacto == string.Empty)
            {
                MessageBox.Show("El contacto del cliente es Obligatorio");
                return false;
            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validar()) return;
            if (dsSpx1.LlamadaSoporte.Rows.Count <= 0)
            {
                int id = llamadaSoporteTableAdapter1.verNextId().Value;
                Nullable<DateTime> fechaN = new Nullable<DateTime>();
                Nullable<int> enteroN = new Nullable<int>();
                llamadaSoporteTableAdapter1.Insert(id, cmbEstado.SelectedValue.ToString(), calApertura.fechaValue,
                 false, nitCliente, codUbicacion, codContacto, txtInfAdiContacto.Text, txtSerial.Text,
                 (codModalidad.Trim()== string.Empty)?null:codModalidad,
                 SPXSeguridad.logica.sesion.LoginUsuarioAutenticado,
                 (cmbIngeniero.SelectedValue == null || cmbIngeniero.SelectedValue.ToString().Trim() == string.Empty) ? null : cmbIngeniero.SelectedValue.ToString(),
                 DateTime.Now,
                 (cmbAsesorComercial.SelectedValue == null || cmbAsesorComercial.SelectedValue.ToString().Trim() == string.Empty) ? enteroN : int.Parse(cmbAsesorComercial.SelectedValue.ToString())
                 , txtDescripcionProblema.Text, txtObservaciones.Text, rdSiTelefonica.Checked, txtObservacionesFinales.Text,
                 (calCierre.ValueObject == null) ? fechaN : calCierre.Value, null, enteroN,
                 (calFechaSolcuion.ValueObject == null) ? fechaN : calFechaSolcuion.Value, null, null,
                 int.Parse(cmbTipoAsesoria.SelectedValue.ToString() ),null,2
                 );
                //version llamada 1 o null reporte normal 2 nuevo formato de reporte.
                llamadaSoporteTableAdapter1.FillByidLlamadaSoporte(dsSpx1.LlamadaSoporte, id);
                codLlamada = id;
                llamadaSoporteTableAdapter1.FillByidLlamadaSoporte(dsSpx1.LlamadaSoporte, codLlamada);
                #region zona de notificacion
           //     CgSmtpEmailSender.core.clsSender mailsender = new CgSmtpEmailSender.core.clsSender();
            //    mailsender.EjecutarAccion(501, dsSpx1.LlamadaSoporte[0].asesorTelefonico, (System.Data.DataRow)dsSpx1.LlamadaSoporte[0], null, CgSmtpEmailSender.core.clsSender.prioridad.media, "", "");
                #endregion
            }else {


                Nullable<DateTime> fechaN = new Nullable<DateTime>();
                Nullable<int> enteroN = new Nullable<int>();
                
                llamadaSoporteTableAdapter1.UpdateQuery(
                     cmbEstado.SelectedValue.ToString(), calApertura.fechaValue,
                 false, nitCliente, codUbicacion, codContacto, txtInfAdiContacto.Text, txtSerial.Text,
                   (codModalidad.Trim() == string.Empty) ? null : codModalidad,
                 dsSpx1.LlamadaSoporte[0].asesorTelefonico,
                 (cmbIngeniero.SelectedValue == null || cmbIngeniero.SelectedValue.ToString().Trim() == string.Empty) ? null : cmbIngeniero.SelectedValue.ToString(),
                 DateTime.Now,
                 (cmbAsesorComercial.SelectedValue == null || cmbAsesorComercial.SelectedValue.ToString().Trim() == string.Empty) ? enteroN : int.Parse(cmbAsesorComercial.SelectedValue.ToString())
                 , txtDescripcionProblema.Text, txtObservaciones.Text, rdSiTelefonica.Checked, txtObservacionesFinales.Text,
                 (calCierre.ValueObject == null) ? fechaN : calCierre.Value
                 , (dsSpx1.LlamadaSoporte[0].IscerradaPorNull()) ? null : dsSpx1.LlamadaSoporte[0].cerradaPor
                 , (dsSpx1.LlamadaSoporte[0].IscodSolicitudNull()) ? enteroN : dsSpx1.LlamadaSoporte[0].codSolicitud,
                 int.Parse(cmbTipoAsesoria.SelectedValue.ToString()),
                 codLlamada);
                //--evluamos la fecha de solucion
                if (calFechaSolcuion.ValueObject != null)
                {
                    int diasSolucion = (int)calFechaSolcuion.Value.Subtract(calApertura.fechaValue).TotalDays;
                    llamadaSoporteTableAdapter1.UpdateFechaSolucion(calFechaSolcuion.Value, diasSolucion, codLlamada);
                }
                else {
                    llamadaSoporteTableAdapter1.UpdateFechaSolucion(null, null, codLlamada);
                }
                llamadaSoporteTableAdapter1.FillByidLlamadaSoporte(dsSpx1.LlamadaSoporte, codLlamada);
            }
            acomodarBotones();
            System.Media.SystemSounds.Exclamation.Play();
        }

        private void btnSolicitarServicio_Click(object sender, EventArgs e)
        {
            solicitarServicio();
        }

        private void btnCerrarOrden_Click(object sender, EventArgs e)
        {
            //para cerrar una orden debe tener por lo menos un seguimiento
            seguimientoTableAdapter1.FillByidLlamadaSoporte(dsSpx1.seguimiento, codLlamada);
            if (dsSpx1.seguimiento.Rows.Count <= 0)
            {
                MessageBox.Show("Para Cerrar la Orden debe tener por un Seguimiento.");
                return;
            }
            //tomamos la fecha de solucion
            frmFechaSolucion fr = new frmFechaSolucion();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                calFechaSolcuion.Value = fr.fecha;
                string calcular = ((int)fr.fecha.Subtract(calApertura.fechaValue).TotalDays).ToString();
                if (calcular == "-1")
                {
                    calcular = "0";
                }
                txtDiasEnDarSolucion.Text = calcular;
                llamadaSoporteTableAdapter1.UpdateFechaSolucion(fr.fecha,(int) fr.fecha.Subtract(calApertura.fechaValue).TotalDays, codLlamada);
                llamadaSoporteTableAdapter1.UpdateEstado("CERRA", codLlamada);
                llamadaSoporteTableAdapter1.UpdateCierre(DateTime.Now, SPXSeguridad.logica.sesion.LoginUsuarioAutenticado,fr.resultadoFinal, codLlamada);
                llamadaSoporteTableAdapter1.FillByidLlamadaSoporte(dsSpx1.LlamadaSoporte, codLlamada);
                #region zona de notificacion
               // CgSmtpEmailSender.core.clsSender mailsender = new CgSmtpEmailSender.core.clsSender();
               // mailsender.EjecutarAccion(505, dsSpx1.LlamadaSoporte[0].asesorTelefonico, (System.Data.DataRow)dsSpx1.LlamadaSoporte[0], null, CgSmtpEmailSender.core.clsSender.prioridad.media, "", "");
                #endregion
                cargarDatos();
                acomodarBotones();
            }
        }

        private void btnReabrirOrden_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Esta seguro de reabrir esta orden de servicio", "Confirmacion", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            if (dsSpx1.LlamadaSoporte[0].IscodSolicitudNull())
            {
                llamadaSoporteTableAdapter1.UpdateEstado("ABIER", codLlamada);
            }else {
                llamadaSoporteTableAdapter1.UpdateEstado("SOLGE", codLlamada);
            }
            Nullable<DateTime> fechaN = new Nullable<DateTime>();
            llamadaSoporteTableAdapter1.UpdateCierre(fechaN, null,null, codLlamada);
            llamadaSoporteTableAdapter1.FillByidLlamadaSoporte(dsSpx1.LlamadaSoporte, codLlamada);
            #region zona de notificacionacti
          //  CgSmtpEmailSender.core.clsSender mailsender = new CgSmtpEmailSender.core.clsSender();
          //  mailsender.EjecutarAccion(504, dsSpx1.LlamadaSoporte[0].asesorTelefonico, (System.Data.DataRow)dsSpx1.LlamadaSoporte[0], null, CgSmtpEmailSender.core.clsSender.prioridad.media, "", "");
            #endregion
            cargarDatos();
            acomodarBotones();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string ruta = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter objDef = new SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter();
            objDef.Fill(dsSpx1.defaults);
 
            frmlImpresion frImp= new frmlImpresion();
            string strReporte = "rptLlamadaSeguimiento";

            if (frImp.ShowDialog() != DialogResult.OK) return;
            if (frImp.opcion == 1)
            { 
               strReporte = "rptLlamadaSeguimiento";
            }else {
                strReporte = "rptLlamadaSeguimientoCompleta";
            }

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
            if (reporte.Fields.Contains("lblTitulo"))
            {
                reporte.Fields["lblTitulo"].Value = dsSpx1.defaults[0].tituloLlamadas.Trim();
            }
            if (reporte.Fields.Contains("lblVersion"))
            {
                reporte.Fields["lblVersion"].Value = dsSpx1.defaults[0].versionLlamadas.Trim();
            }
            if (reporte.Fields.Contains("lblTipoDocumento"))
            {
                if (!dsSpx1.defaults[0].IscodigoLLamadasNull())
                    reporte.Fields["lblTipoDocumento"].Value = dsSpx1.defaults[0].codigoLLamadas.Trim();
            }
            if (reporte.Fields.Contains("lblVigencia"))
            {
                if (!dsSpx1.defaults[0].IsfechaVigenciaLlamadasNull())
                    reporte.Fields["lblVigencia"].Value = dsSpx1.defaults[0].fechaVigenciaLlamadas.ToShortDateString();
            }
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            reporte.DataSource.ConnectionString = objData.CadenaConexionReportes;
            reporte.DataSource.RecordSource = reporte.DataSource.RecordSource.Replace("<<codLLamada>>", codLlamada.ToString());
            //modificamos el subreporte
            if (reporte.Fields.Contains("subRpt"))
            {
                reporte.Fields["subRpt"].Subreport.DataSource.ConnectionString = objData.CadenaConexionReportes;
                reporte.Fields["subRpt"].Subreport.DataSource.RecordSource = reporte.Fields["subRpt"].Subreport.DataSource.RecordSource.Replace("<<codLLamada>>", codLlamada.ToString());    
            }
            var  frmRpt = new SPControladoraDatos.artefactos.SPXQuery.frm.Reportes.frmReporte (reporte);
            frmRpt.Icon = this.Icon;

            frmRpt.ShowDialog();
        
        }

        private bool solicitarServicio() 
        {
            spProcesos.solicitudes.frmSolicitudServicio frm = new spProcesos.solicitudes.frmSolicitudServicio();
            frm.mostrarDialogo = true;
            frm.CodLlamada = codLlamada;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                int tmp = frm.CodSolicitud;
                llamadaSoporteTableAdapter1.UpdateCodSolicitud(tmp, codLlamada);
                //actualizamos el estado de la llamada
                llamadaSoporteTableAdapter1.UpdateEstado("SOLGE", codLlamada);
                llamadaSoporteTableAdapter1.FillByidLlamadaSoporte(dsSpx1.LlamadaSoporte, codLlamada);
                cargarDatos();
                acomodarBotones();
                return true;
            }
            return false;
        }

        #region seguimientos e Indicaciones
        private void btnAddIndicaciones_Click(object sender, EventArgs e)
        {
            if (dsSpx1.LlamadaSoporte.Rows.Count <= 0)
            {
                MessageBox.Show("Guarde Primero el Encabezado de la llamada para agregar Indicaciones");
                return;
            }
            llamadasTecnicas.Indicaciones frmI = new Indicaciones();
            frmI.CodLlamada = codLlamada;
            if (frmI.ShowDialog() == DialogResult.OK)
            {
            
                indicacionesLLamadasTableAdapter1.FillByidLLamadaSoporte(dsSpx1.indicacionesLLamadas, codLlamada);
            }

        }

        private void btnEditIndicaciones_Click(object sender, EventArgs e)
        {
            if (grdIndicaciones.Columns["codIndicacion"].Text.Trim() == string.Empty) return;
            llamadasTecnicas.Indicaciones frmI = new Indicaciones();
            frmI.CodLlamada = codLlamada;
            frmI.CodIndicacion = int.Parse(grdIndicaciones.Columns["codIndicacion"].Text.Trim());
            if (frmI.ShowDialog() == DialogResult.OK)
            {
                indicacionesLLamadasTableAdapter1.FillByidLLamadaSoporte(dsSpx1.indicacionesLLamadas, codLlamada);
            }
        }

        private void btnDelIndicaciones_Click(object sender, EventArgs e)
        {
            if (grdIndicaciones.Columns["codIndicacion"].Text.Trim() == string.Empty) return;
            if (MessageBox.Show("Esta seguro de eliminar esta Indicacion?", "Confirmacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = int.Parse(grdIndicaciones.Columns["codIndicacion"].Text.Trim());
                indicacionesLLamadasTableAdapter1.DeleteQuery(id, codLlamada);
                indicacionesLLamadasTableAdapter1.FillByidLLamadaSoporte(dsSpx1.indicacionesLLamadas, codLlamada);
            }

        }

        private void btnAddSeguimiento_Click(object sender, EventArgs e)
        {
            if (dsSpx1.LlamadaSoporte.Rows.Count <= 0)
            {
                MessageBox.Show("Guarde Primero el Encabezado de la llamada para Programar Seguimientos");
                return;
            }

            frmAgregarSeguimiento frmp = new frmAgregarSeguimiento();
            frmp.CodLlamada = codLlamada;
            if (frmp.ShowDialog() == DialogResult.OK)
            {
                llamadaSoporteTableAdapter1.UpdatefechaUltimoSeguimiento(DateTime.Now, codLlamada);
                seguimientoTableAdapter1.FillByidLlamadaSoporte(dsSpx1.seguimiento, codLlamada);
            }
        }

        private void btnEditSeguimi_Click(object sender, EventArgs e)
        {
            if (grdSeguimiento.Columns["idSeguimiento"].Text.Trim() == string.Empty) return;

            frmAgregarSeguimiento frmp = new frmAgregarSeguimiento();
            frmp.CodLlamada = codLlamada;
            frmp.IdSeguimiento = int.Parse(grdSeguimiento.Columns["idSeguimiento"].Text);
            if (frmp.ShowDialog() == DialogResult.OK)
            {
                seguimientoTableAdapter1.FillByidLlamadaSoporte(dsSpx1.seguimiento, codLlamada);
                llamadaSoporteTableAdapter1.FillByidLlamadaSoporte(dsSpx1.LlamadaSoporte, codLlamada);
                #region zona de notificacion
                //CgSmtpEmailSender.core.clsSender mailsender = new CgSmtpEmailSender.core.clsSender();
                //mailsender.EjecutarAccion(503, dsSpx1.LlamadaSoporte[0].asesorTelefonico, (System.Data.DataRow)dsSpx1.LlamadaSoporte[0], null, CgSmtpEmailSender.core.clsSender.prioridad.media, "", "");
                #endregion
            }
        }

        private void btnDelSeguimien_Click(object sender, EventArgs e)
        {
            if (grdSeguimiento.Columns["idSeguimiento"].Text.Trim() == string.Empty) return;
            if (MessageBox.Show("Esta seguro de eliminar este seguimiento?", "Confirmacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = int.Parse(grdSeguimiento.Columns["idSeguimiento"].Text.Trim());
                seguimientoTableAdapter1.DeleteQuery(id);
                seguimientoTableAdapter1.FillByidLlamadaSoporte(dsSpx1.seguimiento, codLlamada);
            }

        }

        private void btnProgramarSeguimiento_Click(object sender, EventArgs e)
        {
            if (dsSpx1.LlamadaSoporte.Rows.Count <= 0)
            {
                MessageBox.Show("Guarde Primero el Encabezado de la llamada para Programar Seguimientos");
                return;
            }

                frmProgramarSeguimiento frmp = new frmProgramarSeguimiento();
                frmp.CodLlamada = codLlamada;
                if (frmp.ShowDialog() == DialogResult.OK)
                {
                    seguimientoTableAdapter1.FillByidLlamadaSoporte(dsSpx1.seguimiento, codLlamada);
                }
                llamadaSoporteTableAdapter1.FillByidLlamadaSoporte(dsSpx1.LlamadaSoporte, codLlamada);
                #region zona de notificacion
                //CgSmtpEmailSender.core.clsSender mailsender = new CgSmtpEmailSender.core.clsSender();
                //mailsender.EjecutarAccion(502, dsSpx1.LlamadaSoporte[0].asesorTelefonico, (System.Data.DataRow)dsSpx1.LlamadaSoporte[0], null, CgSmtpEmailSender.core.clsSender.prioridad.media, "", "");
                #endregion
          
        }
#endregion

        private void rdSiTelefonica_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdNoTelefonic_CheckedChanged(object sender, EventArgs e)
        {
            if (!eventosEncendidos) return;
            if (rdNoTelefonic.Checked)
            {
                if (MessageBox.Show("Desea crear una solicitud de servicio para dar solucion al problema? ", "Pregunta??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
                solicitarServicio();
            }
        }

        private void btnInfCliente_Click(object sender, EventArgs e)
        {
            if (nitCliente.Trim() == string.Empty) return;
            SpFrm.terceros.frmInfCliente fr = new SpFrm.terceros.frmInfCliente();
            fr.nitCliente = nitCliente;
            fr.Show();
        }

        private void btnInfSucursal_Click(object sender, EventArgs e)
        {
            if (nitCliente.Trim() == string.Empty) return;
            SpFrm.terceros.frmInfSucursal fr = new SpFrm.terceros.frmInfSucursal();
            fr.NitCliente = nitCliente;
            fr.CodSucursal = codUbicacion;
            fr.Show();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (nitCliente.Trim() == string.Empty) return;
            SpFrm.terceros.frmInfContactoSucursal fr = new SpFrm.terceros.frmInfContactoSucursal();
            fr.NitCliente = nitCliente;
            fr.CodContacto = codContacto;
            fr.Show();
        }

        private void txtNombreContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbAsesorComercial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSolicitarRecoleccion_Click(object sender, EventArgs e)
        {
            if (nitCliente.Trim() == string.Empty) return;
            spProcesos.recolecciones.frmNuevaRecoleccion frm = new spProcesos.recolecciones.frmNuevaRecoleccion();
            frm.serial = txtSerial.Text.Trim();
            frm.Show();
        }

        private void btnActividadesxModelo_Click(object sender, EventArgs e)
        {
            if (txtSerial.Text == string.Empty) return;
            equiposTableAdapter1.FillBySerial(dsSpx1.equipos, txtSerial.Text);

            spProcesos.problemas_frecuentes.frmParametrizacionProblemas fr = new spProcesos.problemas_frecuentes.frmParametrizacionProblemas();
            fr.codFabricante = dsSpx1.equipos[0].codFabricante.Trim();
            fr.codModelo = dsSpx1.equipos[0].codModelo.Trim();

           
            fr.ShowDialog();
        }
    }
}
