using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SPControladoraDatos.artefactos;

namespace SPControladoraDatos.artefactos.SPXUtilidades.Misc.festivos
{
    public partial class frmConfiguracionFestivos : Form
    {
        public frmConfiguracionFestivos()
        {
            InitializeComponent();
        }

        private void cargarAno() 
        {
            clsTdias_festivos obj = new clsTdias_festivos();
            obj.FillByano(dsFestivos1.dias_festivos, int.Parse(cmbAno.Text));
        }

        private void cmbAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarAno();
        }

        private void frmConfiguracionFestivos_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

           DataConector obj = new DataConector();
            DateTime d = obj.fechaServer;

            //cargamos todos los anos
            int k = 2010;
            for (; k <= d.Year; k++)
            {
                cmbAno.Items.Add("" + k);
            }
            cmbAno.SelectedIndex = cmbAno.Items.Count-1;
            cargarAno();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmNewFestivo fr = new frmNewFestivo();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                cargarAno();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmConfiguracionFestivos fr = new frmConfiguracionFestivos();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                cargarAno();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (grdDatos.Columns["cod_dias_festivos"].Text.Trim() != string.Empty)
            {
                if(MessageBox.Show("Esta seguro de eliminar el registro?","Confirmacion",MessageBoxButtons.YesNo)== System.Windows.Forms.DialogResult.Yes){
                clsTdias_festivos obj = new clsTdias_festivos();
                obj.DeleteQuery(int.Parse( grdDatos.Columns["cod_dias_festivos"].Text ));
                cargarAno();
                }
            }
        }

        private void btnCrearDomingos_Click(object sender, EventArgs e)
        {
            frmDomingosAutomaticos fr = new frmDomingosAutomaticos();
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                cargarAno();
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            frmTest fr = new frmTest();
            fr.Show();
        }
    }
}
