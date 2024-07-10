namespace spProcesos.ordenPrestamo
{
    partial class frmRecibirRepuestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecibirRepuestos));
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.btnEntregarRepuestos = new DevComponents.DotNetBar.ButtonX();
            this.btnverSolicitud = new DevComponents.DotNetBar.ButtonX();
            this.btnExportarExcel = new DevComponents.DotNetBar.ButtonX();
            this.grdDatos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.ordenPrestamoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.OrdenPrestamoTableAdapter();
            this.grdDatos.BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntregarRepuestos
            // 
            this.btnEntregarRepuestos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEntregarRepuestos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnEntregarRepuestos, "Recibir Repuestos");
            this.btnEntregarRepuestos.Image = ((System.Drawing.Image)(resources.GetObject("btnEntregarRepuestos.Image")));
            this.btnEntregarRepuestos.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnEntregarRepuestos.Location = new System.Drawing.Point(688, 11);
            this.btnEntregarRepuestos.Name = "btnEntregarRepuestos";
            this.btnEntregarRepuestos.Size = new System.Drawing.Size(33, 33);
            this.btnEntregarRepuestos.TabIndex = 80;
            this.btnEntregarRepuestos.Click += new System.EventHandler(this.btnEntregarRepuestos_Click);
            // 
            // btnverSolicitud
            // 
            this.btnverSolicitud.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnverSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnverSolicitud, "Ver Orden de Prestamo");
            this.btnverSolicitud.Image = ((System.Drawing.Image)(resources.GetObject("btnverSolicitud.Image")));
            this.btnverSolicitud.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnverSolicitud.Location = new System.Drawing.Point(653, 11);
            this.btnverSolicitud.Name = "btnverSolicitud";
            this.btnverSolicitud.Size = new System.Drawing.Size(33, 33);
            this.btnverSolicitud.TabIndex = 79;
            this.btnverSolicitud.Click += new System.EventHandler(this.btnverSolicitud_Click);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExportarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnExportarExcel, "Exportar Excel");
            this.btnExportarExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarExcel.Image")));
            this.btnExportarExcel.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnExportarExcel.Location = new System.Drawing.Point(723, 11);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(33, 33);
            this.btnExportarExcel.TabIndex = 78;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUpdate = false;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.DataMember = "OrdenPrestamo";
            this.grdDatos.DataSource = this.dsSpx1;
            this.grdDatos.FilterBar = true;
            this.grdDatos.GroupByCaption = "";
            this.grdDatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDatos.Images"))));
            this.grdDatos.Location = new System.Drawing.Point(12, 47);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(740, 440);
            this.grdDatos.TabIndex = 77;
            this.grdDatos.Text = "c1TrueDBGrid1";
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
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
            // frmRecibirRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(765, 499);
            this.Controls.Add(this.btnEntregarRepuestos);
            this.Controls.Add(this.btnverSolicitud);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.grdDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRecibirRepuestos";
            this.Text = "Recibir Repuestos";
            this.Load += new System.EventHandler(this.frmRecibirRepuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.OrdenPrestamoTableAdapter ordenPrestamoTableAdapter1;
        private DevComponents.DotNetBar.ButtonX btnEntregarRepuestos;
        private DevComponents.DotNetBar.ButtonX btnverSolicitud;
        private DevComponents.DotNetBar.ButtonX btnExportarExcel;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdDatos;
    }
}