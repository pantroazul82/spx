using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.Equipos
{
    public partial class frmAgregaArchivoxEquipo : Form
    {
        public frmAgregaArchivoxEquipo()
        {
            InitializeComponent();
        }

        public string tipoArchivo { get {return cmbTipoArchivo.SelectedValue.ToString(); } }
        public string observaciones { get { return txtObservaciones.Text; } }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmAgregaArchivoxEquipo_Load(object sender, EventArgs e)
        {
            tiposArchivoXequipoTableAdapter1.Fill(dsSpx1.TiposArchivoXequipo);
        }
    }
}