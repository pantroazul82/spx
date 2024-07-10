namespace spProcesos.Equipos
{
    partial class frmAuditoriaEquipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuditoriaEquipo));
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.calFechaFin = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.calfechaInicio = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.btnInfEquipo = new DevComponents.DotNetBar.ButtonX();
            this.grdDAtos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calfechaInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDAtos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarExcel.Location = new System.Drawing.Point(723, 30);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(178, 33);
            this.btnExportarExcel.TabIndex = 81;
            this.btnExportarExcel.Text = "Exportar Excel";
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // txtfiltro
            // 
            this.txtfiltro.Location = new System.Drawing.Point(12, 12);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(405, 20);
            this.txtfiltro.TabIndex = 80;
            // 
            // calFechaFin
            // 
            // 
            // 
            // 
            this.calFechaFin.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calFechaFin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaFin.ButtonDropDown.Visible = true;
            this.calFechaFin.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calFechaFin.Location = new System.Drawing.Point(225, 38);
            // 
            // 
            // 
            this.calFechaFin.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
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
            this.calFechaFin.Size = new System.Drawing.Size(200, 21);
            this.calFechaFin.TabIndex = 79;
            // 
            // calfechaInicio
            // 
            // 
            // 
            // 
            this.calfechaInicio.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calfechaInicio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calfechaInicio.ButtonDropDown.Visible = true;
            this.calfechaInicio.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calfechaInicio.Location = new System.Drawing.Point(12, 38);
            // 
            // 
            // 
            this.calfechaInicio.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
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
            this.calfechaInicio.Size = new System.Drawing.Size(200, 21);
            this.calfechaInicio.TabIndex = 78;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnBuscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBuscar.Location = new System.Drawing.Point(431, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(33, 33);
            this.btnBuscar.TabIndex = 77;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnInfEquipo
            // 
            this.btnInfEquipo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInfEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfEquipo.Image")));
            this.btnInfEquipo.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnInfEquipo.Location = new System.Drawing.Point(907, 30);
            this.btnInfEquipo.Name = "btnInfEquipo";
            this.btnInfEquipo.Size = new System.Drawing.Size(33, 33);
            this.btnInfEquipo.TabIndex = 76;
            this.btnInfEquipo.Click += new System.EventHandler(this.btnInfEquipo_Click);
            // 
            // grdDAtos
            // 
            this.grdDAtos.AllowUpdate = false;
            this.grdDAtos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDAtos.FilterBar = true;
            this.grdDAtos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDAtos.Images"))));
            this.grdDAtos.Location = new System.Drawing.Point(12, 69);
            this.grdDAtos.Name = "grdDAtos";
            this.grdDAtos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDAtos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDAtos.PreviewInfo.ZoomFactor = 75D;
            this.grdDAtos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDAtos.PrintInfo.PageSettings")));
            this.grdDAtos.Size = new System.Drawing.Size(928, 399);
            this.grdDAtos.TabIndex = 75;
            this.grdDAtos.Text = "c1TrueDBGrid1";
            this.grdDAtos.PropBag = resources.GetString("grdDAtos.PropBag");
            // 
            // frmAuditoriaEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(952, 480);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.txtfiltro);
            this.Controls.Add(this.calFechaFin);
            this.Controls.Add(this.calfechaInicio);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnInfEquipo);
            this.Controls.Add(this.grdDAtos);
            this.Name = "frmAuditoriaEquipo";
            this.Text = "Auditoria Equipo";
            this.Load += new System.EventHandler(this.frmAuditoriaEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calFechaFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calfechaInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDAtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.TextBox txtfiltro;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFechaFin;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calfechaInicio;
        private DevComponents.DotNetBar.ButtonX btnBuscar;
        private DevComponents.DotNetBar.ButtonX btnInfEquipo;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdDAtos;
    }
}