using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SPControladoraDatos.artefactos;

namespace SPControladoraDatos.artefactos.SPXQuery.frm.Query
{
    public partial class frmColumnasPivote : Form
    {
        public frmColumnasPivote()
        {
            InitializeComponent();
        }

        public int codColumnaPivote { set; get; }
        public int codQuery { set; get; }
        data.cgq_tablas_pivote cgq_tablas_pivote1 = new data.cgq_tablas_pivote();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCaption.Text.Trim() == string.Empty) 
            {
                MessageBox.Show("El Caption o Etiqueta es Obligatorio!!!");
                return;
            }
            if (txtColumna.Text.Trim() == string.Empty)
            {
                MessageBox.Show("La Columnas es Obligatoria!!!");
                return;
            }

            if (codColumnaPivote == 0)
            {
                cgq_tablas_pivote1.Insert(txtColumna.Text, txtCaption.Text, codQuery,rdColumna.Checked,rdFila.Checked);
            }else {
                cgq_tablas_pivote1.UpdateQuery(txtColumna.Text, txtCaption.Text, rdColumna.Checked, rdFila.Checked, codColumnaPivote);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmColumnasPivote_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

            if (codColumnaPivote != 0)
            {
                cgq_tablas_pivote1.FillBycod_cgq_tablas_pivote(dsSPXQuery1.cgq_tablas_pivote, codColumnaPivote);
                txtColumna.Text = dsSPXQuery1.cgq_tablas_pivote[0].campo;
                txtCaption.Text = dsSPXQuery1.cgq_tablas_pivote[0].caption;
                if (!dsSPXQuery1.cgq_tablas_pivote[0].Ises_filaNull())
                rdFila.Checked = dsSPXQuery1.cgq_tablas_pivote[0].es_fila;

                if (!dsSPXQuery1.cgq_tablas_pivote[0].Ises_columnaNull())
                rdColumna.Checked = dsSPXQuery1.cgq_tablas_pivote[0].es_columna;
            }

        }
    }
}
