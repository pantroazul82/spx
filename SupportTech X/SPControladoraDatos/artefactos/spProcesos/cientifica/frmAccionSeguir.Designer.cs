namespace spProcesos.cientifica
{
    partial class frmAccionSeguir
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.accion_seguir_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.accion_seguir_cientificaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccionSeguir = new System.Windows.Forms.TextBox();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.chkIndQc = new System.Windows.Forms.CheckBox();
            this.chkIndVisita = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 51);
            this.panel1.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(260, 16);
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
            this.btnCancelar.Location = new System.Drawing.Point(341, 16);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // accion_seguir_cientificaTableAdapter1
            // 
            this.accion_seguir_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Accion a Seguir";
            // 
            // txtAccionSeguir
            // 
            this.txtAccionSeguir.Location = new System.Drawing.Point(114, 37);
            this.txtAccionSeguir.Name = "txtAccionSeguir";
            this.txtAccionSeguir.Size = new System.Drawing.Size(265, 20);
            this.txtAccionSeguir.TabIndex = 3;
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chkIndQc
            // 
            this.chkIndQc.AutoSize = true;
            this.chkIndQc.Location = new System.Drawing.Point(195, 101);
            this.chkIndQc.Name = "chkIndQc";
            this.chkIndQc.Size = new System.Drawing.Size(75, 17);
            this.chkIndQc.TabIndex = 4;
            this.chkIndQc.Text = "Inidica QC";
            this.chkIndQc.UseVisualStyleBackColor = true;
            // 
            // chkIndVisita
            // 
            this.chkIndVisita.AutoSize = true;
            this.chkIndVisita.Location = new System.Drawing.Point(195, 144);
            this.chkIndVisita.Name = "chkIndVisita";
            this.chkIndVisita.Size = new System.Drawing.Size(85, 17);
            this.chkIndVisita.TabIndex = 5;
            this.chkIndVisita.Text = "Inidica Visita";
            this.chkIndVisita.UseVisualStyleBackColor = true;
            // 
            // frmAccionSeguir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 259);
            this.Controls.Add(this.chkIndVisita);
            this.Controls.Add(this.chkIndQc);
            this.Controls.Add(this.txtAccionSeguir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frmAccionSeguir";
            this.Text = "Accion Seguir";
            this.Load += new System.EventHandler(this.frmAccionSeguir_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private SPControladoraDatos.dsSpxTableAdapters.accion_seguir_cientificaTableAdapter accion_seguir_cientificaTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccionSeguir;
        private SPControladoraDatos.dsSpx dsSpx1;
        private System.Windows.Forms.CheckBox chkIndQc;
        private System.Windows.Forms.CheckBox chkIndVisita;
    }
}