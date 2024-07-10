namespace SpFrm.rptServicios
{
    partial class frmTipoServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoServicio));
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.tipoServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.TipoServicioTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombreTipoServicio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.chkVuelve = new System.Windows.Forms.CheckBox();
            this.chkServicioValidoContrato = new System.Windows.Forms.CheckBox();
            this.chkServicioPreventivo = new System.Windows.Forms.CheckBox();
            this.chkCorrectivo = new System.Windows.Forms.CheckBox();
            this.chkDevuelvenEntrada = new System.Windows.Forms.CheckBox();
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
            this.ribbonControlDataFrm.Size = new System.Drawing.Size(966, 556);
            this.ribbonControlDataFrm.Controls.SetChildIndex(this.ribbonPanel2dataFrm, 0);
            this.ribbonControlDataFrm.Controls.SetChildIndex(this.ribbonPanel1dataFrm, 0);
            // 
            // ribbonPanel1dataFrm
            // 
            this.ribbonPanel1dataFrm.Controls.Add(this.chkOmiteAprobacion);
            this.ribbonPanel1dataFrm.Controls.Add(this.chkDevuelvenEntrada);
            this.ribbonPanel1dataFrm.Controls.Add(this.chkCorrectivo);
            this.ribbonPanel1dataFrm.Controls.Add(this.chkServicioPreventivo);
            this.ribbonPanel1dataFrm.Controls.Add(this.chkServicioValidoContrato);
            this.ribbonPanel1dataFrm.Controls.Add(this.chkVuelve);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtNombreTipoServicio);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtDescripcion);
            this.ribbonPanel1dataFrm.Controls.Add(this.label1);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtCodigo);
            this.ribbonPanel1dataFrm.Controls.Add(this.label2);
            this.ribbonPanel1dataFrm.Controls.Add(this.label3);
            this.ribbonPanel1dataFrm.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanel1dataFrm.Size = new System.Drawing.Size(966, 498);
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
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label3, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label2, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtCodigo, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label1, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtNombreTipoServicio, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.chkVuelve, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.chkServicioValidoContrato, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.chkServicioPreventivo, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.chkCorrectivo, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.chkDevuelvenEntrada, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.chkOmiteAprobacion, 0);
            // 
            // cgDataControler1
            // 
            this.cgDataControler1.campos = "Codigo|codTipoServicio,Tipo Servicio|nombretipoServicio";
            this.cgDataControler1.dataTabla = this.dsSpx1.TipoServicio;
            this.cgDataControler1.EstadoControles = false;
            this.cgDataControler1.EventosEncendidos = true;
            this.cgDataControler1.AntesDeAceptar += new CGDataControler.dataControlerEventHandler(this.cgDataControler1_AntesDeAceptar);
            // 
            // ribbonPanel2dataFrm
            // 
            this.ribbonPanel2dataFrm.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanel2dataFrm.Size = new System.Drawing.Size(966, 498);
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
            this.grdDatos.DataMember = "TipoServicio";
            this.grdDatos.DataSource = this.dsSpx1;
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75D;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(902, 328);
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
            // 
            // txtTotalRegistros
            // 
            this.txtTotalRegistros.Text = "0";
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
            // tipoServicioTableAdapter1
            // 
            this.tipoServicioTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(14, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(14, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre Tipo Servicio *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(14, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripcion";
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "TipoServicio.codTipoServicio", true));
            this.txtCodigo.Location = new System.Drawing.Point(149, 121);
            this.txtCodigo.MaxLength = 5;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(155, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // txtNombreTipoServicio
            // 
            this.txtNombreTipoServicio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "TipoServicio.nombretipoServicio", true));
            this.txtNombreTipoServicio.Location = new System.Drawing.Point(149, 158);
            this.txtNombreTipoServicio.MaxLength = 40;
            this.txtNombreTipoServicio.Name = "txtNombreTipoServicio";
            this.txtNombreTipoServicio.ReadOnly = true;
            this.txtNombreTipoServicio.Size = new System.Drawing.Size(375, 20);
            this.txtNombreTipoServicio.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "TipoServicio.descripcion", true));
            this.txtDescripcion.Location = new System.Drawing.Point(149, 198);
            this.txtDescripcion.MaxLength = 250;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(480, 124);
            this.txtDescripcion.TabIndex = 2;
            // 
            // chkVuelve
            // 
            this.chkVuelve.AutoSize = true;
            this.chkVuelve.BackColor = System.Drawing.Color.Transparent;
            this.chkVuelve.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsSpx1, "TipoServicio.devuelveTaller", true));
            this.chkVuelve.Location = new System.Drawing.Point(149, 339);
            this.chkVuelve.Name = "chkVuelve";
            this.chkVuelve.Size = new System.Drawing.Size(387, 17);
            this.chkVuelve.TabIndex = 5;
            this.chkVuelve.Text = "Este Tipo de Servicio retorna el equipo al taller al cerrar una orden de trabajo";
            this.chkVuelve.UseVisualStyleBackColor = false;
            // 
            // chkServicioValidoContrato
            // 
            this.chkServicioValidoContrato.AutoSize = true;
            this.chkServicioValidoContrato.BackColor = System.Drawing.Color.Transparent;
            this.chkServicioValidoContrato.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsSpx1, "TipoServicio.validoContrato", true));
            this.chkServicioValidoContrato.Location = new System.Drawing.Point(149, 385);
            this.chkServicioValidoContrato.Name = "chkServicioValidoContrato";
            this.chkServicioValidoContrato.Size = new System.Drawing.Size(296, 17);
            this.chkServicioValidoContrato.TabIndex = 6;
            this.chkServicioValidoContrato.Text = "Tipo de Servicio Cubierto por Contratos de Mantenimento";
            this.chkServicioValidoContrato.UseVisualStyleBackColor = false;
            // 
            // chkServicioPreventivo
            // 
            this.chkServicioPreventivo.AutoSize = true;
            this.chkServicioPreventivo.BackColor = System.Drawing.Color.Transparent;
            this.chkServicioPreventivo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsSpx1, "TipoServicio.preventivo", true));
            this.chkServicioPreventivo.Location = new System.Drawing.Point(149, 413);
            this.chkServicioPreventivo.Name = "chkServicioPreventivo";
            this.chkServicioPreventivo.Size = new System.Drawing.Size(118, 17);
            this.chkServicioPreventivo.TabIndex = 7;
            this.chkServicioPreventivo.Text = "Servicio Preventivo";
            this.chkServicioPreventivo.UseVisualStyleBackColor = false;
            this.chkServicioPreventivo.CheckedChanged += new System.EventHandler(this.chkServicioPreventivo_CheckedChanged);
            // 
            // chkCorrectivo
            // 
            this.chkCorrectivo.AutoSize = true;
            this.chkCorrectivo.BackColor = System.Drawing.Color.Transparent;
            this.chkCorrectivo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsSpx1, "TipoServicio.correctivo", true));
            this.chkCorrectivo.Location = new System.Drawing.Point(149, 441);
            this.chkCorrectivo.Name = "chkCorrectivo";
            this.chkCorrectivo.Size = new System.Drawing.Size(115, 17);
            this.chkCorrectivo.TabIndex = 8;
            this.chkCorrectivo.Text = "Servicio Correctivo";
            this.chkCorrectivo.UseVisualStyleBackColor = false;
            // 
            // chkDevuelvenEntrada
            // 
            this.chkDevuelvenEntrada.AutoSize = true;
            this.chkDevuelvenEntrada.BackColor = System.Drawing.Color.Transparent;
            this.chkDevuelvenEntrada.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsSpx1, "TipoServicio.devuelveEntrada", true));
            this.chkDevuelvenEntrada.Location = new System.Drawing.Point(149, 362);
            this.chkDevuelvenEntrada.Name = "chkDevuelvenEntrada";
            this.chkDevuelvenEntrada.Size = new System.Drawing.Size(356, 17);
            this.chkDevuelvenEntrada.TabIndex = 9;
            this.chkDevuelvenEntrada.Text = "Este Tipo de Servicio retorna el equipo al taller al ingresar una entrada";
            this.chkDevuelvenEntrada.UseVisualStyleBackColor = false;
            // 
            // chkOmiteAprobacion
            // 
            this.chkOmiteAprobacion.AutoSize = true;
            this.chkOmiteAprobacion.BackColor = System.Drawing.Color.Transparent;
            this.chkOmiteAprobacion.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsSpx1, "TipoServicio.omite_aprobacion_os", true));
            this.chkOmiteAprobacion.Location = new System.Drawing.Point(149, 464);
            this.chkOmiteAprobacion.Name = "chkOmiteAprobacion";
            this.chkOmiteAprobacion.Size = new System.Drawing.Size(196, 17);
            this.chkOmiteAprobacion.TabIndex = 10;
            this.chkOmiteAprobacion.Text = "Omite Aprobacion orden de Servicio";
            this.chkOmiteAprobacion.UseVisualStyleBackColor = false;
            // 
            // frmTipoServicio
            // 
            this.ClientSize = new System.Drawing.Size(976, 559);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTipoServicio";
            this.Text = "Tipos de Servicio - Nombre Software";
            this.tituloTabla = "Tipos de Servicio";
            this.Load += new System.EventHandler(this.frmTipoServicio_Load);
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
        private SPControladoraDatos.dsSpxTableAdapters.TipoServicioTableAdapter tipoServicioTableAdapter1;
        private System.Windows.Forms.TextBox txtNombreTipoServicio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkVuelve;
        private System.Windows.Forms.CheckBox chkServicioValidoContrato;
        private System.Windows.Forms.CheckBox chkCorrectivo;
        private System.Windows.Forms.CheckBox chkServicioPreventivo;
        private System.Windows.Forms.CheckBox chkDevuelvenEntrada;
        private System.Windows.Forms.CheckBox chkOmiteAprobacion;
    }
}
