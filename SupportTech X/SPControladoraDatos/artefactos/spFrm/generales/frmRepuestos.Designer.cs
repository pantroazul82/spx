namespace SpFrm.generales
{
    partial class frmRepuestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepuestos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtRepuesto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.repuestosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.repuestosTableAdapter();
            this.rbArchivos = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.archivosxRepuestoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.archivosxRepuestoTableAdapter();
            this.btnQuitarArchivo = new System.Windows.Forms.Button();
            this.btnSubirArchivo = new System.Windows.Forms.Button();
            this.btnGuardarArchivo = new System.Windows.Forms.Button();
            this.btnVerArchivo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.grdArchivos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ribbonControlDataFrm.SuspendLayout();
            this.ribbonPanel1dataFrm.SuspendLayout();
            this.ribbonPanel2dataFrm.SuspendLayout();
            this.grdDatos.BeginInit();
            this.grpOpcionesExportar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.ribbonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdArchivos)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControlDataFrm
            // 
            this.ribbonControlDataFrm.Controls.Add(this.ribbonPanel1);
            this.ribbonControlDataFrm.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.rbArchivos});
            this.ribbonControlDataFrm.Size = new System.Drawing.Size(968, 553);
            this.ribbonControlDataFrm.SelectedRibbonTabChanged += new System.EventHandler(this.ribbonControlDataFrm_SelectedRibbonTabChanged);
            this.ribbonControlDataFrm.Controls.SetChildIndex(this.ribbonPanel2dataFrm, 0);
            this.ribbonControlDataFrm.Controls.SetChildIndex(this.ribbonPanel1, 0);
            this.ribbonControlDataFrm.Controls.SetChildIndex(this.ribbonPanel1dataFrm, 0);
            // 
            // ribbonPanel1dataFrm
            // 
            this.ribbonPanel1dataFrm.Controls.Add(this.txtPrecio);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtRepuesto);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtObservaciones);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtCodigo);
            this.ribbonPanel1dataFrm.Controls.Add(this.label4);
            this.ribbonPanel1dataFrm.Controls.Add(this.label3);
            this.ribbonPanel1dataFrm.Controls.Add(this.label2);
            this.ribbonPanel1dataFrm.Controls.Add(this.label1);
            this.ribbonPanel1dataFrm.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel1dataFrm.Size = new System.Drawing.Size(968, 496);
            this.ribbonPanel1dataFrm.TabIndex = 0;
            this.ribbonPanel1dataFrm.Visible = true;
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label1, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label2, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label3, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label4, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtCodigo, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtObservaciones, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtRepuesto, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtPrecio, 0);
            // 
            // cgDataControler1
            // 
            this.cgDataControler1.campos = "Codigo|codRepuesto,Repuestp|descripcion,Precio|precio";
            this.cgDataControler1.dataTabla = this.dsSpx1.repuestos;
            this.cgDataControler1.EstadoControles = false;
            this.cgDataControler1.EventosEncendidos = true;
            this.cgDataControler1.estadoControlesChanged += new CGDataControler.dataControlerEventHandler(this.cgDataControler1_estadoControlesChanged);
            // 
            // ribbonPanel2dataFrm
            // 
            this.ribbonPanel2dataFrm.Size = new System.Drawing.Size(968, 496);
            // 
            // grdDatos
            // 
            this.grdDatos.DataMember = "repuestos";
            this.grdDatos.DataSource = this.dsSpx1;
            this.grdDatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDatos.Images"))));
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(902, 314);
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
            this.grpOpcionesExportar.Style.CornerDiameter = 4;
            this.grpOpcionesExportar.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grpOpcionesExportar.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.grpOpcionesExportar.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grpOpcionesExportar.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(14, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Repuesto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(14, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Observaciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(14, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(14, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "repuestos.codRepuesto", true));
            this.txtCodigo.Location = new System.Drawing.Point(136, 119);
            this.txtCodigo.MaxLength = 20;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "repuestos.Observaciones", true));
            this.txtObservaciones.Location = new System.Drawing.Point(136, 227);
            this.txtObservaciones.MaxLength = 250;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ReadOnly = true;
            this.txtObservaciones.Size = new System.Drawing.Size(300, 160);
            this.txtObservaciones.TabIndex = 3;
            // 
            // txtRepuesto
            // 
            this.txtRepuesto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "repuestos.descripcion", true));
            this.txtRepuesto.Location = new System.Drawing.Point(136, 155);
            this.txtRepuesto.MaxLength = 80;
            this.txtRepuesto.Name = "txtRepuesto";
            this.txtRepuesto.ReadOnly = true;
            this.txtRepuesto.Size = new System.Drawing.Size(300, 20);
            this.txtRepuesto.TabIndex = 1;
            // 
            // txtPrecio
            // 
            this.txtPrecio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "repuestos.precio", true));
            this.txtPrecio.Location = new System.Drawing.Point(136, 191);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 2;
            // 
            // repuestosTableAdapter1
            // 
            this.repuestosTableAdapter1.ClearBeforeFill = true;
            // 
            // rbArchivos
            // 
            this.rbArchivos.ImagePaddingHorizontal = 8;
            this.rbArchivos.Name = "rbArchivos";
            this.rbArchivos.Panel = this.ribbonPanel1;
            this.rbArchivos.Text = "Archivos";
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
            this.ribbonPanel1.Size = new System.Drawing.Size(968, 496);
            this.ribbonPanel1.TabIndex = 3;
            this.ribbonPanel1.Visible = false;
            // 
            // archivosxRepuestoTableAdapter1
            // 
            this.archivosxRepuestoTableAdapter1.ClearBeforeFill = true;
            // 
            // btnQuitarArchivo
            // 
            this.btnQuitarArchivo.Location = new System.Drawing.Point(832, 128);
            this.btnQuitarArchivo.Name = "btnQuitarArchivo";
            this.btnQuitarArchivo.Size = new System.Drawing.Size(111, 23);
            this.btnQuitarArchivo.TabIndex = 23;
            this.btnQuitarArchivo.Text = "Quitar Archivo";
            this.btnQuitarArchivo.UseVisualStyleBackColor = true;
            this.btnQuitarArchivo.Click += new System.EventHandler(this.btnQuitarArchivo_Click);
            // 
            // btnSubirArchivo
            // 
            this.btnSubirArchivo.Location = new System.Drawing.Point(832, 99);
            this.btnSubirArchivo.Name = "btnSubirArchivo";
            this.btnSubirArchivo.Size = new System.Drawing.Size(111, 23);
            this.btnSubirArchivo.TabIndex = 22;
            this.btnSubirArchivo.Text = "Agregar Archivo";
            this.btnSubirArchivo.UseVisualStyleBackColor = true;
            this.btnSubirArchivo.Click += new System.EventHandler(this.btnSubirArchivo_Click);
            // 
            // btnGuardarArchivo
            // 
            this.btnGuardarArchivo.Location = new System.Drawing.Point(832, 70);
            this.btnGuardarArchivo.Name = "btnGuardarArchivo";
            this.btnGuardarArchivo.Size = new System.Drawing.Size(111, 23);
            this.btnGuardarArchivo.TabIndex = 21;
            this.btnGuardarArchivo.Text = "Guardar Archivo";
            this.btnGuardarArchivo.UseVisualStyleBackColor = true;
            this.btnGuardarArchivo.Click += new System.EventHandler(this.btnGuardarArchivo_Click);
            // 
            // btnVerArchivo
            // 
            this.btnVerArchivo.Location = new System.Drawing.Point(832, 41);
            this.btnVerArchivo.Name = "btnVerArchivo";
            this.btnVerArchivo.Size = new System.Drawing.Size(111, 23);
            this.btnVerArchivo.TabIndex = 20;
            this.btnVerArchivo.Text = "Ver Archivo";
            this.btnVerArchivo.UseVisualStyleBackColor = true;
            this.btnVerArchivo.Click += new System.EventHandler(this.btnVerArchivo_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(26, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Archivos Asociados al Repuesto";
            // 
            // grdArchivos
            // 
            this.grdArchivos.AllowUpdate = false;
            this.grdArchivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdArchivos.DataMember = "archivosxRepuesto";
            this.grdArchivos.DataSource = this.dsSpx1;
            this.grdArchivos.FilterBar = true;
            this.grdArchivos.GroupByCaption = "Drag a column header here to group by that column";
            this.grdArchivos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdArchivos.Images"))));
            this.grdArchivos.Location = new System.Drawing.Point(26, 40);
            this.grdArchivos.Name = "grdArchivos";
            this.grdArchivos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdArchivos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdArchivos.PreviewInfo.ZoomFactor = 75;
            this.grdArchivos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdArchivos.PrintInfo.PageSettings")));
            this.grdArchivos.Size = new System.Drawing.Size(719, 432);
            this.grdArchivos.TabIndex = 18;
            this.grdArchivos.Text = "c1TrueDBGrid1";
            this.grdArchivos.PropBag = resources.GetString("grdArchivos.PropBag");
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // frmRepuestos
            // 
            this.ClientSize = new System.Drawing.Size(976, 556);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRepuestos";
            this.Text = "Repuestos - Nombre Software";
            this.tituloTabla = "Repuestos";
            this.Load += new System.EventHandler(this.frmRepuestos_Load);
            this.ribbonControlDataFrm.ResumeLayout(false);
            this.ribbonControlDataFrm.PerformLayout();
            this.ribbonPanel1dataFrm.ResumeLayout(false);
            this.ribbonPanel1dataFrm.PerformLayout();
            this.ribbonPanel2dataFrm.ResumeLayout(false);
            this.ribbonPanel2dataFrm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.grpOpcionesExportar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.ribbonPanel1.ResumeLayout(false);
            this.ribbonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdArchivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SPControladoraDatos.dsSpx dsSpx1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtRepuesto;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private SPControladoraDatos.dsSpxTableAdapters.repuestosTableAdapter repuestosTableAdapter1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonTabItem rbArchivos;
        private SPControladoraDatos.dsSpxTableAdapters.archivosxRepuestoTableAdapter archivosxRepuestoTableAdapter1;
        private System.Windows.Forms.Button btnQuitarArchivo;
        private System.Windows.Forms.Button btnSubirArchivo;
        private System.Windows.Forms.Button btnGuardarArchivo;
        private System.Windows.Forms.Button btnVerArchivo;
        private System.Windows.Forms.Label label12;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdArchivos;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
