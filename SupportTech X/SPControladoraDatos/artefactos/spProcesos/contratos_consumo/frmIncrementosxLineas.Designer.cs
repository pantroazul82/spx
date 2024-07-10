namespace spProcesos.contratos_consumo
{
    partial class frmIncrementosxLineas
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
            this.dsContratoConsumo1 = new SPControladoraDatos.dsContratoConsumo();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linea_consumoTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.linea_consumoTableAdapter();
            this.incrementosxlinea_consumoTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.incrementosxlinea_consumoTableAdapter();
            this.cmbLineaConsumo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nmIncremento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsContratoConsumo1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsContratoConsumo1
            // 
            this.dsContratoConsumo1.DataSetName = "dsContratoConsumo";
            this.dsContratoConsumo1.EnforceConstraints = false;
            this.dsContratoConsumo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 45);
            this.panel1.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(212, 7);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(291, 7);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Linea de Consumo";
            // 
            // linea_consumoTableAdapter1
            // 
            this.linea_consumoTableAdapter1.ClearBeforeFill = true;
            // 
            // incrementosxlinea_consumoTableAdapter1
            // 
            this.incrementosxlinea_consumoTableAdapter1.ClearBeforeFill = true;
            // 
            // cmbLineaConsumo
            // 
            this.cmbLineaConsumo.DataSource = this.dsContratoConsumo1;
            this.cmbLineaConsumo.DisplayMember = "linea_consumo.nombre_linea_consumo";
            this.cmbLineaConsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLineaConsumo.FormattingEnabled = true;
            this.cmbLineaConsumo.Location = new System.Drawing.Point(131, 39);
            this.cmbLineaConsumo.Name = "cmbLineaConsumo";
            this.cmbLineaConsumo.Size = new System.Drawing.Size(214, 21);
            this.cmbLineaConsumo.TabIndex = 3;
            this.cmbLineaConsumo.ValueMember = "linea_consumo.cod_linea_consumo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Incremento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(236, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(353, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Recuerde que los decrementos se ingresan como incrementos negativos.";
            // 
            // nmIncremento
            // 
            this.nmIncremento.Location = new System.Drawing.Point(131, 81);
            this.nmIncremento.Name = "nmIncremento";
            this.nmIncremento.Size = new System.Drawing.Size(100, 20);
            this.nmIncremento.TabIndex = 8;
            this.nmIncremento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nmIncremento_KeyPress);
            // 
            // frmIncrementosxLineas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(371, 262);
            this.Controls.Add(this.nmIncremento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbLineaConsumo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmIncrementosxLineas";
            this.Text = "Incrementos por Lineas de consumo";
            this.Load += new System.EventHandler(this.frmIncrementosxLineas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsContratoConsumo1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SPControladoraDatos.dsContratoConsumo dsContratoConsumo1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.linea_consumoTableAdapter linea_consumoTableAdapter1;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.incrementosxlinea_consumoTableAdapter incrementosxlinea_consumoTableAdapter1;
        private System.Windows.Forms.ComboBox cmbLineaConsumo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nmIncremento;
    }
}