using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.ordenesTrabajo
{
    public partial class frmMisOrdenesPendientes : Form
    {
        public frmMisOrdenesPendientes()
        {
            InitializeComponent();
        }

        private void frmMisOrdenesPendientes_Load(object sender, EventArgs e)
        {
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\MisOrdenesPendLayt.xs";
            if(System.IO.File.Exists(str))
                grddatos.LoadLayout(str);
            dsPlantillas1.EnforceConstraints = false;
            pltListadoOrdenServicioTableAdapter1.FillByAsignadoA
                (dsPlantillas1.pltListadoOrdenServicio,SPXSeguridad.logica.sesion.LoginUsuarioAutenticado);
            
        }

        private void btnVerOrden_Click(object sender, EventArgs e)
        {
            if (grddatos.Columns[0].Text.Trim() == string.Empty) return;
            spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo frmObj = new frmNuevaOrdenTrabajo();
            frmObj.CodOrdenServicio = grddatos.Columns[0].Text;
            frmObj.Show();
        }

        private void rdInternas_CheckedChanged(object sender, EventArgs e)
        {
            cambiarVisibilidad();
        }

        private void rdExternas_CheckedChanged(object sender, EventArgs e)
        {
            cambiarVisibilidad();
        }

        private void tdTodas_CheckedChanged(object sender, EventArgs e)
        {
            cambiarVisibilidad();
        }

        private void cambiarVisibilidad() 
        {

            if (rdExternas.Checked)
            {
                grddatos.Columns["esInterno"].FilterText="False";

            }
            else if (rdInternas.Checked)
            {
                grddatos.Columns["esInterno"].FilterText = "True";
            }            else
            {

                grddatos.Columns["esInterno"].FilterText = "";
            }
        }

 
        
        private void btnExportarExcel_Click_1(object sender, EventArgs e)
        {
SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel objEx = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            objEx.exportar(grddatos, "Mis Ordenes de Servicio", false);
            System.Media.SystemSounds.Exclamation.Play();
        }

        private void btnGuardarGrilla_Click(object sender, EventArgs e)
        {
            //guardamos la configuracion de la grilla
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\MisOrdenesPendLayt.xs";
            grddatos.SaveLayout(str);
        }

        private void btnReinicciargrilla_Click(object sender, EventArgs e)
        {
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\MisOrdenesPendLayt.xs";
            System.IO.File.Delete(str);
            MessageBox.Show("Los Cambios se veran reflejados cuando cargue de nuevo el formulario.","");
        }
    }
}
