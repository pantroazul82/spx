namespace SPXSeguridad.licencias
{
    partial class frmTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTest));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHI = new System.Windows.Forms.TextBox();
            this.serial = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.btnSerial = new System.Windows.Forms.Button();
            this.btnGuardarSerial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Formulario Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Formulario Generador";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hardware Id";
            // 
            // txtHI
            // 
            this.txtHI.Location = new System.Drawing.Point(15, 25);
            this.txtHI.Name = "txtHI";
            this.txtHI.ReadOnly = true;
            this.txtHI.Size = new System.Drawing.Size(311, 20);
            this.txtHI.TabIndex = 3;
            this.txtHI.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // serial
            // 
            this.serial.AutoSize = true;
            this.serial.Location = new System.Drawing.Point(12, 86);
            this.serial.Name = "serial";
            this.serial.Size = new System.Drawing.Size(33, 13);
            this.serial.TabIndex = 4;
            this.serial.Text = "Serial";
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(15, 102);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(311, 20);
            this.txtSerial.TabIndex = 5;
            // 
            // btnSerial
            // 
            this.btnSerial.Location = new System.Drawing.Point(15, 51);
            this.btnSerial.Name = "btnSerial";
            this.btnSerial.Size = new System.Drawing.Size(141, 23);
            this.btnSerial.TabIndex = 6;
            this.btnSerial.Text = "generar serial";
            this.btnSerial.UseVisualStyleBackColor = true;
            this.btnSerial.Click += new System.EventHandler(this.btnSerial_Click);
            // 
            // btnGuardarSerial
            // 
            this.btnGuardarSerial.Location = new System.Drawing.Point(15, 191);
            this.btnGuardarSerial.Name = "btnGuardarSerial";
            this.btnGuardarSerial.Size = new System.Drawing.Size(141, 23);
            this.btnGuardarSerial.TabIndex = 7;
            this.btnGuardarSerial.Text = "Guardar Serial";
            this.btnGuardarSerial.UseVisualStyleBackColor = true;
            this.btnGuardarSerial.Click += new System.EventHandler(this.btnGuardarSerial_Click);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(338, 225);
            this.Controls.Add(this.btnGuardarSerial);
            this.Controls.Add(this.btnSerial);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.serial);
            this.Controls.Add(this.txtHI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.Load += new System.EventHandler(this.frmTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHI;
        private System.Windows.Forms.Label serial;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Button btnSerial;
        private System.Windows.Forms.Button btnGuardarSerial;
    }
}