namespace SpFrm.generales
{
    partial class frmDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartamento));
            C1.Win.C1TrueDBGrid.Style style9 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style10 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style11 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style12 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style13 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style14 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style15 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style16 = new C1.Win.C1TrueDBGrid.Style();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.paisesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.paisesTableAdapter();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.txtCodDepartamento = new System.Windows.Forms.TextBox();
            this.departamentoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.departamentoTableAdapter();
            this.c1TrueDBDropdown1 = new C1.Win.C1TrueDBGrid.C1TrueDBDropdown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grdDatos.BeginInit();
            this.ribbonControlDataFrm.SuspendLayout();
            this.ribbonPanel1dataFrm.SuspendLayout();
            this.ribbonPanel2dataFrm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBDropdown1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDatos
            // 
            this.grdDatos.DataMember = "departamento";
            this.grdDatos.DataSource = this.dsSpx1;
            this.grdDatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDatos.Images"))));
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(954, 362);
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
            // 
            // ribbonControlDataFrm
            // 
            this.ribbonControlDataFrm.Size = new System.Drawing.Size(968, 553);
            this.ribbonControlDataFrm.Controls.SetChildIndex(this.ribbonPanel2dataFrm, 0);
            this.ribbonControlDataFrm.Controls.SetChildIndex(this.ribbonPanel1dataFrm, 0);
            // 
            // ribbonPanel1dataFrm
            // 
            this.ribbonPanel1dataFrm.Controls.Add(this.label7);
            this.ribbonPanel1dataFrm.Controls.Add(this.label6);
            this.ribbonPanel1dataFrm.Controls.Add(this.label5);
            this.ribbonPanel1dataFrm.Controls.Add(this.cmbPais);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtNombre);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtCodDepartamento);
            this.ribbonPanel1dataFrm.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel1dataFrm.Size = new System.Drawing.Size(968, 496);
            this.ribbonPanel1dataFrm.Visible = true;
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtCodDepartamento, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtNombre, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.cmbPais, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label5, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label6, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label7, 0);
            // 
            // cgDataControler1
            // 
            this.cgDataControler1.campos = "codigo Pais|codPais,Codigo Departamento|codDepartamento,Departamento|NombreDepart" +
                "amento";
            this.cgDataControler1.dataTabla = this.dsSpx1.departamento;
            this.cgDataControler1.EstadoControles = false;
            // 
            // ribbonPanel2dataFrm
            // 
            this.ribbonPanel2dataFrm.Controls.Add(this.c1TrueDBDropdown1);
            this.ribbonPanel2dataFrm.Size = new System.Drawing.Size(968, 496);
            this.ribbonPanel2dataFrm.Controls.SetChildIndex(this.c1TrueDBDropdown1, 0);
            this.ribbonPanel2dataFrm.Controls.SetChildIndex(this.grdDatos, 0);
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paisesTableAdapter1
            // 
            this.paisesTableAdapter1.ClearBeforeFill = true;
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "departamento.NombreDepartamento", true));
            this.txtNombre.Location = new System.Drawing.Point(137, 194);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(181, 20);
            this.txtNombre.TabIndex = 14;
            // 
            // cmbPais
            // 
            this.cmbPais.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbPais.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPais.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsSpx1, "departamento.codPais", true));
            this.cmbPais.DataSource = this.dsSpx1;
            this.cmbPais.DisplayMember = "paises.nombrePais";
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(137, 115);
            this.cmbPais.MaxLength = 5;
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(181, 21);
            this.cmbPais.TabIndex = 12;
            this.cmbPais.ValueMember = "paises.codPais";
            // 
            // txtCodDepartamento
            // 
            this.txtCodDepartamento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "departamento.codDepartamento", true));
            this.txtCodDepartamento.Location = new System.Drawing.Point(137, 157);
            this.txtCodDepartamento.MaxLength = 5;
            this.txtCodDepartamento.Name = "txtCodDepartamento";
            this.txtCodDepartamento.ReadOnly = true;
            this.txtCodDepartamento.Size = new System.Drawing.Size(181, 20);
            this.txtCodDepartamento.TabIndex = 13;
            // 
            // departamentoTableAdapter1
            // 
            this.departamentoTableAdapter1.ClearBeforeFill = true;
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
            this.c1TrueDBDropdown1.ColumnHeaders = false;
            this.c1TrueDBDropdown1.DataMember = "paises";
            this.c1TrueDBDropdown1.DataSource = this.dsSpx1;
            this.c1TrueDBDropdown1.DisplayMember = "paises.nombrePais";
            this.c1TrueDBDropdown1.EvenRowStyle = style10;
            this.c1TrueDBDropdown1.FetchRowStyles = false;
            this.c1TrueDBDropdown1.FooterStyle = style11;
            this.c1TrueDBDropdown1.HeadingStyle = style12;
            this.c1TrueDBDropdown1.HighLightRowStyle = style13;
            this.c1TrueDBDropdown1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBDropdown1.Images"))));
            this.c1TrueDBDropdown1.Location = new System.Drawing.Point(752, 48);
            this.c1TrueDBDropdown1.Name = "c1TrueDBDropdown1";
            this.c1TrueDBDropdown1.OddRowStyle = style14;
            this.c1TrueDBDropdown1.RecordSelectorStyle = style15;
            this.c1TrueDBDropdown1.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.c1TrueDBDropdown1.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
            this.c1TrueDBDropdown1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1TrueDBDropdown1.ScrollTips = false;
            this.c1TrueDBDropdown1.Size = new System.Drawing.Size(142, 70);
            this.c1TrueDBDropdown1.Style = style16;
            this.c1TrueDBDropdown1.TabIndex = 9;
            this.c1TrueDBDropdown1.TabStop = false;
            this.c1TrueDBDropdown1.Text = "c1TrueDBDropdown1";
            this.c1TrueDBDropdown1.ValueMember = "paises.codPais";
            this.c1TrueDBDropdown1.ValueTranslate = true;
            this.c1TrueDBDropdown1.Visible = false;
            this.c1TrueDBDropdown1.PropBag = resources.GetString("c1TrueDBDropdown1.PropBag");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(10, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "*Nombre Departamento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(10, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "*Pais:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(10, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "*Codigo Departamento:";
            // 
            // frmDepartamento
            // 
            this.ClientSize = new System.Drawing.Size(976, 556);
            this.Name = "frmDepartamento";
            this.Text = "Departamento - Nombre Software";
            this.tituloTabla = "Departamento";
            this.Load += new System.EventHandler(this.frmDepartamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ribbonControlDataFrm.ResumeLayout(false);
            this.ribbonControlDataFrm.PerformLayout();
            this.ribbonPanel1dataFrm.ResumeLayout(false);
            this.ribbonPanel1dataFrm.PerformLayout();
            this.ribbonPanel2dataFrm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBDropdown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.paisesTableAdapter paisesTableAdapter1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.TextBox txtCodDepartamento;
        private SPControladoraDatos.dsSpxTableAdapters.departamentoTableAdapter departamentoTableAdapter1;
        private C1.Win.C1TrueDBGrid.C1TrueDBDropdown c1TrueDBDropdown1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}
