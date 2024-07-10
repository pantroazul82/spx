namespace spProcesos.Herramientas
{
    partial class frmTrasladosMasivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrasladosMasivos));
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.logCambioUbicacionesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.logCambioUbicacionesTableAdapter();
            this.label43 = new System.Windows.Forms.Label();
            this.txtObservacionesIniciales = new System.Windows.Forms.TextBox();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.chkConservarOrigen = new System.Windows.Forms.CheckBox();
            this.cmbEstadoEquipoLocal = new System.Windows.Forms.ComboBox();
            this.dsSpx2 = new SPControladoraDatos.dsSpx();
            this.chkEnvioCliente = new System.Windows.Forms.CheckBox();
            this.lblEstadoEquipo = new System.Windows.Forms.Label();
            this.btnLimpiarCliente = new System.Windows.Forms.Button();
            this.btnBuscarNit = new DevComponents.DotNetBar.ButtonX();
            this.calUltimoEnvio = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cmbModaldad = new System.Windows.Forms.ComboBox();
            this.lblModalidad = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.cmbSucursalCliente = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnTraerEquipos = new DevComponents.DotNetBar.ButtonX();
            this.cmbEstadoEquipoOrigen = new System.Windows.Forms.ComboBox();
            this.lblEstadoEqupoOrigen = new System.Windows.Forms.Label();
            this.cmbModalidadOrigen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSucursalOrigen = new System.Windows.Forms.Label();
            this.cmbSucursalOrigen = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuscarNitorigen = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbClienteOrigen = new System.Windows.Forms.ComboBox();
            this.ciudadesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ciudadesTableAdapter();
            this.clientesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.clientesTableAdapter();
            this.departamentoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.departamentoTableAdapter();
            this.paisesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.paisesTableAdapter();
            this.fabricanteTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.fabricanteTableAdapter();
            this.modelosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter();
            this.estadoLocalEquiposTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.estadoLocalEquiposTableAdapter();
            this.modalidadEquipoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ModalidadEquipoTableAdapter();
            this.equiposTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter();
            this.sucursalClienteTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.sucursalClienteTableAdapter();
            this.equipoAuxiliarTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.equipoAuxiliarTableAdapter();
            this.dsPlantillas1 = new SPControladoraDatos.dsPlantillas();
            this.vistaEquipoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.vistaEquipoTableAdapter();
            this.grdEquipos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.btnGuardarGrilla = new DevComponents.DotNetBar.ButtonX();
            this.btnReinicciargrilla = new DevComponents.DotNetBar.ButtonX();
            this.btnLimpiar = new DevComponents.DotNetBar.ButtonX();
            this.btnExportarExcel = new DevComponents.DotNetBar.ButtonX();
            this.btnBorrarRegistro = new DevComponents.DotNetBar.ButtonX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.pnlInicio = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlDos = new System.Windows.Forms.Panel();
            this.equiposTableAdapter2 = new SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calUltimoEnvio)).BeginInit();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEquipos)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlInicio.SuspendLayout();
            this.pnlDos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.EnforceConstraints = false;
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logCambioUbicacionesTableAdapter1
            // 
            this.logCambioUbicacionesTableAdapter1.ClearBeforeFill = true;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Transparent;
            this.label43.Location = new System.Drawing.Point(13, 369);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(98, 13);
            this.label43.TabIndex = 75;
            this.label43.Text = "Motivo de Traslado";
            // 
            // txtObservacionesIniciales
            // 
            this.txtObservacionesIniciales.Location = new System.Drawing.Point(14, 387);
            this.txtObservacionesIniciales.Multiline = true;
            this.txtObservacionesIniciales.Name = "txtObservacionesIniciales";
            this.txtObservacionesIniciales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacionesIniciales.Size = new System.Drawing.Size(530, 82);
            this.txtObservacionesIniciales.TabIndex = 74;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.chkConservarOrigen);
            this.groupPanel1.Controls.Add(this.cmbEstadoEquipoLocal);
            this.groupPanel1.Controls.Add(this.txtObservacionesIniciales);
            this.groupPanel1.Controls.Add(this.label43);
            this.groupPanel1.Controls.Add(this.chkEnvioCliente);
            this.groupPanel1.Controls.Add(this.lblEstadoEquipo);
            this.groupPanel1.Controls.Add(this.btnLimpiarCliente);
            this.groupPanel1.Controls.Add(this.btnBuscarNit);
            this.groupPanel1.Controls.Add(this.calUltimoEnvio);
            this.groupPanel1.Controls.Add(this.cmbModaldad);
            this.groupPanel1.Controls.Add(this.lblModalidad);
            this.groupPanel1.Controls.Add(this.txtDepartamento);
            this.groupPanel1.Controls.Add(this.txtCiudad);
            this.groupPanel1.Controls.Add(this.txtPais);
            this.groupPanel1.Controls.Add(this.cmbCliente);
            this.groupPanel1.Controls.Add(this.lblPais);
            this.groupPanel1.Controls.Add(this.label4);
            this.groupPanel1.Controls.Add(this.lblDepartamento);
            this.groupPanel1.Controls.Add(this.lblCiudad);
            this.groupPanel1.Controls.Add(this.lblSucursal);
            this.groupPanel1.Controls.Add(this.lblDireccion);
            this.groupPanel1.Controls.Add(this.cmbSucursalCliente);
            this.groupPanel1.Controls.Add(this.txtDireccion);
            this.groupPanel1.Location = new System.Drawing.Point(227, 25);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(565, 494);
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
            this.groupPanel1.TabIndex = 76;
            this.groupPanel1.Text = "Ubicacion Destino";
            // 
            // chkConservarOrigen
            // 
            this.chkConservarOrigen.AutoSize = true;
            this.chkConservarOrigen.BackColor = System.Drawing.Color.Transparent;
            this.chkConservarOrigen.Location = new System.Drawing.Point(115, 132);
            this.chkConservarOrigen.Name = "chkConservarOrigen";
            this.chkConservarOrigen.Size = new System.Drawing.Size(206, 17);
            this.chkConservarOrigen.TabIndex = 83;
            this.chkConservarOrigen.Text = "Conservar La Configuracion de Origen";
            this.chkConservarOrigen.UseVisualStyleBackColor = false;
            // 
            // cmbEstadoEquipoLocal
            // 
            this.cmbEstadoEquipoLocal.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsSpx2, "equipos.codEstadoLocal", true));
            this.cmbEstadoEquipoLocal.DataSource = this.dsSpx2;
            this.cmbEstadoEquipoLocal.DisplayMember = "estadoLocalEquipos.nombreEstadoLocal";
            this.cmbEstadoEquipoLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoEquipoLocal.FormattingEnabled = true;
            this.cmbEstadoEquipoLocal.Location = new System.Drawing.Point(115, 132);
            this.cmbEstadoEquipoLocal.MaxLength = 5;
            this.cmbEstadoEquipoLocal.Name = "cmbEstadoEquipoLocal";
            this.cmbEstadoEquipoLocal.Size = new System.Drawing.Size(225, 21);
            this.cmbEstadoEquipoLocal.TabIndex = 39;
            this.cmbEstadoEquipoLocal.ValueMember = "estadoLocalEquipos.codEstadoLocal";
            // 
            // dsSpx2
            // 
            this.dsSpx2.DataSetName = "dsSpx";
            this.dsSpx2.EnforceConstraints = false;
            this.dsSpx2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chkEnvioCliente
            // 
            this.chkEnvioCliente.AutoSize = true;
            this.chkEnvioCliente.BackColor = System.Drawing.Color.Transparent;
            this.chkEnvioCliente.Location = new System.Drawing.Point(8, 329);
            this.chkEnvioCliente.Name = "chkEnvioCliente";
            this.chkEnvioCliente.Size = new System.Drawing.Size(121, 17);
            this.chkEnvioCliente.TabIndex = 82;
            this.chkEnvioCliente.Text = "Fecha Envio Cliente";
            this.chkEnvioCliente.UseVisualStyleBackColor = false;
            // 
            // lblEstadoEquipo
            // 
            this.lblEstadoEquipo.AutoSize = true;
            this.lblEstadoEquipo.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoEquipo.Location = new System.Drawing.Point(3, 136);
            this.lblEstadoEquipo.Name = "lblEstadoEquipo";
            this.lblEstadoEquipo.Size = new System.Drawing.Size(76, 13);
            this.lblEstadoEquipo.TabIndex = 38;
            this.lblEstadoEquipo.Text = "Estado Equipo";
            // 
            // btnLimpiarCliente
            // 
            this.btnLimpiarCliente.Location = new System.Drawing.Point(349, 21);
            this.btnLimpiarCliente.Name = "btnLimpiarCliente";
            this.btnLimpiarCliente.Size = new System.Drawing.Size(19, 23);
            this.btnLimpiarCliente.TabIndex = 41;
            this.btnLimpiarCliente.Text = "x";
            this.btnLimpiarCliente.UseVisualStyleBackColor = true;
            this.btnLimpiarCliente.Click += new System.EventHandler(this.btnLimpiarCliente_Click);
            // 
            // btnBuscarNit
            // 
            this.btnBuscarNit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscarNit.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarNit.Image")));
            this.btnBuscarNit.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnBuscarNit.Location = new System.Drawing.Point(369, 19);
            this.btnBuscarNit.Name = "btnBuscarNit";
            this.btnBuscarNit.Size = new System.Drawing.Size(35, 33);
            this.btnBuscarNit.TabIndex = 40;
            this.btnBuscarNit.Click += new System.EventHandler(this.btnBuscarNit_Click);
            // 
            // calUltimoEnvio
            // 
            // 
            // 
            // 
            this.calUltimoEnvio.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calUltimoEnvio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calUltimoEnvio.ButtonDropDown.Visible = true;
            this.calUltimoEnvio.Location = new System.Drawing.Point(135, 329);
            // 
            // 
            // 
            this.calUltimoEnvio.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calUltimoEnvio.MonthCalendar.BackgroundStyle.Class = "";
            this.calUltimoEnvio.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calUltimoEnvio.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calUltimoEnvio.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calUltimoEnvio.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calUltimoEnvio.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calUltimoEnvio.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calUltimoEnvio.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calUltimoEnvio.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calUltimoEnvio.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calUltimoEnvio.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calUltimoEnvio.MonthCalendar.DisplayMonth = new System.DateTime(2009, 2, 1, 0, 0, 0, 0);
            this.calUltimoEnvio.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calUltimoEnvio.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calUltimoEnvio.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calUltimoEnvio.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calUltimoEnvio.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calUltimoEnvio.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calUltimoEnvio.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calUltimoEnvio.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calUltimoEnvio.MonthCalendar.TodayButtonVisible = true;
            this.calUltimoEnvio.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calUltimoEnvio.Name = "calUltimoEnvio";
            this.calUltimoEnvio.Size = new System.Drawing.Size(200, 20);
            this.calUltimoEnvio.TabIndex = 81;
            // 
            // cmbModaldad
            // 
            this.cmbModaldad.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsSpx2, "equipos.codModalidadEquipo", true));
            this.cmbModaldad.DataSource = this.dsSpx2;
            this.cmbModaldad.DisplayMember = "ModalidadEquipo.nombreModalidadEquipo";
            this.cmbModaldad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModaldad.FormattingEnabled = true;
            this.cmbModaldad.Location = new System.Drawing.Point(115, 95);
            this.cmbModaldad.MaxLength = 5;
            this.cmbModaldad.Name = "cmbModaldad";
            this.cmbModaldad.Size = new System.Drawing.Size(225, 21);
            this.cmbModaldad.TabIndex = 37;
            this.cmbModaldad.ValueMember = "ModalidadEquipo.codModalidadEquipo";
            // 
            // lblModalidad
            // 
            this.lblModalidad.AutoSize = true;
            this.lblModalidad.BackColor = System.Drawing.Color.Transparent;
            this.lblModalidad.Location = new System.Drawing.Point(3, 99);
            this.lblModalidad.Name = "lblModalidad";
            this.lblModalidad.Size = new System.Drawing.Size(56, 13);
            this.lblModalidad.TabIndex = 36;
            this.lblModalidad.Text = "Modalidad";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(115, 205);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.ReadOnly = true;
            this.txtDepartamento.Size = new System.Drawing.Size(196, 20);
            this.txtDepartamento.TabIndex = 35;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(115, 169);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.ReadOnly = true;
            this.txtCiudad.Size = new System.Drawing.Size(196, 20);
            this.txtCiudad.TabIndex = 33;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(115, 241);
            this.txtPais.Name = "txtPais";
            this.txtPais.ReadOnly = true;
            this.txtPais.Size = new System.Drawing.Size(196, 20);
            this.txtPais.TabIndex = 34;
            // 
            // cmbCliente
            // 
            this.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsSpx2, "equipos.nitClienteUbica", true));
            this.cmbCliente.DataSource = this.dsSpx2;
            this.cmbCliente.DisplayMember = "clientes.nombreCliente";
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(115, 21);
            this.cmbCliente.MaxLength = 20;
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(225, 21);
            this.cmbCliente.TabIndex = 15;
            this.cmbCliente.ValueMember = "clientes.nitCliente";
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.BackColor = System.Drawing.Color.Transparent;
            this.lblPais.Location = new System.Drawing.Point(3, 245);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(27, 13);
            this.lblPais.TabIndex = 32;
            this.lblPais.Text = "Pais";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(3, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cliente";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartamento.Location = new System.Drawing.Point(3, 209);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(74, 13);
            this.lblDepartamento.TabIndex = 31;
            this.lblDepartamento.Text = "Departamento";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.BackColor = System.Drawing.Color.Transparent;
            this.lblCiudad.Location = new System.Drawing.Point(3, 173);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(40, 13);
            this.lblCiudad.TabIndex = 30;
            this.lblCiudad.Text = "Ciudad";
            // 
            // lblSucursal
            // 
            this.lblSucursal.BackColor = System.Drawing.Color.Transparent;
            this.lblSucursal.Location = new System.Drawing.Point(3, 56);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(71, 40);
            this.lblSucursal.TabIndex = 8;
            this.lblSucursal.Text = "Sucursal";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccion.Location = new System.Drawing.Point(3, 281);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 10;
            this.lblDireccion.Text = "Direccion";
            // 
            // cmbSucursalCliente
            // 
            this.cmbSucursalCliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsSpx2, "equipos.codSucursalUbica", true));
            this.cmbSucursalCliente.DataSource = this.dsSpx2;
            this.cmbSucursalCliente.DisplayMember = "sucursalCliente.nombreSucursal";
            this.cmbSucursalCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursalCliente.FormattingEnabled = true;
            this.cmbSucursalCliente.Location = new System.Drawing.Point(115, 58);
            this.cmbSucursalCliente.MaxLength = 5;
            this.cmbSucursalCliente.Name = "cmbSucursalCliente";
            this.cmbSucursalCliente.Size = new System.Drawing.Size(225, 21);
            this.cmbSucursalCliente.TabIndex = 18;
            this.cmbSucursalCliente.ValueMember = "sucursalCliente.codSucursal";
            this.cmbSucursalCliente.SelectedIndexChanged += new System.EventHandler(this.cmbSucursalCliente_SelectedIndexChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(115, 277);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(270, 20);
            this.txtDireccion.TabIndex = 22;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(433, 27);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 77;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Visible = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(510, 27);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 78;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btnTraerEquipos);
            this.groupPanel2.Controls.Add(this.cmbEstadoEquipoOrigen);
            this.groupPanel2.Controls.Add(this.lblEstadoEqupoOrigen);
            this.groupPanel2.Controls.Add(this.cmbModalidadOrigen);
            this.groupPanel2.Controls.Add(this.label2);
            this.groupPanel2.Controls.Add(this.lblSucursalOrigen);
            this.groupPanel2.Controls.Add(this.cmbSucursalOrigen);
            this.groupPanel2.Controls.Add(this.button1);
            this.groupPanel2.Controls.Add(this.btnBuscarNitorigen);
            this.groupPanel2.Controls.Add(this.label1);
            this.groupPanel2.Controls.Add(this.cmbClienteOrigen);
            this.groupPanel2.Location = new System.Drawing.Point(12, 3);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(416, 185);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.Class = "";
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.Class = "";
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.Class = "";
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 79;
            this.groupPanel2.Text = "Informacion Origen";
            // 
            // btnTraerEquipos
            // 
            this.btnTraerEquipos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnTraerEquipos, "Traer Equipos");
            this.balloonTip1.SetBalloonText(this.btnTraerEquipos, null);
            this.btnTraerEquipos.Image = ((System.Drawing.Image)(resources.GetObject("btnTraerEquipos.Image")));
            this.btnTraerEquipos.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnTraerEquipos.Location = new System.Drawing.Point(347, 97);
            this.btnTraerEquipos.Name = "btnTraerEquipos";
            this.btnTraerEquipos.Size = new System.Drawing.Size(60, 33);
            this.btnTraerEquipos.TabIndex = 93;
            this.btnTraerEquipos.Click += new System.EventHandler(this.btnTraerEquipos_Click);
            // 
            // cmbEstadoEquipoOrigen
            // 
            this.cmbEstadoEquipoOrigen.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsSpx2, "equipos.codEstadoLocal", true));
            this.cmbEstadoEquipoOrigen.DataSource = this.dsSpx1;
            this.cmbEstadoEquipoOrigen.DisplayMember = "estadoLocalEquipos.nombreEstadoLocal";
            this.cmbEstadoEquipoOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoEquipoOrigen.FormattingEnabled = true;
            this.cmbEstadoEquipoOrigen.Location = new System.Drawing.Point(99, 106);
            this.cmbEstadoEquipoOrigen.MaxLength = 5;
            this.cmbEstadoEquipoOrigen.Name = "cmbEstadoEquipoOrigen";
            this.cmbEstadoEquipoOrigen.Size = new System.Drawing.Size(225, 21);
            this.cmbEstadoEquipoOrigen.TabIndex = 92;
            this.cmbEstadoEquipoOrigen.ValueMember = "estadoLocalEquipos.codEstadoLocal";
            // 
            // lblEstadoEqupoOrigen
            // 
            this.lblEstadoEqupoOrigen.AutoSize = true;
            this.lblEstadoEqupoOrigen.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoEqupoOrigen.Location = new System.Drawing.Point(13, 108);
            this.lblEstadoEqupoOrigen.Name = "lblEstadoEqupoOrigen";
            this.lblEstadoEqupoOrigen.Size = new System.Drawing.Size(76, 13);
            this.lblEstadoEqupoOrigen.TabIndex = 91;
            this.lblEstadoEqupoOrigen.Text = "Estado Equipo";
            // 
            // cmbModalidadOrigen
            // 
            this.cmbModalidadOrigen.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsSpx2, "equipos.codModalidadEquipo", true));
            this.cmbModalidadOrigen.DataSource = this.dsSpx1;
            this.cmbModalidadOrigen.DisplayMember = "ModalidadEquipo.nombreModalidadEquipo";
            this.cmbModalidadOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModalidadOrigen.FormattingEnabled = true;
            this.cmbModalidadOrigen.Location = new System.Drawing.Point(99, 75);
            this.cmbModalidadOrigen.MaxLength = 5;
            this.cmbModalidadOrigen.Name = "cmbModalidadOrigen";
            this.cmbModalidadOrigen.Size = new System.Drawing.Size(225, 21);
            this.cmbModalidadOrigen.TabIndex = 90;
            this.cmbModalidadOrigen.ValueMember = "ModalidadEquipo.codModalidadEquipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 89;
            this.label2.Text = "Modalidad";
            // 
            // lblSucursalOrigen
            // 
            this.lblSucursalOrigen.BackColor = System.Drawing.Color.Transparent;
            this.lblSucursalOrigen.Location = new System.Drawing.Point(13, 44);
            this.lblSucursalOrigen.Name = "lblSucursalOrigen";
            this.lblSucursalOrigen.Size = new System.Drawing.Size(79, 30);
            this.lblSucursalOrigen.TabIndex = 87;
            this.lblSucursalOrigen.Text = "Sucursal";
            // 
            // cmbSucursalOrigen
            // 
            this.cmbSucursalOrigen.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsSpx2, "equipos.codSucursalUbica", true));
            this.cmbSucursalOrigen.DataSource = this.dsSpx1;
            this.cmbSucursalOrigen.DisplayMember = "sucursalCliente.nombreSucursal";
            this.cmbSucursalOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursalOrigen.FormattingEnabled = true;
            this.cmbSucursalOrigen.Location = new System.Drawing.Point(99, 41);
            this.cmbSucursalOrigen.MaxLength = 5;
            this.cmbSucursalOrigen.Name = "cmbSucursalOrigen";
            this.cmbSucursalOrigen.Size = new System.Drawing.Size(225, 21);
            this.cmbSucursalOrigen.TabIndex = 88;
            this.cmbSucursalOrigen.ValueMember = "sucursalCliente.codSucursal";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 23);
            this.button1.TabIndex = 86;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscarNitorigen
            // 
            this.btnBuscarNitorigen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscarNitorigen.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarNitorigen.Image")));
            this.btnBuscarNitorigen.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnBuscarNitorigen.Location = new System.Drawing.Point(347, 4);
            this.btnBuscarNitorigen.Name = "btnBuscarNitorigen";
            this.btnBuscarNitorigen.Size = new System.Drawing.Size(35, 33);
            this.btnBuscarNitorigen.TabIndex = 85;
            this.btnBuscarNitorigen.Click += new System.EventHandler(this.btnBuscarNitorigen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "Cliente";
            // 
            // cmbClienteOrigen
            // 
            this.cmbClienteOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbClienteOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbClienteOrigen.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsSpx2, "equipos.nitClienteUbica", true));
            this.cmbClienteOrigen.DataSource = this.dsSpx1;
            this.cmbClienteOrigen.DisplayMember = "clientes.nombreCliente";
            this.cmbClienteOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClienteOrigen.FormattingEnabled = true;
            this.cmbClienteOrigen.Location = new System.Drawing.Point(99, 8);
            this.cmbClienteOrigen.MaxLength = 20;
            this.cmbClienteOrigen.Name = "cmbClienteOrigen";
            this.cmbClienteOrigen.Size = new System.Drawing.Size(225, 21);
            this.cmbClienteOrigen.TabIndex = 84;
            this.cmbClienteOrigen.ValueMember = "clientes.nitCliente";
            this.cmbClienteOrigen.SelectedIndexChanged += new System.EventHandler(this.cmbClienteOrigen_SelectedIndexChanged);
            // 
            // ciudadesTableAdapter1
            // 
            this.ciudadesTableAdapter1.ClearBeforeFill = true;
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // departamentoTableAdapter1
            // 
            this.departamentoTableAdapter1.ClearBeforeFill = true;
            // 
            // paisesTableAdapter1
            // 
            this.paisesTableAdapter1.ClearBeforeFill = true;
            // 
            // fabricanteTableAdapter1
            // 
            this.fabricanteTableAdapter1.ClearBeforeFill = true;
            // 
            // modelosTableAdapter1
            // 
            this.modelosTableAdapter1.ClearBeforeFill = true;
            // 
            // estadoLocalEquiposTableAdapter1
            // 
            this.estadoLocalEquiposTableAdapter1.ClearBeforeFill = true;
            // 
            // modalidadEquipoTableAdapter1
            // 
            this.modalidadEquipoTableAdapter1.ClearBeforeFill = true;
            // 
            // equiposTableAdapter1
            // 
            this.equiposTableAdapter1.ClearBeforeFill = true;
            // 
            // sucursalClienteTableAdapter1
            // 
            this.sucursalClienteTableAdapter1.ClearBeforeFill = true;
            // 
            // equipoAuxiliarTableAdapter1
            // 
            this.equipoAuxiliarTableAdapter1.ClearBeforeFill = true;
            // 
            // dsPlantillas1
            // 
            this.dsPlantillas1.DataSetName = "dsPlantillas";
            this.dsPlantillas1.EnforceConstraints = false;
            this.dsPlantillas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaEquipoTableAdapter1
            // 
            this.vistaEquipoTableAdapter1.ClearBeforeFill = true;
            // 
            // grdEquipos
            // 
            this.grdEquipos.AllowUpdate = false;
            this.grdEquipos.DataMember = "vistaEquipo";
            this.grdEquipos.DataSource = this.dsSpx1;
            this.grdEquipos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdEquipos.Images"))));
            this.grdEquipos.Location = new System.Drawing.Point(12, 194);
            this.grdEquipos.Name = "grdEquipos";
            this.grdEquipos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdEquipos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdEquipos.PreviewInfo.ZoomFactor = 75D;
            this.grdEquipos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdEquipos.PrintInfo.PageSettings")));
            this.grdEquipos.Size = new System.Drawing.Size(988, 321);
            this.grdEquipos.TabIndex = 83;
            this.grdEquipos.Text = "c1TrueDBGrid1";
            this.grdEquipos.PropBag = resources.GetString("grdEquipos.PropBag");
            // 
            // btnGuardarGrilla
            // 
            this.btnGuardarGrilla.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGuardarGrilla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnGuardarGrilla, "Guardar Columnas");
            this.balloonTip1.SetBalloonText(this.btnGuardarGrilla, "Guarda El Esquema de las Columnas");
            this.btnGuardarGrilla.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarGrilla.Image")));
            this.btnGuardarGrilla.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnGuardarGrilla.Location = new System.Drawing.Point(895, 155);
            this.btnGuardarGrilla.Name = "btnGuardarGrilla";
            this.btnGuardarGrilla.Size = new System.Drawing.Size(33, 33);
            this.btnGuardarGrilla.TabIndex = 88;
            this.btnGuardarGrilla.Click += new System.EventHandler(this.btnGuardarGrilla_Click);
            // 
            // btnReinicciargrilla
            // 
            this.btnReinicciargrilla.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReinicciargrilla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnReinicciargrilla, "Restaurar Columnas");
            this.balloonTip1.SetBalloonText(this.btnReinicciargrilla, "Restaurar Columnas a su Valor Original");
            this.btnReinicciargrilla.Image = ((System.Drawing.Image)(resources.GetObject("btnReinicciargrilla.Image")));
            this.btnReinicciargrilla.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnReinicciargrilla.Location = new System.Drawing.Point(860, 155);
            this.btnReinicciargrilla.Name = "btnReinicciargrilla";
            this.btnReinicciargrilla.Size = new System.Drawing.Size(33, 33);
            this.btnReinicciargrilla.TabIndex = 87;
            this.btnReinicciargrilla.Click += new System.EventHandler(this.btnReinicciargrilla_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnLimpiar, "Limpiar Grilla");
            this.balloonTip1.SetBalloonText(this.btnLimpiar, null);
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnLimpiar.Location = new System.Drawing.Point(930, 155);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(33, 33);
            this.btnLimpiar.TabIndex = 86;
            this.btnLimpiar.Text = " ";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExportarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnExportarExcel, "Exportar Excel");
            this.balloonTip1.SetBalloonText(this.btnExportarExcel, null);
            this.btnExportarExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarExcel.Image")));
            this.btnExportarExcel.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnExportarExcel.Location = new System.Drawing.Point(965, 155);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(33, 33);
            this.btnExportarExcel.TabIndex = 85;
            this.btnExportarExcel.Text = " ";
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // btnBorrarRegistro
            // 
            this.btnBorrarRegistro.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBorrarRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnBorrarRegistro, "Quitar Equipo del Listado a Trasladar");
            this.balloonTip1.SetBalloonText(this.btnBorrarRegistro, null);
            this.btnBorrarRegistro.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrarRegistro.Image")));
            this.btnBorrarRegistro.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnBorrarRegistro.Location = new System.Drawing.Point(825, 155);
            this.btnBorrarRegistro.Name = "btnBorrarRegistro";
            this.btnBorrarRegistro.Size = new System.Drawing.Size(33, 33);
            this.btnBorrarRegistro.TabIndex = 84;
            this.btnBorrarRegistro.Text = " ";
            this.btnBorrarRegistro.Click += new System.EventHandler(this.btnBorrarRegistro_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnAnterior);
            this.panel1.Controls.Add(this.btnSiguiente);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 542);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 62);
            this.panel1.TabIndex = 84;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(355, 27);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 80;
            this.btnAnterior.Text = "Atras";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Visible = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(433, 6);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 79;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // pnlInicio
            // 
            this.pnlInicio.Controls.Add(this.textBox1);
            this.pnlInicio.Controls.Add(this.btnGuardarGrilla);
            this.pnlInicio.Controls.Add(this.btnReinicciargrilla);
            this.pnlInicio.Controls.Add(this.btnLimpiar);
            this.pnlInicio.Controls.Add(this.btnExportarExcel);
            this.pnlInicio.Controls.Add(this.btnBorrarRegistro);
            this.pnlInicio.Controls.Add(this.groupPanel2);
            this.pnlInicio.Controls.Add(this.grdEquipos);
            this.pnlInicio.Location = new System.Drawing.Point(4, 5);
            this.pnlInicio.Name = "pnlInicio";
            this.pnlInicio.Size = new System.Drawing.Size(1007, 531);
            this.pnlInicio.TabIndex = 85;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(637, 8);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(360, 61);
            this.textBox1.TabIndex = 89;
            this.textBox1.Text = "1. Seleccione una primera busqueda con la informacion de origen.\r\n2. elimine del " +
    "listado los equipos que no desea trasladar\r\n3. siguiente paso";
            // 
            // pnlDos
            // 
            this.pnlDos.Controls.Add(this.groupPanel1);
            this.pnlDos.Location = new System.Drawing.Point(1, 8);
            this.pnlDos.Name = "pnlDos";
            this.pnlDos.Size = new System.Drawing.Size(1005, 525);
            this.pnlDos.TabIndex = 86;
            this.pnlDos.Visible = false;
            // 
            // equiposTableAdapter2
            // 
            this.equiposTableAdapter2.ClearBeforeFill = true;
            // 
            // frmTrasladosMasivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1018, 604);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlInicio);
            this.Controls.Add(this.pnlDos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTrasladosMasivos";
            this.Text = "Traslados De Equipos";
            this.Load += new System.EventHandler(this.frmTrasladosDeEquipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calUltimoEnvio)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEquipos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlInicio.ResumeLayout(false);
            this.pnlInicio.PerformLayout();
            this.pnlDos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.logCambioUbicacionesTableAdapter logCambioUbicacionesTableAdapter1;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox txtObservacionesIniciales;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.ComboBox cmbEstadoEquipoLocal;
        private System.Windows.Forms.Label lblEstadoEquipo;
        private System.Windows.Forms.Button btnLimpiarCliente;
        private DevComponents.DotNetBar.ButtonX btnBuscarNit;
        private System.Windows.Forms.ComboBox cmbModaldad;
        private System.Windows.Forms.Label lblModalidad;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.ComboBox cmbSucursalCliente;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private SPControladoraDatos.dsSpxTableAdapters.ciudadesTableAdapter ciudadesTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.clientesTableAdapter clientesTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.departamentoTableAdapter departamentoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.paisesTableAdapter paisesTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.fabricanteTableAdapter fabricanteTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter modelosTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.estadoLocalEquiposTableAdapter estadoLocalEquiposTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.ModalidadEquipoTableAdapter modalidadEquipoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter equiposTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.sucursalClienteTableAdapter sucursalClienteTableAdapter1;
        private SPControladoraDatos.dsSpx dsSpx2;
        private SPControladoraDatos.dsSpxTableAdapters.equipoAuxiliarTableAdapter equipoAuxiliarTableAdapter1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calUltimoEnvio;
        private System.Windows.Forms.CheckBox chkEnvioCliente;
        private System.Windows.Forms.ComboBox cmbModalidadOrigen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSucursalOrigen;
        private System.Windows.Forms.ComboBox cmbSucursalOrigen;
        private System.Windows.Forms.Button button1;
        private DevComponents.DotNetBar.ButtonX btnBuscarNitorigen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClienteOrigen;
        private System.Windows.Forms.ComboBox cmbEstadoEquipoOrigen;
        private System.Windows.Forms.Label lblEstadoEqupoOrigen;
        private SPControladoraDatos.dsPlantillas dsPlantillas1;
        private DevComponents.DotNetBar.ButtonX btnTraerEquipos;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private SPControladoraDatos.dsSpxTableAdapters.vistaEquipoTableAdapter vistaEquipoTableAdapter1;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdEquipos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Panel pnlInicio;
        private System.Windows.Forms.Panel pnlDos;
        private System.Windows.Forms.Button btnAnterior;
        private DevComponents.DotNetBar.ButtonX btnGuardarGrilla;
        private DevComponents.DotNetBar.ButtonX btnReinicciargrilla;
        private DevComponents.DotNetBar.ButtonX btnLimpiar;
        private DevComponents.DotNetBar.ButtonX btnExportarExcel;
        private DevComponents.DotNetBar.ButtonX btnBorrarRegistro;
        private SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter equiposTableAdapter2;
        private System.Windows.Forms.CheckBox chkConservarOrigen;
        private System.Windows.Forms.TextBox textBox1;
    }
}