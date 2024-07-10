namespace spProcesos.cientifica.proceso
{
    partial class frmCerrarOrdenEnSeguimiento
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
            this.label11 = new System.Windows.Forms.Label();
            this.asesoria_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.asesoria_cientificaTableAdapter();
            this.inconveniente_presentado_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.inconveniente_presentado_cientificaTableAdapter();
            this.txtAsesoriaNumero = new System.Windows.Forms.TextBox();
            this.estado_asesoria_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.estado_asesoria_cientificaTableAdapter();
            this.seguimiento_asesoria_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.seguimiento_asesoria_cientificaTableAdapter();
            this.accion_seguirxseguimiento_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.accion_seguirxseguimiento_cientificaTableAdapter();
            this.accion_seguir_cientificaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.accion_seguir_cientificaTableAdapter();
            this.equiposTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdNoControlCalidad = new System.Windows.Forms.RadioButton();
            this.rdSiControlCalidad = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 51);
            this.panel1.TabIndex = 7;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(206, 16);
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
            this.btnCancelar.Location = new System.Drawing.Point(287, 16);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Asesoria Num:";
            // 
            // asesoria_cientificaTableAdapter1
            // 
            this.asesoria_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // inconveniente_presentado_cientificaTableAdapter1
            // 
            this.inconveniente_presentado_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // txtAsesoriaNumero
            // 
            this.txtAsesoriaNumero.BackColor = System.Drawing.Color.White;
            this.txtAsesoriaNumero.Location = new System.Drawing.Point(138, 7);
            this.txtAsesoriaNumero.Name = "txtAsesoriaNumero";
            this.txtAsesoriaNumero.ReadOnly = true;
            this.txtAsesoriaNumero.Size = new System.Drawing.Size(190, 20);
            this.txtAsesoriaNumero.TabIndex = 53;
            // 
            // estado_asesoria_cientificaTableAdapter1
            // 
            this.estado_asesoria_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // seguimiento_asesoria_cientificaTableAdapter1
            // 
            this.seguimiento_asesoria_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // accion_seguirxseguimiento_cientificaTableAdapter1
            // 
            this.accion_seguirxseguimiento_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // accion_seguir_cientificaTableAdapter1
            // 
            this.accion_seguir_cientificaTableAdapter1.ClearBeforeFill = true;
            // 
            // equiposTableAdapter1
            // 
            this.equiposTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdNoControlCalidad);
            this.groupBox3.Controls.Add(this.rdSiControlCalidad);
            this.groupBox3.Location = new System.Drawing.Point(55, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(203, 54);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Requiere Control de Calidad";
            // 
            // rdNoControlCalidad
            // 
            this.rdNoControlCalidad.AutoSize = true;
            this.rdNoControlCalidad.Location = new System.Drawing.Point(74, 24);
            this.rdNoControlCalidad.Name = "rdNoControlCalidad";
            this.rdNoControlCalidad.Size = new System.Drawing.Size(39, 17);
            this.rdNoControlCalidad.TabIndex = 1;
            this.rdNoControlCalidad.TabStop = true;
            this.rdNoControlCalidad.Text = "No";
            this.rdNoControlCalidad.UseVisualStyleBackColor = true;
            // 
            // rdSiControlCalidad
            // 
            this.rdSiControlCalidad.AutoSize = true;
            this.rdSiControlCalidad.Location = new System.Drawing.Point(34, 24);
            this.rdSiControlCalidad.Name = "rdSiControlCalidad";
            this.rdSiControlCalidad.Size = new System.Drawing.Size(34, 17);
            this.rdSiControlCalidad.TabIndex = 0;
            this.rdSiControlCalidad.TabStop = true;
            this.rdSiControlCalidad.Text = "Si";
            this.rdSiControlCalidad.UseVisualStyleBackColor = true;
            // 
            // frmCerrarOrdenEnSeguimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 177);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtAsesoriaNumero);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "frmCerrarOrdenEnSeguimiento";
            this.Text = "Cerrar Asesoria";
            this.Load += new System.EventHandler(this.frmCerrarOrden_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label11;
        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.asesoria_cientificaTableAdapter asesoria_cientificaTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.inconveniente_presentado_cientificaTableAdapter inconveniente_presentado_cientificaTableAdapter1;
        private System.Windows.Forms.TextBox txtAsesoriaNumero;
        private SPControladoraDatos.dsSpxTableAdapters.estado_asesoria_cientificaTableAdapter estado_asesoria_cientificaTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.seguimiento_asesoria_cientificaTableAdapter seguimiento_asesoria_cientificaTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.accion_seguirxseguimiento_cientificaTableAdapter accion_seguirxseguimiento_cientificaTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.accion_seguir_cientificaTableAdapter accion_seguir_cientificaTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter equiposTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdNoControlCalidad;
        private System.Windows.Forms.RadioButton rdSiControlCalidad;
    }
}