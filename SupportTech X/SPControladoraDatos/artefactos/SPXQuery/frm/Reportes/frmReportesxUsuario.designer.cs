using SPControladoraDatos.artefactos.SPXQuery.data;

namespace SPControladoraDatos.artefactos.SPXQuery.frm.Reportes
{
    partial class frmReportesxUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportesxUsuario));
            this.dsGrillas = new dsSPXQuery();
            this.rptxusuarioTableAdapter1 = new data.dsSPXQueryTableAdapters.rptxusuarioTableAdapter();
            this.rptTableAdapter1 = new data.dsSPXQueryTableAdapters.rptTableAdapter();
            this.usuarioTableAdapter1 = new SPXSeguridad.data.cls.clsTusuario();
            this.dsSPXSeguridad1 = new SPXSeguridad.data.dsSPXSeguridad();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExportarQuery = new DevComponents.DotNetBar.ButtonX();
            this.btnActualizarReporte = new DevComponents.DotNetBar.ButtonX();
            this.btnExportarGrupos = new DevComponents.DotNetBar.ButtonX();
            this.btnActualizarGrupos = new DevComponents.DotNetBar.ButtonX();
            this.grdGrupos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.btnExportarUsuarios = new DevComponents.DotNetBar.ButtonX();
            this.btnActualizarUsuarios = new DevComponents.DotNetBar.ButtonX();
            this.grdUsuario = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.grdDatos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.grupo_usuarioTableAdapter1 = new SPXSeguridad.data.cls.clsTgrupo_usuario();
            this.btnFinalizar = new DevComponents.DotNetBar.ButtonX();
            this.panel1.SuspendLayout();
            this.contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsGrillas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 465);
            this.panel1.Size = new System.Drawing.Size(784, 50);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(623, 15);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(697, 15);
            // 
            // contenedor
            // 
            this.contenedor.Controls.Add(this.btnFinalizar);
            this.contenedor.Controls.Add(this.btnEditar);
            this.contenedor.Controls.Add(this.btnExportarQuery);
            this.contenedor.Controls.Add(this.btnActualizarReporte);
            this.contenedor.Controls.Add(this.btnExportarGrupos);
            this.contenedor.Controls.Add(this.btnActualizarGrupos);
            this.contenedor.Controls.Add(this.grdGrupos);
            this.contenedor.Controls.Add(this.btnExportarUsuarios);
            this.contenedor.Controls.Add(this.btnActualizarUsuarios);
            this.contenedor.Controls.Add(this.grdUsuario);
            this.contenedor.Controls.Add(this.grdDatos);
            this.contenedor.Size = new System.Drawing.Size(759, 425);
            // 
            // dsGrillas
            // 
            this.dsGrillas.DataSetName = "dsSPXQuery";
            this.dsGrillas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptxusuarioTableAdapter1
            // 
            this.rptxusuarioTableAdapter1.ClearBeforeFill = true;
            // 
            // rptTableAdapter1
            // 
            this.rptTableAdapter1.ClearBeforeFill = true;
            // 
            // dsSPXSeguridad1
            // 
            this.dsSPXSeguridad1.DataSetName = "dsSPXSeguridad";
            this.dsSPXSeguridad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Location = new System.Drawing.Point(396, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(105, 26);
            this.btnEditar.TabIndex = 84;
            this.btnEditar.Text = "Editar Relaciones";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExportarQuery
            // 
            this.btnExportarQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExportarQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarQuery.Image")));
            this.btnExportarQuery.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnExportarQuery.Location = new System.Drawing.Point(349, 5);
            this.btnExportarQuery.Name = "btnExportarQuery";
            this.btnExportarQuery.Size = new System.Drawing.Size(28, 28);
            this.btnExportarQuery.TabIndex = 88;
            this.btnExportarQuery.Click += new System.EventHandler(this.btnExportarQuery_Click);
            // 
            // btnActualizarReporte
            // 
            this.btnActualizarReporte.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnActualizarReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarReporte.Image")));
            this.btnActualizarReporte.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnActualizarReporte.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnActualizarReporte.Location = new System.Drawing.Point(320, 5);
            this.btnActualizarReporte.Name = "btnActualizarReporte";
            this.btnActualizarReporte.Size = new System.Drawing.Size(28, 28);
            this.btnActualizarReporte.TabIndex = 87;
            this.btnActualizarReporte.Click += new System.EventHandler(this.btnActualizarReporte_Click);
            // 
            // btnExportarGrupos
            // 
            this.btnExportarGrupos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExportarGrupos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarGrupos.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarGrupos.Image")));
            this.btnExportarGrupos.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnExportarGrupos.Location = new System.Drawing.Point(728, 191);
            this.btnExportarGrupos.Name = "btnExportarGrupos";
            this.btnExportarGrupos.Size = new System.Drawing.Size(28, 28);
            this.btnExportarGrupos.TabIndex = 91;
            this.btnExportarGrupos.Click += new System.EventHandler(this.btnExportarGrupos_Click);
            // 
            // btnActualizarGrupos
            // 
            this.btnActualizarGrupos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnActualizarGrupos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarGrupos.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarGrupos.Image")));
            this.btnActualizarGrupos.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnActualizarGrupos.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnActualizarGrupos.Location = new System.Drawing.Point(700, 191);
            this.btnActualizarGrupos.Name = "btnActualizarGrupos";
            this.btnActualizarGrupos.Size = new System.Drawing.Size(28, 28);
            this.btnActualizarGrupos.TabIndex = 89;
            this.btnActualizarGrupos.Click += new System.EventHandler(this.btnActualizarGrupos_Click);
            // 
            // grdGrupos
            // 
            this.grdGrupos.AllowUpdate = false;
            this.grdGrupos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdGrupos.DataMember = "grupo_usuario";
            this.grdGrupos.DataSource = this.dsSPXSeguridad1;
            this.grdGrupos.GroupByCaption = "Drag a column header here to group by that column";
            this.grdGrupos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdGrupos.Images"))));
            this.grdGrupos.Location = new System.Drawing.Point(396, 225);
            this.grdGrupos.Name = "grdGrupos";
            this.grdGrupos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdGrupos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdGrupos.PreviewInfo.ZoomFactor = 75D;
            this.grdGrupos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdGrupos.PrintInfo.PageSettings")));
            this.grdGrupos.Size = new System.Drawing.Size(360, 184);
            this.grdGrupos.TabIndex = 90;
            this.grdGrupos.Text = "c1TrueDBGrid2";
            this.grdGrupos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Black;
            this.grdGrupos.PropBag = resources.GetString("grdGrupos.PropBag");
            // 
            // btnExportarUsuarios
            // 
            this.btnExportarUsuarios.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExportarUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarUsuarios.Image")));
            this.btnExportarUsuarios.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnExportarUsuarios.Location = new System.Drawing.Point(728, 5);
            this.btnExportarUsuarios.Name = "btnExportarUsuarios";
            this.btnExportarUsuarios.Size = new System.Drawing.Size(28, 28);
            this.btnExportarUsuarios.TabIndex = 86;
            this.btnExportarUsuarios.Click += new System.EventHandler(this.btnExportarUsuarios_Click);
            // 
            // btnActualizarUsuarios
            // 
            this.btnActualizarUsuarios.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnActualizarUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarUsuarios.Image")));
            this.btnActualizarUsuarios.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnActualizarUsuarios.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnActualizarUsuarios.Location = new System.Drawing.Point(700, 5);
            this.btnActualizarUsuarios.Name = "btnActualizarUsuarios";
            this.btnActualizarUsuarios.Size = new System.Drawing.Size(28, 28);
            this.btnActualizarUsuarios.TabIndex = 83;
            this.btnActualizarUsuarios.Click += new System.EventHandler(this.btnActualizarUsuarios_Click);
            // 
            // grdUsuario
            // 
            this.grdUsuario.AllowUpdate = false;
            this.grdUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grdUsuario.DataMember = "usuario";
            this.grdUsuario.DataSource = this.dsSPXSeguridad1;
            this.grdUsuario.GroupByCaption = "Drag a column header here to group by that column";
            this.grdUsuario.Images.Add(((System.Drawing.Image)(resources.GetObject("grdUsuario.Images"))));
            this.grdUsuario.Location = new System.Drawing.Point(395, 37);
            this.grdUsuario.Name = "grdUsuario";
            this.grdUsuario.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdUsuario.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdUsuario.PreviewInfo.ZoomFactor = 75D;
            this.grdUsuario.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdUsuario.PrintInfo.PageSettings")));
            this.grdUsuario.Size = new System.Drawing.Size(361, 148);
            this.grdUsuario.TabIndex = 85;
            this.grdUsuario.Text = "c1TrueDBGrid2";
            this.grdUsuario.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Black;
            this.grdUsuario.PropBag = resources.GetString("grdUsuario.PropBag");
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUpdate = false;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.DataMember = "rpt";
            this.grdDatos.DataSource = this.dsGrillas;
            this.grdDatos.FilterBar = true;
            this.grdDatos.GroupByCaption = "Drag a column header here to group by that column";
            this.grdDatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDatos.Images"))));
            this.grdDatos.Location = new System.Drawing.Point(4, 36);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75D;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(373, 373);
            this.grdDatos.TabIndex = 82;
            this.grdDatos.Text = "c1TrueDBGrid1";
            this.grdDatos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Black;
            this.grdDatos.RowColChange += new C1.Win.C1TrueDBGrid.RowColChangeEventHandler(this.grdDatos_RowColChange);
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
              // 
            // btnFinalizar
            // 
            this.btnFinalizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFinalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnFinalizar.Image")));
            this.btnFinalizar.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnFinalizar.Location = new System.Drawing.Point(4, 5);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(80, 28);
            this.btnFinalizar.TabIndex = 92;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // frmReportesxUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 515);
            this.Name = "frmReportesxUsuario";
            this.Text = "Reporte x Usuario";
            this.Load += new System.EventHandler(this.frmReportesxUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.contenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsGrillas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dsSPXQuery dsGrillas;
        private data.dsSPXQueryTableAdapters.rptxusuarioTableAdapter rptxusuarioTableAdapter1;
        private data.dsSPXQueryTableAdapters.rptTableAdapter rptTableAdapter1;
       // private dsSPXQuery.rptxusuarioDataTable rptxusuarioTableAdapter1;
        //private dsSPXQuery.rptDataTable rptTableAdapter1;
        private SPXSeguridad.data.cls.clsTusuario usuarioTableAdapter1;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad1;
        private System.Windows.Forms.Button btnEditar;
        private DevComponents.DotNetBar.ButtonX btnExportarQuery;
        protected DevComponents.DotNetBar.ButtonX btnActualizarReporte;
        private DevComponents.DotNetBar.ButtonX btnExportarGrupos;
        protected DevComponents.DotNetBar.ButtonX btnActualizarGrupos;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdGrupos;
        private DevComponents.DotNetBar.ButtonX btnExportarUsuarios;
        protected DevComponents.DotNetBar.ButtonX btnActualizarUsuarios;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdUsuario;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdDatos;
        private SPXSeguridad.data.cls.clsTgrupo_usuario grupo_usuarioTableAdapter1;
        protected DevComponents.DotNetBar.ButtonX btnFinalizar;
    }
}