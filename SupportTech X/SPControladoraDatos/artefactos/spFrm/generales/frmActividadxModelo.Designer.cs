namespace SpFrm.generales
{
    partial class frmActividadxModelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActividadxModelo));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnAgregarAuxiliar = new DevComponents.DotNetBar.ButtonX();
            this.grdActividades = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.actividadesxModeloTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ActividadesxModeloTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grdActividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(447, 344);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(366, 344);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(12, 12);
            this.txtFiltro.Multiline = true;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(475, 44);
            this.txtFiltro.TabIndex = 5;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnAgregarAuxiliar
            // 
            this.btnAgregarAuxiliar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregarAuxiliar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarAuxiliar.Image")));
            this.btnAgregarAuxiliar.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnAgregarAuxiliar.Location = new System.Drawing.Point(493, 27);
            this.btnAgregarAuxiliar.Name = "btnAgregarAuxiliar";
            this.btnAgregarAuxiliar.Size = new System.Drawing.Size(29, 29);
            this.btnAgregarAuxiliar.TabIndex = 73;
            this.btnAgregarAuxiliar.Click += new System.EventHandler(this.btnAgregarAuxiliar_Click);
            // 
            // grdActividades
            // 
            this.grdActividades.AllowUpdate = false;
            this.grdActividades.DataMember = "ActividadesxModelo";
            this.grdActividades.DataSource = this.dsSpx1;
            this.grdActividades.FilterBar = true;
            this.grdActividades.GroupByCaption = "Drag a column header here to group by that column";
            this.grdActividades.Images.Add(((System.Drawing.Image)(resources.GetObject("grdActividades.Images"))));
            this.grdActividades.Location = new System.Drawing.Point(13, 62);
            this.grdActividades.Name = "grdActividades";
            this.grdActividades.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdActividades.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdActividades.PreviewInfo.ZoomFactor = 75;
            this.grdActividades.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdActividades.PrintInfo.PageSettings")));
            this.grdActividades.RowHeight = 43;
            this.grdActividades.Size = new System.Drawing.Size(509, 265);
            this.grdActividades.TabIndex = 4;
            this.grdActividades.Text = "c1TrueDBGrid1";
            this.grdActividades.PropBag = resources.GetString("grdActividades.PropBag");
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // actividadesxModeloTableAdapter1
            // 
            this.actividadesxModeloTableAdapter1.ClearBeforeFill = true;
            // 
            // frmActividadxModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(534, 379);
            this.Controls.Add(this.btnAgregarAuxiliar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.grdActividades);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmActividadxModelo";
            this.Text = "Actividad Por Modelo";
            this.Load += new System.EventHandler(this.frmActividadxModelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdActividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.ActividadesxModeloTableAdapter actividadesxModeloTableAdapter1;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdActividades;
        private System.Windows.Forms.TextBox txtFiltro;
        private DevComponents.DotNetBar.ButtonX btnAgregarAuxiliar;
    }
}