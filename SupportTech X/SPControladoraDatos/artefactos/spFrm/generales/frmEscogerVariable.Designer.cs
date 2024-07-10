namespace SpFrm.generales
{
    partial class frmEscogerVariable
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
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.variables_medicionTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.variables_medicionTableAdapter();
            this.variables_medicionxmodeloTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.variables_medicionxmodeloTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpValoresEsperados = new System.Windows.Forms.GroupBox();
            this.chkObligatorio = new System.Windows.Forms.CheckBox();
            this.nmRangoFinal = new System.Windows.Forms.NumericUpDown();
            this.nmRangoInicial = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbVariable = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.sub_variable_medicionTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.sub_variable_medicionTableAdapter();
            this.lblSubVariable = new System.Windows.Forms.Label();
            this.cmbSusbvariable = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpValoresEsperados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmRangoFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmRangoInicial)).BeginInit();
            this.SuspendLayout();
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.EnforceConstraints = false;
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // variables_medicionTableAdapter1
            // 
            this.variables_medicionTableAdapter1.ClearBeforeFill = true;
            // 
            // variables_medicionxmodeloTableAdapter1
            // 
            this.variables_medicionxmodeloTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 48);
            this.panel1.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(353, 12);
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
            this.btnCancelar.Location = new System.Drawing.Point(434, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grpValoresEsperados
            // 
            this.grpValoresEsperados.Controls.Add(this.chkObligatorio);
            this.grpValoresEsperados.Controls.Add(this.nmRangoFinal);
            this.grpValoresEsperados.Controls.Add(this.nmRangoInicial);
            this.grpValoresEsperados.Controls.Add(this.label2);
            this.grpValoresEsperados.Controls.Add(this.label1);
            this.grpValoresEsperados.Location = new System.Drawing.Point(12, 87);
            this.grpValoresEsperados.Name = "grpValoresEsperados";
            this.grpValoresEsperados.Size = new System.Drawing.Size(468, 43);
            this.grpValoresEsperados.TabIndex = 1;
            this.grpValoresEsperados.TabStop = false;
            this.grpValoresEsperados.Text = "Valores Esperados";
            // 
            // chkObligatorio
            // 
            this.chkObligatorio.AutoSize = true;
            this.chkObligatorio.Location = new System.Drawing.Point(321, 19);
            this.chkObligatorio.Name = "chkObligatorio";
            this.chkObligatorio.Size = new System.Drawing.Size(144, 17);
            this.chkObligatorio.TabIndex = 4;
            this.chkObligatorio.Text = "Obligatorio en preventivo";
            this.chkObligatorio.UseVisualStyleBackColor = true;
            // 
            // nmRangoFinal
            // 
            this.nmRangoFinal.DecimalPlaces = 2;
            this.nmRangoFinal.Location = new System.Drawing.Point(228, 21);
            this.nmRangoFinal.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmRangoFinal.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.nmRangoFinal.Name = "nmRangoFinal";
            this.nmRangoFinal.Size = new System.Drawing.Size(72, 20);
            this.nmRangoFinal.TabIndex = 3;
            // 
            // nmRangoInicial
            // 
            this.nmRangoInicial.DecimalPlaces = 2;
            this.nmRangoInicial.Location = new System.Drawing.Point(81, 19);
            this.nmRangoInicial.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmRangoInicial.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.nmRangoInicial.Name = "nmRangoInicial";
            this.nmRangoInicial.Size = new System.Drawing.Size(72, 20);
            this.nmRangoInicial.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rango final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rango Inicial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Variable";
            // 
            // cmbVariable
            // 
            this.cmbVariable.DataSource = this.dsSpx1;
            this.cmbVariable.DisplayMember = "variables_medicion.nombre_variables_medicion";
            this.cmbVariable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVariable.FormattingEnabled = true;
            this.cmbVariable.Location = new System.Drawing.Point(87, 16);
            this.cmbVariable.Name = "cmbVariable";
            this.cmbVariable.Size = new System.Drawing.Size(255, 21);
            this.cmbVariable.TabIndex = 3;
            this.cmbVariable.ValueMember = "variables_medicion.cod_variables_medicion";
            this.cmbVariable.SelectedIndexChanged += new System.EventHandler(this.cmbVariable_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Unidades";
            // 
            // txtUnidades
            // 
            this.txtUnidades.Location = new System.Drawing.Point(409, 19);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(100, 20);
            this.txtUnidades.TabIndex = 5;
            // 
            // sub_variable_medicionTableAdapter1
            // 
            this.sub_variable_medicionTableAdapter1.ClearBeforeFill = true;
            // 
            // lblSubVariable
            // 
            this.lblSubVariable.AutoSize = true;
            this.lblSubVariable.Location = new System.Drawing.Point(18, 49);
            this.lblSubVariable.Name = "lblSubVariable";
            this.lblSubVariable.Size = new System.Drawing.Size(67, 13);
            this.lblSubVariable.TabIndex = 8;
            this.lblSubVariable.Text = "Sub Variable";
            // 
            // cmbSusbvariable
            // 
            this.cmbSusbvariable.DataSource = this.dsSpx1;
            this.cmbSusbvariable.DisplayMember = "sub_variable_medicion.nombre_subvariable";
            this.cmbSusbvariable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSusbvariable.FormattingEnabled = true;
            this.cmbSusbvariable.Location = new System.Drawing.Point(87, 49);
            this.cmbSusbvariable.Name = "cmbSusbvariable";
            this.cmbSusbvariable.Size = new System.Drawing.Size(255, 21);
            this.cmbSusbvariable.TabIndex = 9;
            this.cmbSusbvariable.ValueMember = "sub_variable_medicion.cod_sub_variables_medicion";
            // 
            // frmEscogerVariable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(521, 212);
            this.Controls.Add(this.cmbSusbvariable);
            this.Controls.Add(this.lblSubVariable);
            this.Controls.Add(this.txtUnidades);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbVariable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpValoresEsperados);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEscogerVariable";
            this.Text = "Escoger Variable";
            this.Load += new System.EventHandler(this.frmEscogerVariable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.grpValoresEsperados.ResumeLayout(false);
            this.grpValoresEsperados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmRangoFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmRangoInicial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.variables_medicionTableAdapter variables_medicionTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.variables_medicionxmodeloTableAdapter variables_medicionxmodeloTableAdapter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox grpValoresEsperados;
        private System.Windows.Forms.NumericUpDown nmRangoFinal;
        private System.Windows.Forms.NumericUpDown nmRangoInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbVariable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUnidades;
        private System.Windows.Forms.CheckBox chkObligatorio;
        private SPControladoraDatos.dsSpxTableAdapters.sub_variable_medicionTableAdapter sub_variable_medicionTableAdapter1;
        private System.Windows.Forms.Label lblSubVariable;
        private System.Windows.Forms.ComboBox cmbSusbvariable;
    }
}