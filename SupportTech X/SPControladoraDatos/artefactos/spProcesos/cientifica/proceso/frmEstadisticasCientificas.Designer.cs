namespace spProcesos.cientifica.proceso
{
    partial class frmEstadisticasCientificas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadisticasCientificas));
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel2 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.StackedBarSeriesLabel stackedBarSeriesLabel1 = new DevExpress.XtraCharts.StackedBarSeriesLabel();
            DevExpress.XtraCharts.StackedBarSeriesView stackedBarSeriesView1 = new DevExpress.XtraCharts.StackedBarSeriesView();
            this.dsPlantillas1 = new SPControladoraDatos.dsPlantillas();
            this.pltListadoCientificaTableAdapter1 = new SPControladoraDatos.dsPlantillasTableAdapters.pltListadoCientificaTableAdapter();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.calFin = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.calInicio = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldcodasesoriacientifica = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldnombreestadoasesoriacientifica = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldprioridadsugerida = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldprioridad = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldfechasolicitud = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldusuariocreacion = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldnombreCliente = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldnombreSucursal = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldnombreCiudad = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldfechaRespuestaInicial = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldnombrereferenciareactivo = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldfabricantereactivo = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldresponsable = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldnombreFabricante = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNombreModelo = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldserial = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldfechavisita = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldfechacierre = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldsolucionado = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldconforme = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldcerradapor = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldnombreinconveniente = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldvencimientoreactivo = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldllamadarecibidadisponibilidad = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldmotivoanulacion = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldfechasugerida = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldfechaprimerseguimiento = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldA = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldB = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldC = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldD = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldE = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldF = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldG = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldH = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldI = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldJ = new DevExpress.XtraPivotGrid.PivotGridField();
            this.btnExcel = new DevComponents.DotNetBar.ButtonX();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnACtualizarGRafico = new DevComponents.DotNetBar.ButtonX();
            this.btnInfoFechas = new DevComponents.DotNetBar.ButtonX();
            this.fieldlotereactivo = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldnumeroreporteqc = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldmotivoconsulta = new DevExpress.XtraPivotGrid.PivotGridField();
            this.btnUno = new DevComponents.DotNetBar.ButtonX();
            this.btnDos = new DevComponents.DotNetBar.ButtonX();
            this.btn3 = new DevComponents.DotNetBar.ButtonX();
            this.btn4 = new DevComponents.DotNetBar.ButtonX();
            this.btn5 = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dsPlantillas1
            // 
            this.dsPlantillas1.DataSetName = "dsPlantillas";
            this.dsPlantillas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pltListadoCientificaTableAdapter1
            // 
            this.pltListadoCientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(232, 13);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(142, 20);
            this.txtFiltro.TabIndex = 83;
            this.txtFiltro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFiltro_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "Filtro Adicional";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Cod Asesoria",
            "Reactivo",
            "Cliente",
            "Nit Cliente"});
            this.cmbFiltro.Location = new System.Drawing.Point(105, 12);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltro.TabIndex = 81;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnBuscar.Location = new System.Drawing.Point(232, 42);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(36, 23);
            this.btnBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBuscar.TabIndex = 76;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.calFin.Location = new System.Drawing.Point(129, 44);
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
            this.calFin.MonthCalendar.DisplayMonth = new System.DateTime(2010, 11, 1, 0, 0, 0, 0);
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
            this.calFin.Size = new System.Drawing.Size(97, 20);
            this.calFin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.calFin.TabIndex = 75;
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
            this.calInicio.Location = new System.Drawing.Point(11, 44);
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
            this.calInicio.MonthCalendar.DisplayMonth = new System.DateTime(2010, 11, 1, 0, 0, 0, 0);
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
            this.calInicio.Size = new System.Drawing.Size(96, 20);
            this.calInicio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.calInicio.TabIndex = 74;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotGridControl1.DataMember = "pltListadoCientifica";
            this.pivotGridControl1.DataSource = this.dsPlantillas1;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldcodasesoriacientifica,
            this.fieldnombreestadoasesoriacientifica,
            this.fieldprioridadsugerida,
            this.fieldprioridad,
            this.fieldfechasolicitud,
            this.fieldusuariocreacion,
            this.fieldnombreCliente,
            this.fieldnombreSucursal,
            this.fieldnombreCiudad,
            this.fieldfechaRespuestaInicial,
            this.fieldnombrereferenciareactivo,
            this.fieldfabricantereactivo,
            this.fieldresponsable,
            this.fieldnombreFabricante,
            this.fieldNombreModelo,
            this.fieldserial,
            this.fieldfechavisita,
            this.fieldfechacierre,
            this.fieldsolucionado,
            this.fieldconforme,
            this.fieldcerradapor,
            this.fieldnombreinconveniente,
            this.fieldvencimientoreactivo,
            this.fieldllamadarecibidadisponibilidad,
            this.fieldmotivoanulacion,
            this.fieldfechasugerida,
            this.fieldfechaprimerseguimiento,
            this.fieldA,
            this.fieldB,
            this.fieldC,
            this.fieldD,
            this.fieldE,
            this.fieldF,
            this.fieldG,
            this.fieldH,
            this.fieldI,
            this.fieldJ});
            this.pivotGridControl1.Location = new System.Drawing.Point(11, 91);
            this.pivotGridControl1.LookAndFeel.SkinName = "Blue";
            this.pivotGridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(424, 418);
            this.pivotGridControl1.TabIndex = 84;
            // 
            // fieldcodasesoriacientifica
            // 
            this.fieldcodasesoriacientifica.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldcodasesoriacientifica.AreaIndex = 0;
            this.fieldcodasesoriacientifica.Caption = "Cantidad";
            this.fieldcodasesoriacientifica.FieldName = "cod_asesoria_cientifica";
            this.fieldcodasesoriacientifica.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldcodasesoriacientifica.GrandTotalText = "Ordenes";
            this.fieldcodasesoriacientifica.Name = "fieldcodasesoriacientifica";
            this.fieldcodasesoriacientifica.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
            // 
            // fieldnombreestadoasesoriacientifica
            // 
            this.fieldnombreestadoasesoriacientifica.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldnombreestadoasesoriacientifica.AreaIndex = 0;
            this.fieldnombreestadoasesoriacientifica.Caption = "Estado";
            this.fieldnombreestadoasesoriacientifica.FieldName = "nombre_estado_asesoria_cientifica";
            this.fieldnombreestadoasesoriacientifica.Name = "fieldnombreestadoasesoriacientifica";
            // 
            // fieldprioridadsugerida
            // 
            this.fieldprioridadsugerida.AreaIndex = 1;
            this.fieldprioridadsugerida.Caption = "Prioridad sugerida";
            this.fieldprioridadsugerida.FieldName = "prioridad_sugerida";
            this.fieldprioridadsugerida.Name = "fieldprioridadsugerida";
            // 
            // fieldprioridad
            // 
            this.fieldprioridad.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldprioridad.AreaIndex = 0;
            this.fieldprioridad.Caption = "prioridad";
            this.fieldprioridad.FieldName = "prioridad";
            this.fieldprioridad.Name = "fieldprioridad";
            // 
            // fieldfechasolicitud
            // 
            this.fieldfechasolicitud.AreaIndex = 18;
            this.fieldfechasolicitud.Caption = "fecha_solicitud";
            this.fieldfechasolicitud.FieldName = "fecha_solicitud";
            this.fieldfechasolicitud.Name = "fieldfechasolicitud";
            // 
            // fieldusuariocreacion
            // 
            this.fieldusuariocreacion.AreaIndex = 0;
            this.fieldusuariocreacion.Caption = "Creacion por";
            this.fieldusuariocreacion.FieldName = "usuario_creacion";
            this.fieldusuariocreacion.Name = "fieldusuariocreacion";
            // 
            // fieldnombreCliente
            // 
            this.fieldnombreCliente.AreaIndex = 2;
            this.fieldnombreCliente.Caption = "Cliente";
            this.fieldnombreCliente.FieldName = "nombreCliente";
            this.fieldnombreCliente.Name = "fieldnombreCliente";
            // 
            // fieldnombreSucursal
            // 
            this.fieldnombreSucursal.AreaIndex = 3;
            this.fieldnombreSucursal.Caption = "Sucursal";
            this.fieldnombreSucursal.FieldName = "nombreSucursal";
            this.fieldnombreSucursal.Name = "fieldnombreSucursal";
            // 
            // fieldnombreCiudad
            // 
            this.fieldnombreCiudad.AreaIndex = 4;
            this.fieldnombreCiudad.Caption = "Ciudad";
            this.fieldnombreCiudad.FieldName = "nombreCiudad";
            this.fieldnombreCiudad.Name = "fieldnombreCiudad";
            // 
            // fieldfechaRespuestaInicial
            // 
            this.fieldfechaRespuestaInicial.AreaIndex = 7;
            this.fieldfechaRespuestaInicial.Caption = "fecha Respuesta Inicial";
            this.fieldfechaRespuestaInicial.FieldName = "fechaRespuestaInicial";
            this.fieldfechaRespuestaInicial.Name = "fieldfechaRespuestaInicial";
            // 
            // fieldnombrereferenciareactivo
            // 
            this.fieldnombrereferenciareactivo.AreaIndex = 8;
            this.fieldnombrereferenciareactivo.Caption = "Reactivo";
            this.fieldnombrereferenciareactivo.FieldName = "nombre_referencia_reactivo";
            this.fieldnombrereferenciareactivo.Name = "fieldnombrereferenciareactivo";
            // 
            // fieldfabricantereactivo
            // 
            this.fieldfabricantereactivo.AreaIndex = 9;
            this.fieldfabricantereactivo.Caption = "fabricante reactivo";
            this.fieldfabricantereactivo.FieldName = "fabricante_reactivo";
            this.fieldfabricantereactivo.Name = "fieldfabricantereactivo";
            // 
            // fieldresponsable
            // 
            this.fieldresponsable.AreaIndex = 5;
            this.fieldresponsable.Caption = "responsable";
            this.fieldresponsable.FieldName = "responsable";
            this.fieldresponsable.Name = "fieldresponsable";
            // 
            // fieldnombreFabricante
            // 
            this.fieldnombreFabricante.AreaIndex = 10;
            this.fieldnombreFabricante.Caption = "nombre Fabricante";
            this.fieldnombreFabricante.FieldName = "nombreFabricante";
            this.fieldnombreFabricante.Name = "fieldnombreFabricante";
            // 
            // fieldNombreModelo
            // 
            this.fieldNombreModelo.AreaIndex = 11;
            this.fieldNombreModelo.Caption = "Nombre Modelo";
            this.fieldNombreModelo.FieldName = "NombreModelo";
            this.fieldNombreModelo.Name = "fieldNombreModelo";
            // 
            // fieldserial
            // 
            this.fieldserial.AreaIndex = 12;
            this.fieldserial.Caption = "serial";
            this.fieldserial.FieldName = "serial";
            this.fieldserial.Name = "fieldserial";
            // 
            // fieldfechavisita
            // 
            this.fieldfechavisita.AreaIndex = 21;
            this.fieldfechavisita.Caption = "fecha_visita";
            this.fieldfechavisita.FieldName = "fecha_visita";
            this.fieldfechavisita.Name = "fieldfechavisita";
            // 
            // fieldfechacierre
            // 
            this.fieldfechacierre.AreaIndex = 22;
            this.fieldfechacierre.Caption = "fecha_cierre";
            this.fieldfechacierre.FieldName = "fecha_cierre";
            this.fieldfechacierre.Name = "fieldfechacierre";
            // 
            // fieldsolucionado
            // 
            this.fieldsolucionado.AreaIndex = 13;
            this.fieldsolucionado.Caption = "solucionado";
            this.fieldsolucionado.FieldName = "solucionado";
            this.fieldsolucionado.Name = "fieldsolucionado";
            // 
            // fieldconforme
            // 
            this.fieldconforme.AreaIndex = 14;
            this.fieldconforme.Caption = "conforme";
            this.fieldconforme.FieldName = "conforme";
            this.fieldconforme.Name = "fieldconforme";
            // 
            // fieldcerradapor
            // 
            this.fieldcerradapor.AreaIndex = 6;
            this.fieldcerradapor.Caption = "Cerrada por";
            this.fieldcerradapor.FieldName = "cerrada_por";
            this.fieldcerradapor.Name = "fieldcerradapor";
            // 
            // fieldnombreinconveniente
            // 
            this.fieldnombreinconveniente.AreaIndex = 33;
            this.fieldnombreinconveniente.Caption = "nombre_inconveniente";
            this.fieldnombreinconveniente.FieldName = "nombre_inconveniente";
            this.fieldnombreinconveniente.Name = "fieldnombreinconveniente";
            // 
            // fieldvencimientoreactivo
            // 
            this.fieldvencimientoreactivo.AreaIndex = 15;
            this.fieldvencimientoreactivo.Caption = "vencimiento_reactivo";
            this.fieldvencimientoreactivo.FieldName = "vencimiento_reactivo";
            this.fieldvencimientoreactivo.Name = "fieldvencimientoreactivo";
            // 
            // fieldllamadarecibidadisponibilidad
            // 
            this.fieldllamadarecibidadisponibilidad.AreaIndex = 16;
            this.fieldllamadarecibidadisponibilidad.Caption = "disponibilidad";
            this.fieldllamadarecibidadisponibilidad.FieldName = "llamada_recibida_disponibilidad";
            this.fieldllamadarecibidadisponibilidad.Name = "fieldllamadarecibidadisponibilidad";
            // 
            // fieldmotivoanulacion
            // 
            this.fieldmotivoanulacion.AreaIndex = 17;
            this.fieldmotivoanulacion.Caption = "motivo_anulacion";
            this.fieldmotivoanulacion.FieldName = "motivo_anulacion";
            this.fieldmotivoanulacion.Name = "fieldmotivoanulacion";
            // 
            // fieldfechasugerida
            // 
            this.fieldfechasugerida.AreaIndex = 19;
            this.fieldfechasugerida.Caption = "fecha_sugerida";
            this.fieldfechasugerida.FieldName = "fecha_sugerida";
            this.fieldfechasugerida.Name = "fieldfechasugerida";
            // 
            // fieldfechaprimerseguimiento
            // 
            this.fieldfechaprimerseguimiento.AreaIndex = 20;
            this.fieldfechaprimerseguimiento.Caption = "fecha_primer_seguimiento";
            this.fieldfechaprimerseguimiento.FieldName = "fecha_primer_seguimiento";
            this.fieldfechaprimerseguimiento.Name = "fieldfechaprimerseguimiento";
            // 
            // fieldA
            // 
            this.fieldA.AreaIndex = 23;
            this.fieldA.Caption = "A";
            this.fieldA.FieldName = "A";
            this.fieldA.Name = "fieldA";
            // 
            // fieldB
            // 
            this.fieldB.AreaIndex = 24;
            this.fieldB.Caption = "B";
            this.fieldB.FieldName = "B";
            this.fieldB.Name = "fieldB";
            // 
            // fieldC
            // 
            this.fieldC.AreaIndex = 25;
            this.fieldC.Caption = "C";
            this.fieldC.FieldName = "C";
            this.fieldC.Name = "fieldC";
            // 
            // fieldD
            // 
            this.fieldD.AreaIndex = 26;
            this.fieldD.Caption = "D";
            this.fieldD.FieldName = "D";
            this.fieldD.Name = "fieldD";
            // 
            // fieldE
            // 
            this.fieldE.AreaIndex = 27;
            this.fieldE.Caption = "E";
            this.fieldE.FieldName = "E";
            this.fieldE.Name = "fieldE";
            // 
            // fieldF
            // 
            this.fieldF.AreaIndex = 28;
            this.fieldF.Caption = "F";
            this.fieldF.FieldName = "F";
            this.fieldF.Name = "fieldF";
            // 
            // fieldG
            // 
            this.fieldG.AreaIndex = 29;
            this.fieldG.Caption = "G";
            this.fieldG.FieldName = "G";
            this.fieldG.Name = "fieldG";
            // 
            // fieldH
            // 
            this.fieldH.AreaIndex = 30;
            this.fieldH.Caption = "H";
            this.fieldH.FieldName = "H";
            this.fieldH.Name = "fieldH";
            // 
            // fieldI
            // 
            this.fieldI.AreaIndex = 31;
            this.fieldI.Caption = "I";
            this.fieldI.FieldName = "I";
            this.fieldI.Name = "fieldI";
            // 
            // fieldJ
            // 
            this.fieldJ.AreaIndex = 32;
            this.fieldJ.Caption = "J";
            this.fieldJ.FieldName = "J";
            this.fieldJ.Name = "fieldJ";
            // 
            // btnExcel
            // 
            this.btnExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnExcel.Location = new System.Drawing.Point(399, 62);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(36, 23);
            this.btnExcel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExcel.TabIndex = 85;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControl1.AppearanceName = "Chameleon";
            this.chartControl1.DataSource = this.pivotGridControl1;
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Location = new System.Drawing.Point(441, 73);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesDataMember = "Series";
            sideBySideBarSeriesLabel1.LineVisible = true;
            series1.Label = sideBySideBarSeriesLabel1;
            series1.Name = "Series 1";
            sideBySideBarSeriesLabel2.LineVisible = true;
            series2.Label = sideBySideBarSeriesLabel2;
            series2.Name = "Series 2";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "Arguments";
            this.chartControl1.SeriesTemplate.Label = stackedBarSeriesLabel1;
            this.chartControl1.SeriesTemplate.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending;
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values";
            this.chartControl1.SeriesTemplate.View = stackedBarSeriesView1;
            this.chartControl1.Size = new System.Drawing.Size(533, 441);
            this.chartControl1.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 87;
            this.label2.Text = "Tipo Grafico";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bar",
            "Bar Stacked 100%",
            "Bar 3d",
            "Point",
            "Lineas",
            "Lineas 3d",
            "Pie",
            "Dona",
            "Pie 3d"});
            this.comboBox1.Location = new System.Drawing.Point(851, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 88;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnACtualizarGRafico
            // 
            this.btnACtualizarGRafico.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnACtualizarGRafico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnACtualizarGRafico.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnACtualizarGRafico.Image = ((System.Drawing.Image)(resources.GetObject("btnACtualizarGRafico.Image")));
            this.btnACtualizarGRafico.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnACtualizarGRafico.Location = new System.Drawing.Point(936, 15);
            this.btnACtualizarGRafico.Name = "btnACtualizarGRafico";
            this.btnACtualizarGRafico.Size = new System.Drawing.Size(36, 23);
            this.btnACtualizarGRafico.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnACtualizarGRafico.TabIndex = 89;
            // 
            // btnInfoFechas
            // 
            this.btnInfoFechas.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInfoFechas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfoFechas.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnInfoFechas.Image = ((System.Drawing.Image)(resources.GetObject("btnInfoFechas.Image")));
            this.btnInfoFechas.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnInfoFechas.Location = new System.Drawing.Point(357, 62);
            this.btnInfoFechas.Name = "btnInfoFechas";
            this.btnInfoFechas.Size = new System.Drawing.Size(36, 23);
            this.btnInfoFechas.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnInfoFechas.TabIndex = 90;
            this.btnInfoFechas.Click += new System.EventHandler(this.btnInfoFechas_Click);
            // 
            // fieldlotereactivo
            // 
            this.fieldlotereactivo.AreaIndex = 18;
            this.fieldlotereactivo.Caption = "lote_reactivo";
            this.fieldlotereactivo.FieldName = "lote_reactivo";
            this.fieldlotereactivo.Name = "fieldlotereactivo";
            // 
            // fieldnumeroreporteqc
            // 
            this.fieldnumeroreporteqc.AreaIndex = 14;
            this.fieldnumeroreporteqc.Caption = "numero_reporte_qc";
            this.fieldnumeroreporteqc.FieldName = "numero_reporte_qc";
            this.fieldnumeroreporteqc.Name = "fieldnumeroreporteqc";
            // 
            // fieldmotivoconsulta
            // 
            this.fieldmotivoconsulta.AreaIndex = 10;
            this.fieldmotivoconsulta.Caption = "motivo consulta";
            this.fieldmotivoconsulta.FieldName = "motivo_consulta";
            this.fieldmotivoconsulta.Name = "fieldmotivoconsulta";
            // 
            // btnUno
            // 
            this.btnUno.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUno.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUno.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnUno.Location = new System.Drawing.Point(11, 66);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(36, 23);
            this.btnUno.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUno.TabIndex = 91;
            this.btnUno.Text = "1";
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnDos
            // 
            this.btnDos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDos.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDos.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnDos.Location = new System.Drawing.Point(53, 66);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(36, 23);
            this.btnDos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDos.TabIndex = 92;
            this.btnDos.Text = "2";
            this.btnDos.Click += new System.EventHandler(this.btnDos_Click);
            // 
            // btn3
            // 
            this.btn3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn3.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btn3.Location = new System.Drawing.Point(95, 66);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(36, 23);
            this.btn3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn3.TabIndex = 93;
            this.btn3.Text = "3";
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn4.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btn4.Location = new System.Drawing.Point(137, 66);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(36, 23);
            this.btn4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn4.TabIndex = 94;
            this.btn4.Text = "4";
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn5.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btn5.Location = new System.Drawing.Point(179, 66);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(36, 23);
            this.btn5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn5.TabIndex = 95;
            this.btn5.Text = "5";
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // frmEstadisticasCientificas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 521);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.btnInfoFechas);
            this.Controls.Add(this.btnACtualizarGRafico);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.calFin);
            this.Controls.Add(this.calInicio);
            this.Name = "frmEstadisticasCientificas";
            this.Text = "Estadisticas Cientifica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEstadisticasCientificas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SPControladoraDatos.dsPlantillas dsPlantillas1;
        private SPControladoraDatos.dsPlantillasTableAdapters.pltListadoCientificaTableAdapter pltListadoCientificaTableAdapter1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private DevComponents.DotNetBar.ButtonX btnBuscar;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFin;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calInicio;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevComponents.DotNetBar.ButtonX btnExcel;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevComponents.DotNetBar.ButtonX btnACtualizarGRafico;
        private DevComponents.DotNetBar.ButtonX btnInfoFechas;
        private DevExpress.XtraPivotGrid.PivotGridField fieldcodasesoriacientifica;
        private DevExpress.XtraPivotGrid.PivotGridField fieldnombreestadoasesoriacientifica;
        private DevExpress.XtraPivotGrid.PivotGridField fieldprioridadsugerida;
        private DevExpress.XtraPivotGrid.PivotGridField fieldprioridad;
        private DevExpress.XtraPivotGrid.PivotGridField fieldfechasolicitud;
        private DevExpress.XtraPivotGrid.PivotGridField fieldusuariocreacion;
        private DevExpress.XtraPivotGrid.PivotGridField fieldnombreCliente;
        private DevExpress.XtraPivotGrid.PivotGridField fieldnombreSucursal;
        private DevExpress.XtraPivotGrid.PivotGridField fieldnombreCiudad;
        private DevExpress.XtraPivotGrid.PivotGridField fieldfechaRespuestaInicial;
        private DevExpress.XtraPivotGrid.PivotGridField fieldnombrereferenciareactivo;
        private DevExpress.XtraPivotGrid.PivotGridField fieldfabricantereactivo;
        private DevExpress.XtraPivotGrid.PivotGridField fieldresponsable;
        private DevExpress.XtraPivotGrid.PivotGridField fieldnombreFabricante;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNombreModelo;
        private DevExpress.XtraPivotGrid.PivotGridField fieldserial;
        private DevExpress.XtraPivotGrid.PivotGridField fieldfechavisita;
        private DevExpress.XtraPivotGrid.PivotGridField fieldfechacierre;
        private DevExpress.XtraPivotGrid.PivotGridField fieldsolucionado;
        private DevExpress.XtraPivotGrid.PivotGridField fieldconforme;
        private DevExpress.XtraPivotGrid.PivotGridField fieldcerradapor;
        private DevExpress.XtraPivotGrid.PivotGridField fieldnombreinconveniente;
        private DevExpress.XtraPivotGrid.PivotGridField fieldvencimientoreactivo;
        private DevExpress.XtraPivotGrid.PivotGridField fieldllamadarecibidadisponibilidad;
        private DevExpress.XtraPivotGrid.PivotGridField fieldmotivoanulacion;
        private DevExpress.XtraPivotGrid.PivotGridField fieldfechasugerida;
        private DevExpress.XtraPivotGrid.PivotGridField fieldfechaprimerseguimiento;
        private DevExpress.XtraPivotGrid.PivotGridField fieldA;
        private DevExpress.XtraPivotGrid.PivotGridField fieldB;
        private DevExpress.XtraPivotGrid.PivotGridField fieldC;
        private DevExpress.XtraPivotGrid.PivotGridField fieldD;
        private DevExpress.XtraPivotGrid.PivotGridField fieldE;
        private DevExpress.XtraPivotGrid.PivotGridField fieldF;
        private DevExpress.XtraPivotGrid.PivotGridField fieldG;
        private DevExpress.XtraPivotGrid.PivotGridField fieldH;
        private DevExpress.XtraPivotGrid.PivotGridField fieldI;
        private DevExpress.XtraPivotGrid.PivotGridField fieldJ;
        private DevExpress.XtraPivotGrid.PivotGridField fieldlotereactivo;
        private DevExpress.XtraPivotGrid.PivotGridField fieldnumeroreporteqc;
        private DevExpress.XtraPivotGrid.PivotGridField fieldmotivoconsulta;
        private DevComponents.DotNetBar.ButtonX btnUno;
        private DevComponents.DotNetBar.ButtonX btnDos;
        private DevComponents.DotNetBar.ButtonX btn3;
        private DevComponents.DotNetBar.ButtonX btn4;
        private DevComponents.DotNetBar.ButtonX btn5;
    }
}