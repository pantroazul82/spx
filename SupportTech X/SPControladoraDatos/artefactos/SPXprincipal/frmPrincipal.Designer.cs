namespace SPControladoraDatos.artefactos.SPXprincipal
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.navigationPanePanel2 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.picLinea = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.cmbLinea = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnQuick1 = new DevComponents.DotNetBar.ButtonItem();
            this.btnQuick2 = new DevComponents.DotNetBar.ButtonItem();
            this.btnActualizarBotones = new DevComponents.DotNetBar.ButtonItem();
            this.btnHome = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.btnSalir = new DevComponents.DotNetBar.ButtonItem();
            this.navigationPane1 = new DevComponents.DotNetBar.NavigationPane();
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.VentanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineaTableAdapter1 = new SPXSeguridad.data.cls.clsTlinea();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLinea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.bar1.SuspendLayout();
            this.expandablePanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPanePanel2
            // 
            this.navigationPanePanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.navigationPanePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePanel2.Location = new System.Drawing.Point(1, 1);
            this.navigationPanePanel2.Name = "navigationPanePanel2";
            this.navigationPanePanel2.ParentItem = null;
            this.navigationPanePanel2.Size = new System.Drawing.Size(148, 147);
            this.navigationPanePanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.navigationPanePanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.navigationPanePanel2.Style.GradientAngle = 90;
            this.navigationPanePanel2.TabIndex = 3;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.picLinea);
            this.panelEx1.Controls.Add(this.picLogo);
            this.panelEx1.Controls.Add(this.bar1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 28);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1259, 74);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 5;
            // 
            // picLinea
            // 
            this.picLinea.Image = ((System.Drawing.Image)(resources.GetObject("picLinea.Image")));
            this.picLinea.Location = new System.Drawing.Point(4, 2);
            this.picLinea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picLinea.Name = "picLinea";
            this.picLinea.Size = new System.Drawing.Size(153, 69);
            this.picLinea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLinea.TabIndex = 4;
            this.picLinea.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo.Location = new System.Drawing.Point(1108, 30);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(147, 43);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            this.picLogo.Visible = false;
            // 
            // bar1
            // 
            this.bar1.AccessibleDescription = "bar1 (bar1)";
            this.bar1.AccessibleName = "bar1";
            this.bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.bar1.AntiAlias = true;
            this.bar1.BackColor = System.Drawing.Color.White;
            this.bar1.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.TopLeft;
            this.bar1.CanDockRight = false;
            this.bar1.CanReorderTabs = false;
            this.bar1.CanUndock = false;
            this.bar1.Controls.Add(this.cmbLinea);
            this.bar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bar1.DockSide = DevComponents.DotNetBar.eDockSide.Top;
            this.bar1.DockTabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Right;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnQuick1,
            this.btnQuick2,
            this.btnActualizarBotones,
            this.btnHome,
            this.itemContainer1});
            this.bar1.Location = new System.Drawing.Point(784, 0);
            this.bar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bar1.MenuBar = true;
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(475, 24);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 0;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // cmbLinea
            // 
            this.cmbLinea.DisplayMember = "cod_linea";
            this.cmbLinea.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLinea.FormattingEnabled = true;
            this.cmbLinea.ItemHeight = 21;
            this.cmbLinea.Location = new System.Drawing.Point(201, 0);
            this.cmbLinea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbLinea.Name = "cmbLinea";
            this.cmbLinea.Size = new System.Drawing.Size(265, 27);
            this.cmbLinea.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbLinea.TabIndex = 10001;
            this.cmbLinea.ValueMember = "cod_linea";
            this.cmbLinea.Visible = false;
            this.cmbLinea.SelectedIndexChanged += new System.EventHandler(this.cmbLinea_SelectedIndexChanged);
            // 
            // btnQuick1
            // 
            this.btnQuick1.Image = ((System.Drawing.Image)(resources.GetObject("btnQuick1.Image")));
            this.btnQuick1.ImageFixedSize = new System.Drawing.Size(17, 17);
            this.btnQuick1.Name = "btnQuick1";
            this.btnQuick1.Visible = false;
            this.btnQuick1.Click += new System.EventHandler(this.btnQuick1_Click);
            // 
            // btnQuick2
            // 
            this.btnQuick2.Image = ((System.Drawing.Image)(resources.GetObject("btnQuick2.Image")));
            this.btnQuick2.ImageFixedSize = new System.Drawing.Size(17, 17);
            this.btnQuick2.Name = "btnQuick2";
            this.btnQuick2.Visible = false;
            this.btnQuick2.Click += new System.EventHandler(this.btnQuick2_Click);
            // 
            // btnActualizarBotones
            // 
            this.btnActualizarBotones.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarBotones.Image")));
            this.btnActualizarBotones.ImageFixedSize = new System.Drawing.Size(17, 17);
            this.btnActualizarBotones.Name = "btnActualizarBotones";
            this.btnActualizarBotones.Text = "buttonItem1";
            this.btnActualizarBotones.Visible = false;
            this.btnActualizarBotones.Click += new System.EventHandler(this.btnActualizarBotones_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = global::SPControladoraDatos.Properties.Resources.Home_Page_2;
            this.btnHome.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnHome.Name = "btnHome";
            this.btnHome.Text = "Home";
            this.btnHome.Visible = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.Class = "";
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnSalir});
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // navigationPane1
            // 
            this.navigationPane1.ConfigureItemVisible = false;
            this.navigationPane1.Controls.Add(this.navigationPane1.TitlePanel);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPane1.ItemPaddingBottom = 2;
            this.navigationPane1.ItemPaddingTop = 2;
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.NavigationBarHeight = 38;
            this.navigationPane1.Padding = new System.Windows.Forms.Padding(1);
            this.navigationPane1.Size = new System.Drawing.Size(332, 534);
            this.navigationPane1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.navigationPane1.TabIndex = 6;
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel1.Controls.Add(this.navigationPane1);
            this.expandablePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.expandablePanel1.Location = new System.Drawing.Point(0, 102);
            this.expandablePanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(332, 534);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 7;
            this.expandablePanel1.Text = " ";
            this.expandablePanel1.TitleHeight = 32;
            this.expandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "Opciones Principales";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VentanaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.VentanaToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1259, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // VentanaToolStripMenuItem
            // 
            this.VentanaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator7,
            this.salirToolStripMenuItem});
            this.VentanaToolStripMenuItem.Name = "VentanaToolStripMenuItem";
            this.VentanaToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.VentanaToolStripMenuItem.Text = "&Formularios";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(110, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click_1);
            // 
            // lineaTableAdapter1
            // 
            this.lineaTableAdapter1.nombreLlave = "cod_linea";
            this.lineaTableAdapter1.nombreTabla = "linea";
            this.lineaTableAdapter1.sentenciaBase = "SELECT linea.cod_linea,linea.nombre_linea,linea.contacto_linea,linea.email_linea," +
    "linea.telefono_linea,linea.direccion_linea,linea.fax_linea,linea.logo FROM linea" +
    " ";
            this.lineaTableAdapter1.sentenciaBaseDistinct = "SELECT linea.cod_linea,linea.nombre_linea,linea.contacto_linea,linea.email_linea," +
    "linea.telefono_linea,linea.direccion_linea,linea.fax_linea,linea.logo FROM linea" +
    " ";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 636);
            this.Controls.Add(this.expandablePanel1);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrincipal";
            this.Text = "Formulario Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLinea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.bar1.ResumeLayout(false);
            this.expandablePanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel2;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.NavigationPane navigationPane1;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private DevComponents.DotNetBar.Bar bar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem VentanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private SPXSeguridad.data.cls.clsTlinea lineaTableAdapter1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbLinea;
        private DevComponents.DotNetBar.ButtonItem btnSalir;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picLinea;
        private DevComponents.DotNetBar.ButtonItem btnHome;
        private DevComponents.DotNetBar.ButtonItem btnActualizarBotones;
        private DevComponents.DotNetBar.ButtonItem btnQuick1;
        private DevComponents.DotNetBar.ButtonItem btnQuick2;
    }
}