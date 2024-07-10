namespace SPXSeguridad.frm
{
    partial class frmPermisos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPermisos));
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
            this.lblTituloPermisos = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.chkEscribir = new System.Windows.Forms.CheckBox();
            this.chkImprimir = new System.Windows.Forms.CheckBox();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.chkDenegar = new System.Windows.Forms.CheckBox();
            this.chkLectEjec = new System.Windows.Forms.CheckBox();
            this.chkModificar = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkControlTotal = new System.Windows.Forms.CheckBox();
            this.lblTituloModulo = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.c1CmbTipo = new C1.Win.C1TrueDBGrid.C1TrueDBDropdown();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.grdVinculados = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsSPXSeguridad1 = new SPXSeguridad.data.dsSPXSeguridad();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAgregaUsuario = new System.Windows.Forms.Button();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnGenerarListado = new System.Windows.Forms.Button();
            this.c1CmbModulo = new C1.Win.C1TrueDBGrid.C1TrueDBDropdown();
            this.rdGruposModulos = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdVerModulos = new System.Windows.Forms.RadioButton();
            this.grdGrupoModulo = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.grdModulos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTituloPermisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.lblTituloModulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1CmbTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVinculados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1CmbModulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrupoModulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdModulos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloPermisos
            // 
            this.lblTituloPermisos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloPermisos.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloPermisos.CanvasColor = System.Drawing.SystemColors.Control;
            this.lblTituloPermisos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.lblTituloPermisos.Controls.Add(this.chkEscribir);
            this.lblTituloPermisos.Controls.Add(this.chkImprimir);
            this.lblTituloPermisos.Controls.Add(this.chkEliminar);
            this.lblTituloPermisos.Controls.Add(this.pictureBox3);
            this.lblTituloPermisos.Controls.Add(this.btnAplicar);
            this.lblTituloPermisos.Controls.Add(this.chkDenegar);
            this.lblTituloPermisos.Controls.Add(this.chkLectEjec);
            this.lblTituloPermisos.Controls.Add(this.chkModificar);
            this.lblTituloPermisos.Controls.Add(this.label1);
            this.lblTituloPermisos.Controls.Add(this.chkControlTotal);
            this.lblTituloPermisos.Location = new System.Drawing.Point(436, 351);
            this.lblTituloPermisos.Name = "lblTituloPermisos";
            this.lblTituloPermisos.Size = new System.Drawing.Size(431, 179);
            // 
            // 
            // 
            this.lblTituloPermisos.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.lblTituloPermisos.Style.BackColorGradientAngle = 90;
            this.lblTituloPermisos.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.lblTituloPermisos.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.lblTituloPermisos.Style.BorderBottomWidth = 1;
            this.lblTituloPermisos.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.lblTituloPermisos.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.lblTituloPermisos.Style.BorderLeftWidth = 1;
            this.lblTituloPermisos.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.lblTituloPermisos.Style.BorderRightWidth = 1;
            this.lblTituloPermisos.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.lblTituloPermisos.Style.BorderTopWidth = 1;
            this.lblTituloPermisos.Style.Class = "";
            this.lblTituloPermisos.Style.CornerDiameter = 4;
            this.lblTituloPermisos.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.lblTituloPermisos.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.lblTituloPermisos.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.lblTituloPermisos.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.lblTituloPermisos.StyleMouseDown.Class = "";
            this.lblTituloPermisos.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.lblTituloPermisos.StyleMouseOver.Class = "";
            this.lblTituloPermisos.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTituloPermisos.TabIndex = 12;
            this.lblTituloPermisos.Text = "Permisos ";
            // 
            // chkEscribir
            // 
            this.chkEscribir.Location = new System.Drawing.Point(158, 17);
            this.chkEscribir.Name = "chkEscribir";
            this.chkEscribir.Size = new System.Drawing.Size(104, 24);
            this.chkEscribir.TabIndex = 3;
            this.chkEscribir.Text = "Escribir";
            // 
            // chkImprimir
            // 
            this.chkImprimir.Location = new System.Drawing.Point(158, 81);
            this.chkImprimir.Name = "chkImprimir";
            this.chkImprimir.Size = new System.Drawing.Size(104, 24);
            this.chkImprimir.TabIndex = 5;
            this.chkImprimir.Text = "Imprimir";
            // 
            // chkEliminar
            // 
            this.chkEliminar.Location = new System.Drawing.Point(158, 49);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(104, 24);
            this.chkEliminar.TabIndex = 4;
            this.chkEliminar.Text = "Eliminar";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(372, -2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(344, 63);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 51);
            this.btnAplicar.TabIndex = 11;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // chkDenegar
            // 
            this.chkDenegar.Location = new System.Drawing.Point(262, 17);
            this.chkDenegar.Name = "chkDenegar";
            this.chkDenegar.Size = new System.Drawing.Size(104, 24);
            this.chkDenegar.TabIndex = 6;
            this.chkDenegar.Text = "Denegar";
            // 
            // chkLectEjec
            // 
            this.chkLectEjec.Location = new System.Drawing.Point(25, 81);
            this.chkLectEjec.Name = "chkLectEjec";
            this.chkLectEjec.Size = new System.Drawing.Size(136, 24);
            this.chkLectEjec.TabIndex = 2;
            this.chkLectEjec.Text = "Lectura o Ejecucion";
            // 
            // chkModificar
            // 
            this.chkModificar.Location = new System.Drawing.Point(25, 49);
            this.chkModificar.Name = "chkModificar";
            this.chkModificar.Size = new System.Drawing.Size(104, 24);
            this.chkModificar.TabIndex = 1;
            this.chkModificar.Text = "Modificar";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "!Nota: los permisos de denegacion de servicio tendran prioridad con respecto a lo" +
    "s demas permisos.";
            // 
            // chkControlTotal
            // 
            this.chkControlTotal.Location = new System.Drawing.Point(25, 17);
            this.chkControlTotal.Name = "chkControlTotal";
            this.chkControlTotal.Size = new System.Drawing.Size(104, 24);
            this.chkControlTotal.TabIndex = 0;
            this.chkControlTotal.Text = "Control Total";
            // 
            // lblTituloModulo
            // 
            this.lblTituloModulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloModulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloModulo.CanvasColor = System.Drawing.SystemColors.Control;
            this.lblTituloModulo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.lblTituloModulo.Controls.Add(this.c1CmbTipo);
            this.lblTituloModulo.Controls.Add(this.grdVinculados);
            this.lblTituloModulo.Controls.Add(this.pictureBox2);
            this.lblTituloModulo.Controls.Add(this.btnAgregaUsuario);
            this.lblTituloModulo.Location = new System.Drawing.Point(435, 14);
            this.lblTituloModulo.Name = "lblTituloModulo";
            this.lblTituloModulo.Size = new System.Drawing.Size(432, 328);
            // 
            // 
            // 
            this.lblTituloModulo.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.lblTituloModulo.Style.BackColorGradientAngle = 90;
            this.lblTituloModulo.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.lblTituloModulo.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.lblTituloModulo.Style.BorderBottomWidth = 1;
            this.lblTituloModulo.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.lblTituloModulo.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.lblTituloModulo.Style.BorderLeftWidth = 1;
            this.lblTituloModulo.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.lblTituloModulo.Style.BorderRightWidth = 1;
            this.lblTituloModulo.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.lblTituloModulo.Style.BorderTopWidth = 1;
            this.lblTituloModulo.Style.Class = "";
            this.lblTituloModulo.Style.CornerDiameter = 4;
            this.lblTituloModulo.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.lblTituloModulo.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.lblTituloModulo.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.lblTituloModulo.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.lblTituloModulo.StyleMouseDown.Class = "";
            this.lblTituloModulo.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.lblTituloModulo.StyleMouseOver.Class = "";
            this.lblTituloModulo.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTituloModulo.TabIndex = 8;
            this.lblTituloModulo.Text = "Nombres de Grupos o Usuarios";
            // 
            // c1CmbTipo
            // 
            this.c1CmbTipo.AllowColMove = true;
            this.c1CmbTipo.AllowColSelect = true;
            this.c1CmbTipo.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows;
            this.c1CmbTipo.AlternatingRows = false;
            this.c1CmbTipo.CaptionStyle = style1;
            this.c1CmbTipo.ColumnCaptionHeight = 17;
            this.c1CmbTipo.ColumnFooterHeight = 17;
            this.c1CmbTipo.DataMember = "Table1";
            this.c1CmbTipo.DataSource = this.dataSet1;
            this.c1CmbTipo.DisplayMember = "Table1.nombre";
            this.c1CmbTipo.EvenRowStyle = style2;
            this.c1CmbTipo.FetchRowStyles = false;
            this.c1CmbTipo.FooterStyle = style3;
            this.c1CmbTipo.HeadingStyle = style4;
            this.c1CmbTipo.HighLightRowStyle = style5;
            this.c1CmbTipo.Images.Add(((System.Drawing.Image)(resources.GetObject("c1CmbTipo.Images"))));
            this.c1CmbTipo.Location = new System.Drawing.Point(144, 130);
            this.c1CmbTipo.Name = "c1CmbTipo";
            this.c1CmbTipo.OddRowStyle = style6;
            this.c1CmbTipo.RecordSelectorStyle = style7;
            this.c1CmbTipo.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.c1CmbTipo.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
            this.c1CmbTipo.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1CmbTipo.ScrollTips = false;
            this.c1CmbTipo.Size = new System.Drawing.Size(134, 134);
            this.c1CmbTipo.Style = style8;
            this.c1CmbTipo.TabIndex = 14;
            this.c1CmbTipo.TabStop = false;
            this.c1CmbTipo.Text = "c1TrueDBDropdown1";
            this.c1CmbTipo.ValueMember = "Table1.codigo";
            this.c1CmbTipo.ValueTranslate = true;
            this.c1CmbTipo.Visible = false;
            this.c1CmbTipo.PropBag = resources.GetString("c1CmbTipo.PropBag");
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2});
            this.dataTable1.TableName = "Table1";
            // 
            // dataColumn1
            // 
            this.dataColumn1.Caption = "codigo";
            this.dataColumn1.ColumnName = "codigo";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.Caption = "nombre";
            this.dataColumn2.ColumnName = "nombre";
            // 
            // grdVinculados
            // 
            this.grdVinculados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdVinculados.DataMember = "pltVinculados";
            this.grdVinculados.DataSource = this.dsSPXSeguridad1;
            this.grdVinculados.GroupByCaption = "Drag a column header here to group by that column";
            this.grdVinculados.Images.Add(((System.Drawing.Image)(resources.GetObject("grdVinculados.Images"))));
            this.grdVinculados.Location = new System.Drawing.Point(4, 39);
            this.grdVinculados.Name = "grdVinculados";
            this.grdVinculados.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdVinculados.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdVinculados.PreviewInfo.ZoomFactor = 75D;
            this.grdVinculados.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdVinculados.PrintInfo.PageSettings")));
            this.grdVinculados.Size = new System.Drawing.Size(416, 238);
            this.grdVinculados.TabIndex = 13;
            this.grdVinculados.Text = "c1TrueDBGrid3";
            this.grdVinculados.RowColChange += new C1.Win.C1TrueDBGrid.RowColChangeEventHandler(this.grdVinculados_RowColChange);
            this.grdVinculados.PropBag = resources.GetString("grdVinculados.PropBag");
            // 
            // dsSPXSeguridad1
            // 
            this.dsSPXSeguridad1.DataSetName = "dsSPXSeguridad";
            this.dsSPXSeguridad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(379, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnAgregaUsuario
            // 
            this.btnAgregaUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregaUsuario.Location = new System.Drawing.Point(345, 283);
            this.btnAgregaUsuario.Name = "btnAgregaUsuario";
            this.btnAgregaUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnAgregaUsuario.TabIndex = 1;
            this.btnAgregaUsuario.Text = "Editar";
            this.btnAgregaUsuario.Click += new System.EventHandler(this.btnAgregaUsuario_Click);
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btnGenerarListado);
            this.groupPanel2.Controls.Add(this.c1CmbModulo);
            this.groupPanel2.Controls.Add(this.rdGruposModulos);
            this.groupPanel2.Controls.Add(this.pictureBox1);
            this.groupPanel2.Controls.Add(this.rdVerModulos);
            this.groupPanel2.Controls.Add(this.grdGrupoModulo);
            this.groupPanel2.Controls.Add(this.grdModulos);
            this.groupPanel2.Location = new System.Drawing.Point(9, 10);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(420, 559);
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
            this.groupPanel2.TabIndex = 7;
            this.groupPanel2.Text = "Modulos y Funcionalidades del Aplicativo";
            // 
            // btnGenerarListado
            // 
            this.btnGenerarListado.Location = new System.Drawing.Point(212, 3);
            this.btnGenerarListado.Name = "btnGenerarListado";
            this.btnGenerarListado.Size = new System.Drawing.Size(137, 36);
            this.btnGenerarListado.TabIndex = 12;
            this.btnGenerarListado.Text = "Generar Listado de Asignaciones";
            this.btnGenerarListado.Click += new System.EventHandler(this.btnGenerarListado_Click);
            // 
            // c1CmbModulo
            // 
            this.c1CmbModulo.AllowColMove = true;
            this.c1CmbModulo.AllowColSelect = true;
            this.c1CmbModulo.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows;
            this.c1CmbModulo.AlternatingRows = false;
            this.c1CmbModulo.CaptionStyle = style9;
            this.c1CmbModulo.ColumnCaptionHeight = 17;
            this.c1CmbModulo.ColumnFooterHeight = 17;
            this.c1CmbModulo.DataMember = "modulo_seguridad";
            this.c1CmbModulo.DataSource = this.dsSPXSeguridad1;
            this.c1CmbModulo.DisplayMember = "modulo_seguridad.nombre_modulo_seguridad";
            this.c1CmbModulo.EvenRowStyle = style10;
            this.c1CmbModulo.FetchRowStyles = false;
            this.c1CmbModulo.FooterStyle = style11;
            this.c1CmbModulo.HeadingStyle = style12;
            this.c1CmbModulo.HighLightRowStyle = style13;
            this.c1CmbModulo.Images.Add(((System.Drawing.Image)(resources.GetObject("c1CmbModulo.Images"))));
            this.c1CmbModulo.Location = new System.Drawing.Point(73, 339);
            this.c1CmbModulo.Name = "c1CmbModulo";
            this.c1CmbModulo.OddRowStyle = style14;
            this.c1CmbModulo.RecordSelectorStyle = style15;
            this.c1CmbModulo.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.c1CmbModulo.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
            this.c1CmbModulo.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1CmbModulo.ScrollTips = false;
            this.c1CmbModulo.Size = new System.Drawing.Size(100, 150);
            this.c1CmbModulo.Style = style16;
            this.c1CmbModulo.TabIndex = 11;
            this.c1CmbModulo.TabStop = false;
            this.c1CmbModulo.Text = "c1TrueDBDropdown1";
            this.c1CmbModulo.ValueMember = "modulo_seguridad.cod_modulo_seguridad";
            this.c1CmbModulo.ValueTranslate = true;
            this.c1CmbModulo.Visible = false;
            this.c1CmbModulo.PropBag = resources.GetString("c1CmbModulo.PropBag");
            // 
            // rdGruposModulos
            // 
            this.rdGruposModulos.AutoSize = true;
            this.rdGruposModulos.Location = new System.Drawing.Point(118, 14);
            this.rdGruposModulos.Name = "rdGruposModulos";
            this.rdGruposModulos.Size = new System.Drawing.Size(65, 17);
            this.rdGruposModulos.TabIndex = 8;
            this.rdGruposModulos.Text = "Modulos";
            this.rdGruposModulos.UseVisualStyleBackColor = true;
            this.rdGruposModulos.CheckedChanged += new System.EventHandler(this.rdGruposModulos_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(355, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // rdVerModulos
            // 
            this.rdVerModulos.AutoSize = true;
            this.rdVerModulos.Checked = true;
            this.rdVerModulos.Location = new System.Drawing.Point(10, 14);
            this.rdVerModulos.Name = "rdVerModulos";
            this.rdVerModulos.Size = new System.Drawing.Size(102, 17);
            this.rdVerModulos.TabIndex = 5;
            this.rdVerModulos.TabStop = true;
            this.rdVerModulos.Text = "Funcionalidades";
            this.rdVerModulos.UseVisualStyleBackColor = true;
            this.rdVerModulos.CheckedChanged += new System.EventHandler(this.rdVerModulos_CheckedChanged);
            // 
            // grdGrupoModulo
            // 
            this.grdGrupoModulo.AllowUpdate = false;
            this.grdGrupoModulo.DataMember = "modulo_seguridad";
            this.grdGrupoModulo.DataSource = this.dsSPXSeguridad1;
            this.grdGrupoModulo.FilterBar = true;
            this.grdGrupoModulo.GroupByCaption = "Drag a column header here to group by that column";
            this.grdGrupoModulo.Images.Add(((System.Drawing.Image)(resources.GetObject("grdGrupoModulo.Images"))));
            this.grdGrupoModulo.Location = new System.Drawing.Point(10, 43);
            this.grdGrupoModulo.Name = "grdGrupoModulo";
            this.grdGrupoModulo.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdGrupoModulo.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdGrupoModulo.PreviewInfo.ZoomFactor = 75D;
            this.grdGrupoModulo.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdGrupoModulo.PrintInfo.PageSettings")));
            this.grdGrupoModulo.Size = new System.Drawing.Size(386, 488);
            this.grdGrupoModulo.TabIndex = 9;
            this.grdGrupoModulo.Text = "c1TrueDBGrid1";
            this.grdGrupoModulo.Visible = false;
            this.grdGrupoModulo.RowColChange += new C1.Win.C1TrueDBGrid.RowColChangeEventHandler(this.grdGrupoModulo_RowColChange);
            this.grdGrupoModulo.PropBag = resources.GetString("grdGrupoModulo.PropBag");
            // 
            // grdModulos
            // 
            this.grdModulos.AllowUpdate = false;
            this.grdModulos.DataMember = "funcionalidad";
            this.grdModulos.DataSource = this.dsSPXSeguridad1;
            this.grdModulos.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdModulos.FilterBar = true;
            this.grdModulos.GroupByCaption = "";
            this.grdModulos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdModulos.Images"))));
            this.grdModulos.Location = new System.Drawing.Point(10, 43);
            this.grdModulos.Name = "grdModulos";
            this.grdModulos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdModulos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdModulos.PreviewInfo.ZoomFactor = 75D;
            this.grdModulos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdModulos.PrintInfo.PageSettings")));
            this.grdModulos.Size = new System.Drawing.Size(386, 488);
            this.grdModulos.TabIndex = 10;
            this.grdModulos.Text = "c1TrueDBGrid1";
            this.grdModulos.RowColChange += new C1.Win.C1TrueDBGrid.RowColChangeEventHandler(this.grdModulos_RowColChange);
            this.grdModulos.PropBag = resources.GetString("grdModulos.PropBag");
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(759, 537);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 27);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cerrar Ventana";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 576);
            this.ControlBox = false;
            this.Controls.Add(this.lblTituloPermisos);
            this.Controls.Add(this.lblTituloModulo);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPermisos";
            this.Text = "Configuracion de Permisos";
            this.Load += new System.EventHandler(this.frmPermisos_Load);
            this.lblTituloPermisos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.lblTituloModulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1CmbTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVinculados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1CmbModulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrupoModulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdModulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel lblTituloPermisos;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox chkEscribir;
        private System.Windows.Forms.CheckBox chkDenegar;
        private System.Windows.Forms.CheckBox chkLectEjec;
        private System.Windows.Forms.CheckBox chkImprimir;
        private System.Windows.Forms.CheckBox chkModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkControlTotal;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.Button btnAplicar;
        private DevComponents.DotNetBar.Controls.GroupPanel lblTituloModulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAgregaUsuario;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private System.Windows.Forms.RadioButton rdGruposModulos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rdVerModulos;
        private System.Windows.Forms.Button btnCancelar;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad1;

        private C1.Win.C1TrueDBGrid.C1TrueDBDropdown c1CmbModulo;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdModulos;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdGrupoModulo;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private C1.Win.C1TrueDBGrid.C1TrueDBDropdown c1CmbTipo;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdVinculados;
        private System.Windows.Forms.Button btnGenerarListado;
    }
}