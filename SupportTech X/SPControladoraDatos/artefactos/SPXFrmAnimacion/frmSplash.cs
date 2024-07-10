using SPControladoraDatos.artefactos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SPXFrmAnimacion
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        public bool cerrar = false;
        public bool cargando = true;
        private void timer1_Tick(object sender, EventArgs e)
        {

            TopMost = true;
            Application.DoEvents();
            if (cargando)
            {
                this.Opacity += 0.04;
            }
            else {
                if (cerrar)
                {
                    this.Opacity -= 0.1;
                }
            }

            if ( this.Opacity >= 1)
            {
                cargando = false;
                Opacity = 1;
                System.Threading.Thread.Sleep(1000);
            }
            else if (this.Opacity <=0) {
                Opacity = 0;
                timer1.Enabled = false;
                Hide();
            }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            ajustar objFormResizer = new ajustar();
            objFormResizer.ResizeForm(this, Height, Width);

            TopMost = true;
            CenterToScreen();

            timer1.Enabled = true;
            Opacity = 0;
            Application.DoEvents();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
