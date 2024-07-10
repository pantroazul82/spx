namespace spProcesos.ESequipos
{
    partial class frmImprimirEntradaSalida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImprimirEntradaSalida));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.rdEntrada = new System.Windows.Forms.RadioButton();
            this.rdSalida = new System.Windows.Forms.RadioButton();
            this.rdCompleta = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(81, 141);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(162, 141);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // rdEntrada
            // 
            this.rdEntrada.AutoSize = true;
            this.rdEntrada.Checked = true;
            this.rdEntrada.Location = new System.Drawing.Point(101, 34);
            this.rdEntrada.Name = "rdEntrada";
            this.rdEntrada.Size = new System.Drawing.Size(100, 17);
            this.rdEntrada.TabIndex = 2;
            this.rdEntrada.TabStop = true;
            this.rdEntrada.Text = "Imprimir Entrada";
            this.rdEntrada.UseVisualStyleBackColor = true;
            // 
            // rdSalida
            // 
            this.rdSalida.AutoSize = true;
            this.rdSalida.Location = new System.Drawing.Point(101, 67);
            this.rdSalida.Name = "rdSalida";
            this.rdSalida.Size = new System.Drawing.Size(92, 17);
            this.rdSalida.TabIndex = 3;
            this.rdSalida.Text = "Imprimir Salida";
            this.rdSalida.UseVisualStyleBackColor = true;
            // 
            // rdCompleta
            // 
            this.rdCompleta.AutoSize = true;
            this.rdCompleta.Location = new System.Drawing.Point(101, 100);
            this.rdCompleta.Name = "rdCompleta";
            this.rdCompleta.Size = new System.Drawing.Size(117, 17);
            this.rdCompleta.TabIndex = 4;
            this.rdCompleta.Text = "Impresion Completa";
            this.rdCompleta.UseVisualStyleBackColor = true;
            // 
            // frmImprimirEntradaSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(334, 174);
            this.Controls.Add(this.rdCompleta);
            this.Controls.Add(this.rdSalida);
            this.Controls.Add(this.rdEntrada);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmImprimirEntradaSalida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imprimir Registro Entrada y Salida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton rdEntrada;
        private System.Windows.Forms.RadioButton rdSalida;
        private System.Windows.Forms.RadioButton rdCompleta;
    }
}