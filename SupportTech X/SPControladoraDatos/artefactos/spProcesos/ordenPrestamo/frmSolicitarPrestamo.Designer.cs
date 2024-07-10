namespace spProcesos.ordenPrestamo
{
    partial class frmSolicitarPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSolicitarPrestamo));
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.paisesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.paisesTableAdapter();
            this.ciudadesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ciudadesTableAdapter();
            this.departamentoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.departamentoTableAdapter();
            this.defaultsTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter();
            this.ordenPrestamoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.OrdenPrestamoTableAdapter();
            this.repuestosxOrdenPrestamoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.repuestosxOrdenPrestamoTableAdapter();
            this.observacionesxOrdenPrestamoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ObservacionesxOrdenPrestamoTableAdapter();
            this.repuestosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.repuestosTableAdapter();
            this.pltRepuestosxOrdenPrestamoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.pltRepuestosxOrdenPrestamoTableAdapter();
            this.calFechaCreacion = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumeroOrdenPrestamo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAgregarRepuesto = new DevComponents.DotNetBar.ButtonX();
            this.btnModificarRepuestos = new DevComponents.DotNetBar.ButtonX();
            this.btnEliminarRepuesto = new DevComponents.DotNetBar.ButtonX();
            this.label9 = new System.Windows.Forms.Label();
            this.grpUbicacion = new System.Windows.Forms.GroupBox();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.grdRepuestos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.txtElaboradoPor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbResponsable = new System.Windows.Forms.ComboBox();
            this.dsSPXSeguridad1 = new SPXSeguridad.data.dsSPXSeguridad();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ordenServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter();
            this.sucursalClienteTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.sucursalClienteTableAdapter();
            this.lblCodOrden = new System.Windows.Forms.Label();
            this.txtCodOrdenservicio = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clsTusuario1 = new SPXSeguridad.data.cls.clsTusuario();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnInfEquipo = new DevComponents.DotNetBar.ButtonX();
            this.txtModalidad = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.btnBuscarSerial = new DevComponents.DotNetBar.ButtonX();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.equiposTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter();
            this.fabricanteTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.fabricanteTableAdapter();
            this.modelosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter();
            this.label11 = new System.Windows.Forms.Label();
            this.txtObservacionesEquipo = new System.Windows.Forms.TextBox();
            this.modalidadEquipoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ModalidadEquipoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaCreacion)).BeginInit();
            this.grpUbicacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRepuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paisesTableAdapter1
            // 
            this.paisesTableAdapter1.ClearBeforeFill = true;
            // 
            // ciudadesTableAdapter1
            // 
            this.ciudadesTableAdapter1.ClearBeforeFill = true;
            // 
            // departamentoTableAdapter1
            // 
            this.departamentoTableAdapter1.ClearBeforeFill = true;
            // 
            // defaultsTableAdapter1
            // 
            this.defaultsTableAdapter1.ClearBeforeFill = true;
            // 
            // ordenPrestamoTableAdapter1
            // 
            this.ordenPrestamoTableAdapter1.ClearBeforeFill = true;
            // 
            // repuestosxOrdenPrestamoTableAdapter1
            // 
            this.repuestosxOrdenPrestamoTableAdapter1.ClearBeforeFill = true;
            // 
            // observacionesxOrdenPrestamoTableAdapter1
            // 
            this.observacionesxOrdenPrestamoTableAdapter1.ClearBeforeFill = true;
            // 
            // repuestosTableAdapter1
            // 
            this.repuestosTableAdapter1.ClearBeforeFill = true;
            // 
            // pltRepuestosxOrdenPrestamoTableAdapter1
            // 
            this.pltRepuestosxOrdenPrestamoTableAdapter1.ClearBeforeFill = true;
            // 
            // calFechaCreacion
            // 
            // 
            // 
            // 
            this.calFechaCreacion.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calFechaCreacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaCreacion.ButtonDropDown.Visible = true;
            this.calFechaCreacion.Enabled = false;
            this.calFechaCreacion.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calFechaCreacion.Location = new System.Drawing.Point(171, 117);
            // 
            // 
            // 
            this.calFechaCreacion.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFechaCreacion.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calFechaCreacion.MonthCalendar.BackgroundStyle.Class = "";
            this.calFechaCreacion.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaCreacion.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calFechaCreacion.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calFechaCreacion.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calFechaCreacion.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calFechaCreacion.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calFechaCreacion.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calFechaCreacion.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calFechaCreacion.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calFechaCreacion.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaCreacion.MonthCalendar.DisplayMonth = new System.DateTime(2008, 6, 1, 0, 0, 0, 0);
            this.calFechaCreacion.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calFechaCreacion.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFechaCreacion.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calFechaCreacion.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calFechaCreacion.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calFechaCreacion.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calFechaCreacion.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaCreacion.MonthCalendar.TodayButtonVisible = true;
            this.calFechaCreacion.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calFechaCreacion.Name = "calFechaCreacion";
            this.calFechaCreacion.Size = new System.Drawing.Size(137, 21);
            this.calFechaCreacion.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Numero Orden de Prestamo";
            // 
            // txtNumeroOrdenPrestamo
            // 
            this.txtNumeroOrdenPrestamo.BackColor = System.Drawing.Color.White;
            this.txtNumeroOrdenPrestamo.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroOrdenPrestamo.Location = new System.Drawing.Point(212, 32);
            this.txtNumeroOrdenPrestamo.Name = "txtNumeroOrdenPrestamo";
            this.txtNumeroOrdenPrestamo.ReadOnly = true;
            this.txtNumeroOrdenPrestamo.Size = new System.Drawing.Size(96, 21);
            this.txtNumeroOrdenPrestamo.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Fecha Creacion";
            // 
            // btnAgregarRepuesto
            // 
            this.btnAgregarRepuesto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregarRepuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarRepuesto.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarRepuesto.Image")));
            this.btnAgregarRepuesto.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnAgregarRepuesto.Location = new System.Drawing.Point(789, 245);
            this.btnAgregarRepuesto.Name = "btnAgregarRepuesto";
            this.btnAgregarRepuesto.Size = new System.Drawing.Size(29, 29);
            this.btnAgregarRepuesto.TabIndex = 99;
            this.btnAgregarRepuesto.Click += new System.EventHandler(this.btnAgregarRepuesto_Click);
            // 
            // btnModificarRepuestos
            // 
            this.btnModificarRepuestos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnModificarRepuestos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarRepuestos.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarRepuestos.Image")));
            this.btnModificarRepuestos.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnModificarRepuestos.Location = new System.Drawing.Point(824, 245);
            this.btnModificarRepuestos.Name = "btnModificarRepuestos";
            this.btnModificarRepuestos.Size = new System.Drawing.Size(29, 29);
            this.btnModificarRepuestos.TabIndex = 98;
            this.btnModificarRepuestos.Click += new System.EventHandler(this.btnModificarRepuestos_Click);
            // 
            // btnEliminarRepuesto
            // 
            this.btnEliminarRepuesto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEliminarRepuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarRepuesto.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarRepuesto.Image")));
            this.btnEliminarRepuesto.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnEliminarRepuesto.Location = new System.Drawing.Point(859, 245);
            this.btnEliminarRepuesto.Name = "btnEliminarRepuesto";
            this.btnEliminarRepuesto.Size = new System.Drawing.Size(29, 29);
            this.btnEliminarRepuesto.TabIndex = 97;
            this.btnEliminarRepuesto.Click += new System.EventHandler(this.btnEliminarRepuesto_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 94;
            this.label9.Text = "Repuestos";
            // 
            // grpUbicacion
            // 
            this.grpUbicacion.Controls.Add(this.cmbCiudad);
            this.grpUbicacion.Controls.Add(this.cmbDepartamento);
            this.grpUbicacion.Controls.Add(this.label6);
            this.grpUbicacion.Controls.Add(this.label5);
            this.grpUbicacion.Controls.Add(this.label4);
            this.grpUbicacion.Controls.Add(this.cmbPais);
            this.grpUbicacion.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUbicacion.Location = new System.Drawing.Point(318, 7);
            this.grpUbicacion.Name = "grpUbicacion";
            this.grpUbicacion.Size = new System.Drawing.Size(216, 140);
            this.grpUbicacion.TabIndex = 87;
            this.grpUbicacion.TabStop = false;
            this.grpUbicacion.Text = "Ubicacion";
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbCiudad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCiudad.DataSource = this.dsSpx1;
            this.cmbCiudad.DisplayMember = "ciudades.nombreCiudad";
            this.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(14, 111);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(185, 21);
            this.cmbCiudad.TabIndex = 25;
            this.cmbCiudad.ValueMember = "ciudades.codCiudad";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbDepartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDepartamento.DataSource = this.dsSpx1;
            this.cmbDepartamento.DisplayMember = "departamento.NombreDepartamento";
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(14, 71);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(185, 21);
            this.cmbDepartamento.TabIndex = 24;
            this.cmbDepartamento.ValueMember = "departamento.codDepartamento";
            this.cmbDepartamento.SelectedIndexChanged += new System.EventHandler(this.cmbDepartamento_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Pais";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Departamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ciudad";
            // 
            // cmbPais
            // 
            this.cmbPais.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbPais.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPais.DataSource = this.dsSpx1;
            this.cmbPais.DisplayMember = "paises.nombrePais";
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(14, 31);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(185, 21);
            this.cmbPais.TabIndex = 20;
            this.cmbPais.ValueMember = "paises.codPais";
            this.cmbPais.SelectedIndexChanged += new System.EventHandler(this.cmbPais_SelectedIndexChanged);
            // 
            // grdRepuestos
            // 
            this.grdRepuestos.AllowUpdate = false;
            this.grdRepuestos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdRepuestos.DataMember = "pltRepuestosxOrdenPrestamo";
            this.grdRepuestos.DataSource = this.dsSpx1;
            this.grdRepuestos.GroupByCaption = "Drag a column header here to group by that column";
            this.grdRepuestos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdRepuestos.Images"))));
            this.grdRepuestos.Location = new System.Drawing.Point(12, 277);
            this.grdRepuestos.Name = "grdRepuestos";
            this.grdRepuestos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdRepuestos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdRepuestos.PreviewInfo.ZoomFactor = 75D;
            this.grdRepuestos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdRepuestos.PrintInfo.PageSettings")));
            this.grdRepuestos.Size = new System.Drawing.Size(875, 206);
            this.grdRepuestos.TabIndex = 85;
            this.grdRepuestos.Text = "c1TrueDBGrid1";
            this.grdRepuestos.PropBag = resources.GetString("grdRepuestos.PropBag");
            // 
            // txtElaboradoPor
            // 
            this.txtElaboradoPor.BackColor = System.Drawing.Color.White;
            this.txtElaboradoPor.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElaboradoPor.Location = new System.Drawing.Point(142, 60);
            this.txtElaboradoPor.Name = "txtElaboradoPor";
            this.txtElaboradoPor.ReadOnly = true;
            this.txtElaboradoPor.Size = new System.Drawing.Size(166, 21);
            this.txtElaboradoPor.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "Elaborado Por";
            // 
            // cmbResponsable
            // 
            this.cmbResponsable.DataSource = this.dsSPXSeguridad1;
            this.cmbResponsable.DisplayMember = "usuario.nombre";
            this.cmbResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResponsable.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbResponsable.FormattingEnabled = true;
            this.cmbResponsable.Location = new System.Drawing.Point(142, 88);
            this.cmbResponsable.Name = "cmbResponsable";
            this.cmbResponsable.Size = new System.Drawing.Size(166, 21);
            this.cmbResponsable.TabIndex = 82;
            this.cmbResponsable.ValueMember = "usuario.login";
            // 
            // dsSPXSeguridad1
            // 
            this.dsSPXSeguridad1.DataSetName = "dsSPXSeguridad";
            this.dsSPXSeguridad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "Ingeniero Responsable";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 515);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 50);
            this.panel1.TabIndex = 100;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(731, 15);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(812, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ordenServicioTableAdapter1
            // 
            this.ordenServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // sucursalClienteTableAdapter1
            // 
            this.sucursalClienteTableAdapter1.ClearBeforeFill = true;
            // 
            // lblCodOrden
            // 
            this.lblCodOrden.AutoSize = true;
            this.lblCodOrden.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodOrden.Location = new System.Drawing.Point(14, 7);
            this.lblCodOrden.Name = "lblCodOrden";
            this.lblCodOrden.Size = new System.Drawing.Size(109, 13);
            this.lblCodOrden.TabIndex = 101;
            this.lblCodOrden.Text = "Codigo Orden Servicio";
            // 
            // txtCodOrdenservicio
            // 
            this.txtCodOrdenservicio.BackColor = System.Drawing.Color.White;
            this.txtCodOrdenservicio.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodOrdenservicio.Location = new System.Drawing.Point(212, 5);
            this.txtCodOrdenservicio.Name = "txtCodOrdenservicio";
            this.txtCodOrdenservicio.ReadOnly = true;
            this.txtCodOrdenservicio.Size = new System.Drawing.Size(96, 21);
            this.txtCodOrdenservicio.TabIndex = 102;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BackColor = System.Drawing.Color.White;
            this.txtObservaciones.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(142, 157);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(386, 90);
            this.txtObservaciones.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 103;
            this.label3.Text = "Observaciones";
            // 
            // clsTusuario1
            // 
            this.clsTusuario1.nombreLlave = "cod_usuario";
            this.clsTusuario1.nombreTabla = "usuario";
            this.clsTusuario1.sentenciaBase = resources.GetString("clsTusuario1.sentenciaBase");
            this.clsTusuario1.sentenciaBaseDistinct = resources.GetString("clsTusuario1.sentenciaBaseDistinct");
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtObservacionesEquipo);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btnInfEquipo);
            this.groupBox3.Controls.Add(this.txtModalidad);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.btnBuscarSerial);
            this.groupBox3.Controls.Add(this.txtFabricante);
            this.groupBox3.Controls.Add(this.txtModelo);
            this.groupBox3.Controls.Add(this.txtSerial);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(543, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 216);
            this.groupBox3.TabIndex = 105;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion del Equipo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(7, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 33;
            this.label10.Text = "Serial";
            // 
            // btnInfEquipo
            // 
            this.btnInfEquipo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInfEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfEquipo.Image")));
            this.btnInfEquipo.ImageFixedSize = new System.Drawing.Size(29, 29);
            this.btnInfEquipo.Location = new System.Drawing.Point(316, 16);
            this.btnInfEquipo.Name = "btnInfEquipo";
            this.btnInfEquipo.Size = new System.Drawing.Size(33, 33);
            this.btnInfEquipo.TabIndex = 67;
            this.btnInfEquipo.Click += new System.EventHandler(this.btnInfEquipo_Click);
            // 
            // txtModalidad
            // 
            this.txtModalidad.Location = new System.Drawing.Point(78, 104);
            this.txtModalidad.Name = "txtModalidad";
            this.txtModalidad.ReadOnly = true;
            this.txtModalidad.Size = new System.Drawing.Size(199, 21);
            this.txtModalidad.TabIndex = 30;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(7, 107);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(66, 15);
            this.label26.TabIndex = 31;
            this.label26.Text = "Modalidad";
            // 
            // btnBuscarSerial
            // 
            this.btnBuscarSerial.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscarSerial.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarSerial.Image")));
            this.btnBuscarSerial.ImageFixedSize = new System.Drawing.Size(29, 29);
            this.btnBuscarSerial.Location = new System.Drawing.Point(279, 16);
            this.btnBuscarSerial.Name = "btnBuscarSerial";
            this.btnBuscarSerial.Size = new System.Drawing.Size(33, 33);
            this.btnBuscarSerial.TabIndex = 29;
            this.btnBuscarSerial.Click += new System.EventHandler(this.btnBuscarSerial_Click);
            // 
            // txtFabricante
            // 
            this.txtFabricante.Location = new System.Drawing.Point(75, 49);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.ReadOnly = true;
            this.txtFabricante.Size = new System.Drawing.Size(199, 21);
            this.txtFabricante.TabIndex = 3;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(75, 76);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.ReadOnly = true;
            this.txtModelo.Size = new System.Drawing.Size(199, 21);
            this.txtModelo.TabIndex = 4;
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(75, 24);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(199, 21);
            this.txtSerial.TabIndex = 0;
            this.txtSerial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSerial_KeyDown);
            this.txtSerial.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtSerial_MouseDoubleClick);
            this.txtSerial.Validating += new System.ComponentModel.CancelEventHandler(this.txtSerial_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 15);
            this.label13.TabIndex = 13;
            this.label13.Text = "Modelo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 15);
            this.label14.TabIndex = 11;
            this.label14.Text = "Fabricante";
            // 
            // equiposTableAdapter1
            // 
            this.equiposTableAdapter1.ClearBeforeFill = true;
            // 
            // fabricanteTableAdapter1
            // 
            this.fabricanteTableAdapter1.ClearBeforeFill = true;
            // 
            // modelosTableAdapter1
            // 
            this.modelosTableAdapter1.ClearBeforeFill = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 15);
            this.label11.TabIndex = 68;
            this.label11.Text = "Observaciones Prestamo Equipo";
            // 
            // txtObservacionesEquipo
            // 
            this.txtObservacionesEquipo.BackColor = System.Drawing.Color.White;
            this.txtObservacionesEquipo.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacionesEquipo.Location = new System.Drawing.Point(10, 150);
            this.txtObservacionesEquipo.Multiline = true;
            this.txtObservacionesEquipo.Name = "txtObservacionesEquipo";
            this.txtObservacionesEquipo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacionesEquipo.Size = new System.Drawing.Size(334, 60);
            this.txtObservacionesEquipo.TabIndex = 105;
            // 
            // modalidadEquipoTableAdapter1
            // 
            this.modalidadEquipoTableAdapter1.ClearBeforeFill = true;
            // 
            // frmSolicitarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(899, 565);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCodOrden);
            this.Controls.Add(this.txtCodOrdenservicio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.calFechaCreacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumeroOrdenPrestamo);
            this.Controls.Add(this.btnAgregarRepuesto);
            this.Controls.Add(this.btnModificarRepuestos);
            this.Controls.Add(this.btnEliminarRepuesto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grpUbicacion);
            this.Controls.Add(this.txtElaboradoPor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbResponsable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdRepuestos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSolicitarPrestamo";
            this.Text = "Solicitar Prestamo";
            this.Load += new System.EventHandler(this.frmSolicitarPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaCreacion)).EndInit();
            this.grpUbicacion.ResumeLayout(false);
            this.grpUbicacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRepuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.paisesTableAdapter paisesTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.ciudadesTableAdapter ciudadesTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.departamentoTableAdapter departamentoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter defaultsTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.OrdenPrestamoTableAdapter ordenPrestamoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.repuestosxOrdenPrestamoTableAdapter repuestosxOrdenPrestamoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.ObservacionesxOrdenPrestamoTableAdapter observacionesxOrdenPrestamoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.repuestosTableAdapter repuestosTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.pltRepuestosxOrdenPrestamoTableAdapter pltRepuestosxOrdenPrestamoTableAdapter1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFechaCreacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumeroOrdenPrestamo;
        private System.Windows.Forms.Label label8;
        private DevComponents.DotNetBar.ButtonX btnAgregarRepuesto;
        private DevComponents.DotNetBar.ButtonX btnModificarRepuestos;
        private DevComponents.DotNetBar.ButtonX btnEliminarRepuesto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpUbicacion;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPais;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdRepuestos;
        private System.Windows.Forms.TextBox txtElaboradoPor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbResponsable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter ordenServicioTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.sucursalClienteTableAdapter sucursalClienteTableAdapter1;
        private System.Windows.Forms.Label lblCodOrden;
        private System.Windows.Forms.TextBox txtCodOrdenservicio;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label3;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad1;
        private SPXSeguridad.data.cls.clsTusuario clsTusuario1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private DevComponents.DotNetBar.ButtonX btnInfEquipo;
        private System.Windows.Forms.TextBox txtModalidad;
        private System.Windows.Forms.Label label26;
        private DevComponents.DotNetBar.ButtonX btnBuscarSerial;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtObservacionesEquipo;
        private System.Windows.Forms.Label label11;
        private SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter equiposTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.fabricanteTableAdapter fabricanteTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter modelosTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.ModalidadEquipoTableAdapter modalidadEquipoTableAdapter1;
    }
}