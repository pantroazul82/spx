using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.llamadasTecnicas
{
    public partial class frmlImpresion : Form
    {
        public frmlImpresion()
        {
            InitializeComponent();
        }

        public int opcion = 0;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (rdSimple.Checked)
                opcion = 1;
            else
                opcion = 2;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
