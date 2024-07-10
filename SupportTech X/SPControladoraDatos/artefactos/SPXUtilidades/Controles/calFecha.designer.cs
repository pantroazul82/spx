namespace SPControladoraDatos.artefactos.SPXUtilidades.Controles
{
    partial class calFecha
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmbHoras = new System.Windows.Forms.ComboBox();
            this.cmbMinutos = new System.Windows.Forms.ComboBox();
            this.cmbAmPm = new System.Windows.Forms.ComboBox();
            this.calendario = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            ((System.ComponentModel.ISupportInitialize)(this.calendario)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbHoras
            // 
            this.cmbHoras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbHoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoras.FormattingEnabled = true;
            this.cmbHoras.Items.AddRange(new object[] {
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
            this.cmbHoras.Location = new System.Drawing.Point(127, 0);
            this.cmbHoras.Name = "cmbHoras";
            this.cmbHoras.Size = new System.Drawing.Size(39, 21);
            this.cmbHoras.TabIndex = 1;
            // 
            // cmbMinutos
            // 
            this.cmbMinutos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMinutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMinutos.FormattingEnabled = true;
            this.cmbMinutos.Items.AddRange(new object[] {
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
            this.cmbMinutos.Location = new System.Drawing.Point(170, 0);
            this.cmbMinutos.Name = "cmbMinutos";
            this.cmbMinutos.Size = new System.Drawing.Size(39, 21);
            this.cmbMinutos.TabIndex = 2;
            // 
            // cmbAmPm
            // 
            this.cmbAmPm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAmPm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAmPm.FormattingEnabled = true;
            this.cmbAmPm.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cmbAmPm.Location = new System.Drawing.Point(213, 0);
            this.cmbAmPm.Name = "cmbAmPm";
            this.cmbAmPm.Size = new System.Drawing.Size(39, 21);
            this.cmbAmPm.TabIndex = 3;
            // 
            // calendario
            // 
            this.calendario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.calendario.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calendario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calendario.ButtonDropDown.Visible = true;
            this.calendario.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.calendario.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calendario.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calendario.MonthCalendar.BackgroundStyle.Class = "";
            this.calendario.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calendario.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calendario.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calendario.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calendario.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calendario.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calendario.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calendario.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calendario.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calendario.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calendario.MonthCalendar.DisplayMonth = new System.DateTime(2009, 1, 1, 0, 0, 0, 0);
            this.calendario.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calendario.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calendario.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calendario.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calendario.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calendario.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calendario.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calendario.MonthCalendar.TodayButtonVisible = true;
            this.calendario.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calendario.Name = "calendario";
            this.calendario.Size = new System.Drawing.Size(124, 20);
            this.calendario.TabIndex = 4;
            this.calendario.ValueObjectChanged += new System.EventHandler(this.calendario_ValueObjectChanged);
            // 
            // calFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.cmbAmPm);
            this.Controls.Add(this.cmbMinutos);
            this.Controls.Add(this.cmbHoras);
            this.Name = "calFecha";
            this.Size = new System.Drawing.Size(252, 21);
            this.Load += new System.EventHandler(this.calFecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calendario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cmbHoras;
        private System.Windows.Forms.ComboBox cmbMinutos;
        private System.Windows.Forms.ComboBox cmbAmPm;
        protected DevComponents.Editors.DateTimeAdv.DateTimeInput calendario;


    }
}
