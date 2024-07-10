namespace spProcesos.contratos_consumo
{
    partial class frmconsumiblexContratos
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
            this.dsContratoConsumo1 = new SPControladoraDatos.dsContratoConsumo();
            this.consumiblesTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.consumiblesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbConsumible = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.consumiblexcontrato_consumoTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.consumiblexcontrato_consumoTableAdapter();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGrupoConsumible = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fabricanteTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.fabricanteTableAdapter();
            this.grupo_consumibleTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.grupo_consumibleTableAdapter();
            this.nmCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsContratoConsumo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 45);
            this.panel1.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(235, 7);
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
            this.btnCancelar.Location = new System.Drawing.Point(314, 7);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dsContratoConsumo1
            // 
            this.dsContratoConsumo1.DataSetName = "dsContratoConsumo";
            this.dsContratoConsumo1.EnforceConstraints = false;
            this.dsContratoConsumo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consumiblesTableAdapter1
            // 
            this.consumiblesTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Consumibles";
            // 
            // cmbConsumible
            // 
            this.cmbConsumible.DataSource = this.dsContratoConsumo1;
            this.cmbConsumible.DisplayMember = "consumibles.consumible";
            this.cmbConsumible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConsumible.FormattingEnabled = true;
            this.cmbConsumible.Location = new System.Drawing.Point(128, 66);
            this.cmbConsumible.Name = "cmbConsumible";
            this.cmbConsumible.Size = new System.Drawing.Size(240, 21);
            this.cmbConsumible.TabIndex = 5;
            this.cmbConsumible.ValueMember = "consumibles.cod_consumible";
            this.cmbConsumible.SelectedIndexChanged += new System.EventHandler(this.cmbConsumible_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantidad";
            // 
            // consumiblexcontrato_consumoTableAdapter1
            // 
            this.consumiblexcontrato_consumoTableAdapter1.ClearBeforeFill = true;
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.DataSource = this.dsSpx1;
            this.cmbFabricante.DisplayMember = "fabricante.nombre_fabricante";
            this.cmbFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(128, 12);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(240, 21);
            this.cmbFabricante.TabIndex = 9;
            this.cmbFabricante.ValueMember = "fabricante.cod_fabricante";
            this.cmbFabricante.SelectedIndexChanged += new System.EventHandler(this.cmbFabricante_SelectedIndexChanged);
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.EnforceConstraints = false;
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fabricante";
            // 
            // cmbGrupoConsumible
            // 
            this.cmbGrupoConsumible.DataSource = this.dsContratoConsumo1;
            this.cmbGrupoConsumible.DisplayMember = "grupo_consumible.grupo_consumible";
            this.cmbGrupoConsumible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupoConsumible.FormattingEnabled = true;
            this.cmbGrupoConsumible.Location = new System.Drawing.Point(128, 39);
            this.cmbGrupoConsumible.Name = "cmbGrupoConsumible";
            this.cmbGrupoConsumible.Size = new System.Drawing.Size(240, 21);
            this.cmbGrupoConsumible.TabIndex = 11;
            this.cmbGrupoConsumible.ValueMember = "grupo_consumible.cod_grupo_consumible";
            this.cmbGrupoConsumible.SelectedIndexChanged += new System.EventHandler(this.cmbGrupoConsumible_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Grupo Consumibles";
            // 
            // fabricanteTableAdapter1
            // 
            this.fabricanteTableAdapter1.ClearBeforeFill = true;
            // 
            // grupo_consumibleTableAdapter1
            // 
            this.grupo_consumibleTableAdapter1.ClearBeforeFill = true;
            // 
            // nmCantidad
            // 
            this.nmCantidad.Location = new System.Drawing.Point(128, 129);
            this.nmCantidad.Name = "nmCantidad";
            this.nmCantidad.Size = new System.Drawing.Size(100, 20);
            this.nmCantidad.TabIndex = 12;
            this.nmCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nmCantidad_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "separador decimal (.)";
            // 
            // frmconsumiblexContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(394, 216);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nmCantidad);
            this.Controls.Add(this.cmbGrupoConsumible);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbFabricante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbConsumible);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmconsumiblexContratos";
            this.Text = "Consumibles x Contrato";
            this.Load += new System.EventHandler(this.frmconsumiblexContratos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsContratoConsumo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private SPControladoraDatos.dsContratoConsumo dsContratoConsumo1;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.consumiblesTableAdapter consumiblesTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbConsumible;
        private System.Windows.Forms.Label label2;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.consumiblexcontrato_consumoTableAdapter consumiblexcontrato_consumoTableAdapter1;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private SPControladoraDatos.dsSpx dsSpx1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbGrupoConsumible;
        private System.Windows.Forms.Label label4;
        private SPControladoraDatos.dsSpxTableAdapters.fabricanteTableAdapter fabricanteTableAdapter1;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.grupo_consumibleTableAdapter grupo_consumibleTableAdapter1;
        private System.Windows.Forms.TextBox nmCantidad;
        private System.Windows.Forms.Label label5;
    }
}