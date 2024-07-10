using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.cientifica.proceso
{
    public partial class frmCerrarOrdenEnSeguimiento : Form
    {
        public frmCerrarOrdenEnSeguimiento()
        {
            InitializeComponent();
        }

        public int codAsesoria { set; get; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool validar() 
        {
            if (!rdNoControlCalidad.Checked && !rdSiControlCalidad.Checked)
            {
                MessageBox.Show("Debe ingresar si requiere control de calidad o no!");
                return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //actualiza el estado
            if (!validar()) return;
            asesoria_cientificaTableAdapter1.UpdateRequiere_control_calidad(rdSiControlCalidad.Checked, codAsesoria);
            DialogResult = DialogResult.OK;
            Close();
        }
        
        private void frmCerrarOrden_Load(object sender, EventArgs e)
        {
            asesoria_cientificaTableAdapter1.FillByCod_asesoria_cientifica(dsSpx1.asesoria_cientifica, codAsesoria);
            txtAsesoriaNumero.Text = dsSpx1.asesoria_cientifica[0].cod_asesoria_cientifica.ToString();
        }
   
    }
}
