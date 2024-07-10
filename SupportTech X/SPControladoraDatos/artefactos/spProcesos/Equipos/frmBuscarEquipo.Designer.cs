namespace spProcesos.Equipos
{
    partial class frmBuscarEquipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarEquipo));
            this.cmbFiltros = new System.Windows.Forms.ComboBox();
            this.chkFiltro1 = new System.Windows.Forms.CheckBox();
            this.txtFiltro1 = new System.Windows.Forms.TextBox();
            this.txtFiltro2 = new System.Windows.Forms.TextBox();
            this.chkFiltro2 = new System.Windows.Forms.CheckBox();
            this.cmbFiltro2 = new System.Windows.Forms.ComboBox();
            this.txtFiltro3 = new System.Windows.Forms.TextBox();
            this.chkFiltro3 = new System.Windows.Forms.CheckBox();
            this.cmbFiltro3 = new System.Windows.Forms.ComboBox();
            this.btnBuscarNit = new DevComponents.DotNetBar.ButtonX();
            this.btnInfEquipo = new DevComponents.DotNetBar.ButtonX();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.grdEquipos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.controladorColumnas1 = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEquipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFiltros
            // 
            this.cmbFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltros.FormattingEnabled = true;
            this.cmbFiltros.Items.AddRange(new object[] {
            "Serial",
            "Nit Cliente",
            "Cliente",
            "Modelo",
            "Fabricante"});
            this.cmbFiltros.Location = new System.Drawing.Point(74, 19);
            this.cmbFiltros.Name = "cmbFiltros";
            this.cmbFiltros.Size = new System.Drawing.Size(199, 21);
            this.cmbFiltros.TabIndex = 1;
            // 
            // chkFiltro1
            // 
            this.chkFiltro1.AutoSize = true;
            this.chkFiltro1.Checked = true;
            this.chkFiltro1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFiltro1.Location = new System.Drawing.Point(10, 20);
            this.chkFiltro1.Name = "chkFiltro1";
            this.chkFiltro1.Size = new System.Drawing.Size(59, 17);
            this.chkFiltro1.TabIndex = 1;
            this.chkFiltro1.Text = "Filtro 1";
            this.chkFiltro1.UseVisualStyleBackColor = true;
            // 
            // txtFiltro1
            // 
            this.txtFiltro1.Location = new System.Drawing.Point(279, 20);
            this.txtFiltro1.Name = "txtFiltro1";
            this.txtFiltro1.Size = new System.Drawing.Size(176, 21);
            this.txtFiltro1.TabIndex = 2;
            this.txtFiltro1.Text = "%";
            this.txtFiltro1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFiltro1_KeyDown);
            // 
            // txtFiltro2
            // 
            this.txtFiltro2.Location = new System.Drawing.Point(279, 54);
            this.txtFiltro2.Name = "txtFiltro2";
            this.txtFiltro2.Size = new System.Drawing.Size(176, 21);
            this.txtFiltro2.TabIndex = 5;
            this.txtFiltro2.TextChanged += new System.EventHandler(this.txtFiltro2_TextChanged);
            this.txtFiltro2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFiltro1_KeyDown);
            // 
            // chkFiltro2
            // 
            this.chkFiltro2.AutoSize = true;
            this.chkFiltro2.Location = new System.Drawing.Point(10, 54);
            this.chkFiltro2.Name = "chkFiltro2";
            this.chkFiltro2.Size = new System.Drawing.Size(59, 17);
            this.chkFiltro2.TabIndex = 7;
            this.chkFiltro2.Text = "Filtro 2";
            this.chkFiltro2.UseVisualStyleBackColor = true;
            // 
            // cmbFiltro2
            // 
            this.cmbFiltro2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro2.FormattingEnabled = true;
            this.cmbFiltro2.Items.AddRange(new object[] {
            "Serial",
            "Nit Cliente",
            "Cliente",
            "Modelo",
            "Fabricante"});
            this.cmbFiltro2.Location = new System.Drawing.Point(74, 53);
            this.cmbFiltro2.Name = "cmbFiltro2";
            this.cmbFiltro2.Size = new System.Drawing.Size(199, 21);
            this.cmbFiltro2.TabIndex = 4;
            // 
            // txtFiltro3
            // 
            this.txtFiltro3.Location = new System.Drawing.Point(279, 90);
            this.txtFiltro3.Name = "txtFiltro3";
            this.txtFiltro3.Size = new System.Drawing.Size(176, 21);
            this.txtFiltro3.TabIndex = 7;
            this.txtFiltro3.TextChanged += new System.EventHandler(this.txtFiltro3_TextChanged);
            this.txtFiltro3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFiltro1_KeyDown);
            // 
            // chkFiltro3
            // 
            this.chkFiltro3.AutoSize = true;
            this.chkFiltro3.Location = new System.Drawing.Point(10, 90);
            this.chkFiltro3.Name = "chkFiltro3";
            this.chkFiltro3.Size = new System.Drawing.Size(59, 17);
            this.chkFiltro3.TabIndex = 10;
            this.chkFiltro3.Text = "Filtro 3";
            this.chkFiltro3.UseVisualStyleBackColor = true;
            // 
            // cmbFiltro3
            // 
            this.cmbFiltro3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro3.FormattingEnabled = true;
            this.cmbFiltro3.Items.AddRange(new object[] {
            "Serial",
            "Nit Cliente",
            "Cliente",
            "Modelo",
            "Fabricante"});
            this.cmbFiltro3.Location = new System.Drawing.Point(74, 89);
            this.cmbFiltro3.Name = "cmbFiltro3";
            this.cmbFiltro3.Size = new System.Drawing.Size(199, 21);
            this.cmbFiltro3.TabIndex = 6;
            // 
            // btnBuscarNit
            // 
            this.btnBuscarNit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnBuscarNit, "Buscar");
            this.balloonTip1.SetBalloonText(this.btnBuscarNit, null);
            this.btnBuscarNit.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarNit.Image")));
            this.btnBuscarNit.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnBuscarNit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBuscarNit.Location = new System.Drawing.Point(461, 14);
            this.btnBuscarNit.Name = "btnBuscarNit";
            this.btnBuscarNit.Size = new System.Drawing.Size(33, 33);
            this.btnBuscarNit.TabIndex = 3;
            this.btnBuscarNit.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnInfEquipo
            // 
            this.btnInfEquipo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnInfEquipo, "Hoja de Vida de Equipo");
            this.balloonTip1.SetBalloonText(this.btnInfEquipo, null);
            this.btnInfEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfEquipo.Image")));
            this.btnInfEquipo.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnInfEquipo.Location = new System.Drawing.Point(632, 100);
            this.btnInfEquipo.Name = "btnInfEquipo";
            this.btnInfEquipo.Size = new System.Drawing.Size(33, 33);
            this.btnInfEquipo.TabIndex = 4;
            this.btnInfEquipo.Click += new System.EventHandler(this.btnInfEquipo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFiltros);
            this.groupBox1.Controls.Add(this.chkFiltro1);
            this.groupBox1.Controls.Add(this.txtFiltro1);
            this.groupBox1.Controls.Add(this.btnBuscarNit);
            this.groupBox1.Controls.Add(this.cmbFiltro2);
            this.groupBox1.Controls.Add(this.chkFiltro2);
            this.groupBox1.Controls.Add(this.txtFiltro2);
            this.groupBox1.Controls.Add(this.txtFiltro3);
            this.groupBox1.Controls.Add(this.cmbFiltro3);
            this.groupBox1.Controls.Add(this.chkFiltro3);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 459);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 49);
            this.panel1.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(449, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(367, 12);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // grdEquipos
            // 
            this.grdEquipos.AllowUpdate = false;
            this.grdEquipos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdEquipos.CaptionHeight = 17;
            this.grdEquipos.DataMember = "vistaEquipo";
            this.grdEquipos.DataSource = this.dsSpx1;
            this.grdEquipos.FilterBar = true;
            this.grdEquipos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdEquipos.Images"))));
            this.grdEquipos.Location = new System.Drawing.Point(13, 139);
            this.grdEquipos.Name = "grdEquipos";
            this.grdEquipos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdEquipos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdEquipos.PreviewInfo.ZoomFactor = 75D;
            this.grdEquipos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdEquipos.PrintInfo.PageSettings")));
            this.grdEquipos.RowHeight = 15;
            this.grdEquipos.Size = new System.Drawing.Size(866, 301);
            this.grdEquipos.TabIndex = 7;
            this.grdEquipos.Text = "c1TrueDBGrid1";
            this.grdEquipos.PropBag = resources.GetString("grdEquipos.PropBag");
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.EnforceConstraints = false;
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // controladorColumnas1
            // 
            this.controladorColumnas1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controladorColumnas1.BackColor = System.Drawing.Color.Transparent;
            this.controladorColumnas1.grilla = null;
            this.controladorColumnas1.Location = new System.Drawing.Point(668, 104);
            this.controladorColumnas1.MostrarContraer = true;
            this.controladorColumnas1.MostrarExcel = true;
            this.controladorColumnas1.MostrarExpandir = true;
            this.controladorColumnas1.MostrarLimpiar = true;
            this.controladorColumnas1.Name = "controladorColumnas1";
            this.controladorColumnas1.nombreLibro = null;
            this.controladorColumnas1.Size = new System.Drawing.Size(216, 29);
            this.controladorColumnas1.TabIndex = 8;
            // 
            // frmBuscarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(891, 508);
            this.Controls.Add(this.controladorColumnas1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInfEquipo);
            this.Controls.Add(this.grdEquipos);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBuscarEquipo";
            this.Text = "Buscar Equipo";
            this.Load += new System.EventHandler(this.frmBuscarEquipo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdEquipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFiltros;
        private System.Windows.Forms.CheckBox chkFiltro1;
        private System.Windows.Forms.TextBox txtFiltro1;
        private System.Windows.Forms.TextBox txtFiltro2;
        private System.Windows.Forms.CheckBox chkFiltro2;
        private System.Windows.Forms.ComboBox cmbFiltro2;
        private System.Windows.Forms.TextBox txtFiltro3;
        private System.Windows.Forms.CheckBox chkFiltro3;
        private System.Windows.Forms.ComboBox cmbFiltro3;
        private SPControladoraDatos.dsSpx dsSpx1;
        private DevComponents.DotNetBar.ButtonX btnBuscarNit;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdEquipos;
        private DevComponents.DotNetBar.ButtonX btnInfEquipo;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas controladorColumnas1;
    }
}