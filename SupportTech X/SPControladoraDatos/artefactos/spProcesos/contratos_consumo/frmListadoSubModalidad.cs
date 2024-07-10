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
    public partial class frmListadoSubModalidad : Form
    {
        public frmListadoSubModalidad()
        {
            InitializeComponent();
        }

        private void cargarInformacion() 
        {
            string sql = @"select 
sub_modalidad_contrato.cod_sub_modalidad_contrato,
modalidad_contrato.nombre_modalidad_contrato,
sub_modalidad_contrato.nombresub_modalidad_contrato,
sub_modalidad_contrato.activo

 from sub_modalidad_contrato
join modalidad_contrato on modalidad_contrato.cod_modalidad_contrato= sub_modalidad_contrato.cod_modalidad_contrato
order by 
modalidad_contrato.nombre_modalidad_contrato,
sub_modalidad_contrato.nombresub_modalidad_contrato";

            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            grdDatos.DataSource= bd.ejecutarConsulta(sql).Tables[0];
        }

        private void frmListadoSubModalidad_Load(object sender, EventArgs e)
        {
            cargarInformacion();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmSubModalidadContrato fr = new frmSubModalidadContrato();
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                cargarInformacion();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_sub_modalidad_contrato"].Text.Trim() == string.Empty)
            {
                return;
            }
            frmSubModalidadContrato fr = new frmSubModalidadContrato();
            fr.codSubModalidad = int.Parse(grdDatos.Columns["cod_sub_modalidad_contrato"].Text);
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                cargarInformacion();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_sub_modalidad_contrato"].Text.Trim() == string.Empty)
            {
                return;
            }
            if (MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.confirmacionDelete,SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.tituloConfirmacionDelete,MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try {
                    sub_modalidad_contratoTableAdapter1.DeleteQuery(int.Parse(grdDatos.Columns["cod_sub_modalidad_contrato"].Text));
                    cargarInformacion();
                }catch(Exception ex){

                    MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.errorDelete+" "+ex.Message);
                }
            }
        }
    }
}
