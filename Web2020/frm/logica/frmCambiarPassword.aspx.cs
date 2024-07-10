using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2020.frm.logica
{
    public partial class frmCambiarPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsSeguridad obS = new clsSeguridad();
            obS.comprobarAcceso(Page, Session, Response, 0);
        }
        protected void btnCqmbiar_Click(object sender, EventArgs e)
        {
            //camnbiamos el pass
            SPXSeguridad.Login l = new SPXSeguridad.Login();
            string msg = "";
            if (!l.autenticar(Session["ss_login"].ToString().Trim(), txtAnterior.Text, ref msg))
            {
                lblError.Text = "El password anterior no coincide!";
                return;
            }

            if (txtNuevo.Text == string.Empty)
            {
                lblError.Text = "Ingrese el nuevo password!";
                return;
            }

            if (txtNuevo.Text != txtConfirmacion.Text)
            {
                lblError.Text = "El nuevo password no coincide con la confirmacion!";
                return;
            }
            //
            //  LdControladoraDatos.dsMysqlTableAdapters.
            SPXSeguridad.data.cls.clsTusuario usr = new SPXSeguridad.data.cls.clsTusuario();

            string pass = "";
            if (txtNuevo.Text.Trim() != string.Empty)
            {
                SPXSeguridad.Login ll = new SPXSeguridad.Login();
                pass = ll.cifrarPassword(txtNuevo.Text);
            }
            usr.UpdatePassword(pass, DateTime.Now, int.Parse(Session["ss_cod_usuario"].ToString()));

            lblError.Text = "Se cambio el password satisfactoriamente!";
            txtNuevo.Visible = false;
            txtConfirmacion.Visible = false;
            txtAnterior.Visible = false;
            btnCqmbiar.Visible = false;

        }
    }
}