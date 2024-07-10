namespace SpFrm.generales
{
    partial class frmAsesoresComerciales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsesoresComerciales));
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.asesoresComercialesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.asesoresComercialesTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodAsesor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombresAsesor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.ribbonControlDataFrm.SuspendLayout();
            this.ribbonPanel1dataFrm.SuspendLayout();
            this.ribbonPanel2dataFrm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.grpOpcionesExportar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControlDataFrm
            // 
            // 
            // 
            // 
            this.ribbonControlDataFrm.BackgroundStyle.Class = "";
            this.ribbonControlDataFrm.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControlDataFrm.Location = new System.Drawing.Point(5, 1);
            this.ribbonControlDataFrm.Size = new System.Drawing.Size(966, 553);
            this.ribbonControlDataFrm.Controls.SetChildIndex(this.ribbonPanel2dataFrm, 0);
            this.ribbonControlDataFrm.Controls.SetChildIndex(this.ribbonPanel1dataFrm, 0);
            // 
            // ribbonPanel1dataFrm
            // 
            this.ribbonPanel1dataFrm.Controls.Add(this.chkActivo);
            this.ribbonPanel1dataFrm.Controls.Add(this.label6);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtEmail);
            this.ribbonPanel1dataFrm.Controls.Add(this.label5);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtCelular);
            this.ribbonPanel1dataFrm.Controls.Add(this.label4);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtTelefono);
            this.ribbonPanel1dataFrm.Controls.Add(this.label3);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtNombresAsesor);
            this.ribbonPanel1dataFrm.Controls.Add(this.label2);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtCodAsesor);
            this.ribbonPanel1dataFrm.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanel1dataFrm.Size = new System.Drawing.Size(966, 495);
            // 
            // 
            // 
            this.ribbonPanel1dataFrm.Style.Class = "";
            this.ribbonPanel1dataFrm.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1dataFrm.StyleMouseDown.Class = "";
            this.ribbonPanel1dataFrm.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1dataFrm.StyleMouseOver.Class = "";
            this.ribbonPanel1dataFrm.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1dataFrm.Visible = true;
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtCodAsesor, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label2, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtNombresAsesor, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label3, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtTelefono, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label4, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtCelular, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label5, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtEmail, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label6, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.chkActivo, 0);
            // 
            // cgDataControler1
            // 
            this.cgDataControler1.campos = "Codigo|codAsesor,Nombre|NombreAsesor";
            this.cgDataControler1.dataTabla = this.dsSpx1.asesoresComerciales;
            this.cgDataControler1.EstadoControles = false;
            this.cgDataControler1.EventosEncendidos = true;
            this.cgDataControler1.estadoControlesChanged += new CGDataControler.dataControlerEventHandler(this.cgDataControler1_estadoControlesChanged);
            this.cgDataControler1.DespuesDeNuevo += new CGDataControler.dataControlerEventHandler(this.cgDataControler1_DespuesDeNuevo);
            this.cgDataControler1.AntesDeAceptar += new CGDataControler.dataControlerEventHandler(this.cgDataControler1_AntesDeAceptar);
            // 
            // ribbonPanel2dataFrm
            // 
            this.ribbonPanel2dataFrm.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanel2dataFrm.Size = new System.Drawing.Size(966, 495);
            // 
            // 
            // 
            this.ribbonPanel2dataFrm.Style.Class = "";
            this.ribbonPanel2dataFrm.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2dataFrm.StyleMouseDown.Class = "";
            this.ribbonPanel2dataFrm.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2dataFrm.StyleMouseOver.Class = "";
            this.ribbonPanel2dataFrm.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // grdDatos
            // 
            this.grdDatos.DataMember = "asesoresComerciales";
            this.grdDatos.DataSource = this.dsSpx1;
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75D;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(902, 322);
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
            // 
            // grpOpcionesExportar
            // 
            // 
            // 
            // 
            this.grpOpcionesExportar.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.grpOpcionesExportar.Style.BackColorGradientAngle = 90;
            this.grpOpcionesExportar.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.grpOpcionesExportar.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpOpcionesExportar.Style.BorderBottomWidth = 1;
            this.grpOpcionesExportar.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.grpOpcionesExportar.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpOpcionesExportar.Style.BorderLeftWidth = 1;
            this.grpOpcionesExportar.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpOpcionesExportar.Style.BorderRightWidth = 1;
            this.grpOpcionesExportar.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpOpcionesExportar.Style.BorderTopWidth = 1;
            this.grpOpcionesExportar.Style.Class = "";
            this.grpOpcionesExportar.Style.CornerDiameter = 4;
            this.grpOpcionesExportar.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grpOpcionesExportar.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.grpOpcionesExportar.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grpOpcionesExportar.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.grpOpcionesExportar.StyleMouseDown.Class = "";
            this.grpOpcionesExportar.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.grpOpcionesExportar.StyleMouseOver.Class = "";
            this.grpOpcionesExportar.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.EnforceConstraints = false;
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asesoresComercialesTableAdapter1
            // 
            this.asesoresComercialesTableAdapter1.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(40, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo Asesor";
            // 
            // txtCodAsesor
            // 
            this.txtCodAsesor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "asesoresComerciales.codAsesor", true));
            this.txtCodAsesor.Location = new System.Drawing.Point(121, 124);
            this.txtCodAsesor.Name = "txtCodAsesor";
            this.txtCodAsesor.ReadOnly = true;
            this.txtCodAsesor.Size = new System.Drawing.Size(100, 20);
            this.txtCodAsesor.TabIndex = 3;
            this.txtCodAsesor.TextChanged += new System.EventHandler(this.txtCodAsesor_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(40, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombres";
            // 
            // txtNombresAsesor
            // 
            this.txtNombresAsesor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "asesoresComerciales.NombreAsesor", true));
            this.txtNombresAsesor.Location = new System.Drawing.Point(121, 150);
            this.txtNombresAsesor.MaxLength = 50;
            this.txtNombresAsesor.Name = "txtNombresAsesor";
            this.txtNombresAsesor.ReadOnly = true;
            this.txtNombresAsesor.Size = new System.Drawing.Size(268, 20);
            this.txtNombresAsesor.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(40, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "asesoresComerciales.telefono", true));
            this.txtTelefono.Location = new System.Drawing.Point(121, 176);
            this.txtTelefono.MaxLength = 15;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(152, 20);
            this.txtTelefono.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(40, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Celular";
            // 
            // txtCelular
            // 
            this.txtCelular.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "asesoresComerciales.celular", true));
            this.txtCelular.Location = new System.Drawing.Point(121, 202);
            this.txtCelular.MaxLength = 15;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.ReadOnly = true;
            this.txtCelular.Size = new System.Drawing.Size(152, 20);
            this.txtCelular.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(40, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "asesoresComerciales.correo", true));
            this.txtEmail.Location = new System.Drawing.Point(121, 230);
            this.txtEmail.MaxLength = 250;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(268, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.BackColor = System.Drawing.Color.Transparent;
            this.chkActivo.Location = new System.Drawing.Point(121, 256);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 17);
            this.chkActivo.TabIndex = 12;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = false;
            // 
            // frmAsesoresComerciales
            // 
            this.ClientSize = new System.Drawing.Size(976, 556);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAsesoresComerciales";
            this.Text = "Asesores Comerciales - Nombre Software";
            this.tituloTabla = "Asesores Comerciales";
            this.Load += new System.EventHandler(this.frmAsesoresComerciales_Load);
            this.ribbonControlDataFrm.ResumeLayout(false);
            this.ribbonControlDataFrm.PerformLayout();
            this.ribbonPanel1dataFrm.ResumeLayout(false);
            this.ribbonPanel1dataFrm.PerformLayout();
            this.ribbonPanel2dataFrm.ResumeLayout(false);
            this.ribbonPanel2dataFrm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.grpOpcionesExportar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SPControladoraDatos.dsSpx dsSpx1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombresAsesor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodAsesor;
        private SPControladoraDatos.dsSpxTableAdapters.asesoresComercialesTableAdapter asesoresComercialesTableAdapter1;
        private System.Windows.Forms.CheckBox chkActivo;
    }
}
