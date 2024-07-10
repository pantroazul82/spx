namespace SupportTech.frm.importaciones
{
    partial class frmReservar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservar));
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnQuitarReserva = new System.Windows.Forms.Button();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.modelosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grdSinReserva = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.grdReservados = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSinReserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdReservados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReservar
            // 
            this.btnReservar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReservar.Location = new System.Drawing.Point(698, 219);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(75, 23);
            this.btnReservar.TabIndex = 8;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // btnQuitarReserva
            // 
            this.btnQuitarReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitarReserva.Location = new System.Drawing.Point(671, 3);
            this.btnQuitarReserva.Name = "btnQuitarReserva";
            this.btnQuitarReserva.Size = new System.Drawing.Size(99, 23);
            this.btnQuitarReserva.TabIndex = 10;
            this.btnQuitarReserva.Text = "Quitar Reservar";
            this.btnQuitarReserva.UseVisualStyleBackColor = true;
            this.btnQuitarReserva.Click += new System.EventHandler(this.btnQuitarReserva_Click);
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modelosTableAdapter1
            // 
            this.modelosTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Reservados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sin Reserva";
            // 
            // grdSinReserva
            // 
            this.grdSinReserva.AllowUpdate = false;
            this.grdSinReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdSinReserva.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdSinReserva.FilterBar = true;
            this.grdSinReserva.GroupByCaption = "";
            this.grdSinReserva.Images.Add(((System.Drawing.Image)(resources.GetObject("grdSinReserva.Images"))));
            this.grdSinReserva.Location = new System.Drawing.Point(15, 248);
            this.grdSinReserva.Name = "grdSinReserva";
            this.grdSinReserva.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdSinReserva.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdSinReserva.PreviewInfo.ZoomFactor = 75D;
            this.grdSinReserva.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdSinReserva.PrintInfo.PageSettings")));
            this.grdSinReserva.Size = new System.Drawing.Size(755, 217);
            this.grdSinReserva.TabIndex = 13;
            this.grdSinReserva.Text = "c1TrueDBGrid1";
            this.grdSinReserva.PropBag = resources.GetString("grdSinReserva.PropBag");
            // 
            // grdReservados
            // 
            this.grdReservados.AllowUpdate = false;
            this.grdReservados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdReservados.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdReservados.FilterBar = true;
            this.grdReservados.GroupByCaption = "";
            this.grdReservados.Images.Add(((System.Drawing.Image)(resources.GetObject("grdReservados.Images"))));
            this.grdReservados.Location = new System.Drawing.Point(12, 27);
            this.grdReservados.Name = "grdReservados";
            this.grdReservados.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdReservados.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdReservados.PreviewInfo.ZoomFactor = 75D;
            this.grdReservados.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdReservados.PrintInfo.PageSettings")));
            this.grdReservados.Size = new System.Drawing.Size(755, 186);
            this.grdReservados.TabIndex = 14;
            this.grdReservados.Text = "c1TrueDBGrid1";
            this.grdReservados.PropBag = resources.GetString("grdReservados.PropBag");
            // 
            // frmReservar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(785, 477);
            this.Controls.Add(this.grdReservados);
            this.Controls.Add(this.grdSinReserva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuitarReserva);
            this.Controls.Add(this.btnReservar);
            this.Name = "frmReservar";
            this.Text = "Reservar";
            this.Load += new System.EventHandler(this.frmReservar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSinReserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdReservados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnQuitarReserva;
        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter modelosTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdSinReserva;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdReservados;
    }
}