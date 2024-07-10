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
    public partial class frmConsumibles : Form
    {
        public frmConsumibles()
        {
            InitializeComponent();
        }

        public int codConsumibles { set; get; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtconsumibles.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese el consumible");
                return;
            }
            if (txtReferencia.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese la referencia");
                return;
            }

            if (cmbGrupoConsumible.SelectedValue == null || cmbGrupoConsumible.SelectedValue.ToString() == string.Empty)
            {
                MessageBox.Show("Ingrese el grupo de consumible");
                return;
            }
            if (codConsumibles == 0)
            {
                consumiblesTableAdapter1.Insert(txtconsumibles.Text,int.Parse(cmbGrupoConsumible.SelectedValue.ToString()),txtReferencia.Text);
            }
            else {
                consumiblesTableAdapter1.UpdateQuery(txtconsumibles.Text, int.Parse(cmbGrupoConsumible.SelectedValue.ToString()),txtReferencia.Text, codConsumibles);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmConsumibles_Load(object sender, EventArgs e)
        {
            fabricanteTableAdapter1.FillByComboBox(dsSpx1.fabricante);
            if (codConsumibles != 0)
            {
                consumiblesTableAdapter1.FillByCod_consumible(dsContratoConsumo1.consumibles,codConsumibles);
                txtconsumibles.Text = dsContratoConsumo1.consumibles[0].consumible.Trim();
                if (!dsContratoConsumo1.consumibles[0].IsreferenciaNull())
                txtReferencia.Text = dsContratoConsumo1.consumibles[0].referencia.Trim();
                grupo_consumibleTableAdapter1.FillByCod_grupo_consumible(dsContratoConsumo1.grupo_consumible,   dsContratoConsumo1.consumibles[0].cod_grupo_consumible);
                cmbFabricante.SelectedValue = dsContratoConsumo1.grupo_consumible[0].cod_fabricante;
                grupo_consumibleTableAdapter1.FillBycod_fabricante(dsContratoConsumo1.grupo_consumible, dsContratoConsumo1.grupo_consumible[0].cod_fabricante);
                cmbGrupoConsumible.SelectedValue = dsContratoConsumo1.consumibles[0].cod_grupo_consumible;
            }
        }

        private void cmbFabricante_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cod=0;
            if (cmbFabricante.SelectedValue != null && cmbFabricante.SelectedValue != string.Empty)
                cod = int.Parse(cmbFabricante.SelectedValue.ToString());
            
            grupo_consumibleTableAdapter1.FillBycod_fabricante(dsContratoConsumo1.grupo_consumible, cod);

        }
    }
}
