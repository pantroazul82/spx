using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.recolecciones
{
    public partial class frmNuevaRecoleccion : Form
    {
        public string serial { set; get; }

        public frmNuevaRecoleccion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga la informacion del data set en los controles
        /// </summary>
        private void cargarControles()
        {
            if (dsSpx1.recoleccion.Count <= 0) return;

            if (!dsSpx1.recoleccion[0].IscodEntradaSalidaEquiposNull())
            {
                txtNumEntrada.Text = dsSpx1.recoleccion[0].codEntradaSalidaEquipos.ToString();
                btnAmarrarEntrada.Visible = false;
                btnVerEntrada.Visible = true;
            }else {
                btnAmarrarEntrada.Visible = true;
                btnVerEntrada.Visible = false;
            }
            
            if (!dsSpx1.recoleccion[0].IscodEstadoRecoleccionNull())cmbEstadoRecoleccion.SelectedValue= dsSpx1.recoleccion[0].codEstadoRecoleccion;

             txtcodRecoleccion.Text= dsSpx1.recoleccion[0].codRecoleccion.ToString();

            if (!dsSpx1.recoleccion[0].IscodRecoleccionTransportadoraNull())txtCodRecoleccionTrans.Text= dsSpx1.recoleccion[0].codRecoleccionTransportadora.ToString();
            
            if (!dsSpx1.recoleccion[0].IscodTransportadoraNull())cmbTransportadora.SelectedValue= dsSpx1.recoleccion[0].codTransportadora.ToString();
            if (!dsSpx1.recoleccion[0].IsconfirmadaNull())chkConfirmada.Checked=  dsSpx1.recoleccion[0].confirmada;
            if (!dsSpx1.recoleccion[0].IsconfirmadaPorNull())cmbConfirmadaPor.SelectedValue= dsSpx1.recoleccion[0].confirmadaPor;

            if (!dsSpx1.recoleccion[0].IsfechaConfirmacionNull())calConfirmacion.Value= dsSpx1.recoleccion[0].fechaConfirmacion;
            if (!dsSpx1.recoleccion[0].IsfechaRecoleccionNull())calRecoleccion.Value= dsSpx1.recoleccion[0].fechaRecoleccion;
            if (!dsSpx1.recoleccion[0].IsfechaSolicitudNull())calFechaCreacion.Value =dsSpx1.recoleccion[0].fechaSolicitud;
            if (!dsSpx1.recoleccion[0].IsfechaTentativaLlegadaNull())calFechaTentativa.Value= dsSpx1.recoleccion[0].fechaTentativaLlegada;
            if (!dsSpx1.recoleccion[0].IsnroGuiaNull())txtNumeroguia.Text= dsSpx1.recoleccion[0].nroGuia;
           
            if (!dsSpx1.recoleccion[0].IsmotivoRecoleccionNull())txtMotivoRecoleccion.Text= dsSpx1.recoleccion[0].motivoRecoleccion;

            if (!dsSpx1.recoleccion[0].Isretiro_definitivoNull() && dsSpx1.recoleccion[0].retiro_definitivo)
                rdRetiroDefinitivoSi.Checked = true;
            else
                rdRetiroDefinitivoNo.Checked = true;

            if (!dsSpx1.recoleccion[0].IsobsConfirmacionNull()) txtObservacionesConfirmacion.Text= dsSpx1.recoleccion[0].obsConfirmacion;
            if (!dsSpx1.recoleccion[0].IsobservacionesSolicitudNull())txtObservaciones.Text= dsSpx1.recoleccion[0].observacionesSolicitud;
            if (!dsSpx1.recoleccion[0].IsobsInicialesNull())txtObsIniciales.Text= dsSpx1.recoleccion[0].obsIniciales;
            if (!dsSpx1.recoleccion[0].IsresponsableRecoleccionNull()) cmbResponsableRecoleccion.SelectedValue = dsSpx1.recoleccion[0].responsableRecoleccion;
            else cmbResponsableRecoleccion.SelectedValue = "";

            if (!dsSpx1.recoleccion[0].IsserialNull()) txtSerial.Text = dsSpx1.recoleccion[0].serial;
            cargarserial(txtSerial.Text);
            
            if (!dsSpx1.recoleccion[0].IssolicitadoPorNull())cmbAutor.SelectedValue= dsSpx1.recoleccion[0].solicitadoPor;
            habilitarControles();

        }

        private void habilitarControles() 
        {
            //miramos el estado
            //si es nueva
            if (dsSpx1.recoleccion.Count <= 0)
            {
                btnGuardar.Enabled = true;
                btnAnular.Enabled = false;
                btnImprimir.Enabled = false;
                btnConfirmar.Visible = false;
                btnDesconfirmar.Visible = false;

            }else {
                if (dsSpx1.recoleccion[0].codEstadoRecoleccion == 6)//anulada
                {
                    #region anulada
                    grpRetiroDefinitivo.Enabled = false;
                    btnImprimir.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnConfirmar.Visible = false;
                    btnDesconfirmar.Visible = false;
                    btnAnular.Enabled = false;
                    
                    txtSerial.ReadOnly = true;
                    txtcodRecoleccion.ReadOnly = true;
                    txtCodRecoleccionTrans.ReadOnly = true;
                    txtModalidad.ReadOnly = true;
                    txtModelo.ReadOnly = true;
                    txtMotivoRecoleccion.ReadOnly = true;
                    txtNitCliente.ReadOnly = true;
                    txtNombrecliente.ReadOnly = true;
                    txtNumEntrada.ReadOnly = true;
                    txtNumeroguia.ReadOnly = true;
                    txtObservaciones.ReadOnly = true;
                    txtObservacionesConfirmacion.ReadOnly = true;
                    txtObsIniciales.ReadOnly = true;
                    txtSucursal.ReadOnly = true;
                    cmbAutor.Enabled = false;
                    cmbConfirmadaPor.Enabled = false;
                    cmbEstadoRecoleccion.Enabled = false;
                    cmbResponsableRecoleccion.Enabled = false;
                    cmbTransportadora.Enabled = false;
                    calConfirmacion.Enabled = false;
                    calFechaCreacion.Enabled = false;
                    calFechaTentativa.Enabled = false;
                    calRecoleccion.Enabled = false;
                    btnBuscarSerial.Enabled = false;
                    #endregion
                }
                else if (dsSpx1.recoleccion[0].codEstadoRecoleccion == 5)//recolectado
                {
                    #region recolectado
                    grpRetiroDefinitivo.Enabled = false;
                    btnImprimir.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnConfirmar.Visible = false;
                    btnDesconfirmar.Visible = false;
                    btnAnular.Enabled = true;

                    txtSerial.ReadOnly = true;
                    txtcodRecoleccion.ReadOnly = true;
                    txtCodRecoleccionTrans.ReadOnly = true;
                    txtModalidad.ReadOnly = true;
                    txtModelo.ReadOnly = true;
                    txtMotivoRecoleccion.ReadOnly = true;
                    txtNitCliente.ReadOnly = true;
                    txtNombrecliente.ReadOnly = true;
                    txtNumEntrada.ReadOnly = true;
                    txtNumeroguia.ReadOnly = true;
                    txtObservaciones.ReadOnly = true;
                    txtObservacionesConfirmacion.ReadOnly = true;
                    txtObsIniciales.ReadOnly = true;
                    txtSucursal.ReadOnly = true;
                    cmbAutor.Enabled = false;
                    cmbConfirmadaPor.Enabled = false;
                    cmbEstadoRecoleccion.Enabled = false;
                    cmbResponsableRecoleccion.Enabled = false;
                    cmbTransportadora.Enabled = false;
                    calConfirmacion.Enabled = false;
                    calFechaCreacion.Enabled = false;
                    calFechaTentativa.Enabled = false;
                    calRecoleccion.Enabled = false;
                    btnBuscarSerial.Enabled = false;
                    #endregion
                }
                else if (dsSpx1.recoleccion[0].codEstadoRecoleccion == 4)//por recoger
                {
                    #region por recoger
                    btnImprimir.Enabled = true;
                    btnGuardar.Enabled = true;
                    btnAnular.Enabled = true;

                    btnConfirmar.Visible = false;
                    btnDesconfirmar.Visible = true;
                    #endregion
                }
                else if (dsSpx1.recoleccion[0].codEstadoRecoleccion == 3)//en confirmacion
                {
                    #region en confirmacion
                    btnImprimir.Enabled = true;
                    btnGuardar.Enabled = true;
                    btnAnular.Enabled = true;

                    btnConfirmar.Visible = true;
                    btnDesconfirmar.Visible = false;
                    #endregion
                }
                else if (dsSpx1.recoleccion[0].codEstadoRecoleccion == 2)//por asignar transportadora
                {
                    #region anulada
                    btnImprimir.Enabled = true;
                    btnGuardar.Enabled = true;
                    btnAnular.Enabled = true;

                    btnConfirmar.Visible = true;
                    btnDesconfirmar.Visible = false;
                    #endregion
                }
                else if (dsSpx1.recoleccion[0].codEstadoRecoleccion == 1)//nueva
                {
                    #region anulada
                    btnImprimir.Enabled = true;
                    btnGuardar.Enabled = true;
                    btnAnular.Enabled = true;
                    btnConfirmar.Visible = true;
                    btnDesconfirmar.Visible = false;
                    #endregion
                }
            }
        
        }

        private void cmbAutor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private int codRecoleccion = 0;
        public int CodRecoleccion { set { codRecoleccion = value; } get { return codRecoleccion; } }

        private void cargarTablas() 
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            clsTusuario1.Fill(dsSPXSeguridadAutor.usuario);
            clsTusuario1.Fill(dsSPXSeguridadResponsable.usuario);
            clsTusuario1.Fill(dsSPXSeguridadConfirmo.usuario);

            transportadoraTableAdapter1.Fill(dsSpx1.transportadora);
            estadoRecoleccionTableAdapter1.Fill(dsSpx1.estadoRecoleccion);
            calConfirmacion.MonthCalendar.DisplayMonth = n;
            calFechaCreacion.MonthCalendar.DisplayMonth = n;
            calFechaTentativa.MonthCalendar.DisplayMonth = n;
            calRecoleccion.MonthCalendar.DisplayMonth = n;
            cmbEstadoRecoleccion.SelectedValue = 1;
            cmbTransportadora.SelectedValue = -1;
            cmbAutor.SelectedValue = SPXSeguridad.logica.sesion.LoginUsuarioAutenticado;
            cmbConfirmadaPor.SelectedValue = -1;
            cmbResponsableRecoleccion.SelectedValue = SPXSeguridad.logica.sesion.LoginUsuarioAutenticado;
        }

        private void frmNuevaRecoleccion_Load(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            dsSpx1.EnforceConstraints = false;
            cargarTablas();
            txtcodRecoleccion.Text = recoleccionTableAdapter1.verNextId().Value.ToString();
            calFechaCreacion.Value = n;
            cmbAutor.SelectedValue = SPXSeguridad.logica.sesion.LoginUsuarioAutenticado;
            cmbEstadoRecoleccion.SelectedValue = 1;
            if (serial != null && serial.Trim() != string.Empty)
            {
                txtSerial.Text = serial;
                cargarserial(serial);
            }

            if (codRecoleccion != 0)
            {
                recoleccionTableAdapter1.FillByCodRecoleccion(dsSpx1.recoleccion, codRecoleccion);
                cargarControles();
            }else {
                btnVerEntrada.Visible = false;
                habilitarControles();
            }
        }

        private void btnInfEquipo_Click(object sender, EventArgs e)
        {
            if (txtSerial.Text.Trim() == string.Empty) return;
            spProcesos.Equipos.frmInformacionEquipo frm = new spProcesos.Equipos.frmInformacionEquipo();
            frm.Serial = txtSerial.Text.Trim();
            frm.ShowDialog();
        }
        string codigoModalidad = "";
        string codSucursal = "";
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
        
            fabricanteTableAdapter1.FillByCodfabricanteComboBox(dsSpx1.fabricante, dsSpx1.equipos[0].codFabricante.Trim());
            string fabricante = dsSpx1.fabricante[0].nombre_fabricante;
            //
            modelosTableAdapter1.FillByFabricanteModeloComboBox(dsSpx1.Modelos, dsSpx1.equipos[0].codFabricante.Trim(), dsSpx1.equipos[0].codModelo.Trim());
            txtModelo.Text = dsSpx1.Modelos[0].NombreModelo+" ("+fabricante.Trim()+")";

            if (!dsSpx1.Modelos[0].IscodTipoEquipoNull())
            {
                tipoEquipoTableAdapter1.FillBycodTipoEquipo(dsSpx1.tipoEquipo, dsSpx1.Modelos[0].codTipoEquipo);
                txtTipoEquipo.Text = dsSpx1.tipoEquipo[0].nombreTipoEquipo;
            }
#region esto es para cargar la modalidad con el cual fue creada, si cambio de modadlidad no trae el actual si no el de ese entonces.
            codigoModalidad = "";
            if (dsSpx1.recoleccion.Rows.Count <= 0 || dsSpx1.recoleccion[0].serial != txtSerial.Text)
            {
                if (!dsSpx1.equipos[0].IscodModalidadEquipoNull())
                {
                    codigoModalidad = dsSpx1.equipos[0].codModalidadEquipo;
                    txtModalidad.Text = modalidadEquipoTableAdapter1.verNombreModadlidad(codigoModalidad).ToString();
                }
            }
            else
            {
                if (!dsSpx1.recoleccion[0].IscodModalidadNull())
                {
                    codigoModalidad = dsSpx1.recoleccion[0].codModalidad;
                    txtModalidad.Text = modalidadEquipoTableAdapter1.verNombreModadlidad(codigoModalidad).ToString();
                }
            }
#endregion


          
            //esto es para cargar el cliente con el cual fue creada la orden de servicio si cambio no trae el actual si no el de ese entonces.
            string nitCliente = "";
            codSucursal = "";

            if (dsSpx1.recoleccion.Rows.Count <= 0 || dsSpx1.recoleccion[0].serial != txtSerial.Text)
            {
                nitCliente = dsSpx1.equipos[0].nitClienteUbica;
                codSucursal = dsSpx1.equipos[0].codSucursalUbica;
            }
            else
            {
                nitCliente = dsSpx1.recoleccion[0].nitCliente;
                codSucursal = dsSpx1.recoleccion[0].codSucursal;
            }
            clientesTableAdapter1.FillByNitCliente(dsSpx1.clientes, nitCliente);
            txtNitCliente.Text = dsSpx1.clientes[0].nitCliente;
            txtNombrecliente.Text = dsSpx1.clientes[0].nombreCliente;
            //informacion de la ubicacion

            sucursalClienteTableAdapter1.FillByCodSucursalNit(dsSpx1.sucursalCliente, nitCliente, codSucursal);
            txtSucursal.Text = dsSpx1.sucursalCliente[0].nombreSucursal;
          
            return true;
        }

        private void txtSerial_Validating(object sender, CancelEventArgs e)
        {
            if (txtSerial.Text.Trim() == string.Empty) return;
            e.Cancel = !cargarserial(txtSerial.Text);
            if (e.Cancel) txtSerial.Text = "";
        }

        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnInfCliente_Click(object sender, EventArgs e)
        {
            if (txtNitCliente.Text.Trim() == string.Empty) return;
            SpFrm.terceros.frmInfCliente fr = new SpFrm.terceros.frmInfCliente();
            fr.nitCliente = txtNitCliente.Text;
            fr.ShowDialog();
        }

        private void btnInfSucursal_Click(object sender, EventArgs e)
        {
            if (txtNitCliente.Text.Trim() == string.Empty) return;
            SpFrm.terceros.frmInfSucursal fr = new SpFrm.terceros.frmInfSucursal();
            fr.NitCliente = txtNitCliente.Text;
            fr.CodSucursal = codSucursal;
            fr.ShowDialog();
        }

        private void btnVerEntrada_Click(object sender, EventArgs e)
        {
            if (txtNumEntrada.Text.Trim() != string.Empty)
            {
                spProcesos.ESequipos.frmEntradaSalidaEquipos fr = new spProcesos.ESequipos.frmEntradaSalidaEquipos();
                fr.CodEntradaSalidaEquipos = txtNumEntrada.Text;
                fr.Show();
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            //verificamos si tien permiso para anular
            if (SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1012))
            {
                recoleccionTableAdapter1.UpdateCodEstadoRecoleccion(6, codRecoleccion);
                recoleccionTableAdapter1.FillByCodRecoleccion(dsSpx1.recoleccion, codRecoleccion);
                cargarControles();
                recoleccionTableAdapter1.FillByCodRecoleccion(dsSpx1.recoleccion, codRecoleccion);
                #region zona de notificacion
             //   CgSmtpEmailSender.core.clsSender mailsender = new CgSmtpEmailSender.core.clsSender();
              //  mailsender.EjecutarAccion(602, cmbResponsableRecoleccion.SelectedValue.ToString(), (System.Data.DataRow)dsSpx1.recoleccion[0], null, CgSmtpEmailSender.core.clsSender.prioridad.media, "", "");
                #endregion
            }else {
                MessageBox.Show("No tiene los Suficientes permisos para ejecutar esta opcion");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Nullable<DateTime> fechaN= new Nullable<DateTime>();
             Nullable<int> enteroN= new Nullable<int>();
             if (!validar()) return;
             if (codRecoleccion == 0)
             {
                 int estado = 0;
                 if (calFechaTentativa.ValueObject == null)
                 {
                     estado = 1;
                 }
                 else if (cmbTransportadora.SelectedValue == null || cmbTransportadora.SelectedValue.ToString().Trim() == string.Empty)
                 {
                     estado = 2;
                 }
                 else
                 {
                     estado = 3;
                 }
                 codRecoleccion = recoleccionTableAdapter1.verNextId().Value;
                 SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
                 DateTime n = dc.fechaServer;
                 recoleccionTableAdapter1.Insert(codRecoleccion, estado,
                     txtNitCliente.Text, codSucursal,
                     (codigoModalidad == string.Empty) ? null : codigoModalidad, txtSerial.Text, n,
                     SPXSeguridad.logica.sesion.LoginUsuarioAutenticado, txtObservaciones.Text, txtMotivoRecoleccion.Text,
                     (calFechaTentativa.ValueObject == null) ? fechaN : calFechaTentativa.Value
                     , (cmbResponsableRecoleccion.SelectedValue == null || cmbResponsableRecoleccion.SelectedValue.ToString().Trim() == string.Empty) ? null : cmbResponsableRecoleccion.SelectedValue.ToString()
                     , ((cmbTransportadora.SelectedValue == null || cmbTransportadora.SelectedValue.ToString().Trim() == string.Empty) ?
                     (enteroN) : int.Parse(cmbTransportadora.SelectedValue.ToString()))
                     , txtCodRecoleccionTrans.Text, txtNumeroguia.Text, txtObsIniciales.Text, false, null, fechaN, txtObservacionesConfirmacion.Text,
                     fechaN, enteroN,rdRetiroDefinitivoSi.Checked);
                 dsSpx1.EnforceConstraints = false;
                 recoleccionTableAdapter1.FillByCodRecoleccion(dsSpx1.recoleccion, codRecoleccion);
                 #region zona de notificacion
            //     CgSmtpEmailSender.core.clsSender mailsender = new CgSmtpEmailSender.core.clsSender();
              //   mailsender.EjecutarAccion(601, cmbResponsableRecoleccion.SelectedValue.ToString(), (System.Data.DataRow)dsSpx1.recoleccion[0], null, CgSmtpEmailSender.core.clsSender.prioridad.media,"","");
                 #endregion
             }else {
                 int estado = 0;
                 if (int.Parse(cmbEstadoRecoleccion.SelectedValue.ToString()) <= 2)
                 {
                     if (calFechaTentativa.ValueObject == null)
                     {
                         estado = 1;
                     }else
                     if (cmbTransportadora.SelectedValue == null || cmbTransportadora.SelectedValue.ToString().Trim() == string.Empty)
                     {
                         estado = 2;
                     }
                     else
                     {
                         estado = 3;
                     }
                 }
                 else {
                     estado = int.Parse(cmbEstadoRecoleccion.SelectedValue.ToString());
                 }
                 recoleccionTableAdapter1.UpdateQuery(estado, txtNitCliente.Text, codSucursal,
                         (codigoModalidad == string.Empty) ? null : codigoModalidad, txtSerial.Text,
                         calFechaCreacion.Value, cmbAutor.SelectedValue.ToString(), txtObservaciones.Text, txtMotivoRecoleccion.Text,
  (calFechaTentativa.ValueObject == null) ? fechaN : calFechaTentativa.Value
                     , (cmbResponsableRecoleccion.SelectedValue == null || cmbResponsableRecoleccion.SelectedValue.ToString().Trim() == string.Empty) ? null : cmbResponsableRecoleccion.SelectedValue.ToString()
                     , ((cmbTransportadora.SelectedValue == null || cmbTransportadora.SelectedValue.ToString().Trim() == string.Empty) ?
                         (enteroN) : int.Parse(cmbTransportadora.SelectedValue.ToString()))
                         , txtCodRecoleccionTrans.Text, txtNumeroguia.Text, txtObsIniciales.Text,
                          chkConfirmada.Checked,
                          (cmbConfirmadaPor.SelectedValue == null) ? null : cmbConfirmadaPor.SelectedValue.ToString(),

                           (calConfirmacion.ValueObject == null) ? fechaN : calConfirmacion.Value,
                         txtObservacionesConfirmacion.Text,

                         (calRecoleccion.ValueObject == null) ? fechaN : calRecoleccion.Value,
                         (txtNumEntrada.Text.Trim() == string.Empty) ? enteroN : int.Parse(txtNumEntrada.Text),
                         rdRetiroDefinitivoSi.Checked,
                         codRecoleccion);
             }
             recoleccionTableAdapter1.FillByCodRecoleccion(dsSpx1.recoleccion, codRecoleccion);
             cargarControles();
        }

        private bool validar() 
        {
            if (txtSerial.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El equipo es Obligatorio!");
                return false;
            }
            if (txtSerial.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El equipo es Obligatorio!");
                return false;
            }
            if (!rdRetiroDefinitivoNo.Checked && !rdRetiroDefinitivoSi.Checked)
            {
                MessageBox.Show("Debe especificar si es retiro definitivo o no!");
                return false;
            }
            //if (calFechaTentativa.ValueObject == null)
            //{
            //    MessageBox.Show("La fecha tentativa de recoleccion es Obligatoria!");
            //    return false;
            //}
            //if (cmbResponsableRecoleccion.SelectedValue == null || cmbResponsableRecoleccion.SelectedValue.ToString().Trim() == string.Empty)
            //{
            //    MessageBox.Show("El Responsable de la Recoleccion es Obligatorio!");
            //    return false;
            //}
            return true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            if (!SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1026))
            {
                MessageBox.Show("No tiene los Suficientes permisos para ejecutar esta opcion");
                return;
            }

            if (calFechaTentativa.ValueObject == null )
            {
                MessageBox.Show("Si no tiene fecha tentativa no puede Confirmar la Recoleccion.");
                return;
            }

            if (cmbResponsableRecoleccion.SelectedValue == null || cmbResponsableRecoleccion.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Si no tiene responsable no puede Confirmar la Recoleccion.");
                return;
            }
            
            if (cmbTransportadora.SelectedValue == null || cmbTransportadora.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Si no tiene Transportadora no puede Confirmar la Recoleccion.");
                return;
            }
            if(MessageBox.Show("Esta seguro de establecer la recoleccion Como confirmada?","Cambiar de Estado",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                recoleccionTableAdapter1.UpdateCodEstadoRecoleccion(4,codRecoleccion);
                SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
                DateTime n = dc.fechaServer;
                recoleccionTableAdapter1.UpdateConfirmacion(true, SPXSeguridad.logica.sesion.LoginUsuarioAutenticado, n,
                    txtObservacionesConfirmacion.Text, codRecoleccion);
                recoleccionTableAdapter1.FillByCodRecoleccion(dsSpx1.recoleccion, codRecoleccion);
                cargarControles();
                recoleccionTableAdapter1.FillByCodRecoleccion(dsSpx1.recoleccion, codRecoleccion);
                #region zona de notificacion
             //   CgSmtpEmailSender.core.clsSender mailsender = new CgSmtpEmailSender.core.clsSender();
              //  mailsender.EjecutarAccion(603, cmbResponsableRecoleccion.SelectedValue.ToString(), (System.Data.DataRow)dsSpx1.recoleccion[0], null, CgSmtpEmailSender.core.clsSender.prioridad.media,"","");
                #endregion
            }
        }

        private void btnDesconfirmar_Click(object sender, EventArgs e)
        {
            if (!SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1113))
            {
                MessageBox.Show("No tiene los Suficientes permisos para ejecutar esta opcion");
                return;
            }
            if (MessageBox.Show("Esta seguro de establecer la recoleccion Como NO confirmada?", "Cambiar de Estado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                recoleccionTableAdapter1.UpdateCodEstadoRecoleccion(3,codRecoleccion);
                Nullable<DateTime> fechaN= new Nullable<DateTime>();
                recoleccionTableAdapter1.UpdateConfirmacion(false, null, fechaN,
                    txtObservacionesConfirmacion.Text, codRecoleccion);
                recoleccionTableAdapter1.FillByCodRecoleccion(dsSpx1.recoleccion, codRecoleccion);
                cargarControles();
                recoleccionTableAdapter1.FillByCodRecoleccion(dsSpx1.recoleccion, codRecoleccion);
                #region zona de notificacion
              //  CgSmtpEmailSender.core.clsSender mailsender = new CgSmtpEmailSender.core.clsSender();
               // mailsender.EjecutarAccion(604, cmbResponsableRecoleccion.SelectedValue.ToString(), (System.Data.DataRow)dsSpx1.recoleccion[0], null, CgSmtpEmailSender.core.clsSender.prioridad.media,"","");
                #endregion
            }

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter objDef = new SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter();
            objDef.Fill(dsSpx1.defaults);
            string ruta = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            C1.C1Report.C1Report reporte = new C1.C1Report.C1Report();
            reporte.Load(ruta + @"\rpt\rpt.xml", "rptRecoleccion");
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
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            reporte.DataSource.ConnectionString = objData.CadenaConexionReportes;
            reporte.DataSource.RecordSource = reporte.DataSource.RecordSource.Replace("<<codRecoleccion>>",codRecoleccion.ToString());

            SPControladoraDatos.artefactos.SPXQuery.frm.Reportes.frmReporte  frmRpt = new SPControladoraDatos.artefactos.SPXQuery.frm.Reportes.frmReporte (reporte);
            frmRpt.Icon = this.Icon;

            frmRpt.ShowDialog();
        }

        private void btnLimpiarResponsable_Click(object sender, EventArgs e)
        {
            cmbResponsableRecoleccion.SelectedValue = "";
        }

        private void btnAmarrarEntrada_Click(object sender, EventArgs e)
        {
            if (txtSerial.Text.Trim() == string.Empty) return;
            if (codRecoleccion == 0) return;
            spProcesos.ESequipos.frmEntradasSalidasSinRecoleccion fr = new spProcesos.ESequipos.frmEntradasSalidasSinRecoleccion();
            fr.Serial = txtSerial.Text;
            if (fr.ShowDialog() == DialogResult.OK)
            {
                recoleccionTableAdapter1.UpdateRecoleccionFinal(fr.fechaEntrada, int.Parse(fr.CodEntrada), codRecoleccion);
                btnAmarrarEntrada.Visible = false;
                txtNumEntrada.Text = fr.CodEntrada;
                btnVerEntrada.Visible = true;
            }
        }

    }
}
