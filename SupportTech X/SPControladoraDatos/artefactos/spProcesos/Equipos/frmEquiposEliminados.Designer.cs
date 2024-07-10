namespace spProcesos.Equipos
{
    partial class frmEquiposEliminados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEquiposEliminados));
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.grdEquipos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.controladorColumnas1 = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas();
            this.btnInfEquipo = new DevComponents.DotNetBar.ButtonX();
            this.btnDesEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.grdEquipos.Location = new System.Drawing.Point(12, 91);
            this.grdEquipos.Name = "grdEquipos";
            this.grdEquipos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdEquipos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdEquipos.PreviewInfo.ZoomFactor = 75D;
            this.grdEquipos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdEquipos.PrintInfo.PageSettings")));
            this.grdEquipos.RowHeight = 15;
            this.grdEquipos.Size = new System.Drawing.Size(559, 311);
            this.grdEquipos.TabIndex = 8;
            this.grdEquipos.Text = "c1TrueDBGrid1";
            this.grdEquipos.PropBag = resources.GetString("grdEquipos.PropBag");
            // 
            // controladorColumnas1
            // 
            this.controladorColumnas1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controladorColumnas1.BackColor = System.Drawing.Color.Transparent;
            this.controladorColumnas1.grilla = null;
            this.controladorColumnas1.Location = new System.Drawing.Point(356, 56);
            this.controladorColumnas1.MostrarContraer = true;
            this.controladorColumnas1.MostrarExcel = true;
            this.controladorColumnas1.MostrarExpandir = true;
            this.controladorColumnas1.MostrarLimpiar = true;
            this.controladorColumnas1.Name = "controladorColumnas1";
            this.controladorColumnas1.nombreLibro = null;
            this.controladorColumnas1.Size = new System.Drawing.Size(216, 29);
            this.controladorColumnas1.TabIndex = 10;
            // 
            // btnInfEquipo
            // 
            this.btnInfEquipo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInfEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfEquipo.Image")));
            this.btnInfEquipo.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnInfEquipo.Location = new System.Drawing.Point(320, 52);
            this.btnInfEquipo.Name = "btnInfEquipo";
            this.btnInfEquipo.Size = new System.Drawing.Size(33, 33);
            this.btnInfEquipo.TabIndex = 9;
            this.btnInfEquipo.Click += new System.EventHandler(this.btnInfEquipo_Click);
            // 
            // btnDesEliminar
            // 
            this.btnDesEliminar.Location = new System.Drawing.Point(13, 61);
            this.btnDesEliminar.Name = "btnDesEliminar";
            this.btnDesEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnDesEliminar.TabIndex = 11;
            this.btnDesEliminar.Text = "Des Eliminar";
            this.btnDesEliminar.UseVisualStyleBackColor = true;
            this.btnDesEliminar.Click += new System.EventHandler(this.btnDesEliminar_Click);
            // 
            // frmEquiposEliminados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(583, 414);
            this.Controls.Add(this.btnDesEliminar);
            this.Controls.Add(this.controladorColumnas1);
            this.Controls.Add(this.btnInfEquipo);
            this.Controls.Add(this.grdEquipos);
            this.Name = "frmEquiposEliminados";
            this.Text = "Equipos Eliminados";
            this.Load += new System.EventHandler(this.frmEquiposEliminados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEquipos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SPControladoraDatos.dsSpx dsSpx1;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdEquipos;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.controladorColumnas controladorColumnas1;
        private DevComponents.DotNetBar.ButtonX btnInfEquipo;
        private System.Windows.Forms.Button btnDesEliminar;
    }
}