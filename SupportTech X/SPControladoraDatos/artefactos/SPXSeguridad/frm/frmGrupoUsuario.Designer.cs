namespace SPXSeguridad.frm
{
    partial class frmGrupoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrupoUsuario));
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.btnAgregar = new DevComponents.DotNetBar.ButtonX();
            this.btnEditarGrupo = new DevComponents.DotNetBar.ButtonX();
            this.btnEliminarGrupo = new DevComponents.DotNetBar.ButtonX();
            this.btnActualizar = new DevComponents.DotNetBar.ButtonX();
            this.grdGrupos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsSPXSeguridad2 = new SPXSeguridad.data.dsSPXSeguridad();
            this.grupo_usuarioTableAdapter2 = new SPXSeguridad.data.cls.clsTgrupo_usuario();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnAgregar, "Agregar Grupo");
            this.balloonTip1.SetBalloonText(this.btnAgregar, null);
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnAgregar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAgregar.Location = new System.Drawing.Point(203, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(28, 28);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditarGrupo
            // 
            this.btnEditarGrupo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEditarGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnEditarGrupo, "Editar Grupo");
            this.balloonTip1.SetBalloonText(this.btnEditarGrupo, null);
            this.btnEditarGrupo.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarGrupo.Image")));
            this.btnEditarGrupo.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnEditarGrupo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnEditarGrupo.Location = new System.Drawing.Point(232, 12);
            this.btnEditarGrupo.Name = "btnEditarGrupo";
            this.btnEditarGrupo.Size = new System.Drawing.Size(28, 28);
            this.btnEditarGrupo.TabIndex = 1;
            this.btnEditarGrupo.Click += new System.EventHandler(this.btnEditarGrupo_Click);
            // 
            // btnEliminarGrupo
            // 
            this.btnEliminarGrupo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEliminarGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnEliminarGrupo, "Eliminar Grupo");
            this.balloonTip1.SetBalloonText(this.btnEliminarGrupo, null);
            this.btnEliminarGrupo.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarGrupo.Image")));
            this.btnEliminarGrupo.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnEliminarGrupo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnEliminarGrupo.Location = new System.Drawing.Point(261, 12);
            this.btnEliminarGrupo.Name = "btnEliminarGrupo";
            this.btnEliminarGrupo.Size = new System.Drawing.Size(28, 28);
            this.btnEliminarGrupo.TabIndex = 2;
            this.btnEliminarGrupo.Click += new System.EventHandler(this.btnEliminarGrupo_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnActualizar, "Actualizar Grupo");
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnActualizar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnActualizar.Location = new System.Drawing.Point(174, 12);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(28, 28);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // grdGrupos
            // 
            this.grdGrupos.AllowUpdate = false;
            this.grdGrupos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdGrupos.DataMember = "grupo_usuario";
            this.grdGrupos.DataSource = this.dsSPXSeguridad2;
            this.grdGrupos.FilterBar = true;
            this.grdGrupos.GroupByCaption = "Drag a column header here to group by that column";
            this.grdGrupos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdGrupos.Images"))));
            this.grdGrupos.Location = new System.Drawing.Point(12, 51);
            this.grdGrupos.Name = "grdGrupos";
            this.grdGrupos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdGrupos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdGrupos.PreviewInfo.ZoomFactor = 75D;
            this.grdGrupos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdGrupos.PrintInfo.PageSettings")));
            this.grdGrupos.Size = new System.Drawing.Size(285, 342);
            this.grdGrupos.TabIndex = 4;
            this.grdGrupos.Text = "c1TrueDBGrid1";
            this.grdGrupos.PropBag = resources.GetString("grdGrupos.PropBag");
            // 
            // dsSPXSeguridad2
            // 
            this.dsSPXSeguridad2.DataSetName = "dsSPXSeguridad";
            this.dsSPXSeguridad2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmGrupoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 405);
            this.Controls.Add(this.grdGrupos);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminarGrupo);
            this.Controls.Add(this.btnEditarGrupo);
            this.Controls.Add(this.btnAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGrupoUsuario";
            this.Text = "Grupo Usuario";
            this.Load += new System.EventHandler(this.frmGrupoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private DevComponents.DotNetBar.ButtonX btnAgregar;
        private DevComponents.DotNetBar.ButtonX btnEditarGrupo;
        private DevComponents.DotNetBar.ButtonX btnEliminarGrupo;
        private DevComponents.DotNetBar.ButtonX btnActualizar;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdGrupos;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad2;
        private SPXSeguridad.data.cls.clsTgrupo_usuario grupo_usuarioTableAdapter2;
    }
}