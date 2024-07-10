namespace spProcesos.contratos_consumo
{
    partial class frmListadoComparativo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoComparativo));
            this.chkLimitarNumeroResultados = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.txtCampo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdNoLegalizados = new System.Windows.Forms.RadioButton();
            this.rdLegalizados = new System.Windows.Forms.RadioButton();
            this.rdTodos = new System.Windows.Forms.RadioButton();
            this.controladorColumnas1 = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas();
            this.nmRegistros = new System.Windows.Forms.NumericUpDown();
            this.btnVerContrato = new DevComponents.DotNetBar.ButtonX();
            this.grdDatos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.chkOmitir = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // chkLimitarNumeroResultados
            // 
            this.chkLimitarNumeroResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkLimitarNumeroResultados.AutoSize = true;
            this.chkLimitarNumeroResultados.Location = new System.Drawing.Point(261, 5);
            this.chkLimitarNumeroResultados.Name = "chkLimitarNumeroResultados";
            this.chkLimitarNumeroResultados.Size = new System.Drawing.Size(146, 17);
            this.chkLimitarNumeroResultados.TabIndex = 115;
            this.chkLimitarNumeroResultados.Text = "Registros en la busqueda";
            this.chkLimitarNumeroResultados.UseVisualStyleBackColor = true;
            this.chkLimitarNumeroResultados.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.cmbCampo);
            this.groupBox1.Controls.Add(this.txtCampo);
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 50);
            this.groupBox1.TabIndex = 114;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            this.groupBox1.Visible = false;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdNoLegalizados);
            this.groupBox2.Controls.Add(this.rdLegalizados);
            this.groupBox2.Controls.Add(this.rdTodos);
            this.groupBox2.Location = new System.Drawing.Point(20, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 40);
            this.groupBox2.TabIndex = 113;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
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
            // controladorColumnas1
            // 
            this.controladorColumnas1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controladorColumnas1.BackColor = System.Drawing.Color.Transparent;
            this.controladorColumnas1.grilla = null;
            this.controladorColumnas1.Location = new System.Drawing.Point(629, 18);
            this.controladorColumnas1.MostrarContraer = true;
            this.controladorColumnas1.MostrarExcel = true;
            this.controladorColumnas1.MostrarExpandir = true;
            this.controladorColumnas1.MostrarLimpiar = true;
            this.controladorColumnas1.Name = "controladorColumnas1";
            this.controladorColumnas1.nombreLibro = null;
            this.controladorColumnas1.Size = new System.Drawing.Size(216, 29);
            this.controladorColumnas1.TabIndex = 111;
            // 
            // nmRegistros
            // 
            this.nmRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nmRegistros.Location = new System.Drawing.Point(413, 2);
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
            this.nmRegistros.TabIndex = 109;
            this.nmRegistros.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nmRegistros.Visible = false;
            // 
            // btnVerContrato
            // 
            this.btnVerContrato.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVerContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerContrato.Image = ((System.Drawing.Image)(resources.GetObject("btnVerContrato.Image")));
            this.btnVerContrato.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnVerContrato.Location = new System.Drawing.Point(496, 19);
            this.btnVerContrato.Name = "btnVerContrato";
            this.btnVerContrato.Size = new System.Drawing.Size(130, 28);
            this.btnVerContrato.TabIndex = 110;
            this.btnVerContrato.Text = "Ver Diferencias";
            this.btnVerContrato.Tooltip = "Ver Contrato";
            this.btnVerContrato.Click += new System.EventHandler(this.btnVerContrato_Click);
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUpdate = false;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdDatos.FilterBar = true;
            this.grdDatos.GroupByCaption = "";
            this.grdDatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDatos.Images"))));
            this.grdDatos.Location = new System.Drawing.Point(12, 74);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75D;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(833, 400);
            this.grdDatos.TabIndex = 108;
            this.grdDatos.Text = "c1TrueDBGrid1";
            this.grdDatos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
            // 
            // chkOmitir
            // 
            this.chkOmitir.AutoSize = true;
            this.chkOmitir.Location = new System.Drawing.Point(691, 1);
            this.chkOmitir.Name = "chkOmitir";
            this.chkOmitir.Size = new System.Drawing.Size(153, 17);
            this.chkOmitir.TabIndex = 116;
            this.chkOmitir.Text = "Omitir Equipos de Computo";
            this.chkOmitir.UseVisualStyleBackColor = true;
            // 
            // frmListadoComparativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(857, 480);
            this.Controls.Add(this.chkOmitir);
            this.Controls.Add(this.chkLimitarNumeroResultados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.controladorColumnas1);
            this.Controls.Add(this.btnVerContrato);
            this.Controls.Add(this.nmRegistros);
            this.Controls.Add(this.grdDatos);
            this.Name = "frmListadoComparativo";
            this.Text = "Listado Comparativo";
            this.Load += new System.EventHandler(this.frmListadoComparativo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkLimitarNumeroResultados;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnBuscar;
        private System.Windows.Forms.ComboBox cmbCampo;
        private System.Windows.Forms.TextBox txtCampo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdNoLegalizados;
        private System.Windows.Forms.RadioButton rdLegalizados;
        private System.Windows.Forms.RadioButton rdTodos;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas controladorColumnas1;
        private DevComponents.DotNetBar.ButtonX btnVerContrato;
        private System.Windows.Forms.NumericUpDown nmRegistros;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdDatos;
        private System.Windows.Forms.CheckBox chkOmitir;
    }
}