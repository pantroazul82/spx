namespace spProcesos.programacion
{
    partial class frmListadoProgramaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoProgramaciones));
            this.btnVerProgramacion = new DevComponents.DotNetBar.ButtonX();
            this.calFechaFin = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.chkEntreFechas = new System.Windows.Forms.CheckBox();
            this.calfechaInicio = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnFiltrarxEstado = new DevComponents.DotNetBar.ButtonX();
            this.cmbMeses = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.grdDatos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsPlantillas1 = new SPControladoraDatos.dsPlantillas();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.programacionViajesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.programacionViajesTableAdapter();
            this.pltListaProgramacionesTableAdapter1 = new SPControladoraDatos.dsPlantillasTableAdapters.pltListaProgramacionesTableAdapter();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.controladorColumnas1 = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas();
            this.groupBox1.SuspendLayout();
            this.grdDatos.BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerProgramacion
            // 
            this.btnVerProgramacion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVerProgramacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerProgramacion.Image = ((System.Drawing.Image)(resources.GetObject("btnVerProgramacion.Image")));
            this.btnVerProgramacion.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnVerProgramacion.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnVerProgramacion.Location = new System.Drawing.Point(767, 88);
            this.btnVerProgramacion.Name = "btnVerProgramacion";
            this.btnVerProgramacion.Size = new System.Drawing.Size(89, 48);
            this.btnVerProgramacion.TabIndex = 6;
            this.btnVerProgramacion.Text = "Ver Programacion";
            this.btnVerProgramacion.Click += new System.EventHandler(this.btnVerProgramacion_Click);
            // 
            // calFechaFin
            // 
            // 
            // 
            // 
            this.calFechaFin.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calFechaFin.ButtonDropDown.Visible = true;
            this.calFechaFin.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calFechaFin.Location = new System.Drawing.Point(561, 97);
            // 
            // 
            // 
            this.calFechaFin.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
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
            this.calFechaFin.MonthCalendar.TodayButtonVisible = true;
            this.calFechaFin.Name = "calFechaFin";
            this.calFechaFin.Size = new System.Drawing.Size(200, 21);
            this.calFechaFin.TabIndex = 5;
            // 
            // chkEntreFechas
            // 
            this.chkEntreFechas.AutoSize = true;
            this.chkEntreFechas.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEntreFechas.Location = new System.Drawing.Point(12, 99);
            this.chkEntreFechas.Name = "chkEntreFechas";
            this.chkEntreFechas.Size = new System.Drawing.Size(320, 17);
            this.chkEntreFechas.TabIndex = 3;
            this.chkEntreFechas.Text = "Buscar Resultados solo para programaciones entre las Fechas:";
            this.chkEntreFechas.UseVisualStyleBackColor = true;
            // 
            // calfechaInicio
            // 
            // 
            // 
            // 
            this.calfechaInicio.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calfechaInicio.ButtonDropDown.Visible = true;
            this.calfechaInicio.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calfechaInicio.Location = new System.Drawing.Point(348, 97);
            // 
            // 
            // 
            this.calfechaInicio.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
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
            this.calfechaInicio.MonthCalendar.TodayButtonVisible = true;
            this.calfechaInicio.Name = "calfechaInicio";
            this.calfechaInicio.Size = new System.Drawing.Size(200, 21);
            this.calfechaInicio.TabIndex = 4;
            // 
            // btnFiltrarxEstado
            // 
            this.btnFiltrarxEstado.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFiltrarxEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrarxEstado.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrarxEstado.Image")));
            this.btnFiltrarxEstado.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnFiltrarxEstado.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnFiltrarxEstado.Location = new System.Drawing.Point(982, 12);
            this.btnFiltrarxEstado.Name = "btnFiltrarxEstado";
            this.btnFiltrarxEstado.Size = new System.Drawing.Size(97, 49);
            this.btnFiltrarxEstado.TabIndex = 2;
            this.btnFiltrarxEstado.Text = "Filtrar por Mes";
            this.btnFiltrarxEstado.Click += new System.EventHandler(this.btnFiltrarxEstado_Click);
            // 
            // cmbMeses
            // 
            this.cmbMeses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeses.FormattingEnabled = true;
            this.cmbMeses.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmbMeses.Location = new System.Drawing.Point(801, 12);
            this.cmbMeses.Name = "cmbMeses";
            this.cmbMeses.Size = new System.Drawing.Size(175, 21);
            this.cmbMeses.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtFiltro);
            this.groupBox1.Controls.Add(this.cmbFiltro);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnBuscar, "Buscar");
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnBuscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBuscar.Location = new System.Drawing.Point(456, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(33, 33);
            this.btnBuscar.TabIndex = 1;
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
            "Codigo Programacion",
            "Ingeniero Asignado",
            "Codigo Orden Servicio",
            "Serial"});
            this.cmbFiltro.Location = new System.Drawing.Point(6, 26);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(218, 21);
            this.cmbFiltro.TabIndex = 2;
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUpdate = false;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.DataMember = "pltListaProgramaciones";
            this.grdDatos.DataSource = this.dsPlantillas1;
            this.grdDatos.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdDatos.FilterBar = true;
            this.grdDatos.GroupByCaption = "";
            this.grdDatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDatos.Images"))));
            this.grdDatos.Location = new System.Drawing.Point(12, 142);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(1059, 469);
            this.grdDatos.TabIndex = 0;
            this.grdDatos.Text = "c1TrueDBGrid1";
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
            // programacionViajesTableAdapter1
            // 
            this.programacionViajesTableAdapter1.ClearBeforeFill = true;
            // 
            // pltListaProgramacionesTableAdapter1
            // 
            this.pltListaProgramacionesTableAdapter1.ClearBeforeFill = true;
            // 
            // controladorColumnas1
            // 
            this.controladorColumnas1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controladorColumnas1.BackColor = System.Drawing.Color.Transparent;
            this.controladorColumnas1.grilla = null;
            this.controladorColumnas1.Location = new System.Drawing.Point(863, 107);
            this.controladorColumnas1.MostrarContraer = true;
            this.controladorColumnas1.MostrarExcel = true;
            this.controladorColumnas1.MostrarExpandir = true;
            this.controladorColumnas1.MostrarLimpiar = true;
            this.controladorColumnas1.Name = "controladorColumnas1";
            this.controladorColumnas1.nombreLibro = null;
            this.controladorColumnas1.Size = new System.Drawing.Size(216, 29);
            this.controladorColumnas1.TabIndex = 7;
            // 
            // frmListadoProgramaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1083, 619);
            this.Controls.Add(this.controladorColumnas1);
            this.Controls.Add(this.btnVerProgramacion);
            this.Controls.Add(this.calFechaFin);
            this.Controls.Add(this.chkEntreFechas);
            this.Controls.Add(this.calfechaInicio);
            this.Controls.Add(this.btnFiltrarxEstado);
            this.Controls.Add(this.cmbMeses);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListadoProgramaciones";
            this.Text = "Listado de Programaciones";
            this.Load += new System.EventHandler(this.frmListadoProgramaciones_Load);
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
        private SPControladoraDatos.dsSpxTableAdapters.programacionViajesTableAdapter programacionViajesTableAdapter1;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdDatos;
        private DevComponents.DotNetBar.ButtonX btnVerProgramacion;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFechaFin;
        private System.Windows.Forms.CheckBox chkEntreFechas;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calfechaInicio;
        private DevComponents.DotNetBar.ButtonX btnFiltrarxEstado;
        private System.Windows.Forms.ComboBox cmbMeses;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnBuscar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private SPControladoraDatos.dsPlantillas dsPlantillas1;
        private SPControladoraDatos.dsPlantillasTableAdapters.pltListaProgramacionesTableAdapter pltListaProgramacionesTableAdapter1;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas controladorColumnas1;
    }
}