namespace spProcesos.cientifica.proceso
{
    partial class frmEnseguimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnseguimiento));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExportarSeguimientos = new DevComponents.DotNetBar.ButtonX();
            this.btnVerSeguimiento = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregarSeguimiento = new DevComponents.DotNetBar.ButtonX();
            this.grdSeguimentos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.btnCambiardeEstado = new DevComponents.DotNetBar.ButtonX();
            this.btnCerrarAsesoria = new DevComponents.DotNetBar.ButtonX();
            this.prioridad_callcenter_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.prioridad_callcenter_cientificaTableAdapter();
            this.sucursalClienteTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.sucursalClienteTableAdapter();
            this.contactosClientesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.contactosClientesTableAdapter();
            this.asesoria_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.asesoria_cientificaTableAdapter();
            this.estado_asesoria_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.estado_asesoria_cientificaTableAdapter();
            this.clientesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.clientesTableAdapter();
            this.txtNumeroAsesoria = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.btnInfSucursal = new DevComponents.DotNetBar.ButtonX();
            this.btnInfCliente = new DevComponents.DotNetBar.ButtonX();
            this.txtNombrecliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.txtInfAdiContacto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCelularContacto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTelefonoContacto = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNombreContacto = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRegistadaPor = new System.Windows.Forms.TextBox();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.txtMotivoConsulta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.calFechaSolicitud = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.seguimiento_asesoria_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.seguimiento_asesoria_cientificaTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbUsuarioInterno = new System.Windows.Forms.ComboBox();
            this.dsSPXSeguridad1 = new SPXSeguridad.data.dsSPXSeguridad();
            this.label25 = new System.Windows.Forms.Label();
            this.chkInterna = new System.Windows.Forms.CheckBox();
            this.chkIndicaNoEquipo = new System.Windows.Forms.CheckBox();
            this.txtAsesorResponsable = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.calVencimiento = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtNumeroLote = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cmbFabricanteEquipo = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cmbModeloEquipo = new System.Windows.Forms.ComboBox();
            this.grdAccionesSeguir = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.label20 = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFabricanteReactivo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReactivo = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.txtBusqueda();
            this.label5 = new System.Windows.Forms.Label();
            this.accion_seguirxasesoria_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.accion_seguirxasesoria_cientificaTableAdapter();
            this.accion_seguir_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.accion_seguir_cientificaTableAdapter();
            this.fabricanteTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.fabricanteTableAdapter();
            this.modelosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter();
            this.referencia_reactivoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.referencia_reactivoTableAdapter();
            this.btnSolicitudServicioIngenieria = new DevComponents.DotNetBar.ButtonX();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.equiposTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter();
            this.solicitudServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.solicitudServicioTableAdapter();
            this.btnTareasProgramadas = new DevComponents.DotNetBar.ButtonX();
            this.txtCodLlamada = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCerrarEnSeguimiento = new DevComponents.DotNetBar.ButtonX();
            this.btnReabrir = new DevComponents.DotNetBar.ButtonX();
            this.llamadaSoportePreTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.LlamadaSoportePreTableAdapter();
            this.clsTusuario1 = new SPXSeguridad.data.cls.clsTusuario();
            this.btnCambiarCliente = new DevComponents.DotNetBar.ButtonX();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.txtCodigoQc = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSeguimentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaSolicitud)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calVencimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccionesSeguir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.tabControlPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 511);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 51);
            this.panel1.TabIndex = 6;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(797, 16);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(5, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Seguimientos";
            // 
            // btnExportarSeguimientos
            // 
            this.btnExportarSeguimientos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExportarSeguimientos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarSeguimientos.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExportarSeguimientos.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarSeguimientos.Image")));
            this.btnExportarSeguimientos.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnExportarSeguimientos.Location = new System.Drawing.Point(853, 0);
            this.btnExportarSeguimientos.Name = "btnExportarSeguimientos";
            this.btnExportarSeguimientos.Size = new System.Drawing.Size(28, 28);
            this.btnExportarSeguimientos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExportarSeguimientos.TabIndex = 63;
            this.btnExportarSeguimientos.Click += new System.EventHandler(this.btnExportarSeguimientos_Click);
            // 
            // btnVerSeguimiento
            // 
            this.btnVerSeguimiento.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVerSeguimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerSeguimiento.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnVerSeguimiento.Image = ((System.Drawing.Image)(resources.GetObject("btnVerSeguimiento.Image")));
            this.btnVerSeguimiento.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnVerSeguimiento.Location = new System.Drawing.Point(819, 0);
            this.btnVerSeguimiento.Name = "btnVerSeguimiento";
            this.btnVerSeguimiento.Size = new System.Drawing.Size(28, 28);
            this.btnVerSeguimiento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnVerSeguimiento.TabIndex = 61;
            this.btnVerSeguimiento.Click += new System.EventHandler(this.btnVerSeguimiento_Click);
            // 
            // btnAgregarSeguimiento
            // 
            this.btnAgregarSeguimiento.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregarSeguimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarSeguimiento.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAgregarSeguimiento.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarSeguimiento.Image")));
            this.btnAgregarSeguimiento.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnAgregarSeguimiento.Location = new System.Drawing.Point(785, 0);
            this.btnAgregarSeguimiento.Name = "btnAgregarSeguimiento";
            this.btnAgregarSeguimiento.Size = new System.Drawing.Size(28, 28);
            this.btnAgregarSeguimiento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAgregarSeguimiento.TabIndex = 60;
            this.btnAgregarSeguimiento.Click += new System.EventHandler(this.btnAgregarSeguimiento_Click);
            // 
            // grdSeguimentos
            // 
            this.grdSeguimentos.AllowUpdate = false;
            this.grdSeguimentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdSeguimentos.DataMember = "seguimiento_asesoria_cientifica";
            this.grdSeguimentos.DataSource = this.dsSpx1;
            this.grdSeguimentos.FilterBar = true;
            this.grdSeguimentos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdSeguimentos.Images"))));
            this.grdSeguimentos.Location = new System.Drawing.Point(7, 31);
            this.grdSeguimentos.Name = "grdSeguimentos";
            this.grdSeguimentos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdSeguimentos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdSeguimentos.PreviewInfo.ZoomFactor = 75D;
            this.grdSeguimentos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdSeguimentos.PrintInfo.PageSettings")));
            this.grdSeguimentos.RowHeight = 46;
            this.grdSeguimentos.Size = new System.Drawing.Size(873, 440);
            this.grdSeguimentos.TabIndex = 53;
            this.grdSeguimentos.Text = "c1TrueDBGrid2";
            this.grdSeguimentos.PropBag = resources.GetString("grdSeguimentos.PropBag");
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.EnforceConstraints = false;
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCambiardeEstado
            // 
            this.btnCambiardeEstado.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCambiardeEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCambiardeEstado.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCambiardeEstado.Image = ((System.Drawing.Image)(resources.GetObject("btnCambiardeEstado.Image")));
            this.btnCambiardeEstado.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnCambiardeEstado.Location = new System.Drawing.Point(743, 73);
            this.btnCambiardeEstado.Name = "btnCambiardeEstado";
            this.btnCambiardeEstado.Size = new System.Drawing.Size(130, 28);
            this.btnCambiardeEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCambiardeEstado.TabIndex = 65;
            this.btnCambiardeEstado.Text = "Cambiar de Estado";
            this.btnCambiardeEstado.Visible = false;
            this.btnCambiardeEstado.Click += new System.EventHandler(this.btnCambiardeEstado_Click);
            // 
            // btnCerrarAsesoria
            // 
            this.btnCerrarAsesoria.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCerrarAsesoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarAsesoria.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCerrarAsesoria.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarAsesoria.Image")));
            this.btnCerrarAsesoria.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnCerrarAsesoria.Location = new System.Drawing.Point(743, 12);
            this.btnCerrarAsesoria.Name = "btnCerrarAsesoria";
            this.btnCerrarAsesoria.Size = new System.Drawing.Size(130, 28);
            this.btnCerrarAsesoria.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCerrarAsesoria.TabIndex = 64;
            this.btnCerrarAsesoria.Text = "Cerrar Asesoria";
            this.btnCerrarAsesoria.Click += new System.EventHandler(this.btnCerrarAsesoria_Click);
            // 
            // prioridad_callcenter_cientificaTableAdapter1
            // 
            this.prioridad_callcenter_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // sucursalClienteTableAdapter1
            // 
            this.sucursalClienteTableAdapter1.ClearBeforeFill = true;
            // 
            // contactosClientesTableAdapter1
            // 
            this.contactosClientesTableAdapter1.ClearBeforeFill = true;
            // 
            // asesoria_cientificaTableAdapter1
            // 
            this.asesoria_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // estado_asesoria_cientificaTableAdapter1
            // 
            this.estado_asesoria_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // txtNumeroAsesoria
            // 
            this.txtNumeroAsesoria.BackColor = System.Drawing.Color.White;
            this.txtNumeroAsesoria.Location = new System.Drawing.Point(118, 4);
            this.txtNumeroAsesoria.Name = "txtNumeroAsesoria";
            this.txtNumeroAsesoria.ReadOnly = true;
            this.txtNumeroAsesoria.Size = new System.Drawing.Size(181, 20);
            this.txtNumeroAsesoria.TabIndex = 77;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.cmbSucursal);
            this.groupBox4.Controls.Add(this.btnInfSucursal);
            this.groupBox4.Controls.Add(this.btnInfCliente);
            this.groupBox4.Controls.Add(this.txtNombrecliente);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Location = new System.Drawing.Point(315, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(420, 220);
            this.groupBox4.TabIndex = 76;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informacion del Cliente";
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.DataSource = this.dsSpx1;
            this.cmbSucursal.DisplayMember = "sucursalCliente.nombreSucursal";
            this.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursal.Enabled = false;
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(61, 50);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(250, 21);
            this.cmbSucursal.TabIndex = 30;
            this.cmbSucursal.ValueMember = "sucursalCliente.codSucursal";
            // 
            // btnInfSucursal
            // 
            this.btnInfSucursal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInfSucursal.Image = ((System.Drawing.Image)(resources.GetObject("btnInfSucursal.Image")));
            this.btnInfSucursal.ImageFixedSize = new System.Drawing.Size(29, 29);
            this.btnInfSucursal.Location = new System.Drawing.Point(317, 48);
            this.btnInfSucursal.Name = "btnInfSucursal";
            this.btnInfSucursal.Size = new System.Drawing.Size(33, 33);
            this.btnInfSucursal.TabIndex = 86;
            this.btnInfSucursal.Click += new System.EventHandler(this.btnInfSucursal_Click);
            // 
            // btnInfCliente
            // 
            this.btnInfCliente.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInfCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnInfCliente.Image")));
            this.btnInfCliente.ImageFixedSize = new System.Drawing.Size(29, 29);
            this.btnInfCliente.Location = new System.Drawing.Point(317, 12);
            this.btnInfCliente.Name = "btnInfCliente";
            this.btnInfCliente.Size = new System.Drawing.Size(33, 33);
            this.btnInfCliente.TabIndex = 85;
            this.btnInfCliente.Click += new System.EventHandler(this.btnInfCliente_Click);
            // 
            // txtNombrecliente
            // 
            this.txtNombrecliente.BackColor = System.Drawing.Color.White;
            this.txtNombrecliente.Location = new System.Drawing.Point(61, 20);
            this.txtNombrecliente.Name = "txtNombrecliente";
            this.txtNombrecliente.ReadOnly = true;
            this.txtNombrecliente.Size = new System.Drawing.Size(251, 20);
            this.txtNombrecliente.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(7, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 84;
            this.label12.Text = "Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.buttonX1);
            this.groupBox2.Controls.Add(this.txtInfAdiContacto);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtCelularContacto);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtTelefonoContacto);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtNombreContacto);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(7, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 142);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contacto";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Image = ((System.Drawing.Image)(resources.GetObject("buttonX1.Image")));
            this.buttonX1.ImageFixedSize = new System.Drawing.Size(29, 29);
            this.buttonX1.Location = new System.Drawing.Point(310, 12);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(33, 33);
            this.buttonX1.TabIndex = 86;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // txtInfAdiContacto
            // 
            this.txtInfAdiContacto.BackColor = System.Drawing.Color.White;
            this.txtInfAdiContacto.Location = new System.Drawing.Point(120, 80);
            this.txtInfAdiContacto.Multiline = true;
            this.txtInfAdiContacto.Name = "txtInfAdiContacto";
            this.txtInfAdiContacto.ReadOnly = true;
            this.txtInfAdiContacto.Size = new System.Drawing.Size(278, 52);
            this.txtInfAdiContacto.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(6, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 29);
            this.label13.TabIndex = 35;
            this.label13.Text = "Informacion Adicional de Contacto";
            // 
            // txtCelularContacto
            // 
            this.txtCelularContacto.BackColor = System.Drawing.Color.White;
            this.txtCelularContacto.Location = new System.Drawing.Point(219, 51);
            this.txtCelularContacto.Name = "txtCelularContacto";
            this.txtCelularContacto.ReadOnly = true;
            this.txtCelularContacto.Size = new System.Drawing.Size(121, 20);
            this.txtCelularContacto.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(182, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Celular";
            // 
            // txtTelefonoContacto
            // 
            this.txtTelefonoContacto.BackColor = System.Drawing.Color.White;
            this.txtTelefonoContacto.Location = new System.Drawing.Point(54, 50);
            this.txtTelefonoContacto.Name = "txtTelefonoContacto";
            this.txtTelefonoContacto.ReadOnly = true;
            this.txtTelefonoContacto.Size = new System.Drawing.Size(112, 20);
            this.txtTelefonoContacto.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Telefono";
            // 
            // txtNombreContacto
            // 
            this.txtNombreContacto.BackColor = System.Drawing.Color.White;
            this.txtNombreContacto.Location = new System.Drawing.Point(54, 23);
            this.txtNombreContacto.Name = "txtNombreContacto";
            this.txtNombreContacto.ReadOnly = true;
            this.txtNombreContacto.Size = new System.Drawing.Size(251, 20);
            this.txtNombreContacto.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Nombre";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 50);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "Sucursal";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(3, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 75;
            this.label11.Text = "Asesoria Num:";
            // 
            // txtRegistadaPor
            // 
            this.txtRegistadaPor.BackColor = System.Drawing.Color.White;
            this.txtRegistadaPor.Location = new System.Drawing.Point(118, 55);
            this.txtRegistadaPor.Name = "txtRegistadaPor";
            this.txtRegistadaPor.ReadOnly = true;
            this.txtRegistadaPor.Size = new System.Drawing.Size(181, 20);
            this.txtRegistadaPor.TabIndex = 74;
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.DataSource = this.dsSpx1;
            this.cmbPrioridad.DisplayMember = "prioridad_callcenter_cientifica.nombre_prioridad";
            this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridad.Enabled = false;
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Location = new System.Drawing.Point(118, 108);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(181, 21);
            this.cmbPrioridad.TabIndex = 73;
            this.cmbPrioridad.ValueMember = "prioridad_callcenter_cientifica.cod_prioridad_callcenter_cientifica";
            // 
            // txtMotivoConsulta
            // 
            this.txtMotivoConsulta.BackColor = System.Drawing.Color.White;
            this.txtMotivoConsulta.Location = new System.Drawing.Point(6, 149);
            this.txtMotivoConsulta.Multiline = true;
            this.txtMotivoConsulta.Name = "txtMotivoConsulta";
            this.txtMotivoConsulta.ReadOnly = true;
            this.txtMotivoConsulta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMotivoConsulta.Size = new System.Drawing.Size(293, 105);
            this.txtMotivoConsulta.TabIndex = 72;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(3, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 71;
            this.label10.Text = "Motivo de la Consulta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(3, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Prioridad Asesoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Registada Por:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(3, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 13);
            this.label17.TabIndex = 68;
            this.label17.Text = "Fecha de Solicitud:";
            // 
            // calFechaSolicitud
            // 
            // 
            // 
            // 
            this.calFechaSolicitud.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calFechaSolicitud.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaSolicitud.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.calFechaSolicitud.ButtonDropDown.Visible = true;
            this.calFechaSolicitud.Enabled = false;
            this.calFechaSolicitud.Location = new System.Drawing.Point(118, 30);
            // 
            // 
            // 
            this.calFechaSolicitud.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFechaSolicitud.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calFechaSolicitud.MonthCalendar.BackgroundStyle.Class = "";
            this.calFechaSolicitud.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaSolicitud.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calFechaSolicitud.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calFechaSolicitud.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calFechaSolicitud.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calFechaSolicitud.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calFechaSolicitud.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calFechaSolicitud.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calFechaSolicitud.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calFechaSolicitud.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaSolicitud.MonthCalendar.DisplayMonth = new System.DateTime(2010, 11, 1, 0, 0, 0, 0);
            this.calFechaSolicitud.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calFechaSolicitud.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calFechaSolicitud.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFechaSolicitud.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calFechaSolicitud.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calFechaSolicitud.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calFechaSolicitud.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calFechaSolicitud.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaSolicitud.MonthCalendar.TodayButtonVisible = true;
            this.calFechaSolicitud.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calFechaSolicitud.Name = "calFechaSolicitud";
            this.calFechaSolicitud.Size = new System.Drawing.Size(181, 20);
            this.calFechaSolicitud.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.calFechaSolicitud.TabIndex = 67;
            // 
            // seguimiento_asesoria_cientificaTableAdapter1
            // 
            this.seguimiento_asesoria_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.cmbUsuarioInterno);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.chkInterna);
            this.groupBox3.Controls.Add(this.chkIndicaNoEquipo);
            this.groupBox3.Controls.Add(this.txtAsesorResponsable);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.calVencimiento);
            this.groupBox3.Controls.Add(this.txtNumeroLote);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.cmbFabricanteEquipo);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.cmbModeloEquipo);
            this.groupBox3.Controls.Add(this.grdAccionesSeguir);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.txtSerial);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtFabricanteReactivo);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtReactivo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(4, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(772, 187);
            this.groupBox3.TabIndex = 78;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion Aceptacion";
            // 
            // cmbUsuarioInterno
            // 
            this.cmbUsuarioInterno.DataSource = this.dsSPXSeguridad1;
            this.cmbUsuarioInterno.DisplayMember = "usuario.nombre";
            this.cmbUsuarioInterno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuarioInterno.Enabled = false;
            this.cmbUsuarioInterno.FormattingEnabled = true;
            this.cmbUsuarioInterno.Location = new System.Drawing.Point(588, 160);
            this.cmbUsuarioInterno.Name = "cmbUsuarioInterno";
            this.cmbUsuarioInterno.Size = new System.Drawing.Size(181, 21);
            this.cmbUsuarioInterno.TabIndex = 111;
            this.cmbUsuarioInterno.ValueMember = "usuarios.login";
            // 
            // dsSPXSeguridad1
            // 
            this.dsSPXSeguridad1.DataSetName = "dsSPXSeguridad";
            this.dsSPXSeguridad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(500, 165);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(82, 13);
            this.label25.TabIndex = 110;
            this.label25.Text = "Usuario Interno:";
            // 
            // chkInterna
            // 
            this.chkInterna.AutoSize = true;
            this.chkInterna.Enabled = false;
            this.chkInterna.Location = new System.Drawing.Point(352, 162);
            this.chkInterna.Name = "chkInterna";
            this.chkInterna.Size = new System.Drawing.Size(102, 17);
            this.chkInterna.TabIndex = 109;
            this.chkInterna.Text = "Llamada Interna";
            this.chkInterna.UseVisualStyleBackColor = true;
            // 
            // chkIndicaNoEquipo
            // 
            this.chkIndicaNoEquipo.AutoSize = true;
            this.chkIndicaNoEquipo.Enabled = false;
            this.chkIndicaNoEquipo.Location = new System.Drawing.Point(132, 17);
            this.chkIndicaNoEquipo.Name = "chkIndicaNoEquipo";
            this.chkIndicaNoEquipo.Size = new System.Drawing.Size(183, 17);
            this.chkIndicaNoEquipo.TabIndex = 108;
            this.chkIndicaNoEquipo.Text = "Llamada sin Equipo y/o Reactivo";
            this.chkIndicaNoEquipo.UseVisualStyleBackColor = true;
            // 
            // txtAsesorResponsable
            // 
            this.txtAsesorResponsable.BackColor = System.Drawing.Color.White;
            this.txtAsesorResponsable.Location = new System.Drawing.Point(134, 40);
            this.txtAsesorResponsable.Name = "txtAsesorResponsable";
            this.txtAsesorResponsable.ReadOnly = true;
            this.txtAsesorResponsable.Size = new System.Drawing.Size(181, 20);
            this.txtAsesorResponsable.TabIndex = 104;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(19, 135);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(114, 13);
            this.label24.TabIndex = 103;
            this.label24.Text = "Vencimiento Reactivo:";
            // 
            // calVencimiento
            // 
            // 
            // 
            // 
            this.calVencimiento.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calVencimiento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVencimiento.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.calVencimiento.ButtonDropDown.Visible = true;
            this.calVencimiento.Enabled = false;
            this.calVencimiento.Location = new System.Drawing.Point(134, 134);
            // 
            // 
            // 
            this.calVencimiento.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calVencimiento.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calVencimiento.MonthCalendar.BackgroundStyle.Class = "";
            this.calVencimiento.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVencimiento.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calVencimiento.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calVencimiento.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calVencimiento.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calVencimiento.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calVencimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calVencimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calVencimiento.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calVencimiento.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVencimiento.MonthCalendar.DisplayMonth = new System.DateTime(2010, 11, 1, 0, 0, 0, 0);
            this.calVencimiento.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calVencimiento.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calVencimiento.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calVencimiento.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calVencimiento.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calVencimiento.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calVencimiento.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calVencimiento.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVencimiento.MonthCalendar.TodayButtonVisible = true;
            this.calVencimiento.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calVencimiento.Name = "calVencimiento";
            this.calVencimiento.Size = new System.Drawing.Size(181, 20);
            this.calVencimiento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.calVencimiento.TabIndex = 102;
            // 
            // txtNumeroLote
            // 
            this.txtNumeroLote.BackColor = System.Drawing.Color.White;
            this.txtNumeroLote.Location = new System.Drawing.Point(134, 111);
            this.txtNumeroLote.Name = "txtNumeroLote";
            this.txtNumeroLote.ReadOnly = true;
            this.txtNumeroLote.Size = new System.Drawing.Size(181, 20);
            this.txtNumeroLote.TabIndex = 101;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(19, 111);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 13);
            this.label23.TabIndex = 100;
            this.label23.Text = "Numero Lote:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(349, 115);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 13);
            this.label21.TabIndex = 96;
            this.label21.Text = "Fabricante Equipo";
            // 
            // cmbFabricanteEquipo
            // 
            this.cmbFabricanteEquipo.DataSource = this.dsSpx1;
            this.cmbFabricanteEquipo.DisplayMember = "fabricante.nombre_fabricante";
            this.cmbFabricanteEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFabricanteEquipo.Enabled = false;
            this.cmbFabricanteEquipo.FormattingEnabled = true;
            this.cmbFabricanteEquipo.Location = new System.Drawing.Point(352, 131);
            this.cmbFabricanteEquipo.Name = "cmbFabricanteEquipo";
            this.cmbFabricanteEquipo.Size = new System.Drawing.Size(181, 21);
            this.cmbFabricanteEquipo.TabIndex = 97;
            this.cmbFabricanteEquipo.ValueMember = "fabricante.codFabricante";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(585, 115);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(78, 13);
            this.label22.TabIndex = 94;
            this.label22.Text = "Modelo Equipo";
            // 
            // cmbModeloEquipo
            // 
            this.cmbModeloEquipo.DataSource = this.dsSpx1;
            this.cmbModeloEquipo.DisplayMember = "Modelos.NombreModelo";
            this.cmbModeloEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModeloEquipo.Enabled = false;
            this.cmbModeloEquipo.FormattingEnabled = true;
            this.cmbModeloEquipo.Location = new System.Drawing.Point(588, 129);
            this.cmbModeloEquipo.Name = "cmbModeloEquipo";
            this.cmbModeloEquipo.Size = new System.Drawing.Size(181, 21);
            this.cmbModeloEquipo.TabIndex = 95;
            this.cmbModeloEquipo.ValueMember = "Modelos.codModelo";
            // 
            // grdAccionesSeguir
            // 
            this.grdAccionesSeguir.AllowUpdate = false;
            this.grdAccionesSeguir.DataMember = "accion_seguir_cientifica";
            this.grdAccionesSeguir.DataSource = this.dsSpx1;
            this.grdAccionesSeguir.Images.Add(((System.Drawing.Image)(resources.GetObject("grdAccionesSeguir.Images"))));
            this.grdAccionesSeguir.Location = new System.Drawing.Point(352, 29);
            this.grdAccionesSeguir.Name = "grdAccionesSeguir";
            this.grdAccionesSeguir.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdAccionesSeguir.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdAccionesSeguir.PreviewInfo.ZoomFactor = 75D;
            this.grdAccionesSeguir.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdAccionesSeguir.PrintInfo.PageSettings")));
            this.grdAccionesSeguir.Size = new System.Drawing.Size(404, 82);
            this.grdAccionesSeguir.TabIndex = 92;
            this.grdAccionesSeguir.Text = "c1TrueDBGrid1";
            this.grdAccionesSeguir.PropBag = resources.GetString("grdAccionesSeguir.PropBag");
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(349, 13);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(96, 13);
            this.label20.TabIndex = 88;
            this.label20.Text = "Acciones a Seguir:";
            // 
            // txtSerial
            // 
            this.txtSerial.BackColor = System.Drawing.Color.White;
            this.txtSerial.Location = new System.Drawing.Point(134, 158);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.ReadOnly = true;
            this.txtSerial.Size = new System.Drawing.Size(181, 20);
            this.txtSerial.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Serial:";
            // 
            // txtFabricanteReactivo
            // 
            this.txtFabricanteReactivo.BackColor = System.Drawing.Color.White;
            this.txtFabricanteReactivo.Location = new System.Drawing.Point(134, 89);
            this.txtFabricanteReactivo.Name = "txtFabricanteReactivo";
            this.txtFabricanteReactivo.ReadOnly = true;
            this.txtFabricanteReactivo.Size = new System.Drawing.Size(181, 20);
            this.txtFabricanteReactivo.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Fabricante Reactivo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Asesor Responsable:";
            // 
            // txtReactivo
            // 
            this.txtReactivo.codigo = "cod_referencia_reactivo";
            this.txtReactivo.DataMember = this.dsSpx1.referencia_reactivo;
            this.txtReactivo.DataSource = this.dsSpx1;
            this.txtReactivo.descripcion1 = "nombre_referencia_reactivo";
            this.txtReactivo.descripcion2 = "codigo_manual";
            this.txtReactivo.Enabled = false;
            this.txtReactivo.filtroAdicional = null;
            this.txtReactivo.LimiteY = 125;
            this.txtReactivo.linkPadre = null;
            this.txtReactivo.Location = new System.Drawing.Point(134, 65);
            this.txtReactivo.Name = "txtReactivo";
            this.txtReactivo.sentenciaFromObligatoria = null;
            this.txtReactivo.Size = new System.Drawing.Size(181, 20);
            this.txtReactivo.TabIndex = 41;
            this.txtReactivo.Tabla = this.dsSpx1.referencia_reactivo;
            this.txtReactivo.TamanoPopUp = 5;
            this.txtReactivo.txtPadre = null;
            this.txtReactivo.Value = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Reactivo:";
            // 
            // accion_seguirxasesoria_cientificaTableAdapter1
            // 
            this.accion_seguirxasesoria_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // accion_seguir_cientificaTableAdapter1
            // 
            this.accion_seguir_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // fabricanteTableAdapter1
            // 
            this.fabricanteTableAdapter1.ClearBeforeFill = true;
            // 
            // modelosTableAdapter1
            // 
            this.modelosTableAdapter1.ClearBeforeFill = true;
            // 
            // referencia_reactivoTableAdapter1
            // 
            this.referencia_reactivoTableAdapter1.ClearBeforeFill = true;
            // 
            // btnSolicitudServicioIngenieria
            // 
            this.btnSolicitudServicioIngenieria.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSolicitudServicioIngenieria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSolicitudServicioIngenieria.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSolicitudServicioIngenieria.Image = ((System.Drawing.Image)(resources.GetObject("btnSolicitudServicioIngenieria.Image")));
            this.btnSolicitudServicioIngenieria.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnSolicitudServicioIngenieria.Location = new System.Drawing.Point(743, 104);
            this.btnSolicitudServicioIngenieria.Name = "btnSolicitudServicioIngenieria";
            this.btnSolicitudServicioIngenieria.Size = new System.Drawing.Size(130, 28);
            this.btnSolicitudServicioIngenieria.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSolicitudServicioIngenieria.TabIndex = 79;
            this.btnSolicitudServicioIngenieria.Text = "Solicitud Ingenieria";
            this.btnSolicitudServicioIngenieria.Click += new System.EventHandler(this.btnSolicitudServicioIngenieria_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.DataSource = this.dsSpx1;
            this.cmbEstado.DisplayMember = "estado_asesoria_cientifica.nombre_estado_asesoria_cientifica";
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Enabled = false;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(118, 81);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(181, 21);
            this.cmbEstado.TabIndex = 80;
            this.cmbEstado.ValueMember = "estado_asesoria_cientifica.cod_estado_asesoria_cientifica";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "Estado Asesoria:";
            // 
            // equiposTableAdapter1
            // 
            this.equiposTableAdapter1.ClearBeforeFill = true;
            // 
            // solicitudServicioTableAdapter1
            // 
            this.solicitudServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // btnTareasProgramadas
            // 
            this.btnTareasProgramadas.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTareasProgramadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTareasProgramadas.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTareasProgramadas.Image = ((System.Drawing.Image)(resources.GetObject("btnTareasProgramadas.Image")));
            this.btnTareasProgramadas.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnTareasProgramadas.Location = new System.Drawing.Point(779, 296);
            this.btnTareasProgramadas.Name = "btnTareasProgramadas";
            this.btnTareasProgramadas.Size = new System.Drawing.Size(94, 57);
            this.btnTareasProgramadas.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTareasProgramadas.TabIndex = 82;
            this.btnTareasProgramadas.Text = "Tareas Programadas";
            this.btnTareasProgramadas.Click += new System.EventHandler(this.btnTareasProgramadas_Click);
            // 
            // txtCodLlamada
            // 
            this.txtCodLlamada.BackColor = System.Drawing.Color.White;
            this.txtCodLlamada.Location = new System.Drawing.Point(777, 221);
            this.txtCodLlamada.Name = "txtCodLlamada";
            this.txtCodLlamada.ReadOnly = true;
            this.txtCodLlamada.Size = new System.Drawing.Size(98, 20);
            this.txtCodLlamada.TabIndex = 83;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(776, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 84;
            this.label6.Text = "Cod LLamada";
            // 
            // btnCerrarEnSeguimiento
            // 
            this.btnCerrarEnSeguimiento.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCerrarEnSeguimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarEnSeguimiento.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCerrarEnSeguimiento.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarEnSeguimiento.Image")));
            this.btnCerrarEnSeguimiento.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnCerrarEnSeguimiento.Location = new System.Drawing.Point(743, 42);
            this.btnCerrarEnSeguimiento.Name = "btnCerrarEnSeguimiento";
            this.btnCerrarEnSeguimiento.Size = new System.Drawing.Size(130, 28);
            this.btnCerrarEnSeguimiento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCerrarEnSeguimiento.TabIndex = 85;
            this.btnCerrarEnSeguimiento.Text = "Cerrar Seguimiento";
            this.btnCerrarEnSeguimiento.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // btnReabrir
            // 
            this.btnReabrir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReabrir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReabrir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReabrir.Image = ((System.Drawing.Image)(resources.GetObject("btnReabrir.Image")));
            this.btnReabrir.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnReabrir.Location = new System.Drawing.Point(743, 135);
            this.btnReabrir.Name = "btnReabrir";
            this.btnReabrir.Size = new System.Drawing.Size(130, 28);
            this.btnReabrir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReabrir.TabIndex = 86;
            this.btnReabrir.Text = "Reabrir";
            this.btnReabrir.Click += new System.EventHandler(this.btnReabrir_Click);
            // 
            // llamadaSoportePreTableAdapter1
            // 
            this.llamadaSoportePreTableAdapter1.ClearBeforeFill = true;
            // 
            // clsTusuario1
            // 
            this.clsTusuario1.nombreLlave = "cod_usuario";
            this.clsTusuario1.nombreTabla = "usuario";
            this.clsTusuario1.sentenciaBase = resources.GetString("clsTusuario1.sentenciaBase");
            this.clsTusuario1.sentenciaBaseDistinct = null;
            // 
            // btnCambiarCliente
            // 
            this.btnCambiarCliente.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCambiarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCambiarCliente.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCambiarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCambiarCliente.Image")));
            this.btnCambiarCliente.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnCambiarCliente.Location = new System.Drawing.Point(743, 166);
            this.btnCambiarCliente.Name = "btnCambiarCliente";
            this.btnCambiarCliente.Size = new System.Drawing.Size(130, 28);
            this.btnCambiarCliente.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCambiarCliente.TabIndex = 87;
            this.btnCambiarCliente.Text = "Cambiar Cliente";
            this.btnCambiarCliente.Click += new System.EventHandler(this.btnCambiarCliente_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Controls.Add(this.tabControlPanel2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(885, 511);
            this.tabControl1.TabIndex = 88;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItem1);
            this.tabControl1.Tabs.Add(this.tabItem2);
            this.tabControl1.Text = "tabControl1";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.txtCodigoQc);
            this.tabControlPanel1.Controls.Add(this.label18);
            this.tabControlPanel1.Controls.Add(this.groupBox3);
            this.tabControlPanel1.Controls.Add(this.btnCambiarCliente);
            this.tabControlPanel1.Controls.Add(this.btnCerrarAsesoria);
            this.tabControlPanel1.Controls.Add(this.btnReabrir);
            this.tabControlPanel1.Controls.Add(this.btnCambiardeEstado);
            this.tabControlPanel1.Controls.Add(this.btnCerrarEnSeguimiento);
            this.tabControlPanel1.Controls.Add(this.calFechaSolicitud);
            this.tabControlPanel1.Controls.Add(this.txtCodLlamada);
            this.tabControlPanel1.Controls.Add(this.label17);
            this.tabControlPanel1.Controls.Add(this.label6);
            this.tabControlPanel1.Controls.Add(this.label2);
            this.tabControlPanel1.Controls.Add(this.btnTareasProgramadas);
            this.tabControlPanel1.Controls.Add(this.label3);
            this.tabControlPanel1.Controls.Add(this.label1);
            this.tabControlPanel1.Controls.Add(this.label10);
            this.tabControlPanel1.Controls.Add(this.cmbEstado);
            this.tabControlPanel1.Controls.Add(this.txtMotivoConsulta);
            this.tabControlPanel1.Controls.Add(this.btnSolicitudServicioIngenieria);
            this.tabControlPanel1.Controls.Add(this.cmbPrioridad);
            this.tabControlPanel1.Controls.Add(this.txtRegistadaPor);
            this.tabControlPanel1.Controls.Add(this.txtNumeroAsesoria);
            this.tabControlPanel1.Controls.Add(this.label11);
            this.tabControlPanel1.Controls.Add(this.groupBox4);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(885, 485);
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
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel1;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "General";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.label4);
            this.tabControlPanel2.Controls.Add(this.grdSeguimentos);
            this.tabControlPanel2.Controls.Add(this.btnExportarSeguimientos);
            this.tabControlPanel2.Controls.Add(this.btnAgregarSeguimiento);
            this.tabControlPanel2.Controls.Add(this.btnVerSeguimiento);
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(885, 485);
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
            // tabItem2
            // 
            this.tabItem2.AttachedControl = this.tabControlPanel2;
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.Text = "Seguimientos";
            // 
            // txtCodigoQc
            // 
            this.txtCodigoQc.BackColor = System.Drawing.Color.White;
            this.txtCodigoQc.Location = new System.Drawing.Point(775, 260);
            this.txtCodigoQc.Name = "txtCodigoQc";
            this.txtCodigoQc.ReadOnly = true;
            this.txtCodigoQc.Size = new System.Drawing.Size(98, 20);
            this.txtCodigoQc.TabIndex = 88;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(774, 244);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 13);
            this.label18.TabIndex = 89;
            this.label18.Text = "Codigo QC";
            // 
            // frmEnseguimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 562);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(901, 600);
            this.MinimumSize = new System.Drawing.Size(901, 600);
            this.Name = "frmEnseguimiento";
            this.Text = "Aseoria En seguimiento";
            this.Load += new System.EventHandler(this.frmEnseguimiento_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSeguimentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaSolicitud)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calVencimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccionesSeguir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.tabControlPanel1.PerformLayout();
            this.tabControlPanel2.ResumeLayout(false);
            this.tabControlPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdSeguimentos;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.ButtonX btnExportarSeguimientos;
        private DevComponents.DotNetBar.ButtonX btnVerSeguimiento;
        private DevComponents.DotNetBar.ButtonX btnAgregarSeguimiento;
        private DevComponents.DotNetBar.ButtonX btnCambiardeEstado;
        private DevComponents.DotNetBar.ButtonX btnCerrarAsesoria;
        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.prioridad_callcenter_cientificaTableAdapter prioridad_callcenter_cientificaTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.sucursalClienteTableAdapter sucursalClienteTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.contactosClientesTableAdapter contactosClientesTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.asesoria_cientificaTableAdapter asesoria_cientificaTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.estado_asesoria_cientificaTableAdapter estado_asesoria_cientificaTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.clientesTableAdapter clientesTableAdapter1;
        private System.Windows.Forms.TextBox txtNumeroAsesoria;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private DevComponents.DotNetBar.ButtonX btnInfSucursal;
        private DevComponents.DotNetBar.ButtonX btnInfCliente;
        private System.Windows.Forms.TextBox txtNombrecliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.TextBox txtInfAdiContacto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCelularContacto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTelefonoContacto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNombreContacto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRegistadaPor;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.TextBox txtMotivoConsulta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label17;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFechaSolicitud;
        private SPControladoraDatos.dsSpxTableAdapters.seguimiento_asesoria_cientificaTableAdapter seguimiento_asesoria_cientificaTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label24;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calVencimiento;
        private System.Windows.Forms.TextBox txtNumeroLote;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cmbFabricanteEquipo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cmbModeloEquipo;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdAccionesSeguir;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFabricanteReactivo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.txtBusqueda txtReactivo;
        private System.Windows.Forms.Label label5;
        private SPControladoraDatos.dsSpxTableAdapters.accion_seguirxasesoria_cientificaTableAdapter accion_seguirxasesoria_cientificaTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.accion_seguir_cientificaTableAdapter accion_seguir_cientificaTableAdapter1;
        private System.Windows.Forms.TextBox txtAsesorResponsable;
        private SPControladoraDatos.dsSpxTableAdapters.fabricanteTableAdapter fabricanteTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter modelosTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.referencia_reactivoTableAdapter referencia_reactivoTableAdapter1;
        private DevComponents.DotNetBar.ButtonX btnSolicitudServicioIngenieria;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label1;
        private SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter equiposTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.solicitudServicioTableAdapter solicitudServicioTableAdapter1;
        private DevComponents.DotNetBar.ButtonX btnTareasProgramadas;
        private System.Windows.Forms.CheckBox chkIndicaNoEquipo;
        private System.Windows.Forms.ComboBox cmbUsuarioInterno;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.CheckBox chkInterna;
        private System.Windows.Forms.TextBox txtCodLlamada;
        private System.Windows.Forms.Label label6;
        private DevComponents.DotNetBar.ButtonX btnCerrarEnSeguimiento;
        private DevComponents.DotNetBar.ButtonX btnReabrir;
        private SPControladoraDatos.dsSpxTableAdapters.LlamadaSoportePreTableAdapter llamadaSoportePreTableAdapter1;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad1;
        private SPXSeguridad.data.cls.clsTusuario clsTusuario1;
        private DevComponents.DotNetBar.ButtonX btnCambiarCliente;
        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.TabItem tabItem2;
        private System.Windows.Forms.TextBox txtCodigoQc;
        private System.Windows.Forms.Label label18;
    }
}