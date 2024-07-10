namespace spProcesos.ordenPrestamo
{
    partial class frmNuevaOrdenPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevaOrdenPrestamo));
            C1.Win.C1TrueDBGrid.Style style17 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style18 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style19 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style20 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style21 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style22 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style23 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style24 = new C1.Win.C1TrueDBGrid.Style();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.paisesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.paisesTableAdapter();
            this.ciudadesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ciudadesTableAdapter();
            this.departamentoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.departamentoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbResponsable = new System.Windows.Forms.ComboBox();
            this.dsSPXSeguridad1 = new SPXSeguridad.data.dsSPXSeguridad();
            this.txtElaboradoPor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grdRepuestos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsPlantillas1 = new SPControladoraDatos.dsPlantillas();
            this.grdObservaciones = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.defaultsTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumeroOrdenPrestamo = new System.Windows.Forms.TextBox();
            this.ordenPrestamoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.OrdenPrestamoTableAdapter();
            this.repuestosxOrdenPrestamoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.repuestosxOrdenPrestamoTableAdapter();
            this.observacionesxOrdenPrestamoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ObservacionesxOrdenPrestamoTableAdapter();
            this.calFechaCreacion = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumeroOdenServicio = new System.Windows.Forms.TextBox();
            this.lblNumeroOrdenServicio = new System.Windows.Forms.Label();
            this.txtAutorizadoPor = new System.Windows.Forms.TextBox();
            this.lblAutorizadoPor = new System.Windows.Forms.Label();
            this.txtAceptadorPor = new System.Windows.Forms.TextBox();
            this.lblAceptadoPor = new System.Windows.Forms.Label();
            this.txtRecibidosPor = new System.Windows.Forms.TextBox();
            this.lblRecibidoPor = new System.Windows.Forms.Label();
            this.txtAnuladoPor = new System.Windows.Forms.TextBox();
            this.lblAnuladoPor = new System.Windows.Forms.Label();
            this.lblFechaRecibido = new System.Windows.Forms.Label();
            this.calFechaRecibido = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblEstadoOs = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.c1CmbAutoresObs = new C1.Win.C1TrueDBGrid.C1TrueDBDropdown();
            this.dsSPXSeguridad2 = new SPXSeguridad.data.dsSPXSeguridad();
            this.repuestosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.repuestosTableAdapter();
            this.pltRepuestosxOrdenPrestamoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.pltRepuestosxOrdenPrestamoTableAdapter();
            this.btnAgregarObservacion = new DevComponents.DotNetBar.ButtonX();
            this.btnModificarObservaciones = new DevComponents.DotNetBar.ButtonX();
            this.btnEliminarObservaciones = new DevComponents.DotNetBar.ButtonX();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btnSalir = new DevComponents.DotNetBar.ButtonX();
            this.btnImprimir = new DevComponents.DotNetBar.ButtonX();
            this.btnEditar = new DevComponents.DotNetBar.ButtonX();
            this.btnAprobar = new DevComponents.DotNetBar.ButtonX();
            this.btnRechazar = new DevComponents.DotNetBar.ButtonX();
            this.btnEntregar = new DevComponents.DotNetBar.ButtonX();
            this.btnRecibir = new DevComponents.DotNetBar.ButtonX();
            this.btnAnular = new DevComponents.DotNetBar.ButtonX();
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem2 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem3 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem5 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem6 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem7 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem4 = new DevComponents.DotNetBar.ControlContainerItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbEstadoOrdenServicio = new System.Windows.Forms.ComboBox();
            this.cmbEstadoOrdenPrestamo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtObsIniciales = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtObservacionesAprobacion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtObsEntrega = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtObsDevolucion = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.estadosOrdenServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.estadosOrdenServicioTableAdapter();
            this.estadosOrdenPrestamoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.estadosOrdenPrestamoTableAdapter();
            this.ordenServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter();
            this.pltRepuestoxOrdenPrestamoCompletaTableAdapter1 = new SPControladoraDatos.dsPlantillasTableAdapters.pltRepuestoxOrdenPrestamoCompletaTableAdapter();
            this.txtNotaSalida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.clsTusuario1 = new SPXSeguridad.data.cls.clsTusuario();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtObservacionesEquipo = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnInfEquipo = new DevComponents.DotNetBar.ButtonX();
            this.txtModalidad = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.modalidadEquipoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ModalidadEquipoTableAdapter();
            this.equiposTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter();
            this.fabricanteTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.fabricanteTableAdapter();
            this.modelosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRepuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdObservaciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaCreacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaRecibido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CmbAutoresObs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad2)).BeginInit();
            this.ribbonBar1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingeniero Responsable";
            // 
            // cmbResponsable
            // 
            this.cmbResponsable.BackColor = System.Drawing.Color.White;
            this.cmbResponsable.DataSource = this.dsSPXSeguridad1;
            this.cmbResponsable.DisplayMember = "usuario.nombre";
            this.cmbResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResponsable.Enabled = false;
            this.cmbResponsable.FormattingEnabled = true;
            this.cmbResponsable.Location = new System.Drawing.Point(137, 45);
            this.cmbResponsable.Name = "cmbResponsable";
            this.cmbResponsable.Size = new System.Drawing.Size(229, 21);
            this.cmbResponsable.TabIndex = 3;
            this.cmbResponsable.ValueMember = "usuario.login";
            // 
            // dsSPXSeguridad1
            // 
            this.dsSPXSeguridad1.DataSetName = "dsSPXSeguridad";
            this.dsSPXSeguridad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtElaboradoPor
            // 
            this.txtElaboradoPor.BackColor = System.Drawing.Color.White;
            this.txtElaboradoPor.Location = new System.Drawing.Point(137, 17);
            this.txtElaboradoPor.Name = "txtElaboradoPor";
            this.txtElaboradoPor.ReadOnly = true;
            this.txtElaboradoPor.Size = new System.Drawing.Size(229, 21);
            this.txtElaboradoPor.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Elaborado Por";
            // 
            // grdRepuestos
            // 
            this.grdRepuestos.AllowUpdate = false;
            this.grdRepuestos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdRepuestos.CaptionHeight = 17;
            this.grdRepuestos.DataMember = "pltRepuestoxOrdenPrestamoCompleta";
            this.grdRepuestos.DataSource = this.dsPlantillas1;
            this.grdRepuestos.GroupByCaption = "Drag a column header here to group by that column";
            this.grdRepuestos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdRepuestos.Images"))));
            this.grdRepuestos.Location = new System.Drawing.Point(7, 446);
            this.grdRepuestos.Name = "grdRepuestos";
            this.grdRepuestos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdRepuestos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdRepuestos.PreviewInfo.ZoomFactor = 75D;
            this.grdRepuestos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdRepuestos.PrintInfo.PageSettings")));
            this.grdRepuestos.RowHeight = 15;
            this.grdRepuestos.Size = new System.Drawing.Size(571, 254);
            this.grdRepuestos.TabIndex = 16;
            this.grdRepuestos.Text = "c1TrueDBGrid1";
            this.grdRepuestos.PropBag = resources.GetString("grdRepuestos.PropBag");
            // 
            // dsPlantillas1
            // 
            this.dsPlantillas1.DataSetName = "dsPlantillas";
            this.dsPlantillas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdObservaciones
            // 
            this.grdObservaciones.AllowUpdate = false;
            this.grdObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdObservaciones.CaptionHeight = 17;
            this.grdObservaciones.DataMember = "ObservacionesxOrdenPrestamo";
            this.grdObservaciones.DataSource = this.dsSpx1;
            this.grdObservaciones.GroupByCaption = "Drag a column header here to group by that column";
            this.grdObservaciones.Images.Add(((System.Drawing.Image)(resources.GetObject("grdObservaciones.Images"))));
            this.grdObservaciones.Location = new System.Drawing.Point(13, 463);
            this.grdObservaciones.Name = "grdObservaciones";
            this.grdObservaciones.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdObservaciones.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdObservaciones.PreviewInfo.ZoomFactor = 75D;
            this.grdObservaciones.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdObservaciones.PrintInfo.PageSettings")));
            this.grdObservaciones.RowHeight = 15;
            this.grdObservaciones.Size = new System.Drawing.Size(375, 112);
            this.grdObservaciones.TabIndex = 17;
            this.grdObservaciones.Text = "c1TrueDBGrid2";
            this.grdObservaciones.PropBag = resources.GetString("grdObservaciones.PropBag");
            // 
            // cmbPais
            // 
            this.cmbPais.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbPais.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPais.BackColor = System.Drawing.Color.White;
            this.cmbPais.DataSource = this.dsSpx1;
            this.cmbPais.DisplayMember = "paises.nombrePais";
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.Enabled = false;
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(10, 31);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(167, 21);
            this.cmbPais.TabIndex = 20;
            this.cmbPais.ValueMember = "paises.codPais";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCiudad);
            this.groupBox1.Controls.Add(this.cmbDepartamento);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbPais);
            this.groupBox1.Location = new System.Drawing.Point(8, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 59);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ubicacion";
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbCiudad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCiudad.BackColor = System.Drawing.Color.White;
            this.cmbCiudad.DataSource = this.dsSpx1;
            this.cmbCiudad.DisplayMember = "ciudades.nombreCiudad";
            this.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudad.Enabled = false;
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(379, 32);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(185, 21);
            this.cmbCiudad.TabIndex = 25;
            this.cmbCiudad.ValueMember = "ciudades.codCiudad";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbDepartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDepartamento.BackColor = System.Drawing.Color.White;
            this.cmbDepartamento.DataSource = this.dsSpx1;
            this.cmbDepartamento.DisplayMember = "departamento.NombreDepartamento";
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.Enabled = false;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(183, 31);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(190, 21);
            this.cmbDepartamento.TabIndex = 24;
            this.cmbDepartamento.ValueMember = "departamento.codDepartamento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Pais";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Departamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ciudad";
            // 
            // defaultsTableAdapter1
            // 
            this.defaultsTableAdapter1.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Location = new System.Drawing.Point(11, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 34);
            this.label7.TabIndex = 22;
            this.label7.Text = "Cod Orden de Prestamo";
            // 
            // txtNumeroOrdenPrestamo
            // 
            this.txtNumeroOrdenPrestamo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeroOrdenPrestamo.BackColor = System.Drawing.Color.White;
            this.txtNumeroOrdenPrestamo.Location = new System.Drawing.Point(93, 17);
            this.txtNumeroOrdenPrestamo.Name = "txtNumeroOrdenPrestamo";
            this.txtNumeroOrdenPrestamo.ReadOnly = true;
            this.txtNumeroOrdenPrestamo.Size = new System.Drawing.Size(84, 21);
            this.txtNumeroOrdenPrestamo.TabIndex = 23;
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
            // calFechaCreacion
            // 
            this.calFechaCreacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.calFechaCreacion.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calFechaCreacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaCreacion.ButtonDropDown.Visible = true;
            this.calFechaCreacion.Enabled = false;
            this.calFechaCreacion.Location = new System.Drawing.Point(93, 89);
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
            this.calFechaCreacion.Size = new System.Drawing.Size(200, 21);
            this.calFechaCreacion.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Location = new System.Drawing.Point(11, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 29);
            this.label8.TabIndex = 25;
            this.label8.Text = "Fecha Creacion";
            // 
            // txtNumeroOdenServicio
            // 
            this.txtNumeroOdenServicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeroOdenServicio.BackColor = System.Drawing.Color.White;
            this.txtNumeroOdenServicio.Location = new System.Drawing.Point(93, 53);
            this.txtNumeroOdenServicio.Name = "txtNumeroOdenServicio";
            this.txtNumeroOdenServicio.ReadOnly = true;
            this.txtNumeroOdenServicio.Size = new System.Drawing.Size(84, 21);
            this.txtNumeroOdenServicio.TabIndex = 27;
            // 
            // lblNumeroOrdenServicio
            // 
            this.lblNumeroOrdenServicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroOrdenServicio.Location = new System.Drawing.Point(11, 53);
            this.lblNumeroOrdenServicio.Name = "lblNumeroOrdenServicio";
            this.lblNumeroOrdenServicio.Size = new System.Drawing.Size(77, 35);
            this.lblNumeroOrdenServicio.TabIndex = 26;
            this.lblNumeroOrdenServicio.Text = "Cod Orden de Servicio";
            // 
            // txtAutorizadoPor
            // 
            this.txtAutorizadoPor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAutorizadoPor.BackColor = System.Drawing.Color.White;
            this.txtAutorizadoPor.Location = new System.Drawing.Point(137, 138);
            this.txtAutorizadoPor.Name = "txtAutorizadoPor";
            this.txtAutorizadoPor.ReadOnly = true;
            this.txtAutorizadoPor.Size = new System.Drawing.Size(229, 21);
            this.txtAutorizadoPor.TabIndex = 30;
            // 
            // lblAutorizadoPor
            // 
            this.lblAutorizadoPor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAutorizadoPor.AutoSize = true;
            this.lblAutorizadoPor.Location = new System.Drawing.Point(6, 138);
            this.lblAutorizadoPor.Name = "lblAutorizadoPor";
            this.lblAutorizadoPor.Size = new System.Drawing.Size(71, 13);
            this.lblAutorizadoPor.TabIndex = 29;
            this.lblAutorizadoPor.Text = "Aprobado Por";
            // 
            // txtAceptadorPor
            // 
            this.txtAceptadorPor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAceptadorPor.BackColor = System.Drawing.Color.White;
            this.txtAceptadorPor.Location = new System.Drawing.Point(137, 224);
            this.txtAceptadorPor.Name = "txtAceptadorPor";
            this.txtAceptadorPor.ReadOnly = true;
            this.txtAceptadorPor.Size = new System.Drawing.Size(229, 21);
            this.txtAceptadorPor.TabIndex = 32;
            // 
            // lblAceptadoPor
            // 
            this.lblAceptadoPor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAceptadoPor.AutoSize = true;
            this.lblAceptadoPor.Location = new System.Drawing.Point(6, 224);
            this.lblAceptadoPor.Name = "lblAceptadoPor";
            this.lblAceptadoPor.Size = new System.Drawing.Size(130, 13);
            this.lblAceptadoPor.TabIndex = 31;
            this.lblAceptadoPor.Text = "Repuestos Entregados Por";
            // 
            // txtRecibidosPor
            // 
            this.txtRecibidosPor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecibidosPor.BackColor = System.Drawing.Color.White;
            this.txtRecibidosPor.Location = new System.Drawing.Point(137, 317);
            this.txtRecibidosPor.Name = "txtRecibidosPor";
            this.txtRecibidosPor.ReadOnly = true;
            this.txtRecibidosPor.Size = new System.Drawing.Size(229, 21);
            this.txtRecibidosPor.TabIndex = 34;
            // 
            // lblRecibidoPor
            // 
            this.lblRecibidoPor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecibidoPor.AutoSize = true;
            this.lblRecibidoPor.Location = new System.Drawing.Point(6, 317);
            this.lblRecibidoPor.Name = "lblRecibidoPor";
            this.lblRecibidoPor.Size = new System.Drawing.Size(123, 13);
            this.lblRecibidoPor.TabIndex = 33;
            this.lblRecibidoPor.Text = "Repuestos Recibidos Por";
            // 
            // txtAnuladoPor
            // 
            this.txtAnuladoPor.AcceptsReturn = true;
            this.txtAnuladoPor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnuladoPor.BackColor = System.Drawing.Color.White;
            this.txtAnuladoPor.Location = new System.Drawing.Point(137, 403);
            this.txtAnuladoPor.Name = "txtAnuladoPor";
            this.txtAnuladoPor.ReadOnly = true;
            this.txtAnuladoPor.Size = new System.Drawing.Size(229, 21);
            this.txtAnuladoPor.TabIndex = 36;
            // 
            // lblAnuladoPor
            // 
            this.lblAnuladoPor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnuladoPor.Location = new System.Drawing.Point(6, 406);
            this.lblAnuladoPor.Name = "lblAnuladoPor";
            this.lblAnuladoPor.Size = new System.Drawing.Size(65, 13);
            this.lblAnuladoPor.TabIndex = 35;
            this.lblAnuladoPor.Text = "Anulado Por";
            // 
            // lblFechaRecibido
            // 
            this.lblFechaRecibido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaRecibido.Location = new System.Drawing.Point(297, 84);
            this.lblFechaRecibido.Name = "lblFechaRecibido";
            this.lblFechaRecibido.Size = new System.Drawing.Size(71, 37);
            this.lblFechaRecibido.TabIndex = 38;
            this.lblFechaRecibido.Text = "Fecha Devolucion";
            // 
            // calFechaRecibido
            // 
            this.calFechaRecibido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.calFechaRecibido.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calFechaRecibido.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaRecibido.ButtonDropDown.Visible = true;
            this.calFechaRecibido.Enabled = false;
            this.calFechaRecibido.Location = new System.Drawing.Point(367, 89);
            // 
            // 
            // 
            this.calFechaRecibido.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFechaRecibido.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calFechaRecibido.MonthCalendar.BackgroundStyle.Class = "";
            this.calFechaRecibido.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaRecibido.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calFechaRecibido.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calFechaRecibido.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calFechaRecibido.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calFechaRecibido.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calFechaRecibido.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calFechaRecibido.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calFechaRecibido.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calFechaRecibido.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaRecibido.MonthCalendar.DisplayMonth = new System.DateTime(2008, 6, 1, 0, 0, 0, 0);
            this.calFechaRecibido.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calFechaRecibido.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFechaRecibido.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calFechaRecibido.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calFechaRecibido.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calFechaRecibido.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calFechaRecibido.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaRecibido.MonthCalendar.TodayButtonVisible = true;
            this.calFechaRecibido.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calFechaRecibido.Name = "calFechaRecibido";
            this.calFechaRecibido.Size = new System.Drawing.Size(200, 21);
            this.calFechaRecibido.TabIndex = 37;
            // 
            // lblEstadoOs
            // 
            this.lblEstadoOs.Location = new System.Drawing.Point(183, 53);
            this.lblEstadoOs.Name = "lblEstadoOs";
            this.lblEstadoOs.Size = new System.Drawing.Size(85, 38);
            this.lblEstadoOs.TabIndex = 39;
            this.lblEstadoOs.Text = "Estado Orden de Servicio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 435);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Repuestos";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 447);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Observaciones Adicionales";
            // 
            // c1CmbAutoresObs
            // 
            this.c1CmbAutoresObs.AllowColMove = true;
            this.c1CmbAutoresObs.AllowColSelect = true;
            this.c1CmbAutoresObs.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows;
            this.c1CmbAutoresObs.AlternatingRows = false;
            this.c1CmbAutoresObs.CaptionHeight = 17;
            this.c1CmbAutoresObs.CaptionStyle = style17;
            this.c1CmbAutoresObs.ColumnCaptionHeight = 17;
            this.c1CmbAutoresObs.ColumnFooterHeight = 17;
            this.c1CmbAutoresObs.ColumnHeaders = false;
            this.c1CmbAutoresObs.DataMember = "usuario";
            this.c1CmbAutoresObs.DataSource = this.dsSPXSeguridad2;
            this.c1CmbAutoresObs.DisplayMember = "usuario.nombre";
            this.c1CmbAutoresObs.EvenRowStyle = style18;
            this.c1CmbAutoresObs.FetchRowStyles = false;
            this.c1CmbAutoresObs.FooterStyle = style19;
            this.c1CmbAutoresObs.HeadingStyle = style20;
            this.c1CmbAutoresObs.HighLightRowStyle = style21;
            this.c1CmbAutoresObs.Images.Add(((System.Drawing.Image)(resources.GetObject("c1CmbAutoresObs.Images"))));
            this.c1CmbAutoresObs.Location = new System.Drawing.Point(41, 504);
            this.c1CmbAutoresObs.Name = "c1CmbAutoresObs";
            this.c1CmbAutoresObs.OddRowStyle = style22;
            this.c1CmbAutoresObs.RecordSelectorStyle = style23;
            this.c1CmbAutoresObs.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.c1CmbAutoresObs.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
            this.c1CmbAutoresObs.RowHeight = 15;
            this.c1CmbAutoresObs.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1CmbAutoresObs.ScrollTips = false;
            this.c1CmbAutoresObs.Size = new System.Drawing.Size(127, 35);
            this.c1CmbAutoresObs.Style = style24;
            this.c1CmbAutoresObs.TabIndex = 49;
            this.c1CmbAutoresObs.TabStop = false;
            this.c1CmbAutoresObs.Text = "c1TrueDBDropdown1";
            this.c1CmbAutoresObs.ValueMember = "usuario.login";
            this.c1CmbAutoresObs.ValueTranslate = true;
            this.c1CmbAutoresObs.Visible = false;
            this.c1CmbAutoresObs.PropBag = resources.GetString("c1CmbAutoresObs.PropBag");
            // 
            // dsSPXSeguridad2
            // 
            this.dsSPXSeguridad2.DataSetName = "dsSPXSeguridad";
            this.dsSPXSeguridad2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repuestosTableAdapter1
            // 
            this.repuestosTableAdapter1.ClearBeforeFill = true;
            // 
            // pltRepuestosxOrdenPrestamoTableAdapter1
            // 
            this.pltRepuestosxOrdenPrestamoTableAdapter1.ClearBeforeFill = true;
            // 
            // btnAgregarObservacion
            // 
            this.btnAgregarObservacion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregarObservacion.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarObservacion.Image")));
            this.btnAgregarObservacion.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnAgregarObservacion.Location = new System.Drawing.Point(289, 430);
            this.btnAgregarObservacion.Name = "btnAgregarObservacion";
            this.btnAgregarObservacion.Size = new System.Drawing.Size(29, 29);
            this.btnAgregarObservacion.TabIndex = 78;
            this.btnAgregarObservacion.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnModificarObservaciones
            // 
            this.btnModificarObservaciones.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnModificarObservaciones.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarObservaciones.Image")));
            this.btnModificarObservaciones.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnModificarObservaciones.Location = new System.Drawing.Point(324, 430);
            this.btnModificarObservaciones.Name = "btnModificarObservaciones";
            this.btnModificarObservaciones.Size = new System.Drawing.Size(29, 29);
            this.btnModificarObservaciones.TabIndex = 77;
            this.btnModificarObservaciones.Click += new System.EventHandler(this.btnModificarObservaciones_Click);
            // 
            // btnEliminarObservaciones
            // 
            this.btnEliminarObservaciones.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEliminarObservaciones.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarObservaciones.Image")));
            this.btnEliminarObservaciones.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnEliminarObservaciones.Location = new System.Drawing.Point(359, 430);
            this.btnEliminarObservaciones.Name = "btnEliminarObservaciones";
            this.btnEliminarObservaciones.Size = new System.Drawing.Size(29, 29);
            this.btnEliminarObservaciones.TabIndex = 76;
            this.btnEliminarObservaciones.Click += new System.EventHandler(this.btnEliminarObservaciones_Click);
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.Class = "";
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Controls.Add(this.btnSalir);
            this.ribbonBar1.Controls.Add(this.btnImprimir);
            this.ribbonBar1.Controls.Add(this.btnEditar);
            this.ribbonBar1.Controls.Add(this.btnAprobar);
            this.ribbonBar1.Controls.Add(this.btnRechazar);
            this.ribbonBar1.Controls.Add(this.btnEntregar);
            this.ribbonBar1.Controls.Add(this.btnRecibir);
            this.ribbonBar1.Controls.Add(this.btnAnular);
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.controlContainerItem1,
            this.controlContainerItem2,
            this.controlContainerItem3,
            this.controlContainerItem5,
            this.controlContainerItem6,
            this.controlContainerItem7,
            this.controlContainerItem4});
            this.ribbonBar1.Location = new System.Drawing.Point(0, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(989, 55);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar1.TabIndex = 79;
            this.ribbonBar1.Text = "Opciones";
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.Class = "";
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.Class = "";
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnSalir
            // 
            this.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnSalir.Location = new System.Drawing.Point(579, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 33);
            this.btnSalir.TabIndex = 76;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnImprimir.Location = new System.Drawing.Point(6, 3);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(77, 33);
            this.btnImprimir.TabIndex = 68;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnEditar.Location = new System.Drawing.Point(88, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(77, 33);
            this.btnEditar.TabIndex = 67;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAprobar
            // 
            this.btnAprobar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAprobar.Image = ((System.Drawing.Image)(resources.GetObject("btnAprobar.Image")));
            this.btnAprobar.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnAprobar.Location = new System.Drawing.Point(170, 3);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(77, 33);
            this.btnAprobar.TabIndex = 74;
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.Click += new System.EventHandler(this.btnAprobar_Click);
            // 
            // btnRechazar
            // 
            this.btnRechazar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRechazar.Image = ((System.Drawing.Image)(resources.GetObject("btnRechazar.Image")));
            this.btnRechazar.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnRechazar.Location = new System.Drawing.Point(252, 3);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.Size = new System.Drawing.Size(77, 33);
            this.btnRechazar.TabIndex = 70;
            this.btnRechazar.Text = "Rechazar";
            this.btnRechazar.Click += new System.EventHandler(this.btnRechazar_Click);
            // 
            // btnEntregar
            // 
            this.btnEntregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEntregar.Image = ((System.Drawing.Image)(resources.GetObject("btnEntregar.Image")));
            this.btnEntregar.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnEntregar.Location = new System.Drawing.Point(334, 3);
            this.btnEntregar.Name = "btnEntregar";
            this.btnEntregar.Size = new System.Drawing.Size(77, 33);
            this.btnEntregar.TabIndex = 71;
            this.btnEntregar.Text = "Entregar Repuestos";
            this.btnEntregar.Click += new System.EventHandler(this.btnEntregar_Click);
            // 
            // btnRecibir
            // 
            this.btnRecibir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRecibir.Image = ((System.Drawing.Image)(resources.GetObject("btnRecibir.Image")));
            this.btnRecibir.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnRecibir.Location = new System.Drawing.Point(416, 3);
            this.btnRecibir.Name = "btnRecibir";
            this.btnRecibir.Size = new System.Drawing.Size(77, 33);
            this.btnRecibir.TabIndex = 72;
            this.btnRecibir.Text = "Recibir Repuestos";
            this.btnRecibir.Click += new System.EventHandler(this.btnRecibir_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAnular.Image = ((System.Drawing.Image)(resources.GetObject("btnAnular.Image")));
            this.btnAnular.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnAnular.Location = new System.Drawing.Point(498, 3);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(77, 33);
            this.btnAnular.TabIndex = 75;
            this.btnAnular.Text = "Anular";
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // controlContainerItem1
            // 
            this.controlContainerItem1.AllowItemResize = false;
            this.controlContainerItem1.Control = this.btnImprimir;
            this.controlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem1.Name = "controlContainerItem1";
            // 
            // controlContainerItem2
            // 
            this.controlContainerItem2.AllowItemResize = false;
            this.controlContainerItem2.Control = this.btnEditar;
            this.controlContainerItem2.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem2.Name = "controlContainerItem2";
            // 
            // controlContainerItem3
            // 
            this.controlContainerItem3.AllowItemResize = false;
            this.controlContainerItem3.Control = this.btnAprobar;
            this.controlContainerItem3.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem3.Name = "controlContainerItem3";
            // 
            // controlContainerItem5
            // 
            this.controlContainerItem5.AllowItemResize = false;
            this.controlContainerItem5.Control = this.btnRechazar;
            this.controlContainerItem5.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem5.Name = "controlContainerItem5";
            // 
            // controlContainerItem6
            // 
            this.controlContainerItem6.AllowItemResize = false;
            this.controlContainerItem6.Control = this.btnEntregar;
            this.controlContainerItem6.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem6.Name = "controlContainerItem6";
            // 
            // controlContainerItem7
            // 
            this.controlContainerItem7.AllowItemResize = false;
            this.controlContainerItem7.Control = this.btnRecibir;
            this.controlContainerItem7.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem7.Name = "controlContainerItem7";
            // 
            // controlContainerItem4
            // 
            this.controlContainerItem4.AllowItemResize = false;
            this.controlContainerItem4.Control = this.btnAnular;
            this.controlContainerItem4.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem4.Name = "controlContainerItem4";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbEstadoOrdenServicio);
            this.groupBox2.Controls.Add(this.calFechaRecibido);
            this.groupBox2.Controls.Add(this.cmbEstadoOrdenPrestamo);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.calFechaCreacion);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtNumeroOrdenPrestamo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblNumeroOrdenServicio);
            this.groupBox2.Controls.Add(this.txtNumeroOdenServicio);
            this.groupBox2.Controls.Add(this.lblEstadoOs);
            this.groupBox2.Controls.Add(this.lblFechaRecibido);
            this.groupBox2.Location = new System.Drawing.Point(5, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 121);
            this.groupBox2.TabIndex = 80;
            this.groupBox2.TabStop = false;
            // 
            // cmbEstadoOrdenServicio
            // 
            this.cmbEstadoOrdenServicio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbEstadoOrdenServicio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEstadoOrdenServicio.BackColor = System.Drawing.Color.White;
            this.cmbEstadoOrdenServicio.DataSource = this.dsSpx1;
            this.cmbEstadoOrdenServicio.DisplayMember = "estadosOrdenServicio.nombreEstado";
            this.cmbEstadoOrdenServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoOrdenServicio.Enabled = false;
            this.cmbEstadoOrdenServicio.FormattingEnabled = true;
            this.cmbEstadoOrdenServicio.Location = new System.Drawing.Point(300, 50);
            this.cmbEstadoOrdenServicio.Name = "cmbEstadoOrdenServicio";
            this.cmbEstadoOrdenServicio.Size = new System.Drawing.Size(267, 21);
            this.cmbEstadoOrdenServicio.TabIndex = 44;
            this.cmbEstadoOrdenServicio.ValueMember = "estadosOrdenServicio.codEstadoOrdenServicio";
            // 
            // cmbEstadoOrdenPrestamo
            // 
            this.cmbEstadoOrdenPrestamo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbEstadoOrdenPrestamo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEstadoOrdenPrestamo.BackColor = System.Drawing.Color.White;
            this.cmbEstadoOrdenPrestamo.DataSource = this.dsSpx1;
            this.cmbEstadoOrdenPrestamo.DisplayMember = "estadosOrdenPrestamo.nombreEstadoOP";
            this.cmbEstadoOrdenPrestamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoOrdenPrestamo.Enabled = false;
            this.cmbEstadoOrdenPrestamo.FormattingEnabled = true;
            this.cmbEstadoOrdenPrestamo.Location = new System.Drawing.Point(300, 20);
            this.cmbEstadoOrdenPrestamo.Name = "cmbEstadoOrdenPrestamo";
            this.cmbEstadoOrdenPrestamo.Size = new System.Drawing.Size(267, 21);
            this.cmbEstadoOrdenPrestamo.TabIndex = 43;
            this.cmbEstadoOrdenPrestamo.ValueMember = "estadosOrdenPrestamo.codEstadoOrdenPrestamo";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(183, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 28);
            this.label15.TabIndex = 41;
            this.label15.Text = "Estado Orden de Prestamo";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 13);
            this.label11.TabIndex = 81;
            this.label11.Text = "Observaciones Iniciales";
            // 
            // txtObsIniciales
            // 
            this.txtObsIniciales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObsIniciales.BackColor = System.Drawing.Color.White;
            this.txtObsIniciales.Location = new System.Drawing.Point(137, 75);
            this.txtObsIniciales.Multiline = true;
            this.txtObsIniciales.Name = "txtObsIniciales";
            this.txtObsIniciales.ReadOnly = true;
            this.txtObsIniciales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObsIniciales.Size = new System.Drawing.Size(251, 53);
            this.txtObsIniciales.TabIndex = 82;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 13);
            this.label12.TabIndex = 83;
            this.label12.Text = "Observaciones Aprobacion";
            // 
            // txtObservacionesAprobacion
            // 
            this.txtObservacionesAprobacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservacionesAprobacion.BackColor = System.Drawing.Color.White;
            this.txtObservacionesAprobacion.Location = new System.Drawing.Point(137, 165);
            this.txtObservacionesAprobacion.Multiline = true;
            this.txtObservacionesAprobacion.Name = "txtObservacionesAprobacion";
            this.txtObservacionesAprobacion.ReadOnly = true;
            this.txtObservacionesAprobacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacionesAprobacion.Size = new System.Drawing.Size(251, 53);
            this.txtObservacionesAprobacion.TabIndex = 84;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 250);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 13);
            this.label13.TabIndex = 85;
            this.label13.Text = "Observaciones Entrega";
            // 
            // txtObsEntrega
            // 
            this.txtObsEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObsEntrega.BackColor = System.Drawing.Color.White;
            this.txtObsEntrega.Location = new System.Drawing.Point(137, 250);
            this.txtObsEntrega.Multiline = true;
            this.txtObsEntrega.Name = "txtObsEntrega";
            this.txtObsEntrega.ReadOnly = true;
            this.txtObsEntrega.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObsEntrega.Size = new System.Drawing.Size(251, 53);
            this.txtObsEntrega.TabIndex = 86;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 344);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 13);
            this.label14.TabIndex = 87;
            this.label14.Text = "Observaciones Devolucion";
            // 
            // txtObsDevolucion
            // 
            this.txtObsDevolucion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObsDevolucion.BackColor = System.Drawing.Color.White;
            this.txtObsDevolucion.Location = new System.Drawing.Point(137, 344);
            this.txtObsDevolucion.Multiline = true;
            this.txtObsDevolucion.Name = "txtObsDevolucion";
            this.txtObsDevolucion.ReadOnly = true;
            this.txtObsDevolucion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObsDevolucion.Size = new System.Drawing.Size(252, 53);
            this.txtObsDevolucion.TabIndex = 88;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnAgregarObservacion);
            this.groupBox3.Controls.Add(this.txtObsDevolucion);
            this.groupBox3.Controls.Add(this.btnModificarObservaciones);
            this.groupBox3.Controls.Add(this.c1CmbAutoresObs);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtAnuladoPor);
            this.groupBox3.Controls.Add(this.cmbResponsable);
            this.groupBox3.Controls.Add(this.lblAnuladoPor);
            this.groupBox3.Controls.Add(this.btnEliminarObservaciones);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.grdObservaciones);
            this.groupBox3.Controls.Add(this.txtElaboradoPor);
            this.groupBox3.Controls.Add(this.txtObsEntrega);
            this.groupBox3.Controls.Add(this.txtRecibidosPor);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.lblRecibidoPor);
            this.groupBox3.Controls.Add(this.txtObservacionesAprobacion);
            this.groupBox3.Controls.Add(this.txtAceptadorPor);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.lblAceptadoPor);
            this.groupBox3.Controls.Add(this.txtObsIniciales);
            this.groupBox3.Controls.Add(this.txtAutorizadoPor);
            this.groupBox3.Controls.Add(this.lblAutorizadoPor);
            this.groupBox3.Location = new System.Drawing.Point(585, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(395, 585);
            this.groupBox3.TabIndex = 89;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Observaciones";
            // 
            // estadosOrdenServicioTableAdapter1
            // 
            this.estadosOrdenServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // estadosOrdenPrestamoTableAdapter1
            // 
            this.estadosOrdenPrestamoTableAdapter1.ClearBeforeFill = true;
            // 
            // ordenServicioTableAdapter1
            // 
            this.ordenServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // pltRepuestoxOrdenPrestamoCompletaTableAdapter1
            // 
            this.pltRepuestoxOrdenPrestamoCompletaTableAdapter1.ClearBeforeFill = true;
            // 
            // txtNotaSalida
            // 
            this.txtNotaSalida.BackColor = System.Drawing.Color.White;
            this.txtNotaSalida.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotaSalida.Location = new System.Drawing.Point(482, 418);
            this.txtNotaSalida.Name = "txtNotaSalida";
            this.txtNotaSalida.ReadOnly = true;
            this.txtNotaSalida.Size = new System.Drawing.Size(96, 21);
            this.txtNotaSalida.TabIndex = 159;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(382, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 158;
            this.label3.Text = "Numero nota Salida";
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.BackColor = System.Drawing.Color.White;
            this.txtNumeroFactura.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroFactura.Location = new System.Drawing.Point(280, 418);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.ReadOnly = true;
            this.txtNumeroFactura.Size = new System.Drawing.Size(96, 21);
            this.txtNumeroFactura.TabIndex = 157;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(182, 422);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 13);
            this.label16.TabIndex = 156;
            this.label16.Text = "Numero de Factura";
            // 
            // clsTusuario1
            // 
            this.clsTusuario1.nombreLlave = "cod_usuario";
            this.clsTusuario1.nombreTabla = "usuario";
            this.clsTusuario1.sentenciaBase = resources.GetString("clsTusuario1.sentenciaBase");
            this.clsTusuario1.sentenciaBaseDistinct = resources.GetString("clsTusuario1.sentenciaBaseDistinct");
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.txtObservacionesEquipo);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.btnInfEquipo);
            this.groupBox4.Controls.Add(this.txtModalidad);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.txtFabricante);
            this.groupBox4.Controls.Add(this.txtModelo);
            this.groupBox4.Controls.Add(this.txtSerial);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(8, 276);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(571, 130);
            this.groupBox4.TabIndex = 160;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informacion del Equipo";
            // 
            // txtObservacionesEquipo
            // 
            this.txtObservacionesEquipo.BackColor = System.Drawing.Color.White;
            this.txtObservacionesEquipo.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacionesEquipo.Location = new System.Drawing.Point(326, 35);
            this.txtObservacionesEquipo.Multiline = true;
            this.txtObservacionesEquipo.Name = "txtObservacionesEquipo";
            this.txtObservacionesEquipo.ReadOnly = true;
            this.txtObservacionesEquipo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacionesEquipo.Size = new System.Drawing.Size(238, 90);
            this.txtObservacionesEquipo.TabIndex = 105;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(323, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(186, 15);
            this.label17.TabIndex = 68;
            this.label17.Text = "Observaciones Prestamo Equipo";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(7, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 15);
            this.label18.TabIndex = 33;
            this.label18.Text = "Serial";
            // 
            // btnInfEquipo
            // 
            this.btnInfEquipo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInfEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfEquipo.Image")));
            this.btnInfEquipo.ImageFixedSize = new System.Drawing.Size(29, 29);
            this.btnInfEquipo.Location = new System.Drawing.Point(280, 20);
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
            this.txtSerial.BackColor = System.Drawing.Color.White;
            this.txtSerial.Location = new System.Drawing.Point(75, 24);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.ReadOnly = true;
            this.txtSerial.Size = new System.Drawing.Size(199, 21);
            this.txtSerial.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 78);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 15);
            this.label19.TabIndex = 13;
            this.label19.Text = "Modelo";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 53);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 15);
            this.label20.TabIndex = 11;
            this.label20.Text = "Fabricante";
            // 
            // modalidadEquipoTableAdapter1
            // 
            this.modalidadEquipoTableAdapter1.ClearBeforeFill = true;
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
            // frmNuevaOrdenPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(989, 712);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtNotaSalida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumeroFactura);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ribbonBar1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdRepuestos);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNuevaOrdenPrestamo";
            this.Text = "Orden Prestamo";
            this.Load += new System.EventHandler(this.frmNuevaOrdenPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRepuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdObservaciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaCreacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaRecibido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CmbAutoresObs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad2)).EndInit();
            this.ribbonBar1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.paisesTableAdapter paisesTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.ciudadesTableAdapter ciudadesTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.departamentoTableAdapter departamentoTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbResponsable;
         private System.Windows.Forms.TextBox txtElaboradoPor;
        private System.Windows.Forms.Label label2;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdRepuestos;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdObservaciones;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter defaultsTableAdapter1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumeroOrdenPrestamo;
        private SPControladoraDatos.dsSpxTableAdapters.OrdenPrestamoTableAdapter ordenPrestamoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.repuestosxOrdenPrestamoTableAdapter repuestosxOrdenPrestamoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.ObservacionesxOrdenPrestamoTableAdapter observacionesxOrdenPrestamoTableAdapter1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFechaCreacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumeroOdenServicio;
        private System.Windows.Forms.Label lblNumeroOrdenServicio;
        private System.Windows.Forms.TextBox txtAutorizadoPor;
        private System.Windows.Forms.Label lblAutorizadoPor;
        private System.Windows.Forms.TextBox txtAceptadorPor;
        private System.Windows.Forms.Label lblAceptadoPor;
        private System.Windows.Forms.TextBox txtRecibidosPor;
        private System.Windows.Forms.Label lblRecibidoPor;
        private System.Windows.Forms.TextBox txtAnuladoPor;
        private System.Windows.Forms.Label lblAnuladoPor;
        private System.Windows.Forms.Label lblFechaRecibido;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFechaRecibido;
        private System.Windows.Forms.Label lblEstadoOs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private C1.Win.C1TrueDBGrid.C1TrueDBDropdown c1CmbAutoresObs;
        private SPControladoraDatos.dsSpxTableAdapters.repuestosTableAdapter repuestosTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.pltRepuestosxOrdenPrestamoTableAdapter pltRepuestosxOrdenPrestamoTableAdapter1;
        private DevComponents.DotNetBar.ButtonX btnAgregarObservacion;
        private DevComponents.DotNetBar.ButtonX btnModificarObservaciones;
        private DevComponents.DotNetBar.ButtonX btnEliminarObservaciones;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonX btnImprimir;
        private DevComponents.DotNetBar.ButtonX btnEditar;
        private DevComponents.DotNetBar.ButtonX btnAprobar;
        private DevComponents.DotNetBar.ButtonX btnRechazar;
        private DevComponents.DotNetBar.ButtonX btnEntregar;
        private DevComponents.DotNetBar.ButtonX btnRecibir;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem2;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem3;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem5;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem6;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtObsIniciales;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtObservacionesAprobacion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtObsEntrega;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtObsDevolucion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbEstadoOrdenPrestamo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbEstadoOrdenServicio;
        private SPControladoraDatos.dsSpxTableAdapters.estadosOrdenServicioTableAdapter estadosOrdenServicioTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.estadosOrdenPrestamoTableAdapter estadosOrdenPrestamoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter ordenServicioTableAdapter1;
        private DevComponents.DotNetBar.ButtonX btnAnular;
        private DevComponents.DotNetBar.ButtonX btnSalir;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem4;
        private SPControladoraDatos.dsPlantillas dsPlantillas1;
        private SPControladoraDatos.dsPlantillasTableAdapters.pltRepuestoxOrdenPrestamoCompletaTableAdapter pltRepuestoxOrdenPrestamoCompletaTableAdapter1;
        private System.Windows.Forms.TextBox txtNotaSalida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.Label label16;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad1;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad2;
        private SPXSeguridad.data.cls.clsTusuario clsTusuario1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtObservacionesEquipo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private DevComponents.DotNetBar.ButtonX btnInfEquipo;
        private System.Windows.Forms.TextBox txtModalidad;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private SPControladoraDatos.dsSpxTableAdapters.ModalidadEquipoTableAdapter modalidadEquipoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter equiposTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.fabricanteTableAdapter fabricanteTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter modelosTableAdapter1;
    }
}