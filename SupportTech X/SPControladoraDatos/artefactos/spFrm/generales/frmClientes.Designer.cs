namespace SpFrm.generales
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            C1.Win.C1TrueDBGrid.Style style9 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style10 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style11 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style12 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style13 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style14 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style15 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style16 = new C1.Win.C1TrueDBGrid.Style();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.clientesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.clientesTableAdapter();
            this.tipoDocumentoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.tipoDocumentoTableAdapter();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.sucursalClienteTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.sucursalClienteTableAdapter();
            this.contactosClientesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.contactosClientesTableAdapter();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
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
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.grdSucursalesC1 = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.c1TrueDBDropdown1 = new C1.Win.C1TrueDBGrid.C1TrueDBDropdown();
            this.btnConsultarSucursal = new System.Windows.Forms.Button();
            this.btnModificarSucursal = new System.Windows.Forms.Button();
            this.btnEiliminiarSucu = new System.Windows.Forms.Button();
            this.btnAgregarSucursal = new System.Windows.Forms.Button();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnModificarContacto = new System.Windows.Forms.Button();
            this.grdContactos = new System.Windows.Forms.DataGridView();
            this.codContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paginaWebDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cumpleanosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarContacto = new System.Windows.Forms.Button();
            this.btnAgergarContacto = new System.Windows.Forms.Button();
            this.groupPanel4 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnSubirLogo = new System.Windows.Forms.Button();
            this.btnDescargarLogo = new System.Windows.Forms.Button();
            this.tituloContactoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.tituloContactoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.ribbonControlDataFrm.SuspendLayout();
            this.ribbonPanel1dataFrm.SuspendLayout();
            this.ribbonPanel2dataFrm.SuspendLayout();
            this.grdDatos.BeginInit();
            this.grpOpcionesExportar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSucursalesC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBDropdown1)).BeginInit();
            this.groupPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContactos)).BeginInit();
            this.groupPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControlDataFrm
            // 
            // 
            // 
            // 
            this.ribbonControlDataFrm.BackgroundStyle.Class = "";
            this.ribbonControlDataFrm.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControlDataFrm.Location = new System.Drawing.Point(5, 1);
            this.ribbonControlDataFrm.Size = new System.Drawing.Size(934, 694);
            this.ribbonControlDataFrm.Controls.SetChildIndex(this.ribbonPanel2dataFrm, 0);
            this.ribbonControlDataFrm.Controls.SetChildIndex(this.ribbonPanel1dataFrm, 0);
            // 
            // ribbonPanel1dataFrm
            // 
            this.ribbonPanel1dataFrm.Controls.Add(this.chkActivo);
            this.ribbonPanel1dataFrm.Controls.Add(this.label1);
            this.ribbonPanel1dataFrm.Controls.Add(this.textBox1);
            this.ribbonPanel1dataFrm.Controls.Add(this.groupPanel4);
            this.ribbonPanel1dataFrm.Controls.Add(this.groupPanel3);
            this.ribbonPanel1dataFrm.Controls.Add(this.groupPanel2);
            this.ribbonPanel1dataFrm.Controls.Add(this.groupPanel1);
            this.ribbonPanel1dataFrm.Controls.Add(this.label15);
            this.ribbonPanel1dataFrm.Controls.Add(this.label10);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtNit);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtNombreCliente);
            this.ribbonPanel1dataFrm.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanel1dataFrm.Size = new System.Drawing.Size(934, 636);
            // 
            // 
            // 
            this.ribbonPanel1dataFrm.Style.Class = "";
            this.ribbonPanel1dataFrm.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1dataFrm.StyleMouseDown.Class = "";
            this.ribbonPanel1dataFrm.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1dataFrm.StyleMouseOver.Class = "";
            this.ribbonPanel1dataFrm.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1dataFrm.Visible = true;
            this.ribbonPanel1dataFrm.Click += new System.EventHandler(this.ribbonPanel1_Click);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtNombreCliente, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtNit, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label10, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label15, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.groupPanel1, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.groupPanel2, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.groupPanel3, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.groupPanel4, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.textBox1, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label1, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.chkActivo, 0);
            // 
            // cgDataControler1
            // 
            this.cgDataControler1.campos = resources.GetString("cgDataControler1.campos");
            this.cgDataControler1.dataTabla = this.dsSpx1.clientes;
            this.cgDataControler1.EstadoControles = false;
            this.cgDataControler1.EventosEncendidos = true;
            this.cgDataControler1.estadoControlesChanged += new CGDataControler.dataControlerEventHandler(this.cgDataControler1_estadoControlesChanged);
            this.cgDataControler1.EliminarLlaves += new CGDataControler.dataControlerEventHandler(this.cgDataControler1_EliminarLlaves);
            this.cgDataControler1.AntesDeNuevo += new CGDataControler.dataControlerEventHandler(this.cgDataControler1_AntesDeNuevo);
            this.cgDataControler1.AntesDeEliminar += new CGDataControler.dataControlerEventHandler(this.cgDataControler1_AntesDeEliminar);
            this.cgDataControler1.AntesDeAceptar += new CGDataControler.dataControlerEventHandler(this.cgDataControler1_AntesDeAceptar);
            this.cgDataControler1.DespuesDeAceptar += new CGDataControler.dataControlerEventHandler(this.cgDataControler1_DespuesDeAceptar);
            // 
            // ribbonPanel2dataFrm
            // 
            this.ribbonPanel2dataFrm.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanel2dataFrm.Size = new System.Drawing.Size(934, 636);
            // 
            // 
            // 
            this.ribbonPanel2dataFrm.Style.Class = "";
            this.ribbonPanel2dataFrm.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2dataFrm.StyleMouseDown.Class = "";
            this.ribbonPanel2dataFrm.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2dataFrm.StyleMouseOver.Class = "";
            this.ribbonPanel2dataFrm.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // grdDatos
            // 
            this.grdDatos.DataMember = "clientes";
            this.grdDatos.DataSource = this.dsSpx1;
            this.grdDatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDatos.Images"))));
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75D;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(838, 597);
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
            // 
            // txtTotalRegistros
            // 
            this.txtTotalRegistros.Text = "0";
            // 
            // grpOpcionesExportar
            // 
            // 
            // 
            // 
            this.grpOpcionesExportar.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.grpOpcionesExportar.Style.BackColorGradientAngle = 90;
            this.grpOpcionesExportar.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.grpOpcionesExportar.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpOpcionesExportar.Style.BorderBottomWidth = 1;
            this.grpOpcionesExportar.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.grpOpcionesExportar.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpOpcionesExportar.Style.BorderLeftWidth = 1;
            this.grpOpcionesExportar.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpOpcionesExportar.Style.BorderRightWidth = 1;
            this.grpOpcionesExportar.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpOpcionesExportar.Style.BorderTopWidth = 1;
            this.grpOpcionesExportar.Style.Class = "";
            this.grpOpcionesExportar.Style.CornerDiameter = 4;
            this.grpOpcionesExportar.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grpOpcionesExportar.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.grpOpcionesExportar.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grpOpcionesExportar.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.grpOpcionesExportar.StyleMouseDown.Class = "";
            this.grpOpcionesExportar.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.grpOpcionesExportar.StyleMouseOver.Class = "";
            this.grpOpcionesExportar.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
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
            // tipoDocumentoTableAdapter1
            // 
            this.tipoDocumentoTableAdapter1.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // sucursalClienteTableAdapter1
            // 
            this.sucursalClienteTableAdapter1.ClearBeforeFill = true;
            // 
            // contactosClientesTableAdapter1
            // 
            this.contactosClientesTableAdapter1.ClearBeforeFill = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(15, 139);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "*Nombre Cliente:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(14, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "*Nit Cliente:";
            // 
            // txtNit
            // 
            this.txtNit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "clientes.nitCliente", true));
            this.txtNit.Location = new System.Drawing.Point(122, 111);
            this.txtNit.MaxLength = 20;
            this.txtNit.Name = "txtNit";
            this.txtNit.ReadOnly = true;
            this.txtNit.Size = new System.Drawing.Size(196, 20);
            this.txtNit.TabIndex = 11;
            this.txtNit.TextChanged += new System.EventHandler(this.txtNit_TextChanged);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "clientes.nombreCliente", true));
            this.txtNombreCliente.Location = new System.Drawing.Point(121, 139);
            this.txtNombreCliente.MaxLength = 100;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(293, 20);
            this.txtNombreCliente.TabIndex = 12;
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
            this.groupPanel1.Location = new System.Drawing.Point(12, 212);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(418, 307);
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
            this.groupPanel1.TabIndex = 15;
            this.groupPanel1.Text = "Contacto Principal del Cliente";
            // 
            // cmbTituloContacto
            // 
            this.cmbTituloContacto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsSpx1, "clientes.tituloContacto", true));
            this.cmbTituloContacto.DataSource = this.dsSpx1;
            this.cmbTituloContacto.DisplayMember = "tituloContacto.tituloContacto";
            this.cmbTituloContacto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTituloContacto.FormattingEnabled = true;
            this.cmbTituloContacto.Location = new System.Drawing.Point(161, 9);
            this.cmbTituloContacto.MaxLength = 5;
            this.cmbTituloContacto.Name = "cmbTituloContacto";
            this.cmbTituloContacto.Size = new System.Drawing.Size(236, 21);
            this.cmbTituloContacto.TabIndex = 36;
            this.cmbTituloContacto.ValueMember = "tituloContacto.codTituloContacto";
            // 
            // cmbtipoDocumento
            // 
            this.cmbtipoDocumento.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsSpx1, "clientes.codTipoDoc", true));
            this.cmbtipoDocumento.DataSource = this.dsSpx1;
            this.cmbtipoDocumento.DisplayMember = "tipoDocumento.nombreTipoDoc";
            this.cmbtipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtipoDocumento.FormattingEnabled = true;
            this.cmbtipoDocumento.Location = new System.Drawing.Point(161, 95);
            this.cmbtipoDocumento.MaxLength = 5;
            this.cmbtipoDocumento.Name = "cmbtipoDocumento";
            this.cmbtipoDocumento.Size = new System.Drawing.Size(236, 21);
            this.cmbtipoDocumento.TabIndex = 21;
            this.cmbtipoDocumento.ValueMember = "tipoDocumento.codTipoDoc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nombres:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Apellidos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tipo Documento:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 124);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Documento:";
            // 
            // txtCelular
            // 
            this.txtCelular.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "clientes.celular", true));
            this.txtCelular.Location = new System.Drawing.Point(161, 207);
            this.txtCelular.MaxLength = 50;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.ReadOnly = true;
            this.txtCelular.Size = new System.Drawing.Size(236, 20);
            this.txtCelular.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Telefono 1:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 207);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Celular";
            // 
            // txtFax
            // 
            this.txtFax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "clientes.fax", true));
            this.txtFax.Location = new System.Drawing.Point(161, 233);
            this.txtFax.MaxLength = 25;
            this.txtFax.Name = "txtFax";
            this.txtFax.ReadOnly = true;
            this.txtFax.Size = new System.Drawing.Size(236, 20);
            this.txtFax.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Telefono 2:";
            // 
            // txtTelefono2
            // 
            this.txtTelefono2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "clientes.telefono2", true));
            this.txtTelefono2.Location = new System.Drawing.Point(161, 180);
            this.txtTelefono2.MaxLength = 25;
            this.txtTelefono2.Name = "txtTelefono2";
            this.txtTelefono2.ReadOnly = true;
            this.txtTelefono2.Size = new System.Drawing.Size(236, 20);
            this.txtTelefono2.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(123, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Titulo Contacto Personal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Fax:";
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "clientes.email", true));
            this.txtEmail.Location = new System.Drawing.Point(161, 260);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(236, 20);
            this.txtEmail.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 260);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Email";
            // 
            // txtNombres
            // 
            this.txtNombres.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "clientes.nombreContactoPrincipal", true));
            this.txtNombres.Location = new System.Drawing.Point(161, 39);
            this.txtNombres.MaxLength = 20;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.ReadOnly = true;
            this.txtNombres.Size = new System.Drawing.Size(236, 20);
            this.txtNombres.TabIndex = 16;
            // 
            // txtApellidos
            // 
            this.txtApellidos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "clientes.apellidosContacto", true));
            this.txtApellidos.Location = new System.Drawing.Point(161, 67);
            this.txtApellidos.MaxLength = 20;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ReadOnly = true;
            this.txtApellidos.Size = new System.Drawing.Size(236, 20);
            this.txtApellidos.TabIndex = 18;
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "clientes.docContacto", true));
            this.txtNroDocumento.Location = new System.Drawing.Point(161, 124);
            this.txtNroDocumento.MaxLength = 15;
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.ReadOnly = true;
            this.txtNroDocumento.Size = new System.Drawing.Size(236, 20);
            this.txtNroDocumento.TabIndex = 22;
            // 
            // txtTelefono1
            // 
            this.txtTelefono1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "clientes.telefono1", true));
            this.txtTelefono1.Location = new System.Drawing.Point(161, 152);
            this.txtTelefono1.MaxLength = 25;
            this.txtTelefono1.Name = "txtTelefono1";
            this.txtTelefono1.ReadOnly = true;
            this.txtTelefono1.Size = new System.Drawing.Size(236, 20);
            this.txtTelefono1.TabIndex = 23;
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.grdSucursalesC1);
            this.groupPanel2.Controls.Add(this.c1TrueDBDropdown1);
            this.groupPanel2.Controls.Add(this.btnConsultarSucursal);
            this.groupPanel2.Controls.Add(this.btnModificarSucursal);
            this.groupPanel2.Controls.Add(this.btnEiliminiarSucu);
            this.groupPanel2.Controls.Add(this.btnAgregarSucursal);
            this.groupPanel2.Location = new System.Drawing.Point(436, 257);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(496, 188);
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
            this.groupPanel2.TabIndex = 16;
            this.groupPanel2.Text = "Sucursales";
            // 
            // grdSucursalesC1
            // 
            this.grdSucursalesC1.DataMember = "sucursalCliente";
            this.grdSucursalesC1.DataSource = this.dsSpx1;
            this.grdSucursalesC1.GroupByCaption = "Drag a column header here to group by that column";
            this.grdSucursalesC1.Images.Add(((System.Drawing.Image)(resources.GetObject("grdSucursalesC1.Images"))));
            this.grdSucursalesC1.Location = new System.Drawing.Point(5, 52);
            this.grdSucursalesC1.Name = "grdSucursalesC1";
            this.grdSucursalesC1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdSucursalesC1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdSucursalesC1.PreviewInfo.ZoomFactor = 75D;
            this.grdSucursalesC1.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdSucursalesC1.PrintInfo.PageSettings")));
            this.grdSucursalesC1.Size = new System.Drawing.Size(472, 106);
            this.grdSucursalesC1.TabIndex = 51;
            this.grdSucursalesC1.Text = "c1TrueDBGrid1";
            this.grdSucursalesC1.Click += new System.EventHandler(this.grdSucursalesC1_Click);
            this.grdSucursalesC1.DoubleClick += new System.EventHandler(this.grdSucursalesC1_DoubleClick);
            this.grdSucursalesC1.PropBag = resources.GetString("grdSucursalesC1.PropBag");
            // 
            // c1TrueDBDropdown1
            // 
            this.c1TrueDBDropdown1.AllowColMove = true;
            this.c1TrueDBDropdown1.AllowColSelect = true;
            this.c1TrueDBDropdown1.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows;
            this.c1TrueDBDropdown1.AlternatingRows = false;
            this.c1TrueDBDropdown1.CaptionStyle = style9;
            this.c1TrueDBDropdown1.ColumnCaptionHeight = 17;
            this.c1TrueDBDropdown1.ColumnFooterHeight = 17;
            this.c1TrueDBDropdown1.DataSource = this.dsSpx1;
            this.c1TrueDBDropdown1.EvenRowStyle = style10;
            this.c1TrueDBDropdown1.FetchRowStyles = false;
            this.c1TrueDBDropdown1.FooterStyle = style11;
            this.c1TrueDBDropdown1.HeadingStyle = style12;
            this.c1TrueDBDropdown1.HighLightRowStyle = style13;
            this.c1TrueDBDropdown1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBDropdown1.Images"))));
            this.c1TrueDBDropdown1.Location = new System.Drawing.Point(371, 0);
            this.c1TrueDBDropdown1.Name = "c1TrueDBDropdown1";
            this.c1TrueDBDropdown1.OddRowStyle = style14;
            this.c1TrueDBDropdown1.RecordSelectorStyle = style15;
            this.c1TrueDBDropdown1.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.c1TrueDBDropdown1.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
            this.c1TrueDBDropdown1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1TrueDBDropdown1.ScrollTips = false;
            this.c1TrueDBDropdown1.Size = new System.Drawing.Size(75, 23);
            this.c1TrueDBDropdown1.Style = style16;
            this.c1TrueDBDropdown1.TabIndex = 50;
            this.c1TrueDBDropdown1.Text = "c1TrueDBDropdown1";
            this.c1TrueDBDropdown1.Visible = false;
            this.c1TrueDBDropdown1.PropBag = resources.GetString("c1TrueDBDropdown1.PropBag");
            // 
            // btnConsultarSucursal
            // 
            this.btnConsultarSucursal.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarSucursal.Location = new System.Drawing.Point(254, 6);
            this.btnConsultarSucursal.Name = "btnConsultarSucursal";
            this.btnConsultarSucursal.Size = new System.Drawing.Size(75, 20);
            this.btnConsultarSucursal.TabIndex = 49;
            this.btnConsultarSucursal.Text = "Consultar";
            this.btnConsultarSucursal.UseVisualStyleBackColor = true;
            this.btnConsultarSucursal.Click += new System.EventHandler(this.btnConsultarSucursal_Click);
            // 
            // btnModificarSucursal
            // 
            this.btnModificarSucursal.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarSucursal.Location = new System.Drawing.Point(87, 5);
            this.btnModificarSucursal.Name = "btnModificarSucursal";
            this.btnModificarSucursal.Size = new System.Drawing.Size(75, 20);
            this.btnModificarSucursal.TabIndex = 48;
            this.btnModificarSucursal.Text = "Modificar";
            this.btnModificarSucursal.UseVisualStyleBackColor = true;
            this.btnModificarSucursal.Click += new System.EventHandler(this.btnModificarSucursal_Click);
            // 
            // btnEiliminiarSucu
            // 
            this.btnEiliminiarSucu.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEiliminiarSucu.Location = new System.Drawing.Point(170, 5);
            this.btnEiliminiarSucu.Name = "btnEiliminiarSucu";
            this.btnEiliminiarSucu.Size = new System.Drawing.Size(75, 20);
            this.btnEiliminiarSucu.TabIndex = 47;
            this.btnEiliminiarSucu.Text = "Eliminar";
            this.btnEiliminiarSucu.UseVisualStyleBackColor = true;
            this.btnEiliminiarSucu.Click += new System.EventHandler(this.btnEiliminiarSucu_Click);
            // 
            // btnAgregarSucursal
            // 
            this.btnAgregarSucursal.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSucursal.Location = new System.Drawing.Point(4, 5);
            this.btnAgregarSucursal.Name = "btnAgregarSucursal";
            this.btnAgregarSucursal.Size = new System.Drawing.Size(75, 20);
            this.btnAgregarSucursal.TabIndex = 46;
            this.btnAgregarSucursal.Text = "Agregar";
            this.btnAgregarSucursal.UseVisualStyleBackColor = true;
            this.btnAgregarSucursal.Click += new System.EventHandler(this.btnAgregarSucursal_Click);
            // 
            // groupPanel3
            // 
            this.groupPanel3.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.btnConsultar);
            this.groupPanel3.Controls.Add(this.btnModificarContacto);
            this.groupPanel3.Controls.Add(this.grdContactos);
            this.groupPanel3.Controls.Add(this.btnEliminarContacto);
            this.groupPanel3.Controls.Add(this.btnAgergarContacto);
            this.groupPanel3.Location = new System.Drawing.Point(436, 449);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(496, 174);
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
            this.groupPanel3.Style.Class = "";
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.Class = "";
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.Class = "";
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.TabIndex = 17;
            this.groupPanel3.Text = "Contactos";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(253, 6);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 20);
            this.btnConsultar.TabIndex = 48;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnModificarContacto
            // 
            this.btnModificarContacto.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarContacto.Location = new System.Drawing.Point(87, 6);
            this.btnModificarContacto.Name = "btnModificarContacto";
            this.btnModificarContacto.Size = new System.Drawing.Size(75, 20);
            this.btnModificarContacto.TabIndex = 47;
            this.btnModificarContacto.Text = "Modificar";
            this.btnModificarContacto.UseVisualStyleBackColor = true;
            this.btnModificarContacto.Click += new System.EventHandler(this.btnModificarContacto_Click);
            // 
            // grdContactos
            // 
            this.grdContactos.AllowUserToAddRows = false;
            this.grdContactos.AllowUserToDeleteRows = false;
            this.grdContactos.AutoGenerateColumns = false;
            this.grdContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdContactos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codContactoDataGridViewTextBoxColumn,
            this.tituloContactoDataGridViewTextBoxColumn,
            this.nombreContactoDataGridViewTextBoxColumn,
            this.apellidosContactoDataGridViewTextBoxColumn,
            this.docContactoDataGridViewTextBoxColumn,
            this.telefono1DataGridViewTextBoxColumn,
            this.telefono2DataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.paginaWebDataGridViewTextBoxColumn,
            this.faxDataGridViewTextBoxColumn,
            this.cumpleanosDataGridViewTextBoxColumn});
            this.grdContactos.DataMember = "contactosClientes";
            this.grdContactos.DataSource = this.dsSpx1;
            this.grdContactos.Location = new System.Drawing.Point(3, 28);
            this.grdContactos.Name = "grdContactos";
            this.grdContactos.ReadOnly = true;
            this.grdContactos.Size = new System.Drawing.Size(475, 122);
            this.grdContactos.TabIndex = 44;
            // 
            // codContactoDataGridViewTextBoxColumn
            // 
            this.codContactoDataGridViewTextBoxColumn.DataPropertyName = "codContacto";
            this.codContactoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codContactoDataGridViewTextBoxColumn.Name = "codContactoDataGridViewTextBoxColumn";
            this.codContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tituloContactoDataGridViewTextBoxColumn
            // 
            this.tituloContactoDataGridViewTextBoxColumn.DataPropertyName = "tituloContacto";
            this.tituloContactoDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloContactoDataGridViewTextBoxColumn.Name = "tituloContactoDataGridViewTextBoxColumn";
            this.tituloContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreContactoDataGridViewTextBoxColumn
            // 
            this.nombreContactoDataGridViewTextBoxColumn.DataPropertyName = "nombreContacto";
            this.nombreContactoDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreContactoDataGridViewTextBoxColumn.Name = "nombreContactoDataGridViewTextBoxColumn";
            this.nombreContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidosContactoDataGridViewTextBoxColumn
            // 
            this.apellidosContactoDataGridViewTextBoxColumn.DataPropertyName = "apellidosContacto";
            this.apellidosContactoDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosContactoDataGridViewTextBoxColumn.Name = "apellidosContactoDataGridViewTextBoxColumn";
            this.apellidosContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // docContactoDataGridViewTextBoxColumn
            // 
            this.docContactoDataGridViewTextBoxColumn.DataPropertyName = "docContacto";
            this.docContactoDataGridViewTextBoxColumn.HeaderText = "Documento";
            this.docContactoDataGridViewTextBoxColumn.Name = "docContactoDataGridViewTextBoxColumn";
            this.docContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefono1DataGridViewTextBoxColumn
            // 
            this.telefono1DataGridViewTextBoxColumn.DataPropertyName = "telefono1";
            this.telefono1DataGridViewTextBoxColumn.HeaderText = "Telefono 1";
            this.telefono1DataGridViewTextBoxColumn.Name = "telefono1DataGridViewTextBoxColumn";
            this.telefono1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefono2DataGridViewTextBoxColumn
            // 
            this.telefono2DataGridViewTextBoxColumn.DataPropertyName = "telefono2";
            this.telefono2DataGridViewTextBoxColumn.HeaderText = "Telefono 2";
            this.telefono2DataGridViewTextBoxColumn.Name = "telefono2DataGridViewTextBoxColumn";
            this.telefono2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            this.celularDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paginaWebDataGridViewTextBoxColumn
            // 
            this.paginaWebDataGridViewTextBoxColumn.DataPropertyName = "paginaWeb";
            this.paginaWebDataGridViewTextBoxColumn.HeaderText = "Pagina Web";
            this.paginaWebDataGridViewTextBoxColumn.Name = "paginaWebDataGridViewTextBoxColumn";
            this.paginaWebDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // faxDataGridViewTextBoxColumn
            // 
            this.faxDataGridViewTextBoxColumn.DataPropertyName = "fax";
            this.faxDataGridViewTextBoxColumn.HeaderText = "fax";
            this.faxDataGridViewTextBoxColumn.Name = "faxDataGridViewTextBoxColumn";
            this.faxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cumpleanosDataGridViewTextBoxColumn
            // 
            this.cumpleanosDataGridViewTextBoxColumn.DataPropertyName = "cumpleanos";
            this.cumpleanosDataGridViewTextBoxColumn.HeaderText = "Cumpleaños";
            this.cumpleanosDataGridViewTextBoxColumn.Name = "cumpleanosDataGridViewTextBoxColumn";
            this.cumpleanosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnEliminarContacto
            // 
            this.btnEliminarContacto.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarContacto.Location = new System.Drawing.Point(170, 6);
            this.btnEliminarContacto.Name = "btnEliminarContacto";
            this.btnEliminarContacto.Size = new System.Drawing.Size(75, 20);
            this.btnEliminarContacto.TabIndex = 46;
            this.btnEliminarContacto.Text = "Eliminar";
            this.btnEliminarContacto.UseVisualStyleBackColor = true;
            this.btnEliminarContacto.Click += new System.EventHandler(this.btnEliminarContacto_Click);
            // 
            // btnAgergarContacto
            // 
            this.btnAgergarContacto.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgergarContacto.Location = new System.Drawing.Point(4, 6);
            this.btnAgergarContacto.Name = "btnAgergarContacto";
            this.btnAgergarContacto.Size = new System.Drawing.Size(75, 20);
            this.btnAgergarContacto.TabIndex = 45;
            this.btnAgergarContacto.Text = "Agregar";
            this.btnAgergarContacto.UseVisualStyleBackColor = true;
            this.btnAgergarContacto.Click += new System.EventHandler(this.btnAgergarContacto_Click);
            // 
            // groupPanel4
            // 
            this.groupPanel4.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel4.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel4.Controls.Add(this.picLogo);
            this.groupPanel4.Controls.Add(this.btnSubirLogo);
            this.groupPanel4.Controls.Add(this.btnDescargarLogo);
            this.groupPanel4.Location = new System.Drawing.Point(437, 97);
            this.groupPanel4.Name = "groupPanel4";
            this.groupPanel4.Size = new System.Drawing.Size(495, 156);
            // 
            // 
            // 
            this.groupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel4.Style.BackColorGradientAngle = 90;
            this.groupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderBottomWidth = 1;
            this.groupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderLeftWidth = 1;
            this.groupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderRightWidth = 1;
            this.groupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderTopWidth = 1;
            this.groupPanel4.Style.Class = "";
            this.groupPanel4.Style.CornerDiameter = 4;
            this.groupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseDown.Class = "";
            this.groupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseOver.Class = "";
            this.groupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel4.TabIndex = 18;
            this.groupPanel4.Text = "Logo del Cliente";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Black;
            this.picLogo.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.dsSpx1, "clientes.logotipo", true));
            this.picLogo.Location = new System.Drawing.Point(3, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(345, 126);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 35;
            this.picLogo.TabStop = false;
            // 
            // btnSubirLogo
            // 
            this.btnSubirLogo.Location = new System.Drawing.Point(370, 4);
            this.btnSubirLogo.Name = "btnSubirLogo";
            this.btnSubirLogo.Size = new System.Drawing.Size(93, 23);
            this.btnSubirLogo.TabIndex = 33;
            this.btnSubirLogo.Text = "Subir Logo";
            this.btnSubirLogo.UseVisualStyleBackColor = true;
            this.btnSubirLogo.Click += new System.EventHandler(this.btnSubirLogo_Click);
            // 
            // btnDescargarLogo
            // 
            this.btnDescargarLogo.Location = new System.Drawing.Point(370, 29);
            this.btnDescargarLogo.Name = "btnDescargarLogo";
            this.btnDescargarLogo.Size = new System.Drawing.Size(93, 23);
            this.btnDescargarLogo.TabIndex = 34;
            this.btnDescargarLogo.Text = "Descargar Logo";
            this.btnDescargarLogo.UseVisualStyleBackColor = true;
            this.btnDescargarLogo.Click += new System.EventHandler(this.btnDescargarLogo_Click);
            // 
            // tituloContactoTableAdapter1
            // 
            this.tituloContactoTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(14, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Numero de Socio";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "clientes.numeroSocio", true));
            this.textBox1.Location = new System.Drawing.Point(121, 168);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(293, 20);
            this.textBox1.TabIndex = 19;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.BackColor = System.Drawing.Color.Transparent;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsSpx1, "clientes.activo", true));
            this.chkActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivo.Location = new System.Drawing.Point(344, 108);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(70, 20);
            this.chkActivo.TabIndex = 21;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = false;
            // 
            // frmClientes
            // 
            this.ClientSize = new System.Drawing.Size(944, 697);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClientes";
            this.Text = "Clientes - Nombre Software";
            this.tituloTabla = "Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.ribbonControlDataFrm.ResumeLayout(false);
            this.ribbonControlDataFrm.PerformLayout();
            this.ribbonPanel1dataFrm.ResumeLayout(false);
            this.ribbonPanel1dataFrm.PerformLayout();
            this.ribbonPanel2dataFrm.ResumeLayout(false);
            this.ribbonPanel2dataFrm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.grpOpcionesExportar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSucursalesC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBDropdown1)).EndInit();
            this.groupPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdContactos)).EndInit();
            this.groupPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.clientesTableAdapter clientesTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.tipoDocumentoTableAdapter tipoDocumentoTableAdapter1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private SPControladoraDatos.dsSpxTableAdapters.sucursalClienteTableAdapter sucursalClienteTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.contactosClientesTableAdapter contactosClientesTableAdapter1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
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
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel4;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnModificarContacto;
        private System.Windows.Forms.DataGridView grdContactos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paginaWebDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cumpleanosDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnEliminarContacto;
        private System.Windows.Forms.Button btnAgergarContacto;
        private System.Windows.Forms.Button btnConsultarSucursal;
        private System.Windows.Forms.Button btnModificarSucursal;
        private System.Windows.Forms.Button btnEiliminiarSucu;
        private System.Windows.Forms.Button btnAgregarSucursal;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnSubirLogo;
        private System.Windows.Forms.Button btnDescargarLogo;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdSucursalesC1;
        private C1.Win.C1TrueDBGrid.C1TrueDBDropdown c1TrueDBDropdown1;
        private System.Windows.Forms.ComboBox cmbTituloContacto;
        private SPControladoraDatos.dsSpxTableAdapters.tituloContactoTableAdapter tituloContactoTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox chkActivo;
    }
}
