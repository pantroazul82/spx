using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.cientifica.proceso
{
    public partial class frmSeleccioneAccionASeguir : Form
    {
        public frmSeleccioneAccionASeguir()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public int codAccionElegida { get { return int.Parse( cmbAccionSeguir.SelectedValue.ToString());} } 

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbAccionSeguir.SelectedValue == null || cmbAccionSeguir.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Seleccione la Accion a Seguir!");
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmSeleccioneAccionASeguir_Load(object sender, EventArgs e)
        {
            accion_seguir_cientificaTableAdapter1.Fill(dsSpx1.accion_seguir_cientifica);
        }
    }
}
