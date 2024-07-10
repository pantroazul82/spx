namespace spProcesos.inventarioRepuestos
{
    partial class frmEntradaRepuestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntradaRepuestos));
            this.controladorColumnas1 = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas();
            this.grdDatos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.btnNueva = new DevComponents.DotNetBar.ButtonX();
            this.btnVerRecoleccion = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // controladorColumnas1
            // 
            this.controladorColumnas1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controladorColumnas1.BackColor = System.Drawing.Color.Transparent;
            this.controladorColumnas1.grilla = null;
            this.controladorColumnas1.Location = new System.Drawing.Point(533, 32);
            this.controladorColumnas1.MostrarContraer = true;
            this.controladorColumnas1.MostrarExcel = true;
            this.controladorColumnas1.MostrarExpandir = true;
            this.controladorColumnas1.MostrarLimpiar = true;
            this.controladorColumnas1.Name = "controladorColumnas1";
            this.controladorColumnas1.nombreLibro = null;
            this.controladorColumnas1.Size = new System.Drawing.Size(216, 29);
            this.controladorColumnas1.TabIndex = 11;
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUpdate = false;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.DataMember = "pltListaProgramaciones";
            this.grdDatos.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdDatos.FilterBar = true;
            this.grdDatos.GroupByCaption = "";
            this.grdDatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDatos.Images"))));
            this.grdDatos.Location = new System.Drawing.Point(15, 67);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75D;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(734, 395);
            this.grdDatos.TabIndex = 10;
            this.grdDatos.Text = "c1TrueDBGrid1";
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
            // 
            // btnNueva
            // 
            this.btnNueva.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNueva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNueva.Image = ((System.Drawing.Image)(resources.GetObject("btnNueva.Image")));
            this.btnNueva.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnNueva.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnNueva.Location = new System.Drawing.Point(464, 32);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(30, 29);
            this.btnNueva.TabIndex = 111;
            this.btnNueva.Tooltip = "Agregar";
            // 
            // btnVerRecoleccion
            // 
            this.btnVerRecoleccion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVerRecoleccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerRecoleccion.Image = ((System.Drawing.Image)(resources.GetObject("btnVerRecoleccion.Image")));
            this.btnVerRecoleccion.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnVerRecoleccion.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnVerRecoleccion.Location = new System.Drawing.Point(497, 32);
            this.btnVerRecoleccion.Name = "btnVerRecoleccion";
            this.btnVerRecoleccion.Size = new System.Drawing.Size(30, 29);
            this.btnVerRecoleccion.TabIndex = 110;
            this.btnVerRecoleccion.Tooltip = "Editar";
            // 
            // frmEntradaRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 474);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.btnVerRecoleccion);
            this.Controls.Add(this.controladorColumnas1);
            this.Controls.Add(this.grdDatos);
            this.Name = "frmEntradaRepuestos";
            this.Text = "frmEntradaRepuestos";
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas controladorColumnas1;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdDatos;
        private DevComponents.DotNetBar.ButtonX btnNueva;
        private DevComponents.DotNetBar.ButtonX btnVerRecoleccion;
    }
}