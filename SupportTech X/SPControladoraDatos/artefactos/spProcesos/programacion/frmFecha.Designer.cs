namespace spProcesos.programacion
{
    partial class frmFecha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFecha));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.calFecha = new DevComponents.Editors.DateTimeAdv.MonthCalendarAdv();
            this.lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(73, 202);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // calFecha
            // 
            this.calFecha.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.calFecha.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.calFecha.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calFecha.BackgroundStyle.BorderBottomWidth = 1;
            this.calFecha.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.calFecha.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calFecha.BackgroundStyle.BorderLeftWidth = 1;
            this.calFecha.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calFecha.BackgroundStyle.BorderRightWidth = 1;
            this.calFecha.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.calFecha.BackgroundStyle.BorderTopWidth = 1;
            this.calFecha.DisplayMonth = new System.DateTime(2008, 5, 1, 0, 0, 0, 0);
            this.calFecha.Location = new System.Drawing.Point(22, 48);
            this.calFecha.MarkedDates = new System.DateTime[0];
            this.calFecha.MonthlyMarkedDates = new System.DateTime[0];
            this.calFecha.Name = "calFecha";
            // 
            // 
            // 
            this.calFecha.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.calFecha.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.calFecha.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.calFecha.Size = new System.Drawing.Size(177, 148);
            this.calFecha.TabIndex = 3;
            this.calFecha.Text = "monthCalendarAdv1";
            // 
            // lblText
            // 
            this.lblText.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(3, 9);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(205, 28);
            this.lblText.TabIndex = 4;
            this.lblText.Text = "ingrese la Fecha";
            // 
            // frmFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(220, 232);
            this.ControlBox = false;
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.calFecha);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFecha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ingrese la Fecha";
            this.Load += new System.EventHandler(this.frmFecha_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private DevComponents.Editors.DateTimeAdv.MonthCalendarAdv calFecha;
        private System.Windows.Forms.Label lblText;
    }
}