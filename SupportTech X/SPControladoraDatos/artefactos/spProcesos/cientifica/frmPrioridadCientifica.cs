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
    public partial class frmPrioridadCientifica : Form
    {
        public frmPrioridadCientifica()
        {
            InitializeComponent();
        }

        public int codPrioridad { set; get; }

        private void frmPrioridadCientifica_Load(object sender, EventArgs e)
        {
            if (codPrioridad != 0)
            {
                prioridad_callcenter_cientificaTableAdapter1.FillBycod_prioridad_callcenter_cientifica(dsSpx1.prioridad_callcenter_cientifica,
                    codPrioridad);
                txtPrioridadCientifica.Text = dsSpx1.prioridad_callcenter_cientifica[0].nombre_prioridad.Trim();
                nmPrioridad.Value = dsSpx1.prioridad_callcenter_cientifica[0].relevancia;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtPrioridadCientifica.Text.Trim() == string.Empty)
            {
                MessageBox.Show("La prioridad es obligatoria","");
                return;
            }
            if (codPrioridad == 0)
            {
                prioridad_callcenter_cientificaTableAdapter1.Insert(txtPrioridadCientifica.Text, (int)nmPrioridad.Value);
            }
            else {
                prioridad_callcenter_cientificaTableAdapter1.UpdateQuery(txtPrioridadCientifica.Text, (int)nmPrioridad.Value,
                    codPrioridad);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
