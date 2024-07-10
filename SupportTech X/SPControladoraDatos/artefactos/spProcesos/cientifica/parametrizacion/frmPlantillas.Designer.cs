namespace spProcesos.cientifica.parametrizacion
{
    partial class frmPlantillas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlantillas));
            this.button1 = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grdCampos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVersionTemplate = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calCreacion = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.calVigenciaDesde = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.calVigenciaHasta = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtCreadoPor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCambiarArchivo = new System.Windows.Forms.Button();
            this.btnDescargarArchivo = new System.Windows.Forms.Button();
            this.btnAgregarCAmpo = new System.Windows.Forms.Button();
            this.btnEditarCampo = new System.Windows.Forms.Button();
            this.btnEliminarCampo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCampos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calCreacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calVigenciaDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calVigenciaHasta)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(727, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(646, 13);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 374);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 48);
            this.panel1.TabIndex = 2;
            // 
            // grdCampos
            // 
            this.grdCampos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCampos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdCampos.Images"))));
            this.grdCampos.Location = new System.Drawing.Point(12, 220);
            this.grdCampos.Name = "grdCampos";
            this.grdCampos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdCampos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdCampos.PreviewInfo.ZoomFactor = 75D;
            this.grdCampos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdCampos.PrintInfo.PageSettings")));
            this.grdCampos.Size = new System.Drawing.Size(790, 148);
            this.grdCampos.TabIndex = 3;
            this.grdCampos.Text = "c1TrueDBGrid1";
            this.grdCampos.PropBag = resources.GetString("grdCampos.PropBag");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Version Template";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Observaciones";
            // 
            // txtVersionTemplate
            // 
            this.txtVersionTemplate.Location = new System.Drawing.Point(107, 13);
            this.txtVersionTemplate.Name = "txtVersionTemplate";
            this.txtVersionTemplate.Size = new System.Drawing.Size(231, 20);
            this.txtVersionTemplate.TabIndex = 6;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(12, 145);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(489, 69);
            this.txtObservaciones.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vigencia Desde";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vigencia Hasta";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha Creacion";
            // 
            // calCreacion
            // 
            this.calCreacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.calCreacion.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calCreacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calCreacion.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.calCreacion.ButtonDropDown.Visible = true;
            this.calCreacion.Enabled = false;
            this.calCreacion.Location = new System.Drawing.Point(597, 13);
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
            this.calCreacion.MonthCalendar.DisplayMonth = new System.DateTime(2013, 7, 1, 0, 0, 0, 0);
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
            this.calCreacion.Size = new System.Drawing.Size(151, 20);
            this.calCreacion.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.calCreacion.TabIndex = 11;
            // 
            // calVigenciaDesde
            // 
            this.calVigenciaDesde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.calVigenciaDesde.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calVigenciaDesde.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaDesde.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.calVigenciaDesde.ButtonDropDown.Visible = true;
            this.calVigenciaDesde.Enabled = false;
            this.calVigenciaDesde.Location = new System.Drawing.Point(596, 39);
            // 
            // 
            // 
            this.calVigenciaDesde.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calVigenciaDesde.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calVigenciaDesde.MonthCalendar.BackgroundStyle.Class = "";
            this.calVigenciaDesde.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaDesde.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calVigenciaDesde.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calVigenciaDesde.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calVigenciaDesde.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calVigenciaDesde.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calVigenciaDesde.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calVigenciaDesde.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calVigenciaDesde.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calVigenciaDesde.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaDesde.MonthCalendar.DisplayMonth = new System.DateTime(2013, 7, 1, 0, 0, 0, 0);
            this.calVigenciaDesde.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calVigenciaDesde.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calVigenciaDesde.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calVigenciaDesde.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calVigenciaDesde.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calVigenciaDesde.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calVigenciaDesde.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaDesde.MonthCalendar.TodayButtonVisible = true;
            this.calVigenciaDesde.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calVigenciaDesde.Name = "calVigenciaDesde";
            this.calVigenciaDesde.Size = new System.Drawing.Size(151, 20);
            this.calVigenciaDesde.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.calVigenciaDesde.TabIndex = 12;
            // 
            // calVigenciaHasta
            // 
            this.calVigenciaHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.calVigenciaHasta.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calVigenciaHasta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaHasta.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.calVigenciaHasta.ButtonDropDown.Visible = true;
            this.calVigenciaHasta.Enabled = false;
            this.calVigenciaHasta.Location = new System.Drawing.Point(597, 65);
            // 
            // 
            // 
            this.calVigenciaHasta.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calVigenciaHasta.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calVigenciaHasta.MonthCalendar.BackgroundStyle.Class = "";
            this.calVigenciaHasta.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaHasta.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calVigenciaHasta.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calVigenciaHasta.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calVigenciaHasta.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calVigenciaHasta.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calVigenciaHasta.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calVigenciaHasta.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calVigenciaHasta.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calVigenciaHasta.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaHasta.MonthCalendar.DisplayMonth = new System.DateTime(2013, 7, 1, 0, 0, 0, 0);
            this.calVigenciaHasta.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calVigenciaHasta.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calVigenciaHasta.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calVigenciaHasta.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calVigenciaHasta.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calVigenciaHasta.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calVigenciaHasta.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaHasta.MonthCalendar.TodayButtonVisible = true;
            this.calVigenciaHasta.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calVigenciaHasta.Name = "calVigenciaHasta";
            this.calVigenciaHasta.Size = new System.Drawing.Size(151, 20);
            this.calVigenciaHasta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.calVigenciaHasta.TabIndex = 13;
            // 
            // txtCreadoPor
            // 
            this.txtCreadoPor.BackColor = System.Drawing.Color.White;
            this.txtCreadoPor.Location = new System.Drawing.Point(107, 40);
            this.txtCreadoPor.Name = "txtCreadoPor";
            this.txtCreadoPor.ReadOnly = true;
            this.txtCreadoPor.Size = new System.Drawing.Size(231, 20);
            this.txtCreadoPor.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Creado Por";
            // 
            // txtArchivo
            // 
            this.txtArchivo.BackColor = System.Drawing.Color.White;
            this.txtArchivo.Location = new System.Drawing.Point(107, 90);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(231, 20);
            this.txtArchivo.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Archivo";
            // 
            // btnCambiarArchivo
            // 
            this.btnCambiarArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCambiarArchivo.Location = new System.Drawing.Point(107, 116);
            this.btnCambiarArchivo.Name = "btnCambiarArchivo";
            this.btnCambiarArchivo.Size = new System.Drawing.Size(106, 23);
            this.btnCambiarArchivo.TabIndex = 18;
            this.btnCambiarArchivo.Text = "Cambiar Archivo";
            this.btnCambiarArchivo.UseVisualStyleBackColor = true;
            this.btnCambiarArchivo.Click += new System.EventHandler(this.btnCambiarArchivo_Click);
            // 
            // btnDescargarArchivo
            // 
            this.btnDescargarArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDescargarArchivo.Location = new System.Drawing.Point(219, 116);
            this.btnDescargarArchivo.Name = "btnDescargarArchivo";
            this.btnDescargarArchivo.Size = new System.Drawing.Size(119, 23);
            this.btnDescargarArchivo.TabIndex = 19;
            this.btnDescargarArchivo.Text = "Descargar Archivo";
            this.btnDescargarArchivo.UseVisualStyleBackColor = true;
            this.btnDescargarArchivo.Click += new System.EventHandler(this.btnDescargarArchivo_Click);
            // 
            // btnAgregarCAmpo
            // 
            this.btnAgregarCAmpo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarCAmpo.Location = new System.Drawing.Point(515, 191);
            this.btnAgregarCAmpo.Name = "btnAgregarCAmpo";
            this.btnAgregarCAmpo.Size = new System.Drawing.Size(106, 23);
            this.btnAgregarCAmpo.TabIndex = 20;
            this.btnAgregarCAmpo.Text = "Agregar Campo";
            this.btnAgregarCAmpo.UseVisualStyleBackColor = true;
            this.btnAgregarCAmpo.Click += new System.EventHandler(this.btnAgregarCAmpo_Click);
            // 
            // btnEditarCampo
            // 
            this.btnEditarCampo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarCampo.Location = new System.Drawing.Point(626, 191);
            this.btnEditarCampo.Name = "btnEditarCampo";
            this.btnEditarCampo.Size = new System.Drawing.Size(86, 23);
            this.btnEditarCampo.TabIndex = 21;
            this.btnEditarCampo.Text = "Editar Campo";
            this.btnEditarCampo.UseVisualStyleBackColor = true;
            this.btnEditarCampo.Click += new System.EventHandler(this.btnEditarCampo_Click);
            // 
            // btnEliminarCampo
            // 
            this.btnEliminarCampo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarCampo.Location = new System.Drawing.Point(712, 191);
            this.btnEliminarCampo.Name = "btnEliminarCampo";
            this.btnEliminarCampo.Size = new System.Drawing.Size(90, 23);
            this.btnEliminarCampo.TabIndex = 22;
            this.btnEliminarCampo.Text = "Eliminar Campo";
            this.btnEliminarCampo.UseVisualStyleBackColor = true;
            this.btnEliminarCampo.Click += new System.EventHandler(this.btnEliminarCampo_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(9, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(329, 27);
            this.label8.TabIndex = 23;
            this.label8.Text = "Es importante que el archivo de plantilla no tenga mas de 150 filas para evitar p" +
    "roblemas de conversion a pdf";
            // 
            // frmPlantillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 422);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEliminarCampo);
            this.Controls.Add(this.btnEditarCampo);
            this.Controls.Add(this.btnAgregarCAmpo);
            this.Controls.Add(this.btnDescargarArchivo);
            this.Controls.Add(this.btnCambiarArchivo);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCreadoPor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.calVigenciaHasta);
            this.Controls.Add(this.calVigenciaDesde);
            this.Controls.Add(this.calCreacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtVersionTemplate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdCampos);
            this.Controls.Add(this.panel1);
            this.Name = "frmPlantillas";
            this.Text = "Plantillas";
            this.Load += new System.EventHandler(this.frmPlantillas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCampos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calCreacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calVigenciaDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calVigenciaHasta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdCampos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVersionTemplate;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calCreacion;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calVigenciaDesde;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calVigenciaHasta;
        private System.Windows.Forms.TextBox txtCreadoPor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCambiarArchivo;
        private System.Windows.Forms.Button btnDescargarArchivo;
        private System.Windows.Forms.Button btnAgregarCAmpo;
        private System.Windows.Forms.Button btnEditarCampo;
        private System.Windows.Forms.Button btnEliminarCampo;
        private System.Windows.Forms.Label label8;
    }
}