namespace spProcesos.Herramientas
{
    partial class frmTrasladosDeEquipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrasladosDeEquipos));
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.logCambioUbicacionesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.logCambioUbicacionesTableAdapter();
            this.btnInfEquipo = new DevComponents.DotNetBar.ButtonX();
            this.btnBuscarSerial = new DevComponents.DotNetBar.ButtonX();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombrecliente = new System.Windows.Forms.TextBox();
            this.txtNitCliente = new System.Windows.Forms.TextBox();
            this.txtDireccionUbicacion = new System.Windows.Forms.TextBox();
            this.txtSucursal = new System.Windows.Forms.TextBox();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModalidad = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.txtObservacionesIniciales = new System.Windows.Forms.TextBox();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lblReservado = new System.Windows.Forms.Label();
            this.cmbEstadoEquipoLocal = new System.Windows.Forms.ComboBox();
            this.dsSpx2 = new SPControladoraDatos.dsSpx();
            this.lblEstadoEquipo = new System.Windows.Forms.Label();
            this.btnLimpiarCliente = new System.Windows.Forms.Button();
            this.btnBuscarNit = new DevComponents.DotNetBar.ButtonX();
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
            this.calUltimoEnvio = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.chkEnvioCliente = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx2)).BeginInit();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calUltimoEnvio)).BeginInit();
            this.SuspendLayout();
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logCambioUbicacionesTableAdapter1
            // 
            this.logCambioUbicacionesTableAdapter1.ClearBeforeFill = true;
            // 
            // btnInfEquipo
            // 
            this.btnInfEquipo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInfEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfEquipo.Image")));
            this.btnInfEquipo.ImageFixedSize = new System.Drawing.Size(29, 29);
            this.btnInfEquipo.Location = new System.Drawing.Point(394, 62);
            this.btnInfEquipo.Name = "btnInfEquipo";
            this.btnInfEquipo.Size = new System.Drawing.Size(33, 33);
            this.btnInfEquipo.TabIndex = 71;
            this.btnInfEquipo.Click += new System.EventHandler(this.btnInfEquipo_Click);
            // 
            // btnBuscarSerial
            // 
            this.btnBuscarSerial.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscarSerial.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarSerial.Image")));
            this.btnBuscarSerial.ImageFixedSize = new System.Drawing.Size(29, 29);
            this.btnBuscarSerial.Location = new System.Drawing.Point(357, 62);
            this.btnBuscarSerial.Name = "btnBuscarSerial";
            this.btnBuscarSerial.Size = new System.Drawing.Size(33, 33);
            this.btnBuscarSerial.TabIndex = 70;
            this.btnBuscarSerial.Click += new System.EventHandler(this.btnBuscarSerial_Click);
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(120, 69);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(229, 20);
            this.txtSerial.TabIndex = 68;
            this.txtSerial.Validating += new System.ComponentModel.CancelEventHandler(this.txtSerial_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(69, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 69;
            this.label8.Text = "Serial";
            // 
            // txtNombrecliente
            // 
            this.txtNombrecliente.Location = new System.Drawing.Point(90, 134);
            this.txtNombrecliente.Name = "txtNombrecliente";
            this.txtNombrecliente.ReadOnly = true;
            this.txtNombrecliente.Size = new System.Drawing.Size(300, 20);
            this.txtNombrecliente.TabIndex = 1;
            // 
            // txtNitCliente
            // 
            this.txtNitCliente.Location = new System.Drawing.Point(90, 102);
            this.txtNitCliente.Name = "txtNitCliente";
            this.txtNitCliente.ReadOnly = true;
            this.txtNitCliente.Size = new System.Drawing.Size(165, 20);
            this.txtNitCliente.TabIndex = 0;
            // 
            // txtDireccionUbicacion
            // 
            this.txtDireccionUbicacion.Location = new System.Drawing.Point(88, 262);
            this.txtDireccionUbicacion.Name = "txtDireccionUbicacion";
            this.txtDireccionUbicacion.ReadOnly = true;
            this.txtDireccionUbicacion.Size = new System.Drawing.Size(302, 20);
            this.txtDireccionUbicacion.TabIndex = 3;
            // 
            // txtSucursal
            // 
            this.txtSucursal.Location = new System.Drawing.Point(90, 199);
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.ReadOnly = true;
            this.txtSucursal.Size = new System.Drawing.Size(165, 20);
            this.txtSucursal.TabIndex = 0;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(88, 230);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.ReadOnly = true;
            this.txtUbicacion.Size = new System.Drawing.Size(302, 20);
            this.txtUbicacion.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(8, 235);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 13);
            this.label20.TabIndex = 22;
            this.label20.Text = "Ubicacion";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(8, 265);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "Direccion ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(8, 204);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "Sucursal";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(8, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Nombre Cliente";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(8, 106);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Nit cliente";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtFabricante);
            this.groupBox3.Controls.Add(this.txtModelo);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(8, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(346, 86);
            this.groupBox3.TabIndex = 72;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion del Equipo";
            // 
            // txtFabricante
            // 
            this.txtFabricante.Location = new System.Drawing.Point(97, 22);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.ReadOnly = true;
            this.txtFabricante.Size = new System.Drawing.Size(229, 20);
            this.txtFabricante.TabIndex = 3;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(97, 54);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.ReadOnly = true;
            this.txtModelo.Size = new System.Drawing.Size(229, 20);
            this.txtModelo.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Modelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fabricante";
            // 
            // txtModalidad
            // 
            this.txtModalidad.Location = new System.Drawing.Point(90, 164);
            this.txtModalidad.Name = "txtModalidad";
            this.txtModalidad.ReadOnly = true;
            this.txtModalidad.Size = new System.Drawing.Size(165, 20);
            this.txtModalidad.TabIndex = 30;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Location = new System.Drawing.Point(8, 165);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(56, 13);
            this.label26.TabIndex = 31;
            this.label26.Text = "Modalidad";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Transparent;
            this.label43.Location = new System.Drawing.Point(11, 449);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(98, 13);
            this.label43.TabIndex = 75;
            this.label43.Text = "Motivo de Traslado";
            // 
            // txtObservacionesIniciales
            // 
            this.txtObservacionesIniciales.Location = new System.Drawing.Point(12, 467);
            this.txtObservacionesIniciales.Multiline = true;
            this.txtObservacionesIniciales.Name = "txtObservacionesIniciales";
            this.txtObservacionesIniciales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacionesIniciales.Size = new System.Drawing.Size(832, 53);
            this.txtObservacionesIniciales.TabIndex = 74;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.lblReservado);
            this.groupPanel1.Controls.Add(this.cmbEstadoEquipoLocal);
            this.groupPanel1.Controls.Add(this.lblEstadoEquipo);
            this.groupPanel1.Controls.Add(this.btnLimpiarCliente);
            this.groupPanel1.Controls.Add(this.btnBuscarNit);
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
            this.groupPanel1.Location = new System.Drawing.Point(434, 64);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(410, 352);
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
            // lblReservado
            // 
            this.lblReservado.AutoSize = true;
            this.lblReservado.BackColor = System.Drawing.Color.Transparent;
            this.lblReservado.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservado.Location = new System.Drawing.Point(109, -1);
            this.lblReservado.Name = "lblReservado";
            this.lblReservado.Size = new System.Drawing.Size(204, 36);
            this.lblReservado.TabIndex = 42;
            this.lblReservado.Text = "RESERVADO";
            this.lblReservado.Visible = false;
            // 
            // cmbEstadoEquipoLocal
            // 
            this.cmbEstadoEquipoLocal.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsSpx2, "equipos.codEstadoLocal", true));
            this.cmbEstadoEquipoLocal.DataSource = this.dsSpx2;
            this.cmbEstadoEquipoLocal.DisplayMember = "estadoLocalEquipos.nombreEstadoLocal";
            this.cmbEstadoEquipoLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoEquipoLocal.FormattingEnabled = true;
            this.cmbEstadoEquipoLocal.Location = new System.Drawing.Point(88, 297);
            this.cmbEstadoEquipoLocal.MaxLength = 5;
            this.cmbEstadoEquipoLocal.Name = "cmbEstadoEquipoLocal";
            this.cmbEstadoEquipoLocal.Size = new System.Drawing.Size(225, 21);
            this.cmbEstadoEquipoLocal.TabIndex = 39;
            this.cmbEstadoEquipoLocal.ValueMember = "estadoLocalEquipos.codEstadoLocal";
            this.cmbEstadoEquipoLocal.SelectedIndexChanged += new System.EventHandler(this.cmbEstadoEquipoLocal_SelectedIndexChanged);
            // 
            // dsSpx2
            // 
            this.dsSpx2.DataSetName = "dsSpx";
            this.dsSpx2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblEstadoEquipo
            // 
            this.lblEstadoEquipo.AutoSize = true;
            this.lblEstadoEquipo.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoEquipo.Location = new System.Drawing.Point(3, 300);
            this.lblEstadoEquipo.Name = "lblEstadoEquipo";
            this.lblEstadoEquipo.Size = new System.Drawing.Size(76, 13);
            this.lblEstadoEquipo.TabIndex = 38;
            this.lblEstadoEquipo.Text = "Estado Equipo";
            // 
            // btnLimpiarCliente
            // 
            this.btnLimpiarCliente.Location = new System.Drawing.Point(316, 36);
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
            this.btnBuscarNit.Location = new System.Drawing.Point(336, 34);
            this.btnBuscarNit.Name = "btnBuscarNit";
            this.btnBuscarNit.Size = new System.Drawing.Size(35, 33);
            this.btnBuscarNit.TabIndex = 40;
            this.btnBuscarNit.Click += new System.EventHandler(this.btnBuscarNit_Click);
            // 
            // cmbModaldad
            // 
            this.cmbModaldad.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsSpx2, "equipos.codModalidadEquipo", true));
            this.cmbModaldad.DataSource = this.dsSpx2;
            this.cmbModaldad.DisplayMember = "ModalidadEquipo.nombreModalidadEquipo";
            this.cmbModaldad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModaldad.FormattingEnabled = true;
            this.cmbModaldad.Location = new System.Drawing.Point(88, 109);
            this.cmbModaldad.MaxLength = 5;
            this.cmbModaldad.Name = "cmbModaldad";
            this.cmbModaldad.Size = new System.Drawing.Size(225, 21);
            this.cmbModaldad.TabIndex = 37;
            this.cmbModaldad.ValueMember = "ModalidadEquipo.codModalidadEquipo";
            this.cmbModaldad.SelectedIndexChanged += new System.EventHandler(this.cmbModaldad_SelectedIndexChanged);
            // 
            // lblModalidad
            // 
            this.lblModalidad.AutoSize = true;
            this.lblModalidad.BackColor = System.Drawing.Color.Transparent;
            this.lblModalidad.Location = new System.Drawing.Point(11, 113);
            this.lblModalidad.Name = "lblModalidad";
            this.lblModalidad.Size = new System.Drawing.Size(56, 13);
            this.lblModalidad.TabIndex = 36;
            this.lblModalidad.Text = "Modalidad";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(88, 180);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.ReadOnly = true;
            this.txtDepartamento.Size = new System.Drawing.Size(196, 20);
            this.txtDepartamento.TabIndex = 35;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(88, 144);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.ReadOnly = true;
            this.txtCiudad.Size = new System.Drawing.Size(196, 20);
            this.txtCiudad.TabIndex = 33;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(88, 216);
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
            this.cmbCliente.Location = new System.Drawing.Point(88, 38);
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
            this.lblPais.Location = new System.Drawing.Point(11, 220);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(27, 13);
            this.lblPais.TabIndex = 32;
            this.lblPais.Text = "Pais";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(11, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cliente";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartamento.Location = new System.Drawing.Point(11, 184);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(74, 13);
            this.lblDepartamento.TabIndex = 31;
            this.lblDepartamento.Text = "Departamento";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.BackColor = System.Drawing.Color.Transparent;
            this.lblCiudad.Location = new System.Drawing.Point(11, 148);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(40, 13);
            this.lblCiudad.TabIndex = 30;
            this.lblCiudad.Text = "Ciudad";
            // 
            // lblSucursal
            // 
            this.lblSucursal.BackColor = System.Drawing.Color.Transparent;
            this.lblSucursal.Location = new System.Drawing.Point(11, 73);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(71, 40);
            this.lblSucursal.TabIndex = 8;
            this.lblSucursal.Text = "Sucursal";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccion.Location = new System.Drawing.Point(11, 256);
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
            this.cmbSucursalCliente.Location = new System.Drawing.Point(88, 75);
            this.cmbSucursalCliente.MaxLength = 5;
            this.cmbSucursalCliente.Name = "cmbSucursalCliente";
            this.cmbSucursalCliente.Size = new System.Drawing.Size(225, 21);
            this.cmbSucursalCliente.TabIndex = 18;
            this.cmbSucursalCliente.ValueMember = "sucursalCliente.codSucursal";
            this.cmbSucursalCliente.SelectedIndexChanged += new System.EventHandler(this.cmbSucursalCliente_SelectedIndexChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(88, 252);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(270, 20);
            this.txtDireccion.TabIndex = 22;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(692, 528);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 77;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(769, 528);
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
            this.groupPanel2.Controls.Add(this.txtDireccionUbicacion);
            this.groupPanel2.Controls.Add(this.txtModalidad);
            this.groupPanel2.Controls.Add(this.txtUbicacion);
            this.groupPanel2.Controls.Add(this.label20);
            this.groupPanel2.Controls.Add(this.label18);
            this.groupPanel2.Controls.Add(this.label26);
            this.groupPanel2.Controls.Add(this.groupBox3);
            this.groupPanel2.Controls.Add(this.txtSucursal);
            this.groupPanel2.Controls.Add(this.txtNombrecliente);
            this.groupPanel2.Controls.Add(this.label15);
            this.groupPanel2.Controls.Add(this.txtNitCliente);
            this.groupPanel2.Controls.Add(this.label12);
            this.groupPanel2.Controls.Add(this.label19);
            this.groupPanel2.Location = new System.Drawing.Point(12, 98);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(416, 312);
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
            this.groupPanel2.Text = "Informacion Actual";
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
            // calUltimoEnvio
            // 
            // 
            // 
            // 
            this.calUltimoEnvio.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calUltimoEnvio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calUltimoEnvio.ButtonDropDown.Visible = true;
            this.calUltimoEnvio.Location = new System.Drawing.Point(139, 423);
            // 
            // 
            // 
            this.calUltimoEnvio.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calUltimoEnvio.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
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
            // chkEnvioCliente
            // 
            this.chkEnvioCliente.AutoSize = true;
            this.chkEnvioCliente.Location = new System.Drawing.Point(12, 423);
            this.chkEnvioCliente.Name = "chkEnvioCliente";
            this.chkEnvioCliente.Size = new System.Drawing.Size(121, 17);
            this.chkEnvioCliente.TabIndex = 82;
            this.chkEnvioCliente.Text = "Fecha Envio Cliente";
            this.chkEnvioCliente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 36);
            this.label1.TabIndex = 83;
            this.label1.Text = "TRASLADOS ENTRE CLIENTES";
            // 
            // frmTrasladosDeEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(851, 556);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkEnvioCliente);
            this.Controls.Add(this.calUltimoEnvio);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.txtObservacionesIniciales);
            this.Controls.Add(this.btnInfEquipo);
            this.Controls.Add(this.btnBuscarSerial);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTrasladosDeEquipos";
            this.Text = "Traslados De Equipos";
            this.Load += new System.EventHandler(this.frmTrasladosDeEquipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx2)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calUltimoEnvio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.logCambioUbicacionesTableAdapter logCambioUbicacionesTableAdapter1;
        private DevComponents.DotNetBar.ButtonX btnInfEquipo;
        private DevComponents.DotNetBar.ButtonX btnBuscarSerial;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombrecliente;
        private System.Windows.Forms.TextBox txtNitCliente;
        private System.Windows.Forms.TextBox txtDireccionUbicacion;
        private System.Windows.Forms.TextBox txtSucursal;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtModalidad;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.Label lblReservado;
        private System.Windows.Forms.Label label1;
    }
}