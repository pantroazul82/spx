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
    public partial class frmCambiarCliente : Form
    {
        public frmCambiarCliente()
        {
            InitializeComponent();
        }

        public string nitCliente { set; get; }
        public string codSucursal { set; get; }
        public string codContacto { set; get; }

        private void cmbSucursal_Enter(object sender, EventArgs e)
        {
            sucursalClienteTableAdapter1.FillByNitCliente(dsSpx1.sucursalCliente, txtBusqueda1.Value);
            contactosClientesTableAdapter1.FillBynitCliente(dsSpx1.contactosClientes, txtBusqueda1.Value);
        }

        private void cmbContacto_Enter(object sender, EventArgs e)
        {
            sucursalClienteTableAdapter1.FillByNitCliente(dsSpx1.sucursalCliente, txtBusqueda1.Value);
            contactosClientesTableAdapter1.FillBynitCliente(dsSpx1.contactosClientes, txtBusqueda1.Value);
        }

        private void frmCambiarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbContacto.SelectedValue == null || cmbContacto.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("El contacto es obligatorio!!!");
                return;
            }

            if (cmbSucursal.SelectedValue == null || cmbSucursal.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("La sucursal es obligatoria!!!");
                return;
            }
            nitCliente = txtBusqueda1.Value;
            codContacto = cmbContacto.SelectedValue.ToString();
            codSucursal = cmbSucursal.SelectedValue.ToString();

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
