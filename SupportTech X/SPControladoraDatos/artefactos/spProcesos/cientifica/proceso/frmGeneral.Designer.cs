namespace spProcesos.cientifica.proceso
{
    partial class frmGeneral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeneral));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExportarSeguimientos = new DevComponents.DotNetBar.ButtonX();
            this.btnVerSeguimiento = new DevComponents.DotNetBar.ButtonX();
            this.grdSeguimentos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.prioridad_callcenter_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.prioridad_callcenter_cientificaTableAdapter();
            this.sucursalClienteTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.sucursalClienteTableAdapter();
            this.contactosClientesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.contactosClientesTableAdapter();
            this.asesoria_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.asesoria_cientificaTableAdapter();
            this.estado_asesoria_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.estado_asesoria_cientificaTableAdapter();
            this.clientesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.clientesTableAdapter();
            this.txtNumeroAsesoria = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.btnInfSucursal = new DevComponents.DotNetBar.ButtonX();
            this.txtNombrecliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.txtInfAdiContacto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCelularContacto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTelefonoContacto = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNombreContacto = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRegistadaPor = new System.Windows.Forms.TextBox();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.txtMotivoConsulta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.calFechaSolicitud = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.seguimiento_asesoria_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.seguimiento_asesoria_cientificaTableAdapter();
            this.dsSPXSeguridad1 = new SPXSeguridad.data.dsSPXSeguridad();
            this.accion_seguirxasesoria_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.accion_seguirxasesoria_cientificaTableAdapter();
            this.accion_seguir_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.accion_seguir_cientificaTableAdapter();
            this.fabricanteTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.fabricanteTableAdapter();
            this.modelosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter();
            this.referencia_reactivoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.referencia_reactivoTableAdapter();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.equiposTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter();
            this.solicitudServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.solicitudServicioTableAdapter();
            this.btnTareasProgramadas = new DevComponents.DotNetBar.ButtonX();
            this.llamadaSoportePreTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.LlamadaSoportePreTableAdapter();
            this.clsTusuario1 = new SPXSeguridad.data.cls.clsTusuario();
            this.calSugerida = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.calFecha();
            this.label18 = new System.Windows.Forms.Label();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbUsuarioInterno = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtCodLlamada = new System.Windows.Forms.TextBox();
            this.chkInterna = new System.Windows.Forms.CheckBox();
            this.chkIndicaNoEquipo = new System.Windows.Forms.CheckBox();
            this.txtAsesorResponsable = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.calVencimiento = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtNumeroLote = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cmbFabricanteEquipo = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cmbModeloEquipo = new System.Windows.Forms.ComboBox();
            this.grdAccionesSeguir = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.label20 = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFabricanteReactivo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReactivo = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.txtBusqueda();
            this.label5 = new System.Windows.Forms.Label();
            this.calRespuestaInicial = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.calFecha();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.cmbPrioridadAsignada = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdDisponibilidad = new System.Windows.Forms.RadioButton();
            this.rdNoDisponibilidad = new System.Windows.Forms.RadioButton();
            this.txtInformacionSuministradaInicial = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtRespuestaInicial = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.calCierre = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cmbInconvenientePor = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label32 = new System.Windows.Forms.Label();
            this.txtPorqueNoConforme = new System.Windows.Forms.TextBox();
            this.rdNoConforme = new System.Windows.Forms.RadioButton();
            this.rdSiConforme = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label33 = new System.Windows.Forms.Label();
            this.txtPorqueNoSolucionado = new System.Windows.Forms.TextBox();
            this.rdNoSolucionado = new System.Windows.Forms.RadioButton();
            this.rdSiSolucionado = new System.Windows.Forms.RadioButton();
            this.txtReporteCalidad = new System.Windows.Forms.TextBox();
            this.numDiasSolcuonar = new System.Windows.Forms.NumericUpDown();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.calVisita = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dsSpx2 = new SPControladoraDatos.dsSpx();
            this.inconveniente_presentado_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.inconveniente_presentado_cientificaTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSeguimentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaSolicitud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.tabControlPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calVencimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccionesSeguir)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calCierre)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiasSolcuonar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calVisita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 511);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 51);
            this.panel1.TabIndex = 6;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(875, 16);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(9, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Seguimientos";
            // 
            // btnExportarSeguimientos
            // 
            this.btnExportarSeguimientos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExportarSeguimientos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarSeguimientos.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExportarSeguimientos.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarSeguimientos.Image")));
            this.btnExportarSeguimientos.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnExportarSeguimientos.Location = new System.Drawing.Point(922, 248);
            this.btnExportarSeguimientos.Name = "btnExportarSeguimientos";
            this.btnExportarSeguimientos.Size = new System.Drawing.Size(28, 28);
            this.btnExportarSeguimientos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExportarSeguimientos.TabIndex = 63;
            this.btnExportarSeguimientos.Click += new System.EventHandler(this.btnExportarSeguimientos_Click);
            // 
            // btnVerSeguimiento
            // 
            this.btnVerSeguimiento.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVerSeguimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerSeguimiento.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnVerSeguimiento.Image = ((System.Drawing.Image)(resources.GetObject("btnVerSeguimiento.Image")));
            this.btnVerSeguimiento.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnVerSeguimiento.Location = new System.Drawing.Point(888, 248);
            this.btnVerSeguimiento.Name = "btnVerSeguimiento";
            this.btnVerSeguimiento.Size = new System.Drawing.Size(28, 28);
            this.btnVerSeguimiento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnVerSeguimiento.TabIndex = 61;
            this.btnVerSeguimiento.Click += new System.EventHandler(this.btnVerSeguimiento_Click);
            // 
            // grdSeguimentos
            // 
            this.grdSeguimentos.AllowUpdate = false;
            this.grdSeguimentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdSeguimentos.DataMember = "seguimiento_asesoria_cientifica";
            this.grdSeguimentos.DataSource = this.dsSpx1;
            this.grdSeguimentos.FilterBar = true;
            this.grdSeguimentos.GroupByCaption = "Drag a column header here to group by that column";
            this.grdSeguimentos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdSeguimentos.Images"))));
            this.grdSeguimentos.Location = new System.Drawing.Point(12, 278);
            this.grdSeguimentos.Name = "grdSeguimentos";
            this.grdSeguimentos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdSeguimentos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdSeguimentos.PreviewInfo.ZoomFactor = 75D;
            this.grdSeguimentos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdSeguimentos.PrintInfo.PageSettings")));
            this.grdSeguimentos.RowHeight = 46;
            this.grdSeguimentos.Size = new System.Drawing.Size(933, 189);
            this.grdSeguimentos.TabIndex = 53;
            this.grdSeguimentos.Text = "c1TrueDBGrid2";
            this.grdSeguimentos.PropBag = resources.GetString("grdSeguimentos.PropBag");
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prioridad_callcenter_cientificaTableAdapter1
            // 
            this.prioridad_callcenter_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // sucursalClienteTableAdapter1
            // 
            this.sucursalClienteTableAdapter1.ClearBeforeFill = true;
            // 
            // contactosClientesTableAdapter1
            // 
            this.contactosClientesTableAdapter1.ClearBeforeFill = true;
            // 
            // asesoria_cientificaTableAdapter1
            // 
            this.asesoria_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // estado_asesoria_cientificaTableAdapter1
            // 
            this.estado_asesoria_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // txtNumeroAsesoria
            // 
            this.txtNumeroAsesoria.BackColor = System.Drawing.Color.White;
            this.txtNumeroAsesoria.Location = new System.Drawing.Point(111, 16);
            this.txtNumeroAsesoria.Name = "txtNumeroAsesoria";
            this.txtNumeroAsesoria.ReadOnly = true;
            this.txtNumeroAsesoria.Size = new System.Drawing.Size(181, 20);
            this.txtNumeroAsesoria.TabIndex = 77;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.cmbSucursal);
            this.groupBox4.Controls.Add(this.btnInfSucursal);
            this.groupBox4.Controls.Add(this.txtNombrecliente);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Location = new System.Drawing.Point(386, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(420, 220);
            this.groupBox4.TabIndex = 76;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informacion del Cliente";
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.DataSource = this.dsSpx1;
            this.cmbSucursal.DisplayMember = "sucursalCliente.nombreSucursal";
            this.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursal.Enabled = false;
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(61, 50);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(250, 21);
            this.cmbSucursal.TabIndex = 30;
            this.cmbSucursal.ValueMember = "sucursalCliente.codSucursal";
            // 
            // btnInfSucursal
            // 
            this.btnInfSucursal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInfSucursal.Image = ((System.Drawing.Image)(resources.GetObject("btnInfSucursal.Image")));
            this.btnInfSucursal.ImageFixedSize = new System.Drawing.Size(29, 29);
            this.btnInfSucursal.Location = new System.Drawing.Point(317, 48);
            this.btnInfSucursal.Name = "btnInfSucursal";
            this.btnInfSucursal.Size = new System.Drawing.Size(30, 28);
            this.btnInfSucursal.TabIndex = 86;
            this.btnInfSucursal.Click += new System.EventHandler(this.btnInfSucursal_Click);
            // 
            // txtNombrecliente
            // 
            this.txtNombrecliente.BackColor = System.Drawing.Color.White;
            this.txtNombrecliente.Location = new System.Drawing.Point(61, 20);
            this.txtNombrecliente.Name = "txtNombrecliente";
            this.txtNombrecliente.ReadOnly = true;
            this.txtNombrecliente.Size = new System.Drawing.Size(251, 20);
            this.txtNombrecliente.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(7, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 84;
            this.label12.Text = "Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.buttonX1);
            this.groupBox2.Controls.Add(this.txtInfAdiContacto);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtCelularContacto);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtTelefonoContacto);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtNombreContacto);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(7, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 142);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contacto";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Image = ((System.Drawing.Image)(resources.GetObject("buttonX1.Image")));
            this.buttonX1.ImageFixedSize = new System.Drawing.Size(29, 29);
            this.buttonX1.Location = new System.Drawing.Point(310, 12);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(33, 33);
            this.buttonX1.TabIndex = 86;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // txtInfAdiContacto
            // 
            this.txtInfAdiContacto.BackColor = System.Drawing.Color.White;
            this.txtInfAdiContacto.Location = new System.Drawing.Point(120, 80);
            this.txtInfAdiContacto.Multiline = true;
            this.txtInfAdiContacto.Name = "txtInfAdiContacto";
            this.txtInfAdiContacto.ReadOnly = true;
            this.txtInfAdiContacto.Size = new System.Drawing.Size(278, 52);
            this.txtInfAdiContacto.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(6, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 29);
            this.label13.TabIndex = 35;
            this.label13.Text = "Informacion Adicional de Contacto";
            // 
            // txtCelularContacto
            // 
            this.txtCelularContacto.BackColor = System.Drawing.Color.White;
            this.txtCelularContacto.Location = new System.Drawing.Point(219, 51);
            this.txtCelularContacto.Name = "txtCelularContacto";
            this.txtCelularContacto.ReadOnly = true;
            this.txtCelularContacto.Size = new System.Drawing.Size(121, 20);
            this.txtCelularContacto.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(182, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Celular";
            // 
            // txtTelefonoContacto
            // 
            this.txtTelefonoContacto.BackColor = System.Drawing.Color.White;
            this.txtTelefonoContacto.Location = new System.Drawing.Point(54, 50);
            this.txtTelefonoContacto.Name = "txtTelefonoContacto";
            this.txtTelefonoContacto.ReadOnly = true;
            this.txtTelefonoContacto.Size = new System.Drawing.Size(112, 20);
            this.txtTelefonoContacto.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Telefono";
            // 
            // txtNombreContacto
            // 
            this.txtNombreContacto.BackColor = System.Drawing.Color.White;
            this.txtNombreContacto.Location = new System.Drawing.Point(54, 23);
            this.txtNombreContacto.Name = "txtNombreContacto";
            this.txtNombreContacto.ReadOnly = true;
            this.txtNombreContacto.Size = new System.Drawing.Size(251, 20);
            this.txtNombreContacto.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Nombre";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 50);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "Sucursal";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(4, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 75;
            this.label11.Text = "Asesoria Num:";
            // 
            // txtRegistadaPor
            // 
            this.txtRegistadaPor.BackColor = System.Drawing.Color.White;
            this.txtRegistadaPor.Location = new System.Drawing.Point(111, 67);
            this.txtRegistadaPor.Name = "txtRegistadaPor";
            this.txtRegistadaPor.ReadOnly = true;
            this.txtRegistadaPor.Size = new System.Drawing.Size(181, 20);
            this.txtRegistadaPor.TabIndex = 74;
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.DataSource = this.dsSpx1;
            this.cmbPrioridad.DisplayMember = "prioridad_callcenter_cientifica.nombre_prioridad";
            this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridad.Enabled = false;
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Location = new System.Drawing.Point(111, 120);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(181, 21);
            this.cmbPrioridad.TabIndex = 73;
            this.cmbPrioridad.ValueMember = "prioridad_callcenter_cientifica.cod_prioridad_callcenter_cientifica";
            // 
            // txtMotivoConsulta
            // 
            this.txtMotivoConsulta.BackColor = System.Drawing.Color.White;
            this.txtMotivoConsulta.Location = new System.Drawing.Point(5, 246);
            this.txtMotivoConsulta.Multiline = true;
            this.txtMotivoConsulta.Name = "txtMotivoConsulta";
            this.txtMotivoConsulta.ReadOnly = true;
            this.txtMotivoConsulta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMotivoConsulta.Size = new System.Drawing.Size(371, 82);
            this.txtMotivoConsulta.TabIndex = 72;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(4, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 71;
            this.label10.Text = "Motivo de la Consulta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(4, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Prioridad Sugerida:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(4, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Registada Por:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(4, 43);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 13);
            this.label17.TabIndex = 68;
            this.label17.Text = "Fecha de Solicitud:";
            // 
            // calFechaSolicitud
            // 
            // 
            // 
            // 
            this.calFechaSolicitud.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calFechaSolicitud.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaSolicitud.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.calFechaSolicitud.ButtonDropDown.Visible = true;
            this.calFechaSolicitud.Enabled = false;
            this.calFechaSolicitud.Location = new System.Drawing.Point(111, 42);
            // 
            // 
            // 
            this.calFechaSolicitud.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFechaSolicitud.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calFechaSolicitud.MonthCalendar.BackgroundStyle.Class = "";
            this.calFechaSolicitud.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaSolicitud.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calFechaSolicitud.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calFechaSolicitud.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calFechaSolicitud.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calFechaSolicitud.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calFechaSolicitud.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calFechaSolicitud.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calFechaSolicitud.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calFechaSolicitud.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaSolicitud.MonthCalendar.DisplayMonth = new System.DateTime(2010, 11, 1, 0, 0, 0, 0);
            this.calFechaSolicitud.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calFechaSolicitud.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFechaSolicitud.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calFechaSolicitud.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calFechaSolicitud.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calFechaSolicitud.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calFechaSolicitud.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaSolicitud.MonthCalendar.TodayButtonVisible = true;
            this.calFechaSolicitud.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calFechaSolicitud.Name = "calFechaSolicitud";
            this.calFechaSolicitud.Size = new System.Drawing.Size(181, 20);
            this.calFechaSolicitud.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.calFechaSolicitud.TabIndex = 67;
            // 
            // seguimiento_asesoria_cientificaTableAdapter1
            // 
            this.seguimiento_asesoria_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // dsSPXSeguridad1
            // 
            this.dsSPXSeguridad1.DataSetName = "dsSPXSeguridad";
            this.dsSPXSeguridad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accion_seguirxasesoria_cientificaTableAdapter1
            // 
            this.accion_seguirxasesoria_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // accion_seguir_cientificaTableAdapter1
            // 
            this.accion_seguir_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // fabricanteTableAdapter1
            // 
            this.fabricanteTableAdapter1.ClearBeforeFill = true;
            // 
            // modelosTableAdapter1
            // 
            this.modelosTableAdapter1.ClearBeforeFill = true;
            // 
            // referencia_reactivoTableAdapter1
            // 
            this.referencia_reactivoTableAdapter1.ClearBeforeFill = true;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DataSource = this.dsSpx1;
            this.cmbEstado.DisplayMember = "estado_asesoria_cientifica.nombre_estado_asesoria_cientifica";
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Enabled = false;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(111, 93);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(181, 21);
            this.cmbEstado.TabIndex = 80;
            this.cmbEstado.ValueMember = "estado_asesoria_cientifica.cod_estado_asesoria_cientifica";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(4, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "Estado Asesoria:";
            // 
            // equiposTableAdapter1
            // 
            this.equiposTableAdapter1.ClearBeforeFill = true;
            // 
            // solicitudServicioTableAdapter1
            // 
            this.solicitudServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // btnTareasProgramadas
            // 
            this.btnTareasProgramadas.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTareasProgramadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTareasProgramadas.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTareasProgramadas.Image = ((System.Drawing.Image)(resources.GetObject("btnTareasProgramadas.Image")));
            this.btnTareasProgramadas.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnTareasProgramadas.Location = new System.Drawing.Point(857, 169);
            this.btnTareasProgramadas.Name = "btnTareasProgramadas";
            this.btnTareasProgramadas.Size = new System.Drawing.Size(94, 57);
            this.btnTareasProgramadas.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTareasProgramadas.TabIndex = 82;
            this.btnTareasProgramadas.Text = "Tareas Programadas";
            this.btnTareasProgramadas.Click += new System.EventHandler(this.btnTareasProgramadas_Click);
            // 
            // llamadaSoportePreTableAdapter1
            // 
            this.llamadaSoportePreTableAdapter1.ClearBeforeFill = true;
            // 
            // clsTusuario1
            // 
            this.clsTusuario1.nombreLlave = "cod_usuario";
            this.clsTusuario1.nombreTabla = "usuario";
            this.clsTusuario1.sentenciaBase = resources.GetString("clsTusuario1.sentenciaBase");
            this.clsTusuario1.sentenciaBaseDistinct = resources.GetString("clsTusuario1.sentenciaBaseDistinct");
            // 
            // calSugerida
            // 
            this.calSugerida.BackColor = System.Drawing.Color.Transparent;
            this.calSugerida.Enabled = false;
            this.calSugerida.fechaValue = new System.DateTime(((long)(0)));
            this.calSugerida.fechaValueObject = null;
            this.calSugerida.Location = new System.Drawing.Point(111, 174);
            this.calSugerida.Name = "calSugerida";
            this.calSugerida.Size = new System.Drawing.Size(233, 21);
            this.calSugerida.TabIndex = 86;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(4, 178);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 13);
            this.label18.TabIndex = 85;
            this.label18.Text = "Fecha Sugerida:";
            // 
            // tabControl1
            // 
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Controls.Add(this.tabControlPanel2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(963, 511);
            this.tabControl1.TabIndex = 87;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItem1);
            this.tabControl1.Tabs.Add(this.tabItem2);
            this.tabControl1.Text = "tabControl1";
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel1;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "General";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.groupBox3);
            this.tabControlPanel1.Controls.Add(this.txtInformacionSuministradaInicial);
            this.tabControlPanel1.Controls.Add(this.cmbPrioridadAsignada);
            this.tabControlPanel1.Controls.Add(this.label27);
            this.tabControlPanel1.Controls.Add(this.label28);
            this.tabControlPanel1.Controls.Add(this.txtRespuestaInicial);
            this.tabControlPanel1.Controls.Add(this.calRespuestaInicial);
            this.tabControlPanel1.Controls.Add(this.label29);
            this.tabControlPanel1.Controls.Add(this.label26);
            this.tabControlPanel1.Controls.Add(this.label11);
            this.tabControlPanel1.Controls.Add(this.btnTareasProgramadas);
            this.tabControlPanel1.Controls.Add(this.calSugerida);
            this.tabControlPanel1.Controls.Add(this.calFechaSolicitud);
            this.tabControlPanel1.Controls.Add(this.groupBox4);
            this.tabControlPanel1.Controls.Add(this.label18);
            this.tabControlPanel1.Controls.Add(this.label17);
            this.tabControlPanel1.Controls.Add(this.label2);
            this.tabControlPanel1.Controls.Add(this.label3);
            this.tabControlPanel1.Controls.Add(this.label1);
            this.tabControlPanel1.Controls.Add(this.label10);
            this.tabControlPanel1.Controls.Add(this.cmbEstado);
            this.tabControlPanel1.Controls.Add(this.txtMotivoConsulta);
            this.tabControlPanel1.Controls.Add(this.cmbPrioridad);
            this.tabControlPanel1.Controls.Add(this.txtNumeroAsesoria);
            this.tabControlPanel1.Controls.Add(this.txtRegistadaPor);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(963, 485);
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
            // tabItem2
            // 
            this.tabItem2.AttachedControl = this.tabControlPanel2;
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.Text = "Seguimiento y Cierre";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.label6);
            this.tabControlPanel2.Controls.Add(this.calCierre);
            this.tabControlPanel2.Controls.Add(this.cmbInconvenientePor);
            this.tabControlPanel2.Controls.Add(this.label31);
            this.tabControlPanel2.Controls.Add(this.groupBox5);
            this.tabControlPanel2.Controls.Add(this.groupBox6);
            this.tabControlPanel2.Controls.Add(this.txtReporteCalidad);
            this.tabControlPanel2.Controls.Add(this.numDiasSolcuonar);
            this.tabControlPanel2.Controls.Add(this.label34);
            this.tabControlPanel2.Controls.Add(this.label35);
            this.tabControlPanel2.Controls.Add(this.label36);
            this.tabControlPanel2.Controls.Add(this.calVisita);
            this.tabControlPanel2.Controls.Add(this.btnExportarSeguimientos);
            this.tabControlPanel2.Controls.Add(this.btnVerSeguimiento);
            this.tabControlPanel2.Controls.Add(this.label4);
            this.tabControlPanel2.Controls.Add(this.grdSeguimentos);
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(963, 485);
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
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.cmbUsuarioInterno);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.txtCodLlamada);
            this.groupBox3.Controls.Add(this.chkInterna);
            this.groupBox3.Controls.Add(this.chkIndicaNoEquipo);
            this.groupBox3.Controls.Add(this.txtAsesorResponsable);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.calVencimiento);
            this.groupBox3.Controls.Add(this.txtNumeroLote);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.cmbFabricanteEquipo);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.cmbModeloEquipo);
            this.groupBox3.Controls.Add(this.grdAccionesSeguir);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.txtSerial);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtFabricanteReactivo);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtReactivo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(386, 229);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(570, 249);
            this.groupBox3.TabIndex = 87;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion Aceptacion";
            // 
            // cmbUsuarioInterno
            // 
            this.cmbUsuarioInterno.DataSource = this.dsSPXSeguridad1;
            this.cmbUsuarioInterno.DisplayMember = "usuario.nombre";
            this.cmbUsuarioInterno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuarioInterno.Enabled = false;
            this.cmbUsuarioInterno.FormattingEnabled = true;
            this.cmbUsuarioInterno.Location = new System.Drawing.Point(409, 82);
            this.cmbUsuarioInterno.Name = "cmbUsuarioInterno";
            this.cmbUsuarioInterno.Size = new System.Drawing.Size(147, 21);
            this.cmbUsuarioInterno.TabIndex = 111;
            this.cmbUsuarioInterno.ValueMember = "usuarios.login";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(321, 86);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(82, 13);
            this.label25.TabIndex = 110;
            this.label25.Text = "Usuario Interno:";
            // 
            // txtCodLlamada
            // 
            this.txtCodLlamada.BackColor = System.Drawing.Color.White;
            this.txtCodLlamada.Location = new System.Drawing.Point(653, -17);
            this.txtCodLlamada.Name = "txtCodLlamada";
            this.txtCodLlamada.ReadOnly = true;
            this.txtCodLlamada.Size = new System.Drawing.Size(121, 20);
            this.txtCodLlamada.TabIndex = 83;
            // 
            // chkInterna
            // 
            this.chkInterna.AutoSize = true;
            this.chkInterna.Enabled = false;
            this.chkInterna.Location = new System.Drawing.Point(324, 59);
            this.chkInterna.Name = "chkInterna";
            this.chkInterna.Size = new System.Drawing.Size(102, 17);
            this.chkInterna.TabIndex = 109;
            this.chkInterna.Text = "Llamada Interna";
            this.chkInterna.UseVisualStyleBackColor = true;
            // 
            // chkIndicaNoEquipo
            // 
            this.chkIndicaNoEquipo.AutoSize = true;
            this.chkIndicaNoEquipo.Enabled = false;
            this.chkIndicaNoEquipo.Location = new System.Drawing.Point(122, 16);
            this.chkIndicaNoEquipo.Name = "chkIndicaNoEquipo";
            this.chkIndicaNoEquipo.Size = new System.Drawing.Size(183, 17);
            this.chkIndicaNoEquipo.TabIndex = 108;
            this.chkIndicaNoEquipo.Text = "Llamada sin Equipo y/o Reactivo";
            this.chkIndicaNoEquipo.UseVisualStyleBackColor = true;
            // 
            // txtAsesorResponsable
            // 
            this.txtAsesorResponsable.BackColor = System.Drawing.Color.White;
            this.txtAsesorResponsable.Location = new System.Drawing.Point(124, 38);
            this.txtAsesorResponsable.Name = "txtAsesorResponsable";
            this.txtAsesorResponsable.ReadOnly = true;
            this.txtAsesorResponsable.Size = new System.Drawing.Size(181, 20);
            this.txtAsesorResponsable.TabIndex = 104;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(9, 135);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(114, 13);
            this.label24.TabIndex = 103;
            this.label24.Text = "Vencimiento Reactivo:";
            // 
            // calVencimiento
            // 
            // 
            // 
            // 
            this.calVencimiento.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calVencimiento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVencimiento.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.calVencimiento.ButtonDropDown.Visible = true;
            this.calVencimiento.Enabled = false;
            this.calVencimiento.Location = new System.Drawing.Point(124, 134);
            // 
            // 
            // 
            this.calVencimiento.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calVencimiento.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calVencimiento.MonthCalendar.BackgroundStyle.Class = "";
            this.calVencimiento.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVencimiento.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calVencimiento.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calVencimiento.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calVencimiento.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calVencimiento.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calVencimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calVencimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calVencimiento.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calVencimiento.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVencimiento.MonthCalendar.DisplayMonth = new System.DateTime(2010, 11, 1, 0, 0, 0, 0);
            this.calVencimiento.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calVencimiento.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calVencimiento.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calVencimiento.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calVencimiento.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calVencimiento.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calVencimiento.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVencimiento.MonthCalendar.TodayButtonVisible = true;
            this.calVencimiento.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calVencimiento.Name = "calVencimiento";
            this.calVencimiento.Size = new System.Drawing.Size(181, 20);
            this.calVencimiento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.calVencimiento.TabIndex = 102;
            // 
            // txtNumeroLote
            // 
            this.txtNumeroLote.BackColor = System.Drawing.Color.White;
            this.txtNumeroLote.Location = new System.Drawing.Point(124, 111);
            this.txtNumeroLote.Name = "txtNumeroLote";
            this.txtNumeroLote.ReadOnly = true;
            this.txtNumeroLote.Size = new System.Drawing.Size(181, 20);
            this.txtNumeroLote.TabIndex = 101;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(9, 111);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 13);
            this.label23.TabIndex = 100;
            this.label23.Text = "Numero Lote:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 182);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 13);
            this.label21.TabIndex = 96;
            this.label21.Text = "Fabricante Equipo";
            // 
            // cmbFabricanteEquipo
            // 
            this.cmbFabricanteEquipo.DataSource = this.dsSpx1;
            this.cmbFabricanteEquipo.DisplayMember = "fabricante.nombre_fabricante";
            this.cmbFabricanteEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFabricanteEquipo.Enabled = false;
            this.cmbFabricanteEquipo.FormattingEnabled = true;
            this.cmbFabricanteEquipo.Location = new System.Drawing.Point(124, 183);
            this.cmbFabricanteEquipo.Name = "cmbFabricanteEquipo";
            this.cmbFabricanteEquipo.Size = new System.Drawing.Size(181, 21);
            this.cmbFabricanteEquipo.TabIndex = 97;
            this.cmbFabricanteEquipo.ValueMember = "fabricante.codFabricante";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 214);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(78, 13);
            this.label22.TabIndex = 94;
            this.label22.Text = "Modelo Equipo";
            // 
            // cmbModeloEquipo
            // 
            this.cmbModeloEquipo.DataSource = this.dsSpx1;
            this.cmbModeloEquipo.DisplayMember = "Modelos.NombreModelo";
            this.cmbModeloEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModeloEquipo.Enabled = false;
            this.cmbModeloEquipo.FormattingEnabled = true;
            this.cmbModeloEquipo.Location = new System.Drawing.Point(124, 211);
            this.cmbModeloEquipo.Name = "cmbModeloEquipo";
            this.cmbModeloEquipo.Size = new System.Drawing.Size(181, 21);
            this.cmbModeloEquipo.TabIndex = 95;
            this.cmbModeloEquipo.ValueMember = "Modelos.codModelo";
            // 
            // grdAccionesSeguir
            // 
            this.grdAccionesSeguir.AllowUpdate = false;
            this.grdAccionesSeguir.DataMember = "accion_seguir_cientifica";
            this.grdAccionesSeguir.DataSource = this.dsSpx1;
            this.grdAccionesSeguir.GroupByCaption = "Drag a column header here to group by that column";
            this.grdAccionesSeguir.Images.Add(((System.Drawing.Image)(resources.GetObject("grdAccionesSeguir.Images"))));
            this.grdAccionesSeguir.Location = new System.Drawing.Point(324, 150);
            this.grdAccionesSeguir.Name = "grdAccionesSeguir";
            this.grdAccionesSeguir.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdAccionesSeguir.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdAccionesSeguir.PreviewInfo.ZoomFactor = 75D;
            this.grdAccionesSeguir.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdAccionesSeguir.PrintInfo.PageSettings")));
            this.grdAccionesSeguir.Size = new System.Drawing.Size(232, 82);
            this.grdAccionesSeguir.TabIndex = 92;
            this.grdAccionesSeguir.Text = "c1TrueDBGrid1";
            this.grdAccionesSeguir.PropBag = resources.GetString("grdAccionesSeguir.PropBag");
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(321, 135);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(96, 13);
            this.label20.TabIndex = 88;
            this.label20.Text = "Acciones a Seguir:";
            // 
            // txtSerial
            // 
            this.txtSerial.BackColor = System.Drawing.Color.White;
            this.txtSerial.Location = new System.Drawing.Point(124, 158);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.ReadOnly = true;
            this.txtSerial.Size = new System.Drawing.Size(181, 20);
            this.txtSerial.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Serial:";
            // 
            // txtFabricanteReactivo
            // 
            this.txtFabricanteReactivo.BackColor = System.Drawing.Color.White;
            this.txtFabricanteReactivo.Location = new System.Drawing.Point(124, 86);
            this.txtFabricanteReactivo.Name = "txtFabricanteReactivo";
            this.txtFabricanteReactivo.ReadOnly = true;
            this.txtFabricanteReactivo.Size = new System.Drawing.Size(181, 20);
            this.txtFabricanteReactivo.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Fabricante Reactivo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Asesor Responsable:";
            // 
            // txtReactivo
            // 
            this.txtReactivo.codigo = "cod_referencia_reactivo";
            this.txtReactivo.DataMember = this.dsSpx1.referencia_reactivo;
            this.txtReactivo.DataSource = this.dsSpx1;
            this.txtReactivo.descripcion1 = "nombre_referencia_reactivo";
            this.txtReactivo.descripcion2 = "codigo_manual";
            this.txtReactivo.Enabled = false;
            this.txtReactivo.filtroAdicional = null;
            this.txtReactivo.LimiteY = 125;
            this.txtReactivo.linkPadre = null;
            this.txtReactivo.Location = new System.Drawing.Point(124, 63);
            this.txtReactivo.Name = "txtReactivo";
            this.txtReactivo.sentenciaFromObligatoria = null;
            this.txtReactivo.Size = new System.Drawing.Size(181, 20);
            this.txtReactivo.TabIndex = 41;
            this.txtReactivo.Tabla = this.dsSpx1.referencia_reactivo;
            this.txtReactivo.TamanoPopUp = 5;
            this.txtReactivo.txtPadre = null;
            this.txtReactivo.Value = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Reactivo:";
            // 
            // calRespuestaInicial
            // 
            this.calRespuestaInicial.BackColor = System.Drawing.Color.Transparent;
            this.calRespuestaInicial.Enabled = false;
            this.calRespuestaInicial.fechaValue = new System.DateTime(((long)(0)));
            this.calRespuestaInicial.fechaValueObject = null;
            this.calRespuestaInicial.Location = new System.Drawing.Point(111, 202);
            this.calRespuestaInicial.Name = "calRespuestaInicial";
            this.calRespuestaInicial.Size = new System.Drawing.Size(233, 21);
            this.calRespuestaInicial.TabIndex = 112;
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Location = new System.Drawing.Point(4, 196);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(94, 30);
            this.label26.TabIndex = 113;
            this.label26.Text = "Fecha Respuesta Inicial:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Location = new System.Drawing.Point(4, 148);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(98, 13);
            this.label27.TabIndex = 115;
            this.label27.Text = "Prioridad Asignada:";
            // 
            // cmbPrioridadAsignada
            // 
            this.cmbPrioridadAsignada.DataSource = this.dsSpx2;
            this.cmbPrioridadAsignada.DisplayMember = "prioridad_callcenter_cientifica.nombre_prioridad";
            this.cmbPrioridadAsignada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridadAsignada.Enabled = false;
            this.cmbPrioridadAsignada.FormattingEnabled = true;
            this.cmbPrioridadAsignada.Location = new System.Drawing.Point(111, 147);
            this.cmbPrioridadAsignada.Name = "cmbPrioridadAsignada";
            this.cmbPrioridadAsignada.Size = new System.Drawing.Size(181, 21);
            this.cmbPrioridadAsignada.TabIndex = 114;
            this.cmbPrioridadAsignada.ValueMember = "prioridad_callcenter_cientifica.cod_prioridad_callcenter_cientifica";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdDisponibilidad);
            this.groupBox1.Controls.Add(this.rdNoDisponibilidad);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(324, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 32);
            this.groupBox1.TabIndex = 116;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Llamada Disponibilidad";
            // 
            // rdDisponibilidad
            // 
            this.rdDisponibilidad.AutoSize = true;
            this.rdDisponibilidad.Location = new System.Drawing.Point(115, 11);
            this.rdDisponibilidad.Name = "rdDisponibilidad";
            this.rdDisponibilidad.Size = new System.Drawing.Size(34, 17);
            this.rdDisponibilidad.TabIndex = 0;
            this.rdDisponibilidad.TabStop = true;
            this.rdDisponibilidad.Text = "Si";
            this.rdDisponibilidad.UseVisualStyleBackColor = true;
            // 
            // rdNoDisponibilidad
            // 
            this.rdNoDisponibilidad.AutoSize = true;
            this.rdNoDisponibilidad.Location = new System.Drawing.Point(155, 11);
            this.rdNoDisponibilidad.Name = "rdNoDisponibilidad";
            this.rdNoDisponibilidad.Size = new System.Drawing.Size(39, 17);
            this.rdNoDisponibilidad.TabIndex = 1;
            this.rdNoDisponibilidad.TabStop = true;
            this.rdNoDisponibilidad.Text = "No";
            this.rdNoDisponibilidad.UseVisualStyleBackColor = true;
            // 
            // txtInformacionSuministradaInicial
            // 
            this.txtInformacionSuministradaInicial.BackColor = System.Drawing.Color.White;
            this.txtInformacionSuministradaInicial.Location = new System.Drawing.Point(5, 355);
            this.txtInformacionSuministradaInicial.Multiline = true;
            this.txtInformacionSuministradaInicial.Name = "txtInformacionSuministradaInicial";
            this.txtInformacionSuministradaInicial.ReadOnly = true;
            this.txtInformacionSuministradaInicial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInformacionSuministradaInicial.Size = new System.Drawing.Size(371, 58);
            this.txtInformacionSuministradaInicial.TabIndex = 100;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Location = new System.Drawing.Point(4, 339);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(221, 13);
            this.label28.TabIndex = 102;
            this.label28.Text = "Informacion Inicial Suministrada por el cliente:";
            // 
            // txtRespuestaInicial
            // 
            this.txtRespuestaInicial.BackColor = System.Drawing.Color.White;
            this.txtRespuestaInicial.Location = new System.Drawing.Point(5, 434);
            this.txtRespuestaInicial.Multiline = true;
            this.txtRespuestaInicial.Name = "txtRespuestaInicial";
            this.txtRespuestaInicial.ReadOnly = true;
            this.txtRespuestaInicial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRespuestaInicial.Size = new System.Drawing.Size(371, 39);
            this.txtRespuestaInicial.TabIndex = 99;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Location = new System.Drawing.Point(4, 416);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(195, 13);
            this.label29.TabIndex = 101;
            this.label29.Text = "Respuesta Inicial ofrecida por el asesor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(14, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 77;
            this.label6.Text = "Fecha de Cierre";
            // 
            // calCierre
            // 
            // 
            // 
            // 
            this.calCierre.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calCierre.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calCierre.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.calCierre.ButtonDropDown.Visible = true;
            this.calCierre.Enabled = false;
            this.calCierre.Location = new System.Drawing.Point(129, 66);
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
            this.calCierre.MonthCalendar.DisplayMonth = new System.DateTime(2010, 11, 1, 0, 0, 0, 0);
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
            this.calCierre.Size = new System.Drawing.Size(169, 20);
            this.calCierre.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.calCierre.TabIndex = 76;
            // 
            // cmbInconvenientePor
            // 
            this.cmbInconvenientePor.DataSource = this.dsSpx1;
            this.cmbInconvenientePor.DisplayMember = "inconveniente_presentado_cientifica.nombre_inconveniente";
            this.cmbInconvenientePor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInconvenientePor.Enabled = false;
            this.cmbInconvenientePor.FormattingEnabled = true;
            this.cmbInconvenientePor.Location = new System.Drawing.Point(498, 14);
            this.cmbInconvenientePor.Name = "cmbInconvenientePor";
            this.cmbInconvenientePor.Size = new System.Drawing.Size(190, 21);
            this.cmbInconvenientePor.TabIndex = 73;
            this.cmbInconvenientePor.ValueMember = "inconveniente_presentado_cientifica.cod_inconveniente_presentado_cientifica";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Location = new System.Drawing.Point(328, 17);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(154, 13);
            this.label31.TabIndex = 72;
            this.label31.Text = "Inconveniente Presentado Por:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label32);
            this.groupBox5.Controls.Add(this.txtPorqueNoConforme);
            this.groupBox5.Controls.Add(this.rdNoConforme);
            this.groupBox5.Controls.Add(this.rdSiConforme);
            this.groupBox5.Enabled = false;
            this.groupBox5.Location = new System.Drawing.Point(498, 91);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(453, 146);
            this.groupBox5.TabIndex = 71;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Conformidad con la respuesta:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(6, 21);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(47, 13);
            this.label32.TabIndex = 12;
            this.label32.Text = "Por que:";
            // 
            // txtPorqueNoConforme
            // 
            this.txtPorqueNoConforme.Enabled = false;
            this.txtPorqueNoConforme.Location = new System.Drawing.Point(5, 40);
            this.txtPorqueNoConforme.Multiline = true;
            this.txtPorqueNoConforme.Name = "txtPorqueNoConforme";
            this.txtPorqueNoConforme.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPorqueNoConforme.Size = new System.Drawing.Size(442, 100);
            this.txtPorqueNoConforme.TabIndex = 2;
            // 
            // rdNoConforme
            // 
            this.rdNoConforme.AutoSize = true;
            this.rdNoConforme.Location = new System.Drawing.Point(408, 15);
            this.rdNoConforme.Name = "rdNoConforme";
            this.rdNoConforme.Size = new System.Drawing.Size(39, 17);
            this.rdNoConforme.TabIndex = 1;
            this.rdNoConforme.TabStop = true;
            this.rdNoConforme.Text = "No";
            this.rdNoConforme.UseVisualStyleBackColor = true;
            // 
            // rdSiConforme
            // 
            this.rdSiConforme.AutoSize = true;
            this.rdSiConforme.Location = new System.Drawing.Point(368, 15);
            this.rdSiConforme.Name = "rdSiConforme";
            this.rdSiConforme.Size = new System.Drawing.Size(34, 17);
            this.rdSiConforme.TabIndex = 0;
            this.rdSiConforme.TabStop = true;
            this.rdSiConforme.Text = "Si";
            this.rdSiConforme.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label33);
            this.groupBox6.Controls.Add(this.txtPorqueNoSolucionado);
            this.groupBox6.Controls.Add(this.rdNoSolucionado);
            this.groupBox6.Controls.Add(this.rdSiSolucionado);
            this.groupBox6.Enabled = false;
            this.groupBox6.Location = new System.Drawing.Point(12, 92);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(480, 145);
            this.groupBox6.TabIndex = 70;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Requerimiento Solucionado Telefonicamente";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(6, 22);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(47, 13);
            this.label33.TabIndex = 12;
            this.label33.Text = "Por que:";
            // 
            // txtPorqueNoSolucionado
            // 
            this.txtPorqueNoSolucionado.Enabled = false;
            this.txtPorqueNoSolucionado.Location = new System.Drawing.Point(9, 39);
            this.txtPorqueNoSolucionado.Multiline = true;
            this.txtPorqueNoSolucionado.Name = "txtPorqueNoSolucionado";
            this.txtPorqueNoSolucionado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPorqueNoSolucionado.Size = new System.Drawing.Size(465, 100);
            this.txtPorqueNoSolucionado.TabIndex = 2;
            // 
            // rdNoSolucionado
            // 
            this.rdNoSolucionado.AutoSize = true;
            this.rdNoSolucionado.Location = new System.Drawing.Point(431, 20);
            this.rdNoSolucionado.Name = "rdNoSolucionado";
            this.rdNoSolucionado.Size = new System.Drawing.Size(39, 17);
            this.rdNoSolucionado.TabIndex = 1;
            this.rdNoSolucionado.TabStop = true;
            this.rdNoSolucionado.Text = "No";
            this.rdNoSolucionado.UseVisualStyleBackColor = true;
            // 
            // rdSiSolucionado
            // 
            this.rdSiSolucionado.AutoSize = true;
            this.rdSiSolucionado.Location = new System.Drawing.Point(391, 19);
            this.rdSiSolucionado.Name = "rdSiSolucionado";
            this.rdSiSolucionado.Size = new System.Drawing.Size(34, 17);
            this.rdSiSolucionado.TabIndex = 0;
            this.rdSiSolucionado.TabStop = true;
            this.rdSiSolucionado.Text = "Si";
            this.rdSiSolucionado.UseVisualStyleBackColor = true;
            // 
            // txtReporteCalidad
            // 
            this.txtReporteCalidad.Enabled = false;
            this.txtReporteCalidad.Location = new System.Drawing.Point(498, 41);
            this.txtReporteCalidad.Name = "txtReporteCalidad";
            this.txtReporteCalidad.Size = new System.Drawing.Size(190, 20);
            this.txtReporteCalidad.TabIndex = 69;
            // 
            // numDiasSolcuonar
            // 
            this.numDiasSolcuonar.Enabled = false;
            this.numDiasSolcuonar.Location = new System.Drawing.Point(129, 40);
            this.numDiasSolcuonar.Name = "numDiasSolcuonar";
            this.numDiasSolcuonar.Size = new System.Drawing.Size(120, 20);
            this.numDiasSolcuonar.TabIndex = 68;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Location = new System.Drawing.Point(328, 44);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(162, 13);
            this.label34.TabIndex = 67;
            this.label34.Text = "Numero Reporte Control Calidad:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Location = new System.Drawing.Point(14, 40);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(99, 13);
            this.label35.TabIndex = 66;
            this.label35.Text = "Dias en Solucionar:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Location = new System.Drawing.Point(14, 14);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(80, 13);
            this.label36.TabIndex = 65;
            this.label36.Text = "Fecha de Visita";
            // 
            // calVisita
            // 
            // 
            // 
            // 
            this.calVisita.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calVisita.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVisita.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.calVisita.ButtonDropDown.Visible = true;
            this.calVisita.Enabled = false;
            this.calVisita.Location = new System.Drawing.Point(129, 14);
            // 
            // 
            // 
            this.calVisita.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calVisita.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calVisita.MonthCalendar.BackgroundStyle.Class = "";
            this.calVisita.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVisita.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calVisita.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calVisita.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calVisita.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calVisita.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calVisita.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calVisita.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calVisita.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calVisita.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVisita.MonthCalendar.DisplayMonth = new System.DateTime(2010, 11, 1, 0, 0, 0, 0);
            this.calVisita.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calVisita.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calVisita.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calVisita.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calVisita.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calVisita.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calVisita.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVisita.MonthCalendar.TodayButtonVisible = true;
            this.calVisita.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calVisita.Name = "calVisita";
            this.calVisita.Size = new System.Drawing.Size(169, 20);
            this.calVisita.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.calVisita.TabIndex = 64;
            // 
            // dsSpx2
            // 
            this.dsSpx2.DataSetName = "dsSpx";
            this.dsSpx2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inconveniente_presentado_cientificaTableAdapter1
            // 
            this.inconveniente_presentado_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // frmGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 562);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(901, 600);
            this.Name = "frmGeneral";
            this.Text = "Aseoria Cientifica";
            this.Load += new System.EventHandler(this.frmEnseguimiento_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSeguimentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaSolicitud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.tabControlPanel1.PerformLayout();
            this.tabControlPanel2.ResumeLayout(false);
            this.tabControlPanel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calVencimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccionesSeguir)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calCierre)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiasSolcuonar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calVisita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdSeguimentos;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.ButtonX btnExportarSeguimientos;
        private DevComponents.DotNetBar.ButtonX btnVerSeguimiento;
        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.prioridad_callcenter_cientificaTableAdapter prioridad_callcenter_cientificaTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.sucursalClienteTableAdapter sucursalClienteTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.contactosClientesTableAdapter contactosClientesTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.asesoria_cientificaTableAdapter asesoria_cientificaTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.estado_asesoria_cientificaTableAdapter estado_asesoria_cientificaTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.clientesTableAdapter clientesTableAdapter1;
        private System.Windows.Forms.TextBox txtNumeroAsesoria;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private DevComponents.DotNetBar.ButtonX btnInfSucursal;
        private System.Windows.Forms.TextBox txtNombrecliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.TextBox txtInfAdiContacto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCelularContacto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTelefonoContacto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNombreContacto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRegistadaPor;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.TextBox txtMotivoConsulta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label17;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFechaSolicitud;
        private SPControladoraDatos.dsSpxTableAdapters.seguimiento_asesoria_cientificaTableAdapter seguimiento_asesoria_cientificaTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.accion_seguirxasesoria_cientificaTableAdapter accion_seguirxasesoria_cientificaTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.accion_seguir_cientificaTableAdapter accion_seguir_cientificaTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.fabricanteTableAdapter fabricanteTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter modelosTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.referencia_reactivoTableAdapter referencia_reactivoTableAdapter1;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label1;
        private SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter equiposTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.solicitudServicioTableAdapter solicitudServicioTableAdapter1;
        private DevComponents.DotNetBar.ButtonX btnTareasProgramadas;
        private SPControladoraDatos.dsSpxTableAdapters.LlamadaSoportePreTableAdapter llamadaSoportePreTableAdapter1;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad1;
        private SPXSeguridad.data.cls.clsTusuario clsTusuario1;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.calFecha calSugerida;
        private System.Windows.Forms.Label label18;
        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.TabItem tabItem2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbUsuarioInterno;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtCodLlamada;
        private System.Windows.Forms.CheckBox chkInterna;
        private System.Windows.Forms.CheckBox chkIndicaNoEquipo;
        private System.Windows.Forms.TextBox txtAsesorResponsable;
        private System.Windows.Forms.Label label24;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calVencimiento;
        private System.Windows.Forms.TextBox txtNumeroLote;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cmbFabricanteEquipo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cmbModeloEquipo;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdAccionesSeguir;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFabricanteReactivo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.txtBusqueda txtReactivo;
        private System.Windows.Forms.Label label5;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.calFecha calRespuestaInicial;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cmbPrioridadAsignada;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdDisponibilidad;
        private System.Windows.Forms.RadioButton rdNoDisponibilidad;
        private System.Windows.Forms.TextBox txtInformacionSuministradaInicial;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtRespuestaInicial;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label6;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calCierre;
        private System.Windows.Forms.ComboBox cmbInconvenientePor;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtPorqueNoConforme;
        private System.Windows.Forms.RadioButton rdNoConforme;
        private System.Windows.Forms.RadioButton rdSiConforme;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtPorqueNoSolucionado;
        private System.Windows.Forms.RadioButton rdNoSolucionado;
        private System.Windows.Forms.RadioButton rdSiSolucionado;
        private System.Windows.Forms.TextBox txtReporteCalidad;
        private System.Windows.Forms.NumericUpDown numDiasSolcuonar;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calVisita;
        private SPControladoraDatos.dsSpx dsSpx2;
        private SPControladoraDatos.dsSpxTableAdapters.inconveniente_presentado_cientificaTableAdapter inconveniente_presentado_cientificaTableAdapter1;
    }
}