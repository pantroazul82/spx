namespace spHerramientas.consultas
{
    partial class frmIndMantProgxReal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIndMantProgxReal));
            this.calDesde = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.calHasta = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuitarFiltro4 = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregarFilrto3 = new DevComponents.DotNetBar.ButtonX();
            this.btnQuitarFiltro3 = new DevComponents.DotNetBar.ButtonX();
            this.txtFiltro4 = new System.Windows.Forms.TextBox();
            this.cmbFiltro4 = new System.Windows.Forms.ComboBox();
            this.btnAgregarFiltro2 = new DevComponents.DotNetBar.ButtonX();
            this.txtFiltro3 = new System.Windows.Forms.TextBox();
            this.cmbFiltro3 = new System.Windows.Forms.ComboBox();
            this.txtFiltro2 = new System.Windows.Forms.TextBox();
            this.cmbFiltro2 = new System.Windows.Forms.ComboBox();
            this.btnQuitarFiltro2 = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregarFiltro1 = new DevComponents.DotNetBar.ButtonX();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMantRealizados = new System.Windows.Forms.TextBox();
            this.txtMantenimientosProgramdos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.grdDatos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsPlantillas1 = new SPControladoraDatos.dsPlantillas();
            this.pltListadoOrdenServicioTableAdapter1 = new SPControladoraDatos.dsPlantillasTableAdapters.pltListadoOrdenServicioTableAdapter();
            this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
            this.txtIndicador = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grdDatos.BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // calDesde
            // 
            // 
            // 
            // 
            this.calDesde.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calDesde.ButtonDropDown.Visible = true;
            this.calDesde.Location = new System.Drawing.Point(6, 40);
            // 
            // 
            // 
            this.calDesde.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            this.calDesde.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calDesde.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calDesde.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calDesde.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calDesde.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calDesde.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calDesde.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calDesde.MonthCalendar.DisplayMonth = new System.DateTime(2009, 4, 1, 0, 0, 0, 0);
            this.calDesde.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calDesde.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calDesde.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calDesde.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calDesde.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calDesde.MonthCalendar.TodayButtonVisible = true;
            this.calDesde.Name = "calDesde";
            this.calDesde.Size = new System.Drawing.Size(200, 20);
            this.calDesde.TabIndex = 0;
            this.calDesde.Click += new System.EventHandler(this.dateTimeInput1_Click);
            // 
            // calHasta
            // 
            // 
            // 
            // 
            this.calHasta.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calHasta.ButtonDropDown.Visible = true;
            this.calHasta.Location = new System.Drawing.Point(213, 40);
            // 
            // 
            // 
            this.calHasta.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            this.calHasta.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calHasta.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calHasta.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calHasta.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calHasta.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calHasta.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calHasta.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calHasta.MonthCalendar.DisplayMonth = new System.DateTime(2009, 4, 1, 0, 0, 0, 0);
            this.calHasta.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calHasta.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calHasta.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calHasta.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calHasta.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calHasta.MonthCalendar.TodayButtonVisible = true;
            this.calHasta.Name = "calHasta";
            this.calHasta.Size = new System.Drawing.Size(200, 20);
            this.calHasta.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.btnQuitarFiltro4);
            this.groupBox1.Controls.Add(this.btnAgregarFilrto3);
            this.groupBox1.Controls.Add(this.btnQuitarFiltro3);
            this.groupBox1.Controls.Add(this.txtFiltro4);
            this.groupBox1.Controls.Add(this.cmbFiltro4);
            this.groupBox1.Controls.Add(this.btnAgregarFiltro2);
            this.groupBox1.Controls.Add(this.txtFiltro3);
            this.groupBox1.Controls.Add(this.cmbFiltro3);
            this.groupBox1.Controls.Add(this.txtFiltro2);
            this.groupBox1.Controls.Add(this.cmbFiltro2);
            this.groupBox1.Controls.Add(this.btnQuitarFiltro2);
            this.groupBox1.Controls.Add(this.btnAgregarFiltro1);
            this.groupBox1.Controls.Add(this.txtFiltro);
            this.groupBox1.Controls.Add(this.cmbCampo);
            this.groupBox1.Location = new System.Drawing.Point(479, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 132);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnQuitarFiltro4
            // 
            this.btnQuitarFiltro4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuitarFiltro4.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitarFiltro4.Image")));
            this.btnQuitarFiltro4.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnQuitarFiltro4.Location = new System.Drawing.Point(393, 104);
            this.btnQuitarFiltro4.Name = "btnQuitarFiltro4";
            this.btnQuitarFiltro4.Size = new System.Drawing.Size(25, 25);
            this.btnQuitarFiltro4.TabIndex = 84;
            this.btnQuitarFiltro4.Visible = false;
            this.btnQuitarFiltro4.Click += new System.EventHandler(this.btnQuitarFiltro4_Click);
            // 
            // btnAgregarFilrto3
            // 
            this.btnAgregarFilrto3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregarFilrto3.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarFilrto3.Image")));
            this.btnAgregarFilrto3.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnAgregarFilrto3.Location = new System.Drawing.Point(393, 73);
            this.btnAgregarFilrto3.Name = "btnAgregarFilrto3";
            this.btnAgregarFilrto3.Size = new System.Drawing.Size(25, 25);
            this.btnAgregarFilrto3.TabIndex = 83;
            this.btnAgregarFilrto3.Visible = false;
            this.btnAgregarFilrto3.Click += new System.EventHandler(this.btnAgregarFilrto3_Click);
            // 
            // btnQuitarFiltro3
            // 
            this.btnQuitarFiltro3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuitarFiltro3.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitarFiltro3.Image")));
            this.btnQuitarFiltro3.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnQuitarFiltro3.Location = new System.Drawing.Point(424, 73);
            this.btnQuitarFiltro3.Name = "btnQuitarFiltro3";
            this.btnQuitarFiltro3.Size = new System.Drawing.Size(25, 25);
            this.btnQuitarFiltro3.TabIndex = 82;
            this.btnQuitarFiltro3.Visible = false;
            this.btnQuitarFiltro3.Click += new System.EventHandler(this.btnQuitarFiltro3_Click);
            // 
            // txtFiltro4
            // 
            this.txtFiltro4.Location = new System.Drawing.Point(170, 104);
            this.txtFiltro4.Name = "txtFiltro4";
            this.txtFiltro4.Size = new System.Drawing.Size(220, 20);
            this.txtFiltro4.TabIndex = 81;
            this.txtFiltro4.Visible = false;
            // 
            // cmbFiltro4
            // 
            this.cmbFiltro4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro4.FormattingEnabled = true;
            this.cmbFiltro4.Items.AddRange(new object[] {
            "Tipo de Servicio",
            "Prioridad",
            "Ingeniero Asignado",
            "Serial",
            "Nit Cliente",
            "Nombre Cliente",
            "Fabricante",
            "Modelo"});
            this.cmbFiltro4.Location = new System.Drawing.Point(7, 104);
            this.cmbFiltro4.Name = "cmbFiltro4";
            this.cmbFiltro4.Size = new System.Drawing.Size(157, 21);
            this.cmbFiltro4.TabIndex = 80;
            this.cmbFiltro4.Visible = false;
            // 
            // btnAgregarFiltro2
            // 
            this.btnAgregarFiltro2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregarFiltro2.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarFiltro2.Image")));
            this.btnAgregarFiltro2.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnAgregarFiltro2.Location = new System.Drawing.Point(393, 42);
            this.btnAgregarFiltro2.Name = "btnAgregarFiltro2";
            this.btnAgregarFiltro2.Size = new System.Drawing.Size(25, 25);
            this.btnAgregarFiltro2.TabIndex = 78;
            this.btnAgregarFiltro2.Visible = false;
            this.btnAgregarFiltro2.Click += new System.EventHandler(this.btnAgregarFiltro2_Click);
            // 
            // txtFiltro3
            // 
            this.txtFiltro3.Location = new System.Drawing.Point(170, 73);
            this.txtFiltro3.Name = "txtFiltro3";
            this.txtFiltro3.Size = new System.Drawing.Size(220, 20);
            this.txtFiltro3.TabIndex = 77;
            this.txtFiltro3.Visible = false;
            // 
            // cmbFiltro3
            // 
            this.cmbFiltro3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro3.FormattingEnabled = true;
            this.cmbFiltro3.Items.AddRange(new object[] {
            "Tipo de Servicio",
            "Prioridad",
            "Ingeniero Asignado",
            "Serial",
            "Nit Cliente",
            "Nombre Cliente",
            "Fabricante",
            "Modelo"});
            this.cmbFiltro3.Location = new System.Drawing.Point(7, 73);
            this.cmbFiltro3.Name = "cmbFiltro3";
            this.cmbFiltro3.Size = new System.Drawing.Size(157, 21);
            this.cmbFiltro3.TabIndex = 76;
            this.cmbFiltro3.Visible = false;
            // 
            // txtFiltro2
            // 
            this.txtFiltro2.Location = new System.Drawing.Point(170, 42);
            this.txtFiltro2.Name = "txtFiltro2";
            this.txtFiltro2.Size = new System.Drawing.Size(220, 20);
            this.txtFiltro2.TabIndex = 75;
            this.txtFiltro2.Visible = false;
            // 
            // cmbFiltro2
            // 
            this.cmbFiltro2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro2.FormattingEnabled = true;
            this.cmbFiltro2.Items.AddRange(new object[] {
            "Tipo de Servicio",
            "Prioridad",
            "Ingeniero Asignado",
            "Serial",
            "Nit Cliente",
            "Nombre Cliente",
            "Fabricante",
            "Modelo"});
            this.cmbFiltro2.Location = new System.Drawing.Point(7, 42);
            this.cmbFiltro2.Name = "cmbFiltro2";
            this.cmbFiltro2.Size = new System.Drawing.Size(157, 21);
            this.cmbFiltro2.TabIndex = 74;
            this.cmbFiltro2.Visible = false;
            // 
            // btnQuitarFiltro2
            // 
            this.btnQuitarFiltro2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuitarFiltro2.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitarFiltro2.Image")));
            this.btnQuitarFiltro2.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnQuitarFiltro2.Location = new System.Drawing.Point(424, 42);
            this.btnQuitarFiltro2.Name = "btnQuitarFiltro2";
            this.btnQuitarFiltro2.Size = new System.Drawing.Size(25, 25);
            this.btnQuitarFiltro2.TabIndex = 73;
            this.btnQuitarFiltro2.Visible = false;
            this.btnQuitarFiltro2.Click += new System.EventHandler(this.btnQuitarFiltro2_Click);
            // 
            // btnAgregarFiltro1
            // 
            this.btnAgregarFiltro1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregarFiltro1.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarFiltro1.Image")));
            this.btnAgregarFiltro1.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnAgregarFiltro1.Location = new System.Drawing.Point(393, 11);
            this.btnAgregarFiltro1.Name = "btnAgregarFiltro1";
            this.btnAgregarFiltro1.Size = new System.Drawing.Size(25, 25);
            this.btnAgregarFiltro1.TabIndex = 72;
            this.btnAgregarFiltro1.Click += new System.EventHandler(this.btnAgregarFiltro1_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(170, 15);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(220, 20);
            this.txtFiltro.TabIndex = 5;
            // 
            // cmbCampo
            // 
            this.cmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampo.FormattingEnabled = true;
            this.cmbCampo.Items.AddRange(new object[] {
            "Tipo de Servicio",
            "Prioridad",
            "Ingeniero Asignado",
            "Serial",
            "Nit Cliente",
            "Nombre Cliente",
            "Fabricante",
            "Modelo"});
            this.cmbCampo.Location = new System.Drawing.Point(7, 15);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(157, 21);
            this.cmbCampo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mantenimientos Realizados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mantenimientos Programados";
            // 
            // txtMantRealizados
            // 
            this.txtMantRealizados.BackColor = System.Drawing.Color.White;
            this.txtMantRealizados.Location = new System.Drawing.Point(639, 182);
            this.txtMantRealizados.Name = "txtMantRealizados";
            this.txtMantRealizados.ReadOnly = true;
            this.txtMantRealizados.Size = new System.Drawing.Size(56, 20);
            this.txtMantRealizados.TabIndex = 9;
            // 
            // txtMantenimientosProgramdos
            // 
            this.txtMantenimientosProgramdos.BackColor = System.Drawing.Color.White;
            this.txtMantenimientosProgramdos.Location = new System.Drawing.Point(639, 156);
            this.txtMantenimientosProgramdos.Name = "txtMantenimientosProgramdos";
            this.txtMantenimientosProgramdos.ReadOnly = true;
            this.txtMantenimientosProgramdos.Size = new System.Drawing.Size(56, 20);
            this.txtMantenimientosProgramdos.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ordenes de Servicio Desde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ordenes de Servicio Hasta";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageFixedSize = new System.Drawing.Size(35, 35);
            this.btnBuscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBuscar.Location = new System.Drawing.Point(415, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(58, 58);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Generar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUpdate = false;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.DataMember = "pltListadoOrdenServicio";
            this.grdDatos.DataSource = this.dsPlantillas1;
            this.grdDatos.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdDatos.FilterBar = true;
            this.grdDatos.GroupByCaption = "";
            this.grdDatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDatos.Images"))));
            this.grdDatos.Location = new System.Drawing.Point(435, 235);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(522, 475);
            this.grdDatos.TabIndex = 14;
            this.grdDatos.Text = "c1TrueDBGrid1";
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
            // 
            // dsPlantillas1
            // 
            this.dsPlantillas1.DataSetName = "dsPlantillas";
            this.dsPlantillas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pltListadoOrdenServicioTableAdapter1
            // 
            this.pltListadoOrdenServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // c1Chart1
            // 
            this.c1Chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.c1Chart1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.c1Chart1.Location = new System.Drawing.Point(6, 99);
            this.c1Chart1.Name = "c1Chart1";
            this.c1Chart1.PropBag = resources.GetString("c1Chart1.PropBag");
            this.c1Chart1.Size = new System.Drawing.Size(407, 603);
            this.c1Chart1.TabIndex = 15;
            // 
            // txtIndicador
            // 
            this.txtIndicador.BackColor = System.Drawing.Color.White;
            this.txtIndicador.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndicador.Location = new System.Drawing.Point(719, 167);
            this.txtIndicador.Name = "txtIndicador";
            this.txtIndicador.ReadOnly = true;
            this.txtIndicador.Size = new System.Drawing.Size(56, 35);
            this.txtIndicador.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(716, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Indicador";
            // 
            // frmIndMantProgxReal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(969, 722);
            this.Controls.Add(this.txtIndicador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.c1Chart1);
            this.Controls.Add(this.grdDatos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMantenimientosProgramdos);
            this.Controls.Add(this.txtMantRealizados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.calHasta);
            this.Controls.Add(this.calDesde);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIndMantProgxReal";
            this.Text = "OS Programados -  OS Realizadas";
            this.Load += new System.EventHandler(this.frmIndMantProgxReal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.Editors.DateTimeAdv.DateTimeInput calDesde;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calHasta;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnQuitarFiltro4;
        private DevComponents.DotNetBar.ButtonX btnAgregarFilrto3;
        private DevComponents.DotNetBar.ButtonX btnQuitarFiltro3;
        private System.Windows.Forms.TextBox txtFiltro4;
        private System.Windows.Forms.ComboBox cmbFiltro4;
        private DevComponents.DotNetBar.ButtonX btnAgregarFiltro2;
        private System.Windows.Forms.TextBox txtFiltro3;
        private System.Windows.Forms.ComboBox cmbFiltro3;
        private System.Windows.Forms.TextBox txtFiltro2;
        private System.Windows.Forms.ComboBox cmbFiltro2;
        private DevComponents.DotNetBar.ButtonX btnQuitarFiltro2;
        private DevComponents.DotNetBar.ButtonX btnAgregarFiltro1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ComboBox cmbCampo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMantRealizados;
        private System.Windows.Forms.TextBox txtMantenimientosProgramdos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.ButtonX btnBuscar;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdDatos;
        private SPControladoraDatos.dsPlantillas dsPlantillas1;
        private SPControladoraDatos.dsPlantillasTableAdapters.pltListadoOrdenServicioTableAdapter pltListadoOrdenServicioTableAdapter1;
        private C1.Win.C1Chart.C1Chart c1Chart1;
        private System.Windows.Forms.TextBox txtIndicador;
        private System.Windows.Forms.Label label5;
    }
}