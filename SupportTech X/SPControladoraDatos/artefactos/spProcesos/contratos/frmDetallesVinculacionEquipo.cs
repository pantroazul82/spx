using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.contratos
{
    public partial class frmDetallesVinculacionEquipo : Form
    {
        public frmDetallesVinculacionEquipo()
        {
            InitializeComponent();
        }

        public int mantenimientosIncluidos { set { nmMantenimientosIncluidos.Value = (decimal)value; } get { return (int)nmMantenimientosIncluidos.Value; } }
        public int mantenimientosRealizados { set { nmMantenimientosRealizados.Value = (decimal)value; } get { return (int)nmMantenimientosRealizados.Value; } }
        public bool esActivo { set { chkActivo.Checked = value; } get { return chkActivo.Checked; } }


        public bool editableRealizados = true;
        public bool EditableRealizados { set { editableRealizados = value; } get { return editableRealizados; } }

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

        private void frmDetallesVinculacionEquipo_Load(object sender, EventArgs e)
        {
            nmMantenimientosRealizados.Enabled = editableRealizados;
        }
    }
}
