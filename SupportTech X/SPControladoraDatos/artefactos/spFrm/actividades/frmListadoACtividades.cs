using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.actividades
{
    public partial class frmListadoACtividades : Form
    {
        public frmListadoACtividades()
        {
            InitializeComponent();
            controladorColumnas1.grilla = grdDatos;
        }

        private void frmListadoACtividades_Load(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            clsTusuario1.Fill(dsSPXSeguridad1.usuario);
            cmbUsuario.SelectedValue = "-1";
            calFin.Value =n.AddDays(5);
            calInicio.Value = n.AddDays(-35);
            calInicio.MonthCalendar.DisplayMonth = n;
            calFin.MonthCalendar.DisplayMonth = n;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void buscar()
        {
            if (chkUsuario.Checked && (cmbUsuario.SelectedValue == null || cmbUsuario.SelectedValue.ToString().Trim() == string.Empty))
            {
                MessageBox.Show("Seleccione un ingeniero");
                return;
            }
            if(calInicio.ValueObject == null || calFin.ValueObject==null)
            {
                MessageBox.Show("Seleccione un rango de fechas valido");
                return;
            }
            dsPlantillas1.EnforceConstraints = false;
            if (chkUsuario.Checked)
            {
                pltActividadTableAdapter1.FillByLoginFechas(dsPlantillas1.pltActividad, calInicio.Value,
                    calFin.Value.AddDays(1), cmbUsuario.SelectedValue.ToString());
            }else{
                pltActividadTableAdapter1.FillByFechas(dsPlantillas1.pltActividad,  calInicio.Value,
                    calFin.Value.AddDays(1));
            }
      }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            frmNuevaActividad fr = new frmNuevaActividad();
            if(fr.ShowDialog() == DialogResult.OK)
            {
                buscar();
            }
        }

        private void btnVerRecoleccion_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_actividad_adicional"].Text.Trim() == string.Empty) return;
            frmNuevaActividad fr = new frmNuevaActividad();
            fr.codActividad = int.Parse(grdDatos.Columns["cod_actividad_adicional"].Text);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                buscar();
            }
        }
    }
}
