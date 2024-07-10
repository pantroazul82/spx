using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.ordenPrestamo
{
    public partial class frmObservacionesxOrdenPrestamo : Form
    {
        public frmObservacionesxOrdenPrestamo()
        {
            InitializeComponent();
        }

        public string observacion { set { txtObservacion.Text = value; } get { return txtObservacion.Text; } }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}