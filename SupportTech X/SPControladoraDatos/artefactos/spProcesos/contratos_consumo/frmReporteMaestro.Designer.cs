﻿namespace spProcesos.contratos_consumo
{
    partial class frmReporteMaestro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteMaestro));
            this.chkLimitarNumeroResultados = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.txtCampo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdNoLegalizados = new System.Windows.Forms.RadioButton();
            this.rdLegalizados = new System.Windows.Forms.RadioButton();
            this.rdTodos = new System.Windows.Forms.RadioButton();
            this.controladorColumnas1 = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas();
            this.btnVerContrato = new DevComponents.DotNetBar.ButtonX();
            this.nmRegistros = new System.Windows.Forms.NumericUpDown();
            this.grdDatos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.chkReporteResumido = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkFechas = new System.Windows.Forms.CheckBox();
            this.calInicio = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.calFin = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFin)).BeginInit();
            this.SuspendLayout();
            // 
            // chkLimitarNumeroResultados
            // 
            this.chkLimitarNumeroResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkLimitarNumeroResultados.AutoSize = true;
            this.chkLimitarNumeroResultados.Location = new System.Drawing.Point(598, 66);
            this.chkLimitarNumeroResultados.Name = "chkLimitarNumeroResultados";
            this.chkLimitarNumeroResultados.Size = new System.Drawing.Size(146, 17);
            this.chkLimitarNumeroResultados.TabIndex = 115;
            this.chkLimitarNumeroResultados.Text = "Registros en la busqueda";
            this.chkLimitarNumeroResultados.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.cmbCampo);
            this.groupBox1.Controls.Add(this.txtCampo);
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 50);
            this.groupBox1.TabIndex = 114;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnBuscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBuscar.Location = new System.Drawing.Point(300, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(33, 33);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbCampo
            // 
            this.cmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampo.FormattingEnabled = true;
            this.cmbCampo.Items.AddRange(new object[] {
            "Numero Contrato",
            "Nit Cliente",
            "Cliente",
            "Numero Socio",
            "Modelos",
            "Fabricantes",
            "Serial",
            "Lineas de Consumo"});
            this.cmbCampo.Location = new System.Drawing.Point(8, 19);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(128, 21);
            this.cmbCampo.TabIndex = 1;
            // 
            // txtCampo
            // 
            this.txtCampo.Location = new System.Drawing.Point(142, 19);
            this.txtCampo.Name = "txtCampo";
            this.txtCampo.Size = new System.Drawing.Size(152, 20);
            this.txtCampo.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdNoLegalizados);
            this.groupBox2.Controls.Add(this.rdLegalizados);
            this.groupBox2.Controls.Add(this.rdTodos);
            this.groupBox2.Location = new System.Drawing.Point(373, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 40);
            this.groupBox2.TabIndex = 113;
            this.groupBox2.TabStop = false;
            // 
            // rdNoLegalizados
            // 
            this.rdNoLegalizados.AutoSize = true;
            this.rdNoLegalizados.Location = new System.Drawing.Point(277, 15);
            this.rdNoLegalizados.Name = "rdNoLegalizados";
            this.rdNoLegalizados.Size = new System.Drawing.Size(126, 17);
            this.rdNoLegalizados.TabIndex = 2;
            this.rdNoLegalizados.Text = "Traer No Legalizados";
            this.rdNoLegalizados.UseVisualStyleBackColor = true;
            // 
            // rdLegalizados
            // 
            this.rdLegalizados.AutoSize = true;
            this.rdLegalizados.Location = new System.Drawing.Point(123, 15);
            this.rdLegalizados.Name = "rdLegalizados";
            this.rdLegalizados.Size = new System.Drawing.Size(109, 17);
            this.rdLegalizados.TabIndex = 1;
            this.rdLegalizados.Text = "Traer Legalizados";
            this.rdLegalizados.UseVisualStyleBackColor = true;
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
            this.controladorColumnas1.Location = new System.Drawing.Point(629, 95);
            this.controladorColumnas1.MostrarContraer = true;
            this.controladorColumnas1.MostrarExcel = true;
            this.controladorColumnas1.MostrarExpandir = true;
            this.controladorColumnas1.MostrarLimpiar = true;
            this.controladorColumnas1.Name = "controladorColumnas1";
            this.controladorColumnas1.nombreLibro = null;
            this.controladorColumnas1.Size = new System.Drawing.Size(216, 29);
            this.controladorColumnas1.TabIndex = 111;
            // 
            // btnVerContrato
            // 
            this.btnVerContrato.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVerContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerContrato.Image = ((System.Drawing.Image)(resources.GetObject("btnVerContrato.Image")));
            this.btnVerContrato.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnVerContrato.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnVerContrato.Location = new System.Drawing.Point(598, 96);
            this.btnVerContrato.Name = "btnVerContrato";
            this.btnVerContrato.Size = new System.Drawing.Size(28, 28);
            this.btnVerContrato.TabIndex = 110;
            this.btnVerContrato.Tooltip = "Ver Contrato";
            this.btnVerContrato.Click += new System.EventHandler(this.btnVerContrato_Click);
            // 
            // nmRegistros
            // 
            this.nmRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nmRegistros.Location = new System.Drawing.Point(750, 63);
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
            this.nmRegistros.TabIndex = 109;
            this.nmRegistros.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUpdate = false;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdDatos.FilterBar = true;
            this.grdDatos.GroupByCaption = "";
            this.grdDatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDatos.Images"))));
            this.grdDatos.Location = new System.Drawing.Point(12, 129);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75D;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(833, 345);
            this.grdDatos.TabIndex = 108;
            this.grdDatos.Text = "c1TrueDBGrid1";
            this.grdDatos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
            // 
            // chkReporteResumido
            // 
            this.chkReporteResumido.AutoSize = true;
            this.chkReporteResumido.Checked = true;
            this.chkReporteResumido.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReporteResumido.Location = new System.Drawing.Point(13, 84);
            this.chkReporteResumido.Name = "chkReporteResumido";
            this.chkReporteResumido.Size = new System.Drawing.Size(114, 17);
            this.chkReporteResumido.TabIndex = 116;
            this.chkReporteResumido.Text = "Reporte Resumido";
            this.chkReporteResumido.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 117;
            // 
            // chkFechas
            // 
            this.chkFechas.AutoSize = true;
            this.chkFechas.Location = new System.Drawing.Point(15, 108);
            this.chkFechas.Name = "chkFechas";
            this.chkFechas.Size = new System.Drawing.Size(111, 17);
            this.chkFechas.TabIndex = 118;
            this.chkFechas.Text = "Modificados Entre";
            this.chkFechas.UseVisualStyleBackColor = true;
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
            this.calInicio.Location = new System.Drawing.Point(154, 103);
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
            this.calInicio.MonthCalendar.DisplayMonth = new System.DateTime(2013, 10, 1, 0, 0, 0, 0);
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
            this.calInicio.Size = new System.Drawing.Size(135, 20);
            this.calInicio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.calInicio.TabIndex = 119;
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
            this.calFin.Location = new System.Drawing.Point(312, 103);
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
            this.calFin.MonthCalendar.DisplayMonth = new System.DateTime(2013, 10, 1, 0, 0, 0, 0);
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
            this.calFin.Size = new System.Drawing.Size(135, 20);
            this.calFin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.calFin.TabIndex = 120;
            // 
            // frmReporteMaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(857, 480);
            this.Controls.Add(this.calFin);
            this.Controls.Add(this.calInicio);
            this.Controls.Add(this.chkFechas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkReporteResumido);
            this.Controls.Add(this.chkLimitarNumeroResultados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.controladorColumnas1);
            this.Controls.Add(this.btnVerContrato);
            this.Controls.Add(this.nmRegistros);
            this.Controls.Add(this.grdDatos);
            this.Name = "frmReporteMaestro";
            this.Text = "Reporte Maestro Contratos de Consumo";
            this.Load += new System.EventHandler(this.frmReporteMaestro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkLimitarNumeroResultados;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnBuscar;
        private System.Windows.Forms.ComboBox cmbCampo;
        private System.Windows.Forms.TextBox txtCampo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdNoLegalizados;
        private System.Windows.Forms.RadioButton rdLegalizados;
        private System.Windows.Forms.RadioButton rdTodos;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas controladorColumnas1;
        private DevComponents.DotNetBar.ButtonX btnVerContrato;
        private System.Windows.Forms.NumericUpDown nmRegistros;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdDatos;
        private System.Windows.Forms.CheckBox chkReporteResumido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkFechas;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calInicio;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFin;
    }
}