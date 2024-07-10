using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SPXSeguridad.licencias
{
    partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRegistrar fr = new frmRegistrar();
            fr.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormGenerador gr = new FormGenerador();
            gr.Show();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

            Verificador obj = new Verificador();
            txtHI.Text = obj.ghid();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSerial_Click(object sender, EventArgs e)
        {
            Verificador obj = new Verificador();
            try
            {
                txtSerial.Text = obj.generarSerial(txtHI.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardarSerial_Click(object sender, EventArgs e)
        {
            if (txtSerial.Text.Trim() == string.Empty) return;

            Verificador obj = new Verificador();
            obj.guardarSerial(txtSerial.Text);
            MessageBox.Show("Serial guardado con exito.");
        }
    }
}