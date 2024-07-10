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
    public partial class frmGruposConsumibles : Form
    {
        public frmGruposConsumibles()
        {
            InitializeComponent();
        }

        public int CodGrupo { set; get; }

        private void frmGruposConsumibles_Load(object sender, EventArgs e)
        {
            fabricanteTableAdapter1.FillByComboBox(dsSpx1.fabricante);
            if(CodGrupo!=0)
            {
                grupo_consumibleTableAdapter1.FillByCod_grupo_consumible(dsContratoConsumo1.grupo_consumible,CodGrupo);
                cmbFabricante.SelectedValue = dsContratoConsumo1.grupo_consumible[0].cod_fabricante;
                txtGrupoConsumible.Text = dsContratoConsumo1.grupo_consumible[0].grupo_consumible.Trim();

            
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (CodGrupo != 0)
            {
                grupo_consumibleTableAdapter1.UpdateQuery(int.Parse(cmbFabricante.SelectedValue.ToString()), txtGrupoConsumible.Text, CodGrupo);
            }else{
                grupo_consumibleTableAdapter1.Insert(int.Parse(cmbFabricante.SelectedValue.ToString()), txtGrupoConsumible.Text);
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
