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
    public partial class frmConsumoRequerido : Form
    {
        public frmConsumoRequerido()
        {
            InitializeComponent();
        }

        private void txtConsumoRequerido_TextChanged(object sender, EventArgs e)
        {
            
        }

        public int codDetalle { set; get; }
        public int codContrato { set; get; }

        private void txtConsumoRequerido_Validated(object sender, EventArgs e)
        {
            SPXUtilidades.clsFormato.formatoDinero(txtConsumoRequerido, false);
        }

        private void frmConsumoRequerido_Load(object sender, EventArgs e)
        {
            linea_consumoTableAdapter1.Fill(dsContratoConsumo1.linea_consumo);

            if (codDetalle != 0)
            {
                linea_consumoxcontrato_consumoTableAdapter1.FillBycod_linea_consumoxcontrato_consumo(dsContratoConsumo1.linea_consumoxcontrato_consumo, codDetalle);
                cmbLineaConsumo.SelectedValue = dsContratoConsumo1.linea_consumoxcontrato_consumo[0].cod_linea_consumo;
                txtConsumoRequerido.Text =( decimal.Round(dsContratoConsumo1.linea_consumoxcontrato_consumo[0].valor_exigido,0)).ToString();
                SPXUtilidades.clsFormato.formatoDinero(txtConsumoRequerido, false);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbLineaConsumo.SelectedValue == null || cmbLineaConsumo.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese la linea de consumo");
                return;
            }
            if (codDetalle == 0) {
                linea_consumoxcontrato_consumoTableAdapter1.Insert(int.Parse(cmbLineaConsumo.SelectedValue.ToString()), codContrato,
                    SPXUtilidades.clsFormato.formatoDineroToDecimal(txtConsumoRequerido.Text));
            } else {
                linea_consumoxcontrato_consumoTableAdapter1.UpdateQuery(int.Parse(cmbLineaConsumo.SelectedValue.ToString()),
                        SPXUtilidades.clsFormato.formatoDineroToDecimal(txtConsumoRequerido.Text), codDetalle);
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
