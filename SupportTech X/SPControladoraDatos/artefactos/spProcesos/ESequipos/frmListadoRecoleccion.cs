using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.ESequipos
{
    public partial class frmListadoRecoleccion : Form
    {
        public frmListadoRecoleccion()
        {
            InitializeComponent();
        }

        public string serial { set; get; }
        public int codRecoleccion{ set; get; }

        private void frmListadoRecoleccion_Load(object sender, EventArgs e)
        {
            dsSpx1.EnforceConstraints = false;
            recoleccionTableAdapter1.FillByPendienteEquipo(dsSpx1.recoleccion, serial);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(grdDatos.Columns["codRecoleccion"].Text.Trim() == string.Empty)return;

            codRecoleccion = int.Parse(grdDatos.Columns["codRecoleccion"].Text);
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }
    }
}
