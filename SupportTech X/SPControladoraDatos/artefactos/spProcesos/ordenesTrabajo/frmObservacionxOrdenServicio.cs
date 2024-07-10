using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.programacion
{
    public partial class frmObservacionxOrdenServicio : Form
    {
        public frmObservacionxOrdenServicio()
        {
            InitializeComponent();
        }

        private void calActividad_Click(object sender, EventArgs e)
        {

        }

        private string login = "";
        public string Login { set { login = value; } get { return login; } }


        private string codActividad = "0";
        public string CodActividad { set { codActividad = value; } get { return codActividad; } }

        private string codOrdenServicio = "0";
        public string CodOrdenServicio { set { codOrdenServicio = value; } get { return codOrdenServicio; } }

        private void frmObservacionxOrdenServicio_Load(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            calActividad.Value = n;
            clsTusuario1.FillByPermiso(dsSPXSeguridad1.usuario, 1063);
            cmbIngeniero.SelectedValue = Login;

            if (codActividad.Trim() != string.Empty)
            {//insertamos
                actividadxordenServicioTableAdapter1.FillBycodOrdenServicioCodActividad(dsSpx1.actividadxordenServicio,
                    int.Parse(codOrdenServicio), int.Parse(codActividad));
                if (dsSpx1.actividadxordenServicio.Rows.Count > 0)
                {
                    calActividad.Value = dsSpx1.actividadxordenServicio[0].fecha;
                    cmbIngeniero.SelectedValue = dsSpx1.actividadxordenServicio[0].loginAutor;
                    txtObservacion.Text = dsSpx1.actividadxordenServicio[0].observacion;
                    chkConfidencial.Checked = dsSpx1.actividadxordenServicio[0].confidencial;
                }
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (codActividad.Trim() == string.Empty)
            {//insertamos
                int codAc = int.Parse(actividadxordenServicioTableAdapter1.verNextId(int.Parse(codOrdenServicio)).ToString());
                actividadxordenServicioTableAdapter1.Insert(int.Parse(codOrdenServicio),
                    codAc, calActividad.Value, txtObservacion.Text, cmbIngeniero.SelectedValue.ToString(),
                    chkConfidencial.Checked);
            }else {
                actividadxordenServicioTableAdapter1.UpdateQuery(int.Parse(codOrdenServicio),
                    int.Parse(codActividad), calActividad.Value, txtObservacion.Text, cmbIngeniero.SelectedValue.ToString(),
                    chkConfidencial.Checked);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cmbIngeniero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}