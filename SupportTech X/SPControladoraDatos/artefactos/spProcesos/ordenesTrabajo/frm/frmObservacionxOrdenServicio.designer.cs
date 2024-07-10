namespace spProcesos.ordenesTrabajo
{
    partial class frmObservacionxOrdenServicio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmObservacionxOrdenServicio));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.lblIng = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbIngeniero = new System.Windows.Forms.ComboBox();
            this.dsSPXSeguridad1 = new SPXSeguridad.data.dsSPXSeguridad();
            this.label2 = new System.Windows.Forms.Label();
            this.actividadxordenServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.actividadxordenServicioTableAdapter();
            this.btnBuscarActividad = new DevComponents.DotNetBar.ButtonX();
            this.ordenServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardarSinCerrar = new System.Windows.Forms.Button();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.calActividad = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.calFecha();
            this.clsTusuario1 = new SPXSeguridad.data.cls.clsTusuario();
            this.chkConfidencial = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(503, 8);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 34);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Guardar y Cerrar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(584, 8);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 34);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha de Actividad";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.Location = new System.Drawing.Point(8, 156);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacion.Size = new System.Drawing.Size(649, 205);
            this.txtObservacion.TabIndex = 0;
            // 
            // lblIng
            // 
            this.lblIng.BackColor = System.Drawing.Color.White;
            this.lblIng.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSPXSeguridad1, "usuario.nombre", true));
            this.lblIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIng.Location = new System.Drawing.Point(4, 94);
            this.lblIng.Name = "lblIng";
            this.lblIng.Size = new System.Drawing.Size(340, 24);
            this.lblIng.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingeniero";
            // 
            // cmbIngeniero
            // 
            this.cmbIngeniero.DataSource = this.dsSPXSeguridad1;
            this.cmbIngeniero.DisplayMember = "usuario.nombre";
            this.cmbIngeniero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIngeniero.FormattingEnabled = true;
            this.cmbIngeniero.Location = new System.Drawing.Point(144, 61);
            this.cmbIngeniero.Name = "cmbIngeniero";
            this.cmbIngeniero.Size = new System.Drawing.Size(200, 21);
            this.cmbIngeniero.TabIndex = 1;
            this.cmbIngeniero.ValueMember = "usuario.login";
            this.cmbIngeniero.SelectedIndexChanged += new System.EventHandler(this.cmbIngeniero_SelectedIndexChanged);
            // 
            // dsSPXSeguridad1
            // 
            this.dsSPXSeguridad1.DataSetName = "dsSPXSeguridad";
            this.dsSPXSeguridad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Observacion";
            // 
            // actividadxordenServicioTableAdapter1
            // 
            this.actividadxordenServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // btnBuscarActividad
            // 
            this.btnBuscarActividad.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnBuscarActividad, "Libreria Actividades");
            this.balloonTip1.SetBalloonText(this.btnBuscarActividad, null);
            this.btnBuscarActividad.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarActividad.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarActividad.Image")));
            this.btnBuscarActividad.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnBuscarActividad.Location = new System.Drawing.Point(624, 115);
            this.btnBuscarActividad.Name = "btnBuscarActividad";
            this.btnBuscarActividad.Size = new System.Drawing.Size(33, 33);
            this.btnBuscarActividad.TabIndex = 3;
            this.btnBuscarActividad.Click += new System.EventHandler(this.btnBuscarActividad_Click);
            // 
            // ordenServicioTableAdapter1
            // 
            this.ordenServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnGuardarSinCerrar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 372);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 54);
            this.panel1.TabIndex = 2;
            // 
            // btnGuardarSinCerrar
            // 
            this.btnGuardarSinCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarSinCerrar.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarSinCerrar.Location = new System.Drawing.Point(422, 8);
            this.btnGuardarSinCerrar.Name = "btnGuardarSinCerrar";
            this.btnGuardarSinCerrar.Size = new System.Drawing.Size(80, 34);
            this.btnGuardarSinCerrar.TabIndex = 0;
            this.btnGuardarSinCerrar.Text = "Guardar y Crear Otra";
            this.btnGuardarSinCerrar.UseVisualStyleBackColor = true;
            this.btnGuardarSinCerrar.Click += new System.EventHandler(this.btnGuardarSinCerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkConfidencial);
            this.groupBox1.Controls.Add(this.calActividad);
            this.groupBox1.Controls.Add(this.cmbIngeniero);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblIng);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(8, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // calActividad
            // 
            this.calActividad.BackColor = System.Drawing.Color.Transparent;
            this.calActividad.fechaValue = new System.DateTime(2010, 7, 7, 17, 18, 0, 0);
            this.calActividad.fechaValueObject = new System.DateTime(2010, 7, 7, 17, 18, 0, 0);
            this.calActividad.Location = new System.Drawing.Point(144, 21);
            this.calActividad.Name = "calActividad";
            this.calActividad.Size = new System.Drawing.Size(338, 27);
            this.calActividad.TabIndex = 7;
            // 
            // clsTusuario1
            // 
            this.clsTusuario1.nombreLlave = "cod_usuario";
            this.clsTusuario1.nombreTabla = "usuario";
            this.clsTusuario1.sentenciaBase = resources.GetString("clsTusuario1.sentenciaBase");
            this.clsTusuario1.sentenciaBaseDistinct = resources.GetString("clsTusuario1.sentenciaBaseDistinct");
            // 
            // chkConfidencial
            // 
            this.chkConfidencial.AutoSize = true;
            this.chkConfidencial.Location = new System.Drawing.Point(397, 96);
            this.chkConfidencial.Name = "chkConfidencial";
            this.chkConfidencial.Size = new System.Drawing.Size(85, 17);
            this.chkConfidencial.TabIndex = 10;
            this.chkConfidencial.Text = "Confidencial";
            this.chkConfidencial.UseVisualStyleBackColor = true;
            // 
            // frmObservacionxOrdenServicio
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(668, 426);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBuscarActividad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtObservacion);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmObservacionxOrdenServicio";
            this.Text = "Actividades de Orden de Servicio";
            this.Load += new System.EventHandler(this.frmObservacionxOrdenServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private SPControladoraDatos.dsSpx dsSpx1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label lblIng;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbIngeniero;
        private System.Windows.Forms.Label label2;
        private SPControladoraDatos.dsSpxTableAdapters.actividadxordenServicioTableAdapter actividadxordenServicioTableAdapter1;
        private DevComponents.DotNetBar.ButtonX btnBuscarActividad;
        private SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter ordenServicioTableAdapter1;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private System.Windows.Forms.Button btnGuardarSinCerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.calFecha calActividad;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad1;
        private SPXSeguridad.data.cls.clsTusuario clsTusuario1;
        private System.Windows.Forms.CheckBox chkConfidencial;
    }
}