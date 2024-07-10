namespace spProcesos.problemas_frecuentes
{
    partial class frmParametrizacionProblemas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParametrizacionProblemas));
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.fabricanteTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.fabricanteTableAdapter();
            this.modelosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.grdProblemas = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.grdSoluciones = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.controladorColumnasSoluciones = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas();
            this.controladorColumnasProblemas = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas();
            this.problemas_frecuentesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.problemas_frecuentesTableAdapter();
            this.soluciones_problemasTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.soluciones_problemasTableAdapter();
            this.btnAgregar = new DevComponents.DotNetBar.ButtonX();
            this.btnEditarProblema = new DevComponents.DotNetBar.ButtonX();
            this.btnEliminarProblema = new DevComponents.DotNetBar.ButtonX();
            this.btnEliminarSolucion = new DevComponents.DotNetBar.ButtonX();
            this.btnEditarSolucion = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregarSolucion = new DevComponents.DotNetBar.ButtonX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBuscarEspecial = new DevComponents.DotNetBar.ButtonX();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFiltroEspecial = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProblemas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSoluciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fabricanteTableAdapter1
            // 
            this.fabricanteTableAdapter1.ClearBeforeFill = true;
            // 
            // modelosTableAdapter1
            // 
            this.modelosTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fabricante:";
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.DataSource = this.dsSpx1;
            this.cmbFabricante.DisplayMember = "fabricante.nombre_fabricante";
            this.cmbFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(84, 18);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(250, 21);
            this.cmbFabricante.TabIndex = 2;
            this.cmbFabricante.ValueMember = "fabricante.codFabricante";
            this.cmbFabricante.SelectedIndexChanged += new System.EventHandler(this.cmbFabricante_SelectedIndexChanged);
            // 
            // cmbModelo
            // 
            this.cmbModelo.DataSource = this.dsSpx1;
            this.cmbModelo.DisplayMember = "Modelos.NombreModelo";
            this.cmbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Location = new System.Drawing.Point(416, 15);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(250, 21);
            this.cmbModelo.TabIndex = 3;
            this.cmbModelo.ValueMember = "Modelos.codModelo";
            this.cmbModelo.SelectedIndexChanged += new System.EventHandler(this.cmbModelo_SelectedIndexChanged);
            // 
            // grdProblemas
            // 
            this.grdProblemas.AllowUpdate = false;
            this.grdProblemas.DataMember = "problemas_frecuentes";
            this.grdProblemas.DataSource = this.dsSpx1;
            this.grdProblemas.Images.Add(((System.Drawing.Image)(resources.GetObject("grdProblemas.Images"))));
            this.grdProblemas.Location = new System.Drawing.Point(12, 140);
            this.grdProblemas.Name = "grdProblemas";
            this.grdProblemas.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdProblemas.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdProblemas.PreviewInfo.ZoomFactor = 75D;
            this.grdProblemas.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdProblemas.PrintInfo.PageSettings")));
            this.grdProblemas.Size = new System.Drawing.Size(465, 479);
            this.grdProblemas.TabIndex = 4;
            this.grdProblemas.Text = "c1TrueDBGrid1";
            this.grdProblemas.RowColChange += new C1.Win.C1TrueDBGrid.RowColChangeEventHandler(this.grdProblemas_RowColChange);
            this.grdProblemas.PropBag = resources.GetString("grdProblemas.PropBag");
            // 
            // grdSoluciones
            // 
            this.grdSoluciones.DataMember = "soluciones_problemas";
            this.grdSoluciones.DataSource = this.dsSpx1;
            this.grdSoluciones.Images.Add(((System.Drawing.Image)(resources.GetObject("grdSoluciones.Images"))));
            this.grdSoluciones.Location = new System.Drawing.Point(498, 140);
            this.grdSoluciones.Name = "grdSoluciones";
            this.grdSoluciones.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdSoluciones.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdSoluciones.PreviewInfo.ZoomFactor = 75D;
            this.grdSoluciones.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdSoluciones.PrintInfo.PageSettings")));
            this.grdSoluciones.RowHeight = 49;
            this.grdSoluciones.Size = new System.Drawing.Size(498, 479);
            this.grdSoluciones.TabIndex = 5;
            this.grdSoluciones.Text = "c1TrueDBGrid2";
            this.grdSoluciones.PropBag = resources.GetString("grdSoluciones.PropBag");
            // 
            // controladorColumnasSoluciones
            // 
            this.controladorColumnasSoluciones.BackColor = System.Drawing.Color.Transparent;
            this.controladorColumnasSoluciones.grilla = null;
            this.controladorColumnasSoluciones.Location = new System.Drawing.Point(781, 100);
            this.controladorColumnasSoluciones.MostrarContraer = true;
            this.controladorColumnasSoluciones.MostrarExcel = true;
            this.controladorColumnasSoluciones.MostrarExpandir = true;
            this.controladorColumnasSoluciones.MostrarLimpiar = true;
            this.controladorColumnasSoluciones.Name = "controladorColumnasSoluciones";
            this.controladorColumnasSoluciones.nombreLibro = null;
            this.controladorColumnasSoluciones.Size = new System.Drawing.Size(215, 34);
            this.controladorColumnasSoluciones.TabIndex = 6;
            // 
            // controladorColumnasProblemas
            // 
            this.controladorColumnasProblemas.BackColor = System.Drawing.Color.Transparent;
            this.controladorColumnasProblemas.grilla = null;
            this.controladorColumnasProblemas.Location = new System.Drawing.Point(262, 100);
            this.controladorColumnasProblemas.MostrarContraer = true;
            this.controladorColumnasProblemas.MostrarExcel = true;
            this.controladorColumnasProblemas.MostrarExpandir = true;
            this.controladorColumnasProblemas.MostrarLimpiar = true;
            this.controladorColumnasProblemas.Name = "controladorColumnasProblemas";
            this.controladorColumnasProblemas.nombreLibro = null;
            this.controladorColumnasProblemas.Size = new System.Drawing.Size(215, 34);
            this.controladorColumnasProblemas.TabIndex = 7;
            // 
            // problemas_frecuentesTableAdapter1
            // 
            this.problemas_frecuentesTableAdapter1.ClearBeforeFill = true;
            // 
            // soluciones_problemasTableAdapter1
            // 
            this.soluciones_problemasTableAdapter1.ClearBeforeFill = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnAgregar.Location = new System.Drawing.Point(156, 100);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(33, 33);
            this.btnAgregar.TabIndex = 102;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditarProblema
            // 
            this.btnEditarProblema.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEditarProblema.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarProblema.Image")));
            this.btnEditarProblema.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnEditarProblema.Location = new System.Drawing.Point(191, 100);
            this.btnEditarProblema.Name = "btnEditarProblema";
            this.btnEditarProblema.Size = new System.Drawing.Size(33, 33);
            this.btnEditarProblema.TabIndex = 103;
            this.btnEditarProblema.Click += new System.EventHandler(this.btnEditarProblema_Click);
            // 
            // btnEliminarProblema
            // 
            this.btnEliminarProblema.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEliminarProblema.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarProblema.Image")));
            this.btnEliminarProblema.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnEliminarProblema.Location = new System.Drawing.Point(227, 100);
            this.btnEliminarProblema.Name = "btnEliminarProblema";
            this.btnEliminarProblema.Size = new System.Drawing.Size(33, 33);
            this.btnEliminarProblema.TabIndex = 104;
            this.btnEliminarProblema.Click += new System.EventHandler(this.btnEliminarProblema_Click);
            // 
            // btnEliminarSolucion
            // 
            this.btnEliminarSolucion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEliminarSolucion.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarSolucion.Image")));
            this.btnEliminarSolucion.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnEliminarSolucion.Location = new System.Drawing.Point(747, 100);
            this.btnEliminarSolucion.Name = "btnEliminarSolucion";
            this.btnEliminarSolucion.Size = new System.Drawing.Size(33, 33);
            this.btnEliminarSolucion.TabIndex = 107;
            this.btnEliminarSolucion.Click += new System.EventHandler(this.btnEliminarSolucion_Click);
            // 
            // btnEditarSolucion
            // 
            this.btnEditarSolucion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEditarSolucion.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarSolucion.Image")));
            this.btnEditarSolucion.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnEditarSolucion.Location = new System.Drawing.Point(711, 100);
            this.btnEditarSolucion.Name = "btnEditarSolucion";
            this.btnEditarSolucion.Size = new System.Drawing.Size(33, 33);
            this.btnEditarSolucion.TabIndex = 106;
            this.btnEditarSolucion.Click += new System.EventHandler(this.btnEditarSolucion_Click);
            // 
            // btnAgregarSolucion
            // 
            this.btnAgregarSolucion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregarSolucion.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarSolucion.Image")));
            this.btnAgregarSolucion.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnAgregarSolucion.Location = new System.Drawing.Point(676, 100);
            this.btnAgregarSolucion.Name = "btnAgregarSolucion";
            this.btnAgregarSolucion.Size = new System.Drawing.Size(33, 33);
            this.btnAgregarSolucion.TabIndex = 105;
            this.btnAgregarSolucion.Click += new System.EventHandler(this.btnAgregarSolucion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(948, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 50);
            this.pictureBox1.TabIndex = 108;
            this.pictureBox1.TabStop = false;
            // 
            // btnBuscarEspecial
            // 
            this.btnBuscarEspecial.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscarEspecial.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarEspecial.Image")));
            this.btnBuscarEspecial.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnBuscarEspecial.Location = new System.Drawing.Point(444, 52);
            this.btnBuscarEspecial.Name = "btnBuscarEspecial";
            this.btnBuscarEspecial.Size = new System.Drawing.Size(33, 33);
            this.btnBuscarEspecial.TabIndex = 109;
            this.btnBuscarEspecial.Click += new System.EventHandler(this.btnBuscarEspecial_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 110;
            this.label3.Text = "Filtro Especial";
            // 
            // txtFiltroEspecial
            // 
            this.txtFiltroEspecial.Location = new System.Drawing.Point(95, 52);
            this.txtFiltroEspecial.Multiline = true;
            this.txtFiltroEspecial.Name = "txtFiltroEspecial";
            this.txtFiltroEspecial.Size = new System.Drawing.Size(343, 33);
            this.txtFiltroEspecial.TabIndex = 111;
            // 
            // frmParametrizacionProblemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1008, 633);
            this.Controls.Add(this.txtFiltroEspecial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscarEspecial);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEliminarSolucion);
            this.Controls.Add(this.btnEditarSolucion);
            this.Controls.Add(this.btnAgregarSolucion);
            this.Controls.Add(this.btnEliminarProblema);
            this.Controls.Add(this.btnEditarProblema);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.controladorColumnasProblemas);
            this.Controls.Add(this.controladorColumnasSoluciones);
            this.Controls.Add(this.grdSoluciones);
            this.Controls.Add(this.grdProblemas);
            this.Controls.Add(this.cmbModelo);
            this.Controls.Add(this.cmbFabricante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmParametrizacionProblemas";
            this.Text = "Parametrizacion Problemas Frecuentes";
            this.Load += new System.EventHandler(this.frmParametrizacionProblemas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProblemas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSoluciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.fabricanteTableAdapter fabricanteTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter modelosTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.ComboBox cmbModelo;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdProblemas;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdSoluciones;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas controladorColumnasSoluciones;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas controladorColumnasProblemas;
        private SPControladoraDatos.dsSpxTableAdapters.problemas_frecuentesTableAdapter problemas_frecuentesTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.soluciones_problemasTableAdapter soluciones_problemasTableAdapter1;
        private DevComponents.DotNetBar.ButtonX btnAgregar;
        private DevComponents.DotNetBar.ButtonX btnEditarProblema;
        private DevComponents.DotNetBar.ButtonX btnEliminarProblema;
        private DevComponents.DotNetBar.ButtonX btnEliminarSolucion;
        private DevComponents.DotNetBar.ButtonX btnEditarSolucion;
        private DevComponents.DotNetBar.ButtonX btnAgregarSolucion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.ButtonX btnBuscarEspecial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFiltroEspecial;
    }
}