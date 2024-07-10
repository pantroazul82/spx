using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace SPControladoraDatos.artefactos.SPXQuery.frm.Reportes
{
    public partial class frmNuevoCampo : frm.plantillas.frmPrincipal
    {
        public frmNuevoCampo()
        {
            InitializeComponent();
        }

        public int codigoReporte = 0;
        public int codigoParametro = 0;

        private void frmNuevoCampo_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

            tipofiltro_query_rptTableAdapter1.Fill(dsSPXQuery1.tipofiltro_query_rpt);

            if (codigoParametro == 0)
            {
                //txtCodigo.Text = filtrosRptTableAdapter1.verNextId(codigoReporte).Value.ToString();
            }
            else
            {
                rpt_parametrosTableAdapter1.FillBycod_rpt_cod_rpt_parametro(dsSPXQuery1.rpt_parametros, codigoReporte, codigoParametro);
                txtCodigo.Text = dsSPXQuery1.rpt_parametros[0].cod_rpt_parametro.ToString();
                txtNombre.Text = dsSPXQuery1.rpt_parametros[0].nombre;
                txtCaption.Text = dsSPXQuery1.rpt_parametros[0].campo;
                comboBox1.SelectedValue = dsSPXQuery1.rpt_parametros[0].cod_tipo_filtro;
            }
        }

        private void btnBorrarReporte_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null || comboBox1.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("El tipo de filtro es obligatorio", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtNombre.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El nombre es obligatorio", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtCaption.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El caption es obligatorio", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (codigoParametro== 0)
            {
                rpt_parametrosTableAdapter1.Insert(codigoReporte,
                    int.Parse(comboBox1.SelectedValue.ToString()), txtNombre.Text, txtCaption.Text);
            }

            else
            {
                rpt_parametrosTableAdapter1.UpdateParametroBycod_rpt_parametro(txtNombre.Text, txtCaption.Text,
                     int.Parse(comboBox1.SelectedValue.ToString()),
                     codigoParametro);
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}