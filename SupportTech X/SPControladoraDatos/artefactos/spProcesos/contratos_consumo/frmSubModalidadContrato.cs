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
    public partial class frmSubModalidadContrato : Form
    {
        public int codSubModalidad { set; get; }

        public frmSubModalidadContrato()
        {
            InitializeComponent();
        }


        private void frmSubModalidadContrato_Load(object sender, EventArgs e)
        {
            modalidad_contratoTableAdapter1.Fill(dsContratoConsumo1.modalidad_contrato);
            if (codSubModalidad != 0)
            {
                sub_modalidad_contratoTableAdapter1.FillBycod_sub_modalidad_contrato(dsContratoConsumo1.sub_modalidad_contrato,codSubModalidad);
                cmbModalidad.SelectedValue = dsContratoConsumo1.sub_modalidad_contrato[0].cod_modalidad_contrato;
                txtSubModalidadContrato.Text = dsContratoConsumo1.sub_modalidad_contrato[0].nombresub_modalidad_contrato.Trim();
                chkActivo.Checked = dsContratoConsumo1.sub_modalidad_contrato[0].activo;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbModalidad.SelectedValue ==null || cmbModalidad.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese la modalidad");
                return;
            }
            if(txtSubModalidadContrato.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese la sub modalidad");
                return;
            }

            if (codSubModalidad == 0)
            {
                sub_modalidad_contratoTableAdapter1.Insert(int.Parse(cmbModalidad.SelectedValue.ToString()), txtSubModalidadContrato.Text, chkActivo.Checked);
            }
            else {
                sub_modalidad_contratoTableAdapter1.UpdateQuery(int.Parse(cmbModalidad.SelectedValue.ToString()), txtSubModalidadContrato.Text, chkActivo.Checked, codSubModalidad);
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
