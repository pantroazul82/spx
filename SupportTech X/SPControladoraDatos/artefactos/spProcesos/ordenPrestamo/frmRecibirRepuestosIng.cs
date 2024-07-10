using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.ordenPrestamo
{
    public partial class frmRecibirRepuestosIng : Form
    {
        public frmRecibirRepuestosIng()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public int codOrdenPrestamo = 0;

        private void frmRecibirRepuestosIng_Load(object sender, EventArgs e)
        {
            dsSpx1.EnforceConstraints = false;
            txtNumeroOrdenPrestamo.Text = codOrdenPrestamo.ToString();
            ordenPrestamoTableAdapter1.FillBycodOrdenPrestamo(dsSpx1.OrdenPrestamo, codOrdenPrestamo);
            pltRepuestosxOrdenPrestamoTableAdapter1.FillByDevueltas(dsSpx2.pltRepuestosxOrdenPrestamo, codOrdenPrestamo);
            pltRepuestosxOrdenPrestamoTableAdapter1.FillByCodOrdenPrestamoPrestadas(dsSpx1.pltRepuestosxOrdenPrestamo, codOrdenPrestamo);
            //
            txtObservaciones.Text = dsSpx1.OrdenPrestamo[0].obsDevolucion;
        }

        private void btnEntregarTodo_Click(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            Nullable<DateTime> fechaN = new Nullable<DateTime>();

            for (int k = 0; k < dsSpx1.pltRepuestosxOrdenPrestamo.Count; k++)
            {
                repuestosxOrdenPrestamoTableAdapter1.UpdateDevuelto(true, true, false,
                    "", dsSpx1.pltRepuestosxOrdenPrestamo[k].cantidadPrestada,0, dsSpx1.pltRepuestosxOrdenPrestamo[k].fechaEntregaIng,
                    n, fechaN,  codOrdenPrestamo, dsSpx1.pltRepuestosxOrdenPrestamo[k].codRepuesto);
            }
            pltRepuestosxOrdenPrestamoTableAdapter1.FillByDevueltas(dsSpx2.pltRepuestosxOrdenPrestamo, codOrdenPrestamo);
            pltRepuestosxOrdenPrestamoTableAdapter1.FillByCodOrdenPrestamoPrestadas(dsSpx1.pltRepuestosxOrdenPrestamo, codOrdenPrestamo);
        }

        private void btnEntregarRepuesto_Click(object sender, EventArgs e)
        {
            if (grdPrestados.Columns["codRepuesto"].Text.Trim() == string.Empty) return;
            frmRecibirRepuestosDetalle fr = new frmRecibirRepuestosDetalle();
            fr.codRepuesto = grdPrestados.Columns["codRepuesto"].Text;
            fr.codOrdenPrestamo = codOrdenPrestamo;
            if (fr.ShowDialog() == DialogResult.OK)
            {
                pltRepuestosxOrdenPrestamoTableAdapter1.FillByDevueltas(dsSpx2.pltRepuestosxOrdenPrestamo, codOrdenPrestamo);
                pltRepuestosxOrdenPrestamoTableAdapter1.FillByCodOrdenPrestamoPrestadas(dsSpx1.pltRepuestosxOrdenPrestamo, codOrdenPrestamo);
            }
        
        }

        private void btnModificarRepuestos_Click(object sender, EventArgs e)
        {
            if (grdDevueltos.Columns["codRepuesto"].Text.Trim() == string.Empty) return;
            frmRecibirRepuestosDetalle fr = new frmRecibirRepuestosDetalle();
            fr.codRepuesto = grdDevueltos.Columns["codRepuesto"].Text;
            fr.codOrdenPrestamo = codOrdenPrestamo;
            if (fr.ShowDialog() == DialogResult.OK)
            {
                pltRepuestosxOrdenPrestamoTableAdapter1.FillByDevueltas(dsSpx2.pltRepuestosxOrdenPrestamo, codOrdenPrestamo);
                pltRepuestosxOrdenPrestamoTableAdapter1.FillByCodOrdenPrestamoPrestadas(dsSpx1.pltRepuestosxOrdenPrestamo, codOrdenPrestamo);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //
            ordenPrestamoTableAdapter1.UpdateObsDevolucion (txtObservaciones.Text, codOrdenPrestamo);
            ordenPrestamoTableAdapter1.UpdateFactura(txtNumeroFactura.Text, txtNotaSalida.Text, codOrdenPrestamo);
            bool cambiarEstado = true;
            //miramos si ya devolvio todo cambiamos el esta
            for (int k = 0; k < dsSpx1.pltRepuestosxOrdenPrestamo.Count; k++)
            {
                if ((dsSpx1.pltRepuestosxOrdenPrestamo[k].cantidadDevuelta+dsSpx1.pltRepuestosxOrdenPrestamo[k].cantidadConNotaSalida) 
                    < dsSpx1.pltRepuestosxOrdenPrestamo[k].cantidadPrestada)
                    cambiarEstado = false;
            }

            if (cambiarEstado)
            {
                ordenPrestamoTableAdapter1.UpdateDevolucion(SPXSeguridad.logica.sesion.LoginUsuarioAutenticado, txtObservaciones.Text, codOrdenPrestamo);
                ordenPrestamoTableAdapter1.UpdateEstado(7, codOrdenPrestamo);
                ordenPrestamoTableAdapter1.FillBycodOrdenPrestamo(dsSpx1.OrdenPrestamo, codOrdenPrestamo);
                #region zona de notificacion
        //        CgSmtpEmailSender.core.clsSender mailsender = new CgSmtpEmailSender.core.clsSender();
         //       mailsender.EjecutarAccion(307,dsSpx1.OrdenPrestamo[0].loginSolicito, (System.Data.DataRow)dsSpx1.OrdenPrestamo[0], null, CgSmtpEmailSender.core.clsSender.prioridad.media,"","");
                #endregion
            }else{
                ordenPrestamoTableAdapter1.UpdateDevolucion(SPXSeguridad.logica.sesion.LoginUsuarioAutenticado, txtObservaciones.Text, codOrdenPrestamo);
                ordenPrestamoTableAdapter1.UpdateEstado(6, codOrdenPrestamo);
                ordenPrestamoTableAdapter1.FillBycodOrdenPrestamo(dsSpx1.OrdenPrestamo, codOrdenPrestamo);
                #region zona de notificacion
           //     CgSmtpEmailSender.core.clsSender mailsender = new CgSmtpEmailSender.core.clsSender();
            //    mailsender.EjecutarAccion(306, dsSpx1.OrdenPrestamo[0].loginSolicito, (System.Data.DataRow)dsSpx1.OrdenPrestamo[0], null, CgSmtpEmailSender.core.clsSender.prioridad.media,"","");
                #endregion
            }
            //--
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
