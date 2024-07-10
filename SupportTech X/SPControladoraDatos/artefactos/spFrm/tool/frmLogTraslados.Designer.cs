namespace SpFrm.tool
{
    partial class frmLogTraslados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogTraslados));
            this.cmbFiltros = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.btnExportarExcel = new DevComponents.DotNetBar.ButtonX();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnLimpiar = new DevComponents.DotNetBar.ButtonX();
            this.grddatos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.pltLogTrasladosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.pltLogTrasladosTableAdapter();
            this.calInicio = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.calFin = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.btnBorrar = new DevComponents.DotNetBar.ButtonX();
            this.chkFiltarxFechas = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkEnvio = new System.Windows.Forms.CheckBox();
            this.calFinEnvio = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.calInicioEnvio = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnGuardarGrilla = new DevComponents.DotNetBar.ButtonX();
            this.btnReinicciargrilla = new DevComponents.DotNetBar.ButtonX();
            
            ((System.ComponentModel.ISupportInitialize)(this.grddatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFiltros
            // 
            this.cmbFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltros.FormattingEnabled = true;
            this.cmbFiltros.Items.AddRange(new object[] {
            "Serial",
            "Nit Cliente",
            "Nombre Cliente",
            "Usuario"});
            this.cmbFiltros.Location = new System.Drawing.Point(12, 9);
            this.cmbFiltros.Name = "cmbFiltros";
            this.cmbFiltros.Size = new System.Drawing.Size(231, 21);
            this.cmbFiltros.TabIndex = 1;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(259, 9);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(199, 20);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnBuscar, "Buscar");
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageFixedSize = new System.Drawing.Size(29, 29);
            this.btnBuscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBuscar.Location = new System.Drawing.Point(464, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(33, 33);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExportarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnExportarExcel, "Exportar Excel");
            this.btnExportarExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarExcel.Image")));
            this.btnExportarExcel.ImageFixedSize = new System.Drawing.Size(29, 29);
            this.btnExportarExcel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnExportarExcel.Location = new System.Drawing.Point(931, 63);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(33, 33);
            this.btnExportarExcel.TabIndex = 3;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnLimpiar, "Limpiar Grilla");
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageFixedSize = new System.Drawing.Size(29, 29);
            this.btnLimpiar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnLimpiar.Location = new System.Drawing.Point(892, 63);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(33, 33);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // grddatos
            // 
            this.grddatos.AllowUpdate = false;
            this.grddatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grddatos.DataMember = "pltLogTraslados";
            this.grddatos.DataSource = this.dsSpx1;
            this.grddatos.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grddatos.FilterBar = true;
            this.grddatos.GroupByCaption = "";
            this.grddatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grddatos.Images"))));
            this.grddatos.Location = new System.Drawing.Point(12, 102);
            this.grddatos.Name = "grddatos";
            this.grddatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grddatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grddatos.PreviewInfo.ZoomFactor = 75;
            this.grddatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grddatos.PrintInfo.PageSettings")));
            this.grddatos.Size = new System.Drawing.Size(952, 453);
            this.grddatos.TabIndex = 0;
            this.grddatos.Text = "c1TrueDBGrid1";
            this.grddatos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Black;
            this.grddatos.Click += new System.EventHandler(this.grddatos_Click);
            this.grddatos.PropBag = resources.GetString("grddatos.PropBag");
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pltLogTrasladosTableAdapter1
            // 
            this.pltLogTrasladosTableAdapter1.ClearBeforeFill = true;
            // 
            // calInicio
            // 
            // 
            // 
            // 
            this.calInicio.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calInicio.ButtonDropDown.Visible = true;
            this.calInicio.Location = new System.Drawing.Point(154, 43);
            // 
            // 
            // 
            this.calInicio.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
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
            this.calInicio.MonthCalendar.DisplayMonth = new System.DateTime(2009, 2, 1, 0, 0, 0, 0);
            this.calInicio.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calInicio.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calInicio.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calInicio.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calInicio.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calInicio.MonthCalendar.TodayButtonVisible = true;
            this.calInicio.Name = "calInicio";
            this.calInicio.Size = new System.Drawing.Size(200, 20);
            this.calInicio.TabIndex = 6;
            // 
            // calFin
            // 
            // 
            // 
            // 
            this.calFin.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calFin.ButtonDropDown.Visible = true;
            this.calFin.Location = new System.Drawing.Point(369, 43);
            // 
            // 
            // 
            this.calFin.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
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
            this.calFin.MonthCalendar.DisplayMonth = new System.DateTime(2009, 2, 1, 0, 0, 0, 0);
            this.calFin.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calFin.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFin.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calFin.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calFin.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calFin.MonthCalendar.TodayButtonVisible = true;
            this.calFin.Name = "calFin";
            this.calFin.Size = new System.Drawing.Size(200, 20);
            this.calFin.TabIndex = 7;
            // 
            // btnBorrar
            // 
            this.btnBorrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnBorrar, "Eliminar Historico de Traslado");
            this.balloonTip1.SetBalloonText(this.btnBorrar, null);
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.ImageFixedSize = new System.Drawing.Size(29, 29);
            this.btnBorrar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBorrar.Location = new System.Drawing.Point(782, 63);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(33, 33);
            this.btnBorrar.TabIndex = 14;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // chkFiltarxFechas
            // 
            this.chkFiltarxFechas.AutoSize = true;
            this.chkFiltarxFechas.Location = new System.Drawing.Point(12, 43);
            this.chkFiltarxFechas.Name = "chkFiltarxFechas";
            this.chkFiltarxFechas.Size = new System.Drawing.Size(141, 17);
            this.chkFiltarxFechas.TabIndex = 8;
            this.chkFiltarxFechas.Text = "Filtrar Por Fecha Cambio";
            this.chkFiltarxFechas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "-";
            // 
            // chkEnvio
            // 
            this.chkEnvio.AutoSize = true;
            this.chkEnvio.Location = new System.Drawing.Point(12, 66);
            this.chkEnvio.Name = "chkEnvio";
            this.chkEnvio.Size = new System.Drawing.Size(133, 17);
            this.chkEnvio.TabIndex = 12;
            this.chkEnvio.Text = "Filtrar Por Fecha Envio";
            this.chkEnvio.UseVisualStyleBackColor = true;
            // 
            // calFinEnvio
            // 
            // 
            // 
            // 
            this.calFinEnvio.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calFinEnvio.ButtonDropDown.Visible = true;
            this.calFinEnvio.Location = new System.Drawing.Point(369, 66);
            // 
            // 
            // 
            this.calFinEnvio.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            this.calFinEnvio.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calFinEnvio.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calFinEnvio.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calFinEnvio.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calFinEnvio.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calFinEnvio.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calFinEnvio.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calFinEnvio.MonthCalendar.DisplayMonth = new System.DateTime(2009, 2, 1, 0, 0, 0, 0);
            this.calFinEnvio.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calFinEnvio.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFinEnvio.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calFinEnvio.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calFinEnvio.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calFinEnvio.MonthCalendar.TodayButtonVisible = true;
            this.calFinEnvio.Name = "calFinEnvio";
            this.calFinEnvio.Size = new System.Drawing.Size(200, 20);
            this.calFinEnvio.TabIndex = 11;
            // 
            // calInicioEnvio
            // 
            // 
            // 
            // 
            this.calInicioEnvio.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calInicioEnvio.ButtonDropDown.Visible = true;
            this.calInicioEnvio.Location = new System.Drawing.Point(154, 66);
            // 
            // 
            // 
            this.calInicioEnvio.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            this.calInicioEnvio.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calInicioEnvio.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calInicioEnvio.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calInicioEnvio.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calInicioEnvio.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calInicioEnvio.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calInicioEnvio.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calInicioEnvio.MonthCalendar.DisplayMonth = new System.DateTime(2009, 2, 1, 0, 0, 0, 0);
            this.calInicioEnvio.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calInicioEnvio.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calInicioEnvio.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calInicioEnvio.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calInicioEnvio.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calInicioEnvio.MonthCalendar.TodayButtonVisible = true;
            this.calInicioEnvio.Name = "calInicioEnvio";
            this.calInicioEnvio.Size = new System.Drawing.Size(200, 20);
            this.calInicioEnvio.TabIndex = 10;
            // 
            // btnGuardarGrilla
            // 
            this.btnGuardarGrilla.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGuardarGrilla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnGuardarGrilla, "Guardar Columnas");
            this.balloonTip1.SetBalloonText(this.btnGuardarGrilla, "Guarda El Esquema de las Columnas");
            this.btnGuardarGrilla.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarGrilla.Image")));
            this.btnGuardarGrilla.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnGuardarGrilla.Location = new System.Drawing.Point(853, 63);
            this.btnGuardarGrilla.Name = "btnGuardarGrilla";
            this.btnGuardarGrilla.Size = new System.Drawing.Size(33, 33);
            this.btnGuardarGrilla.TabIndex = 92;
            this.btnGuardarGrilla.Click += new System.EventHandler(this.btnGuardarGrilla_Click);
            // 
            // btnReinicciargrilla
            // 
            this.btnReinicciargrilla.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReinicciargrilla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnReinicciargrilla, "Restaurar Columnas");
            this.balloonTip1.SetBalloonText(this.btnReinicciargrilla, "Restaurar Columnas a su Valor Original");
            this.btnReinicciargrilla.Image = ((System.Drawing.Image)(resources.GetObject("btnReinicciargrilla.Image")));
            this.btnReinicciargrilla.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnReinicciargrilla.Location = new System.Drawing.Point(818, 63);
            this.btnReinicciargrilla.Name = "btnReinicciargrilla";
            this.btnReinicciargrilla.Size = new System.Drawing.Size(33, 33);
            this.btnReinicciargrilla.TabIndex = 91;
            this.btnReinicciargrilla.Click += new System.EventHandler(this.btnReinicciargrilla_Click);
            // 
            // frmLogTraslados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(976, 566);
            this.Controls.Add(this.btnGuardarGrilla);
            this.Controls.Add(this.btnReinicciargrilla);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.calInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkEnvio);
            this.Controls.Add(this.calFinEnvio);
            this.Controls.Add(this.calInicioEnvio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkFiltarxFechas);
            this.Controls.Add(this.calFin);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cmbFiltros);
            this.Controls.Add(this.grddatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogTraslados";
            this.Text = "Log de Traslados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLogTraslados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grddatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grddatos;
        private SPControladoraDatos.dsSpx dsSpx1;
        private System.Windows.Forms.ComboBox cmbFiltros;
        private System.Windows.Forms.TextBox txtBuscar;
        private DevComponents.DotNetBar.ButtonX btnBuscar;
        private DevComponents.DotNetBar.ButtonX btnExportarExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private SPControladoraDatos.dsSpxTableAdapters.pltLogTrasladosTableAdapter pltLogTrasladosTableAdapter1;
        private DevComponents.DotNetBar.ButtonX btnLimpiar;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calInicio;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFin;
        private System.Windows.Forms.CheckBox chkFiltarxFechas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkEnvio;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFinEnvio;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calInicioEnvio;
        private DevComponents.DotNetBar.ButtonX btnBorrar;
        private DevComponents.DotNetBar.ButtonX btnGuardarGrilla;
        private DevComponents.DotNetBar.ButtonX btnReinicciargrilla;
    }
}