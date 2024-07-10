namespace spProcesos.ordenPrestamo
{
    partial class frmListadoOrdenPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoOrdenPrestamo));
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.btnVerOrdenprestamo = new DevComponents.DotNetBar.ButtonX();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.btnVerOrdenServicio2 = new DevComponents.DotNetBar.ButtonX();
            this.calFechaFin = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.chkEntreFechas = new System.Windows.Forms.CheckBox();
            this.calfechaInicio = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkautorizadas = new System.Windows.Forms.CheckBox();
            this.chkDevueltos = new System.Windows.Forms.CheckBox();
            this.chkAnuladas = new System.Windows.Forms.CheckBox();
            this.chkPendientesxAutorizacion = new System.Windows.Forms.CheckBox();
            this.chkEntregadosIng = new System.Windows.Forms.CheckBox();
            this.chkRechazadas = new System.Windows.Forms.CheckBox();
            this.grdOrdenPrestamo = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsPlantillas1 = new SPControladoraDatos.dsPlantillas();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
       
            this.panel1 = new System.Windows.Forms.Panel();
            this.grdEstadisticas = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.estadosOrdenPrestamoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.estadosOrdenPrestamoTableAdapter();
            this.controladorColumnas1 = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calfechaInicio)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrdenPrestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEstadisticas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2});
            this.dataTable1.TableName = "tablaEstados";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "estado";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "cantidad";
            this.dataColumn2.DataType = typeof(int);
            // 
            // btnVerOrdenprestamo
            // 
            this.btnVerOrdenprestamo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVerOrdenprestamo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnVerOrdenprestamo, "Ver Orden Prestamo");
            this.btnVerOrdenprestamo.Image = ((System.Drawing.Image)(resources.GetObject("btnVerOrdenprestamo.Image")));
            this.btnVerOrdenprestamo.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnVerOrdenprestamo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnVerOrdenprestamo.Location = new System.Drawing.Point(759, 101);
            this.btnVerOrdenprestamo.Name = "btnVerOrdenprestamo";
            this.btnVerOrdenprestamo.Size = new System.Drawing.Size(33, 29);
            this.btnVerOrdenprestamo.TabIndex = 104;
            this.btnVerOrdenprestamo.Click += new System.EventHandler(this.btnVerOrdenServicio_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnBuscar, "Buscar");
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnBuscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBuscar.Location = new System.Drawing.Point(421, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(27, 28);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVerOrdenServicio2
            // 
            this.btnVerOrdenServicio2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVerOrdenServicio2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnVerOrdenServicio2, "Ver Orden Servicio");
            this.btnVerOrdenServicio2.Image = ((System.Drawing.Image)(resources.GetObject("btnVerOrdenServicio2.Image")));
            this.btnVerOrdenServicio2.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnVerOrdenServicio2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnVerOrdenServicio2.Location = new System.Drawing.Point(724, 101);
            this.btnVerOrdenServicio2.Name = "btnVerOrdenServicio2";
            this.btnVerOrdenServicio2.Size = new System.Drawing.Size(33, 29);
            this.btnVerOrdenServicio2.TabIndex = 108;
            this.btnVerOrdenServicio2.Click += new System.EventHandler(this.btnVerOrdenServicio2_Click);
            // 
            // calFechaFin
            // 
            // 
            // 
            // 
            this.calFechaFin.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calFechaFin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaFin.ButtonDropDown.Visible = true;
            this.calFechaFin.Location = new System.Drawing.Point(450, 99);
            // 
            // 
            // 
            this.calFechaFin.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFechaFin.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calFechaFin.MonthCalendar.BackgroundStyle.Class = "";
            this.calFechaFin.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaFin.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calFechaFin.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calFechaFin.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calFechaFin.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calFechaFin.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calFechaFin.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calFechaFin.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calFechaFin.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calFechaFin.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaFin.MonthCalendar.DisplayMonth = new System.DateTime(2008, 10, 1, 0, 0, 0, 0);
            this.calFechaFin.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calFechaFin.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calFechaFin.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFechaFin.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calFechaFin.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calFechaFin.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calFechaFin.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calFechaFin.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaFin.MonthCalendar.TodayButtonVisible = true;
            this.calFechaFin.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calFechaFin.Name = "calFechaFin";
            this.calFechaFin.Size = new System.Drawing.Size(200, 20);
            this.calFechaFin.TabIndex = 103;
            // 
            // chkEntreFechas
            // 
            this.chkEntreFechas.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEntreFechas.Location = new System.Drawing.Point(12, 99);
            this.chkEntreFechas.Name = "chkEntreFechas";
            this.chkEntreFechas.Size = new System.Drawing.Size(206, 31);
            this.chkEntreFechas.TabIndex = 102;
            this.chkEntreFechas.Text = "Buscar Resultados solo para ordenes de Prestamo entre las Fechas:";
            this.chkEntreFechas.UseVisualStyleBackColor = true;
            // 
            // calfechaInicio
            // 
            // 
            // 
            // 
            this.calfechaInicio.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calfechaInicio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calfechaInicio.ButtonDropDown.Visible = true;
            this.calfechaInicio.Location = new System.Drawing.Point(226, 99);
            // 
            // 
            // 
            this.calfechaInicio.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calfechaInicio.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calfechaInicio.MonthCalendar.BackgroundStyle.Class = "";
            this.calfechaInicio.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calfechaInicio.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calfechaInicio.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calfechaInicio.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calfechaInicio.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calfechaInicio.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calfechaInicio.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calfechaInicio.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calfechaInicio.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calfechaInicio.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calfechaInicio.MonthCalendar.DisplayMonth = new System.DateTime(2008, 10, 1, 0, 0, 0, 0);
            this.calfechaInicio.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calfechaInicio.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calfechaInicio.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calfechaInicio.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calfechaInicio.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calfechaInicio.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calfechaInicio.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calfechaInicio.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calfechaInicio.MonthCalendar.TodayButtonVisible = true;
            this.calfechaInicio.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calfechaInicio.Name = "calfechaInicio";
            this.calfechaInicio.Size = new System.Drawing.Size(200, 20);
            this.calfechaInicio.TabIndex = 101;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtFiltro);
            this.groupBox1.Controls.Add(this.cmbFiltro);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 68);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(195, 25);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(220, 21);
            this.txtFiltro.TabIndex = 0;
            this.txtFiltro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFiltro_KeyDown);
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Codigo Orden de Prestamo",
            "Codigo Orden de Servicio",
            "Estado Orden Prestamo",
            "Solicitado Por"});
            this.cmbFiltro.Location = new System.Drawing.Point(6, 26);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(184, 21);
            this.cmbFiltro.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkautorizadas);
            this.groupBox2.Controls.Add(this.chkDevueltos);
            this.groupBox2.Controls.Add(this.chkAnuladas);
            this.groupBox2.Controls.Add(this.chkPendientesxAutorizacion);
            this.groupBox2.Controls.Add(this.chkEntregadosIng);
            this.groupBox2.Controls.Add(this.chkRechazadas);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(491, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(522, 67);
            this.groupBox2.TabIndex = 107;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros de Estado";
            // 
            // chkautorizadas
            // 
            this.chkautorizadas.AutoSize = true;
            this.chkautorizadas.Checked = true;
            this.chkautorizadas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkautorizadas.Location = new System.Drawing.Point(7, 44);
            this.chkautorizadas.Name = "chkautorizadas";
            this.chkautorizadas.Size = new System.Drawing.Size(191, 19);
            this.chkautorizadas.TabIndex = 5;
            this.chkautorizadas.Text = "Autorizadas (Por entregar Ing)";
            this.chkautorizadas.UseVisualStyleBackColor = true;
            // 
            // chkDevueltos
            // 
            this.chkDevueltos.AutoSize = true;
            this.chkDevueltos.Checked = true;
            this.chkDevueltos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDevueltos.Location = new System.Drawing.Point(302, 44);
            this.chkDevueltos.Name = "chkDevueltos";
            this.chkDevueltos.Size = new System.Drawing.Size(192, 19);
            this.chkDevueltos.TabIndex = 4;
            this.chkDevueltos.Text = "Repustos devueltos a Almacen";
            this.chkDevueltos.UseVisualStyleBackColor = true;
            // 
            // chkAnuladas
            // 
            this.chkAnuladas.AutoSize = true;
            this.chkAnuladas.Checked = true;
            this.chkAnuladas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAnuladas.Location = new System.Drawing.Point(200, 44);
            this.chkAnuladas.Name = "chkAnuladas";
            this.chkAnuladas.Size = new System.Drawing.Size(78, 19);
            this.chkAnuladas.TabIndex = 3;
            this.chkAnuladas.Text = "Anuladas";
            this.chkAnuladas.UseVisualStyleBackColor = true;
            // 
            // chkPendientesxAutorizacion
            // 
            this.chkPendientesxAutorizacion.AutoSize = true;
            this.chkPendientesxAutorizacion.Checked = true;
            this.chkPendientesxAutorizacion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPendientesxAutorizacion.Location = new System.Drawing.Point(6, 19);
            this.chkPendientesxAutorizacion.Name = "chkPendientesxAutorizacion";
            this.chkPendientesxAutorizacion.Size = new System.Drawing.Size(181, 19);
            this.chkPendientesxAutorizacion.TabIndex = 2;
            this.chkPendientesxAutorizacion.Text = "Pendientes Por Autorizacion";
            this.chkPendientesxAutorizacion.UseVisualStyleBackColor = true;
            // 
            // chkEntregadosIng
            // 
            this.chkEntregadosIng.AutoSize = true;
            this.chkEntregadosIng.Checked = true;
            this.chkEntregadosIng.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEntregadosIng.Location = new System.Drawing.Point(302, 20);
            this.chkEntregadosIng.Name = "chkEntregadosIng";
            this.chkEntregadosIng.Size = new System.Drawing.Size(215, 19);
            this.chkEntregadosIng.TabIndex = 1;
            this.chkEntregadosIng.Text = "Repuestos Entregados al Ingeniero";
            this.chkEntregadosIng.UseVisualStyleBackColor = true;
            // 
            // chkRechazadas
            // 
            this.chkRechazadas.AutoSize = true;
            this.chkRechazadas.Checked = true;
            this.chkRechazadas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRechazadas.Location = new System.Drawing.Point(200, 20);
            this.chkRechazadas.Name = "chkRechazadas";
            this.chkRechazadas.Size = new System.Drawing.Size(91, 19);
            this.chkRechazadas.TabIndex = 0;
            this.chkRechazadas.Text = "Rechazadas";
            this.chkRechazadas.UseVisualStyleBackColor = true;
            // 
            // grdOrdenPrestamo
            // 
            this.grdOrdenPrestamo.AllowUpdate = false;
            this.grdOrdenPrestamo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdOrdenPrestamo.DataMember = "pltOrdenPrestamo";
            this.grdOrdenPrestamo.DataSource = this.dsPlantillas1;
            this.grdOrdenPrestamo.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdOrdenPrestamo.FilterBar = true;
            this.grdOrdenPrestamo.GroupByCaption = "";
            this.grdOrdenPrestamo.Images.Add(((System.Drawing.Image)(resources.GetObject("grdOrdenPrestamo.Images"))));
            this.grdOrdenPrestamo.Location = new System.Drawing.Point(12, 136);
            this.grdOrdenPrestamo.Name = "grdOrdenPrestamo";
            this.grdOrdenPrestamo.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdOrdenPrestamo.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdOrdenPrestamo.PreviewInfo.ZoomFactor = 75D;
            this.grdOrdenPrestamo.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdOrdenPrestamo.PrintInfo.PageSettings")));
            this.grdOrdenPrestamo.Size = new System.Drawing.Size(996, 496);
            this.grdOrdenPrestamo.TabIndex = 1;
            this.grdOrdenPrestamo.Text = "c1TrueDBGrid1";
            this.grdOrdenPrestamo.PropBag = resources.GetString("grdOrdenPrestamo.PropBag");
            // 
            // dsPlantillas1
            // 
            this.dsPlantillas1.DataSetName = "dsPlantillas";
            this.dsPlantillas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            //panel
            this.panel1.Controls.Add(this.grdEstadisticas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 638);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 92);
            this.panel1.TabIndex = 109;
            // 
            // grdEstadisticas
            // 
            this.grdEstadisticas.AllowUpdate = false;
            this.grdEstadisticas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdEstadisticas.CaptionHeight = 17;
            this.grdEstadisticas.DataMember = "estadosOrdenPrestamo";
            this.grdEstadisticas.DataSource = this.dsSpx1;
            this.grdEstadisticas.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.Inverted;
            this.grdEstadisticas.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdEstadisticas.GroupByCaption = "Drag a column header here to group by that column";
            this.grdEstadisticas.Images.Add(((System.Drawing.Image)(resources.GetObject("grdEstadisticas.Images"))));
            this.grdEstadisticas.Location = new System.Drawing.Point(10, 9);
            this.grdEstadisticas.Name = "grdEstadisticas";
            this.grdEstadisticas.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdEstadisticas.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdEstadisticas.PreviewInfo.ZoomFactor = 75D;
            this.grdEstadisticas.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdEstadisticas.PrintInfo.PageSettings")));
            this.grdEstadisticas.RowHeight = 15;
            this.grdEstadisticas.Size = new System.Drawing.Size(998, 74);
            this.grdEstadisticas.TabIndex = 0;
            this.grdEstadisticas.Text = "c1TrueDBGrid1";
            this.grdEstadisticas.PropBag = resources.GetString("grdEstadisticas.PropBag");
            // 
            // estadosOrdenPrestamoTableAdapter1
            // 
            this.estadosOrdenPrestamoTableAdapter1.ClearBeforeFill = true;
            // 
            // controladorColumnas1
            // 
            this.controladorColumnas1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controladorColumnas1.BackColor = System.Drawing.Color.Transparent;
            this.controladorColumnas1.grilla = null;
            this.controladorColumnas1.Location = new System.Drawing.Point(792, 101);
            this.controladorColumnas1.MostrarContraer = true;
            this.controladorColumnas1.MostrarExcel = true;
            this.controladorColumnas1.MostrarExpandir = true;
            this.controladorColumnas1.MostrarLimpiar = true;
            this.controladorColumnas1.Name = "controladorColumnas1";
            this.controladorColumnas1.nombreLibro = null;
            this.controladorColumnas1.Size = new System.Drawing.Size(216, 29);
            this.controladorColumnas1.TabIndex = 110;
            // 
            // frmListadoOrdenPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 730);
            this.Controls.Add(this.controladorColumnas1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.calfechaInicio);
            this.Controls.Add(this.btnVerOrdenServicio2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnVerOrdenprestamo);
            this.Controls.Add(this.calFechaFin);
            this.Controls.Add(this.chkEntreFechas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdOrdenPrestamo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListadoOrdenPrestamo";
            this.Text = "Listado Ordenes de Prestamo";
            this.Load += new System.EventHandler(this.frmListadoOrdenPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calfechaInicio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrdenPrestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdEstadisticas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsPlantillasTableAdapters.pltOrdenPrestamoTableAdapter pltOrdenPrestamoTableAdapter1;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdOrdenPrestamo;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private DevComponents.DotNetBar.ButtonX btnVerOrdenprestamo;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFechaFin;
        private System.Windows.Forms.CheckBox chkEntreFechas;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calfechaInicio;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnBuscar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkPendientesxAutorizacion;
        private System.Windows.Forms.CheckBox chkEntregadosIng;
        private System.Windows.Forms.CheckBox chkRechazadas;
        private System.Windows.Forms.CheckBox chkautorizadas;
        private System.Windows.Forms.CheckBox chkDevueltos;
        private System.Windows.Forms.CheckBox chkAnuladas;
        private DevComponents.DotNetBar.ButtonX btnVerOrdenServicio2;
        private SPControladoraDatos.dsPlantillas dsPlantillas1;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdEstadisticas;
        private SPControladoraDatos.dsSpxTableAdapters.estadosOrdenPrestamoTableAdapter estadosOrdenPrestamoTableAdapter1;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas controladorColumnas1;
    }
}