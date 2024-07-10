namespace spProcesos.ordenPrestamo
{
    partial class frmRecibirRepuestosIng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecibirRepuestosIng));
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.btnEntregarTodo = new DevComponents.DotNetBar.ButtonX();
            this.btnEntregarRepuesto = new DevComponents.DotNetBar.ButtonX();
            this.btnModificarRepuestos = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumeroOrdenPrestamo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.txtNotaSalida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grdDevueltos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsSpx2 = new SPControladoraDatos.dsSpx();
            this.grdPrestados = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.ordenPrestamoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.OrdenPrestamoTableAdapter();
            this.pltRepuestosxOrdenPrestamoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.pltRepuestosxOrdenPrestamoTableAdapter();
            this.repuestosxOrdenPrestamoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.repuestosxOrdenPrestamoTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDevueltos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrestados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntregarTodo
            // 
            this.btnEntregarTodo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEntregarTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnEntregarTodo, "Devolver Todos los Repuestos");
            this.btnEntregarTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnEntregarTodo.Image")));
            this.btnEntregarTodo.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnEntregarTodo.Location = new System.Drawing.Point(405, 153);
            this.btnEntregarTodo.Name = "btnEntregarTodo";
            this.btnEntregarTodo.Size = new System.Drawing.Size(29, 29);
            this.btnEntregarTodo.TabIndex = 150;
            this.btnEntregarTodo.Click += new System.EventHandler(this.btnEntregarTodo_Click);
            // 
            // btnEntregarRepuesto
            // 
            this.btnEntregarRepuesto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEntregarRepuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnEntregarRepuesto, "Devolver Repuestos");
            this.btnEntregarRepuesto.Image = ((System.Drawing.Image)(resources.GetObject("btnEntregarRepuesto.Image")));
            this.btnEntregarRepuesto.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnEntregarRepuesto.Location = new System.Drawing.Point(405, 188);
            this.btnEntregarRepuesto.Name = "btnEntregarRepuesto";
            this.btnEntregarRepuesto.Size = new System.Drawing.Size(29, 29);
            this.btnEntregarRepuesto.TabIndex = 144;
            this.btnEntregarRepuesto.Click += new System.EventHandler(this.btnEntregarRepuesto_Click);
            // 
            // btnModificarRepuestos
            // 
            this.btnModificarRepuestos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnModificarRepuestos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnModificarRepuestos, "Modificar Cantidad Devuelta");
            this.btnModificarRepuestos.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarRepuestos.Image")));
            this.btnModificarRepuestos.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnModificarRepuestos.Location = new System.Drawing.Point(405, 223);
            this.btnModificarRepuestos.Name = "btnModificarRepuestos";
            this.btnModificarRepuestos.Size = new System.Drawing.Size(29, 29);
            this.btnModificarRepuestos.TabIndex = 143;
            this.btnModificarRepuestos.Click += new System.EventHandler(this.btnModificarRepuestos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 149;
            this.label1.Text = "Repuestos Devueltos";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BackColor = System.Drawing.Color.White;
            this.txtObservaciones.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(171, 29);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(607, 59);
            this.txtObservaciones.TabIndex = 147;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 146;
            this.label3.Text = "Observaciones Devolucion";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 429);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 50);
            this.panel1.TabIndex = 145;
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
            this.label7.Location = new System.Drawing.Point(6, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 13);
            this.label7.TabIndex = 139;
            this.label7.Text = "Numero Orden de Prestamo";
            // 
            // txtNumeroOrdenPrestamo
            // 
            this.txtNumeroOrdenPrestamo.BackColor = System.Drawing.Color.White;
            this.txtNumeroOrdenPrestamo.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroOrdenPrestamo.Location = new System.Drawing.Point(171, 2);
            this.txtNumeroOrdenPrestamo.Name = "txtNumeroOrdenPrestamo";
            this.txtNumeroOrdenPrestamo.ReadOnly = true;
            this.txtNumeroOrdenPrestamo.Size = new System.Drawing.Size(96, 21);
            this.txtNumeroOrdenPrestamo.TabIndex = 140;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 142;
            this.label9.Text = "Repuestos Prestados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 152;
            this.label2.Text = "Numero de Factura";
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.BackColor = System.Drawing.Color.White;
            this.txtNumeroFactura.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroFactura.Location = new System.Drawing.Point(115, 99);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(96, 21);
            this.txtNumeroFactura.TabIndex = 153;
            // 
            // txtNotaSalida
            // 
            this.txtNotaSalida.BackColor = System.Drawing.Color.White;
            this.txtNotaSalida.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotaSalida.Location = new System.Drawing.Point(317, 99);
            this.txtNotaSalida.Name = "txtNotaSalida";
            this.txtNotaSalida.Size = new System.Drawing.Size(96, 21);
            this.txtNotaSalida.TabIndex = 155;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(217, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 154;
            this.label4.Text = "Numero nota Salida";
            // 
            // grdDevueltos
            // 
            this.grdDevueltos.AllowUpdate = false;
            this.grdDevueltos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDevueltos.CaptionHeight = 17;
            this.grdDevueltos.DataMember = "pltRepuestosxOrdenPrestamo";
            this.grdDevueltos.DataSource = this.dsSpx2;
            this.grdDevueltos.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdDevueltos.GroupByCaption = "Drag a column header here to group by that column";
            this.grdDevueltos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDevueltos.Images"))));
            this.grdDevueltos.Location = new System.Drawing.Point(440, 153);
            this.grdDevueltos.Name = "grdDevueltos";
            this.grdDevueltos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDevueltos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDevueltos.PreviewInfo.ZoomFactor = 75D;
            this.grdDevueltos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDevueltos.PrintInfo.PageSettings")));
            this.grdDevueltos.RowHeight = 15;
            this.grdDevueltos.Size = new System.Drawing.Size(332, 270);
            this.grdDevueltos.TabIndex = 151;
            this.grdDevueltos.Text = "c1TrueDBGrid1";
            this.grdDevueltos.PropBag = resources.GetString("grdDevueltos.PropBag");
            // 
            // dsSpx2
            // 
            this.dsSpx2.DataSetName = "dsSpx";
            this.dsSpx2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdPrestados
            // 
            this.grdPrestados.AllowUpdate = false;
            this.grdPrestados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdPrestados.CaptionHeight = 17;
            this.grdPrestados.DataMember = "pltRepuestosxOrdenPrestamo";
            this.grdPrestados.DataSource = this.dsSpx1;
            this.grdPrestados.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdPrestados.GroupByCaption = "Drag a column header here to group by that column";
            this.grdPrestados.Images.Add(((System.Drawing.Image)(resources.GetObject("grdPrestados.Images"))));
            this.grdPrestados.Location = new System.Drawing.Point(12, 153);
            this.grdPrestados.Name = "grdPrestados";
            this.grdPrestados.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdPrestados.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdPrestados.PreviewInfo.ZoomFactor = 75D;
            this.grdPrestados.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdPrestados.PrintInfo.PageSettings")));
            this.grdPrestados.RowHeight = 15;
            this.grdPrestados.Size = new System.Drawing.Size(387, 270);
            this.grdPrestados.TabIndex = 141;
            this.grdPrestados.Text = "c1TrueDBGrid1";
            this.grdPrestados.PropBag = resources.GetString("grdPrestados.PropBag");
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
            // frmRecibirRepuestosIng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 479);
            this.ControlBox = false;
            this.Controls.Add(this.txtNotaSalida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumeroFactura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grdDevueltos);
            this.Controls.Add(this.btnEntregarTodo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumeroOrdenPrestamo);
            this.Controls.Add(this.btnEntregarRepuesto);
            this.Controls.Add(this.btnModificarRepuestos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grdPrestados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRecibirRepuestosIng";
            this.Text = "Recibir Repuestos";
            this.Load += new System.EventHandler(this.frmRecibirRepuestosIng_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDevueltos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrestados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private SPControladoraDatos.dsSpx dsSpx2;
        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.OrdenPrestamoTableAdapter ordenPrestamoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.pltRepuestosxOrdenPrestamoTableAdapter pltRepuestosxOrdenPrestamoTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.repuestosxOrdenPrestamoTableAdapter repuestosxOrdenPrestamoTableAdapter1;
        private DevComponents.DotNetBar.ButtonX btnEntregarTodo;
        private System.Windows.Forms.Label label1;
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
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdPrestados;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdDevueltos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.TextBox txtNotaSalida;
        private System.Windows.Forms.Label label4;
    }
}