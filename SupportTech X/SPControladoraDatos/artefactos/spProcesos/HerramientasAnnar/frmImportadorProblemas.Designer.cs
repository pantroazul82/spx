namespace spProcesos.HerramientasAnnar
{
    partial class frmImportadorProblemas
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
            this.btnBuscarArchivo = new System.Windows.Forms.Button();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLogArchivos = new System.Windows.Forms.TextBox();
            this.btnCargarArchivo = new System.Windows.Forms.Button();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.problemas_frecuentesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.problemas_frecuentesTableAdapter();
            this.soluciones_problemasTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.soluciones_problemasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarArchivo
            // 
            this.btnBuscarArchivo.Location = new System.Drawing.Point(484, 45);
            this.btnBuscarArchivo.Name = "btnBuscarArchivo";
            this.btnBuscarArchivo.Size = new System.Drawing.Size(117, 23);
            this.btnBuscarArchivo.TabIndex = 0;
            this.btnBuscarArchivo.Text = "Buscar Archivo";
            this.btnBuscarArchivo.UseVisualStyleBackColor = true;
            this.btnBuscarArchivo.Click += new System.EventHandler(this.btnBuscarArchivo_Click);
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(12, 45);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(457, 20);
            this.txtArchivo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione el Archivo";
            // 
            // txtLogArchivos
            // 
            this.txtLogArchivos.BackColor = System.Drawing.Color.White;
            this.txtLogArchivos.Location = new System.Drawing.Point(12, 104);
            this.txtLogArchivos.Multiline = true;
            this.txtLogArchivos.Name = "txtLogArchivos";
            this.txtLogArchivos.ReadOnly = true;
            this.txtLogArchivos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogArchivos.Size = new System.Drawing.Size(598, 301);
            this.txtLogArchivos.TabIndex = 3;
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.Location = new System.Drawing.Point(484, 75);
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Size = new System.Drawing.Size(117, 23);
            this.btnCargarArchivo.TabIndex = 4;
            this.btnCargarArchivo.Text = "Cargar Archivo";
            this.btnCargarArchivo.UseVisualStyleBackColor = true;
            this.btnCargarArchivo.Click += new System.EventHandler(this.btnCargarArchivo_Click);
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // problemas_frecuentesTableAdapter1
            // 
            this.problemas_frecuentesTableAdapter1.ClearBeforeFill = true;
            // 
            // soluciones_problemasTableAdapter1
            // 
            this.soluciones_problemasTableAdapter1.ClearBeforeFill = true;
            // 
            // frmImportadorProblemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 417);
            this.Controls.Add(this.btnCargarArchivo);
            this.Controls.Add(this.txtLogArchivos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.btnBuscarArchivo);
            this.Name = "frmImportadorProblemas";
            this.Text = "Importador Problemas Comunes";
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarArchivo;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLogArchivos;
        private System.Windows.Forms.Button btnCargarArchivo;
        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.problemas_frecuentesTableAdapter problemas_frecuentesTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.soluciones_problemasTableAdapter soluciones_problemasTableAdapter1;
    }
}