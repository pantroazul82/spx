namespace spHerramientas.frm
{
    partial class frmCambiarCodigoAccesorio
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
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCodigoNuevo = new System.Windows.Forms.TextBox();
            this.accesoriosEquipoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.accesoriosEquipoTableAdapter();
            this.txtBusqueda1 = new SPControladoraDatos.artefactos.SPXUtilidades.Controles.txtBusqueda();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(86, 15);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(167, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Accesorio Original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Codigo Nuevo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 50);
            this.panel1.TabIndex = 5;
            // 
            // txtCodigoNuevo
            // 
            this.txtCodigoNuevo.AcceptsReturn = true;
            this.txtCodigoNuevo.Location = new System.Drawing.Point(15, 96);
            this.txtCodigoNuevo.Name = "txtCodigoNuevo";
            this.txtCodigoNuevo.Size = new System.Drawing.Size(294, 20);
            this.txtCodigoNuevo.TabIndex = 6;
            // 
            // accesoriosEquipoTableAdapter1
            // 
            this.accesoriosEquipoTableAdapter1.ClearBeforeFill = true;
            // 
            // txtBusqueda1
            // 
            this.txtBusqueda1.codigo = "codAccesoriosEquipos";
            this.txtBusqueda1.DataMember = this.dsSpx1.accesoriosEquipo;
            this.txtBusqueda1.DataSource = this.dsSpx1;
            this.txtBusqueda1.descripcion1 = "nombreAccesorio";
            this.txtBusqueda1.descripcion2 = "codAccesoriosEquipos";
            this.txtBusqueda1.filtroAdicional = null;
            this.txtBusqueda1.Location = new System.Drawing.Point(15, 34);
            this.txtBusqueda1.Name = "txtBusqueda1";
            this.txtBusqueda1.Size = new System.Drawing.Size(294, 22);
            this.txtBusqueda1.TabIndex = 7;
            this.txtBusqueda1.Tabla = this.dsSpx1.accesoriosEquipo;
            this.txtBusqueda1.TamanoPopUp = 5;
            this.txtBusqueda1.Value = null;
            // 
            // frmCambiarCodigoAccesorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 247);
            this.ControlBox = false;
            this.Controls.Add(this.txtBusqueda1);
            this.Controls.Add(this.txtCodigoNuevo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCambiarCodigoAccesorio";
            this.Text = "Cambiar Codigo Accesorio";
            this.Load += new System.EventHandler(this.frmCambiarCodigoAccesorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SPControladoraDatos.dsSpx dsSpx1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCodigoNuevo;
        private SPControladoraDatos.dsSpxTableAdapters.accesoriosEquipoTableAdapter accesoriosEquipoTableAdapter1;
        private SPControladoraDatos.artefactos.SPXUtilidades.Controles.txtBusqueda txtBusqueda1;
    }
}