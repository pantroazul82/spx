namespace spProcesos.ordenPrestamo
{
    partial class frmCantidadPrestada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCantidadPrestada));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nmCantidadPrestada = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.calEntrega = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            ((System.ComponentModel.ISupportInitialize)(this.nmCantidadPrestada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calEntrega)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(177, 164);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(269, 164);
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
            this.label1.Location = new System.Drawing.Point(33, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad Prestada";
            // 
            // nmCantidadPrestada
            // 
            this.nmCantidadPrestada.Location = new System.Drawing.Point(133, 51);
            this.nmCantidadPrestada.Name = "nmCantidadPrestada";
            this.nmCantidadPrestada.Size = new System.Drawing.Size(71, 20);
            this.nmCantidadPrestada.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Entrega";
            // 
            // calEntrega
            // 
            // 
            // 
            // 
            this.calEntrega.BackgroundStyle.Class = "DateTimeInputBackground";
            this.calEntrega.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calEntrega.ButtonDropDown.Visible = true;
            this.calEntrega.Location = new System.Drawing.Point(133, 88);
            // 
            // 
            // 
            this.calEntrega.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calEntrega.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calEntrega.MonthCalendar.BackgroundStyle.Class = "";
            this.calEntrega.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calEntrega.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.calEntrega.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calEntrega.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.calEntrega.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calEntrega.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calEntrega.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.calEntrega.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.calEntrega.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.calEntrega.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calEntrega.MonthCalendar.DisplayMonth = new System.DateTime(2009, 4, 1, 0, 0, 0, 0);
            this.calEntrega.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.calEntrega.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calEntrega.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.calEntrega.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calEntrega.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.calEntrega.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.calEntrega.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calEntrega.MonthCalendar.TodayButtonVisible = true;
            this.calEntrega.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.calEntrega.Name = "calEntrega";
            this.calEntrega.Size = new System.Drawing.Size(200, 20);
            this.calEntrega.TabIndex = 5;
            // 
            // frmCantidadPrestada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 199);
            this.ControlBox = false;
            this.Controls.Add(this.calEntrega);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmCantidadPrestada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCantidadPrestada";
            this.Text = "Cantidad Prestada";
            this.Load += new System.EventHandler(this.frmCantidadPrestada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmCantidadPrestada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calEntrega)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmCantidadPrestada;
        private System.Windows.Forms.Label label2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput calEntrega;
    }
}