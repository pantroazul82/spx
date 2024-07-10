namespace spProcesos.solicitudes
{
    partial class frmEleccion
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
            this.btnCrearNueva = new System.Windows.Forms.Button();
            this.btnExistente = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearNueva
            // 
            this.btnCrearNueva.Location = new System.Drawing.Point(26, 36);
            this.btnCrearNueva.Name = "btnCrearNueva";
            this.btnCrearNueva.Size = new System.Drawing.Size(81, 46);
            this.btnCrearNueva.TabIndex = 0;
            this.btnCrearNueva.Text = "Crear Orden de Servicio";
            this.btnCrearNueva.UseVisualStyleBackColor = true;
            this.btnCrearNueva.Click += new System.EventHandler(this.btnCrearNueva_Click);
            // 
            // btnExistente
            // 
            this.btnExistente.Location = new System.Drawing.Point(109, 36);
            this.btnExistente.Name = "btnExistente";
            this.btnExistente.Size = new System.Drawing.Size(81, 46);
            this.btnExistente.TabIndex = 1;
            this.btnExistente.Text = "Tomar Orden Existente";
            this.btnExistente.UseVisualStyleBackColor = true;
            this.btnExistente.Click += new System.EventHandler(this.btnExistente_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(192, 36);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 46);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmEleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 143);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExistente);
            this.Controls.Add(this.btnCrearNueva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEleccion";
            this.Text = "Eleccion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearNueva;
        private System.Windows.Forms.Button btnExistente;
        private System.Windows.Forms.Button btnCancelar;
    }
}