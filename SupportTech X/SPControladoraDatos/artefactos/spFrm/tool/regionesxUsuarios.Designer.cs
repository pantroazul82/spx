namespace SpFrm.tool
{
    partial class regionesxUsuarios
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(regionesxUsuarios));
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.grdRegionesxUsuario = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsSpx2 = new SPControladoraDatos.dsSpx();
            this.grdUsuarios = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.ciudadesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ciudadesTableAdapter();
            this.departamentoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.departamentoTableAdapter();
            this.paisesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.paisesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarRegion = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.regionesXusuariosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.regionesXusuariosTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnQuitarRegion = new System.Windows.Forms.Button();
            this.btnAgregarDepartamento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRegionesxUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdRegionesxUsuario
            // 
            this.grdRegionesxUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grdRegionesxUsuario.DataSource = this.dsSpx2;
            this.grdRegionesxUsuario.GroupByCaption = "Drag a column header here to group by that column";
            this.grdRegionesxUsuario.Images.Add(((System.Drawing.Image)(resources.GetObject("grdRegionesxUsuario.Images"))));
            this.grdRegionesxUsuario.Location = new System.Drawing.Point(6, 19);
            this.grdRegionesxUsuario.Name = "grdRegionesxUsuario";
            this.grdRegionesxUsuario.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdRegionesxUsuario.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdRegionesxUsuario.PreviewInfo.ZoomFactor = 75D;
            this.grdRegionesxUsuario.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdRegionesxUsuario.PrintInfo.PageSettings")));
            this.grdRegionesxUsuario.Size = new System.Drawing.Size(668, 482);
            this.grdRegionesxUsuario.TabIndex = 0;
            this.grdRegionesxUsuario.Text = "c1TrueDBGrid1";
            this.grdRegionesxUsuario.PropBag = resources.GetString("grdRegionesxUsuario.PropBag");
            // 
            // dsSpx2
            // 
            this.dsSpx2.DataSetName = "dsSpx";
            this.dsSpx2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdUsuarios
            // 
            this.grdUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grdUsuarios.GroupByCaption = "Drag a column header here to group by that column";
            this.grdUsuarios.Images.Add(((System.Drawing.Image)(resources.GetObject("grdUsuarios.Images"))));
            this.grdUsuarios.Location = new System.Drawing.Point(6, 19);
            this.grdUsuarios.Name = "grdUsuarios";
            this.grdUsuarios.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdUsuarios.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdUsuarios.PreviewInfo.ZoomFactor = 75D;
            this.grdUsuarios.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdUsuarios.PrintInfo.PageSettings")));
            this.grdUsuarios.Size = new System.Drawing.Size(199, 623);
            this.grdUsuarios.TabIndex = 1;
            this.grdUsuarios.Text = "c1TrueDBGrid2";
            this.grdUsuarios.RowColChange += new C1.Win.C1TrueDBGrid.RowColChangeEventHandler(this.grdUsuarios_RowColChange);
            this.grdUsuarios.PropBag = resources.GetString("grdUsuarios.PropBag");
            // 
            // ciudadesTableAdapter1
            // 
            this.ciudadesTableAdapter1.ClearBeforeFill = true;
            // 
            // departamentoTableAdapter1
            // 
            this.departamentoTableAdapter1.ClearBeforeFill = true;
            // 
            // paisesTableAdapter1
            // 
            this.paisesTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pais";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ciudad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Departamento";
            // 
            // cmbPais
            // 
            this.cmbPais.DataSource = this.dsSpx1;
            this.cmbPais.DisplayMember = "paises.nombrePais";
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(89, 29);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(205, 21);
            this.cmbPais.TabIndex = 5;
            this.cmbPais.ValueMember = "paises.codPais";
            this.cmbPais.SelectedIndexChanged += new System.EventHandler(this.cmbPais_SelectedIndexChanged);
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DataSource = this.dsSpx1;
            this.cmbDepartamento.DisplayMember = "departamento.NombreDepartamento";
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(89, 56);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(205, 21);
            this.cmbDepartamento.TabIndex = 6;
            this.cmbDepartamento.ValueMember = "departamento.codDepartamento";
            this.cmbDepartamento.SelectedIndexChanged += new System.EventHandler(this.cmbDepartamento_SelectedIndexChanged);
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.DataSource = this.dsSpx1;
            this.cmbCiudad.DisplayMember = "ciudades.nombreCiudad";
            this.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(89, 83);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(205, 21);
            this.cmbCiudad.TabIndex = 7;
            this.cmbCiudad.ValueMember = "ciudades.codCiudad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregarDepartamento);
            this.groupBox1.Controls.Add(this.btnAgregarRegion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbCiudad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbDepartamento);
            this.groupBox1.Controls.Add(this.cmbPais);
            this.groupBox1.Location = new System.Drawing.Point(233, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 141);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Regiones";
            // 
            // btnAgregarRegion
            // 
            this.btnAgregarRegion.Location = new System.Drawing.Point(300, 83);
            this.btnAgregarRegion.Name = "btnAgregarRegion";
            this.btnAgregarRegion.Size = new System.Drawing.Size(166, 23);
            this.btnAgregarRegion.TabIndex = 9;
            this.btnAgregarRegion.Text = "<<  Agregar Region";
            this.btnAgregarRegion.UseVisualStyleBackColor = true;
            this.btnAgregarRegion.Click += new System.EventHandler(this.btnAgregarRegion_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.grdUsuarios);
            this.groupBox2.Location = new System.Drawing.Point(12, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 650);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuarios";
            // 
            // regionesXusuariosTableAdapter1
            // 
            this.regionesXusuariosTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.grdRegionesxUsuario);
            this.groupBox3.Location = new System.Drawing.Point(227, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(700, 511);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Regiones x Usuario";
            // 
            // btnQuitarRegion
            // 
            this.btnQuitarRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQuitarRegion.Location = new System.Drawing.Point(815, 114);
            this.btnQuitarRegion.Name = "btnQuitarRegion";
            this.btnQuitarRegion.Size = new System.Drawing.Size(112, 25);
            this.btnQuitarRegion.TabIndex = 10;
            this.btnQuitarRegion.Text = "Quitar Region  >>";
            this.btnQuitarRegion.UseVisualStyleBackColor = true;
            this.btnQuitarRegion.Click += new System.EventHandler(this.btnQuitarRegion_Click);
            // 
            // btnAgregarDepartamento
            // 
            this.btnAgregarDepartamento.Location = new System.Drawing.Point(300, 56);
            this.btnAgregarDepartamento.Name = "btnAgregarDepartamento";
            this.btnAgregarDepartamento.Size = new System.Drawing.Size(166, 23);
            this.btnAgregarDepartamento.TabIndex = 10;
            this.btnAgregarDepartamento.Text = "<<  Agregar Departamento";
            this.btnAgregarDepartamento.UseVisualStyleBackColor = true;
            this.btnAgregarDepartamento.Click += new System.EventHandler(this.btnAgregarDepartamento_Click);
            // 
            // regionesxUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(939, 658);
            this.Controls.Add(this.btnQuitarRegion);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "regionesxUsuarios";
            this.Text = "Regiones x Usuario";
            this.Load += new System.EventHandler(this.regionesxUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRegionesxUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SPControladoraDatos.dsSpx dsSpx1;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdRegionesxUsuario;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdUsuarios;
        private SPControladoraDatos.dsSpxTableAdapters.ciudadesTableAdapter ciudadesTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.departamentoTableAdapter departamentoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.paisesTableAdapter paisesTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarRegion;
        private SPControladoraDatos.dsSpx dsSpx2;
        private System.Windows.Forms.GroupBox groupBox2;
        private SPControladoraDatos.dsSpxTableAdapters.regionesXusuariosTableAdapter regionesXusuariosTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnQuitarRegion;
        private System.Windows.Forms.Button btnAgregarDepartamento;
    }
}