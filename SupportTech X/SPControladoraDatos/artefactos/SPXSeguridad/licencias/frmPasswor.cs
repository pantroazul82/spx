using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SPControladoraDatos.artefactos;

namespace SPXSeguridad.licencias
{
    public partial class frmPassword : Form
    {
        public frmPassword()
        {
            InitializeComponent();
        }


        private void frmRegistrar_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtPass.Text.Trim() == "electra69" || txtPass.Text.Trim() == "ftr1231")
            {
                DialogResult = DialogResult.OK;
                Close();
                return;
            }
            else
            {
                MessageBox.Show("password incorrecto");
            }
           
        }
    }
}