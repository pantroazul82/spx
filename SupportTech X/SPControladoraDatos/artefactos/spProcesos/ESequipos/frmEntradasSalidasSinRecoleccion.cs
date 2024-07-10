using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.ESequipos
{
    public partial class frmEntradasSalidasSinRecoleccion : Form
    {
        public frmEntradasSalidasSinRecoleccion()
        {
            InitializeComponent();
        }

        string codEntrada = "";
        public string CodEntrada { set { codEntrada = value; } get { return codEntrada; } }
        public string Serial { set; get; }
        public DateTime fechaEntrada { set; get; }

        private void frmEntradasSalidasSinOrdenServicio_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.SteelBlue;
            dsPlantillas1.EnforceConstraints = false;
            pltListadoESequiposTableAdapter1.FillBySinRecoleccion(dsPlantillas1.pltListadoESequipos,Serial);
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\listESsinReco.xs";
            if (System.IO.File.Exists(str))
                grdDatos.LoadLayout(str);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns[0].Text.Trim() == string.Empty) 
            {
                MessageBox.Show("Debe escoger una entrada del listado");
                return;
            }
            codEntrada = grdDatos.Columns["codEntradaSalidaEquipos"].Text.Trim();
            fechaEntrada = DateTime.Parse(grdDatos.Columns["fechaEntrada"].Text);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            obj.exportar(grdDatos, "Entradas Sin Recoleccion", false);
        }
        private void btnGuardarGrilla_Click(object sender, EventArgs e)
        {
            //guardamos la configuracion de la grilla
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\listESsinReco.xs";
            grdDatos.SaveLayout(str);
            System.Media.SystemSounds.Exclamation.Play();
        }

        private void btnReinicciargrilla_Click(object sender, EventArgs e)
        {
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\listESsinReco.xs";
            System.IO.File.Delete(str);
            System.Media.SystemSounds.Exclamation.Play();
        }
    }
}