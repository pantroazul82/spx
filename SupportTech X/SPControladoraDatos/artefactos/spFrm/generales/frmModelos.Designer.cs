namespace SpFrm.generales
{
    partial class frmModelos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModelos));
            C1.Win.C1TrueDBGrid.Style style33 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style34 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style35 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style36 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style37 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style38 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style39 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style40 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style25 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style26 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style27 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style28 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style29 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style30 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style31 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style32 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style41 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style42 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style43 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style44 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style45 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style46 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style47 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style48 = new C1.Win.C1TrueDBGrid.Style();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.modelosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter();
            this.subTipoEquipoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.subTipoEquipoTableAdapter();
            this.tipoEquipoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.tipoEquipoTableAdapter();
            this.archivosxModeloTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.archivosxModeloTableAdapter();
            this.fabricanteTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.fabricanteTableAdapter();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numFrecuenciaMantenimiento = new System.Windows.Forms.NumericUpDown();
            this.txtCodigoModelo = new System.Windows.Forms.TextBox();
            this.txtNombreModelo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.cmbTipoEquipo = new System.Windows.Forms.ComboBox();
            this.cmbsubtipoEquipo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picFotografia = new System.Windows.Forms.PictureBox();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.picManual = new System.Windows.Forms.PictureBox();
            this.btnVerManual = new System.Windows.Forms.Button();
            this.btnSubirManual = new System.Windows.Forms.Button();
            this.btnDescargarManual = new System.Windows.Forms.Button();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.btnQuitarArchivo = new System.Windows.Forms.Button();
            this.btnSubirArchivo = new System.Windows.Forms.Button();
            this.btnGuardarArchivo = new System.Windows.Forms.Button();
            this.btnVerArchivo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.grdArchivos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.c1CmbFabricante = new C1.Win.C1TrueDBGrid.C1TrueDBDropdown();
            this.c1TrueSubtipo = new C1.Win.C1TrueDBGrid.C1TrueDBDropdown();
            this.c1TrueDBTipoEquipo = new C1.Win.C1TrueDBGrid.C1TrueDBDropdown();
            this.txtVoltaje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmperios = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWatios = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFrecuencia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.nmHorasDuracion = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.nmMinutosDuracion = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.nmMesesFrecuencia = new System.Windows.Forms.NumericUpDown();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbUnidadPeso = new System.Windows.Forms.ComboBox();
            this.unidadPesoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.unidadPesoTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnGuardarFoto = new DevComponents.DotNetBar.ButtonX();
            this.btnVerFoto = new DevComponents.DotNetBar.ButtonX();
            this.btnSubirF = new DevComponents.DotNetBar.ButtonX();
            this.txtCodigoModeloManual = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelVariable = new DevComponents.DotNetBar.ButtonX();
            this.btnEditVariableMedicion = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregarVariableMedicion = new DevComponents.DotNetBar.ButtonX();
            this.grdVariablesMedicion = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsPlantillas1 = new SPControladoraDatos.dsPlantillas();
            this.pltVariablesMedicionxModeloTableAdapter1 = new SPControladoraDatos.dsPlantillasTableAdapters.pltVariablesMedicionxModeloTableAdapter();
            this.variables_medicionxmodeloTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.variables_medicionxmodeloTableAdapter();
            this.ribbonControlDataFrm.SuspendLayout();
            this.ribbonPanel1dataFrm.SuspendLayout();
            this.ribbonPanel2dataFrm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.grpOpcionesExportar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrecuenciaMantenimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotografia)).BeginInit();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picManual)).BeginInit();
            this.ribbonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdArchivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CmbFabricante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueSubtipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBTipoEquipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmHorasDuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMinutosDuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMesesFrecuencia)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVariablesMedicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControlDataFrm
            // 
            // 
            // 
            // 
            this.ribbonControlDataFrm.BackgroundStyle.Class = "";
            this.ribbonControlDataFrm.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControlDataFrm.Controls.Add(this.ribbonPanel1);
            this.ribbonControlDataFrm.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabItem1});
            this.ribbonControlDataFrm.Location = new System.Drawing.Point(5, 1);
            this.ribbonControlDataFrm.Size = new System.Drawing.Size(963, 586);
            this.ribbonControlDataFrm.SelectedRibbonTabChanged += new System.EventHandler(this.ribbonControlDataFrm_SelectedRibbonTabChanged);
            this.ribbonControlDataFrm.Controls.SetChildIndex(this.ribbonPanel1, 0);
            this.ribbonControlDataFrm.Controls.SetChildIndex(this.ribbonPanel2dataFrm, 0);
            this.ribbonControlDataFrm.Controls.SetChildIndex(this.ribbonPanel1dataFrm, 0);
            // 
            // ribbonPanel1dataFrm
            // 
            this.ribbonPanel1dataFrm.Controls.Add(this.groupBox2);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtCodigoModeloManual);
            this.ribbonPanel1dataFrm.Controls.Add(this.label14);
            this.ribbonPanel1dataFrm.Controls.Add(this.btnGuardarFoto);
            this.ribbonPanel1dataFrm.Controls.Add(this.btnVerFoto);
            this.ribbonPanel1dataFrm.Controls.Add(this.btnSubirF);
            this.ribbonPanel1dataFrm.Controls.Add(this.label19);
            this.ribbonPanel1dataFrm.Controls.Add(this.picFotografia);
            this.ribbonPanel1dataFrm.Controls.Add(this.groupBox1);
            this.ribbonPanel1dataFrm.Controls.Add(this.label11);
            this.ribbonPanel1dataFrm.Controls.Add(this.label10);
            this.ribbonPanel1dataFrm.Controls.Add(this.label9);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtCodigoModelo);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtNombreModelo);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtDescripcion);
            this.ribbonPanel1dataFrm.Controls.Add(this.cmbFabricante);
            this.ribbonPanel1dataFrm.Controls.Add(this.cmbTipoEquipo);
            this.ribbonPanel1dataFrm.Controls.Add(this.cmbsubtipoEquipo);
            this.ribbonPanel1dataFrm.Controls.Add(this.label8);
            this.ribbonPanel1dataFrm.Controls.Add(this.label5);
            this.ribbonPanel1dataFrm.Controls.Add(this.label6);
            this.ribbonPanel1dataFrm.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanel1dataFrm.Size = new System.Drawing.Size(963, 528);
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
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label6, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label5, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label8, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.cmbsubtipoEquipo, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.cmbTipoEquipo, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.cmbFabricante, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtNombreModelo, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtCodigoModelo, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label9, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label10, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label11, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.groupBox1, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.picFotografia, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label19, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.btnSubirF, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.btnVerFoto, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.btnGuardarFoto, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label14, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtCodigoModeloManual, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // cgDataControler1
            // 
            this.cgDataControler1.campos = "Codigo Fabricante|codFabricante,Codigo Modelo|codModelo,Nombre Modelo|NombreModel" +
    "o,Descripcion|descripcion,Nombre Manual|nombreManual,Codigo Tipo Equipo|codTipoE" +
    "quipo,Codigo Subtipo|codSubTipoEquipo";
            this.cgDataControler1.dataTabla = this.dsSpx1.Modelos;
            this.cgDataControler1.EstadoControles = false;
            this.cgDataControler1.EventosEncendidos = true;
            this.cgDataControler1.estadoControlesChanged += new CGDataControler.dataControlerEventHandler(this.cgDataControler1_estadoControlesChanged);
            this.cgDataControler1.AntesDeEliminar += new CGDataControler.dataControlerEventHandler(this.cgDataControler1_AntesDeEliminar);
            this.cgDataControler1.AntesDeAceptar += new CGDataControler.dataControlerEventHandler(this.cgDataControler1_AntesDeAceptar);
            // 
            // ribbonPanel2dataFrm
            // 
            this.ribbonPanel2dataFrm.Controls.Add(this.c1TrueSubtipo);
            this.ribbonPanel2dataFrm.Controls.Add(this.c1CmbFabricante);
            this.ribbonPanel2dataFrm.Controls.Add(this.c1TrueDBTipoEquipo);
            this.ribbonPanel2dataFrm.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanel2dataFrm.Size = new System.Drawing.Size(963, 528);
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
            this.ribbonPanel2dataFrm.Controls.SetChildIndex(this.grpOpcionesExportar, 0);
            this.ribbonPanel2dataFrm.Controls.SetChildIndex(this.lblTotalr, 0);
            this.ribbonPanel2dataFrm.Controls.SetChildIndex(this.txtTotalRegistros, 0);
            this.ribbonPanel2dataFrm.Controls.SetChildIndex(this.grdDatos, 0);
            this.ribbonPanel2dataFrm.Controls.SetChildIndex(this.c1TrueDBTipoEquipo, 0);
            this.ribbonPanel2dataFrm.Controls.SetChildIndex(this.c1CmbFabricante, 0);
            this.ribbonPanel2dataFrm.Controls.SetChildIndex(this.c1TrueSubtipo, 0);
            // 
            // grdDatos
            // 
            this.grdDatos.DataMember = "Modelos";
            this.grdDatos.DataSource = this.dsSpx1;
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75D;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(896, 388);
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
            // 
            // txtTotalRegistros
            // 
            this.txtTotalRegistros.Location = new System.Drawing.Point(807, 13);
            this.txtTotalRegistros.Text = "0";
            // 
            // lblTotalr
            // 
            this.lblTotalr.Location = new System.Drawing.Point(723, 16);
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
            this.dsSpx1.EnforceConstraints = false;
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modelosTableAdapter1
            // 
            this.modelosTableAdapter1.ClearBeforeFill = true;
            // 
            // subTipoEquipoTableAdapter1
            // 
            this.subTipoEquipoTableAdapter1.ClearBeforeFill = true;
            // 
            // tipoEquipoTableAdapter1
            // 
            this.tipoEquipoTableAdapter1.ClearBeforeFill = true;
            // 
            // archivosxModeloTableAdapter1
            // 
            this.archivosxModeloTableAdapter1.ClearBeforeFill = true;
            // 
            // fabricanteTableAdapter1
            // 
            this.fabricanteTableAdapter1.ClearBeforeFill = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(276, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 49;
            this.label13.Text = "(dias)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(14, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Descripcion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(9, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Subtipo de Equipo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(11, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Tipo de Equipo";
            // 
            // numFrecuenciaMantenimiento
            // 
            this.numFrecuenciaMantenimiento.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsSpx1, "Modelos.diasxMantenimiento", true));
            this.numFrecuenciaMantenimiento.Location = new System.Drawing.Point(229, 114);
            this.numFrecuenciaMantenimiento.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numFrecuenciaMantenimiento.Name = "numFrecuenciaMantenimiento";
            this.numFrecuenciaMantenimiento.ReadOnly = true;
            this.numFrecuenciaMantenimiento.Size = new System.Drawing.Size(46, 20);
            this.numFrecuenciaMantenimiento.TabIndex = 36;
            // 
            // txtCodigoModelo
            // 
            this.txtCodigoModelo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "Modelos.codModelo", true));
            this.txtCodigoModelo.Location = new System.Drawing.Point(113, 141);
            this.txtCodigoModelo.MaxLength = 30;
            this.txtCodigoModelo.Name = "txtCodigoModelo";
            this.txtCodigoModelo.ReadOnly = true;
            this.txtCodigoModelo.Size = new System.Drawing.Size(112, 20);
            this.txtCodigoModelo.TabIndex = 32;
            this.txtCodigoModelo.TextChanged += new System.EventHandler(this.txtCodigoModelo_TextChanged);
            // 
            // txtNombreModelo
            // 
            this.txtNombreModelo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "Modelos.NombreModelo", true));
            this.txtNombreModelo.Location = new System.Drawing.Point(113, 173);
            this.txtNombreModelo.MaxLength = 100;
            this.txtNombreModelo.Name = "txtNombreModelo";
            this.txtNombreModelo.ReadOnly = true;
            this.txtNombreModelo.Size = new System.Drawing.Size(258, 20);
            this.txtNombreModelo.TabIndex = 35;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "Modelos.descripcion", true));
            this.txtDescripcion.Location = new System.Drawing.Point(113, 259);
            this.txtDescripcion.MaxLength = 1073741823;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(258, 58);
            this.txtDescripcion.TabIndex = 41;
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbFabricante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFabricante.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsSpx1, "Modelos.codFabricante", true));
            this.cmbFabricante.DataSource = this.dsSpx1;
            this.cmbFabricante.DisplayMember = "fabricante.nombre_fabricante";
            this.cmbFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(113, 111);
            this.cmbFabricante.MaxLength = 5;
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(258, 21);
            this.cmbFabricante.TabIndex = 31;
            this.cmbFabricante.ValueMember = "fabricante.codFabricante";
            this.cmbFabricante.SelectedValueChanged += new System.EventHandler(this.cmbFabricante_SelectedValueChanged);
            // 
            // cmbTipoEquipo
            // 
            this.cmbTipoEquipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTipoEquipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipoEquipo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsSpx1, "Modelos.codTipoEquipo", true));
            this.cmbTipoEquipo.DataSource = this.dsSpx1;
            this.cmbTipoEquipo.DisplayMember = "tipoEquipo.nombreTipoEquipo";
            this.cmbTipoEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoEquipo.FormattingEnabled = true;
            this.cmbTipoEquipo.Location = new System.Drawing.Point(113, 202);
            this.cmbTipoEquipo.MaxLength = 5;
            this.cmbTipoEquipo.Name = "cmbTipoEquipo";
            this.cmbTipoEquipo.Size = new System.Drawing.Size(258, 21);
            this.cmbTipoEquipo.TabIndex = 39;
            this.cmbTipoEquipo.ValueMember = "tipoEquipo.codTipoEquipo";
            // 
            // cmbsubtipoEquipo
            // 
            this.cmbsubtipoEquipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbsubtipoEquipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbsubtipoEquipo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsSpx1, "Modelos.codSubTipoEquipo", true));
            this.cmbsubtipoEquipo.DataSource = this.dsSpx1;
            this.cmbsubtipoEquipo.DisplayMember = "tipoEquipo.FK_subTipoEquipo_tipoEquipo.nombreSubTipo";
            this.cmbsubtipoEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsubtipoEquipo.FormattingEnabled = true;
            this.cmbsubtipoEquipo.Location = new System.Drawing.Point(113, 232);
            this.cmbsubtipoEquipo.MaxLength = 5;
            this.cmbsubtipoEquipo.Name = "cmbsubtipoEquipo";
            this.cmbsubtipoEquipo.Size = new System.Drawing.Size(258, 21);
            this.cmbsubtipoEquipo.TabIndex = 40;
            this.cmbsubtipoEquipo.ValueMember = "tipoEquipo.FK_subTipoEquipo_tipoEquipo.codSubtipoEquipo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(11, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "*Nombre Modelo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(11, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "*Fabricante:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(0, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Frecuencia Mantenimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(11, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "*Codigo Modelo:";
            // 
            // picFotografia
            // 
            this.picFotografia.BackColor = System.Drawing.Color.Black;
            this.picFotografia.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.dsSpx1, "Modelos.fotografia", true));
            this.picFotografia.Location = new System.Drawing.Point(532, 111);
            this.picFotografia.Name = "picFotografia";
            this.picFotografia.Size = new System.Drawing.Size(307, 258);
            this.picFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFotografia.TabIndex = 29;
            this.picFotografia.TabStop = false;
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.picManual);
            this.groupPanel2.Controls.Add(this.btnVerManual);
            this.groupPanel2.Controls.Add(this.btnSubirManual);
            this.groupPanel2.Controls.Add(this.btnDescargarManual);
            this.groupPanel2.Location = new System.Drawing.Point(328, 71);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(160, 101);
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
            this.groupPanel2.TabIndex = 51;
            this.groupPanel2.Text = "Manual";
            // 
            // picManual
            // 
            this.picManual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picManual.Image = ((System.Drawing.Image)(resources.GetObject("picManual.Image")));
            this.picManual.Location = new System.Drawing.Point(6, 3);
            this.picManual.Name = "picManual";
            this.picManual.Size = new System.Drawing.Size(76, 74);
            this.picManual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picManual.TabIndex = 23;
            this.picManual.TabStop = false;
            // 
            // btnVerManual
            // 
            this.btnVerManual.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerManual.Location = new System.Drawing.Point(88, 27);
            this.btnVerManual.Name = "btnVerManual";
            this.btnVerManual.Size = new System.Drawing.Size(64, 23);
            this.btnVerManual.TabIndex = 21;
            this.btnVerManual.Text = "Abrir";
            this.btnVerManual.UseVisualStyleBackColor = true;
            this.btnVerManual.Click += new System.EventHandler(this.btnVerManual_Click);
            // 
            // btnSubirManual
            // 
            this.btnSubirManual.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubirManual.Location = new System.Drawing.Point(88, 1);
            this.btnSubirManual.Name = "btnSubirManual";
            this.btnSubirManual.Size = new System.Drawing.Size(64, 23);
            this.btnSubirManual.TabIndex = 20;
            this.btnSubirManual.Text = "Subir";
            this.btnSubirManual.UseVisualStyleBackColor = true;
            this.btnSubirManual.Click += new System.EventHandler(this.btnSubirManual_Click);
            // 
            // btnDescargarManual
            // 
            this.btnDescargarManual.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargarManual.Location = new System.Drawing.Point(88, 56);
            this.btnDescargarManual.Name = "btnDescargarManual";
            this.btnDescargarManual.Size = new System.Drawing.Size(64, 23);
            this.btnDescargarManual.TabIndex = 22;
            this.btnDescargarManual.Text = "Descargar";
            this.btnDescargarManual.UseVisualStyleBackColor = true;
            this.btnDescargarManual.Click += new System.EventHandler(this.btnDescargarManual_Click);
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Text = "Archivos Asociados";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel1.Controls.Add(this.btnQuitarArchivo);
            this.ribbonPanel1.Controls.Add(this.btnSubirArchivo);
            this.ribbonPanel1.Controls.Add(this.btnGuardarArchivo);
            this.ribbonPanel1.Controls.Add(this.btnVerArchivo);
            this.ribbonPanel1.Controls.Add(this.label12);
            this.ribbonPanel1.Controls.Add(this.grdArchivos);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(965, 529);
            // 
            // 
            // 
            this.ribbonPanel1.Style.Class = "";
            this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.Class = "";
            this.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.Class = "";
            this.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1.TabIndex = 3;
            this.ribbonPanel1.Visible = false;
            // 
            // btnQuitarArchivo
            // 
            this.btnQuitarArchivo.Location = new System.Drawing.Point(814, 124);
            this.btnQuitarArchivo.Name = "btnQuitarArchivo";
            this.btnQuitarArchivo.Size = new System.Drawing.Size(111, 23);
            this.btnQuitarArchivo.TabIndex = 17;
            this.btnQuitarArchivo.Text = "Quitar Archivo";
            this.btnQuitarArchivo.UseVisualStyleBackColor = true;
            this.btnQuitarArchivo.Click += new System.EventHandler(this.btnQuitarArchivo_Click);
            // 
            // btnSubirArchivo
            // 
            this.btnSubirArchivo.Location = new System.Drawing.Point(814, 95);
            this.btnSubirArchivo.Name = "btnSubirArchivo";
            this.btnSubirArchivo.Size = new System.Drawing.Size(111, 23);
            this.btnSubirArchivo.TabIndex = 16;
            this.btnSubirArchivo.Text = "Agregar Archivo";
            this.btnSubirArchivo.UseVisualStyleBackColor = true;
            this.btnSubirArchivo.Click += new System.EventHandler(this.btnSubirArchivo_Click);
            // 
            // btnGuardarArchivo
            // 
            this.btnGuardarArchivo.Location = new System.Drawing.Point(814, 66);
            this.btnGuardarArchivo.Name = "btnGuardarArchivo";
            this.btnGuardarArchivo.Size = new System.Drawing.Size(111, 23);
            this.btnGuardarArchivo.TabIndex = 15;
            this.btnGuardarArchivo.Text = "Guardar Archivo";
            this.btnGuardarArchivo.UseVisualStyleBackColor = true;
            this.btnGuardarArchivo.Click += new System.EventHandler(this.btnGuardarArchivo_Click);
            // 
            // btnVerArchivo
            // 
            this.btnVerArchivo.Location = new System.Drawing.Point(814, 37);
            this.btnVerArchivo.Name = "btnVerArchivo";
            this.btnVerArchivo.Size = new System.Drawing.Size(111, 23);
            this.btnVerArchivo.TabIndex = 14;
            this.btnVerArchivo.Text = "Ver Archivo";
            this.btnVerArchivo.UseVisualStyleBackColor = true;
            this.btnVerArchivo.Click += new System.EventHandler(this.btnVerArchivo_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(8, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Archivos Asociados al Modelo";
            // 
            // grdArchivos
            // 
            this.grdArchivos.AllowUpdate = false;
            this.grdArchivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdArchivos.DataMember = "archivosxModelo";
            this.grdArchivos.DataSource = this.dsSpx1;
            this.grdArchivos.FilterBar = true;
            this.grdArchivos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdArchivos.Images"))));
            this.grdArchivos.Location = new System.Drawing.Point(8, 36);
            this.grdArchivos.Name = "grdArchivos";
            this.grdArchivos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdArchivos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdArchivos.PreviewInfo.ZoomFactor = 75D;
            this.grdArchivos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdArchivos.PrintInfo.PageSettings")));
            this.grdArchivos.Size = new System.Drawing.Size(831, 432);
            this.grdArchivos.TabIndex = 12;
            this.grdArchivos.Text = "c1TrueDBGrid1";
            this.grdArchivos.PropBag = resources.GetString("grdArchivos.PropBag");
            // 
            // c1CmbFabricante
            // 
            this.c1CmbFabricante.AllowColMove = true;
            this.c1CmbFabricante.AllowColSelect = true;
            this.c1CmbFabricante.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows;
            this.c1CmbFabricante.AlternatingRows = false;
            this.c1CmbFabricante.CaptionStyle = style33;
            this.c1CmbFabricante.ColumnCaptionHeight = 17;
            this.c1CmbFabricante.ColumnFooterHeight = 17;
            this.c1CmbFabricante.ColumnHeaders = false;
            this.c1CmbFabricante.DataMember = "fabricante";
            this.c1CmbFabricante.DataSource = this.dsSpx1;
            this.c1CmbFabricante.DisplayMember = "fabricante.nombre_fabricante";
            this.c1CmbFabricante.EvenRowStyle = style34;
            this.c1CmbFabricante.FetchRowStyles = false;
            this.c1CmbFabricante.FooterStyle = style35;
            this.c1CmbFabricante.HeadingStyle = style36;
            this.c1CmbFabricante.HighLightRowStyle = style37;
            this.c1CmbFabricante.Images.Add(((System.Drawing.Image)(resources.GetObject("c1CmbFabricante.Images"))));
            this.c1CmbFabricante.Location = new System.Drawing.Point(520, 25);
            this.c1CmbFabricante.Name = "c1CmbFabricante";
            this.c1CmbFabricante.OddRowStyle = style38;
            this.c1CmbFabricante.RecordSelectorStyle = style39;
            this.c1CmbFabricante.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.c1CmbFabricante.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
            this.c1CmbFabricante.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1CmbFabricante.ScrollTips = false;
            this.c1CmbFabricante.Size = new System.Drawing.Size(140, 49);
            this.c1CmbFabricante.Style = style40;
            this.c1CmbFabricante.TabIndex = 9;
            this.c1CmbFabricante.TabStop = false;
            this.c1CmbFabricante.Text = "c1TrueDBDropdown1";
            this.c1CmbFabricante.ValueMember = "fabricante.codFabricante";
            this.c1CmbFabricante.ValueTranslate = true;
            this.c1CmbFabricante.Visible = false;
            this.c1CmbFabricante.PropBag = resources.GetString("c1CmbFabricante.PropBag");
            // 
            // c1TrueSubtipo
            // 
            this.c1TrueSubtipo.AllowColMove = true;
            this.c1TrueSubtipo.AllowColSelect = true;
            this.c1TrueSubtipo.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows;
            this.c1TrueSubtipo.AlternatingRows = false;
            this.c1TrueSubtipo.CaptionStyle = style25;
            this.c1TrueSubtipo.ColumnCaptionHeight = 17;
            this.c1TrueSubtipo.ColumnFooterHeight = 17;
            this.c1TrueSubtipo.ColumnHeaders = false;
            this.c1TrueSubtipo.DataMember = "subTipoEquipo";
            this.c1TrueSubtipo.DataSource = this.dsSpx1;
            this.c1TrueSubtipo.DisplayMember = "subTipoEquipo.nombreSubTipo";
            this.c1TrueSubtipo.EvenRowStyle = style26;
            this.c1TrueSubtipo.FetchRowStyles = false;
            this.c1TrueSubtipo.FooterStyle = style27;
            this.c1TrueSubtipo.HeadingStyle = style28;
            this.c1TrueSubtipo.HighLightRowStyle = style29;
            this.c1TrueSubtipo.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueSubtipo.Images"))));
            this.c1TrueSubtipo.Location = new System.Drawing.Point(744, 50);
            this.c1TrueSubtipo.Name = "c1TrueSubtipo";
            this.c1TrueSubtipo.OddRowStyle = style30;
            this.c1TrueSubtipo.RecordSelectorStyle = style31;
            this.c1TrueSubtipo.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.c1TrueSubtipo.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
            this.c1TrueSubtipo.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1TrueSubtipo.ScrollTips = false;
            this.c1TrueSubtipo.Size = new System.Drawing.Size(141, 55);
            this.c1TrueSubtipo.Style = style32;
            this.c1TrueSubtipo.TabIndex = 10;
            this.c1TrueSubtipo.TabStop = false;
            this.c1TrueSubtipo.Text = "c1TrueDBDropdown2";
            this.c1TrueSubtipo.ValueMember = "subTipoEquipo.codTipoEquipo";
            this.c1TrueSubtipo.ValueTranslate = true;
            this.c1TrueSubtipo.Visible = false;
            this.c1TrueSubtipo.PropBag = resources.GetString("c1TrueSubtipo.PropBag");
            // 
            // c1TrueDBTipoEquipo
            // 
            this.c1TrueDBTipoEquipo.AllowColMove = true;
            this.c1TrueDBTipoEquipo.AllowColSelect = true;
            this.c1TrueDBTipoEquipo.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows;
            this.c1TrueDBTipoEquipo.AlternatingRows = false;
            this.c1TrueDBTipoEquipo.CaptionStyle = style41;
            this.c1TrueDBTipoEquipo.ColumnCaptionHeight = 17;
            this.c1TrueDBTipoEquipo.ColumnFooterHeight = 17;
            this.c1TrueDBTipoEquipo.ColumnHeaders = false;
            this.c1TrueDBTipoEquipo.DataMember = "tipoEquipo";
            this.c1TrueDBTipoEquipo.DataSource = this.dsSpx1;
            this.c1TrueDBTipoEquipo.DisplayMember = "tipoEquipo.nombreTipoEquipo";
            this.c1TrueDBTipoEquipo.EvenRowStyle = style42;
            this.c1TrueDBTipoEquipo.FetchRowStyles = false;
            this.c1TrueDBTipoEquipo.FooterStyle = style43;
            this.c1TrueDBTipoEquipo.HeadingStyle = style44;
            this.c1TrueDBTipoEquipo.HighLightRowStyle = style45;
            this.c1TrueDBTipoEquipo.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBTipoEquipo.Images"))));
            this.c1TrueDBTipoEquipo.Location = new System.Drawing.Point(357, 56);
            this.c1TrueDBTipoEquipo.Name = "c1TrueDBTipoEquipo";
            this.c1TrueDBTipoEquipo.OddRowStyle = style46;
            this.c1TrueDBTipoEquipo.RecordSelectorStyle = style47;
            this.c1TrueDBTipoEquipo.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.c1TrueDBTipoEquipo.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
            this.c1TrueDBTipoEquipo.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1TrueDBTipoEquipo.ScrollTips = false;
            this.c1TrueDBTipoEquipo.Size = new System.Drawing.Size(145, 49);
            this.c1TrueDBTipoEquipo.Style = style48;
            this.c1TrueDBTipoEquipo.TabIndex = 11;
            this.c1TrueDBTipoEquipo.TabStop = false;
            this.c1TrueDBTipoEquipo.Text = "c1TrueDBDropdown3";
            this.c1TrueDBTipoEquipo.ValueMember = "tipoEquipo.codTipoEquipo";
            this.c1TrueDBTipoEquipo.ValueTranslate = true;
            this.c1TrueDBTipoEquipo.Visible = false;
            this.c1TrueDBTipoEquipo.PropBag = resources.GetString("c1TrueDBTipoEquipo.PropBag");
            // 
            // txtVoltaje
            // 
            this.txtVoltaje.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "Modelos.voltaje", true));
            this.txtVoltaje.Location = new System.Drawing.Point(71, 20);
            this.txtVoltaje.MaxLength = 10;
            this.txtVoltaje.Name = "txtVoltaje";
            this.txtVoltaje.ReadOnly = true;
            this.txtVoltaje.Size = new System.Drawing.Size(65, 20);
            this.txtVoltaje.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Voltaje";
            // 
            // txtAmperios
            // 
            this.txtAmperios.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "Modelos.amperios", true));
            this.txtAmperios.Location = new System.Drawing.Point(71, 46);
            this.txtAmperios.MaxLength = 10;
            this.txtAmperios.Name = "txtAmperios";
            this.txtAmperios.ReadOnly = true;
            this.txtAmperios.Size = new System.Drawing.Size(65, 20);
            this.txtAmperios.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(11, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Amperios";
            // 
            // txtWatios
            // 
            this.txtWatios.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "Modelos.watios", true));
            this.txtWatios.Location = new System.Drawing.Point(214, 20);
            this.txtWatios.MaxLength = 10;
            this.txtWatios.Name = "txtWatios";
            this.txtWatios.ReadOnly = true;
            this.txtWatios.Size = new System.Drawing.Size(65, 20);
            this.txtWatios.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(148, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Watios";
            // 
            // txtFrecuencia
            // 
            this.txtFrecuencia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "Modelos.frecuencia", true));
            this.txtFrecuencia.Location = new System.Drawing.Point(214, 46);
            this.txtFrecuencia.MaxLength = 10;
            this.txtFrecuencia.Name = "txtFrecuencia";
            this.txtFrecuencia.ReadOnly = true;
            this.txtFrecuencia.Size = new System.Drawing.Size(65, 20);
            this.txtFrecuencia.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(148, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Frecuencia";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(2, 143);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 26);
            this.label15.TabIndex = 64;
            this.label15.Text = "Duracion Mantenimiento Preventivo";
            // 
            // nmHorasDuracion
            // 
            this.nmHorasDuracion.Location = new System.Drawing.Point(138, 144);
            this.nmHorasDuracion.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nmHorasDuracion.Name = "nmHorasDuracion";
            this.nmHorasDuracion.Size = new System.Drawing.Size(46, 20);
            this.nmHorasDuracion.TabIndex = 65;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(184, 148);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 66;
            this.label16.Text = "(horas)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(276, 149);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 68;
            this.label17.Text = "(minutos)";
            // 
            // nmMinutosDuracion
            // 
            this.nmMinutosDuracion.Location = new System.Drawing.Point(229, 146);
            this.nmMinutosDuracion.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nmMinutosDuracion.Name = "nmMinutosDuracion";
            this.nmMinutosDuracion.Size = new System.Drawing.Size(46, 20);
            this.nmMinutosDuracion.TabIndex = 67;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(184, 116);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 70;
            this.label18.Text = "(Meses)";
            // 
            // nmMesesFrecuencia
            // 
            this.nmMesesFrecuencia.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsSpx1, "Modelos.mesesxMantenimiento", true));
            this.nmMesesFrecuencia.Location = new System.Drawing.Point(138, 113);
            this.nmMesesFrecuencia.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.nmMesesFrecuencia.Name = "nmMesesFrecuencia";
            this.nmMesesFrecuencia.ReadOnly = true;
            this.nmMesesFrecuencia.Size = new System.Drawing.Size(46, 20);
            this.nmMesesFrecuencia.TabIndex = 69;
            // 
            // txtPeso
            // 
            this.txtPeso.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "Modelos.pesoEstimado", true));
            this.txtPeso.Location = new System.Drawing.Point(71, 75);
            this.txtPeso.MaxLength = 10;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.ReadOnly = true;
            this.txtPeso.Size = new System.Drawing.Size(65, 20);
            this.txtPeso.TabIndex = 71;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(11, 79);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 13);
            this.label20.TabIndex = 72;
            this.label20.Text = "Peso";
            // 
            // cmbUnidadPeso
            // 
            this.cmbUnidadPeso.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsSpx1, "Modelos.codUnidadPeso", true));
            this.cmbUnidadPeso.DataSource = this.dsSpx1;
            this.cmbUnidadPeso.DisplayMember = "unidadPeso.nombreUnidadPeso";
            this.cmbUnidadPeso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidadPeso.FormattingEnabled = true;
            this.cmbUnidadPeso.Location = new System.Drawing.Point(143, 75);
            this.cmbUnidadPeso.Name = "cmbUnidadPeso";
            this.cmbUnidadPeso.Size = new System.Drawing.Size(82, 21);
            this.cmbUnidadPeso.TabIndex = 73;
            this.cmbUnidadPeso.ValueMember = "unidadPeso.codUnidadPeso";
            // 
            // unidadPesoTableAdapter1
            // 
            this.unidadPesoTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtVoltaje);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.cmbUnidadPeso);
            this.groupBox1.Controls.Add(this.nmMesesFrecuencia);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.groupPanel2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nmMinutosDuracion);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtPeso);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nmHorasDuracion);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtAmperios);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtWatios);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFrecuencia);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numFrecuenciaMantenimiento);
            this.groupBox1.Location = new System.Drawing.Point(8, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 179);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Tecnica";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(529, 94);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 13);
            this.label19.TabIndex = 75;
            this.label19.Text = "Fotografia";
            // 
            // btnGuardarFoto
            // 
            this.btnGuardarFoto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGuardarFoto.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarFoto.Image")));
            this.btnGuardarFoto.ImageFixedSize = new System.Drawing.Size(34, 34);
            this.btnGuardarFoto.Location = new System.Drawing.Point(845, 200);
            this.btnGuardarFoto.Name = "btnGuardarFoto";
            this.btnGuardarFoto.Size = new System.Drawing.Size(40, 43);
            this.btnGuardarFoto.TabIndex = 184;
            this.btnGuardarFoto.Click += new System.EventHandler(this.btnGuardarFoto_Click);
            // 
            // btnVerFoto
            // 
            this.btnVerFoto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVerFoto.Image = ((System.Drawing.Image)(resources.GetObject("btnVerFoto.Image")));
            this.btnVerFoto.ImageFixedSize = new System.Drawing.Size(34, 34);
            this.btnVerFoto.Location = new System.Drawing.Point(845, 156);
            this.btnVerFoto.Name = "btnVerFoto";
            this.btnVerFoto.Size = new System.Drawing.Size(40, 43);
            this.btnVerFoto.TabIndex = 183;
            this.btnVerFoto.Click += new System.EventHandler(this.btnVerFoto_Click);
            // 
            // btnSubirF
            // 
            this.btnSubirF.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSubirF.Image = ((System.Drawing.Image)(resources.GetObject("btnSubirF.Image")));
            this.btnSubirF.ImageFixedSize = new System.Drawing.Size(34, 34);
            this.btnSubirF.Location = new System.Drawing.Point(845, 111);
            this.btnSubirF.Name = "btnSubirF";
            this.btnSubirF.Size = new System.Drawing.Size(40, 43);
            this.btnSubirF.TabIndex = 182;
            this.btnSubirF.Click += new System.EventHandler(this.btnSubirF_Click);
            // 
            // txtCodigoModeloManual
            // 
            this.txtCodigoModeloManual.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "Modelos.cod_manual_modelo", true));
            this.txtCodigoModeloManual.Location = new System.Drawing.Point(339, 141);
            this.txtCodigoModeloManual.MaxLength = 30;
            this.txtCodigoModeloManual.Name = "txtCodigoModeloManual";
            this.txtCodigoModeloManual.ReadOnly = true;
            this.txtCodigoModeloManual.Size = new System.Drawing.Size(163, 20);
            this.txtCodigoModeloManual.TabIndex = 185;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(248, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 186;
            this.label14.Text = "*Cod Manual:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelVariable);
            this.groupBox2.Controls.Add(this.btnEditVariableMedicion);
            this.groupBox2.Controls.Add(this.btnAgregarVariableMedicion);
            this.groupBox2.Controls.Add(this.grdVariablesMedicion);
            this.groupBox2.Location = new System.Drawing.Point(532, 378);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 147);
            this.groupBox2.TabIndex = 187;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Variables de Medicion";
            // 
            // btnDelVariable
            // 
            this.btnDelVariable.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelVariable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelVariable.Enabled = false;
            this.btnDelVariable.Image = ((System.Drawing.Image)(resources.GetObject("btnDelVariable.Image")));
            this.btnDelVariable.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnDelVariable.Location = new System.Drawing.Point(376, 9);
            this.btnDelVariable.Name = "btnDelVariable";
            this.btnDelVariable.Size = new System.Drawing.Size(29, 29);
            this.btnDelVariable.TabIndex = 49;
            this.btnDelVariable.Tooltip = "Eliminar Variable";
            this.btnDelVariable.Click += new System.EventHandler(this.btnDelVariable_Click);
            // 
            // btnEditVariableMedicion
            // 
            this.btnEditVariableMedicion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEditVariableMedicion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditVariableMedicion.Enabled = false;
            this.btnEditVariableMedicion.Image = ((System.Drawing.Image)(resources.GetObject("btnEditVariableMedicion.Image")));
            this.btnEditVariableMedicion.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnEditVariableMedicion.Location = new System.Drawing.Point(341, 9);
            this.btnEditVariableMedicion.Name = "btnEditVariableMedicion";
            this.btnEditVariableMedicion.Size = new System.Drawing.Size(29, 29);
            this.btnEditVariableMedicion.TabIndex = 48;
            this.btnEditVariableMedicion.Tooltip = "Editar Variable";
            this.btnEditVariableMedicion.Click += new System.EventHandler(this.btnEditVariableMedicion_Click);
            // 
            // btnAgregarVariableMedicion
            // 
            this.btnAgregarVariableMedicion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregarVariableMedicion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarVariableMedicion.Enabled = false;
            this.btnAgregarVariableMedicion.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarVariableMedicion.Image")));
            this.btnAgregarVariableMedicion.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnAgregarVariableMedicion.Location = new System.Drawing.Point(306, 9);
            this.btnAgregarVariableMedicion.Name = "btnAgregarVariableMedicion";
            this.btnAgregarVariableMedicion.Size = new System.Drawing.Size(29, 29);
            this.btnAgregarVariableMedicion.TabIndex = 47;
            this.btnAgregarVariableMedicion.Tooltip = "Agregar Variable";
            this.btnAgregarVariableMedicion.Click += new System.EventHandler(this.btnAgregarVariableMedicion_Click);
            // 
            // grdVariablesMedicion
            // 
            this.grdVariablesMedicion.AllowUpdate = false;
            this.grdVariablesMedicion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdVariablesMedicion.DataMember = "pltVariablesMedicionxModelo";
            this.grdVariablesMedicion.DataSource = this.dsPlantillas1;
            this.grdVariablesMedicion.FilterBar = true;
            this.grdVariablesMedicion.Images.Add(((System.Drawing.Image)(resources.GetObject("grdVariablesMedicion.Images"))));
            this.grdVariablesMedicion.Location = new System.Drawing.Point(15, 41);
            this.grdVariablesMedicion.Name = "grdVariablesMedicion";
            this.grdVariablesMedicion.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdVariablesMedicion.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdVariablesMedicion.PreviewInfo.ZoomFactor = 75D;
            this.grdVariablesMedicion.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdVariablesMedicion.PrintInfo.PageSettings")));
            this.grdVariablesMedicion.Size = new System.Drawing.Size(390, 102);
            this.grdVariablesMedicion.TabIndex = 46;
            this.grdVariablesMedicion.Text = "c1TrueDBGrid1";
            this.grdVariablesMedicion.PropBag = resources.GetString("grdVariablesMedicion.PropBag");
            // 
            // dsPlantillas1
            // 
            this.dsPlantillas1.DataSetName = "dsPlantillas";
            this.dsPlantillas1.EnforceConstraints = false;
            this.dsPlantillas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pltVariablesMedicionxModeloTableAdapter1
            // 
            this.pltVariablesMedicionxModeloTableAdapter1.ClearBeforeFill = true;
            // 
            // variables_medicionxmodeloTableAdapter1
            // 
            this.variables_medicionxmodeloTableAdapter1.ClearBeforeFill = true;
            // 
            // frmModelos
            // 
            this.ClientSize = new System.Drawing.Size(973, 589);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModelos";
            this.Text = "Modelos de Equipos - Nombre Software";
            this.tituloTabla = "Modelos de Equipos";
            this.Load += new System.EventHandler(this.frmModelos_Load);
            this.ribbonControlDataFrm.ResumeLayout(false);
            this.ribbonControlDataFrm.PerformLayout();
            this.ribbonPanel1dataFrm.ResumeLayout(false);
            this.ribbonPanel1dataFrm.PerformLayout();
            this.ribbonPanel2dataFrm.ResumeLayout(false);
            this.ribbonPanel2dataFrm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.grpOpcionesExportar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrecuenciaMantenimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotografia)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picManual)).EndInit();
            this.ribbonPanel1.ResumeLayout(false);
            this.ribbonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdArchivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CmbFabricante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueSubtipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBTipoEquipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmHorasDuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMinutosDuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMesesFrecuencia)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdVariablesMedicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter modelosTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.subTipoEquipoTableAdapter subTipoEquipoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.tipoEquipoTableAdapter tipoEquipoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.archivosxModeloTableAdapter archivosxModeloTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.fabricanteTableAdapter fabricanteTableAdapter1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numFrecuenciaMantenimiento;
        private System.Windows.Forms.TextBox txtCodigoModelo;
        private System.Windows.Forms.TextBox txtNombreModelo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.ComboBox cmbTipoEquipo;
        private System.Windows.Forms.ComboBox cmbsubtipoEquipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picFotografia;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private System.Windows.Forms.PictureBox picManual;
        private System.Windows.Forms.Button btnVerManual;
        private System.Windows.Forms.Button btnSubirManual;
        private System.Windows.Forms.Button btnDescargarManual;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private System.Windows.Forms.Button btnQuitarArchivo;
        private System.Windows.Forms.Button btnSubirArchivo;
        private System.Windows.Forms.Button btnGuardarArchivo;
        private System.Windows.Forms.Button btnVerArchivo;
        private System.Windows.Forms.Label label12;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdArchivos;
        private C1.Win.C1TrueDBGrid.C1TrueDBDropdown c1CmbFabricante;
        private C1.Win.C1TrueDBGrid.C1TrueDBDropdown c1TrueDBTipoEquipo;
        private C1.Win.C1TrueDBGrid.C1TrueDBDropdown c1TrueSubtipo;
        private System.Windows.Forms.TextBox txtFrecuencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWatios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmperios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVoltaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown nmMinutosDuracion;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nmHorasDuracion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown nmMesesFrecuencia;
        private System.Windows.Forms.ComboBox cmbUnidadPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label20;
        private SPControladoraDatos.dsSpxTableAdapters.unidadPesoTableAdapter unidadPesoTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label19;
        private DevComponents.DotNetBar.ButtonX btnGuardarFoto;
        private DevComponents.DotNetBar.ButtonX btnVerFoto;
        private DevComponents.DotNetBar.ButtonX btnSubirF;
        private System.Windows.Forms.TextBox txtCodigoModeloManual;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.ButtonX btnDelVariable;
        private DevComponents.DotNetBar.ButtonX btnEditVariableMedicion;
        private DevComponents.DotNetBar.ButtonX btnAgregarVariableMedicion;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdVariablesMedicion;
        private SPControladoraDatos.dsPlantillasTableAdapters.pltVariablesMedicionxModeloTableAdapter pltVariablesMedicionxModeloTableAdapter1;
        private SPControladoraDatos.dsPlantillas dsPlantillas1;
        private SPControladoraDatos.dsSpxTableAdapters.variables_medicionxmodeloTableAdapter variables_medicionxmodeloTableAdapter1;
    }
}
