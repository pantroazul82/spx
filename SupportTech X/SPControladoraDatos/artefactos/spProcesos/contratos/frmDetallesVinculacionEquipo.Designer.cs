namespace spProcesos.contratos
{
    partial class frmDetallesVinculacionEquipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetallesVinculacionEquipo));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.nmMantenimientosRealizados = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nmMantenimientosIncluidos = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nmMantenimientosRealizados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMantenimientosIncluidos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(125, 8);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(206, 8);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.BackColor = System.Drawing.Color.Transparent;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Location = new System.Drawing.Point(79, 132);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(99, 17);
            this.chkActivo.TabIndex = 118;
            this.chkActivo.Text = "Contrato Activo";
            this.chkActivo.UseVisualStyleBackColor = false;
            this.chkActivo.Visible = false;
            // 
            // nmMantenimientosRealizados
            // 
            this.nmMantenimientosRealizados.Location = new System.Drawing.Point(211, 84);
            this.nmMantenimientosRealizados.Name = "nmMantenimientosRealizados";
            this.nmMantenimientosRealizados.Size = new System.Drawing.Size(61, 20);
            this.nmMantenimientosRealizados.TabIndex = 117;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(17, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 26);
            this.label8.TabIndex = 120;
            this.label8.Text = "Mantenimientos Realizados";
            // 
            // nmMantenimientosIncluidos
            // 
            this.nmMantenimientosIncluidos.Location = new System.Drawing.Point(211, 31);
            this.nmMantenimientosIncluidos.Name = "nmMantenimientosIncluidos";
            this.nmMantenimientosIncluidos.Size = new System.Drawing.Size(61, 20);
            this.nmMantenimientosIncluidos.TabIndex = 116;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(17, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 34);
            this.label3.TabIndex = 119;
            this.label3.Text = "Numero de Mantenimientos Incluidos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 43);
            this.panel1.TabIndex = 121;
            // 
            // frmDetallesVinculacionEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(293, 236);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.nmMantenimientosRealizados);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nmMantenimientosIncluidos);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDetallesVinculacionEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles Vinculacion Equipo";
            this.Load += new System.EventHandler(this.frmDetallesVinculacionEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmMantenimientosRealizados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMantenimientosIncluidos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.NumericUpDown nmMantenimientosRealizados;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nmMantenimientosIncluidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}