using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
namespace SPControladoraDatos.artefactos.SPXUtilidades.Controles
{
    [ToolboxBitmap("pin.bmp")]
    /// <summary>
    /// Opciones generales de configuracion de columnas deun c1truedbgrid
    /// </summary>
    public partial class controladorColumnas : UserControl
    {
        public controladorColumnas()
        {
            InitializeComponent();
        }
        private bool mostrarExcel = true;
        private bool mostrarLimpiar = true;
        private bool mostrarContraer = true;
        private bool mostrarExpandir = true;


        public bool MostrarExcel { set { mostrarExcel = value; } get { return mostrarExcel; } }
        public bool MostrarLimpiar { set { mostrarLimpiar = value; } get { return mostrarLimpiar; } }
        public bool MostrarContraer { set { mostrarContraer = value; } get { return mostrarContraer; } }
        public bool MostrarExpandir { set { mostrarExpandir = value; } get { return mostrarExpandir; } }


        public C1.Win.C1TrueDBGrid.C1TrueDBGrid grilla { set; get; }
        [DefaultValue("Libro 1")]
        public string nombreLibro { set;get;}

        public string nameEspace = "";

        private void controladorColumnas_Load(object sender, EventArgs e)
        {
            cargarDiseno();
        }

        public void cargarDiseno()
        {
            if (DesignMode) return;
            if (grilla != null)
            {
                if(nameEspace == string.Empty)
                nameEspace = this.FindForm().GetType().ToString() + "-" + grilla.Name+"-"+this.Name;
                //miramos si existe el archivo de layout
                Assembly theAssembly = Assembly.GetEntryAssembly();
                string ruta=System.IO.Path.GetDirectoryName(theAssembly.Location)+@"\\layout\"+nameEspace+".xs";
                if ( System.IO.File.Exists(ruta) )
                {
                    grilla.LoadLayout(ruta);
                }
                habilitarVisibilidad();
            }
            if (!mostrarExcel) btnExportarExcel.Visible = false;
            if (!mostrarLimpiar) btnLimpiarGrilla.Visible = false;
            if (!mostrarContraer) buttonX2.Visible = false;
            if (!mostrarExpandir) buttonX1.Visible = false;
           
        }

        private void btnRestaurarConfiguracionColumnas_Click(object sender, EventArgs e)
        {
            Assembly theAssembly = Assembly.GetEntryAssembly();
            string ruta = System.IO.Path.GetDirectoryName(theAssembly.Location) + @"\layout\"+nameEspace+".xs";
            if (System.IO.File.Exists(ruta))
            {
                System.IO.File.Delete(ruta);
                MessageBox.Show("La configuracion de las columnas se restauro satisfactoriamente,\n" +
                    " cuando cargue la ventana la proxima vez podra ver reflejado los cambios",
                    "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                ruta = System.IO.Path.GetDirectoryName(theAssembly.Location) + @"\layout\";
                ruta = ruta + nameEspace + ".cmp";
                System.IO.File.Delete(ruta);
                habilitarVisibilidad();
            }else{
                System.Media.SystemSounds.Exclamation.Play();
            }
            
        }

        private void btnFijarColumnas_Click(object sender, EventArgs e)
        {
            Assembly theAssembly = Assembly.GetEntryAssembly();
            string ruta = System.IO.Path.GetDirectoryName(theAssembly.Location)+@"\layout\";
            if (!System.IO.Directory.Exists(ruta))
            {
                System.IO.Directory.CreateDirectory(ruta);
            }
            if (System.IO.Directory.Exists(ruta))
            {
                grilla.SaveLayout(ruta + nameEspace + ".xs");
                MessageBox.Show("La configuracion de las columnas se Guardo satisfactoriamente,\n"+
                    "Cuando cargue la ventana la proxima vez podra ver reflejado los cambios",
                    "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel ob= new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            ob.exportar(grilla, nombreLibro,false);
        }

        private void btnLimpiarGrilla_Click(object sender, EventArgs e)
        {
            Type tipo= grilla.DataSource.GetType();
            if (tipo.GetProperty("DataSource") != null)
            {
                tipo.GetProperty("DataSource").SetValue(grilla.DataSource, null, null);
            }else {
                if (tipo.GetMethod("Clear") != null)
                    tipo.GetMethod("Clear").Invoke(grilla.DataSource, null);
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
          
            for (int i = 0; i < grilla.Columns.Count; i++)
                grilla.Columns[i].GroupInfo.OutlineMode = C1.Win.C1TrueDBGrid.OutlineModeEnum.StartExpanded;
            bool continuar = true;
            if (grilla.GroupedColumns.Count <= 0)
            {
                MessageBox.Show("Esta Opcion es solamente Aplicable Cuando tiene Agrupada por lo menos una Columna.","Informacion",
                   MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                return;
            }
            
            for (int k = 0; continuar; k++)
            {
                try{
                grilla.ExpandGroupRow(k,true);
                Application.DoEvents();
                }
                catch (Exception) {
                    continuar = false;
                    break; }
            }
            System.Media.SystemSounds.Exclamation.Play();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grilla.Columns.Count; i++)
                grilla.Columns[i].GroupInfo.OutlineMode = C1.Win.C1TrueDBGrid.OutlineModeEnum.StartCollapsed;

            if (grilla.GroupedColumns.Count <= 0)
            {
                MessageBox.Show("Esta Opcion es solamente Aplicable Cuando tiene Agrupada por lo menos una Columna.", "Informacion",
                   MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            for (int k = 0; k < grilla.RowCount; k++)
            {
                try
                {
                    grilla.CollapseGroupRow(k);
                    Application.DoEvents();
                }catch(Exception){}
            }
            System.Media.SystemSounds.Exclamation.Play();
        }

        private void habilitarVisibilidad()
        {
            try
            {
                Assembly theAssembly = Assembly.GetEntryAssembly();
                string ruta = System.IO.Path.GetDirectoryName(theAssembly.Location) + @"\layout\";
                if (!System.IO.Directory.Exists(ruta))
                {
                    System.IO.Directory.CreateDirectory(ruta);
                }

                //
                string nm = ruta + nameEspace + ".cmp";
                if (!System.IO.File.Exists(nm)) return;

                List<string> listaArchivo = new List<string>();
                List<string> listaArchivoCompleto = new List<string>();

                System.IO.TextReader tr = System.IO.File.OpenText(nm);
                string tmp;
                while ((tmp = tr.ReadLine()) != null)
                {

                    listaArchivo.Add(tmp.Split(';')[0]);
                    listaArchivoCompleto.Add(tmp);
                }
                tr.Close();


                for (int k = 0; k < listaArchivo.Count; k++)
                {
                    string[] arr = listaArchivoCompleto[k].Split(';');
                    if (grilla.Splits[0].DisplayColumns[arr[0]] != null)
                    {
                        grilla.Splits[0].DisplayColumns[arr[0]].Visible = (arr[1] == "1");
                    }
                }
            }catch(Exception){}
        }


        private void btnCampos_Click(object sender, EventArgs e)
        {
            Assembly theAssembly = Assembly.GetEntryAssembly();
            string ruta = System.IO.Path.GetDirectoryName(theAssembly.Location) + @"\layout\";
            if (!System.IO.Directory.Exists(ruta))
            {
                System.IO.Directory.CreateDirectory(ruta);
            }
            //
            frmCamposGrilla fr = new frmCamposGrilla();
            fr.grilla = grilla;
            fr.nameEspace = ruta + nameEspace + ".cmp";
            if (fr.ShowDialog() == DialogResult.OK)
            {
                habilitarVisibilidad();
                 //MessageBox.Show("La configuracion de las columnas se Guardo satisfactoriamente,\n" +
                 //   "Cuando cargue la ventana la proxima vez podra ver reflejado los cambios",
                 //   "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
