namespace spProcesos.ordenesTrabajo
{
    partial class frmEscogeIngenero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEscogeIngenero));
            this.grpIngeniero = new System.Windows.Forms.GroupBox();
            this.cmbIngeniero = new System.Windows.Forms.ComboBox();
            this.lblIngeniero = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIngenieroActualmente = new System.Windows.Forms.Label();
            this.reasignacionOrdenesTrabajoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.reasignacionOrdenesTrabajoTableAdapter();
            this.ordenServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter();
            this.clsTusuario1 = new SPXSeguridad.data.cls.clsTusuario();
            this.dsSPXSeguridad1 = new SPXSeguridad.data.dsSPXSeguridad();
            this.grpIngeniero.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpIngeniero
            // 
            this.grpIngeniero.BackColor = System.Drawing.Color.Transparent;
            this.grpIngeniero.Controls.Add(this.cmbIngeniero);
            this.grpIngeniero.Controls.Add(this.lblIngeniero);
            this.grpIngeniero.Location = new System.Drawing.Point(6, 67);
            this.grpIngeniero.Name = "grpIngeniero";
            this.grpIngeniero.Size = new System.Drawing.Size(406, 84);
            this.grpIngeniero.TabIndex = 12;
            this.grpIngeniero.TabStop = false;
            this.grpIngeniero.Text = "Ingeniero Asignado";
            // 
            // cmbIngeniero
            // 
            this.cmbIngeniero.DataSource = this.dsSPXSeguridad1;
            this.cmbIngeniero.DisplayMember = "usuario.nombre";
            this.cmbIngeniero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIngeniero.FormattingEnabled = true;
            this.cmbIngeniero.Location = new System.Drawing.Point(10, 18);
            this.cmbIngeniero.Name = "cmbIngeniero";
            this.cmbIngeniero.Size = new System.Drawing.Size(383, 21);
            this.cmbIngeniero.TabIndex = 0;
            this.cmbIngeniero.ValueMember = "usuario.login";
            this.cmbIngeniero.SelectedIndexChanged += new System.EventHandler(this.cmbIngeniero_SelectedIndexChanged);
            // 
            // lblIngeniero
            // 
            this.lblIngeniero.BackColor = System.Drawing.Color.White;
            this.lblIngeniero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngeniero.Location = new System.Drawing.Point(12, 53);
            this.lblIngeniero.Name = "lblIngeniero";
            this.lblIngeniero.Size = new System.Drawing.Size(381, 18);
            this.lblIngeniero.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(325, 289);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(244, 289);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Motivo de Reasignacion";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(16, 170);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(383, 113);
            this.txtMotivo.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblIngenieroActualmente);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 49);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingeniero Asignado Actualmente";
            // 
            // lblIngenieroActualmente
            // 
            this.lblIngenieroActualmente.BackColor = System.Drawing.Color.White;
            this.lblIngenieroActualmente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngenieroActualmente.Location = new System.Drawing.Point(7, 22);
            this.lblIngenieroActualmente.Name = "lblIngenieroActualmente";
            this.lblIngenieroActualmente.Size = new System.Drawing.Size(387, 18);
            this.lblIngenieroActualmente.TabIndex = 1;
            // 
            // reasignacionOrdenesTrabajoTableAdapter1
            // 
            this.reasignacionOrdenesTrabajoTableAdapter1.ClearBeforeFill = true;
            // 
            // ordenServicioTableAdapter1
            // 
            this.ordenServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // clsTusuario1
            // 
            this.clsTusuario1.nombreLlave = "cod_usuario";
            this.clsTusuario1.nombreTabla = "usuario";
            this.clsTusuario1.sentenciaBase = resources.GetString("clsTusuario1.sentenciaBase");
            this.clsTusuario1.sentenciaBaseDistinct = resources.GetString("clsTusuario1.sentenciaBaseDistinct");
            // 
            // dsSPXSeguridad1
            // 
            this.dsSPXSeguridad1.DataSetName = "dsSPXSeguridad";
            this.dsSPXSeguridad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmEscogeIngenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(419, 324);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grpIngeniero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEscogeIngenero";
            this.Text = "Reasignacion de Ingeniero";
            this.Load += new System.EventHandler(this.frmEscogeIngenero_Load);
            this.grpIngeniero.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpIngeniero;
        private System.Windows.Forms.ComboBox cmbIngeniero;
        private System.Windows.Forms.Label lblIngeniero;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblIngenieroActualmente;
        private SPControladoraDatos.dsSpxTableAdapters.reasignacionOrdenesTrabajoTableAdapter reasignacionOrdenesTrabajoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter ordenServicioTableAdapter1;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad1;
        private SPXSeguridad.data.cls.clsTusuario clsTusuario1;
    }
}