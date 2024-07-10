namespace spProcesos.llamadasTecnicas
{
    partial class frmAgregarSeguimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarSeguimiento));
            this.calSugerida = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.calFecha();
            this.txtObservacionesIniciales = new System.Windows.Forms.TextBox();
            this.txtCreadoPor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdRealizado = new System.Windows.Forms.RadioButton();
            this.rdPendiente = new System.Windows.Forms.RadioButton();
            this.calRealizado = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.calFecha();
            this.label6 = new System.Windows.Forms.Label();
            this.txtObsFinales = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnlimpiaPor = new System.Windows.Forms.Button();
            this.cmbRealizadoPor = new System.Windows.Forms.ComboBox();
            this.dsSPXSeguridad1 = new SPXSeguridad.data.dsSPXSeguridad();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.seguimientoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.seguimientoTableAdapter();
            this.llamadaSoporteTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.LlamadaSoporteTableAdapter();
            this.contactosClientesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.contactosClientesTableAdapter();
            this.clientesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.clientesTableAdapter();
            this.sucursalClienteTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.sucursalClienteTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clsTusuario1 = new SPXSeguridad.data.cls.clsTusuario();
            this.clsTusuario2 = new SPXSeguridad.data.cls.clsTusuario();
            this.dsSPXSeguridad2 = new SPXSeguridad.data.dsSPXSeguridad();
            this.txtSerial = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad2)).BeginInit();
            this.SuspendLayout();
            // 
            // calSugerida
            // 
            this.calSugerida.BackColor = System.Drawing.Color.Transparent;
            this.calSugerida.fechaValue = new System.DateTime(2010, 4, 26, 17, 12, 0, 0);
            this.calSugerida.fechaValueObject = new System.DateTime(2010, 4, 26, 17, 12, 0, 0);
            this.calSugerida.Location = new System.Drawing.Point(384, 36);
            this.calSugerida.Name = "calSugerida";
            this.calSugerida.Size = new System.Drawing.Size(338, 27);
            this.calSugerida.TabIndex = 1;
            // 
            // txtObservacionesIniciales
            // 
            this.txtObservacionesIniciales.Location = new System.Drawing.Point(6, 66);
            this.txtObservacionesIniciales.Multiline = true;
            this.txtObservacionesIniciales.Name = "txtObservacionesIniciales";
            this.txtObservacionesIniciales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacionesIniciales.Size = new System.Drawing.Size(716, 83);
            this.txtObservacionesIniciales.TabIndex = 2;
            // 
            // txtCreadoPor
            // 
            this.txtCreadoPor.Location = new System.Drawing.Point(87, 20);
            this.txtCreadoPor.Name = "txtCreadoPor";
            this.txtCreadoPor.ReadOnly = true;
            this.txtCreadoPor.Size = new System.Drawing.Size(218, 21);
            this.txtCreadoPor.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 99;
            this.label3.Text = "Observaciones Iniciales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 98;
            this.label2.Text = "Creado Por";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 97;
            this.label1.Text = "Fecha Sugerida";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(686, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(605, 15);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(318, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 49);
            this.pictureBox1.TabIndex = 103;
            this.pictureBox1.TabStop = false;
            // 
            // rdRealizado
            // 
            this.rdRealizado.AutoSize = true;
            this.rdRealizado.Location = new System.Drawing.Point(10, 44);
            this.rdRealizado.Name = "rdRealizado";
            this.rdRealizado.Size = new System.Drawing.Size(71, 17);
            this.rdRealizado.TabIndex = 1;
            this.rdRealizado.TabStop = true;
            this.rdRealizado.Text = "Realizado";
            this.rdRealizado.UseVisualStyleBackColor = true;
            // 
            // rdPendiente
            // 
            this.rdPendiente.AutoSize = true;
            this.rdPendiente.Location = new System.Drawing.Point(9, 21);
            this.rdPendiente.Name = "rdPendiente";
            this.rdPendiente.Size = new System.Drawing.Size(74, 17);
            this.rdPendiente.TabIndex = 0;
            this.rdPendiente.TabStop = true;
            this.rdPendiente.Text = "Pendiente";
            this.rdPendiente.UseVisualStyleBackColor = true;
            // 
            // calRealizado
            // 
            this.calRealizado.BackColor = System.Drawing.Color.Transparent;
            this.calRealizado.fechaValue = new System.DateTime(2010, 4, 26, 17, 12, 0, 0);
            this.calRealizado.fechaValueObject = new System.DateTime(2010, 4, 26, 17, 12, 0, 0);
            this.calRealizado.Location = new System.Drawing.Point(393, 33);
            this.calRealizado.Name = "calRealizado";
            this.calRealizado.Size = new System.Drawing.Size(338, 27);
            this.calRealizado.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(393, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 107;
            this.label6.Text = "Fecha de Seguimiento";
            // 
            // txtObsFinales
            // 
            this.txtObsFinales.Location = new System.Drawing.Point(10, 94);
            this.txtObsFinales.Multiline = true;
            this.txtObsFinales.Name = "txtObsFinales";
            this.txtObsFinales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObsFinales.Size = new System.Drawing.Size(733, 70);
            this.txtObsFinales.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 109;
            this.label7.Text = "Observaciones Finales";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnlimpiaPor);
            this.groupBox1.Controls.Add(this.cmbRealizadoPor);
            this.groupBox1.Controls.Add(this.rdPendiente);
            this.groupBox1.Controls.Add(this.txtObsFinales);
            this.groupBox1.Controls.Add(this.rdRealizado);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.calRealizado);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(6, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion  Seguimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 104;
            this.label8.Text = "Realizado Por";
            // 
            // btnlimpiaPor
            // 
            this.btnlimpiaPor.Location = new System.Drawing.Point(343, 37);
            this.btnlimpiaPor.Name = "btnlimpiaPor";
            this.btnlimpiaPor.Size = new System.Drawing.Size(24, 23);
            this.btnlimpiaPor.TabIndex = 3;
            this.btnlimpiaPor.Text = "<<";
            this.btnlimpiaPor.UseVisualStyleBackColor = true;
            this.btnlimpiaPor.Click += new System.EventHandler(this.btnlimpiaPor_Click);
            // 
            // cmbRealizadoPor
            // 
            this.cmbRealizadoPor.DataSource = this.dsSPXSeguridad1;
            this.cmbRealizadoPor.DisplayMember = "usuario.nombre";
            this.cmbRealizadoPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRealizadoPor.FormattingEnabled = true;
            this.cmbRealizadoPor.Location = new System.Drawing.Point(120, 39);
            this.cmbRealizadoPor.Name = "cmbRealizadoPor";
            this.cmbRealizadoPor.Size = new System.Drawing.Size(217, 21);
            this.cmbRealizadoPor.TabIndex = 2;
            this.cmbRealizadoPor.ValueMember = "usuario.login";
            // 
            // dsSPXSeguridad1
            // 
            this.dsSPXSeguridad1.DataSetName = "dsSPXSeguridad";
            this.dsSPXSeguridad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSerial);
            this.groupBox3.Controls.Add(this.calSugerida);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtCreadoPor);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.txtObservacionesIniciales);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(6, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(743, 162);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion de Creacion";
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seguimientoTableAdapter1
            // 
            this.seguimientoTableAdapter1.ClearBeforeFill = true;
            // 
            // llamadaSoporteTableAdapter1
            // 
            this.llamadaSoporteTableAdapter1.ClearBeforeFill = true;
            // 
            // contactosClientesTableAdapter1
            // 
            this.contactosClientesTableAdapter1.ClearBeforeFill = true;
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // sucursalClienteTableAdapter1
            // 
            this.sucursalClienteTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 363);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 50);
            this.panel1.TabIndex = 1;
            // 
            // clsTusuario1
            // 
            this.clsTusuario1.nombreLlave = "cod_usuario";
            this.clsTusuario1.nombreTabla = "usuario";
            this.clsTusuario1.sentenciaBase = resources.GetString("clsTusuario1.sentenciaBase");
            this.clsTusuario1.sentenciaBaseDistinct = resources.GetString("clsTusuario1.sentenciaBaseDistinct");
            // 
            // clsTusuario2
            // 
            this.clsTusuario2.nombreLlave = "cod_usuario";
            this.clsTusuario2.nombreTabla = "usuario";
            this.clsTusuario2.sentenciaBase = resources.GetString("clsTusuario2.sentenciaBase");
            this.clsTusuario2.sentenciaBaseDistinct = resources.GetString("clsTusuario2.sentenciaBaseDistinct");
            // 
            // dsSPXSeguridad2
            // 
            this.dsSPXSeguridad2.DataSetName = "dsSPXSeguridad";
            this.dsSPXSeguridad2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(205, 42);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(100, 21);
            this.txtSerial.TabIndex = 104;
            this.txtSerial.Visible = false;
            // 
            // frmAgregarSeguimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(773, 413);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAgregarSeguimiento";
            this.Text = "Seguimiento";
            this.Load += new System.EventHandler(this.frmAgregarSeguimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.seguimientoTableAdapter seguimientoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.LlamadaSoporteTableAdapter llamadaSoporteTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.contactosClientesTableAdapter contactosClientesTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.clientesTableAdapter clientesTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.sucursalClienteTableAdapter sucursalClienteTableAdapter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.calFecha calSugerida;
        private System.Windows.Forms.TextBox txtObservacionesIniciales;
        private System.Windows.Forms.TextBox txtCreadoPor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.RadioButton rdRealizado;
        private System.Windows.Forms.RadioButton rdPendiente;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.calFecha calRealizado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtObsFinales;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbRealizadoPor;
        private System.Windows.Forms.Button btnlimpiaPor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private SPXSeguridad.data.cls.clsTusuario clsTusuario1;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad1;
        private SPXSeguridad.data.cls.clsTusuario clsTusuario2;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad2;
        private System.Windows.Forms.TextBox txtSerial;
    }
}