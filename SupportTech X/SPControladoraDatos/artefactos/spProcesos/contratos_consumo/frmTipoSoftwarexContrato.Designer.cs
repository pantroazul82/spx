namespace spProcesos.contratos_consumo
{
    partial class frmTipoSoftwarexContrato
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dsContratoConsumo1 = new SPControladoraDatos.dsContratoConsumo();
            this.tipo_software_contrato_consumoTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.tipo_software_contrato_consumoTableAdapter();
            this.tipo_softwarexcontrato_consumoTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.tipo_softwarexcontrato_consumoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbsoftware = new System.Windows.Forms.ComboBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsContratoConsumo1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 45);
            this.panel1.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(368, 7);
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
            this.btnCancelar.Location = new System.Drawing.Point(447, 7);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dsContratoConsumo1
            // 
            this.dsContratoConsumo1.DataSetName = "dsContratoConsumo";
            this.dsContratoConsumo1.EnforceConstraints = false;
            this.dsContratoConsumo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipo_software_contrato_consumoTableAdapter1
            // 
            this.tipo_software_contrato_consumoTableAdapter1.ClearBeforeFill = true;
            // 
            // tipo_softwarexcontrato_consumoTableAdapter1
            // 
            this.tipo_softwarexcontrato_consumoTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Software";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Observaciones";
            // 
            // cmbsoftware
            // 
            this.cmbsoftware.DataSource = this.dsContratoConsumo1;
            this.cmbsoftware.DisplayMember = "tipo_software_contrato_consumo.tipo_software_contrato_consumo";
            this.cmbsoftware.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsoftware.FormattingEnabled = true;
            this.cmbsoftware.Location = new System.Drawing.Point(109, 22);
            this.cmbsoftware.Name = "cmbsoftware";
            this.cmbsoftware.Size = new System.Drawing.Size(271, 21);
            this.cmbsoftware.TabIndex = 6;
            this.cmbsoftware.ValueMember = "tipo_software_contrato_consumo.cod_tipo_software_contrato_consumo";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(109, 52);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(354, 168);
            this.txtObservaciones.TabIndex = 7;
            // 
            // frmTipoSoftwarexContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(527, 281);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.cmbsoftware);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTipoSoftwarexContrato";
            this.Text = "Tipo Software x Contrato";
            this.Load += new System.EventHandler(this.frmTipoSoftwarexContrato_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsContratoConsumo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private SPControladoraDatos.dsContratoConsumo dsContratoConsumo1;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.tipo_software_contrato_consumoTableAdapter tipo_software_contrato_consumoTableAdapter1;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.tipo_softwarexcontrato_consumoTableAdapter tipo_softwarexcontrato_consumoTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbsoftware;
        private System.Windows.Forms.TextBox txtObservaciones;
    }
}