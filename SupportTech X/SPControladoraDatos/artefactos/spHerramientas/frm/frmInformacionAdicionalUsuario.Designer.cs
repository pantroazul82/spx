namespace spHerramientas.frm
{
    partial class frmInformacionAdicionalUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformacionAdicionalUsuario));
            this.grdDatos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picFirma = new System.Windows.Forms.PictureBox();
            this.btnEditarInformacionAdicional = new System.Windows.Forms.Button();
            this.btnAceptarEdicion = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtProfesion = new System.Windows.Forms.TextBox();
            this.btnCambiarImagen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFirma)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUpdate = false;
            this.grdDatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDatos.Images"))));
            this.grdDatos.Location = new System.Drawing.Point(12, 48);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75D;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(352, 399);
            this.grdDatos.TabIndex = 0;
            this.grdDatos.Text = "c1TrueDBGrid1";
            this.grdDatos.RowColChange += new C1.Win.C1TrueDBGrid.RowColChangeEventHandler(this.grdDatos_RowColChange);
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCambiarImagen);
            this.groupBox1.Controls.Add(this.txtProfesion);
            this.groupBox1.Controls.Add(this.txtCargo);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnAceptarEdicion);
            this.groupBox1.Controls.Add(this.btnEditarInformacionAdicional);
            this.groupBox1.Controls.Add(this.picFirma);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(386, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 374);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Adicional";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cargo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Profesion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Firma:";
            // 
            // picFirma
            // 
            this.picFirma.Location = new System.Drawing.Point(26, 114);
            this.picFirma.Name = "picFirma";
            this.picFirma.Size = new System.Drawing.Size(376, 190);
            this.picFirma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFirma.TabIndex = 3;
            this.picFirma.TabStop = false;
            // 
            // btnEditarInformacionAdicional
            // 
            this.btnEditarInformacionAdicional.Location = new System.Drawing.Point(29, 310);
            this.btnEditarInformacionAdicional.Name = "btnEditarInformacionAdicional";
            this.btnEditarInformacionAdicional.Size = new System.Drawing.Size(75, 23);
            this.btnEditarInformacionAdicional.TabIndex = 4;
            this.btnEditarInformacionAdicional.Text = "Editar Informacion";
            this.btnEditarInformacionAdicional.UseVisualStyleBackColor = true;
            this.btnEditarInformacionAdicional.Click += new System.EventHandler(this.btnEditarInformacionAdicional_Click);
            // 
            // btnAceptarEdicion
            // 
            this.btnAceptarEdicion.Location = new System.Drawing.Point(245, 310);
            this.btnAceptarEdicion.Name = "btnAceptarEdicion";
            this.btnAceptarEdicion.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarEdicion.TabIndex = 5;
            this.btnAceptarEdicion.Text = "Aceptar";
            this.btnAceptarEdicion.UseVisualStyleBackColor = true;
            this.btnAceptarEdicion.Visible = false;
            this.btnAceptarEdicion.Click += new System.EventHandler(this.btnAceptarEdicion_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(326, 310);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(91, 20);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.ReadOnly = true;
            this.txtCargo.Size = new System.Drawing.Size(269, 20);
            this.txtCargo.TabIndex = 7;
            // 
            // txtProfesion
            // 
            this.txtProfesion.Location = new System.Drawing.Point(91, 53);
            this.txtProfesion.Name = "txtProfesion";
            this.txtProfesion.ReadOnly = true;
            this.txtProfesion.Size = new System.Drawing.Size(269, 20);
            this.txtProfesion.TabIndex = 8;
            // 
            // btnCambiarImagen
            // 
            this.btnCambiarImagen.Location = new System.Drawing.Point(327, 84);
            this.btnCambiarImagen.Name = "btnCambiarImagen";
            this.btnCambiarImagen.Size = new System.Drawing.Size(75, 23);
            this.btnCambiarImagen.TabIndex = 9;
            this.btnCambiarImagen.Text = "Cambiar Imagen";
            this.btnCambiarImagen.UseVisualStyleBackColor = true;
            this.btnCambiarImagen.Visible = false;
            this.btnCambiarImagen.Click += new System.EventHandler(this.btnCambiarImagen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Listado de Usuarios";
            // 
            // frmInformacionAdicionalUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(833, 471);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdDatos);
            this.Name = "frmInformacionAdicionalUsuario";
            this.Text = "Informacion Adicional Usuario";
            this.Load += new System.EventHandler(this.frmInformacionAdicionalUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFirma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdDatos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCambiarImagen;
        private System.Windows.Forms.TextBox txtProfesion;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptarEdicion;
        private System.Windows.Forms.Button btnEditarInformacionAdicional;
        private System.Windows.Forms.PictureBox picFirma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}