namespace spProcesos.cientifica.proceso
{
    partial class frmCerrarOrden
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.calVisita = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numDiasSolcuonar = new System.Windows.Forms.NumericUpDown();
            this.txtReporteCalidad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbRazon = new System.Windows.Forms.ComboBox();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.lblRazon = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPorqueNoSolucionado = new System.Windows.Forms.TextBox();
            this.rdNoSolucionado = new System.Windows.Forms.RadioButton();
            this.rdSiSolucionado = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPorqueNoConforme = new System.Windows.Forms.TextBox();
            this.rdNoConforme = new System.Windows.Forms.RadioButton();
            this.rdSiConforme = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbInconvenientePor = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.asesoria_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.asesoria_cientificaTableAdapter();
            this.inconveniente_presentado_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.inconveniente_presentado_cientificaTableAdapter();
            this.txtAsesoriaNumero = new System.Windows.Forms.TextBox();
            this.estado_asesoria_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.estado_asesoria_cientificaTableAdapter();
            this.seguimiento_asesoria_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.seguimiento_asesoria_cientificaTableAdapter();
            this.accion_seguirxseguimiento_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.accion_seguirxseguimiento_cientificaTableAdapter();
            this.accion_seguir_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.accion_seguir_cientificaTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.calCierre = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.equiposTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdNoControlCalidad = new System.Windows.Forms.RadioButton();
            this.rdSiControlCalidad = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calVisita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiasSolcuonar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calCierre)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 353);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 51);
            this.panel1.TabIndex = 7;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(650, 16);
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
            this.btnCancelar.Location = new System.Drawing.Point(731, 16);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.calVisita.Location = new System.Drawing.Point(138, 32);
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
            this.calVisita.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
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
            this.calVisita.TabIndex = 8;
            this.calVisita.Validated += new System.EventHandler(this.calVisita_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fecha de Visita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Dias en Solucionar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Numero Reporte Control Calidad:";
            // 
            // numDiasSolcuonar
            // 
            this.numDiasSolcuonar.Enabled = false;
            this.numDiasSolcuonar.Location = new System.Drawing.Point(659, 71);
            this.numDiasSolcuonar.Name = "numDiasSolcuonar";
            this.numDiasSolcuonar.Size = new System.Drawing.Size(120, 20);
            this.numDiasSolcuonar.TabIndex = 14;
            // 
            // txtReporteCalidad
            // 
            this.txtReporteCalidad.Location = new System.Drawing.Point(317, 28);
            this.txtReporteCalidad.Name = "txtReporteCalidad";
            this.txtReporteCalidad.Size = new System.Drawing.Size(190, 20);
            this.txtReporteCalidad.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbRazon);
            this.groupBox1.Controls.Add(this.lblRazon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPorqueNoSolucionado);
            this.groupBox1.Controls.Add(this.rdNoSolucionado);
            this.groupBox1.Controls.Add(this.rdSiSolucionado);
            this.groupBox1.Location = new System.Drawing.Point(9, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 123);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Requerimiento Solucionado Telefonicamente";
            // 
            // cmbRazon
            // 
            this.cmbRazon.DataSource = this.dsSpx1;
            this.cmbRazon.DisplayMember = "inconveniente_presentado_cientifica.nombre_inconveniente";
            this.cmbRazon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRazon.FormattingEnabled = true;
            this.cmbRazon.Location = new System.Drawing.Point(223, 18);
            this.cmbRazon.Name = "cmbRazon";
            this.cmbRazon.Size = new System.Drawing.Size(190, 21);
            this.cmbRazon.TabIndex = 23;
            this.cmbRazon.ValueMember = "inconveniente_presentado_cientifica.cod_inconveniente_presentado_cientifica";
            this.cmbRazon.Visible = false;
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblRazon
            // 
            this.lblRazon.AutoSize = true;
            this.lblRazon.Location = new System.Drawing.Point(179, 21);
            this.lblRazon.Name = "lblRazon";
            this.lblRazon.Size = new System.Drawing.Size(38, 13);
            this.lblRazon.TabIndex = 22;
            this.lblRazon.Text = "Razon";
            this.lblRazon.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Por que:";
            // 
            // txtPorqueNoSolucionado
            // 
            this.txtPorqueNoSolucionado.Location = new System.Drawing.Point(24, 61);
            this.txtPorqueNoSolucionado.Multiline = true;
            this.txtPorqueNoSolucionado.Name = "txtPorqueNoSolucionado";
            this.txtPorqueNoSolucionado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPorqueNoSolucionado.Size = new System.Drawing.Size(742, 44);
            this.txtPorqueNoSolucionado.TabIndex = 2;
            // 
            // rdNoSolucionado
            // 
            this.rdNoSolucionado.AutoSize = true;
            this.rdNoSolucionado.Location = new System.Drawing.Point(96, 19);
            this.rdNoSolucionado.Name = "rdNoSolucionado";
            this.rdNoSolucionado.Size = new System.Drawing.Size(39, 17);
            this.rdNoSolucionado.TabIndex = 1;
            this.rdNoSolucionado.TabStop = true;
            this.rdNoSolucionado.Text = "No";
            this.rdNoSolucionado.UseVisualStyleBackColor = true;
            this.rdNoSolucionado.CheckedChanged += new System.EventHandler(this.rdNoSolucionado_CheckedChanged);
            // 
            // rdSiSolucionado
            // 
            this.rdSiSolucionado.AutoSize = true;
            this.rdSiSolucionado.Location = new System.Drawing.Point(34, 19);
            this.rdSiSolucionado.Name = "rdSiSolucionado";
            this.rdSiSolucionado.Size = new System.Drawing.Size(34, 17);
            this.rdSiSolucionado.TabIndex = 0;
            this.rdSiSolucionado.TabStop = true;
            this.rdSiSolucionado.Text = "Si";
            this.rdSiSolucionado.UseVisualStyleBackColor = true;
            this.rdSiSolucionado.CheckedChanged += new System.EventHandler(this.rdSiSolucionado_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtPorqueNoConforme);
            this.groupBox2.Controls.Add(this.rdNoConforme);
            this.groupBox2.Controls.Add(this.rdSiConforme);
            this.groupBox2.Location = new System.Drawing.Point(9, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(787, 112);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conformidad con la respuesta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Por que:";
            // 
            // txtPorqueNoConforme
            // 
            this.txtPorqueNoConforme.Location = new System.Drawing.Point(96, 40);
            this.txtPorqueNoConforme.Multiline = true;
            this.txtPorqueNoConforme.Name = "txtPorqueNoConforme";
            this.txtPorqueNoConforme.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPorqueNoConforme.Size = new System.Drawing.Size(670, 64);
            this.txtPorqueNoConforme.TabIndex = 2;
            // 
            // rdNoConforme
            // 
            this.rdNoConforme.AutoSize = true;
            this.rdNoConforme.Location = new System.Drawing.Point(34, 40);
            this.rdNoConforme.Name = "rdNoConforme";
            this.rdNoConforme.Size = new System.Drawing.Size(39, 17);
            this.rdNoConforme.TabIndex = 1;
            this.rdNoConforme.TabStop = true;
            this.rdNoConforme.Text = "No";
            this.rdNoConforme.UseVisualStyleBackColor = true;
            this.rdNoConforme.CheckedChanged += new System.EventHandler(this.rdNoConforme_CheckedChanged);
            // 
            // rdSiConforme
            // 
            this.rdSiConforme.AutoSize = true;
            this.rdSiConforme.Location = new System.Drawing.Point(34, 19);
            this.rdSiConforme.Name = "rdSiConforme";
            this.rdSiConforme.Size = new System.Drawing.Size(34, 17);
            this.rdSiConforme.TabIndex = 0;
            this.rdSiConforme.TabStop = true;
            this.rdSiConforme.Text = "Si";
            this.rdSiConforme.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Inconveniente Presentado Por:";
            // 
            // cmbInconvenientePor
            // 
            this.cmbInconvenientePor.DataSource = this.dsSpx1;
            this.cmbInconvenientePor.DisplayMember = "inconveniente_presentado_cientifica.nombre_inconveniente";
            this.cmbInconvenientePor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInconvenientePor.FormattingEnabled = true;
            this.cmbInconvenientePor.Location = new System.Drawing.Point(525, 6);
            this.cmbInconvenientePor.Name = "cmbInconvenientePor";
            this.cmbInconvenientePor.Size = new System.Drawing.Size(190, 21);
            this.cmbInconvenientePor.TabIndex = 21;
            this.cmbInconvenientePor.ValueMember = "inconveniente_presentado_cientifica.cod_inconveniente_presentado_cientifica";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Asesoria Num:";
            // 
            // asesoria_cientificaTableAdapter1
            // 
            this.asesoria_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // inconveniente_presentado_cientificaTableAdapter1
            // 
            this.inconveniente_presentado_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // txtAsesoriaNumero
            // 
            this.txtAsesoriaNumero.BackColor = System.Drawing.Color.White;
            this.txtAsesoriaNumero.Location = new System.Drawing.Point(138, 7);
            this.txtAsesoriaNumero.Name = "txtAsesoriaNumero";
            this.txtAsesoriaNumero.ReadOnly = true;
            this.txtAsesoriaNumero.Size = new System.Drawing.Size(190, 20);
            this.txtAsesoriaNumero.TabIndex = 53;
            // 
            // estado_asesoria_cientificaTableAdapter1
            // 
            this.estado_asesoria_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // seguimiento_asesoria_cientificaTableAdapter1
            // 
            this.seguimiento_asesoria_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // accion_seguirxseguimiento_cientificaTableAdapter1
            // 
            this.accion_seguirxseguimiento_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // accion_seguir_cientificaTableAdapter1
            // 
            this.accion_seguir_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(554, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Fecha de Cierre";
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
            this.calCierre.Location = new System.Drawing.Point(659, 33);
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
            this.calCierre.Size = new System.Drawing.Size(147, 20);
            this.calCierre.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.calCierre.TabIndex = 54;
            this.calCierre.Validated += new System.EventHandler(this.calCierre_Validated);
            // 
            // equiposTableAdapter1
            // 
            this.equiposTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdNoControlCalidad);
            this.groupBox3.Controls.Add(this.rdSiControlCalidad);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtReporteCalidad);
            this.groupBox3.Location = new System.Drawing.Point(12, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(536, 54);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Requiere Control de Calidad";
            // 
            // rdNoControlCalidad
            // 
            this.rdNoControlCalidad.AutoSize = true;
            this.rdNoControlCalidad.Location = new System.Drawing.Point(74, 24);
            this.rdNoControlCalidad.Name = "rdNoControlCalidad";
            this.rdNoControlCalidad.Size = new System.Drawing.Size(39, 17);
            this.rdNoControlCalidad.TabIndex = 1;
            this.rdNoControlCalidad.TabStop = true;
            this.rdNoControlCalidad.Text = "No";
            this.rdNoControlCalidad.UseVisualStyleBackColor = true;
            // 
            // rdSiControlCalidad
            // 
            this.rdSiControlCalidad.AutoSize = true;
            this.rdSiControlCalidad.Location = new System.Drawing.Point(34, 24);
            this.rdSiControlCalidad.Name = "rdSiControlCalidad";
            this.rdSiControlCalidad.Size = new System.Drawing.Size(34, 17);
            this.rdSiControlCalidad.TabIndex = 0;
            this.rdSiControlCalidad.TabStop = true;
            this.rdSiControlCalidad.Text = "Si";
            this.rdSiControlCalidad.UseVisualStyleBackColor = true;
            // 
            // frmCerrarOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(818, 404);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calCierre);
            this.Controls.Add(this.txtAsesoriaNumero);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbInconvenientePor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numDiasSolcuonar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calVisita);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(824, 428);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(824, 428);
            this.Name = "frmCerrarOrden";
            this.Text = "Cerrar Asesoria";
            this.Load += new System.EventHandler(this.frmCerrarOrden_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calVisita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiasSolcuonar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calCierre)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calVisita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numDiasSolcuonar;
        private System.Windows.Forms.TextBox txtReporteCalidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPorqueNoSolucionado;
        private System.Windows.Forms.RadioButton rdNoSolucionado;
        private System.Windows.Forms.RadioButton rdSiSolucionado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPorqueNoConforme;
        private System.Windows.Forms.RadioButton rdNoConforme;
        private System.Windows.Forms.RadioButton rdSiConforme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbInconvenientePor;
        private System.Windows.Forms.Label label11;
        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.asesoria_cientificaTableAdapter asesoria_cientificaTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.inconveniente_presentado_cientificaTableAdapter inconveniente_presentado_cientificaTableAdapter1;
        private System.Windows.Forms.TextBox txtAsesoriaNumero;
        private SPControladoraDatos.dsSpxTableAdapters.estado_asesoria_cientificaTableAdapter estado_asesoria_cientificaTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.seguimiento_asesoria_cientificaTableAdapter seguimiento_asesoria_cientificaTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.accion_seguirxseguimiento_cientificaTableAdapter accion_seguirxseguimiento_cientificaTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.accion_seguir_cientificaTableAdapter accion_seguir_cientificaTableAdapter1;
        private System.Windows.Forms.Label label4;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calCierre;
        private SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter equiposTableAdapter1;
        private System.Windows.Forms.ComboBox cmbRazon;
        private System.Windows.Forms.Label lblRazon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdNoControlCalidad;
        private System.Windows.Forms.RadioButton rdSiControlCalidad;
    }
}