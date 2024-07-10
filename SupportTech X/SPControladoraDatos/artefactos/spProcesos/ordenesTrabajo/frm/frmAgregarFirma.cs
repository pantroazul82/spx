using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.ordenesTrabajo.frm
{
    public partial class frmAgregarFirma : Form
    {
        public frmAgregarFirma()
        {
            InitializeComponent();
        }

        public System.Drawing.Bitmap firma;

        private void btnCAncelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Graphics objGrafico = picFirma.CreateGraphics();
       
            DialogResult = DialogResult.OK;
            Close();
        }

        bool dibujar = false;

        private void picFirma_MouseDown(object sender, MouseEventArgs e)
        {
            dibujar = true;
        }

        private void picFirma_MouseUp(object sender, MouseEventArgs e)
        {
            dibujar = false;
            puntoAnterior = new Point(0, 0);
        }

        private void picFirma_MouseMove(object sender, MouseEventArgs e)
        {
            if (dibujar)
            {
                Graphics objGrafico = Graphics.FromImage(firma);
                Pen objLapiz = new Pen(Color.Black, (float)nmFuente.Value);
                if (!(puntoAnterior.X == 0 && puntoAnterior.Y == 0))
                {
                    objGrafico.DrawLine(objLapiz, e.X, e.Y, puntoAnterior.X, puntoAnterior.Y);
                }
                puntoAnterior.X = e.X;
                puntoAnterior.Y = e.Y;
            }
            picFirma.Image = firma;
        }

        System.Drawing.Point puntoAnterior;

        private void frmAgregarFirma_Load(object sender, EventArgs e)
        {
            firma = new Bitmap(picFirma.Width, picFirma.Height);
            Graphics objGrafico = Graphics.FromImage(firma);
            Brush b = new SolidBrush(Color.White);
            objGrafico.FillRectangle(b, 0, 0, picFirma.Width, picFirma.Height);
        }

    }
}
