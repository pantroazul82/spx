using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SPControladoraDatos.artefactos;

namespace SPXSeguridad.frm
{
    public partial class frmTipoDocumento : Form
    {
        public frmTipoDocumento()
        {
            InitializeComponent();
        }

        private bool validar() 
        {
            if (txtTipoDocumento.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese el tipo de documento!");
                return false;
            }
            if (txtAbreviatura.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese la abreviatura");
                return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!validar()) return;

            tipo_documentoTableAdapter1.Insert(txtTipoDocumento.Text, false, false, txtAbreviatura.Text);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void frmTipoDocumento_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);
        }
    }
}
