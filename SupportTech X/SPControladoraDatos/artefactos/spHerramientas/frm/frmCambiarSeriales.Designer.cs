namespace spHerramientas.frm
{
    partial class frmCambiarSeriales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambiarSeriales));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInfEquipo = new DevComponents.DotNetBar.ButtonX();
            this.btnBuscarSerial = new DevComponents.DotNetBar.ButtonX();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSerialNuevo = new System.Windows.Forms.TextBox();
            this.btnCambiar = new DevComponents.DotNetBar.ButtonX();
            this.btnCancelar = new DevComponents.DotNetBar.ButtonX();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.equiposTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter();
            this.vistaEquipoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.vistaEquipoTableAdapter();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnCancelar);
            this.groupBox3.Controls.Add(this.txtSerialNuevo);
            this.groupBox3.Controls.Add(this.btnCambiar);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnInfEquipo);
            this.groupBox3.Controls.Add(this.btnBuscarSerial);
            this.groupBox3.Controls.Add(this.txtFabricante);
            this.groupBox3.Controls.Add(this.txtModelo);
            this.groupBox3.Controls.Add(this.txtSerial);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(6, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 202);
            this.groupBox3.TabIndex = 63;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion del Equipo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(5, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Serial Actual";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnInfEquipo
            // 
            this.btnInfEquipo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInfEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfEquipo.Image")));
            this.btnInfEquipo.ImageFixedSize = new System.Drawing.Size(29, 29);
            this.btnInfEquipo.Location = new System.Drawing.Point(349, 54);
            this.btnInfEquipo.Name = "btnInfEquipo";
            this.btnInfEquipo.Size = new System.Drawing.Size(33, 33);
            this.btnInfEquipo.TabIndex = 67;
            this.btnInfEquipo.Click += new System.EventHandler(this.btnInfEquipo_Click);
            // 
            // btnBuscarSerial
            // 
            this.btnBuscarSerial.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscarSerial.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarSerial.Image")));
            this.btnBuscarSerial.ImageFixedSize = new System.Drawing.Size(29, 29);
            this.btnBuscarSerial.Location = new System.Drawing.Point(314, 54);
            this.btnBuscarSerial.Name = "btnBuscarSerial";
            this.btnBuscarSerial.Size = new System.Drawing.Size(33, 33);
            this.btnBuscarSerial.TabIndex = 29;
            this.btnBuscarSerial.Click += new System.EventHandler(this.btnBuscarSerial_Click);
            // 
            // txtFabricante
            // 
            this.txtFabricante.Location = new System.Drawing.Point(74, 87);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.ReadOnly = true;
            this.txtFabricante.Size = new System.Drawing.Size(234, 20);
            this.txtFabricante.TabIndex = 3;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(74, 114);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.ReadOnly = true;
            this.txtModelo.Size = new System.Drawing.Size(234, 20);
            this.txtModelo.TabIndex = 4;
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(74, 58);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(234, 20);
            this.txtSerial.TabIndex = 0;
            this.txtSerial.Validating += new System.ComponentModel.CancelEventHandler(this.txtSerial_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Modelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fabricante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(5, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Serial Nuevo";
            // 
            // txtSerialNuevo
            // 
            this.txtSerialNuevo.AcceptsReturn = true;
            this.txtSerialNuevo.Location = new System.Drawing.Point(74, 31);
            this.txtSerialNuevo.Name = "txtSerialNuevo";
            this.txtSerialNuevo.Size = new System.Drawing.Size(234, 20);
            this.txtSerialNuevo.TabIndex = 69;
            this.txtSerialNuevo.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // btnCambiar
            // 
            this.btnCambiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCambiar.Image = ((System.Drawing.Image)(resources.GetObject("btnCambiar.Image")));
            this.btnCambiar.ImageFixedSize = new System.Drawing.Size(29, 29);
            this.btnCambiar.Location = new System.Drawing.Point(67, 161);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(123, 33);
            this.btnCambiar.TabIndex = 70;
            this.btnCambiar.Text = "Cambiar Serial";
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelar.CausesValidation = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageFixedSize = new System.Drawing.Size(29, 29);
            this.btnCancelar.Location = new System.Drawing.Point(196, 161);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 33);
            this.btnCancelar.TabIndex = 71;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equiposTableAdapter1
            // 
            this.equiposTableAdapter1.ClearBeforeFill = true;
            // 
            // vistaEquipoTableAdapter1
            // 
            this.vistaEquipoTableAdapter1.ClearBeforeFill = true;
            // 
            // frmCambiarSeriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(400, 213);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCambiarSeriales";
            this.Text = "Cambiar Seriales";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.ButtonX btnCancelar;
        private System.Windows.Forms.TextBox txtSerialNuevo;
        private DevComponents.DotNetBar.ButtonX btnCambiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private DevComponents.DotNetBar.ButtonX btnInfEquipo;
        private DevComponents.DotNetBar.ButtonX btnBuscarSerial;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter equiposTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.vistaEquipoTableAdapter vistaEquipoTableAdapter1;
    }
}