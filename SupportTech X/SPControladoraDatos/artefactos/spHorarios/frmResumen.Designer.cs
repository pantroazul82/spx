namespace spHorarios
{
    partial class frmResumen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResumen));
            this.dsPlantillas1 = new SPControladoraDatos.dsPlantillas();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.txtCuerpo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pltOrdenServicioSchedulleTableAdapter1 = new SPControladoraDatos.dsPlantillasTableAdapters.pltOrdenServicioSchedulleTableAdapter();
            this.calInicio = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.calFecha();
            this.calFin = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.calFecha();
            this.btnVerOrden = new DevComponents.DotNetBar.ButtonX();
            this.btnCerrar = new DevComponents.DotNetBar.ButtonX();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).BeginInit();
            this.SuspendLayout();
            // 
            // dsPlantillas1
            // 
            this.dsPlantillas1.DataSetName = "dsPlantillas";
            this.dsPlantillas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtAsunto
            // 
            this.txtAsunto.BackColor = System.Drawing.Color.White;
            this.txtAsunto.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsunto.Location = new System.Drawing.Point(71, 12);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.ReadOnly = true;
            this.txtAsunto.Size = new System.Drawing.Size(422, 21);
            this.txtAsunto.TabIndex = 0;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.BackColor = System.Drawing.Color.White;
            this.txtUbicacion.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUbicacion.Location = new System.Drawing.Point(71, 56);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.ReadOnly = true;
            this.txtUbicacion.Size = new System.Drawing.Size(422, 21);
            this.txtUbicacion.TabIndex = 1;
            // 
            // txtCuerpo
            // 
            this.txtCuerpo.BackColor = System.Drawing.Color.White;
            this.txtCuerpo.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuerpo.Location = new System.Drawing.Point(71, 161);
            this.txtCuerpo.Multiline = true;
            this.txtCuerpo.Name = "txtCuerpo";
            this.txtCuerpo.ReadOnly = true;
            this.txtCuerpo.Size = new System.Drawing.Size(461, 167);
            this.txtCuerpo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Asunto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Inicia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ubicacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Termina";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Informacion";
            // 
            // pltOrdenServicioSchedulleTableAdapter1
            // 
            this.pltOrdenServicioSchedulleTableAdapter1.ClearBeforeFill = true;
            // 
            // calInicio
            // 
            this.calInicio.BackColor = System.Drawing.Color.Transparent;
            this.calInicio.Enabled = false;
            this.calInicio.fechaValue = new System.DateTime(2009, 2, 11, 20, 31, 0, 0);
            this.calInicio.fechaValueObject = new System.DateTime(2009, 2, 11, 20, 31, 0, 0);
            this.calInicio.Location = new System.Drawing.Point(69, 87);
            this.calInicio.Name = "calInicio";
            this.calInicio.Size = new System.Drawing.Size(338, 27);
            this.calInicio.TabIndex = 8;
            // 
            // calFin
            // 
            this.calFin.BackColor = System.Drawing.Color.Transparent;
            this.calFin.Enabled = false;
            this.calFin.fechaValue = new System.DateTime(2009, 2, 11, 20, 31, 0, 0);
            this.calFin.fechaValueObject = new System.DateTime(2009, 2, 11, 20, 31, 0, 0);
            this.calFin.Location = new System.Drawing.Point(70, 120);
            this.calFin.Name = "calFin";
            this.calFin.Size = new System.Drawing.Size(338, 27);
            this.calFin.TabIndex = 9;
            // 
            // btnVerOrden
            // 
            this.btnVerOrden.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVerOrden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnVerOrden, "Ver Orden de Servicio");
            this.balloonTip1.SetBalloonText(this.btnVerOrden, null);
            this.btnVerOrden.Image = ((System.Drawing.Image)(resources.GetObject("btnVerOrden.Image")));
            this.btnVerOrden.ImageFixedSize = new System.Drawing.Size(29, 29);
            this.btnVerOrden.Location = new System.Drawing.Point(499, 12);
            this.btnVerOrden.Name = "btnVerOrden";
            this.btnVerOrden.Size = new System.Drawing.Size(33, 33);
            this.btnVerOrden.TabIndex = 80;
            this.btnVerOrden.Text = " ";
            this.btnVerOrden.Click += new System.EventHandler(this.btnVerOrden_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnCerrar, "Cerrar");
            this.balloonTip1.SetBalloonText(this.btnCerrar, null);
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageFixedSize = new System.Drawing.Size(29, 29);
            this.btnCerrar.Location = new System.Drawing.Point(499, 49);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 33);
            this.btnCerrar.TabIndex = 81;
            this.btnCerrar.Text = " ";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmResumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(537, 337);
            this.ControlBox = false;
            this.Controls.Add(this.txtCuerpo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnVerOrden);
            this.Controls.Add(this.calFin);
            this.Controls.Add(this.calInicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.txtAsunto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmResumen";
            this.Text = "Resumen";
            this.Load += new System.EventHandler(this.frmResumen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SPControladoraDatos.dsPlantillas dsPlantillas1;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.TextBox txtCuerpo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private SPControladoraDatos.dsPlantillasTableAdapters.pltOrdenServicioSchedulleTableAdapter pltOrdenServicioSchedulleTableAdapter1;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.calFecha calInicio;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.calFecha calFin;
        private DevComponents.DotNetBar.ButtonX btnVerOrden;
        private DevComponents.DotNetBar.ButtonX btnCerrar;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
    }
}