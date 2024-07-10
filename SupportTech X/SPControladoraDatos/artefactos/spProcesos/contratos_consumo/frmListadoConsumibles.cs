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
    public partial class frmListadoConsumibles : Form
    {
        public frmListadoConsumibles()
        {
            InitializeComponent();
        }

        private void frmListadoConsumibles_Load(object sender, EventArgs e)
        {
            pltConsumibleTableAdapter1.Fill(dsContratoConsumo1.pltConsumible);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmConsumibles fr = new frmConsumibles();
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pltConsumibleTableAdapter1.Fill(dsContratoConsumo1.pltConsumible);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_consumible"].Text.Trim() == string.Empty)
            {
                return;
            }
            frmConsumibles fr = new frmConsumibles();
            fr.codConsumibles = int.Parse(grdDatos.Columns["cod_consumible"].Text);
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pltConsumibleTableAdapter1.Fill(dsContratoConsumo1.pltConsumible);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_consumible"].Text.Trim() == string.Empty)
            {
                return;
            }
            if (MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.confirmacionDelete, SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.tituloConfirmacionDelete, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    consumiblesTableAdapter1.DeleteQuery(int.Parse(grdDatos.Columns["cod_consumible"].Text));
                    pltConsumibleTableAdapter1.Fill(dsContratoConsumo1.pltConsumible);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.errorDelete + " " + ex.Message);
                }
            }
        }

        private void btnCargueInformacion_Click(object sender, EventArgs e)
        {
            frmImportarGruposyConsumibles fr = new frmImportarGruposyConsumibles();
            fr.Show();
        }
    }
}
