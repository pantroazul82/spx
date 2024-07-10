using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace spProcesos.Equipos
{
    public partial class frmInformacionEquipo : Form
    {
        public frmInformacionEquipo()
        {
            InitializeComponent();
            controladorColumnasRepuestosInstalados.grilla = grdRespuestosInstalados;
            controladorColumnasRecoleccion.grilla = grdRecolecciones;
            controladorColumnasRevision.grilla = grdRevision;

        }

        private string codModelo="";
        private string codFabricante = "";
        private string codSucursal = "";
        public string Serial { set { txtSerial.Text = value; } get { return txtSerial.Text; } }

        float duracionModelo = 0;
        private void cargarTiempomantenimiento()
        {

            if (duracionModelo != 0){
                txtDuracionMantenimiento.Text = ((int)duracionModelo) + " Horas ";
            if(    (duracionModelo - ((int)duracionModelo)) !=0)
                txtDuracionMantenimiento.Text += ((duracionModelo - ((int)duracionModelo)) * 60) + " Minutos"; 
            }      
        }
        
        
        private bool cargarserial(string serial)
        {
            //miramos si existe el serial
            equiposTableAdapter1.FillBySerial(dsSpx1.equipos, serial);
            vistaEquipoTableAdapter1.FillBySerial(dsSpx1.vistaEquipo, serial);
            if (dsSpx1.vistaEquipo.Rows.Count <= 0)
            {
                MessageBox.Show("El equipo con serial " + serial.Trim() + " no existe en la base de datos.");
                return false;
            }
            if (!dsSpx1.equipos[0].IsfechaProximoManteNull())calProximoMantenimiento.Value = dsSpx1.equipos[0].fechaProximoMante;
            if (!dsSpx1.equipos[0].IsfechaUltimoManteNull())calUltimoMantenimiento.Value = dsSpx1.equipos[0].fechaUltimoMante;
            if (!dsSpx1.equipos[0].IsobsequipoNull()) txtObsEquipo.Text = dsSpx1.equipos[0].obsequipo;
            if (!dsSpx1.equipos[0].IsCodadicionalNull()) txtCodigoAdicional.Text = dsSpx1.equipos[0].Codadicional;
            if (!dsSpx1.equipos[0].IscodTipoPropiedadNull()) 
            {
                tipoPropiedadTableAdapter1.FillBycodTipoPropiedad(dsSpx1.tipoPropiedad,dsSpx1.equipos[0].codTipoPropiedad);
                txtTipoPropiedad.Text = dsSpx1.tipoPropiedad[0].nombreTipoPropiedad;
            }
            else {txtTipoPropiedad.Text = "No Asignado";}


            if (!dsSpx1.equipos[0].Isultimo_responsableNull())
            {
                txtUltimoResponsable.Text = dsSpx1.equipos[0].ultimo_responsable.Trim();
            }

            txtFabricante.Text = dsSpx1.vistaEquipo[0].nombrefabricante;
            #region todo lo que tiene que ver con el modelo
            txtModelo.Text = dsSpx1.vistaEquipo[0].nombremodelo;
            codModelo = dsSpx1.equipos[0].codModelo.Trim();
            codFabricante = dsSpx1.equipos[0].codFabricante.Trim();
            modelosTableAdapter1.FillByFabricanteModeloComboBox(dsSpx1.Modelos,
                dsSpx1.equipos[0].codFabricante.Trim(),codModelo);
            //cargamos el tiempo de mantenimiento
            string tiempoMan = "";
            if (!dsSpx1.Modelos[0].IsmesesxMantenimientoNull() && dsSpx1.Modelos[0].mesesxMantenimiento >0)
            {
                tiempoMan = dsSpx1.Modelos[0].mesesxMantenimiento + " Meses ";
            }
            if (!dsSpx1.Modelos[0].IsdiasxMantenimientoNull() && dsSpx1.Modelos[0].diasxMantenimiento > 0)
            {
                tiempoMan += dsSpx1.Modelos[0].diasxMantenimiento + " Dias ";
            }
            txtFrecuenciaMantenimiento.Text = tiempoMan;

            if (!dsSpx1.Modelos[0].IsduracionmantenimientoNull())
            {
                duracionModelo = (float)dsSpx1.Modelos[0].duracionmantenimiento;
            }
            if (!dsSpx1.Modelos[0].IsamperiosNull()) txtAmperios.Text = dsSpx1.Modelos[0].amperios;
            if (!dsSpx1.Modelos[0].IswatiosNull()) txtWatios.Text = dsSpx1.Modelos[0].watios;
            if (!dsSpx1.Modelos[0].IsvoltajeNull()) txtVoltaje.Text = dsSpx1.Modelos[0].voltaje;
            if (!dsSpx1.Modelos[0].IsfrecuenciaNull()) txtFrecuencia.Text = dsSpx1.Modelos[0].frecuencia;
            if (!dsSpx1.Modelos[0].IspesoEstimadoNull()) txtPeso.Text = dsSpx1.Modelos[0].pesoEstimado.ToString();
            if (!dsSpx1.Modelos[0].IscodUnidadPesoNull()) txtPeso.Text = txtPeso.Text + " " + unidadPesoTableAdapter1.verUnidad(dsSpx1.Modelos[0].codUnidadPeso);


            cargarTiempomantenimiento();
            //
            txtTipoEquipo.Text = dsSpx1.vistaEquipo[0].nombretipoequipo;
            //
            txtSubtipo.Text = dsSpx1.vistaEquipo[0].nombresubtipo;
            if (!dsSpx1.equipos[0].IscodModalidadEquipoNull())
            {
                txtModalidad.Text = modalidadEquipoTableAdapter1.verNombreModadlidad(dsSpx1.equipos[0].codModalidadEquipo).ToString();
            }
            #endregion
            //Informacion del Cliente
            clientesTableAdapter1.FillByNitCliente(dsSpx1.clientes, dsSpx1.equipos[0].nitClienteUbica);
            if (dsSpx1.equipos[0].nitClienteUbica.Trim() == "local")
            { 
            //traemos el codigo del estado
                if (!dsSpx1.equipos[0].IscodEstadoLocalNull())
                {
                    SPControladoraDatos.dsSpxTableAdapters.estadoLocalEquiposTableAdapter objEstLocal = new SPControladoraDatos.dsSpxTableAdapters.estadoLocalEquiposTableAdapter();
                    
                    grpUbicacion.Visible = false;
                    lblEStadoLocal.Visible = true;
                    txtEstadoLocal.Visible = true;
                    txtEstadoLocal.Text = objEstLocal.verNombre(dsSpx1.equipos[0].codEstadoLocal);
                }
            }
            txtNitCliente.Text = dsSpx1.clientes[0].nitCliente;
            txtNombrecliente.Text = dsSpx1.clientes[0].nombreCliente;
            
            
            
           // txtTelefonoCliente.Text = (dsSpx1.clientes[0].Istelefono1Null()) ? "" : dsSpx1.clientes[0].telefono1;
            
            //informacion de la ubicacion
            sucursalClienteTableAdapter1.FillByCodSucursalNit(dsSpx1.sucursalCliente, dsSpx1.clientes[0].nitCliente, dsSpx1.equipos[0].codSucursalUbica);
            if (!dsSpx1.sucursalCliente[0].IscodPaisNull() && !dsSpx1.sucursalCliente[0].IscodDepartamentoNull()
                && !dsSpx1.sucursalCliente[0].IscodCiudadNull())
            {
                txtUbicacion.Text = "(" + paisesTableAdapter1.verNombrePais(dsSpx1.sucursalCliente[0].codPais).ToString().Trim();
                txtUbicacion.Text += ") " + departamentoTableAdapter1.verNombreDepartamento(dsSpx1.sucursalCliente[0].codPais, dsSpx1.sucursalCliente[0].codDepartamento).ToString().Trim();
                txtUbicacion.Text += ", " + ciudadesTableAdapter1.verNombreCiudad(dsSpx1.sucursalCliente[0].codPais, dsSpx1.sucursalCliente[0].codDepartamento, dsSpx1.sucursalCliente[0].codCiudad).ToString().Trim();
            }
            txtSucursal.Text =  dsSpx1.sucursalCliente[0].nombreSucursal;
            codSucursal = dsSpx1.sucursalCliente[0].codSucursal;
            txtTelefonoSucursal.Text = (dsSpx1.sucursalCliente[0].IsTelefono1Null()) ? "" : dsSpx1.sucursalCliente[0].Telefono1;
            if (!dsSpx1.sucursalCliente[0].IsTelefono2Null() && dsSpx1.sucursalCliente[0].Telefono2.Trim() != string.Empty)
                txtTelefonoSucursal.Text = txtTelefonoSucursal.Text+" - "+ dsSpx1.sucursalCliente[0].Telefono2;

            txtDireccionSucursal.Text = (dsSpx1.sucursalCliente[0].IsDireccionNull()) ? "" : dsSpx1.sucursalCliente[0].Direccion;

            #region informacion del contacto general
            txtContactoGeneral.Text = (dsSpx1.clientes[0].IsnombreContactoPrincipalNull()) ? "" : dsSpx1.clientes[0].nombreContactoPrincipal;
            txtEmailGeneral.Text = (dsSpx1.clientes[0].IsemailNull()) ? "" : dsSpx1.clientes[0].email;
            txtCelularGeneral.Text = (dsSpx1.clientes[0].IscelularNull()) ? "" : dsSpx1.clientes[0].celular;
            #endregion
            if (!dsSpx1.sucursalCliente[0].IscodContactoNull())
            {
                contactosClientesTableAdapter1.FillBycodContactoNit(dsSpx1.contactosClientes, txtNitCliente.Text,
                    dsSpx1.sucursalCliente[0].codContacto);
                if (dsSpx1.contactosClientes.Count > 0)
                {
                    txtContactoPrincipal.Text = dsSpx1.contactosClientes[0].nombreContacto.Trim() +" "+ dsSpx1.contactosClientes[0].apellidosContacto.Trim();
                    txtEmailContacto.Text = (dsSpx1.contactosClientes[0].IsemailNull()) ? "" : dsSpx1.contactosClientes[0].email.Trim();
                    txtCelularContacto.Text = (dsSpx1.contactosClientes[0].IscelularNull()) ? "" : dsSpx1.contactosClientes[0].celular.Trim();
                    txtTelefonoContacto.Text = dsSpx1.contactosClientes[0].telefono1.Trim();
                    if (!dsSpx1.contactosClientes[0].Istelefono2Null() && dsSpx1.contactosClientes[0].telefono2.Trim() != string.Empty)
                    txtTelefonoContacto.Text = txtTelefonoContacto.Text+"-"+ dsSpx1.contactosClientes[0].telefono2.Trim();
                }
            }

            
            
            if (!dsSpx1.equipos[0].IsfechaLlegadaNull()) { calfechaLLegada.Value = dsSpx1.equipos[0].fechaLlegada; }
            if (!dsSpx1.equipos[0].IsfechaSalidaNull()) { calFechaSalida.Value = dsSpx1.equipos[0].fechaSalida; }
            cargarObservaciones(serial);

            if (!dsSpx1.equipos[0].IsnitClienteUbicacionRealNull())
            {
                clientesTableAdapter1.FillByNitCliente(dsSpx1.clientes, dsSpx1.equipos[0].nitClienteUbicacionReal);
                if (dsSpx1.clientes.Count > 0)
                {
                    SPControladoraDatos.dsSpxTableAdapters.vistaSucursalTableAdapter objSucursal=new SPControladoraDatos.dsSpxTableAdapters.vistaSucursalTableAdapter();
                    txtClienteReal.Text = dsSpx1.clientes[0].nombreCliente.Trim()+" ("+ dsSpx1.clientes[0].nitCliente.Trim() +")";
                    objSucursal.FillByNitClienteCodSucursal(dsSpx1.vistaSucursal, dsSpx1.equipos[0].nitClienteUbicacionReal, dsSpx1.equipos[0].codSucursalUbicaReal);

                    string depReal = "";
                    if (!dsSpx1.vistaSucursal[0].IsNombreDepartamentoNull())
                    depReal=dsSpx1.vistaSucursal[0].NombreDepartamento;
                    string ciuReal = "";
                    if (!dsSpx1.vistaSucursal[0].IsnombreCiudadNull())
                        ciuReal=dsSpx1.vistaSucursal[0].nombreCiudad.Trim();

                    txtSucursalReal.Text = dsSpx1.vistaSucursal[0].nombreSucursal+" ("+
                        depReal + " " + ciuReal
                        +")";
                }
            }
            
            return true;
        }

        private void cargarObservaciones(string serial) 
        {
            //vemos las dos ulitmas ordenes de servicio
            ordenServicioTableAdapter1.FillByDosUltimasAprobadas(dsSpx1.ordenServicio,serial);
            if (dsSpx1.ordenServicio.Rows.Count > 0)
            {
                txtObservacionAnterior.Text = dsSpx1.ordenServicio[0].observacionesIngeniero;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmInformacionEquipo_Load(object sender, EventArgs e)
        {
            dsPlantillas1.EnforceConstraints = false;
            //VERFICAMOS EL PERMISO
            if (!SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1115))
            {
                MessageBox.Show("No tiene permisos para ver la Hoja de vida del equipo");
                Close();
                return;
            }
            btnVerEquipo.Visible = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1116);
            
            //inicializamos los calendarios
            calInicioRepuestos.Value = DateTime.Now.AddYears(-1);
            calFinRepuestos.Value = DateTime.Now.AddDays(1);
            calInicioRecoleccion.Value = DateTime.Now.AddDays(30);
            calFinRecoleccion.Value = DateTime.Now.AddDays(1);
            calInicioRevision.Value = DateTime.Now.AddDays(-60);
            calFinRevision.Value = DateTime.Now.AddDays(1);

            calFinRecoleccion.MonthCalendar.DisplayMonth = DateTime.Now;
            calfechaLLegada.MonthCalendar.DisplayMonth = DateTime.Now;
            calFechaSalida.MonthCalendar.DisplayMonth = DateTime.Now;
            calFinContrato.MonthCalendar.DisplayMonth = DateTime.Now;
            calFinRecoleccion.MonthCalendar.DisplayMonth = DateTime.Now;
            calFinRepuestos.MonthCalendar.DisplayMonth = DateTime.Now;
            calInicioContrato.MonthCalendar.DisplayMonth = DateTime.Now;
            calInicioRecoleccion.MonthCalendar.DisplayMonth = DateTime.Now;
            calInicioRepuestos.MonthCalendar.DisplayMonth = DateTime.Now;
            calProximoMantenimiento.MonthCalendar.DisplayMonth = DateTime.Now;

            calInicioRevision.MonthCalendar.DisplayMonth = DateTime.Now;
            calFinRevision.MonthCalendar.DisplayMonth = DateTime.Now;
            calUltimoMantenimiento.MonthCalendar.DisplayMonth = DateTime.Now;

            

            cargarserial(txtSerial.Text);
        }

        private void btnVerEquipo_Click(object sender, EventArgs e)
        {
            frmEquipos frm = new frmEquipos();
            frm.SerialEquipo = txtSerial.Text;
            frm.Show();
        }

        private void tabControl1_SelectedTabChanging(object sender, DevComponents.DotNetBar.TabStripTabChangingEventArgs e)
        {
            //
            //MessageBox.Show(e.NewTab.Text);
            if (e.NewTab.Text.Trim() == "Auxiliares y Traslados")
            {
                #region cargamos el layout del los equipos auxiliares
                string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                // 
                str += @"\infEquiLayt.xs";
                if(System.IO.File.Exists(str))
                grdAuxilares.LoadLayout(str);
#endregion
                #region cargamos el layout del los traslados
                str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                // 
                str += @"\infEquiTrasLayt.xs";
                if (System.IO.File.Exists(str))
                    grdTraslados.LoadLayout(str);
                #endregion

                equipoAuxiliarTableAdapter1.FillByserialAuxiliar(dsSpx1.equipoAuxiliar, txtSerial.Text);
                if (dsSpx1.equipoAuxiliar.Rows.Count > 0)
                {
                    txtEquipoAuxiliarDe.Text = dsSpx1.equipoAuxiliar[0].serialEquipo;
                }else {
                    txtEquipoAuxiliarDe.Text = "Ninguno";
                }
                vistaEquipoTableAdapter1.FillAuxiliares(dsSpxAuxiliares.vistaEquipo, txtSerial.Text);
                dsSpx1.EnforceConstraints = false;
                pltLogTrasladosTableAdapter1.FillBySerial(dsSpx1.pltLogTraslados,txtSerial.Text);
            }
            else if (e.NewTab.Text.Trim() == "Historial de Mantenimiento")
            {
                #region cargamos el layout del los equipos auxiliares
                string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                
                str += @"\infEquiLaytOS.xs";
                if (System.IO.File.Exists(str))
                    grdOrdenServicio.LoadLayout(str);
                #endregion
                pltinfEquipoOSTableAdapter1.FillBySerial(dsPlantillas1.pltinfEquipoOS,txtSerial.Text);
                txtOrdenesServicios.Text = dsPlantillas1.pltinfEquipoOS.Rows.Count.ToString();
            }
            else if (e.NewTab.Text.Trim() == @"Entradas/Salidas")
            {
                #region cargamos el layout del los equipos auxiliares
                string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

                str += @"\infEquiLaytlistaES.xs";
                if (System.IO.File.Exists(str))
                    grdListadoES.LoadLayout(str);
                #endregion
                pltListadoESequiposTableAdapter1.FillBySerial(dsPlantillas1.pltListadoESequipos, txtSerial.Text);
                txtNumeroEntradas.Text = dsPlantillas1.pltListadoESequipos.Rows.Count.ToString();
            }
            else if (e.NewTab.Text.Trim() == @"Archivos")
            {
                pltArchivosXequipoTableAdapter1.FillBySerial(dsPlantillas1.pltArchivosXequipo, txtSerial.Text);
                
            }
            else if (e.NewTab.Text.Trim() == @"Contrato")
            {
                #region zona de contratos
                contratosTableAdapter1.FillByContratoActivoEquipo(dsSpx1.contratos, txtSerial.Text, DateTime.Now);
                if (dsSpx1.contratos.Rows.Count > 0)
                {
                    tipoContratoTableAdapter1.Fill(dsSpx1.tipoContrato);
                    cmbTipoContrato.SelectedValue= dsSpx1.contratos[0].codTipoContrato;
                    modalidadContratoTableAdapter1.FillBycodTipoContrato(dsSpx1.modalidadContrato,dsSpx1.contratos[0].codTipoContrato);
                    if(!dsSpx1.contratos[0].IscodModalidadContratoNull())cmbModalidadContrato.SelectedValue= dsSpx1.contratos[0].codModalidadContrato;


                    calInicioContrato.Value = dsSpx1.contratos[0].fechaInicioContrato;
                    calFinContrato.Value = dsSpx1.contratos[0].fechaFinContrato;
                    
                    txtNroContrato.Text = dsSpx1.contratos[0].numeroContrato;
                    txtObervacionesContrato.Text = dsSpx1.contratos[0].Observaciones;

                    nmDiasHabiles.Value=(decimal)dsSpx1.contratos[0].timeRptaDiasHabiles;
                    nmHorasHabiles.Value=(decimal)dsSpx1.contratos[0].timeRptaHorasHabiles;
                    nmMantenimientosIncluidos.Value=(decimal)dsSpx1.contratos[0].NumeroMantenimientos;
                    nmMesesEntreMantenimientos.Value=(decimal)dsSpx1.contratos[0].mesesxMantenimiento;
                    nmPorcentajePrecioTiquetes.Value=(decimal)dsSpx1.contratos[0].porcentajeTiquetes;


                    chkIncluyeRepuestos.Checked=dsSpx1.contratos[0].incluyeRepuestos;
                    chkIncluyeTiquetes.Checked=dsSpx1.contratos[0].incluyeTiquetes;

                    if(dsSpx1.contratos[0].incluyeRepuestos)
                    {
                    repuestosxContratosTableAdapter1.FillByNroContrato(dsSpx1.repuestosxContratos,txtNroContrato.Text);
                    }
                    mantenimientosxContratoTableAdapter1.FillByManteniientosContratoActual(dsSpx1.mantenimientosxContrato,
                        txtSerial.Text, txtNroContrato.Text
                        ,dsSpx1.contratos[0].codOtroSi);
                    //
                    contratosxEquipoTableAdapter1.FillBySerialNumContratoOtroSi(dsSpx1.contratosxEquipo, txtSerial.Text,
                        dsSpx1.contratos[0].numeroContrato, dsSpx1.contratos[0].codOtroSi);
                    nmMantenimientosIncluidos.Value  = dsSpx1.contratosxEquipo[0].mantenimientosxContrato;
                    nmMantenimientosRealizados.Value = dsSpx1.contratosxEquipo[0].mantenimientosRealizados;
                }
                else {
                    txtNroContrato.Text = "Sin Contrato de Mantenimiento Activo";
                }
                #endregion
            }
            else if (e.NewTab.Text.Trim() == @"Llamadas")
            {
                pltListadoLlamadasTableAdapter1.FillBySerial(dsPlantillas1.pltListadoLlamadas, txtSerial.Text);
                txtRegistroLlamadas.Text = dsPlantillas1.pltListadoLlamadas.Count.ToString();
            }
            else if (e.NewTab.Text.Trim() == @"Repuestos Instalados")
            {
                cargarRepuestos();
            }
            else if (e.NewTab.Text.Trim() == @"Recolecciones")
            {
                cargarRecolecciones();
            }
            else if (e.NewTab.Text.Trim() == "Revision Equipos")
            {
                SPControladoraDatos.dsCientificaTableAdapters.pltRevisionEquiposTableAdapter pltRevision = new SPControladoraDatos.dsCientificaTableAdapters.pltRevisionEquiposTableAdapter();
                pltRevision.FillBySerialFechas(dsCientifica1.pltRevisionEquipos, calInicioRevision.Value, calFinRevision.Value, txtSerial.Text);
            }
        }

        private void btnInfEquipoPrincipal_Click(object sender, EventArgs e)
        {
            if(txtEquipoAuxiliarDe.Text != "Ninguno")
            {
            spProcesos.Equipos.frmInformacionEquipo frm = new spProcesos.Equipos.frmInformacionEquipo();
            frm.Serial = txtEquipoAuxiliarDe.Text;
            frm.ShowDialog();
            }
        }

        private void btnInfEquipoAuxiliar_Click(object sender, EventArgs e)
        {
            if (grdAuxilares.Columns["serial"].Text.Trim() == string.Empty) return;
            spProcesos.Equipos.frmInformacionEquipo frm = new spProcesos.Equipos.frmInformacionEquipo();
            frm.Serial = grdAuxilares.Columns["serial"].Text.Trim();
            frm.ShowDialog();
            
        }

        private void btnInfSucursal_Click(object sender, EventArgs e)
        {
            if (grdTraslados.Columns["sucursalDestino"].Text.Trim() == string.Empty) return;
            SpFrm.generales.frmSucursales frmC = new SpFrm.generales.frmSucursales();
            frmC.NitCliente = grdTraslados.Columns["nitDestino"].Text.Trim();
            frmC.CodigoSucursal = sucursalClienteTableAdapter1.verCodigoSucursal( 
                grdTraslados.Columns["nitDestino"].Text.Trim(),grdTraslados.Columns["sucursalDestino"].Text.Trim());
            frmC.Consultando = true;
            frmC.ShowDialog();
        }

    
        private void btnExpExcelAux_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel objX = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            objX.exportar(grdAuxilares, "Auxiliares "+txtSerial.Text, false);
        }

        private void btnExportarTraslExcel_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel objX = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            objX.exportar(grdTraslados, "Traslados "+txtSerial.Text, false);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {//Guarda la configuracion de la grilla de equipos auxiliares
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\infEquiLayt.xs";
            grdAuxilares.SaveLayout(str);
        }

        private void btnGuardarGrilla_Click(object sender, EventArgs e)
        {
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\infEquiTrasLayt.xs";
            grdTraslados.SaveLayout(str);
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\infEquiLayt.xs";
            System.IO.File.Delete(str);
            MessageBox.Show("Los cambios se veran reflejados cuando carge de nuevo la ventana");
        }

        private void btnReinicciargrilla_Click(object sender, EventArgs e)
        {
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\infEquiTrasLayt.xs";
            System.IO.File.Delete(str);
            MessageBox.Show("Los cambios se veran reflejados cuando carge de nuevo la ventana");
        }

        #region orden servicio
        private void btnVerOrdenServicio_Click(object sender, EventArgs e)
        {
            if (grdOrdenServicio.Columns["codOrdenServicio"].Text.Trim() == string.Empty) return;
            //cargamos el formulario de equipos
            spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo frmO = new spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo();
            frmO.CodOrdenServicio = grdOrdenServicio.Columns["codOrdenServicio"].Text.Trim();
            frmO.ShowDialog();
        }

        private void btnExcelOS_Click(object sender, EventArgs e)
        {

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel objX = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            objX.exportar(grdOrdenServicio, "Ordenes de servicio " + txtSerial.Text, false);
        }

        private void btnGuardarColOS_Click(object sender, EventArgs e)
        {
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\infEquiLaytOS.xs";
            grdOrdenServicio.SaveLayout(str);
        }

        private void btnRestaurarColOs_Click(object sender, EventArgs e)
        {
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\infEquiLaytOS.xs";
            System.IO.File.Delete(str);
            MessageBox.Show("Los cambios se veran reflejados cuando carge de nuevo la ventana");
        }
#endregion
        #region entrada salida de equipos
        private void btnExportarExcelES_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel objX = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            objX.exportar(grdListadoES, @"Entradas/Salidas  " + txtSerial.Text, false);
        }

        private void btnGuardarColEs_Click(object sender, EventArgs e)
        {
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\infEquiLaytlistaES.xs";
            grdListadoES.SaveLayout(str);
        }

        private void btnRestaurarColES_Click(object sender, EventArgs e)
        {
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\infEquiLaytlistaES.xs";
            System.IO.File.Delete(str);
            MessageBox.Show("Los cambios se veran reflejados cuando carge de nuevo la ventana");
        }

        private void btnVerOrdenEntrada_Click(object sender, EventArgs e)
        {
            if (grdListadoES.Columns["codEntradaSalidaEquipos"].Text.Trim() == string.Empty) return;
            if (grdListadoES.Columns["codOrdenServicio"].Text.Trim() == string.Empty) return;
            //cargamos el formulario de equipos
            spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo frmO = new spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo();
            frmO.CodOrdenServicio = grdListadoES.Columns["codOrdenServicio"].Text.Trim();
            frmO.ShowDialog();
        }

        private void btnVerESs_Click(object sender, EventArgs e)
        {
            if (grdListadoES.Columns["codEntradaSalidaEquipos"].Text.Trim() == string.Empty) return;
            //cargamos el formulario de equipos
            spProcesos.ESequipos.frmEntradaSalidaEquipos frmO = new spProcesos.ESequipos.frmEntradaSalidaEquipos();
            frmO.CodEntradaSalidaEquipos = grdListadoES.Columns["codEntradaSalidaEquipos"].Text.Trim();
            frmO.ShowDialog();
        }
#endregion

        private void btnGuardarArchivo_Click(object sender, EventArgs e)
        {
            if (grdArchivos.Columns["codArchivo"].Text.Trim() == string.Empty) return;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.RestoreDirectory = true;
            

            saveFileDialog1.FileName = grdArchivos.Columns["nombreArchivo"].Value.ToString();
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                string nombreArchivo = saveFileDialog1.FileName;

                FileStream stream = new FileStream(nombreArchivo, FileMode.Create, FileAccess.Write);
                BinaryWriter writer = new BinaryWriter(stream);
                byte[] arr = (byte[])archivosXequipoTableAdapter1.verArchivo(txtSerial.Text, int.Parse(grdArchivos.Columns["codArchivo"].Value.ToString()));

                writer.Write(arr);
                writer.Close();
                MessageBox.Show("Archivo Guardado satisfactoriamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo \n" + ex.Message);
            }

        }

        private void btnVerArchivo_Click(object sender, EventArgs e)
        {
            if (grdArchivos.Columns["codArchivo"].Text.Trim() == string.Empty) return;
           
            try
            {
                string path = System.IO.Path.GetTempPath();
                string nombreArchivo = path + @"\" + System.IO.Path.GetFileName(
                    grdArchivos.Columns["nombreArchivo"].Value.ToString());

                FileStream stream = new FileStream(nombreArchivo, FileMode.Create, FileAccess.Write);
                BinaryWriter writer = new BinaryWriter(stream);
                byte[] arr = (byte[])
                    archivosXequipoTableAdapter1.verArchivo(txtSerial.Text, int.Parse(grdArchivos.Columns["codArchivo"].Value.ToString()));
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
        #region contratos
        private void btnVerOrdenServicioContrato_Click(object sender, EventArgs e)
        {
            if (grdMantenimientosxContrato.Columns["codOrdenServicio"].Text.Trim() == string.Empty) return;
            //cargamos el formulario de equipos
            spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo frmO = new spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo();
            frmO.CodOrdenServicio = grdMantenimientosxContrato.Columns["codOrdenServicio"].Text.Trim();
            frmO.ShowDialog();
        }
        #endregion

        private void btnExportarExcelOSContraros_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel objX = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            objX.exportar(grdMantenimientosxContrato, "Ordenes de servicio " +txtNroContrato.Text+"-"+ txtSerial.Text, false);
        }

        private void btnExportarLlamdasExcel_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel objX = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            objX.exportar(GrdLlamadas, "Llamadas " + txtSerial.Text, false);
        }

        private void btnGuardarLayoutLlamadas_Click(object sender, EventArgs e)
        {
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\infEquiLaytLLamadas.xs";
            grdOrdenServicio.SaveLayout(str);
        }

        private void btnRestaurarLlamadas_Click(object sender, EventArgs e)
        {
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\infEquiLaytLLamadas.xs";
            System.IO.File.Delete(str);
            MessageBox.Show("Los cambios se veran reflejados cuando carge de nuevo la ventana");
        }

        private void btnVerllamada_Click(object sender, EventArgs e)
        {
            if (GrdLlamadas.Columns["idLlamadaSoporte"].Text.Trim() == string.Empty) return;
            //cargamos el formulario de equipos
            spProcesos.llamadasTecnicas.frmLlamadasSoporte frmLL = new spProcesos.llamadasTecnicas.frmLlamadasSoporte();
            frmLL.CodLLamada = int.Parse(GrdLlamadas.Columns["idLlamadaSoporte"].Text);
            frmLL.ShowDialog();
        }

        private void btnBaseFallas_Click(object sender, EventArgs e)
        {
            spProcesos.problemas_frecuentes.frmParametrizacionProblemas fr = new spProcesos.problemas_frecuentes.frmParametrizacionProblemas();
            fr.codFabricante = codFabricante;
            fr.codModelo = codModelo;
            
            fr.Show();
        }

        private void btnInfCliente_Click(object sender, EventArgs e)
        {
            if (txtNitCliente.Text.Trim() == string.Empty) return;
            SpFrm.terceros.frmInfCliente fr = new SpFrm.terceros.frmInfCliente();
            fr.nitCliente = txtNitCliente.Text;
            fr.Show();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            if (txtNitCliente.Text.Trim() == string.Empty) return;
            SpFrm.terceros.frmInfSucursal fr = new SpFrm.terceros.frmInfSucursal();
            fr.NitCliente = txtNitCliente.Text;
            fr.CodSucursal = codSucursal;
            fr.Show();
        }

        private void btnCArgarRespuestos_Click(object sender, EventArgs e)
        {
            cargarRepuestos();
        }

        private void cargarRepuestos(){
            if (calFinRepuestos.ValueObject == null || calInicioRepuestos.ValueObject == null)
            {
                MessageBox.Show("Seleccione Fechas validas");
                dsPlantillas1.pltRepuestosInstalados.Clear();
                return;
            }
            pltRepuestosInstaladosTableAdapter1.FillByEquipoFecha(dsPlantillas1.pltRepuestosInstalados,
                txtSerial.Text, calInicioRepuestos.Value, calFinRepuestos.Value);
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            if (grdRespuestosInstalados.Columns["codOrdenServicio"].Text.Trim() == string.Empty)
                return;

            spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo fr = new spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo();
            fr.CodOrdenServicio = grdRespuestosInstalados.Columns["codOrdenServicio"].Text;
            fr.Show();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnVerRecoleccion_Click(object sender, EventArgs e)
        {
            if (grdRecolecciones.Columns["codRecoleccion"].Text.Trim() == string.Empty) return;
            recolecciones.frmNuevaRecoleccion fr = new recolecciones.frmNuevaRecoleccion();
            fr.CodRecoleccion = int.Parse(grdRecolecciones.Columns["codRecoleccion"].Text);
            fr.Show();
        }
        private string generarSqlRecoleccion()
        {
            System.Text.StringBuilder sb = new StringBuilder();
            sb.Append(" set dateformat dmy select nombreModalidadEquipo,");
            sb.Append(" codRecoleccion, fechaSolicitud,  ");
            sb.Append(" us1.nombre 'solicitadoPor', nombreEstadoRecoleccion, ");
            sb.Append(" observacionesSolicitud, motivoRecoleccion, fechaTentativaLlegada,  ");
            sb.Append(" us2.nombre 'responsableRecoleccion', ");
            sb.Append(" nombreTransportadora, codRecoleccionTransportadora, nroGuia, obsIniciales, confirmada,  ");
            sb.Append(" us3.nombre 'confirmadaPor', fechaConfirmacion, obsConfirmacion, fechaRecoleccion, codEntradaSalidaEquipos, ");

            sb.Append(" clientes.nitCliente,clientes.nombreCliente, ");
            sb.Append(" paises.nombrePais,departamento.NombreDepartamento,ciudades.nombreCiudad, ");
            sb.Append(" tipoEquipo.nombreTipoEquipo, subTipoEquipo.nombreSubTipo,Modelos.NombreModelo,fabricante.nombre_fabricante, ");
            sb.Append(" equipos.serial ");
            sb.Append(" ,sucursalCliente.nombreSucursal ");
            sb.Append(" from recoleccion  ");
            sb.Append(" join estadoRecoleccion on estadoRecoleccion.codEstadoRecoleccion = recoleccion.codEstadoRecoleccion ");
            sb.Append(" left join transportadora on transportadora.codTransportadora = recoleccion.codTransportadora ");
            sb.Append(" join clientes on clientes.nitCliente = recoleccion.nitCliente ");
            sb.Append(" join sucursalCliente on sucursalCliente.nitCliente = recoleccion.nitCliente and sucursalCliente.codSucursal = recoleccion.codSucursal  ");
            sb.Append(" left join paises on paises.codPais = sucursalCliente.codPais ");
            sb.Append(" left join departamentos departamento on departamento.codPais = sucursalCliente.codPais and departamento.codDepartamento = sucursalCliente.codDepartamento ");
            sb.Append(" left join ciudades on ciudades.codPais = sucursalCliente.codPais and ciudades.codDepartamento = sucursalCliente.codDepartamento and ciudades.codCiudad = sucursalCliente.codCiudad ");


            sb.Append(" join equipos on equipos.serial = recoleccion.serial ");
            sb.Append(" join ModalidadEquipo on equipos.codModalidadEquipo = ModalidadEquipo.codModalidadEquipo ");
            sb.Append(" join fabricante on fabricante.codFabricante = equipos.codFabricante ");
            sb.Append(" join Modelos on Modelos.codFabricante = fabricante.codFabricante and Modelos.codModelo = equipos.codModelo ");
            sb.Append(" join tipoEquipo on tipoEquipo.codTipoEquipo = Modelos.codTipoEquipo ");
            sb.Append(" join subTipoEquipo on subTipoEquipo.codTipoEquipo = Modelos.codTipoEquipo and subTipoEquipo.codSubtipoEquipo = Modelos.codSubTipoEquipo ");
            sb.Append(" left join usuario us1 on us1.login = recoleccion.solicitadoPor ");
            sb.Append(" left join usuario us2 on us2.login = recoleccion.responsableRecoleccion ");
            sb.Append(" left join usuario us3 on us3.login = recoleccion.confirmadaPor ");
            sb.Append(" WHERE equipos.serial='"+txtSerial.Text+"' ");
            string sql = " and recoleccion.fechaTentativaLlegada between  '" +
               calInicioRecoleccion.Value.Day + "-" + calInicioRecoleccion.Value.Month + "-" + calInicioRecoleccion.Value.Year + "' and '" +
               calFinRecoleccion.Value.Day + "-" + calFinRecoleccion.Value.Month + "-" + calFinRecoleccion.Value.Year + "' ";
            sb.Append(sql);
            return sb.ToString();
        }

        private void cargarRecolecciones()
        {
            string sql = generarSqlRecoleccion();
            //generamos el filtro
          
            dsPlantillas1.pltListadoRecoleccion.Clear();
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            dsPlantillas1.pltListadoRecoleccion.Merge(objData.ejecutarConsulta(sql).Tables[0]);
        }

        private void btnBuscarRecoleccion_Click(object sender, EventArgs e)
        {
            cargarRecolecciones();
        }

        private void tabControlPanel1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscarRevision_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.dsCientificaTableAdapters.pltRevisionEquiposTableAdapter pltRevision = new SPControladoraDatos.dsCientificaTableAdapters.pltRevisionEquiposTableAdapter();
            pltRevision.FillBySerialFechas(dsCientifica1.pltRevisionEquipos, calInicioRevision.Value, calFinRevision.Value, txtSerial.Text);
        }

        
    }
}
