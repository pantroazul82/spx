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
    public partial class frmLinea : Form
    {
        public frmLinea()
        {
            InitializeComponent();
            controladorColumnas1.grilla = grdDatos;
        }

        private void frmLinea_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

            cargarLinea();
        }
        
        bool eventosEncendidos=true;

        private void cargarLinea()
        {
            eventosEncendidos = false;
            lineaTableAdapter1.FillSinLogo(dsSPXSeguridad1.linea);
            eventosEncendidos = true;
            cargarLogo();
        }

        private void cargarLogo()
        {
            if (!eventosEncendidos) return;
            if (grdDatos.Columns["cod_linea"].Text.Trim() == string.Empty) { picLogo = null; return; }
            picLogo.Image = lineaTableAdapter1.verLogo(int.Parse(grdDatos.Columns["cod_linea"].Text)); 
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmEditarLinea fr = new frmEditarLinea();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                cargarLinea();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_linea"].Text.ToString().Trim() == string.Empty) return;

            frmEditarLinea fr = new frmEditarLinea();
            fr.codLinea = int.Parse(grdDatos.Columns["cod_linea"].Text.ToString());
            if (fr.ShowDialog() == DialogResult.OK)
            {
                cargarLinea();
            }
        }

        private void btnEliminarLinea_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_linea"].Text.ToString().Trim() == string.Empty) return;

            if (MessageBox.Show("Esta seguro de eliminar la linea","Confirmacion",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    lineaTableAdapter1.DeleteQuery(int.Parse(grdDatos.Columns["cod_linea"].Text));
                    cargarLinea();
                    
                }catch(Exception)
                {
                    MessageBox.Show("No se puede eliminar la linea\nAsegurese que la linea que intenta borrar no tenga ningun otro registro asociado!");
                }
            }
            
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
            string a = System.IO.Path.GetTempFileName() + "im.png";
            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picLogo.Image.Save(a, System.Drawing.Imaging.ImageFormat.Png);
                SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsArchivos.abrirArchivo(a);
                System.Media.SystemSounds.Beep.Play();

            }
        }

        private void grdDatos_RowColChange(object sender, C1.Win.C1TrueDBGrid.RowColChangeEventArgs e)
        {
            cargarLogo();
        }
    }
}
