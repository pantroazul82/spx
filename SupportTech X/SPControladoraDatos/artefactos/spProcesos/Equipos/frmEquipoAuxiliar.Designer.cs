namespace spProcesos.Equipos
{
    partial class frmEquipoAuxiliar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEquipoAuxiliar));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCAncelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInfEquipo = new DevComponents.DotNetBar.ButtonX();
            this.txtSerialAuxiliar = new System.Windows.Forms.TextBox();
            this.txtDescripcionAuxiliar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtModalidad = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtSubtipo = new System.Windows.Forms.TextBox();
            this.txtTipoEquipo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnBuscarAux = new DevComponents.DotNetBar.ButtonX();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.equiposTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter();
            this.equipoAuxiliarTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.equipoAuxiliarTableAdapter();
            this.vistaEquipoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.vistaEquipoTableAdapter();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(354, 331);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCAncelar
            // 
            this.btnCAncelar.Location = new System.Drawing.Point(435, 331);
            this.btnCAncelar.Name = "btnCAncelar";
            this.btnCAncelar.Size = new System.Drawing.Size(75, 23);
            this.btnCAncelar.TabIndex = 1;
            this.btnCAncelar.Text = "Cancelar";
            this.btnCAncelar.UseVisualStyleBackColor = true;
            this.btnCAncelar.Click += new System.EventHandler(this.btnCAncelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Serial Equipo Principal";
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(130, 26);
            this.txtSerial.MaxLength = 30;
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.ReadOnly = true;
            this.txtSerial.Size = new System.Drawing.Size(183, 20);
            this.txtSerial.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Serial Equipo Auxiliar";
            // 
            // btnInfEquipo
            // 
            this.btnInfEquipo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInfEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfEquipo.Image")));
            this.btnInfEquipo.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnInfEquipo.Location = new System.Drawing.Point(360, 54);
            this.btnInfEquipo.Name = "btnInfEquipo";
            this.btnInfEquipo.Size = new System.Drawing.Size(42, 34);
            this.btnInfEquipo.TabIndex = 71;
            this.btnInfEquipo.Click += new System.EventHandler(this.btnInfEquipo_Click);
            // 
            // txtSerialAuxiliar
            // 
            this.txtSerialAuxiliar.Location = new System.Drawing.Point(130, 59);
            this.txtSerialAuxiliar.MaxLength = 30;
            this.txtSerialAuxiliar.Name = "txtSerialAuxiliar";
            this.txtSerialAuxiliar.Size = new System.Drawing.Size(183, 20);
            this.txtSerialAuxiliar.TabIndex = 72;
            this.txtSerialAuxiliar.Validating += new System.ComponentModel.CancelEventHandler(this.txtSerialAuxiliar_Validating);
            // 
            // txtDescripcionAuxiliar
            // 
            this.txtDescripcionAuxiliar.Location = new System.Drawing.Point(94, 230);
            this.txtDescripcionAuxiliar.MaxLength = 300;
            this.txtDescripcionAuxiliar.Multiline = true;
            this.txtDescripcionAuxiliar.Name = "txtDescripcionAuxiliar";
            this.txtDescripcionAuxiliar.Size = new System.Drawing.Size(416, 95);
            this.txtDescripcionAuxiliar.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Descripcion";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtModalidad);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.txtSubtipo);
            this.groupBox3.Controls.Add(this.txtTipoEquipo);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.txtFabricante);
            this.groupBox3.Controls.Add(this.txtModelo);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(4, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(506, 121);
            this.groupBox3.TabIndex = 75;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion del Equipo";
            // 
            // txtModalidad
            // 
            this.txtModalidad.Location = new System.Drawing.Point(89, 19);
            this.txtModalidad.Name = "txtModalidad";
            this.txtModalidad.ReadOnly = true;
            this.txtModalidad.Size = new System.Drawing.Size(162, 20);
            this.txtModalidad.TabIndex = 30;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(8, 23);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(56, 13);
            this.label26.TabIndex = 31;
            this.label26.Text = "Modalidad";
            // 
            // txtSubtipo
            // 
            this.txtSubtipo.Location = new System.Drawing.Point(340, 86);
            this.txtSubtipo.Name = "txtSubtipo";
            this.txtSubtipo.ReadOnly = true;
            this.txtSubtipo.Size = new System.Drawing.Size(156, 20);
            this.txtSubtipo.TabIndex = 8;
            // 
            // txtTipoEquipo
            // 
            this.txtTipoEquipo.Location = new System.Drawing.Point(89, 85);
            this.txtTipoEquipo.Name = "txtTipoEquipo";
            this.txtTipoEquipo.ReadOnly = true;
            this.txtTipoEquipo.Size = new System.Drawing.Size(162, 20);
            this.txtTipoEquipo.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 13);
            this.label16.TabIndex = 24;
            this.label16.Text = "Tipo de Equipo";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(255, 90);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(79, 13);
            this.label21.TabIndex = 23;
            this.label21.Text = "Subtipo Equipo";
            // 
            // txtFabricante
            // 
            this.txtFabricante.Location = new System.Drawing.Point(89, 55);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.ReadOnly = true;
            this.txtFabricante.Size = new System.Drawing.Size(162, 20);
            this.txtFabricante.TabIndex = 3;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(340, 56);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.ReadOnly = true;
            this.txtModelo.Size = new System.Drawing.Size(156, 20);
            this.txtModelo.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(259, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Modelo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Fabricante";
            // 
            // btnBuscarAux
            // 
            this.btnBuscarAux.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscarAux.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarAux.Image")));
            this.btnBuscarAux.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnBuscarAux.Location = new System.Drawing.Point(319, 54);
            this.btnBuscarAux.Name = "btnBuscarAux";
            this.btnBuscarAux.Size = new System.Drawing.Size(35, 33);
            this.btnBuscarAux.TabIndex = 76;
            this.btnBuscarAux.Click += new System.EventHandler(this.btnBuscarAux_Click);
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
            // equipoAuxiliarTableAdapter1
            // 
            this.equipoAuxiliarTableAdapter1.ClearBeforeFill = true;
            // 
            // vistaEquipoTableAdapter1
            // 
            this.vistaEquipoTableAdapter1.ClearBeforeFill = true;
            // 
            // frmEquipoAuxiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(516, 361);
            this.Controls.Add(this.btnBuscarAux);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtDescripcionAuxiliar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSerialAuxiliar);
            this.Controls.Add(this.btnInfEquipo);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCAncelar);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEquipoAuxiliar";
            this.Text = "Equipo Auxiliar";
            this.Load += new System.EventHandler(this.frmEquipoAuxiliar_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCAncelar;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX btnInfEquipo;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSerialAuxiliar;
        private System.Windows.Forms.TextBox txtDescripcionAuxiliar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtModalidad;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtSubtipo;
        private System.Windows.Forms.TextBox txtTipoEquipo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private DevComponents.DotNetBar.ButtonX btnBuscarAux;
        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter equiposTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.equipoAuxiliarTableAdapter equipoAuxiliarTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.vistaEquipoTableAdapter vistaEquipoTableAdapter1;
    }
}