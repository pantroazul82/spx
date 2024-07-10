namespace spProcesos.contratos_consumo
{
    partial class frmListadoConsumibles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoConsumibles));
            this.dsContratoConsumo1 = new SPControladoraDatos.dsContratoConsumo();
            this.btnEliminar = new DevComponents.DotNetBar.ButtonX();
            this.btnEditar = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregar = new DevComponents.DotNetBar.ButtonX();
            this.grdDatos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.consumiblesTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.consumiblesTableAdapter();
            this.pltConsumibleTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.pltConsumibleTableAdapter();
            this.btnCargueInformacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsContratoConsumo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dsContratoConsumo1
            // 
            this.dsContratoConsumo1.DataSetName = "dsContratoConsumo";
            this.dsContratoConsumo1.EnforceConstraints = false;
            this.dsContratoConsumo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnEliminar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnEliminar.Location = new System.Drawing.Point(523, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(33, 33);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnEditar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnEditar.Location = new System.Drawing.Point(484, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(33, 33);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnAgregar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAgregar.Location = new System.Drawing.Point(445, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(33, 33);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUpdate = false;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.DataMember = "pltConsumible";
            this.grdDatos.DataSource = this.dsContratoConsumo1;
            this.grdDatos.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdDatos.FilterBar = true;
            this.grdDatos.GroupByCaption = "";
            this.grdDatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDatos.Images"))));
            this.grdDatos.Location = new System.Drawing.Point(12, 51);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75D;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(542, 395);
            this.grdDatos.TabIndex = 12;
            this.grdDatos.Text = "c1TrueDBGrid1";
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
            // 
            // consumiblesTableAdapter1
            // 
            this.consumiblesTableAdapter1.ClearBeforeFill = true;
            // 
            // pltConsumibleTableAdapter1
            // 
            this.pltConsumibleTableAdapter1.ClearBeforeFill = true;
            // 
            // btnCargueInformacion
            // 
            this.btnCargueInformacion.Location = new System.Drawing.Point(256, 13);
            this.btnCargueInformacion.Name = "btnCargueInformacion";
            this.btnCargueInformacion.Size = new System.Drawing.Size(164, 23);
            this.btnCargueInformacion.TabIndex = 13;
            this.btnCargueInformacion.Text = "Cargue de Informacion";
            this.btnCargueInformacion.UseVisualStyleBackColor = true;
            this.btnCargueInformacion.Visible = false;
            this.btnCargueInformacion.Click += new System.EventHandler(this.btnCargueInformacion_Click);
            // 
            // frmListadoConsumibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(566, 458);
            this.Controls.Add(this.btnCargueInformacion);
            this.Controls.Add(this.grdDatos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmListadoConsumibles";
            this.Text = "Listado Consumibles";
            this.Load += new System.EventHandler(this.frmListadoConsumibles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsContratoConsumo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SPControladoraDatos.dsContratoConsumo dsContratoConsumo1;
        private DevComponents.DotNetBar.ButtonX btnEliminar;
        private DevComponents.DotNetBar.ButtonX btnEditar;
        private DevComponents.DotNetBar.ButtonX btnAgregar;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdDatos;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.consumiblesTableAdapter consumiblesTableAdapter1;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.pltConsumibleTableAdapter pltConsumibleTableAdapter1;
        private System.Windows.Forms.Button btnCargueInformacion;
    }
}