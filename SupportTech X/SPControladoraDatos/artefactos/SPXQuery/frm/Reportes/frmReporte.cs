using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace SPControladoraDatos.artefactos.SPXQuery.frm.Reportes
{
    public partial class frmReporte : Form
    {
        public frmReporte(C1.C1Report.C1Report reporte)
        {
            InitializeComponent();
            c1Report1 = reporte;
        }
        public bool autoManjarExcepcion = true;

        private void frmReporte_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

            try
            {
                System.Threading.Thread hilo = new System.Threading.Thread(new System.Threading.ThreadStart(cargarAnimacion));
                hilo.Start();
               DataConector obj = new DataConector();
                c1Report1.DataSource.ConnectionString = obj.CadenaConexionReportes;
                for (int k = 0; k < c1Report1.Fields.Count; k++)
                {
                    if (c1Report1.Fields[k].Subreport != null)
                        c1Report1.Fields[k].Subreport.DataSource.ConnectionString = obj.CadenaConexionReportes;
                }
                
                c1PrintPreviewControl1.Document = c1Report1.Document;
                
                frAnimacion.animacionEnd();
            }
            catch (Exception ex)
            {
                           
                if (frAnimacion != null && !frAnimacion.IsDisposed)
                    frAnimacion.animacionEnd();

                if (autoManjarExcepcion)
                {
                    if (ex.InnerException == null)
                        MessageBox.Show("Hay selecciones erroneas en las listas de filtro u orden.\n" + ex.Message);
                    else
                        MessageBox.Show("Hay selecciones erroneas en las listas de filtro u orden.\n" + ex.Message + "\nAdicional:" + ex.InnerException.Message);
                }
                else
                {
                    if (ex.InnerException == null)
                    throw(new Exception("Hay selecciones erroneas en las listas de filtro u orden.\n" + ex.Message));
                    else
                        throw(new Exception("Hay selecciones erroneas en las listas de filtro u orden.\n" + ex.Message + "\nAdicional:" + ex.InnerException.Message));
  
                }
            }
        }

        SPXFrmAnimacion.frmEfecto frAnimacion = new SPXFrmAnimacion.frmEfecto();
        private void cargarAnimacion()
        {
            frAnimacion = new SPXFrmAnimacion.frmEfecto();

            frAnimacion.Show();
            frAnimacion.animacion();
        }
    }
}
