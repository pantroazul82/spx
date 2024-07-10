using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.ordenesTrabajo
{
    public partial class frmEscogeIngenero : Form
    {
        public frmEscogeIngenero()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private string loginActual = "";

        public string LoginActual { set { loginActual = value; } get { return loginActual; } }
        public string LoginNuevo { get { return cmbIngeniero.SelectedValue.ToString(); } }
        public string motivoReasignacion { get { return txtMotivo.Text.Trim(); } }

        private void frmEscogeIngenero_Load(object sender, EventArgs e)
        {
            clsTusuario1.FillBylogin(dsSPXSeguridad1.usuario, loginActual);
            if (dsSPXSeguridad1.usuario.Count > 0)
            {
                lblIngenieroActualmente.Text = dsSPXSeguridad1.usuario[0].nombre ;
            }
            //hacemos un fill a el combo de ingenieros
            clsTusuario1.FillByPermiso(dsSPXSeguridad1.usuario, 1063); cmbIngeniero.Text = "";
        }

        private void cmbIngeniero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIngeniero.SelectedValue == null || cmbIngeniero.SelectedValue.ToString().Trim() == string.Empty) return;

            clsTusuario1.FillBylogin(dsSPXSeguridad1.usuario, cmbIngeniero.SelectedValue.ToString());
            if (dsSPXSeguridad1.usuario.Count > 0)
            {
                lblIngeniero.Text = dsSPXSeguridad1.usuario[0].nombre;
            }
            else {
                lblIngeniero.Text = "";
            }
       }

        private void btnLimpiarIngeniero_Click(object sender, EventArgs e)
        {
            cmbIngeniero.Text = "";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //validamos
            if (cmbIngeniero.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Para reasignar una orden de servicio debe escojer un ingeniero");
                return;  
            }
            if (loginActual.Trim()  == cmbIngeniero.SelectedValue.ToString().Trim())
            {
                MessageBox.Show("Para reasignar una orden de servicio debe escojer otro ingeniero");
                return;
            }
            DialogResult = DialogResult.OK;            
            Close();
        }
    }
}
