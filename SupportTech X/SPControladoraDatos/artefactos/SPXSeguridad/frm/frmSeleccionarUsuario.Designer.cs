namespace SPXSeguridad.frm
{
    partial class frmSeleccionarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeleccionarUsuario));
            this.dsSPXSeguridad1 = new SPXSeguridad.data.dsSPXSeguridad();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grdUsuario = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.usuarioTableAdapter1 = new SPXSeguridad.data.cls.clsTusuario();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dsSPXSeguridad1
            // 
            this.dsSPXSeguridad1.DataSetName = "dsSPXSeguridad";
            this.dsSPXSeguridad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 50);
            this.panel1.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(252, 15);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(329, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // grdUsuario
            // 
            this.grdUsuario.AllowUpdate = false;
            this.grdUsuario.DataMember = "usuario";
            this.grdUsuario.DataSource = this.dsSPXSeguridad1;
            this.grdUsuario.FilterBar = true;
            this.grdUsuario.GroupByCaption = "Drag a column header here to group by that column";
            this.grdUsuario.Images.Add(((System.Drawing.Image)(resources.GetObject("grdUsuario.Images"))));
            this.grdUsuario.Location = new System.Drawing.Point(12, 26);
            this.grdUsuario.Name = "grdUsuario";
            this.grdUsuario.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdUsuario.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdUsuario.PreviewInfo.ZoomFactor = 75D;
            this.grdUsuario.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdUsuario.PrintInfo.PageSettings")));
            this.grdUsuario.Size = new System.Drawing.Size(394, 248);
            this.grdUsuario.TabIndex = 2;
            this.grdUsuario.Text = "c1TrueDBGrid1";
            this.grdUsuario.PropBag = resources.GetString("grdUsuario.PropBag");
            // 
            // frmSeleccionarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 345);
            this.ControlBox = false;
            this.Controls.Add(this.grdUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSeleccionarUsuario";
            this.Text = "Seleccionar  Usuario";
            this.Load += new System.EventHandler(this.frmSeleccionarGrupoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdUsuario;
        private SPXSeguridad.data.cls.clsTusuario usuarioTableAdapter1;
    }
}