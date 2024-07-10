using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.ordenPrestamo
{
    public partial class frmCantidadPrestada : Form
    {
        public frmCantidadPrestada()
        {
            InitializeComponent();
        }


        public DateTime fechaEntrega;
        public decimal cantidad=0;

        private void frmCantidadPrestada_Load(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            fechaEntrega = n;
            calEntrega.Value = fechaEntrega;
            nmCantidadPrestada.Value = cantidad;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cantidad = nmCantidadPrestada.Value;
            fechaEntrega = calEntrega.Value;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
