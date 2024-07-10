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
    public partial class frmListadoModalidadContrato : Form
    {
        public frmListadoModalidadContrato()
        {
            InitializeComponent();
        }


        private void frmListadoModalidadContrato_Load(object sender, EventArgs e)
        {
            cargarInformacion();
        }

        private void cargarInformacion()
        {
            modalidad_contratoTableAdapter1.Fill(dsContratoConsumo1.modalidad_contrato);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmModalidadContrato fr = new frmModalidadContrato();
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                cargarInformacion();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_modalidad_contrato"].Text.Trim() == string.Empty)
            {
                return;
            }
            frmModalidadContrato fr = new frmModalidadContrato();
            fr.codModalidad = int.Parse(grdDatos.Columns["cod_modalidad_contrato"].Text);
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                cargarInformacion();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_modalidad_contrato"].Text.Trim() == string.Empty)
            {
                return;
            }
            if (MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.confirmacionDelete,SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.tituloConfirmacionDelete,MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try {
                    modalidad_contratoTableAdapter1.DeleteQuery(int.Parse(grdDatos.Columns["cod_modalidad_contrato"].Text));
                    cargarInformacion();
                }catch(Exception ex){

                    MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.errorDelete+" "+ex.Message);
                }
            }
        }

    }
}
