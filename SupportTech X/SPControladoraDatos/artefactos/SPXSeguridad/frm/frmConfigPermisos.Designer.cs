namespace SPXSeguridad.frm
{
    partial class frmConfigPermisos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigPermisos));
            C1.Win.C1TrueDBGrid.Style style1 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style2 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style3 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style4 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style5 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style6 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style7 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style8 = new C1.Win.C1TrueDBGrid.Style();
            this.lblVinculados = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAgregarUsuario = new DevComponents.DotNetBar.ButtonX();
            this.btnDesvincular = new DevComponents.DotNetBar.ButtonX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregarGrupo = new DevComponents.DotNetBar.ButtonX();
            this.grdVinculados = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsSPXSeguridad1 = new SPXSeguridad.data.dsSPXSeguridad();
            this.grdGrupo = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.grdUsuarios = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.grupo_usuarioTableAdapter1 = new SPXSeguridad.data.cls.clsTgrupo_usuario();
            this.usuarioTableAdapter1 = new SPXSeguridad.data.cls.clsTusuario();
            this.c1CmbTipo = new C1.Win.C1TrueDBGrid.C1TrueDBDropdown();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.pltVinculadosTableAdapter1 = new SPXSeguridad.data.cls.clsTpltVinculados();
            this.funcionalidad_usuarioTableAdapter1 = new SPXSeguridad.data.cls.clsTfuncionalidad_usuario();
            this.funcionalidad_grupousuarioTableAdapter1 = new SPXSeguridad.data.cls.clsTfuncionalidad_grupousuario();
            this.moduloseguridad_usuarioTableAdapter1 = new SPXSeguridad.data.cls.clsTmoduloseguridad_usuario();
            this.moduloseguridad_grupousuarioTableAdapter1 = new SPXSeguridad.data.cls.clsTmoduloseguridad_grupousuario();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVinculados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CmbTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVinculados
            // 
            this.lblVinculados.AutoSize = true;
            this.lblVinculados.Location = new System.Drawing.Point(420, 43);
            this.lblVinculados.Name = "lblVinculados";
            this.lblVinculados.Size = new System.Drawing.Size(62, 13);
            this.lblVinculados.TabIndex = 3;
            this.lblVinculados.Text = "Vinculados ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Grupos de Usuarios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Usuarios del Sistema";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(10, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(131, 18);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Modulo o Grupo";
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarUsuario.Image")));
            this.btnAgregarUsuario.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnAgregarUsuario.Location = new System.Drawing.Point(389, 62);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(28, 28);
            this.btnAgregarUsuario.TabIndex = 7;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnDesvincular
            // 
            this.btnDesvincular.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDesvincular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesvincular.Location = new System.Drawing.Point(731, 33);
            this.btnDesvincular.Name = "btnDesvincular";
            this.btnDesvincular.Size = new System.Drawing.Size(87, 23);
            this.btnDesvincular.TabIndex = 9;
            this.btnDesvincular.Text = "Desvincular";
            this.btnDesvincular.Click += new System.EventHandler(this.btnDesvincular_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 517);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 50);
            this.panel1.TabIndex = 10;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(665, 15);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(748, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregarGrupo
            // 
            this.btnAgregarGrupo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregarGrupo.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarGrupo.Image")));
            this.btnAgregarGrupo.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnAgregarGrupo.Location = new System.Drawing.Point(389, 310);
            this.btnAgregarGrupo.Name = "btnAgregarGrupo";
            this.btnAgregarGrupo.Size = new System.Drawing.Size(28, 28);
            this.btnAgregarGrupo.TabIndex = 11;
            this.btnAgregarGrupo.Click += new System.EventHandler(this.btnAgregarGrupo_Click);
            // 
            // grdVinculados
            // 
            this.grdVinculados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdVinculados.DataMember = "pltVinculados";
            this.grdVinculados.DataSource = this.dsSPXSeguridad1;
            this.grdVinculados.GroupByCaption = "Drag a column header here to group by that column";
            this.grdVinculados.Images.Add(((System.Drawing.Image)(resources.GetObject("grdVinculados.Images"))));
            this.grdVinculados.Location = new System.Drawing.Point(423, 62);
            this.grdVinculados.Name = "grdVinculados";
            this.grdVinculados.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdVinculados.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdVinculados.PreviewInfo.ZoomFactor = 75D;
            this.grdVinculados.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdVinculados.PrintInfo.PageSettings")));
            this.grdVinculados.Size = new System.Drawing.Size(395, 449);
            this.grdVinculados.TabIndex = 2;
            this.grdVinculados.Text = "c1TrueDBGrid3";
            this.grdVinculados.PropBag = resources.GetString("grdVinculados.PropBag");
            // 
            // dsSPXSeguridad1
            // 
            this.dsSPXSeguridad1.DataSetName = "dsSPXSeguridad";
            this.dsSPXSeguridad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdGrupo
            // 
            this.grdGrupo.AllowUpdate = false;
            this.grdGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.grdGrupo.DataMember = "grupo_usuario";
            this.grdGrupo.DataSource = this.dsSPXSeguridad1;
            this.grdGrupo.FilterBar = true;
            this.grdGrupo.GroupByCaption = "Drag a column header here to group by that column";
            this.grdGrupo.Images.Add(((System.Drawing.Image)(resources.GetObject("grdGrupo.Images"))));
            this.grdGrupo.Location = new System.Drawing.Point(15, 310);
            this.grdGrupo.Name = "grdGrupo";
            this.grdGrupo.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdGrupo.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdGrupo.PreviewInfo.ZoomFactor = 75D;
            this.grdGrupo.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdGrupo.PrintInfo.PageSettings")));
            this.grdGrupo.Size = new System.Drawing.Size(368, 201);
            this.grdGrupo.TabIndex = 1;
            this.grdGrupo.Text = "c1TrueDBGrid2";
            this.grdGrupo.PropBag = resources.GetString("grdGrupo.PropBag");
            // 
            // grdUsuarios
            // 
            this.grdUsuarios.AllowUpdate = false;
            this.grdUsuarios.DataMember = "usuario";
            this.grdUsuarios.DataSource = this.dsSPXSeguridad1;
            this.grdUsuarios.FilterBar = true;
            this.grdUsuarios.GroupByCaption = "Drag a column header here to group by that column";
            this.grdUsuarios.Images.Add(((System.Drawing.Image)(resources.GetObject("grdUsuarios.Images"))));
            this.grdUsuarios.Location = new System.Drawing.Point(15, 62);
            this.grdUsuarios.Name = "grdUsuarios";
            this.grdUsuarios.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdUsuarios.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdUsuarios.PreviewInfo.ZoomFactor = 75D;
            this.grdUsuarios.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdUsuarios.PrintInfo.PageSettings")));
            this.grdUsuarios.Size = new System.Drawing.Size(368, 219);
            this.grdUsuarios.TabIndex = 0;
            this.grdUsuarios.Text = "c1TrueDBGrid1";
            this.grdUsuarios.PropBag = resources.GetString("grdUsuarios.PropBag");
            // 
            // c1CmbTipo
            // 
            this.c1CmbTipo.AllowColMove = true;
            this.c1CmbTipo.AllowColSelect = true;
            this.c1CmbTipo.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows;
            this.c1CmbTipo.AlternatingRows = false;
            this.c1CmbTipo.CaptionStyle = style1;
            this.c1CmbTipo.ColumnCaptionHeight = 17;
            this.c1CmbTipo.ColumnFooterHeight = 17;
            this.c1CmbTipo.DataMember = "Table1";
            this.c1CmbTipo.DataSource = this.dataSet1;
            this.c1CmbTipo.DisplayMember = "Table1.nombre";
            this.c1CmbTipo.EvenRowStyle = style2;
            this.c1CmbTipo.FetchRowStyles = false;
            this.c1CmbTipo.FooterStyle = style3;
            this.c1CmbTipo.HeadingStyle = style4;
            this.c1CmbTipo.HighLightRowStyle = style5;
            this.c1CmbTipo.Images.Add(((System.Drawing.Image)(resources.GetObject("c1CmbTipo.Images"))));
            this.c1CmbTipo.Location = new System.Drawing.Point(606, 147);
            this.c1CmbTipo.Name = "c1CmbTipo";
            this.c1CmbTipo.OddRowStyle = style6;
            this.c1CmbTipo.RecordSelectorStyle = style7;
            this.c1CmbTipo.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.c1CmbTipo.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
            this.c1CmbTipo.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1CmbTipo.ScrollTips = false;
            this.c1CmbTipo.Size = new System.Drawing.Size(134, 134);
            this.c1CmbTipo.Style = style8;
            this.c1CmbTipo.TabIndex = 12;
            this.c1CmbTipo.TabStop = false;
            this.c1CmbTipo.Text = "c1TrueDBDropdown1";
            this.c1CmbTipo.ValueMember = "Table1.codigo";
            this.c1CmbTipo.ValueTranslate = true;
            this.c1CmbTipo.Visible = false;
            this.c1CmbTipo.PropBag = resources.GetString("c1CmbTipo.PropBag");
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2});
            this.dataTable1.TableName = "Table1";
            // 
            // dataColumn1
            // 
            this.dataColumn1.Caption = "codigo";
            this.dataColumn1.ColumnName = "codigo";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.Caption = "nombre";
            this.dataColumn2.ColumnName = "nombre";
           
            // 
            // frmConfigPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 567);
            this.Controls.Add(this.c1CmbTipo);
            this.Controls.Add(this.btnAgregarGrupo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDesvincular);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblVinculados);
            this.Controls.Add(this.grdVinculados);
            this.Controls.Add(this.grdGrupo);
            this.Controls.Add(this.grdUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmConfigPermisos";
            this.Text = "Configuracion de Permisos";
            this.Load += new System.EventHandler(this.frmConfigPermisos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdVinculados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CmbTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdUsuarios;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdGrupo;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdVinculados;
        private System.Windows.Forms.Label lblVinculados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitulo;
        private DevComponents.DotNetBar.ButtonX btnAgregarUsuario;
        private DevComponents.DotNetBar.ButtonX btnDesvincular;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad1;
        private SPXSeguridad.data.cls.clsTgrupo_usuario grupo_usuarioTableAdapter1;
        private SPXSeguridad.data.cls.clsTusuario usuarioTableAdapter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private DevComponents.DotNetBar.ButtonX btnAgregarGrupo;
        private C1.Win.C1TrueDBGrid.C1TrueDBDropdown c1CmbTipo;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private SPXSeguridad.data.cls.clsTpltVinculados pltVinculadosTableAdapter1;
        private SPXSeguridad.data.cls.clsTfuncionalidad_usuario funcionalidad_usuarioTableAdapter1;
        private SPXSeguridad.data.cls.clsTfuncionalidad_grupousuario funcionalidad_grupousuarioTableAdapter1;
        private SPXSeguridad.data.cls.clsTmoduloseguridad_usuario moduloseguridad_usuarioTableAdapter1;
        private SPXSeguridad.data.cls.clsTmoduloseguridad_grupousuario moduloseguridad_grupousuarioTableAdapter1;
    }
}