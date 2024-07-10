using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.llamadasTecnicas
{
    public partial class frmFechaSolucion : Form
    {
        public frmFechaSolucion()
        {
            InitializeComponent();
        }

        public DateTime fecha { get { return calSolucion.Value; } }

        public int resultadoFinal { get {return int.Parse(cmbResultadoFinal.SelectedValue.ToString()); } }
        private void bnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (calSolucion.ValueObject == null)
            {
                MessageBox.Show("Seleccione una fecha");
                return;
            }

            if (cmbResultadoFinal.SelectedValue== null || cmbResultadoFinal.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Seleccione el resultado final");
                return;
            }
            //la fecha de solucion no puede ser mayor a la fecha de cierre
            SPXdata.BD.DataConector o=new SPXdata.BD.DataConector();
            if (calSolucion.Value > o.fechaServer)
            {
                MessageBox.Show("La fecha de solucion no puede ser mayor a la fecha de cierre");
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmFechaSolucion_Load(object sender, EventArgs e)
        {
            calSolucion.Value = DateTime.Now;
            calSolucion.MonthCalendar.DisplayMonth = DateTime.Now;
            resultado_final_llamadaTableAdapter1.Fill(dsSpx1.resultado_final_llamada);
            cmbResultadoFinal.SelectedIndex = -1;
        }
    }
}
