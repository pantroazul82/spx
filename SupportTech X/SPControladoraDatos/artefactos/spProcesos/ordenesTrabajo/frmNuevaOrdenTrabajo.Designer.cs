namespace spProcesos.ordenesTrabajo
{
    partial class frmNuevaOrdenTrabajo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevaOrdenTrabajo));
            C1.Win.C1TrueDBGrid.Style style1 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style2 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style3 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style4 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style5 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style6 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style7 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style8 = new C1.Win.C1TrueDBGrid.Style();
            this.grpIngeniero = new System.Windows.Forms.GroupBox();
            this.btnLimpiarIngeniero = new System.Windows.Forms.Button();
            this.lblIngeniero = new System.Windows.Forms.Label();
            this.dsSPXSeguridad1 = new SPXSeguridad.data.dsSPXSeguridad();
            this.cmbIngeniero = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.label27 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumeroEntrada = new System.Windows.Forms.TextBox();
            this.txtNumeroOrdenServicio = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdOrdenExterna = new System.Windows.Forms.RadioButton();
            this.rdInterna = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnInfCliente = new DevComponents.DotNetBar.ButtonX();
            this.txtNombrecliente = new System.Windows.Forms.TextBox();
            this.txtNitCliente = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnInfSucursal = new DevComponents.DotNetBar.ButtonX();
            this.txtSucursal = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.calUltimoMantenimiento = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.calProximoMantenimiento = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInfEquipo = new DevComponents.DotNetBar.ButtonX();
            this.txtModalidad = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.btnBuscarSerial = new DevComponents.DotNetBar.ButtonX();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.grpFecha = new System.Windows.Forms.GroupBox();
            this.btnConsultarDisponib = new DevComponents.DotNetBar.ButtonX();
            this.calInicioProg = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.calFecha();
            this.calFinProg = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.calFecha();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpPorContrato = new System.Windows.Forms.GroupBox();
            this.txtNumeroContrato = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rdContratoNo = new System.Windows.Forms.RadioButton();
            this.rdContratoSi = new System.Windows.Forms.RadioButton();
            this.btnVerES = new DevComponents.DotNetBar.ButtonX();
            this.btnLimpiaAsesor = new System.Windows.Forms.Button();
            this.cmbAsesorComercial = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbTipoServicio = new System.Windows.Forms.ComboBox();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.txtObservacionesIniciales = new System.Windows.Forms.TextBox();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel6 = new DevComponents.DotNetBar.TabControlPanel();
            this.grdExpotarReportesInsumos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsPlantillas1 = new SPControladoraDatos.dsPlantillas();
            this.btnGenerarExcel = new System.Windows.Forms.Button();
            this.btnImprimirSolicitud = new System.Windows.Forms.Button();
            this.btnActualizarSolicitudes = new System.Windows.Forms.Button();
            this.btnEliminarSolicitud = new System.Windows.Forms.Button();
            this.btnModifcarSolicitud = new System.Windows.Forms.Button();
            this.btnAgregarInsumos = new System.Windows.Forms.Button();
            this.grdSolicitudesInsumos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.tabItem6 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel8 = new DevComponents.DotNetBar.TabControlPanel();
            this.btnAgregarDispositivoMedicionExterno = new DevComponents.DotNetBar.ButtonX();
            this.btnVerRangos = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregarVariableMedicion = new DevComponents.DotNetBar.ButtonX();
            this.btnEditarVariableMedicion = new DevComponents.DotNetBar.ButtonX();
            this.btnEliminarVariableMedicion = new DevComponents.DotNetBar.ButtonX();
            this.grdVariablesMedicion = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.label25 = new System.Windows.Forms.Label();
            this.btnAgregarDispostivoMedicion = new DevComponents.DotNetBar.ButtonX();
            this.btnHojaVidaDipositivoMedicion = new DevComponents.DotNetBar.ButtonX();
            this.btnQuitarDispositivo = new DevComponents.DotNetBar.ButtonX();
            this.grddispositivosMedicion = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.rdAdecuadoNo = new System.Windows.Forms.RadioButton();
            this.rdAdecuado = new System.Windows.Forms.RadioButton();
            this.rdManteimientoIndicadoNo = new System.Windows.Forms.RadioButton();
            this.rdMantemientoIndicado = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.calMantenimientoxUsuario = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.grdRepuestos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.btnAgregarRepuesto = new DevComponents.DotNetBar.ButtonX();
            this.btnModificarRepuesto = new DevComponents.DotNetBar.ButtonX();
            this.btnQuitarRepuesto = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregarActividad = new DevComponents.DotNetBar.ButtonX();
            this.btnModificarActividad = new DevComponents.DotNetBar.ButtonX();
            this.btnEliminarActividad = new DevComponents.DotNetBar.ButtonX();
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.txtObservacionesIngeniero = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.txtFallasReportadas = new System.Windows.Forms.TextBox();
            this.grdActividades = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.c1CmbIng = new C1.Win.C1TrueDBGrid.C1TrueDBDropdown();
            this.tabItem8 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.calFechaFinProgramacionIA = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label11 = new System.Windows.Forms.Label();
            this.calFechaCreacion = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.calCierre = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label37 = new System.Windows.Forms.Label();
            this.calFechaProgramacionIA = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label2 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.calAprobacion = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtAnuladaPor = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtAprobadaPor = new System.Windows.Forms.TextBox();
            this.calAnulacion = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtCerradaPor = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.txtCreadaPor = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnReasignar = new DevComponents.DotNetBar.ButtonX();
            this.grdAsignaciones = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel3 = new DevComponents.DotNetBar.TabControlPanel();
            this.btnVerArchivo = new DevComponents.DotNetBar.ButtonX();
            this.btnSubirArchivo = new DevComponents.DotNetBar.ButtonX();
            this.btnGuardarArchivo = new DevComponents.DotNetBar.ButtonX();
            this.btnQuitarArchivo = new DevComponents.DotNetBar.ButtonX();
            this.grdArchivos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.tabItem3 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel7 = new DevComponents.DotNetBar.TabControlPanel();
            this.btnImprimirOrdenPrestamo = new DevComponents.DotNetBar.ButtonX();
            this.btnActualizarOrdenPrestamo = new DevComponents.DotNetBar.ButtonX();
            this.btnSolicitarOrdenPrestamo = new DevComponents.DotNetBar.ButtonX();
            this.btnModificarOrdenPrestamo = new DevComponents.DotNetBar.ButtonX();
            this.btnEliminarOrdenPrestamo = new DevComponents.DotNetBar.ButtonX();
            this.grdOrdenPrestamo = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.tabItem7 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel5 = new DevComponents.DotNetBar.TabControlPanel();
            this.grpInformacionCliente = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnCambiarInformacionAceptacionCliente = new DevComponents.DotNetBar.ButtonX();
            this.cmbAmPMSalidaCliente = new System.Windows.Forms.ComboBox();
            this.cmbMinSalidaCliente = new System.Windows.Forms.ComboBox();
            this.label38 = new System.Windows.Forms.Label();
            this.cmbHoraSalidaCliente = new System.Windows.Forms.ComboBox();
            this.txtUsuarioCliente = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.cmbAmPmLlegadaCliente = new System.Windows.Forms.ComboBox();
            this.cmbHoraLlegadaCliente = new System.Windows.Forms.ComboBox();
            this.cmbMinutosLlegadaCliente = new System.Windows.Forms.ComboBox();
            this.btnQuitarComprobante = new System.Windows.Forms.Button();
            this.btnAgregarComprobante = new System.Windows.Forms.Button();
            this.btnGuardarComprobante = new System.Windows.Forms.Button();
            this.btnVerComprobante = new System.Windows.Forms.Button();
            this.grdComprobantes = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.tabItem5 = new DevComponents.DotNetBar.TabItem(this.components);
            this.btnGuardar = new DevComponents.DotNetBar.ButtonX();
            this.btnImprimir = new DevComponents.DotNetBar.ButtonX();
            this.btnAnular = new DevComponents.DotNetBar.ButtonX();
            this.btnReabrirOrden = new DevComponents.DotNetBar.ButtonX();
            this.btnCerrarOrden = new DevComponents.DotNetBar.ButtonX();
            this.btnAprobarOrden = new DevComponents.DotNetBar.ButtonX();
            this.btnAceptar = new DevComponents.DotNetBar.ButtonX();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btnCancelar = new DevComponents.DotNetBar.ButtonX();
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem2 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem3 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem5 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem6 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem7 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem8 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem9 = new DevComponents.DotNetBar.ControlContainerItem();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tipoServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.TipoServicioTableAdapter();
            this.prioridadesOrdenServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.prioridadesOrdenServicioTableAdapter();
            this.archivosXOrdenServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.archivosXOrdenServicioTableAdapter();
            this.estadosOrdenServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.estadosOrdenServicioTableAdapter();
            this.reasignacionOrdenesTrabajoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.reasignacionOrdenesTrabajoTableAdapter();
            this.tipoComprobanteTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.tipoComprobanteTableAdapter();
            this.ordenServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter();
            this.equiposTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter();
            this.fabricanteTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.fabricanteTableAdapter();
            this.modelosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter();
            this.modalidadEquipoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ModalidadEquipoTableAdapter();
            this.tipoDocumentoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.tipoDocumentoTableAdapter();
            this.sucursalClienteTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.sucursalClienteTableAdapter();
            this.clientesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.clientesTableAdapter();
            this.departamentoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.departamentoTableAdapter();
            this.paisesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.paisesTableAdapter();
            this.ciudadesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ciudadesTableAdapter();
            this.entradaSalidaEquiposTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.EntradaSalidaEquiposTableAdapter();
            this.actividadxordenServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.actividadxordenServicioTableAdapter();
            this.comprobantesAceptacionOrdenservicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.comprobantesAceptacionOrdenservicioTableAdapter();
            this.solicitudInsumosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.solicitudInsumosTableAdapter();
            this.ordenPrestamoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.OrdenPrestamoTableAdapter();
            this.pltOrdenPrestamoTableAdapter1 = new SPControladoraDatos.dsPlantillasTableAdapters.pltOrdenPrestamoTableAdapter();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.asesoresComercialesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.asesoresComercialesTableAdapter();
            this.solicitudServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.solicitudServicioTableAdapter();
            this.repuestoxOrdenServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.repuestoxOrdenServicioTableAdapter();
            this.pltRepuestosxOrdenServicioTableAdapter1 = new SPControladoraDatos.dsPlantillasTableAdapters.pltRepuestosxOrdenServicioTableAdapter();
            this.logCambioUbicacionesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.logCambioUbicacionesTableAdapter();
            this.defaultsTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter();
            this.contratosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.contratosTableAdapter();
            this.mantenimientosxContratoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.mantenimientosxContratoTableAdapter();
            this.contratosxEquipoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.contratosxEquipoTableAdapter();
            this.actividad_adicionalTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.actividad_adicionalTableAdapter();
            this.notificacionTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.notificacionTableAdapter();
            this.llamadaSoporteTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.LlamadaSoporteTableAdapter();
            this.comprobantesAceptacionOrdenservicioTableAdapter2 = new SPControladoraDatos.dsSpxTableAdapters.comprobantesAceptacionOrdenservicioTableAdapter();
            this.dsSPXSeguridad2 = new SPXSeguridad.data.dsSPXSeguridad();
            this.clsTusuario1 = new SPXSeguridad.data.cls.clsTusuario();
            this.dispositivosmedicionxordenservicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.dispositivosmedicionxordenservicioTableAdapter();
            this.pltVariablesxOrdenServicioTableAdapter1 = new SPControladoraDatos.dsPlantillasTableAdapters.pltVariablesxOrdenServicioTableAdapter();
            this.pltDispositivosxOrdenTableAdapter1 = new SPControladoraDatos.dsPlantillasTableAdapters.pltDispositivosxOrdenTableAdapter();
            this.grpIngeniero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calUltimoMantenimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calProximoMantenimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.grpFecha.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpPorContrato.SuspendLayout();
            this.tabControlPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdExpotarReportesInsumos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSolicitudesInsumos)).BeginInit();
            this.tabControlPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVariablesMedicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grddispositivosMedicion)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calMantenimientoxUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRepuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdActividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CmbIng)).BeginInit();
            this.tabControlPanel2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaFinProgramacionIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaCreacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calCierre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaProgramacionIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calAprobacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calAnulacion)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAsignaciones)).BeginInit();
            this.tabControlPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdArchivos)).BeginInit();
            this.tabControlPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrdenPrestamo)).BeginInit();
            this.tabControlPanel5.SuspendLayout();
            this.grpInformacionCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdComprobantes)).BeginInit();
            this.ribbonBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpIngeniero
            // 
            this.grpIngeniero.BackColor = System.Drawing.Color.Transparent;
            this.grpIngeniero.Controls.Add(this.btnLimpiarIngeniero);
            this.grpIngeniero.Controls.Add(this.lblIngeniero);
            this.grpIngeniero.Controls.Add(this.cmbIngeniero);
            this.grpIngeniero.Location = new System.Drawing.Point(5, 186);
            this.grpIngeniero.Name = "grpIngeniero";
            this.grpIngeniero.Size = new System.Drawing.Size(578, 49);
            this.grpIngeniero.TabIndex = 11;
            this.grpIngeniero.TabStop = false;
            this.grpIngeniero.Text = "Ingeniero Asignado";
            // 
            // btnLimpiarIngeniero
            // 
            this.btnLimpiarIngeniero.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarIngeniero.Location = new System.Drawing.Point(245, 19);
            this.btnLimpiarIngeniero.Name = "btnLimpiarIngeniero";
            this.btnLimpiarIngeniero.Size = new System.Drawing.Size(26, 23);
            this.btnLimpiarIngeniero.TabIndex = 67;
            this.btnLimpiarIngeniero.Text = "<<";
            this.btnLimpiarIngeniero.UseVisualStyleBackColor = true;
            this.btnLimpiarIngeniero.Click += new System.EventHandler(this.btnLimpiarIngeniero_Click);
            // 
            // lblIngeniero
            // 
            this.lblIngeniero.BackColor = System.Drawing.Color.White;
            this.lblIngeniero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSPXSeguridad1, "usuario.login", true));
            this.lblIngeniero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngeniero.Location = new System.Drawing.Point(281, 21);
            this.lblIngeniero.Name = "lblIngeniero";
            this.lblIngeniero.Size = new System.Drawing.Size(254, 18);
            this.lblIngeniero.TabIndex = 1;
            // 
            // dsSPXSeguridad1
            // 
            this.dsSPXSeguridad1.DataSetName = "dsSPXSeguridad";
            this.dsSPXSeguridad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbIngeniero
            // 
            this.cmbIngeniero.DataSource = this.dsSPXSeguridad1;
            this.cmbIngeniero.DisplayMember = "usuario.nombre";
            this.cmbIngeniero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIngeniero.FormattingEnabled = true;
            this.cmbIngeniero.Location = new System.Drawing.Point(6, 20);
            this.cmbIngeniero.Name = "cmbIngeniero";
            this.cmbIngeniero.Size = new System.Drawing.Size(232, 23);
            this.cmbIngeniero.TabIndex = 0;
            this.cmbIngeniero.ValueMember = "usuario.login";
            this.cmbIngeniero.SelectedIndexChanged += new System.EventHandler(this.cmbIngeniero_SelectedIndexChanged);
            this.cmbIngeniero.Validating += new System.ComponentModel.CancelEventHandler(this.cmbIngeniero_Validating);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "prioridadesOrdenServicio.orden", true));
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(73, 77);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(14, 15);
            this.label28.TabIndex = 60;
            this.label28.Text = "0";
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.EnforceConstraints = false;
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Location = new System.Drawing.Point(6, 77);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(57, 15);
            this.label27.TabIndex = 59;
            this.label27.Text = "Prioridad";
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(16, 45);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(187, 26);
            this.label24.TabIndex = 56;
            this.label24.Text = "Fecha Tentativo Fin de Ejecucion";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(6, 160);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(94, 15);
            this.label22.TabIndex = 55;
            this.label22.Text = "Tipo de Servicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(357, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 41;
            this.label4.Text = "Numero Entrada";
            // 
            // txtNumeroEntrada
            // 
            this.txtNumeroEntrada.Location = new System.Drawing.Point(458, 18);
            this.txtNumeroEntrada.Name = "txtNumeroEntrada";
            this.txtNumeroEntrada.ReadOnly = true;
            this.txtNumeroEntrada.Size = new System.Drawing.Size(79, 21);
            this.txtNumeroEntrada.TabIndex = 43;
            // 
            // txtNumeroOrdenServicio
            // 
            this.txtNumeroOrdenServicio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "ordenServicio.codOrdenServicio", true));
            this.txtNumeroOrdenServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroOrdenServicio.Location = new System.Drawing.Point(147, 17);
            this.txtNumeroOrdenServicio.Name = "txtNumeroOrdenServicio";
            this.txtNumeroOrdenServicio.ReadOnly = true;
            this.txtNumeroOrdenServicio.Size = new System.Drawing.Size(74, 21);
            this.txtNumeroOrdenServicio.TabIndex = 39;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdOrdenExterna);
            this.groupBox1.Controls.Add(this.rdInterna);
            this.groupBox1.Location = new System.Drawing.Point(230, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 56);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            // 
            // rdOrdenExterna
            // 
            this.rdOrdenExterna.AutoSize = true;
            this.rdOrdenExterna.Location = new System.Drawing.Point(8, 34);
            this.rdOrdenExterna.Name = "rdOrdenExterna";
            this.rdOrdenExterna.Size = new System.Drawing.Size(104, 19);
            this.rdOrdenExterna.TabIndex = 1;
            this.rdOrdenExterna.TabStop = true;
            this.rdOrdenExterna.Text = "Orden Externa";
            this.rdOrdenExterna.UseVisualStyleBackColor = true;
            this.rdOrdenExterna.CheckedChanged += new System.EventHandler(this.rdOrdenExterna_CheckedChanged);
            // 
            // rdInterna
            // 
            this.rdInterna.AutoSize = true;
            this.rdInterna.Location = new System.Drawing.Point(8, 10);
            this.rdInterna.Name = "rdInterna";
            this.rdInterna.Size = new System.Drawing.Size(100, 19);
            this.rdInterna.TabIndex = 0;
            this.rdInterna.TabStop = true;
            this.rdInterna.Text = "Orden Interna";
            this.rdInterna.UseVisualStyleBackColor = true;
            this.rdInterna.CheckedChanged += new System.EventHandler(this.rdInterna_CheckedChanged);
            this.rdInterna.Click += new System.EventHandler(this.rdInterna_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 45;
            this.label1.Text = "Numero Orden Servicio";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btnInfCliente);
            this.groupBox4.Controls.Add(this.txtNombrecliente);
            this.groupBox4.Controls.Add(this.txtNitCliente);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(6, 233);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(387, 171);
            this.groupBox4.TabIndex = 62;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informacion del Cliente";
            // 
            // btnInfCliente
            // 
            this.btnInfCliente.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInfCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnInfCliente.Image")));
            this.btnInfCliente.ImageFixedSize = new System.Drawing.Size(29, 29);
            this.btnInfCliente.Location = new System.Drawing.Point(314, 16);
            this.btnInfCliente.Name = "btnInfCliente";
            this.btnInfCliente.Size = new System.Drawing.Size(33, 33);
            this.btnInfCliente.TabIndex = 62;
            this.btnInfCliente.Click += new System.EventHandler(this.btnInfCliente_Click);
            // 
            // txtNombrecliente
            // 
            this.txtNombrecliente.Location = new System.Drawing.Point(75, 51);
            this.txtNombrecliente.Name = "txtNombrecliente";
            this.txtNombrecliente.ReadOnly = true;
            this.txtNombrecliente.Size = new System.Drawing.Size(290, 21);
            this.txtNombrecliente.TabIndex = 1;
            // 
            // txtNitCliente
            // 
            this.txtNitCliente.Location = new System.Drawing.Point(74, 21);
            this.txtNitCliente.Name = "txtNitCliente";
            this.txtNitCliente.ReadOnly = true;
            this.txtNitCliente.Size = new System.Drawing.Size(234, 21);
            this.txtNitCliente.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnInfSucursal);
            this.groupBox5.Controls.Add(this.txtSucursal);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Location = new System.Drawing.Point(4, 91);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(377, 69);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sucursal del Cliente";
            // 
            // btnInfSucursal
            // 
            this.btnInfSucursal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInfSucursal.Image = ((System.Drawing.Image)(resources.GetObject("btnInfSucursal.Image")));
            this.btnInfSucursal.ImageFixedSize = new System.Drawing.Size(29, 29);
            this.btnInfSucursal.Location = new System.Drawing.Point(316, 24);
            this.btnInfSucursal.Name = "btnInfSucursal";
            this.btnInfSucursal.Size = new System.Drawing.Size(33, 33);
            this.btnInfSucursal.TabIndex = 63;
            this.btnInfSucursal.Click += new System.EventHandler(this.btnInfSucursal_Click);
            // 
            // txtSucursal
            // 
            this.txtSucursal.Location = new System.Drawing.Point(76, 32);
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.ReadOnly = true;
            this.txtSucursal.Size = new System.Drawing.Size(234, 21);
            this.txtSucursal.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 35);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 15);
            this.label19.TabIndex = 19;
            this.label19.Text = "Sucursal";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(4, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 42);
            this.label12.TabIndex = 16;
            this.label12.Text = "Nombre Cliente";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 15);
            this.label15.TabIndex = 11;
            this.label15.Text = "Nit cliente";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.calUltimoMantenimiento);
            this.groupBox3.Controls.Add(this.calProximoMantenimiento);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnInfEquipo);
            this.groupBox3.Controls.Add(this.txtModalidad);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.btnBuscarSerial);
            this.groupBox3.Controls.Add(this.txtFabricante);
            this.groupBox3.Controls.Add(this.txtModelo);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtSerial);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 216);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion del Equipo";
            // 
            // calUltimoMantenimiento
            // 
            // 
            // 
            // 
            this.calUltimoMantenimiento.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calUltimoMantenimiento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calUltimoMantenimiento.ButtonDropDown.Visible = true;
            this.calUltimoMantenimiento.Enabled = false;
            this.calUltimoMantenimiento.Location = new System.Drawing.Point(102, 184);
            // 
            // 
            // 
            this.calUltimoMantenimiento.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calUltimoMantenimiento.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calUltimoMantenimiento.MonthCalendar.BackgroundStyle.Class = "";
            this.calUltimoMantenimiento.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calUltimoMantenimiento.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calUltimoMantenimiento.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calUltimoMantenimiento.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calUltimoMantenimiento.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calUltimoMantenimiento.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calUltimoMantenimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calUltimoMantenimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calUltimoMantenimiento.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calUltimoMantenimiento.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calUltimoMantenimiento.MonthCalendar.DisplayMonth = new System.DateTime(2008, 4, 1, 0, 0, 0, 0);
            this.calUltimoMantenimiento.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calUltimoMantenimiento.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calUltimoMantenimiento.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calUltimoMantenimiento.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calUltimoMantenimiento.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calUltimoMantenimiento.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calUltimoMantenimiento.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calUltimoMantenimiento.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calUltimoMantenimiento.MonthCalendar.TodayButtonVisible = true;
            this.calUltimoMantenimiento.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calUltimoMantenimiento.Name = "calUltimoMantenimiento";
            this.calUltimoMantenimiento.Size = new System.Drawing.Size(207, 21);
            this.calUltimoMantenimiento.TabIndex = 7;
            // 
            // calProximoMantenimiento
            // 
            // 
            // 
            // 
            this.calProximoMantenimiento.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calProximoMantenimiento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calProximoMantenimiento.ButtonDropDown.Visible = true;
            this.calProximoMantenimiento.Enabled = false;
            this.calProximoMantenimiento.Location = new System.Drawing.Point(102, 147);
            // 
            // 
            // 
            this.calProximoMantenimiento.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calProximoMantenimiento.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calProximoMantenimiento.MonthCalendar.BackgroundStyle.Class = "";
            this.calProximoMantenimiento.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calProximoMantenimiento.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calProximoMantenimiento.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calProximoMantenimiento.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calProximoMantenimiento.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calProximoMantenimiento.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calProximoMantenimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calProximoMantenimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calProximoMantenimiento.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calProximoMantenimiento.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calProximoMantenimiento.MonthCalendar.DisplayMonth = new System.DateTime(2008, 4, 1, 0, 0, 0, 0);
            this.calProximoMantenimiento.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calProximoMantenimiento.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calProximoMantenimiento.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calProximoMantenimiento.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calProximoMantenimiento.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calProximoMantenimiento.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calProximoMantenimiento.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calProximoMantenimiento.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calProximoMantenimiento.MonthCalendar.TodayButtonVisible = true;
            this.calProximoMantenimiento.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calProximoMantenimiento.Name = "calProximoMantenimiento";
            this.calProximoMantenimiento.Size = new System.Drawing.Size(207, 21);
            this.calProximoMantenimiento.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(7, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "Serial";
            // 
            // btnInfEquipo
            // 
            this.btnInfEquipo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnInfEquipo, null);
            this.balloonTip1.SetBalloonText(this.btnInfEquipo, "Informacion Adicional del equipo");
            this.btnInfEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfEquipo.Image")));
            this.btnInfEquipo.ImageFixedSize = new System.Drawing.Size(29, 29);
            this.btnInfEquipo.Location = new System.Drawing.Point(350, 16);
            this.btnInfEquipo.Name = "btnInfEquipo";
            this.btnInfEquipo.Size = new System.Drawing.Size(33, 33);
            this.btnInfEquipo.TabIndex = 67;
            this.btnInfEquipo.Click += new System.EventHandler(this.btnInfEquipo_Click);
            // 
            // txtModalidad
            // 
            this.txtModalidad.Location = new System.Drawing.Point(75, 103);
            this.txtModalidad.Name = "txtModalidad";
            this.txtModalidad.ReadOnly = true;
            this.txtModalidad.Size = new System.Drawing.Size(234, 21);
            this.txtModalidad.TabIndex = 30;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(7, 107);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(66, 15);
            this.label26.TabIndex = 31;
            this.label26.Text = "Modalidad";
            // 
            // btnBuscarSerial
            // 
            this.btnBuscarSerial.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnBuscarSerial, null);
            this.balloonTip1.SetBalloonText(this.btnBuscarSerial, "Buscar Equipo");
            this.btnBuscarSerial.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarSerial.Image")));
            this.btnBuscarSerial.ImageFixedSize = new System.Drawing.Size(29, 29);
            this.btnBuscarSerial.Location = new System.Drawing.Point(315, 16);
            this.btnBuscarSerial.Name = "btnBuscarSerial";
            this.btnBuscarSerial.Size = new System.Drawing.Size(33, 33);
            this.btnBuscarSerial.TabIndex = 29;
            this.btnBuscarSerial.Click += new System.EventHandler(this.btnBuscarSerial_Click);
            // 
            // txtFabricante
            // 
            this.txtFabricante.Location = new System.Drawing.Point(75, 49);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.ReadOnly = true;
            this.txtFabricante.Size = new System.Drawing.Size(234, 21);
            this.txtFabricante.TabIndex = 3;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(75, 76);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.ReadOnly = true;
            this.txtModelo.Size = new System.Drawing.Size(234, 21);
            this.txtModelo.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(7, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 33);
            this.label10.TabIndex = 17;
            this.label10.Text = "Fecha Ultimo Mantenimiento";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(7, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 33);
            this.label9.TabIndex = 16;
            this.label9.Text = "Fecha Proximo Mantenimiento";
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(75, 24);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(234, 21);
            this.txtSerial.TabIndex = 0;
            this.txtSerial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSerial_KeyDown);
            this.txtSerial.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtSerial_MouseDoubleClick);
            this.txtSerial.Validating += new System.ComponentModel.CancelEventHandler(this.txtSerial_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Modelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fabricante";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(306, 78);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(45, 15);
            this.label23.TabIndex = 64;
            this.label23.Text = "Estado";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Controls.Add(this.tabControlPanel6);
            this.tabControl1.Controls.Add(this.tabControlPanel8);
            this.tabControl1.Controls.Add(this.tabControlPanel2);
            this.tabControl1.Controls.Add(this.tabControlPanel3);
            this.tabControl1.Controls.Add(this.tabControlPanel7);
            this.tabControl1.Controls.Add(this.tabControlPanel5);
            this.tabControl1.Location = new System.Drawing.Point(0, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1026, 671);
            this.tabControl1.TabIndex = 65;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItem1);
            this.tabControl1.Tabs.Add(this.tabItem2);
            this.tabControl1.Tabs.Add(this.tabItem8);
            this.tabControl1.Tabs.Add(this.tabItem3);
            this.tabControl1.Tabs.Add(this.tabItem5);
            this.tabControl1.Tabs.Add(this.tabItem6);
            this.tabControl1.Tabs.Add(this.tabItem7);
            this.tabControl1.SelectedTabChanging += new DevComponents.DotNetBar.TabStrip.SelectedTabChangingEventHandler(this.tabControl1_SelectedTabChanging);
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.grpFecha);
            this.tabControlPanel1.Controls.Add(this.groupBox2);
            this.tabControlPanel1.Controls.Add(this.label43);
            this.tabControlPanel1.Controls.Add(this.txtObservacionesIniciales);
            this.tabControlPanel1.Controls.Add(this.groupBox4);
            this.tabControlPanel1.Controls.Add(this.groupBox3);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(1026, 645);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabItem1;
            // 
            // grpFecha
            // 
            this.grpFecha.BackColor = System.Drawing.Color.Transparent;
            this.grpFecha.Controls.Add(this.btnConsultarDisponib);
            this.grpFecha.Controls.Add(this.calInicioProg);
            this.grpFecha.Controls.Add(this.calFinProg);
            this.grpFecha.Controls.Add(this.label3);
            this.grpFecha.Controls.Add(this.label24);
            this.grpFecha.Location = new System.Drawing.Point(403, 254);
            this.grpFecha.Name = "grpFecha";
            this.grpFecha.Size = new System.Drawing.Size(508, 75);
            this.grpFecha.TabIndex = 70;
            this.grpFecha.TabStop = false;
            // 
            // btnConsultarDisponib
            // 
            this.btnConsultarDisponib.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnConsultarDisponib, "Consultar Disponibilidad");
            this.balloonTip1.SetBalloonText(this.btnConsultarDisponib, null);
            this.btnConsultarDisponib.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarDisponib.Image")));
            this.btnConsultarDisponib.ImageFixedSize = new System.Drawing.Size(29, 29);
            this.btnConsultarDisponib.Location = new System.Drawing.Point(450, 10);
            this.btnConsultarDisponib.Name = "btnConsultarDisponib";
            this.btnConsultarDisponib.Size = new System.Drawing.Size(33, 33);
            this.btnConsultarDisponib.TabIndex = 72;
            this.btnConsultarDisponib.Click += new System.EventHandler(this.btnConsultarDisponib_Click);
            // 
            // calInicioProg
            // 
            this.calInicioProg.BackColor = System.Drawing.Color.Transparent;
            this.calInicioProg.fechaValue = new System.DateTime(((long)(0)));
            this.calInicioProg.fechaValueObject = null;
            this.calInicioProg.Location = new System.Drawing.Point(207, 15);
            this.calInicioProg.Name = "calInicioProg";
            this.calInicioProg.Size = new System.Drawing.Size(216, 23);
            this.calInicioProg.TabIndex = 73;
            this.calInicioProg.Validated += new System.EventHandler(this.calInicioProg_Validated);
            // 
            // calFinProg
            // 
            this.calFinProg.BackColor = System.Drawing.Color.Transparent;
            this.calFinProg.fechaValue = new System.DateTime(((long)(0)));
            this.calFinProg.fechaValueObject = null;
            this.calFinProg.Location = new System.Drawing.Point(209, 49);
            this.calFinProg.Name = "calFinProg";
            this.calFinProg.Size = new System.Drawing.Size(214, 27);
            this.calFinProg.TabIndex = 74;
            this.calFinProg.Validating += new System.ComponentModel.CancelEventHandler(this.calFinProg_Validating);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(16, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 65;
            this.label3.Text = "Fecha Tentativa Ejecucion";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.grpPorContrato);
            this.groupBox2.Controls.Add(this.btnVerES);
            this.groupBox2.Controls.Add(this.btnLimpiaAsesor);
            this.groupBox2.Controls.Add(this.grpIngeniero);
            this.groupBox2.Controls.Add(this.cmbAsesorComercial);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNumeroOrdenServicio);
            this.groupBox2.Controls.Add(this.cmbEstado);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.txtNumeroEntrada);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.cmbTipoServicio);
            this.groupBox2.Controls.Add(this.cmbPrioridad);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(403, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(592, 244);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            // 
            // grpPorContrato
            // 
            this.grpPorContrato.BackColor = System.Drawing.Color.Transparent;
            this.grpPorContrato.Controls.Add(this.txtNumeroContrato);
            this.grpPorContrato.Controls.Add(this.label13);
            this.grpPorContrato.Controls.Add(this.rdContratoNo);
            this.grpPorContrato.Controls.Add(this.rdContratoSi);
            this.grpPorContrato.Location = new System.Drawing.Point(6, 104);
            this.grpPorContrato.Name = "grpPorContrato";
            this.grpPorContrato.Size = new System.Drawing.Size(342, 42);
            this.grpPorContrato.TabIndex = 75;
            this.grpPorContrato.TabStop = false;
            this.grpPorContrato.Text = "Por Contrato";
            // 
            // txtNumeroContrato
            // 
            this.txtNumeroContrato.BackColor = System.Drawing.Color.White;
            this.txtNumeroContrato.Location = new System.Drawing.Point(227, 16);
            this.txtNumeroContrato.Name = "txtNumeroContrato";
            this.txtNumeroContrato.ReadOnly = true;
            this.txtNumeroContrato.Size = new System.Drawing.Size(100, 21);
            this.txtNumeroContrato.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(124, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "Numero Contrato";
            // 
            // rdContratoNo
            // 
            this.rdContratoNo.AutoSize = true;
            this.rdContratoNo.Checked = true;
            this.rdContratoNo.Location = new System.Drawing.Point(50, 15);
            this.rdContratoNo.Name = "rdContratoNo";
            this.rdContratoNo.Size = new System.Drawing.Size(41, 19);
            this.rdContratoNo.TabIndex = 1;
            this.rdContratoNo.TabStop = true;
            this.rdContratoNo.Text = "No";
            this.rdContratoNo.UseVisualStyleBackColor = true;
            this.rdContratoNo.CheckedChanged += new System.EventHandler(this.rdContratoNo_CheckedChanged);
            // 
            // rdContratoSi
            // 
            this.rdContratoSi.AutoSize = true;
            this.rdContratoSi.Location = new System.Drawing.Point(6, 15);
            this.rdContratoSi.Name = "rdContratoSi";
            this.rdContratoSi.Size = new System.Drawing.Size(36, 19);
            this.rdContratoSi.TabIndex = 0;
            this.rdContratoSi.Text = "Si";
            this.rdContratoSi.UseVisualStyleBackColor = true;
            // 
            // btnVerES
            // 
            this.btnVerES.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnVerES, "Ver Entrada ");
            this.btnVerES.Image = ((System.Drawing.Image)(resources.GetObject("btnVerES.Image")));
            this.btnVerES.ImageFixedSize = new System.Drawing.Size(29, 29);
            this.btnVerES.Location = new System.Drawing.Point(540, 12);
            this.btnVerES.Name = "btnVerES";
            this.btnVerES.Size = new System.Drawing.Size(33, 33);
            this.btnVerES.TabIndex = 74;
            this.btnVerES.Click += new System.EventHandler(this.btnVerES_Click);
            // 
            // btnLimpiaAsesor
            // 
            this.btnLimpiaAsesor.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiaAsesor.Location = new System.Drawing.Point(557, 158);
            this.btnLimpiaAsesor.Name = "btnLimpiaAsesor";
            this.btnLimpiaAsesor.Size = new System.Drawing.Size(26, 23);
            this.btnLimpiaAsesor.TabIndex = 73;
            this.btnLimpiaAsesor.Text = "<<";
            this.btnLimpiaAsesor.UseVisualStyleBackColor = true;
            this.btnLimpiaAsesor.Click += new System.EventHandler(this.btnLimpiaAsesor_Click);
            // 
            // cmbAsesorComercial
            // 
            this.cmbAsesorComercial.DataSource = this.dsSpx1;
            this.cmbAsesorComercial.DisplayMember = "asesoresComerciales.NombreAsesor";
            this.cmbAsesorComercial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAsesorComercial.FormattingEnabled = true;
            this.cmbAsesorComercial.Location = new System.Drawing.Point(375, 160);
            this.cmbAsesorComercial.Name = "cmbAsesorComercial";
            this.cmbAsesorComercial.Size = new System.Drawing.Size(177, 23);
            this.cmbAsesorComercial.TabIndex = 71;
            this.cmbAsesorComercial.ValueMember = "asesoresComerciales.codAsesor";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsSpx1, "ordenServicio.codEstadoOrdenServicio", true));
            this.cmbEstado.DataSource = this.dsSpx1;
            this.cmbEstado.DisplayMember = "estadosOrdenServicio.nombreEstado";
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Enabled = false;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(375, 73);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(179, 23);
            this.cmbEstado.TabIndex = 63;
            this.cmbEstado.ValueMember = "estadosOrdenServicio.codEstadoOrdenServicio";
            // 
            // cmbTipoServicio
            // 
            this.cmbTipoServicio.DataSource = this.dsSpx1;
            this.cmbTipoServicio.DisplayMember = "TipoServicio.nombretipoServicio";
            this.cmbTipoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoServicio.FormattingEnabled = true;
            this.cmbTipoServicio.Location = new System.Drawing.Point(104, 157);
            this.cmbTipoServicio.Name = "cmbTipoServicio";
            this.cmbTipoServicio.Size = new System.Drawing.Size(198, 23);
            this.cmbTipoServicio.TabIndex = 40;
            this.cmbTipoServicio.ValueMember = "TipoServicio.codTipoServicio";
            this.cmbTipoServicio.SelectedIndexChanged += new System.EventHandler(this.cmbTipoServicio_SelectedIndexChanged);
            this.cmbTipoServicio.Validated += new System.EventHandler(this.cmbTipoServicio_Validated);
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.DataSource = this.dsSpx1;
            this.cmbPrioridad.DisplayMember = "prioridadesOrdenServicio.nombre";
            this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Location = new System.Drawing.Point(104, 75);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(198, 23);
            this.cmbPrioridad.TabIndex = 58;
            this.cmbPrioridad.ValueMember = "prioridadesOrdenServicio.codPrioridadOS";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(306, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 32);
            this.label8.TabIndex = 72;
            this.label8.Text = "Asesor Comercial";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Transparent;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label43.Location = new System.Drawing.Point(406, 339);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(159, 15);
            this.label43.TabIndex = 66;
            this.label43.Text = "Observaciones Iniciales";
            // 
            // txtObservacionesIniciales
            // 
            this.txtObservacionesIniciales.Location = new System.Drawing.Point(405, 357);
            this.txtObservacionesIniciales.MaxLength = 1500;
            this.txtObservacionesIniciales.Multiline = true;
            this.txtObservacionesIniciales.Name = "txtObservacionesIniciales";
            this.txtObservacionesIniciales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacionesIniciales.Size = new System.Drawing.Size(581, 156);
            this.txtObservacionesIniciales.TabIndex = 65;
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel1;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "Informacion General";
            // 
            // tabControlPanel6
            // 
            this.tabControlPanel6.Controls.Add(this.grdExpotarReportesInsumos);
            this.tabControlPanel6.Controls.Add(this.btnGenerarExcel);
            this.tabControlPanel6.Controls.Add(this.btnImprimirSolicitud);
            this.tabControlPanel6.Controls.Add(this.btnActualizarSolicitudes);
            this.tabControlPanel6.Controls.Add(this.btnEliminarSolicitud);
            this.tabControlPanel6.Controls.Add(this.btnModifcarSolicitud);
            this.tabControlPanel6.Controls.Add(this.btnAgregarInsumos);
            this.tabControlPanel6.Controls.Add(this.grdSolicitudesInsumos);
            this.tabControlPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel6.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel6.Name = "tabControlPanel6";
            this.tabControlPanel6.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel6.Size = new System.Drawing.Size(1026, 645);
            this.tabControlPanel6.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel6.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel6.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel6.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel6.Style.GradientAngle = 90;
            this.tabControlPanel6.TabIndex = 6;
            this.tabControlPanel6.TabItem = this.tabItem6;
            // 
            // grdExpotarReportesInsumos
            // 
            this.grdExpotarReportesInsumos.AllowUpdate = false;
            this.grdExpotarReportesInsumos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdExpotarReportesInsumos.DataMember = "pltExportarInsumos";
            this.grdExpotarReportesInsumos.DataSource = this.dsPlantillas1;
            this.grdExpotarReportesInsumos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdExpotarReportesInsumos.Images"))));
            this.grdExpotarReportesInsumos.Location = new System.Drawing.Point(392, 53);
            this.grdExpotarReportesInsumos.Name = "grdExpotarReportesInsumos";
            this.grdExpotarReportesInsumos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdExpotarReportesInsumos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdExpotarReportesInsumos.PreviewInfo.ZoomFactor = 75D;
            this.grdExpotarReportesInsumos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdExpotarReportesInsumos.PrintInfo.PageSettings")));
            this.grdExpotarReportesInsumos.Size = new System.Drawing.Size(552, 496);
            this.grdExpotarReportesInsumos.TabIndex = 34;
            this.grdExpotarReportesInsumos.Text = "c1TrueDBGrid1";
            this.grdExpotarReportesInsumos.Visible = false;
            this.grdExpotarReportesInsumos.PropBag = resources.GetString("grdExpotarReportesInsumos.PropBag");
            // 
            // dsPlantillas1
            // 
            this.dsPlantillas1.DataSetName = "dsPlantillas";
            this.dsPlantillas1.EnforceConstraints = false;
            this.dsPlantillas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnGenerarExcel
            // 
            this.btnGenerarExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarExcel.Location = new System.Drawing.Point(131, 30);
            this.btnGenerarExcel.Name = "btnGenerarExcel";
            this.btnGenerarExcel.Size = new System.Drawing.Size(134, 23);
            this.btnGenerarExcel.TabIndex = 33;
            this.btnGenerarExcel.Text = "Generar Excel";
            this.btnGenerarExcel.UseVisualStyleBackColor = true;
            this.btnGenerarExcel.Click += new System.EventHandler(this.btnGenerarExcel_Click);
            // 
            // btnImprimirSolicitud
            // 
            this.btnImprimirSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirSolicitud.Location = new System.Drawing.Point(12, 30);
            this.btnImprimirSolicitud.Name = "btnImprimirSolicitud";
            this.btnImprimirSolicitud.Size = new System.Drawing.Size(113, 23);
            this.btnImprimirSolicitud.TabIndex = 32;
            this.btnImprimirSolicitud.Text = "Imprimir Solicitud";
            this.btnImprimirSolicitud.UseVisualStyleBackColor = true;
            this.btnImprimirSolicitud.Click += new System.EventHandler(this.btnImprimirSolicitud_Click);
            // 
            // btnActualizarSolicitudes
            // 
            this.btnActualizarSolicitudes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarSolicitudes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarSolicitudes.Location = new System.Drawing.Point(530, 30);
            this.btnActualizarSolicitudes.Name = "btnActualizarSolicitudes";
            this.btnActualizarSolicitudes.Size = new System.Drawing.Size(120, 23);
            this.btnActualizarSolicitudes.TabIndex = 31;
            this.btnActualizarSolicitudes.Text = "Actualizar";
            this.btnActualizarSolicitudes.UseVisualStyleBackColor = true;
            this.btnActualizarSolicitudes.Click += new System.EventHandler(this.btnActualizarSolicitudes_Click);
            // 
            // btnEliminarSolicitud
            // 
            this.btnEliminarSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarSolicitud.Location = new System.Drawing.Point(890, 30);
            this.btnEliminarSolicitud.Name = "btnEliminarSolicitud";
            this.btnEliminarSolicitud.Size = new System.Drawing.Size(120, 23);
            this.btnEliminarSolicitud.TabIndex = 30;
            this.btnEliminarSolicitud.Text = "Eliminar Solicitud";
            this.btnEliminarSolicitud.UseVisualStyleBackColor = true;
            this.btnEliminarSolicitud.Click += new System.EventHandler(this.btnEliminarSolicitud_Click);
            // 
            // btnModifcarSolicitud
            // 
            this.btnModifcarSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifcarSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifcarSolicitud.Location = new System.Drawing.Point(770, 30);
            this.btnModifcarSolicitud.Name = "btnModifcarSolicitud";
            this.btnModifcarSolicitud.Size = new System.Drawing.Size(120, 23);
            this.btnModifcarSolicitud.TabIndex = 29;
            this.btnModifcarSolicitud.Text = "Modificar Solicitud";
            this.btnModifcarSolicitud.UseVisualStyleBackColor = true;
            this.btnModifcarSolicitud.Click += new System.EventHandler(this.btnModifcarSolicitud_Click);
            // 
            // btnAgregarInsumos
            // 
            this.btnAgregarInsumos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarInsumos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarInsumos.Location = new System.Drawing.Point(650, 30);
            this.btnAgregarInsumos.Name = "btnAgregarInsumos";
            this.btnAgregarInsumos.Size = new System.Drawing.Size(120, 23);
            this.btnAgregarInsumos.TabIndex = 28;
            this.btnAgregarInsumos.Text = "Realizar Solitud";
            this.btnAgregarInsumos.UseVisualStyleBackColor = true;
            this.btnAgregarInsumos.Click += new System.EventHandler(this.btnAgregarInsumos_Click);
            // 
            // grdSolicitudesInsumos
            // 
            this.grdSolicitudesInsumos.AllowUpdate = false;
            this.grdSolicitudesInsumos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdSolicitudesInsumos.DataMember = "solicitudInsumos";
            this.grdSolicitudesInsumos.DataSource = this.dsSpx1;
            this.grdSolicitudesInsumos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdSolicitudesInsumos.Images"))));
            this.grdSolicitudesInsumos.Location = new System.Drawing.Point(12, 59);
            this.grdSolicitudesInsumos.Name = "grdSolicitudesInsumos";
            this.grdSolicitudesInsumos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdSolicitudesInsumos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdSolicitudesInsumos.PreviewInfo.ZoomFactor = 75D;
            this.grdSolicitudesInsumos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdSolicitudesInsumos.PrintInfo.PageSettings")));
            this.grdSolicitudesInsumos.Size = new System.Drawing.Size(1002, 525);
            this.grdSolicitudesInsumos.TabIndex = 27;
            this.grdSolicitudesInsumos.Text = "c1TrueDBGrid1";
            this.grdSolicitudesInsumos.PropBag = resources.GetString("grdSolicitudesInsumos.PropBag");
            // 
            // tabItem6
            // 
            this.tabItem6.AttachedControl = this.tabControlPanel6;
            this.tabItem6.Name = "tabItem6";
            this.tabItem6.Text = "Solicitud de Insumos";
            // 
            // tabControlPanel8
            // 
            this.tabControlPanel8.Controls.Add(this.btnAgregarDispositivoMedicionExterno);
            this.tabControlPanel8.Controls.Add(this.btnVerRangos);
            this.tabControlPanel8.Controls.Add(this.btnAgregarVariableMedicion);
            this.tabControlPanel8.Controls.Add(this.btnEditarVariableMedicion);
            this.tabControlPanel8.Controls.Add(this.btnEliminarVariableMedicion);
            this.tabControlPanel8.Controls.Add(this.grdVariablesMedicion);
            this.tabControlPanel8.Controls.Add(this.label25);
            this.tabControlPanel8.Controls.Add(this.btnAgregarDispostivoMedicion);
            this.tabControlPanel8.Controls.Add(this.btnHojaVidaDipositivoMedicion);
            this.tabControlPanel8.Controls.Add(this.btnQuitarDispositivo);
            this.tabControlPanel8.Controls.Add(this.grddispositivosMedicion);
            this.tabControlPanel8.Controls.Add(this.label20);
            this.tabControlPanel8.Controls.Add(this.panel1);
            this.tabControlPanel8.Controls.Add(this.rdManteimientoIndicadoNo);
            this.tabControlPanel8.Controls.Add(this.rdMantemientoIndicado);
            this.tabControlPanel8.Controls.Add(this.label17);
            this.tabControlPanel8.Controls.Add(this.label14);
            this.tabControlPanel8.Controls.Add(this.calMantenimientoxUsuario);
            this.tabControlPanel8.Controls.Add(this.grdRepuestos);
            this.tabControlPanel8.Controls.Add(this.btnAgregarRepuesto);
            this.tabControlPanel8.Controls.Add(this.btnModificarRepuesto);
            this.tabControlPanel8.Controls.Add(this.btnQuitarRepuesto);
            this.tabControlPanel8.Controls.Add(this.btnAgregarActividad);
            this.tabControlPanel8.Controls.Add(this.btnModificarActividad);
            this.tabControlPanel8.Controls.Add(this.btnEliminarActividad);
            this.tabControlPanel8.Controls.Add(this.label21);
            this.tabControlPanel8.Controls.Add(this.label16);
            this.tabControlPanel8.Controls.Add(this.label46);
            this.tabControlPanel8.Controls.Add(this.txtObservacionesIngeniero);
            this.tabControlPanel8.Controls.Add(this.label45);
            this.tabControlPanel8.Controls.Add(this.txtDiagnostico);
            this.tabControlPanel8.Controls.Add(this.label44);
            this.tabControlPanel8.Controls.Add(this.txtFallasReportadas);
            this.tabControlPanel8.Controls.Add(this.grdActividades);
            this.tabControlPanel8.Controls.Add(this.c1CmbIng);
            this.tabControlPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel8.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel8.Name = "tabControlPanel8";
            this.tabControlPanel8.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel8.Size = new System.Drawing.Size(1026, 645);
            this.tabControlPanel8.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel8.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel8.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel8.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel8.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel8.Style.GradientAngle = 90;
            this.tabControlPanel8.TabIndex = 8;
            this.tabControlPanel8.TabItem = this.tabItem8;
            // 
            // btnAgregarDispositivoMedicionExterno
            // 
            this.btnAgregarDispositivoMedicionExterno.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnAgregarDispositivoMedicionExterno, null);
            this.balloonTip1.SetBalloonText(this.btnAgregarDispositivoMedicionExterno, "Agregar Dispositivo Externo");
            this.btnAgregarDispositivoMedicionExterno.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnAgregarDispositivoMedicionExterno.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnAgregarDispositivoMedicionExterno.Location = new System.Drawing.Point(811, 17);
            this.btnAgregarDispositivoMedicionExterno.Name = "btnAgregarDispositivoMedicionExterno";
            this.btnAgregarDispositivoMedicionExterno.Size = new System.Drawing.Size(109, 29);
            this.btnAgregarDispositivoMedicionExterno.TabIndex = 103;
            this.btnAgregarDispositivoMedicionExterno.Text = "Agregar Dispositivo Externo";
            this.btnAgregarDispositivoMedicionExterno.Tooltip = "Agregar Dispositivo Externo";
            this.btnAgregarDispositivoMedicionExterno.Click += new System.EventHandler(this.btnAgregarDispositivoMedicionExterno_Click);
            // 
            // btnVerRangos
            // 
            this.btnVerRangos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnVerRangos, null);
            this.balloonTip1.SetBalloonText(this.btnVerRangos, "Ver rangos configurados");
            this.btnVerRangos.Image = ((System.Drawing.Image)(resources.GetObject("btnVerRangos.Image")));
            this.btnVerRangos.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnVerRangos.Location = new System.Drawing.Point(796, 198);
            this.btnVerRangos.Name = "btnVerRangos";
            this.btnVerRangos.Size = new System.Drawing.Size(29, 29);
            this.btnVerRangos.TabIndex = 102;
            this.btnVerRangos.Click += new System.EventHandler(this.btnVerRangos_Click);
            // 
            // btnAgregarVariableMedicion
            // 
            this.btnAgregarVariableMedicion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnAgregarVariableMedicion, null);
            this.balloonTip1.SetBalloonText(this.btnAgregarVariableMedicion, "Agregar Variable");
            this.btnAgregarVariableMedicion.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarVariableMedicion.Image")));
            this.btnAgregarVariableMedicion.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnAgregarVariableMedicion.Location = new System.Drawing.Point(915, 198);
            this.btnAgregarVariableMedicion.Name = "btnAgregarVariableMedicion";
            this.btnAgregarVariableMedicion.Size = new System.Drawing.Size(29, 29);
            this.btnAgregarVariableMedicion.TabIndex = 101;
            this.btnAgregarVariableMedicion.Click += new System.EventHandler(this.btnAgregarVariableMedicion_Click);
            // 
            // btnEditarVariableMedicion
            // 
            this.btnEditarVariableMedicion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnEditarVariableMedicion, null);
            this.balloonTip1.SetBalloonText(this.btnEditarVariableMedicion, "Modificiar Variable");
            this.btnEditarVariableMedicion.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarVariableMedicion.Image")));
            this.btnEditarVariableMedicion.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnEditarVariableMedicion.Location = new System.Drawing.Point(950, 198);
            this.btnEditarVariableMedicion.Name = "btnEditarVariableMedicion";
            this.btnEditarVariableMedicion.Size = new System.Drawing.Size(29, 29);
            this.btnEditarVariableMedicion.TabIndex = 100;
            this.btnEditarVariableMedicion.Click += new System.EventHandler(this.btnEditarVariableMedicion_Click);
            // 
            // btnEliminarVariableMedicion
            // 
            this.btnEliminarVariableMedicion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnEliminarVariableMedicion, null);
            this.balloonTip1.SetBalloonText(this.btnEliminarVariableMedicion, "Eliminar Variable");
            this.btnEliminarVariableMedicion.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarVariableMedicion.Image")));
            this.btnEliminarVariableMedicion.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnEliminarVariableMedicion.Location = new System.Drawing.Point(985, 198);
            this.btnEliminarVariableMedicion.Name = "btnEliminarVariableMedicion";
            this.btnEliminarVariableMedicion.Size = new System.Drawing.Size(29, 29);
            this.btnEliminarVariableMedicion.TabIndex = 99;
            this.btnEliminarVariableMedicion.Click += new System.EventHandler(this.btnEliminarVariableMedicion_Click);
            // 
            // grdVariablesMedicion
            // 
            this.grdVariablesMedicion.AllowUpdate = false;
            this.grdVariablesMedicion.DataMember = "pltVariablesxOrdenServicio";
            this.grdVariablesMedicion.DataSource = this.dsPlantillas1;
            this.grdVariablesMedicion.FetchRowStyles = true;
            this.grdVariablesMedicion.Images.Add(((System.Drawing.Image)(resources.GetObject("grdVariablesMedicion.Images"))));
            this.grdVariablesMedicion.Location = new System.Drawing.Point(661, 229);
            this.grdVariablesMedicion.Name = "grdVariablesMedicion";
            this.grdVariablesMedicion.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdVariablesMedicion.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdVariablesMedicion.PreviewInfo.ZoomFactor = 75D;
            this.grdVariablesMedicion.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdVariablesMedicion.PrintInfo.PageSettings")));
            this.grdVariablesMedicion.Size = new System.Drawing.Size(353, 147);
            this.grdVariablesMedicion.TabIndex = 98;
            this.grdVariablesMedicion.Text = "c1TrueDBGrid2";
            this.grdVariablesMedicion.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.grdVariablesMedicion.FetchRowStyle += new C1.Win.C1TrueDBGrid.FetchRowStyleEventHandler(this.grdVariablesMedicion_FetchRowStyle);
            this.grdVariablesMedicion.AfterSort += new C1.Win.C1TrueDBGrid.FilterEventHandler(this.grdVariablesMedicion_AfterSort);
            this.grdVariablesMedicion.PropBag = resources.GetString("grdVariablesMedicion.PropBag");
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label25.Location = new System.Drawing.Point(658, 214);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(132, 13);
            this.label25.TabIndex = 97;
            this.label25.Text = "Variables de Medicion";
            // 
            // btnAgregarDispostivoMedicion
            // 
            this.btnAgregarDispostivoMedicion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnAgregarDispostivoMedicion, null);
            this.balloonTip1.SetBalloonText(this.btnAgregarDispostivoMedicion, "Agregar Dispositivo");
            this.btnAgregarDispostivoMedicion.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarDispostivoMedicion.Image")));
            this.btnAgregarDispostivoMedicion.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnAgregarDispostivoMedicion.Location = new System.Drawing.Point(957, 16);
            this.btnAgregarDispostivoMedicion.Name = "btnAgregarDispostivoMedicion";
            this.btnAgregarDispostivoMedicion.Size = new System.Drawing.Size(29, 29);
            this.btnAgregarDispostivoMedicion.TabIndex = 96;
            this.btnAgregarDispostivoMedicion.Tooltip = "Agregar Dispositivo";
            this.btnAgregarDispostivoMedicion.Click += new System.EventHandler(this.btnAgregarDispostivoMedicion_Click);
            // 
            // btnHojaVidaDipositivoMedicion
            // 
            this.btnHojaVidaDipositivoMedicion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnHojaVidaDipositivoMedicion, null);
            this.balloonTip1.SetBalloonText(this.btnHojaVidaDipositivoMedicion, "Hoja de vida");
            this.btnHojaVidaDipositivoMedicion.Image = ((System.Drawing.Image)(resources.GetObject("btnHojaVidaDipositivoMedicion.Image")));
            this.btnHojaVidaDipositivoMedicion.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnHojaVidaDipositivoMedicion.Location = new System.Drawing.Point(926, 16);
            this.btnHojaVidaDipositivoMedicion.Name = "btnHojaVidaDipositivoMedicion";
            this.btnHojaVidaDipositivoMedicion.Size = new System.Drawing.Size(29, 29);
            this.btnHojaVidaDipositivoMedicion.TabIndex = 95;
            this.btnHojaVidaDipositivoMedicion.Tooltip = "Hoja de vida";
            this.btnHojaVidaDipositivoMedicion.Click += new System.EventHandler(this.btnHojaVidaDipositivoMedicion_Click);
            // 
            // btnQuitarDispositivo
            // 
            this.btnQuitarDispositivo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnQuitarDispositivo, null);
            this.balloonTip1.SetBalloonText(this.btnQuitarDispositivo, "Quitar Dispositivo");
            this.btnQuitarDispositivo.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitarDispositivo.Image")));
            this.btnQuitarDispositivo.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnQuitarDispositivo.Location = new System.Drawing.Point(989, 16);
            this.btnQuitarDispositivo.Name = "btnQuitarDispositivo";
            this.btnQuitarDispositivo.Size = new System.Drawing.Size(29, 29);
            this.btnQuitarDispositivo.TabIndex = 94;
            this.btnQuitarDispositivo.Tooltip = "Quitar Dispositivo";
            this.btnQuitarDispositivo.Click += new System.EventHandler(this.btnQuitarDispositivo_Click);
            // 
            // grddispositivosMedicion
            // 
            this.grddispositivosMedicion.AllowUpdate = false;
            this.grddispositivosMedicion.DataMember = "pltDispositivosxOrden";
            this.grddispositivosMedicion.DataSource = this.dsPlantillas1;
            this.grddispositivosMedicion.Images.Add(((System.Drawing.Image)(resources.GetObject("grddispositivosMedicion.Images"))));
            this.grddispositivosMedicion.Location = new System.Drawing.Point(661, 50);
            this.grddispositivosMedicion.Name = "grddispositivosMedicion";
            this.grddispositivosMedicion.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grddispositivosMedicion.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grddispositivosMedicion.PreviewInfo.ZoomFactor = 75D;
            this.grddispositivosMedicion.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grddispositivosMedicion.PrintInfo.PageSettings")));
            this.grddispositivosMedicion.Size = new System.Drawing.Size(353, 138);
            this.grddispositivosMedicion.TabIndex = 93;
            this.grddispositivosMedicion.Text = "c1TrueDBGrid1";
            this.grddispositivosMedicion.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.grddispositivosMedicion.PropBag = resources.GetString("grddispositivosMedicion.PropBag");
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label20.Location = new System.Drawing.Point(661, 15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(143, 35);
            this.label20.TabIndex = 92;
            this.label20.Text = "Dispositivos de Medicion Utilizados";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.rdAdecuadoNo);
            this.panel1.Controls.Add(this.rdAdecuado);
            this.panel1.Location = new System.Drawing.Point(321, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 26);
            this.panel1.TabIndex = 91;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(2, 5);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(223, 13);
            this.label18.TabIndex = 88;
            this.label18.Text = "Equipo Adecuado despues del mantenimiento";
            // 
            // rdAdecuadoNo
            // 
            this.rdAdecuadoNo.AutoSize = true;
            this.rdAdecuadoNo.BackColor = System.Drawing.Color.Transparent;
            this.rdAdecuadoNo.Location = new System.Drawing.Point(283, 3);
            this.rdAdecuadoNo.Name = "rdAdecuadoNo";
            this.rdAdecuadoNo.Size = new System.Drawing.Size(39, 17);
            this.rdAdecuadoNo.TabIndex = 90;
            this.rdAdecuadoNo.TabStop = true;
            this.rdAdecuadoNo.Text = "No";
            this.rdAdecuadoNo.UseVisualStyleBackColor = false;
            // 
            // rdAdecuado
            // 
            this.rdAdecuado.AutoSize = true;
            this.rdAdecuado.BackColor = System.Drawing.Color.Transparent;
            this.rdAdecuado.Location = new System.Drawing.Point(239, 3);
            this.rdAdecuado.Name = "rdAdecuado";
            this.rdAdecuado.Size = new System.Drawing.Size(34, 17);
            this.rdAdecuado.TabIndex = 89;
            this.rdAdecuado.TabStop = true;
            this.rdAdecuado.Text = "Si";
            this.rdAdecuado.UseVisualStyleBackColor = false;
            // 
            // rdManteimientoIndicadoNo
            // 
            this.rdManteimientoIndicadoNo.AutoSize = true;
            this.rdManteimientoIndicadoNo.BackColor = System.Drawing.Color.Transparent;
            this.rdManteimientoIndicadoNo.Location = new System.Drawing.Point(604, 215);
            this.rdManteimientoIndicadoNo.Name = "rdManteimientoIndicadoNo";
            this.rdManteimientoIndicadoNo.Size = new System.Drawing.Size(39, 17);
            this.rdManteimientoIndicadoNo.TabIndex = 87;
            this.rdManteimientoIndicadoNo.TabStop = true;
            this.rdManteimientoIndicadoNo.Text = "No";
            this.rdManteimientoIndicadoNo.UseVisualStyleBackColor = false;
            // 
            // rdMantemientoIndicado
            // 
            this.rdMantemientoIndicado.AutoSize = true;
            this.rdMantemientoIndicado.BackColor = System.Drawing.Color.Transparent;
            this.rdMantemientoIndicado.Location = new System.Drawing.Point(560, 215);
            this.rdMantemientoIndicado.Name = "rdMantemientoIndicado";
            this.rdMantemientoIndicado.Size = new System.Drawing.Size(34, 17);
            this.rdMantemientoIndicado.TabIndex = 86;
            this.rdMantemientoIndicado.TabStop = true;
            this.rdMantemientoIndicado.Text = "Si";
            this.rdMantemientoIndicado.UseVisualStyleBackColor = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(323, 215);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(231, 13);
            this.label17.TabIndex = 85;
            this.label17.Text = "Mantenimiento de la maquina según lo indicado";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label14.Location = new System.Drawing.Point(11, 214);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 35);
            this.label14.TabIndex = 84;
            this.label14.Text = "Ultimo Mantenimiento por parte del usuario";
            // 
            // calMantenimientoxUsuario
            // 
            // 
            // 
            // 
            this.calMantenimientoxUsuario.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calMantenimientoxUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calMantenimientoxUsuario.ButtonDropDown.Visible = true;
            this.calMantenimientoxUsuario.Location = new System.Drawing.Point(168, 215);
            // 
            // 
            // 
            this.calMantenimientoxUsuario.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calMantenimientoxUsuario.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calMantenimientoxUsuario.MonthCalendar.BackgroundStyle.Class = "";
            this.calMantenimientoxUsuario.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calMantenimientoxUsuario.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calMantenimientoxUsuario.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calMantenimientoxUsuario.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calMantenimientoxUsuario.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calMantenimientoxUsuario.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calMantenimientoxUsuario.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calMantenimientoxUsuario.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calMantenimientoxUsuario.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calMantenimientoxUsuario.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calMantenimientoxUsuario.MonthCalendar.DisplayMonth = new System.DateTime(2008, 4, 1, 0, 0, 0, 0);
            this.calMantenimientoxUsuario.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calMantenimientoxUsuario.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calMantenimientoxUsuario.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calMantenimientoxUsuario.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calMantenimientoxUsuario.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calMantenimientoxUsuario.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calMantenimientoxUsuario.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calMantenimientoxUsuario.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calMantenimientoxUsuario.MonthCalendar.TodayButtonVisible = true;
            this.calMantenimientoxUsuario.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calMantenimientoxUsuario.Name = "calMantenimientoxUsuario";
            this.calMantenimientoxUsuario.Size = new System.Drawing.Size(111, 20);
            this.calMantenimientoxUsuario.TabIndex = 83;
            // 
            // grdRepuestos
            // 
            this.grdRepuestos.AllowUpdate = false;
            this.grdRepuestos.DataMember = "pltRepuestosxOrdenServicio";
            this.grdRepuestos.DataSource = this.dsPlantillas1;
            this.grdRepuestos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdRepuestos.Images"))));
            this.grdRepuestos.Location = new System.Drawing.Point(12, 295);
            this.grdRepuestos.Name = "grdRepuestos";
            this.grdRepuestos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdRepuestos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdRepuestos.PreviewInfo.ZoomFactor = 75D;
            this.grdRepuestos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdRepuestos.PrintInfo.PageSettings")));
            this.grdRepuestos.Size = new System.Drawing.Size(631, 98);
            this.grdRepuestos.TabIndex = 81;
            this.grdRepuestos.Text = "c1TrueDBGrid1";
            this.grdRepuestos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.grdRepuestos.PropBag = resources.GetString("grdRepuestos.PropBag");
            // 
            // btnAgregarRepuesto
            // 
            this.btnAgregarRepuesto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnAgregarRepuesto, null);
            this.balloonTip1.SetBalloonText(this.btnAgregarRepuesto, "Agregar Repuesto");
            this.btnAgregarRepuesto.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarRepuesto.Image")));
            this.btnAgregarRepuesto.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnAgregarRepuesto.Location = new System.Drawing.Point(545, 263);
            this.btnAgregarRepuesto.Name = "btnAgregarRepuesto";
            this.btnAgregarRepuesto.Size = new System.Drawing.Size(29, 29);
            this.btnAgregarRepuesto.TabIndex = 80;
            this.btnAgregarRepuesto.Click += new System.EventHandler(this.btnAgregarRepuesto_Click);
            // 
            // btnModificarRepuesto
            // 
            this.btnModificarRepuesto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnModificarRepuesto, null);
            this.balloonTip1.SetBalloonText(this.btnModificarRepuesto, "Modificiar Repuesto");
            this.btnModificarRepuesto.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarRepuesto.Image")));
            this.btnModificarRepuesto.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnModificarRepuesto.Location = new System.Drawing.Point(580, 263);
            this.btnModificarRepuesto.Name = "btnModificarRepuesto";
            this.btnModificarRepuesto.Size = new System.Drawing.Size(29, 29);
            this.btnModificarRepuesto.TabIndex = 79;
            this.btnModificarRepuesto.Click += new System.EventHandler(this.btnModificarRepuesto_Click);
            // 
            // btnQuitarRepuesto
            // 
            this.btnQuitarRepuesto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnQuitarRepuesto, null);
            this.balloonTip1.SetBalloonText(this.btnQuitarRepuesto, "Eliminar Repuesto");
            this.btnQuitarRepuesto.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitarRepuesto.Image")));
            this.btnQuitarRepuesto.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnQuitarRepuesto.Location = new System.Drawing.Point(615, 263);
            this.btnQuitarRepuesto.Name = "btnQuitarRepuesto";
            this.btnQuitarRepuesto.Size = new System.Drawing.Size(29, 29);
            this.btnQuitarRepuesto.TabIndex = 78;
            this.btnQuitarRepuesto.Click += new System.EventHandler(this.btnQuitarRepuesto_Click);
            // 
            // btnAgregarActividad
            // 
            this.btnAgregarActividad.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnAgregarActividad, null);
            this.balloonTip1.SetBalloonText(this.btnAgregarActividad, "Agregar Actividad");
            this.btnAgregarActividad.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarActividad.Image")));
            this.btnAgregarActividad.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnAgregarActividad.Location = new System.Drawing.Point(915, 382);
            this.btnAgregarActividad.Name = "btnAgregarActividad";
            this.btnAgregarActividad.Size = new System.Drawing.Size(29, 29);
            this.btnAgregarActividad.TabIndex = 77;
            this.btnAgregarActividad.Click += new System.EventHandler(this.btnAgregarActividad_Click);
            // 
            // btnModificarActividad
            // 
            this.btnModificarActividad.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnModificarActividad, null);
            this.balloonTip1.SetBalloonText(this.btnModificarActividad, "Modificiar Actividad");
            this.btnModificarActividad.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarActividad.Image")));
            this.btnModificarActividad.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnModificarActividad.Location = new System.Drawing.Point(950, 382);
            this.btnModificarActividad.Name = "btnModificarActividad";
            this.btnModificarActividad.Size = new System.Drawing.Size(29, 29);
            this.btnModificarActividad.TabIndex = 76;
            this.btnModificarActividad.Click += new System.EventHandler(this.btnModificarActividad_Click);
            // 
            // btnEliminarActividad
            // 
            this.btnEliminarActividad.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnEliminarActividad, null);
            this.balloonTip1.SetBalloonText(this.btnEliminarActividad, "Eliminar Actividad");
            this.btnEliminarActividad.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarActividad.Image")));
            this.btnEliminarActividad.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnEliminarActividad.Location = new System.Drawing.Point(985, 382);
            this.btnEliminarActividad.Name = "btnEliminarActividad";
            this.btnEliminarActividad.Size = new System.Drawing.Size(29, 29);
            this.btnEliminarActividad.TabIndex = 75;
            this.btnEliminarActividad.Click += new System.EventHandler(this.btnEliminarActividad_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label21.Location = new System.Drawing.Point(5, 276);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(126, 13);
            this.label21.TabIndex = 74;
            this.label21.Text = "Repuestos Utilizados";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label16.Location = new System.Drawing.Point(12, 399);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(139, 15);
            this.label16.TabIndex = 73;
            this.label16.Text = "Trabajos Realizados";
            // 
            // label46
            // 
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label46.Location = new System.Drawing.Point(10, 149);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(92, 32);
            this.label46.TabIndex = 72;
            this.label46.Text = "Observaciones Ingeniero";
            // 
            // txtObservacionesIngeniero
            // 
            this.txtObservacionesIngeniero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacionesIngeniero.Location = new System.Drawing.Point(105, 149);
            this.txtObservacionesIngeniero.MaxLength = 1500;
            this.txtObservacionesIngeniero.Multiline = true;
            this.txtObservacionesIngeniero.Name = "txtObservacionesIngeniero";
            this.txtObservacionesIngeniero.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacionesIngeniero.Size = new System.Drawing.Size(539, 57);
            this.txtObservacionesIngeniero.TabIndex = 71;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label45.Location = new System.Drawing.Point(11, 78);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(74, 13);
            this.label45.TabIndex = 70;
            this.label45.Text = "Diagnostico";
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnostico.Location = new System.Drawing.Point(105, 78);
            this.txtDiagnostico.MaxLength = 1500;
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDiagnostico.Size = new System.Drawing.Size(539, 65);
            this.txtDiagnostico.TabIndex = 69;
            // 
            // label44
            // 
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label44.Location = new System.Drawing.Point(11, 6);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(92, 29);
            this.label44.TabIndex = 68;
            this.label44.Text = "Fallas Reportadas";
            // 
            // txtFallasReportadas
            // 
            this.txtFallasReportadas.AcceptsReturn = true;
            this.txtFallasReportadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFallasReportadas.Location = new System.Drawing.Point(105, 7);
            this.txtFallasReportadas.MaxLength = 1500;
            this.txtFallasReportadas.Multiline = true;
            this.txtFallasReportadas.Name = "txtFallasReportadas";
            this.txtFallasReportadas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFallasReportadas.Size = new System.Drawing.Size(539, 65);
            this.txtFallasReportadas.TabIndex = 67;
            // 
            // grdActividades
            // 
            this.grdActividades.AllowUpdate = false;
            this.grdActividades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdActividades.DataMember = "actividadxordenServicio";
            this.grdActividades.DataSource = this.dsSpx1;
            this.grdActividades.Images.Add(((System.Drawing.Image)(resources.GetObject("grdActividades.Images"))));
            this.grdActividades.Location = new System.Drawing.Point(14, 417);
            this.grdActividades.Name = "grdActividades";
            this.grdActividades.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdActividades.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdActividades.PreviewInfo.ZoomFactor = 75D;
            this.grdActividades.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdActividades.PrintInfo.PageSettings")));
            this.grdActividades.RowHeight = 51;
            this.grdActividades.Size = new System.Drawing.Size(1000, 215);
            this.grdActividades.TabIndex = 8;
            this.grdActividades.Text = "c1TrueDBGrid1";
            this.grdActividades.PropBag = resources.GetString("grdActividades.PropBag");
            // 
            // c1CmbIng
            // 
            this.c1CmbIng.AllowColMove = true;
            this.c1CmbIng.AllowColSelect = true;
            this.c1CmbIng.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows;
            this.c1CmbIng.AlternatingRows = false;
            this.c1CmbIng.CaptionStyle = style1;
            this.c1CmbIng.ColumnCaptionHeight = 17;
            this.c1CmbIng.ColumnFooterHeight = 17;
            this.c1CmbIng.ColumnHeaders = false;
            this.c1CmbIng.DisplayMember = "usuarios.nombre";
            this.c1CmbIng.EvenRowStyle = style2;
            this.c1CmbIng.FetchRowStyles = false;
            this.c1CmbIng.FooterStyle = style3;
            this.c1CmbIng.HeadingStyle = style4;
            this.c1CmbIng.HighLightRowStyle = style5;
            this.c1CmbIng.Images.Add(((System.Drawing.Image)(resources.GetObject("c1CmbIng.Images"))));
            this.c1CmbIng.Location = new System.Drawing.Point(469, 465);
            this.c1CmbIng.Name = "c1CmbIng";
            this.c1CmbIng.OddRowStyle = style6;
            this.c1CmbIng.RecordSelectorStyle = style7;
            this.c1CmbIng.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.c1CmbIng.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
            this.c1CmbIng.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1CmbIng.ScrollTips = false;
            this.c1CmbIng.Size = new System.Drawing.Size(129, 77);
            this.c1CmbIng.Style = style8;
            this.c1CmbIng.TabIndex = 9;
            this.c1CmbIng.TabStop = false;
            this.c1CmbIng.Text = "c1TrueDBDropdown1";
            this.c1CmbIng.ValueMember = "usuarios.login";
            this.c1CmbIng.ValueTranslate = true;
            this.c1CmbIng.Visible = false;
            this.c1CmbIng.PropBag = resources.GetString("c1CmbIng.PropBag");
            // 
            // tabItem8
            // 
            this.tabItem8.AttachedControl = this.tabControlPanel8;
            this.tabItem8.Name = "tabItem8";
            this.tabItem8.Text = "Actividades Realizadas";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.groupBox6);
            this.tabControlPanel2.Controls.Add(this.groupPanel1);
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(1026, 645);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 2;
            this.tabControlPanel2.TabItem = this.tabItem2;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.calFechaFinProgramacionIA);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.calFechaCreacion);
            this.groupBox6.Controls.Add(this.calCierre);
            this.groupBox6.Controls.Add(this.label37);
            this.groupBox6.Controls.Add(this.calFechaProgramacionIA);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label29);
            this.groupBox6.Controls.Add(this.calAprobacion);
            this.groupBox6.Controls.Add(this.txtAnuladaPor);
            this.groupBox6.Controls.Add(this.label31);
            this.groupBox6.Controls.Add(this.txtAprobadaPor);
            this.groupBox6.Controls.Add(this.calAnulacion);
            this.groupBox6.Controls.Add(this.txtCerradaPor);
            this.groupBox6.Controls.Add(this.label32);
            this.groupBox6.Controls.Add(this.label36);
            this.groupBox6.Controls.Add(this.txtCreadaPor);
            this.groupBox6.Controls.Add(this.label39);
            this.groupBox6.Controls.Add(this.label33);
            this.groupBox6.Controls.Add(this.label40);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(84, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(826, 155);
            this.groupBox6.TabIndex = 84;
            this.groupBox6.TabStop = false;
            // 
            // calFechaFinProgramacionIA
            // 
            // 
            // 
            // 
            this.calFechaFinProgramacionIA.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calFechaFinProgramacionIA.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaFinProgramacionIA.ButtonDropDown.Visible = true;
            this.calFechaFinProgramacionIA.Enabled = false;
            this.calFechaFinProgramacionIA.Location = new System.Drawing.Point(540, 39);
            // 
            // 
            // 
            this.calFechaFinProgramacionIA.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFechaFinProgramacionIA.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calFechaFinProgramacionIA.MonthCalendar.BackgroundStyle.Class = "";
            this.calFechaFinProgramacionIA.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaFinProgramacionIA.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calFechaFinProgramacionIA.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calFechaFinProgramacionIA.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calFechaFinProgramacionIA.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calFechaFinProgramacionIA.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calFechaFinProgramacionIA.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calFechaFinProgramacionIA.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calFechaFinProgramacionIA.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calFechaFinProgramacionIA.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaFinProgramacionIA.MonthCalendar.DisplayMonth = new System.DateTime(2008, 4, 1, 0, 0, 0, 0);
            this.calFechaFinProgramacionIA.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calFechaFinProgramacionIA.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calFechaFinProgramacionIA.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFechaFinProgramacionIA.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calFechaFinProgramacionIA.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calFechaFinProgramacionIA.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calFechaFinProgramacionIA.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calFechaFinProgramacionIA.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaFinProgramacionIA.MonthCalendar.TodayButtonVisible = true;
            this.calFechaFinProgramacionIA.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calFechaFinProgramacionIA.Name = "calFechaFinProgramacionIA";
            this.calFechaFinProgramacionIA.Size = new System.Drawing.Size(200, 21);
            this.calFechaFinProgramacionIA.TabIndex = 83;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(370, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 19);
            this.label11.TabIndex = 84;
            this.label11.Text = "Fecha Tentativa Fin Ejecutivo";
            // 
            // calFechaCreacion
            // 
            // 
            // 
            // 
            this.calFechaCreacion.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calFechaCreacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaCreacion.ButtonDropDown.Visible = true;
            this.calFechaCreacion.Enabled = false;
            this.calFechaCreacion.Location = new System.Drawing.Point(164, 15);
            // 
            // 
            // 
            this.calFechaCreacion.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFechaCreacion.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calFechaCreacion.MonthCalendar.BackgroundStyle.Class = "";
            this.calFechaCreacion.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaCreacion.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calFechaCreacion.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calFechaCreacion.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calFechaCreacion.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calFechaCreacion.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calFechaCreacion.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calFechaCreacion.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calFechaCreacion.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calFechaCreacion.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaCreacion.MonthCalendar.DisplayMonth = new System.DateTime(2008, 4, 1, 0, 0, 0, 0);
            this.calFechaCreacion.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calFechaCreacion.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calFechaCreacion.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFechaCreacion.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calFechaCreacion.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calFechaCreacion.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calFechaCreacion.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calFechaCreacion.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaCreacion.MonthCalendar.TodayButtonVisible = true;
            this.calFechaCreacion.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calFechaCreacion.Name = "calFechaCreacion";
            this.calFechaCreacion.Size = new System.Drawing.Size(185, 21);
            this.calFechaCreacion.TabIndex = 79;
            // 
            // calCierre
            // 
            // 
            // 
            // 
            this.calCierre.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calCierre.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calCierre.ButtonDropDown.Visible = true;
            this.calCierre.Enabled = false;
            this.calCierre.Location = new System.Drawing.Point(164, 72);
            // 
            // 
            // 
            this.calCierre.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calCierre.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calCierre.MonthCalendar.BackgroundStyle.Class = "";
            this.calCierre.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calCierre.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calCierre.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calCierre.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calCierre.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calCierre.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calCierre.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calCierre.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calCierre.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calCierre.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calCierre.MonthCalendar.DisplayMonth = new System.DateTime(2008, 4, 1, 0, 0, 0, 0);
            this.calCierre.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calCierre.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calCierre.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calCierre.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calCierre.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calCierre.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calCierre.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calCierre.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calCierre.MonthCalendar.TodayButtonVisible = true;
            this.calCierre.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calCierre.Name = "calCierre";
            this.calCierre.Size = new System.Drawing.Size(185, 21);
            this.calCierre.TabIndex = 55;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.Location = new System.Drawing.Point(10, 46);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(150, 15);
            this.label37.TabIndex = 82;
            this.label37.Text = "Fecha Tentativa Ejecucion";
            // 
            // calFechaProgramacionIA
            // 
            // 
            // 
            // 
            this.calFechaProgramacionIA.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calFechaProgramacionIA.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaProgramacionIA.ButtonDropDown.Visible = true;
            this.calFechaProgramacionIA.Enabled = false;
            this.calFechaProgramacionIA.Location = new System.Drawing.Point(164, 44);
            // 
            // 
            // 
            this.calFechaProgramacionIA.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFechaProgramacionIA.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calFechaProgramacionIA.MonthCalendar.BackgroundStyle.Class = "";
            this.calFechaProgramacionIA.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaProgramacionIA.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calFechaProgramacionIA.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calFechaProgramacionIA.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calFechaProgramacionIA.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calFechaProgramacionIA.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calFechaProgramacionIA.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calFechaProgramacionIA.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calFechaProgramacionIA.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calFechaProgramacionIA.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaProgramacionIA.MonthCalendar.DisplayMonth = new System.DateTime(2008, 4, 1, 0, 0, 0, 0);
            this.calFechaProgramacionIA.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calFechaProgramacionIA.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calFechaProgramacionIA.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFechaProgramacionIA.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calFechaProgramacionIA.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calFechaProgramacionIA.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calFechaProgramacionIA.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calFechaProgramacionIA.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaProgramacionIA.MonthCalendar.TodayButtonVisible = true;
            this.calFechaProgramacionIA.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calFechaProgramacionIA.Name = "calFechaProgramacionIA";
            this.calFechaProgramacionIA.Size = new System.Drawing.Size(185, 21);
            this.calFechaProgramacionIA.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(10, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 80;
            this.label2.Text = "Fecha Creacion";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Location = new System.Drawing.Point(10, 74);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(77, 15);
            this.label29.TabIndex = 57;
            this.label29.Text = "Fecha Cierre";
            // 
            // calAprobacion
            // 
            // 
            // 
            // 
            this.calAprobacion.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calAprobacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calAprobacion.ButtonDropDown.Visible = true;
            this.calAprobacion.Enabled = false;
            this.calAprobacion.Location = new System.Drawing.Point(164, 100);
            // 
            // 
            // 
            this.calAprobacion.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calAprobacion.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calAprobacion.MonthCalendar.BackgroundStyle.Class = "";
            this.calAprobacion.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calAprobacion.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calAprobacion.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calAprobacion.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calAprobacion.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calAprobacion.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calAprobacion.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calAprobacion.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calAprobacion.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calAprobacion.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calAprobacion.MonthCalendar.DisplayMonth = new System.DateTime(2008, 4, 1, 0, 0, 0, 0);
            this.calAprobacion.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calAprobacion.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calAprobacion.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calAprobacion.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calAprobacion.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calAprobacion.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calAprobacion.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calAprobacion.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calAprobacion.MonthCalendar.TodayButtonVisible = true;
            this.calAprobacion.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calAprobacion.Name = "calAprobacion";
            this.calAprobacion.Size = new System.Drawing.Size(185, 21);
            this.calAprobacion.TabIndex = 58;
            // 
            // txtAnuladaPor
            // 
            this.txtAnuladaPor.Location = new System.Drawing.Point(540, 126);
            this.txtAnuladaPor.Name = "txtAnuladaPor";
            this.txtAnuladaPor.ReadOnly = true;
            this.txtAnuladaPor.Size = new System.Drawing.Size(273, 21);
            this.txtAnuladaPor.TabIndex = 75;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Location = new System.Drawing.Point(10, 102);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(106, 15);
            this.label31.TabIndex = 59;
            this.label31.Text = "Fecha Aprobacion";
            // 
            // txtAprobadaPor
            // 
            this.txtAprobadaPor.Location = new System.Drawing.Point(540, 98);
            this.txtAprobadaPor.Name = "txtAprobadaPor";
            this.txtAprobadaPor.ReadOnly = true;
            this.txtAprobadaPor.Size = new System.Drawing.Size(273, 21);
            this.txtAprobadaPor.TabIndex = 74;
            // 
            // calAnulacion
            // 
            // 
            // 
            // 
            this.calAnulacion.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calAnulacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calAnulacion.ButtonDropDown.Visible = true;
            this.calAnulacion.Enabled = false;
            this.calAnulacion.Location = new System.Drawing.Point(165, 128);
            // 
            // 
            // 
            this.calAnulacion.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calAnulacion.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calAnulacion.MonthCalendar.BackgroundStyle.Class = "";
            this.calAnulacion.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calAnulacion.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calAnulacion.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calAnulacion.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calAnulacion.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calAnulacion.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calAnulacion.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calAnulacion.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calAnulacion.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calAnulacion.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calAnulacion.MonthCalendar.DisplayMonth = new System.DateTime(2008, 4, 1, 0, 0, 0, 0);
            this.calAnulacion.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calAnulacion.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calAnulacion.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calAnulacion.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calAnulacion.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calAnulacion.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calAnulacion.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calAnulacion.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calAnulacion.MonthCalendar.TodayButtonVisible = true;
            this.calAnulacion.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calAnulacion.Name = "calAnulacion";
            this.calAnulacion.Size = new System.Drawing.Size(185, 21);
            this.calAnulacion.TabIndex = 60;
            // 
            // txtCerradaPor
            // 
            this.txtCerradaPor.Location = new System.Drawing.Point(540, 70);
            this.txtCerradaPor.Name = "txtCerradaPor";
            this.txtCerradaPor.ReadOnly = true;
            this.txtCerradaPor.Size = new System.Drawing.Size(273, 21);
            this.txtCerradaPor.TabIndex = 73;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Location = new System.Drawing.Point(11, 130);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(98, 15);
            this.label32.TabIndex = 61;
            this.label32.Text = "Fecha Anulacion";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Location = new System.Drawing.Point(370, 16);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(69, 15);
            this.label36.TabIndex = 62;
            this.label36.Text = "Creada Por";
            // 
            // txtCreadaPor
            // 
            this.txtCreadaPor.Location = new System.Drawing.Point(540, 13);
            this.txtCreadaPor.Name = "txtCreadaPor";
            this.txtCreadaPor.ReadOnly = true;
            this.txtCreadaPor.Size = new System.Drawing.Size(273, 21);
            this.txtCreadaPor.TabIndex = 70;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.Transparent;
            this.label39.Location = new System.Drawing.Point(370, 131);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(74, 15);
            this.label39.TabIndex = 67;
            this.label39.Text = "Anulada Por";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Location = new System.Drawing.Point(370, 75);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(73, 15);
            this.label33.TabIndex = 65;
            this.label33.Text = "Cerrada Por";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label40.Location = new System.Drawing.Point(370, 103);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(82, 15);
            this.label40.TabIndex = 66;
            this.label40.Text = "Aprobada Por";
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnReasignar);
            this.groupPanel1.Controls.Add(this.grdAsignaciones);
            this.groupPanel1.Location = new System.Drawing.Point(12, 214);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(991, 422);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.Class = "";
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.Class = "";
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.Class = "";
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 83;
            this.groupPanel1.Text = "Historial de Asignaciones";
            // 
            // btnReasignar
            // 
            this.btnReasignar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReasignar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReasignar.Enabled = false;
            this.btnReasignar.Image = ((System.Drawing.Image)(resources.GetObject("btnReasignar.Image")));
            this.btnReasignar.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnReasignar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnReasignar.Location = new System.Drawing.Point(892, 17);
            this.btnReasignar.Name = "btnReasignar";
            this.btnReasignar.Size = new System.Drawing.Size(70, 48);
            this.btnReasignar.TabIndex = 30;
            this.btnReasignar.Text = "Reasignar";
            this.btnReasignar.Click += new System.EventHandler(this.btnReasignar_Click);
            // 
            // grdAsignaciones
            // 
            this.grdAsignaciones.AllowUpdate = false;
            this.grdAsignaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdAsignaciones.DataMember = "reasignacionOrdenesTrabajo";
            this.grdAsignaciones.DataSource = this.dsSpx1;
            this.grdAsignaciones.Images.Add(((System.Drawing.Image)(resources.GetObject("grdAsignaciones.Images"))));
            this.grdAsignaciones.Location = new System.Drawing.Point(6, 17);
            this.grdAsignaciones.Name = "grdAsignaciones";
            this.grdAsignaciones.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdAsignaciones.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdAsignaciones.PreviewInfo.ZoomFactor = 75D;
            this.grdAsignaciones.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdAsignaciones.PrintInfo.PageSettings")));
            this.grdAsignaciones.Size = new System.Drawing.Size(876, 382);
            this.grdAsignaciones.TabIndex = 0;
            this.grdAsignaciones.Text = "c1TrueDBGrid1";
            this.grdAsignaciones.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.grdAsignaciones.PropBag = resources.GetString("grdAsignaciones.PropBag");
            // 
            // tabItem2
            // 
            this.tabItem2.AttachedControl = this.tabControlPanel2;
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.Text = "Informacion Adicional";
            // 
            // tabControlPanel3
            // 
            this.tabControlPanel3.Controls.Add(this.btnVerArchivo);
            this.tabControlPanel3.Controls.Add(this.btnSubirArchivo);
            this.tabControlPanel3.Controls.Add(this.btnGuardarArchivo);
            this.tabControlPanel3.Controls.Add(this.btnQuitarArchivo);
            this.tabControlPanel3.Controls.Add(this.grdArchivos);
            this.tabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel3.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel3.Name = "tabControlPanel3";
            this.tabControlPanel3.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel3.Size = new System.Drawing.Size(1026, 645);
            this.tabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel3.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel3.Style.GradientAngle = 90;
            this.tabControlPanel3.TabIndex = 3;
            this.tabControlPanel3.TabItem = this.tabItem3;
            // 
            // btnVerArchivo
            // 
            this.btnVerArchivo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnVerArchivo, "Ver Archivo");
            this.balloonTip1.SetBalloonText(this.btnVerArchivo, null);
            this.btnVerArchivo.Image = ((System.Drawing.Image)(resources.GetObject("btnVerArchivo.Image")));
            this.btnVerArchivo.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnVerArchivo.Location = new System.Drawing.Point(18, 71);
            this.btnVerArchivo.Name = "btnVerArchivo";
            this.btnVerArchivo.Size = new System.Drawing.Size(33, 33);
            this.btnVerArchivo.TabIndex = 86;
            this.btnVerArchivo.Click += new System.EventHandler(this.btnVerArchivo_Click);
            // 
            // btnSubirArchivo
            // 
            this.btnSubirArchivo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnSubirArchivo, "Subir Archivo");
            this.balloonTip1.SetBalloonText(this.btnSubirArchivo, null);
            this.btnSubirArchivo.Image = ((System.Drawing.Image)(resources.GetObject("btnSubirArchivo.Image")));
            this.btnSubirArchivo.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnSubirArchivo.Location = new System.Drawing.Point(18, 30);
            this.btnSubirArchivo.Name = "btnSubirArchivo";
            this.btnSubirArchivo.Size = new System.Drawing.Size(33, 33);
            this.btnSubirArchivo.TabIndex = 85;
            this.btnSubirArchivo.Click += new System.EventHandler(this.btnSubirArchivo_Click);
            // 
            // btnGuardarArchivo
            // 
            this.btnGuardarArchivo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnGuardarArchivo, "Guardar Archivo");
            this.balloonTip1.SetBalloonText(this.btnGuardarArchivo, null);
            this.btnGuardarArchivo.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarArchivo.Image")));
            this.btnGuardarArchivo.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnGuardarArchivo.Location = new System.Drawing.Point(18, 112);
            this.btnGuardarArchivo.Name = "btnGuardarArchivo";
            this.btnGuardarArchivo.Size = new System.Drawing.Size(33, 33);
            this.btnGuardarArchivo.TabIndex = 84;
            this.btnGuardarArchivo.Click += new System.EventHandler(this.btnGuardarArchivo_Click);
            // 
            // btnQuitarArchivo
            // 
            this.btnQuitarArchivo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnQuitarArchivo, "Eliminar Archivo");
            this.balloonTip1.SetBalloonText(this.btnQuitarArchivo, null);
            this.btnQuitarArchivo.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitarArchivo.Image")));
            this.btnQuitarArchivo.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnQuitarArchivo.Location = new System.Drawing.Point(18, 153);
            this.btnQuitarArchivo.Name = "btnQuitarArchivo";
            this.btnQuitarArchivo.Size = new System.Drawing.Size(33, 33);
            this.btnQuitarArchivo.TabIndex = 83;
            this.btnQuitarArchivo.Click += new System.EventHandler(this.btnQuitarArchivo_Click);
            // 
            // grdArchivos
            // 
            this.grdArchivos.AllowUpdate = false;
            this.grdArchivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdArchivos.DataMember = "archivosXOrdenServicio";
            this.grdArchivos.DataSource = this.dsSpx1;
            this.grdArchivos.FilterBar = true;
            this.grdArchivos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdArchivos.Images"))));
            this.grdArchivos.Location = new System.Drawing.Point(71, 28);
            this.grdArchivos.Name = "grdArchivos";
            this.grdArchivos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdArchivos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdArchivos.PreviewInfo.ZoomFactor = 75D;
            this.grdArchivos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdArchivos.PrintInfo.PageSettings")));
            this.grdArchivos.Size = new System.Drawing.Size(905, 579);
            this.grdArchivos.TabIndex = 24;
            this.grdArchivos.Text = "c1TrueDBGrid1";
            this.grdArchivos.PropBag = resources.GetString("grdArchivos.PropBag");
            // 
            // tabItem3
            // 
            this.tabItem3.AttachedControl = this.tabControlPanel3;
            this.tabItem3.Name = "tabItem3";
            this.tabItem3.Text = "Archivos Asociados";
            // 
            // tabControlPanel7
            // 
            this.tabControlPanel7.Controls.Add(this.btnImprimirOrdenPrestamo);
            this.tabControlPanel7.Controls.Add(this.btnActualizarOrdenPrestamo);
            this.tabControlPanel7.Controls.Add(this.btnSolicitarOrdenPrestamo);
            this.tabControlPanel7.Controls.Add(this.btnModificarOrdenPrestamo);
            this.tabControlPanel7.Controls.Add(this.btnEliminarOrdenPrestamo);
            this.tabControlPanel7.Controls.Add(this.grdOrdenPrestamo);
            this.tabControlPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel7.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel7.Name = "tabControlPanel7";
            this.tabControlPanel7.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel7.Size = new System.Drawing.Size(1026, 645);
            this.tabControlPanel7.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel7.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel7.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel7.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel7.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel7.Style.GradientAngle = 90;
            this.tabControlPanel7.TabIndex = 7;
            this.tabControlPanel7.TabItem = this.tabItem7;
            // 
            // btnImprimirOrdenPrestamo
            // 
            this.btnImprimirOrdenPrestamo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnImprimirOrdenPrestamo, "Imprimir Orden de Prestamo");
            this.btnImprimirOrdenPrestamo.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimirOrdenPrestamo.Image")));
            this.btnImprimirOrdenPrestamo.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnImprimirOrdenPrestamo.Location = new System.Drawing.Point(8, 15);
            this.btnImprimirOrdenPrestamo.Name = "btnImprimirOrdenPrestamo";
            this.btnImprimirOrdenPrestamo.Size = new System.Drawing.Size(33, 33);
            this.btnImprimirOrdenPrestamo.TabIndex = 83;
            this.btnImprimirOrdenPrestamo.Click += new System.EventHandler(this.btnImprimirOrdenPrestamo_Click);
            // 
            // btnActualizarOrdenPrestamo
            // 
            this.btnActualizarOrdenPrestamo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnActualizarOrdenPrestamo, "Actualizar");
            this.btnActualizarOrdenPrestamo.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarOrdenPrestamo.Image")));
            this.btnActualizarOrdenPrestamo.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnActualizarOrdenPrestamo.Location = new System.Drawing.Point(866, 15);
            this.btnActualizarOrdenPrestamo.Name = "btnActualizarOrdenPrestamo";
            this.btnActualizarOrdenPrestamo.Size = new System.Drawing.Size(33, 33);
            this.btnActualizarOrdenPrestamo.TabIndex = 82;
            this.btnActualizarOrdenPrestamo.Click += new System.EventHandler(this.btnActualizarOrdenPrestamo_Click);
            // 
            // btnSolicitarOrdenPrestamo
            // 
            this.btnSolicitarOrdenPrestamo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnSolicitarOrdenPrestamo, "Solicitar Orden de Prestamo");
            this.btnSolicitarOrdenPrestamo.Image = ((System.Drawing.Image)(resources.GetObject("btnSolicitarOrdenPrestamo.Image")));
            this.btnSolicitarOrdenPrestamo.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnSolicitarOrdenPrestamo.Location = new System.Drawing.Point(901, 15);
            this.btnSolicitarOrdenPrestamo.Name = "btnSolicitarOrdenPrestamo";
            this.btnSolicitarOrdenPrestamo.Size = new System.Drawing.Size(33, 33);
            this.btnSolicitarOrdenPrestamo.TabIndex = 81;
            this.btnSolicitarOrdenPrestamo.Click += new System.EventHandler(this.btnSolicitarOrdenPrestamo_Click);
            // 
            // btnModificarOrdenPrestamo
            // 
            this.btnModificarOrdenPrestamo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnModificarOrdenPrestamo, "Modificar Orden de Prestamo");
            this.btnModificarOrdenPrestamo.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarOrdenPrestamo.Image")));
            this.btnModificarOrdenPrestamo.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnModificarOrdenPrestamo.Location = new System.Drawing.Point(936, 15);
            this.btnModificarOrdenPrestamo.Name = "btnModificarOrdenPrestamo";
            this.btnModificarOrdenPrestamo.Size = new System.Drawing.Size(33, 33);
            this.btnModificarOrdenPrestamo.TabIndex = 80;
            this.btnModificarOrdenPrestamo.Click += new System.EventHandler(this.btnModificarOrdenPrestamo_Click);
            // 
            // btnEliminarOrdenPrestamo
            // 
            this.btnEliminarOrdenPrestamo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnEliminarOrdenPrestamo, "Anular Orden de Prestamo");
            this.btnEliminarOrdenPrestamo.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarOrdenPrestamo.Image")));
            this.btnEliminarOrdenPrestamo.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnEliminarOrdenPrestamo.Location = new System.Drawing.Point(971, 15);
            this.btnEliminarOrdenPrestamo.Name = "btnEliminarOrdenPrestamo";
            this.btnEliminarOrdenPrestamo.Size = new System.Drawing.Size(33, 33);
            this.btnEliminarOrdenPrestamo.TabIndex = 79;
            this.btnEliminarOrdenPrestamo.Click += new System.EventHandler(this.btnEliminarOrdenPrestamo_Click);
            // 
            // grdOrdenPrestamo
            // 
            this.grdOrdenPrestamo.AllowUpdate = false;
            this.grdOrdenPrestamo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdOrdenPrestamo.DataMember = "pltOrdenPrestamo";
            this.grdOrdenPrestamo.DataSource = this.dsPlantillas1;
            this.grdOrdenPrestamo.FilterBar = true;
            this.grdOrdenPrestamo.GroupByCaption = "";
            this.grdOrdenPrestamo.Images.Add(((System.Drawing.Image)(resources.GetObject("grdOrdenPrestamo.Images"))));
            this.grdOrdenPrestamo.Location = new System.Drawing.Point(8, 57);
            this.grdOrdenPrestamo.Name = "grdOrdenPrestamo";
            this.grdOrdenPrestamo.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdOrdenPrestamo.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdOrdenPrestamo.PreviewInfo.ZoomFactor = 75D;
            this.grdOrdenPrestamo.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdOrdenPrestamo.PrintInfo.PageSettings")));
            this.grdOrdenPrestamo.Size = new System.Drawing.Size(1006, 583);
            this.grdOrdenPrestamo.TabIndex = 39;
            this.grdOrdenPrestamo.Text = "c1TrueDBGrid1";
            this.grdOrdenPrestamo.PropBag = resources.GetString("grdOrdenPrestamo.PropBag");
            // 
            // tabItem7
            // 
            this.tabItem7.AttachedControl = this.tabControlPanel7;
            this.tabItem7.Name = "tabItem7";
            this.tabItem7.Text = "Ordenes de Prestamo";
            // 
            // tabControlPanel5
            // 
            this.tabControlPanel5.Controls.Add(this.grpInformacionCliente);
            this.tabControlPanel5.Controls.Add(this.btnQuitarComprobante);
            this.tabControlPanel5.Controls.Add(this.btnAgregarComprobante);
            this.tabControlPanel5.Controls.Add(this.btnGuardarComprobante);
            this.tabControlPanel5.Controls.Add(this.btnVerComprobante);
            this.tabControlPanel5.Controls.Add(this.grdComprobantes);
            this.tabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel5.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel5.Name = "tabControlPanel5";
            this.tabControlPanel5.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel5.Size = new System.Drawing.Size(1026, 645);
            this.tabControlPanel5.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel5.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel5.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel5.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel5.Style.GradientAngle = 90;
            this.tabControlPanel5.TabIndex = 5;
            this.tabControlPanel5.TabItem = this.tabItem5;
            // 
            // grpInformacionCliente
            // 
            this.grpInformacionCliente.BackColor = System.Drawing.Color.Transparent;
            this.grpInformacionCliente.CanvasColor = System.Drawing.SystemColors.Control;
            this.grpInformacionCliente.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.grpInformacionCliente.Controls.Add(this.btnCambiarInformacionAceptacionCliente);
            this.grpInformacionCliente.Controls.Add(this.cmbAmPMSalidaCliente);
            this.grpInformacionCliente.Controls.Add(this.cmbMinSalidaCliente);
            this.grpInformacionCliente.Controls.Add(this.label38);
            this.grpInformacionCliente.Controls.Add(this.cmbHoraSalidaCliente);
            this.grpInformacionCliente.Controls.Add(this.txtUsuarioCliente);
            this.grpInformacionCliente.Controls.Add(this.label41);
            this.grpInformacionCliente.Controls.Add(this.label42);
            this.grpInformacionCliente.Controls.Add(this.cmbAmPmLlegadaCliente);
            this.grpInformacionCliente.Controls.Add(this.cmbHoraLlegadaCliente);
            this.grpInformacionCliente.Controls.Add(this.cmbMinutosLlegadaCliente);
            this.grpInformacionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInformacionCliente.Location = new System.Drawing.Point(12, 11);
            this.grpInformacionCliente.Name = "grpInformacionCliente";
            this.grpInformacionCliente.Size = new System.Drawing.Size(881, 100);
            // 
            // 
            // 
            this.grpInformacionCliente.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.grpInformacionCliente.Style.BackColorGradientAngle = 90;
            this.grpInformacionCliente.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.grpInformacionCliente.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpInformacionCliente.Style.BorderBottomWidth = 1;
            this.grpInformacionCliente.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.grpInformacionCliente.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpInformacionCliente.Style.BorderLeftWidth = 1;
            this.grpInformacionCliente.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpInformacionCliente.Style.BorderRightWidth = 1;
            this.grpInformacionCliente.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpInformacionCliente.Style.BorderTopWidth = 1;
            this.grpInformacionCliente.Style.Class = "";
            this.grpInformacionCliente.Style.CornerDiameter = 4;
            this.grpInformacionCliente.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grpInformacionCliente.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.grpInformacionCliente.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grpInformacionCliente.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.grpInformacionCliente.StyleMouseDown.Class = "";
            this.grpInformacionCliente.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.grpInformacionCliente.StyleMouseOver.Class = "";
            this.grpInformacionCliente.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.grpInformacionCliente.TabIndex = 95;
            this.grpInformacionCliente.Text = "Informacion del Cliente";
            // 
            // btnCambiarInformacionAceptacionCliente
            // 
            this.btnCambiarInformacionAceptacionCliente.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnCambiarInformacionAceptacionCliente, null);
            this.balloonTip1.SetBalloonText(this.btnCambiarInformacionAceptacionCliente, "Cambiar Informacion de Aceptacion del Cliente");
            this.btnCambiarInformacionAceptacionCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCambiarInformacionAceptacionCliente.Image")));
            this.btnCambiarInformacionAceptacionCliente.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btnCambiarInformacionAceptacionCliente.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCambiarInformacionAceptacionCliente.Location = new System.Drawing.Point(718, 5);
            this.btnCambiarInformacionAceptacionCliente.Name = "btnCambiarInformacionAceptacionCliente";
            this.btnCambiarInformacionAceptacionCliente.Size = new System.Drawing.Size(72, 57);
            this.btnCambiarInformacionAceptacionCliente.TabIndex = 30;
            this.btnCambiarInformacionAceptacionCliente.Click += new System.EventHandler(this.btnCambiarInformacionAceptacionCliente_Click);
            // 
            // cmbAmPMSalidaCliente
            // 
            this.cmbAmPMSalidaCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAmPMSalidaCliente.Enabled = false;
            this.cmbAmPMSalidaCliente.FormattingEnabled = true;
            this.cmbAmPMSalidaCliente.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cmbAmPMSalidaCliente.Location = new System.Drawing.Point(646, 40);
            this.cmbAmPMSalidaCliente.Name = "cmbAmPMSalidaCliente";
            this.cmbAmPMSalidaCliente.Size = new System.Drawing.Size(51, 23);
            this.cmbAmPMSalidaCliente.TabIndex = 91;
            // 
            // cmbMinSalidaCliente
            // 
            this.cmbMinSalidaCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMinSalidaCliente.Enabled = false;
            this.cmbMinSalidaCliente.FormattingEnabled = true;
            this.cmbMinSalidaCliente.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmbMinSalidaCliente.Location = new System.Drawing.Point(589, 40);
            this.cmbMinSalidaCliente.Name = "cmbMinSalidaCliente";
            this.cmbMinSalidaCliente.Size = new System.Drawing.Size(51, 23);
            this.cmbMinSalidaCliente.TabIndex = 90;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(3, 5);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(179, 13);
            this.label38.TabIndex = 84;
            this.label38.Text = "Nombre de Usuario del Cliente";
            // 
            // cmbHoraSalidaCliente
            // 
            this.cmbHoraSalidaCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoraSalidaCliente.Enabled = false;
            this.cmbHoraSalidaCliente.FormattingEnabled = true;
            this.cmbHoraSalidaCliente.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbHoraSalidaCliente.Location = new System.Drawing.Point(532, 40);
            this.cmbHoraSalidaCliente.Name = "cmbHoraSalidaCliente";
            this.cmbHoraSalidaCliente.Size = new System.Drawing.Size(51, 23);
            this.cmbHoraSalidaCliente.TabIndex = 89;
            // 
            // txtUsuarioCliente
            // 
            this.txtUsuarioCliente.Location = new System.Drawing.Point(3, 25);
            this.txtUsuarioCliente.Name = "txtUsuarioCliente";
            this.txtUsuarioCliente.ReadOnly = true;
            this.txtUsuarioCliente.Size = new System.Drawing.Size(323, 21);
            this.txtUsuarioCliente.TabIndex = 85;
            // 
            // label41
            // 
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.Location = new System.Drawing.Point(363, 40);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(155, 21);
            this.label41.TabIndex = 93;
            this.label41.Text = "Hora Salida donde el Cliente";
            // 
            // label42
            // 
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Location = new System.Drawing.Point(363, 8);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(155, 20);
            this.label42.TabIndex = 92;
            this.label42.Text = "Hora Llegada donde el Cliente";
            // 
            // cmbAmPmLlegadaCliente
            // 
            this.cmbAmPmLlegadaCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAmPmLlegadaCliente.Enabled = false;
            this.cmbAmPmLlegadaCliente.FormattingEnabled = true;
            this.cmbAmPmLlegadaCliente.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cmbAmPmLlegadaCliente.Location = new System.Drawing.Point(646, 8);
            this.cmbAmPmLlegadaCliente.Name = "cmbAmPmLlegadaCliente";
            this.cmbAmPmLlegadaCliente.Size = new System.Drawing.Size(51, 23);
            this.cmbAmPmLlegadaCliente.TabIndex = 88;
            // 
            // cmbHoraLlegadaCliente
            // 
            this.cmbHoraLlegadaCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoraLlegadaCliente.Enabled = false;
            this.cmbHoraLlegadaCliente.FormattingEnabled = true;
            this.cmbHoraLlegadaCliente.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbHoraLlegadaCliente.Location = new System.Drawing.Point(532, 8);
            this.cmbHoraLlegadaCliente.Name = "cmbHoraLlegadaCliente";
            this.cmbHoraLlegadaCliente.Size = new System.Drawing.Size(51, 23);
            this.cmbHoraLlegadaCliente.TabIndex = 86;
            // 
            // cmbMinutosLlegadaCliente
            // 
            this.cmbMinutosLlegadaCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMinutosLlegadaCliente.Enabled = false;
            this.cmbMinutosLlegadaCliente.FormattingEnabled = true;
            this.cmbMinutosLlegadaCliente.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmbMinutosLlegadaCliente.Location = new System.Drawing.Point(589, 8);
            this.cmbMinutosLlegadaCliente.Name = "cmbMinutosLlegadaCliente";
            this.cmbMinutosLlegadaCliente.Size = new System.Drawing.Size(51, 23);
            this.cmbMinutosLlegadaCliente.TabIndex = 87;
            // 
            // btnQuitarComprobante
            // 
            this.btnQuitarComprobante.Location = new System.Drawing.Point(884, 229);
            this.btnQuitarComprobante.Name = "btnQuitarComprobante";
            this.btnQuitarComprobante.Size = new System.Drawing.Size(127, 23);
            this.btnQuitarComprobante.TabIndex = 34;
            this.btnQuitarComprobante.Text = "Quitar Comprobante";
            this.btnQuitarComprobante.UseVisualStyleBackColor = true;
            this.btnQuitarComprobante.Click += new System.EventHandler(this.btnQuitarComprobante_Click);
            // 
            // btnAgregarComprobante
            // 
            this.btnAgregarComprobante.Location = new System.Drawing.Point(884, 144);
            this.btnAgregarComprobante.Name = "btnAgregarComprobante";
            this.btnAgregarComprobante.Size = new System.Drawing.Size(127, 23);
            this.btnAgregarComprobante.TabIndex = 33;
            this.btnAgregarComprobante.Text = "Agregar Comprobante";
            this.btnAgregarComprobante.UseVisualStyleBackColor = true;
            this.btnAgregarComprobante.Click += new System.EventHandler(this.btnAgregarComprobante_Click);
            // 
            // btnGuardarComprobante
            // 
            this.btnGuardarComprobante.Location = new System.Drawing.Point(884, 202);
            this.btnGuardarComprobante.Name = "btnGuardarComprobante";
            this.btnGuardarComprobante.Size = new System.Drawing.Size(127, 23);
            this.btnGuardarComprobante.TabIndex = 32;
            this.btnGuardarComprobante.Text = "Guardar Comprobante";
            this.btnGuardarComprobante.UseVisualStyleBackColor = true;
            this.btnGuardarComprobante.Click += new System.EventHandler(this.btnGuardarComprobante_Click);
            // 
            // btnVerComprobante
            // 
            this.btnVerComprobante.Location = new System.Drawing.Point(884, 173);
            this.btnVerComprobante.Name = "btnVerComprobante";
            this.btnVerComprobante.Size = new System.Drawing.Size(127, 23);
            this.btnVerComprobante.TabIndex = 31;
            this.btnVerComprobante.Text = "Ver Comprobante";
            this.btnVerComprobante.UseVisualStyleBackColor = true;
            this.btnVerComprobante.Click += new System.EventHandler(this.btnVerComprobante_Click);
            // 
            // grdComprobantes
            // 
            this.grdComprobantes.AllowUpdate = false;
            this.grdComprobantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdComprobantes.DataMember = "comprobantesAceptacionOrdenservicio";
            this.grdComprobantes.DataSource = this.dsSpx1;
            this.grdComprobantes.FilterBar = true;
            this.grdComprobantes.Images.Add(((System.Drawing.Image)(resources.GetObject("grdComprobantes.Images"))));
            this.grdComprobantes.Location = new System.Drawing.Point(12, 135);
            this.grdComprobantes.Name = "grdComprobantes";
            this.grdComprobantes.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdComprobantes.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdComprobantes.PreviewInfo.ZoomFactor = 75D;
            this.grdComprobantes.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdComprobantes.PrintInfo.PageSettings")));
            this.grdComprobantes.Size = new System.Drawing.Size(876, 459);
            this.grdComprobantes.TabIndex = 30;
            this.grdComprobantes.Text = "c1TrueDBGrid1";
            this.grdComprobantes.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.grdComprobantes.PropBag = resources.GetString("grdComprobantes.PropBag");
            // 
            // tabItem5
            // 
            this.tabItem5.AttachedControl = this.tabControlPanel5;
            this.tabItem5.Name = "tabItem5";
            this.tabItem5.Text = "Comprobantes de Aceptacion";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnGuardar.Location = new System.Drawing.Point(94, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(83, 35);
            this.btnGuardar.TabIndex = 67;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnImprimir.Location = new System.Drawing.Point(6, 3);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(83, 35);
            this.btnImprimir.TabIndex = 68;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAnular.Image = ((System.Drawing.Image)(resources.GetObject("btnAnular.Image")));
            this.btnAnular.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnAnular.Location = new System.Drawing.Point(270, 3);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(83, 35);
            this.btnAnular.TabIndex = 70;
            this.btnAnular.Text = "Anular";
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnReabrirOrden
            // 
            this.btnReabrirOrden.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReabrirOrden.Image = ((System.Drawing.Image)(resources.GetObject("btnReabrirOrden.Image")));
            this.btnReabrirOrden.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnReabrirOrden.Location = new System.Drawing.Point(446, 3);
            this.btnReabrirOrden.Name = "btnReabrirOrden";
            this.btnReabrirOrden.Size = new System.Drawing.Size(83, 35);
            this.btnReabrirOrden.TabIndex = 72;
            this.btnReabrirOrden.Text = "Reabrir Orden";
            this.btnReabrirOrden.Click += new System.EventHandler(this.btnReabrirOrden_Click);
            // 
            // btnCerrarOrden
            // 
            this.btnCerrarOrden.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCerrarOrden.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarOrden.Image")));
            this.btnCerrarOrden.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnCerrarOrden.Location = new System.Drawing.Point(358, 3);
            this.btnCerrarOrden.Name = "btnCerrarOrden";
            this.btnCerrarOrden.Size = new System.Drawing.Size(83, 35);
            this.btnCerrarOrden.TabIndex = 71;
            this.btnCerrarOrden.Text = "Cerrar Orden";
            this.btnCerrarOrden.Click += new System.EventHandler(this.btnCerrarOrden_Click);
            // 
            // btnAprobarOrden
            // 
            this.btnAprobarOrden.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAprobarOrden.Image = ((System.Drawing.Image)(resources.GetObject("btnAprobarOrden.Image")));
            this.btnAprobarOrden.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnAprobarOrden.Location = new System.Drawing.Point(534, 3);
            this.btnAprobarOrden.Name = "btnAprobarOrden";
            this.btnAprobarOrden.Size = new System.Drawing.Size(83, 35);
            this.btnAprobarOrden.TabIndex = 73;
            this.btnAprobarOrden.Text = "Aprobar Orden";
            this.btnAprobarOrden.Click += new System.EventHandler(this.btnAprobarOrden_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnAceptar.Location = new System.Drawing.Point(182, 3);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(83, 35);
            this.btnAceptar.TabIndex = 74;
            this.btnAceptar.Text = "Aceptar";
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.Class = "";
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Controls.Add(this.btnImprimir);
            this.ribbonBar1.Controls.Add(this.btnGuardar);
            this.ribbonBar1.Controls.Add(this.btnAceptar);
            this.ribbonBar1.Controls.Add(this.btnAnular);
            this.ribbonBar1.Controls.Add(this.btnCerrarOrden);
            this.ribbonBar1.Controls.Add(this.btnReabrirOrden);
            this.ribbonBar1.Controls.Add(this.btnAprobarOrden);
            this.ribbonBar1.Controls.Add(this.btnCancelar);
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.controlContainerItem1,
            this.controlContainerItem2,
            this.controlContainerItem3,
            this.controlContainerItem5,
            this.controlContainerItem6,
            this.controlContainerItem7,
            this.controlContainerItem8,
            this.controlContainerItem9});
            this.ribbonBar1.Location = new System.Drawing.Point(0, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(1026, 57);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar1.TabIndex = 75;
            this.ribbonBar1.Text = "Opciones";
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.Class = "";
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.Class = "";
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnCancelar.Location = new System.Drawing.Point(622, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 35);
            this.btnCancelar.TabIndex = 75;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // controlContainerItem1
            // 
            this.controlContainerItem1.AllowItemResize = false;
            this.controlContainerItem1.Control = this.btnImprimir;
            this.controlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem1.Name = "controlContainerItem1";
            // 
            // controlContainerItem2
            // 
            this.controlContainerItem2.AllowItemResize = false;
            this.controlContainerItem2.Control = this.btnGuardar;
            this.controlContainerItem2.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem2.Name = "controlContainerItem2";
            // 
            // controlContainerItem3
            // 
            this.controlContainerItem3.AllowItemResize = false;
            this.controlContainerItem3.Control = this.btnAceptar;
            this.controlContainerItem3.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem3.Name = "controlContainerItem3";
            // 
            // controlContainerItem5
            // 
            this.controlContainerItem5.AllowItemResize = false;
            this.controlContainerItem5.Control = this.btnAnular;
            this.controlContainerItem5.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem5.Name = "controlContainerItem5";
            // 
            // controlContainerItem6
            // 
            this.controlContainerItem6.AllowItemResize = false;
            this.controlContainerItem6.Control = this.btnCerrarOrden;
            this.controlContainerItem6.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem6.Name = "controlContainerItem6";
            // 
            // controlContainerItem7
            // 
            this.controlContainerItem7.AllowItemResize = false;
            this.controlContainerItem7.Control = this.btnReabrirOrden;
            this.controlContainerItem7.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem7.Name = "controlContainerItem7";
            // 
            // controlContainerItem8
            // 
            this.controlContainerItem8.AllowItemResize = false;
            this.controlContainerItem8.Control = this.btnAprobarOrden;
            this.controlContainerItem8.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem8.Name = "controlContainerItem8";
            // 
            // controlContainerItem9
            // 
            this.controlContainerItem9.AllowItemResize = false;
            this.controlContainerItem9.Control = this.btnCancelar;
            this.controlContainerItem9.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem9.Name = "controlContainerItem9";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // tipoServicioTableAdapter1
            // 
            this.tipoServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // prioridadesOrdenServicioTableAdapter1
            // 
            this.prioridadesOrdenServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // archivosXOrdenServicioTableAdapter1
            // 
            this.archivosXOrdenServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // estadosOrdenServicioTableAdapter1
            // 
            this.estadosOrdenServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // reasignacionOrdenesTrabajoTableAdapter1
            // 
            this.reasignacionOrdenesTrabajoTableAdapter1.ClearBeforeFill = true;
            // 
            // tipoComprobanteTableAdapter1
            // 
            this.tipoComprobanteTableAdapter1.ClearBeforeFill = true;
            // 
            // ordenServicioTableAdapter1
            // 
            this.ordenServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // equiposTableAdapter1
            // 
            this.equiposTableAdapter1.ClearBeforeFill = true;
            // 
            // fabricanteTableAdapter1
            // 
            this.fabricanteTableAdapter1.ClearBeforeFill = true;
            // 
            // modelosTableAdapter1
            // 
            this.modelosTableAdapter1.ClearBeforeFill = true;
            // 
            // modalidadEquipoTableAdapter1
            // 
            this.modalidadEquipoTableAdapter1.ClearBeforeFill = true;
            // 
            // tipoDocumentoTableAdapter1
            // 
            this.tipoDocumentoTableAdapter1.ClearBeforeFill = true;
            // 
            // sucursalClienteTableAdapter1
            // 
            this.sucursalClienteTableAdapter1.ClearBeforeFill = true;
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // departamentoTableAdapter1
            // 
            this.departamentoTableAdapter1.ClearBeforeFill = true;
            // 
            // paisesTableAdapter1
            // 
            this.paisesTableAdapter1.ClearBeforeFill = true;
            // 
            // ciudadesTableAdapter1
            // 
            this.ciudadesTableAdapter1.ClearBeforeFill = true;
            // 
            // entradaSalidaEquiposTableAdapter1
            // 
            this.entradaSalidaEquiposTableAdapter1.ClearBeforeFill = true;
            // 
            // actividadxordenServicioTableAdapter1
            // 
            this.actividadxordenServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // comprobantesAceptacionOrdenservicioTableAdapter1
            // 
            this.comprobantesAceptacionOrdenservicioTableAdapter1.ClearBeforeFill = true;
            // 
            // solicitudInsumosTableAdapter1
            // 
            this.solicitudInsumosTableAdapter1.ClearBeforeFill = true;
            // 
            // ordenPrestamoTableAdapter1
            // 
            this.ordenPrestamoTableAdapter1.ClearBeforeFill = true;
            // 
            // pltOrdenPrestamoTableAdapter1
            // 
            this.pltOrdenPrestamoTableAdapter1.ClearBeforeFill = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // asesoresComercialesTableAdapter1
            // 
            this.asesoresComercialesTableAdapter1.ClearBeforeFill = true;
            // 
            // solicitudServicioTableAdapter1
            // 
            this.solicitudServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // repuestoxOrdenServicioTableAdapter1
            // 
            this.repuestoxOrdenServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // pltRepuestosxOrdenServicioTableAdapter1
            // 
            this.pltRepuestosxOrdenServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // logCambioUbicacionesTableAdapter1
            // 
            this.logCambioUbicacionesTableAdapter1.ClearBeforeFill = true;
            // 
            // defaultsTableAdapter1
            // 
            this.defaultsTableAdapter1.ClearBeforeFill = true;
            // 
            // contratosTableAdapter1
            // 
            this.contratosTableAdapter1.ClearBeforeFill = true;
            // 
            // mantenimientosxContratoTableAdapter1
            // 
            this.mantenimientosxContratoTableAdapter1.ClearBeforeFill = true;
            // 
            // contratosxEquipoTableAdapter1
            // 
            this.contratosxEquipoTableAdapter1.ClearBeforeFill = true;
            // 
            // actividad_adicionalTableAdapter1
            // 
            this.actividad_adicionalTableAdapter1.ClearBeforeFill = true;
            // 
            // notificacionTableAdapter1
            // 
            this.notificacionTableAdapter1.ClearBeforeFill = true;
            // 
            // llamadaSoporteTableAdapter1
            // 
            this.llamadaSoporteTableAdapter1.ClearBeforeFill = true;
            // 
            // comprobantesAceptacionOrdenservicioTableAdapter2
            // 
            this.comprobantesAceptacionOrdenservicioTableAdapter2.ClearBeforeFill = true;
            // 
            // dsSPXSeguridad2
            // 
            this.dsSPXSeguridad2.DataSetName = "dsSPXSeguridad";
            this.dsSPXSeguridad2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clsTusuario1
            // 
            this.clsTusuario1.nombreLlave = "cod_usuario";
            this.clsTusuario1.nombreTabla = "usuario";
            this.clsTusuario1.sentenciaBase = resources.GetString("clsTusuario1.sentenciaBase");
            this.clsTusuario1.sentenciaBaseDistinct = null;
            // 
            // dispositivosmedicionxordenservicioTableAdapter1
            // 
            this.dispositivosmedicionxordenservicioTableAdapter1.ClearBeforeFill = true;
            // 
            // pltVariablesxOrdenServicioTableAdapter1
            // 
            this.pltVariablesxOrdenServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // pltDispositivosxOrdenTableAdapter1
            // 
            this.pltDispositivosxOrdenTableAdapter1.ClearBeforeFill = true;
            // 
            // frmNuevaOrdenTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 738);
            this.Controls.Add(this.ribbonBar1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNuevaOrdenTrabajo";
            this.Text = "Nueva Orden de Servicio";
            this.Load += new System.EventHandler(this.frmNuevaOrdenTrabajo_Load);
            this.grpIngeniero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calUltimoMantenimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calProximoMantenimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.tabControlPanel1.PerformLayout();
            this.grpFecha.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpPorContrato.ResumeLayout(false);
            this.grpPorContrato.PerformLayout();
            this.tabControlPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdExpotarReportesInsumos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSolicitudesInsumos)).EndInit();
            this.tabControlPanel8.ResumeLayout(false);
            this.tabControlPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVariablesMedicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grddispositivosMedicion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calMantenimientoxUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRepuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdActividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CmbIng)).EndInit();
            this.tabControlPanel2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaFinProgramacionIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaCreacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calCierre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaProgramacionIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calAprobacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calAnulacion)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAsignaciones)).EndInit();
            this.tabControlPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdArchivos)).EndInit();
            this.tabControlPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrdenPrestamo)).EndInit();
            this.tabControlPanel5.ResumeLayout(false);
            this.grpInformacionCliente.ResumeLayout(false);
            this.grpInformacionCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdComprobantes)).EndInit();
            this.ribbonBar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpIngeniero;
        private System.Windows.Forms.ComboBox cmbIngeniero;
        private System.Windows.Forms.Label lblIngeniero;
        private SPControladoraDatos.dsSpx dsSpx1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cmbTipoServicio;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumeroEntrada;
        private System.Windows.Forms.TextBox txtNumeroOrdenServicio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdOrdenExterna;
        private System.Windows.Forms.RadioButton rdInterna;
        private System.Windows.Forms.Label label1;
        private SPControladoraDatos.dsSpxTableAdapters.TipoServicioTableAdapter tipoServicioTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.prioridadesOrdenServicioTableAdapter prioridadesOrdenServicioTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtNombrecliente;
        private System.Windows.Forms.TextBox txtNitCliente;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtSucursal;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtModalidad;
        private System.Windows.Forms.Label label26;
        private DevComponents.DotNetBar.ButtonX btnBuscarSerial;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calUltimoMantenimiento;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calProximoMantenimiento;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label23;
        private SPControladoraDatos.dsSpxTableAdapters.archivosXOrdenServicioTableAdapter archivosXOrdenServicioTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.estadosOrdenServicioTableAdapter estadosOrdenServicioTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.reasignacionOrdenesTrabajoTableAdapter reasignacionOrdenesTrabajoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.tipoComprobanteTableAdapter tipoComprobanteTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter ordenServicioTableAdapter1;
        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel3;
        private DevComponents.DotNetBar.TabItem tabItem3;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.TabItem tabItem2;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel5;
        private DevComponents.DotNetBar.TabItem tabItem5;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel7;
        private DevComponents.DotNetBar.TabItem tabItem7;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel6;
        private DevComponents.DotNetBar.TabItem tabItem6;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel8;
        private DevComponents.DotNetBar.TabItem tabItem8;
        private System.Windows.Forms.TextBox txtAnuladaPor;
        private System.Windows.Forms.TextBox txtAprobadaPor;
        private System.Windows.Forms.TextBox txtCerradaPor;
        private System.Windows.Forms.TextBox txtCreadaPor;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label32;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calAnulacion;
        private System.Windows.Forms.Label label31;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calAprobacion;
        private System.Windows.Forms.Label label29;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calCierre;
        private System.Windows.Forms.Label label2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFechaCreacion;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.Label label37;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFechaProgramacionIA;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdAsignaciones;
        private DevComponents.DotNetBar.ButtonX btnReasignar;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdArchivos;
        private System.Windows.Forms.Button btnQuitarComprobante;
        private System.Windows.Forms.Button btnAgregarComprobante;
        private System.Windows.Forms.Button btnGuardarComprobante;
        private System.Windows.Forms.Button btnVerComprobante;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdComprobantes;
        private C1.Win.C1TrueDBGrid.C1TrueDBDropdown c1CmbIng;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdActividades;
        private System.Windows.Forms.Button btnImprimirSolicitud;
        private System.Windows.Forms.Button btnActualizarSolicitudes;
        private System.Windows.Forms.Button btnEliminarSolicitud;
        private System.Windows.Forms.Button btnModifcarSolicitud;
        private System.Windows.Forms.Button btnAgregarInsumos;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdSolicitudesInsumos;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox txtObservacionesIngeniero;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox txtFallasReportadas;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox txtObservacionesIniciales;
        private SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter equiposTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.fabricanteTableAdapter fabricanteTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter modelosTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.ModalidadEquipoTableAdapter modalidadEquipoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.tipoDocumentoTableAdapter tipoDocumentoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.sucursalClienteTableAdapter sucursalClienteTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.clientesTableAdapter clientesTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.departamentoTableAdapter departamentoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.paisesTableAdapter paisesTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.ciudadesTableAdapter ciudadesTableAdapter1;
        private DevComponents.DotNetBar.ButtonX btnReabrirOrden;
        private DevComponents.DotNetBar.ButtonX btnCerrarOrden;
        private DevComponents.DotNetBar.ButtonX btnAnular;
        private DevComponents.DotNetBar.ButtonX btnImprimir;
        private DevComponents.DotNetBar.ButtonX btnGuardar;
        private DevComponents.DotNetBar.ButtonX btnAprobarOrden;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonX btnAceptar;
        private DevComponents.DotNetBar.ButtonX btnCancelar;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem2;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem3;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem5;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem6;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem7;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem8;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem9;
        private DevComponents.DotNetBar.ButtonX btnInfEquipo;
        private System.Windows.Forms.Button btnLimpiarIngeniero;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private System.Windows.Forms.Label label6;
        private SPControladoraDatos.dsSpxTableAdapters.EntradaSalidaEquiposTableAdapter entradaSalidaEquiposTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.actividadxordenServicioTableAdapter actividadxordenServicioTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.comprobantesAceptacionOrdenservicioTableAdapter comprobantesAceptacionOrdenservicioTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.solicitudInsumosTableAdapter solicitudInsumosTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.OrdenPrestamoTableAdapter ordenPrestamoTableAdapter1;
        private SPControladoraDatos.dsPlantillasTableAdapters.pltOrdenPrestamoTableAdapter pltOrdenPrestamoTableAdapter1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpFecha;
        private System.Windows.Forms.ComboBox cmbAsesorComercial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox6;
        private DevComponents.DotNetBar.Controls.GroupPanel grpInformacionCliente;
        private DevComponents.DotNetBar.ButtonX btnCambiarInformacionAceptacionCliente;
        private System.Windows.Forms.ComboBox cmbAmPMSalidaCliente;
        private System.Windows.Forms.ComboBox cmbMinSalidaCliente;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.ComboBox cmbHoraSalidaCliente;
        private System.Windows.Forms.TextBox txtUsuarioCliente;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.ComboBox cmbAmPmLlegadaCliente;
        private System.Windows.Forms.ComboBox cmbHoraLlegadaCliente;
        private System.Windows.Forms.ComboBox cmbMinutosLlegadaCliente;
        private System.Windows.Forms.Label label16;
        private SPControladoraDatos.dsSpxTableAdapters.asesoresComercialesTableAdapter asesoresComercialesTableAdapter1;
        private System.Windows.Forms.Button btnLimpiaAsesor;
        private SPControladoraDatos.dsSpxTableAdapters.solicitudServicioTableAdapter solicitudServicioTableAdapter1;
        private System.Windows.Forms.Label label21;
        private DevComponents.DotNetBar.ButtonX btnAgregarActividad;
        private DevComponents.DotNetBar.ButtonX btnModificarActividad;
        private DevComponents.DotNetBar.ButtonX btnEliminarActividad;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdRepuestos;
        private DevComponents.DotNetBar.ButtonX btnAgregarRepuesto;
        private DevComponents.DotNetBar.ButtonX btnModificarRepuesto;
        private DevComponents.DotNetBar.ButtonX btnQuitarRepuesto;
        private SPControladoraDatos.dsPlantillas dsPlantillas1;
        private SPControladoraDatos.dsSpxTableAdapters.repuestoxOrdenServicioTableAdapter repuestoxOrdenServicioTableAdapter1;
        private SPControladoraDatos.dsPlantillasTableAdapters.pltRepuestosxOrdenServicioTableAdapter pltRepuestosxOrdenServicioTableAdapter1;
        private DevComponents.DotNetBar.ButtonX btnConsultarDisponib;
        private SPControladoraDatos.dsSpxTableAdapters.logCambioUbicacionesTableAdapter logCambioUbicacionesTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter defaultsTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.contratosTableAdapter contratosTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.mantenimientosxContratoTableAdapter mantenimientosxContratoTableAdapter1;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdOrdenPrestamo;
        private DevComponents.DotNetBar.ButtonX btnImprimirOrdenPrestamo;
        private DevComponents.DotNetBar.ButtonX btnActualizarOrdenPrestamo;
        private DevComponents.DotNetBar.ButtonX btnSolicitarOrdenPrestamo;
        private DevComponents.DotNetBar.ButtonX btnModificarOrdenPrestamo;
        private DevComponents.DotNetBar.ButtonX btnEliminarOrdenPrestamo;
        private DevComponents.DotNetBar.ButtonX btnVerES;
        private DevComponents.DotNetBar.ButtonX btnInfCliente;
        private DevComponents.DotNetBar.ButtonX btnInfSucursal;
        private DevComponents.DotNetBar.ButtonX btnVerArchivo;
        private DevComponents.DotNetBar.ButtonX btnSubirArchivo;
        private DevComponents.DotNetBar.ButtonX btnGuardarArchivo;
        private DevComponents.DotNetBar.ButtonX btnQuitarArchivo;
        private System.Windows.Forms.Label label11;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFechaFinProgramacionIA;
        private SPControladoraDatos.dsSpxTableAdapters.contratosxEquipoTableAdapter contratosxEquipoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.actividad_adicionalTableAdapter actividad_adicionalTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.notificacionTableAdapter notificacionTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.LlamadaSoporteTableAdapter llamadaSoporteTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.comprobantesAceptacionOrdenservicioTableAdapter comprobantesAceptacionOrdenservicioTableAdapter2;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad1;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad2;
        private SPXSeguridad.data.cls.clsTusuario clsTusuario1;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.calFecha calFinProg;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.calFecha calInicioProg;
        private System.Windows.Forms.GroupBox grpPorContrato;
        private System.Windows.Forms.TextBox txtNumeroContrato;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rdContratoNo;
        private System.Windows.Forms.RadioButton rdContratoSi;
        private System.Windows.Forms.Label label14;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calMantenimientoxUsuario;
        private System.Windows.Forms.RadioButton rdManteimientoIndicadoNo;
        private System.Windows.Forms.RadioButton rdMantemientoIndicado;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RadioButton rdAdecuadoNo;
        private System.Windows.Forms.RadioButton rdAdecuado;
        private DevComponents.DotNetBar.ButtonX btnAgregarVariableMedicion;
        private DevComponents.DotNetBar.ButtonX btnEditarVariableMedicion;
        private DevComponents.DotNetBar.ButtonX btnEliminarVariableMedicion;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdVariablesMedicion;
        private System.Windows.Forms.Label label25;
        private DevComponents.DotNetBar.ButtonX btnAgregarDispostivoMedicion;
        private DevComponents.DotNetBar.ButtonX btnHojaVidaDipositivoMedicion;
        private DevComponents.DotNetBar.ButtonX btnQuitarDispositivo;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grddispositivosMedicion;
        private System.Windows.Forms.Label label20;
        private SPControladoraDatos.dsSpxTableAdapters.dispositivosmedicionxordenservicioTableAdapter dispositivosmedicionxordenservicioTableAdapter1;
        private SPControladoraDatos.dsPlantillasTableAdapters.pltVariablesxOrdenServicioTableAdapter pltVariablesxOrdenServicioTableAdapter1;
        private DevComponents.DotNetBar.ButtonX btnVerRangos;
        private DevComponents.DotNetBar.ButtonX btnAgregarDispositivoMedicionExterno;
        private SPControladoraDatos.dsPlantillasTableAdapters.pltDispositivosxOrdenTableAdapter pltDispositivosxOrdenTableAdapter1;
        private System.Windows.Forms.Button btnGenerarExcel;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdExpotarReportesInsumos;
    }
}