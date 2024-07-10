namespace spProcesos.contratos_consumo
{
    partial class frmConsumibles
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
            this.txtconsumibles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dsContratoConsumo1 = new SPControladoraDatos.dsContratoConsumo();
            this.consumiblesTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.consumiblesTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGrupoConsumible = new System.Windows.Forms.ComboBox();
            this.grupo_consumibleTableAdapter1 = new SPControladoraDatos.dsContratoConsumoTableAdapters.grupo_consumibleTableAdapter();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.label3 = new System.Windows.Forms.Label();
            this.fabricanteTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.fabricanteTableAdapter();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.panel1.Location = new System.Drawing.Point(0, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 45);
            this.panel1.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(342, 7);
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
            this.btnCancelar.Location = new System.Drawing.Point(421, 7);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtconsumibles
            // 
            this.txtconsumibles.Location = new System.Drawing.Point(139, 88);
            this.txtconsumibles.Name = "txtconsumibles";
            this.txtconsumibles.Size = new System.Drawing.Size(301, 20);
            this.txtconsumibles.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consumibles";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Grupo Consumible";
            // 
            // cmbGrupoConsumible
            // 
            this.cmbGrupoConsumible.DataSource = this.dsContratoConsumo1;
            this.cmbGrupoConsumible.DisplayMember = "grupo_consumible.grupo_consumible";
            this.cmbGrupoConsumible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupoConsumible.FormattingEnabled = true;
            this.cmbGrupoConsumible.Location = new System.Drawing.Point(139, 50);
            this.cmbGrupoConsumible.Name = "cmbGrupoConsumible";
            this.cmbGrupoConsumible.Size = new System.Drawing.Size(301, 21);
            this.cmbGrupoConsumible.TabIndex = 6;
            this.cmbGrupoConsumible.ValueMember = "grupo_consumible.cod_grupo_consumible";
            // 
            // grupo_consumibleTableAdapter1
            // 
            this.grupo_consumibleTableAdapter1.ClearBeforeFill = true;
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.DataSource = this.dsSpx1;
            this.cmbFabricante.DisplayMember = "fabricante.nombre_fabricante";
            this.cmbFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(139, 12);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(301, 21);
            this.cmbFabricante.TabIndex = 8;
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
            this.label3.Location = new System.Drawing.Point(23, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fabricante";
            // 
            // fabricanteTableAdapter1
            // 
            this.fabricanteTableAdapter1.ClearBeforeFill = true;
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(139, 118);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(301, 20);
            this.txtReferencia.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Referencia";
            // 
            // frmConsumibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(501, 224);
            this.Controls.Add(this.txtReferencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbFabricante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbGrupoConsumible);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtconsumibles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConsumibles";
            this.Text = "Consumibles";
            this.Load += new System.EventHandler(this.frmConsumibles_Load);
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
        private System.Windows.Forms.TextBox txtconsumibles;
        private System.Windows.Forms.Label label1;
        private SPControladoraDatos.dsContratoConsumo dsContratoConsumo1;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.consumiblesTableAdapter consumiblesTableAdapter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGrupoConsumible;
        private SPControladoraDatos.dsContratoConsumoTableAdapters.grupo_consumibleTableAdapter grupo_consumibleTableAdapter1;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.Label label3;
        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.fabricanteTableAdapter fabricanteTableAdapter1;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label label4;
    }
}