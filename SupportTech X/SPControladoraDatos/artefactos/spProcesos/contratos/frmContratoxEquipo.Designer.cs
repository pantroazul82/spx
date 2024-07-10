namespace spProcesos.contratos
{
    partial class frmContratoxEquipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContratoxEquipo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cmbNumeroContrato = new System.Windows.Forms.ComboBox();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.chkContatoActivo = new System.Windows.Forms.CheckBox();
            this.nmMantenimientosRealizados = new System.Windows.Forms.NumericUpDown();
            this.nmMantenimientosxContratos = new System.Windows.Forms.NumericUpDown();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clientesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.clientesTableAdapter();
            this.contratosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.contratosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMantenimientosRealizados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMantenimientosxContratos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Contrato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mantenimientos x Contrato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mantenimientos Realizados";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(311, 194);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(230, 194);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cmbNumeroContrato
            // 
            this.cmbNumeroContrato.DataSource = this.dsSpx1;
            this.cmbNumeroContrato.DisplayMember = "contratos.numeroContrato";
            this.cmbNumeroContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumeroContrato.FormattingEnabled = true;
            this.cmbNumeroContrato.Location = new System.Drawing.Point(160, 47);
            this.cmbNumeroContrato.Name = "cmbNumeroContrato";
            this.cmbNumeroContrato.Size = new System.Drawing.Size(226, 21);
            this.cmbNumeroContrato.TabIndex = 1;
            this.cmbNumeroContrato.ValueMember = "contratos.numeroContrato";
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chkContatoActivo
            // 
            this.chkContatoActivo.AutoSize = true;
            this.chkContatoActivo.Location = new System.Drawing.Point(160, 156);
            this.chkContatoActivo.Name = "chkContatoActivo";
            this.chkContatoActivo.Size = new System.Drawing.Size(99, 17);
            this.chkContatoActivo.TabIndex = 4;
            this.chkContatoActivo.Text = "Contrato Activo";
            this.chkContatoActivo.UseVisualStyleBackColor = true;
            // 
            // nmMantenimientosRealizados
            // 
            this.nmMantenimientosRealizados.Location = new System.Drawing.Point(160, 120);
            this.nmMantenimientosRealizados.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmMantenimientosRealizados.Name = "nmMantenimientosRealizados";
            this.nmMantenimientosRealizados.Size = new System.Drawing.Size(81, 20);
            this.nmMantenimientosRealizados.TabIndex = 3;
            // 
            // nmMantenimientosxContratos
            // 
            this.nmMantenimientosxContratos.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsSpx1, "contratos.NumeroMantenimientos", true));
            this.nmMantenimientosxContratos.Enabled = false;
            this.nmMantenimientosxContratos.Location = new System.Drawing.Point(160, 84);
            this.nmMantenimientosxContratos.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmMantenimientosxContratos.Name = "nmMantenimientosxContratos";
            this.nmMantenimientosxContratos.Size = new System.Drawing.Size(81, 20);
            this.nmMantenimientosxContratos.TabIndex = 2;
            // 
            // cmbCliente
            // 
            this.cmbCliente.DataSource = this.dsSpx1;
            this.cmbCliente.DisplayMember = "clientes.nombreCliente";
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(72, 12);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(314, 21);
            this.cmbCliente.TabIndex = 0;
            this.cmbCliente.ValueMember = "clientes.nitCliente";
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cliente";
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // contratosTableAdapter1
            // 
            this.contratosTableAdapter1.ClearBeforeFill = true;
            // 
            // frmContratoxEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(398, 225);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nmMantenimientosxContratos);
            this.Controls.Add(this.nmMantenimientosRealizados);
            this.Controls.Add(this.chkContatoActivo);
            this.Controls.Add(this.cmbNumeroContrato);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmContratoxEquipo";
            this.Text = "Agregar Contrato x Equipo";
            this.Load += new System.EventHandler(this.frmContratoxEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMantenimientosRealizados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMantenimientosxContratos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cmbNumeroContrato;
        private System.Windows.Forms.CheckBox chkContatoActivo;
        private System.Windows.Forms.NumericUpDown nmMantenimientosRealizados;
        private System.Windows.Forms.NumericUpDown nmMantenimientosxContratos;
        private System.Windows.Forms.ComboBox cmbCliente;
        private SPControladoraDatos.dsSpx dsSpx1;
        private System.Windows.Forms.Label label4;
        private SPControladoraDatos.dsSpxTableAdapters.clientesTableAdapter clientesTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.contratosTableAdapter contratosTableAdapter1;
    }
}