using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.ordenPrestamo
{
    public partial class frmAprobar : Form
    {
        public frmAprobar()
        {
            InitializeComponent();
        }
        public int codOrdenPrestamo=0;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmAprobar_Load(object sender, EventArgs e)
        {
            dsSpx1.EnforceConstraints = false;
            txtNumeroOrdenPrestamo.Text = codOrdenPrestamo.ToString();
            ordenPrestamoTableAdapter1.FillBycodOrdenPrestamo(dsSpx1.OrdenPrestamo, codOrdenPrestamo);
            pltRepuestosxOrdenPrestamoTableAdapter1.FillByCodOrdenPrestamo(dsSpx1.pltRepuestosxOrdenPrestamo, codOrdenPrestamo);
            //
            clsTusuario1.FillByPermiso(dsSPXSeguridad1.usuario, 1063);
            cmbResponsable.SelectedValue = dsSpx1.OrdenPrestamo[0].loginResponsable;
            txtObservaciones.Text = dsSpx1.OrdenPrestamo[0].obsAprobacion;
            //Si la orden fue rechazada damos la opcion para que la cambie de rechazada a aprobada
            if (dsSpx1.OrdenPrestamo[0].codEstadoOrdenPrestamo == 3)
            {
                btnCambiarRechazadaAprobada.Visible = true;
            }else{
                btnCambiarRechazadaAprobada.Visible = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //la aprobamos
            if(dsSpx1.OrdenPrestamo[0].codEstadoOrdenPrestamo ==1)
            ordenPrestamoTableAdapter1.UpdateEstado(2, codOrdenPrestamo);
            else
            ordenPrestamoTableAdapter1.UpdateEstado(dsSpx1.OrdenPrestamo[0].codEstadoOrdenPrestamo, codOrdenPrestamo);
            ordenPrestamoTableAdapter1.UpdateAprobacion(SPXSeguridad.logica.sesion.LoginUsuarioAutenticado, txtObservaciones.Text, codOrdenPrestamo);
            ordenPrestamoTableAdapter1.UpdateResponsable(cmbResponsable.SelectedValue.ToString(), codOrdenPrestamo);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAgregarRepuesto_Click(object sender, EventArgs e)
        {
            programacion.frmRepuesto frmTmp = new programacion.frmRepuesto();

            if (frmTmp.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Nullable<DateTime> fechaN= new Nullable<DateTime>();
                    repuestosxOrdenPrestamoTableAdapter1.Insert(codOrdenPrestamo,frmTmp.codigoRepuesto, false,
     false, false, "", fechaN, fechaN, fechaN, frmTmp.cantidad, 0, 0, 0);
                    pltRepuestosxOrdenPrestamoTableAdapter1.FillByCodOrdenPrestamo(dsSpx1.pltRepuestosxOrdenPrestamo, codOrdenPrestamo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Asegurese de no ingresar dos veces el mismo codigo de repuesto a la orden de prestamo \n" + ex.Message);
                }
            }
        }

        private void btnModificarRepuestos_Click(object sender, EventArgs e)
        {
            if (grdRepuestos.Columns["codRepuesto"].Text.Trim() == string.Empty)
                return;

            programacion.frmRepuesto fr = new programacion.frmRepuesto();
            fr.codigoRepuesto = grdRepuestos.Columns["codRepuesto"].Text.Trim();
            fr.cantidad = int.Parse(grdRepuestos.Columns["cantidadSolicitada"].Text.Trim());
            if (fr.ShowDialog() == DialogResult.OK)
            {
                //primero la quitamos
                repuestosxOrdenPrestamoTableAdapter1.DeleteQuery(codOrdenPrestamo, grdRepuestos.Columns["codRepuesto"].Text);
                //luego agregamos de nuevo la fila
                Nullable<DateTime> fechaN= new Nullable<DateTime>();

                repuestosxOrdenPrestamoTableAdapter1.Insert(codOrdenPrestamo, grdRepuestos.Columns["codRepuesto"].Text, false,
                    false, false, "", fechaN, fechaN, fechaN, fr.cantidad, 0, 0, 0);
                pltRepuestosxOrdenPrestamoTableAdapter1.FillByCodOrdenPrestamo(dsSpx1.pltRepuestosxOrdenPrestamo, codOrdenPrestamo);
            }
        }

        private void btnEliminarRepuesto_Click(object sender, EventArgs e)
        {
            if (grdRepuestos.Columns["codRepuesto"].Text.Trim() == string.Empty)
                return;

            if (MessageBox.Show("Esta seguro de eliminar este repuesto de la orden", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                != DialogResult.Yes)
            {
                return;
            }
            repuestosxOrdenPrestamoTableAdapter1.DeleteQuery(codOrdenPrestamo, grdRepuestos.Columns["codRepuesto"].Text);
            pltRepuestosxOrdenPrestamoTableAdapter1.FillByCodOrdenPrestamo(dsSpx1.pltRepuestosxOrdenPrestamo, codOrdenPrestamo);
        }

        private void btnCambiarRechazadaAprobada_Click(object sender, EventArgs e)
        {
            ordenPrestamoTableAdapter1.UpdateAprobacion(SPXSeguridad.logica.sesion.LoginUsuarioAutenticado, txtObservaciones.Text, codOrdenPrestamo);
            ordenPrestamoTableAdapter1.UpdateEstado(2, codOrdenPrestamo);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
