namespace spProcesos.ordenesTrabajo.listados
{
    partial class frmListadoEstadisticosGrilla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoEstadisticosGrilla));
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
            C1.Win.C1TrueDBGrid.Style style17 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style18 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style19 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style20 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style21 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style22 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style23 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style24 = new C1.Win.C1TrueDBGrid.Style();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.ordenServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter();
            this.prioridadesOrdenServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.prioridadesOrdenServicioTableAdapter();
            this.estadosOrdenServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.estadosOrdenServicioTableAdapter();
            this.tipoServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.TipoServicioTableAdapter();
            this.grddatos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.c1CmbTiposServicio = new C1.Win.C1TrueDBGrid.C1TrueDBDropdown();
            this.c1CmbPrioiridades = new C1.Win.C1TrueDBGrid.C1TrueDBDropdown();
            this.c1cmbEstados = new C1.Win.C1TrueDBGrid.C1TrueDBDropdown();
            this.btnVerOrden = new DevComponents.DotNetBar.ButtonX();
            this.btnExportarExcel = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.grddatos.BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CmbTiposServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CmbPrioiridades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1cmbEstados)).BeginInit();
            this.SuspendLayout();
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordenServicioTableAdapter1
            // 
            this.ordenServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // prioridadesOrdenServicioTableAdapter1
            // 
            this.prioridadesOrdenServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // estadosOrdenServicioTableAdapter1
            // 
            this.estadosOrdenServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // tipoServicioTableAdapter1
            // 
            this.tipoServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // grddatos
            // 
            this.grddatos.AllowUpdate = false;
            this.grddatos.AlternatingRows = true;
            this.grddatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grddatos.DataMember = "ordenServicio";
            this.grddatos.DataSource = this.dsSpx1;
            this.grddatos.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grddatos.FilterBar = true;
            this.grddatos.GroupByCaption = "";
            this.grddatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grddatos.Images"))));
            this.grddatos.Location = new System.Drawing.Point(12, 69);
            this.grddatos.Name = "grddatos";
            this.grddatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grddatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grddatos.PreviewInfo.ZoomFactor = 75;
            this.grddatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grddatos.PrintInfo.PageSettings")));
            this.grddatos.Size = new System.Drawing.Size(858, 457);
            this.grddatos.TabIndex = 0;
            this.grddatos.Text = "c1TrueDBGrid1";
            this.grddatos.PropBag = resources.GetString("grddatos.PropBag");
            // 
            // c1CmbTiposServicio
            // 
            this.c1CmbTiposServicio.AllowColMove = true;
            this.c1CmbTiposServicio.AllowColSelect = true;
            this.c1CmbTiposServicio.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows;
            this.c1CmbTiposServicio.AlternatingRows = false;
            this.c1CmbTiposServicio.CaptionStyle = style1;
            this.c1CmbTiposServicio.ColumnCaptionHeight = 17;
            this.c1CmbTiposServicio.ColumnFooterHeight = 17;
            this.c1CmbTiposServicio.ColumnHeaders = false;
            this.c1CmbTiposServicio.DataMember = "TipoServicio";
            this.c1CmbTiposServicio.DataSource = this.dsSpx1;
            this.c1CmbTiposServicio.DisplayMember = "TipoServicio.nombretipoServicio";
            this.c1CmbTiposServicio.EvenRowStyle = style2;
            this.c1CmbTiposServicio.FetchRowStyles = false;
            this.c1CmbTiposServicio.FooterStyle = style3;
            this.c1CmbTiposServicio.HeadingStyle = style4;
            this.c1CmbTiposServicio.HighLightRowStyle = style5;
            this.c1CmbTiposServicio.Images.Add(((System.Drawing.Image)(resources.GetObject("c1CmbTiposServicio.Images"))));
            this.c1CmbTiposServicio.Location = new System.Drawing.Point(431, 336);
            this.c1CmbTiposServicio.Name = "c1CmbTiposServicio";
            this.c1CmbTiposServicio.OddRowStyle = style6;
            this.c1CmbTiposServicio.RecordSelectorStyle = style7;
            this.c1CmbTiposServicio.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.c1CmbTiposServicio.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
            this.c1CmbTiposServicio.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1CmbTiposServicio.ScrollTips = false;
            this.c1CmbTiposServicio.Size = new System.Drawing.Size(155, 45);
            this.c1CmbTiposServicio.Style = style8;
            this.c1CmbTiposServicio.TabIndex = 1;
            this.c1CmbTiposServicio.TabStop = false;
            this.c1CmbTiposServicio.Text = "c1TrueDBDropdown1";
            this.c1CmbTiposServicio.ValueMember = "TipoServicio.codTipoServicio";
            this.c1CmbTiposServicio.ValueTranslate = true;
            this.c1CmbTiposServicio.Visible = false;
            this.c1CmbTiposServicio.PropBag = resources.GetString("c1CmbTiposServicio.PropBag");
            // 
            // c1CmbPrioiridades
            // 
            this.c1CmbPrioiridades.AllowColMove = true;
            this.c1CmbPrioiridades.AllowColSelect = true;
            this.c1CmbPrioiridades.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows;
            this.c1CmbPrioiridades.AlternatingRows = false;
            this.c1CmbPrioiridades.CaptionStyle = style9;
            this.c1CmbPrioiridades.ColumnCaptionHeight = 17;
            this.c1CmbPrioiridades.ColumnFooterHeight = 17;
            this.c1CmbPrioiridades.ColumnHeaders = false;
            this.c1CmbPrioiridades.DataMember = "prioridadesOrdenServicio";
            this.c1CmbPrioiridades.DataSource = this.dsSpx1;
            this.c1CmbPrioiridades.DisplayMember = "prioridadesOrdenServicio.nombre";
            this.c1CmbPrioiridades.EvenRowStyle = style10;
            this.c1CmbPrioiridades.FetchRowStyles = false;
            this.c1CmbPrioiridades.FooterStyle = style11;
            this.c1CmbPrioiridades.HeadingStyle = style12;
            this.c1CmbPrioiridades.HighLightRowStyle = style13;
            this.c1CmbPrioiridades.Images.Add(((System.Drawing.Image)(resources.GetObject("c1CmbPrioiridades.Images"))));
            this.c1CmbPrioiridades.Location = new System.Drawing.Point(478, 236);
            this.c1CmbPrioiridades.Name = "c1CmbPrioiridades";
            this.c1CmbPrioiridades.OddRowStyle = style14;
            this.c1CmbPrioiridades.RecordSelectorStyle = style15;
            this.c1CmbPrioiridades.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.c1CmbPrioiridades.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
            this.c1CmbPrioiridades.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1CmbPrioiridades.ScrollTips = false;
            this.c1CmbPrioiridades.Size = new System.Drawing.Size(119, 58);
            this.c1CmbPrioiridades.Style = style16;
            this.c1CmbPrioiridades.TabIndex = 2;
            this.c1CmbPrioiridades.TabStop = false;
            this.c1CmbPrioiridades.Text = "c1TrueDBDropdown2";
            this.c1CmbPrioiridades.ValueMember = "prioridadesOrdenServicio.codPrioridadOS";
            this.c1CmbPrioiridades.ValueTranslate = true;
            this.c1CmbPrioiridades.Visible = false;
            this.c1CmbPrioiridades.PropBag = resources.GetString("c1CmbPrioiridades.PropBag");
            // 
            // c1cmbEstados
            // 
            this.c1cmbEstados.AllowColMove = true;
            this.c1cmbEstados.AllowColSelect = true;
            this.c1cmbEstados.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows;
            this.c1cmbEstados.AlternatingRows = false;
            this.c1cmbEstados.CaptionStyle = style17;
            this.c1cmbEstados.ColumnCaptionHeight = 17;
            this.c1cmbEstados.ColumnFooterHeight = 17;
            this.c1cmbEstados.ColumnHeaders = false;
            this.c1cmbEstados.DataMember = "estadosOrdenServicio";
            this.c1cmbEstados.DataSource = this.dsSpx1;
            this.c1cmbEstados.DisplayMember = "estadosOrdenServicio.nombreEstado";
            this.c1cmbEstados.EvenRowStyle = style18;
            this.c1cmbEstados.FetchRowStyles = false;
            this.c1cmbEstados.FooterStyle = style19;
            this.c1cmbEstados.HeadingStyle = style20;
            this.c1cmbEstados.HighLightRowStyle = style21;
            this.c1cmbEstados.Images.Add(((System.Drawing.Image)(resources.GetObject("c1cmbEstados.Images"))));
            this.c1cmbEstados.Location = new System.Drawing.Point(88, 260);
            this.c1cmbEstados.Name = "c1cmbEstados";
            this.c1cmbEstados.OddRowStyle = style22;
            this.c1cmbEstados.RecordSelectorStyle = style23;
            this.c1cmbEstados.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.c1cmbEstados.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
            this.c1cmbEstados.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1cmbEstados.ScrollTips = false;
            this.c1cmbEstados.Size = new System.Drawing.Size(122, 63);
            this.c1cmbEstados.Style = style24;
            this.c1cmbEstados.TabIndex = 3;
            this.c1cmbEstados.TabStop = false;
            this.c1cmbEstados.Text = "c1TrueDBDropdown3";
            this.c1cmbEstados.ValueMember = "estadosOrdenServicio.codEstadoOrdenServicio";
            this.c1cmbEstados.ValueTranslate = true;
            this.c1cmbEstados.Visible = false;
            this.c1cmbEstados.PropBag = resources.GetString("c1cmbEstados.PropBag");
            // 
            // btnVerOrden
            // 
            this.btnVerOrden.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVerOrden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerOrden.Image = ((System.Drawing.Image)(resources.GetObject("btnVerOrden.Image")));
            this.btnVerOrden.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnVerOrden.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnVerOrden.Location = new System.Drawing.Point(723, 2);
            this.btnVerOrden.Name = "btnVerOrden";
            this.btnVerOrden.Size = new System.Drawing.Size(75, 61);
            this.btnVerOrden.TabIndex = 16;
            this.btnVerOrden.Text = "Ver Orden de Servicio";
            this.btnVerOrden.Click += new System.EventHandler(this.btnVerOrden_Click);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExportarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarExcel.Image")));
            this.btnExportarExcel.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnExportarExcel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnExportarExcel.Location = new System.Drawing.Point(804, 2);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(75, 61);
            this.btnExportarExcel.TabIndex = 15;
            this.btnExportarExcel.Text = "Exportar Excel";
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // frmListadoEstadisticosGrilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(882, 538);
            this.Controls.Add(this.btnVerOrden);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.c1cmbEstados);
            this.Controls.Add(this.c1CmbPrioiridades);
            this.Controls.Add(this.c1CmbTiposServicio);
            this.Controls.Add(this.grddatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListadoEstadisticosGrilla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenes de Servicio";
            this.Load += new System.EventHandler(this.frmListadoEstadisticosGrilla_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmListadoEstadisticosGrilla_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grddatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CmbTiposServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CmbPrioiridades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1cmbEstados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter ordenServicioTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.prioridadesOrdenServicioTableAdapter prioridadesOrdenServicioTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.estadosOrdenServicioTableAdapter estadosOrdenServicioTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.TipoServicioTableAdapter tipoServicioTableAdapter1;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grddatos;
        private C1.Win.C1TrueDBGrid.C1TrueDBDropdown c1CmbTiposServicio;
        private C1.Win.C1TrueDBGrid.C1TrueDBDropdown c1CmbPrioiridades;
        private C1.Win.C1TrueDBGrid.C1TrueDBDropdown c1cmbEstados;
        private DevComponents.DotNetBar.ButtonX btnVerOrden;
        private DevComponents.DotNetBar.ButtonX btnExportarExcel;
    }
}