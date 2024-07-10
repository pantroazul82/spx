namespace SpFrm.generales
{
    partial class frmTipoEquipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoEquipo));
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.tipoEquipoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.tipoEquipoTableAdapter();
            this.txtCodigoTipo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chkDispostivioMedicion = new System.Windows.Forms.CheckBox();
            this.chkDispositivoMedible = new System.Windows.Forms.CheckBox();
            this.chkOmiteAprobacion = new System.Windows.Forms.CheckBox();
            this.ribbonControlDataFrm.SuspendLayout();
            this.ribbonPanel1dataFrm.SuspendLayout();
            this.ribbonPanel2dataFrm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.grpOpcionesExportar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControlDataFrm
            // 
            // 
            // 
            // 
            this.ribbonControlDataFrm.BackgroundStyle.Class = "";
            this.ribbonControlDataFrm.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControlDataFrm.Location = new System.Drawing.Point(5, 1);
            this.ribbonControlDataFrm.Size = new System.Drawing.Size(990, 567);
            this.ribbonControlDataFrm.Controls.SetChildIndex(this.ribbonPanel2dataFrm, 0);
            this.ribbonControlDataFrm.Controls.SetChildIndex(this.ribbonPanel1dataFrm, 0);
            // 
            // ribbonPanel1dataFrm
            // 
            this.ribbonPanel1dataFrm.Controls.Add(this.chkOmiteAprobacion);
            this.ribbonPanel1dataFrm.Controls.Add(this.chkDispositivoMedible);
            this.ribbonPanel1dataFrm.Controls.Add(this.chkDispostivioMedicion);
            this.ribbonPanel1dataFrm.Controls.Add(this.textBox1);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtCodigoTipo);
            this.ribbonPanel1dataFrm.Controls.Add(this.label5);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtNombre);
            this.ribbonPanel1dataFrm.Controls.Add(this.label6);
            this.ribbonPanel1dataFrm.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanel1dataFrm.Size = new System.Drawing.Size(990, 509);
            // 
            // 
            // 
            this.ribbonPanel1dataFrm.Style.Class = "";
            this.ribbonPanel1dataFrm.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1dataFrm.StyleMouseDown.Class = "";
            this.ribbonPanel1dataFrm.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1dataFrm.StyleMouseOver.Class = "";
            this.ribbonPanel1dataFrm.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1dataFrm.Visible = true;
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label6, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtNombre, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label5, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtCodigoTipo, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.textBox1, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.chkDispostivioMedicion, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.chkDispositivoMedible, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.chkOmiteAprobacion, 0);
            // 
            // cgDataControler1
            // 
            this.cgDataControler1.campos = "Codigo|codTipoEquipo,Nombre|nombreTipoEquipo";
            this.cgDataControler1.dataTabla = this.dsSpx1.tipoEquipo;
            this.cgDataControler1.EstadoControles = false;
            this.cgDataControler1.EventosEncendidos = true;
            this.cgDataControler1.estadoControlesChanged += new CGDataControler.dataControlerEventHandler(this.cgDataControler1_estadoControlesChanged);
            this.cgDataControler1.AntesDeAceptar += new CGDataControler.dataControlerEventHandler(this.cgDataControler1_AntesDeAceptar);
            // 
            // ribbonPanel2dataFrm
            // 
            this.ribbonPanel2dataFrm.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanel2dataFrm.Size = new System.Drawing.Size(990, 509);
            // 
            // 
            // 
            this.ribbonPanel2dataFrm.Style.Class = "";
            this.ribbonPanel2dataFrm.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2dataFrm.StyleMouseDown.Class = "";
            this.ribbonPanel2dataFrm.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2dataFrm.StyleMouseOver.Class = "";
            this.ribbonPanel2dataFrm.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // grdDatos
            // 
            this.grdDatos.DataMember = "tipoEquipo";
            this.grdDatos.DataSource = this.dsSpx1;
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75D;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(950, 350);
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
            // 
            // grpOpcionesExportar
            // 
            // 
            // 
            // 
            this.grpOpcionesExportar.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.grpOpcionesExportar.Style.BackColorGradientAngle = 90;
            this.grpOpcionesExportar.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.grpOpcionesExportar.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpOpcionesExportar.Style.BorderBottomWidth = 1;
            this.grpOpcionesExportar.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.grpOpcionesExportar.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpOpcionesExportar.Style.BorderLeftWidth = 1;
            this.grpOpcionesExportar.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpOpcionesExportar.Style.BorderRightWidth = 1;
            this.grpOpcionesExportar.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpOpcionesExportar.Style.BorderTopWidth = 1;
            this.grpOpcionesExportar.Style.Class = "";
            this.grpOpcionesExportar.Style.CornerDiameter = 4;
            this.grpOpcionesExportar.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grpOpcionesExportar.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.grpOpcionesExportar.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grpOpcionesExportar.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.grpOpcionesExportar.StyleMouseDown.Class = "";
            this.grpOpcionesExportar.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.grpOpcionesExportar.StyleMouseOver.Class = "";
            this.grpOpcionesExportar.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.EnforceConstraints = false;
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoEquipoTableAdapter1
            // 
            this.tipoEquipoTableAdapter1.ClearBeforeFill = true;
            // 
            // txtCodigoTipo
            // 
            this.txtCodigoTipo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "tipoEquipo.codTipoEquipo", true));
            this.txtCodigoTipo.Location = new System.Drawing.Point(122, 114);
            this.txtCodigoTipo.MaxLength = 5;
            this.txtCodigoTipo.Name = "txtCodigoTipo";
            this.txtCodigoTipo.ReadOnly = true;
            this.txtCodigoTipo.Size = new System.Drawing.Size(183, 20);
            this.txtCodigoTipo.TabIndex = 3;
            this.txtCodigoTipo.TextChanged += new System.EventHandler(this.txtCodigoTipo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(14, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "*Codigo Tipo Equipo:";
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "tipoEquipo.nombreTipoEquipo", true));
            this.txtNombre.Location = new System.Drawing.Point(122, 150);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(292, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(14, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "*Nombre Tipo Equipo:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(449, 114);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(496, 185);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // chkDispostivioMedicion
            // 
            this.chkDispostivioMedicion.AutoSize = true;
            this.chkDispostivioMedicion.BackColor = System.Drawing.Color.Transparent;
            this.chkDispostivioMedicion.Location = new System.Drawing.Point(127, 207);
            this.chkDispostivioMedicion.Name = "chkDispostivioMedicion";
            this.chkDispostivioMedicion.Size = new System.Drawing.Size(123, 17);
            this.chkDispostivioMedicion.TabIndex = 8;
            this.chkDispostivioMedicion.Text = "Dispositivo Medicion";
            this.chkDispostivioMedicion.UseVisualStyleBackColor = false;
            // 
            // chkDispositivoMedible
            // 
            this.chkDispositivoMedible.AutoSize = true;
            this.chkDispositivoMedible.BackColor = System.Drawing.Color.Transparent;
            this.chkDispositivoMedible.Location = new System.Drawing.Point(127, 239);
            this.chkDispositivoMedible.Name = "chkDispositivoMedible";
            this.chkDispositivoMedible.Size = new System.Drawing.Size(117, 17);
            this.chkDispositivoMedible.TabIndex = 9;
            this.chkDispositivoMedible.Text = "Dispositivo Medible";
            this.chkDispositivoMedible.UseVisualStyleBackColor = false;
            // 
            // chkOmiteAprobacion
            // 
            this.chkOmiteAprobacion.AutoSize = true;
            this.chkOmiteAprobacion.BackColor = System.Drawing.Color.Transparent;
            this.chkOmiteAprobacion.Location = new System.Drawing.Point(127, 266);
            this.chkOmiteAprobacion.Name = "chkOmiteAprobacion";
            this.chkOmiteAprobacion.Size = new System.Drawing.Size(194, 17);
            this.chkOmiteAprobacion.TabIndex = 10;
            this.chkOmiteAprobacion.Text = "Omite Aprobacion orden de servicio";
            this.chkOmiteAprobacion.UseVisualStyleBackColor = false;
            // 
            // frmTipoEquipo
            // 
            this.ClientSize = new System.Drawing.Size(1000, 570);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTipoEquipo";
            this.Text = "Tipo Equipos - Nombre Software";
            this.tituloTabla = "Tipo Equipos";
            this.Load += new System.EventHandler(this.frmTipoEquipo_Load);
            this.ribbonControlDataFrm.ResumeLayout(false);
            this.ribbonControlDataFrm.PerformLayout();
            this.ribbonPanel1dataFrm.ResumeLayout(false);
            this.ribbonPanel1dataFrm.PerformLayout();
            this.ribbonPanel2dataFrm.ResumeLayout(false);
            this.ribbonPanel2dataFrm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.grpOpcionesExportar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.tipoEquipoTableAdapter tipoEquipoTableAdapter1;
        private System.Windows.Forms.TextBox txtCodigoTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox chkDispositivoMedible;
        private System.Windows.Forms.CheckBox chkDispostivioMedicion;
        private System.Windows.Forms.CheckBox chkOmiteAprobacion;
    }
}
