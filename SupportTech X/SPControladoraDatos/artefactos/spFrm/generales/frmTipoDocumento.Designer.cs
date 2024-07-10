namespace SpFrm.generales
{
    partial class frmTipoDocumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoDocumento));
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.tipoDocumentoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.tipoDocumentoTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtTipoDocumento = new System.Windows.Forms.TextBox();
            this.txtAbreviatura = new System.Windows.Forms.TextBox();
            this.grdDatos.BeginInit();
            this.ribbonControlDataFrm.SuspendLayout();
            this.ribbonPanel1dataFrm.SuspendLayout();
            this.ribbonPanel2dataFrm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDatos
            // 
            this.grdDatos.DataMember = "tipoDocumento";
            this.grdDatos.DataSource = this.dsSpx1;
            this.grdDatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDatos.Images"))));
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(978, 380);
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
            // 
            // ribbonControl1
            // 
            this.ribbonControlDataFrm.Size = new System.Drawing.Size(992, 567);
            this.ribbonControlDataFrm.Controls.SetChildIndex(this.ribbonPanel2dataFrm, 0);
            this.ribbonControlDataFrm.Controls.SetChildIndex(this.ribbonPanel1dataFrm, 0);
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1dataFrm.Controls.Add(this.label5);
            this.ribbonPanel1dataFrm.Controls.Add(this.label7);
            this.ribbonPanel1dataFrm.Controls.Add(this.label6);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtCodigo);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtTipoDocumento);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtAbreviatura);
            this.ribbonPanel1dataFrm.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel1dataFrm.Size = new System.Drawing.Size(992, 510);
            this.ribbonPanel1dataFrm.Visible = true;
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtAbreviatura, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtTipoDocumento, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtCodigo, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label6, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label7, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label5, 0);
            // 
            // cgDataControler1
            // 
            this.cgDataControler1.campos = "Codigo|codTipoDoc,Tipo Documento|nombreTipoDoc,Abreviatura|abreviatura";
            this.cgDataControler1.dataTabla = this.dsSpx1.tipoDocumento;
            this.cgDataControler1.EstadoControles = false;
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2dataFrm.Size = new System.Drawing.Size(992, 510);
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoDocumentoTableAdapter1
            // 
            this.tipoDocumentoTableAdapter1.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(12, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Codigo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(12, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tipo de Documento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(12, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Abreviatura";
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "tipoDocumento.codTipoDoc", true));
            this.txtCodigo.Location = new System.Drawing.Point(120, 114);
            this.txtCodigo.MaxLength = 5;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 7;
            // 
            // txtTipoDocumento
            // 
            this.txtTipoDocumento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "tipoDocumento.nombreTipoDoc", true));
            this.txtTipoDocumento.Location = new System.Drawing.Point(120, 150);
            this.txtTipoDocumento.MaxLength = 30;
            this.txtTipoDocumento.Name = "txtTipoDocumento";
            this.txtTipoDocumento.ReadOnly = true;
            this.txtTipoDocumento.Size = new System.Drawing.Size(244, 20);
            this.txtTipoDocumento.TabIndex = 8;
            // 
            // txtAbreviatura
            // 
            this.txtAbreviatura.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "tipoDocumento.abreviatura", true));
            this.txtAbreviatura.Location = new System.Drawing.Point(120, 186);
            this.txtAbreviatura.MaxLength = 5;
            this.txtAbreviatura.Name = "txtAbreviatura";
            this.txtAbreviatura.ReadOnly = true;
            this.txtAbreviatura.Size = new System.Drawing.Size(100, 20);
            this.txtAbreviatura.TabIndex = 9;
            // 
            // frmTipoDocumento
            // 
            this.ClientSize = new System.Drawing.Size(1000, 570);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTipoDocumento";
            this.Text = "Tipos de Documento - Nombre Software";
            this.tituloTabla = "Tipos de Documento";
            this.Load += new System.EventHandler(this.frmTipoDocumento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ribbonControlDataFrm.ResumeLayout(false);
            this.ribbonControlDataFrm.PerformLayout();
            this.ribbonPanel1dataFrm.ResumeLayout(false);
            this.ribbonPanel1dataFrm.PerformLayout();
            this.ribbonPanel2dataFrm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.tipoDocumentoTableAdapter tipoDocumentoTableAdapter1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtTipoDocumento;
        private System.Windows.Forms.TextBox txtAbreviatura;
    }
}
