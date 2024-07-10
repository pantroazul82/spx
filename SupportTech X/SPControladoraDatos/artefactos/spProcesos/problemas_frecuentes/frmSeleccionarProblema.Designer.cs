namespace spProcesos.problemas_frecuentes
{
    partial class frmSeleccionarProblema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeleccionarProblema));
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.problemas_frecuentesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.problemas_frecuentesTableAdapter();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grdProblema = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.lblModeloFabricante = new System.Windows.Forms.Label();
            this.btnAgregarProblema = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProblema)).BeginInit();
            this.SuspendLayout();
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // problemas_frecuentesTableAdapter1
            // 
            this.problemas_frecuentesTableAdapter1.ClearBeforeFill = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(403, 13);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(322, 13);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 48);
            this.panel1.TabIndex = 2;
            // 
            // grdProblema
            // 
            this.grdProblema.AllowUpdate = false;
            this.grdProblema.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdProblema.CaptionHeight = 17;
            this.grdProblema.DataMember = "problemas_frecuentes";
            this.grdProblema.DataSource = this.dsSpx1;
            this.grdProblema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdProblema.Images.Add(((System.Drawing.Image)(resources.GetObject("grdProblema.Images"))));
            this.grdProblema.Location = new System.Drawing.Point(12, 58);
            this.grdProblema.Name = "grdProblema";
            this.grdProblema.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdProblema.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdProblema.PreviewInfo.ZoomFactor = 75D;
            this.grdProblema.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdIndicaciones.PrintInfo.PageSettings")));
            this.grdProblema.RowHeight = 15;
            this.grdProblema.Size = new System.Drawing.Size(463, 294);
            this.grdProblema.TabIndex = 3;
            this.grdProblema.Text = "c1TrueDBGrid2";
            this.grdProblema.PropBag = resources.GetString("grdProblema.PropBag");
            // 
            // lblModeloFabricante
            // 
            this.lblModeloFabricante.AutoSize = true;
            this.lblModeloFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeloFabricante.Location = new System.Drawing.Point(13, 13);
            this.lblModeloFabricante.Name = "lblModeloFabricante";
            this.lblModeloFabricante.Size = new System.Drawing.Size(0, 20);
            this.lblModeloFabricante.TabIndex = 4;
            // 
            // btnAgregarProblema
            // 
            this.btnAgregarProblema.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregarProblema.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProblema.Image")));
            this.btnAgregarProblema.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnAgregarProblema.Location = new System.Drawing.Point(446, 23);
            this.btnAgregarProblema.Name = "btnAgregarProblema";
            this.btnAgregarProblema.Size = new System.Drawing.Size(29, 29);
            this.btnAgregarProblema.TabIndex = 111;
            this.btnAgregarProblema.Click += new System.EventHandler(this.btnAgregarProblema_Click);
            // 
            // frmSeleccionarProblema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(487, 406);
            this.Controls.Add(this.btnAgregarProblema);
            this.Controls.Add(this.lblModeloFabricante);
            this.Controls.Add(this.grdProblema);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSeleccionarProblema";
            this.Text = "Seleccionar Problema";
            this.Load += new System.EventHandler(this.frmSeleccionarProblema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProblema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.problemas_frecuentesTableAdapter problemas_frecuentesTableAdapter1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdProblema;
        private System.Windows.Forms.Label lblModeloFabricante;
        private DevComponents.DotNetBar.ButtonX btnAgregarProblema;
    }
}