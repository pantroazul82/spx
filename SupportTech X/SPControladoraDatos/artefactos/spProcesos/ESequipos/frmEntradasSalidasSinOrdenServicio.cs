using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.ESequipos
{
    public partial class frmEntradasSalidasSinOrdenServicio : Form
    {
        public frmEntradasSalidasSinOrdenServicio()
        {
            InitializeComponent();
        }

        string codEntrada = "";
        public string CodEntrada { set { codEntrada = value; } get { return codEntrada; } }

        private void frmEntradasSalidasSinOrdenServicio_Load(object sender, EventArgs e)
        {
            panel1.BackColor = SPControladoraDatos.artefactos.SPXUtilidades.Themes.ThemeManager.verColor();
            dsPlantillas1.EnforceConstraints = false;
            pltListadoESequiposTableAdapter1.FillBySinOrdenServicio(dsPlantillas1.pltListadoESequipos);
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\listESsinOrdenSLayt.xs";
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
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            obj.exportar(grdDatos, "Entradas Sin Orden", false);
        }
        private void btnGuardarGrilla_Click(object sender, EventArgs e)
        {
            //guardamos la configuracion de la grilla
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\listESsinOrdenSLayt.xs";
            grdDatos.SaveLayout(str);
            System.Media.SystemSounds.Exclamation.Play();
        }

        private void btnReinicciargrilla_Click(object sender, EventArgs e)
        {
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\listESsinOrdenSLayt.xs";
            System.IO.File.Delete(str);
            System.Media.SystemSounds.Exclamation.Play();
        }
    }
}