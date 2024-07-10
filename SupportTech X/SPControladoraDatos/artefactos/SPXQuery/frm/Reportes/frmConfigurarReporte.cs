using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using SPControladoraDatos.artefactos;

namespace SPControladoraDatos.artefactos.SPXQuery.frm.Reportes 
{
    public partial class frmConfigurarReporte : frm.plantillas.frmListado
    {
        public frmConfigurarReporte()
        {
            cod_modulo = 63;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

            try
            {
                rptTableAdapter2.Fill(dsSPXQuery1.rpt);
            }
            catch (Exception)
            {
                if (MessageBox.Show("La base de datos seleccionada no tiene configuradas las tablas de reportes.\n desea Intentar crearlas.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    configrpt obj = new configrpt();
                    try
                    {
                       DataConector obj2 = new DataConector();
                        obj2.ejecutarComando(obj.verScriptCreacion());
                        MessageBox.Show("Se crearon las tablas Satisfactoriamente");
                        rptTableAdapter2.Fill(dsSPXQuery1.rpt);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se pudo crear las tablas");
                    }
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarReporte_Click(object sender, EventArgs e)
        {
            if (!permiteAgregar) return;
            frmNuevoReporte fr = new frmNuevoReporte();
            if (fr.ShowDialog() == DialogResult.OK)
                rptTableAdapter2.Fill(dsSPXQuery1.rpt);
        }

        private void btnModificarReporte_Click(object sender, EventArgs e)
        {
            if (!permiteModificar) return;
            if (grdDatos.Columns["cod_rpt"].Text.Trim() == string.Empty) return;
            frmNuevoReporte fr = new frmNuevoReporte();
            fr.codigoRpt = int.Parse(grdDatos.Columns["cod_rpt"].Text);

            if (fr.ShowDialog() == DialogResult.OK)
                rptTableAdapter2.Fill(dsSPXQuery1.rpt);
        }

        private void btnBorrarReporte_Click(object sender, EventArgs e)
        {
            if (!permiteEliminar) return;
            if (grdDatos.Columns["idRpt"].Text.Trim() == string.Empty) return;
            if (MessageBox.Show("Esta seguro de Eliminar el reporte???", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                rpt_parametrosTableAdapter1.DeleteBycod_rpt(int.Parse(grdDatos.Columns["cod_rpt"].Text));
                rptTableAdapter2.DeleteQuery(int.Parse(grdDatos.Columns["cod_rpt"].Text));
                rptTableAdapter2.Fill(dsSPXQuery1.rpt);
            }
        }

        private void btnGenerarScript_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "SQL|*.sql";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                System.IO.TextWriter tw = System.IO.File.CreateText(sv.FileName);
                configrpt obj = new configrpt();
                tw.Write(obj.verScriptDatos());
                tw.Close();
                System.Media.SystemSounds.Exclamation.Play();
            }
        }

        private void btnGenerarScriptTablas_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "SQL|*.sql";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                System.IO.TextWriter tw = System.IO.File.CreateText(sv.FileName);
                configrpt obj = new configrpt();
                tw.Write(obj.verScriptCreacion());
                tw.Close();
                System.Media.SystemSounds.Exclamation.Play();
            }
        }

        private void btnEditarReportexUsuario_Click(object sender, EventArgs e)
        {
            if (dsSPXQuery1.rpt.Rows.Count <= 0) return;
            frmReportesxUsuario fr = new frmReportesxUsuario();
            fr.Show();
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            obj.exportar(grdDatos, "Libro1", true);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            rptTableAdapter2.Fill(dsSPXQuery1.rpt);
        }
    }
}
