namespace spProcesos.ordenesTrabajo
{
    partial class frmListadoOrdenesServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoOrdenesServicio));
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.ordenServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter();
            this.grdDatos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsPlantillas1 = new SPControladoraDatos.dsPlantillas();
            this.btnFiltrarxEstado = new DevComponents.DotNetBar.ButtonX();
            this.cmbEstados = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.calfechaInicio = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.chkEntreFechas = new System.Windows.Forms.CheckBox();
            this.calFechaFin = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnVerOrdenServicio = new DevComponents.DotNetBar.ButtonX();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.pltListadoOrdenServicioTableAdapter1 = new SPControladoraDatos.dsPlantillasTableAdapters.pltListadoOrdenServicioTableAdapter();
            this.estadosOrdenServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.estadosOrdenServicioTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.calFinCerrada = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.chkFechasCerradas = new System.Windows.Forms.CheckBox();
            this.calInicioCerrada = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.calFinAprobada = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.chkAprobadas = new System.Windows.Forms.CheckBox();
            this.calInicioAprobadas = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.controladorColumnas1 = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas();
            this.calFinProgramadas = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.chkProgramadas = new System.Windows.Forms.CheckBox();
            this.calInicioProgramadas = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.grdDatos.BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calfechaInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFinCerrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calInicioCerrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFinAprobada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calInicioAprobadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFinProgramadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calInicioProgramadas)).BeginInit();
            this.SuspendLayout();
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordenServicioTableAdapter1
            // 
            this.ordenServicioTableAdapter1.ClearBeforeFill = true;
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
            this.grdDatos.Location = new System.Drawing.Point(12, 169);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75D;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(984, 435);
            this.grdDatos.TabIndex = 0;
            this.grdDatos.Text = "c1TrueDBGrid1";
            this.grdDatos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
            // 
            // dsPlantillas1
            // 
            this.dsPlantillas1.DataSetName = "dsPlantillas";
            this.dsPlantillas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnFiltrarxEstado
            // 
            this.btnFiltrarxEstado.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFiltrarxEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnFiltrarxEstado, "Filtrar por Estado");
            this.balloonTip1.SetBalloonText(this.btnFiltrarxEstado, null);
            this.btnFiltrarxEstado.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrarxEstado.Image")));
            this.btnFiltrarxEstado.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnFiltrarxEstado.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnFiltrarxEstado.Location = new System.Drawing.Point(967, 12);
            this.btnFiltrarxEstado.Name = "btnFiltrarxEstado";
            this.btnFiltrarxEstado.Size = new System.Drawing.Size(33, 33);
            this.btnFiltrarxEstado.TabIndex = 19;
            this.btnFiltrarxEstado.Click += new System.EventHandler(this.btnFiltrarxEstado_Click);
            // 
            // cmbEstados
            // 
            this.cmbEstados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEstados.DataSource = this.dsSpx1;
            this.cmbEstados.DisplayMember = "estadosOrdenServicio.nombreEstado";
            this.cmbEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstados.FormattingEnabled = true;
            this.cmbEstados.Location = new System.Drawing.Point(786, 12);
            this.cmbEstados.Name = "cmbEstados";
            this.cmbEstados.Size = new System.Drawing.Size(175, 21);
            this.cmbEstados.TabIndex = 18;
            this.cmbEstados.ValueMember = "estadosOrdenServicio.codEstadoOrdenServicio";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtFiltro);
            this.groupBox1.Controls.Add(this.cmbFiltro);
            this.groupBox1.Location = new System.Drawing.Point(12, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnBuscar, "Buscar");
            this.balloonTip1.SetBalloonText(this.btnBuscar, null);
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnBuscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBuscar.Location = new System.Drawing.Point(456, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(33, 33);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(230, 26);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(220, 20);
            this.txtFiltro.TabIndex = 0;
            this.txtFiltro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFiltro_KeyDown);
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Codigo Orden de Servicio",
            "Numero de Entrada",
            "Serial",
            "Nit Cliente",
            "Cliente",
            "Numero Socio",
            "Modelo",
            "Ciudad",
            "Departamento"});
            this.cmbFiltro.Location = new System.Drawing.Point(6, 26);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(218, 21);
            this.cmbFiltro.TabIndex = 1;
            // 
            // calfechaInicio
            // 
            // 
            // 
            // 
            this.calfechaInicio.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calfechaInicio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calfechaInicio.ButtonDropDown.Visible = true;
            this.calfechaInicio.Location = new System.Drawing.Point(372, 89);
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
            this.calfechaInicio.Size = new System.Drawing.Size(139, 20);
            this.calfechaInicio.TabIndex = 20;
            // 
            // chkEntreFechas
            // 
            this.chkEntreFechas.AutoSize = true;
            this.chkEntreFechas.Location = new System.Drawing.Point(12, 91);
            this.chkEntreFechas.Name = "chkEntreFechas";
            this.chkEntreFechas.Size = new System.Drawing.Size(327, 17);
            this.chkEntreFechas.TabIndex = 21;
            this.chkEntreFechas.Text = "Buscar Resultados solo para ordenes creadas entre las Fechas:";
            this.chkEntreFechas.UseVisualStyleBackColor = true;
            // 
            // calFechaFin
            // 
            // 
            // 
            // 
            this.calFechaFin.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calFechaFin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaFin.ButtonDropDown.Visible = true;
            this.calFechaFin.Location = new System.Drawing.Point(517, 88);
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
            this.calFechaFin.Size = new System.Drawing.Size(139, 20);
            this.calFechaFin.TabIndex = 22;
            // 
            // btnVerOrdenServicio
            // 
            this.btnVerOrdenServicio.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVerOrdenServicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnVerOrdenServicio, "Ver Orden");
            this.balloonTip1.SetBalloonText(this.btnVerOrdenServicio, null);
            this.btnVerOrdenServicio.Image = ((System.Drawing.Image)(resources.GetObject("btnVerOrdenServicio.Image")));
            this.btnVerOrdenServicio.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnVerOrdenServicio.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnVerOrdenServicio.Location = new System.Drawing.Point(756, 134);
            this.btnVerOrdenServicio.Name = "btnVerOrdenServicio";
            this.btnVerOrdenServicio.Size = new System.Drawing.Size(27, 28);
            this.btnVerOrdenServicio.TabIndex = 23;
            this.btnVerOrdenServicio.Click += new System.EventHandler(this.btnVerOrdenServicio_Click);
            // 
            // pltListadoOrdenServicioTableAdapter1
            // 
            this.pltListadoOrdenServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // estadosOrdenServicioTableAdapter1
            // 
            this.estadosOrdenServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(741, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 96;
            this.label1.Text = "Estado";
            // 
            // calFinCerrada
            // 
            // 
            // 
            // 
            this.calFinCerrada.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calFinCerrada.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinCerrada.ButtonDropDown.Visible = true;
            this.calFinCerrada.Location = new System.Drawing.Point(517, 114);
            // 
            // 
            // 
            this.calFinCerrada.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFinCerrada.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calFinCerrada.MonthCalendar.BackgroundStyle.Class = "";
            this.calFinCerrada.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinCerrada.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calFinCerrada.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calFinCerrada.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calFinCerrada.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calFinCerrada.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calFinCerrada.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calFinCerrada.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calFinCerrada.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calFinCerrada.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinCerrada.MonthCalendar.DisplayMonth = new System.DateTime(2008, 10, 1, 0, 0, 0, 0);
            this.calFinCerrada.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calFinCerrada.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calFinCerrada.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFinCerrada.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calFinCerrada.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calFinCerrada.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calFinCerrada.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calFinCerrada.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinCerrada.MonthCalendar.TodayButtonVisible = true;
            this.calFinCerrada.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calFinCerrada.Name = "calFinCerrada";
            this.calFinCerrada.Size = new System.Drawing.Size(139, 20);
            this.calFinCerrada.TabIndex = 99;
            // 
            // chkFechasCerradas
            // 
            this.chkFechasCerradas.AutoSize = true;
            this.chkFechasCerradas.Location = new System.Drawing.Point(12, 117);
            this.chkFechasCerradas.Name = "chkFechasCerradas";
            this.chkFechasCerradas.Size = new System.Drawing.Size(330, 17);
            this.chkFechasCerradas.TabIndex = 98;
            this.chkFechasCerradas.Text = "Buscar Resultados solo para ordenes cerradas entre las Fechas:";
            this.chkFechasCerradas.UseVisualStyleBackColor = true;
            // 
            // calInicioCerrada
            // 
            // 
            // 
            // 
            this.calInicioCerrada.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calInicioCerrada.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioCerrada.ButtonDropDown.Visible = true;
            this.calInicioCerrada.Location = new System.Drawing.Point(372, 115);
            // 
            // 
            // 
            this.calInicioCerrada.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calInicioCerrada.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calInicioCerrada.MonthCalendar.BackgroundStyle.Class = "";
            this.calInicioCerrada.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioCerrada.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calInicioCerrada.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calInicioCerrada.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calInicioCerrada.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calInicioCerrada.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calInicioCerrada.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calInicioCerrada.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calInicioCerrada.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calInicioCerrada.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioCerrada.MonthCalendar.DisplayMonth = new System.DateTime(2008, 10, 1, 0, 0, 0, 0);
            this.calInicioCerrada.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calInicioCerrada.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calInicioCerrada.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calInicioCerrada.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calInicioCerrada.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calInicioCerrada.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calInicioCerrada.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calInicioCerrada.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioCerrada.MonthCalendar.TodayButtonVisible = true;
            this.calInicioCerrada.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calInicioCerrada.Name = "calInicioCerrada";
            this.calInicioCerrada.Size = new System.Drawing.Size(139, 20);
            this.calInicioCerrada.TabIndex = 97;
            // 
            // calFinAprobada
            // 
            // 
            // 
            // 
            this.calFinAprobada.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calFinAprobada.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinAprobada.ButtonDropDown.Visible = true;
            this.calFinAprobada.Location = new System.Drawing.Point(517, 142);
            // 
            // 
            // 
            this.calFinAprobada.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFinAprobada.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calFinAprobada.MonthCalendar.BackgroundStyle.Class = "";
            this.calFinAprobada.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinAprobada.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calFinAprobada.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calFinAprobada.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calFinAprobada.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calFinAprobada.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calFinAprobada.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calFinAprobada.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calFinAprobada.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calFinAprobada.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinAprobada.MonthCalendar.DisplayMonth = new System.DateTime(2008, 10, 1, 0, 0, 0, 0);
            this.calFinAprobada.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calFinAprobada.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calFinAprobada.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFinAprobada.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calFinAprobada.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calFinAprobada.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calFinAprobada.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calFinAprobada.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinAprobada.MonthCalendar.TodayButtonVisible = true;
            this.calFinAprobada.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calFinAprobada.Name = "calFinAprobada";
            this.calFinAprobada.Size = new System.Drawing.Size(139, 20);
            this.calFinAprobada.TabIndex = 102;
            // 
            // chkAprobadas
            // 
            this.chkAprobadas.AutoSize = true;
            this.chkAprobadas.Location = new System.Drawing.Point(12, 145);
            this.chkAprobadas.Name = "chkAprobadas";
            this.chkAprobadas.Size = new System.Drawing.Size(340, 17);
            this.chkAprobadas.TabIndex = 101;
            this.chkAprobadas.Text = "Buscar Resultados solo para ordenes Aprobadas entre las Fechas:";
            this.chkAprobadas.UseVisualStyleBackColor = true;
            // 
            // calInicioAprobadas
            // 
            // 
            // 
            // 
            this.calInicioAprobadas.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calInicioAprobadas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioAprobadas.ButtonDropDown.Visible = true;
            this.calInicioAprobadas.Location = new System.Drawing.Point(372, 143);
            // 
            // 
            // 
            this.calInicioAprobadas.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calInicioAprobadas.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calInicioAprobadas.MonthCalendar.BackgroundStyle.Class = "";
            this.calInicioAprobadas.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioAprobadas.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calInicioAprobadas.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calInicioAprobadas.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calInicioAprobadas.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calInicioAprobadas.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calInicioAprobadas.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calInicioAprobadas.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calInicioAprobadas.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calInicioAprobadas.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioAprobadas.MonthCalendar.DisplayMonth = new System.DateTime(2008, 10, 1, 0, 0, 0, 0);
            this.calInicioAprobadas.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calInicioAprobadas.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calInicioAprobadas.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calInicioAprobadas.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calInicioAprobadas.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calInicioAprobadas.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calInicioAprobadas.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calInicioAprobadas.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioAprobadas.MonthCalendar.TodayButtonVisible = true;
            this.calInicioAprobadas.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calInicioAprobadas.Name = "calInicioAprobadas";
            this.calInicioAprobadas.Size = new System.Drawing.Size(139, 20);
            this.calInicioAprobadas.TabIndex = 100;
            // 
            // controladorColumnas1
            // 
            this.controladorColumnas1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controladorColumnas1.BackColor = System.Drawing.Color.Transparent;
            this.controladorColumnas1.grilla = null;
            this.controladorColumnas1.Location = new System.Drawing.Point(784, 134);
            this.controladorColumnas1.MostrarContraer = true;
            this.controladorColumnas1.MostrarExcel = true;
            this.controladorColumnas1.MostrarExpandir = true;
            this.controladorColumnas1.MostrarLimpiar = true;
            this.controladorColumnas1.Name = "controladorColumnas1";
            this.controladorColumnas1.nombreLibro = null;
            this.controladorColumnas1.Size = new System.Drawing.Size(216, 29);
            this.controladorColumnas1.TabIndex = 103;
            // 
            // calFinProgramadas
            // 
            // 
            // 
            // 
            this.calFinProgramadas.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calFinProgramadas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinProgramadas.ButtonDropDown.Visible = true;
            this.calFinProgramadas.Location = new System.Drawing.Point(517, 62);
            // 
            // 
            // 
            this.calFinProgramadas.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFinProgramadas.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calFinProgramadas.MonthCalendar.BackgroundStyle.Class = "";
            this.calFinProgramadas.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinProgramadas.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calFinProgramadas.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calFinProgramadas.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calFinProgramadas.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calFinProgramadas.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calFinProgramadas.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calFinProgramadas.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calFinProgramadas.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calFinProgramadas.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinProgramadas.MonthCalendar.DisplayMonth = new System.DateTime(2008, 10, 1, 0, 0, 0, 0);
            this.calFinProgramadas.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calFinProgramadas.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calFinProgramadas.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFinProgramadas.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calFinProgramadas.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calFinProgramadas.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calFinProgramadas.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calFinProgramadas.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinProgramadas.MonthCalendar.TodayButtonVisible = true;
            this.calFinProgramadas.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calFinProgramadas.Name = "calFinProgramadas";
            this.calFinProgramadas.Size = new System.Drawing.Size(139, 20);
            this.calFinProgramadas.TabIndex = 109;
            // 
            // chkProgramadas
            // 
            this.chkProgramadas.AutoSize = true;
            this.chkProgramadas.Location = new System.Drawing.Point(12, 65);
            this.chkProgramadas.Name = "chkProgramadas";
            this.chkProgramadas.Size = new System.Drawing.Size(350, 17);
            this.chkProgramadas.TabIndex = 108;
            this.chkProgramadas.Text = "Buscar Resultados solo para ordenes programadas entre las Fechas:";
            this.chkProgramadas.UseVisualStyleBackColor = true;
            // 
            // calInicioProgramadas
            // 
            // 
            // 
            // 
            this.calInicioProgramadas.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calInicioProgramadas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioProgramadas.ButtonDropDown.Visible = true;
            this.calInicioProgramadas.Location = new System.Drawing.Point(372, 63);
            // 
            // 
            // 
            this.calInicioProgramadas.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calInicioProgramadas.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calInicioProgramadas.MonthCalendar.BackgroundStyle.Class = "";
            this.calInicioProgramadas.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioProgramadas.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calInicioProgramadas.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calInicioProgramadas.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calInicioProgramadas.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calInicioProgramadas.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calInicioProgramadas.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calInicioProgramadas.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calInicioProgramadas.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calInicioProgramadas.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioProgramadas.MonthCalendar.DisplayMonth = new System.DateTime(2008, 10, 1, 0, 0, 0, 0);
            this.calInicioProgramadas.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calInicioProgramadas.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calInicioProgramadas.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calInicioProgramadas.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calInicioProgramadas.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calInicioProgramadas.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calInicioProgramadas.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calInicioProgramadas.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioProgramadas.MonthCalendar.TodayButtonVisible = true;
            this.calInicioProgramadas.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calInicioProgramadas.Name = "calInicioProgramadas";
            this.calInicioProgramadas.Size = new System.Drawing.Size(139, 20);
            this.calInicioProgramadas.TabIndex = 107;
            // 
            // frmListadoOrdenesServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1008, 616);
            this.Controls.Add(this.calFinProgramadas);
            this.Controls.Add(this.chkProgramadas);
            this.Controls.Add(this.calInicioProgramadas);
            this.Controls.Add(this.controladorColumnas1);
            this.Controls.Add(this.btnVerOrdenServicio);
            this.Controls.Add(this.calInicioAprobadas);
            this.Controls.Add(this.calFinAprobada);
            this.Controls.Add(this.chkAprobadas);
            this.Controls.Add(this.calFinCerrada);
            this.Controls.Add(this.chkFechasCerradas);
            this.Controls.Add(this.calInicioCerrada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calFechaFin);
            this.Controls.Add(this.chkEntreFechas);
            this.Controls.Add(this.calfechaInicio);
            this.Controls.Add(this.btnFiltrarxEstado);
            this.Controls.Add(this.cmbEstados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListadoOrdenesServicio";
            this.Text = "Listado Ordenes de Servicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListadoOrdenesServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calfechaInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFinCerrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calInicioCerrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFinAprobada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calInicioAprobadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFinProgramadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calInicioProgramadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter ordenServicioTableAdapter1;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdDatos;
        private DevComponents.DotNetBar.ButtonX btnFiltrarxEstado;
        private System.Windows.Forms.ComboBox cmbEstados;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnBuscar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calfechaInicio;
        private System.Windows.Forms.CheckBox chkEntreFechas;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFechaFin;
        private DevComponents.DotNetBar.ButtonX btnVerOrdenServicio;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private SPControladoraDatos.dsPlantillas dsPlantillas1;
        private SPControladoraDatos.dsPlantillasTableAdapters.pltListadoOrdenServicioTableAdapter pltListadoOrdenServicioTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.estadosOrdenServicioTableAdapter estadosOrdenServicioTableAdapter1;
        private System.Windows.Forms.Label label1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFinCerrada;
        private System.Windows.Forms.CheckBox chkFechasCerradas;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calInicioCerrada;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFinAprobada;
        private System.Windows.Forms.CheckBox chkAprobadas;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calInicioAprobadas;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas controladorColumnas1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFinProgramadas;
        private System.Windows.Forms.CheckBox chkProgramadas;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calInicioProgramadas;
    }
}