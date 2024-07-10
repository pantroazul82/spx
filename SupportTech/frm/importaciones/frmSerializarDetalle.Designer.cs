namespace SupportTech.frm.importaciones
{
    partial class frmSerializarDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSerializarDetalle));
            this.txtBusquedaFabricante = new SPXUtilidades.Controles.txtBusqueda();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.txtBusquedaModelo = new SPXUtilidades.Controles.txtBusqueda();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calFechaIngreso = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dsFlujo1 = new SPXFlujo.Data.dsFlujo();
            this.detalle_movimientoTableAdapter1 = new SPXFlujo.Data.dsFlujoTableAdapters.detalle_movimientoTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.equiposTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter();
            this.estadoLocalEquiposTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.estadoLocalEquiposTableAdapter();
            this.modalidadEquipoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ModalidadEquipoTableAdapter();
            this.lblEstadoLocal = new System.Windows.Forms.Label();
            this.lblModalidad = new System.Windows.Forms.Label();
            this.cmbModalidad = new System.Windows.Forms.ComboBox();
            this.cmbEstadoLocalEquipos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaIngreso)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsFlujo1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusquedaFabricante
            // 
            this.txtBusquedaFabricante.codigo = "codFabricante";
            this.txtBusquedaFabricante.DataMember = this.dsSpx1.fabricante;
            this.txtBusquedaFabricante.DataSource = this.dsSpx1;
            this.txtBusquedaFabricante.descripcion1 = "nombre_fabricante";
            this.txtBusquedaFabricante.Enabled = false;
            this.txtBusquedaFabricante.filtroAdicional = null;
            this.txtBusquedaFabricante.LimiteY = 125;
            this.txtBusquedaFabricante.linkPadre = null;
            this.txtBusquedaFabricante.Location = new System.Drawing.Point(136, 29);
            this.txtBusquedaFabricante.Name = "txtBusquedaFabricante";
            this.txtBusquedaFabricante.sentenciaFromObligatoria = null;
            this.txtBusquedaFabricante.Size = new System.Drawing.Size(294, 22);
            this.txtBusquedaFabricante.TabIndex = 3;
            this.txtBusquedaFabricante.Tabla = this.dsSpx1.fabricante;
            this.txtBusquedaFabricante.TamanoPopUp = 5;
            this.txtBusquedaFabricante.txtPadre = null;
            this.txtBusquedaFabricante.Value = "0";
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBusquedaModelo
            // 
            this.txtBusquedaModelo.codigo = "codModelo";
            this.txtBusquedaModelo.DataMember = this.dsSpx1.Modelos;
            this.txtBusquedaModelo.DataSource = this.dsSpx1;
            this.txtBusquedaModelo.descripcion1 = "NombreModelo";
            this.txtBusquedaModelo.filtroAdicional = null;
            this.txtBusquedaModelo.LimiteY = 125;
            this.txtBusquedaModelo.linkPadre = null;
            this.txtBusquedaModelo.Location = new System.Drawing.Point(136, 60);
            this.txtBusquedaModelo.Name = "txtBusquedaModelo";
            this.txtBusquedaModelo.sentenciaFromObligatoria = null;
            this.txtBusquedaModelo.Size = new System.Drawing.Size(294, 22);
            this.txtBusquedaModelo.TabIndex = 0;
            this.txtBusquedaModelo.Tabla = this.dsSpx1.Modelos;
            this.txtBusquedaModelo.TamanoPopUp = 5;
            this.txtBusquedaModelo.txtPadre = null;
            this.txtBusquedaModelo.Value = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fabricante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de Ingreso";
            // 
            // calFechaIngreso
            // 
            // 
            // 
            // 
            this.calFechaIngreso.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calFechaIngreso.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaIngreso.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.calFechaIngreso.ButtonDropDown.Visible = true;
            this.calFechaIngreso.Location = new System.Drawing.Point(136, 92);
            // 
            // 
            // 
            this.calFechaIngreso.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFechaIngreso.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calFechaIngreso.MonthCalendar.BackgroundStyle.Class = "";
            this.calFechaIngreso.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaIngreso.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calFechaIngreso.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calFechaIngreso.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calFechaIngreso.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calFechaIngreso.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calFechaIngreso.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calFechaIngreso.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calFechaIngreso.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calFechaIngreso.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaIngreso.MonthCalendar.DisplayMonth = new System.DateTime(2011, 10, 1, 0, 0, 0, 0);
            this.calFechaIngreso.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calFechaIngreso.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFechaIngreso.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calFechaIngreso.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calFechaIngreso.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calFechaIngreso.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calFechaIngreso.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calFechaIngreso.MonthCalendar.TodayButtonVisible = true;
            this.calFechaIngreso.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calFechaIngreso.Name = "calFechaIngreso";
            this.calFechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.calFechaIngreso.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.calFechaIngreso.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 271);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 38);
            this.panel1.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(287, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 26);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(368, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 26);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dsFlujo1
            // 
            this.dsFlujo1.DataSetName = "dsFlujo";
            this.dsFlujo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detalle_movimientoTableAdapter1
            // 
            this.detalle_movimientoTableAdapter1.nombreLlave = "cod_detalle_movimiento";
            this.detalle_movimientoTableAdapter1.nombreTabla = "detalle_movimiento";
            this.detalle_movimientoTableAdapter1.sentenciaBase = resources.GetString("detalle_movimientoTableAdapter1.sentenciaBase");
            this.detalle_movimientoTableAdapter1.sentenciaBaseDistinct = resources.GetString("detalle_movimientoTableAdapter1.sentenciaBaseDistinct");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Serial";
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(136, 126);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(294, 20);
            this.txtSerial.TabIndex = 6;
            // 
            // equiposTableAdapter1
            // 
            this.equiposTableAdapter1.ClearBeforeFill = true;
            // 
            // estadoLocalEquiposTableAdapter1
            // 
            this.estadoLocalEquiposTableAdapter1.ClearBeforeFill = true;
            // 
            // modalidadEquipoTableAdapter1
            // 
            this.modalidadEquipoTableAdapter1.ClearBeforeFill = true;
            // 
            // lblEstadoLocal
            // 
            this.lblEstadoLocal.AutoSize = true;
            this.lblEstadoLocal.Location = new System.Drawing.Point(20, 167);
            this.lblEstadoLocal.Name = "lblEstadoLocal";
            this.lblEstadoLocal.Size = new System.Drawing.Size(110, 13);
            this.lblEstadoLocal.TabIndex = 8;
            this.lblEstadoLocal.Text = "Estado Local Equipos";
            // 
            // lblModalidad
            // 
            this.lblModalidad.AutoSize = true;
            this.lblModalidad.Location = new System.Drawing.Point(20, 200);
            this.lblModalidad.Name = "lblModalidad";
            this.lblModalidad.Size = new System.Drawing.Size(56, 13);
            this.lblModalidad.TabIndex = 7;
            this.lblModalidad.Text = "Modalidad";
            this.lblModalidad.Visible = false;
            // 
            // cmbModalidad
            // 
            this.cmbModalidad.DataSource = this.dsSpx1;
            this.cmbModalidad.DisplayMember = "ModalidadEquipo.nombreModalidadEquipo";
            this.cmbModalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModalidad.FormattingEnabled = true;
            this.cmbModalidad.Location = new System.Drawing.Point(136, 197);
            this.cmbModalidad.Name = "cmbModalidad";
            this.cmbModalidad.Size = new System.Drawing.Size(200, 21);
            this.cmbModalidad.TabIndex = 9;
            this.cmbModalidad.ValueMember = "ModalidadEquipo.codModalidadEquipo";
            this.cmbModalidad.Visible = false;
            // 
            // cmbEstadoLocalEquipos
            // 
            this.cmbEstadoLocalEquipos.DataSource = this.dsSpx1;
            this.cmbEstadoLocalEquipos.DisplayMember = "estadoLocalEquipos.nombreEstadoLocal";
            this.cmbEstadoLocalEquipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoLocalEquipos.FormattingEnabled = true;
            this.cmbEstadoLocalEquipos.Location = new System.Drawing.Point(136, 164);
            this.cmbEstadoLocalEquipos.Name = "cmbEstadoLocalEquipos";
            this.cmbEstadoLocalEquipos.Size = new System.Drawing.Size(200, 21);
            this.cmbEstadoLocalEquipos.TabIndex = 10;
            this.cmbEstadoLocalEquipos.ValueMember = "estadoLocalEquipos.codEstadoLocal";
            // 
            // frmSerializarDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(454, 309);
            this.Controls.Add(this.cmbEstadoLocalEquipos);
            this.Controls.Add(this.cmbModalidad);
            this.Controls.Add(this.lblEstadoLocal);
            this.Controls.Add(this.lblModalidad);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.calFechaIngreso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBusquedaModelo);
            this.Controls.Add(this.txtBusquedaFabricante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSerializarDetalle";
            this.Text = "Serializar Detalle";
            this.Load += new System.EventHandler(this.frmSerializarDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaIngreso)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsFlujo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SPXUtilidades.Controles.txtBusqueda txtBusquedaFabricante;
        private SPXUtilidades.Controles.txtBusqueda txtBusquedaModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private SPControladoraDatos.dsSpx dsSpx1;
        private System.Windows.Forms.Label label3;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calFechaIngreso;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private SPXFlujo.Data.dsFlujo dsFlujo1;
        private SPXFlujo.Data.dsFlujoTableAdapters.detalle_movimientoTableAdapter detalle_movimientoTableAdapter1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSerial;
        private SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter equiposTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.estadoLocalEquiposTableAdapter estadoLocalEquiposTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.ModalidadEquipoTableAdapter modalidadEquipoTableAdapter1;
        private System.Windows.Forms.Label lblEstadoLocal;
        private System.Windows.Forms.Label lblModalidad;
        private System.Windows.Forms.ComboBox cmbModalidad;
        private System.Windows.Forms.ComboBox cmbEstadoLocalEquipos;
    }
}