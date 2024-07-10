using SPControladoraDatos.artefactos.SPXQuery.data;

namespace SPControladoraDatos.artefactos.SPXQuery.frm.Query
{
    partial class frmQueryxUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQueryxUsuario));
            this.dsSPXQuery1 = new dsSPXQuery();
            this.dsSPXSeguridad1 = new SPXSeguridad.data.dsSPXSeguridad();
            this.usuarioTableAdapter1 = new SPXSeguridad.data.cls.clsTusuario();
            this.grupo_usuarioTableAdapter1 = new SPXSeguridad.data.cls.clsTgrupo_usuario();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExportarQuery = new DevComponents.DotNetBar.ButtonX();
            this.btnActualizarQuery = new DevComponents.DotNetBar.ButtonX();
            this.btnExportarGrupos = new DevComponents.DotNetBar.ButtonX();
            this.btnActualizarGrupos = new DevComponents.DotNetBar.ButtonX();
            this.btnExportarUsuarios = new DevComponents.DotNetBar.ButtonX();
            this.btnFinalizar = new DevComponents.DotNetBar.ButtonX();
            this.grdGrupos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.btnActualizarUsuarios = new DevComponents.DotNetBar.ButtonX();
            this.grdUsuario = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.grdQuery = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.panel1.SuspendLayout();
            this.contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXQuery1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(783, 23);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Location = new System.Drawing.Point(0, 473);
            this.panel1.Size = new System.Drawing.Size(808, 50);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(1175, 15);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1249, 15);
            // 
            // contenedor
            // 
            this.contenedor.Controls.Add(this.btnFinalizar);
            this.contenedor.Controls.Add(this.btnEditar);
            this.contenedor.Controls.Add(this.btnExportarQuery);
            this.contenedor.Controls.Add(this.btnActualizarQuery);
            this.contenedor.Controls.Add(this.btnExportarGrupos);
            this.contenedor.Controls.Add(this.btnActualizarGrupos);
            this.contenedor.Controls.Add(this.grdGrupos);
            this.contenedor.Controls.Add(this.btnExportarUsuarios);
            this.contenedor.Controls.Add(this.btnActualizarUsuarios);
            this.contenedor.Controls.Add(this.grdUsuario);
            this.contenedor.Controls.Add(this.grdQuery);
            this.contenedor.Size = new System.Drawing.Size(783, 433);
            // 
            // dsSPXQuery1
            // 
            this.dsSPXQuery1.DataSetName = "dsSPXQuery";
            this.dsSPXQuery1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsSPXSeguridad1
            // 
            this.dsSPXSeguridad1.DataSetName = "dsSPXSeguridad";
            this.dsSPXSeguridad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioTableAdapter1
            // 
            this.usuarioTableAdapter1.nombreLlave = "cod_usuario";
            this.usuarioTableAdapter1.nombreTabla = "usuario";
            this.usuarioTableAdapter1.sentenciaBase = resources.GetString("usuarioTableAdapter1.sentenciaBase");
            this.usuarioTableAdapter1.sentenciaBaseDistinct = null;
            // 
            // grupo_usuarioTableAdapter1
            // 
            this.grupo_usuarioTableAdapter1.nombreLlave = "cod_grupo_usuario";
            this.grupo_usuarioTableAdapter1.nombreTabla = "grupo_usuario";
            this.grupo_usuarioTableAdapter1.sentenciaBase = "SELECT distinct grupo_usuario.cod_grupo_usuario,grupo_usuario.nombre_grupo_usuari" +
    "o FROM grupo_usuario";
            this.grupo_usuarioTableAdapter1.sentenciaBaseDistinct = "SELECT distinct grupo_usuario.cod_grupo_usuario,grupo_usuario.nombre_grupo_usuari" +
    "o FROM grupo_usuario";
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Location = new System.Drawing.Point(384, 7);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(101, 26);
            this.btnEditar.TabIndex = 73;
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
            this.btnExportarQuery.Location = new System.Drawing.Point(350, 5);
            this.btnExportarQuery.Name = "btnExportarQuery";
            this.btnExportarQuery.Size = new System.Drawing.Size(28, 28);
            this.btnExportarQuery.TabIndex = 78;
            this.btnExportarQuery.Click += new System.EventHandler(this.btnExportarQuery_Click_1);
            // 
            // btnActualizarQuery
            // 
            this.btnActualizarQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnActualizarQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarQuery.Image")));
            this.btnActualizarQuery.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnActualizarQuery.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnActualizarQuery.Location = new System.Drawing.Point(320, 5);
            this.btnActualizarQuery.Name = "btnActualizarQuery";
            this.btnActualizarQuery.Size = new System.Drawing.Size(28, 28);
            this.btnActualizarQuery.TabIndex = 77;
            // 
            // btnExportarGrupos
            // 
            this.btnExportarGrupos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExportarGrupos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarGrupos.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarGrupos.Image")));
            this.btnExportarGrupos.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnExportarGrupos.Location = new System.Drawing.Point(746, 193);
            this.btnExportarGrupos.Name = "btnExportarGrupos";
            this.btnExportarGrupos.Size = new System.Drawing.Size(28, 28);
            this.btnExportarGrupos.TabIndex = 81;
            this.btnExportarGrupos.Click += new System.EventHandler(this.btnExportarGrupos_Click_1);
            // 
            // btnActualizarGrupos
            // 
            this.btnActualizarGrupos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnActualizarGrupos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarGrupos.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarGrupos.Image")));
            this.btnActualizarGrupos.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnActualizarGrupos.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnActualizarGrupos.Location = new System.Drawing.Point(718, 193);
            this.btnActualizarGrupos.Name = "btnActualizarGrupos";
            this.btnActualizarGrupos.Size = new System.Drawing.Size(28, 28);
            this.btnActualizarGrupos.TabIndex = 79;
            // 
            // btnExportarUsuarios
            // 
            this.btnExportarUsuarios.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExportarUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarUsuarios.Image")));
            this.btnExportarUsuarios.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnExportarUsuarios.Location = new System.Drawing.Point(745, 7);
            this.btnExportarUsuarios.Name = "btnExportarUsuarios";
            this.btnExportarUsuarios.Size = new System.Drawing.Size(28, 28);
            this.btnExportarUsuarios.TabIndex = 75;
            this.btnExportarUsuarios.Click += new System.EventHandler(this.btnExportarUsuarios_Click_1);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFinalizar.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnFinalizar.Location = new System.Drawing.Point(4, 5);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(80, 28);
            this.btnFinalizar.TabIndex = 82;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // grdGrupos
            // 
            this.grdGrupos.AllowUpdate = false;
            this.grdGrupos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdGrupos.DataMember = "grupo_usuario";
            this.grdGrupos.DataSource = this.dsSPXSeguridad1;
            this.grdGrupos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdGrupos.Images"))));
            this.grdGrupos.Location = new System.Drawing.Point(384, 227);
            this.grdGrupos.Name = "grdGrupos";
            this.grdGrupos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdGrupos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdGrupos.PreviewInfo.ZoomFactor = 75D;
            this.grdGrupos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdGrupos.PrintInfo.PageSettings")));
            this.grdGrupos.Size = new System.Drawing.Size(390, 203);
            this.grdGrupos.TabIndex = 80;
            this.grdGrupos.Text = "c1TrueDBGrid2";
            this.grdGrupos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Black;
            this.grdGrupos.PropBag = resources.GetString("grdGrupos.PropBag");
            // 
            // btnActualizarUsuarios
            // 
            this.btnActualizarUsuarios.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnActualizarUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarUsuarios.Image")));
            this.btnActualizarUsuarios.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnActualizarUsuarios.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnActualizarUsuarios.Location = new System.Drawing.Point(717, 7);
            this.btnActualizarUsuarios.Name = "btnActualizarUsuarios";
            this.btnActualizarUsuarios.Size = new System.Drawing.Size(28, 28);
            this.btnActualizarUsuarios.TabIndex = 72;
            // 
            // grdUsuario
            // 
            this.grdUsuario.AllowUpdate = false;
            this.grdUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grdUsuario.DataMember = "usuario";
            this.grdUsuario.DataSource = this.dsSPXSeguridad1;
            this.grdUsuario.Images.Add(((System.Drawing.Image)(resources.GetObject("grdUsuario.Images"))));
            this.grdUsuario.Location = new System.Drawing.Point(384, 39);
            this.grdUsuario.Name = "grdUsuario";
            this.grdUsuario.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdUsuario.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdUsuario.PreviewInfo.ZoomFactor = 75D;
            this.grdUsuario.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdUsuario.PrintInfo.PageSettings")));
            this.grdUsuario.Size = new System.Drawing.Size(389, 148);
            this.grdUsuario.TabIndex = 74;
            this.grdUsuario.Text = "c1TrueDBGrid2";
            this.grdUsuario.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Black;
            this.grdUsuario.PropBag = resources.GetString("grdUsuario.PropBag");
            // 
            // grdQuery
            // 
            this.grdQuery.AllowUpdate = false;
            this.grdQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdQuery.DataMember = "cgq_query";
            this.grdQuery.DataSource = this.dsSPXQuery1;
            this.grdQuery.FilterBar = true;
            this.grdQuery.Images.Add(((System.Drawing.Image)(resources.GetObject("grdQuery.Images"))));
            this.grdQuery.Location = new System.Drawing.Point(4, 36);
            this.grdQuery.Name = "grdQuery";
            this.grdQuery.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdQuery.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdQuery.PreviewInfo.ZoomFactor = 75D;
            this.grdQuery.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdQuery.PrintInfo.PageSettings")));
            this.grdQuery.Size = new System.Drawing.Size(374, 389);
            this.grdQuery.TabIndex = 71;
            this.grdQuery.Text = "c1TrueDBGrid1";
            this.grdQuery.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Black;
            this.grdQuery.RowColChange += new C1.Win.C1TrueDBGrid.RowColChangeEventHandler(this.grdQuery_RowColChange_1);
            this.grdQuery.PropBag = resources.GetString("grdQuery.PropBag");
            // 
            // frmQueryxUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 523);
            this.Name = "frmQueryxUsuario";
            this.Text = "Query x Usuario";
            this.Load += new System.EventHandler(this.frmQueryxUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.contenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXQuery1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdQuery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dsSPXQuery dsSPXQuery1;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad1;
        private SPXSeguridad.data.cls.clsTusuario usuarioTableAdapter1;
        private SPXSeguridad.data.cls.clsTgrupo_usuario grupo_usuarioTableAdapter1;
        private System.Windows.Forms.Button btnEditar;
        private DevComponents.DotNetBar.ButtonX btnExportarQuery;
        protected DevComponents.DotNetBar.ButtonX btnActualizarQuery;
        private DevComponents.DotNetBar.ButtonX btnExportarGrupos;
        protected DevComponents.DotNetBar.ButtonX btnActualizarGrupos;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdGrupos;
        private DevComponents.DotNetBar.ButtonX btnExportarUsuarios;
        protected DevComponents.DotNetBar.ButtonX btnActualizarUsuarios;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdUsuario;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdQuery;
        protected DevComponents.DotNetBar.ButtonX btnFinalizar;
    }
}