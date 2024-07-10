using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SPXFrmAnimacion
{
	/// <summary>
	/// Descripci�n breve de FormCargando.
	/// </summary>
	public class FormCargando : System.Windows.Forms.Form
	{
		/// <summary>
		/// Variable del dise�ador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label lblInfo;
		private bool Activo=true;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Button ribbonButton1;
        private Button btnCancelar;
		private System.Windows.Forms.PictureBox pictureBox4;
        private bool mostrarcancelar = false;
        public bool MostrarCancelar { set { mostrarcancelar = value; } get { return mostrarcancelar; } }
        private bool cancelo = false;
        public bool Cancelo { set { cancelo = value; } get { return cancelo; } }

		public FormCargando()
		{
			//
			// Necesario para admitir el Dise�ador de Windows Forms
			//
			InitializeComponent();

			//
			// TODO: agregar c�digo de constructor despu�s de llamar a InitializeComponent
			//
		}

		/// <summary>
		/// Limpiar los recursos que se est�n utilizando.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region C�digo generado por el Dise�ador de Windows Forms
		/// <summary>
		/// M�todo necesario para admitir el Dise�ador. No se puede modificar
		/// el contenido del m�todo con el editor de c�digo.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCargando));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ribbonButton1 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 56);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(245, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 56);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Black;
            this.lblInfo.Location = new System.Drawing.Point(95, 68);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(127, 27);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Cargando";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(62, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 47);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(62, 18);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 47);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.FlatAppearance.BorderSize = 0;
            this.ribbonButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ribbonButton1.Font = new System.Drawing.Font("Calibri", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonButton1.Location = new System.Drawing.Point(124, -5);
            this.ribbonButton1.Name = "ribbonButton1";
            this.ribbonButton1.Size = new System.Drawing.Size(69, 23);
            this.ribbonButton1.TabIndex = 8;
            this.ribbonButton1.Text = "Cerrar";
            this.ribbonButton1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ribbonButton1.UseVisualStyleBackColor = true;
            this.ribbonButton1.Click += new System.EventHandler(this.ribbonButton1_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(116, 93);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 24);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormCargando
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.BackColor = System.Drawing.Color.White;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(316, 139);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.ribbonButton1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCargando";
            this.Opacity = 0.75D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargando";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormCargando_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        public string texto { get { return lblInfo.Text; } set { lblInfo.Text = value; } }
        
        private void FormCargando_Load(object sender, System.EventArgs e)
		{
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

            if (mostrarcancelar) btnCancelar.Visible = true;
		}

		public void animacion()
		{
			while(Activo)
			{		
					if(lblInfo.ForeColor == Color.Black)
					{
						lblInfo.ForeColor=Color.Red;
					}
					else{
						lblInfo.ForeColor=Color.Black;
					}
				pictureBox4.Left+=5;
				pictureBox3.Left+=5;
		
				if(pictureBox4.Left> (this.Size.Width/2)-(pictureBox4.Size.Width/2))
				{
					pictureBox4.Visible=false;
					pictureBox3.Visible=true;
				}
				if(pictureBox3.Left+pictureBox3.Size.Width >pictureBox2.Left){
					pictureBox4.Visible=true;
					pictureBox3.Visible=false;
					pictureBox4.Left = pictureBox1.Left+pictureBox1.Size.Width;
					pictureBox3.Left = pictureBox1.Left+pictureBox1.Size.Width;
				}

				
				Application.DoEvents();
				System.Threading.Thread.Sleep(120);
			}
			this.Close();
		}

        public void animacionEnd()
        {
            Activo = false;
        }

        private void ribbonButton1_Click_1(object sender, EventArgs e)
        {
            animacionEnd();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelo = true;
            animacionEnd();
        }
	}
}
