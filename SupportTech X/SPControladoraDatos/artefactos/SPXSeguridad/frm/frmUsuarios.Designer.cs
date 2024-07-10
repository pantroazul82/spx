namespace SPXSeguridad.frm
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.btnEliminarGrupo = new DevComponents.DotNetBar.ButtonX();
            this.btnEditarGrupo = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregarGrupo = new DevComponents.DotNetBar.ButtonX();
            this.btnEditar = new DevComponents.DotNetBar.ButtonX();
            this.btnActuazalizar = new DevComponents.DotNetBar.ButtonX();
            this.btnEliminarUsuario = new DevComponents.DotNetBar.ButtonX();
            this.btnEditarUsuario = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregarUsuario = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grdGruposDelUsuario = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsSPXSeguridad2 = new SPXSeguridad.data.dsSPXSeguridad();
            this.grdGrupos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsSPXSeguridad1 = new SPXSeguridad.data.dsSPXSeguridad();
            this.grdUsuario = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.usuarioTableAdapter1 = new SPXSeguridad.data.cls.clsTusuario();
            this.grupo_usuarioTableAdapter1 = new SPXSeguridad.data.cls.clsTgrupo_usuario();
            this.grupousuario_usuarioTableAdapter1 = new SPXSeguridad.data.cls.clsTgrupousuario_usuario();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdGruposDelUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuario)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminarGrupo
            // 
            this.btnEliminarGrupo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEliminarGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnEliminarGrupo, "Eliminar Grupo");
            this.btnEliminarGrupo.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarGrupo.Image")));
            this.btnEliminarGrupo.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnEliminarGrupo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnEliminarGrupo.Location = new System.Drawing.Point(696, 207);
            this.btnEliminarGrupo.Name = "btnEliminarGrupo";
            this.btnEliminarGrupo.Size = new System.Drawing.Size(28, 28);
            this.btnEliminarGrupo.TabIndex = 7;
            this.btnEliminarGrupo.Click += new System.EventHandler(this.btnEliminarGrupo_Click);
            // 
            // btnEditarGrupo
            // 
            this.btnEditarGrupo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEditarGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnEditarGrupo, "Editar Grupo");
            this.btnEditarGrupo.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarGrupo.Image")));
            this.btnEditarGrupo.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnEditarGrupo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnEditarGrupo.Location = new System.Drawing.Point(666, 207);
            this.btnEditarGrupo.Name = "btnEditarGrupo";
            this.btnEditarGrupo.Size = new System.Drawing.Size(28, 28);
            this.btnEditarGrupo.TabIndex = 6;
            this.btnEditarGrupo.Click += new System.EventHandler(this.btnEditarGrupo_Click);
            // 
            // btnAgregarGrupo
            // 
            this.btnAgregarGrupo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregarGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnAgregarGrupo, "Agregar Grupo");
            this.btnAgregarGrupo.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarGrupo.Image")));
            this.btnAgregarGrupo.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnAgregarGrupo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAgregarGrupo.Location = new System.Drawing.Point(636, 207);
            this.btnAgregarGrupo.Name = "btnAgregarGrupo";
            this.btnAgregarGrupo.Size = new System.Drawing.Size(28, 28);
            this.btnAgregarGrupo.TabIndex = 5;
            this.btnAgregarGrupo.Click += new System.EventHandler(this.btnAgregarGrupo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnEditar, "Modificar Grupos del Usuario");
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnEditar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnEditar.Location = new System.Drawing.Point(696, 6);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(28, 28);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Click += new System.EventHandler(this.btnAgregarGrupoUsuario_Click);
            // 
            // btnActuazalizar
            // 
            this.btnActuazalizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnActuazalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnActuazalizar, "Actualizar Informacion");
            this.btnActuazalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActuazalizar.Image")));
            this.btnActuazalizar.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnActuazalizar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnActuazalizar.Location = new System.Drawing.Point(343, 19);
            this.btnActuazalizar.Name = "btnActuazalizar";
            this.btnActuazalizar.Size = new System.Drawing.Size(28, 28);
            this.btnActuazalizar.TabIndex = 18;
            this.btnActuazalizar.Click += new System.EventHandler(this.btnActuazalizar_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEliminarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnEliminarUsuario, "Eliminar Usuario");
            this.btnEliminarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarUsuario.Image")));
            this.btnEliminarUsuario.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnEliminarUsuario.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(430, 19);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(28, 28);
            this.btnEliminarUsuario.TabIndex = 17;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEditarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnEditarUsuario, "Editar Usuario");
            this.btnEditarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarUsuario.Image")));
            this.btnEditarUsuario.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnEditarUsuario.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnEditarUsuario.Location = new System.Drawing.Point(401, 19);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(28, 28);
            this.btnEditarUsuario.TabIndex = 16;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnAgregarUsuario, "Agregar Usuario");
            this.btnAgregarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarUsuario.Image")));
            this.btnAgregarUsuario.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnAgregarUsuario.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(372, 19);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(28, 28);
            this.btnAgregarUsuario.TabIndex = 15;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Usuarios del Sistema";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(466, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Grupos del Usuario";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(465, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Grupos del Sistema";
            // 
            // grdGruposDelUsuario
            // 
            this.grdGruposDelUsuario.AllowUpdate = false;
            this.grdGruposDelUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grdGruposDelUsuario.DataMember = "grupo_usuario";
            this.grdGruposDelUsuario.DataSource = this.dsSPXSeguridad2;
            this.grdGruposDelUsuario.GroupByCaption = "Drag a column header here to group by that column";
            this.grdGruposDelUsuario.Images.Add(((System.Drawing.Image)(resources.GetObject("grdGruposDelUsuario.Images"))));
            this.grdGruposDelUsuario.Location = new System.Drawing.Point(468, 37);
            this.grdGruposDelUsuario.Name = "grdGruposDelUsuario";
            this.grdGruposDelUsuario.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdGruposDelUsuario.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdGruposDelUsuario.PreviewInfo.ZoomFactor = 75D;
            this.grdGruposDelUsuario.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdGruposDelUsuario.PrintInfo.PageSettings")));
            this.grdGruposDelUsuario.Size = new System.Drawing.Size(258, 148);
            this.grdGruposDelUsuario.TabIndex = 14;
            this.grdGruposDelUsuario.Text = "c1TrueDBGrid1";
            this.grdGruposDelUsuario.PropBag = resources.GetString("grdGruposDelUsuario.PropBag");
            // 
            // dsSPXSeguridad2
            // 
            this.dsSPXSeguridad2.DataSetName = "dsSPXSeguridad";
            this.dsSPXSeguridad2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.grdGrupos.Location = new System.Drawing.Point(468, 238);
            this.grdGrupos.Name = "grdGrupos";
            this.grdGrupos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdGrupos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdGrupos.PreviewInfo.ZoomFactor = 75D;
            this.grdGrupos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdGrupos.PrintInfo.PageSettings")));
            this.grdGrupos.Size = new System.Drawing.Size(258, 168);
            this.grdGrupos.TabIndex = 9;
            this.grdGrupos.Text = "c1TrueDBGrid1";
            this.grdGrupos.PropBag = resources.GetString("grdGrupos.PropBag");
            // 
            // dsSPXSeguridad1
            // 
            this.dsSPXSeguridad1.DataSetName = "dsSPXSeguridad";
            this.dsSPXSeguridad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdUsuario
            // 
            this.grdUsuario.AllowUpdate = false;
            this.grdUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdUsuario.DataMember = "usuario";
            this.grdUsuario.DataSource = this.dsSPXSeguridad1;
            this.grdUsuario.FilterBar = true;
            this.grdUsuario.GroupByCaption = "Drag a column header here to group by that column";
            this.grdUsuario.Images.Add(((System.Drawing.Image)(resources.GetObject("grdUsuario.Images"))));
            this.grdUsuario.Location = new System.Drawing.Point(7, 52);
            this.grdUsuario.Name = "grdUsuario";
            this.grdUsuario.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdUsuario.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdUsuario.PreviewInfo.ZoomFactor = 75D;
            this.grdUsuario.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdUsuario.PrintInfo.PageSettings")));
            this.grdUsuario.Size = new System.Drawing.Size(451, 355);
            this.grdUsuario.TabIndex = 0;
            this.grdUsuario.Text = "c1TrueDBGrid1";
            this.grdUsuario.RowColChange += new C1.Win.C1TrueDBGrid.RowColChangeEventHandler(this.grdUsuario_RowColChange);
            this.grdUsuario.PropBag = resources.GetString("grdUsuario.PropBag");
             // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 51);
            this.panel1.TabIndex = 23;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(649, 16);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(741, 463);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActuazalizar);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnEditarUsuario);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.grdGruposDelUsuario);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.grdGrupos);
            this.Controls.Add(this.btnEliminarGrupo);
            this.Controls.Add(this.btnEditarGrupo);
            this.Controls.Add(this.btnAgregarGrupo);
            this.Controls.Add(this.grdUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUsuarios";
            this.Text = "Usuarios del Sistema";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdGruposDelUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdUsuario;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdGrupos;
        private DevComponents.DotNetBar.ButtonX btnEliminarGrupo;
        private DevComponents.DotNetBar.ButtonX btnEditarGrupo;
        private DevComponents.DotNetBar.ButtonX btnAgregarGrupo;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdGruposDelUsuario;
        private DevComponents.DotNetBar.ButtonX btnEditar;
        private DevComponents.DotNetBar.ButtonX btnActuazalizar;
        private DevComponents.DotNetBar.ButtonX btnEliminarUsuario;
        private DevComponents.DotNetBar.ButtonX btnEditarUsuario;
        private DevComponents.DotNetBar.ButtonX btnAgregarUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad1;
        private SPXSeguridad.data.cls.clsTusuario usuarioTableAdapter1;
        private SPXSeguridad.data.cls.clsTgrupo_usuario grupo_usuarioTableAdapter1;
        private SPXSeguridad.data.cls.clsTgrupousuario_usuario grupousuario_usuarioTableAdapter1;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
    }
}