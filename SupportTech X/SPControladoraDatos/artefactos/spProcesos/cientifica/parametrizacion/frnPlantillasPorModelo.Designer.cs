namespace spProcesos.cientifica.parametrizacion
{
    partial class frnPlantillasPorModelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frnPlantillasPorModelo));
            this.btnEditarPlantilla = new System.Windows.Forms.Button();
            this.btnNuevaPlantilla = new System.Windows.Forms.Button();
            this.btnDescargarPlantilla = new System.Windows.Forms.Button();
            this.lblModeloFabricante = new System.Windows.Forms.Label();
            this.grdDatos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditarPlantilla
            // 
            this.btnEditarPlantilla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarPlantilla.Location = new System.Drawing.Point(614, 12);
            this.btnEditarPlantilla.Name = "btnEditarPlantilla";
            this.btnEditarPlantilla.Size = new System.Drawing.Size(109, 23);
            this.btnEditarPlantilla.TabIndex = 0;
            this.btnEditarPlantilla.Text = "Editar Plantilla";
            this.btnEditarPlantilla.UseVisualStyleBackColor = true;
            this.btnEditarPlantilla.Click += new System.EventHandler(this.btnEditarPlantilla_Click);
            // 
            // btnNuevaPlantilla
            // 
            this.btnNuevaPlantilla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevaPlantilla.Location = new System.Drawing.Point(501, 12);
            this.btnNuevaPlantilla.Name = "btnNuevaPlantilla";
            this.btnNuevaPlantilla.Size = new System.Drawing.Size(109, 23);
            this.btnNuevaPlantilla.TabIndex = 1;
            this.btnNuevaPlantilla.Text = "Nueva Plantilla";
            this.btnNuevaPlantilla.UseVisualStyleBackColor = true;
            this.btnNuevaPlantilla.Click += new System.EventHandler(this.btnNuevaPlantilla_Click);
            // 
            // btnDescargarPlantilla
            // 
            this.btnDescargarPlantilla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDescargarPlantilla.Location = new System.Drawing.Point(726, 12);
            this.btnDescargarPlantilla.Name = "btnDescargarPlantilla";
            this.btnDescargarPlantilla.Size = new System.Drawing.Size(109, 23);
            this.btnDescargarPlantilla.TabIndex = 2;
            this.btnDescargarPlantilla.Text = "Descargar Plantilla";
            this.btnDescargarPlantilla.UseVisualStyleBackColor = true;
            this.btnDescargarPlantilla.Click += new System.EventHandler(this.btnDescargarPlantilla_Click);
            // 
            // lblModeloFabricante
            // 
            this.lblModeloFabricante.AutoSize = true;
            this.lblModeloFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeloFabricante.Location = new System.Drawing.Point(12, 15);
            this.lblModeloFabricante.Name = "lblModeloFabricante";
            this.lblModeloFabricante.Size = new System.Drawing.Size(85, 20);
            this.lblModeloFabricante.TabIndex = 3;
            this.lblModeloFabricante.Text = "Fabricante";
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUpdate = false;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.FilterBar = true;
            this.grdDatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDatos.Images"))));
            this.grdDatos.Location = new System.Drawing.Point(12, 41);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75D;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(823, 388);
            this.grdDatos.TabIndex = 4;
            this.grdDatos.Text = "c1TrueDBGrid1";
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
            // 
            // frnPlantillasPorModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(847, 447);
            this.Controls.Add(this.grdDatos);
            this.Controls.Add(this.lblModeloFabricante);
            this.Controls.Add(this.btnDescargarPlantilla);
            this.Controls.Add(this.btnNuevaPlantilla);
            this.Controls.Add(this.btnEditarPlantilla);
            this.Name = "frnPlantillasPorModelo";
            this.Text = "Plantillas Por Modelo";
            this.Load += new System.EventHandler(this.frnPlantillasPorModelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditarPlantilla;
        private System.Windows.Forms.Button btnNuevaPlantilla;
        private System.Windows.Forms.Button btnDescargarPlantilla;
        private System.Windows.Forms.Label lblModeloFabricante;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdDatos;
    }
}