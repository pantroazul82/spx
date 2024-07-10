namespace spProcesos.llamadasTecnicas
{
    partial class frmListadoLLamadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoLLamadas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbEstados = new System.Windows.Forms.ComboBox();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.grdDatos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsPlantillas1 = new SPControladoraDatos.dsPlantillas();
            this.estadosLLamadasTecnicasTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.estadosLLamadasTecnicasTableAdapter();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.btnVerLlamada = new DevComponents.DotNetBar.ButtonX();
            this.dsSpx2 = new SPControladoraDatos.dsSpx();
            this.pltListadoLlamadasTableAdapter1 = new SPControladoraDatos.dsPlantillasTableAdapters.pltListadoLlamadasTableAdapter();
            this.controladorColumnas1 = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas();
            this.calInicio = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.calFin = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calFinCerradas = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.calInicioCerradas = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label4 = new System.Windows.Forms.Label();
            this.calSolciitudFin = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.calSolicitudIni = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.chkCerradasEntre = new System.Windows.Forms.CheckBox();
            this.chkSolicitudEntre = new System.Windows.Forms.CheckBox();
            this.chkCreadas = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.grdDatos.BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFinCerradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calInicioCerradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calSolciitudFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calSolicitudIni)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbEstados);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtFiltro);
            this.groupBox1.Controls.Add(this.cmbCampo);
            this.groupBox1.Location = new System.Drawing.Point(8, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 45);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // cmbEstados
            // 
            this.cmbEstados.DataSource = this.dsSpx1;
            this.cmbEstados.DisplayMember = "estadosLLamadasTecnicas.nombreEstado";
            this.cmbEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstados.FormattingEnabled = true;
            this.cmbEstados.Location = new System.Drawing.Point(230, 18);
            this.cmbEstados.Name = "cmbEstados";
            this.cmbEstados.Size = new System.Drawing.Size(220, 21);
            this.cmbEstados.TabIndex = 16;
            this.cmbEstados.ValueMember = "estadosLLamadasTecnicas.codEstadoLlamada";
            this.cmbEstados.Visible = false;
            this.cmbEstados.SelectedIndexChanged += new System.EventHandler(this.cmbEstados_SelectedIndexChanged);
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnBuscar, "Buscar");
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnBuscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBuscar.Location = new System.Drawing.Point(456, 14);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(29, 29);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(230, 18);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(220, 20);
            this.txtFiltro.TabIndex = 5;
            this.txtFiltro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFiltro_KeyDown);
            // 
            // cmbCampo
            // 
            this.cmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampo.FormattingEnabled = true;
            this.cmbCampo.Items.AddRange(new object[] {
            "Codigo Llamada",
            "Serial",
            "Nit CLiente",
            "Estado"});
            this.cmbCampo.Location = new System.Drawing.Point(6, 18);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(218, 21);
            this.cmbCampo.TabIndex = 3;
            this.cmbCampo.SelectedIndexChanged += new System.EventHandler(this.cmbCampo_SelectedIndexChanged);
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUpdate = false;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.DataMember = "pltListadoLlamadas";
            this.grdDatos.DataSource = this.dsPlantillas1;
            this.grdDatos.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdDatos.FilterBar = true;
            this.grdDatos.GroupByCaption = "";
            this.grdDatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDatos.Images"))));
            this.grdDatos.Location = new System.Drawing.Point(12, 150);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75D;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(984, 560);
            this.grdDatos.TabIndex = 12;
            this.grdDatos.Text = "c1TrueDBGrid1";
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
            // 
            // dsPlantillas1
            // 
            this.dsPlantillas1.DataSetName = "dsPlantillas";
            this.dsPlantillas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estadosLLamadasTecnicasTableAdapter1
            // 
            this.estadosLLamadasTecnicasTableAdapter1.ClearBeforeFill = true;
            // 
            // btnVerLlamada
            // 
            this.btnVerLlamada.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVerLlamada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnVerLlamada, "Ver Llamada");
            this.balloonTip1.SetBalloonText(this.btnVerLlamada, null);
            this.btnVerLlamada.Image = ((System.Drawing.Image)(resources.GetObject("btnVerLlamada.Image")));
            this.btnVerLlamada.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnVerLlamada.Location = new System.Drawing.Point(747, 115);
            this.btnVerLlamada.Name = "btnVerLlamada";
            this.btnVerLlamada.Size = new System.Drawing.Size(31, 29);
            this.btnVerLlamada.TabIndex = 72;
            this.btnVerLlamada.Text = " ";
            this.btnVerLlamada.Click += new System.EventHandler(this.btnVerLlamada_Click);
            // 
            // dsSpx2
            // 
            this.dsSpx2.DataSetName = "dsSpx";
            this.dsSpx2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pltListadoLlamadasTableAdapter1
            // 
            this.pltListadoLlamadasTableAdapter1.ClearBeforeFill = true;
            // 
            // controladorColumnas1
            // 
            this.controladorColumnas1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controladorColumnas1.BackColor = System.Drawing.Color.Transparent;
            this.controladorColumnas1.grilla = null;
            this.controladorColumnas1.Location = new System.Drawing.Point(780, 115);
            this.controladorColumnas1.MostrarContraer = true;
            this.controladorColumnas1.MostrarExcel = true;
            this.controladorColumnas1.MostrarExpandir = true;
            this.controladorColumnas1.MostrarLimpiar = true;
            this.controladorColumnas1.Name = "controladorColumnas1";
            this.controladorColumnas1.nombreLibro = null;
            this.controladorColumnas1.Size = new System.Drawing.Size(216, 29);
            this.controladorColumnas1.TabIndex = 73;
            // 
            // calInicio
            // 
            // 
            // 
            // 
            this.calInicio.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calInicio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicio.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.calInicio.ButtonDropDown.Visible = true;
            this.calInicio.Location = new System.Drawing.Point(158, 10);
            // 
            // 
            // 
            this.calInicio.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calInicio.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calInicio.MonthCalendar.BackgroundStyle.Class = "";
            this.calInicio.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicio.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calInicio.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calInicio.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calInicio.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calInicio.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calInicio.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calInicio.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calInicio.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calInicio.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicio.MonthCalendar.DisplayMonth = new System.DateTime(2011, 9, 1, 0, 0, 0, 0);
            this.calInicio.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calInicio.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calInicio.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calInicio.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calInicio.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calInicio.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calInicio.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calInicio.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicio.MonthCalendar.TodayButtonVisible = true;
            this.calInicio.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calInicio.Name = "calInicio";
            this.calInicio.Size = new System.Drawing.Size(116, 20);
            this.calInicio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.calInicio.TabIndex = 74;
            // 
            // calFin
            // 
            // 
            // 
            // 
            this.calFin.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calFin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFin.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.calFin.ButtonDropDown.Visible = true;
            this.calFin.Location = new System.Drawing.Point(299, 10);
            // 
            // 
            // 
            this.calFin.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFin.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calFin.MonthCalendar.BackgroundStyle.Class = "";
            this.calFin.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFin.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calFin.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calFin.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calFin.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calFin.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calFin.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calFin.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calFin.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calFin.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFin.MonthCalendar.DisplayMonth = new System.DateTime(2011, 9, 1, 0, 0, 0, 0);
            this.calFin.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calFin.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calFin.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFin.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calFin.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calFin.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calFin.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calFin.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFin.MonthCalendar.TodayButtonVisible = true;
            this.calFin.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calFin.Name = "calFin";
            this.calFin.Size = new System.Drawing.Size(139, 20);
            this.calFin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.calFin.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "y";
            // 
            // calFinCerradas
            // 
            // 
            // 
            // 
            this.calFinCerradas.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calFinCerradas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinCerradas.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.calFinCerradas.ButtonDropDown.Visible = true;
            this.calFinCerradas.Location = new System.Drawing.Point(299, 36);
            // 
            // 
            // 
            this.calFinCerradas.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFinCerradas.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calFinCerradas.MonthCalendar.BackgroundStyle.Class = "";
            this.calFinCerradas.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinCerradas.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calFinCerradas.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calFinCerradas.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calFinCerradas.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calFinCerradas.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calFinCerradas.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calFinCerradas.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calFinCerradas.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calFinCerradas.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinCerradas.MonthCalendar.DisplayMonth = new System.DateTime(2011, 9, 1, 0, 0, 0, 0);
            this.calFinCerradas.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calFinCerradas.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calFinCerradas.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFinCerradas.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calFinCerradas.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calFinCerradas.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calFinCerradas.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calFinCerradas.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinCerradas.MonthCalendar.TodayButtonVisible = true;
            this.calFinCerradas.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calFinCerradas.Name = "calFinCerradas";
            this.calFinCerradas.Size = new System.Drawing.Size(139, 20);
            this.calFinCerradas.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.calFinCerradas.TabIndex = 79;
            // 
            // calInicioCerradas
            // 
            // 
            // 
            // 
            this.calInicioCerradas.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calInicioCerradas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioCerradas.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.calInicioCerradas.ButtonDropDown.Visible = true;
            this.calInicioCerradas.Location = new System.Drawing.Point(158, 36);
            // 
            // 
            // 
            this.calInicioCerradas.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calInicioCerradas.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calInicioCerradas.MonthCalendar.BackgroundStyle.Class = "";
            this.calInicioCerradas.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioCerradas.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calInicioCerradas.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calInicioCerradas.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calInicioCerradas.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calInicioCerradas.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calInicioCerradas.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calInicioCerradas.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calInicioCerradas.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calInicioCerradas.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioCerradas.MonthCalendar.DisplayMonth = new System.DateTime(2011, 9, 1, 0, 0, 0, 0);
            this.calInicioCerradas.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calInicioCerradas.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calInicioCerradas.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calInicioCerradas.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calInicioCerradas.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calInicioCerradas.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calInicioCerradas.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calInicioCerradas.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioCerradas.MonthCalendar.TodayButtonVisible = true;
            this.calInicioCerradas.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calInicioCerradas.Name = "calInicioCerradas";
            this.calInicioCerradas.Size = new System.Drawing.Size(116, 20);
            this.calInicioCerradas.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.calInicioCerradas.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 83;
            this.label4.Text = "y";
            // 
            // calSolciitudFin
            // 
            // 
            // 
            // 
            this.calSolciitudFin.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calSolciitudFin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calSolciitudFin.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.calSolciitudFin.ButtonDropDown.Visible = true;
            this.calSolciitudFin.Location = new System.Drawing.Point(299, 62);
            // 
            // 
            // 
            this.calSolciitudFin.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calSolciitudFin.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calSolciitudFin.MonthCalendar.BackgroundStyle.Class = "";
            this.calSolciitudFin.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calSolciitudFin.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calSolciitudFin.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calSolciitudFin.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calSolciitudFin.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calSolciitudFin.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calSolciitudFin.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calSolciitudFin.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calSolciitudFin.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calSolciitudFin.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calSolciitudFin.MonthCalendar.DisplayMonth = new System.DateTime(2011, 9, 1, 0, 0, 0, 0);
            this.calSolciitudFin.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calSolciitudFin.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calSolciitudFin.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calSolciitudFin.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calSolciitudFin.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calSolciitudFin.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calSolciitudFin.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calSolciitudFin.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calSolciitudFin.MonthCalendar.TodayButtonVisible = true;
            this.calSolciitudFin.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calSolciitudFin.Name = "calSolciitudFin";
            this.calSolciitudFin.Size = new System.Drawing.Size(139, 20);
            this.calSolciitudFin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.calSolciitudFin.TabIndex = 82;
            // 
            // calSolicitudIni
            // 
            // 
            // 
            // 
            this.calSolicitudIni.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calSolicitudIni.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calSolicitudIni.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.calSolicitudIni.ButtonDropDown.Visible = true;
            this.calSolicitudIni.Location = new System.Drawing.Point(158, 62);
            // 
            // 
            // 
            this.calSolicitudIni.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calSolicitudIni.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calSolicitudIni.MonthCalendar.BackgroundStyle.Class = "";
            this.calSolicitudIni.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calSolicitudIni.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calSolicitudIni.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calSolicitudIni.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calSolicitudIni.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calSolicitudIni.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calSolicitudIni.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calSolicitudIni.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calSolicitudIni.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calSolicitudIni.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calSolicitudIni.MonthCalendar.DisplayMonth = new System.DateTime(2011, 9, 1, 0, 0, 0, 0);
            this.calSolicitudIni.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calSolicitudIni.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calSolicitudIni.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calSolicitudIni.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calSolicitudIni.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calSolicitudIni.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calSolicitudIni.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calSolicitudIni.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calSolicitudIni.MonthCalendar.TodayButtonVisible = true;
            this.calSolicitudIni.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calSolicitudIni.Name = "calSolicitudIni";
            this.calSolicitudIni.Size = new System.Drawing.Size(116, 20);
            this.calSolicitudIni.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.calSolicitudIni.TabIndex = 81;
            // 
            // chkCerradasEntre
            // 
            this.chkCerradasEntre.AutoSize = true;
            this.chkCerradasEntre.Location = new System.Drawing.Point(12, 39);
            this.chkCerradasEntre.Name = "chkCerradasEntre";
            this.chkCerradasEntre.Size = new System.Drawing.Size(143, 17);
            this.chkCerradasEntre.TabIndex = 84;
            this.chkCerradasEntre.Text = "Llamadas cerradas Entre";
            this.chkCerradasEntre.UseVisualStyleBackColor = true;
            // 
            // chkSolicitudEntre
            // 
            this.chkSolicitudEntre.AutoSize = true;
            this.chkSolicitudEntre.Location = new System.Drawing.Point(12, 63);
            this.chkSolicitudEntre.Name = "chkSolicitudEntre";
            this.chkSolicitudEntre.Size = new System.Drawing.Size(94, 17);
            this.chkSolicitudEntre.TabIndex = 85;
            this.chkSolicitudEntre.Text = "Solicitud Entre";
            this.chkSolicitudEntre.UseVisualStyleBackColor = true;
            // 
            // chkCreadas
            // 
            this.chkCreadas.AutoSize = true;
            this.chkCreadas.Checked = true;
            this.chkCreadas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCreadas.Location = new System.Drawing.Point(12, 11);
            this.chkCreadas.Name = "chkCreadas";
            this.chkCreadas.Size = new System.Drawing.Size(141, 17);
            this.chkCreadas.TabIndex = 86;
            this.chkCreadas.Text = "Llamadas Creadas Entre";
            this.chkCreadas.UseVisualStyleBackColor = true;
            // 
            // frmListadoLLamadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 722);
            this.Controls.Add(this.chkCreadas);
            this.Controls.Add(this.chkSolicitudEntre);
            this.Controls.Add(this.chkCerradasEntre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calSolciitudFin);
            this.Controls.Add(this.calSolicitudIni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calFinCerradas);
            this.Controls.Add(this.calInicioCerradas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calFin);
            this.Controls.Add(this.calInicio);
            this.Controls.Add(this.controladorColumnas1);
            this.Controls.Add(this.btnVerLlamada);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListadoLLamadas";
            this.Text = "Listado LLamadas Soporte";
            this.Load += new System.EventHandler(this.frmListadoLLamadas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFinCerradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calInicioCerradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calSolciitudFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calSolicitudIni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnBuscar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ComboBox cmbCampo;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdDatos;
        private SPControladoraDatos.dsSpx dsSpx1;

        private SPControladoraDatos.dsSpxTableAdapters.estadosLLamadasTecnicasTableAdapter estadosLLamadasTecnicasTableAdapter1;
        private System.Windows.Forms.ComboBox cmbEstados;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private DevComponents.DotNetBar.ButtonX btnVerLlamada;
        private SPControladoraDatos.dsSpx dsSpx2;
        private SPControladoraDatos.dsPlantillas dsPlantillas1;
        private SPControladoraDatos.dsPlantillasTableAdapters.pltListadoLlamadasTableAdapter pltListadoLlamadasTableAdapter1;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas controladorColumnas1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calInicio;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFinCerradas;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calInicioCerradas;
        private System.Windows.Forms.Label label4;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calSolciitudFin;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calSolicitudIni;
        private System.Windows.Forms.CheckBox chkCerradasEntre;
        private System.Windows.Forms.CheckBox chkSolicitudEntre;
        private System.Windows.Forms.CheckBox chkCreadas;
    }
}