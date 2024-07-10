namespace spProcesos.llamadasTecnicas
{
    partial class frmListadoREsFinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoREsFinal));
            this.grdDAtos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.btnDelIndicaciones = new DevComponents.DotNetBar.ButtonX();
            this.btnEditIndicaciones = new DevComponents.DotNetBar.ButtonX();
            this.btnAddIndicaciones = new DevComponents.DotNetBar.ButtonX();
            this.resultado_final_llamadaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.resultado_final_llamadaTableAdapter();
            this.grdDAtos.BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDAtos
            // 
            this.grdDAtos.AllowUpdate = false;
            this.grdDAtos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDAtos.DataMember = "resultado_final_llamada";
            this.grdDAtos.DataSource = this.dsSpx1;
            this.grdDAtos.FilterBar = true;
            this.grdDAtos.GroupByCaption = "Drag a column header here to group by that column";
            this.grdDAtos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDAtos.Images"))));
            this.grdDAtos.Location = new System.Drawing.Point(12, 71);
            this.grdDAtos.Name = "grdDAtos";
            this.grdDAtos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDAtos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDAtos.PreviewInfo.ZoomFactor = 75D;
            this.grdDAtos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDAtos.PrintInfo.PageSettings")));
            this.grdDAtos.Size = new System.Drawing.Size(650, 365);
            this.grdDAtos.TabIndex = 0;
            this.grdDAtos.Text = "c1TrueDBGrid1";
            this.grdDAtos.PropBag = resources.GetString("grdDAtos.PropBag");
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDelIndicaciones
            // 
            this.btnDelIndicaciones.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelIndicaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelIndicaciones.Image = ((System.Drawing.Image)(resources.GetObject("btnDelIndicaciones.Image")));
            this.btnDelIndicaciones.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnDelIndicaciones.Location = new System.Drawing.Point(633, 36);
            this.btnDelIndicaciones.Name = "btnDelIndicaciones";
            this.btnDelIndicaciones.Size = new System.Drawing.Size(29, 29);
            this.btnDelIndicaciones.TabIndex = 41;
            this.btnDelIndicaciones.Click += new System.EventHandler(this.btnDelIndicaciones_Click);
            // 
            // btnEditIndicaciones
            // 
            this.btnEditIndicaciones.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEditIndicaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditIndicaciones.Image = ((System.Drawing.Image)(resources.GetObject("btnEditIndicaciones.Image")));
            this.btnEditIndicaciones.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnEditIndicaciones.Location = new System.Drawing.Point(598, 36);
            this.btnEditIndicaciones.Name = "btnEditIndicaciones";
            this.btnEditIndicaciones.Size = new System.Drawing.Size(29, 29);
            this.btnEditIndicaciones.TabIndex = 40;
            this.btnEditIndicaciones.Click += new System.EventHandler(this.btnEditIndicaciones_Click);
            // 
            // btnAddIndicaciones
            // 
            this.btnAddIndicaciones.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddIndicaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddIndicaciones.Image = ((System.Drawing.Image)(resources.GetObject("btnAddIndicaciones.Image")));
            this.btnAddIndicaciones.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnAddIndicaciones.Location = new System.Drawing.Point(563, 36);
            this.btnAddIndicaciones.Name = "btnAddIndicaciones";
            this.btnAddIndicaciones.Size = new System.Drawing.Size(29, 29);
            this.btnAddIndicaciones.TabIndex = 39;
            this.btnAddIndicaciones.Click += new System.EventHandler(this.btnAddIndicaciones_Click);
            // 
            // resultado_final_llamadaTableAdapter1
            // 
            this.resultado_final_llamadaTableAdapter1.ClearBeforeFill = true;
            // 
            // frmListadoREsFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(674, 448);
            this.Controls.Add(this.btnDelIndicaciones);
            this.Controls.Add(this.btnEditIndicaciones);
            this.Controls.Add(this.btnAddIndicaciones);
            this.Controls.Add(this.grdDAtos);
            this.Name = "frmListadoREsFinal";
            this.Text = "Listado Resultado Final Llamada";
            this.Load += new System.EventHandler(this.frmListadoREsFinal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDAtos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdDAtos;
        private SPControladoraDatos.dsSpx dsSpx1;
        private DevComponents.DotNetBar.ButtonX btnDelIndicaciones;
        private DevComponents.DotNetBar.ButtonX btnEditIndicaciones;
        private DevComponents.DotNetBar.ButtonX btnAddIndicaciones;
        private SPControladoraDatos.dsSpxTableAdapters.resultado_final_llamadaTableAdapter resultado_final_llamadaTableAdapter1;
    }
}