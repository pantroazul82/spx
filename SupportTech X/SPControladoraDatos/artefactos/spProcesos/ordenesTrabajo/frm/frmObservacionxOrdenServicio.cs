using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.ordenesTrabajo
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

        private bool puedeAsignarxOtro = false;
        public bool PuedeAsignarxOtro { set { puedeAsignarxOtro = value; } get { return puedeAsignarxOtro; } }
        private string login = "";
        public string Login { set { login = value; } get { return login; } }


        private string codActividad = "0";
        public string CodActividad { set { codActividad = value; } get { return codActividad; } }

        private string codOrdenServicio = "0";
        public string CodOrdenServicio { set { codOrdenServicio = value; } get { return codOrdenServicio; } }

        private void frmObservacionxOrdenServicio_Load(object sender, EventArgs e)
        {
            
            panel1.BackColor = SPControladoraDatos.artefactos.SPXUtilidades.Themes.ThemeManager.verColor();
            
            calActividad.fechaValue = DateTime.Now;
            clsTusuario1.FillByPermiso(dsSPXSeguridad1.usuario, 1063);
            
            cmbIngeniero.SelectedValue = Login;

            if (codActividad.Trim() != string.Empty)
            {//insertamos
                actividadxordenServicioTableAdapter1.FillBycodOrdenServicioCodActividad(dsSpx1.actividadxordenServicio,
                    int.Parse(codOrdenServicio), int.Parse(codActividad));
                if (dsSpx1.actividadxordenServicio.Rows.Count > 0)
                {
                    calActividad.fechaValue = dsSpx1.actividadxordenServicio[0].fecha;
                    cmbIngeniero.SelectedValue = dsSpx1.actividadxordenServicio[0].loginAutor;
                    txtObservacion.Text = dsSpx1.actividadxordenServicio[0].observacion;
                    chkConfidencial.Checked = dsSpx1.actividadxordenServicio[0].confidencial;
                }
            }
            if (!puedeAsignarxOtro) {  
                cmbIngeniero.Enabled = false;
                cmbIngeniero.SelectedValue = SPXSeguridad.logica.sesion.LoginUsuarioAutenticado;
            }
            txtObservacion.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void guardar() 
        {
            if (codActividad.Trim() == string.Empty)
            {//insertamos
                int codAc = int.Parse(actividadxordenServicioTableAdapter1.verNextId(int.Parse(codOrdenServicio)).ToString());
                actividadxordenServicioTableAdapter1.Insert(int.Parse(codOrdenServicio),
                    codAc, calActividad.fechaValue, txtObservacion.Text, cmbIngeniero.SelectedValue.ToString(),chkConfidencial.Checked);
            }
            else
            {
                actividadxordenServicioTableAdapter1.UpdateQuery(int.Parse(codOrdenServicio),
                    int.Parse(codActividad), calActividad.fechaValue, txtObservacion.Text, cmbIngeniero.SelectedValue.ToString(), chkConfidencial.Checked);
            }
        
        }

        private void btnGuardarSinCerrar_Click(object sender, EventArgs e)
        {
            guardar();
            txtObservacion.Text = "";
            txtObservacion.Focus();
            codActividad = "";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            guardar();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnBuscarActividad_Click(object sender, EventArgs e)
        {
            SpFrm.generales.frmActividadxModelo frm = new SpFrm.generales.frmActividadxModelo();
            frm.CodFabricante = ordenServicioTableAdapter1.verFabricante(int.Parse(codOrdenServicio)); ;
            frm.CodModelo = ordenServicioTableAdapter1.verModelo(int.Parse(codOrdenServicio)); ;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtObservacion.Text = frm.actividad;
            }
        }

        private void cmbIngeniero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}