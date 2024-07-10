namespace spProcesos.contratos
{
    partial class frmNuevoOtroSi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoOtroSi));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.lblHora = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calCreacion = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.grpMantenimiento = new System.Windows.Forms.GroupBox();
            this.btnModificarRepuesto = new DevComponents.DotNetBar.ButtonX();
            this.btnDesvincularRepuesto = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregarRepuestos = new DevComponents.DotNetBar.ButtonX();
            this.grdRepuestos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.nmDiasHabiles = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nmMantenimientosIncluidos = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nmMesesEntreMantenimientos = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.nmHorasHabiles = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.chkIncluyeTiquetes = new System.Windows.Forms.CheckBox();
            this.nmPorcentajePrecioTiquetes = new System.Windows.Forms.NumericUpDown();
            this.chkIncluyeRepuestos = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOtroSi = new System.Windows.Forms.TextBox();
            this.grpConsumo = new System.Windows.Forms.GroupBox();
            this.txtConsumoxLinea = new System.Windows.Forms.TextBox();
            this.chkTienePoliza = new System.Windows.Forms.CheckBox();
            this.rdConsumoxLinea = new System.Windows.Forms.RadioButton();
            this.rdconsumoMinimoGeneral = new System.Windows.Forms.RadioButton();
            this.txtConsumoMinimo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMontoContrato = new System.Windows.Forms.TextBox();
            this.btnLimpiarModalidad = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbTipoContrato = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtObervaciones = new System.Windows.Forms.TextBox();
            this.btnCancelar = new DevComponents.DotNetBar.ButtonX();
            this.btnGuardar = new DevComponents.DotNetBar.ButtonX();
            this.label24 = new System.Windows.Forms.Label();
            this.cmbModalidadContrato = new System.Windows.Forms.ComboBox();
            this.txtNroContrato = new System.Windows.Forms.TextBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.calInicioContrato = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.calFinContrato = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.tipoContratoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.tipoContratoTableAdapter();
            this.contratosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.contratosTableAdapter();
            this.archivosxcontratoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.archivosxcontratoTableAdapter();
            this.clientesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.clientesTableAdapter();
            this.contratosxEquipoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.contratosxEquipoTableAdapter();
            this.equiposTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter();
            this.dsPlantillas1 = new SPControladoraDatos.dsPlantillas();
            this.mantenimientosxContratoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.mantenimientosxContratoTableAdapter();
            this.modalidadContratoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.modalidadContratoTableAdapter();
            this.repuestosxContratosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.repuestosxContratosTableAdapter();
            this.pltFechaSistemaTableAdapter1 = new SPControladoraDatos.dsPlantillasTableAdapters.pltFechaSistemaTableAdapter();
            this.nmTopeCorrectivos = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.chkIncluyeCorrectivos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calCreacion)).BeginInit();
            this.grpMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRepuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiasHabiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMantenimientosIncluidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMesesEntreMantenimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmHorasHabiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPorcentajePrecioTiquetes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grpConsumo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calInicioContrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFinContrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTopeCorrectivos)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // tabControl1
            // 
            this.tabControl1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1016, 569);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItem1);
            this.tabControl1.Text = "tabControl1";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.lblHora);
            this.tabControlPanel1.Controls.Add(this.label2);
            this.tabControlPanel1.Controls.Add(this.calCreacion);
            this.tabControlPanel1.Controls.Add(this.grpMantenimiento);
            this.tabControlPanel1.Controls.Add(this.groupBox2);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(1016, 543);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 0;
            this.tabControlPanel1.TabItem = this.tabItem1;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Location = new System.Drawing.Point(342, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 13);
            this.lblHora.TabIndex = 162;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(13, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 158;
            this.label2.Text = "Fecha Creacion:";
            // 
            // calCreacion
            // 
            // 
            // 
            // 
            this.calCreacion.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calCreacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calCreacion.ButtonDropDown.Visible = true;
            this.calCreacion.Enabled = false;
            this.calCreacion.Location = new System.Drawing.Point(136, 5);
            // 
            // 
            // 
            this.calCreacion.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calCreacion.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calCreacion.MonthCalendar.BackgroundStyle.Class = "";
            this.calCreacion.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calCreacion.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calCreacion.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calCreacion.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calCreacion.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calCreacion.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calCreacion.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calCreacion.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calCreacion.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calCreacion.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calCreacion.MonthCalendar.DisplayMonth = new System.DateTime(2008, 10, 1, 0, 0, 0, 0);
            this.calCreacion.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calCreacion.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calCreacion.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calCreacion.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calCreacion.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calCreacion.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calCreacion.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calCreacion.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calCreacion.MonthCalendar.TodayButtonVisible = true;
            this.calCreacion.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calCreacion.Name = "calCreacion";
            this.calCreacion.Size = new System.Drawing.Size(200, 20);
            this.calCreacion.TabIndex = 157;
            // 
            // grpMantenimiento
            // 
            this.grpMantenimiento.BackColor = System.Drawing.Color.Transparent;
            this.grpMantenimiento.Controls.Add(this.nmTopeCorrectivos);
            this.grpMantenimiento.Controls.Add(this.label6);
            this.grpMantenimiento.Controls.Add(this.chkIncluyeCorrectivos);
            this.grpMantenimiento.Controls.Add(this.btnModificarRepuesto);
            this.grpMantenimiento.Controls.Add(this.btnDesvincularRepuesto);
            this.grpMantenimiento.Controls.Add(this.btnAgregarRepuestos);
            this.grpMantenimiento.Controls.Add(this.grdRepuestos);
            this.grpMantenimiento.Controls.Add(this.nmDiasHabiles);
            this.grpMantenimiento.Controls.Add(this.label3);
            this.grpMantenimiento.Controls.Add(this.nmMantenimientosIncluidos);
            this.grpMantenimiento.Controls.Add(this.label8);
            this.grpMantenimiento.Controls.Add(this.nmMesesEntreMantenimientos);
            this.grpMantenimiento.Controls.Add(this.label15);
            this.grpMantenimiento.Controls.Add(this.nmHorasHabiles);
            this.grpMantenimiento.Controls.Add(this.label14);
            this.grpMantenimiento.Controls.Add(this.label11);
            this.grpMantenimiento.Controls.Add(this.chkIncluyeTiquetes);
            this.grpMantenimiento.Controls.Add(this.nmPorcentajePrecioTiquetes);
            this.grpMantenimiento.Controls.Add(this.chkIncluyeRepuestos);
            this.grpMantenimiento.Controls.Add(this.label10);
            this.grpMantenimiento.Location = new System.Drawing.Point(518, 5);
            this.grpMantenimiento.Name = "grpMantenimiento";
            this.grpMantenimiento.Size = new System.Drawing.Size(486, 526);
            this.grpMantenimiento.TabIndex = 153;
            this.grpMantenimiento.TabStop = false;
            this.grpMantenimiento.Text = "Informacion de Mantenimiento";
            // 
            // btnModificarRepuesto
            // 
            this.btnModificarRepuesto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnModificarRepuesto, null);
            this.balloonTip1.SetBalloonText(this.btnModificarRepuesto, "Modificar Repuestos");
            this.btnModificarRepuesto.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarRepuesto.Image")));
            this.btnModificarRepuesto.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnModificarRepuesto.Location = new System.Drawing.Point(408, 175);
            this.btnModificarRepuesto.Name = "btnModificarRepuesto";
            this.btnModificarRepuesto.Size = new System.Drawing.Size(33, 33);
            this.btnModificarRepuesto.TabIndex = 145;
            this.btnModificarRepuesto.Click += new System.EventHandler(this.btnModificarRepuesto_Click);
            // 
            // btnDesvincularRepuesto
            // 
            this.btnDesvincularRepuesto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnDesvincularRepuesto, null);
            this.balloonTip1.SetBalloonText(this.btnDesvincularRepuesto, "Desvincular Repuesto");
            this.btnDesvincularRepuesto.Image = ((System.Drawing.Image)(resources.GetObject("btnDesvincularRepuesto.Image")));
            this.btnDesvincularRepuesto.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnDesvincularRepuesto.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDesvincularRepuesto.Location = new System.Drawing.Point(447, 175);
            this.btnDesvincularRepuesto.Name = "btnDesvincularRepuesto";
            this.btnDesvincularRepuesto.Size = new System.Drawing.Size(33, 33);
            this.btnDesvincularRepuesto.TabIndex = 144;
            this.btnDesvincularRepuesto.Click += new System.EventHandler(this.btnDesvincularRepuesto_Click);
            // 
            // btnAgregarRepuestos
            // 
            this.btnAgregarRepuestos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnAgregarRepuestos, null);
            this.balloonTip1.SetBalloonText(this.btnAgregarRepuestos, "Agregar Repuestos");
            this.btnAgregarRepuestos.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarRepuestos.Image")));
            this.btnAgregarRepuestos.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnAgregarRepuestos.Location = new System.Drawing.Point(367, 175);
            this.btnAgregarRepuestos.Name = "btnAgregarRepuestos";
            this.btnAgregarRepuestos.Size = new System.Drawing.Size(33, 33);
            this.btnAgregarRepuestos.TabIndex = 143;
            this.btnAgregarRepuestos.Click += new System.EventHandler(this.btnAgregarRepuestos_Click);
            // 
            // grdRepuestos
            // 
            this.grdRepuestos.AllowUpdate = false;
            this.grdRepuestos.DataMember = "repuestosxContratos";
            this.grdRepuestos.DataSource = this.dsSpx1;
            this.grdRepuestos.GroupByCaption = "Drag a column header here to group by that column";
            this.grdRepuestos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdRepuestos.Images"))));
            this.grdRepuestos.Location = new System.Drawing.Point(18, 228);
            this.grdRepuestos.Name = "grdRepuestos";
            this.grdRepuestos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdRepuestos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdRepuestos.PreviewInfo.ZoomFactor = 75D;
            this.grdRepuestos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdRepuestos.PrintInfo.PageSettings")));
            this.grdRepuestos.Size = new System.Drawing.Size(462, 292);
            this.grdRepuestos.TabIndex = 133;
            this.grdRepuestos.Text = "c1TrueDBGrid1";
            this.grdRepuestos.PropBag = resources.GetString("grdRepuestos.PropBag");
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nmDiasHabiles
            // 
            this.nmDiasHabiles.Location = new System.Drawing.Point(408, 93);
            this.nmDiasHabiles.Name = "nmDiasHabiles";
            this.nmDiasHabiles.Size = new System.Drawing.Size(61, 20);
            this.nmDiasHabiles.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 34);
            this.label3.TabIndex = 101;
            this.label3.Text = "Numero de Mantenimientos Incluidos";
            // 
            // nmMantenimientosIncluidos
            // 
            this.nmMantenimientosIncluidos.Location = new System.Drawing.Point(160, 60);
            this.nmMantenimientosIncluidos.Name = "nmMantenimientosIncluidos";
            this.nmMantenimientosIncluidos.Size = new System.Drawing.Size(61, 20);
            this.nmMantenimientosIncluidos.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(257, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 26);
            this.label8.TabIndex = 115;
            this.label8.Text = "Meses entre los mantenimento del contrato";
            // 
            // nmMesesEntreMantenimientos
            // 
            this.nmMesesEntreMantenimientos.Location = new System.Drawing.Point(408, 60);
            this.nmMesesEntreMantenimientos.Name = "nmMesesEntreMantenimientos";
            this.nmMesesEntreMantenimientos.Size = new System.Drawing.Size(61, 20);
            this.nmMesesEntreMantenimientos.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(14, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 26);
            this.label15.TabIndex = 130;
            this.label15.Text = "Tiempo respuesta Horas habiles";
            // 
            // nmHorasHabiles
            // 
            this.nmHorasHabiles.Location = new System.Drawing.Point(160, 95);
            this.nmHorasHabiles.Name = "nmHorasHabiles";
            this.nmHorasHabiles.Size = new System.Drawing.Size(61, 20);
            this.nmHorasHabiles.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(257, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 26);
            this.label14.TabIndex = 132;
            this.label14.Text = "Tiempo Respuesta Dias Habiles";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(257, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 27);
            this.label11.TabIndex = 123;
            this.label11.Text = "Porcentaje Cubierto del Precio de tiquetes";
            // 
            // chkIncluyeTiquetes
            // 
            this.chkIncluyeTiquetes.AutoSize = true;
            this.chkIncluyeTiquetes.BackColor = System.Drawing.Color.Transparent;
            this.chkIncluyeTiquetes.Location = new System.Drawing.Point(18, 138);
            this.chkIncluyeTiquetes.Name = "chkIncluyeTiquetes";
            this.chkIncluyeTiquetes.Size = new System.Drawing.Size(104, 17);
            this.chkIncluyeTiquetes.TabIndex = 14;
            this.chkIncluyeTiquetes.Text = "Incluye Tiquetes";
            this.chkIncluyeTiquetes.UseVisualStyleBackColor = false;
            // 
            // nmPorcentajePrecioTiquetes
            // 
            this.nmPorcentajePrecioTiquetes.Location = new System.Drawing.Point(408, 125);
            this.nmPorcentajePrecioTiquetes.Name = "nmPorcentajePrecioTiquetes";
            this.nmPorcentajePrecioTiquetes.Size = new System.Drawing.Size(61, 20);
            this.nmPorcentajePrecioTiquetes.TabIndex = 15;
            this.nmPorcentajePrecioTiquetes.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // chkIncluyeRepuestos
            // 
            this.chkIncluyeRepuestos.AutoSize = true;
            this.chkIncluyeRepuestos.BackColor = System.Drawing.Color.Transparent;
            this.chkIncluyeRepuestos.Location = new System.Drawing.Point(17, 164);
            this.chkIncluyeRepuestos.Name = "chkIncluyeRepuestos";
            this.chkIncluyeRepuestos.Size = new System.Drawing.Size(114, 17);
            this.chkIncluyeRepuestos.TabIndex = 12;
            this.chkIncluyeRepuestos.Text = "Incluye Repuestos";
            this.chkIncluyeRepuestos.UseVisualStyleBackColor = false;
            this.chkIncluyeRepuestos.CheckedChanged += new System.EventHandler(this.chkIncluyeRepuestos_CheckedChanged);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(15, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 20);
            this.label10.TabIndex = 121;
            this.label10.Text = "Repuestos incluidos";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtOtroSi);
            this.groupBox2.Controls.Add(this.grpConsumo);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtMontoContrato);
            this.groupBox2.Controls.Add(this.btnLimpiarModalidad);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.cmbTipoContrato);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtObervaciones);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.cmbModalidadContrato);
            this.groupBox2.Controls.Add(this.txtNroContrato);
            this.groupBox2.Controls.Add(this.cmbCliente);
            this.groupBox2.Controls.Add(this.calInicioContrato);
            this.groupBox2.Controls.Add(this.calFinContrato);
            this.groupBox2.Location = new System.Drawing.Point(6, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 492);
            this.groupBox2.TabIndex = 152;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion General";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 160;
            this.label1.Text = "Otro Si Numero";
            // 
            // txtOtroSi
            // 
            this.txtOtroSi.Location = new System.Drawing.Point(129, 49);
            this.txtOtroSi.MaxLength = 40;
            this.txtOtroSi.Name = "txtOtroSi";
            this.txtOtroSi.Size = new System.Drawing.Size(310, 20);
            this.txtOtroSi.TabIndex = 159;
            // 
            // grpConsumo
            // 
            this.grpConsumo.BackColor = System.Drawing.Color.Transparent;
            this.grpConsumo.Controls.Add(this.txtConsumoxLinea);
            this.grpConsumo.Controls.Add(this.chkTienePoliza);
            this.grpConsumo.Controls.Add(this.rdConsumoxLinea);
            this.grpConsumo.Controls.Add(this.rdconsumoMinimoGeneral);
            this.grpConsumo.Controls.Add(this.txtConsumoMinimo);
            this.grpConsumo.Location = new System.Drawing.Point(6, 255);
            this.grpConsumo.Name = "grpConsumo";
            this.grpConsumo.Size = new System.Drawing.Size(486, 65);
            this.grpConsumo.TabIndex = 17;
            this.grpConsumo.TabStop = false;
            this.grpConsumo.Text = "Consumo MInimo";
            // 
            // txtConsumoxLinea
            // 
            this.txtConsumoxLinea.Location = new System.Drawing.Point(339, 18);
            this.txtConsumoxLinea.Name = "txtConsumoxLinea";
            this.txtConsumoxLinea.Size = new System.Drawing.Size(141, 20);
            this.txtConsumoxLinea.TabIndex = 7;
            this.txtConsumoxLinea.TextChanged += new System.EventHandler(this.txtConsumoxLinea_TextChanged);
            // 
            // chkTienePoliza
            // 
            this.chkTienePoliza.AutoSize = true;
            this.chkTienePoliza.BackColor = System.Drawing.Color.Transparent;
            this.chkTienePoliza.Location = new System.Drawing.Point(10, 19);
            this.chkTienePoliza.Name = "chkTienePoliza";
            this.chkTienePoliza.Size = new System.Drawing.Size(106, 17);
            this.chkTienePoliza.TabIndex = 0;
            this.chkTienePoliza.Text = "Consumo Minimo";
            this.chkTienePoliza.UseVisualStyleBackColor = false;
            this.chkTienePoliza.CheckedChanged += new System.EventHandler(this.chkTienePoliza_CheckedChanged);
            // 
            // rdConsumoxLinea
            // 
            this.rdConsumoxLinea.AutoSize = true;
            this.rdConsumoxLinea.BackColor = System.Drawing.Color.Transparent;
            this.rdConsumoxLinea.Enabled = false;
            this.rdConsumoxLinea.Location = new System.Drawing.Point(178, 19);
            this.rdConsumoxLinea.Name = "rdConsumoxLinea";
            this.rdConsumoxLinea.Size = new System.Drawing.Size(143, 17);
            this.rdConsumoxLinea.TabIndex = 1;
            this.rdConsumoxLinea.TabStop = true;
            this.rdConsumoxLinea.Text = "Consumo MInimo x Linea";
            this.rdConsumoxLinea.UseVisualStyleBackColor = false;
            this.rdConsumoxLinea.CheckedChanged += new System.EventHandler(this.rdConsumoxLinea_CheckedChanged);
            // 
            // rdconsumoMinimoGeneral
            // 
            this.rdconsumoMinimoGeneral.AutoSize = true;
            this.rdconsumoMinimoGeneral.BackColor = System.Drawing.Color.Transparent;
            this.rdconsumoMinimoGeneral.Enabled = false;
            this.rdconsumoMinimoGeneral.Location = new System.Drawing.Point(178, 44);
            this.rdconsumoMinimoGeneral.Name = "rdconsumoMinimoGeneral";
            this.rdconsumoMinimoGeneral.Size = new System.Drawing.Size(146, 17);
            this.rdconsumoMinimoGeneral.TabIndex = 2;
            this.rdconsumoMinimoGeneral.TabStop = true;
            this.rdconsumoMinimoGeneral.Text = "Consumo MInimo General";
            this.rdconsumoMinimoGeneral.UseVisualStyleBackColor = false;
            this.rdconsumoMinimoGeneral.CheckedChanged += new System.EventHandler(this.rdconsumoMinimoGeneral_CheckedChanged);
            // 
            // txtConsumoMinimo
            // 
            this.txtConsumoMinimo.Enabled = false;
            this.txtConsumoMinimo.Location = new System.Drawing.Point(339, 43);
            this.txtConsumoMinimo.Name = "txtConsumoMinimo";
            this.txtConsumoMinimo.Size = new System.Drawing.Size(141, 20);
            this.txtConsumoMinimo.TabIndex = 3;
            this.txtConsumoMinimo.TextChanged += new System.EventHandler(this.txtConsumoMinimo_TextChanged);
            this.txtConsumoMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsumoMinimo_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(6, 232);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 13);
            this.label18.TabIndex = 158;
            this.label18.Text = "Monto Contrato";
            // 
            // txtMontoContrato
            // 
            this.txtMontoContrato.Location = new System.Drawing.Point(129, 232);
            this.txtMontoContrato.Name = "txtMontoContrato";
            this.txtMontoContrato.Size = new System.Drawing.Size(141, 20);
            this.txtMontoContrato.TabIndex = 150;
            this.txtMontoContrato.TextChanged += new System.EventHandler(this.txtMontoContrato_TextChanged);
            // 
            // btnLimpiarModalidad
            // 
            this.btnLimpiarModalidad.Location = new System.Drawing.Point(445, 112);
            this.btnLimpiarModalidad.Name = "btnLimpiarModalidad";
            this.btnLimpiarModalidad.Size = new System.Drawing.Size(19, 23);
            this.btnLimpiarModalidad.TabIndex = 149;
            this.btnLimpiarModalidad.Text = "x";
            this.btnLimpiarModalidad.UseVisualStyleBackColor = true;
            this.btnLimpiarModalidad.Click += new System.EventHandler(this.btnLimpiarModalidad_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(6, 82);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 13);
            this.label19.TabIndex = 157;
            this.label19.Text = "Tipo de Contrato";
            // 
            // cmbTipoContrato
            // 
            this.cmbTipoContrato.DataSource = this.dsSpx1;
            this.cmbTipoContrato.DisplayMember = "tipoContrato.nombreTipoContrato";
            this.cmbTipoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoContrato.FormattingEnabled = true;
            this.cmbTipoContrato.Location = new System.Drawing.Point(129, 82);
            this.cmbTipoContrato.MaxLength = 5;
            this.cmbTipoContrato.Name = "cmbTipoContrato";
            this.cmbTipoContrato.Size = new System.Drawing.Size(310, 21);
            this.cmbTipoContrato.TabIndex = 147;
            this.cmbTipoContrato.ValueMember = "tipoContrato.codTipoContrato";
            this.cmbTipoContrato.SelectedIndexChanged += new System.EventHandler(this.cmbTipoContrato_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(6, 204);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(97, 13);
            this.label20.TabIndex = 156;
            this.label20.Text = "Fecha Fin Contrato";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(6, 143);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 13);
            this.label21.TabIndex = 155;
            this.label21.Text = "Cliente";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(6, 113);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(116, 13);
            this.label22.TabIndex = 154;
            this.label22.Text = "Modalidad del Contrato";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(6, 176);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(108, 13);
            this.label23.TabIndex = 153;
            this.label23.Text = "Fecha Inicio Contrato";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(4, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 114;
            this.label9.Text = "Observaciones:";
            // 
            // txtObervaciones
            // 
            this.txtObervaciones.Location = new System.Drawing.Point(7, 339);
            this.txtObervaciones.MaxLength = 1073741823;
            this.txtObervaciones.Multiline = true;
            this.txtObervaciones.Name = "txtObervaciones";
            this.txtObervaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObervaciones.Size = new System.Drawing.Size(487, 56);
            this.txtObervaciones.TabIndex = 16;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnCancelar, "Cancelar");
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnCancelar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCancelar.Location = new System.Drawing.Point(470, 396);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(33, 33);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnGuardar, "Guardar");
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnGuardar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnGuardar.Location = new System.Drawing.Point(435, 396);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(33, 33);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(6, 19);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(87, 13);
            this.label24.TabIndex = 152;
            this.label24.Text = "Numero Contrato";
            // 
            // cmbModalidadContrato
            // 
            this.cmbModalidadContrato.DataSource = this.dsSpx1;
            this.cmbModalidadContrato.DisplayMember = "modalidadContrato.nombreModalidadContrato";
            this.cmbModalidadContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModalidadContrato.FormattingEnabled = true;
            this.cmbModalidadContrato.Location = new System.Drawing.Point(129, 113);
            this.cmbModalidadContrato.MaxLength = 5;
            this.cmbModalidadContrato.Name = "cmbModalidadContrato";
            this.cmbModalidadContrato.Size = new System.Drawing.Size(310, 21);
            this.cmbModalidadContrato.TabIndex = 3;
            this.cmbModalidadContrato.ValueMember = "modalidadContrato.codModalidadContrato";
            // 
            // txtNroContrato
            // 
            this.txtNroContrato.Location = new System.Drawing.Point(129, 19);
            this.txtNroContrato.MaxLength = 40;
            this.txtNroContrato.Name = "txtNroContrato";
            this.txtNroContrato.Size = new System.Drawing.Size(310, 20);
            this.txtNroContrato.TabIndex = 0;
            this.txtNroContrato.Validating += new System.ComponentModel.CancelEventHandler(this.txtNroContrato_Validating);
            // 
            // cmbCliente
            // 
            this.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCliente.DataSource = this.dsSpx1;
            this.cmbCliente.DisplayMember = "clientes.nombreCliente";
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(129, 143);
            this.cmbCliente.MaxLength = 20;
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(310, 21);
            this.cmbCliente.TabIndex = 1;
            this.cmbCliente.ValueMember = "clientes.nitCliente";
            // 
            // calInicioContrato
            // 
            // 
            // 
            // 
            this.calInicioContrato.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calInicioContrato.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioContrato.ButtonDropDown.Visible = true;
            this.calInicioContrato.Location = new System.Drawing.Point(129, 176);
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
            this.calInicioContrato.MonthCalendar.DisplayMonth = new System.DateTime(2008, 10, 1, 0, 0, 0, 0);
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
            this.calInicioContrato.Size = new System.Drawing.Size(200, 20);
            this.calInicioContrato.TabIndex = 133;
            this.calInicioContrato.Validating += new System.ComponentModel.CancelEventHandler(this.calInicioContrato_Validating);
            // 
            // calFinContrato
            // 
            // 
            // 
            // 
            this.calFinContrato.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calFinContrato.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinContrato.ButtonDropDown.Visible = true;
            this.calFinContrato.Location = new System.Drawing.Point(129, 204);
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
            this.calFinContrato.MonthCalendar.DisplayMonth = new System.DateTime(2008, 10, 1, 0, 0, 0, 0);
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
            this.calFinContrato.Size = new System.Drawing.Size(200, 20);
            this.calFinContrato.TabIndex = 134;
            this.calFinContrato.Validating += new System.ComponentModel.CancelEventHandler(this.calFinContrato_Validating);
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel1;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "Informacion General";
            // 
            // tipoContratoTableAdapter1
            // 
            this.tipoContratoTableAdapter1.ClearBeforeFill = true;
            // 
            // contratosTableAdapter1
            // 
            this.contratosTableAdapter1.ClearBeforeFill = true;
            // 
            // archivosxcontratoTableAdapter1
            // 
            this.archivosxcontratoTableAdapter1.ClearBeforeFill = true;
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // contratosxEquipoTableAdapter1
            // 
            this.contratosxEquipoTableAdapter1.ClearBeforeFill = true;
            // 
            // equiposTableAdapter1
            // 
            this.equiposTableAdapter1.ClearBeforeFill = true;
            // 
            // dsPlantillas1
            // 
            this.dsPlantillas1.DataSetName = "dsPlantillas";
            this.dsPlantillas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mantenimientosxContratoTableAdapter1
            // 
            this.mantenimientosxContratoTableAdapter1.ClearBeforeFill = true;
            // 
            // modalidadContratoTableAdapter1
            // 
            this.modalidadContratoTableAdapter1.ClearBeforeFill = true;
            // 
            // repuestosxContratosTableAdapter1
            // 
            this.repuestosxContratosTableAdapter1.ClearBeforeFill = true;
            // 
            // pltFechaSistemaTableAdapter1
            // 
            this.pltFechaSistemaTableAdapter1.ClearBeforeFill = true;
            // 
            // nmTopeCorrectivos
            // 
            this.nmTopeCorrectivos.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmTopeCorrectivos.Location = new System.Drawing.Point(411, 14);
            this.nmTopeCorrectivos.Name = "nmTopeCorrectivos";
            this.nmTopeCorrectivos.Size = new System.Drawing.Size(61, 21);
            this.nmTopeCorrectivos.TabIndex = 147;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(208, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 21);
            this.label6.TabIndex = 148;
            this.label6.Text = "Tope para Correctivos (0 para ilimitados)";
            // 
            // chkIncluyeCorrectivos
            // 
            this.chkIncluyeCorrectivos.AutoSize = true;
            this.chkIncluyeCorrectivos.BackColor = System.Drawing.Color.Transparent;
            this.chkIncluyeCorrectivos.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncluyeCorrectivos.Location = new System.Drawing.Point(18, 16);
            this.chkIncluyeCorrectivos.Name = "chkIncluyeCorrectivos";
            this.chkIncluyeCorrectivos.Size = new System.Drawing.Size(115, 17);
            this.chkIncluyeCorrectivos.TabIndex = 146;
            this.chkIncluyeCorrectivos.Text = "Incluye Correctivos";
            this.chkIncluyeCorrectivos.UseVisualStyleBackColor = false;
            // 
            // frmNuevoOtroSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1016, 569);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNuevoOtroSi";
            this.Text = "Anexo Otro Si";
            this.Load += new System.EventHandler(this.frmNuevoContrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.tabControlPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calCreacion)).EndInit();
            this.grpMantenimiento.ResumeLayout(false);
            this.grpMantenimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRepuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiasHabiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMantenimientosIncluidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMesesEntreMantenimientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmHorasHabiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPorcentajePrecioTiquetes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpConsumo.ResumeLayout(false);
            this.grpConsumo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calInicioContrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFinContrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTopeCorrectivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.tipoContratoTableAdapter tipoContratoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.contratosTableAdapter contratosTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.archivosxcontratoTableAdapter archivosxcontratoTableAdapter1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private SPControladoraDatos.dsSpxTableAdapters.clientesTableAdapter clientesTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.contratosxEquipoTableAdapter contratosxEquipoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter equiposTableAdapter1;
        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.ButtonX btnCancelar;
        private DevComponents.DotNetBar.ButtonX btnGuardar;
        private System.Windows.Forms.NumericUpDown nmMesesEntreMantenimientos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpConsumo;
        private System.Windows.Forms.CheckBox chkTienePoliza;
        private System.Windows.Forms.RadioButton rdConsumoxLinea;
        private System.Windows.Forms.RadioButton rdconsumoMinimoGeneral;
        private System.Windows.Forms.TextBox txtConsumoMinimo;
        private System.Windows.Forms.NumericUpDown nmMantenimientosIncluidos;
        private System.Windows.Forms.TextBox txtNroContrato;
        private System.Windows.Forms.TextBox txtObervaciones;
        private System.Windows.Forms.CheckBox chkIncluyeRepuestos;
        private System.Windows.Forms.CheckBox chkIncluyeTiquetes;
        private System.Windows.Forms.ComboBox cmbModalidadContrato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nmPorcentajePrecioTiquetes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nmDiasHabiles;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nmHorasHabiles;
        private System.Windows.Forms.Label label15;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFinContrato;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calInicioContrato;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private SPControladoraDatos.dsSpxTableAdapters.mantenimientosxContratoTableAdapter mantenimientosxContratoTableAdapter1;
        private System.Windows.Forms.TextBox txtConsumoxLinea;
        private System.Windows.Forms.ComboBox cmbTipoContrato;
        private System.Windows.Forms.Button btnLimpiarModalidad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtMontoContrato;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox grpMantenimiento;
        private DevComponents.DotNetBar.ButtonX btnDesvincularRepuesto;
        private DevComponents.DotNetBar.ButtonX btnAgregarRepuestos;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdRepuestos;
        private SPControladoraDatos.dsSpxTableAdapters.modalidadContratoTableAdapter modalidadContratoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.repuestosxContratosTableAdapter repuestosxContratosTableAdapter1;
        private DevComponents.DotNetBar.ButtonX btnModificarRepuesto;
        private SPControladoraDatos.dsPlantillas dsPlantillas1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOtroSi;
        private System.Windows.Forms.Label label2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calCreacion;
        private SPControladoraDatos.dsPlantillasTableAdapters.pltFechaSistemaTableAdapter pltFechaSistemaTableAdapter1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.NumericUpDown nmTopeCorrectivos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkIncluyeCorrectivos;
    }
}