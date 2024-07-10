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
    public partial class frmSeleccionarPassword : Form
    {
        public frmSeleccionarPassword()
        {
            InitializeComponent();
        }

        public string password { set; get; }

        private void frmSeleccionarPassword_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

            if (password != null && password.Trim() != string.Empty)
            {
                txtPassActual.Visible = true;
                lblPassActual.Visible = true;
                txtPassActual.Focus();
            }else {
                txtPassActual.Visible = false;
                lblPassActual.Visible = false;
                txtPassword.Focus();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            calcularComplejidad();
        }

        private void calcularComplejidad()
        {
            int nivelSeguro = 0;
            #region nivel de acuerdo al tamano
            if (txtPassword.Text.Trim().Length > 20)
                nivelSeguro += 70;
            if (txtPassword.Text.Trim().Length > 15)
                nivelSeguro += 50;
            else if (txtPassword.Text.Trim().Length > 13)
                nivelSeguro += 35;
            else if (txtPassword.Text.Trim().Length > 10)
                nivelSeguro += 30;
            else if (txtPassword.Text.Trim().Length > 9)
                nivelSeguro += 25;
            else if (txtPassword.Text.Trim().Length > 8)
                nivelSeguro += 20;
            else if (txtPassword.Text.Trim().Length > 7)
                nivelSeguro += 15;
            #endregion

            #region nivel de acuerdo a la complejidad
            char[] arr = txtPassword.Text.ToCharArray();
            int digitos = 1;
            for (int k = 0; k < arr.Length; k++)
            {
                if (char.IsDigit(arr[k]))
                {
                    nivelSeguro += (40/digitos++);
                }else if (char.IsPunctuation(arr[k]))
                {
                    nivelSeguro += (40 / digitos++);
                }
                else if (char.IsSymbol(arr[k]))
                {
                    nivelSeguro += (40 / digitos++);
                }
                else if (!char.IsLetter(arr[k]))
                {
                    nivelSeguro += (40 / digitos++);
                }
                else 
                {
                    nivelSeguro += 1;
                }
            }
#endregion
            if (nivelSeguro > progressBarX1.Maximum)
                nivelSeguro = progressBarX1.Maximum;
            
            if(nivelSeguro<20)
            {
                progressBarX1.ColorTable = DevComponents.DotNetBar.eProgressBarItemColor.Error;
                
            }else if (nivelSeguro < 70)
            {
                progressBarX1.ColorTable = DevComponents.DotNetBar.eProgressBarItemColor.Paused;
            }else
            {
                progressBarX1.ColorTable = DevComponents.DotNetBar.eProgressBarItemColor.Normal;
            }
                progressBarX1.Value = nivelSeguro;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtPassActual.Visible && txtPassActual.Text != password)
            {
                Login l=new Login();
                if (txtPassActual.Text.Trim() == string.Empty && password != string.Empty
                    || !l.compararCadena(l.cifrarPassword(txtPassActual.Text), password)
                    )
                {
                    MessageBox.Show("El password actual no es valido!");
                    return;
                }
            }
            if (txtConfirmacion.Text != txtPassword.Text)
            {
                MessageBox.Show("El password y la confirmacion son diferentes!");
                return;
            }
            if (SPXSeguridad.frmLogin.PasswordFuerte) 
            {
                if(txtPassword.Text.Length <8)
                {
                    MessageBox.Show("El password es demasiado corto debe tener por lo menos 8 caracteres!");
                    return;
                }

                if (txtPassword.Text.IndexOfAny(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }) < 0)
                {
                    MessageBox.Show("El password debe contener letras y valores numericos!");
                    return;
                }

                if (txtPassword.Text.IndexOfAny(new char[] { '~', '!', '@', '#', '$', '%', '^', '&', '*', '(',')','-','+','=',',','.','<','>','?' }) < 0)
                {
                    MessageBox.Show("El password debe contener caracteres como '~', '!', '@', '#', '$', '%', '^', '&', '*', '(',')','-','+','=',',','.','<','>','?' para garantizar la seguridad.");
                    return;
                }
            }
            
            password = txtPassword.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

    }
}
