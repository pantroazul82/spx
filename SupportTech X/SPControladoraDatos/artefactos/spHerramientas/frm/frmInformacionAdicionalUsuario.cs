using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spHerramientas.frm
{
    public partial class frmInformacionAdicionalUsuario : Form
    {
        public frmInformacionAdicionalUsuario()
        {
            InitializeComponent();
        }
        SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
        private void cargarInfousuario()
        {
            int codusuario = int.Parse(grdDatos.Columns["cod_usuario"].Text);
            
            usuarios.FillBycod_usuario(ds.informacion_adicional_usuario,
                codusuario);
            if (ds.informacion_adicional_usuario.Count > 0)
            {
                txtCargo.Text = ds.informacion_adicional_usuario[0].cargo;
                txtProfesion.Text = ds.informacion_adicional_usuario[0].profesion;
                if (!ds.informacion_adicional_usuario[0].Isimagen_firmaNull())
                {
                    Image im = Image.FromStream(new System.IO.MemoryStream(ds.informacion_adicional_usuario[0].imagen_firma));
                    picFirma.Image = im;
                }else {
                    picFirma.Image = null;
                }
            }else {
                txtCargo.Text = "";
                txtProfesion.Text = "";
                picFirma.Image = null;
            }
        }

        bool eventosEncendidos = false;
        private void frmInformacionAdicionalUsuario_Load(object sender, EventArgs e)
        {
            string sql = "select cod_usuario,nombre,login from usuario order by nombre";
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            grdDatos.DataSource= bd.ejecutarConsulta(sql).Tables[0];

            //cargar usuarios
            eventosEncendidos = true;
            cargarInfousuario();

        }

        private void grdDatos_RowColChange(object sender, C1.Win.C1TrueDBGrid.RowColChangeEventArgs e)
        {
            if (!eventosEncendidos) return;
            
                cargarInfousuario();
            
        }

        private void btnCambiarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog pf = new OpenFileDialog();
                if (pf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    picFirma.Image = Image.FromFile(  pf.FileName );
                }
            }catch{
            
            }
        }

        private void btnEditarInformacionAdicional_Click(object sender, EventArgs e)
        {
            if (!eventosEncendidos) return;
            habilitarBotones();
        }

        SPControladoraDatos.dsSpxTableAdapters.informacion_adicional_usuarioTableAdapter usuarios = new SPControladoraDatos.dsSpxTableAdapters.informacion_adicional_usuarioTableAdapter();

        private void btnAceptarEdicion_Click(object sender, EventArgs e)
        {
            if (!eventosEncendidos) return;
            int codusuario = int.Parse( grdDatos.Columns["cod_usuario"].Text);
            //------- //---------//
            byte[] buffer = null;
            if (picFirma.Image != null)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                picFirma.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                buffer=ms.ToArray();
                
            }
            //usuarios.FillBycod_usuario(ds.informacion_adicional_usuario, codusuario);
            //validamos si se inserta o se actualiza
            if (ds.informacion_adicional_usuario.Count > 0)
            {
                usuarios.UpdateByCodUsuario(
                txtCargo.Text, txtProfesion.Text, buffer, codusuario);
            }
            else {
                usuarios.Insert(codusuario, txtCargo.Text, txtProfesion.Text, buffer);
            }
            //cargarInfousuario();
            deshabilitarBotones();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (!eventosEncendidos) return;
            cargarInfousuario();
            deshabilitarBotones();
        }

        private void deshabilitarBotones()
        {
            txtCargo.ReadOnly = true;
            txtProfesion.ReadOnly = true;
            btnAceptarEdicion.Visible = false;
            btnCancelar.Visible = false;
            btnCambiarImagen.Visible = false;
            btnEditarInformacionAdicional.Visible = true;
        }

        private void habilitarBotones()
        {
            txtCargo.ReadOnly = false;
            txtProfesion.ReadOnly = false;
            btnAceptarEdicion.Visible = true;
            btnCancelar.Visible = true;
            btnCambiarImagen.Visible = true;
            btnEditarInformacionAdicional.Visible = false;
        }


    }
}
