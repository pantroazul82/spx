using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;
using SPControladoraDatos.artefactos;
using SPXdata.BD;
using SPX2019.artefactos.SPXdata.frm;
using CGDataControler;

namespace SPXSeguridad
{
	/// <summary>
	/// Descripción breve de Form1.
	/// </summary>
	public class frmLogin : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBase;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ToolTip toolTip1;
		protected Label lblNombreSoftware;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.TextBox txtClave;
		private System.ComponentModel.IContainer components;
		private bool conEncripcion=true;
		public Image LOGO { set { imagenLogo.Image = value; lblVersion.Visible = false; imagenLogo.SizeMode = PictureBoxSizeMode.AutoSize; } }
		public bool mostrarLicencia { set { lblNombreSoftware.Visible = value; } }
		public bool mostrarLogo { set { imagenLogo.Visible = value; lblVersion.Visible = value; } }
		/// <summary>
		/// Indica el texto que se debe mostrar en la ventana de inicio
		/// </summary>
		public string tituloVentana { set { this.Text = value; }
			get { return this.Text; }
		}

        private static bool exigeCambioPassword = false;
        private static bool passwordFuerte = false;
        private static int diasCambioPassword = 0;
        public static bool ExigeCambioPassword { set { exigeCambioPassword = value; } get { return exigeCambioPassword; } }
        public static int DiasCambioPassword { set { diasCambioPassword = value; } get { return diasCambioPassword; } }
        public static bool PasswordFuerte { set { passwordFuerte = value; } get { return passwordFuerte; } }

		/// <summary>
		/// Indica si cuando la clave en la base de datos esta encriptada o esta en texto plano
		/// </summary>
		public bool ConEncripcion{set{conEncripcion=value;}get{return conEncripcion;}}
		private bool conEncripcionConfiguracion = true;
		protected PictureBox imagenLogo;
        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
		private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
		private DevComponents.DotNetBar.TabItem tabItem1;
		private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
		private DevComponents.DotNetBar.TabItem Configuracion;
		private DevComponents.DotNetBar.ButtonX btnTheme;
		private DevComponents.DotNetBar.ButtonX btnCnn;
		protected PictureBox pictureBox1;
        private DevComponents.DotNetBar.ButtonX btnAcercaDe;
        protected Label lblVersion;
		private System.Data.DataSet dataSet1;
		private System.Data.DataTable tablaConexiones;
		private System.Data.DataColumn dataColumn1;
		private System.Data.DataColumn dataColumn2;
		private System.Data.DataColumn dataColumn3;
		private System.Data.DataColumn dataColumn4;
		private System.Data.DataColumn dataColumn5;
		private System.Data.DataColumn dataColumn6;
		private System.Data.DataColumn dataColumn7;
		private System.Data.DataColumn dataColumn8;
		private System.Data.DataColumn dataColumn9;
		private System.Data.DataColumn dataColumn10;
		private System.Data.DataColumn dataColumn11;
        private Button button1;
        private Button btnIngresar2;

        /// <summary>
        /// Indica si cuando la clave que se carga del en la base de datos esta encriptada o esta en texto plano
        /// de estar encriptada debe estarlo con el algoritmo rindael
        /// </summary>
        public bool ConEncripcionConfig{set{conEncripcionConfiguracion =value;}get{return conEncripcionConfiguracion;}}
		
		private string usuario="none";
		
		/// <summary>
		/// Me indica el login del usuario que se registro en el sistema.
		/// si el usuario es none significa que no se ha iniciado una session.
		/// </summary>
		public string Usuario{set{usuario=value;}get{return usuario;}}

		/// <summary>
		/// Constructor
		/// </summary>
		public frmLogin()
		{   
			InitializeComponent();
		}

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBase = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblNombreSoftware = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.imagenLogo = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnAcercaDe = new DevComponents.DotNetBar.ButtonX();
            this.btnTheme = new DevComponents.DotNetBar.ButtonX();
            this.btnCnn = new DevComponents.DotNetBar.ButtonX();
            this.Configuracion = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnIngresar2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.dataSet1 = new System.Data.DataSet();
            this.tablaConexiones = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.imagenLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel2.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaConexiones)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Clave";
            // 
            // comboBase
            // 
            this.comboBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBase.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBase.Location = new System.Drawing.Point(195, 16);
            this.comboBase.Name = "comboBase";
            this.comboBase.Size = new System.Drawing.Size(334, 22);
            this.comboBase.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Conexion";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 15000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 100;
            // 
            // lblNombreSoftware
            // 
            this.lblNombreSoftware.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreSoftware.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSoftware.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblNombreSoftware.Location = new System.Drawing.Point(-3, 188);
            this.lblNombreSoftware.Name = "lblNombreSoftware";
            this.lblNombreSoftware.Size = new System.Drawing.Size(312, 17);
            this.lblNombreSoftware.TabIndex = 23;
            this.lblNombreSoftware.Text = "© Kuxan 2020";
            this.lblNombreSoftware.Visible = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(195, 48);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(334, 22);
            this.txtUsuario.TabIndex = 26;
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(195, 76);
            this.txtClave.MaxLength = 20;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(334, 22);
            this.txtClave.TabIndex = 27;
            this.txtClave.UseSystemPasswordChar = true;
            // 
            // imagenLogo
            // 
            this.imagenLogo.BackColor = System.Drawing.Color.Transparent;
            this.imagenLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.imagenLogo.Image = ((System.Drawing.Image)(resources.GetObject("imagenLogo.Image")));
            this.imagenLogo.Location = new System.Drawing.Point(-3, 3);
            this.imagenLogo.Name = "imagenLogo";
            this.imagenLogo.Size = new System.Drawing.Size(130, 104);
            this.imagenLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagenLogo.TabIndex = 1;
            this.imagenLogo.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Controls.Add(this.tabControlPanel2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 1;
            this.tabControl1.Size = new System.Drawing.Size(573, 286);
            this.tabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.VS2005Document;
            this.tabControl1.TabIndex = 29;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItem1);
            this.tabControl1.Tabs.Add(this.Configuracion);
            this.tabControl1.Text = "tabControl1";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.lblVersion);
            this.tabControlPanel2.Controls.Add(this.btnAcercaDe);
            this.tabControlPanel2.Controls.Add(this.btnTheme);
            this.tabControlPanel2.Controls.Add(this.btnCnn);
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(573, 260);
            this.tabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(250)))), ((int)(((byte)(247)))));
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 2;
            this.tabControlPanel2.TabItem = this.Configuracion;
            // 
            // lblVersion
            // 
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Location = new System.Drawing.Point(12, 226);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(375, 13);
            this.lblVersion.TabIndex = 29;
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAcercaDe.Image = ((System.Drawing.Image)(resources.GetObject("btnAcercaDe.Image")));
            this.btnAcercaDe.ImageFixedSize = new System.Drawing.Size(44, 44);
            this.btnAcercaDe.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAcercaDe.Location = new System.Drawing.Point(166, 4);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Size = new System.Drawing.Size(75, 79);
            this.btnAcercaDe.TabIndex = 2;
            this.btnAcercaDe.Text = "Acerca de";
            this.btnAcercaDe.Visible = false;
            this.btnAcercaDe.Click += new System.EventHandler(this.btnAcercaDe_Click);
            // 
            // btnTheme
            // 
            this.btnTheme.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTheme.Image = ((System.Drawing.Image)(resources.GetObject("btnTheme.Image")));
            this.btnTheme.ImageFixedSize = new System.Drawing.Size(44, 44);
            this.btnTheme.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnTheme.Location = new System.Drawing.Point(85, 4);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.Size = new System.Drawing.Size(75, 79);
            this.btnTheme.TabIndex = 1;
            this.btnTheme.Text = "Estilos Visuales";
            this.btnTheme.Click += new System.EventHandler(this.btnTheme_Click);
            // 
            // btnCnn
            // 
            this.btnCnn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCnn.Image = ((System.Drawing.Image)(resources.GetObject("btnCnn.Image")));
            this.btnCnn.ImageFixedSize = new System.Drawing.Size(44, 44);
            this.btnCnn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCnn.Location = new System.Drawing.Point(4, 4);
            this.btnCnn.Name = "btnCnn";
            this.btnCnn.Size = new System.Drawing.Size(75, 79);
            this.btnCnn.TabIndex = 0;
            this.btnCnn.Text = "Cadenas de Conexion";
            this.btnCnn.Click += new System.EventHandler(this.btnCnn_Click);
            // 
            // Configuracion
            // 
            this.Configuracion.AttachedControl = this.tabControlPanel2;
            this.Configuracion.Name = "Configuracion";
            this.Configuracion.Text = "Configuracion";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.groupPanel1);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(573, 260);
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(250)))), ((int)(((byte)(247)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabItem1;
            this.tabControlPanel1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.pictureBox1);
            this.groupPanel1.Controls.Add(this.btnIngresar2);
            this.groupPanel1.Controls.Add(this.button1);
            this.groupPanel1.Controls.Add(this.lblNombreSoftware);
            this.groupPanel1.Controls.Add(this.txtUsuario);
            this.groupPanel1.Controls.Add(this.comboBase);
            this.groupPanel1.Controls.Add(this.txtClave);
            this.groupPanel1.Controls.Add(this.label4);
            this.groupPanel1.Controls.Add(this.label2);
            this.groupPanel1.Controls.Add(this.imagenLogo);
            this.groupPanel1.Controls.Add(this.label3);
            this.groupPanel1.Location = new System.Drawing.Point(15, 16);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(548, 223);
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
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "Informacion de Cuenta";
            // 
            // btnIngresar2
            // 
            this.btnIngresar2.Location = new System.Drawing.Point(346, 134);
            this.btnIngresar2.Name = "btnIngresar2";
            this.btnIngresar2.Size = new System.Drawing.Size(88, 46);
            this.btnIngresar2.TabIndex = 30;
            this.btnIngresar2.Text = "Ingresar";
            this.btnIngresar2.UseVisualStyleBackColor = true;
            this.btnIngresar2.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 46);
            this.button1.TabIndex = 25;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel1;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "Login   ";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.tablaConexiones});
            // 
            // tablaConexiones
            // 
            this.tablaConexiones.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11});
            this.tablaConexiones.TableName = "tablaConexiones";
            // 
            // dataColumn1
            // 
            this.dataColumn1.Caption = "Tipo";
            this.dataColumn1.ColumnName = "tipo_cnn";
            // 
            // dataColumn2
            // 
            this.dataColumn2.Caption = "Conexion";
            this.dataColumn2.ColumnName = "nombre_conexion";
            // 
            // dataColumn3
            // 
            this.dataColumn3.Caption = "Login";
            this.dataColumn3.ColumnName = "login";
            // 
            // dataColumn4
            // 
            this.dataColumn4.Caption = "password";
            this.dataColumn4.ColumnName = "password";
            // 
            // dataColumn5
            // 
            this.dataColumn5.Caption = "Servidor";
            this.dataColumn5.ColumnName = "servidor";
            // 
            // dataColumn6
            // 
            this.dataColumn6.Caption = "base de datos";
            this.dataColumn6.ColumnName = "base_datos";
            // 
            // dataColumn7
            // 
            this.dataColumn7.Caption = "puerto";
            this.dataColumn7.ColumnName = "puerto";
            // 
            // dataColumn8
            // 
            this.dataColumn8.Caption = "Sid";
            this.dataColumn8.ColumnName = "sid";
            // 
            // dataColumn9
            // 
            this.dataColumn9.Caption = "Conexion Directa";
            this.dataColumn9.ColumnName = "conexion_directa";
            // 
            // dataColumn10
            // 
            this.dataColumn10.Caption = "tipo cnn Oracle";
            this.dataColumn10.ColumnName = "tipo_cnn_oracle";
            // 
            // dataColumn11
            // 
            this.dataColumn11.Caption = "Time Out";
            this.dataColumn11.ColumnName = "time_out";
            // 
            // frmLogin
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(573, 286);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(376, 270);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Acceso";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmLoginCombo_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.imagenLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel2.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaConexiones)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		public System.Data.DataTable cargarCnn() 
		{
			if (DesignMode) return null;
			
			string ruta = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
			if (!System.IO.Directory.Exists(ruta + @"\data"))
			{
				System.IO.Directory.CreateDirectory(ruta + @"\data");
			}
			//cargamos el archivo
			if (System.IO.File.Exists(ruta + @"\data\cnn.xml"))
			{
				tablaConexiones.Clear();
			   tablaConexiones.ReadXml(ruta + @"\data\cnn.xml");
			}
			return tablaConexiones;
		}

		private void cargarCombo() 
		{
			if (DesignMode) return;
			try
			{
				comboBase.Items.Clear();
				System.Data.DataTable tabla = cargarCnn();
				if (tabla.Rows.Count > 1)
				{
					comboBase.Visible = true;
					label4.Visible = true;
					//cargamos el combo de bases
					int k = tabla.Rows.Count;

					for (int j = 0; j < k; j++)
					{
						comboBase.Items.Add(tabla.Rows[j]["nombre_conexion"].ToString());
					}

					if (SPControladoraDatos.Properties.Settings.Default.posicionCombo<tabla.Rows.Count)
					comboBase.SelectedIndex = SPControladoraDatos.Properties.Settings.Default.posicionCombo;
					txtUsuario.Text = SPControladoraDatos.Properties.Settings.Default.usuarioAutenticado;
					txtUsuario.Focus();
				}else{
					comboBase.Visible = false;
					label4.Visible = false;
					txtUsuario.Text = SPControladoraDatos.Properties.Settings.Default.usuarioAutenticado;
					txtUsuario.Focus();
				}
			}
			catch (Exception ex)
			{
				System.IO.File.Delete("basewcgActiva.xpp");
			  if(  MessageBox.Show("Error al cargar la aplicacion compruebe que el archivo de configuracion XML este en un formato valido!\nDesea ver informacion mas detallada","Error de Configuracion", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
				== DialogResult.Yes){
				MessageBox.Show(ex.Message, "Informacion detallada!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
                SPControladoraDatos.Properties.Settings.Default.posicionCombo = 0;
                SPControladoraDatos.Properties.Settings.Default.Save();
				btnIngresar2.Enabled = false;
				this.txtClave.Enabled = false;
				this.txtUsuario.Enabled = false;
				this.comboBase.Enabled = false;
			}
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            ajustar objFormResizer = new ajustar();
            objFormResizer.ResizeForm(this, Height, Width);

            this.Visible = false;
			DateTime Inicio = DateTime.Now;
			// simulating operations at startup
			//System.Threading.Thread.Sleep(SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsSplash.timeSplash);
			
			#region cargamos el icono y los valores x defecto
			if (SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.parametrosSoftware.nombreSoftware != null && SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.parametrosSoftware.nombreSoftware.Trim() != string.Empty)
			{
				this.Text = "Control de Acceso - "+SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.parametrosSoftware.nombreSoftware;
			}
			if (SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.parametrosSoftware.iconoSoftware != null)
			{
				this.Icon = SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.parametrosSoftware.iconoSoftware;
			}
			if (SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.parametrosSoftware.logotipoSoftware != null)
			{
				imagenLogo.Image = SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.parametrosSoftware.logotipoSoftware;
			}
			#endregion
			#region zona de cargar el combo y el label de version
			cargarCombo();
			//le ponemos a la version
			tabControl1.SelectedTabIndex = 0;
			if (!DesignMode)
			{
                SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsUtilidadesReflection objReflection = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsUtilidadesReflection();
				DateTime uc = objReflection.verUltimaModificacion();
				lblVersion.Text = "Ultimo Cambio: " + verMes(uc.Month) + " " + uc.Day + @" del " + uc.Year;
			}
			#endregion

			//mensaje resolucion
			int x = Screen.PrimaryScreen.Bounds.Height;
			int y = Screen.PrimaryScreen.Bounds.Width;
			if (x < 768 && y < 1024)
				MessageBox.Show("Este Programa funciona mejor con resoluciones superiores a 1024 x 768\n te recomiendo cambies la resolucion por una mayor.", "Resolucion de Pantalla", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Visible = true;
			this.Activate();
		}
	
		private string verMes(int mes)
		{
			if (DesignMode) return "";
			string respuesta = "";
			switch (mes) 
			{
				case 1: { respuesta = "Enero";break; }
					case 2: { respuesta = "Febrero";break; }
					case 3: { respuesta = "Marzo";break; }
					case 4: { respuesta = "Abril";break; }
					case 5: { respuesta = "Mayo";break; }
					case 6: { respuesta = "Junio";break; }
					case 7: { respuesta = "Julio";break; }
					case 8: { respuesta = "Agosto";break; }
					case 9: { respuesta = "Septiembre";break; }
					case 10: { respuesta = "Octubre";break; }
					case 11: { respuesta = "Noviembre";break; }
					case 12: { respuesta = "Diciembre";break; }
			}
			return respuesta;
		}
		
		private void btnSalir_Click(object sender, System.EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		/// <summary>
		/// Realiza el efecto cuando se esta cerrando la ventana.
		/// </summary>
		private void ocultarForm()
		{
			if (DesignMode) return;
			while (this.Opacity > 0.1)
			{
				System.Threading.Thread.Sleep(80);
				this.Opacity -= 0.1;

				Application.DoEvents();
			}
		}

  

		private void aceptar()
		{
			try
			{
				usuario = txtUsuario.Text.Trim();
				if (!cargarValoresConexion()) return;
				DataConector objData = new DataConector();
				SPXSeguridad.cnn.cargarConexion(objData.CadenaConexion);
				SPXSeguridad.Login ctrAcceso = new Login();
				string mensaje = "";
                //en esta seccion deben poner las vaidaciones de licencia y de numero de usuarios
             

                if (ctrAcceso.autenticar(txtUsuario.Text,txtClave.Text,ref mensaje))
				{
                    //si logor logearse y tine activada la opcion de cambiar de password 
                    if (exigeCambioPassword && diasCambioPassword >0)
                    {
                        objData.forzarCadenaConexion(objData.CadenaConexion);
                        object c=objData.ejecutarProcedimiento("select DATEDIFF(day,fecha_cambio_password,GETDATE()) dia from usuario where login='" + txtUsuario.Text + "'");
                        if (c != null && c != System.DBNull.Value)
                        {
                            int dias = int.Parse(c.ToString());
                            if(dias > diasCambioPassword)
                            {
                            //lanzamos el formulario para que cambie el password
                                MessageBox.Show("Por politicas de seguridad el password debe cambiarse cada " + diasCambioPassword + " dias, su password no se cambia hace " + dias + " dias, debe cambiar su password inmendiatamente.");
                                frm.frmSeleccionarPassword fr = new frm.frmSeleccionarPassword();
                                fr.password = null;
                                if (fr.ShowDialog() != DialogResult.OK)
                                {
                                    return;
                                }
                                if (txtClave.Text == fr.password) {
                                    MessageBox.Show("el password nuevo y el anterior no deben ser iguales.");
                                    return;
                                }
                                SPXSeguridad.data.cls.clsTusuario usuariox = new SPXSeguridad.data.cls.clsTusuario();

                                Login l = new Login();
                                string pass = l.cifrarPassword(fr.password);
                                usuariox.UpdatePassword(pass, DateTime.Now, int.Parse(objData.ejecutarProcedimiento("select top 1 cod_usuario from usuario where login='" + txtUsuario.Text + "'").ToString()));
                            }
                        }
                    }
                    #region guardamos cual es la base activa y el usuario

                    SPControladoraDatos.Properties.Settings.Default.usuarioAutenticado = txtUsuario.Text;
                    SPControladoraDatos.Properties.Settings.Default.posicionCombo = comboBase.SelectedIndex;
                    SPControladoraDatos.Properties.Settings.Default.Save();
					#endregion
					string app = System.IO.Path.GetFileNameWithoutExtension(Application.ExecutablePath);
					ctrAcceso.RegistrarIngreso(txtUsuario.Text.Trim(), Application.ProductVersion, app);
					ocultarForm();
					this.DialogResult = DialogResult.OK;
					Close();
				}
				else
				{
					Usuario = "none";
					MessageBox.Show("Acceso No permitido\n" + mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					txtClave.Focus();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al ejecutar la accion, compruebe que el archivo de configuracin xml tenga valores validos\nNo olvide que el password de la base de datos debe estar cifrado.\ninformacion tecnica del error: " + ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
			}
		}

		/// <summary>
		/// Carga los valores de la cadena de conexion con la cual el aplicativo va a trabajar.
		/// </summary>
		private bool cargarValoresConexion()
		{
			if (DesignMode) return false;
			int pos = this.comboBase.SelectedIndex;
			int time = 0;
			System.Data.DataTable tabla = cargarCnn();
			if (tabla.Rows.Count <= 0)
			{
				MessageBox.Show("No tiene ninguna cadena de conexion configurada.","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				return false;
			}
			if (pos == -1) pos = 0;
            SPControladoraDatos.Properties.Settings.Default.posicionCombo = pos;
            SPControladoraDatos.Properties.Settings.Default.Save();

			DataConector.Login = tabla.Rows[pos]["login"].ToString();
			DataConector.Password = tabla.Rows[pos]["password"].ToString();
			DataConector.Servidor = tabla.Rows[pos]["servidor"].ToString();
			DataConector.BaseDatos = tabla.Rows[pos]["base_datos"].ToString();

			int.TryParse(tabla.Rows[pos]["time_out"].ToString(), out  time);
			DataConector.Time_out = time;

			if (tabla.Rows[pos]["tipo_cnn"].ToString().ToUpper() == "MYSQL")
			{
				DataConector.Tipo =DataConector.tipoMotor.mysql;
			}
			else if (tabla.Rows[pos]["tipo_cnn"].ToString() == "SQLSERVER")
			{
				DataConector.Tipo =DataConector.tipoMotor.SQLserver;
			}
			else if (tabla.Rows[pos]["tipo_cnn"].ToString() == "ORACLE")
			{
				DataConector.Tipo =DataConector.tipoMotor.oracle;
			}
			else if (tabla.Rows[pos]["tipo_cnn"].ToString() == "POSTGRESS")
			{
				DataConector.Tipo =DataConector.tipoMotor.postgress;
			}
			DataConector.Puerto = tabla.Rows[pos]["puerto"].ToString();
			
			//oracle
			if (tabla.Rows[pos]["tipo_cnn_oracle"].ToString().ToLower() == "normal")
			{
				DataConector._TipoCnnOracle =DataConector.tipoCnnOracle.normal;
			}
			else if (tabla.Rows[pos]["tipo_cnn_oracle"].ToString().ToLower() == "sysdba")
			{
				DataConector._TipoCnnOracle =DataConector.tipoCnnOracle.sysdba;
			}
			else if (tabla.Rows[pos]["tipo_cnn_oracle"].ToString().ToLower() == "sysoper")
			{
				DataConector._TipoCnnOracle =DataConector.tipoCnnOracle.sysoper;
			}
			DataConector.Sid = tabla.Rows[pos]["sid"].ToString();

			DataConector.ConexionDirecta = (tabla.Rows[pos]["conexion_directa"].ToString() == "1");

			
			if (ConEncripcionConfig)
			{
                SPXSeguridad.Cryptografia.CryptoRijndael objTmp = new SPXSeguridad.Cryptografia.CryptoRijndael();
				if (DataConector.Password.Trim() != string.Empty)
					DataConector.Password = objTmp.DesEncriptar(DataConector.Password, "CGSF");
			}
			
			return true;
		}

		/// <summary>
		/// Carga los valores de la cadena de conexion con la cual el aplicativo va a trabajar.
		/// </summary>
		public bool cargarValoresConexion(int pos)
		{
			if (pos < 0) return false;

			if (DesignMode) return false;
			int time = 0;
			System.Data.DataTable tabla = cargarCnn();
			if (tabla.Rows.Count <= 0)
			{
				MessageBox.Show("No tiene ninguna cadena de conexion configurada.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			if (pos == -1) pos = 0;
            SPControladoraDatos.Properties.Settings.Default.posicionCombo = pos;
            SPControladoraDatos.Properties.Settings.Default.Save();

			DataConector.Login = tabla.Rows[pos]["login"].ToString();
			DataConector.Password = tabla.Rows[pos]["password"].ToString();
			DataConector.Servidor = tabla.Rows[pos]["servidor"].ToString();
			DataConector.BaseDatos = tabla.Rows[pos]["base_datos"].ToString();

			int.TryParse(tabla.Rows[pos]["time_out"].ToString(), out  time);
			DataConector.Time_out = time;

			if (tabla.Rows[pos]["tipo_cnn"].ToString().ToUpper() == "MYSQL")
			{
				DataConector.Tipo =DataConector.tipoMotor.mysql;
			}
			else if (tabla.Rows[pos]["tipo_cnn"].ToString() == "SQLSERVER")
			{
				DataConector.Tipo =DataConector.tipoMotor.SQLserver;
			}
			else if (tabla.Rows[pos]["tipo_cnn"].ToString() == "ORACLE")
			{
				DataConector.Tipo =DataConector.tipoMotor.oracle;
			}
			else if (tabla.Rows[pos]["tipo_cnn"].ToString() == "POSTGRESS")
			{
				DataConector.Tipo =DataConector.tipoMotor.postgress;
			}
			DataConector.Puerto = tabla.Rows[pos]["puerto"].ToString();

			//oracle
			if (tabla.Rows[pos]["tipo_cnn_oracle"].ToString().ToLower() == "normal")
			{
				DataConector._TipoCnnOracle =DataConector.tipoCnnOracle.normal;
			}
			else if (tabla.Rows[pos]["tipo_cnn_oracle"].ToString().ToLower() == "sysdba")
			{
				DataConector._TipoCnnOracle =DataConector.tipoCnnOracle.sysdba;
			}
			else if (tabla.Rows[pos]["tipo_cnn_oracle"].ToString().ToLower() == "sysoper")
			{
				DataConector._TipoCnnOracle =DataConector.tipoCnnOracle.sysoper;
			}
			DataConector.Sid = tabla.Rows[pos]["sid"].ToString();

			DataConector.ConexionDirecta = (tabla.Rows[pos]["conexion_directa"].ToString() == "1");


			if (ConEncripcionConfig)
			{
				SPXSeguridad.Cryptografia.CryptoRijndael objTmp = new SPXSeguridad.Cryptografia.CryptoRijndael();
				if (DataConector.Password.Trim() != string.Empty)
					DataConector.Password = objTmp.DesEncriptar(DataConector.Password, "CGSF");
			}

			return true;
		}



		private void frmLoginCombo_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (DesignMode) return;
			if(e.KeyChar == (char)13)
			{
				aceptar();
			}
		}

		private void btnCnn_Click(object sender, EventArgs e)
		{
			if (DesignMode) return;
            frmConfiguraCnn frm = new frmConfiguraCnn();
			frm.Icon = this.Icon;            
			if (frm.ShowDialog() == DialogResult.OK)
			{                
				cargarCombo();
			}
		}

		private void btnTheme_Click(object sender, EventArgs e)
		{
			if (DesignMode) return;
            SPControladoraDatos.artefactos.SPXUtilidades.Themes.FrmPersonalizar frm = new SPControladoraDatos.artefactos.SPXUtilidades.Themes.FrmPersonalizar(); 
			frm.Icon = this.Icon;
			if (frm.ShowDialog() == DialogResult.OK)
			{
				Invalidate();
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			if (DesignMode) return;
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void btnIngresar_Click(object sender, EventArgs e)
		{
			if (DesignMode) return;
			aceptar();
		}

		private void btnAcercaDe_Click(object sender, EventArgs e)
		{
			if (DesignMode) return;
            SPXSeguridad.frm.utilidades.frmAbout fr = new SPXSeguridad.frm.utilidades.frmAbout();
			fr.ShowDialog();
		}

	}
}
