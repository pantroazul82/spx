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
    public partial class frmTipoSoftwarexContrato : Form
    {
        public frmTipoSoftwarexContrato()
        {
            InitializeComponent();
        }

        public int codContrato { set; get; }
        public int codDetalle { set; get; }

        private void frmTipoSoftwarexContrato_Load(object sender, EventArgs e)
        {
            tipo_software_contrato_consumoTableAdapter1.Fill(dsContratoConsumo1.tipo_software_contrato_consumo);
            if (codDetalle != 0)
            {
                tipo_softwarexcontrato_consumoTableAdapter1.FillByCod_tipo_softwarexcontrato_consumo(dsContratoConsumo1.tipo_softwarexcontrato_consumo, codDetalle);
                cmbsoftware.SelectedValue = dsContratoConsumo1.tipo_softwarexcontrato_consumo[0].cod_tipo_software_contrato_consumo;
                txtObservaciones.Text = dsContratoConsumo1.tipo_softwarexcontrato_consumo[0].observaciones.Trim();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbsoftware.SelectedValue == null || cmbsoftware.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("El tiopo de software es obligatorio.");
                return;
            }

            if (codDetalle != 0)
            {
                tipo_softwarexcontrato_consumoTableAdapter1.UpdateQuery(int.Parse(cmbsoftware.SelectedValue.ToString()), codContrato, txtObservaciones.Text, codDetalle);
            }
            else {
                tipo_softwarexcontrato_consumoTableAdapter1.Insert(int.Parse(cmbsoftware.SelectedValue.ToString()), codContrato, txtObservaciones.Text);
            }
            DialogResult = DialogResult.OK;
            Close();

        }
    }
}
