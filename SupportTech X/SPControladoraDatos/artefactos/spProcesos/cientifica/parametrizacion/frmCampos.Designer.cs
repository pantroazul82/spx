namespace spProcesos.cientifica.parametrizacion
{
    partial class frmCampos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.nmFila = new System.Windows.Forms.NumericUpDown();
            this.nmColumna = new System.Windows.Forms.NumericUpDown();
            this.chkEsBoleano = new System.Windows.Forms.CheckBox();
            this.chkEsBoleanoNegado = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmColumna)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 48);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(326, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(245, 13);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Campo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fila";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Columna";
            // 
            // cmbCampo
            // 
            this.cmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampo.FormattingEnabled = true;
            this.cmbCampo.Items.AddRange(new object[] {
            "Asesor recibe",
            "Adecuado",
            "No Adecuado",
            "Consecutivo",
            "Equipo Nuevo",
            "Equipo Usuado",
            "Fabricante",
            "Fecha Creacion",
            "Fecha revision",
            "Fecha aprobacion",
            "Fecha cierre",
            "Ingeniero entrega",
            "Modelos",
            "Nit Cliente",
            "Nombre cliente",
            "Serial",
            "observaciones",
            "observaciones iniciales",
            "Usuario creacion",
            "Firma Asesor Recibe",
            "Firma Ingeniero Entrega"});
            this.cmbCampo.Location = new System.Drawing.Point(136, 39);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(211, 21);
            this.cmbCampo.TabIndex = 0;
            // 
            // nmFila
            // 
            this.nmFila.Location = new System.Drawing.Point(136, 74);
            this.nmFila.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmFila.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmFila.Name = "nmFila";
            this.nmFila.Size = new System.Drawing.Size(120, 20);
            this.nmFila.TabIndex = 1;
            this.nmFila.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nmColumna
            // 
            this.nmColumna.Location = new System.Drawing.Point(136, 103);
            this.nmColumna.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmColumna.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmColumna.Name = "nmColumna";
            this.nmColumna.Size = new System.Drawing.Size(120, 20);
            this.nmColumna.TabIndex = 2;
            this.nmColumna.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkEsBoleano
            // 
            this.chkEsBoleano.AutoSize = true;
            this.chkEsBoleano.Location = new System.Drawing.Point(79, 149);
            this.chkEsBoleano.Name = "chkEsBoleano";
            this.chkEsBoleano.Size = new System.Drawing.Size(80, 17);
            this.chkEsBoleano.TabIndex = 7;
            this.chkEsBoleano.Text = "Es Boleano";
            this.chkEsBoleano.UseVisualStyleBackColor = true;
            // 
            // chkEsBoleanoNegado
            // 
            this.chkEsBoleanoNegado.AutoSize = true;
            this.chkEsBoleanoNegado.Location = new System.Drawing.Point(175, 149);
            this.chkEsBoleanoNegado.Name = "chkEsBoleanoNegado";
            this.chkEsBoleanoNegado.Size = new System.Drawing.Size(158, 17);
            this.chkEsBoleanoNegado.TabIndex = 8;
            this.chkEsBoleanoNegado.Text = "Negacion del Valor Boleano";
            this.chkEsBoleanoNegado.UseVisualStyleBackColor = true;
            // 
            // frmCampos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(413, 243);
            this.Controls.Add(this.chkEsBoleanoNegado);
            this.Controls.Add(this.chkEsBoleano);
            this.Controls.Add(this.nmColumna);
            this.Controls.Add(this.nmFila);
            this.Controls.Add(this.cmbCampo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCampos";
            this.Text = "Campos";
            this.Load += new System.EventHandler(this.frmCampos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmFila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmColumna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCampo;
        private System.Windows.Forms.NumericUpDown nmFila;
        private System.Windows.Forms.NumericUpDown nmColumna;
        private System.Windows.Forms.CheckBox chkEsBoleano;
        private System.Windows.Forms.CheckBox chkEsBoleanoNegado;
    }
}