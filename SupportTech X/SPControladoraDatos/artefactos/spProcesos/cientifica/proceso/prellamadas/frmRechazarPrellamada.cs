using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.cientifica.proceso.prellamadas
{
    public partial class frmRechazarPrellamada : Form
    {
        public frmRechazarPrellamada()
        {
            InitializeComponent();
        }

        public int codLlamada { set; get; }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            llamadaSoportePreTableAdapter1.UpdateEstadoLLamadaTecnica("Rechazada", codLlamada);
            llamadaSoportePreTableAdapter1.UpdateObsFinales(txtMotivoRechazo.Text, codLlamada);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmRechazarPrellamada_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
