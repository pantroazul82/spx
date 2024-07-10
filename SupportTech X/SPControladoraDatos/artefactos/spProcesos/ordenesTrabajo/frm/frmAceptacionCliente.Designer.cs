namespace spProcesos.ordenesTrabajo
{
    partial class frmAceptacionCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAceptacionCliente));
            this.cmbAmPMSalidaCliente = new System.Windows.Forms.ComboBox();
            this.cmbMinSalidaCliente = new System.Windows.Forms.ComboBox();
            this.label38 = new System.Windows.Forms.Label();
            this.cmbHoraSalidaCliente = new System.Windows.Forms.ComboBox();
            this.txtUsuarioCliente = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.cmbAmPmLlegadaCliente = new System.Windows.Forms.ComboBox();
            this.cmbHoraLlegadaCliente = new System.Windows.Forms.ComboBox();
            this.cmbMinutosLlegadaCliente = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnComprobantesAceptacion = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipoComprobante = new System.Windows.Forms.TextBox();
            this.btnQuitarComprobante = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comprobantesAceptacionOrdenservicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.comprobantesAceptacionOrdenservicioTableAdapter();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.tipoComprobanteTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.tipoComprobanteTableAdapter();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAmPMSalidaCliente
            // 
            this.cmbAmPMSalidaCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAmPMSalidaCliente.FormattingEnabled = true;
            this.cmbAmPMSalidaCliente.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cmbAmPMSalidaCliente.Location = new System.Drawing.Point(292, 98);
            this.cmbAmPMSalidaCliente.Name = "cmbAmPMSalidaCliente";
            this.cmbAmPMSalidaCliente.Size = new System.Drawing.Size(51, 21);
            this.cmbAmPMSalidaCliente.TabIndex = 101;
            // 
            // cmbMinSalidaCliente
            // 
            this.cmbMinSalidaCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMinSalidaCliente.FormattingEnabled = true;
            this.cmbMinSalidaCliente.Items.AddRange(new object[] {
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
            this.cmbMinSalidaCliente.Location = new System.Drawing.Point(235, 98);
            this.cmbMinSalidaCliente.Name = "cmbMinSalidaCliente";
            this.cmbMinSalidaCliente.Size = new System.Drawing.Size(51, 21);
            this.cmbMinSalidaCliente.TabIndex = 100;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.Location = new System.Drawing.Point(9, 14);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(150, 13);
            this.label38.TabIndex = 94;
            this.label38.Text = "Nombre de Usuario del Cliente";
            // 
            // cmbHoraSalidaCliente
            // 
            this.cmbHoraSalidaCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoraSalidaCliente.FormattingEnabled = true;
            this.cmbHoraSalidaCliente.Items.AddRange(new object[] {
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
            this.cmbHoraSalidaCliente.Location = new System.Drawing.Point(178, 98);
            this.cmbHoraSalidaCliente.Name = "cmbHoraSalidaCliente";
            this.cmbHoraSalidaCliente.Size = new System.Drawing.Size(51, 21);
            this.cmbHoraSalidaCliente.TabIndex = 99;
            // 
            // txtUsuarioCliente
            // 
            this.txtUsuarioCliente.Location = new System.Drawing.Point(12, 30);
            this.txtUsuarioCliente.Name = "txtUsuarioCliente";
            this.txtUsuarioCliente.Size = new System.Drawing.Size(323, 20);
            this.txtUsuarioCliente.TabIndex = 95;
            // 
            // label41
            // 
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.Location = new System.Drawing.Point(9, 98);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(155, 21);
            this.label41.TabIndex = 103;
            this.label41.Text = "Hora Salida donde el Cliente";
            // 
            // label42
            // 
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Location = new System.Drawing.Point(9, 66);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(155, 20);
            this.label42.TabIndex = 102;
            this.label42.Text = "Hora Llegada donde el Cliente";
            // 
            // cmbAmPmLlegadaCliente
            // 
            this.cmbAmPmLlegadaCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAmPmLlegadaCliente.FormattingEnabled = true;
            this.cmbAmPmLlegadaCliente.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cmbAmPmLlegadaCliente.Location = new System.Drawing.Point(292, 66);
            this.cmbAmPmLlegadaCliente.Name = "cmbAmPmLlegadaCliente";
            this.cmbAmPmLlegadaCliente.Size = new System.Drawing.Size(51, 21);
            this.cmbAmPmLlegadaCliente.TabIndex = 98;
            this.cmbAmPmLlegadaCliente.SelectedIndexChanged += new System.EventHandler(this.cmbAmPmLlegadaCliente_SelectedIndexChanged);
            // 
            // cmbHoraLlegadaCliente
            // 
            this.cmbHoraLlegadaCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoraLlegadaCliente.FormattingEnabled = true;
            this.cmbHoraLlegadaCliente.Items.AddRange(new object[] {
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
            this.cmbHoraLlegadaCliente.Location = new System.Drawing.Point(178, 66);
            this.cmbHoraLlegadaCliente.Name = "cmbHoraLlegadaCliente";
            this.cmbHoraLlegadaCliente.Size = new System.Drawing.Size(51, 21);
            this.cmbHoraLlegadaCliente.TabIndex = 96;
            this.cmbHoraLlegadaCliente.SelectedIndexChanged += new System.EventHandler(this.cmbHoraLlegadaCliente_SelectedIndexChanged);
            // 
            // cmbMinutosLlegadaCliente
            // 
            this.cmbMinutosLlegadaCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMinutosLlegadaCliente.FormattingEnabled = true;
            this.cmbMinutosLlegadaCliente.Items.AddRange(new object[] {
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
            this.cmbMinutosLlegadaCliente.Location = new System.Drawing.Point(235, 66);
            this.cmbMinutosLlegadaCliente.Name = "cmbMinutosLlegadaCliente";
            this.cmbMinutosLlegadaCliente.Size = new System.Drawing.Size(51, 21);
            this.cmbMinutosLlegadaCliente.TabIndex = 97;
            this.cmbMinutosLlegadaCliente.SelectedIndexChanged += new System.EventHandler(this.cmbMinutosLlegadaCliente_SelectedIndexChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(184, 395);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 104;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(265, 395);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 105;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnComprobantesAceptacion);
            this.groupBox1.Location = new System.Drawing.Point(268, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 252);
            this.groupBox1.TabIndex = 106;
            this.groupBox1.TabStop = false;
            // 
            // btnComprobantesAceptacion
            // 
            this.btnComprobantesAceptacion.Location = new System.Drawing.Point(67, 107);
            this.btnComprobantesAceptacion.Name = "btnComprobantesAceptacion";
            this.btnComprobantesAceptacion.Size = new System.Drawing.Size(195, 39);
            this.btnComprobantesAceptacion.TabIndex = 105;
            this.btnComprobantesAceptacion.Text = "Agregar Comprobante Digital";
            this.btnComprobantesAceptacion.UseVisualStyleBackColor = true;
            this.btnComprobantesAceptacion.Click += new System.EventHandler(this.btnComprobantesAceptacion_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTipoComprobante);
            this.groupBox2.Controls.Add(this.btnQuitarComprobante);
            this.groupBox2.Location = new System.Drawing.Point(12, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 252);
            this.groupBox2.TabIndex = 107;
            this.groupBox2.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(6, 223);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(111, 23);
            this.btnGuardar.TabIndex = 109;
            this.btnGuardar.Text = "Guardar Imagen";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(6, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 108;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 106;
            this.label1.Text = "Tipo de Comprobamte";
            // 
            // txtTipoComprobante
            // 
            this.txtTipoComprobante.Location = new System.Drawing.Point(6, 33);
            this.txtTipoComprobante.Name = "txtTipoComprobante";
            this.txtTipoComprobante.ReadOnly = true;
            this.txtTipoComprobante.Size = new System.Drawing.Size(316, 20);
            this.txtTipoComprobante.TabIndex = 107;
            // 
            // btnQuitarComprobante
            // 
            this.btnQuitarComprobante.Location = new System.Drawing.Point(126, 223);
            this.btnQuitarComprobante.Name = "btnQuitarComprobante";
            this.btnQuitarComprobante.Size = new System.Drawing.Size(195, 23);
            this.btnQuitarComprobante.TabIndex = 105;
            this.btnQuitarComprobante.Text = "Quitar Comprobante Digital";
            this.btnQuitarComprobante.UseVisualStyleBackColor = true;
            this.btnQuitarComprobante.Click += new System.EventHandler(this.btnQuitarComprobante_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // comprobantesAceptacionOrdenservicioTableAdapter1
            // 
            this.comprobantesAceptacionOrdenservicioTableAdapter1.ClearBeforeFill = true;
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoComprobanteTableAdapter1
            // 
            this.tipoComprobanteTableAdapter1.ClearBeforeFill = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Imagen|*.jpg";
            // 
            // frmAceptacionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(345, 420);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbAmPMSalidaCliente);
            this.Controls.Add(this.cmbMinSalidaCliente);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.cmbHoraSalidaCliente);
            this.Controls.Add(this.txtUsuarioCliente);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.cmbAmPmLlegadaCliente);
            this.Controls.Add(this.cmbHoraLlegadaCliente);
            this.Controls.Add(this.cmbMinutosLlegadaCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAceptacionCliente";
            this.Text = "Informacion Aceptacion Cliente";
            this.Load += new System.EventHandler(this.frmAceptacionCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAmPMSalidaCliente;
        private System.Windows.Forms.ComboBox cmbMinSalidaCliente;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.ComboBox cmbHoraSalidaCliente;
        private System.Windows.Forms.TextBox txtUsuarioCliente;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.ComboBox cmbAmPmLlegadaCliente;
        private System.Windows.Forms.ComboBox cmbHoraLlegadaCliente;
        private System.Windows.Forms.ComboBox cmbMinutosLlegadaCliente;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnComprobantesAceptacion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnQuitarComprobante;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTipoComprobante;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private SPControladoraDatos.dsSpxTableAdapters.comprobantesAceptacionOrdenservicioTableAdapter comprobantesAceptacionOrdenservicioTableAdapter1;
        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.tipoComprobanteTableAdapter tipoComprobanteTableAdapter1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}