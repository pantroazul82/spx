using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SPControladoraDatos.artefactos.SPXQuery.frm.Reportes
{
    public partial class frmNuevoReporte : frm.plantillas.frmPrincipal
    {
        public frmNuevoReporte()
        {
            InitializeComponent();
        }

        private void btnSelecXml_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "xml|*.xml";
            if (d.ShowDialog() == DialogResult.OK)
            {
                txtXml.Text = System.IO.Path.GetFileName(d.FileName);
            }
        }

        public int codigoRpt = 0;

        private void frmNuevoReporte_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

            rpt_parametrosTableAdapter1.FillBycod_rpt(dsSPXQuery1.rpt_parametros, codigoRpt);
            if (codigoRpt == 0)
            {
                //es nuevo
                //btnAgregarReporte.Visible = false;
                //btnModificarReporte.Visible = false;
                //btnBorrarReporte.Visible = false;
            }
            else
            {
                //cargamos la info del reporte
                rptTableAdapter1.FillBycod_rpt(dsSPXQuery1.rpt, codigoRpt);
                rpt_parametrosTableAdapter1.FillBycod_rpt(dsSPXQuery1.rpt_parametros, codigoRpt);
                txtCodigo.Text = dsSPXQuery1.rpt[0].cod_rpt.ToString();
                txtCaption.Text = dsSPXQuery1.rpt[0].caption_rpt;
                txtNombre.Text = dsSPXQuery1.rpt[0].nombre_rpt;
                txtXml.Text = dsSPXQuery1.rpt[0].xml;
                chkFiltroObligatorio.Checked = dsSPXQuery1.rpt[0].filtra_linea;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (codigoRpt == 0)
            {
                int prueba = ((chkFiltroObligatorio.Checked) ? 1 : 0);
                //codigoRpt = int.Parse(txtCodigo.Text);
                rptTableAdapter1.Insert(txtNombre.Text, txtCaption.Text, txtXml.Text,
                    chkFiltroObligatorio.Checked);
                //btnAgregarReporte.Visible = true;
                //btnModificarReporte.Visible = true;
                //btnBorrarReporte.Visible = true;
                txtCodigo.Text = rptTableAdapter1.verIdentity().ToString();
            }
            else
            {
                rptTableAdapter1.UpdateQuery(txtNombre.Text, txtCaption.Text, txtXml.Text, 
                    chkFiltroObligatorio.Checked, codigoRpt);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAgregarReporte_Click(object sender, EventArgs e)
        {
            frmNuevoCampo fr = new frmNuevoCampo();
            fr.codigoReporte = codigoRpt;

            if (fr.ShowDialog() == DialogResult.OK)
                rpt_parametrosTableAdapter1.FillBycod_rpt(dsSPXQuery1.rpt_parametros, codigoRpt);
        }

        private void btnModificarReporte_Click(object sender, EventArgs e)
        {
            if (grdcampos.Columns["cod_rpt_parametro"].Text.Trim() == string.Empty) return;
            frmNuevoCampo fr = new frmNuevoCampo();
            fr.codigoReporte = codigoRpt;
            fr.codigoParametro = int.Parse(grdcampos.Columns["cod_rpt_parametro"].Text);
            if (fr.ShowDialog() == DialogResult.OK)
                rpt_parametrosTableAdapter1.FillBycod_rpt(dsSPXQuery1.rpt_parametros, codigoRpt);
        }

        private void btnBorrarReporte_Click(object sender, EventArgs e)
        {
            if (grdcampos.Columns["cod_rpt_parametro"].Text.Trim() == string.Empty) return;

            if (MessageBox.Show("Esta seguro de eliminar este filtro", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) 
                == DialogResult.Yes)
            {
                rpt_parametrosTableAdapter1.DeleteBycod_rpt_cod_rpt_parametro(codigoRpt, int.Parse(grdcampos.Columns["cod_rpt_parametro"].Text.Trim()));
                rpt_parametrosTableAdapter1.FillBycod_rpt(dsSPXQuery1.rpt_parametros, codigoRpt);
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            obj.exportar(grdcampos, "Libro1", true);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (codigoRpt == 0) return;
            rpt_parametrosTableAdapter1.FillBycod_rpt(dsSPXQuery1.rpt_parametros, codigoRpt);
        }
    }
}