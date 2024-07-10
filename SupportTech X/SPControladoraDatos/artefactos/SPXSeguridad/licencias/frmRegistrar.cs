using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SPXSeguridad.licencias
{
    public partial class frmRegistrar : Form
    {
        public frmRegistrar()
        {
            InitializeComponent();
        }
        private bool verificarSerial = false;
        public bool VerificarSerial { set { verificarSerial = value; } get { return verificarSerial; } }

        private void frmRegistrar_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

            this.Text = this.Text + " " + Verificador.Aplicativo + " " + Verificador.VersionApp;
            Verificador obj = new Verificador();
            if (verificarSerial)
            {
                if (obj.verificarSerial())
                {
                    lblInfo.Text = "Software Registrado";
                    string[] cadenas=obj.generarSerial(obj.ghid()).Split('-');
                    txtSerial.Text = cadenas[0];
                    txtSerial2.Text = cadenas[1];
                    txtSerial3.Text = cadenas[2];
                    txtSerial4.Text = cadenas[3];
                    txtSerial5.Text = cadenas[4];
                    txtSerial6.Text = cadenas[5];
                    txtSerial7.Text = cadenas[6];
                    //--
                    txtSerial.ReadOnly=true;
                    txtSerial2.ReadOnly=true;
                    txtSerial3.ReadOnly=true;
                    txtSerial4.ReadOnly = true;
                    txtSerial5.ReadOnly = true;
                    txtSerial6.ReadOnly = true;
                    txtSerial7.ReadOnly = true;
                    
                }
            }
            txtHID.Text = obj.ghid();  
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtSerial.ReadOnly)
            {
                DialogResult = DialogResult.OK;
                Close();
                return;
            }
            string serial= txtSerial.Text+"-"+txtSerial2.Text+"-"+txtSerial3.Text+"-"+txtSerial4.Text+"-"+txtSerial5.Text.Trim()+"-"+txtSerial6.Text.Trim()+"-"+txtSerial7.Text;
            if (txtSerial.Text.Trim() == string.Empty )
            {
                MessageBox.Show("Ingrese un numero de serie valido.");
                return;
            }
            Verificador obj = new Verificador();
            try
            {
                if (obj.comprobarSerial(obj.ghid(), serial))
                {
                    obj.guardarSerial(serial);
                    MessageBox.Show("Felicitaciones se Registro Correctamente.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    txtSerial6.Text = "";
                    txtSerial5.Text = "";
                    txtSerial4.Text = "";
                    txtSerial3.Text = "";
                    txtSerial2.Text = "";
                    txtSerial.Text = "";
                    MessageBox.Show("Ingrese un numero de serie valido.");
                    txtSerial.Focus();
                }
            }catch(Exception ex)
            {
                     MessageBox.Show("Ingrese un numero de serie valido."+ex.Message);
            }
        }

        private void txtSerial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSerial.Text.Length == 6 && txtSerial.SelectedText.Trim() != txtSerial.Text.Trim())
            {
                e.Handled = true;
                txtSerial2.Text = e.KeyChar.ToString();
                FindForm().SelectNextControl(txtSerial, true, true, true, true);
                txtSerial2.SelectionStart = 1;
            }
        }

        private void txtSerial2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSerial2.Text.Length == 6 && txtSerial2.SelectedText.Trim() != txtSerial2.Text.Trim())
            {
                e.Handled = true;
                txtSerial3.Text = e.KeyChar.ToString();
                FindForm().SelectNextControl(txtSerial2, true, true, true, true);
                txtSerial3.SelectionStart = 1;
            }
        }

        private void txtSerial3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSerial3.Text.Length == 6 && txtSerial3.SelectedText.Trim() != txtSerial3.Text.Trim())
            {
                e.Handled = true;
                txtSerial4.Text = e.KeyChar.ToString();
                FindForm().SelectNextControl(txtSerial3 , true, true, true, true);
                txtSerial4.SelectionStart = 1;
            }
        }

        private void txtSerial4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSerial4.Text.Length == 6 && txtSerial4.SelectedText.Trim() != txtSerial4.Text.Trim())
            {
                e.Handled = true;
                txtSerial5.Text = e.KeyChar.ToString();
                FindForm().SelectNextControl(txtSerial4, true, true, true, true);
                txtSerial5.SelectionStart = 1;
            }
        }

        private void txtSerial5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSerial5.Text.Length == 6 && txtSerial5.SelectedText.Trim() != txtSerial5.Text.Trim())
            {
                e.Handled = true;
                txtSerial6.Text = e.KeyChar.ToString();
                FindForm().SelectNextControl(txtSerial5, true, true, true, true);
                txtSerial6.SelectionStart = 1;
            }
        }

        private void txtSerial6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSerial6.Text.Length == 6 && txtSerial6.SelectedText.Trim() != txtSerial6.Text.Trim())
            {
                e.Handled = true;
                txtSerial7.Text = e.KeyChar.ToString();
                FindForm().SelectNextControl(txtSerial6, true, true, true, true);
                txtSerial7.SelectionStart = 1;
            }
        }

        private void txtSerial7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSerial7.Text.Length == 6 && txtSerial7.SelectedText.Trim() != txtSerial7.Text.Trim())
            {
                e.Handled = true;
                FindForm().SelectNextControl(txtSerial7, true, true, true, true);
            }
        }

        private void txtSerial_TextChanged(object sender, EventArgs e)
        {
            if (txtSerial.Text.Trim().Length > 6)
            {
                string[] s =txtSerial.Text.Trim().Split('-');
                if (s.Length > 0)
                {
                    txtSerial.Text = s[0].Substring(0, 6);
                    txtSerial2.Focus();
                }
                if (s.Length > 1)
                {
                    txtSerial2.Text = s[1].Substring(0, 6);
                    txtSerial3.Focus();
                }
                if (s.Length > 2)
                {
                    txtSerial3.Text = s[2].Substring(0, 6);
                    txtSerial4.Focus();
                }
                if (s.Length > 3)
                {
                    txtSerial4.Text = s[3].Substring(0, 6);
                    txtSerial5.Focus();
                }
                if (s.Length > 4)
                {
                    txtSerial5.Text = s[4].Substring(0, 6);
                    txtSerial6.Focus();
                }
                if (s.Length > 5)
                {
                    txtSerial6.Text = s[5].Substring(0, 6);
                    txtSerial7.Focus();
                }
                if (s.Length > 6)
                {
                    txtSerial7.Text = s[6].Substring(0, 6);
                    btnAceptar.Focus();
                }

            }
        }

        private void txtSerial2_TextChanged(object sender, EventArgs e)
        {
            if (txtSerial2.Text.Trim().Length > 6)
            {
                string[] s = txtSerial2.Text.Trim().Split('-');
                if (s.Length > 1)
                {
                    txtSerial3.Text = s[1].Substring(0, 6);
                    txtSerial4.Focus();
                }
                if (s.Length > 2)
                {
                    txtSerial4.Text = s[2].Substring(0, 6);
                    txtSerial5.Focus();
                }
                if (s.Length > 3)
                {
                    txtSerial5.Text = s[3].Substring(0, 6);
                    txtSerial6.Focus();
                }
                if (s.Length > 4)
                {
                    txtSerial6.Text = s[4].Substring(0, 6);
                    txtSerial7.Focus();
                }
                if (s.Length > 5)
                {
                    txtSerial7.Text = s[5].Substring(0, 6);
                    btnAceptar.Focus();
                }

            }
        }

        private void txtSerial3_TextChanged(object sender, EventArgs e)
        {
            if (txtSerial3.Text.Trim().Length > 6)
            {
                string[] s = txtSerial3.Text.Trim().Split('-');
                if (s.Length > 1)
                {
                    txtSerial4.Text = s[1].Substring(0, 6);
                    txtSerial5.Focus();
                }
                if (s.Length > 2)
                {
                    txtSerial5.Text = s[2].Substring(0, 6);
                    txtSerial6.Focus();
                }
                if (s.Length > 3)
                {
                    txtSerial6.Text = s[3].Substring(0, 6);
                    txtSerial7.Focus();
                }
                if (s.Length > 4)
                {
                    txtSerial7.Text = s[4].Substring(0, 6);
                    btnAceptar.Focus();
                }
            }
        }

        private void txtSerial4_TextChanged(object sender, EventArgs e)
        {
            if (txtSerial4.Text.Trim().Length > 6)
            {
                string[] s = txtSerial4.Text.Trim().Split('-');

                if (s.Length > 1)
                {
                    txtSerial5.Text = s[1].Substring(0, 6);
                    txtSerial6.Focus();
                }
                if (s.Length > 2)
                {
                    txtSerial6.Text = s[2].Substring(0, 6);
                    txtSerial7.Focus();
                }
                if (s.Length > 3)
                {
                    txtSerial7.Text = s[3].Substring(0, 6);
                    btnAceptar.Focus();
                }
            }
        }

        private void txtSerial5_TextChanged(object sender, EventArgs e)
        {
            if (txtSerial5.Text.Trim().Length > 6)
            {
                string[] s = txtSerial5.Text.Trim().Split('-');

                if (s.Length > 1)
                {
                    txtSerial6.Text = s[1].Substring(0, 5);
                    txtSerial7.Focus();
                }
                if (s.Length > 2)
                {
                    txtSerial7.Text = s[2].Substring(0, 6);
                    btnAceptar.Focus();
                }
            }
        }


        private void txtSerial6_TextChanged(object sender, EventArgs e)
        {
            if (txtSerial6.Text.Trim().Length > 6)
            {
                string[] s = txtSerial6.Text.Trim().Split('-');

                if (s.Length > 1)
                {
                    txtSerial7.Text = s[1].Substring(0, 6);
                    btnAceptar.Focus();
                }
            }
        }

        private void txtSerial7_TextChanged(object sender, EventArgs e)
        {

        }


    }
}