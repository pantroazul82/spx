namespace spProcesos.cientifica.proceso
{
    partial class frmAceptarOrden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAceptarOrden));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.prioridad_callcenter_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.prioridad_callcenter_cientificaTableAdapter();
            this.sucursalClienteTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.sucursalClienteTableAdapter();
            this.contactosClientesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.contactosClientesTableAdapter();
            this.txtNumeroAsesoria = new System.Windows.Forms.TextBox();
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.btnInfSucursal = new DevComponents.DotNetBar.ButtonX();
            this.btnInfCliente = new DevComponents.DotNetBar.ButtonX();
            this.txtNombrecliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnInfoContacto = new DevComponents.DotNetBar.ButtonX();
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
            this.label1 = new System.Windows.Forms.Label();
            this.calFechaSolicitud = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.calSugerida = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.calFecha();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscarReactivo = new DevComponents.DotNetBar.ButtonX();
            this.txtReactivo = new System.Windows.Forms.TextBox();
            this.btnEditarAsesorResponsable = new DevComponents.DotNetBar.ButtonX();
            this.calRespuestaInicial = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.calFecha();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbUsuarioInterno = new System.Windows.Forms.ComboBox();
            this.dsSPXSeguridad2 = new SPXSeguridad.data.dsSPXSeguridad();
            this.label25 = new System.Windows.Forms.Label();
            this.chkIndicaNoEquipo = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdDisponibilidad = new System.Windows.Forms.RadioButton();
            this.rdNoDisponibilidad = new System.Windows.Forms.RadioButton();
            this.chkInterna = new System.Windows.Forms.CheckBox();
            this.label24 = new System.Windows.Forms.Label();
            this.calVencimiento = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtNumeroLote = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtInformacionSuministradaInicial = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cmbFabricanteEquipo = new System.Windows.Forms.ComboBox();
            this.dsSpx2 = new SPControladoraDatos.dsSpx();
            this.label22 = new System.Windows.Forms.Label();
            this.cmbModeloEquipo = new System.Windows.Forms.ComboBox();
            this.btnBuscarSerial = new DevComponents.DotNetBar.ButtonX();
            this.grdAccionesSeguir = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.btnEliminar = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregar = new DevComponents.DotNetBar.ButtonX();
            this.label20 = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFabricanteReactivo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAsesorResponsable = new System.Windows.Forms.ComboBox();
            this.dsSPXSeguridad1 = new SPXSeguridad.data.dsSPXSeguridad();
            this.txtRespuestaInicial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPrioridadAsignada = new System.Windows.Forms.ComboBox();
            this.clientesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.clientesTableAdapter();
            this.asesoria_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.asesoria_cientificaTableAdapter();
            this.referencia_reactivoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.referencia_reactivoTableAdapter();
            this.fabricanteTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.fabricanteTableAdapter();
            this.modelosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter();
            this.equiposTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter();
            this.accion_seguir_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.accion_seguir_cientificaTableAdapter();
            this.accion_seguirxasesoria_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.accion_seguirxasesoria_cientificaTableAdapter();
            this.estado_asesoria_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.estado_asesoria_cientificaTableAdapter();
            this.referencia_reactivoTableAdapter2 = new SPControladoraDatos.dsSpxTableAdapters.referencia_reactivoTableAdapter();
            this.clsTusuario1 = new SPXSeguridad.data.cls.clsTusuario();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.grpCliente.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaSolicitud)).BeginInit();
            this.grpGeneral.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calVencimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccionesSeguir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 563);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 51);
            this.panel1.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(675, 16);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(756, 16);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            // txtNumeroAsesoria
            // 
            this.txtNumeroAsesoria.BackColor = System.Drawing.Color.White;
            this.txtNumeroAsesoria.Location = new System.Drawing.Point(130, 14);
            this.txtNumeroAsesoria.Name = "txtNumeroAsesoria";
            this.txtNumeroAsesoria.ReadOnly = true;
            this.txtNumeroAsesoria.Size = new System.Drawing.Size(181, 20);
            this.txtNumeroAsesoria.TabIndex = 41;
            // 
            // grpCliente
            // 
            this.grpCliente.BackColor = System.Drawing.Color.Transparent;
            this.grpCliente.Controls.Add(this.cmbSucursal);
            this.grpCliente.Controls.Add(this.btnInfSucursal);
            this.grpCliente.Controls.Add(this.btnInfCliente);
            this.grpCliente.Controls.Add(this.txtNombrecliente);
            this.grpCliente.Controls.Add(this.label12);
            this.grpCliente.Controls.Add(this.groupBox2);
            this.grpCliente.Controls.Add(this.label19);
            this.grpCliente.Location = new System.Drawing.Point(394, 5);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Size = new System.Drawing.Size(440, 208);
            this.grpCliente.TabIndex = 40;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Informacion del Cliente";
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
            this.cmbSucursal.Size = new System.Drawing.Size(251, 21);
            this.cmbSucursal.TabIndex = 30;
            this.cmbSucursal.ValueMember = "sucursalCliente.codSucursal";
            // 
            // btnInfSucursal
            // 
            this.btnInfSucursal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInfSucursal.Image = ((System.Drawing.Image)(resources.GetObject("btnInfSucursal.Image")));
            this.btnInfSucursal.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnInfSucursal.Location = new System.Drawing.Point(316, 44);
            this.btnInfSucursal.Name = "btnInfSucursal";
            this.btnInfSucursal.Size = new System.Drawing.Size(28, 28);
            this.btnInfSucursal.TabIndex = 86;
            this.btnInfSucursal.Click += new System.EventHandler(this.btnInfSucursal_Click);
            // 
            // btnInfCliente
            // 
            this.btnInfCliente.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInfCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnInfCliente.Image")));
            this.btnInfCliente.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnInfCliente.Location = new System.Drawing.Point(353, 16);
            this.btnInfCliente.Name = "btnInfCliente";
            this.btnInfCliente.Size = new System.Drawing.Size(28, 28);
            this.btnInfCliente.TabIndex = 85;
            this.btnInfCliente.Click += new System.EventHandler(this.btnInfCliente_Click);
            // 
            // txtNombrecliente
            // 
            this.txtNombrecliente.Enabled = false;
            this.txtNombrecliente.Location = new System.Drawing.Point(61, 20);
            this.txtNombrecliente.Name = "txtNombrecliente";
            this.txtNombrecliente.ReadOnly = true;
            this.txtNombrecliente.Size = new System.Drawing.Size(286, 20);
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
            this.groupBox2.Controls.Add(this.btnInfoContacto);
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
            this.groupBox2.Size = new System.Drawing.Size(417, 134);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contacto";
            // 
            // btnInfoContacto
            // 
            this.btnInfoContacto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInfoContacto.Image = ((System.Drawing.Image)(resources.GetObject("btnInfoContacto.Image")));
            this.btnInfoContacto.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnInfoContacto.Location = new System.Drawing.Point(309, 18);
            this.btnInfoContacto.Name = "btnInfoContacto";
            this.btnInfoContacto.Size = new System.Drawing.Size(28, 28);
            this.btnInfoContacto.TabIndex = 86;
            this.btnInfoContacto.Click += new System.EventHandler(this.btnInfoContacto_Click);
            // 
            // txtInfAdiContacto
            // 
            this.txtInfAdiContacto.Enabled = false;
            this.txtInfAdiContacto.Location = new System.Drawing.Point(120, 80);
            this.txtInfAdiContacto.Multiline = true;
            this.txtInfAdiContacto.Name = "txtInfAdiContacto";
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
            this.txtCelularContacto.Enabled = false;
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
            this.txtTelefonoContacto.Enabled = false;
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
            this.txtNombreContacto.Enabled = false;
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
            this.label11.Location = new System.Drawing.Point(15, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Asesoria Num:";
            // 
            // txtRegistadaPor
            // 
            this.txtRegistadaPor.BackColor = System.Drawing.Color.White;
            this.txtRegistadaPor.Location = new System.Drawing.Point(130, 66);
            this.txtRegistadaPor.Name = "txtRegistadaPor";
            this.txtRegistadaPor.ReadOnly = true;
            this.txtRegistadaPor.Size = new System.Drawing.Size(181, 20);
            this.txtRegistadaPor.TabIndex = 38;
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.DataSource = this.dsSpx1;
            this.cmbPrioridad.DisplayMember = "prioridad_callcenter_cientifica.nombre_prioridad";
            this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Location = new System.Drawing.Point(130, 96);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(181, 21);
            this.cmbPrioridad.TabIndex = 37;
            this.cmbPrioridad.ValueMember = "prioridad_callcenter_cientifica.cod_prioridad_callcenter_cientifica";
            // 
            // txtMotivoConsulta
            // 
            this.txtMotivoConsulta.Location = new System.Drawing.Point(18, 167);
            this.txtMotivoConsulta.Multiline = true;
            this.txtMotivoConsulta.Name = "txtMotivoConsulta";
            this.txtMotivoConsulta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMotivoConsulta.Size = new System.Drawing.Size(336, 34);
            this.txtMotivoConsulta.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Motivo de la Consulta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Prioridad Sugerida:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Registada Por:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Fecha de Solicitud:";
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
            this.calFechaSolicitud.Location = new System.Drawing.Point(130, 40);
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
            this.calFechaSolicitud.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
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
            this.calFechaSolicitud.TabIndex = 31;
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.label26);
            this.grpGeneral.Controls.Add(this.calSugerida);
            this.grpGeneral.Controls.Add(this.txtMotivoConsulta);
            this.grpGeneral.Controls.Add(this.txtNumeroAsesoria);
            this.grpGeneral.Controls.Add(this.calFechaSolicitud);
            this.grpGeneral.Controls.Add(this.label1);
            this.grpGeneral.Controls.Add(this.label11);
            this.grpGeneral.Controls.Add(this.label2);
            this.grpGeneral.Controls.Add(this.txtRegistadaPor);
            this.grpGeneral.Controls.Add(this.label3);
            this.grpGeneral.Controls.Add(this.cmbPrioridad);
            this.grpGeneral.Controls.Add(this.label10);
            this.grpGeneral.Enabled = false;
            this.grpGeneral.Location = new System.Drawing.Point(12, 4);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(369, 209);
            this.grpGeneral.TabIndex = 42;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "Informacion General";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(17, 129);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(85, 13);
            this.label26.TabIndex = 43;
            this.label26.Text = "Fecha Sugerida:";
            // 
            // calSugerida
            // 
            this.calSugerida.BackColor = System.Drawing.Color.Transparent;
            this.calSugerida.Enabled = false;
            this.calSugerida.fechaValue = new System.DateTime(((long)(0)));
            this.calSugerida.fechaValueObject = null;
            this.calSugerida.Location = new System.Drawing.Point(130, 125);
            this.calSugerida.Name = "calSugerida";
            this.calSugerida.Size = new System.Drawing.Size(216, 21);
            this.calSugerida.TabIndex = 42;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscarReactivo);
            this.groupBox3.Controls.Add(this.txtReactivo);
            this.groupBox3.Controls.Add(this.btnEditarAsesorResponsable);
            this.groupBox3.Controls.Add(this.calRespuestaInicial);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.cmbUsuarioInterno);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.chkIndicaNoEquipo);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.chkInterna);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.calVencimiento);
            this.groupBox3.Controls.Add(this.txtNumeroLote);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.txtInformacionSuministradaInicial);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.cmbFabricanteEquipo);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.cmbModeloEquipo);
            this.groupBox3.Controls.Add(this.btnBuscarSerial);
            this.groupBox3.Controls.Add(this.grdAccionesSeguir);
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.btnAgregar);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.txtSerial);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtFabricanteReactivo);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cmbAsesorResponsable);
            this.groupBox3.Controls.Add(this.txtRespuestaInicial);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cmbPrioridadAsignada);
            this.groupBox3.Location = new System.Drawing.Point(15, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(812, 327);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion Aceptacion";
            // 
            // btnBuscarReactivo
            // 
            this.btnBuscarReactivo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscarReactivo.CausesValidation = false;
            this.btnBuscarReactivo.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarReactivo.Image")));
            this.btnBuscarReactivo.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnBuscarReactivo.Location = new System.Drawing.Point(338, 138);
            this.btnBuscarReactivo.Name = "btnBuscarReactivo";
            this.btnBuscarReactivo.Size = new System.Drawing.Size(28, 28);
            this.btnBuscarReactivo.TabIndex = 106;
            this.btnBuscarReactivo.Click += new System.EventHandler(this.btnBuscarReactivo_Click);
            // 
            // txtReactivo
            // 
            this.txtReactivo.BackColor = System.Drawing.Color.White;
            this.txtReactivo.Location = new System.Drawing.Point(131, 145);
            this.txtReactivo.Name = "txtReactivo";
            this.txtReactivo.Size = new System.Drawing.Size(202, 20);
            this.txtReactivo.TabIndex = 105;
            this.txtReactivo.Validated += new System.EventHandler(this.txtReactivo_Validated_1);
            // 
            // btnEditarAsesorResponsable
            // 
            this.btnEditarAsesorResponsable.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEditarAsesorResponsable.CausesValidation = false;
            this.btnEditarAsesorResponsable.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarAsesorResponsable.Image")));
            this.btnEditarAsesorResponsable.ImageFixedSize = new System.Drawing.Size(18, 18);
            this.btnEditarAsesorResponsable.Location = new System.Drawing.Point(313, 61);
            this.btnEditarAsesorResponsable.Name = "btnEditarAsesorResponsable";
            this.btnEditarAsesorResponsable.Size = new System.Drawing.Size(22, 22);
            this.btnEditarAsesorResponsable.TabIndex = 104;
            this.btnEditarAsesorResponsable.Tooltip = "Editar Asesor Responsable";
            this.btnEditarAsesorResponsable.Click += new System.EventHandler(this.btnEditarAsesorResponsable_Click);
            // 
            // calRespuestaInicial
            // 
            this.calRespuestaInicial.BackColor = System.Drawing.Color.Transparent;
            this.calRespuestaInicial.Enabled = false;
            this.calRespuestaInicial.fechaValue = new System.DateTime(((long)(0)));
            this.calRespuestaInicial.fechaValueObject = null;
            this.calRespuestaInicial.Location = new System.Drawing.Point(117, 34);
            this.calRespuestaInicial.Name = "calRespuestaInicial";
            this.calRespuestaInicial.Size = new System.Drawing.Size(216, 21);
            this.calRespuestaInicial.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(14, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(138, 30);
            this.label18.TabIndex = 51;
            this.label18.Text = "Fecha Respuesta Inicial:";
            // 
            // cmbUsuarioInterno
            // 
            this.cmbUsuarioInterno.DataSource = this.dsSPXSeguridad2;
            this.cmbUsuarioInterno.DisplayMember = "usuario.nombre";
            this.cmbUsuarioInterno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuarioInterno.Enabled = false;
            this.cmbUsuarioInterno.FormattingEnabled = true;
            this.cmbUsuarioInterno.Location = new System.Drawing.Point(622, 302);
            this.cmbUsuarioInterno.Name = "cmbUsuarioInterno";
            this.cmbUsuarioInterno.Size = new System.Drawing.Size(181, 21);
            this.cmbUsuarioInterno.TabIndex = 19;
            this.cmbUsuarioInterno.ValueMember = "usuario.login";
            // 
            // dsSPXSeguridad2
            // 
            this.dsSPXSeguridad2.DataSetName = "dsSPXSeguridad";
            this.dsSPXSeguridad2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(534, 307);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(82, 13);
            this.label25.TabIndex = 46;
            this.label25.Text = "Usuario Interno:";
            // 
            // chkIndicaNoEquipo
            // 
            this.chkIndicaNoEquipo.AutoSize = true;
            this.chkIndicaNoEquipo.Location = new System.Drawing.Point(129, 125);
            this.chkIndicaNoEquipo.Name = "chkIndicaNoEquipo";
            this.chkIndicaNoEquipo.Size = new System.Drawing.Size(183, 17);
            this.chkIndicaNoEquipo.TabIndex = 3;
            this.chkIndicaNoEquipo.Text = "Llamada sin Equipo y/o Reactivo";
            this.chkIndicaNoEquipo.UseVisualStyleBackColor = true;
            this.chkIndicaNoEquipo.CheckedChanged += new System.EventHandler(this.chkIndicaNoEquipo_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdDisponibilidad);
            this.groupBox1.Controls.Add(this.rdNoDisponibilidad);
            this.groupBox1.Location = new System.Drawing.Point(607, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 32);
            this.groupBox1.TabIndex = 12;
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
            this.rdDisponibilidad.CheckedChanged += new System.EventHandler(this.rdDisponibilidad_CheckedChanged);
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
            // chkInterna
            // 
            this.chkInterna.AutoSize = true;
            this.chkInterna.Enabled = false;
            this.chkInterna.Location = new System.Drawing.Point(395, 304);
            this.chkInterna.Name = "chkInterna";
            this.chkInterna.Size = new System.Drawing.Size(102, 17);
            this.chkInterna.TabIndex = 18;
            this.chkInterna.Text = "Llamada Interna";
            this.chkInterna.UseVisualStyleBackColor = true;
            this.chkInterna.CheckedChanged += new System.EventHandler(this.chkInterna_CheckedChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(14, 218);
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
            this.calVencimiento.Location = new System.Drawing.Point(129, 217);
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
            this.calVencimiento.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
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
            this.calVencimiento.TabIndex = 7;
            // 
            // txtNumeroLote
            // 
            this.txtNumeroLote.BackColor = System.Drawing.Color.White;
            this.txtNumeroLote.Location = new System.Drawing.Point(129, 194);
            this.txtNumeroLote.Name = "txtNumeroLote";
            this.txtNumeroLote.Size = new System.Drawing.Size(237, 20);
            this.txtNumeroLote.TabIndex = 6;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(14, 194);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 13);
            this.label23.TabIndex = 100;
            this.label23.Text = "Numero Lote:";
            // 
            // txtInformacionSuministradaInicial
            // 
            this.txtInformacionSuministradaInicial.Location = new System.Drawing.Point(387, 42);
            this.txtInformacionSuministradaInicial.Multiline = true;
            this.txtInformacionSuministradaInicial.Name = "txtInformacionSuministradaInicial";
            this.txtInformacionSuministradaInicial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInformacionSuministradaInicial.Size = new System.Drawing.Size(417, 58);
            this.txtInformacionSuministradaInicial.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(386, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(221, 13);
            this.label17.TabIndex = 98;
            this.label17.Text = "Informacion Inicial Suministrada por el cliente:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(14, 270);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 13);
            this.label21.TabIndex = 96;
            this.label21.Text = "Fabricante Equipo";
            // 
            // cmbFabricanteEquipo
            // 
            this.cmbFabricanteEquipo.DataSource = this.dsSpx2;
            this.cmbFabricanteEquipo.DisplayMember = "fabricante.nombre_fabricante";
            this.cmbFabricanteEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFabricanteEquipo.FormattingEnabled = true;
            this.cmbFabricanteEquipo.Location = new System.Drawing.Point(131, 267);
            this.cmbFabricanteEquipo.Name = "cmbFabricanteEquipo";
            this.cmbFabricanteEquipo.Size = new System.Drawing.Size(181, 21);
            this.cmbFabricanteEquipo.TabIndex = 10;
            this.cmbFabricanteEquipo.ValueMember = "fabricante.codFabricante";
            this.cmbFabricanteEquipo.SelectedIndexChanged += new System.EventHandler(this.cmbFabricanteEquipo_SelectedIndexChanged);
            // 
            // dsSpx2
            // 
            this.dsSpx2.DataSetName = "dsSpx";
            this.dsSpx2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(14, 300);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(78, 13);
            this.label22.TabIndex = 94;
            this.label22.Text = "Modelo Equipo";
            // 
            // cmbModeloEquipo
            // 
            this.cmbModeloEquipo.DataSource = this.dsSpx2;
            this.cmbModeloEquipo.DisplayMember = "Modelos.NombreModelo";
            this.cmbModeloEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModeloEquipo.FormattingEnabled = true;
            this.cmbModeloEquipo.Location = new System.Drawing.Point(131, 297);
            this.cmbModeloEquipo.Name = "cmbModeloEquipo";
            this.cmbModeloEquipo.Size = new System.Drawing.Size(181, 21);
            this.cmbModeloEquipo.TabIndex = 11;
            this.cmbModeloEquipo.ValueMember = "Modelos.codModelo";
            // 
            // btnBuscarSerial
            // 
            this.btnBuscarSerial.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscarSerial.CausesValidation = false;
            this.btnBuscarSerial.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarSerial.Image")));
            this.btnBuscarSerial.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnBuscarSerial.Location = new System.Drawing.Point(317, 236);
            this.btnBuscarSerial.Name = "btnBuscarSerial";
            this.btnBuscarSerial.Size = new System.Drawing.Size(28, 28);
            this.btnBuscarSerial.TabIndex = 9;
            this.btnBuscarSerial.Click += new System.EventHandler(this.btnBuscarSerial_Click);
            // 
            // grdAccionesSeguir
            // 
            this.grdAccionesSeguir.AllowUpdate = false;
            this.grdAccionesSeguir.DataMember = "accion_seguir_cientifica";
            this.grdAccionesSeguir.DataSource = this.dsSpx1;
            this.grdAccionesSeguir.GroupByCaption = "Drag a column header here to group by that column";
            this.grdAccionesSeguir.Images.Add(((System.Drawing.Image)(resources.GetObject("grdAccionesSeguir.Images"))));
            this.grdAccionesSeguir.Location = new System.Drawing.Point(395, 210);
            this.grdAccionesSeguir.Name = "grdAccionesSeguir";
            this.grdAccionesSeguir.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdAccionesSeguir.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdAccionesSeguir.PreviewInfo.ZoomFactor = 75D;
            this.grdAccionesSeguir.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdAccionesSeguir.PrintInfo.PageSettings")));
            this.grdAccionesSeguir.Size = new System.Drawing.Size(411, 87);
            this.grdAccionesSeguir.TabIndex = 17;
            this.grdAccionesSeguir.Text = "c1TrueDBGrid1";
            this.grdAccionesSeguir.PropBag = resources.GetString("grdAccionesSeguir.PropBag");
            // 
            // btnEliminar
            // 
            this.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageFixedSize = new System.Drawing.Size(18, 18);
            this.btnEliminar.Location = new System.Drawing.Point(778, 176);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(28, 28);
            this.btnEliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnAgregar.Location = new System.Drawing.Point(747, 176);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(28, 28);
            this.btnAgregar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(392, 191);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(126, 13);
            this.label20.TabIndex = 88;
            this.label20.Text = "Acciones a Seguir Inicial:";
            // 
            // txtSerial
            // 
            this.txtSerial.BackColor = System.Drawing.Color.White;
            this.txtSerial.Location = new System.Drawing.Point(129, 241);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(181, 20);
            this.txtSerial.TabIndex = 8;
            this.txtSerial.Validated += new System.EventHandler(this.txtSerial_Validated);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Serial:";
            // 
            // txtFabricanteReactivo
            // 
            this.txtFabricanteReactivo.BackColor = System.Drawing.Color.White;
            this.txtFabricanteReactivo.Location = new System.Drawing.Point(129, 172);
            this.txtFabricanteReactivo.Name = "txtFabricanteReactivo";
            this.txtFabricanteReactivo.ReadOnly = true;
            this.txtFabricanteReactivo.Size = new System.Drawing.Size(237, 20);
            this.txtFabricanteReactivo.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Fabricante Reactivo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Asesor Responsable:";
            // 
            // cmbAsesorResponsable
            // 
            this.cmbAsesorResponsable.DataSource = this.dsSPXSeguridad1;
            this.cmbAsesorResponsable.DisplayMember = "usuario.nombre";
            this.cmbAsesorResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAsesorResponsable.FormattingEnabled = true;
            this.cmbAsesorResponsable.Location = new System.Drawing.Point(129, 62);
            this.cmbAsesorResponsable.Name = "cmbAsesorResponsable";
            this.cmbAsesorResponsable.Size = new System.Drawing.Size(181, 21);
            this.cmbAsesorResponsable.TabIndex = 1;
            this.cmbAsesorResponsable.ValueMember = "usuario.login";
            // 
            // dsSPXSeguridad1
            // 
            this.dsSPXSeguridad1.DataSetName = "dsSPXSeguridad";
            this.dsSPXSeguridad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtRespuestaInicial
            // 
            this.txtRespuestaInicial.Location = new System.Drawing.Point(389, 125);
            this.txtRespuestaInicial.Multiline = true;
            this.txtRespuestaInicial.Name = "txtRespuestaInicial";
            this.txtRespuestaInicial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRespuestaInicial.Size = new System.Drawing.Size(412, 45);
            this.txtRespuestaInicial.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Respuesta Inicial ofrecida por el asesor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Reactivo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Prioridad Asignada:";
            // 
            // cmbPrioridadAsignada
            // 
            this.cmbPrioridadAsignada.DataSource = this.dsSpx2;
            this.cmbPrioridadAsignada.DisplayMember = "prioridad_callcenter_cientifica.nombre_prioridad";
            this.cmbPrioridadAsignada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridadAsignada.FormattingEnabled = true;
            this.cmbPrioridadAsignada.Location = new System.Drawing.Point(129, 92);
            this.cmbPrioridadAsignada.Name = "cmbPrioridadAsignada";
            this.cmbPrioridadAsignada.Size = new System.Drawing.Size(181, 21);
            this.cmbPrioridadAsignada.TabIndex = 2;
            this.cmbPrioridadAsignada.ValueMember = "prioridad_callcenter_cientifica.cod_prioridad_callcenter_cientifica";
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // asesoria_cientificaTableAdapter1
            // 
            this.asesoria_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // referencia_reactivoTableAdapter1
            // 
            this.referencia_reactivoTableAdapter1.ClearBeforeFill = true;
            // 
            // fabricanteTableAdapter1
            // 
            this.fabricanteTableAdapter1.ClearBeforeFill = true;
            // 
            // modelosTableAdapter1
            // 
            this.modelosTableAdapter1.ClearBeforeFill = true;
            // 
            // equiposTableAdapter1
            // 
            this.equiposTableAdapter1.ClearBeforeFill = true;
            // 
            // accion_seguir_cientificaTableAdapter1
            // 
            this.accion_seguir_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // accion_seguirxasesoria_cientificaTableAdapter1
            // 
            this.accion_seguirxasesoria_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // estado_asesoria_cientificaTableAdapter1
            // 
            this.estado_asesoria_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // referencia_reactivoTableAdapter2
            // 
            this.referencia_reactivoTableAdapter2.ClearBeforeFill = true;
            // 
            // clsTusuario1
            // 
            this.clsTusuario1.nombreLlave = "cod_usuario";
            this.clsTusuario1.nombreTabla = "usuario";
            this.clsTusuario1.sentenciaBase = resources.GetString("clsTusuario1.sentenciaBase");
            this.clsTusuario1.sentenciaBaseDistinct = resources.GetString("clsTusuario1.sentenciaBaseDistinct");
            // 
            // frmAceptarOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(843, 614);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpGeneral);
            this.Controls.Add(this.grpCliente);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(849, 638);
            this.MinimumSize = new System.Drawing.Size(849, 638);
            this.Name = "frmAceptarOrden";
            this.Text = "Aceptar Orden";
            this.Load += new System.EventHandler(this.frmAceptarOrden_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaSolicitud)).EndInit();
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calVencimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccionesSeguir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.prioridad_callcenter_cientificaTableAdapter prioridad_callcenter_cientificaTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.sucursalClienteTableAdapter sucursalClienteTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.contactosClientesTableAdapter contactosClientesTableAdapter1;
        private System.Windows.Forms.TextBox txtNumeroAsesoria;
        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private DevComponents.DotNetBar.ButtonX btnInfSucursal;
        private DevComponents.DotNetBar.ButtonX btnInfCliente;
        private System.Windows.Forms.TextBox txtNombrecliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.ButtonX btnInfoContacto;
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
        private System.Windows.Forms.Label label1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFechaSolicitud;
        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFabricanteReactivo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbAsesorResponsable;
        private System.Windows.Forms.TextBox txtRespuestaInicial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPrioridadAsignada;
        private DevComponents.DotNetBar.ButtonX btnBuscarSerial;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdAccionesSeguir;
        private DevComponents.DotNetBar.ButtonX btnEliminar;
        private DevComponents.DotNetBar.ButtonX btnAgregar;
        private SPControladoraDatos.dsSpx dsSpx2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cmbFabricanteEquipo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cmbModeloEquipo;
        private SPControladoraDatos.dsSpxTableAdapters.clientesTableAdapter clientesTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.asesoria_cientificaTableAdapter asesoria_cientificaTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.referencia_reactivoTableAdapter referencia_reactivoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.fabricanteTableAdapter fabricanteTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter modelosTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter equiposTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.accion_seguir_cientificaTableAdapter accion_seguir_cientificaTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.accion_seguirxasesoria_cientificaTableAdapter accion_seguirxasesoria_cientificaTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdDisponibilidad;
        private System.Windows.Forms.RadioButton rdNoDisponibilidad;
        private System.Windows.Forms.Label label24;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calVencimiento;
        private System.Windows.Forms.TextBox txtNumeroLote;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtInformacionSuministradaInicial;
        private System.Windows.Forms.Label label17;
        private SPControladoraDatos.dsSpxTableAdapters.estado_asesoria_cientificaTableAdapter estado_asesoria_cientificaTableAdapter1;
        private System.Windows.Forms.CheckBox chkIndicaNoEquipo;
        private System.Windows.Forms.ComboBox cmbUsuarioInterno;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.CheckBox chkInterna;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.calFecha calRespuestaInicial;
        private DevComponents.DotNetBar.ButtonX btnEditarAsesorResponsable;
        private DevComponents.DotNetBar.ButtonX btnBuscarReactivo;
        private System.Windows.Forms.TextBox txtReactivo;
        private SPControladoraDatos.dsSpxTableAdapters.referencia_reactivoTableAdapter referencia_reactivoTableAdapter2;
        private System.Windows.Forms.Label label26;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.calFecha calSugerida;
        private SPXSeguridad.data.cls.clsTusuario clsTusuario1;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad1;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad2;
    }
}