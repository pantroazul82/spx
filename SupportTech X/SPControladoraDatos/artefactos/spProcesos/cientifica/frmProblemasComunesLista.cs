using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.cientifica
{
    public partial class frmProblemasComunesLista : Form
    {
        public frmProblemasComunesLista()
        {
            InitializeComponent();
        }

        private void frmProblemasComunesLista_Load(object sender, EventArgs e)
        {
            problemas_comunes_cientificaTableAdapter1.Fill(dsSpx1.problemas_comunes_cientifica);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cientifica.frmProblemaComun fr=new frmProblemaComun();
            if(fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                problemas_comunes_cientificaTableAdapter1.Fill(dsSpx1.problemas_comunes_cientifica);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_problemas_comunes_cientifica"].Text.Trim() == string.Empty) return;

            cientifica.frmProblemaComun fr = new frmProblemaComun();
            fr.codProblemaComun = int.Parse(grdDatos.Columns["cod_problemas_comunes_cientifica"].Text);
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                problemas_comunes_cientificaTableAdapter1.Fill(dsSpx1.problemas_comunes_cientifica);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_problemas_comunes_cientifica"].Text.Trim() == string.Empty) return;

            
            if (MessageBox.Show("Esta seguro de eliminar el registro?","Confirmacion",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                problemas_comunes_cientificaTableAdapter1.DeleteQuery(
                    int.Parse(grdDatos.Columns["cod_problemas_comunes_cientifica"].Text));
                problemas_comunes_cientificaTableAdapter1.Fill(dsSpx1.problemas_comunes_cientifica);
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel ob = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            ob.exportarRapido(grdDatos,"Problemas Comunes",false);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void buscar()
        {
            string sql = @"select * from problemas_comunes_cientifica where solucion_propuesta like '%"+txtBuscador.Text.Trim()+"%'"+
             " OR descripcion_problema_comun like '%"+txtBuscador.Text.Trim()+"%'"+
             " OR titulo_problema_comun like '"+txtBuscador.Text.Trim()+"'";
            
            dsSpx1.problemas_comunes_cientifica.Clear();
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            dsSpx1.problemas_comunes_cientifica.Merge(
            objData.ejecutarConsulta(sql).Tables[0]
            );

        }

        private void txtBuscador_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtBuscador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscar();
            }
        }
    }
}
