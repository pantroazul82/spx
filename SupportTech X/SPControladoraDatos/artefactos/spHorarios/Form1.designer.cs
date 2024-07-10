using SPControladoraDatos.artefactos.SPXUtilidades.Controles;

namespace spHorarios
{
    partial class Form1
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
            C1.C1Schedule.Printing.PrintStyle printStyle11 = new C1.C1Schedule.Printing.PrintStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            C1.C1Schedule.Printing.PrintStyle printStyle12 = new C1.C1Schedule.Printing.PrintStyle();
            C1.C1Schedule.Printing.PrintStyle printStyle13 = new C1.C1Schedule.Printing.PrintStyle();
            C1.C1Schedule.Printing.PrintStyle printStyle14 = new C1.C1Schedule.Printing.PrintStyle();
            C1.C1Schedule.Printing.PrintStyle printStyle15 = new C1.C1Schedule.Printing.PrintStyle();
            C1.C1Schedule.Printing.PrintStyle printStyle1 = new C1.C1Schedule.Printing.PrintStyle();
            C1.C1Schedule.Printing.PrintStyle printStyle2 = new C1.C1Schedule.Printing.PrintStyle();
            C1.C1Schedule.Printing.PrintStyle printStyle3 = new C1.C1Schedule.Printing.PrintStyle();
            C1.C1Schedule.Printing.PrintStyle printStyle4 = new C1.C1Schedule.Printing.PrintStyle();
            C1.C1Schedule.Printing.PrintStyle printStyle5 = new C1.C1Schedule.Printing.PrintStyle();
            this.tabEntradas = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel3 = new DevComponents.DotNetBar.TabControlPanel();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.btnVerLlamada = new DevComponents.DotNetBar.ButtonX();
            this.controladorColumnasListadoLlamadas1 = new controladorColumnas();
            this.controladorColumnasSeguimientoLlamadas = new controladorColumnas();
            this.btnVerSeguimientoLlamada = new DevComponents.DotNetBar.ButtonX();
            this.calListadoLlamadas = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grdSeguimientosProgramados = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.grdLlamadas = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsPlantillas1 = new SPControladoraDatos.dsPlantillas();
            this.tabLlamadas = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.calendario = new C1.Win.C1Schedule.C1Schedule();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnExcelMis1 = new DevComponents.DotNetBar.ButtonX();
            this.btnGuardarGrdRespuesta = new DevComponents.DotNetBar.ButtonX();
            this.btnRestaurargrdRespuestas = new DevComponents.DotNetBar.ButtonX();
            this.btnGuardargrdAsignadas = new DevComponents.DotNetBar.ButtonX();
            this.btnReinicciargrdasignadas = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNivel3 = new System.Windows.Forms.Label();
            this.btnEsquemaColores = new DevComponents.DotNetBar.ButtonX();
            this.lblNivel2 = new System.Windows.Forms.Label();
            this.picnivel3 = new System.Windows.Forms.PictureBox();
            this.picNivel1 = new System.Windows.Forms.PictureBox();
            this.picNivel2 = new System.Windows.Forms.PictureBox();
            this.picEnespera = new System.Windows.Forms.PictureBox();
            this.picPrioridadAlta = new System.Windows.Forms.PictureBox();
            this.lblNivel1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.grdASignadas = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsMisOrdenes = new SPControladoraDatos.dsPlantillas();
            this.lblIngeniero = new System.Windows.Forms.Label();
            this.c1Calendar1 = new C1.Win.C1Schedule.C1Calendar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdRespuesta = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsMisOrdenesEnEspera = new SPControladoraDatos.dsPlantillas();
            this.btnActualizar = new DevComponents.DotNetBar.ButtonX();
            this.btnHoy = new DevComponents.DotNetBar.ButtonX();
            this.btn30 = new DevComponents.DotNetBar.ButtonX();
            this.btn7 = new DevComponents.DotNetBar.ButtonX();
            this.btn5 = new DevComponents.DotNetBar.ButtonX();
            this.btnDia = new DevComponents.DotNetBar.ButtonX();
            this.tabMisActividades = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.calendarioIngeniero = new C1.Win.C1Schedule.C1Schedule();
            this.contextMenuIngeniero = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dsPlantillasIngenieros = new SPControladoraDatos.dsPlantillas();
            this.btnMisASignadasHorario = new DevComponents.DotNetBar.ButtonX();
            this.btnGuardarGrdIngEspRespuesta = new DevComponents.DotNetBar.ButtonX();
            this.btnRestaurarGrdIngEspRespuesta = new DevComponents.DotNetBar.ButtonX();
            this.btnGuardarGrdIngAsignadas = new DevComponents.DotNetBar.ButtonX();
            this.btnRestaurarGrdOrdenesINg = new DevComponents.DotNetBar.ButtonX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNivel3b = new System.Windows.Forms.Label();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.lblnivel2b = new System.Windows.Forms.Label();
            this.picNivel3b = new System.Windows.Forms.PictureBox();
            this.picNivel1b = new System.Windows.Forms.PictureBox();
            this.picNivel2b = new System.Windows.Forms.PictureBox();
            this.picEnEsperab = new System.Windows.Forms.PictureBox();
            this.picPrioridadAltab = new System.Windows.Forms.PictureBox();
            this.lblNivel1b = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbIngenieros = new System.Windows.Forms.ComboBox();
            this.dsSPXSeguridad1 = new SPXSeguridad.data.dsSPXSeguridad();
            this.c1CalendarIng = new C1.Win.C1Schedule.C1Calendar();
            this.grdOrdenesIngeniero = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsOrdenesIngeniero = new SPControladoraDatos.dsPlantillas();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grdOrdenesIngenieroEspRespuesta = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsOrdenesIngenieroEnEspera = new SPControladoraDatos.dsPlantillas();
            this.btnActualizarIngeniero = new DevComponents.DotNetBar.ButtonX();
            this.btnHoyIngeniero = new DevComponents.DotNetBar.ButtonX();
            this.btn30Ing = new DevComponents.DotNetBar.ButtonX();
            this.btn7Ing = new DevComponents.DotNetBar.ButtonX();
            this.btn5ing = new DevComponents.DotNetBar.ButtonX();
            this.btnDiaIng = new DevComponents.DotNetBar.ButtonX();
            this.tabActividadesIng = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel5 = new DevComponents.DotNetBar.TabControlPanel();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.grdEntradasSinSeguimiento = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.grdEntradasSinSalida = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.btnVerEntradaSinSeguimiento = new DevComponents.DotNetBar.ButtonX();
            this.btnVerEntradaSinSalida = new DevComponents.DotNetBar.ButtonX();
            this.btnVerEntradaSinOrden = new DevComponents.DotNetBar.ButtonX();
            this.controladorColumnasEntradasSinSeguimiento = new controladorColumnas();
            this.controladorColumnasEntradaSinSalida = new controladorColumnas();
            this.controladorColumnasEntradasSinOrden = new controladorColumnas();
            this.label9 = new System.Windows.Forms.Label();
            this.grdEntradasSinOrden = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabListadoEntradas = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel6 = new DevComponents.DotNetBar.TabControlPanel();
            this.btnActualizarMaestro = new DevComponents.DotNetBar.ButtonX();
            this.btnVerContratoxVencer = new DevComponents.DotNetBar.ButtonX();
            this.controladorColumnasContratoVencido = new controladorColumnas();
            this.controladorColumnasContratosxVencer = new controladorColumnas();
            this.btnVerContratoVencido = new DevComponents.DotNetBar.ButtonX();
            this.grdContratosVencidos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.grdContratosxVencer = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabContratos = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel7 = new DevComponents.DotNetBar.TabControlPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabDefault = new DevComponents.DotNetBar.TabItem(this.components);
            this.pltOrdenServicioSchedulleTableAdapter1 = new SPControladoraDatos.dsPlantillasTableAdapters.pltOrdenServicioSchedulleTableAdapter();
            this.ordenServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.pltListadoOrdenServicioTableAdapter1 = new SPControladoraDatos.dsPlantillasTableAdapters.pltListadoOrdenServicioTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.estadosOrdenServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.estadosOrdenServicioTableAdapter();
            this.pltListaContratosVencimientoTableAdapter1 = new SPControladoraDatos.dsPlantillasTableAdapters.pltListaContratosVencimientoTableAdapter();
            this.dsSPXSeguridad2 = new SPXSeguridad.data.dsSPXSeguridad();
            this.clsTusuario1 = new SPXSeguridad.data.cls.clsTusuario();
            ((System.ComponentModel.ISupportInitialize)(this.tabEntradas)).BeginInit();
            this.tabEntradas.SuspendLayout();
            this.tabControlPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calListadoLlamadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSeguimientosProgramados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLlamadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).BeginInit();
            this.tabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendario.DataStorage.AppointmentStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendario.DataStorage.CategoryStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendario.DataStorage.ContactStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendario.DataStorage.LabelStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendario.DataStorage.OwnerStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendario.DataStorage.ResourceStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendario.DataStorage.StatusStorage)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picnivel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNivel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNivel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnespera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrioridadAlta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdASignadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMisOrdenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Calendar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRespuesta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMisOrdenesEnEspera)).BeginInit();
            this.tabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarioIngeniero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarioIngeniero.DataStorage.AppointmentStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarioIngeniero.DataStorage.CategoryStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarioIngeniero.DataStorage.ContactStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarioIngeniero.DataStorage.LabelStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarioIngeniero.DataStorage.OwnerStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarioIngeniero.DataStorage.ResourceStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarioIngeniero.DataStorage.StatusStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillasIngenieros)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNivel3b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNivel1b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNivel2b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnEsperab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrioridadAltab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CalendarIng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrdenesIngeniero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrdenesIngeniero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrdenesIngenieroEspRespuesta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrdenesIngenieroEnEspera)).BeginInit();
            this.tabControlPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEntradasSinSeguimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEntradasSinSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEntradasSinOrden)).BeginInit();
            this.tabControlPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContratosVencidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdContratosxVencer)).BeginInit();
            this.tabControlPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabEntradas
            // 
            this.tabEntradas.CanReorderTabs = true;
            this.tabEntradas.Controls.Add(this.tabControlPanel1);
            this.tabEntradas.Controls.Add(this.tabControlPanel2);
            this.tabEntradas.Controls.Add(this.tabControlPanel3);
            this.tabEntradas.Controls.Add(this.tabControlPanel5);
            this.tabEntradas.Controls.Add(this.tabControlPanel6);
            this.tabEntradas.Controls.Add(this.tabControlPanel7);
            this.tabEntradas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabEntradas.Location = new System.Drawing.Point(0, 0);
            this.tabEntradas.Name = "tabEntradas";
            this.tabEntradas.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabEntradas.SelectedTabIndex = 0;
            this.tabEntradas.Size = new System.Drawing.Size(1015, 560);
            this.tabEntradas.Style = DevComponents.DotNetBar.eTabStripStyle.VS2005Document;
            this.tabEntradas.TabIndex = 1;
            this.tabEntradas.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.MultilineWithNavigationBox;
            this.tabEntradas.Tabs.Add(this.tabMisActividades);
            this.tabEntradas.Tabs.Add(this.tabActividadesIng);
            this.tabEntradas.Tabs.Add(this.tabLlamadas);
            this.tabEntradas.Tabs.Add(this.tabListadoEntradas);
            this.tabEntradas.Tabs.Add(this.tabContratos);
            this.tabEntradas.Tabs.Add(this.tabDefault);
            this.tabEntradas.Text = "Mis Actividades";
            this.tabEntradas.SelectedTabChanged += new DevComponents.DotNetBar.TabStrip.SelectedTabChangedEventHandler(this.tabControl1_SelectedTabChanged);
            // 
            // tabControlPanel3
            // 
            this.tabControlPanel3.Controls.Add(this.buttonX2);
            this.tabControlPanel3.Controls.Add(this.btnVerLlamada);
            this.tabControlPanel3.Controls.Add(this.controladorColumnasListadoLlamadas1);
            this.tabControlPanel3.Controls.Add(this.controladorColumnasSeguimientoLlamadas);
            this.tabControlPanel3.Controls.Add(this.btnVerSeguimientoLlamada);
            this.tabControlPanel3.Controls.Add(this.calListadoLlamadas);
            this.tabControlPanel3.Controls.Add(this.label6);
            this.tabControlPanel3.Controls.Add(this.label3);
            this.tabControlPanel3.Controls.Add(this.grdSeguimientosProgramados);
            this.tabControlPanel3.Controls.Add(this.grdLlamadas);
            this.tabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel3.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel3.Name = "tabControlPanel3";
            this.tabControlPanel3.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel3.Size = new System.Drawing.Size(1015, 534);
            this.tabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(250)))), ((int)(((byte)(247)))));
            this.tabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.tabControlPanel3.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel3.Style.GradientAngle = 90;
            this.tabControlPanel3.TabIndex = 3;
            this.tabControlPanel3.TabItem = this.tabLlamadas;
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.buttonX2, "Actualizar");
            this.balloonTip1.SetBalloonText(this.buttonX2, null);
            this.buttonX2.Image = ((System.Drawing.Image)(resources.GetObject("buttonX2.Image")));
            this.buttonX2.ImageFixedSize = new System.Drawing.Size(15, 15);
            this.buttonX2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonX2.Location = new System.Drawing.Point(14, 4);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(22, 21);
            this.buttonX2.TabIndex = 84;
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // btnVerLlamada
            // 
            this.btnVerLlamada.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnVerLlamada, "Ver Llamada");
            this.btnVerLlamada.Image = ((System.Drawing.Image)(resources.GetObject("btnVerLlamada.Image")));
            this.btnVerLlamada.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnVerLlamada.Location = new System.Drawing.Point(327, 16);
            this.btnVerLlamada.Name = "btnVerLlamada";
            this.btnVerLlamada.Size = new System.Drawing.Size(31, 29);
            this.btnVerLlamada.TabIndex = 83;
            this.btnVerLlamada.Text = " ";
            this.btnVerLlamada.Click += new System.EventHandler(this.btnVerLlamada_Click);
            // 
            // controladorColumnasListadoLlamadas1
            // 
            this.controladorColumnasListadoLlamadas1.BackColor = System.Drawing.Color.Transparent;
            this.controladorColumnasListadoLlamadas1.grilla = null;
            this.controladorColumnasListadoLlamadas1.Location = new System.Drawing.Point(360, 16);
            this.controladorColumnasListadoLlamadas1.MostrarContraer = true;
            this.controladorColumnasListadoLlamadas1.MostrarExcel = true;
            this.controladorColumnasListadoLlamadas1.MostrarExpandir = true;
            this.controladorColumnasListadoLlamadas1.MostrarLimpiar = true;
            this.controladorColumnasListadoLlamadas1.Name = "controladorColumnasListadoLlamadas1";
            this.controladorColumnasListadoLlamadas1.nombreLibro = null;
            this.controladorColumnasListadoLlamadas1.Size = new System.Drawing.Size(216, 29);
            this.controladorColumnasListadoLlamadas1.TabIndex = 82;
            // 
            // controladorColumnasSeguimientoLlamadas
            // 
            this.controladorColumnasSeguimientoLlamadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controladorColumnasSeguimientoLlamadas.BackColor = System.Drawing.Color.Transparent;
            this.controladorColumnasSeguimientoLlamadas.grilla = null;
            this.controladorColumnasSeguimientoLlamadas.Location = new System.Drawing.Point(784, 17);
            this.controladorColumnasSeguimientoLlamadas.MostrarContraer = true;
            this.controladorColumnasSeguimientoLlamadas.MostrarExcel = true;
            this.controladorColumnasSeguimientoLlamadas.MostrarExpandir = true;
            this.controladorColumnasSeguimientoLlamadas.MostrarLimpiar = true;
            this.controladorColumnasSeguimientoLlamadas.Name = "controladorColumnasSeguimientoLlamadas";
            this.controladorColumnasSeguimientoLlamadas.nombreLibro = null;
            this.controladorColumnasSeguimientoLlamadas.Size = new System.Drawing.Size(216, 29);
            this.controladorColumnasSeguimientoLlamadas.TabIndex = 81;
            // 
            // btnVerSeguimientoLlamada
            // 
            this.btnVerSeguimientoLlamada.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVerSeguimientoLlamada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnVerSeguimientoLlamada, "Ver Seguimiento");
            this.btnVerSeguimientoLlamada.Image = ((System.Drawing.Image)(resources.GetObject("btnVerSeguimientoLlamada.Image")));
            this.btnVerSeguimientoLlamada.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnVerSeguimientoLlamada.Location = new System.Drawing.Point(756, 17);
            this.btnVerSeguimientoLlamada.Name = "btnVerSeguimientoLlamada";
            this.btnVerSeguimientoLlamada.Size = new System.Drawing.Size(26, 28);
            this.btnVerSeguimientoLlamada.TabIndex = 80;
            this.btnVerSeguimientoLlamada.Text = " ";
            this.btnVerSeguimientoLlamada.Click += new System.EventHandler(this.btnVerSeguimientoLlamada_Click);
            // 
            // calListadoLlamadas
            // 
            // 
            // 
            // 
            this.calListadoLlamadas.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calListadoLlamadas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calListadoLlamadas.ButtonDropDown.Visible = true;
            this.calListadoLlamadas.Location = new System.Drawing.Point(155, 26);
            // 
            // 
            // 
            this.calListadoLlamadas.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calListadoLlamadas.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calListadoLlamadas.MonthCalendar.BackgroundStyle.Class = "";
            this.calListadoLlamadas.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calListadoLlamadas.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calListadoLlamadas.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calListadoLlamadas.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calListadoLlamadas.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calListadoLlamadas.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calListadoLlamadas.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calListadoLlamadas.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calListadoLlamadas.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calListadoLlamadas.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calListadoLlamadas.MonthCalendar.DisplayMonth = new System.DateTime(2010, 4, 1, 0, 0, 0, 0);
            this.calListadoLlamadas.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calListadoLlamadas.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calListadoLlamadas.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calListadoLlamadas.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calListadoLlamadas.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calListadoLlamadas.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calListadoLlamadas.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calListadoLlamadas.MonthCalendar.TodayButtonVisible = true;
            this.calListadoLlamadas.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calListadoLlamadas.Name = "calListadoLlamadas";
            this.calListadoLlamadas.Size = new System.Drawing.Size(143, 20);
            this.calListadoLlamadas.TabIndex = 13;
            this.calListadoLlamadas.ValueChanged += new System.EventHandler(this.calListadoLlamadas_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(585, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Seguimientos Programados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(9, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Llamadas Tecnicas Abiertas";
            // 
            // grdSeguimientosProgramados
            // 
            this.grdSeguimientosProgramados.AllowUpdate = false;
            this.grdSeguimientosProgramados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdSeguimientosProgramados.DataMember = "seguimiento";
            this.grdSeguimientosProgramados.DataSource = this.dsSpx1;
            this.grdSeguimientosProgramados.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdSeguimientosProgramados.GroupByCaption = "";
            this.grdSeguimientosProgramados.Images.Add(((System.Drawing.Image)(resources.GetObject("grdSeguimientosProgramados.Images"))));
            this.grdSeguimientosProgramados.Location = new System.Drawing.Point(588, 48);
            this.grdSeguimientosProgramados.Name = "grdSeguimientosProgramados";
            this.grdSeguimientosProgramados.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdSeguimientosProgramados.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdSeguimientosProgramados.PreviewInfo.ZoomFactor = 75D;
            this.grdSeguimientosProgramados.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdSeguimientosProgramados.PrintInfo.PageSettings")));
            this.grdSeguimientosProgramados.Size = new System.Drawing.Size(404, 469);
            this.grdSeguimientosProgramados.TabIndex = 12;
            this.grdSeguimientosProgramados.Text = "c1TrueDBGrid2";
            this.grdSeguimientosProgramados.PropBag = resources.GetString("grdSeguimientosProgramados.PropBag");
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.EnforceConstraints = false;
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdLlamadas
            // 
            this.grdLlamadas.AllowUpdate = false;
            this.grdLlamadas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grdLlamadas.DataMember = "pltListadoLlamadas";
            this.grdLlamadas.DataSource = this.dsPlantillas1;
            this.grdLlamadas.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdLlamadas.GroupByCaption = "";
            this.grdLlamadas.Images.Add(((System.Drawing.Image)(resources.GetObject("grdLlamadas.Images"))));
            this.grdLlamadas.Location = new System.Drawing.Point(12, 48);
            this.grdLlamadas.Name = "grdLlamadas";
            this.grdLlamadas.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdLlamadas.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdLlamadas.PreviewInfo.ZoomFactor = 75D;
            this.grdLlamadas.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdLlamadas.PrintInfo.PageSettings")));
            this.grdLlamadas.Size = new System.Drawing.Size(556, 474);
            this.grdLlamadas.TabIndex = 11;
            this.grdLlamadas.Text = "c1TrueDBGrid1";
            this.grdLlamadas.PropBag = resources.GetString("grdLlamadas.PropBag");
            // 
            // dsPlantillas1
            // 
            this.dsPlantillas1.DataSetName = "dsPlantillas";
            this.dsPlantillas1.EnforceConstraints = false;
            this.dsPlantillas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabLlamadas
            // 
            this.tabLlamadas.AttachedControl = this.tabControlPanel3;
            this.tabLlamadas.Name = "tabLlamadas";
            this.tabLlamadas.Text = "Llamadas Tecnicas";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.calendario);
            this.tabControlPanel1.Controls.Add(this.btnExcelMis1);
            this.tabControlPanel1.Controls.Add(this.btnGuardarGrdRespuesta);
            this.tabControlPanel1.Controls.Add(this.btnRestaurargrdRespuestas);
            this.tabControlPanel1.Controls.Add(this.btnGuardargrdAsignadas);
            this.tabControlPanel1.Controls.Add(this.btnReinicciargrdasignadas);
            this.tabControlPanel1.Controls.Add(this.groupBox1);
            this.tabControlPanel1.Controls.Add(this.grdASignadas);
            this.tabControlPanel1.Controls.Add(this.lblIngeniero);
            this.tabControlPanel1.Controls.Add(this.c1Calendar1);
            this.tabControlPanel1.Controls.Add(this.label2);
            this.tabControlPanel1.Controls.Add(this.label1);
            this.tabControlPanel1.Controls.Add(this.grdRespuesta);
            this.tabControlPanel1.Controls.Add(this.btnActualizar);
            this.tabControlPanel1.Controls.Add(this.btnHoy);
            this.tabControlPanel1.Controls.Add(this.btn30);
            this.tabControlPanel1.Controls.Add(this.btn7);
            this.tabControlPanel1.Controls.Add(this.btn5);
            this.tabControlPanel1.Controls.Add(this.btnDia);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(1015, 534);
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(250)))), ((int)(((byte)(247)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabMisActividades;
            // 
            // calendario
            // 
            // 
            // 
            // 
            this.calendario.CalendarInfo.CultureInfo = new System.Globalization.CultureInfo("es-CO");
            this.calendario.CalendarInfo.DateFormatString = "dd/MM/yyyy";
            this.calendario.CalendarInfo.EndDayTime = System.TimeSpan.Parse("19:00:00");
            this.calendario.CalendarInfo.FirstDate = new System.DateTime(2008, 2, 13, 0, 0, 0, 0);
            this.calendario.CalendarInfo.LastDate = new System.DateTime(2050, 2, 13, 0, 0, 0, 0);
            this.calendario.CalendarInfo.StartDayTime = System.TimeSpan.Parse("07:00:00");
            this.calendario.CalendarInfo.TimeScale = System.TimeSpan.Parse("00:30:00");
            this.calendario.CalendarInfo.WeekStart = System.DayOfWeek.Sunday;
            this.calendario.CalendarInfo.WorkDays.AddRange(new System.DayOfWeek[] {
            System.DayOfWeek.Monday,
            System.DayOfWeek.Tuesday,
            System.DayOfWeek.Wednesday,
            System.DayOfWeek.Thursday,
            System.DayOfWeek.Friday});
            this.calendario.ContextMenuStrip = this.contextMenuStrip1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.calendario.DataStorage.AppointmentStorage.DataMember = "pltOrdenServicioSchedulle";
            this.calendario.DataStorage.AppointmentStorage.DataSource = this.dsPlantillas1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.calendario.DataStorage.AppointmentStorage.Mappings.Body.MappingName = "cuerpo";
            // 
            // 
            // 
            this.calendario.DataStorage.AppointmentStorage.Mappings.End.MappingName = "fechaFinProgramacion";
            // 
            // 
            // 
            this.calendario.DataStorage.AppointmentStorage.Mappings.IndexMapping.MappingName = "codOrdenServicio";
            // 
            // 
            // 
            this.calendario.DataStorage.AppointmentStorage.Mappings.Location.MappingName = "ubicacion";
            // 
            // 
            // 
            this.calendario.DataStorage.AppointmentStorage.Mappings.Start.MappingName = "fechaProgramacion";
            // 
            // 
            // 
            this.calendario.DataStorage.AppointmentStorage.Mappings.Subject.MappingName = "asunto";
            // 
            // 
            // 
            this.calendario.DataStorage.StatusStorage.DataMember = "estadosOrdenServicio";
            this.calendario.EditOptions = C1.Win.C1Schedule.EditOptions.None;
            this.calendario.GroupPageSize = 2;
            this.calendario.Location = new System.Drawing.Point(12, 43);
            this.calendario.Name = "calendario";
            printStyle11.Description = "Daily Style";
            printStyle11.PreviewImage = ((System.Drawing.Image)(resources.GetObject("printStyle11.PreviewImage")));
            printStyle11.StyleName = "Daily";
            printStyle11.StyleSource = "day.c1d";
            printStyle12.Description = "Weekly Style";
            printStyle12.PreviewImage = ((System.Drawing.Image)(resources.GetObject("printStyle12.PreviewImage")));
            printStyle12.StyleName = "Week";
            printStyle12.StyleSource = "week.c1d";
            printStyle13.Description = "Monthly Style";
            printStyle13.PreviewImage = ((System.Drawing.Image)(resources.GetObject("printStyle13.PreviewImage")));
            printStyle13.StyleName = "Month";
            printStyle13.StyleSource = "month.c1d";
            printStyle14.Description = "Details Style";
            printStyle14.PreviewImage = ((System.Drawing.Image)(resources.GetObject("printStyle14.PreviewImage")));
            printStyle14.StyleName = "Details";
            printStyle14.StyleSource = "details.c1d";
            printStyle15.Context = C1.C1Schedule.Printing.PrintContextType.Appointment;
            printStyle15.Description = "Memo Style";
            printStyle15.PreviewImage = ((System.Drawing.Image)(resources.GetObject("printStyle15.PreviewImage")));
            printStyle15.StyleName = "Memo";
            printStyle15.StyleSource = "memo.c1d";
            this.calendario.PrintInfo.PrintStyles.AddRange(new C1.C1Schedule.Printing.PrintStyle[] {
            printStyle11,
            printStyle12,
            printStyle13,
            printStyle14,
            printStyle15});
            // 
            // 
            // 
            this.calendario.Settings.FirstVisibleTime = System.TimeSpan.Parse("08:00:00");
            this.calendario.ShowContextMenu = false;
            this.calendario.ShowReminderForm = false;
            this.calendario.ShowTitle = false;
            this.calendario.Size = new System.Drawing.Size(640, 356);
            this.calendario.TabIndex = 23;
            this.calendario.ViewType = C1.Win.C1Schedule.ScheduleViewEnum.MonthView;
            this.calendario.VisualStyle = C1.Win.C1Schedule.UI.VisualStyle.Office2007Black;
            this.calendario.BeforeContextMenuShow += new System.EventHandler<C1.Win.C1Schedule.BeforeContextMenuShowEventArgs>(this.calendario_BeforeContextMenuShow);
            this.calendario.BeforeAppointmentShow += new C1.C1Schedule.CancelAppointmentEventHandler(this.calendario_BeforeAppointmentShow);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // btnExcelMis1
            // 
            this.btnExcelMis1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExcelMis1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnExcelMis1, "Exportar Excel");
            this.balloonTip1.SetBalloonText(this.btnExcelMis1, null);
            this.btnExcelMis1.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelMis1.Image")));
            this.btnExcelMis1.ImageFixedSize = new System.Drawing.Size(18, 18);
            this.btnExcelMis1.Location = new System.Drawing.Point(935, 276);
            this.btnExcelMis1.Name = "btnExcelMis1";
            this.btnExcelMis1.Size = new System.Drawing.Size(20, 20);
            this.btnExcelMis1.TabIndex = 76;
            this.btnExcelMis1.Click += new System.EventHandler(this.btnExcelMis1_Click);
            // 
            // btnGuardarGrdRespuesta
            // 
            this.btnGuardarGrdRespuesta.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGuardarGrdRespuesta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnGuardarGrdRespuesta, "Guardar Columnas");
            this.balloonTip1.SetBalloonText(this.btnGuardarGrdRespuesta, "Guarda El Esquema de las Columnas");
            this.btnGuardarGrdRespuesta.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarGrdRespuesta.Image")));
            this.btnGuardarGrdRespuesta.ImageFixedSize = new System.Drawing.Size(18, 18);
            this.btnGuardarGrdRespuesta.Location = new System.Drawing.Point(985, 73);
            this.btnGuardarGrdRespuesta.Name = "btnGuardarGrdRespuesta";
            this.btnGuardarGrdRespuesta.Size = new System.Drawing.Size(20, 20);
            this.btnGuardarGrdRespuesta.TabIndex = 75;
            this.btnGuardarGrdRespuesta.Click += new System.EventHandler(this.btnGuardarGrdRespuesta_Click);
            // 
            // btnRestaurargrdRespuestas
            // 
            this.btnRestaurargrdRespuestas.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRestaurargrdRespuestas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnRestaurargrdRespuestas, "Restaurar Columnas");
            this.balloonTip1.SetBalloonText(this.btnRestaurargrdRespuestas, "Restaurar Columnas a su Valor Original");
            this.btnRestaurargrdRespuestas.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurargrdRespuestas.Image")));
            this.btnRestaurargrdRespuestas.ImageFixedSize = new System.Drawing.Size(18, 18);
            this.btnRestaurargrdRespuestas.Location = new System.Drawing.Point(962, 73);
            this.btnRestaurargrdRespuestas.Name = "btnRestaurargrdRespuestas";
            this.btnRestaurargrdRespuestas.Size = new System.Drawing.Size(20, 20);
            this.btnRestaurargrdRespuestas.TabIndex = 74;
            this.btnRestaurargrdRespuestas.Click += new System.EventHandler(this.btnRestaurargrdRespuestas_Click);
            // 
            // btnGuardargrdAsignadas
            // 
            this.btnGuardargrdAsignadas.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGuardargrdAsignadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnGuardargrdAsignadas, "Guardar Columnas");
            this.balloonTip1.SetBalloonText(this.btnGuardargrdAsignadas, "Guarda El Esquema de las Columnas");
            this.btnGuardargrdAsignadas.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardargrdAsignadas.Image")));
            this.btnGuardargrdAsignadas.ImageFixedSize = new System.Drawing.Size(18, 18);
            this.btnGuardargrdAsignadas.Location = new System.Drawing.Point(982, 277);
            this.btnGuardargrdAsignadas.Name = "btnGuardargrdAsignadas";
            this.btnGuardargrdAsignadas.Size = new System.Drawing.Size(20, 20);
            this.btnGuardargrdAsignadas.TabIndex = 73;
            this.btnGuardargrdAsignadas.Click += new System.EventHandler(this.btnGuardargrdAsignadas_Click);
            // 
            // btnReinicciargrdasignadas
            // 
            this.btnReinicciargrdasignadas.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReinicciargrdasignadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnReinicciargrdasignadas, "Restaurar Columnas");
            this.balloonTip1.SetBalloonText(this.btnReinicciargrdasignadas, "Restaurar Columnas a su Valor Original");
            this.btnReinicciargrdasignadas.Image = ((System.Drawing.Image)(resources.GetObject("btnReinicciargrdasignadas.Image")));
            this.btnReinicciargrdasignadas.ImageFixedSize = new System.Drawing.Size(18, 18);
            this.btnReinicciargrdasignadas.Location = new System.Drawing.Point(958, 277);
            this.btnReinicciargrdasignadas.Name = "btnReinicciargrdasignadas";
            this.btnReinicciargrdasignadas.Size = new System.Drawing.Size(20, 20);
            this.btnReinicciargrdasignadas.TabIndex = 72;
            this.btnReinicciargrdasignadas.Click += new System.EventHandler(this.btnReinicciargrdasignadas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblNivel3);
            this.groupBox1.Controls.Add(this.btnEsquemaColores);
            this.groupBox1.Controls.Add(this.lblNivel2);
            this.groupBox1.Controls.Add(this.picnivel3);
            this.groupBox1.Controls.Add(this.picNivel1);
            this.groupBox1.Controls.Add(this.picNivel2);
            this.groupBox1.Controls.Add(this.picEnespera);
            this.groupBox1.Controls.Add(this.picPrioridadAlta);
            this.groupBox1.Controls.Add(this.lblNivel1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(658, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 66);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // lblNivel3
            // 
            this.lblNivel3.AutoSize = true;
            this.lblNivel3.Location = new System.Drawing.Point(225, 41);
            this.lblNivel3.Name = "lblNivel3";
            this.lblNivel3.Size = new System.Drawing.Size(91, 13);
            this.lblNivel3.TabIndex = 12;
            this.lblNivel3.Text = "10 dias de retrazo";
            // 
            // btnEsquemaColores
            // 
            this.btnEsquemaColores.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEsquemaColores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnEsquemaColores, "Configurar Colores y Tiempos ");
            this.balloonTip1.SetBalloonText(this.btnEsquemaColores, null);
            this.btnEsquemaColores.Image = ((System.Drawing.Image)(resources.GetObject("btnEsquemaColores.Image")));
            this.btnEsquemaColores.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnEsquemaColores.Location = new System.Drawing.Point(317, 5);
            this.btnEsquemaColores.Name = "btnEsquemaColores";
            this.btnEsquemaColores.Size = new System.Drawing.Size(30, 30);
            this.btnEsquemaColores.TabIndex = 27;
            this.btnEsquemaColores.Click += new System.EventHandler(this.btnEsquemaColores_Click);
            // 
            // lblNivel2
            // 
            this.lblNivel2.AutoSize = true;
            this.lblNivel2.Location = new System.Drawing.Point(114, 41);
            this.lblNivel2.Name = "lblNivel2";
            this.lblNivel2.Size = new System.Drawing.Size(91, 13);
            this.lblNivel2.TabIndex = 11;
            this.lblNivel2.Text = "10 dias de retrazo";
            // 
            // picnivel3
            // 
            this.picnivel3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.picnivel3.Location = new System.Drawing.Point(315, 40);
            this.picnivel3.Name = "picnivel3";
            this.picnivel3.Size = new System.Drawing.Size(20, 15);
            this.picnivel3.TabIndex = 10;
            this.picnivel3.TabStop = false;
            // 
            // picNivel1
            // 
            this.picNivel1.BackColor = System.Drawing.Color.LightCoral;
            this.picNivel1.Location = new System.Drawing.Point(94, 40);
            this.picNivel1.Name = "picNivel1";
            this.picNivel1.Size = new System.Drawing.Size(20, 15);
            this.picNivel1.TabIndex = 9;
            this.picNivel1.TabStop = false;
            // 
            // picNivel2
            // 
            this.picNivel2.BackColor = System.Drawing.Color.Brown;
            this.picNivel2.Location = new System.Drawing.Point(207, 40);
            this.picNivel2.Name = "picNivel2";
            this.picNivel2.Size = new System.Drawing.Size(20, 15);
            this.picNivel2.TabIndex = 8;
            this.picNivel2.TabStop = false;
            // 
            // picEnespera
            // 
            this.picEnespera.BackColor = System.Drawing.Color.Khaki;
            this.picEnespera.Location = new System.Drawing.Point(131, 19);
            this.picEnespera.Name = "picEnespera";
            this.picEnespera.Size = new System.Drawing.Size(20, 15);
            this.picEnespera.TabIndex = 7;
            this.picEnespera.TabStop = false;
            // 
            // picPrioridadAlta
            // 
            this.picPrioridadAlta.BackColor = System.Drawing.Color.DarkSlateGray;
            this.picPrioridadAlta.Location = new System.Drawing.Point(236, 19);
            this.picPrioridadAlta.Name = "picPrioridadAlta";
            this.picPrioridadAlta.Size = new System.Drawing.Size(20, 15);
            this.picPrioridadAlta.TabIndex = 6;
            this.picPrioridadAlta.TabStop = false;
            // 
            // lblNivel1
            // 
            this.lblNivel1.AutoSize = true;
            this.lblNivel1.Location = new System.Drawing.Point(0, 41);
            this.lblNivel1.Name = "lblNivel1";
            this.lblNivel1.Size = new System.Drawing.Size(91, 13);
            this.lblNivel1.TabIndex = 2;
            this.lblNivel1.Text = "10 dias de retrazo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(168, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Prioridad Alta";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "En espera de respuesta";
            // 
            // grdASignadas
            // 
            this.grdASignadas.AllowUpdate = false;
            this.grdASignadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdASignadas.DataMember = "pltListadoOrdenServicio";
            this.grdASignadas.DataSource = this.dsMisOrdenes;
            this.grdASignadas.FetchRowStyles = true;
            this.grdASignadas.FilterBar = true;
            this.grdASignadas.Images.Add(((System.Drawing.Image)(resources.GetObject("grdASignadas.Images"))));
            this.grdASignadas.Location = new System.Drawing.Point(658, 298);
            this.grdASignadas.Name = "grdASignadas";
            this.grdASignadas.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdASignadas.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdASignadas.PreviewInfo.ZoomFactor = 75D;
            this.grdASignadas.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdASignadas.PrintInfo.PageSettings")));
            this.grdASignadas.Size = new System.Drawing.Size(344, 219);
            this.grdASignadas.TabIndex = 26;
            this.grdASignadas.Text = "c1TrueDBGrid1";
            this.grdASignadas.FetchRowStyle += new C1.Win.C1TrueDBGrid.FetchRowStyleEventHandler(this.grdASignadas_FetchRowStyle);
            this.grdASignadas.DoubleClick += new System.EventHandler(this.grdASignadas_DoubleClick);
            this.grdASignadas.PropBag = resources.GetString("grdASignadas.PropBag");
            // 
            // dsMisOrdenes
            // 
            this.dsMisOrdenes.DataSetName = "dsPlantillas";
            this.dsMisOrdenes.EnforceConstraints = false;
            this.dsMisOrdenes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblIngeniero
            // 
            this.lblIngeniero.AutoSize = true;
            this.lblIngeniero.BackColor = System.Drawing.Color.Transparent;
            this.lblIngeniero.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngeniero.Location = new System.Drawing.Point(12, 16);
            this.lblIngeniero.Name = "lblIngeniero";
            this.lblIngeniero.Size = new System.Drawing.Size(159, 19);
            this.lblIngeniero.TabIndex = 25;
            this.lblIngeniero.Text = "Nombre del ingeniero";
            // 
            // c1Calendar1
            // 
            this.c1Calendar1.BoldedDates = new System.DateTime[0];
            this.c1Calendar1.CalendarDimensions = 3;
            this.c1Calendar1.Location = new System.Drawing.Point(12, 399);
            this.c1Calendar1.Name = "c1Calendar1";
            this.c1Calendar1.Schedule = this.calendario;
            this.c1Calendar1.Size = new System.Drawing.Size(640, 200);
            this.c1Calendar1.TabIndex = 24;
          //  this.c1Calendar1.VisualStyle = C1.Win.C1Schedule.UI.VisualStyle.Royale;
            this.c1Calendar1.SelectionChanged += new System.EventHandler<C1.Win.C1Schedule.SelectionChangedEventArgs>(this.c1Calendar1_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(656, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mis Ordenes de Servicio Asignadas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(655, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ordenes de Servicio En Espera de Respuesta";
            // 
            // grdRespuesta
            // 
            this.grdRespuesta.AllowUpdate = false;
            this.grdRespuesta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdRespuesta.DataMember = "pltListadoOrdenServicio";
            this.grdRespuesta.DataSource = this.dsMisOrdenesEnEspera;
            this.grdRespuesta.FilterBar = true;
            this.grdRespuesta.Images.Add(((System.Drawing.Image)(resources.GetObject("grdRespuesta.Images"))));
            this.grdRespuesta.Location = new System.Drawing.Point(659, 96);
            this.grdRespuesta.Name = "grdRespuesta";
            this.grdRespuesta.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdRespuesta.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdRespuesta.PreviewInfo.ZoomFactor = 75D;
            this.grdRespuesta.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdRespuesta.PrintInfo.PageSettings")));
            this.grdRespuesta.Size = new System.Drawing.Size(344, 178);
            this.grdRespuesta.TabIndex = 19;
            this.grdRespuesta.Text = "c1TrueDBGrid1";
            this.grdRespuesta.DoubleClick += new System.EventHandler(this.grdRespuesta_DoubleClick);
            this.grdRespuesta.PropBag = resources.GetString("grdRespuesta.PropBag");
            // 
            // dsMisOrdenesEnEspera
            // 
            this.dsMisOrdenesEnEspera.DataSetName = "dsPlantillas";
            this.dsMisOrdenesEnEspera.EnforceConstraints = false;
            this.dsMisOrdenesEnEspera.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnActualizar
            // 
            this.btnActualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnActualizar.Location = new System.Drawing.Point(615, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(33, 33);
            this.btnActualizar.TabIndex = 18;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnHoy
            // 
            this.btnHoy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHoy.Image = ((System.Drawing.Image)(resources.GetObject("btnHoy.Image")));
            this.btnHoy.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnHoy.Location = new System.Drawing.Point(579, 2);
            this.btnHoy.Name = "btnHoy";
            this.btnHoy.Size = new System.Drawing.Size(33, 33);
            this.btnHoy.TabIndex = 16;
            this.btnHoy.Click += new System.EventHandler(this.btnHoy_Click);
            // 
            // btn30
            // 
            this.btn30.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn30.Image = ((System.Drawing.Image)(resources.GetObject("btn30.Image")));
            this.btn30.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btn30.Location = new System.Drawing.Point(546, 2);
            this.btn30.Name = "btn30";
            this.btn30.Size = new System.Drawing.Size(33, 33);
            this.btn30.TabIndex = 15;
            this.btn30.Click += new System.EventHandler(this.btn30_Click);
            // 
            // btn7
            // 
            this.btn7.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn7.Image = ((System.Drawing.Image)(resources.GetObject("btn7.Image")));
            this.btn7.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btn7.Location = new System.Drawing.Point(513, 2);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(33, 33);
            this.btn7.TabIndex = 14;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn5
            // 
            this.btn5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn5.Image = ((System.Drawing.Image)(resources.GetObject("btn5.Image")));
            this.btn5.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btn5.Location = new System.Drawing.Point(480, 2);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(33, 33);
            this.btn5.TabIndex = 13;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btnDia
            // 
            this.btnDia.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDia.Image = ((System.Drawing.Image)(resources.GetObject("btnDia.Image")));
            this.btnDia.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnDia.Location = new System.Drawing.Point(447, 2);
            this.btnDia.Name = "btnDia";
            this.btnDia.Size = new System.Drawing.Size(33, 33);
            this.btnDia.TabIndex = 12;
            this.btnDia.Click += new System.EventHandler(this.btnDia_Click);
            // 
            // tabMisActividades
            // 
            this.tabMisActividades.AttachedControl = this.tabControlPanel1;
            this.tabMisActividades.Name = "tabMisActividades";
            this.tabMisActividades.Text = "Mis Actividades";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.calendarioIngeniero);
            this.tabControlPanel2.Controls.Add(this.btnMisASignadasHorario);
            this.tabControlPanel2.Controls.Add(this.btnGuardarGrdIngEspRespuesta);
            this.tabControlPanel2.Controls.Add(this.btnRestaurarGrdIngEspRespuesta);
            this.tabControlPanel2.Controls.Add(this.btnGuardarGrdIngAsignadas);
            this.tabControlPanel2.Controls.Add(this.btnRestaurarGrdOrdenesINg);
            this.tabControlPanel2.Controls.Add(this.groupBox2);
            this.tabControlPanel2.Controls.Add(this.cmbIngenieros);
            this.tabControlPanel2.Controls.Add(this.c1CalendarIng);
            this.tabControlPanel2.Controls.Add(this.grdOrdenesIngeniero);
            this.tabControlPanel2.Controls.Add(this.label4);
            this.tabControlPanel2.Controls.Add(this.label5);
            this.tabControlPanel2.Controls.Add(this.grdOrdenesIngenieroEspRespuesta);
            this.tabControlPanel2.Controls.Add(this.btnActualizarIngeniero);
            this.tabControlPanel2.Controls.Add(this.btnHoyIngeniero);
            this.tabControlPanel2.Controls.Add(this.btn30Ing);
            this.tabControlPanel2.Controls.Add(this.btn7Ing);
            this.tabControlPanel2.Controls.Add(this.btn5ing);
            this.tabControlPanel2.Controls.Add(this.btnDiaIng);
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(1015, 534);
            this.tabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(250)))), ((int)(((byte)(247)))));
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 2;
            this.tabControlPanel2.TabItem = this.tabActividadesIng;
            // 
            // calendarioIngeniero
            // 
            // 
            // 
            // 
            this.calendarioIngeniero.CalendarInfo.CultureInfo = new System.Globalization.CultureInfo("es-CO");
            this.calendarioIngeniero.CalendarInfo.DateFormatString = "dd/MM/yyyy";
            this.calendarioIngeniero.CalendarInfo.EndDayTime = System.TimeSpan.Parse("19:00:00");
            this.calendarioIngeniero.CalendarInfo.FirstDate = new System.DateTime(2008, 2, 5, 0, 0, 0, 0);
            this.calendarioIngeniero.CalendarInfo.LastDate = new System.DateTime(2050, 2, 5, 0, 0, 0, 0);
            this.calendarioIngeniero.CalendarInfo.StartDayTime = System.TimeSpan.Parse("07:00:00");
            this.calendarioIngeniero.CalendarInfo.TimeScale = System.TimeSpan.Parse("00:30:00");
            this.calendarioIngeniero.CalendarInfo.WeekStart = System.DayOfWeek.Sunday;
            this.calendarioIngeniero.CalendarInfo.WorkDays.AddRange(new System.DayOfWeek[] {
            System.DayOfWeek.Monday,
            System.DayOfWeek.Tuesday,
            System.DayOfWeek.Wednesday,
            System.DayOfWeek.Thursday,
            System.DayOfWeek.Friday,
            System.DayOfWeek.Saturday});
            this.calendarioIngeniero.ContextMenuStrip = this.contextMenuIngeniero;
            // 
            // 
            // 
            // 
            // 
            // 
            this.calendarioIngeniero.DataStorage.AppointmentStorage.DataMember = "pltOrdenServicioSchedulle";
            this.calendarioIngeniero.DataStorage.AppointmentStorage.DataSource = this.dsPlantillasIngenieros;
            // 
            // 
            // 
            // 
            // 
            // 
            this.calendarioIngeniero.DataStorage.AppointmentStorage.Mappings.Body.MappingName = "cuerpo";
            // 
            // 
            // 
            this.calendarioIngeniero.DataStorage.AppointmentStorage.Mappings.End.MappingName = "fechaFinProgramacion";
            // 
            // 
            // 
            this.calendarioIngeniero.DataStorage.AppointmentStorage.Mappings.IndexMapping.MappingName = "codOrdenServicio";
            // 
            // 
            // 
            this.calendarioIngeniero.DataStorage.AppointmentStorage.Mappings.Location.MappingName = "ubicacion";
            // 
            // 
            // 
            this.calendarioIngeniero.DataStorage.AppointmentStorage.Mappings.Start.MappingName = "fechaProgramacion";
            // 
            // 
            // 
            this.calendarioIngeniero.DataStorage.AppointmentStorage.Mappings.Subject.MappingName = "asunto";
            // 
            // 
            // 
            this.calendarioIngeniero.DataStorage.StatusStorage.DataMember = "estadosOrdenServicio";
            this.calendarioIngeniero.EditOptions = C1.Win.C1Schedule.EditOptions.None;
            this.calendarioIngeniero.GroupPageSize = 2;
            this.calendarioIngeniero.Location = new System.Drawing.Point(12, 48);
            this.calendarioIngeniero.Name = "calendarioIngeniero";
            printStyle1.Description = "Daily Style";
            printStyle1.PreviewImage = ((System.Drawing.Image)(resources.GetObject("printStyle1.PreviewImage")));
            printStyle1.StyleName = "Daily";
            printStyle1.StyleSource = "day.c1d";
            printStyle2.Description = "Weekly Style";
            printStyle2.PreviewImage = ((System.Drawing.Image)(resources.GetObject("printStyle2.PreviewImage")));
            printStyle2.StyleName = "Week";
            printStyle2.StyleSource = "week.c1d";
            printStyle3.Description = "Monthly Style";
            printStyle3.PreviewImage = ((System.Drawing.Image)(resources.GetObject("printStyle3.PreviewImage")));
            printStyle3.StyleName = "Month";
            printStyle3.StyleSource = "month.c1d";
            printStyle4.Description = "Details Style";
            printStyle4.PreviewImage = ((System.Drawing.Image)(resources.GetObject("printStyle4.PreviewImage")));
            printStyle4.StyleName = "Details";
            printStyle4.StyleSource = "details.c1d";
            printStyle5.Context = C1.C1Schedule.Printing.PrintContextType.Appointment;
            printStyle5.Description = "Memo Style";
            printStyle5.PreviewImage = ((System.Drawing.Image)(resources.GetObject("printStyle5.PreviewImage")));
            printStyle5.StyleName = "Memo";
            printStyle5.StyleSource = "memo.c1d";
            this.calendarioIngeniero.PrintInfo.PrintStyles.AddRange(new C1.C1Schedule.Printing.PrintStyle[] {
            printStyle1,
            printStyle2,
            printStyle3,
            printStyle4,
            printStyle5});
            // 
            // 
            // 
            this.calendarioIngeniero.Settings.FirstVisibleTime = System.TimeSpan.Parse("08:00:00");
            this.calendarioIngeniero.ShowContextMenu = false;
            this.calendarioIngeniero.ShowReminderForm = false;
            this.calendarioIngeniero.ShowTitle = false;
            this.calendarioIngeniero.Size = new System.Drawing.Size(640, 356);
            this.calendarioIngeniero.TabIndex = 36;
            this.calendarioIngeniero.ViewType = C1.Win.C1Schedule.ScheduleViewEnum.MonthView;
            this.calendarioIngeniero.VisualStyle = C1.Win.C1Schedule.UI.VisualStyle.Office2007Black;
            this.calendarioIngeniero.BeforeContextMenuShow += new System.EventHandler<C1.Win.C1Schedule.BeforeContextMenuShowEventArgs>(this.calendarioIngeniero_BeforeContextMenuShow);
            this.calendarioIngeniero.BeforeAppointmentShow += new C1.C1Schedule.CancelAppointmentEventHandler(this.calendarioIngeniero_BeforeAppointmentShow);
            // 
            // contextMenuIngeniero
            // 
            this.contextMenuIngeniero.Name = "contextMenuStrip1";
            this.contextMenuIngeniero.Size = new System.Drawing.Size(61, 4);
            this.contextMenuIngeniero.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuIngeniero_Opening);
            this.contextMenuIngeniero.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuIngeniero_ItemClicked);
            // 
            // dsPlantillasIngenieros
            // 
            this.dsPlantillasIngenieros.DataSetName = "dsPlantillas";
            this.dsPlantillasIngenieros.EnforceConstraints = false;
            this.dsPlantillasIngenieros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnMisASignadasHorario
            // 
            this.btnMisASignadasHorario.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMisASignadasHorario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnMisASignadasHorario, "Exportar Excel");
            this.balloonTip1.SetBalloonText(this.btnMisASignadasHorario, null);
            this.btnMisASignadasHorario.Image = ((System.Drawing.Image)(resources.GetObject("btnMisASignadasHorario.Image")));
            this.btnMisASignadasHorario.ImageFixedSize = new System.Drawing.Size(18, 18);
            this.btnMisASignadasHorario.Location = new System.Drawing.Point(936, 277);
            this.btnMisASignadasHorario.Name = "btnMisASignadasHorario";
            this.btnMisASignadasHorario.Size = new System.Drawing.Size(20, 20);
            this.btnMisASignadasHorario.TabIndex = 78;
            this.btnMisASignadasHorario.Click += new System.EventHandler(this.btnMisASignadasHorario_Click);
            // 
            // btnGuardarGrdIngEspRespuesta
            // 
            this.btnGuardarGrdIngEspRespuesta.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGuardarGrdIngEspRespuesta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnGuardarGrdIngEspRespuesta, "Guardar Columnas");
            this.balloonTip1.SetBalloonText(this.btnGuardarGrdIngEspRespuesta, "Guarda El Esquema de las Columnas");
            this.btnGuardarGrdIngEspRespuesta.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarGrdIngEspRespuesta.Image")));
            this.btnGuardarGrdIngEspRespuesta.ImageFixedSize = new System.Drawing.Size(18, 18);
            this.btnGuardarGrdIngEspRespuesta.Location = new System.Drawing.Point(985, 73);
            this.btnGuardarGrdIngEspRespuesta.Name = "btnGuardarGrdIngEspRespuesta";
            this.btnGuardarGrdIngEspRespuesta.Size = new System.Drawing.Size(20, 20);
            this.btnGuardarGrdIngEspRespuesta.TabIndex = 77;
            this.btnGuardarGrdIngEspRespuesta.Click += new System.EventHandler(this.btnGuardarGrdIngEspRespuesta_Click);
            // 
            // btnRestaurarGrdIngEspRespuesta
            // 
            this.btnRestaurarGrdIngEspRespuesta.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRestaurarGrdIngEspRespuesta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnRestaurarGrdIngEspRespuesta, "Restaurar Columnas");
            this.balloonTip1.SetBalloonText(this.btnRestaurarGrdIngEspRespuesta, "Restaurar Columnas a su Valor Original");
            this.btnRestaurarGrdIngEspRespuesta.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurarGrdIngEspRespuesta.Image")));
            this.btnRestaurarGrdIngEspRespuesta.ImageFixedSize = new System.Drawing.Size(18, 18);
            this.btnRestaurarGrdIngEspRespuesta.Location = new System.Drawing.Point(962, 73);
            this.btnRestaurarGrdIngEspRespuesta.Name = "btnRestaurarGrdIngEspRespuesta";
            this.btnRestaurarGrdIngEspRespuesta.Size = new System.Drawing.Size(20, 20);
            this.btnRestaurarGrdIngEspRespuesta.TabIndex = 76;
            this.btnRestaurarGrdIngEspRespuesta.Click += new System.EventHandler(this.btnRestaurarGrdIngEspRespuesta_Click);
            // 
            // btnGuardarGrdIngAsignadas
            // 
            this.btnGuardarGrdIngAsignadas.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGuardarGrdIngAsignadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnGuardarGrdIngAsignadas, "Guardar Columnas");
            this.balloonTip1.SetBalloonText(this.btnGuardarGrdIngAsignadas, "Guarda El Esquema de las Columnas");
            this.btnGuardarGrdIngAsignadas.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarGrdIngAsignadas.Image")));
            this.btnGuardarGrdIngAsignadas.ImageFixedSize = new System.Drawing.Size(18, 18);
            this.btnGuardarGrdIngAsignadas.Location = new System.Drawing.Point(982, 277);
            this.btnGuardarGrdIngAsignadas.Name = "btnGuardarGrdIngAsignadas";
            this.btnGuardarGrdIngAsignadas.Size = new System.Drawing.Size(20, 20);
            this.btnGuardarGrdIngAsignadas.TabIndex = 75;
            this.btnGuardarGrdIngAsignadas.Click += new System.EventHandler(this.btnGuardarGrdIngAsignadas_Click);
            // 
            // btnRestaurarGrdOrdenesINg
            // 
            this.btnRestaurarGrdOrdenesINg.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRestaurarGrdOrdenesINg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnRestaurarGrdOrdenesINg, "Restaurar Columnas");
            this.balloonTip1.SetBalloonText(this.btnRestaurarGrdOrdenesINg, "Restaurar Columnas a su Valor Original");
            this.btnRestaurarGrdOrdenesINg.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurarGrdOrdenesINg.Image")));
            this.btnRestaurarGrdOrdenesINg.ImageFixedSize = new System.Drawing.Size(18, 18);
            this.btnRestaurarGrdOrdenesINg.Location = new System.Drawing.Point(959, 277);
            this.btnRestaurarGrdOrdenesINg.Name = "btnRestaurarGrdOrdenesINg";
            this.btnRestaurarGrdOrdenesINg.Size = new System.Drawing.Size(20, 20);
            this.btnRestaurarGrdOrdenesINg.TabIndex = 74;
            this.btnRestaurarGrdOrdenesINg.Click += new System.EventHandler(this.btnRestaurarGrdOrdenesINg_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblNivel3b);
            this.groupBox2.Controls.Add(this.buttonX4);
            this.groupBox2.Controls.Add(this.lblnivel2b);
            this.groupBox2.Controls.Add(this.picNivel3b);
            this.groupBox2.Controls.Add(this.picNivel1b);
            this.groupBox2.Controls.Add(this.picNivel2b);
            this.groupBox2.Controls.Add(this.picEnEsperab);
            this.groupBox2.Controls.Add(this.picPrioridadAltab);
            this.groupBox2.Controls.Add(this.lblNivel1b);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Location = new System.Drawing.Point(658, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 66);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            // 
            // lblNivel3b
            // 
            this.lblNivel3b.AutoSize = true;
            this.lblNivel3b.Location = new System.Drawing.Point(225, 41);
            this.lblNivel3b.Name = "lblNivel3b";
            this.lblNivel3b.Size = new System.Drawing.Size(91, 13);
            this.lblNivel3b.TabIndex = 12;
            this.lblNivel3b.Text = "10 dias de retrazo";
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.buttonX4, "Configurar Colores y Tiempos ");
            this.buttonX4.Image = ((System.Drawing.Image)(resources.GetObject("buttonX4.Image")));
            this.buttonX4.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.buttonX4.Location = new System.Drawing.Point(317, 5);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(30, 30);
            this.buttonX4.TabIndex = 41;
            this.buttonX4.Click += new System.EventHandler(this.buttonX4_Click);
            // 
            // lblnivel2b
            // 
            this.lblnivel2b.AutoSize = true;
            this.lblnivel2b.Location = new System.Drawing.Point(114, 41);
            this.lblnivel2b.Name = "lblnivel2b";
            this.lblnivel2b.Size = new System.Drawing.Size(91, 13);
            this.lblnivel2b.TabIndex = 11;
            this.lblnivel2b.Text = "10 dias de retrazo";
            // 
            // picNivel3b
            // 
            this.picNivel3b.BackColor = System.Drawing.Color.Red;
            this.picNivel3b.Location = new System.Drawing.Point(315, 40);
            this.picNivel3b.Name = "picNivel3b";
            this.picNivel3b.Size = new System.Drawing.Size(20, 15);
            this.picNivel3b.TabIndex = 10;
            this.picNivel3b.TabStop = false;
            // 
            // picNivel1b
            // 
            this.picNivel1b.BackColor = System.Drawing.Color.LightCoral;
            this.picNivel1b.Location = new System.Drawing.Point(94, 40);
            this.picNivel1b.Name = "picNivel1b";
            this.picNivel1b.Size = new System.Drawing.Size(20, 15);
            this.picNivel1b.TabIndex = 9;
            this.picNivel1b.TabStop = false;
            // 
            // picNivel2b
            // 
            this.picNivel2b.BackColor = System.Drawing.Color.Brown;
            this.picNivel2b.Location = new System.Drawing.Point(207, 40);
            this.picNivel2b.Name = "picNivel2b";
            this.picNivel2b.Size = new System.Drawing.Size(20, 15);
            this.picNivel2b.TabIndex = 8;
            this.picNivel2b.TabStop = false;
            // 
            // picEnEsperab
            // 
            this.picEnEsperab.BackColor = System.Drawing.Color.Khaki;
            this.picEnEsperab.Location = new System.Drawing.Point(131, 19);
            this.picEnEsperab.Name = "picEnEsperab";
            this.picEnEsperab.Size = new System.Drawing.Size(20, 15);
            this.picEnEsperab.TabIndex = 7;
            this.picEnEsperab.TabStop = false;
            // 
            // picPrioridadAltab
            // 
            this.picPrioridadAltab.BackColor = System.Drawing.Color.DarkSlateGray;
            this.picPrioridadAltab.Location = new System.Drawing.Point(236, 19);
            this.picPrioridadAltab.Name = "picPrioridadAltab";
            this.picPrioridadAltab.Size = new System.Drawing.Size(20, 15);
            this.picPrioridadAltab.TabIndex = 6;
            this.picPrioridadAltab.TabStop = false;
            // 
            // lblNivel1b
            // 
            this.lblNivel1b.AutoSize = true;
            this.lblNivel1b.Location = new System.Drawing.Point(0, 41);
            this.lblNivel1b.Name = "lblNivel1b";
            this.lblNivel1b.Size = new System.Drawing.Size(91, 13);
            this.lblNivel1b.TabIndex = 2;
            this.lblNivel1b.Text = "10 dias de retrazo";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(168, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Prioridad Alta";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(119, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "En espera de respuesta";
            // 
            // cmbIngenieros
            // 
            this.cmbIngenieros.DataSource = this.dsSPXSeguridad1;
            this.cmbIngenieros.DisplayMember = "usuario.login";
            this.cmbIngenieros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIngenieros.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIngenieros.FormattingEnabled = true;
            this.cmbIngenieros.Location = new System.Drawing.Point(14, 7);
            this.cmbIngenieros.Name = "cmbIngenieros";
            this.cmbIngenieros.Size = new System.Drawing.Size(284, 23);
            this.cmbIngenieros.TabIndex = 40;
            this.cmbIngenieros.ValueMember = "usuario.login";
            this.cmbIngenieros.SelectedIndexChanged += new System.EventHandler(this.cmbIngenieros_SelectedIndexChanged);
            // 
            // dsSPXSeguridad1
            // 
            this.dsSPXSeguridad1.DataSetName = "dsSPXSeguridad";
            this.dsSPXSeguridad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // c1CalendarIng
            // 
            this.c1CalendarIng.BoldedDates = new System.DateTime[0];
            this.c1CalendarIng.CalendarDimensions = 3;
            this.c1CalendarIng.Location = new System.Drawing.Point(12, 404);
            this.c1CalendarIng.Name = "c1CalendarIng";
            this.c1CalendarIng.Schedule = this.calendarioIngeniero;
            this.c1CalendarIng.Size = new System.Drawing.Size(638, 200);
            this.c1CalendarIng.TabIndex = 39;
           // this.c1CalendarIng.VisualStyle = C1.Win.C1Schedule.UI.VisualStyle.Royale;
            this.c1CalendarIng.SelectionChanged += new System.EventHandler<C1.Win.C1Schedule.SelectionChangedEventArgs>(this.c1CalendarIng_SelectionChanged);
            // 
            // grdOrdenesIngeniero
            // 
            this.grdOrdenesIngeniero.AllowUpdate = false;
            this.grdOrdenesIngeniero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdOrdenesIngeniero.DataMember = "pltListadoOrdenServicio";
            this.grdOrdenesIngeniero.DataSource = this.dsOrdenesIngeniero;
            this.grdOrdenesIngeniero.FetchRowStyles = true;
            this.grdOrdenesIngeniero.FilterBar = true;
            this.grdOrdenesIngeniero.Images.Add(((System.Drawing.Image)(resources.GetObject("grdOrdenesIngeniero.Images"))));
            this.grdOrdenesIngeniero.Location = new System.Drawing.Point(658, 298);
            this.grdOrdenesIngeniero.Name = "grdOrdenesIngeniero";
            this.grdOrdenesIngeniero.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdOrdenesIngeniero.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdOrdenesIngeniero.PreviewInfo.ZoomFactor = 75D;
            this.grdOrdenesIngeniero.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdOrdenesIngeniero.PrintInfo.PageSettings")));
            this.grdOrdenesIngeniero.Size = new System.Drawing.Size(344, 224);
            this.grdOrdenesIngeniero.TabIndex = 38;
            this.grdOrdenesIngeniero.Text = "c1TrueDBGrid1";
            this.grdOrdenesIngeniero.FetchRowStyle += new C1.Win.C1TrueDBGrid.FetchRowStyleEventHandler(this.grdOrdenesIngeniero_FetchRowStyle);
            this.grdOrdenesIngeniero.DoubleClick += new System.EventHandler(this.grdOrdenesIngeniero_DoubleClick);
            this.grdOrdenesIngeniero.PropBag = resources.GetString("grdOrdenesIngeniero.PropBag");
            // 
            // dsOrdenesIngeniero
            // 
            this.dsOrdenesIngeniero.DataSetName = "dsPlantillas";
            this.dsOrdenesIngeniero.EnforceConstraints = false;
            this.dsOrdenesIngeniero.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(654, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "Ordenes de Servicio Asignadas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(653, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(298, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "Ordenes de Servicio En Espera de Respuesta";
            // 
            // grdOrdenesIngenieroEspRespuesta
            // 
            this.grdOrdenesIngenieroEspRespuesta.AllowUpdate = false;
            this.grdOrdenesIngenieroEspRespuesta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdOrdenesIngenieroEspRespuesta.DataMember = "pltListadoOrdenServicio";
            this.grdOrdenesIngenieroEspRespuesta.DataSource = this.dsOrdenesIngenieroEnEspera;
            this.grdOrdenesIngenieroEspRespuesta.FilterBar = true;
            this.grdOrdenesIngenieroEspRespuesta.Images.Add(((System.Drawing.Image)(resources.GetObject("grdOrdenesIngenieroEspRespuesta.Images"))));
            this.grdOrdenesIngenieroEspRespuesta.Location = new System.Drawing.Point(659, 96);
            this.grdOrdenesIngenieroEspRespuesta.Name = "grdOrdenesIngenieroEspRespuesta";
            this.grdOrdenesIngenieroEspRespuesta.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdOrdenesIngenieroEspRespuesta.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdOrdenesIngenieroEspRespuesta.PreviewInfo.ZoomFactor = 75D;
            this.grdOrdenesIngenieroEspRespuesta.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdOrdenesIngenieroEspRespuesta.PrintInfo.PageSettings")));
            this.grdOrdenesIngenieroEspRespuesta.Size = new System.Drawing.Size(344, 178);
            this.grdOrdenesIngenieroEspRespuesta.TabIndex = 33;
            this.grdOrdenesIngenieroEspRespuesta.Text = "c1TrueDBGrid1";
            this.grdOrdenesIngenieroEspRespuesta.DoubleClick += new System.EventHandler(this.grdOrdenesIngenieroEspRespuesta_DoubleClick);
            this.grdOrdenesIngenieroEspRespuesta.PropBag = resources.GetString("grdOrdenesIngenieroEspRespuesta.PropBag");
            // 
            // dsOrdenesIngenieroEnEspera
            // 
            this.dsOrdenesIngenieroEnEspera.DataSetName = "dsPlantillas";
            this.dsOrdenesIngenieroEnEspera.EnforceConstraints = false;
            this.dsOrdenesIngenieroEnEspera.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnActualizarIngeniero
            // 
            this.btnActualizarIngeniero.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnActualizarIngeniero, "Actualizar");
            this.balloonTip1.SetBalloonText(this.btnActualizarIngeniero, null);
            this.btnActualizarIngeniero.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarIngeniero.Image")));
            this.btnActualizarIngeniero.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnActualizarIngeniero.Location = new System.Drawing.Point(615, 7);
            this.btnActualizarIngeniero.Name = "btnActualizarIngeniero";
            this.btnActualizarIngeniero.Size = new System.Drawing.Size(33, 33);
            this.btnActualizarIngeniero.TabIndex = 32;
            this.btnActualizarIngeniero.Click += new System.EventHandler(this.btnActualizarIngeniero_Click);
            // 
            // btnHoyIngeniero
            // 
            this.btnHoyIngeniero.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnHoyIngeniero, "Ir a hoy");
            this.balloonTip1.SetBalloonText(this.btnHoyIngeniero, null);
            this.btnHoyIngeniero.Image = ((System.Drawing.Image)(resources.GetObject("btnHoyIngeniero.Image")));
            this.btnHoyIngeniero.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnHoyIngeniero.Location = new System.Drawing.Point(579, 7);
            this.btnHoyIngeniero.Name = "btnHoyIngeniero";
            this.btnHoyIngeniero.Size = new System.Drawing.Size(33, 33);
            this.btnHoyIngeniero.TabIndex = 31;
            this.btnHoyIngeniero.Click += new System.EventHandler(this.btnHoyIngeniero_Click);
            // 
            // btn30Ing
            // 
            this.btn30Ing.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btn30Ing, "Ver Mes");
            this.balloonTip1.SetBalloonText(this.btn30Ing, null);
            this.btn30Ing.Image = ((System.Drawing.Image)(resources.GetObject("btn30Ing.Image")));
            this.btn30Ing.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btn30Ing.Location = new System.Drawing.Point(546, 7);
            this.btn30Ing.Name = "btn30Ing";
            this.btn30Ing.Size = new System.Drawing.Size(33, 33);
            this.btn30Ing.TabIndex = 30;
            this.btn30Ing.Click += new System.EventHandler(this.btn30Ing_Click);
            // 
            // btn7Ing
            // 
            this.btn7Ing.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btn7Ing, "Ver Semana");
            this.balloonTip1.SetBalloonText(this.btn7Ing, null);
            this.btn7Ing.Image = ((System.Drawing.Image)(resources.GetObject("btn7Ing.Image")));
            this.btn7Ing.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btn7Ing.Location = new System.Drawing.Point(513, 7);
            this.btn7Ing.Name = "btn7Ing";
            this.btn7Ing.Size = new System.Drawing.Size(33, 33);
            this.btn7Ing.TabIndex = 29;
            this.btn7Ing.Click += new System.EventHandler(this.btn7Ing_Click);
            // 
            // btn5ing
            // 
            this.btn5ing.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btn5ing, "Ver Semana Laboral");
            this.balloonTip1.SetBalloonText(this.btn5ing, null);
            this.btn5ing.Image = ((System.Drawing.Image)(resources.GetObject("btn5ing.Image")));
            this.btn5ing.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btn5ing.Location = new System.Drawing.Point(480, 7);
            this.btn5ing.Name = "btn5ing";
            this.btn5ing.Size = new System.Drawing.Size(33, 33);
            this.btn5ing.TabIndex = 28;
            this.btn5ing.Click += new System.EventHandler(this.btn5ing_Click);
            // 
            // btnDiaIng
            // 
            this.btnDiaIng.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnDiaIng, "Ver Dia");
            this.balloonTip1.SetBalloonText(this.btnDiaIng, null);
            this.btnDiaIng.Image = ((System.Drawing.Image)(resources.GetObject("btnDiaIng.Image")));
            this.btnDiaIng.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnDiaIng.Location = new System.Drawing.Point(447, 7);
            this.btnDiaIng.Name = "btnDiaIng";
            this.btnDiaIng.Size = new System.Drawing.Size(33, 33);
            this.btnDiaIng.TabIndex = 27;
            this.btnDiaIng.Click += new System.EventHandler(this.btnDiaIng_Click);
            // 
            // tabActividadesIng
            // 
            this.tabActividadesIng.AttachedControl = this.tabControlPanel2;
            this.tabActividadesIng.Name = "tabActividadesIng";
            this.tabActividadesIng.Text = "Actividades de Ingenieros";
            // 
            // tabControlPanel5
            // 
            this.tabControlPanel5.Controls.Add(this.buttonX1);
            this.tabControlPanel5.Controls.Add(this.grdEntradasSinSeguimiento);
            this.tabControlPanel5.Controls.Add(this.grdEntradasSinSalida);
            this.tabControlPanel5.Controls.Add(this.btnVerEntradaSinSeguimiento);
            this.tabControlPanel5.Controls.Add(this.btnVerEntradaSinSalida);
            this.tabControlPanel5.Controls.Add(this.btnVerEntradaSinOrden);
            this.tabControlPanel5.Controls.Add(this.controladorColumnasEntradasSinSeguimiento);
            this.tabControlPanel5.Controls.Add(this.controladorColumnasEntradaSinSalida);
            this.tabControlPanel5.Controls.Add(this.controladorColumnasEntradasSinOrden);
            this.tabControlPanel5.Controls.Add(this.label9);
            this.tabControlPanel5.Controls.Add(this.grdEntradasSinOrden);
            this.tabControlPanel5.Controls.Add(this.label7);
            this.tabControlPanel5.Controls.Add(this.label8);
            this.tabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel5.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel5.Name = "tabControlPanel5";
            this.tabControlPanel5.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel5.Size = new System.Drawing.Size(1015, 534);
            this.tabControlPanel5.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(250)))), ((int)(((byte)(247)))));
            this.tabControlPanel5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel5.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.tabControlPanel5.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel5.Style.GradientAngle = 90;
            this.tabControlPanel5.TabIndex = 5;
            this.tabControlPanel5.TabItem = this.tabListadoEntradas;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.buttonX1, "Actualizar");
            this.balloonTip1.SetBalloonText(this.buttonX1, null);
            this.buttonX1.Image = ((System.Drawing.Image)(resources.GetObject("buttonX1.Image")));
            this.buttonX1.ImageFixedSize = new System.Drawing.Size(15, 15);
            this.buttonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonX1.Location = new System.Drawing.Point(21, 0);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(22, 21);
            this.buttonX1.TabIndex = 58;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // grdEntradasSinSeguimiento
            // 
            this.grdEntradasSinSeguimiento.AllowUpdate = false;
            this.grdEntradasSinSeguimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdEntradasSinSeguimiento.DataMember = "pltListadoESequipos";
            this.grdEntradasSinSeguimiento.DataSource = this.dsOrdenesIngenieroEnEspera;
            this.grdEntradasSinSeguimiento.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdEntradasSinSeguimiento.GroupByCaption = "";
            this.grdEntradasSinSeguimiento.Images.Add(((System.Drawing.Image)(resources.GetObject("grdEntradasSinSeguimiento.Images"))));
            this.grdEntradasSinSeguimiento.Location = new System.Drawing.Point(588, 356);
            this.grdEntradasSinSeguimiento.Name = "grdEntradasSinSeguimiento";
            this.grdEntradasSinSeguimiento.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdEntradasSinSeguimiento.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdEntradasSinSeguimiento.PreviewInfo.ZoomFactor = 75D;
            this.grdEntradasSinSeguimiento.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdEntradasSinSeguimiento.PrintInfo.PageSettings")));
            this.grdEntradasSinSeguimiento.Size = new System.Drawing.Size(412, 164);
            this.grdEntradasSinSeguimiento.TabIndex = 34;
            this.grdEntradasSinSeguimiento.Text = "c1TrueDBGrid4";
            this.grdEntradasSinSeguimiento.PropBag = resources.GetString("grdEntradasSinSeguimiento.PropBag");
            // 
            // grdEntradasSinSalida
            // 
            this.grdEntradasSinSalida.AllowUpdate = false;
            this.grdEntradasSinSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grdEntradasSinSalida.DataMember = "pltListadoESequipos";
            this.grdEntradasSinSalida.DataSource = this.dsPlantillasIngenieros;
            this.grdEntradasSinSalida.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdEntradasSinSalida.GroupByCaption = "";
            this.grdEntradasSinSalida.Images.Add(((System.Drawing.Image)(resources.GetObject("grdEntradasSinSalida.Images"))));
            this.grdEntradasSinSalida.Location = new System.Drawing.Point(588, 43);
            this.grdEntradasSinSalida.Name = "grdEntradasSinSalida";
            this.grdEntradasSinSalida.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdEntradasSinSalida.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdEntradasSinSalida.PreviewInfo.ZoomFactor = 75D;
            this.grdEntradasSinSalida.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdEntradasSinSalida.PrintInfo.PageSettings")));
            this.grdEntradasSinSalida.Size = new System.Drawing.Size(412, 263);
            this.grdEntradasSinSalida.TabIndex = 33;
            this.grdEntradasSinSalida.Text = "c1TrueDBGrid4";
            this.grdEntradasSinSalida.PropBag = resources.GetString("grdEntradasSinSalida.PropBag");
            // 
            // btnVerEntradaSinSeguimiento
            // 
            this.btnVerEntradaSinSeguimiento.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVerEntradaSinSeguimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnVerEntradaSinSeguimiento, "Ver Entrada/Salida");
            this.balloonTip1.SetBalloonText(this.btnVerEntradaSinSeguimiento, null);
            this.btnVerEntradaSinSeguimiento.Image = ((System.Drawing.Image)(resources.GetObject("btnVerEntradaSinSeguimiento.Image")));
            this.btnVerEntradaSinSeguimiento.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnVerEntradaSinSeguimiento.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnVerEntradaSinSeguimiento.Location = new System.Drawing.Point(761, 322);
            this.btnVerEntradaSinSeguimiento.Name = "btnVerEntradaSinSeguimiento";
            this.btnVerEntradaSinSeguimiento.Size = new System.Drawing.Size(28, 28);
            this.btnVerEntradaSinSeguimiento.TabIndex = 32;
            this.btnVerEntradaSinSeguimiento.Click += new System.EventHandler(this.btnVerEntradaSinSeguimiento_Click);
            // 
            // btnVerEntradaSinSalida
            // 
            this.btnVerEntradaSinSalida.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVerEntradaSinSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnVerEntradaSinSalida, "Ver Entrada/Salida");
            this.balloonTip1.SetBalloonText(this.btnVerEntradaSinSalida, null);
            this.btnVerEntradaSinSalida.Image = ((System.Drawing.Image)(resources.GetObject("btnVerEntradaSinSalida.Image")));
            this.btnVerEntradaSinSalida.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnVerEntradaSinSalida.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnVerEntradaSinSalida.Location = new System.Drawing.Point(760, 12);
            this.btnVerEntradaSinSalida.Name = "btnVerEntradaSinSalida";
            this.btnVerEntradaSinSalida.Size = new System.Drawing.Size(28, 28);
            this.btnVerEntradaSinSalida.TabIndex = 31;
            this.btnVerEntradaSinSalida.Click += new System.EventHandler(this.btnVerEntradaSinSalida_Click);
            // 
            // btnVerEntradaSinOrden
            // 
            this.btnVerEntradaSinOrden.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVerEntradaSinOrden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnVerEntradaSinOrden, "Ver Entrada/Salida");
            this.btnVerEntradaSinOrden.Image = ((System.Drawing.Image)(resources.GetObject("btnVerEntradaSinOrden.Image")));
            this.btnVerEntradaSinOrden.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnVerEntradaSinOrden.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnVerEntradaSinOrden.Location = new System.Drawing.Point(334, 13);
            this.btnVerEntradaSinOrden.Name = "btnVerEntradaSinOrden";
            this.btnVerEntradaSinOrden.Size = new System.Drawing.Size(28, 28);
            this.btnVerEntradaSinOrden.TabIndex = 30;
            this.btnVerEntradaSinOrden.Click += new System.EventHandler(this.btnVerEntradaSinOrden_Click);
            // 
            // controladorColumnasEntradasSinSeguimiento
            // 
            this.controladorColumnasEntradasSinSeguimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controladorColumnasEntradasSinSeguimiento.BackColor = System.Drawing.Color.Transparent;
            this.controladorColumnasEntradasSinSeguimiento.grilla = null;
            this.controladorColumnasEntradasSinSeguimiento.Location = new System.Drawing.Point(790, 322);
            this.controladorColumnasEntradasSinSeguimiento.MostrarContraer = true;
            this.controladorColumnasEntradasSinSeguimiento.MostrarExcel = true;
            this.controladorColumnasEntradasSinSeguimiento.MostrarExpandir = true;
            this.controladorColumnasEntradasSinSeguimiento.MostrarLimpiar = true;
            this.controladorColumnasEntradasSinSeguimiento.Name = "controladorColumnasEntradasSinSeguimiento";
            this.controladorColumnasEntradasSinSeguimiento.nombreLibro = null;
            this.controladorColumnasEntradasSinSeguimiento.Size = new System.Drawing.Size(216, 29);
            this.controladorColumnasEntradasSinSeguimiento.TabIndex = 22;
            // 
            // controladorColumnasEntradaSinSalida
            // 
            this.controladorColumnasEntradaSinSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controladorColumnasEntradaSinSalida.BackColor = System.Drawing.Color.Transparent;
            this.controladorColumnasEntradaSinSalida.grilla = null;
            this.controladorColumnasEntradaSinSalida.Location = new System.Drawing.Point(789, 12);
            this.controladorColumnasEntradaSinSalida.MostrarContraer = true;
            this.controladorColumnasEntradaSinSalida.MostrarExcel = true;
            this.controladorColumnasEntradaSinSalida.MostrarExpandir = true;
            this.controladorColumnasEntradaSinSalida.MostrarLimpiar = true;
            this.controladorColumnasEntradaSinSalida.Name = "controladorColumnasEntradaSinSalida";
            this.controladorColumnasEntradaSinSalida.nombreLibro = null;
            this.controladorColumnasEntradaSinSalida.Size = new System.Drawing.Size(216, 29);
            this.controladorColumnasEntradaSinSalida.TabIndex = 21;
            // 
            // controladorColumnasEntradasSinOrden
            // 
            this.controladorColumnasEntradasSinOrden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controladorColumnasEntradasSinOrden.BackColor = System.Drawing.Color.Transparent;
            this.controladorColumnasEntradasSinOrden.grilla = null;
            this.controladorColumnasEntradasSinOrden.Location = new System.Drawing.Point(364, 13);
            this.controladorColumnasEntradasSinOrden.MostrarContraer = true;
            this.controladorColumnasEntradasSinOrden.MostrarExcel = true;
            this.controladorColumnasEntradasSinOrden.MostrarExpandir = true;
            this.controladorColumnasEntradasSinOrden.MostrarLimpiar = true;
            this.controladorColumnasEntradasSinOrden.Name = "controladorColumnasEntradasSinOrden";
            this.controladorColumnasEntradasSinOrden.nombreLibro = null;
            this.controladorColumnasEntradasSinOrden.Size = new System.Drawing.Size(216, 29);
            this.controladorColumnasEntradasSinOrden.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(590, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Entradas Sin Seguimiento";
            // 
            // grdEntradasSinOrden
            // 
            this.grdEntradasSinOrden.AllowUpdate = false;
            this.grdEntradasSinOrden.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdEntradasSinOrden.DataMember = "pltListadoESequipos";
            this.grdEntradasSinOrden.DataSource = this.dsPlantillas1;
            this.grdEntradasSinOrden.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdEntradasSinOrden.GroupByCaption = "";
            this.grdEntradasSinOrden.Images.Add(((System.Drawing.Image)(resources.GetObject("grdEntradasSinOrden.Images"))));
            this.grdEntradasSinOrden.Location = new System.Drawing.Point(18, 46);
            this.grdEntradasSinOrden.Name = "grdEntradasSinOrden";
            this.grdEntradasSinOrden.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdEntradasSinOrden.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdEntradasSinOrden.PreviewInfo.ZoomFactor = 75D;
            this.grdEntradasSinOrden.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdEntradasSinOrden.PrintInfo.PageSettings")));
            this.grdEntradasSinOrden.Size = new System.Drawing.Size(556, 474);
            this.grdEntradasSinOrden.TabIndex = 16;
            this.grdEntradasSinOrden.Text = "c1TrueDBGrid4";
            this.grdEntradasSinOrden.PropBag = resources.GetString("grdEntradasSinOrden.PropBag");
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(591, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Entradas Sin Salida";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(18, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Entradas Sin Orden de Servicio";
            // 
            // tabListadoEntradas
            // 
            this.tabListadoEntradas.AttachedControl = this.tabControlPanel5;
            this.tabListadoEntradas.Name = "tabListadoEntradas";
            this.tabListadoEntradas.Text = "Entradas";
            // 
            // tabControlPanel6
            // 
            this.tabControlPanel6.Controls.Add(this.btnActualizarMaestro);
            this.tabControlPanel6.Controls.Add(this.btnVerContratoxVencer);
            this.tabControlPanel6.Controls.Add(this.controladorColumnasContratoVencido);
            this.tabControlPanel6.Controls.Add(this.controladorColumnasContratosxVencer);
            this.tabControlPanel6.Controls.Add(this.btnVerContratoVencido);
            this.tabControlPanel6.Controls.Add(this.grdContratosVencidos);
            this.tabControlPanel6.Controls.Add(this.grdContratosxVencer);
            this.tabControlPanel6.Controls.Add(this.label11);
            this.tabControlPanel6.Controls.Add(this.label10);
            this.tabControlPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel6.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel6.Name = "tabControlPanel6";
            this.tabControlPanel6.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel6.Size = new System.Drawing.Size(1015, 534);
            this.tabControlPanel6.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(250)))), ((int)(((byte)(247)))));
            this.tabControlPanel6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel6.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.tabControlPanel6.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel6.Style.GradientAngle = 90;
            this.tabControlPanel6.TabIndex = 6;
            this.tabControlPanel6.TabItem = this.tabContratos;
            // 
            // btnActualizarMaestro
            // 
            this.btnActualizarMaestro.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnActualizarMaestro, "Actualizar");
            this.btnActualizarMaestro.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarMaestro.Image")));
            this.btnActualizarMaestro.ImageFixedSize = new System.Drawing.Size(15, 15);
            this.btnActualizarMaestro.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnActualizarMaestro.Location = new System.Drawing.Point(15, 0);
            this.btnActualizarMaestro.Name = "btnActualizarMaestro";
            this.btnActualizarMaestro.Size = new System.Drawing.Size(22, 21);
            this.btnActualizarMaestro.TabIndex = 57;
            this.btnActualizarMaestro.Click += new System.EventHandler(this.btnActualizarMaestro_Click);
            // 
            // btnVerContratoxVencer
            // 
            this.btnVerContratoxVencer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVerContratoxVencer.Image = ((System.Drawing.Image)(resources.GetObject("btnVerContratoxVencer.Image")));
            this.btnVerContratoxVencer.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnVerContratoxVencer.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnVerContratoxVencer.Location = new System.Drawing.Point(327, 6);
            this.btnVerContratoxVencer.Name = "btnVerContratoxVencer";
            this.btnVerContratoxVencer.Size = new System.Drawing.Size(32, 29);
            this.btnVerContratoxVencer.TabIndex = 56;
            this.btnVerContratoxVencer.Click += new System.EventHandler(this.btnVerContratoxVencer_Click);
            // 
            // controladorColumnasContratoVencido
            // 
            this.controladorColumnasContratoVencido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controladorColumnasContratoVencido.BackColor = System.Drawing.Color.Transparent;
            this.controladorColumnasContratoVencido.grilla = null;
            this.controladorColumnasContratoVencido.Location = new System.Drawing.Point(790, 1);
            this.controladorColumnasContratoVencido.MostrarContraer = true;
            this.controladorColumnasContratoVencido.MostrarExcel = true;
            this.controladorColumnasContratoVencido.MostrarExpandir = true;
            this.controladorColumnasContratoVencido.MostrarLimpiar = true;
            this.controladorColumnasContratoVencido.Name = "controladorColumnasContratoVencido";
            this.controladorColumnasContratoVencido.nombreLibro = null;
            this.controladorColumnasContratoVencido.Size = new System.Drawing.Size(216, 29);
            this.controladorColumnasContratoVencido.TabIndex = 55;
            // 
            // controladorColumnasContratosxVencer
            // 
            this.controladorColumnasContratosxVencer.BackColor = System.Drawing.Color.Transparent;
            this.controladorColumnasContratosxVencer.grilla = null;
            this.controladorColumnasContratosxVencer.Location = new System.Drawing.Point(360, 6);
            this.controladorColumnasContratosxVencer.MostrarContraer = true;
            this.controladorColumnasContratosxVencer.MostrarExcel = true;
            this.controladorColumnasContratosxVencer.MostrarExpandir = true;
            this.controladorColumnasContratosxVencer.MostrarLimpiar = true;
            this.controladorColumnasContratosxVencer.Name = "controladorColumnasContratosxVencer";
            this.controladorColumnasContratosxVencer.nombreLibro = null;
            this.controladorColumnasContratosxVencer.Size = new System.Drawing.Size(216, 29);
            this.controladorColumnasContratosxVencer.TabIndex = 54;
            // 
            // btnVerContratoVencido
            // 
            this.btnVerContratoVencido.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVerContratoVencido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerContratoVencido.Image = ((System.Drawing.Image)(resources.GetObject("btnVerContratoVencido.Image")));
            this.btnVerContratoVencido.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnVerContratoVencido.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnVerContratoVencido.Location = new System.Drawing.Point(756, 1);
            this.btnVerContratoVencido.Name = "btnVerContratoVencido";
            this.btnVerContratoVencido.Size = new System.Drawing.Size(32, 29);
            this.btnVerContratoVencido.TabIndex = 52;
            this.btnVerContratoVencido.Click += new System.EventHandler(this.btnVerContratoVencido_Click);
            // 
            // grdContratosVencidos
            // 
            this.grdContratosVencidos.AllowUpdate = false;
            this.grdContratosVencidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdContratosVencidos.DataMember = "pltListaContratosVencimiento";
            this.grdContratosVencidos.DataSource = this.dsOrdenesIngeniero;
            this.grdContratosVencidos.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdContratosVencidos.FetchRowStyles = true;
            this.grdContratosVencidos.FilterBar = true;
            this.grdContratosVencidos.GroupByCaption = "";
            this.grdContratosVencidos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdContratosVencidos.Images"))));
            this.grdContratosVencidos.Location = new System.Drawing.Point(582, 34);
            this.grdContratosVencidos.Name = "grdContratosVencidos";
            this.grdContratosVencidos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdContratosVencidos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdContratosVencidos.PreviewInfo.ZoomFactor = 75D;
            this.grdContratosVencidos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdContratosVencidos.PrintInfo.PageSettings")));
            this.grdContratosVencidos.Size = new System.Drawing.Size(419, 483);
            this.grdContratosVencidos.TabIndex = 51;
            this.grdContratosVencidos.Text = "c1TrueDBGrid1";
            this.grdContratosVencidos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.grdContratosVencidos.PropBag = resources.GetString("grdContratosVencidos.PropBag");
            // 
            // grdContratosxVencer
            // 
            this.grdContratosxVencer.AllowUpdate = false;
            this.grdContratosxVencer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grdContratosxVencer.DataMember = "pltListaContratosVencimiento";
            this.grdContratosxVencer.DataSource = this.dsPlantillas1;
            this.grdContratosxVencer.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdContratosxVencer.FetchRowStyles = true;
            this.grdContratosxVencer.FilterBar = true;
            this.grdContratosxVencer.GroupByCaption = "";
            this.grdContratosxVencer.Images.Add(((System.Drawing.Image)(resources.GetObject("grdContratosxVencer.Images"))));
            this.grdContratosxVencer.Location = new System.Drawing.Point(14, 37);
            this.grdContratosxVencer.Name = "grdContratosxVencer";
            this.grdContratosxVencer.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdContratosxVencer.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdContratosxVencer.PreviewInfo.ZoomFactor = 75D;
            this.grdContratosxVencer.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdContratosxVencer.PrintInfo.PageSettings")));
            this.grdContratosxVencer.Size = new System.Drawing.Size(555, 483);
            this.grdContratosxVencer.TabIndex = 50;
            this.grdContratosxVencer.Text = "c1TrueDBGrid1";
            this.grdContratosxVencer.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.grdContratosxVencer.PropBag = resources.GetString("grdContratosxVencer.PropBag");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(580, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Contratos Vencidos Recientemente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(12, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(280, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Contratos con fecha de vencimiento en menos de un Mes";
            // 
            // tabContratos
            // 
            this.tabContratos.AttachedControl = this.tabControlPanel6;
            this.tabContratos.Name = "tabContratos";
            this.tabContratos.Text = "Contratos";
            // 
            // tabControlPanel7
            // 
            this.tabControlPanel7.Controls.Add(this.pictureBox3);
            this.tabControlPanel7.Controls.Add(this.pictureBox2);
            this.tabControlPanel7.Controls.Add(this.pictureBox1);
            this.tabControlPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel7.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel7.Name = "tabControlPanel7";
            this.tabControlPanel7.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel7.Size = new System.Drawing.Size(1015, 534);
            this.tabControlPanel7.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(250)))), ((int)(((byte)(247)))));
            this.tabControlPanel7.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel7.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.tabControlPanel7.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel7.Style.GradientAngle = 90;
            this.tabControlPanel7.TabIndex = 7;
            this.tabControlPanel7.TabItem = this.tabDefault;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(622, 426);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(389, 96);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(712, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(288, 261);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(470, 627);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabDefault
            // 
            this.tabDefault.AttachedControl = this.tabControlPanel7;
            this.tabDefault.Name = "tabDefault";
            this.tabDefault.Text = "Supportech X";
            // 
            // pltOrdenServicioSchedulleTableAdapter1
            // 
            this.pltOrdenServicioSchedulleTableAdapter1.ClearBeforeFill = true;
            // 
            // ordenServicioTableAdapter1
            // 
            this.ordenServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // pltListadoOrdenServicioTableAdapter1
            // 
            this.pltListadoOrdenServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // estadosOrdenServicioTableAdapter1
            // 
            this.estadosOrdenServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // pltListaContratosVencimientoTableAdapter1
            // 
            this.pltListaContratosVencimientoTableAdapter1.ClearBeforeFill = true;
            // 
            // dsSPXSeguridad2
            // 
            this.dsSPXSeguridad2.DataSetName = "dsSPXSeguridad";
            this.dsSPXSeguridad2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clsTusuario1
            // 
            this.clsTusuario1.nombreLlave = "cod_usuario";
            this.clsTusuario1.nombreTabla = "usuario";
            this.clsTusuario1.sentenciaBase = resources.GetString("clsTusuario1.sentenciaBase");
            this.clsTusuario1.sentenciaBaseDistinct = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 560);
            this.Controls.Add(this.tabEntradas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ventana Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabEntradas)).EndInit();
            this.tabEntradas.ResumeLayout(false);
            this.tabControlPanel3.ResumeLayout(false);
            this.tabControlPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calListadoLlamadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSeguimientosProgramados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLlamadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).EndInit();
            this.tabControlPanel1.ResumeLayout(false);
            this.tabControlPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendario.DataStorage.AppointmentStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendario.DataStorage.CategoryStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendario.DataStorage.ContactStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendario.DataStorage.LabelStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendario.DataStorage.OwnerStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendario.DataStorage.ResourceStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendario.DataStorage.StatusStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picnivel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNivel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNivel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnespera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrioridadAlta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdASignadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMisOrdenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Calendar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRespuesta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMisOrdenesEnEspera)).EndInit();
            this.tabControlPanel2.ResumeLayout(false);
            this.tabControlPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarioIngeniero.DataStorage.AppointmentStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarioIngeniero.DataStorage.CategoryStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarioIngeniero.DataStorage.ContactStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarioIngeniero.DataStorage.LabelStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarioIngeniero.DataStorage.OwnerStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarioIngeniero.DataStorage.ResourceStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarioIngeniero.DataStorage.StatusStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarioIngeniero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillasIngenieros)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNivel3b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNivel1b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNivel2b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnEsperab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrioridadAltab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CalendarIng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrdenesIngeniero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrdenesIngeniero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrdenesIngenieroEspRespuesta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrdenesIngenieroEnEspera)).EndInit();
            this.tabControlPanel5.ResumeLayout(false);
            this.tabControlPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEntradasSinSeguimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEntradasSinSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEntradasSinOrden)).EndInit();
            this.tabControlPanel6.ResumeLayout(false);
            this.tabControlPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContratosVencidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdContratosxVencer)).EndInit();
            this.tabControlPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.TabControl tabEntradas;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabMisActividades;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.TabItem tabActividadesIng;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel3;
        private DevComponents.DotNetBar.TabItem tabLlamadas;
        private DevComponents.DotNetBar.ButtonX btnActualizar;
        private DevComponents.DotNetBar.ButtonX btnHoy;
        private DevComponents.DotNetBar.ButtonX btn30;
        private DevComponents.DotNetBar.ButtonX btn7;
        private DevComponents.DotNetBar.ButtonX btn5;
        private DevComponents.DotNetBar.ButtonX btnDia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdRespuesta;
        private SPControladoraDatos.dsPlantillas dsPlantillas1;
        private SPControladoraDatos.dsPlantillasTableAdapters.pltOrdenServicioSchedulleTableAdapter pltOrdenServicioSchedulleTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter ordenServicioTableAdapter1;
        private C1.Win.C1Schedule.C1Calendar c1Calendar1;
        private C1.Win.C1Schedule.C1Schedule calendario;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private SPControladoraDatos.dsPlantillas dsMisOrdenes;
        private SPControladoraDatos.dsPlantillas dsMisOrdenesEnEspera;
        private SPControladoraDatos.dsPlantillasTableAdapters.pltListadoOrdenServicioTableAdapter pltListadoOrdenServicioTableAdapter1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblIngeniero;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdASignadas;
        private C1.Win.C1Schedule.C1Calendar c1CalendarIng;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdOrdenesIngeniero;
        private C1.Win.C1Schedule.C1Schedule calendarioIngeniero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdOrdenesIngenieroEspRespuesta;
        private DevComponents.DotNetBar.ButtonX btnActualizarIngeniero;
        private DevComponents.DotNetBar.ButtonX btnHoyIngeniero;
        private DevComponents.DotNetBar.ButtonX btn30Ing;
        private DevComponents.DotNetBar.ButtonX btn7Ing;
        private DevComponents.DotNetBar.ButtonX btn5ing;
        private DevComponents.DotNetBar.ButtonX btnDiaIng;
        private System.Windows.Forms.ComboBox cmbIngenieros;
        private SPControladoraDatos.dsPlantillas dsPlantillasIngenieros;
        private SPControladoraDatos.dsPlantillas dsOrdenesIngeniero;
        private SPControladoraDatos.dsPlantillas dsOrdenesIngenieroEnEspera;
        private System.Windows.Forms.ContextMenuStrip contextMenuIngeniero;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdSeguimientosProgramados;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdLlamadas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel5;
        private DevComponents.DotNetBar.TabItem tabListadoEntradas;
        private System.Windows.Forms.Label label9;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdEntradasSinOrden;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private DevComponents.DotNetBar.TabItem tabContratos;
        private SPControladoraDatos.dsSpxTableAdapters.estadosOrdenServicioTableAdapter estadosOrdenServicioTableAdapter1;
        private DevComponents.DotNetBar.ButtonX btnEsquemaColores;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picnivel3;
        private System.Windows.Forms.PictureBox picNivel1;
        private System.Windows.Forms.PictureBox picNivel2;
        private System.Windows.Forms.PictureBox picEnespera;
        private System.Windows.Forms.PictureBox picPrioridadAlta;
        private System.Windows.Forms.Label lblNivel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblNivel3;
        private System.Windows.Forms.Label lblNivel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNivel3b;
        private System.Windows.Forms.Label lblnivel2b;
        private System.Windows.Forms.PictureBox picNivel3b;
        private System.Windows.Forms.PictureBox picNivel1b;
        private System.Windows.Forms.PictureBox picNivel2b;
        private System.Windows.Forms.PictureBox picEnEsperab;
        private System.Windows.Forms.PictureBox picPrioridadAltab;
        private System.Windows.Forms.Label lblNivel1b;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private DevComponents.DotNetBar.ButtonX btnGuardargrdAsignadas;
        private DevComponents.DotNetBar.ButtonX btnReinicciargrdasignadas;
        private DevComponents.DotNetBar.ButtonX btnGuardarGrdRespuesta;
        private DevComponents.DotNetBar.ButtonX btnRestaurargrdRespuestas;
        private DevComponents.DotNetBar.ButtonX btnGuardarGrdIngEspRespuesta;
        private DevComponents.DotNetBar.ButtonX btnRestaurarGrdIngEspRespuesta;
        private DevComponents.DotNetBar.ButtonX btnGuardarGrdIngAsignadas;
        private DevComponents.DotNetBar.ButtonX btnRestaurarGrdOrdenesINg;
        private DevComponents.DotNetBar.ButtonX btnExcelMis1;
        private DevComponents.DotNetBar.ButtonX btnMisASignadasHorario;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel7;
        private DevComponents.DotNetBar.TabItem tabDefault;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calListadoLlamadas;
        private SPControladoraDatos.dsSpx dsSpx1;
        private controladorColumnas controladorColumnasListadoLlamadas1;
        private controladorColumnas controladorColumnasSeguimientoLlamadas;
        private DevComponents.DotNetBar.ButtonX btnVerSeguimientoLlamada;
        private DevComponents.DotNetBar.ButtonX btnVerLlamada;
        private controladorColumnas controladorColumnasEntradasSinSeguimiento;
        private controladorColumnas controladorColumnasEntradaSinSalida;
        private controladorColumnas controladorColumnasEntradasSinOrden;
        private DevComponents.DotNetBar.ButtonX btnVerEntradaSinSeguimiento;
        private DevComponents.DotNetBar.ButtonX btnVerEntradaSinSalida;
        private DevComponents.DotNetBar.ButtonX btnVerEntradaSinOrden;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdEntradasSinSalida;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdEntradasSinSeguimiento;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdContratosVencidos;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdContratosxVencer;
        private controladorColumnas controladorColumnasContratoVencido;
        private controladorColumnas controladorColumnasContratosxVencer;
        private DevComponents.DotNetBar.ButtonX btnVerContratoVencido;
        private DevComponents.DotNetBar.ButtonX btnVerContratoxVencer;
        private SPControladoraDatos.dsPlantillasTableAdapters.pltListaContratosVencimientoTableAdapter pltListaContratosVencimientoTableAdapter1;
        private DevComponents.DotNetBar.ButtonX btnActualizarMaestro;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad1;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad2;
        private SPXSeguridad.data.cls.clsTusuario clsTusuario1;

    }
}