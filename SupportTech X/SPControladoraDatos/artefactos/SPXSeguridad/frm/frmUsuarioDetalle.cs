using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SPControladoraDatos.artefactos;
using SPXSeguridad.data;

namespace SPXSeguridad.frm
{
    public partial class frmUsuarioDetalle : Form
    {
        public frmUsuarioDetalle()
        {
            InitializeComponent();
        }

        public int codUsuario { set; get; }

        private bool validar() 
        {
            if (txtLogin.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El login es obligatorio!");
                return false;
            }

            if (txtNombre.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El nombre es obligatorio!");
                return false;
            }

            if (codUsuario == 0)
            {
                SPXSeguridad.data.dsSPXSeguridad ds = new SPXSeguridad.data.dsSPXSeguridad();
                usuarioTableAdapter1.FillBylogin(ds.usuario, txtLogin.Text.Trim());
                if (ds.usuario.Count > 0)
                {
                    MessageBox.Show("El login ya existe en la base de datos!");
                    return false;
                }
            }else{
                SPXSeguridad.data.dsSPXSeguridad ds = new SPXSeguridad.data.dsSPXSeguridad();
              
                usuarioTableAdapter1.FillBylogin(ds.usuario, txtLogin.Text.Trim());
                if (ds.usuario.Count > 0 && 
                    ds.usuario[0].cod_usuario != codUsuario
                    )
                {
                    MessageBox.Show("El login ya existe en la base de datos y esta asociado a otro usuario!");
                    return false;
                }
            }

            if (txtCorreo.Text.Trim() != string.Empty)
            {
                if (txtCorreo.Text.IndexOf("@") < 0 || txtCorreo.Text.IndexOf(".") < 1)
                {
                    MessageBox.Show("El Email no esta en un formato valido.");
                    return false;
                }
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!validar()) return;
            if (codUsuario == 0)
            {
                
                frmSeleccionarPassword fr = new frmSeleccionarPassword();
                if (fr.ShowDialog() != DialogResult.OK) return;
                //lanzamos la ventana de password
               DataConector dc = new DataConector();
                DateTime n = dc.fechaServer;
                usuarioTableAdapter1.Insert(txtLogin.Text, txtNombre.Text,txtDocumento.Text, fr.password, chkBloqueado.Checked,
                    txtCorreo.Text,0,n,
                    (cmbTipoDocumento.SelectedValue == null)?(int?)null:int.Parse(cmbTipoDocumento.SelectedValue.ToString()));
            }else{
                usuarioTableAdapter1.UpdateQuery(txtLogin.Text, txtNombre.Text,txtDocumento.Text,
                    chkBloqueado.Checked, txtCorreo.Text,0,
                    (cmbTipoDocumento.SelectedValue == null)?(int?)null:int.Parse(cmbTipoDocumento.SelectedValue.ToString()),
                    codUsuario);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void frmUsuarioDetalle_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

            tipo_documentoTableAdapter1.Fill(dsSPXSeguridad1.tipo_documento);
            cmbTipoDocumento.SelectedValue = -1;
            if(codUsuario != 0)
            {
                btnCambiarPassword.Visible = true;
                usuarioTableAdapter1.FillBycod_usuario(dsSPXSeguridad1.usuario, codUsuario);

                txtLogin.Text = dsSPXSeguridad1.usuario[0].login.Trim();
                txtNombre.Text = dsSPXSeguridad1.usuario[0].nombre.Trim();

                if (!dsSPXSeguridad1.usuario[0].IsdocumentoNull())
                txtDocumento.Text = dsSPXSeguridad1.usuario[0].documento.Trim();

                if (!dsSPXSeguridad1.usuario[0].Iscod_tipo_documentoNull())
                cmbTipoDocumento.SelectedValue = dsSPXSeguridad1.usuario[0].cod_tipo_documento;

                if (!dsSPXSeguridad1.usuario[0].IscorreoNull())
                    txtCorreo.Text = dsSPXSeguridad1.usuario[0].correo.Trim();
                if(!dsSPXSeguridad1.usuario[0].Ises_bloqueadoNull())
                    chkBloqueado.Checked = dsSPXSeguridad1.usuario[0].es_bloqueado;
            }else{
                btnCambiarPassword.Visible = false;
            }
        }

        private void btnCambiarPassword_Click(object sender, EventArgs e)
        {
            // if(SPControladoraDatos.artefactos.SPXprincipal.dsSPXSeguridad1.usuario.Count<=0)return;
            if (dsSPXSeguridad1.usuario.Count<=0 ) return;
            frmSeleccionarPassword fr = new frmSeleccionarPassword();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Login l = new Login();
                string pass=fr.password;
                if(pass.Trim() != string.Empty)
                {
                pass= l.cifrarPassword(pass);
                }
                usuarioTableAdapter1.UpdatePassword(pass ,DateTime.Now, codUsuario);
            }
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            frmTipoDocumento fr = new frmTipoDocumento();
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                object a =cmbTipoDocumento.SelectedValue;
                tipo_documentoTableAdapter1.Fill(dsSPXSeguridad1.tipo_documento);
                if (a == null)
                {
                    cmbTipoDocumento.SelectedValue = -1;
                }
                else
                {
                    cmbTipoDocumento.SelectedValue = a;
                }
            }
        }
    }
}
