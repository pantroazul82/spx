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
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            clsTdias_festivos obj = new clsTdias_festivos();
            if (calInicio.SelectedDate.Year < 2000)
            {
                MessageBox.Show("Seleccione una fecha de inicio valida!");
                return;
            }
            if (calFin.SelectedDate.Year < 2000)
            {
                MessageBox.Show("Seleccione una fecha de fin valida!");
                return;
            }
            int a=obj.verDiasNoHabiles(calInicio.SelectedDate , calFin.SelectedDate);
            lblMensaje.Text = "Existen " + a + " dias no habiles entre las fechas";
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);
        }
    }
}
