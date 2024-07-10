using SPControladoraDatos.artefactos.SPXQuery.data;

namespace SPControladoraDatos.artefactos.SPXQuery.frm.Query
{
    partial class frmEditarQueryUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarQueryUsuarios));
            this.grdGrupos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsSPXSeguridadGrillas = new SPXSeguridad.data.dsSPXSeguridad();
            this.grdUsuario = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.grdQuery = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.btnAgregarUsuario = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregarGrupo = new DevComponents.DotNetBar.ButtonX();
            this.usuarioTableAdapter1 = new SPXSeguridad.data.cls.clsTusuario();
            this.grupo_usuarioTableAdapter1 = new SPXSeguridad.data.cls.clsTgrupo_usuario();
            this.btnQuitar = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dsSPXQuery1 = new dsSPXQuery();
            this.dsSPXSeguridad1 = new SPXSeguridad.data.dsSPXSeguridad();
            this.panel1.SuspendLayout();
            this.contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridadGrillas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXQuery1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(759, 23);
            this.lblTitulo.Text = "Editar Query por Usuario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Location = new System.Drawing.Point(0, 512);
            this.panel1.Size = new System.Drawing.Size(784, 50);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(623, 15);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(697, 15);
            // 
            // contenedor
            // 
            this.contenedor.Controls.Add(this.label2);
            this.contenedor.Controls.Add(this.label1);
            this.contenedor.Controls.Add(this.btnQuitar);
            this.contenedor.Controls.Add(this.btnAgregarGrupo);
            this.contenedor.Controls.Add(this.btnAgregarUsuario);
            this.contenedor.Controls.Add(this.grdQuery);
            this.contenedor.Controls.Add(this.grdGrupos);
            this.contenedor.Controls.Add(this.grdUsuario);
            this.contenedor.Size = new System.Drawing.Size(759, 472);
            // 
            // grdGrupos
            // 
            this.grdGrupos.AllowUpdate = false;
            this.grdGrupos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdGrupos.DataMember = "grupo_usuario";
            this.grdGrupos.DataSource = this.dsSPXSeguridadGrillas;
            this.grdGrupos.FilterBar = true;
            this.grdGrupos.GroupByCaption = "Drag a column header here to group by that column";
            this.grdGrupos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdGrupos.Images"))));
            this.grdGrupos.Location = new System.Drawing.Point(6, 243);
            this.grdGrupos.Name = "grdGrupos";
            this.grdGrupos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdGrupos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdGrupos.PreviewInfo.ZoomFactor = 75D;
            this.grdGrupos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdGrupos.PrintInfo.PageSettings")));
            this.grdGrupos.Size = new System.Drawing.Size(333, 219);
            this.grdGrupos.TabIndex = 71;
            this.grdGrupos.Text = "c1TrueDBGrid2";
            this.grdGrupos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Black;
            this.grdGrupos.PropBag = resources.GetString("grdGrupos.PropBag");
            // 
            // dsSPXSeguridadGrillas
            // 
            this.dsSPXSeguridadGrillas.DataSetName = "dsSPXSeguridad";
            this.dsSPXSeguridadGrillas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdUsuario
            // 
            this.grdUsuario.AllowUpdate = false;
            this.grdUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdUsuario.DataMember = "usuario";
            this.grdUsuario.DataSource = this.dsSPXSeguridadGrillas;
            this.grdUsuario.FilterBar = true;
            this.grdUsuario.GroupByCaption = "Drag a column header here to group by that column";
            this.grdUsuario.Images.Add(((System.Drawing.Image)(resources.GetObject("grdUsuario.Images"))));
            this.grdUsuario.Location = new System.Drawing.Point(6, 26);
            this.grdUsuario.Name = "grdUsuario";
            this.grdUsuario.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdUsuario.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdUsuario.PreviewInfo.ZoomFactor = 75D;
            this.grdUsuario.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdUsuario.PrintInfo.PageSettings")));
            this.grdUsuario.Size = new System.Drawing.Size(333, 198);
            this.grdUsuario.TabIndex = 70;
            this.grdUsuario.Text = "c1TrueDBGrid2";
            this.grdUsuario.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Black;
            this.grdUsuario.PropBag = resources.GetString("grdUsuario.PropBag");
            // 
            // grdQuery
            // 
            this.grdQuery.AllowUpdate = false;
            this.grdQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grdQuery.DataMember = "Table1";
            this.grdQuery.DataSource = this.dataSet1;
            this.grdQuery.GroupByCaption = "Drag a column header here to group by that column";
            this.grdQuery.Images.Add(((System.Drawing.Image)(resources.GetObject("grdQuery.Images"))));
            this.grdQuery.Location = new System.Drawing.Point(378, 25);
            this.grdQuery.Name = "grdQuery";
            this.grdQuery.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdQuery.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdQuery.PreviewInfo.ZoomFactor = 75D;
            this.grdQuery.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdQuery.PrintInfo.PageSettings")));
            this.grdQuery.Size = new System.Drawing.Size(378, 437);
            this.grdQuery.TabIndex = 72;
            this.grdQuery.Text = "c1TrueDBGrid1";
            this.grdQuery.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Black;
            this.grdQuery.PropBag = resources.GetString("grdQuery.PropBag");
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
            this.dataColumn2,
            this.dataColumn3});
            this.dataTable1.TableName = "Table1";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Codigo";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Tipo";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Nombre";
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregarUsuario.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAgregarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarUsuario.Image")));
            this.btnAgregarUsuario.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnAgregarUsuario.Location = new System.Drawing.Point(345, 26);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(28, 28);
            this.btnAgregarUsuario.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAgregarUsuario.TabIndex = 73;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnAgregarGrupo
            // 
            this.btnAgregarGrupo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregarGrupo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAgregarGrupo.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarGrupo.Image")));
            this.btnAgregarGrupo.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnAgregarGrupo.Location = new System.Drawing.Point(345, 243);
            this.btnAgregarGrupo.Name = "btnAgregarGrupo";
            this.btnAgregarGrupo.Size = new System.Drawing.Size(28, 28);
            this.btnAgregarGrupo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAgregarGrupo.TabIndex = 74;
            this.btnAgregarGrupo.Click += new System.EventHandler(this.btnAgregarGrupo_Click);
            // 
            // usuarioTableAdapter1
            // 
            this.usuarioTableAdapter1.nombreLlave = "cod_usuario";
            this.usuarioTableAdapter1.nombreTabla = "usuario";
            this.usuarioTableAdapter1.sentenciaBase = resources.GetString("usuarioTableAdapter1.sentenciaBase");
            this.usuarioTableAdapter1.sentenciaBaseDistinct = resources.GetString("usuarioTableAdapter1.sentenciaBaseDistinct");
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
            // btnQuitar
            // 
            this.btnQuitar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitar.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnQuitar.Location = new System.Drawing.Point(670, 3);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(86, 20);
            this.btnQuitar.TabIndex = 75;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "Usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "Grupos de Usuarios";
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
            // frmEditarQueryUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Name = "frmEditarQueryUsuarios";
            this.Text = "Editar Query Usuarios";
            this.Load += new System.EventHandler(this.frmEditarQueryUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.contenedor.ResumeLayout(false);
            this.contenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridadGrillas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXQuery1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdGrupos;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdUsuario;
        private DevComponents.DotNetBar.ButtonX btnAgregarGrupo;
        private DevComponents.DotNetBar.ButtonX btnAgregarUsuario;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdQuery;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridadGrillas;
        private SPXSeguridad.data.cls.clsTusuario usuarioTableAdapter1;
        private SPXSeguridad.data.cls.clsTgrupo_usuario grupo_usuarioTableAdapter1;
        private DevComponents.DotNetBar.ButtonX btnQuitar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private dsSPXQuery dsSPXQuery1;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad1;
    }
}