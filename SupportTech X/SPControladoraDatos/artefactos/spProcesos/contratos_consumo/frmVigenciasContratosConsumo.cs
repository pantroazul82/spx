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
    public partial class frmVigenciasContratosConsumo : Form
    {
        public frmVigenciasContratosConsumo()
        {
            InitializeComponent();
        }

        public int codVigencia { set; get; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtContratosConsumo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese la vigencia");
                return;
            }
            if (codVigencia == 0)
            {
                vigencias_contrato_consumoTableAdapter1.Insert(txtContratosConsumo.Text);
            
            }else{
                vigencias_contrato_consumoTableAdapter1.UpdateQuery(txtContratosConsumo.Text,codVigencia);
            }
            DialogResult = DialogResult.OK;
            Close();

        }

        private void frmVigenciasContratosConsumo_Load(object sender, EventArgs e)
        {
            if (codVigencia != 0)
            {
                vigencias_contrato_consumoTableAdapter1.FillBycod_vigencias_contrato_consumo(dsContratoConsumo1.vigencias_contrato_consumo, codVigencia);
                txtContratosConsumo.Text = dsContratoConsumo1.vigencias_contrato_consumo[0].vigencias_contrato_consumo.Trim();
            }
            
        }
    }
}
