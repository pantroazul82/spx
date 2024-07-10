using SPControladoraDatos.artefactos.SPXUtilidades.Controles;

namespace spHerramientas.consultas
{
    partial class frmSeguimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeguimiento));
            this.grdDatos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuitarFiltro4 = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregarFilrto3 = new DevComponents.DotNetBar.ButtonX();
            this.btnQuitarFiltro3 = new DevComponents.DotNetBar.ButtonX();
            this.txtFiltro4 = new System.Windows.Forms.TextBox();
            this.cmbFiltro4 = new System.Windows.Forms.ComboBox();
            this.btnAgregarFiltro2 = new DevComponents.DotNetBar.ButtonX();
            this.txtFiltro3 = new System.Windows.Forms.TextBox();
            this.cmbFiltro3 = new System.Windows.Forms.ComboBox();
            this.txtFiltro2 = new System.Windows.Forms.TextBox();
            this.cmbFiltro2 = new System.Windows.Forms.ComboBox();
            this.btnQuitarFiltro2 = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregarFiltro1 = new DevComponents.DotNetBar.ButtonX();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btnExportarExcel = new DevComponents.DotNetBar.ButtonX();
            this.cmbMeses = new System.Windows.Forms.ComboBox();
            this.btnCalendario = new DevComponents.DotNetBar.ButtonX();
            this.btnInfEquipo = new DevComponents.DotNetBar.ButtonX();
            this.btnBuscarSerial = new DevComponents.DotNetBar.ButtonX();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.btnAsignarTipoPropiedad = new DevComponents.DotNetBar.ButtonX();
            this.btnAsignarResponsable = new DevComponents.DotNetBar.ButtonX();
            this.cmbOrden = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cmbAno = new System.Windows.Forms.ComboBox();
            this.controladorColumnas1 = new controladorColumnas();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.chkTop = new System.Windows.Forms.CheckBox();
            this.nmTop = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTop)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUpdate = false;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdDatos.FilterBar = true;
            this.grdDatos.GroupByCaption = "";
            this.grdDatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDatos.Images"))));
            this.grdDatos.Location = new System.Drawing.Point(12, 180);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75D;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(772, 295);
            this.grdDatos.TabIndex = 0;
            this.grdDatos.Text = "c1TrueDBGrid1";
            this.grdDatos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.System;
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
            // 
            // cmbCampo
            // 
            this.cmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampo.FormattingEnabled = true;
            this.cmbCampo.Items.AddRange(new object[] {
            "Serial",
            "Nit Cliente",
            "Socio de Negocio",
            "Nombre Cliente",
            "Fabricante",
            "Modelo",
            "Modalidad",
            "Sub Tipo de Equipo",
            "Tipo de Equipo",
            "Tipo de Propiedad"});
            this.cmbCampo.Location = new System.Drawing.Point(7, 15);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(157, 21);
            this.cmbCampo.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.btnQuitarFiltro4);
            this.groupBox1.Controls.Add(this.btnAgregarFilrto3);
            this.groupBox1.Controls.Add(this.btnQuitarFiltro3);
            this.groupBox1.Controls.Add(this.txtFiltro4);
            this.groupBox1.Controls.Add(this.cmbFiltro4);
            this.groupBox1.Controls.Add(this.btnAgregarFiltro2);
            this.groupBox1.Controls.Add(this.txtFiltro3);
            this.groupBox1.Controls.Add(this.cmbFiltro3);
            this.groupBox1.Controls.Add(this.txtFiltro2);
            this.groupBox1.Controls.Add(this.cmbFiltro2);
            this.groupBox1.Controls.Add(this.btnQuitarFiltro2);
            this.groupBox1.Controls.Add(this.btnAgregarFiltro1);
            this.groupBox1.Controls.Add(this.txtFiltro);
            this.groupBox1.Controls.Add(this.cmbCampo);
            this.groupBox1.Location = new System.Drawing.Point(10, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 132);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnQuitarFiltro4
            // 
            this.btnQuitarFiltro4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnQuitarFiltro4, "Quitar Filtro");
            this.btnQuitarFiltro4.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitarFiltro4.Image")));
            this.btnQuitarFiltro4.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnQuitarFiltro4.Location = new System.Drawing.Point(393, 104);
            this.btnQuitarFiltro4.Name = "btnQuitarFiltro4";
            this.btnQuitarFiltro4.Size = new System.Drawing.Size(25, 25);
            this.btnQuitarFiltro4.TabIndex = 84;
            this.btnQuitarFiltro4.Visible = false;
            this.btnQuitarFiltro4.Click += new System.EventHandler(this.btnQuitarFiltro4_Click);
            // 
            // btnAgregarFilrto3
            // 
            this.btnAgregarFilrto3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnAgregarFilrto3, "Agregar Filtro");
            this.btnAgregarFilrto3.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarFilrto3.Image")));
            this.btnAgregarFilrto3.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnAgregarFilrto3.Location = new System.Drawing.Point(393, 73);
            this.btnAgregarFilrto3.Name = "btnAgregarFilrto3";
            this.btnAgregarFilrto3.Size = new System.Drawing.Size(25, 25);
            this.btnAgregarFilrto3.TabIndex = 83;
            this.btnAgregarFilrto3.Visible = false;
            this.btnAgregarFilrto3.Click += new System.EventHandler(this.btnAgregarFilrto3_Click);
            // 
            // btnQuitarFiltro3
            // 
            this.btnQuitarFiltro3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnQuitarFiltro3, "Quitar Filtro");
            this.btnQuitarFiltro3.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitarFiltro3.Image")));
            this.btnQuitarFiltro3.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnQuitarFiltro3.Location = new System.Drawing.Point(424, 73);
            this.btnQuitarFiltro3.Name = "btnQuitarFiltro3";
            this.btnQuitarFiltro3.Size = new System.Drawing.Size(25, 25);
            this.btnQuitarFiltro3.TabIndex = 82;
            this.btnQuitarFiltro3.Visible = false;
            this.btnQuitarFiltro3.Click += new System.EventHandler(this.btnQuitarFiltro3_Click);
            // 
            // txtFiltro4
            // 
            this.txtFiltro4.Location = new System.Drawing.Point(170, 104);
            this.txtFiltro4.Name = "txtFiltro4";
            this.txtFiltro4.Size = new System.Drawing.Size(220, 20);
            this.txtFiltro4.TabIndex = 81;
            this.txtFiltro4.Visible = false;
            this.txtFiltro4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFiltro_KeyDown);
            // 
            // cmbFiltro4
            // 
            this.cmbFiltro4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro4.FormattingEnabled = true;
            this.cmbFiltro4.Items.AddRange(new object[] {
            "Serial",
            "Nit Cliente",
            "Socio de Negocio",
            "Nombre Cliente",
            "Fabricante",
            "Modelo",
            "Modalidad",
            "Sub Tipo de Equipo",
            "Tipo de Equipo",
            "Tipo de Propiedad"});
            this.cmbFiltro4.Location = new System.Drawing.Point(7, 104);
            this.cmbFiltro4.Name = "cmbFiltro4";
            this.cmbFiltro4.Size = new System.Drawing.Size(157, 21);
            this.cmbFiltro4.TabIndex = 80;
            this.cmbFiltro4.Visible = false;
            // 
            // btnAgregarFiltro2
            // 
            this.btnAgregarFiltro2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnAgregarFiltro2, "Agregar Filtro");
            this.btnAgregarFiltro2.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarFiltro2.Image")));
            this.btnAgregarFiltro2.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnAgregarFiltro2.Location = new System.Drawing.Point(393, 42);
            this.btnAgregarFiltro2.Name = "btnAgregarFiltro2";
            this.btnAgregarFiltro2.Size = new System.Drawing.Size(25, 25);
            this.btnAgregarFiltro2.TabIndex = 78;
            this.btnAgregarFiltro2.Visible = false;
            this.btnAgregarFiltro2.Click += new System.EventHandler(this.btnAgregarFiltro2_Click);
            // 
            // txtFiltro3
            // 
            this.txtFiltro3.Location = new System.Drawing.Point(170, 73);
            this.txtFiltro3.Name = "txtFiltro3";
            this.txtFiltro3.Size = new System.Drawing.Size(220, 20);
            this.txtFiltro3.TabIndex = 77;
            this.txtFiltro3.Visible = false;
            this.txtFiltro3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFiltro_KeyDown);
            // 
            // cmbFiltro3
            // 
            this.cmbFiltro3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro3.FormattingEnabled = true;
            this.cmbFiltro3.Items.AddRange(new object[] {
            "Serial",
            "Nit Cliente",
            "Socio de Negocio",
            "Nombre Cliente",
            "Fabricante",
            "Modelo",
            "Modalidad",
            "Sub Tipo de Equipo",
            "Tipo de Equipo",
            "Tipo de Propiedad"});
            this.cmbFiltro3.Location = new System.Drawing.Point(7, 73);
            this.cmbFiltro3.Name = "cmbFiltro3";
            this.cmbFiltro3.Size = new System.Drawing.Size(157, 21);
            this.cmbFiltro3.TabIndex = 76;
            this.cmbFiltro3.Visible = false;
            // 
            // txtFiltro2
            // 
            this.txtFiltro2.Location = new System.Drawing.Point(170, 42);
            this.txtFiltro2.Name = "txtFiltro2";
            this.txtFiltro2.Size = new System.Drawing.Size(220, 20);
            this.txtFiltro2.TabIndex = 75;
            this.txtFiltro2.Visible = false;
            this.txtFiltro2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFiltro_KeyDown);
            // 
            // cmbFiltro2
            // 
            this.cmbFiltro2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro2.FormattingEnabled = true;
            this.cmbFiltro2.Items.AddRange(new object[] {
            "Serial",
            "Nit Cliente",
            "Socio de Negocio",
            "Nombre Cliente",
            "Fabricante",
            "Modelo",
            "Modalidad",
            "Sub Tipo de Equipo",
            "Tipo de Equipo",
            "Tipo de Propiedad"});
            this.cmbFiltro2.Location = new System.Drawing.Point(7, 42);
            this.cmbFiltro2.Name = "cmbFiltro2";
            this.cmbFiltro2.Size = new System.Drawing.Size(157, 21);
            this.cmbFiltro2.TabIndex = 74;
            this.cmbFiltro2.Visible = false;
            // 
            // btnQuitarFiltro2
            // 
            this.btnQuitarFiltro2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnQuitarFiltro2, "Quitar Filtro");
            this.btnQuitarFiltro2.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitarFiltro2.Image")));
            this.btnQuitarFiltro2.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnQuitarFiltro2.Location = new System.Drawing.Point(424, 42);
            this.btnQuitarFiltro2.Name = "btnQuitarFiltro2";
            this.btnQuitarFiltro2.Size = new System.Drawing.Size(25, 25);
            this.btnQuitarFiltro2.TabIndex = 73;
            this.btnQuitarFiltro2.Visible = false;
            this.btnQuitarFiltro2.Click += new System.EventHandler(this.btnQuitarFiltro2_Click);
            // 
            // btnAgregarFiltro1
            // 
            this.btnAgregarFiltro1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnAgregarFiltro1, "Agregar Filtro");
            this.btnAgregarFiltro1.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarFiltro1.Image")));
            this.btnAgregarFiltro1.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnAgregarFiltro1.Location = new System.Drawing.Point(393, 11);
            this.btnAgregarFiltro1.Name = "btnAgregarFiltro1";
            this.btnAgregarFiltro1.Size = new System.Drawing.Size(25, 25);
            this.btnAgregarFiltro1.TabIndex = 72;
            this.btnAgregarFiltro1.Click += new System.EventHandler(this.btnAgregarFiltro1_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(170, 15);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(220, 20);
            this.txtFiltro.TabIndex = 5;
            this.txtFiltro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFiltro_KeyDown);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnBuscar, "Buscar");
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnBuscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBuscar.Location = new System.Drawing.Point(434, 141);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(33, 33);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.buttonX1, "Configurar Campos");
            this.buttonX1.Image = ((System.Drawing.Image)(resources.GetObject("buttonX1.Image")));
            this.buttonX1.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.buttonX1.Location = new System.Drawing.Point(751, 141);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(33, 33);
            this.buttonX1.TabIndex = 7;
            this.buttonX1.Text = " ";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExportarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnExportarExcel, "Exportar Excel");
            this.btnExportarExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarExcel.Image")));
            this.btnExportarExcel.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnExportarExcel.Location = new System.Drawing.Point(678, 141);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(33, 33);
            this.btnExportarExcel.TabIndex = 9;
            this.btnExportarExcel.Text = " ";
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // cmbMeses
            // 
            this.cmbMeses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeses.FormattingEnabled = true;
            this.cmbMeses.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmbMeses.Location = new System.Drawing.Point(480, 11);
            this.cmbMeses.Name = "cmbMeses";
            this.cmbMeses.Size = new System.Drawing.Size(175, 21);
            this.cmbMeses.TabIndex = 12;
            // 
            // btnCalendario
            // 
            this.btnCalendario.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCalendario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalendario.Image = ((System.Drawing.Image)(resources.GetObject("btnCalendario.Image")));
            this.btnCalendario.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnCalendario.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCalendario.Location = new System.Drawing.Point(665, 11);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(119, 57);
            this.btnCalendario.TabIndex = 13;
            this.btnCalendario.Text = "Mantenimientos x Mes";
            this.btnCalendario.Click += new System.EventHandler(this.btnCalendario_Click);
            // 
            // btnInfEquipo
            // 
            this.btnInfEquipo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnInfEquipo, "Hoja de Vida del Equipo");
            this.btnInfEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfEquipo.Image")));
            this.btnInfEquipo.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnInfEquipo.Location = new System.Drawing.Point(12, 141);
            this.btnInfEquipo.Name = "btnInfEquipo";
            this.btnInfEquipo.Size = new System.Drawing.Size(33, 33);
            this.btnInfEquipo.TabIndex = 68;
            this.btnInfEquipo.Click += new System.EventHandler(this.btnInfEquipo_Click);
            // 
            // btnBuscarSerial
            // 
            this.btnBuscarSerial.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnBuscarSerial, "Ver Equipo");
            this.btnBuscarSerial.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarSerial.Image")));
            this.btnBuscarSerial.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnBuscarSerial.Location = new System.Drawing.Point(47, 141);
            this.btnBuscarSerial.Name = "btnBuscarSerial";
            this.btnBuscarSerial.Size = new System.Drawing.Size(33, 33);
            this.btnBuscarSerial.TabIndex = 69;
            this.btnBuscarSerial.Click += new System.EventHandler(this.btnBuscarSerial_Click);
            // 
            // btnAsignarTipoPropiedad
            // 
            this.btnAsignarTipoPropiedad.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnAsignarTipoPropiedad, "Ver Equipo");
            this.btnAsignarTipoPropiedad.Image = ((System.Drawing.Image)(resources.GetObject("btnAsignarTipoPropiedad.Image")));
            this.btnAsignarTipoPropiedad.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnAsignarTipoPropiedad.Location = new System.Drawing.Point(83, 141);
            this.btnAsignarTipoPropiedad.Name = "btnAsignarTipoPropiedad";
            this.btnAsignarTipoPropiedad.Size = new System.Drawing.Size(103, 33);
            this.btnAsignarTipoPropiedad.TabIndex = 87;
            this.btnAsignarTipoPropiedad.Text = "Asignar Tipo Propiedad";
            this.btnAsignarTipoPropiedad.Click += new System.EventHandler(this.btnAsignarTipoPropiedad_Click);
            // 
            // btnAsignarResponsable
            // 
            this.btnAsignarResponsable.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnAsignarResponsable, "Asignar Responsable");
            this.btnAsignarResponsable.Image = ((System.Drawing.Image)(resources.GetObject("btnAsignarResponsable.Image")));
            this.btnAsignarResponsable.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnAsignarResponsable.Location = new System.Drawing.Point(192, 142);
            this.btnAsignarResponsable.Name = "btnAsignarResponsable";
            this.btnAsignarResponsable.Size = new System.Drawing.Size(113, 33);
            this.btnAsignarResponsable.TabIndex = 88;
            this.btnAsignarResponsable.Text = "Asignar Ultimo Responsable";
            this.btnAsignarResponsable.Click += new System.EventHandler(this.btnAsignarResponsable_Click);
            // 
            // cmbOrden
            // 
            this.cmbOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrden.FormattingEnabled = true;
            this.cmbOrden.Items.AddRange(new object[] {
            "Serial",
            "Nit Cliente",
            "Nombre Cliente",
            "Fabricante",
            "Modelo",
            "Modalidad",
            "Sub Tipo de Equipo",
            "Tipo de Equipo"});
            this.cmbOrden.Location = new System.Drawing.Point(309, 153);
            this.cmbOrden.Name = "cmbOrden";
            this.cmbOrden.Size = new System.Drawing.Size(119, 21);
            this.cmbOrden.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "Ordenar";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(612, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "Registros";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Location = new System.Drawing.Point(684, 115);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 84;
            // 
            // cmbAno
            // 
            this.cmbAno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAno.FormattingEnabled = true;
            this.cmbAno.Items.AddRange(new object[] {
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040"});
            this.cmbAno.Location = new System.Drawing.Point(480, 38);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(175, 21);
            this.cmbAno.TabIndex = 85;
            // 
            // controladorColumnas1
            // 
            this.controladorColumnas1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controladorColumnas1.BackColor = System.Drawing.Color.Transparent;
            this.controladorColumnas1.grilla = null;
            this.controladorColumnas1.Location = new System.Drawing.Point(534, 141);
            this.controladorColumnas1.MostrarContraer = true;
            this.controladorColumnas1.MostrarExcel = false;
            this.controladorColumnas1.MostrarExpandir = true;
            this.controladorColumnas1.MostrarLimpiar = true;
            this.controladorColumnas1.Name = "controladorColumnas1";
            this.controladorColumnas1.nombreLibro = null;
            this.controladorColumnas1.Size = new System.Drawing.Size(215, 34);
            this.controladorColumnas1.TabIndex = 86;
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.EnforceConstraints = false;
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chkTop
            // 
            this.chkTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTop.AutoSize = true;
            this.chkTop.Checked = true;
            this.chkTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTop.Location = new System.Drawing.Point(512, 89);
            this.chkTop.Name = "chkTop";
            this.chkTop.Size = new System.Drawing.Size(131, 17);
            this.chkTop.TabIndex = 89;
            this.chkTop.Text = "Traer solo los primeros";
            this.chkTop.UseVisualStyleBackColor = true;
            // 
            // nmTop
            // 
            this.nmTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nmTop.Location = new System.Drawing.Point(649, 89);
            this.nmTop.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nmTop.Name = "nmTop";
            this.nmTop.Size = new System.Drawing.Size(79, 20);
            this.nmTop.TabIndex = 90;
            this.nmTop.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(733, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 91;
            this.label3.Text = "Registros";
            // 
            // frmSeguimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(796, 483);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmTop);
            this.Controls.Add(this.chkTop);
            this.Controls.Add(this.btnAsignarResponsable);
            this.Controls.Add(this.btnAsignarTipoPropiedad);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.controladorColumnas1);
            this.Controls.Add(this.cmbAno);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOrden);
            this.Controls.Add(this.btnBuscarSerial);
            this.Controls.Add(this.btnInfEquipo);
            this.Controls.Add(this.btnCalendario);
            this.Controls.Add(this.cmbMeses);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdDatos);
            this.Controls.Add(this.btnBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSeguimiento";
            this.Text = "Seguimiento";
            this.Load += new System.EventHandler(this.frmSeguimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdDatos;
        private System.Windows.Forms.ComboBox cmbCampo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFiltro;
        private SPControladoraDatos.dsSpx dsSpx1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX btnBuscar;
        private DevComponents.DotNetBar.ButtonX btnExportarExcel;
        private System.Windows.Forms.ComboBox cmbMeses;
        private DevComponents.DotNetBar.ButtonX btnCalendario;
        private DevComponents.DotNetBar.ButtonX btnInfEquipo;
        private DevComponents.DotNetBar.ButtonX btnBuscarSerial;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private System.Windows.Forms.TextBox txtFiltro4;
        private System.Windows.Forms.ComboBox cmbFiltro4;
        private DevComponents.DotNetBar.ButtonX btnAgregarFiltro2;
        private System.Windows.Forms.TextBox txtFiltro3;
        private System.Windows.Forms.ComboBox cmbFiltro3;
        private System.Windows.Forms.TextBox txtFiltro2;
        private System.Windows.Forms.ComboBox cmbFiltro2;
        private DevComponents.DotNetBar.ButtonX btnQuitarFiltro2;
        private DevComponents.DotNetBar.ButtonX btnAgregarFiltro1;
        private DevComponents.DotNetBar.ButtonX btnQuitarFiltro4;
        private DevComponents.DotNetBar.ButtonX btnAgregarFilrto3;
        private DevComponents.DotNetBar.ButtonX btnQuitarFiltro3;
        private System.Windows.Forms.ComboBox cmbOrden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox cmbAno;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas controladorColumnas1;
        private DevComponents.DotNetBar.ButtonX btnAsignarTipoPropiedad;
        private DevComponents.DotNetBar.ButtonX btnAsignarResponsable;
        private System.Windows.Forms.CheckBox chkTop;
        private System.Windows.Forms.NumericUpDown nmTop;
        private System.Windows.Forms.Label label3;
    }
}