namespace spProcesos.contratos_consumo
{
    partial class frmConsumoRequerido
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLineaConsumo = new System.Windows.Forms.ComboBox();
            this.dsContratoConsumo1 = new SPControladoraDatos.dsContratoConsumo();
            this.label2 = new System.Windows.Forms.Label();
            this.linea_consumoTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.linea_consumoTableAdapter();
            this.txtConsumoRequerido = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblConsumoRequerido = new System.Windows.Forms.Label();
            this.linea_consumoxcontrato_consumoTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.linea_consumoxcontrato_consumoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsContratoConsumo1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(217, 7);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(298, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Linea Consumo";
            // 
            // cmbLineaConsumo
            // 
            this.cmbLineaConsumo.DataSource = this.dsContratoConsumo1;
            this.cmbLineaConsumo.DisplayMember = "linea_consumo.nombre_linea_consumo";
            this.cmbLineaConsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLineaConsumo.FormattingEnabled = true;
            this.cmbLineaConsumo.Location = new System.Drawing.Point(120, 84);
            this.cmbLineaConsumo.Name = "cmbLineaConsumo";
            this.cmbLineaConsumo.Size = new System.Drawing.Size(241, 21);
            this.cmbLineaConsumo.TabIndex = 3;
            this.cmbLineaConsumo.ValueMember = "linea_consumo.cod_linea_consumo";
            // 
            // dsContratoConsumo1
            // 
            this.dsContratoConsumo1.DataSetName = "dsContratoConsumo";
            this.dsContratoConsumo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Consumo Requerido";
            // 
            // linea_consumoTableAdapter1
            // 
            this.linea_consumoTableAdapter1.ClearBeforeFill = true;
            // 
            // txtConsumoRequerido
            // 
            this.txtConsumoRequerido.Location = new System.Drawing.Point(120, 36);
            this.txtConsumoRequerido.Name = "txtConsumoRequerido";
            this.txtConsumoRequerido.Size = new System.Drawing.Size(150, 20);
            this.txtConsumoRequerido.TabIndex = 5;
            this.txtConsumoRequerido.TextChanged += new System.EventHandler(this.txtConsumoRequerido_TextChanged);
            this.txtConsumoRequerido.Validated += new System.EventHandler(this.txtConsumoRequerido_Validated);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 38);
            this.panel1.TabIndex = 6;
            // 
            // lblConsumoRequerido
            // 
            this.lblConsumoRequerido.AutoSize = true;
            this.lblConsumoRequerido.Location = new System.Drawing.Point(117, 59);
            this.lblConsumoRequerido.Name = "lblConsumoRequerido";
            this.lblConsumoRequerido.Size = new System.Drawing.Size(0, 13);
            this.lblConsumoRequerido.TabIndex = 7;
            // 
            // linea_consumoxcontrato_consumoTableAdapter1
            // 
            this.linea_consumoxcontrato_consumoTableAdapter1.ClearBeforeFill = true;
            // 
            // frmConsumoRequerido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(387, 210);
            this.Controls.Add(this.lblConsumoRequerido);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtConsumoRequerido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbLineaConsumo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConsumoRequerido";
            this.Text = "Consumo Requerido";
            this.Load += new System.EventHandler(this.frmConsumoRequerido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsContratoConsumo1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLineaConsumo;
        private System.Windows.Forms.Label label2;
        private SPControladoraDatos.dsContratoConsumo dsContratoConsumo1;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.linea_consumoTableAdapter linea_consumoTableAdapter1;
        private System.Windows.Forms.TextBox txtConsumoRequerido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblConsumoRequerido;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.linea_consumoxcontrato_consumoTableAdapter linea_consumoxcontrato_consumoTableAdapter1;
    }
}