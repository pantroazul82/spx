namespace SupportTech.frm.importaciones
{
    partial class frmSerializar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSerializar));
            this.grdReservados = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.grdSinReserva = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuitarReserva = new System.Windows.Forms.Button();
            this.controladorColumnasSerializados = new SPXUtilidades.Controles.controladorColumnas();
            this.controladorColumnasSinSerializar = new SPXUtilidades.Controles.controladorColumnas();
            this.btnTerminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdReservados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSinReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // grdReservados
            // 
            this.grdReservados.AllowUpdate = false;
            this.grdReservados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdReservados.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdReservados.FilterBar = true;
            this.grdReservados.GroupByCaption = "";
            this.grdReservados.Images.Add(((System.Drawing.Image)(resources.GetObject("grdReservados.Images"))));
            this.grdReservados.Location = new System.Drawing.Point(12, 261);
            this.grdReservados.Name = "grdReservados";
            this.grdReservados.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdReservados.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdReservados.PreviewInfo.ZoomFactor = 75D;
            this.grdReservados.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdReservados.PrintInfo.PageSettings")));
            this.grdReservados.Size = new System.Drawing.Size(815, 262);
            this.grdReservados.TabIndex = 20;
            this.grdReservados.Text = "c1TrueDBGrid1";
            this.grdReservados.PropBag = resources.GetString("grdReservados.PropBag");
            // 
            // grdSinReserva
            // 
            this.grdSinReserva.AllowUpdate = false;
            this.grdSinReserva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdSinReserva.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdSinReserva.FilterBar = true;
            this.grdSinReserva.GroupByCaption = "";
            this.grdSinReserva.Images.Add(((System.Drawing.Image)(resources.GetObject("grdSinReserva.Images"))));
            this.grdSinReserva.Location = new System.Drawing.Point(12, 36);
            this.grdSinReserva.Name = "grdSinReserva";
            this.grdSinReserva.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdSinReserva.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdSinReserva.PreviewInfo.ZoomFactor = 75D;
            this.grdSinReserva.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdSinReserva.PrintInfo.PageSettings")));
            this.grdSinReserva.Size = new System.Drawing.Size(818, 183);
            this.grdSinReserva.TabIndex = 19;
            this.grdSinReserva.Text = "c1TrueDBGrid1";
            this.grdSinReserva.PropBag = resources.GetString("grdSinReserva.PropBag");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Serializados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Sin Serializar";
            // 
            // btnQuitarReserva
            // 
            this.btnQuitarReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitarReserva.Location = new System.Drawing.Point(517, 4);
            this.btnQuitarReserva.Name = "btnQuitarReserva";
            this.btnQuitarReserva.Size = new System.Drawing.Size(99, 23);
            this.btnQuitarReserva.TabIndex = 16;
            this.btnQuitarReserva.Text = "Serializar";
            this.btnQuitarReserva.UseVisualStyleBackColor = true;
            this.btnQuitarReserva.Click += new System.EventHandler(this.btnQuitarReserva_Click);
            // 
            // controladorColumnasSerializados
            // 
            this.controladorColumnasSerializados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controladorColumnasSerializados.BackColor = System.Drawing.Color.Transparent;
            this.controladorColumnasSerializados.grilla = null;
            this.controladorColumnasSerializados.Location = new System.Drawing.Point(622, 226);
            this.controladorColumnasSerializados.MostrarContraer = true;
            this.controladorColumnasSerializados.MostrarExcel = true;
            this.controladorColumnasSerializados.MostrarExpandir = true;
            this.controladorColumnasSerializados.MostrarLimpiar = true;
            this.controladorColumnasSerializados.Name = "controladorColumnasSerializados";
            this.controladorColumnasSerializados.nombreLibro = null;
            this.controladorColumnasSerializados.Size = new System.Drawing.Size(216, 29);
            this.controladorColumnasSerializados.TabIndex = 86;
            // 
            // controladorColumnasSinSerializar
            // 
            this.controladorColumnasSinSerializar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controladorColumnasSinSerializar.BackColor = System.Drawing.Color.Transparent;
            this.controladorColumnasSinSerializar.grilla = null;
            this.controladorColumnasSinSerializar.Location = new System.Drawing.Point(622, 4);
            this.controladorColumnasSinSerializar.MostrarContraer = true;
            this.controladorColumnasSinSerializar.MostrarExcel = true;
            this.controladorColumnasSinSerializar.MostrarExpandir = true;
            this.controladorColumnasSinSerializar.MostrarLimpiar = true;
            this.controladorColumnasSinSerializar.Name = "controladorColumnasSinSerializar";
            this.controladorColumnasSinSerializar.nombreLibro = null;
            this.controladorColumnasSinSerializar.Size = new System.Drawing.Size(216, 29);
            this.controladorColumnasSinSerializar.TabIndex = 87;
            // 
            // btnTerminar
            // 
            this.btnTerminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTerminar.Location = new System.Drawing.Point(412, 4);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(99, 23);
            this.btnTerminar.TabIndex = 88;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // frmSerializar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(842, 534);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.controladorColumnasSinSerializar);
            this.Controls.Add(this.controladorColumnasSerializados);
            this.Controls.Add(this.grdReservados);
            this.Controls.Add(this.grdSinReserva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuitarReserva);
            this.Name = "frmSerializar";
            this.Text = "Serializar";
            this.Load += new System.EventHandler(this.frmSerializar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdReservados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSinReserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdReservados;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdSinReserva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuitarReserva;
        private SPXUtilidades.Controles.controladorColumnas controladorColumnasSerializados;
        private SPXUtilidades.Controles.controladorColumnas controladorColumnasSinSerializar;
        private System.Windows.Forms.Button btnTerminar;

    }
}