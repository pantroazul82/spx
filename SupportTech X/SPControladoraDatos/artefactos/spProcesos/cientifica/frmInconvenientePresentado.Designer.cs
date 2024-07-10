namespace spProcesos.cientifica
{
    partial class frmInconvenientePresentado
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
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.inconveniente_presentado_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.inconveniente_presentado_cientificaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInconveniente = new System.Windows.Forms.TextBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.chkEquipo = new System.Windows.Forms.CheckBox();
            this.chkIndicaReactivo = new System.Windows.Forms.CheckBox();
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
            this.panel1.Location = new System.Drawing.Point(0, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 51);
            this.panel1.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(193, 16);
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
            this.btnCancelar.Location = new System.Drawing.Point(274, 16);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inconveniente_presentado_cientificaTableAdapter1
            // 
            this.inconveniente_presentado_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inconveniente Presentado";
            // 
            // txtInconveniente
            // 
            this.txtInconveniente.Location = new System.Drawing.Point(25, 52);
            this.txtInconveniente.Name = "txtInconveniente";
            this.txtInconveniente.Size = new System.Drawing.Size(324, 20);
            this.txtInconveniente.TabIndex = 3;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(25, 79);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(61, 17);
            this.chkActivo.TabIndex = 4;
            this.chkActivo.Text = "Activos";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // chkEquipo
            // 
            this.chkEquipo.AutoSize = true;
            this.chkEquipo.Location = new System.Drawing.Point(25, 102);
            this.chkEquipo.Name = "chkEquipo";
            this.chkEquipo.Size = new System.Drawing.Size(91, 17);
            this.chkEquipo.TabIndex = 5;
            this.chkEquipo.Text = "Indica Equipo";
            this.chkEquipo.UseVisualStyleBackColor = true;
            // 
            // chkIndicaReactivo
            // 
            this.chkIndicaReactivo.AutoSize = true;
            this.chkIndicaReactivo.Location = new System.Drawing.Point(25, 125);
            this.chkIndicaReactivo.Name = "chkIndicaReactivo";
            this.chkIndicaReactivo.Size = new System.Drawing.Size(101, 17);
            this.chkIndicaReactivo.TabIndex = 6;
            this.chkIndicaReactivo.Text = "Indica Reactivo";
            this.chkIndicaReactivo.UseVisualStyleBackColor = true;
            // 
            // frmInconvenientePresentado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 248);
            this.Controls.Add(this.chkIndicaReactivo);
            this.Controls.Add(this.chkEquipo);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.txtInconveniente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frmInconvenientePresentado";
            this.Text = "Inconveniente Presentado";
            this.Load += new System.EventHandler(this.frmInconvenientePresentado_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.inconveniente_presentado_cientificaTableAdapter inconveniente_presentado_cientificaTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInconveniente;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.CheckBox chkEquipo;
        private System.Windows.Forms.CheckBox chkIndicaReactivo;
    }
}