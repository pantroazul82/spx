namespace SpFrm.generales
{
    partial class frmActividadesxModelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActividadesxModelo));
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.fabricanteTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.fabricanteTableAdapter();
            this.modelosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.txtCodActividad = new System.Windows.Forms.TextBox();
            this.txtActividad = new System.Windows.Forms.TextBox();
            this.actividadesxModeloTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ActividadesxModeloTableAdapter();
            this.ribbonControlDataFrm.SuspendLayout();
            this.ribbonPanel1dataFrm.SuspendLayout();
            this.ribbonPanel2dataFrm.SuspendLayout();
            this.grdDatos.BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControlDataFrm
            // 
            this.ribbonControlDataFrm.Size = new System.Drawing.Size(968, 553);
            this.ribbonControlDataFrm.Controls.SetChildIndex(this.ribbonPanel2dataFrm, 0);
            this.ribbonControlDataFrm.Controls.SetChildIndex(this.ribbonPanel1dataFrm, 0);
            // 
            // ribbonPanel1dataFrm
            // 
            this.ribbonPanel1dataFrm.Controls.Add(this.txtActividad);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtCodActividad);
            this.ribbonPanel1dataFrm.Controls.Add(this.cmbModelo);
            this.ribbonPanel1dataFrm.Controls.Add(this.cmbFabricante);
            this.ribbonPanel1dataFrm.Controls.Add(this.label4);
            this.ribbonPanel1dataFrm.Controls.Add(this.label3);
            this.ribbonPanel1dataFrm.Controls.Add(this.label2);
            this.ribbonPanel1dataFrm.Controls.Add(this.label1);
            this.ribbonPanel1dataFrm.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel1dataFrm.Size = new System.Drawing.Size(968, 496);
            this.ribbonPanel1dataFrm.Visible = true;
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label1, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label2, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label3, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label4, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.cmbFabricante, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.cmbModelo, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtCodActividad, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtActividad, 0);
            // 
            // cgDataControler1
            // 
            this.cgDataControler1.campos = "Cod Actividad|codActividad";
            this.cgDataControler1.dataTabla = this.dsSpx1.ActividadesxModelo;
            this.cgDataControler1.EstadoControles = false;
            this.cgDataControler1.DespuesDeNuevo += new CGDataControler.dataControlerEventHandler(this.cgDataControler1_DespuesDeNuevo);
            this.cgDataControler1.AntesDeAceptar += new CGDataControler.dataControlerEventHandler(this.cgDataControler1_AntesDeAceptar);
            // 
            // ribbonPanel2dataFrm
            // 
            this.ribbonPanel2dataFrm.Size = new System.Drawing.Size(968, 496);
            // 
            // grdDatos
            // 
            this.grdDatos.DataMember = "ActividadesxModelo";
            this.grdDatos.DataSource = this.dsSpx1;
            this.grdDatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDatos.Images"))));
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(954, 311);
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
            // 
            // txtTotalRegistros
            // 
            this.txtTotalRegistros.Text = "0";
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fabricanteTableAdapter1
            // 
            this.fabricanteTableAdapter1.ClearBeforeFill = true;
            // 
            // modelosTableAdapter1
            // 
            this.modelosTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(23, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fabricante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(23, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(23, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cod Actividad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(24, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Actividad";
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsSpx1, "ActividadesxModelo.codFabricante", true));
            this.cmbFabricante.DataSource = this.dsSpx1;
            this.cmbFabricante.DisplayMember = "fabricante.nombre_fabricante";
            this.cmbFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(111, 133);
            this.cmbFabricante.MaxLength = 5;
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(266, 21);
            this.cmbFabricante.TabIndex = 6;
            this.cmbFabricante.ValueMember = "fabricante.codFabricante";
            this.cmbFabricante.SelectedIndexChanged += new System.EventHandler(this.cmbFabricante_SelectedIndexChanged);
            // 
            // cmbModelo
            // 
            this.cmbModelo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsSpx1, "ActividadesxModelo.codModelo", true));
            this.cmbModelo.DataSource = this.dsSpx1;
            this.cmbModelo.DisplayMember = "Modelos.NombreModelo";
            this.cmbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Location = new System.Drawing.Point(111, 168);
            this.cmbModelo.MaxLength = 5;
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(266, 21);
            this.cmbModelo.TabIndex = 7;
            this.cmbModelo.ValueMember = "Modelos.codModelo";
            this.cmbModelo.SelectedIndexChanged += new System.EventHandler(this.cmbModelo_SelectedIndexChanged);
            // 
            // txtCodActividad
            // 
            this.txtCodActividad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "ActividadesxModelo.codActividad", true));
            this.txtCodActividad.Location = new System.Drawing.Point(111, 203);
            this.txtCodActividad.Name = "txtCodActividad";
            this.txtCodActividad.ReadOnly = true;
            this.txtCodActividad.Size = new System.Drawing.Size(41, 20);
            this.txtCodActividad.TabIndex = 8;
            // 
            // txtActividad
            // 
            this.txtActividad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "ActividadesxModelo.descripcion", true));
            this.txtActividad.Location = new System.Drawing.Point(111, 238);
            this.txtActividad.MaxLength = 2147483647;
            this.txtActividad.Multiline = true;
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.ReadOnly = true;
            this.txtActividad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtActividad.Size = new System.Drawing.Size(380, 102);
            this.txtActividad.TabIndex = 9;
            // 
            // actividadesxModeloTableAdapter1
            // 
            this.actividadesxModeloTableAdapter1.ClearBeforeFill = true;
            // 
            // frmActividadesxModelo
            // 
            this.ClientSize = new System.Drawing.Size(976, 556);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmActividadesxModelo";
            this.Text = "Actividades Por Modelo - Nombre Software";
            this.tituloTabla = "Actividades Por Modelo";
            this.Load += new System.EventHandler(this.frmActividadesxModelo_Load);
            this.ribbonControlDataFrm.ResumeLayout(false);
            this.ribbonControlDataFrm.PerformLayout();
            this.ribbonPanel1dataFrm.ResumeLayout(false);
            this.ribbonPanel1dataFrm.PerformLayout();
            this.ribbonPanel2dataFrm.ResumeLayout(false);
            this.ribbonPanel2dataFrm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.fabricanteTableAdapter fabricanteTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter modelosTableAdapter1;
        private System.Windows.Forms.TextBox txtActividad;
        private System.Windows.Forms.TextBox txtCodActividad;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private SPControladoraDatos.dsSpxTableAdapters.ActividadesxModeloTableAdapter actividadesxModeloTableAdapter1;
    }
}
