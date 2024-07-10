using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.ordenPrestamo
{
    public partial class frmRechazar : Form
    {
        public frmRechazar()
        {
            InitializeComponent();
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ordenPrestamoTableAdapter1.UpdateAprobacion(SPXSeguridad.logica.sesion.LoginUsuarioAutenticado, txtObservaciones.Text, codOrdenPrestamo);
            ordenPrestamoTableAdapter1.UpdateEstado(3, codOrdenPrestamo);
            DialogResult = DialogResult.OK;
            Close();
        }

        public int codOrdenPrestamo = 0;

        private void frmRechazar_Load(object sender, EventArgs e)
        {
            txtNumeroOrdenPrestamo.Text = codOrdenPrestamo.ToString();
            ordenPrestamoTableAdapter1.FillBycodOrdenPrestamo(dsSpx1.OrdenPrestamo, codOrdenPrestamo);
            txtObservaciones.Text = dsSpx1.OrdenPrestamo[0].obsAprobacion;
        }
    }
}
