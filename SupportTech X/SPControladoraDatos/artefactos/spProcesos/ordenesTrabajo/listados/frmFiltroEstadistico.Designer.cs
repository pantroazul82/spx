namespace spProcesos.ordenesTrabajo.listados
{
    partial class frmFiltroEstadistico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFiltroEstadistico));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.c1CmbPrioridadesExternas = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsPrioridadesExternas = new SPControladoraDatos.dsPlantillas();
            this.c1CmbCantidad = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsCantidad = new SPControladoraDatos.dsPlantillas();
            this.c1GrdPrioridadesInternas = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsPrioiridadesInternas = new SPControladoraDatos.dsPlantillas();
            this.c1CmbTiposServicio = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsTiposServicio = new SPControladoraDatos.dsPlantillas();
            this.c1CmbEstados = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsEstados = new SPControladoraDatos.dsPlantillas();
            this.pltEstadisticasOrdenSErvicioTableAdapter1 = new SPControladoraDatos.dsPlantillasTableAdapters.pltEstadisticasOrdenSErvicioTableAdapter();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.calInicio = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.calFin = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.c1CmbPrioridadesExternas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrioridadesExternas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CmbCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1GrdPrioridadesInternas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrioiridadesInternas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CmbTiposServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CmbEstados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFin)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(12, 42);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Estado";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(12, 210);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(113, 26);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Tipos de Servicio";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(356, 42);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(132, 23);
            this.labelX3.TabIndex = 8;
            this.labelX3.Text = "Prioridades Internas";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(356, 245);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(132, 23);
            this.labelX4.TabIndex = 9;
            this.labelX4.Text = "Prioridades Externas";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(356, 413);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 10;
            this.labelX5.Text = "Fechas";
            // 
            // c1CmbPrioridadesExternas
            // 
            this.c1CmbPrioridadesExternas.AllowUpdate = false;
            this.c1CmbPrioridadesExternas.DataMember = "pltEstadisticasOrdenSErvicio";
            this.c1CmbPrioridadesExternas.DataSource = this.dsPrioridadesExternas;
            this.c1CmbPrioridadesExternas.GroupByCaption = "Drag a column header here to group by that column";
            this.c1CmbPrioridadesExternas.Images.Add(((System.Drawing.Image)(resources.GetObject("c1CmbPrioridadesExternas.Images"))));
            this.c1CmbPrioridadesExternas.Images.Add(((System.Drawing.Image)(resources.GetObject("c1CmbPrioridadesExternas.Images1"))));
            this.c1CmbPrioridadesExternas.Location = new System.Drawing.Point(356, 269);
            this.c1CmbPrioridadesExternas.Name = "c1CmbPrioridadesExternas";
            this.c1CmbPrioridadesExternas.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1CmbPrioridadesExternas.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1CmbPrioridadesExternas.PreviewInfo.ZoomFactor = 75D;
            this.c1CmbPrioridadesExternas.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1CmbPrioridadesExternas.PrintInfo.PageSettings")));
            this.c1CmbPrioridadesExternas.Size = new System.Drawing.Size(448, 139);
            this.c1CmbPrioridadesExternas.TabIndex = 4;
            this.c1CmbPrioridadesExternas.Text = "c1TrueDBGrid1";
            this.c1CmbPrioridadesExternas.Click += new System.EventHandler(this.c1CmbPrioridadesExternas_Click);
            this.c1CmbPrioridadesExternas.PropBag = resources.GetString("c1CmbPrioridadesExternas.PropBag");
            // 
            // dsPrioridadesExternas
            // 
            this.dsPrioridadesExternas.DataSetName = "dsPlantillas";
            this.dsPrioridadesExternas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // c1CmbCantidad
            // 
            this.c1CmbCantidad.DataMember = "pltEstadisticasOrdenSErvicio";
            this.c1CmbCantidad.DataSource = this.dsCantidad;
            this.c1CmbCantidad.GroupByCaption = "Drag a column header here to group by that column";
            this.c1CmbCantidad.Images.Add(((System.Drawing.Image)(resources.GetObject("c1CmbCantidad.Images"))));
            this.c1CmbCantidad.Images.Add(((System.Drawing.Image)(resources.GetObject("c1CmbCantidad.Images1"))));
            this.c1CmbCantidad.Location = new System.Drawing.Point(356, 436);
            this.c1CmbCantidad.Name = "c1CmbCantidad";
            this.c1CmbCantidad.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1CmbCantidad.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1CmbCantidad.PreviewInfo.ZoomFactor = 75D;
            this.c1CmbCantidad.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1CmbCantidad.PrintInfo.PageSettings")));
            this.c1CmbCantidad.Size = new System.Drawing.Size(464, 113);
            this.c1CmbCantidad.TabIndex = 6;
            this.c1CmbCantidad.Text = "c1TrueDBGrid1";
            this.c1CmbCantidad.Click += new System.EventHandler(this.c1CmbCantidad_Click);
            this.c1CmbCantidad.PropBag = resources.GetString("c1CmbCantidad.PropBag");
            // 
            // dsCantidad
            // 
            this.dsCantidad.DataSetName = "dsPlantillas";
            this.dsCantidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // c1GrdPrioridadesInternas
            // 
            this.c1GrdPrioridadesInternas.AllowUpdate = false;
            this.c1GrdPrioridadesInternas.DataMember = "pltEstadisticasOrdenSErvicio";
            this.c1GrdPrioridadesInternas.DataSource = this.dsPrioiridadesInternas;
            this.c1GrdPrioridadesInternas.GroupByCaption = "Drag a column header here to group by that column";
            this.c1GrdPrioridadesInternas.Images.Add(((System.Drawing.Image)(resources.GetObject("c1GrdPrioridadesInternas.Images"))));
            this.c1GrdPrioridadesInternas.Images.Add(((System.Drawing.Image)(resources.GetObject("c1GrdPrioridadesInternas.Images1"))));
            this.c1GrdPrioridadesInternas.Location = new System.Drawing.Point(356, 71);
            this.c1GrdPrioridadesInternas.Name = "c1GrdPrioridadesInternas";
            this.c1GrdPrioridadesInternas.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1GrdPrioridadesInternas.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1GrdPrioridadesInternas.PreviewInfo.ZoomFactor = 75D;
            this.c1GrdPrioridadesInternas.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1GrdPrioridadesInternas.PrintInfo.PageSettings")));
            this.c1GrdPrioridadesInternas.Size = new System.Drawing.Size(448, 174);
            this.c1GrdPrioridadesInternas.TabIndex = 0;
            this.c1GrdPrioridadesInternas.Text = "c1TrueDBGrid1";
            this.c1GrdPrioridadesInternas.Click += new System.EventHandler(this.c1GrdPrioridadesInternas_Click);
            this.c1GrdPrioridadesInternas.PropBag = resources.GetString("c1GrdPrioridadesInternas.PropBag");
            // 
            // dsPrioiridadesInternas
            // 
            this.dsPrioiridadesInternas.DataSetName = "dsPlantillas";
            this.dsPrioiridadesInternas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // c1CmbTiposServicio
            // 
            this.c1CmbTiposServicio.AllowUpdate = false;
            this.c1CmbTiposServicio.DataMember = "pltEstadisticasOrdenSErvicio";
            this.c1CmbTiposServicio.DataSource = this.dsTiposServicio;
            this.c1CmbTiposServicio.GroupByCaption = "Drag a column header here to group by that column";
            this.c1CmbTiposServicio.Images.Add(((System.Drawing.Image)(resources.GetObject("c1CmbTiposServicio.Images"))));
            this.c1CmbTiposServicio.Images.Add(((System.Drawing.Image)(resources.GetObject("c1CmbTiposServicio.Images1"))));
            this.c1CmbTiposServicio.Location = new System.Drawing.Point(12, 235);
            this.c1CmbTiposServicio.Name = "c1CmbTiposServicio";
            this.c1CmbTiposServicio.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1CmbTiposServicio.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1CmbTiposServicio.PreviewInfo.ZoomFactor = 75D;
            this.c1CmbTiposServicio.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1CmbTiposServicio.PrintInfo.PageSettings")));
            this.c1CmbTiposServicio.Size = new System.Drawing.Size(318, 314);
            this.c1CmbTiposServicio.TabIndex = 7;
            this.c1CmbTiposServicio.Text = "c1TrueDBGrid1";
            this.c1CmbTiposServicio.Click += new System.EventHandler(this.c1CmbTiposServicio_Click);
            this.c1CmbTiposServicio.PropBag = resources.GetString("c1CmbTiposServicio.PropBag");
            // 
            // dsTiposServicio
            // 
            this.dsTiposServicio.DataSetName = "dsPlantillas";
            this.dsTiposServicio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // c1CmbEstados
            // 
            this.c1CmbEstados.Cursor = System.Windows.Forms.Cursors.Default;
            this.c1CmbEstados.DataMember = "pltEstadisticasOrdenSErvicio";
            this.c1CmbEstados.DataSource = this.dsEstados;
            this.c1CmbEstados.GroupByCaption = "Drag a column header here to group by that column";
            this.c1CmbEstados.Images.Add(((System.Drawing.Image)(resources.GetObject("c1CmbEstados.Images"))));
            this.c1CmbEstados.Images.Add(((System.Drawing.Image)(resources.GetObject("c1CmbEstados.Images1"))));
            this.c1CmbEstados.Images.Add(((System.Drawing.Image)(resources.GetObject("c1CmbEstados.Images2"))));
            this.c1CmbEstados.LinesPerRow = 1;
            this.c1CmbEstados.Location = new System.Drawing.Point(12, 71);
            this.c1CmbEstados.Name = "c1CmbEstados";
            this.c1CmbEstados.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1CmbEstados.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1CmbEstados.PreviewInfo.ZoomFactor = 75D;
            this.c1CmbEstados.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1CmbEstados.PrintInfo.PageSettings")));
            this.c1CmbEstados.Size = new System.Drawing.Size(316, 133);
            this.c1CmbEstados.TabIndex = 5;
            this.c1CmbEstados.Text = "c1TrueDBGrid1";
            this.c1CmbEstados.Click += new System.EventHandler(this.c1CmbEstados_Click);
            this.c1CmbEstados.PropBag = resources.GetString("c1CmbEstados.PropBag");
            // 
            // dsEstados
            // 
            this.dsEstados.DataSetName = "dsPlantillas";
            this.dsEstados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pltEstadisticasOrdenSErvicioTableAdapter1
            // 
            this.pltEstadisticasOrdenSErvicioTableAdapter1.ClearBeforeFill = true;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(12, 13);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(129, 23);
            this.labelX6.TabIndex = 11;
            this.labelX6.Text = "Fecha Programacion";
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
            this.calInicio.Location = new System.Drawing.Point(168, 15);
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
            this.calInicio.MonthCalendar.DisplayMonth = new System.DateTime(2011, 8, 1, 0, 0, 0, 0);
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
            this.calInicio.Size = new System.Drawing.Size(131, 20);
            this.calInicio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.calInicio.TabIndex = 12;
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
            this.calFin.Location = new System.Drawing.Point(315, 15);
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
            this.calFin.MonthCalendar.DisplayMonth = new System.DateTime(2011, 8, 1, 0, 0, 0, 0);
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
            this.calFin.Size = new System.Drawing.Size(131, 20);
            this.calFin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.calFin.TabIndex = 13;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBuscar.Location = new System.Drawing.Point(461, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmFiltroEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(832, 558);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.calFin);
            this.Controls.Add(this.calInicio);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.c1CmbPrioridadesExternas);
            this.Controls.Add(this.c1CmbCantidad);
            this.Controls.Add(this.c1GrdPrioridadesInternas);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.c1CmbTiposServicio);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.c1CmbEstados);
            this.Controls.Add(this.labelX1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFiltroEstadistico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenes de Servicio";
            this.Load += new System.EventHandler(this.frmFiltroEstadistico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1CmbPrioridadesExternas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrioridadesExternas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CmbCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1GrdPrioridadesInternas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrioiridadesInternas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CmbTiposServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CmbEstados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1GrdPrioridadesInternas;
        private SPControladoraDatos.dsPlantillas dsEstados;
        private SPControladoraDatos.dsPlantillasTableAdapters.pltEstadisticasOrdenSErvicioTableAdapter pltEstadisticasOrdenSErvicioTableAdapter1;
        private SPControladoraDatos.dsPlantillas dsTiposServicio;
        private SPControladoraDatos.dsPlantillas dsPrioiridadesInternas;
        private SPControladoraDatos.dsPlantillas dsPrioridadesExternas;
        private SPControladoraDatos.dsPlantillas dsCantidad;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1CmbPrioridadesExternas;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1CmbTiposServicio;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1CmbCantidad;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1CmbEstados;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calInicio;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFin;
        private DevComponents.DotNetBar.ButtonX btnBuscar;
    }
}