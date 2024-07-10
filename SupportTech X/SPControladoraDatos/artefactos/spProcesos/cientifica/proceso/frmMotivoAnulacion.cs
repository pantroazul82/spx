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
    public partial class frmMotivoAnulacion : Form
    {
        public frmMotivoAnulacion()
        {
            InitializeComponent();
        }

        public int codAsesoria { set; get; }

        private void frmMotivoAnulacion_Load(object sender, EventArgs e)
        {
            motivo_anulacion_cientificaTableAdapter1.Fill(dsSpx1.motivo_anulacion_cientifica);
            cmbMotivoAnulacion.SelectedValue = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if( cmbMotivoAnulacion.SelectedValue == null || cmbMotivoAnulacion.SelectedValue.ToString().Trim() == string.Empty )
            {
                MessageBox.Show("Seleccione el Motivo de Anulacion","Validacion");
                return;
            }
            //traemos el estado de anulacion
            estado_asesoria_cientificaTableAdapter1.FillByCod_manual(dsSpx1.estado_asesoria_cientifica, "5");
            asesoria_cientificaTableAdapter1.UpdateAnulada(
                dsSpx1.estado_asesoria_cientifica[0].cod_estado_asesoria_cientifica,
                int.Parse(cmbMotivoAnulacion.SelectedValue.ToString()),
                txtInfoAdicional.Text,
                codAsesoria);
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
