using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.generales.newFormat
{
    public partial class frmListadoMotivoSalida : Form
    {
        public frmListadoMotivoSalida()
        {
            InitializeComponent();
        }

        private void btnAddIndicaciones_Click(object sender, EventArgs e)
        {
            frmMotivoSalida fr = new frmMotivoSalida();
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                motivo_salidaTableAdapter1.Fill(dsSpx1.motivo_salida);
            }
        }

        private void btnEditIndicaciones_Click(object sender, EventArgs e)
        {
            if (grdDAtos.Columns["cod_motivo_salida"].Text.Trim() == string.Empty)
                return;
            frmMotivoSalida fr = new frmMotivoSalida();
            fr.codMotivoSalida = int.Parse(grdDAtos.Columns["cod_motivo_salida"].Text);
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                motivo_salidaTableAdapter1.Fill(dsSpx1.motivo_salida);
            }
        }

        private void btnDelIndicaciones_Click(object sender, EventArgs e)
        {
            if (grdDAtos.Columns["cod_motivo_salida"].Text.Trim() == string.Empty)
                return;
            if (MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.confirmacionDelete,SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.tituloConfirmacionDelete,MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes) return;
                try{
                motivo_salidaTableAdapter1.DeleteQuery(int.Parse(grdDAtos.Columns["cod_motivo_salida"].Text));
                motivo_salidaTableAdapter1.Fill(dsSpx1.motivo_salida);
                }catch(Exception ex){
                    MessageBox.Show(

                        SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.errorDelete+"\n"+ex.Message);
                }
            

        }

        private void frmListadoMotivoSalida_Load(object sender, EventArgs e)
        {
            motivo_salidaTableAdapter1.Fill(dsSpx1.motivo_salida);
        }
    }
}
