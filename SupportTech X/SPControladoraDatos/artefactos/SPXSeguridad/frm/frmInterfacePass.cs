using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SPXSeguridad.frm
{
    public partial class frmInterfacePass : Form
    {
        public frmInterfacePass()
        {
            InitializeComponent();
        }

        private void frmInterfacePass_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

            this.Visible = false;
            SPXSeguridad.frm.frmSeleccionarPassword fr = new SPXSeguridad.frm.frmSeleccionarPassword();
            fr.password = "";
            SPXSeguridad.data.dsSPXSeguridad ds = new SPXSeguridad.data.dsSPXSeguridad();
            SPXSeguridad.data.cls.clsTusuario usuarioTableAdapter1 = new SPXSeguridad.data.cls.clsTusuario();
            usuarioTableAdapter1.FillBycod_usuario(ds.usuario, SPXSeguridad.logica.sesion.CodUsuarioAutenticado);
            fr.password = ds.usuario[0].password;
            fr.Icon = FindForm().Icon;
            if (fr.ShowDialog() == DialogResult.OK)
            {
                string pass = fr.password;
                if (fr.password != string.Empty)
                {
                    Login l = new Login();
                    pass = l.cifrarPassword(fr.password);
                }
               DataConector dc = new DataConector();
                DateTime n = dc.fechaServer;
                usuarioTableAdapter1.UpdatePassword(pass, n, SPXSeguridad.logica.sesion.CodUsuarioAutenticado);
            }
            DialogResult = fr.DialogResult;
            Close();
        }
    }
}
