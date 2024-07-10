namespace spProcesos.recolecciones
{
    partial class frmNuevaRecoleccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevaRecoleccion));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpRetiroDefinitivo = new System.Windows.Forms.GroupBox();
            this.rdRetiroDefinitivoNo = new System.Windows.Forms.RadioButton();
            this.rdRetiroDefinitivoSi = new System.Windows.Forms.RadioButton();
            this.btnLimpiarResponsable = new System.Windows.Forms.Button();
            this.txtcodRecoleccion = new System.Windows.Forms.TextBox();
            this.txtMotivoRecoleccion = new System.Windows.Forms.TextBox();
            this.cmbResponsableRecoleccion = new System.Windows.Forms.ComboBox();
            this.dsSPXSeguridadResponsable = new SPXSeguridad.data.dsSPXSeguridad();
            this.calFechaTentativa = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.cmbAutor = new System.Windows.Forms.ComboBox();
            this.dsSPXSeguridadAutor = new SPXSeguridad.data.dsSPXSeguridad();
            this.cmbEstadoRecoleccion = new System.Windows.Forms.ComboBox();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.label15 = new System.Windows.Forms.Label();
            this.calFechaCreacion = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFechaRecibido = new System.Windows.Forms.Label();
            this.btnAmarrarEntrada = new DevComponents.DotNetBar.ButtonX();
            this.txtNumEntrada = new System.Windows.Forms.TextBox();
            this.btnVerEntrada = new DevComponents.DotNetBar.ButtonX();
            this.label12 = new System.Windows.Forms.Label();
            this.calRecoleccion = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label5 = new System.Windows.Forms.Label();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btnImprimir = new DevComponents.DotNetBar.ButtonX();
            this.btnGuardar = new DevComponents.DotNetBar.ButtonX();
            this.btnAnular = new DevComponents.DotNetBar.ButtonX();
            this.btnSalir = new DevComponents.DotNetBar.ButtonX();
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem2 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem5 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem6 = new DevComponents.DotNetBar.ControlContainerItem();
            this.recoleccionTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.recoleccionTableAdapter();
            this.transportadoraTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.transportadoraTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCodRecoleccionTrans = new System.Windows.Forms.TextBox();
            this.txtObsIniciales = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTransportadora = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumeroguia = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnInfSucursal = new DevComponents.DotNetBar.ButtonX();
            this.btnInfCliente = new DevComponents.DotNetBar.ButtonX();
            this.txtNombrecliente = new System.Windows.Forms.TextBox();
            this.txtNitCliente = new System.Windows.Forms.TextBox();
            this.txtSucursal = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtTipoEquipo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.btnInfEquipo = new DevComponents.DotNetBar.ButtonX();
            this.txtModalidad = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.btnBuscarSerial = new DevComponents.DotNetBar.ButtonX();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDesconfirmar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtObservacionesConfirmacion = new System.Windows.Forms.TextBox();
            this.calConfirmacion = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label2 = new System.Windows.Forms.Label();
            this.chkConfirmada = new System.Windows.Forms.CheckBox();
            this.cmbConfirmadaPor = new System.Windows.Forms.ComboBox();
            this.dsSPXSeguridadConfirmo = new SPXSeguridad.data.dsSPXSeguridad();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.estadoRecoleccionTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.estadoRecoleccionTableAdapter();
            this.equiposTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter();
            this.clientesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.clientesTableAdapter();
            this.sucursalClienteTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.sucursalClienteTableAdapter();
            this.fabricanteTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.fabricanteTableAdapter();
            this.modalidadEquipoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ModalidadEquipoTableAdapter();
            this.modelosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.tipoEquipoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.tipoEquipoTableAdapter();
            this.clsTusuario1 = new SPXSeguridad.data.cls.clsTusuario();
            this.dsSPXSeguridad4 = new SPXSeguridad.data.dsSPXSeguridad();
            this.groupBox2.SuspendLayout();
            this.grpRetiroDefinitivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridadResponsable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaTentativa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridadAutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaCreacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calRecoleccion)).BeginInit();
            this.ribbonBar1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calConfirmacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridadConfirmo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grpRetiroDefinitivo);
            this.groupBox2.Controls.Add(this.btnLimpiarResponsable);
            this.groupBox2.Controls.Add(this.txtcodRecoleccion);
            this.groupBox2.Controls.Add(this.txtMotivoRecoleccion);
            this.groupBox2.Controls.Add(this.cmbResponsableRecoleccion);
            this.groupBox2.Controls.Add(this.calFechaTentativa);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label38);
            this.groupBox2.Controls.Add(this.cmbAutor);
            this.groupBox2.Controls.Add(this.cmbEstadoRecoleccion);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.calFechaCreacion);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblFechaRecibido);
            this.groupBox2.Location = new System.Drawing.Point(9, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 298);
            this.groupBox2.TabIndex = 91;
            this.groupBox2.TabStop = false;
            // 
            // grpRetiroDefinitivo
            // 
            this.grpRetiroDefinitivo.Controls.Add(this.rdRetiroDefinitivoNo);
            this.grpRetiroDefinitivo.Controls.Add(this.rdRetiroDefinitivoSi);
            this.grpRetiroDefinitivo.Location = new System.Drawing.Point(15, 248);
            this.grpRetiroDefinitivo.Name = "grpRetiroDefinitivo";
            this.grpRetiroDefinitivo.Size = new System.Drawing.Size(412, 44);
            this.grpRetiroDefinitivo.TabIndex = 61;
            this.grpRetiroDefinitivo.TabStop = false;
            this.grpRetiroDefinitivo.Text = "Retiro Definitivo";
            // 
            // rdRetiroDefinitivoNo
            // 
            this.rdRetiroDefinitivoNo.AutoSize = true;
            this.rdRetiroDefinitivoNo.Location = new System.Drawing.Point(205, 20);
            this.rdRetiroDefinitivoNo.Name = "rdRetiroDefinitivoNo";
            this.rdRetiroDefinitivoNo.Size = new System.Drawing.Size(110, 17);
            this.rdRetiroDefinitivoNo.TabIndex = 1;
            this.rdRetiroDefinitivoNo.TabStop = true;
            this.rdRetiroDefinitivoNo.Text = "Retiro Por Cambio";
            this.rdRetiroDefinitivoNo.UseVisualStyleBackColor = true;
            // 
            // rdRetiroDefinitivoSi
            // 
            this.rdRetiroDefinitivoSi.AutoSize = true;
            this.rdRetiroDefinitivoSi.Location = new System.Drawing.Point(38, 19);
            this.rdRetiroDefinitivoSi.Name = "rdRetiroDefinitivoSi";
            this.rdRetiroDefinitivoSi.Size = new System.Drawing.Size(148, 17);
            this.rdRetiroDefinitivoSi.TabIndex = 0;
            this.rdRetiroDefinitivoSi.TabStop = true;
            this.rdRetiroDefinitivoSi.Text = "Retiro Definitivo de Apoyo";
            this.rdRetiroDefinitivoSi.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarResponsable
            // 
            this.btnLimpiarResponsable.Location = new System.Drawing.Point(361, 163);
            this.btnLimpiarResponsable.Name = "btnLimpiarResponsable";
            this.btnLimpiarResponsable.Size = new System.Drawing.Size(19, 23);
            this.btnLimpiarResponsable.TabIndex = 60;
            this.btnLimpiarResponsable.Text = "x";
            this.btnLimpiarResponsable.UseVisualStyleBackColor = true;
            this.btnLimpiarResponsable.Click += new System.EventHandler(this.btnLimpiarResponsable_Click);
            // 
            // txtcodRecoleccion
            // 
            this.txtcodRecoleccion.BackColor = System.Drawing.Color.White;
            this.txtcodRecoleccion.Location = new System.Drawing.Point(155, 78);
            this.txtcodRecoleccion.Name = "txtcodRecoleccion";
            this.txtcodRecoleccion.ReadOnly = true;
            this.txtcodRecoleccion.Size = new System.Drawing.Size(200, 20);
            this.txtcodRecoleccion.TabIndex = 23;
            // 
            // txtMotivoRecoleccion
            // 
            this.txtMotivoRecoleccion.BackColor = System.Drawing.Color.White;
            this.txtMotivoRecoleccion.Location = new System.Drawing.Point(155, 192);
            this.txtMotivoRecoleccion.Multiline = true;
            this.txtMotivoRecoleccion.Name = "txtMotivoRecoleccion";
            this.txtMotivoRecoleccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMotivoRecoleccion.Size = new System.Drawing.Size(329, 55);
            this.txtMotivoRecoleccion.TabIndex = 48;
            // 
            // cmbResponsableRecoleccion
            // 
            this.cmbResponsableRecoleccion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbResponsableRecoleccion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbResponsableRecoleccion.BackColor = System.Drawing.Color.White;
            this.cmbResponsableRecoleccion.DataSource = this.dsSPXSeguridadResponsable;
            this.cmbResponsableRecoleccion.DisplayMember = "usuario.nombre";
            this.cmbResponsableRecoleccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResponsableRecoleccion.FormattingEnabled = true;
            this.cmbResponsableRecoleccion.Location = new System.Drawing.Point(155, 163);
            this.cmbResponsableRecoleccion.Name = "cmbResponsableRecoleccion";
            this.cmbResponsableRecoleccion.Size = new System.Drawing.Size(202, 21);
            this.cmbResponsableRecoleccion.TabIndex = 52;
            this.cmbResponsableRecoleccion.ValueMember = "usuario.login";
            // 
            // dsSPXSeguridadResponsable
            // 
            this.dsSPXSeguridadResponsable.DataSetName = "dsSPXSeguridad";
            this.dsSPXSeguridadResponsable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calFechaTentativa
            // 
            // 
            // 
            // 
            this.calFechaTentativa.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calFechaTentativa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaTentativa.ButtonDropDown.Visible = true;
            this.calFechaTentativa.Location = new System.Drawing.Point(155, 135);
            // 
            // 
            // 
            this.calFechaTentativa.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFechaTentativa.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calFechaTentativa.MonthCalendar.BackgroundStyle.Class = "";
            this.calFechaTentativa.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaTentativa.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calFechaTentativa.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calFechaTentativa.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calFechaTentativa.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calFechaTentativa.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calFechaTentativa.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calFechaTentativa.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calFechaTentativa.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calFechaTentativa.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaTentativa.MonthCalendar.DisplayMonth = new System.DateTime(2008, 6, 1, 0, 0, 0, 0);
            this.calFechaTentativa.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calFechaTentativa.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calFechaTentativa.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFechaTentativa.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calFechaTentativa.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calFechaTentativa.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calFechaTentativa.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calFechaTentativa.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaTentativa.MonthCalendar.TodayButtonVisible = true;
            this.calFechaTentativa.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calFechaTentativa.Name = "calFechaTentativa";
            this.calFechaTentativa.Size = new System.Drawing.Size(200, 20);
            this.calFechaTentativa.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(2, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 19);
            this.label3.TabIndex = 50;
            this.label3.Text = "Fecha Tentativa Recoleccion";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 19);
            this.label4.TabIndex = 51;
            this.label4.Text = "Responsable Recoleccion";
            // 
            // label38
            // 
            this.label38.Location = new System.Drawing.Point(3, 195);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(134, 19);
            this.label38.TabIndex = 47;
            this.label38.Text = "Motivo Recoleccion";
            // 
            // cmbAutor
            // 
            this.cmbAutor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbAutor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAutor.BackColor = System.Drawing.Color.White;
            this.cmbAutor.DataSource = this.dsSPXSeguridadAutor;
            this.cmbAutor.DisplayMember = "usuario.nombre";
            this.cmbAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAutor.Enabled = false;
            this.cmbAutor.FormattingEnabled = true;
            this.cmbAutor.Location = new System.Drawing.Point(155, 21);
            this.cmbAutor.Name = "cmbAutor";
            this.cmbAutor.Size = new System.Drawing.Size(202, 21);
            this.cmbAutor.TabIndex = 44;
            this.cmbAutor.ValueMember = "usuario.login";
            this.cmbAutor.SelectedIndexChanged += new System.EventHandler(this.cmbAutor_SelectedIndexChanged);
            // 
            // dsSPXSeguridadAutor
            // 
            this.dsSPXSeguridadAutor.DataSetName = "dsSPXSeguridad";
            this.dsSPXSeguridadAutor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbEstadoRecoleccion
            // 
            this.cmbEstadoRecoleccion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbEstadoRecoleccion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEstadoRecoleccion.BackColor = System.Drawing.Color.White;
            this.cmbEstadoRecoleccion.DataSource = this.dsSpx1;
            this.cmbEstadoRecoleccion.DisplayMember = "estadoRecoleccion.nombreEstadoRecoleccion";
            this.cmbEstadoRecoleccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoRecoleccion.Enabled = false;
            this.cmbEstadoRecoleccion.FormattingEnabled = true;
            this.cmbEstadoRecoleccion.Location = new System.Drawing.Point(155, 106);
            this.cmbEstadoRecoleccion.Name = "cmbEstadoRecoleccion";
            this.cmbEstadoRecoleccion.Size = new System.Drawing.Size(200, 21);
            this.cmbEstadoRecoleccion.TabIndex = 43;
            this.cmbEstadoRecoleccion.ValueMember = "estadoRecoleccion.codEstadoRecoleccion";
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(2, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 19);
            this.label15.TabIndex = 41;
            this.label15.Text = "Estado Recoleccion";
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
            this.calFechaCreacion.Location = new System.Drawing.Point(155, 50);
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
            this.calFechaCreacion.MonthCalendar.DisplayMonth = new System.DateTime(2008, 6, 1, 0, 0, 0, 0);
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
            this.calFechaCreacion.Size = new System.Drawing.Size(200, 20);
            this.calFechaCreacion.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(2, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "Consecutivo";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(2, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 19);
            this.label8.TabIndex = 25;
            this.label8.Text = "Fecha Creacion";
            // 
            // lblFechaRecibido
            // 
            this.lblFechaRecibido.Location = new System.Drawing.Point(2, 25);
            this.lblFechaRecibido.Name = "lblFechaRecibido";
            this.lblFechaRecibido.Size = new System.Drawing.Size(71, 19);
            this.lblFechaRecibido.TabIndex = 38;
            this.lblFechaRecibido.Text = "Autor";
            // 
            // btnAmarrarEntrada
            // 
            this.btnAmarrarEntrada.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnAmarrarEntrada, "Amarrar Entrada");
            this.balloonTip1.SetBalloonText(this.btnAmarrarEntrada, null);
            this.btnAmarrarEntrada.Image = ((System.Drawing.Image)(resources.GetObject("btnAmarrarEntrada.Image")));
            this.btnAmarrarEntrada.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnAmarrarEntrada.Location = new System.Drawing.Point(954, 580);
            this.btnAmarrarEntrada.Name = "btnAmarrarEntrada";
            this.btnAmarrarEntrada.Size = new System.Drawing.Size(28, 28);
            this.btnAmarrarEntrada.TabIndex = 61;
            this.btnAmarrarEntrada.Visible = false;
            this.btnAmarrarEntrada.Click += new System.EventHandler(this.btnAmarrarEntrada_Click);
            // 
            // txtNumEntrada
            // 
            this.txtNumEntrada.BackColor = System.Drawing.Color.White;
            this.txtNumEntrada.Location = new System.Drawing.Point(863, 585);
            this.txtNumEntrada.Name = "txtNumEntrada";
            this.txtNumEntrada.ReadOnly = true;
            this.txtNumEntrada.Size = new System.Drawing.Size(85, 20);
            this.txtNumEntrada.TabIndex = 58;
            // 
            // btnVerEntrada
            // 
            this.btnVerEntrada.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnVerEntrada, "Ver Entrada");
            this.balloonTip1.SetBalloonText(this.btnVerEntrada, null);
            this.btnVerEntrada.Image = ((System.Drawing.Image)(resources.GetObject("btnVerEntrada.Image")));
            this.btnVerEntrada.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnVerEntrada.Location = new System.Drawing.Point(954, 581);
            this.btnVerEntrada.Name = "btnVerEntrada";
            this.btnVerEntrada.Size = new System.Drawing.Size(28, 28);
            this.btnVerEntrada.TabIndex = 59;
            this.btnVerEntrada.Click += new System.EventHandler(this.btnVerEntrada_Click);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(815, 589);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 17);
            this.label12.TabIndex = 57;
            this.label12.Text = "Entrada";
            // 
            // calRecoleccion
            // 
            // 
            // 
            // 
            this.calRecoleccion.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calRecoleccion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calRecoleccion.ButtonDropDown.Visible = true;
            this.calRecoleccion.Enabled = false;
            this.calRecoleccion.Location = new System.Drawing.Point(609, 589);
            // 
            // 
            // 
            this.calRecoleccion.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calRecoleccion.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calRecoleccion.MonthCalendar.BackgroundStyle.Class = "";
            this.calRecoleccion.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calRecoleccion.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calRecoleccion.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calRecoleccion.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calRecoleccion.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calRecoleccion.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calRecoleccion.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calRecoleccion.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calRecoleccion.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calRecoleccion.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calRecoleccion.MonthCalendar.DisplayMonth = new System.DateTime(2008, 6, 1, 0, 0, 0, 0);
            this.calRecoleccion.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calRecoleccion.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calRecoleccion.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calRecoleccion.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calRecoleccion.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calRecoleccion.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calRecoleccion.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calRecoleccion.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calRecoleccion.MonthCalendar.TodayButtonVisible = true;
            this.calRecoleccion.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calRecoleccion.Name = "calRecoleccion";
            this.calRecoleccion.Size = new System.Drawing.Size(200, 20);
            this.calRecoleccion.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(521, 594);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 15);
            this.label5.TabIndex = 54;
            this.label5.Text = "Fecha Llegada";
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
            this.ribbonBar1.Controls.Add(this.btnAnular);
            this.ribbonBar1.Controls.Add(this.btnSalir);
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.controlContainerItem1,
            this.controlContainerItem2,
            this.controlContainerItem5,
            this.controlContainerItem6});
            this.ribbonBar1.Location = new System.Drawing.Point(0, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(1008, 56);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar1.TabIndex = 90;
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
            // btnImprimir
            // 
            this.btnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnImprimir.Location = new System.Drawing.Point(6, 3);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(83, 33);
            this.btnImprimir.TabIndex = 68;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnGuardar.Location = new System.Drawing.Point(94, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(83, 33);
            this.btnGuardar.TabIndex = 67;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAnular.Image = ((System.Drawing.Image)(resources.GetObject("btnAnular.Image")));
            this.btnAnular.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnAnular.Location = new System.Drawing.Point(182, 3);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(83, 33);
            this.btnAnular.TabIndex = 101;
            this.btnAnular.Text = "Anular";
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnSalir.Location = new System.Drawing.Point(270, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(83, 33);
            this.btnSalir.TabIndex = 77;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.controlContainerItem6.Control = this.btnSalir;
            this.controlContainerItem6.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem6.Name = "controlContainerItem6";
            // 
            // recoleccionTableAdapter1
            // 
            this.recoleccionTableAdapter1.ClearBeforeFill = true;
            // 
            // transportadoraTableAdapter1
            // 
            this.transportadoraTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCodRecoleccionTrans);
            this.groupBox3.Controls.Add(this.txtObsIniciales);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cmbTransportadora);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label37);
            this.groupBox3.Location = new System.Drawing.Point(518, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(475, 185);
            this.groupBox3.TabIndex = 94;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion de Transportadora";
            // 
            // txtCodRecoleccionTrans
            // 
            this.txtCodRecoleccionTrans.AcceptsReturn = true;
            this.txtCodRecoleccionTrans.BackColor = System.Drawing.Color.White;
            this.txtCodRecoleccionTrans.Location = new System.Drawing.Point(108, 61);
            this.txtCodRecoleccionTrans.Name = "txtCodRecoleccionTrans";
            this.txtCodRecoleccionTrans.Size = new System.Drawing.Size(200, 20);
            this.txtCodRecoleccionTrans.TabIndex = 50;
            // 
            // txtObsIniciales
            // 
            this.txtObsIniciales.BackColor = System.Drawing.Color.White;
            this.txtObsIniciales.Location = new System.Drawing.Point(12, 104);
            this.txtObsIniciales.Multiline = true;
            this.txtObsIniciales.Name = "txtObsIniciales";
            this.txtObsIniciales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObsIniciales.Size = new System.Drawing.Size(418, 73);
            this.txtObsIniciales.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "Cod Recolecion";
            // 
            // cmbTransportadora
            // 
            this.cmbTransportadora.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbTransportadora.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTransportadora.BackColor = System.Drawing.Color.White;
            this.cmbTransportadora.DataSource = this.dsSpx1;
            this.cmbTransportadora.DisplayMember = "transportadora.nombreTransportadora";
            this.cmbTransportadora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransportadora.FormattingEnabled = true;
            this.cmbTransportadora.Location = new System.Drawing.Point(108, 32);
            this.cmbTransportadora.Name = "cmbTransportadora";
            this.cmbTransportadora.Size = new System.Drawing.Size(200, 21);
            this.cmbTransportadora.TabIndex = 43;
            this.cmbTransportadora.ValueMember = "transportadora.codTransportadora";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "Transportadora";
            // 
            // label37
            // 
            this.label37.Location = new System.Drawing.Point(11, 90);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(151, 34);
            this.label37.TabIndex = 45;
            this.label37.Text = "Observaciones Iniciales";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 55;
            this.label9.Text = "Numero de Guia";
            // 
            // txtNumeroguia
            // 
            this.txtNumeroguia.BackColor = System.Drawing.Color.White;
            this.txtNumeroguia.Location = new System.Drawing.Point(108, 57);
            this.txtNumeroguia.Name = "txtNumeroguia";
            this.txtNumeroguia.Size = new System.Drawing.Size(200, 20);
            this.txtNumeroguia.TabIndex = 56;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.btnInfSucursal);
            this.groupBox5.Controls.Add(this.btnInfCliente);
            this.groupBox5.Controls.Add(this.txtNombrecliente);
            this.groupBox5.Controls.Add(this.txtNitCliente);
            this.groupBox5.Controls.Add(this.txtSucursal);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Location = new System.Drawing.Point(9, 514);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(496, 131);
            this.groupBox5.TabIndex = 97;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Informacion del Cliente";
            // 
            // btnInfSucursal
            // 
            this.btnInfSucursal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInfSucursal.Image = ((System.Drawing.Image)(resources.GetObject("btnInfSucursal.Image")));
            this.btnInfSucursal.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnInfSucursal.Location = new System.Drawing.Point(392, 81);
            this.btnInfSucursal.Name = "btnInfSucursal";
            this.btnInfSucursal.Size = new System.Drawing.Size(28, 28);
            this.btnInfSucursal.TabIndex = 61;
            this.btnInfSucursal.Click += new System.EventHandler(this.btnInfSucursal_Click);
            // 
            // btnInfCliente
            // 
            this.btnInfCliente.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInfCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnInfCliente.Image")));
            this.btnInfCliente.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnInfCliente.Location = new System.Drawing.Point(392, 25);
            this.btnInfCliente.Name = "btnInfCliente";
            this.btnInfCliente.Size = new System.Drawing.Size(28, 28);
            this.btnInfCliente.TabIndex = 60;
            this.btnInfCliente.Click += new System.EventHandler(this.btnInfCliente_Click);
            // 
            // txtNombrecliente
            // 
            this.txtNombrecliente.Location = new System.Drawing.Point(155, 59);
            this.txtNombrecliente.Name = "txtNombrecliente";
            this.txtNombrecliente.ReadOnly = true;
            this.txtNombrecliente.Size = new System.Drawing.Size(234, 20);
            this.txtNombrecliente.TabIndex = 1;
            // 
            // txtNitCliente
            // 
            this.txtNitCliente.Location = new System.Drawing.Point(155, 31);
            this.txtNitCliente.Name = "txtNitCliente";
            this.txtNitCliente.ReadOnly = true;
            this.txtNitCliente.Size = new System.Drawing.Size(234, 20);
            this.txtNitCliente.TabIndex = 0;
            // 
            // txtSucursal
            // 
            this.txtSucursal.Location = new System.Drawing.Point(155, 86);
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.ReadOnly = true;
            this.txtSucursal.Size = new System.Drawing.Size(234, 20);
            this.txtSucursal.TabIndex = 0;
            // 
            // label27
            // 
            this.label27.Location = new System.Drawing.Point(12, 64);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(137, 15);
            this.label27.TabIndex = 16;
            this.label27.Text = "Nombre Cliente";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(12, 37);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(54, 13);
            this.label30.TabIndex = 11;
            this.label30.Text = "Nit cliente";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(12, 89);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(48, 13);
            this.label25.TabIndex = 19;
            this.label25.Text = "Sucursal";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.txtTipoEquipo);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.label31);
            this.groupBox7.Controls.Add(this.btnInfEquipo);
            this.groupBox7.Controls.Add(this.txtModalidad);
            this.groupBox7.Controls.Add(this.label32);
            this.groupBox7.Controls.Add(this.btnBuscarSerial);
            this.groupBox7.Controls.Add(this.txtModelo);
            this.groupBox7.Controls.Add(this.txtSerial);
            this.groupBox7.Controls.Add(this.label35);
            this.groupBox7.Location = new System.Drawing.Point(9, 374);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(500, 137);
            this.groupBox7.TabIndex = 96;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Informacion del Equipo";
            // 
            // txtTipoEquipo
            // 
            this.txtTipoEquipo.Location = new System.Drawing.Point(155, 56);
            this.txtTipoEquipo.Name = "txtTipoEquipo";
            this.txtTipoEquipo.ReadOnly = true;
            this.txtTipoEquipo.Size = new System.Drawing.Size(234, 20);
            this.txtTipoEquipo.TabIndex = 68;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 69;
            this.label14.Text = "Modelo";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Location = new System.Drawing.Point(12, 38);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(33, 13);
            this.label31.TabIndex = 33;
            this.label31.Text = "Serial";
            // 
            // btnInfEquipo
            // 
            this.btnInfEquipo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInfEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfEquipo.Image")));
            this.btnInfEquipo.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnInfEquipo.Location = new System.Drawing.Point(423, 17);
            this.btnInfEquipo.Name = "btnInfEquipo";
            this.btnInfEquipo.Size = new System.Drawing.Size(28, 28);
            this.btnInfEquipo.TabIndex = 67;
            this.btnInfEquipo.Click += new System.EventHandler(this.btnInfEquipo_Click);
            // 
            // txtModalidad
            // 
            this.txtModalidad.Location = new System.Drawing.Point(155, 111);
            this.txtModalidad.Name = "txtModalidad";
            this.txtModalidad.ReadOnly = true;
            this.txtModalidad.Size = new System.Drawing.Size(234, 20);
            this.txtModalidad.TabIndex = 30;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(12, 114);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(56, 13);
            this.label32.TabIndex = 31;
            this.label32.Text = "Modalidad";
            // 
            // btnBuscarSerial
            // 
            this.btnBuscarSerial.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscarSerial.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarSerial.Image")));
            this.btnBuscarSerial.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnBuscarSerial.Location = new System.Drawing.Point(392, 17);
            this.btnBuscarSerial.Name = "btnBuscarSerial";
            this.btnBuscarSerial.Size = new System.Drawing.Size(28, 28);
            this.btnBuscarSerial.TabIndex = 29;
            this.btnBuscarSerial.Click += new System.EventHandler(this.btnBuscarSerial_Click);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(155, 82);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.ReadOnly = true;
            this.txtModelo.Size = new System.Drawing.Size(234, 20);
            this.txtModelo.TabIndex = 4;
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(155, 24);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(234, 20);
            this.txtSerial.TabIndex = 0;
            this.txtSerial.Validating += new System.ComponentModel.CancelEventHandler(this.txtSerial_Validating);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(12, 63);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(64, 13);
            this.label35.TabIndex = 13;
            this.label35.Text = "Tipo Equipo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumeroguia);
            this.groupBox1.Controls.Add(this.btnDesconfirmar);
            this.groupBox1.Controls.Add(this.btnConfirmar);
            this.groupBox1.Controls.Add(this.txtObservacionesConfirmacion);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.calConfirmacion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkConfirmada);
            this.groupBox1.Controls.Add(this.cmbConfirmadaPor);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(518, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 197);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Confirmacion";
            // 
            // btnDesconfirmar
            // 
            this.btnDesconfirmar.Location = new System.Drawing.Point(321, 80);
            this.btnDesconfirmar.Name = "btnDesconfirmar";
            this.btnDesconfirmar.Size = new System.Drawing.Size(139, 23);
            this.btnDesconfirmar.TabIndex = 61;
            this.btnDesconfirmar.Text = "Establecer No Confirmada";
            this.btnDesconfirmar.UseVisualStyleBackColor = true;
            this.btnDesconfirmar.Click += new System.EventHandler(this.btnDesconfirmar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(321, 56);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(139, 23);
            this.btnConfirmar.TabIndex = 60;
            this.btnConfirmar.Text = "Establecer Confirmada";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtObservacionesConfirmacion
            // 
            this.txtObservacionesConfirmacion.BackColor = System.Drawing.Color.White;
            this.txtObservacionesConfirmacion.Location = new System.Drawing.Point(6, 128);
            this.txtObservacionesConfirmacion.Multiline = true;
            this.txtObservacionesConfirmacion.Name = "txtObservacionesConfirmacion";
            this.txtObservacionesConfirmacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacionesConfirmacion.Size = new System.Drawing.Size(424, 63);
            this.txtObservacionesConfirmacion.TabIndex = 46;
            // 
            // calConfirmacion
            // 
            // 
            // 
            // 
            this.calConfirmacion.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calConfirmacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calConfirmacion.ButtonDropDown.Visible = true;
            this.calConfirmacion.Enabled = false;
            this.calConfirmacion.Location = new System.Drawing.Point(108, 83);
            // 
            // 
            // 
            this.calConfirmacion.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calConfirmacion.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calConfirmacion.MonthCalendar.BackgroundStyle.Class = "";
            this.calConfirmacion.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calConfirmacion.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calConfirmacion.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calConfirmacion.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calConfirmacion.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calConfirmacion.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calConfirmacion.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calConfirmacion.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calConfirmacion.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calConfirmacion.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calConfirmacion.MonthCalendar.DisplayMonth = new System.DateTime(2008, 6, 1, 0, 0, 0, 0);
            this.calConfirmacion.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calConfirmacion.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calConfirmacion.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calConfirmacion.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calConfirmacion.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calConfirmacion.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calConfirmacion.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calConfirmacion.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calConfirmacion.MonthCalendar.TodayButtonVisible = true;
            this.calConfirmacion.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calConfirmacion.Name = "calConfirmacion";
            this.calConfirmacion.Size = new System.Drawing.Size(200, 20);
            this.calConfirmacion.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 30);
            this.label2.TabIndex = 59;
            this.label2.Text = "Fecha Confirmacion";
            // 
            // chkConfirmada
            // 
            this.chkConfirmada.AutoSize = true;
            this.chkConfirmada.Enabled = false;
            this.chkConfirmada.Location = new System.Drawing.Point(321, 27);
            this.chkConfirmada.Name = "chkConfirmada";
            this.chkConfirmada.Size = new System.Drawing.Size(79, 17);
            this.chkConfirmada.TabIndex = 57;
            this.chkConfirmada.Text = "Confirmada";
            this.chkConfirmada.UseVisualStyleBackColor = true;
            // 
            // cmbConfirmadaPor
            // 
            this.cmbConfirmadaPor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbConfirmadaPor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbConfirmadaPor.BackColor = System.Drawing.Color.White;
            this.cmbConfirmadaPor.DataSource = this.dsSPXSeguridadConfirmo;
            this.cmbConfirmadaPor.DisplayMember = "usuario.nombre";
            this.cmbConfirmadaPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConfirmadaPor.Enabled = false;
            this.cmbConfirmadaPor.FormattingEnabled = true;
            this.cmbConfirmadaPor.Location = new System.Drawing.Point(109, 27);
            this.cmbConfirmadaPor.Name = "cmbConfirmadaPor";
            this.cmbConfirmadaPor.Size = new System.Drawing.Size(199, 21);
            this.cmbConfirmadaPor.TabIndex = 43;
            this.cmbConfirmadaPor.ValueMember = "usuario.login";
            // 
            // dsSPXSeguridadConfirmo
            // 
            this.dsSPXSeguridadConfirmo.DataSetName = "dsSPXSeguridad";
            this.dsSPXSeguridadConfirmo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(9, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 28);
            this.label10.TabIndex = 41;
            this.label10.Text = "Confirmada Por";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(6, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 25);
            this.label11.TabIndex = 45;
            this.label11.Text = "Observaciones Confirmacion";
            // 
            // estadoRecoleccionTableAdapter1
            // 
            this.estadoRecoleccionTableAdapter1.ClearBeforeFill = true;
            // 
            // equiposTableAdapter1
            // 
            this.equiposTableAdapter1.ClearBeforeFill = true;
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // sucursalClienteTableAdapter1
            // 
            this.sucursalClienteTableAdapter1.ClearBeforeFill = true;
            // 
            // fabricanteTableAdapter1
            // 
            this.fabricanteTableAdapter1.ClearBeforeFill = true;
            // 
            // modalidadEquipoTableAdapter1
            // 
            this.modalidadEquipoTableAdapter1.ClearBeforeFill = true;
            // 
            // modelosTableAdapter1
            // 
            this.modelosTableAdapter1.ClearBeforeFill = true;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BackColor = System.Drawing.Color.White;
            this.txtObservaciones.Location = new System.Drawing.Point(524, 494);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(458, 60);
            this.txtObservaciones.TabIndex = 100;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(521, 475);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 34);
            this.label13.TabIndex = 99;
            this.label13.Text = "Observaciones Generales";
            // 
            // tipoEquipoTableAdapter1
            // 
            this.tipoEquipoTableAdapter1.ClearBeforeFill = true;
            // 
            // clsTusuario1
            // 
            this.clsTusuario1.nombreLlave = "cod_usuario";
            this.clsTusuario1.nombreTabla = "usuario";
            this.clsTusuario1.sentenciaBase = resources.GetString("clsTusuario1.sentenciaBase");
            this.clsTusuario1.sentenciaBaseDistinct = resources.GetString("clsTusuario1.sentenciaBaseDistinct");
            // 
            // dsSPXSeguridad4
            // 
            this.dsSPXSeguridad4.DataSetName = "dsSPXSeguridad";
            this.dsSPXSeguridad4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmNuevaRecoleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 666);
            this.Controls.Add(this.btnAmarrarEntrada);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.calRecoleccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNumEntrada);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnVerEntrada);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ribbonBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNuevaRecoleccion";
            this.Text = "Nueva Recoleccion";
            this.Load += new System.EventHandler(this.frmNuevaRecoleccion_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpRetiroDefinitivo.ResumeLayout(false);
            this.grpRetiroDefinitivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridadResponsable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaTentativa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridadAutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaCreacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calRecoleccion)).EndInit();
            this.ribbonBar1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calConfirmacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridadConfirmo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbEstadoRecoleccion;
        private System.Windows.Forms.Label label15;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFechaCreacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcodRecoleccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFechaRecibido;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonX btnImprimir;
        private DevComponents.DotNetBar.ButtonX btnGuardar;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem2;
        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.recoleccionTableAdapter recoleccionTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.transportadoraTableAdapter transportadoraTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbTransportadora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txtObsIniciales;
        private System.Windows.Forms.ComboBox cmbAutor;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtNombrecliente;
        private System.Windows.Forms.TextBox txtNitCliente;
        private System.Windows.Forms.TextBox txtSucursal;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label31;
        private DevComponents.DotNetBar.ButtonX btnInfEquipo;
        private System.Windows.Forms.TextBox txtModalidad;
        private System.Windows.Forms.Label label32;
        private DevComponents.DotNetBar.ButtonX btnBuscarSerial;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.ComboBox cmbResponsableRecoleccion;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFechaTentativa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txtMotivoRecoleccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumeroguia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodRecoleccionTrans;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calConfirmacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkConfirmada;
        private System.Windows.Forms.ComboBox cmbConfirmadaPor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtObservacionesConfirmacion;
        private DevComponents.DotNetBar.ButtonX btnVerEntrada;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNumEntrada;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calRecoleccion;
        private System.Windows.Forms.Label label5;
        private SPControladoraDatos.dsSpxTableAdapters.estadoRecoleccionTableAdapter estadoRecoleccionTableAdapter1;
        private DevComponents.DotNetBar.ButtonX btnInfSucursal;
        private DevComponents.DotNetBar.ButtonX btnInfCliente;
        private SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter equiposTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.clientesTableAdapter clientesTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.sucursalClienteTableAdapter sucursalClienteTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.fabricanteTableAdapter fabricanteTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.ModalidadEquipoTableAdapter modalidadEquipoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter modelosTableAdapter1;
        private System.Windows.Forms.Button btnDesconfirmar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label13;
        private DevComponents.DotNetBar.ButtonX btnAnular;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem5;
        private DevComponents.DotNetBar.ButtonX btnSalir;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem6;
        private System.Windows.Forms.Button btnLimpiarResponsable;
        private DevComponents.DotNetBar.ButtonX btnAmarrarEntrada;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private System.Windows.Forms.TextBox txtTipoEquipo;
        private System.Windows.Forms.Label label14;
        private SPControladoraDatos.dsSpxTableAdapters.tipoEquipoTableAdapter tipoEquipoTableAdapter1;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridadConfirmo;
        private SPXSeguridad.data.cls.clsTusuario clsTusuario1;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridadAutor;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridadResponsable;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad4;
        private System.Windows.Forms.GroupBox grpRetiroDefinitivo;
        private System.Windows.Forms.RadioButton rdRetiroDefinitivoNo;
        private System.Windows.Forms.RadioButton rdRetiroDefinitivoSi;
    }
}