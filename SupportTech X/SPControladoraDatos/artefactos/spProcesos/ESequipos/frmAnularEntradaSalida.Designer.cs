namespace spProcesos.ESequipos
{
    partial class frmAnularEntradaSalida
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnuladaPor = new System.Windows.Forms.TextBox();
            this.txtObsAnulacion = new System.Windows.Forms.TextBox();
            this.calAnulacion = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.entradaSalidaEquiposTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.EntradaSalidaEquiposTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calAnulacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(411, 7);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(330, 7);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 39);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Anulada por";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha de Anulacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Observaciones de Anulacion";
            // 
            // txtAnuladaPor
            // 
            this.txtAnuladaPor.Enabled = false;
            this.txtAnuladaPor.Location = new System.Drawing.Point(83, 12);
            this.txtAnuladaPor.Name = "txtAnuladaPor";
            this.txtAnuladaPor.Size = new System.Drawing.Size(194, 20);
            this.txtAnuladaPor.TabIndex = 0;
            // 
            // txtObsAnulacion
            // 
            this.txtObsAnulacion.Location = new System.Drawing.Point(16, 89);
            this.txtObsAnulacion.Multiline = true;
            this.txtObsAnulacion.Name = "txtObsAnulacion";
            this.txtObsAnulacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObsAnulacion.Size = new System.Drawing.Size(470, 85);
            this.txtObsAnulacion.TabIndex = 2;
            // 
            // calAnulacion
            // 
            // 
            // 
            // 
            this.calAnulacion.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calAnulacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calAnulacion.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.calAnulacion.ButtonDropDown.Visible = true;
            this.calAnulacion.Enabled = false;
            this.calAnulacion.Location = new System.Drawing.Point(391, 15);
            // 
            // 
            // 
            this.calAnulacion.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calAnulacion.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calAnulacion.MonthCalendar.BackgroundStyle.Class = "";
            this.calAnulacion.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calAnulacion.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calAnulacion.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calAnulacion.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calAnulacion.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calAnulacion.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calAnulacion.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calAnulacion.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calAnulacion.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calAnulacion.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calAnulacion.MonthCalendar.DisplayMonth = new System.DateTime(2012, 5, 1, 0, 0, 0, 0);
            this.calAnulacion.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calAnulacion.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calAnulacion.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calAnulacion.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calAnulacion.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calAnulacion.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calAnulacion.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calAnulacion.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calAnulacion.MonthCalendar.TodayButtonVisible = true;
            this.calAnulacion.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calAnulacion.Name = "calAnulacion";
            this.calAnulacion.Size = new System.Drawing.Size(95, 20);
            this.calAnulacion.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.calAnulacion.TabIndex = 1;
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entradaSalidaEquiposTableAdapter1
            // 
            this.entradaSalidaEquiposTableAdapter1.ClearBeforeFill = true;
            // 
            // frmAnularEntradaSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(498, 235);
            this.Controls.Add(this.calAnulacion);
            this.Controls.Add(this.txtObsAnulacion);
            this.Controls.Add(this.txtAnuladaPor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAnularEntradaSalida";
            this.Text = "Anular Entrada Salida";
            this.Load += new System.EventHandler(this.frmAnularEntradaSalida_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calAnulacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAnuladaPor;
        private System.Windows.Forms.TextBox txtObsAnulacion;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calAnulacion;
        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.EntradaSalidaEquiposTableAdapter entradaSalidaEquiposTableAdapter1;
    }
}