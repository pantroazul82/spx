
using SPControladoraDatos.artefactos.SPXQuery.data;
using SPControladoraDatos.artefactos.SPXQuery.data.dsSPXQueryTableAdapters;

namespace SPControladoraDatos.artefactos.SPXQuery.frm.Reportes
{
    partial class frmSeleccionReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeleccionReporte));
            this.btnVerReporte = new DevComponents.DotNetBar.ButtonX();
            this.cmbOrden3 = new System.Windows.Forms.ComboBox();
            this.dsOrden3 = new dsSPXQuery();
            this.chkOrden3 = new System.Windows.Forms.CheckBox();
            this.cmbOrden1 = new System.Windows.Forms.ComboBox();
            this.dsOrden1 = new dsSPXQuery();
            this.chkOrden2 = new System.Windows.Forms.CheckBox();
            this.cmbOrden2 = new System.Windows.Forms.ComboBox();
            this.dsOrden2 = new dsSPXQuery();
            this.chkOrden1 = new System.Windows.Forms.CheckBox();
            this.btnQuitarFiltro = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregarFiltro = new DevComponents.DotNetBar.ButtonX();
            this.lblCal3 = new System.Windows.Forms.Label();
            this.lblCal2 = new System.Windows.Forms.Label();
            this.lblCal4 = new System.Windows.Forms.Label();
            this.lblCal1 = new System.Windows.Forms.Label();
            this.lblyf3 = new System.Windows.Forms.Label();
            this.cal1F3 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cal2F3 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtFloat2F3 = new System.Windows.Forms.TextBox();
            this.txtFloat1F3 = new System.Windows.Forms.TextBox();
            this.txtEntero2F3 = new System.Windows.Forms.TextBox();
            this.txtEntero1F3 = new System.Windows.Forms.TextBox();
            this.lblyf4 = new System.Windows.Forms.Label();
            this.cal1F4 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cal2F4 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtFloat2F4 = new System.Windows.Forms.TextBox();
            this.txtFloat1F4 = new System.Windows.Forms.TextBox();
            this.txtEntero2F4 = new System.Windows.Forms.TextBox();
            this.txtEntero1F4 = new System.Windows.Forms.TextBox();
            this.lblyf2 = new System.Windows.Forms.Label();
            this.cal1F2 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cal2f2 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtFloat2F2 = new System.Windows.Forms.TextBox();
            this.txtFloat1F2 = new System.Windows.Forms.TextBox();
            this.txtEntero2F2 = new System.Windows.Forms.TextBox();
            this.txtEntero1F2 = new System.Windows.Forms.TextBox();
            this.lblyf1 = new System.Windows.Forms.Label();
            this.cmbFiltro4 = new System.Windows.Forms.ComboBox();
            this.dsFiltro4 = new dsSPXQuery();
            this.cmbFiltro3 = new System.Windows.Forms.ComboBox();
            this.dsFiltro3 = new dsSPXQuery();
            this.cmbFiltro2 = new System.Windows.Forms.ComboBox();
            this.dsFiltro2 = new dsSPXQuery();
            this.cal1F1 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cal2f1 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtFloat2F1 = new System.Windows.Forms.TextBox();
            this.txtFloat1F1 = new System.Windows.Forms.TextBox();
            this.txtEntero2F1 = new System.Windows.Forms.TextBox();
            this.txtEntero1F1 = new System.Windows.Forms.TextBox();
            this.chkFiltro4 = new System.Windows.Forms.CheckBox();
            this.chkFiltro3 = new System.Windows.Forms.CheckBox();
            this.chkFilltro2 = new System.Windows.Forms.CheckBox();
            this.chkFiltro1 = new System.Windows.Forms.CheckBox();
            this.cmbCampo1 = new System.Windows.Forms.ComboBox();
            this.dsFiltro1 = new dsSPXQuery();
            this.cmbOperador4 = new System.Windows.Forms.ComboBox();
            this.cmbOperador3 = new System.Windows.Forms.ComboBox();
            this.cmbOperador2 = new System.Windows.Forms.ComboBox();
            this.cmbOperador1 = new System.Windows.Forms.ComboBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lbloperador = new System.Windows.Forms.Label();
            this.lblvalor = new System.Windows.Forms.Label();
            this.txtFiltro4 = new System.Windows.Forms.TextBox();
            this.txtFiltro3 = new System.Windows.Forms.TextBox();
            this.txtFiltro2 = new System.Windows.Forms.TextBox();
            this.txtFiltro1 = new System.Windows.Forms.TextBox();
            this.grdRpt = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsSPXQuery2 = new dsSPXQuery();
            this.dsSPXQuery1 = new dsSPXQuery();
            this.c1Report1 = new C1.C1Report.C1Report();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSep2Orden = new System.Windows.Forms.Label();
            this.lblSep1Orden = new System.Windows.Forms.Label();
            this.btnQuitarOrden = new DevComponents.DotNetBar.ButtonX();
            this.cmbOrden3Estilos = new System.Windows.Forms.ComboBox();
            this.btnAgregarOrden = new DevComponents.DotNetBar.ButtonX();
            this.cmbOrden2Estilos = new System.Windows.Forms.ComboBox();
            this.cmbOrden1Estilos = new System.Windows.Forms.ComboBox();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.lblEstado = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenExcel = new DevComponents.DotNetBar.ButtonX();
            this.grdToolExcel = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.rptTableAdapter1 = new data.dsSPXQueryTableAdapters.rptTableAdapter();
            this.tipofiltro_query_rptTableAdapter1 = new data.cls.clsTtipofiltro_query_rpt();
            this.rpt_parametrosTableAdapter1 = new data.dsSPXQueryTableAdapters.rpt_parametrosTableAdapter();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrden3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrden1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrden2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cal1F3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cal2F3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cal1F4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cal2F4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cal1F2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cal2f2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFiltro4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFiltro3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFiltro2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cal1F1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cal2f1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFiltro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRpt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXQuery2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXQuery1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Report1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdToolExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerReporte
            // 
            this.btnVerReporte.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVerReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnVerReporte.Image")));
            this.btnVerReporte.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnVerReporte.Location = new System.Drawing.Point(616, 239);
            this.btnVerReporte.Name = "btnVerReporte";
            this.btnVerReporte.Size = new System.Drawing.Size(71, 70);
            this.btnVerReporte.TabIndex = 70;
            this.btnVerReporte.Text = "Ver Reporte";
            this.btnVerReporte.Click += new System.EventHandler(this.btnVerReporte_Click);
            // 
            // cmbOrden3
            // 
            this.cmbOrden3.DataSource = this.dsOrden3;
            this.cmbOrden3.DisplayMember = "rpt_parametros.nombre";
            this.cmbOrden3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrden3.Location = new System.Drawing.Point(529, 17);
            this.cmbOrden3.Name = "cmbOrden3";
            this.cmbOrden3.Size = new System.Drawing.Size(150, 21);
            this.cmbOrden3.TabIndex = 65;
            this.cmbOrden3.ValueMember = "rpt_parametros.campo";
            this.cmbOrden3.Visible = false;
            // 
            // dsOrden3
            // 
            this.dsOrden3.DataSetName = "dsSPXQuery";
            this.dsOrden3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chkOrden3
            // 
            this.chkOrden3.AutoSize = true;
            this.chkOrden3.BackColor = System.Drawing.Color.Transparent;
            this.chkOrden3.Location = new System.Drawing.Point(529, 44);
            this.chkOrden3.Name = "chkOrden3";
            this.chkOrden3.Size = new System.Drawing.Size(73, 17);
            this.chkOrden3.TabIndex = 68;
            this.chkOrden3.Text = "Ordenar 3";
            this.chkOrden3.UseVisualStyleBackColor = false;
            this.chkOrden3.Visible = false;
            // 
            // cmbOrden1
            // 
            this.cmbOrden1.DataSource = this.dsOrden1;
            this.cmbOrden1.DisplayMember = "rpt_parametros.nombre";
            this.cmbOrden1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrden1.Location = new System.Drawing.Point(15, 17);
            this.cmbOrden1.Name = "cmbOrden1";
            this.cmbOrden1.Size = new System.Drawing.Size(150, 21);
            this.cmbOrden1.TabIndex = 50;
            this.cmbOrden1.ValueMember = "rpt_parametros.campo";
            this.cmbOrden1.Visible = false;
            // 
            // dsOrden1
            // 
            this.dsOrden1.DataSetName = "dsSPXQuery";
            this.dsOrden1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chkOrden2
            // 
            this.chkOrden2.AutoSize = true;
            this.chkOrden2.BackColor = System.Drawing.Color.Transparent;
            this.chkOrden2.Location = new System.Drawing.Point(271, 44);
            this.chkOrden2.Name = "chkOrden2";
            this.chkOrden2.Size = new System.Drawing.Size(73, 17);
            this.chkOrden2.TabIndex = 67;
            this.chkOrden2.Text = "Ordenar 2";
            this.chkOrden2.UseVisualStyleBackColor = false;
            this.chkOrden2.Visible = false;
            // 
            // cmbOrden2
            // 
            this.cmbOrden2.DataSource = this.dsOrden2;
            this.cmbOrden2.DisplayMember = "rpt_parametros.nombre";
            this.cmbOrden2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrden2.Location = new System.Drawing.Point(271, 17);
            this.cmbOrden2.Name = "cmbOrden2";
            this.cmbOrden2.Size = new System.Drawing.Size(150, 21);
            this.cmbOrden2.TabIndex = 64;
            this.cmbOrden2.ValueMember = "rpt_parametros.campo";
            this.cmbOrden2.Visible = false;
            // 
            // dsOrden2
            // 
            this.dsOrden2.DataSetName = "dsSPXQuery";
            this.dsOrden2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chkOrden1
            // 
            this.chkOrden1.AutoSize = true;
            this.chkOrden1.BackColor = System.Drawing.Color.Transparent;
            this.chkOrden1.Location = new System.Drawing.Point(15, 48);
            this.chkOrden1.Name = "chkOrden1";
            this.chkOrden1.Size = new System.Drawing.Size(73, 17);
            this.chkOrden1.TabIndex = 66;
            this.chkOrden1.Text = "Ordenar 1";
            this.chkOrden1.UseVisualStyleBackColor = false;
            this.chkOrden1.Visible = false;
            // 
            // btnQuitarFiltro
            // 
            this.btnQuitarFiltro.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnQuitarFiltro, "Quitar Filtro");
            this.btnQuitarFiltro.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitarFiltro.Image")));
            this.btnQuitarFiltro.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnQuitarFiltro.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnQuitarFiltro.Location = new System.Drawing.Point(55, 13);
            this.btnQuitarFiltro.Name = "btnQuitarFiltro";
            this.btnQuitarFiltro.Size = new System.Drawing.Size(33, 33);
            this.btnQuitarFiltro.TabIndex = 94;
            this.btnQuitarFiltro.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btnAgregarFiltro
            // 
            this.btnAgregarFiltro.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnAgregarFiltro, "Agregar Filtro");
            this.btnAgregarFiltro.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarFiltro.Image")));
            this.btnAgregarFiltro.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnAgregarFiltro.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAgregarFiltro.Location = new System.Drawing.Point(16, 13);
            this.btnAgregarFiltro.Name = "btnAgregarFiltro";
            this.btnAgregarFiltro.Size = new System.Drawing.Size(33, 33);
            this.btnAgregarFiltro.TabIndex = 93;
            this.btnAgregarFiltro.Click += new System.EventHandler(this.btnAgregarFiltro_Click);
            // 
            // lblCal3
            // 
            this.lblCal3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCal3.Location = new System.Drawing.Point(576, 3);
            this.lblCal3.Name = "lblCal3";
            this.lblCal3.Size = new System.Drawing.Size(20, 16);
            this.lblCal3.TabIndex = 92;
            this.lblCal3.Text = "y";
            // 
            // lblCal2
            // 
            this.lblCal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCal2.Location = new System.Drawing.Point(577, 3);
            this.lblCal2.Name = "lblCal2";
            this.lblCal2.Size = new System.Drawing.Size(20, 16);
            this.lblCal2.TabIndex = 91;
            this.lblCal2.Text = "y";
            // 
            // lblCal4
            // 
            this.lblCal4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCal4.Location = new System.Drawing.Point(577, 3);
            this.lblCal4.Name = "lblCal4";
            this.lblCal4.Size = new System.Drawing.Size(20, 16);
            this.lblCal4.TabIndex = 90;
            this.lblCal4.Text = "y";
            // 
            // lblCal1
            // 
            this.lblCal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCal1.Location = new System.Drawing.Point(623, 4);
            this.lblCal1.Name = "lblCal1";
            this.lblCal1.Size = new System.Drawing.Size(20, 16);
            this.lblCal1.TabIndex = 89;
            this.lblCal1.Text = "y";
            // 
            // lblyf3
            // 
            this.lblyf3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyf3.Location = new System.Drawing.Point(437, 3);
            this.lblyf3.Name = "lblyf3";
            this.lblyf3.Size = new System.Drawing.Size(11, 17);
            this.lblyf3.TabIndex = 88;
            this.lblyf3.Text = "y";
            // 
            // cal1F3
            // 
            // 
            // 
            // 
            this.cal1F3.BackgroundStyle.Class = "DateTimeInputBackground";
            this.cal1F3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cal1F3.ButtonDropDown.Visible = true;
            this.cal1F3.Location = new System.Drawing.Point(372, 3);
            // 
            // 
            // 
            this.cal1F3.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.cal1F3.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.cal1F3.MonthCalendar.BackgroundStyle.Class = "";
            this.cal1F3.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cal1F3.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.cal1F3.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.cal1F3.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.cal1F3.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.cal1F3.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.cal1F3.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.cal1F3.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.cal1F3.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.cal1F3.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cal1F3.MonthCalendar.DisplayMonth = new System.DateTime(2008, 11, 1, 0, 0, 0, 0);
            this.cal1F3.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.cal1F3.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.cal1F3.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.cal1F3.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.cal1F3.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.cal1F3.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.cal1F3.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.cal1F3.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cal1F3.MonthCalendar.TodayButtonVisible = true;
            this.cal1F3.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.cal1F3.Name = "cal1F3";
            this.cal1F3.Size = new System.Drawing.Size(200, 20);
            this.cal1F3.TabIndex = 87;
            // 
            // cal2F3
            // 
            // 
            // 
            // 
            this.cal2F3.BackgroundStyle.Class = "DateTimeInputBackground";
            this.cal2F3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cal2F3.ButtonDropDown.Visible = true;
            this.cal2F3.Location = new System.Drawing.Point(602, 3);
            // 
            // 
            // 
            this.cal2F3.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.cal2F3.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.cal2F3.MonthCalendar.BackgroundStyle.Class = "";
            this.cal2F3.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cal2F3.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.cal2F3.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.cal2F3.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.cal2F3.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.cal2F3.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.cal2F3.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.cal2F3.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.cal2F3.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.cal2F3.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cal2F3.MonthCalendar.DisplayMonth = new System.DateTime(2008, 11, 1, 0, 0, 0, 0);
            this.cal2F3.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.cal2F3.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.cal2F3.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.cal2F3.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.cal2F3.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.cal2F3.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.cal2F3.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.cal2F3.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cal2F3.MonthCalendar.TodayButtonVisible = true;
            this.cal2F3.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.cal2F3.Name = "cal2F3";
            this.cal2F3.Size = new System.Drawing.Size(200, 20);
            this.cal2F3.TabIndex = 86;
            // 
            // txtFloat2F3
            // 
            this.txtFloat2F3.Location = new System.Drawing.Point(451, 3);
            this.txtFloat2F3.Name = "txtFloat2F3";
            this.txtFloat2F3.Size = new System.Drawing.Size(59, 20);
            this.txtFloat2F3.TabIndex = 85;
            this.txtFloat2F3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFloat1F1_KeyPress);
            // 
            // txtFloat1F3
            // 
            this.txtFloat1F3.Location = new System.Drawing.Point(372, 3);
            this.txtFloat1F3.Name = "txtFloat1F3";
            this.txtFloat1F3.Size = new System.Drawing.Size(59, 20);
            this.txtFloat1F3.TabIndex = 84;
            this.txtFloat1F3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFloat1F1_KeyPress);
            // 
            // txtEntero2F3
            // 
            this.txtEntero2F3.Location = new System.Drawing.Point(451, 3);
            this.txtEntero2F3.Name = "txtEntero2F3";
            this.txtEntero2F3.Size = new System.Drawing.Size(59, 20);
            this.txtEntero2F3.TabIndex = 83;
            this.txtEntero2F3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntero1F1_KeyPress);
            // 
            // txtEntero1F3
            // 
            this.txtEntero1F3.Location = new System.Drawing.Point(372, 3);
            this.txtEntero1F3.Name = "txtEntero1F3";
            this.txtEntero1F3.Size = new System.Drawing.Size(59, 20);
            this.txtEntero1F3.TabIndex = 82;
            this.txtEntero1F3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntero1F1_KeyPress);
            // 
            // lblyf4
            // 
            this.lblyf4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyf4.Location = new System.Drawing.Point(439, 3);
            this.lblyf4.Name = "lblyf4";
            this.lblyf4.Size = new System.Drawing.Size(11, 17);
            this.lblyf4.TabIndex = 81;
            this.lblyf4.Text = "y";
            // 
            // cal1F4
            // 
            // 
            // 
            // 
            this.cal1F4.BackgroundStyle.Class = "DateTimeInputBackground";
            this.cal1F4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cal1F4.ButtonDropDown.Visible = true;
            this.cal1F4.Location = new System.Drawing.Point(373, 3);
            // 
            // 
            // 
            this.cal1F4.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.cal1F4.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.cal1F4.MonthCalendar.BackgroundStyle.Class = "";
            this.cal1F4.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cal1F4.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.cal1F4.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.cal1F4.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.cal1F4.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.cal1F4.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.cal1F4.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.cal1F4.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.cal1F4.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.cal1F4.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cal1F4.MonthCalendar.DisplayMonth = new System.DateTime(2008, 11, 1, 0, 0, 0, 0);
            this.cal1F4.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.cal1F4.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.cal1F4.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.cal1F4.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.cal1F4.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.cal1F4.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.cal1F4.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.cal1F4.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cal1F4.MonthCalendar.TodayButtonVisible = true;
            this.cal1F4.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.cal1F4.Name = "cal1F4";
            this.cal1F4.Size = new System.Drawing.Size(200, 20);
            this.cal1F4.TabIndex = 80;
            // 
            // cal2F4
            // 
            // 
            // 
            // 
            this.cal2F4.BackgroundStyle.Class = "DateTimeInputBackground";
            this.cal2F4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cal2F4.ButtonDropDown.Visible = true;
            this.cal2F4.Location = new System.Drawing.Point(601, 3);
            // 
            // 
            // 
            this.cal2F4.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.cal2F4.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.cal2F4.MonthCalendar.BackgroundStyle.Class = "";
            this.cal2F4.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cal2F4.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.cal2F4.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.cal2F4.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.cal2F4.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.cal2F4.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.cal2F4.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.cal2F4.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.cal2F4.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.cal2F4.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cal2F4.MonthCalendar.DisplayMonth = new System.DateTime(2008, 11, 1, 0, 0, 0, 0);
            this.cal2F4.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.cal2F4.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.cal2F4.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.cal2F4.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.cal2F4.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.cal2F4.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.cal2F4.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.cal2F4.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cal2F4.MonthCalendar.TodayButtonVisible = true;
            this.cal2F4.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.cal2F4.Name = "cal2F4";
            this.cal2F4.Size = new System.Drawing.Size(200, 20);
            this.cal2F4.TabIndex = 79;
            // 
            // txtFloat2F4
            // 
            this.txtFloat2F4.Location = new System.Drawing.Point(453, 3);
            this.txtFloat2F4.Name = "txtFloat2F4";
            this.txtFloat2F4.Size = new System.Drawing.Size(59, 20);
            this.txtFloat2F4.TabIndex = 78;
            this.txtFloat2F4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFloat1F1_KeyPress);
            // 
            // txtFloat1F4
            // 
            this.txtFloat1F4.Location = new System.Drawing.Point(373, 3);
            this.txtFloat1F4.Name = "txtFloat1F4";
            this.txtFloat1F4.Size = new System.Drawing.Size(59, 20);
            this.txtFloat1F4.TabIndex = 77;
            this.txtFloat1F4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFloat1F1_KeyPress);
            // 
            // txtEntero2F4
            // 
            this.txtEntero2F4.Location = new System.Drawing.Point(453, 3);
            this.txtEntero2F4.Name = "txtEntero2F4";
            this.txtEntero2F4.Size = new System.Drawing.Size(59, 20);
            this.txtEntero2F4.TabIndex = 76;
            this.txtEntero2F4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntero1F1_KeyPress);
            // 
            // txtEntero1F4
            // 
            this.txtEntero1F4.Location = new System.Drawing.Point(373, 3);
            this.txtEntero1F4.Name = "txtEntero1F4";
            this.txtEntero1F4.Size = new System.Drawing.Size(59, 20);
            this.txtEntero1F4.TabIndex = 75;
            this.txtEntero1F4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntero1F1_KeyPress);
            // 
            // lblyf2
            // 
            this.lblyf2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyf2.Location = new System.Drawing.Point(437, 3);
            this.lblyf2.Name = "lblyf2";
            this.lblyf2.Size = new System.Drawing.Size(11, 17);
            this.lblyf2.TabIndex = 74;
            this.lblyf2.Text = "y";
            // 
            // cal1F2
            // 
            // 
            // 
            // 
            this.cal1F2.BackgroundStyle.Class = "DateTimeInputBackground";
            this.cal1F2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cal1F2.ButtonDropDown.Visible = true;
            this.cal1F2.Location = new System.Drawing.Point(370, 3);
            // 
            // 
            // 
            this.cal1F2.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.cal1F2.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.cal1F2.MonthCalendar.BackgroundStyle.Class = "";
            this.cal1F2.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cal1F2.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.cal1F2.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.cal1F2.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.cal1F2.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.cal1F2.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.cal1F2.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.cal1F2.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.cal1F2.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.cal1F2.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cal1F2.MonthCalendar.DisplayMonth = new System.DateTime(2008, 11, 1, 0, 0, 0, 0);
            this.cal1F2.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.cal1F2.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.cal1F2.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.cal1F2.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.cal1F2.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.cal1F2.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.cal1F2.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.cal1F2.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cal1F2.MonthCalendar.TodayButtonVisible = true;
            this.cal1F2.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.cal1F2.Name = "cal1F2";
            this.cal1F2.Size = new System.Drawing.Size(200, 20);
            this.cal1F2.TabIndex = 73;
            // 
            // cal2f2
            // 
            // 
            // 
            // 
            this.cal2f2.BackgroundStyle.Class = "DateTimeInputBackground";
            this.cal2f2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cal2f2.ButtonDropDown.Visible = true;
            this.cal2f2.Location = new System.Drawing.Point(603, 3);
            // 
            // 
            // 
            this.cal2f2.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.cal2f2.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.cal2f2.MonthCalendar.BackgroundStyle.Class = "";
            this.cal2f2.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cal2f2.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.cal2f2.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.cal2f2.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.cal2f2.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.cal2f2.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.cal2f2.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.cal2f2.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.cal2f2.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.cal2f2.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cal2f2.MonthCalendar.DisplayMonth = new System.DateTime(2008, 11, 1, 0, 0, 0, 0);
            this.cal2f2.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.cal2f2.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.cal2f2.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.cal2f2.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.cal2f2.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.cal2f2.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.cal2f2.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.cal2f2.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cal2f2.MonthCalendar.TodayButtonVisible = true;
            this.cal2f2.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.cal2f2.Name = "cal2f2";
            this.cal2f2.Size = new System.Drawing.Size(200, 20);
            this.cal2f2.TabIndex = 72;
            // 
            // txtFloat2F2
            // 
            this.txtFloat2F2.Location = new System.Drawing.Point(451, 3);
            this.txtFloat2F2.Name = "txtFloat2F2";
            this.txtFloat2F2.Size = new System.Drawing.Size(59, 20);
            this.txtFloat2F2.TabIndex = 71;
            this.txtFloat2F2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFloat1F1_KeyPress);
            // 
            // txtFloat1F2
            // 
            this.txtFloat1F2.Location = new System.Drawing.Point(370, 3);
            this.txtFloat1F2.Name = "txtFloat1F2";
            this.txtFloat1F2.Size = new System.Drawing.Size(59, 20);
            this.txtFloat1F2.TabIndex = 70;
            this.txtFloat1F2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFloat1F1_KeyPress);
            // 
            // txtEntero2F2
            // 
            this.txtEntero2F2.Location = new System.Drawing.Point(451, 3);
            this.txtEntero2F2.Name = "txtEntero2F2";
            this.txtEntero2F2.Size = new System.Drawing.Size(59, 20);
            this.txtEntero2F2.TabIndex = 69;
            this.txtEntero2F2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntero1F1_KeyPress);
            // 
            // txtEntero1F2
            // 
            this.txtEntero1F2.Location = new System.Drawing.Point(370, 3);
            this.txtEntero1F2.Name = "txtEntero1F2";
            this.txtEntero1F2.Size = new System.Drawing.Size(59, 20);
            this.txtEntero1F2.TabIndex = 68;
            this.txtEntero1F2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntero1F1_KeyPress);
            // 
            // lblyf1
            // 
            this.lblyf1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyf1.Location = new System.Drawing.Point(437, 4);
            this.lblyf1.Name = "lblyf1";
            this.lblyf1.Size = new System.Drawing.Size(11, 17);
            this.lblyf1.TabIndex = 67;
            this.lblyf1.Text = "y";
            // 
            // cmbFiltro4
            // 
            this.cmbFiltro4.DataSource = this.dsFiltro4;
            this.cmbFiltro4.DisplayMember = "rpt_parametros.nombre";
            this.cmbFiltro4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro4.Location = new System.Drawing.Point(12, 3);
            this.cmbFiltro4.Name = "cmbFiltro4";
            this.cmbFiltro4.Size = new System.Drawing.Size(215, 21);
            this.cmbFiltro4.TabIndex = 66;
            this.cmbFiltro4.ValueMember = "rpt_parametros.campo";
            this.cmbFiltro4.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro4_SelectedIndexChanged);
            // 
            // dsFiltro4
            // 
            this.dsFiltro4.DataSetName = "dsSPXQuery";
            this.dsFiltro4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbFiltro3
            // 
            this.cmbFiltro3.DataSource = this.dsFiltro3;
            this.cmbFiltro3.DisplayMember = "rpt_parametros.nombre";
            this.cmbFiltro3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro3.Location = new System.Drawing.Point(10, 3);
            this.cmbFiltro3.Name = "cmbFiltro3";
            this.cmbFiltro3.Size = new System.Drawing.Size(215, 21);
            this.cmbFiltro3.TabIndex = 65;
            this.cmbFiltro3.ValueMember = "rpt_parametros.campo";
            this.cmbFiltro3.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro3_SelectedIndexChanged);
            // 
            // dsFiltro3
            // 
            this.dsFiltro3.DataSetName = "dsSPXQuery";
            this.dsFiltro3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbFiltro2
            // 
            this.cmbFiltro2.DataSource = this.dsFiltro2;
            this.cmbFiltro2.DisplayMember = "rpt_parametros.nombre";
            this.cmbFiltro2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro2.Location = new System.Drawing.Point(10, 3);
            this.cmbFiltro2.Name = "cmbFiltro2";
            this.cmbFiltro2.Size = new System.Drawing.Size(215, 21);
            this.cmbFiltro2.TabIndex = 64;
            this.cmbFiltro2.ValueMember = "rpt_parametros.campo";
            this.cmbFiltro2.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro2_SelectedIndexChanged);
            // 
            // dsFiltro2
            // 
            this.dsFiltro2.DataSetName = "dsSPXQuery";
            this.dsFiltro2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cal1F1
            // 
            // 
            // 
            // 
            this.cal1F1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.cal1F1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cal1F1.ButtonDropDown.Visible = true;
            this.cal1F1.Location = new System.Drawing.Point(372, 4);
            // 
            // 
            // 
            this.cal1F1.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.cal1F1.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.cal1F1.MonthCalendar.BackgroundStyle.Class = "";
            this.cal1F1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cal1F1.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.cal1F1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.cal1F1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.cal1F1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.cal1F1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.cal1F1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.cal1F1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.cal1F1.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.cal1F1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cal1F1.MonthCalendar.DisplayMonth = new System.DateTime(2008, 11, 1, 0, 0, 0, 0);
            this.cal1F1.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.cal1F1.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.cal1F1.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.cal1F1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.cal1F1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.cal1F1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.cal1F1.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.cal1F1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cal1F1.MonthCalendar.TodayButtonVisible = true;
            this.cal1F1.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.cal1F1.Name = "cal1F1";
            this.cal1F1.Size = new System.Drawing.Size(200, 20);
            this.cal1F1.TabIndex = 63;
            // 
            // cal2f1
            // 
            // 
            // 
            // 
            this.cal2f1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.cal2f1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cal2f1.ButtonDropDown.Visible = true;
            this.cal2f1.Location = new System.Drawing.Point(601, 4);
            // 
            // 
            // 
            this.cal2f1.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.cal2f1.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.cal2f1.MonthCalendar.BackgroundStyle.Class = "";
            this.cal2f1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cal2f1.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.cal2f1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.cal2f1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.cal2f1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.cal2f1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.cal2f1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.cal2f1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.cal2f1.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.cal2f1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cal2f1.MonthCalendar.DisplayMonth = new System.DateTime(2008, 11, 1, 0, 0, 0, 0);
            this.cal2f1.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.cal2f1.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.cal2f1.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.cal2f1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.cal2f1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.cal2f1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.cal2f1.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.cal2f1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cal2f1.MonthCalendar.TodayButtonVisible = true;
            this.cal2f1.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.cal2f1.Name = "cal2f1";
            this.cal2f1.Size = new System.Drawing.Size(200, 20);
            this.cal2f1.TabIndex = 62;
            // 
            // txtFloat2F1
            // 
            this.txtFloat2F1.Location = new System.Drawing.Point(451, 4);
            this.txtFloat2F1.Name = "txtFloat2F1";
            this.txtFloat2F1.Size = new System.Drawing.Size(59, 20);
            this.txtFloat2F1.TabIndex = 61;
            this.txtFloat2F1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFloat1F1_KeyPress);
            // 
            // txtFloat1F1
            // 
            this.txtFloat1F1.Location = new System.Drawing.Point(372, 4);
            this.txtFloat1F1.Name = "txtFloat1F1";
            this.txtFloat1F1.Size = new System.Drawing.Size(59, 20);
            this.txtFloat1F1.TabIndex = 60;
            this.txtFloat1F1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFloat1F1_KeyPress);
            // 
            // txtEntero2F1
            // 
            this.txtEntero2F1.Location = new System.Drawing.Point(451, 4);
            this.txtEntero2F1.Name = "txtEntero2F1";
            this.txtEntero2F1.Size = new System.Drawing.Size(59, 20);
            this.txtEntero2F1.TabIndex = 59;
            this.txtEntero2F1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntero1F1_KeyPress);
            // 
            // txtEntero1F1
            // 
            this.txtEntero1F1.Location = new System.Drawing.Point(372, 4);
            this.txtEntero1F1.Name = "txtEntero1F1";
            this.txtEntero1F1.Size = new System.Drawing.Size(59, 20);
            this.txtEntero1F1.TabIndex = 58;
            this.txtEntero1F1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntero1F1_KeyPress);
            // 
            // chkFiltro4
            // 
            this.chkFiltro4.AutoSize = true;
            this.chkFiltro4.Location = new System.Drawing.Point(11, 28);
            this.chkFiltro4.Name = "chkFiltro4";
            this.chkFiltro4.Size = new System.Drawing.Size(57, 17);
            this.chkFiltro4.TabIndex = 57;
            this.chkFiltro4.Text = "Filtro 4";
            this.chkFiltro4.UseVisualStyleBackColor = true;
            this.chkFiltro4.Visible = false;
            // 
            // chkFiltro3
            // 
            this.chkFiltro3.AutoSize = true;
            this.chkFiltro3.Location = new System.Drawing.Point(12, 20);
            this.chkFiltro3.Name = "chkFiltro3";
            this.chkFiltro3.Size = new System.Drawing.Size(57, 17);
            this.chkFiltro3.TabIndex = 56;
            this.chkFiltro3.Text = "Filtro 3";
            this.chkFiltro3.UseVisualStyleBackColor = true;
            this.chkFiltro3.Visible = false;
            // 
            // chkFilltro2
            // 
            this.chkFilltro2.AutoSize = true;
            this.chkFilltro2.Location = new System.Drawing.Point(10, 23);
            this.chkFilltro2.Name = "chkFilltro2";
            this.chkFilltro2.Size = new System.Drawing.Size(57, 17);
            this.chkFilltro2.TabIndex = 55;
            this.chkFilltro2.Text = "Filtro 2";
            this.chkFilltro2.UseVisualStyleBackColor = true;
            this.chkFilltro2.Visible = false;
            // 
            // chkFiltro1
            // 
            this.chkFiltro1.AutoSize = true;
            this.chkFiltro1.Location = new System.Drawing.Point(10, 23);
            this.chkFiltro1.Name = "chkFiltro1";
            this.chkFiltro1.Size = new System.Drawing.Size(57, 17);
            this.chkFiltro1.TabIndex = 54;
            this.chkFiltro1.Text = "Filtro 1";
            this.chkFiltro1.UseVisualStyleBackColor = true;
            this.chkFiltro1.Visible = false;
            // 
            // cmbCampo1
            // 
            this.cmbCampo1.DataSource = this.dsFiltro1;
            this.cmbCampo1.DisplayMember = "rpt_parametros.nombre";
            this.cmbCampo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampo1.Location = new System.Drawing.Point(10, 4);
            this.cmbCampo1.Name = "cmbCampo1";
            this.cmbCampo1.Size = new System.Drawing.Size(215, 21);
            this.cmbCampo1.TabIndex = 50;
            this.cmbCampo1.ValueMember = "rpt_parametros.campo";
            this.cmbCampo1.SelectedIndexChanged += new System.EventHandler(this.cmbCampo1_SelectedIndexChanged);
            // 
            // dsFiltro1
            // 
            this.dsFiltro1.DataSetName = "dsSPXQuery";
            this.dsFiltro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbOperador4
            // 
            this.cmbOperador4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperador4.Items.AddRange(new object[] {
            "LIKE",
            "=",
            "<",
            ">",
            "<=",
            ">=",
            "<>",
            "IS",
            "IS NOT"});
            this.cmbOperador4.Location = new System.Drawing.Point(233, 3);
            this.cmbOperador4.Name = "cmbOperador4";
            this.cmbOperador4.Size = new System.Drawing.Size(133, 21);
            this.cmbOperador4.TabIndex = 49;
            this.cmbOperador4.SelectedIndexChanged += new System.EventHandler(this.cmbOperador4_SelectedIndexChanged);
            // 
            // cmbOperador3
            // 
            this.cmbOperador3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperador3.Items.AddRange(new object[] {
            "LIKE",
            "=",
            "<",
            ">",
            "<=",
            ">=",
            "<>",
            "IS",
            "IS NOT"});
            this.cmbOperador3.Location = new System.Drawing.Point(231, 3);
            this.cmbOperador3.Name = "cmbOperador3";
            this.cmbOperador3.Size = new System.Drawing.Size(133, 21);
            this.cmbOperador3.TabIndex = 48;
            this.cmbOperador3.SelectedIndexChanged += new System.EventHandler(this.cmbOperador3_SelectedIndexChanged);
            // 
            // cmbOperador2
            // 
            this.cmbOperador2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperador2.Items.AddRange(new object[] {
            "LIKE",
            "=",
            "<",
            ">",
            "<=",
            ">=",
            "<>",
            "IS",
            "IS NOT"});
            this.cmbOperador2.Location = new System.Drawing.Point(231, 3);
            this.cmbOperador2.Name = "cmbOperador2";
            this.cmbOperador2.Size = new System.Drawing.Size(133, 21);
            this.cmbOperador2.TabIndex = 47;
            this.cmbOperador2.SelectedIndexChanged += new System.EventHandler(this.cmbOperador2_SelectedIndexChanged);
            // 
            // cmbOperador1
            // 
            this.cmbOperador1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperador1.Items.AddRange(new object[] {
            "Igual",
            "Menor",
            "Mayor",
            "Menor o Igual",
            "Mayor o Igual",
            "Entre",
            "Diferente"});
            this.cmbOperador1.Location = new System.Drawing.Point(231, 4);
            this.cmbOperador1.Name = "cmbOperador1";
            this.cmbOperador1.Size = new System.Drawing.Size(133, 21);
            this.cmbOperador1.TabIndex = 46;
            this.cmbOperador1.SelectedIndexChanged += new System.EventHandler(this.cmbOperador1_SelectedIndexChanged);
            // 
            // lblCampo
            // 
            this.lblCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.Location = new System.Drawing.Point(16, 13);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(64, 15);
            this.lblCampo.TabIndex = 45;
            this.lblCampo.Text = "Campo";
            this.lblCampo.Visible = false;
            // 
            // lbloperador
            // 
            this.lbloperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloperador.Location = new System.Drawing.Point(235, 13);
            this.lbloperador.Name = "lbloperador";
            this.lbloperador.Size = new System.Drawing.Size(64, 16);
            this.lbloperador.TabIndex = 44;
            this.lbloperador.Text = "Operador";
            this.lbloperador.Visible = false;
            // 
            // lblvalor
            // 
            this.lblvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalor.Location = new System.Drawing.Point(376, 13);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(48, 16);
            this.lblvalor.TabIndex = 43;
            this.lblvalor.Text = "Valor";
            this.lblvalor.Visible = false;
            // 
            // txtFiltro4
            // 
            this.txtFiltro4.Location = new System.Drawing.Point(373, 3);
            this.txtFiltro4.Name = "txtFiltro4";
            this.txtFiltro4.Size = new System.Drawing.Size(136, 20);
            this.txtFiltro4.TabIndex = 42;
            // 
            // txtFiltro3
            // 
            this.txtFiltro3.Location = new System.Drawing.Point(372, 3);
            this.txtFiltro3.Name = "txtFiltro3";
            this.txtFiltro3.Size = new System.Drawing.Size(136, 20);
            this.txtFiltro3.TabIndex = 41;
            // 
            // txtFiltro2
            // 
            this.txtFiltro2.Location = new System.Drawing.Point(370, 3);
            this.txtFiltro2.Name = "txtFiltro2";
            this.txtFiltro2.Size = new System.Drawing.Size(136, 20);
            this.txtFiltro2.TabIndex = 40;
            // 
            // txtFiltro1
            // 
            this.txtFiltro1.Location = new System.Drawing.Point(372, 4);
            this.txtFiltro1.Name = "txtFiltro1";
            this.txtFiltro1.Size = new System.Drawing.Size(136, 20);
            this.txtFiltro1.TabIndex = 39;
            // 
            // grdRpt
            // 
            this.grdRpt.AllowUpdate = false;
            this.grdRpt.BackColor = System.Drawing.Color.White;
            this.grdRpt.CaptionHeight = 17;
            this.grdRpt.DataMember = "rpt";
            this.grdRpt.DataSource = this.dsSPXQuery2;
            this.grdRpt.FilterBar = true;
            this.grdRpt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdRpt.GroupByCaption = "Drag a column header here to group by that column";
            this.grdRpt.Images.Add(((System.Drawing.Image)(resources.GetObject("grdRpt.Images"))));
            this.grdRpt.Location = new System.Drawing.Point(0, 9);
            this.grdRpt.Name = "grdRpt";
            this.grdRpt.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdRpt.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdRpt.PreviewInfo.ZoomFactor = 75D;
            this.grdRpt.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdRpt.PrintInfo.PageSettings")));
            this.grdRpt.RowHeight = 20;
            this.grdRpt.Size = new System.Drawing.Size(610, 300);
            this.grdRpt.TabIndex = 0;
            this.grdRpt.Text = "c1TrueDBGrid1";
            this.grdRpt.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Black;
            this.grdRpt.BeforeRowColChange += new C1.Win.C1TrueDBGrid.CancelEventHandler(this.grdRpt_BeforeRowColChange);
            this.grdRpt.RowColChange += new C1.Win.C1TrueDBGrid.RowColChangeEventHandler(this.grdRpt_RowColChange);
            this.grdRpt.PropBag = resources.GetString("grdRpt.PropBag");
            // 
            // dsSPXQuery2
            // 
            this.dsSPXQuery2.DataSetName = "dsSPXQuery";
            this.dsSPXQuery2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsSPXQuery1
            // 
            this.dsSPXQuery1.DataSetName = "dsSPXQuery";
            this.dsSPXQuery1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // c1Report1
            // 
            this.c1Report1.ReportDefinition = resources.GetString("c1Report1.ReportDefinition");
            this.c1Report1.ReportName = "c1Report1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.cmbOrden3);
            this.groupBox1.Controls.Add(this.lblSep2Orden);
            this.groupBox1.Controls.Add(this.lblSep1Orden);
            this.groupBox1.Controls.Add(this.btnQuitarOrden);
            this.groupBox1.Controls.Add(this.cmbOrden3Estilos);
            this.groupBox1.Controls.Add(this.btnAgregarOrden);
            this.groupBox1.Controls.Add(this.cmbOrden2Estilos);
            this.groupBox1.Controls.Add(this.cmbOrden1Estilos);
            this.groupBox1.Controls.Add(this.chkOrden3);
            this.groupBox1.Controls.Add(this.chkOrden1);
            this.groupBox1.Controls.Add(this.cmbOrden1);
            this.groupBox1.Controls.Add(this.chkOrden2);
            this.groupBox1.Controls.Add(this.cmbOrden2);
            this.groupBox1.Location = new System.Drawing.Point(7, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(889, 56);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordenar";
            // 
            // lblSep2Orden
            // 
            this.lblSep2Orden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSep2Orden.Location = new System.Drawing.Point(514, 20);
            this.lblSep2Orden.Name = "lblSep2Orden";
            this.lblSep2Orden.Size = new System.Drawing.Size(8, 15);
            this.lblSep2Orden.TabIndex = 75;
            this.lblSep2Orden.Text = "-";
            this.lblSep2Orden.Visible = false;
            // 
            // lblSep1Orden
            // 
            this.lblSep1Orden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSep1Orden.Location = new System.Drawing.Point(259, 20);
            this.lblSep1Orden.Name = "lblSep1Orden";
            this.lblSep1Orden.Size = new System.Drawing.Size(9, 15);
            this.lblSep1Orden.TabIndex = 74;
            this.lblSep1Orden.Text = "-";
            this.lblSep1Orden.Visible = false;
            // 
            // btnQuitarOrden
            // 
            this.btnQuitarOrden.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnQuitarOrden, "Quitar Orden");
            this.balloonTip1.SetBalloonText(this.btnQuitarOrden, null);
            this.btnQuitarOrden.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitarOrden.Image")));
            this.btnQuitarOrden.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnQuitarOrden.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnQuitarOrden.Location = new System.Drawing.Point(53, 18);
            this.btnQuitarOrden.Name = "btnQuitarOrden";
            this.btnQuitarOrden.Size = new System.Drawing.Size(33, 33);
            this.btnQuitarOrden.TabIndex = 73;
            this.btnQuitarOrden.Visible = false;
            this.btnQuitarOrden.Click += new System.EventHandler(this.btnQuitarOrden_Click);
            // 
            // cmbOrden3Estilos
            // 
            this.cmbOrden3Estilos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrden3Estilos.Items.AddRange(new object[] {
            "Ascendente",
            "Descendente"});
            this.cmbOrden3Estilos.Location = new System.Drawing.Point(682, 17);
            this.cmbOrden3Estilos.Name = "cmbOrden3Estilos";
            this.cmbOrden3Estilos.Size = new System.Drawing.Size(88, 21);
            this.cmbOrden3Estilos.TabIndex = 71;
            this.cmbOrden3Estilos.Visible = false;
            // 
            // btnAgregarOrden
            // 
            this.btnAgregarOrden.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnAgregarOrden, "Agregar Criterio de Orden");
            this.balloonTip1.SetBalloonText(this.btnAgregarOrden, null);
            this.btnAgregarOrden.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarOrden.Image")));
            this.btnAgregarOrden.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnAgregarOrden.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAgregarOrden.Location = new System.Drawing.Point(14, 18);
            this.btnAgregarOrden.Name = "btnAgregarOrden";
            this.btnAgregarOrden.Size = new System.Drawing.Size(33, 33);
            this.btnAgregarOrden.TabIndex = 72;
            this.btnAgregarOrden.Click += new System.EventHandler(this.btnAgregarOrden_Click);
            // 
            // cmbOrden2Estilos
            // 
            this.cmbOrden2Estilos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrden2Estilos.Items.AddRange(new object[] {
            "Ascendente",
            "Descendente"});
            this.cmbOrden2Estilos.Location = new System.Drawing.Point(424, 17);
            this.cmbOrden2Estilos.Name = "cmbOrden2Estilos";
            this.cmbOrden2Estilos.Size = new System.Drawing.Size(88, 21);
            this.cmbOrden2Estilos.TabIndex = 70;
            this.cmbOrden2Estilos.Visible = false;
            // 
            // cmbOrden1Estilos
            // 
            this.cmbOrden1Estilos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrden1Estilos.Items.AddRange(new object[] {
            "Ascendente",
            "Descendente"});
            this.cmbOrden1Estilos.Location = new System.Drawing.Point(168, 17);
            this.cmbOrden1Estilos.Name = "cmbOrden1Estilos";
            this.cmbOrden1Estilos.Size = new System.Drawing.Size(88, 21);
            this.cmbOrden1Estilos.TabIndex = 69;
            this.cmbOrden1Estilos.Visible = false;
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = System.Drawing.Color.White;
            this.lblEstado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(744, 283);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(152, 26);
            this.lblEstado.TabIndex = 72;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.btnQuitarFiltro);
            this.groupBox2.Controls.Add(this.btnAgregarFiltro);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.lblvalor);
            this.groupBox2.Controls.Add(this.lbloperador);
            this.groupBox2.Controls.Add(this.lblCampo);
            this.groupBox2.Location = new System.Drawing.Point(7, 377);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(889, 187);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chkFiltro4);
            this.panel4.Controls.Add(this.lblCal4);
            this.panel4.Controls.Add(this.cal2F4);
            this.panel4.Controls.Add(this.lblyf4);
            this.panel4.Controls.Add(this.txtFiltro4);
            this.panel4.Controls.Add(this.cal1F4);
            this.panel4.Controls.Add(this.cmbOperador4);
            this.panel4.Controls.Add(this.cmbFiltro4);
            this.panel4.Controls.Add(this.txtFloat2F4);
            this.panel4.Controls.Add(this.txtEntero1F4);
            this.panel4.Controls.Add(this.txtFloat1F4);
            this.panel4.Controls.Add(this.txtEntero2F4);
            this.panel4.Location = new System.Drawing.Point(6, 122);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(875, 30);
            this.panel4.TabIndex = 97;
            this.panel4.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblCal3);
            this.panel3.Controls.Add(this.cal2F3);
            this.panel3.Controls.Add(this.txtFiltro3);
            this.panel3.Controls.Add(this.lblyf3);
            this.panel3.Controls.Add(this.cmbOperador3);
            this.panel3.Controls.Add(this.cal1F3);
            this.panel3.Controls.Add(this.cmbFiltro3);
            this.panel3.Controls.Add(this.txtEntero1F3);
            this.panel3.Controls.Add(this.txtFloat2F3);
            this.panel3.Controls.Add(this.txtEntero2F3);
            this.panel3.Controls.Add(this.chkFiltro3);
            this.panel3.Controls.Add(this.txtFloat1F3);
            this.panel3.Location = new System.Drawing.Point(6, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(875, 30);
            this.panel3.TabIndex = 96;
            this.panel3.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cal2f2);
            this.panel2.Controls.Add(this.lblCal2);
            this.panel2.Controls.Add(this.txtFiltro2);
            this.panel2.Controls.Add(this.cmbOperador2);
            this.panel2.Controls.Add(this.cmbFiltro2);
            this.panel2.Controls.Add(this.txtEntero1F2);
            this.panel2.Controls.Add(this.txtEntero2F2);
            this.panel2.Controls.Add(this.txtFloat1F2);
            this.panel2.Controls.Add(this.txtFloat2F2);
            this.panel2.Controls.Add(this.cal1F2);
            this.panel2.Controls.Add(this.lblyf2);
            this.panel2.Controls.Add(this.chkFilltro2);
            this.panel2.Location = new System.Drawing.Point(7, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(875, 30);
            this.panel2.TabIndex = 95;
            this.panel2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbCampo1);
            this.panel1.Controls.Add(this.txtFiltro1);
            this.panel1.Controls.Add(this.cmbOperador1);
            this.panel1.Controls.Add(this.chkFiltro1);
            this.panel1.Controls.Add(this.txtEntero1F1);
            this.panel1.Controls.Add(this.lblCal1);
            this.panel1.Controls.Add(this.txtEntero2F1);
            this.panel1.Controls.Add(this.txtFloat1F1);
            this.panel1.Controls.Add(this.txtFloat2F1);
            this.panel1.Controls.Add(this.cal2f1);
            this.panel1.Controls.Add(this.cal1F1);
            this.panel1.Controls.Add(this.lblyf1);
            this.panel1.Location = new System.Drawing.Point(7, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 30);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // btnGenExcel
            // 
            this.btnGenExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGenExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnGenExcel.Image")));
            this.btnGenExcel.ImageFixedSize = new System.Drawing.Size(38, 38);
            this.btnGenExcel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnGenExcel.Location = new System.Drawing.Point(617, 163);
            this.btnGenExcel.Name = "btnGenExcel";
            this.btnGenExcel.Size = new System.Drawing.Size(70, 70);
            this.btnGenExcel.TabIndex = 74;
            this.btnGenExcel.Text = "Generar Excel";
            this.btnGenExcel.Click += new System.EventHandler(this.btnGenExcel_Click);
            // 
            // grdToolExcel
            // 
            this.grdToolExcel.GroupByCaption = "Drag a column header here to group by that column";
            this.grdToolExcel.Images.Add(((System.Drawing.Image)(resources.GetObject("grdToolExcel.Images"))));
            this.grdToolExcel.Location = new System.Drawing.Point(800, 12);
            this.grdToolExcel.Name = "grdToolExcel";
            this.grdToolExcel.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdToolExcel.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdToolExcel.PreviewInfo.ZoomFactor = 75D;
            this.grdToolExcel.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdToolExcel.PrintInfo.PageSettings")));
            this.grdToolExcel.Size = new System.Drawing.Size(96, 69);
            this.grdToolExcel.TabIndex = 75;
            this.grdToolExcel.Text = "c1TrueDBGrid1";
            this.grdToolExcel.Visible = false;
            this.grdToolExcel.PropBag = resources.GetString("grdToolExcel.PropBag");
            // 
            // rptTableAdapter1
            // 
            this.rptTableAdapter1.ClearBeforeFill = true;
            // 
            // rpt_parametrosTableAdapter1
            // 
            this.rpt_parametrosTableAdapter1.ClearBeforeFill = true;
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(834, 9);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(62, 72);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 98;
            this.picLogo.TabStop = false;
            // 
            // frmSeleccionReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(908, 576);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.grdToolExcel);
            this.Controls.Add(this.btnGenExcel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVerReporte);
            this.Controls.Add(this.grdRpt);
            this.Name = "frmSeleccionReporte";
            this.Text = "Seleccion Reporte";
            this.Load += new System.EventHandler(this.frmSeleccionReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsOrden3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrden1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrden2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cal1F3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cal2F3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cal1F4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cal2F4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cal1F2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cal2f2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFiltro4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFiltro3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFiltro2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cal1F1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cal2f1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFiltro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRpt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXQuery2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXQuery1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Report1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdToolExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdRpt;
        private System.Windows.Forms.ComboBox cmbCampo1;
        private System.Windows.Forms.ComboBox cmbOperador4;
        private System.Windows.Forms.ComboBox cmbOperador3;
        private System.Windows.Forms.ComboBox cmbOperador2;
        private System.Windows.Forms.ComboBox cmbOperador1;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lbloperador;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.TextBox txtFiltro4;
        private System.Windows.Forms.TextBox txtFiltro3;
        private System.Windows.Forms.TextBox txtFiltro2;
        private System.Windows.Forms.TextBox txtFiltro1;
        private System.Windows.Forms.CheckBox chkFiltro4;
        private System.Windows.Forms.CheckBox chkFiltro3;
        private System.Windows.Forms.CheckBox chkFilltro2;
        private System.Windows.Forms.CheckBox chkFiltro1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput cal1F1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput cal2f1;
        private System.Windows.Forms.TextBox txtFloat2F1;
        private System.Windows.Forms.TextBox txtFloat1F1;
        private System.Windows.Forms.TextBox txtEntero2F1;
        private System.Windows.Forms.TextBox txtEntero1F1;
        private System.Windows.Forms.ComboBox cmbFiltro4;
        private System.Windows.Forms.ComboBox cmbFiltro3;
        private System.Windows.Forms.ComboBox cmbFiltro2;
        private System.Windows.Forms.ComboBox cmbOrden3;
        private System.Windows.Forms.ComboBox cmbOrden2;
        private System.Windows.Forms.ComboBox cmbOrden1;
        private System.Windows.Forms.Label lblyf1;
        private System.Windows.Forms.Label lblyf2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput cal1F2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput cal2f2;
        private System.Windows.Forms.TextBox txtFloat2F2;
        private System.Windows.Forms.TextBox txtFloat1F2;
        private System.Windows.Forms.TextBox txtEntero2F2;
        private System.Windows.Forms.TextBox txtEntero1F2;
        private System.Windows.Forms.Label lblyf3;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput cal1F3;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput cal2F3;
        private System.Windows.Forms.TextBox txtFloat2F3;
        private System.Windows.Forms.TextBox txtFloat1F3;
        private System.Windows.Forms.TextBox txtEntero2F3;
        private System.Windows.Forms.TextBox txtEntero1F3;
        private System.Windows.Forms.Label lblyf4;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput cal1F4;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput cal2F4;
        private System.Windows.Forms.TextBox txtFloat2F4;
        private System.Windows.Forms.TextBox txtFloat1F4;
        private System.Windows.Forms.TextBox txtEntero2F4;
        private System.Windows.Forms.TextBox txtEntero1F4;
        private System.Windows.Forms.Label lblCal3;
        private System.Windows.Forms.Label lblCal2;
        private System.Windows.Forms.Label lblCal4;
        private System.Windows.Forms.Label lblCal1;
        private System.Windows.Forms.CheckBox chkOrden3;
        private System.Windows.Forms.CheckBox chkOrden2;
        private System.Windows.Forms.CheckBox chkOrden1;
        private DevComponents.DotNetBar.ButtonX btnVerReporte;
        private C1.C1Report.C1Report c1Report1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private DevComponents.DotNetBar.ButtonX btnAgregarOrden;
        private DevComponents.DotNetBar.ButtonX btnQuitarOrden;
        private System.Windows.Forms.ComboBox cmbOrden1Estilos;
        private System.Windows.Forms.ComboBox cmbOrden3Estilos;
        private System.Windows.Forms.ComboBox cmbOrden2Estilos;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblSep2Orden;
        private System.Windows.Forms.Label lblSep1Orden;
        private DevComponents.DotNetBar.ButtonX btnQuitarFiltro;
        private DevComponents.DotNetBar.ButtonX btnAgregarFiltro;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX btnGenExcel;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdToolExcel;
        private dsSPXQuery dsSPXQuery1;
        private rptTableAdapter rptTableAdapter1;
        private dsSPXQuery dsFiltro1;
        private dsSPXQuery dsFiltro2;
        private dsSPXQuery dsFiltro3;
        private dsSPXQuery dsFiltro4;
        //private dsSPXQuery.rpt_parametrosTableAdapter rpt_parametrosTableAdapter1;
        //private dsSPXQuery.tipofiltro_query_rptTableAdapter tipofiltro_query_rptTableAdapter1;
        private dsSPXQuery dsOrden1;
        private dsSPXQuery dsOrden2;
        private dsSPXQuery dsOrden3;
        private dsSPXQuery dsSPXQuery2;
        private data.cls.clsTtipofiltro_query_rpt tipofiltro_query_rptTableAdapter1;
        private rpt_parametrosTableAdapter rpt_parametrosTableAdapter1;
        private System.Windows.Forms.PictureBox picLogo;
    }
}