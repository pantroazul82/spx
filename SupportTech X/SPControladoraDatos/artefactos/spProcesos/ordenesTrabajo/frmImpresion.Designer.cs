namespace spProcesos.ordenesTrabajo
{
    partial class frmImpresion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImpresion));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.rdimpOS = new System.Windows.Forms.RadioButton();
            this.rdCompleta = new System.Windows.Forms.RadioButton();
            this.rdReporteServicio = new System.Windows.Forms.RadioButton();
            this.estadosOrdenServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.estadosOrdenServicioTableAdapter();
            this.ordenServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(52, 209);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(133, 209);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // rdimpOS
            // 
            this.rdimpOS.AutoSize = true;
            this.rdimpOS.Checked = true;
            this.rdimpOS.Location = new System.Drawing.Point(31, 27);
            this.rdimpOS.Name = "rdimpOS";
            this.rdimpOS.Size = new System.Drawing.Size(148, 17);
            this.rdimpOS.TabIndex = 2;
            this.rdimpOS.TabStop = true;
            this.rdimpOS.Text = "Imprimir Orden de Servicio";
            this.rdimpOS.UseVisualStyleBackColor = true;
            // 
            // rdCompleta
            // 
            this.rdCompleta.AutoSize = true;
            this.rdCompleta.Location = new System.Drawing.Point(31, 100);
            this.rdCompleta.Name = "rdCompleta";
            this.rdCompleta.Size = new System.Drawing.Size(117, 17);
            this.rdCompleta.TabIndex = 5;
            this.rdCompleta.Text = "Impresion Completa";
            this.rdCompleta.UseVisualStyleBackColor = true;
            // 
            // rdReporteServicio
            // 
            this.rdReporteServicio.AutoSize = true;
            this.rdReporteServicio.Location = new System.Drawing.Point(31, 63);
            this.rdReporteServicio.Name = "rdReporteServicio";
            this.rdReporteServicio.Size = new System.Drawing.Size(157, 17);
            this.rdReporteServicio.TabIndex = 4;
            this.rdReporteServicio.Text = "Imprimir Reporte de Servicio";
            this.rdReporteServicio.UseVisualStyleBackColor = true;
            // 
            // estadosOrdenServicioTableAdapter1
            // 
            this.estadosOrdenServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // ordenServicioTableAdapter1
            // 
            this.ordenServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // frmImpresion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(261, 244);
            this.Controls.Add(this.rdCompleta);
            this.Controls.Add(this.rdReporteServicio);
            this.Controls.Add(this.rdimpOS);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmImpresion";
            this.Text = "Opciones de Impresion";
            this.Load += new System.EventHandler(this.frmImpresion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton rdimpOS;
        private System.Windows.Forms.RadioButton rdCompleta;
        private System.Windows.Forms.RadioButton rdReporteServicio;
        private SPControladoraDatos.dsSpxTableAdapters.estadosOrdenServicioTableAdapter estadosOrdenServicioTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter ordenServicioTableAdapter1;
    }
}