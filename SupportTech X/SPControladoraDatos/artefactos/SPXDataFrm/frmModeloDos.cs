using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CgDataFrm
{
    public partial class frmModeloDos : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public static string nombreSoftware = "Nombre Software";
        public static string NombreSoftware { set { nombreSoftware = value; } get { return nombreSoftware; } }
        private string TituloTabla = "";
        public string tituloTabla { set { TituloTabla = value; this.Text = tituloTabla + " - " + nombreSoftware; } get { return TituloTabla; } }
        private int moduloSeguridad = 0;
        public int ModuloSeguridad { set { moduloSeguridad = value; } get { return moduloSeguridad; } }

        public frmModeloDos()
        {
            
            InitializeComponent();
            this.Text = this.Text + " - " + nombreSoftware.Trim();
        }

        private void frmModelo_Load(object sender, EventArgs e)
        { 
            cgDataControler1.ModuloSeguridad = moduloSeguridad;
            grdDatos.EvenRowStyle.BackColor = Color.GhostWhite;
            grdDatos.OddRowStyle.BackColor = Color.LightSteelBlue;
            if (cgDataControler1.dataTabla != null)
            txtTotalRegistros.Text = cgDataControler1.dataTabla.Rows.Count.ToString();
            cgDataControler1.EventosEncendidos = true;
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\CGMD" + TituloTabla + ".xs";
            if (System.IO.File.Exists(str))
            {
                grdDatos.LoadLayout(str);
            }
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.DefaultExt = "txt";
            dlg.FileName = "*.txt";
            dlg.Filter = "Archivo de texto|*.txt";
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            grdDatos.ExportToDelimitedFile(dlg.FileName, C1.Win.C1TrueDBGrid.RowSelectorEnum.AllRows);
            if (chkAbrirDespuesdeExportar.Checked)
                SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsArchivos.abrirArchivo(dlg.FileName);
        }

        private void btnHtml_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.DefaultExt = "html";
            dlg.FileName = "*.html";
            dlg.Filter = "Pagina HTML|*.html";
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            grdDatos.ExportToHTML(dlg.FileName);
            if (chkAbrirDespuesdeExportar.Checked)
                SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsArchivos.abrirArchivo(dlg.FileName);
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.DefaultExt = "pdf";
            dlg.FileName = "*.pdf";
            dlg.Filter = "Archivo Pdf|*.pdf";
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            grdDatos.ExportToPDF(dlg.FileName);
            if (chkAbrirDespuesdeExportar.Checked)
                SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsArchivos.abrirArchivo(dlg.FileName);
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            // choose file
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            obj.exportar(grdDatos, this.tituloTabla, chkAbrirDespuesdeExportar.Checked);
        }

        private void cgDataControler1_DespuesDeAccion(object sender, CGDataControler.dataControlerEventArgs e)
        {
            if (cgDataControler1.dataTabla != null)
            txtTotalRegistros.Text = cgDataControler1.dataTabla.Rows.Count.ToString();
        }

        public void cargarTotales() 
        {
            if (cgDataControler1.dataTabla != null)
            txtTotalRegistros.Text = cgDataControler1.dataTabla.Rows.Count.ToString();
        }

        private void frmModeloDos_Shown(object sender, EventArgs e)
        {
            cargarTotales();
        }

        private void frmModeloDos_Enter(object sender, EventArgs e)
        {
            cargarTotales();
        }

        private void btnGuardarGrilla_Click(object sender, EventArgs e)
        {
            //guardamos la configuracion de la grilla
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\CGMD" + TituloTabla + ".xs";

            grdDatos.SaveLayout(str);
            MessageBox.Show("Estructura guardada Satisfactoriamente!!");
        }

        private void btnReinicciargrilla_Click(object sender, EventArgs e)
        {
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\CGMD" + TituloTabla + ".xs";
            System.IO.File.Delete(str);
            MessageBox.Show("Los cambios se veran reflejados una ves cargue de nuevo la ventana");

        }
    }
}

