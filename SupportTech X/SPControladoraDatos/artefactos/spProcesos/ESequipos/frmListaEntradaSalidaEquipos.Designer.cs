namespace spProcesos.ESequipos
{
    partial class frmListaEntradaSalidaEquipos
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaEntradaSalidaEquipos));
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.txtCampo = new System.Windows.Forms.TextBox();
            this.nmRegistros = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.btnVerOrdenServicio = new DevComponents.DotNetBar.ButtonX();
            this.calFechaFin = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.chkEntreFechas = new System.Windows.Forms.CheckBox();
            this.calfechaInicio = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.btnNuevaEntrada = new DevComponents.DotNetBar.ButtonX();
            this.calFinSalida = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.chkBuscarSalida = new System.Windows.Forms.CheckBox();
            this.calInicioSalida = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.calFinSeg = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.chkBuscarSeguimiento = new System.Windows.Forms.CheckBox();
            this.calInicioSeg = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdPendientesxSeguimiento = new System.Windows.Forms.RadioButton();
            this.rdTraerSalida = new System.Windows.Forms.RadioButton();
            this.rdTodos = new System.Windows.Forms.RadioButton();
            this.controladorColumnas1 = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas();
            this.grdDatos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsPlantillas1 = new SPControladoraDatos.dsPlantillas();
            this.pltListadoESequiposTableAdapter1 = new SPControladoraDatos.dsPlantillasTableAdapters.pltListadoESequiposTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nmRegistros)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calfechaInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFinSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calInicioSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFinSeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calInicioSeg)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grdDatos.BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCampo
            // 
            this.cmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampo.FormattingEnabled = true;
            this.cmbCampo.Items.AddRange(new object[] {
            "Codigo Entrada/Salida",
            "Codigo Orden de Servicio",
            "Serial",
            "Nit Cliente",
            "Cliente",
            "Numero Socio",
            "Modelo",
            "Ciudad",
            "Departamento",
            "Ciudad Salida",
            "Departamento Salida"});
            this.cmbCampo.Location = new System.Drawing.Point(8, 19);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(210, 21);
            this.cmbCampo.TabIndex = 1;
            // 
            // txtCampo
            // 
            this.txtCampo.Location = new System.Drawing.Point(223, 19);
            this.txtCampo.Name = "txtCampo";
            this.txtCampo.Size = new System.Drawing.Size(224, 20);
            this.txtCampo.TabIndex = 0;
            this.txtCampo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCampo_KeyDown);
            // 
            // nmRegistros
            // 
            this.nmRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nmRegistros.Location = new System.Drawing.Point(971, 71);
            this.nmRegistros.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmRegistros.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmRegistros.Name = "nmRegistros";
            this.nmRegistros.Size = new System.Drawing.Size(95, 20);
            this.nmRegistros.TabIndex = 5;
            this.nmRegistros.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(838, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Registros en la busqueda";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.cmbCampo);
            this.groupBox1.Controls.Add(this.txtCampo);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 50);
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
            this.btnBuscar.Location = new System.Drawing.Point(456, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(33, 33);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVerOrdenServicio
            // 
            this.btnVerOrdenServicio.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVerOrdenServicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnVerOrdenServicio, "Ver Entrada/Salida");
            this.balloonTip1.SetBalloonText(this.btnVerOrdenServicio, null);
            this.btnVerOrdenServicio.Image = ((System.Drawing.Image)(resources.GetObject("btnVerOrdenServicio.Image")));
            this.btnVerOrdenServicio.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnVerOrdenServicio.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnVerOrdenServicio.Location = new System.Drawing.Point(816, 99);
            this.btnVerOrdenServicio.Name = "btnVerOrdenServicio";
            this.btnVerOrdenServicio.Size = new System.Drawing.Size(33, 33);
            this.btnVerOrdenServicio.TabIndex = 29;
            this.btnVerOrdenServicio.Click += new System.EventHandler(this.btnVerOrdenServicio_Click);
            // 
            // calFechaFin
            // 
            // 
            // 
            // 
            this.calFechaFin.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calFechaFin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaFin.ButtonDropDown.Visible = true;
            this.calFechaFin.Location = new System.Drawing.Point(463, 65);
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
            this.calFechaFin.TabIndex = 28;
            // 
            // chkEntreFechas
            // 
            this.chkEntreFechas.AutoSize = true;
            this.chkEntreFechas.Location = new System.Drawing.Point(10, 64);
            this.chkEntreFechas.Name = "chkEntreFechas";
            this.chkEntreFechas.Size = new System.Drawing.Size(214, 17);
            this.chkEntreFechas.TabIndex = 27;
            this.chkEntreFechas.Text = "Buscar Resultados para Entradas entre:";
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
            this.calfechaInicio.Location = new System.Drawing.Point(248, 65);
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
            this.calfechaInicio.TabIndex = 26;
            // 
            // btnNuevaEntrada
            // 
            this.btnNuevaEntrada.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNuevaEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnNuevaEntrada, "Nueva Entrada");
            this.balloonTip1.SetBalloonText(this.btnNuevaEntrada, null);
            this.btnNuevaEntrada.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevaEntrada.Image")));
            this.btnNuevaEntrada.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnNuevaEntrada.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnNuevaEntrada.Location = new System.Drawing.Point(780, 99);
            this.btnNuevaEntrada.Name = "btnNuevaEntrada";
            this.btnNuevaEntrada.Size = new System.Drawing.Size(33, 33);
            this.btnNuevaEntrada.TabIndex = 99;
            this.btnNuevaEntrada.Click += new System.EventHandler(this.btnNuevaEntrada_Click);
            // 
            // calFinSalida
            // 
            // 
            // 
            // 
            this.calFinSalida.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calFinSalida.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinSalida.ButtonDropDown.Visible = true;
            this.calFinSalida.Location = new System.Drawing.Point(463, 88);
            // 
            // 
            // 
            this.calFinSalida.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFinSalida.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calFinSalida.MonthCalendar.BackgroundStyle.Class = "";
            this.calFinSalida.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinSalida.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calFinSalida.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calFinSalida.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calFinSalida.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calFinSalida.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calFinSalida.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calFinSalida.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calFinSalida.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calFinSalida.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinSalida.MonthCalendar.DisplayMonth = new System.DateTime(2008, 10, 1, 0, 0, 0, 0);
            this.calFinSalida.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calFinSalida.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calFinSalida.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFinSalida.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calFinSalida.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calFinSalida.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calFinSalida.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calFinSalida.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinSalida.MonthCalendar.TodayButtonVisible = true;
            this.calFinSalida.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calFinSalida.Name = "calFinSalida";
            this.calFinSalida.Size = new System.Drawing.Size(200, 20);
            this.calFinSalida.TabIndex = 93;
            // 
            // chkBuscarSalida
            // 
            this.chkBuscarSalida.AutoSize = true;
            this.chkBuscarSalida.Location = new System.Drawing.Point(10, 87);
            this.chkBuscarSalida.Name = "chkBuscarSalida";
            this.chkBuscarSalida.Size = new System.Drawing.Size(204, 17);
            this.chkBuscarSalida.TabIndex = 92;
            this.chkBuscarSalida.Text = "Buscar Resultados para salidas entre:";
            this.chkBuscarSalida.UseVisualStyleBackColor = true;
            // 
            // calInicioSalida
            // 
            // 
            // 
            // 
            this.calInicioSalida.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calInicioSalida.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioSalida.ButtonDropDown.Visible = true;
            this.calInicioSalida.Location = new System.Drawing.Point(248, 88);
            // 
            // 
            // 
            this.calInicioSalida.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calInicioSalida.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calInicioSalida.MonthCalendar.BackgroundStyle.Class = "";
            this.calInicioSalida.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioSalida.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calInicioSalida.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calInicioSalida.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calInicioSalida.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calInicioSalida.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calInicioSalida.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calInicioSalida.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calInicioSalida.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calInicioSalida.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioSalida.MonthCalendar.DisplayMonth = new System.DateTime(2008, 10, 1, 0, 0, 0, 0);
            this.calInicioSalida.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calInicioSalida.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calInicioSalida.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calInicioSalida.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calInicioSalida.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calInicioSalida.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calInicioSalida.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calInicioSalida.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioSalida.MonthCalendar.TodayButtonVisible = true;
            this.calInicioSalida.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calInicioSalida.Name = "calInicioSalida";
            this.calInicioSalida.Size = new System.Drawing.Size(200, 20);
            this.calInicioSalida.TabIndex = 91;
            // 
            // calFinSeg
            // 
            // 
            // 
            // 
            this.calFinSeg.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calFinSeg.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinSeg.ButtonDropDown.Visible = true;
            this.calFinSeg.Location = new System.Drawing.Point(463, 112);
            // 
            // 
            // 
            this.calFinSeg.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFinSeg.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calFinSeg.MonthCalendar.BackgroundStyle.Class = "";
            this.calFinSeg.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinSeg.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calFinSeg.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calFinSeg.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calFinSeg.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calFinSeg.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calFinSeg.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calFinSeg.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calFinSeg.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calFinSeg.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinSeg.MonthCalendar.DisplayMonth = new System.DateTime(2008, 10, 1, 0, 0, 0, 0);
            this.calFinSeg.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calFinSeg.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calFinSeg.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFinSeg.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calFinSeg.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calFinSeg.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calFinSeg.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calFinSeg.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinSeg.MonthCalendar.TodayButtonVisible = true;
            this.calFinSeg.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calFinSeg.Name = "calFinSeg";
            this.calFinSeg.Size = new System.Drawing.Size(200, 20);
            this.calFinSeg.TabIndex = 96;
            // 
            // chkBuscarSeguimiento
            // 
            this.chkBuscarSeguimiento.AutoSize = true;
            this.chkBuscarSeguimiento.Location = new System.Drawing.Point(10, 111);
            this.chkBuscarSeguimiento.Name = "chkBuscarSeguimiento";
            this.chkBuscarSeguimiento.Size = new System.Drawing.Size(235, 17);
            this.chkBuscarSeguimiento.TabIndex = 95;
            this.chkBuscarSeguimiento.Text = "Buscar Resultados para Seguimientos entre:";
            this.chkBuscarSeguimiento.UseVisualStyleBackColor = true;
            // 
            // calInicioSeg
            // 
            // 
            // 
            // 
            this.calInicioSeg.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calInicioSeg.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioSeg.ButtonDropDown.Visible = true;
            this.calInicioSeg.Location = new System.Drawing.Point(248, 112);
            // 
            // 
            // 
            this.calInicioSeg.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calInicioSeg.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calInicioSeg.MonthCalendar.BackgroundStyle.Class = "";
            this.calInicioSeg.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioSeg.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calInicioSeg.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calInicioSeg.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calInicioSeg.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calInicioSeg.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calInicioSeg.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calInicioSeg.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calInicioSeg.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calInicioSeg.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioSeg.MonthCalendar.DisplayMonth = new System.DateTime(2008, 10, 1, 0, 0, 0, 0);
            this.calInicioSeg.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calInicioSeg.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calInicioSeg.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calInicioSeg.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calInicioSeg.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calInicioSeg.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calInicioSeg.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calInicioSeg.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioSeg.MonthCalendar.TodayButtonVisible = true;
            this.calInicioSeg.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calInicioSeg.Name = "calInicioSeg";
            this.calInicioSeg.Size = new System.Drawing.Size(200, 20);
            this.calInicioSeg.TabIndex = 94;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdPendientesxSeguimiento);
            this.groupBox2.Controls.Add(this.rdTraerSalida);
            this.groupBox2.Controls.Add(this.rdTodos);
            this.groupBox2.Location = new System.Drawing.Point(592, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 40);
            this.groupBox2.TabIndex = 97;
            this.groupBox2.TabStop = false;
            // 
            // rdPendientesxSeguimiento
            // 
            this.rdPendientesxSeguimiento.AutoSize = true;
            this.rdPendientesxSeguimiento.Location = new System.Drawing.Point(277, 15);
            this.rdPendientesxSeguimiento.Name = "rdPendientesxSeguimiento";
            this.rdPendientesxSeguimiento.Size = new System.Drawing.Size(186, 17);
            this.rdPendientesxSeguimiento.TabIndex = 2;
            this.rdPendientesxSeguimiento.Text = "Traer Pendientes Por Seguimiento";
            this.rdPendientesxSeguimiento.UseVisualStyleBackColor = true;
            // 
            // rdTraerSalida
            // 
            this.rdTraerSalida.AutoSize = true;
            this.rdTraerSalida.Location = new System.Drawing.Point(94, 15);
            this.rdTraerSalida.Name = "rdTraerSalida";
            this.rdTraerSalida.Size = new System.Drawing.Size(157, 17);
            this.rdTraerSalida.TabIndex = 1;
            this.rdTraerSalida.Text = "Traer Pendientes Por Salida";
            this.rdTraerSalida.UseVisualStyleBackColor = true;
            // 
            // rdTodos
            // 
            this.rdTodos.AutoSize = true;
            this.rdTodos.Checked = true;
            this.rdTodos.Location = new System.Drawing.Point(10, 15);
            this.rdTodos.Name = "rdTodos";
            this.rdTodos.Size = new System.Drawing.Size(55, 17);
            this.rdTodos.TabIndex = 0;
            this.rdTodos.TabStop = true;
            this.rdTodos.Text = "Todos";
            this.rdTodos.UseVisualStyleBackColor = true;
            // 
            // controladorColumnas1
            // 
            this.controladorColumnas1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controladorColumnas1.BackColor = System.Drawing.Color.Transparent;
            this.controladorColumnas1.grilla = null;
            this.controladorColumnas1.Location = new System.Drawing.Point(850, 103);
            this.controladorColumnas1.MostrarContraer = true;
            this.controladorColumnas1.MostrarExcel = true;
            this.controladorColumnas1.MostrarExpandir = true;
            this.controladorColumnas1.MostrarLimpiar = true;
            this.controladorColumnas1.Name = "controladorColumnas1";
            this.controladorColumnas1.nombreLibro = null;
            this.controladorColumnas1.Size = new System.Drawing.Size(216, 29);
            this.controladorColumnas1.TabIndex = 98;
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUpdate = false;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.DataMember = "pltListadoESequipos";
            this.grdDatos.DataSource = this.dsPlantillas1;
            this.grdDatos.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdDatos.FilterBar = true;
            this.grdDatos.GroupByCaption = "";
            this.grdDatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDatos.Images"))));
            this.grdDatos.Location = new System.Drawing.Point(9, 138);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75D;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(1055, 420);
            this.grdDatos.TabIndex = 2;
            this.grdDatos.Text = "c1TrueDBGrid1";
            this.grdDatos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
            // 
            // dsPlantillas1
            // 
            this.dsPlantillas1.DataSetName = "dsPlantillas";
            this.dsPlantillas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pltListadoESequiposTableAdapter1
            // 
            this.pltListadoESequiposTableAdapter1.ClearBeforeFill = true;
            // 
            // frmListaEntradaSalidaEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1073, 569);
            this.Controls.Add(this.btnNuevaEntrada);
            this.Controls.Add(this.controladorColumnas1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.calFinSeg);
            this.Controls.Add(this.chkBuscarSeguimiento);
            this.Controls.Add(this.calInicioSeg);
            this.Controls.Add(this.calFinSalida);
            this.Controls.Add(this.chkBuscarSalida);
            this.Controls.Add(this.calInicioSalida);
            this.Controls.Add(this.btnVerOrdenServicio);
            this.Controls.Add(this.calFechaFin);
            this.Controls.Add(this.chkEntreFechas);
            this.Controls.Add(this.calfechaInicio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmRegistros);
            this.Controls.Add(this.grdDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListaEntradaSalidaEquipos";
            this.Text = "Listado Entrada Salida Equipos";
            this.Load += new System.EventHandler(this.frmListaEntradaSalidaEquipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmRegistros)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calfechaInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFinSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calInicioSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFinSeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calInicioSeg)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdDatos;
        private System.Windows.Forms.ComboBox cmbCampo;
        private System.Windows.Forms.TextBox txtCampo;
        private System.Windows.Forms.NumericUpDown nmRegistros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnBuscar;
        private DevComponents.DotNetBar.ButtonX btnVerOrdenServicio;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFechaFin;
        private System.Windows.Forms.CheckBox chkEntreFechas;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calfechaInicio;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private SPControladoraDatos.dsPlantillas dsPlantillas1;
        private SPControladoraDatos.dsPlantillasTableAdapters.pltListadoESequiposTableAdapter pltListadoESequiposTableAdapter1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFinSalida;
        private System.Windows.Forms.CheckBox chkBuscarSalida;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calInicioSalida;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFinSeg;
        private System.Windows.Forms.CheckBox chkBuscarSeguimiento;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calInicioSeg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdPendientesxSeguimiento;
        private System.Windows.Forms.RadioButton rdTraerSalida;
        private System.Windows.Forms.RadioButton rdTodos;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas controladorColumnas1;
        private DevComponents.DotNetBar.ButtonX btnNuevaEntrada;
    }
}