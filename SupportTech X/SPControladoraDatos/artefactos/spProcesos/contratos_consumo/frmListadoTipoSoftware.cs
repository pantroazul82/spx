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
    public partial class frmListadoTipoSoftware : Form
    {
        public frmListadoTipoSoftware()
        {
            InitializeComponent();
        }

        private void frmListadoTipoSoftware_Load(object sender, EventArgs e)
        {
            tipo_software_contrato_consumoTableAdapter1.Fill(dsContratoConsumo1.tipo_software_contrato_consumo);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmTipoSoftware fr = new frmTipoSoftware();
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tipo_software_contrato_consumoTableAdapter1.Fill(dsContratoConsumo1.tipo_software_contrato_consumo);

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_tipo_software_contrato_consumo"].Text.Trim() == string.Empty)
            {
                return;
            }
            frmTipoSoftware fr = new frmTipoSoftware();
            fr.codTipoSoftware = int.Parse(grdDatos.Columns["cod_tipo_software_contrato_consumo"].Text);
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tipo_software_contrato_consumoTableAdapter1.Fill(dsContratoConsumo1.tipo_software_contrato_consumo);
     
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_tipo_software_contrato_consumo"].Text.Trim() == string.Empty)
            {
                return;
            }
            if (MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.confirmacionDelete, SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.tituloConfirmacionDelete, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    tipo_software_contrato_consumoTableAdapter1.DeleteQuery(int.Parse(grdDatos.Columns["cod_tipo_software_contrato_consumo"].Text));
                          tipo_software_contrato_consumoTableAdapter1.Fill(dsContratoConsumo1.tipo_software_contrato_consumo);
    
                }
                catch (Exception ex)
                {

                    MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.errorDelete + " " + ex.Message);
                }
            }
        }
    }
}
