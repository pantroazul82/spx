namespace spProcesos.contratos
{
    partial class frmListadoContratosAVencer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoContratosAVencer));
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.btnVerProgramacion = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.calfechaVencimiento = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label1 = new System.Windows.Forms.Label();
            this.calVencimientoHasta = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.grdDatos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsPlantillas1 = new SPControladoraDatos.dsPlantillas();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.pltListaContratosVencimientoTableAdapter1 = new SPControladoraDatos.dsPlantillasTableAdapters.pltListaContratosVencimientoTableAdapter();
            this.controladorColumnas1 = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas();
            this.groupBox1.SuspendLayout();
            this.grdDatos.BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnBuscar, "Buscar");
            this.balloonTip1.SetBalloonText(this.btnBuscar, null);
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnBuscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBuscar.Location = new System.Drawing.Point(457, 14);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(33, 33);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVerProgramacion
            // 
            this.btnVerProgramacion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVerProgramacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerProgramacion.Image = ((System.Drawing.Image)(resources.GetObject("btnVerProgramacion.Image")));
            this.btnVerProgramacion.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnVerProgramacion.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnVerProgramacion.Location = new System.Drawing.Point(691, 39);
            this.btnVerProgramacion.Name = "btnVerProgramacion";
            this.btnVerProgramacion.Size = new System.Drawing.Size(89, 48);
            this.btnVerProgramacion.TabIndex = 48;
            this.btnVerProgramacion.Text = "Ver Contrato";
            this.btnVerProgramacion.Click += new System.EventHandler(this.btnVerProgramacion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtFiltro);
            this.groupBox1.Controls.Add(this.cmbFiltro);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 51);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(231, 19);
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
            "Nit Cliente",
            "Nombre Cliente",
            "Numero Contrato",
            "Tipo de Contrato",
            "Modalidad"});
            this.cmbFiltro.Location = new System.Drawing.Point(7, 19);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(218, 21);
            this.cmbFiltro.TabIndex = 1;
            // 
            // calfechaVencimiento
            // 
            // 
            // 
            // 
            this.calfechaVencimiento.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calfechaVencimiento.ButtonDropDown.Visible = true;
            this.calfechaVencimiento.Location = new System.Drawing.Point(247, 67);
            // 
            // 
            // 
            this.calfechaVencimiento.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            this.calfechaVencimiento.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calfechaVencimiento.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calfechaVencimiento.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calfechaVencimiento.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calfechaVencimiento.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calfechaVencimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calfechaVencimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calfechaVencimiento.MonthCalendar.DisplayMonth = new System.DateTime(2009, 3, 1, 0, 0, 0, 0);
            this.calfechaVencimiento.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calfechaVencimiento.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calfechaVencimiento.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calfechaVencimiento.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calfechaVencimiento.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calfechaVencimiento.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calfechaVencimiento.MonthCalendar.TodayButtonVisible = true;
            this.calfechaVencimiento.Name = "calfechaVencimiento";
            this.calfechaVencimiento.Size = new System.Drawing.Size(200, 20);
            this.calfechaVencimiento.TabIndex = 53;
            this.calfechaVencimiento.ValueChanged += new System.EventHandler(this.calfechaVencimiento_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Contratos Con Fecha de Vencimiento Entre";
            // 
            // calVencimientoHasta
            // 
            // 
            // 
            // 
            this.calVencimientoHasta.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calVencimientoHasta.ButtonDropDown.Visible = true;
            this.calVencimientoHasta.Location = new System.Drawing.Point(453, 67);
            // 
            // 
            // 
            this.calVencimientoHasta.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            this.calVencimientoHasta.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calVencimientoHasta.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calVencimientoHasta.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calVencimientoHasta.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calVencimientoHasta.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calVencimientoHasta.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calVencimientoHasta.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calVencimientoHasta.MonthCalendar.DisplayMonth = new System.DateTime(2009, 3, 1, 0, 0, 0, 0);
            this.calVencimientoHasta.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calVencimientoHasta.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calVencimientoHasta.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calVencimientoHasta.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calVencimientoHasta.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calVencimientoHasta.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calVencimientoHasta.MonthCalendar.TodayButtonVisible = true;
            this.calVencimientoHasta.Name = "calVencimientoHasta";
            this.calVencimientoHasta.Size = new System.Drawing.Size(200, 20);
            this.calVencimientoHasta.TabIndex = 57;
            this.calVencimientoHasta.ValueChanged += new System.EventHandler(this.calVencimientoHasta_ValueChanged);
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUpdate = false;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.DataMember = "pltListaContratosVencimiento";
            this.grdDatos.DataSource = this.dsPlantillas1;
            this.grdDatos.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdDatos.FetchRowStyles = true;
            this.grdDatos.FilterBar = true;
            this.grdDatos.GroupByCaption = "";
            this.grdDatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDatos.Images"))));
            this.grdDatos.Location = new System.Drawing.Point(14, 93);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(984, 620);
            this.grdDatos.TabIndex = 49;
            this.grdDatos.Text = "c1TrueDBGrid1";
            this.grdDatos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.grdDatos.FetchRowStyle += new C1.Win.C1TrueDBGrid.FetchRowStyleEventHandler(this.grdDatos_FetchRowStyle);
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
            // pltListaContratosVencimientoTableAdapter1
            // 
            this.pltListaContratosVencimientoTableAdapter1.ClearBeforeFill = true;
            // 
            // controladorColumnas1
            // 
            this.controladorColumnas1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controladorColumnas1.BackColor = System.Drawing.Color.Transparent;
            this.controladorColumnas1.grilla = null;
            this.controladorColumnas1.Location = new System.Drawing.Point(784, 53);
            this.controladorColumnas1.MostrarContraer = true;
            this.controladorColumnas1.MostrarExcel = true;
            this.controladorColumnas1.MostrarExpandir = true;
            this.controladorColumnas1.MostrarLimpiar = true;
            this.controladorColumnas1.Name = "controladorColumnas1";
            this.controladorColumnas1.nombreLibro = null;
            this.controladorColumnas1.Size = new System.Drawing.Size(215, 34);
            this.controladorColumnas1.TabIndex = 58;
            // 
            // frmListadoContratosAVencer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1008, 722);
            this.Controls.Add(this.controladorColumnas1);
            this.Controls.Add(this.calVencimientoHasta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calfechaVencimiento);
            this.Controls.Add(this.grdDatos);
            this.Controls.Add(this.btnVerProgramacion);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListadoContratosAVencer";
            this.Text = "Contratos Proximos a Vencer";
            this.Load += new System.EventHandler(this.frmListadoContratosAVencer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private SPControladoraDatos.dsPlantillas dsPlantillas1;
        private SPControladoraDatos.dsSpx dsSpx1;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdDatos;
        private DevComponents.DotNetBar.ButtonX btnVerProgramacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnBuscar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calfechaVencimiento;
        private System.Windows.Forms.Label label1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calVencimientoHasta;
        private SPControladoraDatos.dsPlantillasTableAdapters.pltListaContratosVencimientoTableAdapter pltListaContratosVencimientoTableAdapter1;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas controladorColumnas1;
    }
}