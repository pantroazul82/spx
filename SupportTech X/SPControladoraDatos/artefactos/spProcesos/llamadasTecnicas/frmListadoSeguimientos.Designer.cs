namespace spProcesos.llamadasTecnicas
{
    partial class frmListadoSeguimientos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoSeguimientos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.grdDatos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.seguimientoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.seguimientoTableAdapter();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.btnVerLlamada = new DevComponents.DotNetBar.ButtonX();
            this.calFecha = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.controladorColumnas1 = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.chkNotificacionesACtivas = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.grdDatos.BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFecha)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtFiltro);
            this.groupBox1.Controls.Add(this.cmbCampo);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 68);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnBuscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBuscar.Location = new System.Drawing.Point(456, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(29, 29);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(230, 26);
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
            "Cod Seguimiento",
            "Serial",
            "Nit Cliente"});
            this.cmbCampo.Location = new System.Drawing.Point(6, 26);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(218, 21);
            this.cmbCampo.TabIndex = 3;
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUpdate = false;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.DataMember = "seguimiento";
            this.grdDatos.DataSource = this.dsSpx1;
            this.grdDatos.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdDatos.FilterBar = true;
            this.grdDatos.GroupByCaption = "";
            this.grdDatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDatos.Images"))));
            this.grdDatos.Location = new System.Drawing.Point(12, 89);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75D;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(807, 465);
            this.grdDatos.TabIndex = 77;
            this.grdDatos.Text = "c1TrueDBGrid1";
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seguimientoTableAdapter1
            // 
            this.seguimientoTableAdapter1.ClearBeforeFill = true;
            // 
            // btnVerLlamada
            // 
            this.btnVerLlamada.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVerLlamada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnVerLlamada, "Ver Seguimiento");
            this.btnVerLlamada.Image = ((System.Drawing.Image)(resources.GetObject("btnVerLlamada.Image")));
            this.btnVerLlamada.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnVerLlamada.Location = new System.Drawing.Point(576, 54);
            this.btnVerLlamada.Name = "btnVerLlamada";
            this.btnVerLlamada.Size = new System.Drawing.Size(26, 28);
            this.btnVerLlamada.TabIndex = 79;
            this.btnVerLlamada.Text = " ";
            this.btnVerLlamada.Click += new System.EventHandler(this.btnVerLlamada_Click);
            // 
            // calFecha
            // 
            this.calFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.calFecha.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calFecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFecha.ButtonDropDown.Visible = true;
            this.calFecha.Location = new System.Drawing.Point(619, 27);
            // 
            // 
            // 
            this.calFecha.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFecha.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calFecha.MonthCalendar.BackgroundStyle.Class = "";
            this.calFecha.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFecha.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calFecha.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calFecha.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calFecha.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calFecha.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calFecha.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calFecha.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calFecha.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calFecha.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFecha.MonthCalendar.DisplayMonth = new System.DateTime(2009, 1, 1, 0, 0, 0, 0);
            this.calFecha.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calFecha.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calFecha.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFecha.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calFecha.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calFecha.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calFecha.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calFecha.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFecha.MonthCalendar.TodayButtonVisible = true;
            this.calFecha.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calFecha.Name = "calFecha";
            this.calFecha.Size = new System.Drawing.Size(200, 20);
            this.calFecha.TabIndex = 84;
            this.calFecha.ValueChanged += new System.EventHandler(this.calFecha_ValueChanged);
            // 
            // controladorColumnas1
            // 
            this.controladorColumnas1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controladorColumnas1.BackColor = System.Drawing.Color.Transparent;
            this.controladorColumnas1.grilla = null;
            this.controladorColumnas1.Location = new System.Drawing.Point(603, 54);
            this.controladorColumnas1.MostrarContraer = true;
            this.controladorColumnas1.MostrarExcel = true;
            this.controladorColumnas1.MostrarExpandir = true;
            this.controladorColumnas1.MostrarLimpiar = true;
            this.controladorColumnas1.Name = "controladorColumnas1";
            this.controladorColumnas1.nombreLibro = null;
            this.controladorColumnas1.Size = new System.Drawing.Size(216, 29);
            this.controladorColumnas1.TabIndex = 85;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // alertControl1
            // 
            this.alertControl1.AutoFormDelay = 700000;
            this.alertControl1.AutoHeight = true;
            // 
            // chkNotificacionesACtivas
            // 
            this.chkNotificacionesACtivas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkNotificacionesACtivas.AutoSize = true;
            this.chkNotificacionesACtivas.Checked = global::SPControladoraDatos.Properties.Settings.Default.notificacionesActivas;
            this.chkNotificacionesACtivas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNotificacionesACtivas.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::SPControladoraDatos.Properties.Settings.Default, "notificacionesActivas", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkNotificacionesACtivas.Location = new System.Drawing.Point(688, 5);
            this.chkNotificacionesACtivas.Name = "chkNotificacionesACtivas";
            this.chkNotificacionesACtivas.Size = new System.Drawing.Size(131, 17);
            this.chkNotificacionesACtivas.TabIndex = 86;
            this.chkNotificacionesACtivas.Text = "Notificaciones Activas";
            this.chkNotificacionesACtivas.UseVisualStyleBackColor = true;
            // 
            // frmListadoSeguimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(831, 566);
            this.Controls.Add(this.chkNotificacionesACtivas);
            this.Controls.Add(this.controladorColumnas1);
            this.Controls.Add(this.calFecha);
            this.Controls.Add(this.btnVerLlamada);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListadoSeguimientos";
            this.Text = "Seguimientos";
            this.Load += new System.EventHandler(this.frmListadoSeguimientos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFecha)).EndInit();
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
        private SPControladoraDatos.dsSpxTableAdapters.seguimientoTableAdapter seguimientoTableAdapter1;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private DevComponents.DotNetBar.ButtonX btnVerLlamada;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFecha;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas controladorColumnas1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private System.Windows.Forms.CheckBox chkNotificacionesACtivas;
    }
}