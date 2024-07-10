namespace spProcesos.contratos_consumo
{
    partial class frmListadoContratosConsumo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoContratosConsumo));
            this.grdDatos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsContratoConsumo1 = new SPControladoraDatos.dsContratoConsumo();
            this.btnNuevoContrato = new DevComponents.DotNetBar.ButtonX();
            this.controladorColumnas1 = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas();
            this.btnVerContrato = new DevComponents.DotNetBar.ButtonX();
            this.nmRegistros = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdNoLegalizados = new System.Windows.Forms.RadioButton();
            this.rdLegalizados = new System.Windows.Forms.RadioButton();
            this.rdTodos = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.txtCampo = new System.Windows.Forms.TextBox();
            this.chkLimitarNumeroResultados = new System.Windows.Forms.CheckBox();
            this.btnElimnarContrato = new DevComponents.DotNetBar.ButtonX();
            this.btnEditarEspecial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContratoConsumo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmRegistros)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUpdate = false;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.DataSource = this.dsContratoConsumo1;
            this.grdDatos.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdDatos.FilterBar = true;
            this.grdDatos.GroupByCaption = "";
            this.grdDatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDatos.Images"))));
            this.grdDatos.Location = new System.Drawing.Point(12, 123);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75D;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(833, 345);
            this.grdDatos.TabIndex = 3;
            this.grdDatos.Text = "c1TrueDBGrid1";
            this.grdDatos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
            // 
            // dsContratoConsumo1
            // 
            this.dsContratoConsumo1.DataSetName = "dsContratoConsumo";
            this.dsContratoConsumo1.EnforceConstraints = false;
            this.dsContratoConsumo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnNuevoContrato
            // 
            this.btnNuevoContrato.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNuevoContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoContrato.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoContrato.Image")));
            this.btnNuevoContrato.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnNuevoContrato.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnNuevoContrato.Location = new System.Drawing.Point(537, 90);
            this.btnNuevoContrato.Name = "btnNuevoContrato";
            this.btnNuevoContrato.Size = new System.Drawing.Size(28, 28);
            this.btnNuevoContrato.TabIndex = 104;
            this.btnNuevoContrato.Tooltip = "Nuevo Contrato";
            this.btnNuevoContrato.Click += new System.EventHandler(this.btnNuevoContrato_Click);
            // 
            // controladorColumnas1
            // 
            this.controladorColumnas1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controladorColumnas1.BackColor = System.Drawing.Color.Transparent;
            this.controladorColumnas1.grilla = null;
            this.controladorColumnas1.Location = new System.Drawing.Point(629, 89);
            this.controladorColumnas1.MostrarContraer = true;
            this.controladorColumnas1.MostrarExcel = true;
            this.controladorColumnas1.MostrarExpandir = true;
            this.controladorColumnas1.MostrarLimpiar = true;
            this.controladorColumnas1.Name = "controladorColumnas1";
            this.controladorColumnas1.nombreLibro = null;
            this.controladorColumnas1.Size = new System.Drawing.Size(216, 29);
            this.controladorColumnas1.TabIndex = 103;
            // 
            // btnVerContrato
            // 
            this.btnVerContrato.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVerContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerContrato.Image = ((System.Drawing.Image)(resources.GetObject("btnVerContrato.Image")));
            this.btnVerContrato.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnVerContrato.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnVerContrato.Location = new System.Drawing.Point(569, 90);
            this.btnVerContrato.Name = "btnVerContrato";
            this.btnVerContrato.Size = new System.Drawing.Size(28, 28);
            this.btnVerContrato.TabIndex = 102;
            this.btnVerContrato.Tooltip = "Ver Contrato";
            this.btnVerContrato.Click += new System.EventHandler(this.btnVerContrato_Click);
            // 
            // nmRegistros
            // 
            this.nmRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nmRegistros.Location = new System.Drawing.Point(750, 57);
            this.nmRegistros.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmRegistros.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmRegistros.Name = "nmRegistros";
            this.nmRegistros.Size = new System.Drawing.Size(95, 20);
            this.nmRegistros.TabIndex = 100;
            this.nmRegistros.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdNoLegalizados);
            this.groupBox2.Controls.Add(this.rdLegalizados);
            this.groupBox2.Controls.Add(this.rdTodos);
            this.groupBox2.Location = new System.Drawing.Point(373, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 40);
            this.groupBox2.TabIndex = 105;
            this.groupBox2.TabStop = false;
            // 
            // rdNoLegalizados
            // 
            this.rdNoLegalizados.AutoSize = true;
            this.rdNoLegalizados.Location = new System.Drawing.Point(277, 15);
            this.rdNoLegalizados.Name = "rdNoLegalizados";
            this.rdNoLegalizados.Size = new System.Drawing.Size(126, 17);
            this.rdNoLegalizados.TabIndex = 2;
            this.rdNoLegalizados.Text = "Traer No Legalizados";
            this.rdNoLegalizados.UseVisualStyleBackColor = true;
            // 
            // rdLegalizados
            // 
            this.rdLegalizados.AutoSize = true;
            this.rdLegalizados.Location = new System.Drawing.Point(123, 15);
            this.rdLegalizados.Name = "rdLegalizados";
            this.rdLegalizados.Size = new System.Drawing.Size(109, 17);
            this.rdLegalizados.TabIndex = 1;
            this.rdLegalizados.Text = "Traer Legalizados";
            this.rdLegalizados.UseVisualStyleBackColor = true;
            // 
            // rdTodos
            // 
            this.rdTodos.AutoSize = true;
            this.rdTodos.Checked = true;
            this.rdTodos.Location = new System.Drawing.Point(10, 15);
            this.rdTodos.Name = "rdTodos";
            this.rdTodos.Size = new System.Drawing.Size(55, 17);
            this.rdTodos.TabIndex = 0;
            this.rdTodos.TabStop = true;
            this.rdTodos.Text = "Todos";
            this.rdTodos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.cmbCampo);
            this.groupBox1.Controls.Add(this.txtCampo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 50);
            this.groupBox1.TabIndex = 106;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnBuscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBuscar.Location = new System.Drawing.Point(300, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(33, 33);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbCampo
            // 
            this.cmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampo.FormattingEnabled = true;
            this.cmbCampo.Items.AddRange(new object[] {
            "Numero Contrato",
            "Nit Cliente",
            "Cliente",
            "Numero Socio",
            "Modelos",
            "Fabricantes",
            "Serial",
            "Lineas de Consumo"});
            this.cmbCampo.Location = new System.Drawing.Point(8, 19);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(128, 21);
            this.cmbCampo.TabIndex = 1;
            // 
            // txtCampo
            // 
            this.txtCampo.Location = new System.Drawing.Point(142, 19);
            this.txtCampo.Name = "txtCampo";
            this.txtCampo.Size = new System.Drawing.Size(152, 20);
            this.txtCampo.TabIndex = 0;
            // 
            // chkLimitarNumeroResultados
            // 
            this.chkLimitarNumeroResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkLimitarNumeroResultados.AutoSize = true;
            this.chkLimitarNumeroResultados.Location = new System.Drawing.Point(598, 60);
            this.chkLimitarNumeroResultados.Name = "chkLimitarNumeroResultados";
            this.chkLimitarNumeroResultados.Size = new System.Drawing.Size(146, 17);
            this.chkLimitarNumeroResultados.TabIndex = 107;
            this.chkLimitarNumeroResultados.Text = "Registros en la busqueda";
            this.chkLimitarNumeroResultados.UseVisualStyleBackColor = true;
            // 
            // btnElimnarContrato
            // 
            this.btnElimnarContrato.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnElimnarContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnElimnarContrato.Image = ((System.Drawing.Image)(resources.GetObject("btnElimnarContrato.Image")));
            this.btnElimnarContrato.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnElimnarContrato.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnElimnarContrato.Location = new System.Drawing.Point(600, 89);
            this.btnElimnarContrato.Name = "btnElimnarContrato";
            this.btnElimnarContrato.Size = new System.Drawing.Size(28, 28);
            this.btnElimnarContrato.TabIndex = 108;
            this.btnElimnarContrato.Tooltip = "Eliminar Contrato";
            this.btnElimnarContrato.Click += new System.EventHandler(this.btnElimnarContrato_Click);
            // 
            // btnEditarEspecial
            // 
            this.btnEditarEspecial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarEspecial.Location = new System.Drawing.Point(425, 89);
            this.btnEditarEspecial.Name = "btnEditarEspecial";
            this.btnEditarEspecial.Size = new System.Drawing.Size(106, 23);
            this.btnEditarEspecial.TabIndex = 109;
            this.btnEditarEspecial.Text = "Editar Especial";
            this.btnEditarEspecial.UseVisualStyleBackColor = true;
            this.btnEditarEspecial.Click += new System.EventHandler(this.btnEditarEspecial_Click);
            // 
            // frmListadoContratosConsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(857, 480);
            this.Controls.Add(this.btnEditarEspecial);
            this.Controls.Add(this.btnElimnarContrato);
            this.Controls.Add(this.chkLimitarNumeroResultados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnNuevoContrato);
            this.Controls.Add(this.controladorColumnas1);
            this.Controls.Add(this.btnVerContrato);
            this.Controls.Add(this.nmRegistros);
            this.Controls.Add(this.grdDatos);
            this.Name = "frmListadoContratosConsumo";
            this.Text = "Listado Contratos Consumo";
            this.Load += new System.EventHandler(this.frmListadoContratosConsumo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContratoConsumo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmRegistros)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdDatos;
        private DevComponents.DotNetBar.ButtonX btnNuevoContrato;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas controladorColumnas1;
        private DevComponents.DotNetBar.ButtonX btnVerContrato;
        private System.Windows.Forms.NumericUpDown nmRegistros;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdNoLegalizados;
        private System.Windows.Forms.RadioButton rdLegalizados;
        private System.Windows.Forms.RadioButton rdTodos;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnBuscar;
        private System.Windows.Forms.ComboBox cmbCampo;
        private System.Windows.Forms.TextBox txtCampo;
        private System.Windows.Forms.CheckBox chkLimitarNumeroResultados;
        private SPControladoraDatos.dsContratoConsumo dsContratoConsumo1;
        private DevComponents.DotNetBar.ButtonX btnElimnarContrato;
        private System.Windows.Forms.Button btnEditarEspecial;
    }
}