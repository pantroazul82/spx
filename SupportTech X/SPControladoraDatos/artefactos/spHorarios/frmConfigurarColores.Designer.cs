namespace spHorarios
{
    partial class frmConfigurarColores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigurarColores));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.picNivel1 = new System.Windows.Forms.PictureBox();
            this.picNivel2 = new System.Windows.Forms.PictureBox();
            this.picNivel3 = new System.Windows.Forms.PictureBox();
            this.picAlta = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.slider1 = new DevComponents.DotNetBar.Controls.Slider();
            this.slider2 = new DevComponents.DotNetBar.Controls.Slider();
            this.slider3 = new DevComponents.DotNetBar.Controls.Slider();
            this.picEsperaRes = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNivel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNivel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNivel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEsperaRes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 50);
            this.panel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(163, 14);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(82, 14);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // picNivel1
            // 
            this.picNivel1.BackColor = System.Drawing.Color.SteelBlue;
            this.picNivel1.Location = new System.Drawing.Point(266, 22);
            this.picNivel1.Name = "picNivel1";
            this.picNivel1.Size = new System.Drawing.Size(26, 23);
            this.picNivel1.TabIndex = 1;
            this.picNivel1.TabStop = false;
            this.picNivel1.Click += new System.EventHandler(this.picNivel1_Click);
            // 
            // picNivel2
            // 
            this.picNivel2.BackColor = System.Drawing.Color.Tomato;
            this.picNivel2.Location = new System.Drawing.Point(266, 60);
            this.picNivel2.Name = "picNivel2";
            this.picNivel2.Size = new System.Drawing.Size(26, 23);
            this.picNivel2.TabIndex = 2;
            this.picNivel2.TabStop = false;
            this.picNivel2.Click += new System.EventHandler(this.picNivel2_Click);
            // 
            // picNivel3
            // 
            this.picNivel3.BackColor = System.Drawing.Color.Pink;
            this.picNivel3.Location = new System.Drawing.Point(266, 98);
            this.picNivel3.Name = "picNivel3";
            this.picNivel3.Size = new System.Drawing.Size(26, 23);
            this.picNivel3.TabIndex = 3;
            this.picNivel3.TabStop = false;
            this.picNivel3.Click += new System.EventHandler(this.picNivel3_Click);
            // 
            // picAlta
            // 
            this.picAlta.BackColor = System.Drawing.Color.LightSkyBlue;
            this.picAlta.Location = new System.Drawing.Point(278, 21);
            this.picAlta.Name = "picAlta";
            this.picAlta.Size = new System.Drawing.Size(26, 23);
            this.picAlta.TabIndex = 4;
            this.picAlta.TabStop = false;
            this.picAlta.Click += new System.EventHandler(this.picAlta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ordenes de Servicio Con Prioridad Alta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ordenes de Servicio En Espera de Respuesta";
            // 
            // slider1
            // 
            this.slider1.Location = new System.Drawing.Point(16, 39);
            this.slider1.Name = "slider1";
            this.slider1.Size = new System.Drawing.Size(230, 24);
            this.slider1.TabIndex = 9;
            this.slider1.Text = "Dias";
            this.slider1.TextColor = System.Drawing.Color.Black;
            this.slider1.Value = 0;
            this.slider1.ValueChanged += new System.EventHandler(this.slider1_ValueChanged);
            // 
            // slider2
            // 
            this.slider2.Location = new System.Drawing.Point(16, 69);
            this.slider2.Name = "slider2";
            this.slider2.Size = new System.Drawing.Size(230, 23);
            this.slider2.TabIndex = 10;
            this.slider2.Text = "Dias";
            this.slider2.TextColor = System.Drawing.Color.Black;
            this.slider2.Value = 0;
            this.slider2.ValueChanged += new System.EventHandler(this.slider2_ValueChanged);
            // 
            // slider3
            // 
            this.slider3.Location = new System.Drawing.Point(16, 98);
            this.slider3.Name = "slider3";
            this.slider3.Size = new System.Drawing.Size(230, 23);
            this.slider3.TabIndex = 11;
            this.slider3.Text = "Dias";
            this.slider3.TextColor = System.Drawing.Color.Black;
            this.slider3.Value = 0;
            this.slider3.ValueChanged += new System.EventHandler(this.slider3_ValueChanged);
            // 
            // picEsperaRes
            // 
            this.picEsperaRes.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.picEsperaRes.Location = new System.Drawing.Point(278, 70);
            this.picEsperaRes.Name = "picEsperaRes";
            this.picEsperaRes.Size = new System.Drawing.Size(26, 23);
            this.picEsperaRes.TabIndex = 12;
            this.picEsperaRes.TabStop = false;
            this.picEsperaRes.Click += new System.EventHandler(this.picEsperaRes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.slider1);
            this.groupBox1.Controls.Add(this.picNivel1);
            this.groupBox1.Controls.Add(this.slider3);
            this.groupBox1.Controls.Add(this.picNivel2);
            this.groupBox1.Controls.Add(this.slider2);
            this.groupBox1.Controls.Add(this.picNivel3);
            this.groupBox1.Location = new System.Drawing.Point(12, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 135);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alarma para ordenes de Servicio retardadas";
            // 
            // frmConfigurarColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(320, 339);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picEsperaRes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picAlta);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfigurarColores";
            this.Text = "Configurar Colores";
            this.Load += new System.EventHandler(this.frmConfigurarColores_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picNivel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNivel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNivel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEsperaRes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.PictureBox picNivel1;
        private System.Windows.Forms.PictureBox picNivel2;
        private System.Windows.Forms.PictureBox picNivel3;
        private System.Windows.Forms.PictureBox picAlta;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.Slider slider1;
        private DevComponents.DotNetBar.Controls.Slider slider2;
        private DevComponents.DotNetBar.Controls.Slider slider3;
        private System.Windows.Forms.PictureBox picEsperaRes;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}