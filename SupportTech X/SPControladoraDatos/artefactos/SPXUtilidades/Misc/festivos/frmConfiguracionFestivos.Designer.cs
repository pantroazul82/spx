

namespace SPControladoraDatos.artefactos.SPXUtilidades.Misc.festivos
{
    partial class frmConfiguracionFestivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracionFestivos));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAno = new System.Windows.Forms.ComboBox();
            this.btnCrearDomingos = new DevComponents.DotNetBar.ButtonX();
            this.btnEliminar = new DevComponents.DotNetBar.ButtonX();
            this.btnNuevo = new DevComponents.DotNetBar.ButtonX();
            this.grdDatos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsFestivos1 = new dsFestivos ();
            this.btnTest = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFestivos1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "Año";
            // 
            // cmbAno
            // 
            this.cmbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAno.FormattingEnabled = true;
            this.cmbAno.Location = new System.Drawing.Point(42, 19);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(101, 21);
            this.cmbAno.TabIndex = 82;
            this.cmbAno.SelectedIndexChanged += new System.EventHandler(this.cmbAno_SelectedIndexChanged);
            // 
            // btnCrearDomingos
            // 
            this.btnCrearDomingos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCrearDomingos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearDomingos.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCrearDomingos.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnCrearDomingos.Location = new System.Drawing.Point(465, 12);
            this.btnCrearDomingos.Name = "btnCrearDomingos";
            this.btnCrearDomingos.Size = new System.Drawing.Size(125, 28);
            this.btnCrearDomingos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCrearDomingos.TabIndex = 85;
            this.btnCrearDomingos.Text = "Crear automaticamente Domingos";
            this.btnCrearDomingos.Click += new System.EventHandler(this.btnCrearDomingos_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEliminar.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnEliminar.Location = new System.Drawing.Point(505, 46);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(85, 28);
            this.btnEliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEliminar.TabIndex = 84;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNuevo.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnNuevo.Location = new System.Drawing.Point(414, 46);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(85, 28);
            this.btnNuevo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNuevo.TabIndex = 80;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUpdate = false;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.DataMember = "dias_festivos";
            this.grdDatos.DataSource = this.dsFestivos1;
            this.grdDatos.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdDatos.FilterBar = true;
            this.grdDatos.GroupByCaption = "";
            this.grdDatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDatos.Images"))));
            this.grdDatos.Location = new System.Drawing.Point(12, 85);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75D;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(580, 323);
            this.grdDatos.TabIndex = 79;
            this.grdDatos.Text = "c1TrueDBGrid1";
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
            // 
            // dsFestivos1
            // 
            this.dsFestivos1.DataSetName = "dsFestivos";
            this.dsFestivos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnTest
            // 
            this.btnTest.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTest.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnTest.Location = new System.Drawing.Point(414, 12);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(45, 28);
            this.btnTest.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTest.TabIndex = 86;
            this.btnTest.Text = "Test";
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // frmConfiguracionFestivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 420);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnCrearDomingos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAno);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.grdDatos);
            this.Name = "frmConfiguracionFestivos";
            this.Text = "Configuracion Festivos";
            this.Load += new System.EventHandler(this.frmConfiguracionFestivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFestivos1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnCrearDomingos;
        private DevComponents.DotNetBar.ButtonX btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAno;
        private DevComponents.DotNetBar.ButtonX btnNuevo;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdDatos;
        private dsFestivos dsFestivos1;
        private DevComponents.DotNetBar.ButtonX btnTest;
 
    }
}