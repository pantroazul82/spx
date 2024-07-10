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
    public partial class frmIncrementosxLineas : Form
    {
        public frmIncrementosxLineas()
        {
            InitializeComponent();
        }
        public int codIgo { set; get; }
        public int codIgoContrato { set; get; }

        private void frmIncrementosxLineas_Load(object sender, EventArgs e)
        {
            linea_consumoTableAdapter1.Fill(dsContratoConsumo1.linea_consumo);
            if (codIgo != 0)
            {
                incrementosxlinea_consumoTableAdapter1.FillBycod_incrementosxlinea_consumo(dsContratoConsumo1.incrementosxlinea_consumo, codIgo);
                decimal incre = 0;
                decimal.TryParse(dsContratoConsumo1.incrementosxlinea_consumo[0].incremento.Trim().Replace(".",System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator),out incre);
                nmIncremento.Text = incre.ToString().Replace(",",".");
                cmbLineaConsumo.SelectedValue = dsContratoConsumo1.incrementosxlinea_consumo[0].cod_linea_consumo;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(cmbLineaConsumo.SelectedValue == null || cmbLineaConsumo.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese la linea de consumo");
                return;
            }
            if(codIgo ==0){
                incrementosxlinea_consumoTableAdapter1.Insert(
                    int.Parse(cmbLineaConsumo.SelectedValue.ToString()), nmIncremento.Text.ToString(), codIgoContrato);
            }else{
                incrementosxlinea_consumoTableAdapter1.UpdateQuery(
                       int.Parse(cmbLineaConsumo.SelectedValue.ToString()),
                       nmIncremento.Text, codIgoContrato, codIgo
                    );
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void nmIncremento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar < 30)
            {
                e.Handled = false;
                return;
            }
            if (e.KeyChar == '0' ||
                e.KeyChar == '1' ||
                e.KeyChar == '2' ||
                e.KeyChar == '3' ||
                e.KeyChar == '4' ||
                e.KeyChar == '5' ||
                e.KeyChar == '6' ||
                e.KeyChar == '7' ||
                e.KeyChar == '8' ||
                e.KeyChar == '9' ||
                e.KeyChar == '0' ||
                e.KeyChar == '.' ||
                e.KeyChar == '-'
                )
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
