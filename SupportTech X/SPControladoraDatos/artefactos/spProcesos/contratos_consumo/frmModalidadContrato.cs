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
    public partial class frmModalidadContrato : Form
    {

        public int codModalidad { set; get; }
        public frmModalidadContrato()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtModalidadContrato.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese la modalidad.");
                return;
            }
            if (codModalidad == 0)
            {
                modalidad_contratoTableAdapter1.Insert(txtModalidadContrato.Text.Trim(), chkActivo.Checked);
            }else {
                modalidad_contratoTableAdapter1.UpdateQuery(txtModalidadContrato.Text.Trim(), chkActivo.Checked, codModalidad);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void frmModalidadContrato_Load(object sender, EventArgs e)
        {
            if (codModalidad != 0)
            {
                modalidad_contratoTableAdapter1.FillByCod_modalidad_contrato(dsContratoConsumo1.modalidad_contrato, codModalidad);
                
                chkActivo.Checked = dsContratoConsumo1.modalidad_contrato[0].activo;
                txtModalidadContrato.Text = dsContratoConsumo1.modalidad_contrato[0].nombre_modalidad_contrato.Trim();
            }
        }
    }
}
