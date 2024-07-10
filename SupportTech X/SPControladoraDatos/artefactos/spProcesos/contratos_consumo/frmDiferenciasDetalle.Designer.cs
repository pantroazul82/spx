namespace spProcesos.contratos_consumo
{
    partial class frmDiferenciasDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiferenciasDetalle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grdDatos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.grdContratos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsContratoConsumo1 = new SPControladoraDatos.dsContratoConsumo();
            this.vistaEquipoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.vistaEquipoTableAdapter();
            this.pltEquiposxContratoTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.pltEquiposxContratoTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdContratos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContratoConsumo1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 385);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 45);
            this.panel1.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(825, 10);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Equipos Ingenieria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Equipos Contrato";
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUpdate = false;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grdDatos.DataMember = "vistaEquipo";
            this.grdDatos.DataSource = this.dsSpx1;
            this.grdDatos.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdDatos.FetchRowStyles = true;
            this.grdDatos.GroupByCaption = "";
            this.grdDatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDatos.Images"))));
            this.grdDatos.Location = new System.Drawing.Point(12, 29);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75D;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(487, 333);
            this.grdDatos.TabIndex = 109;
            this.grdDatos.Text = "c1TrueDBGrid1";
            this.grdDatos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.grdDatos.FetchRowStyle += new C1.Win.C1TrueDBGrid.FetchRowStyleEventHandler(this.grdDatos_FetchRowStyle);
            this.grdDatos.Sort += new C1.Win.C1TrueDBGrid.FilterEventHandler(this.grdDatos_Sort);
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.EnforceConstraints = false;
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdContratos
            // 
            this.grdContratos.AllowUpdate = false;
            this.grdContratos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdContratos.DataMember = "pltEquiposxContrato";
            this.grdContratos.DataSource = this.dsContratoConsumo1;
            this.grdContratos.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdContratos.FetchRowStyles = true;
            this.grdContratos.GroupByCaption = "";
            this.grdContratos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdContratos.Images"))));
            this.grdContratos.Location = new System.Drawing.Point(509, 29);
            this.grdContratos.Name = "grdContratos";
            this.grdContratos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdContratos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdContratos.PreviewInfo.ZoomFactor = 75D;
            this.grdContratos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdContratos.PrintInfo.PageSettings")));
            this.grdContratos.Size = new System.Drawing.Size(391, 333);
            this.grdContratos.TabIndex = 110;
            this.grdContratos.Text = "c1TrueDBGrid1";
            this.grdContratos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.grdContratos.FetchRowStyle += new C1.Win.C1TrueDBGrid.FetchRowStyleEventHandler(this.grdContratos_FetchRowStyle);
            this.grdContratos.Sort += new C1.Win.C1TrueDBGrid.FilterEventHandler(this.c1TrueDBGrid1_Sort);
            this.grdContratos.PropBag = resources.GetString("grdContratos.PropBag");
            // 
            // dsContratoConsumo1
            // 
            this.dsContratoConsumo1.DataSetName = "dsContratoConsumo";
            this.dsContratoConsumo1.EnforceConstraints = false;
            this.dsContratoConsumo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaEquipoTableAdapter1
            // 
            this.vistaEquipoTableAdapter1.ClearBeforeFill = true;
            // 
            // pltEquiposxContratoTableAdapter1
            // 
            this.pltEquiposxContratoTableAdapter1.ClearBeforeFill = true;
            // 
            // frmDiferenciasDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 430);
            this.Controls.Add(this.grdContratos);
            this.Controls.Add(this.grdDatos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frmDiferenciasDetalle";
            this.Text = "Diferencias Detalle";
            this.Load += new System.EventHandler(this.frmDiferenciasDetalle_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdContratos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContratoConsumo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdDatos;
        private SPControladoraDatos.dsSpx dsSpx1;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdContratos;
        private SPControladoraDatos.dsContratoConsumo dsContratoConsumo1;
        private SPControladoraDatos.dsSpxTableAdapters.vistaEquipoTableAdapter vistaEquipoTableAdapter1;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.pltEquiposxContratoTableAdapter pltEquiposxContratoTableAdapter1;
    }
}