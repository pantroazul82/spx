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
    public partial class frmTipoAsesoria : Form
    {
        public frmTipoAsesoria()
        {
            InitializeComponent();
        }
        public int codTipoAsesoria { set; get; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtTipoAsesoria.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El tipo de asesoria es obligatorio!");
                return;
            }
            if (txtAbreviatura.Text.Trim() == string.Empty)
            {
                MessageBox.Show("La abreviatura es obligatoria!");
                return;
            }
            if (codTipoAsesoria == 0)
            {
                tipo_asesoriaTableAdapter1.Insert(txtTipoAsesoria.Text,txtAbreviatura.Text);
            }
            else {
                tipo_asesoriaTableAdapter1.UpdateQuery(txtTipoAsesoria.Text,txtAbreviatura.Text,codTipoAsesoria);
            
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmTipoAsesoria_Load(object sender, EventArgs e)
        {
            if (codTipoAsesoria != 0)
            {
                tipo_asesoriaTableAdapter1.FillBycod_tipo_asesoria(dsSpx1.tipo_asesoria, codTipoAsesoria);
                txtAbreviatura.Text = dsSpx1.tipo_asesoria[0].abreviatura.Trim();
                txtTipoAsesoria.Text = dsSpx1.tipo_asesoria[0].nombre_tipo_asesoria.Trim();
            }
        }
    }
}
