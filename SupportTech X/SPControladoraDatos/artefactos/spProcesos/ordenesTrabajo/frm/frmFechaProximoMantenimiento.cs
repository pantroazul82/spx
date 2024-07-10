using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.ordenesTrabajo.frm
{
    public partial class frmFechaProximoMantenimiento : Form
    {
        public frmFechaProximoMantenimiento()
        {
            InitializeComponent();
        }

        public string serialEquipo = "";
        public DateTime fechaProximomantenimiento = DateTime.Now;

        private void frmFechaProximoMantenimiento_Load(object sender, EventArgs e)
        {
            calDentroDe.MonthCalendar.DisplayMonth = DateTime.Now;
            calProximoMantenimiento.MonthCalendar.DisplayMonth = DateTime.Now;
            calSugerido.MonthCalendar.DisplayMonth = DateTime.Now;
            //
            equiposTableAdapter1.FillBySerial(dsSpx1.equipos, serialEquipo);
            if (dsSpx1.equipos.Rows.Count <= 0) return;
            //cargamos la fecha que tiene configurada de antes
            if(!dsSpx1.equipos[0].IsfechaProximoManteNull())
                calProximoMantenimiento.Value = dsSpx1.equipos[0].fechaProximoMante;
            else
                calProximoMantenimiento.ValueObject = null;
            //cargamos la proxima fecha segun la configuracion del modelo
            int meses = 0, dias = 0;
            modelosTableAdapter1.FillByFabricanteModelo(dsSpx1.Modelos, dsSpx1.equipos[0].codFabricante.Trim(), dsSpx1.equipos[0].codModelo.Trim());
            //cargamos la informacion del modelo
            if (!dsSpx1.Modelos[0].IsmesesxMantenimientoNull())
                meses = dsSpx1.Modelos[0].mesesxMantenimiento;
            if (!dsSpx1.Modelos[0].IsdiasxMantenimientoNull())
                dias = dsSpx1.Modelos[0].diasxMantenimiento;
            //verificamos si no tiene configurado o si es 0 cargamos la configuracion de defaults
            if (dias + meses == 0) 
            {
                if (defaultsTableAdapter1.vermesesxMantenimiento().HasValue)
                    meses = defaultsTableAdapter1.vermesesxMantenimiento().Value;
                if (defaultsTableAdapter1.verdiasxMantenimiento().HasValue)
                    dias = defaultsTableAdapter1.verdiasxMantenimiento().Value;
            }
            calSugerido.Value= DateTime.Now.AddMonths(meses).AddDays(dias);
            if (meses > 0)
                lblSugerido.Text = meses + " (Meses) ";
            if (dias > 0)
                lblSugerido.Text += dias + " (Dias) ";
            //
            calProximoMantenimiento.Enabled = false;
            calSugerido.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //validamos
            if(!rdActual.Checked && !rdEstimado.Checked && !rdSugerido.Checked && !rdNinguna.Checked)
            {
                MessageBox.Show("Elija una opcion");
                return;
            }
            if (rdActual.Checked)
            {
                if (calProximoMantenimiento.ValueObject == null)
                {
                    MessageBox.Show("no puede seleccionar la fecha de programacion actual ya que el equipo no la tiene!!!");
                    return;
                }
                fechaProximomantenimiento= calProximoMantenimiento.Value;
            }
            if (rdSugerido.Checked)
            {

                //if (calProximoMantenimiento.ValueObject == null)
                //{
                //    MessageBox.Show("no puede seleccionar la fecha de programacion actual ya que el equipo no la tiene!!!")
                //    return;
                //}
                fechaProximomantenimiento=calSugerido.Value;
            }else 
            if (rdEstimado.Checked)
            {
                if (calDentroDe.Value < DateTime.Now)
                {
                    MessageBox.Show("La fecha del proxmimo mantenimiento no puede ser menor que hoy!!!");
                    return;
                }
                fechaProximomantenimiento=calDentroDe.Value;
            }
            else if (rdNinguna.Checked) {
                fechaProximomantenimiento = DateTime.MinValue;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        bool cambiaCAlendario = true;
        private void nmMeses_ValueChanged(object sender, EventArgs e)
        {
            if (cambiaCAlendario) return;
            cambiaCAlendario = false;
            calDentroDe.Value = DateTime.Now.AddMonths((int)nmMeses.Value).AddDays((int)nmDias.Value);
            cambiaCAlendario = true;
        }

        private void nmDias_ValueChanged(object sender, EventArgs e)
        {
            if (cambiaCAlendario) return;
            cambiaCAlendario = false;
            calDentroDe.Value = DateTime.Now.AddMonths((int)nmMeses.Value).AddDays((int)nmDias.Value);
            cambiaCAlendario = true;
        }

        private void calDentroDe_Click(object sender, EventArgs e)
        {
            cambiaCAlendario = true;
        }

        private void calDentroDe_ValueChanged(object sender, EventArgs e)
        {
            if(!cambiaCAlendario )return;
            //aca ponemos la diferencia en los numeric
            TimeSpan ts =calDentroDe.Value.Subtract(  DateTime.Now);
            nmMeses.Value = (ts.Days/30>0)?ts.Days/30:0;
            nmDias.Value = (ts.Days % 30 > 0) ? ts.Days % 30 : 0;
            cambiaCAlendario = false;
        }

        private void nmMeses_Click(object sender, EventArgs e)
        {
            cambiaCAlendario = false;
        }

        private void nmDias_Click(object sender, EventArgs e)
        {
            cambiaCAlendario = false;
        }
    }
}
