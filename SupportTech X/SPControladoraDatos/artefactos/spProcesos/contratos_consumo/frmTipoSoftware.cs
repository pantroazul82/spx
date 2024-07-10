using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.contratos_consumo
{
    public partial class frmTipoSoftware : Form
    {
        public frmTipoSoftware()
        {
            InitializeComponent();
        }

        public int codTipoSoftware { set; get; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtTipoSoftware.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese el tipo de software");
                return;
            }
            
            if (codTipoSoftware == 0) {
                tipo_software_contrato_consumoTableAdapter1.Insert(txtTipoSoftware.Text);
            } else {
                tipo_software_contrato_consumoTableAdapter1.UpdateQuery(txtTipoSoftware.Text, codTipoSoftware);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmTipoSoftware_Load(object sender, EventArgs e)
        {
            if (codTipoSoftware != 0)
            {
                tipo_software_contrato_consumoTableAdapter1.FillBycod_tipo_software_contrato_consumo
                    (dsContratoConsumo1.tipo_software_contrato_consumo, codTipoSoftware);
                txtTipoSoftware.Text = dsContratoConsumo1.tipo_software_contrato_consumo[0].tipo_software_contrato_consumo.Trim();
            }
        }
    }
}
