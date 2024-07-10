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
    public partial class frmParametrosCientifica : Form
    {
        public frmParametrosCientifica()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            parametro_cientificaTableAdapter1.UpdateQuery(txtVersionLlamada.Text,
                txtTipoDocumentoLlamada.Text, txtCodigoLlamada.Text, txtImplementacionLlamada.Text,
                dsSpx1.parametro_cientifica[0].cod_parametro_cientifica);

            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void frmParametrosCientifica_Load(object sender, EventArgs e)
        {
            parametro_cientificaTableAdapter1.Fill(dsSpx1.parametro_cientifica);
            if(dsSpx1.parametro_cientifica.Count<=0)
            {
                parametro_cientificaTableAdapter1.Insert("", "", "", "");
                parametro_cientificaTableAdapter1.Fill(dsSpx1.parametro_cientifica);
            }

            txtCodigoLlamada.Text = dsSpx1.parametro_cientifica[0].codigo_documento_llamada.Trim();
            txtImplementacionLlamada.Text = dsSpx1.parametro_cientifica[0].implementacion_documento_llamada.Trim();
            txtTipoDocumentoLlamada.Text = dsSpx1.parametro_cientifica[0].tipo_documento_llamada.Trim();
            txtVersionLlamada.Text = dsSpx1.parametro_cientifica[0].version_formato_llamada.Trim();
        }
    }
}
