namespace spProcesos.HerramientasAnnar
{
    partial class frmUtilidades
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
            this.btnImportarProblemas = new System.Windows.Forms.Button();
            this.btnSeguimientoEspecial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImportarProblemas
            // 
            this.btnImportarProblemas.Location = new System.Drawing.Point(12, 12);
            this.btnImportarProblemas.Name = "btnImportarProblemas";
            this.btnImportarProblemas.Size = new System.Drawing.Size(166, 23);
            this.btnImportarProblemas.TabIndex = 0;
            this.btnImportarProblemas.Text = "Importar Problemas";
            this.btnImportarProblemas.UseVisualStyleBackColor = true;
            this.btnImportarProblemas.Click += new System.EventHandler(this.btnImportarProblemas_Click);
            // 
            // btnSeguimientoEspecial
            // 
            this.btnSeguimientoEspecial.Location = new System.Drawing.Point(12, 41);
            this.btnSeguimientoEspecial.Name = "btnSeguimientoEspecial";
            this.btnSeguimientoEspecial.Size = new System.Drawing.Size(166, 23);
            this.btnSeguimientoEspecial.TabIndex = 1;
            this.btnSeguimientoEspecial.Text = "Seguimiento Especial";
            this.btnSeguimientoEspecial.UseVisualStyleBackColor = true;
            this.btnSeguimientoEspecial.Click += new System.EventHandler(this.btnSeguimientoEspecial_Click);
            // 
            // frmUtilidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(499, 366);
            this.Controls.Add(this.btnSeguimientoEspecial);
            this.Controls.Add(this.btnImportarProblemas);
            this.Name = "frmUtilidades";
            this.Text = "Utilidades";
            this.Load += new System.EventHandler(this.frmUtilidades_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImportarProblemas;
        private System.Windows.Forms.Button btnSeguimientoEspecial;
    }
}