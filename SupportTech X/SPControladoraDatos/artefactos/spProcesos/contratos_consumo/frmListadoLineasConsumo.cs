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
    public partial class frmListadoLineasConsumo : Form
    {
        public frmListadoLineasConsumo()
        {
            InitializeComponent();
        }

        private void frmListadoLineasConsumo_Load(object sender, EventArgs e)
        {
            cargarInformacion();
        }

        private void cargarInformacion()
        {
            linea_consumoTableAdapter1.Fill(dsContratoConsumo1.linea_consumo);
        }

     
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_linea_consumo"].Text.Trim() == string.Empty)
            {
                return;
            }
            frmLineasConsumo fr = new frmLineasConsumo();
            fr.codLineaConsumo = int.Parse(grdDatos.Columns["cod_linea_consumo"].Text);
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                cargarInformacion();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_linea_consumo"].Text.Trim() == string.Empty)
            {
                return;
            }
            if (MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.confirmacionDelete,SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.tituloConfirmacionDelete,MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try {
                    linea_consumoTableAdapter1.DeleteQuery(int.Parse(grdDatos.Columns["cod_linea_consumo"].Text));
                    cargarInformacion();
                }catch(Exception ex){

                    MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.errorDelete+" "+ex.Message);
                }
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            frmLineasConsumo fr = new frmLineasConsumo();
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                cargarInformacion();
            }
        }

    }
}

