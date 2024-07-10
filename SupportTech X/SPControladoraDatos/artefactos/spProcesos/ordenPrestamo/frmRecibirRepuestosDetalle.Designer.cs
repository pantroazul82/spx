namespace spProcesos.ordenPrestamo
{
    partial class frmRecibirRepuestosDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecibirRepuestosDetalle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConNotasalida = new System.Windows.Forms.TextBox();
            this.txtCantidadPrestada = new System.Windows.Forms.TextBox();
            this.txtDevuelta = new System.Windows.Forms.TextBox();
            this.txtObservacionesNotaSalida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.repuestosxOrdenPrestamoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.repuestosxOrdenPrestamoTableAdapter();
            this.txtRepuesto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.repuestosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.repuestosTableAdapter();
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
            this.panel1.Location = new System.Drawing.Point(0, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 50);
            this.panel1.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(186, 15);
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
            this.btnCancelar.Location = new System.Drawing.Point(267, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(70, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 134;
            this.label1.Text = "Cantidad Prestada";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(70, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 135;
            this.label2.Text = "Cantidad Devuelta";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(70, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 30);
            this.label3.TabIndex = 136;
            this.label3.Text = "Cantidad con Nota de Salida";
            // 
            // txtConNotasalida
            // 
            this.txtConNotasalida.Location = new System.Drawing.Point(186, 104);
            this.txtConNotasalida.Name = "txtConNotasalida";
            this.txtConNotasalida.Size = new System.Drawing.Size(100, 21);
            this.txtConNotasalida.TabIndex = 1;
            this.txtConNotasalida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConNotasalida_KeyPress);
            // 
            // txtCantidadPrestada
            // 
            this.txtCantidadPrestada.Location = new System.Drawing.Point(186, 51);
            this.txtCantidadPrestada.Name = "txtCantidadPrestada";
            this.txtCantidadPrestada.ReadOnly = true;
            this.txtCantidadPrestada.Size = new System.Drawing.Size(100, 21);
            this.txtCantidadPrestada.TabIndex = 138;
            // 
            // txtDevuelta
            // 
            this.txtDevuelta.Location = new System.Drawing.Point(186, 77);
            this.txtDevuelta.Name = "txtDevuelta";
            this.txtDevuelta.Size = new System.Drawing.Size(100, 21);
            this.txtDevuelta.TabIndex = 0;
            this.txtDevuelta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDevuelta_KeyPress);
            // 
            // txtObservacionesNotaSalida
            // 
            this.txtObservacionesNotaSalida.Location = new System.Drawing.Point(14, 173);
            this.txtObservacionesNotaSalida.Multiline = true;
            this.txtObservacionesNotaSalida.Name = "txtObservacionesNotaSalida";
            this.txtObservacionesNotaSalida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacionesNotaSalida.Size = new System.Drawing.Size(332, 84);
            this.txtObservacionesNotaSalida.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(11, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 140;
            this.label4.Text = "Observaciones Nota de Salida";
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repuestosxOrdenPrestamoTableAdapter1
            // 
            this.repuestosxOrdenPrestamoTableAdapter1.ClearBeforeFill = true;
            // 
            // txtRepuesto
            // 
            this.txtRepuesto.Location = new System.Drawing.Point(64, 12);
            this.txtRepuesto.Name = "txtRepuesto";
            this.txtRepuesto.ReadOnly = true;
            this.txtRepuesto.Size = new System.Drawing.Size(282, 21);
            this.txtRepuesto.TabIndex = 143;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 142;
            this.label5.Text = "Repuesto";
            // 
            // repuestosTableAdapter1
            // 
            this.repuestosTableAdapter1.ClearBeforeFill = true;
            // 
            // frmRecibirRepuestosDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(359, 320);
            this.ControlBox = false;
            this.Controls.Add(this.txtRepuesto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtObservacionesNotaSalida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDevuelta);
            this.Controls.Add(this.txtCantidadPrestada);
            this.Controls.Add(this.txtConNotasalida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRecibirRepuestosDetalle";
            this.Text = "Recibir Repuestos Detalle";
            this.Load += new System.EventHandler(this.frmRecibirRepuestosDetalle_Load);
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
        private SPControladoraDatos.dsSpxTableAdapters.repuestosxOrdenPrestamoTableAdapter repuestosxOrdenPrestamoTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConNotasalida;
        private System.Windows.Forms.TextBox txtCantidadPrestada;
        private System.Windows.Forms.TextBox txtDevuelta;
        private System.Windows.Forms.TextBox txtObservacionesNotaSalida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRepuesto;
        private System.Windows.Forms.Label label5;
        private SPControladoraDatos.dsSpxTableAdapters.repuestosTableAdapter repuestosTableAdapter1;
    }
}