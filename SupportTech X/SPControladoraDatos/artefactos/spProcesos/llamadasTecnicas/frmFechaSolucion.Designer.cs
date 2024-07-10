namespace spProcesos.llamadasTecnicas
{
    partial class frmFechaSolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFechaSolucion));
            this.label1 = new System.Windows.Forms.Label();
            this.calSolucion = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbResultadoFinal = new System.Windows.Forms.ComboBox();
            this.resultado_final_llamadaTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.resultado_final_llamadaTableAdapter();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            ((System.ComponentModel.ISupportInitialize)(this.calSolucion)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la Fecha de Solucion";
            // 
            // calSolucion
            // 
            // 
            // 
            // 
            this.calSolucion.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calSolucion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calSolucion.ButtonDropDown.Visible = true;
            this.calSolucion.Location = new System.Drawing.Point(199, 79);
            // 
            // 
            // 
            this.calSolucion.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calSolucion.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calSolucion.MonthCalendar.BackgroundStyle.Class = "";
            this.calSolucion.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calSolucion.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calSolucion.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calSolucion.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calSolucion.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calSolucion.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calSolucion.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calSolucion.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calSolucion.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calSolucion.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calSolucion.MonthCalendar.DisplayMonth = new System.DateTime(2010, 7, 1, 0, 0, 0, 0);
            this.calSolucion.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calSolucion.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calSolucion.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calSolucion.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calSolucion.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calSolucion.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calSolucion.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calSolucion.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calSolucion.MonthCalendar.TodayButtonVisible = true;
            this.calSolucion.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calSolucion.Name = "calSolucion";
            this.calSolucion.Size = new System.Drawing.Size(200, 20);
            this.calSolucion.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.bnCancelar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 50);
            this.panel1.TabIndex = 2;
            // 
            // bnCancelar
            // 
            this.bnCancelar.Location = new System.Drawing.Point(324, 15);
            this.bnCancelar.Name = "bnCancelar";
            this.bnCancelar.Size = new System.Drawing.Size(75, 23);
            this.bnCancelar.TabIndex = 4;
            this.bnCancelar.Text = "Cancelar";
            this.bnCancelar.UseVisualStyleBackColor = true;
            this.bnCancelar.Click += new System.EventHandler(this.bnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(243, 15);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resultado Final";
            // 
            // cmbResultadoFinal
            // 
            this.cmbResultadoFinal.DataSource = this.dsSpx1;
            this.cmbResultadoFinal.DisplayMember = "resultado_final_llamada.resultado_final_llamada";
            this.cmbResultadoFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResultadoFinal.FormattingEnabled = true;
            this.cmbResultadoFinal.Location = new System.Drawing.Point(114, 21);
            this.cmbResultadoFinal.Name = "cmbResultadoFinal";
            this.cmbResultadoFinal.Size = new System.Drawing.Size(285, 21);
            this.cmbResultadoFinal.TabIndex = 4;
            this.cmbResultadoFinal.ValueMember = "resultado_final_llamada.cod_resultado_final_llamada";
            // 
            // resultado_final_llamadaTableAdapter1
            // 
            this.resultado_final_llamadaTableAdapter1.ClearBeforeFill = true;
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmFechaSolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(407, 195);
            this.ControlBox = false;
            this.Controls.Add(this.cmbResultadoFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.calSolucion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFechaSolucion";
            this.Text = "Fecha Solucion";
            this.Load += new System.EventHandler(this.frmFechaSolucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calSolucion)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calSolucion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbResultadoFinal;
        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.resultado_final_llamadaTableAdapter resultado_final_llamadaTableAdapter1;
    }
}