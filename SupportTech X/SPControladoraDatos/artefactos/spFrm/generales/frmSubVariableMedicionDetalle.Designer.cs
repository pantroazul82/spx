namespace SpFrm.generales
{
    partial class frmSubVariableMedicionDetalle
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
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubVariable = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cmbSubvariableMedicion = new System.Windows.Forms.ComboBox();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.sub_variable_medicionTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.sub_variable_medicionTableAdapter();
            this.variables_medicionTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.variables_medicionTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUnidades
            // 
            this.txtUnidades.Location = new System.Drawing.Point(155, 103);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(221, 20);
            this.txtUnidades.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Unidades:";
            // 
            // txtSubVariable
            // 
            this.txtSubVariable.Location = new System.Drawing.Point(155, 65);
            this.txtSubVariable.Name = "txtSubVariable";
            this.txtSubVariable.Size = new System.Drawing.Size(221, 20);
            this.txtSubVariable.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Variable de medicion:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 48);
            this.panel1.TabIndex = 12;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(417, 13);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(336, 13);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cmbSubvariableMedicion
            // 
            this.cmbSubvariableMedicion.DataSource = this.dsSpx1;
            this.cmbSubvariableMedicion.DisplayMember = "variables_medicion.nombre_variables_medicion";
            this.cmbSubvariableMedicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubvariableMedicion.FormattingEnabled = true;
            this.cmbSubvariableMedicion.Location = new System.Drawing.Point(155, 27);
            this.cmbSubvariableMedicion.Name = "cmbSubvariableMedicion";
            this.cmbSubvariableMedicion.Size = new System.Drawing.Size(325, 21);
            this.cmbSubvariableMedicion.TabIndex = 19;
            this.cmbSubvariableMedicion.ValueMember = "variables_medicion.cod_variables_medicion";
            this.cmbSubvariableMedicion.SelectedIndexChanged += new System.EventHandler(this.cmbSubvariableMedicion_SelectedIndexChanged);
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.EnforceConstraints = false;
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sub_variable_medicionTableAdapter1
            // 
            this.sub_variable_medicionTableAdapter1.ClearBeforeFill = true;
            // 
            // variables_medicionTableAdapter1
            // 
            this.variables_medicionTableAdapter1.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Sub variable de medicion:";
            // 
            // frmSubVariableMedicionDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(504, 219);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSubvariableMedicion);
            this.Controls.Add(this.txtUnidades);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSubVariable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "frmSubVariableMedicionDetalle";
            this.Text = "SubVariable Medicion Detalle";
            this.Load += new System.EventHandler(this.frmSubVariableMedicionDetalle_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUnidades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSubVariable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cmbSubvariableMedicion;
        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.sub_variable_medicionTableAdapter sub_variable_medicionTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.variables_medicionTableAdapter variables_medicionTableAdapter1;
        private System.Windows.Forms.Label label4;
    }
}