namespace spProcesos.programacion
{
    partial class frmDetallesProgramacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetallesProgramacion));
            this.cmbTipoServicio = new System.Windows.Forms.ComboBox();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.chkConfirmado = new System.Windows.Forms.CheckBox();
            this.cmbAmpLlegada = new System.Windows.Forms.ComboBox();
            this.cmbMinutoLlegada = new System.Windows.Forms.ComboBox();
            this.cmbhoraLLegada = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tipoServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.TipoServicioTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAmPmFin = new System.Windows.Forms.ComboBox();
            this.cmbMinutoFin = new System.Windows.Forms.ComboBox();
            this.cmbHoraFin = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.modelosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter();
            this.equiposTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.prioridadesOrdenServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.prioridadesOrdenServicioTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTipoServicio
            // 
            this.cmbTipoServicio.DataSource = this.dsSpx1;
            this.cmbTipoServicio.DisplayMember = "TipoServicio.nombretipoServicio";
            this.cmbTipoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoServicio.FormattingEnabled = true;
            this.cmbTipoServicio.Location = new System.Drawing.Point(103, 25);
            this.cmbTipoServicio.Name = "cmbTipoServicio";
            this.cmbTipoServicio.Size = new System.Drawing.Size(200, 21);
            this.cmbTipoServicio.TabIndex = 0;
            this.cmbTipoServicio.ValueMember = "TipoServicio.codTipoServicio";
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chkConfirmado
            // 
            this.chkConfirmado.AutoSize = true;
            this.chkConfirmado.Location = new System.Drawing.Point(103, 185);
            this.chkConfirmado.Name = "chkConfirmado";
            this.chkConfirmado.Size = new System.Drawing.Size(81, 17);
            this.chkConfirmado.TabIndex = 9;
            this.chkConfirmado.Text = "Confirmado";
            this.chkConfirmado.UseVisualStyleBackColor = true;
            // 
            // cmbAmpLlegada
            // 
            this.cmbAmpLlegada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAmpLlegada.FormattingEnabled = true;
            this.cmbAmpLlegada.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cmbAmpLlegada.Location = new System.Drawing.Point(216, 125);
            this.cmbAmpLlegada.Name = "cmbAmpLlegada";
            this.cmbAmpLlegada.Size = new System.Drawing.Size(51, 21);
            this.cmbAmpLlegada.TabIndex = 5;
            this.cmbAmpLlegada.SelectedIndexChanged += new System.EventHandler(this.cmbAmpLlegada_SelectedIndexChanged);
            // 
            // cmbMinutoLlegada
            // 
            this.cmbMinutoLlegada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMinutoLlegada.FormattingEnabled = true;
            this.cmbMinutoLlegada.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmbMinutoLlegada.Location = new System.Drawing.Point(160, 125);
            this.cmbMinutoLlegada.Name = "cmbMinutoLlegada";
            this.cmbMinutoLlegada.Size = new System.Drawing.Size(51, 21);
            this.cmbMinutoLlegada.TabIndex = 4;
            this.cmbMinutoLlegada.SelectedIndexChanged += new System.EventHandler(this.cmbMinutoLlegada_SelectedIndexChanged);
            // 
            // cmbhoraLLegada
            // 
            this.cmbhoraLLegada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbhoraLLegada.FormattingEnabled = true;
            this.cmbhoraLLegada.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbhoraLLegada.Location = new System.Drawing.Point(103, 125);
            this.cmbhoraLLegada.Name = "cmbhoraLLegada";
            this.cmbhoraLLegada.Size = new System.Drawing.Size(51, 21);
            this.cmbhoraLLegada.TabIndex = 3;
            this.cmbhoraLLegada.SelectedIndexChanged += new System.EventHandler(this.cmbhoraLLegada_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(14, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "Hora Inicio";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 35);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tipo de Mantenimiento";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(311, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(230, 15);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // tipoServicioTableAdapter1
            // 
            this.tipoServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 93);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Fecha";
            // 
            // cmbAmPmFin
            // 
            this.cmbAmPmFin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAmPmFin.FormattingEnabled = true;
            this.cmbAmPmFin.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cmbAmPmFin.Location = new System.Drawing.Point(216, 152);
            this.cmbAmPmFin.Name = "cmbAmPmFin";
            this.cmbAmPmFin.Size = new System.Drawing.Size(51, 21);
            this.cmbAmPmFin.TabIndex = 8;
            // 
            // cmbMinutoFin
            // 
            this.cmbMinutoFin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMinutoFin.FormattingEnabled = true;
            this.cmbMinutoFin.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmbMinutoFin.Location = new System.Drawing.Point(160, 152);
            this.cmbMinutoFin.Name = "cmbMinutoFin";
            this.cmbMinutoFin.Size = new System.Drawing.Size(51, 21);
            this.cmbMinutoFin.TabIndex = 7;
            // 
            // cmbHoraFin
            // 
            this.cmbHoraFin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoraFin.FormattingEnabled = true;
            this.cmbHoraFin.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbHoraFin.Location = new System.Drawing.Point(103, 152);
            this.cmbHoraFin.Name = "cmbHoraFin";
            this.cmbHoraFin.Size = new System.Drawing.Size(51, 21);
            this.cmbHoraFin.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Hora Fin";
            // 
            // modelosTableAdapter1
            // 
            this.modelosTableAdapter1.ClearBeforeFill = true;
            // 
            // equiposTableAdapter1
            // 
            this.equiposTableAdapter1.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(14, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 35;
            this.label4.Text = "Prioridad";
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.DataSource = this.dsSpx1;
            this.cmbPrioridad.DisplayMember = "prioridadesOrdenServicio.nombre";
            this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Location = new System.Drawing.Point(103, 59);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(200, 21);
            this.cmbPrioridad.TabIndex = 1;
            this.cmbPrioridad.ValueMember = "prioridadesOrdenServicio.codPrioridadOS";
            // 
            // prioridadesOrdenServicioTableAdapter1
            // 
            this.prioridadesOrdenServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(14, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 36;
            this.label5.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(103, 208);
            this.txtObservaciones.MaxLength = 250;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(283, 108);
            this.txtObservaciones.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 329);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(398, 50);
            this.panel1.TabIndex = 11;
            // 
            // frmDetallesProgramacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(398, 379);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbPrioridad);
            this.Controls.Add(this.cmbAmPmFin);
            this.Controls.Add(this.cmbMinutoFin);
            this.Controls.Add(this.cmbHoraFin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAmpLlegada);
            this.Controls.Add(this.cmbMinutoLlegada);
            this.Controls.Add(this.cmbhoraLLegada);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkConfirmado);
            this.Controls.Add(this.cmbTipoServicio);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDetallesProgramacion";
            this.Text = "Detalles Programacion";
            this.Load += new System.EventHandler(this.frmDetallesProgramacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoServicio;
        private System.Windows.Forms.CheckBox chkConfirmado;
        private System.Windows.Forms.ComboBox cmbAmpLlegada;
        private System.Windows.Forms.ComboBox cmbMinutoLlegada;
        private System.Windows.Forms.ComboBox cmbhoraLLegada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.TipoServicioTableAdapter tipoServicioTableAdapter1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAmPmFin;
        private System.Windows.Forms.ComboBox cmbMinutoFin;
        private System.Windows.Forms.ComboBox cmbHoraFin;
        private System.Windows.Forms.Label label3;
        private SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter modelosTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter equiposTableAdapter1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private SPControladoraDatos.dsSpxTableAdapters.prioridadesOrdenServicioTableAdapter prioridadesOrdenServicioTableAdapter1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Panel panel1;
    }
}