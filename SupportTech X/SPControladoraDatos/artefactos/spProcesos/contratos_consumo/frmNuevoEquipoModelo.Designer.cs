namespace spProcesos.contratos_consumo
{
    partial class frmNuevoEquipoModelo
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdEquipo = new System.Windows.Forms.RadioButton();
            this.rdOtro = new System.Windows.Forms.RadioButton();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarEquipo = new System.Windows.Forms.Button();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.fabricanteTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.fabricanteTableAdapter();
            this.modelosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter();
            this.equiposTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter();
            this.equiposxcontrato_consumoTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.equiposxcontrato_consumoTableAdapter();
            this.chkPropiedadAnnar = new System.Windows.Forms.CheckBox();
            this.chkConectado = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(253, 11);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(335, 10);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 43);
            this.panel1.TabIndex = 2;
            // 
            // rdEquipo
            // 
            this.rdEquipo.AutoSize = true;
            this.rdEquipo.Checked = true;
            this.rdEquipo.Location = new System.Drawing.Point(12, 22);
            this.rdEquipo.Name = "rdEquipo";
            this.rdEquipo.Size = new System.Drawing.Size(58, 17);
            this.rdEquipo.TabIndex = 3;
            this.rdEquipo.TabStop = true;
            this.rdEquipo.Text = "Equipo";
            this.rdEquipo.UseVisualStyleBackColor = true;
            this.rdEquipo.Visible = false;
            this.rdEquipo.CheckedChanged += new System.EventHandler(this.rdEquipo_CheckedChanged);
            // 
            // rdOtro
            // 
            this.rdOtro.AutoSize = true;
            this.rdOtro.Location = new System.Drawing.Point(164, 22);
            this.rdOtro.Name = "rdOtro";
            this.rdOtro.Size = new System.Drawing.Size(92, 17);
            this.rdOtro.TabIndex = 0;
            this.rdOtro.Text = "Software/Otro";
            this.rdOtro.UseVisualStyleBackColor = true;
            this.rdOtro.Visible = false;
            this.rdOtro.CheckedChanged += new System.EventHandler(this.rdOtro_CheckedChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(15, 212);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(395, 86);
            this.txtDescripcion.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descripcion software";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fabricante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Serial";
            // 
            // btnBuscarEquipo
            // 
            this.btnBuscarEquipo.Location = new System.Drawing.Point(86, 160);
            this.btnBuscarEquipo.Name = "btnBuscarEquipo";
            this.btnBuscarEquipo.Size = new System.Drawing.Size(131, 23);
            this.btnBuscarEquipo.TabIndex = 4;
            this.btnBuscarEquipo.Text = "Buscar Equipo";
            this.btnBuscarEquipo.UseVisualStyleBackColor = true;
            this.btnBuscarEquipo.Click += new System.EventHandler(this.btnBuscarEquipo_Click);
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.DataSource = this.dsSpx1;
            this.cmbFabricante.DisplayMember = "fabricante.nombre_fabricante";
            this.cmbFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(86, 58);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(210, 21);
            this.cmbFabricante.TabIndex = 1;
            this.cmbFabricante.ValueMember = "fabricante.codFabricante";
            this.cmbFabricante.SelectedIndexChanged += new System.EventHandler(this.cmbFabricante_SelectedIndexChanged);
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.EnforceConstraints = false;
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbModelo
            // 
            this.cmbModelo.DataSource = this.dsSpx1;
            this.cmbModelo.DisplayMember = "Modelos.NombreModelo";
            this.cmbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Location = new System.Drawing.Point(86, 94);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(210, 21);
            this.cmbModelo.TabIndex = 2;
            this.cmbModelo.ValueMember = "Modelos.codModelo";
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(86, 125);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.ReadOnly = true;
            this.txtSerial.Size = new System.Drawing.Size(210, 20);
            this.txtSerial.TabIndex = 3;
            // 
            // fabricanteTableAdapter1
            // 
            this.fabricanteTableAdapter1.ClearBeforeFill = true;
            // 
            // modelosTableAdapter1
            // 
            this.modelosTableAdapter1.ClearBeforeFill = true;
            // 
            // equiposTableAdapter1
            // 
            this.equiposTableAdapter1.ClearBeforeFill = true;
            // 
            // equiposxcontrato_consumoTableAdapter1
            // 
            this.equiposxcontrato_consumoTableAdapter1.ClearBeforeFill = true;
            // 
            // chkPropiedadAnnar
            // 
            this.chkPropiedadAnnar.AutoSize = true;
            this.chkPropiedadAnnar.Location = new System.Drawing.Point(238, 164);
            this.chkPropiedadAnnar.Name = "chkPropiedadAnnar";
            this.chkPropiedadAnnar.Size = new System.Drawing.Size(105, 17);
            this.chkPropiedadAnnar.TabIndex = 5;
            this.chkPropiedadAnnar.Text = "Propiedad Annar";
            this.chkPropiedadAnnar.UseVisualStyleBackColor = true;
            // 
            // chkConectado
            // 
            this.chkConectado.AutoSize = true;
            this.chkConectado.Location = new System.Drawing.Point(238, 187);
            this.chkConectado.Name = "chkConectado";
            this.chkConectado.Size = new System.Drawing.Size(123, 17);
            this.chkConectado.TabIndex = 6;
            this.chkConectado.Text = "Conectado Software";
            this.chkConectado.UseVisualStyleBackColor = true;
            // 
            // frmNuevoEquipoModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(422, 355);
            this.Controls.Add(this.chkConectado);
            this.Controls.Add(this.chkPropiedadAnnar);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.cmbModelo);
            this.Controls.Add(this.cmbFabricante);
            this.Controls.Add(this.btnBuscarEquipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.rdOtro);
            this.Controls.Add(this.rdEquipo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNuevoEquipoModelo";
            this.Text = "Nuevo Relacion de Equipo/Modelo o Software";
            this.Load += new System.EventHandler(this.frmNuevoEquipoModelo_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdEquipo;
        private System.Windows.Forms.RadioButton rdOtro;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscarEquipo;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.TextBox txtSerial;
        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.fabricanteTableAdapter fabricanteTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter modelosTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter equiposTableAdapter1;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.equiposxcontrato_consumoTableAdapter equiposxcontrato_consumoTableAdapter1;
        private System.Windows.Forms.CheckBox chkPropiedadAnnar;
        private System.Windows.Forms.CheckBox chkConectado;
    }
}