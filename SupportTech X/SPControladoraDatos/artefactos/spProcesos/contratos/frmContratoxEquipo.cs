using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.contratos
{
    public partial class frmContratoxEquipo : Form
    {
        public frmContratoxEquipo()
        {
            InitializeComponent();
        }

        private string cliente = "";
        public string Cliente { set { cliente = value; } get { return cliente; } }
        public string numeroCliente { get { return cmbCliente.SelectedValue.ToString().Trim(); } }
        public string numeroContrato {get { return cmbNumeroContrato.Text.ToString().Trim(); } }
        public decimal manRealizados { get { return nmMantenimientosRealizados.Value; } }
        public decimal manXContrato { get { return nmMantenimientosxContratos.Value; } }
        public bool esActivo { get { return chkContatoActivo.Checked; } }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (esActivo && cliente.ToUpper().Trim() != cmbCliente.SelectedValue.ToString().ToUpper().Trim())
            {
                MessageBox.Show("No puede asociar este contrato como activo debido a que el equipo actualmente esta en el cliente "+
                    cliente.Trim() + " y el contrato "+cmbNumeroContrato.Text.Trim()+" esta vinculado con otro cliente!");
                return;
            }
            if (cmbNumeroContrato.SelectedValue == null || cmbNumeroContrato.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Debe elegir un contrato");
                cmbNumeroContrato.Focus();
                return;
            }
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void frmContratoxEquipo_Load(object sender, EventArgs e)
        {
            clientesTableAdapter1.Fill(dsSpx1.clientes);
            SPControladoraDatos.dsSpxTableAdapters.contratosTableAdapter objC = new SPControladoraDatos.dsSpxTableAdapters.contratosTableAdapter();
            if (cmbCliente.SelectedValue != null && cmbCliente.SelectedValue.ToString().Trim() != string.Empty)
            {
                objC.FillBynitCliente(dsSpx1.contratos, cmbCliente.SelectedValue.ToString());
            }
            //cargamos el cliente donde esta actualmente el equipo
            cmbCliente.SelectedValue = Cliente;
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            SPControladoraDatos.dsSpxTableAdapters.contratosTableAdapter objC = new SPControladoraDatos.dsSpxTableAdapters.contratosTableAdapter();
           
            if (cmbCliente.SelectedValue != null && cmbCliente.SelectedValue.ToString().Trim() != string.Empty)
            {
                objC.FillBynitCliente(dsSpx1.contratos, cmbCliente.SelectedValue.ToString());
            }
        }
    }
}