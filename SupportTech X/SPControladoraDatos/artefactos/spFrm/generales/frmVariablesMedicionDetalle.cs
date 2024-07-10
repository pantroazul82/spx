using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.generales
{
    public partial class frmVariablesMedicionDetalle : Form
    {
        public frmVariablesMedicionDetalle()
        {
            InitializeComponent();
        }

        public int codVariable { set; get; }

        private void frmVariablesMedicionDetalle_Load(object sender, EventArgs e)
        {
            if (codVariable != 0)
            {
                variables_medicionTableAdapter1.FillByCod_variables_medicion(dsSpx1.variables_medicion, codVariable);
                if (dsSpx1.variables_medicion.Count > 0)
                {
                    txtVariable.Text = dsSpx1.variables_medicion[0].nombre_variables_medicion.Trim();
                    txtUnidades.Text = dsSpx1.variables_medicion[0].unidades.Trim();
                    txtCodigoMotivoSalida.Text = codVariable.ToString();
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtVariable.Text.Trim() == string.Empty)
            {
                MessageBox.Show("La variable es obligatoria!");
                return;
            }
            if (codVariable == 0)
            {
                variables_medicionTableAdapter1.Insert(txtVariable.Text,txtUnidades.Text);
            }
            else
            {
                variables_medicionTableAdapter1.UpdateQuery(txtVariable.Text,
                    txtUnidades.Text, codVariable);
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
