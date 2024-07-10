using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.cientifica
{
    public partial class frmProblemaComun : Form
    {
        public frmProblemaComun()
        {
            InitializeComponent();
        }

        public int codProblemaComun { set; get; }

        private void frmProblemaComun_Load(object sender, EventArgs e)
        {
            if (codProblemaComun != 0)
            {
                problemas_comunes_cientificaTableAdapter1.FillBycod_problemas_comunes_cientifica(dsSpx1.problemas_comunes_cientifica,
                    codProblemaComun);
                txtDescripcion.Text =    dsSpx1.problemas_comunes_cientifica[0].descripcion_problema_comun.Trim();
                txtTituloProblemaComun.Text = dsSpx1.problemas_comunes_cientifica[0].titulo_problema_comun.Trim();
                txtSolucionPropuesta.Text = dsSpx1.problemas_comunes_cientifica[0].solucion_propuesta.Trim();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtTituloProblemaComun.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El titulo es obligatorio","Error de validacion");
                return;
            }
            if (codProblemaComun == 0)
            {
                problemas_comunes_cientificaTableAdapter1.Insert(
                    txtTituloProblemaComun.Text, txtDescripcion.Text, txtSolucionPropuesta.Text);
            }else {
                problemas_comunes_cientificaTableAdapter1.UpdateQuery(
                    txtTituloProblemaComun.Text, txtDescripcion.Text, txtSolucionPropuesta.Text,
                    codProblemaComun);
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
