namespace spProcesos.contratos_consumo
{
    partial class contratosConsumo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(contratosConsumo));
            this.calFinContrato = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.calInicioContrato = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblOtroSi = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerarOtroSi = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtOtroSi = new System.Windows.Forms.TextBox();
            this.grpOtroSi = new System.Windows.Forms.GroupBox();
            this.calOtroSi = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroContrato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAsesor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.chkLegalizado = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbModalidad = new System.Windows.Forms.ComboBox();
            this.dsContratoConsumo1 = new SPControladoraDatos.dsContratoConsumo();
            this.cmbSubModalidad = new System.Windows.Forms.ComboBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtBusquedaCliente1 = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.txtBusqueda();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.modalidad_contratoTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.modalidad_contratoTableAdapter();
            this.sub_modalidad_contratoTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.sub_modalidad_contratoTableAdapter();
            this.equiposxcontrato_consumoTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.equiposxcontrato_consumoTableAdapter();
            this.contrato_consumoTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.contrato_consumoTableAdapter();
            this.archivoxcontrato_consumoTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.archivoxcontrato_consumoTableAdapter();
            this.grdEquipos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.grdConsumo = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grpRelaciones = new System.Windows.Forms.GroupBox();
            this.btnImportarConsumo = new DevComponents.DotNetBar.ButtonX();
            this.txtConsumoTotal = new System.Windows.Forms.TextBox();
            this.btnImportarEquipos = new DevComponents.DotNetBar.ButtonX();
            this.btnEliminarContratoConsumo = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregarConsumo = new DevComponents.DotNetBar.ButtonX();
            this.btnEditarContratoConsumo = new DevComponents.DotNetBar.ButtonX();
            this.btnEliminarEquipo = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregarEquipo = new DevComponents.DotNetBar.ButtonX();
            this.btnEditarEquipo = new DevComponents.DotNetBar.ButtonX();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbRazonVigencia = new System.Windows.Forms.ComboBox();
            this.txtNumeroContratoVinculado = new System.Windows.Forms.TextBox();
            this.chkProrogaAutomatica = new System.Windows.Forms.CheckBox();
            this.grpSoftwareAsociado = new System.Windows.Forms.GroupBox();
            this.btnImportarContrato = new DevComponents.DotNetBar.ButtonX();
            this.btnEliminarSoftware = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregarSoftware = new DevComponents.DotNetBar.ButtonX();
            this.btnEditarSoftware = new DevComponents.DotNetBar.ButtonX();
            this.grdTipoSoftware = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.cmbVigencia = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbSubModalidadVinculado = new System.Windows.Forms.ComboBox();
            this.dsContratoConsumo2 = new SPControladoraDatos.dsContratoConsumo();
            this.grpConsumibles = new System.Windows.Forms.GroupBox();
            this.btnExportarConsumiibles = new DevComponents.DotNetBar.ButtonX();
            this.btnImportarConsumiblesContrato = new DevComponents.DotNetBar.ButtonX();
            this.btnEliminarConsumible = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregarConsumible = new DevComponents.DotNetBar.ButtonX();
            this.btnEditarConsumible = new DevComponents.DotNetBar.ButtonX();
            this.grdConsumibles = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.grpIncrementos = new System.Windows.Forms.GroupBox();
            this.btnImportarIncrementosxLineaConsumo = new DevComponents.DotNetBar.ButtonX();
            this.btnEliminarIncremento = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregarIncremento = new DevComponents.DotNetBar.ButtonX();
            this.btnEditarIncremento = new DevComponents.DotNetBar.ButtonX();
            this.grdIncrementosPorLinea = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbModalidadVinculado = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel3 = new DevComponents.DotNetBar.TabControlPanel();
            this.btnAbrirArchivo = new DevComponents.DotNetBar.ButtonX();
            this.btnDescargarArchivo = new DevComponents.DotNetBar.ButtonX();
            this.btnQuitarArchivo = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregarArchivo = new DevComponents.DotNetBar.ButtonX();
            this.grdArchivos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.tabItem3 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel4 = new DevComponents.DotNetBar.TabControlPanel();
            this.btnRecaclcular = new System.Windows.Forms.Button();
            this.controladorColumnas1 = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas();
            this.grdcambios = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.tabItem4 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.btnVerDetalleHistorico = new DevComponents.DotNetBar.ButtonX();
            this.grdHistorico = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsContratoHistorico = new SPControladoraDatos.dsContratoConsumo();
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.linea_consumoxcontrato_consumoTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.linea_consumoxcontrato_consumoTableAdapter();
            this.pltConsumoxContratoTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.pltConsumoxContratoTableAdapter();
            this.pltEquiposxContratoTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.pltEquiposxContratoTableAdapter();
            this.pltContratoConsumoTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.pltContratoConsumoTableAdapter();
            this.vigencias_contrato_consumoTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.vigencias_contrato_consumoTableAdapter();
            this.tipo_software_contrato_consumoTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.tipo_software_contrato_consumoTableAdapter();
            this.consumiblesTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.consumiblesTableAdapter();
            this.pltIncrementosLineaConsumoxContratoTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.pltIncrementosLineaConsumoxContratoTableAdapter();
            this.pltConsumibleTableAdapter1 = new SPControladoraDatos.dsCientificaTableAdapters.pltConsumibleTableAdapter();
            this.incrementosxlinea_consumoTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.incrementosxlinea_consumoTableAdapter();
            this.consumiblexcontrato_consumoTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.consumiblexcontrato_consumoTableAdapter();
            this.vigencias_contrato_consumoTableAdapter2 = new SPControladoraDatos.dsContratoConsumoTableAdapters.vigencias_contrato_consumoTableAdapter();
            this.pltConsumiblexContratoConsumoTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.pltConsumiblexContratoConsumoTableAdapter();
            this.razon_no_vigenteTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.razon_no_vigenteTableAdapter();
            this.pltTipoSoftwarexContratoTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.pltTipoSoftwarexContratoTableAdapter();
            this.tipo_softwarexcontrato_consumoTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.tipo_softwarexcontrato_consumoTableAdapter();
            this.log_cambio_contratos_consumoTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.log_cambio_contratos_consumoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.calFinContrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calInicioContrato)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpOtroSi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calOtroSi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContratoConsumo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEquipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsumo)).BeginInit();
            this.grpRelaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.grpSoftwareAsociado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoSoftware)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContratoConsumo2)).BeginInit();
            this.grpConsumibles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsumibles)).BeginInit();
            this.grpIncrementos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdIncrementosPorLinea)).BeginInit();
            this.tabControlPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdArchivos)).BeginInit();
            this.tabControlPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdcambios)).BeginInit();
            this.tabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHistorico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContratoHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // calFinContrato
            // 
            // 
            // 
            // 
            this.calFinContrato.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calFinContrato.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinContrato.ButtonDropDown.Visible = true;
            this.calFinContrato.Location = new System.Drawing.Point(428, 179);
            // 
            // 
            // 
            this.calFinContrato.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFinContrato.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calFinContrato.MonthCalendar.BackgroundStyle.Class = "";
            this.calFinContrato.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinContrato.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calFinContrato.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calFinContrato.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calFinContrato.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calFinContrato.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calFinContrato.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calFinContrato.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calFinContrato.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calFinContrato.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinContrato.MonthCalendar.DisplayMonth = new System.DateTime(2008, 4, 1, 0, 0, 0, 0);
            this.calFinContrato.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calFinContrato.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calFinContrato.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFinContrato.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calFinContrato.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calFinContrato.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calFinContrato.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calFinContrato.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinContrato.MonthCalendar.TodayButtonVisible = true;
            this.calFinContrato.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calFinContrato.Name = "calFinContrato";
            this.calFinContrato.Size = new System.Drawing.Size(129, 20);
            this.calFinContrato.TabIndex = 7;
            // 
            // calInicioContrato
            // 
            // 
            // 
            // 
            this.calInicioContrato.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calInicioContrato.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioContrato.ButtonDropDown.Visible = true;
            this.calInicioContrato.Location = new System.Drawing.Point(128, 179);
            // 
            // 
            // 
            this.calInicioContrato.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calInicioContrato.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calInicioContrato.MonthCalendar.BackgroundStyle.Class = "";
            this.calInicioContrato.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioContrato.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calInicioContrato.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calInicioContrato.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calInicioContrato.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calInicioContrato.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calInicioContrato.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calInicioContrato.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calInicioContrato.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calInicioContrato.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioContrato.MonthCalendar.DisplayMonth = new System.DateTime(2008, 4, 1, 0, 0, 0, 0);
            this.calInicioContrato.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calInicioContrato.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calInicioContrato.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calInicioContrato.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calInicioContrato.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calInicioContrato.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calInicioContrato.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calInicioContrato.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioContrato.MonthCalendar.TodayButtonVisible = true;
            this.calInicioContrato.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calInicioContrato.Name = "calInicioContrato";
            this.calInicioContrato.Size = new System.Drawing.Size(129, 20);
            this.calInicioContrato.TabIndex = 6;
            // 
            // lblOtroSi
            // 
            this.lblOtroSi.AutoSize = true;
            this.lblOtroSi.BackColor = System.Drawing.Color.Transparent;
            this.lblOtroSi.Location = new System.Drawing.Point(116, 15);
            this.lblOtroSi.Name = "lblOtroSi";
            this.lblOtroSi.Size = new System.Drawing.Size(79, 13);
            this.lblOtroSi.TabIndex = 33;
            this.lblOtroSi.Text = "Otro Si Numero";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(9, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "Observaciones:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnGenerarOtroSi);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 632);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 51);
            this.panel1.TabIndex = 0;
            // 
            // btnGenerarOtroSi
            // 
            this.btnGenerarOtroSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarOtroSi.Location = new System.Drawing.Point(19, 16);
            this.btnGenerarOtroSi.Name = "btnGenerarOtroSi";
            this.btnGenerarOtroSi.Size = new System.Drawing.Size(139, 23);
            this.btnGenerarOtroSi.TabIndex = 2;
            this.btnGenerarOtroSi.Text = "Generar Otro Si";
            this.btnGenerarOtroSi.UseVisualStyleBackColor = true;
            this.btnGenerarOtroSi.Visible = false;
            this.btnGenerarOtroSi.Click += new System.EventHandler(this.btnGenerarOtroSi_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(919, 16);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(838, 16);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtOtroSi
            // 
            this.txtOtroSi.Location = new System.Drawing.Point(198, 11);
            this.txtOtroSi.Name = "txtOtroSi";
            this.txtOtroSi.Size = new System.Drawing.Size(100, 20);
            this.txtOtroSi.TabIndex = 64;
            // 
            // grpOtroSi
            // 
            this.grpOtroSi.BackColor = System.Drawing.Color.Transparent;
            this.grpOtroSi.Controls.Add(this.calOtroSi);
            this.grpOtroSi.Controls.Add(this.txtOtroSi);
            this.grpOtroSi.Controls.Add(this.lblOtroSi);
            this.grpOtroSi.Controls.Add(this.label1);
            this.grpOtroSi.Location = new System.Drawing.Point(12, -2);
            this.grpOtroSi.Name = "grpOtroSi";
            this.grpOtroSi.Size = new System.Drawing.Size(534, 37);
            this.grpOtroSi.TabIndex = 65;
            this.grpOtroSi.TabStop = false;
            this.grpOtroSi.Text = "Informacion Otro Si";
            this.grpOtroSi.Visible = false;
            // 
            // calOtroSi
            // 
            // 
            // 
            // 
            this.calOtroSi.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calOtroSi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calOtroSi.ButtonDropDown.Visible = true;
            this.calOtroSi.Enabled = false;
            this.calOtroSi.Location = new System.Drawing.Point(380, 12);
            // 
            // 
            // 
            this.calOtroSi.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calOtroSi.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calOtroSi.MonthCalendar.BackgroundStyle.Class = "";
            this.calOtroSi.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calOtroSi.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calOtroSi.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calOtroSi.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calOtroSi.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calOtroSi.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calOtroSi.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calOtroSi.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calOtroSi.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calOtroSi.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calOtroSi.MonthCalendar.DisplayMonth = new System.DateTime(2008, 4, 1, 0, 0, 0, 0);
            this.calOtroSi.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calOtroSi.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calOtroSi.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calOtroSi.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calOtroSi.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calOtroSi.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calOtroSi.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calOtroSi.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calOtroSi.MonthCalendar.TodayButtonVisible = true;
            this.calOtroSi.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calOtroSi.Name = "calOtroSi";
            this.calOtroSi.Size = new System.Drawing.Size(146, 20);
            this.calOtroSi.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(307, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 14);
            this.label1.TabIndex = 66;
            this.label1.Text = "Fecha otro si";
            // 
            // txtNumeroContrato
            // 
            this.txtNumeroContrato.Location = new System.Drawing.Point(128, 43);
            this.txtNumeroContrato.Name = "txtNumeroContrato";
            this.txtNumeroContrato.Size = new System.Drawing.Size(168, 20);
            this.txtNumeroContrato.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Numero de Contrato:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(9, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(311, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "Asesor:";
            // 
            // cmbAsesor
            // 
            this.cmbAsesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAsesor.FormattingEnabled = true;
            this.cmbAsesor.Location = new System.Drawing.Point(359, 44);
            this.cmbAsesor.Name = "cmbAsesor";
            this.cmbAsesor.Size = new System.Drawing.Size(130, 21);
            this.cmbAsesor.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(9, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 73;
            this.label6.Text = "Modalidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(281, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 13);
            this.label8.TabIndex = 72;
            this.label8.Text = "Fecha Finalizacion Contrato:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(9, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 71;
            this.label11.Text = "Fecha Inicio Contrato:";
            // 
            // chkLegalizado
            // 
            this.chkLegalizado.AutoSize = true;
            this.chkLegalizado.BackColor = System.Drawing.Color.Transparent;
            this.chkLegalizado.Location = new System.Drawing.Point(129, 209);
            this.chkLegalizado.Name = "chkLegalizado";
            this.chkLegalizado.Size = new System.Drawing.Size(120, 17);
            this.chkLegalizado.TabIndex = 8;
            this.chkLegalizado.Text = "Contrato Legalizado";
            this.chkLegalizado.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(9, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 75;
            this.label12.Text = "Sub Modalidad";
            // 
            // cmbModalidad
            // 
            this.cmbModalidad.DataSource = this.dsContratoConsumo1;
            this.cmbModalidad.DisplayMember = "modalidad_contrato.nombre_modalidad_contrato";
            this.cmbModalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModalidad.FormattingEnabled = true;
            this.cmbModalidad.Location = new System.Drawing.Point(127, 69);
            this.cmbModalidad.Name = "cmbModalidad";
            this.cmbModalidad.Size = new System.Drawing.Size(362, 21);
            this.cmbModalidad.TabIndex = 2;
            this.cmbModalidad.ValueMember = "modalidad_contrato.cod_modalidad_contrato";
            this.cmbModalidad.SelectedIndexChanged += new System.EventHandler(this.cmbModalidad_SelectedIndexChanged);
            // 
            // dsContratoConsumo1
            // 
            this.dsContratoConsumo1.DataSetName = "dsContratoConsumo";
            this.dsContratoConsumo1.EnforceConstraints = false;
            this.dsContratoConsumo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbSubModalidad
            // 
            this.cmbSubModalidad.DataSource = this.dsContratoConsumo1;
            this.cmbSubModalidad.DisplayMember = "sub_modalidad_contrato.nombresub_modalidad_contrato";
            this.cmbSubModalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubModalidad.FormattingEnabled = true;
            this.cmbSubModalidad.Location = new System.Drawing.Point(128, 94);
            this.cmbSubModalidad.Name = "cmbSubModalidad";
            this.cmbSubModalidad.Size = new System.Drawing.Size(361, 21);
            this.cmbSubModalidad.TabIndex = 3;
            this.cmbSubModalidad.ValueMember = "sub_modalidad_contrato.cod_sub_modalidad_contrato";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(129, 235);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(428, 47);
            this.txtObservaciones.TabIndex = 10;
            // 
            // txtBusquedaCliente1
            // 
            this.txtBusquedaCliente1.codigo = "nitCliente";
            this.txtBusquedaCliente1.DataMember = this.dsSpx1.clientes;
            this.txtBusquedaCliente1.DataSource = this.dsSpx1;
            this.txtBusquedaCliente1.descripcion1 = "numeroSocio";
            this.txtBusquedaCliente1.descripcion2 = "nombreCliente";
            this.txtBusquedaCliente1.filtroAdicional = null;
            this.txtBusquedaCliente1.LimiteY = 125;
            this.txtBusquedaCliente1.linkPadre = null;
            this.txtBusquedaCliente1.Location = new System.Drawing.Point(128, 124);
            this.txtBusquedaCliente1.Name = "txtBusquedaCliente1";
            this.txtBusquedaCliente1.sentenciaFromObligatoria = null;
            this.txtBusquedaCliente1.Size = new System.Drawing.Size(361, 20);
            this.txtBusquedaCliente1.TabIndex = 4;
            this.txtBusquedaCliente1.Tabla = this.dsSpx1.clientes;
            this.txtBusquedaCliente1.TamanoPopUp = 5;
            this.txtBusquedaCliente1.txtPadre = null;
            this.txtBusquedaCliente1.Value = "0";
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.EnforceConstraints = false;
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modalidad_contratoTableAdapter1
            // 
            this.modalidad_contratoTableAdapter1.ClearBeforeFill = true;
            // 
            // sub_modalidad_contratoTableAdapter1
            // 
            this.sub_modalidad_contratoTableAdapter1.ClearBeforeFill = true;
            // 
            // equiposxcontrato_consumoTableAdapter1
            // 
            this.equiposxcontrato_consumoTableAdapter1.ClearBeforeFill = true;
            // 
            // contrato_consumoTableAdapter1
            // 
            this.contrato_consumoTableAdapter1.ClearBeforeFill = true;
            // 
            // archivoxcontrato_consumoTableAdapter1
            // 
            this.archivoxcontrato_consumoTableAdapter1.ClearBeforeFill = true;
            // 
            // grdEquipos
            // 
            this.grdEquipos.AllowUpdate = false;
            this.grdEquipos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdEquipos.DataMember = "pltEquiposxContrato";
            this.grdEquipos.DataSource = this.dsContratoConsumo1;
            this.grdEquipos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdEquipos.Images"))));
            this.grdEquipos.Location = new System.Drawing.Point(351, 54);
            this.grdEquipos.Name = "grdEquipos";
            this.grdEquipos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdEquipos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdEquipos.PreviewInfo.ZoomFactor = 75D;
            this.grdEquipos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdEquipos.PrintInfo.PageSettings")));
            this.grdEquipos.Size = new System.Drawing.Size(620, 127);
            this.grdEquipos.TabIndex = 81;
            this.grdEquipos.Text = "c1TrueDBGrid1";
            this.grdEquipos.PropBag = resources.GetString("grdEquipos.PropBag");
            // 
            // grdConsumo
            // 
            this.grdConsumo.AllowUpdate = false;
            this.grdConsumo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grdConsumo.DataMember = "pltConsumoxContrato";
            this.grdConsumo.DataSource = this.dsContratoConsumo1;
            this.grdConsumo.Images.Add(((System.Drawing.Image)(resources.GetObject("grdConsumo.Images"))));
            this.grdConsumo.Location = new System.Drawing.Point(11, 54);
            this.grdConsumo.Name = "grdConsumo";
            this.grdConsumo.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdConsumo.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdConsumo.PreviewInfo.ZoomFactor = 75D;
            this.grdConsumo.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdConsumo.PrintInfo.PageSettings")));
            this.grdConsumo.Size = new System.Drawing.Size(334, 127);
            this.grdConsumo.TabIndex = 82;
            this.grdConsumo.Text = "c1TrueDBGrid2";
            this.grdConsumo.PropBag = resources.GetString("grdConsumo.PropBag");
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(354, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 21);
            this.label5.TabIndex = 83;
            this.label5.Text = "Equipos, Modelos o Software:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 21);
            this.label7.TabIndex = 84;
            this.label7.Text = "Consumo Requerido:";
            // 
            // grpRelaciones
            // 
            this.grpRelaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRelaciones.BackColor = System.Drawing.Color.White;
            this.grpRelaciones.Controls.Add(this.btnImportarConsumo);
            this.grpRelaciones.Controls.Add(this.txtConsumoTotal);
            this.grpRelaciones.Controls.Add(this.btnImportarEquipos);
            this.grpRelaciones.Controls.Add(this.btnEliminarContratoConsumo);
            this.grpRelaciones.Controls.Add(this.btnAgregarConsumo);
            this.grpRelaciones.Controls.Add(this.btnEditarContratoConsumo);
            this.grpRelaciones.Controls.Add(this.btnEliminarEquipo);
            this.grpRelaciones.Controls.Add(this.btnAgregarEquipo);
            this.grpRelaciones.Controls.Add(this.btnEditarEquipo);
            this.grpRelaciones.Controls.Add(this.grdConsumo);
            this.grpRelaciones.Controls.Add(this.label7);
            this.grpRelaciones.Controls.Add(this.grdEquipos);
            this.grpRelaciones.Controls.Add(this.label5);
            this.grpRelaciones.Location = new System.Drawing.Point(8, 410);
            this.grpRelaciones.Name = "grpRelaciones";
            this.grpRelaciones.Size = new System.Drawing.Size(985, 190);
            this.grpRelaciones.TabIndex = 85;
            this.grpRelaciones.TabStop = false;
            this.grpRelaciones.Visible = false;
            // 
            // btnImportarConsumo
            // 
            this.btnImportarConsumo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImportarConsumo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnImportarConsumo.Location = new System.Drawing.Point(134, 22);
            this.btnImportarConsumo.Name = "btnImportarConsumo";
            this.btnImportarConsumo.Size = new System.Drawing.Size(112, 23);
            this.btnImportarConsumo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnImportarConsumo.TabIndex = 111;
            this.btnImportarConsumo.Text = "Importar de contrato";
            this.btnImportarConsumo.Visible = false;
            this.btnImportarConsumo.Click += new System.EventHandler(this.btnImportarConsumo_Click);
            // 
            // txtConsumoTotal
            // 
            this.txtConsumoTotal.Location = new System.Drawing.Point(10, 28);
            this.txtConsumoTotal.Name = "txtConsumoTotal";
            this.txtConsumoTotal.ReadOnly = true;
            this.txtConsumoTotal.Size = new System.Drawing.Size(107, 20);
            this.txtConsumoTotal.TabIndex = 98;
            // 
            // btnImportarEquipos
            // 
            this.btnImportarEquipos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImportarEquipos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportarEquipos.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnImportarEquipos.Location = new System.Drawing.Point(760, 22);
            this.btnImportarEquipos.Name = "btnImportarEquipos";
            this.btnImportarEquipos.Size = new System.Drawing.Size(112, 23);
            this.btnImportarEquipos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnImportarEquipos.TabIndex = 110;
            this.btnImportarEquipos.Text = "Importar de contrato";
            this.btnImportarEquipos.Visible = false;
            this.btnImportarEquipos.Click += new System.EventHandler(this.btnImportarEquipos_Click);
            // 
            // btnEliminarContratoConsumo
            // 
            this.btnEliminarContratoConsumo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEliminarContratoConsumo.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarContratoConsumo.Image")));
            this.btnEliminarContratoConsumo.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnEliminarContratoConsumo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnEliminarContratoConsumo.Location = new System.Drawing.Point(317, 20);
            this.btnEliminarContratoConsumo.Name = "btnEliminarContratoConsumo";
            this.btnEliminarContratoConsumo.Size = new System.Drawing.Size(28, 28);
            this.btnEliminarContratoConsumo.TabIndex = 108;
            this.btnEliminarContratoConsumo.Click += new System.EventHandler(this.btnEliminarContratoConsumo_Click);
            // 
            // btnAgregarConsumo
            // 
            this.btnAgregarConsumo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregarConsumo.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarConsumo.Image")));
            this.btnAgregarConsumo.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnAgregarConsumo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAgregarConsumo.Location = new System.Drawing.Point(250, 20);
            this.btnAgregarConsumo.Name = "btnAgregarConsumo";
            this.btnAgregarConsumo.Size = new System.Drawing.Size(28, 28);
            this.btnAgregarConsumo.TabIndex = 107;
            this.btnAgregarConsumo.Click += new System.EventHandler(this.btnAgregarConsumo_Click);
            // 
            // btnEditarContratoConsumo
            // 
            this.btnEditarContratoConsumo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEditarContratoConsumo.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarContratoConsumo.Image")));
            this.btnEditarContratoConsumo.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnEditarContratoConsumo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnEditarContratoConsumo.Location = new System.Drawing.Point(284, 20);
            this.btnEditarContratoConsumo.Name = "btnEditarContratoConsumo";
            this.btnEditarContratoConsumo.Size = new System.Drawing.Size(28, 28);
            this.btnEditarContratoConsumo.TabIndex = 106;
            this.btnEditarContratoConsumo.Click += new System.EventHandler(this.btnEditarContratoConsumo_Click);
            // 
            // btnEliminarEquipo
            // 
            this.btnEliminarEquipo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEliminarEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarEquipo.Image")));
            this.btnEliminarEquipo.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnEliminarEquipo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnEliminarEquipo.Location = new System.Drawing.Point(943, 22);
            this.btnEliminarEquipo.Name = "btnEliminarEquipo";
            this.btnEliminarEquipo.Size = new System.Drawing.Size(28, 28);
            this.btnEliminarEquipo.TabIndex = 105;
            this.btnEliminarEquipo.Click += new System.EventHandler(this.btnEliminarEquipo_Click);
            // 
            // btnAgregarEquipo
            // 
            this.btnAgregarEquipo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregarEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarEquipo.Image")));
            this.btnAgregarEquipo.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnAgregarEquipo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAgregarEquipo.Location = new System.Drawing.Point(876, 22);
            this.btnAgregarEquipo.Name = "btnAgregarEquipo";
            this.btnAgregarEquipo.Size = new System.Drawing.Size(28, 28);
            this.btnAgregarEquipo.TabIndex = 101;
            this.btnAgregarEquipo.Click += new System.EventHandler(this.btnAgregarEquipo_Click);
            // 
            // btnEditarEquipo
            // 
            this.btnEditarEquipo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEditarEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarEquipo.Image")));
            this.btnEditarEquipo.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnEditarEquipo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnEditarEquipo.Location = new System.Drawing.Point(910, 22);
            this.btnEditarEquipo.Name = "btnEditarEquipo";
            this.btnEditarEquipo.Size = new System.Drawing.Size(28, 28);
            this.btnEditarEquipo.TabIndex = 100;
            this.btnEditarEquipo.Click += new System.EventHandler(this.btnEditarEquipo_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.BackColor = System.Drawing.Color.White;
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Controls.Add(this.tabControlPanel3);
            this.tabControl1.Controls.Add(this.tabControlPanel4);
            this.tabControl1.Controls.Add(this.tabControlPanel2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1005, 632);
            this.tabControl1.TabIndex = 86;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItem1);
            this.tabControl1.Tabs.Add(this.tabItem3);
            this.tabControl1.Tabs.Add(this.tabItem2);
            this.tabControl1.Tabs.Add(this.tabItem4);
            this.tabControl1.Text = "tabControl1";
            this.tabControl1.SelectedTabChanged += new DevComponents.DotNetBar.TabStrip.SelectedTabChangedEventHandler(this.tabControl1_SelectedTabChanged);
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.label16);
            this.tabControlPanel1.Controls.Add(this.cmbRazonVigencia);
            this.tabControlPanel1.Controls.Add(this.txtNumeroContratoVinculado);
            this.tabControlPanel1.Controls.Add(this.chkProrogaAutomatica);
            this.tabControlPanel1.Controls.Add(this.grpSoftwareAsociado);
            this.tabControlPanel1.Controls.Add(this.cmbVigencia);
            this.tabControlPanel1.Controls.Add(this.label10);
            this.tabControlPanel1.Controls.Add(this.cmbSubModalidadVinculado);
            this.tabControlPanel1.Controls.Add(this.grpConsumibles);
            this.tabControlPanel1.Controls.Add(this.grpIncrementos);
            this.tabControlPanel1.Controls.Add(this.label14);
            this.tabControlPanel1.Controls.Add(this.grpOtroSi);
            this.tabControlPanel1.Controls.Add(this.cmbModalidadVinculado);
            this.tabControlPanel1.Controls.Add(this.grpRelaciones);
            this.tabControlPanel1.Controls.Add(this.calInicioContrato);
            this.tabControlPanel1.Controls.Add(this.label15);
            this.tabControlPanel1.Controls.Add(this.txtBusquedaCliente1);
            this.tabControlPanel1.Controls.Add(this.label13);
            this.tabControlPanel1.Controls.Add(this.txtObservaciones);
            this.tabControlPanel1.Controls.Add(this.calFinContrato);
            this.tabControlPanel1.Controls.Add(this.label2);
            this.tabControlPanel1.Controls.Add(this.label9);
            this.tabControlPanel1.Controls.Add(this.txtNumeroContrato);
            this.tabControlPanel1.Controls.Add(this.cmbSubModalidad);
            this.tabControlPanel1.Controls.Add(this.label3);
            this.tabControlPanel1.Controls.Add(this.cmbModalidad);
            this.tabControlPanel1.Controls.Add(this.label4);
            this.tabControlPanel1.Controls.Add(this.label12);
            this.tabControlPanel1.Controls.Add(this.cmbAsesor);
            this.tabControlPanel1.Controls.Add(this.chkLegalizado);
            this.tabControlPanel1.Controls.Add(this.label11);
            this.tabControlPanel1.Controls.Add(this.label6);
            this.tabControlPanel1.Controls.Add(this.label8);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(1005, 606);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabItem1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(232, 153);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 98;
            this.label16.Text = "Razon:";
            // 
            // cmbRazonVigencia
            // 
            this.cmbRazonVigencia.DataSource = this.dsContratoConsumo1;
            this.cmbRazonVigencia.DisplayMember = "razon_no_vigente.nombre_razon_no_vigente";
            this.cmbRazonVigencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRazonVigencia.FormattingEnabled = true;
            this.cmbRazonVigencia.Location = new System.Drawing.Point(279, 150);
            this.cmbRazonVigencia.Name = "cmbRazonVigencia";
            this.cmbRazonVigencia.Size = new System.Drawing.Size(278, 21);
            this.cmbRazonVigencia.TabIndex = 97;
            this.cmbRazonVigencia.ValueMember = "razon_no_vigente.cod_razon_no_vigente";
            // 
            // txtNumeroContratoVinculado
            // 
            this.txtNumeroContratoVinculado.Location = new System.Drawing.Point(828, 13);
            this.txtNumeroContratoVinculado.Name = "txtNumeroContratoVinculado";
            this.txtNumeroContratoVinculado.Size = new System.Drawing.Size(166, 20);
            this.txtNumeroContratoVinculado.TabIndex = 11;
            // 
            // chkProrogaAutomatica
            // 
            this.chkProrogaAutomatica.AutoSize = true;
            this.chkProrogaAutomatica.BackColor = System.Drawing.Color.Transparent;
            this.chkProrogaAutomatica.Location = new System.Drawing.Point(294, 209);
            this.chkProrogaAutomatica.Name = "chkProrogaAutomatica";
            this.chkProrogaAutomatica.Size = new System.Drawing.Size(119, 17);
            this.chkProrogaAutomatica.TabIndex = 9;
            this.chkProrogaAutomatica.Text = "Proroga Automatica";
            this.chkProrogaAutomatica.UseVisualStyleBackColor = false;
            // 
            // grpSoftwareAsociado
            // 
            this.grpSoftwareAsociado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSoftwareAsociado.BackColor = System.Drawing.Color.White;
            this.grpSoftwareAsociado.Controls.Add(this.btnImportarContrato);
            this.grpSoftwareAsociado.Controls.Add(this.btnEliminarSoftware);
            this.grpSoftwareAsociado.Controls.Add(this.btnAgregarSoftware);
            this.grpSoftwareAsociado.Controls.Add(this.btnEditarSoftware);
            this.grpSoftwareAsociado.Controls.Add(this.grdTipoSoftware);
            this.grpSoftwareAsociado.Location = new System.Drawing.Point(633, 102);
            this.grpSoftwareAsociado.Name = "grpSoftwareAsociado";
            this.grpSoftwareAsociado.Size = new System.Drawing.Size(360, 124);
            this.grpSoftwareAsociado.TabIndex = 96;
            this.grpSoftwareAsociado.TabStop = false;
            this.grpSoftwareAsociado.Text = "Software Asociado";
            this.grpSoftwareAsociado.Visible = false;
            // 
            // btnImportarContrato
            // 
            this.btnImportarContrato.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImportarContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportarContrato.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnImportarContrato.Location = new System.Drawing.Point(143, 12);
            this.btnImportarContrato.Name = "btnImportarContrato";
            this.btnImportarContrato.Size = new System.Drawing.Size(112, 23);
            this.btnImportarContrato.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnImportarContrato.TabIndex = 115;
            this.btnImportarContrato.Text = "Importar de contrato";
            this.btnImportarContrato.Visible = false;
            this.btnImportarContrato.Click += new System.EventHandler(this.btnImportarContrato_Click);
            // 
            // btnEliminarSoftware
            // 
            this.btnEliminarSoftware.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEliminarSoftware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarSoftware.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarSoftware.Image")));
            this.btnEliminarSoftware.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnEliminarSoftware.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnEliminarSoftware.Location = new System.Drawing.Point(326, 10);
            this.btnEliminarSoftware.Name = "btnEliminarSoftware";
            this.btnEliminarSoftware.Size = new System.Drawing.Size(28, 28);
            this.btnEliminarSoftware.TabIndex = 114;
            this.btnEliminarSoftware.Click += new System.EventHandler(this.btnEliminarSoftware_Click);
            // 
            // btnAgregarSoftware
            // 
            this.btnAgregarSoftware.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregarSoftware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarSoftware.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarSoftware.Image")));
            this.btnAgregarSoftware.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnAgregarSoftware.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAgregarSoftware.Location = new System.Drawing.Point(259, 10);
            this.btnAgregarSoftware.Name = "btnAgregarSoftware";
            this.btnAgregarSoftware.Size = new System.Drawing.Size(28, 28);
            this.btnAgregarSoftware.TabIndex = 113;
            this.btnAgregarSoftware.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // btnEditarSoftware
            // 
            this.btnEditarSoftware.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEditarSoftware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarSoftware.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarSoftware.Image")));
            this.btnEditarSoftware.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnEditarSoftware.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnEditarSoftware.Location = new System.Drawing.Point(293, 10);
            this.btnEditarSoftware.Name = "btnEditarSoftware";
            this.btnEditarSoftware.Size = new System.Drawing.Size(28, 28);
            this.btnEditarSoftware.TabIndex = 112;
            this.btnEditarSoftware.Click += new System.EventHandler(this.btnEditarSoftware_Click);
            // 
            // grdTipoSoftware
            // 
            this.grdTipoSoftware.AllowUpdate = false;
            this.grdTipoSoftware.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTipoSoftware.DataMember = "pltTipoSoftwarexContrato";
            this.grdTipoSoftware.DataSource = this.dsContratoConsumo1;
            this.grdTipoSoftware.Images.Add(((System.Drawing.Image)(resources.GetObject("grdTipoSoftware.Images"))));
            this.grdTipoSoftware.Location = new System.Drawing.Point(10, 44);
            this.grdTipoSoftware.Name = "grdTipoSoftware";
            this.grdTipoSoftware.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdTipoSoftware.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdTipoSoftware.PreviewInfo.ZoomFactor = 75D;
            this.grdTipoSoftware.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdTipoSoftware.PrintInfo.PageSettings")));
            this.grdTipoSoftware.Size = new System.Drawing.Size(344, 72);
            this.grdTipoSoftware.TabIndex = 83;
            this.grdTipoSoftware.Text = "c1TrueDBGrid2";
            this.grdTipoSoftware.PropBag = resources.GetString("grdTipoSoftware.PropBag");
            // 
            // cmbVigencia
            // 
            this.cmbVigencia.DataSource = this.dsContratoConsumo1;
            this.cmbVigencia.DisplayMember = "vigencias_contrato_consumo.vigencias_contrato_consumo";
            this.cmbVigencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVigencia.FormattingEnabled = true;
            this.cmbVigencia.Location = new System.Drawing.Point(128, 150);
            this.cmbVigencia.Name = "cmbVigencia";
            this.cmbVigencia.Size = new System.Drawing.Size(98, 21);
            this.cmbVigencia.TabIndex = 1;
            this.cmbVigencia.ValueMember = "vigencias_contrato_consumo.cod_vigencias_contrato_consumo";
            this.cmbVigencia.SelectedIndexChanged += new System.EventHandler(this.cmbVigencia_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(9, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 88;
            this.label10.Text = "Vigencia:";
            // 
            // cmbSubModalidadVinculado
            // 
            this.cmbSubModalidadVinculado.DataSource = this.dsContratoConsumo2;
            this.cmbSubModalidadVinculado.DisplayMember = "sub_modalidad_contrato.nombresub_modalidad_contrato";
            this.cmbSubModalidadVinculado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubModalidadVinculado.FormattingEnabled = true;
            this.cmbSubModalidadVinculado.Location = new System.Drawing.Point(739, 68);
            this.cmbSubModalidadVinculado.Name = "cmbSubModalidadVinculado";
            this.cmbSubModalidadVinculado.Size = new System.Drawing.Size(254, 21);
            this.cmbSubModalidadVinculado.TabIndex = 13;
            this.cmbSubModalidadVinculado.ValueMember = "sub_modalidad_contrato.cod_sub_modalidad_contrato";
            // 
            // dsContratoConsumo2
            // 
            this.dsContratoConsumo2.DataSetName = "dsContratoConsumo";
            this.dsContratoConsumo2.EnforceConstraints = false;
            this.dsContratoConsumo2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpConsumibles
            // 
            this.grpConsumibles.BackColor = System.Drawing.Color.White;
            this.grpConsumibles.Controls.Add(this.btnExportarConsumiibles);
            this.grpConsumibles.Controls.Add(this.btnImportarConsumiblesContrato);
            this.grpConsumibles.Controls.Add(this.btnEliminarConsumible);
            this.grpConsumibles.Controls.Add(this.btnAgregarConsumible);
            this.grpConsumibles.Controls.Add(this.btnEditarConsumible);
            this.grpConsumibles.Controls.Add(this.grdConsumibles);
            this.grpConsumibles.Location = new System.Drawing.Point(8, 286);
            this.grpConsumibles.Name = "grpConsumibles";
            this.grpConsumibles.Size = new System.Drawing.Size(573, 120);
            this.grpConsumibles.TabIndex = 87;
            this.grpConsumibles.TabStop = false;
            this.grpConsumibles.Text = "Consumibles";
            this.grpConsumibles.Visible = false;
            // 
            // btnExportarConsumiibles
            // 
            this.btnExportarConsumiibles.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExportarConsumiibles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarConsumiibles.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExportarConsumiibles.Location = new System.Drawing.Point(236, 15);
            this.btnExportarConsumiibles.Name = "btnExportarConsumiibles";
            this.btnExportarConsumiibles.Size = new System.Drawing.Size(112, 23);
            this.btnExportarConsumiibles.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExportarConsumiibles.TabIndex = 116;
            this.btnExportarConsumiibles.Text = "Exportar Consumibles";
            this.btnExportarConsumiibles.Visible = false;
            this.btnExportarConsumiibles.Click += new System.EventHandler(this.btnExportarConsumiibles_Click);
            // 
            // btnImportarConsumiblesContrato
            // 
            this.btnImportarConsumiblesContrato.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImportarConsumiblesContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportarConsumiblesContrato.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnImportarConsumiblesContrato.Location = new System.Drawing.Point(354, 15);
            this.btnImportarConsumiblesContrato.Name = "btnImportarConsumiblesContrato";
            this.btnImportarConsumiblesContrato.Size = new System.Drawing.Size(112, 23);
            this.btnImportarConsumiblesContrato.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnImportarConsumiblesContrato.TabIndex = 115;
            this.btnImportarConsumiblesContrato.Text = "Importar de contrato";
            this.btnImportarConsumiblesContrato.Visible = false;
            this.btnImportarConsumiblesContrato.Click += new System.EventHandler(this.btnImportarConsumiblesContrato_Click);
            // 
            // btnEliminarConsumible
            // 
            this.btnEliminarConsumible.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEliminarConsumible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarConsumible.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarConsumible.Image")));
            this.btnEliminarConsumible.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnEliminarConsumible.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnEliminarConsumible.Location = new System.Drawing.Point(537, 13);
            this.btnEliminarConsumible.Name = "btnEliminarConsumible";
            this.btnEliminarConsumible.Size = new System.Drawing.Size(28, 28);
            this.btnEliminarConsumible.TabIndex = 114;
            this.btnEliminarConsumible.Click += new System.EventHandler(this.btnEliminarConsumible_Click);
            // 
            // btnAgregarConsumible
            // 
            this.btnAgregarConsumible.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregarConsumible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarConsumible.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarConsumible.Image")));
            this.btnAgregarConsumible.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnAgregarConsumible.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAgregarConsumible.Location = new System.Drawing.Point(470, 13);
            this.btnAgregarConsumible.Name = "btnAgregarConsumible";
            this.btnAgregarConsumible.Size = new System.Drawing.Size(28, 28);
            this.btnAgregarConsumible.TabIndex = 113;
            this.btnAgregarConsumible.Click += new System.EventHandler(this.btnAgregarConsumible_Click);
            // 
            // btnEditarConsumible
            // 
            this.btnEditarConsumible.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEditarConsumible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarConsumible.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarConsumible.Image")));
            this.btnEditarConsumible.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnEditarConsumible.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnEditarConsumible.Location = new System.Drawing.Point(504, 13);
            this.btnEditarConsumible.Name = "btnEditarConsumible";
            this.btnEditarConsumible.Size = new System.Drawing.Size(28, 28);
            this.btnEditarConsumible.TabIndex = 112;
            this.btnEditarConsumible.Click += new System.EventHandler(this.btnEditarConsumible_Click);
            // 
            // grdConsumibles
            // 
            this.grdConsumibles.AllowUpdate = false;
            this.grdConsumibles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdConsumibles.DataMember = "pltConsumiblexContratoConsumo";
            this.grdConsumibles.DataSource = this.dsContratoConsumo1;
            this.grdConsumibles.Images.Add(((System.Drawing.Image)(resources.GetObject("grdConsumibles.Images"))));
            this.grdConsumibles.Location = new System.Drawing.Point(6, 43);
            this.grdConsumibles.Name = "grdConsumibles";
            this.grdConsumibles.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdConsumibles.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdConsumibles.PreviewInfo.ZoomFactor = 75D;
            this.grdConsumibles.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdConsumibles.PrintInfo.PageSettings")));
            this.grdConsumibles.Size = new System.Drawing.Size(559, 70);
            this.grdConsumibles.TabIndex = 83;
            this.grdConsumibles.Text = "c1TrueDBGrid2";
            this.grdConsumibles.PropBag = resources.GetString("grdConsumibles.PropBag");
            // 
            // grpIncrementos
            // 
            this.grpIncrementos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpIncrementos.BackColor = System.Drawing.Color.White;
            this.grpIncrementos.Controls.Add(this.btnImportarIncrementosxLineaConsumo);
            this.grpIncrementos.Controls.Add(this.btnEliminarIncremento);
            this.grpIncrementos.Controls.Add(this.btnAgregarIncremento);
            this.grpIncrementos.Controls.Add(this.btnEditarIncremento);
            this.grpIncrementos.Controls.Add(this.grdIncrementosPorLinea);
            this.grpIncrementos.Location = new System.Drawing.Point(633, 235);
            this.grpIncrementos.Name = "grpIncrementos";
            this.grpIncrementos.Size = new System.Drawing.Size(360, 163);
            this.grpIncrementos.TabIndex = 86;
            this.grpIncrementos.TabStop = false;
            this.grpIncrementos.Text = "Incrementos por Linea de Consumo";
            this.grpIncrementos.Visible = false;
            // 
            // btnImportarIncrementosxLineaConsumo
            // 
            this.btnImportarIncrementosxLineaConsumo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImportarIncrementosxLineaConsumo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportarIncrementosxLineaConsumo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnImportarIncrementosxLineaConsumo.Location = new System.Drawing.Point(141, 15);
            this.btnImportarIncrementosxLineaConsumo.Name = "btnImportarIncrementosxLineaConsumo";
            this.btnImportarIncrementosxLineaConsumo.Size = new System.Drawing.Size(112, 23);
            this.btnImportarIncrementosxLineaConsumo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnImportarIncrementosxLineaConsumo.TabIndex = 115;
            this.btnImportarIncrementosxLineaConsumo.Text = "Importar de contrato";
            this.btnImportarIncrementosxLineaConsumo.Visible = false;
            this.btnImportarIncrementosxLineaConsumo.Click += new System.EventHandler(this.btnImportarIncrementosxLineaConsumo_Click);
            // 
            // btnEliminarIncremento
            // 
            this.btnEliminarIncremento.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEliminarIncremento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarIncremento.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarIncremento.Image")));
            this.btnEliminarIncremento.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnEliminarIncremento.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnEliminarIncremento.Location = new System.Drawing.Point(324, 13);
            this.btnEliminarIncremento.Name = "btnEliminarIncremento";
            this.btnEliminarIncremento.Size = new System.Drawing.Size(28, 28);
            this.btnEliminarIncremento.TabIndex = 114;
            this.btnEliminarIncremento.Click += new System.EventHandler(this.btnEliminarIncremento_Click);
            // 
            // btnAgregarIncremento
            // 
            this.btnAgregarIncremento.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregarIncremento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarIncremento.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarIncremento.Image")));
            this.btnAgregarIncremento.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnAgregarIncremento.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAgregarIncremento.Location = new System.Drawing.Point(257, 13);
            this.btnAgregarIncremento.Name = "btnAgregarIncremento";
            this.btnAgregarIncremento.Size = new System.Drawing.Size(28, 28);
            this.btnAgregarIncremento.TabIndex = 113;
            this.btnAgregarIncremento.Click += new System.EventHandler(this.btnAgregarIncremento_Click);
            // 
            // btnEditarIncremento
            // 
            this.btnEditarIncremento.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEditarIncremento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarIncremento.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarIncremento.Image")));
            this.btnEditarIncremento.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnEditarIncremento.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnEditarIncremento.Location = new System.Drawing.Point(291, 13);
            this.btnEditarIncremento.Name = "btnEditarIncremento";
            this.btnEditarIncremento.Size = new System.Drawing.Size(28, 28);
            this.btnEditarIncremento.TabIndex = 112;
            this.btnEditarIncremento.Click += new System.EventHandler(this.btnEditarIncremento_Click);
            // 
            // grdIncrementosPorLinea
            // 
            this.grdIncrementosPorLinea.AllowUpdate = false;
            this.grdIncrementosPorLinea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdIncrementosPorLinea.DataMember = "pltIncrementosLineaConsumoxContrato";
            this.grdIncrementosPorLinea.DataSource = this.dsContratoConsumo1;
            this.grdIncrementosPorLinea.Images.Add(((System.Drawing.Image)(resources.GetObject("grdIncrementosPorLinea.Images"))));
            this.grdIncrementosPorLinea.Location = new System.Drawing.Point(6, 47);
            this.grdIncrementosPorLinea.Name = "grdIncrementosPorLinea";
            this.grdIncrementosPorLinea.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdIncrementosPorLinea.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdIncrementosPorLinea.PreviewInfo.ZoomFactor = 75D;
            this.grdIncrementosPorLinea.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdIncrementosPorLinea.PrintInfo.PageSettings")));
            this.grdIncrementosPorLinea.Size = new System.Drawing.Size(346, 110);
            this.grdIncrementosPorLinea.TabIndex = 83;
            this.grdIncrementosPorLinea.Text = "c1TrueDBGrid2";
            this.grdIncrementosPorLinea.PropBag = resources.GetString("grdIncrementosPorLinea.PropBag");
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(630, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 93;
            this.label14.Text = "Sub Modalidad";
            // 
            // cmbModalidadVinculado
            // 
            this.cmbModalidadVinculado.DataSource = this.dsContratoConsumo2;
            this.cmbModalidadVinculado.DisplayMember = "modalidad_contrato.nombre_modalidad_contrato";
            this.cmbModalidadVinculado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModalidadVinculado.FormattingEnabled = true;
            this.cmbModalidadVinculado.Location = new System.Drawing.Point(739, 41);
            this.cmbModalidadVinculado.Name = "cmbModalidadVinculado";
            this.cmbModalidadVinculado.Size = new System.Drawing.Size(254, 21);
            this.cmbModalidadVinculado.TabIndex = 12;
            this.cmbModalidadVinculado.ValueMember = "modalidad_contrato.cod_modalidad_contrato";
            this.cmbModalidadVinculado.SelectedIndexChanged += new System.EventHandler(this.cmbModalidadVinculado_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(630, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 92;
            this.label15.Text = "Modalidad";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(630, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(169, 14);
            this.label13.TabIndex = 90;
            this.label13.Text = "Numero de Contrato Vinculado:";
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel1;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "Informacion General";
            // 
            // tabControlPanel3
            // 
            this.tabControlPanel3.Controls.Add(this.btnAbrirArchivo);
            this.tabControlPanel3.Controls.Add(this.btnDescargarArchivo);
            this.tabControlPanel3.Controls.Add(this.btnQuitarArchivo);
            this.tabControlPanel3.Controls.Add(this.btnAgregarArchivo);
            this.tabControlPanel3.Controls.Add(this.grdArchivos);
            this.tabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel3.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel3.Name = "tabControlPanel3";
            this.tabControlPanel3.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel3.Size = new System.Drawing.Size(1005, 606);
            this.tabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel3.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel3.Style.GradientAngle = 90;
            this.tabControlPanel3.TabIndex = 3;
            this.tabControlPanel3.TabItem = this.tabItem3;
            // 
            // btnAbrirArchivo
            // 
            this.btnAbrirArchivo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAbrirArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbrirArchivo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAbrirArchivo.Location = new System.Drawing.Point(651, 19);
            this.btnAbrirArchivo.Name = "btnAbrirArchivo";
            this.btnAbrirArchivo.Size = new System.Drawing.Size(135, 23);
            this.btnAbrirArchivo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAbrirArchivo.TabIndex = 110;
            this.btnAbrirArchivo.Text = "Abrir Archivo";
            this.btnAbrirArchivo.Click += new System.EventHandler(this.btnAbrirArchivo_Click);
            // 
            // btnDescargarArchivo
            // 
            this.btnDescargarArchivo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDescargarArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDescargarArchivo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDescargarArchivo.Location = new System.Drawing.Point(792, 19);
            this.btnDescargarArchivo.Name = "btnDescargarArchivo";
            this.btnDescargarArchivo.Size = new System.Drawing.Size(135, 23);
            this.btnDescargarArchivo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDescargarArchivo.TabIndex = 109;
            this.btnDescargarArchivo.Text = "Descargar Archivo";
            this.btnDescargarArchivo.Click += new System.EventHandler(this.btnDescargarArchivo_Click);
            // 
            // btnQuitarArchivo
            // 
            this.btnQuitarArchivo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuitarArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitarArchivo.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitarArchivo.Image")));
            this.btnQuitarArchivo.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnQuitarArchivo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnQuitarArchivo.Location = new System.Drawing.Point(967, 14);
            this.btnQuitarArchivo.Name = "btnQuitarArchivo";
            this.btnQuitarArchivo.Size = new System.Drawing.Size(28, 28);
            this.btnQuitarArchivo.TabIndex = 108;
            this.btnQuitarArchivo.Click += new System.EventHandler(this.btnQuitarArchivo_Click);
            // 
            // btnAgregarArchivo
            // 
            this.btnAgregarArchivo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregarArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarArchivo.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarArchivo.Image")));
            this.btnAgregarArchivo.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnAgregarArchivo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAgregarArchivo.Location = new System.Drawing.Point(933, 14);
            this.btnAgregarArchivo.Name = "btnAgregarArchivo";
            this.btnAgregarArchivo.Size = new System.Drawing.Size(28, 28);
            this.btnAgregarArchivo.TabIndex = 107;
            this.btnAgregarArchivo.Click += new System.EventHandler(this.btnAgregarArchivo_Click);
            // 
            // grdArchivos
            // 
            this.grdArchivos.AllowUpdate = false;
            this.grdArchivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdArchivos.DataMember = "archivoxcontrato_consumo";
            this.grdArchivos.DataSource = this.dsContratoConsumo1;
            this.grdArchivos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdArchivos.Images"))));
            this.grdArchivos.Location = new System.Drawing.Point(12, 51);
            this.grdArchivos.Name = "grdArchivos";
            this.grdArchivos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdArchivos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdArchivos.PreviewInfo.ZoomFactor = 75D;
            this.grdArchivos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdArchivos.PrintInfo.PageSettings")));
            this.grdArchivos.Size = new System.Drawing.Size(981, 519);
            this.grdArchivos.TabIndex = 83;
            this.grdArchivos.Text = "c1TrueDBGrid3";
            this.grdArchivos.PropBag = resources.GetString("grdArchivos.PropBag");
            // 
            // tabItem3
            // 
            this.tabItem3.AttachedControl = this.tabControlPanel3;
            this.tabItem3.Name = "tabItem3";
            this.tabItem3.Text = "Archivos Adjuntos";
            this.tabItem3.Visible = false;
            // 
            // tabControlPanel4
            // 
            this.tabControlPanel4.Controls.Add(this.btnRecaclcular);
            this.tabControlPanel4.Controls.Add(this.controladorColumnas1);
            this.tabControlPanel4.Controls.Add(this.grdcambios);
            this.tabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel4.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel4.Name = "tabControlPanel4";
            this.tabControlPanel4.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel4.Size = new System.Drawing.Size(1005, 606);
            this.tabControlPanel4.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel4.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel4.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel4.Style.GradientAngle = 90;
            this.tabControlPanel4.TabIndex = 4;
            this.tabControlPanel4.TabItem = this.tabItem4;
            // 
            // btnRecaclcular
            // 
            this.btnRecaclcular.Location = new System.Drawing.Point(19, 19);
            this.btnRecaclcular.Name = "btnRecaclcular";
            this.btnRecaclcular.Size = new System.Drawing.Size(220, 23);
            this.btnRecaclcular.TabIndex = 106;
            this.btnRecaclcular.Text = "Recalcular Historicos";
            this.btnRecaclcular.UseVisualStyleBackColor = true;
            this.btnRecaclcular.Click += new System.EventHandler(this.btnRecaclcular_Click);
            // 
            // controladorColumnas1
            // 
            this.controladorColumnas1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controladorColumnas1.BackColor = System.Drawing.Color.Transparent;
            this.controladorColumnas1.grilla = null;
            this.controladorColumnas1.Location = new System.Drawing.Point(779, 13);
            this.controladorColumnas1.MostrarContraer = true;
            this.controladorColumnas1.MostrarExcel = true;
            this.controladorColumnas1.MostrarExpandir = true;
            this.controladorColumnas1.MostrarLimpiar = true;
            this.controladorColumnas1.Name = "controladorColumnas1";
            this.controladorColumnas1.nombreLibro = null;
            this.controladorColumnas1.Size = new System.Drawing.Size(216, 29);
            this.controladorColumnas1.TabIndex = 105;
            // 
            // grdcambios
            // 
            this.grdcambios.AllowUpdate = false;
            this.grdcambios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdcambios.DataMember = "log_cambio_contratos_consumo";
            this.grdcambios.DataSource = this.dsContratoConsumo1;
            this.grdcambios.FilterBar = true;
            this.grdcambios.GroupByCaption = "";
            this.grdcambios.Images.Add(((System.Drawing.Image)(resources.GetObject("grdcambios.Images"))));
            this.grdcambios.Location = new System.Drawing.Point(19, 44);
            this.grdcambios.Name = "grdcambios";
            this.grdcambios.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdcambios.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdcambios.PreviewInfo.ZoomFactor = 75D;
            this.grdcambios.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdcambios.PrintInfo.PageSettings")));
            this.grdcambios.Size = new System.Drawing.Size(974, 547);
            this.grdcambios.TabIndex = 104;
            this.grdcambios.Text = "c1TrueDBGrid1";
            this.grdcambios.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.grdcambios.PropBag = resources.GetString("grdcambios.PropBag");
            // 
            // tabItem4
            // 
            this.tabItem4.AttachedControl = this.tabControlPanel4;
            this.tabItem4.Name = "tabItem4";
            this.tabItem4.Text = "Log de Cambios";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.btnVerDetalleHistorico);
            this.tabControlPanel2.Controls.Add(this.grdHistorico);
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(1005, 606);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 2;
            this.tabControlPanel2.TabItem = this.tabItem2;
            // 
            // btnVerDetalleHistorico
            // 
            this.btnVerDetalleHistorico.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVerDetalleHistorico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerDetalleHistorico.Image = ((System.Drawing.Image)(resources.GetObject("btnVerDetalleHistorico.Image")));
            this.btnVerDetalleHistorico.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnVerDetalleHistorico.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnVerDetalleHistorico.Location = new System.Drawing.Point(828, 10);
            this.btnVerDetalleHistorico.Name = "btnVerDetalleHistorico";
            this.btnVerDetalleHistorico.Size = new System.Drawing.Size(165, 28);
            this.btnVerDetalleHistorico.TabIndex = 101;
            this.btnVerDetalleHistorico.Text = "Ver detalle historico";
            this.btnVerDetalleHistorico.Click += new System.EventHandler(this.btnVerDetalleHistorico_Click);
            // 
            // grdHistorico
            // 
            this.grdHistorico.AllowUpdate = false;
            this.grdHistorico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdHistorico.DataMember = "pltContratoConsumo";
            this.grdHistorico.DataSource = this.dsContratoHistorico;
            this.grdHistorico.FilterBar = true;
            this.grdHistorico.Images.Add(((System.Drawing.Image)(resources.GetObject("grdHistorico.Images"))));
            this.grdHistorico.Location = new System.Drawing.Point(12, 44);
            this.grdHistorico.Name = "grdHistorico";
            this.grdHistorico.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdHistorico.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdHistorico.PreviewInfo.ZoomFactor = 75D;
            this.grdHistorico.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdHistorico.PrintInfo.PageSettings")));
            this.grdHistorico.Size = new System.Drawing.Size(981, 519);
            this.grdHistorico.TabIndex = 84;
            this.grdHistorico.Text = "c1TrueDBGrid3";
            this.grdHistorico.PropBag = resources.GetString("grdHistorico.PropBag");
            // 
            // dsContratoHistorico
            // 
            this.dsContratoHistorico.DataSetName = "dsContratoConsumo";
            this.dsContratoHistorico.EnforceConstraints = false;
            this.dsContratoHistorico.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabItem2
            // 
            this.tabItem2.AttachedControl = this.tabControlPanel2;
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.Text = "Historico Contrato";
            this.tabItem2.Visible = false;
            // 
            // linea_consumoxcontrato_consumoTableAdapter1
            // 
            this.linea_consumoxcontrato_consumoTableAdapter1.ClearBeforeFill = true;
            // 
            // pltConsumoxContratoTableAdapter1
            // 
            this.pltConsumoxContratoTableAdapter1.ClearBeforeFill = true;
            // 
            // pltEquiposxContratoTableAdapter1
            // 
            this.pltEquiposxContratoTableAdapter1.ClearBeforeFill = true;
            // 
            // pltContratoConsumoTableAdapter1
            // 
            this.pltContratoConsumoTableAdapter1.ClearBeforeFill = true;
            // 
            // vigencias_contrato_consumoTableAdapter1
            // 
            this.vigencias_contrato_consumoTableAdapter1.ClearBeforeFill = true;
            // 
            // tipo_software_contrato_consumoTableAdapter1
            // 
            this.tipo_software_contrato_consumoTableAdapter1.ClearBeforeFill = true;
            // 
            // consumiblesTableAdapter1
            // 
            this.consumiblesTableAdapter1.ClearBeforeFill = true;
            // 
            // pltIncrementosLineaConsumoxContratoTableAdapter1
            // 
            this.pltIncrementosLineaConsumoxContratoTableAdapter1.ClearBeforeFill = true;
            // 
            // pltConsumibleTableAdapter1
            // 
            this.pltConsumibleTableAdapter1.ClearBeforeFill = true;
            // 
            // incrementosxlinea_consumoTableAdapter1
            // 
            this.incrementosxlinea_consumoTableAdapter1.ClearBeforeFill = true;
            // 
            // consumiblexcontrato_consumoTableAdapter1
            // 
            this.consumiblexcontrato_consumoTableAdapter1.ClearBeforeFill = true;
            // 
            // vigencias_contrato_consumoTableAdapter2
            // 
            this.vigencias_contrato_consumoTableAdapter2.ClearBeforeFill = true;
            // 
            // pltConsumiblexContratoConsumoTableAdapter1
            // 
            this.pltConsumiblexContratoConsumoTableAdapter1.ClearBeforeFill = true;
            // 
            // razon_no_vigenteTableAdapter1
            // 
            this.razon_no_vigenteTableAdapter1.ClearBeforeFill = true;
            // 
            // pltTipoSoftwarexContratoTableAdapter1
            // 
            this.pltTipoSoftwarexContratoTableAdapter1.ClearBeforeFill = true;
            // 
            // tipo_softwarexcontrato_consumoTableAdapter1
            // 
            this.tipo_softwarexcontrato_consumoTableAdapter1.ClearBeforeFill = true;
            // 
            // log_cambio_contratos_consumoTableAdapter1
            // 
            this.log_cambio_contratos_consumoTableAdapter1.ClearBeforeFill = true;
            // 
            // contratosConsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1005, 683);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "contratosConsumo";
            this.Text = "Contratos Consumo";
            this.Load += new System.EventHandler(this.contratosConsumo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calFinContrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calInicioContrato)).EndInit();
            this.panel1.ResumeLayout(false);
            this.grpOtroSi.ResumeLayout(false);
            this.grpOtroSi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calOtroSi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContratoConsumo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEquipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsumo)).EndInit();
            this.grpRelaciones.ResumeLayout(false);
            this.grpRelaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.tabControlPanel1.PerformLayout();
            this.grpSoftwareAsociado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoSoftware)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContratoConsumo2)).EndInit();
            this.grpConsumibles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdConsumibles)).EndInit();
            this.grpIncrementos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdIncrementosPorLinea)).EndInit();
            this.tabControlPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdArchivos)).EndInit();
            this.tabControlPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdcambios)).EndInit();
            this.tabControlPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdHistorico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContratoHistorico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFinContrato;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calInicioContrato;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblOtroSi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtOtroSi;
        private System.Windows.Forms.GroupBox grpOtroSi;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calOtroSi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroContrato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbAsesor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkLegalizado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbModalidad;
        private System.Windows.Forms.ComboBox cmbSubModalidad;
        private System.Windows.Forms.TextBox txtObservaciones;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.txtBusqueda txtBusquedaCliente1;
        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsContratoConsumo dsContratoConsumo1;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.modalidad_contratoTableAdapter modalidad_contratoTableAdapter1;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.sub_modalidad_contratoTableAdapter sub_modalidad_contratoTableAdapter1;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.equiposxcontrato_consumoTableAdapter equiposxcontrato_consumoTableAdapter1;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.contrato_consumoTableAdapter contrato_consumoTableAdapter1;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.archivoxcontrato_consumoTableAdapter archivoxcontrato_consumoTableAdapter1;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdEquipos;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdConsumo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpRelaciones;
        private System.Windows.Forms.Button btnGenerarOtroSi;
        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel3;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdArchivos;
        private DevComponents.DotNetBar.TabItem tabItem3;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.TabItem tabItem2;
        private DevComponents.DotNetBar.ButtonX btnEliminarContratoConsumo;
        private DevComponents.DotNetBar.ButtonX btnAgregarConsumo;
        private DevComponents.DotNetBar.ButtonX btnEditarContratoConsumo;
        private DevComponents.DotNetBar.ButtonX btnEliminarEquipo;
        private DevComponents.DotNetBar.ButtonX btnAgregarEquipo;
        private DevComponents.DotNetBar.ButtonX btnEditarEquipo;
        private DevComponents.DotNetBar.ButtonX btnDescargarArchivo;
        private DevComponents.DotNetBar.ButtonX btnQuitarArchivo;
        private DevComponents.DotNetBar.ButtonX btnAgregarArchivo;
        private DevComponents.DotNetBar.ButtonX btnVerDetalleHistorico;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdHistorico;
        private SPControladoraDatos.dsContratoConsumo dsContratoHistorico;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.linea_consumoxcontrato_consumoTableAdapter linea_consumoxcontrato_consumoTableAdapter1;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.pltConsumoxContratoTableAdapter pltConsumoxContratoTableAdapter1;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.pltEquiposxContratoTableAdapter pltEquiposxContratoTableAdapter1;
        private DevComponents.DotNetBar.ButtonX btnImportarConsumo;
        private DevComponents.DotNetBar.ButtonX btnImportarEquipos;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.pltContratoConsumoTableAdapter pltContratoConsumoTableAdapter1;
        private System.Windows.Forms.GroupBox grpIncrementos;
        private DevComponents.DotNetBar.ButtonX btnImportarIncrementosxLineaConsumo;
        private DevComponents.DotNetBar.ButtonX btnEliminarIncremento;
        private DevComponents.DotNetBar.ButtonX btnAgregarIncremento;
        private DevComponents.DotNetBar.ButtonX btnEditarIncremento;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdIncrementosPorLinea;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.vigencias_contrato_consumoTableAdapter vigencias_contrato_consumoTableAdapter1;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.tipo_software_contrato_consumoTableAdapter tipo_software_contrato_consumoTableAdapter1;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.consumiblesTableAdapter consumiblesTableAdapter1;
        private System.Windows.Forms.GroupBox grpConsumibles;
        private DevComponents.DotNetBar.ButtonX btnImportarConsumiblesContrato;
        private DevComponents.DotNetBar.ButtonX btnEliminarConsumible;
        private DevComponents.DotNetBar.ButtonX btnAgregarConsumible;
        private DevComponents.DotNetBar.ButtonX btnEditarConsumible;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdConsumibles;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.pltIncrementosLineaConsumoxContratoTableAdapter pltIncrementosLineaConsumoxContratoTableAdapter1;
        private SPControladoraDatos.dsCientificaTableAdapters.pltConsumibleTableAdapter pltConsumibleTableAdapter1;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.incrementosxlinea_consumoTableAdapter incrementosxlinea_consumoTableAdapter1;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.consumiblexcontrato_consumoTableAdapter consumiblexcontrato_consumoTableAdapter1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNumeroContratoVinculado;
        private System.Windows.Forms.ComboBox cmbVigencia;
        private System.Windows.Forms.Label label10;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.vigencias_contrato_consumoTableAdapter vigencias_contrato_consumoTableAdapter2;
        private System.Windows.Forms.ComboBox cmbSubModalidadVinculado;
        private System.Windows.Forms.ComboBox cmbModalidadVinculado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox grpSoftwareAsociado;
        private DevComponents.DotNetBar.ButtonX btnImportarContrato;
        private DevComponents.DotNetBar.ButtonX btnEliminarSoftware;
        private DevComponents.DotNetBar.ButtonX btnAgregarSoftware;
        private DevComponents.DotNetBar.ButtonX btnEditarSoftware;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdTipoSoftware;
        private SPControladoraDatos.dsContratoConsumo dsContratoConsumo2;
        private System.Windows.Forms.TextBox txtConsumoTotal;
        private System.Windows.Forms.CheckBox chkProrogaAutomatica;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.pltConsumiblexContratoConsumoTableAdapter pltConsumiblexContratoConsumoTableAdapter1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbRazonVigencia;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.razon_no_vigenteTableAdapter razon_no_vigenteTableAdapter1;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.pltTipoSoftwarexContratoTableAdapter pltTipoSoftwarexContratoTableAdapter1;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.tipo_softwarexcontrato_consumoTableAdapter tipo_softwarexcontrato_consumoTableAdapter1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel4;
        private DevComponents.DotNetBar.TabItem tabItem4;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas controladorColumnas1;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdcambios;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.log_cambio_contratos_consumoTableAdapter log_cambio_contratos_consumoTableAdapter1;
        private System.Windows.Forms.Button btnRecaclcular;
        private DevComponents.DotNetBar.ButtonX btnAbrirArchivo;
        private DevComponents.DotNetBar.ButtonX btnExportarConsumiibles;
    }
}