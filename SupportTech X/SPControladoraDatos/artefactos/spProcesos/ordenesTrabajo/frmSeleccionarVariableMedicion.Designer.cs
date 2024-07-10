namespace spProcesos.ordenesTrabajo
{
    partial class frmSeleccionarVariableMedicion
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
            this.cmbVariableMedicion = new System.Windows.Forms.ComboBox();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.nmValor = new System.Windows.Forms.NumericUpDown();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.variables_medicionTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.variables_medicionTableAdapter();
            this.variables_medicionxorden_servicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.variables_medicionxorden_servicioTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSubvariableMedicion = new System.Windows.Forms.ComboBox();
            this.sub_variable_medicionTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.sub_variable_medicionTableAdapter();
            this.lblValoresEsperados = new System.Windows.Forms.Label();
            this.chkCalculadaPorEquipo = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmValor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 41);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(275, 7);
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
            this.btnCancelar.Location = new System.Drawing.Point(350, 7);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbVariableMedicion
            // 
            this.cmbVariableMedicion.DataSource = this.dsSpx1;
            this.cmbVariableMedicion.DisplayMember = "variables_medicion.nombre_variables_medicion";
            this.cmbVariableMedicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVariableMedicion.FormattingEnabled = true;
            this.cmbVariableMedicion.Location = new System.Drawing.Point(152, 29);
            this.cmbVariableMedicion.Name = "cmbVariableMedicion";
            this.cmbVariableMedicion.Size = new System.Drawing.Size(243, 21);
            this.cmbVariableMedicion.TabIndex = 1;
            this.cmbVariableMedicion.ValueMember = "variables_medicion.cod_variables_medicion";
            this.cmbVariableMedicion.SelectedIndexChanged += new System.EventHandler(this.cmbVariableMedicion_SelectedIndexChanged);
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.EnforceConstraints = false;
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nmValor
            // 
            this.nmValor.DecimalPlaces = 2;
            this.nmValor.Location = new System.Drawing.Point(152, 122);
            this.nmValor.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmValor.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.nmValor.Name = "nmValor";
            this.nmValor.Size = new System.Drawing.Size(120, 20);
            this.nmValor.TabIndex = 2;
            // 
            // txtUnidades
            // 
            this.txtUnidades.Location = new System.Drawing.Point(152, 158);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.ReadOnly = true;
            this.txtUnidades.Size = new System.Drawing.Size(243, 20);
            this.txtUnidades.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Variable de medicion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Unidades";
            // 
            // variables_medicionTableAdapter1
            // 
            this.variables_medicionTableAdapter1.ClearBeforeFill = true;
            // 
            // variables_medicionxorden_servicioTableAdapter1
            // 
            this.variables_medicionxorden_servicioTableAdapter1.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Subvariable de medicion";
            // 
            // cmbSubvariableMedicion
            // 
            this.cmbSubvariableMedicion.DataSource = this.dsSpx1;
            this.cmbSubvariableMedicion.DisplayMember = "sub_variable_medicion.nombre_subvariable";
            this.cmbSubvariableMedicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubvariableMedicion.FormattingEnabled = true;
            this.cmbSubvariableMedicion.Location = new System.Drawing.Point(152, 60);
            this.cmbSubvariableMedicion.Name = "cmbSubvariableMedicion";
            this.cmbSubvariableMedicion.Size = new System.Drawing.Size(243, 21);
            this.cmbSubvariableMedicion.TabIndex = 8;
            this.cmbSubvariableMedicion.ValueMember = "sub_variable_medicion.cod_sub_variables_medicion";
            this.cmbSubvariableMedicion.SelectedIndexChanged += new System.EventHandler(this.cmbSubvariableMedicion_SelectedIndexChanged);
            // 
            // sub_variable_medicionTableAdapter1
            // 
            this.sub_variable_medicionTableAdapter1.ClearBeforeFill = true;
            // 
            // lblValoresEsperados
            // 
            this.lblValoresEsperados.AutoSize = true;
            this.lblValoresEsperados.Location = new System.Drawing.Point(149, 94);
            this.lblValoresEsperados.Name = "lblValoresEsperados";
            this.lblValoresEsperados.Size = new System.Drawing.Size(0, 13);
            this.lblValoresEsperados.TabIndex = 9;
            // 
            // chkCalculadaPorEquipo
            // 
            this.chkCalculadaPorEquipo.AutoSize = true;
            this.chkCalculadaPorEquipo.Location = new System.Drawing.Point(301, 122);
            this.chkCalculadaPorEquipo.Name = "chkCalculadaPorEquipo";
            this.chkCalculadaPorEquipo.Size = new System.Drawing.Size(128, 17);
            this.chkCalculadaPorEquipo.TabIndex = 10;
            this.chkCalculadaPorEquipo.Text = "Calculada Por Equipo";
            this.chkCalculadaPorEquipo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valores esperados:";
            // 
            // frmSeleccionarVariableMedicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(432, 243);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkCalculadaPorEquipo);
            this.Controls.Add(this.lblValoresEsperados);
            this.Controls.Add(this.cmbSubvariableMedicion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUnidades);
            this.Controls.Add(this.nmValor);
            this.Controls.Add(this.cmbVariableMedicion);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSeleccionarVariableMedicion";
            this.Text = "Seleccionar Variables de Medicion";
            this.Load += new System.EventHandler(this.frmSeleccionarVariableMedicion_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbVariableMedicion;
        private System.Windows.Forms.NumericUpDown nmValor;
        private System.Windows.Forms.TextBox txtUnidades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.variables_medicionTableAdapter variables_medicionTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.variables_medicionxorden_servicioTableAdapter variables_medicionxorden_servicioTableAdapter1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSubvariableMedicion;
        private SPControladoraDatos.dsSpxTableAdapters.sub_variable_medicionTableAdapter sub_variable_medicionTableAdapter1;
        private System.Windows.Forms.Label lblValoresEsperados;
        private System.Windows.Forms.CheckBox chkCalculadaPorEquipo;
        private System.Windows.Forms.Label label5;
    }
}