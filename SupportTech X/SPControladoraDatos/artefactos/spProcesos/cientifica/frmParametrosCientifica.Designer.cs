namespace spProcesos.cientifica
{
    partial class frmParametrosCientifica
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtVersionLlamada = new System.Windows.Forms.TextBox();
            this.txtTipoDocumentoLlamada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoLlamada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImplementacionLlamada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.parametro_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.parametro_cientificaTableAdapter();
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
            this.panel1.Location = new System.Drawing.Point(0, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 51);
            this.panel1.TabIndex = 4;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(181, 16);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(262, 16);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Version Llamada";
            // 
            // txtVersionLlamada
            // 
            this.txtVersionLlamada.Location = new System.Drawing.Point(141, 23);
            this.txtVersionLlamada.Name = "txtVersionLlamada";
            this.txtVersionLlamada.Size = new System.Drawing.Size(180, 20);
            this.txtVersionLlamada.TabIndex = 0;
            // 
            // txtTipoDocumentoLlamada
            // 
            this.txtTipoDocumentoLlamada.Location = new System.Drawing.Point(141, 59);
            this.txtTipoDocumentoLlamada.Name = "txtTipoDocumentoLlamada";
            this.txtTipoDocumentoLlamada.Size = new System.Drawing.Size(180, 20);
            this.txtTipoDocumentoLlamada.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Codigo Llamada";
            // 
            // txtCodigoLlamada
            // 
            this.txtCodigoLlamada.Location = new System.Drawing.Point(141, 95);
            this.txtCodigoLlamada.Name = "txtCodigoLlamada";
            this.txtCodigoLlamada.Size = new System.Drawing.Size(180, 20);
            this.txtCodigoLlamada.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(19, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Implementacion Llamada";
            // 
            // txtImplementacionLlamada
            // 
            this.txtImplementacionLlamada.Location = new System.Drawing.Point(141, 131);
            this.txtImplementacionLlamada.Name = "txtImplementacionLlamada";
            this.txtImplementacionLlamada.Size = new System.Drawing.Size(180, 20);
            this.txtImplementacionLlamada.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(19, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo Documento Llamada";
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parametro_cientificaTableAdapter1
            // 
            this.parametro_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // frmParametrosCientifica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 261);
            this.Controls.Add(this.txtImplementacionLlamada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCodigoLlamada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTipoDocumentoLlamada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVersionLlamada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frmParametrosCientifica";
            this.Text = "Parametros Cientifica";
            this.Load += new System.EventHandler(this.frmParametrosCientifica_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVersionLlamada;
        private System.Windows.Forms.TextBox txtTipoDocumentoLlamada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoLlamada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImplementacionLlamada;
        private System.Windows.Forms.Label label4;
        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.parametro_cientificaTableAdapter parametro_cientificaTableAdapter1;
    }
}