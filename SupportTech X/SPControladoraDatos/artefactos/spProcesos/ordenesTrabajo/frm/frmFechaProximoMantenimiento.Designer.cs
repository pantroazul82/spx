namespace spProcesos.ordenesTrabajo.frm
{
    partial class frmFechaProximoMantenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFechaProximoMantenimiento));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.calProximoMantenimiento = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lblSugerido = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.nmDias = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.nmMeses = new System.Windows.Forms.NumericUpDown();
            this.calSugerido = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.calDentroDe = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.rdEstimado = new System.Windows.Forms.RadioButton();
            this.rdActual = new System.Windows.Forms.RadioButton();
            this.rdSugerido = new System.Windows.Forms.RadioButton();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.defaultsTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter();
            this.modelosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter();
            this.equiposTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter();
            this.rdNinguna = new System.Windows.Forms.RadioButton();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMeses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(282, 205);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(374, 205);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // calProximoMantenimiento
            // 
            // 
            // 
            // 
            this.calProximoMantenimiento.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calProximoMantenimiento.ButtonDropDown.Visible = true;
            this.calProximoMantenimiento.Location = new System.Drawing.Point(233, 30);
            // 
            // 
            // 
            this.calProximoMantenimiento.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            this.calProximoMantenimiento.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calProximoMantenimiento.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calProximoMantenimiento.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calProximoMantenimiento.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calProximoMantenimiento.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calProximoMantenimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calProximoMantenimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calProximoMantenimiento.MonthCalendar.DisplayMonth = new System.DateTime(2008, 10, 1, 0, 0, 0, 0);
            this.calProximoMantenimiento.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calProximoMantenimiento.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calProximoMantenimiento.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calProximoMantenimiento.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calProximoMantenimiento.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calProximoMantenimiento.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calProximoMantenimiento.MonthCalendar.TodayButtonVisible = true;
            this.calProximoMantenimiento.Name = "calProximoMantenimiento";
            this.calProximoMantenimiento.Size = new System.Drawing.Size(200, 20);
            this.calProximoMantenimiento.TabIndex = 1;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.rdNinguna);
            this.groupPanel1.Controls.Add(this.lblSugerido);
            this.groupPanel1.Controls.Add(this.label13);
            this.groupPanel1.Controls.Add(this.btnAceptar);
            this.groupPanel1.Controls.Add(this.nmDias);
            this.groupPanel1.Controls.Add(this.label12);
            this.groupPanel1.Controls.Add(this.btnCancelar);
            this.groupPanel1.Controls.Add(this.nmMeses);
            this.groupPanel1.Controls.Add(this.calSugerido);
            this.groupPanel1.Controls.Add(this.calDentroDe);
            this.groupPanel1.Controls.Add(this.calProximoMantenimiento);
            this.groupPanel1.Controls.Add(this.rdEstimado);
            this.groupPanel1.Controls.Add(this.rdActual);
            this.groupPanel1.Controls.Add(this.rdSugerido);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(464, 237);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 3;
            // 
            // lblSugerido
            // 
            this.lblSugerido.BackColor = System.Drawing.Color.White;
            this.lblSugerido.Location = new System.Drawing.Point(234, 91);
            this.lblSugerido.Name = "lblSugerido";
            this.lblSugerido.Size = new System.Drawing.Size(202, 16);
            this.lblSugerido.TabIndex = 14;
            this.lblSugerido.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(289, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Dias";
            // 
            // nmDias
            // 
            this.nmDias.Location = new System.Drawing.Point(235, 123);
            this.nmDias.Name = "nmDias";
            this.nmDias.Size = new System.Drawing.Size(48, 20);
            this.nmDias.TabIndex = 6;
            this.nmDias.ValueChanged += new System.EventHandler(this.nmDias_ValueChanged);
            this.nmDias.Click += new System.EventHandler(this.nmDias_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(377, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Meses";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nmMeses
            // 
            this.nmMeses.Location = new System.Drawing.Point(323, 123);
            this.nmMeses.Name = "nmMeses";
            this.nmMeses.Size = new System.Drawing.Size(48, 20);
            this.nmMeses.TabIndex = 5;
            this.nmMeses.ValueChanged += new System.EventHandler(this.nmMeses_ValueChanged);
            this.nmMeses.Click += new System.EventHandler(this.nmMeses_Click);
            // 
            // calSugerido
            // 
            // 
            // 
            // 
            this.calSugerido.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calSugerido.ButtonDropDown.Visible = true;
            this.calSugerido.Location = new System.Drawing.Point(233, 67);
            // 
            // 
            // 
            this.calSugerido.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            this.calSugerido.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calSugerido.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calSugerido.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calSugerido.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calSugerido.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calSugerido.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calSugerido.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calSugerido.MonthCalendar.DisplayMonth = new System.DateTime(2008, 10, 1, 0, 0, 0, 0);
            this.calSugerido.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calSugerido.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calSugerido.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calSugerido.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calSugerido.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calSugerido.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calSugerido.MonthCalendar.TodayButtonVisible = true;
            this.calSugerido.Name = "calSugerido";
            this.calSugerido.Size = new System.Drawing.Size(200, 20);
            this.calSugerido.TabIndex = 3;
            // 
            // calDentroDe
            // 
            // 
            // 
            // 
            this.calDentroDe.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calDentroDe.ButtonDropDown.Visible = true;
            this.calDentroDe.Location = new System.Drawing.Point(233, 147);
            // 
            // 
            // 
            this.calDentroDe.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            this.calDentroDe.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calDentroDe.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calDentroDe.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calDentroDe.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calDentroDe.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calDentroDe.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calDentroDe.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calDentroDe.MonthCalendar.DisplayMonth = new System.DateTime(2008, 10, 1, 0, 0, 0, 0);
            this.calDentroDe.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calDentroDe.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calDentroDe.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calDentroDe.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calDentroDe.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calDentroDe.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calDentroDe.MonthCalendar.TodayButtonVisible = true;
            this.calDentroDe.Name = "calDentroDe";
            this.calDentroDe.Size = new System.Drawing.Size(200, 20);
            this.calDentroDe.TabIndex = 7;
            this.calDentroDe.ValueChanged += new System.EventHandler(this.calDentroDe_ValueChanged);
            this.calDentroDe.Click += new System.EventHandler(this.calDentroDe_Click);
            // 
            // rdEstimado
            // 
            this.rdEstimado.AutoSize = true;
            this.rdEstimado.BackColor = System.Drawing.Color.Transparent;
            this.rdEstimado.Location = new System.Drawing.Point(20, 122);
            this.rdEstimado.Name = "rdEstimado";
            this.rdEstimado.Size = new System.Drawing.Size(174, 17);
            this.rdEstimado.TabIndex = 4;
            this.rdEstimado.TabStop = true;
            this.rdEstimado.Text = "En la Siguiente Fecha estimada";
            this.rdEstimado.UseVisualStyleBackColor = false;
            // 
            // rdActual
            // 
            this.rdActual.AutoSize = true;
            this.rdActual.BackColor = System.Drawing.Color.Transparent;
            this.rdActual.Location = new System.Drawing.Point(20, 30);
            this.rdActual.Name = "rdActual";
            this.rdActual.Size = new System.Drawing.Size(194, 17);
            this.rdActual.TabIndex = 0;
            this.rdActual.TabStop = true;
            this.rdActual.Text = "Proximo Mantenimiento Programado";
            this.rdActual.UseVisualStyleBackColor = false;
            // 
            // rdSugerido
            // 
            this.rdSugerido.AutoSize = true;
            this.rdSugerido.BackColor = System.Drawing.Color.Transparent;
            this.rdSugerido.Location = new System.Drawing.Point(20, 70);
            this.rdSugerido.Name = "rdSugerido";
            this.rdSugerido.Size = new System.Drawing.Size(67, 17);
            this.rdSugerido.TabIndex = 2;
            this.rdSugerido.TabStop = true;
            this.rdSugerido.Text = "Sugerido";
            this.rdSugerido.UseVisualStyleBackColor = false;
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // defaultsTableAdapter1
            // 
            this.defaultsTableAdapter1.ClearBeforeFill = true;
            // 
            // modelosTableAdapter1
            // 
            this.modelosTableAdapter1.ClearBeforeFill = true;
            // 
            // equiposTableAdapter1
            // 
            this.equiposTableAdapter1.ClearBeforeFill = true;
            // 
            // rdNinguna
            // 
            this.rdNinguna.AutoSize = true;
            this.rdNinguna.BackColor = System.Drawing.Color.Transparent;
            this.rdNinguna.Location = new System.Drawing.Point(20, 174);
            this.rdNinguna.Name = "rdNinguna";
            this.rdNinguna.Size = new System.Drawing.Size(216, 17);
            this.rdNinguna.TabIndex = 15;
            this.rdNinguna.TabStop = true;
            this.rdNinguna.Text = "No Programar un Proximo mantenimiento";
            this.rdNinguna.UseVisualStyleBackColor = false;
            // 
            // frmFechaProximoMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 237);
            this.Controls.Add(this.groupPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFechaProximoMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fecha Proximo Mantenimiento";
            this.Load += new System.EventHandler(this.frmFechaProximoMantenimiento_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMeses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calProximoMantenimiento;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter defaultsTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter modelosTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter equiposTableAdapter1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calSugerido;
        private System.Windows.Forms.RadioButton rdActual;
        private System.Windows.Forms.RadioButton rdSugerido;
        private System.Windows.Forms.RadioButton rdEstimado;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calDentroDe;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nmDias;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nmMeses;
        private System.Windows.Forms.Label lblSugerido;
        private System.Windows.Forms.RadioButton rdNinguna;
    }
}