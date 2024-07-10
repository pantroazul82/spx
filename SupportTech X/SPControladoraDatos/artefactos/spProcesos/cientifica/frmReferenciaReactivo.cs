using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.cientifica
{
    public partial class frmReferenciaReactivo : Form
    {
        public frmReferenciaReactivo()
        {
            InitializeComponent();
        }

        public int codReferenciaReactivo{set;get;}

        private void frmReferenciaReactivo_Load(object sender, EventArgs e)
        {
            fabricanteTableAdapter1.FillByComboBox(dsSpx1.fabricante);
            if (codReferenciaReactivo != 0)
            {
                referencia_reactivoTableAdapter1.FillBycod_referencia_reactivo(dsSpx1.referencia_reactivo, codReferenciaReactivo);
                cmbFabricante.SelectedValue= dsSpx1.referencia_reactivo[0].codFabricante.Trim();
                txtCodManual.Text= dsSpx1.referencia_reactivo[0].codigo_manual.Trim();
                txtReferenciaReactivo.Text= dsSpx1.referencia_reactivo[0].nombre_referencia_reactivo.Trim();
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool validar() 
        {

            if (cmbFabricante.SelectedValue == null || cmbFabricante.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("el fabricante es obligatorio", "Error de validacion");
                return false;
            }
            if (txtCodManual.Text.Trim() == string.Empty)
            {
                MessageBox.Show("el codigo de manual es obligatorio", "Error de validacion");
                return false;
            }
            if (txtReferenciaReactivo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("La referencia del reactivo es obligatorio.", "Error de validacion");
                return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!validar()) return;

            if (codReferenciaReactivo == 0)
            {
                referencia_reactivoTableAdapter1.Insert(cmbFabricante.SelectedValue.ToString(),txtCodManual.Text, 
                    txtReferenciaReactivo.Text);
            }else {
                referencia_reactivoTableAdapter1.UpdateQuery(cmbFabricante.SelectedValue.ToString(),
                    txtCodManual.Text, txtReferenciaReactivo.Text, codReferenciaReactivo);
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
