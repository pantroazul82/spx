namespace spHerramientas.tool
{
    partial class frmDefaults
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDefaults));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.cmbDepartamentos = new System.Windows.Forms.ComboBox();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnSubirLogo = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnBajarLogo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTituloOrdenServicio = new System.Windows.Forms.TextBox();
            this.txtVersionOrdenServicio = new System.Windows.Forms.TextBox();
            this.chkPideFechaordenServicio = new System.Windows.Forms.CheckBox();
            this.chkModificarOSSolicitudAbierta = new System.Windows.Forms.CheckBox();
            this.txtVersionRptInsumos = new System.Windows.Forms.TextBox();
            this.txtTituloRptInsumos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVersionOrdenPrestamo = new System.Windows.Forms.TextBox();
            this.txtTituloOrdenPrestamo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVersionReporteServicio = new System.Windows.Forms.TextBox();
            this.txtTituloReporteServicio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.departamentoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.departamentoTableAdapter();
            this.paisesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.paisesTableAdapter();
            this.ciudadesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ciudadesTableAdapter();
            this.defaultsTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter();
            this.txtVersionEntradaSalida = new System.Windows.Forms.TextBox();
            this.txtTituloEntradaSalida = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.nmDias = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.nmMeses = new System.Windows.Forms.NumericUpDown();
            this.txtVersionLlamadas = new System.Windows.Forms.TextBox();
            this.txtTituloLlamadas = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtVersionProgramacionViajes = new System.Windows.Forms.TextBox();
            this.txtTituloViajes = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtVersionSolicitud = new System.Windows.Forms.TextBox();
            this.txtTitulosolicitud = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.calFechaVigenciaOs = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtTipoOrdenServicio = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.calVigenciaES = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtTipoES = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.calVigenciaLLamadas = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtTipoDocumentoLlamadas = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.calVigenciaReporteServicio = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtTipoReporteServicio = new System.Windows.Forms.TextBox();
            this.calVigenciaProgramacion = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.txtTipoProgramacion = new System.Windows.Forms.TextBox();
            this.calVigenciaSolicitud = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.txtTipoSolicitud = new System.Windows.Forms.TextBox();
            this.calVigenciaInsumos = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.txtTipoInsumos = new System.Windows.Forms.TextBox();
            this.calVigenciaOrdenPrestamo = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.txtTipoOrdenPrestamo = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel3 = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem3 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel4 = new DevComponents.DotNetBar.TabControlPanel();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.txtTituloControlCalidad = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.txtVersionControlCalidad = new System.Windows.Forms.TextBox();
            this.calVigenciaControlCalidad = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtTipoDocumentoControlCalidad = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.tabItem4 = new DevComponents.DotNetBar.TabItem(this.components);
            this.label40 = new System.Windows.Forms.Label();
            this.txtNotaPieReportes = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMeses)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaVigenciaOs)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calVigenciaES)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calVigenciaLLamadas)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calVigenciaReporteServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calVigenciaProgramacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calVigenciaSolicitud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calVigenciaInsumos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calVigenciaOrdenPrestamo)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel2.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.tabControlPanel3.SuspendLayout();
            this.tabControlPanel4.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calVigenciaControlCalidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(841, 15);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(922, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbCiudad);
            this.groupBox1.Controls.Add(this.cmbDepartamentos);
            this.groupBox1.Controls.Add(this.cmbPais);
            this.groupBox1.Location = new System.Drawing.Point(26, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 61);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ubicaciones";
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.DataSource = this.dsSpx1;
            this.cmbCiudad.DisplayMember = "ciudades.nombreCiudad";
            this.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(316, 28);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(140, 21);
            this.cmbCiudad.TabIndex = 2;
            this.cmbCiudad.ValueMember = "ciudades.codCiudad";
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.EnforceConstraints = false;
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbDepartamentos
            // 
            this.cmbDepartamentos.DataSource = this.dsSpx1;
            this.cmbDepartamentos.DisplayMember = "departamento.NombreDepartamento";
            this.cmbDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamentos.FormattingEnabled = true;
            this.cmbDepartamentos.Location = new System.Drawing.Point(170, 28);
            this.cmbDepartamentos.Name = "cmbDepartamentos";
            this.cmbDepartamentos.Size = new System.Drawing.Size(140, 21);
            this.cmbDepartamentos.TabIndex = 1;
            this.cmbDepartamentos.ValueMember = "departamento.codDepartamento";
            this.cmbDepartamentos.SelectedIndexChanged += new System.EventHandler(this.cmbDepartamentos_SelectedIndexChanged);
            // 
            // cmbPais
            // 
            this.cmbPais.DataSource = this.dsSpx1;
            this.cmbPais.DisplayMember = "paises.nombrePais";
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(24, 28);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(140, 21);
            this.cmbPais.TabIndex = 0;
            this.cmbPais.ValueMember = "paises.codPais";
            this.cmbPais.SelectedIndexChanged += new System.EventHandler(this.cmbPais_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(702, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Logotipo de la Empresa";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Black;
            this.picLogo.Location = new System.Drawing.Point(705, 39);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(218, 255);
            this.picLogo.TabIndex = 4;
            this.picLogo.TabStop = false;
            // 
            // btnSubirLogo
            // 
            this.btnSubirLogo.Location = new System.Drawing.Point(627, 41);
            this.btnSubirLogo.Name = "btnSubirLogo";
            this.btnSubirLogo.Size = new System.Drawing.Size(75, 23);
            this.btnSubirLogo.TabIndex = 5;
            this.btnSubirLogo.Text = "Subir Logo";
            this.btnSubirLogo.UseVisualStyleBackColor = true;
            this.btnSubirLogo.Click += new System.EventHandler(this.btnSubirLogo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // btnBajarLogo
            // 
            this.btnBajarLogo.Location = new System.Drawing.Point(627, 72);
            this.btnBajarLogo.Name = "btnBajarLogo";
            this.btnBajarLogo.Size = new System.Drawing.Size(75, 23);
            this.btnBajarLogo.TabIndex = 6;
            this.btnBajarLogo.Text = "Bajar Logo";
            this.btnBajarLogo.UseVisualStyleBackColor = true;
            this.btnBajarLogo.Click += new System.EventHandler(this.btnBajarLogo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Version ";
            // 
            // txtTituloOrdenServicio
            // 
            this.txtTituloOrdenServicio.Location = new System.Drawing.Point(6, 66);
            this.txtTituloOrdenServicio.MaxLength = 200;
            this.txtTituloOrdenServicio.Name = "txtTituloOrdenServicio";
            this.txtTituloOrdenServicio.Size = new System.Drawing.Size(423, 20);
            this.txtTituloOrdenServicio.TabIndex = 9;
            // 
            // txtVersionOrdenServicio
            // 
            this.txtVersionOrdenServicio.Location = new System.Drawing.Point(6, 29);
            this.txtVersionOrdenServicio.MaxLength = 20;
            this.txtVersionOrdenServicio.Name = "txtVersionOrdenServicio";
            this.txtVersionOrdenServicio.Size = new System.Drawing.Size(296, 20);
            this.txtVersionOrdenServicio.TabIndex = 10;
            // 
            // chkPideFechaordenServicio
            // 
            this.chkPideFechaordenServicio.AutoSize = true;
            this.chkPideFechaordenServicio.BackColor = System.Drawing.Color.Transparent;
            this.chkPideFechaordenServicio.Location = new System.Drawing.Point(26, 206);
            this.chkPideFechaordenServicio.Name = "chkPideFechaordenServicio";
            this.chkPideFechaordenServicio.Size = new System.Drawing.Size(286, 17);
            this.chkPideFechaordenServicio.TabIndex = 11;
            this.chkPideFechaordenServicio.Text = "Pedir la fecha cuando se termina una orden de servicio";
            this.chkPideFechaordenServicio.UseVisualStyleBackColor = false;
            // 
            // chkModificarOSSolicitudAbierta
            // 
            this.chkModificarOSSolicitudAbierta.BackColor = System.Drawing.Color.Transparent;
            this.chkModificarOSSolicitudAbierta.Location = new System.Drawing.Point(26, 168);
            this.chkModificarOSSolicitudAbierta.Name = "chkModificarOSSolicitudAbierta";
            this.chkModificarOSSolicitudAbierta.Size = new System.Drawing.Size(296, 32);
            this.chkModificarOSSolicitudAbierta.TabIndex = 12;
            this.chkModificarOSSolicitudAbierta.Text = "Permitir Modificar una Orden de Servicio con una solicitud de Insumos abierta";
            this.chkModificarOSSolicitudAbierta.UseVisualStyleBackColor = false;
            // 
            // txtVersionRptInsumos
            // 
            this.txtVersionRptInsumos.Location = new System.Drawing.Point(6, 30);
            this.txtVersionRptInsumos.MaxLength = 20;
            this.txtVersionRptInsumos.Name = "txtVersionRptInsumos";
            this.txtVersionRptInsumos.Size = new System.Drawing.Size(296, 20);
            this.txtVersionRptInsumos.TabIndex = 16;
            // 
            // txtTituloRptInsumos
            // 
            this.txtTituloRptInsumos.Location = new System.Drawing.Point(9, 63);
            this.txtTituloRptInsumos.MaxLength = 200;
            this.txtTituloRptInsumos.Name = "txtTituloRptInsumos";
            this.txtTituloRptInsumos.Size = new System.Drawing.Size(523, 20);
            this.txtTituloRptInsumos.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Version ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Titulo ";
            // 
            // txtVersionOrdenPrestamo
            // 
            this.txtVersionOrdenPrestamo.Location = new System.Drawing.Point(9, 30);
            this.txtVersionOrdenPrestamo.MaxLength = 20;
            this.txtVersionOrdenPrestamo.Name = "txtVersionOrdenPrestamo";
            this.txtVersionOrdenPrestamo.Size = new System.Drawing.Size(296, 20);
            this.txtVersionOrdenPrestamo.TabIndex = 20;
            // 
            // txtTituloOrdenPrestamo
            // 
            this.txtTituloOrdenPrestamo.Location = new System.Drawing.Point(9, 60);
            this.txtTituloOrdenPrestamo.MaxLength = 200;
            this.txtTituloOrdenPrestamo.Name = "txtTituloOrdenPrestamo";
            this.txtTituloOrdenPrestamo.Size = new System.Drawing.Size(523, 20);
            this.txtTituloOrdenPrestamo.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Version";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Titulo ";
            // 
            // txtVersionReporteServicio
            // 
            this.txtVersionReporteServicio.Location = new System.Drawing.Point(9, 66);
            this.txtVersionReporteServicio.MaxLength = 20;
            this.txtVersionReporteServicio.Name = "txtVersionReporteServicio";
            this.txtVersionReporteServicio.Size = new System.Drawing.Size(296, 20);
            this.txtVersionReporteServicio.TabIndex = 24;
            // 
            // txtTituloReporteServicio
            // 
            this.txtTituloReporteServicio.Location = new System.Drawing.Point(9, 33);
            this.txtTituloReporteServicio.MaxLength = 200;
            this.txtTituloReporteServicio.Name = "txtTituloReporteServicio";
            this.txtTituloReporteServicio.Size = new System.Drawing.Size(296, 20);
            this.txtTituloReporteServicio.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Version";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Titulo ";
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
            // defaultsTableAdapter1
            // 
            this.defaultsTableAdapter1.ClearBeforeFill = true;
            // 
            // txtVersionEntradaSalida
            // 
            this.txtVersionEntradaSalida.Location = new System.Drawing.Point(9, 62);
            this.txtVersionEntradaSalida.MaxLength = 20;
            this.txtVersionEntradaSalida.Name = "txtVersionEntradaSalida";
            this.txtVersionEntradaSalida.Size = new System.Drawing.Size(296, 20);
            this.txtVersionEntradaSalida.TabIndex = 28;
            // 
            // txtTituloEntradaSalida
            // 
            this.txtTituloEntradaSalida.Location = new System.Drawing.Point(9, 29);
            this.txtTituloEntradaSalida.MaxLength = 200;
            this.txtTituloEntradaSalida.Name = "txtTituloEntradaSalida";
            this.txtTituloEntradaSalida.Size = new System.Drawing.Size(296, 20);
            this.txtTituloEntradaSalida.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Version";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Titulo";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.nmDias);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.nmMeses);
            this.groupBox2.Location = new System.Drawing.Point(26, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 45);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Periodo por defecto para mantenimientos preventivos";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(305, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Dias";
            // 
            // nmDias
            // 
            this.nmDias.Location = new System.Drawing.Point(241, 19);
            this.nmDias.Name = "nmDias";
            this.nmDias.Size = new System.Drawing.Size(48, 20);
            this.nmDias.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(185, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Meses";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nmMeses
            // 
            this.nmMeses.Location = new System.Drawing.Point(131, 19);
            this.nmMeses.Name = "nmMeses";
            this.nmMeses.Size = new System.Drawing.Size(48, 20);
            this.nmMeses.TabIndex = 0;
            // 
            // txtVersionLlamadas
            // 
            this.txtVersionLlamadas.Location = new System.Drawing.Point(6, 33);
            this.txtVersionLlamadas.MaxLength = 20;
            this.txtVersionLlamadas.Name = "txtVersionLlamadas";
            this.txtVersionLlamadas.Size = new System.Drawing.Size(296, 20);
            this.txtVersionLlamadas.TabIndex = 33;
            // 
            // txtTituloLlamadas
            // 
            this.txtTituloLlamadas.Location = new System.Drawing.Point(9, 67);
            this.txtTituloLlamadas.MaxLength = 200;
            this.txtTituloLlamadas.Name = "txtTituloLlamadas";
            this.txtTituloLlamadas.Size = new System.Drawing.Size(423, 20);
            this.txtTituloLlamadas.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Version";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Titulo ";
            // 
            // txtVersionProgramacionViajes
            // 
            this.txtVersionProgramacionViajes.Location = new System.Drawing.Point(14, 30);
            this.txtVersionProgramacionViajes.MaxLength = 20;
            this.txtVersionProgramacionViajes.Name = "txtVersionProgramacionViajes";
            this.txtVersionProgramacionViajes.Size = new System.Drawing.Size(296, 20);
            this.txtVersionProgramacionViajes.TabIndex = 37;
            // 
            // txtTituloViajes
            // 
            this.txtTituloViajes.Location = new System.Drawing.Point(14, 65);
            this.txtTituloViajes.MaxLength = 200;
            this.txtTituloViajes.Name = "txtTituloViajes";
            this.txtTituloViajes.Size = new System.Drawing.Size(518, 20);
            this.txtTituloViajes.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Version ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 52);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Titulo";
            // 
            // txtVersionSolicitud
            // 
            this.txtVersionSolicitud.Location = new System.Drawing.Point(9, 36);
            this.txtVersionSolicitud.MaxLength = 20;
            this.txtVersionSolicitud.Name = "txtVersionSolicitud";
            this.txtVersionSolicitud.Size = new System.Drawing.Size(296, 20);
            this.txtVersionSolicitud.TabIndex = 41;
            // 
            // txtTitulosolicitud
            // 
            this.txtTitulosolicitud.Location = new System.Drawing.Point(9, 73);
            this.txtTitulosolicitud.MaxLength = 200;
            this.txtTitulosolicitud.Name = "txtTitulosolicitud";
            this.txtTitulosolicitud.Size = new System.Drawing.Size(420, 20);
            this.txtTitulosolicitud.TabIndex = 40;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 13);
            this.label18.TabIndex = 39;
            this.label18.Text = "Version ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 59);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 13);
            this.label19.TabIndex = 38;
            this.label19.Text = "Titulo ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 490);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 50);
            this.panel1.TabIndex = 42;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.calFechaVigenciaOs);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.txtTipoOrdenServicio);
            this.groupBox3.Controls.Add(this.txtVersionOrdenServicio);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtTituloOrdenServicio);
            this.groupBox3.Location = new System.Drawing.Point(23, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(556, 130);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Formato Orden Servicio";
            // 
            // calFechaVigenciaOs
            // 
            // 
            // 
            // 
            this.calFechaVigenciaOs.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calFechaVigenciaOs.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaVigenciaOs.ButtonDropDown.Visible = true;
            this.calFechaVigenciaOs.Location = new System.Drawing.Point(324, 29);
            // 
            // 
            // 
            this.calFechaVigenciaOs.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFechaVigenciaOs.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calFechaVigenciaOs.MonthCalendar.BackgroundStyle.Class = "";
            this.calFechaVigenciaOs.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaVigenciaOs.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calFechaVigenciaOs.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calFechaVigenciaOs.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calFechaVigenciaOs.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calFechaVigenciaOs.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calFechaVigenciaOs.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calFechaVigenciaOs.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calFechaVigenciaOs.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calFechaVigenciaOs.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaVigenciaOs.MonthCalendar.DisplayMonth = new System.DateTime(2009, 8, 1, 0, 0, 0, 0);
            this.calFechaVigenciaOs.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calFechaVigenciaOs.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calFechaVigenciaOs.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFechaVigenciaOs.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calFechaVigenciaOs.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calFechaVigenciaOs.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calFechaVigenciaOs.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calFechaVigenciaOs.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaVigenciaOs.MonthCalendar.TodayButtonVisible = true;
            this.calFechaVigenciaOs.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calFechaVigenciaOs.Name = "calFechaVigenciaOs";
            this.calFechaVigenciaOs.Size = new System.Drawing.Size(200, 20);
            this.calFechaVigenciaOs.TabIndex = 14;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 91);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(101, 13);
            this.label20.TabIndex = 11;
            this.label20.Text = "Tipo de Documento";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(324, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(81, 13);
            this.label21.TabIndex = 12;
            this.label21.Text = "Fecha Vigencia";
            // 
            // txtTipoOrdenServicio
            // 
            this.txtTipoOrdenServicio.Location = new System.Drawing.Point(9, 104);
            this.txtTipoOrdenServicio.MaxLength = 20;
            this.txtTipoOrdenServicio.Name = "txtTipoOrdenServicio";
            this.txtTipoOrdenServicio.Size = new System.Drawing.Size(423, 20);
            this.txtTipoOrdenServicio.TabIndex = 13;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.calVigenciaES);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.txtTipoES);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtTituloEntradaSalida);
            this.groupBox4.Controls.Add(this.txtVersionEntradaSalida);
            this.groupBox4.Location = new System.Drawing.Point(585, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(412, 163);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Formato Registro Entrada y Salida de Equipos";
            // 
            // calVigenciaES
            // 
            // 
            // 
            // 
            this.calVigenciaES.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calVigenciaES.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaES.ButtonDropDown.Visible = true;
            this.calVigenciaES.Location = new System.Drawing.Point(9, 128);
            // 
            // 
            // 
            this.calVigenciaES.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calVigenciaES.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calVigenciaES.MonthCalendar.BackgroundStyle.Class = "";
            this.calVigenciaES.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaES.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calVigenciaES.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calVigenciaES.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calVigenciaES.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calVigenciaES.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calVigenciaES.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calVigenciaES.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calVigenciaES.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calVigenciaES.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaES.MonthCalendar.DisplayMonth = new System.DateTime(2009, 8, 1, 0, 0, 0, 0);
            this.calVigenciaES.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calVigenciaES.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calVigenciaES.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calVigenciaES.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calVigenciaES.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calVigenciaES.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calVigenciaES.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calVigenciaES.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaES.MonthCalendar.TodayButtonVisible = true;
            this.calVigenciaES.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calVigenciaES.Name = "calVigenciaES";
            this.calVigenciaES.Size = new System.Drawing.Size(200, 20);
            this.calVigenciaES.TabIndex = 32;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(9, 82);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(101, 13);
            this.label24.TabIndex = 29;
            this.label24.Text = "Tipo de Documento";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(9, 115);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(81, 13);
            this.label25.TabIndex = 30;
            this.label25.Text = "Fecha Vigencia";
            // 
            // txtTipoES
            // 
            this.txtTipoES.Location = new System.Drawing.Point(9, 95);
            this.txtTipoES.MaxLength = 20;
            this.txtTipoES.Name = "txtTipoES";
            this.txtTipoES.Size = new System.Drawing.Size(296, 20);
            this.txtTipoES.TabIndex = 31;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.calVigenciaLLamadas);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.txtTipoDocumentoLlamadas);
            this.groupBox5.Controls.Add(this.txtVersionLlamadas);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.txtTituloLlamadas);
            this.groupBox5.Location = new System.Drawing.Point(23, 290);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(556, 138);
            this.groupBox5.TabIndex = 45;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Formato Reporte Llamadas Tecnicas";
            // 
            // calVigenciaLLamadas
            // 
            // 
            // 
            // 
            this.calVigenciaLLamadas.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calVigenciaLLamadas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaLLamadas.ButtonDropDown.Visible = true;
            this.calVigenciaLLamadas.Location = new System.Drawing.Point(327, 33);
            // 
            // 
            // 
            this.calVigenciaLLamadas.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calVigenciaLLamadas.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calVigenciaLLamadas.MonthCalendar.BackgroundStyle.Class = "";
            this.calVigenciaLLamadas.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaLLamadas.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calVigenciaLLamadas.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calVigenciaLLamadas.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calVigenciaLLamadas.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calVigenciaLLamadas.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calVigenciaLLamadas.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calVigenciaLLamadas.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calVigenciaLLamadas.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calVigenciaLLamadas.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaLLamadas.MonthCalendar.DisplayMonth = new System.DateTime(2009, 8, 1, 0, 0, 0, 0);
            this.calVigenciaLLamadas.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calVigenciaLLamadas.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calVigenciaLLamadas.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calVigenciaLLamadas.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calVigenciaLLamadas.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calVigenciaLLamadas.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calVigenciaLLamadas.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calVigenciaLLamadas.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaLLamadas.MonthCalendar.TodayButtonVisible = true;
            this.calVigenciaLLamadas.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calVigenciaLLamadas.Name = "calVigenciaLLamadas";
            this.calVigenciaLLamadas.Size = new System.Drawing.Size(200, 20);
            this.calVigenciaLLamadas.TabIndex = 37;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 90);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(101, 13);
            this.label26.TabIndex = 34;
            this.label26.Text = "Tipo de Documento";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(327, 20);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(81, 13);
            this.label27.TabIndex = 35;
            this.label27.Text = "Fecha Vigencia";
            // 
            // txtTipoDocumentoLlamadas
            // 
            this.txtTipoDocumentoLlamadas.Location = new System.Drawing.Point(6, 103);
            this.txtTipoDocumentoLlamadas.MaxLength = 20;
            this.txtTipoDocumentoLlamadas.Name = "txtTipoDocumentoLlamadas";
            this.txtTipoDocumentoLlamadas.Size = new System.Drawing.Size(423, 20);
            this.txtTipoDocumentoLlamadas.TabIndex = 36;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.calVigenciaReporteServicio);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.txtTipoReporteServicio);
            this.groupBox6.Controls.Add(this.txtVersionReporteServicio);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.txtTituloReporteServicio);
            this.groupBox6.Location = new System.Drawing.Point(585, 181);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(412, 163);
            this.groupBox6.TabIndex = 46;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Formato Reporte de Servicio";
            // 
            // calVigenciaReporteServicio
            // 
            // 
            // 
            // 
            this.calVigenciaReporteServicio.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calVigenciaReporteServicio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaReporteServicio.ButtonDropDown.Visible = true;
            this.calVigenciaReporteServicio.Location = new System.Drawing.Point(9, 132);
            // 
            // 
            // 
            this.calVigenciaReporteServicio.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calVigenciaReporteServicio.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calVigenciaReporteServicio.MonthCalendar.BackgroundStyle.Class = "";
            this.calVigenciaReporteServicio.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaReporteServicio.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calVigenciaReporteServicio.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calVigenciaReporteServicio.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calVigenciaReporteServicio.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calVigenciaReporteServicio.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calVigenciaReporteServicio.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calVigenciaReporteServicio.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calVigenciaReporteServicio.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calVigenciaReporteServicio.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaReporteServicio.MonthCalendar.DisplayMonth = new System.DateTime(2009, 8, 1, 0, 0, 0, 0);
            this.calVigenciaReporteServicio.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calVigenciaReporteServicio.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calVigenciaReporteServicio.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calVigenciaReporteServicio.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calVigenciaReporteServicio.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calVigenciaReporteServicio.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calVigenciaReporteServicio.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calVigenciaReporteServicio.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaReporteServicio.MonthCalendar.TodayButtonVisible = true;
            this.calVigenciaReporteServicio.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calVigenciaReporteServicio.Name = "calVigenciaReporteServicio";
            this.calVigenciaReporteServicio.Size = new System.Drawing.Size(200, 20);
            this.calVigenciaReporteServicio.TabIndex = 28;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 86);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(101, 13);
            this.label22.TabIndex = 25;
            this.label22.Text = "Tipo de Documento";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(9, 119);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(81, 13);
            this.label23.TabIndex = 26;
            this.label23.Text = "Fecha Vigencia";
            // 
            // txtTipoReporteServicio
            // 
            this.txtTipoReporteServicio.Location = new System.Drawing.Point(9, 99);
            this.txtTipoReporteServicio.MaxLength = 20;
            this.txtTipoReporteServicio.Name = "txtTipoReporteServicio";
            this.txtTipoReporteServicio.Size = new System.Drawing.Size(296, 20);
            this.txtTipoReporteServicio.TabIndex = 27;
            // 
            // calVigenciaProgramacion
            // 
            // 
            // 
            // 
            this.calVigenciaProgramacion.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calVigenciaProgramacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaProgramacion.ButtonDropDown.Visible = true;
            this.calVigenciaProgramacion.Location = new System.Drawing.Point(332, 30);
            // 
            // 
            // 
            this.calVigenciaProgramacion.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calVigenciaProgramacion.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calVigenciaProgramacion.MonthCalendar.BackgroundStyle.Class = "";
            this.calVigenciaProgramacion.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaProgramacion.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calVigenciaProgramacion.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calVigenciaProgramacion.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calVigenciaProgramacion.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calVigenciaProgramacion.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calVigenciaProgramacion.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calVigenciaProgramacion.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calVigenciaProgramacion.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calVigenciaProgramacion.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaProgramacion.MonthCalendar.DisplayMonth = new System.DateTime(2009, 8, 1, 0, 0, 0, 0);
            this.calVigenciaProgramacion.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calVigenciaProgramacion.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calVigenciaProgramacion.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calVigenciaProgramacion.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calVigenciaProgramacion.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calVigenciaProgramacion.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calVigenciaProgramacion.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calVigenciaProgramacion.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaProgramacion.MonthCalendar.TodayButtonVisible = true;
            this.calVigenciaProgramacion.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calVigenciaProgramacion.Name = "calVigenciaProgramacion";
            this.calVigenciaProgramacion.Size = new System.Drawing.Size(200, 20);
            this.calVigenciaProgramacion.TabIndex = 50;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(14, 88);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(101, 13);
            this.label28.TabIndex = 47;
            this.label28.Text = "Tipo de Documento";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(332, 17);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(81, 13);
            this.label29.TabIndex = 48;
            this.label29.Text = "Fecha Vigencia";
            // 
            // txtTipoProgramacion
            // 
            this.txtTipoProgramacion.Location = new System.Drawing.Point(14, 101);
            this.txtTipoProgramacion.MaxLength = 20;
            this.txtTipoProgramacion.Name = "txtTipoProgramacion";
            this.txtTipoProgramacion.Size = new System.Drawing.Size(518, 20);
            this.txtTipoProgramacion.TabIndex = 49;
            // 
            // calVigenciaSolicitud
            // 
            // 
            // 
            // 
            this.calVigenciaSolicitud.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calVigenciaSolicitud.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaSolicitud.ButtonDropDown.Visible = true;
            this.calVigenciaSolicitud.Location = new System.Drawing.Point(324, 36);
            // 
            // 
            // 
            this.calVigenciaSolicitud.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calVigenciaSolicitud.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calVigenciaSolicitud.MonthCalendar.BackgroundStyle.Class = "";
            this.calVigenciaSolicitud.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaSolicitud.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calVigenciaSolicitud.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calVigenciaSolicitud.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calVigenciaSolicitud.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calVigenciaSolicitud.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calVigenciaSolicitud.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calVigenciaSolicitud.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calVigenciaSolicitud.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calVigenciaSolicitud.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaSolicitud.MonthCalendar.DisplayMonth = new System.DateTime(2009, 8, 1, 0, 0, 0, 0);
            this.calVigenciaSolicitud.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calVigenciaSolicitud.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calVigenciaSolicitud.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calVigenciaSolicitud.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calVigenciaSolicitud.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calVigenciaSolicitud.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calVigenciaSolicitud.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calVigenciaSolicitud.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaSolicitud.MonthCalendar.TodayButtonVisible = true;
            this.calVigenciaSolicitud.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calVigenciaSolicitud.Name = "calVigenciaSolicitud";
            this.calVigenciaSolicitud.Size = new System.Drawing.Size(200, 20);
            this.calVigenciaSolicitud.TabIndex = 54;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 99);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(101, 13);
            this.label30.TabIndex = 51;
            this.label30.Text = "Tipo de Documento";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(324, 20);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(81, 13);
            this.label31.TabIndex = 52;
            this.label31.Text = "Fecha Vigencia";
            // 
            // txtTipoSolicitud
            // 
            this.txtTipoSolicitud.Location = new System.Drawing.Point(9, 112);
            this.txtTipoSolicitud.MaxLength = 20;
            this.txtTipoSolicitud.Name = "txtTipoSolicitud";
            this.txtTipoSolicitud.Size = new System.Drawing.Size(420, 20);
            this.txtTipoSolicitud.TabIndex = 53;
            // 
            // calVigenciaInsumos
            // 
            // 
            // 
            // 
            this.calVigenciaInsumos.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calVigenciaInsumos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaInsumos.ButtonDropDown.Visible = true;
            this.calVigenciaInsumos.Location = new System.Drawing.Point(335, 30);
            // 
            // 
            // 
            this.calVigenciaInsumos.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calVigenciaInsumos.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calVigenciaInsumos.MonthCalendar.BackgroundStyle.Class = "";
            this.calVigenciaInsumos.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaInsumos.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calVigenciaInsumos.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calVigenciaInsumos.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calVigenciaInsumos.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calVigenciaInsumos.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calVigenciaInsumos.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calVigenciaInsumos.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calVigenciaInsumos.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calVigenciaInsumos.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaInsumos.MonthCalendar.DisplayMonth = new System.DateTime(2009, 8, 1, 0, 0, 0, 0);
            this.calVigenciaInsumos.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calVigenciaInsumos.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calVigenciaInsumos.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calVigenciaInsumos.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calVigenciaInsumos.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calVigenciaInsumos.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calVigenciaInsumos.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calVigenciaInsumos.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaInsumos.MonthCalendar.TodayButtonVisible = true;
            this.calVigenciaInsumos.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calVigenciaInsumos.Name = "calVigenciaInsumos";
            this.calVigenciaInsumos.Size = new System.Drawing.Size(200, 20);
            this.calVigenciaInsumos.TabIndex = 58;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(9, 84);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(101, 13);
            this.label32.TabIndex = 55;
            this.label32.Text = "Tipo de Documento";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(335, 17);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(81, 13);
            this.label33.TabIndex = 56;
            this.label33.Text = "Fecha Vigencia";
            // 
            // txtTipoInsumos
            // 
            this.txtTipoInsumos.Location = new System.Drawing.Point(9, 97);
            this.txtTipoInsumos.MaxLength = 20;
            this.txtTipoInsumos.Name = "txtTipoInsumos";
            this.txtTipoInsumos.Size = new System.Drawing.Size(523, 20);
            this.txtTipoInsumos.TabIndex = 57;
            // 
            // calVigenciaOrdenPrestamo
            // 
            // 
            // 
            // 
            this.calVigenciaOrdenPrestamo.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calVigenciaOrdenPrestamo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaOrdenPrestamo.ButtonDropDown.Visible = true;
            this.calVigenciaOrdenPrestamo.Location = new System.Drawing.Point(332, 30);
            // 
            // 
            // 
            this.calVigenciaOrdenPrestamo.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calVigenciaOrdenPrestamo.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calVigenciaOrdenPrestamo.MonthCalendar.BackgroundStyle.Class = "";
            this.calVigenciaOrdenPrestamo.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaOrdenPrestamo.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calVigenciaOrdenPrestamo.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calVigenciaOrdenPrestamo.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calVigenciaOrdenPrestamo.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calVigenciaOrdenPrestamo.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calVigenciaOrdenPrestamo.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calVigenciaOrdenPrestamo.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calVigenciaOrdenPrestamo.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calVigenciaOrdenPrestamo.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaOrdenPrestamo.MonthCalendar.DisplayMonth = new System.DateTime(2009, 8, 1, 0, 0, 0, 0);
            this.calVigenciaOrdenPrestamo.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calVigenciaOrdenPrestamo.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calVigenciaOrdenPrestamo.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calVigenciaOrdenPrestamo.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calVigenciaOrdenPrestamo.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calVigenciaOrdenPrestamo.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calVigenciaOrdenPrestamo.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calVigenciaOrdenPrestamo.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaOrdenPrestamo.MonthCalendar.TodayButtonVisible = true;
            this.calVigenciaOrdenPrestamo.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calVigenciaOrdenPrestamo.Name = "calVigenciaOrdenPrestamo";
            this.calVigenciaOrdenPrestamo.Size = new System.Drawing.Size(200, 20);
            this.calVigenciaOrdenPrestamo.TabIndex = 62;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(9, 83);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(101, 13);
            this.label34.TabIndex = 59;
            this.label34.Text = "Tipo de Documento";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(332, 17);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(81, 13);
            this.label35.TabIndex = 60;
            this.label35.Text = "Fecha Vigencia";
            // 
            // txtTipoOrdenPrestamo
            // 
            this.txtTipoOrdenPrestamo.Location = new System.Drawing.Point(9, 96);
            this.txtTipoOrdenPrestamo.MaxLength = 20;
            this.txtTipoOrdenPrestamo.Name = "txtTipoOrdenPrestamo";
            this.txtTipoOrdenPrestamo.Size = new System.Drawing.Size(523, 20);
            this.txtTipoOrdenPrestamo.TabIndex = 61;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.txtTituloOrdenPrestamo);
            this.groupBox7.Controls.Add(this.txtVersionOrdenPrestamo);
            this.groupBox7.Controls.Add(this.calVigenciaOrdenPrestamo);
            this.groupBox7.Controls.Add(this.txtTipoOrdenPrestamo);
            this.groupBox7.Controls.Add(this.label34);
            this.groupBox7.Controls.Add(this.label35);
            this.groupBox7.Location = new System.Drawing.Point(12, 277);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(572, 130);
            this.groupBox7.TabIndex = 63;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Formato Orden de Prestamo";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Controls.Add(this.txtTituloRptInsumos);
            this.groupBox8.Controls.Add(this.txtVersionRptInsumos);
            this.groupBox8.Controls.Add(this.txtTipoInsumos);
            this.groupBox8.Controls.Add(this.label33);
            this.groupBox8.Controls.Add(this.label32);
            this.groupBox8.Controls.Add(this.calVigenciaInsumos);
            this.groupBox8.Location = new System.Drawing.Point(12, 141);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(572, 130);
            this.groupBox8.TabIndex = 64;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Formato Insumos";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtTituloViajes);
            this.groupBox9.Controls.Add(this.label17);
            this.groupBox9.Controls.Add(this.label16);
            this.groupBox9.Controls.Add(this.txtVersionProgramacionViajes);
            this.groupBox9.Controls.Add(this.calVigenciaProgramacion);
            this.groupBox9.Controls.Add(this.txtTipoProgramacion);
            this.groupBox9.Controls.Add(this.label28);
            this.groupBox9.Controls.Add(this.label29);
            this.groupBox9.Location = new System.Drawing.Point(12, 4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(572, 130);
            this.groupBox9.TabIndex = 65;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Formato Programacion de Viajes";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.calVigenciaSolicitud);
            this.groupBox10.Controls.Add(this.label19);
            this.groupBox10.Controls.Add(this.label18);
            this.groupBox10.Controls.Add(this.txtTitulosolicitud);
            this.groupBox10.Controls.Add(this.txtVersionSolicitud);
            this.groupBox10.Controls.Add(this.label30);
            this.groupBox10.Controls.Add(this.txtTipoSolicitud);
            this.groupBox10.Controls.Add(this.label31);
            this.groupBox10.Location = new System.Drawing.Point(23, 145);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(556, 139);
            this.groupBox10.TabIndex = 66;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Formato Solicitud de Servicio";
            // 
            // tabControl1
            // 
            this.tabControl1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanel2);
            this.tabControl1.Controls.Add(this.tabControlPanel3);
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Controls.Add(this.tabControlPanel4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1018, 490);
            this.tabControl1.TabIndex = 67;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItem2);
            this.tabControl1.Tabs.Add(this.tabItem1);
            this.tabControl1.Tabs.Add(this.tabItem3);
            this.tabControl1.Tabs.Add(this.tabItem4);
            this.tabControl1.Text = "Formatos Cientifica";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.picLogo);
            this.tabControlPanel2.Controls.Add(this.label1);
            this.tabControlPanel2.Controls.Add(this.btnSubirLogo);
            this.tabControlPanel2.Controls.Add(this.btnBajarLogo);
            this.tabControlPanel2.Controls.Add(this.groupBox2);
            this.tabControlPanel2.Controls.Add(this.groupBox1);
            this.tabControlPanel2.Controls.Add(this.chkPideFechaordenServicio);
            this.tabControlPanel2.Controls.Add(this.chkModificarOSSolicitudAbierta);
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(1018, 464);
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
            this.tabItem2.Text = "Valores por Defecto";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.groupBox3);
            this.tabControlPanel1.Controls.Add(this.groupBox10);
            this.tabControlPanel1.Controls.Add(this.groupBox6);
            this.tabControlPanel1.Controls.Add(this.groupBox4);
            this.tabControlPanel1.Controls.Add(this.groupBox5);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(1018, 464);
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
            this.tabItem1.Text = "Formatos Impresion 1";
            // 
            // tabControlPanel3
            // 
            this.tabControlPanel3.Controls.Add(this.txtNotaPieReportes);
            this.tabControlPanel3.Controls.Add(this.label40);
            this.tabControlPanel3.Controls.Add(this.groupBox9);
            this.tabControlPanel3.Controls.Add(this.groupBox8);
            this.tabControlPanel3.Controls.Add(this.groupBox7);
            this.tabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel3.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel3.Name = "tabControlPanel3";
            this.tabControlPanel3.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel3.Size = new System.Drawing.Size(1018, 464);
            this.tabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel3.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel3.Style.GradientAngle = 90;
            this.tabControlPanel3.TabIndex = 3;
            this.tabControlPanel3.TabItem = this.tabItem3;
            // 
            // tabItem3
            // 
            this.tabItem3.AttachedControl = this.tabControlPanel3;
            this.tabItem3.Name = "tabItem3";
            this.tabItem3.Text = "Formatos Impresion 2";
            // 
            // tabControlPanel4
            // 
            this.tabControlPanel4.Controls.Add(this.groupBox11);
            this.tabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel4.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel4.Name = "tabControlPanel4";
            this.tabControlPanel4.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel4.Size = new System.Drawing.Size(1018, 464);
            this.tabControlPanel4.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel4.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel4.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel4.Style.GradientAngle = 90;
            this.tabControlPanel4.TabIndex = 4;
            this.tabControlPanel4.TabItem = this.tabItem4;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.txtTituloControlCalidad);
            this.groupBox11.Controls.Add(this.label36);
            this.groupBox11.Controls.Add(this.label37);
            this.groupBox11.Controls.Add(this.txtVersionControlCalidad);
            this.groupBox11.Controls.Add(this.calVigenciaControlCalidad);
            this.groupBox11.Controls.Add(this.txtTipoDocumentoControlCalidad);
            this.groupBox11.Controls.Add(this.label38);
            this.groupBox11.Controls.Add(this.label39);
            this.groupBox11.Location = new System.Drawing.Point(12, 13);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(572, 130);
            this.groupBox11.TabIndex = 66;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Formato Control Calidad";
            // 
            // txtTituloControlCalidad
            // 
            this.txtTituloControlCalidad.Location = new System.Drawing.Point(14, 65);
            this.txtTituloControlCalidad.MaxLength = 200;
            this.txtTituloControlCalidad.Name = "txtTituloControlCalidad";
            this.txtTituloControlCalidad.Size = new System.Drawing.Size(518, 20);
            this.txtTituloControlCalidad.TabIndex = 36;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(14, 52);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(33, 13);
            this.label36.TabIndex = 34;
            this.label36.Text = "Titulo";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(9, 16);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(45, 13);
            this.label37.TabIndex = 35;
            this.label37.Text = "Version ";
            // 
            // txtVersionControlCalidad
            // 
            this.txtVersionControlCalidad.Location = new System.Drawing.Point(14, 30);
            this.txtVersionControlCalidad.MaxLength = 20;
            this.txtVersionControlCalidad.Name = "txtVersionControlCalidad";
            this.txtVersionControlCalidad.Size = new System.Drawing.Size(296, 20);
            this.txtVersionControlCalidad.TabIndex = 37;
            // 
            // calVigenciaControlCalidad
            // 
            // 
            // 
            // 
            this.calVigenciaControlCalidad.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calVigenciaControlCalidad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaControlCalidad.ButtonDropDown.Visible = true;
            this.calVigenciaControlCalidad.Location = new System.Drawing.Point(332, 30);
            // 
            // 
            // 
            this.calVigenciaControlCalidad.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calVigenciaControlCalidad.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calVigenciaControlCalidad.MonthCalendar.BackgroundStyle.Class = "";
            this.calVigenciaControlCalidad.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaControlCalidad.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calVigenciaControlCalidad.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calVigenciaControlCalidad.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calVigenciaControlCalidad.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calVigenciaControlCalidad.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calVigenciaControlCalidad.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calVigenciaControlCalidad.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calVigenciaControlCalidad.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calVigenciaControlCalidad.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaControlCalidad.MonthCalendar.DisplayMonth = new System.DateTime(2009, 8, 1, 0, 0, 0, 0);
            this.calVigenciaControlCalidad.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calVigenciaControlCalidad.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calVigenciaControlCalidad.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calVigenciaControlCalidad.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calVigenciaControlCalidad.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calVigenciaControlCalidad.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calVigenciaControlCalidad.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calVigenciaControlCalidad.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calVigenciaControlCalidad.MonthCalendar.TodayButtonVisible = true;
            this.calVigenciaControlCalidad.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calVigenciaControlCalidad.Name = "calVigenciaControlCalidad";
            this.calVigenciaControlCalidad.Size = new System.Drawing.Size(200, 20);
            this.calVigenciaControlCalidad.TabIndex = 50;
            // 
            // txtTipoDocumentoControlCalidad
            // 
            this.txtTipoDocumentoControlCalidad.Location = new System.Drawing.Point(14, 101);
            this.txtTipoDocumentoControlCalidad.MaxLength = 20;
            this.txtTipoDocumentoControlCalidad.Name = "txtTipoDocumentoControlCalidad";
            this.txtTipoDocumentoControlCalidad.Size = new System.Drawing.Size(518, 20);
            this.txtTipoDocumentoControlCalidad.TabIndex = 49;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(14, 88);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(101, 13);
            this.label38.TabIndex = 47;
            this.label38.Text = "Tipo de Documento";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(332, 17);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(81, 13);
            this.label39.TabIndex = 48;
            this.label39.Text = "Fecha Vigencia";
            // 
            // tabItem4
            // 
            this.tabItem4.AttachedControl = this.tabControlPanel4;
            this.tabItem4.Name = "tabItem4";
            this.tabItem4.Text = "Formatos Cientifica";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(611, 21);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(102, 13);
            this.label40.TabIndex = 66;
            this.label40.Text = "Nota pie Reportes 1";
            // 
            // txtNotaPieReportes
            // 
            this.txtNotaPieReportes.Location = new System.Drawing.Point(614, 43);
            this.txtNotaPieReportes.Multiline = true;
            this.txtNotaPieReportes.Name = "txtNotaPieReportes";
            this.txtNotaPieReportes.Size = new System.Drawing.Size(358, 82);
            this.txtNotaPieReportes.TabIndex = 67;
            // 
            // frmDefaults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1018, 540);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDefaults";
            this.Text = "Defaults";
            this.Load += new System.EventHandler(this.frmDefaults_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMeses)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaVigenciaOs)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calVigenciaES)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calVigenciaLLamadas)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calVigenciaReporteServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calVigenciaProgramacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calVigenciaSolicitud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calVigenciaInsumos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calVigenciaOrdenPrestamo)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel2.ResumeLayout(false);
            this.tabControlPanel2.PerformLayout();
            this.tabControlPanel1.ResumeLayout(false);
            this.tabControlPanel3.ResumeLayout(false);
            this.tabControlPanel3.PerformLayout();
            this.tabControlPanel4.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calVigenciaControlCalidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.ComboBox cmbDepartamentos;
        private System.Windows.Forms.ComboBox cmbPais;
        private SPControladoraDatos.dsSpx dsSpx1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnSubirLogo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnBajarLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTituloOrdenServicio;
        private System.Windows.Forms.TextBox txtVersionOrdenServicio;
        private System.Windows.Forms.CheckBox chkPideFechaordenServicio;
        private System.Windows.Forms.CheckBox chkModificarOSSolicitudAbierta;
        private System.Windows.Forms.TextBox txtVersionRptInsumos;
        private System.Windows.Forms.TextBox txtTituloRptInsumos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVersionOrdenPrestamo;
        private System.Windows.Forms.TextBox txtTituloOrdenPrestamo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVersionReporteServicio;
        private System.Windows.Forms.TextBox txtTituloReporteServicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private SPControladoraDatos.dsSpxTableAdapters.departamentoTableAdapter departamentoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.paisesTableAdapter paisesTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.ciudadesTableAdapter ciudadesTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter defaultsTableAdapter1;
        private System.Windows.Forms.TextBox txtVersionEntradaSalida;
        private System.Windows.Forms.TextBox txtTituloEntradaSalida;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nmDias;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nmMeses;
        private System.Windows.Forms.TextBox txtVersionLlamadas;
        private System.Windows.Forms.TextBox txtTituloLlamadas;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtVersionProgramacionViajes;
        private System.Windows.Forms.TextBox txtTituloViajes;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtVersionSolicitud;
        private System.Windows.Forms.TextBox txtTitulosolicitud;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtTipoOrdenServicio;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFechaVigenciaOs;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calVigenciaReporteServicio;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtTipoReporteServicio;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calVigenciaES;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtTipoES;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calVigenciaLLamadas;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtTipoDocumentoLlamadas;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calVigenciaProgramacion;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtTipoProgramacion;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calVigenciaSolicitud;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtTipoSolicitud;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calVigenciaInsumos;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtTipoInsumos;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calVigenciaOrdenPrestamo;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txtTipoOrdenPrestamo;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel3;
        private DevComponents.DotNetBar.TabItem tabItem3;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.TabItem tabItem2;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel4;
        private DevComponents.DotNetBar.TabItem tabItem4;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox txtTituloControlCalidad;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txtVersionControlCalidad;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calVigenciaControlCalidad;
        private System.Windows.Forms.TextBox txtTipoDocumentoControlCalidad;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txtNotaPieReportes;
        private System.Windows.Forms.Label label40;
    }
}