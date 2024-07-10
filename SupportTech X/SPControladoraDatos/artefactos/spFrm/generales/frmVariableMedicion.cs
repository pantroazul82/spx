using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.generales
{
    public partial class frmVariableMedicion : Form
    {
        public frmVariableMedicion()
        {
            InitializeComponent();
        }

        private void btnAddIndicaciones_Click(object sender, EventArgs e)
        {
            frmVariablesMedicionDetalle fr = new frmVariablesMedicionDetalle();
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                variables_medicionTableAdapter1.Fill(dsSpx1.variables_medicion);
            }
        }

        private void btnEditIndicaciones_Click(object sender, EventArgs e)
        {
            if (grdDAtos.Columns["cod_variables_medicion"].Text.Trim() == string.Empty)
                return;
            frmVariablesMedicionDetalle fr = new frmVariablesMedicionDetalle();
            fr.codVariable = int.Parse(grdDAtos.Columns["cod_variables_medicion"].Text);
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                variables_medicionTableAdapter1.Fill(dsSpx1.variables_medicion);
            }
        }

        private void btnDelIndicaciones_Click(object sender, EventArgs e)
        {
            if (grdDAtos.Columns["cod_variables_medicion"].Text.Trim() == string.Empty)
                return;
            if (MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.confirmacionDelete, SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.tituloConfirmacionDelete, MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes) return;
            try
            {
                variables_medicionTableAdapter1.DeleteQuery(int.Parse(grdDAtos.Columns["cod_variables_medicion"].Text));
                variables_medicionTableAdapter1.Fill(dsSpx1.variables_medicion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(

                    SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.errorDelete + "\n" + ex.Message);
            }


        }

        private void frmVariableMedicion_Load(object sender, EventArgs e)
        {
            variables_medicionTableAdapter1.Fill(dsSpx1.variables_medicion);
        }
    }
}
