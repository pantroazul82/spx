namespace spProcesos.cientifica.proceso
{
    partial class frmTareasAsesorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTareasAsesorias));
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.grdDAtos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.btnExportarExcel = new DevComponents.DotNetBar.ButtonX();
            this.btnEliminar = new DevComponents.DotNetBar.ButtonX();
            this.btnEditar = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregar = new DevComponents.DotNetBar.ButtonX();
            this.tarea_asesoria_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.tarea_asesoria_cientificaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.grdDAtos.BeginInit();
            this.SuspendLayout();
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdDAtos
            // 
            this.grdDAtos.AllowUpdate = false;
            this.grdDAtos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDAtos.DataMember = "tarea_asesoria_cientifica";
            this.grdDAtos.DataSource = this.dsSpx1;
            this.grdDAtos.FilterBar = true;
            this.grdDAtos.GroupByCaption = "Drag a column header here to group by that column";
            this.grdDAtos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDAtos.Images"))));
            this.grdDAtos.Location = new System.Drawing.Point(13, 43);
            this.grdDAtos.Name = "grdDAtos";
            this.grdDAtos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDAtos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDAtos.PreviewInfo.ZoomFactor = 75D;
            this.grdDAtos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDAtos.PrintInfo.PageSettings")));
            this.grdDAtos.Size = new System.Drawing.Size(530, 433);
            this.grdDAtos.TabIndex = 0;
            this.grdDAtos.Text = "c1TrueDBGrid1";
            this.grdDAtos.PropBag = resources.GetString("grdDAtos.PropBag");
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExportarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarExcel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExportarExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarExcel.Image")));
            this.btnExportarExcel.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnExportarExcel.Location = new System.Drawing.Point(516, 9);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(28, 28);
            this.btnExportarExcel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExportarExcel.TabIndex = 13;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageFixedSize = new System.Drawing.Size(18, 18);
            this.btnEliminar.Location = new System.Drawing.Point(482, 9);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(28, 28);
            this.btnEliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnEditar.Location = new System.Drawing.Point(448, 9);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(28, 28);
            this.btnEditar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnAgregar.Location = new System.Drawing.Point(414, 9);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(28, 28);
            this.btnAgregar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tarea_asesoria_cientificaTableAdapter1
            // 
            this.tarea_asesoria_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // frmTareasAsesorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 488);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grdDAtos);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(571, 526);
            this.MinimumSize = new System.Drawing.Size(571, 526);
            this.Name = "frmTareasAsesorias";
            this.Text = "Tareas Asesorias";
            this.Load += new System.EventHandler(this.frmTareasAsesorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDAtos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SPControladoraDatos.dsSpx dsSpx1;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdDAtos;
        private DevComponents.DotNetBar.ButtonX btnExportarExcel;
        private DevComponents.DotNetBar.ButtonX btnEliminar;
        private DevComponents.DotNetBar.ButtonX btnEditar;
        private DevComponents.DotNetBar.ButtonX btnAgregar;
        private SPControladoraDatos.dsSpxTableAdapters.tarea_asesoria_cientificaTableAdapter tarea_asesoria_cientificaTableAdapter1;
    }
}