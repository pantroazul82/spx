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
    public partial class frmAgregarDispositivoMedicionExterno : Form
    {
        public frmAgregarDispositivoMedicionExterno()
        {
            InitializeComponent();
        }

        public int cod { set; get; }
        public int codOrdenServicio { set; get; }

        public string codFabricante { set; get; }
        public string codModelo { set; get; }
        public string serial { set; get; }
        public string responsable { set; get; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (txtFabricante.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El fabricante es obligatorio.");
                return;
            }

            if (txtModelo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El modelo es obligatorio.");
                return;
            }

            if (txtSerialExterno.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El serial es obligatorio.");
                return;
            }


            if (txtResponsableExterno.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El responsable es obligatorio.");
                return;
            }

          
            if (cod == 0)
            {
                dispositivosmedicionxordenservicioTableAdapter1.Insert(null, codOrdenServicio, null, null, txtSerialExterno.Text, txtResponsableExterno.Text,txtFabricante.Text,txtModelo.Text);
            }else {
                dispositivosmedicionxordenservicioTableAdapter1.UpdateQuery(null, null, txtSerialExterno.Text, txtResponsableExterno.Text,txtFabricante.Text,txtModelo.Text, cod);
            }
            DialogResult = DialogResult.OK;
        }

     

        private void frmAgregarDispositivoMedicionExterno_Load(object sender, EventArgs e)
        {
            
        }
    }
}
