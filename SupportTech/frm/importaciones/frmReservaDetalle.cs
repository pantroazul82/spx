using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SupportTech.frm.importaciones
{
    public partial class frmReservaDetalle : Form
    {
        public frmReservaDetalle()
        {
            InitializeComponent();
        }

        public int cantidadDisponible { set; get; }
        public string nitCliente { set; get; }
        public string codSucursal{ set; get; }
        public int cantidadElegida { set; get; }

        private void cmbSucursal_Enter(object sender, EventArgs e)
        {
            sucursalClienteTableAdapter1.FillByNitCliente(dsSpx1.sucursalCliente, txtBusqueda1.Value);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (nmCantidad.Value == 0)
            {
                MessageBox.Show("La cantidad a reservar debe ser mayor a cero!!!");
                return;
            }
            if (nmCantidad.Value > cantidadDisponible)
            {
                MessageBox.Show("La cantidad a reservar debe ser menor que la cantidad disponible que es "+cantidadDisponible+"!!!");
                return;
            }
            if (cmbSucursal.SelectedValue == null || cmbSucursal.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("La sucursal es obligatoria");
                return;
            }

            nitCliente = txtBusqueda1.Value;
            codSucursal= cmbSucursal.SelectedValue.ToString();
            cantidadElegida = (int)nmCantidad.Value;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();

        }

        private void frmReservaDetalle_Load(object sender, EventArgs e)
        {

        }
    }
}
