using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.Equipos
{
    public partial class frmContactosCliente : Form
    {
        public frmContactosCliente()
        {
            InitializeComponent();
        }

        private string nitCliente = "";
        public string NitCliente { set { nitCliente = value; } get { return nitCliente; } }

        private string codContacto = "";
        public string CodContacto { set { codContacto = value; } get { return codContacto; } }

        private void frmContactosCliente_Load(object sender, EventArgs e)
        {
            lblCliente.Text = clientesTableAdapter1.verNombreCliente(nitCliente);
            cargar();
        }

        public void cargar() 
        {
            if (chkInactivosActivos.Checked)
            {
                contactosClientesTableAdapter1.FillBynitCliente(dsSpx1.contactosClientes, nitCliente);
            }else {
                contactosClientesTableAdapter1.FillByNitClienteActivos(dsSpx1.contactosClientes, nitCliente,true);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns[0].Text.Trim() == string.Empty) return;
            codContacto = grdDatos.Columns["codContacto"].Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAgregarContacto_Click(object sender, EventArgs e)
        {
            SpFrm.generales.frmContactos frm = new SpFrm.generales.frmContactos();
            frm.NitCliente = nitCliente;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                contactosClientesTableAdapter1.FillBynitCliente(dsSpx1.contactosClientes, nitCliente);
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns[0].Text.Trim() == string.Empty) return;
            codContacto = grdDatos.Columns["codContacto"].Text;
            contactosClientesTableAdapter1.UpdateActivo(false, NitCliente, codContacto);

            cargar();
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns[0].Text.Trim() == string.Empty) return;
            codContacto = grdDatos.Columns["codContacto"].Text;
            contactosClientesTableAdapter1.UpdateActivo(true, NitCliente, codContacto);
        }

        private void chkInactivosActivos_CheckedChanged(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
