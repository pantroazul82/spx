﻿namespace SpFrm.generales
{
    partial class frmMediosSolicitud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMediosSolicitud));
            this.medioSolicitudTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.medioSolicitudTableAdapter();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.ribbonControlDataFrm.SuspendLayout();
            this.ribbonPanel1dataFrm.SuspendLayout();
            this.grpOpcionesExportar.SuspendLayout();
            this.grdDatos.BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControlDataFrm
            // 
            this.ribbonControlDataFrm.Size = new System.Drawing.Size(968, 553);
            this.ribbonControlDataFrm.Controls.SetChildIndex(this.ribbonPanel1dataFrm, 0);
            // 
            // ribbonPanel1dataFrm
            // 
            this.ribbonPanel1dataFrm.Controls.Add(this.label3);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtDescripcion);
            this.ribbonPanel1dataFrm.Controls.Add(this.label2);
            this.ribbonPanel1dataFrm.Controls.Add(this.txtCodigo);
            this.ribbonPanel1dataFrm.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel1dataFrm.Size = new System.Drawing.Size(968, 496);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.grdDatos, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.grpOpcionesExportar, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtCodigo, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label2, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.ribbonPanel1dataFrm.Controls.SetChildIndex(this.label3, 0);
            // 
            // cgDataControler1
            // 
            this.cgDataControler1.campos = "Codigo|codMedioSolicitud,Descripcion|descripcionMedio";
            this.cgDataControler1.dataTabla = this.dsSpx1.medioSolicitud;
            this.cgDataControler1.EstadoControles = false;
            this.cgDataControler1.DespuesDeNuevo += new CGDataControler.dataControlerEventHandler(this.cgDataControler1_DespuesDeNuevo);
            // 
            // grpOpcionesExportar
            // 
            this.grpOpcionesExportar.Location = new System.Drawing.Point(475, 345);
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
            this.grpOpcionesExportar.Style.CornerDiameter = 4;
            this.grpOpcionesExportar.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grpOpcionesExportar.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.grpOpcionesExportar.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grpOpcionesExportar.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // grdDatos
            // 
            this.grdDatos.DataMember = "medioSolicitud";
            this.grdDatos.DataSource = this.dsSpx1;
            this.grdDatos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDatos.Images"))));
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.Size = new System.Drawing.Size(473, 235);
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
            // 
            // medioSolicitudTableAdapter1
            // 
            this.medioSolicitudTableAdapter1.ClearBeforeFill = true;
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(18, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "medioSolicitud.descripcionMedio", true));
            this.txtDescripcion.Location = new System.Drawing.Point(99, 136);
            this.txtDescripcion.MaxLength = 30;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(268, 20);
            this.txtDescripcion.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(18, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Codigo Medio";
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSpx1, "medioSolicitud.codMedioSolicitud", true));
            this.txtCodigo.Location = new System.Drawing.Point(99, 110);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 15;
            // 
            // frmMediosSolicitud
            // 
            this.ClientSize = new System.Drawing.Size(976, 556);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMediosSolicitud";
            this.Text = "Medios de Solicitud - Nombre Software";
            this.tituloTabla = "Medios de Solicitud";
            this.Load += new System.EventHandler(this.frmMediosSolicitud_Load);
            this.ribbonControlDataFrm.ResumeLayout(false);
            this.ribbonControlDataFrm.PerformLayout();
            this.ribbonPanel1dataFrm.ResumeLayout(false);
            this.ribbonPanel1dataFrm.PerformLayout();
            this.grpOpcionesExportar.ResumeLayout(false);
            this.grpOpcionesExportar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SPControladoraDatos.dsSpxTableAdapters.medioSolicitudTableAdapter medioSolicitudTableAdapter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private SPControladoraDatos.dsSpx dsSpx1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}