namespace SpFrm.terceros
{
    partial class frmInfCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfCliente));
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.clientesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.clientesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNroSocio = new System.Windows.Forms.TextBox();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cmbTituloContacto = new System.Windows.Forms.ComboBox();
            this.cmbtipoDocumento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTelefono2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.txtTelefono1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.grdContactos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.btnInfContactos = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnInfEquipo = new DevComponents.DotNetBar.ButtonX();
            this.grdSucursales = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.vistaSucursalTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.vistaSucursalTableAdapter();
            this.contactosClientesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.contactosClientesTableAdapter();
            this.tipoDocumentoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.tipoDocumentoTableAdapter();
            this.tituloContactoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.tituloContactoTableAdapter();
            this.btnOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.groupPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContactos)).BeginInit();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSucursales)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(6, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Numero de Socio";
            // 
            // txtNroSocio
            // 
            this.txtNroSocio.BackColor = System.Drawing.Color.White;
            this.txtNroSocio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "clientes.numeroSocio", true));
            this.txtNroSocio.Location = new System.Drawing.Point(116, 66);
            this.txtNroSocio.MaxLength = 20;
            this.txtNroSocio.Name = "txtNroSocio";
            this.txtNroSocio.ReadOnly = true;
            this.txtNroSocio.Size = new System.Drawing.Size(252, 20);
            this.txtNroSocio.TabIndex = 26;
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.cmbTituloContacto);
            this.groupPanel1.Controls.Add(this.cmbtipoDocumento);
            this.groupPanel1.Controls.Add(this.label5);
            this.groupPanel1.Controls.Add(this.label11);
            this.groupPanel1.Controls.Add(this.label6);
            this.groupPanel1.Controls.Add(this.label16);
            this.groupPanel1.Controls.Add(this.txtCelular);
            this.groupPanel1.Controls.Add(this.label7);
            this.groupPanel1.Controls.Add(this.label18);
            this.groupPanel1.Controls.Add(this.txtFax);
            this.groupPanel1.Controls.Add(this.label12);
            this.groupPanel1.Controls.Add(this.txtTelefono2);
            this.groupPanel1.Controls.Add(this.label17);
            this.groupPanel1.Controls.Add(this.label8);
            this.groupPanel1.Controls.Add(this.txtEmail);
            this.groupPanel1.Controls.Add(this.label14);
            this.groupPanel1.Controls.Add(this.txtNombres);
            this.groupPanel1.Controls.Add(this.txtApellidos);
            this.groupPanel1.Controls.Add(this.txtNroDocumento);
            this.groupPanel1.Controls.Add(this.txtTelefono1);
            this.groupPanel1.Location = new System.Drawing.Point(9, 92);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(506, 198);
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
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 25;
            this.groupPanel1.Text = "Contacto Principal del Cliente";
            // 
            // cmbTituloContacto
            // 
            this.cmbTituloContacto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsSpx1, "clientes.tituloContacto", true));
            this.cmbTituloContacto.DataSource = this.dsSpx1;
            this.cmbTituloContacto.DisplayMember = "tituloContacto.tituloContacto";
            this.cmbTituloContacto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTituloContacto.Enabled = false;
            this.cmbTituloContacto.FormattingEnabled = true;
            this.cmbTituloContacto.Location = new System.Drawing.Point(104, 6);
            this.cmbTituloContacto.MaxLength = 5;
            this.cmbTituloContacto.Name = "cmbTituloContacto";
            this.cmbTituloContacto.Size = new System.Drawing.Size(148, 21);
            this.cmbTituloContacto.TabIndex = 36;
            this.cmbTituloContacto.ValueMember = "tituloContacto.codTituloContacto";
            // 
            // cmbtipoDocumento
            // 
            this.cmbtipoDocumento.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsSpx1, "clientes.codTipoDoc", true));
            this.cmbtipoDocumento.DataSource = this.dsSpx1;
            this.cmbtipoDocumento.DisplayMember = "tipoDocumento.nombreTipoDoc";
            this.cmbtipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtipoDocumento.Enabled = false;
            this.cmbtipoDocumento.FormattingEnabled = true;
            this.cmbtipoDocumento.Location = new System.Drawing.Point(104, 63);
            this.cmbtipoDocumento.MaxLength = 5;
            this.cmbtipoDocumento.Name = "cmbtipoDocumento";
            this.cmbtipoDocumento.Size = new System.Drawing.Size(148, 21);
            this.cmbtipoDocumento.TabIndex = 21;
            this.cmbtipoDocumento.ValueMember = "tipoDocumento.codTipoDoc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nombres:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(271, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Apellidos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tipo Documento:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(271, 68);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Documento:";
            // 
            // txtCelular
            // 
            this.txtCelular.BackColor = System.Drawing.Color.White;
            this.txtCelular.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "clientes.celular", true));
            this.txtCelular.Location = new System.Drawing.Point(104, 120);
            this.txtCelular.MaxLength = 50;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.ReadOnly = true;
            this.txtCelular.Size = new System.Drawing.Size(148, 20);
            this.txtCelular.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Telefono 1:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 118);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Celular";
            // 
            // txtFax
            // 
            this.txtFax.BackColor = System.Drawing.Color.White;
            this.txtFax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "clientes.fax", true));
            this.txtFax.Location = new System.Drawing.Point(338, 120);
            this.txtFax.MaxLength = 25;
            this.txtFax.Name = "txtFax";
            this.txtFax.ReadOnly = true;
            this.txtFax.Size = new System.Drawing.Size(148, 20);
            this.txtFax.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(271, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Telefono 2:";
            // 
            // txtTelefono2
            // 
            this.txtTelefono2.BackColor = System.Drawing.Color.White;
            this.txtTelefono2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "clientes.telefono2", true));
            this.txtTelefono2.Location = new System.Drawing.Point(338, 92);
            this.txtTelefono2.MaxLength = 25;
            this.txtTelefono2.Name = "txtTelefono2";
            this.txtTelefono2.ReadOnly = true;
            this.txtTelefono2.Size = new System.Drawing.Size(148, 20);
            this.txtTelefono2.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(8, 6);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 27);
            this.label17.TabIndex = 34;
            this.label17.Text = "Titulo Contacto Personal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Fax:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "clientes.email", true));
            this.txtEmail.Location = new System.Drawing.Point(104, 148);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(264, 20);
            this.txtEmail.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Email";
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.Color.White;
            this.txtNombres.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "clientes.nombreContactoPrincipal", true));
            this.txtNombres.Location = new System.Drawing.Point(104, 35);
            this.txtNombres.MaxLength = 20;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.ReadOnly = true;
            this.txtNombres.Size = new System.Drawing.Size(148, 20);
            this.txtNombres.TabIndex = 16;
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.Color.White;
            this.txtApellidos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "clientes.apellidosContacto", true));
            this.txtApellidos.Location = new System.Drawing.Point(338, 35);
            this.txtApellidos.MaxLength = 20;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ReadOnly = true;
            this.txtApellidos.Size = new System.Drawing.Size(148, 20);
            this.txtApellidos.TabIndex = 18;
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.BackColor = System.Drawing.Color.White;
            this.txtNroDocumento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "clientes.docContacto", true));
            this.txtNroDocumento.Location = new System.Drawing.Point(338, 63);
            this.txtNroDocumento.MaxLength = 15;
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.ReadOnly = true;
            this.txtNroDocumento.Size = new System.Drawing.Size(148, 20);
            this.txtNroDocumento.TabIndex = 22;
            // 
            // txtTelefono1
            // 
            this.txtTelefono1.BackColor = System.Drawing.Color.White;
            this.txtTelefono1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "clientes.telefono1", true));
            this.txtTelefono1.Location = new System.Drawing.Point(104, 92);
            this.txtTelefono1.MaxLength = 25;
            this.txtTelefono1.Name = "txtTelefono1";
            this.txtTelefono1.ReadOnly = true;
            this.txtTelefono1.Size = new System.Drawing.Size(148, 20);
            this.txtTelefono1.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(6, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "*Nombre Cliente:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(6, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "*Nit Cliente:";
            // 
            // txtNit
            // 
            this.txtNit.BackColor = System.Drawing.Color.White;
            this.txtNit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "clientes.nitCliente", true));
            this.txtNit.Location = new System.Drawing.Point(116, 10);
            this.txtNit.MaxLength = 20;
            this.txtNit.Name = "txtNit";
            this.txtNit.ReadOnly = true;
            this.txtNit.Size = new System.Drawing.Size(196, 20);
            this.txtNit.TabIndex = 21;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BackColor = System.Drawing.Color.White;
            this.txtNombreCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "clientes.nombreCliente", true));
            this.txtNombreCliente.Location = new System.Drawing.Point(116, 38);
            this.txtNombreCliente.MaxLength = 100;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(252, 20);
            this.txtNombreCliente.TabIndex = 22;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Black;
            this.picLogo.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.dsSpx1, "clientes.logotipo", true));
            this.picLogo.Location = new System.Drawing.Point(521, 8);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(448, 233);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 36;
            this.picLogo.TabStop = false;
            // 
            // groupPanel3
            // 
            this.groupPanel3.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.grdContactos);
            this.groupPanel3.Controls.Add(this.btnInfContactos);
            this.groupPanel3.Location = new System.Drawing.Point(9, 296);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(506, 230);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel3.TabIndex = 38;
            this.groupPanel3.Text = "Contactos";
            // 
            // grdContactos
            // 
            this.grdContactos.AllowUpdate = false;
            this.grdContactos.DataMember = "contactosClientes";
            this.grdContactos.DataSource = this.dsSpx1;
            this.grdContactos.FilterBar = true;
            this.grdContactos.GroupByCaption = "Drag a column header here to group by that column";
            this.grdContactos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdContactos.Images"))));
            this.grdContactos.Location = new System.Drawing.Point(3, 43);
            this.grdContactos.Name = "grdContactos";
            this.grdContactos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdContactos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdContactos.PreviewInfo.ZoomFactor = 75;
            this.grdContactos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdContactos.PrintInfo.PageSettings")));
            this.grdContactos.Size = new System.Drawing.Size(494, 161);
            this.grdContactos.TabIndex = 78;
            this.grdContactos.Text = "c1TrueDBGrid1";
            this.grdContactos.PropBag = resources.GetString("grdContactos.PropBag");
            // 
            // btnInfContactos
            // 
            this.btnInfContactos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInfContactos.Image = ((System.Drawing.Image)(resources.GetObject("btnInfContactos.Image")));
            this.btnInfContactos.ImageFixedSize = new System.Drawing.Size(29, 29);
            this.btnInfContactos.Location = new System.Drawing.Point(464, 3);
            this.btnInfContactos.Name = "btnInfContactos";
            this.btnInfContactos.Size = new System.Drawing.Size(33, 33);
            this.btnInfContactos.TabIndex = 77;
            this.btnInfContactos.Click += new System.EventHandler(this.btnInfContactos_Click);
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btnInfEquipo);
            this.groupPanel2.Controls.Add(this.grdSucursales);
            this.groupPanel2.Location = new System.Drawing.Point(521, 247);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(446, 279);
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
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel2.TabIndex = 37;
            this.groupPanel2.Text = "Sucursales";
            // 
            // btnInfEquipo
            // 
            this.btnInfEquipo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInfEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfEquipo.Image")));
            this.btnInfEquipo.ImageFixedSize = new System.Drawing.Size(29, 29);
            this.btnInfEquipo.Location = new System.Drawing.Point(404, 3);
            this.btnInfEquipo.Name = "btnInfEquipo";
            this.btnInfEquipo.Size = new System.Drawing.Size(33, 33);
            this.btnInfEquipo.TabIndex = 76;
            this.btnInfEquipo.Click += new System.EventHandler(this.btnInfEquipo_Click);
            // 
            // grdSucursales
            // 
            this.grdSucursales.AllowUpdate = false;
            this.grdSucursales.DataMember = "vistaSucursal";
            this.grdSucursales.DataSource = this.dsSpx1;
            this.grdSucursales.FilterBar = true;
            this.grdSucursales.GroupByCaption = "Drag a column header here to group by that column";
            this.grdSucursales.Images.Add(((System.Drawing.Image)(resources.GetObject("grdSucursales.Images"))));
            this.grdSucursales.Location = new System.Drawing.Point(5, 39);
            this.grdSucursales.Name = "grdSucursales";
            this.grdSucursales.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdSucursales.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdSucursales.PreviewInfo.ZoomFactor = 75;
            this.grdSucursales.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdSucursales.PrintInfo.PageSettings")));
            this.grdSucursales.Size = new System.Drawing.Size(432, 214);
            this.grdSucursales.TabIndex = 51;
            this.grdSucursales.Text = "c1TrueDBGrid1";
            this.grdSucursales.PropBag = resources.GetString("grdSucursales.PropBag");
            // 
            // vistaSucursalTableAdapter1
            // 
            this.vistaSucursalTableAdapter1.ClearBeforeFill = true;
            // 
            // contactosClientesTableAdapter1
            // 
            this.contactosClientesTableAdapter1.ClearBeforeFill = true;
            // 
            // tipoDocumentoTableAdapter1
            // 
            this.tipoDocumentoTableAdapter1.ClearBeforeFill = true;
            // 
            // tituloContactoTableAdapter1
            // 
            this.tituloContactoTableAdapter1.ClearBeforeFill = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(452, 14);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 39;
            this.btnOk.Text = "Aceptar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 553);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 50);
            this.panel1.TabIndex = 40;
            // 
            // frmInfCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 603);
            this.ControlBox = false;
            this.Controls.Add(this.txtNroSocio);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupPanel3);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInfCliente";
            this.Text = "Informacion del Cliente";
            this.Load += new System.EventHandler(this.frmInfCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.groupPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdContactos)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSucursales)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.clientesTableAdapter clientesTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNroSocio;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.ComboBox cmbTituloContacto;
        private System.Windows.Forms.ComboBox cmbtipoDocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTelefono2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.TextBox txtTelefono1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.PictureBox picLogo;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdSucursales;
        private SPControladoraDatos.dsSpxTableAdapters.vistaSucursalTableAdapter vistaSucursalTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.contactosClientesTableAdapter contactosClientesTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.tipoDocumentoTableAdapter tipoDocumentoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.tituloContactoTableAdapter tituloContactoTableAdapter1;
        private DevComponents.DotNetBar.ButtonX btnInfEquipo;
        private DevComponents.DotNetBar.ButtonX btnInfContactos;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdContactos;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panel1;
    }
}