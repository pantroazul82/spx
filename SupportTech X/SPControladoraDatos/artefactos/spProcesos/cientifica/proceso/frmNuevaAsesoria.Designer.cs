namespace spProcesos.cientifica.proceso
{
    partial class frmNuevaAsesoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevaAsesoria));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.calFechaSolicitud = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMotivoConsulta = new System.Windows.Forms.TextBox();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.txtRegistadaPor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtSn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.btnInfSucursal = new DevComponents.DotNetBar.ButtonX();
            this.btnInfCliente = new DevComponents.DotNetBar.ButtonX();
            this.txtNombrecliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new DevComponents.DotNetBar.ButtonX();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.txtInfAdiContacto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCelularContacto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTelefonoContacto = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnBuscarContacto = new DevComponents.DotNetBar.ButtonX();
            this.txtNombreContacto = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnLimpiarCliente = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.prioridad_callcenter_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.prioridad_callcenter_cientificaTableAdapter();
            this.sucursalClienteTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.sucursalClienteTableAdapter();
            this.contactosClientesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.contactosClientesTableAdapter();
            this.txtNumeroAsesoria = new System.Windows.Forms.TextBox();
            this.asesoria_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.asesoria_cientificaTableAdapter();
            this.estado_asesoria_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.estado_asesoria_cientificaTableAdapter();
            this.clientesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.clientesTableAdapter();
            this.clientesTableAdapter2 = new SPControladoraDatos.dsSpxTableAdapters.clientesTableAdapter();
            this.ciudadesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ciudadesTableAdapter();
            this.departamentoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.departamentoTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.calSugerida = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.calFecha();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdDisponibilidad = new System.Windows.Forms.RadioButton();
            this.rdNoDisponibilidad = new System.Windows.Forms.RadioButton();
            this.calRespuestaInicial = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.calFecha();
            this.lblRespuestaInicial = new System.Windows.Forms.Label();
            this.cmbUsuarioInterno = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.chkInterna = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaSolicitud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 345);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 51);
            this.panel1.TabIndex = 7;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(678, 16);
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
            this.btnCancelar.Location = new System.Drawing.Point(759, 16);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.calFechaSolicitud.Location = new System.Drawing.Point(124, 49);
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
            this.calFechaSolicitud.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha de Solicitud:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Registada Por:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prioridad Sugerida:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Motivo de la Consulta:";
            // 
            // txtMotivoConsulta
            // 
            this.txtMotivoConsulta.Location = new System.Drawing.Point(12, 243);
            this.txtMotivoConsulta.Multiline = true;
            this.txtMotivoConsulta.Name = "txtMotivoConsulta";
            this.txtMotivoConsulta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMotivoConsulta.Size = new System.Drawing.Size(373, 96);
            this.txtMotivoConsulta.TabIndex = 5;
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.DataSource = this.dsSpx1;
            this.cmbPrioridad.DisplayMember = "prioridad_callcenter_cientifica.nombre_prioridad";
            this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Location = new System.Drawing.Point(124, 101);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(181, 21);
            this.cmbPrioridad.TabIndex = 3;
            this.cmbPrioridad.ValueMember = "prioridad_callcenter_cientifica.cod_prioridad_callcenter_cientifica";
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtRegistadaPor
            // 
            this.txtRegistadaPor.BackColor = System.Drawing.Color.White;
            this.txtRegistadaPor.Location = new System.Drawing.Point(124, 75);
            this.txtRegistadaPor.Name = "txtRegistadaPor";
            this.txtRegistadaPor.ReadOnly = true;
            this.txtRegistadaPor.Size = new System.Drawing.Size(181, 20);
            this.txtRegistadaPor.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Asesoria Num:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.txtSn);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtCiudad);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.cmbSucursal);
            this.groupBox4.Controls.Add(this.btnInfSucursal);
            this.groupBox4.Controls.Add(this.btnInfCliente);
            this.groupBox4.Controls.Add(this.txtNombrecliente);
            this.groupBox4.Controls.Add(this.btnBuscarCliente);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.btnLimpiarCliente);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Location = new System.Drawing.Point(391, 39);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(440, 300);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informacion del Cliente";
            // 
            // txtSn
            // 
            this.txtSn.BackColor = System.Drawing.Color.White;
            this.txtSn.Location = new System.Drawing.Point(62, 115);
            this.txtSn.Name = "txtSn";
            this.txtSn.ReadOnly = true;
            this.txtSn.Size = new System.Drawing.Size(305, 20);
            this.txtSn.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 87;
            this.label5.Text = "S/N";
            // 
            // txtCiudad
            // 
            this.txtCiudad.BackColor = System.Drawing.Color.White;
            this.txtCiudad.Location = new System.Drawing.Point(61, 89);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.ReadOnly = true;
            this.txtCiudad.Size = new System.Drawing.Size(305, 20);
            this.txtCiudad.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Ciudad";
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.DataSource = this.dsSpx1;
            this.cmbSucursal.DisplayMember = "sucursalCliente.nombreSucursal";
            this.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(61, 50);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(250, 21);
            this.cmbSucursal.TabIndex = 1;
            this.cmbSucursal.ValueMember = "sucursalCliente.codSucursal";
            this.cmbSucursal.SelectedIndexChanged += new System.EventHandler(this.cmbSucursal_SelectedIndexChanged);
            // 
            // btnInfSucursal
            // 
            this.btnInfSucursal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInfSucursal.Image = ((System.Drawing.Image)(resources.GetObject("btnInfSucursal.Image")));
            this.btnInfSucursal.ImageFixedSize = new System.Drawing.Size(29, 29);
            this.btnInfSucursal.Location = new System.Drawing.Point(317, 42);
            this.btnInfSucursal.Name = "btnInfSucursal";
            this.btnInfSucursal.Size = new System.Drawing.Size(33, 33);
            this.btnInfSucursal.TabIndex = 86;
            this.btnInfSucursal.Click += new System.EventHandler(this.btnInfSucursal_Click);
            // 
            // btnInfCliente
            // 
            this.btnInfCliente.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInfCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnInfCliente.Image")));
            this.btnInfCliente.ImageFixedSize = new System.Drawing.Size(29, 29);
            this.btnInfCliente.Location = new System.Drawing.Point(400, 14);
            this.btnInfCliente.Name = "btnInfCliente";
            this.btnInfCliente.Size = new System.Drawing.Size(33, 33);
            this.btnInfCliente.TabIndex = 85;
            this.btnInfCliente.Click += new System.EventHandler(this.btnInfCliente_Click);
            // 
            // txtNombrecliente
            // 
            this.txtNombrecliente.Location = new System.Drawing.Point(61, 20);
            this.txtNombrecliente.Name = "txtNombrecliente";
            this.txtNombrecliente.ReadOnly = true;
            this.txtNombrecliente.Size = new System.Drawing.Size(286, 20);
            this.txtNombrecliente.TabIndex = 0;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
            this.btnBuscarCliente.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnBuscarCliente.Location = new System.Drawing.Point(368, 15);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(29, 29);
            this.btnBuscarCliente.TabIndex = 0;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
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
            this.groupBox2.Controls.Add(this.buttonX2);
            this.groupBox2.Controls.Add(this.txtInfAdiContacto);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtCelularContacto);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtTelefonoContacto);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.btnBuscarContacto);
            this.groupBox2.Controls.Add(this.txtNombreContacto);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(10, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 139);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contacto";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.Image = ((System.Drawing.Image)(resources.GetObject("buttonX2.Image")));
            this.buttonX2.ImageFixedSize = new System.Drawing.Size(29, 29);
            this.buttonX2.Location = new System.Drawing.Point(345, 13);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(33, 33);
            this.buttonX2.TabIndex = 86;
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // txtInfAdiContacto
            // 
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
            // btnBuscarContacto
            // 
            this.btnBuscarContacto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscarContacto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarContacto.Image")));
            this.btnBuscarContacto.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnBuscarContacto.Location = new System.Drawing.Point(311, 13);
            this.btnBuscarContacto.Name = "btnBuscarContacto";
            this.btnBuscarContacto.Size = new System.Drawing.Size(29, 33);
            this.btnBuscarContacto.TabIndex = 0;
            this.btnBuscarContacto.Click += new System.EventHandler(this.btnBuscarContacto_Click);
            // 
            // txtNombreContacto
            // 
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
            // btnLimpiarCliente
            // 
            this.btnLimpiarCliente.Location = new System.Drawing.Point(348, 19);
            this.btnLimpiarCliente.Name = "btnLimpiarCliente";
            this.btnLimpiarCliente.Size = new System.Drawing.Size(18, 23);
            this.btnLimpiarCliente.TabIndex = 4;
            this.btnLimpiarCliente.Text = "<<";
            this.btnLimpiarCliente.UseVisualStyleBackColor = true;
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
            this.txtNumeroAsesoria.Location = new System.Drawing.Point(124, 12);
            this.txtNumeroAsesoria.Name = "txtNumeroAsesoria";
            this.txtNumeroAsesoria.ReadOnly = true;
            this.txtNumeroAsesoria.Size = new System.Drawing.Size(181, 20);
            this.txtNumeroAsesoria.TabIndex = 0;
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
            // clientesTableAdapter2
            // 
            this.clientesTableAdapter2.ClearBeforeFill = true;
            // 
            // ciudadesTableAdapter1
            // 
            this.ciudadesTableAdapter1.ClearBeforeFill = true;
            // 
            // departamentoTableAdapter1
            // 
            this.departamentoTableAdapter1.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Fecha Sugerida:";
            // 
            // calSugerida
            // 
            this.calSugerida.BackColor = System.Drawing.Color.Transparent;
            this.calSugerida.fechaValue = new System.DateTime(((long)(0)));
            this.calSugerida.fechaValueObject = null;
            this.calSugerida.Location = new System.Drawing.Point(127, 167);
            this.calSugerida.Name = "calSugerida";
            this.calSugerida.Size = new System.Drawing.Size(252, 21);
            this.calSugerida.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdDisponibilidad);
            this.groupBox1.Controls.Add(this.rdNoDisponibilidad);
            this.groupBox1.Location = new System.Drawing.Point(176, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 32);
            this.groupBox1.TabIndex = 34;
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
            // calRespuestaInicial
            // 
            this.calRespuestaInicial.BackColor = System.Drawing.Color.Transparent;
            this.calRespuestaInicial.Enabled = false;
            this.calRespuestaInicial.fechaValue = new System.DateTime(((long)(0)));
            this.calRespuestaInicial.fechaValueObject = null;
            this.calRespuestaInicial.Location = new System.Drawing.Point(127, 196);
            this.calRespuestaInicial.Name = "calRespuestaInicial";
            this.calRespuestaInicial.Size = new System.Drawing.Size(252, 21);
            this.calRespuestaInicial.TabIndex = 52;
            this.calRespuestaInicial.Visible = false;
            // 
            // lblRespuestaInicial
            // 
            this.lblRespuestaInicial.Location = new System.Drawing.Point(2, 192);
            this.lblRespuestaInicial.Name = "lblRespuestaInicial";
            this.lblRespuestaInicial.Size = new System.Drawing.Size(119, 30);
            this.lblRespuestaInicial.TabIndex = 53;
            this.lblRespuestaInicial.Text = "Fecha Respuesta Inicial:";
            this.lblRespuestaInicial.Visible = false;
            // 
            // cmbUsuarioInterno
            // 
            this.cmbUsuarioInterno.DisplayMember = "usuario.nombre";
            this.cmbUsuarioInterno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuarioInterno.Enabled = false;
            this.cmbUsuarioInterno.FormattingEnabled = true;
            this.cmbUsuarioInterno.Location = new System.Drawing.Point(618, 7);
            this.cmbUsuarioInterno.Name = "cmbUsuarioInterno";
            this.cmbUsuarioInterno.Size = new System.Drawing.Size(181, 21);
            this.cmbUsuarioInterno.TabIndex = 55;
            this.cmbUsuarioInterno.ValueMember = "usuario.login";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(530, 12);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(82, 13);
            this.label25.TabIndex = 56;
            this.label25.Text = "Usuario Interno:";
            // 
            // chkInterna
            // 
            this.chkInterna.AutoSize = true;
            this.chkInterna.Location = new System.Drawing.Point(391, 9);
            this.chkInterna.Name = "chkInterna";
            this.chkInterna.Size = new System.Drawing.Size(102, 17);
            this.chkInterna.TabIndex = 54;
            this.chkInterna.Text = "Llamada Interna";
            this.chkInterna.UseVisualStyleBackColor = true;
            this.chkInterna.CheckedChanged += new System.EventHandler(this.chkInterna_CheckedChanged);
            // 
            // frmNuevaAsesoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(846, 396);
            this.Controls.Add(this.cmbUsuarioInterno);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.chkInterna);
            this.Controls.Add(this.calRespuestaInicial);
            this.Controls.Add(this.lblRespuestaInicial);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.calSugerida);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNumeroAsesoria);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtRegistadaPor);
            this.Controls.Add(this.cmbPrioridad);
            this.Controls.Add(this.txtMotivoConsulta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calFechaSolicitud);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmNuevaAsesoria";
            this.Text = "Asesoria Cientifica";
            this.Load += new System.EventHandler(this.frmNuevaAsesoria_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calFechaSolicitud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFechaSolicitud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMotivoConsulta;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.TextBox txtRegistadaPor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevComponents.DotNetBar.ButtonX btnInfSucursal;
        private DevComponents.DotNetBar.ButtonX btnInfCliente;
        private System.Windows.Forms.TextBox txtNombrecliente;
        private DevComponents.DotNetBar.ButtonX btnBuscarCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private System.Windows.Forms.TextBox txtInfAdiContacto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCelularContacto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTelefonoContacto;
        private System.Windows.Forms.Label label15;
        private DevComponents.DotNetBar.ButtonX btnBuscarContacto;
        private System.Windows.Forms.TextBox txtNombreContacto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnLimpiarCliente;
        private System.Windows.Forms.Label label19;
        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.prioridad_callcenter_cientificaTableAdapter prioridad_callcenter_cientificaTableAdapter1;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private SPControladoraDatos.dsSpxTableAdapters.sucursalClienteTableAdapter sucursalClienteTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.contactosClientesTableAdapter contactosClientesTableAdapter1;
        private System.Windows.Forms.TextBox txtNumeroAsesoria;
        private SPControladoraDatos.dsSpxTableAdapters.asesoria_cientificaTableAdapter asesoria_cientificaTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.estado_asesoria_cientificaTableAdapter estado_asesoria_cientificaTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.clientesTableAdapter clientesTableAdapter1;
        private System.Windows.Forms.TextBox txtSn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label label4;
        private SPControladoraDatos.dsSpxTableAdapters.clientesTableAdapter clientesTableAdapter2;
        private SPControladoraDatos.dsSpxTableAdapters.ciudadesTableAdapter ciudadesTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.departamentoTableAdapter departamentoTableAdapter1;
        private System.Windows.Forms.Label label6;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.calFecha calSugerida;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdDisponibilidad;
        private System.Windows.Forms.RadioButton rdNoDisponibilidad;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.calFecha calRespuestaInicial;
        private System.Windows.Forms.Label lblRespuestaInicial;
        private System.Windows.Forms.ComboBox cmbUsuarioInterno;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.CheckBox chkInterna;
    }
}