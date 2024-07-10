using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SPControladoraDatos.artefactos;

namespace SPXSeguridad.Clases
{
    public partial class barraSeguridad : UserControl
    {
        public barraSeguridad()
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

        private void btnCambiarPass_Click(object sender, EventArgs e)
        {
            SPXSeguridad.frm.frmSeleccionarPassword fr = new SPXSeguridad.frm.frmSeleccionarPassword();
            fr.password = "";
            SPXSeguridad.data.dsSPXSeguridad ds=new SPXSeguridad.data.dsSPXSeguridad();
            SPXSeguridad.data.cls.clsTusuario usuarioTableAdapter1 = new SPXSeguridad.data.cls.clsTusuario();
            usuarioTableAdapter1.FillBycod_usuario(ds.usuario, SPXSeguridad.logica.sesion.CodUsuarioAutenticado);
            fr.password = ds.usuario[0].password;
            fr.Icon = FindForm().Icon;
            if (fr.ShowDialog() == DialogResult.OK)
            {
                string pass = fr.password;
                if(fr.password != string.Empty)
                {
                    Login l = new Login();
                    pass = l.cifrarPassword(fr.password);
                }
                usuarioTableAdapter1.UpdatePassword(pass, DateTime.Now, SPXSeguridad.logica.sesion.CodUsuarioAutenticado);
            }
        }

        private void btnFunciones_Click(object sender, EventArgs e)
        {
            SPXSeguridad.frm.frmFuncionalidades frmUsr = new SPXSeguridad.frm.frmFuncionalidades();
            verificarPermiso(1, frmUsr, false);
        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            SPXSeguridad.frm.frmGrupoUsuario frmUsr = new SPXSeguridad.frm.frmGrupoUsuario();
            verificarPermiso(1, frmUsr, false);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            SPXSeguridad.frm.frmUsuarios frmUsr = new SPXSeguridad.frm.frmUsuarios();
            verificarPermiso(1, frmUsr, false);
        }

        private void btnPermisos_Click(object sender, EventArgs e)
        {
            SPXSeguridad.frm.frmPermisos frmGrp = new SPXSeguridad.frm.frmPermisos();
            verificarPermiso(1, frmGrp, false);
        }
    }
}
