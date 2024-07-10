namespace spProcesos.ordenPrestamo
{
    partial class frmEntregarRepuestosIng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntregarRepuestosIng));
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumeroOrdenPrestamo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.btnEntregarTodo = new DevComponents.DotNetBar.ButtonX();
            this.btnEntregarRepuesto = new DevComponents.DotNetBar.ButtonX();
            this.btnModificarRepuestos = new DevComponents.DotNetBar.ButtonX();
            this.grdPrestadas = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsSpx2 = new SPControladoraDatos.dsSpx();
            this.grdRepuestos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.ordenPrestamoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.OrdenPrestamoTableAdapter();
            this.pltRepuestosxOrdenPrestamoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.pltRepuestosxOrdenPrestamoTableAdapter();
            this.repuestosxOrdenPrestamoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.repuestosxOrdenPrestamoTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrestadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRepuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BackColor = System.Drawing.Color.White;
            this.txtObservaciones.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(171, 32);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(607, 96);
            this.txtObservaciones.TabIndex = 134;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 133;
            this.label3.Text = "Observaciones Entrega";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 347);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 50);
            this.panel1.TabIndex = 132;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(616, 15);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(697, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 13);
            this.label7.TabIndex = 124;
            this.label7.Text = "Numero Orden de Prestamo";
            // 
            // txtNumeroOrdenPrestamo
            // 
            this.txtNumeroOrdenPrestamo.BackColor = System.Drawing.Color.White;
            this.txtNumeroOrdenPrestamo.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroOrdenPrestamo.Location = new System.Drawing.Point(275, 5);
            this.txtNumeroOrdenPrestamo.Name = "txtNumeroOrdenPrestamo";
            this.txtNumeroOrdenPrestamo.ReadOnly = true;
            this.txtNumeroOrdenPrestamo.Size = new System.Drawing.Size(96, 21);
            this.txtNumeroOrdenPrestamo.TabIndex = 125;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 129;
            this.label9.Text = "Repuestos Aprobados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 137;
            this.label1.Text = "Repuestos Entregados";
            // 
            // btnEntregarTodo
            // 
            this.btnEntregarTodo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEntregarTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnEntregarTodo, "Entregar Todos los Repuestos");
            this.btnEntregarTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnEntregarTodo.Image")));
            this.btnEntregarTodo.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnEntregarTodo.Location = new System.Drawing.Point(405, 158);
            this.btnEntregarTodo.Name = "btnEntregarTodo";
            this.btnEntregarTodo.Size = new System.Drawing.Size(29, 29);
            this.btnEntregarTodo.TabIndex = 138;
            this.btnEntregarTodo.Click += new System.EventHandler(this.btnEntregarTodo_Click);
            // 
            // btnEntregarRepuesto
            // 
            this.btnEntregarRepuesto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEntregarRepuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnEntregarRepuesto, "Entregar Repuestos");
            this.btnEntregarRepuesto.Image = ((System.Drawing.Image)(resources.GetObject("btnEntregarRepuesto.Image")));
            this.btnEntregarRepuesto.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnEntregarRepuesto.Location = new System.Drawing.Point(405, 193);
            this.btnEntregarRepuesto.Name = "btnEntregarRepuesto";
            this.btnEntregarRepuesto.Size = new System.Drawing.Size(29, 29);
            this.btnEntregarRepuesto.TabIndex = 131;
            this.btnEntregarRepuesto.Click += new System.EventHandler(this.btnEntregarRepuesto_Click);
            // 
            // btnModificarRepuestos
            // 
            this.btnModificarRepuestos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnModificarRepuestos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnModificarRepuestos, "Modificar Cantidad Entregada");
            this.btnModificarRepuestos.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarRepuestos.Image")));
            this.btnModificarRepuestos.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnModificarRepuestos.Location = new System.Drawing.Point(405, 228);
            this.btnModificarRepuestos.Name = "btnModificarRepuestos";
            this.btnModificarRepuestos.Size = new System.Drawing.Size(29, 29);
            this.btnModificarRepuestos.TabIndex = 130;
            this.btnModificarRepuestos.Click += new System.EventHandler(this.btnModificarRepuestos_Click);
            // 
            // grdPrestadas
            // 
            this.grdPrestadas.AllowUpdate = false;
            this.grdPrestadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdPrestadas.CaptionHeight = 17;
            this.grdPrestadas.DataMember = "pltRepuestosxOrdenPrestamo";
            this.grdPrestadas.DataSource = this.dsSpx2;
            this.grdPrestadas.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdPrestadas.GroupByCaption = "Drag a column header here to group by that column";
            this.grdPrestadas.Images.Add(((System.Drawing.Image)(resources.GetObject("grdPrestadas.Images"))));
            this.grdPrestadas.Location = new System.Drawing.Point(440, 156);
            this.grdPrestadas.Name = "grdPrestadas";
            this.grdPrestadas.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdPrestadas.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdPrestadas.PreviewInfo.ZoomFactor = 75D;
            this.grdPrestadas.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdPrestadas.PrintInfo.PageSettings")));
            this.grdPrestadas.RowHeight = 15;
            this.grdPrestadas.Size = new System.Drawing.Size(338, 185);
            this.grdPrestadas.TabIndex = 136;
            this.grdPrestadas.Text = "c1TrueDBGrid1";
            this.grdPrestadas.PropBag = resources.GetString("grdPrestadas.PropBag");
            // 
            // dsSpx2
            // 
            this.dsSpx2.DataSetName = "dsSpx";
            this.dsSpx2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdRepuestos
            // 
            this.grdRepuestos.AllowUpdate = false;
            this.grdRepuestos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdRepuestos.CaptionHeight = 17;
            this.grdRepuestos.DataMember = "pltRepuestosxOrdenPrestamo";
            this.grdRepuestos.DataSource = this.dsSpx1;
            this.grdRepuestos.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdRepuestos.GroupByCaption = "Drag a column header here to group by that column";
            this.grdRepuestos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdRepuestos.Images"))));
            this.grdRepuestos.Location = new System.Drawing.Point(12, 156);
            this.grdRepuestos.Name = "grdRepuestos";
            this.grdRepuestos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdRepuestos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdRepuestos.PreviewInfo.ZoomFactor = 75D;
            this.grdRepuestos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdRepuestos.PrintInfo.PageSettings")));
            this.grdRepuestos.RowHeight = 15;
            this.grdRepuestos.Size = new System.Drawing.Size(387, 185);
            this.grdRepuestos.TabIndex = 128;
            this.grdRepuestos.Text = "c1TrueDBGrid1";
            this.grdRepuestos.PropBag = resources.GetString("grdRepuestos.PropBag");
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordenPrestamoTableAdapter1
            // 
            this.ordenPrestamoTableAdapter1.ClearBeforeFill = true;
            // 
            // pltRepuestosxOrdenPrestamoTableAdapter1
            // 
            this.pltRepuestosxOrdenPrestamoTableAdapter1.ClearBeforeFill = true;
            // 
            // repuestosxOrdenPrestamoTableAdapter1
            // 
            this.repuestosxOrdenPrestamoTableAdapter1.ClearBeforeFill = true;
            // 
            // frmEntregarRepuestosIng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(790, 397);
            this.ControlBox = false;
            this.Controls.Add(this.btnEntregarTodo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdPrestadas);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumeroOrdenPrestamo);
            this.Controls.Add(this.btnEntregarRepuesto);
            this.Controls.Add(this.btnModificarRepuestos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grdRepuestos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEntregarRepuestosIng";
            this.Text = "Entregar Repuestos";
            this.Load += new System.EventHandler(this.frmEntregarRepuestosIng_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPrestadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRepuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.OrdenPrestamoTableAdapter ordenPrestamoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.pltRepuestosxOrdenPrestamoTableAdapter pltRepuestosxOrdenPrestamoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.repuestosxOrdenPrestamoTableAdapter repuestosxOrdenPrestamoTableAdapter1;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumeroOrdenPrestamo;
        private DevComponents.DotNetBar.ButtonX btnEntregarRepuesto;
        private DevComponents.DotNetBar.ButtonX btnModificarRepuestos;
        private System.Windows.Forms.Label label9;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdRepuestos;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdPrestadas;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private SPControladoraDatos.dsSpx dsSpx2;
        private DevComponents.DotNetBar.ButtonX btnEntregarTodo;
    }
}