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
    public partial class frmDomingosAutomaticos : Form
    {
        public frmDomingosAutomaticos()
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
            int creados=0;
            clsTdias_festivos clsTdias_festivos1 = new clsTdias_festivos();
            DateTime d=new DateTime(int.Parse(cmbAno.Text),1,1);
            for (int k = 0; k < 366; k++)
            {
                if (d.DayOfWeek == DayOfWeek.Sunday && d.Year == int.Parse(cmbAno.Text))
                {
                ////validamos si 
                    clsTdias_festivos1.FillByday_of_year(dsFestivos1.dias_festivos, k + 1,d.Year);
                    if (dsFestivos1.dias_festivos.Count <= 0)
                    {
                        clsTdias_festivos1.Insert(d.Day, d.Month, d.Year, d);
                        creados++;
                    }
                }
                   d= d.AddDays(1);
            }

            MessageBox.Show("Se crearon "+creados+" nuevos registros de dias festivos.","Alerta");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmDomingosAutomaticos_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

           DataConector obj = new DataConector();
            DateTime d = obj.fechaServer;

            //cargamos todos los anos
            for (int k = 2010; k <= d.Year; k++)
            {
                cmbAno.Items.Add("" + k);
            }
            cmbAno.SelectedIndex= cmbAno.Items.Count-1;
        }
    }
}
