namespace spProcesos.ordenesTrabajo
{
    partial class frmRepuesto
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepuesto));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nmCantidad = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dtxtRepuesto = new CGDataControler.dataText();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.repuestosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.repuestosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nmCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(97, 97);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(178, 97);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Repuesto";
            // 
            // nmCantidad
            // 
            this.nmCantidad.Location = new System.Drawing.Point(74, 55);
            this.nmCantidad.Name = "nmCantidad";
            this.nmCantidad.Size = new System.Drawing.Size(100, 20);
            this.nmCantidad.TabIndex = 4;
            this.nmCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantidad";
            // 
            // dtxtRepuesto
            // 
            this.dtxtRepuesto.BackColor = System.Drawing.Color.Transparent;
            this.dtxtRepuesto.CadenaConexion = "";
            this.dtxtRepuesto.CampoNombre = "repuestos.descripcion";
            this.dtxtRepuesto.CampoValor = "repuestos.codRepuesto";
            this.dtxtRepuesto.DataMember = this.dsSpx1.repuestos;
            this.dtxtRepuesto.DataSource = this.dsSpx1;
            this.dtxtRepuesto.FiltroAdicional = "";
            this.dtxtRepuesto.Location = new System.Drawing.Point(74, 12);
            this.dtxtRepuesto.MostrarAnuncios = false;
            this.dtxtRepuesto.MostrarMensaje = true;
            this.dtxtRepuesto.Name = "dtxtRepuesto";
            this.dtxtRepuesto.Size = new System.Drawing.Size(265, 37);
            this.dtxtRepuesto.TabIndex = 5;
            this.dtxtRepuesto.Tipo_datos = CGDataControler.tipoDatos.texto;
            this.dtxtRepuesto.ValoresCorrectos = false;
            this.dtxtRepuesto.Load += new System.EventHandler(this.dataText1_Load);
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repuestosTableAdapter1
            // 
            this.repuestosTableAdapter1.ClearBeforeFill = true;
            // 
            // frmRepuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(351, 131);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtxtRepuesto);
            this.Controls.Add(this.nmCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRepuesto";
            this.Text = "Repuesto";
            this.Load += new System.EventHandler(this.frmRepuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.repuestosTableAdapter repuestosTableAdapter1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmCantidad;
        private CGDataControler.dataText dtxtRepuesto;
        private System.Windows.Forms.Label label2;
    }
}