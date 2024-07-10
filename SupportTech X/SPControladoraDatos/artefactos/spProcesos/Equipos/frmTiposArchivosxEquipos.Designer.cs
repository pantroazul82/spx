namespace spProcesos.Equipos
{
    partial class frmTiposArchivosxEquipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTiposArchivosxEquipos));
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.tiposArchivoXequipoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.TiposArchivoXequipoTableAdapter();
            this.chkEsObligatorio = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombreTipo = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.grdDatos.BeginInit();
            this.ribbonControlDataFrm.SuspendLayout();
            this.ribbonPanel1dataFrm.SuspendLayout();
            this.ribbonPanel2dataFrm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDatos
            // 
            this.grdDatos.DataMember = "TiposArchivoXequipo";
            this.grdDatos.DataSource = this.dsSpx1;
            this.grdDatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDatos.Images"))));
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(954, 314);
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
            // 
            // ribbonControlDataFrm
            // 
            this.ribbonControlDataFrm.Size = new System.Drawing.Size(968, 556);
            this.ribbonControlDataFrm.Controls.SetChildIndex(this.ribbonPanel2dataFrm, 0);
            this.ribbonControlDataFrm.Controls.SetChildIndex(this.ribbonPanel1dataFrm, 0);
            // 
            // ribbonPanel1dataFrm
            // 
            this.ribbonPanel1dataFrm.Controls.Add(this.label7);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtDescripcion);
            this.ribbonPanel1dataFrm.Controls.Add(this.label8);
            this.ribbonPanel1dataFrm.Controls.Add(this.label9);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtNombreTipo);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtCodigo);
            this.ribbonPanel1dataFrm.Controls.Add(this.chkEsObligatorio);
            this.ribbonPanel1dataFrm.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel1dataFrm.Size = new System.Drawing.Size(968, 499);
            this.ribbonPanel1dataFrm.Visible = true;
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.chkEsObligatorio, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtCodigo, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtNombreTipo, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label9, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label8, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label7, 0);
            // 
            // cgDataControler1
            // 
            this.cgDataControler1.campos = "Codigo|codTipoArchivoxEquipo,Tipo Archivo|nombre";
            this.cgDataControler1.dataTabla = this.dsSpx1.TiposArchivoXequipo;
            this.cgDataControler1.EstadoControles = false;
            // 
            // ribbonPanel2dataFrm
            // 
            this.ribbonPanel2dataFrm.Size = new System.Drawing.Size(968, 499);
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tiposArchivoXequipoTableAdapter1
            // 
            this.tiposArchivoXequipoTableAdapter1.ClearBeforeFill = true;
            // 
            // chkEsObligatorio
            // 
            this.chkEsObligatorio.AutoSize = true;
            this.chkEsObligatorio.BackColor = System.Drawing.Color.Transparent;
            this.chkEsObligatorio.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsSpx1, "TiposArchivoXequipo.esObligatorio", true));
            this.chkEsObligatorio.Location = new System.Drawing.Point(149, 318);
            this.chkEsObligatorio.Name = "chkEsObligatorio";
            this.chkEsObligatorio.Size = new System.Drawing.Size(91, 17);
            this.chkEsObligatorio.TabIndex = 8;
            this.chkEsObligatorio.Text = "Es Obligatorio";
            this.chkEsObligatorio.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(14, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "TiposArchivoXequipo.descripcion", true));
            this.txtDescripcion.Location = new System.Drawing.Point(149, 177);
            this.txtDescripcion.MaxLength = 350;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(365, 120);
            this.txtDescripcion.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(11, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Codigo Tipo Archivo*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(11, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tipo Archivo*";
            // 
            // txtNombreTipo
            // 
            this.txtNombreTipo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "TiposArchivoXequipo.nombre", true));
            this.txtNombreTipo.Location = new System.Drawing.Point(149, 141);
            this.txtNombreTipo.MaxLength = 40;
            this.txtNombreTipo.Name = "txtNombreTipo";
            this.txtNombreTipo.ReadOnly = true;
            this.txtNombreTipo.Size = new System.Drawing.Size(365, 20);
            this.txtNombreTipo.TabIndex = 17;
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "TiposArchivoXequipo.codTipoArchivoxEquipo", true));
            this.txtCodigo.Location = new System.Drawing.Point(149, 108);
            this.txtCodigo.MaxLength = 5;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(183, 20);
            this.txtCodigo.TabIndex = 16;
            // 
            // frmTiposArchivosxEquipos
            // 
            this.ClientSize = new System.Drawing.Size(976, 559);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTiposArchivosxEquipos";
            this.Text = "Tipos de Archivo x Equipo - Nombre Software";
            this.tituloTabla = "Tipos de Archivo x Equipo";
            this.Load += new System.EventHandler(this.frmTiposArchivosxEquipos_Load);
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
        private System.Windows.Forms.CheckBox chkEsObligatorio;
        private SPControladoraDatos.dsSpxTableAdapters.TiposArchivoXequipoTableAdapter tiposArchivoXequipoTableAdapter1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombreTipo;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}
