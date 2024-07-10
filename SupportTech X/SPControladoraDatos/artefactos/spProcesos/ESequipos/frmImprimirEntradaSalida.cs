using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.ESequipos
{
    public partial class frmImprimirEntradaSalida : Form
    {
        public frmImprimirEntradaSalida()
        {
            InitializeComponent();
        }

        public int opcion { 
            get {
                int res = 1;
                if (rdEntrada.Checked) res = 1;
                else if (rdSalida.Checked) res = 2;
                else if (rdCompleta.Checked) res = 3;
                return res;
            } 
        }

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
