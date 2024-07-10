using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.generales.newFormat
{
    public partial class frmMotivoSalida : Form
    {
        public frmMotivoSalida()
        {
            InitializeComponent();
        }

        public int codMotivoSalida { set; get; }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtMotivoSalida.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El motivo de salida es obligatorio!");
                return;
            }
            if (codMotivoSalida == 0)
            {
                motivo_salidaTableAdapter1.Insert(txtMotivoSalida.Text);
            }
            else {
                motivo_salidaTableAdapter1.UpdateMotivoSalida(txtMotivoSalida.Text,codMotivoSalida);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmMotivoSalida_Load(object sender, EventArgs e)
        {
            if (codMotivoSalida != 0)
            {
                motivo_salidaTableAdapter1.FillByCod_motivo_salida(dsSpx1.motivo_salida, codMotivoSalida);
                if (dsSpx1.motivo_salida.Count > 0)
                {
                    txtMotivoSalida.Text = dsSpx1.motivo_salida[0].nombre_motivo_salida;
                    txtCodigoMotivoSalida.Text = codMotivoSalida.ToString();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
