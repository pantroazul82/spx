namespace SpFrm.terceros
{
    partial class frmInfSucursal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfSucursal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelefono2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreSucursal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnInfContacto = new DevComponents.DotNetBar.ButtonX();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNroSocio = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNitCliente = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbTituloContacto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefonoContacto = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtTelefonoContactoAlterna = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.contactosClientesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.contactosClientesTableAdapter();
            this.tipoDocumentoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.tipoDocumentoTableAdapter();
            this.tituloContactoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.tituloContactoTableAdapter();
            this.clientesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.clientesTableAdapter();
            this.sucursalClienteTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.sucursalClienteTableAdapter();
            this.vistaSucursalTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.vistaSucursalTableAdapter();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 374);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 50);
            this.panel1.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(344, 15);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Aceptar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCiudad);
            this.groupBox1.Controls.Add(this.txtDepartamento);
            this.groupBox1.Controls.Add(this.txtPais);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtTelefono2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombreSucursal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Location = new System.Drawing.Point(12, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 247);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtCiudad
            // 
            this.txtCiudad.BackColor = System.Drawing.Color.White;
            this.txtCiudad.Location = new System.Drawing.Point(121, 103);
            this.txtCiudad.MaxLength = 25;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.ReadOnly = true;
            this.txtCiudad.Size = new System.Drawing.Size(209, 20);
            this.txtCiudad.TabIndex = 18;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.BackColor = System.Drawing.Color.White;
            this.txtDepartamento.Location = new System.Drawing.Point(121, 75);
            this.txtDepartamento.MaxLength = 25;
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.ReadOnly = true;
            this.txtDepartamento.Size = new System.Drawing.Size(209, 20);
            this.txtDepartamento.TabIndex = 17;
            // 
            // txtPais
            // 
            this.txtPais.BackColor = System.Drawing.Color.White;
            this.txtPais.Location = new System.Drawing.Point(121, 47);
            this.txtPais.MaxLength = 25;
            this.txtPais.Name = "txtPais";
            this.txtPais.ReadOnly = true;
            this.txtPais.Size = new System.Drawing.Size(209, 20);
            this.txtPais.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Departamento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Telefono Alternativo";
            // 
            // txtTelefono2
            // 
            this.txtTelefono2.BackColor = System.Drawing.Color.White;
            this.txtTelefono2.Location = new System.Drawing.Point(121, 159);
            this.txtTelefono2.MaxLength = 25;
            this.txtTelefono2.Name = "txtTelefono2";
            this.txtTelefono2.ReadOnly = true;
            this.txtTelefono2.Size = new System.Drawing.Size(207, 20);
            this.txtTelefono2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre de La Sucursal";
            // 
            // txtNombreSucursal
            // 
            this.txtNombreSucursal.BackColor = System.Drawing.Color.White;
            this.txtNombreSucursal.Location = new System.Drawing.Point(121, 19);
            this.txtNombreSucursal.MaxLength = 50;
            this.txtNombreSucursal.Name = "txtNombreSucursal";
            this.txtNombreSucursal.ReadOnly = true;
            this.txtNombreSucursal.Size = new System.Drawing.Size(207, 20);
            this.txtNombreSucursal.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.Location = new System.Drawing.Point(121, 187);
            this.txtDireccion.MaxLength = 100;
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(243, 40);
            this.txtDireccion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ciudad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pais";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            this.txtTelefono.Location = new System.Drawing.Point(121, 131);
            this.txtTelefono.MaxLength = 25;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(209, 20);
            this.txtTelefono.TabIndex = 2;
            // 
            // btnInfContacto
            // 
            this.btnInfContacto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInfContacto.Image = ((System.Drawing.Image)(resources.GetObject("btnInfContacto.Image")));
            this.btnInfContacto.ImageFixedSize = new System.Drawing.Size(29, 29);
            this.btnInfContacto.Location = new System.Drawing.Point(302, 23);
            this.btnInfContacto.Name = "btnInfContacto";
            this.btnInfContacto.Size = new System.Drawing.Size(33, 33);
            this.btnInfContacto.TabIndex = 85;
            this.btnInfContacto.Click += new System.EventHandler(this.btnInfContacto_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 74);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 84;
            this.label16.Text = "Cliente";
            // 
            // txtNroSocio
            // 
            this.txtNroSocio.BackColor = System.Drawing.Color.White;
            this.txtNroSocio.Location = new System.Drawing.Point(103, 74);
            this.txtNroSocio.MaxLength = 25;
            this.txtNroSocio.Name = "txtNroSocio";
            this.txtNroSocio.ReadOnly = true;
            this.txtNroSocio.Size = new System.Drawing.Size(273, 20);
            this.txtNroSocio.TabIndex = 83;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 82;
            this.label15.Text = "Nit Cliente";
            // 
            // txtNitCliente
            // 
            this.txtNitCliente.BackColor = System.Drawing.Color.White;
            this.txtNitCliente.Location = new System.Drawing.Point(103, 48);
            this.txtNitCliente.MaxLength = 25;
            this.txtNitCliente.Name = "txtNitCliente";
            this.txtNitCliente.ReadOnly = true;
            this.txtNitCliente.Size = new System.Drawing.Size(273, 20);
            this.txtNitCliente.TabIndex = 81;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 80;
            this.label14.Text = "Cliente";
            // 
            // txtcliente
            // 
            this.txtcliente.BackColor = System.Drawing.Color.White;
            this.txtcliente.Location = new System.Drawing.Point(103, 22);
            this.txtcliente.MaxLength = 25;
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.ReadOnly = true;
            this.txtcliente.Size = new System.Drawing.Size(273, 20);
            this.txtcliente.TabIndex = 79;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnInfContacto);
            this.groupBox2.Controls.Add(this.cmbTituloContacto);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cmbTipoDocumento);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtApellidos);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtNombres);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.txtDocumento);
            this.groupBox2.Location = new System.Drawing.Point(393, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 349);
            this.groupBox2.TabIndex = 77;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Contacto de la Sucursal";
            // 
            // cmbTituloContacto
            // 
            this.cmbTituloContacto.DisplayMember = "tituloContacto.tituloContacto";
            this.cmbTituloContacto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTituloContacto.Enabled = false;
            this.cmbTituloContacto.FormattingEnabled = true;
            this.cmbTituloContacto.Location = new System.Drawing.Point(113, 28);
            this.cmbTituloContacto.Name = "cmbTituloContacto";
            this.cmbTituloContacto.Size = new System.Drawing.Size(166, 21);
            this.cmbTituloContacto.TabIndex = 62;
            this.cmbTituloContacto.ValueMember = "tituloContacto.codTituloContacto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Nombres Contacto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Apellidos Contacto";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "Tipo Documento";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DisplayMember = "tipoDocumento.nombreTipoDoc";
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.Enabled = false;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(112, 121);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(166, 21);
            this.cmbTipoDocumento.TabIndex = 43;
            this.cmbTipoDocumento.ValueMember = "tipoDocumento.codTipoDoc";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 157);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 13);
            this.label17.TabIndex = 42;
            this.label17.Text = "Documento";
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.Color.White;
            this.txtApellidos.Location = new System.Drawing.Point(112, 88);
            this.txtApellidos.MaxLength = 20;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ReadOnly = true;
            this.txtApellidos.Size = new System.Drawing.Size(223, 20);
            this.txtApellidos.TabIndex = 40;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "Titulo Contacto";
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.Color.White;
            this.txtNombres.Location = new System.Drawing.Point(112, 62);
            this.txtNombres.MaxLength = 20;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.ReadOnly = true;
            this.txtNombres.Size = new System.Drawing.Size(223, 20);
            this.txtNombres.TabIndex = 38;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.txtFax);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.txtEmail);
            this.groupBox4.Controls.Add(this.txtTelefonoContacto);
            this.groupBox4.Controls.Add(this.txtCelular);
            this.groupBox4.Controls.Add(this.txtTelefonoContactoAlterna);
            this.groupBox4.Location = new System.Drawing.Point(13, 176);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(335, 162);
            this.groupBox4.TabIndex = 76;
            this.groupBox4.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 13);
            this.label19.TabIndex = 47;
            this.label19.Text = "Telefono";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(15, 53);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 13);
            this.label20.TabIndex = 48;
            this.label20.Text = "Telefono Alterno";
            // 
            // txtFax
            // 
            this.txtFax.BackColor = System.Drawing.Color.White;
            this.txtFax.Location = new System.Drawing.Point(124, 134);
            this.txtFax.MaxLength = 25;
            this.txtFax.Name = "txtFax";
            this.txtFax.ReadOnly = true;
            this.txtFax.Size = new System.Drawing.Size(196, 20);
            this.txtFax.TabIndex = 55;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(15, 79);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 13);
            this.label21.TabIndex = 51;
            this.label21.Text = "Celular";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(15, 136);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(24, 13);
            this.label22.TabIndex = 61;
            this.label22.Text = "Fax";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(15, 106);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(32, 13);
            this.label23.TabIndex = 53;
            this.label23.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(124, 106);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(196, 20);
            this.txtEmail.TabIndex = 52;
            // 
            // txtTelefonoContacto
            // 
            this.txtTelefonoContacto.BackColor = System.Drawing.Color.White;
            this.txtTelefonoContacto.Location = new System.Drawing.Point(124, 22);
            this.txtTelefonoContacto.MaxLength = 25;
            this.txtTelefonoContacto.Name = "txtTelefonoContacto";
            this.txtTelefonoContacto.ReadOnly = true;
            this.txtTelefonoContacto.Size = new System.Drawing.Size(196, 20);
            this.txtTelefonoContacto.TabIndex = 46;
            // 
            // txtCelular
            // 
            this.txtCelular.BackColor = System.Drawing.Color.White;
            this.txtCelular.Location = new System.Drawing.Point(124, 78);
            this.txtCelular.MaxLength = 50;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.ReadOnly = true;
            this.txtCelular.Size = new System.Drawing.Size(196, 20);
            this.txtCelular.TabIndex = 50;
            // 
            // txtTelefonoContactoAlterna
            // 
            this.txtTelefonoContactoAlterna.BackColor = System.Drawing.Color.White;
            this.txtTelefonoContactoAlterna.Location = new System.Drawing.Point(124, 50);
            this.txtTelefonoContactoAlterna.MaxLength = 25;
            this.txtTelefonoContactoAlterna.Name = "txtTelefonoContactoAlterna";
            this.txtTelefonoContactoAlterna.ReadOnly = true;
            this.txtTelefonoContactoAlterna.Size = new System.Drawing.Size(196, 20);
            this.txtTelefonoContactoAlterna.TabIndex = 49;
            // 
            // txtDocumento
            // 
            this.txtDocumento.BackColor = System.Drawing.Color.White;
            this.txtDocumento.Location = new System.Drawing.Point(112, 154);
            this.txtDocumento.MaxLength = 15;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.ReadOnly = true;
            this.txtDocumento.Size = new System.Drawing.Size(223, 20);
            this.txtDocumento.TabIndex = 44;
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // sucursalClienteTableAdapter1
            // 
            this.sucursalClienteTableAdapter1.ClearBeforeFill = true;
            // 
            // vistaSucursalTableAdapter1
            // 
            this.vistaSucursalTableAdapter1.ClearBeforeFill = true;
            // 
            // frmInfSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 424);
            this.ControlBox = false;
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtNroSocio);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtNitCliente);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInfSucursal";
            this.Text = "Informacion de Sucursal";
            this.Load += new System.EventHandler(this.frmInfSucursal_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTelefono2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreSucursal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefono;
        private DevComponents.DotNetBar.ButtonX btnInfContacto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNroSocio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNitCliente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbTituloContacto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefonoContacto;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtTelefonoContactoAlterna;
        private System.Windows.Forms.Button btnOk;
        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.contactosClientesTableAdapter contactosClientesTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.tipoDocumentoTableAdapter tipoDocumentoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.tituloContactoTableAdapter tituloContactoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.clientesTableAdapter clientesTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.sucursalClienteTableAdapter sucursalClienteTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.vistaSucursalTableAdapter vistaSucursalTableAdapter1;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.TextBox txtPais;
    }
}