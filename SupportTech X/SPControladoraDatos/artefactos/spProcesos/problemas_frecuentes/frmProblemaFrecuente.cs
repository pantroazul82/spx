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
    public partial class frmProblemaFrecuente : Form
    {
        public frmProblemaFrecuente()
        {
            InitializeComponent();
        }

        public int codProblema { set;get; }
        public string codModelo { set;get; }
        public string codFaricante { set; get; }

        private void frmProblemaFrecuente_Load(object sender, EventArgs e)
        {
            if (codProblema != 0)
            {
                problemas_frecuentesTableAdapter1.FillBycod_problema_frecuente(dsSpx1.problemas_frecuentes, codProblema);
                txtCodManual.Text = (dsSpx1.problemas_frecuentes[0].Iscod_manualNull()) ? "" : dsSpx1.problemas_frecuentes[0].cod_manual.Trim();
                txtNombre.Text = (dsSpx1.problemas_frecuentes[0].Isnombre_problemaNull()) ? "" : dsSpx1.problemas_frecuentes[0].nombre_problema.Trim();
                txtObservacion.Text = (dsSpx1.problemas_frecuentes[0].IsdescripcionNull()) ? "" : dsSpx1.problemas_frecuentes[0].descripcion.Trim();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool validar() 
        {
            if (txtCodManual.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El codigo manual es obligatorio","Error");
                return false;
            }

            if (txtNombre.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El Nombre es obligatorio", "Error");
                return false;
            }

            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!validar()) return;

            //guardo
            if (codProblema == 0)
            {
                problemas_frecuentesTableAdapter1.Insert(codFaricante, codModelo, txtCodManual.Text,
                    txtNombre.Text, txtObservacion.Text);
            }else {
                problemas_frecuentesTableAdapter1.UpdateQuery(txtCodManual.Text,
                        txtNombre.Text, txtObservacion.Text,codProblema);
            }

            DialogResult = DialogResult.OK;
            Close();


        }
    }
}
