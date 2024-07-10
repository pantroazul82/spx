namespace SpFrm.tool
{
    partial class frmInformacionLocal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformacionLocal));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.grdBodegas = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.clientesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.clientesTableAdapter();
            this.sucursalClienteTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.sucursalClienteTableAdapter();
            this.defaultsTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter();
            this.cmbUbicacionPredeterminada = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEstadoPredetermindo = new System.Windows.Forms.ComboBox();
            this.estadoLocalEquiposTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.estadoLocalEquiposTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkTrasladosAutomaticosAlCerrarLaorden = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkTrasladosAutomaticosAlRelizarEntrada = new System.Windows.Forms.CheckBox();
            this.cmbEstadoEntrada = new System.Windows.Forms.ComboBox();
            this.dsSpx2 = new SPControladoraDatos.dsSpx();
            this.cmbUbicacionEntrada = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkEstadoAutomaticosAlRelizarEntrada = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdBodegas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(738, 15);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(819, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre de la Empresa";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Location = new System.Drawing.Point(128, 15);
            this.txtNombreEmpresa.MaxLength = 50;
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(314, 20);
            this.txtNombreEmpresa.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ubicaciones o Bodegas";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(801, 215);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(801, 184);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(801, 246);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // grdBodegas
            // 
            this.grdBodegas.CaptionHeight = 50;
            this.grdBodegas.DataMember = "sucursalCliente";
            this.grdBodegas.DataSource = this.dsSpx1;
            this.grdBodegas.GroupByCaption = "Drag a column header here to group by that column";
            this.grdBodegas.Images.Add(((System.Drawing.Image)(resources.GetObject("grdBodegas.Images"))));
            this.grdBodegas.Location = new System.Drawing.Point(21, 184);
            this.grdBodegas.Name = "grdBodegas";
            this.grdBodegas.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdBodegas.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdBodegas.PreviewInfo.ZoomFactor = 75D;
            this.grdBodegas.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdBodegas.PrintInfo.PageSettings")));
            this.grdBodegas.Size = new System.Drawing.Size(774, 289);
            this.grdBodegas.TabIndex = 6;
            this.grdBodegas.Text = "c1TrueDBGrid1";
            this.grdBodegas.PropBag = resources.GetString("grdBodegas.PropBag");
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // sucursalClienteTableAdapter1
            // 
            this.sucursalClienteTableAdapter1.ClearBeforeFill = true;
            // 
            // defaultsTableAdapter1
            // 
            this.defaultsTableAdapter1.ClearBeforeFill = true;
            // 
            // cmbUbicacionPredeterminada
            // 
            this.cmbUbicacionPredeterminada.DataSource = this.dsSpx1;
            this.cmbUbicacionPredeterminada.DisplayMember = "sucursalCliente.nombreSucursal";
            this.cmbUbicacionPredeterminada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUbicacionPredeterminada.FormattingEnabled = true;
            this.cmbUbicacionPredeterminada.Location = new System.Drawing.Point(166, 45);
            this.cmbUbicacionPredeterminada.Name = "cmbUbicacionPredeterminada";
            this.cmbUbicacionPredeterminada.Size = new System.Drawing.Size(251, 21);
            this.cmbUbicacionPredeterminada.TabIndex = 11;
            this.cmbUbicacionPredeterminada.ValueMember = "sucursalCliente.codSucursal";
            this.cmbUbicacionPredeterminada.SelectedIndexChanged += new System.EventHandler(this.cmbUbicacionPredeterminada_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ubicacion Prederminada Taller";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Estado Prederminado Taller";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbEstadoPredetermindo
            // 
            this.cmbEstadoPredetermindo.DataSource = this.dsSpx1;
            this.cmbEstadoPredetermindo.DisplayMember = "estadoLocalEquipos.nombreEstadoLocal";
            this.cmbEstadoPredetermindo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoPredetermindo.FormattingEnabled = true;
            this.cmbEstadoPredetermindo.Location = new System.Drawing.Point(165, 80);
            this.cmbEstadoPredetermindo.Name = "cmbEstadoPredetermindo";
            this.cmbEstadoPredetermindo.Size = new System.Drawing.Size(251, 21);
            this.cmbEstadoPredetermindo.TabIndex = 14;
            this.cmbEstadoPredetermindo.ValueMember = "estadoLocalEquipos.codEstadoLocal";
            // 
            // estadoLocalEquiposTableAdapter1
            // 
            this.estadoLocalEquiposTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 479);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 50);
            this.panel1.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkTrasladosAutomaticosAlCerrarLaorden);
            this.groupBox1.Controls.Add(this.cmbEstadoPredetermindo);
            this.groupBox1.Controls.Add(this.cmbUbicacionPredeterminada);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(10, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 112);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Traslados Automaticos al Cerrar la orden de Servicio Interna";
            // 
            // chkTrasladosAutomaticosAlCerrarLaorden
            // 
            this.chkTrasladosAutomaticosAlCerrarLaorden.AutoSize = true;
            this.chkTrasladosAutomaticosAlCerrarLaorden.Location = new System.Drawing.Point(165, 20);
            this.chkTrasladosAutomaticosAlCerrarLaorden.Name = "chkTrasladosAutomaticosAlCerrarLaorden";
            this.chkTrasladosAutomaticosAlCerrarLaorden.Size = new System.Drawing.Size(73, 17);
            this.chkTrasladosAutomaticosAlCerrarLaorden.TabIndex = 15;
            this.chkTrasladosAutomaticosAlCerrarLaorden.Text = "Habilitado";
            this.chkTrasladosAutomaticosAlCerrarLaorden.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkEstadoAutomaticosAlRelizarEntrada);
            this.groupBox2.Controls.Add(this.chkTrasladosAutomaticosAlRelizarEntrada);
            this.groupBox2.Controls.Add(this.cmbEstadoEntrada);
            this.groupBox2.Controls.Add(this.cmbUbicacionEntrada);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(446, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 111);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Traslados Automaticos al Realizar Una Entrada";
            // 
            // chkTrasladosAutomaticosAlRelizarEntrada
            // 
            this.chkTrasladosAutomaticosAlRelizarEntrada.AutoSize = true;
            this.chkTrasladosAutomaticosAlRelizarEntrada.Location = new System.Drawing.Point(69, 46);
            this.chkTrasladosAutomaticosAlRelizarEntrada.Name = "chkTrasladosAutomaticosAlRelizarEntrada";
            this.chkTrasladosAutomaticosAlRelizarEntrada.Size = new System.Drawing.Size(73, 17);
            this.chkTrasladosAutomaticosAlRelizarEntrada.TabIndex = 16;
            this.chkTrasladosAutomaticosAlRelizarEntrada.Text = "Habilitado";
            this.chkTrasladosAutomaticosAlRelizarEntrada.UseVisualStyleBackColor = true;
            // 
            // cmbEstadoEntrada
            // 
            this.cmbEstadoEntrada.DataSource = this.dsSpx2;
            this.cmbEstadoEntrada.DisplayMember = "estadoLocalEquipos.nombreEstadoLocal";
            this.cmbEstadoEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoEntrada.FormattingEnabled = true;
            this.cmbEstadoEntrada.Location = new System.Drawing.Point(165, 81);
            this.cmbEstadoEntrada.Name = "cmbEstadoEntrada";
            this.cmbEstadoEntrada.Size = new System.Drawing.Size(251, 21);
            this.cmbEstadoEntrada.TabIndex = 14;
            this.cmbEstadoEntrada.ValueMember = "estadoLocalEquipos.codEstadoLocal";
            // 
            // dsSpx2
            // 
            this.dsSpx2.DataSetName = "dsSpx";
            this.dsSpx2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbUbicacionEntrada
            // 
            this.cmbUbicacionEntrada.DataSource = this.dsSpx2;
            this.cmbUbicacionEntrada.DisplayMember = "sucursalCliente.nombreSucursal";
            this.cmbUbicacionEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUbicacionEntrada.FormattingEnabled = true;
            this.cmbUbicacionEntrada.Location = new System.Drawing.Point(166, 46);
            this.cmbUbicacionEntrada.Name = "cmbUbicacionEntrada";
            this.cmbUbicacionEntrada.Size = new System.Drawing.Size(251, 21);
            this.cmbUbicacionEntrada.TabIndex = 11;
            this.cmbUbicacionEntrada.ValueMember = "sucursalCliente.codSucursal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ubicacion";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Estado";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkEstadoAutomaticosAlRelizarEntrada
            // 
            this.chkEstadoAutomaticosAlRelizarEntrada.AutoSize = true;
            this.chkEstadoAutomaticosAlRelizarEntrada.Location = new System.Drawing.Point(69, 83);
            this.chkEstadoAutomaticosAlRelizarEntrada.Name = "chkEstadoAutomaticosAlRelizarEntrada";
            this.chkEstadoAutomaticosAlRelizarEntrada.Size = new System.Drawing.Size(73, 17);
            this.chkEstadoAutomaticosAlRelizarEntrada.TabIndex = 17;
            this.chkEstadoAutomaticosAlRelizarEntrada.Text = "Habilitado";
            this.chkEstadoAutomaticosAlRelizarEntrada.UseVisualStyleBackColor = true;
            // 
            // frmInformacionLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(906, 529);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grdBodegas);
            this.Controls.Add(this.txtNombreEmpresa);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInformacionLocal";
            this.Text = "Informacion Local";
            this.Load += new System.EventHandler(this.frmInformacionLocal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBodegas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SPControladoraDatos.dsSpx dsSpx1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreEmpresa;
        private SPControladoraDatos.dsSpxTableAdapters.clientesTableAdapter clientesTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.sucursalClienteTableAdapter sucursalClienteTableAdapter1;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdBodegas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter defaultsTableAdapter1;
        private System.Windows.Forms.ComboBox cmbUbicacionPredeterminada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEstadoPredetermindo;
        private SPControladoraDatos.dsSpxTableAdapters.estadoLocalEquiposTableAdapter estadoLocalEquiposTableAdapter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbEstadoEntrada;
        private System.Windows.Forms.ComboBox cmbUbicacionEntrada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private SPControladoraDatos.dsSpx dsSpx2;
        private System.Windows.Forms.CheckBox chkTrasladosAutomaticosAlCerrarLaorden;
        private System.Windows.Forms.CheckBox chkTrasladosAutomaticosAlRelizarEntrada;
        private System.Windows.Forms.CheckBox chkEstadoAutomaticosAlRelizarEntrada;
    }
}