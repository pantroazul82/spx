namespace SpFrm.generales
{
    partial class frmSubTipoEquipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubTipoEquipo));
            C1.Win.C1TrueDBGrid.Style style1 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style2 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style3 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style4 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style5 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style6 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style7 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style8 = new C1.Win.C1TrueDBGrid.Style();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.tipoEquipoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.tipoEquipoTableAdapter();
            this.subTipoEquipoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.subTipoEquipoTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipoEquipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtSubTipoEquipo = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.c1TrueDBDropdown1 = new C1.Win.C1TrueDBGrid.C1TrueDBDropdown();
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
            this.grdDatos.DataMember = "subTipoEquipo";
            this.grdDatos.DataSource = this.dsSpx1;
            this.grdDatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDatos.Images"))));
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(978, 325);
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
            this.ribbonPanel1dataFrm.Controls.Add(this.textBox1);
            this.ribbonPanel1dataFrm.Controls.Add(this.label5);
            this.ribbonPanel1dataFrm.Controls.Add(this.label7);
            this.ribbonPanel1dataFrm.Controls.Add(this.cmbTipoEquipo);
            this.ribbonPanel1dataFrm.Controls.Add(this.label6);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtCodigo);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtSubTipoEquipo);
            this.ribbonPanel1dataFrm.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel1dataFrm.Size = new System.Drawing.Size(992, 510);
            this.ribbonPanel1dataFrm.Visible = true;
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtSubTipoEquipo, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtCodigo, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label6, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.cmbTipoEquipo, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label7, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label5, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.textBox1, 0);
            // 
            // cgDataControler1
            // 
            this.cgDataControler1.campos = "Tipo Equipo|codTipoEquipo,Codigo SubTipo|codSubtipoEquipo,Nombre SubTipo|nombreSu" +
                "bTipo";
            this.cgDataControler1.dataTabla = this.dsSpx1.subTipoEquipo;
            this.cgDataControler1.EstadoControles = false;
            // 
            // ribbonPanel2dataFrm
            // 
            this.ribbonPanel2dataFrm.Controls.Add(this.c1TrueDBDropdown1);
            this.ribbonPanel2dataFrm.Size = new System.Drawing.Size(992, 510);
            this.ribbonPanel2dataFrm.Controls.SetChildIndex(this.c1TrueDBDropdown1, 0);
            this.ribbonPanel2dataFrm.Controls.SetChildIndex(this.grdDatos, 0);
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoEquipoTableAdapter1
            // 
            this.tipoEquipoTableAdapter1.ClearBeforeFill = true;
            // 
            // subTipoEquipoTableAdapter1
            // 
            this.subTipoEquipoTableAdapter1.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "*Tipo Equipo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(12, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "*SubTipo Equipo:";
            // 
            // cmbTipoEquipo
            // 
            this.cmbTipoEquipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTipoEquipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipoEquipo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsSpx1, "subTipoEquipo.codTipoEquipo", true));
            this.cmbTipoEquipo.DataSource = this.dsSpx1;
            this.cmbTipoEquipo.DisplayMember = "tipoEquipo.nombreTipoEquipo";
            this.cmbTipoEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoEquipo.FormattingEnabled = true;
            this.cmbTipoEquipo.Location = new System.Drawing.Point(120, 113);
            this.cmbTipoEquipo.MaxLength = 5;
            this.cmbTipoEquipo.Name = "cmbTipoEquipo";
            this.cmbTipoEquipo.Size = new System.Drawing.Size(233, 21);
            this.cmbTipoEquipo.TabIndex = 7;
            this.cmbTipoEquipo.ValueMember = "tipoEquipo.codTipoEquipo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(12, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "* Codigo SubTipo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "subTipoEquipo.codSubtipoEquipo", true));
            this.txtCodigo.Location = new System.Drawing.Point(120, 151);
            this.txtCodigo.MaxLength = 5;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(132, 20);
            this.txtCodigo.TabIndex = 8;
            // 
            // txtSubTipoEquipo
            // 
            this.txtSubTipoEquipo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "subTipoEquipo.nombreSubTipo", true));
            this.txtSubTipoEquipo.Location = new System.Drawing.Point(120, 187);
            this.txtSubTipoEquipo.MaxLength = 30;
            this.txtSubTipoEquipo.Name = "txtSubTipoEquipo";
            this.txtSubTipoEquipo.ReadOnly = true;
            this.txtSubTipoEquipo.Size = new System.Drawing.Size(233, 20);
            this.txtSubTipoEquipo.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(410, 113);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(496, 185);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // c1TrueDBDropdown1
            // 
            this.c1TrueDBDropdown1.AllowColMove = true;
            this.c1TrueDBDropdown1.AllowColSelect = true;
            this.c1TrueDBDropdown1.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows;
            this.c1TrueDBDropdown1.AlternatingRows = false;
            this.c1TrueDBDropdown1.CaptionStyle = style1;
            this.c1TrueDBDropdown1.ColumnCaptionHeight = 17;
            this.c1TrueDBDropdown1.ColumnFooterHeight = 17;
            this.c1TrueDBDropdown1.ColumnHeaders = false;
            this.c1TrueDBDropdown1.DataMember = "tipoEquipo";
            this.c1TrueDBDropdown1.DataSource = this.dsSpx1;
            this.c1TrueDBDropdown1.DisplayMember = "tipoEquipo.nombreTipoEquipo";
            this.c1TrueDBDropdown1.EvenRowStyle = style2;
            this.c1TrueDBDropdown1.FetchRowStyles = false;
            this.c1TrueDBDropdown1.FooterStyle = style3;
            this.c1TrueDBDropdown1.HeadingStyle = style4;
            this.c1TrueDBDropdown1.HighLightRowStyle = style5;
            this.c1TrueDBDropdown1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBDropdown1.Images"))));
            this.c1TrueDBDropdown1.Location = new System.Drawing.Point(366, 67);
            this.c1TrueDBDropdown1.Name = "c1TrueDBDropdown1";
            this.c1TrueDBDropdown1.OddRowStyle = style6;
            this.c1TrueDBDropdown1.RecordSelectorStyle = style7;
            this.c1TrueDBDropdown1.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.c1TrueDBDropdown1.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
            this.c1TrueDBDropdown1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1TrueDBDropdown1.ScrollTips = false;
            this.c1TrueDBDropdown1.Size = new System.Drawing.Size(75, 23);
            this.c1TrueDBDropdown1.Style = style8;
            this.c1TrueDBDropdown1.TabIndex = 9;
            this.c1TrueDBDropdown1.TabStop = false;
            this.c1TrueDBDropdown1.Text = "c1TrueDBDropdown1";
            this.c1TrueDBDropdown1.ValueMember = "tipoEquipo.codTipoEquipo";
            this.c1TrueDBDropdown1.ValueTranslate = true;
            this.c1TrueDBDropdown1.Visible = false;
            this.c1TrueDBDropdown1.PropBag = resources.GetString("c1TrueDBDropdown1.PropBag");
            // 
            // frmSubTipoEquipo
            // 
            this.ClientSize = new System.Drawing.Size(1000, 570);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSubTipoEquipo";
            this.Text = "Subtipo Equipos - Nombre Software";
            this.tituloTabla = "Subtipo Equipos";
            this.Load += new System.EventHandler(this.frmSubTipoEquipo_Load);
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
        private SPControladoraDatos.dsSpxTableAdapters.tipoEquipoTableAdapter tipoEquipoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.subTipoEquipoTableAdapter subTipoEquipoTableAdapter1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTipoEquipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtSubTipoEquipo;
        private System.Windows.Forms.TextBox textBox1;
        private C1.Win.C1TrueDBGrid.C1TrueDBDropdown c1TrueDBDropdown1;
    }
}
