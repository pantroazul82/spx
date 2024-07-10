using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.ordenPrestamo
{
    public partial class frmEntregarRepuestosIng : Form
    {
        public frmEntregarRepuestosIng()
        {
            InitializeComponent();
        }
        public int codOrdenPrestamo = 0;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {

            ordenPrestamoTableAdapter1.UpdateobsEntrega(txtObservaciones.Text, codOrdenPrestamo);
            bool cambiarEstado = true;
            //miramos si ya entrego todo cambiamos el esta
            for (int k = 0; k < dsSpx1.pltRepuestosxOrdenPrestamo.Count; k++)
            {
                if (dsSpx1.pltRepuestosxOrdenPrestamo[k].cantidadSolicitada > dsSpx1.pltRepuestosxOrdenPrestamo[k].cantidadPrestada)
                    cambiarEstado = false;
            }

               
            if (cambiarEstado || MessageBox.Show("Termino de entregar los repuestos al Ingeniero?\n","Cambiar Estado?", MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                ordenPrestamoTableAdapter1.UpdateEntrega(SPXSeguridad.logica.sesion.LoginUsuarioAutenticado, txtObservaciones.Text, codOrdenPrestamo);
                ordenPrestamoTableAdapter1.UpdateEstado(5, codOrdenPrestamo);
                Nullable<DateTime> fechaN = new Nullable<DateTime>();
                for (int k = 0; k < dsSpx1.pltRepuestosxOrdenPrestamo.Count; k++)
                {
                    repuestosxOrdenPrestamoTableAdapter1.UpdateEntregado(true, false, false,
                        "", dsSpx1.pltRepuestosxOrdenPrestamo[k].fechaEntregaIng, fechaN, fechaN,
                        codOrdenPrestamo, dsSpx1.pltRepuestosxOrdenPrestamo[k].codRepuesto);
                }
                ordenPrestamoTableAdapter1.FillBycodOrdenPrestamo(dsSpx1.OrdenPrestamo, codOrdenPrestamo);
            }else{
                ordenPrestamoTableAdapter1.UpdateEntrega(SPXSeguridad.logica.sesion.LoginUsuarioAutenticado, txtObservaciones.Text, codOrdenPrestamo);
                ordenPrestamoTableAdapter1.UpdateEstado(4, codOrdenPrestamo);
                ordenPrestamoTableAdapter1.FillBycodOrdenPrestamo(dsSpx1.OrdenPrestamo, codOrdenPrestamo);
            }
            //--
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnEntregarRepuesto_Click(object sender, EventArgs e)
        {
            if (grdRepuestos.Columns["cantidadSolicitada"].Text.Trim() == string.Empty) return;
            frmCantidadPrestada fr = new frmCantidadPrestada();
            fr.cantidad = decimal.Parse(grdRepuestos.Columns["cantidadSolicitada"].Text);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                if (fr.cantidad > decimal.Parse(grdRepuestos.Columns["cantidadSolicitada"].Text))
                {
                    MessageBox.Show("La cantidad autorizada es "+decimal.Parse(grdRepuestos.Columns["cantidadSolicitada"].Text)+" no puede prestar mas de lo autorizado." );
                    return;
                }

                repuestosxOrdenPrestamoTableAdapter1.UpdatecantidadPrestada((int)fr.cantidad,fr.fechaEntrega, codOrdenPrestamo,
                    grdRepuestos.Columns["codRepuesto"].Text);
            }
            pltRepuestosxOrdenPrestamoTableAdapter1.FillByCodOrdenPrestamo(dsSpx1.pltRepuestosxOrdenPrestamo, codOrdenPrestamo);
            pltRepuestosxOrdenPrestamoTableAdapter1.FillByCodOrdenPrestamoPrestadas(dsSpx2.pltRepuestosxOrdenPrestamo, codOrdenPrestamo);
       
        }

        private void btnModificarRepuestos_Click(object sender, EventArgs e)
        {
            if (grdPrestadas.Columns["cantidadPrestada"].Text.Trim() == string.Empty) return;
            frmCantidadPrestada fr = new frmCantidadPrestada();
            fr.cantidad = decimal.Parse(grdPrestadas.Columns["cantidadPrestada"].Text);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                
                if (fr.cantidad > decimal.Parse(grdPrestadas.Columns["cantidadSolicitada"].Text))
                {
                    MessageBox.Show("La cantidad autorizada es " + decimal.Parse(grdPrestadas.Columns["cantidadSolicitada"].Text) + " no puede prestar mas de lo autorizado.");
                    return;
                }

                repuestosxOrdenPrestamoTableAdapter1.UpdatecantidadPrestada((int)fr.cantidad, fr.fechaEntrega, codOrdenPrestamo,
                    grdPrestadas.Columns["codRepuesto"].Text);
            }
            pltRepuestosxOrdenPrestamoTableAdapter1.FillByCodOrdenPrestamo(dsSpx1.pltRepuestosxOrdenPrestamo, codOrdenPrestamo);
            pltRepuestosxOrdenPrestamoTableAdapter1.FillByCodOrdenPrestamoPrestadas(dsSpx2.pltRepuestosxOrdenPrestamo, codOrdenPrestamo);
       
        }

        private void frmEntregarRepuestosIng_Load(object sender, EventArgs e)
        {
            dsSpx1.EnforceConstraints = false;
            txtNumeroOrdenPrestamo.Text = codOrdenPrestamo.ToString();
            ordenPrestamoTableAdapter1.FillBycodOrdenPrestamo(dsSpx1.OrdenPrestamo, codOrdenPrestamo);
            pltRepuestosxOrdenPrestamoTableAdapter1.FillByCodOrdenPrestamo(dsSpx1.pltRepuestosxOrdenPrestamo, codOrdenPrestamo);
            pltRepuestosxOrdenPrestamoTableAdapter1.FillByCodOrdenPrestamoPrestadas(dsSpx2.pltRepuestosxOrdenPrestamo, codOrdenPrestamo);
            //
            txtObservaciones.Text = dsSpx1.OrdenPrestamo[0].obsEntrega;
        }

        private void btnEntregarTodo_Click(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            Nullable<DateTime> fechaN= new Nullable<DateTime>();

            for (int k = 0; k < dsSpx1.pltRepuestosxOrdenPrestamo.Count; k++)
            {
                repuestosxOrdenPrestamoTableAdapter1.UpdateEntregado(true, false, false,
                    "", n, fechaN, fechaN, codOrdenPrestamo, dsSpx1.pltRepuestosxOrdenPrestamo[k].codRepuesto);
                repuestosxOrdenPrestamoTableAdapter1.UpdatecantidadPrestada(dsSpx1.pltRepuestosxOrdenPrestamo[k].cantidadSolicitada,
                    n,codOrdenPrestamo, dsSpx1.pltRepuestosxOrdenPrestamo[k].codRepuesto);
            }
            pltRepuestosxOrdenPrestamoTableAdapter1.FillByCodOrdenPrestamo(dsSpx1.pltRepuestosxOrdenPrestamo, codOrdenPrestamo);
            pltRepuestosxOrdenPrestamoTableAdapter1.FillByCodOrdenPrestamoPrestadas(dsSpx2.pltRepuestosxOrdenPrestamo, codOrdenPrestamo);
     
        }
    }
}
