using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SPControladoraDatos.artefactos.SPXUtilidades.Controles
{
    public partial class frmCamposGrilla : Form
    {
        public frmCamposGrilla()
        {
            InitializeComponent();
        }

        public string nameEspace { get; set; }

        public C1.Win.C1TrueDBGrid.C1TrueDBGrid grilla 
        {
            set;get;
        }

        private void frmCamposGrilla_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

            cargarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            guardarCampos();
            DialogResult = DialogResult.OK;
        }

        private void guardarCampos() 
        {
            System.IO.File.Delete(nameEspace);

            System.IO.TextWriter tw = System.IO.File.CreateText(nameEspace);

            for (int k = 0; k < lstCampos.Items.Count; k++)
            {
                tw.WriteLine(lstCampos.Items[k].ToString()+";"+(lstCampos.CheckedItems.Contains(lstCampos.Items[k])?"1":"0")  );
            }


            tw.Close();
        
        }
        private void cargarCampos() 
        {
            List<string> listaArchivo = new List<string>();
            List<string> listaArchivoCompleto = new List<string>();
            if (System.IO.File.Exists(nameEspace))
            {
                System.IO.TextReader tr= System.IO.File.OpenText(nameEspace);
                string tmp;
                while((tmp=tr.ReadLine()) != null)
                {
                    
                    listaArchivo.Add(tmp.Split(';')[0]);
                    listaArchivoCompleto.Add(tmp);
                }
             tr.Close();
                //ordenamos la lista
            }else{
                System.IO.File.CreateText(nameEspace).Close();
            }
            //cargamos el lstGrilla los nombres que tiene la grilla
            List<string> lstGrilla = new List<string>();
            for (int k = 0; k < grilla.Columns.Count; k++)
            {
                lstGrilla.Add(grilla.Columns[k].Caption);
                //si esate en el archivo lo chuleamos o no
            }
            lstGrilla.Sort();

            for (int k = 0; k < lstGrilla.Count; k++)
            {
                if (listaArchivo.Contains(lstGrilla[k]))
                {
                    string[] arr = listaArchivoCompleto[ listaArchivo.IndexOf( lstGrilla[k])].Split(';');
                    lstCampos.Items.Add(arr[0],  (arr[1] == "1") );
                }else{
                    if (validarColumna(lstGrilla[k]))
                    {
                        lstCampos.Items.Add(lstGrilla[k],
                            ((grilla.Splits[0].DisplayColumns[lstGrilla[k]] == null) ? false : grilla.Splits[0].DisplayColumns[lstGrilla[k]].Visible)
                             );
                    }
                }
                //si esate en el archivo lo chuleamos o no
            }
        }

        private bool validarColumna(string nombre) 
        {
            for(int k=0;k<grilla.Splits[0].DisplayColumns.Count;k++){
                if (grilla.Splits[0].DisplayColumns[k].Name == nombre)
                    return true;
            }
            return false;
        }

        private void btnSeleccionarTodos_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < lstCampos.Items.Count; k++)
                lstCampos.SetItemChecked(k, true);
        }
    }
}
