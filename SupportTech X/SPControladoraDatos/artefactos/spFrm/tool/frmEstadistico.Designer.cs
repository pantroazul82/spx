namespace SpFrm.tool
{
    partial class frmEstadistico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadistico));
            this.calInicio = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.calFin = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBusquedaTipoServicio = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.txtBusqueda();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.label3 = new System.Windows.Forms.Label();
            this.grdTipoServicio = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsPlantillas1 = new SPControladoraDatos.dsPlantillas();
            this.txtBusquedaUsuario = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.txtBusqueda();
            this.dsSeguridad1 = new SPControladoraDatos.dsSpx();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdxTipoServicio = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBusquedaSerial = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.txtBusqueda();
            this.txtBusquedaModalidad = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.txtBusqueda();
            this.txtBusquedaCliente = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.txtBusqueda();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBusquedaFabricante = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.txtBusqueda();
            this.txtBusquedaModelo = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.txtBusqueda();
            ((System.ComponentModel.ISupportInitialize)(this.calInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFin)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSeguridad1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdxTipoServicio)).BeginInit();
            this.SuspendLayout();
            // 
            // calInicio
            // 
            // 
            // 
            // 
            this.calInicio.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calInicio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicio.ButtonDropDown.Visible = true;
            this.calInicio.Location = new System.Drawing.Point(123, 19);
            // 
            // 
            // 
            this.calInicio.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
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
            this.calInicio.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.calInicio.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
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
            this.calInicio.Size = new System.Drawing.Size(200, 20);
            this.calInicio.TabIndex = 0;
            // 
            // calFin
            // 
            // 
            // 
            // 
            this.calFin.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calFin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFin.ButtonDropDown.Visible = true;
            this.calFin.Location = new System.Drawing.Point(353, 19);
            // 
            // 
            // 
            this.calFin.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
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
            this.calFin.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.calFin.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
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
            this.calFin.Size = new System.Drawing.Size(200, 20);
            this.calFin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha Programación";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBusquedaTipoServicio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.grdTipoServicio);
            this.groupBox1.Location = new System.Drawing.Point(4, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 353);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estadisticas por Tipo Servicio";
            // 
            // txtBusquedaTipoServicio
            // 
            this.txtBusquedaTipoServicio.codigo = "codTipoServicio";
            this.txtBusquedaTipoServicio.DataMember = this.dsSpx1.TipoServicio;
            this.txtBusquedaTipoServicio.DataSource = this.dsSpx1;
            this.txtBusquedaTipoServicio.descripcion1 = "nombretipoServicio";
            this.txtBusquedaTipoServicio.filtroAdicional = null;
            this.txtBusquedaTipoServicio.LimiteY = 125;
            this.txtBusquedaTipoServicio.linkPadre = null;
            this.txtBusquedaTipoServicio.Location = new System.Drawing.Point(111, 20);
            this.txtBusquedaTipoServicio.Name = "txtBusquedaTipoServicio";
            this.txtBusquedaTipoServicio.sentenciaFromObligatoria = null;
            this.txtBusquedaTipoServicio.Size = new System.Drawing.Size(294, 20);
            this.txtBusquedaTipoServicio.TabIndex = 0;
            this.txtBusquedaTipoServicio.Tabla = this.dsSpx1.TipoServicio;
            this.txtBusquedaTipoServicio.TamanoPopUp = 5;
            this.txtBusquedaTipoServicio.txtPadre = null;
            this.txtBusquedaTipoServicio.Value = "0";
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo de Servicio";
            // 
            // grdTipoServicio
            // 
            this.grdTipoServicio.DataMember = "pltEstadisticasOSxTipoServicio";
            this.grdTipoServicio.DataSource = this.dsPlantillas1;
            this.grdTipoServicio.GroupByCaption = "Drag a column header here to group by that column";
            this.grdTipoServicio.Images.Add(((System.Drawing.Image)(resources.GetObject("grdTipoServicio.Images"))));
            this.grdTipoServicio.Location = new System.Drawing.Point(24, 54);
            this.grdTipoServicio.Name = "grdTipoServicio";
            this.grdTipoServicio.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdTipoServicio.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdTipoServicio.PreviewInfo.ZoomFactor = 75D;
            this.grdTipoServicio.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdTipoServicio.PrintInfo.PageSettings")));
            this.grdTipoServicio.Size = new System.Drawing.Size(472, 290);
            this.grdTipoServicio.TabIndex = 1;
            this.grdTipoServicio.Text = "c1TrueDBGrid1";
            this.grdTipoServicio.PropBag = resources.GetString("grdTipoServicio.PropBag");
            // 
            // dsPlantillas1
            // 
            this.dsPlantillas1.DataSetName = "dsPlantillas";
            this.dsPlantillas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBusquedaUsuario
            // 
            this.txtBusquedaUsuario.codigo = "login";
            this.txtBusquedaUsuario.DataMember = this.dsSeguridad1.usuarios;
            this.txtBusquedaUsuario.DataSource = this.dsSeguridad1;
            this.txtBusquedaUsuario.descripcion1 = "nombre";
            this.txtBusquedaUsuario.filtroAdicional = null;
            this.txtBusquedaUsuario.LimiteY = 125;
            this.txtBusquedaUsuario.linkPadre = null;
            this.txtBusquedaUsuario.Location = new System.Drawing.Point(100, 20);
            this.txtBusquedaUsuario.Name = "txtBusquedaUsuario";
            this.txtBusquedaUsuario.sentenciaFromObligatoria = null;
            this.txtBusquedaUsuario.Size = new System.Drawing.Size(294, 20);
            this.txtBusquedaUsuario.TabIndex = 0;
            this.txtBusquedaUsuario.Tabla = this.dsSeguridad1.usuarios;
            this.txtBusquedaUsuario.TamanoPopUp = 5;
            this.txtBusquedaUsuario.txtPadre = null;
            this.txtBusquedaUsuario.Value = "0";
            // 
            // dsSeguridad1
            // 
            this.dsSeguridad1.DataSetName = "dsSeguridad";
            this.dsSeguridad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdxTipoServicio);
            this.groupBox2.Controls.Add(this.txtBusquedaUsuario);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(512, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 353);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estadisticas por Usuario";
            // 
            // grdxTipoServicio
            // 
            this.grdxTipoServicio.AllowUpdate = false;
            this.grdxTipoServicio.DataMember = "pltEstadisticasOSxUsuario";
            this.grdxTipoServicio.DataSource = this.dsPlantillas1;
            this.grdxTipoServicio.GroupByCaption = "Drag a column header here to group by that column";
            this.grdxTipoServicio.Images.Add(((System.Drawing.Image)(resources.GetObject("grdxTipoServicio.Images"))));
            this.grdxTipoServicio.Location = new System.Drawing.Point(6, 54);
            this.grdxTipoServicio.Name = "grdxTipoServicio";
            this.grdxTipoServicio.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdxTipoServicio.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdxTipoServicio.PreviewInfo.ZoomFactor = 75D;
            this.grdxTipoServicio.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdxTipoServicio.PrintInfo.PageSettings")));
            this.grdxTipoServicio.Size = new System.Drawing.Size(472, 290);
            this.grdxTipoServicio.TabIndex = 1;
            this.grdxTipoServicio.Text = "c1TrueDBGrid2";
            this.grdxTipoServicio.PropBag = resources.GetString("grdxTipoServicio.PropBag");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Serial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Modalidad";
            // 
            // txtBusquedaSerial
            // 
            this.txtBusquedaSerial.codigo = "serial";
            this.txtBusquedaSerial.DataMember = this.dsSpx1.equipos;
            this.txtBusquedaSerial.DataSource = this.dsSpx1;
            this.txtBusquedaSerial.descripcion1 = "serial";
            this.txtBusquedaSerial.filtroAdicional = null;
            this.txtBusquedaSerial.LimiteY = 125;
            this.txtBusquedaSerial.linkPadre = null;
            this.txtBusquedaSerial.Location = new System.Drawing.Point(99, 104);
            this.txtBusquedaSerial.Name = "txtBusquedaSerial";
            this.txtBusquedaSerial.sentenciaFromObligatoria = null;
            this.txtBusquedaSerial.Size = new System.Drawing.Size(294, 20);
            this.txtBusquedaSerial.TabIndex = 4;
            this.txtBusquedaSerial.Tabla = this.dsSpx1.equipos;
            this.txtBusquedaSerial.TamanoPopUp = 5;
            this.txtBusquedaSerial.txtPadre = null;
            this.txtBusquedaSerial.Value = "0";
            // 
            // txtBusquedaModalidad
            // 
            this.txtBusquedaModalidad.codigo = "codModalidadEquipo";
            this.txtBusquedaModalidad.DataMember = this.dsSpx1.ModalidadEquipo;
            this.txtBusquedaModalidad.DataSource = this.dsSpx1;
            this.txtBusquedaModalidad.descripcion1 = "nombreModalidadEquipo";
            this.txtBusquedaModalidad.filtroAdicional = null;
            this.txtBusquedaModalidad.LimiteY = 125;
            this.txtBusquedaModalidad.linkPadre = null;
            this.txtBusquedaModalidad.Location = new System.Drawing.Point(99, 156);
            this.txtBusquedaModalidad.Name = "txtBusquedaModalidad";
            this.txtBusquedaModalidad.sentenciaFromObligatoria = null;
            this.txtBusquedaModalidad.Size = new System.Drawing.Size(294, 20);
            this.txtBusquedaModalidad.TabIndex = 6;
            this.txtBusquedaModalidad.Tabla = this.dsSpx1.ModalidadEquipo;
            this.txtBusquedaModalidad.TamanoPopUp = 5;
            this.txtBusquedaModalidad.txtPadre = null;
            this.txtBusquedaModalidad.Value = "0";
            // 
            // txtBusquedaCliente
            // 
            this.txtBusquedaCliente.codigo = "nitCliente";
            this.txtBusquedaCliente.DataMember = this.dsSpx1.clientes;
            this.txtBusquedaCliente.DataSource = this.dsSpx1;
            this.txtBusquedaCliente.descripcion1 = "nitCliente";
            this.txtBusquedaCliente.descripcion2 = "nombreCliente";
            this.txtBusquedaCliente.filtroAdicional = null;
            this.txtBusquedaCliente.LimiteY = 125;
            this.txtBusquedaCliente.linkPadre = null;
            this.txtBusquedaCliente.Location = new System.Drawing.Point(99, 130);
            this.txtBusquedaCliente.Name = "txtBusquedaCliente";
            this.txtBusquedaCliente.sentenciaFromObligatoria = null;
            this.txtBusquedaCliente.Size = new System.Drawing.Size(294, 20);
            this.txtBusquedaCliente.TabIndex = 5;
            this.txtBusquedaCliente.Tabla = this.dsSpx1.clientes;
            this.txtBusquedaCliente.TamanoPopUp = 5;
            this.txtBusquedaCliente.txtPadre = null;
            this.txtBusquedaCliente.Value = "0";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Snow;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(670, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(331, 75);
            this.label7.TabIndex = 11;
            this.label7.Text = "Si no conoce un criterio de busqueda especifico ingrese %";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(408, 141);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 35);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Fabricante";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Modelo";
            // 
            // txtBusquedaFabricante
            // 
            this.txtBusquedaFabricante.codigo = "codFabricante";
            this.txtBusquedaFabricante.DataMember = this.dsSpx1.fabricante;
            this.txtBusquedaFabricante.DataSource = this.dsSpx1;
            this.txtBusquedaFabricante.descripcion1 = "nombreFabricante";
            this.txtBusquedaFabricante.filtroAdicional = null;
            this.txtBusquedaFabricante.LimiteY = 125;
            this.txtBusquedaFabricante.linkPadre = null;
            this.txtBusquedaFabricante.Location = new System.Drawing.Point(99, 76);
            this.txtBusquedaFabricante.Name = "txtBusquedaFabricante";
            this.txtBusquedaFabricante.sentenciaFromObligatoria = null;
            this.txtBusquedaFabricante.Size = new System.Drawing.Size(294, 20);
            this.txtBusquedaFabricante.TabIndex = 3;
            this.txtBusquedaFabricante.Tabla = this.dsSpx1.fabricante;
            this.txtBusquedaFabricante.TamanoPopUp = 5;
            this.txtBusquedaFabricante.txtPadre = null;
            this.txtBusquedaFabricante.Value = "0";
            // 
            // txtBusquedaModelo
            // 
            this.txtBusquedaModelo.codigo = "codModelo";
            this.txtBusquedaModelo.DataMember = this.dsSpx1.Modelos;
            this.txtBusquedaModelo.DataSource = this.dsSpx1;
            this.txtBusquedaModelo.descripcion1 = "NombreModelo";
            this.txtBusquedaModelo.filtroAdicional = null;
            this.txtBusquedaModelo.LimiteY = 125;
            this.txtBusquedaModelo.linkPadre = null;
            this.txtBusquedaModelo.Location = new System.Drawing.Point(99, 50);
            this.txtBusquedaModelo.Name = "txtBusquedaModelo";
            this.txtBusquedaModelo.sentenciaFromObligatoria = null;
            this.txtBusquedaModelo.Size = new System.Drawing.Size(294, 20);
            this.txtBusquedaModelo.TabIndex = 2;
            this.txtBusquedaModelo.Tabla = this.dsSpx1.Modelos;
            this.txtBusquedaModelo.TamanoPopUp = 5;
            this.txtBusquedaModelo.txtPadre = null;
            this.txtBusquedaModelo.Value = "0";
            // 
            // frmEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 547);
            this.Controls.Add(this.txtBusquedaModelo);
            this.Controls.Add(this.txtBusquedaFabricante);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBusquedaCliente);
            this.Controls.Add(this.txtBusquedaModalidad);
            this.Controls.Add(this.txtBusquedaSerial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.calInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calFin);
            this.Name = "frmEstadistico";
            this.Text = "Formulario Estadistico";
            this.Load += new System.EventHandler(this.frmEstadistico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSeguridad1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdxTipoServicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.Editors.DateTimeAdv.DateTimeInput calInicio;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdTipoServicio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdxTipoServicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.txtBusqueda txtBusquedaUsuario;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.txtBusqueda txtBusquedaTipoServicio;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.txtBusqueda txtBusquedaSerial;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.txtBusqueda txtBusquedaModalidad;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.txtBusqueda txtBusquedaCliente;
        private System.Windows.Forms.Label label7;
        private SPControladoraDatos.dsPlantillas dsPlantillas1;
        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpx dsSeguridad1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.txtBusqueda txtBusquedaFabricante;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.txtBusqueda txtBusquedaModelo;
    }
}