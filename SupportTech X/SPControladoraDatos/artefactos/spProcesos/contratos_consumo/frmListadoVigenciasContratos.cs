using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.contratos_consumo
{
    public partial class frmListadoVigenciasContratos : Form
    {
        public frmListadoVigenciasContratos()
        {
            InitializeComponent();
        }

        private void frmListadoVigenciasContratos_Load(object sender, EventArgs e)
        {
            vigencias_contrato_consumoTableAdapter1.Fill(dsContratoConsumo1.vigencias_contrato_consumo);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmVigenciasContratosConsumo fr = new frmVigenciasContratosConsumo();
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                vigencias_contrato_consumoTableAdapter1.Fill(dsContratoConsumo1.vigencias_contrato_consumo);
       
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_vigencias_contrato_consumo"].Text.Trim() == string.Empty)
            {
                return;
            }
            frmVigenciasContratosConsumo fr = new frmVigenciasContratosConsumo();
            fr.codVigencia = int.Parse(grdDatos.Columns["cod_vigencias_contrato_consumo"].Text);
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                vigencias_contrato_consumoTableAdapter1.Fill(dsContratoConsumo1.vigencias_contrato_consumo);

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_vigencias_contrato_consumo"].Text.Trim() == string.Empty)
            {
                return;
            }
            if (MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.confirmacionDelete, SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.tituloConfirmacionDelete, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    vigencias_contrato_consumoTableAdapter1.DeleteQuery(int.Parse(grdDatos.Columns["cod_vigencias_contrato_consumo"].Text));
                    vigencias_contrato_consumoTableAdapter1.Fill(dsContratoConsumo1.vigencias_contrato_consumo);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.errorDelete + " " + ex.Message);
                }
            }
        }
    }
}
