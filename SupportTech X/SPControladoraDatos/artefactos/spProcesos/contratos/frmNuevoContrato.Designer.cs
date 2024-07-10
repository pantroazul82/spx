namespace spProcesos.contratos
{
    partial class frmNuevoContrato
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
            C1.Win.C1TrueDBGrid.Style style1 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style2 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style3 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style4 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style5 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style6 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style7 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style8 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style9 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style10 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style11 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style12 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style13 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style14 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style15 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style16 = new C1.Win.C1TrueDBGrid.Style();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoContrato));
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.tipoContratoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.tipoContratoTableAdapter();
            this.contratosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.contratosTableAdapter();
            this.archivosxcontratoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.archivosxcontratoTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.clientesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.clientesTableAdapter();
            this.contratosxEquipoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.contratosxEquipoTableAdapter();
            this.equiposTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSerial = new System.Windows.Forms.Label();
            this.dsPlantillas1 = new SPControladoraDatos.dsPlantillas();
            this.btnDesvincularOden = new DevComponents.DotNetBar.ButtonX();
            this.btnVincularOrden = new DevComponents.DotNetBar.ButtonX();
            this.btnEditarInfoEquipo = new DevComponents.DotNetBar.ButtonX();
            this.grpMantenimiento = new System.Windows.Forms.GroupBox();
            this.nmTopeCorrectivos = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.chkIncluyeCorrectivos = new System.Windows.Forms.CheckBox();
            this.btnModificarRepuesto = new DevComponents.DotNetBar.ButtonX();
            this.btnDesvincularRepuesto = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregarRepuestos = new DevComponents.DotNetBar.ButtonX();
            this.grdRepuestos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.nmDiasHabiles = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nmMantenimientosIncluidos = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nmMesesEntreMantenimientos = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.nmHorasHabiles = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.chkIncluyeTiquetes = new System.Windows.Forms.CheckBox();
            this.nmPorcentajePrecioTiquetes = new System.Windows.Forms.NumericUpDown();
            this.chkIncluyeRepuestos = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calCreacion = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMontoContrato = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbTipoContrato = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.grpConsumo = new System.Windows.Forms.GroupBox();
            this.txtConsumoxLinea = new System.Windows.Forms.TextBox();
            this.chkTienePoliza = new System.Windows.Forms.CheckBox();
            this.rdConsumoxLinea = new System.Windows.Forms.RadioButton();
            this.rdconsumoMinimoGeneral = new System.Windows.Forms.RadioButton();
            this.txtConsumoMinimo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnImprimir = new DevComponents.DotNetBar.ButtonX();
            this.txtObervaciones = new System.Windows.Forms.TextBox();
            this.btnCancelar = new DevComponents.DotNetBar.ButtonX();
            this.btnGuardar = new DevComponents.DotNetBar.ButtonX();
            this.label24 = new System.Windows.Forms.Label();
            this.cmbModalidadContrato = new System.Windows.Forms.ComboBox();
            this.txtNroContrato = new System.Windows.Forms.TextBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.btnBuscarNit = new DevComponents.DotNetBar.ButtonX();
            this.btnLimpiarCliente = new System.Windows.Forms.Button();
            this.calInicioContrato = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.calFinContrato = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnCambiarContrato = new DevComponents.DotNetBar.ButtonX();
            this.btnDesvincularEquipo = new DevComponents.DotNetBar.ButtonX();
            this.btnVincularEquipo = new DevComponents.DotNetBar.ButtonX();
            this.btnInfEquipo = new DevComponents.DotNetBar.ButtonX();
            this.grdEquipos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.label16 = new System.Windows.Forms.Label();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel3 = new DevComponents.DotNetBar.TabControlPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.lblSerialOtroSi = new System.Windows.Forms.Label();
            this.dsPlantillasEquipoOtroSi = new SPControladoraDatos.dsPlantillas();
            this.btnDesvincularOrdenOtroSi = new DevComponents.DotNetBar.ButtonX();
            this.btnVincularOrdenOtroSi = new DevComponents.DotNetBar.ButtonX();
            this.c1TipoContrato = new C1.Win.C1TrueDBGrid.C1TrueDBDropdown();
            this.dsOtrosSi = new SPControladoraDatos.dsSpx();
            this.c1CmbModalidadContrato = new C1.Win.C1TrueDBGrid.C1TrueDBDropdown();
            this.btnExportarEquiposOtro = new DevComponents.DotNetBar.ButtonX();
            this.btnEditOtroSi = new DevComponents.DotNetBar.ButtonX();
            this.btnEliminarOtroSi = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregarOtroSi = new DevComponents.DotNetBar.ButtonX();
            this.btnEditInfoequipoOtroSi = new DevComponents.DotNetBar.ButtonX();
            this.btnCambiarEquipoOtroSi = new DevComponents.DotNetBar.ButtonX();
            this.btnEliminarEquipoOtroSi = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregarEquipoOtroSi = new DevComponents.DotNetBar.ButtonX();
            this.btnHojaDeVidaEOtroSi = new DevComponents.DotNetBar.ButtonX();
            this.grdEquiposOtroSi = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.grdOtroSi = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.tabItem3 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.c1GrdArchivos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuitarArchivo = new System.Windows.Forms.Button();
            this.btnSubirArchivo = new System.Windows.Forms.Button();
            this.btnGuardarArchivo = new System.Windows.Forms.Button();
            this.btnVerArchivo = new System.Windows.Forms.Button();
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel4 = new DevComponents.DotNetBar.TabControlPanel();
            this.btnExportarEquposTodos = new DevComponents.DotNetBar.ButtonX();
            this.grdtodosequipos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsPltTotales = new SPControladoraDatos.dsPlantillas();
            this.label1 = new System.Windows.Forms.Label();
            this.tabItem4 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel5 = new DevComponents.DotNetBar.TabControlPanel();
            this.btnExportarRepuestos = new DevComponents.DotNetBar.ButtonX();
            this.label4 = new System.Windows.Forms.Label();
            this.grdRepuestosTodoContrato = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsTotales = new SPControladoraDatos.dsSpx();
            this.tabItem5 = new DevComponents.DotNetBar.TabItem(this.components);
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.mantenimientosxContratoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.mantenimientosxContratoTableAdapter();
            this.modalidadContratoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.modalidadContratoTableAdapter();
            this.repuestosxContratosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.repuestosxContratosTableAdapter();
            this.pltFechaSistemaTableAdapter1 = new SPControladoraDatos.dsPlantillasTableAdapters.pltFechaSistemaTableAdapter();
            this.pltComtratoxEquipoTableAdapter1 = new SPControladoraDatos.dsPlantillasTableAdapters.pltComtratoxEquipoTableAdapter();
            this.tabItem6 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel6 = new DevComponents.DotNetBar.TabControlPanel();
            this.grdVinculaciones = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).BeginInit();
            this.grpMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTopeCorrectivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRepuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiasHabiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMantenimientosIncluidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMesesEntreMantenimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmHorasHabiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPorcentajePrecioTiquetes)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calCreacion)).BeginInit();
            this.grpConsumo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calInicioContrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFinContrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEquipos)).BeginInit();
            this.tabControlPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillasEquipoOtroSi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TipoContrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOtrosSi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CmbModalidadContrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEquiposOtroSi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOtroSi)).BeginInit();
            this.tabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1GrdArchivos)).BeginInit();
            this.tabControlPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdtodosequipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPltTotales)).BeginInit();
            this.tabControlPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRepuestosTodoContrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTotales)).BeginInit();
            this.tabControlPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVinculaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoContratoTableAdapter1
            // 
            this.tipoContratoTableAdapter1.ClearBeforeFill = true;
            // 
            // contratosTableAdapter1
            // 
            this.contratosTableAdapter1.ClearBeforeFill = true;
            // 
            // archivosxcontratoTableAdapter1
            // 
            this.archivosxcontratoTableAdapter1.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // contratosxEquipoTableAdapter1
            // 
            this.contratosxEquipoTableAdapter1.ClearBeforeFill = true;
            // 
            // equiposTableAdapter1
            // 
            this.equiposTableAdapter1.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanel6);
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Controls.Add(this.tabControlPanel5);
            this.tabControl1.Controls.Add(this.tabControlPanel3);
            this.tabControl1.Controls.Add(this.tabControlPanel2);
            this.tabControl1.Controls.Add(this.tabControlPanel4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1016, 694);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItem1);
            this.tabControl1.Tabs.Add(this.tabItem2);
            this.tabControl1.Tabs.Add(this.tabItem3);
            this.tabControl1.Tabs.Add(this.tabItem4);
            this.tabControl1.Tabs.Add(this.tabItem5);
            this.tabControl1.Tabs.Add(this.tabItem6);
            this.tabControl1.Text = "tabControl1";
            this.tabControl1.SelectedTabChanged += new DevComponents.DotNetBar.TabStrip.SelectedTabChangedEventHandler(this.tabControl1_SelectedTabChanged);
            this.tabControl1.SelectedTabChanging += new DevComponents.DotNetBar.TabStrip.SelectedTabChangingEventHandler(this.tabControl1_SelectedTabChanging);
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.label7);
            this.tabControlPanel1.Controls.Add(this.lblSerial);
            this.tabControlPanel1.Controls.Add(this.btnDesvincularOden);
            this.tabControlPanel1.Controls.Add(this.btnVincularOrden);
            this.tabControlPanel1.Controls.Add(this.btnEditarInfoEquipo);
            this.tabControlPanel1.Controls.Add(this.grpMantenimiento);
            this.tabControlPanel1.Controls.Add(this.groupBox2);
            this.tabControlPanel1.Controls.Add(this.btnCambiarContrato);
            this.tabControlPanel1.Controls.Add(this.btnDesvincularEquipo);
            this.tabControlPanel1.Controls.Add(this.btnVincularEquipo);
            this.tabControlPanel1.Controls.Add(this.btnInfEquipo);
            this.tabControlPanel1.Controls.Add(this.grdEquipos);
            this.tabControlPanel1.Controls.Add(this.label16);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(1016, 668);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 0;
            this.tabControlPanel1.TabItem = this.tabItem1;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(521, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 140;
            this.label7.Text = "Serial Activo";
            // 
            // lblSerial
            // 
            this.lblSerial.BackColor = System.Drawing.Color.White;
            this.lblSerial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPlantillas1, "pltComtratoxEquipo.serial", true));
            this.lblSerial.Location = new System.Drawing.Point(521, 383);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(117, 23);
            this.lblSerial.TabIndex = 139;
            // 
            // dsPlantillas1
            // 
            this.dsPlantillas1.DataSetName = "dsPlantillas";
            this.dsPlantillas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDesvincularOden
            // 
            this.btnDesvincularOden.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnDesvincularOden, null);
            this.balloonTip1.SetBalloonText(this.btnDesvincularOden, "Vincular Equipo");
            this.btnDesvincularOden.Image = ((System.Drawing.Image)(resources.GetObject("btnDesvincularOden.Image")));
            this.btnDesvincularOden.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnDesvincularOden.Location = new System.Drawing.Point(761, 373);
            this.btnDesvincularOden.Name = "btnDesvincularOden";
            this.btnDesvincularOden.Size = new System.Drawing.Size(92, 33);
            this.btnDesvincularOden.TabIndex = 138;
            this.btnDesvincularOden.Text = "desvincular Orden";
            this.btnDesvincularOden.Click += new System.EventHandler(this.btnDesvincularOden_Click);
            // 
            // btnVincularOrden
            // 
            this.btnVincularOrden.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnVincularOrden, null);
            this.balloonTip1.SetBalloonText(this.btnVincularOrden, "Vincular Equipo");
            this.btnVincularOrden.Image = ((System.Drawing.Image)(resources.GetObject("btnVincularOrden.Image")));
            this.btnVincularOrden.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnVincularOrden.Location = new System.Drawing.Point(679, 373);
            this.btnVincularOrden.Name = "btnVincularOrden";
            this.btnVincularOrden.Size = new System.Drawing.Size(80, 33);
            this.btnVincularOrden.TabIndex = 137;
            this.btnVincularOrden.Text = "Vincular Orden";
            this.btnVincularOrden.Click += new System.EventHandler(this.btnVincularOrden_Click);
            // 
            // btnEditarInfoEquipo
            // 
            this.btnEditarInfoEquipo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnEditarInfoEquipo, null);
            this.balloonTip1.SetBalloonText(this.btnEditarInfoEquipo, "Editar Informacion del Equipo");
            this.btnEditarInfoEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarInfoEquipo.Image")));
            this.btnEditarInfoEquipo.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnEditarInfoEquipo.Location = new System.Drawing.Point(891, 373);
            this.btnEditarInfoEquipo.Name = "btnEditarInfoEquipo";
            this.btnEditarInfoEquipo.Size = new System.Drawing.Size(33, 33);
            this.btnEditarInfoEquipo.TabIndex = 4;
            this.btnEditarInfoEquipo.Click += new System.EventHandler(this.btnEditarInfoEquipo_Click);
            // 
            // grpMantenimiento
            // 
            this.grpMantenimiento.BackColor = System.Drawing.Color.Transparent;
            this.grpMantenimiento.Controls.Add(this.nmTopeCorrectivos);
            this.grpMantenimiento.Controls.Add(this.label6);
            this.grpMantenimiento.Controls.Add(this.chkIncluyeCorrectivos);
            this.grpMantenimiento.Controls.Add(this.btnModificarRepuesto);
            this.grpMantenimiento.Controls.Add(this.btnDesvincularRepuesto);
            this.grpMantenimiento.Controls.Add(this.btnAgregarRepuestos);
            this.grpMantenimiento.Controls.Add(this.grdRepuestos);
            this.grpMantenimiento.Controls.Add(this.nmDiasHabiles);
            this.grpMantenimiento.Controls.Add(this.label3);
            this.grpMantenimiento.Controls.Add(this.nmMantenimientosIncluidos);
            this.grpMantenimiento.Controls.Add(this.label8);
            this.grpMantenimiento.Controls.Add(this.nmMesesEntreMantenimientos);
            this.grpMantenimiento.Controls.Add(this.label15);
            this.grpMantenimiento.Controls.Add(this.nmHorasHabiles);
            this.grpMantenimiento.Controls.Add(this.label14);
            this.grpMantenimiento.Controls.Add(this.label11);
            this.grpMantenimiento.Controls.Add(this.chkIncluyeTiquetes);
            this.grpMantenimiento.Controls.Add(this.nmPorcentajePrecioTiquetes);
            this.grpMantenimiento.Controls.Add(this.chkIncluyeRepuestos);
            this.grpMantenimiento.Controls.Add(this.label10);
            this.grpMantenimiento.Location = new System.Drawing.Point(518, 5);
            this.grpMantenimiento.Name = "grpMantenimiento";
            this.grpMantenimiento.Size = new System.Drawing.Size(486, 356);
            this.grpMantenimiento.TabIndex = 1;
            this.grpMantenimiento.TabStop = false;
            this.grpMantenimiento.Text = "Informacion de Mantenimiento";
            // 
            // nmTopeCorrectivos
            // 
            this.nmTopeCorrectivos.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmTopeCorrectivos.Location = new System.Drawing.Point(408, 27);
            this.nmTopeCorrectivos.Name = "nmTopeCorrectivos";
            this.nmTopeCorrectivos.Size = new System.Drawing.Size(61, 21);
            this.nmTopeCorrectivos.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(205, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 21);
            this.label6.TabIndex = 136;
            this.label6.Text = "Tope para Correctivos (0 para ilimitados)";
            // 
            // chkIncluyeCorrectivos
            // 
            this.chkIncluyeCorrectivos.AutoSize = true;
            this.chkIncluyeCorrectivos.BackColor = System.Drawing.Color.Transparent;
            this.chkIncluyeCorrectivos.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncluyeCorrectivos.Location = new System.Drawing.Point(15, 29);
            this.chkIncluyeCorrectivos.Name = "chkIncluyeCorrectivos";
            this.chkIncluyeCorrectivos.Size = new System.Drawing.Size(115, 17);
            this.chkIncluyeCorrectivos.TabIndex = 0;
            this.chkIncluyeCorrectivos.Text = "Incluye Correctivos";
            this.chkIncluyeCorrectivos.UseVisualStyleBackColor = false;
            // 
            // btnModificarRepuesto
            // 
            this.btnModificarRepuesto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnModificarRepuesto, null);
            this.balloonTip1.SetBalloonText(this.btnModificarRepuesto, "Modificar Repuestos");
            this.btnModificarRepuesto.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarRepuesto.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarRepuesto.Image")));
            this.btnModificarRepuesto.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnModificarRepuesto.Location = new System.Drawing.Point(402, 157);
            this.btnModificarRepuesto.Name = "btnModificarRepuesto";
            this.btnModificarRepuesto.Size = new System.Drawing.Size(33, 33);
            this.btnModificarRepuesto.TabIndex = 10;
            this.btnModificarRepuesto.Click += new System.EventHandler(this.btnModificarRepuesto_Click);
            // 
            // btnDesvincularRepuesto
            // 
            this.btnDesvincularRepuesto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnDesvincularRepuesto, null);
            this.balloonTip1.SetBalloonText(this.btnDesvincularRepuesto, "Desvincular Repuesto");
            this.btnDesvincularRepuesto.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesvincularRepuesto.Image = ((System.Drawing.Image)(resources.GetObject("btnDesvincularRepuesto.Image")));
            this.btnDesvincularRepuesto.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnDesvincularRepuesto.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDesvincularRepuesto.Location = new System.Drawing.Point(436, 157);
            this.btnDesvincularRepuesto.Name = "btnDesvincularRepuesto";
            this.btnDesvincularRepuesto.Size = new System.Drawing.Size(33, 33);
            this.btnDesvincularRepuesto.TabIndex = 11;
            this.btnDesvincularRepuesto.Click += new System.EventHandler(this.btnDesvincularRepuesto_Click);
            // 
            // btnAgregarRepuestos
            // 
            this.btnAgregarRepuestos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnAgregarRepuestos, null);
            this.balloonTip1.SetBalloonText(this.btnAgregarRepuestos, "Agregar Repuestos");
            this.btnAgregarRepuestos.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRepuestos.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarRepuestos.Image")));
            this.btnAgregarRepuestos.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnAgregarRepuestos.Location = new System.Drawing.Point(368, 157);
            this.btnAgregarRepuestos.Name = "btnAgregarRepuestos";
            this.btnAgregarRepuestos.Size = new System.Drawing.Size(33, 33);
            this.btnAgregarRepuestos.TabIndex = 9;
            this.btnAgregarRepuestos.Click += new System.EventHandler(this.btnAgregarRepuestos_Click);
            // 
            // grdRepuestos
            // 
            this.grdRepuestos.AllowUpdate = false;
            this.grdRepuestos.DataMember = "repuestosxContratos";
            this.grdRepuestos.DataSource = this.dsSpx1;
            this.grdRepuestos.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdRepuestos.FilterBar = true;
            this.grdRepuestos.GroupByCaption = "";
            this.grdRepuestos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdRepuestos.Images"))));
            this.grdRepuestos.Location = new System.Drawing.Point(15, 196);
            this.grdRepuestos.Name = "grdRepuestos";
            this.grdRepuestos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdRepuestos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdRepuestos.PreviewInfo.ZoomFactor = 75D;
            this.grdRepuestos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdRepuestos.PrintInfo.PageSettings")));
            this.grdRepuestos.Size = new System.Drawing.Size(462, 155);
            this.grdRepuestos.TabIndex = 12;
            this.grdRepuestos.Text = "c1TrueDBGrid1";
            this.grdRepuestos.PropBag = resources.GetString("grdRepuestos.PropBag");
            // 
            // nmDiasHabiles
            // 
            this.nmDiasHabiles.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmDiasHabiles.Location = new System.Drawing.Point(408, 85);
            this.nmDiasHabiles.Name = "nmDiasHabiles";
            this.nmDiasHabiles.Size = new System.Drawing.Size(61, 21);
            this.nmDiasHabiles.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 34);
            this.label3.TabIndex = 101;
            this.label3.Text = "Numero de Mantenimientos Incluidos";
            // 
            // nmMantenimientosIncluidos
            // 
            this.nmMantenimientosIncluidos.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmMantenimientosIncluidos.Location = new System.Drawing.Point(160, 52);
            this.nmMantenimientosIncluidos.Name = "nmMantenimientosIncluidos";
            this.nmMantenimientosIncluidos.Size = new System.Drawing.Size(61, 21);
            this.nmMantenimientosIncluidos.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(240, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 26);
            this.label8.TabIndex = 115;
            this.label8.Text = "Meses entre los mantenimentos del contrato";
            // 
            // nmMesesEntreMantenimientos
            // 
            this.nmMesesEntreMantenimientos.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmMesesEntreMantenimientos.Location = new System.Drawing.Point(408, 52);
            this.nmMesesEntreMantenimientos.Name = "nmMesesEntreMantenimientos";
            this.nmMesesEntreMantenimientos.Size = new System.Drawing.Size(61, 21);
            this.nmMesesEntreMantenimientos.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(15, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 26);
            this.label15.TabIndex = 130;
            this.label15.Text = "Tiempo respuesta Horas habiles";
            // 
            // nmHorasHabiles
            // 
            this.nmHorasHabiles.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmHorasHabiles.Location = new System.Drawing.Point(160, 87);
            this.nmHorasHabiles.Name = "nmHorasHabiles";
            this.nmHorasHabiles.Size = new System.Drawing.Size(61, 21);
            this.nmHorasHabiles.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(240, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(162, 16);
            this.label14.TabIndex = 132;
            this.label14.Text = "Tiempo Respuesta Dias Habiles";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(240, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 27);
            this.label11.TabIndex = 123;
            this.label11.Text = "Porcentaje Cubierto del Precio de tiquetes";
            // 
            // chkIncluyeTiquetes
            // 
            this.chkIncluyeTiquetes.AutoSize = true;
            this.chkIncluyeTiquetes.BackColor = System.Drawing.Color.Transparent;
            this.chkIncluyeTiquetes.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncluyeTiquetes.Location = new System.Drawing.Point(15, 130);
            this.chkIncluyeTiquetes.Name = "chkIncluyeTiquetes";
            this.chkIncluyeTiquetes.Size = new System.Drawing.Size(103, 17);
            this.chkIncluyeTiquetes.TabIndex = 7;
            this.chkIncluyeTiquetes.Text = "Incluye Tiquetes";
            this.chkIncluyeTiquetes.UseVisualStyleBackColor = false;
            // 
            // nmPorcentajePrecioTiquetes
            // 
            this.nmPorcentajePrecioTiquetes.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmPorcentajePrecioTiquetes.Location = new System.Drawing.Point(408, 117);
            this.nmPorcentajePrecioTiquetes.Name = "nmPorcentajePrecioTiquetes";
            this.nmPorcentajePrecioTiquetes.Size = new System.Drawing.Size(61, 21);
            this.nmPorcentajePrecioTiquetes.TabIndex = 6;
            this.nmPorcentajePrecioTiquetes.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // chkIncluyeRepuestos
            // 
            this.chkIncluyeRepuestos.AutoSize = true;
            this.chkIncluyeRepuestos.BackColor = System.Drawing.Color.Transparent;
            this.chkIncluyeRepuestos.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncluyeRepuestos.Location = new System.Drawing.Point(15, 156);
            this.chkIncluyeRepuestos.Name = "chkIncluyeRepuestos";
            this.chkIncluyeRepuestos.Size = new System.Drawing.Size(112, 17);
            this.chkIncluyeRepuestos.TabIndex = 8;
            this.chkIncluyeRepuestos.Text = "Incluye Repuestos";
            this.chkIncluyeRepuestos.UseVisualStyleBackColor = false;
            this.chkIncluyeRepuestos.CheckedChanged += new System.EventHandler(this.chkIncluyeRepuestos_CheckedChanged);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(15, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 20);
            this.label10.TabIndex = 121;
            this.label10.Text = "Repuestos incluidos";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblHora);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.calCreacion);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtMontoContrato);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.cmbTipoContrato);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.grpConsumo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnImprimir);
            this.groupBox2.Controls.Add(this.txtObervaciones);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.cmbModalidadContrato);
            this.groupBox2.Controls.Add(this.txtNroContrato);
            this.groupBox2.Controls.Add(this.cmbCliente);
            this.groupBox2.Controls.Add(this.btnBuscarNit);
            this.groupBox2.Controls.Add(this.btnLimpiarCliente);
            this.groupBox2.Controls.Add(this.calInicioContrato);
            this.groupBox2.Controls.Add(this.calFinContrato);
            this.groupBox2.Location = new System.Drawing.Point(6, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 380);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion General";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Location = new System.Drawing.Point(258, 20);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 13);
            this.lblHora.TabIndex = 161;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(10, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 160;
            this.label5.Text = "Fecha Creacion";
            // 
            // calCreacion
            // 
            // 
            // 
            // 
            this.calCreacion.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calCreacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calCreacion.ButtonDropDown.Visible = true;
            this.calCreacion.Enabled = false;
            this.calCreacion.Location = new System.Drawing.Point(136, 17);
            // 
            // 
            // 
            this.calCreacion.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calCreacion.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calCreacion.MonthCalendar.BackgroundStyle.Class = "";
            this.calCreacion.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calCreacion.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calCreacion.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calCreacion.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calCreacion.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calCreacion.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calCreacion.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calCreacion.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calCreacion.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calCreacion.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calCreacion.MonthCalendar.DisplayMonth = new System.DateTime(2008, 10, 1, 0, 0, 0, 0);
            this.calCreacion.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calCreacion.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calCreacion.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calCreacion.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calCreacion.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calCreacion.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calCreacion.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calCreacion.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calCreacion.MonthCalendar.TodayButtonVisible = true;
            this.calCreacion.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calCreacion.Name = "calCreacion";
            this.calCreacion.Size = new System.Drawing.Size(117, 20);
            this.calCreacion.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(10, 156);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 13);
            this.label18.TabIndex = 158;
            this.label18.Text = "Monto Contrato";
            // 
            // txtMontoContrato
            // 
            this.txtMontoContrato.Location = new System.Drawing.Point(136, 153);
            this.txtMontoContrato.Name = "txtMontoContrato";
            this.txtMontoContrato.Size = new System.Drawing.Size(141, 20);
            this.txtMontoContrato.TabIndex = 10;
            this.txtMontoContrato.TextChanged += new System.EventHandler(this.txtMontoContrato_TextChanged);
            this.txtMontoContrato.Validating += new System.ComponentModel.CancelEventHandler(this.txtMontoContrato_Validating);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(448, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(13, 43);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 13);
            this.label19.TabIndex = 157;
            this.label19.Text = "Tipo de Contrato";
            // 
            // cmbTipoContrato
            // 
            this.cmbTipoContrato.DataSource = this.dsSpx1;
            this.cmbTipoContrato.DisplayMember = "tipoContrato.nombreTipoContrato";
            this.cmbTipoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoContrato.FormattingEnabled = true;
            this.cmbTipoContrato.Location = new System.Drawing.Point(136, 43);
            this.cmbTipoContrato.MaxLength = 5;
            this.cmbTipoContrato.Name = "cmbTipoContrato";
            this.cmbTipoContrato.Size = new System.Drawing.Size(310, 21);
            this.cmbTipoContrato.TabIndex = 2;
            this.cmbTipoContrato.ValueMember = "tipoContrato.codTipoContrato";
            this.cmbTipoContrato.SelectedIndexChanged += new System.EventHandler(this.cmbTipoContrato_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(259, 133);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(97, 13);
            this.label20.TabIndex = 156;
            this.label20.Text = "Fecha Fin Contrato";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(13, 101);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 13);
            this.label21.TabIndex = 155;
            this.label21.Text = "Cliente";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(13, 72);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(116, 13);
            this.label22.TabIndex = 154;
            this.label22.Text = "Modalidad del Contrato";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(13, 130);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(108, 13);
            this.label23.TabIndex = 153;
            this.label23.Text = "Fecha Inicio Contrato";
            // 
            // grpConsumo
            // 
            this.grpConsumo.BackColor = System.Drawing.Color.Transparent;
            this.grpConsumo.Controls.Add(this.txtConsumoxLinea);
            this.grpConsumo.Controls.Add(this.chkTienePoliza);
            this.grpConsumo.Controls.Add(this.rdConsumoxLinea);
            this.grpConsumo.Controls.Add(this.rdconsumoMinimoGeneral);
            this.grpConsumo.Controls.Add(this.txtConsumoMinimo);
            this.grpConsumo.Location = new System.Drawing.Point(12, 178);
            this.grpConsumo.Name = "grpConsumo";
            this.grpConsumo.Size = new System.Drawing.Size(486, 68);
            this.grpConsumo.TabIndex = 11;
            this.grpConsumo.TabStop = false;
            this.grpConsumo.Text = "Consumo MInimo";
            // 
            // txtConsumoxLinea
            // 
            this.txtConsumoxLinea.Location = new System.Drawing.Point(339, 18);
            this.txtConsumoxLinea.Name = "txtConsumoxLinea";
            this.txtConsumoxLinea.Size = new System.Drawing.Size(141, 20);
            this.txtConsumoxLinea.TabIndex = 1;
            this.txtConsumoxLinea.TextChanged += new System.EventHandler(this.txtConsumoxLinea_TextChanged);
            this.txtConsumoxLinea.Validating += new System.ComponentModel.CancelEventHandler(this.txtConsumoxLinea_Validating);
            // 
            // chkTienePoliza
            // 
            this.chkTienePoliza.AutoSize = true;
            this.chkTienePoliza.BackColor = System.Drawing.Color.Transparent;
            this.chkTienePoliza.Location = new System.Drawing.Point(10, 19);
            this.chkTienePoliza.Name = "chkTienePoliza";
            this.chkTienePoliza.Size = new System.Drawing.Size(106, 17);
            this.chkTienePoliza.TabIndex = 0;
            this.chkTienePoliza.Text = "Consumo Minimo";
            this.chkTienePoliza.UseVisualStyleBackColor = false;
            this.chkTienePoliza.CheckedChanged += new System.EventHandler(this.chkTienePoliza_CheckedChanged);
            // 
            // rdConsumoxLinea
            // 
            this.rdConsumoxLinea.AutoSize = true;
            this.rdConsumoxLinea.BackColor = System.Drawing.Color.Transparent;
            this.rdConsumoxLinea.Enabled = false;
            this.rdConsumoxLinea.Location = new System.Drawing.Point(178, 19);
            this.rdConsumoxLinea.Name = "rdConsumoxLinea";
            this.rdConsumoxLinea.Size = new System.Drawing.Size(143, 17);
            this.rdConsumoxLinea.TabIndex = 0;
            this.rdConsumoxLinea.TabStop = true;
            this.rdConsumoxLinea.Text = "Consumo MInimo x Linea";
            this.rdConsumoxLinea.UseVisualStyleBackColor = false;
            this.rdConsumoxLinea.CheckedChanged += new System.EventHandler(this.rdConsumoxLinea_CheckedChanged);
            // 
            // rdconsumoMinimoGeneral
            // 
            this.rdconsumoMinimoGeneral.AutoSize = true;
            this.rdconsumoMinimoGeneral.BackColor = System.Drawing.Color.Transparent;
            this.rdconsumoMinimoGeneral.Enabled = false;
            this.rdconsumoMinimoGeneral.Location = new System.Drawing.Point(178, 44);
            this.rdconsumoMinimoGeneral.Name = "rdconsumoMinimoGeneral";
            this.rdconsumoMinimoGeneral.Size = new System.Drawing.Size(146, 17);
            this.rdconsumoMinimoGeneral.TabIndex = 2;
            this.rdconsumoMinimoGeneral.TabStop = true;
            this.rdconsumoMinimoGeneral.Text = "Consumo MInimo General";
            this.rdconsumoMinimoGeneral.UseVisualStyleBackColor = false;
            this.rdconsumoMinimoGeneral.CheckedChanged += new System.EventHandler(this.rdconsumoMinimoGeneral_CheckedChanged);
            // 
            // txtConsumoMinimo
            // 
            this.txtConsumoMinimo.Enabled = false;
            this.txtConsumoMinimo.Location = new System.Drawing.Point(339, 43);
            this.txtConsumoMinimo.Name = "txtConsumoMinimo";
            this.txtConsumoMinimo.Size = new System.Drawing.Size(141, 20);
            this.txtConsumoMinimo.TabIndex = 3;
            this.txtConsumoMinimo.TextChanged += new System.EventHandler(this.txtConsumoMinimo_TextChanged);
            this.txtConsumoMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsumoMinimo_KeyPress);
            this.txtConsumoMinimo.Validating += new System.ComponentModel.CancelEventHandler(this.txtConsumoMinimo_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(4, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 114;
            this.label9.Text = "Observaciones:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnImprimir, "Imprimir");
            this.balloonTip1.SetBalloonText(this.btnImprimir, null);
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnImprimir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnImprimir.Location = new System.Drawing.Point(291, 342);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(33, 33);
            this.btnImprimir.TabIndex = 13;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtObervaciones
            // 
            this.txtObervaciones.Location = new System.Drawing.Point(11, 271);
            this.txtObervaciones.MaxLength = 1073741823;
            this.txtObervaciones.Multiline = true;
            this.txtObervaciones.Name = "txtObervaciones";
            this.txtObervaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObervaciones.Size = new System.Drawing.Size(487, 65);
            this.txtObervaciones.TabIndex = 12;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnCancelar, "Cancelar");
            this.balloonTip1.SetBalloonText(this.btnCancelar, null);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnCancelar.Location = new System.Drawing.Point(414, 342);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 33);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnGuardar, "Guardar");
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnGuardar.Location = new System.Drawing.Point(327, 342);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 33);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(327, 23);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(72, 13);
            this.label24.TabIndex = 152;
            this.label24.Text = "Num Contrato";
            // 
            // cmbModalidadContrato
            // 
            this.cmbModalidadContrato.DataSource = this.dsSpx1;
            this.cmbModalidadContrato.DisplayMember = "modalidadContrato.nombreModalidadContrato";
            this.cmbModalidadContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModalidadContrato.FormattingEnabled = true;
            this.cmbModalidadContrato.Location = new System.Drawing.Point(136, 72);
            this.cmbModalidadContrato.MaxLength = 5;
            this.cmbModalidadContrato.Name = "cmbModalidadContrato";
            this.cmbModalidadContrato.Size = new System.Drawing.Size(310, 21);
            this.cmbModalidadContrato.TabIndex = 3;
            this.cmbModalidadContrato.ValueMember = "modalidadContrato.codModalidadContrato";
            // 
            // txtNroContrato
            // 
            this.txtNroContrato.Location = new System.Drawing.Point(400, 19);
            this.txtNroContrato.MaxLength = 40;
            this.txtNroContrato.Name = "txtNroContrato";
            this.txtNroContrato.Size = new System.Drawing.Size(106, 20);
            this.txtNroContrato.TabIndex = 1;
            this.txtNroContrato.Validating += new System.ComponentModel.CancelEventHandler(this.txtNroContrato_Validating);
            // 
            // cmbCliente
            // 
            this.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCliente.DataSource = this.dsSpx1;
            this.cmbCliente.DisplayMember = "clientes.nombreCliente";
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(136, 101);
            this.cmbCliente.MaxLength = 20;
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(310, 21);
            this.cmbCliente.TabIndex = 5;
            this.cmbCliente.ValueMember = "clientes.nitCliente";
            // 
            // btnBuscarNit
            // 
            this.btnBuscarNit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscarNit.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarNit.Image")));
            this.btnBuscarNit.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnBuscarNit.Location = new System.Drawing.Point(470, 95);
            this.btnBuscarNit.Name = "btnBuscarNit";
            this.btnBuscarNit.Size = new System.Drawing.Size(33, 33);
            this.btnBuscarNit.TabIndex = 7;
            this.btnBuscarNit.Click += new System.EventHandler(this.btnBuscarNit_Click);
            // 
            // btnLimpiarCliente
            // 
            this.btnLimpiarCliente.Location = new System.Drawing.Point(448, 100);
            this.btnLimpiarCliente.Name = "btnLimpiarCliente";
            this.btnLimpiarCliente.Size = new System.Drawing.Size(19, 23);
            this.btnLimpiarCliente.TabIndex = 6;
            this.btnLimpiarCliente.Text = "x";
            this.btnLimpiarCliente.UseVisualStyleBackColor = true;
            this.btnLimpiarCliente.Click += new System.EventHandler(this.btnLimpiarCliente_Click);
            // 
            // calInicioContrato
            // 
            // 
            // 
            // 
            this.calInicioContrato.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calInicioContrato.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioContrato.ButtonDropDown.Visible = true;
            this.calInicioContrato.Location = new System.Drawing.Point(136, 130);
            // 
            // 
            // 
            this.calInicioContrato.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calInicioContrato.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calInicioContrato.MonthCalendar.BackgroundStyle.Class = "";
            this.calInicioContrato.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioContrato.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calInicioContrato.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calInicioContrato.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calInicioContrato.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calInicioContrato.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calInicioContrato.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calInicioContrato.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calInicioContrato.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calInicioContrato.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioContrato.MonthCalendar.DisplayMonth = new System.DateTime(2008, 10, 1, 0, 0, 0, 0);
            this.calInicioContrato.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calInicioContrato.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calInicioContrato.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calInicioContrato.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calInicioContrato.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calInicioContrato.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calInicioContrato.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calInicioContrato.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calInicioContrato.MonthCalendar.TodayButtonVisible = true;
            this.calInicioContrato.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calInicioContrato.Name = "calInicioContrato";
            this.calInicioContrato.Size = new System.Drawing.Size(117, 20);
            this.calInicioContrato.TabIndex = 8;
            this.calInicioContrato.Validating += new System.ComponentModel.CancelEventHandler(this.calInicioContrato_Validating);
            // 
            // calFinContrato
            // 
            // 
            // 
            // 
            this.calFinContrato.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calFinContrato.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinContrato.ButtonDropDown.Visible = true;
            this.calFinContrato.Location = new System.Drawing.Point(362, 129);
            // 
            // 
            // 
            this.calFinContrato.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFinContrato.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calFinContrato.MonthCalendar.BackgroundStyle.Class = "";
            this.calFinContrato.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinContrato.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calFinContrato.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calFinContrato.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calFinContrato.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calFinContrato.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calFinContrato.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calFinContrato.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calFinContrato.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calFinContrato.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinContrato.MonthCalendar.DisplayMonth = new System.DateTime(2008, 10, 1, 0, 0, 0, 0);
            this.calFinContrato.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calFinContrato.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calFinContrato.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFinContrato.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calFinContrato.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calFinContrato.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calFinContrato.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calFinContrato.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFinContrato.MonthCalendar.TodayButtonVisible = true;
            this.calFinContrato.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calFinContrato.Name = "calFinContrato";
            this.calFinContrato.Size = new System.Drawing.Size(117, 20);
            this.calFinContrato.TabIndex = 9;
            this.calFinContrato.Validating += new System.ComponentModel.CancelEventHandler(this.calFinContrato_Validating);
            // 
            // btnCambiarContrato
            // 
            this.btnCambiarContrato.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnCambiarContrato, null);
            this.balloonTip1.SetBalloonText(this.btnCambiarContrato, "Cambiar Vinculacion del Equipo por Otro Equipo");
            this.btnCambiarContrato.Image = ((System.Drawing.Image)(resources.GetObject("btnCambiarContrato.Image")));
            this.btnCambiarContrato.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnCambiarContrato.Location = new System.Drawing.Point(644, 373);
            this.btnCambiarContrato.Name = "btnCambiarContrato";
            this.btnCambiarContrato.Size = new System.Drawing.Size(33, 33);
            this.btnCambiarContrato.TabIndex = 3;
            this.btnCambiarContrato.Click += new System.EventHandler(this.btnCambiarContrato_Click);
            // 
            // btnDesvincularEquipo
            // 
            this.btnDesvincularEquipo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnDesvincularEquipo, null);
            this.balloonTip1.SetBalloonText(this.btnDesvincularEquipo, "Desvincular Equipo");
            this.btnDesvincularEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnDesvincularEquipo.Image")));
            this.btnDesvincularEquipo.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnDesvincularEquipo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDesvincularEquipo.Location = new System.Drawing.Point(927, 373);
            this.btnDesvincularEquipo.Name = "btnDesvincularEquipo";
            this.btnDesvincularEquipo.Size = new System.Drawing.Size(33, 33);
            this.btnDesvincularEquipo.TabIndex = 5;
            this.btnDesvincularEquipo.Click += new System.EventHandler(this.btnDesvincularEquipo_Click);
            // 
            // btnVincularEquipo
            // 
            this.btnVincularEquipo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnVincularEquipo, null);
            this.balloonTip1.SetBalloonText(this.btnVincularEquipo, "Vincular Equipo");
            this.btnVincularEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnVincularEquipo.Image")));
            this.btnVincularEquipo.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnVincularEquipo.Location = new System.Drawing.Point(855, 373);
            this.btnVincularEquipo.Name = "btnVincularEquipo";
            this.btnVincularEquipo.Size = new System.Drawing.Size(33, 33);
            this.btnVincularEquipo.TabIndex = 2;
            this.btnVincularEquipo.Click += new System.EventHandler(this.btnVincularEquipo_Click);
            // 
            // btnInfEquipo
            // 
            this.btnInfEquipo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnInfEquipo, "Hoja de Vida del Equipo");
            this.balloonTip1.SetBalloonText(this.btnInfEquipo, null);
            this.btnInfEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfEquipo.Image")));
            this.btnInfEquipo.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnInfEquipo.Location = new System.Drawing.Point(963, 373);
            this.btnInfEquipo.Name = "btnInfEquipo";
            this.btnInfEquipo.Size = new System.Drawing.Size(33, 33);
            this.btnInfEquipo.TabIndex = 6;
            this.btnInfEquipo.Click += new System.EventHandler(this.btnInfEquipo_Click);
            // 
            // grdEquipos
            // 
            this.grdEquipos.AllowColMove = false;
            this.grdEquipos.AllowColSelect = false;
            this.grdEquipos.AllowUpdate = false;
            this.grdEquipos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdEquipos.DataMember = "pltComtratoxEquipo";
            this.grdEquipos.DataSource = this.dsPlantillas1;
            this.grdEquipos.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdEquipos.FilterBar = true;
            this.grdEquipos.GroupByAreaVisible = false;
            this.grdEquipos.GroupByCaption = "";
            this.grdEquipos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdEquipos.Images"))));
            this.grdEquipos.Location = new System.Drawing.Point(12, 409);
            this.grdEquipos.Name = "grdEquipos";
            this.grdEquipos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdEquipos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdEquipos.PreviewInfo.ZoomFactor = 75D;
            this.grdEquipos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdEquipos.PrintInfo.PageSettings")));
            this.grdEquipos.Size = new System.Drawing.Size(986, 247);
            this.grdEquipos.TabIndex = 7;
            this.grdEquipos.Text = "c1TrueDBGrid1";
            this.grdEquipos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.grdEquipos.PropBag = resources.GetString("grdEquipos.PropBag");
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(9, 388);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(193, 18);
            this.label16.TabIndex = 136;
            this.label16.Text = "Equipos Vinculados al Contrato";
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel1;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "Informacion General";
            // 
            // tabControlPanel3
            // 
            this.tabControlPanel3.Controls.Add(this.label12);
            this.tabControlPanel3.Controls.Add(this.lblSerialOtroSi);
            this.tabControlPanel3.Controls.Add(this.btnDesvincularOrdenOtroSi);
            this.tabControlPanel3.Controls.Add(this.btnVincularOrdenOtroSi);
            this.tabControlPanel3.Controls.Add(this.c1TipoContrato);
            this.tabControlPanel3.Controls.Add(this.c1CmbModalidadContrato);
            this.tabControlPanel3.Controls.Add(this.btnExportarEquiposOtro);
            this.tabControlPanel3.Controls.Add(this.btnEditOtroSi);
            this.tabControlPanel3.Controls.Add(this.btnEliminarOtroSi);
            this.tabControlPanel3.Controls.Add(this.btnAgregarOtroSi);
            this.tabControlPanel3.Controls.Add(this.btnEditInfoequipoOtroSi);
            this.tabControlPanel3.Controls.Add(this.btnCambiarEquipoOtroSi);
            this.tabControlPanel3.Controls.Add(this.btnEliminarEquipoOtroSi);
            this.tabControlPanel3.Controls.Add(this.btnAgregarEquipoOtroSi);
            this.tabControlPanel3.Controls.Add(this.btnHojaDeVidaEOtroSi);
            this.tabControlPanel3.Controls.Add(this.grdEquiposOtroSi);
            this.tabControlPanel3.Controls.Add(this.grdOtroSi);
            this.tabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel3.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel3.Name = "tabControlPanel3";
            this.tabControlPanel3.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel3.Size = new System.Drawing.Size(1016, 668);
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
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(454, 274);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 16);
            this.label12.TabIndex = 167;
            this.label12.Text = "Serial Activo";
            // 
            // lblSerialOtroSi
            // 
            this.lblSerialOtroSi.BackColor = System.Drawing.Color.White;
            this.lblSerialOtroSi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPlantillasEquipoOtroSi, "pltComtratoxEquipo.serial", true));
            this.lblSerialOtroSi.Location = new System.Drawing.Point(454, 293);
            this.lblSerialOtroSi.Name = "lblSerialOtroSi";
            this.lblSerialOtroSi.Size = new System.Drawing.Size(117, 23);
            this.lblSerialOtroSi.TabIndex = 166;
            // 
            // dsPlantillasEquipoOtroSi
            // 
            this.dsPlantillasEquipoOtroSi.DataSetName = "dsPlantillas";
            this.dsPlantillasEquipoOtroSi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDesvincularOrdenOtroSi
            // 
            this.btnDesvincularOrdenOtroSi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnDesvincularOrdenOtroSi, null);
            this.balloonTip1.SetBalloonText(this.btnDesvincularOrdenOtroSi, "Vincular Equipo");
            this.btnDesvincularOrdenOtroSi.Image = ((System.Drawing.Image)(resources.GetObject("btnDesvincularOrdenOtroSi.Image")));
            this.btnDesvincularOrdenOtroSi.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnDesvincularOrdenOtroSi.Location = new System.Drawing.Point(716, 280);
            this.btnDesvincularOrdenOtroSi.Name = "btnDesvincularOrdenOtroSi";
            this.btnDesvincularOrdenOtroSi.Size = new System.Drawing.Size(92, 33);
            this.btnDesvincularOrdenOtroSi.TabIndex = 165;
            this.btnDesvincularOrdenOtroSi.Text = "desvincular Orden";
            this.btnDesvincularOrdenOtroSi.Click += new System.EventHandler(this.btnDesvincularOrdenOtroSi_Click);
            // 
            // btnVincularOrdenOtroSi
            // 
            this.btnVincularOrdenOtroSi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnVincularOrdenOtroSi, null);
            this.balloonTip1.SetBalloonText(this.btnVincularOrdenOtroSi, "Vincular Equipo");
            this.btnVincularOrdenOtroSi.Image = ((System.Drawing.Image)(resources.GetObject("btnVincularOrdenOtroSi.Image")));
            this.btnVincularOrdenOtroSi.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnVincularOrdenOtroSi.Location = new System.Drawing.Point(634, 280);
            this.btnVincularOrdenOtroSi.Name = "btnVincularOrdenOtroSi";
            this.btnVincularOrdenOtroSi.Size = new System.Drawing.Size(80, 33);
            this.btnVincularOrdenOtroSi.TabIndex = 164;
            this.btnVincularOrdenOtroSi.Text = "Vincular Orden";
            this.btnVincularOrdenOtroSi.Click += new System.EventHandler(this.btnVincularOrdenOtroSi_Click);
            // 
            // c1TipoContrato
            // 
            this.c1TipoContrato.AllowColMove = true;
            this.c1TipoContrato.AllowColSelect = true;
            this.c1TipoContrato.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows;
            this.c1TipoContrato.AlternatingRows = false;
            this.c1TipoContrato.CaptionStyle = style1;
            this.c1TipoContrato.ColumnCaptionHeight = 17;
            this.c1TipoContrato.ColumnFooterHeight = 17;
            this.c1TipoContrato.DataMember = "tipoContrato";
            this.c1TipoContrato.DataSource = this.dsOtrosSi;
            this.c1TipoContrato.DisplayMember = "tipoContrato.nombreTipoContrato";
            this.c1TipoContrato.EvenRowStyle = style2;
            this.c1TipoContrato.FetchRowStyles = false;
            this.c1TipoContrato.FooterStyle = style3;
            this.c1TipoContrato.HeadingStyle = style4;
            this.c1TipoContrato.HighLightRowStyle = style5;
            this.c1TipoContrato.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TipoContrato.Images"))));
            this.c1TipoContrato.Location = new System.Drawing.Point(492, 82);
            this.c1TipoContrato.Name = "c1TipoContrato";
            this.c1TipoContrato.OddRowStyle = style6;
            this.c1TipoContrato.RecordSelectorStyle = style7;
            this.c1TipoContrato.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.c1TipoContrato.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
            this.c1TipoContrato.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1TipoContrato.ScrollTips = false;
            this.c1TipoContrato.Size = new System.Drawing.Size(100, 150);
            this.c1TipoContrato.Style = style8;
            this.c1TipoContrato.TabIndex = 163;
            this.c1TipoContrato.TabStop = false;
            this.c1TipoContrato.Text = "c1TrueDBDropdown2";
            this.c1TipoContrato.ValueMember = "tipoContrato.codTipoContrato";
            this.c1TipoContrato.ValueTranslate = true;
            this.c1TipoContrato.Visible = false;
            this.c1TipoContrato.PropBag = resources.GetString("c1TipoContrato.PropBag");
            // 
            // dsOtrosSi
            // 
            this.dsOtrosSi.DataSetName = "dsSpx";
            this.dsOtrosSi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // c1CmbModalidadContrato
            // 
            this.c1CmbModalidadContrato.AllowColMove = true;
            this.c1CmbModalidadContrato.AllowColSelect = true;
            this.c1CmbModalidadContrato.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows;
            this.c1CmbModalidadContrato.AlternatingRows = false;
            this.c1CmbModalidadContrato.CaptionStyle = style9;
            this.c1CmbModalidadContrato.ColumnCaptionHeight = 17;
            this.c1CmbModalidadContrato.ColumnFooterHeight = 17;
            this.c1CmbModalidadContrato.DataMember = "modalidadContrato";
            this.c1CmbModalidadContrato.DataSource = this.dsOtrosSi;
            this.c1CmbModalidadContrato.DisplayMember = "modalidadContrato.nombreModalidadContrato";
            this.c1CmbModalidadContrato.EvenRowStyle = style10;
            this.c1CmbModalidadContrato.FetchRowStyles = false;
            this.c1CmbModalidadContrato.FooterStyle = style11;
            this.c1CmbModalidadContrato.HeadingStyle = style12;
            this.c1CmbModalidadContrato.HighLightRowStyle = style13;
            this.c1CmbModalidadContrato.Images.Add(((System.Drawing.Image)(resources.GetObject("c1CmbModalidadContrato.Images"))));
            this.c1CmbModalidadContrato.Location = new System.Drawing.Point(280, 98);
            this.c1CmbModalidadContrato.Name = "c1CmbModalidadContrato";
            this.c1CmbModalidadContrato.OddRowStyle = style14;
            this.c1CmbModalidadContrato.RecordSelectorStyle = style15;
            this.c1CmbModalidadContrato.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.c1CmbModalidadContrato.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
            this.c1CmbModalidadContrato.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1CmbModalidadContrato.ScrollTips = false;
            this.c1CmbModalidadContrato.Size = new System.Drawing.Size(100, 150);
            this.c1CmbModalidadContrato.Style = style16;
            this.c1CmbModalidadContrato.TabIndex = 162;
            this.c1CmbModalidadContrato.TabStop = false;
            this.c1CmbModalidadContrato.Text = "c1TrueDBDropdown1";
            this.c1CmbModalidadContrato.ValueMember = "modalidadContrato.codModalidadContrato";
            this.c1CmbModalidadContrato.ValueTranslate = true;
            this.c1CmbModalidadContrato.Visible = false;
            this.c1CmbModalidadContrato.PropBag = resources.GetString("c1CmbModalidadContrato.PropBag");
            // 
            // btnExportarEquiposOtro
            // 
            this.btnExportarEquiposOtro.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnExportarEquiposOtro, "Exportar a Excel");
            this.balloonTip1.SetBalloonText(this.btnExportarEquiposOtro, null);
            this.btnExportarEquiposOtro.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarEquiposOtro.Image")));
            this.btnExportarEquiposOtro.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnExportarEquiposOtro.Location = new System.Drawing.Point(965, 280);
            this.btnExportarEquiposOtro.Name = "btnExportarEquiposOtro";
            this.btnExportarEquiposOtro.Size = new System.Drawing.Size(33, 33);
            this.btnExportarEquiposOtro.TabIndex = 161;
            this.btnExportarEquiposOtro.Click += new System.EventHandler(this.btnExportarEquiposOtro_Click);
            // 
            // btnEditOtroSi
            // 
            this.btnEditOtroSi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEditOtroSi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnEditOtroSi, null);
            this.balloonTip1.SetBalloonText(this.btnEditOtroSi, "Modificar Otro Si");
            this.btnEditOtroSi.Image = ((System.Drawing.Image)(resources.GetObject("btnEditOtroSi.Image")));
            this.btnEditOtroSi.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnEditOtroSi.Location = new System.Drawing.Point(944, 31);
            this.btnEditOtroSi.Name = "btnEditOtroSi";
            this.btnEditOtroSi.Size = new System.Drawing.Size(33, 33);
            this.btnEditOtroSi.TabIndex = 145;
            this.btnEditOtroSi.Click += new System.EventHandler(this.btnEditOtroSi_Click);
            // 
            // btnEliminarOtroSi
            // 
            this.btnEliminarOtroSi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEliminarOtroSi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnEliminarOtroSi, null);
            this.balloonTip1.SetBalloonText(this.btnEliminarOtroSi, "Eliminar Otro Si");
            this.btnEliminarOtroSi.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarOtroSi.Image")));
            this.btnEliminarOtroSi.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnEliminarOtroSi.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnEliminarOtroSi.Location = new System.Drawing.Point(978, 31);
            this.btnEliminarOtroSi.Name = "btnEliminarOtroSi";
            this.btnEliminarOtroSi.Size = new System.Drawing.Size(33, 33);
            this.btnEliminarOtroSi.TabIndex = 144;
            this.btnEliminarOtroSi.Click += new System.EventHandler(this.btnEliminarOtroSi_Click);
            // 
            // btnAgregarOtroSi
            // 
            this.btnAgregarOtroSi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregarOtroSi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnAgregarOtroSi, null);
            this.balloonTip1.SetBalloonText(this.btnAgregarOtroSi, "Agregar Otro Si ");
            this.btnAgregarOtroSi.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarOtroSi.Image")));
            this.btnAgregarOtroSi.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnAgregarOtroSi.Location = new System.Drawing.Point(908, 31);
            this.btnAgregarOtroSi.Name = "btnAgregarOtroSi";
            this.btnAgregarOtroSi.Size = new System.Drawing.Size(33, 33);
            this.btnAgregarOtroSi.TabIndex = 143;
            this.btnAgregarOtroSi.Click += new System.EventHandler(this.btnAgregarOtroSi_Click);
            // 
            // btnEditInfoequipoOtroSi
            // 
            this.btnEditInfoequipoOtroSi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnEditInfoequipoOtroSi, null);
            this.balloonTip1.SetBalloonText(this.btnEditInfoequipoOtroSi, "Editar Informacion del Equipo");
            this.btnEditInfoequipoOtroSi.Image = ((System.Drawing.Image)(resources.GetObject("btnEditInfoequipoOtroSi.Image")));
            this.btnEditInfoequipoOtroSi.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnEditInfoequipoOtroSi.Location = new System.Drawing.Point(853, 280);
            this.btnEditInfoequipoOtroSi.Name = "btnEditInfoequipoOtroSi";
            this.btnEditInfoequipoOtroSi.Size = new System.Drawing.Size(33, 33);
            this.btnEditInfoequipoOtroSi.TabIndex = 160;
            this.btnEditInfoequipoOtroSi.Click += new System.EventHandler(this.btnEditInfoequipoOtroSi_Click);
            // 
            // btnCambiarEquipoOtroSi
            // 
            this.btnCambiarEquipoOtroSi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnCambiarEquipoOtroSi, null);
            this.balloonTip1.SetBalloonText(this.btnCambiarEquipoOtroSi, "Cambiar Vinculacion del Equipo por Otro Equipo");
            this.btnCambiarEquipoOtroSi.Image = ((System.Drawing.Image)(resources.GetObject("btnCambiarEquipoOtroSi.Image")));
            this.btnCambiarEquipoOtroSi.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnCambiarEquipoOtroSi.Location = new System.Drawing.Point(595, 280);
            this.btnCambiarEquipoOtroSi.Name = "btnCambiarEquipoOtroSi";
            this.btnCambiarEquipoOtroSi.Size = new System.Drawing.Size(33, 33);
            this.btnCambiarEquipoOtroSi.TabIndex = 159;
            this.btnCambiarEquipoOtroSi.Click += new System.EventHandler(this.btnCambiarEquipoOtroSi_Click);
            // 
            // btnEliminarEquipoOtroSi
            // 
            this.btnEliminarEquipoOtroSi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnEliminarEquipoOtroSi, null);
            this.balloonTip1.SetBalloonText(this.btnEliminarEquipoOtroSi, "Desvincular Equipo");
            this.btnEliminarEquipoOtroSi.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarEquipoOtroSi.Image")));
            this.btnEliminarEquipoOtroSi.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnEliminarEquipoOtroSi.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnEliminarEquipoOtroSi.Location = new System.Drawing.Point(890, 280);
            this.btnEliminarEquipoOtroSi.Name = "btnEliminarEquipoOtroSi";
            this.btnEliminarEquipoOtroSi.Size = new System.Drawing.Size(33, 33);
            this.btnEliminarEquipoOtroSi.TabIndex = 158;
            this.btnEliminarEquipoOtroSi.Click += new System.EventHandler(this.btnEliminarEquipoOtroSi_Click);
            // 
            // btnAgregarEquipoOtroSi
            // 
            this.btnAgregarEquipoOtroSi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnAgregarEquipoOtroSi, null);
            this.balloonTip1.SetBalloonText(this.btnAgregarEquipoOtroSi, "Vincular Equipo");
            this.btnAgregarEquipoOtroSi.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarEquipoOtroSi.Image")));
            this.btnAgregarEquipoOtroSi.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnAgregarEquipoOtroSi.Location = new System.Drawing.Point(814, 280);
            this.btnAgregarEquipoOtroSi.Name = "btnAgregarEquipoOtroSi";
            this.btnAgregarEquipoOtroSi.Size = new System.Drawing.Size(33, 33);
            this.btnAgregarEquipoOtroSi.TabIndex = 157;
            this.btnAgregarEquipoOtroSi.Click += new System.EventHandler(this.btnAgregarEquipoOtroSi_Click);
            // 
            // btnHojaDeVidaEOtroSi
            // 
            this.btnHojaDeVidaEOtroSi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnHojaDeVidaEOtroSi, "Hoja de Vida del Equipo");
            this.btnHojaDeVidaEOtroSi.Image = ((System.Drawing.Image)(resources.GetObject("btnHojaDeVidaEOtroSi.Image")));
            this.btnHojaDeVidaEOtroSi.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnHojaDeVidaEOtroSi.Location = new System.Drawing.Point(926, 280);
            this.btnHojaDeVidaEOtroSi.Name = "btnHojaDeVidaEOtroSi";
            this.btnHojaDeVidaEOtroSi.Size = new System.Drawing.Size(33, 33);
            this.btnHojaDeVidaEOtroSi.TabIndex = 156;
            this.btnHojaDeVidaEOtroSi.Click += new System.EventHandler(this.btnHojaDeVidaEOtroSi_Click);
            // 
            // grdEquiposOtroSi
            // 
            this.grdEquiposOtroSi.AllowColMove = false;
            this.grdEquiposOtroSi.AllowColSelect = false;
            this.grdEquiposOtroSi.AllowUpdate = false;
            this.grdEquiposOtroSi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdEquiposOtroSi.DataMember = "pltComtratoxEquipo";
            this.grdEquiposOtroSi.DataSource = this.dsPlantillasEquipoOtroSi;
            this.grdEquiposOtroSi.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdEquiposOtroSi.FilterBar = true;
            this.grdEquiposOtroSi.GroupByCaption = "";
            this.grdEquiposOtroSi.Images.Add(((System.Drawing.Image)(resources.GetObject("grdEquiposOtroSi.Images"))));
            this.grdEquiposOtroSi.Location = new System.Drawing.Point(12, 319);
            this.grdEquiposOtroSi.Name = "grdEquiposOtroSi";
            this.grdEquiposOtroSi.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdEquiposOtroSi.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdEquiposOtroSi.PreviewInfo.ZoomFactor = 75D;
            this.grdEquiposOtroSi.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdEquiposOtroSi.PrintInfo.PageSettings")));
            this.grdEquiposOtroSi.Size = new System.Drawing.Size(986, 339);
            this.grdEquiposOtroSi.TabIndex = 155;
            this.grdEquiposOtroSi.Text = "c1TrueDBGrid1";
            this.grdEquiposOtroSi.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.grdEquiposOtroSi.PropBag = resources.GetString("grdEquiposOtroSi.PropBag");
            // 
            // grdOtroSi
            // 
            this.grdOtroSi.AllowUpdate = false;
            this.grdOtroSi.DataMember = "contratos";
            this.grdOtroSi.DataSource = this.dsOtrosSi;
            this.grdOtroSi.GroupByCaption = "Drag a column header here to group by that column";
            this.grdOtroSi.Images.Add(((System.Drawing.Image)(resources.GetObject("grdOtroSi.Images"))));
            this.grdOtroSi.Location = new System.Drawing.Point(12, 19);
            this.grdOtroSi.Name = "grdOtroSi";
            this.grdOtroSi.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdOtroSi.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdOtroSi.PreviewInfo.ZoomFactor = 75D;
            this.grdOtroSi.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdOtroSi.PrintInfo.PageSettings")));
            this.grdOtroSi.Size = new System.Drawing.Size(886, 248);
            this.grdOtroSi.TabIndex = 0;
            this.grdOtroSi.Text = "c1TrueDBGrid1";
            this.grdOtroSi.RowColChange += new C1.Win.C1TrueDBGrid.RowColChangeEventHandler(this.grdOtroSi_RowColChange);
            this.grdOtroSi.PropBag = resources.GetString("grdOtroSi.PropBag");
            // 
            // tabItem3
            // 
            this.tabItem3.AttachedControl = this.tabControlPanel3;
            this.tabItem3.Name = "tabItem3";
            this.tabItem3.Text = "Anexos al Contrato (Otro SI)";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.c1GrdArchivos);
            this.tabControlPanel2.Controls.Add(this.label2);
            this.tabControlPanel2.Controls.Add(this.btnQuitarArchivo);
            this.tabControlPanel2.Controls.Add(this.btnSubirArchivo);
            this.tabControlPanel2.Controls.Add(this.btnGuardarArchivo);
            this.tabControlPanel2.Controls.Add(this.btnVerArchivo);
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(1016, 668);
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
            // c1GrdArchivos
            // 
            this.c1GrdArchivos.AllowUpdate = false;
            this.c1GrdArchivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1GrdArchivos.DataMember = "archivosxcontrato";
            this.c1GrdArchivos.DataSource = this.dsSpx1;
            this.c1GrdArchivos.GroupByCaption = "Drag a column header here to group by that column";
            this.c1GrdArchivos.Images.Add(((System.Drawing.Image)(resources.GetObject("c1GrdArchivos.Images"))));
            this.c1GrdArchivos.Location = new System.Drawing.Point(12, 40);
            this.c1GrdArchivos.Name = "c1GrdArchivos";
            this.c1GrdArchivos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1GrdArchivos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1GrdArchivos.PreviewInfo.ZoomFactor = 75D;
            this.c1GrdArchivos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1GrdArchivos.PrintInfo.PageSettings")));
            this.c1GrdArchivos.Size = new System.Drawing.Size(819, 607);
            this.c1GrdArchivos.TabIndex = 23;
            this.c1GrdArchivos.Text = "c1TrueDBGrid1";
            this.c1GrdArchivos.PropBag = resources.GetString("c1GrdArchivos.PropBag");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(9, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Archivos Asociados al Contrato";
            // 
            // btnQuitarArchivo
            // 
            this.btnQuitarArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitarArchivo.Location = new System.Drawing.Point(887, 69);
            this.btnQuitarArchivo.Name = "btnQuitarArchivo";
            this.btnQuitarArchivo.Size = new System.Drawing.Size(111, 23);
            this.btnQuitarArchivo.TabIndex = 21;
            this.btnQuitarArchivo.Text = "Quitar Archivo";
            this.btnQuitarArchivo.UseVisualStyleBackColor = true;
            this.btnQuitarArchivo.Click += new System.EventHandler(this.btnQuitarArchivo_Click);
            // 
            // btnSubirArchivo
            // 
            this.btnSubirArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubirArchivo.Location = new System.Drawing.Point(887, 40);
            this.btnSubirArchivo.Name = "btnSubirArchivo";
            this.btnSubirArchivo.Size = new System.Drawing.Size(111, 23);
            this.btnSubirArchivo.TabIndex = 20;
            this.btnSubirArchivo.Text = "Agregar Archivo";
            this.btnSubirArchivo.UseVisualStyleBackColor = true;
            this.btnSubirArchivo.Click += new System.EventHandler(this.btnSubirArchivo_Click);
            // 
            // btnGuardarArchivo
            // 
            this.btnGuardarArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarArchivo.Location = new System.Drawing.Point(887, 127);
            this.btnGuardarArchivo.Name = "btnGuardarArchivo";
            this.btnGuardarArchivo.Size = new System.Drawing.Size(111, 23);
            this.btnGuardarArchivo.TabIndex = 19;
            this.btnGuardarArchivo.Text = "Guardar Archivo";
            this.btnGuardarArchivo.UseVisualStyleBackColor = true;
            this.btnGuardarArchivo.Click += new System.EventHandler(this.btnGuardarArchivo_Click);
            // 
            // btnVerArchivo
            // 
            this.btnVerArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerArchivo.Location = new System.Drawing.Point(887, 98);
            this.btnVerArchivo.Name = "btnVerArchivo";
            this.btnVerArchivo.Size = new System.Drawing.Size(111, 23);
            this.btnVerArchivo.TabIndex = 18;
            this.btnVerArchivo.Text = "Ver Archivo";
            this.btnVerArchivo.UseVisualStyleBackColor = true;
            this.btnVerArchivo.Click += new System.EventHandler(this.btnVerArchivo_Click);
            // 
            // tabItem2
            // 
            this.tabItem2.AttachedControl = this.tabControlPanel2;
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.Text = "Archivos por Contrato";
            // 
            // tabControlPanel4
            // 
            this.tabControlPanel4.Controls.Add(this.btnExportarEquposTodos);
            this.tabControlPanel4.Controls.Add(this.grdtodosequipos);
            this.tabControlPanel4.Controls.Add(this.label1);
            this.tabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel4.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel4.Name = "tabControlPanel4";
            this.tabControlPanel4.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel4.Size = new System.Drawing.Size(1016, 668);
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
            // btnExportarEquposTodos
            // 
            this.btnExportarEquposTodos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExportarEquposTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnExportarEquposTodos, "Exportar a Excel");
            this.btnExportarEquposTodos.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarEquposTodos.Image")));
            this.btnExportarEquposTodos.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnExportarEquposTodos.Location = new System.Drawing.Point(971, 4);
            this.btnExportarEquposTodos.Name = "btnExportarEquposTodos";
            this.btnExportarEquposTodos.Size = new System.Drawing.Size(33, 33);
            this.btnExportarEquposTodos.TabIndex = 162;
            this.btnExportarEquposTodos.Click += new System.EventHandler(this.btnExportarEquposTodos_Click);
            // 
            // grdtodosequipos
            // 
            this.grdtodosequipos.AllowColMove = false;
            this.grdtodosequipos.AllowColSelect = false;
            this.grdtodosequipos.AllowUpdate = false;
            this.grdtodosequipos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdtodosequipos.DataMember = "pltComtratoxEquipo";
            this.grdtodosequipos.DataSource = this.dsPltTotales;
            this.grdtodosequipos.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdtodosequipos.FilterBar = true;
            this.grdtodosequipos.GroupByCaption = "";
            this.grdtodosequipos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdtodosequipos.Images"))));
            this.grdtodosequipos.Location = new System.Drawing.Point(18, 40);
            this.grdtodosequipos.Name = "grdtodosequipos";
            this.grdtodosequipos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdtodosequipos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdtodosequipos.PreviewInfo.ZoomFactor = 75D;
            this.grdtodosequipos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdtodosequipos.PrintInfo.PageSettings")));
            this.grdtodosequipos.Size = new System.Drawing.Size(986, 522);
            this.grdtodosequipos.TabIndex = 139;
            this.grdtodosequipos.Text = "c1TrueDBGrid1";
            this.grdtodosequipos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.grdtodosequipos.PropBag = resources.GetString("grdtodosequipos.PropBag");
            // 
            // dsPltTotales
            // 
            this.dsPltTotales.DataSetName = "dsPlantillas";
            this.dsPltTotales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 18);
            this.label1.TabIndex = 138;
            this.label1.Text = "Equipos Vinculados al Contrato";
            // 
            // tabItem4
            // 
            this.tabItem4.AttachedControl = this.tabControlPanel4;
            this.tabItem4.Name = "tabItem4";
            this.tabItem4.Text = "Equipos del Contrato";
            // 
            // tabControlPanel5
            // 
            this.tabControlPanel5.Controls.Add(this.btnExportarRepuestos);
            this.tabControlPanel5.Controls.Add(this.label4);
            this.tabControlPanel5.Controls.Add(this.grdRepuestosTodoContrato);
            this.tabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel5.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel5.Name = "tabControlPanel5";
            this.tabControlPanel5.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel5.Size = new System.Drawing.Size(1016, 668);
            this.tabControlPanel5.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel5.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel5.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel5.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel5.Style.GradientAngle = 90;
            this.tabControlPanel5.TabIndex = 5;
            this.tabControlPanel5.TabItem = this.tabItem5;
            // 
            // btnExportarRepuestos
            // 
            this.btnExportarRepuestos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExportarRepuestos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnExportarRepuestos, "Exportar a Excel");
            this.balloonTip1.SetBalloonText(this.btnExportarRepuestos, null);
            this.btnExportarRepuestos.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarRepuestos.Image")));
            this.btnExportarRepuestos.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnExportarRepuestos.Location = new System.Drawing.Point(971, 15);
            this.btnExportarRepuestos.Name = "btnExportarRepuestos";
            this.btnExportarRepuestos.Size = new System.Drawing.Size(33, 33);
            this.btnExportarRepuestos.TabIndex = 163;
            this.btnExportarRepuestos.Click += new System.EventHandler(this.btnExportarRepuestos_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 152;
            this.label4.Text = "Repuestos incluidos";
            // 
            // grdRepuestosTodoContrato
            // 
            this.grdRepuestosTodoContrato.AllowUpdate = false;
            this.grdRepuestosTodoContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdRepuestosTodoContrato.DataMember = "repuestosxContratos";
            this.grdRepuestosTodoContrato.DataSource = this.dsTotales;
            this.grdRepuestosTodoContrato.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdRepuestosTodoContrato.FilterBar = true;
            this.grdRepuestosTodoContrato.GroupByCaption = "";
            this.grdRepuestosTodoContrato.Images.Add(((System.Drawing.Image)(resources.GetObject("grdRepuestosTodoContrato.Images"))));
            this.grdRepuestosTodoContrato.Location = new System.Drawing.Point(12, 54);
            this.grdRepuestosTodoContrato.Name = "grdRepuestosTodoContrato";
            this.grdRepuestosTodoContrato.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdRepuestosTodoContrato.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdRepuestosTodoContrato.PreviewInfo.ZoomFactor = 75D;
            this.grdRepuestosTodoContrato.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdRepuestosTodoContrato.PrintInfo.PageSettings")));
            this.grdRepuestosTodoContrato.Size = new System.Drawing.Size(992, 593);
            this.grdRepuestosTodoContrato.TabIndex = 151;
            this.grdRepuestosTodoContrato.Text = "c1TrueDBGrid1";
            this.grdRepuestosTodoContrato.PropBag = resources.GetString("grdRepuestosTodoContrato.PropBag");
            // 
            // dsTotales
            // 
            this.dsTotales.DataSetName = "dsSpx";
            this.dsTotales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabItem5
            // 
            this.tabItem5.AttachedControl = this.tabControlPanel5;
            this.tabItem5.Name = "tabItem5";
            this.tabItem5.Text = "Repuestos del Contrato";
            // 
            // mantenimientosxContratoTableAdapter1
            // 
            this.mantenimientosxContratoTableAdapter1.ClearBeforeFill = true;
            // 
            // modalidadContratoTableAdapter1
            // 
            this.modalidadContratoTableAdapter1.ClearBeforeFill = true;
            // 
            // repuestosxContratosTableAdapter1
            // 
            this.repuestosxContratosTableAdapter1.ClearBeforeFill = true;
            // 
            // pltFechaSistemaTableAdapter1
            // 
            this.pltFechaSistemaTableAdapter1.ClearBeforeFill = true;
            // 
            // pltComtratoxEquipoTableAdapter1
            // 
            this.pltComtratoxEquipoTableAdapter1.ClearBeforeFill = true;
            // 
            // tabItem6
            // 
            this.tabItem6.AttachedControl = this.tabControlPanel6;
            this.tabItem6.Name = "tabItem6";
            this.tabItem6.Text = "Vinculaciones / Desvinculaciones";
            // 
            // tabControlPanel6
            // 
            this.tabControlPanel6.Controls.Add(this.grdVinculaciones);
            this.tabControlPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel6.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel6.Name = "tabControlPanel6";
            this.tabControlPanel6.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel6.Size = new System.Drawing.Size(1016, 668);
            this.tabControlPanel6.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel6.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel6.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel6.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel6.Style.GradientAngle = 90;
            this.tabControlPanel6.TabIndex = 6;
            this.tabControlPanel6.TabItem = this.tabItem6;
            // 
            // grdVinculaciones
            // 
            this.grdVinculaciones.GroupByCaption = "Drag a column header here to group by that column";
            this.grdVinculaciones.Images.Add(((System.Drawing.Image)(resources.GetObject("grdVinculaciones.Images"))));
            this.grdVinculaciones.Location = new System.Drawing.Point(12, 35);
            this.grdVinculaciones.Name = "grdVinculaciones";
            this.grdVinculaciones.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdVinculaciones.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdVinculaciones.PreviewInfo.ZoomFactor = 75D;
            this.grdVinculaciones.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings")));
            this.grdVinculaciones.Size = new System.Drawing.Size(983, 612);
            this.grdVinculaciones.TabIndex = 0;
            this.grdVinculaciones.Text = "c1TrueDBGrid1";
            this.grdVinculaciones.PropBag = resources.GetString("grdVinculaciones.PropBag");
            // 
            // frmNuevoContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1016, 694);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNuevoContrato";
            this.Text = "Nuevo Contrato";
            this.Load += new System.EventHandler(this.frmNuevoContrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).EndInit();
            this.grpMantenimiento.ResumeLayout(false);
            this.grpMantenimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTopeCorrectivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRepuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiasHabiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMantenimientosIncluidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMesesEntreMantenimientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmHorasHabiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPorcentajePrecioTiquetes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calCreacion)).EndInit();
            this.grpConsumo.ResumeLayout(false);
            this.grpConsumo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calInicioContrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFinContrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEquipos)).EndInit();
            this.tabControlPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillasEquipoOtroSi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TipoContrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOtrosSi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CmbModalidadContrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEquiposOtroSi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOtroSi)).EndInit();
            this.tabControlPanel2.ResumeLayout(false);
            this.tabControlPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1GrdArchivos)).EndInit();
            this.tabControlPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdtodosequipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPltTotales)).EndInit();
            this.tabControlPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdRepuestosTodoContrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTotales)).EndInit();
            this.tabControlPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdVinculaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.tipoContratoTableAdapter tipoContratoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.contratosTableAdapter contratosTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.archivosxcontratoTableAdapter archivosxcontratoTableAdapter1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private SPControladoraDatos.dsSpxTableAdapters.clientesTableAdapter clientesTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.contratosxEquipoTableAdapter contratosxEquipoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter equiposTableAdapter1;
        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.TabItem tabItem2;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.ButtonX btnImprimir;
        private DevComponents.DotNetBar.ButtonX btnCancelar;
        private DevComponents.DotNetBar.ButtonX btnGuardar;
        private System.Windows.Forms.NumericUpDown nmMesesEntreMantenimientos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpConsumo;
        private System.Windows.Forms.CheckBox chkTienePoliza;
        private System.Windows.Forms.RadioButton rdConsumoxLinea;
        private System.Windows.Forms.RadioButton rdconsumoMinimoGeneral;
        private System.Windows.Forms.TextBox txtConsumoMinimo;
        private System.Windows.Forms.NumericUpDown nmMantenimientosIncluidos;
        private System.Windows.Forms.TextBox txtNroContrato;
        private System.Windows.Forms.TextBox txtObervaciones;
        private System.Windows.Forms.CheckBox chkIncluyeRepuestos;
        private System.Windows.Forms.CheckBox chkIncluyeTiquetes;
        private System.Windows.Forms.ComboBox cmbModalidadContrato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpiarCliente;
        private DevComponents.DotNetBar.ButtonX btnBuscarNit;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nmPorcentajePrecioTiquetes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nmDiasHabiles;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nmHorasHabiles;
        private System.Windows.Forms.Label label15;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFinContrato;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calInicioContrato;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1GrdArchivos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuitarArchivo;
        private System.Windows.Forms.Button btnSubirArchivo;
        private System.Windows.Forms.Button btnGuardarArchivo;
        private System.Windows.Forms.Button btnVerArchivo;
        private System.Windows.Forms.Label label16;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdEquipos;
        private DevComponents.DotNetBar.ButtonX btnInfEquipo;
        private DevComponents.DotNetBar.ButtonX btnDesvincularEquipo;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private DevComponents.DotNetBar.ButtonX btnVincularEquipo;
        private DevComponents.DotNetBar.ButtonX btnCambiarContrato;
        private SPControladoraDatos.dsSpxTableAdapters.mantenimientosxContratoTableAdapter mantenimientosxContratoTableAdapter1;
        private System.Windows.Forms.TextBox txtConsumoxLinea;
        private System.Windows.Forms.ComboBox cmbTipoContrato;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtMontoContrato;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox grpMantenimiento;
        private DevComponents.DotNetBar.ButtonX btnDesvincularRepuesto;
        private DevComponents.DotNetBar.ButtonX btnAgregarRepuestos;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdRepuestos;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel3;
        private DevComponents.DotNetBar.TabItem tabItem3;
        private SPControladoraDatos.dsSpxTableAdapters.modalidadContratoTableAdapter modalidadContratoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.repuestosxContratosTableAdapter repuestosxContratosTableAdapter1;
        private DevComponents.DotNetBar.ButtonX btnModificarRepuesto;
        private DevComponents.DotNetBar.ButtonX btnEditarInfoEquipo;
         private SPControladoraDatos.dsPlantillas dsPlantillas1;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdOtroSi;
        private DevComponents.DotNetBar.ButtonX btnEditOtroSi;
        private DevComponents.DotNetBar.ButtonX btnEliminarOtroSi;
        private DevComponents.DotNetBar.ButtonX btnAgregarOtroSi;
        private DevComponents.DotNetBar.ButtonX btnEditInfoequipoOtroSi;
        private DevComponents.DotNetBar.ButtonX btnCambiarEquipoOtroSi;
        private DevComponents.DotNetBar.ButtonX btnEliminarEquipoOtroSi;
        private DevComponents.DotNetBar.ButtonX btnAgregarEquipoOtroSi;
        private DevComponents.DotNetBar.ButtonX btnHojaDeVidaEOtroSi;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdEquiposOtroSi;
        private SPControladoraDatos.dsSpx dsOtrosSi;
        private DevComponents.DotNetBar.ButtonX btnExportarEquiposOtro;
        private SPControladoraDatos.dsPlantillas dsPlantillasEquipoOtroSi;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel4;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdtodosequipos;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.TabItem tabItem4;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel5;
        private System.Windows.Forms.Label label4;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdRepuestosTodoContrato;
        private DevComponents.DotNetBar.TabItem tabItem5;
        private SPControladoraDatos.dsSpx dsTotales;
        private SPControladoraDatos.dsPlantillas dsPltTotales;
        private C1.Win.C1TrueDBGrid.C1TrueDBDropdown c1TipoContrato;
        private C1.Win.C1TrueDBGrid.C1TrueDBDropdown c1CmbModalidadContrato;
        private DevComponents.DotNetBar.ButtonX btnExportarRepuestos;
        private DevComponents.DotNetBar.ButtonX btnExportarEquposTodos;
        private System.Windows.Forms.Label label5;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calCreacion;
        private SPControladoraDatos.dsPlantillasTableAdapters.pltFechaSistemaTableAdapter pltFechaSistemaTableAdapter1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.NumericUpDown nmTopeCorrectivos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkIncluyeCorrectivos;
        private DevComponents.DotNetBar.ButtonX btnDesvincularOden;
        private DevComponents.DotNetBar.ButtonX btnVincularOrden;
        private SPControladoraDatos.dsPlantillasTableAdapters.pltComtratoxEquipoTableAdapter pltComtratoxEquipoTableAdapter1;
        private DevComponents.DotNetBar.ButtonX btnDesvincularOrdenOtroSi;
        private DevComponents.DotNetBar.ButtonX btnVincularOrdenOtroSi;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblSerialOtroSi;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel6;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdVinculaciones;
        private DevComponents.DotNetBar.TabItem tabItem6;
    }
}