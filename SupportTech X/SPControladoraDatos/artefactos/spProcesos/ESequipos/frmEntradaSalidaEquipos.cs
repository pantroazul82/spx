using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using  System.IO;
namespace spProcesos.ESequipos
{
    public partial class frmEntradaSalidaEquipos : Form
    {
        public frmEntradaSalidaEquipos()
        {
            InitializeComponent();
        }

        List<string> tabsCerrados = new List<string>();

        private string codEntradaSalidaEquipos = "";
        public string CodEntradaSalidaEquipos { set { codEntradaSalidaEquipos = value; } get { return codEntradaSalidaEquipos; } }
        /// <summary>
        /// esta variable es util para no preguntar mas de una vez si desea desvincular los equipos auxiliares, al momento de crear una entrada
        /// 
        /// </summary>
        public bool preguntarDesvincularAsociados = false;
        /// <summary>
        /// me indica al momento de guardar si desvincula los asociados.
        /// </summary>
        public bool DesvincularAsociados = false;



        /// <summary>
        /// Llena las tablas auxiliares como tipo de servicio, o estado fisicamente.
        /// </summary>
        private void llenarTablas() 
        {
            tipoServicioTableAdapter1.Fill(dsSpx1.TipoServicio);
            estadoFisicamenteTableAdapter1.Fill(dsSpx1.EstadoFisicamente);
            clsTusuario1.Fill(dsSPXSeguridad1.usuario);
            modalidadEquipoTableAdapter1.Fill(dsSpx2.ModalidadEquipo);
            estadoLocalEquiposTableAdapter1.Fill(dsSpx2.estadoLocalEquipos);
            sucursalClienteTableAdapter1.FillByNitCliente(dsSpx3.sucursalCliente, "local");
            motivo_salidaTableAdapter1.Fill(dsSpx1.motivo_salida);
        }


        /// <summary>
        /// Ajusta la visibilidad de la opcion de crear orden de servicio dependiendo del estado de la entrada y salida de equipo
        /// tambien habilita los tabs
        /// </summary>
        private void ajustarControles() 
        {
            tabsCerrados.Clear();
            tabsCerrados.Add("Salida");
            tabsCerrados.Add("Seguimiento");
            //miramos si es nuevo
            if (codEntradaSalidaEquipos.Trim() == string.Empty)
            {//si es nuevo 
                lblOrndeServicio.Visible = false;
                btnCrearOrdenServicio.Visible = false;
                txtOrdenServicio.Visible = false;
                tabControlPanel2.Enabled = false;
                btnImprimir.Enabled = false;
            }else{
                lblOrndeServicio.Visible = true;
                btnCrearOrdenServicio.Visible = true;
                btnImprimir.Enabled = true;
                txtOrdenServicio.Visible = true;
                //miramos si tiene orden de servicio asignada
                if (entradaSalidaEquiposTableAdapter1.verCodigoOrdenTrabajo(int.Parse(codEntradaSalidaEquipos)).Value ==0)
                {
                    btnCrearOrdenServicio.Visible = true;
                }
                else {
                    btnCrearOrdenServicio.Visible = false;   
                    tabsCerrados.Remove("Salida");
                    tabsCerrados.Remove("Seguimiento");
                }
            }
        }

        /// <summary>
        /// Modifica tanto la entada la salida y el seguimiento del equipo
        /// </summary>
        bool modes = false;

        /// <summary>
        /// Modifica la entrada del equipo
        /// </summary>
        bool entradaEquipo = false;

        /// <summary>
        /// Modifica la salida del equipo
        /// </summary>
        bool salidaEquipo = false;

        /// <summary>
        /// Modifica el seguimiento del equipo
        /// </summary>
        bool seguimientoEquipo = false;

        /// <summary>
        /// Bloquea los controles segun los permisos que tiene y el estado de la entrada salida de equipos.
        /// </summary>
        private void bloquearControles() 
        {
            #region Bloque controles segun los permisos
           
            txtSerial.Enabled = entradaEquipo;
            btnBuscar.Enabled = entradaEquipo;
            calFechaEntrada.Enabled = entradaEquipo;
            cmbEstadoFisicamente.Enabled = entradaEquipo;
            cmbTipoServicio.Enabled = entradaEquipo;
            btnCrearOrdenServicio.Enabled = entradaEquipo;
            txtObservaciones.Enabled = entradaEquipo;
            btnAgregarComponenteEntrada.Enabled = entradaEquipo;
            btnModificarComponenteEntrada.Enabled = entradaEquipo;
            btnEliminarComponenteEntrada.Enabled = entradaEquipo;

            #endregion
            if (dsSpx1.EntradaSalidaEquipos.Rows.Count <=0) return;
            // verificamos si el equipo tiene orden de servicio impide que cambien el equipo
            if (txtOrdenServicio.Text.Trim() != string.Empty)
                txtSerial.ReadOnly = true;
                btnBuscar.Visible = false;
            
            ///Si tiene fecha de terminacion bloquea la ventana a menos que tengo los suficientes permisos
                if (!dsSpx1.EntradaSalidaEquipos[0].IsfechaTerminacionMovtoNull() && !modes)
                { 
                  txtSerial.Enabled=false;
                    btnBuscar.Enabled=false;
                    calFechaEntrada.Enabled=false;
                    cmbEstadoFisicamente.Enabled=false;
                    cmbTipoServicio.Enabled=false;
                    btnCrearOrdenServicio.Enabled=false;
                    txtObservaciones.Enabled=false;
                    btnAgregarComponenteEntrada.Enabled=false;
                    btnModificarComponenteEntrada.Enabled=false;
                    btnEliminarComponenteEntrada.Enabled = false;
                }
        }


        private void frmEntradaSalidaEquipos_Load(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            dsSpx1.EnforceConstraints = false;
            calEntradaSistema.Value = n;
            calFechaEntrada.MonthCalendar.DisplayMonth = n;
            calFechaSalida.MonthCalendar.DisplayMonth = n;
            calFechaTerminacion.MonthCalendar.DisplayMonth = n;
            calGrabacionSeguimiento.MonthCalendar.DisplayMonth = n;
            calSeguimiento.MonthCalendar.DisplayMonth = n;
            #region cargamos los permisos
            modes = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1005);
            seguimientoEquipo = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1120) || modes;
            entradaEquipo = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1033) || modes;
            salidaEquipo = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1072) || modes;
            #endregion
            clientesTableAdapter1.Fill(dsSpx2.clientes);
            calFechaEntrada.MonthCalendar.DisplayMonth = n;
            calSeguimiento.MonthCalendar.DisplayMonth = n;
            llenarTablas();
            
            if (codEntradaSalidaEquipos.Trim() == string.Empty)
            {//si es nuevo
                txtCodigoEntradaSalida.Text = entradaSalidaEquiposTableAdapter1.verNextId().Value.ToString();   
            }else{
                txtCodigoEntradaSalida.Text = codEntradaSalidaEquipos;
                entradaSalidaEquiposTableAdapter1.FillBycodEntradaSalidaEquipos(dsSpx1.EntradaSalidaEquipos, int.Parse(codEntradaSalidaEquipos));
            }
            cargarControles();
            ajustarControles();
            bloquearControles();
            cargarAuxiliares();
            if (dsSpx1.EntradaSalidaEquipos.Count>0 && !dsSpx1.EntradaSalidaEquipos[0].Isanulada_porNull())
            {
                botonesAnulacion();
            }
        }

        /// <summary>
        /// Cargamos la Informacion que esta en el dataset en los controles.
        /// </summary>
        private void cargarControles()
        {
            //aqui lo de entrada
            if (dsSpx1.EntradaSalidaEquipos.Rows.Count <= 0) return;
            txtSerial.Text = dsSpx1.EntradaSalidaEquipos[0].serial;
            cargarserial(txtSerial.Text,false);
            if(!dsSpx1.EntradaSalidaEquipos[0].IsfechaEntradaNull()) calFechaEntrada.Value = dsSpx1.EntradaSalidaEquipos[0].fechaEntrada;
            if(!dsSpx1.EntradaSalidaEquipos[0].IscodEstadoFisicamenteNull()) cmbEstadoFisicamente.SelectedValue = dsSpx1.EntradaSalidaEquipos[0].codEstadoFisicamente;
            if(!dsSpx1.EntradaSalidaEquipos[0].IscodTiposervicioNull()) cmbTipoServicio.SelectedValue = dsSpx1.EntradaSalidaEquipos[0].codTiposervicio;
            if(!dsSpx1.EntradaSalidaEquipos[0].IsobsEntradaNull()) txtObservaciones.Text = dsSpx1.EntradaSalidaEquipos[0].obsEntrada;
            if (!dsSpx1.EntradaSalidaEquipos[0].IscodOrdenServicioNull())
            {
                txtOrdenServicio.Text = dsSpx1.EntradaSalidaEquipos[0].codOrdenServicio.ToString();
                btnVerOs.Visible = true;
            }
            //Salida
            if (!dsSpx1.EntradaSalidaEquipos[0].IsfechaTerminacionMovtoNull()) calFechaTerminacion.Value = dsSpx1.EntradaSalidaEquipos[0].fechaTerminacionMovto;
            
            if(!dsSpx1.EntradaSalidaEquipos[0].IsfechaSalidaNull()) calFechaSalida.Value = dsSpx1.EntradaSalidaEquipos[0].fechaSalida;
            if(!dsSpx1.EntradaSalidaEquipos[0].IsobsSalidaNull()) txtObservacionesSalida.Text = dsSpx1.EntradaSalidaEquipos[0].obsSalida;
            if (!dsSpx1.EntradaSalidaEquipos[0].IscodBodegaLocalNull()) 
            { 
                cmbUbicacionReal.SelectedValue = dsSpx1.EntradaSalidaEquipos[0].codBodegaLocal; 
                cmbUbicacionReal.Enabled = false; 
            }
            if(!dsSpx1.EntradaSalidaEquipos[0].Isanulada_porNull())btnAnular.Text = "Informacion de anulacion";
            if (dsSpx1.EntradaSalidaEquipos[0].IsnitClienteSalidaNull())
            {
                cmbCliente.SelectedValue = dsSpx1.EntradaSalidaEquipos[0].nitcliente;
                cargarSucursal();
                cargarSucursalCliente();
            }else {
                cmbCliente.SelectedValue = dsSpx1.EntradaSalidaEquipos[0].nitClienteSalida;
                cargarSucursal();
                cargarSucursalCliente();
            }

            if (dsSpx1.EntradaSalidaEquipos[0].IscodSucursalSalidaNull())
            {
                cmbSucursalCliente.SelectedValue = dsSpx1.EntradaSalidaEquipos[0].codSucursal;
            }else {
                cmbSucursalCliente.SelectedValue = dsSpx1.EntradaSalidaEquipos[0].codSucursalSalida;
            }

            if (!dsSpx1.EntradaSalidaEquipos[0].IscodEstadoSalidaNull())
            {
                cmbEstadoEquipoLocal.SelectedValue = dsSpx1.EntradaSalidaEquipos[0].codEstadoSalida;
            }else {
                cmbEstadoEquipoLocal.SelectedValue = "-1";
            }

            if (!dsSpx1.EntradaSalidaEquipos[0].Iscod_motivo_salidaNull())
            {
                cmbMotivoSalida.SelectedValue = dsSpx1.EntradaSalidaEquipos[0].cod_motivo_salida;
            }
            else
            {
                cmbMotivoSalida.SelectedValue = "-1";
            }
            
            if (dsSpx1.EntradaSalidaEquipos[0].IscodModalidadSalidaNull())
            {
                if (!dsSpx1.EntradaSalidaEquipos[0].IscodModalidadNull())
                {
                    cmbModaldad.SelectedValue = dsSpx1.EntradaSalidaEquipos[0].codModalidad;
                }
                else
                {
                    cmbModaldad.SelectedValue = "-1";
                }
            }
            else
            {
                cmbModaldad.SelectedValue = dsSpx1.EntradaSalidaEquipos[0].codModalidadSalida;
                
            }

            //Seguimiento
            if(!dsSpx1.EntradaSalidaEquipos[0].IsfechaIngresoSeguimientoNull()) calGrabacionSeguimiento.Value = dsSpx1.EntradaSalidaEquipos[0].fechaIngresoSeguimiento;
            if(!dsSpx1.EntradaSalidaEquipos[0].IsfechaSeguimientoNull()) calSeguimiento.Value = dsSpx1.EntradaSalidaEquipos[0].fechaSeguimiento;
            if (!dsSpx1.EntradaSalidaEquipos[0].IsusuarioSeguimientoNull())
            if (!dsSpx1.EntradaSalidaEquipos[0].IsusuarioSeguimientoNull()) cmbSeguimientoPor.SelectedValue = dsSpx1.EntradaSalidaEquipos[0].usuarioSeguimiento;
            if (!dsSpx1.EntradaSalidaEquipos[0].IsfuncionabienNull()) rdFuncionaBien.Checked = dsSpx1.EntradaSalidaEquipos[0].funcionabien;
            if (!dsSpx1.EntradaSalidaEquipos[0].IsfuncionabienNull()) rdNofuncionaBien.Checked = !dsSpx1.EntradaSalidaEquipos[0].funcionabien;
            if (!dsSpx1.EntradaSalidaEquipos[0].IsobservacionesNull()) txtObservacionesSeguimiento.Text = dsSpx1.EntradaSalidaEquipos[0].observaciones;

            
            if (!dsSpx1.EntradaSalidaEquipos[0].IsopNull()) txtOp.Text = dsSpx1.EntradaSalidaEquipos[0].op;
            if (!dsSpx1.EntradaSalidaEquipos[0].IsfacturaNull()) txtFactura.Text = dsSpx1.EntradaSalidaEquipos[0].factura;
            if (!dsSpx1.EntradaSalidaEquipos[0].IsfechaEntradaSistemaNull()) calEntradaSistema.Value = dsSpx1.EntradaSalidaEquipos[0].fechaEntradaSistema;
         
            //cargamos los accesorios
            accesoriosxEntradaSalidaEquiposTableAdapter1.FillByEntradasCodEntradaSalida(dsSpx1.AccesoriosxEntradaSalidaEquipos, int.Parse(codEntradaSalidaEquipos));
            accesoriosxEntradaSalidaEquiposTableAdapter1.FillBySalidasCodEntradaSalida(dsSpx2.AccesoriosxEntradaSalidaEquipos,int.Parse(codEntradaSalidaEquipos));
            //

        }

        private void botonesAnulacion()
        {
            btnAceptar.Enabled = false;
            btnAceptarSalida.Enabled = false;
            btnAceptarSeguimiento.Enabled = false;
            btnAgregarAccesorioSalida.Enabled = false;
            btnAgregarArchivo.Enabled = false;
            btnAgregarComponenteEntrada.Enabled = false;
            btnAgregarEquipoAuxiliar.Enabled = false;
            btnAgregarSeguimiento.Enabled = false;
            btnBuscar.Enabled = false;
            btnBuscarNit.Enabled = false;
            btnCancelarSalida.Enabled = false;
            btnCrearOrdenServicio.Enabled = false;
            btnEliminarAccesorioSalida.Enabled = false;
            btnEliminarArchivo.Enabled = false;
            btnEliminarComponenteEntrada.Enabled = false;
            btnGuardar.Enabled = false;
            btnGuardarArchivo.Enabled = false;
            btnImportarDesdeEntrada.Enabled = false;
            btnLimpiarCliente.Enabled = false;
            btnModificarAccesorioSalida.Enabled = false;
            btnModificarComponenteEntrada.Enabled = false;
            btnQuitarEquipoAuxiliar.Enabled = false;
            btnAnular.Text = "Informacion anulacion";
        }

        #region zona de buscar serial y cargar la informacion del serial
        /// <summary>
        /// busca un equipo para cargarlo en los controles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            spProcesos.Equipos.frmBuscarEquipo fr = new spProcesos.Equipos.frmBuscarEquipo();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                txtSerial.Text = fr.Serial;
                txtSerial.Focus();
                cargarserial(txtSerial.Text,false);
            }
        }

        string codSucursal = "";
        
        /// <summary>
        /// carga la informacion del serial, 
        /// </summary>
        /// <param name="serial">serial a cargar</param>
        /// <param name="load">me indica si esta en el load o cuando es digitado.</param>
        /// <returns></returns>
        private bool cargarserial(string serial,bool load)
        {
            //miramos si existe el serial
            equiposTableAdapter1.FillBySerial(dsSpx1.equipos, serial);
            if (dsSpx1.equipos.Rows.Count <= 0)
            {
                MessageBox.Show("El equipo con serial " + serial.Trim() + " no existe en la base de datos.");
                return false;
            }

            //
            fabricanteTableAdapter1.FillBycodFabricante(dsSpx1.fabricante, dsSpx1.equipos[0].codFabricante.Trim());
            txtFabricante.Text = dsSpx1.fabricante[0].nombre_fabricante;
            //
            modelosTableAdapter1.FillByFabricanteModelo(dsSpx1.Modelos, dsSpx1.equipos[0].codFabricante.Trim(), dsSpx1.equipos[0].codModelo.Trim());
            txtModelo.Text = dsSpx1.Modelos[0].NombreModelo;
            //
            if (!dsSpx1.Modelos[0].IscodTipoEquipoNull())
            {
                tipoEquipoTableAdapter1.FillBycodTipoEquipo(dsSpx1.tipoEquipo, dsSpx1.Modelos[0].codTipoEquipo);
                if (dsSpx1.tipoEquipo[0].IsnombreTipoEquipoNull())
                {
                    MessageBox.Show("el tipo de equipo esta mal configurado");
                    return true;
                }
                txtTipoEquipo.Text = dsSpx1.tipoEquipo[0].nombreTipoEquipo;

                //
                if (!dsSpx1.Modelos[0].IscodSubTipoEquipoNull())
                {
                    subTipoEquipoTableAdapter1.FillBycodSubtipoEquipoTipoEquipo(dsSpx1.subTipoEquipo, dsSpx1.Modelos[0].codTipoEquipo, dsSpx1.Modelos[0].codSubTipoEquipo);
                    txtSubtipo.Text = dsSpx1.subTipoEquipo[0].nombreSubTipo;
                }

            }
            if (!dsSpx1.equipos[0].IscodModalidadEquipoNull())
            txtModalidad.Text = modalidadEquipoTableAdapter1.verNombreModadlidad(dsSpx1.equipos[0].codModalidadEquipo).ToString();
            
            if (dsSpx1.EntradaSalidaEquipos.Rows.Count <= 0 || dsSpx1.EntradaSalidaEquipos[0].serial != serial)
            {
                //Informacion del Cliente
                clientesTableAdapter1.FillByNitCliente(dsSpx1.clientes, dsSpx1.equipos[0].nitClienteUbica);
                txtNitCliente.Text = dsSpx1.clientes[0].nitCliente;
                txtNombrecliente.Text = dsSpx1.clientes[0].nombreCliente;
                //informacion de la ubicacion
                sucursalClienteTableAdapter1.FillByCodSucursalNit(dsSpx1.sucursalCliente, dsSpx1.clientes[0].nitCliente, dsSpx1.equipos[0].codSucursalUbica);
                txtSucursal.Text = dsSpx1.sucursalCliente[0].nombreSucursal;
                codSucursal = dsSpx1.sucursalCliente[0].codSucursal;

                if (!dsSpx1.sucursalCliente[0].IscodPaisNull() && !dsSpx1.sucursalCliente[0].IscodDepartamentoNull() && !dsSpx1.sucursalCliente[0].IscodCiudadNull())
                {
                    txtUbicacion.Text = "(" + paisesTableAdapter1.verNombrePais(dsSpx1.sucursalCliente[0].codPais).ToString().Trim();
                    txtUbicacion.Text += ") " + departamentoTableAdapter1.verNombreDepartamento(dsSpx1.sucursalCliente[0].codPais, dsSpx1.sucursalCliente[0].codDepartamento).ToString().Trim();
                    txtUbicacion.Text += ", " + ciudadesTableAdapter1.verNombreCiudad(dsSpx1.sucursalCliente[0].codPais, dsSpx1.sucursalCliente[0].codDepartamento, dsSpx1.sucursalCliente[0].codCiudad).ToString().Trim();
                }
            }else {
                //Informacion del Cliente
                clientesTableAdapter1.FillByNitCliente(dsSpx1.clientes, dsSpx1.EntradaSalidaEquipos[0].nitcliente);
                txtNitCliente.Text = dsSpx1.clientes[0].nitCliente;
                txtNombrecliente.Text = dsSpx1.clientes[0].nombreCliente;
                //informacion de la ubicacion
                sucursalClienteTableAdapter1.FillByCodSucursalNit(dsSpx1.sucursalCliente, dsSpx1.clientes[0].nitCliente, dsSpx1.EntradaSalidaEquipos[0].codSucursal);
                txtSucursal.Text = dsSpx1.sucursalCliente[0].nombreSucursal;
                codSucursal = dsSpx1.sucursalCliente[0].codSucursal;
                //informacion de la modalidad
                if (!dsSpx1.EntradaSalidaEquipos[0].IscodModalidadNull())
                    txtModalidad.Text = modalidadEquipoTableAdapter1.verNombreModadlidad(dsSpx1.EntradaSalidaEquipos[0].codModalidad).ToString();
            
                if (!dsSpx1.sucursalCliente[0].IscodPaisNull() && !dsSpx1.sucursalCliente[0].IscodDepartamentoNull() && !dsSpx1.sucursalCliente[0].IscodCiudadNull())
                {
                    txtUbicacion.Text = "(" + paisesTableAdapter1.verNombrePais(dsSpx1.sucursalCliente[0].codPais).ToString().Trim();
                    txtUbicacion.Text += ") " + departamentoTableAdapter1.verNombreDepartamento(dsSpx1.sucursalCliente[0].codPais, dsSpx1.sucursalCliente[0].codDepartamento).ToString().Trim();
                    txtUbicacion.Text += ", " + ciudadesTableAdapter1.verNombreCiudad(dsSpx1.sucursalCliente[0].codPais, dsSpx1.sucursalCliente[0].codDepartamento, dsSpx1.sucursalCliente[0].codCiudad).ToString().Trim();
                }
            }
            //validamos si tiene una recoleccion pendiente el archivo
            recoleccionTableAdapter1.FillByPendienteEquipo(dsSpx1.recoleccion, serial);
            lblRecoleccion.Visible= (dsSpx1.recoleccion.Count>0);
            //validamos si tiene equipos auxiliares si tiene equipos auxiliares preguntamos si desea desvincularlos
            if (!load && CodEntradaSalidaEquipos=="" && !preguntarDesvincularAsociados)
            {
                preguntarDesvincularAsociados = true;//siginifica que ya preguntamos!
                equipoAuxiliarTableAdapter1.FillByserialEquipo(dsSpx1.equipoAuxiliar, serial);
                if (dsSpx1.equipoAuxiliar.Count > 0)
                {
                   DesvincularAsociados= MessageBox.Show("Este equipo tiene equipos auxiliares vinculados, desea desvincular los equipos auxiliares del equipo principal?", "Equipo con equipos auxiliares!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes;
                   if (!DesvincularAsociados)
                   {
                       
                       dsSpx1.vistaEquipo.Clear();
                       for (int k = 0; k < dsSpx1.equipoAuxiliar.Count; k++)
                       {
                           dsSpx1.vistaEquipo.Merge(
                           vistaEquipoTableAdapter1.GetDataBySerial(dsSpx1.equipoAuxiliar[k].serialAuxiliar)
                           );
                       }
                   }
                }
            }

                return true;
        }

        private void txtSerial_Validating(object sender, CancelEventArgs e)
        {
            if (txtSerial.Text.Trim() == string.Empty) return;
            e.Cancel = !cargarserial(txtSerial.Text,false);
            if (e.Cancel) txtSerial.Text = "";
        }

        private void btnInfEquipo_Click(object sender, EventArgs e)
        {
            if (txtSerial.Text.Trim() == string.Empty) return;
            spProcesos.Equipos.frmInformacionEquipo frm = new spProcesos.Equipos.frmInformacionEquipo();
            frm.Serial = txtSerial.Text.Trim();
            frm.ShowDialog();
        }
        #endregion


        private bool guardar() 
        {
            if (!validar()) return false;
            //verificamos si es nuevo o si esta actualizando
            Nullable<DateTime> fechaN= new Nullable<DateTime>();
            Nullable<bool> boolN = new Nullable<bool>();
            Nullable<int> enteroNullo = new Nullable<int>();
    //        CgSmtpEmailSender.core.clsSender mailsender = new CgSmtpEmailSender.core.clsSender();
            if (codEntradaSalidaEquipos.Trim() == string.Empty)//nuevo
            {
                int codigo = entradaSalidaEquiposTableAdapter1.verNextId().Value;
                txtCodigoEntradaSalida.Text = codigo.ToString();
                codEntradaSalidaEquipos = codigo.ToString();
                entradaSalidaEquiposTableAdapter1.Insert(codigo, calFechaEntrada.Value, null, txtSerial.Text, cmbEstadoFisicamente.SelectedValue.ToString(),
                    null, cmbTipoServicio.SelectedValue.ToString().Trim(), txtObservaciones.Text,txtObservacionesSalida.Text,txtNitCliente.Text.Trim(),
                    dsSpx1.equipos[0].IscodSucursalUbicaNull()?null:dsSpx1.equipos[0].codSucursalUbica.Trim(),
                    dsSpx1.equipos[0].IscodModalidadEquipoNull()?null:dsSpx1.equipos[0].codModalidadEquipo.Trim(),
                    null,SPXSeguridad.logica.sesion.LoginUsuarioAutenticado,fechaN,fechaN,null,boolN,"",null,null,null,null,"","",DateTime.Now,null,
                    null,null,null,cmbUbicacionReal.SelectedValue.ToString().Trim(),null);
                //insertamos los accesorios
                for (int k = 0; k < dsSpx1.AccesoriosxEntradaSalidaEquipos.Rows.Count; k++)
                {
                    accesoriosxEntradaSalidaEquiposTableAdapter1.Insert(codigo, k + 1, true,
                        dsSpx1.AccesoriosxEntradaSalidaEquipos[k].codAccesoriosEquipos, dsSpx1.AccesoriosxEntradaSalidaEquipos[k].esOtro,
                        dsSpx1.AccesoriosxEntradaSalidaEquipos[k].descripcion, dsSpx1.AccesoriosxEntradaSalidaEquipos[k].cantidad);
                }
                entradaSalidaEquiposTableAdapter1.FillBycodEntradaSalidaEquipos(dsSpx1.EntradaSalidaEquipos,codigo);
                accesoriosxEntradaSalidaEquiposTableAdapter1.FillByEntradasCodEntradaSalida(dsSpx1.AccesoriosxEntradaSalidaEquipos,codigo);

                #region al ser nueva verificamos si existe alguna recoleccion pendiente de este equipo si existe la cambiamos de estado
                recoleccionTableAdapter1.FillByPendienteEquipo(dsSpx1.recoleccion, txtSerial.Text);
                if (dsSpx1.recoleccion.Count > 0)
                {
                    int codRecoleccion = 0;
                    if (dsSpx1.recoleccion.Count > 1)
                    {
                        //seleccion la recoleccion a asociar
                        MessageBox.Show("El equipo que ingreso tiene mas de una recoleccion en proceso, esta se actualizara de acuerdo a la informacion de la entrada", "Recoleccion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmListadoRecoleccion fr = new frmListadoRecoleccion();
                        fr.serial = txtSerial.Text.Trim();
                        if (fr.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                        {

                            return false;
                        }
                        else
                        {
                            codRecoleccion = fr.codRecoleccion;
                        }
                    }
                    else {
                        MessageBox.Show("El equipo que ingreso tenia una recoleccion en proceso, esta se actualizo de acuerdo a la informacion de la entrada", "Recoleccion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        codRecoleccion= dsSpx1.recoleccion[0].codRecoleccion;
                    }
                    
                    
                    recoleccionTableAdapter1.UpdateCodEstadoRecoleccion(5, codRecoleccion);
                    recoleccionTableAdapter1.UpdateRecoleccionFinal(calFechaEntrada.Value,
                        codigo, codRecoleccion);
                    #region zona de notificacion

                  //  mailsender.EjecutarAccion(605, dsSpx1.recoleccion[0].responsableRecoleccion, (System.Data.DataRow)dsSpx1.recoleccion[0],
                  //      null, CgSmtpEmailSender.core.clsSender.prioridad.media,"","");
                    #endregion
                }
#endregion
                if (DesvincularAsociados)
                {
                    equipoAuxiliarTableAdapter1.FillByserialEquipo(dsSpx1.equipoAuxiliar, txtSerial.Text);
                    //traemos el codigo de la ubicacion de destino
                        string codUbica = defaultsTableAdapter1.verCodUbicacionTrasladoEntradas().Trim();
                        string codEstado = defaultsTableAdapter1.verCodEstadoLocalTrasladoEntradas().Trim();
                    for (int k = 0; k < dsSpx1.equipoAuxiliar.Count; k++)
                    {
                        SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
                        DateTime n = dc.fechaServer;
                        spProcesos.Herramientas.frmTrasladosDeEquipos.trasladar(
                            "local", (codUbica.Trim() == string.Empty) ? null : codUbica, dsSpx1.equipoAuxiliar[k].serialAuxiliar,
                            "Desvinculacion de equipo auxiliar Al Crear la Entrada " + codigo + " del Equipo!", false, n, false, "", codEstado);
                   
                    }
                    equipoAuxiliarTableAdapter1.DeletebyEquipo(txtSerial.Text);
                    //validar si los equipos auxiliares los trae a taller
                }

#region Ingresamos los equipos auxiliares que tenga a equipos auxiliares x entrada.
                equipoAuxiliarTableAdapter1.FillByserialEquipo(dsSpx1.equipoAuxiliar, txtSerial.Text);
                for (int k = 0; k < dsSpx1.equipoAuxiliar.Count; k++)
                {
                    equiposAuxiliaresxEntradaTableAdapter1.Insert(int.Parse(codEntradaSalidaEquipos), dsSpx1.equipoAuxiliar[k].serialAuxiliar);
                }
#endregion
                    #region verificamos si el tipo de servicio me cambia la ubicacion base de datos del equipo
                    if ( chkCambiarUbicacionEquipo.Checked )
                    {
                        //ademas verificamos que no tenga creada ya orden de servicio
                        if (txtOrdenServicio.Text.Trim() == string.Empty)
                        {
                            //traemos el codigo de la ubicacion de destino
                            string codUbica = cmbUbicacionReal.SelectedValue.ToString();
                            string codEstado = defaultsTableAdapter1.verCodEstadoLocalTrasladoEntradas().Trim();
                            spProcesos.Herramientas.frmTrasladosDeEquipos.trasladar(
                                "local", (codUbica.Trim() == string.Empty) ? null : codUbica, txtSerial.Text,
                                "Cambio de ubicacion automatico al crear la Entrada " + codigo + " del Equipo!", false, DateTime.Now, false, "", codEstado);

                            //spProcesos.Herramientas.frmTrasladosDeEquipos.trasladar(
                            //    "local", (codUbica.Trim() == string.Empty) ? null : codUbica, txtSerial.Text,
                            //    "Se cambia La ubicacion Al Crear la Entrada " + codigo + " del Equipo!", false, DateTime.Now, false, "", codEstado);
                        }
                    }
                #endregion
   
                
                #region zona de notificacion

             //   mailsender.EjecutarAccion(201, "", (System.Data.DataRow)dsSpx1.EntradaSalidaEquipos[0], null, CgSmtpEmailSender.core.clsSender.prioridad.media,"","");
                #endregion
                    equiposTableAdapter1.UpdateUbicacionReal("local",cmbUbicacionReal.SelectedValue.ToString(), txtSerial.Text);
                    chkCambiarUbicacionEquipo.Visible = false;
                    cmbUbicacionReal.Enabled = false;
            }
            else{

                entradaSalidaEquiposTableAdapter1.UpdateQuery(
                    (calFechaEntrada.ValueObject == null) ? fechaN : calFechaEntrada.Value,
                    txtSerial.Text,
                    (cmbEstadoFisicamente.SelectedValue == null)?null:cmbEstadoFisicamente.SelectedValue.ToString(),
                    (txtOrdenServicio.Text.Trim() ==string.Empty) ?enteroNullo :int.Parse(txtOrdenServicio.Text),
                    cmbTipoServicio.SelectedValue.ToString(), txtObservaciones.Text,
                    txtNitCliente.Text,
                    dsSpx1.EntradaSalidaEquipos[0].IscodSucursalNull()?null: dsSpx1.EntradaSalidaEquipos[0].codSucursal,
                    dsSpx1.EntradaSalidaEquipos[0].IscodModalidadNull() ? null : dsSpx1.EntradaSalidaEquipos[0].codModalidad,
                     int.Parse(codEntradaSalidaEquipos));
                
                //actualizamos los accesorios
                accesoriosxEntradaSalidaEquiposTableAdapter1.Update(dsSpx1.AccesoriosxEntradaSalidaEquipos);
                dsSpx1.AccesoriosxEntradaSalidaEquipos.AcceptChanges();
                entradaSalidaEquiposTableAdapter1.FillBycodEntradaSalidaEquipos(dsSpx1.EntradaSalidaEquipos,int.Parse(codEntradaSalidaEquipos));

                #region verificamos si el tipo de servicio me cambia la ubicacion base de datos del equipo
                  bool? permiteCambiarUbicacion = defaultsTableAdapter1.VerTrasladosAutomaticosEntradas();

                  if (permiteCambiarUbicacion.HasValue && permiteCambiarUbicacion.Value)
                  {

                      if (
                          !tipoServicioTableAdapter1.GetDataBycodTipoServicio(cmbTipoServicio.SelectedValue.ToString())[0].IsdevuelveEntradaNull()
                          &&
                          tipoServicioTableAdapter1.GetDataBycodTipoServicio(cmbTipoServicio.SelectedValue.ToString())[0].devuelveEntrada)
                      {
                          //ademas verificamos que no tenga creada ya orden de servicio
                          if (txtOrdenServicio.Text.Trim() == string.Empty)
                          {
                              //traemos el codigo de la ubicacion de destino
                              string codUbica = defaultsTableAdapter1.verCodUbicacionTrasladoEntradas().Trim();
                              string codEstado = defaultsTableAdapter1.verCodEstadoLocalTrasladoEntradas().Trim();
                              spProcesos.Herramientas.frmTrasladosDeEquipos.trasladar(
                                  "local", (codUbica.Trim() == string.Empty) ? null : codUbica, txtSerial.Text,
                                  "Se cambia La ubicacion Al Guardar la Entrada " + txtCodigoEntradaSalida.Text + " del Equipo!", false, DateTime.Now, false, "", codEstado);
                          }
                      }
                  }
                #endregion

                #region zona de notificacion
            //    mailsender.EjecutarAccion(202, "", (System.Data.DataRow)dsSpx1.EntradaSalidaEquipos[0], null, CgSmtpEmailSender.core.clsSender.prioridad.media,"","");
                #endregion
            }
            ajustarControles();
            bloquearControles();
            return true;
        }
        
        private bool validar() 
        {
            if (txtSerial.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El serial del equipo es obligatorio");
                txtSerial.Focus();
                return false;
            }
            if (calFechaEntrada.ValueObject == null)
            {
                MessageBox.Show("La fecha de entrada es obligatoria");
                calFechaEntrada.Focus();
                return false;
            }
            if (cmbEstadoFisicamente.Text.Trim() == string.Empty) 
            {
                MessageBox.Show("El estado fisico del equipo es obligatorio");
                cmbEstadoFisicamente.Focus();
                return false;
            }
            if (cmbTipoServicio.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El tipo de servicio es obligatorio");
                cmbTipoServicio.Focus();
                return false;
            }
            if (cmbUbicacionReal.SelectedValue == null || cmbUbicacionReal.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("la Bodega de entrada es obligatoria!");
                cmbUbicacionReal.Focus();
                return false;
            
            }
            return true;
        }

        private void btnCrearOrdenServicio_Click(object sender, EventArgs e)
        {
            //aca crea una orden de servicio
            guardar();
            ordenesTrabajo.frmNuevaOrdenTrabajo frm = new spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo();
            frm.NumeroEntrada = codEntradaSalidaEquipos;
            frm.mostrarDialogo=true;
            if (frm.ShowDialog() == DialogResult.OK && frm.CodOrdenServicio.Trim() != string.Empty)
            {
                //actuaizamos el codigo de la ordn
                entradaSalidaEquiposTableAdapter1.UpdateCodOrdenServicio(int.Parse(frm.CodOrdenServicio), int.Parse(codEntradaSalidaEquipos));
                txtOrdenServicio.Text = frm.CodOrdenServicio;
                btnCrearOrdenServicio.Visible = false;
                btnVerOs.Visible = true;
            }
        }

        private void tabControl1_SelectedTabChanging(object sender, DevComponents.DotNetBar.TabStripTabChangingEventArgs e)
        {
            //si esta intentnado ingresar la salida primero verificamos que cumpla las siguientes condiciones
            //1 que tenga una orden de servicio
            //2 que la orden de servicio este cerrada
            if (dsSpx1.EntradaSalidaEquipos.Count <= 0)
            {
                MessageBox.Show("Guarde Primero La Entrada Antes de Ingresar La Salida, El Seguimiento o archivos asociados.");
                e.Cancel = true;
                return;
            }
            
            if (e.NewTab.Text.IndexOf("Salida") >= 0)
            {
                if (txtOrdenServicio.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("No puede ingresar la salida del equipo si este no tiene una orden de servicio asociada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Cancel = true;
                    return;
                }
                //traemos el estado de la orden de servicio
                ordenServicioTableAdapter1.FillByCodOrdenServicio(dsSpx1.ordenServicio, int.Parse(txtOrdenServicio.Text));

                if (dsSpx1.ordenServicio[0].codEstadoOrdenServicio == "EJECU" || 
                    dsSpx1.ordenServicio[0].codEstadoOrdenServicio == "PROGR" ||
                    dsSpx1.ordenServicio[0].codEstadoOrdenServicio == "NUEVA" ||
                    dsSpx1.ordenServicio[0].codEstadoOrdenServicio == "ENESP"                    
                    
                    )
                {
                        MessageBox.Show("No puede ingresar la salida del equipo hasta que la orden de servicio este cerrada!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        e.Cancel = true;
                        return;
                } 
            }

            if (e.NewTab.Text.IndexOf("Seguimiento") >= 0)
            {
                if (dsSpx1.EntradaSalidaEquipos[0].IsfechaSalidaNull())
                {
                    MessageBox.Show("No puede ingresar el Seguimiento si la salida no tiene la fecha de salida!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Cancel = true;
                    return;
                }
            }else

            if (e.NewTab.Text.IndexOf("Archivos") >= 0)
            {
                archivosxEntradaSalidaEquiposTableAdapter1.FillBycodEntradaSalidaEquipos(dsSpx1.archivosxEntradaSalidaEquipos,int.Parse(codEntradaSalidaEquipos));
                if (dsSpx1.EntradaSalidaEquipos[0].Isanulada_porNull())
                {
                    btnAgregarArchivo.Enabled = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1034);
                    btnEliminarArchivo.Enabled = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1035);
                }
            }
        }

        #region zona de impresion
        private void imprimir(int opcion)
        {
            string ruta = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter objDef = new SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter();
            objDef.Fill(dsSpx1.defaults);
            string strReporte = "";
            switch (opcion)
            {
                case 1: { strReporte = "rptESEquiposEntrada"; break; }
                case 2: { strReporte = "rptESEquiposSalida"; break; }
                case 3: { strReporte = "rptESEquipos"; break; }
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
                if (!dsSpx1.defaults[0].IstituloRegistroEntradaSalidaNull())
                    reporte.Fields["lblTitulo"].Value = dsSpx1.defaults[0].tituloRegistroEntradaSalida.Trim();
            }
            if (reporte.Fields.Contains("lblVersion"))
            {
                if (!dsSpx1.defaults[0].IsversionRegistroEntradaSalidaNull())
                    reporte.Fields["lblVersion"].Value = dsSpx1.defaults[0].versionRegistroEntradaSalida.Trim();
            }
            if (reporte.Fields.Contains("lblTipoDocumento"))
            {
                if (!dsSpx1.defaults[0].IscodigoEntradaSalidaNull())
                    reporte.Fields["lblTipoDocumento"].Value = dsSpx1.defaults[0].codigoEntradaSalida.Trim();
            }
            if (reporte.Fields.Contains("lblVigencia"))
            {
                if (!dsSpx1.defaults[0].IsfechaVigenciaEntradaSalidaNull())
                    reporte.Fields["lblVigencia"].Value = dsSpx1.defaults[0].fechaVigenciaEntradaSalida.ToShortDateString();
            }
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            reporte.DataSource.ConnectionString = objData.CadenaConexionReportes;
            reporte.DataSource.RecordSource = reporte.DataSource.RecordSource.Replace("<<codEntrada>>", txtCodigoEntradaSalida.Text);

            var frmRpt = new SPControladoraDatos.artefactos.SPXQuery.frm.Reportes.frmReporte (reporte);
            frmRpt.Icon = this.Icon;

            frmRpt.ShowDialog();

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            frmImprimirEntradaSalida fr = new frmImprimirEntradaSalida();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                imprimir(fr.opcion);
            }
        }
        #endregion
        #region accesorios de entrada
        private int verCodigoAccesorio()
        {
            int maximo = 0;
            for (int k = 0; k < dsSpx1.AccesoriosxEntradaSalidaEquipos.Rows.Count; k++)
            {
                if (dsSpx1.AccesoriosxEntradaSalidaEquipos[k].Codigo > maximo)
                    maximo = dsSpx1.AccesoriosxEntradaSalidaEquipos[k].Codigo;
            }
            return maximo + 1;
        }

        private void btnAgregarComponenteEntrada_Click(object sender, EventArgs e)
        {
            frmBuscarAccesorio fr = new frmBuscarAccesorio();
            fr.Fabricante = txtFabricante.Text.Trim().ToUpper();
            fr.Modelo = txtModelo.Text.Trim().ToUpper();
            if (fr.ShowDialog() == DialogResult.OK) 
            {
                SPControladoraDatos.dsSpx.AccesoriosxEntradaSalidaEquiposRow fila
                    = dsSpx1.AccesoriosxEntradaSalidaEquipos.NewAccesoriosxEntradaSalidaEquiposRow();
                fila.codEntradaSalidaEquipos = int.Parse(txtCodigoEntradaSalida.Text.Trim());
                fila.Codigo = verCodigoAccesorio();
                fila.cantidad = fr.Cantidad;
                fila.descripcion = fr.NombreAccesorio;
                fila.esOtro = fr.EsOtro;
                fila.codAccesoriosEquipos = fr.CodigoAccesorio;
                fila.sonDeEntrada = true;
                dsSpx1.AccesoriosxEntradaSalidaEquipos.AddAccesoriosxEntradaSalidaEquiposRow(fila);
            }
        }
        private void btnEliminarComponenteEntrada_Click(object sender, EventArgs e)
        {
            if(grdAccesoriosLlegada.Columns[0].Text.Trim() == string.Empty)return;
            if(MessageBox.Show("Esta seguro de eliminar este accesorio","Pregunta",MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                dsSpx1.AccesoriosxEntradaSalidaEquipos.Rows.RemoveAt(grdAccesoriosLlegada.RowBookmark(grdAccesoriosLlegada.Row)); 
            }
        }
        private void btnModificarComponenteEntrada_Click(object sender, EventArgs e)
        {
            if (grdAccesoriosLlegada.Columns[0].Text.Trim() == string.Empty) return;
            frmModificaAccesorios fr = new frmModificaAccesorios();
            fr.CodigoAccesorio = grdAccesoriosLlegada.Columns["codAccesoriosEquipos"].Text.Trim();
            fr.Cantidad = float.Parse(grdAccesoriosLlegada.Columns["cantidad"].Text.Trim());
            fr.NombreAccesorio = grdAccesoriosLlegada.Columns["descripcion"].Text.Trim();
            
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dsSpx1.AccesoriosxEntradaSalidaEquipos[grdAccesoriosLlegada.RowBookmark(grdAccesoriosLlegada.Row)].cantidad = fr.Cantidad;
            }

        }
        #endregion
        #region accesorios de salida
        private int verCodigoAccesorioSalida()
        {
            int maximo = 0;
            for (int k = 0; k < dsSpx2.AccesoriosxEntradaSalidaEquipos.Rows.Count; k++)
            {
                if (dsSpx2.AccesoriosxEntradaSalidaEquipos[k].Codigo > maximo)
                    maximo = dsSpx2.AccesoriosxEntradaSalidaEquipos[k].Codigo;
            }
            return maximo + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (grdDatosSalida.Columns[0].Text.Trim() == string.Empty) return;
            frmModificaAccesorios fr = new frmModificaAccesorios();
            fr.CodigoAccesorio = grdDatosSalida.Columns["codAccesoriosEquipos"].Text.Trim();
            fr.Cantidad = float.Parse(grdDatosSalida.Columns["cantidad"].Text.Trim());
            fr.NombreAccesorio = grdDatosSalida.Columns["descripcion"].Text.Trim();

            if (fr.ShowDialog() == DialogResult.OK)
            {
                dsSpx2.AccesoriosxEntradaSalidaEquipos[grdDatosSalida.RowBookmark(grdDatosSalida.Row)].cantidad = fr.Cantidad;
            }

        }

        private void btnAgregarAccesorioSalida_Click(object sender, EventArgs e)
        {
            frmBuscarAccesorio fr = new frmBuscarAccesorio();
            fr.Fabricante = txtFabricante.Text.Trim().ToUpper();
            fr.Modelo = txtModelo.Text.Trim().ToUpper();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                SPControladoraDatos.dsSpx.AccesoriosxEntradaSalidaEquiposRow fila
                    = dsSpx2.AccesoriosxEntradaSalidaEquipos.NewAccesoriosxEntradaSalidaEquiposRow();
                fila.codEntradaSalidaEquipos = int.Parse(txtCodigoEntradaSalida.Text.Trim());
                fila.Codigo = verCodigoAccesorioSalida();
                fila.cantidad = fr.Cantidad;
                fila.descripcion = fr.NombreAccesorio;
                fila.esOtro = fr.EsOtro;
                fila.codAccesoriosEquipos = fr.CodigoAccesorio;
                fila.sonDeEntrada = false;
                dsSpx2.AccesoriosxEntradaSalidaEquipos.AddAccesoriosxEntradaSalidaEquiposRow(fila);
            }
        }

        private void btnEliminarAccesorioSalida_Click(object sender, EventArgs e)
        {
            if (grdAccesoriosLlegada.Columns[0].Text.Trim() == string.Empty) return;
            if (MessageBox.Show("Esta seguro de eliminar este accesorio", "Pregunta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dsSpx2.AccesoriosxEntradaSalidaEquipos.Rows.RemoveAt(grdDatosSalida.RowBookmark(grdDatosSalida.Row));
            }
        }
        #endregion
       
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!guardar()) return;
            //para ver los cambios hacemos el fill
            entradaSalidaEquiposTableAdapter1.FillBycodEntradaSalidaEquipos(dsSpx1.EntradaSalidaEquipos, int.Parse(codEntradaSalidaEquipos));
       
        
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!guardar()) return;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void calSeguimiento_Click(object sender, EventArgs e)
        {
            if (dsSpx1.EntradaSalidaEquipos.Count <= 0) return;
            if (dsSpx1.EntradaSalidaEquipos[0].IsusuarioSeguimientoNull())
            {
                cmbSeguimientoPor.SelectedValue = SPXSeguridad.logica.sesion.LoginUsuarioAutenticado;
                calSeguimiento.Value = DateTime.Now;
            }

        }

        private void btnAgregarSeguimiento_Click(object sender, EventArgs e)
        {
            if(seguimientoEquipo){
            btnAceptarSeguimiento.Visible = true;
            btnCancelarSeguimietno.Visible = true;
            btnAgregarSeguimiento.Visible = false;
            
            calSeguimiento.Enabled=true;
                calGrabacionSeguimiento.Value=DateTime.Now;
                cmbSeguimientoPor.SelectedValue = SPXSeguridad.logica.sesion.LoginUsuarioAutenticado;
                rdFuncionaBien.Enabled = true;
                rdNofuncionaBien.Enabled = true;
                txtObservacionesSeguimiento.Enabled = true;
            }else{
                MessageBox.Show("No tiene permisos para hacer esta Accion!!!");
            }

        }

        private void btnCancelarSeguimietno_Click(object sender, EventArgs e)
        {
            //primero los estados
            btnAceptarSeguimiento.Visible = false;
            btnCancelarSeguimietno.Visible = false;
            btnAgregarSeguimiento.Visible = true;

            calSeguimiento.Enabled = false;
            rdFuncionaBien.Enabled = false;
            rdNofuncionaBien.Enabled = false;
            txtObservacionesSeguimiento.Enabled = false;

            if (dsSpx1.EntradaSalidaEquipos.Count <= 0) return;
            
            if(!dsSpx1.EntradaSalidaEquipos[0].IsusuarioSeguimientoNull())
                cmbSeguimientoPor.SelectedValue = dsSpx1.EntradaSalidaEquipos[0].usuarioSeguimiento;

            if (!dsSpx1.EntradaSalidaEquipos[0].IsfechaSeguimientoNull())
                calSeguimiento.Value = dsSpx1.EntradaSalidaEquipos[0].fechaSeguimiento;
            else
                calSeguimiento.ValueObject = null;
            
            if (!dsSpx1.EntradaSalidaEquipos[0].IsfechaIngresoSeguimientoNull())
                calGrabacionSeguimiento.Value = dsSpx1.EntradaSalidaEquipos[0].fechaIngresoSeguimiento;
            else
                calGrabacionSeguimiento.ValueObject = null;

            if (!dsSpx1.EntradaSalidaEquipos[0].IsfuncionabienNull()) {
                rdNofuncionaBien.Checked =!dsSpx1.EntradaSalidaEquipos[0].funcionabien;
                rdFuncionaBien.Checked = dsSpx1.EntradaSalidaEquipos[0].funcionabien;
            }else{
                rdFuncionaBien.Checked = false;
                rdNofuncionaBien.Checked = false;
            }
            if (!dsSpx1.EntradaSalidaEquipos[0].IsobservacionesNull()) txtObservacionesSeguimiento.Text = dsSpx1.EntradaSalidaEquipos[0].observaciones;
        }

        private void btnAceptarSeguimiento_Click(object sender, EventArgs e)
        {
            //validamos
            if (!rdFuncionaBien.Checked && !rdFuncionaMal.Checked)
            {
                MessageBox.Show("debe ingresar si el equipo Funciona Bien o No");
                return;
            }
            
            if (calSeguimiento.ValueObject == null)
            {
                MessageBox.Show("debe ingresar la fecha del Seguimiento");
                return;
            }
            
            if (cmbSeguimientoPor.SelectedValue == null || cmbSeguimientoPor.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Debe ingresar Quien realizo el permiso");
                return;
            }
            //primero los estados
            btnAceptarSeguimiento.Visible = false;
            btnCancelarSeguimietno.Visible = false;
            btnAgregarSeguimiento.Visible = true;

            calSeguimiento.Enabled = false;
            rdFuncionaBien.Enabled = false;
            rdNofuncionaBien.Enabled = false;
            txtObservacionesSeguimiento.Enabled = false;
            //guardamos la informacion
            entradaSalidaEquiposTableAdapter1.UpdateSeguimiento(calGrabacionSeguimiento.Value,
               calSeguimiento.Value, cmbSeguimientoPor.SelectedValue.ToString(),
               rdFuncionaBien.Checked, txtObservacionesSeguimiento.Text, int.Parse(codEntradaSalidaEquipos));
            entradaSalidaEquiposTableAdapter1.FillBycodEntradaSalidaEquipos(dsSpx1.EntradaSalidaEquipos, int.Parse(codEntradaSalidaEquipos));
            #region zona de notificacion
          //  CgSmtpEmailSender.core.clsSender mailsender = new CgSmtpEmailSender.core.clsSender();
           // mailsender.EjecutarAccion(204, "", (System.Data.DataRow)dsSpx1.EntradaSalidaEquipos[0], null, CgSmtpEmailSender.core.clsSender.prioridad.media,"","");
            #endregion
        }

        private void btnIngresarSalida_Click(object sender, EventArgs e)
        {
            if (salidaEquipo)
            {
                //--
                ejecutarReserva = false;
                codMovimientoReserva = 0;

                //primero los estados
                btnAceptarSalida.Visible = true;
                btnCancelarSalida.Visible = true;
                btnIngresarSalida.Visible = false;
                //---
                calFechaSalida.Enabled = true;
                btnAgregarAccesorioSalida.Enabled = true;
                btnEliminarAccesorioSalida.Enabled = true;
                btnModificarAccesorioSalida.Enabled = true;
                txtObservacionesSalida.Enabled = true;
                txtOp.Enabled = true;
                txtFactura.Enabled = true;
                btnImportarDesdeEntrada.Enabled = true;
                cmbCliente.Enabled = true;
                cmbSucursalCliente.Enabled = true;
                cmbModaldad.Enabled = true;
                cmbMotivoSalida.Enabled = true;
                cmbEstadoEquipoLocal.Enabled = true;
                btnBuscarNit.Enabled = true;
                btnLimpiarCliente.Enabled = true;
                //validamos si hay reservados modelos 
                #region verificamos si hay reservas del mismo modelo, si hay reservas para el mismo modelo, alertamos!!!
                SPXdata.BD.DataConector obj=new SPXdata.BD.DataConector();
                string sql = @"select 
cod_movimiento,tipo_movimiento.nombre_tipo_movimiento,fecha_creacion
,usuario.nombre 'Creado Por',
fabricante.nombre_Fabricante,modelos.nombreModelo,
clientes.nitCliente,clientes.nombreCliente,sucursalCliente.codSucursal,
observaciones_iniciales,
movimiento.num1 'Reservado',movimiento.num2 'Entregado',
color_r,color_g,color_b,texto_alarma,
fecha_ultimo_cambio
 from movimiento
left join fabricante on fabricante.codfabricante = movimiento.txt2
left join modelos on fabricante.codfabricante = modelos.codFabricante and movimiento.txt3 = modelos.codModelo
join usuario on usuario.cod_usuario = movimiento.usuario_creacion
left join tipo_movimiento on tipo_movimiento.cod_tipo_movimiento= movimiento.cod_tipo_movimiento
left join clientes on clientes.NitCliente = movimiento.txt4
left join sucursalCliente on sucursalCliente.nitCliente = clientes.nitCliente and movimiento.txt5 = sucursalCliente.codSucursal
where 
cod_proceso_semilla=2
and fabricante.codfabricante = '" + dsSpx1.equipos[0].codFabricante.Trim().Trim() + @"'
 and  modelos.codModelo ='" + dsSpx1.equipos[0].codModelo.Trim().Trim() + @"'
and movimiento.num1 - isnull(movimiento.num2,0) !=0 order by fecha_creacion asc";
                System.Data.DataTable tb = obj.ejecutarConsulta(sql).Tables[0];
                #endregion
                if (tb.Rows.Count > 0)
                {
                    if (MessageBox.Show("Hay una reserva para un equipo de este modelo, desea aplicarla en este momento?", "Confirmacion", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        codMovimientoReserva = long.Parse(tb.Rows[0]["cod_movimiento"].ToString());
                        cmbCliente.SelectedValue = tb.Rows[0]["nitCliente"].ToString();
                        cargarSucursal();
                        cmbSucursalCliente.SelectedValue = tb.Rows[0]["codSucursal"].ToString();
                        cargarSucursalCliente();
                        cmbCliente.Enabled = false;
                        cmbSucursalCliente.Enabled = false;
                        ejecutarReserva = true;
                    }
                }
                
                //validamos si el equipo esta resevado
                if (cmbCliente.Enabled && !dsSpx1.equipos[0].IsnitClienteReservaNull())
                {
                    lblReservado.Visible = true;
                    cmbCliente.SelectedValue = dsSpx1.equipos[0].nitClienteReserva;
                    cargarSucursal();
                    cmbSucursalCliente.SelectedValue = dsSpx1.equipos[0].codSucursalReserva;
                    cargarSucursalCliente();
                    if (!dsSpx1.equipos[0].IscodModadlidadReservaNull()) 
                    cmbModaldad.SelectedValue = dsSpx1.equipos[0].codModadlidadReserva;

                    if (!dsSpx1.equipos[0].IscodEstadoLocalReservaNull())
                        cmbEstadoEquipoLocal.SelectedValue = dsSpx1.equipos[0].codEstadoLocalReserva;
                }else{
                    lblReservado.Visible = false;
                }
            }else{
                MessageBox.Show("No tiene permisos para realizar la Accion!!");
            }
        }

        bool   ejecutarReserva = false;
        long   codMovimientoReserva = 0;

        private void btnCancelarSalida_Click(object sender, EventArgs e)
        {
            //primero los estados
            btnAceptarSalida.Visible = false;
            btnCancelarSalida.Visible = false;
            btnImportarDesdeEntrada.Enabled = false;
            btnIngresarSalida.Visible = true;
            calFechaSalida.Enabled = false;
            btnAgregarAccesorioSalida.Enabled = false;
            btnEliminarAccesorioSalida.Enabled = false;
            btnModificarAccesorioSalida.Enabled = false;
            txtObservacionesSalida.Enabled = false;
            cmbCliente.Enabled = false;
            cmbSucursalCliente.Enabled = false;
            cmbEstadoEquipoLocal.Enabled = false;
            btnBuscarNit.Enabled = false;
            txtOp.Enabled = false;
            txtFactura.Enabled = false;
            btnLimpiarCliente.Enabled = false;
            cmbModaldad.Enabled = false;
            cmbMotivoSalida.Enabled = false;
            
            if (dsSpx1.EntradaSalidaEquipos.Count <= 0) return;

            txtObservacionesSalida.Text = dsSpx1.EntradaSalidaEquipos[0].obsSalida;
            if (!dsSpx1.EntradaSalidaEquipos[0].IsfechaSalidaNull())
                calFechaSalida.Value = dsSpx1.EntradaSalidaEquipos[0].fechaSalida;
            else
                calFechaSalida.ValueObject = null;

            accesoriosxEntradaSalidaEquiposTableAdapter1.FillBySalidasCodEntradaSalida(dsSpx2.AccesoriosxEntradaSalidaEquipos,
                int.Parse(codEntradaSalidaEquipos));
        }

        private void btnAceptarSalida_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.dsSpx dsEquipo=new SPControladoraDatos.dsSpx();
            equiposTableAdapter1.FillBySerial(dsEquipo.equipos, txtSerial.Text);
            SPControladoraDatos.dsSpxTableAdapters.sucursalClienteTableAdapter ue = new SPControladoraDatos.dsSpxTableAdapters.sucursalClienteTableAdapter();
            string nit = "";
            string sucursal = "";
            if (!dsEquipo.equipos[0].IsnitClienteUbicacionRealNull())
            {
                nit = dsEquipo.equipos[0].nitClienteUbicacionReal;
                sucursal = dsEquipo.equipos[0].codSucursalUbicaReal;
            }
            else {
                nit = dsEquipo.equipos[0].nitClienteUbica;
                sucursal = dsEquipo.equipos[0].codSucursalUbica;
            }
            ue.FillByCodSucursalNit(dsEquipo.sucursalCliente, nit,sucursal);
            if (!dsEquipo.sucursalCliente[0].IsbloqueaSalidaNull() && dsEquipo.sucursalCliente[0].bloqueaSalida)
            {
                MessageBox.Show("Cuando el equipo esta en la bodega "+dsEquipo.sucursalCliente[0].nombreSucursal.Trim() +" no se puede trasladar a un cliente","Bodega Bloqueada");
                return;
            }
            

            if (calFechaSalida.ValueObject == null)
            {
                MessageBox.Show("Ingrese la Fecha de Salida");
                return;
            }
            if (cmbCliente.SelectedValue == null || cmbCliente.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("El cliente es Obligatorio.");
                return;
            }
            if (cmbCliente.SelectedValue == null || cmbCliente.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("La Sucursal es Obligatoria.");
                return;
            }
            if (cmbModaldad.Visible && (cmbModaldad.SelectedValue == null || cmbModaldad.SelectedValue.ToString().Trim() == string.Empty))
            {
                MessageBox.Show("La Modalidad es Obligatoria.");
                return;
            }
            if (cmbMotivoSalida.Visible && (cmbMotivoSalida.SelectedValue == null || cmbMotivoSalida.SelectedValue.ToString().Trim() == string.Empty))
            {
                MessageBox.Show("El motivo de salida es obligatorio!!");
                return;
            }
            if (!cmbModaldad.Visible && (cmbEstadoEquipoLocal.SelectedValue == null || cmbEstadoEquipoLocal.SelectedValue.ToString().Trim() == string.Empty))
            {
                MessageBox.Show("Los equipos que van a taller deben tener un estado local.");
                return;
            }


            btnImportarDesdeEntrada.Enabled = false;
            btnAceptarSalida.Visible = false;
            btnCancelarSalida.Visible = false;
            btnIngresarSalida.Visible = true;
            calFechaSalida.Enabled = false;
            btnAgregarAccesorioSalida.Enabled = false;
            btnEliminarAccesorioSalida.Enabled = false;
            btnModificarAccesorioSalida.Enabled = false;
            txtOp.Enabled = false;
            txtFactura.Enabled = false;
            txtObservacionesSalida.Enabled = false;
            cmbCliente.Enabled = false;
            cmbSucursalCliente.Enabled = false;
            cmbModaldad.Enabled = false;
            cmbEstadoEquipoLocal.Enabled = false;
            btnBuscarNit.Enabled = false;
            btnLimpiarCliente.Enabled = false;
            if (calFechaTerminacion.ValueObject == null)
            {
                if (dsSpx1.ordenServicio.Count > 0 && !dsSpx1.ordenServicio[0].IsfechaCierreNull())
                    calFechaTerminacion.Value = dsSpx1.ordenServicio[0].fechaCierre;
                else
                    calFechaTerminacion.Value = DateTime.Now;
            }

            entradaSalidaEquiposTableAdapter1.UpdateSalida(calFechaSalida.Value, txtObservacionesSalida.Text,
                calFechaTerminacion.Value,cmbCliente.SelectedValue.ToString(),cmbSucursalCliente.SelectedValue.ToString(),
                (cmbModaldad.SelectedValue == null || cmbModaldad.SelectedValue.ToString().Trim()==string.Empty)?null:cmbModaldad.SelectedValue.ToString()
                ,(!cmbEstadoEquipoLocal.Visible)?null:   cmbEstadoEquipoLocal.SelectedValue.ToString()
                , int.Parse(codEntradaSalidaEquipos));
            entradaSalidaEquiposTableAdapter1.UpdateFacturaOp(txtOp.Text,txtFactura.Text, int.Parse(codEntradaSalidaEquipos));
            entradaSalidaEquiposTableAdapter1.UpdateCod_motivo_salida(int.Parse(cmbMotivoSalida.SelectedValue.ToString()),int.Parse(CodEntradaSalidaEquipos));
            entradaSalidaEquiposTableAdapter1.FillBycodEntradaSalidaEquipos(dsSpx1.EntradaSalidaEquipos, int.Parse(codEntradaSalidaEquipos));
            cmbMotivoSalida.Enabled = false;
            #region zona de notificacion
          //  CgSmtpEmailSender.core.clsSender mailsender = new CgSmtpEmailSender.core.clsSender();
          //  mailsender.EjecutarAccion(203, "", (System.Data.DataRow)dsSpx1.EntradaSalidaEquipos[0], null, CgSmtpEmailSender.core.clsSender.prioridad.media,"","");
            #endregion
            
            
            //miramos si debemos insertarlo en el log de traslados
            if (cmbCliente.SelectedValue.ToString().Trim() != dsSpx1.EntradaSalidaEquipos[0].nitcliente
                && cmbSucursalCliente.SelectedValue.ToString().Trim() != dsSpx1.EntradaSalidaEquipos[0].codSucursal)
            {
                //verficamos que ya no este en el log
                logCambioUbicacionesTableAdapter1.FillByValidarSalida(dsSpx1.logCambioUbicaciones,
                    dsSpx1.EntradaSalidaEquipos[0].nitcliente, dsSpx1.EntradaSalidaEquipos[0].codSucursal,
                    cmbCliente.SelectedValue.ToString(), cmbSucursalCliente.SelectedValue.ToString(),
                    calFechaSalida.Value);
                if (dsSpx1.logCambioUbicaciones.Count <= 0)
                {
                    spProcesos.Herramientas.frmTrasladosDeEquipos.trasladar(
                        cmbCliente.SelectedValue.ToString(), cmbSucursalCliente.SelectedValue.ToString(),
                        txtSerial.Text, "Proceso Automatico de Entrada y Salida de Equipos", true,
                        calFechaSalida.Value, cmbModaldad.Visible,(cmbModaldad.Visible)? cmbModaldad.SelectedValue.ToString():"",
                        (cmbEstadoEquipoLocal.Visible)?cmbEstadoEquipoLocal.SelectedValue.ToString():"");
                }
            }

            accesoriosxEntradaSalidaEquiposTableAdapter1.Update(dsSpx2.AccesoriosxEntradaSalidaEquipos);
            dsSpx2.AccesoriosxEntradaSalidaEquipos.AcceptChanges();
            //ahora validamos si debemos limpiar la reserva o no
            guardar();
            //if (ejecutarReserva)
            //{
            //    spProcesos.disponibles.frmEjecutarReserva frmEjecu = new disponibles.frmEjecutarReserva();
            //    frmEjecu.ejecutarReserva(codMovimientoReserva, txtSerial.Text);
            //}else 
            if( !dsSpx1.equipos[0].IsnitClienteReservaNull() )
            {      
                equiposTableAdapter1.UpdateReserva(dsSpx1.equipos[0].nitClienteReserva, dsSpx1.equipos[0].codSucursalReserva,
                    (dsSpx1.equipos[0].IscodModadlidadReservaNull()) ? null : dsSpx1.equipos[0].codModadlidadReserva,
                        (dsSpx1.equipos[0].IscodEstadoLocalReservaNull()) ? null : dsSpx1.equipos[0].codEstadoLocalReserva,
                        txtSerial.Text);
                if (
                    dsSpx1.equipos[0].nitClienteReserva.Trim() == cmbCliente.SelectedValue.ToString().Trim()
                    ||
                    MessageBox.Show("Esta enviando el equipo a un cliente diferente del que esta reservado\r\nDesea limpiar la reserva?", "Reserva No Tenida en cuenta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes
                    )
                {
                    equiposTableAdapter1.UpdateReserva(null, null, null, null, txtSerial.Text);
                }
            }

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cargamos las sucursales del cliente
            cargarSucursal();
            cargarSucursalCliente();
        }

        private void btnBuscarNit_Click(object sender, EventArgs e)
        {
            spProcesos.Equipos.frmBuscaCliente fc = new spProcesos.Equipos.frmBuscaCliente();
            if (fc.ShowDialog() == DialogResult.OK)
            {
                cmbCliente.SelectedValue = fc.NitClente;
                cargarSucursal();
                cargarSucursalCliente();
            }
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            cmbCliente.SelectedValue = "";
            cmbSucursalCliente.SelectedValue = "";
            cargarSucursal();
        }

        private void cmbSucursalCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarSucursalCliente();
        }

        private void cmbModaldad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbEstadoEquipoLocal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cargarSucursal()
        {
            txtDireccion.Text = "";
            txtPais.Text = "";
            txtDepartamento.Text = "";
            txtCiudad.Text = "";

            if (cmbCliente.SelectedValue != null && cmbCliente.SelectedValue.ToString().Trim() != string.Empty)
            {
                sucursalClienteTableAdapter1.FillByNitCliente(dsSpx2.sucursalCliente, cmbCliente.SelectedValue.ToString());
            }
        }

        private void mostrarModalidad(bool valor)
        {
            if (valor)
            {
                lblSucursal.Text = "Sucursal";
            }
            else
            {
                lblSucursal.Text = "Bodega o Ubicacion";
            }
            lblEstadoEquipo.Location = lblModalidad.Location;
            cmbEstadoEquipoLocal.Location = cmbModaldad.Location;

            lblModalidad.Visible = valor;
            cmbModaldad.Visible = valor;
            lblEstadoEquipo.Visible = !valor;
            cmbEstadoEquipoLocal.Visible = !valor;
            txtCiudad.Visible = valor;
            txtDepartamento.Visible = valor;
            txtPais.Visible = valor;
            txtDireccion.Visible = valor;

            //
            lblCiudad.Visible = valor;
            lblDepartamento.Visible = valor;
            lblPais.Visible = valor;
            lblDireccion.Visible = valor;

        }

        private void cargarSucursalCliente()
        {
            if (cmbCliente.SelectedValue == null || cmbCliente.SelectedValue.ToString() == string.Empty)
            {
                mostrarModalidad(true);
                return;
            }

            //miramos si el cliente elegido es el taller local y ocultamos un combo y mostrmos el otro
            if (cmbCliente.SelectedValue.ToString().ToString().Trim() == "local")
            {
                mostrarModalidad(false);
            }
            else
            {
                mostrarModalidad(true);
            }


            if (cmbSucursalCliente.SelectedValue == null || cmbSucursalCliente.SelectedValue.ToString() == string.Empty)
                return;
            //if (cgDataControler1.verValor("codSucursalUbica") != null && (!cmbSucursalCliente.Enabled))
            //    cmbSucursalCliente.SelectedValue = cgDataControler1.verValor("codSucursalUbica");
            if (cmbSucursalCliente.SelectedValue == null) return;
            SPControladoraDatos.dsSpx.sucursalClienteDataTable tab =
            sucursalClienteTableAdapter1.GetDataByCodSucursalNit(cmbCliente.SelectedValue.ToString(), cmbSucursalCliente.SelectedValue.ToString());
            if (tab.Count > 0)
            {
                txtDireccion.Text = tab[0].IsDireccionNull() ? "" : tab[0].Direccion;
                if (!tab[0].IscodPaisNull())
                {
                    txtPais.Text = paisesTableAdapter1.verNombrePais(tab[0].codPais).ToString();

                    if (!tab[0].IscodDepartamentoNull())
                    {
                        txtDepartamento.Text = departamentoTableAdapter1.verNombreDepartamento(tab[0].codPais, tab[0].codDepartamento).ToString();

                        if (!tab[0].IscodCiudadNull())
                            txtCiudad.Text = ciudadesTableAdapter1.verNombreCiudad(tab[0].codPais, tab[0].codDepartamento, tab[0].codCiudad).ToString();
                    }
                }
            }
        }

        private void btnVerOs_Click(object sender, EventArgs e)
        {
            if (txtOrdenServicio.Text.Trim() != string.Empty)
            {
                spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo fr = new spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo();
                fr.CodOrdenServicio = txtOrdenServicio.Text;
                fr.Show();
            }
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

        private void tabControlPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarArchivo_Click(object sender, EventArgs e)
        {
            //se puede agregar en cualquier momento
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

                int codArchivo = archivosxEntradaSalidaEquiposTableAdapter1.verNextId().Value;
                archivosxEntradaSalidaEquiposTableAdapter1.Insert(codArchivo,int.Parse(codEntradaSalidaEquipos),nombre,mensaje, archivo);
                //cargamos los archivos
                archivosxEntradaSalidaEquiposTableAdapter1.FillBycodEntradaSalidaEquipos(dsSpx1.archivosxEntradaSalidaEquipos, int.Parse(codEntradaSalidaEquipos));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el archivo\n" + ex.Message);
            }
        }


        private void btnEliminarArchivo_Click(object sender, EventArgs e)
        {
            if (grdArchivos.Columns["codarchivosxEntradaSalidaEquipos"].Value == null ||
 grdArchivos.Columns["codarchivosxEntradaSalidaEquipos"].Value.ToString().Trim() == string.Empty)
            {
                return;
            }

            if (MessageBox.Show("Esta seguro de eliminar el archivo relacionado a la entrada", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) != DialogResult.Yes)
                return;


            archivosxEntradaSalidaEquiposTableAdapter1.DeleteQuery(int.Parse(grdArchivos.Columns["codarchivosxEntradaSalidaEquipos"].Value.ToString()));
            //cargamos la grilla
            archivosxEntradaSalidaEquiposTableAdapter1.FillBycodEntradaSalidaEquipos(dsSpx1.archivosxEntradaSalidaEquipos, int.Parse(codEntradaSalidaEquipos));

        }

        private void btnVerArchivo_Click(object sender, EventArgs e)
        {
            if (grdArchivos.Columns["codarchivosxEntradaSalidaEquipos"].Value == null ||
    grdArchivos.Columns["codarchivosxEntradaSalidaEquipos"].Value.ToString().Trim() == string.Empty)
            {
                return;
            }
            try
            {
                string path = System.IO.Path.GetTempPath();
                string nombreArchivo = path + @"\" + System.IO.Path.GetFileName(
                    grdArchivos.Columns["nombreArchivo"].Value.ToString()).Trim();

                System.IO.FileStream stream = new System.IO.FileStream(nombreArchivo, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                System.IO.BinaryWriter writer = new System.IO.BinaryWriter(stream);
                byte[] arr = (byte[])
                    archivosxEntradaSalidaEquiposTableAdapter1.verArchivo(int.Parse(grdArchivos.Columns["codarchivosxEntradaSalidaEquipos"].Value.ToString()));
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
            if (grdArchivos.Columns["codarchivosxEntradaSalidaEquipos"].Value == null ||
grdArchivos.Columns["codarchivosxEntradaSalidaEquipos"].Value.ToString().Trim() == string.Empty)
            {
                return;
            }
            saveFileDialog1.FileName = grdArchivos.Columns["nombreArchivo"].Value.ToString().Trim();
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                string nombreArchivo = saveFileDialog1.FileName;

                FileStream stream = new FileStream(nombreArchivo, FileMode.Create, FileAccess.Write);
                BinaryWriter writer = new BinaryWriter(stream);
                byte[] arr = (byte[])
                    archivosxEntradaSalidaEquiposTableAdapter1.verArchivo(int.Parse(grdArchivos.Columns["codarchivosxEntradaSalidaEquipos"].Value.ToString()));

                writer.Write(arr);
                writer.Close();
                MessageBox.Show("Archivo Guardado satisfactoriamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo \n" + ex.Message);
            }
        }

        private void btnImportarDesdeEntrada_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
            SPControladoraDatos.dsSpx dsSalidas = new SPControladoraDatos.dsSpx();
            accesoriosxEntradaSalidaEquiposTableAdapter1.FillByEntradasCodEntradaSalida(ds.AccesoriosxEntradaSalidaEquipos,
                int.Parse(txtCodigoEntradaSalida.Text));
            //
            accesoriosxEntradaSalidaEquiposTableAdapter1.FillBySalidasCodEntradaSalida(dsSalidas.AccesoriosxEntradaSalidaEquipos,
                int.Parse(txtCodigoEntradaSalida.Text));

            for (int k = 0; k < ds.AccesoriosxEntradaSalidaEquipos.Count; k++)
            {

                if (dsSalidas.AccesoriosxEntradaSalidaEquipos.Select("codAccesoriosEquipos='" + ds.AccesoriosxEntradaSalidaEquipos[k].codAccesoriosEquipos + "'").Length <= 0)
                {
                    accesoriosxEntradaSalidaEquiposTableAdapter1.Insert(int.Parse(txtCodigoEntradaSalida.Text),
                        ds.AccesoriosxEntradaSalidaEquipos[k].Codigo, false, ds.AccesoriosxEntradaSalidaEquipos[k].codAccesoriosEquipos,
                        ds.AccesoriosxEntradaSalidaEquipos[k].IsesOtroNull() ? false : ds.AccesoriosxEntradaSalidaEquipos[k].esOtro,
                        ds.AccesoriosxEntradaSalidaEquipos[k].IsdescripcionNull() ? "" : ds.AccesoriosxEntradaSalidaEquipos[k].descripcion,
                        ds.AccesoriosxEntradaSalidaEquipos[k].cantidad);
                }
            }
            accesoriosxEntradaSalidaEquiposTableAdapter1.FillBySalidasCodEntradaSalida(dsSpx2.AccesoriosxEntradaSalidaEquipos,
               int.Parse(txtCodigoEntradaSalida.Text));
            System.Media.SystemSounds.Beep.Play();
        }

        private void btnHojaDeVidaAuxiliar_Click(object sender, EventArgs e)
        {
            if (grdEquiposAuxliares.Columns["serial"].Text.Trim() == string.Empty) return;
            spProcesos.Equipos.frmInformacionEquipo frm = new spProcesos.Equipos.frmInformacionEquipo();
            frm.Serial = grdEquiposAuxliares.Columns["serial"].Text.Trim();
            frm.ShowDialog();
        }

        private void btnAgregarEquipoAuxiliar_Click(object sender, EventArgs e)
        {
            if (codEntradaSalidaEquipos.Trim() == string.Empty){
                MessageBox.Show("Debe guardar la entrada primero!");
                return;}
            spProcesos.Equipos.frmBuscarEquipo fr = new Equipos.frmBuscarEquipo();
            if (fr.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
            //validamos si el equipo esta vinculado a otro equipo
            equipoAuxiliarTableAdapter1.FillByserialAuxiliar(dsSpx1.equipoAuxiliar, fr.Serial);

            if (dsSpx1.equipoAuxiliar.Count > 0 && dsSpx1.equipoAuxiliar[0].serialEquipo.Trim() != txtSerial.Text.Trim())
            {
                if (MessageBox.Show("Este equipo esta vinculado con otro equipo con serial " + dsSpx1.equipoAuxiliar[0].serialEquipo.Trim() + " desea continuar de todos modos!", "Confirmacion", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
                return;
            }

            equiposAuxiliaresxEntradaTableAdapter1.Insert(int.Parse(codEntradaSalidaEquipos), fr.Serial);
            cargarAuxiliares();
        }

        private void cargarAuxiliares() 
        {
            if (codEntradaSalidaEquipos.Trim() == string.Empty) return;
            equiposAuxiliaresxEntradaTableAdapter1.FillByCodEntradaSalidaEquipos(dsSpx1.equiposAuxiliaresxEntrada,
                int.Parse(codEntradaSalidaEquipos));
            dsSpx1.vistaEquipo.Clear();
            for (int k = 0; k < dsSpx1.equiposAuxiliaresxEntrada.Count; k++)
            {
                dsSpx1.vistaEquipo.Merge(
                vistaEquipoTableAdapter1.GetDataBySerial(dsSpx1.equiposAuxiliaresxEntrada[k].serialAuxiliar)
                );
            }
        }

        private void btnQuitarEquipoAuxiliar_Click(object sender, EventArgs e)
        {
            if (grdEquiposAuxliares.Columns["Serial"].Text.Trim() == string.Empty)
            {
                return;
            }
            if (codEntradaSalidaEquipos.Trim() == string.Empty)
            {
                MessageBox.Show("Debe guardar la entrada primero!");
                return;
            }
          
                if (MessageBox.Show("Esta seguro de desvincular este equipo auxiliar con la entrada!", "Confirmacion", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
                    return;
            

            equiposAuxiliaresxEntradaTableAdapter1.DeleteByEntradaSerial(int.Parse(codEntradaSalidaEquipos), grdEquiposAuxliares.Columns["Serial"].Text.Trim());
            cargarAuxiliares();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (!SPXSeguridad.verificadorPermisos.ejecutarAccion(2013))
            {
                MessageBox.Show("Acceso denegado");
                return;
            }

            if (codEntradaSalidaEquipos.Trim() == string.Empty)
            {
                return;
            }
            //validmos el estado de la entrada salida
            if (dsSpx1.EntradaSalidaEquipos.Count <= 0) return;
            frmAnularEntradaSalida fr = new frmAnularEntradaSalida();
            fr.codEntradaSalidaEquipo = int.Parse(codEntradaSalidaEquipos);
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                botonesAnulacion();
            }
          
        }

        private void cmbTipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoServicio.SelectedValue == null || cmbTipoServicio.SelectedValue.ToString().Trim() == string.Empty)
                return;

            if (
                       !tipoServicioTableAdapter1.GetDataBycodTipoServicio(cmbTipoServicio.SelectedValue.ToString())[0].IsdevuelveEntradaNull()
                       &&
                       tipoServicioTableAdapter1.GetDataBycodTipoServicio(cmbTipoServicio.SelectedValue.ToString())[0].devuelveEntrada)
            {
                //ademas verificamos que no tenga creada ya orden de servicio
                if (txtOrdenServicio.Text.Trim() == string.Empty)
                {
                    //traemos el codigo de la ubicacion de destino
                    string codUbica = defaultsTableAdapter1.verCodUbicacionTrasladoEntradas().Trim();
                    cmbUbicacionReal.SelectedValue = codUbica;
                }
            }
        }

        private void btnImprimirEtiqueta_Click(object sender, EventArgs e)
        {
            string ruta = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter objDef = new SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter();
            objDef.Fill(dsSpx1.defaults);
            string strReporte = "rptStiker";
           

            C1.C1Report.C1Report reporte = new C1.C1Report.C1Report();
            reporte.Load(ruta + @"\rpt\rpt.xml", strReporte);
          
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            reporte.DataSource.ConnectionString = objData.CadenaConexionReportes;
            reporte.DataSource.RecordSource = reporte.DataSource.RecordSource.Replace("<<codEntrada>>", txtCodigoEntradaSalida.Text);
            reporte.Document.Print();
           // SPXQuery.frm.Reportes.frmReporte frmRpt = new SPXQuery.frm.Reportes.frmReporte(reporte);
            //frmRpt.Icon = this.Icon;

            //frmRpt.ShowDialog();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            string ruta = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter objDef = new SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter();
            objDef.Fill(dsSpx1.defaults);
            string strReporte = "rptStikerSalida";


            C1.C1Report.C1Report reporte = new C1.C1Report.C1Report();
            reporte.Load(ruta + @"\rpt\rpt.xml", strReporte);

            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            reporte.DataSource.ConnectionString = objData.CadenaConexionReportes;
            reporte.DataSource.RecordSource = reporte.DataSource.RecordSource.Replace("<<codEntrada>>", txtCodigoEntradaSalida.Text);
             reporte.Document.Print();
            //SPXQuery.frm.Reportes.frmReporte frmRpt = new SPXQuery.frm.Reportes.frmReporte(reporte);
            //frmRpt.Icon = this.Icon;

            //frmRpt.ShowDialog();

        }

    }
}