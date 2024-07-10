using SPControladoraDatos.artefactos.SPXQuery.data;
using SPControladoraDatos.artefactos.SPXQuery.data.dsSPXQueryTableAdapters;

namespace SPControladoraDatos.artefactos.SPXQuery.frm.Reportes
{
    partial class frmNuevoReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoReporte));
            this.dsSPXQuery1 = new dsSPXQuery();
            this.rptTableAdapter1 = new rptTableAdapter();
            this.rpt_parametrosTableAdapter1 = new rpt_parametrosTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.grdcampos = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelecXml = new System.Windows.Forms.Button();
            this.txtXml = new System.Windows.Forms.TextBox();
            this.txtCaption = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.chkFiltroObligatorio = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.contOpciones = new System.Windows.Forms.Panel();
            this.btnExportarExcel = new DevComponents.DotNetBar.ButtonX();
            this.btnModificar = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregar = new DevComponents.DotNetBar.ButtonX();
            this.btnEliminar = new DevComponents.DotNetBar.ButtonX();
            this.btnActualizar = new DevComponents.DotNetBar.ButtonX();
            this.panel1.SuspendLayout();
            this.contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXQuery1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdcampos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(260, 23);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAplicar);
            this.panel1.Location = new System.Drawing.Point(0, 445);
            this.panel1.Size = new System.Drawing.Size(606, 50);
            this.panel1.Controls.SetChildIndex(this.btnAceptar, 0);
            this.panel1.Controls.SetChildIndex(this.btnCancelar, 0);
            this.panel1.Controls.SetChildIndex(this.btnAplicar, 0);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(372, 15);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(446, 15);
            // 
            // contenedor
            // 
            this.contenedor.Controls.Add(this.contOpciones);
            this.contenedor.Controls.Add(this.label5);
            this.contenedor.Controls.Add(this.grdcampos);
            this.contenedor.Controls.Add(this.groupBox1);
            this.contenedor.Size = new System.Drawing.Size(581, 405);
            // 
            // dsSPXQuery1
            // 
            this.dsSPXQuery1.DataSetName = "dsSPXQuery";
            this.dsSPXQuery1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptTableAdapter1
            // 
            this.rptTableAdapter1.ClearBeforeFill = true;
            // 
            // rpt_parametrosTableAdapter1
            // 
            this.rpt_parametrosTableAdapter1.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Campos";
            // 
            // grdcampos
            // 
            this.grdcampos.AllowUpdate = false;
            this.grdcampos.DataMember = "rpt_parametros";
            this.grdcampos.DataSource = this.dsSPXQuery1;
            this.grdcampos.GroupByCaption = "Drag a column header here to group by that column";
            this.grdcampos.Images.Add(((System.Drawing.Image)(resources.GetObject("grdcampos.Images"))));
            this.grdcampos.Location = new System.Drawing.Point(20, 198);
            this.grdcampos.Name = "grdcampos";
            this.grdcampos.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdcampos.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdcampos.PreviewInfo.ZoomFactor = 75D;
            this.grdcampos.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdcampos.PrintInfo.PageSettings")));
            this.grdcampos.Size = new System.Drawing.Size(550, 198);
            this.grdcampos.TabIndex = 9;
            this.grdcampos.Text = "c1TrueDBGrid1";
            this.grdcampos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.grdcampos.PropBag = resources.GetString("grdcampos.PropBag");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelecXml);
            this.groupBox1.Controls.Add(this.txtXml);
            this.groupBox1.Controls.Add(this.txtCaption);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.chkFiltroObligatorio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 153);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion del Reporte";
            // 
            // btnSelecXml
            // 
            this.btnSelecXml.Location = new System.Drawing.Point(517, 100);
            this.btnSelecXml.Name = "btnSelecXml";
            this.btnSelecXml.Size = new System.Drawing.Size(27, 23);
            this.btnSelecXml.TabIndex = 9;
            this.btnSelecXml.Text = "...";
            this.btnSelecXml.UseVisualStyleBackColor = true;
            // 
            // txtXml
            // 
            this.txtXml.Location = new System.Drawing.Point(73, 103);
            this.txtXml.MaxLength = 50;
            this.txtXml.Name = "txtXml";
            this.txtXml.Size = new System.Drawing.Size(438, 20);
            this.txtXml.TabIndex = 8;
            // 
            // txtCaption
            // 
            this.txtCaption.Location = new System.Drawing.Point(73, 73);
            this.txtCaption.MaxLength = 100;
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(471, 20);
            this.txtCaption.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(73, 44);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(471, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(73, 16);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(76, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // chkFiltroObligatorio
            // 
            this.chkFiltroObligatorio.AutoSize = true;
            this.chkFiltroObligatorio.Location = new System.Drawing.Point(73, 129);
            this.chkFiltroObligatorio.Name = "chkFiltroObligatorio";
            this.chkFiltroObligatorio.Size = new System.Drawing.Size(101, 17);
            this.chkFiltroObligatorio.TabIndex = 4;
            this.chkFiltroObligatorio.Text = "Filtro Obligatorio";
            this.chkFiltroObligatorio.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "XML";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Caption";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // btnAplicar
            // 
            this.btnAplicar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAplicar.Location = new System.Drawing.Point(519, 15);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 23);
            this.btnAplicar.TabIndex = 3;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // contOpciones
            // 
            this.contOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contOpciones.Controls.Add(this.btnExportarExcel);
            this.contOpciones.Controls.Add(this.btnModificar);
            this.contOpciones.Controls.Add(this.btnAgregar);
            this.contOpciones.Controls.Add(this.btnEliminar);
            this.contOpciones.Controls.Add(this.btnActualizar);
            this.contOpciones.Location = new System.Drawing.Point(426, 167);
            this.contOpciones.Name = "contOpciones";
            this.contOpciones.Size = new System.Drawing.Size(144, 28);
            this.contOpciones.TabIndex = 65;
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExportarExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarExcel.Image")));
            this.btnExportarExcel.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnExportarExcel.Location = new System.Drawing.Point(115, 0);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(28, 28);
            this.btnExportarExcel.TabIndex = 4;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnModificar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnModificar.Location = new System.Drawing.Point(58, 0);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(28, 28);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Click += new System.EventHandler(this.btnModificarReporte_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnAgregar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAgregar.Location = new System.Drawing.Point(29, 0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(28, 28);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Tooltip = "<font color=\"#1F497D\"><u><b>Actualizar</b></u></font>";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregarReporte_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnEliminar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnEliminar.Location = new System.Drawing.Point(87, 0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(28, 28);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Tooltip = "<font color=\"#1F497D\"><u><b>Eliminar Item</b></u></font>";
            this.btnEliminar.Click += new System.EventHandler(this.btnBorrarReporte_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnActualizar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnActualizar.Location = new System.Drawing.Point(0, 0);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(28, 28);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // frmNuevoReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(606, 495);
            this.MaximizeBox = false;
            this.Name = "frmNuevoReporte";
            this.Text = "Nuevo Reporte";
            this.Load += new System.EventHandler(this.frmNuevoReporte_Load);
            this.panel1.ResumeLayout(false);
            this.contenedor.ResumeLayout(false);
            this.contenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXQuery1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdcampos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private dsSPXQuery dsSPXQuery1;
        private data.dsSPXQueryTableAdapters.rptTableAdapter rptTableAdapter1;
        private data.dsSPXQueryTableAdapters.rpt_parametrosTableAdapter rpt_parametrosTableAdapter1;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Label label5;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdcampos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelecXml;
        private System.Windows.Forms.TextBox txtXml;
        private System.Windows.Forms.TextBox txtCaption;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.CheckBox chkFiltroObligatorio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel contOpciones;
        private DevComponents.DotNetBar.ButtonX btnExportarExcel;
        protected DevComponents.DotNetBar.ButtonX btnModificar;
        protected DevComponents.DotNetBar.ButtonX btnAgregar;
        protected DevComponents.DotNetBar.ButtonX btnEliminar;
        protected DevComponents.DotNetBar.ButtonX btnActualizar;
    }
}