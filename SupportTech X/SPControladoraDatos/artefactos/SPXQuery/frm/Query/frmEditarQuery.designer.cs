using SPControladoraDatos.artefactos.SPXQuery.data;

namespace SPControladoraDatos.artefactos.SPXQuery.frm.Query
{
    partial class frmEditarQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarQuery));
            this.grddatos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnProbar = new DevComponents.DotNetBar.ButtonX();
            this.dsPar1 = new dsSPXQuery();
            this.grdParametros = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.btnAgregarParametros = new DevComponents.DotNetBar.ButtonX();
            this.btnEliminarParametro = new DevComponents.DotNetBar.ButtonX();
            this.btnEditarParametro = new DevComponents.DotNetBar.ButtonX();
            this.label3 = new System.Windows.Forms.Label();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.btnGuardar = new DevComponents.DotNetBar.ButtonX();
            this.btnGuardarYcerrar = new DevComponents.DotNetBar.ButtonX();
            this.btnCancelar = new DevComponents.DotNetBar.ButtonX();
            this.txtSql = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCampoFecha = new System.Windows.Forms.TextBox();
            this.chkFiltraxPeriodo = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.nmPeriodoInicial = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dsSPXSeguridad1 = new SPXSeguridad.data.dsSPXSeguridad();
            ((System.ComponentModel.ISupportInitialize)(this.grddatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdParametros)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPeriodoInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).BeginInit();
            this.SuspendLayout();
            // 
            // grddatos
            // 
            this.grddatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grddatos.GroupByCaption = "Drag a column header here to group by that column";
            this.grddatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grddatos.Images"))));
            this.grddatos.Location = new System.Drawing.Point(12, 392);
            this.grddatos.Name = "grddatos";
            this.grddatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grddatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grddatos.PreviewInfo.ZoomFactor = 75D;
            this.grddatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grddatos.PrintInfo.PageSettings")));
            this.grddatos.Size = new System.Drawing.Size(976, 186);
            this.grddatos.TabIndex = 0;
            this.grddatos.Text = "c1TrueDBGrid1";
            this.grddatos.PropBag = resources.GetString("grddatos.PropBag");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sentencia SQL";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(99, 17);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(264, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // btnProbar
            // 
            this.btnProbar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnProbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProbar.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnProbar.Location = new System.Drawing.Point(7, 103);
            this.btnProbar.Name = "btnProbar";
            this.btnProbar.Size = new System.Drawing.Size(109, 27);
            this.btnProbar.TabIndex = 82;
            this.btnProbar.Text = "Probar SQL";
            this.btnProbar.Click += new System.EventHandler(this.btnProbar_Click);
            // 
            // dsPar1
            // 
            this.dsPar1.DataSetName = "dsSPXQuery";
            this.dsPar1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdParametros
            // 
            this.grdParametros.AllowUpdate = false;
            this.grdParametros.DataMember = "cgq_parametrosquery";
            this.grdParametros.DataSource = this.dsPar1;
            this.grdParametros.GroupByCaption = "Drag a column header here to group by that column";
            this.grdParametros.Images.Add(((System.Drawing.Image)(resources.GetObject("grdParametros.Images"))));
            this.grdParametros.Location = new System.Drawing.Point(589, 46);
            this.grdParametros.Name = "grdParametros";
            this.grdParametros.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdParametros.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdParametros.PreviewInfo.ZoomFactor = 75D;
            this.grdParametros.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdParametros.PrintInfo.PageSettings")));
            this.grdParametros.Size = new System.Drawing.Size(386, 97);
            this.grdParametros.TabIndex = 84;
            this.grdParametros.Text = "c1TrueDBGrid1";
            this.grdParametros.PropBag = resources.GetString("grdParametros.PropBag");
            // 
            // btnAgregarParametros
            // 
            this.btnAgregarParametros.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnAgregarParametros, "Agregar Parametros");
            this.btnAgregarParametros.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnAgregarParametros.Location = new System.Drawing.Point(888, 12);
            this.btnAgregarParametros.Name = "btnAgregarParametros";
            this.btnAgregarParametros.Size = new System.Drawing.Size(28, 28);
            this.btnAgregarParametros.TabIndex = 86;
            this.btnAgregarParametros.Click += new System.EventHandler(this.btnAgregarParametros_Click);
            // 
            // btnEliminarParametro
            // 
            this.btnEliminarParametro.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEliminarParametro.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnEliminarParametro.Location = new System.Drawing.Point(947, 12);
            this.btnEliminarParametro.Name = "btnEliminarParametro";
            this.btnEliminarParametro.Size = new System.Drawing.Size(28, 28);
            this.btnEliminarParametro.TabIndex = 85;
            this.btnEliminarParametro.Click += new System.EventHandler(this.btnEliminarParametro_Click);
            // 
            // btnEditarParametro
            // 
            this.btnEditarParametro.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnEditarParametro, "Editar parametro");
            this.btnEditarParametro.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnEditarParametro.Location = new System.Drawing.Point(918, 12);
            this.btnEditarParametro.Name = "btnEditarParametro";
            this.btnEditarParametro.Size = new System.Drawing.Size(28, 28);
            this.btnEditarParametro.TabIndex = 87;
            this.btnEditarParametro.Click += new System.EventHandler(this.btnEditarParametro_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 88;
            this.label3.Text = "Parametros";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnGuardar, "Guardar");
            this.btnGuardar.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnGuardar.Location = new System.Drawing.Point(248, 103);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(83, 27);
            this.btnGuardar.TabIndex = 90;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnGuardarYcerrar
            // 
            this.btnGuardarYcerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGuardarYcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnGuardarYcerrar, "Guardar");
            this.balloonTip1.SetBalloonText(this.btnGuardarYcerrar, null);
            this.btnGuardarYcerrar.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnGuardarYcerrar.Location = new System.Drawing.Point(120, 103);
            this.btnGuardarYcerrar.Name = "btnGuardarYcerrar";
            this.btnGuardarYcerrar.Size = new System.Drawing.Size(125, 27);
            this.btnGuardarYcerrar.TabIndex = 111;
            this.btnGuardarYcerrar.Text = "Guardar y Cerrar";
            this.btnGuardarYcerrar.Click += new System.EventHandler(this.btnGuardarYcerrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnCancelar.Location = new System.Drawing.Point(334, 103);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 27);
            this.btnCancelar.TabIndex = 89;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtSql
            // 
            this.txtSql.AcceptsTab = true;
            this.txtSql.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSql.BackColor = System.Drawing.Color.Honeydew;
            this.txtSql.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSql.ForeColor = System.Drawing.Color.Maroon;
            this.txtSql.Location = new System.Drawing.Point(10, 168);
            this.txtSql.Name = "txtSql";
            this.txtSql.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtSql.Size = new System.Drawing.Size(968, 205);
            this.txtSql.TabIndex = 91;
            this.txtSql.Text = "";
            this.txtSql.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 99;
            this.label5.Text = "Campo Fecha:";
            // 
            // txtCampoFecha
            // 
            this.txtCampoFecha.Location = new System.Drawing.Point(200, 41);
            this.txtCampoFecha.Name = "txtCampoFecha";
            this.txtCampoFecha.Size = new System.Drawing.Size(160, 20);
            this.txtCampoFecha.TabIndex = 100;
            // 
            // chkFiltraxPeriodo
            // 
            this.chkFiltraxPeriodo.AutoSize = true;
            this.chkFiltraxPeriodo.Location = new System.Drawing.Point(7, 43);
            this.chkFiltraxPeriodo.Name = "chkFiltraxPeriodo";
            this.chkFiltraxPeriodo.Size = new System.Drawing.Size(105, 17);
            this.chkFiltraxPeriodo.TabIndex = 108;
            this.chkFiltraxPeriodo.Text = "Filtra por Periodo";
            this.chkFiltraxPeriodo.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.nmPeriodoInicial);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.chkFiltraxPeriodo);
            this.groupBox5.Controls.Add(this.txtNombre);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.txtCampoFecha);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(10, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(557, 77);
            this.groupBox5.TabIndex = 110;
            this.groupBox5.TabStop = false;
            // 
            // nmPeriodoInicial
            // 
            this.nmPeriodoInicial.Location = new System.Drawing.Point(458, 41);
            this.nmPeriodoInicial.Name = "nmPeriodoInicial";
            this.nmPeriodoInicial.Size = new System.Drawing.Size(58, 20);
            this.nmPeriodoInicial.TabIndex = 113;
            this.nmPeriodoInicial.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(522, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 112;
            this.label10.Text = "dias";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(379, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 111;
            this.label9.Text = "Periodo Inicial";
            // 
            // dsSPXSeguridad1
            // 
            this.dsSPXSeguridad1.DataSetName = "dsSPXSeguridad";
            this.dsSPXSeguridad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmEditarQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 590);
            this.Controls.Add(this.btnGuardarYcerrar);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.txtSql);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEditarParametro);
            this.Controls.Add(this.btnAgregarParametros);
            this.Controls.Add(this.btnEliminarParametro);
            this.Controls.Add(this.grdParametros);
            this.Controls.Add(this.btnProbar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grddatos);
            this.Name = "frmEditarQuery";
            this.Text = "Constructor de Query";
            this.Load += new System.EventHandler(this.frmEditarQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grddatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdParametros)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPeriodoInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grddatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private DevComponents.DotNetBar.ButtonX btnProbar;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdParametros;
        private DevComponents.DotNetBar.ButtonX btnAgregarParametros;
        private DevComponents.DotNetBar.ButtonX btnEliminarParametro;
        private DevComponents.DotNetBar.ButtonX btnEditarParametro;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private DevComponents.DotNetBar.ButtonX btnGuardar;
        private DevComponents.DotNetBar.ButtonX btnCancelar;
        private System.Windows.Forms.RichTextBox txtSql;
        private dsSPXQuery dsPar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCampoFecha;
        private System.Windows.Forms.CheckBox chkFiltraxPeriodo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown nmPeriodoInicial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad1;
        private DevComponents.DotNetBar.ButtonX btnGuardarYcerrar;
    }
}