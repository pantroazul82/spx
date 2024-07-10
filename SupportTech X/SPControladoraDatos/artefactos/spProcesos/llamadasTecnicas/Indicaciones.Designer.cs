namespace spProcesos.llamadasTecnicas
{
    partial class Indicaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Indicaciones));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIndicaciones = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.indicacionesLLamadasTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.indicacionesLLamadasTableAdapter();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calCreacion = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.calIndicacion = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calCreacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calIndicacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(528, 14);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(609, 14);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Indicaciones Dadas al Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Observaciones";
            // 
            // txtIndicaciones
            // 
            this.txtIndicaciones.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndicaciones.Location = new System.Drawing.Point(6, 87);
            this.txtIndicaciones.Multiline = true;
            this.txtIndicaciones.Name = "txtIndicaciones";
            this.txtIndicaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIndicaciones.Size = new System.Drawing.Size(679, 117);
            this.txtIndicaciones.TabIndex = 0;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(6, 237);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(679, 102);
            this.txtObservaciones.TabIndex = 1;
            // 
            // indicacionesLLamadasTableAdapter1
            // 
            this.indicacionesLLamadasTableAdapter1.ClearBeforeFill = true;
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 49);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha Creacion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha Indicacion:";
            // 
            // calCreacion
            // 
            // 
            // 
            // 
            this.calCreacion.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calCreacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calCreacion.ButtonDropDown.Visible = true;
            this.calCreacion.Enabled = false;
            this.calCreacion.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calCreacion.Location = new System.Drawing.Point(113, 7);
            // 
            // 
            // 
            this.calCreacion.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calCreacion.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calCreacion.MonthCalendar.BackgroundStyle.Class = "";
            this.calCreacion.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calCreacion.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calCreacion.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calCreacion.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calCreacion.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calCreacion.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calCreacion.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calCreacion.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calCreacion.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calCreacion.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calCreacion.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.calCreacion.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calCreacion.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calCreacion.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calCreacion.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calCreacion.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calCreacion.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calCreacion.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calCreacion.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calCreacion.MonthCalendar.TodayButtonVisible = true;
            this.calCreacion.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calCreacion.Name = "calCreacion";
            this.calCreacion.Size = new System.Drawing.Size(200, 24);
            this.calCreacion.TabIndex = 8;
            // 
            // calIndicacion
            // 
            // 
            // 
            // 
            this.calIndicacion.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calIndicacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calIndicacion.ButtonDropDown.Visible = true;
            this.calIndicacion.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calIndicacion.Location = new System.Drawing.Point(113, 37);
            // 
            // 
            // 
            this.calIndicacion.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calIndicacion.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calIndicacion.MonthCalendar.BackgroundStyle.Class = "";
            this.calIndicacion.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calIndicacion.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calIndicacion.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calIndicacion.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calIndicacion.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calIndicacion.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calIndicacion.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calIndicacion.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calIndicacion.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calIndicacion.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calIndicacion.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.calIndicacion.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calIndicacion.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calIndicacion.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calIndicacion.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calIndicacion.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calIndicacion.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calIndicacion.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calIndicacion.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calIndicacion.MonthCalendar.TodayButtonVisible = true;
            this.calIndicacion.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calIndicacion.Name = "calIndicacion";
            this.calIndicacion.Size = new System.Drawing.Size(200, 24);
            this.calIndicacion.TabIndex = 9;
            // 
            // Indicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(697, 404);
            this.ControlBox = false;
            this.Controls.Add(this.calIndicacion);
            this.Controls.Add(this.calCreacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtIndicaciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Indicaciones";
            this.Text = "Indicaciones";
            this.Load += new System.EventHandler(this.Indicaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calCreacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calIndicacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIndicaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private SPControladoraDatos.dsSpxTableAdapters.indicacionesLLamadasTableAdapter indicacionesLLamadasTableAdapter1;
        private SPControladoraDatos.dsSpx dsSpx1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calCreacion;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calIndicacion;
    }
}