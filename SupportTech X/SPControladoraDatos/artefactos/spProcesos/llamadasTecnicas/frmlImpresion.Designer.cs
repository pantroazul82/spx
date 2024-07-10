namespace spProcesos.llamadasTecnicas
{
    partial class frmlImpresion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlImpresion));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdSimple = new System.Windows.Forms.RadioButton();
            this.rdImpresionCompleta = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(64, 15);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(145, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 50);
            this.panel1.TabIndex = 2;
            // 
            // rdSimple
            // 
            this.rdSimple.AutoSize = true;
            this.rdSimple.Checked = true;
            this.rdSimple.Location = new System.Drawing.Point(84, 35);
            this.rdSimple.Name = "rdSimple";
            this.rdSimple.Size = new System.Drawing.Size(110, 17);
            this.rdSimple.TabIndex = 3;
            this.rdSimple.TabStop = true;
            this.rdSimple.Text = "Impresion Sencilla";
            this.rdSimple.UseVisualStyleBackColor = true;
            // 
            // rdImpresionCompleta
            // 
            this.rdImpresionCompleta.AutoSize = true;
            this.rdImpresionCompleta.Location = new System.Drawing.Point(84, 74);
            this.rdImpresionCompleta.Name = "rdImpresionCompleta";
            this.rdImpresionCompleta.Size = new System.Drawing.Size(117, 17);
            this.rdImpresionCompleta.TabIndex = 4;
            this.rdImpresionCompleta.Text = "Impresion Completa";
            this.rdImpresionCompleta.UseVisualStyleBackColor = true;
            // 
            // frmlImpresion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 200);
            this.ControlBox = false;
            this.Controls.Add(this.rdImpresionCompleta);
            this.Controls.Add(this.rdSimple);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmlImpresion";
            this.Text = "lImpresion Llamada Tecnica";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdSimple;
        private System.Windows.Forms.RadioButton rdImpresionCompleta;
    }
}