namespace spProcesos.solicitudes
{
    partial class frmListadoSolicitudesServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoSolicitudesServicio));
            this.btnFiltrarxEstado = new DevComponents.DotNetBar.ButtonX();
            this.cmbEstados = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.calfechaInicio = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.chkEntreFechas = new System.Windows.Forms.CheckBox();
            this.calFechaFin = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnVerSolicitudServicio = new DevComponents.DotNetBar.ButtonX();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.grdDatos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsPlantillas1 = new SPControladoraDatos.dsPlantillas();
            this.controladorColumnas1 = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas();
            this.groupBox1.SuspendLayout();
            this.grdDatos.BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFiltrarxEstado
            // 
            this.btnFiltrarxEstado.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFiltrarxEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrarxEstado.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrarxEstado.Image")));
            this.btnFiltrarxEstado.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnFiltrarxEstado.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnFiltrarxEstado.Location = new System.Drawing.Point(899, 12);
            this.btnFiltrarxEstado.Name = "btnFiltrarxEstado";
            this.btnFiltrarxEstado.Size = new System.Drawing.Size(97, 46);
            this.btnFiltrarxEstado.TabIndex = 19;
            this.btnFiltrarxEstado.Text = "Filtrar por Estado";
            this.btnFiltrarxEstado.Click += new System.EventHandler(this.btnFiltrarxEstado_Click);
            // 
            // cmbEstados
            // 
            this.cmbEstados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEstados.DisplayMember = "estadosSolicitud.codEstadoSolicitud";
            this.cmbEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstados.FormattingEnabled = true;
            this.cmbEstados.Location = new System.Drawing.Point(718, 12);
            this.cmbEstados.Name = "cmbEstados";
            this.cmbEstados.Size = new System.Drawing.Size(175, 21);
            this.cmbEstados.TabIndex = 18;
            this.cmbEstados.ValueMember = "estadosSolicitud.codEstadoSolicitud";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtFiltro);
            this.groupBox1.Controls.Add(this.cmbFiltro);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnBuscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBuscar.Location = new System.Drawing.Point(456, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 48);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
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
            "Codigo Solicitud de Servicio",
            "Serial",
            "Nit Cliente"});
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
            this.calfechaInicio.ButtonDropDown.Visible = true;
            this.calfechaInicio.Location = new System.Drawing.Point(348, 89);
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
            this.calfechaInicio.Size = new System.Drawing.Size(200, 20);
            this.calfechaInicio.TabIndex = 20;
            // 
            // chkEntreFechas
            // 
            this.chkEntreFechas.AutoSize = true;
            this.chkEntreFechas.Location = new System.Drawing.Point(12, 91);
            this.chkEntreFechas.Name = "chkEntreFechas";
            this.chkEntreFechas.Size = new System.Drawing.Size(340, 17);
            this.chkEntreFechas.TabIndex = 21;
            this.chkEntreFechas.Text = "Buscar Resultados solo para Solicitudes creadas entre las Fechas:";
            this.chkEntreFechas.UseVisualStyleBackColor = true;
            // 
            // calFechaFin
            // 
            // 
            // 
            // 
            this.calFechaFin.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calFechaFin.ButtonDropDown.Visible = true;
            this.calFechaFin.Location = new System.Drawing.Point(555, 89);
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
            this.calFechaFin.Size = new System.Drawing.Size(184, 20);
            this.calFechaFin.TabIndex = 22;
            // 
            // btnVerSolicitudServicio
            // 
            this.btnVerSolicitudServicio.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVerSolicitudServicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnVerSolicitudServicio, "Ver Solicitud");
            this.balloonTip1.SetBalloonText(this.btnVerSolicitudServicio, null);
            this.btnVerSolicitudServicio.Image = ((System.Drawing.Image)(resources.GetObject("btnVerSolicitudServicio.Image")));
            this.btnVerSolicitudServicio.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnVerSolicitudServicio.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnVerSolicitudServicio.Location = new System.Drawing.Point(745, 81);
            this.btnVerSolicitudServicio.Name = "btnVerSolicitudServicio";
            this.btnVerSolicitudServicio.Size = new System.Drawing.Size(33, 33);
            this.btnVerSolicitudServicio.TabIndex = 23;
            this.btnVerSolicitudServicio.Click += new System.EventHandler(this.btnVerOrdenServicio_Click);
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUpdate = false;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.DataMember = "pltListadoSolicitudServicio";
            this.grdDatos.DataSource = this.dsPlantillas1;
            this.grdDatos.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdDatos.FilterBar = true;
            this.grdDatos.GroupByCaption = "";
            this.grdDatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDatos.Images"))));
            this.grdDatos.Location = new System.Drawing.Point(12, 120);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(984, 594);
            this.grdDatos.TabIndex = 0;
            this.grdDatos.Text = "c1TrueDBGrid1";
            this.grdDatos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.System;
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
            // 
            // dsPlantillas1
            // 
            this.dsPlantillas1.DataSetName = "dsPlantillas";
            this.dsPlantillas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // controladorColumnas1
            // 
            this.controladorColumnas1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controladorColumnas1.BackColor = System.Drawing.Color.Transparent;
            this.controladorColumnas1.grilla = null;
            this.controladorColumnas1.Location = new System.Drawing.Point(781, 80);
            this.controladorColumnas1.MostrarContraer = true;
            this.controladorColumnas1.MostrarExcel = true;
            this.controladorColumnas1.MostrarExpandir = true;
            this.controladorColumnas1.MostrarLimpiar = true;
            this.controladorColumnas1.Name = "controladorColumnas1";
            this.controladorColumnas1.nombreLibro = null;
            this.controladorColumnas1.Size = new System.Drawing.Size(215, 34);
            this.controladorColumnas1.TabIndex = 24;
            // 
            // frmListadoSolicitudesServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1008, 726);
            this.Controls.Add(this.controladorColumnas1);
            this.Controls.Add(this.btnVerSolicitudServicio);
            this.Controls.Add(this.calFechaFin);
            this.Controls.Add(this.chkEntreFechas);
            this.Controls.Add(this.calfechaInicio);
            this.Controls.Add(this.btnFiltrarxEstado);
            this.Controls.Add(this.cmbEstados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListadoSolicitudesServicio";
            this.Text = "Listado Solicitudes de Servicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListadoOrdenesServicio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private DevComponents.DotNetBar.ButtonX btnVerSolicitudServicio;
        private SPControladoraDatos.dsPlantillas dsPlantillas1;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas controladorColumnas1;
    }
}