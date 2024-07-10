using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SPControladoraDatos.artefactos.SPXUtilidades.Misc.festivos
{
    public partial class frmNewFestivo : Form
    {
        public frmNewFestivo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DateTime d = monthCalendarAdv1.SelectedDate;
            clsTdias_festivos clsTdias_festivos1 = new clsTdias_festivos();
                clsTdias_festivos1.FillByday_of_year(dsFestivos1.dias_festivos, d.DayOfYear,d.Year);
                if (dsFestivos1.dias_festivos.Count <= 0)
                {
                    clsTdias_festivos1.Insert(d.Day, d.Month, d.Year, d);
                }
                DialogResult = DialogResult.OK;
            
        }

        private void frmNewFestivo_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

           DataConector dc = new DataConector();
            DateTime n = dc.fechaServer;
            monthCalendarAdv1.DisplayMonth= n;
        }
    }
}
