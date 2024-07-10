using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.llamadasTecnicas
{
    public partial class frmListadoREsFinal : Form
    {
        public frmListadoREsFinal()
        {
            InitializeComponent();
        }

        private void btnAddIndicaciones_Click(object sender, EventArgs e)
        {
            frmREsultadoFinal fr = new frmREsultadoFinal();
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                resultado_final_llamadaTableAdapter1.Fill(dsSpx1.resultado_final_llamada);
            }
        }

        private void frmListadoREsFinal_Load(object sender, EventArgs e)
        {
            resultado_final_llamadaTableAdapter1.Fill(dsSpx1.resultado_final_llamada);
        }

        private void btnEditIndicaciones_Click(object sender, EventArgs e)
        {
            if (grdDAtos.Columns["cod_resultado_final_llamada"].Text.Trim() == string.Empty) return;
            frmREsultadoFinal fr = new frmREsultadoFinal();
            fr.codResultadoFinal = int.Parse(grdDAtos.Columns["cod_resultado_final_llamada"].Text);
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                resultado_final_llamadaTableAdapter1.Fill(dsSpx1.resultado_final_llamada);
            }
        }

        private void btnDelIndicaciones_Click(object sender, EventArgs e)
        {
            if (grdDAtos.Columns["cod_resultado_final_llamada"].Text.Trim() == string.Empty) return;
            
            if (MessageBox.Show("Esta seguro de eliminar este registro","Confirmacion",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    resultado_final_llamadaTableAdapter1.DeleteQuery(int.Parse(grdDAtos.Columns["cod_resultado_final_llamada"].Text));
                    resultado_final_llamadaTableAdapter1.Fill(dsSpx1.resultado_final_llamada);
                }catch(Exception ex){
                    MessageBox.Show("Error al eliminar el registro "+ex.Message);
                
                }
            }
        }
    }
}
