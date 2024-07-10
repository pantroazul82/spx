namespace SPXSeguridad.linea
{
    partial class frmLineasxUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLineasxUsuario));
            this.dsSPXSeguridad1 = new SPXSeguridad.data.dsSPXSeguridad();
            this.lineaTableAdapter1 = new SPXSeguridad.data.cls.clsTlinea();
            this.lineaxusuarioTableAdapter1 = new SPXSeguridad.data.cls.clsTlineasxusuario();
            this.grupo_usuarioxlineaTableAdapter1 = new SPXSeguridad.data.cls.clsTgrupo_usuarioxlinea();
            this.grupo_usuarioTableAdapter1 = new SPXSeguridad.data.cls.clsTgrupo_usuario();
            this.usuarioTableAdapter1 = new SPXSeguridad.data.cls.clsTusuario();
            this.btnAgregarUsuario = new DevComponents.DotNetBar.ButtonX();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.btnQuitarUsuario = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregarGrupo = new DevComponents.DotNetBar.ButtonX();
            this.grdLinea = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.grdUsuarios = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.grdGrupos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLinea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrupos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsSPXSeguridad1
            // 
            this.dsSPXSeguridad1.DataSetName = "dsSPXSeguridad";
            this.dsSPXSeguridad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;

            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnAgregarUsuario, "Agregar Usuario");
            this.balloonTip1.SetBalloonText(this.btnAgregarUsuario, null);
            this.btnAgregarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarUsuario.Image")));
            this.btnAgregarUsuario.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnAgregarUsuario.Location = new System.Drawing.Point(564, 10);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(28, 28);
            this.btnAgregarUsuario.TabIndex = 0;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnQuitarUsuario
            // 
            this.btnQuitarUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuitarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnQuitarUsuario, "Quitar Usuario");
            this.btnQuitarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitarUsuario.Image")));
            this.btnQuitarUsuario.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnQuitarUsuario.Location = new System.Drawing.Point(598, 10);
            this.btnQuitarUsuario.Name = "btnQuitarUsuario";
            this.btnQuitarUsuario.Size = new System.Drawing.Size(28, 28);
            this.btnQuitarUsuario.TabIndex = 8;
            this.btnQuitarUsuario.Click += new System.EventHandler(this.btnQuitarUsuario_Click);
            // 
            // btnAgregarGrupo
            // 
            this.btnAgregarGrupo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregarGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnAgregarGrupo, "Editar Grupos de la Linea");
            this.btnAgregarGrupo.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarGrupo.Image")));
            this.btnAgregarGrupo.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnAgregarGrupo.Location = new System.Drawing.Point(602, 235);
            this.btnAgregarGrupo.Name = "btnAgregarGrupo";
            this.btnAgregarGrupo.Size = new System.Drawing.Size(28, 28);
            this.btnAgregarGrupo.TabIndex = 9;
            this.btnAgregarGrupo.Click += new System.EventHandler(this.btnAgregarGrupo_Click);
            // 
            // grdLinea
            // 
            this.grdLinea.AllowUpdate = false;
            this.grdLinea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.grdLinea.DataMember = "linea";
            this.grdLinea.DataSource = this.dsSPXSeguridad1;
            this.grdLinea.FilterBar = true;
            this.grdLinea.GroupByCaption = "Drag a column header here to group by that column";
            this.grdLinea.Images.Add(((System.Drawing.Image)(resources.GetObject("grdLinea.Images"))));
            this.grdLinea.Location = new System.Drawing.Point(12, 33);
            this.grdLinea.Name = "grdLinea";
            this.grdLinea.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdLinea.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdLinea.PreviewInfo.ZoomFactor = 75D;
            this.grdLinea.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdLinea.PrintInfo.PageSettings")));
            this.grdLinea.Size = new System.Drawing.Size(237, 428);
            this.grdLinea.TabIndex = 1;
            this.grdLinea.Text = "c1TrueDBGrid1";
            this.grdLinea.RowColChange += new C1.Win.C1TrueDBGrid.RowColChangeEventHandler(this.grdLinea_RowColChange);
            this.grdLinea.PropBag = resources.GetString("grdLinea.PropBag");
            // 
            // grdUsuarios
            // 
            this.grdUsuarios.AllowUpdate = false;
            this.grdUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdUsuarios.DataMember = "usuario";
            this.grdUsuarios.DataSource = this.dsSPXSeguridad1;
            this.grdUsuarios.FilterBar = true;
            this.grdUsuarios.GroupByCaption = "Drag a column header here to group by that column";
            this.grdUsuarios.Images.Add(((System.Drawing.Image)(resources.GetObject("grdUsuarios.Images"))));
            this.grdUsuarios.Location = new System.Drawing.Point(262, 49);
            this.grdUsuarios.Name = "grdUsuarios";
            this.grdUsuarios.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdUsuarios.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdUsuarios.PreviewInfo.ZoomFactor = 75D;
            this.grdUsuarios.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdUsuarios.PrintInfo.PageSettings")));
            this.grdUsuarios.Size = new System.Drawing.Size(369, 180);
            this.grdUsuarios.TabIndex = 2;
            this.grdUsuarios.Text = "c1TrueDBGrid2";
            this.grdUsuarios.PropBag = resources.GetString("grdUsuarios.PropBag");
            // 
            // grdGrupos
            // 
            this.grdGrupos.AllowUpdate = false;
            this.grdGrupos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdGrupos.DataMember = "grupo_usuario";
            this.grdGrupos.DataSource = this.dsSPXSeguridad1;
            this.grdGrupos.FilterBar = true;
            this.grdGrupos.GroupByCaption = "Drag a column header here to group by that column";
            this.grdGrupos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdGrupos.Images"))));
            this.grdGrupos.Location = new System.Drawing.Point(262, 269);
            this.grdGrupos.Name = "grdGrupos";
            this.grdGrupos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdGrupos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdGrupos.PreviewInfo.ZoomFactor = 75D;
            this.grdGrupos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdGrupos.PrintInfo.PageSettings")));
            this.grdGrupos.Size = new System.Drawing.Size(369, 193);
            this.grdGrupos.TabIndex = 3;
            this.grdGrupos.Text = "c1TrueDBGrid3";
            this.grdGrupos.PropBag = resources.GetString("grdGrupos.PropBag");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 468);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 54);
            this.panel1.TabIndex = 4;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(559, 19);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(71, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Grupo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Linea";
            // 
            // frmLineasxUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(640, 522);
            this.Controls.Add(this.btnAgregarGrupo);
            this.Controls.Add(this.btnQuitarUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grdGrupos);
            this.Controls.Add(this.grdUsuarios);
            this.Controls.Add(this.grdLinea);
            this.Controls.Add(this.btnAgregarUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLineasxUsuario";
            this.Text = "Lineas por Usuario";
            this.Load += new System.EventHandler(this.frmLineasxUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLinea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrupos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad1;
        private SPXSeguridad.data.cls.clsTlinea lineaTableAdapter1;
        private SPXSeguridad.data.cls.clsTlineasxusuario lineaxusuarioTableAdapter1;
        private SPXSeguridad.data.cls.clsTgrupo_usuarioxlinea grupo_usuarioxlineaTableAdapter1;
        private SPXSeguridad.data.cls.clsTgrupo_usuario grupo_usuarioTableAdapter1;
        private SPXSeguridad.data.cls.clsTusuario usuarioTableAdapter1;
        private DevComponents.DotNetBar.ButtonX btnAgregarUsuario;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdLinea;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdUsuarios;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdGrupos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.ButtonX btnQuitarUsuario;
        private DevComponents.DotNetBar.ButtonX btnAgregarGrupo;
    }
}