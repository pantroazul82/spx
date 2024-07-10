using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.cientifica
{
    public partial class frmAccionSeguir : Form
    {
        public frmAccionSeguir()
        {
            InitializeComponent();
        }

        public int codAccionSeguir { set; get; }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtAccionSeguir.Text.Trim() == string.Empty){
                MessageBox.Show("La accion a seguir es obligatoria!","Error de validacion");
            return;
            }
            if (codAccionSeguir == 0) {
                accion_seguir_cientificaTableAdapter1.Insert(txtAccionSeguir.Text,chkIndQc.Checked,chkIndVisita.Checked);
            } else {
                accion_seguir_cientificaTableAdapter1.UpdateQuery(txtAccionSeguir.Text,chkIndQc.Checked,chkIndVisita.Checked, codAccionSeguir);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void frmAccionSeguir_Load(object sender, EventArgs e)
        {
            if (codAccionSeguir != 0)
            {
                accion_seguir_cientificaTableAdapter1.FillBycod_accion_seguir_cientifica(
                    dsSpx1.accion_seguir_cientifica, codAccionSeguir);
                txtAccionSeguir.Text = dsSpx1.accion_seguir_cientifica[0].nombre_accion_seguir.Trim();
                if (!dsSpx1.accion_seguir_cientifica[0].Isind_visitaNull())
                chkIndVisita.Checked = dsSpx1.accion_seguir_cientifica[0].ind_visita;
                if (!dsSpx1.accion_seguir_cientifica[0].Isind_qcNull())
                    chkIndQc.Checked = dsSpx1.accion_seguir_cientifica[0].ind_qc;
            }
        }
    }
}
