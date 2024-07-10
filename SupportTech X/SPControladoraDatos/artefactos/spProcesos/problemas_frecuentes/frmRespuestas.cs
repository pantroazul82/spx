using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.problemas_frecuentes
{
    public partial class frmRespuestas : Form
    {
        public frmRespuestas()
        {
            InitializeComponent();
        }

        public int codProblema { set; get; }
        public int codRespuesta { set; get; }
        SPControladoraDatos.dsSpxTableAdapters.problemas_frecuentesTableAdapter problemas_frecuentesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.problemas_frecuentesTableAdapter();
        private void frmRespuestas_Load(object sender, EventArgs e)
        {
            if (codProblema != 0)
            {
                problemas_frecuentesTableAdapter1.FillBycod_problema_frecuente(dsSpx1.problemas_frecuentes, codProblema);
                string a = dsSpx1.problemas_frecuentes[0].cod_manual.Trim();
                //luego calculamos cuantas soluciones tiene el problema
                soluciones_problemasTableAdapter1.FillBycod_problema_frecuente(dsSpx1.soluciones_problemas, codProblema);
                a = a + "-" + (dsSpx1.soluciones_problemas.Count + 1).ToString().PadLeft(3, '0');
                txtNombre.Text = a;
            }
            if (codRespuesta != 0)
            {
                soluciones_problemasTableAdapter1.FillBycod_soluciones_problemas(dsSpx1.soluciones_problemas, codRespuesta);
                txtNombre.Text = (dsSpx1.soluciones_problemas[0].Isnombre_solucionNull()) ? "" : dsSpx1.soluciones_problemas[0].nombre_solucion.Trim();
                txtObservacion.Text =(dsSpx1.soluciones_problemas[0].Isdescripcion_solucionNull())?"" :dsSpx1.soluciones_problemas[0].descripcion_solucion.Trim();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool validar() 
        {
            if (txtNombre.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El nombre es Obligatorio","Error");
                return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!validar()) 
            {
                return;
            }

            if (codRespuesta == 0)
            {
                soluciones_problemasTableAdapter1.Insert(codProblema, txtNombre.Text, txtObservacion.Text);
            }else{
                soluciones_problemasTableAdapter1.UpdateQuery(txtNombre.Text, txtObservacion.Text,codRespuesta);
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
