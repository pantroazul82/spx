using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.ordenPrestamo
{
    public partial class frmRecibirRepuestosDetalle : Form
    {
        public frmRecibirRepuestosDetalle()
        {
            InitializeComponent();
        }

        private void txtDevuelta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (int)e.KeyChar > 20)
                e.Handled = true;
        }

        private void txtConNotasalida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (int)e.KeyChar > 20)
                e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


        public int codOrdenPrestamo = 0;
        public string codRepuesto = "";
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int prestada = 0;
            int devuelto = 0;
            int notaSailda=0;
            int.TryParse(txtConNotasalida.Text, out notaSailda);
            int.TryParse(txtDevuelta.Text, out devuelto);
            int.TryParse(txtCantidadPrestada.Text, out prestada);
            
            if ((devuelto +notaSailda) > prestada)
            { MessageBox.Show("No puede devolver mas de lo que fue prestado!!!!");
              return;
            }
            Nullable<DateTime> fechaN= new Nullable<DateTime>();
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            repuestosxOrdenPrestamoTableAdapter1.UpdateDevuelto(
                true, true, (notaSailda > 0), txtObservacionesNotaSalida.Text, devuelto, notaSailda,
                dsSpx1.repuestosxOrdenPrestamo[0].fechaEntregaIng, n,
                (notaSailda > 0) ? n : fechaN , codOrdenPrestamo, codRepuesto);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmRecibirRepuestosDetalle_Load(object sender, EventArgs e)
        {
            repuestosTableAdapter1.FillBycodRepuesto(dsSpx1.repuestos, codRepuesto);
            txtRepuesto.Text = dsSpx1.repuestos[0].descripcion.Trim() + " (" + dsSpx1.repuestos[0].codRepuesto.Trim() + ")";
            repuestosxOrdenPrestamoTableAdapter1.FillBycodOrdenPrestamoCodRepuesto(dsSpx1.repuestosxOrdenPrestamo, codOrdenPrestamo, codRepuesto);
            txtCantidadPrestada.Text = dsSpx1.repuestosxOrdenPrestamo[0].cantidadPrestada.ToString();
            txtConNotasalida.Text = dsSpx1.repuestosxOrdenPrestamo[0].cantidadConNotaSalida.ToString();
            txtDevuelta.Text = dsSpx1.repuestosxOrdenPrestamo[0].cantidadDevuelta.ToString();
            txtObservacionesNotaSalida.Text = dsSpx1.repuestosxOrdenPrestamo[0].obsNotaSalida;
            txtDevuelta.Focus();
        }
    }
}
