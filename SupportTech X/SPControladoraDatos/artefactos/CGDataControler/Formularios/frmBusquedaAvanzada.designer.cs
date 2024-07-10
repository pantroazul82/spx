namespace CGDataControler.Formularios
{
    partial class frmBusquedaAvanzada
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
            this.cmbCampos = new System.Windows.Forms.ComboBox();
            this.cmbOperacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAbrirParentesis = new System.Windows.Forms.Button();
            this.btnAgregarOr = new System.Windows.Forms.Button();
            this.btnCerrarParentesis = new System.Windows.Forms.Button();
            this.btnAgregarAnd = new System.Windows.Forms.Button();
            this.btnEliminarAnterior = new System.Windows.Forms.Button();
            this.btnParentesisObligatorio = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.calValor = new System.Windows.Forms.DateTimePicker();
            this.numValor = new System.Windows.Forms.NumericUpDown();
            this.txtValorDoble = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCampos
            // 
            this.cmbCampos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampos.FormattingEnabled = true;
            this.cmbCampos.Location = new System.Drawing.Point(6, 43);
            this.cmbCampos.Name = "cmbCampos";
            this.cmbCampos.Size = new System.Drawing.Size(154, 21);
            this.cmbCampos.TabIndex = 0;
            this.cmbCampos.SelectedIndexChanged += new System.EventHandler(this.cmbCampos_SelectedIndexChanged);
            // 
            // cmbOperacion
            // 
            this.cmbOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperacion.FormattingEnabled = true;
            this.cmbOperacion.Items.AddRange(new object[] {
            "=",
            "!=",
            "<",
            ">",
            "<=",
            ">=",
            "LIKE"});
            this.cmbOperacion.Location = new System.Drawing.Point(178, 44);
            this.cmbOperacion.Name = "cmbOperacion";
            this.cmbOperacion.Size = new System.Drawing.Size(121, 21);
            this.cmbOperacion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Campo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Operacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(321, 44);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(151, 20);
            this.txtValor.TabIndex = 5;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(12, 198);
            this.txtFiltro.Multiline = true;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.ReadOnly = true;
            this.txtFiltro.Size = new System.Drawing.Size(660, 169);
            this.txtFiltro.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Filtro";
            // 
            // btnAbrirParentesis
            // 
            this.btnAbrirParentesis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirParentesis.Location = new System.Drawing.Point(12, 142);
            this.btnAbrirParentesis.Name = "btnAbrirParentesis";
            this.btnAbrirParentesis.Size = new System.Drawing.Size(143, 23);
            this.btnAbrirParentesis.TabIndex = 8;
            this.btnAbrirParentesis.Text = "Abrir Parentesis Opcional";
            this.btnAbrirParentesis.UseVisualStyleBackColor = true;
            this.btnAbrirParentesis.Click += new System.EventHandler(this.btnAbrirParentesis_Click);
            // 
            // btnAgregarOr
            // 
            this.btnAgregarOr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarOr.Location = new System.Drawing.Point(12, 113);
            this.btnAgregarOr.Name = "btnAgregarOr";
            this.btnAgregarOr.Size = new System.Drawing.Size(143, 23);
            this.btnAgregarOr.TabIndex = 9;
            this.btnAgregarOr.Text = "Agregar Como Opcional";
            this.btnAgregarOr.UseVisualStyleBackColor = true;
            this.btnAgregarOr.Click += new System.EventHandler(this.btnAgregarOr_Click);
            // 
            // btnCerrarParentesis
            // 
            this.btnCerrarParentesis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarParentesis.Location = new System.Drawing.Point(365, 142);
            this.btnCerrarParentesis.Name = "btnCerrarParentesis";
            this.btnCerrarParentesis.Size = new System.Drawing.Size(143, 23);
            this.btnCerrarParentesis.TabIndex = 10;
            this.btnCerrarParentesis.Text = "Cerrar Parentesis";
            this.btnCerrarParentesis.UseVisualStyleBackColor = true;
            this.btnCerrarParentesis.Click += new System.EventHandler(this.btnCerrarParentesis_Click);
            // 
            // btnAgregarAnd
            // 
            this.btnAgregarAnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAnd.Location = new System.Drawing.Point(190, 113);
            this.btnAgregarAnd.Name = "btnAgregarAnd";
            this.btnAgregarAnd.Size = new System.Drawing.Size(143, 23);
            this.btnAgregarAnd.TabIndex = 11;
            this.btnAgregarAnd.Text = "Agregar Como Obligatorio";
            this.btnAgregarAnd.UseVisualStyleBackColor = true;
            this.btnAgregarAnd.Click += new System.EventHandler(this.btnAgregarAnd_Click);
            // 
            // btnEliminarAnterior
            // 
            this.btnEliminarAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarAnterior.Location = new System.Drawing.Point(365, 113);
            this.btnEliminarAnterior.Name = "btnEliminarAnterior";
            this.btnEliminarAnterior.Size = new System.Drawing.Size(143, 23);
            this.btnEliminarAnterior.TabIndex = 12;
            this.btnEliminarAnterior.Text = "Eliminar Anterior Condicion";
            this.btnEliminarAnterior.UseVisualStyleBackColor = true;
            this.btnEliminarAnterior.Click += new System.EventHandler(this.btnEliminarAnterior_Click);
            // 
            // btnParentesisObligatorio
            // 
            this.btnParentesisObligatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParentesisObligatorio.Location = new System.Drawing.Point(190, 142);
            this.btnParentesisObligatorio.Name = "btnParentesisObligatorio";
            this.btnParentesisObligatorio.Size = new System.Drawing.Size(143, 23);
            this.btnParentesisObligatorio.TabIndex = 13;
            this.btnParentesisObligatorio.Text = "Abrir Parentesis Obligatorio";
            this.btnParentesisObligatorio.UseVisualStyleBackColor = true;
            this.btnParentesisObligatorio.Click += new System.EventHandler(this.btnParentesisObligatorio_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(591, 113);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(591, 143);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // calValor
            // 
            this.calValor.Location = new System.Drawing.Point(454, 17);
            this.calValor.Name = "calValor";
            this.calValor.Size = new System.Drawing.Size(200, 20);
            this.calValor.TabIndex = 16;
            this.calValor.Visible = false;
            // 
            // numValor
            // 
            this.numValor.Location = new System.Drawing.Point(503, 43);
            this.numValor.Maximum = new decimal(new int[] {
            1410055408,
            2,
            0,
            0});
            this.numValor.Name = "numValor";
            this.numValor.Size = new System.Drawing.Size(120, 20);
            this.numValor.TabIndex = 17;
            this.numValor.Visible = false;
            // 
            // txtValorDoble
            // 
            this.txtValorDoble.Location = new System.Drawing.Point(503, 59);
            this.txtValorDoble.Name = "txtValorDoble";
            this.txtValorDoble.Size = new System.Drawing.Size(151, 20);
            this.txtValorDoble.TabIndex = 18;
            this.txtValorDoble.Visible = false;
            this.txtValorDoble.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorDoble_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtValorDoble);
            this.groupBox1.Controls.Add(this.cmbCampos);
            this.groupBox1.Controls.Add(this.numValor);
            this.groupBox1.Controls.Add(this.cmbOperacion);
            this.groupBox1.Controls.Add(this.calValor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 85);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Condicion";
            // 
            // frmBusquedaAvanzada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(684, 377);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnParentesisObligatorio);
            this.Controls.Add(this.btnEliminarAnterior);
            this.Controls.Add(this.btnAgregarAnd);
            this.Controls.Add(this.btnCerrarParentesis);
            this.Controls.Add(this.btnAgregarOr);
            this.Controls.Add(this.btnAbrirParentesis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFiltro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBusquedaAvanzada";
            this.Text = "Filtros Avanzados";
            this.Load += new System.EventHandler(this.frmBusquedaAvanzada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCampos;
        private System.Windows.Forms.ComboBox cmbOperacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAbrirParentesis;
        private System.Windows.Forms.Button btnAgregarOr;
        private System.Windows.Forms.Button btnCerrarParentesis;
        private System.Windows.Forms.Button btnAgregarAnd;
        private System.Windows.Forms.Button btnEliminarAnterior;
        private System.Windows.Forms.Button btnParentesisObligatorio;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker calValor;
        private System.Windows.Forms.NumericUpDown numValor;
        private System.Windows.Forms.TextBox txtValorDoble;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}