namespace CgDataFrm
{
    partial class frmModelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModelo));
            this.ribbonControlDataFrm = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel2dataFrm = new DevComponents.DotNetBar.RibbonPanel();
            this.btnGuardarGrilla = new DevComponents.DotNetBar.ButtonX();
            this.btnReinicciargrilla = new DevComponents.DotNetBar.ButtonX();
            this.txtTotalRegistros = new System.Windows.Forms.TextBox();
            this.lblTotalr = new System.Windows.Forms.Label();
            this.chkAbrirDespuesdeExportar = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.grpOpcionesExportar = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnExportarExcel = new DevComponents.DotNetBar.ButtonX();
            this.btnTxt = new DevComponents.DotNetBar.ButtonX();
            this.btnPdf = new DevComponents.DotNetBar.ButtonX();
            this.btnHtml = new DevComponents.DotNetBar.ButtonX();
            this.grdDatos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.ribbonPanel1dataFrm = new DevComponents.DotNetBar.RibbonPanel();
            this.grpBarraDatos = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cgDataControler1 = new CGDataControler.CGDataControler();
            this.ribbonTabItem1dataFrm = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem2dataFrm = new DevComponents.DotNetBar.RibbonTabItem();
            this.balloonTipModel = new DevComponents.DotNetBar.BalloonTip();
            this.ribbonControlDataFrm.SuspendLayout();
            this.ribbonPanel2dataFrm.SuspendLayout();
            this.grpOpcionesExportar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.ribbonPanel1dataFrm.SuspendLayout();
            this.grpBarraDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControlDataFrm
            // 
            this.ribbonControlDataFrm.CaptionVisible = true;
            this.ribbonControlDataFrm.Controls.Add(this.ribbonPanel1dataFrm);
            this.ribbonControlDataFrm.Controls.Add(this.ribbonPanel2dataFrm);
            this.ribbonControlDataFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonControlDataFrm.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabItem1dataFrm,
            this.ribbonTabItem2dataFrm});
            this.ribbonControlDataFrm.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControlDataFrm.Location = new System.Drawing.Point(4, 1);
            this.ribbonControlDataFrm.Name = "ribbonControlDataFrm";
            this.ribbonControlDataFrm.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControlDataFrm.Size = new System.Drawing.Size(976, 587);
            this.ribbonControlDataFrm.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonControlDataFrm.TabGroupHeight = 14;
            this.ribbonControlDataFrm.TabIndex = 0;
            this.ribbonControlDataFrm.Text = "ribbonControl1";
            this.ribbonControlDataFrm.SelectedRibbonTabChanged += new System.EventHandler(this.ribbonControlDataFrm_SelectedRibbonTabChanged);
            this.ribbonControlDataFrm.TabIndexChanged += new System.EventHandler(this.ribbonControlDataFrm_TabIndexChanged);
            // 
            // ribbonPanel2dataFrm
            // 
            this.ribbonPanel2dataFrm.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel2dataFrm.Controls.Add(this.btnGuardarGrilla);
            this.ribbonPanel2dataFrm.Controls.Add(this.btnReinicciargrilla);
            this.ribbonPanel2dataFrm.Controls.Add(this.txtTotalRegistros);
            this.ribbonPanel2dataFrm.Controls.Add(this.lblTotalr);
            this.ribbonPanel2dataFrm.Controls.Add(this.chkAbrirDespuesdeExportar);
            this.ribbonPanel2dataFrm.Controls.Add(this.grpOpcionesExportar);
            this.ribbonPanel2dataFrm.Controls.Add(this.grdDatos);
            this.ribbonPanel2dataFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2dataFrm.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel2dataFrm.Name = "ribbonPanel2dataFrm";
            this.ribbonPanel2dataFrm.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2dataFrm.Size = new System.Drawing.Size(976, 530);
            this.ribbonPanel2dataFrm.TabIndex = 2;
            this.ribbonPanel2dataFrm.Visible = false;
            // 
            // btnGuardarGrilla
            // 
            this.btnGuardarGrilla.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGuardarGrilla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarGrilla.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarGrilla.Image")));
            this.btnGuardarGrilla.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnGuardarGrilla.Location = new System.Drawing.Point(931, 85);
            this.btnGuardarGrilla.Name = "btnGuardarGrilla";
            this.btnGuardarGrilla.Size = new System.Drawing.Size(33, 33);
            this.btnGuardarGrilla.TabIndex = 73;
            this.btnGuardarGrilla.Click += new System.EventHandler(this.btnGuardarGrilla_Click);
            // 
            // btnReinicciargrilla
            // 
            this.btnReinicciargrilla.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReinicciargrilla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReinicciargrilla.Image = ((System.Drawing.Image)(resources.GetObject("btnReinicciargrilla.Image")));
            this.btnReinicciargrilla.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnReinicciargrilla.Location = new System.Drawing.Point(896, 85);
            this.btnReinicciargrilla.Name = "btnReinicciargrilla";
            this.btnReinicciargrilla.Size = new System.Drawing.Size(33, 33);
            this.btnReinicciargrilla.TabIndex = 72;
            this.btnReinicciargrilla.Click += new System.EventHandler(this.btnReinicciargrilla_Click);
            // 
            // txtTotalRegistros
            // 
            this.txtTotalRegistros.BackColor = System.Drawing.Color.White;
            this.txtTotalRegistros.Location = new System.Drawing.Point(864, 13);
            this.txtTotalRegistros.Name = "txtTotalRegistros";
            this.txtTotalRegistros.ReadOnly = true;
            this.txtTotalRegistros.Size = new System.Drawing.Size(100, 20);
            this.txtTotalRegistros.TabIndex = 11;
            // 
            // lblTotalr
            // 
            this.lblTotalr.AutoSize = true;
            this.lblTotalr.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalr.Location = new System.Drawing.Point(780, 16);
            this.lblTotalr.Name = "lblTotalr";
            this.lblTotalr.Size = new System.Drawing.Size(78, 13);
            this.lblTotalr.TabIndex = 10;
            this.lblTotalr.Text = "Total Registros";
            // 
            // chkAbrirDespuesdeExportar
            // 
            this.chkAbrirDespuesdeExportar.BackColor = System.Drawing.Color.Transparent;
            this.chkAbrirDespuesdeExportar.Location = new System.Drawing.Point(289, 13);
            this.chkAbrirDespuesdeExportar.Name = "chkAbrirDespuesdeExportar";
            this.chkAbrirDespuesdeExportar.Size = new System.Drawing.Size(202, 23);
            this.chkAbrirDespuesdeExportar.TabIndex = 9;
            this.chkAbrirDespuesdeExportar.Text = "Abrir Archivo despues de exportar";
            // 
            // grpOpcionesExportar
            // 
            this.grpOpcionesExportar.BackColor = System.Drawing.Color.Transparent;
            this.grpOpcionesExportar.CanvasColor = System.Drawing.SystemColors.Control;
            this.grpOpcionesExportar.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.grpOpcionesExportar.Controls.Add(this.btnExportarExcel);
            this.grpOpcionesExportar.Controls.Add(this.btnTxt);
            this.grpOpcionesExportar.Controls.Add(this.btnPdf);
            this.grpOpcionesExportar.Controls.Add(this.btnHtml);
            this.grpOpcionesExportar.Location = new System.Drawing.Point(8, 3);
            this.grpOpcionesExportar.Name = "grpOpcionesExportar";
            this.grpOpcionesExportar.Size = new System.Drawing.Size(275, 112);
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
            this.grpOpcionesExportar.Style.CornerDiameter = 4;
            this.grpOpcionesExportar.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grpOpcionesExportar.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.grpOpcionesExportar.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grpOpcionesExportar.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.grpOpcionesExportar.TabIndex = 8;
            this.grpOpcionesExportar.Text = "Opciones Para Exportar";
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExportarExcel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarExcel.Image")));
            this.btnExportarExcel.ImageFixedSize = new System.Drawing.Size(44, 44);
            this.btnExportarExcel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnExportarExcel.Location = new System.Drawing.Point(204, 2);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(58, 84);
            this.btnExportarExcel.TabIndex = 2;
            this.btnExportarExcel.Text = "Exportar a Excel";
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // btnTxt
            // 
            this.btnTxt.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTxt.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTxt.Image = ((System.Drawing.Image)(resources.GetObject("btnTxt.Image")));
            this.btnTxt.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnTxt.Location = new System.Drawing.Point(6, 2);
            this.btnTxt.Name = "btnTxt";
            this.btnTxt.Size = new System.Drawing.Size(58, 84);
            this.btnTxt.TabIndex = 3;
            this.btnTxt.Text = "Exportar a Texto Plano";
            this.btnTxt.Click += new System.EventHandler(this.btnTxt_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPdf.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.Image = ((System.Drawing.Image)(resources.GetObject("btnPdf.Image")));
            this.btnPdf.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPdf.Location = new System.Drawing.Point(138, 4);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(58, 84);
            this.btnPdf.TabIndex = 1;
            this.btnPdf.Text = "Exportar a  PDF";
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnHtml
            // 
            this.btnHtml.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHtml.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHtml.Image = ((System.Drawing.Image)(resources.GetObject("btnHtml.Image")));
            this.btnHtml.ImageFixedSize = new System.Drawing.Size(44, 44);
            this.btnHtml.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnHtml.Location = new System.Drawing.Point(72, 2);
            this.btnHtml.Name = "btnHtml";
            this.btnHtml.Size = new System.Drawing.Size(58, 84);
            this.btnHtml.TabIndex = 4;
            this.btnHtml.Text = "Exportar a  HTML";
            this.btnHtml.Click += new System.EventHandler(this.btnHtml_Click);
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUpdate = false;
            this.grdDatos.AlternatingRows = true;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdDatos.FilterBar = true;
            this.grdDatos.GroupByCaption = "Arrastre el encabezado de alguna columna para agrupar las filas por esta misma.";
            this.grdDatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDatos.Images"))));
            this.grdDatos.Location = new System.Drawing.Point(8, 124);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(962, 400);
            this.grdDatos.TabIndex = 7;
            this.grdDatos.Text = "c1TrueDBGrid1";
            this.grdDatos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver;
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
            // 
            // ribbonPanel1dataFrm
            // 
            this.ribbonPanel1dataFrm.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel1dataFrm.Controls.Add(this.grpBarraDatos);
            this.ribbonPanel1dataFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1dataFrm.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel1dataFrm.Name = "ribbonPanel1dataFrm";
            this.ribbonPanel1dataFrm.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1dataFrm.Size = new System.Drawing.Size(976, 530);
            this.ribbonPanel1dataFrm.TabIndex = 1;
            // 
            // grpBarraDatos
            // 
            this.grpBarraDatos.BackColor = System.Drawing.Color.Transparent;
            this.grpBarraDatos.CanvasColor = System.Drawing.SystemColors.Control;
            this.grpBarraDatos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.grpBarraDatos.Controls.Add(this.cgDataControler1);
            this.grpBarraDatos.Location = new System.Drawing.Point(8, 3);
            this.grpBarraDatos.Name = "grpBarraDatos";
            this.grpBarraDatos.Size = new System.Drawing.Size(899, 88);
            // 
            // 
            // 
            this.grpBarraDatos.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.grpBarraDatos.Style.BackColorGradientAngle = 90;
            this.grpBarraDatos.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.grpBarraDatos.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpBarraDatos.Style.BorderBottomWidth = 1;
            this.grpBarraDatos.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.grpBarraDatos.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpBarraDatos.Style.BorderLeftWidth = 1;
            this.grpBarraDatos.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpBarraDatos.Style.BorderRightWidth = 1;
            this.grpBarraDatos.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpBarraDatos.Style.BorderTopWidth = 1;
            this.grpBarraDatos.Style.CornerDiameter = 4;
            this.grpBarraDatos.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grpBarraDatos.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.grpBarraDatos.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grpBarraDatos.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.grpBarraDatos.TabIndex = 1;
            this.grpBarraDatos.Text = "Opciones de Datos";
            // 
            // cgDataControler1
            // 
            this.cgDataControler1.BackColor = System.Drawing.Color.Transparent;
            this.cgDataControler1.campos = "";
            this.cgDataControler1.cmTabla = null;
            this.cgDataControler1.ConBotonAceptar = true;
            this.cgDataControler1.ConBotonAdicionar = true;
            this.cgDataControler1.ConBotonAnterior = true;
            this.cgDataControler1.ConBotonDescartar = true;
            this.cgDataControler1.ConBotonEditar = true;
            this.cgDataControler1.ConBotonEliminar = true;
            this.cgDataControler1.ConBotonPrimero = true;
            this.cgDataControler1.ConBotonSalir = true;
            this.cgDataControler1.ConBotonSiguiente = true;
            this.cgDataControler1.ConBotonUltimo = true;
            this.cgDataControler1.dataTabla = null;
            this.cgDataControler1.EditaControles = true;
            this.cgDataControler1.EditaLlaves = false;
            this.cgDataControler1.Esmdi = false;
            this.cgDataControler1.EstadoControles = true;
            this.cgDataControler1.EstadoDatos = CGDataControler.EstadosDatos.Consulta;
            this.cgDataControler1.EventosEncendidos = false;
            this.cgDataControler1.FiltroObligatorio = "";
            this.cgDataControler1.GroupByObligatorio = "";
            this.cgDataControler1.GuardarEnBaseDeDatos = true;
            this.cgDataControler1.JoinObligatorio = "";
            this.cgDataControler1.Location = new System.Drawing.Point(-5, 2);
            this.cgDataControler1.MensajeAntesDeEliminar = "¿Esta seguro de querer eliminar este registro?";
            this.cgDataControler1.MensajeAntesDeEliminarTitulo = "Confirmar Eliminación";
            this.cgDataControler1.ModuloSeguridad = 0;
            this.cgDataControler1.MostrarConsulta = true;
            this.cgDataControler1.MostrarControlDatos = true;
            this.cgDataControler1.Name = "cgDataControler1";
            this.cgDataControler1.OrderByObligatorio = "";
            this.cgDataControler1.PanelConsultaVisible = true;
            this.cgDataControler1.Size = new System.Drawing.Size(787, 48);
            this.cgDataControler1.TabIndex = 0;
            this.cgDataControler1.TableAdapter = null;
            this.cgDataControler1.TamanoImagenesX = 30;
            this.cgDataControler1.TamanoImagenesXMax = 34;
            this.cgDataControler1.TamanoImagenesY = 30;
            this.cgDataControler1.TamanoImagenesYMax = 34;
            this.cgDataControler1.UsarEfectos = false;
            // 
            // ribbonTabItem1dataFrm
            // 
            this.ribbonTabItem1dataFrm.Checked = true;
            this.ribbonTabItem1dataFrm.ImagePaddingHorizontal = 8;
            this.ribbonTabItem1dataFrm.Name = "ribbonTabItem1dataFrm";
            this.ribbonTabItem1dataFrm.Panel = this.ribbonPanel1dataFrm;
            this.ribbonTabItem1dataFrm.Text = "Datos Generales";
            // 
            // ribbonTabItem2dataFrm
            // 
            this.ribbonTabItem2dataFrm.ImagePaddingHorizontal = 8;
            this.ribbonTabItem2dataFrm.Name = "ribbonTabItem2dataFrm";
            this.ribbonTabItem2dataFrm.Panel = this.ribbonPanel2dataFrm;
            this.ribbonTabItem2dataFrm.Text = "Listado de Registros";
            // 
            // frmModelo
            // 
            this.ClientSize = new System.Drawing.Size(984, 590);
            this.Controls.Add(this.ribbonControlDataFrm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModelo";
            this.Load += new System.EventHandler(this.frmModelo_Load);
            this.SizeChanged += new System.EventHandler(this.frmModelo_SizeChanged);
            this.ribbonControlDataFrm.ResumeLayout(false);
            this.ribbonControlDataFrm.PerformLayout();
            this.ribbonPanel2dataFrm.ResumeLayout(false);
            this.ribbonPanel2dataFrm.PerformLayout();
            this.grpOpcionesExportar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ribbonPanel1dataFrm.ResumeLayout(false);
            this.grpBarraDatos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1dataFrm;
        protected DevComponents.DotNetBar.RibbonControl ribbonControlDataFrm;
        protected DevComponents.DotNetBar.RibbonPanel ribbonPanel1dataFrm;
        protected CGDataControler.CGDataControler cgDataControler1;
        private DevComponents.DotNetBar.Controls.GroupPanel grpBarraDatos;
        protected DevComponents.DotNetBar.RibbonPanel ribbonPanel2dataFrm;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkAbrirDespuesdeExportar;
        protected DevComponents.DotNetBar.ButtonX btnExportarExcel;
        protected DevComponents.DotNetBar.ButtonX btnPdf;
        protected DevComponents.DotNetBar.ButtonX btnHtml;
        protected DevComponents.DotNetBar.ButtonX btnTxt;
        public C1.Win.C1TrueDBGrid.C1TrueDBGrid grdDatos;
        protected System.Windows.Forms.TextBox txtTotalRegistros;
        protected System.Windows.Forms.Label lblTotalr;
        protected DevComponents.DotNetBar.Controls.GroupPanel grpOpcionesExportar;
        protected DevComponents.DotNetBar.RibbonTabItem ribbonTabItem2dataFrm;
        private DevComponents.DotNetBar.BalloonTip balloonTipModel;
        private DevComponents.DotNetBar.ButtonX btnGuardarGrilla;
        private DevComponents.DotNetBar.ButtonX btnReinicciargrilla;
    }
}