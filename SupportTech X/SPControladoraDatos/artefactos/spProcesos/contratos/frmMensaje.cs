using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.contratos
{
    public partial class frmMensaje : Form
    {
        public frmMensaje()
        {
            InitializeComponent();
        }

        public string codOtroSi = "";
        public bool modificando = false;

        /// <summary>
        /// texto que esta en el cuadro de texto que escribe el usuario
        /// </summary>
        public string mensaje { set { txtMensaje.Text = value.Trim(); } get { return txtMensaje.Text.Trim(); } }
        /// <summary>
        /// Texto que se muestra en el titulo de la ventana
        /// </summary>
        public string titulo { set {this.Text= value; } get { return this.Text; } }
        /// <summary>
        /// Texto que se muestra en la etiqueta encima del cuadro de texto
        /// </summary>
        public string pregunta { set { lblTitulo.Text = value; } get { return lblTitulo.Text; } }
        

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int tmp = 0;
            int.TryParse(cmbOtroSiNum.Text, out tmp);
            if (tmp != 0 && cmbOtroSiNum.Visible)
            {
                codOtroSi = tmp.ToString();
            }
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void frmMensaje_Load(object sender, EventArgs e)
        {
            //por defecto el envia el maximo cod otro si existente
            int a = 0;
            int.TryParse(codOtroSi, out a);
            if (a > 0)
            { 
                for(int k=0;k<=a;k++)
                {
                    cmbOtroSiNum.Items.Add(k);        
                }
                cmbOtroSiNum.Text = a.ToString();
                if (modificando)
                    cmbOtroSiNum.Visible = false;
            }
            else {
                cmbOtroSiNum.Visible = false;
                label1.Visible = false;
            }
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}