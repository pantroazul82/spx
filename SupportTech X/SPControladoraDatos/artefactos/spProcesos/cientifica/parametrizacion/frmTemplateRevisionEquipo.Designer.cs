namespace spProcesos.cientifica.parametrizacion
{
    partial class frmTemplateRevisionEquipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTemplateRevisionEquipo));
            this.grdDatos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.btnVerPlantillas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUpdate = false;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.FilterBar = true;
            this.grdDatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDatos.Images"))));
            this.grdDatos.Location = new System.Drawing.Point(12, 65);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75D;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(882, 348);
            this.grdDatos.TabIndex = 0;
            this.grdDatos.Text = "c1TrueDBGrid1";
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
            // 
            // btnVerPlantillas
            // 
            this.btnVerPlantillas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerPlantillas.Location = new System.Drawing.Point(740, 36);
            this.btnVerPlantillas.Name = "btnVerPlantillas";
            this.btnVerPlantillas.Size = new System.Drawing.Size(154, 23);
            this.btnVerPlantillas.TabIndex = 1;
            this.btnVerPlantillas.Text = "Ver Plantillas del Modelo";
            this.btnVerPlantillas.UseVisualStyleBackColor = true;
            this.btnVerPlantillas.Click += new System.EventHandler(this.btnVerPlantillas_Click);
            // 
            // frmTemplateRevisionEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(906, 425);
            this.Controls.Add(this.btnVerPlantillas);
            this.Controls.Add(this.grdDatos);
            this.Name = "frmTemplateRevisionEquipo";
            this.Text = "Template Revision Equipo";
            this.Load += new System.EventHandler(this.frmTemplateRevisionEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdDatos;
        private System.Windows.Forms.Button btnVerPlantillas;
    }
}