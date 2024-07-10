namespace SPXSeguridad.frm
{
    partial class frmFuncionalidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionalidades));
            C1.Win.C1TrueDBGrid.Style style9 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style10 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style11 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style12 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style13 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style14 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style15 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style16 = new C1.Win.C1TrueDBGrid.Style();
            this.grdModulos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.grdFuncionalidades = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.c1CmbModulos = new C1.Win.C1TrueDBGrid.C1TrueDBDropdown();
            this.dsSPXSeguridad1 = new SPXSeguridad.data.dsSPXSeguridad();
            this.btnACeptar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grdModulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFuncionalidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CmbModulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdModulos
            // 
            this.grdModulos.AllowUpdate = false;
            this.grdModulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdModulos.DataMember = "modulo_seguridad";
            this.grdModulos.DataSource = this.dsSPXSeguridad1;
            this.grdModulos.FilterBar = true;
            this.grdModulos.GroupByCaption = "Drag a column header here to group by that column";
            this.grdModulos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdModulos.Images"))));
            this.grdModulos.Location = new System.Drawing.Point(426, 34);
            this.grdModulos.Name = "grdModulos";
            this.grdModulos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdModulos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdModulos.PreviewInfo.ZoomFactor = 75D;
            this.grdModulos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdModulos.PrintInfo.PageSettings")));
            this.grdModulos.Size = new System.Drawing.Size(240, 333);
            this.grdModulos.TabIndex = 0;
            this.grdModulos.Text = "c1TrueDBGrid1";
            this.grdModulos.PropBag = resources.GetString("grdModulos.PropBag");
            // 
            // grdFuncionalidades
            // 
            this.grdFuncionalidades.AllowUpdate = false;
            this.grdFuncionalidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdFuncionalidades.DataMember = "funcionalidad";
            this.grdFuncionalidades.DataSource = this.dsSPXSeguridad1;
            this.grdFuncionalidades.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdFuncionalidades.FilterBar = true;
            this.grdFuncionalidades.GroupByCaption = "";
            this.grdFuncionalidades.Images.Add(((System.Drawing.Image)(resources.GetObject("grdFuncionalidades.Images"))));
            this.grdFuncionalidades.Location = new System.Drawing.Point(12, 34);
            this.grdFuncionalidades.Name = "grdFuncionalidades";
            this.grdFuncionalidades.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdFuncionalidades.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdFuncionalidades.PreviewInfo.ZoomFactor = 75D;
            this.grdFuncionalidades.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdFuncionalidades.PrintInfo.PageSettings")));
            this.grdFuncionalidades.Size = new System.Drawing.Size(408, 333);
            this.grdFuncionalidades.TabIndex = 1;
            this.grdFuncionalidades.Text = "c1TrueDBGrid2";
            this.grdFuncionalidades.PropBag = resources.GetString("grdFuncionalidades.PropBag");
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modulos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Funcionalidades";
            // 
            // c1CmbModulos
            // 
            this.c1CmbModulos.AllowColMove = true;
            this.c1CmbModulos.AllowColSelect = true;
            this.c1CmbModulos.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows;
            this.c1CmbModulos.AlternatingRows = false;
            this.c1CmbModulos.CaptionStyle = style9;
            this.c1CmbModulos.ColumnCaptionHeight = 17;
            this.c1CmbModulos.ColumnFooterHeight = 17;
            this.c1CmbModulos.DataMember = "modulo_seguridad";
            this.c1CmbModulos.DataSource = this.dsSPXSeguridad1;
            this.c1CmbModulos.DisplayMember = "modulo_seguridad.nombre_modulo_seguridad";
            this.c1CmbModulos.EvenRowStyle = style10;
            this.c1CmbModulos.FetchRowStyles = false;
            this.c1CmbModulos.FooterStyle = style11;
            this.c1CmbModulos.HeadingStyle = style12;
            this.c1CmbModulos.HighLightRowStyle = style13;
            this.c1CmbModulos.Images.Add(((System.Drawing.Image)(resources.GetObject("c1CmbModulos.Images"))));
            this.c1CmbModulos.Location = new System.Drawing.Point(99, 175);
            this.c1CmbModulos.Name = "c1CmbModulos";
            this.c1CmbModulos.OddRowStyle = style14;
            this.c1CmbModulos.RecordSelectorStyle = style15;
            this.c1CmbModulos.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.c1CmbModulos.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
            this.c1CmbModulos.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1CmbModulos.ScrollTips = false;
            this.c1CmbModulos.Size = new System.Drawing.Size(100, 150);
            this.c1CmbModulos.Style = style16;
            this.c1CmbModulos.TabIndex = 4;
            this.c1CmbModulos.TabStop = false;
            this.c1CmbModulos.Text = "c1TrueDBDropdown1";
            this.c1CmbModulos.ValueMember = "modulo_seguridad.cod_modulo_seguridad";
            this.c1CmbModulos.ValueTranslate = true;
            this.c1CmbModulos.Visible = false;
            this.c1CmbModulos.PropBag = resources.GetString("c1CmbModulos.PropBag");
            // 
            // dsSPXSeguridad1
            // 
            this.dsSPXSeguridad1.DataSetName = "dsSPXSeguridad";
            this.dsSPXSeguridad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnACeptar
            // 
            this.btnACeptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnACeptar.Location = new System.Drawing.Point(591, 16);
            this.btnACeptar.Name = "btnACeptar";
            this.btnACeptar.Size = new System.Drawing.Size(75, 23);
            this.btnACeptar.TabIndex = 5;
            this.btnACeptar.Text = "Aceptar";
            this.btnACeptar.UseVisualStyleBackColor = true;
            this.btnACeptar.Click += new System.EventHandler(this.btnACeptar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnACeptar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 389);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 51);
            this.panel1.TabIndex = 6;
            // 
            // frmFuncionalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 440);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.c1CmbModulos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdFuncionalidades);
            this.Controls.Add(this.grdModulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFuncionalidades";
            this.Text = "Funcionalidades";
            this.Load += new System.EventHandler(this.frmFuncionalidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdModulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFuncionalidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CmbModulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdModulos;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdFuncionalidades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private C1.Win.C1TrueDBGrid.C1TrueDBDropdown c1CmbModulos;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad1;
        private System.Windows.Forms.Button btnACeptar;
        private System.Windows.Forms.Panel panel1;
    }
}