namespace spProcesos.ESequipos
{
    partial class frmAccesoriosEquipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccesoriosEquipo));
            this.accesoriosEquipoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.accesoriosEquipoTableAdapter();
            this.fabricanteTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.fabricanteTableAdapter();
            this.modelosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAbrirFoto = new DevComponents.DotNetBar.ButtonX();
            this.btnGuardarFoto = new DevComponents.DotNetBar.ButtonX();
            this.btnSubirFoto = new DevComponents.DotNetBar.ButtonX();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.btnLimpiarfabricante = new System.Windows.Forms.Button();
            this.btnLimpiarModelo = new System.Windows.Forms.Button();
            this.fotografiaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.fotografiaTableAdapter();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ribbonControlDataFrm.SuspendLayout();
            this.ribbonPanel1dataFrm.SuspendLayout();
            this.ribbonPanel2dataFrm.SuspendLayout();
            this.grdDatos.BeginInit();
            this.grpOpcionesExportar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControlDataFrm
            // 
            this.ribbonControlDataFrm.Size = new System.Drawing.Size(992, 565);
            this.ribbonControlDataFrm.Controls.SetChildIndex(this.ribbonPanel2dataFrm, 0);
            this.ribbonControlDataFrm.Controls.SetChildIndex(this.ribbonPanel1dataFrm, 0);
            // 
            // ribbonPanel1dataFrm
            // 
            this.ribbonPanel1dataFrm.Controls.Add(this.btnLimpiarModelo);
            this.ribbonPanel1dataFrm.Controls.Add(this.btnLimpiarfabricante);
            this.ribbonPanel1dataFrm.Controls.Add(this.picFoto);
            this.ribbonPanel1dataFrm.Controls.Add(this.btnAbrirFoto);
            this.ribbonPanel1dataFrm.Controls.Add(this.btnGuardarFoto);
            this.ribbonPanel1dataFrm.Controls.Add(this.btnSubirFoto);
            this.ribbonPanel1dataFrm.Controls.Add(this.cmbModelo);
            this.ribbonPanel1dataFrm.Controls.Add(this.cmbFabricante);
            this.ribbonPanel1dataFrm.Controls.Add(this.label2);
            this.ribbonPanel1dataFrm.Controls.Add(this.label3);
            this.ribbonPanel1dataFrm.Controls.Add(this.label1);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtDescripcion);
            this.ribbonPanel1dataFrm.Controls.Add(this.label7);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtNombre);
            this.ribbonPanel1dataFrm.Controls.Add(this.label5);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtCodigo);
            this.ribbonPanel1dataFrm.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel1dataFrm.Size = new System.Drawing.Size(992, 508);
            this.ribbonPanel1dataFrm.Visible = true;
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtCodigo, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label5, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtNombre, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label7, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label1, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label3, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label2, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.cmbFabricante, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.cmbModelo, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.btnSubirFoto, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.btnGuardarFoto, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.btnAbrirFoto, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.picFoto, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.btnLimpiarfabricante, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.btnLimpiarModelo, 0);
            // 
            // cgDataControler1
            // 
            this.cgDataControler1.campos = "Codigo|codAccesoriosEquipos,Nombre|nombreAccesorio";
            this.cgDataControler1.dataTabla = this.dsSpx1.accesoriosEquipo;
            this.cgDataControler1.EstadoControles = false;
            this.cgDataControler1.estadoControlesChanged += new CGDataControler.dataControlerEventHandler(this.cgDataControler1_estadoControlesChanged);
            this.cgDataControler1.AntesDeAceptar += new CGDataControler.dataControlerEventHandler(this.cgDataControler1_AntesDeAceptar);
            // 
            // ribbonPanel2dataFrm
            // 
            this.ribbonPanel2dataFrm.Size = new System.Drawing.Size(992, 508);
            // 
            // grdDatos
            // 
            this.grdDatos.DataMember = "accesoriosEquipo";
            this.grdDatos.DataSource = this.dsSpx1;
            this.grdDatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDatos.Images"))));
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(978, 433);
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
            // 
            // txtTotalRegistros
            // 
            this.txtTotalRegistros.Text = "0";
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
            this.grpOpcionesExportar.Style.CornerDiameter = 4;
            this.grpOpcionesExportar.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grpOpcionesExportar.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.grpOpcionesExportar.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grpOpcionesExportar.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // accesoriosEquipoTableAdapter1
            // 
            this.accesoriosEquipoTableAdapter1.ClearBeforeFill = true;
            // 
            // fabricanteTableAdapter1
            // 
            this.fabricanteTableAdapter1.ClearBeforeFill = true;
            // 
            // modelosTableAdapter1
            // 
            this.modelosTableAdapter1.ClearBeforeFill = true;
            // 
            // cmbModelo
            // 
            this.cmbModelo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsSpx1, "accesoriosEquipo.codModelo", true));
            this.cmbModelo.DataSource = this.dsSpx1;
            this.cmbModelo.DisplayMember = "Modelos.NombreModelo";
            this.cmbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Location = new System.Drawing.Point(128, 205);
            this.cmbModelo.MaxLength = 5;
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(217, 21);
            this.cmbModelo.TabIndex = 35;
            this.cmbModelo.ValueMember = "Modelos.codModelo";
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsSpx1, "accesoriosEquipo.codFabricante", true));
            this.cmbFabricante.DataSource = this.dsSpx1;
            this.cmbFabricante.DisplayMember = "fabricante.nombre_fabricante";
            this.cmbFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(128, 176);
            this.cmbFabricante.MaxLength = 5;
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(217, 21);
            this.cmbFabricante.TabIndex = 34;
            this.cmbFabricante.ValueMember = "fabricante.codFabricante";
            this.cmbFabricante.SelectedIndexChanged += new System.EventHandler(this.cmbFabricante_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(20, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(20, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Fabricante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(20, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "accesoriosEquipo.descripcion", true));
            this.txtDescripcion.Location = new System.Drawing.Point(128, 234);
            this.txtDescripcion.MaxLength = 250;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(321, 135);
            this.txtDescripcion.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(20, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "*Nombre Accesorio";
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "accesoriosEquipo.nombreAccesorio", true));
            this.txtNombre.Location = new System.Drawing.Point(128, 146);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(181, 20);
            this.txtNombre.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(20, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "*Codigo Accesorio";
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "accesoriosEquipo.codAccesoriosEquipos", true));
            this.txtCodigo.Location = new System.Drawing.Point(128, 117);
            this.txtCodigo.MaxLength = 15;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(181, 20);
            this.txtCodigo.TabIndex = 26;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // btnAbrirFoto
            // 
            this.btnAbrirFoto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAbrirFoto.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirFoto.Image")));
            this.btnAbrirFoto.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnAbrirFoto.Location = new System.Drawing.Point(931, 158);
            this.btnAbrirFoto.Name = "btnAbrirFoto";
            this.btnAbrirFoto.Size = new System.Drawing.Size(33, 33);
            this.btnAbrirFoto.TabIndex = 148;
            this.btnAbrirFoto.Click += new System.EventHandler(this.btnAbrirFoto_Click);
            // 
            // btnGuardarFoto
            // 
            this.btnGuardarFoto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGuardarFoto.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarFoto.Image")));
            this.btnGuardarFoto.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnGuardarFoto.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnGuardarFoto.Location = new System.Drawing.Point(931, 197);
            this.btnGuardarFoto.Name = "btnGuardarFoto";
            this.btnGuardarFoto.Size = new System.Drawing.Size(33, 33);
            this.btnGuardarFoto.TabIndex = 147;
            this.btnGuardarFoto.ClientSizeChanged += new System.EventHandler(this.btnGuardarFoto_Click);
            // 
            // btnSubirFoto
            // 
            this.btnSubirFoto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSubirFoto.Image = ((System.Drawing.Image)(resources.GetObject("btnSubirFoto.Image")));
            this.btnSubirFoto.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnSubirFoto.Location = new System.Drawing.Point(931, 119);
            this.btnSubirFoto.Name = "btnSubirFoto";
            this.btnSubirFoto.Size = new System.Drawing.Size(33, 33);
            this.btnSubirFoto.TabIndex = 146;
            this.btnSubirFoto.Click += new System.EventHandler(this.btnSubirFoto_Click);
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(566, 119);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(350, 355);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFoto.TabIndex = 149;
            this.picFoto.TabStop = false;
            // 
            // btnLimpiarfabricante
            // 
            this.btnLimpiarfabricante.Location = new System.Drawing.Point(351, 176);
            this.btnLimpiarfabricante.Name = "btnLimpiarfabricante";
            this.btnLimpiarfabricante.Size = new System.Drawing.Size(16, 23);
            this.btnLimpiarfabricante.TabIndex = 150;
            this.btnLimpiarfabricante.Text = "x";
            this.btnLimpiarfabricante.UseVisualStyleBackColor = true;
            this.btnLimpiarfabricante.Click += new System.EventHandler(this.btnLimpiarfabricante_Click);
            // 
            // btnLimpiarModelo
            // 
            this.btnLimpiarModelo.Location = new System.Drawing.Point(351, 203);
            this.btnLimpiarModelo.Name = "btnLimpiarModelo";
            this.btnLimpiarModelo.Size = new System.Drawing.Size(16, 23);
            this.btnLimpiarModelo.TabIndex = 151;
            this.btnLimpiarModelo.Text = "x";
            this.btnLimpiarModelo.UseVisualStyleBackColor = true;
            this.btnLimpiarModelo.Click += new System.EventHandler(this.btnLimpiarModelo_Click);
            // 
            // fotografiaTableAdapter1
            // 
            this.fotografiaTableAdapter1.ClearBeforeFill = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "jpg";
            this.saveFileDialog1.Filter = "JPEG|*.jpg|BMP|*.bmp|Archivo PNG|*.png|GIF|*.gif";
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG|*.jpg|BMP|*.bmp|Archivo PNG|*.png|GIF|*.gif";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // frmAccesoriosEquipo
            // 
            this.ClientSize = new System.Drawing.Size(1000, 568);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAccesoriosEquipo";
            this.Text = "Accesorios - Nombre Software";
            this.tituloTabla = "Accesorios";
            this.Load += new System.EventHandler(this.frmAccesoriosEquipo_Load);
            this.ribbonControlDataFrm.ResumeLayout(false);
            this.ribbonControlDataFrm.PerformLayout();
            this.ribbonPanel1dataFrm.ResumeLayout(false);
            this.ribbonPanel1dataFrm.PerformLayout();
            this.ribbonPanel2dataFrm.ResumeLayout(false);
            this.ribbonPanel2dataFrm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.grpOpcionesExportar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SPControladoraDatos.dsSpxTableAdapters.accesoriosEquipoTableAdapter accesoriosEquipoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.fabricanteTableAdapter fabricanteTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter modelosTableAdapter1;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private SPControladoraDatos.dsSpx dsSpx1;
        private System.Windows.Forms.PictureBox picFoto;
        private DevComponents.DotNetBar.ButtonX btnAbrirFoto;
        private DevComponents.DotNetBar.ButtonX btnGuardarFoto;
        private DevComponents.DotNetBar.ButtonX btnSubirFoto;
        private System.Windows.Forms.Button btnLimpiarfabricante;
        private System.Windows.Forms.Button btnLimpiarModelo;
        private SPControladoraDatos.dsSpxTableAdapters.fotografiaTableAdapter fotografiaTableAdapter1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
