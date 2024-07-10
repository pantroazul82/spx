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
    public partial class frmSubVariableMedicion : Form
    {
        public frmSubVariableMedicion()
        {
            InitializeComponent();
        }

        private void frmSubVariableMedicion_Load(object sender, EventArgs e)
        {
            pltSubVariableTableAdapter1.Fill(dsSpx1.pltSubVariable);
        }

        private void btnAddIndicaciones_Click(object sender, EventArgs e)
        {
            frmSubVariableMedicionDetalle fr = new frmSubVariableMedicionDetalle();
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pltSubVariableTableAdapter1.Fill(dsSpx1.pltSubVariable);
            }
        }

        private void btnEditIndicaciones_Click(object sender, EventArgs e)
        {
            if (grdDAtos.Columns["cod_sub_variables_medicion"].Text.Trim() == string.Empty)
                return;
            frmSubVariableMedicionDetalle fr = new frmSubVariableMedicionDetalle();
            fr.codSubvariablemedicion = int.Parse(grdDAtos.Columns["cod_sub_variables_medicion"].Text);
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pltSubVariableTableAdapter1.Fill(dsSpx1.pltSubVariable);
            }
        }

        private void btnDelIndicaciones_Click(object sender, EventArgs e)
        {
            if (grdDAtos.Columns["cod_sub_variables_medicion"].Text.Trim() == string.Empty)
                return;
            if (MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.confirmacionDelete, SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.tituloConfirmacionDelete, MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes) return;
            try
            {
                sub_variable_medicionTableAdapter1.DeleteQuery(int.Parse(grdDAtos.Columns["cod_sub_variables_medicion"].Text));
                pltSubVariableTableAdapter1.Fill(dsSpx1.pltSubVariable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(

                    SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.errorDelete + "\n" + ex.Message);
            }

        }
    }
}
