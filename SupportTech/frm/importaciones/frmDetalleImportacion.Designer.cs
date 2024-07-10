namespace SupportTech.frm.importaciones
{
    partial class frmDetalleImportacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleImportacion));
            this.controladorColumnasSinSerializar = new SPXUtilidades.Controles.controladorColumnas();
            this.grdDetalle = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // controladorColumnasSinSerializar
            // 
            this.controladorColumnasSinSerializar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controladorColumnasSinSerializar.BackColor = System.Drawing.Color.Transparent;
            this.controladorColumnasSinSerializar.grilla = null;
            this.controladorColumnasSinSerializar.Location = new System.Drawing.Point(722, 12);
            this.controladorColumnasSinSerializar.MostrarContraer = true;
            this.controladorColumnasSinSerializar.MostrarExcel = true;
            this.controladorColumnasSinSerializar.MostrarExpandir = true;
            this.controladorColumnasSinSerializar.MostrarLimpiar = true;
            this.controladorColumnasSinSerializar.Name = "controladorColumnasSinSerializar";
            this.controladorColumnasSinSerializar.nombreLibro = null;
            this.controladorColumnasSinSerializar.Size = new System.Drawing.Size(216, 29);
            this.controladorColumnasSinSerializar.TabIndex = 90;
            // 
            // grdDetalle
            // 
            this.grdDetalle.AllowUpdate = false;
            this.grdDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDetalle.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdDetalle.FilterBar = true;
            this.grdDetalle.GroupByCaption = "";
            this.grdDetalle.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDetalle.Images"))));
            this.grdDetalle.Location = new System.Drawing.Point(12, 47);
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDetalle.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDetalle.PreviewInfo.ZoomFactor = 75D;
            this.grdDetalle.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDetalle.PrintInfo.PageSettings")));
            this.grdDetalle.Size = new System.Drawing.Size(917, 485);
            this.grdDetalle.TabIndex = 89;
            this.grdDetalle.Text = "c1TrueDBGrid1";
            this.grdDetalle.PropBag = resources.GetString("grdDetalle.PropBag");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 88;
            this.label1.Text = "Informacion";
            // 
            // frmDetalleImportacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(941, 544);
            this.Controls.Add(this.controladorColumnasSinSerializar);
            this.Controls.Add(this.grdDetalle);
            this.Controls.Add(this.label1);
            this.Name = "frmDetalleImportacion";
            this.Text = "Detalle Importacion";
            this.Load += new System.EventHandler(this.frmDetalleImportacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SPXUtilidades.Controles.controladorColumnas controladorColumnasSinSerializar;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdDetalle;
        private System.Windows.Forms.Label label1;
    }
}