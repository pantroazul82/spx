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
    public partial class frmSubVariableMedicionDetalle : Form
    {
        public frmSubVariableMedicionDetalle()
        {
            InitializeComponent();
        }

        public int codSubvariablemedicion { set; get; }

        private void frmSubVariableMedicionDetalle_Load(object sender, EventArgs e)
        {
            variables_medicionTableAdapter1.Fill(dsSpx1.variables_medicion);

            if (codSubvariablemedicion != 0)
            {
                sub_variable_medicionTableAdapter1.FillByCod_sub_variables_medicion(dsSpx1.sub_variable_medicion, codSubvariablemedicion);
                txtUnidades.Text = dsSpx1.sub_variable_medicion[0].unidades;
                cmbSubvariableMedicion.SelectedValue = dsSpx1.sub_variable_medicion[0].cod_variables_medicion;
                cmbSubvariableMedicion.Enabled = false;
                txtSubVariable.Text = dsSpx1.sub_variable_medicion[0].nombre_subvariable;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtSubVariable.Text == string.Empty)
            {
                MessageBox.Show("El nombre de la sub variable es obligatorio ");
                return;
            }

            if (txtSubVariable.Text == string.Empty)
            {
                MessageBox.Show("Las Unidades son obligatorias ");
                return;
            }

            if (cmbSubvariableMedicion.SelectedValue == null || cmbSubvariableMedicion.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("La variable es obligatoria ");
                return;
            }

            if (codSubvariablemedicion != 0)
            {
                sub_variable_medicionTableAdapter1.UpdateQuery( txtSubVariable.Text, txtUnidades.Text,codSubvariablemedicion);
            }else{
                sub_variable_medicionTableAdapter1.Insert(int.Parse(cmbSubvariableMedicion.SelectedValue.ToString()), txtSubVariable.Text, txtUnidades.Text);
            }
            DialogResult = DialogResult.OK;
        }

        private void cmbSubvariableMedicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbSubvariableMedicion.SelectedValue== null || cmbSubvariableMedicion.SelectedValue.ToString().Trim()== string.Empty)return;

            SPControladoraDatos.dsSpx ds=new SPControladoraDatos.dsSpx();
            variables_medicionTableAdapter1.FillByCod_variables_medicion(ds.variables_medicion,int.Parse( cmbSubvariableMedicion.SelectedValue.ToString() ));
            txtUnidades.Text = ds.variables_medicion[0].unidades;
        }
    }
}
