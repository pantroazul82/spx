namespace spProcesos.contratos_consumo
{
    partial class frmImportarGruposyConsumibles
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
            this.btnCargue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.btnSubirDatos = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCargue
            // 
            this.btnCargue.Location = new System.Drawing.Point(588, 22);
            this.btnCargue.Name = "btnCargue";
            this.btnCargue.Size = new System.Drawing.Size(75, 23);
            this.btnCargue.TabIndex = 0;
            this.btnCargue.Text = "Cargar";
            this.btnCargue.UseVisualStyleBackColor = true;
            this.btnCargue.Click += new System.EventHandler(this.btnCargue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grupos y Consumibles";
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(142, 22);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(440, 20);
            this.txtArchivo.TabIndex = 2;
            // 
            // btnSubirDatos
            // 
            this.btnSubirDatos.Location = new System.Drawing.Point(588, 51);
            this.btnSubirDatos.Name = "btnSubirDatos";
            this.btnSubirDatos.Size = new System.Drawing.Size(75, 23);
            this.btnSubirDatos.TabIndex = 3;
            this.btnSubirDatos.Text = "Subir Datos";
            this.btnSubirDatos.UseVisualStyleBackColor = true;
            this.btnSubirDatos.Click += new System.EventHandler(this.btnSubirDatos_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(588, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmImportarGruposyConsumibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSubirDatos);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCargue);
            this.Name = "frmImportarGruposyConsumibles";
            this.Text = "Importar Grupos y Consumibles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Button btnSubirDatos;
        private System.Windows.Forms.Button button2;
    }
}