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
    public partial class frmMotivoAnulacion : Form
    {
        public frmMotivoAnulacion()
        {
            InitializeComponent();
        }

        public int codMotivoAnulacion { set; get; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void frmMotivoAnulacion_Load(object sender, EventArgs e)
        {
            if (codMotivoAnulacion != 0)
            {
                motivo_anulacion_cientificaTableAdapter1.FillBycod_motivo_anulacion_cientifica(dsSpx1.motivo_anulacion_cientifica,
                    codMotivoAnulacion);
                txtMotivoAnulacion.Text = dsSpx1.motivo_anulacion_cientifica[0].motivo_anulacion.Trim();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (codMotivoAnulacion == 0)
            {
                motivo_anulacion_cientificaTableAdapter1.Insert(txtMotivoAnulacion.Text);
            }
            else {
                motivo_anulacion_cientificaTableAdapter1.UpdateQuery(txtMotivoAnulacion.Text, codMotivoAnulacion);
            }
            DialogResult = DialogResult.OK;
            Close();

        }
    }
}
