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
    public partial class frmInconvenientePresentado : Form
    {
        public frmInconvenientePresentado()
        {
            InitializeComponent();
        }

        public int codInconveniente { set; get; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtInconveniente.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El inconveniente es obligatorio!","Alerta");
                return;
            }
            if (codInconveniente == 0)
            {
                inconveniente_presentado_cientificaTableAdapter1.Insert(txtInconveniente.Text,chkActivo.Checked,chkIndicaReactivo.Checked,chkEquipo.Checked);
            }else {
                inconveniente_presentado_cientificaTableAdapter1.UpdateQuery(
                    txtInconveniente.Text, chkActivo.Checked, chkIndicaReactivo.Checked, chkEquipo.Checked, codInconveniente);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmInconvenientePresentado_Load(object sender, EventArgs e)
        {
            if (codInconveniente != 0)
            {
                inconveniente_presentado_cientificaTableAdapter1.FillBycod_inconveniente_presentado_cientifica(
                    dsSpx1.inconveniente_presentado_cientifica, codInconveniente
                    );
                txtInconveniente.Text = dsSpx1.inconveniente_presentado_cientifica[0].nombre_inconveniente.Trim();
                if (!dsSpx1.inconveniente_presentado_cientifica[0].IsactivoNull())
                chkActivo.Checked = dsSpx1.inconveniente_presentado_cientifica[0].activo;

                if (!dsSpx1.inconveniente_presentado_cientifica[0].Isind_reactivoNull())
                    chkIndicaReactivo.Checked = dsSpx1.inconveniente_presentado_cientifica[0].ind_reactivo;

                if (!dsSpx1.inconveniente_presentado_cientifica[0].Isind_equipoNull())
                    chkEquipo.Checked = dsSpx1.inconveniente_presentado_cientifica[0].ind_equipo;
            }
        }
    }
}
