using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SPControladoraDatos.artefactos.SPXUtilidades
{
    public partial class frmMensaje : Form
    {
        /// <summary>
        /// Es un formulario simple que permite recibir un texto o mostrar un texto el pantalla
        /// </summary>
        public frmMensaje()
        {
            InitializeComponent();
        }
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
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

            panel1.BackColor = SPControladoraDatos.artefactos.SPXUtilidades.Themes.ThemeManager.verColor();
        }
    }
}