using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.problemas_frecuentes
{
    public partial class frmParametrizacionProblemas : Form
    {
       public string codFabricante = "";
       public string codModelo = "";

        public frmParametrizacionProblemas()
        {
            InitializeComponent();
            controladorColumnasProblemas.grilla = grdProblemas;
            controladorColumnasSoluciones.grilla = grdSoluciones;
        }

        private void cmbFabricante_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarModelo();
        }
        
        private void cargarModelo(){
            if (cmbFabricante.SelectedValue == null || cmbFabricante.SelectedValue.ToString().Trim() == string.Empty)
            {
                dsSpx1.Modelos.Clear();
                return;
            }
            modelosTableAdapter1.FillByCodFabricanteComboBox(dsSpx1.Modelos, cmbFabricante.SelectedValue.ToString());
            cmbModelo.SelectedValue = "-1";
            

        }

       

        private void frmParametrizacionProblemas_Load(object sender, EventArgs e)
        {
            fabricanteTableAdapter1.FillByComboBox(dsSpx1.fabricante);
            if (codFabricante == string.Empty)
            {
                cmbFabricante.SelectedValue = "-1";
            }else {
                cmbFabricante.SelectedValue = codFabricante;
                cargarModelo();
                cmbModelo.SelectedValue = codModelo;
                cmbFabricante.Enabled = false;
                cmbModelo.Enabled = false;
                problemas_frecuentesTableAdapter1.FillByFabricanteModelo(dsSpx1.problemas_frecuentes, cmbFabricante.SelectedValue.ToString(),
                cmbModelo.SelectedValue.ToString());
                cargarSoluciones();
                if (!SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1117))
                {
                    btnAgregar.Enabled = false;
                    btnAgregarSolucion.Enabled = false;
                    btnEditarProblema.Enabled = false;
                    btnEditarSolucion.Enabled = false;
                    btnEliminarProblema.Enabled = false;
                    btnEliminarSolucion.Enabled = false;
                }
            }
        }

        private void grdProblemas_RowColChange(object sender, C1.Win.C1TrueDBGrid.RowColChangeEventArgs e)
        {
            cargarSoluciones();
        }

        private void cargarSoluciones() 
        {
            if (grdProblemas.Columns["cod_problema_frecuente"].Text.Trim() == string.Empty)
            {
                dsSpx1.soluciones_problemas.Clear();
                return;
            }

            soluciones_problemasTableAdapter1.FillBycod_problema_frecuente(dsSpx1.soluciones_problemas,
                int.Parse(grdProblemas.Columns["cod_problema_frecuente"].Text));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(cmbModelo.SelectedValue == null || cmbModelo.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Seleccione un Modelo");
                return;
            }
            frmProblemaFrecuente fr = new frmProblemaFrecuente();
            fr.codFaricante = cmbFabricante.SelectedValue.ToString();
            fr.codModelo = cmbModelo.SelectedValue.ToString();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                problemas_frecuentesTableAdapter1.FillByFabricanteModelo(dsSpx1.problemas_frecuentes, cmbFabricante.SelectedValue.ToString(),
        cmbModelo.SelectedValue.ToString());
            }

        }

        private void btnEditarProblema_Click(object sender, EventArgs e)
        {
            if (grdProblemas.Columns["cod_problema_frecuente"].Text.Trim() == string.Empty)
            {
                return;
            }
            frmProblemaFrecuente fr = new frmProblemaFrecuente();
            fr.codProblema = int.Parse(grdProblemas.Columns["cod_problema_frecuente"].Text);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                problemas_frecuentesTableAdapter1.FillByFabricanteModelo(dsSpx1.problemas_frecuentes, cmbFabricante.SelectedValue.ToString(),
      cmbModelo.SelectedValue.ToString());
            }
        }

        private void btnEliminarProblema_Click(object sender, EventArgs e)
        {
            if (grdProblemas.Columns["cod_problema_frecuente"].Text.Trim() == string.Empty)
            {
                return;
            }
          
            if (MessageBox.Show("Esta seguro de eliminar el registro?","Pregunta",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {  
                soluciones_problemasTableAdapter1.DeleteBycod_problema_frecuente(
                    int.Parse(grdProblemas.Columns["cod_problema_frecuente"].Text));

                problemas_frecuentesTableAdapter1.DeleteQuery(
                    int.Parse(grdProblemas.Columns["cod_problema_frecuente"].Text));
                problemas_frecuentesTableAdapter1.FillByFabricanteModelo(dsSpx1.problemas_frecuentes, cmbFabricante.SelectedValue.ToString(),
      cmbModelo.SelectedValue.ToString());
            }
        }

        private void btnAgregarSolucion_Click(object sender, EventArgs e)
        {
            if (grdProblemas.Columns["cod_problema_frecuente"].Text.Trim() == string.Empty)
            {
                return;
            }
            frmRespuestas fr = new frmRespuestas();
            fr.codProblema = int.Parse(grdProblemas.Columns["cod_problema_frecuente"].Text);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                cargarSoluciones();
            }
        }

        private void btnEditarSolucion_Click(object sender, EventArgs e)
        {
            if (grdSoluciones.Columns["cod_soluciones_problemas"].Text.Trim() == string.Empty)
            {
                return;
            }
            frmRespuestas fr = new frmRespuestas();
            fr.codRespuesta = int.Parse(grdSoluciones.Columns["cod_soluciones_problemas"].Text);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                cargarSoluciones();
            }
        }

        private void btnEliminarSolucion_Click(object sender, EventArgs e)
        {
            if (grdSoluciones.Columns["cod_soluciones_problemas"].Text.Trim() == string.Empty)
            {
                return;
            }

            if (MessageBox.Show("Esta seguro de eliminar el registro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                soluciones_problemasTableAdapter1.DeleteQuery(
                    int.Parse(grdSoluciones.Columns["cod_soluciones_problemas"].Text));
                cargarSoluciones();
            }
        }

        private void cmbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModelo.SelectedValue == null || cmbModelo.SelectedValue.ToString().Trim() == string.Empty)
            {
                dsSpx1.problemas_frecuentes.Clear();
            }else{
                problemas_frecuentesTableAdapter1.FillByFabricanteModelo(dsSpx1.problemas_frecuentes, cmbFabricante.SelectedValue.ToString(),
                    cmbModelo.SelectedValue.ToString());
            }
            Application.DoEvents();
            cargarSoluciones();
        }

        private void btnBuscarEspecial_Click(object sender, EventArgs e)
        {
            cargarEspecial();
            cargarSoluciones();
        }

        private void cargarEspecial()
        {
            string sql = @"SELECT        cod_problema_frecuente, codFabricante, codModelo, cod_manual, nombre_problema, descripcion
FROM            problemas_frecuentes
WHERE        
(codFabricante ='" + cmbFabricante.SelectedValue.ToString() + "') AND (codModelo ='" + cmbModelo.SelectedValue.ToString() + "') "+
                   " and (nombre_problema like '%" + txtFiltroEspecial.Text.Trim() + "%' or descripcion like '%" + txtFiltroEspecial.Text.Trim() + "%') ";
            dsSpx1.problemas_frecuentes.Clear();
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            dsSpx1.problemas_frecuentes.Merge(bd.ejecutarConsulta(sql).Tables[0]);
        }
    }
}
