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
    public partial class frmListadoTipoAsesoria : Form
    {
        public frmListadoTipoAsesoria()
        {
            InitializeComponent();
        }

        private void btnAddIndicaciones_Click(object sender, EventArgs e)
        {
            frmTipoAsesoria fr = new frmTipoAsesoria();
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tipo_asesoriaTableAdapter1.Fill(dsSpx1.tipo_asesoria);
            }
        }

        private void btnEditIndicaciones_Click(object sender, EventArgs e)
        {
            if (grdDAtos.Columns["cod_tipo_asesoria"].Text.Trim() == string.Empty) return;
            frmTipoAsesoria fr = new frmTipoAsesoria();
            fr.codTipoAsesoria = int.Parse(grdDAtos.Columns["cod_tipo_asesoria"].Text);
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tipo_asesoriaTableAdapter1.Fill(dsSpx1.tipo_asesoria);
            }
        }

        private void btnDelIndicaciones_Click(object sender, EventArgs e)
        {
            if (grdDAtos.Columns["cod_tipo_asesoria"].Text.Trim() == string.Empty) return;
            frmTipoAsesoria fr = new frmTipoAsesoria();
            fr.codTipoAsesoria = int.Parse(grdDAtos.Columns["cod_tipo_asesoria"].Text);
            if (MessageBox.Show("Esta seguro de eliminar este registro?","Confirmacion!",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    tipo_asesoriaTableAdapter1.DeleteQuery(int.Parse(grdDAtos.Columns["cod_tipo_asesoria"].Text));
                tipo_asesoriaTableAdapter1.Fill(dsSpx1.tipo_asesoria);

                }catch(Exception ex){
                    MessageBox.Show("Error al eliminar el registro "+ex.Message);
                }
            }
        }

        private void frmListadoTipoAsesoria_Load(object sender, EventArgs e)
        {
            tipo_asesoriaTableAdapter1.Fill(dsSpx1.tipo_asesoria);
        }
    }
}
