using SPControladoraDatos.artefactos.SPXQuery.data;

namespace SPControladoraDatos.artefactos.SPXQuery.frm.Reportes
{
    partial class frmConfigurarReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigurarReporte));
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.btnGenerarScriptTablas = new DevComponents.DotNetBar.ButtonX();
            this.btnGenerarScript = new DevComponents.DotNetBar.ButtonX();
            this.btnSalir = new DevComponents.DotNetBar.ButtonX();
            this.c1Report1 = new C1.C1Report.C1Report();
            this.dsSPXQuery1 = new dsSPXQuery();
            this.rptTableAdapter2 = new data.dsSPXQueryTableAdapters.rptTableAdapter();
            this.rpt_parametrosTableAdapter1 = new data.dsSPXQueryTableAdapters.rpt_parametrosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Report1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXQuery1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Click += new System.EventHandler(this.btnBorrarReporte_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Click += new System.EventHandler(this.btnModificarReporte_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregarReporte_Click);
            // 
            // grdDatos
            // 
            this.grdDatos.DataMember = "rpt";
            this.grdDatos.DataSource = this.dsSPXQuery1;
            this.grdDatos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDatos.PreviewInfo.ZoomFactor = 75D;
            this.grdDatos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDatos.PrintInfo.PageSettings")));
            this.grdDatos.PropBag = resources.GetString("grdDatos.PropBag");
            // 
            // btnGenerarScriptTablas
            // 
            this.btnGenerarScriptTablas.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGenerarScriptTablas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnGenerarScriptTablas, "Generar Script Para Crear Tablas");
            this.balloonTip1.SetBalloonText(this.btnGenerarScriptTablas, null);
            this.btnGenerarScriptTablas.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarScriptTablas.Image")));
            this.btnGenerarScriptTablas.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnGenerarScriptTablas.Location = new System.Drawing.Point(229, 2);
            this.btnGenerarScriptTablas.Name = "btnGenerarScriptTablas";
            this.btnGenerarScriptTablas.Size = new System.Drawing.Size(28, 28);
            this.btnGenerarScriptTablas.TabIndex = 70;
            this.btnGenerarScriptTablas.Click += new System.EventHandler(this.btnGenerarScript_Click);
            // 
            // btnGenerarScript
            // 
            this.btnGenerarScript.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGenerarScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balloonTip1.SetBalloonCaption(this.btnGenerarScript, "Generar Script");
            this.balloonTip1.SetBalloonText(this.btnGenerarScript, null);
            this.btnGenerarScript.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarScript.Image")));
            this.btnGenerarScript.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnGenerarScript.Location = new System.Drawing.Point(258, 2);
            this.btnGenerarScript.Name = "btnGenerarScript";
            this.btnGenerarScript.Size = new System.Drawing.Size(28, 28);
            this.btnGenerarScript.TabIndex = 69;
            this.btnGenerarScript.Click += new System.EventHandler(this.btnGenerarScriptTablas_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnSalir, "Salir");
            this.balloonTip1.SetBalloonText(this.btnSalir, null);
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnSalir.Location = new System.Drawing.Point(94, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 28);
            this.btnSalir.TabIndex = 68;
            this.btnSalir.Text = "Reportes x Usuario";
            this.btnSalir.Click += new System.EventHandler(this.btnEditarReportexUsuario_Click);
            // 
            // c1Report1
            // 
            this.c1Report1.ReportDefinition = resources.GetString("c1Report1.ReportDefinition");
            this.c1Report1.ReportName = "c1Report1";
            // 
            // dsSPXQuery1
            // 
            this.dsSPXQuery1.DataSetName = "dsSPXQuery";
            this.dsSPXQuery1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptTableAdapter2
            // 
            this.rptTableAdapter2.ClearBeforeFill = true;
            // 
            // rpt_parametrosTableAdapter1
            // 
            this.rpt_parametrosTableAdapter1.ClearBeforeFill = true;
            // 
            // frmConfigurarReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(444, 462);
            this.Controls.Add(this.btnGenerarScriptTablas);
            this.Controls.Add(this.btnGenerarScript);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmConfigurarReporte";
            this.Text = "Configurar Reportes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.grdDatos, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnGenerarScript, 0);
            this.Controls.SetChildIndex(this.btnGenerarScriptTablas, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Report1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXQuery1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private C1.C1Report.C1Report c1Report1;
        private dsSPXQuery dsSPXQuery1;
        private data.dsSPXQueryTableAdapters.rptTableAdapter rptTableAdapter2;
        private DevComponents.DotNetBar.ButtonX btnGenerarScriptTablas;
        private DevComponents.DotNetBar.ButtonX btnGenerarScript;
        private DevComponents.DotNetBar.ButtonX btnSalir;
        private data.dsSPXQueryTableAdapters.rpt_parametrosTableAdapter rpt_parametrosTableAdapter1;
    }
}

