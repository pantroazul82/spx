namespace spProcesos.contratos
{
    partial class frmTipoContratos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoContratos));
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.tipoContratoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.tipoContratoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombreTipo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.chkDemantenimiento = new System.Windows.Forms.CheckBox();
            this.chkContratoConsumo = new System.Windows.Forms.CheckBox();
            this.ribbonControlDataFrm.SuspendLayout();
            this.ribbonPanel1dataFrm.SuspendLayout();
            this.ribbonPanel2dataFrm.SuspendLayout();
            this.grdDatos.BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControlDataFrm
            // 
            this.ribbonControlDataFrm.Size = new System.Drawing.Size(968, 556);
            this.ribbonControlDataFrm.Controls.SetChildIndex(this.ribbonPanel2dataFrm, 0);
            this.ribbonControlDataFrm.Controls.SetChildIndex(this.ribbonPanel1dataFrm, 0);
            // 
            // ribbonPanel1dataFrm
            // 
            this.ribbonPanel1dataFrm.Controls.Add(this.chkContratoConsumo);
            this.ribbonPanel1dataFrm.Controls.Add(this.chkDemantenimiento);
            this.ribbonPanel1dataFrm.Controls.Add(this.label3);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtDescripcion);
            this.ribbonPanel1dataFrm.Controls.Add(this.label1);
            this.ribbonPanel1dataFrm.Controls.Add(this.label2);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtNombreTipo);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtCodigo);
            this.ribbonPanel1dataFrm.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel1dataFrm.Size = new System.Drawing.Size(968, 499);
            this.ribbonPanel1dataFrm.Visible = true;
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtCodigo, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtNombreTipo, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label2, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label1, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label3, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.chkDemantenimiento, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.chkContratoConsumo, 0);
            // 
            // cgDataControler1
            // 
            this.cgDataControler1.campos = "Codigo |codTipoContrato,Tipo Contrato|nombreTipoContrato,Descripcion|descripcion";
            this.cgDataControler1.dataTabla = this.dsSpx1.tipoContrato;
            this.cgDataControler1.EstadoControles = false;
            // 
            // ribbonPanel2dataFrm
            // 
            this.ribbonPanel2dataFrm.Size = new System.Drawing.Size(968, 499);
            // 
            // grdDatos
            // 
            this.grdDatos.DataMember = "tipoContrato";
            this.grdDatos.DataSource = this.dsSpx1;
            this.grdDatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDatos.Images"))));
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(954, 372);
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
            // tipoContratoTableAdapter1
            // 
            this.tipoContratoTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(11, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo Tipo Contrato*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(11, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo Contrato*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(14, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripcion";
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "tipoContrato.codTipoContrato", true));
            this.txtCodigo.Location = new System.Drawing.Point(149, 115);
            this.txtCodigo.MaxLength = 5;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(183, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // txtNombreTipo
            // 
            this.txtNombreTipo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "tipoContrato.nombreTipoContrato", true));
            this.txtNombreTipo.Location = new System.Drawing.Point(149, 148);
            this.txtNombreTipo.MaxLength = 30;
            this.txtNombreTipo.Name = "txtNombreTipo";
            this.txtNombreTipo.ReadOnly = true;
            this.txtNombreTipo.Size = new System.Drawing.Size(365, 20);
            this.txtNombreTipo.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "tipoContrato.descripcion", true));
            this.txtDescripcion.Location = new System.Drawing.Point(149, 181);
            this.txtDescripcion.MaxLength = 1073741823;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(365, 120);
            this.txtDescripcion.TabIndex = 7;
            // 
            // chkDemantenimiento
            // 
            this.chkDemantenimiento.AutoSize = true;
            this.chkDemantenimiento.BackColor = System.Drawing.Color.Transparent;
            this.chkDemantenimiento.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsSpx1, "tipoContrato.deMantenimiento", true));
            this.chkDemantenimiento.Location = new System.Drawing.Point(570, 113);
            this.chkDemantenimiento.Name = "chkDemantenimiento";
            this.chkDemantenimiento.Size = new System.Drawing.Size(153, 17);
            this.chkDemantenimiento.TabIndex = 8;
            this.chkDemantenimiento.Text = "Contrato de Mantenimiento";
            this.chkDemantenimiento.UseVisualStyleBackColor = false;
            // 
            // chkContratoConsumo
            // 
            this.chkContratoConsumo.AutoSize = true;
            this.chkContratoConsumo.BackColor = System.Drawing.Color.Transparent;
            this.chkContratoConsumo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsSpx1, "tipoContrato.deConsumo", true));
            this.chkContratoConsumo.Location = new System.Drawing.Point(570, 151);
            this.chkContratoConsumo.Name = "chkContratoConsumo";
            this.chkContratoConsumo.Size = new System.Drawing.Size(128, 17);
            this.chkContratoConsumo.TabIndex = 9;
            this.chkContratoConsumo.Text = "Contrato de Consumo";
            this.chkContratoConsumo.UseVisualStyleBackColor = false;
            // 
            // frmTipoContratos
            // 
            this.ClientSize = new System.Drawing.Size(976, 559);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTipoContratos";
            this.Text = "Tipos de Contrato - Nombre Software";
            this.tituloTabla = "Tipos de Contrato";
            this.Load += new System.EventHandler(this.frmTipoContratos_Load);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreTipo;
        private System.Windows.Forms.TextBox txtCodigo;
        private SPControladoraDatos.dsSpxTableAdapters.tipoContratoTableAdapter tipoContratoTableAdapter1;
        private System.Windows.Forms.CheckBox chkContratoConsumo;
        private System.Windows.Forms.CheckBox chkDemantenimiento;
    }
}
