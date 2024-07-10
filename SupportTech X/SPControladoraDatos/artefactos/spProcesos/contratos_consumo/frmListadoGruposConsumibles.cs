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
    public partial class frmListadoGruposConsumibles : Form
    {
        public frmListadoGruposConsumibles()
        {
            InitializeComponent();
        }

        private void frmListadoConsumibles_Load(object sender, EventArgs e)
        {
            dsContratoConsumo1.EnforceConstraints = false;
            pltGrupoConsumibleTableAdapter1.Fill(dsContratoConsumo1.pltGrupoConsumible);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmGruposConsumibles fr = new frmGruposConsumibles();
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pltGrupoConsumibleTableAdapter1.Fill(dsContratoConsumo1.pltGrupoConsumible);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_grupo_consumible"].Text.Trim() == string.Empty)
            {
                return;
            }
            frmGruposConsumibles fr = new frmGruposConsumibles();
            fr.CodGrupo = int.Parse(grdDatos.Columns["cod_grupo_consumible"].Text);
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pltGrupoConsumibleTableAdapter1.Fill(dsContratoConsumo1.pltGrupoConsumible);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_grupo_consumible"].Text.Trim() == string.Empty)
            {
                return;
            }
            if (MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.confirmacionDelete, SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.tituloConfirmacionDelete, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    
                    grupo_consumibleTableAdapter1.DeleteQuery(int.Parse(grdDatos.Columns["cod_grupo_consumible"].Text));
                    pltGrupoConsumibleTableAdapter1.Fill(dsContratoConsumo1.pltGrupoConsumible);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.errorDelete + " " + ex.Message);
                }
            }
        }
    }
}
