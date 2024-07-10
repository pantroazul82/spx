namespace spProcesos.ordenesTrabajo.frm
{
    partial class frmDisponibilidad
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
            this.components = new System.ComponentModel.Container();
            C1.C1Schedule.Printing.PrintStyle printStyle1 = new C1.C1Schedule.Printing.PrintStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDisponibilidad));
            C1.C1Schedule.Printing.PrintStyle printStyle2 = new C1.C1Schedule.Printing.PrintStyle();
            C1.C1Schedule.Printing.PrintStyle printStyle3 = new C1.C1Schedule.Printing.PrintStyle();
            C1.C1Schedule.Printing.PrintStyle printStyle4 = new C1.C1Schedule.Printing.PrintStyle();
            C1.C1Schedule.Printing.PrintStyle printStyle5 = new C1.C1Schedule.Printing.PrintStyle();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.pltOrdenServicioSchedulleTableAdapter1 = new SPControladoraDatos.dsPlantillasTableAdapters.pltOrdenServicioSchedulleTableAdapter();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dsPlantillas1 = new SPControladoraDatos.dsPlantillas();
            this.lblIngeniero = new System.Windows.Forms.Label();
            this.calendario = new C1.Win.C1Schedule.C1Schedule();
            this.cmbIngeniero = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.clsTusuario1 = new SPXSeguridad.data.cls.clsTusuario();
            this.dsSPXSeguridad1 = new SPXSeguridad.data.dsSPXSeguridad();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).BeginInit();
            this.SuspendLayout();
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pltOrdenServicioSchedulleTableAdapter1
            // 
            this.pltOrdenServicioSchedulleTableAdapter1.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // dsPlantillas1
            // 
            this.dsPlantillas1.DataSetName = "dsPlantillas";
            this.dsPlantillas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblIngeniero
            // 
            this.lblIngeniero.AutoSize = true;
            this.lblIngeniero.BackColor = System.Drawing.Color.Transparent;
            this.lblIngeniero.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngeniero.Location = new System.Drawing.Point(12, 9);
            this.lblIngeniero.Name = "lblIngeniero";
            this.lblIngeniero.Size = new System.Drawing.Size(74, 19);
            this.lblIngeniero.TabIndex = 38;
            this.lblIngeniero.Text = "Ingeniero";
            // 
            // calendario
            // 
            // 
            // 
            // 
            this.calendario.CalendarInfo.CultureInfo = new System.Globalization.CultureInfo("es-CO");
            this.calendario.CalendarInfo.DateFormatString = "dd/MM/yyyy";
            this.calendario.CalendarInfo.EndDayTime = System.TimeSpan.Parse("19:00:00");
            this.calendario.CalendarInfo.FirstDate = new System.DateTime(2008, 9, 10, 0, 0, 0, 0);
            this.calendario.CalendarInfo.LastDate = new System.DateTime(2057, 1, 5, 0, 0, 0, 0);
            this.calendario.CalendarInfo.StartDayTime = System.TimeSpan.Parse("07:00:00");
            this.calendario.CalendarInfo.TimeInterval = C1.C1Schedule.TimeScaleEnum.OneHour;
            this.calendario.CalendarInfo.TimeScale = System.TimeSpan.Parse("01:00:00");
            this.calendario.CalendarInfo.WeekStart = System.DayOfWeek.Sunday;
            this.calendario.CalendarInfo.WorkDays.AddRange(new System.DayOfWeek[] {
            System.DayOfWeek.Monday,
            System.DayOfWeek.Tuesday,
            System.DayOfWeek.Wednesday,
            System.DayOfWeek.Thursday,
            System.DayOfWeek.Friday});
            this.calendario.ContextMenuStrip = this.contextMenuStrip1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.calendario.DataStorage.AppointmentStorage.DataMember = "pltOrdenServicioSchedulle";
            this.calendario.DataStorage.AppointmentStorage.DataSource = this.dsPlantillas1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.calendario.DataStorage.AppointmentStorage.Mappings.Body.MappingName = "cuerpo";
            // 
            // 
            // 
            this.calendario.DataStorage.AppointmentStorage.Mappings.End.MappingName = "fechaFinProgramacion";
            // 
            // 
            // 
            this.calendario.DataStorage.AppointmentStorage.Mappings.IndexMapping.MappingName = "codOrdenServicio";
            // 
            // 
            // 
            this.calendario.DataStorage.AppointmentStorage.Mappings.Location.MappingName = "ubicacion";
            // 
            // 
            // 
            this.calendario.DataStorage.AppointmentStorage.Mappings.Start.MappingName = "fechaProgramacion";
            // 
            // 
            // 
            this.calendario.DataStorage.AppointmentStorage.Mappings.Subject.MappingName = "asunto";
            // 
            // 
            // 
            this.calendario.DataStorage.StatusStorage.DataMember = "estadosOrdenServicio";
            this.calendario.EditOptions = C1.Win.C1Schedule.EditOptions.None;
            this.calendario.FirstVisibleTime = System.TimeSpan.Parse("08:00:00");
            this.calendario.Location = new System.Drawing.Point(12, 39);
            this.calendario.Name = "calendario";
            printStyle1.Description = "Daily Style";
            printStyle1.PreviewImage = ((System.Drawing.Image)(resources.GetObject("printStyle1.PreviewImage")));
            printStyle1.StyleName = "Daily";
            printStyle1.StyleSource = "day.c1d";
            printStyle2.Description = "Weekly Style";
            printStyle2.PreviewImage = ((System.Drawing.Image)(resources.GetObject("printStyle2.PreviewImage")));
            printStyle2.StyleName = "Week";
            printStyle2.StyleSource = "week.c1d";
            printStyle3.Description = "Monthly Style";
            printStyle3.PreviewImage = ((System.Drawing.Image)(resources.GetObject("printStyle3.PreviewImage")));
            printStyle3.StyleName = "Month";
            printStyle3.StyleSource = "month.c1d";
            printStyle4.Description = "Details Style";
            printStyle4.PreviewImage = ((System.Drawing.Image)(resources.GetObject("printStyle4.PreviewImage")));
            printStyle4.StyleName = "Details";
            printStyle4.StyleSource = "details.c1d";
            printStyle5.Context = C1.C1Schedule.Printing.PrintContextType.Appointment;
            printStyle5.Description = "Memo Style";
            printStyle5.PreviewImage = ((System.Drawing.Image)(resources.GetObject("printStyle5.PreviewImage")));
            printStyle5.StyleName = "Memo";
            printStyle5.StyleSource = "memo.c1d";
            this.calendario.PrintInfo.PrintStyles.AddRange(new C1.C1Schedule.Printing.PrintStyle[] {
            printStyle1,
            printStyle2,
            printStyle3,
            printStyle4,
            printStyle5});
            this.calendario.ShowContextMenu = false;
            this.calendario.ShowReminderForm = false;
            this.calendario.Size = new System.Drawing.Size(640, 409);
            this.calendario.TabIndex = 36;
            this.calendario.VisualStyle = C1.Win.C1Schedule.UI.VisualStyle.Office2007Black;
            this.calendario.BeforeContextMenuShow += new System.EventHandler<C1.Win.C1Schedule.BeforeContextMenuShowEventArgs>(this.calendario_BeforeContextMenuShow);
            this.calendario.SelectedIntervalChanged += new System.EventHandler<C1.Win.C1Schedule.SelectedIntervalChangedEventArgs>(this.calendario_SelectedIntervalChanged);
            this.calendario.SelectedDaysChanged += new System.EventHandler(this.calendario_SelectedDaysChanged);
            this.calendario.BeforeAppointmentShow += new C1.C1Schedule.CancelAppointmentEventHandler(this.calendario_BeforeAppointmentShow);
            // 
            // cmbIngeniero
            // 
            this.cmbIngeniero.DataSource = this.dsSPXSeguridad1;
            this.cmbIngeniero.DisplayMember = "usuario.nombre";
            this.cmbIngeniero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIngeniero.FormattingEnabled = true;
            this.cmbIngeniero.Location = new System.Drawing.Point(322, 12);
            this.cmbIngeniero.Name = "cmbIngeniero";
            this.cmbIngeniero.Size = new System.Drawing.Size(330, 21);
            this.cmbIngeniero.TabIndex = 39;
            this.cmbIngeniero.ValueMember = "usuario.login";
            this.cmbIngeniero.SelectedIndexChanged += new System.EventHandler(this.cmbIngeniero_SelectedIndexChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(577, 454);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 40;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // clsTusuario1
            // 
            this.clsTusuario1.nombreLlave = "cod_usuario";
            this.clsTusuario1.nombreTabla = "usuario";
            this.clsTusuario1.sentenciaBase = resources.GetString("clsTusuario1.sentenciaBase");
            this.clsTusuario1.sentenciaBaseDistinct = resources.GetString("clsTusuario1.sentenciaBaseDistinct");
            // 
            // dsSPXSeguridad1
            // 
            this.dsSPXSeguridad1.DataSetName = "dsSPXSeguridad";
            this.dsSPXSeguridad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmDisponibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(660, 481);
            this.ControlBox = false;
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbIngeniero);
            this.Controls.Add(this.lblIngeniero);
            this.Controls.Add(this.calendario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDisponibilidad";
            this.Text = "Disponibilidad";
            this.Load += new System.EventHandler(this.frmDisponibilidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlantillas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsPlantillasTableAdapters.pltOrdenServicioSchedulleTableAdapter pltOrdenServicioSchedulleTableAdapter1;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private SPControladoraDatos.dsPlantillas dsPlantillas1;
        private System.Windows.Forms.Label lblIngeniero;
        private C1.Win.C1Schedule.C1Schedule calendario;
        private System.Windows.Forms.ComboBox cmbIngeniero;
        private System.Windows.Forms.Button btnAceptar;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad1;
        private SPXSeguridad.data.cls.clsTusuario clsTusuario1;
    }
}