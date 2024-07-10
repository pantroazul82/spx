namespace spProcesos.ordenesTrabajo.frm
{
    partial class frmAgregarFirma
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
            this.btnCAncelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picFirma = new System.Windows.Forms.PictureBox();
            this.nmFuente = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFirma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFuente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCAncelar
            // 
            this.btnCAncelar.Location = new System.Drawing.Point(342, 21);
            this.btnCAncelar.Name = "btnCAncelar";
            this.btnCAncelar.Size = new System.Drawing.Size(75, 23);
            this.btnCAncelar.TabIndex = 0;
            this.btnCAncelar.Text = "Cancelar";
            this.btnCAncelar.UseVisualStyleBackColor = true;
            this.btnCAncelar.Click += new System.EventHandler(this.btnCAncelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(261, 21);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnCAncelar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 391);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 56);
            this.panel1.TabIndex = 2;
            // 
            // picFirma
            // 
            this.picFirma.Location = new System.Drawing.Point(12, 34);
            this.picFirma.Name = "picFirma";
            this.picFirma.Size = new System.Drawing.Size(695, 351);
            this.picFirma.TabIndex = 3;
            this.picFirma.TabStop = false;
            this.picFirma.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picFirma_MouseMove);
            this.picFirma.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picFirma_MouseDown);
            this.picFirma.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picFirma_MouseUp);
            // 
            // nmFuente
            // 
            this.nmFuente.Location = new System.Drawing.Point(79, 10);
            this.nmFuente.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nmFuente.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nmFuente.Name = "nmFuente";
            this.nmFuente.Size = new System.Drawing.Size(120, 20);
            this.nmFuente.TabIndex = 4;
            this.nmFuente.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fuente";
            // 
            // frmAgregarFirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 447);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmFuente);
            this.Controls.Add(this.picFirma);
            this.Controls.Add(this.panel1);
            this.Name = "frmAgregarFirma";
            this.Text = "frmAgregarFirma";
            this.Load += new System.EventHandler(this.frmAgregarFirma_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFirma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFuente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCAncelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picFirma;
        private System.Windows.Forms.NumericUpDown nmFuente;
        private System.Windows.Forms.Label label1;
    }
}