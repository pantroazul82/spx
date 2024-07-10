namespace spProcesos.ordenesTrabajo.frm
{
    partial class frmSeleccionarOrdenParaInsumo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeleccionarOrdenParaInsumo));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModalidad = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInfEquipo = new DevComponents.DotNetBar.ButtonX();
            this.btnBuscarSerial = new DevComponents.DotNetBar.ButtonX();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.equiposTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter();
            this.fabricanteTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.fabricanteTableAdapter();
            this.modelosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter();
            this.modalidadEquipoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ModalidadEquipoTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dsPlantillas1 = new SPControladoraDatos.dsPlantillas();
            this.grdDatos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.cmbTop = new System.Windows.Forms.ComboBox();
            this.btnGenerarSolicitudInsumos = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.cmbTop);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnInfEquipo);
            this.groupBox3.Controls.Add(this.txtModalidad);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.btnBuscarSerial);
            this.groupBox3.Controls.Add(this.txtFabricante);
            this.groupBox3.Controls.Add(this.txtModelo);
            this.groupBox3.Controls.Add(this.txtSerial);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 169);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion del Equipo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(7, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "Serial";
            // 
            // txtModalidad
            // 
            this.txtModalidad.Location = new System.Drawing.Point(75, 103);
            this.txtModalidad.Name = "txtModalidad";
            this.txtModalidad.ReadOnly = true;
            this.txtModalidad.Size = new System.Drawing.Size(234, 21);
            this.txtModalidad.TabIndex = 30;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(7, 107);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(66, 15);
            this.label26.TabIndex = 31;
            this.label26.Text = "Modalidad";
            // 
            // txtFabricante
            // 
            this.txtFabricante.Location = new System.Drawing.Point(75, 49);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.ReadOnly = true;
            this.txtFabricante.Size = new System.Drawing.Size(234, 21);
            this.txtFabricante.TabIndex = 3;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(75, 76);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.ReadOnly = true;
            this.txtModelo.Size = new System.Drawing.Size(234, 21);
            this.txtModelo.TabIndex = 4;
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(75, 24);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(234, 21);
            this.txtSerial.TabIndex = 0;
            this.txtSerial.DoubleClick += new System.EventHandler(this.txtSerial_DoubleClick);
            this.txtSerial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSerial_KeyDown);
            this.txtSerial.Validating += new System.ComponentModel.CancelEventHandler(this.txtSerial_Validating);
            this.txtSerial.Validated += new System.EventHandler(this.txtSerial_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Modelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fabricante";
            // 
            // btnInfEquipo
            // 
            this.btnInfEquipo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInfEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfEquipo.Image")));
            this.btnInfEquipo.ImageFixedSize = new System.Drawing.Size(29, 29);
            this.btnInfEquipo.Location = new System.Drawing.Point(350, 16);
            this.btnInfEquipo.Name = "btnInfEquipo";
            this.btnInfEquipo.Size = new System.Drawing.Size(33, 33);
            this.btnInfEquipo.TabIndex = 67;
            this.btnInfEquipo.Click += new System.EventHandler(this.btnInfEquipo_Click);
            // 
            // btnBuscarSerial
            // 
            this.btnBuscarSerial.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscarSerial.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarSerial.Image")));
            this.btnBuscarSerial.ImageFixedSize = new System.Drawing.Size(29, 29);
            this.btnBuscarSerial.Location = new System.Drawing.Point(315, 16);
            this.btnBuscarSerial.Name = "btnBuscarSerial";
            this.btnBuscarSerial.Size = new System.Drawing.Size(33, 33);
            this.btnBuscarSerial.TabIndex = 29;
            this.btnBuscarSerial.Click += new System.EventHandler(this.btnBuscarSerial_Click);
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.EnforceConstraints = false;
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equiposTableAdapter1
            // 
            this.equiposTableAdapter1.ClearBeforeFill = true;
            // 
            // fabricanteTableAdapter1
            // 
            this.fabricanteTableAdapter1.ClearBeforeFill = true;
            // 
            // modelosTableAdapter1
            // 
            this.modelosTableAdapter1.ClearBeforeFill = true;
            // 
            // modalidadEquipoTableAdapter1
            // 
            this.modalidadEquipoTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 68;
            this.button1.Text = "Traer Ordenes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dsPlantillas1
            // 
            this.dsPlantillas1.DataSetName = "dsPlantillas";
            this.dsPlantillas1.EnforceConstraints = false;
            this.dsPlantillas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUpdate = false;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.DataMember = "pltListadoOrdenServicio";
            this.grdDatos.DataSource = this.dsPlantillas1;
            this.grdDatos.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy;
            this.grdDatos.FilterBar = true;
            this.grdDatos.GroupByAreaVisible = false;
            this.grdDatos.GroupByCaption = "";
            this.grdDatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDatos.Images"))));
            this.grdDatos.Location = new System.Drawing.Point(12, 187);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75D;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(547, 258);
            this.grdDatos.TabIndex = 63;
            this.grdDatos.Text = "c1TrueDBGrid1";
            this.grdDatos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
            // 
            // cmbTop
            // 
            this.cmbTop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTop.FormattingEnabled = true;
            this.cmbTop.Items.AddRange(new object[] {
            "10",
            "50",
            "100",
            "500",
            "1000",
            "10000",
            "10000"});
            this.cmbTop.Location = new System.Drawing.Point(10, 140);
            this.cmbTop.Name = "cmbTop";
            this.cmbTop.Size = new System.Drawing.Size(121, 23);
            this.cmbTop.TabIndex = 69;
            // 
            // btnGenerarSolicitudInsumos
            // 
            this.btnGenerarSolicitudInsumos.Location = new System.Drawing.Point(405, 152);
            this.btnGenerarSolicitudInsumos.Name = "btnGenerarSolicitudInsumos";
            this.btnGenerarSolicitudInsumos.Size = new System.Drawing.Size(154, 23);
            this.btnGenerarSolicitudInsumos.TabIndex = 64;
            this.btnGenerarSolicitudInsumos.Text = "Generar Solicitud Insumos";
            this.btnGenerarSolicitudInsumos.UseVisualStyleBackColor = true;
            this.btnGenerarSolicitudInsumos.Click += new System.EventHandler(this.btnGenerarSolicitudInsumos_Click);
            // 
            // frmSeleccionarOrdenParaInsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 444);
            this.Controls.Add(this.btnGenerarSolicitudInsumos);
            this.Controls.Add(this.grdDatos);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmSeleccionarOrdenParaInsumo";
            this.Text = "frmSeleccionarOrdenParaInsumo";
            this.Load += new System.EventHandler(this.frmSeleccionarOrdenParaInsumo_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private DevComponents.DotNetBar.ButtonX btnInfEquipo;
        private System.Windows.Forms.TextBox txtModalidad;
        private System.Windows.Forms.Label label26;
        private DevComponents.DotNetBar.ButtonX btnBuscarSerial;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter equiposTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.fabricanteTableAdapter fabricanteTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter modelosTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.ModalidadEquipoTableAdapter modalidadEquipoTableAdapter1;
        private System.Windows.Forms.Button button1;
        private SPControladoraDatos.dsPlantillas dsPlantillas1;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdDatos;
        private System.Windows.Forms.ComboBox cmbTop;
        private System.Windows.Forms.Button btnGenerarSolicitudInsumos;
    }
}