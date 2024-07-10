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
    public partial class frmLineasConsumo : Form
    {
        public frmLineasConsumo()
        {
            InitializeComponent();
        }
        public int codLineaConsumo { set; get; }
        private void frmLineasConsumo_Load(object sender, EventArgs e)
        {
            if (codLineaConsumo != 0)
            {
                linea_consumoTableAdapter1.FillByCod_linea_consumo(dsContratoConsumo1.linea_consumo, codLineaConsumo);
                txtModalidadContrato.Text = dsContratoConsumo1.linea_consumo[0].nombre_linea_consumo.Trim();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtModalidadContrato.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese la linea de consumo");
                return;
            }
            if (codLineaConsumo == 0)
            {
                linea_consumoTableAdapter1.Insert(txtModalidadContrato.Text.Trim());
            }
            else {
                linea_consumoTableAdapter1.UpdateQuery(txtModalidadContrato.Text, codLineaConsumo);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
