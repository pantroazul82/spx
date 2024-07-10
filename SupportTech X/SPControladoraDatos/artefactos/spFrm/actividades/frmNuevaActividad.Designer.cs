namespace SpFrm.actividades
{
    partial class frmNuevaActividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevaActividad));
            this.tipo_actividadTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.tipo_actividadTableAdapter();
            this.actividad_adicionalTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.actividad_adicionalTableAdapter();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipoActividad = new System.Windows.Forms.ComboBox();
            this.cmbIngeniero = new System.Windows.Forms.ComboBox();
            this.txtActividad = new System.Windows.Forms.TextBox();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.calFechaInicio = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.calFecha();
            this.calFechaFin = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.calFecha();
            this.label7 = new System.Windows.Forms.Label();
            this.clsTusuario1 = new SPXSeguridad.data.cls.clsTusuario();
            this.dsSPXSeguridad1 = new SPXSeguridad.data.dsSPXSeguridad();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).BeginInit();
            this.SuspendLayout();
            // 
            // tipo_actividadTableAdapter1
            // 
            this.tipo_actividadTableAdapter1.ClearBeforeFill = true;
            // 
            // actividad_adicionalTableAdapter1
            // 
            this.actividad_adicionalTableAdapter1.ClearBeforeFill = true;
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(417, 22);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(336, 22);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 0;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btncancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 373);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 57);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo Actividad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingeniero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Actividad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha";
            // 
            // cmbTipoActividad
            // 
            this.cmbTipoActividad.DataSource = this.dsSpx1;
            this.cmbTipoActividad.DisplayMember = "tipo_actividad.nombre_tipo_actividad";
            this.cmbTipoActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoActividad.FormattingEnabled = true;
            this.cmbTipoActividad.Location = new System.Drawing.Point(157, 29);
            this.cmbTipoActividad.Name = "cmbTipoActividad";
            this.cmbTipoActividad.Size = new System.Drawing.Size(203, 21);
            this.cmbTipoActividad.TabIndex = 0;
            this.cmbTipoActividad.ValueMember = "tipo_actividad.cod_tipo_actividad";
            // 
            // cmbIngeniero
            // 
            this.cmbIngeniero.DataSource = this.dsSPXSeguridad1;
            this.cmbIngeniero.DisplayMember = "usuario.nombre";
            this.cmbIngeniero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIngeniero.FormattingEnabled = true;
            this.cmbIngeniero.Location = new System.Drawing.Point(157, 63);
            this.cmbIngeniero.Name = "cmbIngeniero";
            this.cmbIngeniero.Size = new System.Drawing.Size(203, 21);
            this.cmbIngeniero.TabIndex = 1;
            this.cmbIngeniero.ValueMember = "usuario.login";
            // 
            // txtActividad
            // 
            this.txtActividad.Location = new System.Drawing.Point(157, 150);
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.Size = new System.Drawing.Size(331, 20);
            this.txtActividad.TabIndex = 4;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(157, 176);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(331, 20);
            this.txtUbicacion.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ubicacion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(15, 230);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(477, 105);
            this.txtDescripcion.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Descripcion";
            // 
            // calFechaInicio
            // 
            this.calFechaInicio.BackColor = System.Drawing.Color.Transparent;
            this.calFechaInicio.fechaValue = new System.DateTime(2010, 6, 16, 12, 6, 0, 0);
            this.calFechaInicio.fechaValueObject = new System.DateTime(2010, 6, 16, 12, 6, 0, 0);
            this.calFechaInicio.Location = new System.Drawing.Point(157, 90);
            this.calFechaInicio.Name = "calFechaInicio";
            this.calFechaInicio.Size = new System.Drawing.Size(338, 27);
            this.calFechaInicio.TabIndex = 2;
            // 
            // calFechaFin
            // 
            this.calFechaFin.BackColor = System.Drawing.Color.Transparent;
            this.calFechaFin.fechaValue = new System.DateTime(2010, 6, 16, 12, 6, 0, 0);
            this.calFechaFin.fechaValueObject = new System.DateTime(2010, 6, 16, 12, 6, 0, 0);
            this.calFechaFin.Location = new System.Drawing.Point(154, 123);
            this.calFechaFin.Name = "calFechaFin";
            this.calFechaFin.Size = new System.Drawing.Size(338, 27);
            this.calFechaFin.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Fecha";
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
            // frmNuevaActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 430);
            this.ControlBox = false;
            this.Controls.Add(this.calFechaFin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.calFechaInicio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtActividad);
            this.Controls.Add(this.cmbIngeniero);
            this.Controls.Add(this.cmbTipoActividad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmNuevaActividad";
            this.Text = "Nueva Actividad";
            this.Load += new System.EventHandler(this.frmNuevaActividad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SPControladoraDatos.dsSpxTableAdapters.tipo_actividadTableAdapter tipo_actividadTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.actividad_adicionalTableAdapter actividad_adicionalTableAdapter1;
        private SPControladoraDatos.dsSpx dsSpx1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipoActividad;
        private System.Windows.Forms.ComboBox cmbIngeniero;
        private System.Windows.Forms.TextBox txtActividad;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label6;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.calFecha calFechaInicio;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.calFecha calFechaFin;
        private System.Windows.Forms.Label label7;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad1;
        private SPXSeguridad.data.cls.clsTusuario clsTusuario1;
    }
}