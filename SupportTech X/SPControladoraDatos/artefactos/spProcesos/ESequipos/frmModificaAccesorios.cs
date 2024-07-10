using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.ESequipos
{
    public partial class frmModificaAccesorios : Form
    {
        public frmModificaAccesorios()
        {
            InitializeComponent();
        }

       //--
        public string CodigoAccesorio { set { txtCodigo.Text = value; } get { return txtCodigo.Text.Trim(); } }
        public string NombreAccesorio { set { txtNombreAccesorio.Text = value; } get { return txtNombreAccesorio.Text; } }
        public float Cantidad { set { txtCantidad.Text = value.ToString(); } get { float res = 0; float.TryParse(txtCantidad.Text, out res); return res; } }

        private void frmModificaAccesorios_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Cantidad == 0) { MessageBox.Show("Ingrese una cantidad valida"); return; }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}