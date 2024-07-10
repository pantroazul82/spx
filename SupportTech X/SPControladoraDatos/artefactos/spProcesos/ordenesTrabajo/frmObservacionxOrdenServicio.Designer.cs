namespace spProcesos.programacion
{
    partial class frmObservacionxOrdenServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmObservacionxOrdenServicio));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.calActividad = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblIng = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbIngeniero = new System.Windows.Forms.ComboBox();
            this.dsSPXSeguridad1 = new SPXSeguridad.data.dsSPXSeguridad();
            this.label2 = new System.Windows.Forms.Label();
            this.actividadxordenServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.actividadxordenServicioTableAdapter();
            this.clsTusuario1 = new SPXSeguridad.data.cls.clsTusuario();
            this.chkConfidencial = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calActividad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(355, 10);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(436, 10);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha de Actividad";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.Location = new System.Drawing.Point(15, 161);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacion.Size = new System.Drawing.Size(496, 170);
            this.txtObservacion.TabIndex = 3;
            // 
            // calActividad
            // 
            // 
            // 
            // 
            this.calActividad.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calActividad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calActividad.ButtonDropDown.Visible = true;
            this.calActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calActividad.Location = new System.Drawing.Point(152, 18);
            // 
            // 
            // 
            this.calActividad.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calActividad.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calActividad.MonthCalendar.BackgroundStyle.Class = "";
            this.calActividad.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calActividad.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calActividad.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calActividad.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calActividad.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calActividad.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calActividad.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calActividad.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calActividad.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calActividad.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calActividad.MonthCalendar.DisplayMonth = new System.DateTime(2008, 4, 1, 0, 0, 0, 0);
            this.calActividad.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calActividad.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calActividad.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calActividad.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calActividad.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calActividad.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calActividad.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calActividad.MonthCalendar.TodayButtonVisible = true;
            this.calActividad.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calActividad.Name = "calActividad";
            this.calActividad.Size = new System.Drawing.Size(200, 23);
            this.calActividad.TabIndex = 4;
            this.calActividad.Click += new System.EventHandler(this.calActividad_Click);
            // 
            // lblIng
            // 
            this.lblIng.BackColor = System.Drawing.Color.White;
            this.lblIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIng.Location = new System.Drawing.Point(12, 89);
            this.lblIng.Name = "lblIng";
            this.lblIng.Size = new System.Drawing.Size(340, 24);
            this.lblIng.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingeniero";
            // 
            // cmbIngeniero
            // 
            this.cmbIngeniero.DataSource = this.dsSPXSeguridad1;
            this.cmbIngeniero.DisplayMember = "usuario.nombre";
            this.cmbIngeniero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIngeniero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIngeniero.FormattingEnabled = true;
            this.cmbIngeniero.Location = new System.Drawing.Point(152, 56);
            this.cmbIngeniero.Name = "cmbIngeniero";
            this.cmbIngeniero.Size = new System.Drawing.Size(200, 24);
            this.cmbIngeniero.TabIndex = 7;
            this.cmbIngeniero.ValueMember = "usuario.login";
            this.cmbIngeniero.SelectedIndexChanged += new System.EventHandler(this.cmbIngeniero_SelectedIndexChanged);
            // 
            // dsSPXSeguridad1
            // 
            this.dsSPXSeguridad1.DataSetName = "dsSPXSeguridad";
            this.dsSPXSeguridad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Observacion";
            // 
            // actividadxordenServicioTableAdapter1
            // 
            this.actividadxordenServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // clsTusuario1
            // 
            this.clsTusuario1.nombreLlave = "cod_usuario";
            this.clsTusuario1.nombreTabla = "usuario";
            this.clsTusuario1.sentenciaBase = resources.GetString("clsTusuario1.sentenciaBase");
            this.clsTusuario1.sentenciaBaseDistinct = resources.GetString("clsTusuario1.sentenciaBaseDistinct");
            // 
            // chkConfidencial
            // 
            this.chkConfidencial.AutoSize = true;
            this.chkConfidencial.Location = new System.Drawing.Point(265, 130);
            this.chkConfidencial.Name = "chkConfidencial";
            this.chkConfidencial.Size = new System.Drawing.Size(84, 17);
            this.chkConfidencial.TabIndex = 9;
            this.chkConfidencial.Text = "Confidencial";
            this.chkConfidencial.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 348);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 45);
            this.panel1.TabIndex = 10;
            // 
            // frmObservacionxOrdenServicio
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(523, 393);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkConfidencial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbIngeniero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblIng);
            this.Controls.Add(this.calActividad);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmObservacionxOrdenServicio";
            this.Text = "Actividades de Orden de Servicio";
            this.Load += new System.EventHandler(this.frmObservacionxOrdenServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calActividad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private SPControladoraDatos.dsSpx dsSpx1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtObservacion;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calActividad;
        private System.Windows.Forms.Label lblIng;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbIngeniero;
        private System.Windows.Forms.Label label2;
        private SPControladoraDatos.dsSpxTableAdapters.actividadxordenServicioTableAdapter actividadxordenServicioTableAdapter1;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad1;
        private SPXSeguridad.data.cls.clsTusuario clsTusuario1;
        private System.Windows.Forms.CheckBox chkConfidencial;
        private System.Windows.Forms.Panel panel1;
    }
}