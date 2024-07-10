using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SPXSeguridad.licencias
{
    public partial class FormGenerador : Form
    {
        public FormGenerador()
        {
            InitializeComponent();
        }

        private bool controlarPassword = false;
        public bool ControlarPassword { set { controlarPassword = value; } get { return controlarPassword; } }


        private void btnGenerarSerial_Click(object sender, EventArgs e)
        {
            Verificador obj = new Verificador();
            try
            {
                txtSerial.Text = obj.generarSerial(txtHID.Text);
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

            frmPassword fr= new frmPassword();
            if (controlarPassword && fr.ShowDialog() != DialogResult.OK)
            {
                btnGenerarSerial.Enabled = false;
            }
              
        }
     
    }
}