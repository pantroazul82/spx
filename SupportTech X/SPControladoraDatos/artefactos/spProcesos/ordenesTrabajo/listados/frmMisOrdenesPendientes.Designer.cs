namespace spProcesos.ordenesTrabajo
{
    partial class frmMisOrdenesPendientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMisOrdenesPendientes));
            this.rdExternas = new System.Windows.Forms.RadioButton();
            this.tdTodas = new System.Windows.Forms.RadioButton();
            this.rdInternas = new System.Windows.Forms.RadioButton();
            this.btnVerOrden = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuardarGrilla = new DevComponents.DotNetBar.ButtonX();
            this.btnReinicciargrilla = new DevComponents.DotNetBar.ButtonX();
            this.btnExportarExcel = new DevComponents.DotNetBar.ButtonX();
            this.grddatos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsPlantillas1 = new SPControladoraDatos.dsPlantillas();
            this.pltListadoOrdenServicioTableAdapter1 = new SPControladoraDatos.dsPlantillasTableAdapters.pltListadoOrdenServicioTableAdapter();
            this.groupBox1.SuspendLayout();
            this.grddatos.BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdExternas
            // 
            this.rdExternas.AutoSize = true;
            this.rdExternas.Location = new System.Drawing.Point(242, 14);
            this.rdExternas.Name = "rdExternas";
            this.rdExternas.Size = new System.Drawing.Size(108, 17);
            this.rdExternas.TabIndex = 2;
            this.rdExternas.Text = "Ordenes Externas";
            this.rdExternas.UseVisualStyleBackColor = true;
            this.rdExternas.CheckedChanged += new System.EventHandler(this.rdExternas_CheckedChanged);
            // 
            // tdTodas
            // 
            this.tdTodas.AutoSize = true;
            this.tdTodas.Checked = true;
            this.tdTodas.Location = new System.Drawing.Point(9, 14);
            this.tdTodas.Name = "tdTodas";
            this.tdTodas.Size = new System.Drawing.Size(115, 17);
            this.tdTodas.TabIndex = 3;
            this.tdTodas.TabStop = true;
            this.tdTodas.Text = "Internas y Externas";
            this.tdTodas.UseVisualStyleBackColor = true;
            this.tdTodas.CheckedChanged += new System.EventHandler(this.tdTodas_CheckedChanged);
            // 
            // rdInternas
            // 
            this.rdInternas.AutoSize = true;
            this.rdInternas.Location = new System.Drawing.Point(130, 14);
            this.rdInternas.Name = "rdInternas";
            this.rdInternas.Size = new System.Drawing.Size(107, 17);
            this.rdInternas.TabIndex = 4;
            this.rdInternas.Text = "Ordenes Internas";
            this.rdInternas.UseVisualStyleBackColor = true;
            this.rdInternas.CheckedChanged += new System.EventHandler(this.rdInternas_CheckedChanged);
            // 
            // btnVerOrden
            // 
            this.btnVerOrden.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVerOrden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerOrden.Image = ((System.Drawing.Image)(resources.GetObject("btnVerOrden.Image")));
            this.btnVerOrden.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnVerOrden.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnVerOrden.Location = new System.Drawing.Point(735, 12);
            this.btnVerOrden.Name = "btnVerOrden";
            this.btnVerOrden.Size = new System.Drawing.Size(33, 33);
            this.btnVerOrden.TabIndex = 14;
            this.btnVerOrden.Click += new System.EventHandler(this.btnVerOrden_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tdTodas);
            this.groupBox1.Controls.Add(this.rdExternas);
            this.groupBox1.Controls.Add(this.rdInternas);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 35);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // btnGuardarGrilla
            // 
            this.btnGuardarGrilla.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGuardarGrilla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarGrilla.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarGrilla.Image")));
            this.btnGuardarGrilla.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnGuardarGrilla.Location = new System.Drawing.Point(806, 12);
            this.btnGuardarGrilla.Name = "btnGuardarGrilla";
            this.btnGuardarGrilla.Size = new System.Drawing.Size(33, 33);
            this.btnGuardarGrilla.TabIndex = 75;
            this.btnGuardarGrilla.Click += new System.EventHandler(this.btnGuardarGrilla_Click);
            // 
            // btnReinicciargrilla
            // 
            this.btnReinicciargrilla.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReinicciargrilla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReinicciargrilla.Image = ((System.Drawing.Image)(resources.GetObject("btnReinicciargrilla.Image")));
            this.btnReinicciargrilla.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnReinicciargrilla.Location = new System.Drawing.Point(771, 12);
            this.btnReinicciargrilla.Name = "btnReinicciargrilla";
            this.btnReinicciargrilla.Size = new System.Drawing.Size(33, 33);
            this.btnReinicciargrilla.TabIndex = 74;
            this.btnReinicciargrilla.Click += new System.EventHandler(this.btnReinicciargrilla_Click);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExportarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarExcel.Image")));
            this.btnExportarExcel.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnExportarExcel.Location = new System.Drawing.Point(842, 12);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(33, 33);
            this.btnExportarExcel.TabIndex = 72;
            this.btnExportarExcel.Text = " ";
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click_1);
            // 
            // grddatos
            // 
            this.grddatos.AllowUpdate = false;
            this.grddatos.AlternatingRows = true;
            this.grddatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grddatos.CaptionHeight = 17;
            this.grddatos.DataMember = "pltListadoOrdenServicio";
            this.grddatos.DataSource = this.dsPlantillas1;
            this.grddatos.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grddatos.FilterBar = true;
            this.grddatos.GroupByCaption = "";
            this.grddatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grddatos.Images"))));
            this.grddatos.Location = new System.Drawing.Point(12, 51);
            this.grddatos.Name = "grddatos";
            this.grddatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grddatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grddatos.PreviewInfo.ZoomFactor = 75;
            this.grddatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grddatos.PrintInfo.PageSettings")));
            this.grddatos.RowHeight = 15;
            this.grddatos.Size = new System.Drawing.Size(863, 499);
            this.grddatos.TabIndex = 0;
            this.grddatos.Text = "c1TrueDBGrid1";
            this.grddatos.PropBag = resources.GetString("grddatos.PropBag");
            // 
            // dsPlantillas1
            // 
            this.dsPlantillas1.DataSetName = "dsPlantillas";
            this.dsPlantillas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pltListadoOrdenServicioTableAdapter1
            // 
            this.pltListadoOrdenServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // frmMisOrdenesPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.btnGuardarGrilla);
            this.Controls.Add(this.btnReinicciargrilla);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVerOrden);
            this.Controls.Add(this.grddatos);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMisOrdenesPendientes";
            this.Text = "Mis Ordenes Pendientes";
            this.Load += new System.EventHandler(this.frmMisOrdenesPendientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grddatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grddatos;
        private System.Windows.Forms.RadioButton rdExternas;
        private System.Windows.Forms.RadioButton tdTodas;
        private System.Windows.Forms.RadioButton rdInternas;
        private DevComponents.DotNetBar.ButtonX btnVerOrden;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdProgramadas;
        private DevComponents.DotNetBar.ButtonX btnGuardarGrilla;
        private DevComponents.DotNetBar.ButtonX btnReinicciargrilla;
        private DevComponents.DotNetBar.ButtonX btnExportarExcel;
        private SPControladoraDatos.dsPlantillas dsPlantillas1;
        private SPControladoraDatos.dsPlantillasTableAdapters.pltListadoOrdenServicioTableAdapter pltListadoOrdenServicioTableAdapter1;
    }
}