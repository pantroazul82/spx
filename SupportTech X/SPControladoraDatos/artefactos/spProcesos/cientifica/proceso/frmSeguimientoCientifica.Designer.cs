

namespace spProcesos.cientifica.proceso
{
    partial class frmSeguimientoCientifica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeguimientoCientifica));
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.seguimiento_asesoria_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.seguimiento_asesoria_cientificaTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtRegistadaPor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.calFechaSeguimineto = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.calFecha();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRich1 = new System.Windows.Forms.TextBox();
            this.grdAccionesSeguir = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.btnEliminar = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregar = new DevComponents.DotNetBar.ButtonX();
            this.label20 = new System.Windows.Forms.Label();
            this.accion_seguir_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.accion_seguir_cientificaTableAdapter();
            this.accion_seguirxseguimiento_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.accion_seguirxseguimiento_cientificaTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.accion_seguirxasesoria_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.accion_seguirxasesoria_cientificaTableAdapter();
            this.lblPrimerSeguimiento = new System.Windows.Forms.Label();
            this.asesoria_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.asesoria_cientificaTableAdapter();
            this.seguimiento_asesoria_cientificaTableAdapter2 = new SPControladoraDatos.dsSpxTableAdapters.seguimiento_asesoria_cientificaTableAdapter();
            this.clsTusuario1 = new SPXSeguridad.data.cls.clsTusuario();
            this.dsSPXSeguridad1 = new SPXSeguridad.data.dsSPXSeguridad();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccionesSeguir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).BeginInit();
            this.SuspendLayout();
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seguimiento_asesoria_cientificaTableAdapter1
            // 
            this.seguimiento_asesoria_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 507);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 55);
            this.panel1.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(614, 20);
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
            this.btnCancelar.Location = new System.Drawing.Point(695, 20);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtRegistadaPor
            // 
            this.txtRegistadaPor.BackColor = System.Drawing.Color.White;
            this.txtRegistadaPor.Location = new System.Drawing.Point(95, 22);
            this.txtRegistadaPor.Name = "txtRegistadaPor";
            this.txtRegistadaPor.ReadOnly = true;
            this.txtRegistadaPor.Size = new System.Drawing.Size(181, 20);
            this.txtRegistadaPor.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Registada Por:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Fecha de Seguimiento:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservaciones.BackColor = System.Drawing.Color.White;
            this.txtObservaciones.Location = new System.Drawing.Point(13, 62);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ReadOnly = true;
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(382, 151);
            this.txtObservaciones.TabIndex = 26;
            // 
            // calFechaSeguimineto
            // 
            this.calFechaSeguimineto.BackColor = System.Drawing.Color.Transparent;
            this.calFechaSeguimineto.Enabled = false;
            this.calFechaSeguimineto.fechaValue = new System.DateTime(((long)(0)));
            this.calFechaSeguimineto.fechaValueObject = null;
            this.calFechaSeguimineto.Location = new System.Drawing.Point(404, 21);
            this.calFechaSeguimineto.Name = "calFechaSeguimineto";
            this.calFechaSeguimineto.Size = new System.Drawing.Size(338, 27);
            this.calFechaSeguimineto.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Observaciones:";
            // 
            // txtRich1
            // 
            this.txtRich1.Location = new System.Drawing.Point(10, 232);
            this.txtRich1.Name = "txtRich1";
            this.txtRich1.ReadOnly = false;
            this.txtRich1.Size = new System.Drawing.Size(760, 264);
            this.txtRich1.TabIndex = 29;
            this.txtRich1.Text = resources.GetString("txtRich1.texto");
            // 
            // grdAccionesSeguir
            // 
            this.grdAccionesSeguir.AllowUpdate = false;
            this.grdAccionesSeguir.DataMember = "accion_seguir_cientifica";
            this.grdAccionesSeguir.DataSource = this.dsSpx1;
            this.grdAccionesSeguir.GroupByCaption = "Drag a column header here to group by that column";
            this.grdAccionesSeguir.Images.Add(((System.Drawing.Image)(resources.GetObject("grdAccionesSeguir.Images"))));
            this.grdAccionesSeguir.Location = new System.Drawing.Point(404, 81);
            this.grdAccionesSeguir.Name = "grdAccionesSeguir";
            this.grdAccionesSeguir.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdAccionesSeguir.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdAccionesSeguir.PreviewInfo.ZoomFactor = 75D;
            this.grdAccionesSeguir.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdAccionesSeguir.PrintInfo.PageSettings")));
            this.grdAccionesSeguir.Size = new System.Drawing.Size(368, 132);
            this.grdAccionesSeguir.TabIndex = 96;
            this.grdAccionesSeguir.Text = "c1TrueDBGrid1";
            this.grdAccionesSeguir.PropBag = resources.GetString("grdAccionesSeguir.PropBag");
            // 
            // btnEliminar
            // 
            this.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageFixedSize = new System.Drawing.Size(18, 18);
            this.btnEliminar.Location = new System.Drawing.Point(745, 47);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(28, 28);
            this.btnEliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEliminar.TabIndex = 95;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnAgregar.Location = new System.Drawing.Point(714, 47);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(28, 28);
            this.btnAgregar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAgregar.TabIndex = 94;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(401, 62);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(96, 13);
            this.label20.TabIndex = 93;
            this.label20.Text = "Acciones a Seguir:";
            // 
            // accion_seguir_cientificaTableAdapter1
            // 
            this.accion_seguir_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // accion_seguirxseguimiento_cientificaTableAdapter1
            // 
            this.accion_seguirxseguimiento_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 97;
            this.label4.Text = "Observaciones Con Formato:";
            // 
            // accion_seguirxasesoria_cientificaTableAdapter1
            // 
            this.accion_seguirxasesoria_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // lblPrimerSeguimiento
            // 
            this.lblPrimerSeguimiento.AutoSize = true;
            this.lblPrimerSeguimiento.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerSeguimiento.ForeColor = System.Drawing.Color.Red;
            this.lblPrimerSeguimiento.Location = new System.Drawing.Point(10, 1);
            this.lblPrimerSeguimiento.Name = "lblPrimerSeguimiento";
            this.lblPrimerSeguimiento.Size = new System.Drawing.Size(100, 13);
            this.lblPrimerSeguimiento.TabIndex = 98;
            this.lblPrimerSeguimiento.Text = "Primer Seguimiento";
            this.lblPrimerSeguimiento.Visible = false;
            // 
            // asesoria_cientificaTableAdapter1
            // 
            this.asesoria_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // seguimiento_asesoria_cientificaTableAdapter2
            // 
            this.seguimiento_asesoria_cientificaTableAdapter2.ClearBeforeFill = true;
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
            // frmSeguimientoCientifica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lblPrimerSeguimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grdAccionesSeguir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtRich1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calFechaSeguimineto);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtRegistadaPor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmSeguimientoCientifica";
            this.Text = "Seguimiento Cientifica";
            this.Load += new System.EventHandler(this.frmSeguimientoCientifica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAccionesSeguir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.seguimiento_asesoria_cientificaTableAdapter seguimiento_asesoria_cientificaTableAdapter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtRegistadaPor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtObservaciones;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.calFecha calFechaSeguimineto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRich1;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdAccionesSeguir;
        private DevComponents.DotNetBar.ButtonX btnEliminar;
        private DevComponents.DotNetBar.ButtonX btnAgregar;
        private System.Windows.Forms.Label label20;
        private SPControladoraDatos.dsSpxTableAdapters.accion_seguir_cientificaTableAdapter accion_seguir_cientificaTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.accion_seguirxseguimiento_cientificaTableAdapter accion_seguirxseguimiento_cientificaTableAdapter1;
        private System.Windows.Forms.Label label4;
        private SPControladoraDatos.dsSpxTableAdapters.accion_seguirxasesoria_cientificaTableAdapter accion_seguirxasesoria_cientificaTableAdapter1;
        private System.Windows.Forms.Label lblPrimerSeguimiento;
        private SPControladoraDatos.dsSpxTableAdapters.asesoria_cientificaTableAdapter asesoria_cientificaTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.seguimiento_asesoria_cientificaTableAdapter seguimiento_asesoria_cientificaTableAdapter2;
        private SPXSeguridad.data.cls.clsTusuario clsTusuario1;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad1;
    }
}