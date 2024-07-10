namespace spProcesos.recolecciones
{
    partial class frmListadoRecolecciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoRecolecciones));
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.btnVerRecoleccion = new DevComponents.DotNetBar.ButtonX();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.btnNueva = new DevComponents.DotNetBar.ButtonX();
            this.calFechaFin = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.chkEntreFechas = new System.Windows.Forms.CheckBox();
            this.calfechaInicio = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.grdDatos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsPlantillas1 = new SPControladoraDatos.dsPlantillas();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.controladorColumnas1 = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calfechaInicio)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grdDatos.BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerRecoleccion
            // 
            this.btnVerRecoleccion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVerRecoleccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnVerRecoleccion, "Ver Orden");
            this.balloonTip1.SetBalloonText(this.btnVerRecoleccion, null);
            this.btnVerRecoleccion.Image = ((System.Drawing.Image)(resources.GetObject("btnVerRecoleccion.Image")));
            this.btnVerRecoleccion.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnVerRecoleccion.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnVerRecoleccion.Location = new System.Drawing.Point(750, 93);
            this.btnVerRecoleccion.Name = "btnVerRecoleccion";
            this.btnVerRecoleccion.Size = new System.Drawing.Size(30, 29);
            this.btnVerRecoleccion.TabIndex = 105;
            this.btnVerRecoleccion.Click += new System.EventHandler(this.btnVerRecoleccion_Click);
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
            // btnNueva
            // 
            this.btnNueva.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNueva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnNueva, "Nueva");
            this.btnNueva.Image = ((System.Drawing.Image)(resources.GetObject("btnNueva.Image")));
            this.btnNueva.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnNueva.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnNueva.Location = new System.Drawing.Point(716, 93);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(30, 29);
            this.btnNueva.TabIndex = 107;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // calFechaFin
            // 
            // 
            // 
            // 
            this.calFechaFin.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calFechaFin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaFin.ButtonDropDown.Visible = true;
            this.calFechaFin.Location = new System.Drawing.Point(214, 102);
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
            this.calFechaFin.TabIndex = 104;
            // 
            // chkEntreFechas
            // 
            this.chkEntreFechas.AutoSize = true;
            this.chkEntreFechas.Checked = true;
            this.chkEntreFechas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEntreFechas.Location = new System.Drawing.Point(12, 78);
            this.chkEntreFechas.Name = "chkEntreFechas";
            this.chkEntreFechas.Size = new System.Drawing.Size(372, 17);
            this.chkEntreFechas.TabIndex = 103;
            this.chkEntreFechas.Text = "Buscar Resultados solo para Recolecciones Tentativas entre las Fechas:";
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
            this.calfechaInicio.Location = new System.Drawing.Point(8, 102);
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
            this.calfechaInicio.TabIndex = 102;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtFiltro);
            this.groupBox1.Controls.Add(this.cmbFiltro);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 60);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(230, 27);
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
            "Codigo Recoleccion",
            "Estado",
            "Numero de Entrada",
            "Serial",
            "Nit Cliente",
            "Cliente"});
            this.cmbFiltro.Location = new System.Drawing.Point(6, 26);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(218, 21);
            this.cmbFiltro.TabIndex = 1;
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUpdate = false;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.DataMember = "pltListadoRecoleccion";
            this.grdDatos.DataSource = this.dsPlantillas1;
            this.grdDatos.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdDatos.FilterBar = true;
            this.grdDatos.GroupByCaption = "";
            this.grdDatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDatos.Images"))));
            this.grdDatos.Location = new System.Drawing.Point(12, 128);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75D;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(984, 582);
            this.grdDatos.TabIndex = 97;
            this.grdDatos.Text = "c1TrueDBGrid1";
            this.grdDatos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
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
            // 
            // controladorColumnas1
            // 
            this.controladorColumnas1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controladorColumnas1.BackColor = System.Drawing.Color.Transparent;
            this.controladorColumnas1.grilla = null;
            this.controladorColumnas1.Location = new System.Drawing.Point(780, 93);
            this.controladorColumnas1.MostrarContraer = true;
            this.controladorColumnas1.MostrarExcel = true;
            this.controladorColumnas1.MostrarExpandir = true;
            this.controladorColumnas1.MostrarLimpiar = true;
            this.controladorColumnas1.Name = "controladorColumnas1";
            this.controladorColumnas1.nombreLibro = null;
            this.controladorColumnas1.Size = new System.Drawing.Size(216, 29);
            this.controladorColumnas1.TabIndex = 106;
            // 
            // frmListadoRecolecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1008, 722);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.controladorColumnas1);
            this.Controls.Add(this.btnVerRecoleccion);
            this.Controls.Add(this.calFechaFin);
            this.Controls.Add(this.chkEntreFechas);
            this.Controls.Add(this.calfechaInicio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListadoRecolecciones";
            this.Text = "Listado Recolecciones";
            this.Load += new System.EventHandler(this.frmListadoRecolecciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calFechaFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calfechaInicio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsPlantillas dsPlantillas1;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private DevComponents.DotNetBar.ButtonX btnVerRecoleccion;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFechaFin;
        private System.Windows.Forms.CheckBox chkEntreFechas;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calfechaInicio;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnBuscar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdDatos;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas controladorColumnas1;
        private DevComponents.DotNetBar.ButtonX btnNueva;
    }
}