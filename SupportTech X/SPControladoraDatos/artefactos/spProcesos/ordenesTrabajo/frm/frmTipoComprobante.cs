using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.ordenesTrabajo
{
    public partial class frmTipoComprobante : Form
    {
        public frmTipoComprobante()
        {
            InitializeComponent();
        }

        public string codTipoComprobante { get {
            string res = "";
            if(cmbTipoDeComprobante.SelectedValue != null)
                res=cmbTipoDeComprobante.SelectedValue.ToString();
            return res;
        }
        }

        public string NombreTipoComprobante
        {
            get
            {
                string res = "";
                if (cmbTipoDeComprobante.SelectedValue != null)
                    res = cmbTipoDeComprobante.Text;
                return res;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbTipoDeComprobante.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Escoja el tipo de comprobante");
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmTipoComprobante_Load(object sender, EventArgs e)
        {
            tipoComprobanteTableAdapter1.Fill(dsSpx1.tipoComprobante);
        }
    }
}
