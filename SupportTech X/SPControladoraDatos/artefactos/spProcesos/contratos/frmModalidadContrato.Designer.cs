namespace spProcesos.contratos
{
    partial class frmModalidadContrato
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
            C1.Win.C1TrueDBGrid.Style style1 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style2 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style3 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style4 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style5 = new C1.Win.C1TrueDBGrid.Style();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModalidadContrato));
            C1.Win.C1TrueDBGrid.Style style6 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style7 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style8 = new C1.Win.C1TrueDBGrid.Style();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.tipoContratoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.tipoContratoTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreTipo = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoContrato = new System.Windows.Forms.ComboBox();
            this.c1CmbTipocontrato = new C1.Win.C1TrueDBGrid.C1TrueDBDropdown();
            this.dsSpx2 = new SPControladoraDatos.dsSpx();
            this.modalidadContratoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.modalidadContratoTableAdapter();
            this.ribbonControlDataFrm.SuspendLayout();
            this.ribbonPanel1dataFrm.SuspendLayout();
            this.grpOpcionesExportar.SuspendLayout();
            this.grdDatos.BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CmbTipocontrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx2)).BeginInit();
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
            this.ribbonControlDataFrm.Size = new System.Drawing.Size(966, 553);
            this.ribbonControlDataFrm.Controls.SetChildIndex(this.ribbonPanel1dataFrm, 0);
            // 
            // ribbonPanel1dataFrm
            // 
            this.ribbonPanel1dataFrm.Controls.Add(this.c1CmbTipocontrato);
            this.ribbonPanel1dataFrm.Controls.Add(this.cmbTipoContrato);
            this.ribbonPanel1dataFrm.Controls.Add(this.label5);
            this.ribbonPanel1dataFrm.Controls.Add(this.label3);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtDescripcion);
            this.ribbonPanel1dataFrm.Controls.Add(this.label2);
            this.ribbonPanel1dataFrm.Controls.Add(this.label4);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtNombreTipo);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtCodigo);
            this.ribbonPanel1dataFrm.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanel1dataFrm.Size = new System.Drawing.Size(966, 495);
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
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.grdDatos, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.grpOpcionesExportar, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtCodigo, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtNombreTipo, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label4, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label2, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label3, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label5, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.cmbTipoContrato, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.c1CmbTipocontrato, 0);
            // 
            // cgDataControler1
            // 
            this.cgDataControler1.campos = "Codigo|codModalidadContrato,Modalidad|nombreModalidadContrato";
            this.cgDataControler1.dataTabla = this.dsSpx1.modalidadContrato;
            this.cgDataControler1.EstadoControles = false;
            this.cgDataControler1.EventosEncendidos = true;
            // 
            // grpOpcionesExportar
            // 
            this.grpOpcionesExportar.Location = new System.Drawing.Point(473, 344);
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
            // chkAbrirDespuesdeExportar
            // 
            // 
            // 
            // 
            this.chkAbrirDespuesdeExportar.BackgroundStyle.Class = "";
            this.chkAbrirDespuesdeExportar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // grdDatos
            // 
            this.grdDatos.DataMember = "modalidadContrato";
            this.grdDatos.DataSource = this.dsSpx1;
            this.grdDatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDatos.Images"))));
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75D;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(471, 234);
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(5, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "modalidadContrato.desccripcion", true));
            this.txtDescripcion.Location = new System.Drawing.Point(149, 206);
            this.txtDescripcion.MaxLength = 1073741823;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(307, 176);
            this.txtDescripcion.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(5, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Codigo Modalidad Contrato*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(5, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tipo Contrato*";
            // 
            // txtNombreTipo
            // 
            this.txtNombreTipo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "modalidadContrato.nombreModalidadContrato", true));
            this.txtNombreTipo.Location = new System.Drawing.Point(149, 173);
            this.txtNombreTipo.MaxLength = 30;
            this.txtNombreTipo.Name = "txtNombreTipo";
            this.txtNombreTipo.ReadOnly = true;
            this.txtNombreTipo.Size = new System.Drawing.Size(307, 20);
            this.txtNombreTipo.TabIndex = 14;
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "modalidadContrato.codModalidadContrato", true));
            this.txtCodigo.Location = new System.Drawing.Point(149, 140);
            this.txtCodigo.MaxLength = 5;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(183, 20);
            this.txtCodigo.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(5, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Modalidad Contrato*";
            // 
            // cmbTipoContrato
            // 
            this.cmbTipoContrato.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsSpx1, "modalidadContrato.codTipoContrato", true));
            this.cmbTipoContrato.DataSource = this.dsSpx1;
            this.cmbTipoContrato.DisplayMember = "tipoContrato.nombreTipoContrato";
            this.cmbTipoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoContrato.FormattingEnabled = true;
            this.cmbTipoContrato.Location = new System.Drawing.Point(149, 110);
            this.cmbTipoContrato.MaxLength = 5;
            this.cmbTipoContrato.Name = "cmbTipoContrato";
            this.cmbTipoContrato.Size = new System.Drawing.Size(307, 21);
            this.cmbTipoContrato.TabIndex = 17;
            this.cmbTipoContrato.ValueMember = "tipoContrato.codTipoContrato";
            // 
            // c1CmbTipocontrato
            // 
            this.c1CmbTipocontrato.AllowColMove = true;
            this.c1CmbTipocontrato.AllowColSelect = true;
            this.c1CmbTipocontrato.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows;
            this.c1CmbTipocontrato.AlternatingRows = false;
            this.c1CmbTipocontrato.CaptionStyle = style1;
            this.c1CmbTipocontrato.ColumnCaptionHeight = 17;
            this.c1CmbTipocontrato.ColumnFooterHeight = 17;
            this.c1CmbTipocontrato.DataMember = "tipoContrato";
            this.c1CmbTipocontrato.DataSource = this.dsSpx2;
            this.c1CmbTipocontrato.DisplayMember = "tipoContrato.nombreTipoContrato";
            this.c1CmbTipocontrato.EvenRowStyle = style2;
            this.c1CmbTipocontrato.FetchRowStyles = false;
            this.c1CmbTipocontrato.FooterStyle = style3;
            this.c1CmbTipocontrato.HeadingStyle = style4;
            this.c1CmbTipocontrato.HighLightRowStyle = style5;
            this.c1CmbTipocontrato.Images.Add(((System.Drawing.Image)(resources.GetObject("c1CmbTipocontrato.Images"))));
            this.c1CmbTipocontrato.Location = new System.Drawing.Point(399, 275);
            this.c1CmbTipocontrato.Name = "c1CmbTipocontrato";
            this.c1CmbTipocontrato.OddRowStyle = style6;
            this.c1CmbTipocontrato.RecordSelectorStyle = style7;
            this.c1CmbTipocontrato.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.c1CmbTipocontrato.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
            this.c1CmbTipocontrato.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1CmbTipocontrato.ScrollTips = false;
            this.c1CmbTipocontrato.Size = new System.Drawing.Size(100, 150);
            this.c1CmbTipocontrato.Style = style8;
            this.c1CmbTipocontrato.TabIndex = 18;
            this.c1CmbTipocontrato.TabStop = false;
            this.c1CmbTipocontrato.Text = "c1TrueDBDropdown1";
            this.c1CmbTipocontrato.ValueMember = "tipoContrato.codTipoContrato";
            this.c1CmbTipocontrato.ValueTranslate = true;
            this.c1CmbTipocontrato.Visible = false;
            this.c1CmbTipocontrato.PropBag = resources.GetString("c1CmbTipocontrato.PropBag");
            // 
            // dsSpx2
            // 
            this.dsSpx2.DataSetName = "dsSpx";
            this.dsSpx2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modalidadContratoTableAdapter1
            // 
            this.modalidadContratoTableAdapter1.ClearBeforeFill = true;
            // 
            // frmModalidadContrato
            // 
            this.ClientSize = new System.Drawing.Size(976, 556);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModalidadContrato";
            this.Text = "Modalidad Contratos - Nombre Software";
            this.tituloTabla = "Modalidad Contratos";
            this.Load += new System.EventHandler(this.frmModalidadContrato_Load);
            this.ribbonControlDataFrm.ResumeLayout(false);
            this.ribbonControlDataFrm.PerformLayout();
            this.ribbonPanel1dataFrm.ResumeLayout(false);
            this.ribbonPanel1dataFrm.PerformLayout();
            this.grpOpcionesExportar.ResumeLayout(false);
            this.grpOpcionesExportar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CmbTipocontrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.tipoContratoTableAdapter tipoContratoTableAdapter1;
        private System.Windows.Forms.ComboBox cmbTipoContrato;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreTipo;
        private System.Windows.Forms.TextBox txtCodigo;
        private C1.Win.C1TrueDBGrid.C1TrueDBDropdown c1CmbTipocontrato;
        private SPControladoraDatos.dsSpx dsSpx2;
        private SPControladoraDatos.dsSpxTableAdapters.modalidadContratoTableAdapter modalidadContratoTableAdapter1;
    }
}
