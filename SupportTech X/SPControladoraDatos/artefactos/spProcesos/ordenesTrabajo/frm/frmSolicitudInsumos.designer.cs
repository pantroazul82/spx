namespace spProcesos.ordenesTrabajo
{
    partial class frmSolicitudInsumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSolicitudInsumos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkAceptada = new System.Windows.Forms.CheckBox();
            this.chkCancelada = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.btnRechazar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.nmHorasMantenimientoPreventivo = new System.Windows.Forms.NumericUpDown();
            this.txtNumerofactura = new System.Windows.Forms.TextBox();
            this.nmManteCorrectivo = new System.Windows.Forms.NumericUpDown();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtTiempoEstimado = new System.Windows.Forms.TextBox();
            this.txtAprobadaPor = new System.Windows.Forms.TextBox();
            this.datecalFechaAprobacion = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtNumeroSolicitud = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGrabarSalir = new System.Windows.Forms.Button();
            this.grdDetalleSolicitud = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsSpx1 = new SPControladoraDatos.dsSpx();
            this.detalleSolicitudInsumosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.detalleSolicitudInsumosTableAdapter();
            this.solicitudInsumosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.solicitudInsumosTableAdapter();
            this.repuestosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.repuestosTableAdapter();
            this.pltDetalleSolicitudInsumosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.pltDetalleSolicitudInsumosTableAdapter();
            this.nmHorasDiagnostico = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEliminarRepuesto = new DevComponents.DotNetBar.ButtonX();
            this.btnModificar = new DevComponents.DotNetBar.ButtonX();
            this.btnAgregarRepuesto = new DevComponents.DotNetBar.ButtonX();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.btnImprimir = new DevComponents.DotNetBar.ButtonX();
            this.unidadTiempoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.unidadTiempoTableAdapter();
            this.cmbtiempo = new System.Windows.Forms.ComboBox();
            this.clsTusuario1 = new SPXSeguridad.data.cls.clsTusuario();
            this.dsSPXSeguridad1 = new SPXSeguridad.data.dsSPXSeguridad();
            this.txtConsecutivoGeneral = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmHorasMantenimientoPreventivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmManteCorrectivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datecalFechaAprobacion)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleSolicitud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmHorasDiagnostico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Factura";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(269, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horas Mantenimiento Preventivo";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(490, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horas Mantenimiento Correctivo";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(13, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tiempo Estimado Entrega ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Observaciones";
            // 
            // chkAceptada
            // 
            this.chkAceptada.AutoSize = true;
            this.chkAceptada.BackColor = System.Drawing.Color.Transparent;
            this.chkAceptada.Enabled = false;
            this.chkAceptada.Location = new System.Drawing.Point(73, 71);
            this.chkAceptada.Name = "chkAceptada";
            this.chkAceptada.Size = new System.Drawing.Size(72, 17);
            this.chkAceptada.TabIndex = 5;
            this.chkAceptada.Text = "Aceptada";
            this.chkAceptada.UseVisualStyleBackColor = false;
            this.chkAceptada.CheckedChanged += new System.EventHandler(this.chkAceptada_CheckedChanged);
            // 
            // chkCancelada
            // 
            this.chkCancelada.AutoSize = true;
            this.chkCancelada.BackColor = System.Drawing.Color.Transparent;
            this.chkCancelada.Enabled = false;
            this.chkCancelada.Location = new System.Drawing.Point(201, 71);
            this.chkCancelada.Name = "chkCancelada";
            this.chkCancelada.Size = new System.Drawing.Size(81, 17);
            this.chkCancelada.TabIndex = 6;
            this.chkCancelada.Text = "Rechazada";
            this.chkCancelada.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(20, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Aprobada Por";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(14, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Fecha de Aprobacion";
            // 
            // btnAprobar
            // 
            this.btnAprobar.Location = new System.Drawing.Point(260, 236);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(75, 23);
            this.btnAprobar.TabIndex = 9;
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.UseVisualStyleBackColor = true;
            this.btnAprobar.Click += new System.EventHandler(this.btnAprobar_Click);
            // 
            // btnRechazar
            // 
            this.btnRechazar.Location = new System.Drawing.Point(344, 236);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.Size = new System.Drawing.Size(75, 23);
            this.btnRechazar.TabIndex = 10;
            this.btnRechazar.Text = "Rechazar";
            this.btnRechazar.UseVisualStyleBackColor = true;
            this.btnRechazar.Click += new System.EventHandler(this.btnRechazar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(16, 236);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Grabar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(425, 236);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // nmHorasMantenimientoPreventivo
            // 
            this.nmHorasMantenimientoPreventivo.Location = new System.Drawing.Point(384, 43);
            this.nmHorasMantenimientoPreventivo.Name = "nmHorasMantenimientoPreventivo";
            this.nmHorasMantenimientoPreventivo.Size = new System.Drawing.Size(55, 20);
            this.nmHorasMantenimientoPreventivo.TabIndex = 13;
            // 
            // txtNumerofactura
            // 
            this.txtNumerofactura.Location = new System.Drawing.Point(600, 12);
            this.txtNumerofactura.Name = "txtNumerofactura";
            this.txtNumerofactura.Size = new System.Drawing.Size(168, 20);
            this.txtNumerofactura.TabIndex = 14;
            // 
            // nmManteCorrectivo
            // 
            this.nmManteCorrectivo.Location = new System.Drawing.Point(611, 43);
            this.nmManteCorrectivo.Name = "nmManteCorrectivo";
            this.nmManteCorrectivo.Size = new System.Drawing.Size(55, 20);
            this.nmManteCorrectivo.TabIndex = 15;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(15, 122);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(424, 89);
            this.txtObservaciones.TabIndex = 16;
            this.txtObservaciones.TextChanged += new System.EventHandler(this.txtObservaciones_TextChanged);
            // 
            // txtTiempoEstimado
            // 
            this.txtTiempoEstimado.Location = new System.Drawing.Point(112, 79);
            this.txtTiempoEstimado.Name = "txtTiempoEstimado";
            this.txtTiempoEstimado.Size = new System.Drawing.Size(169, 20);
            this.txtTiempoEstimado.TabIndex = 17;
            this.txtTiempoEstimado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTiempoEstimado_KeyPress);
            // 
            // txtAprobadaPor
            // 
            this.txtAprobadaPor.Enabled = false;
            this.txtAprobadaPor.Location = new System.Drawing.Point(141, 15);
            this.txtAprobadaPor.Name = "txtAprobadaPor";
            this.txtAprobadaPor.Size = new System.Drawing.Size(200, 20);
            this.txtAprobadaPor.TabIndex = 18;
            // 
            // datecalFechaAprobacion
            // 
            // 
            // 
            // 
            this.datecalFechaAprobacion.BackgroundStyle.Class = "DateTimeInputBackground";
            this.datecalFechaAprobacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datecalFechaAprobacion.ButtonDropDown.Visible = true;
            this.datecalFechaAprobacion.Enabled = false;
            this.datecalFechaAprobacion.Location = new System.Drawing.Point(141, 43);
            // 
            // 
            // 
            this.datecalFechaAprobacion.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.datecalFechaAprobacion.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.datecalFechaAprobacion.MonthCalendar.BackgroundStyle.Class = "";
            this.datecalFechaAprobacion.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datecalFechaAprobacion.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.datecalFechaAprobacion.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.datecalFechaAprobacion.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.datecalFechaAprobacion.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.datecalFechaAprobacion.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.datecalFechaAprobacion.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.datecalFechaAprobacion.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.datecalFechaAprobacion.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.datecalFechaAprobacion.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datecalFechaAprobacion.MonthCalendar.DisplayMonth = new System.DateTime(2008, 5, 1, 0, 0, 0, 0);
            this.datecalFechaAprobacion.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.datecalFechaAprobacion.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.datecalFechaAprobacion.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.datecalFechaAprobacion.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.datecalFechaAprobacion.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.datecalFechaAprobacion.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.datecalFechaAprobacion.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.datecalFechaAprobacion.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.datecalFechaAprobacion.MonthCalendar.TodayButtonVisible = true;
            this.datecalFechaAprobacion.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.datecalFechaAprobacion.Name = "datecalFechaAprobacion";
            this.datecalFechaAprobacion.Size = new System.Drawing.Size(200, 20);
            this.datecalFechaAprobacion.TabIndex = 19;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.datecalFechaAprobacion);
            this.groupPanel1.Controls.Add(this.chkAceptada);
            this.groupPanel1.Controls.Add(this.txtAprobadaPor);
            this.groupPanel1.Controls.Add(this.chkCancelada);
            this.groupPanel1.Controls.Add(this.label6);
            this.groupPanel1.Controls.Add(this.label7);
            this.groupPanel1.Location = new System.Drawing.Point(445, 104);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(397, 106);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.Class = "";
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.Class = "";
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.Class = "";
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 20;
            // 
            // txtNumeroSolicitud
            // 
            this.txtNumeroSolicitud.Location = new System.Drawing.Point(384, 9);
            this.txtNumeroSolicitud.Name = "txtNumeroSolicitud";
            this.txtNumeroSolicitud.ReadOnly = true;
            this.txtNumeroSolicitud.Size = new System.Drawing.Size(55, 20);
            this.txtNumeroSolicitud.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Consecutivo Orden servicio";
            // 
            // btnGrabarSalir
            // 
            this.btnGrabarSalir.Location = new System.Drawing.Point(97, 236);
            this.btnGrabarSalir.Name = "btnGrabarSalir";
            this.btnGrabarSalir.Size = new System.Drawing.Size(156, 23);
            this.btnGrabarSalir.TabIndex = 28;
            this.btnGrabarSalir.Text = "Grabar y Salir";
            this.btnGrabarSalir.UseVisualStyleBackColor = true;
            this.btnGrabarSalir.Click += new System.EventHandler(this.btnGrabarSalir_Click);
            // 
            // grdDetalleSolicitud
            // 
            this.grdDetalleSolicitud.AllowUpdate = false;
            this.grdDetalleSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDetalleSolicitud.DataMember = "pltDetalleSolicitudInsumos";
            this.grdDetalleSolicitud.DataSource = this.dsSpx1;
            this.grdDetalleSolicitud.Images.Add(((System.Drawing.Image)(resources.GetObject("grdDetalleSolicitud.Images"))));
            this.grdDetalleSolicitud.Location = new System.Drawing.Point(15, 271);
            this.grdDetalleSolicitud.Name = "grdDetalleSolicitud";
            this.grdDetalleSolicitud.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.grdDetalleSolicitud.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.grdDetalleSolicitud.PreviewInfo.ZoomFactor = 75D;
            this.grdDetalleSolicitud.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("grdDetalleSolicitud.PrintInfo.PageSettings")));
            this.grdDetalleSolicitud.Size = new System.Drawing.Size(833, 283);
            this.grdDetalleSolicitud.TabIndex = 29;
            this.grdDetalleSolicitud.Text = "c1TrueDBGrid1";
            this.grdDetalleSolicitud.PropBag = resources.GetString("grdDetalleSolicitud.PropBag");
            // 
            // dsSpx1
            // 
            this.dsSpx1.DataSetName = "dsSpx";
            this.dsSpx1.EnforceConstraints = false;
            this.dsSpx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detalleSolicitudInsumosTableAdapter1
            // 
            this.detalleSolicitudInsumosTableAdapter1.ClearBeforeFill = true;
            // 
            // solicitudInsumosTableAdapter1
            // 
            this.solicitudInsumosTableAdapter1.ClearBeforeFill = true;
            // 
            // repuestosTableAdapter1
            // 
            this.repuestosTableAdapter1.ClearBeforeFill = true;
            // 
            // pltDetalleSolicitudInsumosTableAdapter1
            // 
            this.pltDetalleSolicitudInsumosTableAdapter1.ClearBeforeFill = true;
            // 
            // nmHorasDiagnostico
            // 
            this.nmHorasDiagnostico.Location = new System.Drawing.Point(112, 44);
            this.nmHorasDiagnostico.Name = "nmHorasDiagnostico";
            this.nmHorasDiagnostico.Size = new System.Drawing.Size(55, 20);
            this.nmHorasDiagnostico.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(13, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 18);
            this.label9.TabIndex = 30;
            this.label9.Text = "Horas Diagnostico";
            // 
            // btnEliminarRepuesto
            // 
            this.btnEliminarRepuesto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnEliminarRepuesto, "Eliminar Repuesto");
            this.balloonTip1.SetBalloonText(this.btnEliminarRepuesto, null);
            this.btnEliminarRepuesto.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarRepuesto.Image")));
            this.btnEliminarRepuesto.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnEliminarRepuesto.Location = new System.Drawing.Point(816, 236);
            this.btnEliminarRepuesto.Name = "btnEliminarRepuesto";
            this.btnEliminarRepuesto.Size = new System.Drawing.Size(29, 29);
            this.btnEliminarRepuesto.TabIndex = 41;
            this.btnEliminarRepuesto.Click += new System.EventHandler(this.btnEliminarRepuesto_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnModificar, "Modificar Repuesto");
            this.balloonTip1.SetBalloonText(this.btnModificar, null);
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnModificar.Location = new System.Drawing.Point(781, 236);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(29, 29);
            this.btnModificar.TabIndex = 40;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregarRepuesto
            // 
            this.btnAgregarRepuesto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnAgregarRepuesto, "Agregar Repuesto");
            this.balloonTip1.SetBalloonText(this.btnAgregarRepuesto, null);
            this.btnAgregarRepuesto.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarRepuesto.Image")));
            this.btnAgregarRepuesto.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnAgregarRepuesto.Location = new System.Drawing.Point(746, 236);
            this.btnAgregarRepuesto.Name = "btnAgregarRepuesto";
            this.btnAgregarRepuesto.Size = new System.Drawing.Size(29, 29);
            this.btnAgregarRepuesto.TabIndex = 39;
            this.btnAgregarRepuesto.Click += new System.EventHandler(this.btnAgregarRepuesto_Click);
            this.btnAgregarRepuesto.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.btnAgregarRepuesto_ControlRemoved);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.balloonTip1.SetBalloonCaption(this.btnImprimir, "Agregar Repuesto");
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnImprimir.Location = new System.Drawing.Point(711, 236);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(29, 29);
            this.btnImprimir.TabIndex = 43;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // unidadTiempoTableAdapter1
            // 
            this.unidadTiempoTableAdapter1.ClearBeforeFill = true;
            // 
            // cmbtiempo
            // 
            this.cmbtiempo.DataSource = this.dsSpx1;
            this.cmbtiempo.DisplayMember = "unidadTiempo.descripcion";
            this.cmbtiempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtiempo.FormattingEnabled = true;
            this.cmbtiempo.Location = new System.Drawing.Point(287, 79);
            this.cmbtiempo.Name = "cmbtiempo";
            this.cmbtiempo.Size = new System.Drawing.Size(152, 21);
            this.cmbtiempo.TabIndex = 42;
            this.cmbtiempo.ValueMember = "unidadTiempo.codUnidadTiempo";
            // 
            // clsTusuario1
            // 
            this.clsTusuario1.nombreLlave = "cod_usuario";
            this.clsTusuario1.nombreTabla = "usuario";
            this.clsTusuario1.sentenciaBase = resources.GetString("clsTusuario1.sentenciaBase");
            this.clsTusuario1.sentenciaBaseDistinct = null;
            // 
            // dsSPXSeguridad1
            // 
            this.dsSPXSeguridad1.DataSetName = "dsSPXSeguridad";
            this.dsSPXSeguridad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtConsecutivoGeneral
            // 
            this.txtConsecutivoGeneral.Location = new System.Drawing.Point(112, 12);
            this.txtConsecutivoGeneral.Name = "txtConsecutivoGeneral";
            this.txtConsecutivoGeneral.ReadOnly = true;
            this.txtConsecutivoGeneral.Size = new System.Drawing.Size(55, 20);
            this.txtConsecutivoGeneral.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Solitud Numero";
            // 
            // frmSolicitudInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(857, 566);
            this.Controls.Add(this.txtConsecutivoGeneral);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.cmbtiempo);
            this.Controls.Add(this.btnEliminarRepuesto);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregarRepuesto);
            this.Controls.Add(this.nmHorasDiagnostico);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grdDetalleSolicitud);
            this.Controls.Add(this.btnGrabarSalir);
            this.Controls.Add(this.txtNumeroSolicitud);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.txtTiempoEstimado);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.nmManteCorrectivo);
            this.Controls.Add(this.txtNumerofactura);
            this.Controls.Add(this.nmHorasMantenimientoPreventivo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnRechazar);
            this.Controls.Add(this.btnAprobar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSolicitudInsumos";
            this.Text = "Solicitudes Insumos";
            this.Load += new System.EventHandler(this.frmSolicitudInsumos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmHorasMantenimientoPreventivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmManteCorrectivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datecalFechaAprobacion)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleSolicitud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmHorasDiagnostico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPXSeguridad1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SPControladoraDatos.dsSpx dsSpx1;
        private SPControladoraDatos.dsSpxTableAdapters.detalleSolicitudInsumosTableAdapter detalleSolicitudInsumosTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.solicitudInsumosTableAdapter solicitudInsumosTableAdapter1;
        private SPControladoraDatos.dsSpxTableAdapters.repuestosTableAdapter repuestosTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkAceptada;
        private System.Windows.Forms.CheckBox chkCancelada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.Button btnRechazar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown nmHorasMantenimientoPreventivo;
        private System.Windows.Forms.TextBox txtNumerofactura;
        private System.Windows.Forms.NumericUpDown nmManteCorrectivo;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtTiempoEstimado;
        private System.Windows.Forms.TextBox txtAprobadaPor;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput datecalFechaAprobacion;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.TextBox txtNumeroSolicitud;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGrabarSalir;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid grdDetalleSolicitud;
        private SPControladoraDatos.dsSpxTableAdapters.pltDetalleSolicitudInsumosTableAdapter pltDetalleSolicitudInsumosTableAdapter1;
        private System.Windows.Forms.NumericUpDown nmHorasDiagnostico;
        private System.Windows.Forms.Label label9;
        private DevComponents.DotNetBar.ButtonX btnEliminarRepuesto;
        private DevComponents.DotNetBar.ButtonX btnModificar;
        private DevComponents.DotNetBar.ButtonX btnAgregarRepuesto;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private SPControladoraDatos.dsSpxTableAdapters.unidadTiempoTableAdapter unidadTiempoTableAdapter1;
        private System.Windows.Forms.ComboBox cmbtiempo;
        private DevComponents.DotNetBar.ButtonX btnImprimir;
        private SPXSeguridad.data.cls.clsTusuario clsTusuario1;
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad1;
        private System.Windows.Forms.TextBox txtConsecutivoGeneral;
        private System.Windows.Forms.Label label10;
    }
}