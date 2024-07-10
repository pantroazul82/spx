namespace spProcesos.contratos_consumo
{
    partial class frmSubModalidadContrato
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
            this.sub_modalidad_contratoTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.sub_modalidad_contratoTableAdapter();
            this.modalidad_contratoTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.modalidad_contratoTableAdapter();
            this.dsContratoConsumo1 = new SPControladoraDatos.dsContratoConsumo();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.txtSubModalidadContrato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbModalidad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsContratoConsumo1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 51);
            this.panel1.TabIndex = 0;
            // 
            // sub_modalidad_contratoTableAdapter1
            // 
            this.sub_modalidad_contratoTableAdapter1.ClearBeforeFill = true;
            // 
            // modalidad_contratoTableAdapter1
            // 
            this.modalidad_contratoTableAdapter1.ClearBeforeFill = true;
            // 
            // dsContratoConsumo1
            // 
            this.dsContratoConsumo1.DataSetName = "dsContratoConsumo";
            this.dsContratoConsumo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(197, 16);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(116, 16);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(92, 157);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 17);
            this.chkActivo.TabIndex = 6;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtSubModalidadContrato
            // 
            this.txtSubModalidadContrato.Location = new System.Drawing.Point(15, 107);
            this.txtSubModalidadContrato.Name = "txtSubModalidadContrato";
            this.txtSubModalidadContrato.Size = new System.Drawing.Size(257, 20);
            this.txtSubModalidadContrato.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modalidad Contrato";
            // 
            // cmbModalidad
            // 
            this.cmbModalidad.DataSource = this.dsContratoConsumo1;
            this.cmbModalidad.DisplayMember = "modalidad_contrato.nombre_modalidad_contrato";
            this.cmbModalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModalidad.FormattingEnabled = true;
            this.cmbModalidad.Location = new System.Drawing.Point(12, 49);
            this.cmbModalidad.Name = "cmbModalidad";
            this.cmbModalidad.Size = new System.Drawing.Size(260, 21);
            this.cmbModalidad.TabIndex = 7;
            this.cmbModalidad.ValueMember = "modalidad_contrato.cod_modalidad_contrato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sub modalidad Contrato";
            // 
            // frmSubModalidadContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbModalidad);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.txtSubModalidadContrato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSubModalidadContrato";
            this.Text = "Sub Modalidad Contrato";
            this.Load += new System.EventHandler(this.frmSubModalidadContrato_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsContratoConsumo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.sub_modalidad_contratoTableAdapter sub_modalidad_contratoTableAdapter1;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.modalidad_contratoTableAdapter modalidad_contratoTableAdapter1;
        private SPControladoraDatos.dsContratoConsumo dsContratoConsumo1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.TextBox txtSubModalidadContrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbModalidad;
        private System.Windows.Forms.Label label2;
    }
}