using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SPXSeguridad.Clases
{
    public partial class barraLinea : UserControl
    {
        public barraLinea()
        {
            InitializeComponent();
        }

        private void verificarPermiso(int modulo, System.Windows.Forms.Form formulario, bool dialogo)
        {
           SPXSeguridad.verificadorPermisos ver = new verificadorPermisos();
            ver.codModulo = modulo;
            ver.codUsuario = SPXSeguridad.logica.sesion.CodUsuarioAutenticado;
            ver.solicitarAutorizacion();
            if (ver.Ejecutar)
            {
                formulario.Icon = this.FindForm().Icon;
                formulario.Owner = this.FindForm();
                if (dialogo) formulario.ShowDialog();
                else formulario.Show();
            }else{
                formulario.Dispose();
                MessageBox.Show("No tiene los suficientes permisos para ejecutar esta accion.!", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnLineas_Click(object sender, EventArgs e)
        {
            SPXSeguridad.linea.frmLinea fr = new linea.frmLinea();
            verificarPermiso(1, fr, false);
        }

        private void btnLineasxUsuario_Click(object sender, EventArgs e)
        {
            SPXSeguridad.linea.frmLineasxUsuario fr = new SPXSeguridad.linea.frmLineasxUsuario();
            verificarPermiso(1, fr, false);
        }


    }
}
