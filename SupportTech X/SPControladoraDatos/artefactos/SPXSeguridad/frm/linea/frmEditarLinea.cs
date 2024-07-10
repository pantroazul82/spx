using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SPXSeguridad.linea
{
    public partial class frmEditarLinea : Form
    {
        public frmEditarLinea()
        {
            InitializeComponent();
        }

        public int codLinea { set; get; }

        public bool validar() 
        {
            if (txtNombreLinea.Text.Trim() == string.Empty) 
            {
                MessageBox.Show("Ïngrese el nonbre de la linea","");
                return false;
            }

            //MessageBox.Show();

            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!validar()) return;
            //alamcenamos el logo
            byte[] logo = null;
            if (picLogo.Image != null)
            {
                
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                
                picLogo.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                logo=ms.ToArray();
            }

            if (codLinea == 0) {
                lineaTableAdapter1.Insert(txtNombreLinea.Text, txtContactoLinea.Text, txtEmail.Text, txtTelefono.Text,
                    txtDireccion.Text, txtFax.Text,logo
                    );
            } else {
                lineaTableAdapter1.UpdateQuery(txtNombreLinea.Text, txtContactoLinea.Text, txtEmail.Text,
                    txtTelefono.Text, txtDireccion.Text, txtFax.Text, logo, codLinea);
            }
            
            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmEditarLinea_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

            if (codLinea != 0)
            {
                lineaTableAdapter1.FillBycod_linea(dsSPXSeguridad1.linea, codLinea);
                
                if (!dsSPXSeguridad1.linea[0].Iscontacto_lineaNull())
                txtContactoLinea.Text = dsSPXSeguridad1.linea[0].contacto_linea;
                
                if (!dsSPXSeguridad1.linea[0].Isdireccion_lineaNull())
                txtDireccion.Text = dsSPXSeguridad1.linea[0].direccion_linea;
                
                if (!dsSPXSeguridad1.linea[0].Isemail_lineaNull())
                txtEmail.Text = dsSPXSeguridad1.linea[0].email_linea;

                if (!dsSPXSeguridad1.linea[0].Isfax_lineaNull())
                txtFax.Text = dsSPXSeguridad1.linea[0].fax_linea;
                
                txtNombreLinea.Text = dsSPXSeguridad1.linea[0].nombre_linea;
                
                if (!dsSPXSeguridad1.linea[0].Istelefono_lineaNull())
                txtTelefono.Text = dsSPXSeguridad1.linea[0].telefono_linea;
                
                if (!dsSPXSeguridad1.linea[0].IslogoNull())
                { 
                    picLogo.Image= (Image.FromStream(new System.IO.MemoryStream(dsSPXSeguridad1.linea[0].logo)));
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnGuardarLogo_Click(object sender, EventArgs e)
        {
            if (picLogo.Image == null) return;
            saveFileDialog1.FileName = "imagen.png";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picLogo.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void btnAbrirLogo_Click(object sender, EventArgs e)
        {
            if (picLogo.Image == null) return;
            string a=System.IO.Path.GetTempFileName()+"im.png";
            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picLogo.Image.Save(a, System.Drawing.Imaging.ImageFormat.Png);
                SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsArchivos.abrirArchivo(a);
                System.Media.SystemSounds.Beep.Play();

            }
        }

        private void btnSubirLogo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picLogo.Image= Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
