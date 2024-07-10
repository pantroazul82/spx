namespace spProcesos.programacion
{
    partial class frmNewProgramacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewProgramacion));
            this.label1 = new System.Windows.Forms.Label();
            this.calSalida = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.calRegreso = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbhoraVueloSalida = new System.Windows.Forms.ComboBox();
            this.cmbMinutoSalida = new System.Windows.Forms.ComboBox();
            this.cmbAmSalida = new System.Windows.Forms.ComboBox();
            this.cmbAmpLlegada = new System.Windows.Forms.ComboBox();
            this.cmbMinutoLlegada = new System.Windows.Forms.ComboBox();
            this.cmbhoraLLegada = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdDepartamento = new System.Windows.Forms.RadioButton();
            this.rdCiudad = new System.Windows.Forms.RadioButton();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.rdPais = new System.Windows.Forms.RadioButton();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.cmbDepartamentos = new System.Windows.Forms.ComboBox();
            this.calFinPeriodo = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label9 = new System.Windows.Forms.Label();
            this.calInicioPeriodo = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.cmbMeses = new System.Windows.Forms.ComboBox();
            this.rdMostrarTodos = new System.Windows.Forms.RadioButton();
            this.rdMostrarSinProgramacion = new System.Windows.Forms.RadioButton();
            this.rdMes = new System.Windows.Forms.RadioButton();
            this.rdPeriodo = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnGuardar = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btnInfEquipo = new DevComponents.DotNetBar.ButtonX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.btnSugerir = new DevComponents.DotNetBar.ButtonX();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.btnVerOrdenServicio = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregar = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregarTodos = new DevComponents.DotNetBar.ButtonX();
            this.btnQuitarTodosDetalles = new DevComponents.DotNetBar.ButtonX();
            this.btnQuitarDetalle = new DevComponents.DotNetBar.ButtonX();
            this.btnConfirmarTodos = new DevComponents.DotNetBar.ButtonX();
            this.btnModificar = new DevComponents.DotNetBar.ButtonX();
            this.btnDesconfirmarTodos = new DevComponents.DotNetBar.ButtonX();
            this.btnGuardarGrilla = new DevComponents.DotNetBar.ButtonX();
            this.btnReinicciargrilla = new DevComponents.DotNetBar.ButtonX();
            this.btnGuardarListaProgramacion = new DevComponents.DotNetBar.ButtonX();
            this.btnRestaurarListaProgramacion = new DevComponents.DotNetBar.ButtonX();
            this.btnExportarExcelProgramacion = new DevComponents.DotNetBar.ButtonX();
            this.btnLimpiarDepartamento = new System.Windows.Forms.Button();
            this.btnLimpiarCiudad = new System.Windows.Forms.Button();
            this.grdDetalleProgramacion = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsPlantillas1 = new SPControladoraDatos.dsPlantillas();
            this.grdEquipos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.cmbIngeniero = new System.Windows.Forms.ComboBox();
             this.departamentoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.departamentoTableAdapter();
            this.paisesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.paisesTableAdapter();
            this.ciudadesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ciudadesTableAdapter();
            this.equiposTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter();
            this.defaultsTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter();
            this.programacionViajesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.programacionViajesTableAdapter();
            this.detalleProgramacionViajesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.detalleProgramacionViajesTableAdapter();
            this.tipoServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.TipoServicioTableAdapter();
            this.ordenServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter();
            this.btnProgramar = new DevComponents.DotNetBar.ButtonX();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnImprimir = new DevComponents.DotNetBar.ButtonX();
            this.prioridadesOrdenServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.prioridadesOrdenServicioTableAdapter();
            this.dsSpx2 = new SPControladoraDatos.dsSpx();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCiudadDestino = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbPaisDEstino = new System.Windows.Forms.ComboBox();
            this.cmbDepartamentoDestino = new System.Windows.Forms.ComboBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pltDetalleProgramacionViajesTableAdapter1 = new SPControladoraDatos.dsPlantillasTableAdapters.pltDetalleProgramacionViajesTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbAsesorComercial = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.asesoresComercialesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.asesoresComercialesTableAdapter();
            this.notificacionTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.notificacionTableAdapter();
            this.contratosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.contratosTableAdapter();
            this.mantenimientosxContratoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.mantenimientosxContratoTableAdapter();
            this.contratosxEquipoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.contratosxEquipoTableAdapter();
            this.clsTusuario1 = new SPXSeguridad.data.cls.clsTusuario();
            this.dsSPXSeguridad1 = new SPXSeguridad.data.dsSPXSeguridad();
            ((System.ComponentModel.ISupportInitialize)(this.calSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calRegreso)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFinPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calInicioPeriodo)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleProgramacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEquipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingeniero:";
            // 
            // calSalida
            // 
            // 
            // 
            // 
            this.calSalida.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calSalida.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calSalida.ButtonDropDown.Visible = true;
            this.calSalida.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calSalida.Location = new System.Drawing.Point(117, 118);
            // 
            // 
            // 
            this.calSalida.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calSalida.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calSalida.MonthCalendar.BackgroundStyle.Class = "";
            this.calSalida.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calSalida.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calSalida.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calSalida.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calSalida.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calSalida.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calSalida.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calSalida.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calSalida.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calSalida.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calSalida.MonthCalendar.DisplayMonth = new System.DateTime(2008, 4, 1, 0, 0, 0, 0);
            this.calSalida.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calSalida.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calSalida.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calSalida.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calSalida.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calSalida.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calSalida.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calSalida.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calSalida.MonthCalendar.TodayButtonVisible = true;
            this.calSalida.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calSalida.Name = "calSalida";
            this.calSalida.Size = new System.Drawing.Size(200, 21);
            this.calSalida.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha Salida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha Regreso";
            // 
            // calRegreso
            // 
            // 
            // 
            // 
            this.calRegreso.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calRegreso.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calRegreso.ButtonDropDown.Visible = true;
            this.calRegreso.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calRegreso.Location = new System.Drawing.Point(117, 144);
            // 
            // 
            // 
            this.calRegreso.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calRegreso.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calRegreso.MonthCalendar.BackgroundStyle.Class = "";
            this.calRegreso.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calRegreso.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calRegreso.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calRegreso.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calRegreso.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calRegreso.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calRegreso.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calRegreso.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calRegreso.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calRegreso.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calRegreso.MonthCalendar.DisplayMonth = new System.DateTime(2008, 4, 1, 0, 0, 0, 0);
            this.calRegreso.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calRegreso.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calRegreso.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calRegreso.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calRegreso.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calRegreso.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calRegreso.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calRegreso.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calRegreso.MonthCalendar.TodayButtonVisible = true;
            this.calRegreso.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calRegreso.Name = "calRegreso";
            this.calRegreso.Size = new System.Drawing.Size(200, 21);
            this.calRegreso.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(323, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "Hora Vuelo de Regreso";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(323, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "Hora Vuelo de Salida";
            // 
            // cmbhoraVueloSalida
            // 
            this.cmbhoraVueloSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbhoraVueloSalida.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbhoraVueloSalida.FormattingEnabled = true;
            this.cmbhoraVueloSalida.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbhoraVueloSalida.Location = new System.Drawing.Point(399, 118);
            this.cmbhoraVueloSalida.Name = "cmbhoraVueloSalida";
            this.cmbhoraVueloSalida.Size = new System.Drawing.Size(51, 21);
            this.cmbhoraVueloSalida.TabIndex = 18;
            // 
            // cmbMinutoSalida
            // 
            this.cmbMinutoSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMinutoSalida.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMinutoSalida.FormattingEnabled = true;
            this.cmbMinutoSalida.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmbMinutoSalida.Location = new System.Drawing.Point(456, 118);
            this.cmbMinutoSalida.Name = "cmbMinutoSalida";
            this.cmbMinutoSalida.Size = new System.Drawing.Size(51, 21);
            this.cmbMinutoSalida.TabIndex = 19;
            // 
            // cmbAmSalida
            // 
            this.cmbAmSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAmSalida.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAmSalida.FormattingEnabled = true;
            this.cmbAmSalida.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cmbAmSalida.Location = new System.Drawing.Point(513, 118);
            this.cmbAmSalida.Name = "cmbAmSalida";
            this.cmbAmSalida.Size = new System.Drawing.Size(51, 21);
            this.cmbAmSalida.TabIndex = 20;
            // 
            // cmbAmpLlegada
            // 
            this.cmbAmpLlegada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAmpLlegada.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAmpLlegada.FormattingEnabled = true;
            this.cmbAmpLlegada.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cmbAmpLlegada.Location = new System.Drawing.Point(514, 144);
            this.cmbAmpLlegada.Name = "cmbAmpLlegada";
            this.cmbAmpLlegada.Size = new System.Drawing.Size(51, 21);
            this.cmbAmpLlegada.TabIndex = 23;
            // 
            // cmbMinutoLlegada
            // 
            this.cmbMinutoLlegada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMinutoLlegada.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMinutoLlegada.FormattingEnabled = true;
            this.cmbMinutoLlegada.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmbMinutoLlegada.Location = new System.Drawing.Point(457, 144);
            this.cmbMinutoLlegada.Name = "cmbMinutoLlegada";
            this.cmbMinutoLlegada.Size = new System.Drawing.Size(51, 21);
            this.cmbMinutoLlegada.TabIndex = 22;
            // 
            // cmbhoraLLegada
            // 
            this.cmbhoraLLegada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbhoraLLegada.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbhoraLLegada.FormattingEnabled = true;
            this.cmbhoraLLegada.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbhoraLLegada.Location = new System.Drawing.Point(400, 144);
            this.cmbhoraLLegada.Name = "cmbhoraLLegada";
            this.cmbhoraLLegada.Size = new System.Drawing.Size(51, 21);
            this.cmbhoraLLegada.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rdDepartamento);
            this.groupBox2.Controls.Add(this.rdCiudad);
            this.groupBox2.Controls.Add(this.cmbCiudad);
            this.groupBox2.Controls.Add(this.rdPais);
            this.groupBox2.Controls.Add(this.cmbPais);
            this.groupBox2.Controls.Add(this.cmbDepartamentos);
            this.groupBox2.Location = new System.Drawing.Point(4, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 105);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ubicacion";
            // 
            // rdDepartamento
            // 
            this.rdDepartamento.AutoSize = true;
            this.rdDepartamento.Checked = true;
            this.rdDepartamento.Location = new System.Drawing.Point(10, 42);
            this.rdDepartamento.Name = "rdDepartamento";
            this.rdDepartamento.Size = new System.Drawing.Size(111, 17);
            this.rdDepartamento.TabIndex = 21;
            this.rdDepartamento.TabStop = true;
            this.rdDepartamento.Text = "Por Departamento";
            this.rdDepartamento.UseVisualStyleBackColor = true;
            // 
            // rdCiudad
            // 
            this.rdCiudad.AutoSize = true;
            this.rdCiudad.Location = new System.Drawing.Point(10, 69);
            this.rdCiudad.Name = "rdCiudad";
            this.rdCiudad.Size = new System.Drawing.Size(77, 17);
            this.rdCiudad.TabIndex = 19;
            this.rdCiudad.Text = "Por Ciudad";
            this.rdCiudad.UseVisualStyleBackColor = true;
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.DataSource = this.dsSpx1;
            this.cmbCiudad.DisplayMember = "ciudades.nombreCiudad";
            this.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(145, 69);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(182, 21);
            this.cmbCiudad.TabIndex = 6;
            this.cmbCiudad.ValueMember = "ciudades.codCiudad";
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rdPais
            // 
            this.rdPais.AutoSize = true;
            this.rdPais.Location = new System.Drawing.Point(10, 15);
            this.rdPais.Name = "rdPais";
            this.rdPais.Size = new System.Drawing.Size(64, 17);
            this.rdPais.TabIndex = 20;
            this.rdPais.Text = "Por Pais";
            this.rdPais.UseVisualStyleBackColor = true;
            // 
            // cmbPais
            // 
            this.cmbPais.DataSource = this.dsSpx1;
            this.cmbPais.DisplayMember = "paises.nombrePais";
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(145, 15);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(182, 21);
            this.cmbPais.TabIndex = 2;
            this.cmbPais.ValueMember = "paises.codPais";
            this.cmbPais.SelectedIndexChanged += new System.EventHandler(this.cmbPais_SelectedIndexChanged);
            // 
            // cmbDepartamentos
            // 
            this.cmbDepartamentos.DataSource = this.dsSpx1;
            this.cmbDepartamentos.DisplayMember = "departamento.NombreDepartamento";
            this.cmbDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamentos.FormattingEnabled = true;
            this.cmbDepartamentos.Location = new System.Drawing.Point(145, 42);
            this.cmbDepartamentos.Name = "cmbDepartamentos";
            this.cmbDepartamentos.Size = new System.Drawing.Size(182, 21);
            this.cmbDepartamentos.TabIndex = 4;
            this.cmbDepartamentos.ValueMember = "departamento.codDepartamento";
            this.cmbDepartamentos.SelectedIndexChanged += new System.EventHandler(this.cmbDepartamentos_SelectedIndexChanged);
            // 
            // calFinPeriodo
            // 
            // 
            // 
            // 
            this.calFinPeriodo.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calFinPeriodo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinPeriodo.ButtonDropDown.Visible = true;
            this.calFinPeriodo.Location = new System.Drawing.Point(140, 67);
            // 
            // 
            // 
            this.calFinPeriodo.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFinPeriodo.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calFinPeriodo.MonthCalendar.BackgroundStyle.Class = "";
            this.calFinPeriodo.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinPeriodo.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calFinPeriodo.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calFinPeriodo.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calFinPeriodo.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calFinPeriodo.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calFinPeriodo.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calFinPeriodo.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calFinPeriodo.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calFinPeriodo.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinPeriodo.MonthCalendar.DisplayMonth = new System.DateTime(2008, 4, 1, 0, 0, 0, 0);
            this.calFinPeriodo.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calFinPeriodo.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calFinPeriodo.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFinPeriodo.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calFinPeriodo.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calFinPeriodo.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calFinPeriodo.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calFinPeriodo.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinPeriodo.MonthCalendar.TodayButtonVisible = true;
            this.calFinPeriodo.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calFinPeriodo.Name = "calFinPeriodo";
            this.calFinPeriodo.Size = new System.Drawing.Size(200, 21);
            this.calFinPeriodo.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(122, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "y";
            // 
            // calInicioPeriodo
            // 
            // 
            // 
            // 
            this.calInicioPeriodo.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calInicioPeriodo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioPeriodo.ButtonDropDown.Visible = true;
            this.calInicioPeriodo.Location = new System.Drawing.Point(140, 40);
            // 
            // 
            // 
            this.calInicioPeriodo.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calInicioPeriodo.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calInicioPeriodo.MonthCalendar.BackgroundStyle.Class = "";
            this.calInicioPeriodo.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioPeriodo.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calInicioPeriodo.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calInicioPeriodo.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calInicioPeriodo.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calInicioPeriodo.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calInicioPeriodo.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calInicioPeriodo.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calInicioPeriodo.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calInicioPeriodo.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioPeriodo.MonthCalendar.DisplayMonth = new System.DateTime(2008, 4, 1, 0, 0, 0, 0);
            this.calInicioPeriodo.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calInicioPeriodo.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calInicioPeriodo.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calInicioPeriodo.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calInicioPeriodo.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calInicioPeriodo.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calInicioPeriodo.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calInicioPeriodo.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioPeriodo.MonthCalendar.TodayButtonVisible = true;
            this.calInicioPeriodo.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calInicioPeriodo.Name = "calInicioPeriodo";
            this.calInicioPeriodo.Size = new System.Drawing.Size(200, 21);
            this.calInicioPeriodo.TabIndex = 13;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnBuscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnBuscar.Location = new System.Drawing.Point(335, 260);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(71, 25);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbMeses
            // 
            this.cmbMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeses.FormattingEnabled = true;
            this.cmbMeses.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmbMeses.Location = new System.Drawing.Point(140, 13);
            this.cmbMeses.Name = "cmbMeses";
            this.cmbMeses.Size = new System.Drawing.Size(175, 21);
            this.cmbMeses.TabIndex = 30;
            // 
            // rdMostrarTodos
            // 
            this.rdMostrarTodos.AutoSize = true;
            this.rdMostrarTodos.Location = new System.Drawing.Point(10, 15);
            this.rdMostrarTodos.Name = "rdMostrarTodos";
            this.rdMostrarTodos.Size = new System.Drawing.Size(150, 17);
            this.rdMostrarTodos.TabIndex = 31;
            this.rdMostrarTodos.Text = "Mostrar Todos los Equipos";
            this.rdMostrarTodos.UseVisualStyleBackColor = true;
            // 
            // rdMostrarSinProgramacion
            // 
            this.rdMostrarSinProgramacion.AutoSize = true;
            this.rdMostrarSinProgramacion.Checked = true;
            this.rdMostrarSinProgramacion.Location = new System.Drawing.Point(185, 15);
            this.rdMostrarSinProgramacion.Name = "rdMostrarSinProgramacion";
            this.rdMostrarSinProgramacion.Size = new System.Drawing.Size(183, 17);
            this.rdMostrarSinProgramacion.TabIndex = 30;
            this.rdMostrarSinProgramacion.TabStop = true;
            this.rdMostrarSinProgramacion.Text = "Mostrar equipos sin programacion";
            this.rdMostrarSinProgramacion.UseVisualStyleBackColor = true;
            // 
            // rdMes
            // 
            this.rdMes.AutoSize = true;
            this.rdMes.Checked = true;
            this.rdMes.Location = new System.Drawing.Point(10, 13);
            this.rdMes.Name = "rdMes";
            this.rdMes.Size = new System.Drawing.Size(64, 17);
            this.rdMes.TabIndex = 33;
            this.rdMes.TabStop = true;
            this.rdMes.Text = "Por Mes";
            this.rdMes.UseVisualStyleBackColor = true;
            // 
            // rdPeriodo
            // 
            this.rdPeriodo.AutoSize = true;
            this.rdPeriodo.Location = new System.Drawing.Point(10, 39);
            this.rdPeriodo.Name = "rdPeriodo";
            this.rdPeriodo.Size = new System.Drawing.Size(124, 17);
            this.rdPeriodo.TabIndex = 32;
            this.rdPeriodo.Text = "Para el periodo Entre";
            this.rdPeriodo.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.cmbMeses);
            this.groupBox3.Controls.Add(this.rdPeriodo);
            this.groupBox3.Controls.Add(this.rdMes);
            this.groupBox3.Controls.Add(this.calFinPeriodo);
            this.groupBox3.Controls.Add(this.calInicioPeriodo);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 94);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mantenimientos Programados";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.rdMostrarSinProgramacion);
            this.groupBox4.Controls.Add(this.rdMostrarTodos);
            this.groupBox4.Location = new System.Drawing.Point(4, 206);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(402, 51);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.groupBox3);
            this.groupPanel1.Controls.Add(this.btnBuscar);
            this.groupPanel1.Controls.Add(this.groupBox2);
            this.groupPanel1.Controls.Add(this.groupBox4);
            this.groupPanel1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(5, 3);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(416, 308);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.Class = "";
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.Class = "";
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.Class = "";
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 36;
            this.groupPanel1.Text = "Opciones de Busqueda de Equipos";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnGuardar.Location = new System.Drawing.Point(794, 14);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(102, 33);
            this.btnGuardar.TabIndex = 68;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX1.Image = ((System.Drawing.Image)(resources.GetObject("buttonX1.Image")));
            this.buttonX1.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.buttonX1.Location = new System.Drawing.Point(904, 14);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(102, 33);
            this.buttonX1.TabIndex = 76;
            this.buttonX1.Text = "Cancelar";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btnInfEquipo
            // 
            this.btnInfEquipo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInfEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfEquipo.Image")));
            this.btnInfEquipo.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnInfEquipo.Location = new System.Drawing.Point(326, 318);
            this.btnInfEquipo.Name = "btnInfEquipo";
            this.btnInfEquipo.Size = new System.Drawing.Size(28, 28);
            this.btnInfEquipo.TabIndex = 77;
            this.btnInfEquipo.Click += new System.EventHandler(this.btnInfEquipo_Click);
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX3.Image = ((System.Drawing.Image)(resources.GetObject("buttonX3.Image")));
            this.buttonX3.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.buttonX3.Location = new System.Drawing.Point(824, 317);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(28, 28);
            this.buttonX3.TabIndex = 79;
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // btnSugerir
            // 
            this.btnSugerir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnSugerir, null);
            this.balloonTip1.SetBalloonText(this.btnSugerir, "Sugerir Ingeniero de Acuerdo a la Zona del servicio");
            this.btnSugerir.Image = ((System.Drawing.Image)(resources.GetObject("btnSugerir.Image")));
            this.btnSugerir.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnSugerir.Location = new System.Drawing.Point(396, 80);
            this.btnSugerir.Name = "btnSugerir";
            this.btnSugerir.Size = new System.Drawing.Size(86, 33);
            this.btnSugerir.TabIndex = 85;
            this.btnSugerir.Text = "Sugerir Ingeniero";
            this.btnSugerir.Click += new System.EventHandler(this.btnSugerir_Click);
            // 
            // btnVerOrdenServicio
            // 
            this.btnVerOrdenServicio.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVerOrdenServicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnVerOrdenServicio, null);
            this.balloonTip1.SetBalloonText(this.btnVerOrdenServicio, "Ver Orden de Servicio");
            this.btnVerOrdenServicio.Image = ((System.Drawing.Image)(resources.GetObject("btnVerOrdenServicio.Image")));
            this.btnVerOrdenServicio.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnVerOrdenServicio.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnVerOrdenServicio.Location = new System.Drawing.Point(854, 317);
            this.btnVerOrdenServicio.Name = "btnVerOrdenServicio";
            this.btnVerOrdenServicio.Size = new System.Drawing.Size(28, 28);
            this.btnVerOrdenServicio.TabIndex = 89;
            this.btnVerOrdenServicio.Click += new System.EventHandler(this.btnVerOrdenServicio_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnAgregar, "Agregar Equipo a la Programacion");
            this.balloonTip1.SetBalloonText(this.btnAgregar, null);
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnAgregar.Location = new System.Drawing.Point(420, 381);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(28, 28);
            this.btnAgregar.TabIndex = 101;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAgregarTodos
            // 
            this.btnAgregarTodos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnAgregarTodos, "Agregar todos los Equipo a la Programacion");
            this.balloonTip1.SetBalloonText(this.btnAgregarTodos, null);
            this.btnAgregarTodos.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarTodos.Image")));
            this.btnAgregarTodos.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnAgregarTodos.Location = new System.Drawing.Point(420, 412);
            this.btnAgregarTodos.Name = "btnAgregarTodos";
            this.btnAgregarTodos.Size = new System.Drawing.Size(28, 28);
            this.btnAgregarTodos.TabIndex = 102;
            this.btnAgregarTodos.Click += new System.EventHandler(this.btnAgregarTodos_Click);
            // 
            // btnQuitarTodosDetalles
            // 
            this.btnQuitarTodosDetalles.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuitarTodosDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnQuitarTodosDetalles, "Quitar todos los equipos de la programacion");
            this.btnQuitarTodosDetalles.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitarTodosDetalles.Image")));
            this.btnQuitarTodosDetalles.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnQuitarTodosDetalles.Location = new System.Drawing.Point(981, 442);
            this.btnQuitarTodosDetalles.Name = "btnQuitarTodosDetalles";
            this.btnQuitarTodosDetalles.Size = new System.Drawing.Size(28, 28);
            this.btnQuitarTodosDetalles.TabIndex = 104;
            this.btnQuitarTodosDetalles.Click += new System.EventHandler(this.btnQuitarTodosDetalles_Click);
            // 
            // btnQuitarDetalle
            // 
            this.btnQuitarDetalle.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuitarDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnQuitarDetalle, "Quitar Equipo de la programacion");
            this.btnQuitarDetalle.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitarDetalle.Image")));
            this.btnQuitarDetalle.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnQuitarDetalle.Location = new System.Drawing.Point(981, 412);
            this.btnQuitarDetalle.Name = "btnQuitarDetalle";
            this.btnQuitarDetalle.Size = new System.Drawing.Size(28, 28);
            this.btnQuitarDetalle.TabIndex = 103;
            this.btnQuitarDetalle.Click += new System.EventHandler(this.btnQuitarDetalle_Click);
            // 
            // btnConfirmarTodos
            // 
            this.btnConfirmarTodos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnConfirmarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnConfirmarTodos, "Confirmar Todos");
            this.balloonTip1.SetBalloonText(this.btnConfirmarTodos, null);
            this.btnConfirmarTodos.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmarTodos.Image")));
            this.btnConfirmarTodos.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnConfirmarTodos.Location = new System.Drawing.Point(466, 14);
            this.btnConfirmarTodos.Name = "btnConfirmarTodos";
            this.btnConfirmarTodos.Size = new System.Drawing.Size(102, 33);
            this.btnConfirmarTodos.TabIndex = 109;
            this.btnConfirmarTodos.Text = "Confirmar Todo";
            this.btnConfirmarTodos.Click += new System.EventHandler(this.btnConfirmarTodos_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnModificar, null);
            this.balloonTip1.SetBalloonText(this.btnModificar, "Modificar");
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnModificar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnModificar.Location = new System.Drawing.Point(981, 381);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(28, 28);
            this.btnModificar.TabIndex = 108;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnDesconfirmarTodos
            // 
            this.btnDesconfirmarTodos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDesconfirmarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnDesconfirmarTodos, "Desconfirmar Todos");
            this.balloonTip1.SetBalloonText(this.btnDesconfirmarTodos, null);
            this.btnDesconfirmarTodos.Image = ((System.Drawing.Image)(resources.GetObject("btnDesconfirmarTodos.Image")));
            this.btnDesconfirmarTodos.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnDesconfirmarTodos.Location = new System.Drawing.Point(358, 14);
            this.btnDesconfirmarTodos.Name = "btnDesconfirmarTodos";
            this.btnDesconfirmarTodos.Size = new System.Drawing.Size(102, 33);
            this.btnDesconfirmarTodos.TabIndex = 107;
            this.btnDesconfirmarTodos.Text = "Desconfirmar Todo";
            this.btnDesconfirmarTodos.Click += new System.EventHandler(this.btnDesconfirmarTodos_Click);
            // 
            // btnGuardarGrilla
            // 
            this.btnGuardarGrilla.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnGuardarGrilla, "Guardar Columnas");
            this.balloonTip1.SetBalloonText(this.btnGuardarGrilla, "Guarda El Esquema de las Columnas");
            this.btnGuardarGrilla.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarGrilla.Image")));
            this.btnGuardarGrilla.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnGuardarGrilla.Location = new System.Drawing.Point(356, 318);
            this.btnGuardarGrilla.Name = "btnGuardarGrilla";
            this.btnGuardarGrilla.Size = new System.Drawing.Size(28, 28);
            this.btnGuardarGrilla.TabIndex = 110;
            this.btnGuardarGrilla.Click += new System.EventHandler(this.btnGuardarGrilla_Click);
            // 
            // btnReinicciargrilla
            // 
            this.btnReinicciargrilla.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnReinicciargrilla, "Restaurar Columnas");
            this.balloonTip1.SetBalloonText(this.btnReinicciargrilla, "Restaurar Columnas a su Valor Original");
            this.btnReinicciargrilla.Image = ((System.Drawing.Image)(resources.GetObject("btnReinicciargrilla.Image")));
            this.btnReinicciargrilla.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnReinicciargrilla.Location = new System.Drawing.Point(386, 318);
            this.btnReinicciargrilla.Name = "btnReinicciargrilla";
            this.btnReinicciargrilla.Size = new System.Drawing.Size(28, 28);
            this.btnReinicciargrilla.TabIndex = 109;
            this.btnReinicciargrilla.Click += new System.EventHandler(this.btnReinicciargrilla_Click);
            // 
            // btnGuardarListaProgramacion
            // 
            this.btnGuardarListaProgramacion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGuardarListaProgramacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnGuardarListaProgramacion, "Guardar Columnas");
            this.balloonTip1.SetBalloonText(this.btnGuardarListaProgramacion, "Guarda El Esquema de las Columnas");
            this.btnGuardarListaProgramacion.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarListaProgramacion.Image")));
            this.btnGuardarListaProgramacion.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnGuardarListaProgramacion.Location = new System.Drawing.Point(885, 317);
            this.btnGuardarListaProgramacion.Name = "btnGuardarListaProgramacion";
            this.btnGuardarListaProgramacion.Size = new System.Drawing.Size(28, 28);
            this.btnGuardarListaProgramacion.TabIndex = 112;
            this.btnGuardarListaProgramacion.Click += new System.EventHandler(this.btnGuardarListaProgramacion_Click);
            // 
            // btnRestaurarListaProgramacion
            // 
            this.btnRestaurarListaProgramacion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRestaurarListaProgramacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnRestaurarListaProgramacion, "Restaurar Columnas");
            this.balloonTip1.SetBalloonText(this.btnRestaurarListaProgramacion, "Restaurar Columnas a su Valor Original");
            this.btnRestaurarListaProgramacion.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurarListaProgramacion.Image")));
            this.btnRestaurarListaProgramacion.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnRestaurarListaProgramacion.Location = new System.Drawing.Point(915, 317);
            this.btnRestaurarListaProgramacion.Name = "btnRestaurarListaProgramacion";
            this.btnRestaurarListaProgramacion.Size = new System.Drawing.Size(28, 28);
            this.btnRestaurarListaProgramacion.TabIndex = 111;
            this.btnRestaurarListaProgramacion.Click += new System.EventHandler(this.btnRestaurarListaProgramacion_Click);
            // 
            // btnExportarExcelProgramacion
            // 
            this.btnExportarExcelProgramacion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExportarExcelProgramacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnExportarExcelProgramacion, "Restaurar Columnas");
            this.balloonTip1.SetBalloonText(this.btnExportarExcelProgramacion, "Restaurar Columnas a su Valor Original");
            this.btnExportarExcelProgramacion.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarExcelProgramacion.Image")));
            this.btnExportarExcelProgramacion.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnExportarExcelProgramacion.Location = new System.Drawing.Point(945, 317);
            this.btnExportarExcelProgramacion.Name = "btnExportarExcelProgramacion";
            this.btnExportarExcelProgramacion.Size = new System.Drawing.Size(28, 28);
            this.btnExportarExcelProgramacion.TabIndex = 113;
            this.btnExportarExcelProgramacion.Click += new System.EventHandler(this.btnExportarExcelProgramacion_Click);
            // 
            // btnLimpiarDepartamento
            // 
            this.btnLimpiarDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarDepartamento.Location = new System.Drawing.Point(372, 14);
            this.btnLimpiarDepartamento.Name = "btnLimpiarDepartamento";
            this.btnLimpiarDepartamento.Size = new System.Drawing.Size(17, 21);
            this.btnLimpiarDepartamento.TabIndex = 98;
            this.btnLimpiarDepartamento.Text = "<";
            this.btnLimpiarDepartamento.UseVisualStyleBackColor = true;
            this.btnLimpiarDepartamento.Click += new System.EventHandler(this.btnLimpiarDepartamento_Click);
            // 
            // btnLimpiarCiudad
            // 
            this.btnLimpiarCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCiudad.Location = new System.Drawing.Point(555, 15);
            this.btnLimpiarCiudad.Name = "btnLimpiarCiudad";
            this.btnLimpiarCiudad.Size = new System.Drawing.Size(18, 21);
            this.btnLimpiarCiudad.TabIndex = 99;
            this.btnLimpiarCiudad.Text = "<";
            this.btnLimpiarCiudad.UseVisualStyleBackColor = true;
            this.btnLimpiarCiudad.Click += new System.EventHandler(this.btnLimpiarCiudad_Click);
            // 
            // grdDetalleProgramacion
            // 
            this.grdDetalleProgramacion.AllowUpdate = false;
            this.grdDetalleProgramacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDetalleProgramacion.CaptionHeight = 17;
            this.grdDetalleProgramacion.DataMember = "pltDetalleProgramacionViajes";
            this.grdDetalleProgramacion.DataSource = this.dsPlantillas1;
            this.grdDetalleProgramacion.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdDetalleProgramacion.FilterBar = true;
            this.grdDetalleProgramacion.GroupByCaption = "";
            this.grdDetalleProgramacion.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDetalleProgramacion.Images"))));
            this.grdDetalleProgramacion.Location = new System.Drawing.Point(459, 352);
            this.grdDetalleProgramacion.Name = "grdDetalleProgramacion";
            this.grdDetalleProgramacion.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDetalleProgramacion.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDetalleProgramacion.PreviewInfo.ZoomFactor = 75D;
            this.grdDetalleProgramacion.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDetalleProgramacion.PrintInfo.PageSettings")));
            this.grdDetalleProgramacion.RecordSelectorWidth = 13;
            this.grdDetalleProgramacion.RowHeight = 15;
            this.grdDetalleProgramacion.Size = new System.Drawing.Size(516, 323);
            this.grdDetalleProgramacion.TabIndex = 81;
            this.grdDetalleProgramacion.Text = "c1TrueDBGrid1";
            this.grdDetalleProgramacion.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.grdDetalleProgramacion.PropBag = resources.GetString("grdDetalleProgramacion.PropBag");
            // 
            // dsPlantillas1
            // 
            this.dsPlantillas1.DataSetName = "dsPlantillas";
            this.dsPlantillas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdEquipos
            // 
            this.grdEquipos.AllowUpdate = false;
            this.grdEquipos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grdEquipos.CaptionHeight = 17;
            this.grdEquipos.DataMember = "pltEquiposProgramacionViajes";
            this.grdEquipos.DataSource = this.dsPlantillas1;
            this.grdEquipos.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdEquipos.FilterBar = true;
            this.grdEquipos.GroupByCaption = "";
            this.grdEquipos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdEquipos.Images"))));
            this.grdEquipos.Location = new System.Drawing.Point(5, 352);
            this.grdEquipos.Name = "grdEquipos";
            this.grdEquipos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdEquipos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdEquipos.PreviewInfo.ZoomFactor = 75D;
            this.grdEquipos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdEquipos.PrintInfo.PageSettings")));
            this.grdEquipos.RecordSelectorWidth = 13;
            this.grdEquipos.RowHeight = 15;
            this.grdEquipos.Size = new System.Drawing.Size(412, 322);
            this.grdEquipos.TabIndex = 25;
            this.grdEquipos.Text = "c1TrueDBGrid1";
            this.grdEquipos.PropBag = resources.GetString("grdEquipos.PropBag");
            // 
            // cmbIngeniero
            // 
            this.cmbIngeniero.DataSource = this.dsSPXSeguridad1;
            this.cmbIngeniero.DisplayMember = "usuario.nombre";
            this.cmbIngeniero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIngeniero.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIngeniero.FormattingEnabled = true;
            this.cmbIngeniero.Location = new System.Drawing.Point(117, 85);
            this.cmbIngeniero.Name = "cmbIngeniero";
            this.cmbIngeniero.Size = new System.Drawing.Size(273, 21);
            this.cmbIngeniero.TabIndex = 0;
            this.cmbIngeniero.ValueMember = "usuario.login";
              // 
            // departamentoTableAdapter1
            // 
            this.departamentoTableAdapter1.ClearBeforeFill = true;
            // 
            // paisesTableAdapter1
            // 
            this.paisesTableAdapter1.ClearBeforeFill = true;
            // 
            // ciudadesTableAdapter1
            // 
            this.ciudadesTableAdapter1.ClearBeforeFill = true;
            // 
            // equiposTableAdapter1
            // 
            this.equiposTableAdapter1.ClearBeforeFill = true;
            // 
            // defaultsTableAdapter1
            // 
            this.defaultsTableAdapter1.ClearBeforeFill = true;
            // 
            // programacionViajesTableAdapter1
            // 
            this.programacionViajesTableAdapter1.ClearBeforeFill = true;
            // 
            // detalleProgramacionViajesTableAdapter1
            // 
            this.detalleProgramacionViajesTableAdapter1.ClearBeforeFill = true;
            // 
            // tipoServicioTableAdapter1
            // 
            this.tipoServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // ordenServicioTableAdapter1
            // 
            this.ordenServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // btnProgramar
            // 
            this.btnProgramar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnProgramar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProgramar.Image = ((System.Drawing.Image)(resources.GetObject("btnProgramar.Image")));
            this.btnProgramar.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnProgramar.Location = new System.Drawing.Point(574, 14);
            this.btnProgramar.Name = "btnProgramar";
            this.btnProgramar.Size = new System.Drawing.Size(102, 33);
            this.btnProgramar.TabIndex = 88;
            this.btnProgramar.Text = "Programar";
            this.btnProgramar.Click += new System.EventHandler(this.btnProgramar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 90;
            this.label2.Text = "Estado Programacion";
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(308, 28);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(253, 21);
            this.txtEstado.TabIndex = 91;
            this.txtEstado.Text = "Pendiente";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(117, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(71, 21);
            this.txtCodigo.TabIndex = 93;
            this.txtCodigo.Text = "Pendiente";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 36);
            this.label3.TabIndex = 92;
            this.label3.Text = "Codigo Programacion";
            // 
            // btnImprimir
            // 
            this.btnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnImprimir.Location = new System.Drawing.Point(684, 14);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(102, 33);
            this.btnImprimir.TabIndex = 94;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // prioridadesOrdenServicioTableAdapter1
            // 
            this.prioridadesOrdenServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // dsSpx2
            // 
            this.dsSpx2.DataSetName = "dsSpx";
            this.dsSpx2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnLimpiarDepartamento);
            this.groupBox1.Controls.Add(this.btnLimpiarCiudad);
            this.groupBox1.Controls.Add(this.cmbCiudadDestino);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbPaisDEstino);
            this.groupBox1.Controls.Add(this.cmbDepartamentoDestino);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 42);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Destino";
            // 
            // cmbCiudadDestino
            // 
            this.cmbCiudadDestino.DataSource = this.dsSpx2;
            this.cmbCiudadDestino.DisplayMember = "ciudades.nombreCiudad";
            this.cmbCiudadDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudadDestino.FormattingEnabled = true;
            this.cmbCiudadDestino.Location = new System.Drawing.Point(430, 16);
            this.cmbCiudadDestino.Name = "cmbCiudadDestino";
            this.cmbCiudadDestino.Size = new System.Drawing.Size(124, 21);
            this.cmbCiudadDestino.TabIndex = 6;
            this.cmbCiudadDestino.ValueMember = "ciudades.codCiudad";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(389, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 14);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ciudad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(167, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Departamento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Pais:";
            // 
            // cmbPaisDEstino
            // 
            this.cmbPaisDEstino.DataSource = this.dsSpx2;
            this.cmbPaisDEstino.DisplayMember = "paises.nombrePais";
            this.cmbPaisDEstino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaisDEstino.FormattingEnabled = true;
            this.cmbPaisDEstino.Location = new System.Drawing.Point(31, 14);
            this.cmbPaisDEstino.Name = "cmbPaisDEstino";
            this.cmbPaisDEstino.Size = new System.Drawing.Size(134, 21);
            this.cmbPaisDEstino.TabIndex = 2;
            this.cmbPaisDEstino.ValueMember = "paises.codPais";
            this.cmbPaisDEstino.SelectedIndexChanged += new System.EventHandler(this.cmbPaisDEstino_SelectedIndexChanged);
            // 
            // cmbDepartamentoDestino
            // 
            this.cmbDepartamentoDestino.DataSource = this.dsSpx2;
            this.cmbDepartamentoDestino.DisplayMember = "departamento.NombreDepartamento";
            this.cmbDepartamentoDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamentoDestino.FormattingEnabled = true;
            this.cmbDepartamentoDestino.Location = new System.Drawing.Point(244, 14);
            this.cmbDepartamentoDestino.Name = "cmbDepartamentoDestino";
            this.cmbDepartamentoDestino.Size = new System.Drawing.Size(127, 21);
            this.cmbDepartamentoDestino.TabIndex = 4;
            this.cmbDepartamentoDestino.ValueMember = "departamento.codDepartamento";
            this.cmbDepartamentoDestino.SelectedIndexChanged += new System.EventHandler(this.cmbDepartamentoDestino_SelectedIndexChanged);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(3, 229);
            this.txtObservaciones.MaxLength = 250;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(576, 70);
            this.txtObservaciones.TabIndex = 99;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 98;
            this.label12.Text = "Observaciones";
            // 
            // pltDetalleProgramacionViajesTableAdapter1
            // 
            this.pltDetalleProgramacionViajesTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnConfirmarTodos);
            this.panel1.Controls.Add(this.btnDesconfirmarTodos);
            this.panel1.Controls.Add(this.buttonX1);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.btnProgramar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 681);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 59);
            this.panel1.TabIndex = 100;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(2, 315);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 13);
            this.label13.TabIndex = 105;
            this.label13.Text = "Resultado de la Busqueda";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbAsesorComercial);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.cmbhoraLLegada);
            this.groupBox5.Controls.Add(this.cmbMinutoLlegada);
            this.groupBox5.Controls.Add(this.cmbAmpLlegada);
            this.groupBox5.Controls.Add(this.cmbhoraVueloSalida);
            this.groupBox5.Controls.Add(this.cmbMinutoSalida);
            this.groupBox5.Controls.Add(this.cmbAmSalida);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.cmbIngeniero);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.calSalida);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.calRegreso);
            this.groupBox5.Controls.Add(this.txtObservaciones);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.txtCodigo);
            this.groupBox5.Controls.Add(this.txtEstado);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.btnSugerir);
            this.groupBox5.Location = new System.Drawing.Point(425, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(586, 305);
            this.groupBox5.TabIndex = 106;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Informacion de la Orden de Prestamo";
            // 
            // cmbAsesorComercial
            // 
            this.cmbAsesorComercial.DataSource = this.dsSpx1;
            this.cmbAsesorComercial.DisplayMember = "asesoresComerciales.NombreAsesor";
            this.cmbAsesorComercial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAsesorComercial.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAsesorComercial.FormattingEnabled = true;
            this.cmbAsesorComercial.Location = new System.Drawing.Point(117, 56);
            this.cmbAsesorComercial.Name = "cmbAsesorComercial";
            this.cmbAsesorComercial.Size = new System.Drawing.Size(273, 21);
            this.cmbAsesorComercial.TabIndex = 100;
            this.cmbAsesorComercial.ValueMember = "asesoresComerciales.codAsesor";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 13);
            this.label14.TabIndex = 101;
            this.label14.Text = "Asesor Comercial:";
            // 
            // asesoresComercialesTableAdapter1
            // 
            this.asesoresComercialesTableAdapter1.ClearBeforeFill = true;
            // 
            // notificacionTableAdapter1
            // 
            this.notificacionTableAdapter1.ClearBeforeFill = true;
            // 
            // contratosTableAdapter1
            // 
            this.contratosTableAdapter1.ClearBeforeFill = true;
            // 
            // mantenimientosxContratoTableAdapter1
            // 
            this.mantenimientosxContratoTableAdapter1.ClearBeforeFill = true;
            // 
            // contratosxEquipoTableAdapter1
            // 
            this.contratosxEquipoTableAdapter1.ClearBeforeFill = true;
            // 
            // clsTusuario1
            // 
            this.clsTusuario1.nombreLlave = "cod_usuario";
            this.clsTusuario1.nombreTabla = "usuario";
            this.clsTusuario1.sentenciaBase = resources.GetString("clsTusuario1.sentenciaBase");
            this.clsTusuario1.sentenciaBaseDistinct = resources.GetString("clsTusuario1.sentenciaBaseDistinct");
            // 
            // dsSPXSeguridad1
            // 
            this.dsSPXSeguridad1.DataSetName = "dsSPXSeguridad";
            this.dsSPXSeguridad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmNewProgramacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1016, 740);
            this.Controls.Add(this.btnExportarExcelProgramacion);
            this.Controls.Add(this.btnGuardarListaProgramacion);
            this.Controls.Add(this.btnRestaurarListaProgramacion);
            this.Controls.Add(this.btnGuardarGrilla);
            this.Controls.Add(this.btnReinicciargrilla);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnVerOrdenServicio);
            this.Controls.Add(this.buttonX3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnQuitarTodosDetalles);
            this.Controls.Add(this.btnQuitarDetalle);
            this.Controls.Add(this.btnAgregarTodos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grdDetalleProgramacion);
            this.Controls.Add(this.btnInfEquipo);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.grdEquipos);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNewProgramacion";
            this.Text = "Crear Programacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNewProgramacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calRegreso)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFinPeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calInicioPeriodo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleProgramacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEquipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbIngeniero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPais;
        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.departamentoTableAdapter departamentoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.paisesTableAdapter paisesTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.ciudadesTableAdapter ciudadesTableAdapter1;
        private System.Windows.Forms.ComboBox cmbDepartamentos;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calSalida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calRegreso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbhoraVueloSalida;
        private System.Windows.Forms.ComboBox cmbMinutoSalida;
        private System.Windows.Forms.ComboBox cmbAmSalida;
        private System.Windows.Forms.ComboBox cmbAmpLlegada;
        private System.Windows.Forms.ComboBox cmbMinutoLlegada;
        private System.Windows.Forms.ComboBox cmbhoraLLegada;
        private SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter equiposTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFinPeriodo;
        private System.Windows.Forms.Label label9;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calInicioPeriodo;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdEquipos;
        private System.Windows.Forms.RadioButton rdDepartamento;
        private System.Windows.Forms.RadioButton rdPais;
        private System.Windows.Forms.RadioButton rdCiudad;
        private SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter defaultsTableAdapter1;
        private DevComponents.DotNetBar.ButtonX btnBuscar;
        private System.Windows.Forms.ComboBox cmbMeses;
        private System.Windows.Forms.RadioButton rdMostrarTodos;
        private System.Windows.Forms.RadioButton rdMostrarSinProgramacion;
        private System.Windows.Forms.RadioButton rdMes;
        private System.Windows.Forms.RadioButton rdPeriodo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btnGuardar;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private SPControladoraDatos.dsPlantillas dsPlantillas1;
        private DevComponents.DotNetBar.ButtonX btnInfEquipo;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdDetalleProgramacion;
        private SPControladoraDatos.dsSpxTableAdapters.programacionViajesTableAdapter programacionViajesTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.detalleProgramacionViajesTableAdapter detalleProgramacionViajesTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.TipoServicioTableAdapter tipoServicioTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter ordenServicioTableAdapter1;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private DevComponents.DotNetBar.ButtonX btnSugerir;
        private DevComponents.DotNetBar.ButtonX btnProgramar;
        private DevComponents.DotNetBar.ButtonX btnVerOrdenServicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.ButtonX btnImprimir;
        private SPControladoraDatos.dsSpxTableAdapters.prioridadesOrdenServicioTableAdapter prioridadesOrdenServicioTableAdapter1;
        private SPControladoraDatos.dsSpx dsSpx2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbCiudadDestino;
        private System.Windows.Forms.ComboBox cmbPaisDEstino;
        private System.Windows.Forms.ComboBox cmbDepartamentoDestino;
        private System.Windows.Forms.Button btnLimpiarDepartamento;
        private System.Windows.Forms.Button btnLimpiarCiudad;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label12;
        private SPControladoraDatos.dsPlantillasTableAdapters.pltDetalleProgramacionViajesTableAdapter pltDetalleProgramacionViajesTableAdapter1;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX btnAgregar;
        private DevComponents.DotNetBar.ButtonX btnAgregarTodos;
        private DevComponents.DotNetBar.ButtonX btnQuitarTodosDetalles;
        private DevComponents.DotNetBar.ButtonX btnQuitarDetalle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox5;
        private DevComponents.DotNetBar.ButtonX btnConfirmarTodos;
        private DevComponents.DotNetBar.ButtonX btnModificar;
        private DevComponents.DotNetBar.ButtonX btnDesconfirmarTodos;
        private DevComponents.DotNetBar.ButtonX btnGuardarGrilla;
        private DevComponents.DotNetBar.ButtonX btnReinicciargrilla;
        private DevComponents.DotNetBar.ButtonX btnGuardarListaProgramacion;
        private DevComponents.DotNetBar.ButtonX btnRestaurarListaProgramacion;
        private DevComponents.DotNetBar.ButtonX btnExportarExcelProgramacion;
        private System.Windows.Forms.ComboBox cmbAsesorComercial;
        private System.Windows.Forms.Label label14;
        private SPControladoraDatos.dsSpxTableAdapters.asesoresComercialesTableAdapter asesoresComercialesTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.notificacionTableAdapter notificacionTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.contratosTableAdapter contratosTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.mantenimientosxContratoTableAdapter mantenimientosxContratoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.contratosxEquipoTableAdapter contratosxEquipoTableAdapter1;
        private SPXSeguridad.data.cls.clsTusuario clsTusuario1;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad1;
    }
}