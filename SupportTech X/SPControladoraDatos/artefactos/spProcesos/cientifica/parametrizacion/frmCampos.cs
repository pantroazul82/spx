using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.cientifica.parametrizacion
{
    public partial class frmCampos : Form
    {
        public frmCampos()
        {
            InitializeComponent();
        }

        public string codigoTemplate { set; get; }
        public string codigoCampo { set; get; }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void frmCampos_Load(object sender, EventArgs e)
        {
            if (codigoCampo != null && codigoCampo.Trim() != string.Empty) 
            {
                SPControladoraDatos.dsCientifica ds = new SPControladoraDatos.dsCientifica();
                SPControladoraDatos.dsCientificaTableAdapters.campos_template_revisionTableAdapter campos = new SPControladoraDatos.dsCientificaTableAdapters.campos_template_revisionTableAdapter();

                campos.FillBycod_campos_template_revision(ds.campos_template_revision, int.Parse(codigoCampo));
                if (!ds.campos_template_revision[0].IscampoNull())
                cmbCampo.Text = ds.campos_template_revision[0].campo;
                
                if (!ds.campos_template_revision[0].IsfilaNull())
                nmFila.Value = ds.campos_template_revision[0].fila;

                if (!ds.campos_template_revision[0].IscolumnaNull())
                nmColumna.Value = ds.campos_template_revision[0].columna;

                if (!ds.campos_template_revision[0].IsesBoleanoNull())
                chkEsBoleano.Checked = ds.campos_template_revision[0].esBoleano;
                if (!ds.campos_template_revision[0].IsesNegadoNull())
                chkEsBoleanoNegado.Checked = ds.campos_template_revision[0].esNegado;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbCampo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe seleccionar el campo");
                return;
            }
            SPControladoraDatos.dsCientificaTableAdapters.campos_template_revisionTableAdapter campos = new SPControladoraDatos.dsCientificaTableAdapters.campos_template_revisionTableAdapter();
            if (codigoCampo != null && codigoCampo.Trim() != string.Empty)
            {
                campos.UpdateQuery(cmbCampo.Text, (int)nmFila.Value, (int)nmColumna.Value,chkEsBoleano.Checked,chkEsBoleanoNegado.Checked,
                    int.Parse(codigoCampo));
            } else {
                campos.Insert(int.Parse(codigoTemplate), cmbCampo.Text, (int)nmFila.Value, (int)nmColumna.Value,chkEsBoleano.Checked,chkEsBoleanoNegado.Checked);
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
