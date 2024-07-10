using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.llamadasTecnicas
{
    public partial class frmREsultadoFinal : Form
    {
        public frmREsultadoFinal()
        {
            InitializeComponent();
        }
        public int codResultadoFinal { set; get; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtResultadoFinal.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El tipo de asesoria es obligatorio!");
                return;
            }
            if (txtAbreviatura.Text.Trim() == string.Empty)
            {
                MessageBox.Show("La abreviatura es obligatoria!");
                return;
            }
            if (codResultadoFinal == 0)
            {
                resultado_final_llamadaTableAdapter1.Insert(txtResultadoFinal.Text, txtAbreviatura.Text);
            }
            else {
                resultado_final_llamadaTableAdapter1.UpdateQuery(txtResultadoFinal.Text, txtAbreviatura.Text, codResultadoFinal);
            
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmTipoAsesoria_Load(object sender, EventArgs e)
        {
            if (codResultadoFinal != 0)
            {
                resultado_final_llamadaTableAdapter1.FillBycod_resultado_final_llamada(dsSpx1.resultado_final_llamada, codResultadoFinal);
                txtAbreviatura.Text = dsSpx1.resultado_final_llamada[0].abreviatura.Trim();
                txtResultadoFinal.Text = dsSpx1.resultado_final_llamada[0].resultado_final_llamada.Trim();
            }
        }
    }
}
