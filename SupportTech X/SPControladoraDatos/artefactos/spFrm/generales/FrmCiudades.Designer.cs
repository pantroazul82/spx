namespace SpFrm.generales
{
    partial class FrmCiudades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCiudades));
            C1.Win.C1TrueDBGrid.Style style25 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style26 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style27 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style28 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style29 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style30 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style31 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style32 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style17 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style18 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style19 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style20 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style21 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style22 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style23 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style24 = new C1.Win.C1TrueDBGrid.Style();
            this.ciudadesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ciudadesTableAdapter();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.paisesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.paisesTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.c1Paises = new C1.Win.C1TrueDBGrid.C1TrueDBDropdown();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.departamentoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.departamentoTableAdapter();
            this.c1Departamento = new C1.Win.C1TrueDBGrid.C1TrueDBDropdown();
            this.dsSpx2 = new SPControladoraDatos.dsSpx();
            this.grdDatos.BeginInit();
            this.ribbonControlDataFrm.SuspendLayout();
            this.ribbonPanel1dataFrm.SuspendLayout();
            this.ribbonPanel2dataFrm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Paises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Departamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx2)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDatos
            // 
            this.grdDatos.DataMember = "ciudades";
            this.grdDatos.DataSource = this.dsSpx1;
            this.grdDatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDatos.Images"))));
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(978, 376);
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
            // 
            // ribbonControlDataFrm
            // 
            this.ribbonControlDataFrm.Size = new System.Drawing.Size(992, 567);
            this.ribbonControlDataFrm.Controls.SetChildIndex(this.ribbonPanel2dataFrm, 0);
            this.ribbonControlDataFrm.Controls.SetChildIndex(this.ribbonPanel1dataFrm, 0);
            // 
            // ribbonPanel1dataFrm
            // 
            this.ribbonPanel1dataFrm.Controls.Add(this.cmbDepartamento);
            this.ribbonPanel1dataFrm.Controls.Add(this.label1);
            this.ribbonPanel1dataFrm.Controls.Add(this.label7);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtNombre);
            this.ribbonPanel1dataFrm.Controls.Add(this.cmbPais);
            this.ribbonPanel1dataFrm.Controls.Add(this.label6);
            this.ribbonPanel1dataFrm.Controls.Add(this.label5);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtCiudad);
            this.ribbonPanel1dataFrm.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel1dataFrm.Size = new System.Drawing.Size(992, 510);
            this.ribbonPanel1dataFrm.Visible = true;
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtCiudad, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label5, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label6, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.cmbPais, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtNombre, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label7, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label1, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.cmbDepartamento, 0);
            // 
            // cgDataControler1
            // 
            this.cgDataControler1.campos = "codigo Pais|codPais,Codigo Ciudad|codCiudad,Ciudad|nombreCiudad";
            this.cgDataControler1.dataTabla = this.dsSpx1.ciudades;
            this.cgDataControler1.EstadoControles = false;
            this.cgDataControler1.AntesDeAceptar += new CGDataControler.dataControlerEventHandler(this.cgDataControler1_AntesDeAceptar);
            // 
            // ribbonPanel2dataFrm
            // 
            this.ribbonPanel2dataFrm.Controls.Add(this.c1Departamento);
            this.ribbonPanel2dataFrm.Controls.Add(this.c1Paises);
            this.ribbonPanel2dataFrm.Size = new System.Drawing.Size(992, 510);
            this.ribbonPanel2dataFrm.Controls.SetChildIndex(this.c1Paises, 0);
            this.ribbonPanel2dataFrm.Controls.SetChildIndex(this.grdDatos, 0);
            this.ribbonPanel2dataFrm.Controls.SetChildIndex(this.c1Departamento, 0);
            // 
            // ciudadesTableAdapter1
            // 
            this.ciudadesTableAdapter1.ClearBeforeFill = true;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(12, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "*Nombre Ciudad:";
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "ciudades.nombreCiudad", true));
            this.txtNombre.Location = new System.Drawing.Point(120, 217);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(181, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // cmbPais
            // 
            this.cmbPais.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbPais.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPais.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsSpx1, "ciudades.codPais", true));
            this.cmbPais.DataSource = this.dsSpx1;
            this.cmbPais.DisplayMember = "paises.nombrePais";
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(120, 113);
            this.cmbPais.MaxLength = 5;
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(181, 21);
            this.cmbPais.TabIndex = 6;
            this.cmbPais.ValueMember = "paises.codPais";
            this.cmbPais.SelectedIndexChanged += new System.EventHandler(this.cmbPais_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(12, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "*Pais:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(12, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "*Codigo Ciudad:";
            // 
            // txtCiudad
            // 
            this.txtCiudad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "ciudades.codCiudad", true));
            this.txtCiudad.Location = new System.Drawing.Point(120, 180);
            this.txtCiudad.MaxLength = 5;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.ReadOnly = true;
            this.txtCiudad.Size = new System.Drawing.Size(181, 20);
            this.txtCiudad.TabIndex = 7;
            // 
            // c1Paises
            // 
            this.c1Paises.AllowColMove = true;
            this.c1Paises.AllowColSelect = true;
            this.c1Paises.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows;
            this.c1Paises.AlternatingRows = false;
            this.c1Paises.CaptionStyle = style25;
            this.c1Paises.ColumnCaptionHeight = 17;
            this.c1Paises.ColumnFooterHeight = 17;
            this.c1Paises.ColumnHeaders = false;
            this.c1Paises.DataMember = "paises";
            this.c1Paises.DataSource = this.dsSpx1;
            this.c1Paises.DisplayMember = "paises.nombrePais";
            this.c1Paises.EvenRowStyle = style26;
            this.c1Paises.FetchRowStyles = false;
            this.c1Paises.FooterStyle = style27;
            this.c1Paises.HeadingStyle = style28;
            this.c1Paises.HighLightRowStyle = style29;
            this.c1Paises.Images.Add(((System.Drawing.Image)(resources.GetObject("c1Paises.Images"))));
            this.c1Paises.Location = new System.Drawing.Point(568, 42);
            this.c1Paises.Name = "c1Paises";
            this.c1Paises.OddRowStyle = style30;
            this.c1Paises.RecordSelectorStyle = style31;
            this.c1Paises.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.c1Paises.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
            this.c1Paises.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1Paises.ScrollTips = false;
            this.c1Paises.Size = new System.Drawing.Size(190, 76);
            this.c1Paises.Style = style32;
            this.c1Paises.TabIndex = 9;
            this.c1Paises.TabStop = false;
            this.c1Paises.Text = "c1TrueDBDropdown1";
            this.c1Paises.ValueMember = "paises.codPais";
            this.c1Paises.ValueTranslate = true;
            this.c1Paises.Visible = false;
            this.c1Paises.PropBag = resources.GetString("c1Paises.PropBag");
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsSpx1, "ciudades.codDepartamento", true));
            this.cmbDepartamento.DataSource = this.dsSpx2;
            this.cmbDepartamento.DisplayMember = "departamento.NombreDepartamento";
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(120, 145);
            this.cmbDepartamento.MaxLength = 5;
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(181, 21);
            this.cmbDepartamento.TabIndex = 12;
            this.cmbDepartamento.ValueMember = "departamento.codDepartamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "*Departamento:";
            // 
            // departamentoTableAdapter1
            // 
            this.departamentoTableAdapter1.ClearBeforeFill = true;
            // 
            // c1Departamento
            // 
            this.c1Departamento.AllowColMove = true;
            this.c1Departamento.AllowColSelect = true;
            this.c1Departamento.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows;
            this.c1Departamento.AlternatingRows = false;
            this.c1Departamento.CaptionStyle = style17;
            this.c1Departamento.ColumnCaptionHeight = 17;
            this.c1Departamento.ColumnFooterHeight = 17;
            this.c1Departamento.ColumnHeaders = false;
            this.c1Departamento.DataMember = "paises.FK_departamento_paises";
            this.c1Departamento.DataSource = this.dsSpx1;
            this.c1Departamento.DisplayMember = "paises.FK_departamento_paises.NombreDepartamento";
            this.c1Departamento.EvenRowStyle = style18;
            this.c1Departamento.FetchRowStyles = false;
            this.c1Departamento.FooterStyle = style19;
            this.c1Departamento.HeadingStyle = style20;
            this.c1Departamento.HighLightRowStyle = style21;
            this.c1Departamento.Images.Add(((System.Drawing.Image)(resources.GetObject("c1Departamento.Images"))));
            this.c1Departamento.Location = new System.Drawing.Point(775, 42);
            this.c1Departamento.Name = "c1Departamento";
            this.c1Departamento.OddRowStyle = style22;
            this.c1Departamento.RecordSelectorStyle = style23;
            this.c1Departamento.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.c1Departamento.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
            this.c1Departamento.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1Departamento.ScrollTips = false;
            this.c1Departamento.Size = new System.Drawing.Size(190, 76);
            this.c1Departamento.Style = style24;
            this.c1Departamento.TabIndex = 10;
            this.c1Departamento.TabStop = false;
            this.c1Departamento.Text = "c1TrueDBDropdown1";
            this.c1Departamento.ValueMember = "paises.FK_departamento_paises.codDepartamento";
            this.c1Departamento.ValueTranslate = true;
            this.c1Departamento.Visible = false;
            this.c1Departamento.PropBag = resources.GetString("c1Departamento.PropBag");
            // 
            // dsSpx2
            // 
            this.dsSpx2.DataSetName = "dsSpx";
            this.dsSpx2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmCiudades
            // 
            this.ClientSize = new System.Drawing.Size(1000, 570);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCiudades";
            this.Text = "Ciudades - Nombre Software";
            this.tituloTabla = "Ciudades";
            this.Load += new System.EventHandler(this.FrmCiudades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ribbonControlDataFrm.ResumeLayout(false);
            this.ribbonControlDataFrm.PerformLayout();
            this.ribbonPanel1dataFrm.ResumeLayout(false);
            this.ribbonPanel1dataFrm.PerformLayout();
            this.ribbonPanel2dataFrm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Paises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Departamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SPControladoraDatos.dsSpxTableAdapters.ciudadesTableAdapter ciudadesTableAdapter1;
        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.paisesTableAdapter paisesTableAdapter1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCiudad;
        private C1.Win.C1TrueDBGrid.C1TrueDBDropdown c1Paises;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label label1;
        private SPControladoraDatos.dsSpxTableAdapters.departamentoTableAdapter departamentoTableAdapter1;
        private C1.Win.C1TrueDBGrid.C1TrueDBDropdown c1Departamento;
        private SPControladoraDatos.dsSpx dsSpx2;
    }
}
